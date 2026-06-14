<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormScatola
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormScatola))
        NotificaScatolaLabel = New Label()
        ScatolaToolStrip = New ToolStrip()
        InizioScatolaToolStripButton = New ToolStripButton()
        IndietroScatolaToolStripButton = New ToolStripButton()
        RecordToolStripLabel = New ToolStripLabel()
        AvantiScatolaToolStripButton = New ToolStripButton()
        FineScatolaToolStripButton = New ToolStripButton()
        ToolStripSeparator1 = New ToolStripSeparator()
        NuovoScatolaToolStripButton = New ToolStripButton()
        SalvaScatolaToolStripButton = New ToolStripButton()
        ModificaScatolaToolStripButton = New ToolStripButton()
        EliminaScatolaToolStripButton = New ToolStripButton()
        ToolStripSeparator2 = New ToolStripSeparator()
        RicercaScatolaToolStripButton = New ToolStripButton()
        AnnullaRicercaScatolaToolStripButton = New ToolStripButton()
        StampaScatolaToolStripButton = New ToolStripDropDownButton()
        StampaDaSelezioneToolStripMenuItem = New ToolStripMenuItem()
        StampaReportElementiToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator3 = New ToolStripSeparator()
        EsportaDBScatolaToolStripButton = New ToolStripButton()
        ImportaDBScatolaToolStripButton = New ToolStripButton()
        EliminaDBScatolaToolStripButton = New ToolStripButton()
        ToolStripSeparator4 = New ToolStripSeparator()
        EsciScatolaToolStripButton = New ToolStripButton()
        AiutoScatolaToolStripButton = New ToolStripButton()
        NotificaScatolaStatusStrip = New StatusStrip()
        NotificaScatolaToolStripStatusLabel = New ToolStripStatusLabel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        MarcaScatolaTextBox = New TextBox()
        CodiceScatolaTextBox = New TextBox()
        LarghezzaScatolaTextBox = New TextBox()
        AltezzaScatolaTextBox = New TextBox()
        ProfonditaScatolaTextBox = New TextBox()
        ForiPosterioriTextBox = New TextBox()
        SettLargSSTextBox = New TextBox()
        SettAltSSTextBox = New TextBox()
        SettLargLateraliTextBox = New TextBox()
        SettAltLateraliTextBox = New TextBox()
        NoteScatolaTextBox = New TextBox()
        LibScatolaDataGridView = New DataGridView()
        TipoPosaComboBox = New ComboBox()
        Label14 = New Label()
        DivisorioScatolaTextBox = New TextBox()
        VolumeTotaleTextBox = New TextBox()
        VolumeScompartoTextBox = New TextBox()
        AreaUtileSSTextBox = New TextBox()
        AreaUtileLateraleTextBox = New TextBox()
        Label8 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        Label20 = New Label()
        Label21 = New Label()
        Label22 = New Label()
        ScatolaToolStrip.SuspendLayout()
        NotificaScatolaStatusStrip.SuspendLayout()
        CType(LibScatolaDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' NotificaScatolaLabel
        ' 
        NotificaScatolaLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        NotificaScatolaLabel.BorderStyle = BorderStyle.Fixed3D
        NotificaScatolaLabel.Location = New Point(12, 482)
        NotificaScatolaLabel.Name = "NotificaScatolaLabel"
        NotificaScatolaLabel.Size = New Size(802, 58)
        NotificaScatolaLabel.TabIndex = 1
        NotificaScatolaLabel.Text = "Label1"
        ' 
        ' ScatolaToolStrip
        ' 
        ScatolaToolStrip.BackColor = SystemColors.ControlDark
        ScatolaToolStrip.GripStyle = ToolStripGripStyle.Hidden
        ScatolaToolStrip.Items.AddRange(New ToolStripItem() {InizioScatolaToolStripButton, IndietroScatolaToolStripButton, RecordToolStripLabel, AvantiScatolaToolStripButton, FineScatolaToolStripButton, ToolStripSeparator1, NuovoScatolaToolStripButton, SalvaScatolaToolStripButton, ModificaScatolaToolStripButton, EliminaScatolaToolStripButton, ToolStripSeparator2, RicercaScatolaToolStripButton, AnnullaRicercaScatolaToolStripButton, StampaScatolaToolStripButton, ToolStripSeparator3, EsportaDBScatolaToolStripButton, ImportaDBScatolaToolStripButton, EliminaDBScatolaToolStripButton, ToolStripSeparator4, EsciScatolaToolStripButton, AiutoScatolaToolStripButton})
        ScatolaToolStrip.Location = New Point(0, 0)
        ScatolaToolStrip.Name = "ScatolaToolStrip"
        ScatolaToolStrip.Size = New Size(826, 25)
        ScatolaToolStrip.TabIndex = 4
        ScatolaToolStrip.Text = "ToolStrip1"
        ' 
        ' InizioScatolaToolStripButton
        ' 
        InizioScatolaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        InizioScatolaToolStripButton.Image = CType(resources.GetObject("InizioScatolaToolStripButton.Image"), Image)
        InizioScatolaToolStripButton.ImageTransparentColor = Color.Magenta
        InizioScatolaToolStripButton.Name = "InizioScatolaToolStripButton"
        InizioScatolaToolStripButton.Size = New Size(23, 22)
        InizioScatolaToolStripButton.Text = "ToolStripButton1"
        InizioScatolaToolStripButton.ToolTipText = "Vai all'inizio"
        ' 
        ' IndietroScatolaToolStripButton
        ' 
        IndietroScatolaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        IndietroScatolaToolStripButton.Image = CType(resources.GetObject("IndietroScatolaToolStripButton.Image"), Image)
        IndietroScatolaToolStripButton.ImageTransparentColor = Color.Magenta
        IndietroScatolaToolStripButton.Name = "IndietroScatolaToolStripButton"
        IndietroScatolaToolStripButton.Size = New Size(23, 22)
        IndietroScatolaToolStripButton.Text = "ToolStripButton2"
        IndietroScatolaToolStripButton.ToolTipText = "Vai indietro"
        ' 
        ' RecordToolStripLabel
        ' 
        RecordToolStripLabel.Name = "RecordToolStripLabel"
        RecordToolStripLabel.Size = New Size(88, 22)
        RecordToolStripLabel.Text = "- Navigazione -"
        ' 
        ' AvantiScatolaToolStripButton
        ' 
        AvantiScatolaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AvantiScatolaToolStripButton.Image = CType(resources.GetObject("AvantiScatolaToolStripButton.Image"), Image)
        AvantiScatolaToolStripButton.ImageTransparentColor = Color.Magenta
        AvantiScatolaToolStripButton.Name = "AvantiScatolaToolStripButton"
        AvantiScatolaToolStripButton.Size = New Size(23, 22)
        AvantiScatolaToolStripButton.Text = "ToolStripButton3"
        AvantiScatolaToolStripButton.ToolTipText = "Vai avanti"
        ' 
        ' FineScatolaToolStripButton
        ' 
        FineScatolaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        FineScatolaToolStripButton.Image = CType(resources.GetObject("FineScatolaToolStripButton.Image"), Image)
        FineScatolaToolStripButton.ImageTransparentColor = Color.Magenta
        FineScatolaToolStripButton.Name = "FineScatolaToolStripButton"
        FineScatolaToolStripButton.Size = New Size(23, 22)
        FineScatolaToolStripButton.Text = "ToolStripButton4"
        FineScatolaToolStripButton.ToolTipText = "Vai alla fine"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 25)
        ' 
        ' NuovoScatolaToolStripButton
        ' 
        NuovoScatolaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        NuovoScatolaToolStripButton.Image = CType(resources.GetObject("NuovoScatolaToolStripButton.Image"), Image)
        NuovoScatolaToolStripButton.ImageTransparentColor = Color.Magenta
        NuovoScatolaToolStripButton.Name = "NuovoScatolaToolStripButton"
        NuovoScatolaToolStripButton.Size = New Size(23, 22)
        NuovoScatolaToolStripButton.Text = "ToolStripButton5"
        NuovoScatolaToolStripButton.ToolTipText = "Nuovo record"
        ' 
        ' SalvaScatolaToolStripButton
        ' 
        SalvaScatolaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        SalvaScatolaToolStripButton.Image = CType(resources.GetObject("SalvaScatolaToolStripButton.Image"), Image)
        SalvaScatolaToolStripButton.ImageTransparentColor = Color.Magenta
        SalvaScatolaToolStripButton.Name = "SalvaScatolaToolStripButton"
        SalvaScatolaToolStripButton.Size = New Size(23, 22)
        SalvaScatolaToolStripButton.Text = "ToolStripButton6"
        SalvaScatolaToolStripButton.ToolTipText = "Salva dati"
        ' 
        ' ModificaScatolaToolStripButton
        ' 
        ModificaScatolaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ModificaScatolaToolStripButton.Image = CType(resources.GetObject("ModificaScatolaToolStripButton.Image"), Image)
        ModificaScatolaToolStripButton.ImageTransparentColor = Color.Magenta
        ModificaScatolaToolStripButton.Name = "ModificaScatolaToolStripButton"
        ModificaScatolaToolStripButton.Size = New Size(23, 22)
        ModificaScatolaToolStripButton.Text = "ToolStripButton8"
        ModificaScatolaToolStripButton.ToolTipText = "Modifica dati selezionati"
        ' 
        ' EliminaScatolaToolStripButton
        ' 
        EliminaScatolaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        EliminaScatolaToolStripButton.Image = CType(resources.GetObject("EliminaScatolaToolStripButton.Image"), Image)
        EliminaScatolaToolStripButton.ImageTransparentColor = Color.Magenta
        EliminaScatolaToolStripButton.Name = "EliminaScatolaToolStripButton"
        EliminaScatolaToolStripButton.Size = New Size(23, 22)
        EliminaScatolaToolStripButton.Text = "ToolStripButton7"
        EliminaScatolaToolStripButton.ToolTipText = "Elimina dati selezionati"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 25)
        ' 
        ' RicercaScatolaToolStripButton
        ' 
        RicercaScatolaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        RicercaScatolaToolStripButton.Image = CType(resources.GetObject("RicercaScatolaToolStripButton.Image"), Image)
        RicercaScatolaToolStripButton.ImageTransparentColor = Color.Magenta
        RicercaScatolaToolStripButton.Name = "RicercaScatolaToolStripButton"
        RicercaScatolaToolStripButton.Size = New Size(23, 22)
        RicercaScatolaToolStripButton.Text = "ToolStripButton9"
        RicercaScatolaToolStripButton.ToolTipText = "Ricerca dati"
        ' 
        ' AnnullaRicercaScatolaToolStripButton
        ' 
        AnnullaRicercaScatolaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AnnullaRicercaScatolaToolStripButton.Image = CType(resources.GetObject("AnnullaRicercaScatolaToolStripButton.Image"), Image)
        AnnullaRicercaScatolaToolStripButton.ImageTransparentColor = Color.Magenta
        AnnullaRicercaScatolaToolStripButton.Name = "AnnullaRicercaScatolaToolStripButton"
        AnnullaRicercaScatolaToolStripButton.Size = New Size(23, 22)
        AnnullaRicercaScatolaToolStripButton.Text = "ToolStripButton10"
        AnnullaRicercaScatolaToolStripButton.ToolTipText = "Annulla ricerca"
        ' 
        ' StampaScatolaToolStripButton
        ' 
        StampaScatolaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        StampaScatolaToolStripButton.DropDownItems.AddRange(New ToolStripItem() {StampaDaSelezioneToolStripMenuItem, StampaReportElementiToolStripMenuItem})
        StampaScatolaToolStripButton.Image = CType(resources.GetObject("StampaScatolaToolStripButton.Image"), Image)
        StampaScatolaToolStripButton.ImageTransparentColor = Color.Magenta
        StampaScatolaToolStripButton.Name = "StampaScatolaToolStripButton"
        StampaScatolaToolStripButton.Size = New Size(29, 22)
        StampaScatolaToolStripButton.Text = "ToolStripButton11"
        StampaScatolaToolStripButton.ToolTipText = " "
        ' 
        ' StampaDaSelezioneToolStripMenuItem
        ' 
        StampaDaSelezioneToolStripMenuItem.Name = "StampaDaSelezioneToolStripMenuItem"
        StampaDaSelezioneToolStripMenuItem.Size = New Size(219, 22)
        StampaDaSelezioneToolStripMenuItem.Text = "Stampa Report da selezione"
        StampaDaSelezioneToolStripMenuItem.ToolTipText = "Stampa Report dei dati Visualizzati"
        ' 
        ' StampaReportElementiToolStripMenuItem
        ' 
        StampaReportElementiToolStripMenuItem.Name = "StampaReportElementiToolStripMenuItem"
        StampaReportElementiToolStripMenuItem.Size = New Size(219, 22)
        StampaReportElementiToolStripMenuItem.Text = "Stampa Report elemnti"
        StampaReportElementiToolStripMenuItem.ToolTipText = "Stampa Report dei dati presenti nel Data Base"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(6, 25)
        ' 
        ' EsportaDBScatolaToolStripButton
        ' 
        EsportaDBScatolaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        EsportaDBScatolaToolStripButton.Image = CType(resources.GetObject("EsportaDBScatolaToolStripButton.Image"), Image)
        EsportaDBScatolaToolStripButton.ImageTransparentColor = Color.Magenta
        EsportaDBScatolaToolStripButton.Name = "EsportaDBScatolaToolStripButton"
        EsportaDBScatolaToolStripButton.Size = New Size(23, 22)
        EsportaDBScatolaToolStripButton.Text = "ToolStripButton12"
        EsportaDBScatolaToolStripButton.ToolTipText = "Esporta Data Base"
        ' 
        ' ImportaDBScatolaToolStripButton
        ' 
        ImportaDBScatolaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ImportaDBScatolaToolStripButton.Image = CType(resources.GetObject("ImportaDBScatolaToolStripButton.Image"), Image)
        ImportaDBScatolaToolStripButton.ImageTransparentColor = Color.Magenta
        ImportaDBScatolaToolStripButton.Name = "ImportaDBScatolaToolStripButton"
        ImportaDBScatolaToolStripButton.Size = New Size(23, 22)
        ImportaDBScatolaToolStripButton.Text = "ToolStripButton13"
        ImportaDBScatolaToolStripButton.ToolTipText = "Importa Data Base"
        ' 
        ' EliminaDBScatolaToolStripButton
        ' 
        EliminaDBScatolaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        EliminaDBScatolaToolStripButton.Image = CType(resources.GetObject("EliminaDBScatolaToolStripButton.Image"), Image)
        EliminaDBScatolaToolStripButton.ImageTransparentColor = Color.Magenta
        EliminaDBScatolaToolStripButton.Name = "EliminaDBScatolaToolStripButton"
        EliminaDBScatolaToolStripButton.Size = New Size(23, 22)
        EliminaDBScatolaToolStripButton.Text = "ToolStripButton14"
        EliminaDBScatolaToolStripButton.ToolTipText = "Ripulisci Data Base"
        ' 
        ' ToolStripSeparator4
        ' 
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ToolStripSeparator4.Size = New Size(6, 25)
        ' 
        ' EsciScatolaToolStripButton
        ' 
        EsciScatolaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        EsciScatolaToolStripButton.Image = CType(resources.GetObject("EsciScatolaToolStripButton.Image"), Image)
        EsciScatolaToolStripButton.ImageTransparentColor = Color.Magenta
        EsciScatolaToolStripButton.Name = "EsciScatolaToolStripButton"
        EsciScatolaToolStripButton.Size = New Size(23, 22)
        EsciScatolaToolStripButton.Text = "ToolStripButton15"
        EsciScatolaToolStripButton.ToolTipText = "Chiudi finestra Scatola"
        ' 
        ' AiutoScatolaToolStripButton
        ' 
        AiutoScatolaToolStripButton.Alignment = ToolStripItemAlignment.Right
        AiutoScatolaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AiutoScatolaToolStripButton.Image = CType(resources.GetObject("AiutoScatolaToolStripButton.Image"), Image)
        AiutoScatolaToolStripButton.ImageTransparentColor = Color.Magenta
        AiutoScatolaToolStripButton.Name = "AiutoScatolaToolStripButton"
        AiutoScatolaToolStripButton.Size = New Size(23, 22)
        AiutoScatolaToolStripButton.Text = "ToolStripButton16"
        AiutoScatolaToolStripButton.ToolTipText = "Aiuto scatola"
        ' 
        ' NotificaScatolaStatusStrip
        ' 
        NotificaScatolaStatusStrip.Items.AddRange(New ToolStripItem() {NotificaScatolaToolStripStatusLabel})
        NotificaScatolaStatusStrip.Location = New Point(0, 549)
        NotificaScatolaStatusStrip.Name = "NotificaScatolaStatusStrip"
        NotificaScatolaStatusStrip.Size = New Size(826, 22)
        NotificaScatolaStatusStrip.TabIndex = 5
        NotificaScatolaStatusStrip.Text = "StatusStrip1"
        ' 
        ' NotificaScatolaToolStripStatusLabel
        ' 
        NotificaScatolaToolStripStatusLabel.Name = "NotificaScatolaToolStripStatusLabel"
        NotificaScatolaToolStripStatusLabel.Size = New Size(194, 17)
        NotificaScatolaToolStripStatusLabel.Text = "NotificaScatolaToolStripStatusLabel"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(18, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 15)
        Label1.TabIndex = 6
        Label1.Text = "Marca :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(131, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 15)
        Label2.TabIndex = 7
        Label2.Text = "Codice scatola :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(275, 43)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 15)
        Label3.TabIndex = 8
        Label3.Text = "Tipo posa :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(439, 43)
        Label4.Name = "Label4"
        Label4.Size = New Size(95, 15)
        Label4.TabIndex = 9
        Label4.Text = "Larghezza (mm):"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(568, 43)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 15)
        Label5.TabIndex = 10
        Label5.Text = "Altezza (mm):"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(695, 47)
        Label6.Name = "Label6"
        Label6.Size = New Size(99, 15)
        Label6.TabIndex = 11
        Label6.Text = "Profondità (mm):"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(18, 96)
        Label7.Name = "Label7"
        Label7.Size = New Size(110, 15)
        Label7.TabIndex = 12
        Label7.Text = "Forature posteriori :"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(275, 96)
        Label9.Name = "Label9"
        Label9.Size = New Size(120, 15)
        Label9.TabIndex = 14
        Label9.Text = "Sett.larg.sopra/sotto :"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(439, 96)
        Label10.Name = "Label10"
        Label10.Size = New Size(113, 15)
        Label10.TabIndex = 15
        Label10.Text = "Sett.alt.sopra/sotto :"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(568, 96)
        Label11.Name = "Label11"
        Label11.Size = New Size(94, 15)
        Label11.TabIndex = 16
        Label11.Text = "Sett.larg.laterali :"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(695, 96)
        Label12.Name = "Label12"
        Label12.Size = New Size(87, 15)
        Label12.TabIndex = 17
        Label12.Text = "Sett.alt.laterali :"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(374, 149)
        Label13.Name = "Label13"
        Label13.Size = New Size(39, 15)
        Label13.TabIndex = 18
        Label13.Text = "Note :"
        ' 
        ' MarcaScatolaTextBox
        ' 
        MarcaScatolaTextBox.Location = New Point(18, 61)
        MarcaScatolaTextBox.Name = "MarcaScatolaTextBox"
        MarcaScatolaTextBox.ReadOnly = True
        MarcaScatolaTextBox.Size = New Size(100, 23)
        MarcaScatolaTextBox.TabIndex = 1
        ' 
        ' CodiceScatolaTextBox
        ' 
        CodiceScatolaTextBox.Location = New Point(131, 61)
        CodiceScatolaTextBox.Name = "CodiceScatolaTextBox"
        CodiceScatolaTextBox.ReadOnly = True
        CodiceScatolaTextBox.Size = New Size(111, 23)
        CodiceScatolaTextBox.TabIndex = 2
        ' 
        ' LarghezzaScatolaTextBox
        ' 
        LarghezzaScatolaTextBox.Location = New Point(439, 61)
        LarghezzaScatolaTextBox.Name = "LarghezzaScatolaTextBox"
        LarghezzaScatolaTextBox.ReadOnly = True
        LarghezzaScatolaTextBox.Size = New Size(87, 23)
        LarghezzaScatolaTextBox.TabIndex = 4
        ' 
        ' AltezzaScatolaTextBox
        ' 
        AltezzaScatolaTextBox.Location = New Point(568, 61)
        AltezzaScatolaTextBox.Name = "AltezzaScatolaTextBox"
        AltezzaScatolaTextBox.ReadOnly = True
        AltezzaScatolaTextBox.Size = New Size(100, 23)
        AltezzaScatolaTextBox.TabIndex = 5
        ' 
        ' ProfonditaScatolaTextBox
        ' 
        ProfonditaScatolaTextBox.Location = New Point(695, 65)
        ProfonditaScatolaTextBox.Name = "ProfonditaScatolaTextBox"
        ProfonditaScatolaTextBox.ReadOnly = True
        ProfonditaScatolaTextBox.Size = New Size(100, 23)
        ProfonditaScatolaTextBox.TabIndex = 6
        ' 
        ' ForiPosterioriTextBox
        ' 
        ForiPosterioriTextBox.Location = New Point(18, 114)
        ForiPosterioriTextBox.Name = "ForiPosterioriTextBox"
        ForiPosterioriTextBox.ReadOnly = True
        ForiPosterioriTextBox.Size = New Size(111, 23)
        ForiPosterioriTextBox.TabIndex = 7
        ' 
        ' SettLargSSTextBox
        ' 
        SettLargSSTextBox.Location = New Point(275, 114)
        SettLargSSTextBox.Name = "SettLargSSTextBox"
        SettLargSSTextBox.ReadOnly = True
        SettLargSSTextBox.Size = New Size(87, 23)
        SettLargSSTextBox.TabIndex = 9
        ' 
        ' SettAltSSTextBox
        ' 
        SettAltSSTextBox.Location = New Point(439, 114)
        SettAltSSTextBox.Name = "SettAltSSTextBox"
        SettAltSSTextBox.ReadOnly = True
        SettAltSSTextBox.Size = New Size(100, 23)
        SettAltSSTextBox.TabIndex = 10
        ' 
        ' SettLargLateraliTextBox
        ' 
        SettLargLateraliTextBox.Location = New Point(568, 114)
        SettLargLateraliTextBox.Name = "SettLargLateraliTextBox"
        SettLargLateraliTextBox.ReadOnly = True
        SettLargLateraliTextBox.Size = New Size(94, 23)
        SettLargLateraliTextBox.TabIndex = 11
        ' 
        ' SettAltLateraliTextBox
        ' 
        SettAltLateraliTextBox.Location = New Point(695, 114)
        SettAltLateraliTextBox.Name = "SettAltLateraliTextBox"
        SettAltLateraliTextBox.ReadOnly = True
        SettAltLateraliTextBox.Size = New Size(87, 23)
        SettAltLateraliTextBox.TabIndex = 12
        ' 
        ' NoteScatolaTextBox
        ' 
        NoteScatolaTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        NoteScatolaTextBox.Location = New Point(18, 167)
        NoteScatolaTextBox.Multiline = True
        NoteScatolaTextBox.Name = "NoteScatolaTextBox"
        NoteScatolaTextBox.ReadOnly = True
        NoteScatolaTextBox.ScrollBars = ScrollBars.Vertical
        NoteScatolaTextBox.Size = New Size(796, 47)
        NoteScatolaTextBox.TabIndex = 13
        ' 
        ' LibScatolaDataGridView
        ' 
        LibScatolaDataGridView.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        LibScatolaDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        LibScatolaDataGridView.Location = New Point(12, 312)
        LibScatolaDataGridView.Name = "LibScatolaDataGridView"
        LibScatolaDataGridView.ReadOnly = True
        LibScatolaDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        LibScatolaDataGridView.Size = New Size(802, 160)
        LibScatolaDataGridView.TabIndex = 14
        ' 
        ' TipoPosaComboBox
        ' 
        TipoPosaComboBox.Enabled = False
        TipoPosaComboBox.FormattingEnabled = True
        TipoPosaComboBox.Items.AddRange(New Object() {"Incasso", "Parete", "Pareti leggere"})
        TipoPosaComboBox.Location = New Point(275, 61)
        TipoPosaComboBox.Name = "TipoPosaComboBox"
        TipoPosaComboBox.Size = New Size(132, 23)
        TipoPosaComboBox.TabIndex = 3
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(135, 96)
        Label14.Name = "Label14"
        Label14.Size = New Size(104, 15)
        Label14.TabIndex = 19
        Label14.Text = "n° Divisori interni :"
        ' 
        ' DivisorioScatolaTextBox
        ' 
        DivisorioScatolaTextBox.Location = New Point(135, 114)
        DivisorioScatolaTextBox.Name = "DivisorioScatolaTextBox"
        DivisorioScatolaTextBox.ReadOnly = True
        DivisorioScatolaTextBox.Size = New Size(111, 23)
        DivisorioScatolaTextBox.TabIndex = 8
        ' 
        ' VolumeTotaleTextBox
        ' 
        VolumeTotaleTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        VolumeTotaleTextBox.Location = New Point(32, 276)
        VolumeTotaleTextBox.Name = "VolumeTotaleTextBox"
        VolumeTotaleTextBox.ReadOnly = True
        VolumeTotaleTextBox.Size = New Size(100, 23)
        VolumeTotaleTextBox.TabIndex = 21
        ' 
        ' VolumeScompartoTextBox
        ' 
        VolumeScompartoTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        VolumeScompartoTextBox.Location = New Point(216, 276)
        VolumeScompartoTextBox.Name = "VolumeScompartoTextBox"
        VolumeScompartoTextBox.ReadOnly = True
        VolumeScompartoTextBox.Size = New Size(100, 23)
        VolumeScompartoTextBox.TabIndex = 22
        ' 
        ' AreaUtileSSTextBox
        ' 
        AreaUtileSSTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        AreaUtileSSTextBox.Location = New Point(426, 276)
        AreaUtileSSTextBox.Name = "AreaUtileSSTextBox"
        AreaUtileSSTextBox.ReadOnly = True
        AreaUtileSSTextBox.Size = New Size(100, 23)
        AreaUtileSSTextBox.TabIndex = 23
        ' 
        ' AreaUtileLateraleTextBox
        ' 
        AreaUtileLateraleTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        AreaUtileLateraleTextBox.Location = New Point(656, 276)
        AreaUtileLateraleTextBox.Name = "AreaUtileLateraleTextBox"
        AreaUtileLateraleTextBox.ReadOnly = True
        AreaUtileLateraleTextBox.Size = New Size(100, 23)
        AreaUtileLateraleTextBox.TabIndex = 24
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Location = New Point(656, 256)
        Label8.Name = "Label8"
        Label8.Size = New Size(108, 15)
        Label8.TabIndex = 25
        Label8.Text = "Area Utile Laterale :"
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label15.AutoSize = True
        Label15.Location = New Point(426, 256)
        Label15.Name = "Label15"
        Label15.Size = New Size(129, 15)
        Label15.TabIndex = 26
        Label15.Text = "Area Utile Sopra/sotto :"
        ' 
        ' Label16
        ' 
        Label16.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label16.AutoSize = True
        Label16.Location = New Point(216, 256)
        Label16.Name = "Label16"
        Label16.Size = New Size(114, 15)
        Label16.TabIndex = 27
        Label16.Text = "Volume Scomparto :"
        ' 
        ' Label17
        ' 
        Label17.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label17.AutoSize = True
        Label17.Location = New Point(32, 256)
        Label17.Name = "Label17"
        Label17.Size = New Size(88, 15)
        Label17.TabIndex = 28
        Label17.Text = "Volume Totale :"
        ' 
        ' Label18
        ' 
        Label18.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label18.Location = New Point(18, 224)
        Label18.Name = "Label18"
        Label18.Size = New Size(796, 23)
        Label18.TabIndex = 29
        Label18.Text = "--- Area di Calcolo ---"
        Label18.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(134, 285)
        Label19.Name = "Label19"
        Label19.Size = New Size(30, 15)
        Label19.TabIndex = 30
        Label19.Text = "Cm³"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(329, 284)
        Label20.Name = "Label20"
        Label20.Size = New Size(30, 15)
        Label20.TabIndex = 31
        Label20.Text = "Cm³"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(532, 284)
        Label21.Name = "Label21"
        Label21.Size = New Size(33, 15)
        Label21.TabIndex = 32
        Label21.Text = "mm²"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(762, 284)
        Label22.Name = "Label22"
        Label22.Size = New Size(33, 15)
        Label22.TabIndex = 33
        Label22.Text = "mm²"
        ' 
        ' FormScatola
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(826, 571)
        Controls.Add(Label22)
        Controls.Add(Label21)
        Controls.Add(Label20)
        Controls.Add(Label19)
        Controls.Add(Label18)
        Controls.Add(Label17)
        Controls.Add(Label16)
        Controls.Add(Label15)
        Controls.Add(Label8)
        Controls.Add(AreaUtileLateraleTextBox)
        Controls.Add(AreaUtileSSTextBox)
        Controls.Add(VolumeScompartoTextBox)
        Controls.Add(VolumeTotaleTextBox)
        Controls.Add(DivisorioScatolaTextBox)
        Controls.Add(Label14)
        Controls.Add(TipoPosaComboBox)
        Controls.Add(LibScatolaDataGridView)
        Controls.Add(NoteScatolaTextBox)
        Controls.Add(SettAltLateraliTextBox)
        Controls.Add(SettLargLateraliTextBox)
        Controls.Add(SettAltSSTextBox)
        Controls.Add(SettLargSSTextBox)
        Controls.Add(ForiPosterioriTextBox)
        Controls.Add(ProfonditaScatolaTextBox)
        Controls.Add(AltezzaScatolaTextBox)
        Controls.Add(LarghezzaScatolaTextBox)
        Controls.Add(CodiceScatolaTextBox)
        Controls.Add(MarcaScatolaTextBox)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(NotificaScatolaStatusStrip)
        Controls.Add(ScatolaToolStrip)
        Controls.Add(NotificaScatolaLabel)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormScatola"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Scatola"
        ScatolaToolStrip.ResumeLayout(False)
        ScatolaToolStrip.PerformLayout()
        NotificaScatolaStatusStrip.ResumeLayout(False)
        NotificaScatolaStatusStrip.PerformLayout()
        CType(LibScatolaDataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NotificaScatolaLabel As Label
    Friend WithEvents ScatolaToolStrip As ToolStrip
    Friend WithEvents InizioScatolaToolStripButton As ToolStripButton
    Friend WithEvents IndietroScatolaToolStripButton As ToolStripButton
    Friend WithEvents RecordToolStripLabel As ToolStripLabel
    Friend WithEvents AvantiScatolaToolStripButton As ToolStripButton
    Friend WithEvents FineScatolaToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents NuovoScatolaToolStripButton As ToolStripButton
    Friend WithEvents SalvaScatolaToolStripButton As ToolStripButton
    Friend WithEvents EliminaScatolaToolStripButton As ToolStripButton
    Friend WithEvents ModificaScatolaToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents RicercaScatolaToolStripButton As ToolStripButton
    Friend WithEvents AnnullaRicercaScatolaToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents EsportaDBScatolaToolStripButton As ToolStripButton
    Friend WithEvents ImportaDBScatolaToolStripButton As ToolStripButton
    Friend WithEvents EliminaDBScatolaToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents EsciScatolaToolStripButton As ToolStripButton
    Friend WithEvents AiutoScatolaToolStripButton As ToolStripButton
    Friend WithEvents NotificaScatolaStatusStrip As StatusStrip
    Friend WithEvents NotificaScatolaToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents MarcaScatolaTextBox As TextBox
    Friend WithEvents CodiceScatolaTextBox As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents LarghezzaScatolaTextBox As TextBox
    Friend WithEvents AltezzaScatolaTextBox As TextBox
    Friend WithEvents ProfonditaScatolaTextBox As TextBox
    Friend WithEvents ForiPosterioriTextBox As TextBox
    Friend WithEvents SettLargSSTextBox As TextBox
    Friend WithEvents SettAltSSTextBox As TextBox
    Friend WithEvents SettLargLateraliTextBox As TextBox
    Friend WithEvents SettAltLateraliTextBox As TextBox
    Friend WithEvents NoteScatolaTextBox As TextBox
    Friend WithEvents LibScatolaDataGridView As DataGridView
    Friend WithEvents TipoPosaComboBox As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents DivisorioScatolaTextBox As TextBox
    Friend WithEvents VolumeTotaleTextBox As TextBox
    Friend WithEvents VolumeScompartoTextBox As TextBox
    Friend WithEvents AreaUtileSSTextBox As TextBox
    Friend WithEvents AreaUtileLateraleTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents StampaScatolaToolStripButton As ToolStripDropDownButton
    Friend WithEvents StampaDaSelezioneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StampaReportElementiToolStripMenuItem As ToolStripMenuItem
End Class
