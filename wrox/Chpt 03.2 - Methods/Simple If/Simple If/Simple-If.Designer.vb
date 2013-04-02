<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Simple_If
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
        Me.btnIf = New System.Windows.Forms.Button
        Me.btnAnotherIf = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnIf
        '
        Me.btnIf.Location = New System.Drawing.Point(105, 39)
        Me.btnIf.Name = "btnIf"
        Me.btnIf.Size = New System.Drawing.Size(75, 23)
        Me.btnIf.TabIndex = 0
        Me.btnIf.Text = "If"
        Me.btnIf.UseVisualStyleBackColor = True
        '
        'btnAnotherIf
        '
        Me.btnAnotherIf.Location = New System.Drawing.Point(105, 83)
        Me.btnAnotherIf.Name = "btnAnotherIf"
        Me.btnAnotherIf.Size = New System.Drawing.Size(75, 23)
        Me.btnAnotherIf.TabIndex = 1
        Me.btnAnotherIf.Text = "Another If"
        Me.btnAnotherIf.UseVisualStyleBackColor = True
        '
        'Simple_If
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 145)
        Me.Controls.Add(Me.btnAnotherIf)
        Me.Controls.Add(Me.btnIf)
        Me.Name = "Simple_If"
        Me.Text = "Simple If"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnIf As System.Windows.Forms.Button
    Friend WithEvents btnAnotherIf As System.Windows.Forms.Button

End Class
