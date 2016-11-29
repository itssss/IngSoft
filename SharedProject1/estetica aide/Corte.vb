Public Class Corte
    Private Sub Detallado_Click(sender As Object, e As EventArgs) Handles Detallado.Click
        detallad.Show()
        Me.Hide()
    End Sub

    Private Sub Resumido_Click(sender As Object, e As EventArgs) Handles Resumido.Click
        resumid.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Corte_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MENU_PRINCIPAL.Show()
    End Sub
End Class