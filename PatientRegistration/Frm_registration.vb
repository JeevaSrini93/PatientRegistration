Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class Frm_registration
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Frm_registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Dob_DateTimePicker.MaxDate = Date.Now
            Me.PasswordTextBox.UseSystemPasswordChar = True
            Me.Txt_reEnterpassword.UseSystemPasswordChar = True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Notification")
        End Try
    End Sub

    Private Sub Frm_registration_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Notification")
        End Try
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            If Txt_firstname.Text.Trim.Length = 0 Then
                MsgBox("Please enter the First Name", MsgBoxStyle.Information, "Notification")
                Exit Sub
            End If
            If Txt_lastname.Text.Trim.Length = 0 Then
                MsgBox("Please enter the Last Name", MsgBoxStyle.Information, "Notification")
                Exit Sub
            End If
            If Txt_email.Text.Trim.Length = 0 Then
                MsgBox("Please enter the EMail", MsgBoxStyle.Information, "Notification")
                Exit Sub
            End If
            If TClass.IsValidEmail(Txt_email.Text) = False Then
                MsgBox("Please enter the Valid EMail Address", MsgBoxStyle.Information, "Notification")
                Exit Sub
            End If
            If Txt_phone.Text.Trim.Length = 0 OrElse Txt_phone.Text.Length <> 10 Then
                MsgBox("Please enter a valid 10-digit phone number.", MsgBoxStyle.Information, "Notification")
                Exit Sub
            End If
            If TClass.IsValidPassword(PasswordTextBox.Text) = False Then
                MsgBox("Password should contain Minimum one Upper case letter, one lower case
letter, one number, one special character and total minimum 8 characters.", MsgBoxStyle.Information, "Please enter The valid password")
                Exit Sub
            End If
            If PasswordTextBox.Text <> Txt_reEnterpassword.Text Then
                MsgBox("Re-Enter password Not Match.", MsgBoxStyle.Information, "Notification")
                Exit Sub
            End If
            Dim firstName As String = Txt_firstname.Text
            Dim lastName As String = Txt_lastname.Text
            Dim email As String = Txt_email.Text
            Dim phoneNumber As String = Txt_phone.Text
            Dim dateOfBirth As DateTime = Dob_DateTimePicker.Value
            Dim passwordHash As String = TClass.Encode(PasswordTextBox.Text)

            InsertPatient(firstName, lastName, email, phoneNumber, dateOfBirth, passwordHash)

            ' Clear form fields after successful insertion (optional)
            Txt_firstname.Text = ""
            Txt_lastname.Text = ""
            Txt_phone.Text = ""
            PasswordTextBox.Text = ""
            Txt_reEnterpassword.Text = ""
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Notification")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If PasswordTextBox.UseSystemPasswordChar = True Then
                Me.Button1.Image = My.Resources.hide_eye
                Me.PasswordTextBox.UseSystemPasswordChar = False
                Me.Txt_reEnterpassword.UseSystemPasswordChar = False

            Else
                Me.Button1.Image = My.Resources.eye
                Me.PasswordTextBox.UseSystemPasswordChar = True
                Me.Txt_reEnterpassword.UseSystemPasswordChar = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Notification")
        End Try
    End Sub
    Dim ConnectionString As String = TClass.connectionString
    Private Sub InsertPatient(ByVal firstName As String, ByVal lastName As String, ByVal email As String,
                            ByVal phoneNumber As String, ByVal dateOfBirth As DateTime, ByVal passwordHash As String)
        Dim connection As New SqlConnection(ConnectionString)
        Dim command As New SqlCommand("InsertPatient", connection)
        command.CommandType = CommandType.StoredProcedure

        ' Add parameters with appropriate data types
        command.Parameters.AddWithValue("@firstName", firstName)
        command.Parameters.AddWithValue("@lastName", lastName)
        command.Parameters.AddWithValue("@email", email)
        command.Parameters.AddWithValue("@phoneNumber", phoneNumber)
        command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth)
        command.Parameters.AddWithValue("@passwordHash", passwordHash)

        Try
            connection.Open()
            command.ExecuteNonQuery()
            MsgBox("Patient registration successful!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Error inserting patient: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub Txt_phone_TextChanged(sender As Object, e As EventArgs) Handles Txt_phone.TextChanged

    End Sub

    Private Sub Txt_phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_phone.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) AndAlso Asc(ch) <> 8 AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub PasswordTextBox_TextChanged_1(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub Btn_cancel_Click(sender As Object, e As EventArgs) Handles Btn_cancel.Click
        Me.Close()
    End Sub
End Class