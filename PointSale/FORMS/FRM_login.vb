Public Class FRM_login

    Private Sub Limpia()
        Me.TXT_password.Text = ""
        Me.TXT_usuario.Text = ""
    End Sub

    Private Sub BTN_inciaSesion_Click(sender As System.Object, e As System.EventArgs) Handles BTN_inciaSesion.Click
        If TXT_usuario.Text = "betogaona7" And TXT_password.Text = "12345" Then
            FRM_InitialScreen.Show()
            Me.Hide()
        Else
            MsgBox("Usuario y/o contraseña incorrecta... ", MsgBoxStyle.Information, "Error")
            Limpia()
        End If
    End Sub


    Private Sub BTN_salir_Click(sender As System.Object, e As System.EventArgs) Handles BTN_salir.Click
        Me.Close()
    End Sub
End Class