<DataContract()> _
Public Class e_ReporteConsumoEquipo
    Implements Ie_ReporteConsumoEquipo

#Region "Declaracion de Variables"

    Private _id As String
    Private _nombre As String
    Private _costomaterial As Double
    Private _costoservicio As Double
    Private _costoasignacion As Double
    Private _indicador As String

    <DataMember()> _
    Public TipoOperacion As String

    <DataMember()> _
    Public Anio As String
    <DataMember()> _
    Public Mes As String
    <DataMember()> _
    Public IdAlmacen As String
    <DataMember()> _
    Public IdMaterial As String

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
    Public Property Indicador() As String
        Get
            Return _indicador
        End Get
        Set(ByVal value As String)
            _indicador = value
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    <DataMember()> _
Public Property CostoMaterial() As Double
        Get
            Return _costomaterial
        End Get
        Set(ByVal value As Double)
            _costomaterial = value
        End Set
    End Property

    <DataMember()> _
Public Property CostoServicio() As Double
        Get
            Return _costoservicio
        End Get
        Set(ByVal value As Double)
            _costoservicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property CostoAsignacion() As Double
        Get
            Return _costoasignacion
        End Get
        Set(ByVal value As Double)
            _costoasignacion = value
        End Set
    End Property

    <DataMember()> _
    Public ReadOnly Property CostoTotal() As Double
        Get
            Return _costomaterial + _costoservicio + _costoasignacion
        End Get
    End Property

#End Region

#Region "Contructor"

    Public Sub New()
        IdAlmacen = String.Empty
        Anio = String.Empty
        Mes = String.Empty
        TipoOperacion = String.Empty
        _indicador = String.Empty
    End Sub

    Public Sub New(ByVal ls_Id As String _
                   , ByVal ls_Nombre As String _
                   , ByVal ln_CostoMaterial As Double _
                   , ByVal ln_CostoServicio As Double _
                   , ByVal ln_CostoAsginacion As Double)
        _id = Right(ls_Id, 12)
        _indicador = Left(ls_Id, 1)
        _nombre = ls_Nombre
        _costomaterial = ln_CostoMaterial
        _costoservicio = ln_CostoServicio
        _costoasignacion = ln_CostoAsginacion
    End Sub

#End Region

    Public Function Obtener(ByVal reporteconsumoequipo As e_ReporteConsumoEquipo) As e_ReporteConsumoEquipo Implements Ie_ReporteConsumoEquipo.Obtener
        Return reporteconsumoequipo
    End Function

End Class
