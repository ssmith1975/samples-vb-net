<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFloatingPointMath
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
        Me.btnFloatMath = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnFloatMath
        '
        Me.btnFloatMath.Location = New System.Drawing.Point(90, 34)
        Me.btnFloatMath.Name = "btnFloatMath"
        Me.btnFloatMath.Size = New System.Drawing.Size(104, 23)
        Me.btnFloatMath.TabIndex = 0
        Me.btnFloatMath.Text = "Double Test"
        Me.btnFloatMath.UseVisualStyleBackColor = True
        '
        'frmFloatingPointMath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 90)
        Me.Controls.Add(Me.btnFloatMath)
        Me.Name = "frmFloatingPointMath"
        Me.Text = "Floating Point Math"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnFloatMath As System.Windows.Forms.Button

End Class
