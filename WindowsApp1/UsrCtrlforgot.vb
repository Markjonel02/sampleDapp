Public Class UsrCtrlforgot
    Private Sub Guna2ShadowPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2ShadowPanel1.Paint

    End Sub

    Private Sub TXTNEWPASS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTNEWPASS.KeyPress
        If TXTNEWPASS.Text = String.Empty Then
            TXTCONFIRMPASS.Text = ""

        End If
    End Sub

    Private Sub BTNFORGOT_Click(sender As Object, e As EventArgs) Handles BTNFORGOT.Click
        If TXTNEWPASS.Text = "" Or TXTCONFIRMPASS.Text = "" Or TXTCURRENTPASS.Text = "" Then
            MsgBox("All fields are required!", vbOKOnly + vbCritical)
            TXTCONFIRMPASS.Text = ""
            TXTCURRENTPASS.Text = ""
            TXTNEWPASS.Text = ""

            Exit Sub
        End If
        If TXTNEWPASS.Text <> TXTCONFIRMPASS.Text Then
            MsgBox("Ooops the password you type is not matched!", vbOKOnly + vbCritical, "Error")
            TXTCONFIRMPASS.Text = ""
            TXTCURRENTPASS.Text = ""
            TXTNEWPASS.Text = ""
            'Code for update
            opencon()
            cmd.CommandText = "Update tbl_user set username=@usn, password=@pw, newpass=@np, confirmpassword=@cpw  where username= @usn"
            With cmd.Parameters
                .Clear()
                .AddWithValue("np", TXTNEWPASS.Text)
                .AddWithValue("cpw", TXTCONFIRMPASS.Text)

            End With
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("changing password completed!", vbOKOnly + vbCritical)
            TXTCONFIRMPASS.Text = ""
            TXTCURRENTPASS.Text = ""
            TXTNEWPASS.Text = ""
        End If
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click

        Dim i As Integer
        For i = 0 To 0
            FRMLOGIN.pnlloginmain.Controls.RemoveAt(i)
        Next
        Dim D As New UsrCtlSignin()
        D.Parent = FRMLOGIN.pnlloginmain
        D.Show()
        D.Dock = DockStyle.Fill

    End Sub

    Private Sub TXTCURRENTPASS_TextChanged(sender As Object, e As EventArgs) Handles TXTCURRENTPASS.TextChanged
        opencon()
        cmd.CommandText = "select password from tbl_user where username= '" & TXTUSN.Text & "'"
        Dim pass As String = cmd.ExecuteScalar()
        If pass = TXTCURRENTPASS.Text Then
            lblcurrentpass.Text = "ok"
            lblcurrentpass.ForeColor = Color.Lime
            lblcurrentpass.Visible = True

        Else
            lblcurrentpass.Text = "wrong"
            lblcurrentpass.ForeColor = Color.Red
            lblcurrentpass.Visible = True
        End If
        If TXTCURRENTPASS.Text = "" Then
            lblcurrentpass.Visible = False
        End If
        con.Close()
    End Sub

    Private Sub TXTCONFIRMPASS_TextChanged(sender As Object, e As EventArgs) Handles TXTCONFIRMPASS.TextChanged
        If TXTNEWPASS.Text = TXTCONFIRMPASS.Text Then
            lblconfirmpass.Text = "Matched!"
            lblconfirmpass.ForeColor = Color.Lime

            lblconfirmpass.Visible = True

        Else
            lblconfirmpass.Text = "Incorrect "
            lblconfirmpass.ForeColor = Color.Red
            lblconfirmpass.Visible = True
        End If
        If TXTNEWPASS.Text = "" Or TXTCONFIRMPASS.Text = "" Then
            lblconfirmpass.Visible = False
        End If
        con.Close()
    End Sub

    Private Sub UsrCtrlforgot_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblconfirmpass.Visible = False
        lblcurrentpass.Visible = False

    End Sub
End Class
