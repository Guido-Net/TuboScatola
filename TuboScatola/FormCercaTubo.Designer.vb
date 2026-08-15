<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCercaTubo
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
        Label2 = New Label()
        Label1 = New Label()
        AnnullaButton = New Button()
        CercaButton = New Button()
        DatoRicercaTextBox = New TextBox()
        TipoRicercaComboBox = New ComboBox()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(171, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 15)
        Label2.TabIndex = 11
        Label2.Text = "Dato in ricerca :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(33, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 15)
        Label1.TabIndex = 10
        Label1.Text = "Tipo di ricerca :"
        ' 
        ' AnnullaButton
        ' 
        AnnullaButton.Location = New Point(12, 87)
        AnnullaButton.Name = "AnnullaButton"
        AnnullaButton.Size = New Size(75, 23)
        AnnullaButton.TabIndex = 9
        AnnullaButton.Text = "Annulla"
        AnnullaButton.UseVisualStyleBackColor = True
        ' 
        ' CercaButton
        ' 
        CercaButton.Location = New Point(292, 87)
        CercaButton.Name = "CercaButton"
        CercaButton.Size = New Size(75, 23)
        CercaButton.TabIndex = 8
        CercaButton.Text = "Ricerca"
        CercaButton.UseVisualStyleBackColor = True
        ' 
        ' DatoRicercaTextBox
        ' 
        DatoRicercaTextBox.Location = New Point(171, 35)
        DatoRicercaTextBox.Name = "DatoRicercaTextBox"
        DatoRicercaTextBox.Size = New Size(129, 23)
        DatoRicercaTextBox.TabIndex = 7
        ' 
        ' TipoRicercaComboBox
        ' 
        TipoRicercaComboBox.FormattingEnabled = True
        TipoRicercaComboBox.Items.AddRange(New Object() {"Marca", "TipoTubo"})
        TipoRicercaComboBox.Location = New Point(33, 35)
        TipoRicercaComboBox.Name = "TipoRicercaComboBox"
        TipoRicercaComboBox.Size = New Size(121, 23)
        TipoRicercaComboBox.TabIndex = 6
        ' 
        ' FormCercaTubo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(379, 122)
        ControlBox = False
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(AnnullaButton)
        Controls.Add(CercaButton)
        Controls.Add(DatoRicercaTextBox)
        Controls.Add(TipoRicercaComboBox)
        FormBorderStyle = FormBorderStyle.FixedDialog
        KeyPreview = True
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormCercaTubo"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cerca..."
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AnnullaButton As Button
    Friend WithEvents CercaButton As Button
    Friend WithEvents DatoRicercaTextBox As TextBox
    Friend WithEvents TipoRicercaComboBox As ComboBox
End Class
