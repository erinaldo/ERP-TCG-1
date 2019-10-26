Imports System.Xml
Imports System.IO
Imports System.Security.Cryptography.X509Certificates
Imports System.Security.Cryptography.Xml
Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports Ionic.Zip

Public Class s_Retencion

    Private odCatalago As d_CatalagoCodigoSunat
    Private odRetencionElectronica As d_ComprobanteElectronico
    Private odDetallePago As d_CuentaxPDocumentoRetencion
    Private odComunicaBaja As d_ComprobanteElectronicoBath

    ''' <summary>
    ''' Generar Archivo XML para Comprobante Electornico - Retencion
    ''' </summary>
    ''' <param name="dtCab">Data Table - Documento</param>
    ''' <param name="dtDet">Data Table - Detalle Documento</param>
    ''' <param name="rutaFE">Ruta de Servidor</param>
    ''' <param name="nombre">Nombre del Comprobante Electronico</param>
    ''' <param name="valorResumen">Resumen de Comprobante Electronico</param>
    ''' <param name="firma">Informacion de la Firma Digital</param>
    ''' <param name="esLote">Indicador de Lote</param>
    ''' <param name="usuario">Id Usuario</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GenerarXml(ByVal dtCab As DataTable, ByVal dtDet As DataTable, ByVal rutaFE As String, ByRef nombre As String, _
                               ByRef valorResumen As String, ByRef firma As String, ByVal esLote As Boolean, ByVal usuario As String) As Boolean
        'Create XmlWriterSettings.
        Dim settings As XmlWriterSettings = New XmlWriterSettings()
        Dim prefixCac As String, prefixCbc As String, prefixDs As String, prefixExt As String, prefixSac As String
        Dim cadCac As String = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"
        Dim cadCbc As String = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"
        Dim cadCcts As String = "urn:un:unece:uncefact:documentation:2"
        Dim cadDs As String = "http://www.w3.org/2000/09/xmldsig#"
        Dim cadExt As String = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2"
        Dim cadQdt As String = "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2"
        Dim cadSac As String = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1"
        Dim cadUdt As String = "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2"
        Dim cadXsi As String = "http://www.w3.org/2001/XMLSchema-instance"
        ''Dim facturacionADObj As New LogicaNegocioPercepcion.PercepcionAD(mCadenaConexion)
        ''Dim facturacionObj As New LogicaNegocioPercepcion.Percepcion(mCadenaConexion)
        Dim monedaSol, monedaDol As String
        Dim TipDoc As String
        Dim definicion As String = ""
        Dim valorCodBarras As String = ""
        Dim cdrXML As String = ""
        Dim flagError As Boolean = False
        Dim boolRetorno As Boolean = False
        Dim tipoid As String = ""
        Try
            odCatalago = New d_CatalagoCodigoSunat : odRetencionElectronica = New d_ComprobanteElectronico
            ''monedaSol = facturacionADObj.ObtenerCodigoSunatPorCodigoSistema("002", "SOL")
            monedaSol = odCatalago.Obtener(New e_CatalagoCodigoSunat With {.CodigoTabla = "002", .CodigoElemento = "SOL"}).CodigoSunat
            ''monedaDol = facturacionADObj.ObtenerCodigoSunatPorCodigoSistema("002", "DOL")
            monedaDol = odCatalago.Obtener(New e_CatalagoCodigoSunat With {.CodigoTabla = "002", .CodigoElemento = "DOL"}).CodigoSunat
            TipDoc = dtCab.Rows(0).Item("tipcomp").ToString()
            If dtCab.Rows(0).Item("nroid").ToString.Trim = "" Then
                Throw New Exception("No existe documento del cliente")
            End If
            ''tipoid = facturacionADObj.ObtenerCodigoSunatPorCodigoSistema("006", dtCab.Rows(0).Item("tipoid"))
            tipoid = odCatalago.Obtener(New e_CatalagoCodigoSunat With {.CodigoTabla = "006", .CodigoElemento = dtCab.Rows(0).Item("tipoid")}).CodigoSunat
            If tipoid.Trim = "" Then
                Throw New Exception("No existe tipo del documento " & dtCab.Rows(0).Item("tipoid").ToString().Trim & " del cliente")
            End If
            ''nombre = facturacionADObj.ObtenerDescripcionPorCodigoSistema("017", "001") & "-" & "20" & "-" & dtCab.Rows(0).Item("seriecomp").ToString().Trim() & "-" & dtCab.Rows(0).Item("corrcomp").ToString().PadLeft(8, "0").Trim()
            nombre = odCatalago.Obtener(New e_CatalagoCodigoSunat With {.CodigoTabla = "017", .CodigoElemento = "001"}).Descripcion & "-" & "20" & "-" & _
                dtCab.Rows(0).Item("seriecomp").ToString().Trim() & "-" & dtCab.Rows(0).Item("corrcomp").ToString().PadLeft(8, "0").Trim()
            settings.Indent = True
            ' Create XmlWriter.
            settings.Encoding = System.Text.UTF8Encoding.UTF8
            Using writer As XmlWriter = XmlWriter.Create(rutaFE.Trim() & "\Retencion\" & nombre.Trim() & ".XML", settings)
                prefixCac = writer.LookupPrefix(cadCac)
                prefixExt = writer.LookupPrefix(cadExt)
                prefixSac = writer.LookupPrefix(cadSac)
                prefixCbc = writer.LookupPrefix(cadCbc)
                prefixDs = writer.LookupPrefix(cadDs)
                ' Begin writing.
                writer.WriteStartDocument()
                '<Retention xmlns="urn:sunat:names:specification:ubl:peru:schema:xsd:Retention-1" xmlns:cac="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2" xmlns:cbc="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2" xmlns:ccts="urn:un:unece:uncefact:documentation:2" xmlns:ds="http://www.w3.org/2000/09/xmldsig#" xmlns:ext="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2" xmlns:qdt="urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2" xmlns:sac="urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1" xmlns:udt="urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
                writer.WriteStartElement("Retention", "urn:sunat:names:specification:ubl:peru:schema:xsd:Retention-1") ' Root.
                'writer.WriteStartElement("Perception") ' Root.
                writer.WriteAttributeString("xmlns", "cac", Nothing, cadCac)
                writer.WriteAttributeString("xmlns", "cbc", Nothing, cadCbc)
                writer.WriteAttributeString("xmlns", "ccts", Nothing, cadCcts)
                writer.WriteAttributeString("xmlns", "ds", Nothing, cadDs)
                writer.WriteAttributeString("xmlns", "ext", Nothing, cadExt)
                writer.WriteAttributeString("xmlns", "qdt", Nothing, cadQdt)
                writer.WriteAttributeString("xmlns", "sac", Nothing, cadSac)
                writer.WriteAttributeString("xmlns", "udt", Nothing, cadUdt)
                writer.WriteAttributeString("xmlns", "xsi", Nothing, cadXsi)
                ''Me.ObtenerExtensiones(writer, prefixExt, prefixSac, prefixCbc, prefixDs, cadExt, cadSac, cadCbc, cadDs, dtCab, dtDet, monedaSol.Trim(), False)
                fc_ObtenerExtensiones(writer, prefixExt, prefixSac, prefixCbc, prefixDs, cadExt)
                ''Me.ObtenerDatosCabecera(writer, prefixCbc, prefixCac, prefixSac, cadCbc, cadCac, cadSac, dtCab, TipDoc, monedaSol.Trim(), False, Nothing, "", "")
                fc_ObtenerDatosCabecera(writer, prefixCbc, prefixCac, prefixSac, cadCbc, cadCac, cadSac, dtCab, TipDoc, monedaSol.Trim(), False, Nothing, "", "")
                For Each drFila As DataRow In dtDet.Rows
                    ''Me.ObtenerDatosDetalle(writer, prefixSac, prefixCbc, prefixCac, cadCbc, cadCac, cadSac, dtCab.Rows(0).Item("seriecomp").ToString.Trim & "-" & dtCab.Rows(0).Item("corrcomp").ToString.Trim, drFila, monedaSol.Trim(), monedaDol)
                    fc_ObtenerDatosDetalle(writer, prefixSac, prefixCbc, prefixCac, cadCbc, cadCac, cadSac, dtCab.Rows(0).Item("idcomp").ToString.Trim, _
                                           drFila, monedaSol.Trim(), monedaDol)
                Next
                '</Retention>
                writer.WriteEndElement()
                writer.WriteEndDocument()
            End Using
            ''Me.AgregarFirma(rutaFE, nombre, valorResumen, firma, False, TipDoc)
            fc_AgregarFirma(rutaFE, nombre, valorResumen, firma, False, TipDoc)
            'Me.ValidarXML(rutaFE, nombre, dtCab.Rows(0).Item("tipcomp"))
            If esLote Then
                Dim xmlDoc As XmlDocument = New XmlDocument()
                xmlDoc.PreserveWhitespace = True
                xmlDoc.Load(rutaFE & "\Retencion\" & nombre & ".XML")
                'boolRetorno = xmlDoc.OuterXml.ToString.Trim
            End If
            Using zip As ZipFile = New ZipFile(System.Text.UTF8Encoding.UTF8)
                zip.AddFile(rutaFE.Trim() & "\Retencion\" & nombre.Trim() & ".XML", "")
                zip.Save(rutaFE.Trim() & "\Retencion\" & nombre.Trim() & ".zip")
            End Using
            ''definicion = Me.EnviarXML(rutaFE, nombre, cdrXML)
            definicion = fc_EnviarXML(rutaFE, nombre, cdrXML)
        Catch ex As Exception
            flagError = True
            Throw ex
        Finally
            If cdrXML.Trim <> "" Then
                ''valorCodBarras = PreparaCodigoBarras(dtCab, False, valorResumen, firma, 1)
                valorCodBarras = fc_PreparaCodigoBarras(dtCab, False, valorResumen, firma, 1)
                ''facturacionObj.AdicionarComprobanteElectronico(dtCab.Rows(0).Item("idcomp"), definicion, nombre, valorCodBarras, cdrXML, dtCab.Rows(0).Item("seriecomp").ToString.Trim & dtCab.Rows(0).Item("corrcomp").ToString.Trim, flagError, usuario)
                odRetencionElectronica.Guardar(New e_ComprobanteElectronico With {.TipoOperacion = "", .TipoReferencia = 2, .IdReferencia = dtCab.Rows(0).Item("idcomp"), _
                                                                                  .xmlbase64 = definicion, .nombrexml = nombre, .valorcodbarras = valorCodBarras, _
                                                                                  .ValorResumen = valorResumen, .cdrxml = cdrXML, .UsuarioCrea = usuario})
                boolRetorno = True
            End If
            If File.Exists(rutaFE.Trim() & "\Retencion\" & nombre.Trim() & ".xml") Then
                File.Delete(rutaFE.Trim() & "\Retencion\" & nombre.Trim() & ".xml")
            End If
            If File.Exists(rutaFE.Trim() & "\Retencion\" & "R-" & nombre.Trim() & ".xml") Then
                File.Delete(rutaFE.Trim() & "\Retencion\" & "R-" & nombre.Trim() & ".xml")
            End If
        End Try
        Return boolRetorno
    End Function

    Public Function GenerarXmlComprobantesBaja(ByVal dtCab As DataTable, ByVal fechaGeneracion As DateTime, ByVal rutaFE As String, ByVal usuario As String) As String
        ' Create XmlWriterSettings.
        Dim nombre As String = ""
        Dim settings As XmlWriterSettings = New XmlWriterSettings()
        Dim prefixCac As String, prefixCbc As String, prefixDs As String, prefixExt As String, prefixSac As String
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
        Dim ticket As String
        ''Dim facturacionADObj As New LogicaNegocioPercepcion.PercepcionAD(mCadenaConexion)
        ''Dim facturacion2ADObj As New LogicaNegocioPercepcion.Percepcion(mCadenaConexion)
        Dim i As Integer = 0
        Dim correlativo As String = ""
        Try
            odCatalago = New d_CatalagoCodigoSunat : odComunicaBaja = New d_ComprobanteElectronicoBath
            ''correlativo = facturacionADObj.ObtenerCorrelativo(True, fechaGeneracion).ToString.Trim
            correlativo = odComunicaBaja.Obtener(New e_ComprobanteElectronicoBath With {.TipoOperacion = "U", .TipoReferencia = 2, .IndBaja = True, .FechaEnvio = fechaGeneracion}).TipoReferencia
            ''nombre = facturacionADObj.ObtenerDescripcionPorCodigoSistema("017", "001") & "-RR-" & CType(fechaGeneracion, Date).Year.ToString().PadLeft(2, "0").Trim() & CType(fechaGeneracion, Date).Month.ToString().PadLeft(2, "0").Trim() & CType(fechaGeneracion, Date).Day.ToString().PadLeft(2, "0").Trim() & "-" & correlativo.Trim.PadLeft(5, "0")
            nombre = odCatalago.Obtener(New e_CatalagoCodigoSunat With {.CodigoTabla = "017", .CodigoElemento = "001"}).Descripcion & "-RR-" & _
                CType(fechaGeneracion, Date).Year.ToString().PadLeft(2, "0").Trim() & CType(fechaGeneracion, Date).Month.ToString().PadLeft(2, "0").Trim() & _
                CType(fechaGeneracion, Date).Day.ToString().PadLeft(2, "0").Trim() & "-" & correlativo.Trim.PadLeft(5, "0")
            settings.Indent = True
            ' Create XmlWriter.
            settings.Encoding = System.Text.UTF8Encoding.UTF8
            Using writer As XmlWriter = XmlWriter.Create(rutaFE.Trim() & "\Retencion\" & nombre.Trim() & ".XML", settings)
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
                ''Me.ObtenerExtensiones(writer, prefixExt, prefixSac, prefixCbc, prefixDs, cadExt, cadSac, cadCbc, cadDs, Nothing, Nothing, "", True)
                fc_ObtenerExtensiones(writer, prefixExt, prefixSac, prefixCbc, prefixDs, cadExt)
                ''Me.ObtenerDatosCabeceraBaja(writer, prefixCbc, prefixCac, cadSac, cadCbc, cadCac, cadSac, dtCab, "", "", True, fechaGeneracion, "RR", correlativo.Trim)
                fc_ObtenerDatosCabecera(writer, prefixCbc, prefixCac, prefixSac, cadCbc, cadCac, cadSac, dtCab, "", "", True, fechaGeneracion, "RR", correlativo.Trim)
                For Each drFila As DataRow In dtCab.Rows
                    i = i + 1
                    ''Me.ObtenerDatosDetalleComprobantesBaja(writer, prefixCbc, prefixSac, cadCbc, cadSac, drFila.Item("tipcomp"), drFila.Item("seriecomp"), drFila.Item("corrcomp"), i, "ERROR EN EL SISTEMA")
                    fc_ObtenerDatosDetalleComprobantesBaja(writer, prefixCbc, prefixSac, cadCbc, cadSac, drFila.Item("tipcomp"), drFila.Item("seriecomp"), drFila.Item("corrcomp"), i, "ERROR EN EL SISTEMA")
                Next
                '</VoidedDocuments>
                writer.WriteEndElement()
                writer.WriteEndDocument()
            End Using
            ''Me.AgregarFirma(rutaFE, nombre, "", "", True, "RA")
            fc_AgregarFirma(rutaFE, nombre, "", "", True, "RA")
            Using zip As ZipFile = New ZipFile(System.Text.UTF8Encoding.UTF8)
                zip.AddFile(rutaFE.Trim() & "\Retencion\" & nombre.Trim() & ".XML", "")
                zip.Save(rutaFE.Trim() & "\Retencion\" & nombre.Trim() & ".zip")
            End Using
            ''ticket = Me.EnviarBajaXML(rutaFE, nombre, definicion)
            ticket = fc_EnviarBajaXML(rutaFE, nombre, definicion)
            ''facturacion2ADObj.AdicionarComprobanteBath(dtCab, fechaGeneracion, nombre, definicion, True, ticket, usuario, "", "")
            odComunicaBaja.Guardar(New e_ComprobanteElectronicoBath With {.TipoOperacion = "I", .TipoReferencia = 2, .FechaEnvio = fechaGeneracion, .xmlbase64 = definicion, _
                                                                          .nombrexml = nombre, .IndBaja = True, .UsuarioCrea = usuario, .Estado = "E", .Ticket = ticket, _
                                                                          .leDetalle = fc_GeneraDetalleBaja(dtCab, usuario)})
        Catch ex As Exception
            Throw ex
        Finally
            If File.Exists(rutaFE.Trim() & "\Retencion\" & nombre.Trim() & ".xml") Then
                File.Delete(rutaFE.Trim() & "\Retencion\" & nombre.Trim() & ".xml")
            End If
        End Try
        Return ticket
    End Function

    ''' <summary>
    ''' Escribe las Extenciones del Documento XML
    ''' </summary>
    ''' <param name="writer">Documento XML</param>
    ''' <param name="prefixExt"></param>
    ''' <param name="prefixSac"></param>
    ''' <param name="prefixCbc"></param>
    ''' <param name="prefixDs"></param>
    ''' <param name="cadExt"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function fc_ObtenerExtensiones(ByVal writer As XmlWriter, ByVal prefixExt As String, ByVal prefixSac As String, _
                                           ByVal prefixCbc As String, ByVal prefixDs As String, ByVal cadExt As String)
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

    ''' <summary>
    ''' Escribe Informacion Principal de Documento XML
    ''' </summary>
    ''' <param name="writer"></param>
    ''' <param name="prefixCbc"></param>
    ''' <param name="prefixCac"></param>
    ''' <param name="prefixSac"></param>
    ''' <param name="cadCbc"></param>
    ''' <param name="cadCac"></param>
    ''' <param name="cadSac"></param>
    ''' <param name="dtCab"></param>
    ''' <param name="TipDoc"></param>
    ''' <param name="CodMon"></param>
    ''' <param name="flagBaja"></param>
    ''' <param name="fechaGeneracion"></param>
    ''' <param name="prefijo"></param>
    ''' <param name="correlativo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function fc_ObtenerDatosCabecera(ByVal writer As XmlWriter, ByVal prefixCbc As String, ByVal prefixCac As String, ByVal prefixSac As String, _
                                          ByVal cadCbc As String, ByVal cadCac As String, ByVal cadSac As String, ByVal dtCab As DataTable, ByVal TipDoc As String, _
                                          ByVal CodMon As String, ByVal flagBaja As Boolean, ByVal fechaGeneracion As DateTime, ByVal prefijo As String, _
                                          ByVal correlativo As String) As XmlWriter
        ''Dim facturacionADObj As New PercepcionAD(mCadenaConexion)
        odCatalago = New d_CatalagoCodigoSunat
        '<cbc:UBLVersionID>2.0</cbc:UBLVersionID>
        writer.WriteElementString("UBLVersionID", cadCbc, "2.0")
        '<cbc:CustomizationID>1.0</cbc:CustomizationID>
        writer.WriteElementString("CustomizationID", cadCbc, "1.0")
        If flagBaja Then
            writer.WriteElementString("ID", cadCbc, prefijo.Trim & "-" & CType(fechaGeneracion, Date).Year.ToString().PadLeft(2, "0").Trim() & _
                                      CType(fechaGeneracion, Date).Month.ToString().PadLeft(2, "0").Trim() & _
                                      CType(fechaGeneracion, Date).Day.ToString().PadLeft(2, "0").Trim() & "-" & correlativo.Trim.PadLeft(5, "0"))
            '<cbc:ReferenceDate>2012-04-15</cbc:ReferenceDate>
            writer.WriteElementString("ReferenceDate", cadCbc, CType(dtCab.Rows(0).Item("feccomp"), Date).Year.ToString().PadLeft(2, "0").Trim() & "-" & _
                                      CType(dtCab.Rows(0).Item("feccomp"), Date).Month.ToString().PadLeft(2, "0").Trim() & "-" & _
                                      CType(dtCab.Rows(0).Item("feccomp"), Date).Day.ToString().PadLeft(2, "0").Trim())
            '<cbc:IssueDate>2012-03-14</cbc:IssueDate>
            writer.WriteElementString("IssueDate", cadCbc, CType(fechaGeneracion, Date).Year.ToString().PadLeft(2, "0").Trim() & "-" & _
                                      CType(fechaGeneracion, Date).Month.ToString().PadLeft(2, "0").Trim() & "-" & _
                                      CType(fechaGeneracion, Date).Day.ToString().PadLeft(2, "0").Trim())
        End If
        '<cac:Signature>
        writer.WriteStartElement(prefixCac, "Signature", cadCac)
        '<cbc:ID>IDSignKG</cbc:ID>
        writer.WriteElementString("ID", cadCbc, "IDSignSP")
        '<cac:SignatoryParty>
        writer.WriteStartElement(prefixCac, "SignatoryParty", cadCac)
        '<cac:PartyIdentification>
        writer.WriteStartElement(prefixCac, "PartyIdentification", cadCac)
        '<cbc:ID>20100113612</cbc:ID> - RUC EMPRESA
        ''writer.WriteElementString("ID", cadCbc, facturacionADObj.ObtenerDescripcionPorCodigoSistema("017", "001").ToString().Trim())
        writer.WriteElementString("ID", cadCbc, odCatalago.Obtener(New e_CatalagoCodigoSunat With {.CodigoTabla = "017", .CodigoElemento = "001"}).Descripcion)
        '</cac:PartyIdentification>
        writer.WriteEndElement()
        '<cac:PartyName>
        writer.WriteStartElement(prefixCac, "PartyName", cadCac)
        '<cbc:Name><![CDATA[K&G Laboratorios]]></cbc:Name>
        ''writer.WriteElementString("Name", cadCbc, facturacionADObj.ObtenerDescripcionPorCodigoSistema("017", "013").ToString().Trim())
        writer.WriteElementString("Name", cadCbc, odCatalago.Obtener(New e_CatalagoCodigoSunat With {.CodigoTabla = "017", .CodigoElemento = "013"}).Descripcion)
        '</cac:PartyName>
        writer.WriteEndElement()
        '</cac:SignatoryParty>
        writer.WriteEndElement()
        '<cac:DigitalSignatureAttachment>
        writer.WriteStartElement(prefixCac, "DigitalSignatureAttachment", cadCac)
        '<cac:ExternalReference>
        writer.WriteStartElement(prefixCac, "ExternalReference", cadCac)
        '<cbc:URI>#signatureKG</cbc:URI>
        writer.WriteElementString("URI", cadCbc, "#SignatureSP")
        '</cac:ExternalReference>
        writer.WriteEndElement()
        '</cac:DigitalSignatureAttachment>
        writer.WriteEndElement()
        '</cac:Signature>
        writer.WriteEndElement()
        If Not flagBaja Then
            '<cbc:ID>R001-123</cbc:ID>
            writer.WriteElementString("ID", cadCbc, dtCab.Rows(0).Item("seriecomp").ToString().Trim() & "-" & dtCab.Rows(0).Item("corrcomp").ToString().PadLeft(8, "0").Trim())
            '<cbc:IssueDate>2015-12-24</cbc:IssueDate>
            writer.WriteElementString("IssueDate", cadCbc, CType(dtCab.Rows(0).Item("feccomp"), Date).Year.ToString().PadLeft(2, "0").Trim() & "-" & _
                                      CType(dtCab.Rows(0).Item("feccomp"), Date).Month.ToString().ToString().PadLeft(2, "0").Trim() & "-" & _
                                      CType(dtCab.Rows(0).Item("feccomp"), Date).Day.ToString().PadLeft(2, "0").Trim())
        End If

        If flagBaja Then
            '<cac:AccountingSupplierParty>
            writer.WriteStartElement(prefixCac, "AccountingSupplierParty", cadCac)
            '<cbc:CustomerAssignedAccountID>20479729141</cbc:CustomerAssignedAccountID>
            writer.WriteElementString("CustomerAssignedAccountID", cadCbc, odCatalago.Obtener(New e_CatalagoCodigoSunat With {.CodigoTabla = "017", .CodigoElemento = "001"}).Descripcion)
            '<cbc:AdditionalAccountID>6</cbc:AdditionalAccountID>
            writer.WriteElementString("AdditionalAccountID", cadCbc, odCatalago.Obtener(New e_CatalagoCodigoSunat With {.CodigoTabla = "017", .CodigoElemento = "002"}).Descripcion)
            '<cac:Party>
            writer.WriteStartElement(prefixCac, "Party", cadCac)
            '<cac:PartyName>
            writer.WriteStartElement(prefixCac, "PartyName", cadCac)
            '<cbc:Name>Induamerica SAC</cbc:Name>
            writer.WriteElementString("Name", cadCbc, odCatalago.Obtener(New e_CatalagoCodigoSunat With {.CodigoTabla = "017", .CodigoElemento = "010"}).Descripcion)
            '</cac:PartyName>
            writer.WriteEndElement()
            '<cac:PartyLegalEntity>
            writer.WriteStartElement(prefixCac, "PartyLegalEntity", cadCac)
            '<cbc:RegistrationName>Induamerica SAC</cbc:RegistrationName>
            writer.WriteElementString("RegistrationName", cadCbc, odCatalago.Obtener(New e_CatalagoCodigoSunat With {.CodigoTabla = "017", .CodigoElemento = "013"}).Descripcion)
            '</cac:PartyName>
            writer.WriteEndElement()
            '</cac:Party>
            writer.WriteEndElement()
            '</cac:AccountingSupplierParty>
            writer.WriteEndElement()
        Else
            '<cac:AgentParty> Datos Emisor Electronico
            writer.WriteStartElement(prefixCac, "AgentParty", cadCac)
            '<cac:PartyIdentification>
            writer.WriteStartElement(prefixCac, "PartyIdentification", cadCac)
            '<cbc:ID schemeID="6">20100113612</cbc:ID>
            writer.WriteStartElement(prefixCbc, "ID", cadCbc)
            ''writer.WriteAttributeString("schemeID", facturacionADObj.ObtenerDescripcionPorCodigoSistema("017", "002").Trim())
            writer.WriteAttributeString("schemeID", odCatalago.Obtener(New e_CatalagoCodigoSunat With {.CodigoTabla = "017", .CodigoElemento = "002"}).Descripcion)
            ''writer.WriteValue(facturacionADObj.ObtenerDescripcionPorCodigoSistema("017", "001").ToString().Trim())
            writer.WriteValue(odCatalago.Obtener(New e_CatalagoCodigoSunat With {.CodigoTabla = "017", .CodigoElemento = "001"}).Descripcion)
            writer.WriteEndElement()
            '</cac:PartyIdentification>
            writer.WriteEndElement()
            '<cac:PartyName>
            writer.WriteStartElement(prefixCac, "PartyName", cadCac)
            '<cbc:Name><![CDATA[K&G Laboratorios]]></cbc:Name>
            ''writer.WriteElementString("Name", cadCbc, facturacionADObj.ObtenerDescripcionPorCodigoSistema("017", "010"))
            writer.WriteElementString("Name", cadCbc, odCatalago.Obtener(New e_CatalagoCodigoSunat With {.CodigoTabla = "017", .CodigoElemento = "010"}).Descripcion)
            '</cac:PartyName>
            writer.WriteEndElement()

            '<cac:PostalAddress>
            writer.WriteStartElement(prefixCac, "PostalAddress", cadCac)
            '<cbc:ID>150114</cbc:ID>
            ''writer.WriteElementString("ID", cadCbc, facturacionADObj.ObtenerDescripcionPorCodigoSistema("017", "003"))
            writer.WriteElementString("ID", cadCbc, odCatalago.Obtener(New e_CatalagoCodigoSunat With {.CodigoTabla = "017", .CodigoElemento = "003"}).Descripcion)
            '<cbc:StreetName>AV. LOS OLIVOS 767</cbc:StreetName>
            '' writer.WriteElementString("StreetName", cadCbc, facturacionADObj.ObtenerDescripcionPorCodigoSistema("017", "004"))
            writer.WriteElementString("StreetName", cadCbc, odCatalago.Obtener(New e_CatalagoCodigoSunat With {.CodigoTabla = "017", .CodigoElemento = "004"}).Descripcion)
            '<cbc:CitySubdivisionName>URB. SANTA FELICIA</cbc:CitySubdivisionName>
            ''writer.WriteElementString("CitySubdivisionName", cadCbc, facturacionADObj.ObtenerDescripcionPorCodigoSistema("017", "005"))
            writer.WriteElementString("CitySubdivisionName", cadCbc, odCatalago.Obtener(New e_CatalagoCodigoSunat With {.CodigoTabla = "017", .CodigoElemento = "005"}).Descripcion)
            '<cbc:CityName>LIMA</cbc:CityName>
            ''writer.WriteElementString("CityName", cadCbc, facturacionADObj.ObtenerDescripcionPorCodigoSistema("017", "006"))
            writer.WriteElementString("CityName", cadCbc, odCatalago.Obtener(New e_CatalagoCodigoSunat With {.CodigoTabla = "017", .CodigoElemento = "006"}).Descripcion)
            '<cbc:CountrySubentity>LIMA</cbc:CountrySubentity>
            ''writer.WriteElementString("CountrySubentity", cadCbc, facturacionADObj.ObtenerDescripcionPorCodigoSistema("017", "007"))
            writer.WriteElementString("CountrySubentity", cadCbc, odCatalago.Obtener(New e_CatalagoCodigoSunat With {.CodigoTabla = "017", .CodigoElemento = "007"}).Descripcion)
            '<cbc:District>MOLINA</cbc:District>
            ''writer.WriteElementString("District", cadCbc, facturacionADObj.ObtenerDescripcionPorCodigoSistema("017", "008"))
            writer.WriteElementString("District", cadCbc, odCatalago.Obtener(New e_CatalagoCodigoSunat With {.CodigoTabla = "017", .CodigoElemento = "008"}).Descripcion)
            '<cac:Country>
            writer.WriteStartElement(prefixCac, "Country", cadCac)
            '<cbc:IdentificationCode>PE</cbc:IdentificationCode>
            ''writer.WriteElementString("IdentificationCode", cadCbc, facturacionADObj.ObtenerDescripcionPorCodigoSistema("017", "009"))
            writer.WriteElementString("IdentificationCode", cadCbc, odCatalago.Obtener(New e_CatalagoCodigoSunat With {.CodigoTabla = "017", .CodigoElemento = "009"}).Descripcion)
            '</cac:Country>
            writer.WriteEndElement()
            '</cac:PostalAddress>
            writer.WriteEndElement()

            '<cac:PartyLegalEntity>
            writer.WriteStartElement(prefixCac, "PartyLegalEntity", cadCac)
            '<cbc:RegistrationName><![CDATA[K&G Asociados S. A.]]></cbc:RegistrationName>
            ''writer.WriteElementString("RegistrationName", cadCbc, facturacionADObj.ObtenerDescripcionPorCodigoSistema("017", "013"))
            writer.WriteElementString("RegistrationName", cadCbc, odCatalago.Obtener(New e_CatalagoCodigoSunat With {.CodigoTabla = "017", .CodigoElemento = "013"}).Descripcion)
            '</cac:PartyLegalEntity>
            writer.WriteEndElement()
            '</cac:AgentParty>
            writer.WriteEndElement()
        End If

        If flagBaja = False Then
            '<cac:ReceiverParty> Datos Proveedor
            writer.WriteStartElement(prefixCac, "ReceiverParty", cadCac)
            '<cac:PartyIdentification>
            writer.WriteStartElement(prefixCac, "PartyIdentification", cadCac)
            '<cbc:ID schemeID="6">20100070970</cbc:ID>
            writer.WriteStartElement(prefixCbc, "ID", cadCbc)
            ''writer.WriteAttributeString("schemeID", facturacionADObj.ObtenerDescripcionPorCodigoSistema("017", "002").Trim())
            writer.WriteAttributeString("schemeID", odCatalago.Obtener(New e_CatalagoCodigoSunat With {.CodigoTabla = "017", .CodigoElemento = "002"}).Descripcion)
            writer.WriteValue(dtCab.Rows(0).Item("nroid").ToString().Trim())
            writer.WriteEndElement()
            '</cac:PartyIdentification>
            writer.WriteEndElement()
            '<cac:PartyName>
            writer.WriteStartElement(prefixCac, "PartyName", cadCac)
            '<cbc:Name><![CDATA[SUPERMERCADOS PERUANOS SOCIEDAD ANONIMA O S.P.S.A.]]></cbc:Name>
            writer.WriteElementString("Name", cadCbc, dtCab.Rows(0).Item("razonsocial").ToString().Trim())
            '</cac:PartyName>
            writer.WriteEndElement()
            '<cac:PartyLegalEntity>
            writer.WriteStartElement(prefixCac, "PartyLegalEntity", cadCac)
            '<cbc:RegistrationName><![CDATA[SUPERMERCADOS PERUANOS SOCIEDAD ANONIMA O  S.P.S.A.]]></cbc:RegistrationName>
            writer.WriteElementString("RegistrationName", cadCbc, dtCab.Rows(0).Item("nombrecomercial").ToString.Trim)
            '</cac:PartyLegalEntity>
            writer.WriteEndElement()
            '</cac:ReceiverParty>
            writer.WriteEndElement()
            '<sac:SUNATRetentionSystemCode>01</sac:SUNATRetentionSystemCode>
            writer.WriteElementString("SUNATRetentionSystemCode", cadSac, dtCab.Rows(0).Item("regimenretencion").ToString.Trim)
            '<sac:SUNATRetentionPercent>3</sac:SUNATRetentionPercent>
            writer.WriteElementString("SUNATRetentionPercent", cadSac, CType(dtCab.Rows(0).Item("tasaretencion"), Double).ToString("F2"))
            '<cbc:Note>Se emite con facturas del periodo 12/2015</cbc:Note>
            writer.WriteElementString("Note", cadCbc, "Se emite con facturas del periodo " & CType(dtCab.Rows(0).Item("feccomp"), DateTime).Month.ToString.PadLeft(2, "0") & "/" & CType(dtCab.Rows(0).Item("feccomp"), DateTime).Year.ToString.PadLeft(2, "0"))
            '<cbc:TotalInvoiceAmount currencyID="PEN">517.50</cbc:TotalInvoiceAmount>
            writer.WriteStartElement(prefixCbc, "TotalInvoiceAmount", cadCbc)
            writer.WriteAttributeString("currencyID", CodMon.Trim())
            writer.WriteValue(CType(dtCab.Rows(0).Item("ImporteTotalRetenido"), Double).ToString("F2"))
            writer.WriteEndElement()
            '<sac:SUNATTotalPaid currencyID="PEN">16732.50</sac:SUNATTotalPaid>
            writer.WriteStartElement(prefixSac, "SUNATTotalPaid", cadSac)
            writer.WriteAttributeString("currencyID", CodMon.Trim())
            writer.WriteValue(CType(dtCab.Rows(0).Item("importeventa"), Double).ToString("F2"))
            writer.WriteEndElement()
        End If

        Return writer
    End Function

    ''' <summary>
    ''' Escribe Informacion de Pagos para Documento XML
    ''' </summary>
    ''' <param name="writer"></param>
    ''' <param name="prefixSac"></param>
    ''' <param name="prefixCbc"></param>
    ''' <param name="prefixCac"></param>
    ''' <param name="cadCbc"></param>
    ''' <param name="cadCac"></param>
    ''' <param name="cadSac"></param>
    ''' <param name="certNbr"></param>
    ''' <param name="drFila"></param>
    ''' <param name="moneda"></param>
    ''' <param name="monedaDOl"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function fc_ObtenerDatosDetalle(ByVal writer As XmlWriter, ByVal prefixSac As String, ByVal prefixCbc As String, ByVal prefixCac As String, _
                                            ByVal cadCbc As String, ByVal cadCac As String, ByVal cadSac As String, ByVal certNbr As String, ByVal drFila As DataRow, _
                                            ByVal moneda As String, ByVal monedaDOl As String) As XmlWriter
        ''Dim facturacionADObj As New PercepcionAD(mCadenaConexion)
        Dim dtPagos As DataTable
        Dim flagME As Boolean = False
        odDetallePago = New d_CuentaxPDocumentoRetencion
        '<sac:SUNATRetentionDocumentReference>
        writer.WriteStartElement(prefixSac, "SUNATRetentionDocumentReference", cadSac)
        '<cbc:ID schemeID="01">0001-14</cbc:ID>
        writer.WriteStartElement(prefixCbc, "ID", cadCbc)
        writer.WriteAttributeString("schemeID", drFila.Item("tipcomp").ToString.Trim)
        writer.WriteValue(drFila.Item("seriecomp").ToString.Trim.PadLeft(4, "0") & "-" & drFila.Item("corrcomp").ToString.Trim)
        writer.WriteEndElement()
        '<cbc:IssueDate>2015-12-22</cbc:IssueDate>
        writer.WriteElementString("IssueDate", cadCbc, CType(drFila.Item("feccomp"), DateTime).Year.ToString.PadLeft(4, "0") & "-" & _
                                  CType(drFila.Item("feccomp"), DateTime).Month.ToString.PadLeft(2, "0") & "-" & _
                                  CType(drFila.Item("feccomp"), DateTime).Day.ToString.PadLeft(2, "0"))
        '<cbc:TotalInvoiceAmount currencyID="PEN">23000.00</cbc:TotalInvoiceAmount>
        writer.WriteStartElement(prefixCbc, "TotalInvoiceAmount", cadCbc)
        If drFila.Item("codmon").ToString.Trim = "SOL" Then
            writer.WriteAttributeString("currencyID", moneda.ToString.Trim)
            writer.WriteValue(CType(drFila.Item("importeventa"), Double).ToString("F2"))
            writer.WriteEndElement()
        Else
            writer.WriteAttributeString("currencyID", monedaDOl.ToString.Trim)
            writer.WriteValue(CType(drFila.Item("importeventame"), Double).ToString("F2"))
            writer.WriteEndElement()
            flagME = True
        End If
        ''dtPagos = facturacionADObj.ObtenerDetallePagosFERetencion(certNbr.Trim, drFila.Item("seriecomp").ToString.Trim & "-" & drFila.Item("corrcomp").ToString.Trim)
        dtPagos = odDetallePago.ListarPagos(New e_CuentaxPDocumentoRetencion With {.IdDocumentoRetencion = certNbr.Trim, .IdCuentaxCyP = drFila.Item("IdMovDocumento").ToString.Trim})
        If dtPagos.Rows.Count = 0 Then
            Throw New Exception("No existen pagos para el comprobante no se puede enviar")
        End If
        For Each drFilaAux As DataRow In dtPagos.Rows
            '<cac:Payment>
            writer.WriteStartElement(prefixCac, "Payment", cadCac)
            '<cbc:ID>1</cbc:ID>
            writer.WriteElementString("ID", cadCbc, drFilaAux.Item("numeropago"))
            '<cbc:PaidAmount currencyID=”USD”>1000.00</cbc:PaidAmount>
            writer.WriteStartElement(prefixCbc, "PaidAmount", cadCbc)
            If drFilaAux.Item("moneda").ToString.Trim = "SOL" Then
                writer.WriteAttributeString("currencyID", moneda.ToString.Trim)
                writer.WriteValue(CType(drFilaAux.Item("importepago"), Double).ToString("F2"))
                writer.WriteEndElement()
            Else
                writer.WriteAttributeString("currencyID", monedaDOl.ToString.Trim)
                writer.WriteValue(CType(drFilaAux.Item("importepagome"), Double).ToString("F2"))
                writer.WriteEndElement()
                flagME = True
            End If
            '<cbc:PaidDate>2015-06-22</cbc:PaidDate>
            writer.WriteElementString("PaidDate", cadCbc, CType(drFilaAux.Item("fecha"), DateTime).Year.ToString.PadLeft(4, "0") & "-" & _
                                      CType(drFilaAux.Item("fecha"), DateTime).Month.ToString.PadLeft(2, "0") & "-" & _
                                      CType(drFilaAux.Item("fecha"), DateTime).Day.ToString.PadLeft(2, "0"))
            '</cac:Payment>
            writer.WriteEndElement()
            Exit For
        Next
        '<sac:SUNATRetentionInformation>
        writer.WriteStartElement(prefixSac, "SUNATRetentionInformation", cadSac)
        '<sac:SUNATRetentionAmount currencyID=”PEN”>90.00</sac:SUNATRetentionAmount>
        writer.WriteStartElement(prefixSac, "SUNATRetentionAmount", cadSac)
        writer.WriteAttributeString("currencyID", moneda.Trim)
        writer.WriteValue(CType(drFila.Item("importeretenido"), Double).ToString("F2"))
        writer.WriteEndElement()
        '<sac:SUNATRetentionDate>2015-12-24</sac:SUNATRetentionDate>
        writer.WriteElementString("SUNATRetentionDate", cadSac, CType(drFila.Item("feccomp2"), DateTime).Year.ToString.PadLeft(4, "0") & "-" & _
                                  CType(drFila.Item("feccomp2"), DateTime).Month.ToString.PadLeft(2, "0") & "-" & _
                                  CType(drFila.Item("feccomp2"), DateTime).Day.ToString.PadLeft(2, "0"))
        '<sac:SUNATNetTotalPaid currencyID="PEN">13580.00</sac:SUNATNetTotalPaid>
        writer.WriteStartElement(prefixSac, "SUNATNetTotalPaid", cadSac)
        writer.WriteAttributeString("currencyID", moneda.Trim)
        writer.WriteValue(CType(drFila.Item("importetotal"), Double).ToString("F2"))
        writer.WriteEndElement()
        '<cac:ExchangeRate>
        writer.WriteStartElement(prefixCac, "ExchangeRate", cadCac)
        '<cbc:SourceCurrencyCode>USD</cbc:SourceCurrencyCode>
        If flagME = True Then
            writer.WriteElementString("SourceCurrencyCode", cadCbc, monedaDOl)
        Else
            writer.WriteElementString("SourceCurrencyCode", cadCbc, moneda)
        End If
        '<cbc:TargetCurrencyCode>PEN</cbc:TargetCurrencyCode>
        writer.WriteElementString("TargetCurrencyCode", cadCbc, moneda.Trim)
        '<cbc:CalculationRate>3.00</cbc:CalculationRate>
        writer.WriteElementString("CalculationRate", cadCbc, CType(drFila.Item("factorc"), Double).ToString("F6"))
        '<cbc:Date>2015-06-22</cbc:Date>
        writer.WriteElementString("Date", cadCbc, CType(drFila.Item("feccomp2"), DateTime).Year.ToString.PadLeft(4, "0") & "-" & _
                                  CType(drFila.Item("feccomp2"), DateTime).Month.ToString.PadLeft(2, "0") & "-" & _
                                  CType(drFila.Item("feccomp2"), DateTime).Day.ToString.PadLeft(2, "0"))
        '</cac:ExchangeRate>
        writer.WriteEndElement()
        '</sac:SUNATRetentionInformation>
        writer.WriteEndElement()
        '</sac:SUNATRetentionDocumentReference>
        writer.WriteEndElement()
        Return writer
    End Function

    ''' <summary>
    ''' Exribe Firma Digital en Documento XML
    ''' </summary>
    ''' <param name="rutaFE"></param>
    ''' <param name="Nombre"></param>
    ''' <param name="valorResumen"></param>
    ''' <param name="firma"></param>
    ''' <param name="flagBaja"></param>
    ''' <param name="TipoDoc"></param>
    ''' <remarks></remarks>
    Private Sub fc_AgregarFirma(ByVal rutaFE As String, ByVal Nombre As String, ByRef valorResumen As String, ByRef firma As String, _
                                ByVal flagBaja As Boolean, ByVal TipoDoc As String)
        Try
            Dim local_xmlArchivo As String = rutaFE & "\Retencion\" & Nombre & ".XML"

            Dim local_nombreXML As String = System.IO.Path.GetFileName(local_xmlArchivo)

            Dim local_typoDocumento As String

            local_typoDocumento = TipoDoc

            Dim MiCertificado As X509Certificate2 = New X509Certificate2(rutaFE & "\Certificado\" & "llave_privada_isl_2016.pfx", "Induameric@", X509KeyStorageFlags.MachineKeySet)
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
            nsMgr.AddNamespace("sac", "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")
            nsMgr.AddNamespace("ccts", "urn:un:unece:uncefact:documentation:2")
            nsMgr.AddNamespace("xsi", "http://www.w3.org/2001/XMLSchema-instance")

            Select Case local_typoDocumento
                Case "01", "03" 'factura / boleta
                    nsMgr.AddNamespace("tns", "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")
                    local_xpath = "/tns:Perception/ext:UBLExtensions/ext:UBLExtension[1]/ext:ExtensionContent"
                Case "07" 'nota de credito
                    nsMgr.AddNamespace("tns", "urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2")
                    local_xpath = "/tns:CreditNote/ext:UBLExtensions/ext:UBLExtension[2]/ext:ExtensionContent"
                Case "08" 'nota de debito
                    nsMgr.AddNamespace("tns", "urn:oasis:names:specification:ubl:schema:xsd:DebitNote-2")
                    local_xpath = "/tns:DebitNote/ext:UBLExtensions/ext:UBLExtension[2]/ext:ExtensionContent"
                Case "RA"  'Communicacion de baja
                    nsMgr.AddNamespace("tns", "urn:sunat:names:specification:ubl:peru:schema:xsd:VoidedDocuments-1")
                    local_xpath = "/tns:VoidedDocuments/ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent"
                Case "RC" 'Resumen de diario
                    nsMgr.AddNamespace("tns", "urn:sunat:names:specification:ubl:peru:schema:xsd:SummaryDocuments-1")
                    local_xpath = "/tns:SummaryDocuments/ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent"
                Case "20" 'Retencion
                    nsMgr.AddNamespace("tns", "urn:sunat:names:specification:ubl:peru:schema:xsd:Retention-1")
                    local_xpath = "/tns:Retention/ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent"
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

    ''' <summary>
    ''' Genera Codigo de Barras
    ''' </summary>
    ''' <param name="dtCab"></param>
    ''' <param name="flagME"></param>
    ''' <param name="valorResumen"></param>
    ''' <param name="firma"></param>
    ''' <param name="factorC"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fc_PreparaCodigoBarras(ByVal dtCab As DataTable, ByVal flagME As Boolean, ByVal valorResumen As String, ByVal firma As String, ByVal factorC As Double) As String
        Dim codBarras As String = ""
        ''Dim tablaFeObjAD As New LogicaNegocioPercepcion.PercepcionAD(mCadenaConexion)
        odCatalago = New d_CatalagoCodigoSunat
        ''codBarras = tablaFeObjAD.ObtenerDescripcionPorCodigoSistema("017", "001") & "|" & dtCab.Rows(0).Item("seriecomp") & "|" & dtCab.Rows(0).Item("corrcomp") & "||" _
        ''& IIf(IIf(flagME, CType(dtCab.Rows(0).Item("importeventa"), Double).ToString("F2"), CType(dtCab.Rows(0).Item("importeventa"), Double).ToString("F2")) = 0, "", IIf(flagME, CType(dtCab.Rows(0).Item("importeventa"), Double).ToString("F2"), CType(dtCab.Rows(0).Item("importeventa"), Double).ToString("F2"))) & "|" _
        ''& CType(dtCab.Rows(0).Item("feccomp"), Date).Year.ToString().PadLeft(2, "0").Trim() & "-" & CType(dtCab.Rows(0).Item("feccomp"), Date).Month.ToString().ToString().PadLeft(2, "0").Trim() & "-" & CType(dtCab.Rows(0).Item("feccomp"), Date).Day.ToString().PadLeft(2, "0").Trim() & "|" _
        ''& dtCab.Rows(0).Item("tipoid").ToString.Trim & "|" & dtCab.Rows(0).Item("nroid").ToString.Trim & "|" & valorResumen & "|" & firma & "|"
        codBarras = odCatalago.Obtener(New e_CatalagoCodigoSunat With {.CodigoTabla = "017", .CodigoElemento = "001"}).Descripcion & "|" & dtCab.Rows(0).Item("seriecomp") & _
            "|" & dtCab.Rows(0).Item("corrcomp") & "||" & IIf(IIf(flagME, CType(dtCab.Rows(0).Item("importeventa"), Double).ToString("F2"), _
                                                                  CType(dtCab.Rows(0).Item("importeventa"), Double).ToString("F2")) = 0, "", _
                                                              IIf(flagME, CType(dtCab.Rows(0).Item("importeventa"), Double).ToString("F2"), _
                                                                  CType(dtCab.Rows(0).Item("importeventa"), Double).ToString("F2"))) & "|" & _
            CType(dtCab.Rows(0).Item("feccomp"), Date).Year.ToString().PadLeft(2, "0").Trim() & "-" & _
            CType(dtCab.Rows(0).Item("feccomp"), Date).Month.ToString().ToString().PadLeft(2, "0").Trim() & "-" & _
            CType(dtCab.Rows(0).Item("feccomp"), Date).Day.ToString().PadLeft(2, "0").Trim() & "|" & _
            dtCab.Rows(0).Item("tipoid").ToString.Trim & "|" & dtCab.Rows(0).Item("nroid").ToString.Trim & "|" & valorResumen & "|" & firma & "|"
        Return codBarras
    End Function

    ''' <summary>
    ''' Envio de Documento XML a SUNAT
    ''' </summary>
    ''' <param name="rutaFE"></param>
    ''' <param name="Nombre"></param>
    ''' <param name="cdrXML"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function fc_EnviarXML(ByVal rutaFE As String, ByVal Nombre As String, ByRef cdrXML As String) As String
        Dim fsRpta As New FileStream(rutaFE & "\Retencion\" & "R-" & Nombre & ".zip", FileMode.Create)
        Dim clienteRemotoObj As New sRetencion.billServiceClient
        Dim datos As New sRetencion.sendBillResponse
        Dim envio As New sRetencion.sendBillRequest
        ''Dim TablaFEADObj As New PercepcionAD(mCadenaConexion)
        Dim xmlDoc As New XmlDocument()
        Dim msjError As String
        Dim definicion As String = ""
        Dim cadError As String
        Try
            odCatalago = New d_CatalagoCodigoSunat
            envio.contentFile = My.Computer.FileSystem.ReadAllBytes(rutaFE & "\Retencion\" & Nombre & ".zip")
            envio.fileName = Nombre & ".zip"
            clienteRemotoObj.Open()
            datos.applicationResponse = clienteRemotoObj.sendBill(envio.fileName, envio.contentFile)
            fsRpta.Write(datos.applicationResponse, 0, datos.applicationResponse.Length)
            fsRpta.Close()
            ''Me.Extraer(rutaFE, Nombre)
            mt_Extraer(rutaFE, Nombre)
            xmlDoc.PreserveWhitespace = False
            xmlDoc.Load(rutaFE & "\Retencion\" & "R-" & Nombre & ".XML")
            cdrXML = xmlDoc.OuterXml.ToString.Trim
            ''msjError = VerificarSiExisteError(xmlDoc.DocumentElement)
            msjError = fc_VerificarSiExisteError(xmlDoc.DocumentElement)
            If msjError <> "" Then
                Throw New Exception("Comprobante rechazado por la SUNAT: " & msjError)
            End If
            ''definicion = EncodeArrayBase64(envio.contentFile)
            definicion = fc_EncodeArrayBase64(envio.contentFile)
        Catch ex As System.ServiceModel.FaultException
            'cadError = TablaFEADObj.ObtenerDescripcionPorCodigoSistema("018", ex.Code.Name.ToString.Replace("soap-env-Server.", "").Trim)
            ''cadError = TablaFEADObj.ObtenerDescripcionPorCodigoSistema("018", ex.Message)
            cadError = odCatalago.Obtener(New e_CatalagoCodigoSunat With {.CodigoTabla = "018", .CodigoElemento = ex.Message}).Descripcion
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

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="rutaFE"></param>
    ''' <param name="Nombre"></param>
    ''' <remarks></remarks>
    Private Sub mt_Extraer(ByVal rutaFE As String, ByVal Nombre As String)
        Using zip1 As ZipFile = ZipFile.Read(rutaFE & "\Retencion\" & "R-" & Nombre & ".zip")
            Dim e As ZipEntry
            For Each e In zip1
                e.Extract(rutaFE & "\Retencion\", ExtractExistingFileAction.OverwriteSilently)
            Next
        End Using
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="nodos"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function fc_VerificarSiExisteError(ByVal nodos As XmlElement)
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
                    msjError = fc_VerificarSiExisteError(nodo)
                    If msjError <> "" Then
                        Exit For
                    End If
                Next
            End If
        End If
        Return msjError
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="arrData"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fc_EncodeArrayBase64(ByRef arrData() As Byte) As String
        Dim objXML As MSXML2.DOMDocument
        Dim objNode As MSXML2.IXMLDOMElement

        objXML = New MSXML2.DOMDocument
        'Matriz de bytes a base64
        objNode = objXML.createElement("b64")

        objNode.dataType = "bin.base64"
        objNode.nodeTypedValue = arrData
        fc_EncodeArrayBase64 = objNode.text
        arrData = objNode.nodeTypedValue
        objNode = Nothing
        objXML = Nothing
    End Function

    Private Function fc_ObtenerDatosDetalleComprobantesBaja(ByVal writer As XmlWriter, ByVal prefixCbc As String, ByVal prefixSac As String, ByVal cadCbc As String, _
                                                         ByVal cadSac As String, ByVal tipComp As String, ByVal serieComp As String, ByVal corrComp As String, _
                                                         ByVal item As Integer, ByVal Motivo As String) As XmlWriter
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

    Private Function fc_EnviarBajaXML(ByVal rutaFE As String, ByVal Nombre As String, ByRef definicion As String) As String
        Dim clienteRemotoObj As New sRetencion.billServiceClient
        Dim datos As New sRetencion.sendSummaryResponse
        Dim envio As New sRetencion.sendSummaryRequest
        ' Dim TablaFEADObj As New PercepcionAD(mCadenaConexion)
        Dim cadError As String
        Try
            odCatalago = New d_CatalagoCodigoSunat
            envio.contentFile = My.Computer.FileSystem.ReadAllBytes(rutaFE & "\Retencion\" & Nombre & ".zip")
            envio.fileName = Nombre & ".zip"
            clienteRemotoObj.Open()
            datos.ticket = clienteRemotoObj.sendSummary(envio.fileName, envio.contentFile)
            If datos.ticket Is Nothing Then
                datos.ticket = "201600544444"
            End If
            definicion = fc_EncodeArrayBase64(envio.contentFile)
        Catch ex As System.ServiceModel.FaultException
            ''cadError = TablaFEADObj.ObtenerDescripcionPorCodigoSistema("018", ex.Message)
            cadError = odCatalago.Obtener(New e_CatalagoCodigoSunat With {.CodigoTabla = "018", .CodigoElemento = ex.Message}).Descripcion
            'cadError = TablaFEADObj.ObtenerDescripcionPorCodigoSistema("018", ex.Code.Name.ToString.Replace("soap-env-Server.", "").Trim)
            If cadError.Trim <> "" Then
                Throw New Exception("Error al enviar documento a la SUNAT: " & cadError)
            Else
                Throw New Exception("Error al enviar documento a la SUNAT: " & ex.Message)
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return datos.ticket
    End Function

    Private Function fc_GeneraDetalleBaja(ByVal dsComprobantes As DataTable, ByVal IdUsuario As String) As List(Of e_ComprobanteElectronicoBath_Detalle)
        Try
            Dim leDetalle As New List(Of e_ComprobanteElectronicoBath_Detalle)
            Dim oeDetalle As e_ComprobanteElectronicoBath_Detalle
            Dim i As Integer = 0
            For Each fila As DataRow In dsComprobantes.Rows
                i = i + 1
                oeDetalle = New e_ComprobanteElectronicoBath_Detalle
                oeDetalle.TipoOperacion = "I"
                oeDetalle.Item = i
                oeDetalle.TipoReferencia = 2
                oeDetalle.IdReferencia = fila.Item("idcomp")
                oeDetalle.UsuarioCrea = IdUsuario
                leDetalle.Add(oeDetalle)
            Next
            Return leDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EnviarXMLGetStatus(ByVal rutaFE As String, ByVal ticket As String, ByVal Usuario As String, ByVal PrefijoID As String) As Boolean

        Dim clienteRemotoObj As New sRetencion.billServiceClient
        Dim datos As New sRetencion.getStatusResponse
        Dim envio As New sRetencion.getStatusRequest

        Dim oeCatalago As e_CatalagoCodigoSunat
        Dim oeComprobanteBathDet As e_ComprobanteElectronicoBath_Detalle
        Dim odComprobanteBath As New d_ComprobanteElectronicoBath
        Dim odComprobanteBathDet As New d_ComprobanteElectronicoBath_Detalle
        Dim dCatalago As New d_CatalagoCodigoSunat

        Dim l_ComprobanteElectronicoBath As New List(Of e_ComprobanteElectronicoBath)
        Dim l_ComprobanteElectronicoBathD As New List(Of e_ComprobanteElectronicoBath_Detalle)

        Dim xmlDoc As New XmlDocument()
        Dim msjError As String
        Dim cdrXML As String = ""
        Dim cadError As String = ""
        Dim Nombre As String = ""
        Dim fsRpta As FileStream = Nothing
        Dim flagError As Boolean = False

        Try
            Dim oeComprobanteBath As New e_ComprobanteElectronicoBath
            oeComprobanteBath.TipoReferencia = "2"
            oeComprobanteBath.TipoOperacion = ""
            oeComprobanteBath.Ticket = ticket
            l_ComprobanteElectronicoBath.AddRange(odComprobanteBath.Listar(oeComprobanteBath))
            If l_ComprobanteElectronicoBath.Count = 0 Then Throw New Exception("Numero de ticket no existe")

            Nombre = l_ComprobanteElectronicoBath.Item(0).nombrexml
            oeComprobanteBathDet = New e_ComprobanteElectronicoBath_Detalle
            oeComprobanteBathDet.IdBath = l_ComprobanteElectronicoBath.Item(0).Id

            l_ComprobanteElectronicoBathD.AddRange(odComprobanteBathDet.Listar(oeComprobanteBathDet))

            clienteRemotoObj.Open()
            envio.ticket = l_ComprobanteElectronicoBath.Item(0).Ticket
            datos.status = clienteRemotoObj.getStatus(envio.ticket)

            If CDbl(datos.status.statusCode.Trim) <> 98 Then
                fsRpta = New FileStream(rutaFE & "\Retencion\" & "R-" & Nombre & ".zip", FileMode.Create)
                fsRpta.Write(datos.status.content, 0, datos.status.content.Length)
                fsRpta.Close()
                Me.mt_Extraer(rutaFE, Nombre)
                xmlDoc.PreserveWhitespace = False
                xmlDoc.Load(rutaFE & "\Retencion\" & Nombre & ".XML")
                cdrXML = xmlDoc.OuterXml.ToString.Trim
                msjError = fc_VerificarSiExisteError(xmlDoc.DocumentElement)
                If msjError <> "" Then
                    Throw New Exception("Comprobante rechazado por la SUNAT: " & msjError)
                End If
            Else
                Throw New Exception("Ticket se encuentra en proceso, por favor intente mas tarde!!!")
            End If
        Catch ex As System.ServiceModel.FaultException
            flagError = True
            oeCatalago = New e_CatalagoCodigoSunat
            oeCatalago.CodigoTabla = "018" : oeCatalago.CodigoElemento = ex.Code.Name.ToString.Replace("Server.", "").Trim
            If IsNumeric(oeCatalago.CodigoElemento) Then
                cadError = dCatalago.Obtener(oeCatalago).Descripcion
            End If
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

            If cdrXML.Trim <> "" Then
                odComprobanteBath.ActualizarEstadoBath_Retencion(l_ComprobanteElectronicoBath, l_ComprobanteElectronicoBathD, cdrXML, flagError, Usuario, PrefijoID)
            End If

            If File.Exists(rutaFE & "\Retencion\" & "R-" & Nombre & ".xml") Then
                File.Delete(rutaFE & "\Retencion\" & "R-" & Nombre & ".xml")
            End If
            clienteRemotoObj.Close()
        End Try
        Return True
    End Function

    Public Function ConsultarDocumento(dsComprobante As DataSet, RutaFE As String, usuario As String, ByVal esLote As Boolean) As Boolean
        'Create XmlWriterSettings.
        Dim settings As XmlWriterSettings = New XmlWriterSettings()
        Dim prefixCac As String, prefixCbc As String, prefixDs As String, prefixExt As String, prefixSac As String
        Dim cadCac As String = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"
        Dim cadCbc As String = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"
        Dim cadCcts As String = "urn:un:unece:uncefact:documentation:2"
        Dim cadDs As String = "http://www.w3.org/2000/09/xmldsig#"
        Dim cadExt As String = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2"
        Dim cadQdt As String = "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2"
        Dim cadSac As String = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1"
        Dim cadUdt As String = "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2"
        Dim cadXsi As String = "http://www.w3.org/2001/XMLSchema-instance"
        ''Dim facturacionADObj As New LogicaNegocioPercepcion.PercepcionAD(mCadenaConexion)
        ''Dim facturacionObj As New LogicaNegocioPercepcion.Percepcion(mCadenaConexion)
        Dim monedaSol, monedaDol As String
        Dim TipDoc As String
        Dim definicion As String = ""
        Dim valorCodBarras As String = ""
        Dim cdrXML As String = ""
        Dim flagError As Boolean = False
        Dim boolRetorno As Boolean = False
        Dim tipoid As String = ""

        Dim clienteRemotoObj As New sConsultarFactura.billServiceClient
        Dim datos As New sConsultarFactura.getStatusCdrResponse()
        Dim envio As New sConsultarFactura.getStatusCdrRequest
        Dim cadError As String = ""

        Dim xmlBase64, valorResumen, firma As String
        Dim flagME As Boolean
        Dim fsRpta As FileStream
        Dim Nombre As String = ""
        Dim dtDocOri As DataTable = Nothing
        Dim xmlDoc As XmlDocument = New XmlDocument()
        Dim odComprobanteElectronico As New d_ComprobanteElectronico
        Dim oeComprobanteElectronico As e_ComprobanteElectronico
        Dim oeDocumento As e_MovimientoDocumento
        Try
            Dim dtCab As DataTable = dsComprobante.Tables(0).Copy
            odCatalago = New d_CatalagoCodigoSunat
            Nombre = odCatalago.Obtener(New e_CatalagoCodigoSunat With {.CodigoTabla = "017", .CodigoElemento = "001"}).Descripcion & "-" & "20" & "-" & _
                dtCab.Rows(0).Item("seriecomp").ToString().Trim() & "-" & dtCab.Rows(0).Item("corrcomp").ToString().PadLeft(8, "0").Trim()
            'ucMsje.MsjeVisible = False
            ' dtCab = facturacionADOBj.ObtenerCabeceraComprobante(Me.txtSerie.Text, Me.txtCorrelativo.Text, ddlTipoDocumento.SelectedValue.ToString.Trim)
            If dtCab.Rows.Count > 0 Then
                envio.rucComprobante = odCatalago.Obtener(New e_CatalagoCodigoSunat With {.CodigoTabla = "017", .CodigoElemento = "001"}).Descripcion
                envio.tipoComprobante = "20"
                envio.serieComprobante = dtCab.Rows(0).Item("seriecomp").ToString().Trim()
                envio.numeroComprobante = dtCab.Rows(0).Item("corrcomp").ToString().PadLeft(8, "0").Trim()
                clienteRemotoObj.Open()
                System.Net.ServicePointManager.Expect100Continue = False
                datos.statusCdr = clienteRemotoObj.getStatusCdr(envio.rucComprobante, envio.tipoComprobante, envio.serieComprobante, envio.numeroComprobante)
                If Not datos.statusCdr.content Is Nothing Then
                    fsRpta = New FileStream(RutaFE & "\Retencion\R-" & Nombre & ".zip", FileMode.Create)
                    fsRpta.Write(datos.statusCdr.content, 0, datos.statusCdr.content.Length)
                    fsRpta.Close()
                    Me.mt_Extraer(RutaFE, Nombre)
                    xmlDoc.PreserveWhitespace = False
                    xmlDoc.Load(RutaFE & "\Retencion\R-" & Nombre & ".XML")
                    cdrXML = xmlDoc.OuterXml.ToString.Trim
                    cadError = fc_VerificarSiExisteError(xmlDoc.DocumentElement)
                    'dsComprobante = facturacionADOBj.ObtenerComprobanteFE(dtCab.Rows(0).Item("idcomp"))
                    valorCodBarras = ""
                    valorResumen = ""
                    firma = ""
                    If Not System.IO.File.Exists(RutaFE & Nombre.Trim() & ".XML") Then
                        odCatalago = New d_CatalagoCodigoSunat : odRetencionElectronica = New d_ComprobanteElectronico
                        ''monedaSol = facturacionADObj.ObtenerCodigoSunatPorCodigoSistema("002", "SOL")
                        monedaSol = odCatalago.Obtener(New e_CatalagoCodigoSunat With {.CodigoTabla = "002", .CodigoElemento = "SOL"}).CodigoSunat
                        ''monedaDol = facturacionADObj.ObtenerCodigoSunatPorCodigoSistema("002", "DOL")
                        monedaDol = odCatalago.Obtener(New e_CatalagoCodigoSunat With {.CodigoTabla = "002", .CodigoElemento = "DOL"}).CodigoSunat
                        TipDoc = dtCab.Rows(0).Item("tipcomp").ToString()
                        If dtCab.Rows(0).Item("nroid").ToString.Trim = "" Then
                            Throw New Exception("No existe documento del cliente")
                        End If
                        ''tipoid = facturacionADObj.ObtenerCodigoSunatPorCodigoSistema("006", dtCab.Rows(0).Item("tipoid"))
                        tipoid = odCatalago.Obtener(New e_CatalagoCodigoSunat With {.CodigoTabla = "006", .CodigoElemento = dtCab.Rows(0).Item("tipoid")}).CodigoSunat
                        If tipoid.Trim = "" Then
                            Throw New Exception("No existe tipo del documento " & dtCab.Rows(0).Item("tipoid").ToString().Trim & " del cliente")
                        End If
                        ''nombre = facturacionADObj.ObtenerDescripcionPorCodigoSistema("017", "001") & "-" & "20" & "-" & dtCab.Rows(0).Item("seriecomp").ToString().Trim() & "-" & dtCab.Rows(0).Item("corrcomp").ToString().PadLeft(8, "0").Trim()
                        Nombre = odCatalago.Obtener(New e_CatalagoCodigoSunat With {.CodigoTabla = "017", .CodigoElemento = "001"}).Descripcion & "-" & "20" & "-" & _
                            dtCab.Rows(0).Item("seriecomp").ToString().Trim() & "-" & dtCab.Rows(0).Item("corrcomp").ToString().PadLeft(8, "0").Trim()
                        settings.Indent = True
                        ' Create XmlWriter.
                        settings.Encoding = System.Text.UTF8Encoding.UTF8
                        Using writer As XmlWriter = XmlWriter.Create(RutaFE.Trim() & "\Retencion\" & Nombre.Trim() & ".XML", settings)
                            prefixCac = writer.LookupPrefix(cadCac)
                            prefixExt = writer.LookupPrefix(cadExt)
                            prefixSac = writer.LookupPrefix(cadSac)
                            prefixCbc = writer.LookupPrefix(cadCbc)
                            prefixDs = writer.LookupPrefix(cadDs)
                            ' Begin writing.
                            writer.WriteStartDocument()
                            '<Retention xmlns="urn:sunat:names:specification:ubl:peru:schema:xsd:Retention-1" xmlns:cac="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2" xmlns:cbc="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2" xmlns:ccts="urn:un:unece:uncefact:documentation:2" xmlns:ds="http://www.w3.org/2000/09/xmldsig#" xmlns:ext="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2" xmlns:qdt="urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2" xmlns:sac="urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1" xmlns:udt="urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
                            writer.WriteStartElement("Retention", "urn:sunat:names:specification:ubl:peru:schema:xsd:Retention-1") ' Root.
                            'writer.WriteStartElement("Perception") ' Root.
                            writer.WriteAttributeString("xmlns", "cac", Nothing, cadCac)
                            writer.WriteAttributeString("xmlns", "cbc", Nothing, cadCbc)
                            writer.WriteAttributeString("xmlns", "ccts", Nothing, cadCcts)
                            writer.WriteAttributeString("xmlns", "ds", Nothing, cadDs)
                            writer.WriteAttributeString("xmlns", "ext", Nothing, cadExt)
                            writer.WriteAttributeString("xmlns", "qdt", Nothing, cadQdt)
                            writer.WriteAttributeString("xmlns", "sac", Nothing, cadSac)
                            writer.WriteAttributeString("xmlns", "udt", Nothing, cadUdt)
                            writer.WriteAttributeString("xmlns", "xsi", Nothing, cadXsi)
                            ''Me.ObtenerExtensiones(writer, prefixExt, prefixSac, prefixCbc, prefixDs, cadExt, cadSac, cadCbc, cadDs, dtCab, dtDet, monedaSol.Trim(), False)
                            fc_ObtenerExtensiones(writer, prefixExt, prefixSac, prefixCbc, prefixDs, cadExt)
                            ''Me.ObtenerDatosCabecera(writer, prefixCbc, prefixCac, prefixSac, cadCbc, cadCac, cadSac, dtCab, TipDoc, monedaSol.Trim(), False, Nothing, "", "")
                            fc_ObtenerDatosCabecera(writer, prefixCbc, prefixCac, prefixSac, cadCbc, cadCac, cadSac, dtCab, TipDoc, monedaSol.Trim(), False, Nothing, "", "")
                            For Each drFila As DataRow In dsComprobante.Tables(1).Rows
                                ''Me.ObtenerDatosDetalle(writer, prefixSac, prefixCbc, prefixCac, cadCbc, cadCac, cadSac, dtCab.Rows(0).Item("seriecomp").ToString.Trim & "-" & dtCab.Rows(0).Item("corrcomp").ToString.Trim, drFila, monedaSol.Trim(), monedaDol)
                                fc_ObtenerDatosDetalle(writer, prefixSac, prefixCbc, prefixCac, cadCbc, cadCac, cadSac, dtCab.Rows(0).Item("idcomp").ToString.Trim, _
                                                       drFila, monedaSol.Trim(), monedaDol)
                            Next
                            '</Retention>
                            writer.WriteEndElement()
                            writer.WriteEndDocument()
                        End Using
                        ''Me.AgregarFirma(rutaFE, nombre, valorResumen, firma, False, TipDoc)
                        fc_AgregarFirma(RutaFE, Nombre, valorResumen, firma, False, TipDoc)
                        'Me.ValidarXML(rutaFE, nombre, dtCab.Rows(0).Item("tipcomp"))
                        If esLote Then
                            xmlDoc = New XmlDocument()
                            xmlDoc.PreserveWhitespace = True
                            xmlDoc.Load(RutaFE & "\Retencion\" & Nombre & ".XML")
                            'boolRetorno = xmlDoc.OuterXml.ToString.Trim
                        End If
                        Using zip As ZipFile = New ZipFile(System.Text.UTF8Encoding.UTF8)
                            zip.AddFile(RutaFE.Trim() & "\Retencion\" & Nombre.Trim() & ".XML", "")
                            zip.Save(RutaFE.Trim() & "\Retencion\" & Nombre.Trim() & ".zip")
                        End Using
                    End If
                    xmlBase64 = fc_EncodeArrayBase64(My.Computer.FileSystem.ReadAllBytes(RutaFE & Nombre & ".xml"))
                    If cadError.Trim <> "" Then
                        cadError = "Comprobante Rechazado: " & cadError.Trim
                        flagError = True
                    Else
                        flagError = False
                    End If
                    If cdrXML.Trim = "" Then
                        Throw New Exception(cadError)
                    Else
                        valorCodBarras = fc_PreparaCodigoBarras(dsComprobante.Tables(0), flagME, valorResumen, firma, dsComprobante.Tables(0).Rows(0).Item("factorc"))
                        odRetencionElectronica.Guardar(New e_ComprobanteElectronico With {.TipoOperacion = "", .TipoReferencia = 2, .IdReferencia = dtCab.Rows(0).Item("idcomp"), _
                                                                                  .xmlbase64 = xmlBase64, .nombrexml = Nombre, .valorcodbarras = valorCodBarras, _
                                                                                  .ValorResumen = valorResumen, .cdrxml = cdrXML, .UsuarioCrea = usuario})
                        boolRetorno = True

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
             If File.Exists(rutaFE.Trim() & "\Retencion\" & nombre.Trim() & ".xml") Then
                File.Delete(RutaFE.Trim() & "\Retencion\" & Nombre.Trim() & ".xml")
            End If
            If File.Exists(RutaFE.Trim() & "\Retencion\" & "R-" & Nombre.Trim() & ".xml") Then
                File.Delete(RutaFE.Trim() & "\Retencion\" & "R-" & Nombre.Trim() & ".xml")
            End If
            clienteRemotoObj.Close()
            System.Net.ServicePointManager.Expect100Continue = True
        End Try
    End Function
End Class
