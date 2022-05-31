Public Class FRMMAINMENU
    Private Sub FRMMAINMENU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btndashboard.IdleFillColor = Color.FromArgb(105, 181, 255)
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Dim close = MsgBox("Do you really want to Exit", vbYesNo + vbQuestion, "System Exit")

        If DialogResult.Yes = close Then
            Application.Exit()
        End If
    End Sub
End Class