Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_DocumentoSinAsociacion
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_DocumentoSinAsociacion
        Try
            Dim oeDocumentoSinAsociacion = New e_DocumentoSinAsociacion( _
                             o_fila("Id").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("Evaluado").ToString _
                             , o_fila("IdUsuarioSolicito").ToString _
                             , o_fila("IdUsuarioEvalua").ToString _
                             , o_fila("IdTipoDocumento").ToString _
                             , o_fila("IdDocumento").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeDocumentoSinAsociacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDocumentoSinAsociacion As e_DocumentoSinAsociacion) As e_DocumentoSinAsociacion

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CMP.Isp_DocumentoSinAsociacion_Listar", "", oeDocumentoSinAsociacion.Id)
            If ds.Tables.Count > 0 Then
                oeDocumentoSinAsociacion = Cargar(ds.Tables(0).Rows(0))
                Return oeDocumentoSinAsociacion
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDocumentoSinAsociacion As e_DocumentoSinAsociacion) As List(Of e_DocumentoSinAsociacion)
        Try
            Dim ldDocumentoSinAsociacion As New List(Of e_DocumentoSinAsociacion)
            Dim ds As DataSet
            With oeDocumentoSinAsociacion
                ds = sqlhelper.ExecuteDataset("CMP.Isp_DocumentoSinAsociacion_Listar", .TipoOperacion _
                        , .Id _
                        , .Glosa _
                        , .Evaluado _
                        , .IdUsuarioSolicito _
                        , .IdUsuarioEvalua _
                        , .IdTipoDocumento _
                        , .IdDocumento _
                        , .UsuarioCreacion _
                        , .FechaInicio _
                        , .FechaFin _
                        )
            End With
            oeDocumentoSinAsociacion = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDocumentoSinAsociacion = Cargar(o_Fila)
                    ldDocumentoSinAsociacion.Add(oeDocumentoSinAsociacion)
                Next
                Return ldDocumentoSinAsociacion
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeDocumentoSinAsociacion As e_DocumentoSinAsociacion) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeDocumentoSinAsociacion
                sqlhelper.ExecuteNonQuery("CMP.Isp_DocumentoSinAsociacion_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .Glosa _
                        , .Fecha _
                        , .Evaluado _
                        , .IdUsuarioSolicito _
                        , .IdUsuarioEvalua _
                        , .IdTipoDocumento _
                        , .IdDocumento _
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

    Public Function Eliminar(ByVal oeDocumentoSinAsociacion As e_DocumentoSinAsociacion) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CMP.Isp_DocumentoSinAsociacion_IAE", "E", _
             "", oeDocumentoSinAsociacion.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
