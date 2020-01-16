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

Public Class d_GastoOperacion

    Private sqlhelper As New SqlHelper

    Dim odGastoRegConsumoCombustible As New d_Gasto_RegistroConsumoCombustible
    Dim oeGastoRegConsumoCombustible As New e_Gasto_RegistroConsumoCombustible
    Dim odRegConsumoCombustible As New d_RegistroConsumoCombustible
    Dim oeRegConsumoCombustible As New e_RegistroConsumoCombustible
    Dim odMovimientoDocumento As New d_MovimientoDocumento

    Private Function Cargar(ByVal o_fila As DataRow) As e_GastoOperacion
        Try
            Dim oeGastoOperacion = New e_GastoOperacion( _
                             o_fila("Id").ToString _
                             , o_fila("IdCuentaCorriente").ToString _
                             , o_fila("TipoMovimiento").ToString _
                             , o_fila("IdFlujoCaja").ToString _
                             , o_fila("FlujoCaja").ToString _
                             , o_fila("IdDocumento").ToString _
                             , o_fila("IdPeriodo").ToString _
                             , o_fila("Periodo").ToString _
                             , o_fila("Serie") _
                             , o_fila("Nro") _
                             , o_fila("IdTipoDocumento").ToString _
                             , o_fila("TipoDoc").ToString _
                             , o_fila("IdViaje").ToString _
                             , o_fila("IdClienteProveedor").ToString _
                             , o_fila("Proveedor").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("TipoCambio") _
                             , o_fila("IdMoneda").ToString _
                             , o_fila("Moneda").ToString _
                             , o_fila("SubTotal") _
                             , o_fila("IGV") _
                             , o_fila("Importe") _
                             , o_fila("IdEstado").ToString _
                             , o_fila("IdGrupo").ToString _
                             , o_fila("NroGrupo").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Fecha").ToString _
                            , o_fila("Viaje").ToString _
                            , o_fila("IdPiloto").ToString _
                            , o_fila("Piloto").ToString _
                            , o_fila("IdTipoVehiculo").ToString _
                            , o_fila("Vehiculo").ToString _
                            , o_fila("IdCopiloto").ToString _
                            , o_fila("Copiloto").ToString _
                            , o_fila("IdOrigen").ToString _
                            , o_fila("Origen").ToString _
                            , o_fila("IdDestino").ToString _
                            , o_fila("Destino").ToString _
                            , o_fila("Estado").ToString _
                            , o_fila("Origen").ToString & " - " & o_fila("Destino").ToString _
                            , o_fila("IdAsiento").ToString _
                            , o_fila("IndAlmacen").ToString _
                            , o_fila("IdTrabajadorAutoriza").ToString _
                            , o_fila("TrabajadorAutoriza").ToString _
                            , o_fila("IndGasto").ToString _
                            , o_fila("IdTarjetaMovimiento").ToString)
            Return oeGastoOperacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeGastoOperacion As e_GastoOperacion) As e_GastoOperacion
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_GastoOperacion_Listar", oeGastoOperacion.TipoOperacion, oeGastoOperacion.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeGastoOperacion = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeGastoOperacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeGastoOperacion As e_GastoOperacion) As List(Of e_GastoOperacion)
        Try
            Dim ldGastoOperacion As New List(Of e_GastoOperacion)
            Dim ds As DataSet
            With oeGastoOperacion
                ds = sqlhelper.ExecuteDataset("TES.Isp_GastoOperacion_Listar", .TipoOperacion _
                        , .Id _
                        , .IdCuentaCorriente _
                        , .TipoMovimiento _
                        , .IdFlujoCaja _
                        , .IdDocumento _
                        , .IdViaje _
                        , .FechaEmision _
                        , .IdEstado _
                        , .IdGrupo _
                        , .UsuarioCreacion _
                        , .IdCaja _
                        , .IndGasto _
                        , .FechaCreacion)
            End With
            oeGastoOperacion = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeGastoOperacion = Cargar(o_Fila)
                ldGastoOperacion.Add(oeGastoOperacion)
            Next
            Return ldGastoOperacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarSimple(ByVal oeGastoOperacion As e_GastoOperacion) As Boolean
        Try
            With oeGastoOperacion
                sqlhelper.ExecuteNonQuery("TES.Isp_GastoOperacion_IAE", .TipoOperacion,
                        .Id _
                        , .IdCuentaCorriente _
                        , .TipoMovimiento _
                        , .IdFlujoCaja _
                        , "" _
                        , .IdViaje _
                        , .FechaEmision _
                        , .Glosa _
                        , .Total _
                        , .IdEstado _
                        , .IdGrupo _
                        , .UsuarioCreacion _
                        , .Activo _
                        , .PrefijoID _
                        , 0 _
                        , .FechaCierre,
                        "",
                        "",
                        0,
                        .IdCaja,
                        .IndGasto)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeGastoOperacion As e_GastoOperacion) As Boolean
        Dim oeMovimientoDocumento22 As New e_MovimientoDocumento
        Try
            Dim oeMovimientoDocumento As New e_MovimientoDocumento
            Dim odGasto As New d_GastoOperacion
            With oeGastoOperacion
                'G:gasto operacion se le asigan un grupo, L: Liquida 
                If .TipoOperacion <> "G" AndAlso .TipoOperacion <> "L" AndAlso .IdTipoDocumento <> "1CH000000062" Then 'Vale de caja
                    oeMovimientoDocumento22 = .oeMovimientoDocumento
                    oeMovimientoDocumento22.FechaVencimiento = oeMovimientoDocumento22.FechaEmision
                    If .oeMovimientoDocumento.IdTipoDocumento = "1CH000000073" Then
                        .oeMovimientoDocumento.IndCompraVenta = -1
                    ElseIf .oeMovimientoDocumento.IdTipoDocumento = "1SI000000001" Then
                        .oeMovimientoDocumento.IndCompraVenta = -1
                    Else
                        .oeMovimientoDocumento.IndCompraVenta = 1
                    End If
                    .oeMovimientoDocumento.PrefijoID = oeGastoOperacion.PrefijoID '@0001
                    odMovimientoDocumento.GuardarGastoOperacion(.oeMovimientoDocumento)
                    .IdDocumento = .oeMovimientoDocumento.Id
                End If
                If Not odGasto.GuardarGasto(oeGastoOperacion) Then
                    Return False
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarGasto(oeGastoOperacion As e_GastoOperacion) As Boolean
        Try
            Dim odAsiento As New d_Asiento
            Dim odGastoCaja As New d_Gasto_Caja
            Dim idGastoOpe As String = ""

            Dim IdRegComb As String = ""
            With oeGastoOperacion
                .Id = sqlhelper.ExecuteScalar("TES.Isp_GastoOperacion_IAE", .TipoOperacion,
                        .Id, .IdCuentaCorriente, .TipoMovimiento, .IdFlujoCaja, .IdDocumento _
                        , .IdViaje, .FechaEmision, .Glosa, .Total, .IdEstado, .IdGrupo, .UsuarioCreacion _
                        , .Activo, .PrefijoID, .IndAlmacen, .FechaEmision, .IdProveedor _
                        , .IdTipoDocumento, .SubTotal, .IdCaja, .IdTrabajadorAutoriza, .IdLugar, .IndGasto)
                idGastoOpe = .Id
                If .oeRegistroCombustible IsNot Nothing Then
                    .oeRegistroCombustible.TipoOperacion = "I"
                    .oeRegistroCombustible.Ind_GastoViaje = 1
                    .oeRegistroCombustible.PrefijoID = oeGastoOperacion.PrefijoID '@0001
                    With oeGastoOperacion.oeRegistroCombustible
                        IdRegComb = sqlhelper.ExecuteScalar("[ALM].[Isp_RegistroConsumoCombustible_IAE]",
                                            .TipoOperacion,
                                            .PrefijoID,
                                            .Id _
                                            , .IdViaje _
                                            , .IdVehiculo _
                                            , .IdPiloto _
                                            , .FechaTanqueo _
                                            , .CantidadGalon _
                                            , .KilometrosTanqueo _
                                            , .NroVale _
                                            , .IndCredito _
                                            , .IndTanqueo _
                                            , .IdGrifo _
                                            , .IdDireccion _
                                            , .IdMaterial _
                                            , .SaldoGls _
                                            , .Estado _
                                            , .Activo _
                                            , .UsuarioCreacion _
                                            , .Ind_GastoViaje _
                                            , False)
                        oeGastoRegConsumoCombustible.TipoOperacion = "I"
                        oeGastoRegConsumoCombustible.IdGastoOperacion = idGastoOpe
                        oeGastoRegConsumoCombustible.IdRegistroConsumoCombustible = IdRegComb
                        oeGastoRegConsumoCombustible.PrefijoID = oeGastoOperacion.PrefijoID '@0001
                        odGastoRegConsumoCombustible.Guardar(oeGastoRegConsumoCombustible)
                    End With
                End If
                'G:gasto operacion se le asigan un grupo, L: Liquida 
                If .TipoOperacion <> "G" AndAlso .TipoOperacion <> "L" AndAlso .IdViaje = "" Then
                    If .oeGasto_Caja.id = "" Then .oeGasto_Caja.TipoOperacion = "I"
                    .oeGasto_Caja.IdGastoOperacion = idGastoOpe
                    .oeGasto_Caja.PrefijoID = oeGastoOperacion.PrefijoID '@0001
                    odGastoCaja.Guardar(.oeGasto_Caja)
                    If .oeGasto_Caja.TipoOperacion = "I" And .oeGasto_Caja.IndCompraAlmacen Then
                        .oeMovimientoDocumento.TipoOperacion = "CAM"
                        .oeMovimientoDocumento.PrefijoID = oeGastoOperacion.PrefijoID '@0001
                        odMovimientoDocumento.GuardarGastoOperacion(.oeMovimientoDocumento)
                    End If
                End If
                If Not .GastoAsiento Is Nothing Then
                    If .GastoAsiento.TipoOperacion = "I" Then
                        Dim odGastoAsiento As New d_GastoAsiento
                        .GastoAsiento.IdGastoOperacion = idGastoOpe
                        .GastoAsiento.PrefijoID = oeGastoOperacion.PrefijoID '@0001
                        .oeAsiento.PrefijoID = oeGastoOperacion.PrefijoID '@0001
                        odGastoAsiento.Guardar(.GastoAsiento, .oeAsiento)
                    End If
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeGastoOperacion As e_GastoOperacion) As Boolean
        Try
            With oeGastoOperacion
                sqlhelper.ExecuteNonQuery("TES.Isp_GastoOperacion_IAE", "E", _
                                          .Id _
                                          , .IdCuentaCorriente _
                                        , .TipoMovimiento _
                                        , .IdFlujoCaja _
                                        , "" _
                                        , .IdViaje _
                                        , .FechaEmision _
                                        , .Glosa _
                                        , .Total _
                                        , .IdEstado _
                                        , .IdGrupo _
                                        , .UsuarioCreacion _
                                        , .Activo _
                                        , "" _
                                        , .IndAlmacen _
                                        , .FechaEmision _
                                        , .IdProveedor _
                                        , .IdTipoDocumento)
            End With
            If oeGastoOperacion.IdDocumento.Trim <> "" Then
                Dim odMovimientoDocumento As New d_MovimientoDocumento
                Dim oeMovimientoDocumento As New e_MovimientoDocumento
                oeMovimientoDocumento.Id = oeGastoOperacion.IdDocumento
                odMovimientoDocumento.EliminarDocumentoyPago(oeMovimientoDocumento)
                If oeGastoOperacion.IdTipoDocumento = "1CH000000073" Then
                    If oeGastoOperacion.IdAsiento <> "" Then
                        EliminarAsiento(oeGastoOperacion.IdAsiento)
                    End If
                End If
            Else
                If oeGastoOperacion.IdAsiento <> "" Then
                    EliminarAsiento(oeGastoOperacion.IdAsiento)
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function EliminarAsiento(IdAsiento) As Boolean
        Try
            Dim odAsiento As New d_Asiento
            Dim oeAsiento As New e_Asiento
            oeAsiento.Id = IdAsiento
            odAsiento.Eliminar(oeAsiento)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarLista(ByVal leGastoOpe As List(Of e_GastoOperacion)) As Boolean
        Try
            Using transScope As New TransactionScope
                Dim odGastoViatico As New d_GastoViatico
                For Each oeGastoOpe As e_GastoOperacion In leGastoOpe
                    If oeGastoOpe.TipoOperacion = "I" Then Guardar(oeGastoOpe)
                    If oeGastoOpe.TipoOperacion = "E" Then Eliminar(oeGastoOpe)
                    If oeGastoOpe.TipoOperacion = "A" Then ActualizarGO(oeGastoOpe)
                Next
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex 
        End Try
    End Function

    Public Function GuardaMasivo(loGastoOperacion As List(Of e_GastoOperacion), DTDocumento As DataTable, DTDetalle As DataTable, DTCompra As DataTable, _
                                 DTAsiento As DataTable, DTAsiMov As DataTable, DTMovAna As DataTable, DTMovCajBan As DataTable, DTAsiMovDoc As DataTable, _
                                 DTAsiMovMovDoc As DataTable, DTCtaCyP As Data.DataTable) As Boolean
        Try
            ' Dim odGastoOperacion As New d_GastoOperacion
            Using Transaction As New TransactionScope
                If DTDocumento.Rows.Count > 0 Then sqlhelper.InsertarMasivo("CON.MovimientoDocumento", DTDocumento, False)
                If DTDetalle.Rows.Count > 0 Then sqlhelper.InsertarMasivo("CON.DetalleDocumento", DTDetalle, False)
                If DTCompra.Rows.Count > 0 Then sqlhelper.InsertarMasivo("CON.Compra", DTCompra, False)
                If DTAsiento.Rows.Count > 0 Then sqlhelper.InsertarMasivo("CON.Asiento", DTAsiento, False)
                If DTAsiMovDoc.Rows.Count > 0 Then sqlhelper.InsertarMasivo("CON.Asiento_MovDoc", DTAsiMovDoc, False)
                If DTAsiMov.Rows.Count > 0 Then sqlhelper.InsertarMasivo("CON.AsientoMovimiento", DTAsiMov, False)
                If DTMovCajBan.Rows.Count > 0 Then sqlhelper.InsertarMasivo("CON.MovimientoCajaBanco", DTMovCajBan, False)
                If DTCtaCyP.Rows.Count > 0 Then sqlhelper.InsertarMasivo("TES.CuentaxCyP", DTCtaCyP, False)
                If DTAsiMovMovDoc.Rows.Count > 0 Then sqlhelper.InsertarMasivo("CON.AsientoMov_MovDoc", DTAsiMovMovDoc, False)
                If DTMovAna.Rows.Count > 0 Then sqlhelper.InsertarMasivo("CON.MovimientoAnalisis", DTMovAna, False)
                For Each oeGastoOpe As e_GastoOperacion In loGastoOperacion
                    If oeGastoOpe.TipoOperacion = "I" Then GuardarGasto(oeGastoOpe)
                    'If oeGastoOpe.TipoOperacion = "E" Then Eliminar(oeGastoOpe)
                    'If oeGastoOpe.TipoOperacion = "A" Then ActualizarGO(oeGastoOpe)
                Next
                Transaction.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ActualizarGO(ByVal oeGastoOperacion As e_GastoOperacion) As Boolean
        Try
            Dim Id As String = ""
            With oeGastoOperacion
                Id = sqlhelper.ExecuteScalar("TES.Isp_GastoOperacion_IAE", .TipoOperacion, _
                        .Id _
                        , .IdCuentaCorriente _
                        , .TipoMovimiento _
                        , .IdFlujoCaja _
                        , "" _
                        , .IdViaje _
                        , .FechaEmision _
                        , .Glosa)
                Return True
            End With
        Catch ex As Exception
            Throw ex 
        End Try
    End Function

End Class
