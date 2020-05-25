Imports System.Data.OleDb

Public Class NuevoMedico

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

    'Vuelve a la pestaña de médicos
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        VerMedicos.Show()
    End Sub

    'Agrega un nuevo médico
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        'Abrir conexión
        abrir()

        comand = New OleDbCommand("INSERT INTO MEDICOS(idMedico, Nombre, fechaNacimiento, numColegiado, sexo, telefono,
                    idEspecialidad)" & " VALUES(txtAbreviatura, txtNombre, DTPFNacimiento, txtColegiado, txtSexo, txtTelefono, cbEspecialidad)", conexion1)

        comand.Parameters.AddWithValue("@idMedico", txtAbreviatura.Text)
        comand.Parameters.AddWithValue("@Nombre", txtNombre.Text)
        comand.Parameters.AddWithValue("@fechaNaciemiento", DTPFNacimiento.Value.Date)
        comand.Parameters.AddWithValue("@numColegiado", txtColegiado.Text)
        comand.Parameters.AddWithValue("@Sexo", txtSexo.Text)
        comand.Parameters.AddWithValue("@telefono", txtTelefono.Text)
        comand.Parameters.AddWithValue("@idEspecialidad", cbEspecialidad.SelectedItem.ToString())

        comand.ExecuteNonQuery()

        MsgBox("Nuevo médico agregado.", MsgBoxStyle.Information, "Información")

        VerMedicos.Show()
        Me.Hide()

    End Sub

    Private Sub NuevoMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar()
    End Sub
End Class