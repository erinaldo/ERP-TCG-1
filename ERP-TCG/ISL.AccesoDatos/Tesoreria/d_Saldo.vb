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

Public Class d_Saldo

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Saldo
        Try
            Dim oeSaldo = New e_Saldo( _
                             o_Fila("Id").ToString _
                             , o_Fila("Tipo").ToString _
                             , o_Fila("IdCuentaCorriente").ToString _
                             , o_Fila("IdCaja").ToString _
                             , o_Fila("FechaHora").ToString _
                             , o_Fila("Saldo").ToString _
                             , o_Fila("Activo").ToString _
                             , o_Fila("UsuarioCreacion").ToString _
            )
            Return oeSaldo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeSaldo As e_Saldo) As e_Saldo

        Try
            Dim ds As DataSet
            With oeSaldo
                ds = sqlhelper.ExecuteDataset("TES.Isp_Saldo_Listar", .TipoOperacion, .Id, .Tipo, .IdCuentaCorriente, .IdCaja)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeSaldo = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeSaldo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeSaldo As e_Saldo) As List(Of e_Saldo)
        Try
            Dim ldSaldo As New List(Of e_Saldo)
            Dim ds As DataSet
            With oeSaldo
                ds = sqlhelper.ExecuteDataset("TES.Isp_Saldo_Listar", .TipoOperacion _
                        , .Id _
                        , .Tipo _
                        , .IdCuentaCorriente _
                        , .IdCaja _
                        , .FechaHora _
                        , .Saldo _
                        , .Activo _
                        , .UsuarioCreacion _
                        )
            End With
            oeSaldo = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeSaldo = Cargar(o_Fila)
                ldSaldo.Add(oeSaldo)
            Next
            Return ldSaldo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeSaldo As e_Saldo) As Boolean
        Try
            With oeSaldo
                sqlhelper.ExecuteNonQuery("TES.Isp_Saldo_IAE", .TipoOperacion,
                        .Id _
                        , .Tipo _
                        , .IdCuentaCorriente _
                        , .IdCaja _
                        , .FechaHora _
                        , .Saldo _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .PrefijoID
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeSaldo As e_Saldo) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_Saldo_IAE", "E", oeSaldo.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function


End Class
