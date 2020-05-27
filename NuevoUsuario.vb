Imports System.Data
Imports System.Data.OleDb

Public Class NuevoUsuario

    'Volver a la pestaña de inicio de sesión
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub nuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuario.Clear()
        txtContrasena.Clear()
    End Sub

    'Agregar un nueva cuenta de usuario
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        'Abrir conexión
        abrir()

        Try

            comand = New OleDb.OleDbCommand("INSERT INTO USUARIOS(usuario, contrasena) VALUES(txtUsuario, txtContrasena)", conexion1)
            comand.Parameters.AddWithValue("@usuario", txtUsuario.Text)
            comand.Parameters.AddWithValue("@contrasena", txtContrasena.Text)
            comand.ExecuteNonQuery()

            MsgBox("Se ha creado una nueva cuenta de usuario.", MsgBoxStyle.Information, "Información")

            Login.Show()
            Me.Hide()

        Catch ex As Exception
            MsgBox("No se pudo agregar la cuenta de usuario. Intentelo de nuevo", MsgBoxStyle.Critical, "Atención")
        End Try

    End Sub

End Class