Public Class ClaseCita
    Inherits ClasePrincipal

    Public Sub New()
        id = 0
        nombre = ""
    End Sub
    Public Sub New(ByVal nuevoid As Integer)
        MyBase.New(nuevoid)
    End Sub
    Public Sub inserta(ByVal fechaCita As String, ByVal id_cliente As String, ByVal id_empleado As String)
        Dim strSql As String
        strSql = "INSERT INTO citas (id_cita,fechacita,id_cliente,id_empleado) VALUES(" & AutoIncrement(cita) & ",'" & fechaCita & "','" & id_cliente & "','" & id_empleado & "');"
        Dim xCnx As New conexion
        xCnx.objetoCommand(strSql)
        MessageBox.Show("Cita registrado!")
        cnx.Close()
    End Sub
    Public Overloads Function getNombre()
        Return MyBase.getNombre(cita)
    End Function

    Public Overloads Function getId()
        Return MyBase.getId(cita)
    End Function


    Public Overloads Sub actualiza(ByVal fechaCita As String, ByVal id_empleado As String)
        Dim strSql As String
        Dim xCnx As New conexion
        Try
            strSql = "UPDATE citas SET fechacita = '" & fechaCita & "',id_empleado = '" & id_empleado & "'WHERE id_cita = " & id & ";"
            xCnx.objetoCommand(strSql)
            MsgBox("Cita actualizada!")
        Catch
            MsgBox("No se pudo actualizar")
        End Try
        cnx.Close()
    End Sub

    Public Sub eliminar()
        Dim strSql As String
        Dim xCnx As New conexion
        Try
            strSql = "DELETE FROM citas WHERE id_cita = " & id & ";"
            xCnx.objetoCommand(strSql)
            MsgBox("Cita eliminada")
        Catch
            MsgBox("No se pudo eliminar")
        End Try
        cnx.Close()
    End Sub

    Public Function BuscarCita(ByVal id_cliente As String) As Date
        Dim strSQL As String = Nothing
        Dim xCnx As New conexion
        Dim xDT As DataTable
        Dim fecha As Date = Nothing

        strSQL = "SELECT * FROM citas WHERE id_cliente = '" & id_cliente & "';"
        xDT = xCnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("fechacita")) Then
                MsgBox("No hay Citas")
            Else
                fecha = CStr(xDT.Rows(0)("fechacita"))
            End If
        End If
        cnx.Close()
        Return fecha
    End Function
    Public Function consultaTodo() As Object
        Dim strSQL As String
        Dim xCnx As New conexion
        strSQL = "SELECT * from citas where (fechacita >= " & Format(System.DateTime.Now, "yyyy-MM-dd") & ") order by id_cita asc "
        consultaTodo = xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Function

    Public Sub PoblarDataGrid(ByVal DGV As DataGridView)
        DGV.DataSource = consultaTodo()
        DGV.Refresh()
        cnx.Close()

    End Sub
End Class
