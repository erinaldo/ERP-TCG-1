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

Public Class d_GuiaTransportista
    Private sqlhelper As New SqlHelper

    Private odGuiaRemitente As New d_GuiaRemitente
    Private odBitacora As New d_Bitacora

    Public Function FormatoDocumento(ByVal TextoF As String, _
                                ByVal Cantidad As Integer) As String
        Dim ln As String = ""
        For i As Integer = 1 To Cantidad - Len(TextoF)
            ln = ln + "0"
        Next
        Return ln + TextoF
    End Function
    ''' <summary>
    ''' Recuperar la información de una guía de transportista específica
    ''' </summary>
    ''' <param name="o_fila"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 
    Private Function Cargar(ByVal o_fila As DataRow) As e_GuiaTransportista
        Try
            Dim oeGuiaTransportista = New e_GuiaTransportista( _
                             o_fila("Id").ToString _
                             , o_fila("Serie").ToString _
                             , o_fila("Numero").ToString _
                             , o_fila("IdSeguimiento").ToString _
                             , o_fila("IdRemitente").ToString _
                             , o_fila("IdDireccionLugarPartida").ToString _
                             , o_fila("IdDestinatario").ToString _
                             , o_fila("IdDireccionLugarLlegada").ToString _
                             , o_fila("IdMotivoDocumentoTraslado").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Viaje").ToString _
                             , o_fila("IdSubContrata").ToString _
                             , o_fila("SubSerie").ToString _
                             , o_fila("SubNumero").ToString _
                              , o_fila("IdOperacionDetalle").ToString _
                              , o_fila("Incidencia").ToString _
                              , o_fila("PesoToneladas").ToString _
                              , o_fila("IndFacturado").ToString _
                              , o_fila("IndGrtConfirmada").ToString _
                              , o_fila("IndDocumentos").ToString _
                              , o_fila("IndGrtPerdido").ToString _
                              , o_fila("Cantidad").ToString)

            Return oeGuiaTransportista
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Obtener una guía de transportista específica
    ''' </summary>
    ''' <param name="oeGuiaTransportista">Entidad de tipo e_GuiaTransportista</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 
    Public Function Obtener(ByVal oeGuiaTransportista As e_GuiaTransportista) As e_GuiaTransportista
        Try
            Dim ds As DataSet
            With oeGuiaTransportista
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_GuiaTransportista_Listar]", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .Serie, _
                                              .Numero, _
                                              .IdViaje, _
                                              .IdSeguimiento, _
                                              .IdOperacion, _
                                              .IdRemitente, _
                                              .Activo, _
                                              Nothing, _
                                              Nothing, _
                                              .IndGuiaTercero, _
                                              .Glosa)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeGuiaTransportista = Cargar(ds.Tables(0).Rows(0))
                oeGuiaTransportista.IdPilotoTercero = ds.Tables(0).Rows(0)("IdPilotoTercero").ToString
                oeGuiaTransportista.IndGuiaTercero = ds.Tables(0).Rows(0)("IndGuiaTercero").ToString
            Else
                oeGuiaTransportista = New e_GuiaTransportista
            End If
            Return oeGuiaTransportista
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Generar una lista de guías de transportista
    ''' </summary>
    ''' <param name="oeGuiaTransportista">Entidad de tipo e_GuiaTransportista</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Listar(ByVal oeGuiaTransportista As e_GuiaTransportista) As List(Of e_GuiaTransportista)
        Try
            Dim ldGuiaTransportista As New List(Of e_GuiaTransportista)
            Dim ds As DataSet
            With oeGuiaTransportista
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_GuiaTransportista_Listar]", _
                                                 .TipoOperacion _
                                                , .Id _
                                                , .Serie _
                                                , .Numero _
                                                , .IdViaje _
                                                , .IdSeguimiento _
                                                , .IdOperacion _
                                                , .IdRemitente _
                                                , .Activo _
                                                , .FechaDesde _
                                                , .FechaHasta)
            End With
            oeGuiaTransportista = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeGuiaTransportista = Cargar(o_Fila)                
                    oeGuiaTransportista.IdPilotoTercero = o_Fila("IdPilotoTercero").ToString
                    oeGuiaTransportista.IndGuiaTercero = o_Fila("IndGuiaTercero").ToString
                    ldGuiaTransportista.Add(oeGuiaTransportista)
                Next
            Else
                ldGuiaTransportista = New List(Of e_GuiaTransportista)
            End If
            Return ldGuiaTransportista
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDS(ByVal oeGuiaTransportista As e_GuiaTransportista) As List(Of e_GuiaTransportista)
        Try
            Dim ldGuiaTransportista As New List(Of e_GuiaTransportista)
            Dim ds As DataSet
            With oeGuiaTransportista
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_OperacionDet_ListarDS]" _
                                                , .TipoOperacion _
                                                , .IdOperacion _
                                                , .IdMovimientoDoc _
                                                , .Glosa)
            End With
            oeGuiaTransportista = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeGuiaTransportista = Cargar(o_Fila)
                    ldGuiaTransportista.Add(oeGuiaTransportista)
                Next
                Return ldGuiaTransportista
            Else
                ldGuiaTransportista = New List(Of e_GuiaTransportista)
                Return ldGuiaTransportista
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarInformeGrt(ByVal oeGuiaTransportista As e_GuiaTransportista) As DataTable
        Try
            Dim tabla As DataTable
            With oeGuiaTransportista
                tabla = sqlhelper.ExecuteDataset("[OPE].[Isp_InformeGuiaTransportista_Listar]", _
                                                 .TipoOperacion, _
                                                 .IdVehiculo, _
                                                 .Serie, _
                                                 .Inicial, _
                                                 .Final, _
                                                 .FechaDesde, _
                                                 .FechaHasta).Tables(0)
            End With
            If oeGuiaTransportista.IdVehiculo <> "" Then
                Return tabla
            Else
                If oeGuiaTransportista.Inicial <> "" And oeGuiaTransportista.Final <> "" Then
                    Return InformeGrt(tabla, oeGuiaTransportista.Serie,
                                      oeGuiaTransportista.Inicial,
                                      oeGuiaTransportista.Final)
                Else
                    Return tabla
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function InformeGrt(ByVal Tabla As DataTable, ByVal Serie As String, ByVal Inicial As Integer, ByVal Final As Integer) As DataTable


        Dim TablaInforme As DataSet
        TablaInforme = Tabla.DataSet.Clone
        For Each TablaGrt As DataRow In Tabla.Rows
            If CInt(TablaGrt("Numero")) = Inicial Then
                Dim newRow As DataRow = TablaInforme.Tables(0).NewRow()
                newRow("Id") = TablaGrt("Id")
                newRow("Viaje") = TablaGrt("Viaje")
                newRow("Serie") = TablaGrt("Serie")
                newRow("Numero") = TablaGrt("Numero")
                newRow("FechaEmision") = TablaGrt("FechaEmision")
                newRow("Remitente") = TablaGrt("Remitente")
                newRow("Destinatario") = TablaGrt("Destinatario")
                newRow("FechaViaje") = TablaGrt("FechaViaje")
                newRow("Piloto") = TablaGrt("Piloto")
                newRow("Tracto") = TablaGrt("Tracto")
                newRow("Carreta") = TablaGrt("Carreta")
                newRow("Origen") = TablaGrt("Origen")
                newRow("Destino") = TablaGrt("Destino")
                newRow("ClienteOperaciones") = TablaGrt("ClienteOperaciones")
                newRow("Factura") = TablaGrt("Factura")
                newRow("IndFacturado") = TablaGrt("IndFacturado")
                newRow("IndGrtConfirmada") = TablaGrt("IndGrtConfirmada")
                newRow("IndDocumentos") = TablaGrt("IndDocumentos")
                newRow("IndGrtPerdido") = TablaGrt("IndGrtPerdido")
                TablaInforme.Tables(0).Rows.Add(newRow)
            Else
                Dim Contador As Integer
                Dim Rango As Integer
                Contador = Inicial
                Rango = CInt(TablaGrt("Numero"))
                For I = 1 To Rango - Contador
                    Dim newRow As DataRow = TablaInforme.Tables(0).NewRow()
                    newRow("Id") = ""
                    newRow("Viaje") = "N.E"
                    newRow("Serie") = Serie
                    newRow("Numero") = FormatoDocumento(Inicial, 10)
                    newRow("FechaEmision") = Date.Now
                    newRow("Remitente") = ""
                    newRow("Destinatario") = ""
                    newRow("FechaViaje") = Date.Now
                    newRow("Piloto") = ""
                    newRow("Tracto") = ""
                    newRow("Carreta") = ""
                    newRow("Origen") = ""
                    newRow("Destino") = ""
                    newRow("ClienteOperaciones") = ""
                    newRow("Factura") = ""
                    newRow("IndFacturado") = "0"
                    newRow("IndGrtConfirmada") = "0"
                    newRow("IndDocumentos") = "0"
                    newRow("IndGrtPerdido") = "0"
                    TablaInforme.Tables(0).Rows.Add(newRow)
                    Inicial = Inicial + 1
                Next
                Dim newRow1 As DataRow = TablaInforme.Tables(0).NewRow()
                newRow1("Id") = TablaGrt("Id")
                newRow1("Viaje") = TablaGrt("Viaje")
                newRow1("Serie") = TablaGrt("Serie")
                newRow1("Numero") = TablaGrt("Numero")
                newRow1("FechaEmision") = TablaGrt("FechaEmision")
                newRow1("Remitente") = TablaGrt("Remitente")
                newRow1("Destinatario") = TablaGrt("Destinatario")
                newRow1("FechaViaje") = TablaGrt("FechaViaje")
                newRow1("Piloto") = TablaGrt("Piloto")
                newRow1("Tracto") = TablaGrt("Tracto")
                newRow1("Carreta") = TablaGrt("Carreta")
                newRow1("Origen") = TablaGrt("Origen")
                newRow1("Destino") = TablaGrt("Destino")
                newRow1("ClienteOperaciones") = TablaGrt("ClienteOperaciones")
                newRow1("Factura") = TablaGrt("Factura")
                newRow1("IndFacturado") = TablaGrt("IndFacturado")
                newRow1("IndGrtConfirmada") = TablaGrt("IndGrtConfirmada")
                newRow1("IndDocumentos") = TablaGrt("IndDocumentos")
                newRow1("IndGrtPerdido") = TablaGrt("IndGrtPerdido")
                TablaInforme.Tables(0).Rows.Add(newRow1)

            End If
            Inicial = Inicial + 1
        Next
        If Inicial <= Final Then
            Dim Contador As Integer
            Dim Rango As Integer
            Contador = Inicial
            Rango = Final
            For I = 0 To Rango - Contador
                Dim newRow As DataRow = TablaInforme.Tables(0).NewRow()
                newRow("Id") = ""
                newRow("Viaje") = "N.E"
                newRow("Serie") = Serie
                newRow("Numero") = FormatoDocumento(Inicial, 10)
                newRow("FechaEmision") = Date.Now
                newRow("Remitente") = ""
                newRow("Destinatario") = ""
                newRow("FechaViaje") = Date.Now
                newRow("Piloto") = ""
                newRow("Tracto") = ""
                newRow("Carreta") = ""
                newRow("Origen") = ""
                newRow("Destino") = ""
                newRow("ClienteOperaciones") = ""
                newRow("Factura") = ""
                newRow("IndFacturado") = "0"
                newRow("IndGrtConfirmada") = "0"
                newRow("IndDocumentos") = "0"
                newRow("IndGrtPerdido") = "0"
                TablaInforme.Tables(0).Rows.Add(newRow)
                Inicial = Inicial + 1
            Next
        End If
        Return TablaInforme.Tables(0)
    End Function

    ''' <summary>
    ''' Grabar o guardar la información de la guía de transportista
    ''' </summary>
    ''' <param name="oeGuiaTransportista">Entidad de tipo e_GuiaTransportista</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 
    Public Function Guardar(ByVal oeGuiaTransportista As e_Seguimiento) As Boolean
        Dim stResultado() As String
        Try
            Using transScope As New TransactionScope()
                For Each GuiaTransportista As e_GuiaTransportista In oeGuiaTransportista.GuiaTransportista
                    GuiaTransportista.UsuarioCreacion = oeGuiaTransportista.UsuarioCreacion
                    GuiaTransportista.PrefijoID = oeGuiaTransportista.PrefijoID '@0001
                    With GuiaTransportista
                        stResultado = sqlhelper.ExecuteScalar("[OPE].[Isp_GuiaTransportista_IAE]",
                                                              "I",
                                                              .PrefijoID,
                                                                .Id _
                                                                , FormatoDocumento(.Serie, 4) _
                                                                , FormatoDocumento(.Numero, 10) _
                                                                , .IdSeguimiento _
                                                                , .IdRemitente _
                                                                , .IdDireccionLugarPartida _
                                                                , .IdDestinatario _
                                                                , .IdDireccionLugarLlegada _
                                                                , .IdMotivoDocumentoTraslado _
                                                                , .Glosa _
                                                                , .Fecha _
                                                                , .UsuarioCreacion _
                                                                , .Activo _
                                                                , .Incidencia _
                                                                , .IdSubContrata _
                                                                , .SubSerie _
                                                                , .SubNumero _
                                                                , .IdOperacionDetalle _
                                                                , .PesoToneladas _
                                                                , .IndFacturado _
                                                                , .IdVehiculo _
                                                                , .IndGrtConfirmada _
                                                                , .IndDocumentos _
                                                                , .IndGrtPerdido _
                                                                , .Cantidad _
                                                                , .IndGuiaTercero _
                                                                , .IdPilotoTercero).ToString.Split("_")
                    End With
                    If oeGuiaTransportista.GuiaRemitente.Count > 0 Then
                        Dim GrtSerieNumero As String
                        GrtSerieNumero = FormatoDocumento(GuiaTransportista.Serie, 4) & "-" & FormatoDocumento(GuiaTransportista.Numero, 10)
                        For Each GuiaRemitente As e_GuiaRemitente In oeGuiaTransportista.GuiaRemitente.Where(Function(item) item.GuiaTransportista = GrtSerieNumero)
                            'If GrtSerieNumero = GuiaRemitente.GuiaTransportista Then
                            GuiaRemitente.IdGuiaTransportista = stResultado(0)
                            GuiaRemitente.PrefijoID = oeGuiaTransportista.PrefijoID '@0001
                            odGuiaRemitente.Guardar(GuiaRemitente)
                            'End If
                        Next
                    End If
                Next
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeGuiaTransportista As e_GuiaTransportista) As Boolean
        Dim stResultado() As String
        Try
            Dim odOperacionDetalle As New d_Operacion
            Dim odGuiaTransportistaInterrumpida As New d_GuiaTransportistaInterrumpida

            Using transScope As New TransactionScope()
                With oeGuiaTransportista
                    If .TipoOperacion = "I" Then
                        stResultado = sqlhelper.ExecuteScalar("[OPE].[Isp_GuiaTransportista_IAE]",
                                                              .TipoOperacion,
                                                              .PrefijoID,
                                                                .Id _
                                                                , FormatoDocumento(.Serie, 4) _
                                                                , FormatoDocumento(.Numero, 10) _
                                                                , .IdSeguimiento _
                                                                , .IdRemitente _
                                                                , .IdDireccionLugarPartida _
                                                                , .IdDestinatario _
                                                                , .IdDireccionLugarLlegada _
                                                                , .IdMotivoDocumentoTraslado _
                                                                , .Glosa _
                                                                , .Fecha _
                                                                , .UsuarioCreacion _
                                                                , .Activo _
                                                                , .Incidencia _
                                                                , .IdSubContrata _
                                                                , .SubSerie _
                                                                , .SubNumero _
                                                                , .IdOperacionDetalle _
                                                                , .PesoToneladas _
                                                                , .IndFacturado _
                                                                , .IdVehiculo _
                                                                , .IndGrtConfirmada _
                                                                , .IndDocumentos _
                                                                , .IndGrtPerdido _
                                                                , .Cantidad _
                                                                , .IndGuiaTercero _
                                                                , .IdPilotoTercero).ToString.Split("_")

                        If .TipoOperacion <> "F" Then
                            If .GuiaTransportistaInterrumpida.Count > 0 Then
                                For Each GuiaTransportistaInterrumpida As e_GuiaTransportistaInterrumpida In .GuiaTransportistaInterrumpida
                                    GuiaTransportistaInterrumpida.PrefijoID = oeGuiaTransportista.PrefijoID '@0001
                                    odGuiaTransportistaInterrumpida.Guardar(GuiaTransportistaInterrumpida)
                                Next
                            End If
                            If .GuiaRemitente.Count > 0 Then
                                For Each GuiaRemitente As e_GuiaRemitente In .GuiaRemitente
                                    GuiaRemitente.IdGuiaTransportista = stResultado(0)
                                    GuiaRemitente.PrefijoID = oeGuiaTransportista.PrefijoID '@0001
                                    odGuiaRemitente.Guardar(GuiaRemitente)
                                Next
                            End If
                            If .OperacionDetalle.Count > 0 Then
                                For Each OperacionDetalle As e_OperacionDetalle In .OperacionDetalle '.Where(Function(Item) Item.Seleccion = True)
                                    OperacionDetalle.PrefijoID = oeGuiaTransportista.PrefijoID '@0001
                                    If OperacionDetalle.TipoOperacion = "B" Then
                                        odOperacionDetalle.GuardarOperacionDetalle(OperacionDetalle)
                                    Else
                                        If OperacionDetalle.Id = .IdOperacionDetalle Then
                                            OperacionDetalle.TipoOperacion = "G"
                                            odOperacionDetalle.GuardarOperacionDetalle(OperacionDetalle)
                                        End If
                                    End If
                                Next
                            End If
                        End If                        
                    Else
                        If .TipoOperacion = "A" Then
                            If .GuiaTransportista.Count > 0 Then
                                For Each GuiaTransportistaAnuladas As e_GuiaTransportista In .GuiaTransportista
                                    GuiaTransportistaAnuladas.PrefijoID = oeGuiaTransportista.PrefijoID '@0001
                                    With GuiaTransportistaAnuladas
                                        stResultado = sqlhelper.ExecuteScalar("[OPE].[Isp_GuiaTransportista_IAE]",
                                                                 .TipoOperacion,
                                                                 .PrefijoID,
                                                                   .Id _
                                                                   , FormatoDocumento(.Serie, 4) _
                                                                   , FormatoDocumento(.Numero, 10) _
                                                                   , .IdSeguimiento _
                                                                   , .IdRemitente _
                                                                   , .IdDireccionLugarPartida _
                                                                   , .IdDestinatario _
                                                                   , .IdDireccionLugarLlegada _
                                                                   , .IdMotivoDocumentoTraslado _
                                                                   , .Glosa _
                                                                   , .Fecha _
                                                                   , .UsuarioCreacion _
                                                                   , .Activo _
                                                                   , .Incidencia _
                                                                   , .IdSubContrata _
                                                                   , .SubSerie _
                                                                   , .SubNumero _
                                                                   , .IdOperacionDetalle _
                                                                   , .PesoToneladas _
                                                                   , .IndFacturado _
                                                                   , .IdVehiculo _
                                                                   , .IndGrtConfirmada _
                                                                   , .IndDocumentos _
                                                                   , .IndGrtPerdido _
                                                                   , .Cantidad _
                                                                    , .IndGuiaTercero _
                                                                , .IdPilotoTercero).ToString.Split("_")
                                    End With
                                Next
                            End If
                        Else
                            stResultado = sqlhelper.ExecuteScalar("[OPE].[Isp_GuiaTransportista_IAE]", _
                                                         .TipoOperacion, _
                                                         .PrefijoID, _
                                                           .Id _
                                                           , FormatoDocumento(.Serie, 4) _
                                                           , FormatoDocumento(.Numero, 10) _
                                                           , .IdSeguimiento _
                                                           , .IdRemitente _
                                                           , .IdDireccionLugarPartida _
                                                           , .IdDestinatario _
                                                           , .IdDireccionLugarLlegada _
                                                           , .IdMotivoDocumentoTraslado _
                                                           , .Glosa _
                                                           , .Fecha _
                                                           , .UsuarioCreacion _
                                                           , .Activo _
                                                           , .Incidencia _
                                                           , .IdSubContrata _
                                                           , .SubSerie _
                                                           , .SubNumero _
                                                           , .IdOperacionDetalle _
                                                           , .PesoToneladas _
                                                           , .IndFacturado _
                                                           , .IdVehiculo _
                                                           , .IndGrtConfirmada _
                                                           , .IndDocumentos _
                                                           , .IndGrtPerdido _
                                                           , .Cantidad _
                                                            , .IndGuiaTercero _
                                                                , .IdPilotoTercero).ToString.Split("_")
                        End If

                    End If
                   
                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Eliminar la guía de transportista
    ''' </summary>
    ''' <param name="oeGuiaTransportista">Entidad de tipo e_GuiaTransportista</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Eliminar(ByVal oeGuiaTransportista As e_GuiaTransportista) As Boolean
        Try
            Dim resultado As Boolean = False
            With oeGuiaTransportista
                If sqlhelper.ExecuteNonQuery("[OPE].[Isp_GuiaTransportista_IAE]", _
                                            .TipoOperacion, _
                                            "", _
                                            .Id _
                                            , FormatoDocumento(.Serie, 4) _
                                            , FormatoDocumento(.Numero, 10) _
                                            , .IdSeguimiento _
                                            , .IdRemitente _
                                            , .IdDireccionLugarPartida _
                                            , .IdDestinatario _
                                            , .IdDireccionLugarLlegada _
                                            , .IdMotivoDocumentoTraslado _
                                            , .Glosa _
                                            , .Fecha _
                                            , .UsuarioCreacion) > 0 Then
                    resultado = True
                End If
            End With
            Return resultado
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
