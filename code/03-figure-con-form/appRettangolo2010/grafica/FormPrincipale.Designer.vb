<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipale
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
        Me.btnNuovoTriangolo = New System.Windows.Forms.Button()
        Me.btnNuovoRettangolo = New System.Windows.Forms.Button()
        Me.ListaTriangoli = New System.Windows.Forms.ListBox()
        Me.ListaRettangoli = New System.Windows.Forms.ListBox()
        Me.ListaFigure = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnNuovoTriangolo
        '
        Me.btnNuovoTriangolo.Location = New System.Drawing.Point(18, 256)
        Me.btnNuovoTriangolo.Name = "btnNuovoTriangolo"
        Me.btnNuovoTriangolo.Size = New System.Drawing.Size(219, 43)
        Me.btnNuovoTriangolo.TabIndex = 0
        Me.btnNuovoTriangolo.Text = "Nuovo triangolo"
        Me.btnNuovoTriangolo.UseVisualStyleBackColor = True
        '
        'btnNuovoRettangolo
        '
        Me.btnNuovoRettangolo.Location = New System.Drawing.Point(256, 256)
        Me.btnNuovoRettangolo.Name = "btnNuovoRettangolo"
        Me.btnNuovoRettangolo.Size = New System.Drawing.Size(216, 43)
        Me.btnNuovoRettangolo.TabIndex = 1
        Me.btnNuovoRettangolo.Text = "Nuovo rettangolo"
        Me.btnNuovoRettangolo.UseVisualStyleBackColor = True
        '
        'ListaTriangoli
        '
        Me.ListaTriangoli.FormattingEnabled = True
        Me.ListaTriangoli.ItemHeight = 16
        Me.ListaTriangoli.Location = New System.Drawing.Point(18, 54)
        Me.ListaTriangoli.Name = "ListaTriangoli"
        Me.ListaTriangoli.Size = New System.Drawing.Size(219, 196)
        Me.ListaTriangoli.TabIndex = 2
        '
        'ListaRettangoli
        '
        Me.ListaRettangoli.FormattingEnabled = True
        Me.ListaRettangoli.ItemHeight = 16
        Me.ListaRettangoli.Location = New System.Drawing.Point(256, 54)
        Me.ListaRettangoli.Name = "ListaRettangoli"
        Me.ListaRettangoli.Size = New System.Drawing.Size(216, 196)
        Me.ListaRettangoli.TabIndex = 3
        '
        'ListFigure
        '
        Me.ListaFigure.Enabled = False
        Me.ListaFigure.FormattingEnabled = True
        Me.ListaFigure.ItemHeight = 16
        Me.ListaFigure.Location = New System.Drawing.Point(506, 54)
        Me.ListaFigure.Name = "ListFigure"
        Me.ListaFigure.Size = New System.Drawing.Size(296, 244)
        Me.ListaFigure.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(500, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Lista di tutte le figure:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(250, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 32)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Lista rettangoli:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 32)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Lista triangoli:"
        '
        'FormPrincipale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 340)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListaFigure)
        Me.Controls.Add(Me.ListaRettangoli)
        Me.Controls.Add(Me.ListaTriangoli)
        Me.Controls.Add(Me.btnNuovoRettangolo)
        Me.Controls.Add(Me.btnNuovoTriangolo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPrincipale"
        Me.Text = "Form Principale"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNuovoTriangolo As System.Windows.Forms.Button
    Friend WithEvents btnNuovoRettangolo As System.Windows.Forms.Button
    Friend WithEvents ListaTriangoli As System.Windows.Forms.ListBox
    Friend WithEvents ListaRettangoli As System.Windows.Forms.ListBox
    Friend WithEvents ListaFigure As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
