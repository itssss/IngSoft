Public Class ClasePrincipal
    Protected id As Integer
    Protected nombre As String
    Public Sub New()
        id = 0
        nombre = ""
    End Sub

    Public Sub New(ByVal nuevoNombre As String)
        nombre = nuevoNombre
    End Sub

    Public Sub New(ByVal nuevoid As Integer)
        id = nuevoid
    End Sub
    Public Property getSetid() As Integer
        Get
            Return id
        End Get
        Set(ByVal value As Integer)
            id = value
        End Set
    End Property

    Public Property getSetNombre() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property
    Public Overloads Function actualiza(ByVal Tabla As String, ByVal NuevoNombre As String) As Boolean
        Dim strSql As String
        Dim xCnx As New conexion
        If NuevoNombre <> "" Then
            strSql = "UPDATE " & Tabla & " SET nombre = '" & NuevoNombre & "' WHERE nombre = '" & nombre & "';"
            xCnx.objetoCommand(strSql)
            MsgBox("Registro modificado")
            cnx.Close()
            Return True
        Else
            MsgBox("Ingrese el Nuevo Nombre")
            cnx.Close()
            Return False
        End If
    End Function
    Public Overloads Function elimina(ByVal tabla As String) As Boolean
        Dim strSql As String
        Dim xCnx As New conexion

        If nombre <> "" Then
            strSql = "DELETE FROM " & tabla & " WHERE nombre='" & nombre & "';"
            xCnx.objetoCommand(strSql)
            MessageBox.Show("Registro Eliminado")
            cnx.Close()
            Return True
        Else
            MsgBox("Falta el Nombre a Eliminar", MsgBoxStyle.Critical)
            cnx.Close()
            Return False
        End If
    End Function
    Public Function AutoIncrement(ByVal tabla As String) As Integer
        id = getMaxId(tabla) + 1
        Return id
    End Function
    Public Function getMaxId(ByVal tabla As String) As String
        Dim strSql As String = Nothing
        Dim xCnx As New conexion
        Dim xDT As DataTable
        Select Case (tabla)
            Case empleados
                strSql = "SELECT MAX(id_empleado) AS Columna FROM " & empleados & ";"
            Case clientes
                strSql = "SELECT MAX(id_cliente) AS Columna FROM " & clientes & ";"
            Case cita
                strSql = "SELECT MAX(id_cita) AS Columna FROM " & cita & ";"
            Case gastos = "SELECT MAX(id_cita) AS Columna FROM " & gastos & ";"

        End Select
        Try
            xDT = xCnx.objetoDataAdapter(strSql)
            id = CStr(xDT.Rows(0)("Columna"))
            cnx.Close()
            Return id
        Catch
        End Try
        id = 0
        cnx.Close()
        Return id
    End Function
    Public Overloads Function getId(ByVal tabla As String) As String
        Dim strSql As String = Nothing
        Dim xCnx As New conexion
        Dim xDT As DataTable
        Select Case (tabla)
            Case empleados
                strSql = "SELECT id_empleado as Columna FROM " & empleados & " WHERE CONCAT( nombre, ' ', paterno, ' ', materno ) ='" & nombre & "';"
            Case clientes
                strSql = "SELECT id_cliente as Columna FROM " & clientes & " WHERE nombre ='" & nombre & "';"
            Case cita
                Dim fechacita As Date = nombre
                strSql = "SELECT id_cita as Columna FROM " & cita & " WHERE fechacita ='" & Format(fechaCita, "yyyy-MM-dd") & "';"
        End Select
        Try
            xDT = xCnx.objetoDataAdapter(strSql)
            id = CStr(xDT.Rows(0)("Columna"))
            cnx.Close()
            Return id
        Catch
        End Try
        id = 0
        cnx.Close()
        Return id
    End Function
    Public Overloads Function consultaUno(ByVal Tabla As String) As Boolean
        Dim strSQL As String = Nothing
        Dim xCnx As New conexion
        Dim xDT As DataTable

        strSQL = "SELECT * FROM " & Tabla & " WHERE nombre = '" & nombre & "';"
        consultaUno = False
        xDT = xCnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("nombre")) Then
                nombre = ""
            Else
                nombre = CStr(xDT.Rows(0)("nombre"))
                EL_nombre = CStr(xDT.Rows(0)("nombre"))
            End If
            consultaUno = True
        End If
        cnx.Close()
    End Function

    Public Overloads Function getNombre(ByVal tabla As String)
        Dim strSQL As String = Nothing
        Dim xCnx As New conexion
        Dim xDT As DataTable
        Select Case (tabla)
            Case empleados
                strSQL = "SELECT CONCAT( nombre, ' ', paterno, ' ', materno ) as nombre FROM empleados WHERE id_empleado = " & id & ";"
            Case clientes
                strSQL = "SELECT nombre FROM clientes WHERE id_cliente = " & id & ";"
        End Select
        Try
            xDT = xCnx.objetoDataAdapter(strSQL)
            nombre = CStr(xDT.Rows(0)("nombre"))
        Catch
            nombre = ""
        End Try
        cnx.Close()
        Return nombre
    End Function
End Class
