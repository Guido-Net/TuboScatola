Public Class FormTubo

    ' Variabile per capire se è stata selezionata una riga/cella
    Public CellaSelezionata As Boolean = False
    ' Variabile per capire se stiamo creando un nuovo tubo (0) o modificandone uno esistente
    Private IDCorrente As Integer = 0

    ' Stringa di connessione dinamica al database
    Private stringaConnessione As String = ""

    ' Funzione salvagente per trasformare il testo in numero decimale
    Private Function ConvertiInDecimale(testo As String) As Decimal
        Dim valoreDecimale As Decimal = 0
        If String.IsNullOrWhiteSpace(testo) Then Return 0
        Decimal.TryParse(testo.Replace(".", ","), valoreDecimale)
        Return valoreDecimale
    End Function

    Public Sub DeselezionaLibTuboDataGridView()
        LibTuboDataGridView.CurrentCell = Nothing
        LibTuboDataGridView.ClearSelection()
    End Sub

    Public Sub SvuotaCampiTubo()
        MarcaTuboTextBox.Clear()
        TipoTuboComboBox.SelectedIndex = -1
        DiamEstTextBox.Clear()
        DiamIntTextBox.Clear()
        NoteTuboTextBox.Clear()
    End Sub

    Public Sub AbilitaCampiTubo()
        MarcaTuboTextBox.ReadOnly = False
        TipoTuboComboBox.Enabled = True
        DiamEstTextBox.ReadOnly = False
        DiamIntTextBox.ReadOnly = False
        NoteTuboTextBox.ReadOnly = False
    End Sub

    Public Sub DisabilitaCampiTubo()
        MarcaTuboTextBox.ReadOnly = True
        TipoTuboComboBox.Enabled = False
        DiamEstTextBox.ReadOnly = True
        DiamIntTextBox.ReadOnly = True
        NoteTuboTextBox.ReadOnly = True
    End Sub

    ' --- NUOVO INSERIMENTO ---
    Private Sub NuovoTuboToolStripButton_Click(sender As Object, e As EventArgs) Handles NuovoTuboToolStripButton.Click
        IDCorrente = 0
        AbilitaCampiTubo()
        SvuotaCampiTubo()

        NotificaTuboToolStripStatusLabel.Text = "Inserimento nuovo tubo... Compila i campi e premi Salva."
        NotificaTuboLabel.Text = "Nuovo tubo..."
        MarcaTuboTextBox.Focus()
    End Sub

    ' --- SALVATAGGIO / AGGIORNAMENTO ---
    Private Sub SalvaTuboToolStripButton_Click(sender As Object, e As EventArgs) Handles SalvaTuboToolStripButton.Click
        ' Controllo sicurezza: Marca e Tipo sono raccomandati, TipoTubo o Diametro obbligatori
        If String.IsNullOrWhiteSpace(TipoTuboComboBox.Text) OrElse String.IsNullOrWhiteSpace(DiamEstTextBox.Text) Then
            MessageBox.Show("Inserire almeno il Tipo Tubo e il Diametro Esterno per salvare.", "Dati mancanti", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using connessione As New Microsoft.Data.SqlClient.SqlConnection(stringaConnessione)
                connessione.Open()
                Dim querySql As String

                If IDCorrente = 0 Then
                    querySql = "INSERT INTO LibTubi (Marca, TipoTubo, DiamEst, DiamInt, Note) " &
                               "VALUES (@marca, @tipo, @diamEst, @diamInt, @note)"
                Else
                    querySql = "UPDATE LibTubi SET Marca=@marca, TipoTubo=@tipo, DiamEst=@diamEst, DiamInt=@diamInt, Note=@note " &
                               "WHERE Id=@id"
                End If

                Using comando As New Microsoft.Data.SqlClient.SqlCommand(querySql, connessione)
                    comando.Parameters.AddWithValue("@marca", MarcaTuboTextBox.Text.Trim())
                    comando.Parameters.AddWithValue("@tipo", TipoTuboComboBox.Text.Trim())
                    comando.Parameters.AddWithValue("@diamEst", ConvertiInDecimale(DiamEstTextBox.Text))
                    comando.Parameters.AddWithValue("@diamInt", ConvertiInDecimale(DiamIntTextBox.Text))
                    comando.Parameters.AddWithValue("@note", NoteTuboTextBox.Text.Trim())

                    If IDCorrente <> 0 Then
                        comando.Parameters.AddWithValue("@id", IDCorrente)
                    End If

                    comando.ExecuteNonQuery()
                End Using
            End Using

            DisabilitaCampiTubo()
            NotificaTuboToolStripStatusLabel.Text = "Tubo '" & TipoTuboComboBox.Text & " Ø" & DiamEstTextBox.Text & "' salvato con successo alle " & DateTime.Now.ToString("HH:mm:ss")
            NotificaTuboLabel.Text = "Salvato Record tubo..."

            CaricaDatiGriglia()
            DeselezionaLibTuboDataGridView()

        Catch ex As Exception
            MessageBox.Show("Errore durante il salvataggio nel database: " & vbCrLf & ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- CARICAMENTO DATAGRIDVIEW ---
    Private Sub CaricaDatiGriglia()
        Try
            Using connessione As New Microsoft.Data.SqlClient.SqlConnection(stringaConnessione)
                Dim querySql As String = "SELECT * FROM LibTubi ORDER BY Marca, TipoTubo, DiamEst"
                Dim adattatore As New Microsoft.Data.SqlClient.SqlDataAdapter(querySql, connessione)
                Dim tabellaDati As New DataTable()
                adattatore.Fill(tabellaDati)

                LibTuboDataGridView.DataSource = tabellaDati
                LibTuboDataGridView.AutoGenerateColumns = True

                If LibTuboDataGridView.Columns.Contains("Id") Then
                    LibTuboDataGridView.Columns("Id").Visible = False
                End If
            End Using
        Catch ex As Exception
            NotificaTuboToolStripStatusLabel.Text = "Errore caricamento griglia: " & ex.Message
        End Try
    End Sub

    ' --- INIZIALIZZAZIONE FORM ---
    Private Sub FormTubo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
        Try
            Dim cartellaEseguibile As String = Application.StartupPath
            Dim percorsoDatabase As String = ""

            If cartellaEseguibile.Contains("bin") Then
                Dim percorsoProgettoPrincipale As String = "I:\VisualStudio 2022\Progetto TuboScatola\TuboScatola\TuboScatola"
                percorsoDatabase = System.IO.Path.Combine(percorsoProgettoPrincipale, "DatabaseImpianti.mdf")
            Else
                percorsoDatabase = System.IO.Path.Combine(cartellaEseguibile, "DatabaseImpianti.mdf")
            End If

            Dim cartellaDelFile As String = System.IO.Path.GetDirectoryName(percorsoDatabase)
            AppDomain.CurrentDomain.SetData("DataDirectory", cartellaDelFile)

            stringaConnessione = $"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={percorsoDatabase};Integrated Security=True;Encrypt=False"

            CaricaDatiGriglia()
            NotificaTuboToolStripStatusLabel.Text = "Pronto. Connessione database tubi eseguita."
            DeselezionaLibTuboDataGridView()

        Catch ex As Exception
            MessageBox.Show("Errore durante l'inizializzazione del database: " & ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- SELEZIONE RECORD DALLA GRIGLIA ---
    Private Sub LibTuboDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles LibTuboDataGridView.CellClick
        If e.RowIndex >= 0 Then
            Dim rigaSelezionata As DataGridViewRow = LibTuboDataGridView.Rows(e.RowIndex)

            CellaSelezionata = True
            RecordTuboToolStripLabel.Text = (e.RowIndex + 1).ToString()
            IDCorrente = Convert.ToInt32(rigaSelezionata.Cells("Id").Value)

            MarcaTuboTextBox.Text = If(rigaSelezionata.Cells("Marca").Value?.ToString(), "")
            TipoTuboComboBox.Text = If(rigaSelezionata.Cells("TipoTubo").Value?.ToString(), "")
            DiamEstTextBox.Text = If(rigaSelezionata.Cells("DiamEst").Value?.ToString(), "")
            DiamIntTextBox.Text = If(rigaSelezionata.Cells("DiamInt").Value?.ToString(), "")
            NoteTuboTextBox.Text = If(rigaSelezionata.Cells("Note").Value?.ToString(), "")

            NotificaTuboToolStripStatusLabel.Text = "Tubo selezionato: " & TipoTuboComboBox.Text & " Ø" & DiamEstTextBox.Text
            NotificaTuboLabel.Text = "Record tubo selezionato..."
        End If
    End Sub

    ' --- ELIMINAZIONE RECORD ---
    Private Sub EliminaTuboToolStripButton_Click(sender As Object, e As EventArgs) Handles EliminaTuboToolStripButton.Click
        If IDCorrente = 0 Then
            MessageBox.Show("Seleziona un tubo dalla griglia prima di eliminarlo.", "Nessuna selezione", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim conferma As DialogResult = MessageBox.Show("Sei sicuro di voler eliminare definitivamente il tubo selezionato?", "Conferma eliminazione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If conferma = DialogResult.Yes Then
            Try
                Using connessione As New Microsoft.Data.SqlClient.SqlConnection(stringaConnessione)
                    connessione.Open()
                    Dim querySql As String = "DELETE FROM LibTubi WHERE Id = @id"

                    Using comando As New Microsoft.Data.SqlClient.SqlCommand(querySql, connessione)
                        comando.Parameters.AddWithValue("@id", IDCorrente)
                        comando.ExecuteNonQuery()
                    End Using
                End Using

                NotificaTuboToolStripStatusLabel.Text = "Tubo eliminato con successo."
                IDCorrente = 0
                SvuotaCampiTubo()
                DisabilitaCampiTubo()
                CaricaDatiGriglia()
                DeselezionaLibTuboDataGridView()

            Catch ex As Exception
                MessageBox.Show("Errore durante l'eliminazione: " & vbCrLf & ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' --- FILTRO E RICERCA ---
    Public Sub FiltraGriglia(colonna As String, valore As String)
        If LibTuboDataGridView.DataSource IsNot Nothing Then
            Dim dt As DataTable = CType(LibTuboDataGridView.DataSource, DataTable)

            If Not String.IsNullOrEmpty(colonna) AndAlso Not String.IsNullOrEmpty(valore) Then
                dt.DefaultView.RowFilter = String.Format("{0} LIKE '%{1}%'", colonna, valore)
            Else
                dt.DefaultView.RowFilter = ""
            End If
            AnnulaRicercaTuboToolStripButton.Enabled = (dt.DefaultView.RowFilter <> "")
        End If
    End Sub

    Private Sub RicercaTuboToolStripButton_Click(sender As Object, e As EventArgs) Handles RicercaTuboToolStripButton.Click
        Dim frmCerca As New FormCerca()
        frmCerca.ShowDialog()
        DisabilitaCampiTubo()
    End Sub

    Private Sub AnnulaRicercaTuboToolStripButton_Click(sender As Object, e As EventArgs) Handles AnnulaRicercaTuboToolStripButton.Click
        FiltraGriglia("", "")
        NotificaTuboToolStripStatusLabel.Text = "Tutti i tubi visualizzati."
    End Sub

    ' --- IMPORTAZIONE ED ESPORTAZIONE XML ---
    Private Sub ImportaDBTuboToolStripButton_Click(sender As Object, e As EventArgs) Handles ImportaDBTuboToolStripButton.Click
        Dim openFileDialog As New OpenFileDialog With {
            .Filter = "File XML (*.xml)|*.xml",
            .Title = "Seleziona il file XML dei Tubi da importare"
        }

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                Dim tabellaXml As New DataTable()
                tabellaXml.ReadXml(openFileDialog.FileName)

                If tabellaXml.Rows.Count = 0 Then
                    MessageBox.Show("Il file XML selezionato non contiene record.", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                Using connessione As New Microsoft.Data.SqlClient.SqlConnection(stringaConnessione)
                    connessione.Open()
                    Using transazione As Microsoft.Data.SqlClient.SqlTransaction = connessione.BeginTransaction()
                        Try
                            Dim queryDelete As String = "DELETE FROM LibTubi"
                            Using comandoDelete As New Microsoft.Data.SqlClient.SqlCommand(queryDelete, connessione, transazione)
                                comandoDelete.ExecuteNonQuery()
                            End Using

                            Dim queryInsert As String = "INSERT INTO LibTubi (Marca, TipoTubo, DiamEst, DiamInt, Note) " &
                                                       "VALUES (@marca, @tipo, @diamEst, @diamInt, @note)"

                            Using comandoInsert As New Microsoft.Data.SqlClient.SqlCommand(queryInsert, connessione, transazione)
                                For Each rigaXml As DataRow In tabellaXml.Rows
                                    comandoInsert.Parameters.Clear()
                                    comandoInsert.Parameters.AddWithValue("@marca", If(rigaXml.Table.Columns.Contains("Marca"), rigaXml("Marca"), DBNull.Value))
                                    comandoInsert.Parameters.AddWithValue("@tipo", If(rigaXml.Table.Columns.Contains("TipoTubo"), rigaXml("TipoTubo"), DBNull.Value))
                                    comandoInsert.Parameters.AddWithValue("@diamEst", If(rigaXml.Table.Columns.Contains("DiamEst"), rigaXml("DiamEst"), 0))
                                    comandoInsert.Parameters.AddWithValue("@diamInt", If(rigaXml.Table.Columns.Contains("DiamInt"), rigaXml("DiamInt"), 0))
                                    comandoInsert.Parameters.AddWithValue("@note", If(rigaXml.Table.Columns.Contains("Note"), rigaXml("Note"), DBNull.Value))
                                    comandoInsert.ExecuteNonQuery()
                                Next
                            End Using

                            transazione.Commit()
                            NotificaTuboToolStripStatusLabel.Text = "Database Tubi importato con successo!"
                            MessageBox.Show("Importazione completata con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            CaricaDatiGriglia()
                            NuovoTuboToolStripButton.PerformClick()

                        Catch ex As Exception
                            transazione.Rollback()
                            Throw
                        End Try
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show($"Errore durante l'importazione: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub EsportaDBTuboToolStripButton_Click(sender As Object, e As EventArgs) Handles EsportaDBTuboToolStripButton.Click
        Dim saveDialog As New SaveFileDialog With {
            .Filter = "File XML (*.xml)|*.xml",
            .Title = "Esporta database Tubi",
            .FileName = "BackupTubi.xml"
        }

        If saveDialog.ShowDialog() = DialogResult.OK Then
            Try
                If LibTuboDataGridView.DataSource IsNot Nothing Then
                    Dim tabellaDati As DataTable = CType(LibTuboDataGridView.DataSource, DataTable)
                    tabellaDati.TableName = "LibTubi"
                    tabellaDati.WriteXml(saveDialog.FileName, XmlWriteMode.WriteSchema)
                    MessageBox.Show("Esportazione completata con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show($"Errore durante l'esportazione: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub EliminaDBTuboToolStripButton_Click(sender As Object, e As EventArgs) Handles EliminaDBTuboToolStripButton.Click
        Dim pConf As DialogResult = MessageBox.Show("Stai per cancellare DEFINITIVAMENTE tutti i tubi dal database. Continuare?", "PULIZIA TOTALE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If pConf = DialogResult.Yes Then
            Dim sConf As DialogResult = MessageBox.Show("Sei veramente sicuro? L'operazione non è annullabile.", "CONFERMA CRITICA", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            If sConf = DialogResult.Yes Then
                Try
                    Using connessione As New Microsoft.Data.SqlClient.SqlConnection(stringaConnessione)
                        connessione.Open()
                        Using comando As New Microsoft.Data.SqlClient.SqlCommand("DELETE FROM LibTubi", connessione)
                            comando.ExecuteNonQuery()
                        End Using
                    End Using
                    CaricaDatiGriglia()
                    NuovoTuboToolStripButton.PerformClick()
                Catch ex As Exception
                    MessageBox.Show("Errore durante la pulizia: " & ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    ' --- MODIFICA E CHIUSURA ---
    Private Sub ModificaTuboToolStripButton_Click(sender As Object, e As EventArgs) Handles ModificaTuboToolStripButton.Click
        If CellaSelezionata Then
            AbilitaCampiTubo()
            NotificaTuboToolStripStatusLabel.Text = "Modalità modifica dati attiva."
        Else
            DisabilitaCampiTubo()
            MessageBox.Show("Selezionare prima un record dalla griglia...", "Selezione mancante", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub EsciTuboToolStripButton_Click(sender As Object, e As EventArgs) Handles EsciTuboToolStripButton.Click
        RecordTuboToolStripLabel.Text = "- Navigazione -"
        CellaSelezionata = False
        Me.Dispose()
    End Sub

    Private Sub FormTubo_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If CellaSelezionata Then
                DeselezionaLibTuboDataGridView()
                DisabilitaCampiTubo()
                NotificaTuboToolStripStatusLabel.Text = "Modalità modifica dati disattivata."
            Else
                Me.Dispose()
            End If
            CellaSelezionata = False
        End If
    End Sub
    Private Sub DiametriTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DiamEstTextBox.KeyPress, DiamIntTextBox.KeyPress
        Dim txt As TextBox = CType(sender, TextBox)

        ' Converte automaticamente il punto del tastierino numerico in virgola
        If e.KeyChar = "."c Then
            e.KeyChar = ","c
        End If

        ' Performa il controllo sui caratteri consentiti: cifre, tasti di controllo (es. Backspace) e virgola
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> ","c Then
            e.Handled = True
        End If

        ' Impedisce l'inserimento di più di una virgola nello stesso campo
        If e.KeyChar = ","c AndAlso txt.Text.Contains(",") Then
            e.Handled = True
        End If
    End Sub

End Class