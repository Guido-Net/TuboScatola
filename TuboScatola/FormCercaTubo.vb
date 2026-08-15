Public Class FormCercaTubo

    Private Sub FormCercaTubo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Popola la ComboBox con le colonne di ricerca disponibili
        TipoRicercaComboBox.Items.Clear()
        TipoRicercaComboBox.Items.Add("Marca")
        TipoRicercaComboBox.Items.Add("TipoTubo") ' Equivalente a Codice/Tipo Tubo
        TipoRicercaComboBox.SelectedIndex = 0
    End Sub

    Private Sub EseguiRicerca()
        Dim campoDb As String = TipoRicercaComboBox.SelectedItem.ToString()
        Dim testoDaCercare As String = DatoRicercaTextBox.Text.Trim()

        ' Trova l'istanza attiva di FormTubo ed esegue il filtro
        Dim frmTubo As FormTubo = Application.OpenForms.OfType(Of FormTubo)().FirstOrDefault()

        If frmTubo IsNot Nothing Then
            frmTubo.FiltraGriglia(campoDb, testoDaCercare)
        End If

        Me.Close()
    End Sub

    Private Sub CercaButton_Click(sender As Object, e As EventArgs) Handles CercaButton.Click
        EseguiRicerca()
    End Sub

    Private Sub AnnullaButton_Click(sender As Object, e As EventArgs) Handles AnnullaButton.Click
        Me.Close()
    End Sub

    Private Sub FormCercaTubo_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            EseguiRicerca()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class