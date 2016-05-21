<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_proveedor
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
        Me.LBL_nombre = New System.Windows.Forms.Label()
        Me.LBL_estado = New System.Windows.Forms.Label()
        Me.LBL_ciudad = New System.Windows.Forms.Label()
        Me.LBL_rfc = New System.Windows.Forms.Label()
        Me.LBL_cp = New System.Windows.Forms.Label()
        Me.LBL_numero = New System.Windows.Forms.Label()
        Me.LBL_id = New System.Windows.Forms.Label()
        Me.TXT_nombre = New System.Windows.Forms.TextBox()
        Me.LBL_calle = New System.Windows.Forms.Label()
        Me.LBL_colonia = New System.Windows.Forms.Label()
        Me.TXT_rfc = New System.Windows.Forms.TextBox()
        Me.TXT_cp = New System.Windows.Forms.TextBox()
        Me.TXT_ciudad = New System.Windows.Forms.TextBox()
        Me.TXT_estado = New System.Windows.Forms.TextBox()
        Me.TXT_numero = New System.Windows.Forms.TextBox()
        Me.TXT_colonia = New System.Windows.Forms.TextBox()
        Me.TXT_calle = New System.Windows.Forms.TextBox()
        Me.TXT_id = New System.Windows.Forms.TextBox()
        Me.BTN_salir = New System.Windows.Forms.Button()
        Me.BTN_exportar = New System.Windows.Forms.Button()
        Me.BTN_reporte = New System.Windows.Forms.Button()
        Me.BTN_limpiar = New System.Windows.Forms.Button()
        Me.BTN_eliminar = New System.Windows.Forms.Button()
        Me.BTN_guardar = New System.Windows.Forms.Button()
        Me.BTN_nuevo = New System.Windows.Forms.Button()
        Me.DGV_proveedor = New System.Windows.Forms.DataGridView()
        CType(Me.DGV_proveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBL_nombre
        '
        Me.LBL_nombre.AutoSize = True
        Me.LBL_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_nombre.Location = New System.Drawing.Point(218, 24)
        Me.LBL_nombre.Name = "LBL_nombre"
        Me.LBL_nombre.Size = New System.Drawing.Size(60, 16)
        Me.LBL_nombre.TabIndex = 11
        Me.LBL_nombre.Text = "Nombre "
        '
        'LBL_estado
        '
        Me.LBL_estado.AutoSize = True
        Me.LBL_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_estado.Location = New System.Drawing.Point(646, 95)
        Me.LBL_estado.Name = "LBL_estado"
        Me.LBL_estado.Size = New System.Drawing.Size(51, 16)
        Me.LBL_estado.TabIndex = 19
        Me.LBL_estado.Text = "Estado"
        '
        'LBL_ciudad
        '
        Me.LBL_ciudad.AutoSize = True
        Me.LBL_ciudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_ciudad.Location = New System.Drawing.Point(72, 95)
        Me.LBL_ciudad.Name = "LBL_ciudad"
        Me.LBL_ciudad.Size = New System.Drawing.Size(51, 16)
        Me.LBL_ciudad.TabIndex = 17
        Me.LBL_ciudad.Text = "Ciudad"
        '
        'LBL_rfc
        '
        Me.LBL_rfc.AutoSize = True
        Me.LBL_rfc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_rfc.Location = New System.Drawing.Point(516, 24)
        Me.LBL_rfc.Name = "LBL_rfc"
        Me.LBL_rfc.Size = New System.Drawing.Size(35, 16)
        Me.LBL_rfc.TabIndex = 12
        Me.LBL_rfc.Text = "RFC"
        '
        'LBL_cp
        '
        Me.LBL_cp.AutoSize = True
        Me.LBL_cp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_cp.Location = New System.Drawing.Point(522, 95)
        Me.LBL_cp.Name = "LBL_cp"
        Me.LBL_cp.Size = New System.Drawing.Size(29, 16)
        Me.LBL_cp.TabIndex = 15
        Me.LBL_cp.Text = "C.P"
        '
        'LBL_numero
        '
        Me.LBL_numero.AutoSize = True
        Me.LBL_numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_numero.Location = New System.Drawing.Point(495, 57)
        Me.LBL_numero.Name = "LBL_numero"
        Me.LBL_numero.Size = New System.Drawing.Size(56, 16)
        Me.LBL_numero.TabIndex = 14
        Me.LBL_numero.Text = "Numero"
        '
        'LBL_id
        '
        Me.LBL_id.AutoSize = True
        Me.LBL_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_id.Location = New System.Drawing.Point(72, 24)
        Me.LBL_id.Name = "LBL_id"
        Me.LBL_id.Size = New System.Drawing.Size(21, 16)
        Me.LBL_id.TabIndex = 10
        Me.LBL_id.Text = "ID"
        '
        'TXT_nombre
        '
        Me.TXT_nombre.Location = New System.Drawing.Point(284, 24)
        Me.TXT_nombre.MaxLength = 100
        Me.TXT_nombre.Name = "TXT_nombre"
        Me.TXT_nombre.Size = New System.Drawing.Size(193, 20)
        Me.TXT_nombre.TabIndex = 1
        '
        'LBL_calle
        '
        Me.LBL_calle.AutoSize = True
        Me.LBL_calle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_calle.Location = New System.Drawing.Point(72, 57)
        Me.LBL_calle.Name = "LBL_calle"
        Me.LBL_calle.Size = New System.Drawing.Size(39, 16)
        Me.LBL_calle.TabIndex = 13
        Me.LBL_calle.Text = "Calle"
        '
        'LBL_colonia
        '
        Me.LBL_colonia.AutoSize = True
        Me.LBL_colonia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_colonia.Location = New System.Drawing.Point(643, 57)
        Me.LBL_colonia.Name = "LBL_colonia"
        Me.LBL_colonia.Size = New System.Drawing.Size(54, 16)
        Me.LBL_colonia.TabIndex = 16
        Me.LBL_colonia.Text = "Colonia"
        '
        'TXT_rfc
        '
        Me.TXT_rfc.Location = New System.Drawing.Point(557, 20)
        Me.TXT_rfc.MaxLength = 15
        Me.TXT_rfc.Name = "TXT_rfc"
        Me.TXT_rfc.Size = New System.Drawing.Size(140, 20)
        Me.TXT_rfc.TabIndex = 2
        '
        'TXT_cp
        '
        Me.TXT_cp.Location = New System.Drawing.Point(557, 94)
        Me.TXT_cp.MaxLength = 6
        Me.TXT_cp.Name = "TXT_cp"
        Me.TXT_cp.Size = New System.Drawing.Size(78, 20)
        Me.TXT_cp.TabIndex = 5
        '
        'TXT_ciudad
        '
        Me.TXT_ciudad.Location = New System.Drawing.Point(129, 94)
        Me.TXT_ciudad.MaxLength = 50
        Me.TXT_ciudad.Name = "TXT_ciudad"
        Me.TXT_ciudad.Size = New System.Drawing.Size(347, 20)
        Me.TXT_ciudad.TabIndex = 7
        '
        'TXT_estado
        '
        Me.TXT_estado.Location = New System.Drawing.Point(703, 91)
        Me.TXT_estado.MaxLength = 30
        Me.TXT_estado.Name = "TXT_estado"
        Me.TXT_estado.Size = New System.Drawing.Size(223, 20)
        Me.TXT_estado.TabIndex = 9
        '
        'TXT_numero
        '
        Me.TXT_numero.Location = New System.Drawing.Point(557, 55)
        Me.TXT_numero.Name = "TXT_numero"
        Me.TXT_numero.Size = New System.Drawing.Size(78, 20)
        Me.TXT_numero.TabIndex = 4
        '
        'TXT_colonia
        '
        Me.TXT_colonia.Location = New System.Drawing.Point(703, 56)
        Me.TXT_colonia.MaxLength = 100
        Me.TXT_colonia.Name = "TXT_colonia"
        Me.TXT_colonia.Size = New System.Drawing.Size(220, 20)
        Me.TXT_colonia.TabIndex = 6
        '
        'TXT_calle
        '
        Me.TXT_calle.Location = New System.Drawing.Point(130, 55)
        Me.TXT_calle.MaxLength = 100
        Me.TXT_calle.Name = "TXT_calle"
        Me.TXT_calle.Size = New System.Drawing.Size(347, 20)
        Me.TXT_calle.TabIndex = 3
        '
        'TXT_id
        '
        Me.TXT_id.Location = New System.Drawing.Point(130, 23)
        Me.TXT_id.Name = "TXT_id"
        Me.TXT_id.Size = New System.Drawing.Size(73, 20)
        Me.TXT_id.TabIndex = 0
        '
        'BTN_salir
        '
        Me.BTN_salir.BackColor = System.Drawing.Color.DimGray
        Me.BTN_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_salir.Location = New System.Drawing.Point(833, 376)
        Me.BTN_salir.Name = "BTN_salir"
        Me.BTN_salir.Size = New System.Drawing.Size(75, 23)
        Me.BTN_salir.TabIndex = 49
        Me.BTN_salir.Text = "&Salir"
        Me.BTN_salir.UseVisualStyleBackColor = False
        '
        'BTN_exportar
        '
        Me.BTN_exportar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_exportar.Location = New System.Drawing.Point(833, 308)
        Me.BTN_exportar.Name = "BTN_exportar"
        Me.BTN_exportar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_exportar.TabIndex = 48
        Me.BTN_exportar.Text = "&Exportar"
        Me.BTN_exportar.UseVisualStyleBackColor = True
        '
        'BTN_reporte
        '
        Me.BTN_reporte.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_reporte.Location = New System.Drawing.Point(833, 279)
        Me.BTN_reporte.Name = "BTN_reporte"
        Me.BTN_reporte.Size = New System.Drawing.Size(75, 23)
        Me.BTN_reporte.TabIndex = 47
        Me.BTN_reporte.Text = "&Reporte"
        Me.BTN_reporte.UseVisualStyleBackColor = True
        '
        'BTN_limpiar
        '
        Me.BTN_limpiar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_limpiar.Location = New System.Drawing.Point(833, 250)
        Me.BTN_limpiar.Name = "BTN_limpiar"
        Me.BTN_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_limpiar.TabIndex = 46
        Me.BTN_limpiar.Text = "&Limpiar"
        Me.BTN_limpiar.UseVisualStyleBackColor = True
        '
        'BTN_eliminar
        '
        Me.BTN_eliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_eliminar.Location = New System.Drawing.Point(833, 221)
        Me.BTN_eliminar.Name = "BTN_eliminar"
        Me.BTN_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_eliminar.TabIndex = 45
        Me.BTN_eliminar.Text = "&Eliminar"
        Me.BTN_eliminar.UseVisualStyleBackColor = True
        '
        'BTN_guardar
        '
        Me.BTN_guardar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_guardar.Location = New System.Drawing.Point(833, 192)
        Me.BTN_guardar.Name = "BTN_guardar"
        Me.BTN_guardar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_guardar.TabIndex = 44
        Me.BTN_guardar.Text = "&Guardar"
        Me.BTN_guardar.UseVisualStyleBackColor = True
        '
        'BTN_nuevo
        '
        Me.BTN_nuevo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_nuevo.Location = New System.Drawing.Point(833, 163)
        Me.BTN_nuevo.Name = "BTN_nuevo"
        Me.BTN_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.BTN_nuevo.TabIndex = 43
        Me.BTN_nuevo.Text = "&Nuevo"
        Me.BTN_nuevo.UseVisualStyleBackColor = True
        '
        'DGV_proveedor
        '
        Me.DGV_proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_proveedor.Location = New System.Drawing.Point(75, 163)
        Me.DGV_proveedor.Name = "DGV_proveedor"
        Me.DGV_proveedor.Size = New System.Drawing.Size(735, 296)
        Me.DGV_proveedor.TabIndex = 42
        '
        'FRM_proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SpringGreen
        Me.ClientSize = New System.Drawing.Size(984, 471)
        Me.Controls.Add(Me.LBL_nombre)
        Me.Controls.Add(Me.LBL_estado)
        Me.Controls.Add(Me.BTN_salir)
        Me.Controls.Add(Me.LBL_ciudad)
        Me.Controls.Add(Me.BTN_exportar)
        Me.Controls.Add(Me.LBL_rfc)
        Me.Controls.Add(Me.BTN_reporte)
        Me.Controls.Add(Me.LBL_cp)
        Me.Controls.Add(Me.BTN_limpiar)
        Me.Controls.Add(Me.LBL_numero)
        Me.Controls.Add(Me.BTN_eliminar)
        Me.Controls.Add(Me.LBL_id)
        Me.Controls.Add(Me.BTN_guardar)
        Me.Controls.Add(Me.TXT_nombre)
        Me.Controls.Add(Me.LBL_calle)
        Me.Controls.Add(Me.BTN_nuevo)
        Me.Controls.Add(Me.LBL_colonia)
        Me.Controls.Add(Me.DGV_proveedor)
        Me.Controls.Add(Me.TXT_rfc)
        Me.Controls.Add(Me.TXT_cp)
        Me.Controls.Add(Me.TXT_id)
        Me.Controls.Add(Me.TXT_ciudad)
        Me.Controls.Add(Me.TXT_calle)
        Me.Controls.Add(Me.TXT_estado)
        Me.Controls.Add(Me.TXT_colonia)
        Me.Controls.Add(Me.TXT_numero)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_proveedor"
        Me.Text = "Cliente"
        CType(Me.DGV_proveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBL_nombre As System.Windows.Forms.Label
    Friend WithEvents LBL_estado As System.Windows.Forms.Label
    Friend WithEvents LBL_ciudad As System.Windows.Forms.Label
    Friend WithEvents LBL_rfc As System.Windows.Forms.Label
    Friend WithEvents LBL_cp As System.Windows.Forms.Label
    Friend WithEvents LBL_numero As System.Windows.Forms.Label
    Friend WithEvents LBL_id As System.Windows.Forms.Label
    Friend WithEvents TXT_nombre As System.Windows.Forms.TextBox
    Friend WithEvents LBL_calle As System.Windows.Forms.Label
    Friend WithEvents LBL_colonia As System.Windows.Forms.Label
    Friend WithEvents TXT_rfc As System.Windows.Forms.TextBox
    Friend WithEvents TXT_cp As System.Windows.Forms.TextBox
    Friend WithEvents TXT_ciudad As System.Windows.Forms.TextBox
    Friend WithEvents TXT_estado As System.Windows.Forms.TextBox
    Friend WithEvents TXT_numero As System.Windows.Forms.TextBox
    Friend WithEvents TXT_colonia As System.Windows.Forms.TextBox
    Friend WithEvents TXT_calle As System.Windows.Forms.TextBox
    Friend WithEvents TXT_id As System.Windows.Forms.TextBox
    Friend WithEvents BTN_salir As System.Windows.Forms.Button
    Friend WithEvents BTN_exportar As System.Windows.Forms.Button
    Friend WithEvents BTN_reporte As System.Windows.Forms.Button
    Friend WithEvents BTN_limpiar As System.Windows.Forms.Button
    Friend WithEvents BTN_eliminar As System.Windows.Forms.Button
    Friend WithEvents BTN_guardar As System.Windows.Forms.Button
    Friend WithEvents BTN_nuevo As System.Windows.Forms.Button
    Friend WithEvents DGV_proveedor As System.Windows.Forms.DataGridView
End Class
