'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales
' @0001 |   2019-10-01  |  CT2010   |   Version Sistema
'=================================================================================================================


Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports System.Data.OleDb
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinToolbars
Imports Infragistics.Win.UltraWinDataSource
Imports Infragistics.Win.UltraWinGrid.ExcelExport
Imports System.Text.RegularExpressions
Imports System.Net.Mail
Imports System.IO
Imports System.Net
'Imports System.Windows.Forms
Imports System.ServiceModel
Imports Infragistics.Win.Misc
Imports Ionic.Zip
'Imports System.Configuration
'Imports System.Collections.Specialized
Imports MSScriptControl
Imports System.Reflection
Imports Microsoft.Office.Interop
'Imports System.Web


Module m_Funciones

    Dim olEmpresaSistema As New l_EmpresaSistemas

#Region "EOS"

    'Public gstrIdEmpresa As String = "1CIX00000001"
    'Public gstrNombreEmpresa As String = "MEGACERAMICOS DEL NORTE E.I.R.L."
    'Public gstrRucEmpresa As String = "20603652810"
    'Public gstrDireccionEmpresa As String = "CAL.NICOLAS AYLLON NRO. 900 URB. URRUNAGA SC. 1 LAMBAYEQUE - CHICLAYO - JOSE LEONARDO ORTIZ"
    ''------
    'Public gstrIdEmpresaSis As String = "1CIX001"
    'Public gstrIdSucursal As String = "1CIX001"
    'Public gstrNombreEmpresaSis As String = "MEGACERAMICOS DEL NORTE E.I.R.L."
    'Public gstrRucEmpresaSis As String = "20603652810"



    Public Function gfc_ParametroValor(ByVal ls_Abreviatura As String) As Double
        Dim ln_Retorna As Double = 0.18
        'oeParametro = New e_Parametro
        'oeParametro.TipoBusca = 2 : oeParametro.Abreviatura = ls_Abreviatura
        'If gleParametro.Contains(oeParametro) Then
        '    oeParametro = gleParametro.Item(gleParametro.IndexOf(oeParametro))
        '    ln_Retorna = oeParametro.Valor
        'End If

        Return ln_Retorna
    End Function

    Public Function gfc_obtener_TurnoActivo() As e_CierreTurno '' CESS
        Dim dTurno As New l_CierreTurno
        Return dTurno.Obtener(New e_CierreTurno With {.TipoOperacion = "TAC", .IdSucursal = gs_IdSucursal})

    End Function

    Public Sub gmt_ComboGrillaSubAlmacen(IdAlmacen As String, ByVal Grilla As UltraGrid)
        Try
            Dim loSubAlmacen As New List(Of e_Combo)
            Dim objValueList As Infragistics.Win.ValueList = Nothing
            Grilla.DisplayLayout.ValueLists.Clear()
            objValueList = Grilla.DisplayLayout.ValueLists.Add("SubAlmacen")
            loSubAlmacen = gloSubAlm.Where(Function(i) i.Descripcion = IdAlmacen).ToList
            For Each item As e_Combo In loSubAlmacen
                objValueList.ValueListItems.Add(item.Id, item.Nombre)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'CONFIGURACION DE GRILLA
    Public Sub gmt_ConfiguraGrilla(ByVal Grilla As UltraGrid, ByVal TipoLetra As String, IndFiltro As Boolean, Estilo As UIElementBorderStyle, ParamArray aColumnas As String())
        Dim Band As Boolean
        With Grilla
            If TipoLetra.Trim.Length = 0 Then TipoLetra = "Microsoft Sans Serif"
            .Font = New System.Drawing.Font(TipoLetra, 8.0!)
            .DisplayLayout.Override.BorderStyleCell = Estilo
            .DisplayLayout.Override.BorderStyleRow = Estilo
            .DisplayLayout.Override.HeaderClickAction = HeaderClickAction.SortSingle
            If IndFiltro Then
                Dim Filtro As New SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro
            End If
            If aColumnas.Length > 0 Then
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.Default
                .DisplayLayout.Override.CellClickAction = CellClickAction.Default
                For Each Colum In .DisplayLayout.Bands(0).Columns
                    Band = True
                    For i As Integer = 0 To aColumnas.Length - 1
                        If aColumnas(i).Trim <> "" Then
                            If Colum.Key = aColumnas(i).ToString Then
                                Colum.CellClickAction = CellClickAction.Edit
                                Colum.CellActivation = Activation.AllowEdit
                                Band = False
                                Exit For
                            End If
                        End If
                    Next
                    If Band Then
                        Colum.CellActivation = Activation.NoEdit
                        Colum.CellClickAction = CellClickAction.CellSelect
                    End If
                Next
            Else
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
            End If
            .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
            .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
            .DisplayLayout.MaxColScrollRegions = 1
            .DisplayLayout.MaxRowScrollRegions = 1
            .DisplayLayout.Override.SelectTypeRow = SelectType.Single
        End With
    End Sub

    Public Sub gmt_FormatoColumna(ByVal Grilla As UltraGrid, ByVal _formato As String, ByVal _estilo As UltraWinGrid.ColumnStyle _
                           , ByVal _alineacion As HAlign, ByVal ParamArray aColumnas As String())
        With Grilla.DisplayLayout.Bands(0)
            For i As Integer = 0 To aColumnas.Length - 1
                For Each Colum As UltraGridColumn In .Columns
                    If aColumnas(i).Trim <> "" Then
                        If Colum.Key = aColumnas(i).ToString Then
                            If _formato.Trim <> "" Then .Columns(aColumnas(i).ToString).Format = _formato
                            .Columns(aColumnas(i).ToString).Style = _estilo
                            .Columns(aColumnas(i).ToString).CellAppearance.TextHAlign = _alineacion
                        End If
                    End If
                Next
            Next
        End With
    End Sub

    Public Function gfc_GeneraDTRef(leRef As List(Of e_AsientoModelo_Referencia)) As Data.DataTable
        Try
            Dim _IdAM As String = String.Empty
            Dim _leAux As New List(Of e_AsientoModelo_Referencia)
            For Each oeRef In leRef.OrderBy(Function(it) it.IdActividad).ToList
                If _IdAM <> oeRef.IdActividad Then
                    _IdAM = oeRef.IdActividad
                    Dim _oeAux As New e_AsientoModelo_Referencia
                    _oeAux.IdActividad = _IdAM
                    Dim _lex = leRef.Where(Function(it) it.IdActividad = _IdAM).ToList
                    _oeAux.Cant = _lex.Count
                    _leAux.Add(_oeAux)
                End If
            Next
            Dim dt As Data.DataTable = gfc_CrearDTRef(_leAux.OrderByDescending(Function(it) it.Cant).ToList(0))
            Dim rwdt As Data.DataRow
            Dim pos As Integer = 0
            For Each oeRefAux In _leAux
                rwdt = dt.NewRow
                rwdt("IdAsientoModelo") = oeRefAux.IdActividad
                pos = 0
                For Each _oe In leRef.Where(Function(it) it.IdActividad = oeRefAux.IdActividad).OrderBy(Function(it) it.TipoReferencia).ToList
                    pos = pos + 1
                    rwdt("TipoRef" & pos) = _oe.TipoReferencia
                    rwdt("IdRef" & pos) = _oe.IdReferencia
                    rwdt("Ref" & pos) = _oe.Nombre
                Next
                dt.Rows.Add(rwdt)
            Next
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function gfc_CrearDTRef(oeEstruc As e_AsientoModelo_Referencia) As Data.DataTable
        Dim dtStruc As New Data.DataTable
        With dtStruc
            .Columns.Add(New Data.DataColumn("IdAsientoModelo", Type.GetType("System.String")))
            For i = 1 To oeEstruc.Cant
                .Columns.Add(New Data.DataColumn("TipoRef" & i, Type.GetType("System.Int32")))
                .Columns.Add(New Data.DataColumn("IdRef" & i, Type.GetType("System.String")))
                .Columns.Add(New Data.DataColumn("Ref" & i, Type.GetType("System.String")))
            Next
        End With
        Return dtStruc
    End Function

    Public Sub gmt_OcultarColumna(ByVal Grilla As UltraGrid, ByVal IndBand As Boolean, ByVal ParamArray aColumnas As String())
        With Grilla.DisplayLayout.Bands(0)
            If Not IndBand Then
                For Each Colum As UltraGridColumn In .Columns
                    Colum.Hidden = True
                Next
            End If
            For i As Integer = 0 To aColumnas.Length - 1
                For Each Colum As UltraGridColumn In .Columns
                    If aColumnas(i).Trim <> "" Then
                        If Colum.Key = aColumnas(i).ToString Then
                            .Columns(aColumnas(i).ToString).Hidden = IndBand
                            If Not IndBand Then .Columns(aColumnas(i).ToString).Header.VisiblePosition = i
                        End If
                    End If
                Next
            Next
        End With
    End Sub

    Public Function gfc_ObtenerNumeroDoc(Serie As String, IdTipoDocumento As String, Tipo As Integer) As Integer
        Try
            Dim olDocumento As New l_MovimientoDocumento
            Dim oe As New e_MovimientoDocumento
            oe.TipoOperacion = "NUM"
            oe.Serie = Serie
            oe.IdTipoDocumento = IdTipoDocumento
            Return olDocumento.ObtenerNumDoc(oe).Numero
            Return 1
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function gfc_ObtenerNumeroGRR(Serie As String) As Integer
        Try
            Dim olGrr As New l_GRR_Venta
            Dim oe As New e_GRR_Venta
            oe.TipoOperacion = "NUM"
            oe.Serie = Serie
            Return olGrr.Obtener(oe).Numero
            Return 1
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Public gloAlmMat As List(Of e_Combo)
    Public gloSubAlm As List(Of e_Combo)
    'Public gloUniMed As List(Of e_Combo)
    'Public gloLugares As List(Of e_Combo)
    'Public gloEmpresa As List(Of e_Combo)
    'Public gloTipoPago As List(Of e_Combo)
    'Public gloPiloto As List(Of e_Combo)
    'Public gloMatSCta As List(Of e_Combo)
    'Public gloSerCCta As List(Of e_Combo)
    'Public gloTrabajador As List(Of e_Combo)
    'Public gloTipoDoc As List(Of e_Combo)
    'Public gloCajaTrabajador As List(Of e_Combo)
    'Public gloConceptos As List(Of e_Combo)
    'Public gloEquipo As List(Of e_Combo)

#End Region

#Region "Variables Globales de Logeo de Usuario"

    ''' <summary>
    ''' Variable global para almacenar la información del usuario actual
    ''' </summary>
    ''' <remarks></remarks>
    Public gUsuarioSGI As New e_Usuario
    Public leUsuarios As New List(Of e_Usuario)
    Public gEmpSis As New e_EmpresaSistemas
    'Nombre completo del usuario que se ha logueado al sistema
    'Id del usuario que se ha logueado en el sistema / Utilizado como UsuarioCreacion para todo lo que haga 

    Public gIdControl As String
    Public gImagen As Boolean = True

    ''' <summary>
    ''' Estructura definida para retornar los importes totales de los documentos de compra venta
    ''' </summary>
    ''' <remarks></remarks>
    Public Structure Totales
        Public importeSubTotal As Double
        Public importeIGV As Double
        Public importeTotal As Double
    End Structure

    ''' <summary>
    ''' Variable global para almacenar la información de la versión del sistema
    ''' </summary>
    ''' <remarks></remarks>
    Public gleTrabSeguridad As New List(Of e_TrabajadorSeguridad)
    Public gleActividadRestringida As New List(Of e_ActividadRestringida_Usuario)

    ''' <summary>
    ''' Variable global para almacenar la instancia de funciones generales de la capa lógica de negocio
    ''' </summary>
    ''' <remarks></remarks>
    Public l_FuncionesGenerales As New l_FuncionesGenerales

    ''' <summary>
    ''' Variable global para almacenar el valor por defecto para expandir o contraer las grillas con niveles, 
    ''' Valor por defecto (Verdadero=Expandido)
    ''' </summary>
    ''' <remarks></remarks>
    Public gGrillaExpandida As Boolean = True

    Enum TipoTiempo
        Años
        Meses
        Dias
        Horas
        Minutos
        Segundos
    End Enum

    Public Enum EstadoVehiculo As Integer
        Siniestrado = 0
        EnVenta = 1
        Vendido = 2
        Operativo = 3
        Alquilado = 4
        Otros = 5
        DeBaja = 6
        PerdidaTotal = 7
        Oficina = 8
        Perdida = 9
        Prestada = 10
        Duplicado = 11
    End Enum

#End Region

#Region "Variables globales de formulario multiinstancia"
    Public TipoCliente As Integer
    Public TipoRuta As Integer
    Public TipoProveedor As Integer
    Public TipoProrrateo As String
    Public TipoAnticipo As String

    Public IndFacturado As Boolean
    Public IndGrtConfirmada As Boolean
    Public IndDocumentos As Boolean
    Public IndGrtPerdido As Boolean
    Public IndDireccionarGRT As Boolean = False
    Public EliminaViajes As Boolean = False

    'Variable para gestionar la visualización del mensaje de actualización
    'automático del sistema, en tiempo de ejecución
    Public MostrarMensajeActualizarSGI As Boolean = False

#End Region

    Public Function gmt_CPE(oeDocumento As e_MovimientoDocumento) As String
        Dim RutaXML As String = ""
        Try
            Dim Hash As String = ""
            Dim ls_NombreArchivo As String = ""
            Dim lb_IndXml As Boolean = False
            Dim odDocumento As New l_MovimientoDocumento, odDatosImpresion As New l_MovimientoDocumento_Impresion
            Dim oeDocumentoElectronico As New e_ComprobantePagoElectronico
            Dim olDocumentoElectronico As New l_ComprobantePagoElectronico
            oeDocumentoElectronico = olDocumentoElectronico.Obtener(New e_ComprobantePagoElectronico With {.TipoOperacion = "UNO", .Id = oeDocumento.Id})

            For Each detalle As e_ComprobantePagoElectronico_Detalle In oeDocumentoElectronico.Detalles
                If detalle.Producto.Trim = String.Empty Then Throw New Exception("Existe un Material sin Nombre de Impresion")
            Next
            Select Case oeDocumentoElectronico.TipoDocumento
                Case "01" ' Factura
                    ls_NombreArchivo = olDocumentoElectronico.GenerarEDocFactura(oeDocumentoElectronico, Hash).Trim
                    lb_IndXml = True
                Case "07" ' Nota de Credito
                    If oeDocumentoElectronico.TipoDocAsoc = "01" Then
                        ls_NombreArchivo = olDocumentoElectronico.GenerarEDocNotaCredito(oeDocumentoElectronico, Hash).Trim
                        lb_IndXml = True
                    End If
                    'If oeDocumento.lstDocAsociado.Where(Function(i) i.IdTipoDocumento = "1CIX001").Count > 0 Then

                        'End If
                Case "1CH000000033" ' Nota de Debito
                    'If oeDocumento.lstDocAsociado.Where(Function(i) i.IdTipoDocumento = "1CIX001").Count > 0 Then
                    ls_NombreArchivo = olDocumentoElectronico.GenerarEDocNotaDebito(oeDocumentoElectronico, Hash).Trim
                    lb_IndXml = True
                    'End If
            End Select
            oeDocumento.DatosImpresion.IdMovimientoDocumento = oeDocumentoElectronico.Id
            If lb_IndXml Then
                oeDocumento.DatosImpresion.RutaImpresionXML = ls_NombreArchivo.Trim
                oeDocumento.DatosImpresion.RutaImpresionPDF = Replace(ls_NombreArchivo, "xml", "pdf").Trim
                oeDocumento.DatosImpresion.CodigoExterno = Replace(Replace(ls_NombreArchivo, ".xml", ""), gstrRutaDocumentosEle20, "").Trim
                oeDocumento.DatosImpresion.HashResumen = Hash
            Else
                ls_NombreArchivo = gstrRutaDocumentosEle20 & oeDocumentoElectronico.RUCEmisor & "-" & oeDocumentoElectronico.TipoDocumento & "-" & oeDocumentoElectronico.Documento.Trim & ".pdf"
                'oeDocumento.DatosImpresion.TipoOperacion = "A"
                oeDocumento.DatosImpresion.RutaImpresionXML = String.Empty
                oeDocumento.DatosImpresion.RutaImpresionPDF = ls_NombreArchivo.Trim
                oeDocumento.DatosImpresion.CodigoExterno = Replace(Replace(ls_NombreArchivo, ".pdf", ""), gstrRutaDocumentosEle20, "")
            End If
            oeDocumento.DatosImpresion.TipoOperacion = "U"
            'oeDocumento.TipoOperacion = "R"
            oeDocumento.lstDetalleDocumento = New List(Of e_DetalleDocumento)
            RutaXML = oeDocumento.DatosImpresion.RutaImpresionXML
            odDatosImpresion.Guardar(oeDocumento.DatosImpresion)
            'End If
        Catch ex As Exception
            Throw ex
        End Try
        Return RutaXML
    End Function

    Public Sub gmt_GeneraZip(Ruta As String)
        Try
            Using zip As ZipFile = New ZipFile(System.Text.UTF8Encoding.UTF8)
                zip.AddFile(Ruta.Trim, "")
                zip.Save(Replace(Ruta, ".xml", ".zip"))
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub gmt_Imprimir_CierreTurno(IdCierreTurno As String, IdReporte As String)
        Try
            Dim FRM As New frm_CierreTurno_Imprimir(IdCierreTurno, IdReporte)
            FRM.ShowDialog()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub gmt_Imprimir_CierreTurno(FechaCierre As Date, IdReporte As String)
        Try
            Dim FRM As New frm_CierreTurno_Imprimir(FechaCierre, IdReporte)
            FRM.ShowDialog()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub gmt_Imprimir_Documento(IdMovimientoDocumento As String, Papel As String, Modulo As String, TipoOp As String)
        Try
            Dim FRM As New frm_DocumentoCtble_Imprimir(IdMovimientoDocumento, Papel, Modulo, TipoOp)
            FRM.ShowDialog()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    '@0001 Ini
    Public Sub gmt_Imprimir_DocumentoTicket(IdMovimientoDocumento As String, Papel As String, Modulo As String, TipoOp As String)
        Try
            Dim FRM As New frm_DocumentoCtble_Imprimir(IdMovimientoDocumento, Papel, Modulo, TipoOp)
            FRM.Size = New System.Drawing.Size(400, 700)
            FRM.ShowDialog()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    '@0001

    Public Sub gmt_ImprimirDirecto(IdDocumentoCtble As String, TipoPapel As String, GenerarPDF As Boolean)
        Try
            Dim VISOR As New Microsoft.Reporting.WinForms.ReportViewer
            Dim DATASOURCE As New Microsoft.Reporting.WinForms.ReportDataSource
            Dim DT1 As New DataTable, DT2 As New DataTable
            Dim RDS1 As New Microsoft.Reporting.WinForms.ReportDataSource, RDS2 As New Microsoft.Reporting.WinForms.ReportDataSource
            Dim wr_DocumentoCtble As New l_MovimientoDocumento, DocumentoCtble As New e_MovimientoDocumento

            '' Cargar Reporte en VISOR 
            DocumentoCtble = wr_DocumentoCtble.Obtener(New e_MovimientoDocumento With {.TipoOperacion = "", .Id = IdDocumentoCtble})

            DT1 = wr_DocumentoCtble.dt_DocumentoCtble_Impresion(New e_MovimientoDocumento With {.TipoOperacion = "CAB", .Id = DocumentoCtble.Id})
            RDS1.Name = "Cabecera"
            RDS1.Value = DT1

            DT2 = wr_DocumentoCtble.dt_DocumentoCtble_Impresion(New e_MovimientoDocumento With {.TipoOperacion = "DET", .Id = DocumentoCtble.Id})
            RDS2.Name = "Detalle"
            RDS2.Value = DT2

            With VISOR
                .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                .LocalReport.ReportPath = fs_Obtener_RutaReporte(DocumentoCtble.IdTipoDocumento, "GRIFO", TipoPapel)
                .LocalReport.DataSources.Clear()
                .LocalReport.DataSources.Add(RDS1)
                .LocalReport.DataSources.Add(RDS2)
                .LocalReport.DisplayName = DT1.Rows(0).Item("DOI").ToString + "-" + DT1.Rows(0).Item("SerieNumero").ToString
                .LocalReport.Refresh()
            End With

            VISOR.RefreshReport()
            VISOR.PrintDialog()

            '' Generar archivo PDF
            If GenerarPDF Then
                Dim Archivo As String = "D:\Sistema\xml\" & DocumentoCtble.DatosImpresion.TipoDocumento & "_" & DocumentoCtble.Serie & DocumentoCtble.Numero & ".pdf"
                Dim PDF As Byte()
                Dim filepath As String = Archivo
                If File.Exists(filepath) Then My.Computer.FileSystem.DeleteFile(filepath)
                PDF = VISOR.LocalReport.Render("PDF", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                Dim fs As New FileStream(Archivo, FileMode.Create)
                fs.Write(PDF, 0, PDF.Length)
                fs.Close()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub gmt_Generar_PDF(IdDocumentoCtble As String)
        Try
            Dim VISOR As New Microsoft.Reporting.WinForms.ReportViewer
            Dim DATASOURCE As New Microsoft.Reporting.WinForms.ReportDataSource
            Dim DT1 As New DataTable, DT2 As New DataTable
            Dim RDS1 As New Microsoft.Reporting.WinForms.ReportDataSource, RDS2 As New Microsoft.Reporting.WinForms.ReportDataSource
            Dim wr_DocumentoCtble As New l_MovimientoDocumento, DocumentoCtble As New e_MovimientoDocumento

            '' Cargar Reporte en VISOR
            DocumentoCtble = wr_DocumentoCtble.Obtener(New e_MovimientoDocumento With {.TipoOperacion = "", .Id = IdDocumentoCtble})

            DT1 = wr_DocumentoCtble.dt_DocumentoCtble_Impresion(New e_MovimientoDocumento With {.TipoOperacion = "CAB", .Id = DocumentoCtble.Id})
            RDS1.Name = "Cabecera"
            RDS1.Value = DT1

            DT2 = wr_DocumentoCtble.dt_DocumentoCtble_Impresion(New e_MovimientoDocumento With {.TipoOperacion = "DET", .Id = DocumentoCtble.Id})
            RDS2.Name = "Detalle"
            RDS2.Value = DT2

            With VISOR
                .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                .LocalReport.ReportPath = fs_Obtener_RutaReporte(DocumentoCtble.IdTipoDocumento, "GRIFO", "A4")
                .LocalReport.DataSources.Clear()
                .LocalReport.DataSources.Add(RDS1)
                .LocalReport.DataSources.Add(RDS2)
                .LocalReport.DisplayName = DT1.Rows(0).Item("DOI").ToString + "-" + DT1.Rows(0).Item("SerieNumero").ToString
                .LocalReport.Refresh()
            End With

            VISOR.RefreshReport()

            '' Generar archivo PDF
            Dim Archivo As String = "D:\Sistema\xml\" & DocumentoCtble.DatosImpresion.TipoDocumento & "_" & DocumentoCtble.Serie & DocumentoCtble.Numero & ".pdf"
            Dim PDF As Byte()
            Dim filepath As String = Archivo
            If File.Exists(filepath) Then My.Computer.FileSystem.DeleteFile(filepath)
            PDF = VISOR.LocalReport.Render("PDF", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            Dim fs As New FileStream(Archivo, FileMode.Create)
            fs.Write(PDF, 0, PDF.Length)
            fs.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function fs_Obtener_RutaReporte(IdTipoDocumento As String, ModuloEmision As String, TipoPapel As String) As String
        'Dim Raiz As String = "...\Debug\Grifo\Impresiones\"
        'C:\Users\CESS\Source\Repos\ERP-TCG\ERP-TCG\ISL.Win\Grifo\Impresiones\rpt_DocumentoCtble_A4.rdlc
        Dim Raiz As String = Path.Combine(Application.StartupPath, "Grifo") & "\Impresiones\"
        Select Case ModuloEmision
            Case "GRIFO"
                Select Case IdTipoDocumento
                    Case "1CH000000026" 'Factura
                        Select Case TipoPapel
                            Case "A4" : Return Raiz & "rpt_FacturaVenta_A4.rdlc"
                            Case "TICKET" : Return Raiz & "rpt_FacturaVenta_Ticket.rdlc"
                        End Select
                    Case "1CH000000002" 'Boleta de Venta
                        Select Case TipoPapel
                            Case "A4" : Return Raiz & "rpt_BoletaVenta_A4.rdlc"
                            Case "TICKET" : Return Raiz & "rpt_BoletaVenta_Ticket.rdlc"
                        End Select
                    Case "GCH000000001" 'Nota de Despacho
                        Select Case TipoPapel
                            Case "A4" : Return Raiz & "rpt_NotaDespacho_A4.rdlc"
                            Case "TICKET" : Return Raiz & "rpt_NotaDespacho_Ticket.rdlc"
                        End Select
                    Case Else
                        Select Case TipoPapel
                            Case "A4" : Return Raiz & "rpt_DocumentoCtble_A4.rdlc"
                            Case "TICKET" : Return Raiz & "rpt_DocumentoCtble_Ticket.rdlc"
                        End Select
                End Select
            Case "OV"
                'Select Case IdTipoDocumento '@0001
                'Case "GCH000000001" 'Nota de Despacho '@0001
                Select Case TipoPapel
                    Case "A4" : Return Raiz & "rpt_DocumentoCtble_A4_Comercial.rdlc"
                    Case "TICKET" : Return "Reportes\Comercial\Ventas\rpt_ND_Ticket.rdlc"
                    Case "NCTICKET" : Return "Reportes\Comercial\Ventas\rpt_NC_Ticket.rdlc"
                End Select
                'End Select '@0001
                'Case Else '@0001
                Return ""
        End Select

        Return ""
    End Function

    Public Sub gmt_ListarEmpresa(Tipo As String, Combo As UltraCombo, IdProveedor As String, IndRuc As Boolean, Optional ByVal IndFiltro As Boolean = True)
        Try
            Dim oeEmpresa As New e_Empresa
            Dim olEmpresa As New l_Empresa
            Dim loEmpresa As New List(Of e_Empresa)
            'loEmpresa = New List(Of e_Empresa)
            oeEmpresa.TipoOperacion = Tipo
            If IdProveedor = "" Then
                If IndRuc Then
                    oeEmpresa.Ruc = Combo.Text.Trim
                    loEmpresa = olEmpresa.Listar(oeEmpresa)
                Else
                    oeEmpresa.Nombre = Combo.Text.Trim
                    loEmpresa = olEmpresa.Listar(oeEmpresa)
                End If
            Else
                oeEmpresa.Id = IdProveedor
                loEmpresa = olEmpresa.Listar(oeEmpresa)
            End If
            'If IndFiltro = True Then
            '    Combo.DataSource = loEmpresa.Where(Function(it) it.NroDoc <> gstrRucEmpresa).ToList
            'Else
            Combo.DataSource = loEmpresa
            'End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub gmt_MostrarTabs(ByVal Tab_Mostrar As Integer,
                        ByVal TAB As UltraWinTabControl.UltraTabControl,
                        Optional ByVal Tab_Adicional As Integer = 0)
        Try
            Dim I As Integer
            For I = 0 To TAB.Tabs.Count - 1
                If I = Tab_Mostrar Then
                    TAB.Tabs(I).Enabled = True
                    TAB.Tabs(I).Selected = True
                ElseIf I = Tab_Adicional Then
                    TAB.Tabs(I).Enabled = True
                Else
                    TAB.Tabs(I).Enabled = False
                End If
            Next

            If Tab_Adicional <> 0 Then
                For I = 0 To TAB.Tabs.Count - 1
                    If I = Tab_Adicional Then
                        TAB.Tabs(I).Enabled = True
                    End If
                Next
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function gfc_TipoCambio(Fecha As Date, IndCompra As Boolean) As Double
        Try
            Dim oeTipoCambio As New e_TipoCambio
            Dim olTipoCambio As New l_TipoCambio
            oeTipoCambio.TipoOperacion = "1"
            oeTipoCambio.FechaCambio = Fecha
            oeTipoCambio = olTipoCambio.Obtener(oeTipoCambio)
            If IndCompra Then
                Return oeTipoCambio.CambioVenta
            Else
                Return oeTipoCambio.CambioCompra
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#Region "VariablesGlobalesPerfilesAreasEstados"

    'Declara constante pública del Id de la Empresa
    'Public Const ISL_IdClienteProveedor As String = "" '@0001 "1CH000004444"
    'Public Const ISL_IdProveedor As String = "" '@00001 "1CH000004444"
    'Public Const ISL_IdEmpresa As String = "" '@00001 "1CH000006026"
    'Public Const ERP_Nombre As String = "ERP"
    'Public Const ISL_Nombre As String = "MI EMPRESA S.A.C." '@00001
    'Public Const ISL_RUC As String = "20480099720" '@00001
    'Public Const ISL_DireccionEmpresa1 As String = "DIRECCION DE EMPRESA"
    'Public ISL_RutaImpresion As String = "\\localhost\Fotos/eImpresion\"
    Public ISL_RutaImpresion As String = Path.Combine(Application.StartupPath, "Fotos") & "\eImpresion\"
    Public RutaArchivos As String = "\\LADERA\ComprobanteElectronico\Facturacion\"
    'Public RutaArchivos As String = Path.Combine(Application.StartupPath, "ComprobanteElectronico") & "\Facturacion\"

    Public Abrev_Empresa As String = "ERP"

    'Declara constantes públicas para nombres de perfiles utilizados por diferentes módulos
    Public Const gNombrePerfilSupervidorGeneral As String = "SUPERVISOR GENERAL"
    Public Const gNombrePerfilGerenteAdministrativo As String = "GERENTE ADMINISTRATIVO"
    Public Const gNombrePerfilGerenteOperaciones As String = "GERENTE OPERACIONES"
    Public Const gNombrePerfilJefeOperaciones As String = "JEFE OPERACIONES"
    Public Const gNombrePerfilSupervisorOperaciones As String = "SUPERVISOR OPERACIONES"
    Public Const gNombrePerfilCoordinadorOperaciones As String = "COORDINADOR OPERACIONES"
    Public Const gNombrePerfilJefeMantenimiento As String = "JEFE MANTENIMIENTO"
    Public Const gNombrePerfilCoordinadorMantenimiento As String = "COORDINADOR MANTENIMIENTO"
    Public Const gNombrePerfilJefeTesoreria As String = "JEFE DE ADMINISTRACION"
    Public Const gNombrePerfilCaja As String = "CAJA"
    Public Const gNombrePerfilJefeContabilidad As String = "JEFE CONTABILIDAD"
    Public Const gNombrePerfilAdministrador As String = "ADMINISTRADOR GENERAL"
    Public Const gNombrePerfilFacturacionGuias As String = "ASISTENTE DE FACTURACION Y GUIAS"
    Public Const gNombrePerfilOperadorOperaciones As String = "OPERADOR DE OPERACIONES"
    Public Const gNombrePerfilDocumentosVehiculares As String = "ASISTENTE VEHICULAR"
    Public Const gNombrePerfilAsistenteTesoreria As String = "ASISTENTE TESORERIA"
    Public Const gNombrePerfilJefeCallCenter As String = "JEFE CALL CENTER"
    Public Const gNombrePerfilJefeControlFlota As String = "JEFE CONTROL FLOTA"
    Public Const gNombrePerfilSupervidorCallCenter As String = "SUPERVISOR CALL CENTER"
    Public Const gNombrePerfilOperadorCallCenter As String = "OPERADOR CALL CENTER"
    Public Const gNombrePerfilJefeLogistica As String = "JEFE DE LOGISTICA"
    Public Const gNombrePerfilAsistenteLogistica As String = "ASISTENTE DE LOGISTICA"
    Public Const gNombrePerfilJefeAlmacen As String = "JEFE ALMACEN"
    Public Const gNombrePerfilJefePersonal As String = "JEFE PERSONAL"
    Public Const gNombrePerfilAsistenteRRHH As String = "ASISTENTE DE RECURSOS HUMANOS"
    Public Const gNombrePerfilAutorizaOperaciones As String = "AUTORIZA OPERACIONES"
    Public Const gNombrePerfilAutorizaCallCenter As String = "AUTORIZA CALL CENTER"
    Public Const gNombrePerfilAutorizaTarifas As String = "AUTORIZA TARIFAS"
    Public Const gNombrePerfilJefeLiquidacion As String = "JEFE DE LIQUIDACION"


    Public Const gNombreAreaSuperiorAdministracion As String = "ADMINISTRACION"
    Public Const gNombreAreaSuperiorAuditoria As String = "AUDITORIA"
    Public Const gNombreAreaSuperiorContabilidad As String = "CONTABILIDAD"
    Public Const gNombreAreaSuperiorGerenciaGeneral As String = "GERENCIA GENERAL"
    Public Const gNombreAreaSuperiorInformaticaSistemas As String = "INFORMATICA Y SISTEMAS"
    Public Const gNombreAreaSuperiorOperaciones As String = "OPERACIONES"
    Public Const gNombreAreaSuperiorRecursosHumanos As String = "RECURSOS HUMANOS"
    Public Const gNombreAreaAdministracion As String = "ADMINISTRACION"
    Public Const gNombreAreaAuditoria As String = "AUDITORIA"
    Public Const gNombreAreaCaja As String = "CAJA"
    Public Const gNombreAreaCobranzas As String = "COBRANZA"
    Public Const gNombreAreaContabilidad As String = "CONTABILIDAD"
    Public Const gNombreAreaCoordinacionSupervisionOperacion As String = "COORDINACIÓN Y SUPERVISIÓN DE OPERACIÓN"
    Public Const gNombreAreaFacturacion As String = "FACTURACION"
    Public Const gNombreAreaGerenciaAdministrativa As String = "GERENCIA ADMINISTRATIVA"
    Public Const gNombreAreaGerenciaOperaciones As String = "GERENCIA DE OPERACIONES"
    Public Const gNombreAreaGerenciaGeneral As String = "GERENCIA GENERAL"
    Public Const gNombreAreaInformaticaSistemas As String = "INFORMATICA Y SISTEMAS"
    Public Const gNombreAreaLogistica As String = "LOGISTICA"
    Public Const gNombreAreaMantenimiento As String = "MANTENIMIENTO"
    Public Const gNombreAreaOperaciones As String = "OPERACIONES"
    Public Const gNombreAreaPlaneamientoControl As String = "PLANEAMIENTO Y CONTROL"
    Public Const gNombreAreaMonitoreoyGPS As String = "MONITOREO Y GPS"
    Public Const gNombreAreaRecursosHumanos As String = "RECURSOS HUMANOS"
    Public Const gNombreAreaSeguridadMedioAmbiente As String = "SEGURIDAD Y MEDIO AMBIENTE"
    Public Const gNombreAreaVentas As String = "VENTAS"

    'variables globales para estados generales en el ERP T&L
    Public Const gNombreEstadoAnulado As String = "ANULADO"
    Public Const gNombreEstadoAsignada As String = "ASIGNADA"
    Public Const gNombreEstadoCancelada As String = "CANCELADA"
    Public Const gNombreEstadoCarga As String = "CARGA"
    Public Const gNombreEstadoCuadrado As String = "CUADRADO"
    Public Const gNombreEstadoDescarga As String = "DESCARGA"
    Public Const gNombreEstadoDescuadrado As String = "DESCUADRADO"
    Public Const gNombreEstadoEmitida As String = "EMITIDA"
    Public Const gNombreEstadoEnviado As String = "ENVIADO"
    Public Const gNombreEstadoFin As String = "FIN"
    Public Const gNombreEstadoDeshabilitado As String = "DESHABILITADO"
    Public Const gNombreEstadoHabilitada As String = "HABILITADA"
    Public Const gNombreEstadoLiquidada As String = "LIQUIDADA"
    Public Const gNombreEstadoGenerada As String = "GENERADA"
    Public Const gNombreEstadoParcial As String = "PARCIAL"
    Public Const gNombreEstadoPendiente As String = "PENDIENTE"
    Public Const gNombreEstadoProgramado As String = "PROGRAMADO"
    Public Const gNombreEstadoReembolsado As String = "REEMBOLSADO"
    Public Const gNombreEstadoTerminada As String = "TERMINADA"
    Public Const gNombreEstadoTransito As String = "TRANSITO"
    Public Const gNombreEstadoEnProceso As String = "EN PROCESO"
    Public Const gNombreEstadoBueno As String = "BUENO"
    Public Const gNombreEstadoRegular As String = "REGULAR"
    Public Const gNombreEstadoMalo As String = "MALO"
    Public Const gNombreEstadoDeteriorado As String = "DETERIORADO"
    Public Const gNombreEstadoPorRecuperar As String = "POR RECUPERAR"
    Public Const gNombreEstadoRecuperados As String = "RECUPERADOS"
    Public Const gNombreEstadoPerdidos As String = "PERDIDOS"
    Public Const gNombreEstadoIntegrada As String = "INTEGRADA"
    Public Const gNombreEstadoAprobada As String = "APROBADA"
    Public Const gNombreEstadoCobrado As String = "COBRADO"
    Public Const gNombreEstadoPreEnviado As String = "PRE-ENVIADO"
    Public Const gNombreEstadoConsolidado As String = "CONSOLIDADO"
    Public Const gNombreEstadoCesado As String = "CESADO"
    Public Const gNombreEstadoCalculada As String = "CALCULADA"
    Public Const gNombreEstadoFirmada As String = "FIRMADA"
    Public Const gNombreEstadoPagada As String = "PAGADA"

    'variables globales para estados de ordenes logistica
    Public Const gNombreEstadoOrdenGenerada As String = "GENERADA"
    Public Const gNombreEstadoOrdenPreEvaluada As String = "PRE-EVALUADA"
    Public Const gNombreEstadoOrdenTerminada As String = "TERMINADA"
    Public Const gNombreEstadoOrdenRecepcionado As String = "RECEPCIONADO"
    Public Const gNombreEstadoOrdenAnulada As String = "ANULADA"
    Public Const gNombreEstadoOrdenDespachada As String = "DESPACHADA"
    Public Const gNombreEstadoOrdenPendiente As String = "PENDIENTE"
    Public Const gNombreEstadoOrdenEjecucion As String = "EJECUCION"
    Public Const gNombreEstadoOrdenAcopiado As String = "ACOPIADO"
    Public Const gNombreEstadoOrdenEnviado As String = "ENVIADO"
    Public Const gNombreEstadoOrdenEvaluada As String = "EVALUADA"
    Public Const gNombreEstadoOrdenAtendidoParcialmente As String = "ATENDIDO PARCIALMENTE"
    Public Const gNombreEstadoOrdenAtendido As String = "ATENDIDO"
    Public Const gNombreEstadoOrdenAprobada As String = "APROBADA"
    Public Const gNombreEstadoOrdenRechazada As String = "RECHAZADA"

    'Variables Globales para Concpto de Descuentos
    Public Const gCPBolsaViaje As String = "BOLSA DE VIAJE"
    Public Const gCPPrestamos As String = "PRESTAMOS"
    Public Const gCPSanciones As String = "SANCIONES"
    Public Const gCPMercaderia As String = "MERCADERIA"
    Public Const gCPAdelantos As String = "ADELANTOS"

    'Variables Globales para Flujo de Caja de ERP T&L
    Public Const gFCPrestamo As String = "PRESTAMOS"
    Public Const gFCAdelanto As String = "ADELANTOS"
    Public Const gFCLBS As String = "LIQUIDACION BENEFICIOS SOCIALES"
    Public Const gFCAFPPRIMA As String = "AFP PRIMA"
    Public Const gFCAFPPROFUTURO As String = "AFP PROFUTURO"
    Public Const gFCAFPINTEGRA As String = "AFP INTEGRA"
    Public Const gFCAFPHORIZONTE As String = "AFP HORIZONTE"
    Public Const gFCAFPHABITAT As String = "AFP HABITAT"
    Public Const gFCVACACIONES As String = "VACACIONES"
    Public Const gFCADEPAGDSCTO As String = "ANTICIPO PAGO DSCTO"
    Public Const gFCGastoFin As String = "COMISIONES Y GASTOS BANCARIOS"
    Public Const gFCITF As String = "PAGO DE ITF"
    Public Const gFCPH As String = "HABERES PLANILLA"

    'Variables Globales para Venta de Servicos
    Public Const gVSTransporte As String = "PRESTACION DE SERVICIO DE TRANSPORTE"
    Public Const gVSTracto As String = "VENTAS DE UNIDADES DE TRANSPORTES"
    Public Const gVSOtros As String = "OTROS SERVICIOS PRESTADOS"
    Public Const gVSMercaderia As String = "VENTA DE MERCADERIA"

    'Variables Globales para Cuentas Contables
    Public Const gCC16531 As String = "16531"

    'Variables Globales para Tipo Documentos
    Public Const gTDServicio As String = "SERVICIO"
    Public Const gTDMaterial As String = "MATERIAL"
    Public Const gTDOtro As String = "OTROS (ESPECIFICAR)"
    Public Const gTDNotaCredito As String = "NOTA DE CRÉDITO"

    'Variables Globales para Tipo Obligacion
    Public Const gTOLeasing As String = "LEASING"
    Public Const gTOFactDesc As String = "FACT_DESC"
    Public Const gTOFactoring As String = "FACTORING"
    Public Const gTOCreditoHipotecario As String = "CREDITO HIPOTECARIO"
    Public Const gTOPagare As String = "PAGARE"
    Public Const gTOPrestamo As String = "PRESTAMO"
    Public Const gTOFec As String = "FEC"
    Public Const gTOFed As String = "FEDD"

    'Variables Globales para Cta Ctble Tipo Obligacion
    Public Const gCCTOLeasing As String = "4521"
    Public Const gCCTOLetra As String = "4231"
    Public Const gCCTOFecFeddCredHipo As String = "4511"
    Public Const gCCTOFactDcto As String = "4549"
    Public Const gCCTOPagarePrestamoBanco As String = "4544"
    Public Const gCCTOPagareBanco As String = "4544"
    Public Const gCCTOPrestamoBanco As String = "4511"
    Public Const gCCTOPagarePrestamoNoBanco As String = "4699"

    'Variables Globales para Pago de Obligaciones
    Public Const gPOMora As String = "67372"
    Public Const gPOComision As String = "63911"
    Public Const gPOGastos As String = "67331"
    Public Const gPOITF As String = "64191"
    Public Const gPODescuento As String = "77511"

    'Variables Globales para Caso Especial Pago Obligacion
    Public Const gPOEFecSol As String = "455111"
    Public Const gPOEFecDol As String = "455112"
    Public Const gPOEPagare As String = "45544"

    'Variables Globales para Tipo EMpresa
    Public Const gTEFinancieraBancaria As String = "ENTIDADES FINANCIERAS BANCARIZADOS"
    Public Const gTEFinancieraNoBancaria As String = "ENTIDADES FINANCIERAS NO BANCARIZADOS"

    'Variables Globales para Formulas Planilla
    Public Const gFPIRenumBasico As String = "piRenumeracion"
    Public Const gFPIAsigFam As String = "piAsignacionFamiliar"
    Public Const gFPIRenumVaca As String = "piRenumeracionVacacional"
    Public Const gFPIVueltaCaliza As String = "plaVuelaCaliza"
    Public Const gFPIVueltaPiura As String = "piBonoGratificacion"
    Public Const gFPIBonoPiura As String = "piFeriados"
    Public Const gFPIConvoyPiura As String = "piCtsTruncas"
    Public Const gFPIVueltaLima As String = "piVacacionesTruncas"
    Public Const gFPIOtros As String = "piGratificacionTrunca"
    Public Const gFPIBonoProd As String = "plaBonificacionProduccion"
    Public Const gFPISubsidio As String = "plaSubsidio"
    Public Const gFPIHoraExt25 As String = "piHoraExtraA"
    Public Const gFPIHoraExt35 As String = "piHoraExtraB"
    Public Const gFPIHoraExtNoc As String = "plaHoraExtraC"
    Public Const gFPISubMaternidad As String = "plaSubsidioMaternidad"
    Public Const gFPICompenVac As String = "plaCompensacionVacacional"
    Public Const gFPIBonoResp As String = "plaBonoRespons"
    Public Const gFPIDescMed As String = "plaDescansoMedico"
    Public Const gFPISemaforo As String = "plaSemaforo"
    Public Const gFPIMovilidad As String = "plaMovilidad"
    Public Const gFPIOtroInafecto As String = "plaOtrosIngresosInafectos"

    'Variables Globales para Formula
    Public Const gFAsignacionFamiliar As String = "AsignacionFamiliar"
    Public Const gFUITRentaQuinta7 As String = "UITRTAQUINTA"
    Public Const gFUITRentaQuinta21 As String = "UITRTAQUINTAB"
    Public Const gFRT5R1 As String = "RentaVRangoA"
    Public Const gFRT5R2 As String = "RentaVRangoB"
    Public Const gFRT5R3 As String = "RentaVRangoC"
    Public Const gFRT5R4 As String = "RentaVRangoD"

    'Variables Globales para Parametros
    Public Const gPPorcentajeEsSaludER As String = "PORC_ESR"
    Public Const gPPorcentajeEsSaludEPS As String = "PORC_EPS"
    Public Const gPSueldoMinimo As String = "SULEDO_MIN"
    Public Const gPPorcentajeDescuento As String = "PROC_PREST"
    Public Const gPMontoLimitePrest As String = "MON_LIMPRE"
    Public Const gPPorcRT5R1 As String = "PORC_R5R1"
    Public Const gPPorcRT5R2 As String = "PORC_R5R2"
    Public Const gPPorcRT5R3 As String = "PORC_R5R3"
    Public Const gPPorcRT5R4 As String = "PORC_R5R4"
    Public Const gPPorcRT5R5 As String = "PORC_R5R5"

    Dim lARUsuario As New l_ActividadRestringido_Usuario

#End Region

    '' Variables para CPE
    '\\LADERA\ComprobanteElectronico\xml\
    'D:\Sistema\xml\
    Public gstrRutaDocumentosEle20 As String = "\\LADERA\ComprobanteElectronico\xml\"
    '\\LADERA\ComprobanteElectronico\cdr\
    'D:\Sistema\cdr\
    Public gstrRutaDocumentosCDR As String = "\\LADERA\ComprobanteElectronico\cdr\"

    Public TipoOC As String
    Public TipoMarca As String
    Public OpeMenu As String

    Public PararTiempo As Boolean = False

    Public o_Botonera As New e_Boton

    Public _Operacion As String
    Public gs_IdSucursal As String '@0001
    Public gs_PrefijoIdSucursal As String '@0001
    Public gs_IdClienteProveedorSistema As String '@0001
    Public gs_IdEmpresaSistema As String '@0001
    Public gs_TxtEmpresaSistema As String '@0001
    Public gs_RucEmpresaSistema As String '@0001
    Public gs_DireccionEmpresaSistema As String '@0001
    Public gs_VersionSis As String '@0001
    Public gs_SmtpClientSis As String '@0001
    Public gs_userNameCorreo As String '@0001
    Public gs_passwordCorreo As String '@0001
    '------------Variables Globales Demanda
    Public gNroDemanda As Integer

    Dim l_Configuracion As New l_Configuracion
    Dim oeProveedor As e_Proveedor
    Dim olProveedor As l_Proveedor
    Dim oeProceso As e_ProcesoNegocio
    Dim olProceso As l_ProcesoNegocio

    Dim leTipoDoc As New List(Of e_ProcesoTipoDocumento)
    Dim oeProDoc As e_ProcesoTipoDocumento
    Dim olProDoc As l_ProcesoTipoDocumento

    Public leListaVehiculo As New List(Of e_Vehiculo)
    Public leCuentaContable As New List(Of e_CuentaContable)

    Public ListaViajesOperacion As List(Of e_Viaje)

    'Para Material - Neumatico
    Public oeMDNAux As New e_Material_DisenoNeu
    Public leNOD As New List(Of e_DetalleOrdenNeumatico)

    'Para controlar los errores enviados por email
    Public errorEnviadoEmail As Boolean = False

    Dim olPeriodo As l_Periodo

    Private oeActividadRU As New e_ActividadRestringida_Usuario
    Public ls_IdGSancion As String = ""
    Public IndCuentaCP As Integer = 0

    'ctacte empresa
    Public loCtaCteEmpresa As List(Of e_CtaCte_ProAdq)

    Public IndLocalRemoto As Integer = 0

#Region "Combos"

    Public RutasPublic As List(Of e_Combo)
    Public ProveedorPublic As List(Of e_Combo)
    Public VendedorPublic As List(Of e_Combo)
    Public ClientesPublic As List(Of e_Combo)
    Public ClienteProveedorPublic As List(Of e_Combo)
    Public ComisionistasPublic As List(Of e_Combo)
    Public MaterialesPublic As List(Of e_Combo)
    Public LugaresPublic As List(Of e_Combo)
    Public ModeloFuncionalPublic As List(Of e_Combo)
    Public TipoRutaPublic As List(Of e_Combo)
    Public PersonasPublic As List(Of e_Combo)
    Public VehiculosD2Public As List(Of e_Combo)
    Public TractoPublic As List(Of e_Combo)
    Public CarretaPublic As List(Of e_Combo)
    Public TractoSinDocPublic As List(Of e_Combo)
    Public TesoreroPublic As List(Of e_Combo)
    Public PilotoPublic As List(Of e_Combo)
    Public CopilotoPublic As List(Of e_Combo)
    Public AyudantePublic As List(Of e_Combo)
    Public TipoCargaPublic As List(Of e_Combo)
    Public MonedaPublic As List(Of e_Combo)
    Public FlotaPublic As List(Of e_Combo)
    Public TipoVehiculoPublic As List(Of e_Combo)
    Public CentroPublic As List(Of e_Combo)
    Public UsuarioCentroPublic As List(Of e_Combo)
    Public CentroCostoPublic As List(Of e_Combo)
    Public MotivoDocumentoPublic As List(Of e_Combo)
    Public TrabajadorPublic As List(Of e_Combo)
    Public ZonaPublic As List(Of e_Combo)
    Public ZonaD2Public As List(Of e_Combo)
    Public ConceptoGastoPublic As List(Of e_Combo)
    Public OperacionesPublic As List(Of e_Combo)
    Public TipoDocVehPublic As List(Of e_Combo)
    Public TipoDocTrabPublic As List(Of e_Combo)
    Public CajaUsuarioCentro As List(Of e_Combo)
    Public AlmacenesPublic As List(Of e_Combo)
    Public MaterialAlmacenPublic As List(Of e_Combo)
    Public MatPreSubAlmPublic As List(Of e_Combo)
    Public EquiposPublic As List(Of e_Combo)
    Public MaterialSubFamilia As List(Of e_Combo)
    Public CategoriaServicioPublic As List(Of e_Combo)
    Public CodigoBarrasPublic As List(Of e_Combo)
    Public AsistenteCajaPublic As List(Of e_Combo)
    Public CtaCtblePublic As List(Of e_Combo)
    Public CorreosPublic As List(Of e_Combo)
    Public AreasPublic As List(Of e_Combo)
    Public DocImpPublic As List(Of e_Combo)
    Public TipoPagoPublic As List(Of e_Combo)
    Public MatGeneralPublic As List(Of e_Combo)
    Public AlmNombrePublic As List(Of e_Combo)
    Public TipoGastoPublic As List(Of e_Combo)
    Public OTEquAlmPublic As List(Of e_Combo)
    Public SubAlmDiesel As List(Of e_Combo)
    Public SubAlmGrifo As List(Of e_Combo)
    'ILLL
    Public TipoIncidenciaPublic As List(Of e_Combo)
    Public GradoIncidenciaPublic As List(Of e_Combo)
    Public PrioridadIncidenciaPublic As List(Of e_Combo)
    Public TipoAlarmaPublic As List(Of e_Combo)
    Public OperadorPublic As List(Of e_Combo)
    Public TipoAccidentePublic As List(Of e_Combo)

    Public UnidadMedidaPublic As List(Of e_Combo)
    Public DireccionClienteProveedorPublic As List(Of e_Combo)


    Private olCombo As l_Combo
    Private oeCombo As e_Combo

    Public Sub LlenaCombos()

        oeCombo = New e_Combo
        olCombo = New l_Combo

        oeCombo.Nombre = "Rutas"
        RutasPublic = New List(Of e_Combo)
        RutasPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        ClientesPublic = New List(Of e_Combo)
        oeCombo = New e_Combo
        oeCombo.Nombre = "Clientes"
        ClientesPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        ProveedorPublic = New List(Of e_Combo)
        oeCombo = New e_Combo
        oeCombo.Nombre = "Proveedores"
        ProveedorPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        VendedorPublic = New List(Of e_Combo)
        oeCombo = New e_Combo
        oeCombo.Nombre = "Vendedores"
        VendedorPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        ComisionistasPublic = New List(Of e_Combo)
        oeCombo = New e_Combo
        oeCombo.Nombre = "Comisionistas"
        ComisionistasPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        MaterialesPublic = New List(Of e_Combo)
        oeCombo = New e_Combo
        oeCombo.Nombre = "Materiales"
        MaterialesPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        MatGeneralPublic = New List(Of e_Combo)
        oeCombo = New e_Combo
        oeCombo.Nombre = "MaterialesGeneral"
        MatGeneralPublic.AddRange(olCombo.Listar(oeCombo))

        LugaresPublic = New List(Of e_Combo)
        oeCombo = New e_Combo
        oeCombo.Nombre = "Lugares"
        LugaresPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        oeCombo = New e_Combo
        oeCombo.Nombre = "ModeloFuncional"
        ModeloFuncionalPublic = New List(Of e_Combo)
        ModeloFuncionalPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        oeCombo = New e_Combo
        oeCombo.Nombre = "ImpuestoDocumento"
        DocImpPublic = New List(Of e_Combo)
        DocImpPublic.AddRange(olCombo.Listar(oeCombo))

        oeCombo = New e_Combo
        oeCombo.Nombre = "TipoPago"
        TipoPagoPublic = New List(Of e_Combo)
        TipoPagoPublic.AddRange(olCombo.Listar(oeCombo))

        oeCombo = New e_Combo
        oeCombo.Nombre = "TipoRuta"
        TipoRutaPublic = New List(Of e_Combo)
        TipoRutaPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        oeCombo = New e_Combo
        oeCombo.Nombre = "Persona"
        PersonasPublic = New List(Of e_Combo)
        PersonasPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        oeCombo = New e_Combo
        oeCombo.Nombre = "Tracto"
        TractoPublic = New List(Of e_Combo)
        TractoPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        oeCombo = New e_Combo
        oeCombo.Nombre = "VehiculosCombustible"
        VehiculosD2Public = New List(Of e_Combo)
        VehiculosD2Public.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        oeCombo = New e_Combo
        oeCombo.Nombre = "Tracto"
        TractoPublic = New List(Of e_Combo)
        TractoPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        oeCombo = New e_Combo
        oeCombo.Nombre = "Areas"
        AreasPublic = New List(Of e_Combo)
        AreasPublic.AddRange(olCombo.Listar(oeCombo))

        oeCombo = New e_Combo
        oeCombo.Nombre = "Carreta"
        CarretaPublic = New List(Of e_Combo)
        CarretaPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        If PerfilAsignado(gNombrePerfilFacturacionGuias) Then
            oeCombo = New e_Combo
            oeCombo.Nombre = "Guias"
            TractoSinDocPublic = New List(Of e_Combo)
            TractoSinDocPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
        End If

        oeCombo = New e_Combo
        oeCombo.Nombre = "UMedida"
        UnidadMedidaPublic = olCombo.Listar(oeCombo)

        oeCombo = New e_Combo
        oeCombo.Nombre = "DireccionEmpresaFiscal"
        DireccionClienteProveedorPublic = olCombo.Listar(oeCombo)

        oeCombo = New e_Combo
        oeCombo.Nombre = "Piloto"
        PilotoPublic = New List(Of e_Combo)
        PilotoPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        oeCombo = New e_Combo
        With oeCombo
            .Id = "0"
            .Nombre = "NINGUNO"
            .Descripcion = True
            .Extras.Add("01/01/1901")
        End With
        CopilotoPublic = New List(Of e_Combo)
        CopilotoPublic.Add(oeCombo)

        oeCombo = New e_Combo
        With oeCombo
            .Id = ""
            .Nombre = "NINGUNO"
            .Descripcion = True
        End With
        TesoreroPublic = New List(Of e_Combo)
        TesoreroPublic.Add(oeCombo)
        oeCombo = New e_Combo
        oeCombo.Nombre = "Cajero"
        TesoreroPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        oeCombo = New e_Combo
        oeCombo.Nombre = "Copiloto"
        CopilotoPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        oeCombo = New e_Combo
        With oeCombo
            .Id = "0"
            .Nombre = "NINGUNO"
            .Descripcion = True
        End With
        AyudantePublic = New List(Of e_Combo)
        AyudantePublic.Add(oeCombo)
        oeCombo = New e_Combo
        oeCombo.Nombre = "Ayudante"
        AyudantePublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        oeCombo = New e_Combo
        oeCombo.Nombre = "TipoCarga"
        TipoCargaPublic = New List(Of e_Combo)
        TipoCargaPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        oeCombo = New e_Combo
        oeCombo.Nombre = "Moneda"
        MonedaPublic = New List(Of e_Combo)
        MonedaPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Id).ToList)

        oeCombo = New e_Combo
        oeCombo.Id = ""
        oeCombo.Nombre = "TODOS"
        FlotaPublic = New List(Of e_Combo)
        FlotaPublic.Add(oeCombo)
        oeCombo = New e_Combo
        oeCombo.Nombre = "Flota"
        FlotaPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        TipoVehiculoPublic = New List(Of e_Combo)
        oeCombo = New e_Combo
        oeCombo.Nombre = "TipoVehiculo"
        TipoVehiculoPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        oeCombo = New e_Combo
        oeCombo.Id = ""
        oeCombo.Nombre = "TODOS"
        CentroPublic = New List(Of e_Combo)
        CentroPublic.Add(oeCombo)
        oeCombo = New e_Combo
        oeCombo.Nombre = "Centro"
        CentroPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        oeCombo = New e_Combo
        oeCombo.Nombre = "CentroCosto"
        CentroCostoPublic = New List(Of e_Combo)
        CentroCostoPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        oeCombo = New e_Combo
        oeCombo.Nombre = "MotivoDocumento"
        MotivoDocumentoPublic = New List(Of e_Combo)
        MotivoDocumentoPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        oeCombo = New e_Combo
        oeCombo.Nombre = "Trabajador"
        TrabajadorPublic = New List(Of e_Combo)
        TrabajadorPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        oeCombo = New e_Combo
        oeCombo.Nombre = "OTAlmEqui"
        OTEquAlmPublic = New List(Of e_Combo)
        OTEquAlmPublic.AddRange(olCombo.Listar(oeCombo))

        oeCombo = New e_Combo
        oeCombo.Id = ""
        oeCombo.Nombre = "TODOS"
        ZonaPublic = New List(Of e_Combo)
        ZonaPublic.Add(oeCombo)
        oeCombo = New e_Combo
        oeCombo.Nombre = "Zona"
        ZonaPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        oeCombo = New e_Combo
        oeCombo.Id = ""
        oeCombo.Nombre = "TODOS"
        ZonaD2Public = New List(Of e_Combo)
        ZonaD2Public.Add(oeCombo)
        oeCombo = New e_Combo
        oeCombo.Nombre = "ZonaD2"
        ZonaD2Public.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        oeCombo = New e_Combo
        oeCombo.Id = ""
        oeCombo.Nombre = "TD VEHICULAR"
        TipoDocVehPublic = New List(Of e_Combo)
        TipoDocVehPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(item) item.Nombre).ToList)

        oeCombo = New e_Combo
        oeCombo.Id = ""
        oeCombo.Nombre = "TD IDENTIDAD"
        TipoDocTrabPublic = New List(Of e_Combo)
        TipoDocTrabPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(item) item.Nombre).ToList)

        oeCombo = New e_Combo
        oeCombo.Id = ""
        oeCombo.Nombre = "CAJA USUARIO"
        CajaUsuarioCentro = New List(Of e_Combo)
        CajaUsuarioCentro.AddRange(olCombo.Listar(oeCombo))

        oeCombo = New e_Combo
        oeCombo.Id = ""
        oeCombo.Nombre = "ALMACENES"
        AlmacenesPublic = New List(Of e_Combo)
        AlmacenesPublic.AddRange(olCombo.Listar(oeCombo))

        oeCombo = New e_Combo
        oeCombo.Id = ""
        oeCombo.Nombre = "ALMACENESNOMBRE"
        AlmNombrePublic = New List(Of e_Combo)
        AlmNombrePublic.AddRange(olCombo.Listar(oeCombo))

        oeCombo = New e_Combo
        oeCombo.Nombre = "MATERIAL ALMACEN"
        MaterialAlmacenPublic = New List(Of e_Combo)
        MaterialAlmacenPublic.AddRange(olCombo.Listar(oeCombo))

        oeCombo = New e_Combo
        oeCombo.Nombre = "MATERIAL PRECIO SUBALMACEN"
        MatPreSubAlmPublic = New List(Of e_Combo)
        MatPreSubAlmPublic.AddRange(olCombo.Listar(oeCombo))

        oeCombo = New e_Combo
        oeCombo.Nombre = "EQUIPO"
        EquiposPublic = New List(Of e_Combo)
        EquiposPublic.AddRange(olCombo.Listar(oeCombo))

        oeCombo = New e_Combo
        oeCombo.Nombre = "MATERIALSUBFAMILIA"
        MaterialSubFamilia = New List(Of e_Combo)
        MaterialSubFamilia.AddRange(olCombo.Listar(oeCombo))

        oeCombo = New e_Combo
        oeCombo.Nombre = "CATEGORIASERVICIO"
        CategoriaServicioPublic = New List(Of e_Combo)
        CategoriaServicioPublic.AddRange(olCombo.Listar(oeCombo))

        oeCombo = New e_Combo
        oeCombo.Id = ""
        oeCombo.Nombre = "ClienteProveedor"
        ClienteProveedorPublic = New List(Of e_Combo)
        ClienteProveedorPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(item) item.Nombre).ToList)

        oeCombo = New e_Combo
        oeCombo.Id = ""
        oeCombo.Nombre = "CODIGOBARRAS"
        CodigoBarrasPublic = New List(Of e_Combo)
        CodigoBarrasPublic.AddRange(olCombo.Listar(oeCombo))

        oeCombo = New e_Combo
        oeCombo.Id = ""
        oeCombo.Nombre = "ASISTENTECAJA"
        AsistenteCajaPublic = New List(Of e_Combo)
        AsistenteCajaPublic.AddRange(olCombo.Listar(oeCombo))

        oeCombo = New e_Combo
        oeCombo.Id = ""
        oeCombo.Nombre = "CUENTASCONTABLES"
        CtaCtblePublic = New List(Of e_Combo)
        CtaCtblePublic.AddRange(olCombo.Listar(oeCombo))

        oeCombo = New e_Combo
        oeCombo.Id = ""
        oeCombo.Nombre = "CORREOS"
        CorreosPublic = New List(Of e_Combo)
        CorreosPublic.AddRange(olCombo.Listar(oeCombo))

        'ILLL

        oeCombo = New e_Combo
        oeCombo.Nombre = "TipoIncidencia"
        TipoIncidenciaPublic = New List(Of e_Combo)
        TipoIncidenciaPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        oeCombo = New e_Combo
        oeCombo.Nombre = "GradoIncidencia"
        GradoIncidenciaPublic = New List(Of e_Combo)
        GradoIncidenciaPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        oeCombo = New e_Combo
        oeCombo.Nombre = "PrioridadIncidencia"
        PrioridadIncidenciaPublic = New List(Of e_Combo)
        PrioridadIncidenciaPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        oeCombo = New e_Combo
        oeCombo.Nombre = "TipoAlarma"
        TipoAlarmaPublic = New List(Of e_Combo)
        TipoAlarmaPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        oeCombo = New e_Combo
        oeCombo.Nombre = "Operador"
        OperadorPublic = New List(Of e_Combo)
        OperadorPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        oeCombo = New e_Combo
        oeCombo.Nombre = "TipoAccidente"
        TipoAccidentePublic = New List(Of e_Combo)
        TipoAccidentePublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        oeCombo = New e_Combo
        oeCombo.Nombre = "TipoGasto"
        TipoGastoPublic = New List(Of e_Combo)
        TipoGastoPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        oeCombo = New e_Combo
        oeCombo.Nombre = "AlmacenDiesel"
        SubAlmDiesel = New List(Of e_Combo)
        SubAlmDiesel.AddRange(olCombo.Listar(oeCombo))

        oeCombo = New e_Combo
        oeCombo.Nombre = "AlmacenGrifo"
        SubAlmGrifo = New List(Of e_Combo)
        SubAlmGrifo.AddRange(olCombo.Listar(oeCombo))

    End Sub

#End Region

#Region "IGV"

    Public oeIGVGlobal As New e_Impuesto
    Dim olIGV As l_Impuesto

    ''' <summary>
    ''' Metodo que Carga el IGV
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CargaIGV()
        oeIGVGlobal = New e_Impuesto
        olIGV = New l_Impuesto
        oeIGVGlobal = olIGV.IGV(ObtenerFechaServidor())
    End Sub

#End Region

#Region "Entidades Globales"
    Public IncidenciasPublic As e_IncidenciasAutentificadas

    'Colores bases del ERP T&L
    Public Blanco As Color = Color.White
    Public Negro As Color = Color.Black
    Public Rojo As Color = Color.Red
    Public Amarillo As Color = Color.Yellow
    Public Azul As Color = Color.Blue
    Public Trigo As Color = Color.Wheat
    Public VerdeClaro As Color = Color.LightGreen
    Public Coral As Color = Color.Coral
    Public Kaki As Color = Color.Khaki
    Public Plata As Color = Color.Silver
    Public Ciruela As Color = Color.Plum
    Public Azulino As Color = Color.PowderBlue
    Public MarronClaro As Color = Color.SandyBrown
    Public Indio As Color = Color.IndianRed
    Public Celeste As Color = Color.AliceBlue

#End Region

#Region "Metodos"

    Public Function VersionDelSistema() As String

        Dim version As String = String.Empty
        '@0003
        If Deployment.Application.ApplicationDeployment.IsNetworkDeployed = True Then
            'version = String.Format("Versión {0}", My.Application.Deployment.CurrentVersion.ToString)
            'version = String.Format(My.Application.Deployment.CurrentVersion.ToString) '@0001
            version = String.Format(My.Application.Info.Version.ToString) '@0001
        Else
            'version = String.Format("Versión {0}", My.Application.Info.Version.ToString)
            version = String.Format(My.Application.Info.Version.ToString)
        End If
        'Return version
        '@0003 Inicio
        'Dim oeEmpresaSistemas As New e_EmpresaSistemas
        'oeEmpresaSistemas = olEmpresaSistema.Obtener(oeEmpresaSistemas)
        'version = oeEmpresaSistemas.VersionSis.Trim
        gs_VersionSis = version.Trim
        Return version
        '@0003 Fin
    End Function

    Public Function AutenticarUsuario() As Boolean
        Try
            Dim formularioLogin As New frm_Login
            For contador As Integer = 0 To 2
                formularioLogin.ShowDialog()
                If gUsuarioSGI.Autenticado Then
                    Exit For
                End If
            Next
            Return gUsuarioSGI.Autenticado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Obtener el centro del usuario actual
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerCentro(PrefijoId As String) As e_Centro
        Dim oecentro As New e_Centro
        Dim olCentro As New l_Centro
        oecentro.TipoOperacion = "2"
        oecentro.PrefijoID = PrefijoId
        oecentro = olCentro.Obtener(oecentro)
        Return oecentro
    End Function

    Public Function ObtenerListaMoneda(Optional AgregarTodos As Boolean = False) As List(Of e_Moneda) 'Cess
        Dim Logica As New l_Moneda
        Dim Lista As New List(Of e_Moneda)
        Dim ListaAux As New List(Of e_Moneda)
        Dim Item As New e_Moneda
        Item.Activo = True
        Item.TipoOperacion = "1"
        Lista = Logica.Listar(Item)
        If AgregarTodos Then
            Item = New e_Moneda
            Item.Id = ""
            Item.Nombre = "TODOS"
            ListaAux.Add(Item)
            ListaAux.AddRange(Lista)
            Return ListaAux
        Else
            Return Lista
        End If
    End Function

    Public Function ObtenerListaTurno(Optional AgregarTodos As Boolean = False) As List(Of e_Turno) 'Cess
        Dim Logica As New l_Turno
        Dim Lista As New List(Of e_Turno)
        Dim ListaAux As New List(Of e_Turno)
        Dim Item As New e_Turno
        Item.Activo = True
        Item.TipoOperacion = "1"
        Lista = Logica.Listar(Item)
        If AgregarTodos Then
            Item = New e_Turno
            With Item
                .Id = ""
                .Turno = "TODOS"
            End With
            ListaAux.Add(Item)
            ListaAux.AddRange(Lista)
            Return ListaAux
        Else
            Return Lista
        End If
    End Function

    Public Function ObtenerListaEstado(Optional AgregarTodos As Boolean = False) As List(Of e_Estado) 'Cess
        Dim Logica As New l_Estado
        Dim Lista As New List(Of e_Estado)
        Dim ListaAux As New List(Of e_Estado)
        Dim Item As New e_Estado
        Item.Activo = True
        Item.TipoOperacion = "1"
        Lista = Logica.Listar(Item)
        If AgregarTodos Then
            Item = New e_Estado
            With Item
                .Id = ""
                .Nombre = "TODOS"
            End With
            ListaAux.Add(Item)
            ListaAux.AddRange(Lista)
            Return ListaAux
        Else
            Return Lista
        End If
    End Function

    ''' <summary>
    ''' Función para generar el contenedor de datos de alerta global del sistema
    ''' </summary>
    ''' <param name="titulo">Título del mensaje, asociado a la propiedad Caption</param>
    ''' <param name="mensaje">Mensaje que se desea mostrar</param>
    ''' <param name="imagen">Icono asociado a la alerta</param>
    ''' <param name="informacion">key de la alerta</param>
    ''' <param name="ubicacion">posición u ubicación donde se debe mostrar la alerta</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CargarDatosAlerta(titulo As String, mensaje As String, Optional imagen As Image = Nothing, Optional informacion As String = "", Optional ubicacion As ScreenPosition = ScreenPosition.Default) As UltraDesktopAlertShowWindowInfo
        Dim showInfo As UltraDesktopAlertShowWindowInfo = New UltraDesktopAlertShowWindowInfo()
        showInfo.Caption = titulo
        showInfo.Text = mensaje
        showInfo.Image = imagen
        showInfo.Key = informacion
        showInfo.ScreenPosition = ubicacion
        Return showInfo
    End Function

    ''' <summary>
    ''' Controla de Manera Libre la Botonera Principal del sistema
    ''' </summary>
    ''' <param name="Consultar">Boton Consultar</param>
    ''' <param name="Nuevo">Boton Nuevo</param>
    ''' <param name="Editar">Boton Editar</param>
    ''' <param name="Guardar">Boton Guardar</param>
    ''' <param name="Cancelar">Boton Cancelar</param>
    ''' <param name="Eliminar">Boton Eliminar</param>
    ''' <param name="Imprimir">Boton Imprimir</param>
    ''' <param name="Exportar">Boton Exportar</param>
    ''' <param name="Salir">Boton Salir</param>
    ''' <remarks></remarks>
    ''' 
    Public Sub ControlBoton(Optional ByVal Consultar As Boolean = False _
                                , Optional ByVal Nuevo As Boolean = False _
                                , Optional ByVal Editar As Boolean = False _
                                , Optional ByVal Guardar As Boolean = False _
                                , Optional ByVal Cancelar As Boolean = False _
                                , Optional ByVal Eliminar As Boolean = False _
                                , Optional ByVal Imprimir As Boolean = False _
                                , Optional ByVal Exportar As Boolean = False _
                                , Optional ByVal Salir As Boolean = True)
        o_Botonera.Consultar = Consultar
        o_Botonera.Nuevo = Nuevo
        o_Botonera.Editar = Editar
        o_Botonera.Guardar = Guardar
        o_Botonera.Cancelar = Cancelar
        o_Botonera.Eliminar = Eliminar
        o_Botonera.Imprimir = Imprimir
        o_Botonera.Exportar = Exportar
        o_Botonera.Salir = Salir
        Botones(o_Botonera)

    End Sub

    ''' <summary>
    ''' Habilita o Deshabilita Botonera Principal de Maestro
    ''' </summary>
    ''' <param name="oeBoton">Objeto de Tipo Boton</param>
    ''' <remarks></remarks>
    ''' 
    Public Sub Botones(ByVal oeBoton As e_Boton)
        Try
            frm_Menu.utm_ISLSGI.Tools("Consultar").SharedProps.Enabled = oeBoton.Consultar
            frm_Menu.utm_ISLSGI.Tools("Nuevo").SharedProps.Enabled = oeBoton.Nuevo
            frm_Menu.utm_ISLSGI.Tools("Editar").SharedProps.Enabled = oeBoton.Editar
            frm_Menu.utm_ISLSGI.Tools("Guardar").SharedProps.Enabled = oeBoton.Guardar
            frm_Menu.utm_ISLSGI.Tools("Cancelar").SharedProps.Enabled = oeBoton.Cancelar
            frm_Menu.utm_ISLSGI.Tools("Eliminar").SharedProps.Enabled = oeBoton.Eliminar
            frm_Menu.utm_ISLSGI.Tools("Imprimir").SharedProps.Enabled = oeBoton.Imprimir
            frm_Menu.utm_ISLSGI.Tools("Exportar").SharedProps.Enabled = oeBoton.Exportar
            frm_Menu.utm_ISLSGI.Tools("Salir").SharedProps.Enabled = oeBoton.Salir
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Retorna valor del Tipo de cambio del día)
    ''' </summary>
    ''' <param name="Fecha">Fecha del tipo de cambio</param>
    ''' <param name="IndUltimoTC">IndUltimo= True: retorna ultimo Tipo de Cambio(de la fecha hacia atras)</param>
    ''' <returns>Array de Double donde: Posc 0= TC Venta, Posc 1= TC Compra </returns>
    ''' <remarks></remarks>
    ''' 
    Public Function TipoCambio(ByVal Fecha As Date, Optional ByVal IndUltimoTC As Boolean = False) As Double()
        Try
            Dim TC(1) As Double
            TC(0) = 0
            TC(1) = 0
            Dim oeTC As New e_TipoCambio
            Dim leTC As New List(Of e_TipoCambio)
            Dim olTc As New l_TipoCambio
            oeTC.FechaCambio = Fecha.Date
            If IndUltimoTC Then
                oeTC.TipoOperacion = "U"
            Else
                oeTC.TipoOperacion = "C"
            End If
            leTC.AddRange(olTc.Listar(oeTC))
            If leTC.Count > 0 Then
                'If Tipo = "V" Then
                TC(0) = leTC(0).CambioVenta
                'ElseIf Tipo = "C" Then
                TC(1) = leTC(0).CambioCompra
                'End If
            Else
                'Throw New Exception("No existe Tipo de cambio para esta Fecha")
            End If
            Return TC
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function TipoCambioCompraVenta(ByVal Fecha As Date) As String
        Try
            Dim TC As String
            Dim oeTC As New e_TipoCambio
            Dim leTC As New List(Of e_TipoCambio)
            Dim olTc As New l_TipoCambio

            oeTC.TipoOperacion = "U"
            oeTC.Activo = True
            oeTC.FechaCambio = Fecha
            oeTC = olTc.Listar(oeTC)(0)

            TC = "│ TC. al: " + oeTC.FechaCambio.Date + "│ Compra: S/" + oeTC.CambioCompra.ToString + " │ Venta: S/" + oeTC.CambioVenta.ToString + " │ "
            Return TC

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ConvertirUnidadBase(ByVal Cantidad As Double, ByVal IdUnidadMedida As String) As Double
        Try
            Dim cant As Double = 0
            Dim factor As Double = 0
            Dim oeUnidadMedida As New e_UnidadMedida
            Dim olUnidadMedida As New l_UnidadMedida
            oeUnidadMedida.TipoOperacion = ""
            oeUnidadMedida.Id = IdUnidadMedida
            oeUnidadMedida = olUnidadMedida.Obtener(oeUnidadMedida)
            factor = oeUnidadMedida.Factor
            oeUnidadMedida = Nothing
            cant = Cantidad * factor
            Return cant
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function FormatoDocumento(ByVal TextoF As String,
                                    ByVal Cantidad As Integer) As String
        Dim ln As String = ""
        For i As Integer = 1 To Cantidad - Len(TextoF)
            ln = ln + "0"
        Next
        Return ln + TextoF
    End Function

    Public Function FormatoSerieElectronica(ByVal TextoF As String,
                                    ByVal Tipo As String) As String
        Dim ln As String = ""
        For i As Integer = 1 To 3 - Len(TextoF)
            ln = ln + "0"
        Next
        Return Tipo + ln + TextoF
    End Function

    Public Function CrearComboGrid3(stNomColumnaGrilla As String, stNomColumnaTabla As String, stGrilla As UltraWinGrid.UltraGrid, boDropDownList As Boolean)
        With stGrilla.DisplayLayout
            If boDropDownList = True Then
                .Bands(0).Columns(stNomColumnaGrilla).Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
            Else
                .Bands(0).Columns(stNomColumnaGrilla).Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDown
            End If
            .Bands(0).Columns(stNomColumnaGrilla).ValueList = .ValueLists(stNomColumnaGrilla)
            .ValueLists(stNomColumnaGrilla).MaxDropDownItems = 20
        End With
        Return True
    End Function

    Public Function CrearComboGrid(stNomColumnaGrilla As String, stNomColumnaTabla As String, stGrilla As UltraWinGrid.UltraGrid, Dt As DataTable, boDropDownList As Boolean)
        With stGrilla.DisplayLayout
            If .Bands(0).Columns.Exists(stNomColumnaGrilla) Then
                .ValueLists.Clear()
                .ValueLists.Add(stNomColumnaGrilla)
            Else
                .Bands(0).Columns.Add().Key = stNomColumnaGrilla
                .ValueLists.Clear()
                .ValueLists.Add(stNomColumnaGrilla)
            End If
            With .ValueLists(stNomColumnaGrilla).ValueListItems
                .Clear()
                For I As Integer = 0 To Dt.Rows.Count - 1
                    .Add(Dt.Rows(I)(0), Dt.Rows(I)(stNomColumnaTabla))
                Next
            End With
            If boDropDownList = True Then
                .Bands(0).Columns(stNomColumnaGrilla).Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
            Else
                .Bands(0).Columns(stNomColumnaGrilla).Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDown
            End If
            .Bands(0).Columns(stNomColumnaGrilla).ValueList = .ValueLists(stNomColumnaGrilla)
            .ValueLists(stNomColumnaGrilla).MaxDropDownItems = 20
        End With
        Return True
    End Function

    Public Function CrearComboGridPorCelda(ByVal stNomColumnaGrilla As String,
                           ByVal stNomColumnaTabla As String,
                           ByVal inNroFila As Integer,
                           ByVal stGrilla As UltraWinGrid.UltraGrid,
                           ByVal Dt As DataTable,
                           ByVal boDropDownList As Boolean)
        'Si el Grid ya sido creado o igualada un Datatable 
        With stGrilla.DisplayLayout
            If .Bands(0).Columns.Exists(stNomColumnaGrilla) Then
                .ValueLists.Clear()
                .ValueLists.Add(stNomColumnaGrilla)
            Else
                'Si el Grid recien se esta creando se Agregan Keys (Identificadores de Columna)
                .Bands(0).Columns.Add().Key = stNomColumnaGrilla
                .ValueLists.Clear()
                .ValueLists.Add(stNomColumnaGrilla)
            End If
            With .ValueLists(stNomColumnaGrilla).ValueListItems
                .Clear()
                For I As Integer = 0 To Dt.Rows.Count - 1
                    .Add(Dt.Rows(I)(0), Dt.Rows(I)(stNomColumnaTabla))
                Next
                '.Item(0).DisplayText = "Ninguno" 'Dt.Rows(0)(stNomColumnaTabla)                
            End With
            If boDropDownList Then
                .Bands(0).Columns(stNomColumnaGrilla).Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
            Else
                .Bands(0).Columns(stNomColumnaGrilla).Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDown
            End If
            stGrilla.Rows(inNroFila).Cells(stNomColumnaGrilla).ValueList = .ValueLists(stNomColumnaGrilla)
            .ValueLists(stNomColumnaGrilla).MaxDropDownItems = 20
        End With
        Return True
    End Function

    Public Function CrearComboGridPorCelda(stNomColumnaGrilla As String, stIdColumnaTabla As String, stNomColumnaTabla As String,
                            inNroFila As Integer, stGrilla As UltraWinGrid.UltraGrid, Dt As DataTable, boDropDownList As Boolean)
        With stGrilla.DisplayLayout
            If .Bands(0).Columns.Exists(stNomColumnaGrilla) Then
                .ValueLists.Clear()
                .ValueLists.Add(stNomColumnaGrilla)
            Else
                .Bands(0).Columns.Add().Key = stNomColumnaGrilla
                .ValueLists.Clear()
                .ValueLists.Add(stNomColumnaGrilla)
            End If
            With .ValueLists(stNomColumnaGrilla).ValueListItems
                .Clear()
                For I As Integer = 0 To Dt.Rows.Count - 1
                    .Add(Dt.Rows(I)(stIdColumnaTabla), Dt.Rows(I)(stNomColumnaTabla))
                Next
            End With
            If boDropDownList Then
                .Bands(0).Columns(stNomColumnaGrilla).Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
            Else
                .Bands(0).Columns(stNomColumnaGrilla).Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDown
            End If
            stGrilla.Rows(inNroFila).Cells(stNomColumnaGrilla).ValueList = .ValueLists(stNomColumnaGrilla)
            .ValueLists(stNomColumnaGrilla).MaxDropDownItems = 20
        End With
        Return True
    End Function

    Public Function CrearComboGridCelda(ByVal stNomColumnaGrilla As String,
                           ByVal stNomColumnaTabla As String,
                           ByVal inNroFila As Integer,
                           ByVal stGrilla As UltraWinGrid.UltraGrid,
                           ByVal Dt As DataTable,
                           ByVal boDropDownList As Boolean)
        'Si el Grid ya sido creado o igualada un Datatable 
        With stGrilla.DisplayLayout
            If .Bands(0).Columns.Exists(stNomColumnaGrilla) Then
                .ValueLists.Clear()
                .ValueLists.Add(stNomColumnaGrilla)
            Else
                .Bands(0).Columns.Add().Key = stNomColumnaGrilla
            End If
            With .ValueLists(stNomColumnaGrilla).ValueListItems
                .Clear()
                For I As Integer = 0 To Dt.Rows.Count - 1
                    .Add(Dt.Rows(I)(0), Dt.Rows(I)(stNomColumnaTabla))
                Next
            End With
            If boDropDownList Then
                .Bands(0).Columns(stNomColumnaGrilla).Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
            Else
                .Bands(0).Columns(stNomColumnaGrilla).Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDown
            End If

            .Bands(0).Columns(stNomColumnaGrilla).ValueList = .ValueLists(stNomColumnaGrilla)
            stGrilla.Rows(inNroFila).Cells(stNomColumnaGrilla).ValueList = .ValueLists(stNomColumnaGrilla)
            .ValueLists(stNomColumnaGrilla).MaxDropDownItems = 20

            'stGrilla.Rows(inNroFila).Cells(stNomColumnaGrilla).Value = Dt.Rows(0)(stNomColumnaTabla)


        End With

        'stGrilla.DisplayLayout.ValueLists(stNomColumnaGrilla).ValueListItems.ValueList.SelectedItem = "Barriles"
        Return True
    End Function

    Public Function gfc_CombroGrillaCelda(ColGri As String, ColTab As String, NroFila As Integer, stGrilla As UltraGrid, Dt As DataTable, Optional TipoLista As Boolean = True)
        With stGrilla.DisplayLayout
            If .Bands(0).Columns.Exists(ColGri) Then
                .ValueLists.Clear()
                .ValueLists.Add(ColGri)
            Else
                .Bands(0).Columns.Add().Key = ColGri
                .ValueLists.Clear()
                .ValueLists.Add(ColGri)
            End If
            With .ValueLists(ColGri).ValueListItems
                .Clear()
                For I As Integer = 0 To Dt.Rows.Count - 1
                    .Add(Dt.Rows(I)(0), Dt.Rows(I)(ColTab))
                Next
            End With
            If TipoLista Then
                .Bands(0).Columns(ColGri).Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
            Else
                .Bands(0).Columns(ColGri).Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDown
            End If

            stGrilla.Rows(NroFila).Cells(ColGri).ValueList = .ValueLists(ColGri)
            .ValueLists(ColGri).MaxDropDownItems = 20
        End With
        Return True
    End Function

    Public Function MostrarTabs(Tab_Mostrar As Integer, TAB As UltraWinTabControl.UltraTabControl, Optional Tab_Adicional As Integer = 0) As Boolean
        Try
            Dim I As Integer
            For I = 0 To TAB.Tabs.Count - 1
                If I = Tab_Mostrar Then
                    TAB.Tabs(I).Enabled = True
                    TAB.Tabs(I).Selected = True
                ElseIf I = Tab_Adicional Then
                    TAB.Tabs(I).Enabled = True
                Else
                    TAB.Tabs(I).Enabled = False
                End If
            Next

            If Tab_Adicional <> 0 Then
                For I = 0 To TAB.Tabs.Count - 1
                    If I = Tab_Adicional Then
                        TAB.Tabs(I).Enabled = True
                    End If
                Next
            End If
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Sub SeleccionTabs(Tab_Mostrar As Integer, TAB As UltraWinTabControl.UltraTabControl, Optional Enable As Boolean = True)
        Dim I As Integer
        For I = 0 To TAB.Tabs.Count - 1
            If I = Tab_Mostrar Then
                TAB.Tabs(I).Enabled = True
                TAB.Tabs(I).Selected = True
            Else
                If Enable Then
                    TAB.Tabs(I).Enabled = False
                Else
                    TAB.Tabs(I).Enabled = True
                End If
            End If
        Next
    End Sub

    Public Function LimpiaGrid(ByVal Grid As UltraGrid, ByVal Data As UltraDataSource)
        Data.Rows.Clear()
        Grid.DataSource = Data
        Return True
    End Function

    Public Sub LimpiaCombos(ByVal cboCombo As ISL.Controles.Combo)
        If cboCombo.Items.Count > 0 Then
            cboCombo.DataSource = Nothing
            cboCombo.Text = Nothing
        End If
    End Sub

    ''' <summary>
    ''' Obtener el periodo específico a partir del año 
    ''' </summary>
    ''' <param name="año">año del periodo que se desea obtener</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerPeriodoActivo(año As String) As List(Of e_Periodo)
        Dim oePeriodo As New e_Periodo
        olPeriodo = New l_Periodo
        Dim lePeriodo As New List(Of e_Periodo)
        oePeriodo.Ejercicio = año
        oePeriodo.Activo = True
        lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))
        Return lePeriodo
    End Function

    ''' <summary>
    ''' Obtener el periodo por fecha 
    ''' </summary>
    ''' <param name="fecha">fecha del periodo que se desea obtener</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerPeriodo(fecha As Date) As e_Periodo
        Dim oePeriodo As New e_Periodo
        olPeriodo = New l_Periodo
        oePeriodo.Ejercicio = fecha.Year
        oePeriodo.Mes = fecha.Month
        oePeriodo.Activo = True
        Return olPeriodo.Obtener(oePeriodo)
    End Function

    Public Function ObtenerCuentaPrestamoPeriodo(IdPrestamo As String, Anio As Integer) As List(Of e_CuentaContable)
        Dim oeCuentaContable As New e_CuentaContable
        Dim olCuentaContable = New l_CuentaContable
        Dim leCuentaContable As New List(Of e_CuentaContable)
        oeCuentaContable.TipoOperacion = "P"
        oeCuentaContable.Cuenta = IdPrestamo
        oeCuentaContable.Ejercicio = Anio
        oeCuentaContable.Activo = True
        leCuentaContable.AddRange(olCuentaContable.Listar(oeCuentaContable))
        Return leCuentaContable
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="cboMes"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function LlenaComboMes(ByVal cboMes As ISL.Controles.Combo, lePeriodo As List(Of e_Periodo))
        With cboMes
            .DisplayMember = "Mes"
            .ValueMember = "Id"
            .DataSource = lePeriodo
            If .Items.Count > 0 Then
                .Text = Date.Now.Month
            End If
        End With
        Return cboMes
    End Function

    Public Function LlenarCombo(ByVal Combo As ISL.Controles.Combo,
                                        ByVal Texto As String, ByVal DataSource As Object, ByVal SelectedIndex As Integer)
        Combo.DataSource = DataSource
        Combo.DisplayMember = Texto
        Combo.SelectedIndex = SelectedIndex
        Return True
    End Function

    Public Function LlenarCombo(ByVal Combo As Infragistics.Win.UltraWinEditors.UltraComboEditor,
                                     ByVal Texto As String, ByVal DataSource As Object, ByVal SelectedIndex As Integer)
        Combo.DataSource = DataSource
        Combo.DisplayMember = Texto
        Combo.SelectedIndex = SelectedIndex
        Return True
    End Function

    Public Function ComboNormal(ByVal Combo As Infragistics.Win.UltraWinEditors.UltraComboEditor,
                                  ByVal DataSource As Object, ByVal SelectedIndex As Integer)
        Combo.DataSource = DataSource
        Combo.DisplayMember = "NOMBRE"
        Combo.ValueMember = "ID"
        Combo.SelectedIndex = SelectedIndex
        Return True
    End Function

    Public Function LlenarComboMaestro(ByVal Combo As Infragistics.Win.UltraWinGrid.UltraCombo,
                                   ByVal DataSource As Object, ByVal SelectedIndex As Integer)
        Combo.DataSource = Nothing
        Combo.DataSource = DataSource
        Return True
    End Function

    Public Function LlenarComboMaestro(ByVal Combo As ISL.Controles.ComboMaestros,
                                   ByVal DataSource As Object, ByVal SelectedIndex As Integer)
        Combo.DataSource = DataSource
        Combo.SelectedIndex = SelectedIndex
        Return True
    End Function

    Public Function LlenarComboMaestro(ByVal Combo As Infragistics.Win.UltraWinEditors.UltraComboEditor,
                                  ByVal DataSource As Object, ByVal SelectedIndex As Integer)
        Try
            Combo.DataSource = DataSource
            Combo.SelectedIndex = SelectedIndex
        Catch ex As Exception
            Throw ex
        End Try

        Return True
    End Function

    ''' <summary>
    ''' Función que permite Importar archivos desde Microsoft Excel
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Importar_Excel() As DataTable
        Dim stRuta As String = ""
        Dim Ds As New DataSet
        Dim Da As New OleDbDataAdapter
        Dim Dt As New DataTable
        Try
            Dim openFD As New OpenFileDialog()

            openFD.Title = "Importar Excel"
            openFD.Filter = "Archivos Excel(*.xls;*.xlsx)|*.xls;*.xlsx|Todos los archivos (*.*)|*.*"
            openFD.Multiselect = False
            openFD.InitialDirectory = DirectorioPorDefecto()
            If openFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                stRuta = openFD.FileName
            End If

            Dim stConexion As String = ("Provider=Microsoft.ACE.OLEDB.12.0;" & ("Data Source=" & (stRuta & ";Extended Properties=""Excel 12.0 Xml;HDR=YES;IMEX=2"";")))
            Dim cnConex As New OleDbConnection(stConexion)
            cnConex.Open()
            Dt = cnConex.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)

            If Dt.Rows.Count <= 0 Then
                Throw New Exception("El excel ingresado no contiene ninguna hoja, por favor, verificar para continuar con la operación")
                Return Nothing
            End If

            Dim Cmd As New OleDbCommand("Select * from [" & Dt.Rows(0)("TABLE_NAME").ToString & "]")
            Cmd.Connection = cnConex

            Da.SelectCommand = Cmd
            Da.Fill(Ds)
            cnConex.Close()

        Catch ex As Exception
            Throw ex
        End Try
        Return Ds.Tables(0)
    End Function

    Public Sub Exportar_Excel(ByVal Grilla As UltraWinGrid.UltraGrid)
        Try
            ExportarGrillaAExcel(Grilla)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Exportar_Excel(ByVal GrillaISL As ISL.Controles.Grilla, Optional NombreArchivo As String = "")
        Try
            Dim grilla As New UltraWinGrid.UltraGrid
            grilla = GrillaISL
            ExportarGrillaAExcel(grilla, NombreArchivo)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ExportarGrillaAExcel(ByVal Grilla As UltraWinGrid.UltraGrid, Optional NombreArchivo As String = "")
        Try
            If Grilla.Rows.Count > 0 Then
                Dim uge_Exportar As New UltraGridExcelExporter
                Dim sfd_Dialogo As New System.Windows.Forms.SaveFileDialog
                sfd_Dialogo.Filter = "Libros de Excel (*.xlsx)|*.xlsx|Todos Los Archivos (*.*)|*.*"
                sfd_Dialogo.DefaultExt = "xlsx"
                sfd_Dialogo.FilterIndex = 1
                sfd_Dialogo.Title = "Exportar a ..."
                If NombreArchivo.Trim <> "" Then
                    sfd_Dialogo.FileName = NombreArchivo
                Else
                    sfd_Dialogo.FileName = "Libro"
                End If
                Dim result As DialogResult = sfd_Dialogo.ShowDialog()
                If result = DialogResult.Cancel Then Return
                Dim stNombreArchivo As String = sfd_Dialogo.FileName
                uge_Exportar.Export(Grilla, stNombreArchivo)
                If MessageBox.Show("Se ha exportado satisfactoriamente el archivo, desea poder visualizarlo?",
                "ERP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Process.Start(stNombreArchivo)
                End If
            Else
                Throw New Exception("No hay informacion para exportar al Excel")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub TotalRegistroGrilla(ByVal Grilla As UltraWinGrid.UltraGrid)
        Try
            '----- TOTAL Registros -----'
            Dim Items As SummarySettings = Grilla.DisplayLayout.Bands(0).Summaries.Add("TotalRegistros", SummaryType.Count, Grilla.DisplayLayout.Bands(0).Columns("Numero"))
            With Items
                .DisplayFormat = "Cantidad Registros: {0:#,###,##0}"
                .Appearance.TextHAlign = HAlign.Right
                .Appearance.TextVAlign = VAlign.Middle
                .Band.Override.SummaryDisplayArea = SummaryDisplayAreas.Top
                .Band.Override.SummaryFooterCaptionVisible = DefaultableBoolean.False
                .Band.Override.BorderStyleSummaryFooter = UIElementBorderStyle.Solid
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarProveedores(ByVal combo As Infragistics.Win.UltraWinGrid.UltraCombo, Optional ByVal IdProveedor As String = "0", Optional ByVal chkRuc As Boolean = 0)
        Try
            Cursor.Current = Cursors.WaitCursor
            oeProveedor = New e_Proveedor
            olProveedor = New l_Proveedor
            combo.DataSource = Nothing
            If chkRuc Then oeProveedor._chkRuc = 1
            If Not String.IsNullOrEmpty(combo.Text.Trim) And IdProveedor = "0" Then
                oeProveedor.Nombre = combo.Text.Trim
                combo.DataSource = olProveedor.Listar(oeProveedor)
            ElseIf IdProveedor <> "0" Then
                oeProveedor.Id = IdProveedor
                combo.DataSource = olProveedor.Listar(oeProveedor)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarClienteProveedor(ByVal combo As Infragistics.Win.UltraWinGrid.UltraCombo, IdProveedor As String)
        Try
            Cursor.Current = Cursors.WaitCursor
            Dim oeClienteProveedor As New e_ClienteProveedor
            Dim olClienteProveedor = New l_ClienteProveedor
            combo.DataSource = Nothing
            oeClienteProveedor.Id = IdProveedor
            oeClienteProveedor.Cliente = -1
            oeClienteProveedor.Proveedor = -1
            oeClienteProveedor.Comisionista = -1
            combo.DataSource = olClienteProveedor.Listar(oeClienteProveedor)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Valida si la fecha esta dentro del periodo
    ''' </summary>
    ''' <param name="IdPeriodo">Id del periodo en el que se evalua</param>
    ''' <param name="_Fecha">fecha que se evalua</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ValidarPeriodoyFecha(ByVal IdPeriodo As String, ByVal _Fecha As Date) As Boolean
        Dim oePeriodo As New e_Periodo
        Dim lePeriodo As New List(Of e_Periodo)
        Dim olPeriodo As New l_Periodo
        oePeriodo.Activo = True
        oePeriodo.Id = IdPeriodo
        lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))
        If lePeriodo.Count > 0 Then
            If Not (_Fecha.Date >= lePeriodo(0).FechaInicio.Date And _Fecha.Date <= lePeriodo(0).FechaFin.Date) Then Throw New Exception("La fecha no pertenece al periodo")
        Else
            Throw New Exception("No existe Periodo")
        End If
    End Function

    Public Function ValidarPeridoContable(ByVal IdPeriodo As String, ByVal Modulo As gAreasSGI) As Boolean
        Try
            Return l_FuncionesGenerales.ValidarPeriodo(IdPeriodo, Modulo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarFechaInicioFin(ByVal FechaInicio As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor,
                                ByVal FechaFin As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor) As Boolean
        Try
            If FechaFin.Value < FechaInicio.Value Then
                FechaFin.Value = Date.Today
                Throw New Exception("Fecha de Fin no puede ser menor que Fecha de Inicio")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarFechaInicioFin(ByVal FechaInicio As System.Windows.Forms.DateTimePicker,
                                ByVal FechaFin As System.Windows.Forms.DateTimePicker) As Boolean
        Try
            If FechaFin.Value < FechaInicio.Value Then
                FechaFin.Value = Date.Today
                Throw New Exception("Fecha de Fin no puede ser menor que Fecha de Inicio")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarFechaDesdeHasta(ByVal Fecha As ISL.Controles.RangoFechas) As Boolean
        Try
            If Fecha.Hasta < Fecha.Desde Then
                Fecha.Hasta = Date.Today
                Throw New Exception("Fecha de Fin no puede ser menor que Fecha de Inicio")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarFechaDesdeHasta(ByVal Fecha As ISL.Controles.RangoFechas2) As Boolean
        Try
            If Fecha.Hasta < Fecha.Desde Then
                Fecha.Hasta = Date.Today
                Throw New Exception("Fecha de Fin no puede ser menor que Fecha de Inicio")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarFechaDesde_Hasta(ByVal f_Desde As DateTimePicker, ByVal f_Hasta As DateTimePicker) As Boolean
        Try
            If f_Hasta.Value.Date < f_Desde.Value.Date Then
                f_Desde.Focus()
                Throw New Exception("Fecha de Fin no puede ser menor que Fecha de Inicio")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarCombo(ByVal Combo As Infragistics.Win.UltraWinEditors.UltraComboEditor,
                                        ByVal Etiqueta As String) As Boolean
        Try
            If Combo.Text = "" Then
                Combo.Focus()
                Throw New Exception("Seleccione " + Etiqueta)
            End If

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarTexto(ByVal Texto As Infragistics.Win.UltraWinEditors.UltraTextEditor, ByVal Etiqueta As String) As Boolean
        Try
            If Texto.Text = String.Empty Then Texto.Focus() : Throw New Exception("Seleccione " + Etiqueta)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarComboValue(Combo As Infragistics.Win.UltraWinEditors.UltraComboEditor, Etiqueta As String) As Boolean
        Try
            If Combo.Value = "" Then
                Combo.Focus()
                Throw New Exception("Seleccione " + Etiqueta)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarCombo(Combo As Infragistics.Win.UltraWinGrid.UltraCombo, Etiqueta As String) As Boolean
        Try
            If Combo.Text = "" Then Throw New Exception("Seleccione " + Etiqueta)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarComboValue(ByVal Combo As Infragistics.Win.UltraWinGrid.UltraCombo,
                                    ByVal Etiqueta As String) As Boolean
        Try
            If Combo.Value = "" Then Throw New Exception("Seleccione " + Etiqueta)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarGrilla(ByVal Grilla As Infragistics.Win.UltraWinGrid.UltraGrid,
                                    ByVal Etiqueta As String) As Boolean
        Try
            If Grilla.Rows.Count < 1 Then Throw New Exception("Ingrese " + Etiqueta)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarOpciones(ByVal opciones As ISL.Controles.Opciones,
                                   ByVal Etiqueta As String) As Boolean
        Try
            l_FuncionesGenerales.ValidarCampoNoNulo(opciones.Value, "Ingrese " + Etiqueta)
            Return True
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ValidarEjercicio(ByVal Grid As ISL.Controles.Grilla, ByVal Anio As ISL.Win.Año) As Boolean
        Try
            If Grid.Rows.Count > 0 Then
                For i = 0 To Grid.Rows.Count - 1
                    If Anio.Año = Grid.Rows(i).Cells("Ejercicio").Value Then
                        Return False
                    End If
                Next
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub CargarMenu(ByVal leMenuProceso As List(Of e_MenuProceso))
        Try
            Dim _porcen As Double = 80 / leMenuProceso.Count
            Dim _acumulado As Double = 5
            If leMenuProceso.Count > 0 Then
                For Each menuProceso As e_MenuProceso In leMenuProceso
                    Dim FichaISL As RibbonTab = New RibbonTab("rb" & menuProceso.Codigo)
                    FichaISL.Caption = menuProceso.Abreviatura
                    FichaISL.Visible = menuProceso.Activo
                    frm_Menu.utm_ISLSGI.Ribbon.Tabs.Add(FichaISL)
                    'If menuProceso.Explorador Then
                    '    Dim GrupoExplorerISL As UltraWinExplorerBar.UltraExplorerBarGroup = New UltraWinExplorerBar.UltraExplorerBarGroup
                    '    GrupoExplorerISL.Key = "eb" & menuProceso.Codigo
                    '    GrupoExplorerISL.Text = menuProceso.Abreviatura
                    '    GrupoExplorerISL.Visible = menuProceso.Activo
                    '    frm_Menu.MenuISL.Groups.Add(GrupoExplorerISL)
                    'End If
                    frm_Bienvenida.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    frm_Bienvenida.Label1.Text = VersionDelSistema() & " - Cargando: Módulo de " & menuProceso.Abreviatura
                    _acumulado = _acumulado + _porcen
                    frm_Bienvenida.UltraProgressBar1.Value = _acumulado
                    frm_Bienvenida.Refresh()
                    If menuProceso.leMenuGrupo.Count > 0 Then
                        For Each menuGrupo As e_MenuGrupo In menuProceso.leMenuGrupo
                            Dim GrupoISL As RibbonGroup = New RibbonGroup("rbg" & menuGrupo.Codigo)
                            GrupoISL.Caption = menuGrupo.Abreviatura
                            If menuGrupo.leMenuActividad.Count > 0 Then
                                For Each menuActividad As e_MenuActividad In menuGrupo.leMenuActividad
                                    Dim AparienciaISL As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
                                    If menuActividad.Menu Then
                                        Dim SubMenuISL As PopupMenuTool = New PopupMenuTool("mnu" & menuActividad.Codigo)
                                        SubMenuISL.SharedProps.Caption = menuActividad.Abreviatura
                                        SubMenuISL.SharedPropsInternal.ToolTipText = menuActividad.Nombre
                                        SubMenuISL.SharedPropsInternal.ToolTipTitle = "Mensaje de Sistema"
                                        'If System.Environment.OSVersion.Version.Major >= 6 Then
                                        If gImagen Then
                                            If menuActividad.Tamano Then SubMenuISL.InstanceProps.PreferredSizeOnRibbon = RibbonToolSize.Large
                                            If Not menuActividad.Texto Then SubMenuISL.InstanceProps.PreferredSizeOnRibbon = RibbonToolSize.ImageOnly
                                            If menuActividad.Imagen <> "" Then
                                                AparienciaISL.Image = GeneraImagen(menuActividad.Imagen)
                                                SubMenuISL.SharedPropsInternal.AppearancesSmall.Appearance = AparienciaISL
                                            End If
                                        End If
                                        frm_Menu.utm_ISLSGI.Tools.Add(SubMenuISL)
                                        If menuActividad.leSubMenu.Count > 0 Then
                                            For Each oeSubMenu As e_MenuActividad In menuActividad.leSubMenu
                                                Dim iBoton As ButtonTool = New ButtonTool("mnu" & oeSubMenu.Codigo)
                                                iBoton.SharedProps.Caption = oeSubMenu.Abreviatura
                                                iBoton.SharedProps.Tag = "ISL.Win." & oeSubMenu.Form
                                                'nuevo ------------------'agregado
                                                iBoton.SharedProps.StatusText = oeSubMenu.IdActividadNegocio
                                                iBoton.SharedProps.CustomizerCaption = oeSubMenu.IdProcesoNegocio
                                                iBoton.SharedProps.Category = oeSubMenu.MultiInstancia
                                                ' -----------------------
                                                iBoton.SharedPropsInternal.ToolTipText = oeSubMenu.Nombre
                                                iBoton.SharedPropsInternal.ToolTipTitle = "Mensaje de Sistema"
                                                'If System.Environment.OSVersion.Version.Major >= 6 Then
                                                If gImagen AndAlso oeSubMenu.Imagen <> "" Then

                                                    AparienciaISL = New Infragistics.Win.Appearance
                                                    AparienciaISL.Image = GeneraImagen(oeSubMenu.Imagen)
                                                    iBoton.SharedPropsInternal.AppearancesSmall.Appearance = AparienciaISL
                                                End If
                                                'End If
                                                frm_Menu.utm_ISLSGI.Tools.Add(iBoton)
                                                Dim var As String = iBoton.Key
                                                SubMenuISL.Tools.AddTool(var)
                                                'If oeSubMenu.Explorer Then
                                                '    Dim ItemExplorerISL As UltraWinExplorerBar.UltraExplorerBarItem = New UltraWinExplorerBar.UltraExplorerBarItem
                                                '    ItemExplorerISL.Key = "ebi" & oeSubMenu.Codigo
                                                '    ItemExplorerISL.Text = oeSubMenu.Abreviatura
                                                '    ItemExplorerISL.Tag = "ISL.Win." & oeSubMenu.Form
                                                '    ItemExplorerISL.ToolTipText = oeSubMenu.Nombre
                                                '    ' If System.Environment.OSVersion.Version.Major >= 6 Then
                                                '    If gImagen Then ItemExplorerISL.Settings.AppearancesSmall.Appearance = AparienciaISL
                                                '    'End If
                                                '    'nuevo ------------------
                                                '    ItemExplorerISL.Settings.AppearancesLarge.Tag = oeSubMenu.IdActividadNegocio
                                                '    ItemExplorerISL.Settings.AppearancesSmall.Tag = oeSubMenu.MultiInstancia
                                                '    '-----------------------
                                                '    frm_Menu.MenuISL.Groups("eb" & menuProceso.Codigo).Items.Add(ItemExplorerISL)
                                                'End If
                                                ' SubMenuISL.Tools.AddRange(New ToolBase() {iBoton})
                                            Next
                                        End If
                                        GrupoISL.Tools.AddRange(New PopupToolBase() {SubMenuISL})
                                    Else
                                        Dim BotonISL As ButtonTool = New ButtonTool("mnu" & menuActividad.Codigo)
                                        BotonISL.SharedProps.Caption = menuActividad.Abreviatura
                                        BotonISL.SharedProps.Tag = "ISL.Win." & menuActividad.Form
                                        'nuevo----------------
                                        BotonISL.SharedProps.StatusText = menuActividad.IdActividadNegocio
                                        BotonISL.SharedProps.CustomizerCaption = menuActividad.IdProcesoNegocio
                                        BotonISL.SharedProps.Category = menuActividad.MultiInstancia
                                        '-------------------------------
                                        BotonISL.SharedPropsInternal.ToolTipText = menuActividad.Nombre
                                        BotonISL.SharedPropsInternal.ToolTipTitle = "Mensaje de Sistema"
                                        'If System.Environment.OSVersion.Version.Major >= 6 Then
                                        If gImagen Then
                                            If menuActividad.Tamano Then BotonISL.InstanceProps.PreferredSizeOnRibbon = RibbonToolSize.Large
                                            If Not menuActividad.Texto Then BotonISL.InstanceProps.PreferredSizeOnRibbon = RibbonToolSize.ImageOnly
                                            If menuActividad.Imagen <> "" Then
                                                AparienciaISL.Image = GeneraImagen(menuActividad.Imagen)
                                                BotonISL.SharedPropsInternal.AppearancesSmall.Appearance = AparienciaISL
                                            End If
                                        End If
                                        'End If
                                        GrupoISL.Tools.AddRange(New ToolBase() {BotonISL})
                                        'If menuActividad.Explorer Then
                                        '    Dim ItemExplorerISL As UltraWinExplorerBar.UltraExplorerBarItem = New UltraWinExplorerBar.UltraExplorerBarItem
                                        '    ItemExplorerISL.Key = "ebi" & menuActividad.Codigo
                                        '    ItemExplorerISL.Text = menuActividad.Abreviatura
                                        '    ItemExplorerISL.Tag = "ISL.Win." & menuActividad.Form
                                        '    ItemExplorerISL.ToolTipText = menuActividad.Nombre
                                        '    ' If System.Environment.OSVersion.Version.Major >= 6 Then
                                        '    If gImagen Then ItemExplorerISL.Settings.AppearancesSmall.Appearance = AparienciaISL
                                        '    'End If
                                        '    'nuevo -------------------
                                        '    ItemExplorerISL.Settings.AppearancesLarge.Tag = menuActividad.IdActividadNegocio
                                        '    ItemExplorerISL.Settings.AppearancesSmall.Tag = menuActividad.MultiInstancia
                                        '    '----------------------------
                                        '    frm_Menu.MenuISL.Groups("eb" & menuProceso.Codigo).Items.Add(ItemExplorerISL)
                                        'End If
                                    End If
                                Next
                            End If
                            FichaISL.Groups.AddRange(New Infragistics.Win.UltraWinToolbars.RibbonGroup() {GrupoISL})
                        Next
                    End If
                Next
                ' frm_Menu.utm_ISLSGI.SetContextMenuUltra(Form1_Fill_Pane1, "PopUpMenuTool1")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function PerfilAsignado(nombrePerfil As String) As Boolean
        Try
            Dim resultado As Boolean = False
            For Each perfil As e_UsuarioPerfil In gUsuarioSGI.leUsuarioPerfil
                If perfil.oePerfil.Nombre.Equals(nombrePerfil) Then
                    resultado = True
                    Exit For
                End If
            Next
            Return resultado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function PerfilIdAsignado(IdPerfil As String) As Boolean
        Try
            Dim resultado As Boolean = False
            For Each perfil As e_UsuarioPerfil In gUsuarioSGI.leUsuarioPerfil
                If perfil.oePerfil.Id.Equals(IdPerfil) Then
                    resultado = True
                    Exit For
                End If
            Next
            Return resultado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Función que retorna información de un perfil específico asignado al usuario autenticado 
    ''' </summary>
    ''' <param name="nombrePerfil">Nombre del perfil que necesita saberse si está asignado al usuario</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerPerfilAsignado(nombrePerfil As String) As e_Perfil
        Try
            Dim p As New e_Perfil
            For Each perfil As e_UsuarioPerfil In gUsuarioSGI.leUsuarioPerfil
                If perfil.oePerfil.Nombre.Equals(nombrePerfil) Then
                    p = perfil.oePerfil
                    Exit For
                End If
            Next
            Return p
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Función que retorna información del perfil principal asignado al usuario autenticado 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerPerfilPrincipal() As e_Perfil
        Try
            Dim p As New e_Perfil
            For Each perfil As e_UsuarioPerfil In gUsuarioSGI.leUsuarioPerfil
                If perfil.Principal Then
                    p = perfil.oePerfil
                    Exit For
                End If
            Next
            Return p
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub CargarConfiguracion()
        Try
            Dim olDetalleEntorno As New l_DetalleEntornoTrabajo
            Dim oeDetalleEntorno As New e_DetalleEntornoTrabajo

            oeDetalleEntorno.IdUsuario = gUsuarioSGI.Id
            Dim leDetalleEntorno As List(Of e_DetalleEntornoTrabajo) = olDetalleEntorno.Listar(oeDetalleEntorno)
            If leDetalleEntorno.Count > 0 Then
                For Each oe As e_DetalleEntornoTrabajo In leDetalleEntorno
                    If oe.Activo Then
                        Select Case oe.EntronoTrabajo
                            Case "001"
                                frm_Menu.utm_ISLSGI.Ribbon.IsMinimized = False
                            Case "002"
                                frm_Menu.UltraDockManager1.DockAreas(0).DockAreaPane.Panes(0).Pin()
                            Case "003"
                                PararTiempo = True
                            Case "004"
                                If System.Environment.OSVersion.Version.Major >= 6 Then
                                    MuestraImagenUsuario()
                                    frm_Menu.utm_ISLSGI.Tools("iconconectado").SharedProps.Visible = True
                                    frm_Menu.utm_ISLSGI.Tools("iconusuario").SharedProps.Visible = True
                                End If
                            Case "005"
                                frm_Menu.BackgroundImage = Nothing
                                gImagen = False
                        End Select
                    End If
                Next
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ActualizarMenuActividad(ByVal oeMenuActividad As e_MenuActividad)
        Try

            frm_Menu.utm_ISLSGI.Tools("mnu" & oeMenuActividad.Codigo).SharedProps.Caption = oeMenuActividad.Abreviatura
            frm_Menu.utm_ISLSGI.Tools("mnu" & oeMenuActividad.Codigo).SharedProps.Tag = "ISL.Win." & oeMenuActividad.Form
            frm_Menu.utm_ISLSGI.Tools("mnu" & oeMenuActividad.Codigo).SharedPropsInternal.ToolTipText = oeMenuActividad.Nombre

            If oeMenuActividad.Imagen <> "" Then
                Dim AparienciaISL As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
                AparienciaISL.Image = GeneraImagen(oeMenuActividad.Imagen)
                frm_Menu.utm_ISLSGI.Tools("mnu" & oeMenuActividad.Codigo).SharedPropsInternal.AppearancesSmall.Appearance = AparienciaISL
            End If

            frm_Menu.utm_ISLSGI.Tools("mnu" & oeMenuActividad.Codigo).SharedPropsInternal.Visible = oeMenuActividad.Activo

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub MuestraImagenUsuario()
        Dim olPersona As New l_Persona
        'frm_Menu.utm_ISLSGI.Tools("iconusuario").SharedProps.AppearancesSmall.Appearance.Image = olPersona.Foto(gUsuarioSGI.oePersona.Dni)
        frm_Menu.utm_ISLSGI.Tools("iconusuario").SharedProps.ToolTipText = gUsuarioSGI.oePersona.NombreCompleto
        frm_Menu.utm_ISLSGI.Tools("sbNombreUsuario").SharedProps.Visible = False
    End Sub

    Public Function SoloNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoloNumeros = 0
        Else
            SoloNumeros = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumeros = Keyascii
            Case 13
                SoloNumeros = Keyascii
        End Select
    End Function

    ''' <summary>
    ''' Retorna la fecha del primer día del año
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function PrimerDiaAño() As String
        Return "01/01/" & Date.Now.Year
    End Function

    ''' <summary>
    ''' Retorna la fecha del primer día del mes actual
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function PrimerDiaMes() As Date
        Return DateAdd(DateInterval.Month, DateDiff(DateInterval.Month, Date.MinValue, Today()), Date.MinValue)
    End Function

    ''' <summary>
    ''' Retorna la fecha del primer día del mes especifico
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function PrimerDiaMes(ByVal Fecha As Date) As Date
        Return DateAdd(DateInterval.Month, DateDiff(DateInterval.Month, Date.MinValue, Fecha), Date.MinValue)
    End Function

    ''' <summary>
    ''' Retorna la fecha del ultimo día del mes especifico
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function UltimoDiaMes(ByVal Fecha As Date) As Date
        Return DateAdd(DateInterval.Month, DateDiff(DateInterval.Month, Date.MaxValue, Fecha), Date.MaxValue)
    End Function

    ''' <summary>
    ''' Retorna la fecha del primer día de la semana
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function PrimerDiaSemana() As String
        Return DateAdd(DateInterval.Day, 1 - DatePart(DateInterval.Weekday, Now(), vbMonday), Now()).ToShortDateString
    End Function

    ''' <summary>
    ''' Retorna la fecha del último día del año
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function UltimoDiaAño() As String
        Return DateAdd(DateInterval.Second, -3, DateAdd(DateInterval.Year, DateDiff(DateInterval.Year, Date.MinValue, Today()) + 1, Date.MinValue)).ToShortDateString
    End Function

    ''' <summary>
    ''' Retorna la fecha del último día del mes anterior
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function UltimoDiaMesAnterior() As String
        Return DateSerial(Year(Date.Now), Month(Date.Now), 0)
    End Function

    ''' <summary>
    ''' Retorna una fecha restada en días a partir de una fecha específica
    ''' </summary>
    ''' <param name="fecha">Fecha base desde donde se cuentan los días que se va a restar</param>
    ''' <param name="numeroDias">Número de días que se va a restar a la fecha especificada, por defecto 30 días</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function MesAnterior(ByVal fecha As Date, Optional ByVal numeroDias As Integer = 30) As Date
        Return fecha.AddDays(-numeroDias)
    End Function

    ''' <summary>
    ''' Retorna una fecha incrementada en días a partir de una fecha específica
    ''' </summary>
    ''' <param name="fecha">Fecha base desde donde se cuentan los días que se va a sumar</param>
    ''' <param name="numeroDias">Número de días que se va a incrementar a la fecha especificada, por defecto 30 días</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function MesProximo(ByVal fecha As Date, Optional ByVal numeroDias As Integer = 30) As Date
        Return fecha.Add(New TimeSpan(+numeroDias, 0, 0, 0))
    End Function


    ''' <summary>
    ''' Retorna mac del equipo
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function MacPCLocal() As String
        Dim Mac As String = ""
        Dim theNetworkInterfaces() As NetworkInformation.NetworkInterface = NetworkInformation.NetworkInterface.GetAllNetworkInterfaces
        For Each currentInterface As NetworkInformation.NetworkInterface In theNetworkInterfaces
            Dim obj As System.Net.NetworkInformation.IPInterfaceProperties
            obj = currentInterface.GetIPProperties
            For i As Integer = 0 To obj.UnicastAddresses.Count - 1
                If obj.UnicastAddresses(i).Address.ToString.Contains("10.2") And obj.UnicastAddresses(i).IsDnsEligible = True Then
                    Mac = currentInterface.GetPhysicalAddress().ToString
                    Return Mac
                End If
            Next
        Next
        Return Mac
    End Function

    Public Function RetornaArea(ByVal idTrabajador As String) As String
        Try
            Dim idArea As String = ""
            Dim oeTrabajador As New e_Trabajador
            Dim olTrabajador As New l_Trabajador
            oeTrabajador.Id = idTrabajador
            Return idArea = olTrabajador.Obtener(oeTrabajador).oeArea.Id
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    '-------------------------------------Envio de correo---------------------------------------------------------
    ''' <summary>
    ''' Función utilizada para enviar correos electrónicos
    ''' </summary>
    ''' <param name="ls_Remitente"></param>
    ''' <param name="ls_Lista_Para"></param>
    ''' <param name="ls_Lista_CC"></param>
    ''' <param name="ls_Lista_CCO"></param>
    ''' <param name="ls_Asunto"></param>
    ''' <param name="ls_Mensaje"></param>
    ''' <param name="ls_ListaArchivosAdjuntos"></param>
    ''' <param name="lb_MostrarMsjeConfirmacion"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function EnviarEmail(ByVal ls_Remitente As String, ByVal ls_Lista_Para As String _
        , ByVal ls_Lista_CC As String, ByVal ls_Lista_CCO As String _
        , ByVal ls_Asunto As String, ByVal ls_Mensaje As String, ByVal ls_ListaArchivosAdjuntos As String, Optional ByVal lb_MostrarMsjeConfirmacion As Boolean = True) As Boolean
        Dim lo_Message As New MailMessage
        Try
            Dim la_Para As Object() = Split(ls_Lista_Para, ";", -1)
            Dim la_CC As Object() = Split(ls_Lista_CC, ";", -1)
            Dim la_CCO As Object() = Split(ls_Lista_CCO, ";", -1)

            If la_Para.Length > 0 Or la_CC.Length > 0 Or la_CCO.Length > 0 Then
                Dim la_ArchivosAdjuntos As Object() = Split(ls_ListaArchivosAdjuntos, ";", -1)
                If ls_ListaArchivosAdjuntos <> "" Then
                    For i As Integer = 0 To la_ArchivosAdjuntos.Length - 1
                        Dim la_ArchivoDatos As Object() = Split(la_ArchivosAdjuntos(i), "@", -1)
                        Dim lo_Archivo As New FileStream(la_ArchivoDatos(0), FileMode.Open, FileAccess.Read)
                        Dim lo_Adjunto As New Attachment(lo_Archivo, la_ArchivoDatos(i).ToString)
                        lo_Message.Attachments.Add(lo_Adjunto)
                        lo_Archivo = Nothing
                    Next
                End If
                lo_Message.Subject = ls_Asunto
                lo_Message.Body = "<html><body>" & ls_Mensaje & "<html><body>"
                lo_Message.IsBodyHtml = True
                lo_Message.Priority = MailPriority.High
                lo_Message.From = New MailAddress(ls_Remitente)
                If ls_Lista_Para <> "" Then
                    For i As Integer = 0 To la_Para.Length - 1
                        If la_Para(i) <> "" Then
                            lo_Message.To.Add(New MailAddress(la_Para(i)))
                        End If

                    Next
                End If
                If ls_Lista_CC <> "" Then
                    For i As Integer = 0 To la_CC.Length - 1
                        If la_CC(i) <> "" Then
                            lo_Message.CC.Add(New MailAddress(la_CC(i)))
                        End If
                    Next
                End If
                If ls_Lista_CCO <> "" Then
                    For i As Integer = 0 To la_CCO.Length - 1
                        If la_CCO(i) <> "" Then
                            lo_Message.Bcc.Add(New MailAddress(la_CCO(i)))
                        End If

                    Next
                End If
                Dim client As New SmtpClient(gs_SmtpClientSis.Trim)
                'client.EnableSsl = False
                'client.Port = 587
                client.Credentials = New NetworkCredential(gs_userNameCorreo.Trim, gs_passwordCorreo.Trim)
                client.Send(lo_Message)
                client.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials
                lo_Message.Attachments.Clear()
                lo_Message = Nothing
                client = Nothing
                If lb_MostrarMsjeConfirmacion Then Return True
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message + " " + ex.Source + " " + ex.ToString)
        End Try
        lo_Message = Nothing
    End Function

    ''' <summary>
    ''' Procedimiento desarrollado para capturar la pantalla actual del ERP T&L en un archivo llamado 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CapturaPantalla(ByVal nombreArchivoDestino As String)
        Try
            Dim recuadro As Rectangle
            Dim pantalla As System.Drawing.Bitmap
            Dim grafico As Graphics
            recuadro = Screen.PrimaryScreen.Bounds
            pantalla = New System.Drawing.Bitmap(recuadro.Width, recuadro.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
            grafico = Graphics.FromImage(pantalla)
            grafico.CopyFromScreen(recuadro.X, recuadro.Y, 0, 0, recuadro.Size, CopyPixelOperation.SourceCopy)
            Dim pantallaCapturada As New PictureBox
            pantallaCapturada.Image = pantalla
            pantallaCapturada.Image.Save(nombreArchivoDestino, System.Drawing.Imaging.ImageFormat.Png)
            'pantallaCapturada.Image.Dispose()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Función utilizada para validar el ingreso correcto de emails
    ''' </summary>
    ''' <param name="ls_Email"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ValidarEmail(ByVal ls_Email As String) As Boolean
        Return Regex.IsMatch(ls_Email, "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function


    Public Function ValidarControlEmail(ByVal lo_control As Control, ByVal ls_Nombre As String, Optional ByVal lb_requerido As Boolean = True _
           , Optional ByVal ls_TipoDato As String = "texto") As String
        Dim ls_Msje As String = ""
        If lb_requerido Then
            If Not lo_control.Text.Length > 0 Then
                ls_Msje = ls_Msje & Environment.NewLine & " Ingrese " & ls_Nombre
            End If
        End If
        Select Case ls_TipoDato
            Case "lista_email" 'separados por ,
                Dim ls_Cad As String = ""
                Dim la_ListaEmail As String() = lo_control.Text.Split(",")
                For i As Integer = 0 To la_ListaEmail.Length - 1
                    If Not ValidarEmail(la_ListaEmail(i)) Then
                        ls_Cad = ls_Cad & " " & la_ListaEmail(i)
                    End If
                Next
                If ls_Cad <> "" Then
                    ls_Msje = ls_Msje & Environment.NewLine & " Ingrese correctamente " & ls_Nombre & "[" & ls_Cad & "]"
                End If
        End Select
        Return ls_Msje
    End Function

    ''' <summary>
    ''' Formatea un dato para que se muestre con una determinada cantidad de decimales
    ''' </summary>
    ''' <param name="nroDecimales">Número de decimales que se visualizará</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function FormateaDecimales(Optional ByVal nroDecimales As Integer = 3) As String

        Dim mascara As String = "#,##0.000"
        Select Case nroDecimales
            Case 0
                mascara = "#,##0"
            Case 1
                mascara = "#,##0.0"
            Case 2
                mascara = "#,##0.00"
            Case 3
                mascara = "#,##0.000"
            Case 4
                mascara = "#,##0.0000"
            Case 5
                mascara = "#,##0.00000"
            Case 6
                mascara = "#,##0.000000"
            Case Else
                mascara = "#,##0.000"
        End Select

        Return mascara

    End Function

    ''' <summary>
    ''' Función que retorna la ruta de la Web de Ayuda del Sistema
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SiteAyudaSGI() As String
        Dim servidor As New l_Disponibilidad
        Return "http://" & servidor.IPServidor & ":81/"
    End Function

    ''' <summary>
    ''' Genera una imagen desde un archivo específico
    ''' </summary>
    ''' <param name="archivo">Nombre del archivo y extensión</param>
    ''' <param name="RutaPersonalizada">Indica si la ruta donde se encuentra el archivo es la ruta por defecto (//Imagenes) o no</param>
    ''' <param name="RutaImagen">Detalle de la ruta específica donde se ubica el archivo, en caso no se use la ruta por defecto</param>
    ''' <param name="archivoObligatorio">Indica si el archivo debe existir obligatoriamente para poderse mostrar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GeneraImagen(ByVal archivo As String, Optional ByVal RutaPersonalizada As Boolean = False, Optional ByVal RutaImagen As String = "", Optional ByVal archivoObligatorio As Boolean = False) As System.Drawing.Bitmap
        Try
            If RutaPersonalizada = False Then
                'Dim olDatosConfiguracion As New l_Configuracion '@0001
                'RutaImagen = olDatosConfiguracion.RutaImagen() '@0001
                RutaImagen = Path.Combine(Application.StartupPath, "Imagenes") '@0001
            End If
            archivo = RutaImagen & archivo
            If System.IO.File.Exists(archivo) Then
                Return System.Drawing.Bitmap.FromFile(archivo)
            Else
                If archivoObligatorio Then
                    Throw New Exception("La imagen: " & archivo & ", no existe; comuníquese con el área de sistemas para solucionar el problema")
                Else
                    Return Nothing
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Permite determinar si se trata de un material o servicio
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IndicadorMaterialServicio(ByVal valor As String) As Boolean
        Return IIf(valor = "M", True, False)
    End Function

    '--- --
    Public Sub ComboGrillaTipoDocumento(ByVal grilla As ISL.Controles.Grilla, ByVal ls_Proceso As String)
        'Para Columna de Tipo Documento
        leTipoDoc = New List(Of e_ProcesoTipoDocumento)
        oeProDoc = New e_ProcesoTipoDocumento
        olProDoc = New l_ProcesoTipoDocumento
        oeProDoc.TipoOperacion = 1
        oeProDoc.IdTipoDocumento = ""
        oeProDoc.IdProceso = ObtenerProceso(ls_Proceso)
        leTipoDoc = olProDoc.Listar(oeProDoc)
        grilla.DisplayLayout.ValueLists.Add("IdTipoDocumento")
        With grilla.DisplayLayout.ValueLists("IdTipoDocumento").ValueListItems
            .Clear()
            For Each oeTD As e_ProcesoTipoDocumento In leTipoDoc
                .Add(oeTD.IdTipoDocumento, oeTD.TipoDocumento)
            Next
        End With
        CrearComboGrid3("IdTipoDocumento", "TipoDocumento", grilla, True)
    End Sub

    Public Function ObtenerPrecioUnitario(idMaterial As String, idSubAlmacen As String) As Double
        Try
            Dim oeInv As New e_Inventario
            Dim olInv As New l_Inventario
            oeInv.TipoOperacion = "5"
            oeInv.IdMaterial = idMaterial
            oeInv.IdSubAlmacen = idSubAlmacen
            oeInv = olInv.Obtener(oeInv)
            Return CDbl(oeInv.ValorUnitario) * (1 + oeIGVGlobal.Porcentaje)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerProceso(ByVal lsNombreProceso As String) As String
        Try
            oeProceso = New e_ProcesoNegocio
            olProceso = New l_ProcesoNegocio
            oeProceso.Nombre = lsNombreProceso.Trim
            oeProceso = olProceso.Obtener(oeProceso)
            Return oeProceso.Id
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function TiempoSobrePasado(ByVal fecha As Date, Optional ByVal tipoTiempo As TipoTiempo = m_Funciones.TipoTiempo.Dias) As Integer
        Dim diff1 As System.TimeSpan = Date.Now.Date.Subtract(fecha.Date)
        Dim TiempoRetrazoSalida As Integer
        Select Case tipoTiempo
            Case m_Funciones.TipoTiempo.Años
                TiempoRetrazoSalida = (diff1.Days) / 365
            Case m_Funciones.TipoTiempo.Meses
                TiempoRetrazoSalida = (diff1.Days) / 30
            Case m_Funciones.TipoTiempo.Dias
                TiempoRetrazoSalida = diff1.Days
            Case m_Funciones.TipoTiempo.Horas
                TiempoRetrazoSalida = diff1.Hours
            Case m_Funciones.TipoTiempo.Minutos
                TiempoRetrazoSalida = diff1.Minutes
            Case m_Funciones.TipoTiempo.Segundos
                TiempoRetrazoSalida = diff1.Seconds
        End Select
        Return TiempoRetrazoSalida
    End Function

    ''' <summary>
    ''' Función que permite establecer el tiempo transcurrido en años, meses y días a partir del número de días
    ''' </summary>
    ''' <param name="TotalDias">Total de días transcurridos</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function TiempoEstimado(ByVal TotalDias As Integer) As String
        Dim tiempoEst As String = String.Empty
        Dim años As Integer
        Dim meses As Integer
        If TotalDias >= 365 Then
            años = TotalDias \ 365
            TotalDias = TotalDias Mod 365
            tiempoEst = años.ToString & " años "
        End If
        If TotalDias >= 30 Then
            meses = TotalDias \ 30
            TotalDias = TotalDias Mod 30
            tiempoEst = tiempoEst & meses.ToString & " meses " & TotalDias & " días"
        End If
        Return tiempoEst
    End Function

    Public Sub ListaUsuarios(ByVal Grid As Infragistics.Win.UltraWinGrid.UltraGrid, ByVal IdColumna As String)
        Try
            If leUsuarios.Count = 0 Then
                Dim lUsuarios As New l_Usuario
                Dim oeUsuarios As New e_Usuario
                oeUsuarios.Activo = 1
                oeUsuarios.Controlado = -1
                leUsuarios.AddRange(lUsuarios.Listar(oeUsuarios))
            End If
            '--------------------- para llenar combo en grilla    
            Grid.DisplayLayout.ValueLists.Add(IdColumna)
            With Grid.DisplayLayout.ValueLists(IdColumna).ValueListItems
                .Clear()
                For Each oeTD As e_Usuario In leUsuarios
                    .Add(oeTD.Id, oeTD.oePersona.NombreCompleto)
                Next
            End With
            CrearComboGrid3(IdColumna, "NombreCompleto", Grid, True)
            '------------------------------------------
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK)
        End Try
    End Sub

    Public Sub ListaDeVehiculo(ByVal Grid As Infragistics.Win.UltraWinGrid.UltraGrid, ByVal IdColumna As String)
        Try
            If leListaVehiculo.Count = 0 Then
                Dim oeVehiculo As New e_Vehiculo
                Dim olVehiculo As New l_Vehiculo
                'Dim leVehiculo As New List(Of e_Vehiculo)
                oeVehiculo.TipoOperacion = "D"
                oeVehiculo.Activo = True
                oeVehiculo.Motriz = 1
                leListaVehiculo.AddRange(olVehiculo.Listar(oeVehiculo))
            End If
            '--------------------- para llenar combo en grilla    
            Grid.DisplayLayout.ValueLists.Add(IdColumna)
            With Grid.DisplayLayout.ValueLists(IdColumna).ValueListItems
                .Clear()
                For Each oeTD As e_Vehiculo In leListaVehiculo
                    .Add(oeTD.Id, oeTD.Placa)
                Next
            End With
            CrearComboGrid3("IdVehiculo", "Placa", Grid, True)
            '------------------------------------------

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListaCuentasContable(ByVal Grid As Infragistics.Win.UltraWinGrid.UltraGrid, ByVal IdColumna As String,
                                    ByVal lnPeriodo As Integer, ByVal lsTipo As String)
        Try
            Dim olCuentaContable As New l_CuentaContable
            Dim oeCuentaContable As New e_CuentaContable
            If leCuentaContable.Count = 0 Then
                oeCuentaContable.Activo = 1
                oeCuentaContable.Ejercicio = lnPeriodo
                leCuentaContable.AddRange(olCuentaContable.Listar(oeCuentaContable))
            Else
                If leCuentaContable.Item(0).Ejercicio <> lnPeriodo Then
                    leCuentaContable.Clear()
                    oeCuentaContable.Activo = 1
                    oeCuentaContable.Ejercicio = lnPeriodo
                    leCuentaContable.AddRange(olCuentaContable.Listar(oeCuentaContable))
                End If
            End If
            '--------------------- para llenar combo en grilla    
            If Not Grid.DisplayLayout.ValueLists.Exists(IdColumna) Then
                Grid.DisplayLayout.ValueLists.Add(IdColumna)
            End If
            Dim Mostrar As String = ""
            With Grid.DisplayLayout.ValueLists(IdColumna).ValueListItems
                .Clear()
                For Each oeTD As e_CuentaContable In leCuentaContable
                    If lsTipo = "Cuenta" Then
                        .Add(oeTD.Id, oeTD.Cuenta)
                        Mostrar = "Cuenta"
                    Else
                        .Add(oeTD.Id, oeTD.Nombre)
                        Mostrar = "Nombre"
                    End If
                Next
            End With

            CrearComboGrid3(IdColumna, Mostrar, Grid, True)
            '------------------------------------------
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK)
        End Try
    End Sub

    ''' <summary>
    ''' Invoca el Directorio o Carpeta por defecto de los documentos
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DirectorioPorDefecto() As String
        Dim directorio As String
        Try
            directorio = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            Directory.SetCurrentDirectory(directorio)
        Catch ex As System.IO.DirectoryNotFoundException
            directorio = "C:\\"
        End Try
        Return directorio
    End Function

    Public Function CalculoInteres(ByVal FechaEmision As Date, ByVal FechaVenc As Date, ByVal DecTasaInteres As Double, ByVal Subtotal As Double) As Double
        Dim TemInt As Double = 0
        Dim Diferenciadias As Integer = DateDiff(DateInterval.Day, FechaEmision.Date, FechaVenc.Date)
        TemInt = (((1 + DecTasaInteres / 100) ^ (1 / 360)) - 1) * 100
        'etiTEM.Text = "TEM: " & Math.Round(TemInt, 7).ToString & " %"
        Return (-FV(TemInt / 100, Diferenciadias, Nothing, Subtotal) - Subtotal)
    End Function

    ''' <summary>
    ''' Función para convertir un número en letras
    ''' Se utiliza en el proceso de facturación para que la cantidad sea expresada en letras
    ''' </summary>
    ''' <param name="numero"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ConvertirNumeroALetras(ByVal numero As String) As String
        '********Declara variables de tipo cadena************
        Dim palabras As String = ""
        Dim entero As String = ""
        Dim dec As String = ""
        Dim flag As String = ""

        '********Declara variables de tipo entero***********
        Dim num, x, y As Integer

        flag = "N"

        '**********Número Negativo***********
        If Mid(numero, 1, 1) = "-" Then
            numero = Mid(numero, 2, numero.ToString.Length - 1).ToString
            palabras = "menos "
        End If

        '**********Si tiene ceros a la izquierda*************
        For x = 1 To numero.ToString.Length
            If Mid(numero, 1, 1) = "0" Then
                numero = Trim(Mid(numero, 2, numero.ToString.Length).ToString)
                If Trim(numero.ToString.Length) = 0 Then palabras = ""
            Else
                Exit For
            End If
        Next

        '*********Dividir parte entera y decimal************
        For y = 1 To Len(numero)
            If Mid(numero, y, 1) = "." Then
                flag = "S"
            Else
                If flag = "N" Then
                    entero = entero + Mid(numero, y, 1)
                Else
                    dec = dec + Mid(numero, y, 1)
                End If
            End If
        Next y

        If Len(dec) = 1 Then dec = dec & "0"

        '**********proceso de conversión***********
        flag = "N"

        If Val(numero) <= 999999999 Then
            For y = Len(entero) To 1 Step -1
                num = Len(entero) - (y - 1)
                Select Case y
                    Case 3, 6, 9
                        '**********Asigna las palabras para las centenas***********
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If Mid(entero, num + 1, 1) = "0" And Mid(entero, num + 2, 1) = "0" Then
                                    palabras = palabras & "cien "
                                Else
                                    palabras = palabras & "ciento "
                                End If
                            Case "2"
                                palabras = palabras & "doscientos "
                            Case "3"
                                palabras = palabras & "trescientos "
                            Case "4"
                                palabras = palabras & "cuatrocientos "
                            Case "5"
                                palabras = palabras & "quinientos "
                            Case "6"
                                palabras = palabras & "seiscientos "
                            Case "7"
                                palabras = palabras & "setecientos "
                            Case "8"
                                palabras = palabras & "ochocientos "
                            Case "9"
                                palabras = palabras & "novecientos "
                        End Select
                    Case 2, 5, 8
                        '*********Asigna las palabras para las decenas************
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    flag = "S"
                                    palabras = palabras & "diez "
                                End If
                                If Mid(entero, num + 1, 1) = "1" Then
                                    flag = "S"
                                    palabras = palabras & "once "
                                End If
                                If Mid(entero, num + 1, 1) = "2" Then
                                    flag = "S"
                                    palabras = palabras & "doce "
                                End If
                                If Mid(entero, num + 1, 1) = "3" Then
                                    flag = "S"
                                    palabras = palabras & "trece "
                                End If
                                If Mid(entero, num + 1, 1) = "4" Then
                                    flag = "S"
                                    palabras = palabras & "catorce "
                                End If
                                If Mid(entero, num + 1, 1) = "5" Then
                                    flag = "S"
                                    palabras = palabras & "quince "
                                End If
                                If Mid(entero, num + 1, 1) > "5" Then
                                    flag = "N"
                                    palabras = palabras & "dieci"
                                End If
                            Case "2"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "veinte "
                                    flag = "S"
                                Else
                                    palabras = palabras & "veinti"
                                    flag = "N"
                                End If
                            Case "3"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "treinta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "treinta y "
                                    flag = "N"
                                End If
                            Case "4"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "cuarenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "cuarenta y "
                                    flag = "N"
                                End If
                            Case "5"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "cincuenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "cincuenta y "
                                    flag = "N"
                                End If
                            Case "6"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "sesenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "sesenta y "
                                    flag = "N"
                                End If
                            Case "7"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "setenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "setenta y "
                                    flag = "N"
                                End If
                            Case "8"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "ochenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "ochenta y "
                                    flag = "N"
                                End If
                            Case "9"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "noventa "
                                    flag = "S"
                                Else
                                    palabras = palabras & "noventa y "
                                    flag = "N"
                                End If
                        End Select
                    Case 1, 4, 7
                        '*********Asigna las palabras para las unidades*********
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If flag = "N" Then
                                    If y = 1 Then
                                        palabras = palabras & "uno "
                                    Else
                                        palabras = palabras & "un "
                                    End If
                                End If
                            Case "2"
                                If flag = "N" Then palabras = palabras & "dos "
                            Case "3"
                                If flag = "N" Then palabras = palabras & "tres "
                            Case "4"
                                If flag = "N" Then palabras = palabras & "cuatro "
                            Case "5"
                                If flag = "N" Then palabras = palabras & "cinco "
                            Case "6"
                                If flag = "N" Then palabras = palabras & "seis "
                            Case "7"
                                If flag = "N" Then palabras = palabras & "siete "
                            Case "8"
                                If flag = "N" Then palabras = palabras & "ocho "
                            Case "9"
                                If flag = "N" Then palabras = palabras & "nueve "
                        End Select
                End Select

                '***********Asigna la palabra mil***************
                If y = 4 Then
                    If Mid(entero, 6, 1) <> "0" Or Mid(entero, 5, 1) <> "0" Or Mid(entero, 4, 1) <> "0" Or
                    (Mid(entero, 6, 1) = "0" And Mid(entero, 5, 1) = "0" And Mid(entero, 4, 1) = "0" And
                    Len(entero) <= 6) Then palabras = palabras & "mil "
                End If

                '**********Asigna la palabra millón*************
                If y = 7 Then
                    If Len(entero) = 7 And Mid(entero, 1, 1) = "1" Then
                        palabras = palabras & "millón "
                    Else
                        palabras = palabras & "millones "
                    End If
                End If
            Next y

            '**********Une la parte entera y la parte decimal*************
            If dec <> "" Then
                ConvertirNumeroALetras = palabras & "Con " & dec & "/100 "
            Else
                ConvertirNumeroALetras = palabras & "Con 00/100 "
            End If
        Else
            ConvertirNumeroALetras = ""
        End If
    End Function

    ''' <summary>
    ''' Valida que la configuración regional sea de Perú
    ''' para evitar problemas de signos de numeración y decimales
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ConfiguracionRegionalPeru() As Boolean
        Dim m_Mon As String, d_Mon As String
        Dim m_Num As String, d_Num As String
        m_Mon = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyGroupSeparator
        d_Mon = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator

        m_Num = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator
        d_Num = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator

        If (m_Num = "." Or d_Num = ",") Or (m_Mon = "." Or d_Mon = ",") Then
            MessageBox.Show("Advertencia : La configuración regional de su equipo respecto al formato numérico no es compatible con el sistema. " &
                            Environment.NewLine & Environment.NewLine _
                    & "CONFIGURACIÓN ACTUAL :" & Environment.NewLine &
                    "Separador de Miles -> " & m_Num & Environment.NewLine &
                    "Separador de Decimales-> " & d_Num & Environment.NewLine & Environment.NewLine _
                    & "CONFIGURACIÓN IDEAL:" & Environment.NewLine &
                    "Separador de Miles -> , " & Environment.NewLine &
                    "Separador de Decimales-> . " & Environment.NewLine _
                    & Environment.NewLine _
                    & "Por favor configure su equipo con la CONFIGURACION IDEAL o consulte con el administrador del sistema " & Environment.NewLine _
                    & Environment.NewLine _
                    & "Pasos para configurar mi equipo : " & Environment.NewLine _
                    & "Inicio -> Panel de Control -> Configuración Regional y de Idioma -> Español-Perú  " & Environment.NewLine _
                   , "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Return False
        Else
            Return True
        End If

    End Function

    ''' <summary>
    ''' Evalua que el valor ingresado sea número y contenga guiones
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function EvaluarValorIngresado(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean
        Try
            Dim estado As Boolean = False
            Dim x As Char = e.KeyChar
            If x >= "0" And x <= "9" Then 'numero
                e.Handled = False
            Else
                If x = Convert.ToChar(13) Then 'enter
                    e.Handled = True
                Else
                    If x = Convert.ToChar(8) Then 'backspace
                        e.Handled = False
                    Else
                        If sender.Text.Length = 0 And (x = "-") Then
                            e.Handled = True
                        Else
                            If BuscarGuion(sender.Text, x) = True And x = "-" Then 'punto
                                e.Handled = False
                            Else
                                e.Handled = True
                            End If
                        End If
                    End If
                End If
            End If
            Return e.Handled
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Busca guion en texto ingresado
    ''' </summary>
    ''' <param name="txtval"></param>
    ''' <param name="car"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function BuscarGuion(ByVal txtval As String, ByVal car As Char) As Boolean
        Dim b As Integer
        For b = 1 To txtval.Length
            If Convert.ToChar(Mid(txtval, b, 1)) = car Then
                Return False
            End If
        Next
        Return True
    End Function

    ''' <summary>
    ''' Función para calcular los importes totales de los documentos de compra y venta
    ''' </summary>
    ''' <param name="leactivo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CalcularImportesTotales(leactivo As List(Of e_DetalleDocumento), ByVal Tipo As Integer) As Double
        Try
            Dim SubTotal, Igv, Total As Double
            SubTotal = 0
            Igv = 0
            Total = 0
            If leactivo.Count > 0 Then
                For Each oeDetalleDoc As e_DetalleDocumento In leactivo
                    oeDetalleDoc.Total = Math.Round(oeDetalleDoc.Cantidad * oeDetalleDoc.Precio, 4)
                    oeDetalleDoc.Subtotal = Math.Round(oeDetalleDoc.Cantidad * oeDetalleDoc.Precio, 4)
                    oeDetalleDoc.Igv = oeDetalleDoc.Total - Math.Round(oeDetalleDoc.Cantidad * oeDetalleDoc.PrecioUnitarioSinImp, 4)
                    SubTotal = SubTotal + Math.Round(oeDetalleDoc.Cantidad * oeDetalleDoc.PrecioUnitarioSinImp, 4)
                    Total = Total + oeDetalleDoc.Total
                Next
                Igv = Total - SubTotal
            End If
            Select Case Tipo
                Case 0
                    Return SubTotal
                Case 1
                    Return Igv
                Case 2
                    Return Total
            End Select
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    ''' <summary>
    ''' Función que retorna la fecha del servidor 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerFechaServidor() As Date
        Try
            Dim olUsuario As New l_Usuario
            Dim oeUsuario As New e_Usuario
            oeUsuario.TipoOperacion = "W"
            oeUsuario = olUsuario.ObtieneFechaServidor(oeUsuario)
            Return oeUsuario.oePersona.FechaNacimiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Función para obtener el porcentaje de IGV de la fecha actual
    ''' </summary>
    ''' <remarks></remarks>
    Public Function ObtenerIGV() As Decimal
        Dim olIgv As New l_Impuesto
        Dim oeIgv As New e_Impuesto
        oeIgv = olIgv.IGV(ObtenerFechaServidor) 'Se utiliza provisionalmente el campo fecha de nacimiento del usuario para traer la fecha actual del servidor
        Return oeIgv.Porcentaje
    End Function

    Public Function ObtenerRetencion() As Decimal
        Dim olRetencion As New l_Impuesto
        Return olRetencion.Obtener(New e_Impuesto With {.Abreviatura = "RET", .FechaInicio = ObtenerFechaServidor()}).Porcentaje
    End Function

    ''' <summary>
    ''' Función para obtener el porcentaje de IGV en una fecha específica
    ''' </summary>
    ''' <remarks></remarks>
    Public Function ObtenerIGV(fecha As Date) As Decimal
        Dim olIgv As New l_Impuesto
        Dim oeIgv As New e_Impuesto
        oeIgv = olIgv.IGV(fecha)
        Return oeIgv.Porcentaje
    End Function

    ''' <summary>
    ''' Función que carga un OpenFileDialog con datos comunes para exportar archivos hacia Excel
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CargaDatosOpenFileDialog() As OpenFileDialog
        Dim dialogo As New OpenFileDialog
        dialogo.Title = "Ingrese Nombre de Archivo"
        dialogo.Filter = "Archivos Excel 97-2003(*.xls)|*.xls|Archivos Excel 2007 (*.xlsx)|*.xlsx|Libro de Excel Habilitado para macros (*.xlsm)|*.xlsm"
        dialogo.Multiselect = False
        dialogo.InitialDirectory = DirectorioPorDefecto()
        dialogo.FileName = ""
        dialogo.RestoreDirectory = True
        Return dialogo
    End Function

    ''' <summary>
    ''' Función que carga un SaveFileDialog con datos comunes para exportar archivos hacia Excel
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CargaDatosSaveFileDialog() As SaveFileDialog
        Dim dialogo As New SaveFileDialog
        dialogo.Title = "Ingrese Nombre de Archivo"
        dialogo.Filter = "Archivos Excel 97-2003(*.xls)|*.xls|Archivos Excel 2007 (*.xlsx)|*.xlsx"
        dialogo.FileName = ""
        Return dialogo
    End Function

    ''' <summary>
    ''' Función para unificar la grabación de registros editados
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ActualizaRegistroEditado(RegistroEditado As Integer, IdRegistroEditado As String) As Boolean
        Try
            If RegistroEditado = 1 Then
                Dim oeRegistroEditado As New e_RegistrosEditados
                With oeRegistroEditado
                    .Id = IdRegistroEditado
                End With
                Dim olRegistroEditado As New l_RegistrosEditados
                olRegistroEditado.Guardar(oeRegistroEditado)
                RegistroEditado = 0
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Función para convertir datos de tipo fecha mayores 60 segundos en tiempo r
    ''' </summary>
    ''' <param name="Valor"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ConvertirTiempoReal(Optional Valor As Double = 0.0) As Double
        Try
            Dim ParteEntera As Long
            Dim ParteDecimal As Double
            ParteEntera = Int(Valor)
            ParteDecimal = Valor - ParteEntera
            If ParteDecimal > 0.59 Then
                Return (ParteEntera + 1) + (ParteDecimal - 0.6)
            Else
                Return Valor
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    ''' <summary>
    ''' Metodo que cargar de datos un combo enviando el nombre de la tabla de origen, adicionalmente el campo para el ordenamiento de los datos.
    ''' </summary>
    ''' <param name="cbo">Control Combo.</param>
    ''' <param name="Tabla">Nombre de la Tabla.</param>
    ''' <param name="ValueMember">Campo interno que especifica la seleccion en el combo.</param>
    ''' <param name="DisplayMember">Campo que se muestra en la seleccion del combo.</param>
    ''' <param name="SelectedIndex">Valor por que se muestra por defecto.</param>
    ''' <param name="Sort">Campo para ordenar la informacion en el combo.</param>
    ''' <remarks></remarks>
    Public Sub LlenaComboConfigurable(cbo As ISL.Controles.Combo, Tabla As String, ValueMember As String, DisplayMember As String, SelectedIndex As Integer _
                                      , Optional Sort As String = "")
        Try
            Dim oeCTAux As New e_ConfiguracionTabla
            oeCTAux = CargarCTCD(Tabla)
            cbo.DataSource = FiltraDTable(GenerarDTConfigurable(oeCTAux), "", Sort)
            cbo.ValueMember = ValueMember
            cbo.DisplayMember = DisplayMember
            cbo.SelectedIndex = SelectedIndex
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Metodo que cargar de datos un combo enviando el nombre de la tabla de origen, adicionalmente el campo para el ordenamiento de los datos.
    ''' </summary>
    ''' <param name="cbo">Control Combo Infragistics.</param>
    ''' <param name="Tabla">Nombre de la Tabla.</param>
    ''' <param name="ValueMember">Campo interno que especifica la seleccion en el combo.</param>
    ''' <param name="DisplayMember">Campo que se muestra en la seleccion del combo.</param>
    ''' <param name="SelectedIndex">Valor por que se muestra por defecto.</param>
    ''' <param name="Sort">Campo para ordenar la informacion en el combo.</param>
    ''' <remarks></remarks>
    Public Sub LlenaComboConfigurable(cbo As Infragistics.Win.UltraWinEditors.UltraComboEditor, Tabla As String, ValueMember As String, DisplayMember As String, SelectedIndex As Integer _
                                      , Optional Sort As String = "")
        Try
            Dim oeCTAux As New e_ConfiguracionTabla
            oeCTAux = CargarCTCD(Tabla)
            cbo.DataSource = FiltraDTable(GenerarDTConfigurable(oeCTAux), "", Sort)
            cbo.ValueMember = ValueMember
            cbo.DisplayMember = DisplayMember
            cbo.SelectedIndex = SelectedIndex
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Metodo que cargar de datos un combo enviando un DataTable como origen de datos.
    ''' </summary>
    ''' <param name="cbo">Control Combo.</param>
    ''' <param name="DTable">Origen de Datos</param>
    ''' <param name="ValueMember">Campo interno que especifica la seleccion en el combo.</param>
    ''' <param name="DisplayMember">Campo que se muestra en la seleccion del combo.</param>
    ''' <param name="SelectedIndex">Valor por que se muestra por defecto.</param>
    ''' <remarks></remarks>
    Public Sub LlenaComboConfigurable(cbo As ISL.Controles.Combo, DTable As System.Data.DataTable, ValueMember As String, DisplayMember As String, SelectedIndex As Integer)
        Try
            cbo.DataSource = DTable
            cbo.ValueMember = ValueMember
            cbo.DisplayMember = DisplayMember
            cbo.SelectedIndex = SelectedIndex
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que cargar de datos un combo enviando un DataTable como origen de datos.
    ''' </summary>
    ''' <param name="cbo">Control UltraCombo</param>
    ''' <param name="DTable">Origen de Datos</param>
    ''' <param name="ValueMember">Campo interno que especifica la seleccion en el combo.</param>
    ''' <param name="DisplayMember">Campo que se muestra en la seleccion del combo.</param>
    ''' <remarks></remarks>
    Public Sub LlenaComboConfigurable(cbo As UltraCombo, DTable As System.Data.DataTable, ValueMember As String, DisplayMember As String)
        Try
            cbo.DataSource = DTable
            cbo.ValueMember = ValueMember
            cbo.DisplayMember = DisplayMember
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Metodo que retorna un DataTable generico
    ''' </summary>
    ''' <param name="oeConfiguracionTabla">Objeto de Origen de Datos</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GenerarDTConfigurable(oeConfiguracionTabla As e_ConfiguracionTabla) As System.Data.DataTable
        Try

            Dim dsGenerico As Data.DataTable = GenerarEstructuraDT(oeConfiguracionTabla.leColumna)
            Dim _nrofila As Integer = 0
            Dim _rwCD As Data.DataRow
            Dim _leAuxCD As New List(Of e_ConfiguracionDato)
            Dim _leCCCD As New List(Of e_ConfiguracionDato)
            Dim _leAuxCC = oeConfiguracionTabla.leColumna.Where(Function(it) it.Activo = True).ToList
            Dim _leDatosOrdenado = oeConfiguracionTabla.leDato.Where(Function(it) it.Activo = True).OrderBy(Function(it) it.NroFila).ToList

            For Each _oeCD In _leDatosOrdenado
                If _nrofila <> _oeCD.NroFila Then
                    _nrofila = _oeCD.NroFila
                    _rwCD = dsGenerico.NewRow
                    _leAuxCD = New List(Of e_ConfiguracionDato)
                    _leAuxCD = _leDatosOrdenado.Where(Function(it) it.NroFila = _nrofila).ToList
                    For Each _oeCC In _leAuxCC
                        _leCCCD = _leAuxCD.Where(Function(it) it.Columna = _oeCC.Nombre).ToList
                        If _leCCCD.Count > 0 Then
                            _rwCD(_oeCC.Nombre) = _leCCCD(0).Descripcion
                        Else
                            _rwCD(_oeCC.Nombre) = _oeCC.ValorDefecto
                        End If
                    Next
                    dsGenerico.Rows.Add(_rwCD)
                End If
            Next

            Return dsGenerico

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Cargar una Tabla Configurable con sus respectivas Columnas y Datos
    ''' </summary>
    ''' <param name="Tabla">Nombre de Tabla</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CargarCTCD(Tabla As String) As e_ConfiguracionTabla
        Try
            Dim oeConfTabla As New e_ConfiguracionTabla, olConfTabla As New l_ConfiguracionTabla
            oeConfTabla.TipoOperacion = ""
            oeConfTabla.Nombre = Tabla
            oeConfTabla = olConfTabla.Obtener(oeConfTabla)
            Return oeConfTabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Función que retorna un datos filtrados de un DataTable
    ''' </summary>
    ''' <param name="DTable">Origen de Datos</param>
    ''' <param name="Filtro">Parametros de Filtro</param>
    ''' <param name="Sort">Parametros de Ordenamiento</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function FiltraDTable(DTable As System.Data.DataTable, Filtro As String, Sort As String) As System.Data.DataTable
        Try
            Dim dtAux As New Data.DataTable
            If Not IsNothing(DTable.Select(Filtro, Sort)) Then
                dtAux = DTable.Select(Filtro, Sort).CopyToDataTable
            End If
            Return dtAux
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function GenerarEstructuraDT(leColumnas As List(Of e_ConfiguracionColumna)) As System.Data.DataTable
        Try
            Dim dsEstructura As New Data.DataTable
            Dim _td As String = ""
            With dsEstructura
                For Each oeCCol In leColumnas
                    Select Case oeCCol.TipoDato
                        Case "Bit" : _td = "Boolean"
                        Case "Char" : _td = "String"
                        Case "DateTime" : _td = "DateTime"
                        Case "Decimal" : _td = "Decimal"
                        Case "Int" : _td = "Int32"
                        Case "Varchar" : _td = "String"
                    End Select
                    .Columns.Add(oeCCol.Nombre, Type.GetType("System." & _td))
                    ' .Columns(oeCCol.Codigo).Caption = oeCCol.Nombre
                Next
            End With
            Return dsEstructura
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'funcion para retornar la cuenta corriente (personal/administrativa) de un trabajador
    Public Function BuscarIdCtaCte(ByVal idtrabajador As String, ByVal TipoCuenta As Integer, loCuentaCorriente As List(Of e_CuentaCorriente)) As String
        Dim IdCta As String = ""
        Try
            For Each ctacte As e_CuentaCorriente In loCuentaCorriente.Where(Function(item) item.Tipo = TipoCuenta).ToList
                If ctacte.IdTrabajador = idtrabajador Then
                    IdCta = ctacte.Id
                    Return IdCta
                End If
            Next
            Return IdCta
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Private Function ObtieneNombreCol(leColumnas As List(Of e_ConfiguracionColumna), IdCodigo As String) As String
    '    Try
    '        Dim NombreCol As String = ""
    '        Dim _oeCCAux As New e_ConfiguracionColumna
    '        _oeCCAux.Equivale = 1
    '        _oeCCAux.Id = IdCodigo
    '        If leColumnas.Contains(_oeCCAux) Then
    '            _oeCCAux = leColumnas.Item(leColumnas.IndexOf(_oeCCAux))
    '            NombreCol = _oeCCAux.Nombre
    '        End If
    '        Return NombreCol
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    'Public Function MensajePC(texto As String) As Threading.Tasks.Task
    '    Try
    '        If Not String.IsNullOrEmpty(texto) Then
    '            Dim hablar = CreateObject("Sapi.Spvoice")
    '            'Await hablar.speak(texto, 1)
    '        End If
    '    Catch ex As Exception
    '        'Throw ex
    '    End Try
    'End Function

    Public Function EjecutaFormula(_Nombre As String, _indPlanilla As Boolean, _dsDatos As Data.DataTable,
                                   _leFormula As List(Of e_Formula), _leParametros As List(Of e_AporteDescuento),
                                   _leDetParametro As List(Of e_DetalleAporteDescuento), ByVal ParamArray _variables() As String) As Double
        Try
            Dim _oeformula As New e_Formula
            _oeformula.Equivale = 3 : _oeformula.Nombre = _Nombre
            If _leFormula.Contains(_oeformula) Then
                _oeformula = _leFormula.Item(_leFormula.IndexOf(_oeformula))
                Dim val As Double = 0
                Dim sCodigo As String = ""
                Dim sDeclara As String = ""
                If _oeformula.DatoTrabajador.Trim <> "" Then
                    sDeclara = RecuperaDatos(_oeformula.DatoTrabajador, _dsDatos)
                End If
                If _oeformula.Parametros.Trim <> "" Then
                    sDeclara = sDeclara & RecuperaParametros(_oeformula.Parametros, _leParametros, _leDetParametro) & Environment.NewLine
                End If
                If _oeformula.Constantes.Trim <> "" Then
                    If Not _indPlanilla Then
                        sDeclara = sDeclara & RecuperaVariables("", _variables, _oeformula.Constantes, _indPlanilla) & Environment.NewLine
                    End If
                End If
                If _oeformula.Variables.Trim <> "" Then
                    sDeclara = sDeclara & RecuperaVariables(_oeformula.Variables, _variables, "", True) & Environment.NewLine
                End If
                sCodigo = sDeclara & " " & Environment.NewLine &
                            "Function " & _oeformula.Nombre & Environment.NewLine _
                                & _oeformula.Nombre & " = " & _oeformula.Instrucciones & Environment.NewLine _
                             & "End Function"
                Dim sc As New ScriptControl
                With sc
                    .Language = "VBScript"
                    .AllowUI = True
                    .AddCode(sCodigo)
                    val = .Run(_oeformula.Nombre)
                End With
                Return val
            Else
                Throw New Exception("La Fórmula: " & _Nombre & " no se encuentra")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function RecuperaParametros(_parametros As String, _leParametros As List(Of e_AporteDescuento), _leDetParametros As List(Of e_DetalleAporteDescuento)) As String
        Try
            Dim aDatos As String = ""
            Dim sPar As String() = Nothing
            sPar = _parametros.Split(",")
            For x = 0 To sPar.Length - 1
                Dim _oeParametro As New e_AporteDescuento
                _oeParametro.Abreviatura = sPar(x)
                _oeParametro.Equivale = 4
                If _leParametros.Contains(_oeParametro) Then
                    _oeParametro = _leParametros.Item(_leParametros.IndexOf(_oeParametro))
                    Dim _oeDetParametro As New e_DetalleAporteDescuento
                    _oeDetParametro.IdAporteDescuento = _oeParametro.Id
                    _oeDetParametro.Equivale = 2
                    If _leDetParametros.Contains(_oeDetParametro) Then
                        _oeDetParametro = _leDetParametros.Item(_leDetParametros.IndexOf(_oeDetParametro))
                        aDatos = aDatos & "Dim " & sPar(x) & Environment.NewLine &
                            sPar(x) & " = " & _oeDetParametro.MontoCalculo & Environment.NewLine
                    End If
                    _oeDetParametro.Dispose()
                End If
                _oeParametro.Dispose()
            Next
            Return aDatos
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function RecuperaVariables(_variables As String, _var() As String, _constantes As String, _indplanilla As Boolean) As String
        Try
            Dim aDatos As String = ""
            Dim sVar As String() = Nothing
            If Not _indplanilla Then
                sVar = _constantes.Split(",")
                For i = 0 To sVar.Length - 1
                    aDatos = aDatos & "Dim " & sVar(i) & Environment.NewLine &
                        sVar(i) & " = " & _var(i) & Environment.NewLine
                Next
            Else
                sVar = _variables.Split(",")
                For i = 0 To sVar.Length - 1
                    aDatos = aDatos & "Dim " & sVar(i) & Environment.NewLine &
                        sVar(i) & " = " & _var(i) & Environment.NewLine
                Next
            End If
            Return aDatos
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function RecuperaDatos(_DatosTrabajador As String, _dsDatosGen As Data.DataTable) As String
        Try
            Dim aDatos As String = ""
            Dim sDT As String() = Nothing
            sDT = _DatosTrabajador.Split(",")
            For i = 0 To sDT.Length - 1
                aDatos = aDatos & "Dim " & sDT(i) & Environment.NewLine &
                    sDT(i) & " = " & _dsDatosGen.Rows(0).Item(sDT(i)) & Environment.NewLine
            Next
            Return aDatos
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValorParametro(_Nombre As String, _leParametros As List(Of e_AporteDescuento), _leDetParametros As List(Of e_DetalleAporteDescuento)) As Double
        Try
            Dim _oeParametro As New e_AporteDescuento
            Dim _var As Double = 0
            _oeParametro.Abreviatura = _Nombre
            _oeParametro.Equivale = 4
            If _leParametros.Contains(_oeParametro) Then
                _oeParametro = _leParametros.Item(_leParametros.IndexOf(_oeParametro))
                Dim _oeDetParametro As New e_DetalleAporteDescuento
                _oeDetParametro.IdAporteDescuento = _oeParametro.Id
                _oeDetParametro.Equivale = 2
                If _leDetParametros.Contains(_oeDetParametro) Then
                    _oeDetParametro = _leDetParametros.Item(_leDetParametros.IndexOf(_oeDetParametro))
                    _var = _oeDetParametro.MontoCalculo
                End If
                _oeDetParametro.Dispose()
            End If
            _oeParametro.Dispose()
            Return _var
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarAcl(_acl As String, _idActividadNegocio As String) As Boolean
        Try
            If gUsuarioSGI.leARUsuario.Count > 0 Then
                If _idActividadNegocio IsNot Nothing Then
                    oeActividadRU = New e_ActividadRestringida_Usuario
                    oeActividadRU.IdActividadNegocio = _idActividadNegocio
                    oeActividadRU.AccionSistema = _acl
                    oeActividadRU.Equivale = 1
                    Return gUsuarioSGI.leARUsuario.Contains(oeActividadRU)
                Else
                    Return True
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarActividadNegocio(_acl As String, _ActividadNegocio As String) As Boolean
        Try
            If gUsuarioSGI.leARUsuario.Count > 0 Then
                If _ActividadNegocio IsNot Nothing Then
                    oeActividadRU = New e_ActividadRestringida_Usuario
                    oeActividadRU.IdActividadNegocio = _ActividadNegocio
                    oeActividadRU.AccionSistema = _acl
                    oeActividadRU.Equivale = 1
                    Return gUsuarioSGI.leARUsuario.Contains(oeActividadRU)
                Else
                    Return True
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Caja usuario en centro externo
    Public Function ValidaUsuarioCajaCentro(IdCaja As String, IdCentro As String, IdTrabajador As String) As Boolean
        Try
            Dim flag As Boolean = False
            For Each cajausuario As e_Combo In CajaUsuarioCentro
                If Trim(cajausuario.Id) = IdCaja And Trim(cajausuario.Nombre) = IdTrabajador And Trim(cajausuario.Descripcion) = IdCentro Then
                    flag = True
                    Exit For
                Else
                    flag = False
                End If
            Next
            Return flag
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Buscar Usuario Caja
    Public Function BuscarCajaUsuario(IdTrabajador As String) As e_CajaUsuario
        Try
            Dim oeCajaUsuario As New e_CajaUsuario
            Dim olCajaUsuario As New l_CajaUsuario
            oeCajaUsuario.IdTrabajador = IdTrabajador
            oeCajaUsuario = olCajaUsuario.Obtener(oeCajaUsuario)
            Return oeCajaUsuario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Actualiza listas globales
    Public Sub ActualizarListaPublica(Nombre As String)
        Try
            olCombo = New l_Combo
            oeCombo = New e_Combo
            oeCombo.Nombre = Nombre
            Select Case Nombre
                Case "MATERIAL ALMACEN"
                    MaterialAlmacenPublic = New List(Of e_Combo)
                    MaterialAlmacenPublic.AddRange(olCombo.Listar(oeCombo))
                Case "MATERIALSUBFAMILIA"
                    MaterialSubFamilia = New List(Of e_Combo)
                    MaterialSubFamilia.AddRange(olCombo.Listar(oeCombo))
                Case "CATEGORIASERVICIO"
                    CategoriaServicioPublic = New List(Of e_Combo)
                    CategoriaServicioPublic.AddRange(olCombo.Listar(oeCombo))
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Función que retorna el nombre de la sede de acuerdo al prefijo del sistema
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Lugar() As String
        'Dim Prefijo As New l_Configuracion
        'Select Case Prefijo.PrefijoID '@0001
        'Select Case gs_PrefijoIdSucursal '@0001
        '    Case "1CH"
        '        Lugar = "sede Chiclayo"
        '    Case "1PY"
        '        Lugar = "sede Pacasmayo"
        '    Case "1LI"
        '        Lugar = "sede Ransa Callao"
        '    Case "1SA"
        '        Lugar = "sede Santa Anita"
        '    Case "1LU"
        '        Lugar = "sede Lurín"
        '    Case "1PI"
        '        Lugar = "sede Piura"
        '    Case Else
        '        Lugar = "Area de Sistemas"
        'End Select '@0001 Fin Ini
        Dim oecentro = New e_Centro
        Dim olcentro = New l_Centro
        oecentro.TipoOperacion = "3"
        oecentro.Abreviatura = gs_PrefijoIdSucursal
        oecentro.PrefijoID = gs_PrefijoIdSucursal
        oecentro = olcentro.Obtener(oecentro)
        Lugar = oecentro.Nombre.Trim
        '@0001 Fin
        Return Lugar
    End Function

    ''' <summary>
    ''' Funcion que Retorna DT de Referencia de Asiento Modelo
    ''' </summary>
    ''' <param name="leRef"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GeneraDTRef(leRef As List(Of e_AsientoModelo_Referencia)) As Data.DataTable
        Try
            Dim _IdAM As String = String.Empty
            Dim _leAux As New List(Of e_AsientoModelo_Referencia)
            For Each oeRef In leRef.OrderBy(Function(it) it.IdActividad).ToList
                If _IdAM <> oeRef.IdActividad Then
                    _IdAM = oeRef.IdActividad
                    Dim _oeAux As New e_AsientoModelo_Referencia
                    _oeAux.IdActividad = _IdAM
                    Dim _lex = leRef.Where(Function(it) it.IdActividad = _IdAM).ToList
                    _oeAux.Cant = _lex.Count
                    _leAux.Add(_oeAux)
                End If
            Next
            Dim dt As Data.DataTable = CrearDTRef(_leAux.OrderByDescending(Function(it) it.Cant).ToList(0))
            Dim rwdt As Data.DataRow
            Dim pos As Integer = 0
            For Each oeRefAux In _leAux
                rwdt = dt.NewRow
                rwdt("IdAsientoModelo") = oeRefAux.IdActividad
                pos = 0
                For Each _oe In leRef.Where(Function(it) it.IdActividad = oeRefAux.IdActividad).OrderBy(Function(it) it.TipoReferencia).ToList
                    pos = pos + 1
                    rwdt("TipoRef" & pos) = _oe.TipoReferencia
                    rwdt("IdRef" & pos) = _oe.IdReferencia
                    rwdt("Ref" & pos) = _oe.Nombre
                Next
                dt.Rows.Add(rwdt)
            Next
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CrearDTRef(oeEstruc As e_AsientoModelo_Referencia) As Data.DataTable
        Dim dtStruc As New Data.DataTable
        With dtStruc
            .Columns.Add(New Data.DataColumn("IdAsientoModelo", Type.GetType("System.String")))
            For i = 1 To oeEstruc.Cant
                .Columns.Add(New Data.DataColumn("TipoRef" & i, Type.GetType("System.Int32")))
                .Columns.Add(New Data.DataColumn("IdRef" & i, Type.GetType("System.String")))
                .Columns.Add(New Data.DataColumn("Ref" & i, Type.GetType("System.String")))
            Next
        End With
        Return dtStruc
    End Function

    Public Function BuscarCategoriaServicio(IdServicio As String) As String
        Dim oeCatSer As New e_Combo
        oeCatSer.Tipo = 0
        oeCatSer.Id = IdServicio
        If CategoriaServicioPublic.Contains(oeCatSer) Then
            oeCatSer = CategoriaServicioPublic.Item(CategoriaServicioPublic.IndexOf(oeCatSer))
            Return oeCatSer.Nombre.Trim
        Else
            Return String.Empty
        End If
    End Function

    Public Function LlenaCuentaCatServicio(oeMovDoc As e_MovimientoDocumento, loCtaCtbleCSer As List(Of e_CtaCtbleCatServicio), Ejercicio As Integer) As List(Of e_CtaCtbleCatServicio)
        Try
            If oeMovDoc.lstDetalleDocumento.Count = 0 Then
                Dim oeDetDoc As New e_DetalleDocumento
                Dim olDetalleDocumento As New l_DetalleDocumento
                oeDetDoc.TipoOperacion = "COM"
                oeDetDoc.Activo = 1
                oeDetDoc.IdMovimientoDocumento = oeMovDoc.Id
                oeDetDoc.IndServicioMaterial = "S"
                oeMovDoc.lstDetalleDocumento = New List(Of e_DetalleDocumento)
                oeMovDoc.lstDetalleDocumento.AddRange(olDetalleDocumento.Listar(oeDetDoc))
            End If
            For Each detdoc As e_DetalleDocumento In oeMovDoc.lstDetalleDocumento
                detdoc.IdCategoriaServicio = BuscarCategoriaServicio(detdoc.IdMaterialServicio)
                If detdoc.IdCategoriaServicio = "" Then Throw New Exception("Servicio: " & detdoc.NombreMaterialServicio & " con Categoria Sin Cuenta Contable. Verificar")
            Next
            Dim loCtaCtbleCatServ, loAuxCtaCtble1, loAuxCtaCtble2, loAuxCtaCtble3 As New List(Of e_CtaCtbleCatServicio)
            Dim oeCtaCtbleCatServ, oeCtaCtbleCatServ1, oeCtaCtbleCatServ2 As New e_CtaCtbleCatServicio
            If oeMovDoc.lstDetalleDocumento.Count = 0 Then
                oeCtaCtbleCatServ = New e_CtaCtbleCatServicio
                Dim oeCombo As New e_Combo
                oeCombo.Descripcion = oeMovDoc.Ejercicio
                oeCombo.Nombre = "63932"
                oeCombo.Tipo = 4
                If oeMovDoc.loCtas.Contains(oeCombo) Then
                    oeCombo = oeMovDoc.loCtas.Item(oeMovDoc.loCtas.IndexOf(oeCombo))
                Else
                    Throw New Exception("Error en Cuenta Contable. Verificar")
                End If
                With oeCtaCtbleCatServ
                    .IdCategoriaServicio = "1CH000000011"
                    .IdCuentaContable = oeCombo.Id
                    .IdItemGasto = "1CH000076"
                    .TotalCuenta = oeMovDoc.Total
                    .NroCuentaContable = "63932"
                End With
                loCtaCtbleCatServ.Add(oeCtaCtbleCatServ)
                Return loCtaCtbleCatServ
            End If
            For Each serv As e_DetalleDocumento In oeMovDoc.lstDetalleDocumento
                oeCtaCtbleCatServ = New e_CtaCtbleCatServicio
                oeCtaCtbleCatServ.IdCategoriaServicio = serv.IdCategoriaServicio
                For Each oe As e_CtaCtbleCatServicio In loCtaCtbleCSer.Where(Function(i) i.Ejercicio = Ejercicio).ToList
                    With oeCtaCtbleCatServ
                        If .IdCategoriaServicio = oe.IdCategoriaServicio Then
                            .IdCuentaContable = oe.IdCuentaContable
                            .NroCuentaContable = oe.NroCuentaContable
                            .IdItemGasto = oe.IdItemGasto
                            If serv.IndGravado Then
                                .TotalCuenta = serv.Cantidad * serv.PrecioUnitarioSinImp
                            Else
                                .TotalCuenta = serv.Cantidad * serv.Precio
                            End If
                            loAuxCtaCtble1.Add(oeCtaCtbleCatServ)
                        End If
                    End With
                Next
                If oeCtaCtbleCatServ.IdCuentaContable.Trim.Length = 0 Then Throw New Exception("El servicio " & serv.NombreMaterialServicio.Trim & " no tiene asignado cuenta contable.")
            Next
            Dim IdCatServicio As String = ""
            oeCtaCtbleCatServ1 = New e_CtaCtbleCatServicio
            loAuxCtaCtble2 = New List(Of e_CtaCtbleCatServicio)
            loAuxCtaCtble2.AddRange(loAuxCtaCtble1.OrderBy(Function(i) i.IdCategoriaServicio).ToList)
            For Each ctactble As e_CtaCtbleCatServicio In loAuxCtaCtble2
                oeCtaCtbleCatServ1 = New e_CtaCtbleCatServicio
                If IdCatServicio <> ctactble.IdCategoriaServicio Then
                    IdCatServicio = ctactble.IdCategoriaServicio
                    With oeCtaCtbleCatServ1
                        .IdCategoriaServicio = ctactble.IdCategoriaServicio
                        .IdCuentaContable = ctactble.IdCuentaContable
                        .NroCuentaContable = ctactble.NroCuentaContable
                        .IdItemGasto = ctactble.IdItemGasto
                        .TotalCuenta = loAuxCtaCtble2.Where(Function(i) i.IdCategoriaServicio = IdCatServicio).Sum(Function(i) i.TotalCuenta)
                    End With
                    loAuxCtaCtble3.Add(oeCtaCtbleCatServ1)
                End If
            Next
            Dim IdCuenta As String = ""
            loAuxCtaCtble1 = New List(Of e_CtaCtbleCatServicio)
            loAuxCtaCtble1.AddRange(loAuxCtaCtble3.OrderBy(Function(i) i.IdCuentaContable).ToList)
            For Each ctactble As e_CtaCtbleCatServicio In loAuxCtaCtble1
                oeCtaCtbleCatServ1 = New e_CtaCtbleCatServicio
                If IdCuenta <> ctactble.IdCuentaContable Then
                    IdCuenta = ctactble.IdCuentaContable
                    With oeCtaCtbleCatServ1
                        .IdCategoriaServicio = ctactble.IdCategoriaServicio
                        .IdCuentaContable = ctactble.IdCuentaContable
                        .NroCuentaContable = ctactble.NroCuentaContable
                        .IdItemGasto = ctactble.IdItemGasto
                        .TotalCuenta = loAuxCtaCtble1.Where(Function(i) i.IdCuentaContable = IdCuenta).Sum(Function(i) i.TotalCuenta)
                    End With
                    loCtaCtbleCatServ.Add(oeCtaCtbleCatServ1)
                End If
            Next
            Return loCtaCtbleCatServ
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarSubFamilia(IdMaterial As String) As String
        Dim oeMatSubFam As New e_Combo
        oeMatSubFam.Tipo = 0
        oeMatSubFam.Id = IdMaterial
        If MaterialSubFamilia.Contains(oeMatSubFam) Then
            oeMatSubFam = MaterialSubFamilia.Item(MaterialSubFamilia.IndexOf(oeMatSubFam))
            Return oeMatSubFam.Nombre.Trim
        Else
            Return String.Empty
        End If
    End Function

    Public Sub LlenaCuentaOrden(oeOrden As e_Orden, Ejercicio As Integer, loCtaCtbleSFam As List(Of e_CtaCtbleSubFamiliaMat))
        Try
            For Each oemat As e_OrdenMaterial In oeOrden.lstOrdenMaterial.Where(Function(i) i.IndPropio = True).ToList
                oemat.IdSubFamiliaMaterial = BuscarSubFamilia(oemat.IdMaterial)
                If oemat.IdSubFamiliaMaterial = "" Then Throw New Exception("Material: " & oemat.Material & " con SubFamilia Sin Cuenta Contable. Verificar")
            Next
            Dim loAuxCtaCtble, loAuxCtaCtble1, loAuxCtaCtble2 As New List(Of e_CtaCtbleSubFamiliaMat)
            Dim oeCtaCtbleSFM As New e_CtaCtbleSubFamiliaMat
            For Each ordmat As e_OrdenMaterial In oeOrden.lstOrdenMaterial.Where(Function(i) i.IndPropio = True).ToList
                oeCtaCtbleSFM = New e_CtaCtbleSubFamiliaMat
                oeCtaCtbleSFM.IdSubFamilia = ordmat.IdSubFamiliaMaterial
                For Each oe As e_CtaCtbleSubFamiliaMat In loCtaCtbleSFam.Where(Function(i) i.Ejercicio = Ejercicio).ToList
                    With oeCtaCtbleSFM
                        If .IdSubFamilia = oe.IdSubFamilia Then
                            .IdCtaCtbleExistencias = oe.IdCtaCtbleExistencias
                            .NroCtaCtbleExistencias = oe.NroCtaCtbleExistencias
                            .CtaCtbleExistencias = oe.CtaCtbleExistencias
                            .IdCtaCtbleCompras = oe.IdCtaCtbleCompras
                            .CtaCtbleCompra = oe.CtaCtbleCompra
                            .NroCtaCtbleCompra = oe.NroCtaCtbleCompra
                            .IdCtaCtbleConsumo = oe.IdCtaCtbleConsumo
                            .CtaCtbleConsumo = oe.CtaCtbleConsumo
                            .NroCtaCtbleConsumo = oe.NroCtaCtbleConsumo
                            .IdItemGasto = oe.IdItemGasto
                            .TotalCuentas = (ordmat.CantidadMaterial * ordmat.PrecioUnitario) / (1 + oeIGVGlobal.Porcentaje)
                            loAuxCtaCtble1.Add(oeCtaCtbleSFM)
                        End If
                    End With
                Next
            Next
            Dim IdSubFamilia As String = ""
            Dim ctactbleaux As New e_CtaCtbleSubFamiliaMat
            loAuxCtaCtble.AddRange(loAuxCtaCtble1.OrderBy(Function(item) item.IdSubFamilia).ToList)
            For Each ctactblesfm As e_CtaCtbleSubFamiliaMat In loAuxCtaCtble
                ctactbleaux = New e_CtaCtbleSubFamiliaMat
                If IdSubFamilia <> ctactblesfm.IdSubFamilia Then
                    IdSubFamilia = ctactblesfm.IdSubFamilia
                    With ctactbleaux
                        .IdCtaCtbleExistencias = ctactblesfm.IdCtaCtbleExistencias
                        .NroCtaCtbleExistencias = ctactblesfm.NroCtaCtbleExistencias
                        .CtaCtbleExistencias = ctactblesfm.CtaCtbleExistencias
                        .IdCtaCtbleCompras = ctactblesfm.IdCtaCtbleCompras
                        .CtaCtbleCompra = ctactblesfm.CtaCtbleCompra
                        .NroCtaCtbleCompra = ctactblesfm.NroCtaCtbleCompra
                        .IdCtaCtbleConsumo = ctactblesfm.IdCtaCtbleConsumo
                        .CtaCtbleConsumo = ctactblesfm.CtaCtbleConsumo
                        .NroCtaCtbleConsumo = ctactblesfm.NroCtaCtbleConsumo
                        .IdItemGasto = ctactblesfm.IdItemGasto
                        .TotalCuentas = Math.Round(loAuxCtaCtble.Where(Function(item) item.IdSubFamilia = IdSubFamilia).Sum(Function(item) item.TotalCuentas), 2)
                    End With
                    loAuxCtaCtble2.Add(ctactbleaux)
                End If
            Next
            Dim IdCuenta As String = ""
            Dim loCtaCtbleSFamOrden As New List(Of e_CtaCtbleSubFamiliaMat)
            ctactbleaux = New e_CtaCtbleSubFamiliaMat
            loAuxCtaCtble = New List(Of e_CtaCtbleSubFamiliaMat)
            loAuxCtaCtble.AddRange(loAuxCtaCtble2.OrderBy(Function(item) item.IdCtaCtbleExistencias).ToList)
            For Each ctactblesfm As e_CtaCtbleSubFamiliaMat In loAuxCtaCtble
                ctactbleaux = New e_CtaCtbleSubFamiliaMat
                If IdCuenta <> ctactblesfm.IdCtaCtbleExistencias Then
                    IdCuenta = ctactblesfm.IdCtaCtbleExistencias
                    With ctactbleaux
                        .IdCtaCtbleExistencias = ctactblesfm.IdCtaCtbleExistencias
                        .NroCtaCtbleExistencias = ctactblesfm.NroCtaCtbleExistencias
                        .CtaCtbleExistencias = ctactblesfm.CtaCtbleExistencias
                        .IdCtaCtbleCompras = ctactblesfm.IdCtaCtbleCompras
                        .CtaCtbleCompra = ctactblesfm.CtaCtbleCompra
                        .NroCtaCtbleCompra = ctactblesfm.NroCtaCtbleCompra
                        .IdCtaCtbleConsumo = ctactblesfm.IdCtaCtbleConsumo
                        .CtaCtbleConsumo = ctactblesfm.CtaCtbleConsumo
                        .NroCtaCtbleConsumo = ctactblesfm.NroCtaCtbleConsumo
                        .IdItemGasto = ctactblesfm.IdItemGasto
                        .TotalCuentas = Math.Round(loAuxCtaCtble.Where(Function(item) item.IdCtaCtbleExistencias = IdCuenta).Sum(Function(item) item.TotalCuentas), 2)
                    End With
                    loCtaCtbleSFamOrden.Add(ctactbleaux)
                End If
            Next
            oeOrden.loCtaCtbleSFam.AddRange(loCtaCtbleSFamOrden)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function LlenaCuenta(oeMovDoc As e_MovimientoDocumento, loCtaCtbleSFam As List(Of e_CtaCtbleSubFamiliaMat), Ejercicio As Integer) As List(Of e_CtaCtbleSubFamiliaMat)
        Try
            Dim oeDetDoc As New e_DetalleDocumento
            Dim olDetalleDocumento As New l_DetalleDocumento
            oeDetDoc.TipoOperacion = "COM"
            oeDetDoc.Activo = 1
            oeDetDoc.IdMovimientoDocumento = oeMovDoc.Id
            oeDetDoc.IndServicioMaterial = "M"
            oeMovDoc.lstDetalleDocumento = New List(Of e_DetalleDocumento)
            oeMovDoc.lstDetalleDocumento.AddRange(olDetalleDocumento.Listar(oeDetDoc))
            For Each detdoc As e_DetalleDocumento In oeMovDoc.lstDetalleDocumento
                detdoc.IdSubFamiliaMaterial = BuscarSubFamilia(detdoc.IdMaterialServicio)
                If detdoc.IdSubFamiliaMaterial = "" Then Throw New Exception("Material: " & detdoc.NombreMaterialServicio & " con SubFamilia Sin Cuenta Contable. Verificar")
            Next
            Dim loAuxCtaCtble, loAuxCtaCtble1, loAuxCtaCtble2 As New List(Of e_CtaCtbleSubFamiliaMat)
            Dim oeCtaCtbleSFM As New e_CtaCtbleSubFamiliaMat
            For Each ordmat As e_DetalleDocumento In oeMovDoc.lstDetalleDocumento
                oeCtaCtbleSFM = New e_CtaCtbleSubFamiliaMat
                oeCtaCtbleSFM.IdSubFamilia = ordmat.IdSubFamiliaMaterial
                For Each oe As e_CtaCtbleSubFamiliaMat In loCtaCtbleSFam.Where(Function(i) i.Ejercicio = Ejercicio).ToList
                    With oeCtaCtbleSFM
                        If .IdSubFamilia = oe.IdSubFamilia Then
                            .IdCtaCtbleExistencias = oe.IdCtaCtbleExistencias
                            .NroCtaCtbleExistencias = oe.NroCtaCtbleExistencias
                            .CtaCtbleExistencias = oe.CtaCtbleExistencias
                            .IdCtaCtbleCompras = oe.IdCtaCtbleCompras
                            .CtaCtbleCompra = oe.CtaCtbleCompra
                            .NroCtaCtbleCompra = oe.NroCtaCtbleCompra
                            .IdCtaCtbleConsumo = oe.IdCtaCtbleConsumo
                            .CtaCtbleConsumo = oe.CtaCtbleConsumo
                            .NroCtaCtbleConsumo = oe.NroCtaCtbleConsumo
                            .IdItemGasto = oe.IdItemGasto
                            If ordmat.IndGravado Then
                                .TotalCuentas = (ordmat.Cantidad * ordmat.PrecioUnitarioSinImp)
                            Else
                                .TotalCuentas = ordmat.Cantidad * ordmat.Precio
                            End If
                            loAuxCtaCtble1.Add(oeCtaCtbleSFM)
                        End If
                    End With
                Next
            Next
            Dim IdSubFamilia As String = ""
            Dim ctactbleaux As New e_CtaCtbleSubFamiliaMat
            loAuxCtaCtble.AddRange(loAuxCtaCtble1.OrderBy(Function(item) item.IdSubFamilia).ToList)
            For Each ctactblesfm As e_CtaCtbleSubFamiliaMat In loAuxCtaCtble
                ctactbleaux = New e_CtaCtbleSubFamiliaMat
                If IdSubFamilia <> ctactblesfm.IdSubFamilia Then
                    IdSubFamilia = ctactblesfm.IdSubFamilia
                    With ctactbleaux
                        .IdCtaCtbleExistencias = ctactblesfm.IdCtaCtbleExistencias
                        .NroCtaCtbleExistencias = ctactblesfm.NroCtaCtbleExistencias
                        .CtaCtbleExistencias = ctactblesfm.CtaCtbleExistencias
                        .IdCtaCtbleCompras = ctactblesfm.IdCtaCtbleCompras
                        .CtaCtbleCompra = ctactblesfm.CtaCtbleCompra
                        .NroCtaCtbleCompra = ctactblesfm.NroCtaCtbleCompra
                        .IdCtaCtbleConsumo = ctactblesfm.IdCtaCtbleConsumo
                        .CtaCtbleConsumo = ctactblesfm.CtaCtbleConsumo
                        .NroCtaCtbleConsumo = ctactblesfm.NroCtaCtbleConsumo
                        .IdItemGasto = ctactblesfm.IdItemGasto
                        .TotalCuentas = loAuxCtaCtble.Where(Function(item) item.IdSubFamilia = IdSubFamilia).Sum(Function(item) item.TotalCuentas)
                    End With
                    loAuxCtaCtble2.Add(ctactbleaux)
                End If
            Next
            Dim IdCuenta As String = ""
            Dim loCtaCtbleSFamFct As New List(Of e_CtaCtbleSubFamiliaMat)
            ctactbleaux = New e_CtaCtbleSubFamiliaMat
            loAuxCtaCtble = New List(Of e_CtaCtbleSubFamiliaMat)
            loAuxCtaCtble.AddRange(loAuxCtaCtble2.OrderBy(Function(item) item.IdCtaCtbleCompras).ToList)
            For Each ctactblesfm As e_CtaCtbleSubFamiliaMat In loAuxCtaCtble
                ctactbleaux = New e_CtaCtbleSubFamiliaMat
                If IdCuenta <> ctactblesfm.IdCtaCtbleCompras Then
                    IdCuenta = ctactblesfm.IdCtaCtbleCompras
                    With ctactbleaux
                        .IdCtaCtbleExistencias = ctactblesfm.IdCtaCtbleExistencias
                        .NroCtaCtbleExistencias = ctactblesfm.NroCtaCtbleExistencias
                        .CtaCtbleExistencias = ctactblesfm.CtaCtbleExistencias
                        .IdCtaCtbleCompras = ctactblesfm.IdCtaCtbleCompras
                        .CtaCtbleCompra = ctactblesfm.CtaCtbleCompra
                        .NroCtaCtbleCompra = ctactblesfm.NroCtaCtbleCompra
                        .IdCtaCtbleConsumo = ctactblesfm.IdCtaCtbleConsumo
                        .CtaCtbleConsumo = ctactblesfm.CtaCtbleConsumo
                        .NroCtaCtbleConsumo = ctactblesfm.NroCtaCtbleConsumo
                        .IdItemGasto = ctactblesfm.IdItemGasto
                        .TotalCuentas = Math.Round(loAuxCtaCtble.Where(Function(item) item.IdCtaCtbleCompras = IdCuenta).Sum(Function(item) item.TotalCuentas), 2)
                    End With
                    loCtaCtbleSFamFct.Add(ctactbleaux)
                End If
            Next
            Return loCtaCtbleSFamFct
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ProrrateaCuentas(IdDocumento As String, oeMovDoc As e_MovimientoDocumento, loCtaCtbleSFam As List(Of e_CtaCtbleSubFamiliaMat), Periodo As Integer) As List(Of e_CtaCtbleSubFamiliaMat)
        Try
            Dim oeDetDoc As New e_DetalleDocumento
            Dim olDetalleDocumento As New l_DetalleDocumento
            Dim loDetalleDocumento As New List(Of e_DetalleDocumento)
            oeDetDoc.TipoOperacion = "COM"
            oeDetDoc.Activo = 1
            oeDetDoc.IdMovimientoDocumento = IdDocumento
            oeDetDoc.IndServicioMaterial = "M"
            loDetalleDocumento = New List(Of e_DetalleDocumento)
            loDetalleDocumento.AddRange(olDetalleDocumento.Listar(oeDetDoc))
            If loDetalleDocumento.Count = 0 Then
                Throw New Exception("Documento Asociado sin Detalles. Favor Verificar")
            End If
            For Each detdoc As e_DetalleDocumento In loDetalleDocumento
                detdoc.IdSubFamiliaMaterial = BuscarSubFamilia(detdoc.IdMaterialServicio)
                If detdoc.IdSubFamiliaMaterial = "" Then Throw New Exception("Material: " & detdoc.NombreMaterialServicio & " con SubFamilia Sin Cuenta Contable. Verificar")
            Next
            Dim loAuxCtaCtble, loAuxCtaCtble1, loAuxCtaCtble2 As New List(Of e_CtaCtbleSubFamiliaMat)
            Dim oeCtaCtbleSFM As New e_CtaCtbleSubFamiliaMat
            For Each ordmat As e_DetalleDocumento In loDetalleDocumento
                oeCtaCtbleSFM = New e_CtaCtbleSubFamiliaMat
                oeCtaCtbleSFM.IdSubFamilia = ordmat.IdSubFamiliaMaterial
                For Each oe As e_CtaCtbleSubFamiliaMat In loCtaCtbleSFam.Where(Function(i) i.Ejercicio = Periodo).ToList
                    With oeCtaCtbleSFM
                        If .IdSubFamilia = oe.IdSubFamilia Then
                            .IdCtaCtbleExistencias = oe.IdCtaCtbleExistencias
                            .NroCtaCtbleExistencias = oe.NroCtaCtbleExistencias
                            .CtaCtbleExistencias = oe.CtaCtbleExistencias
                            .IdCtaCtbleCompras = oe.IdCtaCtbleCompras
                            .CtaCtbleCompra = oe.CtaCtbleCompra
                            .NroCtaCtbleCompra = oe.NroCtaCtbleCompra
                            .IdCtaCtbleConsumo = oe.IdCtaCtbleConsumo
                            .CtaCtbleConsumo = oe.CtaCtbleConsumo
                            .NroCtaCtbleConsumo = oe.NroCtaCtbleConsumo
                            .IdItemGasto = oe.IdItemGasto
                            If ordmat.IndGravado Then
                                .TotalCuentas = (ordmat.Cantidad * ordmat.Precio) / (1 + oeIGVGlobal.Porcentaje)
                            Else
                                .TotalCuentas = ordmat.Cantidad * ordmat.Precio
                            End If
                            loAuxCtaCtble1.Add(oeCtaCtbleSFM)
                        End If
                    End With
                Next
            Next
            Dim IdSubFamilia As String = ""
            Dim ctactbleaux As New e_CtaCtbleSubFamiliaMat
            loAuxCtaCtble.AddRange(loAuxCtaCtble1.OrderBy(Function(item) item.IdSubFamilia).ToList)
            For Each ctactblesfm As e_CtaCtbleSubFamiliaMat In loAuxCtaCtble
                ctactbleaux = New e_CtaCtbleSubFamiliaMat
                If IdSubFamilia <> ctactblesfm.IdSubFamilia Then
                    IdSubFamilia = ctactblesfm.IdSubFamilia
                    With ctactbleaux
                        .IdCtaCtbleExistencias = ctactblesfm.IdCtaCtbleExistencias
                        .NroCtaCtbleExistencias = ctactblesfm.NroCtaCtbleExistencias
                        .CtaCtbleExistencias = ctactblesfm.CtaCtbleExistencias
                        .IdCtaCtbleCompras = ctactblesfm.IdCtaCtbleCompras
                        .CtaCtbleCompra = ctactblesfm.CtaCtbleCompra
                        .NroCtaCtbleCompra = ctactblesfm.NroCtaCtbleCompra
                        .IdCtaCtbleConsumo = ctactblesfm.IdCtaCtbleConsumo
                        .CtaCtbleConsumo = ctactblesfm.CtaCtbleConsumo
                        .NroCtaCtbleConsumo = ctactblesfm.NroCtaCtbleConsumo
                        .IdItemGasto = ctactblesfm.IdItemGasto
                        .TotalCuentas = loAuxCtaCtble.Where(Function(item) item.IdSubFamilia = IdSubFamilia).Sum(Function(item) item.TotalCuentas)
                    End With
                    loAuxCtaCtble2.Add(ctactbleaux)
                End If
            Next
            Dim IdCuenta As String = ""
            Dim loCtaCtbleSFamDoc As New List(Of e_CtaCtbleSubFamiliaMat)
            ctactbleaux = New e_CtaCtbleSubFamiliaMat
            loAuxCtaCtble = New List(Of e_CtaCtbleSubFamiliaMat)
            loAuxCtaCtble.AddRange(loAuxCtaCtble2.OrderBy(Function(item) item.IdCtaCtbleCompras).ToList)
            For Each ctactblesfm As e_CtaCtbleSubFamiliaMat In loAuxCtaCtble
                ctactbleaux = New e_CtaCtbleSubFamiliaMat
                If IdCuenta <> ctactblesfm.IdCtaCtbleCompras Then
                    IdCuenta = ctactblesfm.IdCtaCtbleCompras
                    With ctactbleaux
                        .IdCtaCtbleExistencias = ctactblesfm.IdCtaCtbleExistencias
                        .NroCtaCtbleExistencias = ctactblesfm.NroCtaCtbleExistencias
                        .CtaCtbleExistencias = ctactblesfm.CtaCtbleExistencias
                        .IdCtaCtbleCompras = ctactblesfm.IdCtaCtbleCompras
                        .CtaCtbleCompra = ctactblesfm.CtaCtbleCompra
                        .NroCtaCtbleCompra = ctactblesfm.NroCtaCtbleCompra
                        .IdCtaCtbleConsumo = ctactblesfm.IdCtaCtbleConsumo
                        .CtaCtbleConsumo = ctactblesfm.CtaCtbleConsumo
                        .NroCtaCtbleConsumo = ctactblesfm.NroCtaCtbleConsumo
                        .IdItemGasto = ctactblesfm.IdItemGasto
                    End With
                    loCtaCtbleSFamDoc.Add(ctactbleaux)
                End If
            Next
            Dim Total As Double = 0
            If oeMovDoc.IGV > 0 Then
                Total = Math.Round(oeMovDoc.SubTotal / loCtaCtbleSFamDoc.Count, 2)
            Else
                Total = Math.Round(oeMovDoc.Total / loCtaCtbleSFamDoc.Count, 2)
            End If
            For Each procta As e_CtaCtbleSubFamiliaMat In loCtaCtbleSFamDoc
                procta.TotalCuentas = Total
            Next
            Return loCtaCtbleSFamDoc
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function gf_InicioFinMes(ByVal ls_Tipo As String, ByVal ln_Anio As Integer, ByVal ln_Mes As Integer) As String
        Dim ld_Fecha As Date = Now.Date
        Try
            If ls_Tipo = "P" Then
                ld_Fecha = Date.Parse("01/" & ln_Mes.ToString & "/" & ln_Anio.ToString)
            Else
                ld_Fecha = DateSerial(ln_Anio, ln_Mes + 1, 0)
            End If
        Catch ex As Exception
            MessageBox.Show("Interrupcion en el Método:" & ex.TargetSite.Name & Environment.NewLine &
                 "Descripción:" & ex.Message & Environment.NewLine &
                 "Seguimiento:" & Environment.NewLine & ex.StackTrace,
                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return ld_Fecha
    End Function

    Public Function BuscarSubAlmacen_Ingreso(IdOrdenAsignacion As String) As String
        Try
            Dim oeSubAlmacenIngreso As New e_SubAlmacen
            Dim olSubAlmacen As New l_SubAlmacen
            oeSubAlmacenIngreso.TipoOperacion = "5"
            oeSubAlmacenIngreso.Activo = True
            oeSubAlmacenIngreso.IdOrdenAsignacion = IdOrdenAsignacion
            oeSubAlmacenIngreso = olSubAlmacen.Obtener(oeSubAlmacenIngreso)
            Return oeSubAlmacenIngreso.Id
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerDetalleAsignacion(IdMaterial As String, IdSubAlmacen As String) As DataSet
        Try
            Dim oeRegistroInv As New e_RegistroInventario
            Dim olRegistroInv As New l_RegistroInventario
            Dim Fecha As Date = ObtenerFechaServidor()
            oeRegistroInv.TipoOperacion = "S"
            oeRegistroInv.Fecha = Fecha
            oeRegistroInv.IdMaterial = IdMaterial
            oeRegistroInv.IdSubAlmacen = IdSubAlmacen
            oeRegistroInv.FechaInicio = Date.Parse("01/04/2014")
            Return olRegistroInv.ListarStock(oeRegistroInv)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerGrupoDsct(IdArea As String) As String
        Try
            Dim oeGrupoSancion As New e_GrupoSancion
            Dim olGrupoSancion As New l_GrupoSancion
            oeGrupoSancion.IdArea = IdArea
            oeGrupoSancion.IdEstado = "1CH00014"
            oeGrupoSancion = olGrupoSancion.ObtenerGrupoGenerado(oeGrupoSancion)
            If oeGrupoSancion.Id = "" Then
                Throw New Exception("Necesita Crear un Grupo de Sanciones para Generar Descuento")
            End If
            Return oeGrupoSancion.Id
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidaTDoc(oeDocumento As e_MovimientoDocumento) As Boolean
        Try
            If oeDocumento.FechaEmision.Date > ObtenerFechaServidor().Date Then Throw New Exception("No Puede Generar un Documento Mayor a la Fecha Actual")
            Dim Combo As New e_Combo
            Combo.Id = oeDocumento.IdTipoDocumento
            Combo.Tipo = 0
            If Not DocImpPublic.Contains(Combo) Then
                If oeDocumento.IGV > 0 Then
                    Throw New Exception("El Documento: " & oeDocumento.NombreDocumento & " No Tiene IGV")
                End If
            End If
            If oeDocumento.IdMoneda = "1CH02" Then If oeDocumento.Compra.CobraCajaChica = 1 Then Throw New Exception("Caja Chica Solo Paga en Soles")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListaRH(IdProveedor As String, FechaEmision As Date) As List(Of e_Combo)
        Try
            Dim oeHistorialRH As New e_Combo
            Dim olHistorialRH As New l_Combo
            Dim loHistorialRH As New List(Of e_Combo)
            oeHistorialRH.Nombre = "RHPROVEE"
            oeHistorialRH.Id = IdProveedor
            oeHistorialRH.Descripcion = FechaEmision.Date
            loHistorialRH = olHistorialRH.Listar(oeHistorialRH)
            Return loHistorialRH
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub ListaCtaCte()
        Try
            Dim oe As New e_CtaCte_ProAdq
            Dim ol As New l_CtaCte_ProAdq
            loCtaCteEmpresa = New List(Of e_CtaCte_ProAdq)
            oe.TipoOperacion = ""
            loCtaCteEmpresa.AddRange(ol.Listar(oe))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ObtenerDesdeSunat(Ruc As String) As e_Persona
        Try
            Dim strUrl As String = "https://e-consultaruc.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias?ruc="

            Dim request As WebRequest = WebRequest.Create(strUrl & Ruc)
            Dim response As WebResponse = request.GetResponse()
            Dim reader As New StreamReader(response.GetResponseStream())
            Dim res As String = reader.ReadToEnd()

            Dim xDat As String
            Dim xRazSoc As String, xEst As String, xCon As String, xDir As String

            xDat = res
            If Len(xDat) <= 635 Then
                Throw New Exception("El numero Ruc ingresado no existe en la Base de datos de la SUNAT")
            End If
            Dim xTabla() As String
            xDat = Replace(xDat, "     ", " ")
            xDat = Replace(xDat, "    ", " ")
            xDat = Replace(xDat, "   ", " ")
            xDat = Replace(xDat, "  ", " ")
            xDat = Replace(xDat, "( ", "(")
            xDat = Replace(xDat, " )", ")")

            xTabla = Split(xDat, "<small>")

            xTabla(1) = Replace(xTabla(1), "<b>N&#xFA;mero Ruc. </b> " & Ruc & " - ", "")
            xTabla(1) = Replace(xTabla(1), " <br/></small>", "")

            xTabla(4) = Replace(xTabla(4), "<b>Estado.</b>", "")
            xTabla(4) = Replace(xTabla(4), "</small><br/>", "")

            xTabla(7) = Replace(xTabla(7), "<b>Direcci&#xF3;n.</b><br/>", "")
            xTabla(7) = Replace(xTabla(7), "</small><br/>", "")

            xTabla(8) = Replace(xTabla(8), "Situaci&#xF3;n.<b> ", "")
            xTabla(8) = Replace(xTabla(8), "</b></small><br/>", "")

            xTabla(11) = Replace(xTabla(11), "<small><b>Tipo.</b><br/> ", "")
            xTabla(11) = Replace(xTabla(11), "</small><br/>", "")

            xTabla(12) = Replace(xTabla(12), "<small><b>DNI</b> : ", "")
            xTabla(12) = Replace(xTabla(12), "</small><br/>", "")

            xTabla(13) = Replace(xTabla(13), "<b>Fecha Nacimiento.</b> ", "")
            xTabla(13) = Replace(xTabla(13), "</small><br/>", "")

            xRazSoc = CStr(xTabla(1))
            xEst = CStr(xTabla(4))
            xDir = CStr(xTabla(7))
            xCon = CStr(xTabla(8))

            xRazSoc = Replace(xRazSoc, "&#209;", "Ñ")
            xRazSoc = Replace(xRazSoc, "&#xD1;", "Ñ")
            xRazSoc = Replace(xRazSoc, "&#193;", "Á")
            xRazSoc = Replace(xRazSoc, "&#201;", "É")
            xRazSoc = Replace(xRazSoc, "&#205;", "Í")
            xRazSoc = Replace(xRazSoc, "&#211;", "Ó")
            xRazSoc = Replace(xRazSoc, "&#218;", "Ú")
            xRazSoc = Replace(xRazSoc, "&#xC1;", "Á")
            xRazSoc = Replace(xRazSoc, "&#xC9;", "É")
            xRazSoc = Replace(xRazSoc, "&#xCD;", "Í")
            xRazSoc = Replace(xRazSoc, "&#xD3;", "Ó")
            xRazSoc = Replace(xRazSoc, "&#xDA;", "Ú")

            xRazSoc = Mid(xRazSoc, 1, Len(xRazSoc) - 3)

            xDir = Replace(xDir, "&#209;", "Ñ")
            xDir = Replace(xDir, "&#xD1;", "Ñ")
            xDir = Replace(xDir, "&#193;", "Á")
            xDir = Replace(xDir, "&#201;", "É")
            xDir = Replace(xDir, "&#205;", "Í")
            xDir = Replace(xDir, "&#211;", "Ó")
            xDir = Replace(xDir, "&#218;", "Ú")
            xDir = Replace(xDir, "&#xC1;", "Á")
            xDir = Replace(xDir, "&#xC9;", "É")
            xDir = Replace(xDir, "&#xCD;", "Í")
            xDir = Replace(xDir, "&#xD3;", "Ó")
            xDir = Replace(xDir, "&#xDA;", "Ú")

            xEst = Mid(xEst, 1, Len(xEst) - 6)
            xCon = Mid(xCon, 1, Len(xCon) - 3)
            xDir = Mid(xDir, 1, Len(xDir) - 3)
            'xFecNac = Mid(xFecNac, 1, Len(xFecNac) - 8)


            Dim oeEmpresa As New e_Persona
            oeEmpresa.Nombre = xRazSoc
            oeEmpresa.FechaNacimiento = Date.Parse("01/01/1901")
            oeEmpresa.Codigo = xEst 'estado
            oeEmpresa.ApellidoPaterno = xDir
            oeEmpresa.ApellidoMaterno = xCon 'situacion
            Return oeEmpresa
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarFechasPeriodo(FechaDocumento As Date, FechaPeriodo As Date) As Boolean
        Try
            If FechaPeriodo.Date.Year < FechaDocumento.Date.Year Then
                Throw New Exception("No Puede Enviar Documentos del Año: " & FechaDocumento.Date.Year & " al Año: " & FechaPeriodo.Date.Year)
            Else
                If FechaPeriodo.Date.Year = FechaDocumento.Date.Year Then
                    If FechaPeriodo.Date.Month < FechaDocumento.Date.Month Then
                        Throw New Exception("El Mes de Emision es Mayor al Periodo. No se puede Enviar la Compra")
                    End If
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidaFechaIngreso(FechaPeriodo As Date, IdDocumento As String) As Boolean
        Try
            Dim oeOrdDocGRR As New e_Orden_Documento
            Dim oeOrdDoc As New e_Orden_Documento
            Dim olOrdDoc As New l_Orden_Documento
            Dim lo As New List(Of e_Orden_Documento)
            oeOrdDoc.TipoOperacion = "E"
            oeOrdDoc.IdDocumento = IdDocumento
            lo = olOrdDoc.Listar(oeOrdDoc)
            For Each oe As e_Orden_Documento In lo
                oeOrdDocGRR.IdOrden = oe.IdOrden
                oeOrdDocGRR.TipoOperacion = "T"
                oeOrdDocGRR = olOrdDoc.Obtener(oeOrdDocGRR)
                If oeOrdDocGRR.IdDocumento = "" Then
                    Dim PeriodoOrden As String = CStr(oe.FechaCreacion.Month) + "/" + CStr(oe.FechaCreacion.Year)
                    If Year(oe.FechaCreacion) <> Year(FechaPeriodo) Then
                        Throw New Exception("El Documento debe estar en el Mismo Periodo que la Orden de Ingreso: " + PeriodoOrden)
                    End If
                    If Month(oe.FechaCreacion) <> Month(FechaPeriodo) Then
                        Throw New Exception("El Documento debe estar en el Mismo Periodo que la Orden de Ingreso: " + PeriodoOrden)
                    End If
                End If
            Next
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'lista validaciones actividades de negocio 
    Public Sub CargarActividadesRestringidas()
        Dim oeARUsuario = New e_ActividadRestringida_Usuario
        oeARUsuario.IdUsuario = gUsuarioSGI.Id
        oeARUsuario.TipoOperacion = "V"
        gUsuarioSGI.leARUsuario = lARUsuario.Listar(oeARUsuario)
    End Sub

#Region "Grillas Configuracion"


    Public Sub CalcularTotales(ByVal Grilla As UltraGrid, ByVal ParamArray aColumnas As String())
        With Grilla.DisplayLayout.Bands(0)
            .Summaries.Clear()
            .SummaryFooterCaption = "Totales:"
            For i As Integer = 0 To aColumnas.Length - 1
                For Each Colum As UltraGridColumn In .Columns
                    If aColumnas(i).Trim <> "" Then
                        If Colum.Key = aColumnas(i).ToString Then
                            Dim nomcol As String = aColumnas(i).ToString
                            .Summaries.Add("Sum" & nomcol, SummaryType.Sum, .Columns(nomcol))
                            If nomcol = "ValorReal" Then
                                .Summaries.Item("Sum" & nomcol).DisplayFormat = "{0:#,###,##0.000}"
                            Else
                                .Summaries.Item("Sum" & nomcol).DisplayFormat = "{0:#,###,##0.00}"
                            End If
                            .Summaries.Item("Sum" & nomcol).Appearance.TextHAlign = HAlign.Right
                            .Summaries.Item("Sum" & nomcol).Appearance.BackColor = Azul
                            .Summaries.Item("Sum" & nomcol).Appearance.ForeColor = Blanco
                            '.Summaries.Item("Sum" & nomcol).ToolTipText = "Super Mensaje"
                        End If
                    End If
                Next
            Next
        End With
        Grilla.DisplayLayout.Override.SummaryDisplayArea = SummaryDisplayAreas.BottomFixed
    End Sub

    Public Sub CalcularTotales_CierreTurno(ByVal Grilla As UltraGrid, ByVal ParamArray aColumnas As String())
        With Grilla.DisplayLayout.Bands(0)
            .Summaries.Clear()
            .SummaryFooterCaption = "Totales:"
            For i As Integer = 0 To aColumnas.Length - 1
                For Each Colum As UltraGridColumn In .Columns
                    If aColumnas(i).Trim <> "" Then
                        If Colum.Key = aColumnas(i).ToString Then
                            Dim nomcol As String = aColumnas(i).ToString
                            .Summaries.Add("Sum" & nomcol, SummaryType.Sum, .Columns(nomcol))
                            .Summaries.Item("Sum" & nomcol).Appearance.TextHAlign = HAlign.Right
                            .Summaries.Item("Sum" & nomcol).Appearance.BackColor = Azul
                            .Summaries.Item("Sum" & nomcol).Appearance.ForeColor = Blanco
                        End If
                    End If
                Next
            Next
        End With
        Grilla.DisplayLayout.Override.SummaryDisplayArea = SummaryDisplayAreas.BottomFixed
    End Sub

    Public Sub FormatoColumna(ByVal Grilla As UltraGrid, ByVal _formato As String, ByVal _estilo As UltraWinGrid.ColumnStyle _
                            , ByVal _alineacion As HAlign, ByVal ParamArray aColumnas As String())
        With Grilla.DisplayLayout.Bands(0)
            For i As Integer = 0 To aColumnas.Length - 1
                For Each Colum As UltraGridColumn In .Columns
                    If aColumnas(i).Trim <> "" Then
                        If Colum.Key = aColumnas(i).ToString Then
                            If _formato.Trim <> "" Then .Columns(aColumnas(i).ToString).Format = _formato
                            .Columns(aColumnas(i).ToString).Style = _estilo
                            .Columns(aColumnas(i).ToString).CellAppearance.TextHAlign = _alineacion
                        End If
                    End If
                Next
            Next
        End With
    End Sub

    Public Sub OcultarColumna(ByVal Grilla As UltraGrid, ByVal IndBand As Boolean, ByVal ParamArray aColumnas As String())
        With Grilla.DisplayLayout.Bands(0)
            For i As Integer = 0 To aColumnas.Length - 1
                For Each Colum As UltraGridColumn In .Columns
                    If aColumnas(i).Trim <> "" Then
                        If Colum.Key = aColumnas(i).ToString Then
                            .Columns(aColumnas(i).ToString).Hidden = IndBand
                        End If
                    End If
                Next
            Next
        End With
    End Sub

    Public Sub OcultarColumna2(ByVal Grilla As UltraGrid, ByVal IndBand As Boolean, ByVal ParamArray aColumnas As String())
        With Grilla.DisplayLayout.Bands(0)
            If Not IndBand Then
                For Each Colum As UltraGridColumn In .Columns
                    Colum.Hidden = True
                Next
            End If
            For i As Integer = 0 To aColumnas.Length - 1
                For Each Colum As UltraGridColumn In .Columns
                    If aColumnas(i).Trim <> "" Then
                        If Colum.Key = aColumnas(i).ToString Then
                            .Columns(aColumnas(i).ToString).Hidden = IndBand
                            If Not IndBand Then .Columns(aColumnas(i).ToString).Header.VisiblePosition = i
                        End If
                    End If
                Next
            Next
        End With
    End Sub

    Public Sub MostrarColumna(ByVal Grilla As UltraGrid, ByVal ParamArray aColumnas As String())
        For i As Integer = Grilla.DisplayLayout.Bands(0).Columns.Count - 1 To 0 Step -1
            Grilla.DisplayLayout.Bands(0).Columns(i).Hidden = False
        Next
    End Sub

    Public Sub ExcluirColumna(ByVal Grilla As UltraGrid, ByVal ParamArray aColumnas As String())
        With Grilla.DisplayLayout.Bands(0)
            For i As Integer = 0 To aColumnas.Length - 1
                For Each Colum As UltraGridColumn In .Columns
                    If aColumnas(i).Trim <> "" Then
                        If Colum.Key = aColumnas(i).ToString Then
                            .Columns(aColumnas(i).ToString).ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                        End If
                    End If
                Next
            Next
        End With
    End Sub

    Public Sub ColorFondoColumna(ByVal Grilla As UltraGrid, ByVal Color As System.Drawing.Color, ByVal ParamArray aColumnas As String())
        With Grilla.DisplayLayout.Bands(0)
            For i As Integer = 0 To aColumnas.Length - 1
                For Each Colum As UltraGridColumn In .Columns
                    If aColumnas(i).Trim <> "" Then
                        If Colum.Key = aColumnas(i).ToString Then
                            .Columns(aColumnas(i).ToString).CellAppearance.BackColor = Color
                        End If
                    End If
                Next
            Next
        End With
    End Sub

    Public Sub ColorFondoColumna2(ByVal Grilla As UltraGrid, ByVal BackColor As System.Drawing.Color, ByVal ForeColor As System.Drawing.Color, ByVal ParamArray aColumnas As String())
        With Grilla.DisplayLayout.Bands(0)
            For i As Integer = 0 To aColumnas.Length - 1
                For Each Colum As UltraGridColumn In .Columns
                    If aColumnas(i).Trim <> "" Then
                        If Colum.Key = aColumnas(i).ToString Then
                            .Columns(aColumnas(i).ToString).CellAppearance.BackColor = BackColor
                            .Columns(aColumnas(i).ToString).CellAppearance.ForeColor = ForeColor
                        End If
                    End If
                Next
            Next
        End With
    End Sub

    Public Sub CongelaColumna(ByVal Grilla As UltraGrid, ByVal ParamArray aColumnas As String())
        With Grilla.DisplayLayout
            .UseFixedHeaders = True
            .Override.FixedHeaderIndicator = FixedHeaderIndicator.None
            For i As Integer = 0 To aColumnas.Length - 1
                For Each Colum As UltraGridColumn In .Bands(0).Columns
                    If aColumnas(i).Trim <> "" Then
                        If Colum.Key = aColumnas(i).ToString Then
                            .Bands(0).Columns(aColumnas(i).ToString).Header.Fixed = True
                        End If
                    End If
                Next
            Next

        End With
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Grilla">Recipiente de Datos</param>
    ''' <param name="aColumnas">Nombre de las Columnas Separadas por coma</param>
    ''' <remarks></remarks>
    Public Sub ConfiguraGrilla(ByVal Grilla As UltraGrid, ByVal TipoLetra As String, IndFiltro As Boolean, Estilo As UIElementBorderStyle, ParamArray aColumnas As String())
        Dim Band As Boolean
        With Grilla
            If TipoLetra.Trim.Length = 0 Then TipoLetra = "Microsoft Sans Serif"
            .Font = New System.Drawing.Font(TipoLetra, 8.25!)
            .DisplayLayout.Override.BorderStyleCell = Estilo
            .DisplayLayout.Override.BorderStyleRow = Estilo
            .DisplayLayout.Override.HeaderClickAction = HeaderClickAction.SortSingle
            If IndFiltro Then
                Dim Filtro As New SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro
            End If
            If aColumnas.Length > 0 Then
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.Default
                .DisplayLayout.Override.CellClickAction = CellClickAction.Default
                For Each Colum In .DisplayLayout.Bands(0).Columns
                    Band = True
                    For i As Integer = 0 To aColumnas.Length - 1
                        If aColumnas(i).Trim <> "" Then
                            If Colum.Key = aColumnas(i).ToString Then
                                Colum.CellClickAction = CellClickAction.Edit
                                Colum.CellActivation = Activation.AllowEdit
                                Band = False
                                Exit For
                            End If
                        End If
                    Next
                    If Band Then
                        Colum.CellActivation = Activation.NoEdit
                        Colum.CellClickAction = CellClickAction.CellSelect
                    End If
                Next
            Else
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
            End If
            .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
            .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
            .DisplayLayout.MaxColScrollRegions = 1
            .DisplayLayout.MaxRowScrollRegions = 1
        End With
    End Sub

    '''Cadenas Html
    Public Function llenarTablaDemanda(ByVal idDemanda As String) As String
        'Azul 08298A
        'azul aciano #6495ED
        Dim estiloTh As String = "<th style='white-space: nowrap' text-align: left;vertical-align: top;border: 1px solid #000;border-collapse: collapse;padding: 0.3em;caption-side: bottom;>"
        Dim estiloTd As String = "<td style='white-space: nowrap' align='left' valign='top'>"
        Dim estiloLetra As String = "<tr align='left' valign='top'><td bgcolor='#6495ED'><FONT FACE='raro, arial' SIZE=2 COLOR='#ffffff'>"
        Dim estiloLetraDetalle As String = "<th style='white-space: nowrap' bgcolor='#045FB4'><FONT FACE='raro, arial' SIZE=1.3 COLOR='#ffffff'>"
        Dim estiloLetraSC As String = "<FONT FACE='raro, arial' SIZE=1.5>"
        Dim estiloLetraDetalleSC As String = "<td style='white-space: nowrap'><FONT FACE='raro, arial' SIZE=1>"
        Dim cadena As String = ""
        Dim olDemanda As New l_Demanda
        Dim oeDemanda As New e_Demanda
        Dim oeDemandaDetalle As New e_DemandaDetalle
        Dim olViajeTercero As New l_ViajesTerceros
        Dim oeContratoTercero As New e_ViajesTerceros
        Try
            If idDemanda.Length > 0 Then
                Dim RutaLugarDestino As New List(Of e_Ruta)
                oeDemanda = New e_Demanda
                oeDemanda.Id = idDemanda
                oeDemanda.TipoOperacion = "6"
                oeDemanda = olDemanda.Obtener(oeDemanda)
            End If

            Dim indicador As String = "Predemanda"
            Dim cancelar As String = ""
            cadena += "<table border='1' cellpadding='0' cellspacing='0'  >"
            cadena += estiloLetra + "Codigo</font></td><td>" & estiloLetraSC & CStr(oeDemanda.Codigo) & "</font></td></tr>"
            cadena += estiloLetra + "F.Atencion</font></td><td>" & estiloLetraSC & CStr(oeDemanda.FechaAtendida) & "</font></td></tr>"
            cadena += estiloLetra + "Cliente</font></td><td>" & estiloLetraSC & oeDemanda.Cliente & "</font></td></tr>"
            cadena += estiloLetra + "Zona</font></td><td>" & estiloLetraSC & oeDemanda.Zona & "</font></td></tr>"
            cadena += estiloLetra + "Ruta</font></td><td>" & estiloLetraSC & oeDemanda.Ruta & "</font></td></tr>"
            cadena += estiloLetra + "Tipo Vehiculo</font></td><td>" & estiloLetraSC & oeDemanda.TipoVehiculo & "</font></td></tr>"
            cadena += estiloLetra + "Estado</font></td><td>" & estiloLetraSC & oeDemanda.EstadoPredemanda & "</font></td></tr>"
            cadena += estiloLetra + "TotalFlete</font></td><td>" & estiloLetraSC & oeDemanda.TotalFlete.ToString("###,##0.0000") & "</font></td></tr>"
            cadena += estiloLetra + "T.Comision</font></td><td>" & estiloLetraSC & oeDemanda.Comision.ToString("###,##0.0000") & "</font></td></tr>"
            cadena += estiloLetra + "CargaMaterial</font></td><td>" & estiloLetraSC & oeDemanda.CargaMaterial & "</font></td></tr>"
            cadena += estiloLetra + "Observacion</font></td><td>" & estiloLetraSC & oeDemanda.Observacion & "</font></td></tr>"
            cadena += estiloLetra + "Escala</font></td><td>" & estiloLetraSC & oeDemanda.Escala & "</font></td></tr>"
            cadena += estiloLetra + "MotivoEscala</font></td><td>" & estiloLetraSC & oeDemanda.MotivoEscala & "</font></td></tr>"
            cadena += estiloLetra + "FechaCancelacion</font></td><td>" & estiloLetraSC & cancelar & "</font></td></tr>"
            cadena += estiloLetra + "Justificacion</font></td><td>" & estiloLetraSC & oeDemanda.Justificacion & "</font></td></tr>"
            If oeDemanda.Indicador = 2 Then
                indicador = "Demanda"
            End If
            cadena += estiloLetra + "Generado en</font></td><td>" & estiloLetraSC & indicador & "</font></td></tr>"
            cadena &= "</table></br></br>"
            oeDemandaDetalle.IdDemanda = oeDemanda.Id
            'detalle demanda
            cadena += "<CAPTION padding: 0.3em;color: #fff;background: #000;><EM>Detalles Predemanda</EM></CAPTION>"
            cadena += "<table border='1' cellpadding='0' cellspacing='0'  >" & vbCrLf
            cadena += "<tr align='left' valign='top'>"
            cadena += estiloLetraDetalle & "Cantidad</font></th>" & estiloLetraDetalle & "Programado</font></th>" &
                estiloLetraDetalle & "PorProgramar</font></th width='100px'>" & estiloLetraDetalle & "Cliente</font></th>" &
            estiloLetraDetalle & "TipoCarga</font></th>" & estiloLetraDetalle & "Material</font></th>" & estiloLetraDetalle & "Mon.</font></th>" & estiloLetraDetalle & "FleteUnitario</font></th>" & estiloLetraDetalle & "Subtotal</font></th>" &
            estiloLetraDetalle & "Flete</font></th>" & estiloLetraDetalle & "AdelantoFlete</font></th>" & estiloLetraDetalle & "Comision</th>" & estiloLetraDetalle & "Comisionista</th>" & estiloLetraDetalle & "Facturado</th>" &
        estiloLetraDetalle & "PagoContraE</font></th>" & estiloLetraDetalle & "Consolidado</font></th>" & estiloLetraDetalle & "I.C.Igv</th>" & estiloLetraDetalle & "motivoConsolidado</th>" & estiloLetraDetalle & "LugarOrigen</th>" &
        estiloLetraDetalle & "LugarDestino</font></th>" & estiloLetraDetalle & "Dir.Lugar Partida</font></th>" & estiloLetraDetalle & "Dir.Lugar Llegada</th>" & estiloLetraDetalle & "Cliente Final</th>"
            cadena += "</tr>"

            Dim listaDemandaDetalle As List(Of e_DemandaDetalle) = olDemanda.ListarDetalle(oeDemandaDetalle)
            Dim nombreComisionista As String = ComisionistasPublic.Item(0).ToString
            For Each obj As e_DemandaDetalle In listaDemandaDetalle
                cadena += "<tr align='left' valign='top'>"
                cadena += estiloLetraDetalleSC & CStr(obj.Cantidad) & "</font></td>" & estiloLetraDetalleSC & CStr(obj.Programado) & "</font></td>" & estiloLetraDetalleSC & CStr(obj.PorProgramar) & "</font></td>" & estiloLetraDetalleSC & obj.Cliente & "</font></td>" &
                    estiloLetraDetalleSC & obj.TipoCarga & "</font></td>" & estiloLetraDetalleSC & obj.Material & "</font></td>" & estiloLetraDetalleSC & devolverMoneda(obj.Moneda) & "</font></td>" & estiloLetraDetalleSC & CStr(obj.FleteUnitario) & "</font></td>" & estiloLetraDetalleSC & CStr(obj.Subtotal) & "</font></td>" &
              estiloLetraDetalleSC & CStr(obj.Flete) & "</font></td>" & estiloLetraDetalleSC & CStr(obj.AdelantoFlete) & "</font></td>" & estiloLetraDetalleSC & CStr(obj.Comision) & "</font></td>" & estiloLetraDetalleSC & devolverComisionista(obj.Comisionista) & "</font></td>" & estiloLetraDetalleSC & IIf(obj.Facturado, "Si", "No") & "</font></td>" &
              estiloLetraDetalleSC & IIf(obj.PagoContraEntrega, "Si", "No") & "</font></td>" & estiloLetraDetalleSC & CStr(obj.Consolidado) & "</font></td>" & estiloLetraDetalleSC & IIf(obj.IncluyeIGVConsolidado, "Si", "No") & "</font></td>" & estiloLetraDetalleSC & obj.MotivoConsolidado & "</font></td>" & estiloLetraDetalleSC & obj.DireccionOrigen & "</font></td>" &
               estiloLetraDetalleSC & obj.DireccionDestino & "</font></td>" & estiloLetraDetalleSC & obj.DireccionLugarPartida & "</font></td>" & estiloLetraDetalleSC & obj.DireccionLugarLlegada & "</font></td>" &
               estiloLetraDetalleSC & obj.ClienteFinal & "</font></td>"
                cadena += "</tr>"
            Next
            cadena += "</table>"
            oeContratoTercero.IdDemanda = oeDemanda.Id
            oeContratoTercero.TipoOperacion = "2"
            Dim listaTerceros As List(Of e_ViajesTerceros) = olViajeTercero.Listar(oeContratoTercero)
            If listaTerceros.Count > 0 Then
                'detalle viaje a terceros                
                cadena += "</br><table border='1' cellpadding='0' cellspacing='0' " & vbCrLf
                cadena += "<CAPTION padding: 0.3em;color: #fff;background: #fff;><EM>Detalles Viaje Tercero</EM></CAPTION>"
                cadena += "<tr align='left' valign='top'>"
                cadena += estiloLetraDetalle & "Tercero</font></th>" & estiloLetraDetalle & "Contacto</font></th>" & estiloLetraDetalle & "Comision</font></th>" & estiloLetraDetalle & "FleteUnitario</font></th>" &
            estiloLetraDetalle & "Igv</font></th>" & estiloLetraDetalle & "TotalFlete</font></th>" & estiloLetraDetalle & "Moneda</font></th>"
                cadena += "</tr>"

                For Each obj As e_ViajesTerceros In listaTerceros
                    cadena &= "<tr align='left' valign='top'>"
                    cadena &= estiloLetraDetalleSC & obj.IdTercero & "</font></td>" & estiloLetraDetalleSC & obj.IdContacto & "</font></td>" &
                        estiloLetraDetalleSC & CStr(obj.Comision) & "</font></td>" & estiloLetraDetalleSC & CStr(obj.FleteUnitario) & "</font></td>" &
                    estiloLetraDetalleSC & CStr(obj.Igv) & "</font></td>" & estiloLetraDetalleSC & CStr(obj.TotalFlete) & "</font></td>" & estiloLetraDetalleSC & obj.IdMoneda & "</font></td>"
                    cadena &= "</tr>"
                Next
                cadena &= "</table>"
            End If

        Catch ex As Exception
            Throw ex
        End Try

        Return cadena
    End Function

    Public Function devolverComisionista(ByVal codigo As String) As String
        For Each obj As e_Combo In ComisionistasPublic
            If obj.Id = codigo Then
                Return obj.Nombre
            End If
        Next
        Return ""
    End Function

    Public Function devolverMoneda(ByVal codigo As String) As String
        For Each obj As e_Combo In MonedaPublic
            If obj.Id = codigo Then
                Return obj.Nombre
            End If
        Next
        Return ""
    End Function

    '''Cadenas Html
    Public Function getFormatoDemanda(ByVal idDemanda As String, Optional ByVal frm As String = "D") As String
        'Azul 08298A
        'azul aciano #6495ED 045FB4
        Dim estiloTh As String = "<th style='white-space: nowrap' text-align: left;vertical-align: top;border: 1px solid #000;border-collapse: collapse;padding: 0.3em;caption-side: bottom;>"
        Dim estiloTd As String = "<td style='white-space: nowrap' align='left' valign='top'>"
        Dim estiloLetra As String = "<tr valign='top'><td style='border-right-color:#000099; border-right-style:solid; border-right-width:1.5px;' align='right'><font size='1.8' style='font-style: oblique; font-family:arial; color:#000000'>"
        Dim estiloLetraB As String = "<tr><td style='border-right-color:#000099; border-right-style:solid; border-right-width:1px;" +
            " border-top-color:#000099; border-top-style:solid; border-top-width:1px;' align='right'><font size='1.8' style='font-style: oblique; font-family:arial; color:#000000'>"
        Dim estiloLetraDetalle As String = "<th style='white-space: nowrap' bgcolor='#045FB4'><FONT FACE='raro, arial' SIZE=1.3 COLOR='#ffffff'>"
        Dim estiloLetraSC As String = "<td align='left'><FONT FACE='raro, arial' SIZE=1.5>"
        Dim estiloLetraSCB As String = "<td align='left' size='1.8' style='border-bottom-color:#000099; border-bottom-style:solid; border-bottom-width:1.5px;'><font size='2' style='font-style: oblique; font-family:arial; color:#045FB4'>"
        Dim estiloLetraSCBD As String = "<td align='right' size='1.8' style='border-bottom-color:#000099; border-bottom-style:solid; border-bottom-width:1.5px;'><font size='2' style='font-style: oblique; font-family:arial; color:#045FB4'>"
        Dim estiloLetraDetalleSC As String = "<td style='white-space: nowrap'><FONT FACE='raro, arial' SIZE=1>"
        Dim cadena As String = ""
        Dim olDemanda As New l_Demanda
        Dim oeDemanda As New e_Demanda
        Dim oeDemandaDetalle As New e_DemandaDetalle
        Dim olViajeTercero As New l_ViajesTerceros
        Dim oeContratoTercero As New e_ViajesTerceros
        Dim ContactosCarga As String = ""
        Dim ContactosDescarga As String = ""
        Dim TelfContactosCarga As String = ""
        Dim TelfContactosDescarga As String = ""
        Dim ClienteFinal As String = ""
        Dim Comisionista As String = ""
        Try
            If idDemanda.Length > 0 Then
                Dim RutaLugarDestino As New List(Of e_Ruta)
                oeDemanda = New e_Demanda
                oeDemanda.Id = idDemanda
                oeDemanda.TipoOperacion = "6"
                oeDemanda = olDemanda.Obtener(oeDemanda)
            End If
            oeDemandaDetalle.IdDemanda = oeDemanda.Id
            Dim oeCombo = New e_Combo
            oeCombo.Nombre = "Persona"
            PersonasPublic = New List(Of e_Combo)
            PersonasPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
            Dim listaDemandaDetalle As List(Of e_DemandaDetalle) = olDemanda.ListarDetalle(oeDemandaDetalle)
            For Each obj As e_DemandaDetalle In listaDemandaDetalle
                'lista contactos por cliente
                Dim listaCon As New List(Of e_Combo)
                Dim olContacto As New e_Combo
                olContacto.Nombre = "Contacto"
                olContacto.Id = obj.IdCliente
                listaCon.AddRange(olCombo.Listar(olContacto))

                If obj.IdContactoCarga.Trim <> "" Then
                    ContactosCarga = ContactosCarga + PersonasPublic.Where(Function(item) item.Id = obj.IdContactoCarga).ToList.Item(0).Nombre
                    TelfContactosCarga = TelfContactosCarga + listaCon.Where(Function(item) item.Id = obj.IdContactoCarga).ToList.Item(0).Extras(3)
                End If
                If obj.IdContactoDescarga.Trim <> "" Then
                    ContactosDescarga = ContactosDescarga + IIf(obj.IdContactoDescarga.Trim <> "", PersonasPublic.Where(Function(item) item.Id = obj.IdContactoDescarga).ToList.Item(0).Nombre + " ;", "")
                    TelfContactosDescarga = TelfContactosDescarga + listaCon.Where(Function(item) item.Id = obj.IdContactoDescarga).ToList.Item(0).Extras(3)
                End If
                If obj.IdClienteFinal.Trim <> "" Then
                    ClienteFinal = ClienteFinal + ClientesPublic.Where(Function(item) item.Id = obj.IdClienteFinal).ToList.Item(0).Nombre + " ;"
                End If
                If obj.Comisionista.Trim <> "" Then
                    Comisionista = Comisionista + " ;"
                End If
            Next
            'recarga comisionista
            Dim ComisionistasPublic = New List(Of e_Combo)
            oeCombo = New e_Combo
            oeCombo.Nombre = "Comisionistas"
            ComisionistasPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

            Dim indicador As String = "Predemanda"
            Dim cancelar As String = ""
            cadena += "<table cellpadding='0' cellspacing='0'>" & estiloLetraSCBD & "CLIENTE: </font></td>" & estiloLetraSCB & oeDemanda.Cliente & "</font></td></tr>"
            cadena += estiloLetra + "CODIGO:</font></td>" & estiloLetraSC & oeDemanda.Codigo & "</font></td></tr>"
            cadena += estiloLetra + "CLIENTE FINAL:</font></td>" & estiloLetraSC & ClienteFinal & "</font></td></tr>"
            cadena += estiloLetra + "CONTACTO CARGA:</font></td>" & estiloLetraSC & ContactosCarga & "</font></td></tr>"
            cadena += estiloLetra + "TELF CONTACTO CARGA:</font></td>" & estiloLetraSC & TelfContactosCarga & "</font></td></tr>"
            cadena += estiloLetra + "CONTACTO DE DESCARGA:</font></td>" & estiloLetraSC & ContactosDescarga & "</font></td></tr>"
            cadena += estiloLetra + "TELF CONTACTO DESCARGA:</font></td>" & estiloLetraSC & TelfContactosDescarga & "</font></td></tr>"
            cadena += estiloLetra + "TIPO DE CARGA:</font></td>" & estiloLetraSC & oeDemanda.CargaMaterial & "</font></td></tr>"
            cadena += estiloLetra + "TIPO DE UNIDAD:</font></td>" & estiloLetraSC & oeDemanda.TipoVehiculo & "</font></td></tr>"
            cadena += estiloLetra + "CANTIDAD DE UNIDADES:</font></td>" & estiloLetraSC & oeDemanda.NroUnidades & "</font></td></tr>"
            cadena += estiloLetra + "TM/VIAJE:</font></td>" & estiloLetraSC & listaDemandaDetalle.Sum(Function(item) item.Cantidad) & "</font></td></tr>"
            cadena += estiloLetra + "MANIPULEO:</font></td>" & estiloLetraSC & IIf(listaDemandaDetalle.Item(0).Cargar, "Carga = SI", "Carga = NO") & " " & IIf(listaDemandaDetalle.Item(0).Descarga, "Descarga = SI", "Descarga = NO") & "</font></td></tr>"
            cadena += estiloLetra + "FECHA Y HORA-CARGA:</font></td>" & estiloLetraSC & oeDemanda.FechaAtendida & "</font></td></tr>"
            cadena += estiloLetra + "FECHA Y HORA-DESCARGA:</font></td>" & estiloLetraSC & oeDemanda.FechaRecepcion & "</font></td></tr>"
            cadena += estiloLetra + "PTO CARGA:</font></td>" & estiloLetraSC & listaDemandaDetalle.Item(0).DireccionOrigen & "</font></td></tr>"
            cadena += estiloLetra + "PTO DESCARGA:</font></td>" & estiloLetraSC & listaDemandaDetalle.Item(0).DireccionDestino & "</font></td></tr>"
            cadena += estiloLetra + "TIPO DE PAGO:</font></td>" & estiloLetraSC & IIf(listaDemandaDetalle.Item(0).Facturado, "Facturado", "Pago ContraEntrega") & "</font></td></tr>"
            cadena += estiloLetra + "MONEDA:</font></td>" & estiloLetraSC & MonedaPublic.Where(Function(item) item.Id = listaDemandaDetalle.Item(0).Moneda).ToList.Item(0).Nombre & "</font></td></tr>"
            cadena += estiloLetra + "FLETE UNITARIO SIN IGV:</font></td>" & estiloLetraSC & listaDemandaDetalle.Sum(Function(item) item.FleteUnitario) & "</font></td></tr>"
            cadena += estiloLetra + "FLETE UNITARIO INC IGV:</font></td>" & estiloLetraSC & listaDemandaDetalle.Sum(Function(item) item.FleteUnitario + item.IGV) & "</font></td></tr>"
            cadena += estiloLetra + "FLETE TOTAL INC IGV:</font></td>" & estiloLetraSC & oeDemanda.TotalFlete.ToString("###,##0.0000") & "</font></td></tr>"
            cadena += estiloLetra + "ADELANTO DE FLETE:</font></td>" & estiloLetraSC & listaDemandaDetalle.Sum(Function(item) item.AdelantoFlete) & "</font></td></tr>"
            cadena += estiloLetra + "COMISION:</font></td>" & estiloLetraSC & listaDemandaDetalle.Sum(Function(item) item.Comision) & "</font></td></tr>"
            cadena += estiloLetra + "COMISIONISTA:</font></td>" & estiloLetraSC & IIf(listaDemandaDetalle.Item(0).Comisionista <> "", ComisionistasPublic.Where(Function(item) item.Id = listaDemandaDetalle.Item(0).Comisionista).ToList.Item(0).Nombre, "") & "</font></td></tr>"
            cadena += estiloLetra + "TELF COMISIONISTA:</font></td>" & estiloLetraSC & IIf(listaDemandaDetalle.Item(0).Comisionista <> "", ComisionistasPublic.Where(Function(item) item.Id = listaDemandaDetalle.Item(0).Comisionista).ToList.Item(0).Extras(3), "") & "</font></td></tr>"
            cadena += estiloLetra + "OBSERVACION:</font></td>" & estiloLetraSC & IIf(frm = "", oeDemanda.Observacion, oeDemanda.ObservacionPredemanda) & "</font></td></tr></table>"
        Catch ex As Exception
            Throw ex
        End Try
        Return cadena
    End Function

#End Region

    Public Sub MensajeConfirmacion()
        Try
            MessageBox.Show("Operación realizada con éxito", "ERP T&L", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#Region "Metodos para Validar"

    Private epError As New ErrorProvider

    ''' <summary>
    ''' Inicializa errores de los controles
    ''' </summary>
    ''' <param name="Formulario">Formulario para Validar</param>
    ''' <remarks></remarks>
    Public Sub gmt_InicializarError(ByVal Formulario As Form)
        For Each Control In Formulario.Controls
            mt_LimpiarErrorControl(Control)
        Next
    End Sub

    Private Sub mt_LimpiarErrorControl(ByVal control As Control)
        If control.Name.Length > 2 Then
            Select Case control.Name.Substring(0, 3).ToString
                Case "cbo", "cbg", "txt", "dec", "num", "opt", "fec"
                    epError.SetError(control, "")
            End Select
        End If
        For Each obj In control.Controls
            mt_LimpiarErrorControl(obj)
        Next
    End Sub

    ''' <summary>
    ''' Validar errores de varios controles, haciendo uso del ErrorProvider
    ''' </summary>
    ''' <param name="Formulario">Formulario para Validar</param>
    ''' <param name="aControl">Arreglo de Controles a validar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function gfc_ValidarError(ByVal Formulario As Form, ByVal ParamArray aControl As String()) As Boolean
        Try
            gmt_InicializarError(Formulario)
            Dim Ctrl As New Control
            For i As Integer = 0 To aControl.Length - 1
                If aControl(i).Trim <> "" Then
                    If Formulario.Controls.Find(aControl(i).Trim, True).Length = 0 Then Throw New Exception("No se Encuentra el Control: " & aControl(i).Trim)
                    Ctrl = Formulario.Controls.Find(aControl(i).Trim, True)(0)
                    Select Case aControl(i).Trim.Substring(0, 3)
                        Case "cbo"
                            Dim cbo As UltraWinEditors.UltraComboEditor = Ctrl
                            If cbo.SelectedIndex = -1 Then epError.SetError(cbo, "¡Seleccione " & cbo.Tag.trim & "!") : cbo.Focus() : Throw New Exception("¡Seleccione " & cbo.Tag.trim & "!")
                        Case "cbg"
                            Dim cbg As UltraWinGrid.UltraCombo = Ctrl
                            If IsNothing(cbg.SelectedRow) Then epError.SetError(cbg, "¡Seleccione " & cbg.Tag.trim & "!") : cbg.Focus() : Throw New Exception("¡Seleccione " & cbg.Tag.trim & "!")
                        Case "txt"
                            Dim txt As UltraWinEditors.UltraTextEditor = Ctrl
                            If txt.Text.Trim = "" Then epError.SetError(txt, "¡Ingrese " & txt.Tag.trim & "!") : txt.Focus() : Throw New Exception("¡Ingrese " & txt.Tag.trim & "!")
                        Case "num", "dec"
                            Dim num As UltraWinEditors.UltraNumericEditor = Ctrl
                            If num.Value = 0 Then epError.SetError(num, "¡Ingrese " & num.Tag.trim & "!") : num.Focus() : Throw New Exception("¡Ingrese " & num.Tag.trim & "!")
                        Case "opt"
                            Dim opt As UltraWinEditors.UltraOptionSet = Ctrl
                            If opt.CheckedIndex = -1 Then epError.SetError(opt, "¡Seleccione " & opt.Tag.trim & "!") : opt.Focus() : Throw New Exception("¡Seleccione " & opt.Tag.trim & "!")
                        Case "dtp"
                            Dim dtp As DateTimePicker = Ctrl
                            If dtp.Value.Date > ObtenerFechaServidor().Date Then Throw New Exception(dtp.Tag.trim & " debe ser menor o igual a:" & ObtenerFechaServidor().Date & "!")
                    End Select
                End If
            Next
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Valida errores de multiples controles haciendo uso del ErrorProvider
    ''' </summary>
    ''' <param name="Formulario">Formulario para Validar</param>
    ''' <param name="aControl">Arreglo de Controles a validar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function gfc_ValidarErrorMultiple(ByVal Formulario As Form, ByVal ParamArray aControl As String()) As Boolean
        Try
            gmt_InicializarError(Formulario)
            Dim Ctrl As New Control
            Dim indError As Boolean = False
            For i As Integer = 0 To aControl.Length - 1
                If aControl(i).Trim <> "" Then
                    If Formulario.Controls.Find(aControl(i).Trim, True).Length = 0 Then Throw New Exception("No se Encuentra el Control: " & aControl(i).Trim)
                    Ctrl = Formulario.Controls.Find(aControl(i).Trim, True)(0)
                    Select Case aControl(i).Trim.Substring(0, 3)
                        Case "cbo"
                            Dim cbo As UltraWinEditors.UltraComboEditor = Ctrl
                            If cbo.SelectedIndex = -1 Then epError.SetError(cbo, "¡Seleccione " & cbo.Tag.trim & "!") : If (indError = False) Then cbo.Focus() : indError = True
                        Case "cbg"
                            Dim cbg As UltraWinGrid.UltraCombo = Ctrl
                            If IsNothing(cbg.SelectedRow) Then epError.SetError(cbg, "¡Seleccione " & cbg.Tag.trim & "!") : If (indError = False) Then cbg.Focus() : indError = True
                        Case "txt"
                            Dim txt As UltraWinEditors.UltraTextEditor = Ctrl
                            If txt.Text.Trim = "" Then epError.SetError(txt, "¡Ingrese " & txt.Tag.trim & "!") : If (indError = False) Then txt.Focus() : indError = True
                        Case "num", "dec"
                            Dim num As UltraWinEditors.UltraNumericEditor = Ctrl
                            If num.Value = 0 Then epError.SetError(num, "¡Ingrese " & num.Tag.trim & "!") : If (indError = False) Then num.Focus() : indError = True
                        Case "opt"
                            Dim opt As UltraWinEditors.UltraOptionSet = Ctrl
                            If opt.CheckedIndex = -1 Then epError.SetError(opt, "¡Seleccione " & opt.Tag.trim & "!") : If (indError = False) Then opt.Focus() : indError = True
                        Case "dtp"
                            Dim dtp As DateTimePicker = Ctrl
                            If dtp.Value.Date > ObtenerFechaServidor().Date Then Throw New Exception(dtp.Tag.trim & " debe ser menor o igual a:" & ObtenerFechaServidor().Date & "!")
                    End Select
                End If
            Next
            If indError = True Then Throw New Exception("Ingrese los datos restantes")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Formulario">Formulario para Validar</param>
    ''' <param name="ls_Control">Control a Validar</param>
    ''' <param name="ls_Mensaje">Mensaje a Mostrar</param>
    ''' <remarks></remarks>
    Public Sub gmt_MostrarError(ByVal Formulario As Form, ByVal ls_Control As String, ByVal ls_Mensaje As String)
        gmt_InicializarError(Formulario)
        Dim Ctrl As New Control
        If ls_Control.Trim <> "" Then
            If Formulario.Controls.Find(ls_Control.Trim, True).Length = 0 Then Throw New Exception("No se Encuentra el Control: " & ls_Control.Trim)
            Ctrl = Formulario.Controls.Find(ls_Control.Trim, True)(0)
            Select Case ls_Control.Trim.Substring(0, 3)
                Case "cbo"
                    Dim cbo As UltraWinEditors.UltraComboEditor = Ctrl
                    epError.SetError(cbo, ls_Mensaje) : cbo.Focus() : Throw New Exception(ls_Mensaje)
                Case "txt"
                    Dim txt As UltraWinEditors.UltraTextEditor = Ctrl
                    epError.SetError(txt, ls_Mensaje) : txt.Focus() : Throw New Exception(ls_Mensaje)
                Case "num"
                    Dim num As UltraWinEditors.UltraNumericEditor = Ctrl
                    epError.SetError(num, ls_Mensaje) : num.Focus() : Throw New Exception(ls_Mensaje)
                Case "fec"
                    Dim fec As DateTimePicker = Ctrl
                    epError.SetError(fec, ls_Mensaje) : fec.Focus() : Throw New Exception(ls_Mensaje)
            End Select
        End If
    End Sub

#End Region

#End Region

    Private gControlExluidoEnter_Tab() As String
    Private frmEnter_Tab As System.Windows.Forms.Form

    Public Sub gmt_ConfigurarEventoKeyEnter_Tab(formulario As Form, ParamArray ControlesExcluidos() As String)
        gControlExluidoEnter_Tab = ControlesExcluidos
        frmEnter_Tab = formulario
        formulario.KeyPreview = True
        AddHandler formulario.KeyPress, AddressOf KeyPressEventHandler
    End Sub

    ' Eventos Generales

    Private Sub KeyPressEventHandler(sender As Object, e As KeyPressEventArgs)
        Try
            Dim ctrl As New Control
            ctrl = frmEnter_Tab.ActiveControl()
            If e.KeyChar = ChrW(Keys.Enter) Then
                For i = 0 To gControlExluidoEnter_Tab.Length - 1
                    If ctrl.Name.Contains(gControlExluidoEnter_Tab(i)) Then Exit Sub
                Next
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_SeleccionarTextoControl(sender As Object, e As EventArgs)
        If sender.GetType Is New Infragistics.Win.UltraWinEditors.UltraNumericEditor().GetType Then
            CType(sender, Infragistics.Win.UltraWinEditors.UltraNumericEditor).BeginInvoke(DirectCast(Sub() CType(sender, Infragistics.Win.UltraWinEditors.UltraNumericEditor).SelectAll(), Action))
        ElseIf sender.GetType Is New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit().GetType Then
            CType(sender, Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit).BeginInvoke(DirectCast(Sub() CType(sender, Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit).SelectAll(), Action))
        ElseIf sender.GetType Is New ISL.Controles.NumeroDecimal().GetType Then
            CType(sender, ISL.Controles.NumeroDecimal).BeginInvoke(DirectCast(Sub() CType(sender, ISL.Controles.NumeroDecimal).SelectAll(), Action))
        ElseIf sender.GetType Is New ISL.Controles.NumeroEntero().GetType Then
            CType(sender, ISL.Controles.NumeroEntero).BeginInvoke(DirectCast(Sub() CType(sender, ISL.Controles.NumeroEntero).SelectAll(), Action))
        ElseIf sender.GetType Is New ISL.Controles.Numero().GetType Then
            CType(sender, ISL.Controles.Numero).BeginInvoke(DirectCast(Sub() CType(sender, ISL.Controles.Numero).SelectAll(), Action))
        ElseIf sender.GetType Is New Infragistics.Win.UltraWinEditors.UltraTextEditor().GetType Then
            CType(sender, Infragistics.Win.UltraWinEditors.UltraTextEditor).SelectAll()
        End If
    End Sub

    Function gf_AsignarEventoSeleccionarTexto(lo_control As Control) As Control
        For Each Control As Object In lo_control.Controls
            If Control.GetType Is New Infragistics.Win.UltraWinEditors.UltraNumericEditor().GetType Then
                AddHandler CType(Control, Infragistics.Win.UltraWinEditors.UltraNumericEditor).Enter, AddressOf lr_SeleccionarTextoControl
            ElseIf Control.GetType Is New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit().GetType Then
                AddHandler CType(Control, Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit).Enter, AddressOf lr_SeleccionarTextoControl
            ElseIf Control.GetType Is New ISL.Controles.NumeroDecimal().GetType Then
                AddHandler CType(Control, ISL.Controles.NumeroDecimal).Enter, AddressOf lr_SeleccionarTextoControl
            ElseIf Control.GetType Is New ISL.Controles.NumeroEntero().GetType Then
                AddHandler CType(Control, ISL.Controles.NumeroEntero).Enter, AddressOf lr_SeleccionarTextoControl
            ElseIf Control.GetType Is New ISL.Controles.Numero().GetType Then
                AddHandler CType(Control, ISL.Controles.Numero).Enter, AddressOf lr_SeleccionarTextoControl
            ElseIf Control.GetType Is New Infragistics.Win.UltraWinEditors.UltraTextEditor().GetType Then
                AddHandler CType(Control, Infragistics.Win.UltraWinEditors.UltraTextEditor).GotFocus, AddressOf lr_SeleccionarTextoControl
            End If
            Control = gf_AsignarEventoSeleccionarTexto(Control)
        Next
        Return lo_control
    End Function

    ''' <summary>
    ''' Función que carga un OpenFileDialog con datos comunes para exportar archivos hacia Excel
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 
    Public Function gfc_CargaDatosOpenFileDialog() As OpenFileDialog
        Dim dialogo As New OpenFileDialog
        dialogo.Title = "Ingrese Nombre de Archivo"
        dialogo.Filter = "Archivos Excel 97-2003(*.xls)|*.xls|Archivos Excel 2007 (*.xlsx)|*.xlsx"
        dialogo.Multiselect = False
        dialogo.InitialDirectory = fc_DirectorioPorDefecto()
        dialogo.FileName = ""
        dialogo.RestoreDirectory = True
        Return dialogo
    End Function

    ''' <summary>
    ''' Invoca el Directorio o Carpeta por defecto de los documentos
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function fc_DirectorioPorDefecto() As String
        Dim directorio As String
        Try
            directorio = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            Directory.SetCurrentDirectory(directorio)
        Catch ex As System.IO.DirectoryNotFoundException
            directorio = "C:\\"
        End Try
        Return directorio
    End Function

    Public Sub gmt_BloquearEnter(e As KeyPressEventArgs)
        Try
            If e.KeyChar = Chr(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function gf_ValidarFilaSeleccionada(Grilla As Infragistics.Win.UltraWinGrid.UltraGrid) As Boolean
        Try
            If Not (Grilla.Selected.Rows.Count > 0 AndAlso Grilla.ActiveRow.Index >= 0) Then
                MessageBox.Show("Seleccione Fila", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function gf_ConvertirCadenaAlfanumerica(Cadena As String) As String
        Try
            Dim Resultado As String = ""
            For Each x In Cadena
                If Char.IsNumber(x) OrElse Char.IsWhiteSpace(x) OrElse Char.IsLetter(x) Then
                    Resultado += x
                Else
                    Resultado += " "
                End If
            Next
            Return Resultado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function gf_quitarSaltosLinea(ByVal texto As String, caracterReemplazar As String) As String
        Try
            gf_quitarSaltosLinea = Replace(Replace(texto, Chr(10), caracterReemplazar), Chr(13), caracterReemplazar)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function gf_getDTCentroPublic(Lista As List(Of e_Combo)) As DataTable
        Try
            Dim ds = New DataTable
            ds.Columns.Add("Id")
            ds.Columns.Add("Nombre")
            For Each item As e_Combo In Lista
                Dim newRow As DataRow = ds.NewRow()
                newRow("Id") = item.Descripcion
                newRow("Nombre") = item.Nombre
                ds.Rows.Add(newRow)
            Next
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function gf_getDTMonedaPublic(Lista As List(Of e_Combo)) As DataTable
        Try
            Dim ds = New DataTable
            ds.Columns.Add("Id")
            ds.Columns.Add("Nombre")
            For Each item As e_Combo In Lista
                Dim newRow As DataRow = ds.NewRow()
                newRow("Id") = item.Id
                newRow("Nombre") = item.Descripcion
                ds.Rows.Add(newRow)
            Next
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ConvertToDataTable(Of T)(ByVal list As List(Of T)) As DataTable
        Try
            Dim table As New DataTable()
            Dim properties() As PropertyInfo = GetType(T).GetProperties
            For Each p As PropertyInfo In properties
                table.Columns.Add(p.Name, p.PropertyType)
            Next
            For Each item As T In list
                Dim row As DataRow = table.NewRow()
                For Each p As PropertyInfo In properties
                    row(p.Name) = p.GetValue(item, Nothing)
                Next
                table.Rows.Add(row)
            Next
            Return table
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub ExportToExcel(ByVal dtTemp As DataTable, ByVal filepath As String)
        Try
            Dim strFileName As String = filepath
            If System.IO.File.Exists(strFileName) Then
                If (MessageBox.Show("Do you want to replace from the existing file?", "Export to Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes) Then
                    System.IO.File.Delete(strFileName)
                Else
                    Return
                End If

            End If
            Dim _excel As New Excel.Application
            Dim wBook As Excel.Workbook
            Dim wSheet As Excel.Worksheet

            wBook = _excel.Workbooks.Add()
            wSheet = wBook.ActiveSheet()

            Dim dt As System.Data.DataTable = dtTemp
            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0
            'If CheckBox1.Checked Then
            '    For Each dc In dt.Columns
            '        colIndex = colIndex + 1
            '        wSheet.Cells(1, colIndex) = dc.ColumnName
            '    Next
            'End If
            For Each dr In dt.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In dt.Columns
                    colIndex = colIndex + 1
                    wSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next
            wSheet.Columns.AutoFit()
            wBook.SaveAs(strFileName)

            ReleaseObject(wSheet)
            wBook.Close(False)
            ReleaseObject(wBook)
            _excel.Quit()
            ReleaseObject(_excel)
            GC.Collect()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Sub gmt_ControlBoton(Optional ByVal Consultar As Boolean = False _
                                , Optional ByVal Nuevo As Boolean = False _
                                , Optional ByVal Editar As Boolean = False _
                                , Optional ByVal Guardar As Boolean = False _
                                , Optional ByVal Cancelar As Boolean = False _
                                , Optional ByVal Eliminar As Boolean = False _
                                , Optional ByVal Imprimir As Boolean = False _
                                , Optional ByVal Exportar As Boolean = False _
                                , Optional ByVal Salir As Boolean = True)
        o_Botonera.Consultar = Consultar
        o_Botonera.Nuevo = Nuevo
        o_Botonera.Editar = Editar
        o_Botonera.Guardar = Guardar
        o_Botonera.Cancelar = Cancelar
        o_Botonera.Eliminar = Eliminar
        o_Botonera.Imprimir = Imprimir
        o_Botonera.Exportar = Exportar
        o_Botonera.Salir = Salir
        Botones(o_Botonera)
    End Sub



    Private Sub ReleaseObject(ByVal o As Object)
        Try
            While (System.Runtime.InteropServices.Marshal.ReleaseComObject(o) > 0)
            End While
        Catch
        Finally
            o = Nothing
        End Try
    End Sub

    Public Function GenerarCuotas(ByVal MontoPrestamo As Decimal, ByVal fecpre As Date, ByVal NunCuota As Integer, Optional InicioNumCuota As Integer = 0) As List(Of e_PrestamoDetalle)
        Try
            Dim oePrestamoDetalle As e_PrestamoDetalle
            Dim listaPrestamoDetalle As New List(Of e_PrestamoDetalle)
            If MontoPrestamo = 0 Then Throw New Exception("Ingrese Monto de Prestamo")
            Dim montoAux As Decimal = 0
            fecpre = fecpre.AddMonths(-1)
            Dim xa As Integer = 1
            For i As Integer = 1 To NunCuota
                fecpre = fecpre.AddMonths(xa)
                If xa = 0 Then
                    xa = 1
                Else
                    If fecpre.Month = 7 Or fecpre.Month = 12 Then
                        xa = 0
                    End If
                End If
                oePrestamoDetalle = New e_PrestamoDetalle
                oePrestamoDetalle.NroCuota = FormatoDocumento(i + InicioNumCuota, 3)
                oePrestamoDetalle.DobleMes = IIf(xa = 0, 1, 0)
                oePrestamoDetalle.TipoOperacion = "I"
                oePrestamoDetalle.UsuarioCreacion = gUsuarioSGI.Id
                oePrestamoDetalle.Anio = fecpre.Year
                oePrestamoDetalle.Mes = FormatoDocumento(fecpre.Month, 2)
                If NunCuota = i Then
                    oePrestamoDetalle.Importe = Math.Round(MontoPrestamo - montoAux, 2)
                Else
                    oePrestamoDetalle.Importe = Math.Round(MontoPrestamo / NunCuota, 2)
                End If
                montoAux = montoAux + oePrestamoDetalle.Importe
                listaPrestamoDetalle.Add(oePrestamoDetalle)
            Next
            Return listaPrestamoDetalle
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function CrearDTRecordVacaciones() As Data.DataTable
        Dim dtStruc As New Data.DataTable
        With dtStruc
            .Columns.Add(New Data.DataColumn("IdTrabajador", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("DNI", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("NombreCompleto", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaIngreso", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaCese", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("TotalVacaciones", Type.GetType("System.Int32")))
            .Columns.Add(New Data.DataColumn("VacacionesGozadas", Type.GetType("System.Int32")))
            .Columns.Add(New Data.DataColumn("VacacionesPendientes", Type.GetType("System.Int32")))
            .Columns.Add(New Data.DataColumn("VacacionesTruncas", Type.GetType("System.Int32")))
            .Columns.Add(New Data.DataColumn("IndEstado", Type.GetType("System.Int32")))
        End With
        Return dtStruc
    End Function

    Public Function CrearDTVacaciones() As Data.DataTable
        Dim dtStruc As New Data.DataTable
        With dtStruc
            .Columns.Add(New Data.DataColumn("IdTrabajador", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("DNI", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("NombreCompleto", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Cantidad", Type.GetType("System.Int32")))
            .Columns.Add(New Data.DataColumn("FechaInicio", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaFin", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Glosa", Type.GetType("System.String")))
        End With
        Return dtStruc
    End Function

    Public Function DevolverCadena(lo As List(Of e_OrdenMaterial)) As String
        Dim Retorno As String = ""
        Try
            Dim idAlmacen As String = ""
            For Each oe As e_OrdenMaterial In lo.Where(Function(i) i.IndPropio = True).OrderBy(Function(i) i.Almacen).ToList
                If idAlmacen <> oe.Almacen Then
                    idAlmacen = oe.Almacen
                    Retorno = Retorno + " " + idAlmacen
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
        Return Retorno.Replace("ALM. ", "").Trim
    End Function

#Region "Iconos"

    '-------------- Llenar Iconos ---------------------------------------------------------------------
    Public gLstIconos As New List(Of e_Icono)
    Private oeIcono As e_Icono

    Public Sub gmt_Iconos()
        Try
            Dim olDatosConfiguracion As New l_Configuracion

            'Dim strRuta1 As String = olDatosConfiguracion.RutaImagen() & "\Iconos\" '@0001
            Dim strRuta1 As String = Path.Combine(Application.StartupPath, "Imagenes") & "\Iconos\" '@0001
            oeIcono = New e_Icono : oeIcono.Nombre = "Agregar" : oeIcono.Ruta = strRuta1 & "agregar.png" : oeIcono.Icono = New Bitmap(oeIcono.Ruta) : gLstIconos.Add(oeIcono)
            oeIcono = New e_Icono : oeIcono.Nombre = "Modificar" : oeIcono.Ruta = strRuta1 & "modificar.png" : oeIcono.Icono = New Bitmap(oeIcono.Ruta) : gLstIconos.Add(oeIcono)
            oeIcono = New e_Icono : oeIcono.Nombre = "Quitar" : oeIcono.Ruta = strRuta1 & "quitar.png" : oeIcono.Icono = New Bitmap(oeIcono.Ruta) : gLstIconos.Add(oeIcono)
            oeIcono = New e_Icono : oeIcono.Nombre = "Grabar" : oeIcono.Ruta = strRuta1 & "guardar.png" : oeIcono.Icono = New Bitmap(oeIcono.Ruta) : gLstIconos.Add(oeIcono)
            oeIcono = New e_Icono : oeIcono.Nombre = "Cancelar" : oeIcono.Ruta = strRuta1 & "cancelar.png" : oeIcono.Icono = New Bitmap(oeIcono.Ruta) : gLstIconos.Add(oeIcono)
            oeIcono = New e_Icono : oeIcono.Nombre = "Buscar" : oeIcono.Ruta = strRuta1 & "buscar.png" : oeIcono.Icono = New Bitmap(oeIcono.Ruta) : gLstIconos.Add(oeIcono)
            oeIcono = New e_Icono : oeIcono.Nombre = "Extornar" : oeIcono.Ruta = strRuta1 & "extornar.png" : oeIcono.Icono = New Bitmap(oeIcono.Ruta) : gLstIconos.Add(oeIcono)
            oeIcono = New e_Icono : oeIcono.Nombre = "Grafico" : oeIcono.Ruta = strRuta1 & "grafico.png" : oeIcono.Icono = New Bitmap(oeIcono.Ruta) : gLstIconos.Add(oeIcono)
            oeIcono = New e_Icono : oeIcono.Nombre = "Aprobar" : oeIcono.Ruta = strRuta1 & "aprobar.png" : oeIcono.Icono = New Bitmap(oeIcono.Ruta) : gLstIconos.Add(oeIcono)
            oeIcono = New e_Icono : oeIcono.Nombre = "Agregar2" : oeIcono.Ruta = strRuta1 & "agregar2.png" : oeIcono.Icono = New Bitmap(oeIcono.Ruta) : gLstIconos.Add(oeIcono)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

#End Region

    Public Function CrearDTReporteFinalPlanilla() As Data.DataTable
        Dim uge_Exportar As New UltraGridExcelExporter


        Dim dtStruc As New Data.DataTable
        With dtStruc
            .Columns.Add(New Data.DataColumn("DNI", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("TRABAJADOR", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("GERENCIA", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("AREA", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("UNIDAD", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("CARGO", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("SECTOR", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("F. INGRESO", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("BASICO", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("REMUNERACION", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("ASIG_FAM", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("REMUN_VAC", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("CALIZA", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("BONO_PROD", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("SUBSIDIO", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("HORAS_EXTRAS", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("BONO COMBUSTIBLE PIURA", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("VUELTAS ADICIONALES PIURA", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("BONO JEFES CONVOY", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("VUELTAS ADICIONALES LIMA", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("COMP_VAC", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("BONO_RES", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("DESC_MED", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("SEMAFORO", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("MOVILIDAD", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("INGR_BRUTO", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("APOR_OBLIG", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("COMISI_AFP", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("SEGURO_AFP", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("ESSAL_VIDA", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("RENTA5TA", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("DSCTO_JUDI", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("ADE_SUELDO", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("ADEL_VAC", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("DSCTO_EPS", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("BIF", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("SCOTIABANK", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("DESC_FINAN", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("PACIFICO", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("RIMAC", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("TOT_DSCTO", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("TOTAL_NETO", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("BANCO", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("CUENTA", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("APORTE_SRS", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("SCTR_SAL", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("SENATI", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("SCTR_PEN", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("TOT_APORTE", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("GRATIF. 18.17%", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("VACAC. 8.33%", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("CTS. 8.33%", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("TOTAL APORTACIONES", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("TOTAL COSTO", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("VIATICOS LIMA", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("CALIZA SUSTENTO", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("ADMINISTRAT. CAJA", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("DIRECTORIO", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("OTROS", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("TOTAL CAJAS", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("NETO RECIBIDO", Type.GetType("System.Double")))



            '.Columns.Add(New Data.DataColumn("PIURA", Type.GetType("System.String")))
            '.Columns.Add(New Data.DataColumn("Cantidad", Type.GetType("System.Int32")))
            '.Columns.Add(New Data.DataColumn("FechaInicio", Type.GetType("System.String")))
            '.Columns.Add(New Data.DataColumn("FechaFin", Type.GetType("System.String")))
            '.Columns.Add(New Data.DataColumn("Glosa", Type.GetType("System.String")))
        End With
        Return dtStruc
    End Function

    'Public Function CrearDTResumenAsistencia() As Data.DataTable
    '    Dim uge_Exportar As New UltraGridExcelExporter
    '    Dim FechaInicial As Date = "23/04/2017"
    '    Dim FechaFinal As Date = "22/05/2017"
    '    Dim FechaAux As Date = "22/05/2017"

    '    Dim dtStruc As New Data.DataTable
    '    With dtStruc

    '        For I As Integer = 0 To DateDiff(DateInterval.Day, FechaFinal, FechaInicial)
    '            FechaAux = FechaInicial
    '            FechaAux.AddDays(I)

    '            .Columns.Add(New Data.DataColumn(DateAndTime.Day(FechaAux) & "/" & Month(FechaAux), Type.GetType("System.String")))
    '        Next

    '    End With
    '    Return dtStruc
    'End Function

#Region "Reglas de Comprobante de Pago"

    Public Function gfc_ValidarSerieDoc(ls_Serie As String, ls_CodigoTipo As String) As Boolean
        Dim ls_PrimerCaracter As String = String.Empty
        Dim ls_CadenaSobrante As String = String.Empty
        If ls_Serie.Length = 0 Then Throw New Exception("¡Ingrese Serie!")
        If ls_Serie.Trim.Length > 0 Then ls_PrimerCaracter = Left(ls_Serie.Trim, 1)
        If ls_Serie.Trim.Length > 1 Then ls_CadenaSobrante = Right(ls_Serie.Trim, Len(ls_Serie.Trim) - 1)
        Select Case ls_CodigoTipo
            Case "01", "02", "03", "07" : If ls_Serie.Trim.Length <> 4 Then Throw New Exception("Longitud de Serie debe ser 4")
            Case "05" : If ls_Serie.Trim.Length <> 1 Then Throw New Exception("Longitud de Serie debe ser 1")
            Case "53" : If ls_Serie.Trim.Length <> 3 Then Throw New Exception("Longitud de Serie debe ser 3")
            Case Else : If ls_Serie.Trim.Length > 20 Then Throw New Exception("Longitud de Serie debe ser hasta 20")
        End Select
        Select Case ls_CodigoTipo
            Case "01"
                If IsNumeric(ls_PrimerCaracter) Then
                    If Not Regex.IsMatch(ls_CadenaSobrante, "^\d*$") Then Throw New Exception("¡Formato Incorrecto para la Serie!" &
                        Environment.NewLine & "Númérico, si es físico, comenzando por 0000 y terminado con 9999." &
                        Environment.NewLine & "Revisar las Reglas Generales de la información de Comprobante de Pago y/o Documentos")
                Else
                    If ls_PrimerCaracter <> "E" And ls_PrimerCaracter <> "F" Then Throw New Exception("¡Formato Incorrecto para la Serie!" &
                        Environment.NewLine & "Alfanumérico, si es electrónico, la seríe debe ser E001 o FXXX (donde X es alfanumérico)." &
                        Environment.NewLine & "Revisar las Reglas Generales de la información de Comprobante de Pago y/o Documentos")
                    If ls_PrimerCaracter = "E" Then
                        If ls_CadenaSobrante <> "001" Then Throw New Exception("¡Formato Incorrecto para la Serie!" &
                        Environment.NewLine & "Alfanumérico, si es electrónico, la seríe debe ser E001 o FXXX (donde X es alfanumérico)." &
                        Environment.NewLine & "Revisar las Reglas Generales de la información de Comprobante de Pago y/o Documentos")
                    End If
                End If
            Case "02"
                If IsNumeric(ls_PrimerCaracter) Then
                    If Not Regex.IsMatch(ls_CadenaSobrante, "^\d*$") Then Throw New Exception("¡Formato Incorrecto para la Serie!" &
                       Environment.NewLine & "Numérico, comenzando por 0000 y terminado con 9999." &
                       Environment.NewLine & "Revisar las Reglas Generales de la información de Comprobante de Pago y/o Documentos")
                Else
                    If ls_PrimerCaracter & ls_CadenaSobrante <> "E001" Then Throw New Exception("¡Formato Incorrecto para la Serie!" &
                       Environment.NewLine & "Alfanumérico si el Comprobante de Pago (CdP) es electrónico, debe ser E001." &
                       Environment.NewLine & "Revisar las Reglas Generales de la información de Comprobante de Pago y/o Documentos")
                End If
            Case "03"
                If IsNumeric(ls_PrimerCaracter) Then
                    If Not Regex.IsMatch(ls_CadenaSobrante, "^\d*$") Then Throw New Exception("¡Formato Incorrecto para la Serie!" &
                       Environment.NewLine & "Numérico, comenzando por 0000 y terminado con 9999." &
                       Environment.NewLine & "Revisar las Reglas Generales de la información de Comprobante de Pago y/o Documentos")
                Else
                    If ls_PrimerCaracter <> "E" And ls_PrimerCaracter <> "B" Then Throw New Exception("¡Formato Incorrecto para la Serie!" &
                        Environment.NewLine & "Alfanumérico, si es electrónico, la seríe debe ser EB01 o BXXX (donde X es alfanumérico)." &
                        Environment.NewLine & "Revisar las Reglas Generales de la información de Comprobante de Pago y/o Documentos")
                    If ls_PrimerCaracter = "E" Then
                        If ls_CadenaSobrante <> "B01" Then Throw New Exception("¡Formato Incorrecto para la Serie!" &
                        Environment.NewLine & "Alfanumérico, si es electrónico, la seríe debe ser EB01 o BXXX (donde X es alfanumérico)." &
                        Environment.NewLine & "Revisar las Reglas Generales de la información de Comprobante de Pago y/o Documentos")
                    End If
                End If
            Case "05"
                If IsNumeric(ls_PrimerCaracter) Then
                    If CInt(ls_PrimerCaracter) < 1 Or CInt(ls_PrimerCaracter) > 5 Then Throw New Exception("¡Formato Incorrecto para la Serie!" &
                        Environment.NewLine & "Consignar Tipo de Boleto:" &
                        Environment.NewLine & "1= Boleto Manual" &
                        Environment.NewLine & "2= Boleto Automático" &
                        Environment.NewLine & "3= Boleto Electrónico" &
                        Environment.NewLine & "4= Otros" &
                        Environment.NewLine & "5= Anulado" &
                        Environment.NewLine & "Revisar las Reglas Generales de la información de Comprobante de Pago y/o Documentos")
                Else
                    Throw New Exception("¡Formato Incorrecto para la Serie!" &
                                        Environment.NewLine & "Numérico, comenzando por 1 y terminado con 5." &
                                        Environment.NewLine & "Revisar las Reglas Generales de la información de Comprobante de Pago y/o Documentos")
                End If
            Case "07"
                If IsNumeric(ls_PrimerCaracter) Then
                    If Not Regex.IsMatch(ls_CadenaSobrante, "^\d*$") Then Throw New Exception("¡Formato Incorrecto para la Serie!" &
                        Environment.NewLine & "Númérico, si es físico, comenzando por 0000 y terminado con 9999." &
                        Environment.NewLine & "Revisar las Reglas Generales de la información de Comprobante de Pago y/o Documentos")
                Else
                    If ls_PrimerCaracter <> "E" And ls_PrimerCaracter <> "F" And ls_PrimerCaracter <> "B" Then Throw New Exception("¡Formato Incorrecto para la Serie!" &
                        Environment.NewLine & "Alfanumérico, si es electrónico, la seríe debe ser E001 o EB01 o FXXX o BXXX (donde X es alfanumérico)." &
                        Environment.NewLine & "Revisar las Reglas Generales de la información de Comprobante de Pago y/o Documentos")
                    If ls_PrimerCaracter = "E" Then
                        If ls_CadenaSobrante <> "001" And ls_CadenaSobrante <> "B01" Then Throw New Exception("¡Formato Incorrecto para la Serie!" &
                        Environment.NewLine & "Alfanumérico, si es electrónico, la seríe debe ser E001 o EB01 o FXXX o BXXX (donde X es alfanumérico)." &
                        Environment.NewLine & "Revisar las Reglas Generales de la información de Comprobante de Pago y/o Documentos")
                    End If
                End If
            Case "53"
                If Not Regex.IsMatch(ls_PrimerCaracter & ls_CadenaSobrante, "^\d*$") Then Throw New Exception("¡Formato Incorrecto para la Serie!" &
                        Environment.NewLine & "Númérico, Validar con parámetros de la tabla 11. Codigo de la Aduana." &
                        Environment.NewLine & "Revisar las Reglas Generales de la información de Comprobante de Pago y/o Documentos")
            Case Else
                ' Sin Restricciones
        End Select
        Return True
    End Function

    Public Function gfc_ValidarNumeroDoc(ls_Numero As String, ls_CodigoTipo As String) As Boolean
        If ls_Numero.Length = 0 Then Throw New Exception("¡Ingrese Numero!")
        Select Case ls_CodigoTipo
            Case "01", "03", "07" : If ls_Numero.Trim.Length > 8 Then Throw New Exception("Longitud de Numero debe ser hasta 8")
            Case "02" : If ls_Numero.Trim.Length > 7 Then Throw New Exception("Longitud de Numero debe ser hasta 7")
            Case "05" : If ls_Numero.Trim.Length > 11 Then Throw New Exception("Longitud de Numero debe ser hasta 11")
            Case "53" : If ls_Numero.Trim.Length > 6 Then Throw New Exception("Longitud de Numero debe ser hasta 6")
            Case Else : If ls_Numero.Trim.Length > 20 Then Throw New Exception("Longitud de Numero debe ser hasta 20")
        End Select
        Select Case ls_CodigoTipo
            Case "01", "02", "03", "05", "07", "12", "16", "28", "37", "53"
                If Not Regex.IsMatch(ls_Numero, "^\d*$") Then Throw New Exception("¡Formato Incorrecto para el Número!" &
                    Environment.NewLine & "Numérico mayor a cero (0)." &
                    Environment.NewLine & "Revisar las Reglas Generales de la información de Comprobante de Pago y/o Documentos")
            Case "13", "14"

            Case Else
                ' Sin Restricciones
        End Select
        Return True
    End Function

    Public Function gfc_ObtieneLongitudSerie(ByVal ls_CodigoTipoDoc As String) As Integer
        Dim longitud As Integer = 0
        Select Case ls_CodigoTipoDoc
            Case "01", "02", "03", "07" : longitud = 4
            Case "05" : longitud = 1
            Case "53" : longitud = 3
            Case Else : longitud = 20
        End Select
        Return longitud
    End Function

    Public Function gfc_ObtieneLongitudNumero(ByVal ls_CodigoTipoDoc As String) As Integer
        Dim longitud As Integer = 0
        Select Case ls_CodigoTipoDoc
            Case "01", "03", "07" : longitud = 8
            Case "02" : longitud = 7
            Case "05" : longitud = 11
            Case "53" : longitud = 6
            Case Else : longitud = 20
        End Select
        Return longitud
    End Function

    Public Function gfc_ConcatenarCeros(ByVal ls_Texto As String, ByVal Longitud As Integer) As String
        Dim ln As String = ""
        Dim lenAux As Integer = Longitud
        If lenAux > 10 Then lenAux = Len(ls_Texto)
        For i As Integer = 1 To lenAux - Len(ls_Texto)
            ln = ln + "0"
        Next
        Return ln + ls_Texto
    End Function

    Public Function gfc_ObtenerFechaAsiento(ByVal ld_FechaDocumento As Date, ByVal ld_FechaFinPeriodo As Date) As Date
        Dim ld_FechaAsiento As Date = #1/1/1901#
        Dim fecServidor As Date = ObtenerFechaServidor().Date
        Dim fecDoc As Date = ld_FechaDocumento.Date
        Dim fecPeriodo As Date = ld_FechaFinPeriodo.Date
        ld_FechaAsiento = ld_FechaDocumento.Date
        If fecPeriodo <> "01/01/1901" Then
            If fecServidor > fecPeriodo Then
                If fecDoc > fecPeriodo Then
                    Throw New Exception("El Fecha del Comprobante de Pago esta fuera del Periodo")
                Else
                    ld_FechaAsiento = fecDoc
                End If
            Else
                ld_FechaAsiento = fecServidor
            End If
        End If
        Return ld_FechaAsiento
    End Function

#End Region

    Public Function RetornarDia(x As Integer) As String
        Dim dias() As String = {"Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado"}
        Return dias(x)
    End Function

    Public Function RetornarMes(x As Integer) As String
        Dim meses() As String = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Setiembre", "Octubre", "Noviembre", "Diciembre"}
        Return meses(x)
    End Function

    Public Sub gmt_ComboEspecifico(Combo As UltraWinEditors.UltraComboEditor, DataSource As Object, SelectedIndex As Integer, Optional Display As String = "Nombre")
        Combo.DataSource = DataSource
        Combo.DisplayMember = Display
        Combo.ValueMember = "Id"
        Combo.SelectedIndex = SelectedIndex
    End Sub

#Region "CPE - Jhonatan Maco"
    Public Function Deserializar_XmlStr(Obj As String) As DataTable
        Dim jsd As New System.Web.Script.Serialization.JavaScriptSerializer
        Dim Xml As String = jsd.DeserializeObject(Obj).ToString().Trim()
        Dim ds As New DataSet
        Dim xmlSR As System.IO.StringReader = New System.IO.StringReader(Xml)
        ds.ReadXml(xmlSR)
        Return ds.Tables(0)
    End Function

    Public Sub Registro_ComprobanteElectronico_Bath(dt_cpe As DataTable, tipo_oper As String, tipo_documento As String, dt_Det As DataTable)
        Try
            Dim oeComprobanteBath As e_ComprobanteElectronicoBath, olComprobanteBath As New l_ComprobanteElectronicoBath
            Dim oeComprobante As e_ComprobanteElectronico, olComprobante As l_ComprobanteElectronico
            Dim oeComprobanteBath_Det As e_ComprobanteElectronicoBath_Detalle, olComprobanteBath_Det As New l_ComprobanteElectronicoBath_Detalle
            Dim lst_BathDetalle As List(Of e_ComprobanteElectronicoBath_Detalle)
            Dim lst_Bath As List(Of e_ComprobanteElectronicoBath)
            Dim lst_Comprobante As List(Of e_ComprobanteElectronico)
            Dim item As Integer = 0
            Dim id As String = ""
            If tipo_documento = "RC" Or tipo_documento = "RR" Or tipo_documento = "RA" Then
                oeComprobanteBath = New e_ComprobanteElectronicoBath
                olComprobanteBath = New l_ComprobanteElectronicoBath
                With oeComprobanteBath
                    .TipoOperacion = ""
                    .Ticket = dt_cpe.Rows(0).Item("Ticket")
                    lst_Bath = New List(Of e_ComprobanteElectronicoBath)
                    lst_Bath = olComprobanteBath.Listar(oeComprobanteBath)
                    If lst_Bath.Count > 0 Then .Id = lst_Bath.Item(0).Id
                    If lst_Bath.Count > 0 Then
                        .xmlbase64 = lst_Bath.Item(0).xmlbase64
                        .FechaEnvio = lst_Bath.Item(0).FechaEnvio
                        .valorResumen = lst_Bath.Item(0).valorResumen
                        .Firma = lst_Bath.Item(0).Firma
                    Else
                        .xmlbase64 = dt_cpe.Rows(0).Item("xmlbase64")
                        .FechaEnvio = dt_cpe.Rows(0).Item("fechaEnvio")
                        .valorResumen = dt_cpe.Rows(0).Item("ValorResumen")
                        .Firma = dt_cpe.Rows(0).Item("Firma")
                    End If
                    .IndBaja = dt_cpe.Rows(0).Item("IndBaja")
                    .cdrxml = dt_cpe.Rows(0).Item("cdrXML")
                    .nombrexml = dt_cpe.Rows(0).Item("nombrexml")
                    .Estado = dt_cpe.Rows(0).Item("Estado")
                    .TipoReferencia = dt_cpe.Rows(0).Item("TipoReferencia")
                    .TipoOperacion = tipo_oper
                    .UsuarioCrea = gUsuarioSGI.Id
                End With
                If tipo_oper = "I" Then
                    lst_BathDetalle = New List(Of e_ComprobanteElectronicoBath_Detalle)
                    For Each det In dt_Det.Rows
                        item += 1
                        oeComprobanteBath_Det = New e_ComprobanteElectronicoBath_Detalle
                        With oeComprobanteBath_Det
                            .Item = item
                            .TipoOperacion = tipo_oper
                            .IdReferencia = det("id")
                            .UsuarioCrea = gUsuarioSGI.Id
                            .FechaCrea = Date.Now
                            .TipoReferencia = dt_cpe.Rows(0).Item("TipoReferencia")
                            If tipo_documento = "RC" Then
                                .IndBaja = IIf(det("condicion") = "1", 0, 1)
                            Else
                                .IndBaja = CType(dt_cpe.Rows(0).Item("IndBaja"), Boolean)
                            End If
                        End With
                        lst_BathDetalle.Add(oeComprobanteBath_Det)
                    Next
                    oeComprobanteBath.leDetalle = lst_BathDetalle
                End If
                olComprobanteBath.Guardar(oeComprobanteBath)
            Else
                oeComprobante = New e_ComprobanteElectronico
                olComprobante = New l_ComprobanteElectronico
                With oeComprobante
                    lst_Comprobante = New List(Of e_ComprobanteElectronico)
                    .IdReferencia = dt_cpe.Rows(0).Item("IdReferencia")
                    .cdrxml = ""
                    lst_Comprobante = olComprobante.Listar(oeComprobante)

                    .xmlbase64 = dt_cpe.Rows(0).Item("xmlbase64")
                    .cdrxml = dt_cpe.Rows(0).Item("cdrXML")
                    If lst_Comprobante.Count > 0 Then
                        .Id = lst_Comprobante.Item(0).Id
                        .valorcodbarras = IIf(tipo_oper <> "I", lst_Comprobante.Item(0).valorcodbarras, dt_cpe.Rows(0).Item("valorcodbarras"))
                        .valorcodqr = IIf(tipo_oper <> "I", lst_Comprobante.Item(0).valorcodqr, dt_cpe.Rows(0).Item("valorcodqr"))
                        .nombrexml = IIf(tipo_oper <> "I", lst_Comprobante.Item(0).nombrexml, dt_cpe.Rows(0).Item("nombrexml"))
                        .ValorResumen = IIf(tipo_oper <> "I", lst_Comprobante.Item(0).ValorResumen, dt_cpe.Rows(0).Item("ValorResumen"))
                        .Firma = IIf(tipo_oper <> "I", lst_Comprobante.Item(0).Firma, dt_cpe.Rows(0).Item("Firma"))
                    Else
                        .valorcodbarras = dt_cpe.Rows(0).Item("valorcodbarras")
                        .valorcodqr = dt_cpe.Rows(0).Item("valorcodqr")
                        .nombrexml = dt_cpe.Rows(0).Item("nombrexml")
                        .ValorResumen = dt_cpe.Rows(0).Item("ValorResumen")
                        .Firma = dt_cpe.Rows(0).Item("Firma")
                    End If


                    .TipoReferencia = dt_cpe.Rows(0).Item("TipoReferencia")
                    .TipoOperacion = tipo_oper
                    .EstadoElectronico = dt_cpe.Rows(0).Item("EstadoElectronico")
                    .UsuarioCrea = gUsuarioSGI.Id
                    .FechaCrea = Date.Now
                End With
                olComprobante.Guardar(oeComprobante)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

    Public Function SerieDocumento(IdTipoDocumento) As List(Of e_Combo)
        Try
            Dim oeserie = New e_Combo
            Dim ListaSerie = New List(Of e_Combo)
            oeserie.Id = IdTipoDocumento
            oeserie.Nombre = "SerieDocumento"
            oeserie.Descripcion = gUsuarioSGI.Id
            ListaSerie.AddRange(olCombo.Listar(oeserie))
            Return ListaSerie
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Module

