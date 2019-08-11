<DataContract()> _
Public Class e_ObligacionDocumento
    Implements Ie_ObligacionDocumento

#Region "Propiedad"

    Private _id As String
    Private _idmovimientodocumento As String
    Private _idobligacionfinanciera As String
    Private _montomn As Double
    Private _montome As Double
    Private _activo As Boolean
    Private _IdCuentaxCyP As String
    Private _usuariocreacion As String
    Private _fechacreacion As Date
    Private _retencionmn As Double
    Private _retencionme As Double
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    ''' <summary>
    ''' Para Proceso de Letras
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember()> _
    Public OeObligacFin As e_ObligacionFinanciera

    Public Event DatoCambiado()

    <DataMember()> _
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMovimientoDocumento() As String
        Get
            Return _idmovimientodocumento
        End Get
        Set(ByVal value As String)
            _idmovimientodocumento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdObligacionFinanciera() As String
        Get
            Return _idobligacionfinanciera
        End Get
        Set(ByVal value As String)
            _idobligacionfinanciera = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property MontoMN() As Double
        Get
            Return _montomn
        End Get
        Set(ByVal value As Double)
            _montomn = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property MontoME() As Double
        Get
            Return _montome
        End Get
        Set(ByVal value As Double)
            _montome = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property RetencionMN() As Double
        Get
            Return _retencionmn
        End Get
        Set(ByVal value As Double)
            _retencionmn = value
        End Set
    End Property

    <DataMember()> _
    Public Property RetencionME() As Double
        Get
            Return _retencionme
        End Get
        Set(ByVal value As Double)
            _retencionme = value
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdCuentaxCyP() As String
        Get
            Return _IdCuentaxCyP
        End Get
        Set(ByVal value As String)
            _IdCuentaxCyP = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        Activo = True
        _fechacreacion = #1/1/1901#
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdMovimientoDocumento As String _
              , ByVal ls_IdObligacionFinanciera As String _
              , ByVal ln_MontoMN As Double _
              , ByVal ln_MontoME As Double _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_IdCuentaxCyP As String _
              , ByVal ls_RetencionMN As Double _
              , ByVal ls_RetencionME As Double _
           )
        _id = ls_Id
        _idmovimientodocumento = ls_IdMovimientoDocumento
        _idobligacionfinanciera = ls_IdObligacionFinanciera
        _montomn = ln_MontoMN
        _montome = ln_MontoME
        _activo = lb_Activo
        _IdCuentaxCyP = ls_IdCuentaxCyP
        _retencionmn = ls_RetencionMN
        _retencionme = ls_RetencionME
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_ObligacionDocumento
    ''' </summary>
    ''' <param name="obligacionDocumento"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal obligacionDocumento As e_ObligacionDocumento) As e_ObligacionDocumento Implements Ie_ObligacionDocumento.Obtener
        Return obligacionDocumento
    End Function

#End Region

End Class


