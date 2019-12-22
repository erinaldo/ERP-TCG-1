Imports ERP.EntidadesWCF


Public Class e_CierreTurno
    Implements Ie_CierreTurno
    Implements IEquatable(Of e_CierreTurno)

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

#Region "Declaración de variables"

    Private _Id As String
    Private _IdEmpresaSis As String
    Private _IdSucursal As String
    Private _IdTurno As String
    Private _Turno As String
    Private _IdEstado As String
    Private _Estado As String
    Private _Fecha As Date
    Private _HoraInicio As Date
    Private _HoraFin As Date
    Private _IdTrabajador_Apertura As String
    Private _Trabajador_Apertura As String
    Private _IdTrabajador_Cierre As String
    Private _Trabajador_Cierre As String
    Private _Glosa As String
    Private _UsuarioCrea As String
    Private _FechaCrea As Date
    Private _UsuarioModifica As String
    Private _FechaModifica As Date
    Private _Activo As Boolean
    Public Detalles As New List(Of e_CierreTurno_Detalle)

#End Region
#Region "Constructor"
    Public Sub New()
        _Id = ""
        _IdEmpresaSis = ""
        _IdSucursal = ""
        _IdTurno = ""
        _Turno = ""
        _IdEstado = ""
        _Estado = ""
        _Fecha = #01/01/1901#
        _HoraInicio = #01/01/1901#
        _HoraFin = #01/01/1901#
        _IdTrabajador_Apertura = ""
        _Trabajador_Apertura = ""
        _IdTrabajador_Cierre = ""
        _Trabajador_Cierre = ""
        _Glosa = ""
        _UsuarioCrea = ""
        _FechaCrea = #01/01/1901#
        _UsuarioModifica = ""
        _FechaModifica = #01/01/1901#
        _Activo = True
    End Sub

    Public Sub New(
          ByVal ls_Id As String _
          , ByVal ls_IdEmpresaSis As String _
          , ByVal ls_IdSucursal As String _
          , ByVal ls_IdTurno As String _
          , ByVal ls_Turno As String _
          , ByVal ls_IdEstado As String _
          , ByVal ls_Estado As String _
          , ByVal ld_Fecha As Date _
          , ByVal ld_HoraInicio As Date _
          , ByVal ld_HoraFin As Date _
          , ByVal ls_IdTrabajador_Apertura As String _
          , ByVal ls_Trabajador_Apertura As String _
          , ByVal ls_IdTrabajador_Cierre As String _
          , ByVal ls_Trabajador_Cierre As String _
          , ByVal ls_Glosa As String _
          , ByVal ls_UsuarioCrea As String _
          , ByVal ld_FechaCrea As Date _
          , ByVal ls_UsuarioModifica As String _
          , ByVal ld_FechaModifica As Date _
          , ByVal lb_Activo As Boolean
       )
        _Id = ls_Id
        _IdEmpresaSis = ls_IdEmpresaSis
        _IdSucursal = ls_IdSucursal
        _IdTurno = ls_IdTurno
        _Turno = ls_Turno
        _IdEstado = ls_IdEstado
        _Estado = ls_Estado
        _Fecha = ld_Fecha
        _HoraInicio = ld_HoraInicio
        _HoraFin = ld_HoraFin
        _IdTrabajador_Apertura = ls_IdTrabajador_Apertura
        _Trabajador_Apertura = ls_Trabajador_Apertura
        _IdTrabajador_Cierre = ls_IdTrabajador_Cierre
        _Trabajador_Cierre = ls_Trabajador_Cierre
        _Glosa = ls_Glosa
        _UsuarioCrea = ls_UsuarioCrea
        _FechaCrea = ld_FechaCrea
        _UsuarioModifica = ls_UsuarioModifica
        _FechaModifica = ld_FechaModifica
        _Activo = lb_Activo
    End Sub

    Public Function Obtener(Item As e_CierreTurno) As e_CierreTurno Implements Ie_CierreTurno.Obtener
        Throw New NotImplementedException()
    End Function

    Public Function Equals(other As e_CierreTurno) As Boolean Implements IEquatable(Of e_CierreTurno).Equals
        Throw New NotImplementedException()
    End Function

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

    Public Property IdEmpresaSis() As String
        Get
            Return _IdEmpresaSis
        End Get
        Set(ByVal value As String)
            _IdEmpresaSis = value
        End Set
    End Property

    Public Property IdSucursal() As String
        Get
            Return _IdSucursal
        End Get
        Set(ByVal value As String)
            _IdSucursal = value
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

    Public Property IdEstado() As String
        Get
            Return _IdEstado
        End Get
        Set(ByVal value As String)
            _IdEstado = value
        End Set
    End Property

    Public Property Estado() As String
        Get
            Return _Estado
        End Get
        Set(ByVal value As String)
            _Estado = value
        End Set
    End Property

    Public Property Fecha() As Date
        Get
            Return _Fecha
        End Get
        Set(ByVal value As Date)
            _Fecha = value
        End Set
    End Property

    Public Property HoraInicio() As Date
        Get
            Return _HoraInicio
        End Get
        Set(ByVal value As Date)
            _HoraInicio = value
        End Set
    End Property

    Public Property HoraFin() As Date
        Get
            Return _HoraFin
        End Get
        Set(ByVal value As Date)
            _HoraFin = value
        End Set
    End Property

    Public Property IdTrabajador_Apertura() As String
        Get
            Return _IdTrabajador_Apertura
        End Get
        Set(ByVal value As String)
            _IdTrabajador_Apertura = value
        End Set
    End Property

    Public Property Trabajador_Apertura() As String
        Get
            Return _Trabajador_Apertura
        End Get
        Set(ByVal value As String)
            _Trabajador_Apertura = value
        End Set
    End Property

    Public Property IdTrabajador_Cierre() As String
        Get
            Return _IdTrabajador_Cierre
        End Get
        Set(ByVal value As String)
            _IdTrabajador_Cierre = value
        End Set
    End Property

    Public Property Trabajador_Cierre() As String
        Get
            Return _Trabajador_Cierre
        End Get
        Set(ByVal value As String)
            _Trabajador_Cierre = value
        End Set
    End Property

    Public Property Glosa() As String
        Get
            Return _Glosa
        End Get
        Set(ByVal value As String)
            _Glosa = value
        End Set
    End Property

    Public Property UsuarioCrea() As String
        Get
            Return _UsuarioCrea
        End Get
        Set(ByVal value As String)
            _UsuarioCrea = value
        End Set
    End Property

    Public Property FechaCrea() As Date
        Get
            Return _FechaCrea
        End Get
        Set(ByVal value As Date)
            _FechaCrea = value
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

    Public Property FechaModifica() As Date
        Get
            Return _FechaModifica
        End Get
        Set(ByVal value As Date)
            _FechaModifica = value
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

#End Region

End Class
