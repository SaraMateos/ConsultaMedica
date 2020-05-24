Public Class VerMedicos
    'Nuevo
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.Hide()
        NuevoMedico.Show()
    End Sub

    'Editar
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        On Error GoTo SaveErr
        ' MEDICOSBindingSource.EndEdit()
        ' MEDICOSTableAdapter.Update(ConsultaMedicaDataSet)
        MessageBox.Show("Paciente guardado.")
SaveErr:
        Exit Sub
    End Sub

    'Volver a la pestaña principal
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Principal.Show()
    End Sub

    Private Sub verMedicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ConsultaMedicaDataSet.MEDICOS' Puede moverla o quitarla según sea necesario.
        Me.MEDICOSTableAdapter.Fill(Me.ConsultaMedicaDataSet.MEDICOS)

    End Sub
End Class