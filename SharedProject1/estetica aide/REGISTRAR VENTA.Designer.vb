<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class REGISTRAR_VENTA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(REGISTRAR_VENTA))
        Me.ComboBoxRegistrarVentas = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Descripcion1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MontoRegistrarVentas = New System.Windows.Forms.TextBox()
        Me.TotalRegistrarVenta = New System.Windows.Forms.TextBox()
        Me.Descripcion2 = New System.Windows.Forms.TextBox()
        Me.CantidadRegistrarVenta = New System.Windows.Forms.TextBox()
        Me.LupitaRegistrarVenta = New System.Windows.Forms.Button()
        Me.BotonAñadir = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGirdRegistrarVenta = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RecibidoRegistrarVenta = New System.Windows.Forms.TextBox()
        Me.BotonAceptar = New System.Windows.Forms.Button()
        CType(Me.DataGirdRegistrarVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxRegistrarVentas
        '
        Me.ComboBoxRegistrarVentas.FormattingEnabled = True
        Me.ComboBoxRegistrarVentas.Items.AddRange(New Object() {"Servicio cita", "Venta de productos", "Servicio express"})
        Me.ComboBoxRegistrarVentas.Location = New System.Drawing.Point(105, 34)
        Me.ComboBoxRegistrarVentas.Name = "ComboBoxRegistrarVentas"
        Me.ComboBoxRegistrarVentas.Size = New System.Drawing.Size(324, 21)
        Me.ComboBoxRegistrarVentas.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "DESCRIPCION "
        '
        'Descripcion1
        '
        Me.Descripcion1.Location = New System.Drawing.Point(105, 84)
        Me.Descripcion1.Name = "Descripcion1"
        Me.Descripcion1.Size = New System.Drawing.Size(324, 20)
        Me.Descripcion1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(451, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "MONTO    $"
        '
        'MontoRegistrarVentas
        '
        Me.MontoRegistrarVentas.Location = New System.Drawing.Point(522, 84)
        Me.MontoRegistrarVentas.Name = "MontoRegistrarVentas"
        Me.MontoRegistrarVentas.Size = New System.Drawing.Size(112, 20)
        Me.MontoRegistrarVentas.TabIndex = 6
        '
        'TotalRegistrarVenta
        '
        Me.TotalRegistrarVenta.Location = New System.Drawing.Point(171, 297)
        Me.TotalRegistrarVenta.Name = "TotalRegistrarVenta"
        Me.TotalRegistrarVenta.Size = New System.Drawing.Size(100, 20)
        Me.TotalRegistrarVenta.TabIndex = 7
        '
        'Descripcion2
        '
        Me.Descripcion2.Location = New System.Drawing.Point(105, 157)
        Me.Descripcion2.Name = "Descripcion2"
        Me.Descripcion2.Size = New System.Drawing.Size(233, 20)
        Me.Descripcion2.TabIndex = 8
        '
        'CantidadRegistrarVenta
        '
        Me.CantidadRegistrarVenta.Location = New System.Drawing.Point(454, 158)
        Me.CantidadRegistrarVenta.Name = "CantidadRegistrarVenta"
        Me.CantidadRegistrarVenta.Size = New System.Drawing.Size(62, 20)
        Me.CantidadRegistrarVenta.TabIndex = 9
        '
        'LupitaRegistrarVenta
        '
        Me.LupitaRegistrarVenta.BackgroundImage = CType(resources.GetObject("LupitaRegistrarVenta.BackgroundImage"), System.Drawing.Image)
        Me.LupitaRegistrarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LupitaRegistrarVenta.Location = New System.Drawing.Point(344, 154)
        Me.LupitaRegistrarVenta.Name = "LupitaRegistrarVenta"
        Me.LupitaRegistrarVenta.Size = New System.Drawing.Size(44, 23)
        Me.LupitaRegistrarVenta.TabIndex = 10
        Me.LupitaRegistrarVenta.UseVisualStyleBackColor = True
        '
        'BotonAñadir
        '
        Me.BotonAñadir.Location = New System.Drawing.Point(546, 154)
        Me.BotonAñadir.Name = "BotonAñadir"
        Me.BotonAñadir.Size = New System.Drawing.Size(75, 23)
        Me.BotonAñadir.TabIndex = 11
        Me.BotonAñadir.Text = "AÑADIR"
        Me.BotonAñadir.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "DESCRIPCION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(451, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "CANTIDAD"
        '
        'DataGirdRegistrarVenta
        '
        Me.DataGirdRegistrarVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGirdRegistrarVenta.Location = New System.Drawing.Point(12, 197)
        Me.DataGirdRegistrarVenta.Name = "DataGirdRegistrarVenta"
        Me.DataGirdRegistrarVenta.Size = New System.Drawing.Size(629, 72)
        Me.DataGirdRegistrarVenta.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(102, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "TOTAL     $"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(309, 300)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "RECIBIDO     $"
        '
        'RecibidoRegistrarVenta
        '
        Me.RecibidoRegistrarVenta.Location = New System.Drawing.Point(394, 300)
        Me.RecibidoRegistrarVenta.Name = "RecibidoRegistrarVenta"
        Me.RecibidoRegistrarVenta.Size = New System.Drawing.Size(88, 20)
        Me.RecibidoRegistrarVenta.TabIndex = 17
        '
        'BotonAceptar
        '
        Me.BotonAceptar.Location = New System.Drawing.Point(499, 297)
        Me.BotonAceptar.Name = "BotonAceptar"
        Me.BotonAceptar.Size = New System.Drawing.Size(84, 23)
        Me.BotonAceptar.TabIndex = 18
        Me.BotonAceptar.Text = "ACEPTAR"
        Me.BotonAceptar.UseVisualStyleBackColor = True
        '
        'REGISTRAR_VENTA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 362)
        Me.Controls.Add(Me.BotonAceptar)
        Me.Controls.Add(Me.RecibidoRegistrarVenta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGirdRegistrarVenta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BotonAñadir)
        Me.Controls.Add(Me.LupitaRegistrarVenta)
        Me.Controls.Add(Me.CantidadRegistrarVenta)
        Me.Controls.Add(Me.Descripcion2)
        Me.Controls.Add(Me.TotalRegistrarVenta)
        Me.Controls.Add(Me.MontoRegistrarVentas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Descripcion1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxRegistrarVentas)
        Me.Name = "REGISTRAR_VENTA"
        Me.Text = "REGISTRAR VENTA"
        CType(Me.DataGirdRegistrarVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxRegistrarVentas As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Descripcion1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MontoRegistrarVentas As TextBox
    Friend WithEvents TotalRegistrarVenta As TextBox
    Friend WithEvents Descripcion2 As TextBox
    Friend WithEvents CantidadRegistrarVenta As TextBox
    Friend WithEvents LupitaRegistrarVenta As Button
    Friend WithEvents BotonAñadir As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGirdRegistrarVenta As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents RecibidoRegistrarVenta As TextBox
    Friend WithEvents BotonAceptar As Button
End Class
