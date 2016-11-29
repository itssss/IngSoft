Public Class detallad
    Dim egr, ing As Integer
    Private Sub Detallado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrargastos()
        Mostrarventas()
        TxtTotal.Text = ing - egr
    End Sub
    Public Sub Mostrarventas()
        Dim venta As New ClaseVentas
        venta.PoblarDataGrid(DataGridView1)
        Txting.Text = venta.sumaventas()
        ing = CInt(Txting.Text)
    End Sub
    Public Sub Mostrargastos()
        Dim gasto As New ClaseGastos
        gasto.PoblarDataGridE(DataGridView2)
        TxtEgr.Text = gasto.sumagastos()
        egr = CInt(TxtEgr.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PrintForm1.Print()
        Timer1.Stop()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()


    End Sub

    Private Sub detallad_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Corte.Show()
    End Sub
End Class