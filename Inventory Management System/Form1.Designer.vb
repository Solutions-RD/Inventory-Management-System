<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Btn_Trap = New System.Windows.Forms.Button()
        Me.Btn_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_Trap
        '
        Me.Btn_Trap.Location = New System.Drawing.Point(62, 64)
        Me.Btn_Trap.Name = "Btn_Trap"
        Me.Btn_Trap.Size = New System.Drawing.Size(176, 23)
        Me.Btn_Trap.TabIndex = 0
        Me.Btn_Trap.Text = "This is a trap"
        Me.Btn_Trap.UseVisualStyleBackColor = True
        '
        'Btn_Button
        '
        Me.Btn_Button.Location = New System.Drawing.Point(62, 35)
        Me.Btn_Button.Name = "Btn_Button"
        Me.Btn_Button.Size = New System.Drawing.Size(176, 23)
        Me.Btn_Button.TabIndex = 1
        Me.Btn_Button.Text = "This is a button"
        Me.Btn_Button.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Btn_Button)
        Me.Controls.Add(Me.Btn_Trap)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_Trap As Button
    Friend WithEvents Btn_Button As Button
End Class
