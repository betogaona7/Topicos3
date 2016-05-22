Public Class FRM_proveedor

    Dim mProveedor As New CLS_proveedor

    Dim IdProveedor As Integer
    Dim Nombre As String
    Dim RFC As String
    Dim Calle As String
    Dim Numero As Integer
    Dim CodigoPostal As String
    Dim Colonia As String
    Dim Ciudad As String
    Dim Estado As String

    Dim bnuevo As Boolean

    Private Sub FRM_proveedor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Limpia()
        Me.dgFormat()
    End Sub

    Private Sub Limpia()
        Me.TXT_id.Text = ""
        Me.TXT_nombre.Text = ""
        Me.TXT_rfc.Text = ""
        Me.TXT_calle.Text = ""
        Me.TXT_numero.Text = ""
        Me.TXT_cp.Text = ""
        Me.TXT_colonia.Text = ""
        Me.TXT_ciudad.Text = ""
        Me.TXT_estado.Text = ""

        Me.BTN_nuevo.Enabled = True
        Me.BTN_eliminar.Enabled = False
        Me.BTN_guardar.Enabled = False
        bnuevo = False
    End Sub

#Region "Validacion de campos"

    'Validacion de TXT_id
    Private Sub TXT_id_Validated(sender As Object, e As System.EventArgs) Handles TXT_id.Validated
        If Me.TXT_id.Text <> "" And bnuevo <> True Then
            Me.mProveedor.IdProveedor = CInt(Me.TXT_id.Text)
            If Me.mProveedor.GetDB() Then
                Me.TXT_id.Text = Me.mProveedor.IdProveedor
                Me.TXT_nombre.Text = Me.mProveedor.Nombre
                Me.TXT_rfc.Text = Me.mProveedor.RFC
                Me.TXT_calle.Text = Me.mProveedor.Calle
                Me.TXT_numero.Text = Me.mProveedor.Numero
                Me.TXT_cp.Text = Me.mProveedor.CodigoPostal
                Me.TXT_colonia.Text = Me.mProveedor.Colonia
                Me.TXT_ciudad.Text = Me.mProveedor.Ciudad
                Me.TXT_estado.Text = Me.mProveedor.Estado

                bnuevo = False
                Me.BTN_guardar.Enabled = True
                Me.BTN_eliminar.Enabled = True
                Me.BTN_nuevo.Enabled = False

                Me.TXT_nombre.Focus()
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

    Private Sub TXT_rfc_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_rfc.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TXT_calle_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_calle.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TXT_numero_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_numero.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TXT_cp_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_cp.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TXT_colonia_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_colonia.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TXT_estado_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_estado.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TXT_ciudad_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_ciudad.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
#End Region

#Region "Botones"
    'nuevo
    Private Sub BTN_nuevo_Click(sender As System.Object, e As System.EventArgs) Handles BTN_nuevo.Click
        Me.Limpia()

        bnuevo = True
        Me.mProveedor.New_IdProveedor()
        Me.TXT_id.Text = Me.mProveedor.IdProveedor

        Me.BTN_nuevo.Enabled = False
        Me.BTN_guardar.Enabled = True
        Me.BTN_eliminar.Enabled = True
        Me.TXT_nombre.Focus()
    End Sub

    'Guardar
    Private Sub BTN_guardar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_guardar.Click
        If Me.TXT_id.Text <> "" And Me.TXT_nombre.Text <> "" And Me.TXT_rfc.Text <> "" And Me.TXT_calle.Text <> "" And Me.TXT_numero.Text <> "" And Me.TXT_cp.Text <> "" And Me.TXT_colonia.Text <> "" And Me.TXT_ciudad.Text <> "" And Me.TXT_estado.Text <> "" Then
            Me.mProveedor.IdProveedor = CInt(Val(Me.TXT_id.Text))
            Me.mProveedor.Nombre = Me.TXT_nombre.Text
            Me.mProveedor.RFC = Me.TXT_rfc.Text
            Me.mProveedor.Calle = Me.TXT_calle.Text
            Me.mProveedor.Numero = CInt(Val(Me.TXT_numero.Text))
            Me.mProveedor.CodigoPostal = Me.TXT_cp.Text
            Me.mProveedor.Colonia = Me.TXT_colonia.Text
            Me.mProveedor.Ciudad = Me.TXT_ciudad.Text
            Me.mProveedor.Estado = Me.TXT_estado.Text
            If bnuevo = True Then
                Me.mProveedor.Activo = 1
                Me.mProveedor.insertDB()
                MsgBox("Registro " & Me.TXT_id.Text & " Dado de Alta ", MsgBoxStyle.Information, "Aviso")
            Else
                Me.mProveedor.UpdateDB()
                MsgBox("Registro " & Me.TXT_id.Text & " Actualizado ", MsgBoxStyle.Information, "Aviso")
            End If
        End If
        Me.Limpia()

        bnuevo = False
        Me.BTN_nuevo.Enabled = True
        Me.BTN_eliminar.Enabled = False
        Me.BTN_guardar.Enabled = False

        Me.dgFormat()
        Me.TXT_id.Focus()
    End Sub

    'Eliminar
    Private Sub BTN_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_eliminar.Click
        If Me.TXT_id.Text <> "" Then
            Me.mProveedor.IdProveedor = CInt(Me.TXT_id.Text)
            Me.mProveedor.GetDB()
            If MsgBox("Desea Eliminar El Registro " & Me.TXT_nombre.Text, vbYesNo, "Confirmar") = vbYes Then
                If Me.mProveedor.Activo = 0 Then
                    If MsgBox("El Registro Esta Cancelado Desea Activarlo", vbYesNo, "Confirmar ") = vbYes Then
                        Me.mProveedor.UpdCancela(1)
                        MsgBox("Reactivación Correcta", MsgBoxStyle.Information, "Aviso")
                    End If
                Else
                    Me.mProveedor.UpdCancela(0)
                    MsgBox("Cancelación Correcta", MsgBoxStyle.Information, "Aviso")
                End If
            End If
        Else
            MsgBox("Favor De Seleccionar Un Registo", MsgBoxStyle.Information, "Aviso")
        End If
        Me.Limpia()
        Me.dgFormat()
        Me.TXT_id.Focus()
    End Sub

    'Limpiar
    Private Sub BTN_limpiar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_limpiar.Click
        Me.Limpia()
    End Sub

    'Reporte
    Private Sub BTN_reporte_Click(sender As System.Object, e As System.EventArgs) Handles BTN_reporte.Click
        Dim dtDatos As New DataTable
        ''lleno el data table
        dtDatos = Me.mProveedor.Rpt(0)
        If dtDatos.Rows.Count <> 0 Then
            ''asigno el nombre del reporte
            Dim orptprueba As New RPT_proveedor()
            ''le paso al reporte el data table
            orptprueba.SetDataSource(dtDatos)
            ''llamo reporte
            Dim m As New FRM_reporte
            m.CrystalReportViewer1.ReportSource = orptprueba
            m.ShowDialog()
            ''fin codigo nvo
        Else
            MsgBox("No se Encontro Información para Imprimir.. gracias.", MsgBoxStyle.OkOnly)
        End If
        Me.Limpia()
        Me.TXT_id.Focus()
    End Sub

    'Salir
    Private Sub BTN_salir_Click(sender As System.Object, e As System.EventArgs) Handles BTN_salir.Click
        Me.Close()
    End Sub
#End Region

#Region "Grid"

    Private Sub dgFormat()
        Me.DGV_proveedor.DataSource = Me.mProveedor.Fill_Grid()
        Me.DGV_proveedor.Refresh()
        DGV_proveedor.Focus()
    End Sub

    Private Sub DGV_proveedor_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles DGV_proveedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.KeyValue.ToString()
            Me.TXT_id.Text = Me.DGV_proveedor.CurrentRow.Cells(0).Value
            Me.TXT_id_Validated(sender, e)
            bnuevo = False
            Me.BTN_guardar.Enabled = True
            Me.BTN_nuevo.Enabled = False
        End If
    End Sub
#End Region

End Class