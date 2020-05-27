Imports System
Imports System.Data.OleDb

Public Class Receta
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Principal.Show()
    End Sub

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RecImprimir.Show()

    End Sub
End Class