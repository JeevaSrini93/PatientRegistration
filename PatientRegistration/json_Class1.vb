Imports Newtonsoft.Json

Public Class json_Class1

    ' Function to get the JSON string (corrected duplicate entry and casing)
    Private Function GetJsonString() As String
        Return "{
            ""Name"": ""Sample General Hospital"",
            ""Address"": ""123 Main Street, Cityville"",
            ""Departments"": [
                {
                    ""Name"": ""Cardiology"",
                    ""Doctors"": [
                        {
                            ""Id"": 101,
                            ""Name"": ""Dr. John Smith"",
                            ""Specialization"": ""Cardiologist"",
                            ""Experience"": ""10 years""
                        },
                        {
                            ""Id"": 102,
                            ""Name"": ""Dr. Emily Johnson"",
                            ""Specialization"": ""Cardiac Surgeon"",
                            ""Experience"": ""8 years""
                        }
                    ]
                },
                {
                    ""Name"": ""Orthopedics"",
                    ""Doctors"": [
                        {
                            ""Id"": 201,
                            ""Name"": ""Dr. Michael Davis"",
                            ""Specialization"": ""Orthopedic Surgeon"",
                            ""Experience"": ""12 years""
                        },
                        {
                            ""Id"": 202,
                            ""Name"": ""Dr. Sarah Miller"",
                            ""Specialization"": ""Sports Medicine Specialist"",
                            ""Experience"": ""7 years""
                        }
                    ]
                },
                {
                    ""Name"": ""Pediatrics"",
                    ""Doctors"": [
                        {
                            ""Id"": 301,
                            ""Name"": ""Dr. Mark Wilson"",
                            ""Specialization"": ""Pediatrician"",
                            ""Experience"": ""9 years""
                        },
                        {
                            ""Id"": 302,
                            ""Name"": ""Dr. Jennifer Lee"",
                            ""Specialization"": ""Pediatric Surgeon"",
                            ""Experience"": ""6 years""
                        }
                    ]
                }
            ]
        }"
    End Function

    ' Function to deserialize the JSON string and get hospital data
    Private Function GetHospitalData() As Hospital
        Dim jsonString As String = GetJsonString()
        Return JsonConvert.DeserializeObject(Of Hospital)(jsonString)
    End Function

    ' Function to populate ComboBox with department names
    Public Sub PopulateComboBox(comboBox As ComboBox)
        Dim hospitalData As Hospital = GetHospitalData()
        If hospitalData IsNot Nothing AndAlso hospitalData.Departments IsNot Nothing Then
            For Each department In hospitalData.Departments
                comboBox.Items.Add(department.Name)
            Next
        Else
            ' Optional: Handle potential errors (e.g., empty JSON string)
            MsgBox("Error: Unable to populate combobox.", MsgBoxStyle.Information)
        End If
    End Sub
    'Public Sub PopulateDoctorComboBox(doctorComboBox As ComboBox, selectedDepartment As String)
    '    Dim hospitalData As Hospital = GetHospitalData()
    '    If hospitalData IsNot Nothing AndAlso hospitalData.Departments IsNot Nothing Then
    '        doctorComboBox.Items.Clear()  ' Clear existing items before adding new ones
    '        For Each department In hospitalData.Departments
    '            If department.Name = selectedDepartment Then
    '                For Each doctor In department.Doctors
    '                    doctorComboBox.Items.Add(doctor.Name, doctor.Id)
    '                Next
    '                Exit For ' Exit loop after finding matching department
    '            End If
    '        Next
    '    Else
    '        ' Optional: Handle potential errors (e.g., empty JSON string)
    '        MsgBox("Error: Unable to populate doctor combobox.", MsgBoxStyle.Information)
    '    End If
    'End Sub
    Public Sub PopulateDoctorComboBox(doctorComboBox As ComboBox, selectedDepartment As String)
        Dim hospitalData As Hospital = GetHospitalData()
        If hospitalData IsNot Nothing AndAlso hospitalData.Departments IsNot Nothing Then
            doctorComboBox.Items.Clear()
            Dim doctorNameToId As New Dictionary(Of String, Integer)  ' Create dictionary for name-ID mapping

            For Each department In hospitalData.Departments
                If department.Name = selectedDepartment Then
                    For Each doctor In department.Doctors
                        doctorComboBox.Items.Add(doctor.Name)
                        doctorNameToId.Add(doctor.Name, doctor.Id)
                    Next
                    Exit For
                End If
            Next


            'If doctorComboBox.SelectedIndex >= 0 Then  ' Check if an item is selected
            '    Dim selectedName As String = doctorComboBox.SelectedItem.ToString()
            '    If doctorNameToId.ContainsKey(selectedName) Then
            '        Dim doctorId As Integer = doctorNameToId(selectedName)
            '        ' Use doctorId as needed (e.g., display in a message box)
            '        New_appoinment.doctorid = doctorId
            '    End If
            'End If
        Else
            ' Optional: Handle potential errors (e.g., empty JSON string)
            MsgBox("Error: Unable to populate doctor combobox.", MsgBoxStyle.Information)
        End If
    End Sub
End Class

Public Class Hospital
    Public Property Name As String  ' Adjusted casing for property names
    Public Property Address As String
    Public Property Departments As List(Of Department)
End Class

Public Class Department
    Public Property Name As String
    Public Property Doctors As List(Of Doctor)
End Class

Public Class Doctor
    Public Property Id As Integer
    Public Property Name As String
    Public Property Specialization As String
    Public Property Experience As String
End Class
