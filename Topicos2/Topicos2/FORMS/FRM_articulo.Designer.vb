<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_articulo
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
        Me.TXT_id = New System.Windows.Forms.TextBox()
        Me.TXT_descripcion = New System.Windows.Forms.TextBox()
        Me.TXT_costo = New System.Windows.Forms.TextBox()
        Me.TXT_precio = New System.Windows.Forms.TextBox()
        Me.TXT_codigo = New System.Windows.Forms.TextBox()
        Me.LBL_id = New System.Windows.Forms.Label()
        Me.LBL_codigo = New System.Windows.Forms.Label()
        Me.LBL_descripcion = New System.Windows.Forms.Label()
        Me.LBL_precio = New System.Windows.Forms.Label()
        Me.LBL_costo = New System.Windows.Forms.Label()
        Me.DGV_articulo = New System.Windows.Forms.DataGridView()
        Me.BTN_guarda = New System.Windows.Forms.Button()
        Me.BTN_elimina = New System.Windows.Forms.Button()
        Me.BTN_limpia = New System.Windows.Forms.Button()
        Me.BTN_reporte = New System.Windows.Forms.Button()
        Me.BTN_salir = New System.Windows.Forms.Button()
        Me.BTN_nuevo = New System.Windows.Forms.Button()
        Me.BTN_exportar = New System.Windows.Forms.Button()
        CType(Me.DGV_articulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_id
        '
        Me.TXT_id.Location = New System.Drawing.Point(75, 24)
        Me.TXT_id.Name = "TXT_id"
        Me.TXT_id.Size = New System.Drawing.Size(75, 20)
        Me.TXT_id.TabIndex = 0
        '
        'TXT_descripcion
        '
        Me.TXT_descripcion.Location = New System.Drawing.Point(400, 24)
        Me.TXT_descripcion.Name = "TXT_descripcion"
        Me.TXT_descripcion.Size = New System.Drawing.Size(224, 20)
        Me.TXT_descripcion.TabIndex = 1
        '
        'TXT_costo
        '
        Me.TXT_costo.Location = New System.Drawing.Point(238, 60)
        Me.TXT_costo.Name = "TXT_costo"
        Me.TXT_costo.Size = New System.Drawing.Size(76, 20)
        Me.TXT_costo.TabIndex = 2
        '
        'TXT_precio
        '
        Me.TXT_precio.Location = New System.Drawing.Point(75, 60)
        Me.TXT_precio.Name = "TXT_precio"
        Me.TXT_precio.Size = New System.Drawing.Size(75, 20)
        Me.TXT_precio.TabIndex = 3
        '
        'TXT_codigo
        '
        Me.TXT_codigo.Location = New System.Drawing.Point(238, 24)
        Me.TXT_codigo.Name = "TXT_codigo"
        Me.TXT_codigo.Size = New System.Drawing.Size(76, 20)
        Me.TXT_codigo.TabIndex = 4
        '
        'LBL_id
        '
        Me.LBL_id.AutoSize = True
        Me.LBL_id.Location = New System.Drawing.Point(35, 27)
        Me.LBL_id.Name = "LBL_id"
        Me.LBL_id.Size = New System.Drawing.Size(18, 13)
        Me.LBL_id.TabIndex = 5
        Me.LBL_id.Text = "ID"
        '
        'LBL_codigo
        '
        Me.LBL_codigo.AutoSize = True
        Me.LBL_codigo.Location = New System.Drawing.Point(192, 27)
        Me.LBL_codigo.Name = "LBL_codigo"
        Me.LBL_codigo.Size = New System.Drawing.Size(40, 13)
        Me.LBL_codigo.TabIndex = 6
        Me.LBL_codigo.Text = "Codigo"
        '
        'LBL_descripcion
        '
        Me.LBL_descripcion.AutoSize = True
        Me.LBL_descripcion.Location = New System.Drawing.Point(331, 27)
        Me.LBL_descripcion.Name = "LBL_descripcion"
        Me.LBL_descripcion.Size = New System.Drawing.Size(63, 13)
        Me.LBL_descripcion.TabIndex = 7
        Me.LBL_descripcion.Text = "Descripcion"
        '
        'LBL_precio
        '
        Me.LBL_precio.AutoSize = True
        Me.LBL_precio.Location = New System.Drawing.Point(35, 67)
        Me.LBL_precio.Name = "LBL_precio"
        Me.LBL_precio.Size = New System.Drawing.Size(37, 13)
        Me.LBL_precio.TabIndex = 8
        Me.LBL_precio.Text = "Precio"
        '
        'LBL_costo
        '
        Me.LBL_costo.AutoSize = True
        Me.LBL_costo.Location = New System.Drawing.Point(192, 67)
        Me.LBL_costo.Name = "LBL_costo"
        Me.LBL_costo.Size = New System.Drawing.Size(34, 13)
        Me.LBL_costo.TabIndex = 9
        Me.LBL_costo.Text = "Costo"
        '
        'DGV_articulo
        '
        Me.DGV_articulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_articulo.Location = New System.Drawing.Point(38, 108)
        Me.DGV_articulo.Name = "DGV_articulo"
        Me.DGV_articulo.Size = New System.Drawing.Size(532, 207)
        Me.DGV_articulo.TabIndex = 10
        '
        'BTN_guarda
        '
        Me.BTN_guarda.Location = New System.Drawing.Point(611, 123)
        Me.BTN_guarda.Name = "BTN_guarda"
        Me.BTN_guarda.Size = New System.Drawing.Size(75, 23)
        Me.BTN_guarda.TabIndex = 16
        Me.BTN_guarda.Text = "Guarda"
        Me.BTN_guarda.UseVisualStyleBackColor = True
        '
        'BTN_elimina
        '
        Me.BTN_elimina.Location = New System.Drawing.Point(611, 152)
        Me.BTN_elimina.Name = "BTN_elimina"
        Me.BTN_elimina.Size = New System.Drawing.Size(75, 23)
        Me.BTN_elimina.TabIndex = 15
        Me.BTN_elimina.Text = "Elimina"
        Me.BTN_elimina.UseVisualStyleBackColor = True
        '
        'BTN_limpia
        '
        Me.BTN_limpia.Location = New System.Drawing.Point(610, 181)
        Me.BTN_limpia.Name = "BTN_limpia"
        Me.BTN_limpia.Size = New System.Drawing.Size(75, 23)
        Me.BTN_limpia.TabIndex = 14
        Me.BTN_limpia.Text = "Limpia"
        Me.BTN_limpia.UseVisualStyleBackColor = True
        '
        'BTN_reporte
        '
        Me.BTN_reporte.Location = New System.Drawing.Point(611, 210)
        Me.BTN_reporte.Name = "BTN_reporte"
        Me.BTN_reporte.Size = New System.Drawing.Size(75, 23)
        Me.BTN_reporte.TabIndex = 13
        Me.BTN_reporte.Text = "Reporte"
        Me.BTN_reporte.UseVisualStyleBackColor = True
        '
        'BTN_salir
        '
        Me.BTN_salir.Location = New System.Drawing.Point(611, 285)
        Me.BTN_salir.Name = "BTN_salir"
        Me.BTN_salir.Size = New System.Drawing.Size(75, 23)
        Me.BTN_salir.TabIndex = 12
        Me.BTN_salir.Text = "Salir "
        Me.BTN_salir.UseVisualStyleBackColor = True
        '
        'BTN_nuevo
        '
        Me.BTN_nuevo.Location = New System.Drawing.Point(611, 79)
        Me.BTN_nuevo.Name = "BTN_nuevo"
        Me.BTN_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.BTN_nuevo.TabIndex = 11
        Me.BTN_nuevo.Text = "Nuevo"
        Me.BTN_nuevo.UseVisualStyleBackColor = True
        '
        'BTN_exportar
        '
        Me.BTN_exportar.Location = New System.Drawing.Point(610, 239)
        Me.BTN_exportar.Name = "BTN_exportar"
        Me.BTN_exportar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_exportar.TabIndex = 17
        Me.BTN_exportar.Text = "Exportar"
        Me.BTN_exportar.UseVisualStyleBackColor = True
        '
        'FRM_articulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 327)
        Me.Controls.Add(Me.BTN_exportar)
        Me.Controls.Add(Me.BTN_guarda)
        Me.Controls.Add(Me.BTN_elimina)
        Me.Controls.Add(Me.BTN_limpia)
        Me.Controls.Add(Me.BTN_reporte)
        Me.Controls.Add(Me.BTN_salir)
        Me.Controls.Add(Me.BTN_nuevo)
        Me.Controls.Add(Me.DGV_articulo)
        Me.Controls.Add(Me.LBL_costo)
        Me.Controls.Add(Me.LBL_precio)
        Me.Controls.Add(Me.LBL_descripcion)
        Me.Controls.Add(Me.LBL_codigo)
        Me.Controls.Add(Me.LBL_id)
        Me.Controls.Add(Me.TXT_codigo)
        Me.Controls.Add(Me.TXT_precio)
        Me.Controls.Add(Me.TXT_costo)
        Me.Controls.Add(Me.TXT_descripcion)
        Me.Controls.Add(Me.TXT_id)
        Me.Name = "FRM_articulo"
        Me.Text = "FRM_articulo"
        CType(Me.DGV_articulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_id As System.Windows.Forms.TextBox
    Friend WithEvents TXT_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents TXT_costo As System.Windows.Forms.TextBox
    Friend WithEvents TXT_precio As System.Windows.Forms.TextBox
    Friend WithEvents TXT_codigo As System.Windows.Forms.TextBox
    Friend WithEvents LBL_id As System.Windows.Forms.Label
    Friend WithEvents LBL_codigo As System.Windows.Forms.Label
    Friend WithEvents LBL_descripcion As System.Windows.Forms.Label
    Friend WithEvents LBL_precio As System.Windows.Forms.Label
    Friend WithEvents LBL_costo As System.Windows.Forms.Label
    Friend WithEvents DGV_articulo As System.Windows.Forms.DataGridView
    Friend WithEvents BTN_guarda As System.Windows.Forms.Button
    Friend WithEvents BTN_elimina As System.Windows.Forms.Button
    Friend WithEvents BTN_limpia As System.Windows.Forms.Button
    Friend WithEvents BTN_reporte As System.Windows.Forms.Button
    Friend WithEvents BTN_salir As System.Windows.Forms.Button
    Friend WithEvents BTN_nuevo As System.Windows.Forms.Button
    Friend WithEvents BTN_exportar As System.Windows.Forms.Button
End Class
