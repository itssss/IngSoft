<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MENU_PRINCIPAL
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CLIENTES = New System.Windows.Forms.Button()
        Me.VENTAS = New System.Windows.Forms.Button()
        Me.GASTOS = New System.Windows.Forms.Button()
        Me.AGENDA = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CLIENTES
        '
        Me.CLIENTES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CLIENTES.Location = New System.Drawing.Point(32, 34)
        Me.CLIENTES.Margin = New System.Windows.Forms.Padding(4)
        Me.CLIENTES.Name = "CLIENTES"
        Me.CLIENTES.Size = New System.Drawing.Size(180, 74)
        Me.CLIENTES.TabIndex = 0
        Me.CLIENTES.Text = "ACTUALIZAR   CLIENTES"
        Me.CLIENTES.UseVisualStyleBackColor = True
        '
        'VENTAS
        '
        Me.VENTAS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.VENTAS.Location = New System.Drawing.Point(32, 135)
        Me.VENTAS.Margin = New System.Windows.Forms.Padding(4)
        Me.VENTAS.Name = "VENTAS"
        Me.VENTAS.Size = New System.Drawing.Size(180, 74)
        Me.VENTAS.TabIndex = 1
        Me.VENTAS.Text = "REGISTRAR VENTAS"
        Me.VENTAS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.VENTAS.UseVisualStyleBackColor = True
        '
        'GASTOS
        '
        Me.GASTOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GASTOS.Location = New System.Drawing.Point(32, 229)
        Me.GASTOS.Margin = New System.Windows.Forms.Padding(4)
        Me.GASTOS.Name = "GASTOS"
        Me.GASTOS.Size = New System.Drawing.Size(180, 78)
        Me.GASTOS.TabIndex = 2
        Me.GASTOS.Text = "REGISTRAR GASTOS"
        Me.GASTOS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GASTOS.UseVisualStyleBackColor = True
        '
        'AGENDA
        '
        Me.AGENDA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AGENDA.Location = New System.Drawing.Point(271, 34)
        Me.AGENDA.Margin = New System.Windows.Forms.Padding(4)
        Me.AGENDA.Name = "AGENDA"
        Me.AGENDA.Size = New System.Drawing.Size(180, 122)
        Me.AGENDA.TabIndex = 3
        Me.AGENDA.Text = "ACTUALIZAR AGENDA"
        Me.AGENDA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AGENDA.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(271, 203)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 84)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "ACTUALIZAR INVENTARIO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(509, 34)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 74)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "GENERAR REPORTE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(509, 135)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(180, 74)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "GENERAR CORTE DE CAJA"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'MENU_PRINCIPAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 321)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AGENDA)
        Me.Controls.Add(Me.GASTOS)
        Me.Controls.Add(Me.VENTAS)
        Me.Controls.Add(Me.CLIENTES)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MENU_PRINCIPAL"
        Me.Text = "MENU_PRINCIPAL"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CLIENTES As Button
    Friend WithEvents VENTAS As Button
    Friend WithEvents GASTOS As Button
    Friend WithEvents AGENDA As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
