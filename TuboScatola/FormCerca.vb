Public Class FormCerca
    Private Sub FormCerca_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    ' Nel FormCerca, quando premi il tasto "Cerca"
    ' Nel codice di FormCerca.vb
    Private Sub btnEseguiRicerca_Click(sender As Object, e As EventArgs) Handles btnEseguiRicerca.Click
        ' Cerchiamo il form aperto che si chiama FormScatola
        Dim fScatola As FormScatola = DirectCast(Application.OpenForms("FormScatola"), FormScatola)

        If fScatola IsNot Nothing Then
            ' Chiamiamo la funzione che abbiamo appena creato in FormScatola
            fScatola.FiltraGriglia(cboTipoRicerca.Text, txtValoreCerca.Text)
        End If
        Me.Close()
    End Sub

    Private Sub btnAnnullaRicerca_Click(sender As Object, e As EventArgs) Handles btnAnnullaRicerca.Click
        Dim fScatola As FormScatola = DirectCast(Application.OpenForms("FormScatola"), FormScatola)

        If fScatola IsNot Nothing Then
            ' Passiamo parametri vuoti per resettare
            fScatola.FiltraGriglia("", "")
        End If
        Me.Close()
    End Sub

End Class