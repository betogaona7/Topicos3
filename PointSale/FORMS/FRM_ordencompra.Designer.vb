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
        Me.DGV_orden = New System.Windows.Forms.DataGridView()
        Me.BTN_nuevo = New System.Windows.Forms.Button()
        Me.BTN_guardar = New System.Windows.Forms.Button()
        Me.BTN_salir = New System.Windows.Forms.Button()
        Me.TXT_subtotal = New System.Windows.Forms.TextBox()
        Me.TXT_total = New System.Windows.Forms.TextBox()
        Me.TXT_iva = New System.Windows.Forms.TextBox()
        Me.TXT_descuento = New System.Windows.Forms.TextBox()
        Me.LBL_SubTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTN_F2rfc = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXT_nombre = New System.Windows.Forms.TextBox()
        Me.TXT_calle = New System.Windows.Forms.TextBox()
        Me.TXT_numero = New System.Windows.Forms.TextBox()
        Me.TXT_colonia = New System.Windows.Forms.TextBox()
        Me.TXT_rfc = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTN_F2codigo = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BTN_ok = New System.Windows.Forms.Button()
        Me.TXT_importe = New System.Windows.Forms.TextBox()
        Me.TXT_cantidad = New System.Windows.Forms.TextBox()
        Me.TXT_precio = New System.Windows.Forms.TextBox()
        Me.TXT_descripcion = New System.Windows.Forms.TextBox()
        Me.TXT_codigo = New System.Windows.Forms.TextBox()
        Me.LBL_fecha3 = New System.Windows.Forms.Label()
        Me.LBL_folio = New System.Windows.Forms.Label()
        Me.LBL_fecha2 = New System.Windows.Forms.Label()
        Me.LBL_fecha1 = New System.Windows.Forms.Label()
        CType(Me.DGV_orden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV_orden
        '
        Me.DGV_orden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_orden.Location = New System.Drawing.Point(12, 170)
        Me.DGV_orden.Name = "DGV_orden"
        Me.DGV_orden.Size = New System.Drawing.Size(610, 289)
        Me.DGV_orden.TabIndex = 6
        '
        'BTN_nuevo
        '
        Me.BTN_nuevo.Location = New System.Drawing.Point(785, 335)
        Me.BTN_nuevo.Name = "BTN_nuevo"
        Me.BTN_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.BTN_nuevo.TabIndex = 15
        Me.BTN_nuevo.Text = "&Nuevo"
        Me.BTN_nuevo.UseVisualStyleBackColor = True
        '
        'BTN_guardar
        '
        Me.BTN_guardar.Location = New System.Drawing.Point(785, 364)
        Me.BTN_guardar.Name = "BTN_guardar"
        Me.BTN_guardar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_guardar.TabIndex = 16
        Me.BTN_guardar.Text = "&Guardar"
        Me.BTN_guardar.UseVisualStyleBackColor = True
        '
        'BTN_salir
        '
        Me.BTN_salir.BackColor = System.Drawing.Color.DimGray
        Me.BTN_salir.Location = New System.Drawing.Point(785, 393)
        Me.BTN_salir.Name = "BTN_salir"
        Me.BTN_salir.Size = New System.Drawing.Size(75, 23)
        Me.BTN_salir.TabIndex = 17
        Me.BTN_salir.Text = "&Salir"
        Me.BTN_salir.UseVisualStyleBackColor = False
        '
        'TXT_subtotal
        '
        Me.TXT_subtotal.Location = New System.Drawing.Point(739, 189)
        Me.TXT_subtotal.Name = "TXT_subtotal"
        Me.TXT_subtotal.ReadOnly = True
        Me.TXT_subtotal.Size = New System.Drawing.Size(203, 20)
        Me.TXT_subtotal.TabIndex = 2
        '
        'TXT_total
        '
        Me.TXT_total.Location = New System.Drawing.Point(739, 267)
        Me.TXT_total.Name = "TXT_total"
        Me.TXT_total.ReadOnly = True
        Me.TXT_total.Size = New System.Drawing.Size(203, 20)
        Me.TXT_total.TabIndex = 5
        '
        'TXT_iva
        '
        Me.TXT_iva.Location = New System.Drawing.Point(739, 241)
        Me.TXT_iva.Name = "TXT_iva"
        Me.TXT_iva.ReadOnly = True
        Me.TXT_iva.Size = New System.Drawing.Size(203, 20)
        Me.TXT_iva.TabIndex = 4
        '
        'TXT_descuento
        '
        Me.TXT_descuento.Location = New System.Drawing.Point(739, 215)
        Me.TXT_descuento.Name = "TXT_descuento"
        Me.TXT_descuento.Size = New System.Drawing.Size(203, 20)
        Me.TXT_descuento.TabIndex = 3
        '
        'LBL_SubTotal
        '
        Me.LBL_SubTotal.AutoSize = True
        Me.LBL_SubTotal.Location = New System.Drawing.Point(674, 192)
        Me.LBL_SubTotal.Name = "LBL_SubTotal"
        Me.LBL_SubTotal.Size = New System.Drawing.Size(50, 13)
        Me.LBL_SubTotal.TabIndex = 11
        Me.LBL_SubTotal.Text = "SubTotal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(674, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Descuento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(674, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "I.V.A"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(674, 270)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Total"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.BTN_F2rfc)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TXT_nombre)
        Me.GroupBox1.Controls.Add(Me.TXT_calle)
        Me.GroupBox1.Controls.Add(Me.TXT_numero)
        Me.GroupBox1.Controls.Add(Me.TXT_colonia)
        Me.GroupBox1.Controls.Add(Me.TXT_rfc)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(860, 74)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Proveedor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(641, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Colonia"
        '
        'BTN_F2rfc
        '
        Me.BTN_F2rfc.Location = New System.Drawing.Point(128, 41)
        Me.BTN_F2rfc.Name = "BTN_F2rfc"
        Me.BTN_F2rfc.Size = New System.Drawing.Size(35, 23)
        Me.BTN_F2rfc.TabIndex = 6
        Me.BTN_F2rfc.Text = "F2"
        Me.BTN_F2rfc.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(553, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Numero"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(368, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Calle"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(178, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Nombre"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "RFC"
        '
        'TXT_nombre
        '
        Me.TXT_nombre.Location = New System.Drawing.Point(181, 43)
        Me.TXT_nombre.MaxLength = 100
        Me.TXT_nombre.Name = "TXT_nombre"
        Me.TXT_nombre.ReadOnly = True
        Me.TXT_nombre.Size = New System.Drawing.Size(181, 20)
        Me.TXT_nombre.TabIndex = 1
        '
        'TXT_calle
        '
        Me.TXT_calle.Location = New System.Drawing.Point(368, 43)
        Me.TXT_calle.MaxLength = 100
        Me.TXT_calle.Name = "TXT_calle"
        Me.TXT_calle.ReadOnly = True
        Me.TXT_calle.Size = New System.Drawing.Size(182, 20)
        Me.TXT_calle.TabIndex = 2
        '
        'TXT_numero
        '
        Me.TXT_numero.Location = New System.Drawing.Point(556, 43)
        Me.TXT_numero.Name = "TXT_numero"
        Me.TXT_numero.ReadOnly = True
        Me.TXT_numero.Size = New System.Drawing.Size(82, 20)
        Me.TXT_numero.TabIndex = 3
        '
        'TXT_colonia
        '
        Me.TXT_colonia.Location = New System.Drawing.Point(644, 43)
        Me.TXT_colonia.MaxLength = 100
        Me.TXT_colonia.Name = "TXT_colonia"
        Me.TXT_colonia.ReadOnly = True
        Me.TXT_colonia.Size = New System.Drawing.Size(210, 20)
        Me.TXT_colonia.TabIndex = 4
        '
        'TXT_rfc
        '
        Me.TXT_rfc.Location = New System.Drawing.Point(12, 43)
        Me.TXT_rfc.MaxLength = 15
        Me.TXT_rfc.Name = "TXT_rfc"
        Me.TXT_rfc.Size = New System.Drawing.Size(100, 20)
        Me.TXT_rfc.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BTN_F2codigo)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.BTN_ok)
        Me.GroupBox2.Controls.Add(Me.TXT_importe)
        Me.GroupBox2.Controls.Add(Me.TXT_cantidad)
        Me.GroupBox2.Controls.Add(Me.TXT_precio)
        Me.GroupBox2.Controls.Add(Me.TXT_descripcion)
        Me.GroupBox2.Controls.Add(Me.TXT_codigo)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 92)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(860, 72)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Orden"
        '
        'BTN_F2codigo
        '
        Me.BTN_F2codigo.Location = New System.Drawing.Point(128, 43)
        Me.BTN_F2codigo.Name = "BTN_F2codigo"
        Me.BTN_F2codigo.Size = New System.Drawing.Size(35, 23)
        Me.BTN_F2codigo.TabIndex = 6
        Me.BTN_F2codigo.Text = "F2"
        Me.BTN_F2codigo.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(641, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Importe"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(553, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Cantidad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(447, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Precio"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(178, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Descripción"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Codigo"
        '
        'BTN_ok
        '
        Me.BTN_ok.Location = New System.Drawing.Point(779, 44)
        Me.BTN_ok.Name = "BTN_ok"
        Me.BTN_ok.Size = New System.Drawing.Size(75, 23)
        Me.BTN_ok.TabIndex = 11
        Me.BTN_ok.Text = "Ok"
        Me.BTN_ok.UseVisualStyleBackColor = True
        '
        'TXT_importe
        '
        Me.TXT_importe.Location = New System.Drawing.Point(644, 46)
        Me.TXT_importe.Name = "TXT_importe"
        Me.TXT_importe.ReadOnly = True
        Me.TXT_importe.Size = New System.Drawing.Size(126, 20)
        Me.TXT_importe.TabIndex = 4
        '
        'TXT_cantidad
        '
        Me.TXT_cantidad.Location = New System.Drawing.Point(556, 46)
        Me.TXT_cantidad.Name = "TXT_cantidad"
        Me.TXT_cantidad.Size = New System.Drawing.Size(82, 20)
        Me.TXT_cantidad.TabIndex = 3
        '
        'TXT_precio
        '
        Me.TXT_precio.Location = New System.Drawing.Point(450, 46)
        Me.TXT_precio.Name = "TXT_precio"
        Me.TXT_precio.ReadOnly = True
        Me.TXT_precio.Size = New System.Drawing.Size(100, 20)
        Me.TXT_precio.TabIndex = 2
        '
        'TXT_descripcion
        '
        Me.TXT_descripcion.Location = New System.Drawing.Point(181, 46)
        Me.TXT_descripcion.MaxLength = 150
        Me.TXT_descripcion.Name = "TXT_descripcion"
        Me.TXT_descripcion.ReadOnly = True
        Me.TXT_descripcion.Size = New System.Drawing.Size(263, 20)
        Me.TXT_descripcion.TabIndex = 1
        '
        'TXT_codigo
        '
        Me.TXT_codigo.Location = New System.Drawing.Point(12, 46)
        Me.TXT_codigo.Name = "TXT_codigo"
        Me.TXT_codigo.Size = New System.Drawing.Size(100, 20)
        Me.TXT_codigo.TabIndex = 0
        '
        'LBL_fecha3
        '
        Me.LBL_fecha3.AutoSize = True
        Me.LBL_fecha3.Location = New System.Drawing.Point(877, 63)
        Me.LBL_fecha3.Name = "LBL_fecha3"
        Me.LBL_fecha3.Size = New System.Drawing.Size(37, 13)
        Me.LBL_fecha3.TabIndex = 10
        Me.LBL_fecha3.Text = "Fecha"
        Me.LBL_fecha3.Visible = False
        '
        'LBL_folio
        '
        Me.LBL_folio.AutoSize = True
        Me.LBL_folio.Location = New System.Drawing.Point(877, 48)
        Me.LBL_folio.Name = "LBL_folio"
        Me.LBL_folio.Size = New System.Drawing.Size(29, 13)
        Me.LBL_folio.TabIndex = 9
        Me.LBL_folio.Text = "Folio"
        '
        'LBL_fecha2
        '
        Me.LBL_fecha2.AutoSize = True
        Me.LBL_fecha2.Location = New System.Drawing.Point(877, 29)
        Me.LBL_fecha2.Name = "LBL_fecha2"
        Me.LBL_fecha2.Size = New System.Drawing.Size(37, 13)
        Me.LBL_fecha2.TabIndex = 8
        Me.LBL_fecha2.Text = "Fecha"
        Me.LBL_fecha2.Visible = False
        '
        'LBL_fecha1
        '
        Me.LBL_fecha1.AutoSize = True
        Me.LBL_fecha1.Location = New System.Drawing.Point(877, 12)
        Me.LBL_fecha1.Name = "LBL_fecha1"
        Me.LBL_fecha1.Size = New System.Drawing.Size(37, 13)
        Me.LBL_fecha1.TabIndex = 7
        Me.LBL_fecha1.Text = "Fecha"
        '
        'FRM_ordencompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SpringGreen
        Me.ClientSize = New System.Drawing.Size(984, 471)
        Me.Controls.Add(Me.LBL_fecha3)
        Me.Controls.Add(Me.LBL_folio)
        Me.Controls.Add(Me.LBL_fecha2)
        Me.Controls.Add(Me.LBL_fecha1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBL_SubTotal)
        Me.Controls.Add(Me.TXT_descuento)
        Me.Controls.Add(Me.TXT_iva)
        Me.Controls.Add(Me.TXT_total)
        Me.Controls.Add(Me.TXT_subtotal)
        Me.Controls.Add(Me.BTN_salir)
        Me.Controls.Add(Me.BTN_guardar)
        Me.Controls.Add(Me.BTN_nuevo)
        Me.Controls.Add(Me.DGV_orden)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_ordencompra"
        Me.Text = "Orden de Compra"
        CType(Me.DGV_orden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV_orden As System.Windows.Forms.DataGridView
    Friend WithEvents BTN_nuevo As System.Windows.Forms.Button
    Friend WithEvents BTN_guardar As System.Windows.Forms.Button
    Friend WithEvents BTN_salir As System.Windows.Forms.Button
    Friend WithEvents TXT_subtotal As System.Windows.Forms.TextBox
    Friend WithEvents TXT_total As System.Windows.Forms.TextBox
    Friend WithEvents TXT_iva As System.Windows.Forms.TextBox
    Friend WithEvents TXT_descuento As System.Windows.Forms.TextBox
    Friend WithEvents LBL_SubTotal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXT_nombre As System.Windows.Forms.TextBox
    Friend WithEvents TXT_calle As System.Windows.Forms.TextBox
    Friend WithEvents TXT_numero As System.Windows.Forms.TextBox
    Friend WithEvents TXT_colonia As System.Windows.Forms.TextBox
    Friend WithEvents TXT_rfc As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents BTN_ok As System.Windows.Forms.Button
    Friend WithEvents TXT_importe As System.Windows.Forms.TextBox
    Friend WithEvents TXT_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents TXT_precio As System.Windows.Forms.TextBox
    Friend WithEvents TXT_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents TXT_codigo As System.Windows.Forms.TextBox
    Friend WithEvents LBL_fecha3 As System.Windows.Forms.Label
    Friend WithEvents LBL_folio As System.Windows.Forms.Label
    Friend WithEvents LBL_fecha2 As System.Windows.Forms.Label
    Friend WithEvents LBL_fecha1 As System.Windows.Forms.Label
    Friend WithEvents BTN_F2rfc As System.Windows.Forms.Button
    Friend WithEvents BTN_F2codigo As System.Windows.Forms.Button
End Class
