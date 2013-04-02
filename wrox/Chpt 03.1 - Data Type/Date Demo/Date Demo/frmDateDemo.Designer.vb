<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDateDemo
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
        Me.btnShowDate = New System.Windows.Forms.Button
        Me.btnDateProperties = New System.Windows.Forms.Button
        Me.btnDateNames = New System.Windows.Forms.Button
        Me.btnDateLiteral = New System.Windows.Forms.Button
        Me.btnDateManipulation = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnShowDate
        '
        Me.btnShowDate.Location = New System.Drawing.Point(79, 55)
        Me.btnShowDate.Name = "btnShowDate"
        Me.btnShowDate.Size = New System.Drawing.Size(127, 23)
        Me.btnShowDate.TabIndex = 0
        Me.btnShowDate.Text = "Show Date"
        Me.btnShowDate.UseVisualStyleBackColor = True
        '
        'btnDateProperties
        '
        Me.btnDateProperties.Location = New System.Drawing.Point(79, 91)
        Me.btnDateProperties.Name = "btnDateProperties"
        Me.btnDateProperties.Size = New System.Drawing.Size(127, 23)
        Me.btnDateProperties.TabIndex = 1
        Me.btnDateProperties.Text = "Date Properties"
        Me.btnDateProperties.UseVisualStyleBackColor = True
        '
        'btnDateNames
        '
        Me.btnDateNames.Location = New System.Drawing.Point(79, 127)
        Me.btnDateNames.Name = "btnDateNames"
        Me.btnDateNames.Size = New System.Drawing.Size(127, 23)
        Me.btnDateNames.TabIndex = 2
        Me.btnDateNames.Text = "Date Names"
        Me.btnDateNames.UseVisualStyleBackColor = True
        '
        'btnDateLiteral
        '
        Me.btnDateLiteral.Location = New System.Drawing.Point(79, 163)
        Me.btnDateLiteral.Name = "btnDateLiteral"
        Me.btnDateLiteral.Size = New System.Drawing.Size(127, 23)
        Me.btnDateLiteral.TabIndex = 3
        Me.btnDateLiteral.Text = "Date Literal"
        Me.btnDateLiteral.UseVisualStyleBackColor = True
        '
        'btnDateManipulation
        '
        Me.btnDateManipulation.Location = New System.Drawing.Point(79, 199)
        Me.btnDateManipulation.Name = "btnDateManipulation"
        Me.btnDateManipulation.Size = New System.Drawing.Size(127, 23)
        Me.btnDateManipulation.TabIndex = 4
        Me.btnDateManipulation.Text = "Date Manipulation"
        Me.btnDateManipulation.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Date Demo"
        '
        'frmDateDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 276)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDateManipulation)
        Me.Controls.Add(Me.btnDateLiteral)
        Me.Controls.Add(Me.btnDateNames)
        Me.Controls.Add(Me.btnDateProperties)
        Me.Controls.Add(Me.btnShowDate)
        Me.Name = "frmDateDemo"
        Me.Text = "Date Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnShowDate As System.Windows.Forms.Button
    Friend WithEvents btnDateProperties As System.Windows.Forms.Button
    Friend WithEvents btnDateNames As System.Windows.Forms.Button
    Friend WithEvents btnDateLiteral As System.Windows.Forms.Button
    Friend WithEvents btnDateManipulation As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
