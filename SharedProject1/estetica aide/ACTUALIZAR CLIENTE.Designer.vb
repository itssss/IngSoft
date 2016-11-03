<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTUALIZAR_CLIENTE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ACTUALIZAR_CLIENTE))
        Me.Combo = New System.Windows.Forms.ComboBox()
        Me.BoxBuscar = New System.Windows.Forms.GroupBox()
        Me.BUSCAR = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txtclave = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckTerm = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtNombre1 = New System.Windows.Forms.TextBox()
        Me.TxtTel = New System.Windows.Forms.TextBox()
        Me.TxtDir = New System.Windows.Forms.TextBox()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.TxtDesc = New System.Windows.Forms.TextBox()
        Me.GUARDAR = New System.Windows.Forms.Button()
        Me.ELIMINAR = New System.Windows.Forms.Button()
        Me.BoxDatos = New System.Windows.Forms.GroupBox()
        Me.BoxBuscar.SuspendLayout()
        Me.BoxDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Combo
        '
        Me.Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo.FormattingEnabled = True
        Me.Combo.Items.AddRange(New Object() {"INGRESAR", "MODIFICAR"})
        Me.Combo.Location = New System.Drawing.Point(599, 16)
        Me.Combo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Combo.Name = "Combo"
        Me.Combo.Size = New System.Drawing.Size(243, 24)
        Me.Combo.TabIndex = 0
        '
        'BoxBuscar
        '
        Me.BoxBuscar.Controls.Add(Me.BUSCAR)
        Me.BoxBuscar.Controls.Add(Me.Label3)
        Me.BoxBuscar.Controls.Add(Me.Txtclave)
        Me.BoxBuscar.Controls.Add(Me.TxtNombre)
        Me.BoxBuscar.Controls.Add(Me.Label2)
        Me.BoxBuscar.Enabled = False
        Me.BoxBuscar.Location = New System.Drawing.Point(22, 48)
        Me.BoxBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BoxBuscar.Name = "BoxBuscar"
        Me.BoxBuscar.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BoxBuscar.Size = New System.Drawing.Size(824, 83)
        Me.BoxBuscar.TabIndex = 2
        Me.BoxBuscar.TabStop = False
        Me.BoxBuscar.Text = "Buscar"
        '
        'BUSCAR
        '
        Me.BUSCAR.BackgroundImage = CType(resources.GetObject("BUSCAR.BackgroundImage"), System.Drawing.Image)
        Me.BUSCAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BUSCAR.Location = New System.Drawing.Point(758, 23)
        Me.BUSCAR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BUSCAR.Name = "BUSCAR"
        Me.BUSCAR.Size = New System.Drawing.Size(56, 47)
        Me.BUSCAR.TabIndex = 4
        Me.BUSCAR.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(567, 37)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "CLAVE"
        '
        'Txtclave
        '
        Me.Txtclave.Location = New System.Drawing.Point(629, 33)
        Me.Txtclave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtclave.Name = "Txtclave"
        Me.Txtclave.Size = New System.Drawing.Size(109, 22)
        Me.Txtclave.TabIndex = 2
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(92, 33)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(437, 22)
        Me.TxtNombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "NOMBRE "
        '
        'CheckTerm
        '
        Me.CheckTerm.AutoSize = True
        Me.CheckTerm.Location = New System.Drawing.Point(22, 392)
        Me.CheckTerm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckTerm.Name = "CheckTerm"
        Me.CheckTerm.Size = New System.Drawing.Size(273, 21)
        Me.CheckTerm.TabIndex = 3
        Me.CheckTerm.Text = "ACEPTO TERMINOS Y CONDICIONES"
        Me.CheckTerm.UseVisualStyleBackColor = True
        Me.CheckTerm.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 33)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "NOMBRE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 71)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "TELEFONO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 114)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "DIRECCION"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 154)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "CORREO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 194)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "DESCRIPCION"
        '
        'TxtNombre1
        '
        Me.TxtNombre1.Location = New System.Drawing.Point(134, 29)
        Me.TxtNombre1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNombre1.Name = "TxtNombre1"
        Me.TxtNombre1.Size = New System.Drawing.Size(686, 22)
        Me.TxtNombre1.TabIndex = 9
        '
        'TxtTel
        '
        Me.TxtTel.Location = New System.Drawing.Point(134, 68)
        Me.TxtTel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(328, 22)
        Me.TxtTel.TabIndex = 10
        '
        'TxtDir
        '
        Me.TxtDir.Location = New System.Drawing.Point(134, 106)
        Me.TxtDir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtDir.Name = "TxtDir"
        Me.TxtDir.Size = New System.Drawing.Size(685, 22)
        Me.TxtDir.TabIndex = 11
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Location = New System.Drawing.Point(134, 154)
        Me.TxtCorreo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(328, 22)
        Me.TxtCorreo.TabIndex = 12
        '
        'TxtDesc
        '
        Me.TxtDesc.Location = New System.Drawing.Point(134, 191)
        Me.TxtDesc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.Size = New System.Drawing.Size(686, 22)
        Me.TxtDesc.TabIndex = 13
        '
        'GUARDAR
        '
        Me.GUARDAR.Location = New System.Drawing.Point(613, 385)
        Me.GUARDAR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GUARDAR.Name = "GUARDAR"
        Me.GUARDAR.Size = New System.Drawing.Size(100, 28)
        Me.GUARDAR.TabIndex = 14
        Me.GUARDAR.Text = "GUARDAR"
        Me.GUARDAR.UseVisualStyleBackColor = True
        '
        'ELIMINAR
        '
        Me.ELIMINAR.Location = New System.Drawing.Point(748, 385)
        Me.ELIMINAR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ELIMINAR.Name = "ELIMINAR"
        Me.ELIMINAR.Size = New System.Drawing.Size(100, 28)
        Me.ELIMINAR.TabIndex = 15
        Me.ELIMINAR.Text = "ELIMINAR"
        Me.ELIMINAR.UseVisualStyleBackColor = True
        '
        'BoxDatos
        '
        Me.BoxDatos.Controls.Add(Me.Label4)
        Me.BoxDatos.Controls.Add(Me.Label5)
        Me.BoxDatos.Controls.Add(Me.Label6)
        Me.BoxDatos.Controls.Add(Me.TxtDesc)
        Me.BoxDatos.Controls.Add(Me.Label7)
        Me.BoxDatos.Controls.Add(Me.TxtCorreo)
        Me.BoxDatos.Controls.Add(Me.Label8)
        Me.BoxDatos.Controls.Add(Me.TxtDir)
        Me.BoxDatos.Controls.Add(Me.TxtNombre1)
        Me.BoxDatos.Controls.Add(Me.TxtTel)
        Me.BoxDatos.Enabled = False
        Me.BoxDatos.Location = New System.Drawing.Point(22, 149)
        Me.BoxDatos.Name = "BoxDatos"
        Me.BoxDatos.Size = New System.Drawing.Size(824, 223)
        Me.BoxDatos.TabIndex = 16
        Me.BoxDatos.TabStop = False
        Me.BoxDatos.Text = "Datos"
        '
        'ACTUALIZAR_CLIENTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 438)
        Me.Controls.Add(Me.BoxDatos)
        Me.Controls.Add(Me.ELIMINAR)
        Me.Controls.Add(Me.GUARDAR)
        Me.Controls.Add(Me.CheckTerm)
        Me.Controls.Add(Me.BoxBuscar)
        Me.Controls.Add(Me.Combo)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ACTUALIZAR_CLIENTE"
        Me.Text = "ACTUALIZAR CLIENTE"
        Me.BoxBuscar.ResumeLayout(False)
        Me.BoxBuscar.PerformLayout()
        Me.BoxDatos.ResumeLayout(False)
        Me.BoxDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Combo As ComboBox
    Friend WithEvents BoxBuscar As GroupBox
    Friend WithEvents BUSCAR As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Txtclave As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckTerm As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtNombre1 As TextBox
    Friend WithEvents TxtTel As TextBox
    Friend WithEvents TxtDir As TextBox
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents TxtDesc As TextBox
    Friend WithEvents GUARDAR As Button
    Friend WithEvents ELIMINAR As Button
    Friend WithEvents BoxDatos As GroupBox
End Class
