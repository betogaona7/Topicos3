Public Class FRM_usuario

    Dim mUsuario As New CLS_usuario

    Dim IdUsuario As Integer
    Dim Nombre As String
    Dim Login As String
    Dim Password As String
    Dim bnuevo As Boolean

    Private Sub FRM_usuario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Limpiar()
        Me.dgFormat()
    End Sub

    Private Sub Limpiar()
        Me.TXT_id.Text = ""
        Me.TXT_nombre.Text = ""
        Me.TXT_login.Text = ""
        Me.TXT_password.Text = ""

        Me.BTN_nuevo.Enabled = True
        Me.BTN_Eliminar.Enabled = False
        Me.BTN_guardar.Enabled = False

        bnuevo = False
    End Sub

#Region "Validacion de campos"
    Private Sub TXT_id_Validated(sender As Object, e As System.EventArgs) Handles TXT_id.Validated
        If Me.TXT_id.Text <> "" And bnuevo <> True Then
            Me.mUsuario.IdUsuario = CInt(Me.TXT_id.Text)
            If Me.mUsuario.GetDB() Then
                Me.TXT_id.Text = Me.mUsuario.IdUsuario
                Me.TXT_nombre.Text = Me.mUsuario.Nombre
                Me.TXT_login.Text = Me.mUsuario.Login
                Me.TXT_password.Text = Me.mUsuario.Password
                bnuevo = False
                Me.BTN_guardar.Enabled = True
                Me.BTN_Eliminar.Enabled = True
                Me.BTN_nuevo.Enabled = False
                Me.TXT_id.Focus()
            Else
                MsgBox("Registro No Existe... ", MsgBoxStyle.Information, "Aviso")
            End If
        End If
    End Sub

    Private Sub TXT_id_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_id.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TXT_nombre_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_nombre.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TXT_login_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_login.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TXT_password_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_password.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
#End Region

#Region "Botones"

    'Nuevo    
    Private Sub BTN_nuevo_Click(sender As System.Object, e As System.EventArgs) Handles BTN_nuevo.Click
        Me.Limpiar()
        bnuevo = True
        Me.mUsuario.New_IdUsuario()
        Me.TXT_id.Text = Me.mUsuario.IdUsuario
        Me.BTN_nuevo.Enabled = False
        Me.BTN_guardar.Enabled = True
        Me.BTN_Eliminar.Enabled = True
        Me.TXT_id.Focus()
    End Sub

    'Guardar
    Private Sub BTN_guardar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_guardar.Click
        If Me.TXT_id.Text <> "" And Me.TXT_nombre.Text <> "" And Me.TXT_login.Text <> "" And Me.TXT_password.Text <> "" Then
            Me.mUsuario.IdUsuario = CInt(Val(Me.TXT_id.Text))
            Me.mUsuario.Nombre = Me.TXT_nombre.Text
            Me.mUsuario.Login = Me.TXT_login.Text
            Me.mUsuario.Password = Me.TXT_password.Text
            If bnuevo = True Then
                Me.mUsuario.Activo = 1
                Me.mUsuario.insertDB()
                MsgBox("Registro " & Me.TXT_id.Text & " Dado de Alta ", MsgBoxStyle.Information, "Aviso")
            Else
                Me.mUsuario.UpdateDB()
                MsgBox("Registro" & Me.TXT_id.Text & " Actualizado ", MsgBoxStyle.Information, "Aviso")
            End If
        End If
        Me.Limpiar()
        bnuevo = False
        Me.BTN_nuevo.Enabled = True
        Me.BTN_Eliminar.Enabled = False
        Me.BTN_guardar.Enabled = False
        Me.dgFormat()
        Me.TXT_id.Focus()
    End Sub

    'Eliminar
    Private Sub BTN_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_Eliminar.Click
        If Me.TXT_id.Text <> "" Then
            Me.mUsuario.IdUsuario = CInt(Me.TXT_id.Text)
            Me.mUsuario.GetDB()
            If MsgBox("Desea Eliminar El Registro " & Me.TXT_id.Text, vbYesNo, "Confirmar") = vbYes Then
                If Me.mUsuario.Activo = 0 Then
                    If MsgBox("El Registro Esta Cancelado Desea Activarlo", vbYesNo, "Confirmar ") = vbYes Then
                        Me.mUsuario.UpdCancela(1)
                        MsgBox("Reactivacion Correcta", MsgBoxStyle.Information, "Aviso")
                    End If
                Else
                    Me.mUsuario.UpdCancela(0)
                    MsgBox("Cancelacion Correcta", MsgBoxStyle.Information, "Aviso")
                End If
            End If
        Else
            MsgBox("Favor De Seleccionar Un Registo", MsgBoxStyle.Information, "Aviso")
        End If
        Me.Limpiar()
        Me.dgFormat()
        Me.TXT_id.Focus()
    End Sub

    'Limpiar
    Private Sub BTN_Limpiar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_Limpiar.Click
        Me.Limpiar()
    End Sub

    'Salir
    Private Sub BTN_salir_Click(sender As System.Object, e As System.EventArgs) Handles BTN_salir.Click
        Me.Close()
    End Sub

#End Region

#Region "Grid"

    Private Sub dgFormat()
        Me.DGV_usuario.DataSource = Me.mUsuario.Fill_Grid()
        Me.DGV_usuario.Refresh()
        'Me.dg1.Columns(0).HeaderText = "Id"
        'Me.dg1.Columns(1).HeaderText = "Nombre"
        'Me.dg1.Columns(0).Visible = False
        'Me.dg1.Columns(0).Width = 30
        'Me.dg1.Columns(1).Width = 220
        'Me.dg1.Columns(2).Visible = False
        'Me.dg1.Columns(7).Visible = False
        DGV_usuario.Focus()
    End Sub

    'Selecciona el registro marcado del grid
    Private Sub DGV_usuario_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles DGV_usuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.KeyValue.ToString()
            Me.TXT_id.Text = Me.DGV_usuario.CurrentRow.Cells(0).Value
            Me.TXT_id_Validated(sender, e)
            bnuevo = False
            Me.BTN_guardar.Enabled = True
            Me.BTN_nuevo.Enabled = False
        End If
    End Sub
#End Region

End Class