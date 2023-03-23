Public Class FRMLOGIN
    Private Sub FRMLOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXTPASS.UseSystemPasswordChar = True
    End Sub

    Private Sub CHKEYE_CheckedChanged(sender As Object, e As EventArgs) Handles CHKEYE.CheckedChanged
        If CHKEYE.Checked = True Then
            TXTPASS.UseSystemPasswordChar = False
        Else
            TXTPASS.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub BTNLOGIN_Click(sender As Object, e As EventArgs) Handles BTNLOGIN.Click
        If TXTUSN.Text = Nothing And TXTPASS.Text = Nothing Then
            MsgBox("All fields are required", vbCritical + vbOKOnly, "Error login")
            TXTUSN.Clear()
            TXTPASS.Clear()
            TXTUSN.Focus()
        ElseIf TXTUSN.Text = "mark" And TXTPASS.Text = "123" Then
            MsgBox("Welcome" + TXTUSN.Text, vbOKOnly, "Login Success")
            FRMMAIN.Show()
            FRMMAIN.LBLNAME.Text = TXTUSN.Text
            FRMMAIN.LBLUST.Text = "Admin"

        Else
            MsgBox("Username or password is incorrect")
            TXTUSN.Clear()
            TXTPASS.Clear()
            TXTUSN.Focus()
        End If


    End Sub


End Class