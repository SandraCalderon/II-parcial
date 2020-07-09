Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class conexion

    Public conexion As SqlConnection = New SqlConnection("Data Source=DESKTOP-I773KQU;Initial Catalog=Tienda;Integrated Security=True")
    Public cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public dr As SqlDataReader

    Public Sub conectar()
        Try
            conexion.Open()
        Catch ex As Exception
        Finally
            conexion.Close()
        End Try
    End Sub


End Class

