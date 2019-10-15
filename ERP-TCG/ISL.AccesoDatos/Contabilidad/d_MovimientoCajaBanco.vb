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

Public Class d_MovimientoCajaBanco
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_MovimientoCajaBanco
        Try
            Dim oeMovimientoCajaBanco = New e_MovimientoCajaBanco( _
                             o_fila("Id").ToString _
                             , o_fila("IdFlujoCaja").ToString _
                             , o_fila("NroBoucher").ToString _
                             , o_fila("IdCuentaBancaria").ToString _
                             , o_fila("IdMoneda").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("IdTipoDocumento").ToString _
                             , o_fila("IdPeriodoConcilia").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("IdAsientoMovimiento").ToString _
                             , o_fila("tipocambio").ToString _
                             , o_fila("totalMN").ToString _
                             , o_fila("totalME").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("TipoGasto").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("IdTipoGasto").ToString _
                             , o_fila("NroAsiento").ToString)
            Return oeMovimientoCajaBanco
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMovimientoCajaBanco As e_MovimientoCajaBanco) As e_MovimientoCajaBanco
        Try
            With oeMovimientoCajaBanco
                Dim ds As DataSet
                ds = sqlhelper.ExecuteDataset("CON.ISP_MovimientoCajaBanco_Listar", "" _
                    , .Id _
                    , .IdFlujoCaja _
                    , .NroBoucher _
                    , .IdCuentaBancaria _
                    , .Fecha _
                    , .IdMedioPago _
                    , .IdPeriodoConcilia _
                    , .Activo _
                    , .IdAsientoMovimiento _
                    , .tipocambio _
                    , .totalMN _
                    , .totalME _
                    , ._FechaFin _
                    , ._Conciliado _
                    )
                If ds.Tables(0).Rows.Count > 0 Then
                    oeMovimientoCajaBanco = Cargar(ds.Tables(0).Rows(0))
                End If
                Return oeMovimientoCajaBanco
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeMovimientoCajaBanco As e_MovimientoCajaBanco) As List(Of e_MovimientoCajaBanco)
        Try
            Dim ldMovimientoCajaBanco As New List(Of e_MovimientoCajaBanco)
            Dim ds As DataSet
            With oeMovimientoCajaBanco
                ds = sqlhelper.ExecuteDataset("CON.ISP_MovimientoCajaBanco_Listar", .TipoOperacion _
                                              , .Id _
                    , .IdFlujoCaja _
                    , .NroBoucher _
                    , .IdCuentaBancaria _
                    , .Fecha _
                    , .IdMedioPago _
                    , .IdPeriodoConcilia _
                    , .Activo _
                    , .IdAsientoMovimiento _
                    , .TipoCambio _
                    , .TotalMN _
                    , .TotalME _
                    , ._FechaFin _
                    , ._Conciliado _
                    , ._Ejercicio _
                    )
            End With
            oeMovimientoCajaBanco = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMovimientoCajaBanco = Cargar(o_Fila)
                    ldMovimientoCajaBanco.Add(oeMovimientoCajaBanco)
                Next
            End If
            Return ldMovimientoCajaBanco
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByRef oeMovimientoCajaBanco As e_MovimientoCajaBanco) As Boolean
        Try
            Dim stResultado() As String
            Using transScope As New TransactionScope
                With oeMovimientoCajaBanco
                    stResultado = sqlhelper.ExecuteScalar("CON.Isp_MovimientoCajaBanco_IAE",
                                                          .TipoOperacion,
                                                          .PrefijoID,
                                                            .Id _
                                                            , .IdFlujoCaja _
                                                            , .NroBoucher _
                                                            , .IdCuentaBancaria _
                                                            , .Fecha _
                                                            , .IdMedioPago _
                                                            , .IdPeriodoConcilia _
                                                            , .Activo _
                                                            , .IdAsientoMovimiento _
                                                            , .TipoCambio _
                                                            , .TotalMN _
                                                            , .TotalME _
                                                            , ._Operador _
                                                            , ._Ids _
                                                            , .IdTipoGasto _
                                                            , .IdCuentaCorriente _
                                                            , .UsuarioCreacion).ToString.Split("_")
                    .Id = stResultado(0)

                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeMovimientoCajaBanco As e_MovimientoCajaBanco) As Boolean
        Try
            Using transScope As New TransactionScope
                With oeMovimientoCajaBanco
                    sqlhelper.ExecuteNonQuery("CON.Isp_MovimientoCajaBanco_IAE", "E", _
                     "", oeMovimientoCajaBanco.Id)

                    If .MovDoc.Count > 0 Then
                        Dim odMovDoc As New d_MovimientoDocumento
                        For Each oeMovDoc As e_MovimientoDocumento In .MovDoc
                            If Not oeMovDoc Is Nothing Then
                                odMovDoc.Guardar(oeMovDoc, Nothing, False)
                            End If
                        Next
                    End If
                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "CON.MovimientoCajaBanco", PrefijoID
                                  )
            Return IIf(stResultado Is Nothing, PrefijoID & "0000000000001", stResultado)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
