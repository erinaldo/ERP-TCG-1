'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_VehiculoPilotoOperacion
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_VehiculoPilotoOperacion
        Try
            Dim oeVehiculoPilotoOperacion = New e_VehiculoPilotoOperacion( _
                             o_fila("Id").ToString _
                             , o_fila("IdVehiculo").ToString _
                             , o_fila("IdPiloto").ToString _
                             , o_fila("IdActividadNegocio").ToString _
                             , o_fila("IdCliente").ToString _
                             , o_fila("Observacion").ToString _
                             , o_fila("FechaInicio").ToString _
                             , o_fila("FechaFin").ToString _
                             , o_fila("IndVP").ToString _
                             , o_fila("IndHistorial").ToString _
                             , o_fila("Actual").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCrea").ToString _
                             , o_fila("FechaCreacion").ToString)
            Return oeVehiculoPilotoOperacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeVehiculoPilotoOperacion As e_VehiculoPilotoOperacion) As e_VehiculoPilotoOperacion
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("OPE.Isp_VehiculoPilotoOperacion_Listar", _
                                          "", _
                                          oeVehiculoPilotoOperacion.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeVehiculoPilotoOperacion = Cargar(ds.Tables(0).Rows(0))
            Else
                oeVehiculoPilotoOperacion = New e_VehiculoPilotoOperacion
            End If
            Return oeVehiculoPilotoOperacion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeVehiculoPilotoOperacion As e_VehiculoPilotoOperacion) As List(Of e_VehiculoPilotoOperacion)
        Try
            Dim ldVehiculoPilotoOperacion As New List(Of e_VehiculoPilotoOperacion)
            Dim ds As DataSet
            With oeVehiculoPilotoOperacion
                ds = sqlhelper.ExecuteDataset("OPE.Isp_VehiculoPilotoOperacion_Listar", "" _
                        , .Id _
                        , .IdVehiculo _
                        , .IdPiloto _
                        , .IdActividadNegocio _
                        , .IdCliente _
                        , .IndVP _
                        , .IndHistorial _
                        , .Actual)
            End With
            oeVehiculoPilotoOperacion = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeVehiculoPilotoOperacion = Cargar(o_Fila)
                    ldVehiculoPilotoOperacion.Add(oeVehiculoPilotoOperacion)
                Next
            Else
                ldVehiculoPilotoOperacion = New List(Of e_VehiculoPilotoOperacion)
            End If
            Return ldVehiculoPilotoOperacion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeListaVehiculoPiloto As List(Of e_VehiculoPilotoOperacion)) As Boolean
        Try

            Using transScope As New TransactionScope()
                For Each VehiculoPiloto As e_VehiculoPilotoOperacion In oeListaVehiculoPiloto
                    With VehiculoPiloto
                        sqlhelper.ExecuteNonQuery("OPE.Isp_VehiculoPilotoOperacion_IAE",
                                                  "I",
                                                  .PrefijoID,
                                                    .Id _
                                                    , .IdVehiculo _
                                                    , .IdPiloto _
                                                    , .IdActividadNegocio _
                                                    , .IdCliente _
                                                    , .Observacion _
                                                    , .FechaInicio _
                                                    , .FechaFin _
                                                    , .IndVP _
                                                    , .IndHistorial _
                                                    , .Actual _
                                                    , .UsuarioCrea _
                                                    , .Activo)
                    End With
                Next
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeVehiculoPilotoOperacion As e_VehiculoPilotoOperacion) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("OPE.Isp_VehiculoPilotoOperacion_IAE", _
                                      "E", _
                                       "", _
                                       oeVehiculoPilotoOperacion.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
