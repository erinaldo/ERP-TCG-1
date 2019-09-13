

<DataContract()> _
Public Class e_ControlCargaPersonaES
    Implements Ie_ControlCargaPersonaES

#Region "Propiedad"

    Private _id As String
    Private _idpersonaes As String
    Private _carga As String
    Private _observacion As String
    Private _controles As Integer
    Private _confirmado As Integer
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
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
    Public Property Carga() As String
        Get
            Return _carga
        End Get
        Set(ByVal value As String)
            _carga = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Observacion() As String
        Get
            Return _observacion
        End Get
        Set(ByVal value As String)
            _observacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property ControlES() As Integer
        Get
            Return _controles
        End Get
        Set(ByVal value As Integer)
            _controles = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Confirmado() As Integer
        Get
            Return _confirmado
        End Get
        Set(ByVal value As Integer)
            _confirmado = value
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
              , ByVal ls_Carga As String _
              , ByVal ls_Observacion As String _
              , ByVal ln_ControlES As Integer _
              , ByVal ln_Confirmado As Integer _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idpersonaes = ls_IdPersonaES
        _carga = ls_Carga
        _observacion = ls_Observacion
        _controles = ln_ControlES
        _confirmado = ln_Confirmado
        _activo = lb_Activo
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_ControlCargaPersonaES
    ''' </summary>
    ''' <param name="controlCargaPersonaES"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal controlCargaPersonaES As e_ControlCargaPersonaES) As e_ControlCargaPersonaES Implements Ie_ControlCargaPersonaES.Obtener
        Return controlCargaPersonaES
    End Function

#End Region

End Class



