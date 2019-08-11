Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_TrabajadorSeguridad
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_TrabajadorSeguridad
        Try
            Dim oeTrabajadorSeguridad = New e_TrabajadorSeguridad( _
                             o_fila("Id").ToString _
                             , o_fila("IdProceso").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("CodigoTrabajador").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("IdArea").ToString _
                             , o_fila("Area").ToString _
                             , o_fila("CantidadLimite").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("CantidadMinima").ToString _
                             , o_fila("IndMontoFuncional").ToString _
                             , o_fila("NombreProceso").ToString _
            )

            Return oeTrabajadorSeguridad
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTrabajadorSeguridad As e_TrabajadorSeguridad) As e_TrabajadorSeguridad

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[SGD].[Isp_TrabajadorSeguridad_Listar]" _
                                                          , oeTrabajadorSeguridad.TipoOperacion _
                                                          , oeTrabajadorSeguridad.Id _
                                                           , oeTrabajadorSeguridad.IdProcesoNegocio _
                                                         , oeTrabajadorSeguridad.IdTrabajador _
                                                         , oeTrabajadorSeguridad.CantidadLimite _
                                                          , oeTrabajadorSeguridad.Activo _
                                                         , oeTrabajadorSeguridad.UsuarioCreacion _
                                                         , oeTrabajadorSeguridad.NombreProceso)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeTrabajadorSeguridad = Cargar(ds.Tables(0).Rows(0))
            Else
                oeTrabajadorSeguridad = New e_TrabajadorSeguridad
            End If
            Return oeTrabajadorSeguridad

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTrabajadorSeguridad As e_TrabajadorSeguridad) As List(Of e_TrabajadorSeguridad)
        Try
            Dim ldTrabajadorSeguridad As New List(Of e_TrabajadorSeguridad)
            Dim ds As DataSet
            With oeTrabajadorSeguridad
                ds = sqlhelper.ExecuteDataset("[SGD].[Isp_TrabajadorSeguridad_Listar]", .TipoOperacion _
                                                                        , .Id _
                                                                        , .IdProcesoNegocio _
                                                                        , .IdTrabajador _
                                                                        , .CantidadLimite _
                                                                        , .Activo _
                                                                        , .UsuarioCreacion)
            End With
            oeTrabajadorSeguridad = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeTrabajadorSeguridad = Cargar(o_Fila)
                    ldTrabajadorSeguridad.Add(oeTrabajadorSeguridad)
                Next
            End If
            Return ldTrabajadorSeguridad
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarProcesosDelTrabajador(ByVal oeTrabajadorSeguridad As e_TrabajadorSeguridad) As List(Of e_TrabajadorSeguridad)
        Try
            Dim ldTrabajadorSeguridad As New List(Of e_TrabajadorSeguridad)
            '    Dim ds As DataSet
            '    With oeTrabajadorSeguridad
            '        ds = sqlhelper.ExecuteDataset("[SGD].[Isp_TrabajadorSeguridad_Listar]", " " _
            '                                                                , " " _
            '                                                                , " " _
            '                                                                 .IdTrabajador _
            '                                                                , .Activo)
            '    End With
            '    oeTrabajadorSeguridad = Nothing
            '    If ds.Tables.Count > 0 Then
            '        For Each o_Fila As DataRow In ds.Tables(0).Rows
            '            oeTrabajadorSeguridad = Cargar(o_Fila)
            '            ldTrabajadorSeguridad.Add(oeTrabajadorSeguridad)
            '        Next
            '    End If
            Return ldTrabajadorSeguridad
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTrabajadorSeguridad As e_TrabajadorSeguridad) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeTrabajadorSeguridad
                sqlhelper.ExecuteNonQuery("[SGD].[Isp_TrabajadorSeguridad_IAE]", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                                                                        .Id _
                                                                        , .IdProcesoNegocio _
                                                                        , .IdTrabajador _
                                                                        , .CantidadLimite _
                                                                        , .Activo _
                                                                        , .UsuarioCreacion _
                                                                        , .CantidadMinima _
                                                                        , .IndMontoFuncional _
                                                                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeTrabajadorSeguridad As e_TrabajadorSeguridad) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[SGD].[Isp_TrabajadorSeguridad_IAE]", "E", _
             "", oeTrabajadorSeguridad.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
