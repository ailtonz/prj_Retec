Attribute VB_Name = "modResizeForm"
'---------------------------------------------------------------------------------------
' Module    : modResizeForm
' Author    : Jamie Czernik BSc {jamie@jamiessoftware.tk}
' Purpose   : Resizes Microsoft Access forms to fit the current screen resolution.
' Use       : Work on a back-up copy of your application first.
'             Change the constant DESIGN_HORZRES to the horizontal screen resolution
'             used when forms were designed. Change the constant DESIGN_VERTRES to the
'             vertical screen resolution used when forms were designed.
'             Change DESIGN_PIXELS to the DPI used if required.
'             Call ResizeForm Me on the onLoad event for each form (even sub forms).
' Bugs:     : Tab controls and Option Groups are very difficult to handle - see comments
'             throughout code for more information. Scaling forms up works much better
'             than trying to scale forms down. Scaling down will probably distrot fronts.
'             FIX:- Redesign forms to fit lowest resoltion and scale up instead.
'             Continuous sub forms generate random crashes in Access 2002 & later - no fix.
'             Send bug reports to: jamie@jamiessoftware.tk for future fixes.
'             (No immediate support is provided. *Please* check online help, message board
'             and latest version at http://www.jamiessoftware.tk before sending bug reports)
' Test:       Test your application at each possible screen resolution after installing.
' Please    : Consider donating $5 or $10 if you find this code useful by visiting:-
'             http://jamiessoftware.tk/resizeform/rf_download.html
' Credits   : This modResizeForm module was created by Jamie Czernik
'             Contains improvement suggestions/updates from:  Dr. Martin Dumskyj,
'             Nathan Carroll, Wilfrid Underwood & Kyle Hughes.
'             Contains enhancements which fixed some problems in combo boxes, list
'             boxes, and tab controls from: Myke Myers & Chris Garland.
' Updated   : April 2006.
'---------------------------------------------------------------------------------------
Option Compare Database
Option Explicit
'-----------------------------MODULE CONSTANTS & VARIABLES------------------------------
Private Const DESIGN_HORZRES As Long = 1366 '640   '<- CHANGE THIS VALUE TO THE RESOLUTION
                                                'YOU DESIGNED YOUR FORMS IN.
                                                '(e.g. 800 X 600 -> 800)
Private Const DESIGN_VERTRES As Long = 768 '480   '<- CHANGE THIS VALUE TO THE RESOLUTION
                                                'YOU DESIGNED YOUR FORMS IN.
                                                '(e.g. 800 X 600 -> 600)
Private Const DESIGN_PIXELS As Long = 96        '<- CHANGE THIS VALUE TO THE DPI
                                                'SETTING YOU DESIGNED YOUR FORMS IN.
                                                '(If in doubt do not alter the
                                                'DESIGN_PIXELS setting as most
                                                'systems use 96 dpi.)
Private Const WM_HORZRES As Long = 8
Private Const WM_VERTRES As Long = 10
Private Const WM_LOGPIXELSX As Long = 88
Private Const TITLEBAR_PIXELS As Long = 18
Private Const COMMANDBAR_PIXELS As Long = 26
Private Const COMMANDBAR_LEFT As Long = 0
Private Const COMMANDBAR_TOP As Long = 1
Private OrigWindow As tWindow                   'Module level variable holds the
                                                'original window dimensions before
                                                'resize.

Private Type tRect
    left As Long
    Top As Long
    right As Long
    bottom As Long
End Type

Private Type tDisplay
    Height As Long
    Width As Long
    DPI As Long
End Type

Private Type tWindow
    Height As Long
    Width As Long
End Type

Private Type tControl
    Name As String
    Height As Long
    Width As Long
    Top As Long
    left As Long
End Type
'-------------------------- END MODULE CONSTANTS & VARIABLES----------------------------

'------------------------------------API DECLARATIONS-----------------------------------
Private Declare Function WM_apiGetDeviceCaps Lib "gdi32" Alias "GetDeviceCaps" _
(ByVal hdc As Long, ByVal nIndex As Long) As Long

Private Declare Function WM_apiGetDesktopWindow Lib "user32" Alias "GetDesktopWindow" _
() As Long

Private Declare Function WM_apiGetDC Lib "user32" Alias "GetDC" _
(ByVal hwnd As Long) As Long

Private Declare Function WM_apiReleaseDC Lib "user32" Alias "ReleaseDC" _
(ByVal hwnd As Long, ByVal hdc As Long) As Long

Private Declare Function WM_apiGetWindowRect Lib "user32.dll" Alias "GetWindowRect" _
(ByVal hwnd As Long, lpRect As tRect) As Long

Private Declare Function WM_apiMoveWindow Lib "user32.dll" Alias "MoveWindow" _
(ByVal hwnd As Long, ByVal x As Long, ByVal y As Long, ByVal nWidth As Long, _
ByVal nHeight As Long, ByVal bRepaint As Long) As Long

Private Declare Function WM_apiIsZoomed Lib "user32.dll" Alias "IsZoomed" _
(ByVal hwnd As Long) As Long
'--------------------------------- END API DECLARATIONS----------------------------------

'---------------------------------------------------------------------------------------
' Procedure : getScreenResolution
' DateTime  : 27/01/2003
' Author    : Jamie Czernik
' Purpose   : Function returns the current height, width and dpi.
'---------------------------------------------------------------------------------------
Private Function getScreenResolution() As tDisplay

Dim hDCcaps As Long
Dim lngRtn As Long

On Error Resume Next

    'API call get current resolution:-
    hDCcaps = WM_apiGetDC(0) 'Get display context for desktop (hwnd = 0).
    With getScreenResolution
        .Height = WM_apiGetDeviceCaps(hDCcaps, WM_VERTRES)
        .Width = WM_apiGetDeviceCaps(hDCcaps, WM_HORZRES)
        .DPI = WM_apiGetDeviceCaps(hDCcaps, WM_LOGPIXELSX)
    End With
    lngRtn = WM_apiReleaseDC(0, hDCcaps) 'Release display context.
    
End Function

'---------------------------------------------------------------------------------------
' Procedure : getFactor
' DateTime  : 27/01/2003
' Author    : Jamie Czernik
' Purpose   : Function returns the value that the form's/control's height, width, top &
'             left should be multiplied by to fit the current screen resolution.
'---------------------------------------------------------------------------------------
Private Function getFactor(blnVert As Boolean) As Single

Dim sngFactorP As Single

On Error Resume Next

    If getScreenResolution.DPI <> 0 Then
        sngFactorP = DESIGN_PIXELS / getScreenResolution.DPI
    Else
        sngFactorP = 1 'Error with dpi reported so assume 96 dpi.
    End If
    If blnVert Then 'return vertical resolution.
        getFactor = (getScreenResolution.Height / DESIGN_VERTRES) * sngFactorP
    Else 'return horizontal resolution.
        getFactor = (getScreenResolution.Width / DESIGN_HORZRES) * sngFactorP
    End If
    
End Function

'---------------------------------------------------------------------------------------
' Procedure : ReSizeForm
' DateTime  : 27/01/2003
' Author    : Jamie Czernik
' Purpose   : Routine should be called on a form's onOpen or onLoad event.
'---------------------------------------------------------------------------------------
Public Sub ReSizeForm(ByVal frm As Access.Form)

Dim rectWindow As tRect
Dim lngWidth As Long
Dim lngHeight As Long
Dim sngVertFactor As Single
Dim sngHorzFactor As Single
Dim sngFontFactor As Single

On Error Resume Next

    sngVertFactor = getFactor(True)  'Local function returns vertical size change.
    sngHorzFactor = getFactor(False)  'Local function returns horizontal size change.
    'Choose lowest factor for resizing fonts:-
    sngFontFactor = VBA.IIf(sngHorzFactor < sngVertFactor, sngHorzFactor, sngVertFactor)
    Resize sngVertFactor, sngHorzFactor, sngFontFactor, frm 'Local procedure to resize form sections & controls.
    If WM_apiIsZoomed(frm.hwnd) = 0 Then 'Don't change window settings for max'd form.
        Access.DoCmd.RunCommand acCmdAppMaximize 'Maximize the Access Window.
        'Store for dimensions in rectWindow:-
        Call WM_apiGetWindowRect(frm.hwnd, rectWindow)
        'Calculate and store form height and width in local variables:-
        With rectWindow
            lngWidth = .right - .left
            lngHeight = .bottom - .Top
        End With
        'Resize the form window as required (don't resize this for sub forms):-
        If frm.Parent.Name = VBA.vbNullString Then
            Call WM_apiMoveWindow(frm.hwnd, ((getScreenResolution.Width - _
            (sngHorzFactor * lngWidth)) / 2) - getLeftOffset, _
            ((getScreenResolution.Height - (sngVertFactor * lngHeight)) / 2) - _
            getTopOffset, lngWidth * sngHorzFactor, lngHeight * sngVertFactor, 1)
        End If
    End If
    Set frm = Nothing 'Free up resources.
    
End Sub

'---------------------------------------------------------------------------------------
' Procedure : Resize
' DateTime  : 27/01/2003
' Author    : Jamie Czernik
' Purpose   : Routine re-scales the form sections and controls.
'---------------------------------------------------------------------------------------
Private Sub Resize(sngVertFactor As Single, sngHorzFactor As Single, sngFontFactor As _
Single, ByVal frm As Access.Form)

Dim ctl As Access.Control            'Form control variable.
Dim arrCtls() As tControl            'Array of Tab and Option Group control properties.
Dim lngI As Long                     'Loop counter.
Dim lngJ As Long                     'Loop counter.
Dim lngWidth As Long                 'Stores form's new width.
Dim lngHeaderHeight As Long          'Stores header's new height.
Dim lngDetailHeight As Long          'Stores detail's new height.
Dim lngFooterHeight As Long          'Stores footer's new height.
Dim blnHeaderVisible As Boolean      'True if form header visible before resize.
Dim blnDetailVisible As Boolean      'True if form detail visible before resize.
Dim blnFooterVisible As Boolean      'True if form footer visible before resize.
Const FORM_MAX As Long = 31680       'Maximum possible form width & section height.

On Error Resume Next
    
    With frm
        .Painting = False 'Turn off form painting.
        'Calculate form's new with and section heights and store in local variables
        'for later use:-
        lngWidth = .Width * sngHorzFactor
        lngHeaderHeight = .Section(Access.acHeader).Height * sngVertFactor
        lngDetailHeight = .Section(Access.acDetail).Height * sngVertFactor
        lngFooterHeight = .Section(Access.acFooter).Height * sngVertFactor
        'Now maximize the form's width and height while controls are being resized:-
        .Width = FORM_MAX
        .Section(Access.acHeader).Height = FORM_MAX
        .Section(Access.acDetail).Height = FORM_MAX
        .Section(Access.acFooter).Height = FORM_MAX
        'Hiding form sections during resize prevents invalid page fault after
        'resizing column widths for list boxes on forms with a header/footer:-
        blnHeaderVisible = .Section(Access.acHeader).Visible
        blnDetailVisible = .Section(Access.acDetail).Visible
        blnFooterVisible = .Section(Access.acFooter).Visible
        .Section(Access.acHeader).Visible = False
        .Section(Access.acDetail).Visible = False
        .Section(Access.acFooter).Visible = False
    End With
    'Resize array to hold 1 element:-
    ReDim arrCtls(0)
    'Gather properties for Tabs and Option Groups to recify height/width problems:-
    For Each ctl In frm.Controls
        If ((ctl.ControlType = Access.acTabCtl) Or _
        (ctl.ControlType = Access.acOptionGroup)) Then
            With arrCtls(lngI)
                .Name = ctl.Name
                .Height = ctl.Height
                .Width = ctl.Width
                .Top = ctl.Top
                .left = ctl.left
            End With
            lngI = lngI + 1
            ReDim Preserve arrCtls(lngI) 'Increase the size of the array.
        End If
    Next ctl
    'Resize and locate each control:-
    For Each ctl In frm.Controls
        If ctl.ControlType <> Access.acPage Then 'Ignore pages in Tab controls.
            With ctl
                .Height = .Height * sngVertFactor
                .left = .left * sngHorzFactor
                .Top = .Top * sngVertFactor
                .Width = .Width * sngHorzFactor
                .FontSize = .FontSize * sngFontFactor
                'Enhancement by Myke Myers --------------------------------------->
                'Fix certain Combo Box, List Box and Tab control properties:-
                Select Case .ControlType
                    Case Access.acListBox
                        .ColumnWidths = adjustColumnWidths(.ColumnWidths, sngHorzFactor)
                    Case Access.acComboBox
                        .ColumnWidths = adjustColumnWidths(.ColumnWidths, sngHorzFactor)
                        .ListWidth = .ListWidth * sngHorzFactor
                    Case Access.acTabCtl
                        .TabFixedWidth = .TabFixedWidth * sngHorzFactor
                        .TabFixedHeight = .TabFixedHeight * sngVertFactor
                End Select
                '------------------------------------> End enhancement by Myke Myers.
            End With
        End If
    Next ctl
    '********************************************************
    '* Note if scaling form up: If Tab controls or Option   *
    '* Groups are too near the bottom or right side of the  *
    '* form they WILL distort due to the way that Access    *
    '* keeps the child controls within the control frame.   *
    '* Try moving these controls left or up if possible.    *
    '* The opposite is true for scaling down so in this     *
    '* case try moving these controls right or down.        *
    '********************************************************
    'Now try to rectify Tabs and Option Groups height/widths:-
    For lngJ = 0 To lngI
        With frm.Controls.Item(arrCtls(lngJ).Name)
            .left = arrCtls(lngJ).left * sngHorzFactor
            .Top = arrCtls(lngJ).Top * sngVertFactor
            .Height = arrCtls(lngJ).Height * sngVertFactor
            .Width = arrCtls(lngJ).Width * sngHorzFactor
        End With
    Next lngJ
    'Now resize height for each section and form width using stored values:-
    With frm
        .Width = lngWidth
        .Section(Access.acHeader).Height = lngHeaderHeight
        .Section(Access.acDetail).Height = lngDetailHeight
        .Section(Access.acFooter).Height = lngFooterHeight
        'Now unhide form sections:-
        .Section(Access.acHeader).Visible = blnHeaderVisible
        .Section(Access.acDetail).Visible = blnDetailVisible
        .Section(Access.acFooter).Visible = blnFooterVisible
        .Painting = True 'Turn form painting on.
    End With
    Erase arrCtls 'Destory array.
    Set ctl = Nothing 'Free up resources.

End Sub

'---------------------------------------------------------------------------------------
' Procedure : getTopOffset
' DateTime  : 27/01/2003
' Author    : Jamie Czernik
' Purpose   : Function returns the total size in pixels of menu/toolbars at the top of
'             the Access window allowing the form to be positioned in the centre of the
'             screen.
'---------------------------------------------------------------------------------------
Private Function getTopOffset() As Long

Dim cmdBar As Object
Dim lngI As Long

On Error GoTo err

     For Each cmdBar In Application.CommandBars
        If ((cmdBar.Visible = True) And (cmdBar.Position = COMMANDBAR_TOP)) Then
            lngI = lngI + 1
        End If
     Next cmdBar
     getTopOffset = (TITLEBAR_PIXELS + (lngI * COMMANDBAR_PIXELS))

exit_fun:
    Exit Function
    
err:
    'Assume only 1 visible command bar plus the title bar:
    getTopOffset = TITLEBAR_PIXELS + COMMANDBAR_PIXELS
    Resume exit_fun
     
End Function

'---------------------------------------------------------------------------------------
' Procedure : getLeftOffset
' DateTime  : 27/01/2003
' Author    : Jamie Czernik
' Purpose   : Function returns the total size in pixels of menu/toolbars at the left of
'             the Access window allowing the form to be positioned in the centre of the
'             screen.
'---------------------------------------------------------------------------------------
Private Function getLeftOffset() As Long

Dim cmdBar As Object
Dim lngI As Long

On Error GoTo err

     For Each cmdBar In Application.CommandBars
        If ((cmdBar.Visible = True) And (cmdBar.Position = COMMANDBAR_LEFT)) Then
            lngI = lngI + 1
        End If
     Next cmdBar
     getLeftOffset = (lngI * COMMANDBAR_PIXELS)

exit_fun:
    Exit Function
    
err:
    'Assume no visible command bars:-
    getLeftOffset = 0
    Resume exit_fun
     
End Function
 
'---------------------------------------------------------------------------------------
' Procedure : adjustColumnWidths
' DateTime  : 27/01/2003
' Author    : Myke Myers [Split() replacement for Access 97 by Jamie Czernik]
' Purpose   : Adjusts column widths for list boxes and combo boxes.
' Called By : modResize/Resize().
' Event Modification Information:
'   1. Chris Garland    02/07/2006
'   The event was modified to check if there is any column size entry, and if not, the
'   property is left blank on the control.
'---------------------------------------------------------------------------------------
Private Function adjustColumnWidths(strColumnWidths As String, sngFactor As Single) As String
On Error GoTo Err_adjustColumnWidths

Dim astrColumnWidths() As String                'Array to hold the individual column widths
Dim strTemp As String                           'Holds the recombined columnwidths string
Dim lngI As Long                                'For Loop counter
Dim lngJ As Long                                'Columnwidths counter

    'Get the column widths:-
    'THIS CODE BY JAMIE CZERNIK------------------------------------------->
    'Replace the Split() function as not available in Access 97:
    'Sets the array to one entry.
    ReDim astrColumnWidths(0)
    'Loops through each character in the Column Widths String passed in by the calling code.
    For lngI = 1 To VBA.Len(strColumnWidths)
        'Looks for each semicolon, which is what separates the individual Column Widths.
        Select Case VBA.Mid(strColumnWidths, lngI, 1)
            'If a semicolon is not found, the character is added to the any characters
            ' already in the columnwidths entry in the array.  If it is found, the
            ' Columnwidths Counter is incremented by one and the array is increased by
            ' one while retaining entered data so that the next columnwidth can be entered.
            Case Is <> ";"
                astrColumnWidths(lngJ) = astrColumnWidths(lngJ) & VBA.Mid( _
                strColumnWidths, lngI, 1)
            Case ";"
                lngJ = lngJ + 1
                ReDim Preserve astrColumnWidths(lngJ) 'Resize the array.
        End Select
    Next lngI
    'Resets the loop counter to 0.
    lngI = 0
    '--------------------------------------------> END CODE BY JAMIE CZERNIK.
    'Access 2000/2002 users can uncomment the line below and remove the split() code
    'replacement above.
    'astrColumnWidths = Split(strColumnWidths, ";")'Available in Access 2000/2002 only
    strTemp = VBA.vbNullString 'Sets the temp variable to a null string
    'Loops through the all the columnwidths in the array, converting them to the new sizes
    ' (using the Width Size Conversion Factor that was passed-in), and recombining them
    ' into a single string to pass back to the calling code. (If there is no Column Width,
    ' the value is left blank.)
    Do Until lngI > UBound(astrColumnWidths)
        If Not IsNull(astrColumnWidths(lngI)) And astrColumnWidths(lngI) <> "" Then
            strTemp = strTemp & CSng(astrColumnWidths(lngI)) * sngFactor & ";"
        End If
        lngI = lngI + 1
    Loop
    'Returns the combined columnwidths string to the calling code.
    adjustColumnWidths = strTemp
    Erase astrColumnWidths 'Destroy array.
    
Exit_adjustColumnWidths:
    On Error Resume Next
    Exit Function

Err_adjustColumnWidths:
    Erase astrColumnWidths 'Destroy array.
    Resume Exit_adjustColumnWidths
    
End Function

'---------------------------------------------------------------------------------------
' Procedure : getOrigWindow
' DateTime  : 27/01/2003
' Author    : Jamie Czernik
' Purpose   : Routine stores the original window dimensions before resizing call it
'             when form loads. (before calling ResizeForm Me!).
'             Call it: Form_Load()
'             [More info in "Important Points" - point 5 - in help file.]
'---------------------------------------------------------------------------------------
Public Sub getOrigWindow(frm As Access.Form)

On Error Resume Next

    OrigWindow.Height = frm.WindowHeight
    OrigWindow.Width = frm.WindowWidth

End Sub

'---------------------------------------------------------------------------------------
' Procedure : RestoreWindow
' DateTime  : 27/01/2003
' Author    : Jamie Czernik
' Purpose   : Routine restores the original window dimensions call it when form closes.
'             Call it: Form_Close()
'             [More info in "Important Points" - point 5 - in help file.]
'---------------------------------------------------------------------------------------
Public Sub RestoreWindow()

On Error Resume Next

    Access.DoCmd.MoveSize , , OrigWindow.Width, OrigWindow.Height
    Access.DoCmd.Save
    
End Sub


