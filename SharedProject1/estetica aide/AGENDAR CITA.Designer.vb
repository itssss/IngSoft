<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AGENDAR_CITA
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.ReAgendar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 39)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(542, 84)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(270, 208)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "NUEVA CITA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'eliminar
        '
        Me.eliminar.Location = New System.Drawing.Point(491, 208)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(75, 23)
        Me.eliminar.TabIndex = 2
        Me.eliminar.Text = "ELIMINAR"
        Me.eliminar.UseVisualStyleBackColor = True
        '
        'ReAgendar
        '
        Me.ReAgendar.Location = New System.Drawing.Point(386, 208)
        Me.ReAgendar.Name = "ReAgendar"
        Me.ReAgendar.Size = New System.Drawing.Size(99, 23)
        Me.ReAgendar.TabIndex = 3
        Me.ReAgendar.Text = "ReAgendar Cita"
        Me.ReAgendar.UseVisualStyleBackColor = True
        '
        'AGENDAR_CITA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 261)
        Me.Controls.Add(Me.ReAgendar)
        Me.Controls.Add(Me.eliminar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "AGENDAR_CITA"
        Me.Text = "AGENDAR_CITA"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents eliminar As Button
    Friend WithEvents ReAgendar As Button
End Class
