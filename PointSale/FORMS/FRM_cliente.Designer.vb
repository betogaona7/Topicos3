<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_cliente
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BTN_salir = New System.Windows.Forms.Button()
        Me.BTN_exportar = New System.Windows.Forms.Button()
        Me.BTN_reporte = New System.Windows.Forms.Button()
        Me.BTN_limpiar = New System.Windows.Forms.Button()
        Me.BTN_eliminar = New System.Windows.Forms.Button()
        Me.BTN_guardar = New System.Windows.Forms.Button()
        Me.BTN_nuevo = New System.Windows.Forms.Button()
        Me.TXT_cliente = New System.Windows.Forms.TextBox()
        Me.TXT_id = New System.Windows.Forms.TextBox()
        Me.LBL_cliente = New System.Windows.Forms.Label()
        Me.LBL_id = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(37, 96)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(569, 268)
        Me.DataGridView1.TabIndex = 0
        '
        'BTN_salir
        '
        Me.BTN_salir.BackColor = System.Drawing.Color.DimGray
        Me.BTN_salir.Location = New System.Drawing.Point(633, 341)
        Me.BTN_salir.Name = "BTN_salir"
        Me.BTN_salir.Size = New System.Drawing.Size(75, 23)
        Me.BTN_salir.TabIndex = 27
        Me.BTN_salir.Text = "&Salir"
        Me.BTN_salir.UseVisualStyleBackColor = False
        '
        'BTN_exportar
        '
        Me.BTN_exportar.Location = New System.Drawing.Point(633, 273)
        Me.BTN_exportar.Name = "BTN_exportar"
        Me.BTN_exportar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_exportar.TabIndex = 26
        Me.BTN_exportar.Text = "&Exportar"
        Me.BTN_exportar.UseVisualStyleBackColor = True
        '
        'BTN_reporte
        '
        Me.BTN_reporte.Location = New System.Drawing.Point(633, 244)
        Me.BTN_reporte.Name = "BTN_reporte"
        Me.BTN_reporte.Size = New System.Drawing.Size(75, 23)
        Me.BTN_reporte.TabIndex = 25
        Me.BTN_reporte.Text = "&Reporte"
        Me.BTN_reporte.UseVisualStyleBackColor = True
        '
        'BTN_limpiar
        '
        Me.BTN_limpiar.Location = New System.Drawing.Point(633, 215)
        Me.BTN_limpiar.Name = "BTN_limpiar"
        Me.BTN_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_limpiar.TabIndex = 24
        Me.BTN_limpiar.Text = "&Limpiar"
        Me.BTN_limpiar.UseVisualStyleBackColor = True
        '
        'BTN_eliminar
        '
        Me.BTN_eliminar.Location = New System.Drawing.Point(633, 186)
        Me.BTN_eliminar.Name = "BTN_eliminar"
        Me.BTN_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_eliminar.TabIndex = 23
        Me.BTN_eliminar.Text = "&Eliminar"
        Me.BTN_eliminar.UseVisualStyleBackColor = True
        '
        'BTN_guardar
        '
        Me.BTN_guardar.Location = New System.Drawing.Point(633, 157)
        Me.BTN_guardar.Name = "BTN_guardar"
        Me.BTN_guardar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_guardar.TabIndex = 22
        Me.BTN_guardar.Text = "&Guardar"
        Me.BTN_guardar.UseVisualStyleBackColor = True
        '
        'BTN_nuevo
        '
        Me.BTN_nuevo.Location = New System.Drawing.Point(633, 128)
        Me.BTN_nuevo.Name = "BTN_nuevo"
        Me.BTN_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.BTN_nuevo.TabIndex = 21
        Me.BTN_nuevo.Text = "&Nuevo"
        Me.BTN_nuevo.UseVisualStyleBackColor = True
        '
        'TXT_cliente
        '
        Me.TXT_cliente.Location = New System.Drawing.Point(183, 59)
        Me.TXT_cliente.MaxLength = 149
        Me.TXT_cliente.Name = "TXT_cliente"
        Me.TXT_cliente.Size = New System.Drawing.Size(218, 20)
        Me.TXT_cliente.TabIndex = 29
        '
        'TXT_id
        '
        Me.TXT_id.Location = New System.Drawing.Point(37, 59)
        Me.TXT_id.Name = "TXT_id"
        Me.TXT_id.Size = New System.Drawing.Size(100, 20)
        Me.TXT_id.TabIndex = 28
        '
        'LBL_cliente
        '
        Me.LBL_cliente.AutoSize = True
        Me.LBL_cliente.Location = New System.Drawing.Point(180, 43)
        Me.LBL_cliente.Name = "LBL_cliente"
        Me.LBL_cliente.Size = New System.Drawing.Size(39, 13)
        Me.LBL_cliente.TabIndex = 31
        Me.LBL_cliente.Text = "Cliente"
        '
        'LBL_id
        '
        Me.LBL_id.AutoSize = True
        Me.LBL_id.Location = New System.Drawing.Point(34, 43)
        Me.LBL_id.Name = "LBL_id"
        Me.LBL_id.Size = New System.Drawing.Size(18, 13)
        Me.LBL_id.TabIndex = 30
        Me.LBL_id.Text = "ID"
        '
        'FRM_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(754, 390)
        Me.Controls.Add(Me.TXT_cliente)
        Me.Controls.Add(Me.TXT_id)
        Me.Controls.Add(Me.LBL_cliente)
        Me.Controls.Add(Me.LBL_id)
        Me.Controls.Add(Me.BTN_salir)
        Me.Controls.Add(Me.BTN_exportar)
        Me.Controls.Add(Me.BTN_reporte)
        Me.Controls.Add(Me.BTN_limpiar)
        Me.Controls.Add(Me.BTN_eliminar)
        Me.Controls.Add(Me.BTN_guardar)
        Me.Controls.Add(Me.BTN_nuevo)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_cliente"
        Me.Text = "Cliente"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BTN_salir As System.Windows.Forms.Button
    Friend WithEvents BTN_exportar As System.Windows.Forms.Button
    Friend WithEvents BTN_reporte As System.Windows.Forms.Button
    Friend WithEvents BTN_limpiar As System.Windows.Forms.Button
    Friend WithEvents BTN_eliminar As System.Windows.Forms.Button
    Friend WithEvents BTN_guardar As System.Windows.Forms.Button
    Friend WithEvents BTN_nuevo As System.Windows.Forms.Button
    Friend WithEvents TXT_cliente As System.Windows.Forms.TextBox
    Friend WithEvents TXT_id As System.Windows.Forms.TextBox
    Friend WithEvents LBL_cliente As System.Windows.Forms.Label
    Friend WithEvents LBL_id As System.Windows.Forms.Label
End Class
