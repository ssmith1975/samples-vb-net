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
        Me.btnTaskbarHeight = New System.Windows.Forms.Button()
        Me.txtApplicationCopyright = New System.Windows.Forms.TextBox()
        Me.txtScreenBounds = New System.Windows.Forms.TextBox()
        Me.txtScreenWorkingArea = New System.Windows.Forms.TextBox()
        Me.MyNamespace1 = New MyNamespaceControl.MyNamespace()
        Me.SuspendLayout()
        '
        'btnTaskbarHeight
        '
        Me.btnTaskbarHeight.Location = New System.Drawing.Point(12, 193)
        Me.btnTaskbarHeight.Name = "btnTaskbarHeight"
        Me.btnTaskbarHeight.Size = New System.Drawing.Size(120, 23)
        Me.btnTaskbarHeight.TabIndex = 1
        Me.btnTaskbarHeight.Text = "Taskbar Height"
        Me.btnTaskbarHeight.UseVisualStyleBackColor = True
        '
        'txtApplicationCopyright
        '
        Me.txtApplicationCopyright.Location = New System.Drawing.Point(153, 33)
        Me.txtApplicationCopyright.Name = "txtApplicationCopyright"
        Me.txtApplicationCopyright.Size = New System.Drawing.Size(119, 20)
        Me.txtApplicationCopyright.TabIndex = 2
        '
        'txtScreenBounds
        '
        Me.txtScreenBounds.Location = New System.Drawing.Point(153, 75)
        Me.txtScreenBounds.Name = "txtScreenBounds"
        Me.txtScreenBounds.Size = New System.Drawing.Size(119, 20)
        Me.txtScreenBounds.TabIndex = 3
        '
        'txtScreenWorkingArea
        '
        Me.txtScreenWorkingArea.Location = New System.Drawing.Point(153, 117)
        Me.txtScreenWorkingArea.Name = "txtScreenWorkingArea"
        Me.txtScreenWorkingArea.Size = New System.Drawing.Size(119, 20)
        Me.txtScreenWorkingArea.TabIndex = 4
        '
        'MyNamespace1
        '
        Me.MyNamespace1.ApplicationName = ""
        Me.MyNamespace1.Location = New System.Drawing.Point(-3, 12)
        Me.MyNamespace1.Name = "MyNamespace1"
        Me.MyNamespace1.Size = New System.Drawing.Size(150, 175)
        Me.MyNamespace1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.MyNamespace1)
        Me.Controls.Add(Me.txtScreenWorkingArea)
        Me.Controls.Add(Me.txtScreenBounds)
        Me.Controls.Add(Me.txtApplicationCopyright)
        Me.Controls.Add(Me.btnTaskbarHeight)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTaskbarHeight As System.Windows.Forms.Button
    Friend WithEvents txtApplicationCopyright As System.Windows.Forms.TextBox
    Friend WithEvents txtScreenBounds As System.Windows.Forms.TextBox
    Friend WithEvents txtScreenWorkingArea As System.Windows.Forms.TextBox
    Friend WithEvents MyNamespace1 As MyNamespaceControl.MyNamespace

End Class
