'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF

Public Class d_TipoGastoDetalle
    Private sqlhelper As New SqlHelper

    Private oeTipoGastoDetalle As e_TipoGastoDetalle


    Private Function Cargar(ByVal o_fila As DataRow) As e_TipoGastoDetalle
        Try
            Dim oeTipoGastodetalle = New e_TipoGastoDetalle( _
            o_fila("Id"), o_fila("IdTipoGasto"), o_fila("IdFlujoGasto"), o_fila("FlujoGasto"), o_fila("Activo"))
            Return oeTipoGastodetalle
        Catch ex As Exception
            Throw ex
        End Try

    End Function


    Public Function Obtener(ByVal oeTipoGastodetalle As e_TipoGastoDetalle) As e_TipoGastoDetalle
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_TipoGastoDetalle_Listar", oeTipoGastodetalle.TipoOperacion, oeTipoGastodetalle.Id)
            If ds.Tables.Count > 0 Then
                oeTipoGastodetalle = Cargar(ds.Tables(0).Rows(0))
                Return oeTipoGastodetalle
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function Listar(ByVal oeTipoGastodetalle As e_TipoGastoDetalle) As List(Of e_TipoGastoDetalle)
        Try
            Dim ldTipoGastodetalle As New List(Of e_TipoGastoDetalle)
            Dim ds As DataSet
            With oeTipoGastodetalle
                ds = sqlhelper.ExecuteDataset("TES.Isp_TipoGastoDetalle_Listar", oeTipoGastodetalle.TipoOperacion, .Id, .IdTipoGasto, _
                        .IdFlujoCaja, .Activo)
            End With
            oeTipoGastodetalle = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeTipoGastodetalle = Cargar(o_Fila)
                    ldTipoGastodetalle.Add(oeTipoGastodetalle)
                Next
                Return ldTipoGastodetalle
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoGastoDetalle As e_TipoGastoDetalle) As Boolean
        Try


            With oeTipoGastoDetalle
                sqlhelper.ExecuteNonQuery("TES.Isp_TipoGastoDetalle_IAE", "I", _
                .Id, .IdTipoGasto, .IdFlujoCaja, .Activo, .PrefijoID)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function


    Public Function Eliminar(ByVal oeTipoGasto As e_TipoGastoDetalle) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("TES.Isp_TipoGastoDetalle_IAE", "E", oeTipoGasto.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
