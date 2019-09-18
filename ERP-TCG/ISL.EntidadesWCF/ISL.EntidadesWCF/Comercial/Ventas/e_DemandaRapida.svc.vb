

<DataContract()> _
Public Class e_DemandaRapida
    Implements Ie_DemandaRapida

#Region "Constructor"
    Public Sub New()
        Activo = True
    End Sub

    Public Sub New(ByVal lb_Seleccion As Boolean, _
              ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ld_Fecha As Date _
              , ByVal ls_IdCliente As String _
              , ByVal ls_Cliente As String _
              , ByVal ls_IdComisionista As String _
              , ByVal ls_Comisionista As String _
              , ByVal ls_IdRuta As String _
              , ByVal ls_Ruta As String _
              , ByVal ls_IdUsuario As String _
              , ByVal ls_Usuario As String _
              , ByVal ls_IdEstado As String _
              , ByVal ls_Estado As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_Observacion As String _
              , ByVal ls_IdDemanda As String _
               , ByVal ls_UsuarioModifica As String _
               , ByVal ls_Justificacion As String)
        _Seleccion = lb_Seleccion
        _id = ls_Id
        _codigo = ls_Codigo
        _Fecha = ld_Fecha
        _idcliente = ls_IdCliente
        _cliente = ls_Cliente
        _idcomisionista = ls_IdComisionista
        _comisionista = ls_Comisionista
        _idruta = ls_IdRuta
        _ruta = ls_Ruta
        _idUsuario = ls_IdUsuario
        _Usuario = ls_Usuario
        _idEstado = ls_IdEstado
        _Estado = ls_Estado
        _activo = lb_Activo
        _Observacion = ls_Observacion
        _IdDemanda = ls_IdDemanda
        _UsuarioModifica = ls_UsuarioModifica
        _Justificacion = ls_Justificacion
    End Sub

#End Region

#Region "Propiedades"
    Private _Seleccion As Boolean
    Private _id As String
    Private _codigo As String
    Private _Fecha As Date
    Private _idcliente As String
    Private _cliente As String
    Private _idcomisionista As String
    Private _comisionista As String
    Private _idruta As String
    Private _ruta As String
    Private _activo As Boolean
    Private _idUsuario As String
    Private _Usuario As String
    Private _idEstado As String
    Private _Estado As String
    Private _IdDemanda As String
    Private _Observacion As String
    Private _UsuarioModifica As String
    Private _indicador As String
    <DataMember()> _
    Public FechaDesde As String
    <DataMember()> _
    Public FechaHasta As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()>
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()> _
    Public oeListaBitacora As New List(Of e_Bitacora)

    Private _Justificacion As String
    Private _ConceptoCancelacionEliminacion As String
    Private _IdConceptoCancelacionEliminacion As String

    <DataMember()> _
    Public Property Seleccion() As Boolean
        Get
            Return _Seleccion
        End Get
        Set(ByVal value As Boolean)
            _Seleccion = value
        End Set
    End Property

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
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Fecha() As Date
        Get
            Return _Fecha
        End Get
        Set(ByVal value As Date)
            _Fecha = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCliente() As String
        Get
            Return _idcliente
        End Get
        Set(ByVal value As String)
            _idcliente = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cliente() As String
        Get
            Return _cliente
        End Get
        Set(ByVal value As String)
            _cliente = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdComisionista() As String
        Get
            Return _comisionista
        End Get
        Set(ByVal value As String)
            _comisionista = value
        End Set
    End Property

    <DataMember()> _
    Public Property Comisionista() As String
        Get
            Return _comisionista
        End Get
        Set(ByVal value As String)
            _comisionista = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdRuta() As String
        Get
            Return _idruta
        End Get
        Set(ByVal value As String)
            _idruta = value
        End Set
    End Property

    <DataMember()> _
    Public Property Ruta() As String
        Get
            Return _ruta
        End Get
        Set(ByVal value As String)
            _ruta = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdUsuario() As String
        Get
            Return _idUsuario
        End Get
        Set(ByVal value As String)
            _idUsuario = value
        End Set
    End Property

    <DataMember()> _
    Public Property Usuario() As String
        Get
            Return _Usuario
        End Get
        Set(ByVal value As String)
            _Usuario = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEstado() As String
        Get
            Return _idEstado
        End Get
        Set(ByVal value As String)
            _idEstado = value
        End Set
    End Property

    <DataMember()> _
    Public Property Estado() As String
        Get
            Return _Estado
        End Get
        Set(ByVal value As String)
            _Estado = value
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

    <DataMember()> _
    Public Property Observacion() As String
        Get
            Return _Observacion
        End Get
        Set(ByVal value As String)
            _Observacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdDemanda() As String
        Get
            Return _IdDemanda
        End Get
        Set(ByVal value As String)
            _IdDemanda = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioModifica() As String
        Get
            Return _UsuarioModifica
        End Get
        Set(ByVal value As String)
            _UsuarioModifica = value
        End Set
    End Property

    <DataMember()> _
    Public Property Justificacion() As String
        Get
            Return _Justificacion
        End Get
        Set(ByVal value As String)
            _Justificacion = value
        End Set
    End Property
    <DataMember()> _
    Public Property Indicador() As String
        Get
            Return _indicador
        End Get
        Set(ByVal value As String)
            _indicador = value
        End Set
    End Property
    <DataMember()> _
    Public Property ConceptoCancelacionEliminacion() As String
        Get
            Return _ConceptoCancelacionEliminacion
        End Get
        Set(ByVal value As String)
            _ConceptoCancelacionEliminacion = value
        End Set
    End Property
    <DataMember()> _
    Public Property IdConceptoCancelacionEliminacion() As String
        Get
            Return _IdConceptoCancelacionEliminacion
        End Get
        Set(ByVal value As String)
            _IdConceptoCancelacionEliminacion = value
        End Set
    End Property
#End Region

    Public Function Obtener(ByVal demandaRapida As e_DemandaRapida) As e_DemandaRapida Implements Ie_DemandaRapida.Obtener
        Return demandaRapida
    End Function

End Class


