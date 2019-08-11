<DataContract()> _
Public Class e_ConfiguracionNeumatico
    Implements Ie_ConfiguracionNeumatico

#Region "Declaracion de Variables"

    Private _id As String
    Private _nombre As String
    Private _nroejes As Integer
    Private _nroneumaticos As Integer
    Private _activo As Boolean
    Private _usuariocreacion As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean

    <DataMember()> _
    Public lstDetalleConfiguracionNeumatico As New List(Of e_DetalleConfiguracionNeumatico)

    Public Event DatoCambiado()

#End Region

#Region "Propiedad"

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
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NroEjes() As Integer
        Get
            Return _nroejes
        End Get
        Set(ByVal value As Integer)
            _nroejes = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NroNeumaticos() As Integer
        Get
            Return _nroneumaticos
        End Get
        Set(ByVal value As Integer)
            _nroneumaticos = value
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

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
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
              , ByVal ls_Nombre As String _
              , ByVal ln_NroEjes As Integer _
              , ByVal ln_NroNeumaticos As Integer _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
                )
        _id = ls_Id
        _nombre = ls_Nombre
        _nroejes = ln_NroEjes
        _nroneumaticos = ln_NroNeumaticos
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_ConfiguracionNeumatico
    ''' </summary>
    ''' <param name="configuracionNeumatico"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal configuracionNeumatico As e_ConfiguracionNeumatico) As e_ConfiguracionNeumatico Implements Ie_ConfiguracionNeumatico.Obtener
        Return configuracionNeumatico
    End Function

#End Region

End Class
