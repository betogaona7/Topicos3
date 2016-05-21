﻿Public Class CLS_ordendecompradetalle
#Region "Declaracion de variables"
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

End Class