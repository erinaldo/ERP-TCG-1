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

Public Class d_ZonaProceso
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_ZonaProceso
        Try
            Dim oeZonaProceso = New e_ZonaProceso( _
                             o_fila("Id").ToString _
                             , o_fila("IdActividadNegocio").ToString _
                             , o_fila("IdCliente").ToString _
                             , o_fila("Zona").ToString _
                             , o_fila("Monto").ToString _
                             , o_fila("CostoFijo").ToString _
                             , o_fila("Semana").ToString _
                             , o_fila("Observacion").ToString _
                             , o_fila("FechaInicio").ToString _
                             , o_fila("FechaFin").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("Actual").ToString _
                              , o_fila("Activo").ToString)
            Return oeZonaProceso
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeZonaProceso As e_ZonaProceso) As e_ZonaProceso

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("OPE.Isp_ZonaOperacion_Listar",
                                          oeZonaProceso.TipoOperacion _
                                          , oeZonaProceso.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeZonaProceso = Cargar(ds.Tables(0).Rows(0))
            Else
                oeZonaProceso = New e_ZonaProceso
            End If
            Return oeZonaProceso
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeZonaProceso As e_ZonaProceso) As List(Of e_ZonaProceso)
        Try
            Dim ldZonaProceso As New List(Of e_ZonaProceso)
            Dim ds As DataSet
            With oeZonaProceso
                ds = sqlhelper.ExecuteDataset("OPE.Isp_ZonaOperacion_Listar",
                                              .TipoOperacion _
                                            , .Id _
                                            , .IdActividadNegocio _
                                            , .IdCliente _
                                            , .Zona _
                                            , .Actual)
            End With
            oeZonaProceso = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeZonaProceso = Cargar(o_Fila)
                    ldZonaProceso.Add(oeZonaProceso)
                Next
            End If
            Return ldZonaProceso
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeZonaProceso As e_ZonaProceso) As Boolean
        Try
            With oeZonaProceso
                sqlhelper.ExecuteNonQuery("OPE.Isp_ZonaOperacion_IAE",
                                          .TipoOperacion,
                                          .PrefijoID,
                                            .Id _
                                            , .IdActividadNegocio _
                                            , .IdCliente _
                                            , .Zona _
                                            , .Monto _
                                            , .CostoFijo _
                                            , .Semana _
                                            , .Observacion _
                                            , .FechaInicio _
                                            , .FechaFin _
                                            , .Actual)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeZonaProceso As e_ZonaProceso) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("OPE.Isp_ZonaOperacion_IAE", "E", _
                                    "", oeZonaProceso.Id)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function


End Class
