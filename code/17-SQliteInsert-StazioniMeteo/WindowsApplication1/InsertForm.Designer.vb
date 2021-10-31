<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertForm
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
        Me.bottomPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.okButton = New System.Windows.Forms.Button()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.fieldsPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.bottomPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'bottomPanel
        '
        Me.bottomPanel.BackColor = System.Drawing.SystemColors.Control
        Me.bottomPanel.Controls.Add(Me.okButton)
        Me.bottomPanel.Controls.Add(Me.closeButton)
        Me.bottomPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.bottomPanel.Location = New System.Drawing.Point(0, 476)
        Me.bottomPanel.Name = "bottomPanel"
        Me.bottomPanel.Size = New System.Drawing.Size(627, 42)
        Me.bottomPanel.TabIndex = 0
        '
        'okButton
        '
        Me.okButton.Location = New System.Drawing.Point(498, 3)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(126, 38)
        Me.okButton.TabIndex = 0
        Me.okButton.Text = "OK"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'closeButton
        '
        Me.closeButton.Location = New System.Drawing.Point(366, 3)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(126, 38)
        Me.closeButton.TabIndex = 1
        Me.closeButton.Text = "Annulla"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'fieldsPanel
        '
        Me.fieldsPanel.AutoScroll = True
        Me.fieldsPanel.BackColor = System.Drawing.SystemColors.Control
        Me.fieldsPanel.Location = New System.Drawing.Point(1, 2)
        Me.fieldsPanel.Name = "fieldsPanel"
        Me.fieldsPanel.Size = New System.Drawing.Size(625, 474)
        Me.fieldsPanel.TabIndex = 1
        '
        'InsertForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 519)
        Me.Controls.Add(Me.fieldsPanel)
        Me.Controls.Add(Me.bottomPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InsertForm"
        Me.Text = "InsertForm"
        Me.bottomPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bottomPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents okButton As System.Windows.Forms.Button
    Friend WithEvents closeButton As System.Windows.Forms.Button
    Friend WithEvents fieldsPanel As System.Windows.Forms.FlowLayoutPanel
End Class
