

Public Class FormScatola



    ' Variabile per capire se stiamo creando una nuova scatola (0) o modificandone una esistente
    Private IDCorrente As Integer = 0

    ' Percorso del database
    Private stringaConnessione As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='I:\VisualStudio 2022\Progetto TuboScatola\TuboScatola\TuboScatola\DatabaseImpianti.mdf';Integrated Security=True;Encrypt=False"

    ' Funzione salvagente per trasformare il testo in numero decimale in modo sicuro
    Private Function ConvertiInDecimale(testo As String) As Decimal
        Dim valoreDecimale As Decimal = 0
        ' Se il campo è vuoto, restituisce direttamente 0 per evitare errori
        If String.IsNullOrWhiteSpace(testo) Then Return 0

        ' Sostituiamo eventuale punto con la virgola per la formattazione italiana
        Decimal.TryParse(testo.Replace(".", ","), valoreDecimale)
        Return valoreDecimale
    End Function
    ' Calcolo automatico di Volumi (cm³) e Aree (mm²)
    Private Sub CalcolaDatiInTempoReale(sender As Object, e As EventArgs) Handles LarghezzaScatolaTextBox.TextChanged, AltezzaScatolaTextBox.TextChanged, ProfonditaScatolaTextBox.TextChanged, DivisorioScatolaTextBox.TextChanged, SettLargSSTextBox.TextChanged, SettAltSSTextBox.TextChanged, SettLargLateraliTextBox.TextChanged, SettAltLateraliTextBox.TextChanged

        ' 1. Calcolo Volume Totale (da mm³ a cm³ -> diviso 1000)
        Dim larghezza As Decimal = ConvertiInDecimale(LarghezzaScatolaTextBox.Text)
        Dim altezza As Decimal = ConvertiInDecimale(AltezzaScatolaTextBox.Text)
        Dim profondita As Decimal = ConvertiInDecimale(ProfonditaScatolaTextBox.Text)

        Dim volumeTotale As Decimal = (larghezza * altezza * profondita) / 1000
        VolumeTotaleTextBox.Text = volumeTotale.ToString("N2")

        ' 2. Calcolo Volume per Scomparto (in cm³)
        Dim numeroDivisori As Decimal = ConvertiInDecimale(DivisorioScatolaTextBox.Text)
        If numeroDivisori > 1 Then
            VolumeScompartoTextBox.Text = (volumeTotale / numeroDivisori).ToString("N2")
        Else
            VolumeScompartoTextBox.Text = volumeTotale.ToString("N2")
        End If

        ' 3. Calcolo Area Utile Sopra/Sotto (rimane in mm²)
        Dim larghezzaSopraSotto As Decimal = ConvertiInDecimale(SettLargSSTextBox.Text)
        Dim altezzaSopraSotto As Decimal = ConvertiInDecimale(SettAltSSTextBox.Text)
        AreaUtileSSTextBox.Text = (larghezzaSopraSotto * altezzaSopraSotto).ToString("N0")

        ' 4. Calcolo Area Utile Laterale (rimane in mm²)
        Dim larghezzaLaterale As Decimal = ConvertiInDecimale(SettLargLateraliTextBox.Text)
        Dim altezzaLaterale As Decimal = ConvertiInDecimale(SettAltLateraliTextBox.Text)
        AreaUtileLateraleTextBox.Text = (larghezzaLaterale * altezzaLaterale).ToString("N0")

    End Sub




    ' --- FUNZIONE PER COMINCIARE UN NUOVO INSERIMENTO ---
    Private Sub NuovoScatolaToolStripButton_Click(sender As Object, e As EventArgs) Handles NuovoScatolaToolStripButton.Click
        ' Impostiamo l'ID corrente a 0. Questo dice al pulsante Salva che stiamo creando un record NUOVO
        IDCorrente = 0

        ' Svuotiamo tutti i campi di inserimento per l'utente
        MarcaScatolaTextBox.Clear()
        CodiceScatolaTextBox.Clear()
        TipoPosaComboBox.SelectedIndex = -1 ' Deseleziona l'elemento corrente nella ComboBox

        LarghezzaScatolaTextBox.Clear()
        AltezzaScatolaTextBox.Clear()
        ProfonditaScatolaTextBox.Clear()

        ForiPosterioriTextBox.Clear()
        SettLargSSTextBox.Clear()
        SettAltSSTextBox.Clear()
        SettLargLateraliTextBox.Clear()
        SettAltLateraliTextBox.Clear()
        DivisorioScatolaTextBox.Clear()
        NoteScatolaTextBox.Clear()

        ' Nota: I campi di calcolo (VolumeTotaleTextBox, ecc.) si azzereranno da soli 
        ' in automatico perché le TextBox delle dimensioni sono appena state svuotate,
        ' attivando l'evento CalcolaDatiInTempoReale che abbiamo scritto prima!

        ' Aggiorniamo la barra di stato in basso per dare istruzioni all'utente
        NotificaScatolaToolStripStatusLabel.Text = "Inserimento nuova scatola... Compila i campi e premi Salva."

        ' Portiamo il cursore del mouse direttamente sulla prima casella utile
        CodiceScatolaTextBox.Focus()
    End Sub

    ' Funzione salvagente per trasformare il testo in numero intero in modo sicuro
    Private Function ConvertiInIntero(testo As String) As Integer
        Dim valoreIntero As Integer = 0
        If String.IsNullOrWhiteSpace(testo) Then Return 0
        Integer.TryParse(testo, valoreIntero)
        Return valoreIntero
    End Function

    ' --- PROCEDURA DI SALVATAGGIO ---
    Private Sub SalvaScatolaToolStripButton_Click(sender As Object, e As EventArgs) Handles SalvaScatolaToolStripButton.Click
        ' Controllo di sicurezza: il codice scatola è obbligatorio
        If String.IsNullOrWhiteSpace(CodiceScatolaTextBox.Text) Then
            MessageBox.Show("Il Codice Scatola è obbligatorio per salvare il record.", "Dati mancanti", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using connessione As New Microsoft.Data.SqlClient.SqlConnection(stringaConnessione)
                connessione.Open()
                Dim querySql As String

                ' SEZIONE QUERY AGGIORNATA (Da inserire nel tuo blocco Salva)
                If IDCorrente = 0 Then
                    querySql = "INSERT INTO LibScatole (Marca, CodiceScatola, Posa, Larghezza, Altezza, Profondita, ForiPosteriori, SettoreLargSopraSotto, SettoreAltSopraSotto, SettoreLargLaterali, SettoreAltLaterali, DivisorioScatola, Note, VolumeTotale, VolumeScomparto, AreaUtileSS, AreaUtileLaterale) " &
                               "VALUES (@marca, @codice, @tipo, @larg, @alt, @prof, @fori, @largSS, @altSS, @largLat, @altLat, @divisori, @note, @volTot, @volScomp, @areaSS, @areaLat)"
                Else
                    querySql = "UPDATE LibScatole SET Marca=@marca, CodiceScatola=@codice, Posa=@tipo, Larghezza=@larg, Altezza=@alt, Profondita=@prof, ForiPosteriori=@fori, SettoreLargSopraSotto=@largSS, SettoreAltSopraSotto=@altSS, SettoreLargLaterali=@largLat, SettoreAltLaterali=@altLat, DivisorioScatola=@divisori, Note=@note, VolumeTotale=@volTot, VolumeScomparto=@volScomp, AreaUtileSS=@areaSS, AreaUtileLaterale=@areaLat " &
                               "WHERE Id=@id"
                End If

                Using comando As New Microsoft.Data.SqlClient.SqlCommand(querySql, connessione)
                    ' Passiamo i parametri puliti dalle TextBox
                    comando.Parameters.AddWithValue("@marca", MarcaScatolaTextBox.Text.Trim())
                    comando.Parameters.AddWithValue("@codice", CodiceScatolaTextBox.Text.Trim())
                    comando.Parameters.AddWithValue("@tipo", TipoPosaComboBox.Text.Trim())

                    comando.Parameters.AddWithValue("@larg", ConvertiInDecimale(LarghezzaScatolaTextBox.Text))
                    comando.Parameters.AddWithValue("@alt", ConvertiInDecimale(AltezzaScatolaTextBox.Text))
                    comando.Parameters.AddWithValue("@prof", ConvertiInDecimale(ProfonditaScatolaTextBox.Text))

                    comando.Parameters.AddWithValue("@fori", ConvertiInIntero(ForiPosterioriTextBox.Text))
                    comando.Parameters.AddWithValue("@largSS", ConvertiInIntero(SettLargSSTextBox.Text))
                    comando.Parameters.AddWithValue("@altSS", ConvertiInIntero(SettAltSSTextBox.Text))
                    comando.Parameters.AddWithValue("@largLat", ConvertiInIntero(SettLargLateraliTextBox.Text))
                    comando.Parameters.AddWithValue("@altLat", ConvertiInIntero(SettAltLateraliTextBox.Text))
                    comando.Parameters.AddWithValue("@divisori", ConvertiInIntero(DivisorioScatolaTextBox.Text))

                    comando.Parameters.AddWithValue("@note", NoteScatolaTextBox.Text.Trim())

                    ' Passiamo i dati di calcolo
                    comando.Parameters.AddWithValue("@volTot", ConvertiInDecimale(VolumeTotaleTextBox.Text))
                    comando.Parameters.AddWithValue("@volScomp", ConvertiInDecimale(VolumeScompartoTextBox.Text))
                    comando.Parameters.AddWithValue("@areaSS", ConvertiInDecimale(AreaUtileSSTextBox.Text))
                    comando.Parameters.AddWithValue("@areaLat", ConvertiInDecimale(AreaUtileLateraleTextBox.Text))

                    If IDCorrente <> 0 Then
                        comando.Parameters.AddWithValue("@id", IDCorrente)
                    End If

                    comando.ExecuteNonQuery()
                End Using
            End Using

            ' Notifica di successo nella barra in basso
            NotificaScatolaToolStripStatusLabel.Text = "Scatola '" & CodiceScatolaTextBox.Text & "' salvata con successo alle " & DateTime.Now.ToString("HH:mm:ss")

            ' Dopo aver salvato, ricarichiamo la griglia per vedere il nuovo dato
            CaricaDatiGriglia()

        Catch ex As Exception
            MessageBox.Show("Errore durante il salvataggio nel database: " & vbCrLf & ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- PROCEDURA PER CARICARE LA DATAGRIDVIEW ---
    Private Sub CaricaDatiGriglia()
        Try
            Using connessione As New Microsoft.Data.SqlClient.SqlConnection(stringaConnessione)
                Dim querySql As String = "SELECT * FROM LibScatole ORDER BY Marca, CodiceScatola"
                Dim adattatore As New Microsoft.Data.SqlClient.SqlDataAdapter(querySql, connessione)
                Dim tabellaDati As New DataTable()
                adattatore.Fill(tabellaDati)
                '--------------------------------------------
                ' Questo messaggio ti dirà quante scatole trova nel database
                'Debug
                ' MessageBox.Show("Ho trovato " & tabellaDati.Rows.Count & " scatole nel database.")
                '--------------------------------------------
                ' Dopo aver caricato i dati nella tabellaDati...
                LibScatolaDataGridView.DataSource = tabellaDati

                ' FORZARE LA CREAZIONE DELLE COLONNE NELLA DGV
                LibScatolaDataGridView.AutoGenerateColumns = True

                ' Nascondiamo la colonna Id tecnica perché all'utente non serve vederla
                If LibScatolaDataGridView.Columns.Contains("Id") Then
                    LibScatolaDataGridView.Columns("Id").Visible = False
                End If
            End Using
        Catch ex As Exception
            NotificaScatolaToolStripStatusLabel.Text = "Errore caricamento griglia: " & ex.Message
        End Try
    End Sub

    ' Per far apparire i dati appena si apre il form
    Private Sub FormScatola_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CaricaDatiGriglia()
        NotificaScatolaToolStripStatusLabel.Text = "Pronto."
    End Sub

    ' --- CARICAMENTO DEI DATI DALLA GRIGLIA AL FORM (AGGIORNATO) ---
    Private Sub LibScatolaDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles LibScatolaDataGridView.CellClick
        ' Verifichiamo che l'utente abbia cliccato su una riga valida
        If e.RowIndex >= 0 Then
            Dim rigaSelezionata As DataGridViewRow = LibScatolaDataGridView.Rows(e.RowIndex)

            ' Recuperiamo l'ID univoco
            IDCorrente = Convert.ToInt32(rigaSelezionata.Cells("Id").Value)

            ' Distribuiamo i dati della riga nei rispettivi campi del form
            ' Nota: i nomi tra virgolette devono corrispondere esattamente ai nomi delle colonne della tabella DB
            MarcaScatolaTextBox.Text = If(rigaSelezionata.Cells("Marca").Value?.ToString(), "")
            CodiceScatolaTextBox.Text = If(rigaSelezionata.Cells("CodiceScatola").Value?.ToString(), "")
            TipoPosaComboBox.Text = If(rigaSelezionata.Cells("Posa").Value?.ToString(), "")

            LarghezzaScatolaTextBox.Text = If(rigaSelezionata.Cells("Larghezza").Value?.ToString(), "")
            AltezzaScatolaTextBox.Text = If(rigaSelezionata.Cells("Altezza").Value?.ToString(), "")
            ProfonditaScatolaTextBox.Text = If(rigaSelezionata.Cells("Profondita").Value?.ToString(), "")

            ForiPosterioriTextBox.Text = If(rigaSelezionata.Cells("ForiPosteriori").Value?.ToString(), "")
            SettLargSSTextBox.Text = If(rigaSelezionata.Cells("SettoreLargSopraSotto").Value?.ToString(), "")
            SettAltSSTextBox.Text = If(rigaSelezionata.Cells("SettoreAltSopraSotto").Value?.ToString(), "")
            SettLargLateraliTextBox.Text = If(rigaSelezionata.Cells("SettoreLargLaterali").Value?.ToString(), "")
            SettAltLateraliTextBox.Text = If(rigaSelezionata.Cells("SettoreAltLaterali").Value?.ToString(), "")
            DivisorioScatolaTextBox.Text = If(rigaSelezionata.Cells("DivisorioScatola").Value?.ToString(), "")

            NoteScatolaTextBox.Text = If(rigaSelezionata.Cells("Note").Value?.ToString(), "")

            ' Aggiorniamo la barra di stato
            NotificaScatolaToolStripStatusLabel.Text = "Scatola selezionata: " & CodiceScatolaTextBox.Text
        End If
    End Sub

    ' --- PROCEDURA DI ELIMINAZIONE ---
    Private Sub EliminaScatolaToolStripButton_Click(sender As Object, e As EventArgs) Handles EliminaScatolaToolStripButton.Click
        ' 1. Controllo di sicurezza: dobbiamo avere un ID valido per sapere cosa eliminare
        If IDCorrente = 0 Then
            MessageBox.Show("Seleziona una scatola dalla griglia prima di eliminarla.", "Nessuna selezione", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ' 2. Chiediamo conferma all'utente (non si cancella mai senza chiedere!)
        Dim conferma As DialogResult = MessageBox.Show("Sei sicuro di voler eliminare definitivamente la scatola '" & CodiceScatolaTextBox.Text & "'?", "Conferma eliminazione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If conferma = DialogResult.Yes Then
            Try
                Using connessione As New Microsoft.Data.SqlClient.SqlConnection(stringaConnessione)
                    connessione.Open()
                    Dim querySql As String = "DELETE FROM LibScatole WHERE Id = @id"

                    Using comando As New Microsoft.Data.SqlClient.SqlCommand(querySql, connessione)
                        comando.Parameters.AddWithValue("@id", IDCorrente)
                        comando.ExecuteNonQuery()
                    End Using
                End Using

                ' 3. Pulizia post-eliminazione
                NotificaScatolaToolStripStatusLabel.Text = "Scatola eliminata con successo."
                IDCorrente = 0 ' Resettiamo l'ID perché il record non esiste più

                ' Svuotiamo il form per evitare confusione
                ' (Puoi richiamare la stessa logica del tasto Nuovo)
                NuovoScatolaToolStripButton.PerformClick()

                ' Aggiorniamo la griglia
                CaricaDatiGriglia()

            Catch ex As Exception
                MessageBox.Show("Errore durante l'eliminazione: " & vbCrLf & ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    ' Da inserire dentro FormScatola.vb
    Public Sub FiltraGriglia(colonna As String, valore As String)
        ' Assicuriamoci che la griglia abbia dati
        If LibScatolaDataGridView.DataSource IsNot Nothing Then
            Dim dt As DataTable = CType(LibScatolaDataGridView.DataSource, DataTable)

            If Not String.IsNullOrEmpty(colonna) AndAlso Not String.IsNullOrEmpty(valore) Then
                ' Applica il filtro
                dt.DefaultView.RowFilter = String.Format("{0} LIKE '%{1}%'", colonna, valore)
            Else
                ' Resetta il filtro (annulla la ricerca)
                dt.DefaultView.RowFilter = ""
            End If
            ' Se il filtro non è vuoto, il bottone si attiva. Altrimenti si disattiva.
            AnnullaRicercaScatolaToolStripButton.Enabled = (dt.DefaultView.RowFilter <> "")
        End If
    End Sub

    ' --- APERTURA DEL FORM DI RICERCA ---
    Private Sub RicercaScatolaToolStripButton_Click(sender As Object, e As EventArgs) Handles RicercaScatolaToolStripButton.Click
        ' Creiamo una nuova istanza del form di ricerca
        Dim frmCerca As New FormCerca()

        ' Lo mostriamo come finestra di dialogo (il resto del form resta bloccato finché non chiudi la ricerca)
        frmCerca.ShowDialog()
    End Sub

    ' --- RIPRISTINO DELLA GRIGLIA (ANNULLA RICERCA) ---
    Private Sub AnnullaRicercaScatolaToolStripButton_Click(sender As Object, e As EventArgs) Handles AnnullaRicercaScatolaToolStripButton.Click
        ' Richiamiamo la funzione che abbiamo già creato per filtrare, 
        ' passandogli stringhe vuote per indicare che non c'è più alcun filtro.
        FiltraGriglia("", "")

        ' Opzionale: Aggiorniamo la barra di stato per avvisare che la ricerca è stata rimossa
        NotificaScatolaToolStripStatusLabel.Text = "Tutte le scatole visualizzate."
    End Sub

    Private Function CreaTabellaDatiPerStampa() As DataTable
        Dim dt As New DataTable()

        ' Devi aggiungere qui TUTTE le colonne che hai trascinato nel report
        ' I nomi tra virgolette DEVONO essere identici a quelli nel Dati Report del .rdlc
        dt.Columns.Add("Marca")
        dt.Columns.Add("Modello")
        dt.Columns.Add("Larghezza")
        dt.Columns.Add("Altezza")
        dt.Columns.Add("Profondita")
        ' ... aggiungi tutte le altre ...

        ' Ora riempiamo la riga con i dati che hai nelle TextBox/ComboBox a video
        dt.Rows.Add(MarcaScatolaTextBox.Text,
                    CodiceScatolaTextBox.Text,
                    LarghezzaScatolaTextBox.Text,
                    AltezzaScatolaTextBox.Text,
                    ProfonditaScatolaTextBox.Text)

        Return dt
    End Function

    Private Sub StampaDaSelezioneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StampaDaSelezioneToolStripMenuItem.Click
        ' 1. Crea il form
        Dim frm As New FormStampa()
        frm.ModalitaStampa = "SINGOLO" ' <--- Impostiamo il report normale

        ' 2. Verifica che ci sia almeno una riga selezionata
        If LibScatolaDataGridView.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleziona una riga nella tabella prima di stampare.", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' 3. Prendi la riga selezionata dalla griglia
        Dim dr As DataRow = CType(LibScatolaDataGridView.SelectedRows(0).DataBoundItem, DataRowView).Row

        ' 4. Crea una tabella con la STESSA struttura, ma con SOLO quella riga
        Dim dt As DataTable = dr.Table.Clone()
        dt.ImportRow(dr)

        ' 5. Passa i dati e apri
        frm.DatiDaStampare = dt
        frm.ShowDialog()
    End Sub

    Private Sub StampaReportElementiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StampaReportElementiToolStripMenuItem.Click
        ' 1. Crea il form
        Dim frm As New FormStampa()
        frm.ModalitaStampa = "GRUPPI" ' <--- Impostiamo il report raggruppato

        ' 2. Verifica che ci sia un DataSource
        If LibScatolaDataGridView.DataSource Is Nothing Then Return

        ' 3. Estrazione sicura della DataTable
        Dim ds As Object = LibScatolaDataGridView.DataSource

        If TypeOf ds Is DataTable Then
            ' Caso A: Il DataSource è direttamente una DataTable
            frm.DatiDaStampare = DirectCast(ds, DataTable)

        ElseIf TypeOf ds Is BindingSource Then
            ' Caso B: Il DataSource è un BindingSource (molto comune!)
            ' Dobbiamo pescare la tabella dentro la proprietà .DataSource del BindingSource
            Dim bs As BindingSource = DirectCast(ds, BindingSource)
            frm.DatiDaStampare = DirectCast(bs.DataSource, DataTable)
        End If

        ' 4. Apri
        frm.ShowDialog()
    End Sub
End Class