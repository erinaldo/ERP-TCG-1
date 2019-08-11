<DataContract()> _
Public Class e_ReporteOTServicio
    Implements Ie_ReporteOTServicio

#Region "Declaracion de Variables"

    Private _idordentrabajo As String
    Private _nroot As String
    Private _fechaprog As Date
    Private _tipomantenimiento As String
    Private _mantenimiento As String
    Private _idservicio As String
    Private _servicio As String
    Private _placa As String
    Private _marca As String
    Private _proveedor As String
    Private _estado As String
    Private _costoots As Double
    Private _nrors As String
    Private _nrooc As String
    Private _glosa As String
    Private _tipodoc As String
    Private _fecdoc As Date
    Private _nrodoc As String
    Private _tipomoneda As String
    Private _tipocambio As Double
    Private _total As Double
    Private _cantidad As Double
    Private _preciounitario As Double

    <DataMember()> _
    Public TipoOperacion As String

    <DataMember()> _
    Public IdOrdenTrabajo As String
    <DataMember()> _
    Public IdTipoMantenimiento As String
    <DataMember()> _
    Public IdMantenimiento As String
    <DataMember()> _
    Public IdServicio As String
    <DataMember()> _
    Public IdMarca As String
    <DataMember()> _
    Public IdEquipo As String
    <DataMember()> _
    Public IdProveedor As String
    <DataMember()> _
    Public FechaInicio As Date
    <DataMember()> _
    Public FechaFin As Date

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property IdOT() As String
        Get
            Return _idordentrabajo
        End Get
        Set(ByVal value As String)
            _idordentrabajo = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroOT() As String
        Get
            Return _nroot
        End Get
        Set(ByVal value As String)
            _nroot = value
        End Set
    End Property

    <DataMember()> _
   Public Property FechaProgramacion() As Date
        Get
            Return _fechaprog
        End Get
        Set(ByVal value As Date)
            _fechaprog = value
        End Set
    End Property

    <DataMember()> _
   Public Property TipoMantenimiento() As String
        Get
            Return _tipomantenimiento
        End Get
        Set(ByVal value As String)
            _tipomantenimiento = value
        End Set
    End Property

    <DataMember()> _
   Public Property Mantenimiento() As String
        Get
            Return _mantenimiento
        End Get
        Set(ByVal value As String)
            _mantenimiento = value
        End Set
    End Property

    <DataMember()> _
   Public Property IdServ() As String
        Get
            Return _idservicio
        End Get
        Set(ByVal value As String)
            _idservicio = value
        End Set
    End Property

    <DataMember()> _
   Public Property Servicio() As String
        Get
            Return _servicio
        End Get
        Set(ByVal value As String)
            _servicio = value
        End Set
    End Property

    <DataMember()> _
   Public Property Placa() As String
        Get
            Return _placa
        End Get
        Set(ByVal value As String)
            _placa = value
        End Set
    End Property

    <DataMember()> _
   Public Property Marca() As String
        Get
            Return _marca
        End Get
        Set(ByVal value As String)
            _marca = value
        End Set
    End Property

    <DataMember()> _
   Public Property Proveedor() As String
        Get
            Return _proveedor
        End Get
        Set(ByVal value As String)
            _proveedor = value
        End Set
    End Property

    <DataMember()> _
   Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property

    <DataMember()> _
   Public Property CostoOTS() As Double
        Get
            Return _costoots
        End Get
        Set(ByVal value As Double)
            _costoots = value
        End Set
    End Property

    <DataMember()> _
   Public Property NroRS() As String
        Get
            Return _nrors
        End Get
        Set(ByVal value As String)
            _nrors = value
        End Set
    End Property

    <DataMember()> _
   Public Property NroOC() As String
        Get
            Return _nrooc
        End Get
        Set(ByVal value As String)
            _nrooc = value
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
    Public Property TipoDoc() As String
        Get
            Return _tipodoc
        End Get
        Set(ByVal value As String)
            _tipodoc = value
        End Set
    End Property

    <DataMember()> _
    Public Property FecDoc() As Date
        Get
            Return _fecdoc
        End Get
        Set(ByVal value As Date)
            _fecdoc = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroDoc() As String
        Get
            Return _nrodoc
        End Get
        Set(ByVal value As String)
            _nrodoc = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoMoneda() As String
        Get
            Return _tipomoneda
        End Get
        Set(ByVal value As String)
            _tipomoneda = value
        End Set
    End Property

    <DataMember()> _
        Public Property TipoCambio() As Double
        Get
            Return _tipocambio
        End Get
        Set(ByVal value As Double)
            _tipocambio = value
        End Set
    End Property

    <DataMember()> _
    Public Property Total() As Double
        Get
            Return _total
        End Get
        Set(ByVal value As Double)
            _total = value
        End Set
    End Property

    <DataMember()> _
    Public Property Cantidad() As Double
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Double)
            _cantidad = value
        End Set
    End Property

    <DataMember()> _
    Public Property PrecioUnitario() As Double
        Get
            Return _preciounitario
        End Get
        Set(ByVal value As Double)
            _preciounitario = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        IdOrdenTrabajo = String.Empty
        IdTipoMantenimiento = String.Empty
        IdMantenimiento = String.Empty
        IdServicio = String.Empty
        IdMarca = String.Empty
        IdEquipo = String.Empty
        IdProveedor = String.Empty
        FechaInicio = #1/1/1901#
        FechaFin = #1/1/1901#
    End Sub

    Public Sub New(ByVal ls_IdOrdenTrabajo As String _
                   , ByVal ls_NroOT As String _
                   , ByVal ld_FechaProg As Date _
                   , ByVal ls_TipoMantenimiento As String _
                   , ByVal ls_Mantenimiento As String _
                   , ByVal ls_IdServicio As String _
                   , ByVal ls_Servicio As String _
                   , ByVal ls_Placa As String _
                   , ByVal ls_Marca As String _
                   , ByVal ls_Proveedor As String _
                   , ByVal ls_Estado As String _
                   , ByVal ln_CostoOTS As Double _
                   , ByVal ls_NroRS As String _
                   , ByVal ls_NroOC As String _
                   , ByVal ls_Glosa As String _
                   , ByVal ls_TipoDoc As String _
                   , ByVal ld_FechaDoc As String _
                   , ByVal ls_NroDoc As String _
                   , ByVal ls_TipoMoneda As String _
                   , ByVal ln_TipoCambio As Double _
                   , ByVal ln_Total As Double _
                   , ByVal ln_Cantidad As Double _
                   , ByVal ln_PrecioUnitario As Double _
                   )
        _idordentrabajo = ls_IdOrdenTrabajo
        _nroot = ls_NroOT
        _fechaprog = ld_FechaProg
        _tipomantenimiento = ls_TipoMantenimiento
        _mantenimiento = ls_Mantenimiento
        _idservicio = ls_IdServicio
        _servicio = ls_Servicio
        _placa = ls_Placa
        _marca = ls_Marca
        _proveedor = ls_Proveedor
        _estado = ls_Estado
        _costoots = ln_CostoOTS
        _nrors = ls_NroRS
        _nrooc = ls_NroOC
        _glosa = ls_Glosa
        _tipodoc = ls_TipoDoc
        _fecdoc = ld_FechaDoc
        _nrodoc = ls_NroDoc
        _tipomoneda = ls_TipoMoneda
        _tipocambio = ln_TipoCambio
        _total = ln_Total
        _cantidad = ln_Cantidad
        _preciounitario = ln_PrecioUnitario

    End Sub

#End Region

    Public Function Obtener(ByVal reporteotservicio As e_ReporteOTServicio) As e_ReporteOTServicio Implements Ie_ReporteOTServicio.Obtener
        Return reporteotservicio
    End Function

End Class
