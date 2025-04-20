Imports MySql.Data.MySqlClient

Module dbconnection
    ' Function to return a new connection object
    Public Function strconnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;username=root;password=;database=school_information_db")
    End Function

    ' Shared objects (optional if needed elsewhere)
    Public result As String
    Public cmd As New MySqlCommand
    Public dtadapter As New MySqlDataAdapter
    Public dt As New DataTable
End Module
