Public Class Corte_de_caja
    Private Sub Detallado_Click(sender As Object, e As EventArgs) Handles Detallado.Click
        Me.Hide()
        Detallado.Show()
    End Sub

    Private Sub Resumido_Click(sender As Object, e As EventArgs) Handles Resumido.Click
        Me.Hide()
        Resumido.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MENU_PRINCIPAL.Show()
    End Sub
End Class