<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NuevoPaciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevoPaciente))
        Me.txtHistorial = New System.Windows.Forms.TextBox()
        Me.PACIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsultaMedicaDataSet = New WindowsApp1.ConsultaMedicaDataSet()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.GBDatosPersonales = New System.Windows.Forms.GroupBox()
        Me.txtNIF = New System.Windows.Forms.TextBox()
        Me.lblNIF = New System.Windows.Forms.Label()
        Me.lblNumHistorial = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PACIENTESTableAdapter = New WindowsApp1.ConsultaMedicaDataSetTableAdapters.PACIENTESTableAdapter()
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
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultaMedicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBDatosPersonales.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBDatosMedicos.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtHistorial
        '
        Me.txtHistorial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "idPaciente", True))
        Me.txtHistorial.Location = New System.Drawing.Point(106, 22)
        Me.txtHistorial.Name = "txtHistorial"
        Me.txtHistorial.ReadOnly = True
        Me.txtHistorial.Size = New System.Drawing.Size(134, 21)
        Me.txtHistorial.TabIndex = 72
        Me.txtHistorial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Maiandra GD", 11.25!)
        Me.btnVolver.Location = New System.Drawing.Point(32, 523)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 32)
        Me.btnVolver.TabIndex = 66
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Maiandra GD", 11.25!)
        Me.btnAceptar.Location = New System.Drawing.Point(935, 523)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 32)
        Me.btnAceptar.TabIndex = 65
        Me.btnAceptar.Text = "Añadir"
        Me.btnAceptar.UseVisualStyleBackColor = True
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
        Me.GBDatosPersonales.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBDatosPersonales.Location = New System.Drawing.Point(278, 67)
        Me.GBDatosPersonales.Name = "GBDatosPersonales"
        Me.GBDatosPersonales.Size = New System.Drawing.Size(732, 216)
        Me.GBDatosPersonales.TabIndex = 63
        Me.GBDatosPersonales.TabStop = False
        Me.GBDatosPersonales.Text = "Datos Personales"
        '
        'txtNIF
        '
        Me.txtNIF.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "NIF", True))
        Me.txtNIF.Location = New System.Drawing.Point(315, 32)
        Me.txtNIF.Multiline = True
        Me.txtNIF.Name = "txtNIF"
        Me.txtNIF.Size = New System.Drawing.Size(188, 21)
        Me.txtNIF.TabIndex = 1
        Me.txtNIF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblNIF
        '
        Me.lblNIF.AutoSize = True
        Me.lblNIF.Location = New System.Drawing.Point(226, 32)
        Me.lblNIF.Name = "lblNIF"
        Me.lblNIF.Size = New System.Drawing.Size(29, 16)
        Me.lblNIF.TabIndex = 0
        Me.lblNIF.Text = "NIF"
        '
        'lblNumHistorial
        '
        Me.lblNumHistorial.AutoSize = True
        Me.lblNumHistorial.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.lblNumHistorial.Location = New System.Drawing.Point(29, 25)
        Me.lblNumHistorial.Name = "lblNumHistorial"
        Me.lblNumHistorial.Size = New System.Drawing.Size(73, 16)
        Me.lblNumHistorial.TabIndex = 62
        Me.lblNumHistorial.Text = "Nº Historial"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(32, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(208, 216)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 61
        Me.PictureBox1.TabStop = False
        '
        'PACIENTESTableAdapter
        '
        Me.PACIENTESTableAdapter.ClearBeforeFill = True
        '
        'txtSexo
        '
        Me.txtSexo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "sexo", True))
        Me.txtSexo.Location = New System.Drawing.Point(136, 162)
        Me.txtSexo.Multiline = True
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.Size = New System.Drawing.Size(236, 21)
        Me.txtSexo.TabIndex = 18
        Me.txtSexo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 16)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Sexo"
        '
        'DTPFNacimiento
        '
        Me.DTPFNacimiento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "fechaNacimiento", True))
        Me.DTPFNacimiento.Location = New System.Drawing.Point(136, 124)
        Me.DTPFNacimiento.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.DTPFNacimiento.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DTPFNacimiento.Name = "DTPFNacimiento"
        Me.DTPFNacimiento.Size = New System.Drawing.Size(236, 23)
        Me.DTPFNacimiento.TabIndex = 17
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "Nombre", True))
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.PACIENTESBindingSource, "Nombre", True))
        Me.txtNombre.Location = New System.Drawing.Point(136, 89)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(236, 21)
        Me.txtNombre.TabIndex = 16
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(43, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 16)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Nombre"
        '
        'txtTelefono
        '
        Me.txtTelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "teléfono", True))
        Me.txtTelefono.Location = New System.Drawing.Point(483, 162)
        Me.txtTelefono.Multiline = True
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(196, 21)
        Me.txtTelefono.TabIndex = 22
        Me.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(402, 162)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(58, 16)
        Me.lblTelefono.TabIndex = 25
        Me.lblTelefono.Text = "Teléfono"
        '
        'txtDireccion
        '
        Me.txtDireccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "dirección", True))
        Me.txtDireccion.Location = New System.Drawing.Point(483, 124)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(196, 21)
        Me.txtDireccion.TabIndex = 21
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(402, 124)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(61, 16)
        Me.lblDireccion.TabIndex = 24
        Me.lblDireccion.Text = "Dirección"
        '
        'txtPoblacion
        '
        Me.txtPoblacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "Poblacion", True))
        Me.txtPoblacion.Location = New System.Drawing.Point(483, 89)
        Me.txtPoblacion.Multiline = True
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.Size = New System.Drawing.Size(196, 21)
        Me.txtPoblacion.TabIndex = 19
        Me.txtPoblacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPoblacion
        '
        Me.lblPoblacion.AutoSize = True
        Me.lblPoblacion.Location = New System.Drawing.Point(402, 89)
        Me.lblPoblacion.Name = "lblPoblacion"
        Me.lblPoblacion.Size = New System.Drawing.Size(63, 16)
        Me.lblPoblacion.TabIndex = 23
        Me.lblPoblacion.Text = "Población"
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(43, 127)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(87, 16)
        Me.lblFechaNacimiento.TabIndex = 20
        Me.lblFechaNacimiento.Text = "F. Nacimiento"
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
        Me.GBDatosMedicos.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBDatosMedicos.Location = New System.Drawing.Point(32, 309)
        Me.GBDatosMedicos.Name = "GBDatosMedicos"
        Me.GBDatosMedicos.Size = New System.Drawing.Size(978, 192)
        Me.GBDatosMedicos.TabIndex = 73
        Me.GBDatosMedicos.TabStop = False
        Me.GBDatosMedicos.Text = "Datos Médicos"
        '
        'txtAlergias
        '
        Me.txtAlergias.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "alergias", True))
        Me.txtAlergias.Location = New System.Drawing.Point(141, 149)
        Me.txtAlergias.Multiline = True
        Me.txtAlergias.Name = "txtAlergias"
        Me.txtAlergias.Size = New System.Drawing.Size(188, 21)
        Me.txtAlergias.TabIndex = 3
        Me.txtAlergias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAlergias
        '
        Me.lblAlergias.AutoSize = True
        Me.lblAlergias.Location = New System.Drawing.Point(30, 149)
        Me.lblAlergias.Name = "lblAlergias"
        Me.lblAlergias.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAlergias.Size = New System.Drawing.Size(51, 16)
        Me.lblAlergias.TabIndex = 8
        Me.lblAlergias.Text = "Alergias"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "observaciones", True))
        Me.txtObservaciones.Location = New System.Drawing.Point(395, 51)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(565, 112)
        Me.txtObservaciones.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(392, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Observaciones"
        '
        'txtSangre
        '
        Me.txtSangre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "TipoGrupoSanguineo", True))
        Me.txtSangre.Location = New System.Drawing.Point(141, 108)
        Me.txtSangre.Multiline = True
        Me.txtSangre.Name = "txtSangre"
        Me.txtSangre.Size = New System.Drawing.Size(188, 21)
        Me.txtSangre.TabIndex = 2
        Me.txtSangre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSangre
        '
        Me.lblSangre.AutoSize = True
        Me.lblSangre.Location = New System.Drawing.Point(30, 108)
        Me.lblSangre.Name = "lblSangre"
        Me.lblSangre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSangre.Size = New System.Drawing.Size(105, 16)
        Me.lblSangre.TabIndex = 4
        Me.lblSangre.Text = "Grupo sanguíneo"
        '
        'txtAltura
        '
        Me.txtAltura.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "altura", True))
        Me.txtAltura.Location = New System.Drawing.Point(141, 70)
        Me.txtAltura.Multiline = True
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(188, 21)
        Me.txtAltura.TabIndex = 1
        Me.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAltura
        '
        Me.lblAltura.AutoSize = True
        Me.lblAltura.Location = New System.Drawing.Point(30, 70)
        Me.lblAltura.Name = "lblAltura"
        Me.lblAltura.Size = New System.Drawing.Size(42, 16)
        Me.lblAltura.TabIndex = 2
        Me.lblAltura.Text = "Altura" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtPeso
        '
        Me.txtPeso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTESBindingSource, "peso", True))
        Me.txtPeso.Location = New System.Drawing.Point(141, 34)
        Me.txtPeso.Multiline = True
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(188, 21)
        Me.txtPeso.TabIndex = 0
        Me.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Location = New System.Drawing.Point(30, 34)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(33, 16)
        Me.lblPeso.TabIndex = 0
        Me.lblPeso.Text = "Peso"
        '
        'NuevoPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1044, 569)
        Me.Controls.Add(Me.GBDatosMedicos)
        Me.Controls.Add(Me.txtHistorial)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GBDatosPersonales)
        Me.Controls.Add(Me.lblNumHistorial)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NuevoPaciente"
        Me.Text = "Agregar nuevo paciente"
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultaMedicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBDatosPersonales.ResumeLayout(False)
        Me.GBDatosPersonales.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBDatosMedicos.ResumeLayout(False)
        Me.GBDatosMedicos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtHistorial As TextBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents GBDatosPersonales As GroupBox
    Friend WithEvents txtNIF As TextBox
    Friend WithEvents lblNIF As Label
    Friend WithEvents lblNumHistorial As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ConsultaMedicaDataSet As ConsultaMedicaDataSet
    Friend WithEvents PACIENTESBindingSource As BindingSource
    Friend WithEvents PACIENTESTableAdapter As ConsultaMedicaDataSetTableAdapters.PACIENTESTableAdapter
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
End Class
