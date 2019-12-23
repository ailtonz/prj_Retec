Public Class F_tmp_Agenda


    Private Sub MonthCalendar1_DateChanged(sender As System.Object, e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        MsgBox(MonthCalendar1.SelectionStart)
    End Sub
End Class