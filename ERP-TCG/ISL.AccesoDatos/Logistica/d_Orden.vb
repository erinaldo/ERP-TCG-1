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

Public Class d_Orden
    Private sqlhelper As New SqlHelper
    Dim odOrdenMaterial As New d_OrdenMaterial
    Dim odRegistroInventario As New d_RegistroInventario
    Dim odNeumatico As New d_Neumatico
    Dim odDetalleOrdenNeu As New d_DetalleOrdenNeumatico
    Dim odOrdenDoc As New d_Orden_Documento
    Dim odInventario As New d_Inventario

    Private Function Cargar(ByVal fila As DataRow) As e_Orden
        Try
            Dim oeOrden = New e_Orden( _
                                        fila("Id"), _
                                        fila("NroOrden"), _
                                        fila("IdMoneda"), _
                                        fila("Moneda"), _
                                        fila("IdTipoOrden"), _
                                        fila("TipoOrden"), _
                                        fila("FechaOrden"), _
                                        fila("Total"), _
                                        fila("IdAlmacenOrigen"), _
                                        fila("AlmOrigen"), _
                                        fila("IdAlmacenDestino"), _
                                        fila("AlmDestino"), _
                                        fila("IdMovimientoInventario"), _
                                        fila("MovimientoInventario"), _
                                        fila("TipoReferencia"), _
                                        fila("Referencia"), _
                                        fila("IdProveedor"), _
                                        fila("Glosa"), _
                                        fila("Activo"), _
                                        fila("IdEstadoOrden"), _
                                        fila("EstadoOrden"), _
                                        fila("NombreUsuario"), _
                                        fila("UsuarioCreacion"), _
                                        fila("IdUsuarioEjecucion"), _
                                        fila("UsuarioEjecucion"), _
                                        fila("IdOrdenDocumento"), _
                                        fila("IdDocumento"), _
                                        fila("TipoDocumento"), _
                                        fila("SerieNumero"), _
                                        fila("NombreProveedor"))
            Return oeOrden
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeOrden As e_Orden) As e_Orden
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("ALM.Isp_Orden_Listar", _
                                          oeOrden.TipoOperacion, _
                                          oeOrden.Id, oeOrden.NroOrden, Date.Parse("01/01/1901"), Date.Parse("01/01/1901"), _
                                          1, "", "", oeOrden.IdTipoOrden)


            If ds.Tables(0).Rows.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeOrden = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeOrden
        Catch ex As Exception
            Throw
        End Try
        Return Nothing
    End Function

    Public Function Listar(ByVal oeOrden As e_Orden) As List(Of e_Orden)
        Try
            Dim lista As New List(Of e_Orden)
            Dim ds As DataSet
            With oeOrden
                ds = sqlhelper.ExecuteDataset("ALM.Isp_Orden_Listar" _
                                                , .TipoOperacion _
                                                , .Id _
                                                , .NroOrden _
                                                , .fechaInicio _
                                                , .fechaFin _
                                                , .Activo _
                                                , .EstadoOrden _
                                                , .IdMovimientoInventario _
                                                , .IdTipoOrden _
                                                , .Referencia _
                                                , .IndMaterialServicio)

                If ds.Tables.Count > 0 Then
                    For Each o_Fila As DataRow In ds.Tables(0).Rows
                        oeOrden = Cargar(o_Fila)
                        lista.Add(oeOrden)
                    Next
                End If
            End With
            Return lista
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeOrden As e_Orden) As Boolean
        Try
            Dim stResultado() As String
            Using transScope As New TransactionScope()
                With oeOrden
                    stResultado = sqlhelper.ExecuteScalar("ALM.Isp_Orden_IAE" _
                                                        , .TipoOperacion _
                                                        , .PrefijoID _
                                                        , .Id _
                                                        , .NroOrden _
                                                        , .IdMoneda _
                                                        , .IdTipoOrden _
                                                        , .FechaOrden _
                                                        , .Total _
                                                        , .IdSubAlmacenOrigen _
                                                        , .IdSubAlmacenDestino _
                                                        , .IdMovimientoInventario _
                                                        , .TipoReferencia _
                                                        , .Referencia _
                                                        , .IdProveedor _
                                                        , .Glosa _
                                                        , .Activo _
                                                        , .IdEstadoOrden _
                                                        , .IdCentro _
                                                        , .UsuarioCreacion _
                                                        , .IdUsuarioEjecucion).ToString.Split("_")
                    .Id = stResultado(0)
                    For Each Detalle As e_OrdenMaterial In .lstOrdenMaterial
                        Detalle.IdOrden = stResultado(0) : Detalle.UsuarioCreacion = .UsuarioCreacion
                        Detalle.TipoOperacion = .TipoOperacion
                        Detalle.PrefijoID = oeOrden.PrefijoID '@0001
                        odOrdenMaterial.Guardar(Detalle)

                        If .lstDetOrdenNeu.Count > 0 Then
                            Dim _leGen = .lstDetOrdenNeu.Where(Function(it) it.IdReqMat = Detalle.IdRequerimientoMaterial).ToList
                            If _leGen.Count > 0 Then
                                Dim oeGen = _leGen(0)
                                oeGen.IdOrdenMaterial = Detalle.Id
                            End If
                        End If
                    Next
                    For Each Inventario As e_Inventario In .lstInventario
                        Inventario.IdOrden = stResultado(0)
                        Inventario.PrefijoID = oeOrden.PrefijoID '@0001
                        odInventario.GuardarInventario(Inventario)
                    Next
                    'Para Registro de Orden de Ingreso x Asignacion
                    'If Not .lstRegistroInventario Is Nothing Then
                    '    If .lstRegistroInventario.Count > 0 Then
                    '        odRegistroInventario.Guardar(.lstRegistroInventario, stResultado(0))
                    '    End If
                    'End If
                    'Verificar Documento Asociado
                    Dim oeOrdenDoc As New e_Orden_Documento
                    If Not String.IsNullOrEmpty(oeOrden.IdDocumento) Then
                        oeOrdenDoc.TipoOperacion = oeOrden.TipoOperDocAsoc
                        oeOrdenDoc.IdTipoDocumento = oeOrden.TipoDocumento
                        oeOrdenDoc.IdDocumento = oeOrden.IdDocumento
                        oeOrdenDoc.IdTipoOrden = oeOrden.IdTipoOrden
                        oeOrdenDoc.IdOrden = stResultado(0)
                        oeOrdenDoc.UsuarioCreacion = oeOrden.UsuarioCreacion
                        oeOrdenDoc.Activo = True
                        oeOrdenDoc.PrefijoID = oeOrden.PrefijoID '@0001
                        If Not odOrdenDoc.Guardar(oeOrdenDoc) Then Return False
                    End If
                    'Insertar DetalleOrdenNeumatico
                    If .bandNeu = "N" Then
                        If .lstDetOrdenNeu.Count > 0 Then
                            For Each oeDetON In .lstDetOrdenNeu
                                If oeDetON.Id <> "" Then
                                    oeDetON.TipoOperacion = "A"
                                Else
                                    oeDetON.TipoOperacion = "I"
                                End If
                                If oeDetON.oeNeumatico.Id <> "" Then
                                    oeDetON.oeNeumatico.TipoOperacion = "A"
                                Else
                                    oeDetON.oeNeumatico.TipoOperacion = "I"
                                End If
                                oeDetON.oeNeumatico.PrefijoID = oeOrden.PrefijoID '@0001
                                odNeumatico.PreGuardar(oeDetON.oeNeumatico)
                                oeDetON.IdNeumatico = oeDetON.oeNeumatico.Id
                                oeDetON.PrefijoID = oeOrden.PrefijoID '@0001
                                odDetalleOrdenNeu.Guardar(oeDetON)
                            Next
                        End If
                    End If
                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Rectificar_Orden(ByVal oeOrden As e_Orden) As Boolean
        Try
            Dim oeRegInvOrden As New e_RegistroInventarioOrden
            Dim odRegInvOrden As New d_RegistroInventarioOrden

            oeRegInvOrden.Id = ""
            oeRegInvOrden.TipoOperacion = "U"
            oeRegInvOrden.Activo = 1
            oeRegInvOrden.IdOrden = oeOrden.Id
            oeRegInvOrden.UsuarioCreacion = oeOrden.UsuarioCreacion

            odRegInvOrden.Guardar(oeRegInvOrden)

            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarOrdenSalidaPorRequerimiento(ByVal oeOrden As e_Orden) As String
        Try
            Dim stResultado() As String
            Using transScope As New TransactionScope()
                With oeOrden
                    stResultado = sqlhelper.ExecuteScalar("ALM.Isp_Orden_IAE" _
                                                        , .TipoOperacion _
                                                        , .PrefijoID _
                                                        , .Id _
                                                        , .NroOrden _
                                                        , .IdMoneda _
                                                        , .IdTipoOrden _
                                                        , .FechaOrden _
                                                        , .Total _
                                                        , .IdSubAlmacenOrigen _
                                                        , .IdSubAlmacenDestino _
                                                        , .IdMovimientoInventario _
                                                        , .TipoReferencia _
                                                        , .Referencia _
                                                        , .IdProveedor _
                                                        , .Glosa _
                                                        , .Activo _
                                                        , .IdEstadoOrden _
                                                        , .IdCentro _
                                                        , .UsuarioCreacion
                                                        ).ToString.Split("_")

                    For Each Detalle As e_OrdenMaterial In .lstOrdenMaterial
                        Detalle.IdOrden = stResultado(0) : Detalle.UsuarioCreacion = .UsuarioCreacion
                        Detalle.TipoOperacion = .TipoOperacion
                        Detalle.PrefijoID = oeOrden.PrefijoID '@0001
                        odOrdenMaterial.Guardar(Detalle)
                    Next
                End With
                transScope.Complete()
                Return stResultado(0)
            End Using
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeOrden As e_Orden) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("ALM.Isp_Orden_IAE", "E", "", oeOrden.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class