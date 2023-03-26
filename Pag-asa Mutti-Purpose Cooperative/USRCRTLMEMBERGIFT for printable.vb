Imports Bunifu.UI.WinForms

Public Class USRCRTLMEMBERGIFT


    Private Sub PNLMEM_Click(sender As Object, e As EventArgs) Handles PNLMEM.Click
        'PNLMEM.AutoScroll = True
        'PNLMEM.VerticalScroll.Visible = True Or PNLMEM.HorizontalScroll.Visible = False

    End Sub

    Private Sub SCGC_Scroll(sender As Object, e As ScrollEventArgs)
        PNLMEM.AutoScroll = True
        PNLMEM.HorizontalScroll.Visible = False
    End Sub

    Private Sub SCGC_MouseEnter(sender As Object, e As EventArgs)
        PNLMEM.AutoScroll = True
        PNLMEM.HorizontalScroll.Visible = False Or PNLMEM.VerticalScroll.Visible = True
    End Sub
End Class
