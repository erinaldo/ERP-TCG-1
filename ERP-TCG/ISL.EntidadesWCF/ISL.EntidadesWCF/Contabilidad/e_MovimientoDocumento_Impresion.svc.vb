Public Class e_MovimientoDocumento_Impresion


#Region "Declaración de variables"

    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    <DataMember()>
    Public TipoOperacion As String
    <DataMember()>
    Public Modificado As Boolean = False
    <DataMember()>
    Public Equivale As Integer
    <DataMember()>
    Public IndPrincipal As Integer
    <DataMember()>
    Public CargaCompleta As Boolean

    Public Event DatoCambiado()

    Private _Id As String
    Private _IdMovimientoDocumento As String
    Private _IdTipoDocumento As String
    Private _TipoDocumento As String
    Private _IdTurno As String
    Private _Turno As String
    Private _NombreClienteProveedor As String
    Private _NroDocumentoClienteProveedor As String
    Private _IdDireccion As String
    Private _Direccion As String
    Private _IdVechiculo As String
    Private _Placa As String
    Private _IdMedioPago As String
    Private _MedioPago As String
    Private _IdTrabajador As String
    Private _Trabajador As String
    Private _Activo As Boolean
    Private _UsuarioCreacion As String
    Private _FechaCreacion As Date
    Private _UsuarioModifica As String
    Private _FechaModificacion As Date
#End Region

#Region "Constructor"
    Public Sub New()
        TipoOperacion = ""
        _Id = ""
        _IdMovimientoDocumento = ""
        _IdTipoDocumento = ""
        _TipoDocumento = ""
        _IdTurno = ""
        _Turno = ""
        _NombreClienteProveedor = ""
        _NroDocumentoClienteProveedor = ""
        _IdDireccion = ""
        _Direccion = ""
        _IdVechiculo = ""
        _Placa = ""
        _IdMedioPago = ""
        _MedioPago = ""
        _IdTrabajador = ""
        _Trabajador = ""
        _Activo = True
        _UsuarioCreacion = ""
        _FechaCreacion = #01/01/1901#
        _UsuarioModifica = ""
        _FechaModificacion = #01/01/1901#
    End Sub

    Public Sub New(
              ByVal ls_Id As String _
              , ByVal ls_IdMovimientoDocumento As String _
              , ByVal ls_IdTipoDocumento As String _
              , ByVal ls_TipoDocumento As String _
              , ByVal ls_IdTurno As String _
              , ByVal ls_Turno As String _
              , ByVal ls_NombreClienteProveedor As String _
              , ByVal ls_NroDocumentoClienteProveedor As String _
              , ByVal ls_IdDireccion As String _
              , ByVal ls_Direccion As String _
              , ByVal ls_IdVechiculo As String _
              , ByVal ls_Placa As String _
              , ByVal ls_IdMedioPago As String _
              , ByVal ls_MedioPago As String _
              , ByVal ls_IdTrabajador As String _
              , ByVal ls_Trabajador As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioModifica As String _
              , ByVal ld_FechaModificacion As Date
           )
        _Id = ls_Id
        _IdMovimientoDocumento = ls_IdMovimientoDocumento
        _IdTipoDocumento = ls_IdTipoDocumento
        _TipoDocumento = ls_TipoDocumento
        _IdTurno = ls_IdTurno
        _Turno = ls_Turno
        _NombreClienteProveedor = ls_NombreClienteProveedor
        _NroDocumentoClienteProveedor = ls_NroDocumentoClienteProveedor
        _IdDireccion = ls_IdDireccion
        _Direccion = ls_Direccion
        _IdVechiculo = ls_IdVechiculo
        _Placa = ls_Placa
        _IdMedioPago = ls_IdMedioPago
        _MedioPago = ls_MedioPago
        _IdTrabajador = ls_IdTrabajador
        _Trabajador = ls_Trabajador
        _Activo = lb_Activo
        _UsuarioCreacion = ls_UsuarioCreacion
        _FechaCreacion = ld_FechaCreacion
        _UsuarioModifica = ls_UsuarioModifica
        _FechaModificacion = ld_FechaModificacion
    End Sub

#End Region
#Region "Propiedades"


    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property
    Public Property IdMovimientoDocumento() As String
        Get
            Return _IdMovimientoDocumento
        End Get
        Set(ByVal value As String)
            _IdMovimientoDocumento = value
        End Set
    End Property
    Public Property IdTipoDocumento() As String
        Get
            Return _IdTipoDocumento
        End Get
        Set(ByVal value As String)
            _IdTipoDocumento = value
        End Set
    End Property
    Public Property TipoDocumento() As String
        Get
            Return _TipoDocumento
        End Get
        Set(ByVal value As String)
            _TipoDocumento = value
        End Set
    End Property
    Public Property IdTurno() As String
        Get
            Return _IdTurno
        End Get
        Set(ByVal value As String)
            _IdTurno = value
        End Set
    End Property
    Public Property Turno() As String
        Get
            Return _Turno
        End Get
        Set(ByVal value As String)
            _Turno = value
        End Set
    End Property
    Public Property NombreClienteProveedor() As String
        Get
            Return _NombreClienteProveedor
        End Get
        Set(ByVal value As String)
            _NombreClienteProveedor = value
        End Set
    End Property
    Public Property NroDocumentoClienteProveedor() As String
        Get
            Return _NroDocumentoClienteProveedor
        End Get
        Set(ByVal value As String)
            _NroDocumentoClienteProveedor = value
        End Set
    End Property
    Public Property IdDireccion() As String
        Get
            Return _IdDireccion
        End Get
        Set(ByVal value As String)
            _IdDireccion = value
        End Set
    End Property
    Public Property Direccion() As String
        Get
            Return _Direccion
        End Get
        Set(ByVal value As String)
            _Direccion = value
        End Set
    End Property
    Public Property IdVechiculo() As String
        Get
            Return _IdVechiculo
        End Get
        Set(ByVal value As String)
            _IdVechiculo = value
        End Set
    End Property
    Public Property Placa() As String
        Get
            Return _Placa
        End Get
        Set(ByVal value As String)
            _Placa = value
        End Set
    End Property
    Public Property IdMedioPago() As String
        Get
            Return _IdMedioPago
        End Get
        Set(ByVal value As String)
            _IdMedioPago = value
        End Set
    End Property
    Public Property MedioPago() As String
        Get
            Return _MedioPago
        End Get
        Set(ByVal value As String)
            _MedioPago = value
        End Set
    End Property
    Public Property IdTrabajador() As String
        Get
            Return _IdTrabajador
        End Get
        Set(ByVal value As String)
            _IdTrabajador = value
        End Set
    End Property
    Public Property Trabajador() As String
        Get
            Return _Trabajador
        End Get
        Set(ByVal value As String)
            _Trabajador = value
        End Set
    End Property
    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
        End Set
    End Property
    Public Property UsuarioCreacion() As String
        Get
            Return _UsuarioCreacion
        End Get
        Set(ByVal value As String)
            _UsuarioCreacion = value
        End Set
    End Property
    Public Property FechaCreacion() As Date
        Get
            Return _FechaCreacion
        End Get
        Set(ByVal value As Date)
            _FechaCreacion = value
        End Set
    End Property
    Public Property UsuarioModifica() As String
        Get
            Return _UsuarioModifica
        End Get
        Set(ByVal value As String)
            _UsuarioModifica = value
        End Set
    End Property
    Public Property FechaModificacion() As Date
        Get
            Return _FechaModificacion
        End Get
        Set(ByVal value As Date)
            _FechaModificacion = value
        End Set
    End Property
#End Region
End Class