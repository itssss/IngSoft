Public Class Producto
    Inherits ClasePrincipal


    Public Sub New()
        id = 0
        nombre = ""
    End Sub


    Public Sub New(ByVal nuevoNombreProducto As String)

        MyBase.New(nuevoNombreProducto)

    End Sub

    Public Function consultaTodo() As Object
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT * from productos order by id_producto asc"
        consultaTodo = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function

    Public Sub PoblarDataGrid(ByVal DGV As DataGridView)
        DGV.DataSource = consultaTodo()
        DGV.Refresh()
        cnx.Close()

    End Sub

    Public Sub New(ByVal nuevoidproducto As Integer)
        MyBase.New(nuevoidproducto)
    End Sub


    Public Function consultaTodosProducto() As DataTable
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT CONCAT( nombre, ' ', descripcion, ' ', precioventa ) as Poducto FROM productos ORDER BY nombre ASC;"
        consultaTodosProducto = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function

    Public Sub poblarComboNombre(ByVal ComboCo As ComboBox)
        Dim ds As DataTable
        ds = consultaTodosProducto()
        ComboCo.ValueMember = ds.Columns(0).ToString()
        ComboCo.DataSource = ds
        ComboCo.Refresh()
    End Sub


    Public Function consultaTodosID() As DataTable
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT id_producto FROM productos;"
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



    Public Sub insertaProducto(ByVal nombre As String, ByVal descripcion As String, ByVal precioVenta As String, ByVal precioCompra As String, ByVal id_empleado As String, ByVal cantidad As String)
        Dim strSql As String
        'Buscar id Pais ¿como? y agregar el primer campo 
        strSql = "INSERT INTO " & productos & " (id_producto,nombre,descripcion,precioVenta,precioCompra,id_empleado,cantidad) VALUES(" & AutoIncrement(productos) & ",'" & nombre & "','" & descripcion & "','" & precioVenta & "','" & precioCompra & "','" & id_empleado & "','" & cantidad & "');"
        Dim xCnx As New conexion
        xCnx.objetoCommand(strSql)
        MessageBox.Show("Registro insertado!")
        cnx.Close()
    End Sub

    Public Function DatosProductos(ByVal productos As Object) As Object
        Dim strSQL As String
        Dim xCnx As New conexion
        Dim xDT As DataTable

        strSQL = "SELECT * FROM productos WHERE id_producto = " & id & ";"
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            productos = xDT.Rows(0)
        End If
        cnx.Close()
        Return productos
    End Function


    Public Overloads Function getNombreProducto()
        Return MyBase.getNombre(productos)
    End Function

    Public Overloads Function getIdProductos()
        Return MyBase.getId(productos)
    End Function



    Public Overloads Function elimina()
        Dim strSql As String
        Dim xCnx As New conexion
        Try
            strSql = "DELETE FROM productos WHERE id_producto ='" & id & "';"
            xCnx.objetoCommand(strSql)
            cnx.Close()
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Overloads Sub actualiza(ByVal id_producto As String, ByVal nombre As String, ByVal descripcion As String, ByVal id_proovedor As String, ByVal precioVenta As String, ByVal precioCompra As String)
        Dim strSql As String
        Dim xCnx As New conexion
        Try
            strSql = "UPDATE " & productos & " SET nombre = '" & nombre & "', descripcion = '" & descripcion & "' , id_proovedor = '" & id_proovedor & "' , precioVenta = '" & precioVenta & "' , precioCompra = '" & precioCompra & ";"
            xCnx.objetoCommand(strSql)
            MsgBox("Registro Modificado")
        Catch
            MsgBox("Registro No Modificado")
        End Try
        cnx.Close()
    End Sub
    Public Sub PoblarDataGridConFecha(ByVal DGV As DataGridView, ByVal Inicio As String, ByVal fin As String)
        DGV.DataSource = consultaTodosEntreFecha(Inicio, fin)
        DGV.Refresh()
        cnx.Close()
    End Sub
    Public Function consultaTodosEntreFecha(ByVal Inicio As String, ByVal fin As String) As DataTable
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT * FROM productos WHERE fecha between '" & CStr(Inicio) & "' AND '" & CStr(fin) & "'  ORDER BY fecha ASC;"
        consultaTodosEntreFecha = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function
End Class

