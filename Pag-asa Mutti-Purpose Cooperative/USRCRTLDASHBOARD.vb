Imports System
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports Bunifu.UI.WinForms.BunifuAnimatorNS
'to import custom font
Imports System.Drawing.Text
Public Class USRCRTLDASHBOARD


    Private Sub USRCRTLDASHBOARD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim pfc As PrivateFontCollection = New PrivateFontCollection
        'pfc.AddFontFile("AdvancedPixelLcd7-yGOq.ttf")
        'LBLCLOCK.Font = New Font(pfc.Families(0), 14)
        'LBLCLOCK.ForeColor = Color.FromArgb(103, 86, 245)

    End Sub

    Private Sub TMCLOCK_Tick(sender As Object, e As EventArgs) Handles TMCLOCK.Tick
        LBLCLOCK.Text = DateTime.Now.ToString("hh:mm:ss tt") ' Time /AM
    End Sub
End Class
