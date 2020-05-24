Imports System.Data
Imports System.Data.OleDb

Public Class VerMedicos

    Public cadena As OleDbConnection
    Dim comand As New OleDbCommand

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

    'Eliminar médico
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        abrir()
        Dim si As Byte

        Try
            si = MsgBox("¿Estás seguro de eliminar el paciente?", vbYesNo, "Atención")

            If si = vbYes Then
                comand = New OleDbCommand("DELETE FROM MEDICOS WHERE idMedico = @idMedico", conexion1)
                comand.Parameters.AddWithValue("@idMedico", txtAbreviatura.Text)

                'comand = New OleDbCommand(eliminar, conexion1)
                comand.ExecuteNonQuery()

                MsgBox("Eliminado corectamente.", vbInformation, "Información")

            End If
        Catch ex As Exception
            MsgBox("No se pudo eliminar por el siguiente error: ", ex.Message)
        End Try
    End Sub


    'Botón para abrir ventana y agregar un medico
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.Hide()
        NuevoMedico.Show()
    End Sub

    'Cerrar la sesión
    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        End
    End Sub

    'Editar
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        On Error GoTo SaveErr
        ' MEDICOSBindingSource.EndEdit()
        ' MEDICOSTableAdapter.Update(ConsultaMedicaDataSet)
        MessageBox.Show("Paciente guardado.")
SaveErr:
        Exit Sub
    End Sub

    'Volver a la pestaña principal
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Principal.Show()
    End Sub




End Class