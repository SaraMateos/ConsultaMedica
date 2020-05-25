Imports System.Data
Imports System.Data.OleDb
Imports System.Net.Http.Headers

Public Class VerPacientes

    Public cadena As OleDbConnection
    Dim comand As New OleDbCommand

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


    'Actualizar
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        abrir()
        ' Me.PACIENTESTableAdapter.UpdateQuery(txtHistorial.Text, txtNIF.Text, txtNombre.Text, DTPFNacimiento.Value.Date, txtSexo.Text, txtPoblacion.Text,
        'Dim si As Byte

        'Try
        'si = MsgBox("¿Estás seguro de modificar el paciente?", vbYesNo, "Atención")
        '
        'If si = vbYes Then
        'PACIENTESBindingSource.EndEdit()
        'PACIENTESTableAdapter.Update((ConsultaMedicaDataSet.PACIENTES))

        'comand = New OleDbCommand("UPDATE PACIENTES SET idPaciente = txtHistorial, NIF = txtNIF, Nombre = txtNombre, fechaNacimiento = DTPFNacimiento, sexo= txtSexo, Poblacion= txtpoblacion,
        '                   dirección =  txtDireccion, teléfono = txtTelefono, TipoGrupoSanguineo = txtSangre, altura = txtAltura, peso = txtPeso, 
        '                  alergias = txtAlergias, observaciones = txtObservaciones WHERE idPaciente = @idPaciente", conexion1)
        'comand.Parameters.AddWithValue("@NIF", txtNIF.Text)
        'comand.Parameters.AddWithValue("@Nombre", txtNombre.Text)
        'comand.Parameters.AddWithValue("@fechaNaciemiento", DTPFNacimiento.Value.Date)
        'comand.Parameters.AddWithValue("@Sexo", txtSexo.Text)
        'comand.Parameters.AddWithValue("@Poblacion", txtPoblacion.Text)
        'comand.Parameters.AddWithValue("@dirección", txtDireccion.Text)
        'comand.Parameters.AddWithValue("@teléfono", txtTelefono.Text)
        'comand.Parameters.AddWithValue("@TipoGrupoSanguineo", txtSangre.Text)
        'comand.Parameters.AddWithValue("@altura", txtAltura.Text)
        'comand.Parameters.AddWithValue("@peso", txtPeso.Text)
        'comand.Parameters.AddWithValue("@alergias", txtAlergias.Text)
        'comand.Parameters.AddWithValue("@observaciones", txtObservaciones.Text)
        'comand.Parameters.AddWithValue("@idPaciente", txtHistorial.Text)
        '
        'comand.ExecuteNonQuery()


        'MsgBox("Datos del paciente actualizados", MsgBoxStyle.Information, "Información")
        'Else
        'MsgBox("Se cancelo la actualización", MsgBoxStyle.Information, "Información")

        'End If
        'Catch ex As Exception
        'MsgBox("No se pudo actualizar por el siguiente error: " + vbCrLf + ex.Message, vbCritical, "Atención")
        'End Try

    End Sub

    'Pasar al paciente anterior
    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        'PACIENTESBindingSource.MovePrevious()

        ' Dim actual As Integer = DataPacientes.CurrentCell.RowIndex
        'Dim atras As Integer = actual - 1

        'Try
        'If atras >= 0 Then
        'DataPacientes.CurrentCell = DataPacientes.Rows(atras).Cells(0)
        'DataPacientes.Rows(atras).Selected = True
        'Else
        'MsgBox("has llegado al primer paciente: ", MsgBoxStyle.Critical, "Advertencia")
        'End If
        'Catch ex As Exception
        'MsgBox("Error: " & ex.Message)
        'End Try

    End Sub

    'Pasar al siguiente paciente
    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        'PACIENTESBindingSource.MoveNext()

        ' Dim actual As Integer = DataPacientes.CurrentCell.RowIndex
        'Dim siguiente As Integer = actual + 1

        'Try
        'If DataPacientes.Rows.Count > siguiente Then
        'DataPacientes.CurrentCell = DataPacientes.Rows(siguiente).Cells(0)
        'DataPacientes.Rows(siguiente).Selected = True
        'Else
        'MsgBox("has llegado al ultimo paciente: ", MsgBoxStyle.Critical, "Advertencia")
        'End If
        'Catch ex As Exception
        'MsgBox("Error: " & ex.Message)
        'End Try

    End Sub


    'Botón para volver pestaña principal
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Principal.Show()
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        MsgBox("Cerrando aplicación.", MsgBoxStyle.Information, "Cerrando...")
        End
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim consulta As String
        Dim oda As New OleDbDataAdapter
        Dim ods As DataSet
        Dim registro As Byte

        If txtNomPaciente.Text <> "" Then
            consulta = "SELECT * FROM PACIENTES WHERE Nombre = " & txtNomPaciente.Text & ""
            oda = New OleDbDataAdapter(consulta, conexion1)
            ods = New DataSet
            oda.Fill(ods, "PACIENTES")
            registro = ods.Tables("PACIENTES").Rows.Count

            If registro <> 0 Then
                DataPacientes.DataSource = ods
                DataPacientes.DataMember = "PACIENTES"

                txtHistorial.Text = ods.Tables("PACIENTES").Rows(0).Item("idPaciente")
                txtNIF.Text = ods.Tables("PACIENTES").Rows(0).Item("NIF")
                txtNombre.Text = ods.Tables("PACIENTES").Rows(0).Item("Nombre")
                DTPFNacimiento.Value = ods.Tables("PACIENTES").Rows(0).Item("fechaNacimiento")
                txtSexo.Text = ods.Tables("PACIENTES").Rows(0).Item("sexo")
                txtPoblacion.Text = ods.Tables("PACIENTES").Rows(0).Item("Poblacion")
                txtDireccion.Text = ods.Tables("PACIENTES").Rows(0).Item("dirección")
                txtTelefono.Text = ods.Tables("PACIENTES").Rows(0).Item("teléfono")
                txtSangre.Text = ods.Tables("PACIENTES").Rows(0).Item("TipoGrupoSanguineo")
                txtAltura.Text = ods.Tables("PACIENTES").Rows(0).Item("altura")
                txtPeso.Text = ods.Tables("PACIENTES").Rows(0).Item("peso")
                txtAlergias.Text = ods.Tables("PACIENTES").Rows(0).Item("alergias")
                txtObservaciones.Text = ods.Tables("PACIENTES").Rows(0).Item("observaciones")

            Else
                MsgBox("No exixte el código", vbCritical, "Atención")
            End If

        End If
    End Sub
End Class