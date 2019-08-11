

<DataContract()> _
Public Class e_ControlPersonaVehiculoES
    Implements Ie_ControlPersonaVehiculoES

#Region "Propiedad"

    Private _id As String
    Private _idpersonaes As String
    Private _idvehiculoes As String
    Private _condicion As String
    Private _indes As Integer
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

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
    Public Property IdPersonaES() As String
        Get
            Return _idpersonaes
        End Get
        Set(ByVal value As String)
            _idpersonaes = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdVehiculoES() As String
        Get
            Return _idvehiculoes
        End Get
        Set(ByVal value As String)
            _idvehiculoes = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Condicion() As String
        Get
            Return _condicion
        End Get
        Set(ByVal value As String)
            _condicion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndES() As Integer
        Get
            Return _indes
        End Get
        Set(ByVal value As Integer)
            _indes = value
            RaiseEvent DatoCambiado()
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

#End Region

#Region "Constructor"
    Public Sub New()
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdPersonaES As String _
              , ByVal ls_IdVehiculoES As String _
              , ByVal ls_Condicion As String _
              , ByVal ln_IndES As Integer _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idpersonaes = ls_IdPersonaES
        _idvehiculoes = ls_IdVehiculoES
        _condicion = ls_Condicion
        _indes = ln_IndES
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal controlPersonaVehiculoES As e_ControlPersonaVehiculoES) As e_ControlPersonaVehiculoES Implements Ie_ControlPersonaVehiculoES.Obtener
        Return controlPersonaVehiculoES
    End Function

End Class



