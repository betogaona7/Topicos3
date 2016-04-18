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
        Me.BTN_salir = New System.Windows.Forms.Button()
        Me.BTN_exportar = New System.Windows.Forms.Button()
        Me.BTN_reporte = New System.Windows.Forms.Button()
        Me.BTN_limpiar = New System.Windows.Forms.Button()
        Me.BTN_eliminar = New System.Windows.Forms.Button()
        Me.BTN_guardar = New System.Windows.Forms.Button()
        Me.BTN_nuevo = New System.Windows.Forms.Button()
        Me.gpbCliente = New System.Windows.Forms.GroupBox()
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblCiudad = New System.Windows.Forms.Label()
        Me.lblRFC = New System.Windows.Forms.Label()
        Me.lblCP = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.TXT_nombre = New System.Windows.Forms.TextBox()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.lblColonia = New System.Windows.Forms.Label()
        Me.lblMunicipio = New System.Windows.Forms.Label()
        Me.TXT_rfc = New System.Windows.Forms.TextBox()
        Me.TXT_cp = New System.Windows.Forms.TextBox()
        Me.TXT_ciudad = New System.Windows.Forms.TextBox()
        Me.TXT_estado = New System.Windows.Forms.TextBox()
        Me.TXT_numero = New System.Windows.Forms.TextBox()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.TXT_colonia = New System.Windows.Forms.TextBox()
        Me.TXT_calle = New System.Windows.Forms.TextBox()
        Me.TXT_id = New System.Windows.Forms.TextBox()
        Me.DGV_orden = New System.Windows.Forms.DataGridView()
        Me.TXT_municipio = New System.Windows.Forms.TextBox()
        Me.gpbCliente.SuspendLayout()
        CType(Me.DGV_orden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_salir
        '
        Me.BTN_salir.BackColor = System.Drawing.Color.DimGray
        Me.BTN_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_salir.Location = New System.Drawing.Point(696, 395)
        Me.BTN_salir.Name = "BTN_salir"
        Me.BTN_salir.Size = New System.Drawing.Size(75, 23)
        Me.BTN_salir.TabIndex = 39
        Me.BTN_salir.Text = "&Salir"
        Me.BTN_salir.UseVisualStyleBackColor = False
        '
        'BTN_exportar
        '
        Me.BTN_exportar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_exportar.Location = New System.Drawing.Point(696, 327)
        Me.BTN_exportar.Name = "BTN_exportar"
        Me.BTN_exportar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_exportar.TabIndex = 38
        Me.BTN_exportar.Text = "&Exportar"
        Me.BTN_exportar.UseVisualStyleBackColor = True
        '
        'BTN_reporte
        '
        Me.BTN_reporte.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_reporte.Location = New System.Drawing.Point(696, 298)
        Me.BTN_reporte.Name = "BTN_reporte"
        Me.BTN_reporte.Size = New System.Drawing.Size(75, 23)
        Me.BTN_reporte.TabIndex = 37
        Me.BTN_reporte.Text = "&Reporte"
        Me.BTN_reporte.UseVisualStyleBackColor = True
        '
        'BTN_limpiar
        '
        Me.BTN_limpiar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_limpiar.Location = New System.Drawing.Point(696, 269)
        Me.BTN_limpiar.Name = "BTN_limpiar"
        Me.BTN_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_limpiar.TabIndex = 36
        Me.BTN_limpiar.Text = "&Limpiar"
        Me.BTN_limpiar.UseVisualStyleBackColor = True
        '
        'BTN_eliminar
        '
        Me.BTN_eliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_eliminar.Location = New System.Drawing.Point(696, 240)
        Me.BTN_eliminar.Name = "BTN_eliminar"
        Me.BTN_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_eliminar.TabIndex = 35
        Me.BTN_eliminar.Text = "&Eliminar"
        Me.BTN_eliminar.UseVisualStyleBackColor = True
        '
        'BTN_guardar
        '
        Me.BTN_guardar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_guardar.Location = New System.Drawing.Point(696, 211)
        Me.BTN_guardar.Name = "BTN_guardar"
        Me.BTN_guardar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_guardar.TabIndex = 34
        Me.BTN_guardar.Text = "&Guardar"
        Me.BTN_guardar.UseVisualStyleBackColor = True
        '
        'BTN_nuevo
        '
        Me.BTN_nuevo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_nuevo.Location = New System.Drawing.Point(696, 182)
        Me.BTN_nuevo.Name = "BTN_nuevo"
        Me.BTN_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.BTN_nuevo.TabIndex = 33
        Me.BTN_nuevo.Text = "&Nuevo"
        Me.BTN_nuevo.UseVisualStyleBackColor = True
        '
        'gpbCliente
        '
        Me.gpbCliente.BackColor = System.Drawing.Color.Transparent
        Me.gpbCliente.Controls.Add(Me.TXT_municipio)
        Me.gpbCliente.Controls.Add(Me.lblNombreCliente)
        Me.gpbCliente.Controls.Add(Me.lblEstado)
        Me.gpbCliente.Controls.Add(Me.lblCiudad)
        Me.gpbCliente.Controls.Add(Me.lblRFC)
        Me.gpbCliente.Controls.Add(Me.lblCP)
        Me.gpbCliente.Controls.Add(Me.lblNumero)
        Me.gpbCliente.Controls.Add(Me.lblId)
        Me.gpbCliente.Controls.Add(Me.TXT_nombre)
        Me.gpbCliente.Controls.Add(Me.lblCalle)
        Me.gpbCliente.Controls.Add(Me.lblColonia)
        Me.gpbCliente.Controls.Add(Me.lblMunicipio)
        Me.gpbCliente.Controls.Add(Me.TXT_rfc)
        Me.gpbCliente.Controls.Add(Me.TXT_cp)
        Me.gpbCliente.Controls.Add(Me.TXT_ciudad)
        Me.gpbCliente.Controls.Add(Me.TXT_estado)
        Me.gpbCliente.Controls.Add(Me.TXT_numero)
        Me.gpbCliente.Controls.Add(Me.TXT_colonia)
        Me.gpbCliente.Controls.Add(Me.TXT_calle)
        Me.gpbCliente.Controls.Add(Me.TXT_id)
        Me.gpbCliente.Location = New System.Drawing.Point(42, 12)
        Me.gpbCliente.Name = "gpbCliente"
        Me.gpbCliente.Size = New System.Drawing.Size(743, 142)
        Me.gpbCliente.TabIndex = 40
        Me.gpbCliente.TabStop = False
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCliente.Location = New System.Drawing.Point(121, 15)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(101, 16)
        Me.lblNombreCliente.TabIndex = 11
        Me.lblNombreCliente.Text = "Nombre Cliente"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(417, 83)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(51, 16)
        Me.lblEstado.TabIndex = 19
        Me.lblEstado.Text = "Estado"
        '
        'lblCiudad
        '
        Me.lblCiudad.AutoSize = True
        Me.lblCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCiudad.Location = New System.Drawing.Point(3, 108)
        Me.lblCiudad.Name = "lblCiudad"
        Me.lblCiudad.Size = New System.Drawing.Size(51, 16)
        Me.lblCiudad.TabIndex = 17
        Me.lblCiudad.Text = "Ciudad"
        '
        'lblRFC
        '
        Me.lblRFC.AutoSize = True
        Me.lblRFC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRFC.Location = New System.Drawing.Point(586, 16)
        Me.lblRFC.Name = "lblRFC"
        Me.lblRFC.Size = New System.Drawing.Size(35, 16)
        Me.lblRFC.TabIndex = 12
        Me.lblRFC.Text = "RFC"
        '
        'lblCP
        '
        Me.lblCP.AutoSize = True
        Me.lblCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCP.Location = New System.Drawing.Point(592, 50)
        Me.lblCP.Name = "lblCP"
        Me.lblCP.Size = New System.Drawing.Size(29, 16)
        Me.lblCP.TabIndex = 15
        Me.lblCP.Text = "C.P"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.Location = New System.Drawing.Point(417, 50)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(56, 16)
        Me.lblNumero.TabIndex = 14
        Me.lblNumero.Text = "Numero"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(6, 16)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(21, 16)
        Me.lblId.TabIndex = 10
        Me.lblId.Text = "ID"
        '
        'TXT_nombre
        '
        Me.TXT_nombre.Location = New System.Drawing.Point(228, 15)
        Me.TXT_nombre.MaxLength = 100
        Me.TXT_nombre.Name = "TXT_nombre"
        Me.TXT_nombre.Size = New System.Drawing.Size(344, 20)
        Me.TXT_nombre.TabIndex = 1
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalle.Location = New System.Drawing.Point(6, 47)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(39, 16)
        Me.lblCalle.TabIndex = 13
        Me.lblCalle.Text = "Calle"
        '
        'lblColonia
        '
        Me.lblColonia.AutoSize = True
        Me.lblColonia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColonia.Location = New System.Drawing.Point(3, 80)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(54, 16)
        Me.lblColonia.TabIndex = 16
        Me.lblColonia.Text = "Colonia"
        '
        'lblMunicipio
        '
        Me.lblMunicipio.AutoSize = True
        Me.lblMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMunicipio.Location = New System.Drawing.Point(417, 108)
        Me.lblMunicipio.Name = "lblMunicipio"
        Me.lblMunicipio.Size = New System.Drawing.Size(65, 16)
        Me.lblMunicipio.TabIndex = 18
        Me.lblMunicipio.Text = "Municipio"
        '
        'TXT_rfc
        '
        Me.TXT_rfc.Location = New System.Drawing.Point(627, 16)
        Me.TXT_rfc.MaxLength = 15
        Me.TXT_rfc.Name = "TXT_rfc"
        Me.TXT_rfc.Size = New System.Drawing.Size(78, 20)
        Me.TXT_rfc.TabIndex = 2
        '
        'TXT_cp
        '
        Me.TXT_cp.Location = New System.Drawing.Point(627, 49)
        Me.TXT_cp.MaxLength = 6
        Me.TXT_cp.Name = "TXT_cp"
        Me.TXT_cp.Size = New System.Drawing.Size(78, 20)
        Me.TXT_cp.TabIndex = 5
        '
        'TXT_ciudad
        '
        Me.TXT_ciudad.Location = New System.Drawing.Point(60, 107)
        Me.TXT_ciudad.MaxLength = 50
        Me.TXT_ciudad.Name = "TXT_ciudad"
        Me.TXT_ciudad.Size = New System.Drawing.Size(347, 20)
        Me.TXT_ciudad.TabIndex = 7
        '
        'TXT_estado
        '
        Me.TXT_estado.Location = New System.Drawing.Point(479, 82)
        Me.TXT_estado.MaxLength = 30
        Me.TXT_estado.Name = "TXT_estado"
        Me.TXT_estado.Size = New System.Drawing.Size(223, 20)
        Me.TXT_estado.TabIndex = 9
        '
        'TXT_numero
        '
        Me.TXT_numero.Location = New System.Drawing.Point(479, 46)
        Me.TXT_numero.Name = "TXT_numero"
        Me.TXT_numero.Size = New System.Drawing.Size(93, 20)
        Me.TXT_numero.TabIndex = 4
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(191, 320)
        Me.txtMunicipio.MaxLength = 50
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(344, 20)
        Me.txtMunicipio.TabIndex = 8
        '
        'TXT_colonia
        '
        Me.TXT_colonia.Location = New System.Drawing.Point(60, 76)
        Me.TXT_colonia.MaxLength = 100
        Me.TXT_colonia.Name = "TXT_colonia"
        Me.TXT_colonia.Size = New System.Drawing.Size(347, 20)
        Me.TXT_colonia.TabIndex = 6
        '
        'TXT_calle
        '
        Me.TXT_calle.Location = New System.Drawing.Point(60, 47)
        Me.TXT_calle.MaxLength = 100
        Me.TXT_calle.Name = "TXT_calle"
        Me.TXT_calle.Size = New System.Drawing.Size(347, 20)
        Me.TXT_calle.TabIndex = 3
        '
        'TXT_id
        '
        Me.TXT_id.Location = New System.Drawing.Point(33, 15)
        Me.TXT_id.Name = "TXT_id"
        Me.TXT_id.Size = New System.Drawing.Size(73, 20)
        Me.TXT_id.TabIndex = 0
        '
        'DGV_orden
        '
        Me.DGV_orden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_orden.Location = New System.Drawing.Point(42, 161)
        Me.DGV_orden.Name = "DGV_orden"
        Me.DGV_orden.Size = New System.Drawing.Size(621, 291)
        Me.DGV_orden.TabIndex = 32
        '
        'TXT_municipio
        '
        Me.TXT_municipio.Location = New System.Drawing.Point(479, 108)
        Me.TXT_municipio.MaxLength = 30
        Me.TXT_municipio.Name = "TXT_municipio"
        Me.TXT_municipio.Size = New System.Drawing.Size(223, 20)
        Me.TXT_municipio.TabIndex = 20
        '
        'FRM_ordencompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(828, 474)
        Me.Controls.Add(Me.gpbCliente)
        Me.Controls.Add(Me.BTN_salir)
        Me.Controls.Add(Me.BTN_exportar)
        Me.Controls.Add(Me.BTN_reporte)
        Me.Controls.Add(Me.BTN_limpiar)
        Me.Controls.Add(Me.BTN_eliminar)
        Me.Controls.Add(Me.BTN_guardar)
        Me.Controls.Add(Me.BTN_nuevo)
        Me.Controls.Add(Me.DGV_orden)
        Me.Controls.Add(Me.txtMunicipio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_ordencompra"
        Me.Text = "Orden de Compra"
        Me.gpbCliente.ResumeLayout(False)
        Me.gpbCliente.PerformLayout()
        CType(Me.DGV_orden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_salir As System.Windows.Forms.Button
    Friend WithEvents BTN_exportar As System.Windows.Forms.Button
    Friend WithEvents BTN_reporte As System.Windows.Forms.Button
    Friend WithEvents BTN_limpiar As System.Windows.Forms.Button
    Friend WithEvents BTN_eliminar As System.Windows.Forms.Button
    Friend WithEvents BTN_guardar As System.Windows.Forms.Button
    Friend WithEvents BTN_nuevo As System.Windows.Forms.Button
    Friend WithEvents gpbCliente As System.Windows.Forms.GroupBox
    Friend WithEvents TXT_municipio As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreCliente As System.Windows.Forms.Label
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents lblCiudad As System.Windows.Forms.Label
    Friend WithEvents lblRFC As System.Windows.Forms.Label
    Friend WithEvents lblCP As System.Windows.Forms.Label
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents TXT_nombre As System.Windows.Forms.TextBox
    Friend WithEvents lblCalle As System.Windows.Forms.Label
    Friend WithEvents lblColonia As System.Windows.Forms.Label
    Friend WithEvents lblMunicipio As System.Windows.Forms.Label
    Friend WithEvents TXT_rfc As System.Windows.Forms.TextBox
    Friend WithEvents TXT_cp As System.Windows.Forms.TextBox
    Friend WithEvents TXT_ciudad As System.Windows.Forms.TextBox
    Friend WithEvents TXT_estado As System.Windows.Forms.TextBox
    Friend WithEvents TXT_numero As System.Windows.Forms.TextBox
    Friend WithEvents TXT_colonia As System.Windows.Forms.TextBox
    Friend WithEvents TXT_calle As System.Windows.Forms.TextBox
    Friend WithEvents TXT_id As System.Windows.Forms.TextBox
    Friend WithEvents txtMunicipio As System.Windows.Forms.TextBox
    Friend WithEvents DGV_orden As System.Windows.Forms.DataGridView
End Class
