<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_login
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
        Me.TXT_usuario = New System.Windows.Forms.TextBox()
        Me.TXT_password = New System.Windows.Forms.TextBox()
        Me.LBL_usuario = New System.Windows.Forms.Label()
        Me.LBL_password = New System.Windows.Forms.Label()
        Me.BTN_inciaSesion = New System.Windows.Forms.Button()
        Me.BTN_salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TXT_usuario
        '
        Me.TXT_usuario.Location = New System.Drawing.Point(411, 134)
        Me.TXT_usuario.Name = "TXT_usuario"
        Me.TXT_usuario.Size = New System.Drawing.Size(166, 20)
        Me.TXT_usuario.TabIndex = 0
        '
        'TXT_password
        '
        Me.TXT_password.Location = New System.Drawing.Point(411, 210)
        Me.TXT_password.Name = "TXT_password"
        Me.TXT_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_password.Size = New System.Drawing.Size(166, 20)
        Me.TXT_password.TabIndex = 1
        '
        'LBL_usuario
        '
        Me.LBL_usuario.AutoSize = True
        Me.LBL_usuario.Location = New System.Drawing.Point(411, 118)
        Me.LBL_usuario.Name = "LBL_usuario"
        Me.LBL_usuario.Size = New System.Drawing.Size(46, 13)
        Me.LBL_usuario.TabIndex = 2
        Me.LBL_usuario.Text = "Usuario:"
        '
        'LBL_password
        '
        Me.LBL_password.AutoSize = True
        Me.LBL_password.Location = New System.Drawing.Point(411, 194)
        Me.LBL_password.Name = "LBL_password"
        Me.LBL_password.Size = New System.Drawing.Size(56, 13)
        Me.LBL_password.TabIndex = 3
        Me.LBL_password.Text = "Password:"
        '
        'BTN_inciaSesion
        '
        Me.BTN_inciaSesion.Location = New System.Drawing.Point(443, 267)
        Me.BTN_inciaSesion.Name = "BTN_inciaSesion"
        Me.BTN_inciaSesion.Size = New System.Drawing.Size(98, 23)
        Me.BTN_inciaSesion.TabIndex = 4
        Me.BTN_inciaSesion.Text = "Iniciar sesion"
        Me.BTN_inciaSesion.UseVisualStyleBackColor = True
        '
        'BTN_salir
        '
        Me.BTN_salir.Location = New System.Drawing.Point(443, 307)
        Me.BTN_salir.Name = "BTN_salir"
        Me.BTN_salir.Size = New System.Drawing.Size(98, 23)
        Me.BTN_salir.TabIndex = 5
        Me.BTN_salir.Text = "Salir"
        Me.BTN_salir.UseVisualStyleBackColor = True
        '
        'FRM_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SpringGreen
        Me.ClientSize = New System.Drawing.Size(984, 471)
        Me.Controls.Add(Me.BTN_salir)
        Me.Controls.Add(Me.BTN_inciaSesion)
        Me.Controls.Add(Me.LBL_password)
        Me.Controls.Add(Me.LBL_usuario)
        Me.Controls.Add(Me.TXT_password)
        Me.Controls.Add(Me.TXT_usuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar Sesion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_usuario As System.Windows.Forms.TextBox
    Friend WithEvents TXT_password As System.Windows.Forms.TextBox
    Friend WithEvents LBL_usuario As System.Windows.Forms.Label
    Friend WithEvents LBL_password As System.Windows.Forms.Label
    Friend WithEvents BTN_inciaSesion As System.Windows.Forms.Button
    Friend WithEvents BTN_salir As System.Windows.Forms.Button
End Class
