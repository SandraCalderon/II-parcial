Public Class frmArreglos
    Private mComputadoras(,) As String
    Private cantcomputadoras As Integer
    Private index As Byte
    Private encuentra As Boolean = False
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim computadoras(3) As String
        computadoras(0) = "Toshiba"
        computadoras(1) = "Dell"
        computadoras(2) = "ASUS"
        computadoras(3) = "Mac"

        For i = 0 To (computadoras.Length - 1) Step 1
            cmbComputadoras.Items.Add(computadoras(i))
        Next
    End Sub

    Private Sub btnPrecios_Click(sender As Object, e As EventArgs) Handles btnPrecios.Click
        Dim Precio(3) As Integer
        Precio(0) = 22500
        Precio(1) = 21000
        Precio(2) = 29000
        Precio(3) = 42000

        For i = 0 To (Precio.Length - 1) Step 1
            cmbPrecios.Items.Add(Precio(i))
        Next
    End Sub

    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        Dim cantidad As Integer
        Dim compu() As String

        cantidad = Val(txtComputadoras.Text)
        ReDim compu(cantidad)

        'For i = 0 To cantidad Step 1
        For i = 0 To (compu.Length - 1) Step 1
            compu(i) = InputBox("Ingrese la marca de la PC", "Ingreso")
        Next

        'For j = 0 To cantidad Step 1
        For j = 0 To (compu.Length - 1) Step 1
            cmbCompus.Items.Add(compu(j))
        Next


    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        cmbComputadoras.Items.Clear()
        cmbPrecios.Items.Clear()
    End Sub

    Private Sub FRMArreglos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtModelo.Visible = False
        txtPrecio.Visible = False
        txtCantidad.Visible = False
        btnVender.Visible = False
        btnBucar.Visible = False
        txtMarca.Visible = False


    End Sub

    Private Sub bntRegistrar_Click(sender As Object, e As EventArgs) Handles bntRegistrar.Click
        cantcomputadoras = Val(txtCantidadaIngresar.Text)
        ReDim mComputadoras(cantcomputadoras, 3)
        'siempre se le resta 1 al valor cantidad porque inicia desd 0
        ' 3X3 comienza desde 0
        For i = 0 To (cantcomputadoras - 1) Step 1
            mComputadoras(i, 0) = InputBox("Ingrese la marca No." & (i + 1), "Registro")
            mComputadoras(i, 1) = InputBox("Ingrese la modelo No." & (i + 1), "Registro")
            mComputadoras(i, 2) = InputBox("Ingrese la precio No." & (i + 1), "Registro")
            mComputadoras(i, 3) = InputBox("Ingrese la cantidad No." & (i + 1), "Registro")

        Next
    End Sub

    Private Sub btnBucar_Click(sender As Object, e As EventArgs) Handles btnBucar.Click
        Dim marca As String
        marca = Val(txtMarca.Text)

        For i = 0 To (cantcomputadoras - 1) Step 1
            If (mComputadoras(i, 0) = marca) Then
                txtModelo.Text = mComputadoras(i, 1)
                txtPrecio.Text = mComputadoras(1, 2)
                txtCantidad.Text = mComputadoras(i, 3)
                encuentra = True
                btnVender.Enabled = True
                btnBucar.Enabled = True

            End If
        Next

        If (encuentra = False) Then
            MessageBox.Show("No existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class