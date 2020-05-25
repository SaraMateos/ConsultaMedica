Imports System.Data
Imports System.Data.OleDb

Public Class VerMedicos

    Public cadena As OleDbConnection
    Dim comand As New OleDbCommand

    Sub llenar()
        'Llenar el ComboBox
        Dim da As New OleDbDataAdapter()
        Dim dt As New DataTable

        Try
            da = New OleDbDataAdapter("SELECT * FROM MEDICOS", conexion1)
            da.Fill(dt)
            cbEspecialidad.DataSource = dt
            cbEspecialidad.DisplayMember = "idEspecialidad"
            cbEspecialidad.ValueMember = "idEspecialidad"

        Catch ex As Exception

        End Try
    End Sub


    'Conexión con la tabla de pacientes
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

        'Llenar el ComboBox
        llenar()

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
        cbEspecialidad.Text = DataMedicos.Item(6, i).Value()

    End Sub

    'Borrar datos de un médico
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        abrir()

        Dim eliminarRegistro As String

        DataMedicos.Rows.Remove(DataMedicos.CurrentRow)


        eliminarRegistro = "DELETE FROM MEDICOS WHERE idMedico = " & Me.txtAbreviatura.Text & ""
        comand = New OleDbCommand(eliminarRegistro, conexion1)
        comand.ExecuteNonQuery()

        MsgBox("Eliminado corectamente.", vbInformation, "Información")

    End Sub


    'Botón para abrir ventana y agregar un medico
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.Hide()
        NuevoMedico.Show()
    End Sub

    'Cerrar la sesión
    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        MsgBox("Cerrando aplicación.", MsgBoxStyle.Information, "Cerrando...")
        End
    End Sub

    'Editar
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        abrir()
        Dim si As Byte

        Try
            si = MsgBox("¿Estás seguro de modificar el paciente?", vbYesNo, "Atención")

            If si = vbYes Then

                comand = New OleDbCommand("UPDATE INTO MEDICOS(idMedico = txtAbreviatura, Nombre = txtNombre, fechaNacimiento= DTPFNacimiento, numColegiado =txtColegiado, sexo=txtSexo, telefono=txtTelefono,
                    idEspecialidad=cbEspecialidad)", conexion1)

                comand.Parameters.AddWithValue("@idMedico", txtAbreviatura.Text)
                comand.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                comand.Parameters.AddWithValue("@fechaNaciemiento", DTPFNacimiento.Value.Date)
                comand.Parameters.AddWithValue("@numColegiado", txtColegiado.Text)
                comand.Parameters.AddWithValue("@Sexo", txtSexo.Text)
                comand.Parameters.AddWithValue("@telefono", txtTelefono.Text)
                comand.Parameters.AddWithValue("@idEspecialidad", cbEspecialidad.Text)

                comand.ExecuteNonQuery()

                MsgBox("Nuevo médico agregado.", MsgBoxStyle.Information, "Información")
            Else
                MsgBox("Se cancelo la actualización", MsgBoxStyle.Information, "Información")

            End If
        Catch ex As Exception
            MsgBox("No se pudo actualizar por el siguiente error: " + vbCrLf + ex.Message, vbCritical, "Atención")
        End Try

    End Sub

    'Volver a la pestaña principal
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Principal.Show()
    End Sub

    'Ver datos del anterior médico
    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        MEDICOSBindingSource.MovePrevious()

        Dim actual As Integer = DataMedicos.CurrentCell.RowIndex
        Dim atras As Integer = actual - 1

        Try
            If atras >= 0 Then
                DataMedicos.CurrentCell = DataMedicos.Rows(atras).Cells(0)
                DataMedicos.Rows(atras).Selected = True
            Else
                MsgBox("has llegado al primer paciente: ", MsgBoxStyle.Critical, "Advertencia")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    'Ver datos del siguiente médico
    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        'MEDICOSBindingSource.MoveNext()

        'Dim actual As Integer = DataMedicos.CurrentCell.RowIndex
        'Dim siguiente As Integer = actual + 1

        'Try
        'If DataMedicos.Rows.Count > siguiente Then
        'DataMedicos.CurrentCell = DataMedicos.Rows(siguiente).Cells(0)
        'DataMedicos.Rows(siguiente).Selected = True
        'Else
        'MsgBox("has llegado al ultimo paciente: ", MsgBoxStyle.Critical, "Advertencia")
        'End If
        'Catch ex As Exception
        'MsgBox("Error: " & ex.Message)
        'End Try
    End Sub


End Class