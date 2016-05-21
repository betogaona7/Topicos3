Public Class FRM_login

    Dim mUsuario As New CLS_usuario

    Dim Login As String
    Dim Password As String

    Private Sub Limpia()
        Me.TXT_password.Text = ""
        Me.TXT_usuario.Text = ""
    End Sub

    Private Sub BTN_inciaSesion_Click(sender As System.Object, e As System.EventArgs) Handles BTN_inciaSesion.Click
        If Me.TXT_usuario.Text <> "" And TXT_password.Text <> "" Then
            If Me.mUsuario.GetDB2(Me.TXT_usuario.Text, Me.TXT_password.Text) Then
                FRM_InitialScreen.Show()
                Me.Hide()
            Else
                Me.TXT_usuario.Focus()
                MsgBox("Usuario y/o contraseña incorrecta... ", MsgBoxStyle.Information, "Error")
                Limpia()
            End If
        End If
    End Sub

    Private Sub BTN_salir_Click(sender As System.Object, e As System.EventArgs) Handles BTN_salir.Click
        Me.Close()
    End Sub

    
End Class