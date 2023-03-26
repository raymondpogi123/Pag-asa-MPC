Imports System.IO
Imports System.Drawing.Printing
Public Class USRCRTLCashloanApp
    Private Sub PNLCASHAPPFORM_Click(sender As Object, e As EventArgs) Handles PNLCASHAPPFORM.Click
        PNLCASHAPPFORM.AutoScroll = True
        PNLCASHAPPFORM.VerticalScroll.Visible = True Or PNLCASHAPPFORM.HorizontalScroll.Visible = False
    End Sub

    Private Sub BtnPrintForm_Click(sender As Object, e As EventArgs)

    End Sub

End Class
