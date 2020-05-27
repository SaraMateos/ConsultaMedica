Imports System
Imports System.Data.OleDb

Public Class Receta

    'Conexión con la tabla de recetas
    Private Sub verRec()
        Dim oda As New OleDbDataAdapter
        Dim ods As New DataSet
        Dim consulta As String

        consulta = "SELECT * FROM RECETAS"
        oda = New OleDbDataAdapter(consulta, conexion1)
        ods.Tables.Add("RECETAS")
        oda.Fill(ods.Tables("RECETAS"))
        DataRecetas.DataSource = ods.Tables("RECETAS")

    End Sub

    Private Sub Receta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'abrir conexión
        abrir()

        'Carga la tabla de recetas
        verRec()

    End Sub

    'Mostrar datos de la tabla es su correspondiente lugar
    Private Sub DataConsultas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataRecetas.CellContentClick

        Dim i As Integer
        i = DataRecetas.CurrentRow.Index

        txtIdReceta.Text = DataRecetas.Item(0, i).Value()
        txtMedico.Text = DataRecetas.Item(1, i).Value()
        txtPaciente.Text = DataRecetas.Item(2, i).Value()
        DTPFechaCreacion.Text = DataRecetas.Item(3, i).Value()
        txtMedicamento.Text = DataRecetas.Item(5, i).Value()
        txtDosis.Text = DataRecetas.Item(6, i).Value()

    End Sub

    'Actualizar los datos de la tabla
    Private Sub btnActualizar_Click_1(sender As Object, e As EventArgs) Handles btnActualizar.Click
        'Botón para actualizar la tabla
        Dim ole As New OleDbCommand("SELECT * FROM RECETAS", conexion1)
        Dim ds As New DataSet
        Dim dataadapter3 As New OleDbDataAdapter
        dataadapter3.SelectCommand = ole
        dataadapter3.Fill(ds, "RECETAS")
        DataRecetas.DataSource = ds
        DataRecetas.DataMember = "RECETAS"
    End Sub

    'Muestra la pestaña Principal
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Principal.Show()
    End Sub

    'Muestra la pestaña para imprimir
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        RecImprimir.Show()
    End Sub


End Class