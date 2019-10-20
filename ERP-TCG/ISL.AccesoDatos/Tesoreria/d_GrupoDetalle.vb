'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_GrupoDetalle
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_GrupoDetalle
        Try
            Dim oeGrupoDetalle = New e_GrupoDetalle(  o_fila("Id").ToString _
                             , o_fila("IdGrupo").ToString _
                             , o_fila("IdGastoOperacion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("IdViaje").ToString _
                             , o_fila("Viaje").ToString _
                             , o_fila("IdPiloto").ToString _
                             , o_fila("Piloto").ToString _
                             , o_fila("Total").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("FechaEmision").ToString _
                             , o_fila("IdOrigen").ToString _
                             , o_fila("IdDestino").ToString _
                             , o_fila("Origen").ToString & " - " & o_fila("Destino").ToString _
                             , o_fila("IdCopiloto").ToString _
                             , o_fila("Copiloto").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("IdTipoVehiculo").ToString _
                             , o_fila("Vehiculo").ToString _
                             , o_fila("NombreCompleto").ToString _
                             , 0 _
                             , o_fila("Glosa").ToString _
                             , 0 _
                             , 0 _
                             , 0 _
                             , 0  )
            Return oeGrupoDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CargarDesc(ByVal o_fila As DataRow) As e_GrupoDetalle
        Try
            Dim oeGrupoDetalle = New e_GrupoDetalle(  o_fila("Id").ToString _
                             , o_fila("IdGrupo").ToString _
                             , o_fila("IdMovimiento").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("IdViaje").ToString _
                             , o_fila("Viaje").ToString _
                             , o_fila("IdCuentaCorrienteDestino").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("Ingreso") _
                             , "" _
                             , o_fila("Fecha") _
                             , "" _
                             , "" _
                             , "" _
                             , "" _
                             , "" _
                             , "" _
                             , "" _
                             , "" _
                             , o_fila("NombreCompleto").ToString _
                             , o_fila("Saldo") _
                             , o_fila("Glosa") _
                             , 0 _
                             , 0 _
                             , 0 _
                             , 0  )
            Return oeGrupoDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CargarLiq(ByVal o_fila As DataRow) As e_GrupoDetalle
        Try
            Dim oeGrupoDetalle = New e_GrupoDetalle(  o_fila("Id").ToString _
                             , o_fila("IdGrupo").ToString _
                             , "" _
                             , o_fila("Activo").ToString _
                             , o_fila("IdViaje").ToString _
                             , o_fila("Viaje").ToString _
                             , o_fila("IdPiloto").ToString _
                             , o_fila("Piloto").ToString _
                             , o_fila("Total") _
                             , o_fila("Estado").ToString _
                             , o_fila("Fecha") _
                             , "" _
                             , "" _
                             , o_fila("Ruta").ToString _
                             , o_fila("IdCopiloto").ToString _
                             , o_fila("Copiloto").ToString _
                             , "" _
                             , "" _
                             , o_fila("Vehiculo").ToString _
                             , "" _
                             , 0 _
                             , "" _
                             , 0 _
                             , 0 _
                             , 0 _
                             , 0)
            Return oeGrupoDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CargarFlete(ByVal o_fila As DataRow) As e_GrupoDetalle
        Try
            Dim oeGrupoDetalle = New e_GrupoDetalle(o_fila("Id").ToString _
                             , o_fila("IdGrupo").ToString _
                             , o_fila("IdMovimiento").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("IdViaje").ToString _
                             , o_fila("Viaje").ToString _
                             , o_fila("IdCuentaCorrienteDestino").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("Importe") _
                             , "" _
                             , o_fila("Fecha") _
                             , "" _
                             , "" _
                             , "" _
                             , "" _
                             , "" _
                             , "" _
                             , "" _
                             , "" _
                             , o_fila("NombreCompleto").ToString _
                             , o_fila("Saldo") _
                             , o_fila("Glosa") _
                             , o_fila("Flete") _
                             , o_fila("Cargado") _
                             , o_fila("Depositado") _
                             , o_fila("SaldoPorDepositar") )
            Return oeGrupoDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeGrupoDetalle As e_GrupoDetalle) As e_GrupoDetalle

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "",
            Left(oeGrupoDetalle.PrefijoID, 1), "", oeGrupoDetalle.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeGrupoDetalle = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeGrupoDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeGrupoDetalle As e_GrupoDetalle) As List(Of e_GrupoDetalle)
        Try
            Dim ldGrupoDetalle As New List(Of e_GrupoDetalle)
            Dim ds As DataSet
            With oeGrupoDetalle
                ds = sqlhelper.ExecuteDataset("TES.Isp_GrupoDetalle_Listar", .TipoOperacion _
                        , .Id _
                        , .IdGrupo _
                        , .IdGastoOperacion _
                        , .IdCaja _
                        , .Activo)
            End With
            oeGrupoDetalle = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeGrupoDetalle = Cargar(o_Fila)
                ldGrupoDetalle.Add(oeGrupoDetalle)
            Next
            Return ldGrupoDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDesc(ByVal oeGrupoDetalle As e_GrupoDetalle) As List(Of e_GrupoDetalle)
        Try
            Dim ldGrupoDetalle As New List(Of e_GrupoDetalle)
            Dim ds As DataSet
            With oeGrupoDetalle
                ds = sqlhelper.ExecuteDataset("TES.Isp_GrupoDetalleDesc_Listar", .TipoOperacion _
                        , .Id _
                        , .IdGrupo _
                        , .IdGastoOperacion _
                        , .Activo)
            End With
            oeGrupoDetalle = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeGrupoDetalle = CargarDesc(o_Fila)
                ldGrupoDetalle.Add(oeGrupoDetalle)
            Next
            Return ldGrupoDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function ListarFlete(ByVal oeGrupoDetalle As e_GrupoDetalle) As List(Of e_GrupoDetalle)
        Try
            Dim ldGrupoDetalle As New List(Of e_GrupoDetalle)
            Dim ds As DataSet
            With oeGrupoDetalle
                ds = sqlhelper.ExecuteDataset("TES.Isp_GrupoDetalleFlete_Listar", .TipoOperacion _
                        , .Id _
                        , .IdGrupo _
                        , .IdGastoOperacion _
                        , .Activo)
            End With
            oeGrupoDetalle = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeGrupoDetalle = CargarFlete(o_Fila)
                ldGrupoDetalle.Add(oeGrupoDetalle)
            Next
            Return ldGrupoDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarLiq(ByVal oeGrupoDetalle As e_GrupoDetalle) As List(Of e_GrupoDetalle)
        Try
            Dim ldGrupoDetalle As New List(Of e_GrupoDetalle)
            Dim ds As DataSet ' tipooperacion estaba ""
            With oeGrupoDetalle
                ds = sqlhelper.ExecuteDataset("TES.Isp_GrupoDetalleLiq_Listar", .TipoOperacion _
                        , .Id _
                        , .IdGrupo _
                        , .IdGastoOperacion)
            End With
            oeGrupoDetalle = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeGrupoDetalle = CargarLiq(o_Fila)
                ldGrupoDetalle.Add(oeGrupoDetalle)
            Next
            Return ldGrupoDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeGrupoDetalle As e_GrupoDetalle) As Boolean
        Try
            With oeGrupoDetalle
                sqlhelper.ExecuteNonQuery("TES.Isp_GrupoDetalle_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdGrupo _
                        , .IdGastoOperacion _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarDesc(ByVal oeGrupoDetalle As e_GrupoDetalle) As Boolean
        Try
            With oeGrupoDetalle
                sqlhelper.ExecuteNonQuery("TES.Isp_GrupoDetalleDesc_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdGrupo _
                        , .IdGastoOperacion _
                        , .Activo _
                        , .IndFlete
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarFlete(ByVal oeGrupoDetalle As e_GrupoDetalle) As Boolean
        Try
            With oeGrupoDetalle
                sqlhelper.ExecuteNonQuery("TES.Isp_GrupoDetalleFlete_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdGrupo _
                        , .IdGastoOperacion _
                        , .Importe _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarLiq(ByVal oeGrupoDetalle As e_GrupoDetalle) As Boolean
        Try
            With oeGrupoDetalle
                sqlhelper.ExecuteNonQuery("TES.Isp_GrupoDetalleLiq_IAE", .TipoOperacion,
                        .Id _
                        , .IdGrupo _
                        , .IdGastoOperacion _
                        , .Activo _
                        , .PrefijoID
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeGrupoDetalle As e_GrupoDetalle) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeGrupoDetalle.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
