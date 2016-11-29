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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(REGISTRAR_VENTA))
        Me.ComboBoxRegistrarVentas = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Descripcion1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MontoRegistrarVentas = New System.Windows.Forms.TextBox()
        Me.TotalRegistrarVenta = New System.Windows.Forms.TextBox()
        Me.Descripcion2 = New System.Windows.Forms.TextBox()
        Me.LupitaRegistrarVenta = New System.Windows.Forms.Button()
        Me.BotonAñadir = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGirdRegistrarVenta = New System.Windows.Forms.DataGridView()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RecibidoRegistrarVenta = New System.Windows.Forms.TextBox()
        Me.BotonAceptar = New System.Windows.Forms.Button()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGirdRegistrarVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBoxRegistrarVentas
        '
        Me.ComboBoxRegistrarVentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxRegistrarVentas.FormattingEnabled = True
        Me.ComboBoxRegistrarVentas.Items.AddRange(New Object() {"Servicio cita", "Venta de productos", "Servicio express"})
        Me.ComboBoxRegistrarVentas.Location = New System.Drawing.Point(364, 15)
        Me.ComboBoxRegistrarVentas.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxRegistrarVentas.Name = "ComboBoxRegistrarVentas"
        Me.ComboBoxRegistrarVentas.Size = New System.Drawing.Size(431, 24)
        Me.ComboBoxRegistrarVentas.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "DESCRIPCION "
        '
        'Descripcion1
        '
        Me.Descripcion1.Location = New System.Drawing.Point(127, 27)
        Me.Descripcion1.Margin = New System.Windows.Forms.Padding(4)
        Me.Descripcion1.Name = "Descripcion1"
        Me.Descripcion1.Size = New System.Drawing.Size(431, 22)
        Me.Descripcion1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(567, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "MONTO    $"
        '
        'MontoRegistrarVentas
        '
        Me.MontoRegistrarVentas.Location = New System.Drawing.Point(661, 31)
        Me.MontoRegistrarVentas.Margin = New System.Windows.Forms.Padding(4)
        Me.MontoRegistrarVentas.Name = "MontoRegistrarVentas"
        Me.MontoRegistrarVentas.Size = New System.Drawing.Size(87, 22)
        Me.MontoRegistrarVentas.TabIndex = 6
        Me.MontoRegistrarVentas.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TotalRegistrarVenta
        '
        Me.TotalRegistrarVenta.Location = New System.Drawing.Point(115, 533)
        Me.TotalRegistrarVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalRegistrarVenta.Name = "TotalRegistrarVenta"
        Me.TotalRegistrarVenta.ReadOnly = True
        Me.TotalRegistrarVenta.Size = New System.Drawing.Size(132, 22)
        Me.TotalRegistrarVenta.TabIndex = 7
        Me.TotalRegistrarVenta.Text = "0"
        '
        'Descripcion2
        '
        Me.Descripcion2.Location = New System.Drawing.Point(107, 28)
        Me.Descripcion2.Margin = New System.Windows.Forms.Padding(4)
        Me.Descripcion2.Name = "Descripcion2"
        Me.Descripcion2.Size = New System.Drawing.Size(309, 22)
        Me.Descripcion2.TabIndex = 8
        '
        'LupitaRegistrarVenta
        '
        Me.LupitaRegistrarVenta.BackgroundImage = CType(resources.GetObject("LupitaRegistrarVenta.BackgroundImage"), System.Drawing.Image)
        Me.LupitaRegistrarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LupitaRegistrarVenta.Location = New System.Drawing.Point(427, 22)
        Me.LupitaRegistrarVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.LupitaRegistrarVenta.Name = "LupitaRegistrarVenta"
        Me.LupitaRegistrarVenta.Size = New System.Drawing.Size(52, 39)
        Me.LupitaRegistrarVenta.TabIndex = 10
        Me.LupitaRegistrarVenta.UseVisualStyleBackColor = True
        '
        'BotonAñadir
        '
        Me.BotonAñadir.Location = New System.Drawing.Point(501, 25)
        Me.BotonAñadir.Margin = New System.Windows.Forms.Padding(4)
        Me.BotonAñadir.Name = "BotonAñadir"
        Me.BotonAñadir.Size = New System.Drawing.Size(100, 28)
        Me.BotonAñadir.TabIndex = 11
        Me.BotonAñadir.Text = "AÑADIR"
        Me.BotonAñadir.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "PRODUCTO"
        '
        'DataGirdRegistrarVenta
        '
        Me.DataGirdRegistrarVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGirdRegistrarVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombre, Me.desc, Me.PrecioV})
        Me.DataGirdRegistrarVenta.Location = New System.Drawing.Point(40, 69)
        Me.DataGirdRegistrarVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGirdRegistrarVenta.Name = "DataGirdRegistrarVenta"
        Me.DataGirdRegistrarVenta.Size = New System.Drawing.Size(457, 267)
        Me.DataGirdRegistrarVenta.TabIndex = 14
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        '
        'desc
        '
        Me.desc.HeaderText = "Descripcion"
        Me.desc.Name = "desc"
        '
        'PrecioV
        '
        Me.PrecioV.HeaderText = "Precio"
        Me.PrecioV.Name = "PrecioV"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 537)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "TOTAL     $"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(256, 537)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "RECIBIDO     $"
        '
        'RecibidoRegistrarVenta
        '
        Me.RecibidoRegistrarVenta.Location = New System.Drawing.Point(364, 534)
        Me.RecibidoRegistrarVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.RecibidoRegistrarVenta.Name = "RecibidoRegistrarVenta"
        Me.RecibidoRegistrarVenta.Size = New System.Drawing.Size(116, 22)
        Me.RecibidoRegistrarVenta.TabIndex = 17
        Me.RecibidoRegistrarVenta.Text = "0"
        '
        'BotonAceptar
        '
        Me.BotonAceptar.Location = New System.Drawing.Point(943, 537)
        Me.BotonAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.BotonAceptar.Name = "BotonAceptar"
        Me.BotonAceptar.Size = New System.Drawing.Size(112, 28)
        Me.BotonAceptar.TabIndex = 18
        Me.BotonAceptar.Text = "ACEPTAR"
        Me.BotonAceptar.UseVisualStyleBackColor = True
        '
        'Limpiar
        '
        Me.Limpiar.Location = New System.Drawing.Point(609, 26)
        Me.Limpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(100, 28)
        Me.Limpiar.TabIndex = 19
        Me.Limpiar.Text = "LIMPIAR"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Descripcion1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.MontoRegistrarVentas)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 48)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1012, 78)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SERVICIO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(280, 18)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "SERVICIO"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Descripcion2)
        Me.GroupBox2.Controls.Add(Me.LupitaRegistrarVenta)
        Me.GroupBox2.Controls.Add(Me.Limpiar)
        Me.GroupBox2.Controls.Add(Me.BotonAñadir)
        Me.GroupBox2.Controls.Add(Me.DataGirdRegistrarVenta)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 146)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1012, 364)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BUSCAR"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(579, 533)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 22)
        Me.TextBox1.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(495, 537)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 17)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "CAMBIO $"
        '
        'REGISTRAR_VENTA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 574)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BotonAceptar)
        Me.Controls.Add(Me.ComboBoxRegistrarVentas)
        Me.Controls.Add(Me.RecibidoRegistrarVenta)
        Me.Controls.Add(Me.TotalRegistrarVenta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "REGISTRAR_VENTA"
        Me.Text = "REGISTRAR VENTA"
        CType(Me.DataGirdRegistrarVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents LupitaRegistrarVenta As Button
    Friend WithEvents BotonAñadir As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGirdRegistrarVenta As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents RecibidoRegistrarVenta As TextBox
    Friend WithEvents BotonAceptar As Button
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents desc As DataGridViewTextBoxColumn
    Friend WithEvents PrecioV As DataGridViewTextBoxColumn
    Friend WithEvents Limpiar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
