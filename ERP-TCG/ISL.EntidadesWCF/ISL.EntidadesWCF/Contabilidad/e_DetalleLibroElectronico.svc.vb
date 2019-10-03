<DataContract()> _
Public Class e_DetalleLibroElectronico
    Implements Ie_DetalleLibroElectronico
    Implements IEquatable(Of e_DetalleLibroElectronico)
    Implements ICloneable

#Region "Declaracion de Variables"

    Private _id As String
    Private _idlibroelectronico As String
    Private _idmovimientodocumento As String
    Private _periodo As String
    Private _CodigoUnicoOperacion As String
    Private _numerocorrelativo As String
    Private _fechaemision As Date
    Private _fechavencimiento As Date
    Private _tipodocumento As String
    Private _seriedoc As String
    Private _anioemisiondua As String
    Private _numerodoc As String
    Private _numerodoc2 As String
    Private _tipodocidentidad As String
    Private _numerodocidentidad As String
    Private _denominacion As String
    Private _subtotal1 As Double
    Private _igv1 As Double
    Private _subtotal2 As Double
    Private _igv2 As Double
    Private _subtotal3 As Double
    Private _igv3 As Double
    Private _nogravada As Double
    Private _isc As Double
    Private _otrostributos As Double
    Private _total As Double
    Private _tipocambio As Double
    Private _fechaemisionaso As Date
    Private _tipodocumentoaso As String
    Private _serieaso As String
    Private _numerodocaso As String
    Private _numerodocaso2 As String
    Private _fechaemisiondetraccion As Date
    Private _nroconstanciadetraccion As String
    Private _NroCorrelativoVenta As String
    Private _NroCorrelativoCompra As String
    Private _NroCorrelativoConsignacion As String
    Private _CodigoDuaDsiFob As String
    Private _retencion As String
    Private _indicador As String
    Private _activo As Boolean
    Private _CodigoMoneda As String
    Private _ClasificacionBienServicio As String
    Private _IdentificacionContratoProy As String
    Private _ErrorTipo1 As String
    Private _ErrorTipo2 As String
    Private _ErrorTipo3 As String
    Private _ErrorTipo4 As String
    Private _IndCancelaComprobPago As String
    Private _DsctoBaseImp As Double
    Private _DsctoIGV As Double
    Private _CodPais As String
    Private _CodConvenio As String
    Private _CodTipoRenta As String

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public IdPeriodo As String
    <DataMember()> _
    Public _Ejercicio As String
    <DataMember()> _
    Public _Mes As String
    <DataMember()> _
    Public Año As String
    <DataMember()> _
    Public CuentaInicial As String
    <DataMember()> _
    Public CuentaFinal As String
    <DataMember()> _
    Public IndClienteProveedor As String
    <DataMember()> _
    Public Equivale As Integer = 0
    <DataMember()>
    Public PrefijoID As String = ""
    Event DatoCambiado()

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
    Public Property IdLibroElectronico() As String
        Get
            Return _idlibroelectronico
        End Get
        Set(ByVal value As String)
            _idlibroelectronico = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMovimientoDocumento() As String
        Get
            Return _idmovimientodocumento
        End Get
        Set(ByVal value As String)
            _idmovimientodocumento = value
        End Set
    End Property

    <DataMember()> _
    Public Property Periodo() As String
        Get
            Return _periodo
        End Get
        Set(ByVal value As String)
            _periodo = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoUnicoOperacion() As String
        Get
            Return _CodigoUnicoOperacion
        End Get
        Set(ByVal value As String)
            _CodigoUnicoOperacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property NumeroCorrelativo() As String
        Get
            Return _numerocorrelativo
        End Get
        Set(ByVal value As String)
            _numerocorrelativo = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaEmision() As Date
        Get
            Return _fechaemision
        End Get
        Set(ByVal value As Date)
            _fechaemision = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaVencimiento() As Date
        Get
            Return _fechavencimiento
        End Get
        Set(ByVal value As Date)
            _fechavencimiento = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoDocumento() As String
        Get
            Return _tipodocumento
        End Get
        Set(ByVal value As String)
            _tipodocumento = value
        End Set
    End Property

    <DataMember()> _
    Public Property SerieDoc() As String
        Get
            Return _seriedoc
        End Get
        Set(ByVal value As String)
            _seriedoc = value
        End Set
    End Property

    <DataMember()> _
    Public Property AnioEmisionDUA() As String
        Get
            Return _anioemisiondua
        End Get
        Set(ByVal value As String)
            _anioemisiondua = value
        End Set
    End Property

    <DataMember()> _
    Public Property NumeroDoc() As String
        Get
            Return _numerodoc
        End Get
        Set(ByVal value As String)
            _numerodoc = value
        End Set
    End Property

    <DataMember()> _
    Public Property NumeroDoc2() As String
        Get
            Return _numerodoc2
        End Get
        Set(ByVal value As String)
            _numerodoc2 = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoDocIdentidad() As String
        Get
            Return _tipodocidentidad
        End Get
        Set(ByVal value As String)
            _tipodocidentidad = value
        End Set
    End Property

    <DataMember()> _
    Public Property NumeroDocIdentidad() As String
        Get
            Return _numerodocidentidad
        End Get
        Set(ByVal value As String)
            _numerodocidentidad = value
        End Set
    End Property

    <DataMember()> _
    Public Property Denominacion() As String
        Get
            Return _denominacion
        End Get
        Set(ByVal value As String)
            _denominacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property SubTotal1() As Double
        Get
            Return _subtotal1
        End Get
        Set(ByVal value As Double)
            _subtotal1 = value
        End Set
    End Property

    <DataMember()> _
    Public Property IGV1() As Double
        Get
            Return _igv1
        End Get
        Set(ByVal value As Double)
            _igv1 = value
        End Set
    End Property

    <DataMember()> _
    Public Property SubTotal2() As Double
        Get
            Return _subtotal2
        End Get
        Set(ByVal value As Double)
            _subtotal2 = value
        End Set
    End Property

    <DataMember()> _
    Public Property IGV2() As Double
        Get
            Return _igv2
        End Get
        Set(ByVal value As Double)
            _igv2 = value
        End Set
    End Property

    <DataMember()> _
    Public Property SubTotal3() As Double
        Get
            Return _subtotal3
        End Get
        Set(ByVal value As Double)
            _subtotal3 = value
        End Set
    End Property

    <DataMember()> _
    Public Property IGV3() As Double
        Get
            Return _igv3
        End Get
        Set(ByVal value As Double)
            _igv3 = value
        End Set
    End Property

    <DataMember()> _
    Public Property NoGravada() As Double
        Get
            Return _nogravada
        End Get
        Set(ByVal value As Double)
            _nogravada = value
        End Set
    End Property

    <DataMember()> _
    Public Property ISC() As Double
        Get
            Return _isc
        End Get
        Set(ByVal value As Double)
            _isc = value
        End Set
    End Property

    <DataMember()> _
    Public Property OtrosTributos() As Double
        Get
            Return _otrostributos
        End Get
        Set(ByVal value As Double)
            _otrostributos = value
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
    Public Property TipoCambio() As Double
        Get
            Return _tipocambio
        End Get
        Set(ByVal value As Double)
            _tipocambio = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaEmisionAso() As Date
        Get
            Return _fechaemisionaso
        End Get
        Set(ByVal value As Date)
            _fechaemisionaso = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoDocumentoAso() As String
        Get
            Return _tipodocumentoaso
        End Get
        Set(ByVal value As String)
            _tipodocumentoaso = value
        End Set
    End Property

    <DataMember()> _
    Public Property SerieAso() As String
        Get
            Return _serieaso
        End Get
        Set(ByVal value As String)
            _serieaso = value
        End Set
    End Property

    <DataMember()> _
    Public Property NumeroDocAso() As String
        Get
            Return _numerodocaso
        End Get
        Set(ByVal value As String)
            _numerodocaso = value
        End Set
    End Property

    <DataMember()> _
    Public Property NumeroDocAso2() As String
        Get
            Return _numerodocaso2
        End Get
        Set(ByVal value As String)
            _numerodocaso2 = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaEmisionDetraccion() As Date
        Get
            Return _fechaemisiondetraccion
        End Get
        Set(ByVal value As Date)
            _fechaemisiondetraccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroConstanciaDetraccion() As String
        Get
            Return _nroconstanciadetraccion
        End Get
        Set(ByVal value As String)
            _nroconstanciadetraccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroCorrelativoVenta() As String
        Get
            Return _NroCorrelativoVenta
        End Get
        Set(value As String)
            _NroCorrelativoVenta = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroCorrelativoCompra() As String
        Get
            Return _NroCorrelativoCompra
        End Get
        Set(value As String)
            _NroCorrelativoCompra = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroCorrelativoConsignacion() As String
        Get
            Return _NroCorrelativoConsignacion
        End Get
        Set(value As String)
            _NroCorrelativoConsignacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoDuaDsiFob() As String
        Get
            Return _CodigoDuaDsiFob
        End Get
        Set(value As String)
            _CodigoDuaDsiFob = value
        End Set
    End Property

    <DataMember()> _
    Public Property Retencion() As String
        Get
            Return _retencion
        End Get
        Set(ByVal value As String)
            _retencion = value
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
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoMoneda() As String
        Get
            Return _CodigoMoneda
        End Get
        Set(ByVal value As String)
            _CodigoMoneda = value
        End Set
    End Property

    <DataMember()> _
    Public Property ClasificacionBienServicio() As String
        Get
            Return _ClasificacionBienServicio
        End Get
        Set(ByVal value As String)
            _ClasificacionBienServicio = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdentificacionContratoProy() As String
        Get
            Return _IdentificacionContratoProy
        End Get
        Set(ByVal value As String)
            _IdentificacionContratoProy = value
        End Set
    End Property

    <DataMember()> _
    Public Property ErrorTipo1() As String
        Get
            Return _ErrorTipo1
        End Get
        Set(ByVal value As String)
            _ErrorTipo1 = value
        End Set
    End Property

    <DataMember()> _
    Public Property ErrorTipo2() As String
        Get
            Return _ErrorTipo2
        End Get
        Set(ByVal value As String)
            _ErrorTipo2 = value
        End Set
    End Property

    <DataMember()> _
    Public Property ErrorTipo3() As String
        Get
            Return _ErrorTipo3
        End Get
        Set(ByVal value As String)
            _ErrorTipo3 = value
        End Set
    End Property

    <DataMember()> _
    Public Property ErrorTipo4() As String
        Get
            Return _ErrorTipo4
        End Get
        Set(ByVal value As String)
            _ErrorTipo4 = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndCancelaComprobPago() As String
        Get
            Return _IndCancelaComprobPago
        End Get
        Set(ByVal value As String)
            _IndCancelaComprobPago = value
        End Set
    End Property

    <DataMember()> _
    Public Property DsctoBaseImp() As Double
        Get
            Return _DsctoBaseImp
        End Get
        Set(ByVal value As Double)
            _DsctoBaseImp = value
        End Set
    End Property

    <DataMember()> _
    Public Property DsctoIGV() As Double
        Get
            Return _DsctoIGV
        End Get
        Set(ByVal value As Double)
            _DsctoIGV = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodPais() As String
        Get
            Return _CodPais
        End Get
        Set(ByVal value As String)
            _CodPais = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodConvenio() As String
        Get
            Return _CodConvenio
        End Get
        Set(ByVal value As String)
            _CodConvenio = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodTipoRenta() As String
        Get
            Return _CodTipoRenta
        End Get
        Set(ByVal value As String)
            _CodTipoRenta = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        Activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdLibroElectronico As String _
              , ByVal ls_IdMovimientoDocumento As String _
              , ByVal ls_Periodo As String _
              , ByVal ls_CodigoUnicoOperacion As String _
              , ByVal ls_NumeroCorrelativo As String _
              , ByVal ld_FechaEmision As Date _
              , ByVal ld_FechaVencimiento As Date _
              , ByVal ls_TipoDocumento As String _
              , ByVal ls_SerieDoc As String _
              , ByVal ls_AnioEmisionDUA As String _
              , ByVal ls_NumeroDoc As String _
              , ByVal ls_NumeroDoc2 As String _
              , ByVal ls_TipoDocIdentidad As String _
              , ByVal ls_NumeroDocIdentidad As String _
              , ByVal ls_Denominacion As String _
              , ByVal ln_SubTotal1 As Double _
              , ByVal ln_IGV1 As Double _
              , ByVal ln_SubTotal2 As Double _
              , ByVal ln_IGV2 As Double _
              , ByVal ln_SubTotal3 As Double _
              , ByVal ln_IGV3 As Double _
              , ByVal ln_NoGravada As Double _
              , ByVal ln_ISC As Double _
              , ByVal ln_OtrosTributos As Double _
              , ByVal ln_Total As Double _
              , ByVal ln_TipoCambio As Double _
              , ByVal ld_FechaEmisionAso As Date _
              , ByVal ls_TipoDocumentoAso As String _
              , ByVal ls_SerieAso As String _
              , ByVal ls_NumeroDocAso As String _
              , ByVal ls_NumeroDocAso2 As String _
              , ByVal ld_FechaEmisionDetraccion As Date _
              , ByVal ls_NroConstanciaDetraccion As String _
              , ByVal ls_NroCorrelativoVenta As String _
              , ByVal ls_NroCorrelativoCompra As String _
              , ByVal ls_NroCorrelativoConsignacion As String _
              , ByVal ls_CodigoDuaDsiFob As String _
              , ByVal ls_Retencion As String _
              , ByVal ls_Indicador As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_CodigoMoneda As String _
              , ByVal ls_ClasificacionBienServicio As String _
              , ByVal ls_IdentificacionContratoProy As String _
              , ByVal ls_ErrorTipo1 As String _
              , ByVal ls_ErrorTipo2 As String _
              , ByVal ls_ErrorTipo3 As String _
              , ByVal ls_ErrorTipo4 As String _
              , ByVal ls_IndCancelaComprobPago As String _
              , ByVal ln_DsctoBaseImp As Double _
              , ByVal ln_DsctoIGV As Double _
              , ByVal ls_IndClienteProveedor As String _
              , ByVal ls_CodPais As String _
              , ByVal ls_CodConvenio As String _
              , ByVal ls_CodTipoRenta As String _
              , ByVal lb_AfectaAnticipo As Boolean _
           )
        _id = ls_Id
        _idlibroelectronico = ls_IdLibroElectronico
        _idmovimientodocumento = ls_IdMovimientoDocumento
        _periodo = ls_Periodo
        _CodigoUnicoOperacion = ls_CodigoUnicoOperacion
        _numerocorrelativo = ls_NumeroCorrelativo
        _fechaemision = ld_FechaEmision
        _fechavencimiento = If(ld_FechaVencimiento = "01/01/1900", "01/01/0001", ld_FechaVencimiento)
        _tipodocumento = ls_TipoDocumento
        _seriedoc = ls_SerieDoc
        _anioemisiondua = ls_AnioEmisionDUA
        _numerodoc = ls_NumeroDoc
        _numerodoc2 = ls_NumeroDoc2
        'If lb_InventarioBalance Then
        '    _tipodocidentidad = ls_TipoDocIdentidad
        '    _numerodocidentidad = ls_NumeroDocIdentidad
        '    _denominacion = ls_Denominacion
        'Else
        '_tipodocidentidad = IIf(ln_Total = 0, "", ls_TipoDocIdentidad)
        _tipodocidentidad = IIf(ls_NumeroDocIdentidad = "00000000002", "", ls_TipoDocIdentidad)

        '_numerodocidentidad = IIf(ln_Total = 0, "", ls_NumeroDocIdentidad)
        _numerodocidentidad = IIf(ls_NumeroDocIdentidad = "00000000002", "", ls_NumeroDocIdentidad)

        '_denominacion = IIf(ln_Total = 0, "", ls_Denominacion)
        _denominacion = IIf(ls_NumeroDocIdentidad = "00000000002", "", ls_Denominacion)

        'End If
        _subtotal1 = ln_SubTotal1
        _igv1 = ln_IGV1
        _subtotal2 = ln_SubTotal2
        _igv2 = ln_IGV2
        _subtotal3 = ln_SubTotal3
        _igv3 = ln_IGV3
        _nogravada = ln_NoGravada
        _isc = ln_ISC
        _otrostributos = ln_OtrosTributos
        _total = ln_Total
        _tipocambio = ln_TipoCambio
        '_fechaemisionaso = IIf(ld_FechaEmisionAso = "01/01/1900" Or ln_Total = 0, "01/01/0001", ld_FechaEmisionAso)
        _fechaemisionaso = IIf(ld_FechaEmisionAso = "01/01/1900" Or ls_NumeroDocIdentidad = "00000000002", "01/01/0001", ld_FechaEmisionAso)

        '_tipodocumentoaso = IIf(ln_Total = 0, "", ls_TipoDocumentoAso)
        _tipodocumentoaso = IIf(ls_NumeroDocIdentidad = "00000000002", "", ls_TipoDocumentoAso)

        '_serieaso = IIf(ln_Total = 0, "", ls_SerieAso)
        _serieaso = IIf(ls_NumeroDocIdentidad = "00000000002", "", ls_SerieAso)

        '_numerodocaso = IIf(ln_Total = 0, "", ls_NumeroDocAso)
        _numerodocaso = IIf(ls_NumeroDocIdentidad = "00000000002", "", ls_NumeroDocAso)

        _numerodocaso2 = ls_NumeroDocAso2
        _fechaemisiondetraccion = If(ld_FechaEmisionDetraccion = "01/01/1900", "01/01/0001", ld_FechaEmisionDetraccion)
        _nroconstanciadetraccion = ls_NroConstanciaDetraccion
        _NroCorrelativoVenta = ls_NroCorrelativoVenta
        _NroCorrelativoCompra = ls_NroCorrelativoCompra
        _NroCorrelativoConsignacion = ls_NroCorrelativoConsignacion
        _CodigoDuaDsiFob = ls_CodigoDuaDsiFob
        _retencion = ls_Retencion
        _indicador = IIf(ls_NumeroDocIdentidad = "00000000002", "2", ls_Indicador)
        _activo = lb_Activo
        _CodigoMoneda = ls_CodigoMoneda
        _ClasificacionBienServicio = ls_ClasificacionBienServicio
        _IdentificacionContratoProy = ls_IdentificacionContratoProy
        _ErrorTipo1 = ls_ErrorTipo1
        _ErrorTipo2 = ls_ErrorTipo2
        _ErrorTipo3 = ls_ErrorTipo3
        _ErrorTipo4 = ls_ErrorTipo4
        _IndCancelaComprobPago = ls_IndCancelaComprobPago
        _DsctoBaseImp = ln_DsctoBaseImp
        _DsctoIGV = ln_DsctoIGV
        IndClienteProveedor = ls_IndClienteProveedor
        'Para Compras
        If ls_CodPais.Split("_").Count >= 2 Then
            _CodPais = ls_CodPais.Split("_")(0)
            _CodConvenio = ls_CodPais.Split("_")(1)
        Else
            _CodPais = ls_CodPais
            _CodConvenio = ls_CodConvenio
        End If
        _CodTipoRenta = ls_CodTipoRenta
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal detallelibroelectronico As e_DetalleLibroElectronico) As e_DetalleLibroElectronico Implements Ie_DetalleLibroElectronico.Obtener
        Return detallelibroelectronico
    End Function

    Public Overloads Function Equals(ByVal oePLEDet As e_DetalleLibroElectronico) As Boolean Implements System.IEquatable(Of e_DetalleLibroElectronico).Equals
        With oePLEDet
            Select Case .Equivale
                Case 2 : If Me.Periodo.Trim = .Periodo.Trim AndAlso Me.CodigoUnicoOperacion = .CodigoUnicoOperacion _
                    AndAlso Me.ErrorTipo2 = .ErrorTipo2 AndAlso Me.CodConvenio.Trim = .CodConvenio.Trim _
                    AndAlso Me.FechaEmision = .FechaEmision AndAlso Me.ErrorTipo3 = .ErrorTipo3 Then Return True
                    'AndAlso Me.TipoDocumento = .TipoDocumento AndAlso Me.SerieDoc = .SerieDoc AndAlso Me.NumeroDoc = .NumeroDoc Then Return True
            End Select
        End With
        Return False
    End Function

    Public Function Clonar() As Object Implements System.ICloneable.Clone
        Dim oeDetLE As New e_DetalleLibroElectronico
        With oeDetLE
            .Id = Me.Id
            .IdLibroElectronico = Me.IdLibroElectronico
            .IdMovimientoDocumento = Me.IdMovimientoDocumento
            .Periodo = Me.Periodo
            .CodigoUnicoOperacion = Me.CodigoUnicoOperacion
            .NumeroCorrelativo = Me.NumeroCorrelativo
            .FechaEmision = Me.FechaEmision
            .FechaVencimiento = Me.FechaVencimiento
            .TipoDocumento = Me.TipoDocumento
            .SerieDoc = Me.SerieDoc
            .AnioEmisionDUA = Me.AnioEmisionDUA
            .NumeroDoc = Me.NumeroDoc
            .NumeroDoc2 = Me.NumeroDoc2
            .TipoDocIdentidad = Me.TipoDocIdentidad
            .NumeroDocIdentidad = Me.NumeroDocIdentidad
            .Denominacion = Me.Denominacion
            .SubTotal1 = Me.SubTotal1
            .IGV1 = Me.IGV1
            .SubTotal2 = Me.SubTotal2
            .IGV2 = Me.IGV2
            .SubTotal3 = Me.SubTotal3
            .IGV2 = Me.IGV2
            .SubTotal3 = Me.SubTotal3
            .IGV3 = Me.IGV3
            .NoGravada = Me.NoGravada
            .ISC = Me.ISC
            .OtrosTributos = Me.OtrosTributos
            .Total = Me.Total
            .TipoCambio = Me.TipoCambio
            .FechaEmisionAso = Me.FechaEmisionAso
            .TipoDocumentoAso = Me.TipoDocumentoAso
            .SerieAso = Me.SerieAso
            .NumeroDocAso = Me.NumeroDocAso
            .NumeroDocAso2 = Me.NumeroDocAso2
            .FechaEmisionDetraccion = Me.FechaEmisionDetraccion
            .NroConstanciaDetraccion = Me.NroConstanciaDetraccion
            .NroCorrelativoVenta = Me.NroCorrelativoVenta
            .NroCorrelativoCompra = Me.NroCorrelativoCompra
            .NroCorrelativoConsignacion = Me.NroCorrelativoConsignacion
            .CodigoDuaDsiFob = Me.CodigoDuaDsiFob
            .Retencion = Me.Retencion
            .Indicador = Me.Indicador
            .Activo = Me.Activo
            .CodigoMoneda = Me.CodigoMoneda
            .ClasificacionBienServicio = Me.ClasificacionBienServicio
            .IdentificacionContratoProy = Me.IdentificacionContratoProy
            .ErrorTipo1 = Me.ErrorTipo1
            .ErrorTipo2 = Me.ErrorTipo2
            .ErrorTipo3 = Me.ErrorTipo3
            .ErrorTipo4 = Me.ErrorTipo4
            .IndCancelaComprobPago = Me.IndCancelaComprobPago
            .DsctoBaseImp = Me.DsctoBaseImp
            .DsctoIGV = Me.DsctoIGV
            .CodPais = Me.CodPais
            .CodConvenio = Me.CodConvenio
            .CodTipoRenta = Me.CodTipoRenta
        End With
        Return oeDetLE
    End Function

#End Region

End Class
