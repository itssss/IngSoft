Public Class REGISTRAR_GASTOS
    Private Sub REGISTRAR_GASTOS_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MENU_PRINCIPAL.Show()
    End Sub

    Private Sub REGISTRAR_GASTOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btnacep.Click
        Dim g As New ClaseGastos()
        g.insertaGasto(desc.Text, monto.Text, session.item(0))

    End Sub
End Class