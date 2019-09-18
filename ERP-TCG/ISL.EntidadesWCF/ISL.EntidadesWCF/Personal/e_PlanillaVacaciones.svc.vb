<DataContract()> _
Public Class e_PlanillaVacaciones
    Implements Ie_PlanillaVacaciones

#Region "Declaracion de Variables"

    Private _id As String
    Private _idplanilla As String
    Private _planilla As String
    Private _codigo As String
    Private _monto As Double
    Private _descripcion As String
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
    Public leDetalle As New List(Of e_DetallePlanillaVacaciones)
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
    Public Property IdPlanilla() As String
        Get
            Return _idplanilla
        End Get
        Set(ByVal value As String)
            _idplanilla = value
        End Set
    End Property

    <DataMember()> _
    Public Property Planilla() As String
        Get
            Return _planilla
        End Get
        Set(ByVal value As String)
            _planilla = value
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
    Public Property Monto() As Double
        Get
            Return _monto
        End Get
        Set(ByVal value As Double)
            _monto = value
        End Set
    End Property

    <DataMember()> _
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
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
        _idplanilla = String.Empty
        _planilla = String.Empty
        _codigo = String.Empty
        _monto = 0
        _descripcion = String.Empty
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
                  , ByVal ls_IdPlanilla As String _
                  , ByVal ls_Planilla As String _
                  , ByVal ls_Codigo As String _
                  , ByVal ln_Monto As Double _
                  , ByVal ls_Descripcion As String _
                  , ByVal ls_IdEstado As String _
                  , ByVal ls_Estado As String _
                  , ByVal ld_FechaCreacion As Date _
                  , ByVal ls_UsuarioCreacion As String _
                  , ByVal ld_FechaModifica As Date _
                  , ByVal ls_UsuarioModifica As String _
                  , ByVal lb_Activo As Boolean _
               )
        _id = ls_Id
        _idplanilla = ls_IdPlanilla
        _planilla = ls_Planilla
        _codigo = ls_Codigo
        _monto = ln_Monto
        _descripcion = ls_Descripcion
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

    Public Function obtener(oePlanillaVacaciones As e_PlanillaVacaciones) As e_PlanillaVacaciones Implements Ie_PlanillaVacaciones.obtener
        Return oePlanillaVacaciones
    End Function

#End Region

End Class
