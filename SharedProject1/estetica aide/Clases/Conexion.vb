Imports MySql.Data.MySqlClient
Public Class conexion
    Public Sub New()
        cnx.ConnectionString = "server=localhost; user=IngSoftUser; password=IngSoft; database=ingsoft"
        If cnx.State <> ConnectionState.Open Then
            Try
                cnx.Open()
                'MsgBox("Sí")
            Catch ex As Exception
                MsgBox("No se pudo conectar a la base de datos")
                Throw New Exception("No se pudo establecer la conexión.", ex)
                'Finally
            End Try
        End If
    End Sub

    'SELECT
    Public Function objetoDataAdapter(ByVal query As String) As DataTable
        Dim DA As MySqlDataAdapter
        Dim DT As DataTable
        Try
            DA = New MySqlDataAdapter(query, cnx)
            DT = New DataTable
            DA.Fill(DT)
            Return DT
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        Finally
        End Try
        DT.Dispose()
    End Function

    'INSERT - UPDATE - DELETE
    Public Sub objetoCommand(ByVal strcmd As String)
        Dim query As New MySqlCommand(strcmd, cnx)
        Try
            query.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        Finally
            query.Dispose()
        End Try
    End Sub

    'asdsd
    Function objetoDataReader(ByVal comando As String) As MySqlDataReader
        Dim cmd As New MySqlCommand(comando, cnx)
        Dim resultadoSQL As MySqlDataReader = cmd.ExecuteReader()
        Try
            Return resultadoSQL
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        Finally
            cmd.Dispose()
        End Try
    End Function
    Function Insertar(ByVal sql)
        Dim comando As MySqlCommand
        cnx.Open()
        comando = New MySqlCommand(sql, cnx)

        Dim i As Integer = comando.ExecuteNonQuery()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
    Private cmb As MySqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As MySqlDataAdapter
    Public comando As MySqlCommand
    Public Sub Consulta(ByVal sql As String, ByVal Productos As String)
        ds.Tables.Clear()
        da = New MySqlDataAdapter(sql, cnx)
        cmb = New MySqlCommandBuilder(da)
        da.Fill(ds, Productos)
    End Sub
    Function Eliminar(ByVal Productos, ByVal condicion)
        cnx.Open()
        Dim elimina As String = "delete from" + Productos + "where" + condicion
        comando = New MySqlCommand(elimina, cnx)
        Dim i As Integer = comando.ExecuteNonQuery()
        cnx.Close()
        If (i > 0) Then
            Return True
        Else
            Return False

        End If

    End Function
    'asds
    Public Function objetoScalar(ByVal strcmd As String) As Object
        Dim sqlcmd As New MySqlCommand(strcmd, cnx)
        Try
            objetoScalar = sqlcmd.ExecuteScalar()
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        Finally
            sqlcmd.Dispose()
        End Try
    End Function
End Class

