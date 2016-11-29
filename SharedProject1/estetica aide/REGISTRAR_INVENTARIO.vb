Public Class REGISTRAR_INVENTARIO

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Dim producto As New Producto
        producto.insertaProducto(NombreP.Text, DescP.Text, PrecioV.Text, PrecioC.Text, session.item(0), Cantidad.Text)
        producto.PoblarDataGrid(DGV)
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        Dim dgv As DataGridViewRow = Me.DGV.Rows(e.RowIndex)
        NombreP.Text = dgv.Cells(1).Value.ToString()
        DescP.Text = dgv.Cells(2).Value.ToString()
        Cantidad.Text = dgv.Cells(6).Value.ToString()
        PrecioV.Text = dgv.Cells(7).Value.ToString()
        PrecioC.Text = dgv.Cells(4).Value.ToString()
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim producto As New Producto(NombreP.Text)
        producto.getIdProductos()
        If (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Elimición", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes) Then
            If (producto.elimina()) Then
                MessageBox.Show("Datos eliminados correctamente")
                producto.PoblarDataGrid(DGV)
            Else
                MessageBox.Show("Error al eliminar")
            End If

        End If
        restablecer()
    End Sub
    Sub restablecer()
        NombreP.Text = ""
        DescP.Text = ""
        Cantidad.Text = ""
        PrecioV.Text = ""
        PrecioC.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        ACTUALIZAR_INVENTARIO.Show()
    End Sub


    Private Sub Cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cantidad.KeyPress
        If Char.IsNumber(e.KeyChar) Then


            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub REGISTRAR_INVENTARIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim producto As New Producto
        producto.PoblarDataGrid(DGV)
    End Sub

    Private Sub REGISTRAR_INVENTARIO_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub
End Class