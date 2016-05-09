Public Class CLS_ordencompra
#Region "Declaracion de variables"
    'variables de conexion DB'
    Dim xCnx As New dbSQL
    Dim StrSql As String
    Dim xDS As New DataSet
    Dim xDT As New DataTable

    'atributos de la clase'
    Private _IdOdeC As Integer
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
#End Region

#Region "Propiedades"
    'IdOdeC'
    Public Property IdOdeC() As Integer
        Get
            Return _IdOdeC
        End Get
        Set(ByVal value As Integer)
            _IdOdeC = value
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
    Public Property Folio() As String
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
    Public Property SubTotal() As Double
        Get
            Return _SubTotal
        End Get
        Set(ByVal value As Double)
            _SubTotal = value
        End Set
    End Property
    'Descuento
    Public Property Descuento() As Double
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
    Public Property FechaDeCancelado() As String
        Get
            Return _FechaDeCancelado
        End Get
        Set(ByVal value As String)
            _FechaDeCancelado = value
        End Set
    End Property

#End Region

#Region "Rutinas DATABASE"

#End Region


End Class
