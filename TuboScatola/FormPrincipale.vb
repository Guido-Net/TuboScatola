Public Class FormPrincipale

    ' Dichiarazione dell'area MDI
    Private WithEvents AreaMDI As MdiClient

    Private Sub FormPrincipale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cerchiamo l'area grigia (MdiClient) per poterla comandare
        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is MdiClient Then
                AreaMDI = DirectCast(ctl, MdiClient)
                Exit For
            End If
        Next
    End Sub

    ' Questa è la procedura che "incolla" il figlio ai bordi
    Private Sub AdattaFigliMDI()
        If AreaMDI IsNot Nothing Then
            Me.SuspendLayout()
            For Each f As Form In Me.MdiChildren
                ' Forziamo il form in stato normale (non massimizzato)
                f.WindowState = FormWindowState.Normal
                ' Usiamo Bounds per impostare posizione (0,0) e dimensione dell'area grigia contemporaneamente
                f.Bounds = AreaMDI.ClientRectangle
            Next
            Me.ResumeLayout()
        End If
    End Sub

    ' Questo evento gestisce il ridimensionamento mentre muovi il mouse sui bordi del Padre
    Private Sub AreaMDI_Resize(sender As Object, e As EventArgs) Handles AreaMDI.Resize
        If AreaMDI IsNot Nothing Then
            For Each f As Form In Me.MdiChildren
                ' Questo rimuove ogni vincolo e forza il figlio a incollarsi
                f.WindowState = FormWindowState.Normal
                f.Dock = DockStyle.None ' Reset
                f.Bounds = AreaMDI.ClientRectangle ' Lo spalma sull'area
                f.Dock = DockStyle.Fill ' Lo blocca

                ' Forza il TableLayoutPanel interno a ricalcolare tutto
                f.PerformLayout()
            Next
        End If
    End Sub
    ' LA FUNZIONE DEVE STARE QUI!
    Public Sub ForzaAdattamentoFigli()
        If areaMDI IsNot Nothing Then
            Me.SuspendLayout()
            For Each f As Form In Me.MdiChildren
                f.WindowState = FormWindowState.Normal
                f.Dock = DockStyle.None
                f.Bounds = areaMDI.ClientRectangle
                f.Dock = DockStyle.Fill
                f.PerformLayout()
            Next
            Me.ResumeLayout()
        End If
    End Sub
    ' Codice per aprire il Form Figlio
    Private Sub NuovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuovoToolStripMenuItem.Click

        Dim figlio As New FormTuboScatola()
        figlio.MdiParent = Me
        figlio.FormBorderStyle = FormBorderStyle.None

        ' Invece di Dock.Fill, usiamo l'ancoraggio manuale se vogliamo lo scroll perfetto
        figlio.Dock = DockStyle.Top
        figlio.Show()
        AdattaFigliMDI()
        ' 2. "Chiamiamo" la funzione pubblica del figlio
        figlio.PreparaNuovoRecord()
    End Sub
    ' --- MENU LIBRERIE NEL FORM PRINCIPALE ---

    Private Sub ApriLibreriaScatole_Click(sender As Object, e As EventArgs) Handles ApriLibreriaScatoleToolStripMenuItem.Click
        FormScatola.ShowDialog()
    End Sub

    Private Sub ApriLibreriaTubi_Click(sender As Object, e As EventArgs) Handles ApriLibreriaTubiToolStripMenuItem.Click
        FormTubo.ShowDialog()
    End Sub

    Private Sub ApriLibreriaFili_Click(sender As Object, e As EventArgs) Handles ApriLibreriaFiliToolStripMenuItem.Click
        FormFilo.ShowDialog()
    End Sub

    Private Sub ApriLibreriaMorsetti_Click(sender As Object, e As EventArgs) Handles ApriLibreriaMorsettiToolStripMenuItem.Click
        FormMorsetto.ShowDialog()
    End Sub

    '  ' --- APERTURA DEL PROGRAMMA DI CALCOLO ---
    '  Private Sub ApriCalcoloScatole_Click(sender As Object, e As EventArgs) Handles ApriCalcoloScatola.Click
    '      FormTuboScatola.Show() ' Questo apre il cuore del progetto che abbiamo scritto finora
    '  End Sub
End Class