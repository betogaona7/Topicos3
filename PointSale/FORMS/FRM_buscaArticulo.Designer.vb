<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_buscaArticulo
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
        Me.DGV_bArticulo = New System.Windows.Forms.DataGridView()
        Me.TXT_articulo = New System.Windows.Forms.TextBox()
        Me.BTN_filtrar = New System.Windows.Forms.Button()
        Me.BTN_salir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGV_bArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_bArticulo
        '
        Me.DGV_bArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_bArticulo.Location = New System.Drawing.Point(106, 128)
        Me.DGV_bArticulo.Name = "DGV_bArticulo"
        Me.DGV_bArticulo.Size = New System.Drawing.Size(728, 312)
        Me.DGV_bArticulo.TabIndex = 0
        '
        'TXT_articulo
        '
        Me.TXT_articulo.Location = New System.Drawing.Point(151, 86)
        Me.TXT_articulo.Name = "TXT_articulo"
        Me.TXT_articulo.Size = New System.Drawing.Size(493, 20)
        Me.TXT_articulo.TabIndex = 1
        '
        'BTN_filtrar
        '
        Me.BTN_filtrar.Location = New System.Drawing.Point(667, 84)
        Me.BTN_filtrar.Name = "BTN_filtrar"
        Me.BTN_filtrar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_filtrar.TabIndex = 2
        Me.BTN_filtrar.Text = "&Filtrar"
        Me.BTN_filtrar.UseVisualStyleBackColor = True
        '
        'BTN_salir
        '
        Me.BTN_salir.Location = New System.Drawing.Point(759, 84)
        Me.BTN_salir.Name = "BTN_salir"
        Me.BTN_salir.Size = New System.Drawing.Size(75, 23)
        Me.BTN_salir.TabIndex = 3
        Me.BTN_salir.Text = "&Salir"
        Me.BTN_salir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(103, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Articulo:"
        '
        'FRM_buscaArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SpringGreen
        Me.ClientSize = New System.Drawing.Size(984, 471)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_salir)
        Me.Controls.Add(Me.BTN_filtrar)
        Me.Controls.Add(Me.TXT_articulo)
        Me.Controls.Add(Me.DGV_bArticulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_buscaArticulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_buscaArticulo"
        CType(Me.DGV_bArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV_bArticulo As System.Windows.Forms.DataGridView
    Friend WithEvents TXT_articulo As System.Windows.Forms.TextBox
    Friend WithEvents BTN_filtrar As System.Windows.Forms.Button
    Friend WithEvents BTN_salir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
