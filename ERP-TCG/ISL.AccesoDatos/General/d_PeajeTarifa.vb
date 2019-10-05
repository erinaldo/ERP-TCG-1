'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Public Class d_PeajeTarifa
    Private sqlhelper As SqlHelper

    Private Function Cargar(o_fila As DataRow) As e_PeajeTarifa
        Try
            Dim oePeajeTarifa = New e_PeajeTarifa With {
                         .Id = o_fila("Id").ToString _
                         , .IdPeaje = o_fila("IdPeaje").ToString _
                         , .CantidadEjes = o_fila("CantidadEjes") _
                         , .IdTipoVehiculoTarifa = o_fila("IdTipoVehiculoTarifa").ToString _
                         , .Monto = o_fila("Monto") _
                         , .Glosa = o_fila("Glosa").ToString _
                         , .UsuarioCreacion = o_fila("UsuarioCreacion").ToString _
                         , .FechaCreacion = o_fila("FechaCreacion") _
                         , .UsuarioModificacion = o_fila("UsuarioModificacion").ToString _
                         , .FechaModificacion = o_fila("FechaModificacion") _
                         , .Activo = o_fila("Activo") _
            }
            Return oePeajeTarifa
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(oePeajeTarifa As e_PeajeTarifa) As e_PeajeTarifa
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_PeajeTarifa_Listar",
                                          "GEN",
                                          oePeajeTarifa.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oePeajeTarifa = Cargar(ds.Tables(0).Rows(0))
            Else
                oePeajeTarifa = New e_PeajeTarifa
            End If
            Return oePeajeTarifa
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oePeajeTarifa As e_PeajeTarifa) As List(Of e_PeajeTarifa)
        Try
            Dim ldPeajeTarifa As New List(Of e_PeajeTarifa)
            Dim ds As DataSet
            With oePeajeTarifa
                ds = sqlhelper.ExecuteDataset("STD.Isp_PeajeTarifa_Listar",
                                                .TipoOperacion _
                                                , .Id _
                                                , .IdPeaje _
                                                , .CantidadEjes _
                                                , .IdTipoVehiculoTarifa _
                                                , .Monto _
                                                , .Glosa _
                                                , .Activo)
            End With
            oePeajeTarifa = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oePeajeTarifa = Cargar(o_Fila)
                ldPeajeTarifa.Add(oePeajeTarifa)
            Next
            Return ldPeajeTarifa
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oePeajeTarifa As e_PeajeTarifa) As Boolean
        Try
            With oePeajeTarifa
                sqlhelper.ExecuteScalar("STD.Isp_PeajeTarifa_IAE",
                                          .TipoOperacion _
                                            , .PrefijoID _
                                            , .Id _
                                            , .IdPeaje _
                                            , .CantidadEjes _
                                            , .IdTipoVehiculoTarifa _
                                            , .Monto _
                                            , .Glosa _
                                            , .Activo _
                                            , .UsuarioCreacion)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oePeajeTarifa As e_PeajeTarifa) As Boolean
        Try
            With oePeajeTarifa
                sqlhelper.ExecuteScalar("STD.Isp_PeajeTarifa_IAE",
                                          "E" _
                                            , "" _
                                            , .Id _
                                            , .IdPeaje _
                                            , .CantidadEjes _
                                            , .IdTipoVehiculoTarifa _
                                            , .Monto _
                                            , .Glosa _
                                            , .Activo _
                                            , .UsuarioCreacion)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
