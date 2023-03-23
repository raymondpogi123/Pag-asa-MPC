Public Class USRCTRLMEMBERSHIPAPP
    Private Sub USRCTRLMEMBERSHIPAPP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PNLMEMAPP_Click(sender As Object, e As EventArgs) Handles PNLMEMAPP.Click
        PNLMEMAPP.AutoScroll = True
        PNLMEMAPP.VerticalScroll.Visible = True Or PNLMEMAPP.HorizontalScroll.Visible = False
    End Sub

End Class
