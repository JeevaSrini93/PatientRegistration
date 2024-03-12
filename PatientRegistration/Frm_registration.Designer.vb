<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_registration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Dob_DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Txt_phone = New System.Windows.Forms.TextBox()
        Me.Txt_email = New System.Windows.Forms.TextBox()
        Me.Txt_lastname = New System.Windows.Forms.TextBox()
        Me.Txt_firstname = New System.Windows.Forms.TextBox()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.Btn_cancel = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Txt_reEnterpassword = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registration Form"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&First Name *"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "&Last Name *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "&E-Mail *"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "&Phone number *"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "&DOB *"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "&New password*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(44, 222)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "&ReEnter password*"
        '
        'Dob_DateTimePicker
        '
        Me.Dob_DateTimePicker.Location = New System.Drawing.Point(180, 165)
        Me.Dob_DateTimePicker.Name = "Dob_DateTimePicker"
        Me.Dob_DateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Dob_DateTimePicker.TabIndex = 10
        '
        'Txt_phone
        '
        Me.Txt_phone.Location = New System.Drawing.Point(180, 139)
        Me.Txt_phone.MaxLength = 10
        Me.Txt_phone.Name = "Txt_phone"
        Me.Txt_phone.Size = New System.Drawing.Size(200, 20)
        Me.Txt_phone.TabIndex = 8
        '
        'Txt_email
        '
        Me.Txt_email.Location = New System.Drawing.Point(180, 114)
        Me.Txt_email.MaxLength = 255
        Me.Txt_email.Name = "Txt_email"
        Me.Txt_email.Size = New System.Drawing.Size(200, 20)
        Me.Txt_email.TabIndex = 6
        '
        'Txt_lastname
        '
        Me.Txt_lastname.Location = New System.Drawing.Point(180, 91)
        Me.Txt_lastname.MaxLength = 50
        Me.Txt_lastname.Name = "Txt_lastname"
        Me.Txt_lastname.Size = New System.Drawing.Size(200, 20)
        Me.Txt_lastname.TabIndex = 4
        '
        'Txt_firstname
        '
        Me.Txt_firstname.Location = New System.Drawing.Point(180, 67)
        Me.Txt_firstname.MaxLength = 50
        Me.Txt_firstname.Name = "Txt_firstname"
        Me.Txt_firstname.Size = New System.Drawing.Size(200, 20)
        Me.Txt_firstname.TabIndex = 2
        '
        'btn_submit
        '
        Me.btn_submit.Location = New System.Drawing.Point(180, 259)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(75, 23)
        Me.btn_submit.TabIndex = 15
        Me.btn_submit.Text = "&Submit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'Btn_cancel
        '
        Me.Btn_cancel.Location = New System.Drawing.Point(261, 259)
        Me.Btn_cancel.Name = "Btn_cancel"
        Me.Btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.Btn_cancel.TabIndex = 16
        Me.Btn_cancel.Text = "&Cancel"
        Me.Btn_cancel.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.PatientRegistration.My.Resources.Resources.eye
        Me.Button1.Location = New System.Drawing.Point(386, 190)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Image = Global.PatientRegistration.My.Resources.Resources.eye_2_16
        Me.Label9.Location = New System.Drawing.Point(387, 194)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 18
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(180, 190)
        Me.PasswordTextBox.MaxLength = 50
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PasswordTextBox.TabIndex = 20
        '
        'Txt_reEnterpassword
        '
        Me.Txt_reEnterpassword.Location = New System.Drawing.Point(180, 219)
        Me.Txt_reEnterpassword.MaxLength = 50
        Me.Txt_reEnterpassword.Name = "Txt_reEnterpassword"
        Me.Txt_reEnterpassword.Size = New System.Drawing.Size(200, 20)
        Me.Txt_reEnterpassword.TabIndex = 21
        '
        'Frm_registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 436)
        Me.ControlBox = False
        Me.Controls.Add(Me.Txt_reEnterpassword)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Btn_cancel)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.Txt_firstname)
        Me.Controls.Add(Me.Txt_lastname)
        Me.Controls.Add(Me.Txt_email)
        Me.Controls.Add(Me.Txt_phone)
        Me.Controls.Add(Me.Dob_DateTimePicker)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_registration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Dob_DateTimePicker As DateTimePicker
    Friend WithEvents Txt_phone As TextBox
    Friend WithEvents Txt_email As TextBox
    Friend WithEvents Txt_lastname As TextBox
    Friend WithEvents Txt_firstname As TextBox
    Friend WithEvents btn_submit As Button
    Friend WithEvents Btn_cancel As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents Txt_reEnterpassword As TextBox
End Class
