﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Receta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Receta))
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataRecetas = New System.Windows.Forms.DataGridView()
        Me.IdRecetaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdMedicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPacienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCreacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEnfermedadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdMedicamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DosisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECETASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsultaMedicaDataSet1 = New WindowsApp1.ConsultaMedicaDataSet1()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblIdReceta = New System.Windows.Forms.Label()
        Me.txtIdReceta = New System.Windows.Forms.TextBox()
        Me.lblMédico = New System.Windows.Forms.Label()
        Me.lblPaciente = New System.Windows.Forms.Label()
        Me.txtPaciente = New System.Windows.Forms.TextBox()
        Me.txtMedico = New System.Windows.Forms.TextBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.DTPFechaCreacion = New System.Windows.Forms.DateTimePicker()
        Me.lblMedicamento = New System.Windows.Forms.Label()
        Me.txtMedicamento = New System.Windows.Forms.TextBox()
        Me.lblDosis = New System.Windows.Forms.Label()
        Me.txtDosis = New System.Windows.Forms.TextBox()
        Me.txtEnfermedad = New System.Windows.Forms.TextBox()
        Me.lblEnfermedad = New System.Windows.Forms.Label()
        Me.RECETASTableAdapter = New WindowsApp1.ConsultaMedicaDataSet1TableAdapters.RECETASTableAdapter()
        CType(Me.DataRecetas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RECETASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultaMedicaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Maiandra GD", 11.25!)
        Me.btnVolver.Location = New System.Drawing.Point(19, 546)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(89, 34)
        Me.btnVolver.TabIndex = 8
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Font = New System.Drawing.Font("Maiandra GD", 11.25!)
        Me.btnActualizar.Location = New System.Drawing.Point(863, 546)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(89, 34)
        Me.btnActualizar.TabIndex = 7
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Maiandra GD", 11.25!)
        Me.btnNuevo.Location = New System.Drawing.Point(863, 475)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(89, 34)
        Me.btnNuevo.TabIndex = 6
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 39)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Recetas medicas"
        '
        'DataRecetas
        '
        Me.DataRecetas.AllowUserToOrderColumns = True
        Me.DataRecetas.AutoGenerateColumns = False
        Me.DataRecetas.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataRecetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataRecetas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdRecetaDataGridViewTextBoxColumn, Me.IdMedicoDataGridViewTextBoxColumn, Me.IdPacienteDataGridViewTextBoxColumn, Me.FechaCreacionDataGridViewTextBoxColumn, Me.IdEnfermedadDataGridViewTextBoxColumn, Me.IdMedicamentoDataGridViewTextBoxColumn, Me.DosisDataGridViewTextBoxColumn})
        Me.DataRecetas.DataSource = Me.RECETASBindingSource
        Me.DataRecetas.GridColor = System.Drawing.SystemColors.ControlText
        Me.DataRecetas.Location = New System.Drawing.Point(182, 302)
        Me.DataRecetas.Name = "DataRecetas"
        Me.DataRecetas.Size = New System.Drawing.Size(644, 278)
        Me.DataRecetas.TabIndex = 69
        '
        'IdRecetaDataGridViewTextBoxColumn
        '
        Me.IdRecetaDataGridViewTextBoxColumn.DataPropertyName = "idReceta"
        Me.IdRecetaDataGridViewTextBoxColumn.HeaderText = "Num. Receta"
        Me.IdRecetaDataGridViewTextBoxColumn.Name = "IdRecetaDataGridViewTextBoxColumn"
        Me.IdRecetaDataGridViewTextBoxColumn.Visible = False
        '
        'IdMedicoDataGridViewTextBoxColumn
        '
        Me.IdMedicoDataGridViewTextBoxColumn.DataPropertyName = "idMedico"
        Me.IdMedicoDataGridViewTextBoxColumn.HeaderText = "Médico"
        Me.IdMedicoDataGridViewTextBoxColumn.Name = "IdMedicoDataGridViewTextBoxColumn"
        '
        'IdPacienteDataGridViewTextBoxColumn
        '
        Me.IdPacienteDataGridViewTextBoxColumn.DataPropertyName = "idPaciente"
        Me.IdPacienteDataGridViewTextBoxColumn.HeaderText = "Paciente"
        Me.IdPacienteDataGridViewTextBoxColumn.Name = "IdPacienteDataGridViewTextBoxColumn"
        '
        'FechaCreacionDataGridViewTextBoxColumn
        '
        Me.FechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "fechaCreacion"
        Me.FechaCreacionDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaCreacionDataGridViewTextBoxColumn.Name = "FechaCreacionDataGridViewTextBoxColumn"
        '
        'IdEnfermedadDataGridViewTextBoxColumn
        '
        Me.IdEnfermedadDataGridViewTextBoxColumn.DataPropertyName = "idEnfermedad"
        Me.IdEnfermedadDataGridViewTextBoxColumn.HeaderText = "Enfermedad"
        Me.IdEnfermedadDataGridViewTextBoxColumn.Name = "IdEnfermedadDataGridViewTextBoxColumn"
        '
        'IdMedicamentoDataGridViewTextBoxColumn
        '
        Me.IdMedicamentoDataGridViewTextBoxColumn.DataPropertyName = "idMedicamento"
        Me.IdMedicamentoDataGridViewTextBoxColumn.HeaderText = "Medicamento"
        Me.IdMedicamentoDataGridViewTextBoxColumn.Name = "IdMedicamentoDataGridViewTextBoxColumn"
        '
        'DosisDataGridViewTextBoxColumn
        '
        Me.DosisDataGridViewTextBoxColumn.DataPropertyName = "dosis"
        Me.DosisDataGridViewTextBoxColumn.HeaderText = "Dosis"
        Me.DosisDataGridViewTextBoxColumn.Name = "DosisDataGridViewTextBoxColumn"
        '
        'RECETASBindingSource
        '
        Me.RECETASBindingSource.DataMember = "RECETAS"
        Me.RECETASBindingSource.DataSource = Me.ConsultaMedicaDataSet1
        '
        'ConsultaMedicaDataSet
        '
        Me.ConsultaMedicaDataSet1.DataSetName = "ConsultaMedicaDataSet"
        Me.ConsultaMedicaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(788, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(176, 158)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 70
        Me.PictureBox1.TabStop = False
        '
        'lblIdReceta
        '
        Me.lblIdReceta.AutoSize = True
        Me.lblIdReceta.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.lblIdReceta.Location = New System.Drawing.Point(16, 92)
        Me.lblIdReceta.Name = "lblIdReceta"
        Me.lblIdReceta.Size = New System.Drawing.Size(80, 16)
        Me.lblIdReceta.TabIndex = 71
        Me.lblIdReceta.Text = "Num. Receta"
        '
        'txtIdReceta
        '
        Me.txtIdReceta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECETASBindingSource, "idReceta", True))
        Me.txtIdReceta.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.txtIdReceta.Location = New System.Drawing.Point(103, 92)
        Me.txtIdReceta.Name = "txtIdReceta"
        Me.txtIdReceta.ReadOnly = True
        Me.txtIdReceta.Size = New System.Drawing.Size(100, 23)
        Me.txtIdReceta.TabIndex = 72
        Me.txtIdReceta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMédico
        '
        Me.lblMédico.AutoSize = True
        Me.lblMédico.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.lblMédico.Location = New System.Drawing.Point(16, 150)
        Me.lblMédico.Name = "lblMédico"
        Me.lblMédico.Size = New System.Drawing.Size(51, 16)
        Me.lblMédico.TabIndex = 73
        Me.lblMédico.Text = "Médico"
        '
        'lblPaciente
        '
        Me.lblPaciente.AutoSize = True
        Me.lblPaciente.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.lblPaciente.Location = New System.Drawing.Point(16, 195)
        Me.lblPaciente.Name = "lblPaciente"
        Me.lblPaciente.Size = New System.Drawing.Size(53, 16)
        Me.lblPaciente.TabIndex = 74
        Me.lblPaciente.Text = "Paciente"
        '
        'txtPaciente
        '
        Me.txtPaciente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECETASBindingSource, "idPaciente", True))
        Me.txtPaciente.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.txtPaciente.Location = New System.Drawing.Point(103, 195)
        Me.txtPaciente.Name = "txtPaciente"
        Me.txtPaciente.Size = New System.Drawing.Size(229, 23)
        Me.txtPaciente.TabIndex = 1
        '
        'txtMedico
        '
        Me.txtMedico.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECETASBindingSource, "idMedico", True))
        Me.txtMedico.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.txtMedico.Location = New System.Drawing.Point(103, 150)
        Me.txtMedico.Name = "txtMedico"
        Me.txtMedico.Size = New System.Drawing.Size(229, 23)
        Me.txtMedico.TabIndex = 0
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.lblFecha.Location = New System.Drawing.Point(19, 242)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 16)
        Me.lblFecha.TabIndex = 77
        Me.lblFecha.Text = "Fecha"
        '
        'DTPFechaCreacion
        '
        Me.DTPFechaCreacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECETASBindingSource, "fechaCreacion", True))
        Me.DTPFechaCreacion.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RECETASBindingSource, "fechaCreacion", True))
        Me.DTPFechaCreacion.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.DTPFechaCreacion.Location = New System.Drawing.Point(103, 237)
        Me.DTPFechaCreacion.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.DTPFechaCreacion.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DTPFechaCreacion.Name = "DTPFechaCreacion"
        Me.DTPFechaCreacion.Size = New System.Drawing.Size(229, 23)
        Me.DTPFechaCreacion.TabIndex = 2
        '
        'lblMedicamento
        '
        Me.lblMedicamento.AutoSize = True
        Me.lblMedicamento.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.lblMedicamento.Location = New System.Drawing.Point(419, 186)
        Me.lblMedicamento.Name = "lblMedicamento"
        Me.lblMedicamento.Size = New System.Drawing.Size(85, 16)
        Me.lblMedicamento.TabIndex = 79
        Me.lblMedicamento.Text = "Medicamento"
        '
        'txtMedicamento
        '
        Me.txtMedicamento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECETASBindingSource, "idMedicamento", True))
        Me.txtMedicamento.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.txtMedicamento.Location = New System.Drawing.Point(506, 186)
        Me.txtMedicamento.Name = "txtMedicamento"
        Me.txtMedicamento.Size = New System.Drawing.Size(200, 23)
        Me.txtMedicamento.TabIndex = 4
        '
        'lblDosis
        '
        Me.lblDosis.AutoSize = True
        Me.lblDosis.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.lblDosis.Location = New System.Drawing.Point(419, 232)
        Me.lblDosis.Name = "lblDosis"
        Me.lblDosis.Size = New System.Drawing.Size(36, 16)
        Me.lblDosis.TabIndex = 81
        Me.lblDosis.Text = "Dosis"
        '
        'txtDosis
        '
        Me.txtDosis.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECETASBindingSource, "dosis", True))
        Me.txtDosis.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.txtDosis.Location = New System.Drawing.Point(506, 228)
        Me.txtDosis.Multiline = True
        Me.txtDosis.Name = "txtDosis"
        Me.txtDosis.Size = New System.Drawing.Size(295, 48)
        Me.txtDosis.TabIndex = 5
        '
        'txtEnfermedad
        '
        Me.txtEnfermedad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECETASBindingSource, "idEnfermedad", True))
        Me.txtEnfermedad.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.txtEnfermedad.Location = New System.Drawing.Point(506, 150)
        Me.txtEnfermedad.Name = "txtEnfermedad"
        Me.txtEnfermedad.Size = New System.Drawing.Size(200, 23)
        Me.txtEnfermedad.TabIndex = 3
        '
        'lblEnfermedad
        '
        Me.lblEnfermedad.AutoSize = True
        Me.lblEnfermedad.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.lblEnfermedad.Location = New System.Drawing.Point(419, 150)
        Me.lblEnfermedad.Name = "lblEnfermedad"
        Me.lblEnfermedad.Size = New System.Drawing.Size(76, 16)
        Me.lblEnfermedad.TabIndex = 83
        Me.lblEnfermedad.Text = "Enfermedad"
        '
        'RECETASTableAdapter
        '
        Me.RECETASTableAdapter.ClearBeforeFill = True
        '
        'Receta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(978, 589)
        Me.Controls.Add(Me.txtEnfermedad)
        Me.Controls.Add(Me.lblEnfermedad)
        Me.Controls.Add(Me.txtDosis)
        Me.Controls.Add(Me.lblDosis)
        Me.Controls.Add(Me.txtMedicamento)
        Me.Controls.Add(Me.lblMedicamento)
        Me.Controls.Add(Me.DTPFechaCreacion)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.txtMedico)
        Me.Controls.Add(Me.txtPaciente)
        Me.Controls.Add(Me.lblPaciente)
        Me.Controls.Add(Me.lblMédico)
        Me.Controls.Add(Me.txtIdReceta)
        Me.Controls.Add(Me.lblIdReceta)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataRecetas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnVolver)
        Me.Font = New System.Drawing.Font("Maiandra GD", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Receta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receta"
        CType(Me.DataRecetas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RECETASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultaMedicaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVolver As Button
    Friend WithEvents ConsultaMedicaDataSet1 As ConsultaMedicaDataSet1
    Friend WithEvents RECETASBindingSource As BindingSource
    Friend WithEvents RECETASTableAdapter As ConsultaMedicaDataSet1TableAdapters.RECETASTableAdapter
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataRecetas As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblIdReceta As Label
    Friend WithEvents txtIdReceta As TextBox
    Friend WithEvents lblMédico As Label
    Friend WithEvents lblPaciente As Label
    Friend WithEvents txtPaciente As TextBox
    Friend WithEvents txtMedico As TextBox
    Friend WithEvents lblFecha As Label
    Friend WithEvents DTPFechaCreacion As DateTimePicker
    Friend WithEvents lblMedicamento As Label
    Friend WithEvents txtMedicamento As TextBox
    Friend WithEvents lblDosis As Label
    Friend WithEvents txtDosis As TextBox
    Friend WithEvents txtEnfermedad As TextBox
    Friend WithEvents lblEnfermedad As Label
    Friend WithEvents IdRecetaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdMedicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdPacienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaCreacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdEnfermedadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdMedicamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DosisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
