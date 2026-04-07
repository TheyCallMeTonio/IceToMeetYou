Imports MySql.Data.MySqlClient

Public Class RegistroNuevoProducto
    ' --- VARIABLE GLOBAL ---
    Public idProductoEditar As Integer = 0

    ' --- CÓDIGO DEL BOTÓN GUARDAR ---
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            conexion.Open()
            Dim query As String

            If idProductoEditar = 0 Then
                ' --- CORRECCIÓN AQUÍ ---
                ' Agregamos "Id_estado" en la lista de columnas para que coincida con el "1" del final
                query = "INSERT INTO inventario (Producto, Id_categoria, PrecioUnitario, Stock, Id_proveedor) " &
                        "VALUES (@nom, @cat, @pre, @sto, @prov)"
            Else
                ' El UPDATE está bien porque cada campo tiene su valor directo
                query = "UPDATE inventario SET Producto=@nom, Id_categoria=@cat, PrecioUnitario=@pre, " &
                        "Stock=@sto, Id_proveedor=@prov WHERE Id_producto=@id"
            End If

            Dim cmd As New MySqlCommand(query, conexion)
            cmd.Parameters.AddWithValue("@nom", txtNombre.Text)
            cmd.Parameters.AddWithValue("@cat", Val(txtIdcategoria.Text))
            cmd.Parameters.AddWithValue("@pre", txtPrecioUnitario.Text)
            cmd.Parameters.AddWithValue("@sto", Val(txtStock.Text))
            cmd.Parameters.AddWithValue("@prov", Val(txtIdProveedor.Text))

            If idProductoEditar <> 0 Then
                cmd.Parameters.AddWithValue("@id", idProductoEditar)
            End If

            cmd.ExecuteNonQuery()
            MsgBox("¡Operación exitosa!", MsgBoxStyle.Information)

            idProductoEditar = 0
            Me.Close()

        Catch ex As Exception
            MsgBox("Error al procesar: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub
End Class