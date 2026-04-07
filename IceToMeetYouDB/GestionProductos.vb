Imports MySql.Data.MySqlClient

Public Class GestionProductos

    ' --- 1. FUNCIÓN PARA REFRESCAR LA TABLA ---
    Private Sub ActualizarTabla()
        Try
            If conexion.State = ConnectionState.Closed Then conexion.Open()

            Dim dt As New DataTable()
            Dim consulta As String = "SELECT Id_producto, Producto, Id_categoria, PrecioUnitario, Stock, Id_proveedor FROM inventario"
            Dim adaptador As New MySqlDataAdapter(consulta, conexion)

            adaptador.Fill(dt)
            dgvProductos.DataSource = dt

            ' Ocultamos el ID
            dgvProductos.Columns("Id_producto").Visible = False

            ' Ajustes visuales
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvProductos.Columns("PrecioUnitario").HeaderText = "Precio ($)"
            dgvProductos.Columns("Id_categoria").HeaderText = "Categoría"
            dgvProductos.Columns("Id_proveedor").HeaderText = "Proveedor"

        Catch ex As Exception
            MsgBox("Error al cargar la tabla: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    ' --- 2. CARGA AL INICIAR ---
    Private Sub GestionProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarTabla()
    End Sub

    ' --- 3. BOTÓN AGREGAR ---
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim ventanaRegistro As New RegistroNuevoProducto()
        ventanaRegistro.idProductoEditar = 0 ' Aseguramos que sea modo nuevo
        ventanaRegistro.ShowDialog()
        ActualizarTabla()
    End Sub

    ' --- 4. BOTÓN ELIMINAR ---
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvProductos.SelectedRows.Count > 0 Then
            Dim idBorrar = dgvProductos.CurrentRow.Cells("Id_producto").Value

            If MsgBox("¿Seguro que quieres eliminar este producto?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                Try
                    conexion.Open()
                    Dim cmd As New MySqlCommand("DELETE FROM inventario WHERE Id_producto = @id", conexion)
                    cmd.Parameters.AddWithValue("@id", idBorrar)
                    cmd.ExecuteNonQuery()
                    MsgBox("Producto eliminado correctamente.")
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                Finally
                    conexion.Close()
                    ActualizarTabla()
                End Try
            End If
        Else
            MsgBox("Selecciona una fila haciendo clic en la flechita de la izquierda.")
        End If
    End Sub

    ' --- 5. BOTÓN EDITAR ---
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvProductos.SelectedRows.Count > 0 Then
            Dim f As New RegistroNuevoProducto()

            ' Pasamos los datos a la ventana de registro
            f.idProductoEditar = dgvProductos.CurrentRow.Cells("Id_producto").Value
            f.txtNombre.Text = dgvProductos.CurrentRow.Cells("Producto").Value.ToString()
            f.txtIdcategoria.Text = dgvProductos.CurrentRow.Cells("Id_categoria").Value.ToString()
            f.txtPrecioUnitario.Text = dgvProductos.CurrentRow.Cells("PrecioUnitario").Value.ToString()
            f.txtStock.Text = dgvProductos.CurrentRow.Cells("Stock").Value.ToString()
            f.txtIdProveedor.Text = dgvProductos.CurrentRow.Cells("Id_proveedor").Value.ToString()

            f.btnGuardar.Text = "ACTUALIZAR PRODUCTO"
            f.ShowDialog()
            ActualizarTabla()
        Else
            MsgBox("Selecciona un producto primero.")
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Try
            ' Si el buscador está vacío, cargamos todo de nuevo
            If txtBuscar.Text = "" Then
                ActualizarTabla()
                Return
            End If

            ' Si hay texto, buscamos por nombre de producto
            ' Usamos LIKE y los símbolos % para que busque cualquier coincidencia
            conexion.Open()
            Dim dt As New DataTable()
            Dim consulta As String = "SELECT Id_producto, Producto, Id_categoria, PrecioUnitario, Stock, Id_proveedor FROM inventario " &
                                 "WHERE Producto LIKE @busqueda"

            Dim cmd As New MySqlCommand(consulta, conexion)
            cmd.Parameters.AddWithValue("@busqueda", "%" & txtBuscar.Text & "%")

            Dim adaptador As New MySqlDataAdapter(cmd)
            adaptador.Fill(dt)
            dgvProductos.DataSource = dt

            ' Volvemos a ocultar el ID para que no se vea feo
            dgvProductos.Columns("Id_producto").Visible = False
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            ' No ponemos MsgBox aquí para que no moleste mientras escribes, 
            ' solo si es un error crítico.
        Finally
            conexion.Close()
        End Try
    End Sub
End Class