Imports MySql.Data.MySqlClient
Public Class Solicitar_Pedido
    Private Sub Solicitar_Pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim productos As New Producto()
        productos.PoblarDataGrid(Dgv)

    End Sub

    Private Sub Imprimir_Click(sender As Object, e As EventArgs) Handles Imprimir.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PrintForm2.Print()
        Timer1.Stop()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Solicitar_Pedido_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ACTUALIZAR_INVENTARIO.Show()
    End Sub

    Private Sub Dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellContentClick

    End Sub
End Class