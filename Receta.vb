Imports System
Imports System.Data.OleDb

Public Class Receta
    'Muestra la pestaña Principal
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Principal.Show()
    End Sub

    'Actualizar los datos de la tabla
    Private Sub btnActualizar_Click_1(sender As Object, e As EventArgs) Handles btnActualizar.Click
        'Botón para actualizar la tabla
        Dim ole As New OleDbCommand("Select * from CONSULTA", conexion1)
        Dim ds As New DataSet
        Dim dataadapter3 As New OleDbDataAdapter
        dataadapter3.SelectCommand = ole
        dataadapter3.Fill(ds, "CONSULTA")
        'DataRecetas.DataSource = ds
        'DataRecetas.DataMember = "CONSULTA"
    End Sub

    'Muestra la pestaña para imprimir
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        RecImprimir.Show()
    End Sub

End Class