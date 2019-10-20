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

Public Class d_CierreCaja
    Private sqlhelper As New SqlHelper
    Dim odCierreCajaDet As New d_CierreCajaDet
    Dim odMovimiento As New d_Movimiento
    Dim odGastoOperacion As New d_GastoOperacion
    Dim odValesRendir As New d_ValesRendir
    Dim odOtrosIngresos As New d_OtrosIngresos

    Private Function Cargar(ByVal o_fila As DataRow) As e_CierreCaja
        Try
            Dim oeCierreCaja = New e_CierreCaja( _
                             o_Fila("Id").ToString _
                             , o_Fila("Codigo").ToString _
                             , o_Fila("IdCaja").ToString _
                             , o_Fila("FechaCreacion").ToString _
                             , o_Fila("UsuarioCreacion").ToString _
                             , o_Fila("Monto").ToString _
                             , o_Fila("IdCentro").ToString _
                             , o_Fila("Activo").ToString _
            )
            Return oeCierreCaja
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCierreCaja As e_CierreCaja) As e_CierreCaja

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_CierreCaja_Listar", "", oeCierreCaja.Id)
            If ds.Tables.Count > 0 Then
                oeCierreCaja = Cargar(ds.Tables(0).Rows(0))
                Return oeCierreCaja
            Else
                Return New e_CierreCaja
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeCierreCaja As e_CierreCaja) As List(Of e_CierreCaja)
        Try
            Dim ldCierreCaja As New List(Of e_CierreCaja)
            Dim ds As DataSet
            With oeCierreCaja
                ds = sqlhelper.ExecuteDataset("TES.Isp_CierreCaja_Listar", "" _
                        , .Id _
                        , .Codigo _
                        , .IdCaja _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Monto _
                        , .IdCentro _
                        , .Activo _
                        )
            End With
            oeCierreCaja = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCierreCaja = Cargar(o_Fila)
                    ldCierreCaja.Add(oeCierreCaja)
                Next
            End If
            Return ldCierreCaja
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeCierreCaja As e_CierreCaja) As Boolean
        Try
            Dim id As String = ""
            Using TransScope As New TransactionScope()
                With oeCierreCaja
                    id = sqlhelper.ExecuteScalar("TES.Isp_CierreCaja_IAE", .TipoOperacion, .PrefijoID,
                            .Id _
                            , .Codigo _
                            , .IdCaja _
                            , .FechaCreacion _
                            , .UsuarioCreacion _
                            , .Monto _
                            , .IdCentro _
                            , .Activo _
                            , .Glosa)
                    For Each cierredet As e_CierreCajaDet In .loCierreCajaDet
                        cierredet.TipoOperacion = "I"
                        cierredet.IdCierreCaja = id
                        cierredet.PrefijoID = oeCierreCaja.PrefijoID '@0001
                        odCierreCajaDet.Guardar(cierredet)
                    Next
                    If .oeMovimiento IsNot Nothing Then
                        .oeMovimiento.PrefijoID = oeCierreCaja.PrefijoID '@0001
                        odMovimiento.GuardarSimple(.oeMovimiento)
                    End If
                    If .oeGastoOperacion IsNot Nothing Then
                        .oeGastoOperacion.PrefijoID = oeCierreCaja.PrefijoID '@0001
                        odGastoOperacion.GuardarSimple(.oeGastoOperacion)
                    End If
                    If .oeValesRendir IsNot Nothing Then
                        .oeValesRendir.PrefijoID = oeCierreCaja.PrefijoID '@0001
                        odValesRendir.Guardar(.oeValesRendir)
                    End If
                    If .oeOtrosIngresos IsNot Nothing Then
                        .oeOtrosIngresos.PrefijoID = oeCierreCaja.PrefijoID '@0001
                        odOtrosIngresos.Guardar(.oeOtrosIngresos)
                    End If
                End With
                TransScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeCierreCaja As e_CierreCaja) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_CierreCaja_IAE", "E", _
             "", oeCierreCaja.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class

