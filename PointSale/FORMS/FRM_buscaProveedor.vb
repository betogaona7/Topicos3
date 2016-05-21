Public Class FRM_buscaProveedor

    Dim mProveedor As New CLS_proveedor

    Private Sub FRM_buscaProveedor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Limpia()
        Me.dgFormat()
    End Sub

    Private Sub Limpia()
        Me.TXT_proveedor.Text = ""
        Me.dgFormat()
    End Sub

#Region "grid"
    Private Sub dgFormat()
        Me.mProveedor.Nombre = Me.TXT_proveedor.Text
        Me.DGV_bProveedor.DataSource = Me.mProveedor.Fill_Grid(2)
        Me.DGV_bProveedor.Columns(0).HeaderText = "Id"
        Me.DGV_bProveedor.Columns(1).HeaderText = "Nombre"
        Me.DGV_bProveedor.Columns(2).HeaderText = "Calle"
        Me.DGV_bProveedor.Columns(3).HeaderText = "Numero"
        Me.DGV_bProveedor.Columns(4).HeaderText = "Colonia"
        Me.DGV_bProveedor.Columns(5).HeaderText = "Estado"
        Me.DGV_bProveedor.Columns(6).HeaderText = "Municipio"
        Me.DGV_bProveedor.Columns(7).HeaderText = "Ciudad"
        Me.DGV_bProveedor.Columns(8).HeaderText = "Codigo P"
        Me.DGV_bProveedor.Columns(9).HeaderText = "Activo"
        Me.DGV_bProveedor.Columns(0).Visible = False
        Me.DGV_bProveedor.Columns(1).Width = 150
        Me.DGV_bProveedor.Columns(2).Width = 100
        Me.DGV_bProveedor.Columns(3).Width = 50
        Me.DGV_bProveedor.Columns(4).Width = 100
        Me.DGV_bProveedor.Columns(5).Width = 100
        Me.DGV_bProveedor.Refresh()
    End Sub

    Private Sub DGV_bProveedor_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles DGV_bProveedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.KeyValue.ToString()
            GIdCliente = CInt(Val(Me.DGV_bProveedor.CurrentRow.Cells(0).Value))
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
    Private Sub TXT_proveedor_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_proveedor.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
#End Region

    
End Class