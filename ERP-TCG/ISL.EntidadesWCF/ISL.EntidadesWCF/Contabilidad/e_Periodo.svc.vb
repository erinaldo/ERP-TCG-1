<DataContract()> _
Public Class e_Periodo
    Implements Ie_Periodo
    Implements IEquatable(Of e_Periodo)

#Region "Declaracion de Variables"

    Private _Id As String
    Private _Codigo As String
    Private _Ejercicio As Integer
    Private _Mes As Integer
    Private _NomMes As String ' Nombre Mes
    Private _FechaInicio As Date
    Private _FechaFin As Date
    Private _CierreCompras As Boolean
    Private _CierraVentas As Boolean
    Private _CierreAlmacen As Boolean
    Private _CierreTesoreria As Boolean
    Private _CierreCajaLiquidacion As Boolean
    Private _CierreContabilidad As Boolean
    Private _CierreCombustible As Boolean
    Private _cierreplanilla As Boolean
    Private _CambioCompra As Double
    Private _CambioVenta As Double
    Private _Activo As Boolean
    Private _IndCierre As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public IdUsuario As String
    <DataMember()> _
    Public Equivale As Integer
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    Public Event DatoCambiado()


#End Region

#Region "Propiedad"

    <DataMember()> _
    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Ejercicio() As Integer
        Get
            Return _Ejercicio
        End Get
        Set(ByVal value As Integer)
            _Ejercicio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Mes() As Integer
        Get
            Return _Mes
        End Get
        Set(ByVal value As Integer)
            _Mes = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NomMes() As String
        Get
            Return _NomMes
        End Get
        Set(ByVal value As String)
            _NomMes = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaInicio() As Date
        Get
            Return _FechaInicio
        End Get
        Set(ByVal value As Date)
            _FechaInicio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaFin() As Date
        Get
            Return _FechaFin
        End Get
        Set(ByVal value As Date)
            _FechaFin = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CierreCompras() As Boolean
        Get
            Return _CierreCompras
        End Get
        Set(ByVal value As Boolean)
            _CierreCompras = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CierreCajaLiquidacion() As Boolean
        Get
            Return _CierreCajaLiquidacion
        End Get
        Set(ByVal value As Boolean)
            _CierreCajaLiquidacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property CierraVentas() As Boolean
        Get
            Return _CierraVentas
        End Get
        Set(ByVal value As Boolean)
            _CierraVentas = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CierreAlmacen() As Boolean
        Get
            Return _CierreAlmacen
        End Get
        Set(ByVal value As Boolean)
            _CierreAlmacen = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CierreTesoreria() As Boolean
        Get
            Return _CierreTesoreria
        End Get
        Set(ByVal value As Boolean)
            _CierreTesoreria = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CierreContabilidad() As Boolean
        Get
            Return _CierreContabilidad
        End Get
        Set(ByVal value As Boolean)
            _CierreContabilidad = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CierrePlanilla() As Boolean
        Get
            Return _cierreplanilla
        End Get
        Set(ByVal value As Boolean)
            _cierreplanilla = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CambioCompra() As Double
        Get
            Return _CambioCompra
        End Get
        Set(ByVal value As Double)
            _CambioCompra = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CambioVenta() As Double
        Get
            Return _CambioVenta
        End Get
        Set(ByVal value As Double)
            _CambioVenta = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property CierreCombustible() As Boolean
        Get
            Return _CierreCombustible
        End Get
        Set(ByVal value As Boolean)
            _CierreCombustible = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndCierre() As String
        Get
            Return _IndCierre
        End Get
        Set(ByVal value As String)
            _IndCierre = value
        End Set
    End Property

#End Region

#Region "Contructor"

    Sub New()
        FechaInicio = Date.Parse("01/01/1901")
        FechaFin = Date.Parse("01/01/1901")
        _Activo = True
        TipoOperacion = ""
        _IndCierre = ""
        IdUsuario = ""
        _cierreplanilla = False
        _Id = ""
        _Mes = 0
        _NomMes = "(0) TODOS"
    End Sub

    Public Sub New(ByVal ls_Id As String _
                  , ByVal ls_Codigo As String _
                  , ByVal ls_Ejercicio As Integer _
                  , ByVal ls_Mes As Integer _
                  , ByVal ld_FechaInicio As Date _
                  , ByVal ld_FechaFin As Date _
                  , ByVal lb_CierreCompras As Boolean _
                  , ByVal lb_CierraVentas As Boolean _
                  , ByVal lb_CierreAlmacen As Boolean _
                  , ByVal lb_CierreTesoreria As Boolean _
                  , ByVal lb_CierreCajaLiquidacion As Boolean _
                  , ByVal lb_CierreContabilidad As Boolean _
                  , ByVal ln_CambioCompra As Double _
                  , ByVal ln_CambioVenta As Double _
                  , ByVal lb_Activo As Boolean _
                  , ByVal lb_CierreCombustible As Boolean _
                  , ByVal lb_CierrePlanilla As Boolean _
               )
        _Id = ls_Id
        _Codigo = ls_Codigo
        _Ejercicio = ls_Ejercicio
        _Mes = ls_Mes
        _FechaInicio = ld_FechaInicio
        _FechaFin = ld_FechaFin
        _CierreCompras = lb_CierreCompras
        _CierraVentas = lb_CierraVentas
        _CierreAlmacen = lb_CierreAlmacen
        _CierreTesoreria = lb_CierreTesoreria
        _CierreCajaLiquidacion = lb_CierreCajaLiquidacion
        _CierreContabilidad = lb_CierreContabilidad
        _CambioCompra = ln_CambioCompra
        _CambioVenta = ln_CambioVenta
        _Activo = lb_Activo
        _CierreCombustible = lb_CierreCombustible
        _cierreplanilla = lb_CierrePlanilla
        _NomMes = "(" + ls_Mes.ToString + ") " + MonthName(ls_Mes).ToUpper
    End Sub

#End Region

    Public Function Obtener(ByVal periodo As e_Periodo) As e_Periodo Implements Ie_Periodo.Obtener
        Return periodo
    End Function

    Public Overloads Function Equals(ByVal oePeriodo As e_Periodo) As Boolean Implements System.IEquatable(Of e_Periodo).Equals
        Select Case oePeriodo.Equivale
            Case 1 : If Me.Id = oePeriodo.Id Then Return True
            Case 2 : If Me.Ejercicio = oePeriodo.Ejercicio And Me.Mes = oePeriodo.Mes Then Return True
        End Select
        Return False
    End Function

End Class
