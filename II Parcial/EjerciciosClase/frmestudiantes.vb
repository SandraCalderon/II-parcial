﻿Imports System.Data.SqlClient

Public Class frmestudiantes

    Public cn As SqlConnection
    Public comando As SqlCommand
    Public conexion As SqlConnection = New SqlConnection("Data Source=DESKTOP-I773KQU;Initial Catalog=estudiantes;Integrated Security=True")
    Public dr As SqlDataReader
    Public adaptador As SqlDataAdapter
    Public dt As DataTable
    Public cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet
    Public da As SqlDataAdapter

    Private Sub abrirConexion()
        Try
            cn = New SqlConnection("Data Source=DESKTOP-I773KQU;Initial Catalog=estudiantes;Integrated Security=True")
            cn.Open()
        Catch ex As Exception
            MessageBox.Show("Nose pudo abrir" + ex.ToString)
            cn.Close()
        End Try
    End Sub
    '' Private Sub llenarcomboestudiantes(ByVal dgv As ComboBox)
    ' Try
    '    adaptador = New SqlDataAdapter("Select sexo from Alumnos.Registro", cn)
    '   dt = New DataTable
    '   adaptador.Fill(dt)
    '  dgv.DataSource = dt
    '  Catch ex As Exception
    '  MessageBox.Show("no se lleno por: " + ex.ToString)
    'End Try
    ' End Sub
    Private Sub llenarDataGridEstudiantes(ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("select re.id, re.primerNombre, re.segundoNombre, re.primerApellido, re.segundoApellido, re.edad, se.nombreSexo, cl.nombreClase from Alumnos.Registro as re
inner join Alumnos.Sexo as se 
on re.sexo = se.id
inner join Alumnos.Clase as cl 
on cl.id = re.CodigoClase", cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            abrirConexion()
            llenarDataGridEstudiantes(DGestudiantes)
            conexion.Close()
            desactivar()
            '  llenarcomboestudiantes(cmbSexo)
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
    End Sub

    Private Sub desactivar()
        btnEditar.Enabled = False
        btneliminar.Enabled = False

    End Sub
    Private Sub activar()
        btnEditar.Enabled = True
        btneliminar.Enabled = True

    End Sub

    Private Sub limpiar()
        txtCodigo.Clear()
        txtPNombre.Clear()
        txtSNombre.Clear()
        txtPNombre.Clear()
        txtEdad.Clear()
        txtPApellido.Clear()
        cmbSexo.SelectedIndex = -1
        cmbClase.SelectedIndex = -1
        txtCodigo.Focus()
        desactivar()
        txtCodigo.Enabled = True
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
        cmbClase.SelectedIndex = -1
        txtSApellido.Clear()
    End Sub

    Function validarEstudiantes(ByVal codigo As String) As Boolean
        Dim respuesta As Boolean = False
        Try
            conexion.Open()
            comando = New SqlCommand("select * from Alumnos.Registro where id= '" + codigo + "'", conexion)
            dr = comando.ExecuteReader
            If dr.Read Then
                respuesta = True
                dr.Close()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try

        Return respuesta
    End Function

    Function Insertar(ByVal sql)
        conexion.Open()
        comando = New SqlCommand(sql, conexion)
        Dim i As Integer = comando.ExecuteNonQuery
        conexion.Close()

        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Try
            If (validarEstudiantes(txtCodigo.Text) = False) Then
                Dim agregar As String = "insert into Alumnos.Registro values(" + txtCodigo.Text + ",'" + txtPNombre.Text + "','" + txtSNombre.Text + "','" + txtPApellido.Text + "','" + txtSApellido.Text + "','" + txtEdad.Text + "','" + cmbSexo.Text + "', '" + cmbClase.Text + "')"
                If (Insertar(agregar)) Then
                    MessageBox.Show("Estudiante agregado correctamente!!!", "Ingreso de Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    llenarDataGridEstudiantes(DGestudiantes)
                    limpiar()
                    conexion.Close()

                Else
                    MessageBox.Show("Error al agregar el Estudiantes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    conexion.Close()
                End If
            Else
                MsgBox("Este estudinate ya existe", vbObjectError)

            End If
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        Finally
            conexion.Close()
        End Try

    End Sub
    Public Sub Consulta(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub
    Private Sub busquedaDeDatos()
        Consulta("select * from Alumnos.Registro where id= '" + txtCodigo.Text + "'", "Alumnos.Registro")
        DGestudiantes.DataSource = ds.Tables("Alumnos.Registro")
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Consulta("select * from Alumnos.Registro where id= '" + txtCodigo.Text + "'", "Alumnos.Registro")

        If (validarEstudiantes(txtCodigo.Text) = False) Then
            MessageBox.Show("Error en la busqueda, el empleado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            busquedaDeDatos()

        End If
    End Sub

    Private Sub DGestudiantes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGestudiantes.CellContentClick
        Try
            Dim dgempleados As DataGridViewRow = DGestudiantes.Rows(e.RowIndex)
            txtCodigo.Text = dgempleados.Cells(0).Value.ToString()
            txtPNombre.Text = dgempleados.Cells(1).Value.ToString()
            txtSNombre.Text = dgempleados.Cells(2).Value.ToString()
            txtPApellido.Text = dgempleados.Cells(3).Value.ToString()
            txtSApellido.Text = dgempleados.Cells(4).Value.ToString()
            txtEdad.Text = dgempleados.Cells(5).Value.ToString()
            cmbSexo.Text = dgempleados.Cells(6).Value.ToString()
            cmbClase.Text = dgempleados.Cells(7).Value.ToString()
            btneliminar.Enabled = True
            btnEditar.Enabled = True

        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        Finally
            conexion.Close()
        End Try
    End Sub

    Function modifica(ByVal tabla, ByVal campos, ByVal condicion)
        Try
            conexion.Open()
            Dim modificarE As String = "update " + tabla + " set " + campos + " where " + condicion
            comando = New SqlCommand(modificarE, conexion)
            Dim i As Integer = comando.ExecuteNonQuery()
            conexion.Close()
            If (i > 0) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)

        End Try

    End Function
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            txtCodigo.Enabled = False
            Dim modificar As String =
           "PrimerNombre='" + txtPNombre.Text + "', SegundoNombre='" + txtSNombre.Text + "', PrimerApellido='" + txtPApellido.Text + "', SegundoApellido='" + txtSApellido.Text + "', edad='" + txtEdad.Text + "',sexo='" + cmbSexo.Text + "',CodigoClase='" + cmbClase.Text + "'"
            If (modifica("Alumnos.Registro", modificar, " id=" + txtCodigo.Text)) Then
                MessageBox.Show("Actualizado")
                llenarDataGridEstudiantes(DGestudiantes)
                conexion.Close()
            Else
                MessageBox.Show("Error al actualizar")
                conexion.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        Finally
            conexion.Close()
        End Try
    End Sub

    Function eliminar(ByVal tabla, ByVal condicion)
        Try
            conexion.Open()
            Dim elimina As String = "delete from " + tabla + " where " + condicion
            comando = New SqlCommand(elimina, conexion)
            Dim i As Integer = comando.ExecuteNonQuery()
            conexion.Close()
            If (i > 0) Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MessageBox.Show("Elimine primero el empleado")
        End Try
    End Function
    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            If (eliminar("Alumnos.Registro", "id=" + txtCodigo.Text)) Then
                MessageBox.Show("Registro eliminado correctamente")
                llenarDataGridEstudiantes(DGestudiantes)

            Else
                MessageBox.Show("error al eliminar")
            End If
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
            conexion.Close()
        End Try
    End Sub
End Class
