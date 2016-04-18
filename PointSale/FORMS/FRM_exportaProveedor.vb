Imports System.Data
Imports System.IO

Public Class FRM_exportaProveedor

    Private Sub FRM_exportaProveedor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Load_Data(ByVal DG1 As DataGridView)
        GridAExcel(DG1)
        Me.Close()
    End Sub

#Region "Botones"
    Private Sub btnExporta_Click(sender As System.Object, e As System.EventArgs) Handles btnExporta.Click
        Close()
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        GridAExcel(dg1)
    End Sub
#End Region

#Region "Operaciones"
    Function GridAExcel(ByVal ElGrid As DataGridView) As Boolean
        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As New Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As New Microsoft.Office.Interop.Excel.Worksheet
        Try
            'añadimos el libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            'exHoja = exLibro.worksheet.add()
            'la siguente linea la pusimos para que usa la hoja 1
            exHoja = exLibro.Worksheets._Default(1)
            '
            '¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount
            'aqui recorremos todas las filas, y por cada fila todas las colmnas y vamos escribiendo
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).Name.ToString
                'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            Next
            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value
                Next
            Next
            'Titulo en negrita, alineado al centro y que el tamaño de a columna seajuste al texto
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()
            'aplicacion visible
            exApp.Application.Visible = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            Return False
        End Try
        Return True
    End Function
#End Region

End Class