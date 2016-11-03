Public Class INGRESAR_SISTEMA
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ACEPTAR_Click(sender As Object, e As EventArgs) Handles ACEPTAR.Click
        Dim strSQL As String
        Dim xCnx As New conexion
        Dim xDT As DataTable

        strSQL = "SELECT * FROM empleados WHERE usuario = '" & txtuser.Text & "' && contraseña = '" & txtcontra.Text & "';"
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            txtuser.Text = ""
            txtcontra.Text = ""
            session = xDT.Rows(0)
            MessageBox.Show("Bienvenido " & session.Item(1))
            MENU_PRINCIPAL.Show()
            Me.Hide()
        Else
            MessageBox.Show("Usuario o contraseña incorrecto!")
        End If
        cnx.Close()
    End Sub
End Class