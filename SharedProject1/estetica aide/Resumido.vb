Imports MySql.Data.MySqlClient
Public Class Resumido


    Dim cnx As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim conexion As conexion = New conexion()
    Private Sub Detallado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            cnx.ConnectionString = "server=localhost; user=IngSoftUser; password=IngSoft; database=ingsoft"
            cnx.Open()

            Dim fechahoy As String = DateTime.Now.ToString("dd/MM/yyyy")
            Dim fechaventas As String = "fechaventas As fecha FROM ventas"
            Dim fechagastos As String = "fechagastos As fecha From gastos"
            Dim gastos As String = "SELECT SUM(Gastos) As monto decimal FROM gastos where fecha equals fechagastos"
            Dim ventas As String = "SELECT SUM(Ventas) As total decimal FROM ventas where fecha equals fechaventas"
            TextBox1.Text = ventas - gastos
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Corte_de_caja.Show()

    End Sub
End Class