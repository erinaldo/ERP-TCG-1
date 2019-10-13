'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions

Public Class d_RegistroInventario

    Private sqlhelper As New SqlHelper
    Dim odDetalleAsignacion As New d_DetalleAsignacion
    Dim odInventario As New d_Inventario

    Private Function Cargar(ByVal o_fila As DataRow) As e_RegistroInventario
        Try
            Dim oeRegistroInventario = New e_RegistroInventario( _
                             o_fila("Id").ToString _
                             , o_fila("NroMovimiento").ToString _
                             , o_fila("IdMovimientoInventario").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("IdLote").ToString _
                             , o_fila("IdMaterial").ToString _
                             , o_fila("IdUnidadMedida").ToString _
                             , o_fila("Cantidad").ToString _
                             , o_fila("CantidadReal").ToString _
                             , o_fila("ValorUnitario").ToString _
                             , o_fila("ValorUnitarioReal").ToString _
                             , o_fila("ValorTotal").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("IdOrden").ToString)
            Return oeRegistroInventario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CargarSOrden(ByVal o_fila As DataRow) As e_RegistroInventario
        Try
            Dim oeRegistroInventario = New e_RegistroInventario( _
                             o_fila("Id").ToString _
                             , o_fila("NroMovimiento").ToString _
                             , o_fila("IdMovimientoInventario").ToString _
                             , o_fila("IdMaterial").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Cantidad").ToString _
                             , o_fila("CantidadReal").ToString _
                             , o_fila("IdUnidadMedida").ToString _
                             , o_fila("Unidad").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("IdSubAlmacen").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("IdAlmacen").ToString _
                             , o_fila("NombreAlmacen").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("NombreUsuario").ToString _
                             , o_fila("ValorUnitario"))
            Return oeRegistroInventario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeRegistroInventario As e_RegistroInventario) As e_RegistroInventario
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("ALM.ISP_RegistroInventario_Listar", "D", oeRegistroInventario.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeRegistroInventario = Cargar(ds.Tables(0).Rows(0))
            Else
                oeRegistroInventario = New e_RegistroInventario
            End If
            Return oeRegistroInventario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerRegInv(oeRegistroInventario As e_RegistroInventario) As e_RegistroInventario
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("ALM.ISP_RegistroInventario_Listar", "H", oeRegistroInventario.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeRegistroInventario = CargarSOrden(ds.Tables(0).Rows(0))
            Else
                oeRegistroInventario = New e_RegistroInventario
            End If
            Return oeRegistroInventario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeRegistroInventario As e_RegistroInventario) As List(Of e_RegistroInventario)
        Try
            Dim ldRegistroInventario As New List(Of e_RegistroInventario)
            Dim ds As DataSet
            With oeRegistroInventario
                ds = sqlhelper.ExecuteDataset("ALM.ISP_RegistroInventario_Listar", .TipoOperacion _
                        , .Id _
                        , .IdMovimientoInventario _
                        , .Fecha _
                        , .IdSubAlmacen _
                        , .IdMaterial _
                        , .IdUnidadMedida _
                        , .Cantidad _
                        , .CantidadReal _
                        , .ValorUnitario _
                        , .ValorTotal _
                        , .Activo _
                        , .UsuarioCreacion _
                        )
            End With
            oeRegistroInventario = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeRegistroInventario = Cargar(o_Fila)
                    ldRegistroInventario.Add(oeRegistroInventario)
                Next
                Return ldRegistroInventario
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarRegistro(oeRegistroInventario As e_RegistroInventario) As List(Of e_RegistroInventario)
        Try
            Dim ldRegistroInventario As New List(Of e_RegistroInventario)
            Dim ds As DataSet
            With oeRegistroInventario
                ds = sqlhelper.ExecuteDataset("ALM.ISP_RegistroInventario_Listar", .TipoOperacion, .Id)
            End With
            oeRegistroInventario = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeRegistroInventario = CargarSOrden(o_Fila)
                    ldRegistroInventario.Add(oeRegistroInventario)
                Next
            End If
            Return ldRegistroInventario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarStock(ByVal oeRegistroInventario As e_RegistroInventario) As DataSet
        Try
            Dim ldRegistroInventario As New List(Of e_RegistroInventario)
            Dim ds As DataSet
            With oeRegistroInventario
                ds = sqlhelper.ExecuteDataset("ALM.Isp_RegistroInventario_Listar", .TipoOperacion _
                        , .Id _
                        , .NroMovimiento _
                        , .IdMovimientoInventario _
                        , .Fecha _
                        , .IdSubAlmacen _
                        , .IdMaterial _
                        , .IdUnidadMedida _
                        , .Cantidad _
                        , .CantidadReal _
                        , .ValorUnitario _
                        , .ValorUnitarioReal _
                        , .ValorTotal _
                        , .Activo _
                        , .FechaInicio)
            End With
            oeRegistroInventario = Nothing
            If ds.Tables.Count > 0 Then
                Return ds
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarIngresosSalidas(ByVal oeRegistroInventario As e_RegistroInventario) As DataSet
        Try
            Dim ldRegistroInventario As New List(Of e_RegistroInventario)
            Dim ds As DataSet
            With oeRegistroInventario
                ds = sqlhelper.ExecuteDataset("ALM.Isp_IngresosSalidas_Listar", .TipoOperacion _
                        , .IdAlmacen _
                        , .IdTipoMovimiento _
                        , .Anio _
                        , .MesInicio _
                        , .MesFin)
            End With
            oeRegistroInventario = Nothing
            If ds.Tables.Count > 0 Then
                Return ds
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function AjusarKardex(lstRegistroInventario As List(Of e_RegistroInventario)) As Boolean
        Try
            Using transScope As New TransactionScope()
                For Each oe As e_RegistroInventario In lstRegistroInventario
                    oe.TipoOperacion = "J"
                Next
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarRegistroInventario(ByVal oeRegistroInventario As e_RegistroInventario) As Boolean
        Try
            Dim odRegInvOrden As New d_RegistroInventarioOrden
            Dim stResultado() As String
            With oeRegistroInventario
                stResultado = sqlhelper.ExecuteScalar("ALM.ISP_RegistroInventario_IAE", .TipoOperacion, .PrefijoID,
                        .Id, .IdMovimientoInventario, .IdSubAlmacen, .IdMaterial, .IdUnidadMedida _
                        , .Cantidad, .ValorUnitario, .CantidadReal, .ValorUnitarioReal _
                        , .ValorTotal, True, .UsuarioCreacion, .IdRegistroCombustible, .Fecha).ToString.Split("_")
                If .lstDetalleAsignacion.Count > 0 Then
                    For Each Detalle As e_DetalleAsignacion In .lstDetalleAsignacion
                        Detalle.IdRegistroInventario = stResultado(0) : Detalle.TipoOperacion = .TipoOperacion
                        Detalle.PrefijoID = .PrefijoID '@0001
                        odDetalleAsignacion.Guardar(Detalle)
                    Next
                End If
                If .oeRegInvOrden.TipoOperacion = "I" Then
                    .oeRegInvOrden.IdRegistroInventario = stResultado(0)
                    .oeRegInvOrden.UsuarioCreacion = .UsuarioCreacion
                    .oeRegInvOrden.PrefijoID = .PrefijoID '@0001
                    odRegInvOrden.Guardar(.oeRegInvOrden)
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeRegistroInventario As e_RegistroInventario) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("ALM.ISP_RegistroInventario_IAE", "E", _
             "", oeRegistroInventario.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
