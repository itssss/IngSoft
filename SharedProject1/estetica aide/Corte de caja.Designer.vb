<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Corte_de_caja
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Detallado = New System.Windows.Forms.Button()
        Me.Resumido = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Detallado
        '
        Me.Detallado.Location = New System.Drawing.Point(12, 51)
        Me.Detallado.Name = "Detallado"
        Me.Detallado.Size = New System.Drawing.Size(217, 103)
        Me.Detallado.TabIndex = 0
        Me.Detallado.Text = "Corte de caja detallado"
        Me.Detallado.UseVisualStyleBackColor = True
        '
        'Resumido
        '
        Me.Resumido.Location = New System.Drawing.Point(262, 51)
        Me.Resumido.Name = "Resumido"
        Me.Resumido.Size = New System.Drawing.Size(217, 103)
        Me.Resumido.TabIndex = 1
        Me.Resumido.Text = "Corte de caja resumido"
        Me.Resumido.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(208, 180)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Corte_de_caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 215)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Detallado)
        Me.Controls.Add(Me.Resumido)
        Me.Name = "Corte_de_caja"
        Me.Text = "Corte_de_caja"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Detallado As Button
    Friend WithEvents Resumido As Button
    Friend WithEvents Button1 As Button
End Class
