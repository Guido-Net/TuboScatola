Public Class FormStampa
    ' Questa variabile ci dirà quale report usare
    Public ModalitaStampa As String = "SINGOLO"
    Public DatiDaStampare As DataTable

    Private Sub FormStampa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Scegliamo il file in base alla modalità
        If ModalitaStampa = "GRUPPI" Then
            rvScatole.LocalReport.ReportEmbeddedResource = "TuboScatola.ReportScatole_Gruppi.rdlc"
        Else
            rvScatole.LocalReport.ReportEmbeddedResource = "TuboScatola.ReportScatole.rdlc"
        End If

        ' ... resto del codice identico ...
        rvScatole.LocalReport.DataSources.Clear()
        If DatiDaStampare IsNot Nothing Then
            Dim rds As New Microsoft.Reporting.WinForms.ReportDataSource("dsScatoleStampa", DatiDaStampare)
            rvScatole.LocalReport.DataSources.Add(rds)
        End If
        rvScatole.RefreshReport()
    End Sub
End Class