Imports MySql.Data.MySqlClient

Public Class GestionProductos

    ' --- 1. FUNCIÓN PARA REFRESCAR LA TABLA (SIN ESTADO) ---
    Private Sub ActualizarTabla()
        Try
            conexion.Open()
            Dim dt As New DataTable()

            ' Traemos los datos (el ID y el Estado se traen para que el sistema funcione, pero no se verán)
            Dim consulta As String = "SELECT Id_producto, Producto, Id_categoria, PrecioUnitario, Stock, Id_proveedor FROM inventario"
            Dim adaptador As New MySqlDataAdapter(consulta, conexion)

            adaptador.Fill(dt)
            dgvProductos.DataSource = dt

            ' --- OCULTAMOS LAS COLUMNAS QUE NO QUEREMOS VER ---
            dgvProductos.Columns("Id_producto").Visible = False

            ' Ajustes de nombres y estiramiento
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
                    MsgBox("Producto eliminado.")
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                Finally
                    conexion.Close()
                    ActualizarTabla()
                End Try
            End If
        Else
            MsgBox("Selecciona una fila primero.")
        End If
    End Sub

End Class