Public Class CLS_ordencompra

#Region "Declaracion de variables"
    'variables de conexion DB'
    Dim xCnx As New dbSQL
    Dim StrSql As String
    Dim xDS As New DataSet
    Dim xDT As New DataTable

    'atributos de la clase'
    Private _IdOrden As Integer
    Private _IdProveedor As Integer
    Private _Folio As String
    Private _FechaOrden As String
    Private _SubTotal As Double
    Private _Descuento As Double
    Private _Impuesto As Double
    Private _Total As Double
    Private _Cancela As Integer
    Private _FechaDeCancelado As String
    Dim N_Tabla As String = "OdeC"

    'Variables de detalle
    Private _IdOrdenDetalle As Integer
    Private _IdArticulo As Integer
    Private _Cantidad As Integer
    Private _Precio As Double
    Private _Concepto As String

    'Variables de trabajo
    Dim i As Integer
    Dim row As DataRow
    Private _OrdDetalle As DataTable
    Private _OrdADetalle As DataTable
    Private _WTotalCte As Double

    'Campos de detalle 
    Private _IdODetalle As Integer
    Private _IdODIdArticulo As Integer
    Private _IdODCantidad As Integer
    Private _IdODPrecio As Double
    Private _IdODConcepto As String

    Private _WDTDetalle As DataTable
#End Region

#Region "Propiedades"
    'IdOdeC'
    Public Property IdCteOrden() As Integer
        Get
            Return _IdOrden
        End Get
        Set(ByVal value As Integer)
            _IdOrden = value
        End Set
    End Property
    'IdProveedor'
    Public Property IdProveedor() As Integer
        Get
            Return _IdProveedor
        End Get
        Set(ByVal value As Integer)
            _IdProveedor = value
        End Set
    End Property
    'Folio'
    Public Property CteOrdFolio() As String
        Get
            Return _Folio
        End Get
        Set(ByVal value As String)
            _Folio = value
        End Set
    End Property
    'FechaOrder
    Public Property FechaOrden() As String
        Get
            Return _FechaOrden
        End Get
        Set(ByVal value As String)
            _FechaOrden = value
        End Set
    End Property
    'SubTotal
    Public Property Importe() As Double
        Get
            Return _SubTotal
        End Get
        Set(ByVal value As Double)
            _SubTotal = value
        End Set
    End Property
    'Descuento
    Public Property Bonificacion() As Double
        Get
            Return _Descuento
        End Get
        Set(ByVal value As Double)
            _Descuento = value
        End Set
    End Property
    'Impuesto'
    Public Property Impuesto() As Double
        Get
            Return _Impuesto
        End Get
        Set(ByVal value As Double)
            _Impuesto = value
        End Set
    End Property

    'Total'
    Public Property Total() As Double
        Get
            Return _Total
        End Get
        Set(ByVal value As Double)
            _Total = value
        End Set
    End Property
    'Cancela
    Public Property Cancela() As Integer
        Get
            Return _Cancela
        End Get
        Set(ByVal value As Integer)
            _Cancela = value
        End Set
    End Property
    'FechaDeCancelado
    Public Property Fechacancelado() As String
        Get
            Return _FechaDeCancelado
        End Get
        Set(ByVal value As String)
            _FechaDeCancelado = value
        End Set
    End Property
    '-----------------------------------------------------------------------------------------------------------------------
    Public Property OrdADetalle() As DataTable
        Get
            Return _OrdADetalle
        End Get
        Set(ByVal Value As DataTable)
            _OrdADetalle = Value
        End Set
    End Property

    Public Property WTotalCte() As Double
        Get
            Return _WTotalCte
        End Get
        Set(ByVal Value As Double)
            _WTotalCte = Value
        End Set
    End Property

    Public Property IdODetalle() As Integer
        Get
            Return _IdODetalle
        End Get
        Set(ByVal Value As Integer)
            _IdODetalle = Value
        End Set
    End Property
    Public Property IdODIdArticulo() As Integer
        Get
            Return _IdODIdArticulo
        End Get
        Set(ByVal Value As Integer)
            _IdODIdArticulo = Value
        End Set
    End Property
    Public Property IdODCantidad() As Integer
        Get
            Return _IdODCantidad
        End Get
        Set(ByVal Value As Integer)
            _IdODCantidad = Value
        End Set
    End Property
    Public Property IdODPrecio() As Double
        Get
            Return _IdODPrecio
        End Get
        Set(ByVal Value As Double)
            _IdODPrecio = Value
        End Set
    End Property
    Public Property IdODConcepto() As String
        Get
            Return _IdODConcepto
        End Get
        Set(ByVal Value As String)
            _IdODConcepto = Value
        End Set
    End Property
    '' detalle de Orden de compra
    Public Property IdOrdenDetalle() As Integer
        Get
            Return _IdOrdenDetalle
        End Get
        Set(ByVal Value As Integer)
            _IdOrdenDetalle = Value
        End Set
    End Property
    Public Property IdArticulo() As Integer
        Get
            Return _IdArticulo
        End Get
        Set(ByVal Value As Integer)
            _IdArticulo = Value
        End Set
    End Property
    Public Property Cantidad() As Integer
        Get
            Return _Cantidad
        End Get
        Set(ByVal Value As Integer)
            _Cantidad = Value
        End Set
    End Property
    Public Property Precio() As Double
        Get
            Return _Precio
        End Get
        Set(ByVal Value As Double)
            _Precio = Value
        End Set
    End Property
    Public Property Concepto() As String
        Get
            Return _Concepto
        End Get
        Set(ByVal Value As String)
            _Concepto = Value
        End Set
    End Property
    Public Property WDTDetalle() As DataTable
        Get
            Return _WDTDetalle
        End Get
        Set(ByVal Value As DataTable)
            _WDTDetalle = Value
        End Set
    End Property
#End Region

#Region "Rutinas base de datos"

    'New Id Ordern
    Public Sub New_IdOrden()
        StrSql = "SELECT isnull(max(IdOdeC),0) FROM " & N_Tabla
        _IdOrden = xCnx.ScalarQuery(StrSql) + 1
        Me.New_Folio()
    End Sub

    'New Id Orden Detalle
    Public Sub New_IdOrdenDetalle()
        StrSql = "SELECT isnull(max(IdOdeCDetalle),0) FROM OdeCDetalle"
        _IdOrdenDetalle = xCnx.ScalarQuery(StrSql) + 1
    End Sub

    'New Folio
    Public Sub New_Folio()
        StrSql = "SELECT dbo.FN_LPAD(" & _IdOrden & ",'0',6)"    'No se que hace la funcion FN_LPAD
        _Folio = "A" & xCnx.ScalarQuery(StrSql)
    End Sub '

    'Insertar nueva factura
    Public Sub insertDB()
        ''Inserta encabezado
        Me.New_IdOrden()
        StrSql = "INSERT INTO " & N_Tabla
        StrSql = StrSql & " (IdOdeC,IdProveedor,Folio,FechaOrden,"
        StrSql = StrSql & " SubTotal,Descuento,"
        StrSql = StrSql & " Impuesto,Total"
        StrSql = StrSql & " ) "
        StrSql = StrSql & " VALUES(" & _IdOrden & "," & _IdProveedor & ",'" & _Folio & "',"
        StrSql = StrSql & "convert(datetime,convert(VarChar(20),'" & _FechaOrden & "', 103),103),"
        StrSql = StrSql & _SubTotal & "," & _Descuento & ","
        StrSql = StrSql & _Impuesto & "," & _Total
        StrSql = StrSql & " )"
        xCnx.NonQuery(StrSql)
    End Sub

    'Insertar detalle
    Public Sub insertDBDetalle()
        Me.New_IdOrdenDetalle()
        StrSql = "INSERT INTO OdeCDetalle (IdOdeCDetalle,IdOdeC,IdArticulo,"
        StrSql = StrSql & " Cantidad, Precio, Concepto) "
        StrSql = StrSql & " VALUES(" & _IdOrdenDetalle & "," & _IdOrden & ","
        StrSql = StrSql & _IdArticulo & "," & _Cantidad & ",'" & _Precio & "'," & _Concepto
        StrSql = StrSql & ")"
        xCnx.NonQuery(StrSql)
    End Sub

    'Actualiza la cancelacion de una orden de compra
    Public Sub UpdateDBCancela()
        StrSql = "UPDATE " & N_Tabla
        StrSql = StrSql & " set Cancela = " & _Cancela
        StrSql = StrSql & ", ctefacfechaCan = getdate()"   'No se de donde sale CTEFACFECHACAN
        StrSql = StrSql & "  WHERE IdOdeC=" & _IdOrden
        xCnx.NonQuery(StrSql)
    End Sub

    'ELIMINA LOS DATOS DEL CLIENTE SELECCIONADO
    Public Sub DeleteDB()
        'StrSql = "DELETE FROM CLIENTE WHERE idCliente=" & _idcliente
        xCnx.NonQuery(StrSql)
    End Sub

    'Saca orden por id
    Function GetDB(ByVal wCampoBusca As Integer) As Boolean
        ' saca factura por id o por folio
        StrSql = "SELECT IdOdeC, IdProveedor, Folio, FechaOrden,"
        StrSql = StrSql & " SubTotal,Descuento,"
        StrSql = StrSql & " Impuesto,Total,"
        StrSql = StrSql & " Cancela,FechaDeCancelado "
        StrSql = StrSql & " FROM " & N_Tabla
        If wCampoBusca = 1 Then
            StrSql = StrSql & " WHERE IdOdeC=" & _IdOrden
        End If
        If wCampoBusca = 2 Then
            StrSql = StrSql & " WHERE Folio='" & _Folio & "'"
        End If
        GetDB = False
        xDT = xCnx.DTQuery(StrSql)
        If xDT.Rows.Count = 1 Then
            GetDB = True
            _IdOrden = CInt(xDT.Rows(0)("IdOdeC"))
            _IdProveedor = CInt(xDT.Rows(0)("IdProveedor"))
            _Folio = CStr(xDT.Rows(0)("Folio"))
            _FechaOrden = CStr(xDT.Rows(0)("FechaOrden"))
            _SubTotal = CDbl(xDT.Rows(0)("SubTotal"))
            _Descuento = CDbl(xDT.Rows(0)("Descuento"))
            _Impuesto = CDbl(xDT.Rows(0)("Impuesto"))
            _Total = CDbl(xDT.Rows(0)("Total"))
            _Cancela = CInt(xDT.Rows(0)("Cancela"))
            _FechaDeCancelado = CStr(xDT.Rows(0)("FechaDeCancelado"))

        End If
    End Function


    Function RptOrden(ByVal mFolio As String, ByVal mLetras As String) As Object
        StrSql = " Exec dbo.SpRptFactura3 '" & mFolio & "','" & mLetras & "'," & GIVA
        RptOrden = xCnx.DTQuery(StrSql)
    End Function

    'Saca el total de la orden
    Public Function TotalOrden(ByVal WIdcliente As Integer) As Double
        StrSql = "SELECT isnull(sum(Total),0) Total "
        StrSql = StrSql & " from " & N_Tabla & " where  IdProveedor =" & WIdcliente
        StrSql = StrSql & " and Cancela = 0  "
        xDT = xCnx.DTQuery(StrSql)
        TotalOrden = 0
        If xDT.Rows.Count = 1 Then
            TotalOrden = CDbl(xDT.Rows(0)("Total"))
        End If
        Return TotalOrden
    End Function

    'Llenar grid de orden
    Function Fill_Grid_Orden(ByVal mVence1 As String, ByVal mVence2 As String, _
                               ByVal mIdcliente As Integer, ByVal MFolio As String, ByVal MCancela As Integer) As Object
        StrSql = " "
        StrSql = "SELECT F.IdOdeC,F.Folio,F.IdProveedor, C.CTENOMBRE NOMBRE, F.FechaOrden,"   'Nose de donde sale CTENOMBRE
        StrSql = StrSql & " F.SubTotal,"
        StrSql = StrSql & " F.Total,"
        StrSql = StrSql & " F.Impuesto,F.Cancela,F.Descuento"
        StrSql = StrSql & " FROM " & N_Tabla & " F "
        StrSql = StrSql & " INNER JOIN Proveedor C  on C.IdProveedor = F.IdProveedor"
        StrSql = StrSql & " WHERE   "
        If MCancela = 1 Then
            StrSql = StrSql & " F.Cancela=0  "
        End If
        If Len(MFolio) = 0 Then
            If Len(mVence1) > 0 And Len(mVence2) > 0 And MCancela = 1 Then
                StrSql = StrSql & " AND "
                StrSql = StrSql & " F.FechaOrden BETWEEN "
                StrSql = StrSql & " convert(datetime,convert(VarChar(20),'" & mVence1 & "', 103),103)"
                StrSql = StrSql & " and convert(datetime,convert(VarChar(20),'" & mVence2 & "', 103),103)"
            Else
                If Len(mVence1) > 0 And Len(mVence2) > 0 And MCancela <> 1 Then
                    StrSql = StrSql & " F.fechaOrden BETWEEN "
                    StrSql = StrSql & " convert(datetime,convert(VarChar(20),'" & mVence1 & "', 103),103)"
                    StrSql = StrSql & " and convert(datetime,convert(VarChar(20),'" & mVence2 & "', 103),103)"
                End If
            End If
            If mIdcliente > 0 And (MCancela = 1 Or (Len(mVence1) > 0 And Len(mVence2) > 0)) Then
                StrSql = StrSql & "and F.IdProveedor=" & mIdcliente
            Else
                If mIdcliente <> 0 And MCancela = 1 Then
                    StrSql = StrSql & " F.IdProveedor=" & mIdcliente
                End If
            End If
        Else
            StrSql = StrSql & " and F.Folio='" & MFolio & "'"
        End If
        If MCancela = 2 And mIdcliente <> 0 Then
            StrSql = StrSql & " F.ctefacCancelada=0  "     ' No de donde sale CTEFACCACELADA
            StrSql = StrSql & " AND F.CteFacSaldo > 1"     ' No se de donde sale CTEFACTSALDO
            StrSql = StrSql & " AND F.IdProveedor=" & mIdcliente
        End If
        Fill_Grid_Orden = xCnx.DTQuery(StrSql)
    End Function

    'Grid del detalle de la factura
    Function Fill_Grid_OrdenDet() As Object
        StrSql = " "
        StrSql = "SELECT F.IdOdeC,F.IdOdeCDetalle,F.Cantidad,F.Precio,F.Concepto"
        StrSql = StrSql & " FROM OdeCDetalle F "
        StrSql = StrSql & " WHERE  F.IdOdeC= " & _IdOrden
        StrSql = StrSql & " ORDER BY F.IdOdeC, F.IdOdeCDetalle"
        Fill_Grid_OrdenDet = xCnx.DTQuery(StrSql)
    End Function

    'Regresa proveedores que se facturo en rango de fechas
    Function FillG_CteOrde(ByVal mFI As String, ByVal mFF As String) As Object
        StrSql = " "
        StrSql = "SELECT A.IdProveedor,(SELECT Nombre FROM Proveedor WHERE IdProveedor=A.IdProveedor) Nombre"
        StrSql = StrSql & ",round(sum(A.Importe),2) Importe,COUNT(A.IdFactura) nFact"
        StrSql = StrSql & ",round(sum(A.Importe)/COUNT(A.IdCteFactura),2) Prom "
        StrSql = StrSql & " FROM  OdeC A "
        StrSql = StrSql & " INNER JOIN Proveedor C ON C.IdProveedor = A.IdProveedor"
        StrSql = StrSql & " WHERE A.ctefacCancelada=0 and A.ctefacFecha BETWEEN "                           'No se de donde sale CTEFACCANCELADA y CTEFACFECHA
        StrSql = StrSql & " CONVERT(datetime,'" & mFI & "',103) AND  CONVERT(datetime,'" & mFF & "',103) "
        StrSql = StrSql & " GROUP BY A.IdProveedor ORDER BY A.IdProveedor "
        FillG_CteOrde = xCnx.DTQuery(StrSql)
    End Function

    'Proceso de orden
    Function ProcesaVenta() As Boolean
        'Inserta encabezado
        Me.insertDB()
        'Inserta detalle
        For Me.i = 0 To _WDTDetalle.Rows.Count - 1
            row = _WDTDetalle.Rows(Me.i)
            '' paso las variables del datatable 
            ' inserto prefactura detalle
            _Cantidad = row("Cantidad").ToString
            _Precio = row("Precio").ToString
            _Concepto = row("Descuento").ToString
            _IdArticulo = row("IdArticulo").ToString
            Me.insertDBDetalle()
        Next
        ProcesaVenta = True
    End Function

    'Reporte
    Function Rpt(ByVal Mbusca As Integer) As DataTable
        StrSql = "SELECT A.IdOdeC,A.IdProveedor,C.Nombre,C.RFC,C.Calle,C.Numero,C.Colonia,C.Estado,"
        StrSql = StrSql & " C.Ciudad,C.CodigoPostal, A.SubTotal,A.Descuento,A.Impuesto,"
        StrSql = StrSql & " D.Cantidad, D.Precio, D.Concepto,A.Folio,A.FechaOrden"
        StrSql = StrSql & " FROM " & N_Tabla & " A "
        StrSql = StrSql & " INNER JOIN Proveedor C ON C.IdProveedor=A.IdProveedor "
        StrSql = StrSql & " INNER JOIN OdeCDetalle D on D.IdOdeC=A.IdOdeC "
        StrSql = StrSql & " Where A.IdOdeC=" & Mbusca
        Rpt = xCnx.DTQuery(StrSql)
    End Function
#End Region
End Class
