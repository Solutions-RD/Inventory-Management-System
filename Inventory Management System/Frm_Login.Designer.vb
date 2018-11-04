<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Login
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
        Me.TxtBox_UserName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBox_Password = New System.Windows.Forms.TextBox()
        Me.Btn_Login = New System.Windows.Forms.Button()
        Me.Btn_Forgotten = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtBox_UserName
        '
        Me.TxtBox_UserName.Location = New System.Drawing.Point(12, 45)
        Me.TxtBox_UserName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtBox_UserName.Name = "TxtBox_UserName"
        Me.TxtBox_UserName.Size = New System.Drawing.Size(475, 35)
        Me.TxtBox_UserName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 100)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'TxtBox_Password
        '
        Me.TxtBox_Password.Location = New System.Drawing.Point(12, 136)
        Me.TxtBox_Password.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtBox_Password.Name = "TxtBox_Password"
        Me.TxtBox_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtBox_Password.Size = New System.Drawing.Size(475, 35)
        Me.TxtBox_Password.TabIndex = 2
        '
        'Btn_Login
        '
        Me.Btn_Login.Location = New System.Drawing.Point(12, 201)
        Me.Btn_Login.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Login.Name = "Btn_Login"
        Me.Btn_Login.Size = New System.Drawing.Size(222, 98)
        Me.Btn_Login.TabIndex = 4
        Me.Btn_Login.Text = "Login"
        Me.Btn_Login.UseVisualStyleBackColor = True
        '
        'Btn_Forgotten
        '
        Me.Btn_Forgotten.Location = New System.Drawing.Point(275, 201)
        Me.Btn_Forgotten.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.Btn_Forgotten.Name = "Btn_Forgotten"
        Me.Btn_Forgotten.Size = New System.Drawing.Size(217, 98)
        Me.Btn_Forgotten.TabIndex = 5
        Me.Btn_Forgotten.Text = "Forgotten Login"
        Me.Btn_Forgotten.UseVisualStyleBackColor = True
        '
        'Frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 308)
        Me.Controls.Add(Me.Btn_Forgotten)
        Me.Controls.Add(Me.Btn_Login)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtBox_Password)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBox_UserName)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Frm_Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtBox_UserName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBox_Password As TextBox
    Friend WithEvents Btn_Login As Button
    Friend WithEvents Btn_Forgotten As Button
End Class
