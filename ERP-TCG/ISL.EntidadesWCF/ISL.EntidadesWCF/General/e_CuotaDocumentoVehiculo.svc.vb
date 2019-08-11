


<DataContract()> _
Public Class e_CuotaDocumentoVehiculo
    Implements Ie_CuotaDocumentoVehiculo
    Implements IEquatable(Of e_CuotaDocumentoVehiculo)

#Region "Propiedad"

    Private _id As String
    Private _iddocumento As String
    Private _monto As Double
    Private _fecha As Date
    Private _glosa As String
    Private _activo As Boolean
    Private _saldoadministrativo As Double
    Private _saldocontable As Double
    Private _iddocveh_doc As String
    Private _montoopera As Double
    Private _IdOrigen_CuotaMov As String
    Private _idmoneda As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public IdUsuarioCreacion As String
    <DataMember()> _
    Public TipoMovimientoSaldo As String
    <DataMember()> _
      Public FechaDesde As Date
    <DataMember()> _
    Public FechaHasta As Date
    <DataMember()> _
    Public leCuotaPago As New List(Of e_CuotaDocVehPago)
    <DataMember()> _
    Public IndVigencia As String

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
    Public Property IdDocumento() As String
        Get
            Return _iddocumento
        End Get
        Set(ByVal value As String)
            _iddocumento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Monto() As Double
        Get
            Return _monto
        End Get
        Set(ByVal value As Double)
            _monto = value
        End Set
    End Property

    <DataMember()> _
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property

    <DataMember()> _
    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
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
    Public Property SaldoAdministrativo() As Double
        Get
            Return _saldoadministrativo
        End Get
        Set(ByVal value As Double)
            _saldoadministrativo = value
        End Set
    End Property

    <DataMember()> _
    Public Property SaldoContable() As Double
        Get
            Return _saldocontable
        End Get
        Set(ByVal value As Double)
            _saldocontable = value
        End Set
    End Property

    <DataMember()> _
   Public Property IdDocVeh_Doc() As String
        Get
            Return _iddocveh_doc
        End Get
        Set(ByVal value As String)
            _iddocveh_doc = value
        End Set
    End Property

    <DataMember()> _
    Public Property MontoOpera() As Double
        Get
            Return _montoopera
        End Get
        Set(ByVal value As Double)
            _montoopera = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdOrigen_CuotaMov() As String
        Get
            Return _IdOrigen_CuotaMov
        End Get
        Set(ByVal value As String)
            _IdOrigen_CuotaMov = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMoneda() As String
        Get
            Return _idmoneda
        End Get
        Set(ByVal value As String)
            _idmoneda = value
        End Set
    End Property

#End Region

#Region "Constructor"
    Public Sub New()
        FechaDesde = Date.Now().AddYears(-1)
        FechaHasta = Date.Now().AddDays(-1)
        MontoOpera = 0.0
        IdOrigen_CuotaMov = ""
        IndVigencia = ""
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdDocumento As String _
              , ByVal ls_Monto As Double _
              , ByVal ls_Fecha As Date _
              , ByVal ls_Glosa As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_SaldoAdministrativo As Double _
              , ByVal ld_SaldoContable As Double _
              , ByVal ls_IdDocVeh_Doc As String _
              , ByVal ls_IdMoneda As String _
              , ByVal ld_MOntoOpera As Double _
           )
        _id = ls_Id
        _iddocumento = ls_IdDocumento
        _monto = ls_Monto
        _fecha = ls_Fecha
        _glosa = ls_Glosa
        _activo = lb_Activo
        _saldoadministrativo = ld_SaldoAdministrativo
        _saldocontable = ld_SaldoContable
        _iddocveh_doc = ls_IdDocVeh_Doc
        _idmoneda = ls_IdMoneda
        _montoopera = ld_MOntoOpera
    End Sub

#End Region

#Region "Métodos"
    Public Overloads Function Equals(ByVal oeCDV As e_CuotaDocumentoVehiculo) _
    As Boolean Implements IEquatable(Of e_CuotaDocumentoVehiculo).Equals
        If  Me.Glosa = oeCDV.Glosa Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Obtener(ByVal cuotaDocumentoVehiculo As e_CuotaDocumentoVehiculo) As e_CuotaDocumentoVehiculo Implements Ie_CuotaDocumentoVehiculo.Obtener
        Return cuotaDocumentoVehiculo
    End Function

#End Region

End Class


