Public Class e_ComprobantePagoElectronico_Detalle

    Public Property TipoOperacion() As String
    Public Property IdDocumento() As String
    Public Property IdMaterial() As String
    Public Property IndMaterial_Servicio() As String
    Public Property UMedida() As String
    Public Property Cantidad() As Double
    Public Property Producto() As String
    Public Property IndIGV() As Boolean
    Public Property IndInafecta() As Boolean
    Public Property IndExonerada() As Boolean
    Public Property IndISC() As Boolean
    Public Property IndIVAP() As Boolean
    Public Property TotalIGV() As Double
    Public Property TotalInafecta() As Double
    Public Property TotalExonerada() As Double
    Public Property TotalISC() As Double
    Public Property TotalIVAP() As Double
    Public Property CostoUnitario() As Double
    Public Property PrecioUnitario() As Double
    Public Property PrecioTotal() As Double
    Public Property CostoTotal() As Double

    Public Sub New()
        TipoOperacion = "GEN"
        IdDocumento = ""
        IdMaterial = ""
        IndMaterial_Servicio = ""
        UMedida = ""
        Cantidad = 0
        Producto = ""
        IndIGV = False
        IndInafecta = False
        IndExonerada = False
        IndISC = False
        IndIVAP = False
        TotalIGV = 0
        TotalInafecta = 0
        TotalExonerada = 0
        TotalISC = 0
        TotalIVAP = 0
        CostoUnitario = 0
        PrecioUnitario = 0
        PrecioTotal = 0
        CostoTotal = 0
    End Sub

    Public Sub New(
                 p_IdDocumento As String _
                , p_IdMaterial As String _
                , p_IndMaterial_Servicio As String _
                , p_UMedida As String _
                , p_Cantidad As Double _
                , p_Producto As String _
                , p_IndIGV As Boolean _
                , p_IndInafecta As Boolean _
                , p_IndExonerada As Boolean _
                , p_IndISC As Boolean _
                , p_IndIVAP As Boolean _
                , p_TotalIGV As Double _
                , p_TotalInafecta As Double _
                , p_TotalExonerada As Double _
                , p_TotalISC As Double _
                , p_TotalIVAP As Double _
                , p_CostoUnitario As Double _
                , p_PrecioUnitario As Double _
                , p_PrecioTotal As Double _
                , p_CostoTotal As Double)
        IdDocumento = p_IdDocumento
        IdMaterial = p_IdMaterial
        IndMaterial_Servicio = p_IndMaterial_Servicio
        UMedida = p_UMedida
        Cantidad = p_Cantidad
        Producto = p_Producto
        IndIGV = p_IndIGV
        IndInafecta = p_IndInafecta
        IndExonerada = p_IndExonerada
        IndISC = p_IndISC
        IndIVAP = p_IndIVAP
        TotalIGV = p_TotalIGV
        TotalInafecta = p_TotalInafecta
        TotalExonerada = p_TotalExonerada
        TotalISC = p_TotalISC
        TotalIVAP = p_TotalIVAP
        CostoUnitario = p_CostoUnitario
        PrecioUnitario = p_PrecioUnitario
        PrecioTotal = p_PrecioTotal
        CostoTotal = p_CostoTotal
    End Sub

    Public Sub Dispose()
        IdDocumento = ""
        IdMaterial = ""
        IndMaterial_Servicio = ""
        UMedida = ""
        Cantidad = 0
        Producto = ""
        IndIGV = False
        IndInafecta = False
        IndExonerada = False
        IndISC = False
        IndIVAP = False
        TotalIGV = 0
        TotalInafecta = 0
        TotalExonerada = 0
        TotalISC = 0
        TotalIVAP = 0
        CostoUnitario = 0
        PrecioUnitario = 0
        PrecioTotal = 0
        CostoTotal = 0
    End Sub

End Class
