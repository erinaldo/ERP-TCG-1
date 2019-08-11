Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_VehiculoEstado
    Private sqlhelper As SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_VehiculoEstado
        Try
            Dim oeVehiculoEstado = New e_VehiculoEstado(o_fila("Id").ToString _
                                                 , o_fila("IdVehiculo").ToString _
                                                 , o_fila("Indicador").ToString _
                                                 , o_fila("Observacion").ToString _
                                                 , o_fila("FechaInicio").ToString _
                                                 , o_fila("FechaFin").ToString _
                                                 , o_fila("UsuarioCrea").ToString _
                                                 , o_fila("FechaCrea").ToString _
                                                 , o_fila("Actual").ToString _
                                                 , o_fila("Activo").ToString)
            Return oeVehiculoEstado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeVehiculoEstado As e_VehiculoEstado) As e_VehiculoEstado
        Try
            sqlhelper = New SqlHelper
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_VehiculoEstado_Listar", _
                                          "", _
                                          oeVehiculoEstado.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeVehiculoEstado = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeVehiculoEstado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeVehiculoEstado As e_VehiculoEstado) As List(Of e_VehiculoEstado)
        Try
            sqlhelper = New SqlHelper
            Dim ldVehiculoEstado As New List(Of e_VehiculoEstado)
            Dim ds As DataSet
            With oeVehiculoEstado
                ds = sqlhelper.ExecuteDataset("STD.Isp_VehiculoEstado_Listar", _
                                              .TipoOperacion _
                                            , .Id _
                                            , .IdVehiculo _
                                            , .Indicador _
                                            , .Observacion _
                                            , .FechaInicio _
                                            , .FechaFin _
                                            , .UsuarioCrea _
                                            , .FechaCrea _
                                            , .Actual _
                                            , .Activo)
            End With
            oeVehiculoEstado = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeVehiculoEstado = Cargar(o_Fila)
                ldVehiculoEstado.Add(oeVehiculoEstado)
            Next
            Return ldVehiculoEstado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeVehiculoEstado As e_VehiculoEstado) As Boolean
        Try
            sqlhelper = New SqlHelper
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeVehiculoEstado
                sqlhelper.ExecuteNonQuery("STD.Isp_VehiculoEstado_IAE", _
                                          .TipoOperacion, _
                                          d_DatosConfiguracion.PrefijoID, _
                                            .Id _
                                            , .IdVehiculo _
                                            , .Indicador _
                                            , .Observacion _
                                            , .FechaInicio _
                                            , .FechaFin _
                                            , .UsuarioCrea _
                                            , .FechaCrea _
                                            , .Actual _
                                            , .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeVehiculoEstado As e_VehiculoEstado) As Boolean
        Try
            sqlhelper = New SqlHelper
            sqlhelper.ExecuteNonQuery("STD.Isp_VehiculoEstado_IAE", _
                                      "E", _
                                      "", _
                                      oeVehiculoEstado.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
