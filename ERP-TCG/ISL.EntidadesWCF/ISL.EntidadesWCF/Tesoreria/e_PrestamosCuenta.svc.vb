' NOTA: si cambia aquí el nombre de clase "e_PrestamosCuenta", también debe actualizar la referencia a "e_PrestamosCuenta" tanto en Web.config como en el archivo .svc asociado.
Public Class e_PrestamosCuenta
    Implements Ie_PrestamosCuenta
    Implements IEquatable(Of e_PrestamosCuenta)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idconceptoingresos As String
    Private _importe As Double
    Private _indingegr As String
    Private _glosa As String
    Private _voucher As String
    Private _usuarioautoriza As String
    Private _usuariocreacion As String
    Private _activo As Boolean
    Private _fecha As Date
    Private _fechacreacion As Date
    Private _egreso As Double
    Private _ingreso As Double
    Private _autoriza As String
    Private _concepto As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public FechaHasta As Date
    <DataMember()> _
    Public IdCentro As String
    <DataMember()> _
    Public IndCerrado As Integer
    <DataMember()> _
    Public FechaCierre As Date


    <DataMember()> Public oeSaldo As New e_Saldo
    '<DataMember()> Public oeAsiento As New e_Asiento
    <DataMember()> Public loAsientoModelo As New List(Of e_AsientoModelo)
    '<DataMember()> Public oeAsientoDiferencia As New e_Asiento
    '<DataMember()> Public oeMovimientosBancariosOrigen As New e_MovimientoCajaBanco
    '<DataMember()> Public oeMovimientosBancariosDestino As New e_MovimientoCajaBanco
    <DataMember()> Public oePeriodo As e_Periodo
    <DataMember()> Public oeCtaBancaria As e_CuentaBancaria
    <DataMember()> Public TipoCambio As Double
    <DataMember()> Public NroDocumento As String

    Public Event DatoCambiado()

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
    Public Property Concepto() As String
        Get
            Return _concepto
        End Get
        Set(ByVal value As String)
            _concepto = value
        End Set
    End Property

    <DataMember()> _
    Public Property Ingreso() As Double
        Get
            Return _ingreso
        End Get
        Set(ByVal value As Double)
            _ingreso = value
        End Set
    End Property

    <DataMember()> _
    Public Property Autoriza() As String
        Get
            Return _autoriza
        End Get
        Set(ByVal value As String)
            _autoriza = value
        End Set
    End Property

    <DataMember()> _
    Public Property Egreso() As Double
        Get
            Return _egreso
        End Get
        Set(ByVal value As Double)
            _egreso = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdConceptoIngresos() As String
        Get
            Return _idconceptoingresos
        End Get
        Set(ByVal value As String)
            _idconceptoingresos = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Importe() As Double
        Get
            Return _importe
        End Get
        Set(ByVal value As Double)
            _importe = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndIngEgr() As String
        Get
            Return _indingegr
        End Get
        Set(ByVal value As String)
            _indingegr = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Voucher() As String
        Get
            Return _voucher
        End Get
        Set(ByVal value As String)
            _voucher = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioAutoriza() As String
        Get
            Return _usuarioautoriza
        End Get
        Set(ByVal value As String)
            _usuarioautoriza = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        Activo = True
        IndCerrado = 0
        FechaCierre = Date.Parse("01/01/1901")
    End Sub

    Public Sub New(ByVal ls_Id As String _
              , ByVal ls_IdConceptoIngresos As String _
              , ByVal ln_Importe As Double _
              , ByVal ls_IndIngEgr As String _
              , ByVal ls_Glosa As String _
              , ByVal ls_Voucher As String _
              , ByVal ls_UsuarioAutoriza As String _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_Fecha As Date _
              , ByVal ld_FechaCreacion As Date _
              , ByVal lb_Ingreso As Double _
              , ByVal lb_Egreso As Double _
              , ByVal ls_Autoriza As String _
              , ByVal ls_Concepto As String)
        _id = ls_Id
        _idconceptoingresos = ls_IdConceptoIngresos
        _importe = ln_Importe
        _indingegr = ls_IndIngEgr
        _glosa = ls_Glosa
        _voucher = ls_Voucher
        _usuarioautoriza = ls_UsuarioAutoriza
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo
        _fecha = ld_Fecha
        _fechacreacion = ld_FechaCreacion
        _ingreso = lb_Ingreso
        _egreso = lb_Egreso
        _autoriza = ls_Autoriza
        _concepto = ls_Concepto
    End Sub

#End Region

#Region "Metodos"

    Public Overloads Function Equals(ByVal oePrestamosCuenta As e_PrestamosCuenta) _
    As Boolean Implements System.IEquatable(Of e_PrestamosCuenta).Equals
        If Me.Id = oePrestamosCuenta.Id And Me.IndIngEgr = oePrestamosCuenta.IndIngEgr Then Return True
        Return False
    End Function

    Public Function Obtener(ByVal otrosingresos As e_PrestamosCuenta) As e_PrestamosCuenta Implements Ie_PrestamosCuenta.Obtener
        Return otrosingresos
    End Function

#End Region

End Class
