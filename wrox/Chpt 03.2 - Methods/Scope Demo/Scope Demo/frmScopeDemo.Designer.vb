﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScopeDemo
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
        Me.btnScope = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnScope
        '
        Me.btnScope.Location = New System.Drawing.Point(105, 37)
        Me.btnScope.Name = "btnScope"
        Me.btnScope.Size = New System.Drawing.Size(75, 23)
        Me.btnScope.TabIndex = 0
        Me.btnScope.Text = "Scope"
        Me.btnScope.UseVisualStyleBackColor = True
        '
        'frmScopeDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 97)
        Me.Controls.Add(Me.btnScope)
        Me.Name = "frmScopeDemo"
        Me.Text = "Scope Demo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnScope As System.Windows.Forms.Button

End Class
