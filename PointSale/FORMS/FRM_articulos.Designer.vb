﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.TXT_codigo.Location = New System.Drawing.Point(114, 65)
        Me.TXT_codigo.MaxLength = 10
        Me.TXT_codigo.Name = "TXT_codigo"
        Me.TXT_codigo.Size = New System.Drawing.Size(78, 20)
        Me.TXT_codigo.TabIndex = 1
        '
        'TXT_id
        '
        Me.TXT_id.Location = New System.Drawing.Point(114, 21)
        Me.TXT_id.Name = "TXT_id"
        Me.TXT_id.Size = New System.Drawing.Size(78, 20)
        Me.TXT_id.TabIndex = 0
        '
        'LBL_codigo
        '
        Me.LBL_codigo.AutoSize = True
        Me.LBL_codigo.Location = New System.Drawing.Point(68, 68)
        Me.LBL_codigo.Name = "LBL_codigo"
        Me.LBL_codigo.Size = New System.Drawing.Size(43, 13)
        Me.LBL_codigo.TabIndex = 7
        Me.LBL_codigo.Text = "Codigo:"
        '
        'LBL_id
        '
        Me.LBL_id.AutoSize = True
        Me.LBL_id.Location = New System.Drawing.Point(68, 24)
        Me.LBL_id.Name = "LBL_id"
        Me.LBL_id.Size = New System.Drawing.Size(21, 13)
        Me.LBL_id.TabIndex = 6
        Me.LBL_id.Text = "ID:"
        '
        'BTN_salir
        '
        Me.BTN_salir.BackColor = System.Drawing.Color.DimGray
        Me.BTN_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_salir.Location = New System.Drawing.Point(821, 414)
        Me.BTN_salir.Name = "BTN_salir"
        Me.BTN_salir.Size = New System.Drawing.Size(75, 23)
        Me.BTN_salir.TabIndex = 16
        Me.BTN_salir.Text = "&Salir"
        Me.BTN_salir.UseVisualStyleBackColor = False
        '
        'BTN_reporte
        '
        Me.BTN_reporte.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_reporte.Location = New System.Drawing.Point(821, 317)
        Me.BTN_reporte.Name = "BTN_reporte"
        Me.BTN_reporte.Size = New System.Drawing.Size(75, 23)
        Me.BTN_reporte.TabIndex = 15
        Me.BTN_reporte.Text = "&Reporte"
        Me.BTN_reporte.UseVisualStyleBackColor = True
        '
        'BTN_limpiar
        '
        Me.BTN_limpiar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_limpiar.Location = New System.Drawing.Point(821, 288)
        Me.BTN_limpiar.Name = "BTN_limpiar"
        Me.BTN_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_limpiar.TabIndex = 14
        Me.BTN_limpiar.Text = "&Limpiar"
        Me.BTN_limpiar.UseVisualStyleBackColor = True
        '
        'BTN_eliminar
        '
        Me.BTN_eliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_eliminar.Location = New System.Drawing.Point(821, 259)
        Me.BTN_eliminar.Name = "BTN_eliminar"
        Me.BTN_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_eliminar.TabIndex = 13
        Me.BTN_eliminar.Text = "&Eliminar"
        Me.BTN_eliminar.UseVisualStyleBackColor = True
        '
        'BTN_guardar
        '
        Me.BTN_guardar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_guardar.Location = New System.Drawing.Point(821, 230)
        Me.BTN_guardar.Name = "BTN_guardar"
        Me.BTN_guardar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_guardar.TabIndex = 12
        Me.BTN_guardar.Text = "&Guardar"
        Me.BTN_guardar.UseVisualStyleBackColor = True
        '
        'BTN_nuevo
        '
        Me.BTN_nuevo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_nuevo.Location = New System.Drawing.Point(821, 201)
        Me.BTN_nuevo.Name = "BTN_nuevo"
        Me.BTN_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.BTN_nuevo.TabIndex = 11
        Me.BTN_nuevo.Text = "&Nuevo"
        Me.BTN_nuevo.UseVisualStyleBackColor = True
        '
        'DGV_articulo
        '
        Me.DGV_articulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_articulo.Location = New System.Drawing.Point(59, 191)
        Me.DGV_articulo.Name = "DGV_articulo"
        Me.DGV_articulo.Size = New System.Drawing.Size(726, 268)
        Me.DGV_articulo.TabIndex = 5
        '
        'LBL_precio
        '
        Me.LBL_precio.AutoSize = True
        Me.LBL_precio.Location = New System.Drawing.Point(68, 97)
        Me.LBL_precio.Name = "LBL_precio"
        Me.LBL_precio.Size = New System.Drawing.Size(40, 13)
        Me.LBL_precio.TabIndex = 8
        Me.LBL_precio.Text = "Precio:"
        '
        'LBL_descripcion
        '
        Me.LBL_descripcion.AutoSize = True
        Me.LBL_descripcion.Location = New System.Drawing.Point(277, 68)
        Me.LBL_descripcion.Name = "LBL_descripcion"
        Me.LBL_descripcion.Size = New System.Drawing.Size(66, 13)
        Me.LBL_descripcion.TabIndex = 9
        Me.LBL_descripcion.Text = "Descripcion:"
        '
        'TXT_descripcion
        '
        Me.TXT_descripcion.Location = New System.Drawing.Point(349, 65)
        Me.TXT_descripcion.MaxLength = 100
        Me.TXT_descripcion.Name = "TXT_descripcion"
        Me.TXT_descripcion.Size = New System.Drawing.Size(436, 20)
        Me.TXT_descripcion.TabIndex = 2
        '
        'TXT_precio
        '
        Me.TXT_precio.Location = New System.Drawing.Point(114, 94)
        Me.TXT_precio.MaxLength = 149
        Me.TXT_precio.Name = "TXT_precio"
        Me.TXT_precio.Size = New System.Drawing.Size(78, 20)
        Me.TXT_precio.TabIndex = 3
        '
        'LBL_costo
        '
        Me.LBL_costo.AutoSize = True
        Me.LBL_costo.Location = New System.Drawing.Point(277, 101)
        Me.LBL_costo.Name = "LBL_costo"
        Me.LBL_costo.Size = New System.Drawing.Size(37, 13)
        Me.LBL_costo.TabIndex = 10
        Me.LBL_costo.Text = "Costo:"
        '
        'TXT_costo
        '
        Me.TXT_costo.Location = New System.Drawing.Point(349, 94)
        Me.TXT_costo.MaxLength = 149
        Me.TXT_costo.Name = "TXT_costo"
        Me.TXT_costo.Size = New System.Drawing.Size(103, 20)
        Me.TXT_costo.TabIndex = 4
        '
        'FRM_articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SpringGreen
        Me.ClientSize = New System.Drawing.Size(984, 471)
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
        Me.Controls.Add(Me.BTN_reporte)
        Me.Controls.Add(Me.BTN_limpiar)
        Me.Controls.Add(Me.BTN_eliminar)
        Me.Controls.Add(Me.BTN_guardar)
        Me.Controls.Add(Me.BTN_nuevo)
        Me.Controls.Add(Me.DGV_articulo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_articulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
