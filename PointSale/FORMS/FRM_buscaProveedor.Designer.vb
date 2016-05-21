<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_buscaProveedor
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_salir = New System.Windows.Forms.Button()
        Me.BTN_filtrar = New System.Windows.Forms.Button()
        Me.TXT_proveedor = New System.Windows.Forms.TextBox()
        Me.DGV_bProveedor = New System.Windows.Forms.DataGridView()
        CType(Me.DGV_bProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(127, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Proveedor"
        '
        'BTN_salir
        '
        Me.BTN_salir.Location = New System.Drawing.Point(783, 48)
        Me.BTN_salir.Name = "BTN_salir"
        Me.BTN_salir.Size = New System.Drawing.Size(75, 23)
        Me.BTN_salir.TabIndex = 8
        Me.BTN_salir.Text = "Salir"
        Me.BTN_salir.UseVisualStyleBackColor = True
        '
        'BTN_filtrar
        '
        Me.BTN_filtrar.Location = New System.Drawing.Point(691, 48)
        Me.BTN_filtrar.Name = "BTN_filtrar"
        Me.BTN_filtrar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_filtrar.TabIndex = 7
        Me.BTN_filtrar.Text = "Filtrar"
        Me.BTN_filtrar.UseVisualStyleBackColor = True
        '
        'TXT_proveedor
        '
        Me.TXT_proveedor.Location = New System.Drawing.Point(189, 50)
        Me.TXT_proveedor.Name = "TXT_proveedor"
        Me.TXT_proveedor.Size = New System.Drawing.Size(479, 20)
        Me.TXT_proveedor.TabIndex = 6
        '
        'DGV_bProveedor
        '
        Me.DGV_bProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_bProveedor.Location = New System.Drawing.Point(130, 111)
        Me.DGV_bProveedor.Name = "DGV_bProveedor"
        Me.DGV_bProveedor.Size = New System.Drawing.Size(728, 312)
        Me.DGV_bProveedor.TabIndex = 5
        '
        'FRM_buscaProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SpringGreen
        Me.ClientSize = New System.Drawing.Size(984, 471)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_salir)
        Me.Controls.Add(Me.BTN_filtrar)
        Me.Controls.Add(Me.TXT_proveedor)
        Me.Controls.Add(Me.DGV_bProveedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_buscaProveedor"
        Me.Text = "FRM_buscaProveedor"
        CType(Me.DGV_bProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BTN_salir As System.Windows.Forms.Button
    Friend WithEvents BTN_filtrar As System.Windows.Forms.Button
    Friend WithEvents TXT_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents DGV_bProveedor As System.Windows.Forms.DataGridView
End Class
