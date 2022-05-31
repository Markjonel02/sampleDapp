Public Class FRMLOGIN
    Private Sub BTNFACEBOOK_Click(sender As Object, e As EventArgs) Handles BTNFACEBOOK.Click
        Process.Start("www.facebook.com")
    End Sub

    Private Sub BTNTWITT_Click(sender As Object, e As EventArgs) Handles BTNTWITT.Click
        Process.Start("www.twitter.com")

    End Sub

    Private Sub BTNINSTA_Click(sender As Object, e As EventArgs) Handles BTNINSTA.Click
        Process.Start("www.Instagram.com")

    End Sub

    'Private Sub BTNSIGNUP_Click(sender As Object, e As EventArgs) Handles BTNSIGNUP.Click

    'End Sub

    Private Sub tmlogin_Tick(sender As Object, e As EventArgs) Handles tmlogin.Tick
        If pnllogin.Location.X > 10 Then
            pnllogin.Location = New Point(pnllogin.Location.X - 10, pnllogin.Location.Y)
        Else
            tmlogin.Stop()
            BTNSIGNIN.Enabled = True
            BTNSIGNUP.Enabled = True
            gbsocial.Visible = True
            pnlloginmain.Visible = True
        End If
    End Sub

    Private Sub tmlogin2_Tick(sender As Object, e As EventArgs) Handles tmlogin2.Tick
        If pnllogin.Location.X < 370 Then
            pnllogin.Location = New Point(pnllogin.Location.X + 10, pnllogin.Location.Y)
        Else
            tmlogin2.Stop()
            BTNSIGNIN.Enabled = True
            BTNSIGNUP.Enabled = True
            gbsocial.Visible = True
            pnlloginmain.Visible = True
        End If
    End Sub

    Private Sub BTNSIGNIN_Click(sender As Object, e As EventArgs) Handles BTNSIGNIN.Click
        tmlogin2.Start()
        BTNSIGNIN.Hide()
        BTNSIGNUP.Show()
        BTNSIGNUP.Enabled = False
        gbsocial.Visible = False
        pnlloginmain.Visible = False
        pnlloginmain.Location = New Point(9, 7)
        Dim i As Integer
        For i = 0 To 0
            pnlloginmain.Controls.RemoveAt(i)
        Next
        Dim D As New UsrCtlSignin()
        D.Parent = pnlloginmain
        D.Show()
        D.Dock = DockStyle.Fill

    End Sub

    Private Sub FRMLOGIN_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim i As Integer
        For i = 0 To 0
            pnlloginmain.Controls.RemoveAt(i)
        Next
        Dim D As New UsrCtlSignin()
        D.Parent = pnlloginmain
        D.Show()
        D.Dock = DockStyle.Fill

    End Sub

    Private Sub BTNSIGNUP_Click(sender As Object, e As EventArgs) Handles BTNSIGNUP.Click
        tmlogin.Start()
        BTNSIGNIN.Show()
        BTNSIGNUP.Hide()
        BTNSIGNIN.Enabled = False
        gbsocial.Visible = False
        pnlloginmain.Visible = False
        pnlloginmain.Location = New Point(257, 8)

        Dim i As Integer
        For i = 0 To 0
            pnlloginmain.Controls.RemoveAt(i)
        Next
        Dim D As New UsrCtrlsignup()
        D.Parent = pnlloginmain
        D.Show()
        D.Dock = DockStyle.Fill
    End Sub
End Class
