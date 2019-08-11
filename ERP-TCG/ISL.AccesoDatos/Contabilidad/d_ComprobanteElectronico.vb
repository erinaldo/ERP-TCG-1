Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_ComprobanteElectronico

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_ComprobanteElectronico
        Try
            Dim oeComprobanteElectronico = New e_ComprobanteElectronico( _
                             o_fila("Id").ToString _
                             , o_fila("TipoReferencia").ToString _
                             , o_fila("IdReferencia").ToString _
                             , o_fila("xmlbase64").ToString _
                             , o_fila("nombrexml").ToString _
                              , o_fila("Firma").ToString _
                             , o_fila("valorcodbarras").ToString _
                              , o_fila("valorcodqr").ToString _
                             , o_fila("cdrxml").ToString _
                               , o_fila("ValorResumen").ToString _
                             , o_fila("UsuarioCrea").ToString _
                             , o_fila("FechaCrea").ToString _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("FechaModifica").ToString _
                             , o_fila("EstadoElectronico").ToString _
            )
            Return oeComprobanteElectronico
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeComprobanteElectronico As e_ComprobanteElectronico) As e_ComprobanteElectronico
        Try
            Dim ds As DataSet
            With oeComprobanteElectronico
                ds = sqlhelper.ExecuteDataset("CON.Isp_ComprobanteElectronico_Listar", "", .Id, .TipoReferencia, .IdReferencia)
            End With
            If ds.Tables(0).rows.Count > 0 Then
                oeComprobanteElectronico = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeComprobanteElectronico
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeComprobanteElectronico As e_ComprobanteElectronico) As List(Of e_ComprobanteElectronico)
        Try
            Dim ldComprobanteElectronico As New List(Of e_ComprobanteElectronico)
            Dim ds As DataSet
            With oeComprobanteElectronico
                ds = sqlhelper.ExecuteDataset("CON.Isp_ComprobanteElectronico_Listar", "" _
                        , .Id _
                        , .TipoReferencia _
                        , .IdReferencia _
                        , .xmlbase64 _
                        , .nombrexml _
                        , .valorcodbarras _
                        , .cdrxml _
                        )
            End With
            oeComprobanteElectronico = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeComprobanteElectronico = Cargar(o_Fila)
                ldComprobanteElectronico.Add(oeComprobanteElectronico)
            Next
            Return ldComprobanteElectronico
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeComprobanteElectronico As e_ComprobanteElectronico) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeComprobanteElectronico
                sqlhelper.ExecuteNonQuery("CON.Isp_ComprobanteElectronico_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .TipoReferencia _
                        , .IdReferencia _
                        , .xmlbase64 _
                        , .nombrexml _
                        , .valorcodbarras _
                        , .valorcodqr _
                        , .cdrxml _
                        , .ValorResumen _
                        , .UsuarioCrea _
                        , .Firma _
                        , .EstadoElectronico
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeComprobanteElectronico As e_ComprobanteElectronico) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_ComprobanteElectronico_IAE", "E", _
             "", oeComprobanteElectronico.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function AdicionarComprobanteElectronico(ByVal oeComprobanteElectronico As e_ComprobanteElectronico, ByVal oeDocumento As e_MovimientoDocumento) As Boolean
        Try
            Guardar(oeComprobanteElectronico)

            If Not oeDocumento Is Nothing Then
                Dim odMovimientoDocumento As New d_MovimientoDocumento
                odMovimientoDocumento.ActualizarDocFE(oeDocumento)
            End If
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    

End Class
