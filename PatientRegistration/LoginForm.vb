Imports System.Data.SqlClient

Public Class LoginForm



    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If UsernameTextBox.Text.Trim.Length = 0 Then
                MsgBox("Please enter The User Name", MsgBoxStyle.Information, "Notification")
                Exit Sub
            End If
            If PasswordTextBox.Text.Trim.Length = 0 Then
                MsgBox("Please enter The Password", MsgBoxStyle.Information, "Notification")
                Exit Sub
            End If
            If TClass.IsValidPassword(PasswordTextBox.Text) = False Then
                MsgBox("Password should contain Minimum one Upper case letter, one lower case
letter, one number, one special character and total minimum 8 characters.", MsgBoxStyle.Information, "Please enter The valid password")
                Exit Sub
            End If
            GetPatientData()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Notification")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Dim ConnectionString As String = TClass.connectionString
    Private Sub GetPatientData()
        Dim connection As New SqlConnection(ConnectionString)
        Dim decode As String = TClass.Encode(PasswordTextBox.Text)
        Dim command As New SqlCommand("select patientID,firstName,lastName,email,passwordHash from  PatientRegistration where email='" & UsernameTextBox.Text & "' and passwordHash ='" & decode & "' ", connection)
        command.CommandType = CommandType.Text



        Dim adapter As New SqlDataAdapter(command)
        Dim dataTable As New DataTable()

        Try
            connection.Open()
            adapter.Fill(dataTable)
            If dataTable.Rows.Count <= 0 Then
                MsgBox("User Not Found.", MsgBoxStyle.Information, "Notification")
                Exit Sub
            Else
                TClass.UserCode = dataTable(0)("patientID")
                TClass.UserName = dataTable(0)("firstName")
                Dim Main_Form As New Frm_appointment
                Main_Form.Show()
                Me.Hide()
            End If

        Catch ex As Exception
            MsgBox("Error retrieving patient data: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try


    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            Dim reg As New Frm_registration
            reg.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Notification")
        End Try
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.PasswordTextBox.UseSystemPasswordChar = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Notification")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If PasswordTextBox.UseSystemPasswordChar = True Then
                Me.Button1.Image = My.Resources.hide_eye
                Me.PasswordTextBox.UseSystemPasswordChar = False


            Else
                Me.Button1.Image = My.Resources.eye
                Me.PasswordTextBox.UseSystemPasswordChar = True

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Notification")
        End Try
    End Sub
End Class
