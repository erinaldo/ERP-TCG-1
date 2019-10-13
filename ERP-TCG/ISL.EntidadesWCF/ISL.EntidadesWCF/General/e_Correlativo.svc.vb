

<DataContract()> _
Public Class e_Correlativo
    Implements Ie_Correlativo

#Region "Propiedad"

    Private _prefijo As String
    Private _idtipodocumento As String
    Private _numero As Integer
    Private _serie As Integer
    Private _tipo As Integer

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    Public Event DatoCambiado()

    <DataMember()> _
    Public Property Prefijo() As String
        Get
            Return _prefijo
        End Get
        Set(ByVal value As String)
            _prefijo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoDocumento() As String
        Get
            Return _idtipodocumento
        End Get
        Set(ByVal value As String)
            _idtipodocumento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Numero() As Integer
        Get
            Return _numero
        End Get
        Set(ByVal value As Integer)
            _numero = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Tipo() As Integer
        Get
            Return _tipo
        End Get
        Set(ByVal value As Integer)
            _tipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Serie() As Integer
        Get
            Return _serie
        End Get
        Set(ByVal value As Integer)
            _serie = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        Prefijo = String.Empty
        IdTipoDocumento = String.Empty
        Tipo = 0
    End Sub

    Public Sub New( _
              ByVal ls_Prefijo As String _
              , ByVal ls_IdTipoDocumento As String _
              , ByVal ln_Numero As Integer _
              , ByVal ln_Serie As Integer _
              , ByVal ln_Tipo As Integer)
        _prefijo = ls_Prefijo
        _idtipodocumento = ls_IdTipoDocumento
        _numero = ln_Numero
        _serie = ln_Serie
        _tipo = ln_Tipo
    End Sub

#End Region

    Public Function Obtener(ByVal correlativo As e_Correlativo) As e_Correlativo Implements Ie_Correlativo.Obtener
        Return correlativo
    End Function

End Class


