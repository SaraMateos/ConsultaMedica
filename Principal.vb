Public Class Principal
    Private Sub btnPacientes_Click(sender As Object, e As EventArgs) Handles btnPacientes.Click
        Me.Hide()
        VerPacientes.Show()
    End Sub

    'Botón médicos
    Private Sub btnMedicos_Click(sender As Object, e As EventArgs) Handles btnMedicos.Click
        Me.Hide()
        VerMedicos.Show()
    End Sub

    'Botón recetas
    Private Sub btnRecetas_Click(sender As Object, e As EventArgs) Handles btnRecetas.Click
        Me.Hide()
        Receta.Show()
    End Sub

    'Botón consulta
    Private Sub btnConsultas_Click(sender As Object, e As EventArgs) Handles btnConsultas.Click
        Me.Hide()
        Consulta.Show()
    End Sub

End Class