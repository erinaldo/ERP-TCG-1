Public Class e_ActivoFijo
    Implements Ie_ActivoFijo

#Region "Variables"

    Private FichaTecnicaValue As String = String.Empty
    Public TipoOperacion As String = String.Empty
    Public ListAF_CuentaContable As List(Of e_ActivoFijo_CuentaContable)
    Public ListDepreciacionAF As List(Of e_DepreciacionActivoFijo)
    Public ListReadecuacionAF As List(Of e_ReadecuacionActivoFijo)
    Public AsientoAF As e_Asiento
    Public IndReclasificando As Boolean = False
    Public IdAFReclasificado As String = String.Empty

    Public TipoCambio As Double = 0.0
#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Id() As String
    <DataMember()> _
    Public Property IdSedeEmpresa() As String
    <DataMember()> _
    Public Property IdResponsable() As String
    <DataMember()> _
    Public Property Codigo() As String
    <DataMember()> _
    Public Property IdEstado() As String
    <DataMember()> _
    Public Property FechaPropiedad() As Date
    <DataMember()> _
    Public Property IdPropiedadActual() As String
    <DataMember()> _
    Public Property DescripcionResumida() As String
    <DataMember()> _
    Public Property DescripcionDetallada() As String
    <DataMember()> _
    Public Property IdPeriodo() As String
    <DataMember()> _
    Public Property FechaIngreso() As Date
    <DataMember()> _
    Public Property IndFecActivacion() As Integer
    <DataMember()> _
    Public Property FechaActivacion() As Date
    <DataMember()> _
    Public Property IdConceptoIngreso() As String
    <DataMember()> _
    Public Property IdGrupoActivo() As String
    <DataMember()> _
    Public Property IdSubGrupoActivo() As String
    <DataMember()> _
    Public Property IdModelo() As String
    <DataMember()> _
    Public Property IdCentroCosto() As String
    <DataMember()> _
    Public Property IdUbicacion() As String
    <DataMember()> _
    Public Property IdMaterial() As String
    <DataMember()> _
    Public Property Cantidad() As Double
    <DataMember()> _
    Public Property IndDepreciable() As Integer
    <DataMember()> _
    Public Property IndRevalorizable() As Integer
    <DataMember()> _
    Public Property IndPertenencia() As Integer
    <DataMember()> _
    Public Property VidaUtil() As Double
    <DataMember()> _
    Public Property FechaCompra() As Date
    <DataMember()> _
    Public Property IndDocumento() As Integer
    <DataMember()> _
    Public Property IdDocumento() As String
    <DataMember()> _
    Public Property ValorCompra() As Double
    <DataMember()> _
    Public Property FechaSituacion() As Date
    <DataMember()> _
    Public Property ValorLibro() As Double
    <DataMember()> _
    Public Property RevalorizacionAcumulada() As Double
    <DataMember()> _
    Public Property DepreciacionAcumulada() As Double
    <DataMember()> _
    Public Property VidaUtilRemanente() As Double
    <DataMember()> _
    Public Property AnhoMesRevalorizacion() As Date
    <DataMember()> _
    Public Property AnhoMesDepreciacion() As Date
    <DataMember()> _
    Public Property IndBaja() As Integer
    <DataMember()> _
    Public Property FechaBaja() As Date
    <DataMember()> _
    Public Property IdConceptoBaja() As String
    <DataMember()> _
    Public Property DescripcionBaja() As String
    <DataMember()> _
    Public Property FichaTecnica() As String
        Get
            Return If(FichaTecnicaValue = String.Empty, "0", FichaTecnicaValue)
        End Get
        Set(ByVal value As String)
            FichaTecnicaValue = value
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
    <DataMember()> _
    Public Property UsuarioCreacion() As String
    <DataMember()> _
    Public Property FechaCreacion() As Date
    <DataMember()> _
    Public Property UsuarioModificacion() As String
    <DataMember()> _
    Public Property FechaModificacion() As Date
    <DataMember()> _
    Public Property ValorResidual() As Double
    <DataMember()> _
    Public Property IndReclasificado() As Boolean
    <DataMember()> _
    Public Property IdAFReclasifica() As String
    <DataMember()> _
    Public Property IdDocumentoBaja() As String
    <DataMember()> _
    Public Property IdAsientoBaja() As String
    <DataMember()> _
    Public Property IdAsientoReclasificacion() As String
    <DataMember()> _
    Public Property Depreciacion2014() As Double
    <DataMember()> _
    Public Property Depreciacion2015() As Double
    <DataMember()> _
    Public Property Costo2012() As Double
    <DataMember()> _
    Public Property IdActivoFijoDepende() As String


    <DataMember()> _
    Public Property Periodo() As String
    <DataMember()> _
    Public Property GrupoActivo() As String
    <DataMember()> _
    Public Property SubGrupoActivo() As String

#End Region

#Region "Constructor"

    Public Sub New()
        'Variables
        TipoOperacion = String.Empty
        ListAF_CuentaContable = New List(Of e_ActivoFijo_CuentaContable)
        ListDepreciacionAF = New List(Of e_DepreciacionActivoFijo)
        ListReadecuacionAF = New List(Of e_ReadecuacionActivoFijo)
        AsientoAF = New e_Asiento
        IndReclasificando = False
        IdAFReclasificado = String.Empty
        TipoCambio = 0.0
        'Propiedades
        Id = String.Empty
        IdSedeEmpresa = String.Empty
        IdResponsable = String.Empty
        Codigo = String.Empty
        IdEstado = String.Empty
        FechaPropiedad = #1/1/1901#
        IdPropiedadActual = String.Empty
        DescripcionResumida = String.Empty
        DescripcionDetallada = String.Empty
        IdPeriodo = String.Empty
        FechaIngreso = #1/1/1901#
        IndFecActivacion = 0
        FechaActivacion = #1/1/1901#
        IdConceptoIngreso = String.Empty
        IdGrupoActivo = String.Empty
        IdSubGrupoActivo = String.Empty
        IdModelo = String.Empty
        IdCentroCosto = String.Empty
        IdUbicacion = String.Empty
        IdMaterial = String.Empty
        Cantidad = 0.0
        IndDepreciable = 0
        IndRevalorizable = 0
        IndPertenencia = 0
        VidaUtil = 0.0
        FechaCompra = #1/1/1901#
        IndDocumento = 0
        IdDocumento = String.Empty
        ValorCompra = 0.0
        FechaSituacion = #1/1/1901#
        ValorLibro = 0.0
        RevalorizacionAcumulada = 0.0
        DepreciacionAcumulada = 0.0
        VidaUtilRemanente = 0.0
        AnhoMesRevalorizacion = #1/1/1901#
        AnhoMesDepreciacion = #1/1/1901#
        IndBaja = 0
        FechaBaja = #1/1/1901#
        IdConceptoBaja = String.Empty
        DescripcionBaja = String.Empty
        FichaTecnica = "0"
        Activo = True
        UsuarioCreacion = String.Empty
        FechaCreacion = #1/1/1901#
        UsuarioModificacion = String.Empty
        FechaModificacion = #1/1/1901#
        Periodo = String.Empty
        GrupoActivo = String.Empty
        SubGrupoActivo = String.Empty
        ValorResidual = 0.0
        IndReclasificado = False
        IdAFReclasifica = String.Empty
        IdDocumentoBaja = String.Empty
        IdAsientoBaja = String.Empty
        IdAsientoReclasificacion = String.Empty
        Depreciacion2014 = 0.0
        Depreciacion2015 = 0.0
        Costo2012 = 0.0
        IdActivoFijoDepende = String.Empty
    End Sub

#End Region

End Class
