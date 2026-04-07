<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registroClientes
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
        txtNombre = New TextBox()
        txtEdad = New TextBox()
        txtTelefono = New TextBox()
        txtContacto = New TextBox()
        nombre = New Label()
        edad = New Label()
        genero = New Label()
        telefono = New Label()
        contacto = New Label()
        Panel1 = New Panel()
        RegCli = New Label()
        btnLimpiar = New Button()
        btnGuardar = New Button()
        btnFemenino = New Button()
        btnMasculino = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(32, 120)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(233, 23)
        txtNombre.TabIndex = 0
        ' 
        ' txtEdad
        ' 
        txtEdad.Location = New Point(32, 193)
        txtEdad.Name = "txtEdad"
        txtEdad.Size = New Size(233, 23)
        txtEdad.TabIndex = 1
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(32, 337)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(233, 23)
        txtTelefono.TabIndex = 3
        ' 
        ' txtContacto
        ' 
        txtContacto.Location = New Point(32, 405)
        txtContacto.Name = "txtContacto"
        txtContacto.Size = New Size(233, 23)
        txtContacto.TabIndex = 4
        ' 
        ' nombre
        ' 
        nombre.AutoSize = True
        nombre.Font = New Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        nombre.ForeColor = SystemColors.ControlDarkDark
        nombre.Location = New Point(36, 98)
        nombre.Name = "nombre"
        nombre.Size = New Size(58, 17)
        nombre.TabIndex = 5
        nombre.Text = "Nombre"
        ' 
        ' edad
        ' 
        edad.AutoSize = True
        edad.Font = New Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        edad.ForeColor = SystemColors.ControlDarkDark
        edad.Location = New Point(36, 173)
        edad.Name = "edad"
        edad.Size = New Size(38, 17)
        edad.TabIndex = 6
        edad.Text = "Edad"
        ' 
        ' genero
        ' 
        genero.AutoSize = True
        genero.Font = New Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        genero.ForeColor = SystemColors.ControlDarkDark
        genero.Location = New Point(36, 240)
        genero.Name = "genero"
        genero.Size = New Size(52, 17)
        genero.TabIndex = 7
        genero.Text = "Genero"
        ' 
        ' telefono
        ' 
        telefono.AutoSize = True
        telefono.Font = New Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        telefono.ForeColor = SystemColors.ControlDarkDark
        telefono.Location = New Point(36, 317)
        telefono.Name = "telefono"
        telefono.Size = New Size(59, 17)
        telefono.TabIndex = 8
        telefono.Text = "Telefono"
        ' 
        ' contacto
        ' 
        contacto.AutoSize = True
        contacto.Font = New Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        contacto.ForeColor = SystemColors.ControlDarkDark
        contacto.Location = New Point(36, 385)
        contacto.Name = "contacto"
        contacto.Size = New Size(63, 17)
        contacto.TabIndex = 9
        contacto.Text = "Contacto"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(96), CByte(126), CByte(184))
        Panel1.Controls.Add(RegCli)
        Panel1.Location = New Point(-4, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(304, 71)
        Panel1.TabIndex = 10
        ' 
        ' RegCli
        ' 
        RegCli.AutoSize = True
        RegCli.BackColor = Color.FromArgb(CByte(96), CByte(126), CByte(184))
        RegCli.Font = New Font("Brush Script MT", 21.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        RegCli.ForeColor = SystemColors.ControlLightLight
        RegCli.Location = New Point(40, 19)
        RegCli.Name = "RegCli"
        RegCli.Size = New Size(224, 36)
        RegCli.TabIndex = 0
        RegCli.Text = "Registrar nuevo cliente"
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.BackColor = Color.FromArgb(CByte(205), CByte(111), CByte(162))
        btnLimpiar.Font = New Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLimpiar.ForeColor = SystemColors.ControlLightLight
        btnLimpiar.Location = New Point(32, 458)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(113, 32)
        btnLimpiar.TabIndex = 13
        btnLimpiar.Text = "LIMPIAR"
        btnLimpiar.UseVisualStyleBackColor = False
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.FromArgb(CByte(96), CByte(126), CByte(184))
        btnGuardar.Font = New Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGuardar.ForeColor = SystemColors.ControlLightLight
        btnGuardar.Location = New Point(152, 458)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(113, 32)
        btnGuardar.TabIndex = 14
        btnGuardar.Text = "GUARDAR"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnFemenino
        ' 
        btnFemenino.BackColor = Color.FromArgb(CByte(96), CByte(126), CByte(184))
        btnFemenino.Font = New Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnFemenino.ForeColor = SystemColors.ControlLightLight
        btnFemenino.Location = New Point(152, 270)
        btnFemenino.Name = "btnFemenino"
        btnFemenino.Size = New Size(113, 32)
        btnFemenino.TabIndex = 16
        btnFemenino.Text = "Femnino"
        btnFemenino.UseVisualStyleBackColor = False
        ' 
        ' btnMasculino
        ' 
        btnMasculino.BackColor = Color.FromArgb(CByte(96), CByte(126), CByte(184))
        btnMasculino.Font = New Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMasculino.ForeColor = SystemColors.ControlLightLight
        btnMasculino.Location = New Point(32, 270)
        btnMasculino.Name = "btnMasculino"
        btnMasculino.Size = New Size(113, 32)
        btnMasculino.TabIndex = 15
        btnMasculino.Text = "Masculino"
        btnMasculino.UseVisualStyleBackColor = False
        ' 
        ' registroClientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(252), CByte(255))
        ClientSize = New Size(299, 515)
        Controls.Add(btnFemenino)
        Controls.Add(btnMasculino)
        Controls.Add(btnGuardar)
        Controls.Add(btnLimpiar)
        Controls.Add(Panel1)
        Controls.Add(contacto)
        Controls.Add(telefono)
        Controls.Add(genero)
        Controls.Add(edad)
        Controls.Add(nombre)
        Controls.Add(txtContacto)
        Controls.Add(txtTelefono)
        Controls.Add(txtEdad)
        Controls.Add(txtNombre)
        Name = "registroClientes"
        Text = "registroClientes"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtContacto As TextBox
    Friend WithEvents nombre As Label
    Friend WithEvents edad As Label
    Friend WithEvents genero As Label
    Friend WithEvents telefono As Label
    Friend WithEvents contacto As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RegCli As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnFemenino As Button
    Friend WithEvents btnMasculino As Button
End Class
