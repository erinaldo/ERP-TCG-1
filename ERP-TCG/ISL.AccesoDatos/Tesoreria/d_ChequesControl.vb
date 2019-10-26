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

Public Class d_ChequesControl
    Private sqlhelper As New SqlHelper
    Private odChequesTalonarios As New d_ChequesTalonarios

    Private Function Cargar(ByVal o_fila As DataRow) As e_ChequesControl
        Try
            Dim oeChequesControl = New e_ChequesControl( _
                             o_fila("Id").ToString _
                             , o_fila("IdCuentaBancaria").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("Banco").ToString _
                             , o_fila("Moneda").ToString _
                             , o_fila("CuentaBancaria").ToString _
                             , o_fila("Stock").ToString)
            Return oeChequesControl
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeChequesControl As e_ChequesControl) As e_ChequesControl
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_ChequesControl_Listar", oeChequesControl.TipoOperacion, oeChequesControl.Id, oeChequesControl.IdCuentaBancaria)
            If ds.Tables.Count = 0 Then
                oeChequesControl = New e_ChequesControl
                Return oeChequesControl
            End If
            If ds.Tables.Count > 0 And ds.Tables(0).Rows.Count > 0 Then
                oeChequesControl = Cargar(ds.Tables(0).Rows(0))
                Return oeChequesControl
            Else
                Return New e_ChequesControl
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeChequesControl As e_ChequesControl) As List(Of e_ChequesControl)
        Try
            Dim ldChequesControl As New List(Of e_ChequesControl)
            Dim ds As DataSet
            With oeChequesControl
                ds = sqlhelper.ExecuteDataset("TES.Isp_ChequesControl_Listar", .TipoOperacion _
                        , .Id _
                        , .IdCuentaBancaria)
            End With
            oeChequesControl = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeChequesControl = Cargar(o_Fila)
                    ldChequesControl.Add(oeChequesControl)
                Next
            End If
            Return ldChequesControl
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeChequesControl As e_ChequesControl) As Boolean
        Try
            Dim id As String = ""
            Using transScope As New TransactionScope()
                With oeChequesControl
                    id = sqlhelper.ExecuteScalar("TES.Isp_ChequesControl_IAE", .TipoOperacion, .PrefijoID,
                            .Id _
                            , .IdCuentaBancaria _
                            , .Activo _
                            , .UsuarioCreacion _
                            , .FechaCreacion)
                    For Each oeCheTal As e_ChequesTalonarios In .listaChequeTalonario
                        oeCheTal.PrefijoID = oeChequesControl.PrefijoID '@0001
                        If oeCheTal.TipoOperacion <> "I" Then oeCheTal.TipoOperacion = "A"
                        oeCheTal.IdChequesControl = id
                        odChequesTalonarios.Guardar(oeCheTal)
                    Next
                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeChequesControl As e_ChequesControl) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_ChequesControl_IAE", "E", _
             "", oeChequesControl.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
