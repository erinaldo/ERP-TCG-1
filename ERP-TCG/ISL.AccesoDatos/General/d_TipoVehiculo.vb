'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF

Public Class d_TipoVehiculo
    Private sqlhelper As New SqlHelper

    Public oeTipoVehiculo As e_TipoVehiculo

    Private Function Cargar(ByVal o_fila As DataRow) As e_TipoVehiculo
        Try
            Dim oeTipoVehiculo = New e_TipoVehiculo(o_fila("Id"), _
                                                    o_fila("Codigo"), _
                                                    o_fila("Nombre"), _
                                                    o_fila("Abreviatura"), _
                                                    o_fila("Motriz"), _
                                                    o_fila("Carga"), _
                                                    o_fila("IndicadorModeloFuncional"), _
                                                    o_fila("Descripcion"), _
                                                    o_fila("Activo"), _
                                                    o_fila("TipoVehiculoOrigen"), _
                                                    o_fila("IndTipoVehiculo"), _
                                                    o_fila("IndSunarp"))
            Return oeTipoVehiculo
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function Obtener(ByVal oeTipoVehiculo As e_TipoVehiculo) As e_TipoVehiculo
        Try
            Dim ds As DataSet
            With oeTipoVehiculo
                ds = sqlhelper.ExecuteDataset("[STD].[Isp_TipoVehiculo_Listar]",
                                                .TipoOperacion,
                                                 .Id,
                                                 "",
                                                  .Nombre)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeTipoVehiculo = Cargar(ds.Tables(0).Rows(0))
            Else
                oeTipoVehiculo = Nothing
            End If
            Return oeTipoVehiculo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeTipoVehiculo As e_TipoVehiculo) As List(Of e_TipoVehiculo)
        Try
            sqlhelper = New SqlHelper
            Dim ldMarca As New List(Of e_TipoVehiculo)
            Dim ds As DataSet
            With oeTipoVehiculo
                ds = sqlhelper.ExecuteDataset("[STD].[Isp_TipoVehiculo_Listar]", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .Codigo, _
                                              .Nombre, _
                                              .Motriz, _
                                              .Carga, _
                                              .IndicadorFuncional, _
                                              .IdTipoVehiculoOrigen)
            End With
            oeTipoVehiculo = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeTipoVehiculo = Cargar(o_Fila)
                    ldMarca.Add(oeTipoVehiculo)
                Next
            End If
            Return ldMarca
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoVehiculo As e_TipoVehiculo) As Boolean
        Try
            With oeTipoVehiculo
                sqlhelper.ExecuteNonQuery("[STD].[Isp_TipoVehiculo_IAE]", .TipoOperacion,
                                                .PrefijoID,
                                                .Id,
                                                .Codigo,
                                                .Nombre,
                                                .Abreviatura,
                                                .Motriz,
                                                .Carga,
                                                .Descripcion,
                                                .Activo,
                                                .IdTipoVehiculoOrigen,
                                                .UsuarioCreacion,
                                                .IndicadorFuncional,
                                                .IndTipoVehiculo,
                                                .IndSunarp)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeTipoVehiculo As e_TipoVehiculo) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[STD].[Isp_TipoVehiculo_IAE]",
                                      oeTipoVehiculo.TipoOperacion,
                                      "",
                                      oeTipoVehiculo.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ComboGrilla(ByVal ListaTipoVehiculo As List(Of e_TipoVehiculo))
        Dim ds = New DataTable
        ds.Columns.Add("Id")
        ds.Columns.Add("Nombre")
        For Each item As e_TipoVehiculo In ListaTipoVehiculo
            Dim newRow As DataRow = ds.NewRow()
            newRow("Id") = item.Id
            newRow("Nombre") = item.Nombre
            ds.Rows.Add(newRow)
        Next
        Return ds
    End Function

End Class
