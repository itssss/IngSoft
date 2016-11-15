Public Class REAGENDAR_CITA
    Dim clienteBD As Object
    Dim clientePrin As New ClaseCliente
    Private Sub REAGENDAR_CITA_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MENU_PRINCIPAL.Show()
    End Sub

    Private Sub REAGENDAR_CITA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BUSCAR_Click(sender As Object, e As EventArgs) Handles BUSCAR.Click
        If TxtClave.Text = "" Then
            Dim clienteB As New ClaseCliente(TxtNombre.Text)
            clienteB.getId()
            If clienteB.consultaUno Then
                clienteBD = clienteB.DatosCliente(clienteBD)
                TxtClave.Text = clienteBD.item(0)
                clientePrin = clienteBD
                Dim cita As New ClaseCita
                Fecha.Text = cita.BuscarCita(clienteBD.item(0))
                btnAceptar.Enabled = True
                FechaN.Enabled = True
            Else
                btnAceptar.Enabled = False
                Fecha.Enabled = False
                MsgBox("Cliente No encontrado")
                TxtClave.Text = ""
                TxtNombre.Text = ""
            End If
        Else
            Dim clienteB As New ClaseCliente(CInt(TxtClave.Text))
            clienteB.getNombre()
            If clienteB.consultaUno Then
                clienteBD = clienteB.DatosCliente(clienteBD)
                TxtNombre.Text = clienteBD.item(1)
                clientePrin = clienteB
                Dim cita As New ClaseCita
                Fecha.Text = cita.BuscarCita(clienteBD.item(0))
                btnAceptar.Enabled = True
                FechaN.Enabled = True
            Else
                btnAceptar.Enabled = False
                Fecha.Enabled = False
                MsgBox("Cliente No encontrado")
                TxtClave.Text = ""
                TxtNombre.Text = ""
            End If
        End If
    End Sub
End Class