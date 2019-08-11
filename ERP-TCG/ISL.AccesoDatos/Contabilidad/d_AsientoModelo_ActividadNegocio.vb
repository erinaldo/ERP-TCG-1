Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_AsientoModelo_ActividadNegocio
    Private sqlhelper As New SqlHelper
    Private odReferencia As New d_AsientoModelo_Referencia

    Private Function Cargar(ByVal o_fila As DataRow) As e_AsientoModelo_ActividadNegocio
        Try
            Dim oeAsientoModelo_ActividadNegocio = New e_AsientoModelo_ActividadNegocio( _
                             o_fila("Id").ToString _
                             , o_fila("IdAsientoModelo").ToString _
                             , o_fila("IdActividadNegocio").ToString _
                             , o_fila("ProcesoNegocio").ToString _
                             , o_fila("ActividadNegocio").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("FechaModifica") _
                             , o_fila("Activo") _
            )
            Return oeAsientoModelo_ActividadNegocio
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeAsientoModelo_ActividadNegocio As e_AsientoModelo_ActividadNegocio) As e_AsientoModelo_ActividadNegocio
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_AsientoModelo_ActividadNegocio_Listar", "", oeAsientoModelo_ActividadNegocio.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeAsientoModelo_ActividadNegocio = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeAsientoModelo_ActividadNegocio
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAsientoModelo_ActividadNegocio As e_AsientoModelo_ActividadNegocio) As List(Of e_AsientoModelo_ActividadNegocio)
        Try
            Dim ldAsientoModelo_ActividadNegocio As New List(Of e_AsientoModelo_ActividadNegocio)
            Dim ds As DataSet
            With oeAsientoModelo_ActividadNegocio
                ds = sqlhelper.ExecuteDataset("CON.Isp_AsientoModelo_ActividadNegocio_Listar", .TipoOperacion _
                        , .Id _
                        , .IdAsientoModelo _
                        , .IdActividadNegocio _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        , .UsuarioModifica _
                        , .FechaModifica _
                        , .Activo _
                        )
            End With
            oeAsientoModelo_ActividadNegocio = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeAsientoModelo_ActividadNegocio = Cargar(o_Fila)
                ldAsientoModelo_ActividadNegocio.Add(oeAsientoModelo_ActividadNegocio)
            Next
            Return ldAsientoModelo_ActividadNegocio
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeAsientoModelo_ActividadNegocio As e_AsientoModelo_ActividadNegocio) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim _idAMAN() As String
            Using TransScope As New TransactionScope()
                With oeAsientoModelo_ActividadNegocio
                    _idAMAN = sqlhelper.ExecuteScalar("CON.Isp_AsientoModelo_ActividadNegocio_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                            .Id _
                            , .IdAsientoModelo _
                            , .IdActividadNegocio _
                            , .UsuarioCreacion _
                            , .FechaCreacion _
                            , .UsuarioModifica _
                            , .FechaModifica _
                            , .Activo _
                        ).ToString.Split("_")
                    'Guardar Referencia de Asiento Modelo por Actividad
                    For Each oeReferencia In .leReferencia
                        oeReferencia.IdAsiMod_ActNeg = _idAMAN(0)
                        Select Case oeReferencia.TipoOperacion
                            Case "I", "A" : odReferencia.Guardar(oeReferencia)
                            Case "E" : odReferencia.Eliminar(oeReferencia)
                        End Select
                    Next
                End With
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeAsientoModelo_ActividadNegocio As e_AsientoModelo_ActividadNegocio) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_AsientoModelo_ActividadNegocio_IAE", "E", _
             "", oeAsientoModelo_ActividadNegocio.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
