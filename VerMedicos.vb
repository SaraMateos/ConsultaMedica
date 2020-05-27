Imports System.Data
Imports System.Data.OleDb

Public Class VerMedicos

    'Conexión con la tabla de médicos
    Private Sub verMedic()
        Dim oda As New OleDbDataAdapter
        Dim ods As New DataSet
        Dim consulta As String

        consulta = "SELECT * FROM MEDICOS"
        oda = New OleDbDataAdapter(consulta, conexion1)
        ods.Tables.Add("MEDICOS")
        oda.Fill(ods.Tables("MEDICOS"))
        DataMedicos.DataSource = ods.Tables("MEDICOS")

    End Sub

    Private Sub verMedicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'abrir conexión
        abrir()

        'Carga la tabla de pacientes
        verMedic()

    End Sub

    'Mostrar datos de la tabla es su correspondiente lugar
    Private Sub DataMedicos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataMedicos.CellContentClick

        Dim i As Integer
        i = DataMedicos.CurrentRow.Index

        txtAbreviatura.Text = DataMedicos.Item(0, i).Value()
        txtNombre.Text = DataMedicos.Item(1, i).Value()
        DTPFNacimiento.Text = DataMedicos.Item(2, i).Value()
        txtColegiado.Text = DataMedicos.Item(3, i).Value()
        txtSexo.Text = DataMedicos.Item(4, i).Value()
        txtTelefono.Text = DataMedicos.Item(5, i).Value()
        txtEspecialidad.Text = DataMedicos.Item(6, i).Value()

    End Sub

    'Borrar datos de un médico
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        abrir()

        Dim eliminarRegistro As String

        DataMedicos.Rows.Remove(DataMedicos.CurrentRow)


        eliminarRegistro = "DELETE FROM MEDICOS WHERE numColegiado = " & Me.txtColegiado.Text & ""
        comand = New OleDbCommand(eliminarRegistro, conexion1)
        comand.ExecuteNonQuery()

        MsgBox("Eliminado correctamente.", vbInformation, "Información")

    End Sub


    'Botón para abrir ventana y agregar un medico
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.Hide()
        NuevoMedico.Show()
    End Sub

    'Actualiza la tabla
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        abrir()
        Dim oldbc As New OleDbCommand("SELECT * FROM MEDICOS", conexion1)
        Dim ds As New DataSet
        Dim adaptador As New OleDbDataAdapter
        adaptador.SelectCommand = oldbc
        adaptador.Fill(ds, "MEDICOS")
        DataMedicos.DataSource = ds
        DataMedicos.DataMember = "MEDICOS"

    End Sub

    'Volver a la pestaña principal
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Principal.Show()
    End Sub

    'Cerrar la sesión
    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        MsgBox("Cerrando aplicación.", MsgBoxStyle.Information, "Cerrando...")
        End
    End Sub

End Class