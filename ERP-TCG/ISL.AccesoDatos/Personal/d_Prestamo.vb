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

Public Class d_Prestamo
   
    Private sqlhelper As New SqlHelper
    Dim oeDetalle As New e_PrestamoDetalle
    Dim odDetalle As New d_PrestamoDetalle

    Private Function Cargar(ByVal o_fila As DataRow) As e_Prestamo
        Try
            Dim oePrestamo = New e_Prestamo( _
                             o_fila("Id").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("Monto") _
                             , o_fila("Saldo") _
                             , o_fila("CantidadCuotas") _
                             , o_fila("Cancelado") _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("IdConcepto").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Fecha") _
                             , o_fila("FechaCese") _
                             , o_fila("ConceptoPrestamo").ToString _
                             , o_fila("GlosaCancelado").ToString _
                             , o_fila("FechaCancelado") _
                             , o_fila("FechaIntegracion") _
                             , o_fila("Dni").ToString _
                             , o_fila("IdCuentaBancaria").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("UsuarioAprueba").ToString _
                             , o_fila("FechaAprueba") _
            )
            Return oePrestamo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CargarRDT(ByVal o_fila As DataRow) As e_ReporteDescTrabajador
        Try
            Dim oeRDT = New e_ReporteDescTrabajador( _
                              o_fila("IdTrabajador").ToString _
                             , o_fila("Dni").ToString _
                             , o_fila("NombreCompleto").ToString _
                             , o_fila("Activo") _
                             , o_fila("Adelanto") _
                             , o_fila("Sancion") _
            )
            Return oeRDT
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oePrestamo As e_Prestamo) As e_Prestamo

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_Prestamo_Listar", "", oePrestamo.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oePrestamo = Cargar(ds.Tables(0).Rows(0))
                'Cargar Detalle de Prestamo
                oeDetalle = New e_PrestamoDetalle
                oeDetalle.IdPrestamo = oePrestamo.Id
                oeDetalle.Cancelado = -1
                oeDetalle.Anulado = 0
                oeDetalle.Activo = 1
                oePrestamo.leDetalle = odDetalle.Listar(oeDetalle)
                'Cargar Historial de Prestamo
                oeDetalle = New e_PrestamoDetalle
                oeDetalle.IdPrestamo = oePrestamo.Id
                oeDetalle.Cancelado = 1
                oeDetalle.Anulado = 1
                oeDetalle.Activo = 1
                oePrestamo.leHistorial = odDetalle.Listar(oeDetalle)
            End If
            Return oePrestamo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oePrestamo As e_Prestamo) As List(Of e_Prestamo)
        Try
            Dim ldPrestamo As New List(Of e_Prestamo)
            Dim ds As DataSet
            With oePrestamo
                ds = sqlhelper.ExecuteDataset("TES.Isp_Prestamo_Listar", .TipoOperacion _
                        , .Id _
                        , .IdTrabajador _
                        , .Glosa _
                        , .Monto _
                        , .Saldo _
                        , .CantidadCuotas _
                        , .Cancelado _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .IdConcepto _
                        , .Activo _
                        , .fecInicio _
                        , .fecFin _
                        , .lsGruposDescuentos _
                        , .IdEstado _
                        )
            End With
            oePrestamo = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oePrestamo = Cargar(o_Fila)
                ldPrestamo.Add(oePrestamo)
            Next
            Return ldPrestamo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarRDT(ByVal oeRDT As e_ReporteDescTrabajador) As List(Of e_ReporteDescTrabajador)
        Try
            Dim leRDT As New List(Of e_ReporteDescTrabajador)
            Dim ds As DataSet
            With oeRDT
                ds = sqlhelper.ExecuteDataset("PER.Isp_CobroPrestamo_Lista ", .TipoOperacion _
                        , .oeTrabajador.Id _
                        , .Anio _
                        , .Mes _
                        , .Indicador _
                        )
            End With
            oeRDT = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeRDT = CargarRDT(o_Fila)
                leRDT.Add(oeRDT)
            Next
            Return leRDT
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDS(ByVal oePrestamo As e_Prestamo) As Data.DataSet
        Try
            With oePrestamo
                Return sqlhelper.ExecuteDataset("TES.Isp_ReportePrestamo", .TipoOperacion, .IdTrabajador, ._anio, ._mes, .fecInicio, .fecFin)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDT(ByVal oePrestamo As e_Prestamo) As Data.DataTable
        Try
            Dim ds As DataSet

            With oePrestamo
                ds = sqlhelper.ExecuteDataset("TES.Isp_Prestamo_Listar", .TipoOperacion, .Id, .IdTrabajador)
            End With
            oePrestamo = Nothing

            Return ds.Tables(0)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarPrest(ByRef oePrestamo As e_Prestamo) As Boolean
        Try
            Dim id As String
            With oePrestamo
                id = sqlhelper.ExecuteScalar("TES.Isp_Prestamo_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdTrabajador _
                        , .Glosa _
                        , .Monto _
                        , .Saldo _
                        , .CantidadCuotas _
                        , .Cancelado _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .IdConcepto.Trim _
                        , .Activo _
                        , .Fecha _
                        , .GlosaCancelado _
                        , .FechaCancelado _
                        , .FechaIntegracion _
                        , .IdCtaBancaria _
                        , .IdEstado _
                        , .UsuarioAprueba _
                        , .FechaAprueba
                    )
                .Id = id

                For Each oeDet As e_PrestamoDetalle In .leDetalle
                    oeDet.IdPrestamo = .Id
                    oeDet.PrefijoID = oePrestamo.PrefijoID '@0001
                    If oeDet.TipoOperacion.Trim <> "" Then
                        If oeDet.TipoOperacion.Trim = "E" Then
                            odDetalle.Eliminar(oeDet)
                        Else
                            odDetalle.Guardar(oeDet)
                        End If
                    End If
                Next

            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Guardar(ByRef oePrestamo As e_Prestamo, Optional ByVal UsaTransaccion As Boolean = True) As Boolean
        Try
            If UsaTransaccion Then
                Using transScope As New TransactionScope
                    GuardarPrest(oePrestamo)
                    transScope.Complete()
                End Using
            Else
                GuardarPrest(oePrestamo)
            End If
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarLista(ByVal lePrestamo As List(Of e_Prestamo), ByVal IdGrupo As String, ByVal GrupoDesc As String, ByVal PrefijoID As String) As Boolean
        Try
            Dim odPrestamoSancion As New d_Prestamo_Sancion
            Dim odGrupoSancion As New d_GrupoSancion
            Using TransScope As New TransactionScope()
                For Each oePrest As e_Prestamo In lePrestamo
                    oePrest.PrefijoID = PrefijoID '@0001
                    Guardar(oePrest, False)
                    If oePrest.leSancion.Count > 0 Then
                        For Each oePrestSanc As e_Prestamo_Sancion In oePrest.leSancion
                            oePrestSanc.IdPrestamo = oePrest.Id
                            oePrestSanc.PrefijoID = PrefijoID '@0001
                            odPrestamoSancion.Guardar(oePrestSanc)
                        Next
                    End If
                Next
                If IdGrupo.Trim <> "" Then
                    Dim oeGrupo As New e_GrupoSancion
                    oeGrupo.TipoOperacion = "R" : oeGrupo.Tipo = 1 : oeGrupo._CadenaId = IdGrupo
                    oeGrupo.PrefijoID = PrefijoID '@0001
                    odGrupoSancion.Guardar(oeGrupo)
                End If
                If GrupoDesc.Trim <> "" Then
                    Dim oeGrupo As New e_GrupoSancion
                    oeGrupo.TipoOperacion = "R" : oeGrupo.Tipo = 2 : oeGrupo._CadenaId = GrupoDesc
                    oeGrupo.PrefijoID = PrefijoID '@0001
                    odGrupoSancion.Guardar(oeGrupo)
                End If
                TransScope.Complete()
                Return True
            End Using

        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Liquidar(ByVal lePrestamo As List(Of e_Prestamo)) As Boolean
        Try
            Using TransScope As New TransactionScope()
                For Each oePrest In lePrestamo
                    Guardar(oePrest, False)
                Next
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oePrestamo As e_Prestamo) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_Prestamo_IAE", "E", "", oePrestamo.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function CobrarCuota(ByVal leCargoPendiente As List(Of e_Prestamo), ByVal leCuotaCargoPend As List(Of e_PrestamoDetalle)) As Boolean
        Try
            Using TransScope As New TransactionScope()
                For Each oeCP In leCargoPendiente
                    GuardarPrest(oeCP)
                Next
                For Each oeCCP In leCuotaCargoPend
                    odDetalle.Guardar(oeCCP)
                Next
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarLista2(ByVal leDescuento As List(Of e_Prestamo)) As Boolean
        Try
            Using TransScope As New TransactionScope()
                For Each oeDscto In leDescuento
                    Guardar(oeDscto, False)
                Next
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function TransferirDeuda(ByVal oePrestamo As e_Prestamo, oePrestTrans As e_Prestamo) As Boolean
        Try
            Using TransScope As New TransactionScope()

                Dim _id As String = ""
                With oePrestamo
                    _id = sqlhelper.ExecuteScalar("TES.Isp_Prestamo_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .IdTrabajador _
                        , .Glosa _
                        , .Monto _
                        , .Saldo _
                        , .CantidadCuotas _
                        , .Cancelado _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .IdConcepto.Trim _
                        , .Activo _
                        , .Fecha _
                        , .GlosaCancelado _
                        , .FechaCancelado _
                        , .FechaIntegracion _
                        , .IdCtaBancaria _
                        , .IdEstado _
                        , .UsuarioAprueba _
                        , .FechaAprueba _
                    )
                    For Each oeDetHist In .leHistorial
                        If oeDetHist.TipoOperacion.Trim <> "" Then
                            If oeDetHist.TipoOperacion.Trim = "E" Then
                                odDetalle.Eliminar(oeDetHist)
                            Else
                                odDetalle.Guardar(oeDetHist)
                            End If
                        End If
                    Next
                    For Each oeDet In .leDetalle
                        If oeDet.TipoOperacion.Trim <> "" Then
                            If oeDet.TipoOperacion.Trim = "E" Then
                                odDetalle.Eliminar(oeDet)
                            Else
                                oeDet.IdPrestamo = .Id
                                odDetalle.Guardar(oeDet)
                            End If
                        End If
                    Next
                End With
                'With oePrestTrans
                '    _id = sqlhelper.ExecuteScalar("TES.Isp_Prestamo_IAE", .TipoOperacion, .PrefijoID, _
                '       .Id _
                '       , .IdTrabajador _
                '       , .Glosa _
                '       , .Monto _
                '       , .Saldo _
                '       , .CantidadCuotas _
                '       , .Cancelado _
                '       , .FechaCreacion _
                '       , .UsuarioCreacion _
                '       , .IdConcepto.Trim _
                '       , .Activo _
                '       , .Fecha _
                '       , .GlosaCancelado _
                '       , .FechaCancelado _
                '       , .FechaIntegracion _
                '       , .IdCtaBancaria _
                '       , .IdEstado _
                '       , .UsuarioAprueba _
                '       , .FechaAprueba _
                '   )
                'End With
                GuardarPrest(oePrestTrans)
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function


End Class