Imports MySql.Data.MySqlClient

Public Class ConfigSettings
    Private Sub ConfigSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Server_TextBox.Text = modDb.db_server
        UID_TextBox.Text = modDb.db_uid
        Password_TextBox.Text = modDb.db_pwd
        Database_TextBox.Text = modDb.db_name
    End Sub

    Private Sub Save_Button_Click(sender As Object, e As EventArgs) Handles Save_Button.Click
        Try
            modDb.db_server = Server_TextBox.Text
            modDb.db_uid = UID_TextBox.Text
            modDb.db_pwd = Password_TextBox.Text
            modDb.db_name = Database_TextBox.Text


            MessageBox.Show("Configuration updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error saving configuration: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub

End Class
