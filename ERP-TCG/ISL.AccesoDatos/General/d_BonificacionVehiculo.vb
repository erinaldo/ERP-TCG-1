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

Public Class d_BonificacionVehiculo
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_BonificacionVehiculo
        Try
            Dim oeBonificacionVehiculo = New e_BonificacionVehiculo( _
                             o_fila("Id").ToString _
                             , o_fila("IdDocumentoVehicular").ToString _
                             , o_fila("Eje").ToString _
                             , o_fila("TipoSuspension").ToString _
                             , o_fila("KgEje").ToString _
                             , o_fila("KgSuspension").ToString _
                             , o_fila("KgNeumatico").ToString _
                             , o_fila("ClaseNeumatico").ToString _
                             , o_fila("BonificacionEje").ToString _
                             , o_fila("PesoEje").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
                                     )
            Return oeBonificacionVehiculo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeBonificacionVehiculo As e_BonificacionVehiculo) As List(Of e_BonificacionVehiculo)
        Try
            Dim ldBonificacionVehiculo As New List(Of e_BonificacionVehiculo)
            Dim ds As DataSet
            With oeBonificacionVehiculo
                ds = sqlhelper.ExecuteDataset("STD.Isp_BonificacionVehiculo_Listar" _
                        , .TipoOperacion _
                        , .Id _
                        , .IdDocumentoVehicular _
                        , .Activo _
                        , .UsuarioCreacion _
                        )
            End With
            oeBonificacionVehiculo = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeBonificacionVehiculo = Cargar(o_Fila)
                    ldBonificacionVehiculo.Add(oeBonificacionVehiculo)
                Next
            End If
            Return ldBonificacionVehiculo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeBonificacionVehiculo As e_BonificacionVehiculo) As Boolean
        Try
            With oeBonificacionVehiculo
                sqlhelper.ExecuteNonQuery("STD.Isp_BonificacionVehiculo_IAE" _
                                              , .TipoOperacion,
                                              .PrefijoID _
                                            , .Id _
                                            , .IdDocumentoVehicular _
                                            , .Eje _
                                            , .TipoSuspension _
                                            , .KgEje _
                                            , .KgSuspension _
                                            , .KgNeumatico _
                                            , .ClaseNeumatico _
                                            , .BonificacionEje _
                                            , .PesoEje _
                                            , .FechaCreacion _
                                            , .UsuarioCreacion _
                                            , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
