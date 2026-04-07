Imports MySql.Data.MySqlClient

Public Class Form1
    ' --- FUNCIÓN PARA LLENAR EL DATAGRIDVIEW ---

    ' --- 1. CONFIGURACIÓN AL CARGAR LA VENTANA (Autocompletado) ---
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Esta es la lista "invisible" que guardará los nombres
        Dim nombresLista As New AutoCompleteStringCollection()

        Try
            conexion.Open()
            ' Traemos solo los nombres de la tabla clientes
            Dim consulta As String = "SELECT Nombre FROM clientes"
            Dim comando As New MySqlCommand(consulta, conexion)
            Dim lector As MySqlDataReader = comando.ExecuteReader()

            ' Recorremos la base de datos y metemos los nombres a la lista
            While lector.Read()
                nombresLista.Add(lector("Nombre").ToString())
            End While
            lector.Close()

            ' Configuramos tu cuadro de texto para que use esa lista
            txtBusquedaCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            txtBusquedaCliente.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtBusquedaCliente.AutoCompleteCustomSource = nombresLista

        Catch ex As Exception
            MsgBox("Error al cargar nombres: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    ' --- 2. BOTÓN BUSCAR (El botón "B" de cliente) ---
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            conexion.Open()
            ' Buscamos al cliente exacto que escribiste o seleccionaste
            Dim consulta As String = "SELECT * FROM clientes WHERE Nombre = @nom"
            Dim comando As New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@nom", txtBusquedaCliente.Text)

            Dim lector As MySqlDataReader = comando.ExecuteReader()

            If lector.Read() Then
                ' Si lo encuentra, nos muestra su nombre y teléfono
                MsgBox("¡Cliente encontrado!" & vbCrLf &
                       "Nombre: " & lector("Nombre").ToString() & vbCrLf &
                       "Teléfono: " & lector("Telefono").ToString(), MsgBoxStyle.Information)
            Else
                MsgBox("Ese cliente no existe en la base de datos.", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception
            MsgBox("Error en la búsqueda: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    ' --- 3. BOTÓN CLIENTE SIN DOCUMENTOS (Abrir Registro) ---
    Private Sub btnClienteSinDoc_Click(sender As Object, e As EventArgs) Handles btnClienteSinDoc.Click
        Dim ventanaRegistro As New registroClientes()
        ventanaRegistro.ShowDialog()

        ' REFRESCAR: Volvemos a ejecutar el Load para que si agregaste un 
        ' cliente nuevo, aparezca en el buscador de inmediato.
        Form1_Load(sender, e)
    End Sub

    ' --- 4. OTROS BOTONES (Para después) ---


    ' --- FUNCIÓN PARA LLENAR LA TABLA DE INVENTARIO ---
    Private Sub ActualizarInventario()
        Try
            conexion.Open()
            ' 1. La pregunta: "Tráeme todo de la tabla productos"
            Dim consulta As String = "SELECT * FROM productos"
            Dim adaptador As New MySqlDataAdapter(consulta, conexion)

            ' 2. El contenedor: Creamos una tabla virtual en la memoria del PC
            Dim tablaVirtual As New DataTable()

            ' 3. El llenado: El adaptador saca los datos de MySQL y los echa en la tabla virtual
            adaptador.Fill(tablaVirtual)

            ' 4. El puente: Le decimos al DataGridView que su fuente de datos es esa tabla
            dgvInventario.DataSource = tablaVirtual

        Catch ex As Exception
            MsgBox("Error al mostrar inventario: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub BuscarPro_Click(sender As Object, e As EventArgs) Handles BuscarPro.Click
        ActualizarInventario()
    End Sub


    Private Sub btnVerInventario_Click(sender As Object, e As EventArgs) Handles btnVerInventario.Click
        Dim ventanaInventario As New GestionProductos()
        ventanaInventario.ShowDialog()
    End Sub
End Class
