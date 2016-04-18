<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Usuario
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
        Me.components = New System.ComponentModel.Container()
        Me.TXT_id = New System.Windows.Forms.TextBox()
        Me.TXT_nombre = New System.Windows.Forms.TextBox()
        Me.TXT_password = New System.Windows.Forms.TextBox()
        Me.TXT_login = New System.Windows.Forms.TextBox()
        Me.CB_departamento = New System.Windows.Forms.ComboBox()
        Me.BTN_nuevo = New System.Windows.Forms.Button()
        Me.BTN_salir = New System.Windows.Forms.Button()
        Me.BTN_reporte = New System.Windows.Forms.Button()
        Me.BTN_limpia = New System.Windows.Forms.Button()
        Me.BTN_elimina = New System.Windows.Forms.Button()
        Me.BTN_guarda = New System.Windows.Forms.Button()
        Me.DTG_usuario = New System.Windows.Forms.DataGridView()
        Me.LBL_departamento = New System.Windows.Forms.Label()
        Me.CMS_departamento = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LBL_id = New System.Windows.Forms.Label()
        Me.LBL_password = New System.Windows.Forms.Label()
        Me.LBL_login = New System.Windows.Forms.Label()
        Me.LBL_nombre = New System.Windows.Forms.Label()
        CType(Me.DTG_usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_id
        '
        Me.TXT_id.Location = New System.Drawing.Point(12, 42)
        Me.TXT_id.Name = "TXT_id"
        Me.TXT_id.Size = New System.Drawing.Size(100, 20)
        Me.TXT_id.TabIndex = 0
        '
        'TXT_nombre
        '
        Me.TXT_nombre.Location = New System.Drawing.Point(140, 42)
        Me.TXT_nombre.Name = "TXT_nombre"
        Me.TXT_nombre.Size = New System.Drawing.Size(100, 20)
        Me.TXT_nombre.TabIndex = 1
        '
        'TXT_password
        '
        Me.TXT_password.Location = New System.Drawing.Point(386, 42)
        Me.TXT_password.Name = "TXT_password"
        Me.TXT_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_password.Size = New System.Drawing.Size(100, 20)
        Me.TXT_password.TabIndex = 2
        '
        'TXT_login
        '
        Me.TXT_login.Location = New System.Drawing.Point(264, 42)
        Me.TXT_login.Name = "TXT_login"
        Me.TXT_login.Size = New System.Drawing.Size(100, 20)
        Me.TXT_login.TabIndex = 3
        '
        'CB_departamento
        '
        Me.CB_departamento.FormattingEnabled = True
        Me.CB_departamento.Location = New System.Drawing.Point(515, 41)
        Me.CB_departamento.Name = "CB_departamento"
        Me.CB_departamento.Size = New System.Drawing.Size(181, 21)
        Me.CB_departamento.TabIndex = 4
        '
        'BTN_nuevo
        '
        Me.BTN_nuevo.Location = New System.Drawing.Point(622, 76)
        Me.BTN_nuevo.Name = "BTN_nuevo"
        Me.BTN_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.BTN_nuevo.TabIndex = 5
        Me.BTN_nuevo.Text = "Nuevo"
        Me.BTN_nuevo.UseVisualStyleBackColor = True
        '
        'BTN_salir
        '
        Me.BTN_salir.Location = New System.Drawing.Point(622, 282)
        Me.BTN_salir.Name = "BTN_salir"
        Me.BTN_salir.Size = New System.Drawing.Size(75, 23)
        Me.BTN_salir.TabIndex = 6
        Me.BTN_salir.Text = "Salir "
        Me.BTN_salir.UseVisualStyleBackColor = True
        '
        'BTN_reporte
        '
        Me.BTN_reporte.Location = New System.Drawing.Point(622, 207)
        Me.BTN_reporte.Name = "BTN_reporte"
        Me.BTN_reporte.Size = New System.Drawing.Size(75, 23)
        Me.BTN_reporte.TabIndex = 7
        Me.BTN_reporte.Text = "Reporte"
        Me.BTN_reporte.UseVisualStyleBackColor = True
        '
        'BTN_limpia
        '
        Me.BTN_limpia.Location = New System.Drawing.Point(621, 178)
        Me.BTN_limpia.Name = "BTN_limpia"
        Me.BTN_limpia.Size = New System.Drawing.Size(75, 23)
        Me.BTN_limpia.TabIndex = 8
        Me.BTN_limpia.Text = "Limpia"
        Me.BTN_limpia.UseVisualStyleBackColor = True
        '
        'BTN_elimina
        '
        Me.BTN_elimina.Location = New System.Drawing.Point(622, 149)
        Me.BTN_elimina.Name = "BTN_elimina"
        Me.BTN_elimina.Size = New System.Drawing.Size(75, 23)
        Me.BTN_elimina.TabIndex = 9
        Me.BTN_elimina.Text = "Elimina"
        Me.BTN_elimina.UseVisualStyleBackColor = True
        '
        'BTN_guarda
        '
        Me.BTN_guarda.Location = New System.Drawing.Point(622, 120)
        Me.BTN_guarda.Name = "BTN_guarda"
        Me.BTN_guarda.Size = New System.Drawing.Size(75, 23)
        Me.BTN_guarda.TabIndex = 10
        Me.BTN_guarda.Text = "Guarda"
        Me.BTN_guarda.UseVisualStyleBackColor = True
        '
        'DTG_usuario
        '
        Me.DTG_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTG_usuario.Location = New System.Drawing.Point(12, 80)
        Me.DTG_usuario.Name = "DTG_usuario"
        Me.DTG_usuario.Size = New System.Drawing.Size(581, 225)
        Me.DTG_usuario.TabIndex = 11
        '
        'LBL_departamento
        '
        Me.LBL_departamento.AutoSize = True
        Me.LBL_departamento.ContextMenuStrip = Me.CMS_departamento
        Me.LBL_departamento.Location = New System.Drawing.Point(512, 25)
        Me.LBL_departamento.Name = "LBL_departamento"
        Me.LBL_departamento.Size = New System.Drawing.Size(74, 13)
        Me.LBL_departamento.TabIndex = 12
        Me.LBL_departamento.Text = "Departamento"
        '
        'CMS_departamento
        '
        Me.CMS_departamento.Name = "CMS_departamento"
        Me.CMS_departamento.Size = New System.Drawing.Size(61, 4)
        '
        'LBL_id
        '
        Me.LBL_id.AutoSize = True
        Me.LBL_id.Location = New System.Drawing.Point(12, 25)
        Me.LBL_id.Name = "LBL_id"
        Me.LBL_id.Size = New System.Drawing.Size(18, 13)
        Me.LBL_id.TabIndex = 13
        Me.LBL_id.Text = "ID"
        '
        'LBL_password
        '
        Me.LBL_password.AutoSize = True
        Me.LBL_password.Location = New System.Drawing.Point(383, 25)
        Me.LBL_password.Name = "LBL_password"
        Me.LBL_password.Size = New System.Drawing.Size(53, 13)
        Me.LBL_password.TabIndex = 14
        Me.LBL_password.Text = "Password"
        '
        'LBL_login
        '
        Me.LBL_login.AutoSize = True
        Me.LBL_login.Location = New System.Drawing.Point(261, 25)
        Me.LBL_login.Name = "LBL_login"
        Me.LBL_login.Size = New System.Drawing.Size(33, 13)
        Me.LBL_login.TabIndex = 15
        Me.LBL_login.Text = "Login"
        '
        'LBL_nombre
        '
        Me.LBL_nombre.AutoSize = True
        Me.LBL_nombre.Location = New System.Drawing.Point(137, 25)
        Me.LBL_nombre.Name = "LBL_nombre"
        Me.LBL_nombre.Size = New System.Drawing.Size(44, 13)
        Me.LBL_nombre.TabIndex = 16
        Me.LBL_nombre.Text = "Nombre"
        '
        'FRM_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 334)
        Me.Controls.Add(Me.LBL_nombre)
        Me.Controls.Add(Me.LBL_login)
        Me.Controls.Add(Me.LBL_password)
        Me.Controls.Add(Me.LBL_id)
        Me.Controls.Add(Me.LBL_departamento)
        Me.Controls.Add(Me.DTG_usuario)
        Me.Controls.Add(Me.BTN_guarda)
        Me.Controls.Add(Me.BTN_elimina)
        Me.Controls.Add(Me.BTN_limpia)
        Me.Controls.Add(Me.BTN_reporte)
        Me.Controls.Add(Me.BTN_salir)
        Me.Controls.Add(Me.BTN_nuevo)
        Me.Controls.Add(Me.CB_departamento)
        Me.Controls.Add(Me.TXT_login)
        Me.Controls.Add(Me.TXT_password)
        Me.Controls.Add(Me.TXT_nombre)
        Me.Controls.Add(Me.TXT_id)
        Me.Name = "FRM_Usuario"
        Me.Text = "FRM_Usuario"
        CType(Me.DTG_usuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_id As System.Windows.Forms.TextBox
    Friend WithEvents TXT_nombre As System.Windows.Forms.TextBox
    Friend WithEvents TXT_password As System.Windows.Forms.TextBox
    Friend WithEvents TXT_login As System.Windows.Forms.TextBox
    Friend WithEvents CB_departamento As System.Windows.Forms.ComboBox
    Friend WithEvents BTN_nuevo As System.Windows.Forms.Button
    Friend WithEvents BTN_salir As System.Windows.Forms.Button
    Friend WithEvents BTN_reporte As System.Windows.Forms.Button
    Friend WithEvents BTN_limpia As System.Windows.Forms.Button
    Friend WithEvents BTN_elimina As System.Windows.Forms.Button
    Friend WithEvents BTN_guarda As System.Windows.Forms.Button
    Friend WithEvents DTG_usuario As System.Windows.Forms.DataGridView
    Friend WithEvents LBL_departamento As System.Windows.Forms.Label
    Friend WithEvents CMS_departamento As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents LBL_id As System.Windows.Forms.Label
    Friend WithEvents LBL_password As System.Windows.Forms.Label
    Friend WithEvents LBL_login As System.Windows.Forms.Label
    Friend WithEvents LBL_nombre As System.Windows.Forms.Label
End Class
