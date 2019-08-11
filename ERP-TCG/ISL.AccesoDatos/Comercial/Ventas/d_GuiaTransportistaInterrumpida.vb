Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_GuiaTransportistaInterrumpida
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_GuiaTransportistaInterrumpida
        Try
            Dim oeGuiaTransportistaInterrumpida = New e_GuiaTransportistaInterrumpida( _
                             o_fila("Id").ToString _
                             , o_fila("IdSeguimiento").ToString _
                             , o_fila("IdGuiaTransportista").ToString _
                              , o_fila("GuiaTransportista").ToString _
                             , o_fila("IdMotivoTrasladoInterrumpido").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Viaje").ToString)
            Return oeGuiaTransportistaInterrumpida
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeGuiaTransportistaInterrumpida As e_GuiaTransportistaInterrumpida) As e_GuiaTransportistaInterrumpida

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[OPE].[Isp_GuiaTransportistaInterrumpido_Listar]", _
                                          "", _
                                          oeGuiaTransportistaInterrumpida.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeGuiaTransportistaInterrumpida = Cargar(ds.Tables(0).Rows(0))
                Return oeGuiaTransportistaInterrumpida
            Else
                oeGuiaTransportistaInterrumpida = New e_GuiaTransportistaInterrumpida
                Return oeGuiaTransportistaInterrumpida
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGuiaTransportistaInterrumpida As e_GuiaTransportistaInterrumpida) As List(Of e_GuiaTransportistaInterrumpida)
        Try
            Dim ldGuiaTransportistaInterrumpida As New List(Of e_GuiaTransportistaInterrumpida)
            Dim ds As DataSet
            With oeGuiaTransportistaInterrumpida
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_GuiaTransportistaInterrumpido_Listar]", "" _
                                            , .Id _
                                            , .IdSeguimiento _
                                            , .IdGuiaTransportista _
                                            , .IdOperacion _
                                            , .Activo)
            End With
            oeGuiaTransportistaInterrumpida = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeGuiaTransportistaInterrumpida = Cargar(o_Fila)
                    ldGuiaTransportistaInterrumpida.Add(oeGuiaTransportistaInterrumpida)
                Next
                Return ldGuiaTransportistaInterrumpida
            Else
                ldGuiaTransportistaInterrumpida = New List(Of e_GuiaTransportistaInterrumpida)
                Return ldGuiaTransportistaInterrumpida
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeGuiaTransportistaInterrumpida As e_GuiaTransportistaInterrumpida) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeGuiaTransportistaInterrumpida
                sqlhelper.ExecuteNonQuery("[OPE].[Isp_GuiaTransportistaInterrumpido_IAE]", _
                                             "I", _
                                            d_DatosConfiguracion.PrefijoID, _
                                            .Id _
                                            , .IdSeguimiento _
                                            , .IdGuiaTransportista _
                                            , .IdMotivoTrasladoInterrumpido _
                                            , .Glosa _
                                            , .Fecha _
                                            , .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeGuiaTransportistaInterrumpida As e_GuiaTransportistaInterrumpida) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[OPE].[Isp_GuiaTransportistaInterrumpido_IAE]", "E", _
                                            "", _
                                            oeGuiaTransportistaInterrumpida.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
