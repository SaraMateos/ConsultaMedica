Imports System.Data
Imports System.Data.OleDb

Public Class VerPacientes

    'Conexión con la tabla de pacientes
    Private Sub verPacie()
        Dim oda As New OleDbDataAdapter
        Dim ods As New DataSet
        Dim consulta As String

        consulta = "Select * from PACIENTES"
        oda = New OleDbDataAdapter(consulta, conexion1)
        ods.Tables.Add("PACIENTES")
        oda.Fill(ods.Tables("PACIENTES"))
        DataPacientes.DataSource = ods.Tables("PACIENTES")

    End Sub

    Private Sub VerPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'abrir conexión
        abrir()

        'Carga la tabla de pacientes
        verPacie()

    End Sub

    'Mostrar datos de la tabla es su correspondiente lugar
    Private Sub DataPacientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataPacientes.CellContentClick

        Dim i As Integer
        i = DataPacientes.CurrentRow.Index

        txtHistorial.Text = DataPacientes.Item(0, i).Value()
        txtNIF.Text = DataPacientes.Item(1, i).Value()
        txtNombre.Text = DataPacientes.Item(2, i).Value()
        DTPFNacimiento.Text = DataPacientes.Item(3, i).Value()
        txtSexo.Text = DataPacientes.Item(4, i).Value()
        txtPoblacion.Text = DataPacientes.Item(5, i).Value()
        txtDireccion.Text = DataPacientes.Item(6, i).Value()
        txtTelefono.Text = DataPacientes.Item(7, i).Value()
        txtSangre.Text = DataPacientes.Item(8, i).Value()
        txtAltura.Text = DataPacientes.Item(9, i).Value()
        txtPeso.Text = DataPacientes.Item(10, i).Value()
        txtAlergias.Text = DataPacientes.Item(11, i).Value()
        txtObservaciones.Text = DataPacientes.Item(12, i).Value()

    End Sub

    'Botón para abrir ventana y agregar nuevo paciente
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.Hide()
        NuevoPaciente.Show()
    End Sub

    'Botón para eliminar datos de un paciente
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        abrir()
        Dim eliminarRegistro As String

        DataPacientes.Rows.Remove(DataPacientes.CurrentRow)


        eliminarRegistro = "DELETE FROM PACIENTES WHERE idPaciente = " & Me.txtHistorial.Text & ""
        comand = New OleDbCommand(eliminarRegistro, conexion1)
        comand.ExecuteNonQuery()

    End Sub

    'Actualiza la tabla
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        abrir()

        Dim oldbc As New OleDbCommand("Select * from PACIENTES", conexion1)
        Dim ds As New DataSet
        Dim adaptador As New OleDbDataAdapter
        adaptador.SelectCommand = oldbc
        adaptador.Fill(ds, "PACIENTES")
        DataPacientes.DataSource = ds
        DataPacientes.DataMember = "PACIENTES"

    End Sub

    'Botón para volver pestaña principal
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Principal.Show()
    End Sub

    'Cerrar sesión
    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        MsgBox("Cerrando aplicación.", MsgBoxStyle.Information, "Cerrando...")
        End
    End Sub

End Class