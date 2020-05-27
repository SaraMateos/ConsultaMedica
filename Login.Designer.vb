<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblIniciarSesion = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Location = New System.Drawing.Point(627, 23)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(62, 32)
        Me.BtnNuevo.TabIndex = 4
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(27, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(308, 239)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(423, 265)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(85, 32)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Salir"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnIniciar
        '
        Me.btnIniciar.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnIniciar.Location = New System.Drawing.Point(573, 265)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(85, 32)
        Me.btnIniciar.TabIndex = 3
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(480, 117)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(161, 23)
        Me.txtUsuario.TabIndex = 0
        '
        'txtContrasena
        '
        Me.txtContrasena.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasena.Location = New System.Drawing.Point(480, 179)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasena.Size = New System.Drawing.Size(161, 23)
        Me.txtContrasena.TabIndex = 1
        '
        'lblContrasena
        '
        Me.lblContrasena.AutoSize = True
        Me.lblContrasena.Font = New System.Drawing.Font("Maiandra GD", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContrasena.Location = New System.Drawing.Point(350, 178)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(102, 22)
        Me.lblContrasena.TabIndex = 33
        Me.lblContrasena.Text = "Contraseña"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Maiandra GD", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(350, 116)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(73, 22)
        Me.lblUsuario.TabIndex = 32
        Me.lblUsuario.Text = "Usuario"
        '
        'lblIniciarSesion
        '
        Me.lblIniciarSesion.AutoSize = True
        Me.lblIniciarSesion.Font = New System.Drawing.Font("Maiandra GD", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIniciarSesion.Location = New System.Drawing.Point(34, 14)
        Me.lblIniciarSesion.Name = "lblIniciarSesion"
        Me.lblIniciarSesion.Size = New System.Drawing.Size(208, 39)
        Me.lblIniciarSesion.TabIndex = 31
        Me.lblIniciarSesion.Text = "Iniciar sesión"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(716, 324)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.lblContrasena)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.lblIniciarSesion)
        Me.Font = New System.Drawing.Font("Maiandra GD", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnNuevo As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnIniciar As Button
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents lblContrasena As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblIniciarSesion As Label
End Class
