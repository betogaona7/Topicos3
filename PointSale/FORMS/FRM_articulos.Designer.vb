<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_articulos
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
        Me.TXT_codigo = New System.Windows.Forms.TextBox()
        Me.TXT_id = New System.Windows.Forms.TextBox()
        Me.LBL_codigo = New System.Windows.Forms.Label()
        Me.LBL_id = New System.Windows.Forms.Label()
        Me.BTN_salir = New System.Windows.Forms.Button()
        Me.BTN_exportar = New System.Windows.Forms.Button()
        Me.BTN_reporte = New System.Windows.Forms.Button()
        Me.BTN_limpiar = New System.Windows.Forms.Button()
        Me.BTN_eliminar = New System.Windows.Forms.Button()
        Me.BTN_guardar = New System.Windows.Forms.Button()
        Me.BTN_nuevo = New System.Windows.Forms.Button()
        Me.DGV_articulo = New System.Windows.Forms.DataGridView()
        Me.LBL_precio = New System.Windows.Forms.Label()
        Me.LBL_descripcion = New System.Windows.Forms.Label()
        Me.TXT_descripcion = New System.Windows.Forms.TextBox()
        Me.TXT_precio = New System.Windows.Forms.TextBox()
        Me.LBL_costo = New System.Windows.Forms.Label()
        Me.TXT_costo = New System.Windows.Forms.TextBox()
        CType(Me.DGV_articulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_codigo
        '
        Me.TXT_codigo.Location = New System.Drawing.Point(267, 57)
        Me.TXT_codigo.MaxLength = 149
        Me.TXT_codigo.Name = "TXT_codigo"
        Me.TXT_codigo.Size = New System.Drawing.Size(103, 20)
        Me.TXT_codigo.TabIndex = 41
        '
        'TXT_id
        '
        Me.TXT_id.Location = New System.Drawing.Point(146, 57)
        Me.TXT_id.Name = "TXT_id"
        Me.TXT_id.Size = New System.Drawing.Size(100, 20)
        Me.TXT_id.TabIndex = 40
        '
        'LBL_codigo
        '
        Me.LBL_codigo.AutoSize = True
        Me.LBL_codigo.Location = New System.Drawing.Point(264, 41)
        Me.LBL_codigo.Name = "LBL_codigo"
        Me.LBL_codigo.Size = New System.Drawing.Size(40, 13)
        Me.LBL_codigo.TabIndex = 43
        Me.LBL_codigo.Text = "Codigo"
        '
        'LBL_id
        '
        Me.LBL_id.AutoSize = True
        Me.LBL_id.Location = New System.Drawing.Point(143, 41)
        Me.LBL_id.Name = "LBL_id"
        Me.LBL_id.Size = New System.Drawing.Size(18, 13)
        Me.LBL_id.TabIndex = 42
        Me.LBL_id.Text = "ID"
        '
        'BTN_salir
        '
        Me.BTN_salir.BackColor = System.Drawing.Color.DimGray
        Me.BTN_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_salir.Location = New System.Drawing.Point(717, 400)
        Me.BTN_salir.Name = "BTN_salir"
        Me.BTN_salir.Size = New System.Drawing.Size(75, 23)
        Me.BTN_salir.TabIndex = 39
        Me.BTN_salir.Text = "&Salir"
        Me.BTN_salir.UseVisualStyleBackColor = False
        '
        'BTN_exportar
        '
        Me.BTN_exportar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_exportar.Location = New System.Drawing.Point(717, 332)
        Me.BTN_exportar.Name = "BTN_exportar"
        Me.BTN_exportar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_exportar.TabIndex = 38
        Me.BTN_exportar.Text = "&Exportar"
        Me.BTN_exportar.UseVisualStyleBackColor = True
        '
        'BTN_reporte
        '
        Me.BTN_reporte.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_reporte.Location = New System.Drawing.Point(717, 303)
        Me.BTN_reporte.Name = "BTN_reporte"
        Me.BTN_reporte.Size = New System.Drawing.Size(75, 23)
        Me.BTN_reporte.TabIndex = 37
        Me.BTN_reporte.Text = "&Reporte"
        Me.BTN_reporte.UseVisualStyleBackColor = True
        '
        'BTN_limpiar
        '
        Me.BTN_limpiar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_limpiar.Location = New System.Drawing.Point(717, 274)
        Me.BTN_limpiar.Name = "BTN_limpiar"
        Me.BTN_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_limpiar.TabIndex = 36
        Me.BTN_limpiar.Text = "&Limpiar"
        Me.BTN_limpiar.UseVisualStyleBackColor = True
        '
        'BTN_eliminar
        '
        Me.BTN_eliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_eliminar.Location = New System.Drawing.Point(717, 245)
        Me.BTN_eliminar.Name = "BTN_eliminar"
        Me.BTN_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_eliminar.TabIndex = 35
        Me.BTN_eliminar.Text = "&Eliminar"
        Me.BTN_eliminar.UseVisualStyleBackColor = True
        '
        'BTN_guardar
        '
        Me.BTN_guardar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_guardar.Location = New System.Drawing.Point(717, 216)
        Me.BTN_guardar.Name = "BTN_guardar"
        Me.BTN_guardar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_guardar.TabIndex = 34
        Me.BTN_guardar.Text = "&Guardar"
        Me.BTN_guardar.UseVisualStyleBackColor = True
        '
        'BTN_nuevo
        '
        Me.BTN_nuevo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_nuevo.Location = New System.Drawing.Point(717, 187)
        Me.BTN_nuevo.Name = "BTN_nuevo"
        Me.BTN_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.BTN_nuevo.TabIndex = 33
        Me.BTN_nuevo.Text = "&Nuevo"
        Me.BTN_nuevo.UseVisualStyleBackColor = True
        '
        'DGV_articulo
        '
        Me.DGV_articulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_articulo.Location = New System.Drawing.Point(121, 155)
        Me.DGV_articulo.Name = "DGV_articulo"
        Me.DGV_articulo.Size = New System.Drawing.Size(569, 268)
        Me.DGV_articulo.TabIndex = 32
        '
        'LBL_precio
        '
        Me.LBL_precio.AutoSize = True
        Me.LBL_precio.Location = New System.Drawing.Point(143, 96)
        Me.LBL_precio.Name = "LBL_precio"
        Me.LBL_precio.Size = New System.Drawing.Size(37, 13)
        Me.LBL_precio.TabIndex = 45
        Me.LBL_precio.Text = "Precio"
        '
        'LBL_descripcion
        '
        Me.LBL_descripcion.AutoSize = True
        Me.LBL_descripcion.Location = New System.Drawing.Point(406, 41)
        Me.LBL_descripcion.Name = "LBL_descripcion"
        Me.LBL_descripcion.Size = New System.Drawing.Size(63, 13)
        Me.LBL_descripcion.TabIndex = 46
        Me.LBL_descripcion.Text = "Descripcion"
        '
        'TXT_descripcion
        '
        Me.TXT_descripcion.Location = New System.Drawing.Point(409, 57)
        Me.TXT_descripcion.MaxLength = 149
        Me.TXT_descripcion.Name = "TXT_descripcion"
        Me.TXT_descripcion.Size = New System.Drawing.Size(288, 20)
        Me.TXT_descripcion.TabIndex = 47
        '
        'TXT_precio
        '
        Me.TXT_precio.Location = New System.Drawing.Point(186, 93)
        Me.TXT_precio.MaxLength = 149
        Me.TXT_precio.Name = "TXT_precio"
        Me.TXT_precio.Size = New System.Drawing.Size(103, 20)
        Me.TXT_precio.TabIndex = 48
        '
        'LBL_costo
        '
        Me.LBL_costo.AutoSize = True
        Me.LBL_costo.Location = New System.Drawing.Point(321, 96)
        Me.LBL_costo.Name = "LBL_costo"
        Me.LBL_costo.Size = New System.Drawing.Size(34, 13)
        Me.LBL_costo.TabIndex = 49
        Me.LBL_costo.Text = "Costo"
        '
        'TXT_costo
        '
        Me.TXT_costo.Location = New System.Drawing.Point(366, 93)
        Me.TXT_costo.MaxLength = 149
        Me.TXT_costo.Name = "TXT_costo"
        Me.TXT_costo.Size = New System.Drawing.Size(103, 20)
        Me.TXT_costo.TabIndex = 50
        '
        'FRM_articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(902, 513)
        Me.Controls.Add(Me.TXT_costo)
        Me.Controls.Add(Me.LBL_costo)
        Me.Controls.Add(Me.TXT_precio)
        Me.Controls.Add(Me.TXT_descripcion)
        Me.Controls.Add(Me.LBL_descripcion)
        Me.Controls.Add(Me.LBL_precio)
        Me.Controls.Add(Me.TXT_codigo)
        Me.Controls.Add(Me.TXT_id)
        Me.Controls.Add(Me.LBL_codigo)
        Me.Controls.Add(Me.LBL_id)
        Me.Controls.Add(Me.BTN_salir)
        Me.Controls.Add(Me.BTN_exportar)
        Me.Controls.Add(Me.BTN_reporte)
        Me.Controls.Add(Me.BTN_limpiar)
        Me.Controls.Add(Me.BTN_eliminar)
        Me.Controls.Add(Me.BTN_guardar)
        Me.Controls.Add(Me.BTN_nuevo)
        Me.Controls.Add(Me.DGV_articulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_articulos"
        Me.Text = "Articulos"
        CType(Me.DGV_articulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_codigo As System.Windows.Forms.TextBox
    Friend WithEvents TXT_id As System.Windows.Forms.TextBox
    Friend WithEvents LBL_codigo As System.Windows.Forms.Label
    Friend WithEvents LBL_id As System.Windows.Forms.Label
    Friend WithEvents BTN_salir As System.Windows.Forms.Button
    Friend WithEvents BTN_exportar As System.Windows.Forms.Button
    Friend WithEvents BTN_reporte As System.Windows.Forms.Button
    Friend WithEvents BTN_limpiar As System.Windows.Forms.Button
    Friend WithEvents BTN_eliminar As System.Windows.Forms.Button
    Friend WithEvents BTN_guardar As System.Windows.Forms.Button
    Friend WithEvents BTN_nuevo As System.Windows.Forms.Button
    Friend WithEvents DGV_articulo As System.Windows.Forms.DataGridView
    Friend WithEvents LBL_precio As System.Windows.Forms.Label
    Friend WithEvents LBL_descripcion As System.Windows.Forms.Label
    Friend WithEvents TXT_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents TXT_precio As System.Windows.Forms.TextBox
    Friend WithEvents LBL_costo As System.Windows.Forms.Label
    Friend WithEvents TXT_costo As System.Windows.Forms.TextBox
End Class
