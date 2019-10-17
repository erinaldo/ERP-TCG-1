'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions

Public Class d_ReporteDocumento

    Private sqlhelper As New SqlHelper

    Public Function Cargar(ByVal o_fila As DataRow) As e_ReporteDocumento
        Try
            Dim oeReporteDocumento = New e_ReporteDocumento( _
                             o_fila("IdTipoDoc").ToString _
                             , o_fila("TipoDoc").ToString _
                             , o_fila("Id").ToString _
                             , o_fila("Serie").ToString _
                             , o_fila("Numero").ToString _
                             , o_fila("FechaEmision") _
                             , o_fila("FechaVencimiento") _
                             , o_fila("IdCliente").ToString _
                             , o_fila("Cliente").ToString _
                             , o_fila("NroDocumento").ToString _
                             , o_fila("SubTotal") _
                             , o_fila("Igv") _
                             , o_fila("Total") _
                             , o_fila("Saldo") _
                             , o_fila("Detraccion") _
                             , o_fila("SaldoDetraccion") _
                             , o_fila("IdTipoMoneda").ToString _
                             , o_fila("TipoMoneda").ToString _
                             , o_fila("TipoCambio") _
                             , o_fila("IdEstadoDocumento").ToString _
                             , o_fila("EstadoDocumento").ToString _
                             , o_fila("Indicador").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("CadenaOperacion").ToString _
                             , o_fila("CadenaViaje").ToString _
            )

            oeReporteDocumento.IndElectronico = o_fila("IndElectronico").ToString
            oeReporteDocumento.EstadoDocumentoSunat = o_fila("EstadoElectronico").ToString

            Return oeReporteDocumento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CargarRCM(ByVal o_fila As DataRow) As e_ReporteClienteMensual
        Try
            Dim oeReporteCM = New e_ReporteClienteMensual( _
                             o_fila("IdTipoDoc").ToString _
                             , o_fila("TipoDoc").ToString _
                             , o_fila("IdCliente").ToString _
                             , o_fila("NroDoc").ToString _
                             , o_fila("Cliente").ToString _
                             , o_fila("Mes").ToString _
                             , o_fila("Total") _
                             )
            Return oeReporteCM
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeReporteDoc As e_ReporteDocumento) As List(Of e_ReporteDocumento)
        Try
            Dim leReporteDoc As New List(Of e_ReporteDocumento)
            Dim ds As DataSet
            With oeReporteDoc
                ds = sqlhelper.ExecuteDataset("[CON].[Isp_ReporteDocumentosVenta]", _
                                                 .IdTipoDoc _
                                                , ._Fechadesde _
                                                , ._FechaHasta _
                                                , .IdEstadoDocumento _
                                              )

            End With
            oeReporteDoc = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeReporteDoc = Cargar(o_Fila)
                    leReporteDoc.Add(oeReporteDoc)
                Next
            End If
            Return leReporteDoc
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarRCM(ByVal oeReporteCM As e_ReporteClienteMensual) As List(Of e_ReporteClienteMensual)
        Try
            Dim leReporteCM As New List(Of e_ReporteClienteMensual)
            Dim ds As DataSet
            With oeReporteCM
                ds = sqlhelper.ExecuteDataset("[CON].[Isp_ReporteClienteMensual_Listar]", _
                                                 .TipoOperacion _
                                                , .Anio _
                                                , .Mes _
                                              )

            End With
            oeReporteCM = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeReporteCM = CargarRCM(o_Fila)
                    leReporteCM.Add(oeReporteCM)
                Next
            End If
            Return leReporteCM
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
