Public Class frmArreglos
    Private mcomputadoras(,) As String
    Private cantComputadoras As Integer
    Private index As Integer
    Private encuentra As Boolean = False



    Private Sub arreglos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtmodelo.Enabled = False
        txtprecio.Enabled = False
        txtcan.Enabled = False
        btnvender.Enabled = False
        btnbuscar.Enabled = False
        txtmarca.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnvender.Click
        Dim cantvender, stock As Integer
        cantvender = Val(TextBox4.Text)
        stock = mcomputadoras(index, 3)
        If (cantvender >= stock) Then
            MessageBox.Show("Sin Stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            mcomputadoras(index, 3) = stock - cantvender
            MessageBox.Show("Venta Realizada", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtcan.Text = mcomputadoras(index, 3)
        End If

    End Sub

    Private Sub btnregistrar_Click(sender As Object, e As EventArgs) Handles btnregistrar.Click
        cantComputadoras = Val(txtCanIngresar.Text)
        ReDim mcomputadoras(cantComputadoras, 3)
        '3x3= comienza a contar desde 0
        For i = 0 To (cantComputadoras - 1) Step 1
            mcomputadoras(i, 0) = InputBox("Ingrese la marca N." & (i + 1), "Registro")
            mcomputadoras(i, 1) = InputBox("Ingrese el modelo N." & (i + 1), "Registro")
            mcomputadoras(i, 2) = InputBox("Ingrese el precio N." & (i + 1), "Registro")
            mcomputadoras(i, 3) = InputBox("Ingrese la cantidad N." & (i + 1), "Registro")

        Next
        txtmarca.Enabled = True
        btnbuscar.Enabled = True
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click

        Dim marca As String = txtmarca.Text
        If txtmarca.Text <> String.Empty Then

            For i = 0 To (cantComputadoras - 1) Step 1
                If (mcomputadoras(i, 0) = marca) Then
                    txtmodelo.Text = mcomputadoras(i, 1)
                    txtprecio.Text = mcomputadoras(i, 2)
                    txtcan.Text = mcomputadoras(i, 3)
                    encuentra = True
                    btnvender.Enabled = True
                    btnbuscar.Enabled = True
                End If
            Next
            If (encuentra = False) Then
                MessageBox.Show("No existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MsgBox("Ingrese los valores correspondientes")
        End If


    End Sub


    Private Sub txtCanIngresar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCanIngresar.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub txtcan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcan.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim computadoras(3) As String
        computadoras(0) = "Toshiba"
        computadoras(1) = "Dell"
        computadoras(2) = "Asus"
        computadoras(3) = "MAC"
        For i = 0 To (computadoras.Length - 1) Step 1
            cmbComputadoras.Items.Add(computadoras(i))
        Next

    End Sub

    Private Sub btnGenerarPrecio_Click(sender As Object, e As EventArgs) Handles btnGenerarPrecio.Click
        Dim precio(3) As Integer
        precio(0) = 22500
        precio(1) = 21000
        precio(2) = 29000
        precio(3) = 42000
        For i = 0 To (precio.Length - 1) Step 1
            cmbPrecios.Items.Add(precio(i))
        Next
    End Sub

    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        Dim cant As Integer
        Dim comp() As String
        'Asignar tamaño
        cant = Val(txtCantidad.Text)
        ReDim comp(cant)
        'Solicitar la informacion
        For i = 0 To (cant - 1) Step 1
            comp(i) = InputBox("Ingrese la marca de la pc", "Ingreso")
        Next
        'Mostrar la informacion
        For j = 0 To (cant - 1) Step 1
            cmbCompus.Items.Add(comp(j))
        Next
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        cmbComputadoras.Items.Clear()
        cmbPrecios.Items.Clear()
        cmbCompus.Items.Clear()
        cmbPrecios.Items.Clear()
        txtcan.Clear()
        txtCanIngresar.Clear()
        txtCantidad.Clear()
        txtCanIngresar.Clear()
        TextBox4.Clear()
        txtmarca.Clear()
        txtmodelo.Clear()
        txtprecio.Clear()

    End Sub
End Class