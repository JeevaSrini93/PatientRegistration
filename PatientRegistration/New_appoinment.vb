Imports System.Data.SqlClient

Public Class New_appoinment
    Dim jsonClass As New json_Class1()
    Private Sub New_appoinment_Load(sender As Object, e As EventArgs) Handles Me.Load
        'ComboBox1.DataSource = modu
        Try
            dept_ComboBox.Items.Clear()  ' Clear existing items

            App_DateTimePicker.MinDate = Date.Now
            app_timeDateTimePicker.MinDate = DateTime.Now
            jsonClass.PopulateComboBox(dept_ComboBox)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Notification")
        End Try


    End Sub
    Public Shared doctorid As Integer = 0
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dept_ComboBox.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles dept_ComboBox.SelectedValueChanged
        Try
            doctorid = 0
            doc_ComboBox.Items.Clear()
            jsonClass.PopulateDoctorComboBox(doc_ComboBox, dept_ComboBox.Text)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Notification")
        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles doc_ComboBox.SelectedIndexChanged

    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            If dept_ComboBox.Text.Trim.Length = 0 Then
                MsgBox("Please Select the Department", MsgBoxStyle.Information, "Notification")
                Exit Sub
            End If
            If doc_ComboBox.Text.Trim.Length = 0 Then
                MsgBox("Please Select the Doctor", MsgBoxStyle.Information, "Notification")
                Exit Sub
            End If
            Dim selectedDateTime As DateTime = CType(app_timeDateTimePicker.Value, DateTime)
            If selectedDateTime < DateTime.Now Then
                If CType(App_DateTimePicker.Value, DateTime) <= DateTime.Now Then
                    MsgBox("Please select a future date and time.", MsgBoxStyle.Exclamation)
                    app_timeDateTimePicker.Value = DateTime.Now
                    Exit Sub
                End If
            End If

                If Txt_details.Text.Trim.Length = 0 Then
                MsgBox("Please Enter the Details", MsgBoxStyle.Information, "Notification")
                Exit Sub
            End If

            Dim appointmentDate As DateTime = App_DateTimePicker.Value.ToLongDateString

            Dim appointmentTime As TimeSpan = TimeSpan.Parse(selectedDateTime.ToLongTimeString)
            Dim doctorName As String = doc_ComboBox.Text
            Dim details As String = Txt_details.Text
            Dim deptName As String = dept_ComboBox.Text

            Insertappontment(TClass.UserCode, appointmentDate, appointmentTime, doctorName, details, deptName)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Notification")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Dim ConnectionString As String = TClass.connectionString
    Private Sub Insertappontment(ByVal patientID As Integer, ByVal appointmentDate As Date, ByVal appointmentTime As TimeSpan, ByVal doctorName As String, ByVal details As String, ByVal deptName As String)
        Dim connection As New SqlConnection(ConnectionString)
        Dim command As New SqlCommand("InsertAppointment", connection)
        command.CommandType = CommandType.StoredProcedure

        ' Add parameters with appropriate data types
        command.Parameters.AddWithValue("@patientID", patientID)
        command.Parameters.AddWithValue("@appointmentDate", appointmentDate)
        command.Parameters.AddWithValue("@appointmentTime", appointmentTime)
        command.Parameters.AddWithValue("@doctorName", doctorName)
        command.Parameters.AddWithValue("@details", details)
        command.Parameters.AddWithValue("@deptName", deptName)

        Try
            connection.Open()
            command.ExecuteNonQuery()
            MsgBox("Appointment added successful!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Error inserting Appointment: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub Btn_cancel_Click(sender As Object, e As EventArgs) Handles Btn_cancel.Click
        Me.Close()
    End Sub
End Class