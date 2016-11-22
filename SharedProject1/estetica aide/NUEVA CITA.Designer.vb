<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NUEVA_CITA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NUEVA_CITA))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BUSCAR = New System.Windows.Forms.Button()
        Me.txtclave = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboSel = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BUSCAR)
        Me.GroupBox1.Controls.Add(Me.txtclave)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(515, 119)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DEL CLIENTE"
        '
        'BUSCAR
        '
        Me.BUSCAR.BackgroundImage = CType(resources.GetObject("BUSCAR.BackgroundImage"), System.Drawing.Image)
        Me.BUSCAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BUSCAR.Location = New System.Drawing.Point(460, 41)
        Me.BUSCAR.Name = "BUSCAR"
        Me.BUSCAR.Size = New System.Drawing.Size(42, 38)
        Me.BUSCAR.TabIndex = 5
        Me.BUSCAR.UseVisualStyleBackColor = True
        '
        'txtclave
        '
        Me.txtclave.Location = New System.Drawing.Point(358, 51)
        Me.txtclave.Name = "txtclave"
        Me.txtclave.Size = New System.Drawing.Size(83, 20)
        Me.txtclave.TabIndex = 3
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(64, 55)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(232, 20)
        Me.TxtNombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(311, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CLAVE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CLIENTE"
        '
        'btnAceptar
        '
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Location = New System.Drawing.Point(453, 217)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(83, 21)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "ACEPTAR"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Fecha
        '
        Me.Fecha.Enabled = False
        Me.Fecha.Location = New System.Drawing.Point(85, 175)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(200, 20)
        Me.Fecha.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "FECHA"
        '
        'ComboSel
        '
        Me.ComboSel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboSel.FormattingEnabled = True
        Me.ComboSel.Items.AddRange(New Object() {"8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00"})
        Me.ComboSel.Location = New System.Drawing.Point(304, 175)
        Me.ComboSel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboSel.Name = "ComboSel"
        Me.ComboSel.Size = New System.Drawing.Size(92, 21)
        Me.ComboSel.TabIndex = 4
        '
        'NUEVA_CITA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 261)
        Me.Controls.Add(Me.ComboSel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "NUEVA_CITA"
        Me.Text = "NUEVA CITA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtclave As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents Fecha As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents BUSCAR As Button
    Friend WithEvents ComboSel As ComboBox
End Class
