
<DataContract()> _
Public Class e_CuentaxCyP
    Implements Ie_CuentaxCyP

#Region "Declaración de variables"

    Private _id As String
    Private _idmovimientocajabanco As String
    Private _idmovimientodocumento As String
    Private _fecha As Date
    Private _montomn As Double
    Private _montome As Double

    Private _nroBoucher As String
    Private _idcuentabancaraia As String
    Private _IdFLujoCaja As String
    Private _FlujoCaja As String
    Private _IdAsiento As String
    Private _Activo As Boolean
    Private _DocumentoCancelacion As String
    Private _TipoCodigoObligacion As String

    Private _Medio As String
    Private _Glosa As String
    Private _TipoAsiento As String
    Private _NroAsiento As String
    Private _Periodo As String

    Private _IdCuentaCorriente As String

    <DataMember()> _
    Public UsuarioCreacion As String
    <DataMember()> _
    Public MacPCLocalCreacion As String
    <DataMember()> _
    Public MovDocCta As New e_MovimientoDocumentoCuenta
    <DataMember()> _
    Public ObligacionDocumento As New e_ObligacionDocumento
    <DataMember()> _
    Public leObligacionDocumento As List(Of e_ObligacionDocumento)
    <DataMember()> _
    Public AsMov_MovDoc As e_AsientoMov_MovDoc
    <DataMember()> _
    Public _IdAsientoMovimiento As String 'para pagos y cobros
    <DataMember()> _
    Public Shadows TipoOperacion As String
    <DataMember()> _
    Public Shadows Modificado As Boolean
    <DataMember()> _
    Public CuentaxPDocumentoRetencion As e_CuentaxPDocumentoRetencion
    <DataMember()> _
    Public IdAsientoElimina As String

    <DataMember()> _
    Public IndCargoAbono As Integer
    <DataMember()> _
    Public IdMoneda As String
    <DataMember()> _
    Public TipoCambio As Double
    <DataMember()> _
    Public UsuarioModifica As String
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    Public Event DatoCambiado()

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
    Public Property IdMovimientoCajaBanco() As String
        Get
            Return _idmovimientocajabanco
        End Get
        Set(ByVal value As String)
            _idmovimientocajabanco = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdMovimientoDocumento() As String
        Get
            Return _idmovimientodocumento
        End Get
        Set(ByVal value As String)
            _idmovimientodocumento = value
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
    Public Property MontoMN() As Double
        Get
            Return _montomn
        End Get
        Set(ByVal value As Double)
            _montomn = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property MontoMe() As Double
        Get
            Return _montome
        End Get
        Set(ByVal value As Double)
            _montome = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdFlujoCaja() As String
        Get
            Return _IdFLujoCaja
        End Get
        Set(ByVal value As String)
            _IdFLujoCaja = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FlujoCaja()
        Get
            Return _FlujoCaja
        End Get
        Set(ByVal value)
            _FlujoCaja = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCuentaBancaria() As String
        Get
            Return _idcuentabancaraia
        End Get
        Set(ByVal value As String)
            _idcuentabancaraia = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdAsiento() As String
        Get
            Return _IdAsiento
        End Get
        Set(ByVal value As String)
            _IdAsiento = value
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
    Public Property DocumentoCancelacion() As String
        Get
            Return _DocumentoCancelacion
        End Get
        Set(ByVal value As String)
            _DocumentoCancelacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoCodigoObligacion() As String
        Get
            Return _TipoCodigoObligacion
        End Get
        Set(ByVal value As String)
            _TipoCodigoObligacion = value
        End Set
    End Property

    <DataMember()> _
   Public Property NroBoucher() As String
        Get
            Return _nroBoucher
        End Get
        Set(ByVal value As String)
            _nroBoucher = value
        End Set
    End Property

    <DataMember()> _
   Public Property Medio() As String
        Get
            Return _Medio
        End Get
        Set(ByVal value As String)
            _Medio = value
        End Set
    End Property

    <DataMember()> _
  Public Property Glosa() As String
        Get
            Return _Glosa
        End Get
        Set(ByVal value As String)
            _Glosa = value
        End Set
    End Property

    <DataMember()> _
  Public Property TipoAsiento() As String
        Get
            Return _TipoAsiento
        End Get
        Set(ByVal value As String)
            _TipoAsiento = value
        End Set
    End Property

    <DataMember()> _
  Public Property NroAsiento() As String
        Get
            Return _NroAsiento
        End Get
        Set(ByVal value As String)
            _NroAsiento = value
        End Set
    End Property

    <DataMember()> _
  Public Property Periodo() As String
        Get
            Return _Periodo
        End Get
        Set(ByVal value As String)
            _Periodo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCuentaCorriente() As String
        Get
            Return _IdCuentaCorriente
        End Get
        Set(ByVal value As String)
            _IdCuentaCorriente = value
        End Set
    End Property

#End Region

#Region "Constructores"

    Public Sub New()

        MontoMe = Decimal.Zero
        MontoMN = Decimal.Zero
        Fecha = Date.Parse("01/01/1901")
        Activo = True

        IndCargoAbono = 0
        IdMoneda = ""
        TipoCambio = 0
        UsuarioModifica = ""

    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdMovimientoCajaBanco As String _
              , ByVal ls_IdMovimientoDocumento As String _
              , ByVal ld_Fecha As Date _
              , ByVal ln_MontoMN As Double _
              , ByVal ln_MontoMe As Double _
              , ByVal ln_idCuentaBancaria As String _
              , ByVal ln_flujoCaja As String _
              , ByVal ln_IdAsiento As String _
              , ByVal ls_FlujoCaja As String _
              , ByVal ln_DocumentoCancelacion As String _
              , ByVal ln_TipoCodigoObligacion As String _
              , ByVal ls_NroBoucher As String _
              , ByVal ls_Medio As String _
              , ByVal ls_Glosa As String _
              , ByVal ls_TipoAsiento As String _
              , ByVal ls_NroAsiento As String _
              , ByVal ls_Periodo As String _
              , ByVal ls_IdCuentaCorriente As String _
              , ByVal ln_IndCargoAbono As Integer _
              , ByVal ls_IdMoneda As String _
              , ByVal ln_TipoCambio As Double _
              , ByVal ls_UsuarioModifica As String _
           )

        _id = ls_Id
        _idmovimientocajabanco = ls_IdMovimientoCajaBanco
        _idmovimientodocumento = ls_IdMovimientoDocumento
        _fecha = ld_Fecha
        _montomn = ln_MontoMN
        _montome = ln_MontoMe
        _idcuentabancaraia = ln_idCuentaBancaria
        _IdFLujoCaja = ln_flujoCaja
        _IdAsiento = ln_IdAsiento
        _FlujoCaja = ls_FlujoCaja
        _DocumentoCancelacion = ln_DocumentoCancelacion
        _TipoCodigoObligacion = ln_TipoCodigoObligacion
        _nroBoucher = ls_NroBoucher
        _Medio = ls_Medio
        _Glosa = ls_Glosa
        _TipoAsiento = ls_TipoAsiento
        _NroAsiento = ls_NroAsiento
        _Periodo = ls_Periodo
        _IdCuentaCorriente = ls_IdCuentaCorriente
        IndCargoAbono = ln_IndCargoAbono
        IdMoneda = ls_IdMoneda
        TipoCambio = ln_TipoCambio
        UsuarioModifica = ls_UsuarioModifica
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal cuentaxCyP As e_CuentaxCyP) As e_CuentaxCyP Implements Ie_CuentaxCyP.Obtener
        Return cuentaxCyP
    End Function

#End Region

End Class

