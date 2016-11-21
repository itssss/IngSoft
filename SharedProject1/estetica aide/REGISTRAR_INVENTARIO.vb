Public Class REGISTRAR_INVENTARIO
    Dim cnx As conexion = New conexion()
    Dim conexion As conexion = New conexion()
    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click

        Dim Guardar As String = "insert into Productos (descripcion, cantidad ,precioCompra) values (" + Producto.Text + ",'" + Cantidad.Text + "','" + Precio.Text + "´)"

        If (cnx.Insertar(Guardar)) Then

            MessageBox.Show("Datos agregados correctamente")
            Mostrardatos()
        Else
            MessageBox.Show("Error al agregar")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim dgv As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        Producto.Text = dgv.cells(0).Value.ToString()
        Cantidad.Text = dgv.cells(0).Value.ToString()
        Precio.Text = dgv.Cells(0).Value.ToString()
    End Sub
    Public Sub Mostrardatos()
        conexion.Consulta("select * from Productos", "Productos")
        DataGridView1.DataSource = conexion.ds.Tables("Productos")
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        If (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Elimición", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes) Then
            If (conexion.Eliminar("Productos", "nombre=" + Producto.Text)) Then
                MessageBox.Show("Datos eliminados correctamente")
                Mostrardatos()
            Else
                MessageBox.Show("Error al eliminar")
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        ACTUALIZAR_INVENTARIO.Show()
    End Sub

    Private Sub Producto_TextChanged(sender As Object, e As EventArgs) Handles Producto.TextChanged

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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub REGISTRAR_INVENTARIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class