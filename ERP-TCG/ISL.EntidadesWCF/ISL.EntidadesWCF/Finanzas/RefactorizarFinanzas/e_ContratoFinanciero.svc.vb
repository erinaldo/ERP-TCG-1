
<DataContract()> _
Public Class e_ContratoFinanciero
    Implements Ie_ContratoFinanciero

#Region "Propiedad"

    Private _id As String
    Private _codigo As String
    Private _idtipodocumento As New e_TipoDocumento
    Private _idBanco As String
    Private _glosa As String
    Private _fechaemision As Date
    Private _fechavencimiento As Date
    Private _nrocuotas As Integer
    Private _idmoneda As New e_Moneda
    Private _tipocambio As Double
    Private _montomn As Double
    Private _montome As Double
    Private _tasainteres As Double
    Private _activo As Boolean
    Private _usuario As String
    Private _comision As Double
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public lstObligacionesFin As New List(Of e_ObligacionFin)
    <DataMember()> _
    Public IdPeriodo As String
    <DataMember()> _
    Public NombreBanco As String
    <DataMember()> _
    Public Capital As Double
    <DataMember()> _
    Public oeMovCajaBanco As New e_MovimientoCajaBanco
    <DataMember()> _
    Public leDocumentos As New List(Of e_MovimientoDocumento)
    <DataMember()> _
    Public leDocLetra As New List(Of e_DetalleDocumento)
    <DataMember()> _
    Public leMoneda As New List(Of e_Moneda)
    <DataMember()> _
    Public IdClienteProveedor As String
    <DataMember()> _
    Public IndFec As Boolean = False
    <DataMember()> _
    Public MacLocal As String
    <DataMember()>
    Public PrefijoID As String = ""
    Event DatoCambiado()

    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property IdTipoDocumento() As String
        Get
            Return _idtipodocumento.Id
        End Get
        Set(ByVal value As String)
            _idtipodocumento.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property IdEmpresaBanco() As String
        Get
            Return _idBanco
        End Get
        Set(ByVal value As String)
            _idBanco = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property FechaEmision() As Date
        Get
            Return _fechaemision
        End Get
        Set(ByVal value As Date)
            _fechaemision = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property FechaVencimiento() As Date
        Get
            Return _fechavencimiento
        End Get
        Set(ByVal value As Date)
            _fechavencimiento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property NroCuotas() As Integer
        Get
            Return _nrocuotas
        End Get
        Set(ByVal value As Integer)
            _nrocuotas = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property IdMoneda() As String
        Get
            Return _idmoneda.Id
        End Get
        Set(ByVal value As String)
            _idmoneda.Id = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property TipoCambio() As Double
        Get
            Return _tipocambio
        End Get
        Set(ByVal value As Double)
            _tipocambio = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property MontoMN() As Double
        Get
            Return _montomn
        End Get
        Set(ByVal value As Double)
            _montomn = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property MontoME() As Double
        Get
            Return _montome
        End Get
        Set(ByVal value As Double)
            _montome = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property TasaInteres() As Double
        Get
            Return _tasainteres
        End Get
        Set(ByVal value As Double)
            _tasainteres = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    Public Property Comision() As Double
        Get
            Return _comision
        End Get
        Set(ByVal value As Double)
            _comision = value
        End Set
    End Property


#End Region

#Region "Constructor"

    Public Sub New()
        Activo = True
        FechaEmision = Date.Parse("01/01/1901")
        FechaVencimiento = Date.Parse("01/01/1901")
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_Codigo As String _
              , ByVal ls_IdTipoDocumento As String _
              , ByVal ls_IdEmpresaBanco As String _
              , ByVal ls_Glosa As String _
              , ByVal ld_FechaEmision As Date _
              , ByVal ld_FechaVencimiento As Date _
              , ByVal ln_NroCuotas As Integer _
              , ByVal ls_IdMoneda As String _
              , ByVal ln_TipoCambio As Double _
              , ByVal ln_MontoMN As Double _
              , ByVal ln_MontoME As Double _
              , ByVal ln_TasaInteres As Double _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_Comision As Double _
           )
        _id = ls_Id
        _codigo = ls_Codigo
        _idtipodocumento.Id = ls_IdTipoDocumento
        _idBanco = ls_IdEmpresaBanco
        _glosa = ls_Glosa
        _fechaemision = ld_FechaEmision
        _fechavencimiento = ld_FechaVencimiento
        _nrocuotas = ln_NroCuotas
        _idmoneda.Id = ls_IdMoneda
        _tipocambio = ln_TipoCambio
        _montomn = ln_MontoMN
        _montome = ln_MontoME
        _tasainteres = ln_TasaInteres
        _activo = lb_Activo
        _usuario = ls_UsuarioCreacion
        _comision = ld_Comision
    End Sub

#End Region

#Region "Métodos"

    Public Function Obtener(ByVal Contrato As e_ContratoFinanciero) As e_ContratoFinanciero Implements Ie_ContratoFinanciero.Obtener
        Return Contrato
    End Function

#End Region

End Class
