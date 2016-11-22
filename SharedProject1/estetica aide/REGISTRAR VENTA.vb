Public Class REGISTRAR_VENTA

    Dim productoprinci As Object
    Dim lupita As Boolean

    Private Sub REGISTRAR_VENTA_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MENU_PRINCIPAL.Show()
    End Sub


    Private Sub ComboBoxRegistrarVentas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxRegistrarVentas.SelectedIndexChanged
        If ComboBoxRegistrarVentas.Text = "Servicio cita" Then
            Descripcion1.Enabled = True
            MontoRegistrarVentas.Enabled = True
            Descripcion2.Enabled = True
            CantidadRegistrarVenta.Enabled = True


        ElseIf ComboBoxRegistrarVentas.Text = "Venta de productos" Then
            Descripcion1.Enabled = True
            MontoRegistrarVentas.Enabled = True
            Descripcion2.Enabled = True
            CantidadRegistrarVenta.Enabled = True


        ElseIf ComboBoxRegistrarVentas.Text = "Servicio express" Then
            Descripcion1.Enabled = True
            MontoRegistrarVentas.Enabled = True
            Descripcion2.Enabled = False
            CantidadRegistrarVenta.Enabled = False
            DataGirdRegistrarVenta.Visible = False
            BotonAñadir.Enabled = False

        End If

    End Sub

    Private Sub LupitaRegistrarVenta_Click(sender As Object, e As EventArgs) Handles LupitaRegistrarVenta.Click


        Dim productoClase As New Producto(Descripcion2.Text)
        productoClase.getId(productos)

        If productoClase.consultaUno(productos) Then

            productoprinci = productoClase.DatosProductos(productoprinci)
            MsgBox(" Producto encontrado  :) ")
            lupita = True

        Else
            lupita = False


        End If




    End Sub

    Private Sub BotonAñadir_Click(sender As Object, e As EventArgs) Handles BotonAñadir.Click


        Dim productodeaqui As New Producto(CStr(productoprinci.item(1)))

        If (lupita) Then

            productodeaqui.PoblarDataGrid(DataGirdRegistrarVenta)

        End If

    End Sub



End Class