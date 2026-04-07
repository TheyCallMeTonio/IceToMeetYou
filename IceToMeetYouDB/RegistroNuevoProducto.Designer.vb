<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroNuevoProducto
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
        txtStock = New TextBox()
        txtPrecioUnitario = New TextBox()
        txtIdcategoria = New TextBox()
        txtIdProveedor = New TextBox()
        nombre = New Label()
        precioU = New Label()
        categoria = New Label()
        stock = New Label()
        proveedor = New Label()
        btnGuardar = New Button()
        Panel1 = New Panel()
        RegistroPro = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(34, 132)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(127, 23)
        txtNombre.TabIndex = 0
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(34, 209)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(127, 23)
        txtStock.TabIndex = 1
        ' 
        ' txtPrecioUnitario
        ' 
        txtPrecioUnitario.Location = New Point(186, 132)
        txtPrecioUnitario.Name = "txtPrecioUnitario"
        txtPrecioUnitario.Size = New Size(127, 23)
        txtPrecioUnitario.TabIndex = 2
        ' 
        ' txtIdcategoria
        ' 
        txtIdcategoria.Location = New Point(186, 209)
        txtIdcategoria.Name = "txtIdcategoria"
        txtIdcategoria.Size = New Size(127, 23)
        txtIdcategoria.TabIndex = 3
        ' 
        ' txtIdProveedor
        ' 
        txtIdProveedor.Location = New Point(34, 285)
        txtIdProveedor.Name = "txtIdProveedor"
        txtIdProveedor.Size = New Size(127, 23)
        txtIdProveedor.TabIndex = 4
        ' 
        ' nombre
        ' 
        nombre.AutoSize = True
        nombre.Font = New Font("Yu Gothic", 9.75F)
        nombre.Location = New Point(34, 98)
        nombre.Name = "nombre"
        nombre.Size = New Size(56, 17)
        nombre.TabIndex = 5
        nombre.Text = "Nombre"
        ' 
        ' precioU
        ' 
        precioU.AutoSize = True
        precioU.Font = New Font("Yu Gothic", 9.75F)
        precioU.Location = New Point(186, 98)
        precioU.Name = "precioU"
        precioU.Size = New Size(98, 17)
        precioU.TabIndex = 6
        precioU.Text = "Precio Unitario"
        ' 
        ' categoria
        ' 
        categoria.AutoSize = True
        categoria.Font = New Font("Yu Gothic", 9.75F)
        categoria.Location = New Point(186, 178)
        categoria.Name = "categoria"
        categoria.Size = New Size(65, 17)
        categoria.TabIndex = 8
        categoria.Text = "Categoria"
        ' 
        ' stock
        ' 
        stock.AutoSize = True
        stock.Font = New Font("Yu Gothic", 9.75F)
        stock.Location = New Point(34, 178)
        stock.Name = "stock"
        stock.Size = New Size(42, 17)
        stock.TabIndex = 7
        stock.Text = "Stock"
        ' 
        ' proveedor
        ' 
        proveedor.AutoSize = True
        proveedor.Font = New Font("Yu Gothic", 9.75F)
        proveedor.Location = New Point(34, 258)
        proveedor.Name = "proveedor"
        proveedor.Size = New Size(69, 17)
        proveedor.TabIndex = 9
        proveedor.Text = "Proveedor"
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.FromArgb(CByte(96), CByte(126), CByte(184))
        btnGuardar.Font = New Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGuardar.ForeColor = SystemColors.ControlLightLight
        btnGuardar.Location = New Point(186, 279)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Padding = New Padding(2)
        btnGuardar.Size = New Size(127, 28)
        btnGuardar.TabIndex = 10
        btnGuardar.Text = "GUARDAR"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(96), CByte(126), CByte(184))
        Panel1.Controls.Add(RegistroPro)
        Panel1.Location = New Point(1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(349, 69)
        Panel1.TabIndex = 11
        ' 
        ' RegistroPro
        ' 
        RegistroPro.AutoSize = True
        RegistroPro.Font = New Font("Vladimir Script", 26.25F)
        RegistroPro.ForeColor = SystemColors.ControlLightLight
        RegistroPro.Location = New Point(20, 9)
        RegistroPro.Name = "RegistroPro"
        RegistroPro.Padding = New Padding(0, 4, 0, 0)
        RegistroPro.Size = New Size(304, 46)
        RegistroPro.TabIndex = 0
        RegistroPro.Text = "Registrar nuevo producto"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(349, 137)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 12
        Label1.Text = "Label1"
        ' 
        ' RegistroNuevoProducto
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(252), CByte(255))
        ClientSize = New Size(348, 339)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(btnGuardar)
        Controls.Add(proveedor)
        Controls.Add(categoria)
        Controls.Add(stock)
        Controls.Add(precioU)
        Controls.Add(nombre)
        Controls.Add(txtIdProveedor)
        Controls.Add(txtIdcategoria)
        Controls.Add(txtPrecioUnitario)
        Controls.Add(txtStock)
        Controls.Add(txtNombre)
        Name = "RegistroNuevoProducto"
        Text = "RegistroNuevoProducto"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtPrecioUnitario As TextBox
    Friend WithEvents txtIdcategoria As TextBox
    Friend WithEvents txtIdProveedor As TextBox
    Friend WithEvents nombre As Label
    Friend WithEvents precioU As Label
    Friend WithEvents categoria As Label
    Friend WithEvents stock As Label
    Friend WithEvents proveedor As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RegistroPro As Label
    Friend WithEvents Label1 As Label
End Class
