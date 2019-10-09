<DataContract()> _
Public Class e_MovimientoCajaBanco
    Implements Ie_MovimientoCajaBanco
    Implements IEquatable(Of e_MovimientoCajaBanco)

#Region "Declaración de variables"

    Private _id As String
    Private _idflujocaja As String
    Private _nroboucher As String
    Private _idcuentabancaria As String
    Private _idMonedaCtaBan As String
    Private _fecha As Date
    Private _idMedioPago As String
    Private _idperiodoconcilia As String
    Private _activo As Boolean
    Private _idasientomovimiento As String
    Private _tipocambio As Double
    Private _totalMN As Double
    Private _totalMe As Double
    Private _Glosa As String
    Private _Seleccion As Boolean
    Private _usuario As String
    Private _nroasiento As String

    <DataMember()> _
    Public Property TipoGasto() As String
    <DataMember()> _
    Public IdCuentaCorriente As String
    <DataMember()> _
    Public UsuarioCreacion As String
    <DataMember()> _
    Public _IdCuentaContable As String
    <DataMember()> _
    Public _IdTipoAsiento As String = ""
    <DataMember()> _
    Public MovDoc As New List(Of e_MovimientoDocumento)
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public _FechaFin As Date 'para filtrar en lista de movimientos de bancos
    <DataMember()> _
    Public _Conciliado As Integer 'para filtrar en la conciliacion
    <DataMember()> _
    Public _Ejercicio As Integer ' para filtrar en la conciliacion
    <DataMember()> _
    Public _Operador As Integer 'cuando graba resta o suma a la cuenta
    <DataMember()> _
    Public _Ids As String 'contiene los ids para conciliacion
    <DataMember()> _
    Public DifAGanancia As Double
    <DataMember()> _
    Public IdTipoGasto As String = ""
    <DataMember()> _
    Public IdPeriodoCtble As String = ""
    <DataMember()> _
    Public IdCta10 As String = ""
    <DataMember()> _
    Public MacLocal As String = ""
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()> Public IdSucursalSistema As String = ""
    Public Event DatoCambiado()

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Overridable Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdFlujoCaja() As String
        Get
            Return _idflujocaja
        End Get
        Set(ByVal value As String)
            _idflujocaja = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property NroBoucher() As String
        Get
            Return _nroboucher
        End Get
        Set(ByVal value As String)
            _nroboucher = value
            RaiseEvent DatoCambiado()
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
    Public Property IdMonedaCtaBan() As String
        Get
            Return _idMonedaCtaBan
        End Get
        Set(ByVal value As String)
            _idMonedaCtaBan = value
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
    Public Property IdMedioPago() As String
        Get
            Return _idMedioPago
        End Get
        Set(ByVal value As String)
            _idMedioPago = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdPeriodoConcilia() As String
        Get
            Return _idperiodoconcilia
        End Get
        Set(ByVal value As String)
            _idperiodoconcilia = value
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
    Public Property IdAsientoMovimiento() As String
        Get
            Return _idasientomovimiento
        End Get
        Set(ByVal value As String)
            _idasientomovimiento = value
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
    Public Property TotalMN() As Double
        Get
            Return _totalMN
        End Get
        Set(ByVal value As Double)
            _totalMN = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property TotalME() As Double
        Get
            Return _totalMe
        End Get
        Set(ByVal value As Double)
            _totalMe = value
            RaiseEvent DatoCambiado()
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
    Public Property Seleccion() As Boolean
        Get
            Return _Seleccion
        End Get
        Set(ByVal value As Boolean)
            _Seleccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroAsiento() As String
        Get
            Return _nroasiento
        End Get
        Set(ByVal value As String)
            _nroasiento = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        Activo = 1
        Fecha = Date.Parse("01/01/1901")
        _FechaFin = Date.Parse("01/01/1901")
        _Conciliado = -1
        TipoOperacion = ""
        _Ids = ""
        _idasientomovimiento = ""
        TipoGasto = ""
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdFlujoCaja As String _
              , ByVal ls_NroBoucher As String _
              , ByVal ls_IdCuentaBancaria As String _
              , ByVal ls_IdMonedaCtaBan As String _
               , ByVal ld_Fecha As Date _
              , ByVal ls_IdTipoDocumento As String _
                , ByVal ls_IdPeriodoConcilia As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_IdAsientoMovimiento As String _
                 , ByVal ls_tipocambio As Double _
              , ByVal ls_totalMN As Double _
              , ByVal ls_totalME As Double _
              , ByVal ls_Glosa As String _
              , ByVal ls_TipoGasto As String _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ls_IdTipoGasto As String _
              , ByVal ls_NroAsiento As String _
           )
        _id = ls_Id
        _idflujocaja = ls_IdFlujoCaja
        _nroboucher = ls_NroBoucher
        _idcuentabancaria = ls_IdCuentaBancaria
        _idMonedaCtaBan = ls_IdMonedaCtaBan
        _fecha = ld_Fecha
        _idMedioPago = ls_IdTipoDocumento
        _idperiodoconcilia = ls_IdPeriodoConcilia
        _activo = lb_Activo
        _idasientomovimiento = ls_IdAsientoMovimiento
        _tipocambio = ls_tipocambio
        _totalMN = ls_totalMN
        _totalMe = ls_totalME
        _Glosa = ls_Glosa
        _usuario = ls_UsuarioCreacion
        TipoGasto = ls_TipoGasto
        IdTipoGasto = ls_IdTipoGasto
        _nroasiento = ls_NroAsiento
    End Sub

#End Region

#Region "Métodos"

    Public Function Equals1(ByVal other As e_MovimientoCajaBanco) As Boolean Implements System.IEquatable(Of e_MovimientoCajaBanco).Equals
        If Me.IdAsientoMovimiento = other.IdAsientoMovimiento And Me.IdMedioPago = other.IdMedioPago _
        And Me.IdFlujoCaja = other.IdFlujoCaja And Me.IdCuentaBancaria = other.IdCuentaBancaria And Me.NroBoucher = other.NroBoucher Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Obtener(ByVal movimientoCajaBanco As e_MovimientoCajaBanco) As e_MovimientoCajaBanco Implements Ie_MovimientoCajaBanco.Obtener
        Return movimientoCajaBanco
    End Function

#End Region

End Class