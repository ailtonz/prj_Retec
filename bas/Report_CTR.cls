VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
END
Attribute VB_Name = "Report_CTR"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Compare Database

Private Sub Report_Open(Cancel As Integer)

'ImpressoraPadrao Categoria("ImpressoraPadrao")

Printer.TopMargin = 201
Printer.BottomMargin = 201
Printer.LeftMargin = 301
Printer.RightMargin = 201

DoCmd.Maximize

End Sub
