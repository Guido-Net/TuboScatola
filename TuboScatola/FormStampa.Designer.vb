<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStampa
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormStampa))
        rvScatole = New Microsoft.Reporting.WinForms.ReportViewer()
        SuspendLayout()
        ' 
        ' rvScatole
        ' 
        rvScatole.Dock = DockStyle.Fill ' <--- AGGIUNGI QUESTO: fa occupare tutto lo spazio
        rvScatole.Location = New Point(0, 0)
        rvScatole.Name = "rvScatole" ' <--- Corretto il nome che era "ReportViewer"
        rvScatole.ServerReport.BearerToken = Nothing
        rvScatole.Size = New Size(800, 555) ' <--- Adattato alle dimensioni del form
        rvScatole.TabIndex = 0
        ' 
        ' FormStampa
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 555)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FormStampa"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormStampa"
        Controls.Add(rvScatole)
        ResumeLayout(False)
    End Sub

    Friend WithEvents rvScatole As Microsoft.Reporting.WinForms.ReportViewer
End Class
