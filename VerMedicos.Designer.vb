﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.txtEspecialidad = New System.Windows.Forms.TextBox()
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
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.txtColegiado = New System.Windows.Forms.TextBox()
        Me.ConsultaMedicaDataSet1 = New WindowsApp1.ConsultaMedicaDataSet1()
        Me.MEDICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEDICOSTableAdapter = New WindowsApp1.ConsultaMedicaDataSet1TableAdapters.MEDICOSTableAdapter()
        Me.IdMedicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNacimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumColegiadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEspecialidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GBDatosPersonales.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataMedicos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultaMedicaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Maiandra GD", 11.25!)
        Me.btnNuevo.Location = New System.Drawing.Point(490, 563)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 36)
        Me.btnNuevo.TabIndex = 3
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Maiandra GD", 11.25!)
        Me.btnEliminar.Location = New System.Drawing.Point(844, 563)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 36)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Maiandra GD", 11.25!)
        Me.btnVolver.Location = New System.Drawing.Point(39, 563)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 36)
        Me.btnVolver.TabIndex = 4
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Font = New System.Drawing.Font("Maiandra GD", 11.25!)
        Me.btnActualizar.Location = New System.Drawing.Point(937, 563)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(80, 36)
        Me.btnActualizar.TabIndex = 1
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'GBDatosPersonales
        '
        Me.GBDatosPersonales.Controls.Add(Me.txtEspecialidad)
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
        Me.GBDatosPersonales.Location = New System.Drawing.Point(273, 72)
        Me.GBDatosPersonales.Name = "GBDatosPersonales"
        Me.GBDatosPersonales.Size = New System.Drawing.Size(732, 216)
        Me.GBDatosPersonales.TabIndex = 0
        Me.GBDatosPersonales.TabStop = False
        Me.GBDatosPersonales.Text = "Datos Personales"
        '
        'txtEspecialidad
        '
        Me.txtEspecialidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOSBindingSource, "idEspecialidad", True))
        Me.txtEspecialidad.Location = New System.Drawing.Point(480, 140)
        Me.txtEspecialidad.Multiline = True
        Me.txtEspecialidad.Name = "txtEspecialidad"
        Me.txtEspecialidad.Size = New System.Drawing.Size(196, 21)
        Me.txtEspecialidad.TabIndex = 5
        '
        'txtSexo
        '
        Me.txtSexo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOSBindingSource, "sexo", True))
        Me.txtSexo.Location = New System.Drawing.Point(129, 149)
        Me.txtSexo.Multiline = True
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.Size = New System.Drawing.Size(230, 21)
        Me.txtSexo.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Sexo"
        '
        'DTPFNacimiento
        '
        Me.DTPFNacimiento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOSBindingSource, "fechaNacimiento", True))
        Me.DTPFNacimiento.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MEDICOSBindingSource, "fechaNacimiento", True))
        Me.DTPFNacimiento.Location = New System.Drawing.Point(129, 111)
        Me.DTPFNacimiento.Name = "DTPFNacimiento"
        Me.DTPFNacimiento.Size = New System.Drawing.Size(230, 23)
        Me.DTPFNacimiento.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOSBindingSource, "Nombre", True))
        Me.txtNombre.Location = New System.Drawing.Point(129, 76)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(230, 21)
        Me.txtNombre.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(40, 76)
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
        Me.txtTelefono.TabIndex = 4
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
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(40, 112)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(87, 16)
        Me.lblFechaNacimiento.TabIndex = 4
        Me.lblFechaNacimiento.Text = "F. Nacimiento"
        '
        'txtAbreviatura
        '
        Me.txtAbreviatura.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOSBindingSource, "idMedico", True))
        Me.txtAbreviatura.Location = New System.Drawing.Point(315, 32)
        Me.txtAbreviatura.Multiline = True
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Size = New System.Drawing.Size(188, 21)
        Me.txtAbreviatura.TabIndex = 0
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
        Me.lblNumColegiado.Location = New System.Drawing.Point(24, 26)
        Me.lblNumColegiado.Name = "lblNumColegiado"
        Me.lblNumColegiado.Size = New System.Drawing.Size(85, 16)
        Me.lblNumColegiado.TabIndex = 60
        Me.lblNumColegiado.Text = "Nº Colegiado"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(27, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(208, 216)
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
        Me.DataMedicos.Location = New System.Drawing.Point(170, 312)
        Me.DataMedicos.Name = "DataMedicos"
        Me.DataMedicos.Size = New System.Drawing.Size(749, 232)
        Me.DataMedicos.TabIndex = 68
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnCerrarSesion.Image = CType(resources.GetObject("btnCerrarSesion.Image"), System.Drawing.Image)
        Me.btnCerrarSesion.Location = New System.Drawing.Point(978, 19)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(27, 32)
        Me.btnCerrarSesion.TabIndex = 5
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'txtColegiado
        '
        Me.txtColegiado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOSBindingSource, "numColegiado", True))
        Me.txtColegiado.Location = New System.Drawing.Point(116, 23)
        Me.txtColegiado.Name = "txtColegiado"
        Me.txtColegiado.ReadOnly = True
        Me.txtColegiado.Size = New System.Drawing.Size(119, 21)
        Me.txtColegiado.TabIndex = 72
        Me.txtColegiado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ConsultaMedicaDataSet1
        '
        Me.ConsultaMedicaDataSet1.DataSetName = "ConsultaMedicaDataSet1"
        Me.ConsultaMedicaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MEDICOSBindingSource
        '
        Me.MEDICOSBindingSource.DataMember = "MEDICOS"
        Me.MEDICOSBindingSource.DataSource = Me.ConsultaMedicaDataSet1
        '
        'MEDICOSTableAdapter
        '
        Me.MEDICOSTableAdapter.ClearBeforeFill = True
        '
        'IdMedicoDataGridViewTextBoxColumn
        '
        Me.IdMedicoDataGridViewTextBoxColumn.DataPropertyName = "idMedico"
        Me.IdMedicoDataGridViewTextBoxColumn.HeaderText = "Médico"
        Me.IdMedicoDataGridViewTextBoxColumn.Name = "IdMedicoDataGridViewTextBoxColumn"
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
        Me.FechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha de nacimiento"
        Me.FechaNacimientoDataGridViewTextBoxColumn.Name = "FechaNacimientoDataGridViewTextBoxColumn"
        '
        'NumColegiadoDataGridViewTextBoxColumn
        '
        Me.NumColegiadoDataGridViewTextBoxColumn.DataPropertyName = "numColegiado"
        Me.NumColegiadoDataGridViewTextBoxColumn.HeaderText = "Num colegiado"
        Me.NumColegiadoDataGridViewTextBoxColumn.Name = "NumColegiadoDataGridViewTextBoxColumn"
        '
        'SexoDataGridViewTextBoxColumn
        '
        Me.SexoDataGridViewTextBoxColumn.DataPropertyName = "sexo"
        Me.SexoDataGridViewTextBoxColumn.HeaderText = "Sexo"
        Me.SexoDataGridViewTextBoxColumn.Name = "SexoDataGridViewTextBoxColumn"
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Teléfono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        '
        'IdEspecialidadDataGridViewTextBoxColumn
        '
        Me.IdEspecialidadDataGridViewTextBoxColumn.DataPropertyName = "idEspecialidad"
        Me.IdEspecialidadDataGridViewTextBoxColumn.HeaderText = "Especialidad"
        Me.IdEspecialidadDataGridViewTextBoxColumn.Name = "IdEspecialidadDataGridViewTextBoxColumn"
        '
        'VerMedicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1044, 607)
        Me.Controls.Add(Me.txtColegiado)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Controls.Add(Me.DataMedicos)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.GBDatosPersonales)
        Me.Controls.Add(Me.lblNumColegiado)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Maiandra GD", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VerMedicos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de médicos"
        Me.GBDatosPersonales.ResumeLayout(False)
        Me.GBDatosPersonales.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataMedicos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultaMedicaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents GBDatosPersonales As GroupBox
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
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents txtColegiado As TextBox
    Friend WithEvents txtEspecialidad As TextBox
    Friend WithEvents ConsultaMedicaDataSet1 As ConsultaMedicaDataSet1
    Friend WithEvents MEDICOSBindingSource As BindingSource
    Friend WithEvents MEDICOSTableAdapter As ConsultaMedicaDataSet1TableAdapters.MEDICOSTableAdapter
    Friend WithEvents IdMedicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaNacimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumColegiadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdEspecialidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
