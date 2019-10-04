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

Public Class d_ConfiguracionMTC
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_ConfiguracionMTC
        Try
            Dim oeConfiguracionMTC = New e_ConfiguracionMTC( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Capacidad").ToString _
                             , o_fila("LongitudMax").ToString _
                             , o_fila("NumeroEjes").ToString _
                             , o_fila("CantPesoMaxEje1").ToString _
                             , o_fila("CantPesoMaxEje2").ToString _
                             , o_fila("CantPesoMaxEje3").ToString _
                             , o_fila("CantPesoMaxEje4").ToString _
                             , o_fila("CantPesoMaxEje5").ToString _
                             , o_fila("CantPesoMaxEje6").ToString _
                             , o_fila("CantPesoMaxEje7").ToString _
                             , o_fila("CantPesoMaxEje8").ToString _
                             , o_fila("CantPesoMaxEje9").ToString _
                             , o_fila("CantPesoMaxBruto").ToString _
                             , o_fila("Activo").ToString)
            Return oeConfiguracionMTC
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeConfiguracionMTC As e_ConfiguracionMTC) As e_ConfiguracionMTC
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[STD].[Isp_ConfiguracionMTC_Listar]", _
                                          "", _
                                          oeConfiguracionMTC.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeConfiguracionMTC = Cargar(ds.Tables(0).Rows(0))
            Else
                oeConfiguracionMTC = New e_ConfiguracionMTC
            End If
            Return oeConfiguracionMTC
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeConfiguracionMTC As e_ConfiguracionMTC) As List(Of e_ConfiguracionMTC)
        Try
            Dim ldConfiguracionMTC As New List(Of e_ConfiguracionMTC)
            Dim ds As DataSet
            With oeConfiguracionMTC
                ds = sqlhelper.ExecuteDataset("[STD].[Isp_ConfiguracionMTC_Listar]", _
                                              "" _
                                            , .Id _
                                            , .Nombre _
                                            , .Activo)
            End With
            oeConfiguracionMTC = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeConfiguracionMTC = Cargar(o_Fila)
                    ldConfiguracionMTC.Add(oeConfiguracionMTC)
                Next
            Else
                ldConfiguracionMTC = New List(Of e_ConfiguracionMTC)
            End If
            Return ldConfiguracionMTC
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeConfiguracionMTC As e_ConfiguracionMTC) As Boolean
        Try

            With oeConfiguracionMTC
                sqlhelper.ExecuteNonQuery("[STD].[Isp_ConfiguracionMTC_IAE]", _
                                          .TipoOperacion, _
                                          .PrefijoID, _
                                            .Id _
                                            , .Codigo _
                                            , .Nombre _
                                            , .Capacidad _
                                            , .LongitudMax _
                                            , .NumeroEjes _
                                            , .CantPesoMaxEje1 _
                                            , .CantPesoMaxEje2 _
                                            , .CantPesoMaxEje3 _
                                            , .CantPesoMaxEje4 _
                                            , .CantPesoMaxEje5 _
                                            , .CantPesoMaxEje6 _
                                            , .CantPesoMaxEje7 _
                                            , .CantPesoMaxEje8 _
                                            , .CantPesoMaxEje9 _
                                            , .CantPesoMaxBruto _
                                            , .Activo _
                                            , .UsuarioCreacion)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeConfiguracionMTC As e_ConfiguracionMTC) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[STD].[Isp_ConfiguracionMTC_IAE]", _
                                      "E", _
                                        "", _
                                        oeConfiguracionMTC.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class

