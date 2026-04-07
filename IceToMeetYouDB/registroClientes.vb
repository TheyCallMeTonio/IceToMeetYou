Imports MySql.Data.MySqlClient

Public Class registroClientes

    ' 1. DECLARACIÓN: Esta variable vive aquí arriba para que todos los botones la vean
    Dim generoSeleccionado As String = ""

    ' --- EVENTOS DE LOS BOTONES DE GÉNERO ---

    ' Al presionar Masculino
    Private Sub btnMasculino_Click(sender As Object, e As EventArgs) Handles btnMasculino.Click
        generoSeleccionado = "Masculino"

        ' 1. Este se pone azul
        btnMasculino.BackColor = Color.FromArgb(74, 106, 148)
        ' 2. El otro vuelve a blanco (o el color original)
        btnFemenino.BackColor = Color.FromArgb(96, 126, 184)
    End Sub

    ' Al presionar Femenino
    Private Sub btnFemenino_Click(sender As Object, e As EventArgs) Handles btnFemenino.Click
        generoSeleccionado = "Femenino"

        ' 1. Este se pone azul
        btnFemenino.BackColor = Color.FromArgb(74, 106, 148)
        ' 2. El otro vuelve a blanco
        btnMasculino.BackColor = Color.FromArgb(96, 126, 184)

    End Sub

    ' --- BOTÓN GUARDAR ---

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' Validación básica: Que no intenten guardar sin elegir género
        If generoSeleccionado = "" Then
            MsgBox("Por favor, selecciona un género antes de guardar.", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            conexion.Open()
            Dim query As String = "INSERT INTO clientes (Nombre, Edad, Genero, Telefono, Contacto) VALUES (@nom, @edad, @gen, @tel, @cont)"
            Dim comando As New MySqlCommand(query, conexion)

            comando.Parameters.AddWithValue("@nom", txtNombre.Text)
            comando.Parameters.AddWithValue("@edad", txtEdad.Text)
            comando.Parameters.AddWithValue("@gen", generoSeleccionado)
            comando.Parameters.AddWithValue("@tel", txtTelefono.Text)
            comando.Parameters.AddWithValue("@cont", txtContacto.Text)

            comando.ExecuteNonQuery()

            MsgBox("¡Cliente " & txtNombre.Text & " registrado con éxito!", MsgBoxStyle.Information, "Éxito")
            Me.Close()

        Catch ex As Exception
            MsgBox("Error al guardar: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conexion.Close()
        End Try
    End Sub

    ' --- BOTÓN LIMPIAR ---

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNombre.Clear()
        txtEdad.Clear()
        txtTelefono.Clear()
        txtContacto.Clear()
        btnMasculino.BackColor = Color.FromArgb(100, 115, 186)
        btnFemenino.BackColor = Color.FromArgb(100, 115, 186)
        generoSeleccionado = ""
    End Sub

End Class