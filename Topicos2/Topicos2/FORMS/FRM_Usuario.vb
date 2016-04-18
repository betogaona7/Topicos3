Public Class FRM_Usuario

    Dim mUsuario As New CLS_usuario
    Dim mDepartamento As New clsDepartamento
    Dim IDUsuario As Integer
    Dim Nombre As String
    Dim Login As String
    Dim Password As String
    Dim IDDepartamento As Integer
    Dim bnuevo As Boolean

    Private Sub FRM_Usuario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.LoadCombo()
        Me.Limpia()
        Me.dgFormat()
    End Sub

    Private Sub Limpia()
        Me.TXT_id.Text = ""
        Me.TXT_nombre.Text = ""
        Me.TXT_login.Text = ""
        Me.TXT_password.Text = ""
    End Sub

#Region "Combo"
    Private Sub LoadCombo()
        'Carga departamentos 
        Dim DT As New DataTable
        DT = Me.mDepartamento.Load_Combo
        Dim row As DataRow = DT.NewRow
        row("Departamento") = ""
        row("IDDepartamento") = 0

        DT.Rows.InsertAt(row, 0)
        Me.CB_departamento.DataSource = DT
        Me.CB_departamento.Sorted.ToString()
        Me.CB_departamento.DisplayMember = "Departamento"
        Me.CB_departamento.ValueMember = "IDDepartamento"
        Me.CB_departamento.SelectedIndex = 0
    End Sub
#End Region

    Private Sub CMS_departamento_Click(sender As Object, e As System.EventArgs) Handles CMS_departamento.Click
        FRM_departamento.ShowDialog()
    End Sub

    Private Sub BTN_nuevo_Click(sender As System.Object, e As System.EventArgs) Handles BTN_nuevo.Click
        Me.Limpia()
        bnuevo = True
        Me.mUsuario.New_IDUsuario()
        Me.TXT_id.Text = Me.mUsuario.IDUsuario
        Me.BTN_nuevo.Enabled = False
        Me.BTN_guarda.Enabled = True
        Me.BTN_elimina.Enabled = False
        Me.TXT_nombre.Focus()
    End Sub


    Private Sub BTN_guarda_Click(sender As System.Object, e As System.EventArgs) Handles BTN_guarda.Click
        If Me.TXT_id.Text <> "" And Me.TXT_nombre.Text <> "" Then
            Me.mUsuario.IDUsuario = CInt(Val(Me.TXT_id.Text))
            Me.mUsuario.Nombre = Me.TXT_nombre.Text
            Me.mUsuario.Login = Me.TXT_login.Text
            Me.mUsuario.Password = Me.TXT_password.Text
            Me.mUsuario.IDDepartamento = CInt(Val(Me.CB_departamento.SelectedItem("IDDepartamento").ToString))
            If bnuevo = True Then
                Me.mUsuario.Activo = 1
                Me.mUsuario.insertDB()
                MsgBox("Registro " & Me.TXT_id.Text & " dado de alta", MsgBoxStyle.Information, "Aviso")
            Else
                Me.mUsuario.UpdateDB()
                MsgBox("Registro " & Me.TXT_id.Text & " actualizado", MsgBoxStyle.Information, "Aviso")
            End If
        Else
            MsgBox("Favor de completar la informacion", MsgBoxStyle.Information, "Aviso")
        End If
        Me.Limpia()
        bnuevo = False
        Me.BTN_nuevo.Enabled = True
        Me.BTN_elimina.Enabled = False
        Me.BTN_guarda.Enabled = False
        Me.dgFormat()
        Me.TXT_id.Focus()
    End Sub

    Private Sub BTN_elimina_Click(sender As System.Object, e As System.EventArgs) Handles BTN_elimina.Click
        If Me.TXT_id.Text <> "" Then
            Me.mUsuario.IDUsuario = CInt(Me.TXT_id.Text)
            Me.mUsuario.GetDB()
            If MsgBox("Desea eliminar el registro " & Me.TXT_nombre.Text, vbYesNo, "Confirmar") = vbYes Then
                If Me.mUsuario.Activo = 0 Then
                    If MsgBox("El registro esta cancelado desea activarlo", vbYesNo, "Confirmar") = vbYes Then
                        Me.mUsuario.UpdateCancela(1)
                        MsgBox("Reactivacion correcta", MsgBoxStyle.Information, "Aviso")
                    End If
                Else
                    Me.mUsuario.UpdateCancela(0)
                    MsgBox("Cancelacion correcta", MsgBoxStyle.Information, "Aviso")
                End If
            End If
        End If
    End Sub

    Private Sub BTN_reporte_Click(sender As System.Object, e As System.EventArgs) Handles BTN_reporte.Click
        Dim dtDatos As New DataTable
        'LLena el data table 
        dtDatos = Me.mDepartamento.Rpt(0)
        If dtDatos.Rows.Count <> 0 Then
            'Asigno el nombre del reporte 
            Dim orptprueba As New RPT_usuario()
            'Le pasa el reporte al data table 
            orptprueba.SetDataSource(dtDatos)
            'LLamor reporte 
            Dim m As New FRM_reporte
            m.CrystalReportViewer1.ReportSource = orptprueba
            m.ShowDialog()
            ''Fin codigo nuevo
        Else
            MsgBox("No se encontro informacion para imprimir.. gracias", MsgBoxStyle.OkOnly)
        End If
        Me.Limpia()
        Me.TXT_id.Focus()
    End Sub

    Private Sub TXT_id_TextChanged(sender As System.Object, e As System.EventArgs) Handles TXT_id.TextChanged

    End Sub

    Private Sub TXT_id_Validated(sender As Object, e As System.EventArgs) Handles TXT_id.Validated
        If Me.TXT_id.Text <> "" And bnuevo <> True Then
            Me.mUsuario.IDUsuario = CInt(Me.TXT_id.Text)
            If Me.mUsuario.GetDB() Then
                Me.TXT_id.Text = Me.mUsuario.IDUsuario
                Me.TXT_nombre.Text = Me.mUsuario.Nombre
                Me.TXT_login.Text = Me.mUsuario.Login
                Me.TXT_password.Text = Me.mUsuario.Password

                Dim d = 0
                For d = 0 To Me.CB_departamento.Items.Count - 1
                    If Me.CB_departamento.Items(d)("IDDepartamento").ToString = Me.mUsuario.IDDepartamento Then
                        Me.CB_departamento.SelectedIndex = d
                    End If
                Next
                bnuevo = False
                Me.BTN_guarda.Enabled = True
                Me.BTN_elimina.Enabled = True
                Me.BTN_nuevo.Enabled = False
                Me.TXT_nombre.Focus()
            End If
        End If
    End Sub

#Region "GRID"
    Private Sub dgFormat()
        Me.DTG_usuario.DataSource = Me.mUsuario.Fill_Grid()
        Me.DTG_usuario.Refresh()
        Me.DTG_usuario.Focus()
    End Sub

    Private Sub DTG_usuario_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles DTG_usuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.KeyValue.ToString()
            Me.TXT_id.Text = Me.DTG_usuario.CurrentRow.Cells(0).Value
            Me.TXT_id_Validated(sender, e)
            bnuevo = False
            Me.BTN_guarda.Enabled = True
            Me.BTN_elimina.Enabled = True
            Me.BTN_nuevo.Enabled = False
        End If
    End Sub

#End Region


    
End Class