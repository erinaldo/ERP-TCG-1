Imports ERP.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_GRR_Venta

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_GRR_Venta
        Try
            Dim oeGuiaRemitente = New e_GRR_Venta With {.Id = o_fila("Id").ToString, .IdTransportista = o_fila("IdTransportista").ToString _
                , .Transportista = o_fila("Transportista").ToString, .IdCliente = o_fila("IdCliente").ToString, .Cliente = o_fila("Cliente").ToString _
                , .Fecha = o_fila("Fecha").ToString, .FechaTraslado = o_fila("FechaTraslado").ToString, .Serie = o_fila("Serie").ToString _
                , .Numero = o_fila("Numero").ToString, .IdVehiculo = o_fila("IdVehiculo").ToString, .Vehiculo = o_fila("Vehiculo").ToString _
                , .TotalPeso = o_fila("TotalPeso"), .Marca = o_fila("MarcaVehiculo").ToString, .MTCVehiculo = o_fila("MTCVehiculo").ToString _
                , .IdCarreta = o_fila("IdCarreta").ToString, .Carreta = o_fila("Carreta").ToString, .IdChofer = o_fila("IdChofer").ToString _
                , .Chofer = o_fila("Chofer").ToString, .Brevete = o_fila("Brevete").ToString, .IdMotivoTraslado = o_fila("IdMotivoTraslado").ToString _
                , .MotivoTraslado = o_fila("MotivoTraslado").ToString, .IdPartida = o_fila("IdPartida").ToString, .Partida = o_fila("Partida").ToString _
                , .IdDestino = o_fila("IdDestino").ToString, .Destino = o_fila("Destino").ToString, .UsuarioCrea = o_fila("UsuarioCrea").ToString _
                , .IdEstado = o_fila("IdEstado").ToString, .Estado = o_fila("Estado").ToString, .DocAsoc = o_fila("DocAsoc").ToString}
            Return oeGuiaRemitente
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeGuiaRemitente As e_GRR_Venta) As e_GRR_Venta
        Try
            Dim ds As DataSet
            With oeGuiaRemitente
                ds = sqlhelper.ExecuteDataset("[ADM].[GuiaRemision_Venta_Listar]", .TipoOperacion, .Id, .IdEmpresaSis, .IdSucursal,
                                              .IdTransportista, .IdCliente, .Fecha, .FechaTraslado, .Serie)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeGuiaRemitente = Cargar(ds.Tables(0).Rows(0))
                Return oeGuiaRemitente
            Else
                oeGuiaRemitente = New e_GRR_Venta
                Return oeGuiaRemitente
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDT(oe As e_GRR_Venta) As DataTable
        Try
            Dim DT As New DataTable, DS As New DataSet
            With oe
                DS = sqlhelper.ExecuteDataset("[ADM].[GuiaRemision_Venta_Listar]", .TipoOperacion, .Id)
                If DS.Tables(0).Rows.Count > 0 Then
                    DT = DS.Tables(0)
                End If
            End With
            Return DT
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeGuiaRemitente As e_GRR_Venta) As List(Of e_GRR_Venta)
        Try
            Dim ldGuiaRemitente As New List(Of e_GRR_Venta)
            Dim ds As DataSet
            With oeGuiaRemitente
                ds = sqlhelper.ExecuteDataset("[ADM].[GuiaRemision_Venta_Listar]", .TipoOperacion, .Id, .IdEmpresaSis, .IdSucursal,
                                              .IdTransportista, .IdCliente, .Fecha, .FechaTraslado, .Serie, .Numero)
            End With
            oeGuiaRemitente = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeGuiaRemitente = Cargar(o_Fila)
                    ldGuiaRemitente.Add(oeGuiaRemitente)
                Next
            Else
                ldGuiaRemitente = New List(Of e_GRR_Venta)
            End If
            Return ldGuiaRemitente
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeGuiaRemitente As e_GRR_Venta) As Boolean
        Try
            Dim od_GRRVenta_Detalle As New d_GuiaRemisionRemitente_Detalle
            Dim od_RefAsoc As New d_ReferenciaAsociada
            Using transScope As New TransactionScope()
                With oeGuiaRemitente
                    Dim stResultado() As String
                    stResultado = sqlhelper.ExecuteScalar("[ADM].[GuiaRemision_Venta_IAE]", .TipoOperacion, .PrefijoID, .Id, .IdEmpresaSis, .IdSucursal,
                                          .IdTransportista, .IdCliente, .Fecha, .FechaTraslado, .IdEstado, .Serie, .Numero, .TotalPeso, .IdVehiculo, .Vehiculo,
                                          .Marca, .MTCVehiculo, .IdCarreta, .Carreta, .IdChofer, .Chofer, .Brevete, .IdMotivoTraslado, .IdPartida, .Partida,
                                          .IdDestino, .Destino, .IdViaje, .DocAsoc, .UsuarioCrea).ToString.Split("_")
                    .Id = stResultado(0)
                    For Each detalle In .lo_GRRVenta_Detalle
                        If detalle.TipoOperacion = "" Then detalle.TipoOperacion = "A"
                        detalle.IdGRR_Venta = .Id
                        od_GRRVenta_Detalle.Guardar(detalle)
                    Next
                    If .oeReferenciaAsoc.TipoOperacion = "I" Then
                        .oeReferenciaAsoc.IdTablaAsociada = .Id
                        od_RefAsoc.Guardar(.oeReferenciaAsoc)
                    End If
                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EliminarAnular(ByVal oeGuiaRemitente As e_GRR_Venta) As Boolean
        Try
            With oeGuiaRemitente
                sqlhelper.ExecuteNonQuery("[ADM].[GuiaRemision_Venta_IAE]", .TipoOperacion, .PrefijoID, .Id, .IdEmpresaSis, .IdSucursal,
                              .IdTransportista, .IdCliente, .Fecha, .FechaTraslado, .IdEstado, .Serie, .Numero, .TotalPeso, .IdVehiculo, .Vehiculo,
                              .Marca, .MTCVehiculo, .IdCarreta, .Carreta, .IdChofer, .Chofer, .Brevete, .IdMotivoTraslado, .IdPartida, .Partida,
                              .IdDestino, .Destino, .IdViaje, .DocAsoc, .UsuarioCrea)
            End With

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
