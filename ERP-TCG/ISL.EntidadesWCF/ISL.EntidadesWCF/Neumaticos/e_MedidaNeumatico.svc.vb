<DataContract()> _
Public Class e_MedidaNeumatico
    Implements Ie_MedidaNeumatico

#Region "Declaracion de Variables"

    Private _id As String
    Private _nombre As String
    Private _tiponeumatico As String
    Private _idtiponeumatico As String
    Private _diametroaro As Double
    Private _idtipomedida As String
    Private _tipomedida As String
    Private _activo As Boolean
    Private _usuariocreacion As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
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
    Public Property IdTipoNeumatico() As String
        Get
            Return _idtiponeumatico
        End Get
        Set(ByVal value As String)
            _idtiponeumatico = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoNeumatico() As String
        Get
            Return _tiponeumatico
        End Get
        Set(ByVal value As String)
            _tiponeumatico = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoMedida() As String
        Get
            Return _idtipomedida
        End Get
        Set(ByVal value As String)
            _idtipomedida = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoMedida() As String
        Get
            Return _tipomedida
        End Get
        Set(ByVal value As String)
            _tipomedida = value
        End Set
    End Property

    <DataMember()> _
    Public Property DiametroAro() As Double
        Get
            Return _diametroaro
        End Get
        Set(ByVal value As Double)
            _diametroaro = value
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
        TipoOperacion = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Nombre As String _
              , ByVal ls_IdTipoNeumatico As String _
              , ByVal ls_TipoNeumatico As String _
              , ByVal ls_IdTipoMedida As String _
              , ByVal ls_TipoMedida As String _
              , ByVal ln_DiametroAro As Double _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
             )
        _id = ls_Id
        _nombre = ls_Nombre
        _idtiponeumatico = ls_IdTipoNeumatico
        _tiponeumatico = ls_TipoNeumatico
        _idtipomedida = ls_IdTipoMedida
        _tipomedida = ls_TipoMedida
        _diametroaro = ln_DiametroAro
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_MedidaNeumatico
    ''' </summary>
    ''' <param name="medidaNeumatico"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal medidaNeumatico As e_MedidaNeumatico) As e_MedidaNeumatico Implements Ie_MedidaNeumatico.Obtener
        Return medidaNeumatico
    End Function

#End Region

End Class
