Public Class frmLibretadeAhorros
    'variables globales
    Private monto As Double
    'procedimientos
    Private Sub activarControles()
        txtNombre.Enabled = False
        txtMonto.Enabled = False
        btnAperturar.Enabled = False
        btnRetirar.Enabled = True
        btnDepositar.Enabled = True

    End Sub

    Private Sub desactivarControles()
        txtNombre.Enabled = True
        txtMonto.Enabled = True
        btnAperturar.Enabled = True
        btnRetirar.Enabled = False
        btnDepositar.Enabled = False
    End Sub

    Private Sub limpiar()
        desactivarControles()
        txtMonto.Clear()
        txtNombre.Clear()
        txtSaldo.Clear()
        lslDepositos.Items.Clear()
        lslRetiros.Items.Clear()

    End Sub

    Private Sub frmLibretadeAhorros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivarControles()
    End Sub
    Private Sub mostrarSaldo()
        txtSaldo.Text = monto
    End Sub

    Private Sub btnAperturar_Click(sender As Object, e As EventArgs) Handles btnAperturar.Click
        Dim cliente As String
        cliente = Val(txtNombre.Text)
        monto = Val(txtMonto.Text)
        If (monto > 0) Then
            activarControles()
            mostrarSaldo()
        Else

            MessageBox.Show("Monto mayor a 0", "Ingresar monto correcto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Function leer(mensaje As String)
        Dim cantidad As Double
        cantidad = InputBox("Ingrese un monto a " & mensaje, "Operaciones")
        mostrarSaldo()
        Return cantidad
    End Function

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub btnDepositar_Click(sender As Object, e As EventArgs) Handles btnDepositar.Click
        Dim deposito As Double
        deposito = leer("Depositar")
        monto += deposito
        lslDepositos.Items.Add(deposito)
        mostrarSaldo()
    End Sub

    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click
        Dim retirar As Double
        retirar = leer("Retirar")
        If (retirar > monto) Then
            MessageBox.Show("Saldo insuficiente", "Deposite mas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            monto -= retirar
            lslRetiros.Items.Add(retirar)
            mostrarSaldo()

        End If
    End Sub
End Class