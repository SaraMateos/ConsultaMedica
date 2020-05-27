Imports System.Data
Imports System.Data.OleDb

Public Class Login

    ReadOnly conn As New OleDbConnection(My.Settings.ConsultaMedicaConnectionString)

    'Añadir nueva cuenta de usuario
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Me.Hide()
        NuevoUsuario.Show()
    End Sub

    'Iniciar sesión
    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        'Verificar si el usuario es apto o no
        If txtUsuario.Text = Nothing Or txtContrasena.Text = Nothing Then
            MessageBox.Show("Por favor introduce los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using Command As New OleDbCommand("SELECT COUNT(*) FROM USUARIOS WHERE usuario = @usuario AND contrasena = @contrasena", conn)
            Command.Parameters.AddWithValue("@usuario", OleDbType.VarChar).Value = txtUsuario.Text.Trim
            Command.Parameters.AddWithValue("@contrasena", OleDbType.VarChar).Value = txtContrasena.Text.Trim

            Dim count = Convert.ToInt32(Command.ExecuteScalar())

            If count > 0 Then
                MsgBox("Sesión iniciada.", vbInformation, "Información")
                Me.Hide()
                Principal.Show()
            Else
                MsgBox("Oops! Datos incorrectos.", MessageBoxIcon.Error, "Atención")
            End If

        End Using
    End Sub

    'Salir
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        MsgBox("Cerrando aplicación.", MsgBoxStyle.Information, "Cerrando...")
        End
    End Sub

End Class