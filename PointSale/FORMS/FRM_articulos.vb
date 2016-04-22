Public Class FRM_articulos

    Dim mArticulo As New CLS_articulos
    Dim IdArticulo As Integer
    Dim Codigo As String
    Dim Descripcion As String
    Dim Precio As Double
    Dim Costo As Double
    Dim bnuevo As Boolean


    Private Sub FRM_articulos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Limpiar()
        Me.dgFormat()
    End Sub

    Private Sub Limpiar()
        Me.TXT_id.Text = ""
        Me.TXT_codigo.Text = ""
        Me.TXT_costo.Text = ""
        Me.TXT_descripcion.Text = ""
        Me.TXT_precio.Text = ""

        Me.BTN_nuevo.Enabled = True
        Me.BTN_eliminar.Enabled = False
        Me.BTN_guardar.Enabled = False
        bnuevo = False
    End Sub

#Region "Validacion de datos"

    'Validacion de TXT_id
    Private Sub TXT_id_Validated(sender As Object, e As System.EventArgs) Handles TXT_id.Validated
        If Me.TXT_id.Text <> "" And bnuevo <> True Then
            Me.mArticulo.IdArticulo = CInt(Me.TXT_id.Text)
            If Me.mArticulo.GetDB() Then
                Me.TXT_id.Text = Me.mArticulo.IdArticulo
                Me.TXT_codigo.Text = Me.mArticulo.Codigo
                Me.TXT_descripcion.Text = Me.mArticulo.Descripcion
                Me.TXT_precio.Text = Me.mArticulo.Precio
                Me.TXT_costo.Text = Me.mArticulo.Costo

                bnuevo = False
                Me.BTN_guardar.Enabled = True
                Me.BTN_eliminar.Enabled = True
                Me.BTN_nuevo.Enabled = False
                Me.TXT_codigo.Focus()
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

    Private Sub TXT_codigo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_codigo.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TXT_descripcion_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_descripcion.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TXT_precio_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_precio.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TXT_costo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_costo.KeyPress
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
        Me.mArticulo.New_IdArticulo()
        Me.TXT_id.Text = Me.mArticulo.IdArticulo
        Me.BTN_nuevo.Enabled = False
        Me.BTN_guardar.Enabled = True
        Me.BTN_eliminar.Enabled = True
        Me.TXT_codigo.Focus()
    End Sub

    'Guardar
    Private Sub BTN_guardar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_guardar.Click
        If Me.TXT_id.Text <> "" And Me.TXT_descripcion.Text <> "" And Me.TXT_codigo.Text <> "" And Me.TXT_costo.Text <> "" And Me.TXT_precio.Text <> "" Then
            Me.mArticulo.IdArticulo = CInt(Val(Me.TXT_id.Text))
            Me.mArticulo.Codigo = Me.TXT_codigo.Text
            Me.mArticulo.Descripcion = Me.TXT_descripcion.Text
            Me.mArticulo.Precio = CDbl(Val(Me.TXT_precio.Text))
            Me.mArticulo.Costo = CDbl(Val(Me.TXT_costo.Text))
            If bnuevo = True Then
                Me.mArticulo.Activo = 1
                Me.mArticulo.insertDB()
                MsgBox("Registro " & Me.TXT_id.Text & " Dado de Alta ", MsgBoxStyle.Information, "Aviso")
            Else
                Me.mArticulo.UpdateDB()
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

    'Eliminar
    Private Sub BTN_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_eliminar.Click
        If Me.TXT_id.Text <> "" Then
            Me.mArticulo.IdArticulo = CInt(Me.TXT_id.Text)
            Me.mArticulo.GetDB()
            If MsgBox("Desea Eliminar El Registro " & Me.TXT_codigo.Text, vbYesNo, "Confirmar") = vbYes Then
                If Me.mArticulo.Activo = 0 Then
                    If MsgBox("El Registro Esta Cancelado Desea Activarlo", vbYesNo, "Confirmar ") = vbYes Then
                        Me.mArticulo.UpdCancela(1)
                        MsgBox("Reactivacion Correcta", MsgBoxStyle.Information, "Aviso")
                    End If
                Else
                    Me.mArticulo.UpdCancela(0)
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
    Private Sub BTN_limpiar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_limpiar.Click
        Me.Limpiar()
    End Sub

    'Reporte
    Private Sub BTN_reporte_Click(sender As System.Object, e As System.EventArgs) Handles BTN_reporte.Click
        Dim dtDatos As New DataTable
        ''lleno el data table
        dtDatos = Me.mArticulo.Rpt(0)
        If dtDatos.Rows.Count <> 0 Then
            ''asigno el nombre del reporte
            Dim orptprueba As New RPT_articulo()
            ''le paso al reporte el data table
            orptprueba.SetDataSource(dtDatos)
            ''llamo reporte
            Dim m As New FRM_reporte
            m.CrystalReportViewer1.ReportSource = orptprueba
            m.ShowDialog()
            ''fin codigo nvo
        Else
            MsgBox("No se Encontro Informacion para Imprimir.. gracias.", MsgBoxStyle.OkOnly)
        End If
        Me.Limpiar()
        Me.TXT_id.Focus()
    End Sub

    'Exportar
    Private Sub BTN_exportar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_exportar.Click
        FRM_exportar.Load_Data(DGV_articulo)
    End Sub

    'Salir
    Private Sub BTN_salir_Click(sender As System.Object, e As System.EventArgs) Handles BTN_salir.Click
        Me.Close()
    End Sub
#End Region

#Region "Grid"
    Private Sub dgFormat()
        Me.DGV_articulo.DataSource = Me.mArticulo.Fill_Grid()
        Me.DGV_articulo.Refresh()
        DGV_articulo.Focus()
    End Sub

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