
' NOTA: si cambia aquí el nombre de clase "e_PrestamosCuenta", también debe actualizar la referencia a "e_PrestamosCuenta" tanto en Web.config como en el archivo .svc asociado.
<DataContract()> _
Public Class e_OtrosIngresos
    Implements Ie_OtrosIngresos

#Region "Propiedad"

    Private _id As String
    Private _idconceptoingresos As New e_ConceptoIngresos
    Private _cuentacorriente As New e_CuentaCorriente
    Private _trabajador As New e_Trabajador
    Private _idcuentabancaria As String
    Private _cuentabancaria As String
    Private _codigo As String
    Private _voucher As String
    Private _importe As Double
    Private _fecha As Date
    Private _indingresoegreso As Boolean
    Private _indcerrado As Boolean
    Private _fechacierre As Date
    Private _usuariocreacion As String
    Private _fechacreacion As Date
    Private _activo As Boolean
    Private _idreferencia As String
    Private _tiporeferencia As String
    Private _centro As New e_Centro
    Private _glosa As String
    Private _egreso As Double
    Private _ingreso As Double
    
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public IdPeriodo As String
    <DataMember()> _
    Public IdCaja As String = ""
    <DataMember()> _
    Public TipoCambio As Double
    <DataMember()> _
    Public DifDepositada As Double
    <DataMember()> _
    Public loAsientoModelo As New List(Of e_AsientoModelo)

    Event DatoCambiado()

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
    Public Property IdConceptoIngresos() As String
        Get
            Return _idconceptoingresos.Id
        End Get
        Set(ByVal value As String)
            _idconceptoingresos.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
   Public Property Concepto() As String
        Get
            Return _idconceptoingresos.Nombre
        End Get
        Set(ByVal value As String)
            _idconceptoingresos.Nombre = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdCuentaCorriente() As String
        Get
            Return _cuentacorriente.Id
        End Get
        Set(ByVal value As String)
            _cuentacorriente.Id = value
            RaiseEvent DatoCambiado()
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
    Public Property Egreso() As Double
        Get
            Return _egreso
        End Get
        Set(ByVal value As Double)
            _egreso = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCuentaBancaria() As String
        Get
            Return _idcuentabancaria
        End Get
        Set(ByVal value As String)
            _idcuentabancaria = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTrabajador() As String
        Get
            Return _trabajador.Id
        End Get
        Set(ByVal value As String)
            _trabajador.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdCentro() As String
        Get
            Return _centro.Id
        End Get
        Set(ByVal value As String)
            _centro.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Centro() As String
        Get
            Return _centro.Nombre
        End Get
        Set(ByVal value As String)
            _centro.Nombre = value
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
    Public Property IndIngresoEgreso() As Boolean
        Get
            Return _indingresoegreso
        End Get
        Set(ByVal value As Boolean)
            _indingresoegreso = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndCerrado() As Boolean
        Get
            Return _indcerrado
        End Get
        Set(ByVal value As Boolean)
            _indcerrado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCierre() As Date
        Get
            Return _fechacierre
        End Get
        Set(ByVal value As Date)
            _fechacierre = value
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
    Public Property TipoReferencia() As String
        Get
            Return _tiporeferencia
        End Get
        Set(ByVal value As String)
            _tiporeferencia = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdReferencia() As String
        Get
            Return _idreferencia
        End Get
        Set(ByVal value As String)
            _idreferencia = value
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
    Public Property CuentaBancaria() As String
        Get
            Return _cuentabancaria
        End Get
        Set(ByVal value As String)
            _cuentabancaria = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        Activo = True
        Fecha = Date.Parse("01/01/1901")
        FechaCierre = Date.Parse("01/01/1901")
        FechaCreacion = Date.Parse("01/01/1901")
        IndCerrado = False
        IdCuentaBancaria = ""
        TipoOperacion = ""
        Modificado = False
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdConceptoIngresos As String _
              , ByVal ls_IdCuentaCorriente As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_Voucher As String _
              , ByVal ln_Importe As Double _
              , ByVal ld_Fecha As Date _
              , ByVal lb_IndIngresoEgreso As Boolean _
              , ByVal lb_IndCerrado As Boolean _
              , ByVal ld_FechaCierre As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_Ingreso As Double _
              , ByVal ld_Egreso As Double _
              , ByVal ls_CuentaBancaria As String _
              , ByVal ls_IdCuentaBancaria As String _
              , ByVal ls_Glosa As String _
              , ByVal ls_TipoReferencia As String _
              , ByVal ls_Centro As String _
              , ByVal ls_Concepto As String)
        _id = ls_Id
        _idconceptoingresos.Id = ls_IdConceptoIngresos
        _cuentacorriente.Id = ls_IdCuentaCorriente
        _codigo = ls_Codigo
        _voucher = ls_Voucher
        _importe = ln_Importe
        _fecha = ld_Fecha
        _indingresoegreso = lb_IndIngresoEgreso
        _indcerrado = lb_IndCerrado
        _fechacierre = ld_FechaCierre
        _usuariocreacion = ls_UsuarioCreacion
        _fechacreacion = ld_FechaCreacion
        _activo = lb_Activo
        _ingreso = ld_Ingreso
        _egreso = ld_Egreso
        _cuentabancaria = ls_CuentaBancaria
        _idcuentabancaria = ls_IdCuentaBancaria
        _glosa = ls_Glosa
        _tiporeferencia = TipoReferencia
        _centro.Nombre = ls_Centro
        _idconceptoingresos.Nombre = ls_Concepto
    End Sub

#End Region

    Public Function Obtener(ByVal otrosingresos As e_PrestamosCuenta) As e_PrestamosCuenta Implements Ie_OtrosIngresos.Obtener
        Return otrosingresos
    End Function

End Class

