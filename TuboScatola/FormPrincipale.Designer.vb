<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipale
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipale))
        PrincipaleToolStrip = New ToolStrip()
        FileToolStripDropDownButton = New ToolStripDropDownButton()
        NuovoToolStripMenuItem = New ToolStripMenuItem()
        ApriToolStripMenuItem = New ToolStripMenuItem()
        EsciToolStripMenuItem = New ToolStripMenuItem()
        DataBaseToolStripDropDownButton = New ToolStripDropDownButton()
        ApriLibreriaScatoleToolStripMenuItem = New ToolStripMenuItem()
        ApriLibreriaTubiToolStripMenuItem = New ToolStripMenuItem()
        ApriLibreriaFiliToolStripMenuItem = New ToolStripMenuItem()
        ApriLibreriaMorsettiToolStripMenuItem = New ToolStripMenuItem()
        EsportaDBToolStripMenuItem = New ToolStripMenuItem()
        ImportaDBToolStripMenuItem = New ToolStripMenuItem()
        EliminaDBToolStripMenuItem = New ToolStripMenuItem()
        AiutoToolStripDropDownButton = New ToolStripDropDownButton()
        GuidoUtenteToolStripMenuItem = New ToolStripMenuItem()
        InfoToolStripMenuItem = New ToolStripMenuItem()
        PrincipaleStatusStrip = New StatusStrip()
        lblNotifiche = New ToolStripStatusLabel()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        ToolStripStatusLabel2 = New ToolStripStatusLabel()
        NotificheOperativeToolStripStatusLabel = New ToolStripStatusLabel()
        PrincipaleToolStrip.SuspendLayout()
        PrincipaleStatusStrip.SuspendLayout()
        SuspendLayout()
        ' 
        ' PrincipaleToolStrip
        ' 
        PrincipaleToolStrip.BackColor = SystemColors.ControlDark
        PrincipaleToolStrip.GripStyle = ToolStripGripStyle.Hidden
        PrincipaleToolStrip.Items.AddRange(New ToolStripItem() {FileToolStripDropDownButton, DataBaseToolStripDropDownButton, AiutoToolStripDropDownButton})
        PrincipaleToolStrip.Location = New Point(0, 0)
        PrincipaleToolStrip.Name = "PrincipaleToolStrip"
        PrincipaleToolStrip.RenderMode = ToolStripRenderMode.Professional
        PrincipaleToolStrip.Size = New Size(1484, 25)
        PrincipaleToolStrip.TabIndex = 1
        ' 
        ' FileToolStripDropDownButton
        ' 
        FileToolStripDropDownButton.BackColor = SystemColors.ControlDark
        FileToolStripDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Text
        FileToolStripDropDownButton.DropDownItems.AddRange(New ToolStripItem() {NuovoToolStripMenuItem, ApriToolStripMenuItem, EsciToolStripMenuItem})
        FileToolStripDropDownButton.Image = CType(resources.GetObject("FileToolStripDropDownButton.Image"), Image)
        FileToolStripDropDownButton.ImageTransparentColor = Color.Magenta
        FileToolStripDropDownButton.Name = "FileToolStripDropDownButton"
        FileToolStripDropDownButton.Size = New Size(38, 22)
        FileToolStripDropDownButton.Text = "File"
        ' 
        ' NuovoToolStripMenuItem
        ' 
        NuovoToolStripMenuItem.BackColor = SystemColors.ControlDark
        NuovoToolStripMenuItem.Image = CType(resources.GetObject("NuovoToolStripMenuItem.Image"), Image)
        NuovoToolStripMenuItem.Name = "NuovoToolStripMenuItem"
        NuovoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + N"
        NuovoToolStripMenuItem.Size = New Size(180, 22)
        NuovoToolStripMenuItem.Text = "Nuovo"
        NuovoToolStripMenuItem.ToolTipText = "Nuovo [ Ctrl+N]"
        ' 
        ' ApriToolStripMenuItem
        ' 
        ApriToolStripMenuItem.BackColor = SystemColors.ControlDark
        ApriToolStripMenuItem.Image = CType(resources.GetObject("ApriToolStripMenuItem.Image"), Image)
        ApriToolStripMenuItem.Name = "ApriToolStripMenuItem"
        ApriToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + O"
        ApriToolStripMenuItem.Size = New Size(180, 22)
        ApriToolStripMenuItem.Text = "Apri"
        ApriToolStripMenuItem.ToolTipText = "Apri [Ctrl+A]"
        ' 
        ' EsciToolStripMenuItem
        ' 
        EsciToolStripMenuItem.BackColor = SystemColors.ControlDark
        EsciToolStripMenuItem.Image = CType(resources.GetObject("EsciToolStripMenuItem.Image"), Image)
        EsciToolStripMenuItem.Name = "EsciToolStripMenuItem"
        EsciToolStripMenuItem.ShortcutKeyDisplayString = "Esc"
        EsciToolStripMenuItem.Size = New Size(180, 22)
        EsciToolStripMenuItem.Text = "Esci"
        EsciToolStripMenuItem.ToolTipText = "Esci [Esc]"
        ' 
        ' DataBaseToolStripDropDownButton
        ' 
        DataBaseToolStripDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Text
        DataBaseToolStripDropDownButton.DropDownItems.AddRange(New ToolStripItem() {ApriLibreriaScatoleToolStripMenuItem, ApriLibreriaTubiToolStripMenuItem, ApriLibreriaFiliToolStripMenuItem, ApriLibreriaMorsettiToolStripMenuItem, EsportaDBToolStripMenuItem, ImportaDBToolStripMenuItem, EliminaDBToolStripMenuItem})
        DataBaseToolStripDropDownButton.Image = CType(resources.GetObject("DataBaseToolStripDropDownButton.Image"), Image)
        DataBaseToolStripDropDownButton.ImageTransparentColor = Color.Magenta
        DataBaseToolStripDropDownButton.Name = "DataBaseToolStripDropDownButton"
        DataBaseToolStripDropDownButton.Size = New Size(71, 22)
        DataBaseToolStripDropDownButton.Text = "Data Base"
        ' 
        ' ApriLibreriaScatoleToolStripMenuItem
        ' 
        ApriLibreriaScatoleToolStripMenuItem.BackColor = SystemColors.ControlDark
        ApriLibreriaScatoleToolStripMenuItem.Image = CType(resources.GetObject("ApriLibreriaScatoleToolStripMenuItem.Image"), Image)
        ApriLibreriaScatoleToolStripMenuItem.Name = "ApriLibreriaScatoleToolStripMenuItem"
        ApriLibreriaScatoleToolStripMenuItem.Size = New Size(180, 22)
        ApriLibreriaScatoleToolStripMenuItem.Text = "Scatola"
        ' 
        ' ApriLibreriaTubiToolStripMenuItem
        ' 
        ApriLibreriaTubiToolStripMenuItem.BackColor = SystemColors.ControlDark
        ApriLibreriaTubiToolStripMenuItem.Image = CType(resources.GetObject("ApriLibreriaTubiToolStripMenuItem.Image"), Image)
        ApriLibreriaTubiToolStripMenuItem.Name = "ApriLibreriaTubiToolStripMenuItem"
        ApriLibreriaTubiToolStripMenuItem.Size = New Size(180, 22)
        ApriLibreriaTubiToolStripMenuItem.Text = "Tubo"
        ' 
        ' ApriLibreriaFiliToolStripMenuItem
        ' 
        ApriLibreriaFiliToolStripMenuItem.BackColor = SystemColors.ControlDark
        ApriLibreriaFiliToolStripMenuItem.Image = CType(resources.GetObject("ApriLibreriaFiliToolStripMenuItem.Image"), Image)
        ApriLibreriaFiliToolStripMenuItem.Name = "ApriLibreriaFiliToolStripMenuItem"
        ApriLibreriaFiliToolStripMenuItem.Size = New Size(180, 22)
        ApriLibreriaFiliToolStripMenuItem.Text = "Filo"
        ' 
        ' ApriLibreriaMorsettiToolStripMenuItem
        ' 
        ApriLibreriaMorsettiToolStripMenuItem.BackColor = SystemColors.ButtonShadow
        ApriLibreriaMorsettiToolStripMenuItem.Image = CType(resources.GetObject("ApriLibreriaMorsettiToolStripMenuItem.Image"), Image)
        ApriLibreriaMorsettiToolStripMenuItem.Name = "ApriLibreriaMorsettiToolStripMenuItem"
        ApriLibreriaMorsettiToolStripMenuItem.Size = New Size(180, 22)
        ApriLibreriaMorsettiToolStripMenuItem.Text = "Morsetti"
        ' 
        ' EsportaDBToolStripMenuItem
        ' 
        EsportaDBToolStripMenuItem.BackColor = SystemColors.ControlDark
        EsportaDBToolStripMenuItem.Image = CType(resources.GetObject("EsportaDBToolStripMenuItem.Image"), Image)
        EsportaDBToolStripMenuItem.Name = "EsportaDBToolStripMenuItem"
        EsportaDBToolStripMenuItem.Size = New Size(180, 22)
        EsportaDBToolStripMenuItem.Text = "Esporta Data Base"
        ' 
        ' ImportaDBToolStripMenuItem
        ' 
        ImportaDBToolStripMenuItem.BackColor = SystemColors.ControlDark
        ImportaDBToolStripMenuItem.Image = CType(resources.GetObject("ImportaDBToolStripMenuItem.Image"), Image)
        ImportaDBToolStripMenuItem.Name = "ImportaDBToolStripMenuItem"
        ImportaDBToolStripMenuItem.Size = New Size(180, 22)
        ImportaDBToolStripMenuItem.Text = "Importa Data Base"
        ' 
        ' EliminaDBToolStripMenuItem
        ' 
        EliminaDBToolStripMenuItem.BackColor = SystemColors.ControlDark
        EliminaDBToolStripMenuItem.Image = CType(resources.GetObject("EliminaDBToolStripMenuItem.Image"), Image)
        EliminaDBToolStripMenuItem.Name = "EliminaDBToolStripMenuItem"
        EliminaDBToolStripMenuItem.Size = New Size(180, 22)
        EliminaDBToolStripMenuItem.Text = "Elimina Data Base"
        ' 
        ' AiutoToolStripDropDownButton
        ' 
        AiutoToolStripDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Text
        AiutoToolStripDropDownButton.DropDownItems.AddRange(New ToolStripItem() {GuidoUtenteToolStripMenuItem, InfoToolStripMenuItem})
        AiutoToolStripDropDownButton.Image = CType(resources.GetObject("AiutoToolStripDropDownButton.Image"), Image)
        AiutoToolStripDropDownButton.ImageTransparentColor = Color.Magenta
        AiutoToolStripDropDownButton.Name = "AiutoToolStripDropDownButton"
        AiutoToolStripDropDownButton.Size = New Size(49, 22)
        AiutoToolStripDropDownButton.Text = "Aiuto"
        ' 
        ' GuidoUtenteToolStripMenuItem
        ' 
        GuidoUtenteToolStripMenuItem.BackColor = SystemColors.ControlDark
        GuidoUtenteToolStripMenuItem.Image = CType(resources.GetObject("GuidoUtenteToolStripMenuItem.Image"), Image)
        GuidoUtenteToolStripMenuItem.Name = "GuidoUtenteToolStripMenuItem"
        GuidoUtenteToolStripMenuItem.Size = New Size(180, 22)
        GuidoUtenteToolStripMenuItem.Text = "Guido Utente"
        ' 
        ' InfoToolStripMenuItem
        ' 
        InfoToolStripMenuItem.BackColor = SystemColors.ControlDark
        InfoToolStripMenuItem.Image = CType(resources.GetObject("InfoToolStripMenuItem.Image"), Image)
        InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        InfoToolStripMenuItem.Size = New Size(180, 22)
        InfoToolStripMenuItem.Text = "Info"
        ' 
        ' PrincipaleStatusStrip
        ' 
        PrincipaleStatusStrip.BackColor = SystemColors.ControlDark
        PrincipaleStatusStrip.Items.AddRange(New ToolStripItem() {lblNotifiche, ToolStripStatusLabel1, ToolStripStatusLabel2, NotificheOperativeToolStripStatusLabel})
        PrincipaleStatusStrip.Location = New Point(0, 839)
        PrincipaleStatusStrip.Name = "PrincipaleStatusStrip"
        PrincipaleStatusStrip.Size = New Size(1484, 22)
        PrincipaleStatusStrip.TabIndex = 2
        PrincipaleStatusStrip.Text = "StatusStrip1"
        ' 
        ' lblNotifiche
        ' 
        lblNotifiche.BackColor = SystemColors.Control
        lblNotifiche.Name = "lblNotifiche"
        lblNotifiche.Size = New Size(69, 17)
        lblNotifiche.Text = "lblNotifiche"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(0, 17)
        ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        ' 
        ' ToolStripStatusLabel2
        ' 
        ToolStripStatusLabel2.BackColor = SystemColors.Control
        ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        ToolStripStatusLabel2.Size = New Size(16, 17)
        ToolStripStatusLabel2.Text = " | "
        ' 
        ' NotificheOperativeToolStripStatusLabel
        ' 
        NotificheOperativeToolStripStatusLabel.Name = "NotificheOperativeToolStripStatusLabel"
        NotificheOperativeToolStripStatusLabel.Size = New Size(120, 17)
        NotificheOperativeToolStripStatusLabel.Text = "ToolStripStatusLabel3"
        ' 
        ' FormPrincipale
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = SystemColors.ButtonShadow
        ClientSize = New Size(1484, 861)
        Controls.Add(PrincipaleStatusStrip)
        Controls.Add(PrincipaleToolStrip)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        IsMdiContainer = True
        KeyPreview = True
        MinimumSize = New Size(1500, 900)
        Name = "FormPrincipale"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Tubo Scatola"
        PrincipaleToolStrip.ResumeLayout(False)
        PrincipaleToolStrip.PerformLayout()
        PrincipaleStatusStrip.ResumeLayout(False)
        PrincipaleStatusStrip.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PrincipaleToolStrip As ToolStrip
    Friend WithEvents PrincipaleStatusStrip As StatusStrip
    Friend WithEvents lblNotifiche As ToolStripStatusLabel
    Friend WithEvents FileToolStripDropDownButton As ToolStripDropDownButton
    Friend WithEvents ApriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EsciToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents NuovoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataBaseToolStripDropDownButton As ToolStripDropDownButton
    Friend WithEvents AiutoToolStripDropDownButton As ToolStripDropDownButton
    Friend WithEvents GuidoUtenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EsportaDBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportaDBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminaDBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApriLibreriaTubiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApriLibreriaScatoleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApriLibreriaFiliToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotificheOperativeToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents ApriLibreriaMorsettiToolStripMenuItem As ToolStripMenuItem

End Class
