Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_MovimientoActivoFijo
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_MovimientoActivoFijo
        Try
            Dim oeMovimientoActivoFijo = New e_MovimientoActivoFijo( _
                             o_fila("Id").ToString _
                             , o_fila("IdActivoFijo").ToString _
                             , o_fila("IdUbicacionOrigen").ToString _
                             , o_fila("IdUbicacionDestino").ToString _
                             , o_fila("FechaTraslado").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString)
            Return oeMovimientoActivoFijo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMovimientoActivoFijo As e_MovimientoActivoFijo) As e_MovimientoActivoFijo

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_MovimientoActivoFijo_Listar", "", oeMovimientoActivoFijo.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeMovimientoActivoFijo = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeMovimientoActivoFijo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMovimientoActivoFijo As e_MovimientoActivoFijo) As List(Of e_MovimientoActivoFijo)
        Try
            Dim ldMovimientoActivoFijo As New List(Of e_MovimientoActivoFijo)
            Dim ds As DataSet
            With oeMovimientoActivoFijo
                ds = sqlhelper.ExecuteDataset("CON.Isp_MovimientoActivoFijo_Listar", "" _
                        , .Id _
                        , .IdActivoFijo _
                        , .IdUbicacionOrigen _
                        , .IdUbicacionDestino _
                        , .FechaTraslado _
                        , .Descripcion _
                        , .Activo _
                        , .FechaCreacion _
                        , .UsuarioCreacion)
            End With
            oeMovimientoActivoFijo = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeMovimientoActivoFijo = Cargar(o_Fila)
                ldMovimientoActivoFijo.Add(oeMovimientoActivoFijo)
            Next
            Return ldMovimientoActivoFijo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMovimientoActivoFijo As e_MovimientoActivoFijo) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeMovimientoActivoFijo
                sqlhelper.ExecuteNonQuery("CON.Isp_MovimientoActivoFijo_IAE", _
                                          .TipoOperacion, _
                                          .PrefijoID, _
                                        .Id _
                                        , .IdActivoFijo _
                                        , .IdUbicacionOrigen _
                                        , .IdUbicacionDestino _
                                        , .FechaTraslado _
                                        , .Descripcion _
                                        , .UsuarioCreacion)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeMovimientoActivoFijo As e_MovimientoActivoFijo) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_MovimientoActivoFijo_IAE", "E", _
             "", oeMovimientoActivoFijo.Id)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
