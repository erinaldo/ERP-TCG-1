<DataContract()> _
Public Class e_CuentaCtePersonal
    Implements Ie_CuentaCtePersonal
    Implements IEquatable(Of e_CuentaCtePersonal)

#Region "Declaracion de variables"

    Private _id As String
    Private _idtrabajador As String
    Private _trabajador As String
    Private _dni As String
    Private _identidadbancaria As String
    Private _entidadbancaria As String
    Private _idmoneda As String
    Private _moneda As String
    Private _nrocuenta As String
    Private _tipoconcepto As String
    Private _idPersona As String
    Private _persona As String
    Private _vinculo As String
    Private _vigente As Integer
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public Equivale As Integer

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
    Public Property IdTrabajador() As String
        Get
            Return _idtrabajador
        End Get
        Set(ByVal value As String)
            _idtrabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property Trabajador() As String
        Get
            Return _trabajador
        End Get
        Set(ByVal value As String)
            _trabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property Dni() As String
        Get
            Return _dni
        End Get
        Set(ByVal value As String)
            _dni = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEntidadBancaria() As String
        Get
            Return _identidadbancaria
        End Get
        Set(ByVal value As String)
            _identidadbancaria = value
        End Set
    End Property

    <DataMember()> _
   Public Property EntidadBancaria() As String
        Get
            Return _entidadbancaria
        End Get
        Set(ByVal value As String)
            _entidadbancaria = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMoneda() As String
        Get
            Return _idmoneda
        End Get
        Set(ByVal value As String)
            _idmoneda = value
        End Set
    End Property

    <DataMember()> _
   Public Property Moneda() As String
        Get
            Return _moneda
        End Get
        Set(ByVal value As String)
            _moneda = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroCuenta() As String
        Get
            Return _nrocuenta
        End Get
        Set(ByVal value As String)
            _nrocuenta = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoConcepto() As String
        Get
            Return _tipoconcepto
        End Get
        Set(ByVal value As String)
            _tipoconcepto = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdBeneficiario() As String
        Get
            Return _idPersona
        End Get
        Set(ByVal value As String)
            _idPersona = value
        End Set
    End Property

    <DataMember()> _
    Public Property Beneficiario() As String
        Get
            Return _persona
        End Get
        Set(ByVal value As String)
            _persona = value
        End Set
    End Property

    <DataMember()> _
    Public Property Vinculo() As String
        Get
            Return _vinculo
        End Get
        Set(ByVal value As String)
            _vinculo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Vigente() As Integer
        Get
            Return _vigente
        End Get
        Set(ByVal value As Integer)
            _vigente = value
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
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _id = String.Empty
        _idtrabajador = String.Empty
        _trabajador = String.Empty
        _dni = String.Empty
        _identidadbancaria = String.Empty
        _entidadbancaria = String.Empty
        _idmoneda = String.Empty
        _moneda = String.Empty
        _nrocuenta = String.Empty
        _tipoconcepto = String.Empty
        _idPersona = String.Empty
        _persona = String.Empty
        _vinculo = String.Empty
        _vigente = -1
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdTrabajador As String _
              , ByVal ls_Trabajador As String _
              , ByVal ls_Dni As String _
              , ByVal ls_IdEntidadBancaria As String _
              , ByVal ls_EntidadBancaria As String _
              , ByVal ls_IdMoneda As String _
              , ByVal ls_Moneda As String _
              , ByVal ls_NroCuenta As String _
              , ByVal ls_TipoConcepto As String _
              , ByVal ls_IdPersona As String _
              , ByVal ls_Persona As String _
              , ByVal ls_Vinculo As String _
              , ByVal ln_Vigente As Integer _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idtrabajador = ls_IdTrabajador
        _trabajador = ls_Trabajador
        _dni = ls_Dni
        _identidadbancaria = ls_IdEntidadBancaria
        _entidadbancaria = ls_EntidadBancaria
        _idmoneda = ls_IdMoneda
        _moneda = ls_Moneda
        _nrocuenta = ls_NroCuenta
        _tipoconcepto = ls_TipoConcepto
        _idPersona = ls_IdPersona
        _persona = ls_Persona
        _vinculo = ls_Vinculo
        _vigente = ln_Vigente
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function obtener(ByVal oeCuentaCtePersonal As e_CuentaCtePersonal) As e_CuentaCtePersonal Implements Ie_CuentaCtePersonal.obtener
        Return oeCuentaCtePersonal
    End Function

    Public Overloads Function Equals(ByVal oeCtaCtePer As e_CuentaCtePersonal) As Boolean Implements System.IEquatable(Of e_CuentaCtePersonal).Equals
        Select Case oeCtaCtePer.Equivale
            Case 1 : If Me.Id.Trim = oeCtaCtePer.Id.Trim Then Return True
            Case 2 : If Me.NroCuenta.Trim = oeCtaCtePer.NroCuenta.Trim Then Return True
            Case 3 : If Me.IdTrabajador = oeCtaCtePer.IdTrabajador.Trim Then Return True
        End Select
        Return False
    End Function

#End Region

End Class
