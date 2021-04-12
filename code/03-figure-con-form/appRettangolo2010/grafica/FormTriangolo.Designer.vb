<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTriangolo
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextLato1 = New System.Windows.Forms.TextBox()
        Me.TextLato2 = New System.Windows.Forms.TextBox()
        Me.TextLato3 = New System.Windows.Forms.TextBox()
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
        Me.Label1.Location = New System.Drawing.Point(65, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "lato 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "lato 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "lato 3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 214)
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
        'TextLato1
        '
        Me.TextLato1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextLato1.Location = New System.Drawing.Point(175, 49)
        Me.TextLato1.Name = "TextLato1"
        Me.TextLato1.Size = New System.Drawing.Size(136, 38)
        Me.TextLato1.TabIndex = 5
        '
        'TextLato2
        '
        Me.TextLato2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextLato2.Location = New System.Drawing.Point(175, 100)
        Me.TextLato2.Name = "TextLato2"
        Me.TextLato2.Size = New System.Drawing.Size(136, 38)
        Me.TextLato2.TabIndex = 6
        '
        'TextLato3
        '
        Me.TextLato3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextLato3.Location = New System.Drawing.Point(175, 148)
        Me.TextLato3.Name = "TextLato3"
        Me.TextLato3.Size = New System.Drawing.Size(136, 38)
        Me.TextLato3.TabIndex = 7
        '
        'ButtonRicalcola
        '
        Me.ButtonRicalcola.Location = New System.Drawing.Point(365, 148)
        Me.ButtonRicalcola.Name = "ButtonRicalcola"
        Me.ButtonRicalcola.Size = New System.Drawing.Size(99, 49)
        Me.ButtonRicalcola.TabIndex = 10
        Me.ButtonRicalcola.Text = "Ricalcola"
        Me.ButtonRicalcola.UseVisualStyleBackColor = True
        '
        'ButtonSalva
        '
        Me.ButtonSalva.Location = New System.Drawing.Point(365, 27)
        Me.ButtonSalva.Name = "ButtonSalva"
        Me.ButtonSalva.Size = New System.Drawing.Size(99, 34)
        Me.ButtonSalva.TabIndex = 12
        Me.ButtonSalva.Text = "Salva"
        Me.ButtonSalva.UseVisualStyleBackColor = True
        '
        'ButtonElimina
        '
        Me.ButtonElimina.Location = New System.Drawing.Point(365, 67)
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
        Me.LabelPerimetro.Location = New System.Drawing.Point(190, 214)
        Me.LabelPerimetro.Name = "LabelPerimetro"
        Me.LabelPerimetro.Size = New System.Drawing.Size(236, 32)
        Me.LabelPerimetro.TabIndex = 14
        Me.LabelPerimetro.Text = "[valore perimetro]"
        '
        'LabelArea
        '
        Me.LabelArea.AutoSize = True
        Me.LabelArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelArea.Location = New System.Drawing.Point(190, 254)
        Me.LabelArea.Name = "LabelArea"
        Me.LabelArea.Size = New System.Drawing.Size(173, 32)
        Me.LabelArea.TabIndex = 15
        Me.LabelArea.Text = "[valore area]"
        '
        'FormTriangolo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 327)
        Me.Controls.Add(Me.LabelArea)
        Me.Controls.Add(Me.LabelPerimetro)
        Me.Controls.Add(Me.ButtonElimina)
        Me.Controls.Add(Me.ButtonSalva)
        Me.Controls.Add(Me.ButtonRicalcola)
        Me.Controls.Add(Me.TextLato3)
        Me.Controls.Add(Me.TextLato2)
        Me.Controls.Add(Me.TextLato1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormTriangolo"
        Me.Text = "Form Triangolo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextLato1 As System.Windows.Forms.TextBox
    Friend WithEvents TextLato2 As System.Windows.Forms.TextBox
    Friend WithEvents TextLato3 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonRicalcola As System.Windows.Forms.Button
    Friend WithEvents ButtonSalva As System.Windows.Forms.Button
    Friend WithEvents ButtonElimina As System.Windows.Forms.Button
    Friend WithEvents LabelPerimetro As System.Windows.Forms.Label
    Friend WithEvents LabelArea As System.Windows.Forms.Label
End Class
