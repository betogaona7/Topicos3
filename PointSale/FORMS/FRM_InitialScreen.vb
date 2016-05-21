Imports System.Windows.Forms

Public Class FRM_InitialScreen

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    

    

    '-------------------------------------------------------------------
    Private Sub CloseWindows()
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next
        FRM_welcome.MdiParent = Me
        FRM_welcome.Dock = DockStyle.Fill
        FRM_welcome.Show()
    End Sub

    Private Sub FRM_InitialScreen_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub FRM_InitialScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FRM_welcome.MdiParent = Me
        FRM_welcome.Dock = DockStyle.Fill
        FRM_welcome.Show()
    End Sub

    Private Sub TSM_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSM_cliente.Click
        Me.CloseWindows()
        FRM_proveedor.MdiParent = Me
        FRM_proveedor.Dock = DockStyle.Fill
        FRM_proveedor.Show()
    End Sub

    Private Sub TSM_articulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSM_articulo.Click
        Me.CloseWindows()
        FRM_articulos.MdiParent = Me
        FRM_articulos.Dock = DockStyle.Fill
        FRM_articulos.Show()
    End Sub

    Private Sub TSM_orden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSM_orden.Click
        Me.CloseWindows()
        FRM_ordencompra.MdiParent = Me
        FRM_ordencompra.Dock = DockStyle.Fill
        FRM_ordencompra.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        Me.CloseWindows()
        FRM_usuario.MdiParent = Me
        FRM_usuario.Dock = DockStyle.Fill
        FRM_usuario.Show()
    End Sub
End Class
