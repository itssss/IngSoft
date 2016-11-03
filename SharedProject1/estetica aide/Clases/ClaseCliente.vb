Public Class ClaseCliente
    Inherits ClasePrincipal

    Public Sub New()
        id = 0
        nombre = ""
    End Sub

    Public Sub New(ByVal nuevoNombre As String)
        MyBase.New(nuevoNombre)
    End Sub

    Public Sub New(ByVal nuevoid As Integer)
        MyBase.New(nuevoid)
    End Sub
    Public Overloads Function consultaUno() As Boolean
        Return MyBase.consultaUno(clientes)
    End Function
    Public Function DatosCliente(ByVal cliente As Object) As Object
        Dim strSQL As String
        Dim xCnx As New conexion
        Dim xDT As DataTable

        strSQL = "SELECT * FROM clientes WHERE id_cliente = " & id & ";"
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            cliente = xDT.Rows(0)
        End If
        cnx.Close()
        Return cliente
    End Function
    Public Sub inserta(ByVal nombre As String, ByVal telefono As String, ByVal direccion As String, ByVal email As String, ByVal descripcion As String)
        Dim strSql As String
        strSql = "INSERT INTO clientes VALUES(" & AutoIncrement(clientes) & ",'" & nombre & "','" & telefono & "','" & direccion & "','" & email & "','" & descripcion & "');"
        Dim xCnx As New conexion
        xCnx.objetoCommand(strSql)
        MessageBox.Show("Cliente registrado!")
        cnx.Close()
    End Sub

    Public Overloads Function getNombre()
        Return MyBase.getNombre(clientes)
    End Function

    Public Overloads Function getId()
        Return MyBase.getId(clientes)
    End Function

    Public Overloads Function elimina()
        Return MyBase.elimina(clientes)
    End Function

    Public Overloads Sub actualiza(ByVal nombre As String, ByVal telefono As String, ByVal direccion As String, ByVal email As String, ByVal descripcion As String)
        Dim strSql As String
        Dim xCnx As New conexion
        Try
            strSql = "UPDATE clientes SET nombre = '" & nombre & "',email = '" & email & "' , telefono = '" & telefono & "' , direccion = '" & direccion & "', descrip = '" & descripcion & "' WHERE id_cliente = " & id & ";"
            xCnx.objetoCommand(strSql)
            MsgBox("Cliente actualizado!")
        Catch
            MsgBox("No se pudo actualizar")
        End Try
        cnx.Close()
    End Sub

    Public Sub eliminar()
        Dim strSql As String
        Dim xCnx As New conexion
        Try
            strSql = "DELETE FROM clientes WHERE id_cliente = " & id & ";"
            xCnx.objetoCommand(strSql)
            MsgBox("Cliente eliminado")
        Catch
            MsgBox("No se pudo eliminar")
        End Try
        cnx.Close()
    End Sub
End Class
