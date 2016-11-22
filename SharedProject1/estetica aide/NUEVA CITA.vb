Public Class NUEVA_CITA
    Dim clienteBD As Object
    Dim clientePrin As New ClaseCliente
    Private Sub NUEVA_CITA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fecha.MinDate = DateTime.Today
    End Sub

    Private Sub NUEVA_CITA_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        AGENDAR_CITA.Show()
        Dim citas As New ClaseCita()
        citas.PoblarDataGrid(AGENDAR_CITA.DataGridView1)
    End Sub

    Private Sub BUSCAR_Click(sender As Object, e As EventArgs) Handles BUSCAR.Click
        If txtclave.Text = "" Then
            Dim clienteB As New ClaseCliente(TxtNombre.Text)
            clienteB.getId()
            If clienteB.consultaUno Then
                clienteBD = clienteB.DatosCliente(clienteBD)
                txtclave.Text = clienteBD.item(0)
                clientePrin = clienteBD
                btnAceptar.Enabled = True
                Fecha.Enabled = True
            Else
                btnAceptar.Enabled = False
                Fecha.Enabled = False
                MsgBox("Cliente No encontrado")
                txtclave.Text = ""
                TxtNombre.Text = ""
            End If
        Else
            Dim clienteB As New ClaseCliente(CInt(txtclave.Text))
            clienteB.getNombre()
            If clienteB.consultaUno Then
                clienteBD = clienteB.DatosCliente(clienteBD)
                TxtNombre.Text = clienteBD.item(1)
                clientePrin = clienteB
                btnAceptar.Enabled = True
                Fecha.Enabled = True
            Else
                btnAceptar.Enabled = False
                Fecha.Enabled = False
                MsgBox("Cliente No encontrado")
                txtclave.Text = ""
                TxtNombre.Text = ""
            End If
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim cita As New ClaseCita()
        Dim fechacita As Date = Fecha.Text
        cita.inserta(Format(fechacita, "yyyy-MM-dd") & " " & ComboSel.Text & ":00", clientePrin.getId, session.item(0))
        MsgBox("Cita Reagendada")
    End Sub

    Sub disponible()
        'Checar si la hora esta disponible, Como??!
    End Sub

    Private Sub ComboSel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboSel.SelectedIndexChanged

    End Sub
End Class