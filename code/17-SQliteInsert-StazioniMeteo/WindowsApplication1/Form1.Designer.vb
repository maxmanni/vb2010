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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvComuni = New System.Windows.Forms.DataGridView()
        Me.dgvStazioni = New System.Windows.Forms.DataGridView()
        Me.dgvRilevazioni = New System.Windows.Forms.DataGridView()
        Me.inserisciComune = New System.Windows.Forms.Button()
        Me.modificaComune = New System.Windows.Forms.Button()
        Me.eliminaComune = New System.Windows.Forms.Button()
        CType(Me.dgvComuni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvStazioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRilevazioni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Comuni"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Stazioni"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 537)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Rilevazioni"
        '
        'dgvComuni
        '
        Me.dgvComuni.AllowUserToOrderColumns = True
        Me.dgvComuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComuni.Location = New System.Drawing.Point(16, 32)
        Me.dgvComuni.MultiSelect = False
        Me.dgvComuni.Name = "dgvComuni"
        Me.dgvComuni.ReadOnly = True
        Me.dgvComuni.Size = New System.Drawing.Size(594, 214)
        Me.dgvComuni.TabIndex = 11
        '
        'dgvStazioni
        '
        Me.dgvStazioni.AllowUserToOrderColumns = True
        Me.dgvStazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStazioni.Location = New System.Drawing.Point(16, 283)
        Me.dgvStazioni.MultiSelect = False
        Me.dgvStazioni.Name = "dgvStazioni"
        Me.dgvStazioni.ReadOnly = True
        Me.dgvStazioni.Size = New System.Drawing.Size(594, 230)
        Me.dgvStazioni.TabIndex = 12
        '
        'dgvRilevazioni
        '
        Me.dgvRilevazioni.AllowUserToOrderColumns = True
        Me.dgvRilevazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRilevazioni.Location = New System.Drawing.Point(16, 560)
        Me.dgvRilevazioni.MultiSelect = False
        Me.dgvRilevazioni.Name = "dgvRilevazioni"
        Me.dgvRilevazioni.ReadOnly = True
        Me.dgvRilevazioni.Size = New System.Drawing.Size(594, 230)
        Me.dgvRilevazioni.TabIndex = 13
        '
        'inserisciComune
        '
        Me.inserisciComune.Location = New System.Drawing.Point(666, 77)
        Me.inserisciComune.Name = "inserisciComune"
        Me.inserisciComune.Size = New System.Drawing.Size(132, 40)
        Me.inserisciComune.TabIndex = 14
        Me.inserisciComune.Text = "Inserisci Comune"
        Me.inserisciComune.UseVisualStyleBackColor = True
        '
        'modificaComune
        '
        Me.modificaComune.Location = New System.Drawing.Point(666, 123)
        Me.modificaComune.Name = "modificaComune"
        Me.modificaComune.Size = New System.Drawing.Size(132, 40)
        Me.modificaComune.TabIndex = 15
        Me.modificaComune.Text = "Modifica Comune"
        Me.modificaComune.UseVisualStyleBackColor = True
        '
        'eliminaComune
        '
        Me.eliminaComune.Location = New System.Drawing.Point(666, 169)
        Me.eliminaComune.Name = "eliminaComune"
        Me.eliminaComune.Size = New System.Drawing.Size(132, 40)
        Me.eliminaComune.TabIndex = 16
        Me.eliminaComune.Text = "Elimina Comune"
        Me.eliminaComune.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 802)
        Me.Controls.Add(Me.eliminaComune)
        Me.Controls.Add(Me.modificaComune)
        Me.Controls.Add(Me.inserisciComune)
        Me.Controls.Add(Me.dgvRilevazioni)
        Me.Controls.Add(Me.dgvStazioni)
        Me.Controls.Add(Me.dgvComuni)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvComuni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvStazioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRilevazioni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgvComuni As System.Windows.Forms.DataGridView
    Friend WithEvents dgvStazioni As System.Windows.Forms.DataGridView
    Friend WithEvents dgvRilevazioni As System.Windows.Forms.DataGridView
    Friend WithEvents inserisciComune As System.Windows.Forms.Button
    Friend WithEvents modificaComune As System.Windows.Forms.Button
    Friend WithEvents eliminaComune As System.Windows.Forms.Button

End Class
