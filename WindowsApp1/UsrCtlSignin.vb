Public Class UsrCtlSignin
    Dim astat As String = "Active"
    Dim admin As String = "mark"
    Dim Staff As String = "jonel"

    Private Sub chkeyes_CheckedChanged(sender As Object, e As EventArgs) Handles chkeyes.CheckedChanged
        If chkeyes.Checked = False Then
            TXTPASS.UseSystemPasswordChar = True
        Else
            TXTPASS.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub UsrCtlSignin_Load(sender As Object, e As EventArgs) Handles Me.Load
        TXTPASS.UseSystemPasswordChar = True
        FRMLOGIN.BTNSIGNIN.Visible = True

    End Sub

    Private Sub BTNLOGIN_Click(sender As Object, e As EventArgs) Handles BTNLOGIN.Click
        Dim stat = lbluserstat.Text
        If TXTUSN.Text = "" Or TXTPASS.Text = "" Then
            MsgBox("all fields are required ", vbOKOnly + vbCritical, "Error Login")
            TXTPASS.Text = ""
            TXTUSN.Text = ""
            TXTUSN.Focus()
            lbluserstat.Text = "you must fill the  require field "
            lbluserstat.Show()

        Else
            opencon()
            cmd.CommandText = "Select * from tbl_user where username = '" & TXTUSN.Text & "' and password = '" & TXTPASS.Text & "' and status = '" & astat & "'"
            cmd.ExecuteNonQuery()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()

                If dr(2) = admin Then
                    'Act = "Logged-in"
                    'ACTLOG()
                    'A = TXTUSN.Text
                    FRMMAINMENU.lblusrname.Text = "Admin"
                    FRMMAINMENU.lblname.Text = "mark"
                    FRMMAINMENU.Show()
                ElseIf dr(2) = Staff Then
                    'Act = "Logged-in"
                    'ACTLOG()
                    'A = TXTUSN.Text
                    FRMMAINMENU.lblusrname.Text = "Staff"
                    FRMMAINMENU.lblname.Text = "jonel"
                    FRMMAINMENU.Show()
                End If
            End If
            con.Close()
        End If







    End Sub

    Private Sub lblforgot_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblforgot.LinkClicked

        Dim i As Integer
        For i = 0 To 0
            FRMLOGIN.pnlloginmain.Controls.RemoveAt(i)
        Next
        Dim D As New UsrCtrlforgot()
        D.Parent = FRMLOGIN.pnlloginmain
        D.Show()
        D.Dock = DockStyle.Fill

    End Sub


End Class
