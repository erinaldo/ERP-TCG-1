Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_DocumentoVentaDetalle
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_DocumentoVentaDetalle
        Try
            Dim oeDocumentoVentaDetalle = New e_DocumentoVentaDetalle( _
                             o_fila("Id").ToString _
                             , o_fila("IdDocumentoVenta").ToString _
                             , o_fila("TipoReferencia").ToString _
                             , o_fila("IdReferencia").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("Cantidad").ToString _
                             , o_fila("Precio").ToString _
                             , o_fila("SubTotal").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeDocumentoVentaDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDocumentoVentaDetalle As e_DocumentoVentaDetalle) As e_DocumentoVentaDetalle

        Try
            Dim ds As New DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_DocumentoVentaDetalle_Listar", oeDocumentoVentaDetalle.TipoOperacion, oeDocumentoVentaDetalle.Id)
            oeDocumentoVentaDetalle = New e_DocumentoVentaDetalle
            If ds.Tables.Count > 0 Then
                oeDocumentoVentaDetalle = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDocumentoVentaDetalle
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDocumentoVentaDetalle As e_DocumentoVentaDetalle) As List(Of e_DocumentoVentaDetalle)
        Try
            Dim ldDocumentoVentaDetalle As New List(Of e_DocumentoVentaDetalle)
            Dim ds As DataSet
            With oeDocumentoVentaDetalle
                ds = sqlhelper.ExecuteDataset("TES.Isp_DocumentoVentaDetalle_Listar", oeDocumentoVentaDetalle.TipoOperacion _
                        , .Id _
                        , .IdDocumentoVenta _
                        , .TipoReferencia _
                        , .IdReferencia _
                        , .Activo _
                        )
            End With
            oeDocumentoVentaDetalle = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDocumentoVentaDetalle = Cargar(o_Fila)
                    ldDocumentoVentaDetalle.Add(oeDocumentoVentaDetalle)
                Next
                Return ldDocumentoVentaDetalle
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDocumentoVentaDetalle As e_DocumentoVentaDetalle) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeDocumentoVentaDetalle
                sqlhelper.ExecuteNonQuery("TES.Isp_DocumentoVentaDetalle_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdDocumentoVenta _
                        , .TipoReferencia _
                        , .IdReferencia _
                        , .Descripcion _
                        , .Cantidad _
                        , .Precio _
                        , .SubTotal _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDocumentoVentaDetalle As e_DocumentoVentaDetalle) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_DocumentoVentaDetalle_IAE", "E", _
             "", oeDocumentoVentaDetalle.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
