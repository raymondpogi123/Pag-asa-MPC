Imports Bunifu.UI.WinForms

Public Class USRCRTLMEMBERGIFT

    Private Sub USRCRTLMEMBERGIFT_Load(sender As Object, e As EventArgs) Handles Me.Load
        PNLMEM.AutoScroll = True
        PNLMEM.VerticalScroll.Visible = True Or PNLMEM.HorizontalScroll.Visible = False
    End Sub

    Private Sub Guna2VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles Guna2VScrollBar1.Scroll

    End Sub
End Class
