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
            DataGirdRegistrarVenta.Visible = True
            BotonAñadir.Enabled = True
            Label1.Enabled = True
            Label2.Enabled = True
            LupitaRegistrarVenta.Enabled = True
            Limpiar.Enabled = True
            BotonAceptar.Enabled = False
            TextBox1.Text = ""
            Me.DataGirdRegistrarVenta.Rows.Clear()



        ElseIf ComboBoxRegistrarVentas.Text = "Venta de productos" Then
            Descripcion1.Enabled = False
            MontoRegistrarVentas.Enabled = False
            Descripcion2.Enabled = True
            DataGirdRegistrarVenta.Visible = True
            BotonAñadir.Enabled = True

            Label1.Enabled = False
            LupitaRegistrarVenta.Enabled = True
            Label2.Enabled = False
            BotonAceptar.Enabled = False
            Limpiar.Enabled = True
            TextBox1.Text = ""
            Me.DataGirdRegistrarVenta.Rows.Clear()




        ElseIf ComboBoxRegistrarVentas.Text = "Servicio express" Then
            Descripcion1.Enabled = True
            MontoRegistrarVentas.Enabled = True
            Descripcion2.Enabled = False

            DataGirdRegistrarVenta.Visible = False
            BotonAñadir.Enabled = False
            Label1.Enabled = True
            Label2.Enabled = True
            LupitaRegistrarVenta.Enabled = False
            Limpiar.Enabled = False
            BotonAceptar.Enabled = False
            TextBox1.Text = ""
            Me.DataGirdRegistrarVenta.Rows.Clear()





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
            MsgBox(" Producto no encontrado  :( ")

        End If




    End Sub

    Private Sub BotonAñadir_Click(sender As Object, e As EventArgs) Handles BotonAñadir.Click



        Try
            Dim productodeaqui As New Producto(CInt(productoprinci.item(0)))
            If (lupita) Then
                'productodeaqui.PoblarDataGrid(DataGirdRegistrarVenta)
                DataGirdRegistrarVenta.Rows.Add(productoprinci.item(1), productoprinci.item(2), productoprinci.item(7))
            End If
        Catch
            MsgBox("Busque primero un producto")
        End Try
        Try
            SumarTotal()
        Catch ex As Exception
        End Try

    End Sub



    Private Sub Descripcion2_TextChanged(sender As Object, e As EventArgs) Handles Descripcion2.TextChanged

    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click

        If (DataGirdRegistrarVenta.Rows.Count <> -1) Then
            Dim loFila As DataGridViewRow = Me.DataGirdRegistrarVenta.CurrentRow()

            Try
                DataGirdRegistrarVenta.Rows.Remove(loFila)
            Catch
                MsgBox("No lo borre por que no hay nada")
            End Try



        End If
        SumarTotal()
    End Sub

    Function suma()
        Dim Total As Single
        Dim Col As Integer = 2
        For Each row As DataGridViewRow In Me.DataGirdRegistrarVenta.Rows
            Total += Val(row.Cells(Col).Value)
        Next
        TotalRegistrarVenta.Text = Total.ToString
        Return Total.ToString
    End Function

    Private Sub REGISTRAR_VENTA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBoxRegistrarVentas.SelectedIndex = 0
        Descripcion1.Text = ""

        Descripcion2.Text = ""

        Me.DataGirdRegistrarVenta.Rows.Clear()

        MontoRegistrarVentas.Text = ""

        RecibidoRegistrarVenta.Text = ""
        TextBox1.Text = ""















    End Sub






    Private Sub MontoRegistrarVentas_LostFocus(sender As Object, e As EventArgs) Handles MontoRegistrarVentas.LostFocus
        If MontoRegistrarVentas.Text <> "" Then
            Try


                SumarTotal()


            Catch ex As Exception
                MsgBox("ingrese un dato numerico")

            End Try
        Else
            MontoRegistrarVentas.Text = "0"
        End If

    End Sub
    Sub SumarTotal()
        TotalRegistrarVenta.Text = CInt(MontoRegistrarVentas.Text) + suma()
    End Sub

    Private Sub BotonAceptar_Click(sender As Object, e As EventArgs) Handles BotonAceptar.Click
        Dim venta As New ClaseVentas
        venta.inserta(TotalRegistrarVenta.Text)

        PrintForm1.Print()


        MENU_PRINCIPAL.Show()

        ComboBoxRegistrarVentas.SelectedIndex = 0
        Descripcion1.Text = ""

        Descripcion2.Text = ""

        Me.DataGirdRegistrarVenta.Rows.Clear()

        MontoRegistrarVentas.Text = ""

        RecibidoRegistrarVenta.Text = ""
        productoprinci = Nothing

        Me.Hide()




    End Sub




    Sub cambio()


        Try

            If (CInt(RecibidoRegistrarVenta.Text) <> 0) Then

                If (CInt(RecibidoRegistrarVenta.Text) >= CInt(TotalRegistrarVenta.Text)) Then

                    TextBox1.Text = CInt(RecibidoRegistrarVenta.Text) - CInt(TotalRegistrarVenta.Text)

                    BotonAceptar.Enabled = True

                Else
                    MsgBox("ERROR CANTIDAD INVALIDA")
                    BotonAceptar.Enabled = False
                    TextBox1.Text = ""


                End If
            End If




        Catch ex As Exception

        End Try







    End Sub

    Private Sub RecibidoRegistrarVenta_Validated(sender As Object, e As EventArgs) Handles RecibidoRegistrarVenta.Validated

        cambio()



    End Sub

    Private Sub RecibidoRegistrarVenta_TextChanged(sender As Object, e As EventArgs) Handles RecibidoRegistrarVenta.TextChanged

    End Sub
End Class