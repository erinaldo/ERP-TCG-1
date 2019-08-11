Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_ReadecuacionActivoFijo
    Private sqlhelper As SqlHelper
    Private Function Cargar(Fila As DataRow) As e_ReadecuacionActivoFijo
        Try
            Dim oeReadecuacionActivoFijo = New e_ReadecuacionActivoFijo With {
                             .Id = Fila("Id").ToString() _
                             , .IdActivoFijo = Fila("IdActivoFijo").ToString() _
                             , .IdPeriodo = Fila("IdPeriodo").ToString() _
                             , .FechaReadecuacion = Fila("FechaReadecuacion") _
                             , .MontoInvertido = Fila("MontoInvertido") _
                             , .MontoAgregar = Fila("MontoAgregar") _
                             , .VidaUtilAgregar = Fila("VidaUtilAgregar") _
                             , .Observacion = Fila("Observacion").ToString() _
                             , .Actual = Fila("Actual") _
                             , .Activo = Fila("Activo") _
                             , .FechaCreacion = Fila("FechaCreacion") _
                             , .UsuarioCreacion = Fila("UsuarioCreacion").ToString() _
                             , .FechaModificacion = Fila("FechaModificacion") _
                             , .UsuarioModificacion = Fila("UsuarioModificacion").ToString() _
                             , .Periodo = Fila("Periodo").ToString() _
                             , .ValorResidualAgregar = Fila("ValorResidualAgregar") _
            }
            Return oeReadecuacionActivoFijo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ExecuteLST(oeReadecuacionActivoFijo As e_ReadecuacionActivoFijo) As DataSet
        Try
            sqlhelper = New SqlHelper
            Dim ds As DataSet
            With oeReadecuacionActivoFijo
                ds = sqlhelper.ExecuteDataset("[CON].[Isp_ReadecuacionActivoFijo_Listar]" _
                        , .TipoOperacion _
                        , .Id _
                        , .IdActivoFijo _
                        , .IdPeriodo _
                        , .FechaReadecuacion _
                        , .MontoInvertido _
                        , .MontoAgregar _
                        , .VidaUtilAgregar _
                        , .Observacion _
                        , .Actual _
                        , .Activo _
                        )
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(oeReadecuacionActivoFijo As e_ReadecuacionActivoFijo) As e_ReadecuacionActivoFijo
        Try
            Dim ds As DataSet = ExecuteLST(oeReadecuacionActivoFijo)
            If ds.Tables(0).rows.Count > 0 Then
                oeReadecuacionActivoFijo = Cargar(ds.Tables(0).Rows(0))
            Else
                oeReadecuacionActivoFijo = New e_ReadecuacionActivoFijo
            End If
            Return oeReadecuacionActivoFijo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeReadecuacionActivoFijo As e_ReadecuacionActivoFijo) As List(Of e_ReadecuacionActivoFijo)
        Try
            Dim lstReadecuacionActivoFijo As New List(Of e_ReadecuacionActivoFijo)
            Dim ds As DataSet = ExecuteLST(oeReadecuacionActivoFijo)
            oeReadecuacionActivoFijo = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeReadecuacionActivoFijo = Cargar(o_Fila)
                    lstReadecuacionActivoFijo.Add(oeReadecuacionActivoFijo)
                Next
            End If
            Return lstReadecuacionActivoFijo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(oeReadecuacionActivoFijo As e_ReadecuacionActivoFijo) As Boolean
        Try
            Using transScope As New TransactionScope()
                sqlhelper = New SqlHelper
                Dim d_DatosConfiguracion As New d_DatosConfiguracion
                Dim ldReadecuacionAFDoc As New d_ReadecuacionAF_Documento
                Dim IdResultado As String
                With oeReadecuacionActivoFijo
                    IdResultado = sqlhelper.ExecuteScalar("[CON].[Isp_ReadecuacionActivoFijo_IAE]" _
                            , .TipoOperacion _
                            , d_DatosConfiguracion.PrefijoID _
                            , .Id _
                            , .IdActivoFijo _
                            , .IdPeriodo _
                            , .FechaReadecuacion _
                            , .MontoInvertido _
                            , .MontoAgregar _
                            , .VidaUtilAgregar _
                            , .Observacion _
                            , .Actual _
                            , .Activo _
                            , .UsuarioCreacion _
                            , .ValorResidualAgregar _
                        ).ToString()
                    .Id = IdResultado
                    For Each ReadecAFDoc As e_ReadecuacionAF_Documento In .ListReadecuacionAFDoc
                        With ReadecAFDoc
                            .UsuarioCreacion = oeReadecuacionActivoFijo.UsuarioCreacion
                            If .TipoOperacion = "E" Then
                                ldReadecuacionAFDoc.Eliminar(ReadecAFDoc)
                            Else
                                .TipoOperacion = "I"
                                ReadecAFDoc.IdReadecuacionActivoFijo = oeReadecuacionActivoFijo.Id
                                ldReadecuacionAFDoc.Guardar(ReadecAFDoc)
                            End If
                        End With
                    Next
                End With
                transScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(oeReadecuacionActivoFijo As e_ReadecuacionActivoFijo) As Boolean
        Try
            sqlhelper = New SqlHelper
            With oeReadecuacionActivoFijo
                sqlhelper.ExecuteNonQuery("[CON].[Isp_ReadecuacionActivoFijo_IAE]" _
                       , "E" _
                       , "" _
                       , .Id _
                       , .IdActivoFijo _
                       , .IdPeriodo _
                       , .FechaReadecuacion _
                       , .MontoInvertido _
                       , .MontoAgregar _
                       , .VidaUtilAgregar _
                       , .Observacion _
                       , .Actual _
                       , .Activo _
                       , .UsuarioCreacion _
                       , .ValorResidualAgregar _
                   )

            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
