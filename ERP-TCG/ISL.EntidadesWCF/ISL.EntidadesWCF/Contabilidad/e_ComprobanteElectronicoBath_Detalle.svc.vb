<DataContract()> _
Public Class e_ComprobanteElectronicoBath_Detalle
    Implements Ie_ComprobanteElectronicoBath_Detalle

#Region "Declaracion de Variables"

    Private _id As String
    Private _idbath As String
    Private _item As Integer
    Private _tiporeferencia As Integer
    Private _idreferencia As String
    Private _usuariocrea As String
    Private _fechacrea As Date
    Private _usuariomodifica As String
    Private _fechamodifica As Date
    Private _IndBaja As Boolean
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
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
    Public Property IdBath() As String
        Get
            Return _idbath
        End Get
        Set(ByVal value As String)
            _idbath = value
        End Set
    End Property

    <DataMember()> _
    Public Property Item() As Integer
        Get
            Return _item
        End Get
        Set(ByVal value As Integer)
            _item = value
        End Set
    End Property

    '<DataMember()> _
    Public Property IndBaja() As String
        Get
            Return _IndBaja
        End Get
        Set(ByVal value As String)
            _IndBaja = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoReferencia() As Integer
        Get
            Return _tiporeferencia
        End Get
        Set(ByVal value As Integer)
            _tiporeferencia = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdReferencia() As String
        Get
            Return _idreferencia
        End Get
        Set(ByVal value As String)
            _idreferencia = value
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

#Region "Contructor"

    Public Sub New()
        _id = ""
        _idbath = ""
        _item = 0
        _tiporeferencia = 0
        _idreferencia = ""
        _usuariocrea = ""
        _fechacrea = #1/1/1901#
        _usuariomodifica = ""
        _fechamodifica = #1/1/1901#
        _IndBaja = 0
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdBath As String _
              , ByVal ln_Item As Integer _
              , ByVal ln_TipoReferencia As Integer _
              , ByVal ls_IdReferencia As String _
              , ByVal ls_UsuarioCrea As String _
              , ByVal ld_FechaCrea As Date _
              , ByVal ls_UsuarioModifica As String _
              , ByVal ld_FechaModifica As Date _
              , ByVal ls_IndBaja As Boolean _
           )
        _id = ls_Id
        _idbath = ls_IdBath
        _item = ln_Item
        _tiporeferencia = ln_TipoReferencia
        _idreferencia = ls_IdReferencia
        _usuariocrea = ls_UsuarioCrea
        _fechacrea = ld_FechaCrea
        _usuariomodifica = ls_UsuarioModifica
        _fechamodifica = ld_FechaModifica
        _IndBaja = ls_IndBaja
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(comprobanteelectronicobath_detalle As e_ComprobanteElectronicoBath_Detalle) As e_ComprobanteElectronicoBath_Detalle Implements Ie_ComprobanteElectronicoBath_Detalle.Obtener
        Return comprobanteelectronicobath_detalle
    End Function

#End Region

End Class
