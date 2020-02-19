<DataContract()> _
Public Class e_DetallePlanillaVacaciones
    Implements Ie_DetallePlanillaVacaciones
    Implements IEquatable(Of e_DetallePlanillaVacaciones)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idtrabajador As String
    Private _dni As String
    Private _trabajador As String
    Private _idplanillavacaciones As String
    Private _sueldo As Double
    Private _asignacionfamiliar As Double
    Private _diasvacaciones As Integer
    Private _produccion1 As Double
    Private _produccion2 As Double
    Private _produccion3 As Double
    Private _produccion4 As Double
    Private _produccion5 As Double
    Private _produccion6 As Double
    Private _indprombono As Integer
    Private _promedioproduccion As Double
    Private _renumeracion As Double
    Private _monto As Double
    Private _totalpagar As Double
    Private _indadelanto As Integer
    Private _montoadelanto As Double
    Private _montodescuento As Double
    Private _diascomprados As Double
    Private _montocomprado As Double
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _fechamodifica As Date
    Private _usuariomodifica As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
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
    Public Property IdPlanillaVacaciones() As String
        Get
            Return _idplanillavacaciones
        End Get
        Set(ByVal value As String)
            _idplanillavacaciones = value
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
    Public Property Sueldo() As Double
        Get
            Return _sueldo
        End Get
        Set(ByVal value As Double)
            _sueldo = value
        End Set
    End Property

    <DataMember()> _
    Public Property AsignacionFamiliar() As Double
        Get
            Return _asignacionfamiliar
        End Get
        Set(ByVal value As Double)
            _asignacionfamiliar = value
        End Set
    End Property

    <DataMember()> _
    Public Property Renumeracion() As Double
        Get
            _renumeracion = Sueldo + AsignacionFamiliar
            Return _renumeracion
        End Get
        Set(ByVal value As Double)
            _renumeracion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Produccion1() As Double
        Get
            Return _produccion1
        End Get
        Set(ByVal value As Double)
            _produccion1 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Produccion2() As Double
        Get
            Return _produccion2
        End Get
        Set(ByVal value As Double)
            _produccion2 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Produccion3() As Double
        Get
            Return _produccion3
        End Get
        Set(ByVal value As Double)
            _produccion3 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Produccion4() As Double
        Get
            Return _produccion4
        End Get
        Set(ByVal value As Double)
            _produccion4 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Produccion5() As Double
        Get
            Return _produccion5
        End Get
        Set(ByVal value As Double)
            _produccion5 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Produccion6() As Double
        Get
            Return _produccion6
        End Get
        Set(ByVal value As Double)
            _produccion6 = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndPromBono() As Integer
        Get
            Return _indprombono
        End Get
        Set(ByVal value As Integer)
            _indprombono = value
        End Set
    End Property

    <DataMember()> _
    Public Property PromedioProduccion() As Double
        Get
            'If IndPromBono = 1 Then
            '    _promedioproduccion = (Produccion1 + Produccion2 + Produccion3 + Produccion4 + Produccion5 + Produccion6) / 6
            'Else
            '    _promedioproduccion = 0
            'End If
            Return _promedioproduccion
        End Get
        Set(ByVal value As Double)
            _promedioproduccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Monto() As Double
        Get
            _monto = (Renumeracion + PromedioProduccion) - AsignacionFamiliar
            Return _monto
        End Get
        Set(ByVal value As Double)
            _monto = value
        End Set
    End Property

    <DataMember()> _
    Public Property TotalPagar() As Double
        Get
            _totalpagar = Monto / 30 * DiasVacaciones
            Return _totalpagar
        End Get
        Set(ByVal value As Double)
            _totalpagar = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndAdelanto() As Integer
        Get
            Return _indadelanto
        End Get
        Set(ByVal value As Integer)
            _indadelanto = value
        End Set
    End Property

    <DataMember()> _
    Public Property MontoAdelanto() As Double
        Get
            Return _montoadelanto
        End Get
        Set(ByVal value As Double)
            _montoadelanto = value
        End Set
    End Property

    <DataMember()> _
    Public Property MontoDescuento() As Double
        Get
            Return _montodescuento
        End Get
        Set(ByVal value As Double)
            _montodescuento = value
        End Set
    End Property

    <DataMember()> _
    Public Property DiasComprados() As Double
        Get
            Return _diascomprados
        End Get
        Set(ByVal value As Double)
            _diascomprados = value
        End Set
    End Property

    <DataMember()> _
    Public Property MontoComprado() As Double
        Get
            _montocomprado = Monto / 30 * DiasComprados
            Return _montocomprado
        End Get
        Set(ByVal value As Double)
            _montocomprado = value
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
        _idtrabajador = String.Empty
        _dni = String.Empty
        _trabajador = String.Empty
        _idplanillavacaciones = String.Empty
        _sueldo = 0
        _asignacionfamiliar = 0
        _produccion1 = 0
        _produccion2 = 0
        _produccion3 = 0
        _produccion4 = 0
        _produccion5 = 0
        _produccion6 = 0
        _diasvacaciones = 0
        _promedioproduccion = 0
        _renumeracion = 0
        _monto = 0
        _totalpagar = 0
        _indadelanto = 0
        _montoadelanto = 0
        _montodescuento = 0
        _diascomprados = 0
        _montocomprado = 0
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _fechamodifica = #1/1/1901#
        _usuariomodifica = String.Empty
        _activo = True
    End Sub

    Public Sub New( _
          ByVal ls_Id As String _
          , ByVal ls_IdTrabajador As String _
          , ByVal ls_Dni As String _
          , ByVal ls_Trabajador As String _
          , ByVal ls_IdPlanillaVacaciones As String _
          , ByVal ln_Sueldo As Double _
          , ByVal ln_AsignacionFamiliar As Double _
          , ByVal ln_Produccion1 As Double _
          , ByVal ln_Produccion2 As Double _
          , ByVal ln_Produccion3 As Double _
          , ByVal ln_Produccion4 As Double _
          , ByVal ln_Produccion5 As Double _
          , ByVal ln_Produccion6 As Double _
          , ByVal ln_IndPromBono As Double _
          , ByVal ln_DiasVacaciones As Integer _
          , ByVal ln_TotalPagar As Double _
          , ByVal ln_IndAdelanto As Integer _
          , ByVal ln_MontoAdelanto As Double _
          , ByVal ln_MontoDescuento As Double _
          , ByVal ln_DiasComprados As Double _
          , ByVal ln_MontoComprado As Double _
          , ByVal ld_FechaCreacion As Date _
          , ByVal ls_UsuarioCreacion As String _
          , ByVal ld_FechaModifica As Date _
          , ByVal ls_UsuarioModifica As String _
          , ByVal lb_Activo As Boolean _
       )
        _id = ls_Id
        _idtrabajador = ls_IdTrabajador
        _dni = ls_Dni
        _trabajador = ls_Trabajador
        _idplanillavacaciones = ls_IdPlanillaVacaciones
        _sueldo = ln_Sueldo
        _asignacionfamiliar = ln_AsignacionFamiliar
        _produccion1 = ln_Produccion1
        _produccion2 = ln_Produccion2
        _produccion3 = ln_Produccion3
        _produccion4 = ln_Produccion4
        _produccion5 = ln_Produccion5
        _produccion6 = ln_Produccion6
        _indprombono = ln_IndPromBono
        _diasvacaciones = ln_DiasVacaciones
        _totalpagar = ln_TotalPagar
        _indadelanto = ln_IndAdelanto
        _montoadelanto = ln_MontoAdelanto
        _montodescuento = ln_MontoDescuento
        _diascomprados = ln_DiasComprados
        _montocomprado = ln_MontoComprado
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _fechamodifica = ld_FechaModifica
        _usuariomodifica = ls_UsuarioModifica
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    'Public Function ProduccionPromedio() As Double
    '    Dim _promedio As Double = 0
    '    _promedio = (_produccion1 + _produccion2 + _produccion3 + _produccion4 + _produccion5 + _produccion6) / 6
    '    Return _promedio
    'End Function

    'Public Function RenumeracionBruta() As Double
    '    Dim _renumeracionbruta As Double = 0
    '    _renumeracionbruta = _sueldo + AsignacionFamiliar
    '    Return _renumeracionbruta
    'End Function

    Public Function obtener(oeDetallePlanillaVacaciones As e_DetallePlanillaVacaciones) As e_DetallePlanillaVacaciones Implements Ie_DetallePlanillaVacaciones.obtener
        Return oeDetallePlanillaVacaciones
    End Function

    Public Overloads Function Equals(ByVal oeDPV As e_DetallePlanillaVacaciones) As Boolean Implements System.IEquatable(Of e_DetallePlanillaVacaciones).Equals
        Select Case oeDPV.Equivale
            Case 1 : If Me.Id = oeDPV.Id Then Return True
            Case 2 : If Me.IdTrabajador = oeDPV.IdTrabajador And Me.Id = oeDPV.Id Then Return True
        End Select
        Return False
    End Function

#End Region

End Class
