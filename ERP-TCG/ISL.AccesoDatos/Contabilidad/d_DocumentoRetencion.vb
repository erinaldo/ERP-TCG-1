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

Public Class d_DocumentoRetencion
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_DocumentoRetencion
        Try
            Dim oeDocumentoRetencion = New e_DocumentoRetencion( _
                             o_fila("Id").ToString _
                             , o_fila("IdTipoDocumento").ToString _
                             , o_fila("Serie").ToString _
                             , o_fila("Numero").ToString _
                             , o_fila("FechaEmision").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("IdAsientoMovimiento").ToString _
                             , o_fila("TipoDoc").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("IndElectronico").ToString _
                             , o_fila("IndEnviado").ToString _
                             , o_fila("IndAnulado").ToString _
                             , o_fila("Regimen").ToString _
                             , o_fila("Tasa").ToString _
                             , o_fila("Comentario").ToString _
                             , o_fila("IdMonedaRetencion").ToString _
                             , o_fila("TipoCambioRetencion").ToString _
                             , o_fila("ImporteRetencion").ToString _
                             , o_fila("IdMonedaPagado").ToString _
                             , o_fila("ImportePagado").ToString _
                             , o_fila("NroDocElectronico").ToString _
                             , o_fila("EstadoElectronico").ToString _
                             , o_fila("IndEmail").ToString _
                             , o_fila("IndExterno").ToString _
                             , o_fila("UsuarioCrea").ToString _
                             , o_fila("FechaCrea").ToString _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("FechaModifica").ToString _
                             , o_fila("IdProveedor").ToString _
            )
            Return oeDocumentoRetencion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDocumentoRetencion As e_DocumentoRetencion) As e_DocumentoRetencion

        Try
            Dim ds As DataSet
            With oeDocumentoRetencion
                ds = sqlhelper.ExecuteDataset("CON.Isp_DocumentoRetencion_Listar", .TipoOperacion,
            Left(.PrefijoID, 1), "", .Id, .IdTipoDocumento, .Serie, .Numero, .FechaEmision, .Activo, .IdAsientoMovimiento)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeDocumentoRetencion = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDocumentoRetencion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDocumentoRetencion As e_DocumentoRetencion) As List(Of e_DocumentoRetencion)
        Try
            Dim ldDocumentoRetencion As New List(Of e_DocumentoRetencion)
            Dim ds As DataSet
            With oeDocumentoRetencion
                ds = sqlhelper.ExecuteDataset("CON.Isp_DocumentoRetencion_Listar", .TipoOperacion _
                        , Left(.PrefijoID, 1), "" _
                        , .Id _
                        , .IdTipoDocumento _
                        , .Serie _
                        , .Numero _
                        , .FechaEmision _
                        , .Activo _
                        , .IdAsientoMovimiento _
                        , .FechaFin
                        )
            End With
            oeDocumentoRetencion = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDocumentoRetencion = Cargar(o_Fila)
                    ldDocumentoRetencion.Add(oeDocumentoRetencion)
                Next
            End If
            Return ldDocumentoRetencion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function UltimoDocRetencion(ByVal Serie As String) As String
        Try
            Dim stResultado() As String
            stResultado = sqlhelper.ExecuteScalar("CON.Isp_DocumentoRetencion_Listar", "U" _
                        , "", "" _
                        , "" _
                        , "" _
                        , Serie _
                        , "" _
                         ).ToString.Split("_")
            Return stResultado(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ImprimirDocumentoRetencion(ByVal IdRetencion As String) As DataTable
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_RetencionImprimir", IdRetencion)
            Return ds.Tables(0)

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByRef oeDocumentoRetencion As e_DocumentoRetencion) As Boolean
        Try
            Dim stResultado() As String
            With oeDocumentoRetencion
                stResultado = sqlhelper.ExecuteScalar("CON.Isp_DocumentoRetencion_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdTipoDocumento _
                        , .Serie _
                        , .Numero _
                        , .FechaEmision _
                        , .Activo _
                        , .IdAsientoMovimiento _
                        , .Voucher _
                        , .NombreTipoDoc _
                        , .IdEstado _
                        , .IndElectronico _
                        , .IndEnviado _
                        , .IndAnulado _
                        , .Regimen _
                        , .Tasa _
                        , .Comentario _
                        , .IdMonedaRetencion _
                        , .TipoCambioRetencion _
                        , .ImporteRetencion _
                        , .IdMonedaPagado _
                        , .ImportePagado _
                        , .NroDocElectronico _
                        , .EstadoElectronico _
                        , .IndEmail _
                        , .IndExterno _
                        , .UsuarioCrea _
                        , .UsuarioModifica _
                        , .IdProveedor
                    ).ToString.Split("_")
                oeDocumentoRetencion.Id = stResultado(0)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDocumentoRetencion As e_DocumentoRetencion) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_DocumentoRetencion_IAE", "E", _
             "", oeDocumentoRetencion.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function ObtenerRetencion(ByVal oeDocumentoRetencion As e_DocumentoRetencion) As DataSet
        Try
            Dim dsRetencion As DataSet
            With oeDocumentoRetencion
                dsRetencion = sqlhelper.ExecuteDataset("CON.Isp_DocumentoRetencion_Listar", .TipoOperacion, "", "", .Id, .IdTipoDocumento, .Serie, .Numero, .FechaEmision)
            End With
            Return dsRetencion
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
