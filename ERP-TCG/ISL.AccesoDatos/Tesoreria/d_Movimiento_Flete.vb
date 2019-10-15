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

Public Class d_Movimiento_Flete
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Movimiento_Flete
        Try
            Dim oeMovimiento_Flete = New e_Movimiento_Flete( _
                             o_fila("Id").ToString _
                             , o_fila("IdOperacionDetalle").ToString _
                             , o_fila("IdMovimiento").ToString _
                             , o_fila("IdCheque").ToString _
                             , o_fila("Fecha") _
                             , o_fila("Cargado") _
                             , o_fila("Cobrado") _
                             , o_fila("IdViaje") _
                             , o_fila("Viaje") _
                             , o_fila("IdTrabajador") _
                             , o_fila("ApellidoPaterno") _
                             , o_fila("ApellidoMaterno") _
                             , o_fila("Nombre") _
                             , o_fila("Trabajador") _
                             , o_fila("Glosa") _
                             , o_fila("NumeroCheque") _
                             , o_fila("Tipocobro") _
                             , o_fila("Origen").ToString _
                             , o_fila("Destino").ToString _
                             , o_fila("Flete") _
                             , o_fila("Depositado") _
                             , o_fila("SaldoPorDepositar") _
                             , o_fila("IdCliente") _
                             , o_fila("Cliente") _
                             , o_fila("Carga") _
                             , o_fila("Importe") _
                             , o_fila("IdGrupo"))
            Return oeMovimiento_Flete
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMovimiento_Flete As e_Movimiento_Flete) As e_Movimiento_Flete

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_Movimiento_Flete_Listar", oeMovimiento_Flete.TipoOperacion, oeMovimiento_Flete.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeMovimiento_Flete = Cargar(ds.Tables(0).Rows(0))
            Else
                oeMovimiento_Flete = New e_Movimiento_Flete
            End If
            Return oeMovimiento_Flete
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeMovimiento_Flete As e_Movimiento_Flete) As List(Of e_Movimiento_Flete)
        Try
            Dim ldMovimiento_Flete As New List(Of e_Movimiento_Flete)
            Dim ds As DataSet
            With oeMovimiento_Flete
                ds = sqlhelper.ExecuteDataset("TES.Isp_Movimiento_Flete_Listar", .TipoOperacion _
                        , .Id _
                        , .IdOperacionDetalle _
                        , .IdMovimiento _
                        , .IdCheque _
                        , .TipoCobro
                        )
            End With
            oeMovimiento_Flete = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMovimiento_Flete = Cargar(o_Fila)
                    ldMovimiento_Flete.Add(oeMovimiento_Flete)
                Next
            End If
            Return ldMovimiento_Flete
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeMovimiento_Flete As e_Movimiento_Flete) As Boolean
        Try
            Dim odChequexCobrar As New d_ChequexCobrar
            Dim Id As String = ""
            With oeMovimiento_Flete
                If .oeChequeCobrar.TipoOperacion = "I" Then
                    .oeChequeCobrar.PrefijoID = oeMovimiento_Flete.PrefijoID '@0001
                    odChequexCobrar.Guardar(.oeChequeCobrar)
                End If
                Id = sqlhelper.ExecuteScalar("TES.Isp_Movimiento_Flete_IAE", .TipoOperacion, .PrefijoID,
                       .Id _
                       , .IdOperacionDetalle _
                       , .IdMovimiento _
                       , IIf(.oeChequeCobrar.TipoOperacion = "I", .oeChequeCobrar.Id, "") _
                       , .Fecha _
                       , .TipoCobro _
                       , .IdViaje)
                .Id = Id
            End With
            Return True
        Catch ex As Exception
            Throw ex 
        End Try
    End Function

    Public Function Eliminar(ByVal oeMovimiento_Flete As e_Movimiento_Flete) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_Movimiento_Flete_IAE", "E", _
             "", oeMovimiento_Flete.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
