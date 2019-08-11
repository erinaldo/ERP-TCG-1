


<DataContract()> _
Public Class e_Gasto_Caja
    Implements Ie_Gasto_Caja

#Region "Declaracion de Variables"

    Private _id As String
    Private _idgastooperacion As String
    Private _area As New e_Area
    Private _idruta As String
    Private _idpiloto As String
    Private _usuarioautoriza As String
    Private _centrogasto As String
    Private _idtipogasto As String
    Private _idtrabajador As String
    Private _idplaca As String
    Private _activo As Boolean


    Public loGastoVehiculo As New List(Of e_GastoVehiculo)

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public IndCompraAlmacen As Boolean
    <DataMember()> _
    Public IdGastoFuncion As String

    Public Event DatoCambiado()

#End Region

#Region "Propiedad"

    <DataMember()> _
    Public Property id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdGastoOperacion() As String
        Get
            Return _idgastooperacion
        End Get
        Set(ByVal value As String)
            _idgastooperacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdRuta() As String
        Get
            Return _idruta
        End Get
        Set(ByVal value As String)
            _idruta = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdArea() As String
        Get
            Return _area.Id
        End Get
        Set(ByVal value As String)
            _area.Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdPiloto() As String
        Get
            Return _idpiloto
        End Get
        Set(ByVal value As String)
            _idpiloto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioAutoriza() As String
        Get
            Return _usuarioautoriza
        End Get
        Set(ByVal value As String)
            _usuarioautoriza = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CentroGasto() As String
        Get
            Return _centrogasto
        End Get
        Set(ByVal value As String)
            _centrogasto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoGasto() As String
        Get
            Return _idtipogasto
        End Get
        Set(ByVal value As String)
            _idtipogasto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTrabajador() As String
        Get
            Return _idtrabajador
        End Get
        Set(ByVal value As String)
            _idtrabajador = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdPlaca() As String
        Get
            Return _idplaca
        End Get
        Set(ByVal value As String)
            _idplaca = value
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
        _id = ""
        _idgastooperacion = ""
        _idruta = ""
        _idpiloto = ""
        _usuarioautoriza = ""
        _centrogasto = ""
        _idtipogasto = ""
        _idtrabajador = ""
        _idplaca = ""
        _area.Id = ""
        _activo = True
        IndCompraAlmacen = False
    End Sub

    Public Sub New( _
              ByVal ls_id As String _
              , ByVal ls_IdRuta As String _
              , ByVal ls_IdPiloto As String _
              , ByVal ls_UsuarioAutoriza As String _
              , ByVal ls_CentroGasto As String _
              , ByVal ls_IdTipoGasto As String _
              , ByVal ls_IdTrabajador As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_id
        _idruta = ls_IdRuta
        _idpiloto = ls_IdPiloto
        _usuarioautoriza = ls_UsuarioAutoriza
        _centrogasto = ls_CentroGasto
        _idtipogasto = ls_IdTipoGasto
        _idtrabajador = ls_IdTrabajador
        _activo = lb_Activo
    End Sub

#End Region

    Public Function Obtener(ByVal gasto_Caja As e_Gasto_Caja) As e_Gasto_Caja Implements Ie_Gasto_Caja.Obtener
        Return gasto_Caja
    End Function

End Class

