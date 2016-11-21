<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REGISTRAR_INVENTARIO
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Producto = New System.Windows.Forms.TextBox()
        Me.Cantidad = New System.Windows.Forms.TextBox()
        Me.Precio = New System.Windows.Forms.TextBox()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DESCRIPCION_DEL_PRODUCTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO_DE_COMPRA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descripcion del producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(128, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(144, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio"
        '
        'Producto
        '
        Me.Producto.Location = New System.Drawing.Point(198, 54)
        Me.Producto.Name = "Producto"
        Me.Producto.Size = New System.Drawing.Size(100, 22)
        Me.Producto.TabIndex = 3
        '
        'Cantidad
        '
        Me.Cantidad.Location = New System.Drawing.Point(198, 97)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(100, 22)
        Me.Cantidad.TabIndex = 4
        '
        'Precio
        '
        Me.Precio.Location = New System.Drawing.Point(198, 143)
        Me.Precio.Name = "Precio"
        Me.Precio.Size = New System.Drawing.Size(100, 22)
        Me.Precio.TabIndex = 5
        '
        'Guardar
        '
        Me.Guardar.Location = New System.Drawing.Point(51, 181)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(75, 23)
        Me.Guardar.TabIndex = 6
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DESCRIPCION_DEL_PRODUCTO, Me.DataGridViewTextBoxColumn1, Me.PRECIO_DE_COMPRA})
        Me.DataGridView1.Location = New System.Drawing.Point(81, 241)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(467, 335)
        Me.DataGridView1.TabIndex = 7
        '
        'DESCRIPCION_DEL_PRODUCTO
        '
        Me.DESCRIPCION_DEL_PRODUCTO.HeaderText = "DESCRIPCION DEL PRODUCTO"
        Me.DESCRIPCION_DEL_PRODUCTO.Name = "DESCRIPCION_DEL_PRODUCTO"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "CANTIDAD"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'PRECIO_DE_COMPRA
        '
        Me.PRECIO_DE_COMPRA.HeaderText = "PRECIO DE COMPRA"
        Me.PRECIO_DE_COMPRA.Name = "PRECIO_DE_COMPRA"
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(183, 181)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Eliminar.TabIndex = 8
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(488, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 74)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'REGISTRAR_INVENTARIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 612)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.Precio)
        Me.Controls.Add(Me.Cantidad)
        Me.Controls.Add(Me.Producto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "REGISTRAR_INVENTARIO"
        Me.Text = "REGISTRAR_INVENTARIO"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Producto As TextBox
    Friend WithEvents Cantidad As TextBox
    Friend WithEvents Precio As TextBox
    Friend WithEvents Guardar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DESCRIPCION_DEL_PRODUCTO As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PRECIO_DE_COMPRA As DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As Button
    Friend WithEvents Button1 As Button
End Class
