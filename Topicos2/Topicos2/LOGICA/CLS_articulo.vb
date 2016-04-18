Public Class CLS_articulo
#Region "DECLARACION DE VARIBLES"
    'Variables conexion de DB'
    Dim xCnx As New dbSQL
    Dim StrSql As String
    Dim xDS As New DataSet
    Dim xDT As New DataTable
    'Atributos de la clase
    Private _IDArticulo As Integer
    Private _codigo As String
    Private _Descripcion As String
    Private _Precio As String
    Private _Costo As Integer
    Private _Activo As Integer

    Dim N_tabla As String = "ARTICULO"
#End Region

#Region "PROPIEDADES"
    Public Property IDArticulo() As Integer
        Get
            Return _IDArticulo
        End Get
        Set(ByVal value As Integer)
            _IDArticulo = value
        End Set
    End Property

    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property

    Public Property Precio() As String
        Get
            Return _Precio
        End Get
        Set(ByVal value As String)
            _Precio = value
        End Set
    End Property

    Public Property Costo() As String
        Get
            Return _Costo
        End Get
        Set(ByVal value As String)
            _Costo = value
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
        StrSql = "SELECT ISNULL(MAX(IDArticulo),0) FROM " & N_tabla
        _IDArticulo = xCnx.ScalarQuery(StrSql) + 1
    End Sub

    'Inserta registro en la base de datos
    Public Sub insertDB()
        Me.New_IDUsuario()
        StrSql = "INSERT INTO " & N_tabla & "(IDArticulo, Codigo, Descripcion, Precio, Costo, Activo)"
        StrSql = StrSql & " VALUES(" & _IDArticulo & ",'" & _codigo & "'," & _Descripcion & "'," & _Precio & "'," & _Costo & "','"
        StrSql = StrSql & _Activo
        StrSql = StrSql & ")"
        xCnx.NonQuery(StrSql)
    End Sub

    'Actualiza los datos de del registro seleccionado
    Public Sub UpdateDB()
        StrSql = "UPDATE " & N_tabla & " SET Codigo = '" & _codigo & "'"
        'StrSql = StrSql & ", FechaMod = GetDate()"
        StrSql = StrSql & " WHERE IDArticulo = " & _IDArticulo
        xCnx.NonQuery(StrSql)
    End Sub

    'Consulta en la base de datos si el registro ExISTE y LLENA la clse
    Function GetDB() As Boolean
        StrSql = "SELECT IDArticulo, Codigo, Descripcion, Precio, Costo, Activo "
        StrSql = StrSql & " FROM " & N_tabla
        StrSql = StrSql & " WHERE IDArticulo = " & _IDArticulo
        GetDB = False
        xDT = xCnx.DTQuery(StrSql)
        If xDT.Rows.Count = 1 Then
            GetDB = True
            _IDArticulo = CInt(xDT.Rows(0)("IDArticulo"))
            _codigo = CStr(xDT.Rows(0)("Codigo"))
            _Descripcion = CStr(xDT.Rows(0)("Descripcion"))
            _Precio = System.Convert.ToDecimal(xDT.Rows(0)("Precio"))
            _Costo = System.Convert.ToDecimal(xDT.Rows(0)("Costo"))
        End If
    End Function

    'Actualiza activo
    Public Sub UpdateCancela(ByVal mactivo As Integer)
        StrSql = "UPDATE " & N_tabla & " SET Activo = " & mactivo
        StrSql = StrSql & " WHERE IDArticulo = " & _IDArticulo
        xCnx.NonQuery(StrSql)
    End Sub

    'Validacion
    Function Valida(ByVal MBusca As String) As Boolean
        StrSql = "SELECT IDArticulo, Codigo, Descripcion, Activo "
        StrSql = StrSql & " FROM " & N_tabla
        StrSql = StrSql & " WHERE Codigo = '" & MBusca & "'"
        Valida = False
        xDT = xCnx.DTQuery(StrSql)
        'ValidaBanco = True
        If xDT.Rows.Count >= 1 Then
            Valida = True
            _IDArticulo = CInt(xDT.Rows(0)("IDArticulo"))
            _codigo = CStr(xDT.Rows(0)("Codigo"))
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
