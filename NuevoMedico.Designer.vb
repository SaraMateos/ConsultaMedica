<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NuevoMedico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevoMedico))
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
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
        Me.txtColegiado = New System.Windows.Forms.TextBox()
        Me.MEDICOSTableAdapter = New WindowsApp1.ConsultaMedicaDataSetTableAdapters.MEDICOSTableAdapter()
        Me.GBDatosPersonales.SuspendLayout()
        CType(Me.MEDICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultaMedicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Maiandra GD", 11.25!)
        Me.btnVolver.Location = New System.Drawing.Point(38, 304)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 32)
        Me.btnVolver.TabIndex = 69
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Maiandra GD", 11.25!)
        Me.btnAceptar.Location = New System.Drawing.Point(941, 304)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 32)
        Me.btnAceptar.TabIndex = 68
        Me.btnAceptar.Text = "Añadir"
        Me.btnAceptar.UseVisualStyleBackColor = True
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
        Me.GBDatosPersonales.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.GBDatosPersonales.Location = New System.Drawing.Point(284, 70)
        Me.GBDatosPersonales.Name = "GBDatosPersonales"
        Me.GBDatosPersonales.Size = New System.Drawing.Size(732, 216)
        Me.GBDatosPersonales.TabIndex = 67
        Me.GBDatosPersonales.TabStop = False
        Me.GBDatosPersonales.Text = "Datos Personales"
        '
        'cbEspecialidad
        '
        Me.cbEspecialidad.DataSource = Me.MEDICOSBindingSource
        Me.cbEspecialidad.DisplayMember = "idEspecialidad"
        Me.cbEspecialidad.FormattingEnabled = True
        Me.cbEspecialidad.Location = New System.Drawing.Point(480, 145)
        Me.cbEspecialidad.Name = "cbEspecialidad"
        Me.cbEspecialidad.Size = New System.Drawing.Size(196, 24)
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
        Me.txtSexo.Location = New System.Drawing.Point(132, 157)
        Me.txtSexo.Multiline = True
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.Size = New System.Drawing.Size(228, 21)
        Me.txtSexo.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Sexo"
        '
        'DTPFNacimiento
        '
        Me.DTPFNacimiento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOSBindingSource, "fechaNacimiento", True))
        Me.DTPFNacimiento.Location = New System.Drawing.Point(132, 119)
        Me.DTPFNacimiento.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.DTPFNacimiento.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DTPFNacimiento.Name = "DTPFNacimiento"
        Me.DTPFNacimiento.Size = New System.Drawing.Size(228, 23)
        Me.DTPFNacimiento.TabIndex = 20
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOSBindingSource, "Nombre", True))
        Me.txtNombre.Location = New System.Drawing.Point(132, 84)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(228, 21)
        Me.txtNombre.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(43, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Nombre"
        '
        'txtTelefono
        '
        Me.txtTelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOSBindingSource, "telefono", True))
        Me.txtTelefono.Location = New System.Drawing.Point(480, 87)
        Me.txtTelefono.Multiline = True
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(196, 21)
        Me.txtTelefono.TabIndex = 11
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(391, 87)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(58, 16)
        Me.lblTelefono.TabIndex = 10
        Me.lblTelefono.Text = "Telefono"
        '
        'lblEspecialidad
        '
        Me.lblEspecialidad.AutoSize = True
        Me.lblEspecialidad.Location = New System.Drawing.Point(391, 145)
        Me.lblEspecialidad.Name = "lblEspecialidad"
        Me.lblEspecialidad.Size = New System.Drawing.Size(76, 16)
        Me.lblEspecialidad.TabIndex = 8
        Me.lblEspecialidad.Text = "Especialidad"
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(43, 120)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(87, 16)
        Me.lblFechaNacimiento.TabIndex = 4
        Me.lblFechaNacimiento.Text = "F. Nacimiento"
        '
        'txtAbreviatura
        '
        Me.txtAbreviatura.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOSBindingSource, "Nombre", True))
        Me.txtAbreviatura.Location = New System.Drawing.Point(315, 32)
        Me.txtAbreviatura.Multiline = True
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Size = New System.Drawing.Size(188, 21)
        Me.txtAbreviatura.TabIndex = 1
        '
        'lblAbreviatura
        '
        Me.lblAbreviatura.AutoSize = True
        Me.lblAbreviatura.Location = New System.Drawing.Point(226, 32)
        Me.lblAbreviatura.Name = "lblAbreviatura"
        Me.lblAbreviatura.Size = New System.Drawing.Size(84, 16)
        Me.lblAbreviatura.TabIndex = 0
        Me.lblAbreviatura.Text = "Abr. Nombre"
        '
        'lblNumColegiado
        '
        Me.lblNumColegiado.AutoSize = True
        Me.lblNumColegiado.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.lblNumColegiado.Location = New System.Drawing.Point(35, 24)
        Me.lblNumColegiado.Name = "lblNumColegiado"
        Me.lblNumColegiado.Size = New System.Drawing.Size(85, 16)
        Me.lblNumColegiado.TabIndex = 66
        Me.lblNumColegiado.Text = "Nº Colegiado"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(38, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(208, 216)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        '
        'txtColegiado
        '
        Me.txtColegiado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOSBindingSource, "numColegiado", True))
        Me.txtColegiado.Location = New System.Drawing.Point(127, 20)
        Me.txtColegiado.Name = "txtColegiado"
        Me.txtColegiado.ReadOnly = True
        Me.txtColegiado.Size = New System.Drawing.Size(119, 21)
        Me.txtColegiado.TabIndex = 70
        '
        'MEDICOSTableAdapter
        '
        Me.MEDICOSTableAdapter.ClearBeforeFill = True
        '
        'NuevoMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1047, 347)
        Me.Controls.Add(Me.txtColegiado)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GBDatosPersonales)
        Me.Controls.Add(Me.lblNumColegiado)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Maiandra GD", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NuevoMedico"
        Me.Text = "NuevoMedico"
        Me.GBDatosPersonales.ResumeLayout(False)
        Me.GBDatosPersonales.PerformLayout()
        CType(Me.MEDICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultaMedicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVolver As Button
    Friend WithEvents btnAceptar As Button
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
    Friend WithEvents txtColegiado As TextBox
    Friend WithEvents ConsultaMedicaDataSet As ConsultaMedicaDataSet
    Friend WithEvents MEDICOSBindingSource As BindingSource
    Friend WithEvents MEDICOSTableAdapter As ConsultaMedicaDataSetTableAdapters.MEDICOSTableAdapter
End Class
