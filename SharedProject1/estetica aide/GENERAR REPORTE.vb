Public Class GENERAR_REPORTE
    Private Sub FechaFin_LostFocus(sender As Object, e As EventArgs) Handles FechaFin.LostFocus
        FechaInicio.MaxDate = FechaFin.Value.Date
    End Sub

    Private Sub FechaInicio_LostFocus(sender As Object, e As EventArgs) Handles FechaInicio.LostFocus
        FechaFin.MinDate = FechaInicio.Value.Date
    End Sub


    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FechaFin.MaxDate = DateTime.Today
        FechaInicio.MaxDate = DateTime.Today
    End Sub
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If ComboSel.Text = "Ventas" Then
            Dim Venta As New ClaseVentas
            Dim fechain As Date = FechaInicio.Text
            Dim fechafi As Date = FechaFin.Text
            Venta.PoblarDataGridConFecha(DGV, Format(fechain, "yyyy-MM-dd") & " 00:00:00", Format(fechafi, "yyyy-MM-dd") & " 23:59:59")
        ElseIf ComboSel.Text = "Citas" Then
            Dim cita As New ClaseCita
            Dim fechain As Date = FechaInicio.Text
            Dim fechafi As Date = FechaFin.Text
            cita.PoblarDataGridConFecha(DGV, Format(fechain, "yyyy-MM-dd") & " 00:00:00", Format(fechafi, "yyyy-MM-dd") & " 23:59:59")
        ElseIf ComboSel.Text = "Productos" Then
            Dim Prod As New Producto
            Dim fechain As Date = FechaInicio.Text
            Dim fechafi As Date = FechaFin.Text
            Prod.PoblarDataGridConFecha(DGV, Format(fechain, "yyyy-MM-dd") & " 00:00:00", Format(fechafi, "yyyy-MM-dd") & " 23:59:59")
        ElseIf ComboSel.Text = "Gastos" Then
            Dim gasto As New ClaseGastos
            Dim fechain As Date = FechaInicio.Text
            Dim fechafi As Date = FechaFin.Text
            gasto.PoblarDataGridConFecha(DGV, Format(fechain, "yyyy-MM-dd") & " 00:00:00", Format(fechafi, "yyyy-MM-dd") & " 23:59:59")
        ElseIf ComboSel.Text = "Clientes" Then
            Dim Cliente As New ClaseCliente
            Dim fechain As Date = FechaInicio.Text
            Dim fechafi As Date = FechaFin.Text
            Cliente.PoblarDataGridConFecha(DGV, Format(fechain, "yyyy-MM-dd") & " 00:00:00", Format(fechafi, "yyyy-MM-dd") & " 23:59:59")
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PrintForm1.Print()
        Timer1.Stop()
    End Sub
    Private Sub Reportes_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        MENU_PRINCIPAL.Show()

    End Sub
End Class