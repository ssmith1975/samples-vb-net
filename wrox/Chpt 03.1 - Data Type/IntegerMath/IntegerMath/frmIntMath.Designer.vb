﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIntMath
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
        Me.btnIntMath = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnIntMath
        '
        Me.btnIntMath.Location = New System.Drawing.Point(62, 40)
        Me.btnIntMath.Name = "btnIntMath"
        Me.btnIntMath.Size = New System.Drawing.Size(161, 23)
        Me.btnIntMath.TabIndex = 0
        Me.btnIntMath.Text = "Math Test"
        Me.btnIntMath.UseVisualStyleBackColor = True
        '
        'frmIntMath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 102)
        Me.Controls.Add(Me.btnIntMath)
        Me.Name = "frmIntMath"
        Me.Text = "Integer Math"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnIntMath As System.Windows.Forms.Button

End Class
