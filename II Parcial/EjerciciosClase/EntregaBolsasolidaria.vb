Public Class EntregaBolsasolidaria
    Private Identidad(10) As String
    Private contador As Integer = 0

    Private Sub Limpiar()
        txtID.Clear()
        txtNombre.Clear()
        cmbEstado.Text = ""
        txtIntegrantes.Clear()
        chkBasico.Checked = False
        chkRegular.Checked = False
        txtDepartamento.Clear()
        txtMunicipios.Clear()
        txtDireccion.Clear()

    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nombre, estado, tipoBolsa, departamento, municipios, direccion As String
        Dim NIntegrantes As Integer

        Try
            If txtNombre.Text = "" Or txtID.Text = "" Or cmbEstado.Text = "" Or txtIntegrantes.Text = "" Or txtDepartamento.Text = "" Or txtMunicipios.Text = "" Or txtDireccion.Text = "" Then
                MessageBox.Show("Debe llenar todos los campos", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            nombre = txtNombre.Text
            estado = cmbEstado.Text
            Identidad(contador) = txtID.Text

            If Identidad(contador).Length < 15 Then
                MessageBox.Show("Numero de Identidad incompleto", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtID.Focus()
                Exit Sub
            End If
            NIntegrantes = Val(txtIntegrantes.Text)
            departamento = txtDepartamento.Text
            municipios = txtMunicipios.Text
            direccion = txtDireccion.Text
            If chkBasico.Checked = True Then
                tipoBolsa = "Basica"
            Else
                tipoBolsa = "Regular"
            End If

            If contador <> 0 Then
                For i = 0 To contador - 1 Step 1
                    If Identidad(i) = Identidad(contador) Then
                        MessageBox.Show("Ya se le entrego Bolsa Solidaria a este Ciudadano", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtID.Clear()
                        txtID.Focus()
                        Exit Sub
                    End If
                Next
            End If

            DataHistorial.Rows.Add(Identidad(contador), nombre, estado, NIntegrantes, tipoBolsa, departamento, municipios, direccion)
            contador += 1
            Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub txtIntegrantes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIntegrantes.KeyPress
        Dim NIntegrantes As Integer
        NIntegrantes = Val(txtIntegrantes.Text)

        If NIntegrantes > 0 And NIntegrantes < 4 Then
            chkBasico.Checked = True
            chkRegular.Checked = False
        End If
        If NIntegrantes > 3 Then
            chkRegular.Checked = True
            chkBasico.Checked = False
        End If
        If NIntegrantes = 0 Then
            chkBasico.Checked = False
            chkRegular.Checked = False
        End If
    End Sub

    Private Sub txtIntegrantes_LostFocus(sender As Object, e As EventArgs) Handles txtIntegrantes.LostFocus
        Dim NIntegrantes As Integer
        NIntegrantes = Val(txtIntegrantes.Text)

        If NIntegrantes > 0 And NIntegrantes < 4 Then
            chkBasico.Checked = True
            chkRegular.Checked = False
        End If
        If NIntegrantes > 3 Then
            chkRegular.Checked = True
            chkBasico.Checked = False
        End If
        If NIntegrantes = 0 Then
            chkBasico.Checked = False
            chkRegular.Checked = False
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub



    Private Sub txtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If

    End Sub

    Private Sub txtDepartamento_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDepartamento.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtMunicipios_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtMunicipios.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtDireccion_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDireccion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub



    Private Sub btnAgregar_MouseHover(sender As Object, e As EventArgs) Handles btnAgregar.MouseHover
        ToolTip.SetToolTip(btnAgregar, "Agrega los datos de la persona que se le entregara la canasta")
        ToolTip.ToolTipTitle = "Envio"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnLimpiar_MouseHover(sender As Object, e As EventArgs) Handles btnLimpiar.MouseHover
        ToolTip.SetToolTip(btnLimpiar, "Limpiar todos los registros")
        ToolTip.ToolTipTitle = "Envio"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtID_MouseHover(sender As Object, e As EventArgs) Handles txtID.MouseHover
        ToolTip.SetToolTip(txtID, "Ejemplo: 0318-2004-02610")
        ToolTip.ToolTipTitle = "Identidad"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTip.SetToolTip(txtNombre, "Ejemplo: Sandra Calderon")
        ToolTip.ToolTipTitle = "Nombre"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbEstado_MouseHover(sender As Object, e As EventArgs) Handles cmbEstado.MouseHover
        ToolTip.SetToolTip(cmbEstado, "Ejemplo: Pobreza, Pobreza Extrema")
        ToolTip.ToolTipTitle = "Estado"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtIntegrantes_MouseHover(sender As Object, e As EventArgs) Handles txtIntegrantes.MouseHover
        ToolTip.SetToolTip(txtIntegrantes, "Ejemplo: 6,8,9,10")
        ToolTip.ToolTipTitle = "Numero de Integrantes"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtDepartamento_MouseHover(sender As Object, e As EventArgs) Handles txtDepartamento.MouseHover
        ToolTip.SetToolTip(txtDepartamento, "Ejemplo: Comayagua")
        ToolTip.ToolTipTitle = "Departamento"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtMunicipios_MouseHover(sender As Object, e As EventArgs) Handles txtMunicipios.MouseHover
        ToolTip.SetToolTip(txtMunicipios, "Ejemplo: Siguatepeque")
        ToolTip.ToolTipTitle = "Municipio"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtDireccion_MouseHover(sender As Object, e As EventArgs) Handles txtDireccion.MouseHover
        ToolTip.SetToolTip(txtDireccion, "Ejemplo: Barrio San Juan")
        ToolTip.ToolTipTitle = "Direccion"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub


End Class


