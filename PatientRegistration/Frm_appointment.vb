Imports System.Data.SqlClient

Public Class Frm_appointment
    Private Sub Frm_appointment_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.Label1.Text = "Welcome Back " & TClass.UserName
            GetAppoinmentData()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Notification")
        End Try
    End Sub
    Dim ConnectionString As String = TClass.connectionString

    Private Sub GetAppoinmentData()
        Try


            Dim connection As New SqlConnection(ConnectionString)

            Dim command As New SqlCommand("SELECT [AppointmentID]
      ,[patientID]
      ,[appointmentDate]
      ,[appointmentTime]
      
,[doctorname],[deptname]
      ,[Details]
  FROM [PatientRegistration].[dbo].[Appointment] where patientID=" & TClass.UserCode & " and appointmentDate='" & Date.Now.ToLongDateString & "'
", connection)
            command.CommandType = CommandType.Text
            Dim adapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable()

            Try
                connection.Open()
                adapter.Fill(dataTable)
                If dataTable.Rows.Count <= 0 Then
                    Label2.Text = "There is No Appoinment Today."
                Else
                    DataGridView1.DataSource = dataTable
                    With DataGridView1
                        .Columns("patientID").Visible = False


                        .Columns("appointmentDate").HeaderText = "Appointment Date"
                        .Columns("appointmentTime").HeaderText = "Appointment Time"
                        .Columns("Details").HeaderText = "Details"
                        .Columns("doctorname").HeaderText = "Doctor name"
                        .Columns("deptname").HeaderText = "Department"
                        .Columns("doctorname").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        .Columns("deptname").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        .Columns("appointmentDate").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        .Columns("appointmentTime").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        .Columns("Details").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells


                    End With
                End If

            Catch ex As Exception
                MsgBox("Error retrieving Appoitment data: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Notification")
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            Dim newappoument As New New_appoinment
            newappoument.ShowDialog()
            GetAppoinmentData()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Notification")
        End Try
    End Sub
End Class