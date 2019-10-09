<DataContract()> _
Public Class e_Material_DisenoNeu
    Implements Ie_Material_DisenoNeu


#Region "Declaracion de Variables"

    Private _id As String
    Private _idmaterial As String
    Private _iddisenoneumatico As String
    Private _idmarcaneu As String
    Private _idmedidaneu As String
    Private _tipobanda As String
    Private _estadoneu As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean
    <DataMember()> _
   Public TipoOperacion As String
    <DataMember()> _
    Public Material As String
    <DataMember()> _
    Public Modificado As Boolean
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
    Public Property IdMaterial() As String
        Get
            Return _idmaterial
        End Get
        Set(ByVal value As String)
            _idmaterial = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdDisenoNeumatico() As String
        Get
            Return _iddisenoneumatico
        End Get
        Set(ByVal value As String)
            _iddisenoneumatico = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoBanda() As String
        Get
            Return _tipobanda
        End Get
        Set(ByVal value As String)
            _tipobanda = value
        End Set
    End Property

    <DataMember()> _
    Public Property EstadoNeu() As String
        Get
            Return _estadoneu
        End Get
        Set(ByVal value As String)
            _estadoneu = value
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
        _idmaterial = String.Empty
        _iddisenoneumatico = String.Empty
        _tipobanda = String.Empty
        _estadoneu = String.Empty
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _activo = True
        TipoOperacion = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdMaterial As String _
              , ByVal ls_IdDisenoNeumatico As String _
              , ByVal ls_IdMarcaNeu As String _
              , ByVal ls_IdMedidaNeu As String _
              , ByVal ls_TipoBanda As String _
              , ByVal ls_EstadoNeu As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idmaterial = ls_IdMaterial
        _iddisenoneumatico = ls_IdDisenoNeumatico
        _idmarcaneu = ls_IdMarcaNeu
        _idmedidaneu = ls_IdMedidaNeu
        _tipobanda = ls_TipoBanda
        _estadoneu = ls_EstadoNeu
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal material_disenoneu As e_Material_DisenoNeu) As e_Material_DisenoNeu Implements Ie_Material_DisenoNeu.Obtener
        Return material_disenoneu
    End Function

End Class
