'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Microsoft.Reporting.WinForms
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_ReporteFacturaVenta

    Dim leDetalleDoc As New List(Of e_DetalleDoc_OperacionDet)
    Dim MensajeIsl As New c_Alertas

    Private Sub frm_ReporteFacturaVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.ReportViewer1.RefreshReport()
    End Sub

    Public Function CrearDTFactura() As Data.DataTable
        Dim DetalleFac As New Data.DataTable
        With DetalleFac
            .Columns.Add(New Data.DataColumn("TipoDocumento", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Serie", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Numero", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaEmision", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("ImporteDetraer", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Detraccion", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("NetoPagar", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("ValorVenta", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Igv", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("PrecioVenta", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Ruc", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Direccion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Cliente", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("MontoLetra", Type.GetType("System.String")))
        End With
        Return DetalleFac
    End Function

    Public Function CrearDTDetalleFactura() As Data.DataTable
        Dim DetalleFac As New Data.DataTable
        With DetalleFac
            .Columns.Add(New Data.DataColumn("Cantidad", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Unidad", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Descripcion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Cv", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FRUnit", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("FRTotal", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("ValorUnit", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("ValorTotal", Type.GetType("System.Double")))
        End With
        Return DetalleFac
    End Function

    Public Sub CargarDocumento(oeDocumentoVenta As e_MovimientoDocumento, leDetalleDoc As List(Of e_DetalleDoc_OperacionDet), UnDetalle As Boolean, _
                                Observacion As Boolean, Omitir As Boolean, leGTGR As List(Of e_GuiaTransportista), optIgv As Boolean, detraccioncero As Boolean, _
                                OmitirAdjunto As Boolean, CantTonelada As Double, Optional ByVal VistaPrevia As Boolean = False)
        Try
            Dim dtFactura As DataTable = CrearDTFactura()
            Dim dtDetalle As DataTable = CrearDTDetalleFactura()
            'Cuerpo de la factura
            Dim rwFactura As Data.DataRow
            rwFactura = dtFactura.NewRow

            Dim oeIGV As New e_Impuesto, olIGV As New l_Impuesto
            Dim leTemp As New List(Of e_GuiaTransportista)
            Dim Cant As Double = 0, ValorUnit As Double = 0, vrefuni As Double = -1, vreftot As Double = -1, vx As Double = -1
            Dim Ruta As String = "", Producto As String = "", Descripcion As String = ""
            Dim bandruta As Boolean = False, bandprod As Boolean = False

            With oeDocumentoVenta
                'Carga los detalles de la factura
                dtFactura.Rows.Add(rwFactura)
                leDetalleDoc = IIf(VistaPrevia, leDetalleDoc, .leDetalleDocOperDet)
                If leDetalleDoc.Count > 0 Then
                    'Cuando Tiene mas de 8 Detalles se genera un solo detalle con hoja adjunta
                    If leDetalleDoc.Count > 8 Then
                        Dim Unid As String = leDetalleDoc(0).UnidadMedida
                        Cant = IIf(Omitir = True, 0, leDetalleDoc.Sum(Function(item) item.Cantidad))
                        ValorUnit = IIf(Omitir = True, .SubTotal, leDetalleDoc(0).PrecioUnitario)
                        If Not VistaPrevia Then
                            For Each oeDetAux In leDetalleDoc
                                oeDetAux.FactorRefTotal = oeDetAux.FactorRefUni * CantTonelada
                            Next
                        End If
                        vx = leDetalleDoc.Sum(Function(item) item.FactorRefTotal)
                        vreftot = IIf(vx > .Total, vx, .Total)
                        For Each oedet As e_DetalleDoc_OperacionDet In leDetalleDoc
                            If Ruta <> oedet.Origen.Trim & " - " & oedet.Destino.Trim Then
                                If Ruta <> "" Then bandruta = True
                                Ruta = oedet.Origen.Trim & " - " & oedet.Destino.Trim
                            End If
                            If Producto <> oedet.MaterialServicio Then
                                If Producto <> "" Then bandprod = True
                                Producto = oedet.MaterialServicio
                            End If
                        Next
                        Dim rwDetalle As Data.DataRow
                        rwDetalle = dtDetalle.NewRow
                        rwDetalle("Cantidad") = Cant : rwDetalle("Unidad") = Unid
                        If Not bandruta Then
                            Descripcion = " RUTA: " & Ruta & Environment.NewLine : vrefuni = leDetalleDoc(0).FactorRefUni
                        Else
                            Descripcion = " DIVERSOS DESTINOS " & Environment.NewLine
                        End If
                        If Not bandprod Then Descripcion = Descripcion & " PRODUCTO: " & Producto & Environment.NewLine
                        rwDetalle("Descripcion") = IIf(Omitir = True, " POR SERVICIO DE TRANSPORTE" & Environment.NewLine & " DIVERSOS DESTINOS", _
                                                       Descripcion & Environment.NewLine & IIf(OmitirAdjunto = True, "", " DETALLE SEGÚN ANEXO ADJUNTO"))
                        rwDetalle("Cv") = ""
                        If detraccioncero Then
                            rwDetalle("FRUnit") = -1 : rwDetalle("FRTotal") = -1
                        Else
                            rwDetalle("FRUnit") = IIf(Omitir = True, -1, vrefuni) : rwDetalle("FRTotal") = IIf(Omitir = True, -1, vx)
                        End If
                        rwDetalle("ValorUnit") = ValorUnit : rwDetalle("ValorTotal") = .SubTotal
                        dtDetalle.Rows.Add(rwDetalle)
                    Else
                        'Cuando se activo la opcion de mostrar un solo detalle
                        If UnDetalle Then
                            Dim _Unidx As String = leDetalleDoc(0).UnidadMedida
                            Cant = IIf(Omitir = True, 0, leDetalleDoc.Sum(Function(item) item.Cantidad))
                            ValorUnit = IIf(Omitir = True, .SubTotal, leDetalleDoc(0).PrecioUnitario)
                            vx = leDetalleDoc.Sum(Function(item) item.FactorRefTotal)
                            vreftot = IIf(vx > .Total, vx, .Total)
                            For Each oedet As e_DetalleDoc_OperacionDet In leDetalleDoc
                                If Ruta <> oedet.Origen.Trim & " - " & oedet.Destino.Trim Then
                                    If Ruta <> "" Then bandruta = True
                                    Ruta = oedet.Origen.Trim & " - " & oedet.Destino.Trim
                                End If
                                If Producto <> oedet.MaterialServicio Then
                                    If Producto <> "" Then bandprod = True
                                    Producto = oedet.MaterialServicio
                                End If
                            Next
                            Dim rwDetalle As Data.DataRow
                            rwDetalle = dtDetalle.NewRow
                            rwDetalle("Cantidad") = Cant : rwDetalle("Unidad") = _Unidx
                            If Not bandruta Then
                                Descripcion = " RUTA: " & Ruta & Environment.NewLine : vrefuni = leDetalleDoc(0).FactorRefUni
                            Else
                                Descripcion = " DIVERSOS DESTINOS " & Environment.NewLine
                            End If
                            If Not bandprod Then Descripcion = Descripcion & " PRODUCTO: " & Producto & Environment.NewLine
                            rwDetalle("Descripcion") = IIf(Omitir = True, " POR SERVICIO DE TRANSPORTE" & Environment.NewLine & " DIVERSOS DESTINOS", _
                                                           Descripcion & Environment.NewLine & IIf(OmitirAdjunto = True, "", " DETALLE SEGÚN ANEXO ADJUNTO"))
                            rwDetalle("Cv") = ""
                            If detraccioncero Then
                                rwDetalle("FRUnit") = -1 : rwDetalle("FRTotal") = -1
                            Else
                                rwDetalle("FRUnit") = IIf(Omitir = True, -1, vrefuni) : rwDetalle("FRTotal") = IIf(Omitir = True, -1, vx)
                            End If
                            rwDetalle("ValorUnit") = ValorUnit : rwDetalle("ValorTotal") = .SubTotal
                            dtDetalle.Rows.Add(rwDetalle)
                        Else
                            'Cuando la cantidad de detalles es menor que igual 8
                            For Each oedetalle As e_DetalleDoc_OperacionDet In leDetalleDoc
                                Dim cadena As String = "", Doc() As String, idDet As String = ""
                                leTemp = New List(Of e_GuiaTransportista)
                                If leGTGR.Count > 0 Then
                                    idDet = oedetalle.IdOperacionDetalle
                                    leTemp = leGTGR.Where(Function(item) item.Id = idDet).ToList
                                    cadena = leTemp(0).Serie & " - " & leTemp(0).Numero.Substring(0, leTemp(0).Numero.Length - 1)
                                Else
                                    Doc = Split(oedetalle.Glosa, ",")
                                    If Doc.Length = 3 Then
                                        cadena = Doc(1).Trim & " - " & Doc(2).Trim
                                    Else
                                        If Doc.Length = 4 Then
                                            cadena = Doc(2).Trim & " - " & Doc(3).Trim
                                        Else
                                            cadena = Doc(0)
                                        End If
                                    End If
                                End If
                                Dim rwDetalle As Data.DataRow
                                rwDetalle = dtDetalle.NewRow
                                If Omitir Then
                                    rwDetalle("Cantidad") = 0
                                    rwDetalle("Unidad") = ""
                                Else
                                    rwDetalle("Cantidad") = oedetalle.Cantidad
                                    rwDetalle("Unidad") = " " & oedetalle.UnidadMedida
                                End If
                                If oedetalle.IndConsolidado = 2 Then
                                    rwDetalle("Descripcion") = "PRODUCTO:" & oedetalle.MaterialServicio & "-RUTA: " & oedetalle.Origen & "-" & oedetalle.Destino _
                               & "-" & oedetalle.Tracto & "-" & oedetalle.Carreta & "-OP:" & oedetalle._NroOperacion & " " & cadena & " , Aplicacion consolidado al Flete Unitario"
                                Else
                                    If oedetalle.IndConsolidado = 1 Then
                                        rwDetalle("Descripcion") = "Aplicacion Consolidado: " & oedetalle.GlosaConsolidado
                                    Else
                                        rwDetalle("Descripcion") = "PRODUCTO:" & oedetalle.MaterialServicio & "-RUTA: " & oedetalle.Origen & "-" & oedetalle.Destino _
                               & "-" & oedetalle.Tracto & "-" & oedetalle.Carreta & "-OP:" & oedetalle._NroOperacion & " " & cadena
                                    End If
                                End If

                                rwDetalle("Cv") = oedetalle.CV
                                rwDetalle("FRUnit") = oedetalle.FactorRefUni
                                rwDetalle("FRTotal") = IIf(oedetalle.FactorRefTotal = 0, IIf(oedetalle.UnidadMedida = "TONELADA", oedetalle.Cantidad, 30) * oedetalle.FactorRefUni, oedetalle.FactorRefTotal)
                                rwDetalle("ValorUnit") = oedetalle.PrecioUnitario
                                rwDetalle("ValorTotal") = oedetalle.Valor
                                dtDetalle.Rows.Add(rwDetalle)
                            Next
                        End If

                    End If
                Else
                    Dim rwDetalle As Data.DataRow
                    rwDetalle = dtDetalle.NewRow
                    rwDetalle("Cantidad") = IIf(Omitir, 0, 1)
                    rwDetalle("Unidad") = IIf(Omitir, "", "VIAJE")
                    Dim lscadena As String()
                    lscadena = .Venta.Glosa.Split("&")
                    If lscadena.Length > 0 Then
                        rwDetalle("Descripcion") = " " & lscadena(0)
                    Else
                        rwDetalle("Descripcion") = " " & .Venta.Glosa
                    End If
                    rwDetalle("Cv") = ""
                    rwDetalle("FRUnit") = -1
                    rwDetalle("FRTotal") = -1
                    rwDetalle("ValorUnit") = .SubTotal
                    rwDetalle("ValorTotal") = .SubTotal
                    dtDetalle.Rows.Add(rwDetalle)
                End If
                If Observacion Then
                    Dim rwDeta As Data.DataRow
                    rwDeta = dtDetalle.NewRow
                    rwDeta("Cantidad") = 0
                    rwDeta("Unidad") = ""
                    rwDeta("Descripcion") = "" & Environment.NewLine & .Observacion
                    rwDeta("Cv") = ""
                    rwDeta("FRUnit") = -1
                    rwDeta("FRTotal") = -1
                    rwDeta("ValorUnit") = 0
                    rwDeta("ValorTotal") = 0
                    dtDetalle.Rows.Add(rwDeta)
                End If
                'Obtiene Datos de Moneda
                Dim oeMoneda As New e_Moneda, olMoneda As New l_Moneda
                oeMoneda.Activo = True : oeMoneda.Id = oeDocumentoVenta.IdMoneda
                oeMoneda = olMoneda.Obtener(oeMoneda)
                Dim igvcad As String = ""
                If optIgv Then oeIGV = New e_Impuesto : oeIGV = olIGV.IGV(oeDocumentoVenta.FechaEmision) : igvcad = oeIGV.Porcentaje * 100
                'Procesa los datos de la factura
                Me.rptFacturaVenta.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                Me.rptFacturaVenta.Visible = True
                'Nueva Linea Local--------
                ' Me.rptFacturaVenta.LocalReport.ReportPath = "Reportes\rptFacturaPrueba.rdlc"
                '-------------------------
                Dim oReport As New ReportDataSource("dsFacturaVenta_FacturaVenta", dtFactura)
                Dim oReport1 As New ReportDataSource("dsFacturaVenta_DetalleFactura", dtDetalle)
                Dim oeDir As New e_Direccion_EmpresaPersona, olDir As New l_Direccion_EmpresaPersona, leDir As New List(Of e_Direccion_EmpresaPersona)
                Dim DirPrin As String = "", DirSuc As String = ""
                With oeDir
                    .TipoOperacion = "A"
                    .TipoPersonaEmpresa = 2
                    .IdPersonaEmpresa = gs_IdEmpresaSistema.Trim
                    .Principal = -1
                End With

                leDir = olDir.Listar(oeDir)
                If leDir.Count > 0 Then
                    Dim _lDirPrin = leDir.Where(Function(it) it.Principal = 1).ToList
                    If _lDirPrin.Count > 0 Then DirPrin = "OFICINA PRINCIPAL: " & _lDirPrin(0).NombreDir2
                    Dim _lDirSuc = leDir.Where(Function(it) it.Principal = 0).ToList
                    If _lDirSuc.Count > 0 Then DirSuc = "SUC. PACASMAYO: " & _lDirSuc(0).NombreDir2
                End If
                'Parámetros de la cabecera de la factura
                Dim parametros As New List(Of ReportParameter)
                'parametros.Add(New ReportParameter("TipoDocumento", oeDocumentoVenta.NombreDocumento, False))
                parametros.Add(New ReportParameter("Serie", .Serie, False))
                parametros.Add(New ReportParameter("Numero", .Numero, False))
                parametros.Add(New ReportParameter("FechaEmision", .FechaEmision, False))
                parametros.Add(New ReportParameter("RUC", .Ruc, False))
                parametros.Add(New ReportParameter("Cliente", .NombreProveedor, False))
                Dim vardir As String = ""
                If .Direccion.Length > 70 Then
                    vardir = .Direccion.Substring(0, 70)
                Else
                    vardir = .Direccion
                End If
                parametros.Add(New ReportParameter("Direccion", vardir, False))
                'Parámetros de pie de factura
                parametros.Add(New ReportParameter("ImporteDetraer", .ImporteDetraer, False))
                parametros.Add(New ReportParameter("Detraccion", .Venta.Detraccion, False))
                parametros.Add(New ReportParameter("NetoPagar", .NetoPagar, False))
                parametros.Add(New ReportParameter("ValorVenta", .SubTotal, False))
                parametros.Add(New ReportParameter("Igv", .IGV, False))
                parametros.Add(New ReportParameter("PrecioVenta", .Total, False))
                parametros.Add(New ReportParameter("MontoLetra", " " & Conversiones.NumerosALetras.Ejecutar(Math.Round(.Total, 2), True, True, oeMoneda.Nombre), False))
                parametros.Add(New ReportParameter("TipoMoneda", oeMoneda.Abreviatura, False))
                parametros.Add(New ReportParameter("porcIgv", igvcad, False))
                'parametros.Add(New ReportParameter("DirPrin", DirPrin, False))
                'parametros.Add(New ReportParameter("DirSuc", DirSuc, False))
                parametros.Add(New ReportParameter("DirPrin", "OFICINA PRINCIPAL: DIRECCION A", False))
                parametros.Add(New ReportParameter("DirSuc", "SUCURSA: DIRECCION B", False))
                'Proceso de generación de la factura
                Me.rptFacturaVenta.LocalReport.DataSources.Clear()
                Me.rptFacturaVenta.LocalReport.DataSources.Add(oReport)
                Me.rptFacturaVenta.LocalReport.DataSources.Add(oReport1)
                Me.rptFacturaVenta.LocalReport.SetParameters(parametros)
                Me.rptFacturaVenta.LocalReport.Refresh()
                Me.rptFacturaVenta.RefreshReport()
                CargarAnexo(.NombreProveedor, .Serie & "-" & .Numero, leDetalleDoc)
                ' Me.Refresh()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub CargarDocumento2(ByVal oeDocumentoVenta As e_MovimientoDocumento, _
                                ByVal leDetalleDoc As List(Of e_DetalleDocumento), _
                                ByVal IndEmitir As Boolean, _
                                ByVal Omitir As Boolean, _
                                ByVal Cta As Boolean)
        Try
            Dim dtFactura As DataTable = CrearDTFactura()
            Dim dtDetalle As DataTable = CrearDTDetalleFactura()
            'Cuerpo de la factura
            Dim rwFactura As Data.DataRow
            rwFactura = dtFactura.NewRow
            With oeDocumentoVenta
                'Carga los detalles de la factura
                dtFactura.Rows.Add(rwFactura)
                'leDetalleDoc = IIf(IndEmitir , 
                If leDetalleDoc.Count > 0 Then
                    For Each oeDetalle As e_DetalleDocumento In leDetalleDoc
                        Dim rwDetalle As Data.DataRow
                        rwDetalle = dtDetalle.NewRow
                        rwDetalle("Cantidad") = IIf(Omitir, 0, oeDetalle.Cantidad)
                        rwDetalle("Unidad") = IIf(Omitir, "", oeDetalle.UnidadMedida)
                        rwDetalle("Descripcion") = IIf(Cta, .Venta.Glosa, oeDetalle.NombreMaterialServicio)
                        rwDetalle("Cv") = ""
                        rwDetalle("FRUnit") = 0
                        rwDetalle("FRTotal") = 0
                        rwDetalle("ValorUnit") = oeDetalle.Precio
                        rwDetalle("ValorTotal") = oeDetalle.Subtotal
                        dtDetalle.Rows.Add(rwDetalle)
                    Next
                End If
                If Not Cta Then
                    Dim rwDetalle2 As Data.DataRow
                    rwDetalle2 = dtDetalle.NewRow
                    rwDetalle2("Cantidad") = 0
                    rwDetalle2("Unidad") = ""
                    rwDetalle2("Descripcion") = Environment.NewLine & .Venta.Glosa
                    rwDetalle2("Cv") = ""
                    rwDetalle2("FRUnit") = -1
                    rwDetalle2("FRTotal") = -1
                    rwDetalle2("ValorUnit") = 0
                    rwDetalle2("ValorTotal") = 0
                    dtDetalle.Rows.Add(rwDetalle2)
                End If
                'Obtiene Datos de Moneda
                Dim oeMoneda As New e_Moneda, olMoneda As New l_Moneda
                oeMoneda.Activo = True : oeMoneda.Id = oeDocumentoVenta.IdMoneda
                oeMoneda = olMoneda.Obtener(oeMoneda)
                'Procesa los datos de la factura
                Me.rptFacturaVenta.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                Me.rptFacturaVenta.Visible = True
                Dim oReport As New ReportDataSource("dsFacturaVenta_FacturaVenta", dtFactura)
                Dim oReport1 As New ReportDataSource("dsFacturaVenta_DetalleFactura", dtDetalle)
                Dim oeDir As New e_Direccion_EmpresaPersona, olDir As New l_Direccion_EmpresaPersona, leDir As New List(Of e_Direccion_EmpresaPersona)
                Dim DirPrin As String = "", DirSuc As String = ""
                With oeDir
                    .TipoOperacion = "A"
                    .TipoPersonaEmpresa = 2
                    .IdPersonaEmpresa = gs_IdEmpresaSistema.Trim
                    .Principal = -1
                End With
                leDir = olDir.Listar(oeDir)
                If leDir.Count > 0 Then
                    Dim _lDirPrin = leDir.Where(Function(it) it.Principal = 1).ToList
                    If _lDirPrin.Count > 0 Then DirPrin = "OFICINA PRINCIPAL: " & _lDirPrin(0).Nombre
                    Dim _lDirSuc = leDir.Where(Function(it) it.Principal = 0).ToList
                    If _lDirSuc.Count > 0 Then DirSuc = "SUC. PACASMAYO: " & _lDirSuc(0).Nombre
                End If
                'Parámetros de la cabecera de la factura
                Dim parametros As New List(Of ReportParameter)
                'parametros.Add(New ReportParameter("TipoDocumento", oeDocumentoVenta.NombreDocumento, False))
                parametros.Add(New ReportParameter("Serie", .Serie, False))
                parametros.Add(New ReportParameter("Numero", .Numero, False))
                parametros.Add(New ReportParameter("FechaEmision", .FechaEmision, False))
                parametros.Add(New ReportParameter("RUC", .Ruc, False))
                parametros.Add(New ReportParameter("Cliente", .NombreProveedor, False))
                Dim vardir As String = ""
                If .Direccion.Length > 70 Then
                    vardir = .Direccion.Substring(0, 70)
                Else
                    vardir = .Direccion
                End If
                parametros.Add(New ReportParameter("Direccion", vardir, False))
                'Parámetros de pie de factura
                parametros.Add(New ReportParameter("ImporteDetraer", .ImporteDetraer, False))
                parametros.Add(New ReportParameter("Detraccion", .Venta.Detraccion, False))
                parametros.Add(New ReportParameter("NetoPagar", .NetoPagar, False))
                parametros.Add(New ReportParameter("ValorVenta", .SubTotal, False))
                parametros.Add(New ReportParameter("Igv", .IGV, False))
                parametros.Add(New ReportParameter("PrecioVenta", .Total, False))
                parametros.Add(New ReportParameter("MontoLetra", " " & Conversiones.NumerosALetras.Ejecutar(.Total, True, True, oeMoneda.Nombre), False))
                parametros.Add(New ReportParameter("TipoMoneda", oeMoneda.Abreviatura, False))
                parametros.Add(New ReportParameter("porcIgv", "", False))
                parametros.Add(New ReportParameter("DirPrin", DirPrin, False))
                parametros.Add(New ReportParameter("DirSuc", DirSuc, False))
                'Proceso de generación de la factura
                Me.rptFacturaVenta.LocalReport.DataSources.Clear()
                Me.rptFacturaVenta.LocalReport.DataSources.Add(oReport)
                Me.rptFacturaVenta.LocalReport.DataSources.Add(oReport1)
                Me.rptFacturaVenta.LocalReport.SetParameters(parametros)
                Me.rptFacturaVenta.LocalReport.Refresh()
                Me.rptFacturaVenta.RefreshReport()
                ficFactura.Tabs(1).Visible = False
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarAnexo(ByVal Nombre_Prov As String, ByVal NroDoc As String, ByVal leDDOD As List(Of e_DetalleDoc_OperacionDet))
        Try
            griComplemento.Text = Nombre_Prov
            For Each oeDDOD As e_DetalleDoc_OperacionDet In leDDOD
                Dim var() As String
                var = Split(oeDDOD.Glosa, ",")
                oeDDOD.Glosa = ""
                If var.Length = 3 Then
                    oeDDOD.Glosa = "FACT: " & NroDoc & ", " & var(1) & ", " & var(2)
                Else
                    If var.Length = 4 Then
                        oeDDOD.Glosa = var(1) & ", " & var(2) & ", " & var(3)
                    Else
                        oeDDOD.Glosa = var(0)
                    End If
                End If
            Next
            griComplemento.DataSource = leDDOD
            With griComplemento
                OcultarColumna(griComplemento, True, "Id", "IndGravado", "IdOperacionDetalle", "IdOperacion", "IdComisionista", "IdMaterialServicio", "IdUnidadMedida", _
                               "IdMaterial", "IdUnidadCarga", "CantOpe", "IncluyeIgv", "FleteUnitario", "Flete", "PesoToneladas", "Saldo", "ValorUnit2", "Igv", "CantGuia", _
                               "NroViaje", "UnidadMedida", "CantOpe", "CV", "FactorRefUni", "FactorRefTotal", "IdOrigen", "IdDestino")
                ExcluirColumna(griComplemento, "Id", "IndGravado", "IdOperacionDetalle", "IdOperacionDetalle", "IdOperacion", "IdComisionista", "IdMaterialServicio", _
                               "IdUnidadMedida", "IdMaterial", "IdUnidadCarga", "IdOrigen", "IdDestino")
                .DisplayLayout.Bands(0).Columns("FechaViaje").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Tracto").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Carreta").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Origen").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Destino").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("Glosa").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("MaterialServicio").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("Cantidad").Header.VisiblePosition = 8
                .DisplayLayout.Bands(0).Columns("PrecioUnitario").Header.VisiblePosition = 9
                .DisplayLayout.Bands(0).Columns("Valor").Header.VisiblePosition = 10
                .DisplayLayout.Bands(0).Columns("SubTotal").Header.VisiblePosition = 11
                .DisplayLayout.Bands(0).Columns("FechaViaje").Header.Caption = "FECHA"
                .DisplayLayout.Bands(0).Columns("Tracto").Header.Caption = "TRACTO"
                .DisplayLayout.Bands(0).Columns("Carreta").Header.Caption = "CARRETA"
                .DisplayLayout.Bands(0).Columns("Origen").Header.Caption = "ORIGEN"
                .DisplayLayout.Bands(0).Columns("Destino").Header.Caption = "DESTINO"
                .DisplayLayout.Bands(0).Columns("MaterialServicio").Header.Caption = "TIPO"
                .DisplayLayout.Bands(0).Columns("Valor").Header.Caption = "VV"
                .DisplayLayout.Bands(0).Columns("PrecioUnitario").Header.Caption = "P/U"
                .DisplayLayout.Bands(0).Columns("SubTotal").Header.Caption = "TOTAL"
                .DisplayLayout.Bands(0).Columns("Cantidad").Header.Caption = "TN"
                .DisplayLayout.Bands(0).Columns("Glosa").Header.Caption = "LISTA"
                .DisplayLayout.Bands(0).Columns("IdOrigen").Width = 100
                .DisplayLayout.Bands(0).Columns("IdDestino").Width = 100
                .DisplayLayout.Bands(0).Columns("Tracto").Width = 55
                .DisplayLayout.Bands(0).Columns("Carreta").Width = 55
                .DisplayLayout.Bands(0).Columns("Valor").Width = 60
                .DisplayLayout.Bands(0).Columns("PrecioUnitario").Width = 60
                .DisplayLayout.Bands(0).Columns("Glosa").Width = 200
                .DisplayLayout.Bands(0).Columns("Cantidad").Width = 70
                .DisplayLayout.Bands(0).Columns("PrecioUnitario").Width = 70
                .DisplayLayout.Bands(0).Columns("SubTotal").Width = 70
                .DisplayLayout.Bands(0).Columns("Valor").Width = 70
                .DisplayLayout.Bands(0).Columns("FechaViaje").Style = ColumnStyle.Date
                .DisplayLayout.Bands(0).Columns("Glosa").CellAppearance.TextHAlign = HAlign.Center
                .DisplayLayout.Bands(0).Columns("Glosa").CellAppearance.TextTrimming = TextTrimming.EllipsisWord
                .DisplayLayout.Bands(0).Columns("Glosa").CellMultiLine = DefaultableBoolean.True
                FormatoColumna(griComplemento, "#,##0.0000", ColumnStyle.Double, HAlign.Right, "Cantidad", "PrecioUnitario", "Valor", "SubTotal")
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
                CalcularTotales(griComplemento, "Cantidad", "Valor", "SubTotal")
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub tsmiImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiImprimir.Click
        Try
            Me.VistaPreviaPrint.Document = PrintDocument()
            Me.VistaPreviaPrint.ShowDialog(Me)
            Me.VistaPreviaPrint.Document = Nothing
        Catch ex As Exception
            MensajeIsl.Problema(ex.Message, True)
        End Try
    End Sub

    Public Function PrintDocument() As System.Drawing.Printing.PrintDocument
        PrintDocument = Me.GrillaPrint
    End Function

    Private Sub tsmiExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiExportar.Click
        If griComplemento.Rows.Count > 0 Then
            Exportar_Excel(griComplemento)
        Else
            MensajeIsl.Problema("No hay registros para exportar")
        End If
    End Sub

End Class