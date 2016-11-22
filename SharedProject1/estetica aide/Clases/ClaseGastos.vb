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





End Class
