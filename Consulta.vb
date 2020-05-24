Public Class Consulta
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ' MEDICOSTableAdapter.AddNew()
    End Sub

    'Editar
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        On Error GoTo SaveErr
        'MEDICOSTableAdapter.EndEdit()
        'MEDICOSTableAdapter.Update(ConsultaMedicaDataSet)
        MessageBox.Show("Paciente guardado.")
SaveErr:
        Exit Sub
    End Sub

    'Borrar
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Me.Close()
    End Sub

    'Volver
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Principal.Show()
    End Sub
End Class