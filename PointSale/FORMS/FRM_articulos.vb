Public Class FRM_articulos

    Dim bnuevo As Boolean

    Private Sub FRM_articulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Limpiar()
        Me.dgFormat()
    End Sub

    Private Sub Limpiar()
        Me.TXT_id.Text = ""
        Me.TXT_articulo.Text = ""
        Me.BTN_nuevo.Enabled = True
        Me.BTN_eliminar.Enabled = False
        Me.BTN_guardar.Enabled = False
        bnuevo = False
    End Sub


#Region "Validacion de campos"
    'Validacion de ID articulo 
    Private Sub TXT_id_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_id.Validated
        If Me.TXT_id.Text <> "" And bnuevo <> True Then
            Me.mDepartamento.IdDepartamento = CInt(Me.TXT_id.Text)
            If Me.mDepartamento.GetDB() Then
                Me.TXT_id.Text = Me.mDepartamento.IdDepartamento
                Me.TXT_articuloText = Me.mDepartamento.Departamento
                bnuevo = False
                Me.BTN_guardar.Enabled = True
                Me.BTN_eliminar.Enabled = True
                Me.BTN_nuevo.Enabled = False
                Me.TXT_articulo.Focus()
            Else
                MsgBox("Registro no existe... ", MsgBoxStyle.Information, "Aviso")
            End If
        End If
    End Sub

    'Validacion de Id articulo Key press 
    Private Sub TXT_id_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_id.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    'Validacion de TXT_articulo keypress
    Private Sub TXT_articulo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_articulo.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
#End Region

#Region "Botones"
    Private Sub BTN_nuevo_Click(sender As System.Object, e As System.EventArgs) Handles BTN_nuevo.Click
        Me.Limpiar()
        bnuevo = True
        Me.mDepartamento.New_IdDepartamento()
        Me.TXT_id.Text = Me.mDepartamento.IdDepartamento
        Me.BTN_nuevo.Enabled = False
        Me.BTN_guardar.Enabled = True
        Me.BTN_eliminar.Enabled = True
        Me.TXT_articulo.Focus()
    End Sub

    Private Sub BTN_guardar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_guardar.Click
        If Me.TXT_id.Text <> "" And Me.TXT_articulo.Text <> "" Then
            Me.mDepartamento.IdDepartamento = CInt(Val(Me.TXT_id.Text))
            Me.mDepartamento.Departamento = Me.TXT_articulo.Text
            If bnuevo = True Then
                Me.mDepartamento.Activo = 1
                Me.mDepartamento.insertDB()
                MsgBox("Registro " & Me.TXT_id.Text & " Dado de Alta ", MsgBoxStyle.Information, "Aviso")
            Else
                Me.mDepartamento.UpdateDB()
                MsgBox("Registro" & Me.TXT_id.Text & " Actualizado ", MsgBoxStyle.Information, "Aviso")
            End If
        End If
        Me.Limpiar()
        bnuevo = False
        Me.BTN_nuevo.Enabled = True
        Me.BTN_eliminar.Enabled = False
        Me.BTN_guardar.Enabled = False
        Me.dgFormat()
        Me.TXT_id.Focus()
    End Sub

    Private Sub BTN_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_eliminar.Click
        If Me.TXT_id.Text <> "" Then
            Me.mDepartamento.IdDepartamento = CInt(Me.TXT_id.Text)
            Me.mDepartamento.GetDB()
            If MsgBox("Desea Eliminar El Registro " & Me.TXT_articulo.Text, vbYesNo, "Confirmar") = vbYes Then
                If Me.mDepartamento.Activo = 0 Then
                    If MsgBox("El Registro Esta Cancelado, Desea Activarlo", vbYesNo, "Confirmar") = vbYes Then
                        Me.mDepartamento.UpdateCancela(1)
                        MsgBox("Reactivacion Correcta", MsgBoxStyle.Information, "Aviso")
                    End If
                Else
                    Me.mDepartamento.UpdateCancela(0)
                    MsgBox("Cancelacion Correcta", MsgBoxStyle.Information, "Aviso")
                End If
            End If
        Else
            MsgBox("Favor De Seleccionar Un Registo", MsgBoxStyle.Information, "Aviso")
        End If
        Limpiar()
        dgFormat()
    End Sub

    Private Sub BTN_limpiar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_limpiar.Click
        Me.Limpiar()
    End Sub

    Private Sub BTN_reporte_Click(sender As System.Object, e As System.EventArgs) Handles BTN_reporte.Click
        Dim dtDatos As New DataTable
        'LLena el data table 
        dtDatos = Me.mDepartamento.Rpt(0)
        If dtDatos.Rows.Count <> 0 Then
            'Asigno el nombre del reporte 
            Dim orptprueba As New RPT_departamento
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
        Me.Limpiar()
        Me.TXT_id.Focus()
    End Sub

    Private Sub BTN_exportar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_exportar.Click
        'frmExporta.Load_Data(DGV_departamento)
    End Sub

    Private Sub BTN_salir_Click(sender As System.Object, e As System.EventArgs) Handles BTN_salir.Click
        Me.Close()
    End Sub
#End Region

#Region "Gid"
    Private Sub dgFormat()
        Me.DGV_articulo.DataSource = Me.mDepartamento.Fill_Grid()
        Me.DGV_articulo.Refresh()
        'Me.DGV_departamento.Columns(0).HeaderText = "Id"
        'Me.DGV_departamento.Columns(1).HeaderText = "Nombre"
        'Me.DGV_departamento.Columns(0).Visible = False
        'Me.DGV_departamento.Columns(0).Width = 30
        'Me.DGV_departamento.Columns(1).Width = 220
        'Me.DGV_departamento.Columns(2).Visible = False
        'Me.DGV_departamento.Columns(7).Visible = False
        Me.DGV_articulo.Focus()
    End Sub

    'Selecciona el registro marcado del grid
    Private Sub DGV_articulo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles DGV_articulo.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.KeyValue.ToString()
            Me.TXT_id.Text = Me.DGV_articulo.CurrentRow.Cells(0).Value
            Me.TXT_id_Validated(sender, e)
            bnuevo = False
            Me.BTN_guardar.Enabled = True
            Me.BTN_nuevo.Enabled = False
        End If
    End Sub
#End Region

    
End Class