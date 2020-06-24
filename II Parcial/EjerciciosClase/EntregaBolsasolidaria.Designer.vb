<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EntregaBolsasolidaria
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.chkBasico = New System.Windows.Forms.CheckBox()
        Me.txtIntegrantes = New System.Windows.Forms.MaskedTextBox()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtMunicipios = New System.Windows.Forms.TextBox()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.chkRegular = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtID = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataHistorial = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NIntegrantes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBolsa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Departamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Municipios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkBasico
        '
        Me.chkBasico.AutoSize = True
        Me.chkBasico.Enabled = False
        Me.chkBasico.Location = New System.Drawing.Point(241, 61)
        Me.chkBasico.Margin = New System.Windows.Forms.Padding(2)
        Me.chkBasico.Name = "chkBasico"
        Me.chkBasico.Size = New System.Drawing.Size(58, 17)
        Me.chkBasico.TabIndex = 14
        Me.chkBasico.Text = "Basica"
        Me.chkBasico.UseVisualStyleBackColor = True
        '
        'txtIntegrantes
        '
        Me.txtIntegrantes.Location = New System.Drawing.Point(103, 59)
        Me.txtIntegrantes.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIntegrantes.Mask = "99"
        Me.txtIntegrantes.Name = "txtIntegrantes"
        Me.txtIntegrantes.Size = New System.Drawing.Size(33, 20)
        Me.txtIntegrantes.TabIndex = 13
        Me.txtIntegrantes.ValidatingType = GetType(Integer)
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Pobreza", "Pobreza Extrema", "", ""})
        Me.cmbEstado.Location = New System.Drawing.Point(328, 20)
        Me.cmbEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(110, 21)
        Me.cmbEstado.TabIndex = 8
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(171, 152)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(68, 24)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(383, 99)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Dirección:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(189, 99)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Municipios:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 99)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Departamentos:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(158, 62)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Tipo de Bolsa:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtNombre)
        Me.GroupBox3.Controls.Add(Me.btnLimpiar)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtDireccion)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtMunicipios)
        Me.GroupBox3.Controls.Add(Me.txtDepartamento)
        Me.GroupBox3.Controls.Add(Me.chkRegular)
        Me.GroupBox3.Controls.Add(Me.chkBasico)
        Me.GroupBox3.Controls.Add(Me.txtIntegrantes)
        Me.GroupBox3.Controls.Add(Me.cmbEstado)
        Me.GroupBox3.Controls.Add(Me.btnAgregar)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(248, 11)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(662, 190)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Familiares"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(53, 21)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(208, 20)
        Me.txtNombre.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 23)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Nombre:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(439, 96)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(195, 44)
        Me.txtDireccion.TabIndex = 18
        '
        'txtMunicipios
        '
        Me.txtMunicipios.Location = New System.Drawing.Point(253, 96)
        Me.txtMunicipios.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMunicipios.Name = "txtMunicipios"
        Me.txtMunicipios.Size = New System.Drawing.Size(116, 20)
        Me.txtMunicipios.TabIndex = 17
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Location = New System.Drawing.Point(90, 96)
        Me.txtDepartamento.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.Size = New System.Drawing.Size(95, 20)
        Me.txtDepartamento.TabIndex = 16
        '
        'chkRegular
        '
        Me.chkRegular.AutoSize = True
        Me.chkRegular.Enabled = False
        Me.chkRegular.Location = New System.Drawing.Point(328, 62)
        Me.chkRegular.Margin = New System.Windows.Forms.Padding(2)
        Me.chkRegular.Name = "chkRegular"
        Me.chkRegular.Size = New System.Drawing.Size(63, 17)
        Me.chkRegular.TabIndex = 15
        Me.chkRegular.Text = "Regular"
        Me.chkRegular.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "N. de Integrantes:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(279, 23)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Estado:"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(254, 152)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(68, 24)
        Me.btnLimpiar.TabIndex = 19
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 45)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(236, 93)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Jefe de Familia"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(83, 28)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtID.Mask = "0000-0000-00000"
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(94, 20)
        Me.txtID.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        '
        'DataHistorial
        '
        Me.DataHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataHistorial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Id, Me.Estado, Me.NIntegrantes, Me.TBolsa, Me.Departamento, Me.Municipios, Me.Direccion})
        Me.DataHistorial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataHistorial.Location = New System.Drawing.Point(2, 15)
        Me.DataHistorial.Margin = New System.Windows.Forms.Padding(2)
        Me.DataHistorial.Name = "DataHistorial"
        Me.DataHistorial.RowHeadersWidth = 51
        Me.DataHistorial.RowTemplate.Height = 24
        Me.DataHistorial.Size = New System.Drawing.Size(895, 287)
        Me.DataHistorial.TabIndex = 0
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "ID"
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 80
        '
        'Id
        '
        Me.Id.HeaderText = "Nombre"
        Me.Id.MinimumWidth = 6
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.MinimumWidth = 6
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Width = 80
        '
        'NIntegrantes
        '
        Me.NIntegrantes.HeaderText = "N. Integran"
        Me.NIntegrantes.MinimumWidth = 6
        Me.NIntegrantes.Name = "NIntegrantes"
        Me.NIntegrantes.ReadOnly = True
        Me.NIntegrantes.Width = 70
        '
        'TBolsa
        '
        Me.TBolsa.HeaderText = "T. Bolsa"
        Me.TBolsa.MinimumWidth = 6
        Me.TBolsa.Name = "TBolsa"
        Me.TBolsa.ReadOnly = True
        Me.TBolsa.Width = 71
        '
        'Departamento
        '
        Me.Departamento.HeaderText = "Departamento"
        Me.Departamento.MinimumWidth = 6
        Me.Departamento.Name = "Departamento"
        Me.Departamento.ReadOnly = True
        Me.Departamento.Width = 90
        '
        'Municipios
        '
        Me.Municipios.HeaderText = "Municipios"
        Me.Municipios.MinimumWidth = 6
        Me.Municipios.Name = "Municipios"
        Me.Municipios.ReadOnly = True
        Me.Municipios.Width = 90
        '
        'Direccion
        '
        Me.Direccion.HeaderText = "Dirección"
        Me.Direccion.MinimumWidth = 6
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        Me.Direccion.Width = 90
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataHistorial)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 216)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(899, 304)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Historial"
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'EntregaBolsasolidaria
        '
        Me.AcceptButton = Me.btnAgregar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 539)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EntregaBolsasolidaria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EntregaBolsasolidaria"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents chkBasico As CheckBox
    Friend WithEvents txtIntegrantes As MaskedTextBox
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtMunicipios As TextBox
    Friend WithEvents txtDepartamento As TextBox
    Friend WithEvents chkRegular As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtID As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataHistorial As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents NIntegrantes As DataGridViewTextBoxColumn
    Friend WithEvents TBolsa As DataGridViewTextBoxColumn
    Friend WithEvents Departamento As DataGridViewTextBoxColumn
    Friend WithEvents Municipios As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents ErrorValidacion As ErrorProvider
End Class
