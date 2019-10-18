'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions


Public Class d_TipoGasto
    Private sqlhelper As New SqlHelper


    Public Function Cargar(ByVal o_fila As DataRow) As e_TipoGasto
        Try
            Dim oeTipoGasto = New e_TipoGasto( _
                                o_fila("Id"), _
                                o_fila("Codigo"), _
                                o_fila("Nombre"), _
                                o_fila("Abreviatura"), _
                                o_fila("Activo"), _
                                o_fila("UsuarioCreacion"))
            Return oeTipoGasto
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function Obtener(ByVal oeTipoGasto As e_TipoGasto) As e_TipoGasto
        Try
            Dim ds As New Data.DataSet
            With oeTipoGasto
                ds = sqlhelper.ExecuteDataset("TES.Isp_TipoGasto_ListarCD", "", .Id, .Codigo, .Nombre, .Abreviatura, .Activo)
            End With
            oeTipoGasto = New e_TipoGasto
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeTipoGasto = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeTipoGasto
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar2(ByVal oeTipoGasto As e_TipoGasto) As List(Of e_TipoGasto)
        Try
            Dim ldTipoGasto As New List(Of e_TipoGasto)
            Dim ds As DataSet
            With oeTipoGasto
                ds = sqlhelper.ExecuteDataset("TES.Isp_TipoGasto_Listar", "", .Id, .Codigo, _
                        .Nombre, .Abreviatura, .Activo)
            End With
            oeTipoGasto = Nothing
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeTipoGasto = Cargar(o_Fila)
                    ldTipoGasto.Add(oeTipoGasto)
                Next
            End If
            Return ldTipoGasto
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeTipoGasto As e_TipoGasto) As DataSet
        Try
            Dim ds As DataSet
            With oeTipoGasto
                ds = sqlhelper.ExecuteDataset("TES.Isp_TipoGasto_ListarCD", "", .Id, .Codigo, _
                            .Nombre, .Abreviatura, .Activo)
                Return ds
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDetalle(ByVal oeTipoGastoDetalle As e_TipoGastoDetalle) As List(Of e_TipoGastoDetalle)
        Try
            Dim ldTipoGastoDetalle As New List(Of e_TipoGastoDetalle)
            Dim ds As DataSet
            With oeTipoGastoDetalle
                ds = SqlHelper.ExecuteDataset("TES.Isp_TipoGastoDetalle_Listar", "" _
                        , .Id _
                        , .IdTipoGasto _
                        , .IdFlujoCaja _
                        , .Activo)
            End With
            oeTipoGastoDetalle = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeTipoGastoDetalle = CargarDetalle(o_Fila)
                    ldTipoGastoDetalle.Add(oeTipoGastoDetalle)
                Next
                Return ldTipoGastoDetalle
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Private Function CargarDetalle(ByVal o_fila As DataRow) As e_TipoGastoDetalle
        Try
            Dim oeTipoGastoDetalle = New e_TipoGastoDetalle(o_fila("Id"), _
                                o_fila("IdTipoGasto"), _
                                o_fila("IdFlujoGasto"), _
                                o_fila("FlujoGasto"), _
                                o_fila("Activo"))
            Return oeTipoGastoDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function Guardar(ByVal oeTipoGasto As e_TipoGasto) As Boolean
        Dim stResultado() As String
        Try
            Using transScope As New TransactionScope()
                With oeTipoGasto
                    stResultado = SqlHelper.ExecuteScalar("TES.Isp_TipoGasto_IAE", _
                                                          .TipoOperacion, _
                                                          "A", _
                                                          .Id, _
                                                          .Codigo, _
                                                          .Nombre, _
                                                          .Abreviatura, _
                                                          .Activo, _
                                                          .Usuario, _
                                                          .PrefijoID).ToString.Split("_")
                End With
                For Each Detalle As e_TipoGastoDetalle In oeTipoGasto.oeTipoGastoDetalle
                    Detalle.IdTipoGasto = stResultado(0)
                    Detalle.PrefijoID = oeTipoGasto.PrefijoID '@0001
                    GuardarDetalle(Detalle)
                Next
                transScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function GuardarDetalle(ByVal oeTipoGastoDetalle As e_TipoGastoDetalle) As Boolean
        Try
            With oeTipoGastoDetalle
                sqlhelper.ExecuteNonQuery("TES.Isp_TipoGastoDetalle_IAE", "I",
                                          .Id,
                                          .IdTipoGasto,
                                          .IdFlujoCaja,
                                          .Activo,
                                          .PrefijoID)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function



    Public Function Eliminar(ByVal oeTipoGasto As e_TipoGasto) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_TipoGasto_IAE", oeTipoGasto.TipoOperacion, "", oeTipoGasto.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
