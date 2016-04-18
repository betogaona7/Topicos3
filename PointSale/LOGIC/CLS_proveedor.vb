Public Class CLS_proveedor

#Region "Declaracion de variables"
    'variables de conexion DB'
    Dim xCnx As New dbSQL
    Dim StrSql As String
    Dim xDS As New DataSet
    Dim xDT As New DataTable

    'atributos de la clase'
    Private _IdProveedor As Integer
    Private _Nombre As String
    Private _RFC As String
    Private _Calle As String
    Private _Numero As Integer
    Private _Colonia As String
    Private _Estado As String
    Private _Ciudad As String
    Private _CodigoPostal As String
    Private _Activo As Integer
    Dim N_Tabla As String = "PROVEEDOR"
#End Region

#Region "Propiedades"
    'IdCliente'
    Public Property IdProveedor() As Integer
        Get
            Return _IdProveedor
        End Get
        Set(ByVal value As Integer)
            _IdProveedor = value
        End Set
    End Property
    'Nombre'
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property
    'RFC'
    Public Property RFC() As String
        Get
            Return _RFC
        End Get
        Set(ByVal value As String)
            _RFC = value
        End Set
    End Property
    'Calle'
    Public Property Calle() As String
        Get
            Return _Calle
        End Get
        Set(ByVal value As String)
            _Calle = value
        End Set
    End Property
    'Numero'
    Public Property Numero() As Integer
        Get
            Return _Numero
        End Get
        Set(ByVal value As Integer)
            _Numero = value
        End Set
    End Property
    'Colonia'
    Public Property Colonia() As String
        Get
            Return _Colonia
        End Get
        Set(ByVal value As String)
            _Colonia = value
        End Set
    End Property

    'Estado'
    Public Property Estado() As String
        Get
            Return _Estado
        End Get
        Set(ByVal value As String)
            _Estado = value
        End Set
    End Property

    'Ciudad'
    Public Property Ciudad() As String
        Get
            Return _Ciudad
        End Get
        Set(ByVal value As String)
            _Ciudad = value
        End Set
    End Property
    'CodigoPostal'
    Public Property CodigoPostal() As String
        Get
            Return _CodigoPostal
        End Get
        Set(ByVal value As String)
            _CodigoPostal = value
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
    Public Sub New_IdProveedor()
        StrSql = "SELECT isnull(max(IdProveedor),0) FROM " & N_Tabla
        _IdProveedor = xCnx.ScalarQuery(StrSql) + 1
    End Sub

    'Insertar un registro'
    Public Sub insertDB()
        Me.New_IdProveedor()
        StrSql = "INSERT INTO " & N_Tabla & " (IdProveedor,Nombre,RFC,Calle,Numero,Colonia,Estado,Ciudad,CodigoPostal,Activo) "
        StrSql = StrSql & " VALUES(" & _IdProveedor & ",'" & _Nombre & "','" & _RFC & "','" & _Calle & "'," & _Numero & ",'" & _Colonia & "','" & _Estado & "','" & _Ciudad & "','" & _CodigoPostal & "',"
        StrSql = StrSql & Activo & ")"
        xCnx.NonQuery(StrSql)
    End Sub

    'Actualiza los datos del  registro seleccionado'
    Public Sub UpdateDB()
        StrSql = "UPDATE " & N_Tabla & " set Nombre='" & _Nombre & "',"
        StrSql = StrSql & " RFC='" & _RFC & "',"
        StrSql = StrSql & " Calle='" & _Calle & "',"
        StrSql = StrSql & " Numero=" & _Numero & ","
        StrSql = StrSql & " Colonia='" & _Colonia & "',"
        StrSql = StrSql & " Estado='" & _Estado & "',"
        StrSql = StrSql & " Ciudad='" & _Ciudad & "',"
        StrSql = StrSql & " CodigoPostal='" & _CodigoPostal & "'"
        StrSql = StrSql & " WHERE IdProveedor=" & _IdProveedor
        xCnx.NonQuery(StrSql)
    End Sub
    '''''''''''''''''''''''''''''''''''''''''''

    'Consulta en la base de datos si el registro existe y llena la clase'
    Function GetDB() As Boolean
        StrSql = "SELECT IdProveedor, Nombre, RFC, Calle, Numero, Colonia, Estado, Ciudad, CodigoPostal, Activo "
        StrSql = StrSql & " FROM " & N_Tabla
        StrSql = StrSql & " WHERE IdProveedor=" & _IdProveedor
        GetDB = False
        xDT = xCnx.DTQuery(StrSql)
        If xDT.Rows.Count = 1 Then
            GetDB = True
            _IdProveedor = CInt(xDT.Rows(0)("IdProveedor"))
            _Nombre = CStr(xDT.Rows(0)("Nombre"))
            _RFC = CStr(xDT.Rows(0)("RFC"))
            _Calle = CStr(xDT.Rows(0)("Calle"))
            _Numero = CInt(xDT.Rows(0)("Numero"))
            _Colonia = CStr(xDT.Rows(0)("Colonia"))
            _Estado = CStr(xDT.Rows(0)("Estado"))
            _Ciudad = CStr(xDT.Rows(0)("Ciudad"))
            _CodigoPostal = CStr(xDT.Rows(0)("CodigoPostal"))
            _Activo = CInt(xDT.Rows(0)("Activo"))
        End If
    End Function

    'Actualiza activo'
    Public Sub UpdCancela(ByVal mactivo As Integer)
        StrSql = "UPDATE " & N_Tabla & " set Activo= " & mactivo
        StrSql = StrSql & " WHERE IdProveedor =" & _IdProveedor
        xCnx.NonQuery(StrSql)
    End Sub

    'Valida que no existan nombres duplicados'
    Function valida(ByVal MBusca As String) As Boolean
        StrSql = "SELECT IdProveedor, Nombre, RFC, Calle, Numero, Colonia, Estado, Ciudad, CodigoPostal, Activo "
        StrSql = StrSql & " FROM " & N_Tabla
        StrSql = StrSql & " WHERE Nombre='" & MBusca & "'"
        valida = False
        xDT = xCnx.DTQuery(StrSql)
        If xDT.Rows.Count >= 1 Then
            valida = True
            _IdProveedor = CInt(xDT.Rows(0)("IdProveedor"))
            _Nombre = CStr(xDT.Rows(0)("Nombre"))
            _RFC = CStr(xDT.Rows(0)("RFC"))
            _Calle = CStr(xDT.Rows(0)("Calle"))
            _Numero = CInt(xDT.Rows(0)("Numero"))
            _Colonia = CStr(xDT.Rows(0)("Colonia"))
            _Estado = CStr(xDT.Rows(0)("Estado"))
            _Ciudad = CStr(xDT.Rows(0)("Ciudad"))
            _CodigoPostal = CStr(xDT.Rows(0)("CodigoPostal"))
            _Activo = CInt(xDT.Rows(0)("Activo"))
        End If
    End Function

    Function Fill_Grid() As Object
        StrSql = "SELECT IdProveedor,Nombre,RFC,Calle,Numero,Colonia,Estado,Ciudad,CodigoPostal, "
        StrSql = StrSql & " case Activo when 1 then 'Activo' when 0 then "
        StrSql = StrSql & " 'Baja' end Activo"
        StrSql = StrSql & " FROM " & N_Tabla
        Fill_Grid = xCnx.DTQuery(StrSql)
    End Function

    Function Load_Combo() As DataTable
        StrSql = "SELECT IdProveedor,Nombre,RFC,Calle,Numero,Colonia,Estado,Ciudad,CodigoPostal, FROM " & N_Tabla
        StrSql = StrSql & " WHERE Activo = 1 Order by Nombre"
        Load_Combo = xCnx.DTQuery(StrSql)
    End Function
    'Sacar informacion de la tabla si esta activo'
    Function Rpt(ByVal Mbusca As Integer) As DataTable
        StrSql = "SELECT IdProveedor,Nombre,RFC,Calle,Numero,Colonia,Estado,Ciudad,CodigoPostal, "
        StrSql = StrSql & " case Activo when 1 then 'Activo' when 0 "
        StrSql = StrSql & " then 'Baja' end Activo"
        StrSql = StrSql & " FROM " & N_Tabla
        If Mbusca <> 0 Then
            StrSql = StrSql & " Where IdProveedor=" & Mbusca
        End If
        StrSql = StrSql & " Order by Nombre "
        Rpt = xCnx.DTQuery(StrSql)
    End Function
#End Region

End Class
