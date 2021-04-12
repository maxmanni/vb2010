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
        Me.griglia = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.positivo = New System.Windows.Forms.CheckBox()
        Me.nomePaziente = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.griglia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'griglia
        '
        Me.griglia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.griglia.Location = New System.Drawing.Point(12, 12)
        Me.griglia.Name = "griglia"
        Me.griglia.Size = New System.Drawing.Size(647, 379)
        Me.griglia.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(694, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'positivo
        '
        Me.positivo.AutoSize = True
        Me.positivo.Location = New System.Drawing.Point(692, 248)
        Me.positivo.Name = "positivo"
        Me.positivo.Size = New System.Drawing.Size(110, 17)
        Me.positivo.TabIndex = 2
        Me.positivo.Text = "Positivo al COVID"
        Me.positivo.UseVisualStyleBackColor = True
        '
        'nomePaziente
        '
        Me.nomePaziente.ForeColor = System.Drawing.Color.Red
        Me.nomePaziente.Location = New System.Drawing.Point(692, 271)
        Me.nomePaziente.Multiline = True
        Me.nomePaziente.Name = "nomePaziente"
        Me.nomePaziente.Size = New System.Drawing.Size(100, 76)
        Me.nomePaziente.TabIndex = 3
        Me.nomePaziente.Text = "uyyfyf"
        Me.nomePaziente.WordWrap = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(698, 211)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 37)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 403)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.nomePaziente)
        Me.Controls.Add(Me.positivo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.griglia)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.griglia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents griglia As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents positivo As System.Windows.Forms.CheckBox
    Friend WithEvents nomePaziente As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
