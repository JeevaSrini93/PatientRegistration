Imports System.IO

Imports System.Text.RegularExpressions
Imports System.Text

Imports System.Security.Cryptography

Public Class TClass
    Public Shared UserCode As Integer
    Public Shared UserName As String
    Public Shared Function IsValidPassword(ByVal password As String) As Boolean
        ' Regular expressions for checking password criteria
        Dim upperCaseRegex As New Regex("[A-Z]")
        Dim lowerCaseRegex As New Regex("[a-z]")
        Dim digitRegex As New Regex("\d")
        Dim specialCharacterRegex As New Regex("[^a-zA-Z0-9]")

        ' Check if password meets all criteria
        If password.Length >= 8 AndAlso
           upperCaseRegex.IsMatch(password) AndAlso
           lowerCaseRegex.IsMatch(password) AndAlso
           digitRegex.IsMatch(password) AndAlso
           specialCharacterRegex.IsMatch(password) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared connectionString As String = "Data Source=localhost;Initial Catalog=PatientRegistration;Integrated Security=True;"

    Public Shared Function IsValidEmail(ByVal email As String) As Boolean
        ' Regular expression pattern for email validation
        Dim pattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Dim regex As New Regex(pattern)

        ' Check if email matches the pattern
        If regex.IsMatch(email) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared Function Encode(ByVal Value As String) As String
        Try
            Dim encData_byte As Byte() = New Byte(Value.Length - 1) {}
            encData_byte = System.Text.Encoding.UTF8.GetBytes(Value)
            Dim encodedData As String = Convert.ToBase64String(encData_byte)
            Return encodedData
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function Decode(ByVal Value As String) As String
        Try


            Dim encoder As New System.Text.UTF8Encoding()
            Dim utf8Decode As System.Text.Decoder = encoder.GetDecoder()
            Dim todecode_byte As Byte() = Convert.FromBase64String(Value)
            Dim charCount As Integer = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length)
            Dim decoded_char As Char() = New Char(charCount - 1) {}
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0)
            Dim result As New String(decoded_char)
            Return result


        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
