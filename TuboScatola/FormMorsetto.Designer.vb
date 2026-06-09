<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMorsetto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMorsetto))
        MorsettoToolStrip = New ToolStrip()
        InizioMorsettoToolStripButton = New ToolStripButton()
        IndietroMorsettoToolStripButton = New ToolStripButton()
        RecordMorsettoToolStripLabel = New ToolStripLabel()
        AvantiMorsettoToolStripButton = New ToolStripButton()
        FineMorsettoToolStripButton = New ToolStripButton()
        ToolStripSeparator1 = New ToolStripSeparator()
        NuovoMorsettoToolStripButton = New ToolStripButton()
        SalvaMorsettoToolStripButton = New ToolStripButton()
        EliminaMorsettoToolStripButton = New ToolStripButton()
        ModificaMorsettoToolStripButton = New ToolStripButton()
        ToolStripSeparator2 = New ToolStripSeparator()
        RicercaMorsettoToolStripButton = New ToolStripButton()
        AnnullaRicercaMorsettoToolStripButton = New ToolStripButton()
        StampaMorsettoToolStripButton = New ToolStripButton()
        ToolStripSeparator3 = New ToolStripSeparator()
        EsportaDBMorsettoToolStripButton = New ToolStripButton()
        ImportaDBMorsettoToolStripButton = New ToolStripButton()
        EliminaDBMorsettoToolStripButton = New ToolStripButton()
        ToolStripSeparator4 = New ToolStripSeparator()
        EsciMorsettoToolStripButton = New ToolStripButton()
        AiutoMorsettoToolStripButton = New ToolStripButton()
        NotificaTuboLabel = New Label()
        NotificaMorsettoStatusStrip = New StatusStrip()
        NotificaMorsettoToolStripStatusLabel = New ToolStripStatusLabel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        MarcaMorsettiTextBox = New TextBox()
        TipoMorsettiTextBox = New TextBox()
        SezioneMorsettiTextBox = New TextBox()
        NoteMorsettiTextBox = New TextBox()
        SupOccupataTextBox = New TextBox()
        Label5 = New Label()
        LibMorsettoDataGridView = New DataGridView()
        MorsettoToolStrip.SuspendLayout()
        NotificaMorsettoStatusStrip.SuspendLayout()
        CType(LibMorsettoDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MorsettoToolStrip
        ' 
        MorsettoToolStrip.BackColor = SystemColors.ControlDark
        MorsettoToolStrip.GripStyle = ToolStripGripStyle.Hidden
        MorsettoToolStrip.Items.AddRange(New ToolStripItem() {InizioMorsettoToolStripButton, IndietroMorsettoToolStripButton, RecordMorsettoToolStripLabel, AvantiMorsettoToolStripButton, FineMorsettoToolStripButton, ToolStripSeparator1, NuovoMorsettoToolStripButton, SalvaMorsettoToolStripButton, ModificaMorsettoToolStripButton, EliminaMorsettoToolStripButton, ToolStripSeparator2, RicercaMorsettoToolStripButton, AnnullaRicercaMorsettoToolStripButton, StampaMorsettoToolStripButton, ToolStripSeparator3, EsportaDBMorsettoToolStripButton, ImportaDBMorsettoToolStripButton, EliminaDBMorsettoToolStripButton, ToolStripSeparator4, EsciMorsettoToolStripButton, AiutoMorsettoToolStripButton})
        MorsettoToolStrip.Location = New Point(0, 0)
        MorsettoToolStrip.Name = "MorsettoToolStrip"
        MorsettoToolStrip.Size = New Size(721, 25)
        MorsettoToolStrip.TabIndex = 2
        MorsettoToolStrip.Text = "ToolStrip1"
        ' 
        ' InizioMorsettoToolStripButton
        ' 
        InizioMorsettoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        InizioMorsettoToolStripButton.Image = CType(resources.GetObject("InizioMorsettoToolStripButton.Image"), Image)
        InizioMorsettoToolStripButton.ImageTransparentColor = Color.Magenta
        InizioMorsettoToolStripButton.Name = "InizioMorsettoToolStripButton"
        InizioMorsettoToolStripButton.Size = New Size(23, 22)
        InizioMorsettoToolStripButton.Text = "ToolStripButton1"
        ' 
        ' IndietroMorsettoToolStripButton
        ' 
        IndietroMorsettoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        IndietroMorsettoToolStripButton.Image = CType(resources.GetObject("IndietroMorsettoToolStripButton.Image"), Image)
        IndietroMorsettoToolStripButton.ImageTransparentColor = Color.Magenta
        IndietroMorsettoToolStripButton.Name = "IndietroMorsettoToolStripButton"
        IndietroMorsettoToolStripButton.Size = New Size(23, 22)
        IndietroMorsettoToolStripButton.Text = "ToolStripButton2"
        ' 
        ' RecordMorsettoToolStripLabel
        ' 
        RecordMorsettoToolStripLabel.Name = "RecordMorsettoToolStripLabel"
        RecordMorsettoToolStripLabel.Size = New Size(88, 22)
        RecordMorsettoToolStripLabel.Text = "ToolStripLabel1"
        ' 
        ' AvantiMorsettoToolStripButton
        ' 
        AvantiMorsettoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AvantiMorsettoToolStripButton.Image = CType(resources.GetObject("AvantiMorsettoToolStripButton.Image"), Image)
        AvantiMorsettoToolStripButton.ImageTransparentColor = Color.Magenta
        AvantiMorsettoToolStripButton.Name = "AvantiMorsettoToolStripButton"
        AvantiMorsettoToolStripButton.Size = New Size(23, 22)
        AvantiMorsettoToolStripButton.Text = "ToolStripButton3"
        ' 
        ' FineMorsettoToolStripButton
        ' 
        FineMorsettoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        FineMorsettoToolStripButton.Image = CType(resources.GetObject("FineMorsettoToolStripButton.Image"), Image)
        FineMorsettoToolStripButton.ImageTransparentColor = Color.Magenta
        FineMorsettoToolStripButton.Name = "FineMorsettoToolStripButton"
        FineMorsettoToolStripButton.Size = New Size(23, 22)
        FineMorsettoToolStripButton.Text = "ToolStripButton4"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 25)
        ' 
        ' NuovoMorsettoToolStripButton
        ' 
        NuovoMorsettoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        NuovoMorsettoToolStripButton.Image = CType(resources.GetObject("NuovoMorsettoToolStripButton.Image"), Image)
        NuovoMorsettoToolStripButton.ImageTransparentColor = Color.Magenta
        NuovoMorsettoToolStripButton.Name = "NuovoMorsettoToolStripButton"
        NuovoMorsettoToolStripButton.Size = New Size(23, 22)
        NuovoMorsettoToolStripButton.Text = "ToolStripButton5"
        ' 
        ' SalvaMorsettoToolStripButton
        ' 
        SalvaMorsettoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        SalvaMorsettoToolStripButton.Image = CType(resources.GetObject("SalvaMorsettoToolStripButton.Image"), Image)
        SalvaMorsettoToolStripButton.ImageTransparentColor = Color.Magenta
        SalvaMorsettoToolStripButton.Name = "SalvaMorsettoToolStripButton"
        SalvaMorsettoToolStripButton.Size = New Size(23, 22)
        SalvaMorsettoToolStripButton.Text = "ToolStripButton6"
        ' 
        ' EliminaMorsettoToolStripButton
        ' 
        EliminaMorsettoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        EliminaMorsettoToolStripButton.Image = CType(resources.GetObject("EliminaMorsettoToolStripButton.Image"), Image)
        EliminaMorsettoToolStripButton.ImageTransparentColor = Color.Magenta
        EliminaMorsettoToolStripButton.Name = "EliminaMorsettoToolStripButton"
        EliminaMorsettoToolStripButton.Size = New Size(23, 22)
        EliminaMorsettoToolStripButton.Text = "ToolStripButton7"
        ' 
        ' ModificaMorsettoToolStripButton
        ' 
        ModificaMorsettoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ModificaMorsettoToolStripButton.Image = CType(resources.GetObject("ModificaMorsettoToolStripButton.Image"), Image)
        ModificaMorsettoToolStripButton.ImageTransparentColor = Color.Magenta
        ModificaMorsettoToolStripButton.Name = "ModificaMorsettoToolStripButton"
        ModificaMorsettoToolStripButton.Size = New Size(23, 22)
        ModificaMorsettoToolStripButton.Text = "ToolStripButton8"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 25)
        ' 
        ' RicercaMorsettoToolStripButton
        ' 
        RicercaMorsettoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        RicercaMorsettoToolStripButton.Image = CType(resources.GetObject("RicercaMorsettoToolStripButton.Image"), Image)
        RicercaMorsettoToolStripButton.ImageTransparentColor = Color.Magenta
        RicercaMorsettoToolStripButton.Name = "RicercaMorsettoToolStripButton"
        RicercaMorsettoToolStripButton.Size = New Size(23, 22)
        RicercaMorsettoToolStripButton.Text = "ToolStripButton9"
        ' 
        ' AnnullaRicercaMorsettoToolStripButton
        ' 
        AnnullaRicercaMorsettoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AnnullaRicercaMorsettoToolStripButton.Image = CType(resources.GetObject("AnnullaRicercaMorsettoToolStripButton.Image"), Image)
        AnnullaRicercaMorsettoToolStripButton.ImageTransparentColor = Color.Magenta
        AnnullaRicercaMorsettoToolStripButton.Name = "AnnullaRicercaMorsettoToolStripButton"
        AnnullaRicercaMorsettoToolStripButton.Size = New Size(23, 22)
        AnnullaRicercaMorsettoToolStripButton.Text = "ToolStripButton10"
        ' 
        ' StampaMorsettoToolStripButton
        ' 
        StampaMorsettoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        StampaMorsettoToolStripButton.Image = CType(resources.GetObject("StampaMorsettoToolStripButton.Image"), Image)
        StampaMorsettoToolStripButton.ImageTransparentColor = Color.Magenta
        StampaMorsettoToolStripButton.Name = "StampaMorsettoToolStripButton"
        StampaMorsettoToolStripButton.Size = New Size(23, 22)
        StampaMorsettoToolStripButton.Text = "ToolStripButton11"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(6, 25)
        ' 
        ' EsportaDBMorsettoToolStripButton
        ' 
        EsportaDBMorsettoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        EsportaDBMorsettoToolStripButton.Image = CType(resources.GetObject("EsportaDBMorsettoToolStripButton.Image"), Image)
        EsportaDBMorsettoToolStripButton.ImageTransparentColor = Color.Magenta
        EsportaDBMorsettoToolStripButton.Name = "EsportaDBMorsettoToolStripButton"
        EsportaDBMorsettoToolStripButton.Size = New Size(23, 22)
        EsportaDBMorsettoToolStripButton.Text = "ToolStripButton12"
        ' 
        ' ImportaDBMorsettoToolStripButton
        ' 
        ImportaDBMorsettoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ImportaDBMorsettoToolStripButton.Image = CType(resources.GetObject("ImportaDBMorsettoToolStripButton.Image"), Image)
        ImportaDBMorsettoToolStripButton.ImageTransparentColor = Color.Magenta
        ImportaDBMorsettoToolStripButton.Name = "ImportaDBMorsettoToolStripButton"
        ImportaDBMorsettoToolStripButton.Size = New Size(23, 22)
        ImportaDBMorsettoToolStripButton.Text = "ToolStripButton13"
        ' 
        ' EliminaDBMorsettoToolStripButton
        ' 
        EliminaDBMorsettoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        EliminaDBMorsettoToolStripButton.Image = CType(resources.GetObject("EliminaDBMorsettoToolStripButton.Image"), Image)
        EliminaDBMorsettoToolStripButton.ImageTransparentColor = Color.Magenta
        EliminaDBMorsettoToolStripButton.Name = "EliminaDBMorsettoToolStripButton"
        EliminaDBMorsettoToolStripButton.Size = New Size(23, 22)
        EliminaDBMorsettoToolStripButton.Text = "ToolStripButton14"
        ' 
        ' ToolStripSeparator4
        ' 
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ToolStripSeparator4.Size = New Size(6, 25)
        ' 
        ' EsciMorsettoToolStripButton
        ' 
        EsciMorsettoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        EsciMorsettoToolStripButton.Image = CType(resources.GetObject("EsciMorsettoToolStripButton.Image"), Image)
        EsciMorsettoToolStripButton.ImageTransparentColor = Color.Magenta
        EsciMorsettoToolStripButton.Name = "EsciMorsettoToolStripButton"
        EsciMorsettoToolStripButton.Size = New Size(23, 22)
        EsciMorsettoToolStripButton.Text = "ToolStripButton15"
        ' 
        ' AiutoMorsettoToolStripButton
        ' 
        AiutoMorsettoToolStripButton.Alignment = ToolStripItemAlignment.Right
        AiutoMorsettoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AiutoMorsettoToolStripButton.Image = CType(resources.GetObject("AiutoMorsettoToolStripButton.Image"), Image)
        AiutoMorsettoToolStripButton.ImageTransparentColor = Color.Magenta
        AiutoMorsettoToolStripButton.Name = "AiutoMorsettoToolStripButton"
        AiutoMorsettoToolStripButton.Size = New Size(23, 22)
        AiutoMorsettoToolStripButton.Text = "ToolStripButton16"
        ' 
        ' NotificaTuboLabel
        ' 
        NotificaTuboLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        NotificaTuboLabel.BorderStyle = BorderStyle.Fixed3D
        NotificaTuboLabel.Location = New Point(12, 367)
        NotificaTuboLabel.Name = "NotificaTuboLabel"
        NotificaTuboLabel.Size = New Size(697, 52)
        NotificaTuboLabel.TabIndex = 3
        NotificaTuboLabel.Text = "Label1"
        ' 
        ' NotificaMorsettoStatusStrip
        ' 
        NotificaMorsettoStatusStrip.Items.AddRange(New ToolStripItem() {NotificaMorsettoToolStripStatusLabel})
        NotificaMorsettoStatusStrip.Location = New Point(0, 428)
        NotificaMorsettoStatusStrip.Name = "NotificaMorsettoStatusStrip"
        NotificaMorsettoStatusStrip.Size = New Size(721, 22)
        NotificaMorsettoStatusStrip.TabIndex = 4
        NotificaMorsettoStatusStrip.Text = "StatusStrip1"
        ' 
        ' NotificaMorsettoToolStripStatusLabel
        ' 
        NotificaMorsettoToolStripStatusLabel.Name = "NotificaMorsettoToolStripStatusLabel"
        NotificaMorsettoToolStripStatusLabel.Size = New Size(204, 17)
        NotificaMorsettoToolStripStatusLabel.Text = "NotificaMorsettoToolStripStatusLabel"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 15)
        Label1.TabIndex = 5
        Label1.Text = "Marca :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(183, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 15)
        Label2.TabIndex = 6
        Label2.Text = "Tipo morsetto :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(428, 49)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 15)
        Label3.TabIndex = 7
        Label3.Text = "Sezione (mmq):"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(27, 108)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 15)
        Label4.TabIndex = 8
        Label4.Text = "Note :"
        ' 
        ' MarcaMorsettiTextBox
        ' 
        MarcaMorsettiTextBox.Location = New Point(27, 67)
        MarcaMorsettiTextBox.Name = "MarcaMorsettiTextBox"
        MarcaMorsettiTextBox.Size = New Size(100, 23)
        MarcaMorsettiTextBox.TabIndex = 1
        ' 
        ' TipoMorsettiTextBox
        ' 
        TipoMorsettiTextBox.Location = New Point(183, 67)
        TipoMorsettiTextBox.Name = "TipoMorsettiTextBox"
        TipoMorsettiTextBox.Size = New Size(194, 23)
        TipoMorsettiTextBox.TabIndex = 2
        ' 
        ' SezioneMorsettiTextBox
        ' 
        SezioneMorsettiTextBox.Location = New Point(428, 67)
        SezioneMorsettiTextBox.Name = "SezioneMorsettiTextBox"
        SezioneMorsettiTextBox.Size = New Size(100, 23)
        SezioneMorsettiTextBox.TabIndex = 3
        ' 
        ' NoteMorsettiTextBox
        ' 
        NoteMorsettiTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        NoteMorsettiTextBox.Location = New Point(27, 126)
        NoteMorsettiTextBox.Multiline = True
        NoteMorsettiTextBox.Name = "NoteMorsettiTextBox"
        NoteMorsettiTextBox.ScrollBars = ScrollBars.Vertical
        NoteMorsettiTextBox.Size = New Size(682, 52)
        NoteMorsettiTextBox.TabIndex = 5
        ' 
        ' SupOccupataTextBox
        ' 
        SupOccupataTextBox.Location = New Point(575, 67)
        SupOccupataTextBox.Name = "SupOccupataTextBox"
        SupOccupataTextBox.Size = New Size(134, 23)
        SupOccupataTextBox.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(575, 49)
        Label5.Name = "Label5"
        Label5.Size = New Size(137, 15)
        Label5.TabIndex = 14
        Label5.Text = "Sup.ce occupata (mmq):"
        ' 
        ' LibMorsettoDataGridView
        ' 
        LibMorsettoDataGridView.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        LibMorsettoDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        LibMorsettoDataGridView.Location = New Point(12, 184)
        LibMorsettoDataGridView.Name = "LibMorsettoDataGridView"
        LibMorsettoDataGridView.Size = New Size(697, 180)
        LibMorsettoDataGridView.TabIndex = 15
        ' 
        ' FormMorsetto
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(721, 450)
        Controls.Add(LibMorsettoDataGridView)
        Controls.Add(Label5)
        Controls.Add(SupOccupataTextBox)
        Controls.Add(NoteMorsettiTextBox)
        Controls.Add(SezioneMorsettiTextBox)
        Controls.Add(TipoMorsettiTextBox)
        Controls.Add(MarcaMorsettiTextBox)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(NotificaMorsettoStatusStrip)
        Controls.Add(NotificaTuboLabel)
        Controls.Add(MorsettoToolStrip)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FormMorsetto"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Morsetto"
        MorsettoToolStrip.ResumeLayout(False)
        MorsettoToolStrip.PerformLayout()
        NotificaMorsettoStatusStrip.ResumeLayout(False)
        NotificaMorsettoStatusStrip.PerformLayout()
        CType(LibMorsettoDataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MorsettoToolStrip As ToolStrip
    Friend WithEvents InizioMorsettoToolStripButton As ToolStripButton
    Friend WithEvents IndietroMorsettoToolStripButton As ToolStripButton
    Friend WithEvents RecordMorsettoToolStripLabel As ToolStripLabel
    Friend WithEvents AvantiMorsettoToolStripButton As ToolStripButton
    Friend WithEvents FineMorsettoToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents NuovoMorsettoToolStripButton As ToolStripButton
    Friend WithEvents SalvaMorsettoToolStripButton As ToolStripButton
    Friend WithEvents EliminaMorsettoToolStripButton As ToolStripButton
    Friend WithEvents ModificaMorsettoToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents RicercaMorsettoToolStripButton As ToolStripButton
    Friend WithEvents AnnullaRicercaMorsettoToolStripButton As ToolStripButton
    Friend WithEvents StampaMorsettoToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents EsportaDBMorsettoToolStripButton As ToolStripButton
    Friend WithEvents ImportaDBMorsettoToolStripButton As ToolStripButton
    Friend WithEvents EliminaDBMorsettoToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents EsciMorsettoToolStripButton As ToolStripButton
    Friend WithEvents AiutoMorsettoToolStripButton As ToolStripButton
    Friend WithEvents NotificaTuboLabel As Label
    Friend WithEvents NotificaMorsettoStatusStrip As StatusStrip
    Friend WithEvents NotificaMorsettoToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MarcaMorsettiTextBox As TextBox
    Friend WithEvents TipoMorsettiTextBox As TextBox
    Friend WithEvents SezioneMorsettiTextBox As TextBox
    Friend WithEvents NoteMorsettiTextBox As TextBox
    Friend WithEvents SupOccupataTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LibMorsettoDataGridView As DataGridView
End Class
