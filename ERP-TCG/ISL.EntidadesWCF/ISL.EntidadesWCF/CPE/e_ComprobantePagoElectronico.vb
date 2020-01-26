Public Class e_ComprobantePagoElectronico


    Public Property Sel() As Boolean
    Public Property Id() As String
    Public Property IdEmpresaSis() As String
    Public Property IdCentro() As String
    Public Property TipoOperacion() As String
    Public Property TipoDocumento() As String
    Public Property Documento() As String
    Public Property FechaEmision() As Date
    Public Property FechaVencimiento() As Date
    Public Property Moneda() As String
    Public Property MontoLetras() As String
    Public Property NombreComercial() As String
    Public Property RazonSocial() As String
    Public Property DomFiscal() As String
    Public Property IndMatServ() As String
    Public Property Total() As Double
    Public Property SubTotal() As Double
    Public Property TotalIGV() As Double
    Public Property TotalISC() As Double
    Public Property TotalExo() As Double
    Public Property TotalGratis() As Double
    Public Property TotalOtros() As Double
    Public Property TotalInafecto() As Double
    Public Property RUCEmisor() As String
    Public Property CentroEmisor() As String
    Public Property DocumentoReceptor() As String
    Public Property Receptor() As String
    Public Property DireccionReceptor() As String
    Public Property UrbReceptor() As String
    Public Property ProvinciaReceptor() As String
    Public Property DepartamentoReceptor() As String
    Public Property UbigeoReceptor() As String
    Public Property DistritoReceptor() As String
    Public Property DctoGlobal() As Double
    Public Property PorcentajeDcto() As Double
    Public Property CodigoMotivo() As String
    Public Property Motivo() As String
    Public Property Glosa() As String
    Public Property DocumentoAsoc() As String
    Public Property TipoDocAsoc() As String
    Public Property FechaDocAsoc() As Date
    Public Property Hash() As String
    Public Property RptaSunat() As String
    Public Property RutaZip() As String
    Public Property NombreArchivo() As String
    Public Property Usuario As String
    Public Property IdResumen As String
    Public Property IdEstadoSunat As String

    Public Property Detalles() As List(Of e_ComprobantePagoElectronico_Detalle)

    Public Sub New()
        Sel = False
        Id = ""
        IdEmpresaSis = ""
        IdCentro = ""
        TipoOperacion = ""
        TipoDocumento = ""
        Documento = ""
        FechaEmision = "01/01/1901"
        FechaVencimiento = "01/01/1901"
        Moneda = ""
        MontoLetras = ""
        NombreComercial = ""
        RazonSocial = ""
        DomFiscal = ""
        IndMatServ = ""
        Total = 0
        SubTotal = 0
        TotalIGV = 0
        TotalISC = 0
        TotalExo = 0
        TotalGratis = 0
        TotalOtros = 0
        TotalInafecto = 0
        RUCEmisor = ""
        CentroEmisor = ""
        DocumentoReceptor = ""
        Receptor = ""
        DireccionReceptor = ""
        UrbReceptor = ""
        ProvinciaReceptor = ""
        DepartamentoReceptor = ""
        UbigeoReceptor = ""
        DistritoReceptor = ""
        DctoGlobal = 0
        PorcentajeDcto = 0
        CodigoMotivo = ""
        Motivo = ""
        Glosa = ""
        DocumentoAsoc = ""
        TipoDocAsoc = ""
        FechaDocAsoc = "01/01/1901"
        Hash = ""
        RptaSunat = ""
        RutaZip = ""
        NombreArchivo = ""
        Usuario = ""
        IdResumen = ""
        IdEstadoSunat = ""
    End Sub

    Public Sub New(
     p_Id As String _
    , p_IdEmpresaSis As String _
    , p_IdCentro As String _
    , p_TipoOperacion As String _
    , p_TipoDocumento As String _
    , p_Documento As String _
    , p_FechaEmision As Date _
    , p_FechaVencimiento As Date _
    , p_Moneda As String _
    , p_MontoLetras As String _
    , p_NombreComercial As String _
    , p_RazonSocial As String _
    , p_DomFiscal As String _
    , p_IndMatServ As String _
    , p_Total As Double _
    , p_SubTotal As Double _
    , p_TotalIGV As Double _
    , p_TotalISC As Double _
    , p_TotalExo As Double _
    , p_TotalGratis As Double _
    , p_TotalOtros As Double _
    , p_TotalInafecto As Double _
    , p_RUCEmisor As String _
    , p_CentroEmisor As String _
    , p_DocumentoReceptor As String _
    , p_Receptor As String _
    , p_DireccionReceptor As String _
    , p_UrbReceptor As String _
    , p_ProvinciaReceptor As String _
    , p_DepartamentoReceptor As String _
    , p_UbigeoReceptor As String _
    , p_DistritoReceptor As String _
    , p_DctoGlobal As Double _
    , p_PorcentajeDcto As Double _
    , p_CodigoMotivo As String _
    , p_Motivo As String _
    , p_Glosa As String _
    , p_DocumentoAsoc As String _
    , p_TipoDocAsoc As String _
    , p_FechaDocAsoc As Date _
    , p_Hash As String _
    , p_RptaSunat As String _
    , p_RutaZip As String _
    , p_NombreArchivo As String _
    , p_Usuario As String _
    , p_IdResumen As String _
    , p_IdEstadoSunat As String)

        Id = p_Id
        IdEmpresaSis = p_IdEmpresaSis
        IdCentro = p_IdCentro
        TipoOperacion = p_TipoOperacion
        TipoDocumento = p_TipoDocumento
        Documento = p_Documento
        FechaEmision = p_FechaEmision
        FechaVencimiento = p_FechaVencimiento
        Moneda = p_Moneda
        MontoLetras = p_MontoLetras
        NombreComercial = p_NombreComercial
        RazonSocial = p_RazonSocial
        DomFiscal = p_DomFiscal
        IndMatServ = p_IndMatServ
        Total = p_Total
        SubTotal = p_SubTotal
        TotalIGV = p_TotalIGV
        TotalISC = p_TotalISC
        TotalExo = p_TotalExo
        TotalGratis = p_TotalGratis
        TotalOtros = p_TotalOtros
        TotalInafecto = p_TotalInafecto
        RUCEmisor = p_RUCEmisor
        CentroEmisor = p_CentroEmisor
        DocumentoReceptor = p_DocumentoReceptor
        Receptor = p_Receptor
        DireccionReceptor = p_DireccionReceptor
        UrbReceptor = p_UrbReceptor
        ProvinciaReceptor = p_ProvinciaReceptor
        DepartamentoReceptor = p_DepartamentoReceptor
        UbigeoReceptor = p_UbigeoReceptor
        DistritoReceptor = p_DistritoReceptor
        DctoGlobal = p_DctoGlobal
        PorcentajeDcto = p_PorcentajeDcto
        CodigoMotivo = p_CodigoMotivo
        Motivo = p_Motivo
        Glosa = p_Glosa
        DocumentoAsoc = p_DocumentoAsoc
        TipoDocAsoc = p_TipoDocAsoc
        FechaDocAsoc = p_FechaDocAsoc
        p_Hash = p_Hash
        RptaSunat = p_RptaSunat
        RutaZip = p_RutaZip
        p_NombreArchivo = p_NombreArchivo
        Usuario = p_Usuario
        IdResumen = p_IdResumen
        IdEstadoSunat = p_IdEstadoSunat
    End Sub

    Public Sub Dispose()
        Sel = False
        Id = ""
        IdEmpresaSis = ""
        IdCentro = ""
        TipoOperacion = ""
        TipoDocumento = ""
        Documento = ""
        FechaEmision = "01/01/1901"
        FechaVencimiento = "01/01/1901"
        Moneda = ""
        MontoLetras = ""
        NombreComercial = ""
        RazonSocial = ""
        DomFiscal = ""
        IndMatServ = ""
        Total = 0
        SubTotal = 0
        TotalIGV = 0
        TotalISC = 0
        TotalExo = 0
        TotalGratis = 0
        TotalOtros = 0
        TotalInafecto = 0
        RUCEmisor = ""
        CentroEmisor = ""
        DocumentoReceptor = ""
        Receptor = ""
        DireccionReceptor = ""
        UrbReceptor = ""
        ProvinciaReceptor = ""
        DepartamentoReceptor = ""
        UbigeoReceptor = ""
        DistritoReceptor = ""
        DctoGlobal = 0
        PorcentajeDcto = 0
        CodigoMotivo = ""
        Motivo = ""
        Glosa = ""
        DocumentoAsoc = ""
        TipoDocAsoc = ""
        FechaDocAsoc = "01/01/1901"
        Hash = ""
        RptaSunat = ""
        RutaZip = ""
        NombreArchivo = ""
        Usuario = ""
        IdResumen = ""
        IdEstadoSunat = ""
    End Sub

End Class
