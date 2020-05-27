<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VerPacientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VerPacientes))
        Me.PACIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsultaMedicaDataSet = New WindowsApp1.ConsultaMedicaDataSet()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.GBDatosMedicos = New System.Windows.Forms.GroupBox()
        Me.txtAlergias = New System.Windows.Forms.TextBox()
        Me.lblAlergias = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSangre = New System.Windows.Forms.TextBox()
        Me.lblSangre = New System.Windows.Forms.Label()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.lblAltura = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.GBDatosPersonales = New System.Windows.Forms.GroupBox()
        Me.txtSexo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTPFNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtPoblacion = New System.Windows.Forms.TextBox()
        Me.lblPoblacion = New System.Windows.Forms.Label()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.txtNIF = New System.Windows.Forms.TextBox()
        Me.lblNIF = New System.Windows.Forms.Label()
        Me.lblNumHistorial = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PACIENTESTableAdapter = New WindowsApp1.ConsultaMedicaDataSetTableAdapters.PACIENTESTableAdapter()
        Me.DataPacientes = New System.Windows.Forms.DataGridView()
        Me.IdPacienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NIFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNacimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PoblacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirecciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeléfonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoGrupoSanguineoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PesoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlergiasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtHistorial = New System.Windows.Forms.TextBox()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultaMedicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBDatosMedicos.SuspendLayout()
        Me.GBDatosPersonales.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PACIENTESBindingSource
        '
        Me.PACIENTESBindingSource.DataMember = "PACIENTES"
        Me.PACIENTESBindingSource.DataSource = Me.ConsultaMedicaDataSet
        '
        'ConsultaMedicaDataSet
        '
        Me.ConsultaMedicaDataSet.DataSetName = "ConsultaMedicaDataSet"
        Me.ConsultaMedicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSiguiente
        '
        Me.btnSiguiente.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguiente.Image = CType(resources.GetObject("btnSiguiente.Image"), System.Drawing.Image)
        Me.btnSiguiente.Location = New System.Drawing.Point(932, 11)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(56, 48)
        Me.btnSiguiente.TabIndex = 58
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnterior.Image = CType(resources.GetObject("btnAnterior.Image"), System.Drawing.Image)
        Me.btnAnterior.Location = New System.Drawing.Point(870, 11)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(56, 48)
        Me.btnAnterior.TabIndex = 57
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(486, 727)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 30)
        Me.btnNuevo.TabIndex = 2
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(836, 727)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 30)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(35, 727)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 30)
        Me.btnVolver.TabIndex = 5
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Location = New System.Drawing.Point(938, 727)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 30)
        Me.btnActualizar.TabIndex = 0
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'GBDatosMedicos
        '
        Me.GBDatosMedicos.Controls.Add(Me.txtAlergias)
        Me.GBDatosMedicos.Controls.Add(Me.lblAlergias)
        Me.GBDatosMedicos.Controls.Add(Me.txtObservaciones)
        Me.GBDatosMedicos.Controls.Add(Me.Label4)
        Me.GBDatosMedicos.Controls.Add(Me.txtSangre)
        Me.GBDatosMedicos.Controls.Add(Me.lblSangre)
        Me.GBDatosMedicos.Controls.Add(Me.txtAltura)
        Me.GBDatosMedicos.Controls.Add(Me.lblAltura)
        Me.GBDatosMedicos.Controls.Add(Me.txtPeso)
        Me.GBDatosMedicos.Controls.Add(Me.lblPeso)
        Me.GBDatosMedicos.Location = New System.Drawing.Point(35, 295)
        Me.GBDatosMedicos.Name = "GBDatosMedicos"
        Me.GBDatosMedicos.Size = New System.Drawing.Size(978, 178)
        Me.GBDatosMedicos.TabIndex = 52
        Me.GBDatosMedicos.TabStop = False
        Me.GBDatosMedicos.Text = "Datos Médicos"
        '
        'txtAlergias
        '
        Me.txtAlergias.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "alergias", True))
        Me.txtAlergias.Location = New System.Drawing.Point(135, 138)
        Me.txtAlergias.Multiline = True
        Me.txtAlergias.Name = "txtAlergias"
        Me.txtAlergias.Size = New System.Drawing.Size(188, 20)
        Me.txtAlergias.TabIndex = 3
        '
        'lblAlergias
        '
        Me.lblAlergias.AutoSize = True
        Me.lblAlergias.Location = New System.Drawing.Point(30, 138)
        Me.lblAlergias.Name = "lblAlergias"
        Me.lblAlergias.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAlergias.Size = New System.Drawing.Size(44, 13)
        Me.lblAlergias.TabIndex = 8
        Me.lblAlergias.Text = "Alergias"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "observaciones", True))
        Me.txtObservaciones.Location = New System.Drawing.Point(395, 47)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(565, 104)
        Me.txtObservaciones.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(392, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Observaciones"
        '
        'txtSangre
        '
        Me.txtSangre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "TipoGrupoSanguineo", True))
        Me.txtSangre.Location = New System.Drawing.Point(135, 100)
        Me.txtSangre.Multiline = True
        Me.txtSangre.Name = "txtSangre"
        Me.txtSangre.Size = New System.Drawing.Size(188, 20)
        Me.txtSangre.TabIndex = 2
        '
        'lblSangre
        '
        Me.lblSangre.AutoSize = True
        Me.lblSangre.Location = New System.Drawing.Point(30, 100)
        Me.lblSangre.Name = "lblSangre"
        Me.lblSangre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSangre.Size = New System.Drawing.Size(88, 13)
        Me.lblSangre.TabIndex = 4
        Me.lblSangre.Text = "Grupo sanguineo"
        '
        'txtAltura
        '
        Me.txtAltura.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "altura", True))
        Me.txtAltura.Location = New System.Drawing.Point(135, 65)
        Me.txtAltura.Multiline = True
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(188, 20)
        Me.txtAltura.TabIndex = 1
        '
        'lblAltura
        '
        Me.lblAltura.AutoSize = True
        Me.lblAltura.Location = New System.Drawing.Point(30, 65)
        Me.lblAltura.Name = "lblAltura"
        Me.lblAltura.Size = New System.Drawing.Size(34, 13)
        Me.lblAltura.TabIndex = 2
        Me.lblAltura.Text = "Altura" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtPeso
        '
        Me.txtPeso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "peso", True))
        Me.txtPeso.Location = New System.Drawing.Point(135, 32)
        Me.txtPeso.Multiline = True
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(188, 20)
        Me.txtPeso.TabIndex = 0
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Location = New System.Drawing.Point(30, 32)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(31, 13)
        Me.lblPeso.TabIndex = 0
        Me.lblPeso.Text = "Peso"
        '
        'GBDatosPersonales
        '
        Me.GBDatosPersonales.Controls.Add(Me.txtSexo)
        Me.GBDatosPersonales.Controls.Add(Me.Label1)
        Me.GBDatosPersonales.Controls.Add(Me.DTPFNacimiento)
        Me.GBDatosPersonales.Controls.Add(Me.txtNombre)
        Me.GBDatosPersonales.Controls.Add(Me.Label8)
        Me.GBDatosPersonales.Controls.Add(Me.txtTelefono)
        Me.GBDatosPersonales.Controls.Add(Me.lblTelefono)
        Me.GBDatosPersonales.Controls.Add(Me.txtDireccion)
        Me.GBDatosPersonales.Controls.Add(Me.lblDireccion)
        Me.GBDatosPersonales.Controls.Add(Me.txtPoblacion)
        Me.GBDatosPersonales.Controls.Add(Me.lblPoblacion)
        Me.GBDatosPersonales.Controls.Add(Me.lblFechaNacimiento)
        Me.GBDatosPersonales.Controls.Add(Me.txtNIF)
        Me.GBDatosPersonales.Controls.Add(Me.lblNIF)
        Me.GBDatosPersonales.Location = New System.Drawing.Point(281, 65)
        Me.GBDatosPersonales.Name = "GBDatosPersonales"
        Me.GBDatosPersonales.Size = New System.Drawing.Size(732, 201)
        Me.GBDatosPersonales.TabIndex = 51
        Me.GBDatosPersonales.TabStop = False
        Me.GBDatosPersonales.Text = "Datos Personales"
        '
        'txtSexo
        '
        Me.txtSexo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "sexo", True))
        Me.txtSexo.Location = New System.Drawing.Point(149, 142)
        Me.txtSexo.Multiline = True
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.Size = New System.Drawing.Size(196, 20)
        Me.txtSexo.TabIndex = 3
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
        Me.DTPFNacimiento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "fechaNacimiento", True))
        Me.DTPFNacimiento.Location = New System.Drawing.Point(149, 107)
        Me.DTPFNacimiento.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.DTPFNacimiento.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DTPFNacimiento.Name = "DTPFNacimiento"
        Me.DTPFNacimiento.Size = New System.Drawing.Size(196, 20)
        Me.DTPFNacimiento.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "Nombre", True))
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.PACIENTESBindingSource, "Nombre", True))
        Me.txtNombre.Location = New System.Drawing.Point(149, 74)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(196, 20)
        Me.txtNombre.TabIndex = 1
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
        Me.txtTelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "teléfono", True))
        Me.txtTelefono.Location = New System.Drawing.Point(480, 142)
        Me.txtTelefono.Multiline = True
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(196, 20)
        Me.txtTelefono.TabIndex = 6
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(391, 142)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefono.TabIndex = 10
        Me.lblTelefono.Text = "Telefono"
        '
        'txtDireccion
        '
        Me.txtDireccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "dirección", True))
        Me.txtDireccion.Location = New System.Drawing.Point(480, 107)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(196, 20)
        Me.txtDireccion.TabIndex = 5
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(391, 107)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccion.TabIndex = 8
        Me.lblDireccion.Text = "Direccion"
        '
        'txtPoblacion
        '
        Me.txtPoblacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "Poblacion", True))
        Me.txtPoblacion.Location = New System.Drawing.Point(480, 74)
        Me.txtPoblacion.Multiline = True
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.Size = New System.Drawing.Size(196, 20)
        Me.txtPoblacion.TabIndex = 4
        '
        'lblPoblacion
        '
        Me.lblPoblacion.AutoSize = True
        Me.lblPoblacion.Location = New System.Drawing.Point(391, 74)
        Me.lblPoblacion.Name = "lblPoblacion"
        Me.lblPoblacion.Size = New System.Drawing.Size(54, 13)
        Me.lblPoblacion.TabIndex = 6
        Me.lblPoblacion.Text = "Poblacion"
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
        'txtNIF
        '
        Me.txtNIF.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "NIF", True))
        Me.txtNIF.Location = New System.Drawing.Point(315, 30)
        Me.txtNIF.Multiline = True
        Me.txtNIF.Name = "txtNIF"
        Me.txtNIF.Size = New System.Drawing.Size(188, 20)
        Me.txtNIF.TabIndex = 0
        '
        'lblNIF
        '
        Me.lblNIF.AutoSize = True
        Me.lblNIF.Location = New System.Drawing.Point(226, 30)
        Me.lblNIF.Name = "lblNIF"
        Me.lblNIF.Size = New System.Drawing.Size(24, 13)
        Me.lblNIF.TabIndex = 0
        Me.lblNIF.Text = "NIF"
        '
        'lblNumHistorial
        '
        Me.lblNumHistorial.AutoSize = True
        Me.lblNumHistorial.Location = New System.Drawing.Point(32, 28)
        Me.lblNumHistorial.Name = "lblNumHistorial"
        Me.lblNumHistorial.Size = New System.Drawing.Size(59, 13)
        Me.lblNumHistorial.TabIndex = 50
        Me.lblNumHistorial.Text = "Nº Historial"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(35, 65)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(208, 201)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'PACIENTESTableAdapter
        '
        Me.PACIENTESTableAdapter.ClearBeforeFill = True
        '
        'DataPacientes
        '
        Me.DataPacientes.AllowUserToOrderColumns = True
        Me.DataPacientes.AutoGenerateColumns = False
        Me.DataPacientes.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataPacientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPacienteDataGridViewTextBoxColumn, Me.NIFDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.FechaNacimientoDataGridViewTextBoxColumn, Me.SexoDataGridViewTextBoxColumn, Me.PoblacionDataGridViewTextBoxColumn, Me.DirecciónDataGridViewTextBoxColumn, Me.TeléfonoDataGridViewTextBoxColumn, Me.TipoGrupoSanguineoDataGridViewTextBoxColumn, Me.AlturaDataGridViewTextBoxColumn, Me.PesoDataGridViewTextBoxColumn, Me.AlergiasDataGridViewTextBoxColumn, Me.ObservacionesDataGridViewTextBoxColumn})
        Me.DataPacientes.DataSource = Me.PACIENTESBindingSource
        Me.DataPacientes.GridColor = System.Drawing.SystemColors.ControlText
        Me.DataPacientes.Location = New System.Drawing.Point(35, 497)
        Me.DataPacientes.Name = "DataPacientes"
        Me.DataPacientes.Size = New System.Drawing.Size(978, 215)
        Me.DataPacientes.TabIndex = 59
        '
        'IdPacienteDataGridViewTextBoxColumn
        '
        Me.IdPacienteDataGridViewTextBoxColumn.DataPropertyName = "idPaciente"
        Me.IdPacienteDataGridViewTextBoxColumn.HeaderText = "idPaciente"
        Me.IdPacienteDataGridViewTextBoxColumn.Name = "IdPacienteDataGridViewTextBoxColumn"
        '
        'NIFDataGridViewTextBoxColumn
        '
        Me.NIFDataGridViewTextBoxColumn.DataPropertyName = "NIF"
        Me.NIFDataGridViewTextBoxColumn.HeaderText = "NIF"
        Me.NIFDataGridViewTextBoxColumn.Name = "NIFDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'FechaNacimientoDataGridViewTextBoxColumn
        '
        Me.FechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "fechaNacimiento"
        Me.FechaNacimientoDataGridViewTextBoxColumn.HeaderText = "fechaNacimiento"
        Me.FechaNacimientoDataGridViewTextBoxColumn.Name = "FechaNacimientoDataGridViewTextBoxColumn"
        '
        'SexoDataGridViewTextBoxColumn
        '
        Me.SexoDataGridViewTextBoxColumn.DataPropertyName = "sexo"
        Me.SexoDataGridViewTextBoxColumn.HeaderText = "sexo"
        Me.SexoDataGridViewTextBoxColumn.Name = "SexoDataGridViewTextBoxColumn"
        '
        'PoblacionDataGridViewTextBoxColumn
        '
        Me.PoblacionDataGridViewTextBoxColumn.DataPropertyName = "Poblacion"
        Me.PoblacionDataGridViewTextBoxColumn.HeaderText = "Poblacion"
        Me.PoblacionDataGridViewTextBoxColumn.Name = "PoblacionDataGridViewTextBoxColumn"
        '
        'DirecciónDataGridViewTextBoxColumn
        '
        Me.DirecciónDataGridViewTextBoxColumn.DataPropertyName = "dirección"
        Me.DirecciónDataGridViewTextBoxColumn.HeaderText = "dirección"
        Me.DirecciónDataGridViewTextBoxColumn.Name = "DirecciónDataGridViewTextBoxColumn"
        '
        'TeléfonoDataGridViewTextBoxColumn
        '
        Me.TeléfonoDataGridViewTextBoxColumn.DataPropertyName = "teléfono"
        Me.TeléfonoDataGridViewTextBoxColumn.HeaderText = "teléfono"
        Me.TeléfonoDataGridViewTextBoxColumn.Name = "TeléfonoDataGridViewTextBoxColumn"
        '
        'TipoGrupoSanguineoDataGridViewTextBoxColumn
        '
        Me.TipoGrupoSanguineoDataGridViewTextBoxColumn.DataPropertyName = "TipoGrupoSanguineo"
        Me.TipoGrupoSanguineoDataGridViewTextBoxColumn.HeaderText = "TipoGrupoSanguineo"
        Me.TipoGrupoSanguineoDataGridViewTextBoxColumn.Name = "TipoGrupoSanguineoDataGridViewTextBoxColumn"
        '
        'AlturaDataGridViewTextBoxColumn
        '
        Me.AlturaDataGridViewTextBoxColumn.DataPropertyName = "altura"
        Me.AlturaDataGridViewTextBoxColumn.HeaderText = "altura"
        Me.AlturaDataGridViewTextBoxColumn.Name = "AlturaDataGridViewTextBoxColumn"
        '
        'PesoDataGridViewTextBoxColumn
        '
        Me.PesoDataGridViewTextBoxColumn.DataPropertyName = "peso"
        Me.PesoDataGridViewTextBoxColumn.HeaderText = "peso"
        Me.PesoDataGridViewTextBoxColumn.Name = "PesoDataGridViewTextBoxColumn"
        '
        'AlergiasDataGridViewTextBoxColumn
        '
        Me.AlergiasDataGridViewTextBoxColumn.DataPropertyName = "alergias"
        Me.AlergiasDataGridViewTextBoxColumn.HeaderText = "alergias"
        Me.AlergiasDataGridViewTextBoxColumn.Name = "AlergiasDataGridViewTextBoxColumn"
        '
        'ObservacionesDataGridViewTextBoxColumn
        '
        Me.ObservacionesDataGridViewTextBoxColumn.DataPropertyName = "observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.HeaderText = "observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.Name = "ObservacionesDataGridViewTextBoxColumn"
        '
        'txtHistorial
        '
        Me.txtHistorial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "idPaciente", True))
        Me.txtHistorial.Location = New System.Drawing.Point(109, 25)
        Me.txtHistorial.Name = "txtHistorial"
        Me.txtHistorial.ReadOnly = True
        Me.txtHistorial.Size = New System.Drawing.Size(134, 20)
        Me.txtHistorial.TabIndex = 60
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnCerrarSesion.Image = CType(resources.GetObject("btnCerrarSesion.Image"), System.Drawing.Image)
        Me.btnCerrarSesion.Location = New System.Drawing.Point(1005, 19)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(27, 30)
        Me.btnCerrarSesion.TabIndex = 61
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'VerPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1044, 763)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Controls.Add(Me.txtHistorial)
        Me.Controls.Add(Me.DataPacientes)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.GBDatosMedicos)
        Me.Controls.Add(Me.GBDatosPersonales)
        Me.Controls.Add(Me.lblNumHistorial)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VerPacientes"
        Me.Text = "Datos de pacientes"
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultaMedicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBDatosMedicos.ResumeLayout(False)
        Me.GBDatosMedicos.PerformLayout()
        Me.GBDatosPersonales.ResumeLayout(False)
        Me.GBDatosPersonales.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents GBDatosMedicos As GroupBox
    Friend WithEvents txtAlergias As TextBox
    Friend WithEvents lblAlergias As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSangre As TextBox
    Friend WithEvents lblSangre As Label
    Friend WithEvents txtAltura As TextBox
    Friend WithEvents lblAltura As Label
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents lblPeso As Label
    Friend WithEvents GBDatosPersonales As GroupBox
    Friend WithEvents txtSexo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DTPFNacimiento As DateTimePicker
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents lblDireccion As Label
    Friend WithEvents txtPoblacion As TextBox
    Friend WithEvents lblPoblacion As Label
    Friend WithEvents lblFechaNacimiento As Label
    Friend WithEvents txtNIF As TextBox
    Friend WithEvents lblNIF As Label
    Friend WithEvents lblNumHistorial As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ConsultaMedicaDataSet As ConsultaMedicaDataSet
    Friend WithEvents PACIENTESBindingSource As BindingSource
    Friend WithEvents PACIENTESTableAdapter As ConsultaMedicaDataSetTableAdapters.PACIENTESTableAdapter
    Friend WithEvents DataPacientes As DataGridView
    Friend WithEvents txtHistorial As TextBox
    Friend WithEvents IdPacienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NIFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaNacimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PoblacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DirecciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TeléfonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoGrupoSanguineoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PesoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlergiasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnCerrarSesion As Button
End Class
