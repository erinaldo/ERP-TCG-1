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

Public Class d_CalculaTiempoServiciovb
    Dim SqlHelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_CalculaTiempoServicio
        Try
            Dim oeCalculaTiempoServicio = New e_CalculaTiempoServicio(o_fila("TiempoServicioTotal").ToString _
                                                                      , o_fila("dtFechaInicio").ToString _
                                                                      , o_fila("dtCantidadDias").ToString _
                                                                      , o_fila("dtTiempoTotal").ToString _
                                                                      , o_fila("gtFechaInicio").ToString _
                                                                      , o_fila("gtCantidadDias").ToString _
                                                                      , o_fila("gtCantidadMeses").ToString _
                                                                      , o_fila("gtTiempoTotal").ToString _
                                                                      , o_fila("vtFechaInicio").ToString _
                                                                      , o_fila("vtDiasVacaciones").ToString _
                                                                      , o_fila("vtCantidadDias").ToString _
                                                                      , o_fila("vtCantidadMeses").ToString _
                                                                      , o_fila("vtCantidadAños").ToString _
                                                                      , o_fila("vtTiempoTotal").ToString _
                                                                      , o_fila("ctsFechaInicio").ToString _
                                                                      , o_fila("ctsCantidadDias").ToString _
                                                                      , o_fila("ctsCantidadMeses").ToString _
                                                                      , o_fila("ctsTiempoTotal").ToString _
                                                                      , o_fila("PorcentajeAFP").ToString _
                                                                      , o_fila("Adelantos").ToString _
                                                                      , o_fila("PromedioBonificacion").ToString _
                                                                      , o_fila("ToGratificacion").ToString)

            oeCalculaTiempoServicio.CTSfaltas = o_fila("ctsFaltas").ToString
            oeCalculaTiempoServicio.VTfaltas = o_fila("vtFaltas").ToString
            oeCalculaTiempoServicio.GTfaltas = o_fila("gtFaltas").ToString
            oeCalculaTiempoServicio.DTfaltas = o_fila("dtFaltas").ToString
            oeCalculaTiempoServicio.PromedioHorasExtras = o_fila("PromedioHorasExtras").ToString

            Return oeCalculaTiempoServicio
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCalculaTiempoServicio As e_CalculaTiempoServicio) As e_CalculaTiempoServicio
        Try
            Dim ds As DataSet
            With oeCalculaTiempoServicio
                ds = SqlHelper.ExecuteDataset("STD.Isp_CalcularTiempoServicio", .TipoOperacion, .FechaInicio, .FechaCese, .IdTrabajador, _
                                              .IdPeriodo, .FechaInicioCTS, .FechaInicioGT, .FechaInicioVT, .FechaInicioDT)
            End With
            oeCalculaTiempoServicio = New e_CalculaTiempoServicio
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeCalculaTiempoServicio = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeCalculaTiempoServicio
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
