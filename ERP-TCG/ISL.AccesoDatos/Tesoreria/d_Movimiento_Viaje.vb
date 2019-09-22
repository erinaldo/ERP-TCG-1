Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Movimiento_Viaje

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Movimiento_Viaje
        Try
            Dim oeMovimiento_Viaje = New e_Movimiento_Viaje( _
                             o_fila("Id").ToString _
                             , o_fila("IdMovimiento").ToString _
                             , o_fila("IdViaje").ToString _
                             , o_fila("Viaje").ToString _
                             , o_fila("IdPiloto").ToString _
                             , o_fila("Piloto").ToString _
                             , o_fila("IdTipoVehiculo").ToString _
                             , o_fila("TipoVehiculo").ToString _
                             , o_fila("IdTracto").ToString _
                             , o_fila("Tracto").ToString _
                             , o_fila("Carreta").ToString _
                             , o_fila("Ingreso").ToString _
                             , o_fila("Egreso").ToString _
                             , o_fila("Saldo").ToString _
                             , o_fila("Voucher").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("Fecha") _
                             , o_fila("Origen").ToString + " - " + o_fila("Destino").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("IdTrabajadorRecepciona").ToString _
                             , o_fila("TipoTrabajador").ToString _
                             , o_fila("RecibeBolsa").ToString _
                             , o_fila("FechaRecepcion").ToString _
                             , o_fila("TipoTransa").ToString _
                             , o_fila("IngresoTotal").ToString _
                             , o_fila("EgresoTotal").ToString _
                             , o_fila("SaldoTotal").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("GastosRendidos") _
                             , o_fila("FechaLiquidacion") _
                             , o_fila("FechaReembolso") _
                             , o_fila("IdOperacion").ToString _
                             , o_fila("Operacion").ToString _
                             , o_fila("Descuento").ToString _
                             , o_fila("SalidaOrigen") _
                             , o_fila("LlegadaDestino") _
                             , o_fila("Carga").ToString _
                             , o_fila("Copiloto").ToString _
                             , o_fila("DiasAtrasados"))
            Return oeMovimiento_Viaje
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMovimiento_Viaje As e_Movimiento_Viaje) As e_Movimiento_Viaje
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ds As DataSet
            With oeMovimiento_Viaje
                ds = sqlhelper.ExecuteDataset("TES.Isp_Movimiento_Viaje_Listar", _
                                             .TipoOperacion, _
                                             .Id, _
                                             .IdMovimiento, _
                                             .TipoTransa, _
                                             .IdViaje, _
                                             .Viaje, _
                                             .IdPiloto, _
                                             .IdTracto, _
                                             .VincularViajePiloto)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeMovimiento_Viaje = Cargar(ds.Tables(0).Rows(0))
            Else
                oeMovimiento_Viaje = New e_Movimiento_Viaje
            End If
            Return oeMovimiento_Viaje
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMovimiento_Viaje As e_Movimiento_Viaje) As List(Of e_Movimiento_Viaje)
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ldMovimiento_Viaje As New List(Of e_Movimiento_Viaje)
            Dim ds As DataSet
            With oeMovimiento_Viaje
                ds = sqlhelper.ExecuteDataset("TES.Isp_Movimiento_Viaje_Listar", .TipoOperacion _
                        , .Id _
                        , .IdMovimiento _
                        , .TipoTransa _
                        , .IdViaje _
                        , .Viaje _
                        , .IdPiloto _
                        , .IdTracto _
                        , .VincularViajePiloto _
                        , .FechaDesde _
                        , .FechaHasta _
                        , .Activo _
                        , .Estado _
                        , .IdOperacion _
                        , .IndViajeVacio)
            End With
            oeMovimiento_Viaje = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMovimiento_Viaje = Cargar(o_Fila)
                    ldMovimiento_Viaje.Add(oeMovimiento_Viaje)
                Next
            End If
            Return ldMovimiento_Viaje
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeMovimiento_Viaje As e_Movimiento_Viaje) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeMovimiento_Viaje
                sqlhelper.ExecuteNonQuery("TES.Isp_Movimiento_Viaje_IAE", .TipoOperacion, .PrefijoID, _
                        "" _
                        , .IdMovimiento _
                        , .IdViaje _
                        , .IdTrabajadorRecepciona _
                        , .IdTrabajadorClave _
                        , .FechaRecepcion _
                        , .TipoTRB _
                        , .FechaLiquidacion _
                        , .FechaReembolso)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeMovimiento_Viaje As e_Movimiento_Viaje) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_Movimiento_Viaje_IAE", "E", _
             "", oeMovimiento_Viaje.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
