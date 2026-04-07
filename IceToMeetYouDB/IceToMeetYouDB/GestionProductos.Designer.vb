<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionProductos
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
        dgvProductos = New DataGridView()
        btnAgregar = New Button()
        btnEliminar = New Button()
        btnEditar = New Button()
        Panel1 = New Panel()
        Panel2 = New Panel()
        tituloInventario = New Label()
        Panel3 = New Panel()
        CType(dgvProductos, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvProductos
        ' 
        dgvProductos.BackgroundColor = SystemColors.ControlLightLight
        dgvProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProductos.Location = New Point(18, 143)
        dgvProductos.Name = "dgvProductos"
        dgvProductos.Size = New Size(750, 258)
        dgvProductos.TabIndex = 0
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = Color.FromArgb(CByte(96), CByte(126), CByte(184))
        btnAgregar.Font = New Font("Yu Gothic", 9F)
        btnAgregar.ForeColor = SystemColors.ControlLightLight
        btnAgregar.Location = New Point(466, 18)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(97, 32)
        btnAgregar.TabIndex = 1
        btnAgregar.Text = "AGREGAR"
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.FromArgb(CByte(205), CByte(111), CByte(162))
        btnEliminar.Font = New Font("Yu Gothic", 9F)
        btnEliminar.ForeColor = SystemColors.ControlLightLight
        btnEliminar.Location = New Point(672, 18)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(97, 32)
        btnEliminar.TabIndex = 2
        btnEliminar.Text = "ELIMINAR"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnEditar
        ' 
        btnEditar.BackColor = Color.FromArgb(CByte(96), CByte(126), CByte(184))
        btnEditar.Font = New Font("Yu Gothic", 9F)
        btnEditar.ForeColor = SystemColors.ControlLightLight
        btnEditar.Location = New Point(569, 18)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(97, 32)
        btnEditar.TabIndex = 3
        btnEditar.Text = "EDITAR"
        btnEditar.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(96), CByte(126), CByte(184))
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(tituloInventario)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(803, 57)
        Panel1.TabIndex = 4
        ' 
        ' Panel2
        ' 
        Panel2.Location = New Point(2, 56)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(799, 67)
        Panel2.TabIndex = 1
        ' 
        ' tituloInventario
        ' 
        tituloInventario.AutoSize = True
        tituloInventario.Font = New Font("Vladimir Script", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tituloInventario.ForeColor = SystemColors.ControlLightLight
        tituloInventario.Location = New Point(18, 9)
        tituloInventario.Name = "tituloInventario"
        tituloInventario.Size = New Size(144, 42)
        tituloInventario.TabIndex = 0
        tituloInventario.Text = "Inventario"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(241), CByte(246), CByte(255))
        Panel3.Controls.Add(btnAgregar)
        Panel3.Controls.Add(btnEditar)
        Panel3.Controls.Add(btnEliminar)
        Panel3.Location = New Point(0, 57)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(802, 66)
        Panel3.TabIndex = 8
        ' 
        ' GestionProductos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(252), CByte(255))
        ClientSize = New Size(800, 434)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(dgvProductos)
        Name = "GestionProductos"
        Text = "GestionProductos"
        CType(dgvProductos, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tituloInventario As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel

End Class
