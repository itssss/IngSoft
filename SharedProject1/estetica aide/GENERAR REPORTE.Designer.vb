<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GENERAR_REPORTE
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GENERAR_REPORTE))
        Me.FechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.FechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboSel = New System.Windows.Forms.ComboBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FechaInicio
        '
        Me.FechaInicio.Location = New System.Drawing.Point(132, 32)
        Me.FechaInicio.Margin = New System.Windows.Forms.Padding(4)
        Me.FechaInicio.Name = "FechaInicio"
        Me.FechaInicio.Size = New System.Drawing.Size(265, 22)
        Me.FechaInicio.TabIndex = 0
        '
        'FechaFin
        '
        Me.FechaFin.Location = New System.Drawing.Point(132, 96)
        Me.FechaFin.Margin = New System.Windows.Forms.Padding(4)
        Me.FechaFin.Name = "FechaFin"
        Me.FechaFin.Size = New System.Drawing.Size(265, 22)
        Me.FechaFin.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "FECHA INICIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 96)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "FECHA FINAL"
        '
        'ComboSel
        '
        Me.ComboSel.FormattingEnabled = True
        Me.ComboSel.Items.AddRange(New Object() {"Productos", "Clientes", "Ventas", "Gastos", "Citas"})
        Me.ComboSel.Location = New System.Drawing.Point(522, 34)
        Me.ComboSel.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboSel.Name = "ComboSel"
        Me.ComboSel.Size = New System.Drawing.Size(167, 24)
        Me.ComboSel.TabIndex = 4
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(577, 356)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(131, 28)
        Me.BtnGuardar.TabIndex = 6
        Me.BtnGuardar.Text = "GUARDAR PDF"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(44, 146)
        Me.DGV.Margin = New System.Windows.Forms.Padding(4)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(645, 188)
        Me.DGV.TabIndex = 7
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(614, 93)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 8
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'GENERAR_REPORTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 399)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.ComboSel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FechaFin)
        Me.Controls.Add(Me.FechaInicio)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "GENERAR_REPORTE"
        Me.Text = "GENERAR_REPORTE"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FechaInicio As DateTimePicker
    Friend WithEvents FechaFin As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboSel As ComboBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
End Class
