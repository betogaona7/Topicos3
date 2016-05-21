<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_usuario
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
        Me.DGV_usuario = New System.Windows.Forms.DataGridView()
        Me.BTN_nuevo = New System.Windows.Forms.Button()
        Me.BTN_salir = New System.Windows.Forms.Button()
        Me.BTN_Limpiar = New System.Windows.Forms.Button()
        Me.BTN_Eliminar = New System.Windows.Forms.Button()
        Me.BTN_guardar = New System.Windows.Forms.Button()
        Me.TXT_id = New System.Windows.Forms.TextBox()
        Me.TXT_password = New System.Windows.Forms.TextBox()
        Me.TXT_login = New System.Windows.Forms.TextBox()
        Me.TXT_nombre = New System.Windows.Forms.TextBox()
        Me.LBL_id = New System.Windows.Forms.Label()
        Me.LBL_password = New System.Windows.Forms.Label()
        Me.LBL_nombre = New System.Windows.Forms.Label()
        Me.LBL_login = New System.Windows.Forms.Label()
        CType(Me.DGV_usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_usuario
        '
        Me.DGV_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_usuario.Location = New System.Drawing.Point(68, 170)
        Me.DGV_usuario.Name = "DGV_usuario"
        Me.DGV_usuario.Size = New System.Drawing.Size(615, 266)
        Me.DGV_usuario.TabIndex = 0
        '
        'BTN_nuevo
        '
        Me.BTN_nuevo.Location = New System.Drawing.Point(786, 227)
        Me.BTN_nuevo.Name = "BTN_nuevo"
        Me.BTN_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.BTN_nuevo.TabIndex = 1
        Me.BTN_nuevo.Text = "&Nuevo"
        Me.BTN_nuevo.UseVisualStyleBackColor = True
        '
        'BTN_salir
        '
        Me.BTN_salir.Location = New System.Drawing.Point(786, 343)
        Me.BTN_salir.Name = "BTN_salir"
        Me.BTN_salir.Size = New System.Drawing.Size(75, 23)
        Me.BTN_salir.TabIndex = 2
        Me.BTN_salir.Text = "&Salir"
        Me.BTN_salir.UseVisualStyleBackColor = True
        '
        'BTN_Limpiar
        '
        Me.BTN_Limpiar.Location = New System.Drawing.Point(786, 314)
        Me.BTN_Limpiar.Name = "BTN_Limpiar"
        Me.BTN_Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Limpiar.TabIndex = 3
        Me.BTN_Limpiar.Text = "&Limpiar"
        Me.BTN_Limpiar.UseVisualStyleBackColor = True
        '
        'BTN_Eliminar
        '
        Me.BTN_Eliminar.Location = New System.Drawing.Point(786, 285)
        Me.BTN_Eliminar.Name = "BTN_Eliminar"
        Me.BTN_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Eliminar.TabIndex = 4
        Me.BTN_Eliminar.Text = "&Eliminar"
        Me.BTN_Eliminar.UseVisualStyleBackColor = True
        '
        'BTN_guardar
        '
        Me.BTN_guardar.Location = New System.Drawing.Point(786, 256)
        Me.BTN_guardar.Name = "BTN_guardar"
        Me.BTN_guardar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_guardar.TabIndex = 5
        Me.BTN_guardar.Text = "&Guardar"
        Me.BTN_guardar.UseVisualStyleBackColor = True
        '
        'TXT_id
        '
        Me.TXT_id.Location = New System.Drawing.Point(92, 67)
        Me.TXT_id.Name = "TXT_id"
        Me.TXT_id.Size = New System.Drawing.Size(79, 20)
        Me.TXT_id.TabIndex = 6
        '
        'TXT_password
        '
        Me.TXT_password.Location = New System.Drawing.Point(779, 67)
        Me.TXT_password.Name = "TXT_password"
        Me.TXT_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_password.Size = New System.Drawing.Size(133, 20)
        Me.TXT_password.TabIndex = 7
        '
        'TXT_login
        '
        Me.TXT_login.Location = New System.Drawing.Point(567, 67)
        Me.TXT_login.Name = "TXT_login"
        Me.TXT_login.Size = New System.Drawing.Size(132, 20)
        Me.TXT_login.TabIndex = 8
        '
        'TXT_nombre
        '
        Me.TXT_nombre.Location = New System.Drawing.Point(242, 67)
        Me.TXT_nombre.Name = "TXT_nombre"
        Me.TXT_nombre.Size = New System.Drawing.Size(249, 20)
        Me.TXT_nombre.TabIndex = 9
        '
        'LBL_id
        '
        Me.LBL_id.AutoSize = True
        Me.LBL_id.Location = New System.Drawing.Point(65, 70)
        Me.LBL_id.Name = "LBL_id"
        Me.LBL_id.Size = New System.Drawing.Size(21, 13)
        Me.LBL_id.TabIndex = 10
        Me.LBL_id.Text = "ID:"
        '
        'LBL_password
        '
        Me.LBL_password.AutoSize = True
        Me.LBL_password.Location = New System.Drawing.Point(717, 70)
        Me.LBL_password.Name = "LBL_password"
        Me.LBL_password.Size = New System.Drawing.Size(56, 13)
        Me.LBL_password.TabIndex = 11
        Me.LBL_password.Text = "Password:"
        '
        'LBL_nombre
        '
        Me.LBL_nombre.AutoSize = True
        Me.LBL_nombre.Location = New System.Drawing.Point(189, 70)
        Me.LBL_nombre.Name = "LBL_nombre"
        Me.LBL_nombre.Size = New System.Drawing.Size(47, 13)
        Me.LBL_nombre.TabIndex = 12
        Me.LBL_nombre.Text = "Nombre:"
        '
        'LBL_login
        '
        Me.LBL_login.AutoSize = True
        Me.LBL_login.Location = New System.Drawing.Point(515, 70)
        Me.LBL_login.Name = "LBL_login"
        Me.LBL_login.Size = New System.Drawing.Size(46, 13)
        Me.LBL_login.TabIndex = 13
        Me.LBL_login.Text = "Usuario:"
        '
        'FRM_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SpringGreen
        Me.ClientSize = New System.Drawing.Size(984, 471)
        Me.Controls.Add(Me.LBL_login)
        Me.Controls.Add(Me.LBL_nombre)
        Me.Controls.Add(Me.LBL_password)
        Me.Controls.Add(Me.LBL_id)
        Me.Controls.Add(Me.TXT_nombre)
        Me.Controls.Add(Me.TXT_login)
        Me.Controls.Add(Me.TXT_password)
        Me.Controls.Add(Me.TXT_id)
        Me.Controls.Add(Me.BTN_guardar)
        Me.Controls.Add(Me.BTN_Eliminar)
        Me.Controls.Add(Me.BTN_Limpiar)
        Me.Controls.Add(Me.BTN_salir)
        Me.Controls.Add(Me.BTN_nuevo)
        Me.Controls.Add(Me.DGV_usuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_usuario"
        Me.Text = "FRM_usuario"
        CType(Me.DGV_usuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV_usuario As System.Windows.Forms.DataGridView
    Friend WithEvents BTN_nuevo As System.Windows.Forms.Button
    Friend WithEvents BTN_salir As System.Windows.Forms.Button
    Friend WithEvents BTN_Limpiar As System.Windows.Forms.Button
    Friend WithEvents BTN_Eliminar As System.Windows.Forms.Button
    Friend WithEvents BTN_guardar As System.Windows.Forms.Button
    Friend WithEvents TXT_id As System.Windows.Forms.TextBox
    Friend WithEvents TXT_password As System.Windows.Forms.TextBox
    Friend WithEvents TXT_login As System.Windows.Forms.TextBox
    Friend WithEvents TXT_nombre As System.Windows.Forms.TextBox
    Friend WithEvents LBL_id As System.Windows.Forms.Label
    Friend WithEvents LBL_password As System.Windows.Forms.Label
    Friend WithEvents LBL_nombre As System.Windows.Forms.Label
    Friend WithEvents LBL_login As System.Windows.Forms.Label
End Class
