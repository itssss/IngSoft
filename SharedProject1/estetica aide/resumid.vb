Public Class resumid

    Dim egr, ing As Integer
    Private Sub Detallado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim venta As New ClaseVentas
        Dim gasto As New ClaseGastos
        ing = venta.sumaventas()
        egr = gasto.sumagastos()
        TxtTotal.Text = ing - egr
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub resumid_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Corte.Show()
    End Sub
End Class