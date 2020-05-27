Imports System.Data
Imports System.Data.OleDb

Public Class Consulta

    Public cadena As OleDbConnection
    Dim comand As New OleDbCommand

    'Conexión con la tabla de consultas
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

    'Botón para actualizar la tabla
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim ole As New OleDbCommand("SELECT * FROM CONSULTA", conexion1)
        Dim ds As New DataSet
        Dim dataadapter3 As New OleDbDataAdapter
        dataadapter3.SelectCommand = ole
        dataadapter3.Fill(ds, "CONSULTA")
        DataConsultas.DataSource = ds
        DataConsultas.DataMember = "CONSULTA"
    End Sub

    'Nueva consulta
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        'Abrir conexión
        'abrir()

        comand = New OleDbCommand("INSERT INTO CONSULTA(idPaciente, idMedico, fechaRealizada, motivoConsulta, diagnostico, 
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

    'Borrar consulta
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

        abrir()

        Dim eliminarRegistro As String

        DataConsultas.Rows.Remove(DataConsultas.CurrentRow)


        eliminarRegistro = "DELETE FROM CONSULTA WHERE fechaRealizada = " & Me.DTPFechaRealizada.Value & ""
        comand = New OleDbCommand(eliminarRegistro, conexion1)
        comand.ExecuteNonQuery()

        MsgBox("Eliminado corectamente.", vbInformation, "Información")

    End Sub

    'Volver a la pestaña de INICIO
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Principal.Show()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim consulta As String
        Dim oda As New OleDbDataAdapter
        Dim ods As DataSet
        Dim registro As Byte

        If txtPacientes.Text <> "" Then
            consulta = "SELECT * FROM CONSULTA WHERE idPaciente = " & txtPacientes.Text & ""
            oda = New OleDbDataAdapter(consulta, conexion1)
            ods = New DataSet
            oda.Fill(ods, "CONSULTA")
            registro = ods.Tables("CONSULTA").Rows.Count

            If registro <> 0 Then
                DataConsultas.DataSource = ods
                DataConsultas.DataMember = "CONSULTA"

                txtNumHistorial.Text = ods.Tables("CONSULTA").Rows(0).Item("idPaciente")
                txtNombreMedico.Text = ods.Tables("CONSULTA").Rows(0).Item("idMedico")
                DTPFechaRealizada.Value = ods.Tables("CONSULTA").Rows(0).Item("fechaRealizada")
                txtMotivo.Text = ods.Tables("CONSULTA").Rows(0).Item("motivoConsulta")
                txtDiagnostico.Text = ods.Tables("CONSULTA").Rows(0).Item("diagnostico")
                txtTratamiento.Text = ods.Tables("CONSULTA").Rows(0).Item("tratamiento")
                txtEnfermedad.Text = ods.Tables("CONSULTA").Rows(0).Item("idEnfermedad")

            Else
                MsgBox("No exixte el código", vbCritical, "Atención")

            End If

        End If
    End Sub

End Class