Public Class UsrCtrlsignup


    Private Sub BTNSIGNUP_Click(sender As Object, e As EventArgs) Handles BTNSIGNUP.Click
        If TXTUSN.Text = String.Empty Or TXTNAME.Text = String.Empty Or TXTPASS.Text = String.Empty Or TXTCONFIRMPASS.Text = String.Empty Then
            MsgBox("All fields are reqiured", vbOKOnly + vbExclamation, "Error singing up")
            TXTUSN.Text = String.Empty
            TXTNAME.Text = String.Empty
            TXTPASS.Text = String.Empty
            TXTCONFIRMPASS.Text = String.Empty
            TXTUSN.Focus()
        ElseIf TXTPASS.Text = TXTCONFIRMPASS.Text Then
            MsgBox("Welcome", vbOKOnly)
            TXTUSN.Text = String.Empty
            TXTNAME.Text = String.Empty
            TXTPASS.Text = String.Empty
            TXTCONFIRMPASS.Text = String.Empty
            TXTUSN.Focus()

        ElseIf TXTPASS.Text IsNot TXTCONFIRMPASS.Text Then
            LBLMSGEERROR.Text = "password doesn't matched"
            TXTUSN.Text = String.Empty
            TXTNAME.Text = String.Empty
            TXTPASS.Text = String.Empty
            TXTCONFIRMPASS.Text = String.Empty
            TXTUSN.Focus()

        End If
    End Sub
End Class
