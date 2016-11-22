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
        Me.Detallado.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Detallado.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detallado.Location = New System.Drawing.Point(12, 57)
        Me.Detallado.Name = "Detallado"
        Me.Detallado.Size = New System.Drawing.Size(217, 116)
        Me.Detallado.TabIndex = 0
        Me.Detallado.Text = "Corte de caja detallado"
        Me.Detallado.UseVisualStyleBackColor = False
        '
        'Resumido
        '
        Me.Resumido.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Resumido.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resumido.Location = New System.Drawing.Point(262, 57)
        Me.Resumido.Name = "Resumido"
        Me.Resumido.Size = New System.Drawing.Size(217, 116)
        Me.Resumido.TabIndex = 1
        Me.Resumido.Text = "Corte de caja resumido"
        Me.Resumido.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(208, 202)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 26)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Corte_de_caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.estetica_aide.My.Resources.Resources._15139308_1298582353495753_749350956_n
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(491, 242)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Detallado)
        Me.Controls.Add(Me.Resumido)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Corte_de_caja"
        Me.Text = "Corte_de_caja"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Detallado As Button
    Friend WithEvents Resumido As Button
    Friend WithEvents Button1 As Button
End Class
