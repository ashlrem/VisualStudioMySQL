Imports MySql.Data.MySqlClient

Public Class Form2
    Dim ServerString As String = "Server=localhost;User Id=root;Password='';Database=sample_database;"
    Dim SQLConnection As MySqlConnection = New MySqlConnection

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Dim SQLStatement As String = "SELECT * FROM student WHERE student_number = '" + studno.Text + "'"
        Dim Reader As MySqlDataReader
        Dim MySQLConn = New MySqlConnection
        MySQLConn.ConnectionString = "Server=localhost;User Id=root;Password='';Database=sample_database;"

        Try
            MySQLConn.Open()
            Dim Command = New MySqlCommand(SQLStatement, MySQLConn)
            Reader = Command.ExecuteReader

            While Reader.Read
                pass.Text = Reader.GetString("password")
                fname.Text = Reader.GetString("first_name")
                mname.Text = Reader.GetString("middle_initial")
                lname.Text = Reader.GetString("last_name")
                sect.Text = Reader.GetString("section")
            End While
        Catch ex As Exception
            MsgBox("Student Number does not exists!")
        End Try
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        studno.Clear()
        pass.Clear()
        fname.Clear()
        mname.Clear()
        lname.Clear()
        sect.Clear()
    End Sub

    Public Sub DeleteStudentInfo(ByRef SQLStatement As String)
        Using cmd As MySqlCommand = New MySqlCommand

            With cmd
                .CommandText = SQLStatement
                .CommandType = CommandType.Text
                .Connection = SQLConnection
                .ExecuteNonQuery()
            End With
        End Using

        SQLConnection.Close()
        MsgBox("Student Info Successfully deleted!")
        SQLConnection.Dispose()
        studno.Clear()
        pass.Clear()
        fname.Clear()
        mname.Clear()
        lname.Clear()
        sect.Clear()

    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim SQLStatement As String = "DELETE FROM student WHERE student_number = '" & studno.Text & "'"

        Try
            DeleteStudentInfo(SQLStatement)
        Catch ex As Exception
            MsgBox("Failed to delete student info! :(")
        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SQLConnection.ConnectionString = ServerString

        Try
            If SQLConnection.State = ConnectionState.Closed Then
                SQLConnection.Open()
                MsgBox("Successfully connected to the database!")
            Else
                SQLConnection.Close()
                MsgBox("Failed to connect to the database.")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class