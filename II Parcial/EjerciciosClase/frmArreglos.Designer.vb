<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArreglos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnVender = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtVender = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBucar = New System.Windows.Forms.Button()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bntRegistrar = New System.Windows.Forms.Button()
        Me.txtCantidadaIngresar = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbCompus = New System.Windows.Forms.ComboBox()
        Me.btnSolicitar = New System.Windows.Forms.Button()
        Me.txtComputadoras = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.cmbPrecios = New System.Windows.Forms.ComboBox()
        Me.btnPrecios = New System.Windows.Forms.Button()
        Me.cmbComputadoras = New System.Windows.Forms.ComboBox()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.Bidimencionales = New System.Windows.Forms.GroupBox()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Bidimencionales.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVender
        '
        Me.btnVender.Location = New System.Drawing.Point(135, 63)
        Me.btnVender.Name = "btnVender"
        Me.btnVender.Size = New System.Drawing.Size(75, 23)
        Me.btnVender.TabIndex = 4
        Me.btnVender.Text = "Vender"
        Me.btnVender.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Can. Vender"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnVender)
        Me.GroupBox4.Controls.Add(Me.txtVender)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(414, 362)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(373, 112)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Registro"
        '
        'txtVender
        '
        Me.txtVender.Location = New System.Drawing.Point(145, 28)
        Me.txtVender.Name = "txtVender"
        Me.txtVender.Size = New System.Drawing.Size(100, 20)
        Me.txtVender.TabIndex = 3
        '
        'txtCantidad
        '
        Me.txtCantidad.Enabled = False
        Me.txtCantidad.Location = New System.Drawing.Point(78, 132)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(167, 20)
        Me.txtCantidad.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Cantidad"
        '
        'txtPrecio
        '
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Location = New System.Drawing.Point(78, 97)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(167, 20)
        Me.txtPrecio.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Precio"
        '
        'txtModelo
        '
        Me.txtModelo.Enabled = False
        Me.txtModelo.Location = New System.Drawing.Point(78, 62)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(167, 20)
        Me.txtModelo.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Modelo"
        '
        'btnBucar
        '
        Me.btnBucar.Location = New System.Drawing.Point(266, 30)
        Me.btnBucar.Name = "btnBucar"
        Me.btnBucar.Size = New System.Drawing.Size(75, 23)
        Me.btnBucar.TabIndex = 4
        Me.btnBucar.Text = "Buscar"
        Me.btnBucar.UseVisualStyleBackColor = True
        '
        'txtMarca
        '
        Me.txtMarca.Enabled = False
        Me.txtMarca.Location = New System.Drawing.Point(78, 31)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(167, 20)
        Me.txtMarca.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Marca"
        '
        'bntRegistrar
        '
        Me.bntRegistrar.Location = New System.Drawing.Point(135, 63)
        Me.bntRegistrar.Name = "bntRegistrar"
        Me.bntRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.bntRegistrar.TabIndex = 4
        Me.bntRegistrar.Text = "Registrar"
        Me.bntRegistrar.UseVisualStyleBackColor = True
        '
        'txtCantidadaIngresar
        '
        Me.txtCantidadaIngresar.Location = New System.Drawing.Point(145, 28)
        Me.txtCantidadaIngresar.Name = "txtCantidadaIngresar"
        Me.txtCantidadaIngresar.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidadaIngresar.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtCantidad)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtPrecio)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtModelo)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.btnBucar)
        Me.GroupBox3.Controls.Add(Me.txtMarca)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(414, 149)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(373, 196)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Registro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Can. de Computadoras"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bntRegistrar)
        Me.GroupBox1.Controls.Add(Me.txtCantidadaIngresar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(414, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 112)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registro"
        '
        'cmbCompus
        '
        Me.cmbCompus.FormattingEnabled = True
        Me.cmbCompus.Location = New System.Drawing.Point(119, 109)
        Me.cmbCompus.Name = "cmbCompus"
        Me.cmbCompus.Size = New System.Drawing.Size(121, 21)
        Me.cmbCompus.TabIndex = 3
        '
        'btnSolicitar
        '
        Me.btnSolicitar.Location = New System.Drawing.Point(140, 62)
        Me.btnSolicitar.Name = "btnSolicitar"
        Me.btnSolicitar.Size = New System.Drawing.Size(75, 23)
        Me.btnSolicitar.TabIndex = 2
        Me.btnSolicitar.Text = "Solicitar"
        Me.btnSolicitar.UseVisualStyleBackColor = True
        '
        'txtComputadoras
        '
        Me.txtComputadoras.Location = New System.Drawing.Point(140, 24)
        Me.txtComputadoras.Name = "txtComputadoras"
        Me.txtComputadoras.Size = New System.Drawing.Size(100, 20)
        Me.txtComputadoras.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Can. de Computadoras"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbCompus)
        Me.GroupBox2.Controls.Add(Me.btnSolicitar)
        Me.GroupBox2.Controls.Add(Me.txtComputadoras)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(59, 193)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(327, 187)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dinamico"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(115, 109)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'cmbPrecios
        '
        Me.cmbPrecios.FormattingEnabled = True
        Me.cmbPrecios.Location = New System.Drawing.Point(169, 78)
        Me.cmbPrecios.Name = "cmbPrecios"
        Me.cmbPrecios.Size = New System.Drawing.Size(121, 21)
        Me.cmbPrecios.TabIndex = 3
        '
        'btnPrecios
        '
        Me.btnPrecios.Location = New System.Drawing.Point(181, 19)
        Me.btnPrecios.Name = "btnPrecios"
        Me.btnPrecios.Size = New System.Drawing.Size(83, 43)
        Me.btnPrecios.TabIndex = 2
        Me.btnPrecios.Text = "Generar Precios"
        Me.btnPrecios.UseVisualStyleBackColor = True
        '
        'cmbComputadoras
        '
        Me.cmbComputadoras.FormattingEnabled = True
        Me.cmbComputadoras.Location = New System.Drawing.Point(21, 78)
        Me.cmbComputadoras.Name = "cmbComputadoras"
        Me.cmbComputadoras.Size = New System.Drawing.Size(121, 21)
        Me.cmbComputadoras.TabIndex = 1
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(33, 19)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(83, 43)
        Me.btnGenerar.TabIndex = 0
        Me.btnGenerar.Text = "Generar Computadoras"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'Bidimencionales
        '
        Me.Bidimencionales.Controls.Add(Me.btnLimpiar)
        Me.Bidimencionales.Controls.Add(Me.cmbPrecios)
        Me.Bidimencionales.Controls.Add(Me.btnPrecios)
        Me.Bidimencionales.Controls.Add(Me.cmbComputadoras)
        Me.Bidimencionales.Controls.Add(Me.btnGenerar)
        Me.Bidimencionales.Location = New System.Drawing.Point(59, 31)
        Me.Bidimencionales.Name = "Bidimencionales"
        Me.Bidimencionales.Size = New System.Drawing.Size(327, 143)
        Me.Bidimencionales.TabIndex = 6
        Me.Bidimencionales.TabStop = False
        Me.Bidimencionales.Text = "Estatico"
        '
        'frmArreglos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 505)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Bidimencionales)
        Me.Name = "frmArreglos"
        Me.Text = "frmArreglos"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Bidimencionales.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnVender As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtVender As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBucar As Button
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents bntRegistrar As Button
    Friend WithEvents txtCantidadaIngresar As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbCompus As ComboBox
    Friend WithEvents btnSolicitar As Button
    Friend WithEvents txtComputadoras As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents cmbPrecios As ComboBox
    Friend WithEvents btnPrecios As Button
    Friend WithEvents cmbComputadoras As ComboBox
    Friend WithEvents btnGenerar As Button
    Friend WithEvents Bidimencionales As GroupBox
End Class
