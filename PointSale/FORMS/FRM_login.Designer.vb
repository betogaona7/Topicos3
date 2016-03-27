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
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LBL_usuario = New System.Windows.Forms.Label()
        Me.LBL_password = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TXT_usuario
        '
        Me.TXT_usuario.Location = New System.Drawing.Point(66, 79)
        Me.TXT_usuario.Name = "TXT_usuario"
        Me.TXT_usuario.Size = New System.Drawing.Size(166, 20)
        Me.TXT_usuario.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(66, 155)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(166, 20)
        Me.TextBox2.TabIndex = 1
        '
        'LBL_usuario
        '
        Me.LBL_usuario.AutoSize = True
        Me.LBL_usuario.Location = New System.Drawing.Point(66, 63)
        Me.LBL_usuario.Name = "LBL_usuario"
        Me.LBL_usuario.Size = New System.Drawing.Size(46, 13)
        Me.LBL_usuario.TabIndex = 2
        Me.LBL_usuario.Text = "Usuario:"
        '
        'LBL_password
        '
        Me.LBL_password.AutoSize = True
        Me.LBL_password.Location = New System.Drawing.Point(66, 139)
        Me.LBL_password.Name = "LBL_password"
        Me.LBL_password.Size = New System.Drawing.Size(56, 13)
        Me.LBL_password.TabIndex = 3
        Me.LBL_password.Text = "Password:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(98, 212)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Iniciar sesion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FRM_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(301, 282)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LBL_password)
        Me.Controls.Add(Me.LBL_usuario)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TXT_usuario)
        Me.Name = "FRM_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar Sesion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_usuario As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents LBL_usuario As System.Windows.Forms.Label
    Friend WithEvents LBL_password As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
