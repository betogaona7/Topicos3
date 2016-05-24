Public Class FRM_buscaArticulo

    Dim mArticulo As New CLS_articulos

    Private Sub FRM_buscaArticulo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Limpia()
        Me.dgFormat()
    End Sub

    Private Sub Limpia()
        Me.TXT_articulo.Text = ""
        Me.dgFormat()
    End Sub

#Region "Grid"
    Private Sub dgFormat()
        Me.DGV_bArticulo.DataSource = Me.mArticulo.Fill_Grid(1, Me.TXT_articulo.Text)
        Me.DGV_bArticulo.Columns(0).HeaderText = "Id"
        Me.DGV_bArticulo.Columns(1).HeaderText = "Codigo"
        Me.DGV_bArticulo.Columns(2).HeaderText = "Descripcion"
        Me.DGV_bArticulo.Columns(3).HeaderText = "Precio"
        Me.DGV_bArticulo.Columns(4).HeaderText = "Costo"
        Me.DGV_bArticulo.Columns(5).HeaderText = "Activo"

        Me.DGV_bArticulo.Columns(0).Visible = False
        Me.DGV_bArticulo.Columns(1).Width = 50
        Me.DGV_bArticulo.Columns(2).Width = 150
        Me.DGV_bArticulo.Columns(3).Width = 50
        Me.DGV_bArticulo.Columns(4).Width = 50
        Me.DGV_bArticulo.Columns(5).Width = 80
        Me.DGV_bArticulo.Refresh()
    End Sub

    Private Sub DGV_bArticulo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles DGV_bArticulo.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.KeyValue.ToString()
            GIdArticulo = CInt(Val(Me.DGV_bArticulo.CurrentRow.Cells(0).Value))
            Me.Close()
        End If
    End Sub
#End Region

#Region "Botones"
    Private Sub BTN_filtrar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_filtrar.Click
        Me.dgFormat()
    End Sub

    Private Sub BTN_salir_Click(sender As System.Object, e As System.EventArgs) Handles BTN_salir.Click
        Me.Close()
    End Sub
#End Region

#Region "Validacion de campos"
    Private Sub TXT_articulo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_articulo.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        Else
            e.Handled = mGeneral.ValidaMayusculas(e.KeyChar)
        End If
    End Sub
#End Region

End Class