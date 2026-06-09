<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFilo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFilo))
        NotificaFiliLabel = New Label()
        FiloToolStrip = New ToolStrip()
        InizioFiloToolStripButton = New ToolStripButton()
        IndietroFiloToolStripButton = New ToolStripButton()
        ToolStripLabel1 = New ToolStripLabel()
        AvantiFiloToolStripButton = New ToolStripButton()
        FineFiloToolStripButton = New ToolStripButton()
        ToolStripSeparator1 = New ToolStripSeparator()
        ToolStripButton5 = New ToolStripButton()
        ToolStripButton6 = New ToolStripButton()
        ToolStripButton7 = New ToolStripButton()
        ToolStripButton8 = New ToolStripButton()
        ToolStripSeparator2 = New ToolStripSeparator()
        ToolStripButton9 = New ToolStripButton()
        ToolStripButton10 = New ToolStripButton()
        ToolStripButton11 = New ToolStripButton()
        ToolStripSeparator3 = New ToolStripSeparator()
        ToolStripButton12 = New ToolStripButton()
        ToolStripButton13 = New ToolStripButton()
        ToolStripButton14 = New ToolStripButton()
        ToolStripSeparator4 = New ToolStripSeparator()
        ToolStripButton15 = New ToolStripButton()
        ToolStripButton16 = New ToolStripButton()
        NotificaFiloStatusStrip = New StatusStrip()
        NotificaFiloToolStripStatusLabel = New ToolStripStatusLabel()
        NoteFiloText = New TextBox()
        Label1 = New Label()
        SezioneText = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        TipofiloText = New TextBox()
        Label4 = New Label()
        DiametroEsternoFiloTextBox = New TextBox()
        Label5 = New Label()
        LunghezzaFiloTextBox = New TextBox()
        SupEstFiloLabel = New Label()
        Label6 = New Label()
        Label7 = New Label()
        ColoreFiloTextBox = New TextBox()
        Label8 = New Label()
        NoteColoreFiloTextBox = New TextBox()
        LibFiloDataGridView = New DataGridView()
        FiloToolStrip.SuspendLayout()
        NotificaFiloStatusStrip.SuspendLayout()
        CType(LibFiloDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' NotificaFiliLabel
        ' 
        NotificaFiliLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        NotificaFiliLabel.BorderStyle = BorderStyle.Fixed3D
        NotificaFiliLabel.Location = New Point(12, 416)
        NotificaFiliLabel.Name = "NotificaFiliLabel"
        NotificaFiliLabel.Size = New Size(776, 45)
        NotificaFiliLabel.TabIndex = 0
        NotificaFiliLabel.Text = "NotificaFiloLabel"
        ' 
        ' FiloToolStrip
        ' 
        FiloToolStrip.BackColor = SystemColors.ControlDark
        FiloToolStrip.GripStyle = ToolStripGripStyle.Hidden
        FiloToolStrip.Items.AddRange(New ToolStripItem() {InizioFiloToolStripButton, IndietroFiloToolStripButton, ToolStripLabel1, AvantiFiloToolStripButton, FineFiloToolStripButton, ToolStripSeparator1, ToolStripButton5, ToolStripButton6, ToolStripButton8, ToolStripButton7, ToolStripSeparator2, ToolStripButton9, ToolStripButton10, ToolStripButton11, ToolStripSeparator3, ToolStripButton12, ToolStripButton13, ToolStripButton14, ToolStripSeparator4, ToolStripButton15, ToolStripButton16})
        FiloToolStrip.Location = New Point(0, 0)
        FiloToolStrip.Name = "FiloToolStrip"
        FiloToolStrip.Size = New Size(800, 25)
        FiloToolStrip.TabIndex = 1
        FiloToolStrip.Text = "ToolStrip1"
        ' 
        ' InizioFiloToolStripButton
        ' 
        InizioFiloToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        InizioFiloToolStripButton.Image = CType(resources.GetObject("InizioFiloToolStripButton.Image"), Image)
        InizioFiloToolStripButton.ImageTransparentColor = Color.Magenta
        InizioFiloToolStripButton.Name = "InizioFiloToolStripButton"
        InizioFiloToolStripButton.Size = New Size(23, 22)
        InizioFiloToolStripButton.Text = "ToolStripButton1"
        ' 
        ' IndietroFiloToolStripButton
        ' 
        IndietroFiloToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        IndietroFiloToolStripButton.Image = CType(resources.GetObject("IndietroFiloToolStripButton.Image"), Image)
        IndietroFiloToolStripButton.ImageTransparentColor = Color.Magenta
        IndietroFiloToolStripButton.Name = "IndietroFiloToolStripButton"
        IndietroFiloToolStripButton.Size = New Size(23, 22)
        IndietroFiloToolStripButton.Text = "ToolStripButton2"
        ' 
        ' ToolStripLabel1
        ' 
        ToolStripLabel1.Name = "ToolStripLabel1"
        ToolStripLabel1.Size = New Size(88, 22)
        ToolStripLabel1.Text = "ToolStripLabel1"
        ' 
        ' AvantiFiloToolStripButton
        ' 
        AvantiFiloToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AvantiFiloToolStripButton.Image = CType(resources.GetObject("AvantiFiloToolStripButton.Image"), Image)
        AvantiFiloToolStripButton.ImageTransparentColor = Color.Magenta
        AvantiFiloToolStripButton.Name = "AvantiFiloToolStripButton"
        AvantiFiloToolStripButton.Size = New Size(23, 22)
        AvantiFiloToolStripButton.Text = "ToolStripButton3"
        ' 
        ' FineFiloToolStripButton
        ' 
        FineFiloToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        FineFiloToolStripButton.Image = CType(resources.GetObject("FineFiloToolStripButton.Image"), Image)
        FineFiloToolStripButton.ImageTransparentColor = Color.Magenta
        FineFiloToolStripButton.Name = "FineFiloToolStripButton"
        FineFiloToolStripButton.Size = New Size(23, 22)
        FineFiloToolStripButton.Text = "ToolStripButton4"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 25)
        ' 
        ' ToolStripButton5
        ' 
        ToolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), Image)
        ToolStripButton5.ImageTransparentColor = Color.Magenta
        ToolStripButton5.Name = "ToolStripButton5"
        ToolStripButton5.Size = New Size(23, 22)
        ToolStripButton5.Text = "ToolStripButton5"
        ' 
        ' ToolStripButton6
        ' 
        ToolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), Image)
        ToolStripButton6.ImageTransparentColor = Color.Magenta
        ToolStripButton6.Name = "ToolStripButton6"
        ToolStripButton6.Size = New Size(23, 22)
        ToolStripButton6.Text = "ToolStripButton6"
        ' 
        ' ToolStripButton7
        ' 
        ToolStripButton7.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), Image)
        ToolStripButton7.ImageTransparentColor = Color.Magenta
        ToolStripButton7.Name = "ToolStripButton7"
        ToolStripButton7.Size = New Size(23, 22)
        ToolStripButton7.Text = "ToolStripButton7"
        ' 
        ' ToolStripButton8
        ' 
        ToolStripButton8.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), Image)
        ToolStripButton8.ImageTransparentColor = Color.Magenta
        ToolStripButton8.Name = "ToolStripButton8"
        ToolStripButton8.Size = New Size(23, 22)
        ToolStripButton8.Text = "ToolStripButton8"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 25)
        ' 
        ' ToolStripButton9
        ' 
        ToolStripButton9.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), Image)
        ToolStripButton9.ImageTransparentColor = Color.Magenta
        ToolStripButton9.Name = "ToolStripButton9"
        ToolStripButton9.Size = New Size(23, 22)
        ToolStripButton9.Text = "ToolStripButton9"
        ' 
        ' ToolStripButton10
        ' 
        ToolStripButton10.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), Image)
        ToolStripButton10.ImageTransparentColor = Color.Magenta
        ToolStripButton10.Name = "ToolStripButton10"
        ToolStripButton10.Size = New Size(23, 22)
        ToolStripButton10.Text = "ToolStripButton10"
        ' 
        ' ToolStripButton11
        ' 
        ToolStripButton11.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"), Image)
        ToolStripButton11.ImageTransparentColor = Color.Magenta
        ToolStripButton11.Name = "ToolStripButton11"
        ToolStripButton11.Size = New Size(23, 22)
        ToolStripButton11.Text = "ToolStripButton11"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(6, 25)
        ' 
        ' ToolStripButton12
        ' 
        ToolStripButton12.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton12.Image = CType(resources.GetObject("ToolStripButton12.Image"), Image)
        ToolStripButton12.ImageTransparentColor = Color.Magenta
        ToolStripButton12.Name = "ToolStripButton12"
        ToolStripButton12.Size = New Size(23, 22)
        ToolStripButton12.Text = "ToolStripButton12"
        ' 
        ' ToolStripButton13
        ' 
        ToolStripButton13.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton13.Image = CType(resources.GetObject("ToolStripButton13.Image"), Image)
        ToolStripButton13.ImageTransparentColor = Color.Magenta
        ToolStripButton13.Name = "ToolStripButton13"
        ToolStripButton13.Size = New Size(23, 22)
        ToolStripButton13.Text = "ToolStripButton13"
        ' 
        ' ToolStripButton14
        ' 
        ToolStripButton14.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton14.Image = CType(resources.GetObject("ToolStripButton14.Image"), Image)
        ToolStripButton14.ImageTransparentColor = Color.Magenta
        ToolStripButton14.Name = "ToolStripButton14"
        ToolStripButton14.Size = New Size(23, 22)
        ToolStripButton14.Text = "ToolStripButton14"
        ' 
        ' ToolStripSeparator4
        ' 
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ToolStripSeparator4.Size = New Size(6, 25)
        ' 
        ' ToolStripButton15
        ' 
        ToolStripButton15.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton15.Image = CType(resources.GetObject("ToolStripButton15.Image"), Image)
        ToolStripButton15.ImageTransparentColor = Color.Magenta
        ToolStripButton15.Name = "ToolStripButton15"
        ToolStripButton15.Size = New Size(23, 22)
        ToolStripButton15.Text = "ToolStripButton15"
        ' 
        ' ToolStripButton16
        ' 
        ToolStripButton16.Alignment = ToolStripItemAlignment.Right
        ToolStripButton16.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton16.Image = CType(resources.GetObject("ToolStripButton16.Image"), Image)
        ToolStripButton16.ImageTransparentColor = Color.Magenta
        ToolStripButton16.Name = "ToolStripButton16"
        ToolStripButton16.Size = New Size(23, 22)
        ToolStripButton16.Text = "ToolStripButton16"
        ' 
        ' NotificaFiloStatusStrip
        ' 
        NotificaFiloStatusStrip.Items.AddRange(New ToolStripItem() {NotificaFiloToolStripStatusLabel})
        NotificaFiloStatusStrip.Location = New Point(0, 470)
        NotificaFiloStatusStrip.Name = "NotificaFiloStatusStrip"
        NotificaFiloStatusStrip.Size = New Size(800, 22)
        NotificaFiloStatusStrip.TabIndex = 2
        NotificaFiloStatusStrip.Text = "StatusStrip1"
        ' 
        ' NotificaFiloToolStripStatusLabel
        ' 
        NotificaFiloToolStripStatusLabel.Name = "NotificaFiloToolStripStatusLabel"
        NotificaFiloToolStripStatusLabel.Size = New Size(175, 17)
        NotificaFiloToolStripStatusLabel.Text = "NotificaFiloToolStripStatusLabel"
        ' 
        ' NoteFiloText
        ' 
        NoteFiloText.Location = New Point(13, 164)
        NoteFiloText.Multiline = True
        NoteFiloText.Name = "NoteFiloText"
        NoteFiloText.ScrollBars = ScrollBars.Vertical
        NoteFiloText.Size = New Size(775, 66)
        NoteFiloText.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 146)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 4
        Label1.Text = "Note :"
        ' 
        ' SezioneText
        ' 
        SezioneText.Location = New Point(174, 53)
        SezioneText.Name = "SezioneText"
        SezioneText.Size = New Size(93, 23)
        SezioneText.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(174, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 15)
        Label2.TabIndex = 6
        Label2.Text = "Sezione (mmq) :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 35)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 15)
        Label3.TabIndex = 7
        Label3.Text = "Tipo Filo :"
        ' 
        ' TipofiloText
        ' 
        TipofiloText.Location = New Point(13, 53)
        TipofiloText.Name = "TipofiloText"
        TipofiloText.Size = New Size(143, 23)
        TipofiloText.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(299, 35)
        Label4.Name = "Label4"
        Label4.Size = New Size(137, 15)
        Label4.TabIndex = 10
        Label4.Text = "Diametro esterno (mm) :"
        ' 
        ' DiametroEsternoFiloTextBox
        ' 
        DiametroEsternoFiloTextBox.Location = New Point(299, 53)
        DiametroEsternoFiloTextBox.Name = "DiametroEsternoFiloTextBox"
        DiametroEsternoFiloTextBox.Size = New Size(137, 23)
        DiametroEsternoFiloTextBox.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(13, 88)
        Label5.Name = "Label5"
        Label5.Size = New Size(157, 15)
        Label5.TabIndex = 12
        Label5.Text = "Superficie occupata (mmq) :"
        ' 
        ' LunghezzaFiloTextBox
        ' 
        LunghezzaFiloTextBox.Location = New Point(458, 53)
        LunghezzaFiloTextBox.Name = "LunghezzaFiloTextBox"
        LunghezzaFiloTextBox.Size = New Size(100, 23)
        LunghezzaFiloTextBox.TabIndex = 4
        LunghezzaFiloTextBox.Text = "17"
        LunghezzaFiloTextBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' SupEstFiloLabel
        ' 
        SupEstFiloLabel.BackColor = SystemColors.Window
        SupEstFiloLabel.BorderStyle = BorderStyle.Fixed3D
        SupEstFiloLabel.Location = New Point(13, 113)
        SupEstFiloLabel.Name = "SupEstFiloLabel"
        SupEstFiloLabel.Size = New Size(143, 23)
        SupEstFiloLabel.TabIndex = 5
        SupEstFiloLabel.Text = "SupEstFiloLabel"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(458, 35)
        Label6.Name = "Label6"
        Label6.Size = New Size(97, 15)
        Label6.TabIndex = 14
        Label6.Text = "Lunghezza (cm) :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(582, 35)
        Label7.Name = "Label7"
        Label7.Size = New Size(48, 15)
        Label7.TabIndex = 16
        Label7.Text = "Colore :"
        ' 
        ' ColoreFiloTextBox
        ' 
        ColoreFiloTextBox.Location = New Point(582, 53)
        ColoreFiloTextBox.Name = "ColoreFiloTextBox"
        ColoreFiloTextBox.Size = New Size(100, 23)
        ColoreFiloTextBox.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(176, 88)
        Label8.Name = "Label8"
        Label8.Size = New Size(77, 15)
        Label8.TabIndex = 17
        Label8.Text = "Note Colore :"
        ' 
        ' NoteColoreFiloTextBox
        ' 
        NoteColoreFiloTextBox.Location = New Point(176, 113)
        NoteColoreFiloTextBox.Name = "NoteColoreFiloTextBox"
        NoteColoreFiloTextBox.ScrollBars = ScrollBars.Vertical
        NoteColoreFiloTextBox.Size = New Size(349, 23)
        NoteColoreFiloTextBox.TabIndex = 18
        ' 
        ' LibFiloDataGridView
        ' 
        LibFiloDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        LibFiloDataGridView.Location = New Point(12, 236)
        LibFiloDataGridView.Name = "LibFiloDataGridView"
        LibFiloDataGridView.Size = New Size(776, 167)
        LibFiloDataGridView.TabIndex = 19
        ' 
        ' FormFilo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 492)
        Controls.Add(LibFiloDataGridView)
        Controls.Add(Label8)
        Controls.Add(NoteColoreFiloTextBox)
        Controls.Add(Label7)
        Controls.Add(ColoreFiloTextBox)
        Controls.Add(Label6)
        Controls.Add(SupEstFiloLabel)
        Controls.Add(Label5)
        Controls.Add(LunghezzaFiloTextBox)
        Controls.Add(Label4)
        Controls.Add(DiametroEsternoFiloTextBox)
        Controls.Add(TipofiloText)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(SezioneText)
        Controls.Add(Label1)
        Controls.Add(NoteFiloText)
        Controls.Add(NotificaFiloStatusStrip)
        Controls.Add(FiloToolStrip)
        Controls.Add(NotificaFiliLabel)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormFilo"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Filo / Cavo"
        FiloToolStrip.ResumeLayout(False)
        FiloToolStrip.PerformLayout()
        NotificaFiloStatusStrip.ResumeLayout(False)
        NotificaFiloStatusStrip.PerformLayout()
        CType(LibFiloDataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NotificaFiliLabel As Label
    Friend WithEvents FiloToolStrip As ToolStrip
    Friend WithEvents NotificaFiloStatusStrip As StatusStrip
    Friend WithEvents NotificaFiloToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents NoteFiloText As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SezioneText As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TipofiloText As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DiametroEsternoFiloTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LunghezzaFiloTextBox As TextBox
    Friend WithEvents SupEstFiloLabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents InizioFiloToolStripButton As ToolStripButton
    Friend WithEvents IndietroFiloToolStripButton As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents AvantiFiloToolStripButton As ToolStripButton
    Friend WithEvents FineFiloToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents ToolStripButton8 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton9 As ToolStripButton
    Friend WithEvents ToolStripButton10 As ToolStripButton
    Friend WithEvents ToolStripButton11 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButton12 As ToolStripButton
    Friend WithEvents ToolStripButton13 As ToolStripButton
    Friend WithEvents ToolStripButton14 As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripButton15 As ToolStripButton
    Friend WithEvents ToolStripButton16 As ToolStripButton
    Friend WithEvents Label7 As Label
    Friend WithEvents ColoreFiloTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents NoteColoreFiloTextBox As TextBox
    Friend WithEvents LibFiloDataGridView As DataGridView
End Class
