Public Class CLS_usuario
#Region "Declaracion de variables"
    'variables de conexion DB'
    Dim xCnx As New dbSQL
    Dim StrSql As String
    Dim xDS As New DataSet
    Dim xDT As New DataTable

    'atributos de la clase'
    Private _IdUsuario As Integer
    Private _Nombre As String
    Private _Login As String
    Private _Password As String
    Private _Activo As Integer

    Dim N_Tabla As String = "USUARIO"
#End Region

#Region "Propiedades"
    'IdUsuario'
    Public Property IdUsuario() As Integer
        Get
            Return _IdUsuario
        End Get
        Set(ByVal value As Integer)
            _IdUsuario = value
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
    'Login'
    Public Property Login() As String
        Get
            Return _Login
        End Get
        Set(ByVal value As String)
            _Login = value
        End Set
    End Property
    'Password
    Public Property Password() As String
        Get
            Return _Password
        End Get
        Set(ByVal value As String)
            _Password = value
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
        StrSql = "SELECT isnull(max(IdUsuario),0) FROM " & N_Tabla
        _IdUsuario = xCnx.ScalarQuery(StrSql) + 1
    End Sub

    'Insertar un registro'
    Public Sub insertDB()
        Me.New_IdProveedor()
        StrSql = "INSERT INTO " & N_Tabla & " (IdUsuario, Nombre, Login, Password,Activo) "
        StrSql = StrSql & " VALUES(" & _IdUsuario & ",'" & _Nombre & "','" & _Login & "','" & _Password & "',"
        StrSql = StrSql & Activo & ")"
        xCnx.NonQuery(StrSql)
    End Sub

    'Actualiza los datos del  registro seleccionado'
    Public Sub UpdateDB()
        StrSql = "UPDATE " & N_Tabla & " set Nombre='" & _Nombre & "',"
        StrSql = StrSql & " Login='" & _Login & "',"
        StrSql = StrSql & " Password='" & _Password & "' "
        StrSql = StrSql & " WHERE IdUsuario=" & _IdUsuario
        xCnx.NonQuery(StrSql)
    End Sub
    '''''''''''''''''''''''''''''''''''''''''''

    'Consulta en la base de datos si el registro existe y llena la clase'
    Function GetDB() As Boolean
        StrSql = "SELECT IdUsuario, Nombre, Login, Password, Activo "
        StrSql = StrSql & " FROM " & N_Tabla
        StrSql = StrSql & " WHERE IdUsuario=" & _IdUsuario
        GetDB = False
        xDT = xCnx.DTQuery(StrSql)
        If xDT.Rows.Count = 1 Then
            GetDB = True
            _IdUsuario = CInt(xDT.Rows(0)("IdUsuario"))
            _Nombre = CStr(xDT.Rows(0)("Nombre"))
            _Login = CStr(xDT.Rows(0)("Login"))
            _Password = CStr(xDT.Rows(0)("Password"))
            _Activo = CInt(xDT.Rows(0)("Activo"))
        End If
    End Function

    'Actualiza activo'
    Public Sub UpdCancela(ByVal mactivo As Integer)
        StrSql = "UPDATE " & N_Tabla & " set Activo= " & mactivo
        StrSql = StrSql & " WHERE IdUsuario =" & _IdUsuario
        xCnx.NonQuery(StrSql)
    End Sub

    'Valida que no existan nombres duplicados'
    Function valida(ByVal MBusca As String) As Boolean
        StrSql = "SELECT IdUsuario, Nombre, Login, Password, Activo "
        StrSql = StrSql & " FROM " & N_Tabla
        StrSql = StrSql & " WHERE Nombre='" & MBusca & "'"
        valida = False
        xDT = xCnx.DTQuery(StrSql)
        If xDT.Rows.Count >= 1 Then
            valida = True
            _IdUsuario = CInt(xDT.Rows(0)("IdUsuario"))
            _Nombre = CStr(xDT.Rows(0)("Nombre"))
            _Login = CStr(xDT.Rows(0)("Login"))
            _Password = CStr(xDT.Rows(0)("Password"))
            _Activo = CInt(xDT.Rows(0)("Activo"))
        End If
    End Function

    Function Fill_Grid() As Object
        StrSql = "SELECT IdUsuario,Nombre,Login,Password, "
        StrSql = StrSql & " case Activo when 1 then 'Activo' when 0 then "
        StrSql = StrSql & " 'Baja' end Activo"
        StrSql = StrSql & " FROM " & N_Tabla
        Fill_Grid = xCnx.DTQuery(StrSql)
    End Function

    'Sacar informacion de la tabla si esta activo'
    Function Rpt(ByVal Mbusca As Integer) As DataTable
        StrSql = "SELECT IdUsuario,Nombre,Login,Password, "
        StrSql = StrSql & " case Activo when 1 then 'Activo' when 0 "
        StrSql = StrSql & " then 'Baja' end Activo"
        StrSql = StrSql & " FROM " & N_Tabla
        If Mbusca <> 0 Then
            StrSql = StrSql & " Where IdUsuario=" & Mbusca
        End If
        StrSql = StrSql & " Order by Nombre "
        Rpt = xCnx.DTQuery(StrSql)
    End Function
#End Region
End Class
