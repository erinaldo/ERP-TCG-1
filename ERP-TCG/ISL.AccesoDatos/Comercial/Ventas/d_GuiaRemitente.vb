Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_GuiaRemitente

    Private sqlhelper As New SqlHelper

    Public Function FormatoDocumento(ByVal TextoF As String, _
                            ByVal Cantidad As Integer) As String
        Dim ln As String = ""
        For i As Integer = 1 To Cantidad - Len(TextoF)
            ln = ln + "0"
        Next
        Return ln + TextoF
    End Function

    Private Function Cargar(ByVal o_fila As DataRow) As e_GuiaRemitente
        Try
            Dim oeGuiaRemitente = New e_GuiaRemitente( _
                             o_fila("Id").ToString _
                             , o_fila("Serie").ToString _
                             , o_fila("Numero").ToString _
                             , o_fila("IdGuiaTransportista").ToString _
                             , o_fila("GuiaTransportista").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Viaje").ToString _
                             , o_fila("Glosa").ToString)
            Return oeGuiaRemitente
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeGuiaRemitente As e_GuiaRemitente) As e_GuiaRemitente
        Try
            Dim ds As DataSet
            With oeGuiaRemitente
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_GuiaRemitente_Listar]", _
                                                         "", _
                                                         .Id, _
                                                         .Serie, _
                                                         .Numero, _
                                                         .IdRemitente, _
                                                         .IdGuiaTransportista, _
                                                         .IdViaje, _
                                                         .IdOperacion, _
                                                         .Activo)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeGuiaRemitente = Cargar(ds.Tables(0).Rows(0))
                Return oeGuiaRemitente
            Else
                oeGuiaRemitente = New e_GuiaRemitente
                Return oeGuiaRemitente
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGuiaRemitente As e_GuiaRemitente) As List(Of e_GuiaRemitente)
        Try
            Dim ldGuiaRemitente As New List(Of e_GuiaRemitente)
            Dim ds As DataSet
            With oeGuiaRemitente
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_GuiaRemitente_Listar]", "" _
                                                , .Id _
                                                , .Serie _
                                                , .Numero _
                                                , .IdRemitente _
                                                , .IdGuiaTransportista _
                                                , .IdViaje _
                                                , .IdOperacion _
                                                , .Activo)
            End With
            oeGuiaRemitente = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeGuiaRemitente = Cargar(o_Fila)
                    ldGuiaRemitente.Add(oeGuiaRemitente)
                Next
            Else
                ldGuiaRemitente = New List(Of e_GuiaRemitente)
            End If
            Return ldGuiaRemitente
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDS(ByVal oeGuiaRemitente As e_GuiaRemitente) As List(Of e_GuiaRemitente)
        Try
            Dim ldGuiaRemitente As New List(Of e_GuiaRemitente)
            Dim ds As DataSet
            With oeGuiaRemitente
                ds = sqlhelper.ExecuteDataset("OPE.Isp_OperacionDet_ListarDS" _
                                                , .TipoOperacion _
                                                , .IdOperacion _
                                                , .IdMovimientoDoc _
                                                , .Glosa)
            End With
            oeGuiaRemitente = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeGuiaRemitente = Cargar(o_Fila)
                    ldGuiaRemitente.Add(oeGuiaRemitente)
                Next
                Return ldGuiaRemitente
            Else
                ldGuiaRemitente = New List(Of e_GuiaRemitente)
                Return ldGuiaRemitente
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeGuiaRemitente As e_GuiaRemitente) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeGuiaRemitente
                sqlhelper.ExecuteNonQuery("[OPE].[Isp_GuiaRemitente_IAE]", _
                                          "I", _
                                          d_DatosConfiguracion.PrefijoID, _
                                            .Id _
                                            , FormatoDocumento(.Serie, 4) _
                                            , FormatoDocumento(.Numero, 10) _
                                            , .IdGuiaTransportista _
                                            , .Fecha _
                                            , .Activo _
                                            , .Glosa)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeGuiaRemitente As e_GuiaRemitente) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[OPE].[Isp_GuiaRemitente_IAE]", "E", _
                                        "", _
                                        oeGuiaRemitente.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
