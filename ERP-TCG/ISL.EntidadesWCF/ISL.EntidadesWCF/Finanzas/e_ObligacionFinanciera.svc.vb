

<DataContract()> _
Public Class e_ObligacionFinanciera
    Implements Ie_ObligacionFinanciera
    Implements IEquatable(Of e_ObligacionFinanciera)
    Implements ICloneable

#Region "Propiedad"

    Private _id As String
    Private _codigo As String
    Private _idempresabanco As String
    <DataMember()> _
    Public _NombreBanco As String
    Private _glosa As String
    Private _fechaemision As Date
    Private _fechavencimiento As Date
    Private _idtipoobligacion As String
    <DataMember()> _
    Public _NombreObligacion As String
    Private _idmoneda As String
    Private _tipocambio As Double
    Private _montomn As Double
    Private _montome As Double
    <DataMember()> _
    Public _MontoMNSinInteres As Double
    <DataMember()> _
    Public _MontoMESinInteres As Double
    Private _saldo As Double
    Private _tasainteres As Double
    Private _montointerestes As Double
    Private _montointerescon As Double
    Private _montointeresmoratorio As Double
    Private _montointeresdscto As Double
    Private _comision As Double
    Private _activo As Boolean
    Private _idcuentacontable As String
    <DataMember()> _
    Public _IdCuentaContableInteres As String

    ''' Leasing Prestamo Pagare
    Private _idleasing As String
    Private _cuota As Double
    Private _nrocuotas As Integer
    Private _activoleasing As Boolean
    Public FechaInicial As Date

    ''' Fec Letras
    Private _idLetras As String
    Private _indclienteproveedor As Integer
    Private _idclienteproveedor As String
    Private _activoLetras As Boolean
    <DataMember()> _
    Public NroLetra As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()>
    Public Modificado As Boolean
    <DataMember()>
    Public PrefijoID As String = ""

    <DataMember()>
    Public leObligacionDocumento As New List(Of e_ObligacionDocumento)
    <DataMember()> _
    Public leDocumentoAgregados As New List(Of e_MovimientoDocumento)
    <DataMember()> _
    Public oeObligacionPago As e_ObligacionPago
    <DataMember()> _
    Public UsuarioCreacion As String
    <DataMember()> _
    Public MacPcLocalCreacion As String
    <DataMember()> _
    Public NombreDocumento As String
    Private _idCuentaBancaria As String
    Private _gastos As Double
    <DataMember()> _
    Public CodigoUnico As String
    Public Event DatoCambiado()
    Private _MontoOperar As Double

    '---------para pago-----------------
    <DataMember()> _
    Public _IdMovimientoCajaBanco As String
    <DataMember()> _
    Public _IdAsientoMovimiento As String
    <DataMember()> _
    Public _ExcluyeInteres As Boolean
    <DataMember()> _
    Public _Ejercicio As Integer
    '------------------------------------

    'Periodo
    <DataMember()> _
    Public oePeriodo As New e_Periodo

    <DataMember()> _
    Public Property MontoOperar()
        Get
            Return _MontoOperar
        End Get
        Set(ByVal value)
            _MontoOperar = value
        End Set
    End Property

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
    Public Property IdEmpresaBanco() As String
        Get
            Return _idempresabanco
        End Get
        Set(ByVal value As String)
            _idempresabanco = value
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
    Public Property FechaEmision() As Date
        Get
            Return _fechaemision
        End Get
        Set(ByVal value As Date)
            _fechaemision = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaVencimiento() As Date
        Get
            Return _fechavencimiento
        End Get
        Set(ByVal value As Date)
            _fechavencimiento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoObligacion() As String
        Get
            Return _idtipoobligacion
        End Get
        Set(ByVal value As String)
            _idtipoobligacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdMoneda() As String
        Get
            Return _idmoneda
        End Get
        Set(ByVal value As String)
            _idmoneda = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TipoCambio() As Double
        Get
            Return _tipocambio
        End Get
        Set(ByVal value As Double)
            _tipocambio = value
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
    Public Property MontoME() As Double
        Get
            Return _montome
        End Get
        Set(ByVal value As Double)
            _montome = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Saldo() As Double
        Get
            Return _saldo
        End Get
        Set(ByVal value As Double)
            _saldo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TasaInteres() As Double
        Get
            Return _tasainteres
        End Get
        Set(ByVal value As Double)
            _tasainteres = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property MontoInteresTes() As Double
        Get
            Return _montointerestes
        End Get
        Set(ByVal value As Double)
            _montointerestes = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property MontoInteresCon() As Double
        Get
            Return _montointerescon
        End Get
        Set(ByVal value As Double)
            _montointerescon = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property MontoInteresMoratorio() As Double
        Get
            Return _montointeresmoratorio
        End Get
        Set(ByVal value As Double)
            _montointeresmoratorio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property MontoInteresDscto() As Double
        Get
            Return _montointeresdscto
        End Get
        Set(ByVal value As Double)
            _montointeresdscto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Comision() As Double
        Get
            Return _comision
        End Get
        Set(ByVal value As Double)
            _comision = value
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
    Public Property IdCuentaContable() As String
        Get
            Return _idcuentacontable
        End Get
        Set(ByVal value As String)
            _idcuentacontable = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    ''' Leasing Prestamo Pagare
    <DataMember()> _
    Public Property IdLeasing() As String
        Get
            Return _idleasing
        End Get
        Set(ByVal value As String)
            _idleasing = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cuota() As Double
        Get
            Return _cuota
        End Get
        Set(ByVal value As Double)
            _cuota = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NroCuotas() As Integer
        Get
            Return _nrocuotas
        End Get
        Set(ByVal value As Integer)
            _nrocuotas = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property ActivoLeasing() As Boolean
        Get
            Return _activoleasing
        End Get
        Set(ByVal value As Boolean)
            _activoleasing = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    ''' Fec Letras
    <DataMember()> _
    Public Property IdLetras() As String
        Get
            Return _idLetras
        End Get
        Set(ByVal value As String)
            _idLetras = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndClienteProveedor() As Integer
        Get
            Return _indclienteproveedor
        End Get
        Set(ByVal value As Integer)
            _indclienteproveedor = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdClienteProveedor() As String
        Get
            Return _idclienteproveedor
        End Get
        Set(ByVal value As String)
            _idclienteproveedor = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property ActivoLetras() As Boolean
        Get
            Return _activoLetras
        End Get
        Set(ByVal value As Boolean)
            _activoLetras = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdCuentaBancaria() As String
        Get
            Return _idCuentaBancaria
        End Get
        Set(ByVal value As String)
            _idCuentaBancaria = value
        End Set
    End Property

    <DataMember()> _
    Public Property Gastos() As Double
        Get
            Return _Gastos
        End Get
        Set(ByVal value As Double)
            _Gastos = value
        End Set
    End Property
#End Region

#Region "Constructor"

    Public Sub New()
        Id = ""
        TipoOperacion = ""
        Activo = True
        _fechaemision = Date.Parse("01/01/1901")
        _fechavencimiento = Date.Parse("01/01/1901")
        FechaInicial = Date.Parse("01/01/1901")
        _ExcluyeInteres = False
        _codigo = String.Empty
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_IdEmpresaBanco As String _
              , ByVal ls_Glosa As String _
              , ByVal ld_FechaEmision As Date _
              , ByVal ld_FechaVencimiento As Date _
              , ByVal ls_IdTipoObligacion As String _
              , ByVal ls_IdMoneda As String _
              , ByVal ln_TipoCambio As Double _
              , ByVal ln_MontoMN As Double _
              , ByVal ln_MontoME As Double _
              , ByVal ln_Saldo As Double _
              , ByVal ln_TasaInteres As Double _
              , ByVal ln_MontoInteresTes As Double _
              , ByVal ln_MontoInteresCon As Double _
              , ByVal ln_MontoInteresMoratorio As Double _
              , ByVal ln_Comision As Double _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_IdCuentaContable As String _
              , ByVal ls_IdLeasing As String _
              , ByVal ln_CuotaInicial As Double _
              , ByVal ln_NroCuotas As Integer _
              , ByVal ls_IdFecLet As String _
              , ByVal ln_IndClienteProveedor As Integer _
              , ByVal ls_IdClienteProveedor As String _
              , ByVal ls_IdCuentaContableInteres As String _
              , ByVal ls_IdCuentaBancaria As String _
              , ByVal ln_Gasto As Double _
              , ByVal ls_CodigoUnico As String _
              , ByVal lsNombreBanco As String _
              , ByVal lsNombreObligacion As String _
              , ByVal ls_NroLetra As String _
              , ByVal ldFechaEmision As Date _
              , ByVal ln_MontoInteresDscto As Double _
              )

        _id = ls_Id
        _codigo = ls_Codigo
        _idempresabanco = ls_IdEmpresaBanco
        _glosa = ls_Glosa
        _fechaemision = ld_FechaEmision
        _fechavencimiento = ld_FechaVencimiento
        _idtipoobligacion = ls_IdTipoObligacion
        _idmoneda = ls_IdMoneda
        _tipocambio = ln_TipoCambio
        _montomn = ln_MontoMN
        _montome = ln_MontoME
        _saldo = ln_Saldo
        _tasainteres = ln_TasaInteres
        _montointerestes = ln_MontoInteresTes
        _montointerescon = ln_MontoInteresCon
        _montointeresmoratorio = ln_MontoInteresMoratorio
        _comision = ln_Comision
        _activo = lb_Activo
        _idcuentacontable = ls_IdCuentaContable
        _idleasing = ls_IdLeasing
        _cuota = ln_CuotaInicial
        _nrocuotas = ln_NroCuotas
        _idLetras = ls_IdFecLet
        _indclienteproveedor = ln_IndClienteProveedor
        _idclienteproveedor = ls_IdClienteProveedor
        _IdCuentaContableInteres = ls_IdCuentaContableInteres
        _idCuentaBancaria = ls_IdCuentaBancaria
        _gastos = ln_Gasto
        CodigoUnico = ls_CodigoUnico
        _NombreBanco = lsNombreBanco
        _NombreObligacion = lsNombreObligacion
        NroLetra = ls_NroLetra
        FechaInicial = ldFechaEmision
        _montointeresdscto = ln_MontoInteresDscto
    End Sub

#End Region

#Region "Métodos"

    Public Function Equals1(ByVal other As e_ObligacionFinanciera) As Boolean Implements System.IEquatable(Of e_ObligacionFinanciera).Equals
        If Me.Codigo = other.Codigo And Me.IdTipoObligacion = other.IdTipoObligacion _
       And Math.Round(Me.MontoMN, 2) = Math.Round(other.MontoMN, 2) And Math.Round(Me.MontoME, 2) = Math.Round(other.MontoME, 2) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Clone() As Object Implements System.ICloneable.Clone
        Dim oeObligacion As New e_ObligacionFinanciera
        With oeObligacion
            .Id = Me.Id
            .Codigo = Me.Codigo
            .IdEmpresaBanco = Me.IdEmpresaBanco
            .Glosa = Me.Glosa
            .FechaEmision = Me.FechaEmision
            .FechaVencimiento = Me.FechaVencimiento
            .IdTipoObligacion = Me.IdTipoObligacion
            .IdMoneda = Me.IdMoneda
            .TipoCambio = Me.TipoCambio
            .MontoMN = Me.MontoMN
            .MontoME = Me.MontoME
            .Saldo = Me.Saldo
            .TasaInteres = Me.TasaInteres
            .MontoInteresTes = Me.MontoInteresTes
            .MontoInteresCon = Me.MontoInteresCon
            .MontoInteresMoratorio = Me.MontoInteresMoratorio
            .Comision = Me.Comision
            .Activo = Me.Activo
            .IdCuentaContable = Me.IdCuentaContable
            .UsuarioCreacion = Me.UsuarioCreacion
            .MacPcLocalCreacion = Me.MacPcLocalCreacion
            ._IdCuentaContableInteres = Me._IdCuentaContableInteres
            .IdCuentaBancaria = Me.IdCuentaBancaria
            .TipoOperacion = Me.TipoOperacion
            ._NombreBanco = Me._NombreBanco
            ._NombreObligacion = Me._NombreObligacion
            .MontoOperar = Me.MontoOperar
            .FechaInicial = Me.FechaInicial
        End With
        Return oeObligacion
    End Function

    ''' <summary>
    ''' Obtener una entidad de tipo e_ObligacionFinanciera
    ''' </summary>
    ''' <param name="obligacionFinanciera"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal obligacionFinanciera As e_ObligacionFinanciera) As e_ObligacionFinanciera Implements Ie_ObligacionFinanciera.Obtener
        Return obligacionFinanciera
    End Function

#End Region

End Class


