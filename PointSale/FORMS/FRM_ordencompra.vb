Public Class FRM_ordencompra
    Dim mProveedor As New CLS_proveedor
    Dim mArticulo As New CLS_articulos
    Dim mOrden As New CLS_ordencompra

    'Variables de trabajo
    Dim bnuevo As Boolean
    Dim wIdProveedor As Integer
    Dim wBusca As Integer
    Dim DTG As New DataTable
    Dim WtxtTotal As Double
    Dim WtxtIva As Double
    Dim WtxtTotalOrd As Double
    Dim WtxtDescuento As Double
    Dim wIVA As Integer = 16
    Dim dtDatos As New DataTable

    Private Sub FRM_ordencompra_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.CreaDTOrd()
        Me.Limpia()
        Me.TXT_rfc.Focus()
    End Sub

    Private Sub Limpia()
        Me.TXT_rfc.Text = ""
        Me.TXT_nombre.Text = ""
        Me.TXT_calle.Text = ""
        Me.TXT_colonia.Text = ""
        Me.TXT_numero.Text = ""
        Me.wIdProveedor = 0
        Me.LBL_fecha1.Text = Today()
        Me.wBusca = 0
    End Sub

    Private Sub LimpiarArticulo()
        Me.TXT_codigo.Text = ""
        Me.TXT_descripcion.Text = ""
        Me.TXT_precio.Text = ""
        Me.TXT_cantidad.Text = ""
        Me.TXT_importe.Text = ""
    End Sub

#Region "Grid"
    'Formatear Grid
    Private Sub dgFormat()
        Me.DGV_orden.DataSource = DTG
        Me.DGV_orden.Columns(0).HeaderText = "Codigo"
        Me.DGV_orden.Columns(1).HeaderText = "Descripcion"
        Me.DGV_orden.Columns(2).HeaderText = "Cantidad"
        Me.DGV_orden.Columns(3).HeaderText = "Precio"
        Me.DGV_orden.Columns(4).HeaderText = "Importe"
        Me.DGV_orden.Columns(5).HeaderText = "IdArticulo"
        ' '*********
        Me.DGV_orden.Columns(2).DefaultCellStyle.Format = "n"
        Me.DGV_orden.Columns(3).DefaultCellStyle.Format = "n"
        Me.DGV_orden.Columns(4).DefaultCellStyle.Format = "n"
        Me.DGV_orden.Columns(5).DefaultCellStyle.Format = "n"
        ' '**************
        Me.DGV_orden.Columns(0).Width = 80
        Me.DGV_orden.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGV_orden.Columns(1).Width = 150
        Me.DGV_orden.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DGV_orden.Columns(2).Width = 65
        Me.DGV_orden.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGV_orden.Columns(3).Width = 80
        Me.DGV_orden.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DGV_orden.Columns(4).Width = 75
        Me.DGV_orden.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DGV_orden.Columns(5).Width = 90
        Me.DGV_orden.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        ' '**************
        Me.DGV_orden.Columns(5).Visible = False
        Me.DGV_orden.Refresh()
        'Me.DGV_orden.Focus()
    End Sub

    'Key Down
    Private Sub DGV_orden_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles DGV_orden.KeyDown
        If e.KeyCode = Keys.Delete Then
            e.KeyValue.ToString()
            If MsgBox("Desea eliminar el registro ", vbYesNo, "Confirmar") = vbYes Then
                DGV_orden.Rows.Remove(DGV_orden.CurrentRow)
                Me.dgFormat()
                Me.LimpiarArticulo()
                Me.SumGrid()
                Me.TXT_codigo.Focus()
            End If
        End If
    End Sub
#End Region

#Region "Botones"
    'F2_rfc
    Private Sub BTN_F2rfc_Click(sender As System.Object, e As System.EventArgs) Handles BTN_F2rfc.Click
        GIdCliente = 0
        FRM_buscaProveedor.ShowDialog()
        If GIdCliente <> 0 Then
            Me.mProveedor.IdProveedor = GIdCliente
            If Me.mProveedor.GetDB() Then
                Me.pasadatos()
                Me.TXT_codigo.Focus()
            End If
        Else
            Me.TXT_rfc.Focus()
        End If
    End Sub

    'F2_codigo
    Private Sub BTN_F2codigo_Click(sender As System.Object, e As System.EventArgs) Handles BTN_F2codigo.Click
        GIdArticulo = 0
        FRM_buscaArticulo.ShowDialog()
        If GIdArticulo <> 0 Then
            Me.mArticulo.IdArticulo = GIdArticulo
            If Me.mArticulo.GetDB() Then
                Me.TXT_codigo.Text = Me.mArticulo.Codigo
                Me.TXT_descripcion.Text = Me.mArticulo.Descripcion
                Me.TXT_precio.Text = Me.mArticulo.Precio
            End If
        End If
    End Sub

    'ok
    Private Sub BTN_ok_Click(sender As System.Object, e As System.EventArgs) Handles BTN_ok.Click
        Me.AddRow()
        Me.dgFormat()
        Me.LimpiarArticulo()
        Me.SumGrid()
        Me.TXT_codigo.Focus()
    End Sub

    'Nuevo
    Private Sub BTN_nuevo_Click(sender As System.Object, e As System.EventArgs) Handles BTN_nuevo.Click
        bnuevo = True
        Me.mOrden.New_IdOrden()
        Me.LBL_folio.Text = Me.mOrden.CteOrdFolio
    End Sub

    'Guardar
    Private Sub BTN_guardar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_guardar.Click
        If Me.TXT_rfc.Text <> "" Then
            Me.SumGrid()
            'Paso los conceptos de la factura
            Me.mOrden.IdProveedor = CInt(Me.mProveedor.IdProveedor)
            Me.mOrden.Importe = CDbl((Val(WtxtTotal) - CDbl(Val(WtxtDescuento))) + CDbl(Val(WtxtIva)))
            Me.mOrden.Total = CDbl((Val(WtxtTotal) - CDbl(Val(WtxtDescuento))) + CDbl(Val(WtxtIva)))
            Me.mOrden.Bonificacion = CDbl(Val(WtxtDescuento))
            Me.mOrden.Impuesto = Val(WtxtIva)
            Me.mOrden.FechaOrden = Today
            Me.mOrden.WDTDetalle = Me.DTG
            Me.mOrden.ProcesaVenta()
            MsgBox("Orden generada con exito...-", MsgBoxStyle.OkOnly)
            dtDatos = Me.mOrden.Rpt(Me.mOrden.IdCteOrden)
            ''asigno el nombre del reporte
            Dim orptprueba As New RPT_orden
            '' le paso al reporte el data table
            orptprueba.SetDataSource(dtDatos)
            ''llamo reporte
            FRM_reporte.CrystalReportViewer1.ReportSource = orptprueba
            FRM_reporte.ShowDialog()
            Me.Limpia()
            Me.TXT_rfc.Focus()
            Me.BTN_salir_Click(sender, e)
        Else
            MsgBox("Favor de seleccionar un proveedor...", MsgBoxStyle.OkOnly)
        End If
    End Sub

    'Salir
    Private Sub BTN_salir_Click(sender As System.Object, e As System.EventArgs) Handles BTN_salir.Click
        Me.Close()
    End Sub
#End Region

#Region "Operaciones"

    Private Sub pasadatos()
        Me.wIdProveedor = Me.mProveedor.IdProveedor
        Me.TXT_rfc.Text = Me.mProveedor.RFC
        Me.TXT_calle.Text = Me.mProveedor.Calle
        Me.TXT_colonia.Text = Me.mProveedor.Colonia
        Me.TXT_nombre.Text = Me.mProveedor.Nombre
        Me.TXT_numero.Text = Me.mProveedor.Numero
    End Sub

    Private Sub Calc_Importe()
        Me.TXT_importe.Text = Val(Me.TXT_cantidad.Text) * Val(Me.TXT_precio.Text)
        Me.TXT_importe.Text = FormatNumber(Me.TXT_importe.Text, 2)
    End Sub

    Private Sub CreaDTOrd()
        If DTG.Columns.Count > 0 Then
            DTG.Clear()
        Else
            DTG.Columns.Add(New DataColumn("COD"))
            DTG.Columns.Add(New DataColumn("DES"))
            DTG.Columns.Add(New DataColumn("CANT"))
            DTG.Columns.Add(New DataColumn("PRECIO"))
            DTG.Columns.Add(New DataColumn("IMPORTE"))
            DTG.Columns.Add(New DataColumn("IDARTICULO"))
        End If
    End Sub

    Private Function BuscaRow(ByVal wCve As Integer) As Boolean
        BuscaRow = False
        For Each row As DataGridViewRow In Me.DGV_orden.Rows
            If wCve = row.Cells(5).Value Then
                BuscaRow = True
                Exit Function
            End If
        Next
        'end if
    End Function

    Private Sub SumGrid()
        Me.TXT_total.Text = 0.0
        Me.TXT_descuento.Text = 0.0
        Me.TXT_subtotal.Text = 0.0
        Me.WtxtTotal = 0.0
        Me.WtxtIva = 0.0
        Me.WtxtTotalOrd = 0.0
        For Each row As DataGridViewRow In Me.DGV_orden.Rows
            Me.TXT_total.Text = Val(Me.TXT_total.Text) + row.Cells(4).Value
            Me.WtxtTotal = Val(Me.TXT_total.Text) + row.Cells(4).Value
        Next
        Me.TXT_descuento.Text = ((Val(Me.WtxtTotal) - (Val(Me.WtxtDescuento))) * Val(wIVA)) / 100
        Me.WtxtIva = ((Val(Me.WtxtTotal) - (Val(Me.WtxtDescuento))) * Val(wIVA)) / 100
        Me.TXT_total.Text = (Val(Me.WtxtTotal) - (Val(Me.WtxtDescuento))) + Val(Me.TXT_descuento.Text)
        Me.WtxtTotalOrd = (Val(Me.WtxtTotal) - (Val(Me.WtxtDescuento))) + Val(Me.TXT_descuento.Text)
        Me.TXT_descuento.Text = FormatNumber(Me.TXT_descuento.Text, 2)
        Me.TXT_total.Text = FormatNumber(Me.TXT_total.Text, 2)
    End Sub

    Private Sub addRow()
        Dim wImporte As Double
        If BuscaRow(Me.TXT_codigo.Text) = False And Val(TXT_importe.Text) > 0 Then
            Dim Row As DataRow = DTG.NewRow
            Dim nRow As Integer = 0
            Row("COD") = Me.TXT_codigo.Text
            Row("DES") = Me.TXT_descripcion.Text
            Row("CANT") = Me.TXT_cantidad.Text
            Row("PRECIO") = Me.TXT_precio.Text
            wImporte = (Val(Me.TXT_precio.Text) * Val(Me.TXT_cantidad.Text))
            Row("IMPORTE") = Me.TXT_importe.Text
            Row("IDARTICULO") = Me.mArticulo.IdArticulo
            DTG.Rows.Add(Row)
            dgFormat()
        Else
            MsgBox("Cantidad no valida ó codigo duplicado", MsgBoxStyle.OkOnly)
            Me.TXT_codigo.Focus()
        End If
    End Sub

    Private Sub PasaArticulo()
        Me.TXT_codigo.Text = Me.mArticulo.Codigo
        Me.TXT_descripcion.Text = Me.mArticulo.Descripcion
        Me.TXT_precio.Text = Me.mArticulo.Precio
    End Sub
#End Region

#Region "Validacion de campos"
    Private Sub TXT_rfc_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_rfc.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TXT_rfc_Validated(sender As Object, e As System.EventArgs) Handles TXT_rfc.Validated
        If Me.TXT_rfc.Text <> "" Then
            Me.mProveedor.RFC = Me.TXT_rfc.Text
            If Me.mProveedor.GetDB() Then
                Me.pasadatos()
                Me.TXT_codigo.Focus()
            End If
        End If
    End Sub

    Private Sub TXT_codigo_Validated(sender As Object, e As System.EventArgs) Handles TXT_codigo.Validated
        If Me.TXT_codigo.Text <> "" Then
            Me.mArticulo.Codigo = Me.TXT_codigo.Text
            If Me.mArticulo.GetDB() Then
                Me.PasaArticulo()
                Me.TXT_cantidad.Focus()
            End If
            MsgBox("Codigo no Existe...", MsgBoxStyle.OkOnly)
            Me.TXT_codigo.Focus()
        End If
    End Sub

    Private Sub TXT_cantidad_Validated(sender As Object, e As System.EventArgs) Handles TXT_cantidad.Validated
        If Val(Me.TXT_cantidad.Text) > 0 Then
            Me.Calc_Importe()
        Else
            MsgBox("Cantidad no puede ser cero..", MsgBoxStyle.Information, "Aviso")
            Me.TXT_codigo.Focus()
        End If
    End Sub

    Private Sub TXT_descuento_Validated(sender As Object, e As System.EventArgs) Handles TXT_descuento.Validated
        If Val(Me.TXT_descuento.Text) > Val(Me.TXT_total.Text) Then
            MsgBox("!! ojo bonificacion no puede ser mayor al importe de la orden !! ... ( !", MsgBoxStyle.OkOnly)
            Me.TXT_descuento.Focus()
        End If
        Me.WtxtDescuento = Val(Me.TXT_descuento.Text)
        Me.SumGrid()
        Me.BTN_guardar.Focus()
    End Sub
#End Region

End Class