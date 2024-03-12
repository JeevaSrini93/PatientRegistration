<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_appoinment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dept_ComboBox = New System.Windows.Forms.ComboBox()
        Me.doc_ComboBox = New System.Windows.Forms.ComboBox()
        Me.App_DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.app_timeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_details = New System.Windows.Forms.TextBox()
        Me.Btn_cancel = New System.Windows.Forms.Button()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Department"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Doctor"
        '
        'dept_ComboBox
        '
        Me.dept_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dept_ComboBox.FormattingEnabled = True
        Me.dept_ComboBox.Location = New System.Drawing.Point(130, 28)
        Me.dept_ComboBox.Name = "dept_ComboBox"
        Me.dept_ComboBox.Size = New System.Drawing.Size(121, 21)
        Me.dept_ComboBox.TabIndex = 2
        '
        'doc_ComboBox
        '
        Me.doc_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.doc_ComboBox.FormattingEnabled = True
        Me.doc_ComboBox.Location = New System.Drawing.Point(130, 55)
        Me.doc_ComboBox.Name = "doc_ComboBox"
        Me.doc_ComboBox.Size = New System.Drawing.Size(121, 21)
        Me.doc_ComboBox.TabIndex = 3
        '
        'App_DateTimePicker
        '
        Me.App_DateTimePicker.Location = New System.Drawing.Point(130, 82)
        Me.App_DateTimePicker.Name = "App_DateTimePicker"
        Me.App_DateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.App_DateTimePicker.TabIndex = 11
        '
        'app_timeDateTimePicker
        '
        Me.app_timeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.app_timeDateTimePicker.Location = New System.Drawing.Point(130, 108)
        Me.app_timeDateTimePicker.Name = "app_timeDateTimePicker"
        Me.app_timeDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.app_timeDateTimePicker.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Appointment Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Appointment time"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Details"
        '
        'Txt_details
        '
        Me.Txt_details.Location = New System.Drawing.Point(130, 134)
        Me.Txt_details.MaxLength = 500
        Me.Txt_details.Multiline = True
        Me.Txt_details.Name = "Txt_details"
        Me.Txt_details.Size = New System.Drawing.Size(200, 86)
        Me.Txt_details.TabIndex = 16
        '
        'Btn_cancel
        '
        Me.Btn_cancel.Location = New System.Drawing.Point(211, 226)
        Me.Btn_cancel.Name = "Btn_cancel"
        Me.Btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.Btn_cancel.TabIndex = 18
        Me.Btn_cancel.Text = "&Cancel"
        Me.Btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_submit
        '
        Me.btn_submit.Location = New System.Drawing.Point(130, 226)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(75, 23)
        Me.btn_submit.TabIndex = 17
        Me.btn_submit.Text = "&Submit"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'New_appoinment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_cancel)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.Txt_details)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.app_timeDateTimePicker)
        Me.Controls.Add(Me.App_DateTimePicker)
        Me.Controls.Add(Me.doc_ComboBox)
        Me.Controls.Add(Me.dept_ComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "New_appoinment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dept_ComboBox As ComboBox
    Friend WithEvents doc_ComboBox As ComboBox
    Friend WithEvents App_DateTimePicker As DateTimePicker
    Friend WithEvents app_timeDateTimePicker As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_details As TextBox
    Friend WithEvents Btn_cancel As Button
    Friend WithEvents btn_submit As Button
End Class
