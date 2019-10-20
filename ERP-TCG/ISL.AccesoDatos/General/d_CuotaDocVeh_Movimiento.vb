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

Public Class d_CuotaDocVeh_Movimiento
    Private sqlhelper As New SqlHelper
    Dim odCuotaDocumentoVehiculo As New d_CuotaDocumentoVehiculo
    Dim odDocumentoVeh_Documento As New d_DocumentoVehicular_Documento

    Private Function Cargar(ByVal o_fila As DataRow) As e_CuotaDocVeh_Movimiento
        Try
            Dim oeCuotaDocVeh_Movimiento = New e_CuotaDocVeh_Movimiento( _
                                   o_fila("Id").ToString _
                                 , o_fila("Tipo").ToString _
                                 , o_fila("Glosa").ToString _
                                 , o_fila("Fecha").ToString _
                                 , o_fila("IdMovimientoDocumento").ToString _
                                 , o_fila("IdMovimientoCajaBanco").ToString _
                                 , o_fila("IdMoneda").ToString _
                                 , o_fila("TipoCambio").ToString _
                                 , o_fila("MontoMN").ToString _
                                 , o_fila("MontoME").ToString _
                                 , o_fila("Activo").ToString _
                                 , o_fila("FechaCeacion").ToString _
                                 , o_fila("UsuarioCreacion").ToString _
                                     )
            Return oeCuotaDocVeh_Movimiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeCuotaDocVeh_Movimiento As e_CuotaDocVeh_Movimiento ) As List(Of e_CuotaDocVeh_Movimiento )
        Try
            Dim ldCuotaDocVeh_Movimiento As New List(Of e_CuotaDocVeh_Movimiento)
            Dim ds As DataSet
            With oeCuotaDocVeh_Movimiento
                ds = sqlhelper.ExecuteDataset("STD.Isp_CuotaDocumentoVeh_Movimiento_Listar" _
                        , .Id _
                        , .Tipo _
                        , .Glosa _
                        , .Fecha _
                        , .IdMovimientoDocumento _
                        , .IdMovimientoCajaBanco _
                        , .IdMoneda _
                        , .TipoCambio _
                        , .MontoMN _
                        , .MontoME _
                        , .Activo _
                        , .FechaCeacion _
                        , .UsuarioCreacion _
                        )
            End With
            oeCuotaDocVeh_Movimiento = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCuotaDocVeh_Movimiento = Cargar(o_Fila)
                    ldCuotaDocVeh_Movimiento.Add(oeCuotaDocVeh_Movimiento)
                Next
            End If
            Return ldCuotaDocVeh_Movimiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarCancelacion(ByVal oeCuotaDocVeh_Movimiento As e_CuotaDocVeh_Movimiento) As Boolean
        Try
            Dim ListaDocVeh_Doc_Ayuda As New List(Of e_DocumentoVehicular_Documento)
            Dim stResultado() As String
            Using transScope As New TransactionScope()

                With oeCuotaDocVeh_Movimiento
                    stResultado = sqlhelper.ExecuteScalar("STD.Isp_CuotaDocumentoVeh_Movimiento_IAE",
                                              .TipoOperacion _
                                            , .PrefijoID _
                                            , .Id _
                                            , .Tipo _
                                            , .Glosa _
                                            , .Fecha _
                                            , .IdMovimientoDocumento _
                                            , .IdMovimientoCajaBanco _
                                            , .IdMoneda _
                                            , .TipoCambio _
                                            , .MontoMN _
                                            , .MontoME _
                                            , .Activo _
                                            , .FechaCeacion _
                                            , .UsuarioCreacion
                                             ).ToString.Split("_")
                End With

                For Each Cuota As e_CuotaDocumentoVehiculo In oeCuotaDocVeh_Movimiento.leCuota
                    Cuota.TipoOperacion = "S"
                    Cuota.TipoMovimientoSaldo = oeCuotaDocVeh_Movimiento.Tipo
                    Cuota.IdUsuarioCreacion = oeCuotaDocVeh_Movimiento.UsuarioCreacion
                    Cuota.leCuotaPago.Clear()
                    Dim CuotaPago As New e_CuotaDocVehPago
                    With CuotaPago
                        .TipoOperacion = "I"
                        .IdCuota = Cuota.Id
                        .IdCuotaDocVeh_Mov = stResultado(0)
                        .Glosa = oeCuotaDocVeh_Movimiento.Glosa
                        .Monto = Cuota.MontoOpera
                        .UsuarioCreacion = Cuota.IdUsuarioCreacion
                        .FechaCreacion = Date.Now()
                        .Activo = 1
                        .PrefijoID = oeCuotaDocVeh_Movimiento.PrefijoID '@0001
                    End With
                    Cuota.leCuotaPago.Add(CuotaPago)
                    Cuota.PrefijoID = oeCuotaDocVeh_Movimiento.PrefijoID '@0001
                    odCuotaDocumentoVehiculo.Guardar(Cuota)
                Next

                For Each Doc As e_DocumentoVehicular_Documento In oeCuotaDocVeh_Movimiento.leDocumento
                    Doc.TipoOperacion = "S"
                    Doc.leDocVehDocPago.Clear()
                    Dim oeDocVehDocPago As New e_DocVehDocPago
                    With oeDocVehDocPago
                        .TipoOperacion = "I"
                        .IdDocVeh_Doc = Doc.Id
                        .IdCuotaDocVeh_Mov = stResultado(0)
                        .Glosa = oeCuotaDocVeh_Movimiento.Glosa
                        .Monto = Doc.Aplica
                        .FechaCreacion = Date.Now()
                        .UsuarioCreacion = oeCuotaDocVeh_Movimiento.UsuarioCreacion
                        .Activo = 1
                        .PrefijoID = oeCuotaDocVeh_Movimiento.PrefijoID '@0001
                    End With
                    Doc.leDocVehDocPago.Add(oeDocVehDocPago)
                    Doc.PrefijoID = oeCuotaDocVeh_Movimiento.PrefijoID '@0001
                    odDocumentoVeh_Documento.Guardar(Doc)
                Next

                For Each CuotaNueva In oeCuotaDocVeh_Movimiento.leCuotasNuevas
                    CuotaNueva.TipoOperacion = "I"
                    CuotaNueva.IdOrigen_CuotaMov = stResultado(0)
                    CuotaNueva.SaldoAdministrativo = CuotaNueva.MontoOpera
                    CuotaNueva.SaldoContable = CuotaNueva.Monto
                    CuotaNueva.PrefijoID = oeCuotaDocVeh_Movimiento.PrefijoID '@0001
                    odCuotaDocumentoVehiculo.Guardar(CuotaNueva)
                Next

                transScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
