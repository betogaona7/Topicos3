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
        Me.TXT_id = New System.Windows.Forms.TextBox()
        Me.TXT_calle = New System.Windows.Forms.TextBox()
        Me.TXT_rfc = New System.Windows.Forms.TextBox()
        Me.TXT_cp = New System.Windows.Forms.TextBox()
        Me.TXT_numero = New System.Windows.Forms.TextBox()
        Me.TXT_estado = New System.Windows.Forms.TextBox()
        Me.TXT_ciudad = New System.Windows.Forms.TextBox()
        Me.TXT_municipio = New System.Windows.Forms.TextBox()
        Me.TXT_colonia = New System.Windows.Forms.TextBox()
        Me.TXT_cliente = New System.Windows.Forms.TextBox()
        Me.LBL_id = New System.Windows.Forms.Label()
        Me.LBL_cliente = New System.Windows.Forms.Label()
        Me.LBL_ciudad = New System.Windows.Forms.Label()
        Me.LBL_numero = New System.Windows.Forms.Label()
        Me.LBL_municipio = New System.Windows.Forms.Label()
        Me.LBL_colonia = New System.Windows.Forms.Label()
        Me.LBL_calle = New System.Windows.Forms.Label()
        Me.LBL_rfc = New System.Windows.Forms.Label()
        Me.LBL_cp = New System.Windows.Forms.Label()
        Me.LBL_estado = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BTN_exportar = New System.Windows.Forms.Button()
        Me.BTN_guarda = New System.Windows.Forms.Button()
        Me.BTN_elimina = New System.Windows.Forms.Button()
        Me.BTN_limpia = New System.Windows.Forms.Button()
        Me.BTN_reporte = New System.Windows.Forms.Button()
        Me.BTN_salir = New System.Windows.Forms.Button()
        Me.BTN_nuevo = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_id
        '
        Me.TXT_id.Location = New System.Drawing.Point(31, 38)
        Me.TXT_id.Name = "TXT_id"
        Me.TXT_id.Size = New System.Drawing.Size(77, 20)
        Me.TXT_id.TabIndex = 0
        '
        'TXT_calle
        '
        Me.TXT_calle.Location = New System.Drawing.Point(127, 64)
        Me.TXT_calle.Name = "TXT_calle"
        Me.TXT_calle.Size = New System.Drawing.Size(263, 20)
        Me.TXT_calle.TabIndex = 1
        '
        'TXT_rfc
        '
        Me.TXT_rfc.Location = New System.Drawing.Point(416, 38)
        Me.TXT_rfc.Name = "TXT_rfc"
        Me.TXT_rfc.Size = New System.Drawing.Size(100, 20)
        Me.TXT_rfc.TabIndex = 2
        '
        'TXT_cp
        '
        Me.TXT_cp.Location = New System.Drawing.Point(585, 64)
        Me.TXT_cp.Name = "TXT_cp"
        Me.TXT_cp.Size = New System.Drawing.Size(72, 20)
        Me.TXT_cp.TabIndex = 3
        '
        'TXT_numero
        '
        Me.TXT_numero.Location = New System.Drawing.Point(457, 64)
        Me.TXT_numero.Name = "TXT_numero"
        Me.TXT_numero.Size = New System.Drawing.Size(74, 20)
        Me.TXT_numero.TabIndex = 4
        '
        'TXT_estado
        '
        Me.TXT_estado.Location = New System.Drawing.Point(457, 116)
        Me.TXT_estado.Name = "TXT_estado"
        Me.TXT_estado.Size = New System.Drawing.Size(200, 20)
        Me.TXT_estado.TabIndex = 5
        '
        'TXT_ciudad
        '
        Me.TXT_ciudad.Location = New System.Drawing.Point(457, 90)
        Me.TXT_ciudad.Name = "TXT_ciudad"
        Me.TXT_ciudad.Size = New System.Drawing.Size(200, 20)
        Me.TXT_ciudad.TabIndex = 6
        '
        'TXT_municipio
        '
        Me.TXT_municipio.Location = New System.Drawing.Point(127, 116)
        Me.TXT_municipio.Name = "TXT_municipio"
        Me.TXT_municipio.Size = New System.Drawing.Size(185, 20)
        Me.TXT_municipio.TabIndex = 7
        '
        'TXT_colonia
        '
        Me.TXT_colonia.Location = New System.Drawing.Point(127, 90)
        Me.TXT_colonia.Name = "TXT_colonia"
        Me.TXT_colonia.Size = New System.Drawing.Size(263, 20)
        Me.TXT_colonia.TabIndex = 8
        '
        'TXT_cliente
        '
        Me.TXT_cliente.Location = New System.Drawing.Point(127, 38)
        Me.TXT_cliente.Name = "TXT_cliente"
        Me.TXT_cliente.Size = New System.Drawing.Size(263, 20)
        Me.TXT_cliente.TabIndex = 9
        '
        'LBL_id
        '
        Me.LBL_id.AutoSize = True
        Me.LBL_id.Location = New System.Drawing.Point(28, 22)
        Me.LBL_id.Name = "LBL_id"
        Me.LBL_id.Size = New System.Drawing.Size(18, 13)
        Me.LBL_id.TabIndex = 10
        Me.LBL_id.Text = "ID"
        '
        'LBL_cliente
        '
        Me.LBL_cliente.AutoSize = True
        Me.LBL_cliente.Location = New System.Drawing.Point(124, 22)
        Me.LBL_cliente.Name = "LBL_cliente"
        Me.LBL_cliente.Size = New System.Drawing.Size(79, 13)
        Me.LBL_cliente.TabIndex = 11
        Me.LBL_cliente.Text = "Nombre Cliente"
        '
        'LBL_ciudad
        '
        Me.LBL_ciudad.AutoSize = True
        Me.LBL_ciudad.Location = New System.Drawing.Point(413, 93)
        Me.LBL_ciudad.Name = "LBL_ciudad"
        Me.LBL_ciudad.Size = New System.Drawing.Size(40, 13)
        Me.LBL_ciudad.TabIndex = 12
        Me.LBL_ciudad.Text = "Ciudad"
        '
        'LBL_numero
        '
        Me.LBL_numero.AutoSize = True
        Me.LBL_numero.Location = New System.Drawing.Point(413, 67)
        Me.LBL_numero.Name = "LBL_numero"
        Me.LBL_numero.Size = New System.Drawing.Size(44, 13)
        Me.LBL_numero.TabIndex = 13
        Me.LBL_numero.Text = "Numero"
        '
        'LBL_municipio
        '
        Me.LBL_municipio.AutoSize = True
        Me.LBL_municipio.Location = New System.Drawing.Point(69, 119)
        Me.LBL_municipio.Name = "LBL_municipio"
        Me.LBL_municipio.Size = New System.Drawing.Size(52, 13)
        Me.LBL_municipio.TabIndex = 14
        Me.LBL_municipio.Text = "Municipio"
        '
        'LBL_colonia
        '
        Me.LBL_colonia.AutoSize = True
        Me.LBL_colonia.Location = New System.Drawing.Point(69, 93)
        Me.LBL_colonia.Name = "LBL_colonia"
        Me.LBL_colonia.Size = New System.Drawing.Size(42, 13)
        Me.LBL_colonia.TabIndex = 15
        Me.LBL_colonia.Text = "Colonia"
        '
        'LBL_calle
        '
        Me.LBL_calle.AutoSize = True
        Me.LBL_calle.Location = New System.Drawing.Point(69, 67)
        Me.LBL_calle.Name = "LBL_calle"
        Me.LBL_calle.Size = New System.Drawing.Size(30, 13)
        Me.LBL_calle.TabIndex = 16
        Me.LBL_calle.Text = "Calle"
        '
        'LBL_rfc
        '
        Me.LBL_rfc.AutoSize = True
        Me.LBL_rfc.Location = New System.Drawing.Point(413, 22)
        Me.LBL_rfc.Name = "LBL_rfc"
        Me.LBL_rfc.Size = New System.Drawing.Size(28, 13)
        Me.LBL_rfc.TabIndex = 17
        Me.LBL_rfc.Text = "RFC"
        '
        'LBL_cp
        '
        Me.LBL_cp.AutoSize = True
        Me.LBL_cp.Location = New System.Drawing.Point(558, 67)
        Me.LBL_cp.Name = "LBL_cp"
        Me.LBL_cp.Size = New System.Drawing.Size(21, 13)
        Me.LBL_cp.TabIndex = 18
        Me.LBL_cp.Text = "CP"
        '
        'LBL_estado
        '
        Me.LBL_estado.AutoSize = True
        Me.LBL_estado.Location = New System.Drawing.Point(413, 119)
        Me.LBL_estado.Name = "LBL_estado"
        Me.LBL_estado.Size = New System.Drawing.Size(40, 13)
        Me.LBL_estado.TabIndex = 19
        Me.LBL_estado.Text = "Estado"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(31, 153)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(626, 244)
        Me.DataGridView1.TabIndex = 20
        '
        'BTN_exportar
        '
        Me.BTN_exportar.Location = New System.Drawing.Point(689, 269)
        Me.BTN_exportar.Name = "BTN_exportar"
        Me.BTN_exportar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_exportar.TabIndex = 27
        Me.BTN_exportar.Text = "Exportar"
        Me.BTN_exportar.UseVisualStyleBackColor = True
        '
        'BTN_guarda
        '
        Me.BTN_guarda.Location = New System.Drawing.Point(690, 153)
        Me.BTN_guarda.Name = "BTN_guarda"
        Me.BTN_guarda.Size = New System.Drawing.Size(75, 23)
        Me.BTN_guarda.TabIndex = 26
        Me.BTN_guarda.Text = "Guarda"
        Me.BTN_guarda.UseVisualStyleBackColor = True
        '
        'BTN_elimina
        '
        Me.BTN_elimina.Location = New System.Drawing.Point(690, 182)
        Me.BTN_elimina.Name = "BTN_elimina"
        Me.BTN_elimina.Size = New System.Drawing.Size(75, 23)
        Me.BTN_elimina.TabIndex = 25
        Me.BTN_elimina.Text = "Elimina"
        Me.BTN_elimina.UseVisualStyleBackColor = True
        '
        'BTN_limpia
        '
        Me.BTN_limpia.Location = New System.Drawing.Point(689, 211)
        Me.BTN_limpia.Name = "BTN_limpia"
        Me.BTN_limpia.Size = New System.Drawing.Size(75, 23)
        Me.BTN_limpia.TabIndex = 24
        Me.BTN_limpia.Text = "Limpia"
        Me.BTN_limpia.UseVisualStyleBackColor = True
        '
        'BTN_reporte
        '
        Me.BTN_reporte.Location = New System.Drawing.Point(690, 240)
        Me.BTN_reporte.Name = "BTN_reporte"
        Me.BTN_reporte.Size = New System.Drawing.Size(75, 23)
        Me.BTN_reporte.TabIndex = 23
        Me.BTN_reporte.Text = "Reporte"
        Me.BTN_reporte.UseVisualStyleBackColor = True
        '
        'BTN_salir
        '
        Me.BTN_salir.Location = New System.Drawing.Point(690, 315)
        Me.BTN_salir.Name = "BTN_salir"
        Me.BTN_salir.Size = New System.Drawing.Size(75, 23)
        Me.BTN_salir.TabIndex = 22
        Me.BTN_salir.Text = "Salir "
        Me.BTN_salir.UseVisualStyleBackColor = True
        '
        'BTN_nuevo
        '
        Me.BTN_nuevo.Location = New System.Drawing.Point(690, 109)
        Me.BTN_nuevo.Name = "BTN_nuevo"
        Me.BTN_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.BTN_nuevo.TabIndex = 21
        Me.BTN_nuevo.Text = "Nuevo"
        Me.BTN_nuevo.UseVisualStyleBackColor = True
        '
        'FRM_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 418)
        Me.Controls.Add(Me.BTN_exportar)
        Me.Controls.Add(Me.BTN_guarda)
        Me.Controls.Add(Me.BTN_elimina)
        Me.Controls.Add(Me.BTN_limpia)
        Me.Controls.Add(Me.BTN_reporte)
        Me.Controls.Add(Me.BTN_salir)
        Me.Controls.Add(Me.BTN_nuevo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LBL_estado)
        Me.Controls.Add(Me.LBL_cp)
        Me.Controls.Add(Me.LBL_rfc)
        Me.Controls.Add(Me.LBL_calle)
        Me.Controls.Add(Me.LBL_colonia)
        Me.Controls.Add(Me.LBL_municipio)
        Me.Controls.Add(Me.LBL_numero)
        Me.Controls.Add(Me.LBL_ciudad)
        Me.Controls.Add(Me.LBL_cliente)
        Me.Controls.Add(Me.LBL_id)
        Me.Controls.Add(Me.TXT_cliente)
        Me.Controls.Add(Me.TXT_colonia)
        Me.Controls.Add(Me.TXT_municipio)
        Me.Controls.Add(Me.TXT_ciudad)
        Me.Controls.Add(Me.TXT_estado)
        Me.Controls.Add(Me.TXT_numero)
        Me.Controls.Add(Me.TXT_cp)
        Me.Controls.Add(Me.TXT_rfc)
        Me.Controls.Add(Me.TXT_calle)
        Me.Controls.Add(Me.TXT_id)
        Me.Name = "FRM_cliente"
        Me.Text = "FRM_cliente"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_id As System.Windows.Forms.TextBox
    Friend WithEvents TXT_calle As System.Windows.Forms.TextBox
    Friend WithEvents TXT_rfc As System.Windows.Forms.TextBox
    Friend WithEvents TXT_cp As System.Windows.Forms.TextBox
    Friend WithEvents TXT_numero As System.Windows.Forms.TextBox
    Friend WithEvents TXT_estado As System.Windows.Forms.TextBox
    Friend WithEvents TXT_ciudad As System.Windows.Forms.TextBox
    Friend WithEvents TXT_municipio As System.Windows.Forms.TextBox
    Friend WithEvents TXT_colonia As System.Windows.Forms.TextBox
    Friend WithEvents TXT_cliente As System.Windows.Forms.TextBox
    Friend WithEvents LBL_id As System.Windows.Forms.Label
    Friend WithEvents LBL_cliente As System.Windows.Forms.Label
    Friend WithEvents LBL_ciudad As System.Windows.Forms.Label
    Friend WithEvents LBL_numero As System.Windows.Forms.Label
    Friend WithEvents LBL_municipio As System.Windows.Forms.Label
    Friend WithEvents LBL_colonia As System.Windows.Forms.Label
    Friend WithEvents LBL_calle As System.Windows.Forms.Label
    Friend WithEvents LBL_rfc As System.Windows.Forms.Label
    Friend WithEvents LBL_cp As System.Windows.Forms.Label
    Friend WithEvents LBL_estado As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BTN_exportar As System.Windows.Forms.Button
    Friend WithEvents BTN_guarda As System.Windows.Forms.Button
    Friend WithEvents BTN_elimina As System.Windows.Forms.Button
    Friend WithEvents BTN_limpia As System.Windows.Forms.Button
    Friend WithEvents BTN_reporte As System.Windows.Forms.Button
    Friend WithEvents BTN_salir As System.Windows.Forms.Button
    Friend WithEvents BTN_nuevo As System.Windows.Forms.Button
End Class
