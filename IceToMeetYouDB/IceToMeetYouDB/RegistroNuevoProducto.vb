Imports MySql.Data.MySqlClient

Public Class RegistroNuevoProducto

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' --- 1. VALIDACIÓN BÁSICA ---
        ' Verificamos que al menos el nombre y el precio no estén vacíos
        If txtNombre.Text = "" Or txtPrecioUnitario.Text = "" Then
            MsgBox("Por favor llena los campos principales (Nombre y Precio)", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            ' --- 2. CONEXIÓN Y CONSULTA ---
            conexion.Open()

            ' Nota: El Id_producto no se pone porque es AutoIncrement en MySQL
            ' El Id_estado lo dejamos en 1 (Activo) por defecto
            Dim query As String = "INSERT INTO inventario (Producto, Id_categoria, PrecioUnitario, Stock, Id_proveedor) " &
                                 "VALUES (@nom, @cat, @pre, @sto, @prov)"

            Dim cmd As New MySqlCommand(query, conexion)

            ' --- 3. PASAR LOS DATOS DE LOS TEXTBOX A LA CONSULTA ---
            cmd.Parameters.AddWithValue("@nom", txtNombre.Text)
            cmd.Parameters.AddWithValue("@cat", Val(txtIdcategoria.Text))
            cmd.Parameters.AddWithValue("@pre", txtPrecioUnitario.Text)
            cmd.Parameters.AddWithValue("@sto", Val(txtStock.Text))
            cmd.Parameters.AddWithValue("@prov", Val(txtIdProveedor.Text))

            ' --- 4. EJECUTAR ---
            cmd.ExecuteNonQuery()

            MsgBox("¡Producto agregado con éxito, crack!", MsgBoxStyle.Information)

            ' Cerramos esta ventana automáticamente para volver a la tabla
            Me.Close()

        Catch ex As Exception
            MsgBox("Hubo un fallo al guardar: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

End Class