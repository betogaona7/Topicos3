' ''CLASE DE CONEXION GENERICA PARA UN PROYECTO
Imports System.Data.SqlClient
Imports System.Data
Public Class dbSQL
    Dim mArr As Object = Nothing
    Public AppPath As String = App_Path() & "DATA\"
    Public strsqlcnx As String = _
        System.Configuration.ConfigurationSettings.AppSettings("ConnectionString")
    Public cnx As SqlClient.SqlConnection
    Shared cnx_persistente As SqlClient.SqlConnection
    Dim DA As SqlClient.SqlDataAdapter
    Dim DT As DataTable
    Dim DS As DataSet
    Dim DCMD As SqlClient.SqlConnection
    ' ''INSTANCIA  LA CLASE DB CON LOS PARAMETROS INICIALES
    Public Sub New()
        ' ''Verifica si la conexion no es nula
        If cnx Is Nothing Then
            cnx = New SqlClient.SqlConnection(strsqlcnx)
            cnx.Open()
        End If
        cnx = New SqlClient.SqlConnection(strsqlcnx)
        If cnx.State <> ConnectionState.Open Then
            Try
                cnx.Open()
                ' MsgBox("Conexion a la base de datos Correcta...", MsgBoxStyle.Information, "Aviso")
            Catch ex As Exception
                Throw New Exception("No puede abrirse la conexion a la base de datos.", ex)
            End Try
        End If
    End Sub
    ' '' ''FUNCION QUE EJECUTA UN COMANDO DE SQL Y REGRESA UN DATA TABLE 
    Public Function DTQuery(ByVal sqlcmd As String) As DataTable
        DA = New SqlClient.SqlDataAdapter(sqlcmd, cnx)
        If cnx.State <> ConnectionState.Open Then
            Try
                cnx.Open()
                ' MsgBox("Conexion a la base de datos Correcta...", MsgBoxStyle.Information, "Aviso")
            Catch ex As Exception
                Throw New Exception("No puede abrirse la conexion a la base de datos.", ex)
            End Try
        End If
        Dim DT As New DataTable
        DA.Fill(DT)
        cnx.Close()
        Return DT
    End Function
    '' '' ''FUNCION QUE EJECUTA UN COMANDO DE SQL Y REGRESA UN DATA SET 
    'Public Function DAQuery(ByVal sqlcmd As String) As DataSet
    '    DA = New SqlClient.SqlDataAdapter(sqlcmd, cnx)
    '    DA.Fill(sqlcmd)
    '    Return DT
    'End Function

    ' ''RUTINA QUE EJECUTA COMANDO DE SQL DE INSERT/UPDATE/DELETE Y STORED
    Public Function ExecuteSP(ByVal strcmd As String) As Object
        Dim sqlcmd As New SqlClient.SqlCommand(strcmd, cnx)
        If cnx.State <> ConnectionState.Open Then
            Try
                cnx.Open()
                ' MsgBox("Conexion a la base de datos Correcta...", MsgBoxStyle.Information, "Aviso")
            Catch ex As Exception
                Throw New Exception("No puede abrirse la conexion a la base de datos.", ex)
            End Try
        End If
        Dim xRes As Object
        xRes = sqlcmd.ExecuteScalar
        cnx.Close()
        Return xRes
    End Function
    ' ''RUTINA QUE EJECUTA COMANDO DE SQL DE INSERT/UPDATE/DELETE Y STORED
    Public Sub NonQuery(ByVal strcmd As String)
        Dim sqlcmd As New SqlClient.SqlCommand(strcmd, cnx)
        If cnx.State <> ConnectionState.Open Then
            Try
                cnx.Open()
                ' MsgBox("Conexion a la base de datos Correcta...", MsgBoxStyle.Information, "Aviso")
            Catch ex As Exception
                Throw New Exception("No puede abrirse la conexion a la base de datos.", ex)
            End Try
        End If
        sqlcmd.ExecuteNonQuery()
        cnx.Close()
    End Sub
    ' ''FUNCION QUE EJECUTA UN COMANDO DE SQL Y DA UN VALOR COMO RESULTADO 
    Public Function ScalarQuery(ByVal strcmd As String) As Object
        Dim sqlcmd As New SqlClient.SqlCommand(strcmd, cnx)
        If cnx.State <> ConnectionState.Open Then
            Try
                cnx.Open()
                ' MsgBox("Conexion a la base de datos Correcta...", MsgBoxStyle.Information, "Aviso")
            Catch ex As Exception
                Throw New Exception("No puede abrirse la conexion a la base de datos.", ex)
            End Try
        End If
        Dim xRes As Object
        xRes = sqlcmd.ExecuteScalar
        cnx.Close()
        Return xRes
    End Function
    Public Function App_Path() As String
        Return System.AppDomain.CurrentDomain.BaseDirectory()
    End Function
End Class
