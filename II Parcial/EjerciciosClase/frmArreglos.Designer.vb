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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCompus = New System.Windows.Forms.ComboBox()
        Me.btnSolicitar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbPrecios = New System.Windows.Forms.ComboBox()
        Me.btnGenerarPrecio = New System.Windows.Forms.Button()
        Me.cmbComputadoras = New System.Windows.Forms.ComboBox()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtmodelo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.txtmarca = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnregistrar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtCanIngresar = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnvender = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cantidad Computadoras"
        '
        'cmbCompus
        '
        Me.cmbCompus.FormattingEnabled = True
        Me.cmbCompus.Location = New System.Drawing.Point(78, 145)
        Me.cmbCompus.Name = "cmbCompus"
        Me.cmbCompus.Size = New System.Drawing.Size(121, 21)
        Me.cmbCompus.TabIndex = 4
        '
        'btnSolicitar
        '
        Me.btnSolicitar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSolicitar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSolicitar.Location = New System.Drawing.Point(100, 102)
        Me.btnSolicitar.Name = "btnSolicitar"
        Me.btnSolicitar.Size = New System.Drawing.Size(75, 23)
        Me.btnSolicitar.TabIndex = 2
        Me.btnSolicitar.Text = "Solicitar"
        Me.btnSolicitar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Gray
        Me.GroupBox2.Controls.Add(Me.cmbCompus)
        Me.GroupBox2.Controls.Add(Me.btnSolicitar)
        Me.GroupBox2.Controls.Add(Me.txtCantidad)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(24, 172)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(338, 178)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Multidimensionales"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(171, 42)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cantidad Computadoras"
        '
        'txtcan
        '
        Me.txtcan.Location = New System.Drawing.Point(106, 94)
        Me.txtcan.Name = "txtcan"
        Me.txtcan.Size = New System.Drawing.Size(100, 20)
        Me.txtcan.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Cantidad"
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(106, 70)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(100, 20)
        Me.txtprecio.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gray
        Me.GroupBox1.Controls.Add(Me.cmbPrecios)
        Me.GroupBox1.Controls.Add(Me.btnGenerarPrecio)
        Me.GroupBox1.Controls.Add(Me.cmbComputadoras)
        Me.GroupBox1.Controls.Add(Me.btnGenerar)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(24, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 142)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Unidimensionales"
        '
        'cmbPrecios
        '
        Me.cmbPrecios.FormattingEnabled = True
        Me.cmbPrecios.Location = New System.Drawing.Point(194, 86)
        Me.cmbPrecios.Name = "cmbPrecios"
        Me.cmbPrecios.Size = New System.Drawing.Size(121, 21)
        Me.cmbPrecios.TabIndex = 3
        '
        'btnGenerarPrecio
        '
        Me.btnGenerarPrecio.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGenerarPrecio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnGenerarPrecio.Location = New System.Drawing.Point(219, 32)
        Me.btnGenerarPrecio.Name = "btnGenerarPrecio"
        Me.btnGenerarPrecio.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerarPrecio.TabIndex = 2
        Me.btnGenerarPrecio.Text = "Precio"
        Me.btnGenerarPrecio.UseVisualStyleBackColor = False
        '
        'cmbComputadoras
        '
        Me.cmbComputadoras.FormattingEnabled = True
        Me.cmbComputadoras.Location = New System.Drawing.Point(6, 86)
        Me.cmbComputadoras.Name = "cmbComputadoras"
        Me.cmbComputadoras.Size = New System.Drawing.Size(121, 21)
        Me.cmbComputadoras.TabIndex = 1
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGenerar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnGenerar.Location = New System.Drawing.Point(25, 32)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(75, 39)
        Me.btnGenerar.TabIndex = 0
        Me.btnGenerar.Text = "Generar Computador"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Precio"
        '
        'txtmodelo
        '
        Me.txtmodelo.Location = New System.Drawing.Point(106, 47)
        Me.txtmodelo.Name = "txtmodelo"
        Me.txtmodelo.Size = New System.Drawing.Size(100, 20)
        Me.txtmodelo.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Modelo"
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnbuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnbuscar.Location = New System.Drawing.Point(101, 131)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.TabIndex = 5
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'txtmarca
        '
        Me.txtmarca.Location = New System.Drawing.Point(106, 24)
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.Size = New System.Drawing.Size(100, 20)
        Me.txtmarca.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Marca"
        '
        'btnregistrar
        '
        Me.btnregistrar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnregistrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnregistrar.Location = New System.Drawing.Point(92, 71)
        Me.btnregistrar.Name = "btnregistrar"
        Me.btnregistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnregistrar.TabIndex = 5
        Me.btnregistrar.Text = "Registrar"
        Me.btnregistrar.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Gray
        Me.GroupBox3.Controls.Add(Me.btnregistrar)
        Me.GroupBox3.Controls.Add(Me.txtCanIngresar)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(372, 21)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(269, 107)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Registro"
        '
        'txtCanIngresar
        '
        Me.txtCanIngresar.Location = New System.Drawing.Point(133, 24)
        Me.txtCanIngresar.Name = "txtCanIngresar"
        Me.txtCanIngresar.Size = New System.Drawing.Size(100, 20)
        Me.txtCanIngresar.TabIndex = 5
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Gray
        Me.GroupBox4.Controls.Add(Me.txtcan)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtprecio)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtmodelo)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.btnbuscar)
        Me.GroupBox4.Controls.Add(Me.txtmarca)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox4.Location = New System.Drawing.Point(372, 143)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(269, 166)
        Me.GroupBox4.TabIndex = 38
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Registro"
        '
        'btnvender
        '
        Me.btnvender.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnvender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnvender.Location = New System.Drawing.Point(101, 89)
        Me.btnvender.Name = "btnvender"
        Me.btnvender.Size = New System.Drawing.Size(75, 23)
        Me.btnvender.TabIndex = 5
        Me.btnvender.Text = "Vender"
        Me.btnvender.UseVisualStyleBackColor = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(67, 26)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Venta"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Gray
        Me.GroupBox5.Controls.Add(Me.btnvender)
        Me.GroupBox5.Controls.Add(Me.TextBox4)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox5.Location = New System.Drawing.Point(372, 327)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Size = New System.Drawing.Size(269, 148)
        Me.GroupBox5.TabIndex = 39
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Registro"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLimpiar.Location = New System.Drawing.Point(266, 365)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(96, 23)
        Me.btnLimpiar.TabIndex = 36
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'frmArreglos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Brown
        Me.ClientSize = New System.Drawing.Size(672, 505)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnLimpiar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmArreglos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmArreglos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents cmbCompus As ComboBox
    Friend WithEvents btnSolicitar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcan As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbPrecios As ComboBox
    Friend WithEvents btnGenerarPrecio As Button
    Friend WithEvents cmbComputadoras As ComboBox
    Friend WithEvents btnGenerar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtmodelo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnbuscar As Button
    Friend WithEvents txtmarca As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnregistrar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtCanIngresar As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnvender As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnLimpiar As Button
End Class
