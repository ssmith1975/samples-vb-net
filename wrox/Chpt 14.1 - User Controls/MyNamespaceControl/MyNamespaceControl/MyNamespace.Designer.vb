<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyNamespace
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.btnApplicationCopyright = New System.Windows.Forms.Button()
        Me.btnScreenBounds = New System.Windows.Forms.Button()
        Me.btnSreenWorkingArea = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnApplicationCopyright
        '
        Me.btnApplicationCopyright.Location = New System.Drawing.Point(15, 20)
        Me.btnApplicationCopyright.Name = "btnApplicationCopyright"
        Me.btnApplicationCopyright.Size = New System.Drawing.Size(120, 23)
        Me.btnApplicationCopyright.TabIndex = 0
        Me.btnApplicationCopyright.Text = "Application Copyright"
        Me.btnApplicationCopyright.UseVisualStyleBackColor = True
        '
        'btnScreenBounds
        '
        Me.btnScreenBounds.Location = New System.Drawing.Point(15, 62)
        Me.btnScreenBounds.Name = "btnScreenBounds"
        Me.btnScreenBounds.Size = New System.Drawing.Size(120, 24)
        Me.btnScreenBounds.TabIndex = 1
        Me.btnScreenBounds.Text = "Screen Bounds"
        Me.btnScreenBounds.UseVisualStyleBackColor = True
        '
        'btnSreenWorkingArea
        '
        Me.btnSreenWorkingArea.Location = New System.Drawing.Point(15, 105)
        Me.btnSreenWorkingArea.Name = "btnSreenWorkingArea"
        Me.btnSreenWorkingArea.Size = New System.Drawing.Size(120, 26)
        Me.btnSreenWorkingArea.TabIndex = 2
        Me.btnSreenWorkingArea.Text = "Screen Working Area"
        Me.btnSreenWorkingArea.UseVisualStyleBackColor = True
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(12, 144)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(39, 13)
        Me.lblTime.TabIndex = 3
        Me.lblTime.Text = "Label1"
        '
        'MyNamespace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.btnSreenWorkingArea)
        Me.Controls.Add(Me.btnScreenBounds)
        Me.Controls.Add(Me.btnApplicationCopyright)
        Me.Name = "MyNamespace"
        Me.Size = New System.Drawing.Size(150, 175)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnApplicationCopyright As System.Windows.Forms.Button
    Friend WithEvents btnScreenBounds As System.Windows.Forms.Button
    Friend WithEvents btnSreenWorkingArea As System.Windows.Forms.Button
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
