﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Consulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consulta))
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.txtTratamiento = New System.Windows.Forms.TextBox()
        Me.CONSULTABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsultaMedicaDataSet = New WindowsApp1.ConsultaMedicaDataSet()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDiagnostico = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMotivo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PACIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtNumHistorial = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtPacientes = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.DataConsultas = New System.Windows.Forms.DataGridView()
        Me.IdConsultaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPacienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdMedicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaRealizadaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotivoConsultaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiagnosticoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TratamientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idEnfermedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNombreMedico = New System.Windows.Forms.TextBox()
        Me.DTPFechaRealizada = New System.Windows.Forms.DateTimePicker()
        Me.txtEnfermedad = New System.Windows.Forms.TextBox()
        Me.lblEnfermedad = New System.Windows.Forms.Label()
        Me.CONSULTATableAdapter = New WindowsApp1.ConsultaMedicaDataSetTableAdapters.CONSULTATableAdapter()
        Me.PACIENTESTableAdapter = New WindowsApp1.ConsultaMedicaDataSetTableAdapters.PACIENTESTableAdapter()
        Me.MEDICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEDICOSTableAdapter = New WindowsApp1.ConsultaMedicaDataSetTableAdapters.MEDICOSTableAdapter()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        CType(Me.CONSULTABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultaMedicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Maiandra GD", 11.25!)
        Me.btnVolver.Location = New System.Drawing.Point(19, 534)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(89, 34)
        Me.btnVolver.TabIndex = 79
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'txtTratamiento
        '
        Me.txtTratamiento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONSULTABindingSource, "tratamiento", True))
        Me.txtTratamiento.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.txtTratamiento.Location = New System.Drawing.Point(21, 439)
        Me.txtTratamiento.Multiline = True
        Me.txtTratamiento.Name = "txtTratamiento"
        Me.txtTratamiento.Size = New System.Drawing.Size(639, 71)
        Me.txtTratamiento.TabIndex = 76
        '
        'CONSULTABindingSource
        '
        Me.CONSULTABindingSource.DataMember = "CONSULTA"
        Me.CONSULTABindingSource.DataSource = Me.ConsultaMedicaDataSet
        '
        'ConsultaMedicaDataSet
        '
        Me.ConsultaMedicaDataSet.DataSetName = "ConsultaMedicaDataSet"
        Me.ConsultaMedicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(18, 422)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Tratamiento:"
        '
        'txtDiagnostico
        '
        Me.txtDiagnostico.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONSULTABindingSource, "diagnostico", True))
        Me.txtDiagnostico.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.txtDiagnostico.Location = New System.Drawing.Point(21, 336)
        Me.txtDiagnostico.Multiline = True
        Me.txtDiagnostico.Name = "txtDiagnostico"
        Me.txtDiagnostico.Size = New System.Drawing.Size(639, 71)
        Me.txtDiagnostico.TabIndex = 74
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(18, 319)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 16)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Diagnóstico:"
        '
        'txtMotivo
        '
        Me.txtMotivo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONSULTABindingSource, "motivoConsulta", True))
        Me.txtMotivo.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.txtMotivo.Location = New System.Drawing.Point(21, 235)
        Me.txtMotivo.Multiline = True
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(639, 71)
        Me.txtMotivo.TabIndex = 71
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(18, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 16)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Motivo de consulta:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(18, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 16)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "Fecha de consulta"
        '
        'btnBorrar
        '
        Me.btnBorrar.Font = New System.Drawing.Font("Maiandra GD", 11.25!)
        Me.btnBorrar.Location = New System.Drawing.Point(577, 534)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(83, 34)
        Me.btnBorrar.TabIndex = 69
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Maiandra GD", 11.25!)
        Me.btnNuevo.Location = New System.Drawing.Point(467, 534)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(89, 34)
        Me.btnNuevo.TabIndex = 67
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(18, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Médico"
        '
        'PACIENTESBindingSource
        '
        Me.PACIENTESBindingSource.DataMember = "PACIENTES"
        Me.PACIENTESBindingSource.DataSource = Me.ConsultaMedicaDataSet
        '
        'txtNumHistorial
        '
        Me.txtNumHistorial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONSULTABindingSource, "idPaciente", True))
        Me.txtNumHistorial.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.txtNumHistorial.Location = New System.Drawing.Point(133, 108)
        Me.txtNumHistorial.Multiline = True
        Me.txtNumHistorial.Name = "txtNumHistorial"
        Me.txtNumHistorial.Size = New System.Drawing.Size(163, 21)
        Me.txtNumHistorial.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(18, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Num. Historial"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.txtPacientes)
        Me.GroupBox1.Controls.Add(Me.lblBuscar)
        Me.GroupBox1.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(681, 74)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Maiandra GD", 11.25!)
        Me.btnBuscar.Location = New System.Drawing.Point(600, 27)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 25)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtPacientes
        '
        Me.txtPacientes.Location = New System.Drawing.Point(109, 27)
        Me.txtPacientes.Multiline = True
        Me.txtPacientes.Name = "txtPacientes"
        Me.txtPacientes.Size = New System.Drawing.Size(485, 24)
        Me.txtPacientes.TabIndex = 1
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(6, 31)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(90, 16)
        Me.lblBuscar.TabIndex = 0
        Me.lblBuscar.Text = "Num. Historial"
        '
        'DataConsultas
        '
        Me.DataConsultas.AllowUserToOrderColumns = True
        Me.DataConsultas.AutoGenerateColumns = False
        Me.DataConsultas.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataConsultas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdConsultaDataGridViewTextBoxColumn, Me.IdPacienteDataGridViewTextBoxColumn, Me.IdMedicoDataGridViewTextBoxColumn, Me.FechaRealizadaDataGridViewTextBoxColumn, Me.MotivoConsultaDataGridViewTextBoxColumn, Me.DiagnosticoDataGridViewTextBoxColumn, Me.TratamientoDataGridViewTextBoxColumn, Me.idEnfermedad})
        Me.DataConsultas.DataSource = Me.CONSULTABindingSource
        Me.DataConsultas.GridColor = System.Drawing.SystemColors.ControlText
        Me.DataConsultas.Location = New System.Drawing.Point(712, 71)
        Me.DataConsultas.Name = "DataConsultas"
        Me.DataConsultas.Size = New System.Drawing.Size(646, 497)
        Me.DataConsultas.TabIndex = 80
        '
        'IdConsultaDataGridViewTextBoxColumn
        '
        Me.IdConsultaDataGridViewTextBoxColumn.DataPropertyName = "idConsulta"
        Me.IdConsultaDataGridViewTextBoxColumn.HeaderText = "Consulta"
        Me.IdConsultaDataGridViewTextBoxColumn.Name = "IdConsultaDataGridViewTextBoxColumn"
        Me.IdConsultaDataGridViewTextBoxColumn.Visible = False
        Me.IdConsultaDataGridViewTextBoxColumn.Width = 30
        '
        'IdPacienteDataGridViewTextBoxColumn
        '
        Me.IdPacienteDataGridViewTextBoxColumn.DataPropertyName = "idPaciente"
        Me.IdPacienteDataGridViewTextBoxColumn.HeaderText = "Num. Paciente"
        Me.IdPacienteDataGridViewTextBoxColumn.Name = "IdPacienteDataGridViewTextBoxColumn"
        Me.IdPacienteDataGridViewTextBoxColumn.Width = 60
        '
        'IdMedicoDataGridViewTextBoxColumn
        '
        Me.IdMedicoDataGridViewTextBoxColumn.DataPropertyName = "idMedico"
        Me.IdMedicoDataGridViewTextBoxColumn.HeaderText = "Medico"
        Me.IdMedicoDataGridViewTextBoxColumn.Name = "IdMedicoDataGridViewTextBoxColumn"
        Me.IdMedicoDataGridViewTextBoxColumn.Width = 60
        '
        'FechaRealizadaDataGridViewTextBoxColumn
        '
        Me.FechaRealizadaDataGridViewTextBoxColumn.DataPropertyName = "fechaRealizada"
        Me.FechaRealizadaDataGridViewTextBoxColumn.HeaderText = "Fecha de la consulta"
        Me.FechaRealizadaDataGridViewTextBoxColumn.Name = "FechaRealizadaDataGridViewTextBoxColumn"
        '
        'MotivoConsultaDataGridViewTextBoxColumn
        '
        Me.MotivoConsultaDataGridViewTextBoxColumn.DataPropertyName = "motivoConsulta"
        Me.MotivoConsultaDataGridViewTextBoxColumn.HeaderText = "Motivo"
        Me.MotivoConsultaDataGridViewTextBoxColumn.Name = "MotivoConsultaDataGridViewTextBoxColumn"
        '
        'DiagnosticoDataGridViewTextBoxColumn
        '
        Me.DiagnosticoDataGridViewTextBoxColumn.DataPropertyName = "diagnostico"
        Me.DiagnosticoDataGridViewTextBoxColumn.HeaderText = "Diagnostico"
        Me.DiagnosticoDataGridViewTextBoxColumn.Name = "DiagnosticoDataGridViewTextBoxColumn"
        '
        'TratamientoDataGridViewTextBoxColumn
        '
        Me.TratamientoDataGridViewTextBoxColumn.DataPropertyName = "tratamiento"
        Me.TratamientoDataGridViewTextBoxColumn.HeaderText = "Tratamiento"
        Me.TratamientoDataGridViewTextBoxColumn.Name = "TratamientoDataGridViewTextBoxColumn"
        '
        'idEnfermedad
        '
        Me.idEnfermedad.DataPropertyName = "idEnfermedad"
        Me.idEnfermedad.HeaderText = "idEnfermedad"
        Me.idEnfermedad.Name = "idEnfermedad"
        Me.idEnfermedad.Width = 80
        '
        'txtNombreMedico
        '
        Me.txtNombreMedico.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONSULTABindingSource, "idMedico", True))
        Me.txtNombreMedico.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.txtNombreMedico.Location = New System.Drawing.Point(133, 145)
        Me.txtNombreMedico.Multiline = True
        Me.txtNombreMedico.Name = "txtNombreMedico"
        Me.txtNombreMedico.Size = New System.Drawing.Size(335, 21)
        Me.txtNombreMedico.TabIndex = 81
        '
        'DTPFechaRealizada
        '
        Me.DTPFechaRealizada.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONSULTABindingSource, "fechaRealizada", True))
        Me.DTPFechaRealizada.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.DTPFechaRealizada.Location = New System.Drawing.Point(133, 184)
        Me.DTPFechaRealizada.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.DTPFechaRealizada.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DTPFechaRealizada.Name = "DTPFechaRealizada"
        Me.DTPFechaRealizada.Size = New System.Drawing.Size(335, 23)
        Me.DTPFechaRealizada.TabIndex = 20
        '
        'txtEnfermedad
        '
        Me.txtEnfermedad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONSULTABindingSource, "idEnfermedad", True))
        Me.txtEnfermedad.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.txtEnfermedad.Location = New System.Drawing.Point(497, 187)
        Me.txtEnfermedad.Multiline = True
        Me.txtEnfermedad.Name = "txtEnfermedad"
        Me.txtEnfermedad.Size = New System.Drawing.Size(163, 21)
        Me.txtEnfermedad.TabIndex = 84
        '
        'lblEnfermedad
        '
        Me.lblEnfermedad.AutoSize = True
        Me.lblEnfermedad.Font = New System.Drawing.Font("Maiandra GD", 9.75!)
        Me.lblEnfermedad.Location = New System.Drawing.Point(494, 170)
        Me.lblEnfermedad.Name = "lblEnfermedad"
        Me.lblEnfermedad.Size = New System.Drawing.Size(76, 16)
        Me.lblEnfermedad.TabIndex = 83
        Me.lblEnfermedad.Text = "Enfermedad"
        '
        'CONSULTATableAdapter
        '
        Me.CONSULTATableAdapter.ClearBeforeFill = True
        '
        'PACIENTESTableAdapter
        '
        Me.PACIENTESTableAdapter.ClearBeforeFill = True
        '
        'MEDICOSBindingSource
        '
        Me.MEDICOSBindingSource.DataMember = "MEDICOS"
        Me.MEDICOSBindingSource.DataSource = Me.ConsultaMedicaDataSet
        '
        'MEDICOSTableAdapter
        '
        Me.MEDICOSTableAdapter.ClearBeforeFill = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguiente.Image = CType(resources.GetObject("btnSiguiente.Image"), System.Drawing.Image)
        Me.btnSiguiente.Location = New System.Drawing.Point(1301, 13)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(56, 52)
        Me.btnSiguiente.TabIndex = 86
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnterior.Image = CType(resources.GetObject("btnAnterior.Image"), System.Drawing.Image)
        Me.btnAnterior.Location = New System.Drawing.Point(1239, 13)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(56, 52)
        Me.btnAnterior.TabIndex = 85
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Font = New System.Drawing.Font("Maiandra GD", 11.25!)
        Me.btnActualizar.Location = New System.Drawing.Point(712, 33)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(79, 32)
        Me.btnActualizar.TabIndex = 87
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'Consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1376, 579)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.txtEnfermedad)
        Me.Controls.Add(Me.lblEnfermedad)
        Me.Controls.Add(Me.DTPFechaRealizada)
        Me.Controls.Add(Me.txtNombreMedico)
        Me.Controls.Add(Me.DataConsultas)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.txtTratamiento)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDiagnostico)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtMotivo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNumHistorial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Maiandra GD", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Consulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta"
        CType(Me.CONSULTABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultaMedicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PACIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVolver As Button
    Friend WithEvents txtTratamiento As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDiagnostico As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMotivo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNumHistorial As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtPacientes As TextBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents DataConsultas As DataGridView
    Friend WithEvents ConsultaMedicaDataSet As ConsultaMedicaDataSet
    Friend WithEvents CONSULTABindingSource As BindingSource
    Friend WithEvents CONSULTATableAdapter As ConsultaMedicaDataSetTableAdapters.CONSULTATableAdapter
    Friend WithEvents DiagnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtNombreMedico As TextBox
    Friend WithEvents DTPFechaRealizada As DateTimePicker
    Friend WithEvents PACIENTESBindingSource As BindingSource
    Friend WithEvents PACIENTESTableAdapter As ConsultaMedicaDataSetTableAdapters.PACIENTESTableAdapter
    Friend WithEvents MEDICOSBindingSource As BindingSource
    Friend WithEvents MEDICOSTableAdapter As ConsultaMedicaDataSetTableAdapters.MEDICOSTableAdapter
    Friend WithEvents txtEnfermedad As TextBox
    Friend WithEvents lblEnfermedad As Label
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents IdConsultaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdPacienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdMedicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaRealizadaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MotivoConsultaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiagnosticoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TratamientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents idEnfermedad As DataGridViewTextBoxColumn
    Friend WithEvents btnActualizar As Button
End Class
