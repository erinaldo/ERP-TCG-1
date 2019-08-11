<DataContract()> _
Public Class e_CatalagoCodigoSunat
    Implements Ie_CatalagoCodigoSunat

#Region "Declaracion de Variables"

    Private _id As String
    Private _codigotabla As String
    Private _codigoelemento As String
    Private _descripcion As String
    Private _codigosunat As String
    Private _codigoalterno As String
    Private _usuariocrea As String
    Private _fechacrea As Date
    Private _usuariomodifica As String
    Private _fechamodifica As Date

    <DataMember()> _
    Public TipoOperacion As String

#End Region

#Region "Propiedades"

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
    Public Property CodigoTabla() As String
        Get
            Return _codigotabla
        End Get
        Set(ByVal value As String)
            _codigotabla = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoElemento() As String
        Get
            Return _codigoelemento
        End Get
        Set(ByVal value As String)
            _codigoelemento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoSunat() As String
        Get
            Return _codigosunat
        End Get
        Set(ByVal value As String)
            _codigosunat = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoAlterno() As String
        Get
            Return _codigoalterno
        End Get
        Set(ByVal value As String)
            _codigoalterno = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCrea() As String
        Get
            Return _usuariocrea
        End Get
        Set(ByVal value As String)
            _usuariocrea = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCrea() As Date
        Get
            Return _fechacrea
        End Get
        Set(ByVal value As Date)
            _fechacrea = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioModifica() As String
        Get
            Return _usuariomodifica
        End Get
        Set(ByVal value As String)
            _usuariomodifica = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaModifica() As Date
        Get
            Return _fechamodifica
        End Get
        Set(ByVal value As Date)
            _fechamodifica = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _id = ""
        _codigotabla = ""
        _codigoelemento = ""
        _descripcion = ""
        _codigosunat = ""
        _codigoalterno = ""
        _usuariocrea = ""
        _fechacrea = #1/1/1901#
        _usuariomodifica = ""
        _fechamodifica = #1/1/1901#
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_CodigoTabla As String _
              , ByVal ls_CodigoElemento As String _
              , ByVal ls_Descripcion As String _
              , ByVal ls_CodigoSunat As String _
              , ByVal ls_CodigoAlterno As String _
              , ByVal ls_UsuarioCrea As String _
              , ByVal ld_FechaCrea As Date _
              , ByVal ls_UsuarioModifica As String _
              , ByVal ld_FechaModifica As Date _
           )
        _id = ls_Id
        _codigotabla = ls_CodigoTabla
        _codigoelemento = ls_CodigoElemento
        _descripcion = ls_Descripcion
        _codigosunat = ls_CodigoSunat
        _codigoalterno = ls_CodigoAlterno
        _usuariocrea = ls_UsuarioCrea
        _fechacrea = ld_FechaCrea
        _usuariomodifica = ls_UsuarioModifica
        _fechamodifica = ld_FechaModifica
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(catalagocodigosunat As e_CatalagoCodigoSunat) As e_CatalagoCodigoSunat Implements Ie_CatalagoCodigoSunat.Obtener
        Return catalagocodigosunat
    End Function

#End Region

End Class
