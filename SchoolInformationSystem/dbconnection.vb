Imports MySql.Data.MySqlClient

Module dbconnection
    ' Global IDs
    Public GlobalStudentId As String
    Public GlobalInstructorId As String
    Public GlobalAdminId As String

    ' Connection fields (editable from your "Configuration" screen)
    Public ServerAddress As String = "localhost"
    Public Port As String = "3306"
    Public DatabaseName As String = "school_information_db"
    Public DBUsername As String = "root"
    Public DBPassword As String = ""

    ' Result variables
    Public result As String
    Public cmd As New MySqlCommand
    Public dtadapter As New MySqlDataAdapter
    Public dt As New DataTable

    ' Function to return a new connection object
    Public Function strconnection() As MySqlConnection

        Dim connString As String = $"server={ServerAddress};port={Port};user id={DBUsername};password={DBPassword};database={DatabaseName};"
        Return New MySqlConnection(connString)
    End Function

    ' Test Connection
    Public Function TestConnection() As Boolean
        Try
            Using conn As MySqlConnection = strconnection()
                conn.Open()
                conn.Close()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Connection failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function



End Module
