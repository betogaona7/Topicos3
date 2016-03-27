<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_ordencompra
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
        Me.TXT_orden = New System.Windows.Forms.TextBox()
        Me.TXT_id = New System.Windows.Forms.TextBox()
        Me.LBL_orden = New System.Windows.Forms.Label()
        Me.LBL_id = New System.Windows.Forms.Label()
        Me.BTN_salir = New System.Windows.Forms.Button()
        Me.BTN_exportar = New System.Windows.Forms.Button()
        Me.BTN_reporte = New System.Windows.Forms.Button()
        Me.BTN_limpiar = New System.Windows.Forms.Button()
        Me.BTN_eliminar = New System.Windows.Forms.Button()
        Me.BTN_guardar = New System.Windows.Forms.Button()
        Me.BTN_nuevo = New System.Windows.Forms.Button()
        Me.DGV_orden = New System.Windows.Forms.DataGridView()
        CType(Me.DGV_orden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_orden
        '
        Me.TXT_orden.Location = New System.Drawing.Point(189, 51)
        Me.TXT_orden.MaxLength = 149
        Me.TXT_orden.Name = "TXT_orden"
        Me.TXT_orden.Size = New System.Drawing.Size(218, 20)
        Me.TXT_orden.TabIndex = 41
        '
        'TXT_id
        '
        Me.TXT_id.Location = New System.Drawing.Point(43, 51)
        Me.TXT_id.Name = "TXT_id"
        Me.TXT_id.Size = New System.Drawing.Size(100, 20)
        Me.TXT_id.TabIndex = 40
        '
        'LBL_orden
        '
        Me.LBL_orden.AutoSize = True
        Me.LBL_orden.Location = New System.Drawing.Point(186, 35)
        Me.LBL_orden.Name = "LBL_orden"
        Me.LBL_orden.Size = New System.Drawing.Size(89, 13)
        Me.LBL_orden.TabIndex = 43
        Me.LBL_orden.Text = "Orden de compra"
        '
        'LBL_id
        '
        Me.LBL_id.AutoSize = True
        Me.LBL_id.Location = New System.Drawing.Point(40, 35)
        Me.LBL_id.Name = "LBL_id"
        Me.LBL_id.Size = New System.Drawing.Size(18, 13)
        Me.LBL_id.TabIndex = 42
        Me.LBL_id.Text = "ID"
        '
        'BTN_salir
        '
        Me.BTN_salir.BackColor = System.Drawing.Color.DimGray
        Me.BTN_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_salir.Location = New System.Drawing.Point(639, 333)
        Me.BTN_salir.Name = "BTN_salir"
        Me.BTN_salir.Size = New System.Drawing.Size(75, 23)
        Me.BTN_salir.TabIndex = 39
        Me.BTN_salir.Text = "&Salir"
        Me.BTN_salir.UseVisualStyleBackColor = False
        '
        'BTN_exportar
        '
        Me.BTN_exportar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_exportar.Location = New System.Drawing.Point(639, 265)
        Me.BTN_exportar.Name = "BTN_exportar"
        Me.BTN_exportar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_exportar.TabIndex = 38
        Me.BTN_exportar.Text = "&Exportar"
        Me.BTN_exportar.UseVisualStyleBackColor = True
        '
        'BTN_reporte
        '
        Me.BTN_reporte.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_reporte.Location = New System.Drawing.Point(639, 236)
        Me.BTN_reporte.Name = "BTN_reporte"
        Me.BTN_reporte.Size = New System.Drawing.Size(75, 23)
        Me.BTN_reporte.TabIndex = 37
        Me.BTN_reporte.Text = "&Reporte"
        Me.BTN_reporte.UseVisualStyleBackColor = True
        '
        'BTN_limpiar
        '
        Me.BTN_limpiar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_limpiar.Location = New System.Drawing.Point(639, 207)
        Me.BTN_limpiar.Name = "BTN_limpiar"
        Me.BTN_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_limpiar.TabIndex = 36
        Me.BTN_limpiar.Text = "&Limpiar"
        Me.BTN_limpiar.UseVisualStyleBackColor = True
        '
        'BTN_eliminar
        '
        Me.BTN_eliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_eliminar.Location = New System.Drawing.Point(639, 178)
        Me.BTN_eliminar.Name = "BTN_eliminar"
        Me.BTN_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_eliminar.TabIndex = 35
        Me.BTN_eliminar.Text = "&Eliminar"
        Me.BTN_eliminar.UseVisualStyleBackColor = True
        '
        'BTN_guardar
        '
        Me.BTN_guardar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_guardar.Location = New System.Drawing.Point(639, 149)
        Me.BTN_guardar.Name = "BTN_guardar"
        Me.BTN_guardar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_guardar.TabIndex = 34
        Me.BTN_guardar.Text = "&Guardar"
        Me.BTN_guardar.UseVisualStyleBackColor = True
        '
        'BTN_nuevo
        '
        Me.BTN_nuevo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_nuevo.Location = New System.Drawing.Point(639, 120)
        Me.BTN_nuevo.Name = "BTN_nuevo"
        Me.BTN_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.BTN_nuevo.TabIndex = 33
        Me.BTN_nuevo.Text = "&Nuevo"
        Me.BTN_nuevo.UseVisualStyleBackColor = True
        '
        'DGV_orden
        '
        Me.DGV_orden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_orden.Location = New System.Drawing.Point(43, 88)
        Me.DGV_orden.Name = "DGV_orden"
        Me.DGV_orden.Size = New System.Drawing.Size(569, 268)
        Me.DGV_orden.TabIndex = 32
        '
        'FRM_ordencompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(754, 390)
        Me.Controls.Add(Me.TXT_orden)
        Me.Controls.Add(Me.TXT_id)
        Me.Controls.Add(Me.LBL_orden)
        Me.Controls.Add(Me.LBL_id)
        Me.Controls.Add(Me.BTN_salir)
        Me.Controls.Add(Me.BTN_exportar)
        Me.Controls.Add(Me.BTN_reporte)
        Me.Controls.Add(Me.BTN_limpiar)
        Me.Controls.Add(Me.BTN_eliminar)
        Me.Controls.Add(Me.BTN_guardar)
        Me.Controls.Add(Me.BTN_nuevo)
        Me.Controls.Add(Me.DGV_orden)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_ordencompra"
        Me.Text = "Orden de Compra"
        CType(Me.DGV_orden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_orden As System.Windows.Forms.TextBox
    Friend WithEvents TXT_id As System.Windows.Forms.TextBox
    Friend WithEvents LBL_orden As System.Windows.Forms.Label
    Friend WithEvents LBL_id As System.Windows.Forms.Label
    Friend WithEvents BTN_salir As System.Windows.Forms.Button
    Friend WithEvents BTN_exportar As System.Windows.Forms.Button
    Friend WithEvents BTN_reporte As System.Windows.Forms.Button
    Friend WithEvents BTN_limpiar As System.Windows.Forms.Button
    Friend WithEvents BTN_eliminar As System.Windows.Forms.Button
    Friend WithEvents BTN_guardar As System.Windows.Forms.Button
    Friend WithEvents BTN_nuevo As System.Windows.Forms.Button
    Friend WithEvents DGV_orden As System.Windows.Forms.DataGridView
End Class
