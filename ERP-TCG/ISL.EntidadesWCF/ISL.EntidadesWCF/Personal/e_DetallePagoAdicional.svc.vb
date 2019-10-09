<DataContract()> _
Public Class e_DetallePagoAdicional
    Implements Ie_DetallePagoAdicional
    Implements IEquatable(Of e_DetallePagoAdicional)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idpagoadicional As String
    Private _idtrabajador As String
    Private _dni As String
    Private _trabajador As String
    Private _sueldo As Double
    Private _asignacionfamiliar As Double
    Private _renumeracion As Double
    Private _indtipo As Integer
    Private _tipo As String
    Private _cantidad As Double
    Private _monto As Double
    Private _redondeo As Double
    Private _diasvacaciones As Integer
    Private _diasfalta As Integer
    Private _diasdescanso As Integer
    Private _totaldias As Integer
    Private _totalpagar As Double
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _fechamodifica As Date
    Private _usuariomodifica As String
    Private _activo As Boolean
    Private _horasextras As Integer
    Private _minutosextras As Integer

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
    <DataMember()> _
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
    Public Property IdPagoAdicional() As String
        Get
            Return _idpagoadicional
        End Get
        Set(ByVal value As String)
            _idpagoadicional = value
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
    Public Property Sueldo() As Decimal
        Get
            Return _sueldo
        End Get
        Set(ByVal value As Decimal)
            _sueldo = value
        End Set
    End Property

    <DataMember()> _
    Public Property AsignacionFamiliar() As Decimal
        Get
            Return _asignacionfamiliar
        End Get
        Set(ByVal value As Decimal)
            _asignacionfamiliar = value
        End Set
    End Property

    <DataMember()> _
    Public Property Renumeracion() As Decimal
        Get
            _renumeracion = Sueldo + AsignacionFamiliar
            Return _renumeracion
        End Get
        Set(ByVal value As Decimal)
            _renumeracion = value
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
    Public Property Cantidad() As Double
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Double)
            _cantidad = value
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
    Public Property DiasVacaciones() As Integer
        Get
            Return _diasvacaciones
        End Get
        Set(ByVal value As Integer)
            _diasvacaciones = value
        End Set
    End Property

    <DataMember()> _
    Public Property DiasFalta() As Integer
        Get
            Return _diasfalta
        End Get
        Set(ByVal value As Integer)
            _diasfalta = value
        End Set
    End Property

    <DataMember()> _
    Public Property DiasDescanso() As Integer
        Get
            Return _diasdescanso
        End Get
        Set(ByVal value As Integer)
            _diasdescanso = value
        End Set
    End Property

    <DataMember()> _
    Public Property TotalDias() As Integer
        Get
            _totaldias = DiasDescanso + DiasFalta + DiasVacaciones
            Return _totaldias
        End Get
        Set(ByVal value As Integer)
            _totaldias = value
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

    <DataMember()> _
    Public Property HorasExtras() As Integer
        Get
            Return _horasextras
        End Get
        Set(ByVal value As Integer)
            _horasextras = value
        End Set
    End Property

    <DataMember()> _
    Public Property MinutosExtras() As Integer
        Get
            Return _minutosextras
        End Get
        Set(ByVal value As Integer)
            _minutosextras = value
        End Set
    End Property

#End Region

#Region "Construtor"

    Public Sub New()
        _id = String.Empty
        _idpagoadicional = String.Empty
        _idtrabajador = String.Empty
        _dni = String.Empty
        _trabajador = String.Empty
        _indtipo = 0
        _cantidad = 0
        _monto = 0
        _redondeo = 0
        _diasvacaciones = 0
        _diasfalta = 0
        _diasdescanso = 0
        _totaldias = 0
        _totalpagar = 0
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _fechamodifica = #1/1/1901#
        _usuariomodifica = String.Empty
        _activo = True
        _horasextras = 0
        _minutosextras = 0
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdPagoAdicional As String _
              , ByVal ls_IdPlanilla As String _
              , ByVal ls_IdTrabajador As String _
              , ByVal ls_Dni As String _
              , ByVal ls_Trabajador As String _
              , ByVal ln_Sueldo As Double _
              , ByVal ln_AsignacionFamiliar As Double _
              , ByVal ln_IndTipo As Integer _
              , ByVal ln_Cantidad As Double _
              , ByVal ln_Monto As Double _
              , ByVal ln_Redondeo As Double _
              , ByVal ln_DiasVacaciones As Integer _
              , ByVal ln_DiasFalta As Integer _
              , ByVal ln_DiasDescanso As Integer _
              , ByVal ln_TotalPagar As Double _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaModifica As Date _
              , ByVal ls_UsuarioModifica As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idpagoadicional = ls_IdPagoAdicional
        IdPlanilla = ls_IdPlanilla
        _idtrabajador = ls_IdTrabajador
        _dni = ls_Dni
        _trabajador = ls_Trabajador
        _sueldo = ln_Sueldo
        _asignacionfamiliar = ln_AsignacionFamiliar
        _indtipo = ln_IndTipo
        _cantidad = ln_Cantidad
        _monto = ln_Monto
        _redondeo = ln_Redondeo
        _diasvacaciones = ln_DiasVacaciones
        _diasfalta = ln_DiasFalta
        _diasdescanso = ln_DiasDescanso
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

    Public Function obtener(oeDetallePagoAdicional As e_DetallePagoAdicional) As e_DetallePagoAdicional Implements Ie_DetallePagoAdicional.obtener
        Return oeDetallePagoAdicional
    End Function

    Public Overloads Function Equals(ByVal oeDPA As e_DetallePagoAdicional) As Boolean Implements System.IEquatable(Of e_DetallePagoAdicional).Equals
        Select Case oeDPA.TipoBusca
            Case 1 : If Me.Id.Trim = oeDPA.Id.Trim Then Return True
            Case 2 : If Me.IdTrabajador.Trim = oeDPA.IdTrabajador.Trim And Me.IndTipo = oeDPA.IndTipo And Me.Id = "" Then Return True
        End Select
        Return False
    End Function

#End Region

End Class
