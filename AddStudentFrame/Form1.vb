Imports MySql.Data.MySqlClient

Public Class Form1

    Dim ServerString As String = "Server=localhost;User Id=root;Password='';Database=sample_database;"
    Dim SQLConnection As MySqlConnection = New MySqlConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Public Sub SaveStudentInfo(ByRef SQLStatement As String)

        Dim cmd As MySqlCommand = New MySqlCommand

        With cmd
            .CommandText = SQLStatement
            .CommandType = CommandType.Text
            .Connection = SQLConnection
            .ExecuteNonQuery()
        End With

        SQLConnection.Close()
        MsgBox("Student Info Successfully Added!")
        SQLConnection.Dispose()

        studno.Clear()
        pass.Clear()
        fname.Clear()
        mname.Clear()
        lname.Clear()
        sect.Clear()

    End Sub


    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim SQLStatement As String = "INSERT INTO student(student_number,password,first_name,middle_initial,last_name,section) VALUES('" & studno.Text & "','" & pass.Text & "','" & fname.Text & "','" & mname.Text & "','" & lname.Text & "','" & sect.Text & "')"

        Try

            SaveStudentInfo(SQLStatement)
        Catch ex As Exception
            MsgBox("Student Number Already exists!")
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
End Class
