Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_MovimientoNeumatico
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_MovimientoNeumatico
        Try
            Dim oeMovimientoNeumatico = New e_MovimientoNeumatico( _
                             o_fila("Id").ToString _
                             , o_fila("IdVidaNeumatico").ToString _
                             , o_fila("IdMotivo").ToString _
                             , o_fila("EstadoInicial").ToString _
                             , o_fila("EstadoFinal").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("IndVigente").ToString _
                             , o_fila("IdOperacionNeumatico").ToString _
                             , o_fila("CostoSoles") _
                             , o_fila("IdVehiculo").ToString _
                             , o_fila("IdConductor").ToString _
                             , o_fila("IdTecnico").ToString _
                             , o_fila("FechaMov") _
                                         )
            Return oeMovimientoNeumatico
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMovimientoNeumatico As e_MovimientoNeumatico) As e_MovimientoNeumatico

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[NEU].[Isp_MovimientoNeumatico_Listar]", "", oeMovimientoNeumatico.Id)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeMovimientoNeumatico = Cargar(ds.Tables(0).Rows(0))
            Else
                oeMovimientoNeumatico = New e_MovimientoNeumatico
            End If
            Return oeMovimientoNeumatico
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMovimientoNeumatico As e_MovimientoNeumatico) As List(Of e_MovimientoNeumatico)
        Try
            Dim ldMovimientoNeumatico As New List(Of e_MovimientoNeumatico)
            Dim ds As DataSet
            With oeMovimientoNeumatico
                ds = sqlhelper.ExecuteDataset("[NEU].[Isp_MovimientoNeumatico_Listar]", "" _
                        , .Id _
                        , .IdVidaNeumatico _
                        , .IdMotivo _
                        , .EstadoInicial _
                        , .EstadoFinal _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .IndVigente _
                        , .IdOperacionNeumatico _
                        )
            End With
            oeMovimientoNeumatico = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMovimientoNeumatico = Cargar(o_Fila)
                    ldMovimientoNeumatico.Add(oeMovimientoNeumatico)
                Next
            End If
            Return ldMovimientoNeumatico
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMovimientoNeumatico As e_MovimientoNeumatico) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeMovimientoNeumatico
                sqlhelper.ExecuteNonQuery("[NEU].[Isp_MovimientoNeumatico_IAE]", _
                                          .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                                          .Id _
                        , .IdVidaNeumatico _
                        , .IdMotivo _
                        , .EstadoInicial _
                        , .EstadoFinal _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .IndVigente _
                        , .IdOperacionNeumatico _
                        , .CostoSoles _
                        , .IdVehiculo _
                        , .IdConductor _
                        , .IdTecnicoNeu _
                        , .FechaMov _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeMovimientoNeumatico As e_MovimientoNeumatico) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[NEU].[Isp_MovimientoNeumatico_IAE]", "E", _
             "", oeMovimientoNeumatico.Id)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
