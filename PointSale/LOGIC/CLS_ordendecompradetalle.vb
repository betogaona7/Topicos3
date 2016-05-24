Public Class CLS_ordendecompradetalle

#Region "Declaracion de variables"

    Dim xCnx As New dbSQL
    Dim StrSql As String
    Dim xDS As New DataSet
    Dim xDT As New DataTable

    'atributos de la clase'
    Private _IdOrdenDetalle As Integer
    Private _IdOrden As Integer
    Private _IdArticulo As Integer
    Private _Cantidad As Integer
    Private _Precio As Double
    Private _Concepto As String

    Dim N_Tabla As String = "OdeCDetalle"
#End Region

#Region "Propiedades"
    'IdOrdenDetalle'
    Public Property IdOrdenDetalle() As Integer
        Get
            Return _IdOrdenDetalle
        End Get
        Set(ByVal value As Integer)
            _IdOrdenDetalle = value
        End Set
    End Property
    'IdOrden'
    Public Property IdOrden() As Integer
        Get
            Return _IdOrden
        End Get
        Set(ByVal value As Integer)
            _IdOrden = value
        End Set
    End Property
    'IdArticulo'
    Public Property IdArticulo() As Integer
        Get
            Return _IdArticulo
        End Get
        Set(ByVal value As Integer)
            _IdArticulo = value
        End Set
    End Property
    'Cantidad
    Public Property Cantidad() As Integer
        Get
            Return _Cantidad
        End Get
        Set(ByVal value As Integer)
            _Cantidad = value
        End Set
    End Property
    'Precio
    Public Property Precio() As Double
        Get
            Return _Precio
        End Get
        Set(ByVal value As Double)
            _Precio = value
        End Set
    End Property
    'Concepto'
    Public Property Concepto() As String
        Get
            Return _Concepto
        End Get
        Set(ByVal value As String)
            _Concepto = value
        End Set
    End Property
#End Region

#Region "Rutinas base datos"
    'Nuevo Id
    Public Sub New_IdOrdenDetalle()
        StrSql = "SELECT isnull(max(IdOdeCDetalle),0) FROM OdeCDetalle"
        _IdOrdenDetalle = xCnx.ScalarQuery(StrSql) + 1
    End Sub

    'Insertar en BD detalle
    Public Sub insertDBDetalle()
        Me.New_IdOrdenDetalle()
        StrSql = "INSERT INTO OdeCDetalle (IdOdeCDetalle,IdOdeC, IdArticulo, Cantidad,"
        StrSql = StrSql & " Precio, Concepto) "
        StrSql = StrSql & " VALUES(" & _IdOrdenDetalle & "," & _IdOrden & ","
        StrSql = StrSql & _IdArticulo & "," & _Cantidad & "," & _Precio & ",'" & _Concepto
        StrSql = StrSql & "')"
        xCnx.NonQuery(StrSql)
    End Sub

    'Grid del detalle orden
    Function Fill_Grid_OrdenDet() As Object
        StrSql = " "
        StrSql = "SELECT F.IdOdeC,F.IdOdeCDetalle,F.Cantidad,F.Precio,F.Concepto"
        StrSql = StrSql & " FROM OdeCDetalle F "
        StrSql = StrSql & " WHERE F.IdOdeC= " & _IdOrden
        StrSql = StrSql & " ORDER BY F.IdOdeC,F.IdOdeCDetalle"
        Fill_Grid_OrdenDet = xCnx.DTQuery(StrSql)
    End Function
#End Region

End Class
