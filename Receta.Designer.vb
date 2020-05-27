<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.IdRecetaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DosisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCreacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdMedicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPacienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEnfermedadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECETASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsultaMedicaDataSet = New WindowsApp1.ConsultaMedicaDataSet()
        Me.RECETASTableAdapter = New WindowsApp1.ConsultaMedicaDataSetTableAdapters.RECETASTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RECETASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultaMedicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(12, 695)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(89, 32)
        Me.btnVolver.TabIndex = 62
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdRecetaDataGridViewTextBoxColumn, Me.DosisDataGridViewTextBoxColumn, Me.FechaCreacionDataGridViewTextBoxColumn, Me.IdMedicoDataGridViewTextBoxColumn, Me.IdPacienteDataGridViewTextBoxColumn, Me.IdEnfermedadDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RECETASBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(363, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(647, 607)
        Me.DataGridView1.TabIndex = 64
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(937, 695)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(89, 32)
        Me.btnActualizar.TabIndex = 65
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'IdRecetaDataGridViewTextBoxColumn
        '
        Me.IdRecetaDataGridViewTextBoxColumn.DataPropertyName = "idReceta"
        Me.IdRecetaDataGridViewTextBoxColumn.HeaderText = "idReceta"
        Me.IdRecetaDataGridViewTextBoxColumn.Name = "IdRecetaDataGridViewTextBoxColumn"
        '
        'DosisDataGridViewTextBoxColumn
        '
        Me.DosisDataGridViewTextBoxColumn.DataPropertyName = "dosis"
        Me.DosisDataGridViewTextBoxColumn.HeaderText = "dosis"
        Me.DosisDataGridViewTextBoxColumn.Name = "DosisDataGridViewTextBoxColumn"
        '
        'FechaCreacionDataGridViewTextBoxColumn
        '
        Me.FechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "fechaCreacion"
        Me.FechaCreacionDataGridViewTextBoxColumn.HeaderText = "fechaCreacion"
        Me.FechaCreacionDataGridViewTextBoxColumn.Name = "FechaCreacionDataGridViewTextBoxColumn"
        '
        'IdMedicoDataGridViewTextBoxColumn
        '
        Me.IdMedicoDataGridViewTextBoxColumn.DataPropertyName = "idMedico"
        Me.IdMedicoDataGridViewTextBoxColumn.HeaderText = "idMedico"
        Me.IdMedicoDataGridViewTextBoxColumn.Name = "IdMedicoDataGridViewTextBoxColumn"
        '
        'IdPacienteDataGridViewTextBoxColumn
        '
        Me.IdPacienteDataGridViewTextBoxColumn.DataPropertyName = "idPaciente"
        Me.IdPacienteDataGridViewTextBoxColumn.HeaderText = "idPaciente"
        Me.IdPacienteDataGridViewTextBoxColumn.Name = "IdPacienteDataGridViewTextBoxColumn"
        '
        'IdEnfermedadDataGridViewTextBoxColumn
        '
        Me.IdEnfermedadDataGridViewTextBoxColumn.DataPropertyName = "idEnfermedad"
        Me.IdEnfermedadDataGridViewTextBoxColumn.HeaderText = "idEnfermedad"
        Me.IdEnfermedadDataGridViewTextBoxColumn.Name = "IdEnfermedadDataGridViewTextBoxColumn"
        '
        'RECETASBindingSource
        '
        Me.RECETASBindingSource.DataMember = "RECETAS"
        Me.RECETASBindingSource.DataSource = Me.ConsultaMedicaDataSet
        '
        'ConsultaMedicaDataSet
        '
        Me.ConsultaMedicaDataSet.DataSetName = "ConsultaMedicaDataSet"
        Me.ConsultaMedicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RECETASTableAdapter
        '
        Me.RECETASTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(601, 695)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 32)
        Me.Button1.TabIndex = 66
        Me.Button1.Text = "reporte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Receta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1038, 739)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnVolver)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Receta"
        Me.Text = "Receta"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RECETASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultaMedicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnVolver As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ConsultaMedicaDataSet As ConsultaMedicaDataSet
    Friend WithEvents RECETASBindingSource As BindingSource
    Friend WithEvents RECETASTableAdapter As ConsultaMedicaDataSetTableAdapters.RECETASTableAdapter
    Friend WithEvents IdRecetaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DosisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaCreacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdMedicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdPacienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdEnfermedadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnActualizar As Button
    Friend WithEvents Button1 As Button
End Class
