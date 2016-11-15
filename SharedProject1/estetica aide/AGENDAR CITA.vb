Public Class AGENDAR_CITA
    Private Sub AGENDAR_CITA_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MENU_PRINCIPAL.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        NUEVA_CITA.Show()
    End Sub
End Class