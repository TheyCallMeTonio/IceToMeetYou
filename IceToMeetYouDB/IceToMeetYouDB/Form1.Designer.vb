<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Titulo = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        ListProv = New Button()
        btnVerInventario = New Button()
        btnClienteSinDoc = New Button()
        btnBuscar = New Button()
        txtBusquedaCliente = New TextBox()
        NuevaVenta = New Label()
        Productotext = New Label()
        BuscarProducto = New TextBox()
        BuscarPro = New Button()
        TextBox2 = New TextBox()
        dgvInventario = New DataGridView()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(dgvInventario, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(96), CByte(126), CByte(184))
        Panel1.Controls.Add(Titulo)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(-4, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(992, 51)
        Panel1.TabIndex = 0
        ' 
        ' Titulo
        ' 
        Titulo.AutoSize = True
        Titulo.Font = New Font("Vladimir Script", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Titulo.ForeColor = SystemColors.ControlLightLight
        Titulo.Location = New Point(84, 9)
        Titulo.Name = "Titulo"
        Titulo.Size = New Size(194, 35)
        Titulo.TabIndex = 1
        Titulo.Text = "Ice To Meet You"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.holi__1_
        PictureBox1.Location = New Point(40, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(38, 42)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(241), CByte(246), CByte(255))
        Panel2.Controls.Add(ListProv)
        Panel2.Controls.Add(btnVerInventario)
        Panel2.Controls.Add(btnClienteSinDoc)
        Panel2.Controls.Add(btnBuscar)
        Panel2.Controls.Add(txtBusquedaCliente)
        Panel2.Controls.Add(NuevaVenta)
        Panel2.Location = New Point(-1, 51)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(989, 58)
        Panel2.TabIndex = 1
        ' 
        ' ListProv
        ' 
        ListProv.Font = New Font("Yu Gothic", 9F)
        ListProv.Location = New Point(795, 18)
        ListProv.Name = "ListProv"
        ListProv.Size = New Size(164, 22)
        ListProv.TabIndex = 8
        ListProv.Text = "Proveedores"
        ListProv.UseVisualStyleBackColor = True
        ' 
        ' btnVerInventario
        ' 
        btnVerInventario.Font = New Font("Yu Gothic", 9F)
        btnVerInventario.Location = New Point(599, 17)
        btnVerInventario.Name = "btnVerInventario"
        btnVerInventario.Size = New Size(164, 23)
        btnVerInventario.TabIndex = 6
        btnVerInventario.Text = "Ver inventario"
        btnVerInventario.UseVisualStyleBackColor = True
        ' 
        ' btnClienteSinDoc
        ' 
        btnClienteSinDoc.Location = New Point(386, 18)
        btnClienteSinDoc.Name = "btnClienteSinDoc"
        btnClienteSinDoc.Size = New Size(185, 22)
        btnClienteSinDoc.TabIndex = 3
        btnClienteSinDoc.Text = "Cliente sin documentos"
        btnClienteSinDoc.UseVisualStyleBackColor = True
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(324, 18)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(28, 22)
        btnBuscar.TabIndex = 2
        btnBuscar.Text = "Buscar Cliente"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' txtBusquedaCliente
        ' 
        txtBusquedaCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtBusquedaCliente.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtBusquedaCliente.Font = New Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBusquedaCliente.ForeColor = SystemColors.WindowFrame
        txtBusquedaCliente.Location = New Point(174, 17)
        txtBusquedaCliente.Name = "txtBusquedaCliente"
        txtBusquedaCliente.Size = New Size(151, 23)
        txtBusquedaCliente.TabIndex = 1
        txtBusquedaCliente.Text = "Cliente"
        ' 
        ' NuevaVenta
        ' 
        NuevaVenta.AutoSize = True
        NuevaVenta.BackColor = Color.FromArgb(CByte(96), CByte(126), CByte(184))
        NuevaVenta.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        NuevaVenta.ForeColor = SystemColors.ControlLightLight
        NuevaVenta.Location = New Point(23, 14)
        NuevaVenta.Name = "NuevaVenta"
        NuevaVenta.Padding = New Padding(3)
        NuevaVenta.RightToLeft = RightToLeft.Yes
        NuevaVenta.Size = New Size(140, 31)
        NuevaVenta.TabIndex = 0
        NuevaVenta.Text = "NUEVA VENTA"
        ' 
        ' Productotext
        ' 
        Productotext.AutoSize = True
        Productotext.Font = New Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Productotext.Location = New Point(22, 123)
        Productotext.Name = "Productotext"
        Productotext.Size = New Size(57, 16)
        Productotext.TabIndex = 2
        Productotext.Text = "Producto"
        ' 
        ' BuscarProducto
        ' 
        BuscarProducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        BuscarProducto.AutoCompleteSource = AutoCompleteSource.CustomSource
        BuscarProducto.Font = New Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BuscarProducto.ForeColor = SystemColors.WindowFrame
        BuscarProducto.Location = New Point(22, 153)
        BuscarProducto.Name = "BuscarProducto"
        BuscarProducto.Size = New Size(236, 23)
        BuscarProducto.TabIndex = 9
        BuscarProducto.Text = "Producto"
        ' 
        ' BuscarPro
        ' 
        BuscarPro.Location = New Point(253, 154)
        BuscarPro.Name = "BuscarPro"
        BuscarPro.Size = New Size(28, 22)
        BuscarPro.TabIndex = 9
        BuscarPro.Text = "Buscar Producto"
        BuscarPro.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(22, 448)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(766, 27)
        TextBox2.TabIndex = 11
        TextBox2.Text = "COMENTARIOS"
        ' 
        ' dgvInventario
        ' 
        dgvInventario.BackgroundColor = SystemColors.ControlLightLight
        dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvInventario.Location = New Point(22, 199)
        dgvInventario.Name = "dgvInventario"
        dgvInventario.Size = New Size(936, 225)
        dgvInventario.TabIndex = 12
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(252), CByte(255))
        ClientSize = New Size(987, 573)
        Controls.Add(dgvInventario)
        Controls.Add(TextBox2)
        Controls.Add(BuscarPro)
        Controls.Add(BuscarProducto)
        Controls.Add(Productotext)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(dgvInventario, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Titulo As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtBusquedaCliente As TextBox
    Friend WithEvents btnVerInventario As Button
    Friend WithEvents btnClienteSinDoc As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents ListProv As Button
    Friend WithEvents NuevaVenta As Label
    Friend WithEvents Productotext As Label
    Friend WithEvents BuscarProducto As TextBox
    Friend WithEvents BuscarPro As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents dgvInventario As DataGridView

End Class
