<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTuboScatola
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTuboScatola))
        PanelGlobale = New Panel()
        Panel1 = New Panel()
        TableLayoutPanel_Principale = New TableLayoutPanel()
        TableLayoutPanel_Dati = New TableLayoutPanel()
        ComponentiTabControl = New TabControl()
        ScatolaTabPage = New TabPage()
        ScatolaGroupBox = New GroupBox()
        DgwScatole = New DataGridView()
        DGWTableLayoutPanel = New TableLayoutPanel()
        ComponentiScatolaDataGridView = New DataGridView()
        ColTipo = New DataGridViewTextBoxColumn()
        ColDescrizione = New DataGridViewTextBoxColumn()
        ColVolumeUnitario = New DataGridViewTextBoxColumn()
        ColQuantita = New DataGridViewTextBoxColumn()
        ColVolumeTotale = New DataGridViewTextBoxColumn()
        NotaScatolaTableLayoutPanel = New TableLayoutPanel()
        NoteScatolaTextBox = New TextBox()
        Label12 = New Label()
        CalcoliScatolaTableLayoutPanel = New TableLayoutPanel()
        SettoriSopraSottoTextBox = New TextBox()
        Label41 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        ModelloScatolaTextBox = New TextBox()
        LarghezzaScatolaTextBox = New TextBox()
        AltezzaScatolaTextBox = New TextBox()
        ProfonditaScatolaTextBox = New TextBox()
        EsitoVerificaTextBox = New TextBox()
        Label40 = New Label()
        PreforaturaPosterioreTextBox = New TextBox()
        Label42 = New Label()
        SettoreiLateraliTextBox = New TextBox()
        InputScatolaTableLayoutPanel = New TableLayoutPanel()
        Label13 = New Label()
        MarcaScatolaComboBox = New ComboBox()
        MargineSicurezzaComboBox = New ComboBox()
        Label11 = New Label()
        LocaleScatolaTextBox = New TextBox()
        Label14 = New Label()
        ScatolaToolStrip = New ToolStrip()
        InizioScatolaToolStripButton = New ToolStripButton()
        IndietroScatolaToolStripButton = New ToolStripButton()
        RecordScatolaToolStripLabel = New ToolStripLabel()
        AvantiScatolaToolStripButton = New ToolStripButton()
        FineScatolaToolStripButton = New ToolStripButton()
        ToolStripSeparator3 = New ToolStripSeparator()
        NuovoScatolaToolStripButton = New ToolStripButton()
        SalvaScatolaToolStripButton = New ToolStripButton()
        ModificaScatolaToolStripButton = New ToolStripButton()
        EliminaScatolaToolStripButton = New ToolStripButton()
        ToolStripSeparator4 = New ToolStripSeparator()
        RicercaScatolaToolStripButton = New ToolStripButton()
        AnnullaRicercaScatolaToolStripButton = New ToolStripButton()
        ToolStripSeparator5 = New ToolStripSeparator()
        AiutoTuboToolStripButton = New ToolStripButton()
        CalcolaScatolaToolStripButton = New ToolStripButton()
        ToolStripSeparator12 = New ToolStripSeparator()
        TuboTabPage = New TabPage()
        TuboGroupBox = New GroupBox()
        NoteTuboTableLayoutPanel = New TableLayoutPanel()
        Label25 = New Label()
        NoteTuboTextBox = New TextBox()
        InputTuboTableLayoutPanel = New TableLayoutPanel()
        DiametroEstComboBox = New ComboBox()
        Label21 = New Label()
        Label20 = New Label()
        Label22 = New Label()
        NomeTuboTextBox = New TextBox()
        LatoIngressoComboBox = New ComboBox()
        DiametroIntTuboTextBox = New TextBox()
        Label24 = New Label()
        Label35 = New Label()
        MarcaTuboComboBox = New ComboBox()
        Label23 = New Label()
        TipoTuboComboBox = New ComboBox()
        TuboToolStrip = New ToolStrip()
        InizioTuboToolStripButton = New ToolStripButton()
        IndietroTuboToolStripButton = New ToolStripButton()
        RecordTuboToolStripLabel = New ToolStripLabel()
        AvantiTuboToolStripButton = New ToolStripButton()
        FineTuboToolStripButton = New ToolStripButton()
        ToolStripSeparator6 = New ToolStripSeparator()
        NuovoTuboToolStripButton = New ToolStripButton()
        SalvaTuboToolStripButton = New ToolStripButton()
        EliminaTuboToolStripButton = New ToolStripButton()
        ModificaTuboToolStripButton = New ToolStripButton()
        ToolStripSeparator7 = New ToolStripSeparator()
        RicercaTuboToolStripButton = New ToolStripButton()
        AnnullaRicercaTuboToolStripButton = New ToolStripButton()
        ToolStripSeparator8 = New ToolStripSeparator()
        AiutoFiloToolStripButton = New ToolStripButton()
        FiliTabPage = New TabPage()
        FiliGroupBox = New GroupBox()
        NoteFiliTableLayoutPanel = New TableLayoutPanel()
        Label32 = New Label()
        NoteFiloTextBox = New TextBox()
        InputFiliTableLayoutPanel = New TableLayoutPanel()
        Label26 = New Label()
        Label27 = New Label()
        Label28 = New Label()
        Label29 = New Label()
        Label30 = New Label()
        SezioneFiloComboBox = New ComboBox()
        ColoreFiloComboBox = New ComboBox()
        ClassificazioneFiloTextBox = New TextBox()
        NomeFiloTextBox = New TextBox()
        Label31 = New Label()
        NoteColoreFiloLabel = New Label()
        TipoFiloTextBox = New TextBox()
        Label37 = New Label()
        LunghezzaFiloTextBox = New TextBox()
        FiloToolStrip = New ToolStrip()
        InizioFiloToolStripButton = New ToolStripButton()
        IndietroFiloToolStripButton = New ToolStripButton()
        RecordFiloToolStripLabel = New ToolStripLabel()
        AvantiFiloToolStripButton = New ToolStripButton()
        FineFiloToolStripButton = New ToolStripButton()
        ToolStripSeparator9 = New ToolStripSeparator()
        NuovoFiloToolStripButton = New ToolStripButton()
        SalvaFiloToolStripButton = New ToolStripButton()
        EliminaFiloToolStripButton = New ToolStripButton()
        ModificaFiloToolStripButton = New ToolStripButton()
        ToolStripSeparator10 = New ToolStripSeparator()
        RicercaFiloToolStripButton = New ToolStripButton()
        AnnullaRicercaFiloToolStripButton = New ToolStripButton()
        ToolStripSeparator11 = New ToolStripSeparator()
        AiutoScatolaToolStripButton = New ToolStripButton()
        MorsettiTabPage = New TabPage()
        MorsettiGroupBox = New GroupBox()
        NoteMorsettiTableLayoutPanel = New TableLayoutPanel()
        Label33 = New Label()
        NoteMorsettoTextBox = New TextBox()
        MorsettiTableLayoutPanel = New TableLayoutPanel()
        Label34 = New Label()
        MarcaMorsettoComboBox = New ComboBox()
        Label36 = New Label()
        TipoMorsettoComboBox = New ComboBox()
        Label38 = New Label()
        SuperficieOccupataTextBox = New TextBox()
        Label39 = New Label()
        QuantitaMorsettiTextBox = New TextBox()
        MorsettoToolStrip = New ToolStrip()
        InizioMorsettoToolStripButton = New ToolStripButton()
        IndietroMorsettoToolStripButton = New ToolStripButton()
        RecordMorsettoToolStripLabel = New ToolStripLabel()
        AvantiMorsettoToolStripButton = New ToolStripButton()
        FineMorsettoToolStripButton = New ToolStripButton()
        ToolStripSeparator13 = New ToolStripSeparator()
        NuovoMorsettoToolStripButton = New ToolStripButton()
        SalvaMorsettoToolStripButton = New ToolStripButton()
        EliminaMorsettoToolStripButton = New ToolStripButton()
        ModificaMorsettoToolStripButton = New ToolStripButton()
        ToolStripSeparator14 = New ToolStripSeparator()
        RicercaMorsettoToolStripButton = New ToolStripButton()
        AnnullaRicercaMorsettoToolStripButton = New ToolStripButton()
        ToolStripSeparator15 = New ToolStripSeparator()
        AiutoMorsettiToolStripButton = New ToolStripButton()
        GraficaTableLayoutPanel = New TableLayoutPanel()
        Label9 = New Label()
        Anagrafica2TableLayoutPanel = New TableLayoutPanel()
        Label5 = New Label()
        Label6 = New Label()
        NoteAnagraficaTextBox = New TextBox()
        TipoImpiantoTextBox = New TextBox()
        Anagrafica1TableLayoutPanel = New TableLayoutPanel()
        Label10 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        CodiceClienteTextBox = New TextBox()
        NominativoTextBox = New TextBox()
        CapTextBox = New TextBox()
        IndirizzoTextBox = New TextBox()
        CittaTextBox = New TextBox()
        EmailTextBox = New TextBox()
        TelefonoTextBox = New TextBox()
        AnagraficaToolStrip = New ToolStrip()
        ToolStripTextBox1 = New ToolStripTextBox()
        SalvaAnagraficaToolStripButton = New ToolStripButton()
        ModificaAnagraficaToolStripButton = New ToolStripButton()
        ToolStripSeparator1 = New ToolStripSeparator()
        StampaToolStripButton = New ToolStripButton()
        ToolStripSeparator2 = New ToolStripSeparator()
        ToolStripButton1 = New ToolStripButton()
        ToolStripTextBox5 = New ToolStripTextBox()
        EsciToolStripButton = New ToolStripButton()
        PanelGlobale.SuspendLayout()
        Panel1.SuspendLayout()
        TableLayoutPanel_Principale.SuspendLayout()
        TableLayoutPanel_Dati.SuspendLayout()
        ComponentiTabControl.SuspendLayout()
        ScatolaTabPage.SuspendLayout()
        ScatolaGroupBox.SuspendLayout()
        CType(DgwScatole, ComponentModel.ISupportInitialize).BeginInit()
        DGWTableLayoutPanel.SuspendLayout()
        CType(ComponentiScatolaDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        NotaScatolaTableLayoutPanel.SuspendLayout()
        CalcoliScatolaTableLayoutPanel.SuspendLayout()
        InputScatolaTableLayoutPanel.SuspendLayout()
        ScatolaToolStrip.SuspendLayout()
        TuboTabPage.SuspendLayout()
        TuboGroupBox.SuspendLayout()
        NoteTuboTableLayoutPanel.SuspendLayout()
        InputTuboTableLayoutPanel.SuspendLayout()
        TuboToolStrip.SuspendLayout()
        FiliTabPage.SuspendLayout()
        FiliGroupBox.SuspendLayout()
        NoteFiliTableLayoutPanel.SuspendLayout()
        InputFiliTableLayoutPanel.SuspendLayout()
        FiloToolStrip.SuspendLayout()
        MorsettiTabPage.SuspendLayout()
        MorsettiGroupBox.SuspendLayout()
        NoteMorsettiTableLayoutPanel.SuspendLayout()
        MorsettiTableLayoutPanel.SuspendLayout()
        MorsettoToolStrip.SuspendLayout()
        GraficaTableLayoutPanel.SuspendLayout()
        Anagrafica2TableLayoutPanel.SuspendLayout()
        Anagrafica1TableLayoutPanel.SuspendLayout()
        AnagraficaToolStrip.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelGlobale
        ' 
        PanelGlobale.AutoScroll = True
        PanelGlobale.Controls.Add(Panel1)
        PanelGlobale.Controls.Add(Anagrafica2TableLayoutPanel)
        PanelGlobale.Controls.Add(Anagrafica1TableLayoutPanel)
        PanelGlobale.Controls.Add(AnagraficaToolStrip)
        PanelGlobale.Dock = DockStyle.Fill
        PanelGlobale.Location = New Point(0, 0)
        PanelGlobale.Name = "PanelGlobale"
        PanelGlobale.Size = New Size(1506, 785)
        PanelGlobale.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.Controls.Add(TableLayoutPanel_Principale)
        Panel1.Location = New Point(0, 213)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1503, 567)
        Panel1.TabIndex = 17
        ' 
        ' TableLayoutPanel_Principale
        ' 
        TableLayoutPanel_Principale.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel_Principale.BackColor = SystemColors.Control
        TableLayoutPanel_Principale.ColumnCount = 2
        TableLayoutPanel_Principale.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel_Principale.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel_Principale.Controls.Add(TableLayoutPanel_Dati, 0, 0)
        TableLayoutPanel_Principale.Controls.Add(GraficaTableLayoutPanel, 1, 0)
        TableLayoutPanel_Principale.Location = New Point(0, 0)
        TableLayoutPanel_Principale.Name = "TableLayoutPanel_Principale"
        TableLayoutPanel_Principale.RowCount = 1
        TableLayoutPanel_Principale.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel_Principale.Size = New Size(1503, 560)
        TableLayoutPanel_Principale.TabIndex = 18
        ' 
        ' TableLayoutPanel_Dati
        ' 
        TableLayoutPanel_Dati.ColumnCount = 1
        TableLayoutPanel_Dati.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel_Dati.Controls.Add(ComponentiTabControl, 0, 0)
        TableLayoutPanel_Dati.Dock = DockStyle.Top
        TableLayoutPanel_Dati.Location = New Point(3, 3)
        TableLayoutPanel_Dati.Name = "TableLayoutPanel_Dati"
        TableLayoutPanel_Dati.RowCount = 1
        TableLayoutPanel_Dati.RowStyles.Add(New RowStyle(SizeType.Percent, 33.33333F))
        TableLayoutPanel_Dati.Size = New Size(735, 552)
        TableLayoutPanel_Dati.TabIndex = 0
        ' 
        ' ComponentiTabControl
        ' 
        ComponentiTabControl.Controls.Add(ScatolaTabPage)
        ComponentiTabControl.Controls.Add(TuboTabPage)
        ComponentiTabControl.Controls.Add(FiliTabPage)
        ComponentiTabControl.Controls.Add(MorsettiTabPage)
        ComponentiTabControl.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        ComponentiTabControl.Location = New Point(3, 3)
        ComponentiTabControl.Name = "ComponentiTabControl"
        ComponentiTabControl.SelectedIndex = 0
        ComponentiTabControl.Size = New Size(729, 546)
        ComponentiTabControl.TabIndex = 11
        ' 
        ' ScatolaTabPage
        ' 
        ScatolaTabPage.Controls.Add(ScatolaGroupBox)
        ScatolaTabPage.Location = New Point(4, 24)
        ScatolaTabPage.Name = "ScatolaTabPage"
        ScatolaTabPage.Padding = New Padding(3)
        ScatolaTabPage.Size = New Size(721, 518)
        ScatolaTabPage.TabIndex = 0
        ScatolaTabPage.Text = "[ Scatola ]"
        ScatolaTabPage.UseVisualStyleBackColor = True
        ' 
        ' ScatolaGroupBox
        ' 
        ScatolaGroupBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        ScatolaGroupBox.Controls.Add(DgwScatole)
        ScatolaGroupBox.Controls.Add(DGWTableLayoutPanel)
        ScatolaGroupBox.Controls.Add(NotaScatolaTableLayoutPanel)
        ScatolaGroupBox.Controls.Add(CalcoliScatolaTableLayoutPanel)
        ScatolaGroupBox.Controls.Add(InputScatolaTableLayoutPanel)
        ScatolaGroupBox.Controls.Add(ScatolaToolStrip)
        ScatolaGroupBox.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ScatolaGroupBox.Location = New Point(3, 3)
        ScatolaGroupBox.Name = "ScatolaGroupBox"
        ScatolaGroupBox.Size = New Size(712, 511)
        ScatolaGroupBox.TabIndex = 8
        ScatolaGroupBox.TabStop = False
        ' 
        ' DgwScatole
        ' 
        DgwScatole.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgwScatole.Location = New Point(6, 355)
        DgwScatole.Name = "DgwScatole"
        DgwScatole.Size = New Size(709, 150)
        DgwScatole.TabIndex = 15
        ' 
        ' DGWTableLayoutPanel
        ' 
        DGWTableLayoutPanel.ColumnCount = 1
        DGWTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        DGWTableLayoutPanel.Controls.Add(ComponentiScatolaDataGridView, 0, 0)
        DGWTableLayoutPanel.Location = New Point(3, 127)
        DGWTableLayoutPanel.Name = "DGWTableLayoutPanel"
        DGWTableLayoutPanel.RowCount = 1
        DGWTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        DGWTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        DGWTableLayoutPanel.Size = New Size(709, 64)
        DGWTableLayoutPanel.TabIndex = 14
        ' 
        ' ComponentiScatolaDataGridView
        ' 
        ComponentiScatolaDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ComponentiScatolaDataGridView.Columns.AddRange(New DataGridViewColumn() {ColTipo, ColDescrizione, ColVolumeUnitario, ColQuantita, ColVolumeTotale})
        ComponentiScatolaDataGridView.Location = New Point(3, 3)
        ComponentiScatolaDataGridView.MultiSelect = False
        ComponentiScatolaDataGridView.Name = "ComponentiScatolaDataGridView"
        ComponentiScatolaDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ComponentiScatolaDataGridView.Size = New Size(703, 58)
        ComponentiScatolaDataGridView.TabIndex = 0
        ' 
        ' ColTipo
        ' 
        ColTipo.HeaderText = "Tipo"
        ColTipo.Name = "ColTipo"
        ColTipo.ReadOnly = True
        ' 
        ' ColDescrizione
        ' 
        DataGridViewCellStyle1.NullValue = Nothing
        ColDescrizione.DefaultCellStyle = DataGridViewCellStyle1
        ColDescrizione.HeaderText = "Descrizione"
        ColDescrizione.Name = "ColDescrizione"
        ColDescrizione.ReadOnly = True
        ' 
        ' ColVolumeUnitario
        ' 
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        ColVolumeUnitario.DefaultCellStyle = DataGridViewCellStyle2
        ColVolumeUnitario.HeaderText = "Vol. Unit."
        ColVolumeUnitario.Name = "ColVolumeUnitario"
        ColVolumeUnitario.ReadOnly = True
        ' 
        ' ColQuantita
        ' 
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        ColQuantita.DefaultCellStyle = DataGridViewCellStyle3
        ColQuantita.HeaderText = "Q.tà"
        ColQuantita.Name = "ColQuantita"
        ColQuantita.ReadOnly = True
        ' 
        ' ColVolumeTotale
        ' 
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        ColVolumeTotale.DefaultCellStyle = DataGridViewCellStyle4
        ColVolumeTotale.HeaderText = "Vol. Tot.le"
        ColVolumeTotale.Name = "ColVolumeTotale"
        ColVolumeTotale.ReadOnly = True
        ' 
        ' NotaScatolaTableLayoutPanel
        ' 
        NotaScatolaTableLayoutPanel.ColumnCount = 2
        NotaScatolaTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 65F))
        NotaScatolaTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        NotaScatolaTableLayoutPanel.Controls.Add(NoteScatolaTextBox, 1, 0)
        NotaScatolaTableLayoutPanel.Controls.Add(Label12, 0, 0)
        NotaScatolaTableLayoutPanel.Dock = DockStyle.Top
        NotaScatolaTableLayoutPanel.Location = New Point(3, 75)
        NotaScatolaTableLayoutPanel.Name = "NotaScatolaTableLayoutPanel"
        NotaScatolaTableLayoutPanel.RowCount = 1
        NotaScatolaTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        NotaScatolaTableLayoutPanel.Size = New Size(706, 49)
        NotaScatolaTableLayoutPanel.TabIndex = 13
        ' 
        ' NoteScatolaTextBox
        ' 
        NoteScatolaTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        NoteScatolaTextBox.Location = New Point(68, 3)
        NoteScatolaTextBox.Multiline = True
        NoteScatolaTextBox.Name = "NoteScatolaTextBox"
        NoteScatolaTextBox.ScrollBars = ScrollBars.Vertical
        NoteScatolaTextBox.Size = New Size(635, 43)
        NoteScatolaTextBox.TabIndex = 12
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label12.AutoSize = True
        Label12.Location = New Point(3, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(59, 15)
        Label12.TabIndex = 1
        Label12.Text = "Note :"
        ' 
        ' CalcoliScatolaTableLayoutPanel
        ' 
        CalcoliScatolaTableLayoutPanel.ColumnCount = 4
        CalcoliScatolaTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 32.2314F))
        CalcoliScatolaTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 67.7686F))
        CalcoliScatolaTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 125F))
        CalcoliScatolaTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 243F))
        CalcoliScatolaTableLayoutPanel.Controls.Add(SettoriSopraSottoTextBox, 3, 3)
        CalcoliScatolaTableLayoutPanel.Controls.Add(Label41, 0, 3)
        CalcoliScatolaTableLayoutPanel.Controls.Add(Label15, 0, 0)
        CalcoliScatolaTableLayoutPanel.Controls.Add(Label16, 2, 0)
        CalcoliScatolaTableLayoutPanel.Controls.Add(Label17, 0, 1)
        CalcoliScatolaTableLayoutPanel.Controls.Add(Label18, 2, 1)
        CalcoliScatolaTableLayoutPanel.Controls.Add(Label19, 0, 2)
        CalcoliScatolaTableLayoutPanel.Controls.Add(ModelloScatolaTextBox, 1, 0)
        CalcoliScatolaTableLayoutPanel.Controls.Add(LarghezzaScatolaTextBox, 3, 0)
        CalcoliScatolaTableLayoutPanel.Controls.Add(AltezzaScatolaTextBox, 1, 1)
        CalcoliScatolaTableLayoutPanel.Controls.Add(ProfonditaScatolaTextBox, 3, 1)
        CalcoliScatolaTableLayoutPanel.Controls.Add(EsitoVerificaTextBox, 1, 2)
        CalcoliScatolaTableLayoutPanel.Controls.Add(Label40, 2, 2)
        CalcoliScatolaTableLayoutPanel.Controls.Add(PreforaturaPosterioreTextBox, 3, 2)
        CalcoliScatolaTableLayoutPanel.Controls.Add(Label42, 2, 3)
        CalcoliScatolaTableLayoutPanel.Controls.Add(SettoreiLateraliTextBox, 1, 3)
        CalcoliScatolaTableLayoutPanel.Location = New Point(3, 194)
        CalcoliScatolaTableLayoutPanel.Name = "CalcoliScatolaTableLayoutPanel"
        CalcoliScatolaTableLayoutPanel.RowCount = 4
        CalcoliScatolaTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        CalcoliScatolaTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        CalcoliScatolaTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        CalcoliScatolaTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        CalcoliScatolaTableLayoutPanel.Size = New Size(709, 122)
        CalcoliScatolaTableLayoutPanel.TabIndex = 12
        ' 
        ' SettoriSopraSottoTextBox
        ' 
        SettoriSopraSottoTextBox.Anchor = AnchorStyles.Left
        SettoriSopraSottoTextBox.Location = New Point(468, 94)
        SettoriSopraSottoTextBox.Name = "SettoriSopraSottoTextBox"
        SettoriSopraSottoTextBox.Size = New Size(130, 23)
        SettoriSopraSottoTextBox.TabIndex = 15
        ' 
        ' Label41
        ' 
        Label41.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label41.AutoSize = True
        Label41.Location = New Point(3, 98)
        Label41.Name = "Label41"
        Label41.Size = New Size(103, 15)
        Label41.TabIndex = 12
        Label41.Text = "Settori Lat.li :"
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label15.AutoSize = True
        Label15.Location = New Point(3, 7)
        Label15.Name = "Label15"
        Label15.Size = New Size(103, 15)
        Label15.TabIndex = 0
        Label15.Text = "Modello Scatola :"
        ' 
        ' Label16
        ' 
        Label16.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label16.AutoSize = True
        Label16.Location = New Point(343, 7)
        Label16.Name = "Label16"
        Label16.Size = New Size(119, 15)
        Label16.TabIndex = 1
        Label16.Text = "Larghezza Scatola :"
        ' 
        ' Label17
        ' 
        Label17.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label17.AutoSize = True
        Label17.Location = New Point(3, 37)
        Label17.Name = "Label17"
        Label17.Size = New Size(103, 15)
        Label17.TabIndex = 2
        Label17.Text = "Altezza Scatola :"
        ' 
        ' Label18
        ' 
        Label18.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label18.AutoSize = True
        Label18.Location = New Point(343, 37)
        Label18.Name = "Label18"
        Label18.Size = New Size(119, 15)
        Label18.TabIndex = 3
        Label18.Text = "Profondità Scatola :"
        ' 
        ' Label19
        ' 
        Label19.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label19.AutoSize = True
        Label19.Location = New Point(3, 67)
        Label19.Name = "Label19"
        Label19.Size = New Size(103, 15)
        Label19.TabIndex = 4
        Label19.Text = "Esito Calcolo :"
        ' 
        ' ModelloScatolaTextBox
        ' 
        ModelloScatolaTextBox.Anchor = AnchorStyles.Left
        ModelloScatolaTextBox.Location = New Point(112, 3)
        ModelloScatolaTextBox.Name = "ModelloScatolaTextBox"
        ModelloScatolaTextBox.ReadOnly = True
        ModelloScatolaTextBox.Size = New Size(130, 23)
        ModelloScatolaTextBox.TabIndex = 5
        ' 
        ' LarghezzaScatolaTextBox
        ' 
        LarghezzaScatolaTextBox.Anchor = AnchorStyles.Left
        LarghezzaScatolaTextBox.Location = New Point(468, 3)
        LarghezzaScatolaTextBox.Name = "LarghezzaScatolaTextBox"
        LarghezzaScatolaTextBox.ReadOnly = True
        LarghezzaScatolaTextBox.Size = New Size(130, 23)
        LarghezzaScatolaTextBox.TabIndex = 6
        ' 
        ' AltezzaScatolaTextBox
        ' 
        AltezzaScatolaTextBox.Anchor = AnchorStyles.Left
        AltezzaScatolaTextBox.Location = New Point(112, 33)
        AltezzaScatolaTextBox.Name = "AltezzaScatolaTextBox"
        AltezzaScatolaTextBox.ReadOnly = True
        AltezzaScatolaTextBox.Size = New Size(130, 23)
        AltezzaScatolaTextBox.TabIndex = 7
        ' 
        ' ProfonditaScatolaTextBox
        ' 
        ProfonditaScatolaTextBox.Anchor = AnchorStyles.Left
        ProfonditaScatolaTextBox.Location = New Point(468, 33)
        ProfonditaScatolaTextBox.Name = "ProfonditaScatolaTextBox"
        ProfonditaScatolaTextBox.ReadOnly = True
        ProfonditaScatolaTextBox.Size = New Size(130, 23)
        ProfonditaScatolaTextBox.TabIndex = 8
        ' 
        ' EsitoVerificaTextBox
        ' 
        EsitoVerificaTextBox.Anchor = AnchorStyles.Left
        EsitoVerificaTextBox.Location = New Point(112, 63)
        EsitoVerificaTextBox.Name = "EsitoVerificaTextBox"
        EsitoVerificaTextBox.ReadOnly = True
        EsitoVerificaTextBox.Size = New Size(130, 23)
        EsitoVerificaTextBox.TabIndex = 9
        ' 
        ' Label40
        ' 
        Label40.Anchor = AnchorStyles.Left
        Label40.AutoSize = True
        Label40.Location = New Point(343, 67)
        Label40.Name = "Label40"
        Label40.Size = New Size(108, 15)
        Label40.TabIndex = 10
        Label40.Text = "Preforatura Post. :"
        ' 
        ' PreforaturaPosterioreTextBox
        ' 
        PreforaturaPosterioreTextBox.Location = New Point(468, 63)
        PreforaturaPosterioreTextBox.Name = "PreforaturaPosterioreTextBox"
        PreforaturaPosterioreTextBox.ReadOnly = True
        PreforaturaPosterioreTextBox.Size = New Size(130, 23)
        PreforaturaPosterioreTextBox.TabIndex = 11
        ' 
        ' Label42
        ' 
        Label42.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label42.AutoSize = True
        Label42.Location = New Point(343, 98)
        Label42.Name = "Label42"
        Label42.Size = New Size(119, 15)
        Label42.TabIndex = 13
        Label42.Text = "Settori Su/Giu :"
        ' 
        ' SettoreiLateraliTextBox
        ' 
        SettoreiLateraliTextBox.Anchor = AnchorStyles.Left
        SettoreiLateraliTextBox.Location = New Point(112, 94)
        SettoreiLateraliTextBox.Name = "SettoreiLateraliTextBox"
        SettoreiLateraliTextBox.Size = New Size(130, 23)
        SettoreiLateraliTextBox.TabIndex = 14
        ' 
        ' InputScatolaTableLayoutPanel
        ' 
        InputScatolaTableLayoutPanel.ColumnCount = 6
        InputScatolaTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 65F))
        InputScatolaTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 323F))
        InputScatolaTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 66F))
        InputScatolaTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 123F))
        InputScatolaTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 73F))
        InputScatolaTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 8F))
        InputScatolaTableLayoutPanel.Controls.Add(Label13, 2, 0)
        InputScatolaTableLayoutPanel.Controls.Add(MarcaScatolaComboBox, 3, 0)
        InputScatolaTableLayoutPanel.Controls.Add(MargineSicurezzaComboBox, 5, 0)
        InputScatolaTableLayoutPanel.Controls.Add(Label11, 0, 0)
        InputScatolaTableLayoutPanel.Controls.Add(LocaleScatolaTextBox, 1, 0)
        InputScatolaTableLayoutPanel.Controls.Add(Label14, 4, 0)
        InputScatolaTableLayoutPanel.Dock = DockStyle.Top
        InputScatolaTableLayoutPanel.Location = New Point(3, 44)
        InputScatolaTableLayoutPanel.Name = "InputScatolaTableLayoutPanel"
        InputScatolaTableLayoutPanel.RowCount = 1
        InputScatolaTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        InputScatolaTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        InputScatolaTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        InputScatolaTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        InputScatolaTableLayoutPanel.Size = New Size(706, 31)
        InputScatolaTableLayoutPanel.TabIndex = 11
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label13.AutoSize = True
        Label13.Location = New Point(391, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(60, 30)
        Label13.TabIndex = 4
        Label13.Text = "Marca Scatola : "
        ' 
        ' MarcaScatolaComboBox
        ' 
        MarcaScatolaComboBox.FormattingEnabled = True
        MarcaScatolaComboBox.Location = New Point(457, 3)
        MarcaScatolaComboBox.Name = "MarcaScatolaComboBox"
        MarcaScatolaComboBox.Size = New Size(111, 23)
        MarcaScatolaComboBox.TabIndex = 10
        ' 
        ' MargineSicurezzaComboBox
        ' 
        MargineSicurezzaComboBox.FormattingEnabled = True
        MargineSicurezzaComboBox.Items.AddRange(New Object() {"30", "40", "50"})
        MargineSicurezzaComboBox.Location = New Point(653, 3)
        MargineSicurezzaComboBox.Name = "MargineSicurezzaComboBox"
        MargineSicurezzaComboBox.Size = New Size(50, 23)
        MargineSicurezzaComboBox.TabIndex = 11
        MargineSicurezzaComboBox.Text = "40"
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label11.AutoSize = True
        Label11.Location = New Point(3, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(59, 15)
        Label11.TabIndex = 0
        Label11.Text = "Locale :"
        ' 
        ' LocaleScatolaTextBox
        ' 
        LocaleScatolaTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        LocaleScatolaTextBox.Location = New Point(68, 3)
        LocaleScatolaTextBox.Name = "LocaleScatolaTextBox"
        LocaleScatolaTextBox.Size = New Size(317, 23)
        LocaleScatolaTextBox.TabIndex = 9
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label14.AutoSize = True
        Label14.Location = New Point(580, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(67, 30)
        Label14.TabIndex = 6
        Label14.Text = "Margine Scatola :"
        ' 
        ' ScatolaToolStrip
        ' 
        ScatolaToolStrip.BackColor = SystemColors.ControlDark
        ScatolaToolStrip.GripStyle = ToolStripGripStyle.Hidden
        ScatolaToolStrip.Items.AddRange(New ToolStripItem() {InizioScatolaToolStripButton, IndietroScatolaToolStripButton, RecordScatolaToolStripLabel, AvantiScatolaToolStripButton, FineScatolaToolStripButton, ToolStripSeparator3, NuovoScatolaToolStripButton, SalvaScatolaToolStripButton, ModificaScatolaToolStripButton, EliminaScatolaToolStripButton, ToolStripSeparator4, RicercaScatolaToolStripButton, AnnullaRicercaScatolaToolStripButton, ToolStripSeparator5, AiutoTuboToolStripButton, CalcolaScatolaToolStripButton, ToolStripSeparator12})
        ScatolaToolStrip.Location = New Point(3, 19)
        ScatolaToolStrip.Name = "ScatolaToolStrip"
        ScatolaToolStrip.Size = New Size(706, 25)
        ScatolaToolStrip.TabIndex = 10
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
        ' 
        ' IndietroScatolaToolStripButton
        ' 
        IndietroScatolaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        IndietroScatolaToolStripButton.Image = CType(resources.GetObject("IndietroScatolaToolStripButton.Image"), Image)
        IndietroScatolaToolStripButton.ImageTransparentColor = Color.Magenta
        IndietroScatolaToolStripButton.Name = "IndietroScatolaToolStripButton"
        IndietroScatolaToolStripButton.Size = New Size(23, 22)
        IndietroScatolaToolStripButton.Text = "ToolStripButton1"
        ' 
        ' RecordScatolaToolStripLabel
        ' 
        RecordScatolaToolStripLabel.Name = "RecordScatolaToolStripLabel"
        RecordScatolaToolStripLabel.Size = New Size(88, 22)
        RecordScatolaToolStripLabel.Text = "ToolStripLabel1"
        ' 
        ' AvantiScatolaToolStripButton
        ' 
        AvantiScatolaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AvantiScatolaToolStripButton.Image = CType(resources.GetObject("AvantiScatolaToolStripButton.Image"), Image)
        AvantiScatolaToolStripButton.ImageTransparentColor = Color.Magenta
        AvantiScatolaToolStripButton.Name = "AvantiScatolaToolStripButton"
        AvantiScatolaToolStripButton.Size = New Size(23, 22)
        AvantiScatolaToolStripButton.Text = "ToolStripButton1"
        ' 
        ' FineScatolaToolStripButton
        ' 
        FineScatolaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        FineScatolaToolStripButton.Image = CType(resources.GetObject("FineScatolaToolStripButton.Image"), Image)
        FineScatolaToolStripButton.ImageTransparentColor = Color.Magenta
        FineScatolaToolStripButton.Name = "FineScatolaToolStripButton"
        FineScatolaToolStripButton.Size = New Size(23, 22)
        FineScatolaToolStripButton.Text = "ToolStripButton1"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(6, 25)
        ' 
        ' NuovoScatolaToolStripButton
        ' 
        NuovoScatolaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        NuovoScatolaToolStripButton.Image = CType(resources.GetObject("NuovoScatolaToolStripButton.Image"), Image)
        NuovoScatolaToolStripButton.ImageTransparentColor = Color.Magenta
        NuovoScatolaToolStripButton.Name = "NuovoScatolaToolStripButton"
        NuovoScatolaToolStripButton.Size = New Size(23, 22)
        NuovoScatolaToolStripButton.Text = "ToolStripButton4"
        ' 
        ' SalvaScatolaToolStripButton
        ' 
        SalvaScatolaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        SalvaScatolaToolStripButton.Image = CType(resources.GetObject("SalvaScatolaToolStripButton.Image"), Image)
        SalvaScatolaToolStripButton.ImageTransparentColor = Color.Magenta
        SalvaScatolaToolStripButton.Name = "SalvaScatolaToolStripButton"
        SalvaScatolaToolStripButton.Size = New Size(23, 22)
        SalvaScatolaToolStripButton.Text = "ToolStripButton1"
        ' 
        ' ModificaScatolaToolStripButton
        ' 
        ModificaScatolaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ModificaScatolaToolStripButton.Image = CType(resources.GetObject("ModificaScatolaToolStripButton.Image"), Image)
        ModificaScatolaToolStripButton.ImageTransparentColor = Color.Magenta
        ModificaScatolaToolStripButton.Name = "ModificaScatolaToolStripButton"
        ModificaScatolaToolStripButton.Size = New Size(23, 22)
        ModificaScatolaToolStripButton.Text = "ToolStripButton1"
        ' 
        ' EliminaScatolaToolStripButton
        ' 
        EliminaScatolaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        EliminaScatolaToolStripButton.Image = CType(resources.GetObject("EliminaScatolaToolStripButton.Image"), Image)
        EliminaScatolaToolStripButton.ImageTransparentColor = Color.Magenta
        EliminaScatolaToolStripButton.Name = "EliminaScatolaToolStripButton"
        EliminaScatolaToolStripButton.Size = New Size(23, 22)
        EliminaScatolaToolStripButton.Text = "ToolStripButton1"
        ' 
        ' ToolStripSeparator4
        ' 
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ToolStripSeparator4.Size = New Size(6, 25)
        ' 
        ' RicercaScatolaToolStripButton
        ' 
        RicercaScatolaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        RicercaScatolaToolStripButton.Image = CType(resources.GetObject("RicercaScatolaToolStripButton.Image"), Image)
        RicercaScatolaToolStripButton.ImageTransparentColor = Color.Magenta
        RicercaScatolaToolStripButton.Name = "RicercaScatolaToolStripButton"
        RicercaScatolaToolStripButton.Size = New Size(23, 22)
        RicercaScatolaToolStripButton.Text = "ToolStripButton1"
        ' 
        ' AnnullaRicercaScatolaToolStripButton
        ' 
        AnnullaRicercaScatolaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AnnullaRicercaScatolaToolStripButton.Image = CType(resources.GetObject("AnnullaRicercaScatolaToolStripButton.Image"), Image)
        AnnullaRicercaScatolaToolStripButton.ImageTransparentColor = Color.Magenta
        AnnullaRicercaScatolaToolStripButton.Name = "AnnullaRicercaScatolaToolStripButton"
        AnnullaRicercaScatolaToolStripButton.Size = New Size(23, 22)
        AnnullaRicercaScatolaToolStripButton.Text = "ToolStripButton1"
        ' 
        ' ToolStripSeparator5
        ' 
        ToolStripSeparator5.Name = "ToolStripSeparator5"
        ToolStripSeparator5.Size = New Size(6, 25)
        ' 
        ' AiutoTuboToolStripButton
        ' 
        AiutoTuboToolStripButton.Alignment = ToolStripItemAlignment.Right
        AiutoTuboToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AiutoTuboToolStripButton.ImageTransparentColor = Color.Magenta
        AiutoTuboToolStripButton.Name = "AiutoTuboToolStripButton"
        AiutoTuboToolStripButton.Size = New Size(23, 22)
        AiutoTuboToolStripButton.Text = "ToolStripButton1"
        ' 
        ' CalcolaScatolaToolStripButton
        ' 
        CalcolaScatolaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        CalcolaScatolaToolStripButton.Image = CType(resources.GetObject("CalcolaScatolaToolStripButton.Image"), Image)
        CalcolaScatolaToolStripButton.ImageTransparentColor = Color.Magenta
        CalcolaScatolaToolStripButton.Name = "CalcolaScatolaToolStripButton"
        CalcolaScatolaToolStripButton.Size = New Size(23, 22)
        CalcolaScatolaToolStripButton.Text = "ToolStripButton2"
        ' 
        ' ToolStripSeparator12
        ' 
        ToolStripSeparator12.Name = "ToolStripSeparator12"
        ToolStripSeparator12.Size = New Size(6, 25)
        ' 
        ' TuboTabPage
        ' 
        TuboTabPage.Controls.Add(TuboGroupBox)
        TuboTabPage.Location = New Point(4, 24)
        TuboTabPage.Name = "TuboTabPage"
        TuboTabPage.Padding = New Padding(3)
        TuboTabPage.Size = New Size(721, 518)
        TuboTabPage.TabIndex = 1
        TuboTabPage.Text = "[ Tubo ]"
        TuboTabPage.UseVisualStyleBackColor = True
        ' 
        ' TuboGroupBox
        ' 
        TuboGroupBox.Controls.Add(NoteTuboTableLayoutPanel)
        TuboGroupBox.Controls.Add(InputTuboTableLayoutPanel)
        TuboGroupBox.Controls.Add(TuboToolStrip)
        TuboGroupBox.Dock = DockStyle.Fill
        TuboGroupBox.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TuboGroupBox.Location = New Point(3, 3)
        TuboGroupBox.Name = "TuboGroupBox"
        TuboGroupBox.Size = New Size(715, 512)
        TuboGroupBox.TabIndex = 10
        TuboGroupBox.TabStop = False
        ' 
        ' NoteTuboTableLayoutPanel
        ' 
        NoteTuboTableLayoutPanel.ColumnCount = 2
        NoteTuboTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 117F))
        NoteTuboTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        NoteTuboTableLayoutPanel.Controls.Add(Label25, 0, 0)
        NoteTuboTableLayoutPanel.Controls.Add(NoteTuboTextBox, 1, 0)
        NoteTuboTableLayoutPanel.Dock = DockStyle.Top
        NoteTuboTableLayoutPanel.Location = New Point(3, 176)
        NoteTuboTableLayoutPanel.Name = "NoteTuboTableLayoutPanel"
        NoteTuboTableLayoutPanel.RowCount = 1
        NoteTuboTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        NoteTuboTableLayoutPanel.Size = New Size(709, 100)
        NoteTuboTableLayoutPanel.TabIndex = 13
        ' 
        ' Label25
        ' 
        Label25.Anchor = AnchorStyles.Left
        Label25.AutoSize = True
        Label25.Location = New Point(3, 42)
        Label25.Name = "Label25"
        Label25.Size = New Size(41, 15)
        Label25.TabIndex = 0
        Label25.Text = "Note :"
        ' 
        ' NoteTuboTextBox
        ' 
        NoteTuboTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        NoteTuboTextBox.Location = New Point(120, 3)
        NoteTuboTextBox.Multiline = True
        NoteTuboTextBox.Name = "NoteTuboTextBox"
        NoteTuboTextBox.ScrollBars = ScrollBars.Vertical
        NoteTuboTextBox.Size = New Size(586, 94)
        NoteTuboTextBox.TabIndex = 19
        ' 
        ' InputTuboTableLayoutPanel
        ' 
        InputTuboTableLayoutPanel.ColumnCount = 4
        InputTuboTableLayoutPanel.ColumnStyles.Add(New ColumnStyle())
        InputTuboTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 63.6546173F))
        InputTuboTableLayoutPanel.ColumnStyles.Add(New ColumnStyle())
        InputTuboTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 36.3453827F))
        InputTuboTableLayoutPanel.Controls.Add(DiametroEstComboBox, 3, 1)
        InputTuboTableLayoutPanel.Controls.Add(Label21, 2, 1)
        InputTuboTableLayoutPanel.Controls.Add(Label20, 0, 0)
        InputTuboTableLayoutPanel.Controls.Add(Label22, 0, 2)
        InputTuboTableLayoutPanel.Controls.Add(NomeTuboTextBox, 1, 0)
        InputTuboTableLayoutPanel.Controls.Add(LatoIngressoComboBox, 1, 2)
        InputTuboTableLayoutPanel.Controls.Add(DiametroIntTuboTextBox, 3, 2)
        InputTuboTableLayoutPanel.Controls.Add(Label24, 2, 2)
        InputTuboTableLayoutPanel.Controls.Add(Label35, 2, 0)
        InputTuboTableLayoutPanel.Controls.Add(MarcaTuboComboBox, 3, 0)
        InputTuboTableLayoutPanel.Controls.Add(Label23, 0, 1)
        InputTuboTableLayoutPanel.Controls.Add(TipoTuboComboBox, 1, 1)
        InputTuboTableLayoutPanel.Dock = DockStyle.Top
        InputTuboTableLayoutPanel.Location = New Point(3, 44)
        InputTuboTableLayoutPanel.Name = "InputTuboTableLayoutPanel"
        InputTuboTableLayoutPanel.RowCount = 3
        InputTuboTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        InputTuboTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        InputTuboTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 42F))
        InputTuboTableLayoutPanel.Size = New Size(709, 132)
        InputTuboTableLayoutPanel.TabIndex = 12
        ' 
        ' DiametroEstComboBox
        ' 
        DiametroEstComboBox.Anchor = AnchorStyles.Left
        DiametroEstComboBox.FormattingEnabled = True
        DiametroEstComboBox.Location = New Point(530, 56)
        DiametroEstComboBox.Name = "DiametroEstComboBox"
        DiametroEstComboBox.Size = New Size(121, 23)
        DiametroEstComboBox.TabIndex = 16
        ' 
        ' Label21
        ' 
        Label21.Anchor = AnchorStyles.Left
        Label21.AutoSize = True
        Label21.Location = New Point(413, 60)
        Label21.Name = "Label21"
        Label21.Size = New Size(111, 15)
        Label21.TabIndex = 14
        Label21.Text = "Diametro Esterno :"
        ' 
        ' Label20
        ' 
        Label20.Anchor = AnchorStyles.Left
        Label20.AutoSize = True
        Label20.Location = New Point(3, 15)
        Label20.Name = "Label20"
        Label20.Size = New Size(77, 15)
        Label20.TabIndex = 0
        Label20.Text = "Nome Tubo :"
        ' 
        ' Label22
        ' 
        Label22.Anchor = AnchorStyles.Left
        Label22.AutoSize = True
        Label22.Location = New Point(3, 103)
        Label22.Name = "Label22"
        Label22.Size = New Size(87, 15)
        Label22.TabIndex = 2
        Label22.Text = "Lato Ingresso :"
        ' 
        ' NomeTuboTextBox
        ' 
        NomeTuboTextBox.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        NomeTuboTextBox.Location = New Point(96, 11)
        NomeTuboTextBox.Name = "NomeTuboTextBox"
        NomeTuboTextBox.Size = New Size(311, 23)
        NomeTuboTextBox.TabIndex = 13
        ' 
        ' LatoIngressoComboBox
        ' 
        LatoIngressoComboBox.Anchor = AnchorStyles.Left
        LatoIngressoComboBox.FormattingEnabled = True
        LatoIngressoComboBox.Items.AddRange(New Object() {"Alto", "Basso", "Sinistra", "Destro", "Posteriore"})
        LatoIngressoComboBox.Location = New Point(96, 99)
        LatoIngressoComboBox.Name = "LatoIngressoComboBox"
        LatoIngressoComboBox.Size = New Size(121, 23)
        LatoIngressoComboBox.TabIndex = 17
        LatoIngressoComboBox.Text = "Basso"
        ' 
        ' DiametroIntTuboTextBox
        ' 
        DiametroIntTuboTextBox.Anchor = AnchorStyles.Left
        DiametroIntTuboTextBox.Location = New Point(530, 99)
        DiametroIntTuboTextBox.Name = "DiametroIntTuboTextBox"
        DiametroIntTuboTextBox.ReadOnly = True
        DiametroIntTuboTextBox.Size = New Size(100, 23)
        DiametroIntTuboTextBox.TabIndex = 18
        ' 
        ' Label24
        ' 
        Label24.Anchor = AnchorStyles.Left
        Label24.AutoSize = True
        Label24.Location = New Point(413, 103)
        Label24.Name = "Label24"
        Label24.Size = New Size(111, 15)
        Label24.TabIndex = 4
        Label24.Text = "Diametro Interno :"
        ' 
        ' Label35
        ' 
        Label35.Anchor = AnchorStyles.Left
        Label35.AutoSize = True
        Label35.Location = New Point(413, 15)
        Label35.Name = "Label35"
        Label35.Size = New Size(47, 15)
        Label35.TabIndex = 12
        Label35.Text = "Marca :"
        ' 
        ' MarcaTuboComboBox
        ' 
        MarcaTuboComboBox.Anchor = AnchorStyles.Left
        MarcaTuboComboBox.FormattingEnabled = True
        MarcaTuboComboBox.Location = New Point(530, 11)
        MarcaTuboComboBox.Name = "MarcaTuboComboBox"
        MarcaTuboComboBox.Size = New Size(167, 23)
        MarcaTuboComboBox.TabIndex = 14
        ' 
        ' Label23
        ' 
        Label23.Anchor = AnchorStyles.Left
        Label23.AutoSize = True
        Label23.Location = New Point(3, 60)
        Label23.Name = "Label23"
        Label23.Size = New Size(67, 15)
        Label23.TabIndex = 3
        Label23.Text = "Tipo Tubo :"
        ' 
        ' TipoTuboComboBox
        ' 
        TipoTuboComboBox.Anchor = AnchorStyles.Left
        TipoTuboComboBox.FormattingEnabled = True
        TipoTuboComboBox.Location = New Point(96, 56)
        TipoTuboComboBox.Name = "TipoTuboComboBox"
        TipoTuboComboBox.Size = New Size(167, 23)
        TipoTuboComboBox.TabIndex = 15
        ' 
        ' TuboToolStrip
        ' 
        TuboToolStrip.BackColor = SystemColors.ControlDark
        TuboToolStrip.GripStyle = ToolStripGripStyle.Hidden
        TuboToolStrip.Items.AddRange(New ToolStripItem() {InizioTuboToolStripButton, IndietroTuboToolStripButton, RecordTuboToolStripLabel, AvantiTuboToolStripButton, FineTuboToolStripButton, ToolStripSeparator6, NuovoTuboToolStripButton, SalvaTuboToolStripButton, EliminaTuboToolStripButton, ModificaTuboToolStripButton, ToolStripSeparator7, RicercaTuboToolStripButton, AnnullaRicercaTuboToolStripButton, ToolStripSeparator8, AiutoFiloToolStripButton})
        TuboToolStrip.Location = New Point(3, 19)
        TuboToolStrip.Name = "TuboToolStrip"
        TuboToolStrip.Size = New Size(709, 25)
        TuboToolStrip.TabIndex = 11
        TuboToolStrip.Text = "ToolStrip1"
        ' 
        ' InizioTuboToolStripButton
        ' 
        InizioTuboToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        InizioTuboToolStripButton.Name = "InizioTuboToolStripButton"
        InizioTuboToolStripButton.Size = New Size(23, 22)
        InizioTuboToolStripButton.Text = "ToolStripButton1"
        ' 
        ' IndietroTuboToolStripButton
        ' 
        IndietroTuboToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        IndietroTuboToolStripButton.ImageTransparentColor = Color.Magenta
        IndietroTuboToolStripButton.Name = "IndietroTuboToolStripButton"
        IndietroTuboToolStripButton.Size = New Size(23, 22)
        IndietroTuboToolStripButton.Text = "ToolStripButton1"
        ' 
        ' RecordTuboToolStripLabel
        ' 
        RecordTuboToolStripLabel.Name = "RecordTuboToolStripLabel"
        RecordTuboToolStripLabel.Size = New Size(88, 22)
        RecordTuboToolStripLabel.Text = "ToolStripLabel1"
        ' 
        ' AvantiTuboToolStripButton
        ' 
        AvantiTuboToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AvantiTuboToolStripButton.ImageTransparentColor = Color.Magenta
        AvantiTuboToolStripButton.Name = "AvantiTuboToolStripButton"
        AvantiTuboToolStripButton.Size = New Size(23, 22)
        AvantiTuboToolStripButton.Text = "ToolStripButton1"
        ' 
        ' FineTuboToolStripButton
        ' 
        FineTuboToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        FineTuboToolStripButton.ImageTransparentColor = Color.Magenta
        FineTuboToolStripButton.Name = "FineTuboToolStripButton"
        FineTuboToolStripButton.Size = New Size(23, 22)
        FineTuboToolStripButton.Text = "ToolStripButton1"
        ' 
        ' ToolStripSeparator6
        ' 
        ToolStripSeparator6.Name = "ToolStripSeparator6"
        ToolStripSeparator6.Size = New Size(6, 25)
        ' 
        ' NuovoTuboToolStripButton
        ' 
        NuovoTuboToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        NuovoTuboToolStripButton.ImageTransparentColor = Color.Magenta
        NuovoTuboToolStripButton.Name = "NuovoTuboToolStripButton"
        NuovoTuboToolStripButton.Size = New Size(23, 22)
        NuovoTuboToolStripButton.Text = "ToolStripButton4"
        ' 
        ' SalvaTuboToolStripButton
        ' 
        SalvaTuboToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        SalvaTuboToolStripButton.ImageTransparentColor = Color.Magenta
        SalvaTuboToolStripButton.Name = "SalvaTuboToolStripButton"
        SalvaTuboToolStripButton.Size = New Size(23, 22)
        SalvaTuboToolStripButton.Text = "ToolStripButton1"
        ' 
        ' EliminaTuboToolStripButton
        ' 
        EliminaTuboToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        EliminaTuboToolStripButton.ImageTransparentColor = Color.Magenta
        EliminaTuboToolStripButton.Name = "EliminaTuboToolStripButton"
        EliminaTuboToolStripButton.Size = New Size(23, 22)
        EliminaTuboToolStripButton.Text = "ToolStripButton1"
        ' 
        ' ModificaTuboToolStripButton
        ' 
        ModificaTuboToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ModificaTuboToolStripButton.ImageTransparentColor = Color.Magenta
        ModificaTuboToolStripButton.Name = "ModificaTuboToolStripButton"
        ModificaTuboToolStripButton.Size = New Size(23, 22)
        ModificaTuboToolStripButton.Text = "ToolStripButton1"
        ' 
        ' ToolStripSeparator7
        ' 
        ToolStripSeparator7.Name = "ToolStripSeparator7"
        ToolStripSeparator7.Size = New Size(6, 25)
        ' 
        ' RicercaTuboToolStripButton
        ' 
        RicercaTuboToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        RicercaTuboToolStripButton.ImageTransparentColor = Color.Magenta
        RicercaTuboToolStripButton.Name = "RicercaTuboToolStripButton"
        RicercaTuboToolStripButton.Size = New Size(23, 22)
        RicercaTuboToolStripButton.Text = "ToolStripButton1"
        ' 
        ' AnnullaRicercaTuboToolStripButton
        ' 
        AnnullaRicercaTuboToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AnnullaRicercaTuboToolStripButton.ImageTransparentColor = Color.Magenta
        AnnullaRicercaTuboToolStripButton.Name = "AnnullaRicercaTuboToolStripButton"
        AnnullaRicercaTuboToolStripButton.Size = New Size(23, 22)
        AnnullaRicercaTuboToolStripButton.Text = "ToolStripButton1"
        ' 
        ' ToolStripSeparator8
        ' 
        ToolStripSeparator8.Name = "ToolStripSeparator8"
        ToolStripSeparator8.Size = New Size(6, 25)
        ' 
        ' AiutoFiloToolStripButton
        ' 
        AiutoFiloToolStripButton.Alignment = ToolStripItemAlignment.Right
        AiutoFiloToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AiutoFiloToolStripButton.ImageTransparentColor = Color.Magenta
        AiutoFiloToolStripButton.Name = "AiutoFiloToolStripButton"
        AiutoFiloToolStripButton.Size = New Size(23, 22)
        AiutoFiloToolStripButton.Text = "ToolStripButton1"
        ' 
        ' FiliTabPage
        ' 
        FiliTabPage.Controls.Add(FiliGroupBox)
        FiliTabPage.Location = New Point(4, 24)
        FiliTabPage.Name = "FiliTabPage"
        FiliTabPage.Padding = New Padding(3)
        FiliTabPage.Size = New Size(721, 518)
        FiliTabPage.TabIndex = 2
        FiliTabPage.Text = "[ Fili ]"
        FiliTabPage.UseVisualStyleBackColor = True
        ' 
        ' FiliGroupBox
        ' 
        FiliGroupBox.Controls.Add(NoteFiliTableLayoutPanel)
        FiliGroupBox.Controls.Add(InputFiliTableLayoutPanel)
        FiliGroupBox.Controls.Add(FiloToolStrip)
        FiliGroupBox.Dock = DockStyle.Fill
        FiliGroupBox.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FiliGroupBox.Location = New Point(3, 3)
        FiliGroupBox.Name = "FiliGroupBox"
        FiliGroupBox.Size = New Size(715, 512)
        FiliGroupBox.TabIndex = 12
        FiliGroupBox.TabStop = False
        ' 
        ' NoteFiliTableLayoutPanel
        ' 
        NoteFiliTableLayoutPanel.ColumnCount = 2
        NoteFiliTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 110F))
        NoteFiliTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        NoteFiliTableLayoutPanel.Controls.Add(Label32, 0, 0)
        NoteFiliTableLayoutPanel.Controls.Add(NoteFiloTextBox, 1, 0)
        NoteFiliTableLayoutPanel.Dock = DockStyle.Top
        NoteFiliTableLayoutPanel.Location = New Point(3, 171)
        NoteFiliTableLayoutPanel.Name = "NoteFiliTableLayoutPanel"
        NoteFiliTableLayoutPanel.RowCount = 1
        NoteFiliTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        NoteFiliTableLayoutPanel.Size = New Size(709, 112)
        NoteFiliTableLayoutPanel.TabIndex = 14
        ' 
        ' Label32
        ' 
        Label32.Anchor = AnchorStyles.Left
        Label32.AutoSize = True
        Label32.Location = New Point(3, 48)
        Label32.Name = "Label32"
        Label32.Size = New Size(41, 15)
        Label32.TabIndex = 0
        Label32.Text = "Note :"
        ' 
        ' NoteFiloTextBox
        ' 
        NoteFiloTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        NoteFiloTextBox.Location = New Point(113, 3)
        NoteFiloTextBox.Multiline = True
        NoteFiloTextBox.Name = "NoteFiloTextBox"
        NoteFiloTextBox.ScrollBars = ScrollBars.Vertical
        NoteFiloTextBox.Size = New Size(593, 106)
        NoteFiloTextBox.TabIndex = 27
        ' 
        ' InputFiliTableLayoutPanel
        ' 
        InputFiliTableLayoutPanel.ColumnCount = 4
        InputFiliTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15.0273228F))
        InputFiliTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.2732239F))
        InputFiliTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.803278F))
        InputFiliTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 17.8961754F))
        InputFiliTableLayoutPanel.Controls.Add(Label26, 0, 0)
        InputFiliTableLayoutPanel.Controls.Add(Label27, 2, 0)
        InputFiliTableLayoutPanel.Controls.Add(Label28, 0, 1)
        InputFiliTableLayoutPanel.Controls.Add(Label29, 2, 1)
        InputFiliTableLayoutPanel.Controls.Add(Label30, 2, 2)
        InputFiliTableLayoutPanel.Controls.Add(SezioneFiloComboBox, 3, 2)
        InputFiliTableLayoutPanel.Controls.Add(ColoreFiloComboBox, 3, 1)
        InputFiliTableLayoutPanel.Controls.Add(ClassificazioneFiloTextBox, 3, 0)
        InputFiliTableLayoutPanel.Controls.Add(NomeFiloTextBox, 1, 0)
        InputFiliTableLayoutPanel.Controls.Add(Label31, 0, 2)
        InputFiliTableLayoutPanel.Controls.Add(NoteColoreFiloLabel, 1, 2)
        InputFiliTableLayoutPanel.Controls.Add(TipoFiloTextBox, 1, 1)
        InputFiliTableLayoutPanel.Controls.Add(Label37, 0, 3)
        InputFiliTableLayoutPanel.Controls.Add(LunghezzaFiloTextBox, 1, 3)
        InputFiliTableLayoutPanel.Dock = DockStyle.Top
        InputFiliTableLayoutPanel.Location = New Point(3, 44)
        InputFiliTableLayoutPanel.Name = "InputFiliTableLayoutPanel"
        InputFiliTableLayoutPanel.RowCount = 4
        InputFiliTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        InputFiliTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        InputFiliTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        InputFiliTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        InputFiliTableLayoutPanel.Size = New Size(709, 127)
        InputFiliTableLayoutPanel.TabIndex = 13
        ' 
        ' Label26
        ' 
        Label26.Anchor = AnchorStyles.Left
        Label26.AutoSize = True
        Label26.Location = New Point(3, 8)
        Label26.Name = "Label26"
        Label26.Size = New Size(69, 15)
        Label26.TabIndex = 0
        Label26.Text = "Nome Filo :"
        ' 
        ' Label27
        ' 
        Label27.Anchor = AnchorStyles.Left
        Label27.AutoSize = True
        Label27.Location = New Point(465, 0)
        Label27.Name = "Label27"
        Label27.Size = New Size(111, 30)
        Label27.TabIndex = 1
        Label27.Text = "Classificazione Filo :"
        ' 
        ' Label28
        ' 
        Label28.Anchor = AnchorStyles.Left
        Label28.AutoSize = True
        Label28.Location = New Point(3, 39)
        Label28.Name = "Label28"
        Label28.Size = New Size(59, 15)
        Label28.TabIndex = 2
        Label28.Text = "Tipo Filo :"
        ' 
        ' Label29
        ' 
        Label29.Anchor = AnchorStyles.Left
        Label29.AutoSize = True
        Label29.Location = New Point(465, 39)
        Label29.Name = "Label29"
        Label29.Size = New Size(71, 15)
        Label29.TabIndex = 3
        Label29.Text = "Colore Filo :"
        ' 
        ' Label30
        ' 
        Label30.Anchor = AnchorStyles.Left
        Label30.AutoSize = True
        Label30.Location = New Point(465, 70)
        Label30.Name = "Label30"
        Label30.Size = New Size(79, 15)
        Label30.TabIndex = 4
        Label30.Text = "Sezione Filo :"
        ' 
        ' SezioneFiloComboBox
        ' 
        SezioneFiloComboBox.FormattingEnabled = True
        SezioneFiloComboBox.Location = New Point(584, 65)
        SezioneFiloComboBox.Name = "SezioneFiloComboBox"
        SezioneFiloComboBox.Size = New Size(121, 23)
        SezioneFiloComboBox.TabIndex = 24
        ' 
        ' ColoreFiloComboBox
        ' 
        ColoreFiloComboBox.FormattingEnabled = True
        ColoreFiloComboBox.Location = New Point(584, 34)
        ColoreFiloComboBox.Name = "ColoreFiloComboBox"
        ColoreFiloComboBox.Size = New Size(121, 23)
        ColoreFiloComboBox.TabIndex = 23
        ' 
        ' ClassificazioneFiloTextBox
        ' 
        ClassificazioneFiloTextBox.Anchor = AnchorStyles.Left
        ClassificazioneFiloTextBox.Location = New Point(584, 4)
        ClassificazioneFiloTextBox.Name = "ClassificazioneFiloTextBox"
        ClassificazioneFiloTextBox.Size = New Size(121, 23)
        ClassificazioneFiloTextBox.TabIndex = 21
        ' 
        ' NomeFiloTextBox
        ' 
        NomeFiloTextBox.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        NomeFiloTextBox.Location = New Point(109, 4)
        NomeFiloTextBox.Name = "NomeFiloTextBox"
        NomeFiloTextBox.Size = New Size(350, 23)
        NomeFiloTextBox.TabIndex = 20
        ' 
        ' Label31
        ' 
        Label31.Anchor = AnchorStyles.Left
        Label31.AutoSize = True
        Label31.Location = New Point(3, 70)
        Label31.Name = "Label31"
        Label31.Size = New Size(73, 15)
        Label31.TabIndex = 9
        Label31.Text = "Note Colre :"
        ' 
        ' NoteColoreFiloLabel
        ' 
        NoteColoreFiloLabel.Anchor = AnchorStyles.Left
        NoteColoreFiloLabel.BorderStyle = BorderStyle.Fixed3D
        NoteColoreFiloLabel.Location = New Point(109, 66)
        NoteColoreFiloLabel.Name = "NoteColoreFiloLabel"
        NoteColoreFiloLabel.Size = New Size(349, 22)
        NoteColoreFiloLabel.TabIndex = 28
        ' 
        ' TipoFiloTextBox
        ' 
        TipoFiloTextBox.Location = New Point(109, 34)
        TipoFiloTextBox.Name = "TipoFiloTextBox"
        TipoFiloTextBox.Size = New Size(199, 23)
        TipoFiloTextBox.TabIndex = 22
        ' 
        ' Label37
        ' 
        Label37.Anchor = AnchorStyles.Left
        Label37.AutoSize = True
        Label37.Location = New Point(3, 102)
        Label37.Name = "Label37"
        Label37.Size = New Size(94, 15)
        Label37.TabIndex = 30
        Label37.Text = "Lunghezza Filo :"
        ' 
        ' LunghezzaFiloTextBox
        ' 
        LunghezzaFiloTextBox.Anchor = AnchorStyles.Left
        LunghezzaFiloTextBox.Location = New Point(109, 98)
        LunghezzaFiloTextBox.Name = "LunghezzaFiloTextBox"
        LunghezzaFiloTextBox.Size = New Size(121, 23)
        LunghezzaFiloTextBox.TabIndex = 31
        ' 
        ' FiloToolStrip
        ' 
        FiloToolStrip.BackColor = SystemColors.ControlDark
        FiloToolStrip.GripStyle = ToolStripGripStyle.Hidden
        FiloToolStrip.Items.AddRange(New ToolStripItem() {InizioFiloToolStripButton, IndietroFiloToolStripButton, RecordFiloToolStripLabel, AvantiFiloToolStripButton, FineFiloToolStripButton, ToolStripSeparator9, NuovoFiloToolStripButton, SalvaFiloToolStripButton, EliminaFiloToolStripButton, ModificaFiloToolStripButton, ToolStripSeparator10, RicercaFiloToolStripButton, AnnullaRicercaFiloToolStripButton, ToolStripSeparator11, AiutoScatolaToolStripButton})
        FiloToolStrip.Location = New Point(3, 19)
        FiloToolStrip.Name = "FiloToolStrip"
        FiloToolStrip.Size = New Size(709, 25)
        FiloToolStrip.TabIndex = 12
        FiloToolStrip.Text = "ToolStrip1"
        ' 
        ' InizioFiloToolStripButton
        ' 
        InizioFiloToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        InizioFiloToolStripButton.ImageTransparentColor = Color.Magenta
        InizioFiloToolStripButton.Name = "InizioFiloToolStripButton"
        InizioFiloToolStripButton.Size = New Size(23, 22)
        InizioFiloToolStripButton.Text = "ToolStripButton1"
        ' 
        ' IndietroFiloToolStripButton
        ' 
        IndietroFiloToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        IndietroFiloToolStripButton.ImageTransparentColor = Color.Magenta
        IndietroFiloToolStripButton.Name = "IndietroFiloToolStripButton"
        IndietroFiloToolStripButton.Size = New Size(23, 22)
        IndietroFiloToolStripButton.Text = "ToolStripButton1"
        ' 
        ' RecordFiloToolStripLabel
        ' 
        RecordFiloToolStripLabel.Name = "RecordFiloToolStripLabel"
        RecordFiloToolStripLabel.Size = New Size(88, 22)
        RecordFiloToolStripLabel.Text = "ToolStripLabel1"
        ' 
        ' AvantiFiloToolStripButton
        ' 
        AvantiFiloToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AvantiFiloToolStripButton.ImageTransparentColor = Color.Magenta
        AvantiFiloToolStripButton.Name = "AvantiFiloToolStripButton"
        AvantiFiloToolStripButton.Size = New Size(23, 22)
        AvantiFiloToolStripButton.Text = "ToolStripButton1"
        ' 
        ' FineFiloToolStripButton
        ' 
        FineFiloToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        FineFiloToolStripButton.ImageTransparentColor = Color.Magenta
        FineFiloToolStripButton.Name = "FineFiloToolStripButton"
        FineFiloToolStripButton.Size = New Size(23, 22)
        FineFiloToolStripButton.Text = "ToolStripButton1"
        ' 
        ' ToolStripSeparator9
        ' 
        ToolStripSeparator9.Name = "ToolStripSeparator9"
        ToolStripSeparator9.Size = New Size(6, 25)
        ' 
        ' NuovoFiloToolStripButton
        ' 
        NuovoFiloToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        NuovoFiloToolStripButton.ImageTransparentColor = Color.Magenta
        NuovoFiloToolStripButton.Name = "NuovoFiloToolStripButton"
        NuovoFiloToolStripButton.Size = New Size(23, 22)
        NuovoFiloToolStripButton.Text = "ToolStripButton4"
        ' 
        ' SalvaFiloToolStripButton
        ' 
        SalvaFiloToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        SalvaFiloToolStripButton.ImageTransparentColor = Color.Magenta
        SalvaFiloToolStripButton.Name = "SalvaFiloToolStripButton"
        SalvaFiloToolStripButton.Size = New Size(23, 22)
        SalvaFiloToolStripButton.Text = "ToolStripButton1"
        ' 
        ' EliminaFiloToolStripButton
        ' 
        EliminaFiloToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        EliminaFiloToolStripButton.ImageTransparentColor = Color.Magenta
        EliminaFiloToolStripButton.Name = "EliminaFiloToolStripButton"
        EliminaFiloToolStripButton.Size = New Size(23, 22)
        EliminaFiloToolStripButton.Text = "ToolStripButton1"
        ' 
        ' ModificaFiloToolStripButton
        ' 
        ModificaFiloToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ModificaFiloToolStripButton.ImageTransparentColor = Color.Magenta
        ModificaFiloToolStripButton.Name = "ModificaFiloToolStripButton"
        ModificaFiloToolStripButton.Size = New Size(23, 22)
        ModificaFiloToolStripButton.Text = "ToolStripButton1"
        ' 
        ' ToolStripSeparator10
        ' 
        ToolStripSeparator10.Name = "ToolStripSeparator10"
        ToolStripSeparator10.Size = New Size(6, 25)
        ' 
        ' RicercaFiloToolStripButton
        ' 
        RicercaFiloToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        RicercaFiloToolStripButton.ImageTransparentColor = Color.Magenta
        RicercaFiloToolStripButton.Name = "RicercaFiloToolStripButton"
        RicercaFiloToolStripButton.Size = New Size(23, 22)
        RicercaFiloToolStripButton.Text = "ToolStripButton1"
        ' 
        ' AnnullaRicercaFiloToolStripButton
        ' 
        AnnullaRicercaFiloToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AnnullaRicercaFiloToolStripButton.ImageTransparentColor = Color.Magenta
        AnnullaRicercaFiloToolStripButton.Name = "AnnullaRicercaFiloToolStripButton"
        AnnullaRicercaFiloToolStripButton.Size = New Size(23, 22)
        AnnullaRicercaFiloToolStripButton.Text = "ToolStripButton1"
        ' 
        ' ToolStripSeparator11
        ' 
        ToolStripSeparator11.Name = "ToolStripSeparator11"
        ToolStripSeparator11.Size = New Size(6, 25)
        ' 
        ' AiutoScatolaToolStripButton
        ' 
        AiutoScatolaToolStripButton.Alignment = ToolStripItemAlignment.Right
        AiutoScatolaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AiutoScatolaToolStripButton.ImageTransparentColor = Color.Magenta
        AiutoScatolaToolStripButton.Name = "AiutoScatolaToolStripButton"
        AiutoScatolaToolStripButton.Size = New Size(23, 22)
        AiutoScatolaToolStripButton.Text = "ToolStripButton1"
        ' 
        ' MorsettiTabPage
        ' 
        MorsettiTabPage.Controls.Add(MorsettiGroupBox)
        MorsettiTabPage.Location = New Point(4, 24)
        MorsettiTabPage.Name = "MorsettiTabPage"
        MorsettiTabPage.Padding = New Padding(3)
        MorsettiTabPage.Size = New Size(721, 518)
        MorsettiTabPage.TabIndex = 3
        MorsettiTabPage.Text = "[ Morsetti ]"
        MorsettiTabPage.UseVisualStyleBackColor = True
        ' 
        ' MorsettiGroupBox
        ' 
        MorsettiGroupBox.Controls.Add(NoteMorsettiTableLayoutPanel)
        MorsettiGroupBox.Controls.Add(MorsettiTableLayoutPanel)
        MorsettiGroupBox.Controls.Add(MorsettoToolStrip)
        MorsettiGroupBox.Dock = DockStyle.Top
        MorsettiGroupBox.Location = New Point(3, 3)
        MorsettiGroupBox.Name = "MorsettiGroupBox"
        MorsettiGroupBox.Size = New Size(715, 288)
        MorsettiGroupBox.TabIndex = 7
        MorsettiGroupBox.TabStop = False
        ' 
        ' NoteMorsettiTableLayoutPanel
        ' 
        NoteMorsettiTableLayoutPanel.ColumnCount = 2
        NoteMorsettiTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        NoteMorsettiTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 608F))
        NoteMorsettiTableLayoutPanel.Controls.Add(Label33, 0, 0)
        NoteMorsettiTableLayoutPanel.Controls.Add(NoteMorsettoTextBox, 1, 0)
        NoteMorsettiTableLayoutPanel.Dock = DockStyle.Top
        NoteMorsettiTableLayoutPanel.Location = New Point(3, 131)
        NoteMorsettiTableLayoutPanel.Name = "NoteMorsettiTableLayoutPanel"
        NoteMorsettiTableLayoutPanel.RowCount = 1
        NoteMorsettiTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        NoteMorsettiTableLayoutPanel.Size = New Size(709, 157)
        NoteMorsettiTableLayoutPanel.TabIndex = 2
        ' 
        ' Label33
        ' 
        Label33.Anchor = AnchorStyles.Left
        Label33.AutoSize = True
        Label33.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label33.Location = New Point(3, 71)
        Label33.Name = "Label33"
        Label33.Size = New Size(41, 15)
        Label33.TabIndex = 0
        Label33.Text = "Note :"
        ' 
        ' NoteMorsettoTextBox
        ' 
        NoteMorsettoTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        NoteMorsettoTextBox.Location = New Point(104, 3)
        NoteMorsettoTextBox.Multiline = True
        NoteMorsettoTextBox.Name = "NoteMorsettoTextBox"
        NoteMorsettoTextBox.ScrollBars = ScrollBars.Vertical
        NoteMorsettoTextBox.Size = New Size(602, 151)
        NoteMorsettoTextBox.TabIndex = 1
        ' 
        ' MorsettiTableLayoutPanel
        ' 
        MorsettiTableLayoutPanel.ColumnCount = 4
        MorsettiTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 36.8263474F))
        MorsettiTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 63.1736526F))
        MorsettiTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 113F))
        MorsettiTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 284F))
        MorsettiTableLayoutPanel.Controls.Add(Label34, 0, 0)
        MorsettiTableLayoutPanel.Controls.Add(MarcaMorsettoComboBox, 1, 0)
        MorsettiTableLayoutPanel.Controls.Add(Label36, 2, 0)
        MorsettiTableLayoutPanel.Controls.Add(TipoMorsettoComboBox, 3, 0)
        MorsettiTableLayoutPanel.Controls.Add(Label38, 0, 1)
        MorsettiTableLayoutPanel.Controls.Add(SuperficieOccupataTextBox, 1, 1)
        MorsettiTableLayoutPanel.Controls.Add(Label39, 2, 1)
        MorsettiTableLayoutPanel.Controls.Add(QuantitaMorsettiTextBox, 3, 1)
        MorsettiTableLayoutPanel.Dock = DockStyle.Top
        MorsettiTableLayoutPanel.Location = New Point(3, 44)
        MorsettiTableLayoutPanel.Name = "MorsettiTableLayoutPanel"
        MorsettiTableLayoutPanel.RowCount = 2
        MorsettiTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        MorsettiTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        MorsettiTableLayoutPanel.Size = New Size(709, 87)
        MorsettiTableLayoutPanel.TabIndex = 1
        ' 
        ' Label34
        ' 
        Label34.Anchor = AnchorStyles.Left
        Label34.AutoSize = True
        Label34.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label34.Location = New Point(3, 14)
        Label34.Name = "Label34"
        Label34.Size = New Size(47, 15)
        Label34.TabIndex = 0
        Label34.Text = "Marca :"
        ' 
        ' MarcaMorsettoComboBox
        ' 
        MarcaMorsettoComboBox.Anchor = AnchorStyles.Left
        MarcaMorsettoComboBox.FormattingEnabled = True
        MarcaMorsettoComboBox.Location = New Point(117, 10)
        MarcaMorsettoComboBox.Name = "MarcaMorsettoComboBox"
        MarcaMorsettoComboBox.Size = New Size(166, 23)
        MarcaMorsettoComboBox.TabIndex = 1
        ' 
        ' Label36
        ' 
        Label36.Anchor = AnchorStyles.Left
        Label36.AutoSize = True
        Label36.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label36.Location = New Point(314, 14)
        Label36.Name = "Label36"
        Label36.Size = New Size(92, 15)
        Label36.TabIndex = 2
        Label36.Text = "Tipo Morsetto :"
        ' 
        ' TipoMorsettoComboBox
        ' 
        TipoMorsettoComboBox.Anchor = AnchorStyles.Left
        TipoMorsettoComboBox.FormattingEnabled = True
        TipoMorsettoComboBox.Location = New Point(427, 10)
        TipoMorsettoComboBox.Name = "TipoMorsettoComboBox"
        TipoMorsettoComboBox.Size = New Size(260, 23)
        TipoMorsettoComboBox.TabIndex = 3
        ' 
        ' Label38
        ' 
        Label38.Anchor = AnchorStyles.Left
        Label38.AutoSize = True
        Label38.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label38.Location = New Point(3, 50)
        Label38.Name = "Label38"
        Label38.Size = New Size(67, 30)
        Label38.TabIndex = 4
        Label38.Text = "Superficie Occupata :"
        ' 
        ' SuperficieOccupataTextBox
        ' 
        SuperficieOccupataTextBox.Anchor = AnchorStyles.Left
        SuperficieOccupataTextBox.BackColor = SystemColors.Control
        SuperficieOccupataTextBox.Location = New Point(117, 53)
        SuperficieOccupataTextBox.Name = "SuperficieOccupataTextBox"
        SuperficieOccupataTextBox.Size = New Size(100, 23)
        SuperficieOccupataTextBox.TabIndex = 5
        ' 
        ' Label39
        ' 
        Label39.Anchor = AnchorStyles.Left
        Label39.AutoSize = True
        Label39.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label39.Location = New Point(314, 57)
        Label39.Name = "Label39"
        Label39.Size = New Size(58, 15)
        Label39.TabIndex = 6
        Label39.Text = "Quantità:"
        ' 
        ' QuantitaMorsettiTextBox
        ' 
        QuantitaMorsettiTextBox.Anchor = AnchorStyles.Left
        QuantitaMorsettiTextBox.Location = New Point(427, 53)
        QuantitaMorsettiTextBox.Name = "QuantitaMorsettiTextBox"
        QuantitaMorsettiTextBox.Size = New Size(100, 23)
        QuantitaMorsettiTextBox.TabIndex = 7
        ' 
        ' MorsettoToolStrip
        ' 
        MorsettoToolStrip.BackColor = SystemColors.ControlDark
        MorsettoToolStrip.GripStyle = ToolStripGripStyle.Hidden
        MorsettoToolStrip.Items.AddRange(New ToolStripItem() {InizioMorsettoToolStripButton, IndietroMorsettoToolStripButton, RecordMorsettoToolStripLabel, AvantiMorsettoToolStripButton, FineMorsettoToolStripButton, ToolStripSeparator13, NuovoMorsettoToolStripButton, SalvaMorsettoToolStripButton, EliminaMorsettoToolStripButton, ModificaMorsettoToolStripButton, ToolStripSeparator14, RicercaMorsettoToolStripButton, AnnullaRicercaMorsettoToolStripButton, ToolStripSeparator15, AiutoMorsettiToolStripButton})
        MorsettoToolStrip.Location = New Point(3, 19)
        MorsettoToolStrip.Name = "MorsettoToolStrip"
        MorsettoToolStrip.Size = New Size(709, 25)
        MorsettoToolStrip.TabIndex = 0
        MorsettoToolStrip.Text = "ToolStrip1"
        ' 
        ' InizioMorsettoToolStripButton
        ' 
        InizioMorsettoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        InizioMorsettoToolStripButton.ImageTransparentColor = Color.Magenta
        InizioMorsettoToolStripButton.Name = "InizioMorsettoToolStripButton"
        InizioMorsettoToolStripButton.Size = New Size(23, 22)
        InizioMorsettoToolStripButton.Text = "ToolStripButton2"
        ' 
        ' IndietroMorsettoToolStripButton
        ' 
        IndietroMorsettoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        IndietroMorsettoToolStripButton.ImageTransparentColor = Color.Magenta
        IndietroMorsettoToolStripButton.Name = "IndietroMorsettoToolStripButton"
        IndietroMorsettoToolStripButton.Size = New Size(23, 22)
        IndietroMorsettoToolStripButton.Text = "ToolStripButton3"
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
        AvantiMorsettoToolStripButton.ImageTransparentColor = Color.Magenta
        AvantiMorsettoToolStripButton.Name = "AvantiMorsettoToolStripButton"
        AvantiMorsettoToolStripButton.Size = New Size(23, 22)
        AvantiMorsettoToolStripButton.Text = "ToolStripButton4"
        ' 
        ' FineMorsettoToolStripButton
        ' 
        FineMorsettoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        FineMorsettoToolStripButton.ImageTransparentColor = Color.Magenta
        FineMorsettoToolStripButton.Name = "FineMorsettoToolStripButton"
        FineMorsettoToolStripButton.Size = New Size(23, 22)
        FineMorsettoToolStripButton.Text = "ToolStripButton5"
        ' 
        ' ToolStripSeparator13
        ' 
        ToolStripSeparator13.Name = "ToolStripSeparator13"
        ToolStripSeparator13.Size = New Size(6, 25)
        ' 
        ' NuovoMorsettoToolStripButton
        ' 
        NuovoMorsettoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        NuovoMorsettoToolStripButton.ImageTransparentColor = Color.Magenta
        NuovoMorsettoToolStripButton.Name = "NuovoMorsettoToolStripButton"
        NuovoMorsettoToolStripButton.Size = New Size(23, 22)
        NuovoMorsettoToolStripButton.Text = "ToolStripButton6"
        NuovoMorsettoToolStripButton.ToolTipText = "Nuovo Morestto"
        ' 
        ' SalvaMorsettoToolStripButton
        ' 
        SalvaMorsettoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        SalvaMorsettoToolStripButton.ImageTransparentColor = Color.Magenta
        SalvaMorsettoToolStripButton.Name = "SalvaMorsettoToolStripButton"
        SalvaMorsettoToolStripButton.Size = New Size(23, 22)
        SalvaMorsettoToolStripButton.Text = "ToolStripButton7"
        ' 
        ' EliminaMorsettoToolStripButton
        ' 
        EliminaMorsettoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        EliminaMorsettoToolStripButton.ImageTransparentColor = Color.Magenta
        EliminaMorsettoToolStripButton.Name = "EliminaMorsettoToolStripButton"
        EliminaMorsettoToolStripButton.Size = New Size(23, 22)
        EliminaMorsettoToolStripButton.Text = "ToolStripButton8"
        ' 
        ' ModificaMorsettoToolStripButton
        ' 
        ModificaMorsettoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ModificaMorsettoToolStripButton.ImageTransparentColor = Color.Magenta
        ModificaMorsettoToolStripButton.Name = "ModificaMorsettoToolStripButton"
        ModificaMorsettoToolStripButton.Size = New Size(23, 22)
        ModificaMorsettoToolStripButton.Text = "ToolStripButton9"
        ' 
        ' ToolStripSeparator14
        ' 
        ToolStripSeparator14.Name = "ToolStripSeparator14"
        ToolStripSeparator14.Size = New Size(6, 25)
        ' 
        ' RicercaMorsettoToolStripButton
        ' 
        RicercaMorsettoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        RicercaMorsettoToolStripButton.ImageTransparentColor = Color.Magenta
        RicercaMorsettoToolStripButton.Name = "RicercaMorsettoToolStripButton"
        RicercaMorsettoToolStripButton.Size = New Size(23, 22)
        RicercaMorsettoToolStripButton.Text = "ToolStripButton10"
        ' 
        ' AnnullaRicercaMorsettoToolStripButton
        ' 
        AnnullaRicercaMorsettoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AnnullaRicercaMorsettoToolStripButton.ImageTransparentColor = Color.Magenta
        AnnullaRicercaMorsettoToolStripButton.Name = "AnnullaRicercaMorsettoToolStripButton"
        AnnullaRicercaMorsettoToolStripButton.Size = New Size(23, 22)
        AnnullaRicercaMorsettoToolStripButton.Text = "ToolStripButton11"
        ' 
        ' ToolStripSeparator15
        ' 
        ToolStripSeparator15.Name = "ToolStripSeparator15"
        ToolStripSeparator15.Size = New Size(6, 25)
        ' 
        ' AiutoMorsettiToolStripButton
        ' 
        AiutoMorsettiToolStripButton.Alignment = ToolStripItemAlignment.Right
        AiutoMorsettiToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AiutoMorsettiToolStripButton.ImageTransparentColor = Color.Magenta
        AiutoMorsettiToolStripButton.Name = "AiutoMorsettiToolStripButton"
        AiutoMorsettiToolStripButton.Size = New Size(23, 22)
        AiutoMorsettiToolStripButton.Text = "ToolStripButton12"
        ' 
        ' GraficaTableLayoutPanel
        ' 
        GraficaTableLayoutPanel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GraficaTableLayoutPanel.ColumnCount = 1
        GraficaTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        GraficaTableLayoutPanel.Controls.Add(Label9, 0, 0)
        GraficaTableLayoutPanel.Location = New Point(744, 3)
        GraficaTableLayoutPanel.Name = "GraficaTableLayoutPanel"
        GraficaTableLayoutPanel.RowCount = 2
        GraficaTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        GraficaTableLayoutPanel.RowStyles.Add(New RowStyle())
        GraficaTableLayoutPanel.Size = New Size(756, 552)
        GraficaTableLayoutPanel.TabIndex = 1
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label9.BackColor = SystemColors.ControlDark
        Label9.Location = New Point(3, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(750, 25)
        Label9.TabIndex = 5
        Label9.Text = "RAPPRESENTAZIONE GRAFICA"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Anagrafica2TableLayoutPanel
        ' 
        Anagrafica2TableLayoutPanel.ColumnCount = 2
        Anagrafica2TableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 100F))
        Anagrafica2TableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        Anagrafica2TableLayoutPanel.Controls.Add(Label5, 0, 0)
        Anagrafica2TableLayoutPanel.Controls.Add(Label6, 0, 1)
        Anagrafica2TableLayoutPanel.Controls.Add(NoteAnagraficaTextBox, 1, 1)
        Anagrafica2TableLayoutPanel.Controls.Add(TipoImpiantoTextBox, 1, 0)
        Anagrafica2TableLayoutPanel.Dock = DockStyle.Top
        Anagrafica2TableLayoutPanel.Location = New Point(0, 113)
        Anagrafica2TableLayoutPanel.Name = "Anagrafica2TableLayoutPanel"
        Anagrafica2TableLayoutPanel.RowCount = 2
        Anagrafica2TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 28F))
        Anagrafica2TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 72F))
        Anagrafica2TableLayoutPanel.Size = New Size(1506, 100)
        Anagrafica2TableLayoutPanel.TabIndex = 16
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Left
        Label5.AutoSize = True
        Label5.Location = New Point(3, 6)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 15)
        Label5.TabIndex = 4
        Label5.Text = "Tipo Impianto:"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Left
        Label6.AutoSize = True
        Label6.Location = New Point(3, 56)
        Label6.Name = "Label6"
        Label6.Size = New Size(36, 15)
        Label6.TabIndex = 6
        Label6.Text = "Note:"
        ' 
        ' NoteAnagraficaTextBox
        ' 
        NoteAnagraficaTextBox.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        NoteAnagraficaTextBox.Location = New Point(103, 33)
        NoteAnagraficaTextBox.Multiline = True
        NoteAnagraficaTextBox.Name = "NoteAnagraficaTextBox"
        NoteAnagraficaTextBox.ScrollBars = ScrollBars.Vertical
        NoteAnagraficaTextBox.Size = New Size(1400, 61)
        NoteAnagraficaTextBox.TabIndex = 8
        ' 
        ' TipoImpiantoTextBox
        ' 
        TipoImpiantoTextBox.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TipoImpiantoTextBox.Location = New Point(103, 3)
        TipoImpiantoTextBox.Name = "TipoImpiantoTextBox"
        TipoImpiantoTextBox.Size = New Size(1400, 23)
        TipoImpiantoTextBox.TabIndex = 7
        ' 
        ' Anagrafica1TableLayoutPanel
        ' 
        Anagrafica1TableLayoutPanel.ColumnCount = 6
        Anagrafica1TableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 100F))
        Anagrafica1TableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 17.4730034F))
        Anagrafica1TableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 100F))
        Anagrafica1TableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 57.4812775F))
        Anagrafica1TableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 100F))
        Anagrafica1TableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.04572F))
        Anagrafica1TableLayoutPanel.Controls.Add(Label10, 2, 2)
        Anagrafica1TableLayoutPanel.Controls.Add(Label8, 4, 1)
        Anagrafica1TableLayoutPanel.Controls.Add(Label7, 4, 0)
        Anagrafica1TableLayoutPanel.Controls.Add(Label1, 0, 0)
        Anagrafica1TableLayoutPanel.Controls.Add(Label3, 0, 1)
        Anagrafica1TableLayoutPanel.Controls.Add(Label2, 2, 0)
        Anagrafica1TableLayoutPanel.Controls.Add(Label4, 2, 1)
        Anagrafica1TableLayoutPanel.Controls.Add(CodiceClienteTextBox, 1, 0)
        Anagrafica1TableLayoutPanel.Controls.Add(NominativoTextBox, 3, 0)
        Anagrafica1TableLayoutPanel.Controls.Add(CapTextBox, 5, 0)
        Anagrafica1TableLayoutPanel.Controls.Add(IndirizzoTextBox, 3, 1)
        Anagrafica1TableLayoutPanel.Controls.Add(CittaTextBox, 1, 1)
        Anagrafica1TableLayoutPanel.Controls.Add(EmailTextBox, 3, 2)
        Anagrafica1TableLayoutPanel.Controls.Add(TelefonoTextBox, 5, 1)
        Anagrafica1TableLayoutPanel.Dock = DockStyle.Top
        Anagrafica1TableLayoutPanel.Location = New Point(0, 25)
        Anagrafica1TableLayoutPanel.Name = "Anagrafica1TableLayoutPanel"
        Anagrafica1TableLayoutPanel.RowCount = 3
        Anagrafica1TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 27F))
        Anagrafica1TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 27F))
        Anagrafica1TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 27F))
        Anagrafica1TableLayoutPanel.Size = New Size(1506, 88)
        Anagrafica1TableLayoutPanel.TabIndex = 15
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Left
        Label10.AutoSize = True
        Label10.Location = New Point(313, 63)
        Label10.Name = "Label10"
        Label10.Size = New Size(44, 15)
        Label10.TabIndex = 8
        Label10.Text = "E-Mail:"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Left
        Label8.AutoSize = True
        Label8.Location = New Point(1106, 33)
        Label8.Name = "Label8"
        Label8.Size = New Size(56, 15)
        Label8.TabIndex = 8
        Label8.Text = "Telefono:"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Left
        Label7.AutoSize = True
        Label7.Location = New Point(1106, 6)
        Label7.Name = "Label7"
        Label7.Size = New Size(31, 15)
        Label7.TabIndex = 8
        Label7.Text = "Cap:"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Location = New Point(3, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 15)
        Label1.TabIndex = 0
        Label1.Text = "Codice Cliente:"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Left
        Label3.AutoSize = True
        Label3.Location = New Point(3, 33)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 15)
        Label3.TabIndex = 2
        Label3.Text = "Città:"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Location = New Point(313, 6)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nominativo:"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Left
        Label4.AutoSize = True
        Label4.Location = New Point(313, 33)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 15)
        Label4.TabIndex = 3
        Label4.Text = "Indirizzo:"
        ' 
        ' CodiceClienteTextBox
        ' 
        CodiceClienteTextBox.Anchor = AnchorStyles.Left
        CodiceClienteTextBox.Location = New Point(103, 3)
        CodiceClienteTextBox.Name = "CodiceClienteTextBox"
        CodiceClienteTextBox.ReadOnly = True
        CodiceClienteTextBox.Size = New Size(133, 23)
        CodiceClienteTextBox.TabIndex = 1
        ' 
        ' NominativoTextBox
        ' 
        NominativoTextBox.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        NominativoTextBox.Location = New Point(413, 3)
        NominativoTextBox.Name = "NominativoTextBox"
        NominativoTextBox.Size = New Size(687, 23)
        NominativoTextBox.TabIndex = 2
        ' 
        ' CapTextBox
        ' 
        CapTextBox.Anchor = AnchorStyles.Left
        CapTextBox.Location = New Point(1206, 3)
        CapTextBox.Name = "CapTextBox"
        CapTextBox.Size = New Size(135, 23)
        CapTextBox.TabIndex = 3
        ' 
        ' IndirizzoTextBox
        ' 
        IndirizzoTextBox.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        IndirizzoTextBox.Location = New Point(413, 30)
        IndirizzoTextBox.Name = "IndirizzoTextBox"
        IndirizzoTextBox.Size = New Size(687, 23)
        IndirizzoTextBox.TabIndex = 5
        ' 
        ' CittaTextBox
        ' 
        CittaTextBox.Location = New Point(103, 30)
        CittaTextBox.Name = "CittaTextBox"
        CittaTextBox.Size = New Size(173, 23)
        CittaTextBox.TabIndex = 4
        ' 
        ' EmailTextBox
        ' 
        EmailTextBox.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        EmailTextBox.Location = New Point(413, 59)
        EmailTextBox.Name = "EmailTextBox"
        EmailTextBox.Size = New Size(687, 23)
        EmailTextBox.TabIndex = 14
        ' 
        ' TelefonoTextBox
        ' 
        TelefonoTextBox.Anchor = AnchorStyles.Left
        TelefonoTextBox.Location = New Point(1206, 30)
        TelefonoTextBox.Name = "TelefonoTextBox"
        TelefonoTextBox.Size = New Size(135, 23)
        TelefonoTextBox.TabIndex = 6
        ' 
        ' AnagraficaToolStrip
        ' 
        AnagraficaToolStrip.AllowMerge = False
        AnagraficaToolStrip.BackColor = SystemColors.ControlDark
        AnagraficaToolStrip.GripStyle = ToolStripGripStyle.Hidden
        AnagraficaToolStrip.Items.AddRange(New ToolStripItem() {ToolStripTextBox1, SalvaAnagraficaToolStripButton, ModificaAnagraficaToolStripButton, ToolStripSeparator1, StampaToolStripButton, ToolStripSeparator2, ToolStripButton1, ToolStripTextBox5, EsciToolStripButton})
        AnagraficaToolStrip.Location = New Point(0, 0)
        AnagraficaToolStrip.Name = "AnagraficaToolStrip"
        AnagraficaToolStrip.Size = New Size(1506, 25)
        AnagraficaToolStrip.TabIndex = 14
        AnagraficaToolStrip.Text = "ToolStrip1"
        ' 
        ' ToolStripTextBox1
        ' 
        ToolStripTextBox1.BackColor = SystemColors.ControlDark
        ToolStripTextBox1.BorderStyle = BorderStyle.None
        ToolStripTextBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ToolStripTextBox1.Name = "ToolStripTextBox1"
        ToolStripTextBox1.ReadOnly = True
        ToolStripTextBox1.Size = New Size(100, 25)
        ToolStripTextBox1.Text = "-Anagrafica:"
        ' 
        ' SalvaAnagraficaToolStripButton
        ' 
        SalvaAnagraficaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        SalvaAnagraficaToolStripButton.Image = CType(resources.GetObject("SalvaAnagraficaToolStripButton.Image"), Image)
        SalvaAnagraficaToolStripButton.ImageTransparentColor = Color.Magenta
        SalvaAnagraficaToolStripButton.Name = "SalvaAnagraficaToolStripButton"
        SalvaAnagraficaToolStripButton.Size = New Size(23, 22)
        SalvaAnagraficaToolStripButton.Text = "Salva Anagrafica"
        SalvaAnagraficaToolStripButton.ToolTipText = "Salva Anagrafica [Ctrl + S]"
        ' 
        ' ModificaAnagraficaToolStripButton
        ' 
        ModificaAnagraficaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ModificaAnagraficaToolStripButton.Image = CType(resources.GetObject("ModificaAnagraficaToolStripButton.Image"), Image)
        ModificaAnagraficaToolStripButton.ImageTransparentColor = Color.Magenta
        ModificaAnagraficaToolStripButton.Name = "ModificaAnagraficaToolStripButton"
        ModificaAnagraficaToolStripButton.Size = New Size(23, 22)
        ModificaAnagraficaToolStripButton.Text = "Modifica Anagrafica"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 25)
        ' 
        ' StampaToolStripButton
        ' 
        StampaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        StampaToolStripButton.Image = CType(resources.GetObject("StampaToolStripButton.Image"), Image)
        StampaToolStripButton.ImageTransparentColor = Color.Magenta
        StampaToolStripButton.Name = "StampaToolStripButton"
        StampaToolStripButton.Size = New Size(23, 22)
        StampaToolStripButton.Text = "Stampa"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 25)
        ' 
        ' ToolStripButton1
        ' 
        ToolStripButton1.Alignment = ToolStripItemAlignment.Right
        ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton1.ImageTransparentColor = Color.Magenta
        ToolStripButton1.Name = "ToolStripButton1"
        ToolStripButton1.Size = New Size(23, 22)
        ToolStripButton1.Text = "ToolStripButton1"
        ' 
        ' ToolStripTextBox5
        ' 
        ToolStripTextBox5.Alignment = ToolStripItemAlignment.Right
        ToolStripTextBox5.BackColor = SystemColors.ControlDark
        ToolStripTextBox5.BorderStyle = BorderStyle.None
        ToolStripTextBox5.Enabled = False
        ToolStripTextBox5.Name = "ToolStripTextBox5"
        ToolStripTextBox5.Size = New Size(25, 25)
        ' 
        ' EsciToolStripButton
        ' 
        EsciToolStripButton.Alignment = ToolStripItemAlignment.Right
        EsciToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        EsciToolStripButton.ImageTransparentColor = Color.Magenta
        EsciToolStripButton.Name = "EsciToolStripButton"
        EsciToolStripButton.Size = New Size(23, 22)
        EsciToolStripButton.Text = "ToolStripButton3"
        ' 
        ' FormTuboScatola
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(1506, 785)
        ControlBox = False
        Controls.Add(PanelGlobale)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormTuboScatola"
        Text = "FormTuboScatola"
        PanelGlobale.ResumeLayout(False)
        PanelGlobale.PerformLayout()
        Panel1.ResumeLayout(False)
        TableLayoutPanel_Principale.ResumeLayout(False)
        TableLayoutPanel_Dati.ResumeLayout(False)
        ComponentiTabControl.ResumeLayout(False)
        ScatolaTabPage.ResumeLayout(False)
        ScatolaGroupBox.ResumeLayout(False)
        ScatolaGroupBox.PerformLayout()
        CType(DgwScatole, ComponentModel.ISupportInitialize).EndInit()
        DGWTableLayoutPanel.ResumeLayout(False)
        CType(ComponentiScatolaDataGridView, ComponentModel.ISupportInitialize).EndInit()
        NotaScatolaTableLayoutPanel.ResumeLayout(False)
        NotaScatolaTableLayoutPanel.PerformLayout()
        CalcoliScatolaTableLayoutPanel.ResumeLayout(False)
        CalcoliScatolaTableLayoutPanel.PerformLayout()
        InputScatolaTableLayoutPanel.ResumeLayout(False)
        InputScatolaTableLayoutPanel.PerformLayout()
        ScatolaToolStrip.ResumeLayout(False)
        ScatolaToolStrip.PerformLayout()
        TuboTabPage.ResumeLayout(False)
        TuboGroupBox.ResumeLayout(False)
        TuboGroupBox.PerformLayout()
        NoteTuboTableLayoutPanel.ResumeLayout(False)
        NoteTuboTableLayoutPanel.PerformLayout()
        InputTuboTableLayoutPanel.ResumeLayout(False)
        InputTuboTableLayoutPanel.PerformLayout()
        TuboToolStrip.ResumeLayout(False)
        TuboToolStrip.PerformLayout()
        FiliTabPage.ResumeLayout(False)
        FiliGroupBox.ResumeLayout(False)
        FiliGroupBox.PerformLayout()
        NoteFiliTableLayoutPanel.ResumeLayout(False)
        NoteFiliTableLayoutPanel.PerformLayout()
        InputFiliTableLayoutPanel.ResumeLayout(False)
        InputFiliTableLayoutPanel.PerformLayout()
        FiloToolStrip.ResumeLayout(False)
        FiloToolStrip.PerformLayout()
        MorsettiTabPage.ResumeLayout(False)
        MorsettiGroupBox.ResumeLayout(False)
        MorsettiGroupBox.PerformLayout()
        NoteMorsettiTableLayoutPanel.ResumeLayout(False)
        NoteMorsettiTableLayoutPanel.PerformLayout()
        MorsettiTableLayoutPanel.ResumeLayout(False)
        MorsettiTableLayoutPanel.PerformLayout()
        MorsettoToolStrip.ResumeLayout(False)
        MorsettoToolStrip.PerformLayout()
        GraficaTableLayoutPanel.ResumeLayout(False)
        Anagrafica2TableLayoutPanel.ResumeLayout(False)
        Anagrafica2TableLayoutPanel.PerformLayout()
        Anagrafica1TableLayoutPanel.ResumeLayout(False)
        Anagrafica1TableLayoutPanel.PerformLayout()
        AnagraficaToolStrip.ResumeLayout(False)
        AnagraficaToolStrip.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents PanelGlobale As Panel
    Friend WithEvents Anagrafica2TableLayoutPanel As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents NoteAnagraficaTextBox As TextBox
    Friend WithEvents TipoImpiantoTextBox As TextBox
    Friend WithEvents Anagrafica1TableLayoutPanel As TableLayoutPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CodiceClienteTextBox As TextBox
    Friend WithEvents NominativoTextBox As TextBox
    Friend WithEvents CapTextBox As TextBox
    Friend WithEvents IndirizzoTextBox As TextBox
    Friend WithEvents CittaTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents AnagraficaToolStrip As ToolStrip
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents SalvaAnagraficaToolStripButton As ToolStripButton
    Friend WithEvents ModificaAnagraficaToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents StampaToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripTextBox5 As ToolStripTextBox
    Friend WithEvents EsciToolStripButton As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel_Principale As TableLayoutPanel
    Friend WithEvents TableLayoutPanel_Dati As TableLayoutPanel
    Friend WithEvents GraficaTableLayoutPanel As TableLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents ComponentiTabControl As TabControl
    Friend WithEvents ScatolaTabPage As TabPage
    Friend WithEvents ScatolaGroupBox As GroupBox
    Friend WithEvents DGWTableLayoutPanel As TableLayoutPanel
    Friend WithEvents ComponentiScatolaDataGridView As DataGridView
    Friend WithEvents ColTipo As DataGridViewTextBoxColumn
    Friend WithEvents ColDescrizione As DataGridViewTextBoxColumn
    Friend WithEvents ColVolumeUnitario As DataGridViewTextBoxColumn
    Friend WithEvents ColQuantita As DataGridViewTextBoxColumn
    Friend WithEvents ColVolumeTotale As DataGridViewTextBoxColumn
    Friend WithEvents NotaScatolaTableLayoutPanel As TableLayoutPanel
    Friend WithEvents NoteScatolaTextBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents CalcoliScatolaTableLayoutPanel As TableLayoutPanel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents ModelloScatolaTextBox As TextBox
    Friend WithEvents LarghezzaScatolaTextBox As TextBox
    Friend WithEvents AltezzaScatolaTextBox As TextBox
    Friend WithEvents ProfonditaScatolaTextBox As TextBox
    Friend WithEvents EsitoVerificaTextBox As TextBox
    Friend WithEvents InputScatolaTableLayoutPanel As TableLayoutPanel
    Friend WithEvents Label13 As Label
    Friend WithEvents MarcaScatolaComboBox As ComboBox
    Friend WithEvents MargineSicurezzaComboBox As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents LocaleScatolaTextBox As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ScatolaToolStrip As ToolStrip
    Friend WithEvents InizioScatolaToolStripButton As ToolStripButton
    Friend WithEvents IndietroScatolaToolStripButton As ToolStripButton
    Friend WithEvents RecordScatolaToolStripLabel As ToolStripLabel
    Friend WithEvents AvantiScatolaToolStripButton As ToolStripButton
    Friend WithEvents FineScatolaToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents NuovoScatolaToolStripButton As ToolStripButton
    Friend WithEvents SalvaScatolaToolStripButton As ToolStripButton
    Friend WithEvents EliminaScatolaToolStripButton As ToolStripButton
    Friend WithEvents ModificaScatolaToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents RicercaScatolaToolStripButton As ToolStripButton
    Friend WithEvents AnnullaRicercaScatolaToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AiutoTuboToolStripButton As ToolStripButton
    Friend WithEvents CalcolaScatolaToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents TuboTabPage As TabPage
    Friend WithEvents TuboGroupBox As GroupBox
    Friend WithEvents NoteTuboTableLayoutPanel As TableLayoutPanel
    Friend WithEvents Label25 As Label
    Friend WithEvents NoteTuboTextBox As TextBox
    Friend WithEvents InputTuboTableLayoutPanel As TableLayoutPanel
    Friend WithEvents DiametroEstComboBox As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents NomeTuboTextBox As TextBox
    Friend WithEvents LatoIngressoComboBox As ComboBox
    Friend WithEvents DiametroIntTuboTextBox As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents MarcaTuboComboBox As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TipoTuboComboBox As ComboBox
    Friend WithEvents TuboToolStrip As ToolStrip
    Friend WithEvents InizioTuboToolStripButton As ToolStripButton
    Friend WithEvents IndietroTuboToolStripButton As ToolStripButton
    Friend WithEvents RecordTuboToolStripLabel As ToolStripLabel
    Friend WithEvents AvantiTuboToolStripButton As ToolStripButton
    Friend WithEvents FineTuboToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents NuovoTuboToolStripButton As ToolStripButton
    Friend WithEvents SalvaTuboToolStripButton As ToolStripButton
    Friend WithEvents EliminaTuboToolStripButton As ToolStripButton
    Friend WithEvents ModificaTuboToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents RicercaTuboToolStripButton As ToolStripButton
    Friend WithEvents AnnullaRicercaTuboToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents AiutoFiloToolStripButton As ToolStripButton
    Friend WithEvents FiliTabPage As TabPage
    Friend WithEvents FiliGroupBox As GroupBox
    Friend WithEvents NoteFiliTableLayoutPanel As TableLayoutPanel
    Friend WithEvents Label32 As Label
    Friend WithEvents NoteFiloTextBox As TextBox
    Friend WithEvents InputFiliTableLayoutPanel As TableLayoutPanel
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents SezioneFiloComboBox As ComboBox
    Friend WithEvents ColoreFiloComboBox As ComboBox
    Friend WithEvents ClassificazioneFiloTextBox As TextBox
    Friend WithEvents NomeFiloTextBox As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents NoteColoreFiloLabel As Label
    Friend WithEvents TipoFiloTextBox As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents LunghezzaFiloTextBox As TextBox
    Friend WithEvents FiloToolStrip As ToolStrip
    Friend WithEvents InizioFiloToolStripButton As ToolStripButton
    Friend WithEvents IndietroFiloToolStripButton As ToolStripButton
    Friend WithEvents RecordFiloToolStripLabel As ToolStripLabel
    Friend WithEvents AvantiFiloToolStripButton As ToolStripButton
    Friend WithEvents FineFiloToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents NuovoFiloToolStripButton As ToolStripButton
    Friend WithEvents SalvaFiloToolStripButton As ToolStripButton
    Friend WithEvents EliminaFiloToolStripButton As ToolStripButton
    Friend WithEvents ModificaFiloToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents RicercaFiloToolStripButton As ToolStripButton
    Friend WithEvents AnnullaRicercaFiloToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents AiutoScatolaToolStripButton As ToolStripButton
    Friend WithEvents MorsettiTabPage As TabPage
    Friend WithEvents MorsettiGroupBox As GroupBox
    Friend WithEvents NoteMorsettiTableLayoutPanel As TableLayoutPanel
    Friend WithEvents Label33 As Label
    Friend WithEvents NoteMorsettoTextBox As TextBox
    Friend WithEvents MorsettiTableLayoutPanel As TableLayoutPanel
    Friend WithEvents Label34 As Label
    Friend WithEvents MarcaMorsettoComboBox As ComboBox
    Friend WithEvents Label36 As Label
    Friend WithEvents TipoMorsettoComboBox As ComboBox
    Friend WithEvents Label38 As Label
    Friend WithEvents SuperficieOccupataTextBox As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents QuantitaMorsettiTextBox As TextBox
    Friend WithEvents MorsettoToolStrip As ToolStrip
    Friend WithEvents InizioMorsettoToolStripButton As ToolStripButton
    Friend WithEvents IndietroMorsettoToolStripButton As ToolStripButton
    Friend WithEvents RecordMorsettoToolStripLabel As ToolStripLabel
    Friend WithEvents AvantiMorsettoToolStripButton As ToolStripButton
    Friend WithEvents FineMorsettoToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
    Friend WithEvents NuovoMorsettoToolStripButton As ToolStripButton
    Friend WithEvents SalvaMorsettoToolStripButton As ToolStripButton
    Friend WithEvents EliminaMorsettoToolStripButton As ToolStripButton
    Friend WithEvents ModificaMorsettoToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator14 As ToolStripSeparator
    Friend WithEvents RicercaMorsettoToolStripButton As ToolStripButton
    Friend WithEvents AnnullaRicercaMorsettoToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator15 As ToolStripSeparator
    Friend WithEvents AiutoMorsettiToolStripButton As ToolStripButton
    Friend WithEvents DgwScatole As DataGridView
    Friend WithEvents Label40 As Label
    Friend WithEvents PreforaturaPosterioreTextBox As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents SettoriSopraSottoTextBox As TextBox
    Friend WithEvents SettoreiLateraliTextBox As TextBox
End Class
