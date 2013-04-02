<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnumDemo
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
        Me.dtpHour = New System.Windows.Forms.DateTimePicker
        Me.lblState = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'dtpHour
        '
        Me.dtpHour.CustomFormat = "hh:mm:ss tt"
        Me.dtpHour.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHour.Location = New System.Drawing.Point(12, 25)
        Me.dtpHour.MaxDate = New Date(2015, 12, 31, 0, 0, 0, 0)
        Me.dtpHour.MinDate = New Date(2012, 1, 1, 0, 0, 0, 0)
        Me.dtpHour.Name = "dtpHour"
        Me.dtpHour.ShowUpDown = True
        Me.dtpHour.Size = New System.Drawing.Size(100, 20)
        Me.dtpHour.TabIndex = 0
        Me.dtpHour.Value = New Date(2012, 1, 8, 1, 0, 0, 0)
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(12, 57)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(98, 13)
        Me.lblState.TabIndex = 1
        Me.lblState.Text = "State Not Initialized"
        '
        'frmEnumDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 94)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.dtpHour)
        Me.Name = "frmEnumDemo"
        Me.Text = "What's Richard Doing?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpHour As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblState As System.Windows.Forms.Label

End Class
