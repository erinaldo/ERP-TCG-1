<DataContract()> _
Public Class e_DetallePlanilla
    Implements Ie_DetallePlanilla
    Implements IEquatable(Of e_DetallePlanilla)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idplanilla As String
    Private _idtrabajador As String
    Private _dni As String
    Private _trabajador As String
    Private _idcentro As String
    Private _centro As String
    Private _idarea As String
    Private _area As String
    Private _idocupacion As String
    Private _ocupacion As String
    Private _unidad As String
    Private _gerencia As String
    Private _indruta As Integer
    Private _indestado As Integer
    Private _indhijo As Integer
    Private _idempresaafp As String
    Private _empresaafp As String
    Private _indtipoafp As Integer
    Private _indtipoaux As Integer
    Private _diasfaltas As Integer
    Private _diasdescanso As Integer
    Private _diasvacaciones As Integer
    Private _diascompra As Integer
    Private _idcuentacorriente As String
    Private _cuentacorriente As String
    Private _idbanco As String
    Private _ingresos As Double
    Private _deducciones As Double
    Private _aportes As Double
    Private _importepagar As Double
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _fechamodifica As Date
    Private _usuariomodifica As String
    Private _activo As Boolean
    Private _isPagado As Boolean
    Private _indtipo As Integer
    'Private _tipo As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public NroMes As Integer
    <DataMember()>
    Public Equivale As Integer
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
    Public Property IdPlanilla() As String
        Get
            Return _idplanilla
        End Get
        Set(ByVal value As String)
            _idplanilla = value
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
    Public Property IdCentro() As String
        Get
            Return _idcentro
        End Get
        Set(ByVal value As String)
            _idcentro = value
        End Set
    End Property

    <DataMember()> _
    Public Property Centro() As String
        Get
            Return _centro
        End Get
        Set(ByVal value As String)
            _centro = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdArea() As String
        Get
            Return _idarea
        End Get
        Set(ByVal value As String)
            _idarea = value
        End Set
    End Property

    <DataMember()> _
    Public Property Area() As String
        Get
            Return _area
        End Get
        Set(ByVal value As String)
            _area = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdOcupacion() As String
        Get
            Return _idocupacion
        End Get
        Set(ByVal value As String)
            _idocupacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Ocupacion() As String
        Get
            Return _ocupacion
        End Get
        Set(ByVal value As String)
            _ocupacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Unidad() As String
        Get
            Return _unidad
        End Get
        Set(ByVal value As String)
            _unidad = value
        End Set
    End Property

    <DataMember()> _
    Public Property Gerencia() As String
        Get
            Return _gerencia
        End Get
        Set(ByVal value As String)
            _gerencia = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndRuta() As Integer
        Get
            Return _indruta
        End Get
        Set(ByVal value As Integer)
            _indruta = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndEstado() As Integer
        Get
            Return _indestado
        End Get
        Set(ByVal value As Integer)
            _indestado = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndHijo() As Integer
        Get
            Return _indhijo
        End Get
        Set(ByVal value As Integer)
            _indhijo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEmpresaAFP() As String
        Get
            Return _idempresaafp
        End Get
        Set(ByVal value As String)
            _idempresaafp = value
        End Set
    End Property

    <DataMember()> _
    Public Property EmpresaAFP() As String
        Get
            Return _empresaafp
        End Get
        Set(ByVal value As String)
            _empresaafp = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndTipoAFP() As Integer
        Get
            Return _indtipoafp
        End Get
        Set(ByVal value As Integer)
            _indtipoafp = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndTipoAux() As Integer
        Get
            Return _indtipoaux
        End Get
        Set(ByVal value As Integer)
            _indtipoaux = value
        End Set
    End Property

    <DataMember()> _
    Public Property DiasFaltas() As Integer
        Get
            Return _diasfaltas
        End Get
        Set(ByVal value As Integer)
            _diasfaltas = value
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
    Public Property DiasVacaciones() As Integer
        Get
            Return _diasvacaciones
        End Get
        Set(ByVal value As Integer)
            _diasvacaciones = value
        End Set
    End Property

    <DataMember()> _
    Public Property DiasCompra() As Integer
        Get
            Return _diascompra
        End Get
        Set(ByVal value As Integer)
            _diascompra = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCuentaCorriente() As String
        Get
            Return _idcuentacorriente
        End Get
        Set(ByVal value As String)
            _idcuentacorriente = value
        End Set
    End Property

    <DataMember()> _
    Public Property CuentaCorriente() As String
        Get
            Return _cuentacorriente
        End Get
        Set(ByVal value As String)
            _cuentacorriente = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdBanco() As String
        Get
            Return _idbanco
        End Get
        Set(ByVal value As String)
            _idbanco = value
        End Set
    End Property

    <DataMember()> _
    Public Property Ingresos() As Double
        Get
            Return _ingresos
        End Get
        Set(ByVal value As Double)
            _ingresos = value
        End Set
    End Property

    <DataMember()> _
    Public Property Deducciones() As Double
        Get
            Return _deducciones
        End Get
        Set(ByVal value As Double)
            _deducciones = value
        End Set
    End Property

    <DataMember()> _
    Public Property Aportes() As Double
        Get
            Return _aportes
        End Get
        Set(ByVal value As Double)
            _aportes = value
        End Set
    End Property

    <DataMember()> _
    Public Property ImportePagar() As Double
        Get
            Return _importepagar
        End Get
        Set(ByVal value As Double)
            _importepagar = value
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
    Public Property IsPagado() As Boolean
        Get
            Return _isPagado
        End Get
        Set(ByVal value As Boolean)
            _isPagado = value
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

    '<DataMember()> _
    'Public Property Tipo() As String
    '    Get
    '        Return _tipo
    '    End Get
    '    Set(ByVal value As String)
    '        _tipo = value
    '    End Set
    'End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _id = String.Empty
        _idplanilla = String.Empty
        _idtrabajador = String.Empty
        _trabajador = String.Empty
        _idcentro = String.Empty
        _centro = String.Empty
        _idarea = String.Empty
        _area = String.Empty
        _idocupacion = String.Empty
        _ocupacion = String.Empty
        _indruta = -1
        _indestado = -1
        _indhijo = -1
        _idempresaafp = String.Empty
        _empresaafp = String.Empty
        _indtipoafp = -1
        _indtipoaux = -1
        _diasfaltas = 0
        _diasdescanso = 0
        _diasvacaciones = 0
        _diascompra = 0
        _idcuentacorriente = String.Empty
        _cuentacorriente = String.Empty
        _idbanco = String.Empty
        _ingresos = 0
        _deducciones = 0
        _aportes = 0
        _importepagar = 0
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _fechamodifica = #1/1/1901#
        _usuariomodifica = String.Empty
        _activo = True
        _isPagado = False
        _indtipo = -1
    End Sub

    Public Sub New( _
          ByVal ls_Id As String _
          , ByVal ls_IdPlanilla As String _
          , ByVal ls_IdTrabajador As String _
          , ByVal ls_Dni As String _
          , ByVal ls_Trabajador As String _
          , ByVal ls_IdCentro As String _
          , ByVal ls_Centro As String _
          , ByVal ls_IdArea As String _
          , ByVal ls_Area As String _
          , ByVal ls_IdOcupacion As String _
          , ByVal ls_Ocupacion As String _
          , ByVal ln_IndRuta As Integer _
          , ByVal ln_IndEstado As Integer _
          , ByVal ln_IndHijo As Integer _
          , ByVal ls_IdEmpresaAFP As String _
          , ByVal ls_EmpresaAFP As String _
          , ByVal ln_IndTipoAFP As Integer _
          , ByVal ln_IndTipoAux As Integer _
          , ByVal ln_DiasFaltas As Integer _
          , ByVal ln_DiasDescanso As Integer _
          , ByVal ln_DiasVacaciones As Integer _
          , ByVal ln_DiasCompra As Integer _
          , ByVal ls_IdCuentaCorriente As String _
          , ByVal ls_CuentaCorriente As String _
          , ByVal ls_IdBanco As String _
          , ByVal ln_Ingresos As Double _
          , ByVal ln_Deducciones As Double _
          , ByVal ln_Aportes As Double _
          , ByVal ln_ImportePagar As Double _
          , ByVal ld_FechaCreacion As Date _
          , ByVal ls_UsuarioCreacion As String _
          , ByVal ld_FechaModifica As Date _
          , ByVal ls_UsuarioModifica As String _
          , ByVal lb_Activo As Boolean _
       )
        _id = ls_Id
        _idplanilla = ls_IdPlanilla
        _idtrabajador = ls_IdTrabajador
        _dni = ls_Dni
        _trabajador = ls_Trabajador
        _idcentro = ls_IdCentro
        _centro = ls_Centro
        _idarea = ls_IdArea
        _area = ls_Area
        _idocupacion = ls_IdOcupacion
        _ocupacion = ls_Ocupacion
        _indruta = ln_IndRuta
        _indestado = ln_IndEstado
        _indhijo = ln_IndHijo
        _idempresaafp = ls_IdEmpresaAFP
        _empresaafp = ls_EmpresaAFP
        _indtipoafp = ln_IndTipoAFP
        _indtipoaux = ln_IndTipoAux
        _diasfaltas = ln_DiasFaltas
        _diasdescanso = ln_DiasDescanso
        _diasvacaciones = ln_DiasVacaciones
        _diascompra = ln_DiasCompra
        _idcuentacorriente = ls_IdCuentaCorriente
        _cuentacorriente = ls_CuentaCorriente
        _idbanco = ls_IdBanco
        _ingresos = ln_Ingresos
        _deducciones = ln_Deducciones
        _aportes = ln_Aportes
        _importepagar = ln_ImportePagar
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _fechamodifica = ld_FechaModifica
        _usuariomodifica = ls_UsuarioModifica
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function obtener(oeDetallePlanilla As e_DetallePlanilla) As e_DetallePlanilla Implements Ie_DetallePlanilla.obtener
        Return oeDetallePlanilla
    End Function

    Public Overloads Function Equals(ByVal oeDetPla As e_DetallePlanilla) As Boolean Implements System.IEquatable(Of e_DetallePlanilla).Equals
        Select Case oeDetPla.Equivale
            Case 1 : If Me.Id = oeDetPla.Id Then Return True
            Case 2 : If Me.IdTrabajador = oeDetPla.IdTrabajador Then Return True
        End Select
        Return False
    End Function

#End Region

End Class
