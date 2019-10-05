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

Public Class d_Orden_Documento
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Orden_Documento
        Try
            Dim oeOrden_Documento = New e_Orden_Documento(o_fila("Id").ToString _
                             , o_fila("IdTipoDocumento").ToString _
                             , o_fila("IdDocumento").ToString _
                             , o_fila("IdTipoOrden").ToString _
                             , o_fila("IdOrden").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("IndConsignacion").ToString)
            Return oeOrden_Documento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerDoc(ByVal oeOrden_Doc As e_Orden_Documento) As e_MovimientoDocumento
        Try
            With oeOrden_Doc
                Dim ds As DataSet
                Dim oeMovimientoDocumento As New e_MovimientoDocumento
                ds = sqlhelper.ExecuteDataset("CMP.Isp_Orden_Documento_Listar", .TipoOperacion, _
                                              .Id, .IdTipoDocumento, .IdDocumento, .IdTipoOrden, _
                                              .IdOrden, .Activo)

                If ds.Tables(0).Rows.Count > 0 Then
                    Dim odMovDoc As New d_MovimientoDocumento
                    oeMovimientoDocumento = odMovDoc.Cargar(ds.Tables(0).Rows(0))
                End If

                Return oeMovimientoDocumento
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerDocGuiaRemision(ByVal oeOrden_Doc As e_Orden_Documento) As e_GuiaRemisionRemitente
        Try
            With oeOrden_Doc
                Dim ds As DataSet
                Dim oeGuiaRemision As New e_GuiaRemisionRemitente
                ds = sqlhelper.ExecuteDataset("CMP.Isp_Orden_Documento_Listar", .TipoOperacion, _
                                              .Id, .IdTipoDocumento, .IdDocumento, .IdTipoOrden, _
                                              .IdOrden, .Activo)

                If ds.Tables(0).Rows.Count > 0 Then
                    Dim odGuiaRem As New d_GuiaRemisionRemitente
                    oeGuiaRemision = odGuiaRem.Cargar(ds.Tables(0).Rows(0))
                End If

                Return oeGuiaRemision
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeOrden_Documento As e_Orden_Documento) As e_Orden_Documento

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CMP.Isp_Orden_Documento_Listar", oeOrden_Documento.TipoOperacion,
                                           oeOrden_Documento.Id, oeOrden_Documento.IdTipoDocumento,
                                           oeOrden_Documento.IdDocumento, oeOrden_Documento.IdTipoOrden, oeOrden_Documento.IdOrden)
            oeOrden_Documento = New e_Orden_Documento
            If ds.Tables.Count > 0 Then
                If ds.Tables(0).Rows.Count > 0 Then
                    oeOrden_Documento = Cargar(ds.Tables(0).Rows(0))
                End If
            End If

            Return oeOrden_Documento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeOrden_Documento As e_Orden_Documento) As List(Of e_Orden_Documento)
        Try
            Dim ldOrden_Documento As New List(Of e_Orden_Documento)
            Dim ds As DataSet
            With oeOrden_Documento
                ds = sqlhelper.ExecuteDataset("CMP.Isp_Orden_Documento_Listar" _
                                              , .TipoOperacion _
                                              , .Id _
                                              , .IdTipoDocumento _
                                              , .IdDocumento _
                                              , .IdTipoOrden _
                                              , .IdOrden _
                                              , .Activo _
                                              , .UsuarioCreacion _
                                              , .FechaCreacion
                                              )
            End With
            oeOrden_Documento = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeOrden_Documento = Cargar(o_Fila)
                    ldOrden_Documento.Add(oeOrden_Documento)
                Next
            End If
            Return ldOrden_Documento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeOrden_Documento As e_Orden_Documento) As Boolean
        Try
            With oeOrden_Documento
                sqlhelper.ExecuteNonQuery("CMP.Isp_Orden_Documento_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdTipoDocumento _
                        , .IdDocumento _
                        , .IdTipoOrden _
                        , .IdOrden _
                        , .Activo _
                        , .UsuarioCreacion
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class

