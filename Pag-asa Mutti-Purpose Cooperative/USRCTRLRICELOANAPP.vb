Public Class USRCTRLRICELOANAPP
    Private Sub PNLMEM_Click(sender As Object, e As EventArgs) Handles PNLRICE.Click
        PNLRICE.AutoScroll = True
        PNLRICE.VerticalScroll.Visible = False Or PNLRICE.HorizontalScroll.Visible = False

    End Sub
End Class
