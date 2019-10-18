'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_DocumentoRetencionDetalle

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_DocumentoRetencionDetalle
        Try
            Dim oeDocumentoRetencionDetalle = New e_DocumentoRetencionDetalle( _
                             o_fila("Id").ToString _
                             , o_fila("IdDocumentoRetencion").ToString _
                             , o_fila("FechaPago").ToString _
                             , o_fila("NroVoucher").ToString _
                             , o_fila("NumeroPago").ToString _
                             , o_fila("IdMovimientoDocumento").ToString _
                             , o_fila("IdProveedor").ToString _
                             , o_fila("TipoCambio").ToString _
                             , o_fila("MontoPagoOrigen").ToString _
                             , o_fila("MontoPagoSoles").ToString _
                             , o_fila("RetencionOrigen").ToString _
                             , o_fila("RetencionSoles").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaModifica").ToString _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeDocumentoRetencionDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDocumentoRetencionDetalle As e_DocumentoRetencionDetalle) As e_DocumentoRetencionDetalle

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_DocumentoRetencionDetalle_Listar", "", oeDocumentoRetencionDetalle.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeDocumentoRetencionDetalle = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDocumentoRetencionDetalle
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDocumentoRetencionDetalle As e_DocumentoRetencionDetalle) As List(Of e_DocumentoRetencionDetalle)
        Try
            Dim ldDocumentoRetencionDetalle As New List(Of e_DocumentoRetencionDetalle)
            Dim ds As DataSet
            With oeDocumentoRetencionDetalle
                ds = sqlhelper.ExecuteDataset("CON.Isp_DocumentoRetencionDetalle_Listar", "" _
                        , .Id _
                        , .IdDocumentoRetencion _
                        , .FechaPago _
                        , .NroVoucher _
                        , .NumeroPago _
                        , .IdMovimientoDocumento _
                        , .IdProveedor _
                        , .TipoCambio _
                        , .MontoPagoOrigen _
                        , .MontoPagoSoles _
                        , .Activo _
                         , .RetencionOrigen _
                        , .RetencionSoles _
                        )
            End With
            oeDocumentoRetencionDetalle = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeDocumentoRetencionDetalle = Cargar(o_Fila)
                ldDocumentoRetencionDetalle.Add(oeDocumentoRetencionDetalle)
            Next
            Return ldDocumentoRetencionDetalle
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDocumentoRetencionDetalle As e_DocumentoRetencionDetalle) As Boolean
        Try
            With oeDocumentoRetencionDetalle
                sqlhelper.ExecuteNonQuery("CON.Isp_DocumentoRetencionDetalle_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdDocumentoRetencion _
                        , .FechaPago _
                        , .NroVoucher _
                        , .NumeroPago _
                        , .IdMovimientoDocumento _
                        , .IdProveedor _
                        , .TipoCambio _
                        , .MontoPagoOrigen _
                        , .MontoPagoSoles _
                        , .RetencionOrigen _
                        , .RetencionSoles _
                        , .UsuarioCreacion _
                        , .UsuarioModifica _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDocumentoRetencionDetalle As e_DocumentoRetencionDetalle) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_DocumentoRetencionDetalle_IAE", "E", _
             "", oeDocumentoRetencionDetalle.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function ListarDoc(ByVal oeDocumentoRetencionDetalle As e_DocumentoRetencionDetalle) As List(Of e_MovimientoDocumento)
        Try
            Dim ldMovDoc As New List(Of e_MovimientoDocumento)
            Dim oeMovDoc As New e_MovimientoDocumento
            Dim odMovDoc As New d_MovimientoDocumento
            Dim ds As DataSet
            With oeDocumentoRetencionDetalle
                ds = sqlhelper.ExecuteDataset("CON.Isp_DocumentoRetencionDetalle_Listar", .TipoOperacion _
                        , .Id _
                        , .IdDocumentoRetencion _
                        , .FechaPago _
                        , .NroVoucher _
                        , .NumeroPago _
                        , .IdMovimientoDocumento _
                        , .IdProveedor _
                        , .TipoCambio _
                        , .MontoPagoOrigen _
                        , .MontoPagoSoles _
                        , .RetencionOrigen _
                        , .RetencionSoles _
                        , .Activo _
                        )
            End With
            oeMovDoc = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeMovDoc = odMovDoc.Cargar(o_Fila)
                ldMovDoc.Add(oeMovDoc)
            Next
            Return ldMovDoc
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
