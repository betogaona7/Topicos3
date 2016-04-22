Public Class CLS_articulos

#Region "Declaracion de variables"
    'variables de conexion DB'
    Dim xCnx As New dbSQL
    Dim StrSql As String
    Dim xDS As New DataSet
    Dim xDT As New DataTable

    'atributos de la clase'
    Private _IdArticulo As Integer
    Private _Codigo As String
    Private _Descripcion As String
    Private _Precio As Double
    Private _Costo As Double
    Private _Activo As Integer
    Dim N_Tabla As String = "ARTICULO"
#End Region

#Region "Propiedades"
    'IdArticulo'
    Public Property IdArticulo() As Integer
        Get
            Return _IdArticulo
        End Get
        Set(ByVal value As Integer)
            _IdArticulo = value
        End Set
    End Property

    'Codigo'
    Public Property Codigo() As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
        End Set
    End Property

    'Descripcion'
    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property

    'Precio'
    Public Property Precio() As Double
        Get
            Return _Precio
        End Get
        Set(ByVal value As Double)
            _Precio = value
        End Set
    End Property

    'Costo'
    Public Property Costo() As Double
        Get
            Return _Costo
        End Get
        Set(ByVal value As Double)
            _Costo = value
        End Set
    End Property

    'Activo'
    Public Property Activo() As Integer
        Get
            Return _Activo
        End Get
        Set(ByVal value As Integer)
            _Activo = value
        End Set
    End Property

#End Region

#Region "Rutinas DATABASE"

    'Saca numero nuevo de Id'
    Public Sub New_IdArticulo()
        StrSql = "SELECT isnull(max(IdArticulo),0) FROM " & N_Tabla
        _IdArticulo = xCnx.ScalarQuery(StrSql) + 1
    End Sub

    'Insertar un registro'
    Public Sub insertDB()
        Me.New_IdArticulo()
        StrSql = "INSERT INTO " & N_Tabla & " (IdArticulo,Codigo,Descripcion,Precio,Costo,Activo) "
        StrSql = StrSql & " VALUES(" & _IdArticulo & ",'" & _Codigo & "','" & _Descripcion & "'," & _Precio & ",'" & _Costo & "','"
        StrSql = StrSql & Activo & ")"
        xCnx.NonQuery(StrSql)
    End Sub

    'Actualiza los datos del  registro seleccionado'
    Public Sub UpdateDB()
        StrSql = "UPDATE " & N_Tabla & " set Codigo='" & _Codigo & "',"
        StrSql = StrSql & " Descripcion='" & _Descripcion & "',"
        StrSql = StrSql & " Precio=" & _Precio & ","
        StrSql = StrSql & " Costo='" & _Costo & "'"
        StrSql = StrSql & " WHERE IdArticulo=" & _IdArticulo
        xCnx.NonQuery(StrSql)
    End Sub
    '''''''''''''''''''''''''''''''''''''''''''

    'Consulta en la base de datos si el registro existe y llena la clase'
    Function GetDB() As Boolean
        StrSql = "SELECT IdArticulo, Codigo, Descripcion, Precio, Costo, Activo "
        StrSql = StrSql & " FROM " & N_Tabla
        StrSql = StrSql & " WHERE IdArticulo=" & _IdArticulo
        GetDB = False
        xDT = xCnx.DTQuery(StrSql)
        If xDT.Rows.Count = 1 Then
            GetDB = True
            _IdArticulo = CInt(xDT.Rows(0)("IdArticulo"))
            _Codigo = CStr(xDT.Rows(0)("Codigo"))
            _Descripcion = CStr(xDT.Rows(0)("Descripcion"))
            _Precio = CDbl(xDT.Rows(0)("Precio"))
            _Costo = CDbl(xDT.Rows(0)("Costo"))
            _Activo = CInt(xDT.Rows(0)("Activo"))
        End If
    End Function

    'Actualiza activo'
    Public Sub UpdCancela(ByVal mactivo As Integer)
        StrSql = "UPDATE " & N_Tabla & " set Activo= " & mactivo
        StrSql = StrSql & " WHERE IdArticulo =" & _IdArticulo
        xCnx.NonQuery(StrSql)
    End Sub

    'Valida que no existan codigos duplicados'
    Function valida(ByVal MBusca As String) As Boolean
        StrSql = "SELECT IdArticulo, Codigo, Descripcion, Precio, Costo, Activo "
        StrSql = StrSql & " FROM " & N_Tabla
        StrSql = StrSql & " WHERE Codigo='" & MBusca & "'"
        valida = False
        xDT = xCnx.DTQuery(StrSql)
        If xDT.Rows.Count >= 1 Then
            valida = True
            _IdArticulo = CInt(xDT.Rows(0)("IdArticulo"))
            _Codigo = CStr(xDT.Rows(0)("Codigo"))
            _Descripcion = CStr(xDT.Rows(0)("Descripcion"))
            _Precio = CDbl(xDT.Rows(0)("Precio"))
            _Costo = CDbl(xDT.Rows(0)("Costo"))
            _Activo = CInt(xDT.Rows(0)("Activo"))
        End If
    End Function

    Function Fill_Grid() As Object
        StrSql = "SELECT IdArticulo,Codigo,Descripcion,Precio,Costo, "
        StrSql = StrSql & " case Activo when 1 then 'Activo' when 0 then "
        StrSql = StrSql & " 'Baja' end Activo"
        StrSql = StrSql & " FROM " & N_Tabla
        Fill_Grid = xCnx.DTQuery(StrSql)
    End Function

    Function Load_Combo() As DataTable
        StrSql = "SELECT IdArticulo,Codigo,Descripcion,Precio,Costo FROM " & N_Tabla
        StrSql = StrSql & " WHERE Activo = 1 Order by Codigo"
        Load_Combo = xCnx.DTQuery(StrSql)
    End Function

    'Sacar informacion de la tabla si esta activo'
    Function Rpt(ByVal Mbusca As Integer) As DataTable
        StrSql = "SELECT IdArticulo,Codigo,Descripcion,Precio,Costo, "
        StrSql = StrSql & " case Activo when 1 then 'Activo' when 0 "
        StrSql = StrSql & " then 'Baja' end Activo"
        StrSql = StrSql & " FROM " & N_Tabla
        If Mbusca <> 0 Then
            StrSql = StrSql & " Where IdArticulo=" & Mbusca
        End If
        StrSql = StrSql & " Order by Codigo "
        Rpt = xCnx.DTQuery(StrSql)
    End Function
#End Region

End Class
