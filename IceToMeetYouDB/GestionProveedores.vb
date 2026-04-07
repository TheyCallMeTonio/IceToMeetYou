Imports MySql.Data.MySqlClient

Public Class GestionProveedores


    Private Sub GestionProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarTabla()
    End Sub

    ' 2. TU FUNCIÓN (Está excelente, solo la dejo aquí completa)
    Private Sub ActualizarTabla()
        Try
            If conexion.State = ConnectionState.Closed Then conexion.Open()
            Dim dt As New DataTable()
            Dim consulta As String = "SELECT Id_proveedor, Nombre, Contacto, Telefono FROM proveedores"
            Dim adaptador As New MySqlDataAdapter(consulta, conexion)

            adaptador.Fill(dt)
            dgvProveedores.DataSource = dt

            ' CONFIGURACIÓN DE SOLO LECTURA (Perfecto para el cajero)
            dgvProveedores.ReadOnly = True
            dgvProveedores.AllowUserToAddRows = False
            dgvProveedores.AllowUserToDeleteRows = False

            ' Ocultamos el ID y ajustamos
            dgvProveedores.Columns("Id_proveedor").Visible = False
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MsgBox("Error al cargar la lista de contactos: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub txtBuscarProveedor_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarProveedor.TextChanged
        Try
            ' Si borran todo el texto, mostramos la lista completa de nuevo
            If txtBuscarProveedor.Text = "" Then
                ActualizarTabla()
                Exit Sub
            End If

            ' Abrimos conexión si está cerrada
            If conexion.State = ConnectionState.Closed Then conexion.Open()

            Dim dt As New DataTable()
            ' Buscamos por Nombre O por Contacto
            Dim consulta As String = "SELECT Id_proveedor, Nombre, Contacto, Telefono FROM proveedores " &
                                 "WHERE Nombre LIKE @bus OR Contacto LIKE @bus"

            Dim cmd As New MySqlCommand(consulta, conexion)
            ' El % permite que encuentre coincidencias aunque solo escribas una parte del nombre
            cmd.Parameters.AddWithValue("@bus", "%" & txtBuscarProveedor.Text & "%")

            Dim adaptador As New MySqlDataAdapter(cmd)
            adaptador.Fill(dt)
            dgvProveedores.DataSource = dt

            ' Volvemos a ocultar el ID después de filtrar
            dgvProveedores.Columns("Id_proveedor").Visible = False

        Catch ex As Exception
            ' No ponemos mensaje de error aquí para que no interrumpa el tipeo del usuario
        Finally
            conexion.Close()
        End Try
    End Sub
End Class