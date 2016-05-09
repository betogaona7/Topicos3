Public Class CLS_ordendecompradetalle
#Region "Declaracion de variables"
    'variables de conexion DB'
    Dim xCnx As New dbSQL
    Dim StrSql As String
    Dim xDS As New DataSet
    Dim xDT As New DataTable

    'atributos de la clase'
    Private _IdOdeCDetalle As Integer
    Private _IdOdeC As Integer
    Private _IdArticulo As Integer
    Private _Cantidad As Integer
    Private _Precio As Double
    Private _Concepto As String

    Dim N_Tabla As String = "OdeCDetalle"
#End Region

#Region "Propiedades"
    'IdOdeCDetalle'
    Public Property IdOdeCDetalle() As Integer
        Get
            Return _IdOdeCDetalle
        End Get
        Set(ByVal value As Integer)
            _IdOdeCDetalle = value
        End Set
    End Property
    'IOdeC'
    Public Property IdOdeC() As Integer
        Get
            Return _IdOdeC
        End Get
        Set(ByVal value As Integer)
            _IdOdeC = value
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

#Region "Rutinas DATABASE"

#End Region

End Class
