Imports ERP.EntidadesWCF
Imports ERP.AccesoDatos
Imports System.Xml
Imports System.Text
Imports System.Security.Cryptography
Imports System.Security.Cryptography.X509Certificates
Imports System.Security.Cryptography.Xml

Public Class l_ComprobantePagoElectronico
    Implements Il_ComprobantePagoElectronico

    '' CPE
    Public gs_RutaDocumentosEle As String = "\\10.10.1.2\DocumentosElectronicos\"
    'Dim RutaArchivos As String = DirectCast(ConfigurationManager.GetSection("VariablesDeConfiguracion"), NameValueCollection).Item("DocElectronico") & "\Facturacion\"
    Public gstrRutaDocumentosEle20 As String = "D:\Sistema\xml\" 'Path.Combine(Application.StartupPath, "ComprobanteElectronico") & "\Facturacion\"
    'Public gstrRutaDocumentosEle20 As String = "\\10.10.1.8\Comprobantes\2-0\Documentos MTN\"
    Public gs_RutaDocumentosCDR20 As String = "\\10.10.1.8\Comprobantes\2-0\CDR - MTN\"
    Public gdecIGV As Double = 0.18
    Public gstrRutaFirma As String = "D:\Sistema\xml\ComprobanteElectronico\Certificado\C1811162057.pfx"
    Public gstrDepartamentoEmpresa As String = "LAMBAYEQUE"

    Public gstrUbigeoEmpresa As String = "130101"
    Public gstrProvinciaEmpresa As String = "CHICLAYO"
    Public gstrDistritoEmpresa As String = "CHICLAYO"
    Public gstrDireccion As String = "CAL.LORA Y LORA NRO. 2450 P.J. SANTA ANA (GRIFO REPSOL - OFICINA SEGUNDO PISO)"

    Dim ADO As New d_ComprobantePagoElectronico
    Dim ADO_Detalles As New d_ComprobantePagoElectronico_Detalle

    'Dim ADO_Resumen As d_Resumen_Doc_Electronico
    Dim settings As XmlWriterSettings = New XmlWriterSettings()
    Dim prefixCac As String = ""
    Dim prefixCbc As String = ""
    Dim prefixDs As String = ""
    Dim prefixExt As String = ""
    Dim prefixSac As String = ""
    Dim prefixP As String = ""
    Dim cadCac As String = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"
    Dim cadCbc As String = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"
    Dim cadCcts As String = "urn:un:unece:uncefact:documentation:2"
    Dim cadDs As String = "http://www.w3.org/2000/09/xmldsig#"
    Dim cadExt As String = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2"
    Dim cadQdt As String = "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2"
    Dim cadUdt As String = "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2"
    Dim cadXsi As String = "http://www.w3.org/2001/XMLSchema-instance"
    Dim cadSac As String = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1"
    Dim cadP As String = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1"
    Dim ln_Cont As Integer = 1

    Public Function Consultar(Operacion As String, Documento As e_ComprobantePagoElectronico) As List(Of e_ComprobantePagoElectronico) Implements Il_ComprobantePagoElectronico.Consultar
        Try
            Return ADO.Listar(Documento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(Documento As e_ComprobantePagoElectronico) As e_ComprobantePagoElectronico Implements Il_ComprobantePagoElectronico.Obtener
        Try
            Dim CPE As New e_ComprobantePagoElectronico
            CPE = ADO.Obtener(Documento)
            CPE.Detalles = ADO_Detalles.Listar(New e_ComprobantePagoElectronico_Detalle With {.TipoOperacion = "GEN", .IdDocumento = Documento.Id})
            Return CPE
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CambiarEstado(Operacion As String, Documento As e_ComprobantePagoElectronico) As Boolean Implements Il_ComprobantePagoElectronico.CambiarEstado
        Try
            'Return ADO.Guardar("3", Documento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub lr_UBLExtensiones(xml_writer As XmlWriter)
        Try
            xml_writer.WriteStartElement(prefixExt, "UBLExtensions", cadExt)
            xml_writer.WriteStartElement(prefixExt, "UBLExtension", cadExt)
            '<ext:ExtensionContent>
            xml_writer.WriteStartElement(prefixExt, "ExtensionContent", cadExt)


            xml_writer.WriteEndElement() 'ExtensionContent
            xml_writer.WriteEndElement() 'UBLExtension
            xml_writer.WriteEndElement() 'UBLExtensions
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_UBLExtensionesTotales(xml_writer As XmlWriter, Documento As e_ComprobantePagoElectronico)
        Try
            xml_writer.WriteStartElement(prefixExt, "UBLExtensions", cadExt)
            xml_writer.WriteStartElement(prefixExt, "UBLExtension", cadExt)
            '<ext:ExtensionContent>
            xml_writer.WriteStartElement(prefixExt, "ExtensionContent", cadExt)
            xml_writer.WriteStartElement(prefixSac, "AdditionalInformation", cadSac)
            'operaciones gravadas
            xml_writer.WriteStartElement(prefixSac, "AdditionalMonetaryTotal", cadSac)
            xml_writer.WriteElementString("ID", cadCbc, "1001")
            xml_writer.WriteStartElement(prefixCbc, "PayableAmount", cadCbc)
            xml_writer.WriteAttributeString("currencyID", Documento.Moneda)
            xml_writer.WriteString(Documento.SubTotal.ToString("F2"))
            xml_writer.WriteEndElement() 'PayableAmount
            xml_writer.WriteEndElement() 'AdditionalMonetaryTotal
            'operaciones inafectas
            xml_writer.WriteStartElement(prefixSac, "AdditionalMonetaryTotal", cadSac)
            xml_writer.WriteElementString("ID", cadCbc, "1002")
            xml_writer.WriteStartElement(prefixCbc, "PayableAmount", cadCbc)
            xml_writer.WriteAttributeString("currencyID", Documento.Moneda)
            xml_writer.WriteString(Documento.TotalInafecto.ToString("F2"))
            xml_writer.WriteEndElement() 'PayableAmount
            xml_writer.WriteEndElement() 'AdditionalMonetaryTotal
            'operaciones exoneradas
            xml_writer.WriteStartElement(prefixSac, "AdditionalMonetaryTotal", cadSac)
            xml_writer.WriteElementString("ID", cadCbc, "1003")
            xml_writer.WriteStartElement(prefixCbc, "PayableAmount", cadCbc)
            xml_writer.WriteAttributeString("currencyID", Documento.Moneda)
            xml_writer.WriteString(Documento.TotalExo.ToString("F2"))
            xml_writer.WriteEndElement() 'PayableAmount
            xml_writer.WriteEndElement() 'AdditionalMonetaryTotal
            'operaciones gratuitas
            xml_writer.WriteStartElement(prefixSac, "AdditionalMonetaryTotal", cadSac)
            xml_writer.WriteElementString("ID", cadCbc, "1004")
            xml_writer.WriteStartElement(prefixCbc, "PayableAmount", cadCbc)
            xml_writer.WriteAttributeString("currencyID", Documento.Moneda)
            xml_writer.WriteString(Documento.TotalGratis.ToString("F2"))
            xml_writer.WriteEndElement() 'PayableAmount
            xml_writer.WriteEndElement() 'AdditionalMonetaryTotal
            'descuentos
            xml_writer.WriteStartElement(prefixSac, "AdditionalMonetaryTotal", cadSac)
            xml_writer.WriteElementString("ID", cadCbc, "2005")
            xml_writer.WriteStartElement(prefixCbc, "PayableAmount", cadCbc)
            xml_writer.WriteAttributeString("currencyID", Documento.Moneda)
            xml_writer.WriteString(Documento.DctoGlobal.ToString("F2"))
            xml_writer.WriteEndElement() 'PayableAmount
            xml_writer.WriteEndElement() 'AdditionalMonetaryTotal
            xml_writer.WriteEndElement() 'AdditionalInformation AdditionalMonetaryTotal
            xml_writer.WriteEndElement() 'ExtensionContent
            xml_writer.WriteEndElement() 'UBLExtension
            xml_writer.WriteStartElement(prefixExt, "UBLExtension", cadExt)
            xml_writer.WriteStartElement(prefixExt, "ExtensionContent", cadExt)
            xml_writer.WriteEndElement() 'ExtensionContent
            xml_writer.WriteEndElement() 'UBLExtension
            xml_writer.WriteEndElement() 'UBLExtensions
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_UBLVersion21(xml_writer As XmlWriter)
        Try
            xml_writer.WriteElementString("UBLVersionID", cadCbc, "2.1")
            xml_writer.WriteElementString("CustomizationID", cadCbc, "2.0")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_UBLVersion20(xml_writer As XmlWriter, Ind As Boolean)
        Try
            xml_writer.WriteElementString("UBLVersionID", cadCbc, "2.0")
            xml_writer.WriteElementString("CustomizationID", cadCbc, "1." & IIf(Ind, "1", "0"))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_FirmaDigital(xml_writer As XmlWriter, Documento As e_ComprobantePagoElectronico)
        Try
            xml_writer.WriteStartElement(prefixCac, "Signature", cadCac)
            xml_writer.WriteElementString("ID", cadCbc, Documento.RUCEmisor.Trim)
            xml_writer.WriteStartElement(prefixCac, "SignatoryParty", cadCac)
            xml_writer.WriteStartElement(prefixCac, "PartyIdentification", cadCac)
            xml_writer.WriteElementString("ID", cadCbc, Documento.RUCEmisor.Trim)
            xml_writer.WriteEndElement() 'PartyIdentification
            xml_writer.WriteStartElement(prefixCac, "PartyName", cadCac)
            xml_writer.WriteElementString("Name", cadCbc, Documento.RazonSocial)
            xml_writer.WriteEndElement() 'PartyName
            xml_writer.WriteEndElement() 'SignatoryParty
            xml_writer.WriteStartElement(prefixCac, "DigitalSignatureAttachment", cadCac)
            xml_writer.WriteStartElement(prefixCac, "ExternalReference", cadCac)
            xml_writer.WriteElementString("URI", cadCbc, "#SignatureSP")
            xml_writer.WriteEndElement() 'ExternalReference
            xml_writer.WriteEndElement() 'DigitalSignatureAttachment
            xml_writer.WriteEndElement() 'Signature
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_TipoOperacion(xml_writer As XmlWriter, Tipo As String)
        'Try
        '    With xml_writer
        '        .WriteStartElement(prefixCbc, "ProfileID", cadCbc)
        '        .WriteAttributeString("schemeName", "SUNAT:Identificador de Tipo de Operación")
        '        .WriteAttributeString("schemeAgencyName", "PE:SUNAT")
        '        .WriteAttributeString("schemeURI", "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo17")
        '        Select Case Tipo
        '            Case "VN" 'venta normal
        '                .WriteString("0101") '
        '            Case "VA" 'venta arroz pilado
        '                .WriteString("0107")
        '        End Select
        '        .WriteEndElement() 'ProfileID
        '    End With
        'Catch ex As Exception
        '    Throw ex
        'End Try
    End Sub

    Private Sub lr_DatosDocumento(xml_writer As XmlWriter, DocElectronico As e_ComprobantePagoElectronico)
        Try
            With xml_writer
                .WriteElementString("ID", cadCbc, DocElectronico.Documento) 'documento
                .WriteElementString("IssueDate", cadCbc, CStr(DocElectronico.FechaEmision.ToString("yyyy-MM-dd"))) 'fechaemision
                Select Case DocElectronico.TipoDocumento
                    Case "01"
                        .WriteElementString("IssueTime", cadCbc, "00:00:00") 'hora emision
                        .WriteElementString("DueDate", cadCbc, CStr(DocElectronico.FechaVencimiento.ToString("yyyy-MM-dd"))) 'fecha vencimiento
                End Select
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_DatosDocumento20(xml_writer As XmlWriter, DocElectronico As e_ComprobantePagoElectronico)
        Try
            With xml_writer
                .WriteElementString("ID", cadCbc, DocElectronico.Documento) 'documento
                .WriteElementString("IssueDate", cadCbc, CStr(DocElectronico.FechaEmision.ToString("yyyy-MM-dd"))) 'fechaemision
                If DocElectronico.TipoDocumento = "01" Then .WriteElementString("InvoiceTypeCode", cadCbc, DocElectronico.TipoDocumento) 'fechaemision
                .WriteElementString("DocumentCurrencyCode", cadCbc, DocElectronico.Moneda) 'DocumentCurrencyCode
                'Select Case DocElectronico.TipoDocumento
                '    Case "01"
                '        .WriteElementString("IssueTime", cadCbc, "00:00:00") 'hora emision
                '        .WriteElementString("DueDate", cadCbc, CStr(DocElectronico.FechaVencimiento.ToString("yyyy-MM-dd"))) 'fecha vencimiento
                'End Select
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_TipoDocumento(xml_writer As XmlWriter, DocElectronico As e_ComprobantePagoElectronico)
        Try
            With xml_writer
                .WriteStartElement(prefixCbc, "InvoiceTypeCode", cadCbc)
                .WriteAttributeString("listID", "0101")
                .WriteAttributeString("name", "Tipo de Operacion")
                .WriteAttributeString("listSchemeURI", "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo51")
                .WriteString(DocElectronico.TipoDocumento)
                .WriteEndElement()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_MontoMoneda(xml_writer As XmlWriter, DocElectronico As e_ComprobantePagoElectronico)
        Try
            With xml_writer
                .WriteStartElement(prefixCbc, "Note", cadCbc)
                .WriteAttributeString("languageLocaleID", "1000")
                .WriteString(DocElectronico.MontoLetras)
                .WriteEndElement() 'Note
                .WriteStartElement(prefixCbc, "DocumentCurrencyCode", cadCbc)
                .WriteAttributeString("listID", "ISO 4217 Alpha")
                .WriteAttributeString("listName", "Currency")
                .WriteAttributeString("listAgencyName", "United Nations Economic Commission for Europe")
                .WriteString(DocElectronico.Moneda)
                .WriteEndElement() 'DocumentCurrencyCode
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_CantidadDetalles(xml_writer As XmlWriter, Cantidad As Integer)
        Try
            xml_writer.WriteElementString("LineCountNumeric", cadCbc, Cantidad.ToString("F0"))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Private Sub lr_DocumentoAsociado(xml_writer As XmlWriter, Documento As e_ComprobantePagoElectronico)
    '    Try
    '        For Each docasoc As e_ReferenciaAsoc In Documento.DocumentosAsociados
    '            With xml_writer
    '                .WriteStartElement(prefixCac, "DespatchDocumentReference", cadCac)
    '                .WriteElementString("ID", cadCbc, docasoc.Referencia)
    '                .WriteStartElement(prefixCbc, "DocumentTypeCode", cadCbc)
    '                .WriteAttributeString("listName", "SUNAT:Identificador de Tipo de Documento")
    '                .WriteAttributeString("listAgencyName", "PE:SUNAT")
    '                .WriteAttributeString("listURI", "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo01")
    '                .WriteString("09")
    '                .WriteEndElement() 'DocumentTypeCode
    '                .WriteEndElement() 'DespatchDocumentReference
    '            End With
    '        Next
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    Private Sub lr_Emisor(xml_writer As XmlWriter, Documento As e_ComprobantePagoElectronico)
        Try
            With xml_writer
                .WriteStartElement(prefixCac, "AccountingSupplierParty", cadCac)
                '.WriteElementString("CustomerAssignedAccountID", cadCbc, Documento.RUCEmisor.Trim)
                '.WriteElementString("AdditionalAccountID", cadCbc, "6")
                .WriteStartElement(prefixCac, "Party", cadCac)
                .WriteStartElement(prefixCac, "PartyIdentification", cadCac)
                .WriteStartElement(prefixCbc, "ID", cadCbc)
                .WriteAttributeString("schemeID", "6")
                .WriteAttributeString("schemeName", "Documento de Identidad") ' Identificador de Tipo de Documento
                .WriteAttributeString("schemeAgencyName", "PE:SUNAT")
                .WriteAttributeString("schemeURI", "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo06")
                .WriteString(Documento.RUCEmisor.Trim)
                .WriteEndElement() 'ID
                .WriteEndElement() 'PartyIdentification

                If Documento.NombreComercial.Trim.Length > 0 Then
                    .WriteStartElement(prefixCac, "PartyName", cadCac)
                    .WriteStartElement(prefixCbc, "Name", cadCbc)
                    .WriteString(Documento.NombreComercial)
                    .WriteEndElement() 'Name
                    .WriteEndElement() 'PartyName
                End If
                .WriteStartElement(prefixCac, "PartyLegalEntity", cadCac)
                .WriteElementString("RegistrationName", cadCbc, Documento.RazonSocial)
                .WriteStartElement(prefixCac, "RegistrationAddress", cadCac)
                .WriteElementString("ID", cadCbc, gstrUbigeoEmpresa)
                .WriteElementString("AddressTypeCode", cadCbc, "0000")
                .WriteElementString("CityName", cadCbc, gstrDepartamentoEmpresa)
                .WriteElementString("CountrySubentity", cadCbc, gstrProvinciaEmpresa)
                .WriteElementString("District", cadCbc, gstrDistritoEmpresa)
                .WriteStartElement(prefixCac, "AddressLine", cadCac)
                .WriteElementString("Line", cadCbc, gstrDireccion)
                .WriteEndElement() 'AddressLine
                .WriteStartElement(prefixCac, "Country", cadCac)
                .WriteElementString("IdentificationCode", cadCbc, "PE")
                .WriteEndElement() 'Country
                .WriteEndElement() 'RegistrationAddress
                .WriteEndElement() 'PartyLegalEntity
                '.WriteEndElement() 'PartyTaxScheme
                .WriteEndElement() 'Party
                .WriteEndElement() 'AccountingSupplierParty
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_Receptor20(xml_writer As XmlWriter, Documento As e_ComprobantePagoElectronico)
        Try
            With xml_writer
                .WriteStartElement(prefixCac, "AccountingCustomerParty", cadCac)
                .WriteElementString("CustomerAssignedAccountID", cadCbc, Documento.DocumentoReceptor)
                .WriteElementString("AdditionalAccountID", cadCbc, IIf(Documento.DocumentoReceptor.Length = "11", "6", "1"))
                .WriteStartElement(prefixCac, "Party", cadCac)
                .WriteStartElement(prefixCac, "PartyLegalEntity", cadCac)
                .WriteElementString("RegistrationName", cadCbc, Documento.Receptor)
                .WriteEndElement() 'PartyLegalEntity
                .WriteEndElement() 'Party
                .WriteEndElement() 'AccountingCustomerParty
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_Receptor(xml_writer As XmlWriter, Documento As e_ComprobantePagoElectronico, IndDireccion As Boolean)
        Try
            With xml_writer
                .WriteStartElement(prefixCac, "AccountingCustomerParty", cadCac)
                .WriteStartElement(prefixCac, "Party", cadCac)
                .WriteStartElement(prefixCac, "PartyIdentification", cadCac)
                .WriteStartElement(prefixCbc, "ID", cadCbc)
                .WriteAttributeString("schemeID", "6")
                .WriteAttributeString("schemeName", "Documento de Identidad") ' Identificador de Tipo de Documento
                .WriteAttributeString("schemeAgencyName", "PE:SUNAT")
                .WriteAttributeString("schemeURI", "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo06")
                .WriteString(Documento.DocumentoReceptor)
                .WriteEndElement() 'ID
                .WriteEndElement() 'PartyIdentification
                .WriteStartElement(prefixCac, "PartyLegalEntity", cadCac)
                .WriteElementString("RegistrationName", cadCbc, Documento.Receptor)
                .WriteEndElement() 'PartyLegalEntity
                .WriteEndElement() 'Party
                .WriteEndElement() 'AccountingCustomerParty
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_DescuentosGlobales(xml_writer As XmlWriter, Documento As e_ComprobantePagoElectronico)
        Try
            With xml_writer
                .WriteStartElement(prefixCac, "AllowanceCharge", cadCac)
                .WriteElementString("ChargeIndicator", cadCbc, "false")
                .WriteElementString("AllowanceChargeReasonCode", cadCbc, "00")
                .WriteElementString("MultiplierFactorNumeric", cadCbc, Documento.PorcentajeDcto.ToString("F2")) 'porcentaje
                .WriteStartElement(prefixCbc, "Amount", cadCbc)
                .WriteAttributeString("currencyID", Documento.Moneda) '
                .WriteString(Documento.DctoGlobal.ToString("F2")) ' totaldescuentos
                .WriteEndElement() 'Amount
                .WriteStartElement(prefixCbc, "BaseAmount", cadCbc)
                .WriteAttributeString("currencyID", Documento.Moneda) '
                .WriteString(Documento.Total.ToString("F2")) ' totaldocumento
                .WriteEndElement() 'BaseAmount
                .WriteEndElement() 'AllowanceCharge
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_Impuestos(xml_writer As XmlWriter, Documento As e_ComprobantePagoElectronico, Ind21 As Boolean)
        Try
            With xml_writer
                .WriteStartElement(prefixCac, "TaxTotal", cadCac)
                .WriteStartElement(prefixCbc, "TaxAmount", cadCbc)
                .WriteAttributeString("currencyID", Documento.Moneda)
                '.WriteString((Documento.TotalIGV + Documento.TotalISC + Documento.TotalInafecto + Documento.TotalExo).ToString("F2"))
                .WriteString(Documento.TotalIGV.ToString("F2"))
                .WriteEndElement() 'TaxAmount
                If Documento.TotalIGV > 0 Then
                    .WriteStartElement(prefixCac, "TaxSubtotal", cadCac)
                    If Ind21 Then
                        .WriteStartElement(prefixCbc, "TaxableAmount", cadCbc)
                        .WriteAttributeString("currencyID", Documento.Moneda)
                        .WriteString(Documento.SubTotal.ToString("F2"))
                        .WriteEndElement() 'TaxableAmount
                    End If
                    .WriteStartElement(prefixCbc, "TaxAmount", cadCbc)
                    .WriteAttributeString("currencyID", Documento.Moneda)
                    .WriteString(Documento.TotalIGV.ToString("F2"))
                    .WriteEndElement() 'TaxAmount
                    .WriteStartElement(prefixCac, "TaxCategory", cadCac)
                    If Ind21 Then
                        .WriteStartElement(prefixCbc, "ID", cadCbc)
                        .WriteAttributeString("schemeID", "UN/ECE 5305")
                        .WriteAttributeString("schemeName", "Tax Category Identifier")
                        .WriteAttributeString("schemeAgencyName", "United Nations Economic Commission for Europe")
                        .WriteString("S")
                        .WriteEndElement() 'ID
                    End If
                    .WriteStartElement(prefixCac, "TaxScheme", cadCac)
                    If Ind21 Then
                        .WriteStartElement(prefixCbc, "ID", cadCbc)
                        .WriteAttributeString("schemeID", "UN/ECE 5153")
                        .WriteAttributeString("schemeAgencyID", "6")
                        .WriteString("1000")
                        .WriteEndElement() 'ID
                    Else
                        .WriteElementString("ID", cadCbc, "1000")
                    End If
                    .WriteElementString("Name", cadCbc, "IGV")
                    .WriteElementString("TaxTypeCode", cadCbc, "VAT")
                    .WriteEndElement() 'TaxScheme
                    .WriteEndElement() 'TaxCategory
                    .WriteEndElement() 'TaxSubtotal
                End If

                If Documento.TotalISC > 0 Then
                    .WriteStartElement(prefixCac, "TaxSubtotal", cadCac)
                    .WriteStartElement(prefixCbc, "TaxableAmount", cadCbc)
                    .WriteAttributeString("currencyID", Documento.Moneda)
                    .WriteString(Documento.SubTotal.ToString("F2"))
                    .WriteEndElement() 'TaxableAmount
                    .WriteStartElement(prefixCbc, "TaxAmount", cadCbc)
                    .WriteAttributeString("currencyID", Documento.Moneda)
                    .WriteString(Documento.TotalISC.ToString("F2"))
                    .WriteEndElement() 'TaxAmount
                    .WriteStartElement(prefixCac, "TaxCategory", cadCac)
                    .WriteStartElement(prefixCbc, "ID", cadCbc)
                    .WriteAttributeString("schemeID", "UN/ECE 5305")
                    .WriteAttributeString("schemeName", "Tax Category Identifier")
                    .WriteAttributeString("schemeAgencyName", "United Nations Economic Commission for Europe")
                    .WriteString("S")
                    .WriteEndElement() 'ID
                    .WriteStartElement(prefixCac, "TaxScheme", cadCac)
                    .WriteStartElement(prefixCbc, "ID", cadCbc)
                    .WriteAttributeString("schemeID", "UN/ECE 5153")
                    .WriteAttributeString("schemeAgencyID", "6")
                    .WriteString("2000")
                    .WriteEndElement() 'ID
                    .WriteElementString("Name", cadCbc, "ISC")
                    .WriteElementString("TaxTypeCode", cadCbc, "EXC")
                    .WriteEndElement() 'TaxScheme
                    .WriteEndElement() 'TaxCategory
                    .WriteEndElement() 'TaxSubtotal
                End If

                If Documento.TotalExo > 0 Then
                    .WriteStartElement(prefixCac, "TaxSubtotal", cadCac)
                    .WriteStartElement(prefixCbc, "TaxableAmount", cadCbc)
                    .WriteAttributeString("currencyID", Documento.Moneda)
                    .WriteString(Documento.SubTotal.ToString("F2"))
                    .WriteEndElement() 'TaxableAmount
                    .WriteStartElement(prefixCbc, "TaxAmount", cadCbc)
                    .WriteAttributeString("currencyID", Documento.Moneda)
                    .WriteString(0.ToString("F2"))
                    .WriteEndElement() 'TaxAmount
                    .WriteStartElement(prefixCac, "TaxCategory", cadCac)
                    .WriteStartElement(prefixCbc, "ID", cadCbc)
                    .WriteAttributeString("schemeID", "UN/ECE 5305")
                    .WriteAttributeString("schemeName", "Tax Category Identifier")
                    .WriteAttributeString("schemeAgencyName", "United Nations Economic Commission for Europe")
                    .WriteString("E")
                    .WriteEndElement() 'ID
                    .WriteStartElement(prefixCac, "TaxScheme", cadCac)
                    .WriteStartElement(prefixCbc, "ID", cadCbc)
                    .WriteAttributeString("schemeID", "UN/ECE 5153")
                    .WriteAttributeString("schemeAgencyID", "6")
                    .WriteString("9997")
                    .WriteEndElement() 'ID
                    .WriteElementString("Name", cadCbc, "EXO")
                    .WriteElementString("TaxTypeCode", cadCbc, "VAT")
                    .WriteEndElement() 'TaxScheme
                    .WriteEndElement() 'TaxCategory
                    .WriteEndElement() 'TaxSubtotal
                End If

                If Documento.TotalInafecto > 0 Then
                    .WriteStartElement(prefixCac, "TaxSubtotal", cadCac)
                    .WriteStartElement(prefixCbc, "TaxableAmount", cadCbc)
                    .WriteAttributeString("currencyID", Documento.Moneda)
                    .WriteString(Documento.SubTotal.ToString("F2"))
                    .WriteEndElement() 'TaxableAmount
                    .WriteStartElement(prefixCbc, "TaxAmount", cadCbc)
                    .WriteAttributeString("currencyID", Documento.Moneda)
                    .WriteString(Documento.TotalInafecto.ToString("F2"))
                    .WriteEndElement() 'TaxAmount
                    .WriteStartElement(prefixCac, "TaxCategory", cadCac)
                    .WriteStartElement(prefixCbc, "ID", cadCbc)
                    .WriteAttributeString("schemeID", "UN/ECE 5305")
                    .WriteAttributeString("schemeName", "Tax Category Identifier")
                    .WriteAttributeString("schemeAgencyName", "United Nations Economic Commission for Europe")
                    .WriteString("O")
                    .WriteEndElement() 'ID
                    .WriteStartElement(prefixCac, "TaxScheme", cadCac)
                    .WriteStartElement(prefixCbc, "ID", cadCbc)
                    .WriteAttributeString("schemeID", "UN/ECE 5153")
                    .WriteAttributeString("schemeAgencyID", "6")
                    .WriteString("9998")
                    .WriteEndElement() 'ID
                    .WriteElementString("Name", cadCbc, "INAFECTO")
                    .WriteElementString("TaxTypeCode", cadCbc, "FRE")
                    .WriteEndElement() 'TaxScheme
                    .WriteEndElement() 'TaxCategory
                    .WriteEndElement() 'TaxSubtotal
                End If

                If Documento.TotalGratis > 0 Then
                    .WriteStartElement(prefixCac, "TaxSubtotal", cadCac)
                    .WriteStartElement(prefixCbc, "TaxableAmount", cadCbc)
                    .WriteAttributeString("currencyID", Documento.Moneda)
                    .WriteString(Documento.SubTotal.ToString("F2"))
                    .WriteEndElement() 'TaxableAmount
                    .WriteStartElement(prefixCbc, "TaxAmount", cadCbc)
                    .WriteAttributeString("currencyID", Documento.Moneda)
                    .WriteString(Documento.TotalGratis.ToString("F2"))
                    .WriteEndElement() 'TaxAmount
                    .WriteStartElement(prefixCac, "TaxCategory", cadCac)
                    .WriteStartElement(prefixCbc, "ID", cadCbc)
                    .WriteAttributeString("schemeID", "UN/ECE 5305")
                    .WriteAttributeString("schemeName", "Tax Category Identifier")
                    .WriteAttributeString("schemeAgencyName", "United Nations Economic Commission for Europe")
                    .WriteString("Z")
                    .WriteEndElement() 'ID
                    .WriteStartElement(prefixCac, "TaxScheme", cadCac)
                    .WriteStartElement(prefixCbc, "ID", cadCbc)
                    .WriteAttributeString("schemeID", "UN/ECE 5153")
                    .WriteAttributeString("schemeAgencyID", "6")
                    .WriteString("9996")
                    .WriteEndElement() 'ID
                    .WriteElementString("Name", cadCbc, "GRATUITO")
                    .WriteElementString("TaxTypeCode", cadCbc, "FRE")
                    .WriteEndElement() 'TaxScheme
                    .WriteEndElement() 'TaxCategory
                    .WriteEndElement() 'TaxSubtotal
                End If

                If Documento.TotalOtros > 0 Then
                    .WriteStartElement(prefixCac, "TaxSubtotal", cadCac)
                    .WriteStartElement(prefixCbc, "TaxableAmount", cadCbc)
                    .WriteAttributeString("currencyID", Documento.Moneda)
                    .WriteString(Documento.SubTotal.ToString("F2"))
                    .WriteEndElement() 'TaxableAmount
                    .WriteStartElement(prefixCbc, "TaxAmount", cadCbc)
                    .WriteAttributeString("currencyID", Documento.Moneda)
                    .WriteString(Documento.TotalOtros.ToString("F2"))
                    .WriteEndElement() 'TaxAmount
                    .WriteStartElement(prefixCac, "TaxCategory", cadCac)
                    .WriteStartElement(prefixCbc, "ID", cadCbc)
                    .WriteAttributeString("schemeID", "UN/ECE 5305")
                    .WriteAttributeString("schemeName", "Tax Category Identifier")
                    .WriteAttributeString("schemeAgencyName", "United Nations Economic Commission for Europe")
                    .WriteString("O")
                    .WriteEndElement() 'ID
                    .WriteStartElement(prefixCac, "TaxScheme", cadCac)
                    .WriteStartElement(prefixCbc, "ID", cadCbc)
                    .WriteAttributeString("schemeID", "UN/ECE 5153")
                    .WriteAttributeString("schemeAgencyID", "6")
                    .WriteString("9999")
                    .WriteEndElement() 'ID
                    .WriteElementString("Name", cadCbc, "OTROS CONCEPTOS DE PAGO")
                    .WriteElementString("TaxTypeCode", cadCbc, "OTH")
                    .WriteEndElement() 'TaxScheme
                    .WriteEndElement() 'TaxCategory
                    .WriteEndElement() 'TaxSubtotal
                End If

                .WriteEndElement() 'taxtotal
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_Totales(xml_writer As XmlWriter, Documento As e_ComprobantePagoElectronico, lb_Ind21 As Boolean)
        Try
            With xml_writer
                If Documento.TipoDocumento = "08" Then
                    .WriteStartElement(prefixCac, "RequestedMonetaryTotal", cadCac)
                Else
                    .WriteStartElement(prefixCac, "LegalMonetaryTotal", cadCac)
                End If
                If lb_Ind21 Then
                    Select Case Documento.TipoDocumento
                        Case "01", "03"
                            .WriteStartElement(prefixCbc, "LineExtensionAmount", cadCbc) ' subtotal
                            .WriteAttributeString("currencyID", Documento.Moneda)
                            .WriteString(Documento.SubTotal.ToString("F2"))
                            .WriteEndElement() 'LineExtensionAmount
                            .WriteStartElement(prefixCbc, "TaxInclusiveAmount", cadCbc) ' subtotal
                            .WriteAttributeString("currencyID", Documento.Moneda)
                            .WriteString((Documento.Total + Documento.DctoGlobal).ToString("F2"))
                            .WriteEndElement() 'LineExtensionAmount
                            .WriteStartElement(prefixCbc, "AllowanceTotalAmount", cadCbc) ' descuentos
                            .WriteAttributeString("currencyID", Documento.Moneda)
                            .WriteString(Documento.DctoGlobal.ToString("F2"))
                            .WriteEndElement() 'AllowanceTotalAmount
                            .WriteStartElement(prefixCbc, "ChargeTotalAmount", cadCbc) ' subtotal + igv
                            .WriteAttributeString("currencyID", Documento.Moneda)
                            .WriteString(Documento.TotalOtros.ToString("F2"))
                            .WriteEndElement() 'ChargeTotalAmount
                        Case "07"
                            .WriteStartElement(prefixCbc, "TaxInclusiveAmount", cadCbc) ' subtotal + igv
                            .WriteAttributeString("currencyID", Documento.Moneda)
                            .WriteString(Documento.Total.ToString("F2"))
                            .WriteEndElement() 'TaxInclusiveAmount
                    End Select
                End If
                .WriteStartElement(prefixCbc, "PayableAmount", cadCbc) ' subtotal + igv + descuentos
                .WriteAttributeString("currencyID", Documento.Moneda)
                .WriteString((Documento.Total + Documento.DctoGlobal).ToString("F2"))
                .WriteEndElement() 'PayableAmount
                .WriteEndElement() 'LegalMonetaryTotal
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_Detalles(xml_writer As XmlWriter, Documento As e_ComprobantePagoElectronico, lb_Ind21 As Boolean)
        Try
            Dim TipoDoc As String = ""
            Dim Cantidad As String = ""
            Select Case Documento.TipoDocumento
                Case "01", "03"
                    TipoDoc = "InvoiceLine"
                    Cantidad = "Invoiced"
                Case "07"
                    TipoDoc = "CreditNoteLine"
                    Cantidad = "Credited"
                Case "08"
                    TipoDoc = "DebitNoteLine"
                    Cantidad = "Debited"
            End Select
            For Each detalle As e_ComprobantePagoElectronico_Detalle In Documento.Detalles
                With xml_writer
                    .WriteStartElement(prefixCac, TipoDoc, cadCac)
                    .WriteElementString("ID", cadCbc, ln_Cont)

                    'cantidad y unidad de medida ZZ, NIU
                    .WriteStartElement(prefixCbc, Cantidad & "Quantity", cadCbc)
                    .WriteAttributeString("unitCode", IIf(detalle.IndMaterial_Servicio = "S", "ZZ", detalle.UMedida))
                    If lb_Ind21 Then
                        .WriteAttributeString("unitCodeListID", "UN/ECE rec 20")
                        .WriteAttributeString("unitCodeListAgencyName", "United Nations Economic Commission for Europe")
                    End If
                    .WriteString((detalle.Cantidad).ToString("F2"))
                    .WriteEndElement() 'InvoicedQuantity

                    'LineExtensionAmount  total valor unitario
                    .WriteStartElement(prefixCbc, "LineExtensionAmount", cadCbc)
                    .WriteAttributeString("currencyID", Documento.Moneda)
                    .WriteString((detalle.CostoTotal).ToString("F2"))
                    .WriteEndElement() 'LineExtensionAmount

                    'precio unitario
                    .WriteStartElement(prefixCac, "PricingReference", cadCac)
                    .WriteStartElement(prefixCac, "AlternativeConditionPrice", cadCac)
                    .WriteStartElement(prefixCbc, "PriceAmount", cadCbc)
                    .WriteAttributeString("currencyID", Documento.Moneda)
                    .WriteString((detalle.PrecioUnitario).ToString("F2"))
                    .WriteEndElement() 'PriceAmount
                    .WriteStartElement(prefixCbc, "PriceTypeCode", cadCbc)
                    If lb_Ind21 Then
                        .WriteAttributeString("listName", "Tipo de Precio")
                        .WriteAttributeString("listAgencyName", "PE:SUNAT")
                        .WriteAttributeString("listURI", "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo16")
                    End If
                    .WriteString("01")
                    .WriteEndElement() 'PriceTypeCode
                    .WriteEndElement() 'AlternativeConditionPrice
                    .WriteEndElement() 'PricingReference

                    ''Valor referencial unitario por ítem en operaciones no onerosas

                    'detalle impuesto IGV
                    If detalle.IndIGV Or detalle.IndExonerada Or detalle.IndInafecta Or detalle.IndISC Or detalle.IndIVAP Then
                        .WriteStartElement(prefixCac, "TaxTotal", cadCac)
                        .WriteStartElement(prefixCbc, "TaxAmount", cadCbc)
                        .WriteAttributeString("currencyID", Documento.Moneda)
                        .WriteString((detalle.TotalIGV + detalle.TotalExonerada + detalle.TotalInafecta + detalle.TotalISC + detalle.TotalIVAP).ToString("F2"))
                        .WriteEndElement() 'TaxAmount

                        If detalle.IndIGV Then
                            .WriteStartElement(prefixCac, "TaxSubtotal", cadCac)
                            If lb_Ind21 Then
                                .WriteStartElement(prefixCbc, "TaxableAmount", cadCbc)
                                .WriteAttributeString("currencyID", Documento.Moneda)
                                .WriteString((detalle.CostoTotal).ToString("F2"))
                                .WriteEndElement() 'TaxableAmount
                            End If
                            .WriteStartElement(prefixCbc, "TaxAmount", cadCbc)
                            .WriteAttributeString("currencyID", Documento.Moneda)
                            .WriteString((detalle.TotalIGV).ToString("F2"))
                            .WriteEndElement() 'TaxAmount
                            .WriteStartElement(prefixCac, "TaxCategory", cadCac)
                            If lb_Ind21 Then
                                .WriteStartElement(prefixCbc, "ID", cadCbc)
                                .WriteAttributeString("schemeID", "UN/ECE 5305")
                                .WriteAttributeString("schemeName", "Tax Category Identifier")
                                .WriteAttributeString("schemeAgencyName", "United Nations Economic Commission for Europe")
                                .WriteString("S")
                                .WriteEndElement() 'ID
                                .WriteElementString("Percent", cadCbc, (gdecIGV * 100).ToString("F2"))
                            End If
                            .WriteStartElement(prefixCbc, "TaxExemptionReasonCode", cadCbc)
                            If lb_Ind21 Then
                                .WriteAttributeString("listAgencyName", "PE:SUNAT")
                                .WriteAttributeString("listName", "Afectacion del IGV")
                                .WriteAttributeString("listURI", "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo07")
                            End If
                            .WriteString("10")
                            .WriteEndElement() 'TaxExemptionReasonCode
                            .WriteStartElement(prefixCac, "TaxScheme", cadCac)
                            .WriteElementString("ID", cadCbc, "1000")
                            .WriteElementString("Name", cadCbc, "IGV")
                            .WriteElementString("TaxTypeCode", cadCbc, "VAT")
                            .WriteEndElement() 'TaxScheme
                            .WriteEndElement() 'TaxCategory
                            .WriteEndElement() 'TaxSubtotal
                        End If

                        If detalle.IndExonerada Then
                            .WriteStartElement(prefixCac, "TaxSubtotal", cadCac)

                            .WriteStartElement(prefixCbc, "TaxableAmount", cadCbc)
                            .WriteAttributeString("currencyID", Documento.Moneda)
                            .WriteString((detalle.CostoTotal).ToString("F2"))
                            .WriteEndElement() 'TaxableAmount

                            .WriteStartElement(prefixCbc, "TaxAmount", cadCbc)
                            .WriteAttributeString("currencyID", Documento.Moneda)
                            .WriteString(0.ToString("F2"))
                            .WriteEndElement() 'TaxAmount

                            .WriteStartElement(prefixCac, "TaxCategory", cadCac)

                            .WriteStartElement(prefixCbc, "ID", cadCbc)
                            .WriteAttributeString("schemeID", "UN/ECE 5305")
                            .WriteAttributeString("schemeName", "Tax Category Identifier")
                            .WriteAttributeString("schemeAgencyName", "United Nations Economic Commission for Europe")
                            .WriteString("E")
                            .WriteEndElement() 'ID

                            .WriteElementString("Percent", cadCbc, (gdecIGV * 100).ToString("F2"))

                            .WriteStartElement(prefixCbc, "TaxExemptionReasonCode", cadCbc)
                            .WriteAttributeString("listAgencyName", "PE:SUNAT")
                            .WriteAttributeString("listName", "Afectacion del IGV")
                            .WriteAttributeString("listURI", "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo07")
                            .WriteString("20")
                            .WriteEndElement() 'TaxExemptionReasonCode

                            .WriteStartElement(prefixCac, "TaxScheme", cadCac)
                            .WriteElementString("ID", cadCbc, "9997")
                            .WriteElementString("Name", cadCbc, "EXO")
                            .WriteElementString("TaxTypeCode", cadCbc, "VAT")
                            .WriteEndElement() 'TaxScheme

                            .WriteEndElement() 'TaxCategory

                            .WriteEndElement() 'TaxSubtotal
                        End If

                        If detalle.IndInafecta Then
                            .WriteStartElement(prefixCac, "TaxSubtotal", cadCac)

                            .WriteStartElement(prefixCbc, "TaxableAmount", cadCbc)
                            .WriteAttributeString("currencyID", Documento.Moneda)
                            .WriteString((detalle.CostoTotal).ToString("F2"))
                            .WriteEndElement() 'TaxableAmount

                            .WriteStartElement(prefixCbc, "TaxAmount", cadCbc)
                            .WriteAttributeString("currencyID", Documento.Moneda)
                            .WriteString((detalle.TotalInafecta).ToString("F2"))
                            .WriteEndElement() 'TaxAmount

                            .WriteStartElement(prefixCac, "TaxCategory", cadCac)

                            .WriteStartElement(prefixCbc, "ID", cadCbc)
                            .WriteAttributeString("schemeID", "UN/ECE 5305")
                            .WriteAttributeString("schemeName", "Tax Category Identifier")
                            .WriteAttributeString("schemeAgencyName", "United Nations Economic Commission for Europe")
                            .WriteString("O")
                            .WriteEndElement() 'ID

                            .WriteElementString("Percent", cadCbc, 0.ToString("F2"))

                            .WriteStartElement(prefixCbc, "TaxExemptionReasonCode", cadCbc)
                            .WriteAttributeString("listAgencyName", "PE:SUNAT")
                            .WriteAttributeString("listName", "Afectacion del IGV")
                            .WriteAttributeString("listURI", "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo07")
                            .WriteString("30")
                            .WriteEndElement() 'TaxExemptionReasonCode
                            '.WriteElementString("TierRange", cadCbc, "01")
                            .WriteStartElement(prefixCac, "TaxScheme", cadCac)
                            .WriteElementString("ID", cadCbc, "9998")
                            .WriteElementString("Name", cadCbc, "INAFECTO")
                            .WriteElementString("TaxTypeCode", cadCbc, "FRE")
                            .WriteEndElement() 'TaxScheme

                            .WriteEndElement() 'TaxCategory

                            .WriteEndElement() 'TaxSubtotal
                        End If

                        If detalle.IndISC Then
                            .WriteStartElement(prefixCac, "TaxSubtotal", cadCac)

                            .WriteStartElement(prefixCbc, "TaxableAmount", cadCbc)
                            .WriteAttributeString("currencyID", Documento.Moneda)
                            .WriteString((detalle.CostoTotal).ToString("F2"))
                            .WriteEndElement() 'TaxableAmount

                            .WriteStartElement(prefixCbc, "TaxAmount", cadCbc)
                            .WriteAttributeString("currencyID", Documento.Moneda)
                            .WriteString((detalle.TotalIGV).ToString("F2"))
                            .WriteEndElement() 'TaxAmount

                            .WriteStartElement(prefixCac, "TaxCategory", cadCac)

                            .WriteStartElement(prefixCbc, "ID", cadCbc)
                            .WriteAttributeString("schemeID", "UN/ECE 5305")
                            .WriteAttributeString("schemeName", "Tax Category Identifier")
                            .WriteAttributeString("schemeAgencyName", "United Nations Economic Commission for Europe")
                            .WriteString("S")
                            .WriteEndElement() 'ID

                            .WriteElementString("Percent", cadCbc, 0.ToString("F2"))

                            .WriteStartElement(prefixCbc, "TaxExemptionReasonCode", cadCbc)
                            .WriteAttributeString("listAgencyName", "PE:SUNAT")
                            .WriteAttributeString("listName", "Afectacion del IGV")
                            .WriteAttributeString("listURI", "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo07")
                            .WriteString("10")
                            .WriteEndElement() 'TaxExemptionReasonCode
                            .WriteElementString("TierRange", cadCbc, "01")
                            .WriteStartElement(prefixCac, "TaxScheme", cadCac)
                            .WriteElementString("ID", cadCbc, "2000")
                            .WriteElementString("Name", cadCbc, "ISC")
                            .WriteElementString("TaxTypeCode", cadCbc, "EXC")
                            .WriteEndElement() 'TaxScheme

                            .WriteEndElement() 'TaxCategory

                            .WriteEndElement() 'TaxSubtotal
                        End If
                        'If detalle.IndIVAP Then

                        'End If
                        .WriteEndElement() 'TaxTotal
                    End If

                    .WriteStartElement(prefixCac, "Item", cadCac)
                    '.WriteStartElement(prefixCbc, "Description", cadCbc)
                    '.WriteCData(detalle.NombreProducto)
                    '.WriteEndElement() 'Description
                    .WriteElementString("Description", cadCbc, detalle.Producto)

                    If lb_Ind21 Then
                        .WriteStartElement(prefixCac, "SellersItemIdentification", cadCac)
                        .WriteElementString("ID", cadCbc, detalle.IdMaterial)
                        .WriteEndElement() 'SellersItemIdentification
                    End If

                    .WriteEndElement() 'Item

                    .WriteStartElement(prefixCac, "Price", cadCac)
                    .WriteStartElement(prefixCbc, "PriceAmount", cadCbc)
                    .WriteAttributeString("currencyID", Documento.Moneda)
                    .WriteString(detalle.CostoUnitario.ToString("F2"))
                    .WriteEndElement() 'PriceAmount
                    .WriteEndElement() 'Price

                    .WriteEndElement() 'InvoiceLine
                    ln_Cont += 1
                End With
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_Motivo(xml_writer As XmlWriter, Documento As e_ComprobantePagoElectronico)
        Try
            With xml_writer
                .WriteStartElement(prefixCac, "DiscrepancyResponse", cadCac)
                .WriteElementString("ReferenceID", cadCbc, Documento.DocumentoAsoc)
                .WriteElementString("ResponseCode", cadCbc, Documento.CodigoMotivo)
                .WriteElementString("Description", cadCbc, Documento.Glosa)
                .WriteEndElement() 'DiscrepancyResponse
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_DocumentoAfecto(xml_writer As XmlWriter, Documento As e_ComprobantePagoElectronico)
        Try
            With xml_writer
                .WriteStartElement(prefixCac, "BillingReference", cadCac)
                .WriteStartElement(prefixCac, "InvoiceDocumentReference", cadCac)
                .WriteElementString("ID", cadCbc, Documento.DocumentoAsoc)
                .WriteElementString("DocumentTypeCode", cadCbc, Documento.TipoDocAsoc)
                .WriteEndElement() 'InvoiceDocumentReference
                .WriteEndElement() 'BillingReference
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_Emisor20(xml_writer As XmlWriter, Emisor As e_Empresa)
        Try
            With xml_writer
                .WriteStartElement(prefixCac, "AccountingSupplierParty", cadCac)
                .WriteElementString("CustomerAssignedAccountID", cadCbc, Emisor.Ruc)
                .WriteElementString("AdditionalAccountID", cadCbc, "6")
                .WriteStartElement(prefixCac, "Party", cadCac)
                .WriteStartElement(prefixCac, "PartyLegalEntity", cadCac)
                .WriteElementString("RegistrationName", cadCbc, Emisor.Nombre)
                .WriteEndElement() 'PartyLegalEntity
                .WriteEndElement() 'Party
                .WriteEndElement() 'AccountingSupplierParty
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    <OperationBehavior(TransactionScopeRequired:=True)>
    Public Function GenerarEDocBoleta(Documento As e_ComprobantePagoElectronico) As String Implements Il_ComprobantePagoElectronico.GenerarEDocBoleta
        Dim RutaArchivo As String = "" ' gs_RutaDocumentosEle & Documento.RUCEmisor.Trim & "-" & Documento.TipoDocumento & "-" & Documento.Documento & ".xml"
        Try
            settings.Indent = True
            settings.Encoding = System.Text.UTF8Encoding.UTF8
            Using writer As XmlWriter = XmlWriter.Create(RutaArchivo, settings)
                prefixCac = writer.LookupPrefix(cadCac)
                prefixExt = writer.LookupPrefix(cadExt)
                prefixCbc = writer.LookupPrefix(cadCbc)
                prefixDs = writer.LookupPrefix(cadDs)
                writer.WriteStartDocument()
                writer.WriteStartElement("Invoice", "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")
                writer.WriteAttributeString("xmlns", "cac", Nothing, cadCac)
                writer.WriteAttributeString("xmlns", "cbc", Nothing, cadCbc)
                writer.WriteAttributeString("xmlns", "ccts", Nothing, cadCcts)
                writer.WriteAttributeString("xmlns", "ds", Nothing, cadDs)
                writer.WriteAttributeString("xmlns", "ext", Nothing, cadExt)
                writer.WriteAttributeString("xmlns", "qdt", Nothing, cadQdt)
                writer.WriteAttributeString("xmlns", "udt", Nothing, cadUdt)
                writer.WriteAttributeString("xmlns", "xsi", Nothing, cadXsi)
                'inicio
                lr_UBLExtensiones(writer)
                'version UBL
                lr_UBLVersion21(writer)
                'tipo de operacion Valor de Códigos Catálogo N°51
                lr_TipoOperacion(writer, Documento.TipoOperacion)
                'cabecera Documento
                lr_DatosDocumento(writer, Documento)
                'tipo Documento
                lr_TipoDocumento(writer, Documento)
                'Monto Letras y Moneda
                lr_MontoMoneda(writer, Documento)
                'numero detalles
                lr_CantidadDetalles(writer, Documento.Detalles.Where(Function(i) i.IndMaterial_Servicio = Documento.IndMatServ).Count)
                'firma
                lr_FirmaDigital(writer, Documento)
                'documentos asociados
                'If Documento.Detalles.Count > 0 Then
                '    lr_DocumentoAsociado(writer, Documento)
                'End If
                'emisor
                lr_Emisor(writer, Documento)
                'cliente/receptor
                lr_Receptor(writer, Documento, False)
                'descuentos globales
                If Documento.DctoGlobal > 0 Then
                    lr_DescuentosGlobales(writer, Documento)
                End If
                'impuestos
                If Documento.TotalIGV > 0 Or Documento.TotalISC > 0 Or Documento.TotalInafecto > 0 Or Documento.TotalExo > 0 Or Documento.TotalOtros > 0 Or Documento.TotalGratis > 0 Then
                    lr_Impuestos(writer, Documento, True)
                End If
                'totales
                lr_Totales(writer, Documento, True)
                'detalles
                lr_Detalles(writer, Documento, True)
                writer.WriteEndDocument()
                writer.Flush()
                writer.Close()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        Return RutaArchivo
    End Function

    <OperationBehavior(TransactionScopeRequired:=True)>
    Public Function GenerarEDocFactura(Documento As e_ComprobantePagoElectronico, ByRef Hash As String) As String Implements Il_ComprobantePagoElectronico.GenerarEDocFactura
        'Dim SerieNumero As String = Documento.Documento
        Dim RutaArchivo As String = gstrRutaDocumentosEle20 & Documento.RUCEmisor.Trim.Trim & "-" & Documento.TipoDocumento & "-" & Documento.Documento & ".xml"
        Try
            settings.Indent = True
            settings.Encoding = System.Text.Encoding.GetEncoding("ISO-8859-1")

            Using writer As XmlWriter = XmlWriter.Create(RutaArchivo, settings)

                prefixCac = writer.LookupPrefix(cadCac)
                prefixExt = writer.LookupPrefix(cadExt)
                prefixCbc = writer.LookupPrefix(cadCbc)
                prefixDs = writer.LookupPrefix(cadDs)
                writer.WriteStartDocument(False)
                writer.WriteStartElement("Invoice", "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")
                writer.WriteAttributeString("xmlns", "cac", Nothing, cadCac)
                writer.WriteAttributeString("xmlns", "cbc", Nothing, cadCbc)
                writer.WriteAttributeString("xmlns", "ccts", Nothing, cadCcts)
                writer.WriteAttributeString("xmlns", "ds", Nothing, cadDs)
                writer.WriteAttributeString("xmlns", "ext", Nothing, cadExt)
                writer.WriteAttributeString("xmlns", "qdt", Nothing, cadQdt)
                writer.WriteAttributeString("xmlns", "udt", Nothing, cadUdt)
                writer.WriteAttributeString("xmlns", "xsi", Nothing, cadXsi)

                'inicio
                lr_UBLExtensiones(writer)
                'version UBL
                lr_UBLVersion21(writer)
                'tipo de operacion Valor de Códigos Catálogo N°51
                lr_TipoOperacion(writer, Documento.TipoOperacion)
                'cabecera Documento
                lr_DatosDocumento(writer, Documento)
                'tipo Documento
                lr_TipoDocumento(writer, Documento)
                'Monto Letras y Moneda
                lr_MontoMoneda(writer, Documento)
                'numero detalles
                lr_CantidadDetalles(writer, Documento.Detalles.Count)
                'firma
                lr_FirmaDigital(writer, Documento)
                'documentos asociados
                'If Documento.DocumentosAsociados.Count > 0 Then
                '    lr_DocumentoAsociado(writer, Documento)
                'End If
                'emisor
                lr_Emisor(writer, Documento)
                'cliente/receptor
                lr_Receptor(writer, Documento, True)
                'descuentos globales
                If Documento.DctoGlobal > 0 Then
                    lr_DescuentosGlobales(writer, Documento)
                End If
                'impuestos
                If Documento.TotalIGV > 0 Or Documento.TotalISC > 0 Or Documento.TotalInafecto > 0 Or Documento.TotalExo > 0 Or Documento.TotalOtros > 0 Or Documento.TotalGratis > 0 Then
                    lr_Impuestos(writer, Documento, True)
                End If
                'totales
                lr_Totales(writer, Documento, True)
                'detalles
                lr_Detalles(writer, Documento, True)

                writer.WriteEndDocument()
                writer.Flush()
                writer.Close()
            End Using
            FirmarXML(RutaArchivo, Documento.TipoDocumento, Hash)
        Catch ex As Exception
            Throw ex
        End Try
        Return RutaArchivo
    End Function

    <OperationBehavior(TransactionScopeRequired:=True)>
    Public Function GenerarEDocFactura20(Documento As e_ComprobantePagoElectronico, ByRef Hash As String) As String Implements Il_ComprobantePagoElectronico.GenerarEDocFactura20
        ' Dim gstrRutaDocumentosEle20 As String = "D:\Documentos\Compatir\OneDrive\Comprobantes\" & Documento.RUCEmisor.Trim & "\2-0\Documentos\"
        Dim RutaArchivo As String = gstrRutaDocumentosEle20 & Documento.RUCEmisor.Trim.Trim & "-" & Documento.TipoDocumento & "-" & Documento.Documento.Trim & ".xml"
        Try
            settings.Indent = True
            settings.Encoding = System.Text.Encoding.GetEncoding("ISO-8859-1")
            Using writer As XmlWriter = XmlWriter.Create(RutaArchivo, settings)
                prefixCac = writer.LookupPrefix(cadCac)
                prefixExt = writer.LookupPrefix(cadExt)
                prefixCbc = writer.LookupPrefix(cadCbc)
                prefixDs = writer.LookupPrefix(cadDs)
                writer.WriteStartDocument(False)
                writer.WriteStartElement("Invoice", "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")
                writer.WriteAttributeString("xmlns", "cac", Nothing, cadCac)
                writer.WriteAttributeString("xmlns", "cbc", Nothing, cadCbc)
                writer.WriteAttributeString("xmlns", "ccts", Nothing, cadCcts)
                writer.WriteAttributeString("xmlns", "ds", Nothing, cadDs)
                writer.WriteAttributeString("xmlns", "ext", Nothing, cadExt)
                writer.WriteAttributeString("xmlns", "qdt", Nothing, cadQdt)
                writer.WriteAttributeString("xmlns", "udt", Nothing, cadUdt)
                writer.WriteAttributeString("xmlns", "xsi", Nothing, cadXsi)
                'totales
                lr_UBLExtensionesTotales(writer, Documento)
                'version UBL
                lr_UBLVersion20(writer, False)
                'cabecera Documento
                lr_DatosDocumento20(writer, Documento)
                'firma
                lr_FirmaDigital(writer, Documento)
                'emisor
                lr_Emisor20(writer, New e_Empresa With {.Ruc = Documento.RUCEmisor.Trim.Trim, .Nombre = Documento.RazonSocial})
                'cliente/receptor
                lr_Receptor20(writer, Documento)
                'impuestos
                If Documento.TotalIGV > 0 Or Documento.TotalISC > 0 Or Documento.TotalInafecto > 0 Or Documento.TotalExo > 0 Or Documento.TotalOtros > 0 Or Documento.TotalGratis > 0 Then
                    lr_Impuestos(writer, Documento, False)
                End If
                'total
                lr_Totales(writer, Documento, False)
                'detalles
                lr_Detalles(writer, Documento, False)

                writer.WriteEndDocument()
                writer.Flush()
                writer.Close()
            End Using
            FirmarXML(RutaArchivo, Documento.TipoDocumento, Hash)
        Catch ex As Exception
            Throw ex
        End Try
        Return RutaArchivo
    End Function

    <OperationBehavior(TransactionScopeRequired:=True)>
    Public Function GenerarEDocNotaCredito(Documento As e_ComprobantePagoElectronico, ByRef Hash As String) As String Implements Il_ComprobantePagoElectronico.GenerarEDocNotaCredito
        Dim RutaArchivo As String = gstrRutaDocumentosEle20 & Documento.RUCEmisor.Trim & "-" & Documento.TipoDocumento & "-" & Documento.Documento & ".xml"
        Try
            settings.Indent = True
            settings.Encoding = System.Text.UTF8Encoding.UTF8
            Using writer As XmlWriter = XmlWriter.Create(RutaArchivo, settings)
                prefixCac = writer.LookupPrefix(cadCac)
                prefixExt = writer.LookupPrefix(cadExt)
                prefixCbc = writer.LookupPrefix(cadCbc)
                prefixDs = writer.LookupPrefix(cadDs)
                writer.WriteStartDocument()
                writer.WriteStartElement("CreditNote", "urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2")
                writer.WriteAttributeString("xmlns", "cac", Nothing, cadCac)
                writer.WriteAttributeString("xmlns", "cbc", Nothing, cadCbc)
                writer.WriteAttributeString("xmlns", "ccts", Nothing, cadCcts)
                writer.WriteAttributeString("xmlns", "ds", Nothing, cadDs)
                writer.WriteAttributeString("xmlns", "ext", Nothing, cadExt)
                writer.WriteAttributeString("xmlns", "qdt", Nothing, cadQdt)
                writer.WriteAttributeString("xmlns", "udt", Nothing, cadUdt)
                writer.WriteAttributeString("xmlns", "xsi", Nothing, cadXsi)
                'inicio
                lr_UBLExtensiones(writer)
                'version UBL
                lr_UBLVersion21(writer)
                'cabecera Documento
                lr_DatosDocumento(writer, Documento)
                'moneda
                lr_MontoMoneda(writer, Documento)
                'motivo
                lr_Motivo(writer, Documento)
                'documento afecto
                lr_DocumentoAfecto(writer, Documento)
                'firma
                lr_FirmaDigital(writer, Documento)
                'emisor
                lr_Emisor(writer, Documento)
                'receptor
                lr_Receptor(writer, Documento, False)
                'impuestos
                If Documento.TotalIGV > 0 Or Documento.TotalISC > 0 Or Documento.TotalInafecto > 0 Or Documento.TotalExo > 0 Or Documento.TotalOtros > 0 Or Documento.TotalGratis > 0 Then
                    lr_Impuestos(writer, Documento, True)
                End If
                'totales
                lr_Totales(writer, Documento, True)
                'detalles
                lr_Detalles(writer, Documento, True)
                writer.WriteEndDocument()
                writer.Flush()
                writer.Close()
            End Using
            FirmarXML(RutaArchivo, Documento.TipoDocumento, Hash)
        Catch ex As Exception
            Throw ex
        End Try
        Return RutaArchivo
    End Function

    <OperationBehavior(TransactionScopeRequired:=True)>
    Public Function GenerarEDocNotaCredito20(Documento As e_ComprobantePagoElectronico, ByRef Hash As String) As String Implements Il_ComprobantePagoElectronico.GenerarEDocNotaCredito20
        'Dim gstrRutaDocumentosEle20 As String = "D:\Documentos\Compatir\OneDrive\Comprobantes\" & Documento.RUCEmisor.Trim & "\2-0\Documentos\"
        Dim RutaArchivo As String = gstrRutaDocumentosEle20 & Documento.RUCEmisor.Trim & "-" & Documento.TipoDocumento & "-" & Documento.Documento & ".xml"
        Try
            settings.Indent = True
            settings.Encoding = System.Text.UTF8Encoding.UTF8
            Using writer As XmlWriter = XmlWriter.Create(RutaArchivo, settings)
                prefixCac = writer.LookupPrefix(cadCac)
                prefixExt = writer.LookupPrefix(cadExt)
                prefixCbc = writer.LookupPrefix(cadCbc)
                prefixDs = writer.LookupPrefix(cadDs)
                writer.WriteStartDocument()
                writer.WriteStartElement("CreditNote", "urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2")
                writer.WriteAttributeString("xmlns", "cac", Nothing, cadCac)
                writer.WriteAttributeString("xmlns", "cbc", Nothing, cadCbc)
                writer.WriteAttributeString("xmlns", "ccts", Nothing, cadCcts)
                writer.WriteAttributeString("xmlns", "ds", Nothing, cadDs)
                writer.WriteAttributeString("xmlns", "ext", Nothing, cadExt)
                writer.WriteAttributeString("xmlns", "qdt", Nothing, cadQdt)
                writer.WriteAttributeString("xmlns", "udt", Nothing, cadUdt)
                writer.WriteAttributeString("xmlns", "xsi", Nothing, cadXsi)
                'totales
                lr_UBLExtensionesTotales(writer, Documento)
                'version UBL
                lr_UBLVersion20(writer, False)
                'cabecera Documento
                lr_DatosDocumento20(writer, Documento)
                'motivo
                lr_Motivo(writer, Documento)
                'documento afecto
                lr_DocumentoAfecto(writer, Documento)
                'firma
                lr_FirmaDigital(writer, Documento)
                'emisor
                lr_Emisor20(writer, New e_Empresa With {.Ruc = Documento.RUCEmisor.Trim, .Nombre = Documento.RazonSocial})
                'cliente/receptor
                lr_Receptor20(writer, Documento)
                'impuestos
                If Documento.TotalIGV > 0 Or Documento.TotalISC > 0 Or Documento.TotalInafecto > 0 Or Documento.TotalExo > 0 Or Documento.TotalOtros > 0 Or Documento.TotalGratis > 0 Then
                    lr_Impuestos(writer, Documento, False)
                End If
                'total
                lr_Totales(writer, Documento, False)
                'detalles
                lr_Detalles(writer, Documento, False)

                writer.WriteEndDocument()
                writer.Flush()
                writer.Close()
            End Using
            FirmarXML(RutaArchivo, Documento.TipoDocumento, Hash)
        Catch ex As Exception
            Throw ex
        End Try
        Return RutaArchivo
    End Function

    <OperationBehavior(TransactionScopeRequired:=True)>
    Public Function GenerarEDocNotaDebito(Documento As e_ComprobantePagoElectronico, ByRef Hash As String) As String Implements Il_ComprobantePagoElectronico.GenerarEDocNotaDebito
        Dim RutaArchivo As String = "" ' gs_RutaDocumentosEle & Documento.RUCEmisor.Trim & "-" & Documento.TipoDocumento & "-" & Documento.Documento & ".xml"
        Try
            settings.Indent = True
            settings.Encoding = System.Text.UTF8Encoding.UTF8
            Using writer As XmlWriter = XmlWriter.Create(RutaArchivo, settings)
                prefixCac = writer.LookupPrefix(cadCac)
                prefixExt = writer.LookupPrefix(cadExt)
                prefixCbc = writer.LookupPrefix(cadCbc)
                prefixDs = writer.LookupPrefix(cadDs)
                writer.WriteStartDocument()
                writer.WriteStartElement("DebitNote", "urn:oasis:names:specification:ubl:schema:xsd:DebitNote-2")
                writer.WriteAttributeString("xmlns", "cac", Nothing, cadCac)
                writer.WriteAttributeString("xmlns", "cbc", Nothing, cadCbc)
                writer.WriteAttributeString("xmlns", "ccts", Nothing, cadCcts)
                writer.WriteAttributeString("xmlns", "ds", Nothing, cadDs)
                writer.WriteAttributeString("xmlns", "ext", Nothing, cadExt)
                writer.WriteAttributeString("xmlns", "qdt", Nothing, cadQdt)
                writer.WriteAttributeString("xmlns", "udt", Nothing, cadUdt)
                writer.WriteAttributeString("xmlns", "xsi", Nothing, cadXsi)
                'inicio
                lr_UBLExtensiones(writer)
                'version UBL
                lr_UBLVersion21(writer)
                'cabecera Documento
                lr_DatosDocumento(writer, Documento)
                'moneda
                lr_MontoMoneda(writer, Documento)
                'motivo
                lr_Motivo(writer, Documento)
                'documento afecto
                lr_DocumentoAfecto(writer, Documento)
                'firma
                lr_FirmaDigital(writer, Documento)
                'emisor
                lr_Emisor(writer, Documento)
                'receptor
                lr_Receptor(writer, Documento, False)
                'impuestos
                If Documento.TotalIGV > 0 Or Documento.TotalISC > 0 Or Documento.TotalInafecto > 0 Or Documento.TotalExo > 0 Or Documento.TotalOtros > 0 Or Documento.TotalGratis > 0 Then
                    lr_Impuestos(writer, Documento, True)
                End If
                'totales
                lr_Totales(writer, Documento, True)
                'detalles
                lr_Detalles(writer, Documento, True)
                writer.WriteEndDocument()
                writer.Flush()
                writer.Close()
            End Using
            FirmarXML(RutaArchivo, Documento.TipoDocumento, Hash)
        Catch ex As Exception
            Throw ex
        End Try
        Return RutaArchivo
    End Function

    <OperationBehavior(TransactionScopeRequired:=True)>
    Public Function GenerarEDocNotaDebito20(Documento As e_ComprobantePagoElectronico, ByRef Hash As String) As String Implements Il_ComprobantePagoElectronico.GenerarEDocNotaDebito20
        'Dim gstrRutaDocumentosEle20 As String = "D:\Documentos\Compatir\OneDrive\Comprobantes\" & Documento.RUCEmisor.Trim & "\2-0\Documentos\"
        Dim RutaArchivo As String = gstrRutaDocumentosEle20 & Documento.RUCEmisor.Trim & "-" & Documento.TipoDocumento & "-" & Documento.Documento & ".xml"
        Try
            settings.Indent = True
            settings.Encoding = System.Text.UTF8Encoding.UTF8
            Using writer As XmlWriter = XmlWriter.Create(RutaArchivo, settings)
                prefixCac = writer.LookupPrefix(cadCac)
                prefixExt = writer.LookupPrefix(cadExt)
                prefixCbc = writer.LookupPrefix(cadCbc)
                prefixDs = writer.LookupPrefix(cadDs)
                writer.WriteStartDocument()
                writer.WriteStartElement("DebitNote", "urn:oasis:names:specification:ubl:schema:xsd:DebitNote-2")
                writer.WriteAttributeString("xmlns", "cac", Nothing, cadCac)
                writer.WriteAttributeString("xmlns", "cbc", Nothing, cadCbc)
                writer.WriteAttributeString("xmlns", "ccts", Nothing, cadCcts)
                writer.WriteAttributeString("xmlns", "ds", Nothing, cadDs)
                writer.WriteAttributeString("xmlns", "ext", Nothing, cadExt)
                writer.WriteAttributeString("xmlns", "qdt", Nothing, cadQdt)
                writer.WriteAttributeString("xmlns", "udt", Nothing, cadUdt)
                writer.WriteAttributeString("xmlns", "xsi", Nothing, cadXsi)
                'totales
                lr_UBLExtensionesTotales(writer, Documento)
                'version UBL
                lr_UBLVersion20(writer, False)
                'cabecera Documento
                lr_DatosDocumento20(writer, Documento)
                'motivo
                lr_Motivo(writer, Documento)
                'documento afecto
                lr_DocumentoAfecto(writer, Documento)
                'firma
                lr_FirmaDigital(writer, Documento)
                'emisor
                lr_Emisor20(writer, New e_Empresa With {.Ruc = Documento.RUCEmisor.Trim, .Nombre = Documento.RazonSocial})
                'cliente/receptor
                lr_Receptor20(writer, Documento)
                'total
                lr_Totales(writer, Documento, False)
                'detalles
                lr_Detalles(writer, Documento, False)

                writer.WriteEndDocument()
                writer.Flush()
                writer.Close()
            End Using
            FirmarXML(RutaArchivo, Documento.TipoDocumento, Hash)
        Catch ex As Exception
            Throw ex
        End Try
        Return RutaArchivo
    End Function

    <OperationBehavior(TransactionScopeRequired:=True)>
    Public Function GenerarResumenBoletas20(lst As List(Of e_ComprobantePagoElectronico), Empresa As e_Empresa, Resumen As e_ComprobantePagoElectronico_Resumen, ByRef Hash As String) As String Implements Il_ComprobantePagoElectronico.GenerarResumenBoletas20
        'Dim gstrRutaDocumentosEle20 As String = "D:\Documentos\Compatir\OneDrive\Comprobantes\" & Empresa.NroDoc & "\2-0\Documentos\"
        Dim Ruta As String = gstrRutaDocumentosEle20 & Empresa.Ruc.Trim & "-RC-" & Resumen.FechaResumen & "-" & Resumen.Correlativo & ".xml"
        Try
            Dim FechaResumen, FechaDocumentos As String
            FechaResumen = Strings.Left(Resumen.FechaResumen, 4) & "-" & Strings.Left(Strings.Right(Resumen.FechaResumen, 4), 2) & "-" & Strings.Right(Resumen.FechaResumen, 2)
            FechaDocumentos = Strings.Left(Resumen.FechaDocumentos, 4) & "-" & Strings.Left(Strings.Right(Resumen.FechaDocumentos, 4), 2) & "-" & Strings.Right(Resumen.FechaDocumentos, 2)
            Dim Documento As e_ComprobantePagoElectronico = lst(0)
            Dim ln_Linea As Integer = 1
            settings.Indent = True
            settings.Encoding = System.Text.Encoding.GetEncoding("ISO-8859-1")
            Using writer As XmlWriter = XmlWriter.Create(Ruta, settings)
                prefixCac = writer.LookupPrefix(cadCac)
                prefixExt = writer.LookupPrefix(cadExt)
                prefixCbc = writer.LookupPrefix(cadCbc)
                prefixDs = writer.LookupPrefix(cadDs)
                prefixP = writer.LookupPrefix(cadP)
                prefixSac = writer.LookupPrefix(cadSac)
                writer.WriteStartDocument()
                writer.WriteStartElement("SummaryDocuments", "urn:sunat:names:specification:ubl:peru:schema:xsd:SummaryDocuments-1")
                writer.WriteAttributeString("xmlns", "p", Nothing, cadP)
                writer.WriteAttributeString("xmlns", "ext", Nothing, cadExt)
                writer.WriteAttributeString("xmlns", "cbc", Nothing, cadCbc)
                writer.WriteAttributeString("xmlns", "cac", Nothing, cadCac)
                writer.WriteAttributeString("xmlns", "sac", Nothing, cadSac)
                writer.WriteAttributeString("xmlns", "ds", Nothing, cadDs)
                lr_UBLExtensiones(writer)
                lr_UBLVersion20(writer, True)
                writer.WriteElementString("ID", cadCbc, "RC-" & Resumen.FechaResumen & "-" & Resumen.Correlativo)
                writer.WriteElementString("ReferenceDate", cadCbc, FechaDocumentos)
                writer.WriteElementString("IssueDate", cadCbc, FechaResumen)
                writer.WriteElementString("Note", cadCbc, "CONSOLIDADO DE BOLETAS DE VENTA")
                lr_FirmaDigital(writer, Documento)
                lr_Emisor20(writer, Empresa)
                For Each edoc As e_ComprobantePagoElectronico In lst
                    edoc.TipoOperacion = "1"
                    writer.WriteStartElement(prefixSac, "SummaryDocumentsLine", cadSac)

                    writer.WriteElementString("LineID", cadCbc, ln_Linea)
                    writer.WriteElementString("DocumentTypeCode", cadCbc, edoc.TipoDocumento)
                    writer.WriteElementString("ID", cadCbc, edoc.Documento)

                    writer.WriteStartElement(prefixCac, "AccountingCustomerParty", cadCac)
                    writer.WriteElementString("CustomerAssignedAccountID", cadCbc, edoc.DocumentoReceptor)
                    writer.WriteElementString("AdditionalAccountID", cadCbc, IIf(edoc.DocumentoReceptor.Trim.Length = 11, "6", "1"))
                    writer.WriteEndElement() 'AccountingCustomerParty

                    If edoc.DocumentoAsoc.Trim.Length > 0 Then
                        writer.WriteStartElement(prefixCac, "BillingReference", cadCac)
                        writer.WriteStartElement(prefixCac, "InvoiceDocumentReference", cadCac)
                        writer.WriteElementString("ID", cadCbc, edoc.DocumentoAsoc.Trim)
                        writer.WriteElementString("DocumentTypeCode", cadCbc, edoc.TipoDocAsoc)
                        writer.WriteEndElement() 'InvoiceDocumentReference
                        writer.WriteEndElement() 'BillingReference 
                    End If


                    writer.WriteStartElement(prefixCac, "Status", cadCac)
                    writer.WriteElementString("ConditionCode", cadCbc, "1")
                    writer.WriteEndElement() 'Status  ConditionCode

                    writer.WriteStartElement(prefixSac, "TotalAmount", cadSac)
                    writer.WriteAttributeString("currencyID", edoc.Moneda)
                    writer.WriteString(edoc.Total.ToString("F2"))
                    writer.WriteEndElement() 'TotalAmount

                    writer.WriteStartElement(prefixSac, "BillingPayment", cadSac)
                    writer.WriteStartElement(prefixCbc, "PaidAmount", cadCbc)
                    writer.WriteAttributeString("currencyID", edoc.Moneda)
                    writer.WriteString(edoc.SubTotal.ToString("F2"))
                    writer.WriteEndElement() 'PaidAmount
                    writer.WriteElementString("InstructionID", cadCbc, "01")
                    writer.WriteEndElement() 'BillingPayment

                    If edoc.TotalExo > 0 Then
                        writer.WriteStartElement(prefixSac, "BillingPayment", cadSac)
                        writer.WriteStartElement(prefixCbc, "PaidAmount", cadCbc)
                        writer.WriteAttributeString("currencyID", edoc.Moneda)
                        writer.WriteString(edoc.TotalExo.ToString("F2"))
                        writer.WriteEndElement() 'PaidAmount
                        writer.WriteElementString("InstructionID", cadCbc, "02")
                        writer.WriteEndElement() 'BillingPayment
                    End If

                    If edoc.TotalInafecto > 0 Then
                        writer.WriteStartElement(prefixSac, "BillingPayment", cadSac)
                        writer.WriteStartElement(prefixCbc, "PaidAmount", cadCbc)
                        writer.WriteAttributeString("currencyID", edoc.Moneda)
                        writer.WriteString(edoc.TotalInafecto.ToString("F2"))
                        writer.WriteEndElement() 'PaidAmount
                        writer.WriteElementString("InstructionID", cadCbc, "03")
                        writer.WriteEndElement() 'BillingPayment
                    End If

                    writer.WriteStartElement(prefixCac, "TaxTotal", cadCac)
                    writer.WriteStartElement(prefixCbc, "TaxAmount", cadCbc)
                    writer.WriteAttributeString("currencyID", edoc.Moneda)
                    writer.WriteString(edoc.TotalIGV.ToString("F2"))
                    writer.WriteEndElement() 'TaxAmount
                    writer.WriteStartElement(prefixCac, "TaxSubtotal", cadCac)
                    writer.WriteStartElement(prefixCbc, "TaxAmount", cadCbc)
                    writer.WriteAttributeString("currencyID", edoc.Moneda)
                    writer.WriteString(edoc.TotalIGV.ToString("F2"))
                    writer.WriteEndElement() 'TaxAmount
                    writer.WriteStartElement(prefixCac, "TaxCategory", cadCac)
                    writer.WriteStartElement(prefixCac, "TaxScheme", cadCac)
                    writer.WriteElementString("ID", cadCbc, "1000")
                    writer.WriteElementString("Name", cadCbc, "IGV")
                    writer.WriteElementString("TaxTypeCode", cadCbc, "VAT")
                    writer.WriteEndElement() 'TaxScheme
                    writer.WriteEndElement() 'TaxCategory
                    writer.WriteEndElement() 'TaxSubtotal
                    writer.WriteEndElement() 'TaxTotal

                    If edoc.TotalInafecto > 0 Then
                        writer.WriteStartElement(prefixCac, "TaxTotal", cadCac)
                        writer.WriteStartElement(prefixCbc, "TaxAmount", cadCbc)
                        writer.WriteAttributeString("currencyID", edoc.Moneda)
                        writer.WriteString(edoc.TotalInafecto.ToString("F2"))
                        writer.WriteEndElement() 'TaxAmount
                        writer.WriteStartElement(prefixCac, "TaxSubtotal", cadCac)
                        writer.WriteStartElement(prefixCbc, "TaxAmount", cadCbc)
                        writer.WriteAttributeString("currencyID", edoc.Moneda)
                        writer.WriteString(edoc.TotalInafecto.ToString("F2"))
                        writer.WriteEndElement() 'TaxAmount
                        writer.WriteStartElement(prefixCac, "TaxCategory", cadCac)
                        writer.WriteStartElement(prefixCac, "TaxScheme", cadCac)
                        writer.WriteElementString("ID", cadCbc, "9998")
                        writer.WriteElementString("Name", cadCbc, "INAFECTO")
                        writer.WriteElementString("TaxTypeCode", cadCbc, "FRE")
                        writer.WriteEndElement() 'TaxScheme
                        writer.WriteEndElement() 'TaxCategory
                        writer.WriteEndElement() 'TaxSubtotal
                        writer.WriteEndElement() 'TaxTotal
                    End If

                    If edoc.TotalExo > 0 Then
                        writer.WriteStartElement(prefixCac, "TaxTotal", cadCac)
                        writer.WriteStartElement(prefixCbc, "TaxAmount", cadCbc)
                        writer.WriteAttributeString("currencyID", edoc.Moneda)
                        writer.WriteString(edoc.TotalExo.ToString("F2"))
                        writer.WriteEndElement() 'TaxAmount
                        writer.WriteStartElement(prefixCac, "TaxSubtotal", cadCac)
                        writer.WriteStartElement(prefixCbc, "TaxAmount", cadCbc)
                        writer.WriteAttributeString("currencyID", edoc.Moneda)
                        writer.WriteString(edoc.TotalExo.ToString("F2"))
                        writer.WriteEndElement() 'TaxAmount
                        writer.WriteStartElement(prefixCac, "TaxCategory", cadCac)
                        writer.WriteStartElement(prefixCac, "TaxScheme", cadCac)
                        writer.WriteElementString("ID", cadCbc, "9997")
                        writer.WriteElementString("Name", cadCbc, "EXONERADO")
                        writer.WriteElementString("TaxTypeCode", cadCbc, "VAT")
                        writer.WriteEndElement() 'TaxScheme
                        writer.WriteEndElement() 'TaxCategory
                        writer.WriteEndElement() 'TaxSubtotal
                        writer.WriteEndElement() 'TaxTotal
                    End If

                    writer.WriteEndElement() ':SummaryDocumentsLine
                    ln_Linea += 1
                Next

                writer.WriteEndDocument()
                writer.Flush()
                writer.Close()
            End Using
            FirmarXML(Ruta, "RC", Hash)
        Catch ex As Exception
            Throw ex
        End Try
        Return Ruta
    End Function

    <OperationBehavior(TransactionScopeRequired:=True)>
    Public Function GenerarDocBaja(lst As List(Of e_ComprobantePagoElectronico), Empresa As e_Empresa, Resumen As e_ComprobantePagoElectronico_Resumen, ByRef Hash As String, Motivo As String) As String Implements Il_ComprobantePagoElectronico.GenerarDocBaja
        'Dim gstrRutaDocumentosEle20 As String = "D:\Documentos\Compatir\OneDrive\Comprobantes\" & Empresa.NroDoc & "\2-0\Documentos\"
        Dim Ruta As String = gstrRutaDocumentosEle20 & Empresa.Ruc & "-RA-" & Resumen.FechaResumen & "-" & Resumen.Correlativo & ".xml"
        Try
            Dim FechaResumen, FechaDocumentos As String
            FechaResumen = Strings.Left(Resumen.FechaResumen, 4) & "-" & Strings.Left(Strings.Right(Resumen.FechaResumen, 4), 2) & "-" & Strings.Right(Resumen.FechaResumen, 2)
            FechaDocumentos = Strings.Left(Resumen.FechaDocumentos, 4) & "-" & Strings.Left(Strings.Right(Resumen.FechaDocumentos, 4), 2) & "-" & Strings.Right(Resumen.FechaDocumentos, 2)
            Dim Documento As e_ComprobantePagoElectronico = lst(0)
            Dim ln_Linea As Integer = 1
            settings.Indent = True
            settings.Encoding = System.Text.Encoding.GetEncoding("ISO-8859-1")
            Using writer As XmlWriter = XmlWriter.Create(Ruta, settings)
                prefixCac = writer.LookupPrefix(cadCac)
                prefixExt = writer.LookupPrefix(cadExt)
                prefixCbc = writer.LookupPrefix(cadCbc)
                prefixDs = writer.LookupPrefix(cadDs)
                prefixSac = writer.LookupPrefix(cadSac)
                writer.WriteStartDocument()
                writer.WriteStartElement("VoidedDocuments", "urn:sunat:names:specification:ubl:peru:schema:xsd:VoidedDocuments-1")
                writer.WriteAttributeString("xmlns", "ext", Nothing, cadExt)
                writer.WriteAttributeString("xmlns", "cbc", Nothing, cadCbc)
                writer.WriteAttributeString("xmlns", "cac", Nothing, cadCac)
                writer.WriteAttributeString("xmlns", "sac", Nothing, cadSac)
                writer.WriteAttributeString("xmlns", "ds", Nothing, cadDs)
                lr_UBLExtensiones(writer)
                lr_UBLVersion20(writer, False)
                writer.WriteElementString("ID", cadCbc, "RA-" & Resumen.FechaResumen & "-" & Resumen.Correlativo)
                writer.WriteElementString("ReferenceDate", cadCbc, FechaDocumentos)
                writer.WriteElementString("IssueDate", cadCbc, FechaResumen)
                lr_FirmaDigital(writer, Documento)
                lr_Emisor20(writer, Empresa)
                For Each edoc As e_ComprobantePagoElectronico In lst
                    edoc.TipoOperacion = "2"
                    writer.WriteStartElement(prefixSac, "VoidedDocumentsLine", cadSac)
                    writer.WriteElementString("LineID", cadCbc, ln_Linea)
                    writer.WriteElementString("DocumentTypeCode", cadCbc, edoc.TipoDocumento)
                    writer.WriteElementString("DocumentSerialID", cadSac, Strings.Left(edoc.Documento, 4))
                    writer.WriteElementString("DocumentNumberID", cadSac, Strings.Right(edoc.Documento, 8))
                    writer.WriteElementString("VoidReasonDescription", cadSac, Motivo)
                    writer.WriteEndElement()
                    ln_Linea += 1
                Next
                writer.WriteEndDocument()
                writer.Flush()
                writer.Close()
            End Using
            FirmarXML(Ruta, "RA", Hash)
        Catch ex As Exception
            Throw ex
        End Try
        Return Ruta
    End Function

    Public Sub FirmarXML(RutaXML As String, TipoDocumento As String, ByRef Hash As String)
        Try
            'Dim RutaCertificado As String = System.Configuration.ConfigurationManager.AppSettings(gstrRutaFirma).ToString
            'Dim PassCertificado As String = System.Configuration.ConfigurationManager.AppSettings("estelasuarez").ToString
            Dim local_xmlArchivo As String = RutaXML
            Dim local_nombreXML As String = System.IO.Path.GetFileName(local_xmlArchivo)
            Dim MiCertificado As X509Certificate2 = New X509Certificate2(gstrRutaFirma, "materiaGRIF01X", X509KeyStorageFlags.MachineKeySet)
            'Dim MiCertificado As X509Certificate2 = New X509Certificate2(RutaCertificado, PassCertificado)
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
            '
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

            Select Case TipoDocumento
                Case "01", "03"
                    nsMgr.AddNamespace("tns", "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")
                    local_xpath = "/tns:Invoice/ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent"
                Case "07"
                    nsMgr.AddNamespace("tns", "urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2")
                    local_xpath = "/tns:CreditNote/ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent"
                Case "08"
                    nsMgr.AddNamespace("tns", "urn:oasis:names:specification:ubl:schema:xsd:DebitNote-2")
                    local_xpath = "/tns:DebitNote/ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent"
                Case "RA"
                    nsMgr.AddNamespace("tns", "urn:sunat:names:specification:ubl:peru:schema:xsd:VoidedDocuments-1")
                    local_xpath = "/tns:VoidedDocuments/ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent"
                Case "RC"
                    nsMgr.AddNamespace("tns", "urn:sunat:names:specification:ubl:peru:schema:xsd:SummaryDocuments-1")
                    local_xpath = "/tns:SummaryDocuments/ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent"
            End Select

            nsMgr.AddNamespace("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")
            nsMgr.AddNamespace("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")
            nsMgr.AddNamespace("ccts", "urn:un:unece:uncefact:documentation:2")
            nsMgr.AddNamespace("ds", "http://www.w3.org/2000/09/xmldsig#")
            nsMgr.AddNamespace("udt", "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2")
            nsMgr.AddNamespace("ext", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")
            nsMgr.AddNamespace("qdt", "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2")
            nsMgr.AddNamespace("sac", "urn:oasis:names:specification:ubl:schema:xsd:SignatureAggregateComponents-2")
            nsMgr.AddNamespace("udt", "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")

            xmlDoc.SelectSingleNode(local_xpath, nsMgr).AppendChild(xmlDoc.ImportNode(signature, True))

            Hash = signature.ChildNodes.Item(0).ChildNodes.Item(2).ChildNodes.Item(2).FirstChild.Value
            Dim firma As String = signature.ChildNodes.Item(1).FirstChild.Value
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

End Class
