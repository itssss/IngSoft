Imports MySql.Data.MySqlClient
Module Globales
    Public cnx As New MySqlConnection
    Public session As Object
    Public EL_nombre As String
    Public empleados = "empleados", clientes = "clientes", cita = "citas"
End Module
