Public Module mGeneral
    Public xLog As String
    Public xSrv As String
    Public xPass As String
    Public xDB As String
    Public gVersion As String
    Public NameSys As String
    Public GNumUser As Integer
    Public GTpoUser As Integer
    Public GIVA As Integer
    Public GSERIE As String
    Public GNivel As Integer
    Public GModulo As Integer
    Public GAlmacen As Integer
    Public GIdArticulo As Integer
    Public GIdCliente As Integer
    Public logUser As String
    Public nomUser As String
    Public Function ValidaMayusculas(ByRef KeyAscii As Char) As Boolean
        If Char.IsLetterOrDigit(KeyAscii) Then
            ValidaMayusculas = False
            ''ElseIf KeyAscii.IsDigit(KeyAscii) Then
            ''    ValidaMayusculas = False
        ElseIf Char.IsControl(KeyAscii) Then
            ValidaMayusculas = False
        ElseIf Char.IsWhiteSpace(KeyAscii) Then
            ValidaMayusculas = False
        ElseIf Char.IsPunctuation(KeyAscii) Then
            ValidaMayusculas = False
        Else
            ValidaMayusculas = True
        End If
    End Function
    Public Function ValidaNumero(ByRef KeyAscii As Char) As Boolean
        If Char.IsDigit(KeyAscii) Then
            ValidaNumero = False
        ElseIf Char.IsControl(KeyAscii) Then
            ValidaNumero = False
        ElseIf Char.IsPunctuation(KeyAscii) Then
            ValidaNumero = False
        Else
            ValidaNumero = True
        End If
    End Function
End Module
