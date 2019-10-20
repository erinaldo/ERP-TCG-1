'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Utilidad

    Private sqlhelper As New SqlHelper
    Private oeConsolidado As New e_ConsolidadoUtilidad
    Private odConsolidado As New d_ConsolidadoUtilidad
    Private oeDetallado As New e_DetalleUtilidad
    Private odDetallado As New d_DetalleUtilidad

    Private Function Cargar(ByVal o_fila As DataRow) As e_Utilidad
        Try
            Dim oeUtilidad = New e_Utilidad(o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("CantidadTrabajadores") _
                             , o_fila("MontoBase") _
                             , o_fila("PorcentajeParticipacion") _
                             , o_fila("MontoDistribucion") _
                             , o_fila("TotalSueldoAnual") _
                             , o_fila("TotalDiasAnual") _
                             , o_fila("Año") _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaModifica") _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo"))
            Return oeUtilidad
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeUtilidad As e_Utilidad) As e_Utilidad
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("PER.Isp_Utilidad_Listar", oeUtilidad.TipoOperacion, oeUtilidad.Id, "", oeUtilidad.Año)
            If ds.Tables(0).rows.Count > 0 Then
                oeUtilidad = Cargar(ds.Tables(0).Rows(0))
                If oeUtilidad.Id <> "" Then
                    oeConsolidado = New e_ConsolidadoUtilidad
                    oeConsolidado.TipoOperacion = ""
                    oeConsolidado.IdUtilidad = oeUtilidad.Id
                    oeConsolidado.Activo = True
                    oeConsolidado.IndSituacion = -1
                    oeUtilidad.leConsolidado = odConsolidado.Listar(oeConsolidado)
                    oeDetallado = New e_DetalleUtilidad
                    oeDetallado.TipoOperacion = "2"
                    oeDetallado.IdUtilidad = oeUtilidad.Id
                    oeUtilidad.leDetalle = odDetallado.Listar(oeDetallado)
                End If

            End If
            Return oeUtilidad
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeUtilidad As e_Utilidad) As List(Of e_Utilidad)
        Try
            Dim ldUtilidad As New List(Of e_Utilidad)
            Dim ds As DataSet
            With oeUtilidad
                ds = sqlhelper.ExecuteDataset("PER.Isp_Utilidad_Listar", "" _
                        , .Id _
                        , .Codigo)
            End With
            oeUtilidad = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeUtilidad = Cargar(o_Fila)
                ldUtilidad.Add(oeUtilidad)
            Next
            Return ldUtilidad
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeUtilidad As e_Utilidad) As Boolean
        Try
            With oeUtilidad
                sqlhelper.ExecuteNonQuery("PER.Isp_Utilidad_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .Codigo _
                        , .CantidadTrabajadores _
                        , .MontoBase _
                        , .PorcentajeParticipacion _
                        , .MontoDistribucion _
                        , .Año _
                        , .TotalSueldoAnual _
                        , .TotalDiasAnual _
                        , .IdEstado _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeUtilidad As e_Utilidad) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_Utilidad_IAE", "E", _
             "", oeUtilidad.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function ImportarDatos(ByVal oeUtilidad As e_Utilidad) As Boolean
        Try
            Dim _iduti As String = ""
            Using TransScope As New TransactionScope()
                With oeUtilidad
                    _iduti = sqlhelper.ExecuteScalar("PER.Isp_Utilidad_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .Codigo _
                        , .CantidadTrabajadores _
                        , .MontoBase _
                        , .PorcentajeParticipacion _
                        , .MontoDistribucion _
                        , .Año _
                        , .TotalSueldoAnual _
                        , .TotalDiasAnual _
                        , .IdEstado _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo)

                    If .dtConsolidado IsNot Nothing AndAlso .dtConsolidado.Rows.Count > 0 Then
                        For Each Fil As DataRow In .dtConsolidado.Rows
                            Fil("IdUtilidad") = _iduti
                        Next
                        odConsolidado.GuardarMasivo(.dtConsolidado)
                    End If
                    If .dtDetalle IsNot Nothing AndAlso .dtDetalle.Rows.Count > 0 Then
                        For Each Fil As DataRow In .dtDetalle.Rows
                            Fil("IdUtilidad") = _iduti
                            Fil("UsuarioCreacion") = .UsuarioCreacion
                        Next
                        odDetallado.GuardarMasivo(.dtDetalle)
                    End If
                End With
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
