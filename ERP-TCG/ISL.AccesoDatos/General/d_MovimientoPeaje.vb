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

Public Class d_MovimientoPeaje

    Private sqlhelper As New SqlHelper
    Private oeDetPA As New e_DetallePagoAdicional, odDetPA As New d_DetallePagoAdicional

    Private Function Cargar(ByVal o_fila As DataRow) As e_MovimientoPeaje
        Try
            Dim oeMovimientoPeaje = New e_MovimientoPeaje( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("IdEmpresa").ToString _
                             , o_fila("NroTarjeta").ToString _
                             , o_fila("IdVehiculo").ToString _
                             , o_fila("Placa").ToString _
                             , o_fila("Fecha") _
                             , o_fila("IdDocumento").ToString _
                             , o_fila("Serie").ToString _
                             , o_fila("Numero").ToString _
                             , o_fila("Monto") _
                             , o_fila("IndIngresado").ToString _
                             , o_fila("IdGastoOperacion").ToString _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaModificacion") _
                             , o_fila("UsuarioModificacion").ToString _
                             , o_fila("Activo"))

            oeMovimientoPeaje.Empresa = o_fila("Empresa").ToString
            oeMovimientoPeaje.Viaje = o_fila("Viaje").ToString
            Return oeMovimientoPeaje

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oePagoAdicional As e_MovimientoPeaje) As e_MovimientoPeaje

        Try
            Dim ds As DataSet
            With oePagoAdicional
                ds = sqlhelper.ExecuteDataset("STD.Isp_MovimientoPeaje_Listar", "O", .Id)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oePagoAdicional = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oePagoAdicional
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMovimientoPeaje As e_MovimientoPeaje) As List(Of e_MovimientoPeaje)
        Try
            Dim ldMovimientoPeaje As New List(Of e_MovimientoPeaje)
            Dim ds As DataSet
            With oeMovimientoPeaje
                ds = sqlhelper.ExecuteDataset("STD.Isp_MovimientoPeaje_Listar", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .Codigo, _
                                              .IdEmpresa, _
                                              .NroTarjeta, _
                                              .IdVehiculo, _
                                              .Placa, _
                                              .Fecha, _
                                              .IdDocumento, _
                                              .Serie, _
                                              .Numero, _
                                              .IndIngresado, _
                                              .fechaInicio, _
                                              .fechaFin)
            End With
            oeMovimientoPeaje = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeMovimientoPeaje = Cargar(o_Fila)
                ldMovimientoPeaje.Add(oeMovimientoPeaje)
            Next
            Return ldMovimientoPeaje
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oePagoAdicional As e_MovimientoPeaje) As Boolean
        Try
            Dim _idpa As String = ""

            Using TransScope As New TransactionScope()
                With oePagoAdicional
                    _idpa = sqlhelper.ExecuteScalar("STD.Isp_MovimientoPeaje_IAE", .TipoOperacion, .PrefijoID,
                            .Id _
                            , .Codigo _
                            , .IdEmpresa _
                            , .NroTarjeta _
                            , .IdVehiculo _
                            , .Placa _
                            , .Fecha _
                            , .IdDocumento _
                            , .Serie _
                            , .Numero _
                            , .Monto _
                            , .IndIngresado _
                            , .IdGastoOperacion _
                            , .UsuarioCreacion _
                            , .Activo
                        )
                End With
                TransScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oePagoAdicional As e_MovimientoPeaje) As Boolean
        Try
            'sqlhelper.ExecuteNonQuery("PER.Isp_PagoAdicional_IAE", "E", _
            ' "", oePagoAdicional.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function ImportarDatos(ByVal leMovimientoPeaje As List(Of e_MovimientoPeaje)) As Boolean
        Try
            Dim _idpa As String = ""

            Using TransScope As New TransactionScope()
                For Each Fil In leMovimientoPeaje
                    With Fil
                        _idpa = sqlhelper.ExecuteScalar("STD.Isp_MovimientoPeaje_IAE", .TipoOperacion, .PrefijoID,
                                .Id _
                                , .Codigo _
                                , .IdEmpresa _
                                , .NroTarjeta _
                                , .IdVehiculo _
                                , .Placa _
                                , .Fecha _
                                , .IdDocumento _
                                , .Serie _
                                , .Numero _
                                , .Monto _
                                , .IndIngresado _
                                , .IdGastoOperacion _
                                , .UsuarioCreacion _
                                , .Activo
                            )
                    End With
                Next
                TransScope.Complete()
            End Using







            'Dim _idpa As String = ""
            'Using TransScope As New TransactionScope()
            '    With oePagoAdicional
            '        _idpa = sqlhelper.ExecuteScalar("PER.Isp_PagoAdicional_IAE", .TipoOperacion, .PrefijoID, _
            '            .Id _
            '            , .IdPlanilla _
            '            , .Codigo _
            '            , .Descripcion _
            '            , .IdEstado _
            '            , .FechaCreacion _
            '            , .UsuarioCreacion _
            '            , .FechaModifica _
            '            , .UsuarioModifica _
            '            , .Activo _
            '        )

            '        If .dtDetallePA.Rows.Count > 0 Then
            '            For Each Fil As DataRow In .dtDetallePA.Rows
            '                Fil("IdPagoAdicional") = _idpa
            '            Next
            '            odDetPA.GuardarMasivo(.dtDetallePA)
            '        End If

            '    End With
            '    TransScope.Complete()
            Return True
            'End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDts(ByVal oeMovimientoPeaje As e_MovimientoPeaje) As DataSet
        Try
            Dim ds As DataSet
            With oeMovimientoPeaje
                ds = sqlhelper.ExecuteDataset("STD.Isp_MovimientoPeaje_Listar", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .Codigo, _
                                              .IdEmpresa, _
                                              .NroTarjeta, _
                                              .IdVehiculo, _
                                              .Placa, _
                                              .Fecha, _
                                              .IdDocumento, _
                                              .Serie, _
                                              .Numero, _
                                              .IndIngresado, _
                                              .fechaInicio, _
                                              .fechaFin)
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
