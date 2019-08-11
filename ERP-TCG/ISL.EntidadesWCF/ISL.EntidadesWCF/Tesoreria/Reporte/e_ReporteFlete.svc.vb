<DataContract()> _
Public Class e_ReporteFlete
    Implements Ie_ReporteFlete

#Region "Declaración de variables"

    Private _Viaje As String
    Private _Piloto As String
    Private _Flete As String
    Private _FechaCarga As Date
    Private _Cargado As String
    Private _Depositado As String
    Private _SaldoPorDepositar As String
    Private _FechaDeposito As Date
    Private _NroDeposito As String
    Private _FDiasCargaFDeposito As Integer
    Private _idComisionista As String
    Private _Comisionista As String
    Private _idCheque As String
    Private _Cheque As String
    Private _fecCheque As Date
    Private _feccobroCheque As Date
    Private _montoCheque As Double
    Private _cobradoCheque As Boolean
    Private _idBanco As String
    Private _Banco As String
    Private _idCliente As String
    Private _Cliente As String
    Private _DiasFHoyFCobro As Integer
    Private _DiasFCargaFCobro As Integer
    Private _idUsuario As String
    Private _Usuario As String

    Public TipoOperacion As String = ""

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Viaje() As String
        Get
            Return _Viaje
        End Get
        Set(ByVal value As String)
            _Viaje = value
        End Set
    End Property

    <DataMember()> _
    Public Property Piloto() As String
        Get
            Return _Piloto
        End Get
        Set(ByVal value As String)
            _Piloto = value
        End Set
    End Property

    <DataMember()> _
    Public Property Flete() As String
        Get
            Return _Flete
        End Get
        Set(ByVal value As String)
            _Flete = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCarga() As Date
        Get
            Return _FechaCarga
        End Get
        Set(ByVal value As Date)
            _FechaCarga = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cargado() As String
        Get
            Return _Cargado
        End Get
        Set(ByVal value As String)
            _Cargado = value
        End Set
    End Property

    <DataMember()> _
    Public Property Depositado() As String
        Get
            Return _Depositado
        End Get
        Set(ByVal value As String)
            _Depositado = value
        End Set
    End Property

    <DataMember()> _
    Public Property SaldoPorDepositar() As String
        Get
            Return _SaldoPorDepositar
        End Get
        Set(ByVal value As String)
            _SaldoPorDepositar = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroDeposito() As String
        Get
            Return _NroDeposito
        End Get
        Set(ByVal value As String)
            _NroDeposito = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaDeposito() As Date
        Get
            Return _FechaDeposito
        End Get
        Set(ByVal value As Date)
            _FechaDeposito = value
        End Set
    End Property

    <DataMember()> _
    Public Property DiasFCargaFDeposito() As Integer
        Get
            Return _FDiasCargaFDeposito
        End Get
        Set(ByVal value As Integer)
            _FDiasCargaFDeposito = value
        End Set
    End Property

    <DataMember()> _
    Public Property Comisionista() As String
        Get
            Return _Comisionista
        End Get
        Set(ByVal value As String)
            _Comisionista = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdComisionista() As String
        Get
            Return _idComisionista
        End Get
        Set(ByVal value As String)
            _idComisionista = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCheque() As String
        Get
            Return _idCheque
        End Get
        Set(ByVal value As String)
            _idCheque = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCargaCheque() As Date
        Get
            Return _fecCheque
        End Get
        Set(ByVal value As Date)
            _fecCheque = value
        End Set
    End Property

    <DataMember()> _
    Public Property NumeroCheque() As String
        Get
            Return _Cheque
        End Get
        Set(ByVal value As String)
            _Cheque = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdBanco() As String
        Get
            Return _idBanco
        End Get
        Set(ByVal value As String)
            _idBanco = value
        End Set
    End Property

    <DataMember()> _
    Public Property Banco() As String
        Get
            Return _Banco
        End Get
        Set(ByVal value As String)
            _Banco = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCobro() As Date
        Get
            Return _feccobroCheque
        End Get
        Set(ByVal value As Date)
            _feccobroCheque = value
        End Set
    End Property

    <DataMember()> _
    Public Property Importe() As Decimal
        Get
            Return _montoCheque
        End Get
        Set(ByVal value As Decimal)
            _montoCheque = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cobrado() As Boolean
        Get
            Return _cobradoCheque
        End Get
        Set(ByVal value As Boolean)
            _cobradoCheque = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCliente() As String
        Get
            Return _idCliente
        End Get
        Set(ByVal value As String)
            _idCliente = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cliente() As String
        Get
            Return _Cliente
        End Get
        Set(ByVal value As String)
            _Cliente = value
        End Set
    End Property

    <DataMember()> _
    Public Property DiasFHoyFCobro() As Integer
        Get
            Return _DiasFHoyFCobro
        End Get
        Set(ByVal value As Integer)
            _DiasFHoyFCobro = value
        End Set
    End Property

    <DataMember()> _
    Public Property DiasFCargaFCobro() As Integer
        Get
            Return _DiasFCargaFCobro
        End Get
        Set(ByVal value As Integer)
            _DiasFCargaFCobro = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdProgramador() As String
        Get
            Return _idUsuario
        End Get
        Set(ByVal value As String)
            _idUsuario = value
        End Set
    End Property

    <DataMember()> _
    Public Property Programador() As String
        Get
            Return _Usuario
        End Get
        Set(ByVal value As String)
            _Usuario = value
        End Set
    End Property

#End Region

#Region "Constructores"

    Sub New()

    End Sub

    Sub New(ByVal ls_Viaje As String, ByVal ls_Piloto As String, _
            ByVal ld_Flete As Decimal, ByVal ld_FechaCarga As Date, _
            ByVal ld_Cargado As Decimal, ByVal ld_Depositado As Decimal, _
            ByVal ld_SaldoPorDepositar As Decimal, ByVal ld_FechaDeposito As Date, _
            ByVal ld_FDiasCargaFDeposito As Integer, ByVal ld_IdComisionista As String, _
            ByVal ls_Comisionista As String, ByVal ls_IdCheque As String, _
            ByVal ld_FechaCargaCheque As Date, ByVal ls_NumeroCheque As String, _
            ByVal ls_IdBanco As String, ByVal ls_Banco As String, _
            ByVal ld_FechaCobro As Date, ByVal ld_Importe As Decimal, _
            ByVal ls_IdCliente As String, ByVal ls_Cliente As String, _
            ByVal ld_DiasFHoyFCobro As Integer, ByVal ld_DiasFCargaFCobro As Integer, _
            ByVal ls_IdProgramador As String, ByVal ls_Programador As String, _
            ByVal ls_NroDeposito As String, ByVal lb_Cobrado As Boolean)

        _Viaje = ls_Viaje : _Piloto = ls_Piloto
        _Flete = ld_Flete : _FechaCarga = ld_FechaCarga
        _Cargado = ld_Cargado : _Depositado = ld_Depositado
        _SaldoPorDepositar = ld_SaldoPorDepositar : _FechaDeposito = ld_FechaDeposito
        _FDiasCargaFDeposito = ld_FDiasCargaFDeposito : _idComisionista = ld_IdComisionista
        _Comisionista = ls_Comisionista : _idCheque = ls_IdCheque
        _fecCheque = ld_FechaCargaCheque : _Cheque = ls_NumeroCheque
        _idBanco = ls_IdBanco : _Banco = ls_Banco
        _feccobroCheque = ld_FechaCobro : _montoCheque = ld_Importe
        _idCliente = ls_IdCliente : _Cliente = ls_Cliente
        _DiasFHoyFCobro = ld_DiasFHoyFCobro : _DiasFCargaFCobro = ld_DiasFCargaFCobro
        _idUsuario = ls_IdProgramador : _Usuario = ls_Programador
        _NroDeposito = ls_NroDeposito : _cobradoCheque = lb_Cobrado

    End Sub

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal reporteFlete As e_ReporteFlete) As e_ReporteFlete Implements Ie_ReporteFlete.Obtener
        Return reporteFlete
    End Function

#End Region

End Class
