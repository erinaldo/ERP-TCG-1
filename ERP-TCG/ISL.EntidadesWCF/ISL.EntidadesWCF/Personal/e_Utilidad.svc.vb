<DataContract()> _
Public Class e_Utilidad
    Implements Ie_Utilidad

#Region "Declaracion de Variables"

    Private _id As String
    Private _codigo As String
    Private _cantidadtrabajadores As Integer
    Private _montobase As Double
    Private _porcentajeparticipacion As Double
    Private _montodistribucion As Double
    Private _idestado As String
    Private _estado As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _fechamodifica As Date
    Private _usuariomodifica As String
    Private _activo As Boolean
    Private _año As Integer
    Private _totalsueldoanual As Double
    Private _totaldiasanual As Integer

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public leConsolidado As List(Of e_ConsolidadoUtilidad)
    <DataMember()> _
    Public leDetalle As List(Of e_DetalleUtilidad)
    <DataMember()> _
    Public IndImportar As Boolean = False
    <DataMember()> _
    Public dtConsolidado, dtDetalle As DataTable
    <DataMember()>
    Public PrefijoID As String = ""
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
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    <DataMember()> _
    Public Property CantidadTrabajadores() As Integer
        Get
            Return _cantidadtrabajadores
        End Get
        Set(ByVal value As Integer)
            _cantidadtrabajadores = value
        End Set
    End Property

    <DataMember()> _
    Public Property MontoBase() As Double
        Get
            Return _montobase
        End Get
        Set(ByVal value As Double)
            _montobase = value
        End Set
    End Property

    Public Property Año() As Integer
        Get
            Return _año
        End Get
        Set(ByVal value As Integer)
            _año = value
        End Set
    End Property

    Public Property TotalSueldoAnual() As Double
        Get
            Return _totalsueldoanual
        End Get
        Set(ByVal value As Double)
            _totalsueldoanual = value
        End Set
    End Property

    Public Property TotalDiasAnual() As Integer
        Get
            Return _totaldiasanual
        End Get
        Set(ByVal value As Integer)
            _totaldiasanual = value
        End Set
    End Property

    <DataMember()> _
    Public Property PorcentajeParticipacion() As Double
        Get
            Return _porcentajeparticipacion
        End Get
        Set(ByVal value As Double)
            _porcentajeparticipacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property MontoDistribucion() As Double
        Get
            Return _montodistribucion
        End Get
        Set(ByVal value As Double)
            _montodistribucion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEstado() As String
        Get
            Return _idestado
        End Get
        Set(ByVal value As String)
            _idestado = value
        End Set
    End Property

    <DataMember()> _
    Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
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
    Public Property FechaModifica() As Date
        Get
            Return _fechamodifica
        End Get
        Set(ByVal value As Date)
            _fechamodifica = value
        End Set
    End Property

    Public Property UsuarioModifica() As String
        Get
            Return _usuariomodifica
        End Get
        Set(ByVal value As String)
            _usuariomodifica = value
        End Set
    End Property

    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

#End Region

#Region "Contructor"

    Public Sub New()
        _id = String.Empty
        _codigo = String.Empty
        _cantidadtrabajadores = 0
        _montobase = 0
        _porcentajeparticipacion = 0
        _montodistribucion = 0
        _idestado = String.Empty
        _estado = String.Empty
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _fechamodifica = #1/1/1901#
        _usuariomodifica = String.Empty
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ln_CantidadTrabajadores As Integer _
              , ByVal ln_MontoBase As Double _
              , ByVal ln_PorcentajeParticipacion As Double _
              , ByVal ln_MontoDistribucion As Double _
              , ByVal ld_TotalSueldoAnual As Double _
              , ByVal li_TotalDiasAnual As Integer _
              , ByVal li_Año As Integer _
              , ByVal ls_IdEstado As String _
              , ByVal ls_Estado As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaModifica As Date _
              , ByVal ls_UsuarioModifica As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _codigo = ls_Codigo
        _cantidadtrabajadores = ln_CantidadTrabajadores
        _montobase = ln_MontoBase
        _porcentajeparticipacion = ln_PorcentajeParticipacion
        _montodistribucion = ln_MontoDistribucion
        _totaldiasanual = li_TotalDiasAnual
        _año = li_Año
        _totalsueldoanual = ld_TotalSueldoAnual
        _idestado = ls_IdEstado
        _estado = ls_Estado
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _fechamodifica = ld_FechaModifica
        _usuariomodifica = ls_UsuarioModifica
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function obtener(oeUtilidad As e_Utilidad) As e_Utilidad Implements Ie_Utilidad.obtener
        Return oeUtilidad
    End Function

#End Region

End Class
