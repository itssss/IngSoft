Imports MySql.Data.MySqlClient
Public Class ACTUALIZAR_INVENTARIO
    Dim cnx As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Solicitar_Pedido.Show()

    End Sub

    Private Sub ACTUALIZAR_INVENTARIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        REGISTRAR_INVENTARIO.Show()
    End Sub
End Class