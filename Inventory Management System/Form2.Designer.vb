<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ChangeLogInDetails
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
        Me.Btn_ChangePassword = New System.Windows.Forms.Button()
        Me.Btn_AddUser = New System.Windows.Forms.Button()
        Me.Btn_ChangeUserName = New System.Windows.Forms.Button()
        Me.Btn_RemoveUser = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_ChangePassword
        '
        Me.Btn_ChangePassword.Location = New System.Drawing.Point(12, 12)
        Me.Btn_ChangePassword.Name = "Btn_ChangePassword"
        Me.Btn_ChangePassword.Size = New System.Drawing.Size(193, 92)
        Me.Btn_ChangePassword.TabIndex = 0
        Me.Btn_ChangePassword.Text = "Change Password"
        Me.Btn_ChangePassword.UseVisualStyleBackColor = True
        '
        'Btn_AddUser
        '
        Me.Btn_AddUser.Location = New System.Drawing.Point(12, 127)
        Me.Btn_AddUser.Name = "Btn_AddUser"
        Me.Btn_AddUser.Size = New System.Drawing.Size(193, 92)
        Me.Btn_AddUser.TabIndex = 1
        Me.Btn_AddUser.Text = "Add User"
        Me.Btn_AddUser.UseVisualStyleBackColor = True
        '
        'Btn_ChangeUserName
        '
        Me.Btn_ChangeUserName.Location = New System.Drawing.Point(211, 12)
        Me.Btn_ChangeUserName.Name = "Btn_ChangeUserName"
        Me.Btn_ChangeUserName.Size = New System.Drawing.Size(193, 92)
        Me.Btn_ChangeUserName.TabIndex = 2
        Me.Btn_ChangeUserName.Text = "Change Username"
        Me.Btn_ChangeUserName.UseVisualStyleBackColor = True
        '
        'Btn_RemoveUser
        '
        Me.Btn_RemoveUser.Location = New System.Drawing.Point(211, 127)
        Me.Btn_RemoveUser.Name = "Btn_RemoveUser"
        Me.Btn_RemoveUser.Size = New System.Drawing.Size(193, 92)
        Me.Btn_RemoveUser.TabIndex = 3
        Me.Btn_RemoveUser.Text = "Remove User"
        Me.Btn_RemoveUser.UseVisualStyleBackColor = True
        '
        'Frm_ChangeLogInDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 235)
        Me.Controls.Add(Me.Btn_RemoveUser)
        Me.Controls.Add(Me.Btn_ChangeUserName)
        Me.Controls.Add(Me.Btn_AddUser)
        Me.Controls.Add(Me.Btn_ChangePassword)
        Me.Name = "Frm_ChangeLogInDetails"
        Me.Text = "Change Login Details"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_ChangePassword As Button
    Friend WithEvents Btn_AddUser As Button
    Friend WithEvents Btn_ChangeUserName As Button
    Friend WithEvents Btn_RemoveUser As Button
End Class
