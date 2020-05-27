<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.lblConsultas = New System.Windows.Forms.Label()
        Me.lblRecetas = New System.Windows.Forms.Label()
        Me.lblDoctor = New System.Windows.Forms.Label()
        Me.lblPacient = New System.Windows.Forms.Label()
        Me.btnRecetas = New System.Windows.Forms.Button()
        Me.btnConsultas = New System.Windows.Forms.Button()
        Me.btnMedicos = New System.Windows.Forms.Button()
        Me.btnPacientes = New System.Windows.Forms.Button()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblConsultas
        '
        Me.lblConsultas.AutoSize = True
        Me.lblConsultas.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblConsultas.Location = New System.Drawing.Point(342, 28)
        Me.lblConsultas.Name = "lblConsultas"
        Me.lblConsultas.Size = New System.Drawing.Size(72, 18)
        Me.lblConsultas.TabIndex = 27
        Me.lblConsultas.Text = "Consulta"
        '
        'lblRecetas
        '
        Me.lblRecetas.AutoSize = True
        Me.lblRecetas.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblRecetas.Location = New System.Drawing.Point(342, 250)
        Me.lblRecetas.Name = "lblRecetas"
        Me.lblRecetas.Size = New System.Drawing.Size(62, 18)
        Me.lblRecetas.TabIndex = 26
        Me.lblRecetas.Text = "Recetas"
        '
        'lblDoctor
        '
        Me.lblDoctor.AutoSize = True
        Me.lblDoctor.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblDoctor.Location = New System.Drawing.Point(49, 244)
        Me.lblDoctor.Name = "lblDoctor"
        Me.lblDoctor.Size = New System.Drawing.Size(69, 18)
        Me.lblDoctor.TabIndex = 25
        Me.lblDoctor.Text = "Médicos"
        '
        'lblPacient
        '
        Me.lblPacient.AutoSize = True
        Me.lblPacient.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPacient.Location = New System.Drawing.Point(49, 28)
        Me.lblPacient.Name = "lblPacient"
        Me.lblPacient.Size = New System.Drawing.Size(74, 18)
        Me.lblPacient.TabIndex = 24
        Me.lblPacient.Text = "Pacientes"
        '
        'btnRecetas
        '
        Me.btnRecetas.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnRecetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecetas.Image = CType(resources.GetObject("btnRecetas.Image"), System.Drawing.Image)
        Me.btnRecetas.Location = New System.Drawing.Point(345, 267)
        Me.btnRecetas.Name = "btnRecetas"
        Me.btnRecetas.Size = New System.Drawing.Size(156, 154)
        Me.btnRecetas.TabIndex = 3
        Me.btnRecetas.UseVisualStyleBackColor = True
        '
        'btnConsultas
        '
        Me.btnConsultas.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultas.Image = CType(resources.GetObject("btnConsultas.Image"), System.Drawing.Image)
        Me.btnConsultas.Location = New System.Drawing.Point(345, 51)
        Me.btnConsultas.Name = "btnConsultas"
        Me.btnConsultas.Size = New System.Drawing.Size(156, 154)
        Me.btnConsultas.TabIndex = 1
        Me.btnConsultas.UseVisualStyleBackColor = True
        '
        'btnMedicos
        '
        Me.btnMedicos.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMedicos.Image = CType(resources.GetObject("btnMedicos.Image"), System.Drawing.Image)
        Me.btnMedicos.Location = New System.Drawing.Point(52, 267)
        Me.btnMedicos.Name = "btnMedicos"
        Me.btnMedicos.Size = New System.Drawing.Size(158, 154)
        Me.btnMedicos.TabIndex = 2
        Me.btnMedicos.UseVisualStyleBackColor = True
        '
        'btnPacientes
        '
        Me.btnPacientes.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPacientes.Image = CType(resources.GetObject("btnPacientes.Image"), System.Drawing.Image)
        Me.btnPacientes.Location = New System.Drawing.Point(52, 51)
        Me.btnPacientes.Name = "btnPacientes"
        Me.btnPacientes.Size = New System.Drawing.Size(158, 154)
        Me.btnPacientes.TabIndex = 0
        Me.btnPacientes.UseVisualStyleBackColor = True
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnCerrarSesion.Image = CType(resources.GetObject("btnCerrarSesion.Image"), System.Drawing.Image)
        Me.btnCerrarSesion.Location = New System.Drawing.Point(508, 5)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(27, 32)
        Me.btnCerrarSesion.TabIndex = 4
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(547, 456)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Controls.Add(Me.lblConsultas)
        Me.Controls.Add(Me.lblRecetas)
        Me.Controls.Add(Me.lblDoctor)
        Me.Controls.Add(Me.lblPacient)
        Me.Controls.Add(Me.btnRecetas)
        Me.Controls.Add(Me.btnConsultas)
        Me.Controls.Add(Me.btnMedicos)
        Me.Controls.Add(Me.btnPacientes)
        Me.Font = New System.Drawing.Font("Maiandra GD", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblConsultas As Label
    Friend WithEvents lblRecetas As Label
    Friend WithEvents lblDoctor As Label
    Friend WithEvents lblPacient As Label
    Friend WithEvents btnRecetas As Button
    Friend WithEvents btnConsultas As Button
    Friend WithEvents btnMedicos As Button
    Friend WithEvents btnPacientes As Button
    Friend WithEvents btnCerrarSesion As Button
End Class
