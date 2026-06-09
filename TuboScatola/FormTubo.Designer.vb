<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTubo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTubo))
        NotificaTuboLabel = New Label()
        TuboToolStrip = New ToolStrip()
        InizioTuboToolStripButton = New ToolStripButton()
        IndietroTuboToolStripButton = New ToolStripButton()
        RecordTuboToolStripLabel = New ToolStripLabel()
        AvantiTuboToolStripButton = New ToolStripButton()
        FineTuboToolStripButton = New ToolStripButton()
        ToolStripSeparator1 = New ToolStripSeparator()
        NuovoTuboToolStripButton = New ToolStripButton()
        SalvaTuboToolStripButton = New ToolStripButton()
        EliminaTuboToolStripButton = New ToolStripButton()
        ModificaTuboToolStripButton = New ToolStripButton()
        ToolStripSeparator2 = New ToolStripSeparator()
        RicercaTuboToolStripButton = New ToolStripButton()
        AnnulaRicercaTuboToolStripButton = New ToolStripButton()
        StampaTuboToolStripButton1 = New ToolStripButton()
        ToolStripSeparator3 = New ToolStripSeparator()
        EsportaDBTuboToolStripButton = New ToolStripButton()
        ImportaDBTuboToolStripButton = New ToolStripButton()
        EliminaDBTuboToolStripButton = New ToolStripButton()
        ToolStripSeparator4 = New ToolStripSeparator()
        EsciTuboToolStripButton = New ToolStripButton()
        AiutoTuboToolStripButton = New ToolStripButton()
        NotificaTuboStatusStrip = New StatusStrip()
        NotificaTuboToolStripStatusLabel = New ToolStripStatusLabel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        ComboBox1 = New ComboBox()
        LibTuboDataGridView = New DataGridView()
        TuboToolStrip.SuspendLayout()
        NotificaTuboStatusStrip.SuspendLayout()
        CType(LibTuboDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' NotificaTuboLabel
        ' 
        NotificaTuboLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        NotificaTuboLabel.BorderStyle = BorderStyle.Fixed3D
        NotificaTuboLabel.Location = New Point(12, 363)
        NotificaTuboLabel.Name = "NotificaTuboLabel"
        NotificaTuboLabel.Size = New Size(603, 52)
        NotificaTuboLabel.TabIndex = 2
        NotificaTuboLabel.Text = "Label1"
        ' 
        ' TuboToolStrip
        ' 
        TuboToolStrip.BackColor = SystemColors.ControlDark
        TuboToolStrip.GripStyle = ToolStripGripStyle.Hidden
        TuboToolStrip.Items.AddRange(New ToolStripItem() {InizioTuboToolStripButton, IndietroTuboToolStripButton, RecordTuboToolStripLabel, AvantiTuboToolStripButton, FineTuboToolStripButton, ToolStripSeparator1, NuovoTuboToolStripButton, SalvaTuboToolStripButton, ModificaTuboToolStripButton, EliminaTuboToolStripButton, ToolStripSeparator2, RicercaTuboToolStripButton, AnnulaRicercaTuboToolStripButton, StampaTuboToolStripButton1, ToolStripSeparator3, EsportaDBTuboToolStripButton, ImportaDBTuboToolStripButton, EliminaDBTuboToolStripButton, ToolStripSeparator4, EsciTuboToolStripButton, AiutoTuboToolStripButton})
        TuboToolStrip.Location = New Point(0, 0)
        TuboToolStrip.Name = "TuboToolStrip"
        TuboToolStrip.Size = New Size(627, 25)
        TuboToolStrip.TabIndex = 5
        TuboToolStrip.Text = "ToolStrip1"
        ' 
        ' InizioTuboToolStripButton
        ' 
        InizioTuboToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        InizioTuboToolStripButton.Image = CType(resources.GetObject("InizioTuboToolStripButton.Image"), Image)
        InizioTuboToolStripButton.ImageTransparentColor = Color.Magenta
        InizioTuboToolStripButton.Name = "InizioTuboToolStripButton"
        InizioTuboToolStripButton.Size = New Size(23, 22)
        InizioTuboToolStripButton.Text = "ToolStripButton1"
        ' 
        ' IndietroTuboToolStripButton
        ' 
        IndietroTuboToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        IndietroTuboToolStripButton.Image = CType(resources.GetObject("IndietroTuboToolStripButton.Image"), Image)
        IndietroTuboToolStripButton.ImageTransparentColor = Color.Magenta
        IndietroTuboToolStripButton.Name = "IndietroTuboToolStripButton"
        IndietroTuboToolStripButton.Size = New Size(23, 22)
        IndietroTuboToolStripButton.Text = "ToolStripButton2"
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
        AvantiTuboToolStripButton.Image = CType(resources.GetObject("AvantiTuboToolStripButton.Image"), Image)
        AvantiTuboToolStripButton.ImageTransparentColor = Color.Magenta
        AvantiTuboToolStripButton.Name = "AvantiTuboToolStripButton"
        AvantiTuboToolStripButton.Size = New Size(23, 22)
        AvantiTuboToolStripButton.Text = "ToolStripButton3"
        ' 
        ' FineTuboToolStripButton
        ' 
        FineTuboToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        FineTuboToolStripButton.Image = CType(resources.GetObject("FineTuboToolStripButton.Image"), Image)
        FineTuboToolStripButton.ImageTransparentColor = Color.Magenta
        FineTuboToolStripButton.Name = "FineTuboToolStripButton"
        FineTuboToolStripButton.Size = New Size(23, 22)
        FineTuboToolStripButton.Text = "ToolStripButton4"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 25)
        ' 
        ' NuovoTuboToolStripButton
        ' 
        NuovoTuboToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        NuovoTuboToolStripButton.Image = CType(resources.GetObject("NuovoTuboToolStripButton.Image"), Image)
        NuovoTuboToolStripButton.ImageTransparentColor = Color.Magenta
        NuovoTuboToolStripButton.Name = "NuovoTuboToolStripButton"
        NuovoTuboToolStripButton.Size = New Size(23, 22)
        NuovoTuboToolStripButton.Text = "ToolStripButton5"
        ' 
        ' SalvaTuboToolStripButton
        ' 
        SalvaTuboToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        SalvaTuboToolStripButton.Image = CType(resources.GetObject("SalvaTuboToolStripButton.Image"), Image)
        SalvaTuboToolStripButton.ImageTransparentColor = Color.Magenta
        SalvaTuboToolStripButton.Name = "SalvaTuboToolStripButton"
        SalvaTuboToolStripButton.Size = New Size(23, 22)
        SalvaTuboToolStripButton.Text = "ToolStripButton6"
        ' 
        ' EliminaTuboToolStripButton
        ' 
        EliminaTuboToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        EliminaTuboToolStripButton.Image = CType(resources.GetObject("EliminaTuboToolStripButton.Image"), Image)
        EliminaTuboToolStripButton.ImageTransparentColor = Color.Magenta
        EliminaTuboToolStripButton.Name = "EliminaTuboToolStripButton"
        EliminaTuboToolStripButton.Size = New Size(23, 22)
        EliminaTuboToolStripButton.Text = "ToolStripButton7"
        ' 
        ' ModificaTuboToolStripButton
        ' 
        ModificaTuboToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ModificaTuboToolStripButton.Image = CType(resources.GetObject("ModificaTuboToolStripButton.Image"), Image)
        ModificaTuboToolStripButton.ImageTransparentColor = Color.Magenta
        ModificaTuboToolStripButton.Name = "ModificaTuboToolStripButton"
        ModificaTuboToolStripButton.Size = New Size(23, 22)
        ModificaTuboToolStripButton.Text = "ToolStripButton8"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 25)
        ' 
        ' RicercaTuboToolStripButton
        ' 
        RicercaTuboToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        RicercaTuboToolStripButton.Image = CType(resources.GetObject("RicercaTuboToolStripButton.Image"), Image)
        RicercaTuboToolStripButton.ImageTransparentColor = Color.Magenta
        RicercaTuboToolStripButton.Name = "RicercaTuboToolStripButton"
        RicercaTuboToolStripButton.Size = New Size(23, 22)
        RicercaTuboToolStripButton.Text = "ToolStripButton9"
        ' 
        ' AnnulaRicercaTuboToolStripButton
        ' 
        AnnulaRicercaTuboToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AnnulaRicercaTuboToolStripButton.Image = CType(resources.GetObject("AnnulaRicercaTuboToolStripButton.Image"), Image)
        AnnulaRicercaTuboToolStripButton.ImageTransparentColor = Color.Magenta
        AnnulaRicercaTuboToolStripButton.Name = "AnnulaRicercaTuboToolStripButton"
        AnnulaRicercaTuboToolStripButton.Size = New Size(23, 22)
        AnnulaRicercaTuboToolStripButton.Text = "ToolStripButton10"
        ' 
        ' StampaTuboToolStripButton1
        ' 
        StampaTuboToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        StampaTuboToolStripButton1.Image = CType(resources.GetObject("StampaTuboToolStripButton1.Image"), Image)
        StampaTuboToolStripButton1.ImageTransparentColor = Color.Magenta
        StampaTuboToolStripButton1.Name = "StampaTuboToolStripButton1"
        StampaTuboToolStripButton1.Size = New Size(23, 22)
        StampaTuboToolStripButton1.Text = "ToolStripButton11"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(6, 25)
        ' 
        ' EsportaDBTuboToolStripButton
        ' 
        EsportaDBTuboToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        EsportaDBTuboToolStripButton.Image = CType(resources.GetObject("EsportaDBTuboToolStripButton.Image"), Image)
        EsportaDBTuboToolStripButton.ImageTransparentColor = Color.Magenta
        EsportaDBTuboToolStripButton.Name = "EsportaDBTuboToolStripButton"
        EsportaDBTuboToolStripButton.Size = New Size(23, 22)
        EsportaDBTuboToolStripButton.Text = "ToolStripButton12"
        ' 
        ' ImportaDBTuboToolStripButton
        ' 
        ImportaDBTuboToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ImportaDBTuboToolStripButton.Image = CType(resources.GetObject("ImportaDBTuboToolStripButton.Image"), Image)
        ImportaDBTuboToolStripButton.ImageTransparentColor = Color.Magenta
        ImportaDBTuboToolStripButton.Name = "ImportaDBTuboToolStripButton"
        ImportaDBTuboToolStripButton.Size = New Size(23, 22)
        ImportaDBTuboToolStripButton.Text = "ToolStripButton13"
        ' 
        ' EliminaDBTuboToolStripButton
        ' 
        EliminaDBTuboToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        EliminaDBTuboToolStripButton.Image = CType(resources.GetObject("EliminaDBTuboToolStripButton.Image"), Image)
        EliminaDBTuboToolStripButton.ImageTransparentColor = Color.Magenta
        EliminaDBTuboToolStripButton.Name = "EliminaDBTuboToolStripButton"
        EliminaDBTuboToolStripButton.Size = New Size(23, 22)
        EliminaDBTuboToolStripButton.Text = "ToolStripButton14"
        ' 
        ' ToolStripSeparator4
        ' 
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ToolStripSeparator4.Size = New Size(6, 25)
        ' 
        ' EsciTuboToolStripButton
        ' 
        EsciTuboToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        EsciTuboToolStripButton.Image = CType(resources.GetObject("EsciTuboToolStripButton.Image"), Image)
        EsciTuboToolStripButton.ImageTransparentColor = Color.Magenta
        EsciTuboToolStripButton.Name = "EsciTuboToolStripButton"
        EsciTuboToolStripButton.Size = New Size(23, 22)
        EsciTuboToolStripButton.Text = "ToolStripButton15"
        ' 
        ' AiutoTuboToolStripButton
        ' 
        AiutoTuboToolStripButton.Alignment = ToolStripItemAlignment.Right
        AiutoTuboToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AiutoTuboToolStripButton.Image = CType(resources.GetObject("AiutoTuboToolStripButton.Image"), Image)
        AiutoTuboToolStripButton.ImageTransparentColor = Color.Magenta
        AiutoTuboToolStripButton.Name = "AiutoTuboToolStripButton"
        AiutoTuboToolStripButton.Size = New Size(23, 22)
        AiutoTuboToolStripButton.Text = "ToolStripButton16"
        ' 
        ' NotificaTuboStatusStrip
        ' 
        NotificaTuboStatusStrip.Items.AddRange(New ToolStripItem() {NotificaTuboToolStripStatusLabel})
        NotificaTuboStatusStrip.Location = New Point(0, 428)
        NotificaTuboStatusStrip.Name = "NotificaTuboStatusStrip"
        NotificaTuboStatusStrip.Size = New Size(627, 22)
        NotificaTuboStatusStrip.TabIndex = 6
        NotificaTuboStatusStrip.Text = "StatusStrip1"
        ' 
        ' NotificaTuboToolStripStatusLabel
        ' 
        NotificaTuboToolStripStatusLabel.Name = "NotificaTuboToolStripStatusLabel"
        NotificaTuboToolStripStatusLabel.Size = New Size(184, 17)
        NotificaTuboToolStripStatusLabel.Text = "NotificaTuboToolStripStatusLabel"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 15)
        Label1.TabIndex = 7
        Label1.Text = "Marca :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(148, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 15)
        Label2.TabIndex = 8
        Label2.Text = "Tipo Tubo :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(348, 38)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 15)
        Label3.TabIndex = 9
        Label3.Text = "Diam. esterno (mm) :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(483, 38)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 15)
        Label4.TabIndex = 10
        Label4.Text = "Diam. Interno (mm):"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 104)
        Label5.Name = "Label5"
        Label5.Size = New Size(39, 15)
        Label5.TabIndex = 11
        Label5.Text = "Note :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 65)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(118, 23)
        TextBox1.TabIndex = 12
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(348, 65)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(119, 23)
        TextBox2.TabIndex = 13
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(483, 65)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(115, 23)
        TextBox3.TabIndex = 14
        ' 
        ' TextBox4
        ' 
        TextBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox4.Location = New Point(12, 122)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(600, 66)
        TextBox4.TabIndex = 15
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"FK Corrugato", "RK Rigido", "DF Flessibile", "Cavidotto doppia parete"})
        ComboBox1.Location = New Point(148, 65)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(179, 23)
        ComboBox1.TabIndex = 17
        ' 
        ' LibTuboDataGridView
        ' 
        LibTuboDataGridView.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        LibTuboDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        LibTuboDataGridView.Location = New Point(12, 194)
        LibTuboDataGridView.Name = "LibTuboDataGridView"
        LibTuboDataGridView.Size = New Size(600, 150)
        LibTuboDataGridView.TabIndex = 18
        ' 
        ' FormTubo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(627, 450)
        Controls.Add(LibTuboDataGridView)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(NotificaTuboStatusStrip)
        Controls.Add(TuboToolStrip)
        Controls.Add(NotificaTuboLabel)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormTubo"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Tubo"
        TuboToolStrip.ResumeLayout(False)
        TuboToolStrip.PerformLayout()
        NotificaTuboStatusStrip.ResumeLayout(False)
        NotificaTuboStatusStrip.PerformLayout()
        CType(LibTuboDataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NotificaTuboLabel As Label
    Friend WithEvents TuboToolStrip As ToolStrip
    Friend WithEvents InizioTuboToolStripButton As ToolStripButton
    Friend WithEvents IndietroTuboToolStripButton As ToolStripButton
    Friend WithEvents RecordTuboToolStripLabel As ToolStripLabel
    Friend WithEvents AvantiTuboToolStripButton As ToolStripButton
    Friend WithEvents FineTuboToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents NuovoTuboToolStripButton As ToolStripButton
    Friend WithEvents SalvaTuboToolStripButton As ToolStripButton
    Friend WithEvents EliminaTuboToolStripButton As ToolStripButton
    Friend WithEvents ModificaTuboToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents RicercaTuboToolStripButton As ToolStripButton
    Friend WithEvents AnnulaRicercaTuboToolStripButton As ToolStripButton
    Friend WithEvents StampaTuboToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents EsportaDBTuboToolStripButton As ToolStripButton
    Friend WithEvents ImportaDBTuboToolStripButton As ToolStripButton
    Friend WithEvents EliminaDBTuboToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents EsciTuboToolStripButton As ToolStripButton
    Friend WithEvents AiutoTuboToolStripButton As ToolStripButton
    Friend WithEvents NotificaTuboStatusStrip As StatusStrip
    Friend WithEvents NotificaTuboToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents LibTuboDataGridView As DataGridView
End Class
