Imports System.Data
Imports System.Data.OleDb

Public Class NuevoPaciente

    'Volver a la pestaña de todos los pacientes
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        VerPacientes.Show()
    End Sub

    'Agregar un nuevo paciente
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        'Abrir conexión
        abrir()

        comand = New OleDbCommand("INSERT INTO PACIENTES(NIF, Nombre, fechaNacimiento, sexo, Poblacion, dirección, teléfono,
                    TipoGrupoSanguineo, altura, peso, alergias, observaciones)" & " VALUES(txtNIF, txtNombre, DTPFNacimiento, txtSexo, txtPoblacion, txtDireccion, 
                        txtTelefono, txtPeso, txtAltura, txtSangre, txtxAlergias, txtObservaciones)", conexion1)
        comand.Parameters.AddWithValue("@NIF", txtNIF.Text)
        comand.Parameters.AddWithValue("@Nombre", txtNombre.Text)
        comand.Parameters.AddWithValue("@fechaNaciemiento", DTPFNacimiento.Value.Date)
        comand.Parameters.AddWithValue("@Sexo", txtSexo.Text)
        comand.Parameters.AddWithValue("@Poblacion", txtPoblacion.Text)
        comand.Parameters.AddWithValue("@dirección", txtDireccion.Text)
        comand.Parameters.AddWithValue("@teléfono", txtTelefono.Text)
        comand.Parameters.AddWithValue("@TipoGrupoSanguineo", txtSangre.Text)
        comand.Parameters.AddWithValue("@altura", txtAltura.Text)
        comand.Parameters.AddWithValue("@peso", txtPeso.Text)
        comand.Parameters.AddWithValue("@alergias", txtAlergias.Text)
        comand.Parameters.AddWithValue("@observaciones", txtObservaciones.Text)

        comand.ExecuteNonQuery()

        MsgBox("Nuevo paciente agregado.", MsgBoxStyle.Information, "Información")

        VerPacientes.Show()
        Me.Hide()
    End Sub

End Class