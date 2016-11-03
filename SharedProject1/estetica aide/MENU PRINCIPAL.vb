Public Class MENU_PRINCIPAL
    Private Sub AGENDA_Click(sender As Object, e As EventArgs) Handles AGENDA.Click
        Me.Hide()
        AGENDAR_CITA.Show()
    End Sub

    Private Sub MENU_PRINCIPAL_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MsgBox("Hasta Luego " & session.item(1) & "!")
        session = Nothing
        INGRESAR_SISTEMA.Show()
    End Sub

    Private Sub CLIENTES_Click(sender As Object, e As EventArgs) Handles CLIENTES.Click
        Me.Hide()
        ACTUALIZAR_CLIENTE.Show()
    End Sub

    Private Sub VENTAS_Click(sender As Object, e As EventArgs) Handles VENTAS.Click
        Me.Hide()
        REGISTRAR_VENTA.Show()
    End Sub

    Private Sub GASTOS_Click(sender As Object, e As EventArgs) Handles GASTOS.Click
        Me.Hide()
        REGISTRAR_GASTOS.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        ACTUALIZAR_INVENTARIO.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        GENERAR_REPORTE.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        GENERAR_REPORTE.Show()
    End Sub
End Class