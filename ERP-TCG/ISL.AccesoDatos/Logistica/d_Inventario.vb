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

Public Class d_Inventario
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Inventario
        Try
            Dim oeInventario = New e_Inventario( _
                             o_fila("Id").ToString _
                             , o_fila("IdMaterial").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Material").ToString _
                             , o_fila("IdUnidadMedida").ToString _
                             , o_fila("UnidadMedida").ToString _
                             , o_fila("IdSubAlmacen").ToString _
                             , o_fila("CantidadInicial").ToString _
                             , o_fila("CantidadIngreso").ToString _
                             , o_fila("CantidadSalida").ToString _
                             , o_fila("CantidadFinal").ToString _
                             , o_fila("ValorUnitario").ToString _
                             , o_fila("ValorTotal").ToString _
                             , o_fila("PrecioUnitario").ToString _
                             , o_fila("PrecioTotal").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("StockMaximo").ToString _
                             , o_fila("StockMinimo").ToString _
                             , o_fila("Cuenta").ToString _
                             , o_fila("Serial").ToString _
                             , o_fila("Ubicacion").ToString _
                             , o_fila("SubFamilia").ToString _
                             , o_fila("Familia").ToString)
            Return oeInventario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Cargar1(ByVal o_fila As DataRow) As e_Inventario
        Try
            Dim oeInventario = New e_Inventario( _
                             o_fila("Id").ToString _
                             , o_fila("IdMaterial").ToString _
                             , o_fila("IdSubAlmacen").ToString _
                             , o_fila("CantidadFinal").ToString _
                             , o_fila("ValorUnitario").ToString)
            Return oeInventario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeInventario As e_Inventario) As List(Of e_Inventario)
        Try
            Dim ldInventario As New List(Of e_Inventario)
            Dim ds As DataSet
            With oeInventario
                ds = sqlhelper.ExecuteDataset("ALM.ISP_Inventario_Listar", .TipoOperacion _
                        , .Id _
                        , .IdMaterial _
                        , .IdSubAlmacen _
                        , .CantidadInicial _
                        , .CantidadIngreso _
                        , .CantidadSalida _
                        , .CantidadFinal _
                        , .ValorUnitario _
                        , .ValorTotal _
                        , .FechaCreacion _
                        , "" _
                        , .StockMayor _
                        , "01/01/1901" _
                        , "01/01/1901" _
                        , True)
            End With
            oeInventario = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeInventario = Cargar(o_Fila)
                    ldInventario.Add(oeInventario)
                Next
                Return ldInventario
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar1(ByVal oeInventario As e_Inventario) As List(Of e_Inventario)
        Try
            Dim ldInventario As New List(Of e_Inventario)
            Dim ds As DataSet
            With oeInventario
                ds = sqlhelper.ExecuteDataset("ALM.Isp_Inventario_Listar", _
                  oeInventario.TipoOperacion, _
                  oeInventario.Id, _
                  oeInventario.IdMaterial, _
                  oeInventario.IdSubAlmacen)
            End With
            oeInventario = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeInventario = Cargar1(o_Fila)
                    ldInventario.Add(oeInventario)
                Next
                Return ldInventario
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeInventario As e_Inventario) As e_Inventario
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("ALM.Isp_Inventario_Listar", _
                                          oeInventario.TipoOperacion, _
                                          oeInventario.Id, _
                                          oeInventario.IdMaterial, _
                                          oeInventario.IdSubAlmacen)
            If ds.Tables(0).Rows.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeInventario = Cargar1(ds.Tables(0).Rows(0))
            End If
            Return oeInventario
        Catch ex As Exception
            Throw
        End Try
        Return Nothing
    End Function

    Public Function GuardarInventario(oeInventario As e_Inventario) As Boolean
        Try
            Dim odRegInv As New d_RegistroInventario
            Dim odDetalleInventario As New d_DetalleInventario
            Using transScope As New TransactionScope()
                Dim stResultado() As String
                With oeInventario
                    If .CantidadIngreso > 0 Then
                        With .oeRegistroInventario
                            If oeInventario.IdOrden <> "" Then
                                .oeRegInvOrden = New e_RegistroInventarioOrden
                                .oeRegInvOrden.PrefijoID = oeInventario.PrefijoID '@0001
                                .oeRegInvOrden.TipoOperacion = "I"
                                .oeRegInvOrden.IdOrden = oeInventario.IdOrden
                                .oeRegInvOrden.UsuarioCreacion = .UsuarioCreacion
                            End If
                            .ValorUnitario = oeInventario.ValorUnitario
                            .CantidadReal = oeInventario.CantidadIngreso
                            .ValorUnitarioReal = oeInventario.ValorUnitario
                            .ValorTotal = .CantidadReal * .ValorUnitarioReal
                        End With
                        .oeRegistroInventario.PrefijoID = oeInventario.PrefijoID '@0001
                        odRegInv.GuardarRegistroInventario(.oeRegistroInventario)
                    End If
                    stResultado = sqlhelper.ExecuteScalar("[ALM].[Isp_Inventario_IAE]" _
                            , .PrefijoID, .Id, .FechaCreacion, .IdMaterial, .IdSubAlmacen _
                            , .CantidadIngreso, .CantidadSalida, .ValorUnitario, .ValorAdm _
                            , .Usuario, .IndDevolucion, .oeRegistroInventario.Id, .IndValidar).ToString.Split("_")
                    .Id = stResultado(0)
                    If .CantidadSalida > 0 Then
                        Dim oe As New e_Inventario
                        oe.TipoOperacion = ""
                        oe.Id = .Id
                        oe = Obtener(oe)
                        With .oeRegistroInventario
                            If oeInventario.IdOrden <> "" Then
                                .oeRegInvOrden = New e_RegistroInventarioOrden
                                .oeRegInvOrden.PrefijoID = oeInventario.PrefijoID '@0001
                                .oeRegInvOrden.TipoOperacion = "I"
                                .oeRegInvOrden.IdOrden = oeInventario.IdOrden
                                .oeRegInvOrden.UsuarioCreacion = .UsuarioCreacion
                            End If
                            .ValorUnitario = oe.ValorUnitario
                            .CantidadReal = oeInventario.CantidadSalida
                            .ValorUnitarioReal = oe.ValorUnitario
                            .ValorTotal = .CantidadReal * .ValorUnitarioReal

                        End With
                        .oeRegistroInventario.PrefijoID = oeInventario.PrefijoID '@0001
                        odRegInv.GuardarRegistroInventario(.oeRegistroInventario)
                    End If
                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class