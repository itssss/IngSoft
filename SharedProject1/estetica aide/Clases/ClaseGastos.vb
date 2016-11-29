Public Class ClaseGastos
    Inherits ClasePrincipal


    Public Sub New()
        id = 0
        nombre = ""
    End Sub


    Public Function consultaTodo() As Object
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT * from gastos order by id_gasto asc"
        consultaTodo = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function

    Public Sub PoblarDataGrid(ByVal DGV As DataGridView)
        DGV.DataSource = consultaTodo()
        DGV.Refresh()
        cnx.Close()

    End Sub

    Public Sub New(ByVal nuevoidgasto As Integer)
        MyBase.New(nuevoidgasto)
    End Sub

    Public Sub insertaGasto(ByVal descripcion As String, ByVal monto As Integer, ByVal id_empleado As String)
        Dim strSql As String
        'Buscar id Pais ¿como? y agregar el primer campo 
        strSql = "INSERT INTO " & gastos & " (id_gasto,descripcion,monto,id_empleado) VALUES(" & AutoIncrement(gastos) & ",'" & descripcion & "','" & monto & "'," & id_empleado & ");"
        Dim xCnx As New conexion
        xCnx.objetoCommand(strSql)
        MessageBox.Show("Registro insertado!")
        cnx.Close()
    End Sub

    Public Function DatosGastos(ByVal gastos As Object) As Object
        Dim strSQL As String
        Dim xCnx As New conexion
        Dim xDT As DataTable

        strSQL = "SELECT * FROM gastos WHERE id_gasto = " & id & ";"
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            gastos = xDT.Rows(0)
        End If
        cnx.Close()
        Return gastos
    End Function




    Public Overloads Function getIdGastos()
        Return MyBase.getId(gastos)
    End Function



    Public Function consultaTodoE() As Object
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT monto,descripcion,fecha from gastos where fecha between '" & Format(System.DateTime.Now, "yyyy-MM-dd") & " 00:00:00' AND '" & Format(System.DateTime.Now, "yyyy-MM-dd") & " 23:59:59' order by fecha asc"
        consultaTodoE = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function

    Public Sub PoblarDataGridE(ByVal DGV As DataGridView)
        DGV.DataSource = consultaTodoE()
        DGV.Refresh()
        cnx.Close()

    End Sub
    Public Function sumagastos() As String
        Dim strSQL As String
        Dim xCnx As New conexion
        Dim xDT As DataTable
        strSQL = "SELECT sum(monto) as monto from gastos where fecha between '" & Format(System.DateTime.Now, "yyyy-MM-dd") & " 00:00:00' AND '" & Format(System.DateTime.Now, "yyyy-MM-dd") & " 23:59:59' order by fecha asc"
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 And IsDBNull(xDT.Rows(0)("monto")) Then
            sumagastos = "0"
        Else
            sumagastos = CStr(xDT.Rows(0)("monto"))
        End If
        cnx.Close()
    End Function
    Public Sub PoblarDataGridConFecha(ByVal DGV As DataGridView, ByVal Inicio As String, ByVal fin As String)
        DGV.DataSource = consultaTodosEntreFecha(Inicio, fin)
        DGV.Refresh()
        cnx.Close()
    End Sub
    Public Function consultaTodosEntreFecha(ByVal Inicio As String, ByVal fin As String) As DataTable
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT * FROM gastos WHERE fecha between '" & CStr(Inicio) & "' AND '" & CStr(fin) & "'  ORDER BY fecha ASC;"
        consultaTodosEntreFecha = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function
End Class
