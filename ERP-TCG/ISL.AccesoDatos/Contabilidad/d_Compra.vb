Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Compra
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Compra
        Try
            Dim oeCompra = New e_Compra( _
                               o_fila("Id").ToString _
                         , o_fila("AnoEmisionAduana").ToString _
                         , o_fila("Base1") _
                         , o_fila("Igv1") _
                         , o_fila("Base2") _
                         , o_fila("Igv2") _
                         , o_fila("Base3") _
                         , o_fila("Igv3") _
                         , o_fila("Isc") _
                         , o_fila("OtrosTributos") _
                         , o_fila("IdMovimientoDocumento").ToString _
                         , o_fila("Activo") _
                         , o_fila("IdTipoCompra").ToString _
                         , o_fila("NoGravadas") _
                        , o_fila("Percepcion") _
                         , o_fila("Detraccion") _
                         , o_fila("Retencion") _
                         , o_fila("PercepcionPorc") _
                         , o_fila("DetraccionPorc") _
                         , o_fila("RetencionPorc") _
                         , o_fila("IdTipoPago").ToString _
                         , o_fila("IndTipoOperacion").ToString _
                        , o_fila("ImpRenta") _
                        , o_fila("Glosa").ToString _
                        , o_fila("CobraCajaChica").ToString _
                        , o_fila("IdMotivoDocumento").ToString _
                        , o_fila("IndDetraccion").ToString _
            )
            Return oeCompra
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCompra As e_Compra) As e_Compra

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_Compra_Listar", "", oeCompra.Id, 0, 0, 0, 0, 0, 0, 0, 0, 0, oeCompra.IdMovimientoDocumento)
            If ds.Tables(0).rows.Count > 0 Then
                oeCompra = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeCompra
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ObtenerConIdDocumento(ByVal oeCompra As e_Compra) As e_Compra

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_Compra_Listar", "", "" _
                , 0 _
                , 0 _
                , 0 _
                , 0 _
                , 0 _
                , 0 _
                , 0 _
                , 0 _
                , 0 _
                , oeCompra.IdMovimientoDocumento)
            If ds.Tables(0).Rows.Count > 0 Then
                oeCompra = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeCompra
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCompra As e_Compra) As List(Of e_Compra)
        Try
            Dim ldCompra As New List(Of e_Compra)
            Dim ds As DataSet
            With oeCompra
                ds = sqlhelper.ExecuteDataset("CON.Isp_Compra_Listar", "" _
                         , .Id _
                , .AnoEmisionAduana _
                , .Base1 _
                , .Igv1 _
                , .Base2 _
                , .Igv2 _
                , .Base3 _
                , .Igv3 _
                , .Isc _
                , .OtrosTributos _
                , .IdMovimientoDocumento _
                , .Activo _
                , .IdTipoCompra _
                , .NoGravadas _
                        )
            End With
            oeCompra = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCompra = Cargar(o_Fila)
                    ldCompra.Add(oeCompra)
                Next
            End If
            Return ldCompra
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCompra As e_Compra) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeCompra
                sqlhelper.ExecuteNonQuery("CON.Isp_Compra_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                           .Id _
                        , .AnoEmisionAduana _
                        , .Base1 _
                        , .Igv1 _
                        , .Base2 _
                        , .Igv2 _
                        , .Base3 _
                        , .Igv3 _
                        , .Isc _
                        , .OtrosTributos _
                        , .IdMovimientoDocumento _
                        , .Activo _
                        , .IdTipoCompra _
                        , .NoGravadas _
                        , .IdTipoPago _
                        , .Percepcion _
                        , .Detraccion _
                        , .Retencion _
                        , .PercepcionPorc _
                        , .DetraccionPorc _
                        , .RetencionPorc _
                        , .IndTipoOperacion _
                        , .ImpuestoRenta _
                        , .Glosa _
                        , .CobraCajaChica _
                        , .IdMotivoDocumento _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeCompra As e_Compra) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_Compra_IAE", "E", _
             "", oeCompra.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function UltimoIdInserta() As String
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "CON.Compra", d_DatosConfiguracion.PrefijoID)
            Return stResultado
        Catch ex As Exception
            Throw ex 
        End Try
    End Function

End Class
