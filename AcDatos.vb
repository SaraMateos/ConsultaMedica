Imports System.Data
Imports System.Data.OleDb

Public Class AcDatos
    Public conectado As String

    Public Function getConnection() As OleDbConnection
        Dim connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\BASES\ConsultaMedica.accdb; Persist Security Ingo=False"
        getConnection = New OleDbConnection(connString)
    End Function
End Class
