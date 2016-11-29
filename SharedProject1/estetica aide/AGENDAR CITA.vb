Public Class AGENDAR_CITA
    Dim variable As Object
    Private Sub AGENDAR_CITA_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MENU_PRINCIPAL.Show()

    End Sub

    Private Sub AGENDAR_CITA_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim citas As New ClaseCita()
        citas.PoblarDataGrid(DataGridView1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        NUEVA_CITA.Show()
        Dim citas As New ClaseCita()
        citas.PoblarDataGrid(DataGridView1)
    End Sub

    Private Sub ReAgendar_Click(sender As Object, e As EventArgs) Handles ReAgendar.Click
        Me.Hide()
        REAGENDAR_CITA.Show()
        Dim citas As New ClaseCita()
        citas.PoblarDataGrid(DataGridView1)
    End Sub

    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        Dim citas As New ClaseCita(variable)
        citas.eliminar()

        citas.PoblarDataGrid(DataGridView1)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        variable = DataGridView1.Rows(e.RowIndex).Cells(0).Value

    End Sub
End Class