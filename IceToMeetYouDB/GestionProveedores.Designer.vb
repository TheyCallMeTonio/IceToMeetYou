<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionProveedores
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
        Panel1 = New Panel()
        Proveedores = New Label()
        dgvProveedores = New DataGridView()
        txtBuscarProveedor = New TextBox()
        Panel2 = New Panel()
        BuscarProv = New Label()
        Panel1.SuspendLayout()
        CType(dgvProveedores, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(96), CByte(126), CByte(184))
        Panel1.Controls.Add(Proveedores)
        Panel1.Location = New Point(-1, -2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(765, 64)
        Panel1.TabIndex = 0
        ' 
        ' Proveedores
        ' 
        Proveedores.AutoSize = True
        Proveedores.Font = New Font("Vladimir Script", 26.25F)
        Proveedores.ForeColor = SystemColors.ControlLightLight
        Proveedores.Location = New Point(26, 9)
        Proveedores.Name = "Proveedores"
        Proveedores.Size = New Size(150, 42)
        Proveedores.TabIndex = 0
        Proveedores.Text = "Proveedores"
        ' 
        ' dgvProveedores
        ' 
        dgvProveedores.BackgroundColor = SystemColors.ControlLightLight
        dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProveedores.Location = New Point(25, 163)
        dgvProveedores.Name = "dgvProveedores"
        dgvProveedores.Size = New Size(708, 159)
        dgvProveedores.TabIndex = 1
        ' 
        ' txtBuscarProveedor
        ' 
        txtBuscarProveedor.Location = New Point(26, 33)
        txtBuscarProveedor.Name = "txtBuscarProveedor"
        txtBuscarProveedor.Size = New Size(253, 23)
        txtBuscarProveedor.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(241), CByte(246), CByte(255))
        Panel2.Controls.Add(BuscarProv)
        Panel2.Controls.Add(txtBuscarProveedor)
        Panel2.Location = New Point(-1, 61)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(762, 74)
        Panel2.TabIndex = 3
        ' 
        ' BuscarProv
        ' 
        BuscarProv.AutoSize = True
        BuscarProv.Font = New Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BuscarProv.Location = New Point(26, 14)
        BuscarProv.Name = "BuscarProv"
        BuscarProv.Size = New Size(105, 16)
        BuscarProv.TabIndex = 6
        BuscarProv.Text = "Buscar Proveedor"
        ' 
        ' GestionProveedores
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(252), CByte(255))
        ClientSize = New Size(756, 351)
        Controls.Add(Panel2)
        Controls.Add(dgvProveedores)
        Controls.Add(Panel1)
        Name = "GestionProveedores"
        Text = "GestionProveedores"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvProveedores, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Proveedores As Label
    Friend WithEvents dgvProveedores As DataGridView
    Friend WithEvents txtBuscarProveedor As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BuscarProv As Label
End Class
