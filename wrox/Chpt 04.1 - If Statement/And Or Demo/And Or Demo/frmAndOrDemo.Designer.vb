<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAndOrDemo
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
        Me.txtName1 = New System.Windows.Forms.TextBox
        Me.txtName2 = New System.Windows.Forms.TextBox
        Me.btnOrCheck = New System.Windows.Forms.Button
        Me.btnAndCheck = New System.Windows.Forms.Button
        Me.txtName3 = New System.Windows.Forms.TextBox
        Me.btnStringCompare = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtName1
        '
        Me.txtName1.Location = New System.Drawing.Point(42, 45)
        Me.txtName1.Name = "txtName1"
        Me.txtName1.Size = New System.Drawing.Size(100, 20)
        Me.txtName1.TabIndex = 0
        Me.txtName1.Text = "Wendy"
        '
        'txtName2
        '
        Me.txtName2.Location = New System.Drawing.Point(42, 81)
        Me.txtName2.Name = "txtName2"
        Me.txtName2.Size = New System.Drawing.Size(100, 20)
        Me.txtName2.TabIndex = 1
        Me.txtName2.Text = "Stephanie"
        '
        'btnOrCheck
        '
        Me.btnOrCheck.Location = New System.Drawing.Point(157, 45)
        Me.btnOrCheck.Name = "btnOrCheck"
        Me.btnOrCheck.Size = New System.Drawing.Size(99, 23)
        Me.btnOrCheck.TabIndex = 2
        Me.btnOrCheck.Text = "Or Check"
        Me.btnOrCheck.UseVisualStyleBackColor = True
        '
        'btnAndCheck
        '
        Me.btnAndCheck.Location = New System.Drawing.Point(157, 81)
        Me.btnAndCheck.Name = "btnAndCheck"
        Me.btnAndCheck.Size = New System.Drawing.Size(99, 23)
        Me.btnAndCheck.TabIndex = 3
        Me.btnAndCheck.Text = "And Check"
        Me.btnAndCheck.UseVisualStyleBackColor = True
        '
        'txtName3
        '
        Me.txtName3.Location = New System.Drawing.Point(42, 118)
        Me.txtName3.Name = "txtName3"
        Me.txtName3.Size = New System.Drawing.Size(100, 20)
        Me.txtName3.TabIndex = 4
        Me.txtName3.Text = "Bryan"
        '
        'btnStringCompare
        '
        Me.btnStringCompare.Location = New System.Drawing.Point(157, 118)
        Me.btnStringCompare.Name = "btnStringCompare"
        Me.btnStringCompare.Size = New System.Drawing.Size(99, 23)
        Me.btnStringCompare.TabIndex = 5
        Me.btnStringCompare.Text = "String Compare"
        Me.btnStringCompare.UseVisualStyleBackColor = True
        '
        'frmAndOrDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnStringCompare)
        Me.Controls.Add(Me.txtName3)
        Me.Controls.Add(Me.btnAndCheck)
        Me.Controls.Add(Me.btnOrCheck)
        Me.Controls.Add(Me.txtName2)
        Me.Controls.Add(Me.txtName1)
        Me.Name = "frmAndOrDemo"
        Me.Text = "And Or Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName1 As System.Windows.Forms.TextBox
    Friend WithEvents txtName2 As System.Windows.Forms.TextBox
    Friend WithEvents btnOrCheck As System.Windows.Forms.Button
    Friend WithEvents btnAndCheck As System.Windows.Forms.Button
    Friend WithEvents txtName3 As System.Windows.Forms.TextBox
    Friend WithEvents btnStringCompare As System.Windows.Forms.Button

End Class
