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

Public Class d_CuentaPorCobrar
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_CuentaPorCobrar
        Try
            Dim oeCuentaPorCobrar = New e_CuentaPorCobrar(0 _
                             , o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Concepto").ToString _
                             , o_fila("Tipo").ToString _
                             , o_fila("IdAcreedor").ToString _
                             , o_fila("IdDocumentoVenta").ToString _
                             , o_fila("Serie").ToString _
                             , o_fila("Numero").ToString _
                             , o_fila("ImporteTotal").ToString _
                             , o_fila("ImporteAbonado").ToString _
                             , o_fila("Saldo").ToString _
                             , o_fila("Cuotas").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("FechaEmision").ToString _
                             , o_fila("FechaVencimiento").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("IdCliente").ToString _
                             , o_fila("NombreCliente").ToString _
            )
            Return oeCuentaPorCobrar
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCuentaPorCobrar As e_CuentaPorCobrar) As e_CuentaPorCobrar

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_CuentaPorCobrar_Listar", oeCuentaPorCobrar.TipoOperacion, oeCuentaPorCobrar.Id)
            oeCuentaPorCobrar = New e_CuentaPorCobrar
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeCuentaPorCobrar = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeCuentaPorCobrar
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCuentaPorCobrar As e_CuentaPorCobrar) As List(Of e_CuentaPorCobrar)
        Try
            Dim ldCuentaPorCobrar As New List(Of e_CuentaPorCobrar)
            Dim ds As DataSet
            With oeCuentaPorCobrar
                ds = sqlhelper.ExecuteDataset("TES.Isp_CuentaPorCobrar_Listar", .TipoOperacion _
                        , .Id _
                        , .Codigo _
                        , .IdDocumentoVenta _
                        , .FechaDesde _
                        , .FechaHasta _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeCuentaPorCobrar = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCuentaPorCobrar = Cargar(o_Fila)
                    ldCuentaPorCobrar.Add(oeCuentaPorCobrar)
                Next
                Return ldCuentaPorCobrar
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCuentaPorCobrar As e_CuentaPorCobrar) As Boolean
        Try
            With oeCuentaPorCobrar
                sqlhelper.ExecuteNonQuery("TES.Isp_CuentaPorCobrar_IAE", .TipoOperacion, .PrefijoID,
                        "A" _
                        , .Id _
                        , .Codigo _
                        , .Concepto _
                        , .Tipo _
                        , .IdAcreedor _
                        , .IdDocumentoVenta _
                        , .ImporteTotal _
                        , .ImporteAbonado _
                        , .Saldo _
                        , .Cuotas _
                        , .IdEstado _
                        , .FechaEmision _
                        , .FechaVencimiento _
                        , .UsuarioCreacion _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeCuentaPorCobrar As e_CuentaPorCobrar) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_CuentaPorCobrar_IAE", "E", _
             "", oeCuentaPorCobrar.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class