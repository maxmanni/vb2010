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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.deltaLat = New System.Windows.Forms.TextBox()
        Me.deltaLong = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.stazPerComune = New System.Windows.Forms.TextBox()
        Me.creaStazioni = New System.Windows.Forms.Button()
        Me.eliminaStazioni = New System.Windows.Forms.Button()
        Me.progressLabel = New System.Windows.Forms.Label()
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(635, 306)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "variazioni-latitudine"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(635, 337)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "variazioni-longitudine"
        '
        'deltaLat
        '
        Me.deltaLat.Location = New System.Drawing.Point(759, 306)
        Me.deltaLat.Name = "deltaLat"
        Me.deltaLat.Size = New System.Drawing.Size(66, 20)
        Me.deltaLat.TabIndex = 19
        Me.deltaLat.Text = "0.5"
        '
        'deltaLong
        '
        Me.deltaLong.Location = New System.Drawing.Point(759, 337)
        Me.deltaLong.Name = "deltaLong"
        Me.deltaLong.Size = New System.Drawing.Size(66, 20)
        Me.deltaLong.TabIndex = 20
        Me.deltaLong.Text = "0.5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(646, 373)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "staz-per-comune"
        '
        'stazPerComune
        '
        Me.stazPerComune.Location = New System.Drawing.Point(759, 373)
        Me.stazPerComune.Name = "stazPerComune"
        Me.stazPerComune.Size = New System.Drawing.Size(66, 20)
        Me.stazPerComune.TabIndex = 22
        Me.stazPerComune.Text = "10"
        '
        'creaStazioni
        '
        Me.creaStazioni.Location = New System.Drawing.Point(638, 412)
        Me.creaStazioni.Name = "creaStazioni"
        Me.creaStazioni.Size = New System.Drawing.Size(117, 40)
        Me.creaStazioni.TabIndex = 23
        Me.creaStazioni.Text = "Crea Stazioni"
        Me.creaStazioni.UseVisualStyleBackColor = True
        '
        'eliminaStazioni
        '
        Me.eliminaStazioni.Location = New System.Drawing.Point(771, 412)
        Me.eliminaStazioni.Name = "eliminaStazioni"
        Me.eliminaStazioni.Size = New System.Drawing.Size(140, 40)
        Me.eliminaStazioni.TabIndex = 24
        Me.eliminaStazioni.Text = "Elimina Stazioni"
        Me.eliminaStazioni.UseVisualStyleBackColor = True
        '
        'progressLabel
        '
        Me.progressLabel.AutoSize = True
        Me.progressLabel.Location = New System.Drawing.Point(643, 462)
        Me.progressLabel.Name = "progressLabel"
        Me.progressLabel.Size = New System.Drawing.Size(47, 13)
        Me.progressLabel.TabIndex = 25
        Me.progressLabel.Text = "progress"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 802)
        Me.Controls.Add(Me.progressLabel)
        Me.Controls.Add(Me.eliminaStazioni)
        Me.Controls.Add(Me.creaStazioni)
        Me.Controls.Add(Me.stazPerComune)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.deltaLong)
        Me.Controls.Add(Me.deltaLat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents deltaLat As System.Windows.Forms.TextBox
    Friend WithEvents deltaLong As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents stazPerComune As System.Windows.Forms.TextBox
    Friend WithEvents creaStazioni As System.Windows.Forms.Button
    Friend WithEvents eliminaStazioni As System.Windows.Forms.Button
    Friend WithEvents progressLabel As System.Windows.Forms.Label

End Class
