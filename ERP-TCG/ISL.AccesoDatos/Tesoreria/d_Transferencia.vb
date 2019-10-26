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

Public Class d_Transferencia
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Transferencia
        Try
            Dim oeTransferencia = New e_Transferencia( _
                             o_fila("Id").ToString _
                             , o_fila("IdBanco").ToString _
                             , o_fila("Fecha") _
                             , o_fila("Numero").ToString _
                             , o_fila("Concepto").ToString _
                             , o_fila("Monto") _
                             , o_fila("IdMoneda").ToString _
                             , o_fila("TipoCambio") _
                             , o_fila("IdCuentaCorrienteOrigen").ToString _
                             , o_fila("IdCuentaCorrienteDestino").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion") _
                             , o_fila("Activo") _
            )
            Return oeTransferencia
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTransferencia As e_Transferencia) As e_Transferencia
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_Tranferencia_Listar", "", oeTransferencia.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeTransferencia = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeTransferencia
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTransferencia As e_Transferencia) As List(Of e_Transferencia)
        Try
            Dim ldTransferencia As New List(Of e_Transferencia)
            Dim ds As DataSet
            With oeTransferencia
                ds = sqlhelper.ExecuteDataset("TES.Isp_Tranferencia_Listar", "" _
                        , .Id _
                        , .IdBanco _
                        , .Fecha _
                        , .Numero _
                        , .Concepto _
                        , .Monto _
                        , .IdCuentaCorrienteOrigen _
                        , .IdCuentaCorrienteDestino _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        , .Activo _
                        )
            End With
            oeTransferencia = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeTransferencia = Cargar(o_Fila)
                ldTransferencia.Add(oeTransferencia)
            Next
            Return ldTransferencia
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTransferencia As e_Transferencia) As Boolean
        Try
            Dim stResultado() As String
            With oeTransferencia
                stResultado = sqlhelper.ExecuteScalar("TES.Isp_Transferencia_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdBanco _
                        , .Fecha _
                        , .Numero _
                        , .Concepto _
                        , .Monto _
                        , .IdMoneda _
                        , .TipoCambio _
                        , .IdCuentaCorrienteOrigen _
                        , .IdCuentaCorrienteDestino _
                        , .UsuarioCreacion _
                        , .Activo
                    ).ToString.Split("_")

                oeTransferencia.Id = stResultado(0)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeTransferencia As e_Transferencia) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_Transferencia_IAE", "E", _
             "", oeTransferencia.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
