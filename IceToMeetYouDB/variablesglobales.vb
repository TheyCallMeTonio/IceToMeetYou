Imports MySql.Data.MySqlClient

Module VariablesGlobales
    Public cadenaConexion As String = "Server=localhost; Database=icetomeetyoudb; Uid=root; Pwd=;"
    Public conexion As New MySqlConnection(cadenaConexion)
End Module