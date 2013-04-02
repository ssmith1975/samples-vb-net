<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStrings
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
        Me.btnStrings = New System.Windows.Forms.Button
        Me.btnConcatenation = New System.Windows.Forms.Button
        Me.txtString = New System.Windows.Forms.TextBox
        Me.btnLength = New System.Windows.Forms.Button
        Me.btnSubString = New System.Windows.Forms.Button
        Me.btnReplace = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnStrings
        '
        Me.btnStrings.Location = New System.Drawing.Point(51, 25)
        Me.btnStrings.Name = "btnStrings"
        Me.btnStrings.Size = New System.Drawing.Size(182, 23)
        Me.btnStrings.TabIndex = 0
        Me.btnStrings.Text = "Strings"
        Me.btnStrings.UseVisualStyleBackColor = True
        '
        'btnConcatenation
        '
        Me.btnConcatenation.Location = New System.Drawing.Point(51, 60)
        Me.btnConcatenation.Name = "btnConcatenation"
        Me.btnConcatenation.Size = New System.Drawing.Size(182, 23)
        Me.btnConcatenation.TabIndex = 1
        Me.btnConcatenation.Text = "Concatenation"
        Me.btnConcatenation.UseVisualStyleBackColor = True
        '
        'txtString
        '
        Me.txtString.Location = New System.Drawing.Point(51, 136)
        Me.txtString.Name = "txtString"
        Me.txtString.Size = New System.Drawing.Size(100, 20)
        Me.txtString.TabIndex = 2
        '
        'btnLength
        '
        Me.btnLength.Location = New System.Drawing.Point(157, 134)
        Me.btnLength.Name = "btnLength"
        Me.btnLength.Size = New System.Drawing.Size(75, 23)
        Me.btnLength.TabIndex = 3
        Me.btnLength.Text = "Length"
        Me.btnLength.UseVisualStyleBackColor = True
        '
        'btnSubString
        '
        Me.btnSubString.Location = New System.Drawing.Point(51, 174)
        Me.btnSubString.Name = "btnSubString"
        Me.btnSubString.Size = New System.Drawing.Size(182, 23)
        Me.btnSubString.TabIndex = 4
        Me.btnSubString.Text = "SubString"
        Me.btnSubString.UseVisualStyleBackColor = True
        '
        'btnReplace
        '
        Me.btnReplace.Location = New System.Drawing.Point(51, 212)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(181, 23)
        Me.btnReplace.TabIndex = 5
        Me.btnReplace.Text = "Replace"
        Me.btnReplace.UseVisualStyleBackColor = True
        '
        'frmStrings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 324)
        Me.Controls.Add(Me.btnReplace)
        Me.Controls.Add(Me.btnSubString)
        Me.Controls.Add(Me.btnLength)
        Me.Controls.Add(Me.txtString)
        Me.Controls.Add(Me.btnConcatenation)
        Me.Controls.Add(Me.btnStrings)
        Me.Name = "frmStrings"
        Me.Text = "Strings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStrings As System.Windows.Forms.Button
    Friend WithEvents btnConcatenation As System.Windows.Forms.Button
    Friend WithEvents txtString As System.Windows.Forms.TextBox
    Friend WithEvents btnLength As System.Windows.Forms.Button
    Friend WithEvents btnSubString As System.Windows.Forms.Button
    Friend WithEvents btnReplace As System.Windows.Forms.Button

End Class
