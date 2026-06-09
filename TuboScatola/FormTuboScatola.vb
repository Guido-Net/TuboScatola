Imports System.ComponentModel
Imports Microsoft.Data.SqlClient ' <--- Usiamo il nuovo pacchetto

Public Class FormTuboScatola
    ' --- Variabili di Stato del Form ---
    ' Variabile per l'Anagrafica (Cliente)
    Private isNuovoRecord As Boolean = False

    ' Variabile per la Scatola (che è legata all'Anagrafica)
    Private currentScatolaID As Integer = 0
    Private isResetting As Boolean = False
    Private diametroFiloCorrente As Double = 0
    ' 1. Variabile di stato (in cima al codice del Form)
    '  Private isNuovoRecord As Boolean = False
    ' ----------- Nuova Anagrafica. ------------
    Public Sub PreparaNuovoRecord()
        isNuovoRecord = True
        currentScatolaID = 0 ' <--- Resettiamo anche l'ID della scatola per sicurezza

        ' Sblocchiamo il CodiceCliente
        Me.CodiceClienteTextBox.ReadOnly = False

        ' Pulizia (riutilizziamo la logica di reset)
        Me.CodiceClienteTextBox.Clear()
        Me.NominativoTextBox.Clear()
        CapTextBox.Clear()
        CittaTextBox.Clear()
        IndirizzoTextBox.Clear()
        TelefonoTextBox.Clear()
        EmailTextBox.Clear()
        TipoImpiantoTextBox.Clear()
        NoteAnagraficaTextBox.Clear()

        Me.CodiceClienteTextBox.ReadOnly = False
        Me.CodiceClienteTextBox.Clear()

        ' Focus
        Me.CodiceClienteTextBox.Focus()

    End Sub
    ' Da chiamare dopo il salvataggio dell'anagrafica o quando si apre un cliente esistente
    Private Sub CaricaScatoleCliente()
        If String.IsNullOrEmpty(CodiceClienteTextBox.Text) Then Exit Sub
        Dim connString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='I:\VisualStudio 2022\Progetto TuboScatola\TuboScatola\TuboScatola\DatabaseImpianti.mdf';Integrated Security=True;Encrypt=False"
        'Dim connString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabaseImpianti.mdf;Integrated Security=True"
        ' Prendiamo tutto (*) per avere i dati tecnici pronti per il CellClick
        Dim sql As String = "SELECT * FROM Scatole WHERE CodiceCliente_FK = @cod"

        Using conn As New Microsoft.Data.SqlClient.SqlConnection(connString)
            Dim cmd As New Microsoft.Data.SqlClient.SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@cod", CodiceClienteTextBox.Text)

            Dim da As New Microsoft.Data.SqlClient.SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            DgwScatole.DataSource = dt

            ' --- Pulizia estetica delle colonne ---
            If DgwScatole.Columns.Count > 0 Then
                ' Nascondiamo le colonne tecniche che non servono all'occhio dell'utente
                Dim colonneInvisibili() As String = {"ScatolaID", "CodiceCliente_FK", "MargineScatola", "Note",
                                                "LarghezzaScatola", "AltezzaScatola", "ProfonditaScatola",
                                                "PreforaturaPosteriore", "SettoriLaterali", "SettoriSopraSotto"}

                For Each col In colonneInvisibili
                    If DgwScatole.Columns.Contains(col) Then DgwScatole.Columns(col).Visible = False
                Next

                ' Rinominiano le colonne visibili
                DgwScatole.Columns("Locale").HeaderText = "Locale"
                DgwScatole.Columns("MarcaScatola").HeaderText = "Marca"
                DgwScatole.Columns("ModelloScatola").HeaderText = "Modello"
                DgwScatole.Columns("EsitoScatola").HeaderText = "Verifica"
            End If
        End Using
    End Sub
    Private Sub CaricaMarcheScatole()
        ' Stringa aggiornata con Encrypt=False
        Dim connString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='I:\VisualStudio 2022\Progetto TuboScatola\TuboScatola\TuboScatola\DatabaseImpianti.mdf';Integrated Security=True;Encrypt=False"

        Dim query As String = "SELECT DISTINCT Marca FROM LibScatole ORDER BY Marca"

        Using conn As New SqlConnection(connString)
            Dim cmd As New SqlCommand(query, conn)
            Try
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                MarcaScatolaComboBox.Items.Clear()
                While reader.Read()
                    MarcaScatolaComboBox.Items.Add(reader("Marca").ToString())
                End While
                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Errore caricamento: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub CaricaMarcheTubi()
        Dim connString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='I:\VisualStudio 2022\Progetto TuboScatola\TuboScatola\TuboScatola\DatabaseImpianti.mdf';Integrated Security=True;Encrypt=False"
        Dim query As String = "SELECT DISTINCT Marca FROM LibTubi ORDER BY Marca"

        Using conn As New Microsoft.Data.SqlClient.SqlConnection(connString)
            Dim cmd As New Microsoft.Data.SqlClient.SqlCommand(query, conn)
            Try
                conn.Open()
                Dim reader = cmd.ExecuteReader()

                MarcaTuboComboBox.Items.Clear() ' Nome corretto
                While reader.Read()
                    MarcaTuboComboBox.Items.Add(reader("Marca").ToString())
                End While
            Catch ex As Exception
                InviaNotifica("Errore database: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub CaricaDatiInizialiFilo()

        isResetting = True ' Blocca gli eventi durante il caricamento

        Dim connString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""I:\VisualStudio 2022\Progetto TuboScatola\TuboScatola\TuboScatola\DatabaseImpianti.mdf"";Integrated Security=True;Encrypt=False"

        Using conn As New Microsoft.Data.SqlClient.SqlConnection(connString)
            Try
                conn.Open()

                ' 1. Carichiamo le Sezioni (es. 1.5, 2.5, 4) senza duplicati
                Dim querySezioni As String = "SELECT DISTINCT Sezione FROM LibFilo ORDER BY Sezione"
                Dim cmdSez As New Microsoft.Data.SqlClient.SqlCommand(querySezioni, conn)
                Dim readerSez = cmdSez.ExecuteReader()

                SezioneFiloComboBox.Items.Clear()
                While readerSez.Read()
                    SezioneFiloComboBox.Items.Add(readerSez("Sezione"))
                End While
                readerSez.Close() ' Fondamentale chiudere il reader prima di usarne un altro

                ' 2. Carichiamo i Colori senza duplicati
                Dim queryColori As String = "SELECT DISTINCT Colore FROM LibFilo ORDER BY Colore"
                Dim cmdCol As New Microsoft.Data.SqlClient.SqlCommand(queryColori, conn)
                Dim readerCol = cmdCol.ExecuteReader()

                ColoreFiloComboBox.Items.Clear()
                While readerCol.Read()
                    ColoreFiloComboBox.Items.Add(readerCol("Colore").ToString())
                End While

                readerCol.Close()


                ' --- RESET VISIVO ---
                ' Impostiamo a -1 per non avere nulla di selezionato all'avvio
                SezioneFiloComboBox.SelectedIndex = -1
                ColoreFiloComboBox.SelectedIndex = -1

                ' Opzionale: puliamo anche il testo visibile per sicurezza
                SezioneFiloComboBox.Text = ""
                ColoreFiloComboBox.Text = ""
                isResetting = False ' Sblocca gli eventi solo ora che tutto è pulito
                InviaNotifica("Pronto. Seleziona Sezione e Colore del filo.")

                'InviaNotifica("Libreria fili caricata correttamente.")

            Catch ex As Exception
                InviaNotifica("Errore caricamento iniziali: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub CaricaMarcheMorsetti()
        Dim connString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""I:\VisualStudio 2022\Progetto TuboScatola\TuboScatola\TuboScatola\DatabaseImpianti.mdf"";Integrated Security=True;Encrypt=False"

        Using conn As New Microsoft.Data.SqlClient.SqlConnection(connString)
            ' Usiamo DISTINCT per prendere solo le marche uniche
            Dim query As String = "SELECT DISTINCT MarcaMorsetto FROM LibMorsetto ORDER BY MarcaMorsetto"
            Dim cmd As New Microsoft.Data.SqlClient.SqlCommand(query, conn)

            Try
                conn.Open()
                Dim reader = cmd.ExecuteReader()

                MarcaMorsettoComboBox.Items.Clear()

                Dim trovati As Integer = 0
                While reader.Read()
                    MarcaMorsettoComboBox.Items.Add(reader("MarcaMorsetto").ToString())
                    trovati += 1
                End While

                If trovati = 0 Then
                    MessageBox.Show("Attenzione: La tabella LibMorsetto sembra vuota!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show("Errore durante il caricamento marche: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub InviaNotifica(messaggio As String)
        ' 1. Messaggio sul FormPrincipale (Padre)
        If Me.MdiParent IsNot Nothing AndAlso TypeOf Me.MdiParent Is FormPrincipale Then
            Dim padre = DirectCast(Me.MdiParent, FormPrincipale)
            ' Usiamo il nome esatto della tua label nel FormPrincipale
            padre.NotificheOperativeToolStripStatusLabel.Text = messaggio
        End If
    End Sub
    Private Sub FormTuboScatola_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CaricaMarcheScatole() ' Carica i dati Marche delle scatole
        CaricaMarcheTubi() ' Carica i dati Marche dei tubi
        CaricaDatiInizialiFilo() ' Richiama la procedura che abbiamo appena scritto
        CaricaMarcheMorsetti() ' Devi richiamare qui la funzione per caricare le marche

        ' Codice MDI Parent...
        If Me.MdiParent IsNot Nothing Then
            DirectCast(Me.MdiParent, FormPrincipale).ForzaAdattamentoFigli()
        End If

    End Sub

    '---------------------------------------Scatola ---------------------
    ' Quando l'utente clicca sulla

    Private Sub LocaleScatolaTextBox_Enter(sender As Object, e As EventArgs) Handles LocaleScatolaTextBox.Enter
        InviaNotifica("Specifica a quale locale fa parte questa scatola..")
    End Sub
    Private Sub MarcaScatolaComboBox_Enter(sender As Object, e As EventArgs) Handles MarcaScatolaComboBox.Enter
        InviaNotifica("Seleziona la marca della scatola dal database libreria.")
    End Sub

    Private Sub MargineSicurezzaComboBox_Enter(sender As Object, e As EventArgs) Handles MargineSicurezzaComboBox.Enter
        InviaNotifica("Seleziona la '%' di margine di sicurezza per questa scatola.")
    End Sub

    Private Sub NoteScatolaTextBox_Enter(sender As Object, e As EventArgs) Handles NoteScatolaTextBox.Enter
        InviaNotifica("Inserisci eventuali annotazioni tecniche per questa scatola.")
    End Sub
    '---------------------------------------Tubo ------------------------

    ' Quando l'utente clicca sulla Marca
    Private Sub MarcaTuboComboBox_Enter(sender As Object, e As EventArgs) Handles MarcaTuboComboBox.Enter
        InviaNotifica("Seleziona la marca del tubo dal database libreria.")
    End Sub

    ' Quando l'utente clicca sul Tipo Tubo (che è una ComboBox)
    Private Sub TipoTuboComboBox_Enter(sender As Object, e As EventArgs) Handles TipoTuboComboBox.Enter
        InviaNotifica("Specifica il modello tecnico (es. Corrugato FK, Rigido RK, ecc.).")
    End Sub

    ' Quando l'utente clicca sul Diametro Esterno
    Private Sub DiametroEstComboBox_Enter(sender As Object, e As EventArgs) Handles DiametroEstComboBox.Enter
        InviaNotifica("Seleziona il diametro esterno nominale (mm).")
    End Sub

    ' Quando l'utente clicca sulle Note
    Private Sub NoteTuboTextBox_Enter(sender As Object, e As EventArgs) Handles NoteTuboTextBox.Enter
        InviaNotifica("Inserisci eventuali annotazioni tecniche per questo tubo.")
    End Sub

    Private Sub NomeTuboTextBox_Enter(sender As Object, e As EventArgs) Handles NomeTuboTextBox.Enter
        InviaNotifica("Specifica l'appartenenza d'impianto a cui fa parte il tubo..")
    End Sub

    Private Sub LatoIngressoComboBox_Enter(sender As Object, e As EventArgs) Handles LatoIngressoComboBox.Enter
        InviaNotifica("Specifica il lato di inserimento nella scatola..")
    End Sub

    ' Reset quando si esce dai campi
    Private Sub Campi_Leave(sender As Object, e As EventArgs)

        InviaNotifica("Pronto.")
    End Sub

    Private Sub MarcaTuboComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MarcaTuboComboBox.SelectedIndexChanged
        If MarcaTuboComboBox.SelectedItem Is Nothing Then Exit Sub

        ' --- INIZIO RESET SICURO ---
        isResetting = True ' Blocchiamo gli altri eventi

        TipoTuboComboBox.Items.Clear()
        DiametroEstComboBox.Items.Clear()
        TipoTuboComboBox.SelectedIndex = -1
        DiametroEstComboBox.SelectedIndex = -1
        TipoTuboComboBox.Text = "" ' Forza la pulizia visiva
        DiametroIntTuboTextBox.Clear()

        isResetting = False ' Sblocchiamo gli eventi
        ' --- FINE RESET SICURO ---

        Dim connString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='I:\VisualStudio 2022\Progetto TuboScatola\TuboScatola\TuboScatola\DatabaseImpianti.mdf';Integrated Security=True;Encrypt=False"
        Dim query = "SELECT DISTINCT TipoTubo FROM LibTubi WHERE Marca = @marca ORDER BY TipoTubo"

        Using conn As New SqlConnection(connString)
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@marca", MarcaTuboComboBox.SelectedItem.ToString)
            Try
                conn.Open()
                Dim reader = cmd.ExecuteReader
                While reader.Read
                    TipoTuboComboBox.Items.Add(reader("TipoTubo").ToString)
                End While
            Catch ex As Exception
                InviaNotifica("Errore caricamento tipi: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub TipoTuboComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TipoTuboComboBox.SelectedIndexChanged
        If TipoTuboComboBox.SelectedItem Is Nothing Then Exit Sub
        ' Se stiamo resettando, non fare nulla e esci!
        If isResetting Then Exit Sub
        Dim connString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='I:\VisualStudio 2022\Progetto TuboScatola\TuboScatola\TuboScatola\DatabaseImpianti.mdf';Integrated Security=True;Encrypt=False"
        ' Cerchiamo i diametri esterni per quella marca e quel tipo
        Dim query = "SELECT DISTINCT DiametroEst FROM LibTubi WHERE Marca = @marca AND TipoTubo = @tipo ORDER BY DiametroEst"

        Using conn As New SqlConnection(connString)
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@marca", MarcaTuboComboBox.SelectedItem.ToString)
            cmd.Parameters.AddWithValue("@tipo", TipoTuboComboBox.SelectedItem.ToString)

            Try
                conn.Open()
                Dim reader = cmd.ExecuteReader
                DiametroEstComboBox.Items.Clear()

                While reader.Read
                    DiametroEstComboBox.Items.Add(reader("DiametroEst").ToString)
                End While
            Catch ex As Exception
                InviaNotifica("Errore caricamento diametri: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub DiametroEstComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DiametroEstComboBox.SelectedIndexChanged
        If DiametroEstComboBox.SelectedItem Is Nothing Then Exit Sub
        ' Se stiamo resettando, non fare nulla e esci!
        If isResetting Then Exit Sub
        Dim connString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='I:\VisualStudio 2022\Progetto TuboScatola\TuboScatola\TuboScatola\DatabaseImpianti.mdf';Integrated Security=True;Encrypt=False"
        Dim query = "SELECT DiametroInt FROM LibTubi WHERE Marca = @marca AND TipoTubo = @tipo AND DiametroEst = @est"

        Using conn As New SqlConnection(connString)
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@marca", MarcaTuboComboBox.SelectedItem.ToString)
            cmd.Parameters.AddWithValue("@tipo", TipoTuboComboBox.SelectedItem.ToString)
            cmd.Parameters.AddWithValue("@est", DiametroEstComboBox.SelectedItem.ToString)

            Try
                conn.Open()
                Dim risultato = cmd.ExecuteScalar ' Recupera il singolo valore del diametro interno
                If risultato IsNot Nothing Then
                    DiametroIntTuboTextBox.Text = risultato.ToString
                    InviaNotifica("Dati tecnici caricati. Diametro interno: " & risultato.ToString & " mm")
                End If
            Catch ex As Exception
                InviaNotifica("Errore recupero diametro interno: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub AggiornaDatiTecniciFilo()
        If isResetting Then Exit Sub

        ' 1. CONTROLLO INCROCIATO: Se uno dei due manca, svuoto e esco
        If ColoreFiloComboBox.SelectedIndex = -1 OrElse SezioneFiloComboBox.SelectedIndex = -1 Then
            NoteColoreFiloLabel.Text = ""
            Exit Sub
        End If

        ' 2. ESECUZIONE QUERY
        Dim connString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""I:\VisualStudio 2022\Progetto TuboScatola\TuboScatola\TuboScatola\DatabaseImpianti.mdf"";Integrated Security=True;Encrypt=False"
        Dim query As String = "SELECT NoteColore, DiametroEsterno FROM LibFilo WHERE Sezione = @sez AND Colore = @col"

        Using conn As New Microsoft.Data.SqlClient.SqlConnection(connString)
            Dim cmd As New Microsoft.Data.SqlClient.SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@sez", SezioneFiloComboBox.SelectedItem)
            cmd.Parameters.AddWithValue("@col", ColoreFiloComboBox.SelectedItem.ToString())

            Try
                conn.Open()
                Dim reader = cmd.ExecuteReader()

                If reader.Read() Then
                    NoteColoreFiloLabel.Text = reader("NoteColore").ToString()

                    ' SALVATAGGIO NELLA VARIABILE GLOBALE
                    ' Invece di "Dim diametro", usiamo quella dichiarata sopra
                    diametroFiloCorrente = Convert.ToDouble(reader("DiametroEsterno"))

                    InviaNotifica("Dati tecnici caricati. Diametro: " & diametroFiloCorrente & " mm")
                Else
                    NoteColoreFiloLabel.Text = "Nessuna nota disponibile."
                    diametroFiloCorrente = 0 ' Resettiamo se non trova nulla
                End If
            Catch ex As Exception
                MessageBox.Show("Errore: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub ColoreFiloComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ColoreFiloComboBox.SelectedIndexChanged
        AggiornaDatiTecniciFilo()
    End Sub

    Private Sub SezioneFiloComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SezioneFiloComboBox.SelectedIndexChanged
        AggiornaDatiTecniciFilo()
    End Sub
    Private Sub ResettaCampiMorsetto()
        ' Forza il blocco degli eventi
        isResetting = True

        ' 1. Svuota la lista dei tipi
        TipoMorsettoComboBox.Items.Clear()

        ' 2. Forza esplicitamente l'indice a -1 (che significa "nessuna selezione")
        TipoMorsettoComboBox.SelectedIndex = -1

        ' 3. Svuota anche la casella di testo visiva
        TipoMorsettoComboBox.Text = ""

        ' 4. Resetta i campi correlati
        SuperficieOccupataTextBox.Clear()
        NoteMorsettoTextBox.Clear()

        ' Rilascia il blocco
        isResetting = False
    End Sub
    Private Sub MarcaMorsettoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MarcaMorsettoComboBox.SelectedIndexChanged
        ' Se stiamo resettando o non c'è una marca valida, usciamo
        If isResetting OrElse MarcaMorsettoComboBox.SelectedIndex = -1 Then Exit Sub

        ' CHIAMIAMO IL RESET PROFONDO
        ResettaCampiMorsetto()

        ' Ora carichiamo i nuovi dati
        Dim connString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""I:\VisualStudio 2022\Progetto TuboScatola\TuboScatola\TuboScatola\DatabaseImpianti.mdf"";Integrated Security=True;Encrypt=False"
        Dim query = "SELECT DISTINCT TipoMorsetto FROM LibMorsetto WHERE MarcaMorsetto = @marca ORDER BY TipoMorsetto"

        Using conn As New SqlConnection(connString)
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@marca", MarcaMorsettoComboBox.SelectedItem.ToString)

            Try
                conn.Open()
                Dim reader = cmd.ExecuteReader

                isResetting = True ' Blocca durante il caricamento
                While reader.Read
                    TipoMorsettoComboBox.Items.Add(reader("TipoMorsetto").ToString)
                End While
                isResetting = False

            Catch ex As Exception
                MessageBox.Show("Errore caricamento tipi: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub TipoMorsettoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TipoMorsettoComboBox.SelectedIndexChanged
        If isResetting OrElse TipoMorsettoComboBox.SelectedIndex = -1 Then Exit Sub

        Dim connString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""I:\VisualStudio 2022\Progetto TuboScatola\TuboScatola\TuboScatola\DatabaseImpianti.mdf"";Integrated Security=True;Encrypt=False"
        ' Qui filtriamo per Marca E Tipo
        Dim query = "SELECT SuperficieOccupata, NoteMorsetto FROM LibMorsetto WHERE MarcaMorsetto = @marca AND TipoMorsetto = @tipo"

        Using conn As New SqlConnection(connString)
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@marca", MarcaMorsettoComboBox.SelectedItem.ToString)
            cmd.Parameters.AddWithValue("@tipo", TipoMorsettoComboBox.SelectedItem.ToString)

            Try
                conn.Open()
                Dim reader = cmd.ExecuteReader
                If reader.Read Then
                    SuperficieOccupataTextBox.Text = reader("SuperficieOccupata").ToString
                    NoteMorsettoTextBox.Text = reader("NoteMorsetto").ToString
                End If
            Catch ex As Exception
                MessageBox.Show("Errore dati morsetto: " & ex.Message)
            End Try
        End Using
    End Sub

    '----- Routine Salvataggio Anagrafica ----------------

    Private Sub EseguiComando(sql As String, conn As Microsoft.Data.SqlClient.SqlConnection)
        Using cmd As New Microsoft.Data.SqlClient.SqlCommand(sql, conn)
            ' Aggiungiamo i parametri una sola volta qui dentro
            cmd.Parameters.AddWithValue("@cod", CodiceClienteTextBox.Text)
            cmd.Parameters.AddWithValue("@nom", NominativoTextBox.Text)
            cmd.Parameters.AddWithValue("@cap", CapTextBox.Text)
            cmd.Parameters.AddWithValue("@citt", CittaTextBox.Text)
            cmd.Parameters.AddWithValue("@ind", IndirizzoTextBox.Text)
            cmd.Parameters.AddWithValue("@tel", TelefonoTextBox.Text)
            cmd.Parameters.AddWithValue("@ema", EmailTextBox.Text)
            cmd.Parameters.AddWithValue("@tipo", TipoImpiantoTextBox.Text)
            cmd.Parameters.AddWithValue("@note", NoteAnagraficaTextBox.Text)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub SalvaAnagraficaToolStripButton_Click(sender As Object, e As EventArgs) Handles SalvaAnagraficaToolStripButton.Click
        ' 1. Validazione
        If String.IsNullOrWhiteSpace(CodiceClienteTextBox.Text) Then
            MessageBox.Show("Inserisci almeno il Codice Cliente!")
            Exit Sub
        End If

        ' Dim connString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabaseImpianti.mdf;Integrated Security=True"
        Dim connString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='I:\VisualStudio 2022\Progetto TuboScatola\TuboScatola\TuboScatola\DatabaseImpianti.mdf';Integrated Security=True;Encrypt=False"
        Try
            Using conn As New Microsoft.Data.SqlClient.SqlConnection(connString)
                conn.Open()

                If isNuovoRecord Then
                    ' SQL per inserimento (scriviamo tutti i campi)
                    Dim sqlInsert As String = "INSERT INTO Anagrafica (CodiceCliente, Nominativo, CAP, Citta, Indirizzo, Telefono, Email, TipoImpianto, NoteAnagrafica) " &
                                         "VALUES (@cod, @nom, @cap, @citt, @ind, @tel, @ema, @tipo, @note)"
                    EseguiComando(sqlInsert, conn)

                    isNuovoRecord = False
                    CodiceClienteTextBox.ReadOnly = True
                Else
                    ' SQL per aggiornamento
                    Dim sqlUpdate As String = "UPDATE Anagrafica SET Nominativo=@nom, CAP=@cap, Citta=@citt, Indirizzo=@ind, Telefono=@tel, Email=@ema, TipoImpianto=@tipo, NoteAnagrafica=@note " &
                                         "WHERE CodiceCliente=@cod"
                    EseguiComando(sqlUpdate, conn)
                End If
            End Using

            MessageBox.Show("Salvataggio anagrafica completato con successo!", "Conferma", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Opzionale: dopo il salva, rimettiamo il form in stato di sola lettura
            DisabilitaCampiAnagrafica()

        Catch ex As Exception
            MessageBox.Show("Errore durante il salvataggio: " & ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    ' Metodo di supporto per bloccare i campi dopo il salva o all'apertura
    Private Sub DisabilitaCampiAnagrafica()
        NominativoTextBox.ReadOnly = True
        CapTextBox.ReadOnly = True
        CittaTextBox.ReadOnly = True
        IndirizzoTextBox.ReadOnly = True
        TelefonoTextBox.ReadOnly = True
        EmailTextBox.ReadOnly = True
        TipoImpiantoTextBox.ReadOnly = True
        NoteAnagraficaTextBox.ReadOnly = True

        SalvaAnagraficaToolStripButton.Enabled = False
        ModificaAnagraficaToolStripButton.Enabled = True
    End Sub

    ' Codice dentro FormTuboScatola.vb
    Private Sub ModificaAnagraficaToolStripButton_Click(sender As Object, e As EventArgs) Handles ModificaAnagraficaToolStripButton.Click
        ' Sblocca le caselle per la modifica
        CodiceClienteTextBox.ReadOnly = True ' Lasciamo la chiave primaria bloccata
        NominativoTextBox.ReadOnly = False
        CapTextBox.ReadOnly = False
        CittaTextBox.ReadOnly = False
        ' ... e così via per gli altri campi

        ' Abilita il tasto Salva e disabilita il Modifica (per evitare casini)
        ModificaAnagraficaToolStripButton.Enabled = False
        SalvaAnagraficaToolStripButton.Enabled = True
    End Sub

    Private Sub SalvaScatolaToolStripButton_Click(sender As Object, e As EventArgs) Handles SalvaScatolaToolStripButton.Click
        ' 1. Validazione base
        If String.IsNullOrEmpty(CodiceClienteTextBox.Text) Then
            MessageBox.Show("Associa la scatola a un cliente salvando prima l'anagrafica!")
            Exit Sub
        End If

        'Dim connString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabaseImpianti.mdf;Integrated Security=True"
        Dim connString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='I:\VisualStudio 2022\Progetto TuboScatola\TuboScatola\TuboScatola\DatabaseImpianti.mdf';Integrated Security=True;Encrypt=False"
        Using conn As New Microsoft.Data.SqlClient.SqlConnection(connString)
            conn.Open()

            Dim sql As String
            If currentScatolaID = 0 Then
                ' NUOVA SCATOLA
                sql = "INSERT INTO Scatole (CodiceCliente_FK, Locale, MarcaScatola, MargineScatola, ModelloScatola, " &
                  "LarghezzaScatola, AltezzaScatola, ProfonditaScatola, EsitoScatola, PreforaturaPosteriore, " &
                  "SettoriLaterali, SettoriSopraSotto, Note) VALUES " &
                  "(@cod, @loc, @marca, @marg, @mod, @larg, @alt, @prof, @esito, @prefor, @lat, @sopra, @note)"
            Else
                ' MODIFICA SCATOLA ESISTENTE
                sql = "UPDATE Scatole SET Locale=@loc, MarcaScatola=@marca, MargineScatola=@marg, ModelloScatola=@mod, " &
                  "LarghezzaScatola=@larg, AltezzaScatola=@alt, ProfonditaScatola=@prof, EsitoScatola=@esito, " &
                  "PreforaturaPosteriore=@prefor, SettoriLaterali=@lat, SettoriSopraSotto=@sopra, Note=@note " &
                  "WHERE ScatolaID=@id"
            End If

            Using cmd As New Microsoft.Data.SqlClient.SqlCommand(sql, conn)
                ' Parametri comuni
                cmd.Parameters.AddWithValue("@cod", CodiceClienteTextBox.Text)
                cmd.Parameters.AddWithValue("@loc", LocaleScatolaTextBox.Text)
                cmd.Parameters.AddWithValue("@marca", MarcaScatolaComboBox.Text)
                cmd.Parameters.AddWithValue("@marg", MargineSicurezzaComboBox.Text)
                cmd.Parameters.AddWithValue("@mod", ModelloScatolaTextBox.Text)
                cmd.Parameters.AddWithValue("@larg", Val(LarghezzaScatolaTextBox.Text))
                cmd.Parameters.AddWithValue("@alt", Val(AltezzaScatolaTextBox.Text))
                cmd.Parameters.AddWithValue("@prof", Val(ProfonditaScatolaTextBox.Text))
                cmd.Parameters.AddWithValue("@esito", EsitoVerificaTextBox.Text)
                cmd.Parameters.AddWithValue("@prefor", Val(PreforaturaPosterioreTextBox.Text))
                cmd.Parameters.AddWithValue("@lat", Val(SettoreiLateraliTextBox.Text))
                cmd.Parameters.AddWithValue("@sopra", Val(SettoriSopraSottoTextBox.Text))
                cmd.Parameters.AddWithValue("@note", NoteScatolaTextBox.Text)

                If currentScatolaID <> 0 Then cmd.Parameters.AddWithValue("@id", currentScatolaID)

                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Dati scatola salvati correttamente.")
        CaricaScatoleCliente() ' Aggiorna la DataGridView
    End Sub
    Private Sub DgwScatole_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgwScatole.CellClick
        ' Verifichiamo che il click sia su una riga valida e non sull'intestazione
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DgwScatole.Rows(e.RowIndex)

            ' 1. Recupero dell'ID (fondamentale per collegare i componenti)
            ' Se per qualche motivo ScatolaID fosse nullo (improbabile), mettiamo 0
            currentScatolaID = If(row.Cells("ScatolaID").Value Is DBNull.Value, 0, Convert.ToInt32(row.Cells("ScatolaID").Value))

            ' 2. Campi Anagrafici di Input (Sezione Scatola)
            LocaleScatolaTextBox.Text = GetSafeString(row.Cells("Locale").Value)
            MarcaScatolaComboBox.Text = GetSafeString(row.Cells("MarcaScatola").Value)
            MargineSicurezzaComboBox.Text = GetSafeString(row.Cells("MargineScatola").Value)
            NoteScatolaTextBox.Text = GetSafeString(row.Cells("Note").Value)

            ' 3. Campi Risultati del Calcolo (Dati numerici -> GetSafeNumber)
            ModelloScatolaTextBox.Text = GetSafeString(row.Cells("ModelloScatola").Value) ' Testo

            LarghezzaScatolaTextBox.Text = GetSafeNumber(row.Cells("LarghezzaScatola").Value)
            AltezzaScatolaTextBox.Text = GetSafeNumber(row.Cells("AltezzaScatola").Value)
            ProfonditaScatolaTextBox.Text = GetSafeNumber(row.Cells("ProfonditaScatola").Value)
            PreforaturaPosterioreTextBox.Text = GetSafeNumber(row.Cells("PreforaturaPosteriore").Value)
            SettoreiLateraliTextBox.Text = GetSafeNumber(row.Cells("SettoriLaterali").Value)
            SettoriSopraSottoTextBox.Text = GetSafeNumber(row.Cells("SettoriSopraSotto").Value)

            EsitoVerificaTextBox.Text = GetSafeString(row.Cells("EsitoScatola").Value) ' Testo

            ' 4. Aggiornamento automatico della griglia dei componenti interni
            ' Questa Sub caricherà Tubi, Fili e Morsetti legati a questa scatola
            AggiornaDgwComponenti()

            InviaNotifica("Dati caricati per la scatola in: " & LocaleScatolaTextBox.Text)
        End If
    End Sub

    ' Funzione di supporto per evitare i crash da DBNull
    ' Per i campi di testo (Locale, Note, Modello, Esito)
    Private Function GetSafeString(value As Object) As String
        If value Is DBNull.Value OrElse value Is Nothing Then
            Return ""
        Else
            Return value.ToString()
        End If
    End Function

    ' Per i campi numerici (Larghezza, Altezza, Profondità, Settori)
    Private Function GetSafeNumber(value As Object) As String
        If value Is DBNull.Value OrElse value Is Nothing Then
            Return "0" ' Ritorna zero come stringa per la TextBox
        Else
            Return value.ToString()
        End If
    End Function
    Private Sub AggiornaDgwComponenti()
        If currentScatolaID = 0 Then Exit Sub

        Dim connString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabaseImpianti.mdf;Integrated Security=True"

        ' Query UNION originale (senza colonna Volume Totale)
        Dim sql As String = "SELECT 'TUBO' as Tipo, NomeTubo as Descrizione, 0.0 as [VolUnitario], 1 as Qta FROM TubiScatola WHERE ScatolaID_FK = @id " &
                        "UNION ALL " &
                        "SELECT 'FILO', NomeFilo, CAST((3.14159 * POWER(DiametroEsterno/2, 2) * Lunghezza) / 1000 AS DECIMAL(18,2)), 1 FROM FiliScatola WHERE ScatolaID_FK = @id " &
                        "UNION ALL " &
                        "SELECT 'MORSETTO', Modello, SuperficieUnitara, Quantita FROM MorsettiScatola WHERE ScatolaID_FK = @id"

        Using conn As New Microsoft.Data.SqlClient.SqlConnection(connString)
            Dim cmd As New Microsoft.Data.SqlClient.SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", currentScatolaID)

            Dim da As New Microsoft.Data.SqlClient.SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            ComponentiScatolaDataGridView.DataSource = dt
        End Using

        ' Miglioramento della griglia esistente
        If ComponentiScatolaDataGridView.Columns.Count > 0 Then
            ComponentiScatolaDataGridView.Columns("VolUnitario").DefaultCellStyle.Format = "N2"
            ComponentiScatolaDataGridView.Columns("VolUnitario").HeaderText = "Vol. Unitario (cm³)"
            ComponentiScatolaDataGridView.Columns("Qta").HeaderText = "Q.tà"
            ComponentiScatolaDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If

        InviaNotifica("Elenco componenti aggiornato.")
    End Sub
    Private Sub SalvaTuboToolStripButton_Click(sender As Object, e As EventArgs) Handles SalvaTuboToolStripButton.Click
        ' 1. Controllo se abbiamo una scatola attiva
        If currentScatolaID = 0 Then
            MessageBox.Show("Salva prima l'intestazione della Scatola (Locale e Marca)!")
            Exit Sub
        End If

        ' 2. Validazione minima
        If String.IsNullOrEmpty(MarcaTuboComboBox.Text) OrElse String.IsNullOrEmpty(NomeTuboTextBox.Text) Then
            MessageBox.Show("Inserisci il nome del tubo e seleziona una marca/modello.")
            Exit Sub
        End If

        'Dim connString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabaseImpianti.mdf;Integrated Security=True"
        Dim connString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='I:\VisualStudio 2022\Progetto TuboScatola\TuboScatola\TuboScatola\DatabaseImpianti.mdf';Integrated Security=True;Encrypt=False"
        ' SQL per inserire il tubo collegato alla scatola corrente
        ' Nota: Assicurati che i nomi delle colonne corrispondano alla tua tabella TubiScatola
        Dim sql As String = "INSERT INTO TubiScatola (ScatolaID_FK, NomeTubo, Marca, Tipo, DiametroEst, DiametroInt, LatoIngresso, Note) " &
                        "VALUES (@sid, @nome, @marca, @tipo, @dest, @dint, @lato, @note)"

        Using conn As New Microsoft.Data.SqlClient.SqlConnection(connString)
            Using cmd As New Microsoft.Data.SqlClient.SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@sid", currentScatolaID)
                cmd.Parameters.AddWithValue("@nome", NomeTuboTextBox.Text)
                cmd.Parameters.AddWithValue("@marca", MarcaTuboComboBox.Text)
                cmd.Parameters.AddWithValue("@tipo", TipoTuboComboBox.Text)
                cmd.Parameters.AddWithValue("@dest", Val(DiametroEstComboBox.Text))
                cmd.Parameters.AddWithValue("@dint", Val(DiametroIntTuboTextBox.Text))
                cmd.Parameters.AddWithValue("@lato", LatoIngressoComboBox.Text)
                cmd.Parameters.AddWithValue("@note", NoteTuboTextBox.Text)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    AggiornaDgwComponenti()
                    InviaNotifica("Tubo aggiunto correttamente alla configurazione.")

                    ' OPZIONALE: Pulire i campi dopo il salva per inserirne un altro
                    ' ResettaCampiTubo() 
                Catch ex As Exception
                    MessageBox.Show("Errore salvataggio tubo: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub SalvaFiloToolStripButton_Click(sender As Object, e As EventArgs) Handles SalvaFiloToolStripButton.Click
        If currentScatolaID = 0 Then
            MessageBox.Show("Salva l'intestazione della scatola prima di aggiungere i fili!")
            Exit Sub
        End If

        ' Validazione minima: Nome, Sezione e Lunghezza
        If String.IsNullOrWhiteSpace(NomeFiloTextBox.Text) OrElse SezioneFiloComboBox.SelectedIndex = -1 Then
            MessageBox.Show("Inserisci almeno il Nome del filo e seleziona la Sezione!")
            Exit Sub
        End If

        'Dim connString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabaseImpianti.mdf;Integrated Security=True"
        Dim connString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='I:\VisualStudio 2022\Progetto TuboScatola\TuboScatola\TuboScatola\DatabaseImpianti.mdf';Integrated Security=True;Encrypt=False"
        Dim sql As String = "INSERT INTO FiliScatola (ScatolaID_FK, NomeFilo, Classificazione, TipoFilo, Colore, Sezione, Lunghezza, DiametroEsterno, Note) " &
                        "VALUES (@sid, @nome, @class, @tipo, @col, @sez, @lung, @dest, @note)"

        Using conn As New Microsoft.Data.SqlClient.SqlConnection(connString)
            Using cmd As New Microsoft.Data.SqlClient.SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@sid", currentScatolaID)
                cmd.Parameters.AddWithValue("@nome", NomeFiloTextBox.Text)
                cmd.Parameters.AddWithValue("@class", ClassificazioneFiloTextBox.Text)
                cmd.Parameters.AddWithValue("@tipo", TipoFiloTextBox.Text)
                cmd.Parameters.AddWithValue("@col", ColoreFiloComboBox.Text)
                cmd.Parameters.AddWithValue("@sez", SezioneFiloComboBox.SelectedItem)
                cmd.Parameters.AddWithValue("@lung", Val(LunghezzaFiloTextBox.Text)) ' Lunghezza in mm o cm
                cmd.Parameters.AddWithValue("@dest", diametroFiloCorrente)
                cmd.Parameters.AddWithValue("@note", NoteFiloTextBox.Text)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    AggiornaDgwComponenti()
                    InviaNotifica("Filo '" & NomeFiloTextBox.Text & "' aggiunto alla scatola.")

                    ' Pulizia campi per inserimento successivo
                    ResettaCampiInserimentoFilo()
                Catch ex As Exception
                    MessageBox.Show("Errore salvataggio filo: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub ResettaCampiInserimentoFilo()
        NomeFiloTextBox.Clear()
        ClassificazioneFiloTextBox.Clear()
        TipoFiloTextBox.Clear()
        LunghezzaFiloTextBox.Text = "17"
        NoteFiloTextBox.Clear()
        NomeFiloTextBox.Focus()
    End Sub
    Private Sub NuovoFiloToolStripButton_Click(sender As Object, e As EventArgs) Handles NuovoFiloToolStripButton.Click
        LunghezzaFiloTextBox.Text = "17" ' Valore espresso in cm
    End Sub

    Private Sub SalvaMorsettoToolStripButton_Click(sender As Object, e As EventArgs) Handles SalvaMorsettoToolStripButton.Click
        If currentScatolaID = 0 Then
            MessageBox.Show("Salva prima la scatola!")
            Exit Sub
        End If

        'Dim connString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabaseImpianti.mdf;Integrated Security=True"
        Dim connString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='I:\VisualStudio 2022\Progetto TuboScatola\TuboScatola\TuboScatola\DatabaseImpianti.mdf';Integrated Security=True;Encrypt=False"
        Dim sql As String = "INSERT INTO MorsettiScatola (ScatolaID_FK, Marca, Modello, SuperficieUnitara, Quantita, Note) " &
                        "VALUES (@sid, @mar, @mod, @sup, @qta, @note)"

        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@sid", currentScatolaID)
                cmd.Parameters.AddWithValue("@mar", MarcaMorsettoComboBox.Text)
                cmd.Parameters.AddWithValue("@mod", TipoMorsettoComboBox.Text)
                cmd.Parameters.AddWithValue("@sup", Val(SuperficieOccupataTextBox.Text.Replace(",", ".")))
                cmd.Parameters.AddWithValue("@qta", Val(QuantitaMorsettiTextBox.Text))
                cmd.Parameters.AddWithValue("@note", NoteMorsettoTextBox.Text)

                conn.Open()
                cmd.ExecuteNonQuery()
                AggiornaDgwComponenti()
                InviaNotifica("Morsetti aggiunti alla configurazione.")
                ' Qui chiameremo l'aggiornamento della DGW componenti
            End Using
        End Using
    End Sub

    Private Sub DgwScatole_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgwScatole.CellContentClick

    End Sub
End Class