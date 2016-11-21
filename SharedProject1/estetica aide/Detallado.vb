Imports MySql.Data.MySqlClient
Public Class Detallado
    Dim cnx As New MySqlConnection
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim conexion As conexion = New conexion()
    Private Sub Detallado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            cnx.ConnectionString = "server=localhost; user=IngSoftUser; password=IngSoft; database=ingsoft"
            cnx.Open()

            Mostrargastos()
            Mostrarventas()
            Using cnx As New MySqlConnection("connection string")
                cnx.Open()
                Dim fechahoy As String = DateTime.Now.ToString("dd/MM/yyyy")
                Dim fechaventas As String = "fechaventas As fecha FROM ventas"
                Dim fechagastos As String = "fechagastos As fecha From gastos"
                Dim query As String = "SELECT SUM(Ventas) As total decimal FROM ventas where fecha equal fechahoy"
                Dim cmd As New MySqlCommand(query, cnx)

                TextBox1.Text = CStr(cmd.ExecuteScalar())

            End Using
            Using cnx As New MySqlConnection("connection string")
                cnx.Open()

                Dim query As String = "SELECT SUM(Gastos) As monto decimal FROM gastos where fecha equal fechahoy "
                Dim cmd As New MySqlCommand(query, cnx)

                TextBox2.Text = CStr(cmd.ExecuteScalar())

            End Using

            Dim gastos As String = "SELECT SUM(Gastos) As monto decimal FROM gastos where fecha equal fechahoy"
            Dim ventas As String = "SELECT SUM(Ventas) As total decimal FROM ventas where fecha equal fechahoy"
            TextBox3.Text = ventas - gastos
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub Mostrarventas()

        conexion.Consulta("select * from Ventas where fecha Equal fechahoy", "Ventas")
        DataGridView1.DataSource = conexion.ds.Tables("Ventas")

    End Sub
    Public Sub Mostrargastos()
        conexion.Consulta("select * from Gastos where fecha Equal fechahoy", "Gastos")
        DataGridView2.DataSource = conexion.ds.Tables("Gastos")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PrintForm1.Print()
        Timer1.Stop()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Corte_de_caja.Show()

    End Sub


End Class