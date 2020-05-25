Imports System.Data
Imports System.Data.OleDb

Public Class Consulta

    Public cadena As OleDbConnection
    Dim comand As New OleDbCommand

    'Conexión con la tabla de pacientes
    Private Sub verConsul()
        Dim oda As New OleDbDataAdapter
        Dim ods As New DataSet
        Dim consulta As String

        consulta = "SELECT * FROM CONSULTA"
        oda = New OleDbDataAdapter(consulta, conexion1)
        ods.Tables.Add("CONSULTA")
        oda.Fill(ods.Tables("CONSULTA"))
        DataConsultas.DataSource = ods.Tables("CONSULTA")

    End Sub

    Private Sub Consulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'abrir conexión
        abrir()

        'Carga la tabla de pacientes
        verConsul()

    End Sub

    'Mostrar datos de la tabla es su correspondiente lugar
    Private Sub DataConsultas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataConsultas.CellContentClick

        Dim i As Integer
        i = DataConsultas.CurrentRow.Index

        txtNumHistorial.Text = DataConsultas.Item(1, i).Value()
        txtNombreMedico.Text = DataConsultas.Item(2, i).Value()
        DTPFechaRealizada.Text = DataConsultas.Item(3, i).Value()
        txtMotivo.Text = DataConsultas.Item(4, i).Value()
        txtDiagnostico.Text = DataConsultas.Item(5, i).Value()
        txtTratamiento.Text = DataConsultas.Item(6, i).Value()
        txtEnfermedad.Text = DataConsultas.Item(7, i).Value()

    End Sub

    'Nueva consulta
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        'Abrir conexión
        'abrir()

        comand = New OleDbCommand("INSERT INTO CONSULTAA(idPaciente, idMedico, fechaRealizada, motivoConsulta, diagnostico, 
            tratamiento, idEnfermedad)" & " VALUES(txtNumHistorial, txtNombreMedico, DTPFechaRealizada, txtMotivo, txtDiagnostico, txtTratamiento, txtEnfermedad)", conexion1)
        comand.Parameters.AddWithValue("@idPaciente", txtNumHistorial.Text)
        comand.Parameters.AddWithValue("@idMedico", txtNombreMedico.Text)
        comand.Parameters.AddWithValue("@fechaRealizada", DTPFechaRealizada.Value.Date)
        comand.Parameters.AddWithValue("@motivoConsulta", txtMotivo.Text)
        comand.Parameters.AddWithValue("@diagnostico", txtDiagnostico.Text)
        comand.Parameters.AddWithValue("@tratamiento", txtTratamiento.Text)
        comand.Parameters.AddWithValue("@idEnfermedad", txtEnfermedad.Text)


        comand.ExecuteNonQuery()

        MsgBox("Nueva consulta agregada.", MsgBoxStyle.Information, "Información")

    End Sub

    'Borrar
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

    End Sub

    'Volver a la pestaña de INICIO
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Principal.Show()
    End Sub


End Class