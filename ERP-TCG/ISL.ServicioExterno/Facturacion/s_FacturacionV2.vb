Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Xml
Imports System.IO
Imports Ionic.Zip
Imports System.Security.Cryptography
Imports System.Security.Cryptography.X509Certificates
Imports System.Security.Cryptography.Xml
Imports System.Xml.Schema
Imports System.Data

Public Class s_FacturacionV2

    Private LineCountNumeric As String = String.Empty

    Public Function GenerarXmlFacturaElectronica(ByVal dtCab As DataTable, dtAnt As DataTable, ByVal dtDet As DataTable, ByVal rutaFE As String, ByVal usuario As String) As Boolean
        Dim nombre As String = ""
        Dim definicion As String = ""
        Dim valorCodBarras As String = ""
        Dim dtDocOri As DataTable = Nothing
        Dim cdrXML As String = ""
        Dim firma As String = ""
        Dim valorResumen As String = ""
        Dim flagME As Boolean = False
        Dim flagError As Boolean = False
        Dim boolRetorno As Boolean = False
        Dim tipoid As String = ""
        Dim odComprobanteElectronico As New d_ComprobanteElectronico
        Dim oeComprobanteElectronico As e_ComprobanteElectronico
        Dim oeDocumento As e_MovimientoDocumento
        'Dim facturacionObj As New LogicaNegocio.FacturacionElectronica(mCadenaConexion)
        Try
            Me.GenerarXmlFacturaElectronica2(dtCab, dtAnt, dtDet, rutaFE, nombre, valorResumen, firma, flagME, False)
            Using zip As ZipFile = New ZipFile(System.Text.UTF8Encoding.UTF8)
                zip.AddFile(rutaFE.Trim() & nombre.Trim() & ".XML", "")
                zip.Save(rutaFE.Trim() & nombre.Trim() & ".zip")
            End Using
            'definicion = Me.EnviarXML(rutaFE, nombre, cdrXML)
        Catch ex As Exception
            flagError = True
            Throw ex
        Finally
            If cdrXML.Trim <> "" Then
                boolRetorno = True
                valorCodBarras = PreparaCodigoBarras(dtCab, flagME, valorResumen, firma, dtCab.Rows(0).Item("factorc"))
                oeComprobanteElectronico = New e_ComprobanteElectronico
                oeComprobanteElectronico.TipoOperacion = ""
                oeComprobanteElectronico.IdReferencia = dtCab.Rows(0).Item("idcomp")
                oeComprobanteElectronico.TipoReferencia = 1
                oeComprobanteElectronico.xmlbase64 = definicion
                oeComprobanteElectronico.valorcodbarras = valorCodBarras
                oeComprobanteElectronico.cdrxml = cdrXML
                oeComprobanteElectronico.nombrexml = nombre
                oeComprobanteElectronico.UsuarioCrea = usuario
                oeComprobanteElectronico.ValorResumen = valorResumen
                oeDocumento = New e_MovimientoDocumento
                oeDocumento.TipoOperacion = "AFE"
                oeDocumento.Id = dtCab.Rows(0).Item("idcomp")
                oeDocumento.IdUsuarioCrea = usuario
                If flagError Then
                    oeDocumento.IndServicioMaterial = "R"
                Else
                    oeDocumento.IndServicioMaterial = "A"
                End If
                odComprobanteElectronico.AdicionarComprobanteElectronico(oeComprobanteElectronico, oeDocumento)
                'facturacionObj.AdicionarComprobanteElectronico(dtCab.Rows(0).Item("idcomp"), definicion, nombre, valorCodBarras, cdrXML, dtCab.Rows(0).Item("seriecomp").ToString.Trim & dtCab.Rows(0).Item("corrcomp").ToString.Trim, flagError, usuario)
            End If
            If File.Exists(rutaFE.Trim() & nombre.Trim() & ".xml") Then
                File.Delete(rutaFE.Trim() & nombre.Trim() & ".xml")
            End If
            If File.Exists(rutaFE.Trim() & "R-" & nombre.Trim() & ".xml") Then
                File.Delete(rutaFE.Trim() & "R-" & nombre.Trim() & ".xml")
            End If
        End Try
        'Me.GenerarPDF(dtCab, dtDet, rutaFE, nombre, valorCodBarras, flagME)
        'Me.EnviarCorreo("", "", "Comprobante de Pago", "Estimado cliente se adjunta su comprobante de pago", "", rutaFE & nombre & ".pdf")
        Return boolRetorno
    End Function

    Public Function GenerarXmlFacturaElectronica2(ByVal dtCab As DataTable, dtAnt As DataTable, ByVal dtDet As DataTable, ByVal rutaFE As String, ByRef nombre As String, ByRef valorResumen As String, ByRef firma As String, ByRef flagME As Boolean, ByVal esLote As Boolean) As String
        'Create XmlWriterSettings.
        Dim settings As XmlWriterSettings = New XmlWriterSettings()
        Dim prefixCac As String
        Dim prefixCbc As String
        Dim prefixDs As String
        Dim prefixExt As String
        'Dim prefixSac As String
        Dim cadCac As String = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"
        Dim cadCbc As String = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"
        Dim cadCcts As String = "urn:un:unece:uncefact:documentation:2"
        Dim cadDs As String = "http://www.w3.org/2000/09/xmldsig#"
        Dim cadExt As String = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2"
        Dim cadQdt As String = "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2"
        'Dim cadSac As String = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1"
        Dim cadUdt As String = "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2"
        Dim cadXsi As String = "http://www.w3.org/2001/XMLSchema-instance"
        'Dim facturacionADObj As New LogicaNegocio.FacturacionElectronicaAD(mCadenaConexion)
        Dim moneda As String
        Dim TipDoc As String
        Dim flagNC As Boolean
        Dim flagND As Boolean
        Dim definicion As String = ""
        Dim valorCodBarras As String = ""
        Dim dtDocOri As DataTable = Nothing
        Dim cdrXML As String = ""
        Dim flagError As Boolean = False
        Dim strRetorno As String = ""
        Dim tipoid As String = ""
        Dim dCatalago As New d_CatalagoCodigoSunat
        Dim oeCatalago As e_CatalagoCodigoSunat
        Try
            If dtCab.Rows(0).Item("cod_moneda").ToString.Trim <> "SOL" Then
                flagME = True
            End If
            oeCatalago = New e_CatalagoCodigoSunat
            oeCatalago.CodigoTabla = "002" : oeCatalago.CodigoElemento = dtCab.Rows(0).Item("cod_moneda").ToString().Trim()
            moneda = dCatalago.Obtener(oeCatalago).CodigoSunat
            oeCatalago = New e_CatalagoCodigoSunat
            oeCatalago.CodigoTabla = "001" : oeCatalago.CodigoElemento = dtCab.Rows(0).Item("cod_comprob_cat_1").ToString().Trim()
            TipDoc = dCatalago.Obtener(oeCatalago).CodigoAlterno
            flagNC = IIf(dtCab.Rows(0).Item("cod_comprob_cat_1").ToString().Trim = "07", True, False)
            flagND = IIf(dtCab.Rows(0).Item("cod_comprob_cat_1").ToString().Trim = "08", True, False)
            If dtCab.Rows(0).Item("doc_receptor").ToString.Trim = "" Then
                Throw New Exception("No existe documento del cliente")
            End If
            oeCatalago = New e_CatalagoCodigoSunat
            oeCatalago.CodigoTabla = "006" : oeCatalago.CodigoElemento = dtCab.Rows(0).Item("tipodoc_receptor").ToString().Trim()
            tipoid = dCatalago.Obtener(oeCatalago).CodigoSunat
            'tipoid = facturacionADObj.ObtenerCodigoSunatPorCodigoSistema("006", dtCab.Rows(0).Item("tipoid"))
            If tipoid.Trim = "" Then
                Throw New Exception("No existe tipo del documento " & dtCab.Rows(0).Item("tipodoc_receptor").ToString().Trim & " del cliente")
            End If
            If TipDoc = "07" Or TipDoc = "08" Then
                Dim oeDocumento As New e_MovimientoDocumento
                Dim dDocumento As New d_MovimientoDocumento
                oeDocumento.Id = dtCab.Rows(0).Item("id").ToString().Trim : oeDocumento.TipoOperacion = 3
                dtDocOri = dDocumento.ListarFacturacionElectronica(oeDocumento).Tables(0)
                If dtDocOri.Rows.Count = 0 Then
                    Throw New Exception("No existe comprobante origen para el documento :" & CType(dtCab.Rows(0).Item("serie_doc2"), String) & "-" & CType(dtCab.Rows(0).Item("nro_doc2"), String))
                End If
            End If
            oeCatalago = New e_CatalagoCodigoSunat
            oeCatalago.CodigoTabla = "017" : oeCatalago.CodigoElemento = "001"
            nombre = dCatalago.Obtener(oeCatalago).Descripcion & "-" & TipDoc.Trim() & "-" & dtCab.Rows(0).Item("serie_doc2").ToString().Trim() & "-" & dtCab.Rows(0).Item("nro_doc2").ToString().Trim()
            'nombre = facturacionADObj.ObtenerDescripcionPorCodigoSistema("017", "001") & "-" & TipDoc.Trim() & "-" & dtCab.Rows(0).Item("seriecomp").ToString().Trim() & "-" & dtCab.Rows(0).Item("corrcomp").ToString().Trim()
            LineCountNumeric = dtDet.Rows.Count
            settings.Indent = True
            ' Create XmlWriter.
            settings.Encoding = System.Text.UTF8Encoding.UTF8
            Using writer As XmlWriter = XmlWriter.Create(rutaFE.Trim() & nombre.Trim() & ".XML", settings)
                prefixCac = writer.LookupPrefix(cadCac)
                prefixExt = writer.LookupPrefix(cadExt)
                'prefixSac = writer.LookupPrefix(cadSac)
                prefixCbc = writer.LookupPrefix(cadCbc)
                prefixDs = writer.LookupPrefix(cadDs)
                ' Begin writing.
                writer.WriteStartDocument()
                '<Invoice xmlns="urn:oasis:names:specification:ubl:schema:xsd:Invoice-2" xmlns:cac="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2" xmlns:cbc="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2" xmlns:ccts="urn:un:unece:uncefact:documentation:2" xmlns:ds="http://www.w3.org/2000/09/xmldsig#" xmlns:ext="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2" xmlns:qdt="urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2" xmlns:sac="urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1" xmlns:udt="urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
                If flagNC Then
                    writer.WriteStartElement("CreditNote", "urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2")
                ElseIf flagND Then
                    writer.WriteStartElement("DebitNote", "urn:oasis:names:specification:ubl:schema:xsd:DebitNote-2") ' Root.
                Else
                    writer.WriteStartElement("Invoice", "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2") ' Root.
                End If
                'writer.WriteStartElement("Invoice") ' Root.
                writer.WriteAttributeString("xmlns", "cac", Nothing, cadCac)
                writer.WriteAttributeString("xmlns", "cbc", Nothing, cadCbc)
                writer.WriteAttributeString("xmlns", "ccts", Nothing, cadCcts)
                writer.WriteAttributeString("xmlns", "ds", Nothing, cadDs)
                writer.WriteAttributeString("xmlns", "ext", Nothing, cadExt)
                writer.WriteAttributeString("xmlns", "qdt", Nothing, cadQdt)
                'writer.WriteAttributeString("xmlns", "sac", Nothing, cadSac)
                writer.WriteAttributeString("xmlns", "udt", Nothing, cadUdt)
                writer.WriteAttributeString("xmlns", "xsi", Nothing, cadXsi)
                'Me.ObtenerExtensiones(writer, prefixExt, prefixSac, prefixCbc, prefixDs, cadExt, cadSac, cadCbc, cadDs, dtCab, dtDet, moneda.Trim(), flagME, False, dtCab.Rows(0).Item("factorc"))
                Me.ObtenerExtensiones(writer, prefixExt, prefixCbc, prefixDs, cadExt, cadCbc, cadDs, dtCab, dtDet, moneda.Trim(), flagME, False, dtCab.Rows(0).Item("factorc"))
                Me.ObtenerDatosCabecera(writer, prefixCbc, prefixCac, cadCbc, cadCac, dtCab, dtAnt, TipDoc, moneda.Trim(), flagNC, flagME, flagND, False, Nothing, dtCab.Rows(0).Item("factorc"), dtDocOri, "", "")
                For Each drFila As DataRow In dtDet.Rows
                    Me.ObtenerDatosDetalle(writer, prefixCbc, prefixCac, cadCbc, cadCac, drFila, moneda.Trim(), flagNC, flagME, flagND, dtCab.Rows(0).Item("factorc"), dtCab.Rows(0).Item("estransgratuita"))
                Next
                '</Invoice>
                writer.WriteEndElement()
                writer.WriteEndDocument()
            End Using
            Me.AgregarFirma(rutaFE, nombre, valorResumen, firma, False, TipDoc)
            'Me.ValidarXML(rutaFE, nombre, dtCab.Rows(0).Item("cod_comprob_cat_1"))
            If esLote Then
                Dim xmlDoc As XmlDocument = New XmlDocument()
                xmlDoc.PreserveWhitespace = True
                xmlDoc.Load(rutaFE & nombre & ".XML")
                strRetorno = xmlDoc.OuterXml.ToString.Trim
            End If
        Catch ex As Exception
            flagError = True
            Throw ex
        End Try
        Return strRetorno
    End Function

    Private Function EnviarXML(ByVal rutaFE As String, ByVal Nombre As String, ByRef cdrXML As String) As String
        Dim fsRpta As New FileStream(rutaFE & "R-" & Nombre & ".zip", FileMode.Create)
        System.Net.ServicePointManager.UseNagleAlgorithm = True
        System.Net.ServicePointManager.Expect100Continue = False
        System.Net.ServicePointManager.CheckCertificateRevocationList = True
        Dim clienteRemotoObj As New sFacturacion.billServiceClient
        'Dim _behavior = New clsPasswordDigestBehavior("20480099720" + "CPESUNAT", "materiaGRIF01X")
        Dim _behavior = New clsPasswordDigestBehavior("20480099720" + "ERPTCGSO", "Oksimcha44")
        clienteRemotoObj.Endpoint.EndpointBehaviors.Add(_behavior)
        Dim datos As New sFacturacion.sendBillResponse
        Dim envio As New sFacturacion.sendBillRequest
        'Dim TablaFEADObj As New FacturacionElectronicaAD(mCadenaConexion)
        Dim dCatalago As New d_CatalagoCodigoSunat
        Dim oeCatalago As e_CatalagoCodigoSunat
        Dim xmlDoc As New XmlDocument()
        Dim msjError As String
        Dim definicion As String = ""
        Dim cadError As String
        Try
            envio.contentFile = My.Computer.FileSystem.ReadAllBytes(rutaFE & Nombre & ".zip")
            envio.fileName = Nombre & ".zip"
            clienteRemotoObj.Open()
            'datos.applicationResponse = clienteRemotoObj.sendBill(envio.fileName, envio.contentFile)
            datos.applicationResponse = clienteRemotoObj.sendBill(envio.fileName, envio.contentFile, "")
            fsRpta.Write(datos.applicationResponse, 0, datos.applicationResponse.Length)
            fsRpta.Close()
            Me.Extraer(rutaFE, Nombre)
            xmlDoc.PreserveWhitespace = False
            xmlDoc.Load(rutaFE & "R-" & Nombre & ".XML")
            cdrXML = xmlDoc.OuterXml.ToString.Trim
            msjError = VerificarSiExisteError(xmlDoc.DocumentElement)
            If msjError <> "" Then
                Throw New Exception("Comprobante rechazado por la SUNAT: " & msjError)
            End If
            definicion = EncodeArrayBase64(envio.contentFile)
        Catch ex As System.ServiceModel.FaultException
            oeCatalago = New e_CatalagoCodigoSunat
            oeCatalago.CodigoTabla = "018" : oeCatalago.CodigoElemento = ex.Code.Name.ToString.Replace("soap-env-Server.", "").Trim
            'cadError = TablaFEADObj.ObtenerDescripcionPorCodigoSistema("018", ex.Code.Name.ToString.Replace("soap-env-Server.", "").Trim)
            cadError = dCatalago.Obtener(oeCatalago).Descripcion
            If cadError.Trim <> "" Then
                Throw New Exception("Error al enviar documento a la SUNAT: " & cadError)
            Else
                Throw New Exception("Error al enviar documento a la SUNAT: " & ex.Code.Name.ToString & "-" & ex.Message.Trim)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            If Not fsRpta Is Nothing Then
                fsRpta.Close()
            End If
        End Try
        Return definicion
    End Function

    Public Function PreparaCodigoBarras(ByVal dtCab As DataTable, ByVal flagME As Boolean, ByVal valorResumen As String, ByVal firma As String, ByVal factorC As Double) As String
        Dim dCatalago As New d_CatalagoCodigoSunat
        Dim oeCatalago As e_CatalagoCodigoSunat
        Dim codBarras As String = ""
        'Dim tablaFeObjAD As New FacturacionElectronicaAD(mCadenaConexion)
        oeCatalago = New e_CatalagoCodigoSunat
        oeCatalago.CodigoTabla = "017" : oeCatalago.CodigoElemento = "001"
        'codBarras = tablaFeObjAD.ObtenerDescripcionPorCodigoSistema("017", "001") & "|" & dtCab.Rows(0).Item("seriecomp") & "|" & dtCab.Rows(0).Item("corrcomp") & "|" _
        'codBarras = dCatalago.Obtener(oeCatalago).Descripcion & "|" & dtCab.Rows(0).Item("seriecomp") & "|" & dtCab.Rows(0).Item("corrcomp") & "|" _
        '& IIf(IIf(flagME, CType(dtCab.Rows(0).Item("igv") / factorC, Double).ToString("F2"), CType(dtCab.Rows(0).Item("igv"), Double).ToString("F2")) = 0, "", IIf(flagME, CType(dtCab.Rows(0).Item("igv") / factorC, Double).ToString("F2"), CType(dtCab.Rows(0).Item("igv"), Double).ToString("F2"))) & "|" _
        '& IIf(IIf(flagME, CType(dtCab.Rows(0).Item("importeventa"), Double).ToString("F2"), CType(dtCab.Rows(0).Item("importeventa"), Double).ToString("F2")) = 0, "", IIf(flagME, CType(dtCab.Rows(0).Item("importeventa"), Double).ToString("F2"), CType(dtCab.Rows(0).Item("importeventa"), Double).ToString("F2"))) & "|" _
        '& CType(dtCab.Rows(0).Item("feccomp"), Date).Year.ToString().PadLeft(2, "0").Trim() & "-" & CType(dtCab.Rows(0).Item("feccomp"), Date).Month.ToString().ToString().PadLeft(2, "0").Trim() & "-" & CType(dtCab.Rows(0).Item("feccomp"), Date).Day.ToString().PadLeft(2, "0").Trim() & "|" _
        '& dtCab.Rows(0).Item("tipoid").ToString.Trim & "|" & dtCab.Rows(0).Item("nroid").ToString.Trim & "|" & valorResumen & "|" & firma & "|"

        codBarras = dCatalago.Obtener(oeCatalago).Descripcion & "|" & dtCab.Rows(0).Item("seriecomp") & "|" & dtCab.Rows(0).Item("corrcomp") & "|" _
        & IIf(CType(dtCab.Rows(0).Item("igv"), Double).ToString("F2") = 0, "", CType(dtCab.Rows(0).Item("igv"), Double).ToString("F2")) & "|" _
        & IIf(CType(dtCab.Rows(0).Item("importeventa"), Double).ToString("F2") = 0, "", CType(dtCab.Rows(0).Item("importeventa"), Double).ToString("F2")) & "|" _
        & CType(dtCab.Rows(0).Item("feccomp"), Date).Year.ToString().PadLeft(2, "0").Trim() & "-" & CType(dtCab.Rows(0).Item("feccomp"), Date).Month.ToString().ToString().PadLeft(2, "0").Trim() & "-" & CType(dtCab.Rows(0).Item("feccomp"), Date).Day.ToString().PadLeft(2, "0").Trim() & "|" _
        & dtCab.Rows(0).Item("tipoid").ToString.Trim & "|" & dtCab.Rows(0).Item("nroid").ToString.Trim & "|" & valorResumen & "|" & firma & "|"

        Return codBarras
    End Function

    Private Function ObtenerExtensiones(ByVal writer As XmlWriter, ByVal prefixExt As String, ByVal prefixCbc As String, ByVal prefixDs As String, ByVal cadExt As String, ByVal cadCbc As String, ByVal cadDs As String, ByVal dtCab As DataTable, ByVal dtDet As DataTable, ByVal moneda As String, ByVal flagME As Boolean, ByVal flagBajaResumen As Boolean, ByVal factorC As Double)
        'Dim facturacionObjAD As New FacturacionElectronicaAD(mCadenaConexion)
        Dim MontoGravado As Double = 0
        Dim MontoInafecto As Double = 0
        Dim MontoExonerado As Double = 0
        Dim MontoBonificacion As Double = 0
        Dim MontoRetencion As Double = 0
        Dim MontoDetraccion As Double = 0
        'Dim MontoLetras As String
        Dim CuentaDetraccion As String = String.Empty
        'Dim numeroALetras As New s_Funciones
        'Dim dCatalago As New d_CatalagoCodigoSunat
        'Dim oeCatalago As e_CatalagoCodigoSunat
        'Dim porPercepcion As Double
        Dim percepcion As Double = 0
        '<ext:UBLExtensions>     
        writer.WriteStartElement(prefixExt, "UBLExtensions", cadExt)

        '<ext:UBLExtension>
        writer.WriteStartElement(prefixExt, "UBLExtension", cadExt)
        '<ext:ExtensionContent>
        writer.WriteStartElement(prefixExt, "ExtensionContent", cadExt)

        'Aqui va la firmar electronica       
        '</ext:ExtensionContent>
        writer.WriteEndElement()
        '</ext:UBLExtension>
        writer.WriteEndElement()
        '</ext:UBLExtensions>
        writer.WriteEndElement()
        Return writer
    End Function

    Private Function ObtenerDatosCabecera(ByVal writer As XmlWriter, ByVal prefixCbc As String, ByVal prefixCac As String, ByVal cadCbc As String, ByVal cadCac As String, ByVal dtCab As DataTable, dtAnt As DataTable, ByVal TipDoc As String, ByVal CodMon As String, ByVal flagNC As Boolean, ByVal flagME As Boolean, ByVal flagND As Boolean, ByVal flagBaja As Boolean, ByVal fechaGeneracion As DateTime, ByVal factorC As Double, ByVal dtDocOri As DataTable, ByVal prefijo As String, ByVal correlativo As String) As XmlWriter
        Dim dCatalago As New d_CatalagoCodigoSunat
        Dim oeCatalago As e_CatalagoCodigoSunat
        Dim numeroALetras As New s_Funciones
        Dim MontoLetras As String
        '<cbc:UBLVersionID>2.0</cbc:UBLVersionID>
        writer.WriteElementString("UBLVersionID", cadCbc, "2.1")
        '<cbc:CustomizationID>1.0</cbc:CustomizationID>
        writer.WriteElementString("CustomizationID", cadCbc, "2.0")

        If flagBaja Then
            '<cbc:ID>F001-4355</cbc:ID>
            writer.WriteElementString("ID", cadCbc, prefijo.Trim & "-" & CType(fechaGeneracion, Date).Year.ToString().PadLeft(2, "0").Trim() & CType(fechaGeneracion, Date).Month.ToString().PadLeft(2, "0").Trim() & CType(fechaGeneracion, Date).Day.ToString().PadLeft(2, "0").Trim() & "-" & correlativo.Trim)
            '<cbc:ReferenceDate>2012-04-15</cbc:ReferenceDate>
            writer.WriteElementString("ReferenceDate", cadCbc, CType(dtCab.Rows(0).Item("feccomp"), Date).Year.ToString().PadLeft(2, "0").Trim() & "-" & CType(dtCab.Rows(0).Item("feccomp"), Date).Month.ToString().PadLeft(2, "0").Trim() & "-" & CType(dtCab.Rows(0).Item("feccomp"), Date).Day.ToString().PadLeft(2, "0").Trim())
            '<cbc:IssueDate>2012-03-14</cbc:IssueDate>
            writer.WriteElementString("IssueDate", cadCbc, CType(fechaGeneracion, Date).Year.ToString().PadLeft(2, "0").Trim() & "-" & CType(fechaGeneracion, Date).Month.ToString().PadLeft(2, "0").Trim() & "-" & CType(fechaGeneracion, Date).Day.ToString().PadLeft(2, "0").Trim())
        Else

            If Not flagNC And Not flagND Then
                writer.WriteStartElement(prefixCbc, "ProfileID", cadCbc)
                writer.WriteAttributeString("schemeName", "SUNAT:Identificador de Tipo de Operación")
                writer.WriteAttributeString("schemeAgencyName", "PE:SUNAT")
                writer.WriteAttributeString("schemeURI", "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo17")
                writer.WriteValue("0101")
                writer.WriteEndElement()
            End If

            '<cbc:ID>F001-4355</cbc:ID>
            writer.WriteElementString("ID", cadCbc, dtCab.Rows(0).Item("serie_doc2").ToString().Trim() & "-" & dtCab.Rows(0).Item("nro_doc2").ToString().Trim())
            '<cbc:IssueDate>2012-03-14</cbc:IssueDate>
            writer.WriteElementString("IssueDate", cadCbc, CType(dtCab.Rows(0).Item("feccomp"), Date).Year.ToString().PadLeft(2, "0").Trim() & "-" & CType(dtCab.Rows(0).Item("feccomp"), Date).Month.ToString().ToString().PadLeft(2, "0").Trim() & "-" & CType(dtCab.Rows(0).Item("feccomp"), Date).Day.ToString().PadLeft(2, "0").Trim())
            writer.WriteElementString("IssueTime", cadCbc, "12:00:00")

            If flagNC Or flagND Then

                writer.WriteStartElement(prefixCbc, "Note", cadCbc)
                writer.WriteAttributeString("languageLocaleID", "3000")
                writer.WriteValue("0501002017051400452")
                writer.WriteEndElement()

                '<cbc:DocumentCurrencyCode>PEN</cbc:DocumentCurrencyCode>
                writer.WriteElementString("DocumentCurrencyCode", cadCbc, CodMon)

                '<cac:DiscrepancyResponse>
                writer.WriteStartElement(prefixCac, "DiscrepancyResponse", cadCac)
                '<cbc:ReferenceID>F001-4355</cbc:ReferenceID>
                writer.WriteElementString("ReferenceID", cadCbc, dtDocOri.Rows(0).Item("seriecomp").ToString().Trim() & "-" & dtDocOri.Rows(0).Item("corrcomp").ToString().Trim())
                '<cbc:ResponseCode>07</cbc:ResponseCode>
                If flagNC Then
                    oeCatalago = New e_CatalagoCodigoSunat
                    oeCatalago.CodigoTabla = "009" : oeCatalago.CodigoElemento = "006"
                    'writer.WriteElementString("ResponseCode", cadCbc, facturacionADObj.ObtenerCodigoSunatPorCodigoSistema("009", "006"))
                    writer.WriteElementString("ResponseCode", cadCbc, dCatalago.Obtener(oeCatalago).CodigoSunat)
                    '<cbc:Description> Unidades defectuosas, no leen CD que contengan archivos MP3</cbc:Description>
                    oeCatalago = New e_CatalagoCodigoSunat
                    oeCatalago.CodigoTabla = "009" : oeCatalago.CodigoElemento = "006"
                    'writer.WriteElementString("Description", cadCbc, facturacionADObj.ObtenerDescripcionPorCodigoSistema("009", "006"))
                    writer.WriteElementString("Description", cadCbc, dCatalago.Obtener(oeCatalago).Descripcion)
                Else
                    oeCatalago = New e_CatalagoCodigoSunat
                    oeCatalago.CodigoTabla = "010" : oeCatalago.CodigoElemento = "002"
                    'writer.WriteElementString("ResponseCode", cadCbc, facturacionADObj.ObtenerCodigoSunatPorCodigoSistema("010", "002"))
                    writer.WriteElementString("ResponseCode", cadCbc, dCatalago.Obtener(oeCatalago).CodigoSunat)
                    '<cbc:Description> Unidades defectuosas, no leen CD que contengan archivos MP3</cbc:Description>
                    oeCatalago = New e_CatalagoCodigoSunat
                    oeCatalago.CodigoTabla = "010" : oeCatalago.CodigoElemento = "002"
                    'writer.WriteElementString("Description", cadCbc, facturacionADObj.ObtenerDescripcionPorCodigoSistema("010", "002"))
                    writer.WriteElementString("Description", cadCbc, dCatalago.Obtener(oeCatalago).Descripcion)
                End If
                '</cac:DiscrepancyResponse>
                writer.WriteEndElement()

                '<cac:BillingReference>
                writer.WriteStartElement(prefixCac, "BillingReference", cadCac)
                '<cac:InvoiceDocumentReference>
                writer.WriteStartElement(prefixCac, "InvoiceDocumentReference", cadCac)
                '<cbc:ID>F001-4355</cbc:ID>
                writer.WriteElementString("ID", cadCbc, dtDocOri.Rows(0).Item("seriecomp").ToString().Trim() & "-" & dtDocOri.Rows(0).Item("corrcomp").ToString().Trim())
                '<cbc:DocumentTypeCode>01</cbc:DocumentTypeCode>
                'dtTipDoc = ObjTipdoc.ObtenerTipoDocumentoPorCodigo(dtDocOri.Rows(0).Item("tipcomp").ToString())
                writer.WriteElementString("DocumentTypeCode", cadCbc, dtDocOri.Rows(0).Item("tipcomp").ToString())
                '</cac:InvoiceDocumentReference>
                writer.WriteEndElement()
                '</cac:BillingReference>
                writer.WriteEndElement()
            Else

                '<cbc:InvoiceTypeCode>01</cbc:InvoiceTypeCode>
                writer.WriteStartElement(prefixCbc, "InvoiceTypeCode", cadCbc)
                writer.WriteAttributeString("listAgencyName", "PE:SUNAT")
                writer.WriteAttributeString("listName", "SUNAT:Identificador de Tipo de Documento")
                writer.WriteAttributeString("listURI", "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo01")
                writer.WriteValue(TipDoc.Trim())
                writer.WriteEndElement()

                writer.WriteStartElement(prefixCbc, "Note", cadCbc)
                MontoLetras = numeroALetras.gfc_Convertir(CType(dtCab.Rows(0).Item("precio_venta"), Double))
                oeCatalago = New e_CatalagoCodigoSunat
                oeCatalago.CodigoTabla = "015" : oeCatalago.CodigoElemento = "001"
                writer.WriteAttributeString("languageLocaleID", dCatalago.Obtener(oeCatalago).CodigoSunat)
                writer.WriteValue(MontoLetras)
                writer.WriteEndElement()

                writer.WriteStartElement(prefixCbc, "Note", cadCbc)
                writer.WriteAttributeString("languageLocaleID", "3000")
                writer.WriteValue("0501002017051400452")
                writer.WriteEndElement()

                '<cbc:DocumentCurrencyCode>PEN</cbc:DocumentCurrencyCode>
                writer.WriteStartElement(prefixCbc, "DocumentCurrencyCode", cadCbc)
                writer.WriteAttributeString("listID", "ISO 4217 Alpha")
                writer.WriteAttributeString("listName", "Currency")
                writer.WriteAttributeString("listAgencyName", "United Nations Economic Commission for Europe")
                writer.WriteValue(CodMon)
                writer.WriteEndElement()

                writer.WriteElementString("LineCountNumeric", cadCbc, LineCountNumeric)

                If dtCab.Rows(0).Item("orden_compra").ToString <> "" Then
                    '<cac:OrderReference>
                    writer.WriteStartElement(prefixCac, "OrderReference", cadCac)
                    '<cbc:ID>456785969</cbc:ID>
                    writer.WriteElementString("ID", cadCbc, dtCab.Rows(0).Item("nro_oc").ToString)
                    '</cac:OrderReference>
                    writer.WriteEndElement()
                End If

            End If
        End If

        '<cac:Signature>
        writer.WriteStartElement(prefixCac, "Signature", cadCac)
        '<cbc:ID>IDSignSP</cbc:ID>
        writer.WriteElementString("ID", cadCbc, "IDSignSP")
        '<cac:SignatoryParty>
        writer.WriteStartElement(prefixCac, "SignatoryParty", cadCac)
        '<cac:PartyIdentification>
        writer.WriteStartElement(prefixCac, "PartyIdentification", cadCac)
        '<cbc:ID>20100454523</cbc:ID> - RUC EMPRESA
        oeCatalago = New e_CatalagoCodigoSunat
        oeCatalago.CodigoTabla = "017" : oeCatalago.CodigoElemento = "001"
        'writer.WriteElementString("ID", cadCbc, facturacionADObj.ObtenerDescripcionPorCodigoSistema("017", "001").ToString().Trim())
        writer.WriteElementString("ID", cadCbc, dCatalago.Obtener(oeCatalago).Descripcion)
        '</cac:PartyIdentification>
        writer.WriteEndElement()
        '<cac:PartyName>
        writer.WriteStartElement(prefixCac, "PartyName", cadCac)
        '<cbc:Name>SOPORTE TECNOLOGICO EIRL</cbc:Name> NOMBRE DE EMPRESA
        oeCatalago = New e_CatalagoCodigoSunat
        oeCatalago.CodigoTabla = "017" : oeCatalago.CodigoElemento = "013"
        'writer.WriteElementString("Name", cadCbc, facturacionADObj.ObtenerDescripcionPorCodigoSistema("017", "013").ToString().Trim())
        writer.WriteElementString("Name", cadCbc, dCatalago.Obtener(oeCatalago).Descripcion)
        '</cac:PartyName>
        writer.WriteEndElement()
        '</cac:SignatoryParty>
        writer.WriteEndElement()
        '<cac:DigitalSignatureAttachment>
        writer.WriteStartElement(prefixCac, "DigitalSignatureAttachment", cadCac)
        '<cac:ExternalReference>
        writer.WriteStartElement(prefixCac, "ExternalReference", cadCac)
        '<cbc:URI>#SignatureSP</cbc:URI>
        writer.WriteElementString("URI", cadCbc, "#SignatureSP")
        '</cac:ExternalReference>
        writer.WriteEndElement()
        '</cac:DigitalSignatureAttachment>
        writer.WriteEndElement()
        '</cac:Signature>
        writer.WriteEndElement()

        '<cac:AccountingSupplierParty> Datos Emisor Electronico
        writer.WriteStartElement(prefixCac, "AccountingSupplierParty", cadCac)

        ''<cbc:CustomerAssignedAccountID>20100454523</cbc:CustomerAssignedAccountID>
        'oeCatalago = New e_CatalagoCodigoSunat
        'oeCatalago.CodigoTabla = "017" : oeCatalago.CodigoElemento = "001"
        ''writer.WriteElementString("CustomerAssignedAccountID", cadCbc, facturacionADObj.ObtenerDescripcionPorCodigoSistema("017", "001").ToString().Trim())
        'writer.WriteElementString("CustomerAssignedAccountID", cadCbc, dCatalago.Obtener(oeCatalago).Descripcion)
        ''<cbc:AdditionalAccountID>6</cbc:AdditionalAccountID>
        'oeCatalago = New e_CatalagoCodigoSunat
        'oeCatalago.CodigoTabla = "017" : oeCatalago.CodigoElemento = "002"
        ''writer.WriteElementString("AdditionalAccountID", cadCbc, facturacionADObj.ObtenerDescripcionPorCodigoSistema("017", "002"))
        'writer.WriteElementString("AdditionalAccountID", cadCbc, dCatalago.Obtener(oeCatalago).Descripcion)

        '<cac:Party>
        writer.WriteStartElement(prefixCac, "Party", cadCac)
        '<cac:PartyName> 
        writer.WriteStartElement(prefixCac, "PartyName", cadCac)
        '<cbc:Name><![CDATA[K&G Laboratorios]]></cbc:Name> 
        oeCatalago = New e_CatalagoCodigoSunat
        oeCatalago.CodigoTabla = "017" : oeCatalago.CodigoElemento = "010"
        'writer.WriteElementString("Name", cadCbc, facturacionADObj.ObtenerDescripcionPorCodigoSistema("017", "010"))
        writer.WriteElementString("Name", cadCbc, dCatalago.Obtener(oeCatalago).Descripcion)
        '</cac:PartyName>
        writer.WriteEndElement()

        writer.WriteStartElement(prefixCac, "PartyTaxScheme", cadCac)

        oeCatalago = New e_CatalagoCodigoSunat With {.CodigoTabla = "017", .CodigoElemento = "013"}
        writer.WriteStartElement(prefixCbc, "RegistrationName", cadCbc)
        writer.WriteCData(dCatalago.Obtener(oeCatalago).Descripcion)
        writer.WriteEndElement()

        writer.WriteStartElement(prefixCbc, "CompanyID", cadCbc)
        oeCatalago = New e_CatalagoCodigoSunat With {.CodigoTabla = "017", .CodigoElemento = "002"}
        writer.WriteAttributeString("schemeID", dCatalago.Obtener(oeCatalago).Descripcion)
        writer.WriteAttributeString("schemeName", "SUNAT:Identificador de Documento de Identidad")
        writer.WriteAttributeString("schemeAgencyName", "PE:SUNAT")
        writer.WriteAttributeString("schemeURI", "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo06")
        oeCatalago = New e_CatalagoCodigoSunat With {.CodigoTabla = "017", .CodigoElemento = "001"}
        writer.WriteValue(dCatalago.Obtener(oeCatalago).Descripcion)
        writer.WriteEndElement()

        writer.WriteStartElement(prefixCac, "RegistrationAddress", cadCac)
        writer.WriteElementString("AddressTypeCode", cadCbc, "0000")
        writer.WriteEndElement()

        writer.WriteStartElement(prefixCac, "TaxScheme", cadCac)
        writer.WriteElementString("ID", cadCbc, "-")
        writer.WriteEndElement()

        writer.WriteEndElement()

        'If flagBaja = False Then
        '    '<cac:PostalAddress>
        '    writer.WriteStartElement(prefixCac, "PostalAddress", cadCac)
        '    '<cbc:ID>150111</cbc:ID>
        '    oeCatalago = New e_CatalagoCodigoSunat
        '    oeCatalago.CodigoTabla = "017" : oeCatalago.CodigoElemento = "003"
        '    'writer.WriteElementString("ID", cadCbc, facturacionADObj.ObtenerDescripcionPorCodigoSistema("017", "003"))
        '    writer.WriteElementString("ID", cadCbc, dCatalago.Obtener(oeCatalago).Descripcion)
        '    '<cbc:StreetName>AV. LOS PRECURSORES #1245</cbc:StreetName>
        '    oeCatalago = New e_CatalagoCodigoSunat
        '    oeCatalago.CodigoTabla = "017" : oeCatalago.CodigoElemento = "004"
        '    'writer.WriteElementString("StreetName", cadCbc, facturacionADObj.ObtenerDescripcionPorCodigoSistema("017", "004"))
        '    writer.WriteElementString("StreetName", cadCbc, dCatalago.Obtener(oeCatalago).Descripcion)
        '    '<cbc:CitySubdivisionName>URB. MIGUEL GRAU</cbc:CitySubdivisionName>
        '    oeCatalago = New e_CatalagoCodigoSunat
        '    oeCatalago.CodigoTabla = "017" : oeCatalago.CodigoElemento = "005"
        '    'writer.WriteElementString("CitySubdivisionName", cadCbc, facturacionADObj.ObtenerDescripcionPorCodigoSistema("017", "005"))
        '    writer.WriteElementString("CitySubdivisionName", cadCbc, dCatalago.Obtener(oeCatalago).Descripcion)
        '    '<cbc:CityName>LIMA</cbc:CityName>
        '    oeCatalago = New e_CatalagoCodigoSunat
        '    oeCatalago.CodigoTabla = "017" : oeCatalago.CodigoElemento = "006"
        '    'writer.WriteElementString("CityName", cadCbc, facturacionADObj.ObtenerDescripcionPorCodigoSistema("017", "006"))
        '    writer.WriteElementString("CityName", cadCbc, dCatalago.Obtener(oeCatalago).Descripcion)
        '    '<cbc:CountrySubentity>LIMA</cbc:CountrySubentity>
        '    oeCatalago = New e_CatalagoCodigoSunat
        '    oeCatalago.CodigoTabla = "017" : oeCatalago.CodigoElemento = "007"
        '    'writer.WriteElementString("CountrySubentity", cadCbc, facturacionADObj.ObtenerDescripcionPorCodigoSistema("017", "007"))
        '    writer.WriteElementString("CountrySubentity", cadCbc, dCatalago.Obtener(oeCatalago).Descripcion)
        '    '<cbc:District>EL AGUSTINO</cbc:District>
        '    oeCatalago = New e_CatalagoCodigoSunat
        '    oeCatalago.CodigoTabla = "017" : oeCatalago.CodigoElemento = "008"
        '    'writer.WriteElementString("District", cadCbc, facturacionADObj.ObtenerDescripcionPorCodigoSistema("017", "008"))
        '    writer.WriteElementString("District", cadCbc, dCatalago.Obtener(oeCatalago).Descripcion)
        '    '<cac:Country>
        '    writer.WriteStartElement(prefixCac, "Country", cadCac)
        '    '<cbc:IdentificationCode>PE</cbc:IdentificationCode>
        '    oeCatalago = New e_CatalagoCodigoSunat
        '    oeCatalago.CodigoTabla = "017" : oeCatalago.CodigoElemento = "009"
        '    'writer.WriteElementString("IdentificationCode", cadCbc, facturacionADObj.ObtenerDescripcionPorCodigoSistema("017", "009"))
        '    writer.WriteElementString("IdentificationCode", cadCbc, dCatalago.Obtener(oeCatalago).Descripcion)
        '    '</cac:Country>
        '    writer.WriteEndElement()
        '    '</cac:PostalAddress>
        '    writer.WriteEndElement()
        'End If
        ''<cac:PartyLegalEntity>
        'writer.WriteStartElement(prefixCac, "PartyLegalEntity", cadCac)
        ''<cbc:RegistrationName>SOPORTE TECNOLOGICOS EIRL</cbc:RegistrationName>
        'oeCatalago = New e_CatalagoCodigoSunat
        'oeCatalago.CodigoTabla = "017" : oeCatalago.CodigoElemento = "013"
        ''writer.WriteElementString("RegistrationName", cadCbc, facturacionADObj.ObtenerDescripcionPorCodigoSistema("017", "013"))
        'writer.WriteElementString("RegistrationName", cadCbc, dCatalago.Obtener(oeCatalago).Descripcion)
        ''</cac:PartyLegalEntity>
        'writer.WriteEndElement()

        '</cac:Party>
        writer.WriteEndElement()
        '</cac:AccountingSupplierParty>
        writer.WriteEndElement()


        If flagBaja = False Then
            '<cac:AccountingCustomerParty> Datos Cliente
            writer.WriteStartElement(prefixCac, "AccountingCustomerParty", cadCac)

            ''<cbc:CustomerAssignedAccountID>20587896411</cbc:CustomerAssignedAccountID>
            'writer.WriteElementString("CustomerAssignedAccountID", cadCbc, dtCab.Rows(0).Item("doc_receptor").ToString().Trim())
            ''<cbc:AdditionalAccountID>6</cbc:AdditionalAccountID>
            'writer.WriteElementString("AdditionalAccountID", cadCbc, dtCab.Rows(0).Item("tipodoc_receptor").ToString().Trim())

            '<cac:Party>
            writer.WriteStartElement(prefixCac, "Party", cadCac)
            '<cac:PartyTaxScheme>
            writer.WriteStartElement(prefixCac, "PartyTaxScheme", cadCac)
            '<cbc:RegistrationName>SERVICABINAS S.A.</cbc:RegistrationName>
            writer.WriteElementString("RegistrationName", cadCbc, dtCab.Rows(0).Item("empresa_receptor").ToString().Trim())

            writer.WriteStartElement(prefixCbc, "CompanyID", cadCbc)
            writer.WriteAttributeString("schemeID", dtCab.Rows(0).Item("tipodoc_receptor").ToString().Trim())
            writer.WriteAttributeString("schemeName", "SUNAT:Identificador de Documento de Identidad")
            writer.WriteAttributeString("schemeAgencyName", "PE:SUNAT")
            writer.WriteAttributeString("schemeURI", "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo06")
            writer.WriteValue(dtCab.Rows(0).Item("doc_receptor").ToString().Trim())
            writer.WriteEndElement()

            writer.WriteStartElement(prefixCac, "TaxScheme", cadCac)
            writer.WriteElementString("ID", cadCbc, "-")
            writer.WriteEndElement()

            '</cac:PartyTaxScheme>
            writer.WriteEndElement()
            '</cac:Party>
            writer.WriteEndElement()
            '</cac:AccountingSupplierParty>
            writer.WriteEndElement()
            '
            If CType(dtCab.Rows(0).Item("monto_anticipo"), Double) > 0 And Not dtAnt Is Nothing Then
                For Each anticipo In dtAnt.Rows
                    '<cac:PrepaidPayment> Datos de Anticipo
                    writer.WriteStartElement(prefixCac, "PrepaidPayment", cadCac)
                    '<cbc:ID schemeID="02">F001-00000002</cbc:ID>
                    writer.WriteStartElement(prefixCbc, "ID", cadCbc)
                    writer.WriteAttributeString("schemeID", anticipo("tipo_doc").ToString().Trim())
                    writer.WriteValue(CType(anticipo("doc_antic"), String).ToString().Trim())
                    writer.WriteEndElement()
                    '<cbc:PaidAmount currencyID="PEN">62675.85</cbc:ID>
                    writer.WriteStartElement(prefixCbc, "PaidAmount", cadCbc)
                    writer.WriteAttributeString("currencyID", CodMon)
                    writer.WriteValue(CType(anticipo("monto_antic"), Double).ToString("F2"))
                    writer.WriteEndElement()
                    '<cbc:InstructionID schemeID="06">10448457309</cbc:ID>
                    writer.WriteStartElement(prefixCbc, "InstructionID", cadCbc)
                    writer.WriteAttributeString("schemeID", "6")
                    writer.WriteValue(CType(anticipo("doc_cliente"), String).ToString().Trim())
                    writer.WriteEndElement()
                    '</cac:PrepaidPayment>
                    writer.WriteEndElement()
                Next
            End If

            If CType(dtCab.Rows(0).Item("monto_d"), Double) > 0 Then
                '<cbc:AllowanceTotalAmount currencyID="PEN">7000.00</cbc:AllowanceTotalAmount> 
                writer.WriteStartElement(prefixCbc, "AllowanceTotalAmount", cadCbc)
                writer.WriteAttributeString("currencyID", CodMon)
                'If flagME Then
                '    writer.WriteValue(CType(dtCab.Rows(0).Item("descom") / factorC, Double).ToString("F2"))
                'Else
                '    writer.WriteValue(CType(dtCab.Rows(0).Item("descom"), Double).ToString("F2"))
                'End If
                writer.WriteValue(CType(dtCab.Rows(0).Item("monto_d"), Double).ToString("F2"))
                writer.WriteEndElement()
                ''<cbc:ChargeTotalAmount currencyID="PEN">80680.13</cbc:AllowanceTotalAmount>
                'writer.WriteStartElement(prefixCbc, "ChargeTotalAmount", cadCbc)
                'writer.WriteAttributeString("currencyID", CodMon)
                'If flagME Then
                '    writer.WriteValue(CType(dtCab.Rows(0).Item("descom") / factorC, Double).ToString("F2"))
                'Else
                '    writer.WriteValue(CType(dtCab.Rows(0).Item("descom"), Double).ToString("F2"))
                'End If
                'writer.WriteEndElement()
            End If

            If CType(dtCab.Rows(0).Item("total_impuestos"), Double) > 0 Then
                '<cac:TaxTotal>
                writer.WriteStartElement(prefixCac, "TaxTotal", cadCac)

                '<cbc:TaxAmount currencyID="PEN">62675.85</cbc:TaxAmount>
                writer.WriteStartElement(prefixCbc, "TaxAmount", cadCbc)
                writer.WriteAttributeString("currencyID", CodMon)
                writer.WriteValue(CType(dtCab.Rows(0).Item("total_impuestos"), Double).ToString("F2"))
                writer.WriteEndElement()

                '<cac:TaxSubtotal>
                writer.WriteStartElement(prefixCac, "TaxSubtotal", cadCac)

                writer.WriteStartElement(prefixCbc, "TaxableAmount", cadCbc)
                writer.WriteAttributeString("currencyID", CodMon)
                writer.WriteValue(CType(dtCab.Rows(0).Item("montbas_gravado"), Double).ToString("F2"))
                writer.WriteEndElement()

                '<cbc:TaxAmount currencyID="PEN">62675.85</cbc:TaxAmount>
                writer.WriteStartElement(prefixCbc, "TaxAmount", cadCbc)
                writer.WriteAttributeString("currencyID", CodMon)
                writer.WriteValue(CType(dtCab.Rows(0).Item("total_impuestos"), Double).ToString("F2"))
                writer.WriteEndElement()

                '<cac:TaxCategory>
                writer.WriteStartElement(prefixCac, "TaxCategory", cadCac)

                '<cac:TaxScheme>
                writer.WriteStartElement(prefixCac, "TaxScheme", cadCac)
                oeCatalago = New e_CatalagoCodigoSunat
                oeCatalago.CodigoTabla = "005" : oeCatalago.CodigoElemento = "001"
                oeCatalago = dCatalago.Obtener(oeCatalago)

                '<cbc:ID>1000</cbc:ID>
                writer.WriteStartElement(prefixCbc, "ID", cadCbc)
                writer.WriteAttributeString("schemeID", "UN/ECE 5153")
                writer.WriteAttributeString("schemeAgencyID", "6")
                writer.WriteValue(oeCatalago.CodigoSunat)
                writer.WriteEndElement()
                '<cbc:Name>IGV</cbc:Name>
                writer.WriteElementString("Name", cadCbc, oeCatalago.Descripcion)
                '<cbc:TaxTypeCode>VAT</cbc:TaxTypeCode>
                writer.WriteElementString("TaxTypeCode", cadCbc, oeCatalago.CodigoAlterno)
                '</cac:TaxScheme>
                writer.WriteEndElement()

                '</cac:TaxCategory>
                writer.WriteEndElement()
                '</cac:TaxSubtotal>
                writer.WriteEndElement()
                '</cac:TaxTotal>
                writer.WriteEndElement()
            End If

            If flagND Then
                '<cac:RequestedMonetaryTotal>
                writer.WriteStartElement(prefixCac, "RequestedMonetaryTotal", cadCac)
            Else
                '<cac:LegalMonetaryTotal>
                writer.WriteStartElement(prefixCac, "LegalMonetaryTotal", cadCac)
            End If

            If CType(dtCab.Rows(0).Item("monto_anticipo"), Double) > 0 And Not dtAnt Is Nothing Then
                '<cbc:PayableAmount currencyID="PEN">423225.00</cbc:PayableAmount>
                writer.WriteStartElement(prefixCbc, "PrepaidAmount", cadCbc)
                writer.WriteAttributeString("currencyID", CodMon)
                writer.WriteValue(CType(dtCab.Rows(0).Item("monto_anticipo"), Double).ToString("F2"))
                writer.WriteEndElement()
            End If

            '<cbc:PayableAmount currencyID="PEN">423225.00</cbc:PayableAmount>
            writer.WriteStartElement(prefixCbc, "PayableAmount", cadCbc)
            writer.WriteAttributeString("currencyID", CodMon)
            writer.WriteValue(CType(dtCab.Rows(0).Item("precio_venta"), Double).ToString("F2"))
            writer.WriteEndElement()
            '</cac:LegalMonetaryTotal>
            writer.WriteEndElement()

        End If
        Return writer
    End Function

    Private Function ObtenerDatosDetalle(ByVal writer As XmlWriter, ByVal prefixCbc As String, ByVal prefixCac As String, ByVal cadCbc As String, ByVal cadCac As String, ByVal drFila As DataRow, ByVal moneda As String, ByVal flagNC As Boolean, ByVal flagME As Boolean, ByVal flagND As Boolean, ByVal factorC As Double, ByVal esTG As Boolean) As XmlWriter
        Dim dCatalago As New d_CatalagoCodigoSunat
        Dim oeCatalago As e_CatalagoCodigoSunat
        Dim um As String
        '<cac:InvoiceLine>
        If flagNC Then
            writer.WriteStartElement(prefixCac, "CreditNoteLine", cadCac)
        ElseIf flagND Then
            writer.WriteStartElement(prefixCac, "DebitNoteLine", cadCac)
        Else
            writer.WriteStartElement(prefixCac, "InvoiceLine", cadCac)
        End If
        '<cbc:ID>1</cbc:ID>
        writer.WriteElementString("ID", cadCbc, drFila.Item("item"))
        If flagNC Then
            '<cbc:CreditedQuantity unitCode="NIU">100</cbc:CreditedQuantity>
            writer.WriteStartElement(prefixCbc, "CreditedQuantity", cadCbc)
        ElseIf flagND Then
            '<cbc:DebitedQuantity unitCode="NIU">2000</cbc:DebitedQuantity>
            writer.WriteStartElement(prefixCbc, "DebitedQuantity", cadCbc)
        Else
            '<cbc:InvoicedQuantity unitCode="NIU">2000</cbc:InvoicedQuantity>
            writer.WriteStartElement(prefixCbc, "InvoicedQuantity", cadCbc)
        End If
        oeCatalago = New e_CatalagoCodigoSunat
        oeCatalago.CodigoTabla = "003" : oeCatalago.CodigoElemento = CType(drFila.Item("unidad").ToString().Trim(), String)
        um = dCatalago.Obtener(oeCatalago).CodigoSunat
        If um.Trim = "" Then
            um = "NIU"
        End If
        writer.WriteAttributeString("unitCode", um)
        writer.WriteAttributeString("unitCodeListID", "UN/ECE rec 20")
        writer.WriteAttributeString("unitCodeListAgencyName", "Europe")
        writer.WriteValue(drFila.Item("cantidad"))
        writer.WriteEndElement()

        '<cbc:LineExtensionAmount currencyID="PEN">149491.53</cbc:LineExtensionAmount>
        writer.WriteStartElement(prefixCbc, "LineExtensionAmount", cadCbc)
        writer.WriteAttributeString("currencyID", moneda)
        writer.WriteValue(CType(drFila.Item("valor_venta"), Double).ToString("F2"))
        writer.WriteEndElement()

        '<cac:PricingReference>
        writer.WriteStartElement(prefixCac, "PricingReference", cadCac)

        '<cac:AlternativeConditionPrice>
        writer.WriteStartElement(prefixCac, "AlternativeConditionPrice", cadCac)
        '<cbc:PriceAmount currencyID="PEN">98.00</cbc:PriceAmount>
        writer.WriteStartElement(prefixCbc, "PriceAmount", cadCbc)
        writer.WriteAttributeString("currencyID", moneda)
        writer.WriteValue(CType(drFila.Item("precio_venta"), Double).ToString("F2"))
        writer.WriteEndElement()

        '<cbc:PriceTypeCode>01</cbc:PriceTypeCode>
        oeCatalago = New e_CatalagoCodigoSunat
        oeCatalago.CodigoTabla = "016" : oeCatalago.CodigoElemento = "001"
        writer.WriteStartElement(prefixCbc, "PriceTypeCode", cadCbc)
        writer.WriteAttributeString("listName", "SUNAT:Indicador de Tipo de Precio")
        writer.WriteAttributeString("listAgencyName", "PE:SUNAT")
        writer.WriteAttributeString("listURI", "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo16")
        writer.WriteValue(dCatalago.Obtener(oeCatalago).CodigoSunat)
        writer.WriteEndElement()

        '</cac:AlternativeConditionPrice>
        writer.WriteEndElement()

        'If esTG Then
        '    '<cac:AlternativeConditionPrice>
        '    writer.WriteStartElement(prefixCac, "AlternativeConditionPrice", cadCac)
        '    '<cbc:PriceAmount currencyID="PEN">98.00</cbc:PriceAmount>
        '    writer.WriteStartElement(prefixCbc, "PriceAmount", cadCbc)
        '    writer.WriteAttributeString("currencyID", moneda)
        '    'If flagME Then
        '    '    writer.WriteValue(CType(drFila.Item("valorunitario") / factorC, Double).ToString("F2"))
        '    'Else
        '    '    writer.WriteValue(CType(drFila.Item("valorunitario"), Double).ToString("F2"))
        '    'End If
        '    writer.WriteValue(CType(drFila.Item("precio_unit"), Double).ToString("F2"))
        '    writer.WriteEndElement()
        '    '<cbc:PriceTypeCode>02</cbc:PriceTypeCode>
        '    oeCatalago = New e_CatalagoCodigoSunat
        '    oeCatalago.CodigoTabla = "016" : oeCatalago.CodigoElemento = "002"
        '    'writer.WriteElementString("PriceTypeCode", cadCbc, facturacionADObj.ObtenerCodigoSunatPorCodigoSistema("016", "002").Trim())
        '    writer.WriteElementString("PriceTypeCode", cadCbc, dCatalago.Obtener(oeCatalago).CodigoSunat)
        '    '</cac:AlternativeConditionPrice>
        '    writer.WriteEndElement()
        'End If

        '</cac:PricingReference>
        writer.WriteEndElement()

        'If drFila.Item("igv") > 0 Or drFila.Item("igvme") > 0 Then
        '<cac:TaxTotal>
        writer.WriteStartElement(prefixCac, "TaxTotal", cadCac)
        '<cbc:TaxAmount currencyID="PEN">26908.47</cbc:TaxAmount>
        writer.WriteStartElement(prefixCbc, "TaxAmount", cadCbc)
        writer.WriteAttributeString("currencyID", moneda)
        writer.WriteValue(CType(drFila.Item("monto_igv"), Double).ToString("F2"))
        writer.WriteEndElement()
        '<cac:TaxSubtotal>
        writer.WriteStartElement(prefixCac, "TaxSubtotal", cadCac)

        writer.WriteStartElement(prefixCbc, "TaxableAmount", cadCbc)
        writer.WriteAttributeString("currencyID", moneda)
        writer.WriteValue(CType(drFila.Item("valor_venta"), Double).ToString("F2"))
        writer.WriteEndElement()

        '<cbc:TaxAmount currencyID="PEN">26908.47</cbc:TaxAmount>
        writer.WriteStartElement(prefixCbc, "TaxAmount", cadCbc)
        writer.WriteAttributeString("currencyID", moneda)
        writer.WriteValue(CType(drFila.Item("monto_igv"), Double).ToString("F2"))
        writer.WriteEndElement()

        '<cac:TaxCategory>
        writer.WriteStartElement(prefixCac, "TaxCategory", cadCac)

        writer.WriteStartElement(prefixCbc, "ID", cadCbc)
        writer.WriteAttributeString("schemeID", "UN/ECE 5305")
        writer.WriteAttributeString("schemeName", "Tax Category Identifier")
        writer.WriteAttributeString("schemeAgencyName", "United Nations Economic Commission for Europe")
        writer.WriteValue("S")
        writer.WriteEndElement()

        writer.WriteElementString("Percent", cadCbc, "18.00")

        '<cbc:TaxExemptionReasonCode>10</cbc:TaxExemptionReasonCode>
        writer.WriteStartElement(prefixCbc, "TaxExemptionReasonCode", cadCbc)
        writer.WriteAttributeString("listAgencyName", "PE:SUNAT")
        writer.WriteAttributeString("listName", "SUNAT:Codigo de Tipo de Afectación del IGV")
        writer.WriteAttributeString("listURI", "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo07")
        writer.WriteValue(drFila.Item("codigo_imp").ToString().Trim())
        writer.WriteEndElement()

        '<cac:TaxScheme>
        writer.WriteStartElement(prefixCac, "TaxScheme", cadCac)
        '<cbc:ID>1000</cbc:ID>
        oeCatalago = New e_CatalagoCodigoSunat
        oeCatalago.CodigoTabla = "005" : oeCatalago.CodigoElemento = "001"
        writer.WriteStartElement(prefixCbc, "ID", cadCbc)
        writer.WriteAttributeString("schemeID", "UN/ECE 5153")
        writer.WriteAttributeString("schemeName", "Tax Scheme Identifier")
        writer.WriteAttributeString("schemeAgencyName", "United Nations Economic Commission for Europe")
        writer.WriteValue(dCatalago.Obtener(oeCatalago).CodigoSunat)
        writer.WriteEndElement()

        '<cbc:Name>IGV</cbc:Name>
        oeCatalago = New e_CatalagoCodigoSunat
        oeCatalago.CodigoTabla = "005" : oeCatalago.CodigoElemento = "001"
        writer.WriteElementString("Name", cadCbc, dCatalago.Obtener(oeCatalago).Descripcion)
        '<cbc:TaxTypeCode>VAT</cbc:TaxTypeCode>
        oeCatalago = New e_CatalagoCodigoSunat
        oeCatalago.CodigoTabla = "005" : oeCatalago.CodigoElemento = "001"
        writer.WriteElementString("TaxTypeCode", cadCbc, dCatalago.Obtener(oeCatalago).CodigoAlterno)
        '</cac:TaxScheme>
        writer.WriteEndElement()
        '</cac:TaxCategory>
        writer.WriteEndElement()
        '</cac:TaxSubtotal>
        writer.WriteEndElement()
        '</cac:TaxTotal>
        writer.WriteEndElement()
        ' End If   

        '<cac:Item>
        writer.WriteStartElement(prefixCac, "Item", cadCac)
        '<cbc:Description>Grabadora LG Externo Modelo: GE20LU10</cbc:Description>
        writer.WriteElementString("Description", cadCbc, drFila.Item("descripcion_prodserv").ToString().Trim())
        If drFila.Item("codigo_prodserv").ToString().Trim() <> "" Then
            '<cac:SellersItemIdentification>
            writer.WriteStartElement(prefixCac, "SellersItemIdentification", cadCac)
            '<cbc:ID>GLG199</cbc:ID>
            writer.WriteElementString("ID", cadCbc, drFila.Item("codigo_prodserv").ToString().Trim())
            '</cac:SellersItemIdentification>
            writer.WriteEndElement()
        End If
        '</cac:Item>
        writer.WriteEndElement()

        '<cac:Price>
        writer.WriteStartElement(prefixCac, "Price", cadCac)
        '<cbc:PriceAmount currencyID="PEN">83.05</cbc:PriceAmount>
        writer.WriteStartElement(prefixCbc, "PriceAmount", cadCbc)
        writer.WriteAttributeString("currencyID", moneda)
        If esTG Then
            writer.WriteValue("0.00")
        Else
            writer.WriteValue(CType(drFila.Item("precio_unit"), Double).ToString("F2"))
        End If
        writer.WriteEndElement()
        '</cac:Price>
        writer.WriteEndElement()
        '</cac:InvoiceLine>
        writer.WriteEndElement()
        Return writer
    End Function

    Private Sub AgregarFirma(ByVal rutaFE As String, ByVal Nombre As String, ByRef valorResumen As String, ByRef firma As String, ByVal flagBaja As Boolean, ByVal TipoDoc As String)
        Try
            Dim RutaCer As String = Replace(rutaFE, "Facturacion", "Certificado")
            Dim local_xmlArchivo As String = rutaFE & Nombre & ".XML"

            Dim local_nombreXML As String = System.IO.Path.GetFileName(local_xmlArchivo)

            Dim local_typoDocumento As String

            local_typoDocumento = TipoDoc

            Dim MiCertificado As X509Certificate2 = New X509Certificate2(RutaCer & "C1811162057.pfx", "materiaGRIF01X", X509KeyStorageFlags.MachineKeySet)
            Dim xmlDoc As XmlDocument = New XmlDocument()
            xmlDoc.PreserveWhitespace = True
            xmlDoc.Load(local_xmlArchivo)

            Dim signedXml As SignedXml = New SignedXml(xmlDoc)

            signedXml.SigningKey = MiCertificado.PrivateKey

            Dim KeyInfo As KeyInfo = New KeyInfo()

            Dim Reference As Reference = New Reference()
            Reference.Uri = ""

            Reference.AddTransform(New XmlDsigEnvelopedSignatureTransform())

            signedXml.AddReference(Reference)

            Dim X509Chain As X509Chain = New X509Chain()
            X509Chain.Build(MiCertificado)
            If MiCertificado.NotAfter < Date.Now.ToShortDateString Then
                Throw New Exception("Certificado vencido, no puede generar el xml")
            End If
            Dim local_element As X509ChainElement = X509Chain.ChainElements(0)
            Dim x509Data As KeyInfoX509Data = New KeyInfoX509Data(local_element.Certificate)
            Dim subjectName As String = local_element.Certificate.Subject

            x509Data.AddSubjectName(subjectName)
            KeyInfo.AddClause(x509Data)

            signedXml.KeyInfo = KeyInfo
            signedXml.ComputeSignature()

            Dim signature As XmlElement = signedXml.GetXml()
            signature.Prefix = "ds"
            signedXml.ComputeSignature()

            For Each node As XmlNode In signature.SelectNodes("descendant-or-self::*[namespace-uri()='http://www.w3.org/2000/09/xmldsig#']")
                If node.LocalName = "Signature" Then
                    Dim newAttribute As XmlAttribute = xmlDoc.CreateAttribute("Id")
                    newAttribute.Value = "SignatureSP"
                    node.Attributes.Append(newAttribute)
                    Exit For
                End If
            Next node

            Dim local_xpath As String = ""
            Dim nsMgr As XmlNamespaceManager
            nsMgr = New XmlNamespaceManager(xmlDoc.NameTable)
            'nsMgr.AddNamespace("sac", "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")
            nsMgr.AddNamespace("ccts", "urn:un:unece:uncefact:documentation:2")
            nsMgr.AddNamespace("xsi", "http://www.w3.org/2001/XMLSchema-instance")

            Select Case local_typoDocumento
                Case "01", "03" 'factura / boleta
                    nsMgr.AddNamespace("tns", "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")
                    local_xpath = "/tns:Invoice/ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent"
                Case "07" 'nota de credito
                    nsMgr.AddNamespace("tns", "urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2")
                    local_xpath = "/tns:CreditNote/ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent"
                Case "08" 'nota de debito
                    nsMgr.AddNamespace("tns", "urn:oasis:names:specification:ubl:schema:xsd:DebitNote-2")
                    local_xpath = "/tns:DebitNote/ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent"
                Case "RA"  'Communicacion de baja
                    nsMgr.AddNamespace("tns", "urn:sunat:names:specification:ubl:peru:schema:xsd:VoidedDocuments-1")
                    local_xpath = "/tns:VoidedDocuments/ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent"
                Case "RC" 'Resumen de diario
                    nsMgr.AddNamespace("tns", "urn:sunat:names:specification:ubl:peru:schema:xsd:SummaryDocuments-1")
                    local_xpath = "/tns:SummaryDocuments/ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent"
            End Select

            nsMgr.AddNamespace("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")
            nsMgr.AddNamespace("udt", "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2")
            nsMgr.AddNamespace("ext", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")
            nsMgr.AddNamespace("qdt", "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2")
            nsMgr.AddNamespace("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")
            nsMgr.AddNamespace("ds", "http://www.w3.org/2000/09/xmldsig#")

            xmlDoc.SelectSingleNode(local_xpath, nsMgr).AppendChild(xmlDoc.ImportNode(signature, True))
            valorResumen = signature.ChildNodes.Item(0).ChildNodes.Item(2).ChildNodes.Item(2).FirstChild.Value
            firma = signature.ChildNodes.Item(1).FirstChild.Value
            xmlDoc.Save(local_xmlArchivo)

            Dim nodeList As XmlNodeList = xmlDoc.GetElementsByTagName("ds:Signature")

            'el nodo <ds:Signature> debe existir unicamente 1 vez
            If nodeList.Count <> 1 Then
                Throw New Exception("Se produjo un error en la firma del documento")
            End If
            signedXml.LoadXml(CType(nodeList(0), XmlElement))

            'verificacion de la firma generada
            If signedXml.CheckSignature() = False Then
                Throw New Exception("Se produjo un error en la firma del documento")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ObtenerConceptoTributario(ByVal writer As XmlWriter, ByVal prefixSac As String, ByVal cadSac As String, ByVal cadCbc As String, ByVal prefixCbc As String, ByVal CodigoGravado As String, ByVal Moneda As String, ByVal MontoGravado As Double) As XmlWriter
        '<sac:AdditionalMonetaryTotal>
        writer.WriteStartElement(prefixSac, "AdditionalMonetaryTotal", cadSac)
        '<cbc:ID>1001</cbc:ID>
        writer.WriteElementString("ID", cadCbc, CodigoGravado)
        '<cbc:PayableAmount currencyID="PEN">348199.15</cbc:PayableAmount>
        writer.WriteStartElement(prefixCbc, "PayableAmount", cadCbc)
        writer.WriteAttributeString("currencyID", Moneda)
        writer.WriteValue(MontoGravado.ToString("F2"))
        writer.WriteEndElement()
        '</sac:AdditionalMonetaryTotal>
        writer.WriteEndElement()
        Return writer
    End Function

    Private Function ObtenerConceptoTributario2(ByVal writer As XmlWriter, ByVal prefixSac As String, ByVal cadSac As String, ByVal cadCbc As String, ByVal prefixCbc As String, ByVal CodigoGravado As String, ByVal Moneda As String, ByVal MontoGravado As Double, ByVal Porcentaje As Double) As XmlWriter
        '<sac:AdditionalMonetaryTotal>
        writer.WriteStartElement(prefixSac, "AdditionalMonetaryTotal", cadSac)
        '<cbc:ID>1001</cbc:ID>
        writer.WriteElementString("ID", cadCbc, CodigoGravado)
        '<cbc:PayableAmount currencyID="PEN">348199.15</cbc:PayableAmount>
        writer.WriteStartElement(prefixCbc, "PayableAmount", cadCbc)
        writer.WriteAttributeString("currencyID", Moneda)
        writer.WriteValue(MontoGravado.ToString("F2"))
        writer.WriteEndElement()
        '<sac:Percent>9.00%</sac:Percent>
        writer.WriteElementString("Percent", cadCbc, Porcentaje)
        '</sac:AdditionalMonetaryTotal>
        writer.WriteEndElement()
        Return writer
    End Function

    Private Function ObtenerElementosAdicionales(ByVal writer As XmlWriter, ByVal prefixSac As String, ByVal cadSac As String, ByVal cadCbc As String, ByVal prefixCbc As String, ByVal Codigo As String, ByVal Letras As String) As XmlWriter
        '<sac:AdditionalProperty>
        writer.WriteStartElement(prefixSac, "AdditionalProperty", cadSac)
        '<cbc:ID>1000</cbc:ID>
        writer.WriteElementString("ID", cadCbc, Codigo)
        '<cbc:Value>CUATROCIENTOS VEINTITRES MIL DOSCIENTOS VEINTICINCO Y 00/100</cbc:Value>
        writer.WriteElementString("Value", cadCbc, Letras)
        '</sac:AdditionalProperty>
        writer.WriteEndElement()
        Return writer
    End Function

    Public Sub Extraer(ByVal rutaFE As String, ByVal Nombre As String)
        Using zip1 As ZipFile = ZipFile.Read(rutaFE & "R-" & Nombre & ".zip")
            Dim e As ZipEntry
            For Each e In zip1
                e.Extract(rutaFE, ExtractExistingFileAction.OverwriteSilently)
            Next
        End Using
    End Sub

    Private Function VerificarSiExisteError(ByVal nodos As XmlElement)
        Dim msjError As String = ""
        If nodos.HasChildNodes Then
            If nodos.ChildNodes(0).NodeType <> XmlNodeType.Text And nodos.ChildNodes(0).NodeType <> XmlNodeType.CDATA Then
                For Each nodo As XmlElement In nodos.ChildNodes
                    If nodo.Name = "cbc:ResponseCode" Then
                        If nodo.FirstChild.Value.ToString.Replace("soap-env-Server.", "").Trim <> "0" Then
                            msjError = nodo.NextSibling.FirstChild.Value
                            Exit For
                        End If
                    End If
                    msjError = VerificarSiExisteError(nodo)
                    If msjError <> "" Then
                        Exit For
                    End If
                Next
            End If
        End If
        Return msjError
    End Function

    Public Function EncodeArrayBase64(ByRef arrData() As Byte) As String
        Dim objXML As MSXML2.DOMDocument
        Dim objNode As MSXML2.IXMLDOMElement

        objXML = New MSXML2.DOMDocument
        'Matriz de bytes a base64
        objNode = objXML.createElement("b64")

        objNode.dataType = "bin.base64"
        objNode.nodeTypedValue = arrData
        EncodeArrayBase64 = objNode.text
        arrData = objNode.nodeTypedValue
        objNode = Nothing
        objXML = Nothing
    End Function

    Public Function GenerarXmlComprobantesBaja(ByVal dtCab As DataTable, ByVal fechaGeneracion As DateTime, ByVal rutaFE As String, ByVal usuario As String, ByVal PrefijoID As String) As String
        ' Create XmlWriterSettings.
        Dim nombre As String = ""
        Dim settings As XmlWriterSettings = New XmlWriterSettings()
        Dim prefixCac As String
        Dim prefixCbc As String
        Dim prefixDs As String
        Dim prefixExt As String
        Dim prefixSac As String
        Dim cadCac As String = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"
        Dim cadCbc As String = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"
        Dim cadCcts As String = "urn:un:unece:uncefact:documentation:2"
        Dim cadDs As String = "http://www.w3.org/2000/09/xmldsig#"
        Dim cadExt As String = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2"
        Dim cadQdt As String = "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2"
        Dim cadSac As String = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1"
        Dim cadUdt As String = "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2"
        Dim cadXsi As String = "http://www.w3.org/2001/XMLSchema-instance"
        Dim definicion As String = ""
        Dim ticket As String = Nothing
        'Dim facturacionADObj As New LogicaNegocio.FacturacionElectronicaAD(mCadenaConexion)
        'Dim facturacion2ADObj As New LogicaNegocio.FacturacionElectronica(mCadenaConexion)
        Dim i As Integer = 0
        Dim correlativo As String
        Dim TipDoc As String
        Dim dtDocOri As DataTable
        Dim dCatalago As New d_CatalagoCodigoSunat
        Dim oeCatalago As e_CatalagoCodigoSunat
        Dim odComprobanteElectronicoBath As New d_ComprobanteElectronicoBath
        Dim oeComprobanteElectronicoBath As e_ComprobanteElectronicoBath
        Dim ListaBath As New List(Of e_ComprobanteElectronicoBath)
        Try
            oeComprobanteElectronicoBath = New e_ComprobanteElectronicoBath
            oeComprobanteElectronicoBath.TipoOperacion = ""
            oeComprobanteElectronicoBath.TipoReferencia = 1
            oeComprobanteElectronicoBath.FechaEnvio = fechaGeneracion
            oeComprobanteElectronicoBath.IndBaja = True

            ListaBath = odComprobanteElectronicoBath.Listar(oeComprobanteElectronicoBath)
            correlativo = ListaBath.Count + 1
            'correlativo = facturacionADObj.ObtenerCorrelativo(True, fechaGeneracion).ToString.Trim
            oeCatalago = New e_CatalagoCodigoSunat
            oeCatalago.CodigoTabla = "017" : oeCatalago.CodigoElemento = "001"
            'nombre = facturacionADObj.ObtenerDescripcionPorCodigoSistema("017", "001") & "-RA-" & CType(fechaGeneracion, Date).Year.ToString().PadLeft(2, "0").Trim() & CType(fechaGeneracion, Date).Month.ToString().PadLeft(2, "0").Trim() & CType(fechaGeneracion, Date).Day.ToString().PadLeft(2, "0").Trim() & "-" & correlativo.Trim
            nombre = dCatalago.Obtener(oeCatalago).Descripcion & "-RA-" & CType(fechaGeneracion, Date).Year.ToString().PadLeft(2, "0").Trim() & CType(fechaGeneracion, Date).Month.ToString().PadLeft(2, "0").Trim() & CType(fechaGeneracion, Date).Day.ToString().PadLeft(2, "0").Trim() & "-" & correlativo.Trim
            settings.Indent = True
            ' Create XmlWriter.
            settings.Encoding = System.Text.UTF8Encoding.UTF8
            Using writer As XmlWriter = XmlWriter.Create(rutaFE.Trim() & nombre.Trim() & ".XML", settings)
                prefixCac = writer.LookupPrefix(cadCac)
                prefixExt = writer.LookupPrefix(cadExt)
                prefixSac = writer.LookupPrefix(cadSac)
                prefixCbc = writer.LookupPrefix(cadCbc)
                prefixDs = writer.LookupPrefix(cadDs)
                ' Begin writing.
                writer.WriteStartDocument()
                '<VoidedDocuments xmlns="urn:sunat:names:specification:ubl:peru:schema:xsd:VoidedDocuments-1" xmlns:cac="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2" xmlns:cbc="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2" xmlns:ds="http://www.w3.org/2000/09/xmldsig#" xmlns:ext="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2" xmlns:sac="urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
                writer.WriteStartElement("VoidedDocuments", "urn:sunat:names:specification:ubl:peru:schema:xsd:VoidedDocuments-1") ' Root.
                writer.WriteAttributeString("xmlns", "cac", Nothing, cadCac)
                writer.WriteAttributeString("xmlns", "cbc", Nothing, cadCbc)
                writer.WriteAttributeString("xmlns", "ccts", Nothing, cadCcts)
                writer.WriteAttributeString("xmlns", "ds", Nothing, cadDs)
                writer.WriteAttributeString("xmlns", "ext", Nothing, cadExt)
                writer.WriteAttributeString("xmlns", "qdt", Nothing, cadQdt)
                writer.WriteAttributeString("xmlns", "sac", Nothing, cadSac)
                writer.WriteAttributeString("xmlns", "udt", Nothing, cadUdt)
                writer.WriteAttributeString("xmlns", "xsi", Nothing, cadXsi)
                Me.ObtenerExtensiones(writer, prefixExt, prefixCbc, prefixDs, cadExt, cadCbc, cadDs, Nothing, Nothing, "", False, True, dtCab.Rows(0).Item("factorc"))
                Me.ObtenerDatosCabecera(writer, prefixCbc, prefixCac, cadCbc, cadCac, dtCab, Nothing, "", "", False, False, False, True, fechaGeneracion, dtCab.Rows(0).Item("factorc"), Nothing, "RA", correlativo.Trim)
                For Each drFila As DataRow In dtCab.Rows
                    i = i + 1
                    oeCatalago = New e_CatalagoCodigoSunat
                    oeCatalago.CodigoTabla = "001" : oeCatalago.CodigoElemento = drFila.Item("tipcomp").ToString()
                    'TipDoc = facturacionADObj.ObtenerCodigoAlternoPorCodigoSistema("001", drFila.Item("tipcomp").ToString())
                    TipDoc = dCatalago.Obtener(oeCatalago).CodigoAlterno
                    'Select Case TipDoc.Trim()
                    '    Case "01"
                    '        drFila.Item("seriecomp") = "F" & drFila.Item("seriecomp").ToString().Trim()
                    '    Case "03"
                    '        drFila.Item("seriecomp") = "B" & drFila.Item("seriecomp").ToString().Trim()
                    '    Case Else
                    '        dtDocOri = facturacionADObj.ObtenerCabeceraComprobanteOrigen(CType(drFila.Item("seriecomp"), String) & "-" & CType(drFila.Item("corrcomp"), String), CType(drFila.Item("tipcomp"), String))
                    '        If dtDocOri.Rows.Count > 0 Then
                    '            Select Case dtDocOri.Rows(0).Item("tipcomp").ToString.Trim()
                    '                Case "01"
                    '                    drFila.Item("seriecomp") = "F" & drFila.Item("seriecomp").ToString().Trim()
                    '                Case "03"
                    '                    drFila.Item("seriecomp") = "B" & drFila.Item("seriecomp").ToString().Trim()
                    '            End Select
                    '        Else
                    '            Throw New Exception("No existe comprobante origen para el documento :" & CType(drFila.Item("seriecomp"), String) & "-" & CType(drFila.Item("corrcomp"), String))
                    '        End If
                    'End Select                    
                    If TipDoc = "07" Or TipDoc = "08" Then
                        Dim oeDocumento As New e_MovimientoDocumento
                        Dim dDocumento As New d_MovimientoDocumento
                        oeDocumento.Id = dtCab.Rows(0).Item("idcomp").ToString().Trim : oeDocumento.TipoOperacion = 3
                        dtDocOri = dDocumento.ListarFacturacionElectronica(oeDocumento).Tables(0)
                        If dtDocOri.Rows.Count = 0 Then
                            Throw New Exception("No existe comprobante origen para el documento :" & CType(dtCab.Rows(0).Item("seriecomp"), String) & "-" & CType(dtCab.Rows(0).Item("corrcomp"), String))
                        End If
                    End If
                    Me.ObtenerDatosDetalleComprobantesBaja(writer, prefixCbc, prefixSac, cadCbc, cadSac, drFila.Item("tipcomp"), drFila.Item("seriecomp"), drFila.Item("corrcomp"), i, "ERROR EN EL SISTEMA")
                Next
                '</VoidedDocuments>
                writer.WriteEndElement()
                writer.WriteEndDocument()
            End Using
            Me.AgregarFirma(rutaFE, nombre, "", "", True, "RA")
            Using zip As ZipFile = New ZipFile(System.Text.UTF8Encoding.UTF8)
                zip.AddFile(rutaFE.Trim() & nombre.Trim() & ".XML", "")
                zip.Save(rutaFE.Trim() & nombre.Trim() & ".zip")
            End Using
            ticket = Me.EnviarBajaXML(rutaFE, nombre, definicion)
            odComprobanteElectronicoBath.AdicionarComprobanteBath(dtCab, fechaGeneracion, nombre, definicion, True, ticket, usuario, "", "", PrefijoID)
            'EnviarXMLGetStatus(rutaFE, ticket)
        Catch ex As Exception
            If ticket Is Nothing Then
                Throw ex
            Else
                Throw New Exception("Ticket generado: " & ticket & ". Pero existe error: " & ex.Message)
            End If
        Finally
            If File.Exists(rutaFE.Trim() & nombre.Trim() & ".xml") Then
                File.Delete(rutaFE.Trim() & nombre.Trim() & ".xml")
            End If
        End Try
        Return ticket
    End Function

    Private Function ObtenerDatosDetalleComprobantesBaja(ByVal writer As XmlWriter, ByVal prefixCbc As String, ByVal prefixSac As String, ByVal cadCbc As String, ByVal cadSac As String, ByVal tipComp As String, ByVal serieComp As String, ByVal corrComp As String, ByVal item As Integer, ByVal Motivo As String) As XmlWriter
        '<sac:VoidedDocumentsLine>
        writer.WriteStartElement(prefixSac, "VoidedDocumentsLine", cadSac)
        '<cbc:LineID>1</cbc:LineID>
        writer.WriteElementString("LineID", cadCbc, item)
        '<cbc:DocumentTypeCode>01</cbc:DocumentTypeCode>
        writer.WriteElementString("DocumentTypeCode", cadCbc, tipComp)
        '<sac:DocumentSerialID>F001</sac:DocumentSerialID>
        writer.WriteElementString("DocumentSerialID", cadSac, serieComp)
        '<sac:DocumentNumberID>1</sac:DocumentNumberID>
        writer.WriteElementString("DocumentNumberID", cadSac, corrComp)
        '<sac:VoidReasonDescription>ERROR EN SISTEMA</sac:VoidReasonDescription>
        writer.WriteElementString("VoidReasonDescription", cadSac, Motivo)
        '</sac:VoidedDocumentsLine>        
        writer.WriteEndElement()
        Return writer
    End Function

    Private Function EnviarBajaXML(ByVal rutaFE As String, ByVal Nombre As String, ByRef definicion As String) As String
        Dim clienteRemotoObj As New sFacturacion.billServiceClient
        Dim datos As New sFacturacion.sendSummaryResponse
        Dim envio As New sFacturacion.sendSummaryRequest

        Dim dCatalago As New d_CatalagoCodigoSunat
        Dim oeCatalago As e_CatalagoCodigoSunat
        'Dim TablaFEADObj As New FacturacionElectronicaAD(mCadenaConexion)
        Dim cadError As String
        Try
            envio.contentFile = My.Computer.FileSystem.ReadAllBytes(rutaFE & Nombre & ".zip")
            envio.fileName = Nombre & ".zip"
            clienteRemotoObj.Open()
            'datos.ticket = clienteRemotoObj.sendSummary(envio.fileName, envio.contentFile)
            datos.ticket = clienteRemotoObj.sendSummary(envio.fileName, envio.contentFile, "")
            definicion = EncodeArrayBase64(envio.contentFile)
        Catch ex As System.ServiceModel.FaultException
            oeCatalago = New e_CatalagoCodigoSunat
            oeCatalago.CodigoTabla = "018" : oeCatalago.CodigoElemento = ex.Code.Name.ToString.Replace("soap-env-Server.", "").Trim
            'cadError = TablaFEADObj.ObtenerDescripcionPorCodigoSistema("018", ex.Code.Name.ToString.Replace("soap-env-Server.", "").Trim)
            cadError = dCatalago.Obtener(oeCatalago).Descripcion
            If cadError.Trim <> "" Then
                Throw New Exception("Error al enviar documento a la SUNAT: " & cadError)
            Else
                Throw New Exception("Error al enviar documento a la SUNAT: " & ex.Code.Name.ToString)
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return datos.ticket
    End Function

    Public Function EnviarXMLGetStatus(ByVal rutaFE As String, ByVal ticket As String, ByVal PrefijoID As String) As Boolean
        Dim clienteRemotoObj As New sFacturacion.billServiceClient
        Dim datos As New sFacturacion.getStatusResponse
        Dim envio As New sFacturacion.getStatusRequest
        ''Dim TablaFEADObj As New LogicaNegocio.FacturacionElectronicaAD(mCadenaConexion)
        ''Dim TablaFE2ADObj As New LogicaNegocio.FacturacionElectronica(mCadenaConexion)
        Dim xmlDoc As New XmlDocument()
        Dim msjError As String
        Dim cdrXML As String = ""
        Dim cadError As String
        'Dim dtCab As DataTable = Nothing
        Dim dtCab As New List(Of e_ComprobanteElectronicoBath)
        'Dim dtDet As DataTable = Nothing
        Dim dtDet As New List(Of e_ComprobanteElectronicoBath_Detalle)
        Dim Nombre As String = ""
        Dim fsRpta As FileStream = Nothing
        Dim flagError As Boolean = False
        Dim oeComprobanteBath As e_ComprobanteElectronicoBath
        Dim oeComprobanteBathDet As e_ComprobanteElectronicoBath_Detalle
        Dim odComprobanteBath As New d_ComprobanteElectronicoBath
        Dim odComprobanteBathDet As New d_ComprobanteElectronicoBath_Detalle
        Dim dCatalago As New d_CatalagoCodigoSunat
        Dim oeCatalago As e_CatalagoCodigoSunat
        Try
            oeComprobanteBath = New e_ComprobanteElectronicoBath
            oeComprobanteBath.TipoReferencia = "1"
            oeComprobanteBath.TipoOperacion = ""
            oeComprobanteBath.Ticket = ticket
            dtCab = odComprobanteBath.Listar(oeComprobanteBath)
            If dtCab.Count = 0 Then
                Throw New Exception("Numero de ticket no existe")
            End If
            Nombre = dtCab.Item(0).nombrexml
            fsRpta = New FileStream(rutaFE & "R-" & Nombre & ".zip", FileMode.Create)
            oeComprobanteBathDet = New e_ComprobanteElectronicoBath_Detalle
            oeComprobanteBathDet.IdBath = dtCab.Item(0).Id
            dtDet = odComprobanteBathDet.Listar(oeComprobanteBathDet)
            envio.ticket = ticket
            clienteRemotoObj.Open()

            datos.status = clienteRemotoObj.getStatus(envio.ticket)
            If datos.status.statusCode.Trim <> "98" Then
                fsRpta.Write(datos.status.content, 0, datos.status.content.Length)
                fsRpta.Close()
                Me.Extraer(rutaFE, Nombre)
                xmlDoc.PreserveWhitespace = False
                xmlDoc.Load(rutaFE & "R-" & Nombre & ".XML")
                cdrXML = xmlDoc.OuterXml.ToString.Trim
                msjError = VerificarSiExisteError(xmlDoc.DocumentElement)
                If msjError <> "" Then
                    Throw New Exception("Comprobante rechazado por la SUNAT: " & msjError)
                End If
            Else
                Throw New Exception("Ticket se encuentra en proceso, por favor intente mas tarde!!!")
            End If
        Catch ex As System.ServiceModel.FaultException
            flagError = True
            oeCatalago = New e_CatalagoCodigoSunat
            oeCatalago.CodigoTabla = "018" : oeCatalago.CodigoElemento = ex.Code.Name.ToString.Replace("soap-env-Server.", "").Trim
            cadError = dCatalago.Obtener(oeCatalago).Descripcion
            'cadError = TablaFEADObj.ObtenerDescripcionPorCodigoSistema("018", ex.Code.Name.ToString.Replace("soap-env-Server.", "").Trim)
            If cadError.Trim <> "" Then
                Throw New Exception("Error al consultar el ticket a la SUNAT: " & cadError)
            Else
                Throw New Exception("Error al consultar el ticket  a la SUNAT: " & ex.Code.Name.ToString)
            End If
        Catch ex As Exception
            flagError = True
            Throw ex
        Finally
            If Not fsRpta Is Nothing Then
                fsRpta.Close()
            End If
            If (Not (dtCab Is Nothing)) And (Not (dtDet Is Nothing)) Then
                If cdrXML.Trim <> "" Then
                    odComprobanteBath.ActualizarEstadoBath(dtCab, dtDet, cdrXML, flagError, dtCab.Item(0).IndBaja, PrefijoID)
                End If
            End If
            If File.Exists(rutaFE & "R-" & Nombre & ".xml") Then
                File.Delete(rutaFE & "R-" & Nombre & ".xml")
            End If
        End Try
        Return True
    End Function

    Public Function GenerarXmlComprobantesBath_2018(ByVal dtCab As DataTable, dtRow As DataTable, ByVal fechaGeneracion As DateTime, ByVal rutaFE As String, ByVal usuario As String, b_Baja As Boolean, ByVal PrefijoID As String) As String
        Dim nombre As String = ""
        Dim settings As XmlWriterSettings = New XmlWriterSettings()
        Dim prefixCac As String
        Dim prefixCbc As String
        Dim prefixDs As String
        Dim prefixExt As String
        Dim prefixSac As String
        Dim cadCac As String = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"
        Dim cadCbc As String = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"
        Dim cadCcts As String = "urn:un:unece:uncefact:documentation:2"
        Dim cadDs As String = "http://www.w3.org/2000/09/xmldsig#"
        Dim cadExt As String = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2"
        Dim cadQdt As String = "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2"
        Dim cadSac As String = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1"
        Dim cadUdt As String = "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2"
        Dim cadXsi As String = "http://www.w3.org/2001/XMLSchema-instance"
        Dim definicion As String = ""
        Dim ticket As String = Nothing
        Dim i As Integer = 0
        Dim correlativo As String
        Dim dtDocOri As DataTable = Nothing '****
        Dim dCatalogo As New d_CatalagoCodigoSunat
        Dim oeCatalago As e_CatalagoCodigoSunat
        Dim odComprobanteElectronicoBath As New d_ComprobanteElectronicoBath
        Dim oeComprobanteElectronicoBath As e_ComprobanteElectronicoBath
        Dim ListaBath As New List(Of e_ComprobanteElectronicoBath)
        Dim flagME As Boolean
        Dim moneda As String
        Dim TipDoc As String

        Try

            rutaFE = rutaFE ' & dtCab.Rows(0).Item("ABT").ToString & "\"
            oeComprobanteElectronicoBath = New e_ComprobanteElectronicoBath
            oeComprobanteElectronicoBath.TipoOperacion = ""
            'oeComprobanteElectronicoBath.TipoReferencia = 1
            oeComprobanteElectronicoBath.FechaEnvio = fechaGeneracion
            oeComprobanteElectronicoBath.IndBaja = False

            oeComprobanteElectronicoBath.IndBaja = False

            ListaBath = odComprobanteElectronicoBath.Listar(oeComprobanteElectronicoBath)
            correlativo = ListaBath.Count + 1

            'correlativo = facturacionADObj.ObtenerCorrelativo(False, fechaGeneracion).ToString.Trim
            oeCatalago = New e_CatalagoCodigoSunat
            oeCatalago.CodigoTabla = "017" : oeCatalago.CodigoElemento = "001"
            nombre = dCatalogo.Obtener(oeCatalago).Descripcion & "-RC-" & CType(fechaGeneracion, Date).Year.ToString().PadLeft(2, "0").Trim() & CType(fechaGeneracion, Date).Month.ToString().PadLeft(2, "0").Trim() & CType(fechaGeneracion, Date).Day.ToString().PadLeft(2, "0").Trim() & "-" & correlativo.Trim
            settings.Indent = True
            ' Create XmlWriter.
            settings.Encoding = System.Text.UTF8Encoding.UTF8
            Using writer As XmlWriter = XmlWriter.Create(rutaFE.Trim() & nombre.Trim() & ".XML", settings)
                prefixCac = writer.LookupPrefix(cadCac)
                prefixExt = writer.LookupPrefix(cadExt)
                prefixSac = writer.LookupPrefix(cadSac)
                prefixCbc = writer.LookupPrefix(cadCbc)
                prefixDs = writer.LookupPrefix(cadDs)
                ' Begin writing.
                writer.WriteStartDocument()
                '<SummaryDocuments xmlns="urn:sunat:names:specification:ubl:peru:schema:xsd:SummaryDocuments-1" xmlns:cac="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2" xmlns:cbc="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2" xmlns:ds="http://www.w3.org/2000/09/xmldsig#" xmlns:ext="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2" xmlns:sac="urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="urn:sunat:names:specification:ubl:peru:schema:xsd:InvoiceSummary-1 D:\UBL_SUNAT\SUNAT_xml_20110112\20110112\xsd\maindoc\UBLPE-InvoiceSummary-1.0.xsd">
                writer.WriteStartElement("SummaryDocuments", "urn:sunat:names:specification:ubl:peru:schema:xsd:SummaryDocuments-1") ' Root.
                writer.WriteAttributeString("xmlns", "cac", Nothing, cadCac)
                writer.WriteAttributeString("xmlns", "cbc", Nothing, cadCbc)
                writer.WriteAttributeString("xmlns", "ccts", Nothing, cadCcts)
                writer.WriteAttributeString("xmlns", "ds", Nothing, cadDs)
                writer.WriteAttributeString("xmlns", "ext", Nothing, cadExt)
                writer.WriteAttributeString("xmlns", "qdt", Nothing, cadQdt)
                writer.WriteAttributeString("xmlns", "sac", Nothing, cadSac)
                writer.WriteAttributeString("xmlns", "udt", Nothing, cadUdt)
                writer.WriteAttributeString("xmlns", "xsi", Nothing, cadXsi)
                Me.ObtenerExtensiones(writer, prefixExt, prefixCbc, prefixDs, cadExt, cadCbc, cadDs, Nothing, Nothing, "", False, True, 0)
                Me.ObtenerDatosCabeceraResumenBoletas_2018(writer, prefixCbc, prefixCac, cadCbc, cadCac, dtCab, "", "", False, False, False, True, fechaGeneracion, 0, Nothing, "RC", correlativo.Trim)

                For Each drFila As DataRow In dtCab.Rows
                    If dtCab.Rows(0).Item("codmon").ToString.Trim <> "SOL" Then
                        flagME = True
                    End If
                    oeCatalago = New e_CatalagoCodigoSunat
                    oeCatalago.CodigoTabla = "002" : oeCatalago.CodigoElemento = dtCab.Rows(0).Item("codmon").ToString.Trim
                    moneda = dCatalogo.Obtener(oeCatalago).CodigoSunat
                    oeCatalago = New e_CatalagoCodigoSunat
                    oeCatalago.CodigoTabla = "001" : oeCatalago.CodigoElemento = dtCab.Rows(0).Item("tipcomp").ToString().Trim
                    TipDoc = dCatalogo.Obtener(oeCatalago).CodigoAlterno
                    i = i + 1
                    Me.ObtenerDatosDetalleComprobantesBath_2018(writer, prefixCbc, prefixSac, prefixCac, cadCbc, cadSac, cadCac, drFila, i, moneda, flagME, b_Baja)
                Next

                '</SummaryDocuments>
                writer.WriteEndElement()
                writer.WriteEndDocument()
            End Using

            Me.AgregarFirma(rutaFE, nombre, "", "", True, "RC")

            Using zip As ZipFile = New ZipFile(System.Text.UTF8Encoding.UTF8)
                zip.AddFile(rutaFE.Trim() & nombre.Trim() & ".XML", "")
                zip.Save(rutaFE.Trim() & nombre.Trim() & ".zip")
            End Using

            ticket = Me.EnviarBajaXML(rutaFE, nombre, definicion)
            odComprobanteElectronicoBath.AdicionarComprobanteBath(dtCab, fechaGeneracion, nombre, definicion, b_Baja, ticket, usuario, "", "", PrefijoID)
        Catch ex As Exception
            If ticket Is Nothing Then
                Throw ex
            Else
                Throw New Exception("Ticket generado: " & ticket & ". Consulte el ticket mas tarde!!!")
            End If
        Finally
            If File.Exists(rutaFE.Trim() & nombre.Trim() & ".xml") Then
                File.Delete(rutaFE.Trim() & nombre.Trim() & ".xml")
            End If
        End Try
        Return ticket
    End Function

    Private Function ObtenerDatosCabeceraResumenBoletas_2018(ByVal writer As XmlWriter, ByVal prefixCbc As String, ByVal prefixCac As String, ByVal cadCbc As String, ByVal cadCac As String, ByVal dtCab As DataTable, ByVal TipDoc As String, ByVal CodMon As String, ByVal flagNC As Boolean, ByVal flagME As Boolean, ByVal flagND As Boolean, ByVal flagBaja As Boolean, ByVal fechaGeneracion As DateTime, ByVal factorC As Double, ByVal dtDocOri As DataTable, ByVal prefijo As String, ByVal correlativo As String) As XmlWriter

        Try
            Dim oeCatalogo As New e_CatalagoCodigoSunat
            Dim dCatalogo As New d_CatalagoCodigoSunat
            writer.WriteElementString("UBLVersionID", cadCbc, "2.0")
            writer.WriteElementString("CustomizationID", cadCbc, "1.1")
            writer.WriteElementString("ID", cadCbc, prefijo.Trim & "-" & CType(fechaGeneracion, Date).Year.ToString().PadLeft(2, "0").Trim() & CType(fechaGeneracion, Date).Month.ToString().PadLeft(2, "0").Trim() & CType(fechaGeneracion, Date).Day.ToString().PadLeft(2, "0").Trim() & "-" & correlativo.Trim)
            writer.WriteElementString("ReferenceDate", cadCbc, CType(dtCab.Rows(0).Item("feccomp"), Date).Year.ToString().PadLeft(2, "0").Trim() & "-" & CType(dtCab.Rows(0).Item("feccomp"), Date).Month.ToString().PadLeft(2, "0").Trim() & "-" & CType(dtCab.Rows(0).Item("feccomp"), Date).Day.ToString().PadLeft(2, "0").Trim())
            writer.WriteElementString("IssueDate", cadCbc, CType(fechaGeneracion, Date).Year.ToString().PadLeft(2, "0").Trim() & "-" & CType(fechaGeneracion, Date).Month.ToString().PadLeft(2, "0").Trim() & "-" & CType(fechaGeneracion, Date).Day.ToString().PadLeft(2, "0").Trim())

            writer.WriteStartElement(prefixCac, "Signature", cadCac)

            writer.WriteElementString("ID", cadCbc, "IDSignSP")

            writer.WriteStartElement(prefixCac, "SignatoryParty", cadCac)

            writer.WriteStartElement(prefixCac, "PartyIdentification", cadCac)

            oeCatalogo = New e_CatalagoCodigoSunat
            oeCatalogo.CodigoTabla = "017" : oeCatalogo.CodigoElemento = "001"
            writer.WriteElementString("ID", cadCbc, dCatalogo.Obtener(oeCatalogo).Descripcion)
            writer.WriteEndElement()

            writer.WriteStartElement(prefixCac, "PartyName", cadCac)
            oeCatalogo = New e_CatalagoCodigoSunat
            oeCatalogo.CodigoTabla = "017" : oeCatalogo.CodigoElemento = "013"
            writer.WriteElementString("Name", cadCbc, dCatalogo.Obtener(oeCatalogo).Descripcion)

            writer.WriteEndElement()
            writer.WriteEndElement()

            writer.WriteStartElement(prefixCac, "DigitalSignatureAttachment", cadCac)
            writer.WriteStartElement(prefixCac, "ExternalReference", cadCac)

            writer.WriteElementString("URI", cadCbc, "#SignatureSP")

            writer.WriteEndElement()
            writer.WriteEndElement()
            writer.WriteEndElement()

            writer.WriteStartElement(prefixCac, "AccountingSupplierParty", cadCac)
            oeCatalogo = New e_CatalagoCodigoSunat
            oeCatalogo.CodigoTabla = "017" : oeCatalogo.CodigoElemento = "001"
            writer.WriteElementString("CustomerAssignedAccountID", cadCbc, dCatalogo.Obtener(oeCatalogo).Descripcion)
            oeCatalogo = New e_CatalagoCodigoSunat
            oeCatalogo.CodigoTabla = "017" : oeCatalogo.CodigoElemento = "002"
            writer.WriteElementString("AdditionalAccountID", cadCbc, dCatalogo.Obtener(oeCatalogo).Descripcion)
            writer.WriteStartElement(prefixCac, "Party", cadCac)
            writer.WriteStartElement(prefixCac, "PartyName", cadCac)
            oeCatalogo = New e_CatalagoCodigoSunat
            oeCatalogo.CodigoTabla = "017" : oeCatalogo.CodigoElemento = "010"
            writer.WriteElementString("Name", cadCbc, dCatalogo.Obtener(oeCatalogo).Descripcion)
            writer.WriteEndElement()

            writer.WriteStartElement(prefixCac, "PartyLegalEntity", cadCac)
            oeCatalogo = New e_CatalagoCodigoSunat
            oeCatalogo.CodigoTabla = "017" : oeCatalogo.CodigoElemento = "013"
            writer.WriteElementString("RegistrationName", cadCbc, dCatalogo.Obtener(oeCatalogo).Descripcion)

            writer.WriteEndElement()

            writer.WriteEndElement()

            writer.WriteEndElement()
            Return writer
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ObtenerDatosDetalleComprobantesBath_2018(ByVal writer As XmlWriter, ByVal prefixCbc As String, ByVal prefixSac As String, ByVal prefixCac As String, ByVal cadCbc As String, ByVal cadSac As String, ByVal cadCac As String, ByVal drFila As DataRow, ByVal item As Integer, ByVal moneda As String, ByVal flagME As Boolean, b_Baja As Boolean) As XmlWriter
        '<sac:SummaryDocumentsLine>

        writer.WriteStartElement(prefixSac, "SummaryDocumentsLine", cadSac)
        writer.WriteElementString("LineID", cadCbc, item)
        writer.WriteElementString("DocumentTypeCode", cadCbc, drFila.Item("tipcomp"))
        writer.WriteElementString("ID", cadCbc, drFila.Item("seriecomp") & "-" & drFila.Item("corrcomp")) 'SERIE - NUMERO

        writer.WriteStartElement(prefixCac, "AccountingCustomerParty", cadCac)
        writer.WriteElementString("CustomerAssignedAccountID", cadCbc, drFila.Item("dociden").ToString) ' DOCUMENTO DE IDENTIDAD
        writer.WriteElementString("AdditionalAccountID", cadCbc, drFila.Item("tipdociden")) 'TIPO DE DOCUMENTO DE IDENTIDAD
        writer.WriteEndElement()


        'DOCUMENTO ASOCIADO EN EL CASO QUE SEA NOTA DE CREDITO O DEBITO
        If drFila.Item("tipcomp") = "07" Or drFila.Item("tipcomp") = "08" Then
            writer.WriteStartElement(prefixCac, "BillingReference", cadCac)
            writer.WriteStartElement(prefixCac, "InvoiceDocumentReference", cadCac)
            writer.WriteElementString("ID", cadCbc, drFila.Item("seriedocasoc") & "-" & drFila.Item("corrdocasoc")) 'SERIE - NUMERO DOCUMENTO ASOCIADO
            writer.WriteElementString("DocumentTypeCode", cadCbc, drFila.Item("tipodocasoc")) ' TIPO DOCUMENTO
            writer.WriteEndElement()
            writer.WriteEndElement()
        End If


        'Estado del ítem
        writer.WriteStartElement(prefixCac, "Status", cadCac)
        If b_Baja Then
            writer.WriteElementString("ConditionCode", cadCbc, 3) 'CODIGO ESTADO ITEM ANULADO
        Else
            writer.WriteElementString("ConditionCode", cadCbc, 1) 'CODIGO ESTADO ITEM ADICIONAR
        End If
        writer.WriteEndElement()

        'Importe total de la venta, cesión en uso o del servicio prestado
        writer.WriteStartElement(prefixSac, "TotalAmount", cadSac)
        writer.WriteAttributeString("currencyID", moneda)
        writer.WriteValue(CType(drFila.Item("importeventa"), Double).ToString("F2"))
        writer.WriteEndElement()

        'Total valor de venta - operaciones gravadas 

        If CType(drFila.Item("valopergravadas"), Double) > 0 Then
            writer.WriteStartElement(prefixSac, "BillingPayment", cadSac)
            writer.WriteStartElement(prefixCbc, "PaidAmount", cadCbc)
            writer.WriteAttributeString("currencyID", moneda)
            writer.WriteValue(CType(drFila.Item("valopergravadas"), Double).ToString("F2"))
            writer.WriteEndElement()
            writer.WriteElementString("InstructionID", cadCbc, "01")
            writer.WriteEndElement()
        End If


        'Total valor de venta - operaciones exoneradas
        If CType(drFila.Item("valoperexoneradas"), Double) > 0 Then
            writer.WriteStartElement(prefixSac, "BillingPayment", cadSac)
            writer.WriteStartElement(prefixCbc, "PaidAmount", cadCbc)
            writer.WriteAttributeString("currencyID", moneda)
            writer.WriteValue(CType(drFila.Item("valoperexoneradas"), Double).ToString("F2"))
            writer.WriteEndElement()
            writer.WriteElementString("InstructionID", cadCbc, "02")
            writer.WriteEndElement()
        End If


        'Total valor de venta - operaciones inafectas
        If CType(drFila.Item("valoperinafectas"), Double) > 0 Then
            writer.WriteStartElement(prefixSac, "BillingPayment", cadSac)
            writer.WriteStartElement(prefixCbc, "PaidAmount", cadCbc)
            writer.WriteAttributeString("currencyID", moneda)
            writer.WriteValue(CType(drFila.Item("valoperinafectas"), Double).ToString("F2"))
            writer.WriteEndElement()
            writer.WriteElementString("InstructionID", cadCbc, "03")
            writer.WriteEndElement()
        End If



        'IGV
        writer.WriteStartElement(prefixSac, "TaxTotal", cadCac)
        writer.WriteStartElement(prefixCbc, "TaxAmount", cadCbc)
        writer.WriteAttributeString("currencyID", moneda)
        writer.WriteValue(CType(drFila.Item("igv"), Double).ToString("F2"))
        writer.WriteEndElement()
        writer.WriteStartElement(prefixSac, "TaxSubtotal", cadCac)
        writer.WriteStartElement(prefixCbc, "TaxAmount", cadCbc)
        writer.WriteAttributeString("currencyID", moneda)
        writer.WriteValue(CType(drFila.Item("igv"), Double).ToString("F2"))
        writer.WriteEndElement()
        writer.WriteStartElement(prefixSac, "TaxCategory", cadCac)
        writer.WriteStartElement(prefixSac, "TaxScheme", cadCac)
        writer.WriteElementString("ID", cadCbc, "1000")
        writer.WriteElementString("Name", cadCbc, "IGV")
        writer.WriteElementString("TaxTypeCode", cadCbc, "VAT")
        writer.WriteEndElement()
        writer.WriteEndElement()
        writer.WriteEndElement()
        writer.WriteEndElement()

        writer.WriteEndElement()

        Return writer
    End Function

    Public Function GenerarXmlFacturaElectronica_Resumen(ByVal dtCab As DataTable, ByVal dtAnt As DataTable, ByVal dtDet As DataTable, ByVal rutaFE As String, ByVal usuario As String) As Boolean
        Dim nombre As String = ""
        Dim valorCodBarras As String = ""
        Dim dtDocOri As DataTable = Nothing
        Dim firma As String = ""
        Dim valorResumen As String = ""
        Dim flagME As Boolean = False
        Dim flagError As Boolean = False
        Dim boolRetorno As Boolean = False
        Dim tipoid As String = ""
        Dim odComprobanteElectronico As New d_ComprobanteElectronico
        Dim oeComprobanteElectronico As e_ComprobanteElectronico

        'Dim facturacionObj As New LogicaNegocio.FacturacionElectronica(mCadenaConexion)
        Try
            Me.GenerarXmlFacturaElectronica2(dtCab, dtAnt, dtDet, rutaFE, nombre, valorResumen, firma, flagME, False)
            Using zip As ZipFile = New ZipFile(System.Text.UTF8Encoding.UTF8)
                zip.AddFile(rutaFE.Trim() & nombre.Trim() & ".XML", "")
                zip.Save(rutaFE.Trim() & nombre.Trim() & ".zip")
            End Using
            valorCodBarras = PreparaCodigoBarras(dtCab, flagME, valorResumen, firma, dtCab.Rows(0).Item("factorc"))
            oeComprobanteElectronico = New e_ComprobanteElectronico
            oeComprobanteElectronico.TipoOperacion = ""
            oeComprobanteElectronico.IdReferencia = dtCab.Rows(0).Item("idcomp")
            oeComprobanteElectronico.TipoReferencia = 1
            oeComprobanteElectronico.xmlbase64 = ""
            oeComprobanteElectronico.valorcodbarras = valorCodBarras
            oeComprobanteElectronico.cdrxml = ""
            oeComprobanteElectronico.nombrexml = nombre
            oeComprobanteElectronico.UsuarioCrea = usuario
            oeComprobanteElectronico.ValorResumen = valorResumen

            odComprobanteElectronico.AdicionarComprobanteElectronico(oeComprobanteElectronico, Nothing)
        Catch ex As Exception
            flagError = True
            Throw ex
        Finally
            If File.Exists(rutaFE.Trim() & nombre.Trim() & ".xml") Then
                File.Delete(rutaFE.Trim() & nombre.Trim() & ".xml")
            End If
        End Try
        'Me.GenerarPDF(dtCab, dtDet, rutaFE, nombre, valorCodBarras, flagME)
        'Me.EnviarCorreo("", "", "Comprobante de Pago", "Estimado cliente se adjunta su comprobante de pago", "", rutaFE & nombre & ".pdf")
        Return boolRetorno
    End Function

    Public Function ConsultarDocumento(dsComprobante As DataSet, RutaFE As String, usuario As String) As Boolean
        Dim dtCab As DataTable
        ' Dim dtDet As DataTable
        Dim IdTipoDoc As String = ""
        Dim Serie As String = ""
        Dim Corr As String = ""
        Dim Ruc As String = ""
        Dim IdComp As String = ""
        Dim CodEmpr As String = ""
        Dim CodCentro As String = ""
        Dim Abrt As String = ""

        dtCab = dsComprobante.Tables(0).Copy
        If dtCab.Rows.Count = 0 Then Throw New Exception("No presenta cabecera")
        IdTipoDoc = dtCab.Rows(0).Item("tipcomp").ToString.Trim
        Serie = dtCab.Rows(0).Item("seriecomp").ToString.Trim
        Corr = dtCab.Rows(0).Item("corrcomp").ToString.Trim.PadLeft(8, "0").Trim()
        Ruc = "20479729141" 'dtCab.Rows(0).Item("nroid").ToString.Trim
        IdComp = dtCab.Rows(0).Item("idcomp").ToString.Trim
        ' CodEmpr = dtCab.Rows(0).Item("codempr").ToString.Trim
        'CodCentro = dtCab.Rows(0).Item("codcentro").ToString.Trim
        'Abrt = dtCab.Rows(0).Item("ABT").ToString()

        Dim clienteRemotoObj As New sConsultarFactura.billServiceClient
        Dim datos As New sConsultarFactura.getStatusCdrResponse()
        Dim envio As New sConsultarFactura.getStatusCdrRequest
        Dim xmlDoc As New XmlDocument()
        Dim cadError As String = ""
        Dim cdrXML As String
        Dim xmlBase64, valorcodbarras, valorResumen, firma As String
        Dim flagError, flagME As Boolean
        Dim fsRpta As FileStream
        Dim Nombre As String = ""
        Dim definicion As String = ""
        Dim dtDocOri As DataTable = Nothing
        Dim boolRetorno As Boolean = False
        Dim tipoid As String = ""
        Dim odComprobanteElectronico As New d_ComprobanteElectronico
        Dim oeComprobanteElectronico As e_ComprobanteElectronico
        Dim oeDocumento As e_MovimientoDocumento
        Nombre = Ruc & "-" & IdTipoDoc & "-" & Serie & "-" & Corr
        Try
            'ucMsje.MsjeVisible = False
            ' dtCab = facturacionADOBj.ObtenerCabeceraComprobante(Me.txtSerie.Text, Me.txtCorrelativo.Text, ddlTipoDocumento.SelectedValue.ToString.Trim)
            If dtCab.Rows.Count > 0 Then
                envio.rucComprobante = Ruc
                envio.tipoComprobante = IdTipoDoc
                envio.serieComprobante = Serie
                envio.numeroComprobante = Corr
                clienteRemotoObj.Open()
                System.Net.ServicePointManager.Expect100Continue = False
                datos.statusCdr = clienteRemotoObj.getStatusCdr(envio.rucComprobante, envio.tipoComprobante, envio.serieComprobante, envio.numeroComprobante)
                If Not datos.statusCdr.content Is Nothing Then
                    fsRpta = New FileStream(RutaFE & "R-" & Nombre & ".zip", FileMode.Create)
                    fsRpta.Write(datos.statusCdr.content, 0, datos.statusCdr.content.Length)
                    fsRpta.Close()
                    Me.Extraer(RutaFE, Nombre)
                    xmlDoc.PreserveWhitespace = False
                    xmlDoc.Load(RutaFE & "R-" & Nombre & ".XML")
                    cdrXML = xmlDoc.OuterXml.ToString.Trim
                    cadError = VerificarSiExisteError(xmlDoc.DocumentElement)
                    'dsComprobante = facturacionADOBj.ObtenerComprobanteFE(dtCab.Rows(0).Item("idcomp"))
                    valorcodbarras = ""
                    valorResumen = ""
                    firma = ""
                    If Not System.IO.File.Exists(RutaFE & Nombre.Trim() & ".XML") Then
                        GenerarXmlFacturaElectronica2(dsComprobante.Tables(0), dsComprobante.Tables(2), dsComprobante.Tables(1), RutaFE, "", valorResumen, firma, flagME, True)
                        Using zip As ZipFile = New ZipFile(System.Text.UTF8Encoding.UTF8)
                            zip.AddFile(RutaFE.Trim() & Nombre.Trim() & ".XML", "")
                            zip.Save(RutaFE.Trim() & Nombre.Trim() & ".zip")
                        End Using
                    End If
                    xmlBase64 = EncodeArrayBase64(My.Computer.FileSystem.ReadAllBytes(RutaFE & Nombre & ".xml"))
                    If cadError.Trim <> "" Then
                        cadError = "Comprobante Rechazado: " & cadError.Trim
                        flagError = True
                    Else
                        flagError = False
                    End If
                    If cdrXML.Trim = "" Then
                        Throw New Exception(cadError)
                    Else
                        valorcodbarras = PreparaCodigoBarras(dsComprobante.Tables(0), flagME, valorResumen, firma, dsComprobante.Tables(0).Rows(0).Item("factorc"))
                        oeComprobanteElectronico = New e_ComprobanteElectronico
                        oeComprobanteElectronico.TipoOperacion = ""
                        oeComprobanteElectronico.IdReferencia = dtCab.Rows(0).Item("idcomp")
                        oeComprobanteElectronico.TipoReferencia = 1
                        oeComprobanteElectronico.xmlbase64 = xmlBase64
                        oeComprobanteElectronico.valorcodbarras = valorcodbarras
                        oeComprobanteElectronico.cdrxml = cdrXML
                        oeComprobanteElectronico.nombrexml = Nombre
                        oeComprobanteElectronico.UsuarioCrea = usuario
                        oeComprobanteElectronico.ValorResumen = valorResumen
                        oeDocumento = New e_MovimientoDocumento
                        oeDocumento.TipoOperacion = "AFE"
                        oeDocumento.Id = dtCab.Rows(0).Item("idcomp")
                        oeDocumento.IdUsuarioCrea = usuario
                        If flagError Then
                            oeDocumento.IndServicioMaterial = "R"
                        Else
                            oeDocumento.IndServicioMaterial = "A"
                        End If
                        odComprobanteElectronico.AdicionarComprobanteElectronico(oeComprobanteElectronico, oeDocumento)

                        If flagError Then
                            Throw New Exception(cadError)
                        Else
                            Return True
                        End If
                    End If
                Else
                    Throw New Exception(datos.statusCdr.statusMessage)
                End If
            Else
                Throw New Exception("Comprobante no existe")
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            If Not fsRpta Is Nothing Then
                fsRpta.Close()
            End If
            If System.IO.File.Exists(RutaFE & "R-" & Nombre.Trim() & ".XML") Then
                System.IO.File.Delete(RutaFE & "R-" & Nombre.Trim() & ".XML")
            End If

            If System.IO.File.Exists(RutaFE & Nombre.Trim() & ".XML") Then
                System.IO.File.Delete(RutaFE & Nombre.Trim() & ".XML")
            End If
            clienteRemotoObj.Close()
            System.Net.ServicePointManager.Expect100Continue = True
        End Try
    End Function

End Class
