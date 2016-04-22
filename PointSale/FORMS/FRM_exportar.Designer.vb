<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_exportar
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnExporta = New System.Windows.Forms.Button()
        Me.dg1 = New System.Windows.Forms.DataGridView()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(636, 219)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnExporta
        '
        Me.btnExporta.Location = New System.Drawing.Point(636, 177)
        Me.btnExporta.Name = "btnExporta"
        Me.btnExporta.Size = New System.Drawing.Size(75, 23)
        Me.btnExporta.TabIndex = 4
        Me.btnExporta.Text = "&Exporta"
        Me.btnExporta.UseVisualStyleBackColor = True
        '
        'dg1
        '
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Location = New System.Drawing.Point(12, 32)
        Me.dg1.Name = "dg1"
        Me.dg1.Size = New System.Drawing.Size(597, 359)
        Me.dg1.TabIndex = 3
        '
        'FRM_exportar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 422)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnExporta)
        Me.Controls.Add(Me.dg1)
        Me.Name = "FRM_exportar"
        Me.Text = "Exportar"
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnExporta As System.Windows.Forms.Button
    Friend WithEvents dg1 As System.Windows.Forms.DataGridView
End Class
