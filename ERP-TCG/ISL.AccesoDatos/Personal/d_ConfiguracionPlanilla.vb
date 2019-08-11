Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_ConfiguracionPlanilla

    Private sqlhelper As New SqlHelper
    Private oeDetalle As New e_DetalleConfiguracionPlanilla
    Private odDetalle As New d_DetalleConfiguracionPlanilla

    Private Function Cargar(ByVal o_fila As DataRow) As e_ConfiguracionPlanilla
        Try
            Dim oeConfiguracionPlanilla = New e_ConfiguracionPlanilla( _
                             o_Fila("Id").ToString _
                             , o_Fila("Codigo").ToString _
                             , o_Fila("Nombre").ToString _
                             , o_Fila("Descripcion").ToString _
                             , o_Fila("FechaCreacion").ToString _
                             , o_Fila("UsuarioCreacion").ToString _
                             , o_Fila("FechaModifica").ToString _
                             , o_Fila("UsuarioModifica").ToString _
                             , o_Fila("Activo").ToString _
            )
            Return oeConfiguracionPlanilla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeConfiguracionPlanilla As e_ConfiguracionPlanilla) As e_ConfiguracionPlanilla

        Try
            Dim ds As DataSet
            With oeConfiguracionPlanilla
                ds = sqlhelper.ExecuteDataset("PER.Isp_ConfiguracionPlanilla_Listar", .TipoOperacion, .Id)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeConfiguracionPlanilla = Cargar(ds.Tables(0).Rows(0))
                oeDetalle = New e_DetalleConfiguracionPlanilla
                oeDetalle.TipoOperacion = ""
                oeDetalle.IdConfiguracionPlanilla = oeConfiguracionPlanilla.Id
                oeConfiguracionPlanilla.leDetalle = odDetalle.Listar(oeDetalle)
            End If
            Return oeConfiguracionPlanilla
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeConfiguracionPlanilla As e_ConfiguracionPlanilla) As List(Of e_ConfiguracionPlanilla)
        Try
            Dim ldConfiguracionPlanilla As New List(Of e_ConfiguracionPlanilla)
            Dim ds As DataSet
            With oeConfiguracionPlanilla
                ds = sqlhelper.ExecuteDataset("PER.Isp_ConfiguracionPlanilla_Listar", .TipoOperacion _
                        , .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Descripcion _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                        )
            End With
            oeConfiguracionPlanilla = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeConfiguracionPlanilla = Cargar(o_Fila)
                ldConfiguracionPlanilla.Add(oeConfiguracionPlanilla)
            Next
            Return ldConfiguracionPlanilla
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeConfiguracionPlanilla As e_ConfiguracionPlanilla) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim id As String
            With oeConfiguracionPlanilla
                id = sqlhelper.ExecuteScalar("PER.Isp_ConfiguracionPlanilla_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Descripcion _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                    )
                .Id = id

                For Each oeDetConPla In .leDetalle
                    oeDetConPla.IdConfiguracionPlanilla = .Id
                    If .TipoOperacion = "E" Then
                        odDetalle.Eliminar(oeDetConPla)
                    Else
                        odDetalle.Guardar(oeDetConPla)
                    End If
                Next
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeConfiguracionPlanilla As e_ConfiguracionPlanilla) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_ConfiguracionPlanilla_IAE", "E", _
             "", oeConfiguracionPlanilla.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
