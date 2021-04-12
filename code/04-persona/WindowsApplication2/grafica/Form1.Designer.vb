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
        Me.rtb = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbNome = New System.Windows.Forms.TextBox()
        Me.tbCognome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CreaPersona1 = New System.Windows.Forms.Button()
        Me.listaDiPersone = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbCognomeSelezionato = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbNomeSelezionato = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RimuoviPersona = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ModificaPersona = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rtb
        '
        Me.rtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtb.Location = New System.Drawing.Point(12, 35)
        Me.rtb.Name = "rtb"
        Me.rtb.Size = New System.Drawing.Size(464, 461)
        Me.rtb.TabIndex = 0
        Me.rtb.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(482, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome"
        '
        'tbNome
        '
        Me.tbNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNome.Location = New System.Drawing.Point(586, 58)
        Me.tbNome.Name = "tbNome"
        Me.tbNome.Size = New System.Drawing.Size(479, 30)
        Me.tbNome.TabIndex = 2
        '
        'tbCognome
        '
        Me.tbCognome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCognome.Location = New System.Drawing.Point(586, 99)
        Me.tbCognome.Name = "tbCognome"
        Me.tbCognome.Size = New System.Drawing.Size(479, 30)
        Me.tbCognome.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(482, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cognome"
        '
        'CreaPersona1
        '
        Me.CreaPersona1.Location = New System.Drawing.Point(986, 135)
        Me.CreaPersona1.Name = "CreaPersona1"
        Me.CreaPersona1.Size = New System.Drawing.Size(79, 36)
        Me.CreaPersona1.TabIndex = 5
        Me.CreaPersona1.Text = "Aggiungi"
        Me.CreaPersona1.UseVisualStyleBackColor = True
        '
        'listaDiPersone
        '
        Me.listaDiPersone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listaDiPersone.FormattingEnabled = True
        Me.listaDiPersone.ItemHeight = 25
        Me.listaDiPersone.Location = New System.Drawing.Point(487, 218)
        Me.listaDiPersone.Name = "listaDiPersone"
        Me.listaDiPersone.Size = New System.Drawing.Size(580, 154)
        Me.listaDiPersone.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(484, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(261, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Lista delle persona aggiunte:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(490, 389)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Persona selezionata:"
        '
        'tbCognomeSelezionato
        '
        Me.tbCognomeSelezionato.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCognomeSelezionato.Location = New System.Drawing.Point(607, 448)
        Me.tbCognomeSelezionato.Name = "tbCognomeSelezionato"
        Me.tbCognomeSelezionato.Size = New System.Drawing.Size(458, 30)
        Me.tbCognomeSelezionato.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(490, 453)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Cognome"
        '
        'tbNomeSelezionato
        '
        Me.tbNomeSelezionato.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNomeSelezionato.Location = New System.Drawing.Point(607, 414)
        Me.tbNomeSelezionato.Name = "tbNomeSelezionato"
        Me.tbNomeSelezionato.Size = New System.Drawing.Size(458, 30)
        Me.tbNomeSelezionato.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(490, 414)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 25)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Nome"
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(486, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(484, 24)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Per selezionare una persona, clicca su un elemento della lista:"
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(486, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(558, 21)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Per aggiungere una persona alla lista inserisci nome e cognome e premi su aggiung" & _
            "i"
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(12, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(431, 23)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "In questa casella di testo gigante viene scritto cosa succede"
        '
        'RimuoviPersona
        '
        Me.RimuoviPersona.Location = New System.Drawing.Point(647, 498)
        Me.RimuoviPersona.Name = "RimuoviPersona"
        Me.RimuoviPersona.Size = New System.Drawing.Size(79, 36)
        Me.RimuoviPersona.TabIndex = 16
        Me.RimuoviPersona.Text = "Rimuovi"
        Me.RimuoviPersona.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(778, 485)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(166, 69)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Modifica il nome e il cognome e clicca su modifica per applicare le modifiche all" & _
            "a lista"
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(484, 485)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(157, 67)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Clicca su rimuovi per eliminare la Persona selezionata. "
        '
        'ModificaPersona
        '
        Me.ModificaPersona.Location = New System.Drawing.Point(972, 498)
        Me.ModificaPersona.Name = "ModificaPersona"
        Me.ModificaPersona.Size = New System.Drawing.Size(93, 37)
        Me.ModificaPersona.TabIndex = 19
        Me.ModificaPersona.Text = "Modifica"
        Me.ModificaPersona.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 581)
        Me.Controls.Add(Me.ModificaPersona)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.RimuoviPersona)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbCognomeSelezionato)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbNomeSelezionato)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.listaDiPersone)
        Me.Controls.Add(Me.CreaPersona1)
        Me.Controls.Add(Me.tbCognome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbNome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rtb)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtb As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbNome As System.Windows.Forms.TextBox
    Friend WithEvents tbCognome As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CreaPersona1 As System.Windows.Forms.Button
    Friend WithEvents listaDiPersone As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbCognomeSelezionato As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbNomeSelezionato As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents RimuoviPersona As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ModificaPersona As System.Windows.Forms.Button

End Class
