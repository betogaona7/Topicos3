Public Class CLS_usuario

#Region "DECLARACION DE VARIBLES"
    'Variables conexion de DB'
    Dim xCnx As New dbSQL
    Dim StrSql As String
    Dim xDS As New DataSet
    Dim xDT As New DataTable
    'Atributos de la clase
    Private _IDUsuario As Integer
    Private _Nombre As String
    Private _Login As String
    Private _Password As String
    Private _IDDepartamento As Integer
    Private _Activo As Integer
    Dim N_tabla As String = "USUARIO"
#End Region

#Region "PROPIEDADES"
    Public Property IDUsuario() As Integer
        Get
            Return _IDUsuario
        End Get
        Set(ByVal value As Integer)
            _IDUsuario = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Login() As String
        Get
            Return _Login
        End Get
        Set(ByVal value As String)
            _Login = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return _Password
        End Get
        Set(ByVal value As String)
            _Password = value
        End Set
    End Property

    Public Property Activo() As Integer
        Get
            Return _Activo
        End Get
        Set(ByVal value As Integer)
            _Activo = value
        End Set
    End Property

#End Region

#Region "RUTINAS DATABASE"
    'Saca nuevo numero Id
    Public Sub New_IDUsuario()
        StrSql = "SELECT ISNULL(MAX(IDUsuario),0) FROM " & N_tabla
        _IDDepartamento = xCnx.ScalarQuery(StrSql) + 1
    End Sub

    'Inserta registro en la base de datos
    Public Sub insertDB()
        Me.New_IDUsuario()
        StrSql = "INSERT INTO " & N_tabla & "(IDUsuario, Nombre, Loginn, Passwordd, Activo)"
        StrSql = StrSql & " VALUES(" & _IDUsuario & ",'" & _Nombre & "'," & _Login & "'," & _Password & "',"
        StrSql = StrSql & _Activo
        StrSql = StrSql & ")"
        xCnx.NonQuery(StrSql)
    End Sub

    'Actualiza los datos de del registro seleccionado
    Public Sub UpdateDB()
        StrSql = "UPDATE " & N_tabla & " SET Nombre = '" & _Nombre & "'"
        'StrSql = StrSql & ", FechaMod = GetDate()"
        StrSql = StrSql & " WHERE IDUsuario = " & _IDUsuario
        xCnx.NonQuery(StrSql)
    End Sub

    'Consulta en la base de datos si el registro ExISTE y LLENA la clse
    Function GetDB() As Boolean
        StrSql = "SELECT IDUsuario, Nombre, Loginn, Passwordd "
        StrSql = StrSql & " FROM " & N_tabla
        StrSql = StrSql & " WHERE IDUsuario = " & _IDUsuario
        GetDB = False
        xDT = xCnx.DTQuery(StrSql)
        If xDT.Rows.Count = 1 Then
            GetDB = True
            _IDUsuario = CInt(xDT.Rows(0)("IDUsuario"))
            _Nombre = CStr(xDT.Rows(0)("Nombre"))
            _Login = CStr(xDT.Rows(0)("Loginn"))
            _Password = CStr(xDT.Rows(0)("Passwordd"))
        End If
    End Function

    'Actualiza activo
    Public Sub UpdateCancela(ByVal mactivo As Integer)
        StrSql = "UPDATE " & N_tabla & " SET Activo = " & mactivo
        StrSql = StrSql & " WHERE IDUsuario = " & _IDUsuario
        xCnx.NonQuery(StrSql)
    End Sub

    'Validacion
    Function Valida(ByVal MBusca As String) As Boolean
        StrSql = "SELECT IDUsuario, Nombre, Activo "
        StrSql = StrSql & " FROM " & N_tabla
        StrSql = StrSql & " WHERE Nombre = '" & MBusca & "'"
        Valida = False
        xDT = xCnx.DTQuery(StrSql)
        'ValidaBanco = True
        If xDT.Rows.Count >= 1 Then
            Valida = True
            _IDUsuario = CInt(xDT.Rows(0)("IDUsuario"))
            _Nombre = CStr(xDT.Rows(0)("Nombre"))
            _Activo = CStr(xDT.Rows(0)("Activo"))
        End If
    End Function

    'Llenar grid
    Function Fill_Grid() As Object
        StrSql = "SELECT IDUsuario, Nombre, Loginn, Passwordd, IDDepartamento "
        StrSql = StrSql & " CASE Activo WHEN 1 THEN 'Activo' WHEN 0 THEN "
        StrSql = StrSql & "' Baja' END Activo "
        StrSql = StrSql & " FROM " & N_tabla
        Fill_Grid = xCnx.DTQuery(StrSql)
    End Function

    'Llenar combo
    Function Load_Combo() As DataTable
        StrSql = "SELECT IDUsuario, Nombre FROM " & N_tabla
        StrSql = StrSql & " WHERE Activo = 1 ORDER BY Nombre"
        Load_Combo = xCnx.DTQuery(StrSql)
    End Function

    'Sacar informacion de la tabla para hacer el reporte
    Function Rpt(ByVal Mbusca As Integer) As DataTable
        StrSql = "SELECT IDUsuario, Nombre, Loginn, Passwordd, IDDepartamento, Activo"
        StrSql = StrSql & " CASE Activo WHEN 1 THEN 'Activo' WHEN 0 "
        StrSql = StrSql & " THEN 'Baja' END Activo"
        StrSql = StrSql & " FROM " & N_tabla
        If Mbusca <> 0 Then
            StrSql = StrSql & " WHERE IDUsuario = " & Mbusca
        End If
        StrSql = StrSql & " ORDER BY Nombre "
        Rpt = xCnx.DTQuery(StrSql)
    End Function
#End Region
End Class
