Imports MySql.Data.MySqlClient

Public Class TranscriptList
    Private Sub TranscriptList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTranscriptData()
        AddDeleteAndEditButtonColumns()
    End Sub

    ' Load transcript data into the DataGridView
    Private Sub LoadTranscriptData()
        modDb.openConn("schooldb")
        Dim query As String = "SELECT * FROM transcripts"
        Dim table As New DataTable()

        Try
            Using adapter As New MySqlDataAdapter(query, modDb.conn)
                adapter.Fill(table)
                TranscriptDataGridView.DataSource = table ' Bind the data to the DataGridView
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub

    ' Handle the Add button click
    Private Sub transcriptlist_add_Button_Click(sender As Object, e As EventArgs) Handles transcriptlist_add_Button.Click
        Dim form2 As New AddTranscriptPageforAdmin
        form2.Show()
        Hide()
    End Sub

    ' Handle search functionality
    Private Sub transcriptlist_search_Button_Click(sender As Object, e As EventArgs) Handles transcriptlist_search_Button.Click
        modDb.openConn("schooldb")
        Dim query As String = "SELECT * FROM transcripts WHERE 1=1"

        ' Add search conditions based on input fields
        If Not String.IsNullOrWhiteSpace(transcript_id_TextBox.Text) Then
            query &= " AND transcript_id LIKE @TranscriptID"
        End If
        If Not String.IsNullOrWhiteSpace(transcript_studentid_TextBox.Text) Then
            query &= " AND student_id LIKE @StudentID"
        End If
        If Not String.IsNullOrWhiteSpace(transcript_courseid_TextBox.Text) Then
            query &= " AND course_id LIKE @CourseID"
        End If
        If Not String.IsNullOrWhiteSpace(transcript_instructorid_TextBox.Text) Then
            query &= " AND instructor_id LIKE @InstructorID"
        End If
        If Not String.IsNullOrWhiteSpace(transcript_programid_TextBox.Text) Then
            query &= " AND program_id LIKE @ProgramID"
        End If
        If Not String.IsNullOrWhiteSpace(transcript_semester_TextBox.Text) Then
            query &= " AND semester LIKE @Semester"
        End If
        If Not String.IsNullOrWhiteSpace(transcript_grades_TextBox.Text) Then
            query &= " AND grades LIKE @Grades"
        End If
        If Not String.IsNullOrWhiteSpace(transcript_remarks_TextBox.Text) Then
            query &= " AND remarks LIKE @Remarks"
        End If

        Dim table As New DataTable()

        Try
            Using command As New MySqlCommand(query, modDb.conn)
                If Not String.IsNullOrWhiteSpace(transcript_id_TextBox.Text) Then
                    command.Parameters.AddWithValue("@TranscriptID", "%" & transcript_id_TextBox.Text & "%")
                End If
                If Not String.IsNullOrWhiteSpace(transcript_studentid_TextBox.Text) Then
                    command.Parameters.AddWithValue("@StudentID", "%" & transcript_studentid_TextBox.Text & "%")
                End If
                If Not String.IsNullOrWhiteSpace(transcript_courseid_TextBox.Text) Then
                    command.Parameters.AddWithValue("@CourseID", "%" & transcript_courseid_TextBox.Text & "%")
                End If
                If Not String.IsNullOrWhiteSpace(transcript_instructorid_TextBox.Text) Then
                    command.Parameters.AddWithValue("@InstructorID", "%" & transcript_instructorid_TextBox.Text & "%")
                End If
                If Not String.IsNullOrWhiteSpace(transcript_programid_TextBox.Text) Then
                    command.Parameters.AddWithValue("@ProgramID", "%" & transcript_programid_TextBox.Text & "%")
                End If
                If Not String.IsNullOrWhiteSpace(transcript_semester_TextBox.Text) Then
                    command.Parameters.AddWithValue("@Semester", "%" & transcript_semester_TextBox.Text & "%")
                End If
                If Not String.IsNullOrWhiteSpace(transcript_grades_TextBox.Text) Then
                    command.Parameters.AddWithValue("@Grades", "%" & transcript_grades_TextBox.Text & "%")
                End If
                If Not String.IsNullOrWhiteSpace(transcript_remarks_TextBox.Text) Then
                    command.Parameters.AddWithValue("@Remarks", "%" & transcript_remarks_TextBox.Text & "%")
                End If
                Using adapter As New MySqlDataAdapter(command)
                    adapter.Fill(table)
                    TranscriptDataGridView.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub

    ' Add Delete and Edit button columns to the DataGridView
    Private Sub AddDeleteAndEditButtonColumns()
        If TranscriptDataGridView.Columns("Delete") Is Nothing Then
            Dim deleteButton As New DataGridViewButtonColumn()
            deleteButton.Name = "Delete"
            deleteButton.HeaderText = "Action"
            deleteButton.Text = "Delete"
            deleteButton.UseColumnTextForButtonValue = True
            TranscriptDataGridView.Columns.Add(deleteButton)
        End If
        If TranscriptDataGridView.Columns("Edit") Is Nothing Then
            Dim editButton As New DataGridViewButtonColumn()
            editButton.Name = "Edit"
            editButton.HeaderText = "Action"
            editButton.Text = "Edit"
            editButton.UseColumnTextForButtonValue = True
            TranscriptDataGridView.Columns.Add(editButton)
        End If
    End Sub

    ' Handle cell content click for Delete and Edit actions
    Private Sub TranscriptDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TranscriptDataGridView.CellContentClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = TranscriptDataGridView.Rows(e.RowIndex)
            If e.ColumnIndex = TranscriptDataGridView.Columns("Delete").Index Then
                Dim transcriptId As String = selectedRow.Cells("transcript_id").Value.ToString()
                Dim result = MessageBox.Show($"Are you sure you want to delete the transcript with ID {transcriptId}?",
                                             "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    DeleteTranscript(transcriptId)
                    LoadTranscriptData() ' Refresh data
                End If
            ElseIf e.ColumnIndex = TranscriptDataGridView.Columns("Edit").Index Then
                Dim transcriptId As String = selectedRow.Cells("transcript_id").Value.ToString()
                Dim editForm As New EditTranscriptPage()
                editForm.TranscriptID = transcriptId
                editForm.Show()
                Hide()
            End If
        End If
    End Sub

    ' Delete transcript record
    Private Sub DeleteTranscript(transcriptId As String)
        modDb.openConn("schooldb")
        Dim query As String = "DELETE FROM transcripts WHERE transcript_id = @TranscriptID"
        Try
            Using command As New MySqlCommand(query, modDb.conn)
                command.Parameters.AddWithValue("@TranscriptID", transcriptId)
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Transcript deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Transcript not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If modDb.conn.State = ConnectionState.Open Then modDb.conn.Close()
        End Try
    End Sub

    Private Sub transcript_back_Button_Click(sender As Object, e As EventArgs) Handles transcript_back_Button.Click
        Dim form2 As New AdminPage()
        form2.Show()
        Me.Hide()
    End Sub
End Class
