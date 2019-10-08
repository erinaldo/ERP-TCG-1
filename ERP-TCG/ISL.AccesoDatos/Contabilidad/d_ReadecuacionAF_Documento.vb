'Imports System.Transactions
Imports ISL.EntidadesWCF

Public Class d_ReadecuacionAF_Documento
    Private sqlhelper As New SqlHelper
    Private Function Cargar(Fila As DataRow) As e_ReadecuacionAF_Documento
        Try
            Dim oeReadecuacionAF_Documento = New e_ReadecuacionAF_Documento With {
                             .Id = Fila("Id").ToString() _
                             , .IdReadecuacionActivoFijo = Fila("IdReadecuacionActivoFijo").ToString() _
                             , .IdDocumento = Fila("IdDocumento").ToString() _
                             , .Glosa = Fila("Glosa").ToString() _
                             , .UsuarioCreacion = Fila("UsuarioCreacion").ToString() _
                             , .FechaCreacion = Fila("FechaCreacion") _
                             , .UsuarioModificacion = Fila("UsuarioModificacion").ToString() _
                             , .FechaModificacion = Fila("FechaModificacion") _
                             , .Activo = Fila("Activo") _
                             , .IndTipoDoc = Fila("IndTipoDoc") _
                             , .Serie = Fila("Serie").ToString() _
                             , .Numero = Fila("Numero").ToString() _
                             , .IdTipoDocumento = Fila("IdTipoDocumento").ToString() _
            }
            Return oeReadecuacionAF_Documento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ExecuteLST(oeReadecuacionAF_Documento As e_ReadecuacionAF_Documento) As DataSet
        Try
            sqlhelper = New SqlHelper
            Dim ds As DataSet
            With oeReadecuacionAF_Documento
                ds = sqlhelper.ExecuteDataset("[CON].[Isp_ReadecuacionAF_Documento_Listar]" _
                        , .TipoOperacion _
                        , .Id _
                        , .IdReadecuacionActivoFijo _
                        , .IdDocumento _
                        , .Glosa _
                        , .Activo _
                        )
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(oeReadecuacionAF_Documento As e_ReadecuacionAF_Documento) As e_ReadecuacionAF_Documento
        Try
            Dim ds As DataSet = ExecuteLST(oeReadecuacionAF_Documento)
            If ds.Tables(0).rows.Count > 0 Then
                oeReadecuacionAF_Documento = Cargar(ds.Tables(0).Rows(0))
            Else
            oeReadecuacionAF_Documento = New e_ReadecuacionAF_Documento
            End If
            Return oeReadecuacionAF_Documento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeReadecuacionAF_Documento As e_ReadecuacionAF_Documento) As List(Of e_ReadecuacionAF_Documento)
        Try
            Dim lstReadecuacionAF_Documento As New List(Of e_ReadecuacionAF_Documento)
            Dim ds As DataSet = ExecuteLST(oeReadecuacionAF_Documento)
            oeReadecuacionAF_Documento = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeReadecuacionAF_Documento = Cargar(o_Fila)
                    lstReadecuacionAF_Documento.Add(oeReadecuacionAF_Documento)
                Next
            End If
            Return lstReadecuacionAF_Documento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(oeReadecuacionAF_Documento As e_ReadecuacionAF_Documento) As Boolean
        Try
            'Using transScope As New TransactionScope()
            sqlhelper = New SqlHelper
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim IdResultado As String
            With oeReadecuacionAF_Documento
                IdResultado = sqlhelper.ExecuteScalar("[CON].[Isp_ReadecuacionAF_Documento_IAE]" _
                        , .TipoOperacion _
                        , .PrefijoID _
                        , .Id _
                        , .IdReadecuacionActivoFijo _
                        , .IdDocumento _
                        , .Glosa _
                        , .UsuarioCreacion _
                        , .Activo _
                        , .IndTipoDoc
                    ).ToString()
                .Id = IdResultado
            End With
            'transScope.Complete()
            'End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(oeReadecuacionAF_Documento As e_ReadecuacionAF_Documento) As Boolean
        Try
            sqlhelper = New SqlHelper
            With oeReadecuacionAF_Documento
                sqlhelper.ExecuteNonQuery("[CON].[Isp_ReadecuacionAF_Documento_IAE]" _
                       , "E" _
                       , "" _
                       , .Id _
                       , .IdReadecuacionActivoFijo _
                       , .IdDocumento _
                       , .Glosa _
                       , .UsuarioCreacion _
                       , .Activo _
                       , .IndTipoDoc
                   )

            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class