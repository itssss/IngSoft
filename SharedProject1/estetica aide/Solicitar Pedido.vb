Imports MySql.Data.MySqlClient
Public Class Solicitar_Pedido
    Dim cnx As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim conexion As conexion = New conexion()
    Private Sub Solicitar_Pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            cnx.ConnectionString = "server=localhost; user=IngSoftUser; password=IngSoft; database=ingsoft"
            cnx.Open()

            Mostrardatos()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub Mostrardatos()
        conexion.Consulta("select * from Productos", "Productos")
        DataGridView1.DataSource = conexion.ds.Tables("Productos")
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick



    End Sub

    Private Sub Imprimir_Click(sender As Object, e As EventArgs) Handles Imprimir.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PrintForm2.Print()
        Timer1.Stop()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        ACTUALIZAR_INVENTARIO.Show()

    End Sub
End Class