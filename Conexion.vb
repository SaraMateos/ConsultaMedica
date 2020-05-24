Imports System.Data
Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Imports System.Runtime.Serialization

Module Conexion

    Public conexion1 As OleDbConnection = New OleDbConnection
    Public cadenaconexion As String
    Public comand As New OleDbCommand

    Sub abrir()

        Try
            cadenaconexion = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\BASES\ConsultaMedica.accdb")
            conexion1.Close()

            conexion1.ConnectionString = cadenaconexion
            conexion1.Open()
            MsgBox("ok")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

End Module