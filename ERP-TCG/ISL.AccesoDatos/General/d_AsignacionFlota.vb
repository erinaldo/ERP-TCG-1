﻿Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_AsignacionFlota
    Private sqlhelper As SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_AsignacionFlota
        Try
            Dim oeAsignacionFlota = New e_AsignacionFlota( _
                             o_fila("Id").ToString _
                             , o_fila("IdVehiculo").ToString _
                             , o_fila("IdFlota").ToString _
                             , o_fila("Observacion").ToString _
                             , o_fila("FechaInicio").ToString _
                             , o_fila("FechaFin").ToString _
                             , o_fila("Actual") _
                             , o_fila("Activo")
                             )
            Return oeAsignacionFlota
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeAsignacionFlota As e_AsignacionFlota) As e_AsignacionFlota
        Try
            sqlhelper = New SqlHelper
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_AsignacionFlota_Listar", _
                                          "", _
                                          oeAsignacionFlota.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeAsignacionFlota = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeAsignacionFlota
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAsignacionFlota As e_AsignacionFlota) As List(Of e_AsignacionFlota)
        Try
            sqlhelper = New SqlHelper
            Dim ldAsignacionFlota As New List(Of e_AsignacionFlota)
            Dim ds As DataSet
            With oeAsignacionFlota
                ds = sqlhelper.ExecuteDataset("STD.Isp_AsignacionFlota_Listar", _
                                              "" _
                                                , .Id _
                                                , .IdVehiculo _
                                                , .IdFlota)
            End With
            oeAsignacionFlota = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeAsignacionFlota = Cargar(o_Fila)
                ldAsignacionFlota.Add(oeAsignacionFlota)
            Next
            Return ldAsignacionFlota
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeAsignacionFlota As e_AsignacionFlota) As Boolean
        Try
            sqlhelper = New SqlHelper
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeAsignacionFlota
                sqlhelper.ExecuteNonQuery("STD.Isp_AsignacionFlota_IAE", _
                                          .TipoOperacion, _
                                          d_DatosConfiguracion.PrefijoID, _
                                            .Id _
                                            , .IdVehiculo _
                                            , .IdFlota _
                                            , .Observacion _
                                            , .FechaInicio _
                                            , .FechaFin _
                                            , .Actual _
                                            , .UsuarioCrea _
                                            , .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeAsignacionFlota As e_AsignacionFlota) As Boolean
        Try
            sqlhelper = New SqlHelper
            sqlhelper.ExecuteNonQuery("STD.Isp_AsignacionFlota_IAE", _
                                      "E", _
                                        "", _
                                        oeAsignacionFlota.Id)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class