Public Class RecImprimir
    Private Sub RecImprimir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ConsultaMedicaDataSet.RECETAS' Puede moverla o quitarla según sea necesario.
        Me.RECETASTableAdapter.Fill(Me.ConsultaMedicaDataSet.RECETAS)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class