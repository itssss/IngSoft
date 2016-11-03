Public Class ACTUALIZAR_CLIENTE
    Dim busco As Boolean = False
    Dim sel As Boolean = False
    Dim clienteBD As Object
    Dim clientePrin As New ClaseCliente
    Private Sub ACTUALIZAR_CLIENTE_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MENU_PRINCIPAL.Show()
    End Sub

    Private Sub ACTUALIZAR_CLIENTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Combo.SelectedIndex = 1
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo.SelectedIndexChanged
        If Combo.Text = "INGRESAR" Then
            BoxBuscar.Enabled = False
            BoxDatos.Enabled = True
            ELIMINAR.Visible = False
            CheckTerm.Visible = True
            sel = True
        ElseIf Combo.Text = "MODIFICAR" Then
            BoxBuscar.Enabled = True
            BoxDatos.Enabled = False
            ELIMINAR.Visible = True
            CheckTerm.Visible = False
            sel = False
        End If
        restablecer()
    End Sub

    Private Sub GUARDAR_Click(sender As Object, e As EventArgs) Handles GUARDAR.Click
        If sel Then
            If TxtNombre1.Text <> "" And TxtTel.Text <> "" And TxtDir.Text <> "" And TxtCorreo.Text <> "" And TxtDesc.Text <> "" Then
                If CheckTerm.Checked = True Then
                    clientePrin.inserta(TxtNombre1.Text, TxtTel.Text, TxtDir.Text, TxtCorreo.Text, TxtDesc.Text)
                    restablecer()
                    Combo.SelectedIndex = 1
                    Combo.SelectedIndex = 0
                Else
                    MsgBox("Acepte Terminos y Condiciones")
                End If
            Else
                MsgBox("Faltan Datos")
            End If
        Else
            If busco Then
                clientePrin.actualiza(TxtNombre1.Text, TxtTel.Text, TxtDir.Text, TxtCorreo.Text, TxtDesc.Text)
                Combo.SelectedIndex = 0
                Combo.SelectedIndex = 1
            Else
                MsgBox("Busque un Cliente Primero")
            End If
        End If
    End Sub

    Private Sub ELIMINAR_Click(sender As Object, e As EventArgs) Handles ELIMINAR.Click
        If busco = True Then
            clientePrin.eliminar()
            clientePrin = Nothing
            restablecer()
            Combo.SelectedIndex = 0
            Combo.SelectedIndex = 1
        Else
            MsgBox("Busque un Cliente primero")
        End If
    End Sub

    Private Sub BUSCAR_Click(sender As Object, e As EventArgs) Handles BUSCAR.Click
        busco = True
        If Txtclave.Text = "" Then
            Dim clienteB As New ClaseCliente(TxtNombre.Text)
            clienteB.getId()
            If clienteB.consultaUno Then
                llenarcampos(clienteB.DatosCliente(clienteBD))
                clientePrin = clienteB
            Else
                BoxDatos.Enabled = False
                MsgBox("Cliente No encontrado")
            End If
        Else
            Dim clienteB As New ClaseCliente(CInt(Txtclave.Text))
            clienteB.getNombre()
            If clienteB.consultaUno Then
                llenarcampos(clienteB.DatosCliente(clienteBD))
                clientePrin = clienteB
            Else
                BoxDatos.Enabled = False
                MsgBox("Cliente No encontrado")
                busco = False
            End If
        End If
    End Sub
    Sub llenarcampos(ByVal objeto As Object)
        If objeto IsNot Nothing Then
            TxtNombre1.Text = objeto.item(1)
            TxtTel.Text = objeto.item(2)
            TxtDir.Text = objeto.item(3)
            TxtCorreo.Text = objeto.item(4)
            TxtDesc.Text = objeto.item(5)
            BoxDatos.Enabled = True
        Else
            BoxDatos.Enabled = False
            MsgBox("Cliente No encontrado")
        End If
    End Sub
    Sub restablecer()
        TxtNombre1.Text = ""
        TxtTel.Text = ""
        TxtDir.Text = ""
        TxtCorreo.Text = ""
        TxtDesc.Text = ""
        Txtclave.Text = ""
        TxtNombre.Text = ""
        busco = False
        CheckTerm.CheckState = False
    End Sub
End Class