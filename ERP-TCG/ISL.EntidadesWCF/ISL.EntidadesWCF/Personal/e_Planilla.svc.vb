<DataContract()> _
Public Class e_Planilla
    Implements Ie_Planilla

#Region "Declaracion de Variables"

    Private _id As String
    Private _idperiodo As String
    Private _idconfiguracion As String
    Private _periodo As String
    Private _codigo As String
    Private _fechainicio As Date
    Private _fechafin As Date
    Private _tipo As Integer
    Private _nombretipo As String
    Private _importe As Double
    Private _idestado As String
    Private _estado As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _fechamodifica As Date
    Private _usuariomodifica As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public leDetalle As New List(Of e_DetallePlanilla)
    <DataMember()> _
    Public leDetalleConcepto As New List(Of e_DetalleConcepto)
    <DataMember()> _
    Public dsDetalle As Data.DataTable
    <DataMember()> _
    Public dsDetCon As Data.DataTable
    <DataMember()> _
    Public IndCargaCompleto As Boolean = False
    <DataMember()> _
    Public NroMes As Integer
    <DataMember()> _
    Public Ejercicio As Integer
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
    Public Property IdPeriodo() As String
        Get
            Return _idperiodo
        End Get
        Set(ByVal value As String)
            _idperiodo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdConfiguracion() As String
        Get
            Return _idconfiguracion
        End Get
        Set(ByVal value As String)
            _idconfiguracion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Periodo() As String
        Get
            Return _periodo
        End Get
        Set(ByVal value As String)
            _periodo = value
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
    Public Property FechaInicio() As Date
        Get
            Return _fechainicio
        End Get
        Set(ByVal value As Date)
            _fechainicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaFin() As Date
        Get
            Return _fechafin
        End Get
        Set(ByVal value As Date)
            _fechafin = value
        End Set
    End Property

    <DataMember()> _
    Public Property Tipo() As Integer
        Get
            Return _tipo
        End Get
        Set(ByVal value As Integer)
            _tipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property NombreTipo() As String
        Get
            Select Case _tipo
                Case 0 : _nombretipo = "MENSUAL"
                Case 1 : _nombretipo = "QUINCENAL"
                Case 2 : _nombretipo = "OTROS"
            End Select
            Return _nombretipo
        End Get
        Set(ByVal value As String)
            _nombretipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Importe() As Double
        Get
            Return _importe
        End Get
        Set(ByVal value As Double)
            _importe = value
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

    <DataMember()> _
    Public Property UsuarioModifica() As String
        Get
            Return _usuariomodifica
        End Get
        Set(ByVal value As String)
            _usuariomodifica = value
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
        _idperiodo = String.Empty
        _idconfiguracion = String.Empty
        _periodo = String.Empty
        _codigo = String.Empty
        _fechainicio = #1/1/1901#
        _fechafin = #1/1/1901#
        _tipo = -1
        _nombretipo = String.Empty
        _importe = 0
        _idestado = String.Empty
        _estado = String.Empty
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _fechamodifica = #1/1/1901#
        _usuariomodifica = String.Empty
        _activo = True
        TipoOperacion = String.Empty
    End Sub

    Public Sub New( _
          ByVal ls_Id As String _
          , ByVal ls_IdPeriodo As String _
          , ByVal ls_IdConfiguracion As String _
          , ByVal ls_Periodo As String _
          , ByVal ln_Ejercicio As Integer _
          , ByVal ln_NroMes As Integer _
          , ByVal ls_Codigo As String _
          , ByVal ld_FechaInicio As Date _
          , ByVal ld_FechaFin As Date _
          , ByVal ln_Tipo As Integer _
          , ByVal ln_Importe As Double _
          , ByVal ls_IdEstado As String _
          , ByVal ls_Estado As String _
          , ByVal ld_FechaCreacion As Date _
          , ByVal ls_UsuarioCreacion As String _
          , ByVal ld_FechaModifica As Date _
          , ByVal ls_UsuarioModifica As String _
          , ByVal lb_Activo As Boolean _
       )

        _id = ls_Id
        _idperiodo = ls_IdPeriodo
        _idconfiguracion = ls_IdConfiguracion
        _periodo = ls_Periodo
        Ejercicio = ln_Ejercicio
        NroMes = ln_NroMes
        _codigo = ls_Codigo
        _fechainicio = ld_FechaInicio
        _fechafin = ld_FechaFin
        _tipo = ln_Tipo
        _importe = ln_Importe
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

    Public Function obtener(oePlanilla As e_Planilla) As e_Planilla Implements Ie_Planilla.obtener
        Return oePlanilla
    End Function

#End Region

End Class
