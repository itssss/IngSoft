Public Class ClaseVentas
    Inherits ClasePrincipal


    Public Sub inserta(ByVal total As String)


        Dim empleado As New ClaseEmpleado()

        Dim strSql As String
        strSql = "INSERT INTO ventas (id_venta,total,id_empleado) VALUES(" & AutoIncrement(ventas) & ",'" & total & "','" & session.item(0) & "');"
        Dim xCnx As New conexion
        xCnx.objetoCommand(strSql)
        MessageBox.Show("Venta registrada!")
        cnx.Close()
    End Sub

    Public Function consultaTodo() As Object
        Dim strSQL As String
        Dim xCnx As New conexion

        strSQL = "SELECT total,fecha from ventas where fecha between '" & Format(System.DateTime.Now, "yyyy-MM-dd") & " 00:00:00' AND '" & Format(System.DateTime.Now, "yyyy-MM-dd") & " 23:59:59' order by fecha asc"
        consultaTodo = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function

    Public Sub PoblarDataGrid(ByVal DGV As DataGridView)
        DGV.DataSource = consultaTodo()
        DGV.Refresh()
        cnx.Close()

    End Sub
    Public Function sumaventas() As String
        Dim strSQL As String
        Dim xCnx As New conexion
        Dim xDT As DataTable
        strSQL = "SELECT sum(total) as monto from ventas where fecha between '" & Format(System.DateTime.Now, "yyyy-MM-dd") & " 00:00:00' AND '" & Format(System.DateTime.Now, "yyyy-MM-dd") & " 23:59:59' order by fecha asc"
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 And IsDBNull(xDT.Rows(0)("monto")) Then
            sumaventas = "0"
        Else
            sumaventas = CStr(xDT.Rows(0)("monto"))
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

        strSQL = "SELECT * FROM ventas WHERE fecha between '" & CStr(Inicio) & "' AND '" & CStr(fin) & "'  ORDER BY fecha ASC;"
        consultaTodosEntreFecha = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function
End Class
