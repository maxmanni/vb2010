﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.comuneInsert = New System.Windows.Forms.Button()
        Me.comuneNome = New System.Windows.Forms.TextBox()
        Me.comunePopolazione = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvComuni = New System.Windows.Forms.DataGridView()
        Me.dgvStazioni = New System.Windows.Forms.DataGridView()
        Me.dgvRilevazioni = New System.Windows.Forms.DataGridView()
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
        'comuneInsert
        '
        Me.comuneInsert.Location = New System.Drawing.Point(669, 140)
        Me.comuneInsert.Name = "comuneInsert"
        Me.comuneInsert.Size = New System.Drawing.Size(118, 25)
        Me.comuneInsert.TabIndex = 6
        Me.comuneInsert.Text = "Inserisci"
        Me.comuneInsert.UseVisualStyleBackColor = True
        '
        'comuneNome
        '
        Me.comuneNome.Location = New System.Drawing.Point(716, 49)
        Me.comuneNome.Name = "comuneNome"
        Me.comuneNome.Size = New System.Drawing.Size(101, 20)
        Me.comuneNome.TabIndex = 7
        '
        'comunePopolazione
        '
        Me.comunePopolazione.Location = New System.Drawing.Point(729, 88)
        Me.comunePopolazione.Name = "comunePopolazione"
        Me.comunePopolazione.Size = New System.Drawing.Size(88, 20)
        Me.comunePopolazione.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(628, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "nome"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(628, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "popolazione"
        '
        'dgvComuni
        '
        Me.dgvComuni.AllowUserToOrderColumns = True
        Me.dgvComuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComuni.Location = New System.Drawing.Point(16, 32)
        Me.dgvComuni.Name = "dgvComuni"
        Me.dgvComuni.Size = New System.Drawing.Size(594, 214)
        Me.dgvComuni.TabIndex = 11
        '
        'dgvStazioni
        '
        Me.dgvStazioni.AllowUserToOrderColumns = True
        Me.dgvStazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStazioni.Location = New System.Drawing.Point(16, 283)
        Me.dgvStazioni.Name = "dgvStazioni"
        Me.dgvStazioni.Size = New System.Drawing.Size(594, 230)
        Me.dgvStazioni.TabIndex = 12
        '
        'dgvRilevazioni
        '
        Me.dgvRilevazioni.AllowUserToOrderColumns = True
        Me.dgvRilevazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRilevazioni.Location = New System.Drawing.Point(16, 560)
        Me.dgvRilevazioni.Name = "dgvRilevazioni"
        Me.dgvRilevazioni.Size = New System.Drawing.Size(594, 230)
        Me.dgvRilevazioni.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 802)
        Me.Controls.Add(Me.dgvRilevazioni)
        Me.Controls.Add(Me.dgvStazioni)
        Me.Controls.Add(Me.dgvComuni)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.comunePopolazione)
        Me.Controls.Add(Me.comuneNome)
        Me.Controls.Add(Me.comuneInsert)
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
    Friend WithEvents comuneInsert As System.Windows.Forms.Button
    Friend WithEvents comuneNome As System.Windows.Forms.TextBox
    Friend WithEvents comunePopolazione As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgvComuni As System.Windows.Forms.DataGridView
    Friend WithEvents dgvStazioni As System.Windows.Forms.DataGridView
    Friend WithEvents dgvRilevazioni As System.Windows.Forms.DataGridView

End Class
