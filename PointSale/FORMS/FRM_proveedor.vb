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

#Region "Botones"
    Private Sub BTN_nuevo_Click(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub BTN_guardar_Click(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub BTN_eliminar_Click(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub BTN_limpiar_Click(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub BTN_reporte_Click(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub BTN_exportar_Click(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub BTN_salir_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    
#End Region
End Class