<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCerca
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        cboTipoRicerca = New ComboBox()
        txtValoreCerca = New TextBox()
        btnEseguiRicerca = New Button()
        btnAnnullaRicerca = New Button()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' cboTipoRicerca
        ' 
        cboTipoRicerca.FormattingEnabled = True
        cboTipoRicerca.Items.AddRange(New Object() {"Marca", "CodiceScatola", "Posa"})
        cboTipoRicerca.Location = New Point(33, 34)
        cboTipoRicerca.Name = "cboTipoRicerca"
        cboTipoRicerca.Size = New Size(121, 23)
        cboTipoRicerca.TabIndex = 0
        ' 
        ' txtValoreCerca
        ' 
        txtValoreCerca.Location = New Point(171, 34)
        txtValoreCerca.Name = "txtValoreCerca"
        txtValoreCerca.Size = New Size(129, 23)
        txtValoreCerca.TabIndex = 1
        ' 
        ' btnEseguiRicerca
        ' 
        btnEseguiRicerca.Location = New Point(292, 86)
        btnEseguiRicerca.Name = "btnEseguiRicerca"
        btnEseguiRicerca.Size = New Size(75, 23)
        btnEseguiRicerca.TabIndex = 2
        btnEseguiRicerca.Text = "Ricerca"
        btnEseguiRicerca.UseVisualStyleBackColor = True
        ' 
        ' btnAnnullaRicerca
        ' 
        btnAnnullaRicerca.Location = New Point(12, 86)
        btnAnnullaRicerca.Name = "btnAnnullaRicerca"
        btnAnnullaRicerca.Size = New Size(75, 23)
        btnAnnullaRicerca.TabIndex = 3
        btnAnnullaRicerca.Text = "Annulla"
        btnAnnullaRicerca.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(33, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 15)
        Label1.TabIndex = 4
        Label1.Text = "Tipo di ricerca :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(171, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 15)
        Label2.TabIndex = 5
        Label2.Text = "Dato in ricerca :"
        ' 
        ' FormCerca
        ' 
        AcceptButton = btnEseguiRicerca
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(379, 122)
        ControlBox = False
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnAnnullaRicerca)
        Controls.Add(btnEseguiRicerca)
        Controls.Add(txtValoreCerca)
        Controls.Add(cboTipoRicerca)
        FormBorderStyle = FormBorderStyle.FixedDialog
        KeyPreview = True
        Name = "FormCerca"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cerca..."
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cboTipoRicerca As ComboBox
    Friend WithEvents txtValoreCerca As TextBox
    Friend WithEvents btnEseguiRicerca As Button
    Friend WithEvents btnAnnullaRicerca As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
