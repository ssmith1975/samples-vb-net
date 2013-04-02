<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectCase
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
        Me.lstData = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'lstData
        '
        Me.lstData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstData.FormattingEnabled = True
        Me.lstData.IntegralHeight = False
        Me.lstData.ItemHeight = 20
        Me.lstData.Items.AddRange(New Object() {"BRYAN", "ASHLEY", "JENNIFER", "EDDIE", "KATELYN", "TONY"})
        Me.lstData.Location = New System.Drawing.Point(0, 0)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(154, 262)
        Me.lstData.TabIndex = 0
        '
        'frmSelectCase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(154, 262)
        Me.Controls.Add(Me.lstData)
        Me.Name = "frmSelectCase"
        Me.Text = "Select Case"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstData As System.Windows.Forms.ListBox

End Class
