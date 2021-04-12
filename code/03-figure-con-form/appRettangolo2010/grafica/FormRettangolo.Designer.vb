<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRettangolo
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBase = New System.Windows.Forms.TextBox()
        Me.TextAltezza = New System.Windows.Forms.TextBox()
        Me.ButtonRicalcola = New System.Windows.Forms.Button()
        Me.ButtonSalva = New System.Windows.Forms.Button()
        Me.ButtonElimina = New System.Windows.Forms.Button()
        Me.LabelPerimetro = New System.Windows.Forms.Label()
        Me.LabelArea = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "base"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "altezza"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 32)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "perimetro ="
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(89, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 32)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "area ="
        '
        'TextBase
        '
        Me.TextBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBase.Location = New System.Drawing.Point(173, 49)
        Me.TextBase.Name = "TextBase"
        Me.TextBase.Size = New System.Drawing.Size(136, 38)
        Me.TextBase.TabIndex = 5
        '
        'TextAltezza
        '
        Me.TextAltezza.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextAltezza.Location = New System.Drawing.Point(173, 100)
        Me.TextAltezza.Name = "TextAltezza"
        Me.TextAltezza.Size = New System.Drawing.Size(136, 38)
        Me.TextAltezza.TabIndex = 6
        '
        'ButtonRicalcola
        '
        Me.ButtonRicalcola.Location = New System.Drawing.Point(366, 143)
        Me.ButtonRicalcola.Name = "ButtonRicalcola"
        Me.ButtonRicalcola.Size = New System.Drawing.Size(99, 49)
        Me.ButtonRicalcola.TabIndex = 10
        Me.ButtonRicalcola.Text = "Ricalcola"
        Me.ButtonRicalcola.UseVisualStyleBackColor = True
        '
        'ButtonSalva
        '
        Me.ButtonSalva.Location = New System.Drawing.Point(366, 12)
        Me.ButtonSalva.Name = "ButtonSalva"
        Me.ButtonSalva.Size = New System.Drawing.Size(99, 34)
        Me.ButtonSalva.TabIndex = 12
        Me.ButtonSalva.Text = "Salva"
        Me.ButtonSalva.UseVisualStyleBackColor = True
        '
        'ButtonElimina
        '
        Me.ButtonElimina.Location = New System.Drawing.Point(366, 58)
        Me.ButtonElimina.Name = "ButtonElimina"
        Me.ButtonElimina.Size = New System.Drawing.Size(99, 34)
        Me.ButtonElimina.TabIndex = 13
        Me.ButtonElimina.Text = "Elimina"
        Me.ButtonElimina.UseVisualStyleBackColor = True
        '
        'LabelPerimetro
        '
        Me.LabelPerimetro.AutoSize = True
        Me.LabelPerimetro.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPerimetro.Location = New System.Drawing.Point(190, 204)
        Me.LabelPerimetro.Name = "LabelPerimetro"
        Me.LabelPerimetro.Size = New System.Drawing.Size(236, 32)
        Me.LabelPerimetro.TabIndex = 14
        Me.LabelPerimetro.Text = "[valore perimetro]"
        '
        'LabelArea
        '
        Me.LabelArea.AutoSize = True
        Me.LabelArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelArea.Location = New System.Drawing.Point(193, 254)
        Me.LabelArea.Name = "LabelArea"
        Me.LabelArea.Size = New System.Drawing.Size(166, 32)
        Me.LabelArea.TabIndex = 15
        Me.LabelArea.Text = "[vaore area]"
        '
        'FormRettangolo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 327)
        Me.Controls.Add(Me.LabelArea)
        Me.Controls.Add(Me.LabelPerimetro)
        Me.Controls.Add(Me.ButtonElimina)
        Me.Controls.Add(Me.ButtonSalva)
        Me.Controls.Add(Me.ButtonRicalcola)
        Me.Controls.Add(Me.TextAltezza)
        Me.Controls.Add(Me.TextBase)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormRettangolo"
        Me.Text = "Form Triangolo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBase As System.Windows.Forms.TextBox
    Friend WithEvents TextAltezza As System.Windows.Forms.TextBox
    Friend WithEvents ButtonRicalcola As System.Windows.Forms.Button
    Friend WithEvents ButtonSalva As System.Windows.Forms.Button
    Friend WithEvents ButtonElimina As System.Windows.Forms.Button
    Friend WithEvents LabelPerimetro As System.Windows.Forms.Label
    Friend WithEvents LabelArea As System.Windows.Forms.Label
End Class
