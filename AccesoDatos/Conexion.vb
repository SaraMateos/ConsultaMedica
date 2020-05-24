Imports System.Data
Imports System.Data.OleDb

Module Conexion

    Public conexion As New OleDbConnection
    Public estado As String
    Public comm As New OleDbCommand

    Sub enlazar()

        Try
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\BASES\ConsultaMedica.accdb"
            conexion.Open()
            estado = "conectado"
        Catch ex As Exception
            estado = "desconectado"
        End Try

    End Sub
End Module