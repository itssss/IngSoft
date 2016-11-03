Public Class ClaseEmpleado
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
    Public Function consultaTodosNombre() As DataTable
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT CONCAT( nombre, ' ', paterno, ' ', materno ) as Nombre FROM usuarios ORDER BY Nombre ASC;"
        consultaTodosNombre = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function
    Public Sub poblarComboNombre(ByVal ComboCo As ComboBox)
        Dim ds As DataTable
        ds = consultaTodosNombre()
        ComboCo.ValueMember = ds.Columns(0).ToString()
        ComboCo.DataSource = ds
        ComboCo.Refresh()
    End Sub
    Public Function consultaTodosID() As DataTable
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT id_usuario FROM usuarios ORDER BY Nombre ASC;"
        consultaTodosID = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function
    Public Sub poblarComboID(ByVal ComboCo As ComboBox)
        Dim ds As DataTable
        ds = consultaTodosID()
        ComboCo.ValueMember = ds.Columns(0).ToString()
        ComboCo.DataSource = ds
        ComboCo.Refresh()
    End Sub
    'Checar este metodo parametros equivocados
    Public Sub inserta(ByVal nombre As String, ByVal paterno As String, ByVal materno As String, ByVal email As String, ByVal password As String, ByVal rol As String, ByVal idcolonia As String)
        Dim strSql As String
        'Buscar id Pais ¿como? y agregar el primer campo 
        strSql = "INSERT INTO " & empleados & " (id_empleado,nombre,paterno,materno,email,password,rol) VALUES(" & AutoIncrement(empleados) & ",'" & nombre & "','" & paterno & "','" & materno & "','" & email & "','" & password & "'," & rol & "," & idcolonia & ");"
        Dim xCnx As New conexion
        xCnx.objetoCommand(strSql)
        MessageBox.Show("Registro insertado!")
        cnx.Close()
    End Sub
    Public Function DatosUsuario(ByVal usuario As Object) As Object
        Dim strSQL As String
        Dim xCnx As New conexion
        Dim xDT As DataTable

        strSQL = "SELECT * FROM usuarios WHERE id_usuario = " & id & ";"
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            usuario = xDT.Rows(0)
        End If
        cnx.Close()
        Return usuario
    End Function
    Public Overloads Function getNombre()
        Return MyBase.getNombre(empleados)
    End Function

    Public Overloads Function getId()
        Return MyBase.getId(empleados)
    End Function

    Public Overloads Function elimina()
        Return MyBase.elimina(empleados)
    End Function
    'Checar metodo parametros mal
    Public Overloads Sub actualiza(ByVal idusuario As String, ByVal nombre As String, ByVal paterno As String, ByVal materno As String, ByVal email As String, ByVal password As String, ByVal rol As String, ByVal idcolonia As String)
        Dim strSql As String
        Dim xCnx As New conexion
        Try
            strSql = "UPDATE " & empleados & " SET nombre = '" & nombre & "', paterno = '" & paterno & "' , materno = '" & materno & "' , email = '" & email & "' , password = '" & password & "' , rol = " & rol & " , id_colonia = " & idcolonia & " WHERE id_usuario = " & idusuario & ";"
            xCnx.objetoCommand(strSql)
            MsgBox("Registro Modificado")
        Catch
            MsgBox("Registro No Modificado")
        End Try
        cnx.Close()
    End Sub
End Class
