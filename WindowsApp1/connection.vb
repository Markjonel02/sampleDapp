Imports MySql.Data

Module connection

    Public con As New MySqlClient.MySqlConnection
    Public cmd As New MySqlClient.MySqlCommand
    Public dr As MySqlClient.MySqlDataReader
    Public Act As String
    Sub opencon()
        con.ConnectionString = My.Settings.sample_userdbConnectionString
        con.Open()
        cmd.Connection = con
    End Sub
End Module
