Imports ISL.EntidadesWCF
Imports System.Transactions

Public Class d_DistanciaZona

    Private sqlhelper As New SqlHelper

    Private Function Cargar(o_fila As DataRow) As e_DistanciaZona
        Try
            Dim oeDistanciaZona = New e_DistanciaZona(o_fila("Id").ToString, _
                                                      o_fila("IdRuta").ToString, _
                                                      o_fila("IdActividadNegocio").ToString, _
                                                      o_fila("IdCliente").ToString, _
                                                      o_fila("IdZona").ToString, _
                                                      o_fila("Distancia").ToString, _
                                                      o_fila("Observacion").ToString, _
                                                      o_fila("FechaInicio").ToString, _
                                                      o_fila("FechaFin").ToString, _
                                                      o_fila("Actual").ToString)
            Return oeDistanciaZona
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(oeDistanciaZona As e_DistanciaZona) As e_DistanciaZona
        Try
            Dim ds As DataSet
            With oeDistanciaZona
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_DistanciaZona_Listar]", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .IdRuta, _
                                              .IdActividadNegocio, _
                                              .IdCliente, _
                                              .IdZona, _
                                              .Actual)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeDistanciaZona = Cargar(ds.Tables(0).Rows(0))
            Else
                oeDistanciaZona = New e_DistanciaZona
            End If
            Return oeDistanciaZona
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeDistanciaZona As e_DistanciaZona) As List(Of e_DistanciaZona)
        Try
            Dim ldDistanciaZona As New List(Of e_DistanciaZona)
            Dim ds As DataSet
            With oeDistanciaZona
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_DistanciaZona_Listar]", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .IdRuta, _
                                              .IdActividadNegocio, _
                                              .IdCliente, _
                                              .IdZona, _
                                              .Actual)
            End With
            oeDistanciaZona = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDistanciaZona = Cargar(o_Fila)
                    ldDistanciaZona.Add(oeDistanciaZona)
                Next
            Else
                ldDistanciaZona = New List(Of e_DistanciaZona)
            End If
            Return ldDistanciaZona
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(oeDistanciaZona As e_DistanciaZona) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeDistanciaZona
                sqlhelper.ExecuteNonQuery("[OPE].[Isp_DistanciaZona_IAE]", _
                                          .TipoOperacion, _
                                         d_DatosConfiguracion.PrefijoID, _
                                         .Id, _
                                         .IdRuta, _
                                         .IdActividadNegocio, _
                                         .IdCliente, _
                                         .IdZona, _
                                         .Distancia, _
                                         .Observacion, _
                                         .FechaInicio, _
                                         .FechaFin, _
                                         .Actual)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(oeDistanciaZona As e_DistanciaZona) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[OPE].[Isp_DistanciaZona_IAE]", "E", "", oeDistanciaZona.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
