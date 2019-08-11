Imports ISL.EntidadesWCF

Public Class d_ReporteFondoFijo
    Private sqlhelper As New SqlHelper

    Private oeReporteFondoFijo As New e_ReporteFondoFijo

    Private Function Cargar(ByVal o_fila As DataRow) As e_ReporteFondoFijo
        Try
            Dim oeReporteFondoFijo = New e_ReporteFondoFijo( _
             o_fila("N").ToString, _
             o_fila("Referencia").ToString, _
             o_fila("Ingresos"), _
             o_fila("Egresos"))
            Return oeReporteFondoFijo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeReporteFondoFijo As e_ReporteFondoFijo) As e_ReporteFondoFijo
        Try
            Dim ds As New DataSet
            Dim i As Integer = 0
            ds = sqlhelper.ExecuteDataset("TES.Isp_Reporte_FondoFijo", oeReporteFondoFijo.FechaDesde, oeReporteFondoFijo.FechaHasta)
            oeReporteFondoFijo = New e_ReporteFondoFijo
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeReporteFondoFijo.loFondoFijo(i) = Cargar(ds.Tables(0).Rows(0))
                i = i + 1
            End If
            Return oeReporteFondoFijo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeReporteFondoFijo As e_ReporteFondoFijo) As List(Of e_ReporteFondoFijo)
        Try
            Dim ldReporteFondoFijo As New List(Of e_ReporteFondoFijo)
            '-------------------------------------------------------
            Dim oeFlete As New e_Movimiento_Flete
            Dim oeHabilitacion, oeDescuento As New e_Movimiento_Viaje
            Dim oeLiquidadcion As New e_GastoOperacion
            Dim oeGrupoLiquidacion, oeGrupoDescuento, oeGrupoCajaChica, oeGrupoFlete As New e_Grupo
            Dim oeGastoCajaChica As New e_Movimiento_Administrativo

            Dim odMovimiento_Flete As New d_Movimiento_Flete
            Dim odMovimiento As New d_Movimiento_Viaje
            Dim odGastoOperacion As New d_GastoOperacion
            Dim odGrupo As New d_Grupo
            Dim odMovimiento_Administrativo As New d_Movimiento_Administrativo
            '-------------------------------------------------------

            Dim ds As DataSet
            Dim i As Integer = 0
            With oeReporteFondoFijo
                ds = sqlhelper.ExecuteDataset("TES.Isp_Reporte_FondoFijo")
            End With
            oeReporteFondoFijo = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    ldReporteFondoFijo.Add(Cargar(o_Fila))
                Next

                Return ldReporteFondoFijo
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        Finally

        End Try
    End Function

    Public Function ListarFondo(ByVal oeReporteFondoFijo As e_ReporteFondoFijo) As e_ReporteFondoFijo
        Try
            Dim ldReporteFondoFijo As New List(Of e_ReporteFondoFijo)
            '-------------------------------------------------------
            Dim oeFlete As New e_Movimiento_Flete
            Dim oeHabilitacion, oeDescuento As New e_Movimiento_Viaje
            Dim oeLiquidadcion As New e_GastoOperacion
            Dim oeGrupoLiquidacion, oeGrupoDescuento, oeGrupoCajaChica, oeGrupoFlete As New e_Grupo
            Dim oeGastoCajaChica As New e_Movimiento_Administrativo
            Dim oeCajaExterna As New e_GastoOperacion

            Dim oePrestamosCuenta As New e_PrestamosCuenta

            Dim odMovimiento_Flete As New d_Movimiento_Flete
            Dim odMovimiento As New d_Movimiento_Viaje
            Dim odGastoOperacion As New d_GastoOperacion
            Dim odGrupo As New d_Grupo
            Dim odMovimiento_Administrativo As New d_Movimiento_Administrativo
            Dim odPrestamosCuenta As New d_PrestamosCuenta

            Dim oeValesRendir As New e_ValesRendir
            Dim odValesRendir As New d_ValesRendir

            Dim oeOtrosIngresos As New e_OtrosIngresos
            Dim odOtrosIngresos As New d_OtrosIngresos
            '-------------------------------------------------------

            Dim ds As DataSet
            Dim i As Integer = 0
            With oeReporteFondoFijo
                ds = sqlhelper.ExecuteDataset("TES.Isp_Reporte_FondoFijo")
            End With
            '         oeReporteFondoFijo = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    ldReporteFondoFijo.Add(Cargar(o_Fila))
                Next

                With oeReporteFondoFijo
                    .loFondoFijo = ldReporteFondoFijo

                    oeFlete.TipoOperacion = "7"
                    .loFlete = odMovimiento_Flete.Listar(oeFlete)

                    oeHabilitacion.Estado = "HABILITADA"
                    oeHabilitacion.TipoOperacion = "H"
                    oeHabilitacion.Activo = True
                    .loHabilitacion = odMovimiento.Listar(oeHabilitacion)

                    oeLiquidadcion.TipoOperacion = "7"
                    oeLiquidadcion.TipoMovimiento = 1
                    oeLiquidadcion.Activo = True
                    oeLiquidadcion.IdEstado = "LIQUIDADA"
                    .loLiquidacion = odGastoOperacion.Listar(oeLiquidadcion)

                    oeGrupoLiquidacion.TipoOperacion = 6
                    oeGrupoLiquidacion.Estado = "FONDOFIJO"
                    .loGrupoLiquidacion = odGrupo.Listar(oeGrupoLiquidacion)

                    oeDescuento.TipoOperacion = "5"
                    oeDescuento.TipoTransa = 4
                    oeDescuento.Activo = True
                    .loDescuento = odMovimiento.Listar(oeDescuento)

                    oeGastoCajaChica.TipoOperacion = "3"
                    oeGastoCajaChica.IdCaja = "1CH001"
                    oeGastoCajaChica.TipoTransa = 1
                    .loGastoCajaChica = odMovimiento_Administrativo.Listar(oeGastoCajaChica)

                    oeGrupoFlete.Tipo = 3
                    oeGrupoFlete.TipoOperacion = 0
                    oeGrupoFlete.Estado = "ENVIADO"
                    .loGrupoFlete = odGrupo.Listar(oeGrupoFlete)

                    oePrestamosCuenta.TipoOperacion = "2"
                    oePrestamosCuenta.Fecha = Date.Parse("01/01/1901")
                    oePrestamosCuenta.FechaHasta = Date.Parse("01/01/1901")
                    oePrestamosCuenta.IdCentro = "1CH001"
                    .loPrestamosCuenta = odPrestamosCuenta.Listar(oePrestamosCuenta)

                    oeValesRendir.TipoOperacion = "1"
                    oeValesRendir.Fecha = Date.Parse("01/01/1901")
                    .loValesRendir = odValesRendir.Listar(oeValesRendir)

                    oeOtrosIngresos.TipoOperacion = "2"
                    .loOtrosIngresos = odOtrosIngresos.Listar(oeOtrosIngresos)

                End With
                Return oeReporteFondoFijo
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
