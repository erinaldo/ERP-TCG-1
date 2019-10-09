' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_DetallePagoCajaTrabajador" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_DetallePagoCajaTrabajador.svc o e_DetallePagoCajaTrabajador.svc.vb en el Explorador de soluciones e inicie la depuración.
<DataContract()> _
Public Class e_DetallePagoCajaTrabajador
    Implements Ie_DetallePagoCajaTrabajador
    Implements IEquatable(Of e_DetallePagoCajaTrabajador)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idpagocajatrabajador As String
    Private _idtrabajador As String
    Private _dni As String
    Private _trabajador As String
    Private _indtipo As Integer
    Private _tipo As String
    Private _monto As Double
    Private _redondeo As Double
    Private _totalpagar As Double
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
    Public Calcula As Integer = 0
    <DataMember()> _
    Public IdPlanilla As String
    <DataMember()> _
    Public NroMes As Integer
    <DataMember()>
    Public TipoBusca As Integer
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
    Public Property IdPagoCajaTrabajador() As String
        Get
            Return _idpagocajatrabajador
        End Get
        Set(ByVal value As String)
            _idpagocajatrabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTrabajador() As String
        Get
            Return _idtrabajador
        End Get
        Set(ByVal value As String)
            _idtrabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property Dni() As String
        Get
            Return _dni
        End Get
        Set(ByVal value As String)
            _dni = value
        End Set
    End Property

    <DataMember()> _
    Public Property Trabajador() As String
        Get
            Return _trabajador
        End Get
        Set(ByVal value As String)
            _trabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndTipo() As Integer
        Get
            Return _indtipo
        End Get
        Set(ByVal value As Integer)
            _indtipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Tipo() As String
        Get
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Monto() As Double
        Get
            'If Calcula = 1 And IndTipo = 0 Then _monto = Renumeracion / 30 / 8 * 1.25 * Cantidad
            'If Calcula = 1 And IndTipo = 1 Then _monto = Renumeracion / 30 / 8 * 1.35 * Cantidad
            'If Calcula = 1 And IndTipo = 2 Then _monto = Renumeracion / 30 / 8 * 1.35 * Cantidad
            Return _monto
        End Get
        Set(ByVal value As Double)
            _monto = value
        End Set
    End Property

    <DataMember()> _
    Public Property Redondeo() As Double
        Get
            'Dim _res As Double = 0, _cant As Integer = 0
            'If _indtipo = 0 Then
            '    _res = Monto Mod 10
            '    If _res > 0 Then
            '        _cant = (Monto - _res) / 10
            '        _redondeo = (_cant + 1) * 10
            '    Else
            '        _redondeo = Monto
            '    End If
            'End If
            _redondeo = Monto
            Return _redondeo
        End Get
        Set(ByVal value As Double)
            _redondeo = value
        End Set
    End Property

    <DataMember()> _
    Public Property TotalPagar() As Double
        Get
            _totalpagar = Redondeo
            Return _totalpagar
        End Get
        Set(ByVal value As Double)
            _totalpagar = value
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

#Region "Construtor"

    Public Sub New()
        _id = String.Empty
        _idpagocajatrabajador = String.Empty
        _idtrabajador = String.Empty
        _dni = String.Empty
        _trabajador = String.Empty
        _indtipo = 0
        _monto = 0
        _redondeo = 0
        _totalpagar = 0
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _fechamodifica = #1/1/1901#
        _usuariomodifica = String.Empty
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdPagoCajaTrabajador As String _
              , ByVal ls_IdPlanilla As String _
              , ByVal ls_IdTrabajador As String _
              , ByVal ls_Dni As String _
              , ByVal ls_Trabajador As String _
              , ByVal ln_IndTipo As Integer _
              , ByVal ln_Monto As Double _
              , ByVal ln_Redondeo As Double _
              , ByVal ln_TotalPagar As Double _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaModifica As Date _
              , ByVal ls_UsuarioModifica As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idpagocajatrabajador = ls_IdPagoCajaTrabajador
        IdPlanilla = ls_IdPlanilla
        _idtrabajador = ls_IdTrabajador
        _dni = ls_Dni
        _trabajador = ls_Trabajador
        _indtipo = ln_IndTipo
        _monto = ln_Monto
        _redondeo = ln_Redondeo
        _totalpagar = ln_TotalPagar
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _fechamodifica = ld_FechaModifica
        _usuariomodifica = ls_UsuarioModifica
        _activo = lb_Activo
        TipoOperacion = ""
    End Sub

#End Region

#Region "Metodos"

    Public Function obtener(oeDetallePagoAdicional As e_DetallePagoCajaTrabajador) As e_DetallePagoCajaTrabajador Implements Ie_DetallePagoCajaTrabajador.obtener
        Return oeDetallePagoAdicional
    End Function

    Public Overloads Function Equals(ByVal oeDPA As e_DetallePagoCajaTrabajador) As Boolean Implements System.IEquatable(Of e_DetallePagoCajaTrabajador).Equals
        Select Case oeDPA.TipoBusca
            Case 1 : If Me.Id.Trim = oeDPA.Id.Trim Then Return True
            Case 2 : If Me.IdTrabajador.Trim = oeDPA.IdTrabajador.Trim And Me.IndTipo = oeDPA.IndTipo And Me.Id = "" Then Return True
        End Select
        Return False
    End Function

    Public Sub DoWork() Implements Ie_DetallePagoCajaTrabajador.DoWork
    End Sub

#End Region



End Class
