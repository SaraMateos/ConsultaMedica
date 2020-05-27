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
    Private Sub DataRecetas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataRecetas.CellContentClick

        Dim i As Integer
        i = DataRecetas.CurrentRow.Index

        txtIdReceta.Text = DataRecetas.Item(0, i).Value()
        txtMedico.Text = DataRecetas.Item(1, i).Value()
        txtPaciente.Text = DataRecetas.Item(2, i).Value()
        DTPFechaCreacion.Text = DataRecetas.Item(3, i).Value()
        txtEnfermedad.Text = DataRecetas.Item(4, i).Value()
        txtMedicamento.Text = DataRecetas.Item(5, i).Value()
        txtDosis.Text = DataRecetas.Item(6, i).Value()

    End Sub

    'Actualiza los datos de la tabla
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        Dim oledc As New OleDbCommand("SELECT * FROM RECETAS", conexion1)
        Dim ds As New DataSet
        Dim adaptar As New OleDbDataAdapter
        adaptar.SelectCommand = oledc
        adaptar.Fill(ds, "RECETAS")
        DataRecetas.DataSource = ds
        DataRecetas.DataMember = "RECETAS"

    End Sub

    'Muestra la pestaña Principal
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Principal.Show()
    End Sub

    'Añade una nueva receta
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        comand = New OleDbCommand("INSERT INTO RECETAS(idMedico, idPaciente, fechaCreacion, idEnfermedad,
            idMedicamento, dosis)" & " VALUES(txtMedico, txtPaciente, DTPFechaCreacion, txtEnfermedad, txtMedicamento, txtDosis)", conexion1)
        comand.Parameters.AddWithValue("@idMedico", txtMedico.Text)
        comand.Parameters.AddWithValue("@idPaciente", txtPaciente.Text)
        comand.Parameters.AddWithValue("@fechaCreacion", DTPFechaCreacion.Value.Date)
        comand.Parameters.AddWithValue("@idEnfermedad", txtEnfermedad.Text)
        comand.Parameters.AddWithValue("@idMedicamento", txtMedicamento.Text)
        comand.Parameters.AddWithValue("@dosis", txtDosis.Text)

        comand.ExecuteNonQuery()

        MsgBox("Nueva receta agregada.", MsgBoxStyle.Information, "Información")

    End Sub
End Class