<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerMedicos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VerMedicos))
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.GBDatosPersonales = New System.Windows.Forms.GroupBox()
        Me.cbEspecialidad = New System.Windows.Forms.ComboBox()
        Me.MEDICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsultaMedicaDataSet = New WindowsApp1.ConsultaMedicaDataSet()
        Me.txtSexo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTPFNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblEspecialidad = New System.Windows.Forms.Label()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.txtAbreviatura = New System.Windows.Forms.TextBox()
        Me.lblAbreviatura = New System.Windows.Forms.Label()
        Me.lblNumColegiado = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataMedicos = New System.Windows.Forms.DataGridView()
        Me.IdMedicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNacimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumColegiadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEspecialidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MEDICOSTableAdapter = New WindowsApp1.ConsultaMedicaDataSetTableAdapters.MEDICOSTableAdapter()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.txtColegiado = New System.Windows.Forms.TextBox()
        Me.ESPECIALIDADESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ESPECIALIDADESTableAdapter = New WindowsApp1.ConsultaMedicaDataSetTableAdapters.ESPECIALIDADESTableAdapter()
        Me.GBDatosPersonales.SuspendLayout()
        CType(Me.MEDICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultaMedicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataMedicos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ESPECIALIDADESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(490, 523)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 33)
        Me.btnNuevo.TabIndex = 65
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(844, 523)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 33)
        Me.btnEliminar.TabIndex = 64
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(39, 523)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 33)
        Me.btnVolver.TabIndex = 63
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Location = New System.Drawing.Point(942, 523)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 33)
        Me.btnActualizar.TabIndex = 62
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'GBDatosPersonales
        '
        Me.GBDatosPersonales.Controls.Add(Me.cbEspecialidad)
        Me.GBDatosPersonales.Controls.Add(Me.txtSexo)
        Me.GBDatosPersonales.Controls.Add(Me.Label1)
        Me.GBDatosPersonales.Controls.Add(Me.DTPFNacimiento)
        Me.GBDatosPersonales.Controls.Add(Me.txtNombre)
        Me.GBDatosPersonales.Controls.Add(Me.Label8)
        Me.GBDatosPersonales.Controls.Add(Me.txtTelefono)
        Me.GBDatosPersonales.Controls.Add(Me.lblTelefono)
        Me.GBDatosPersonales.Controls.Add(Me.lblEspecialidad)
        Me.GBDatosPersonales.Controls.Add(Me.lblFechaNacimiento)
        Me.GBDatosPersonales.Controls.Add(Me.txtAbreviatura)
        Me.GBDatosPersonales.Controls.Add(Me.lblAbreviatura)
        Me.GBDatosPersonales.Location = New System.Drawing.Point(273, 67)
        Me.GBDatosPersonales.Name = "GBDatosPersonales"
        Me.GBDatosPersonales.Size = New System.Drawing.Size(732, 201)
        Me.GBDatosPersonales.TabIndex = 61
        Me.GBDatosPersonales.TabStop = False
        Me.GBDatosPersonales.Text = "Datos Personales"
        '
        'cbEspecialidad
        '
        Me.cbEspecialidad.DataSource = Me.MEDICOSBindingSource
        Me.cbEspecialidad.DisplayMember = "idEspecialidad"
        Me.cbEspecialidad.FormattingEnabled = True
        Me.cbEspecialidad.Location = New System.Drawing.Point(480, 135)
        Me.cbEspecialidad.Name = "cbEspecialidad"
        Me.cbEspecialidad.Size = New System.Drawing.Size(196, 21)
        Me.cbEspecialidad.TabIndex = 17
        Me.cbEspecialidad.ValueMember = "idEspecialidad"
        '
        'MEDICOSBindingSource
        '
        Me.MEDICOSBindingSource.DataMember = "MEDICOS"
        Me.MEDICOSBindingSource.DataSource = Me.ConsultaMedicaDataSet
        '
        'ConsultaMedicaDataSet
        '
        Me.ConsultaMedicaDataSet.DataSetName = "ConsultaMedicaDataSet"
        Me.ConsultaMedicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtSexo
        '
        Me.txtSexo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOSBindingSource, "sexo", True))
        Me.txtSexo.Location = New System.Drawing.Point(149, 142)
        Me.txtSexo.Multiline = True
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.Size = New System.Drawing.Size(196, 20)
        Me.txtSexo.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Sexo"
        '
        'DTPFNacimiento
        '
        Me.DTPFNacimiento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOSBindingSource, "fechaNacimiento", True))
        Me.DTPFNacimiento.Location = New System.Drawing.Point(149, 107)
        Me.DTPFNacimiento.Name = "DTPFNacimiento"
        Me.DTPFNacimiento.Size = New System.Drawing.Size(196, 20)
        Me.DTPFNacimiento.TabIndex = 14
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOSBindingSource, "Nombre", True))
        Me.txtNombre.Location = New System.Drawing.Point(149, 74)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(196, 20)
        Me.txtNombre.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(60, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Nombre"
        '
        'txtTelefono
        '
        Me.txtTelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOSBindingSource, "telefono", True))
        Me.txtTelefono.Location = New System.Drawing.Point(480, 81)
        Me.txtTelefono.Multiline = True
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(196, 20)
        Me.txtTelefono.TabIndex = 11
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(391, 81)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefono.TabIndex = 10
        Me.lblTelefono.Text = "Telefono"
        '
        'lblEspecialidad
        '
        Me.lblEspecialidad.AutoSize = True
        Me.lblEspecialidad.Location = New System.Drawing.Point(391, 135)
        Me.lblEspecialidad.Name = "lblEspecialidad"
        Me.lblEspecialidad.Size = New System.Drawing.Size(67, 13)
        Me.lblEspecialidad.TabIndex = 8
        Me.lblEspecialidad.Text = "Especialidad"
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(60, 108)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(72, 13)
        Me.lblFechaNacimiento.TabIndex = 4
        Me.lblFechaNacimiento.Text = "F. Nacimiento"
        '
        'txtAbreviatura
        '
        Me.txtAbreviatura.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOSBindingSource, "idMedico", True))
        Me.txtAbreviatura.Location = New System.Drawing.Point(315, 30)
        Me.txtAbreviatura.Multiline = True
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Size = New System.Drawing.Size(188, 20)
        Me.txtAbreviatura.TabIndex = 1
        '
        'lblAbreviatura
        '
        Me.lblAbreviatura.AutoSize = True
        Me.lblAbreviatura.Location = New System.Drawing.Point(226, 30)
        Me.lblAbreviatura.Name = "lblAbreviatura"
        Me.lblAbreviatura.Size = New System.Drawing.Size(66, 13)
        Me.lblAbreviatura.TabIndex = 0
        Me.lblAbreviatura.Text = "Abr. Nombre"
        '
        'lblNumColegiado
        '
        Me.lblNumColegiado.AutoSize = True
        Me.lblNumColegiado.Location = New System.Drawing.Point(24, 24)
        Me.lblNumColegiado.Name = "lblNumColegiado"
        Me.lblNumColegiado.Size = New System.Drawing.Size(69, 13)
        Me.lblNumColegiado.TabIndex = 60
        Me.lblNumColegiado.Text = "Nº Colegiado"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(27, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(208, 201)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'DataMedicos
        '
        Me.DataMedicos.AllowUserToOrderColumns = True
        Me.DataMedicos.AutoGenerateColumns = False
        Me.DataMedicos.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataMedicos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdMedicoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.FechaNacimientoDataGridViewTextBoxColumn, Me.NumColegiadoDataGridViewTextBoxColumn, Me.SexoDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.IdEspecialidadDataGridViewTextBoxColumn})
        Me.DataMedicos.DataSource = Me.MEDICOSBindingSource
        Me.DataMedicos.GridColor = System.Drawing.SystemColors.ControlText
        Me.DataMedicos.Location = New System.Drawing.Point(170, 290)
        Me.DataMedicos.Name = "DataMedicos"
        Me.DataMedicos.Size = New System.Drawing.Size(749, 215)
        Me.DataMedicos.TabIndex = 68
        '
        'IdMedicoDataGridViewTextBoxColumn
        '
        Me.IdMedicoDataGridViewTextBoxColumn.DataPropertyName = "idMedico"
        Me.IdMedicoDataGridViewTextBoxColumn.HeaderText = "idMedico"
        Me.IdMedicoDataGridViewTextBoxColumn.Name = "IdMedicoDataGridViewTextBoxColumn"
        Me.IdMedicoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaNacimientoDataGridViewTextBoxColumn
        '
        Me.FechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "fechaNacimiento"
        Me.FechaNacimientoDataGridViewTextBoxColumn.HeaderText = "fechaNacimiento"
        Me.FechaNacimientoDataGridViewTextBoxColumn.Name = "FechaNacimientoDataGridViewTextBoxColumn"
        Me.FechaNacimientoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumColegiadoDataGridViewTextBoxColumn
        '
        Me.NumColegiadoDataGridViewTextBoxColumn.DataPropertyName = "numColegiado"
        Me.NumColegiadoDataGridViewTextBoxColumn.HeaderText = "numColegiado"
        Me.NumColegiadoDataGridViewTextBoxColumn.Name = "NumColegiadoDataGridViewTextBoxColumn"
        Me.NumColegiadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SexoDataGridViewTextBoxColumn
        '
        Me.SexoDataGridViewTextBoxColumn.DataPropertyName = "sexo"
        Me.SexoDataGridViewTextBoxColumn.HeaderText = "sexo"
        Me.SexoDataGridViewTextBoxColumn.Name = "SexoDataGridViewTextBoxColumn"
        Me.SexoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdEspecialidadDataGridViewTextBoxColumn
        '
        Me.IdEspecialidadDataGridViewTextBoxColumn.DataPropertyName = "idEspecialidad"
        Me.IdEspecialidadDataGridViewTextBoxColumn.HeaderText = "idEspecialidad"
        Me.IdEspecialidadDataGridViewTextBoxColumn.Name = "IdEspecialidadDataGridViewTextBoxColumn"
        Me.IdEspecialidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MEDICOSTableAdapter
        '
        Me.MEDICOSTableAdapter.ClearBeforeFill = True
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnCerrarSesion.Image = CType(resources.GetObject("btnCerrarSesion.Image"), System.Drawing.Image)
        Me.btnCerrarSesion.Location = New System.Drawing.Point(1010, 20)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(27, 30)
        Me.btnCerrarSesion.TabIndex = 71
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguiente.Image = CType(resources.GetObject("btnSiguiente.Image"), System.Drawing.Image)
        Me.btnSiguiente.Location = New System.Drawing.Point(937, 12)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(56, 48)
        Me.btnSiguiente.TabIndex = 70
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnterior.Image = CType(resources.GetObject("btnAnterior.Image"), System.Drawing.Image)
        Me.btnAnterior.Location = New System.Drawing.Point(875, 12)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(56, 48)
        Me.btnAnterior.TabIndex = 69
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'txtColegiado
        '
        Me.txtColegiado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOSBindingSource, "numColegiado", True))
        Me.txtColegiado.Location = New System.Drawing.Point(116, 21)
        Me.txtColegiado.Name = "txtColegiado"
        Me.txtColegiado.ReadOnly = True
        Me.txtColegiado.Size = New System.Drawing.Size(119, 20)
        Me.txtColegiado.TabIndex = 72
        '
        'ESPECIALIDADESBindingSource
        '
        Me.ESPECIALIDADESBindingSource.DataMember = "ESPECIALIDADES"
        Me.ESPECIALIDADESBindingSource.DataSource = Me.ConsultaMedicaDataSet
        '
        'ESPECIALIDADESTableAdapter
        '
        Me.ESPECIALIDADESTableAdapter.ClearBeforeFill = True
        '
        'VerMedicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1044, 564)
        Me.Controls.Add(Me.txtColegiado)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.DataMedicos)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.GBDatosPersonales)
        Me.Controls.Add(Me.lblNumColegiado)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VerMedicos"
        Me.Text = "VerMedicos"
        Me.GBDatosPersonales.ResumeLayout(False)
        Me.GBDatosPersonales.PerformLayout()
        CType(Me.MEDICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultaMedicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataMedicos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ESPECIALIDADESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents GBDatosPersonales As GroupBox
    Friend WithEvents cbEspecialidad As ComboBox
    Friend WithEvents txtSexo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DTPFNacimiento As DateTimePicker
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblEspecialidad As Label
    Friend WithEvents lblFechaNacimiento As Label
    Friend WithEvents txtAbreviatura As TextBox
    Friend WithEvents lblAbreviatura As Label
    Friend WithEvents lblNumColegiado As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataMedicos As DataGridView
    Friend WithEvents ConsultaMedicaDataSet As ConsultaMedicaDataSet
    Friend WithEvents MEDICOSBindingSource As BindingSource
    Friend WithEvents MEDICOSTableAdapter As ConsultaMedicaDataSetTableAdapters.MEDICOSTableAdapter
    Friend WithEvents IdMedicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaNacimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumColegiadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdEspecialidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents txtColegiado As TextBox
    Friend WithEvents ESPECIALIDADESBindingSource As BindingSource
    Friend WithEvents ESPECIALIDADESTableAdapter As ConsultaMedicaDataSetTableAdapters.ESPECIALIDADESTableAdapter
End Class
