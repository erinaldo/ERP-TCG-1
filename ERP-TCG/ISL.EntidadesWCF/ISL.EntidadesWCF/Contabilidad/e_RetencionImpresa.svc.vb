' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "e_RetencionImpresa" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione e_RetencionImpresa.svc o e_RetencionImpresa.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class e_RetencionImpresa
    Implements Ie_RetencionImpresa

    <DataMember()> _
    Public Property Id As String
    <DataMember()> _
    Public Property IdDocRet As String
    <DataMember()> _
    Public Property MotContigencia As String
    <DataMember()> _
    Public Property SerieRet As String
    <DataMember()> _
    Public Property NumeroRet As String
    <DataMember()> _
    Public Property FechaRet As Date
    <DataMember()> _
    Public Property RucPro As String
    <DataMember()> _
    Public Property TipoDocPro As String
    <DataMember()> _
    Public Property RazonSocial As String
    <DataMember()> _
    Public Property RegRet As String
    <DataMember()> _
    Public Property TasaRet As Double
    <DataMember()> _
    Public Property ImpTotRet As Double
    <DataMember()> _
    Public Property ImpTotPag As Double
    <DataMember()> _
    Public Property TipoDocRel As String
    <DataMember()> _
    Public Property SerieDocRel As String
    <DataMember()> _
    Public Property NumeroDocRel As String
    <DataMember()> _
    Public Property FechaEmidoc As Date
    <DataMember()> _
    Public Property TotalDoc As Double
    <DataMember()> _
    Public Property MonedaDoc As String
    <DataMember()> _
    Public Property FechaPago As Date
    <DataMember()> _
    Public Property NroVoucher As String
    <DataMember()> _
    Public Property ImpPago As Double
    <DataMember()> _
    Public Property MonedaPago As String
    <DataMember()> _
    Public Property ImpRetenido As Double
    <DataMember()> _
    Public Property FechaRetencion As Date
    <DataMember()> _
    Public Property ImpTotalPagar As Double
    <DataMember()> _
    Public Property MonExtranjera As String
    <DataMember()> _
    Public Property TipoCambio As String
    <DataMember()> _
    Public Property FechaTC As Date
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()> Public Fecha As Date

    Sub New()
        MonExtranjera = ""
        TipoCambio = ""
        FechaTC = Date.Parse("01/01/1901")
    End Sub

    Public Sub New(lsIdDocRet As String, lsMotContigencia As String, lsSerieRet As String, lsNumeroRet As String, ldFechaRet As Date, _
                   lsRucPro As String, lsTipoDocPro As String, lsRazonSocial As String, lsRegRet As String, lnTasaRet As Double, _
                   lnImpTotRet As Double, lnImpTotPag As Double, lsTipoDocRel As String, lsSerieDocRel As String, lsNumeroDocRel As String, _
                   ldFechaEmidoc As Date, lnTotalDoc As Double, lsMonedaDoc As String, ldFechaPago As Date, lsNroVoucher As String, _
                   lnImpPago As Double, lsMonedaPago As String, lnImpRetenido As Double, ldFechaRetencion As Date, lnImpTotalPagar As Double, _
                   lsMonExtranjera As String, lnTipoCambio As String, lsFechaTC As Date, lsId As String)
        IdDocRet = lsIdDocRet : MotContigencia = lsMotContigencia : SerieRet = lsSerieRet : NumeroRet = lsNumeroRet : FechaRet = ldFechaRet
        RucPro = lsRucPro : TipoDocPro = lsTipoDocPro : RazonSocial = lsRazonSocial : RegRet = lsRegRet : TasaRet = Math.Round(lnTasaRet, 2)
        ImpTotRet = Math.Round(lnImpTotRet, 2) : ImpTotPag = Math.Round(lnImpTotPag, 2) : TipoDocRel = lsTipoDocRel : SerieDocRel = lsSerieDocRel : NumeroDocRel = lsNumeroDocRel
        FechaEmidoc = ldFechaEmidoc : TotalDoc = Math.Round(lnTotalDoc, 2) : MonedaDoc = lsMonedaDoc : FechaPago = ldFechaPago : NroVoucher = lsNroVoucher
        ImpPago = Math.Round(lnImpPago, 2) : MonedaPago = lsMonedaPago : ImpRetenido = Math.Round(lnImpRetenido, 2) : FechaRetencion = ldFechaRetencion : ImpTotalPagar = Math.Round(lnImpTotalPagar, 2)
        MonExtranjera = lsMonExtranjera : TipoCambio = lnTipoCambio : FechaTC = lsFechaTC : Id = lsId
    End Sub

    Public Function Obtener(ByVal periodo As e_RetencionImpresa) As e_RetencionImpresa Implements Ie_RetencionImpresa.Obtener
        Return periodo
    End Function

End Class
