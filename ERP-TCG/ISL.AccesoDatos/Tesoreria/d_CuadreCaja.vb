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

Public Class d_CuadreCaja
    Private sqlhelper As New SqlHelper
    Dim odCuadreGasto As New d_CuadreCajaGasto
    Dim odCuadreBolsa As New d_CuadreCajaBolsa

    Private Function Cargar(ByVal o_fila As DataRow) As e_CuadreCaja
        Try
            Dim oeCuadreCaja = New e_CuadreCaja(o_fila("Id").ToString _
                                                , o_fila("Codigo").ToString _
                             , o_fila("IdCaja").ToString _
                             , o_fila("Caja").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("SaldoSistema").ToString _
                             , o_fila("Efectivo").ToString _
                             , o_fila("TotalGastos").ToString _
                             , o_fila("TotalBolsas").ToString _
                             , o_fila("Otros").ToString _
                             , o_fila("Diferencia").ToString _
                             , o_fila("Observacion").ToString _
                             , o_fila("200").ToString _
                             , o_fila("100").ToString _
                             , o_fila("50").ToString _
                             , o_fila("20").ToString _
                             , o_fila("10").ToString _
                             , o_fila("5").ToString _
                             , o_fila("2").ToString _
                             , o_fila("1").ToString _
                             , o_fila("05").ToString _
                             , o_fila("02").ToString _
                             , o_fila("01").ToString _
                             , o_fila("005").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion").ToString)
            Return oeCuadreCaja
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCuadreCaja As e_CuadreCaja) As e_CuadreCaja
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[TES].[Isp_CuadreCaja_Listar]", "", oeCuadreCaja.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeCuadreCaja = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeCuadreCaja
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeCuadreCaja As e_CuadreCaja) As List(Of e_CuadreCaja)
        Try
            Dim ldCuadreCaja As New List(Of e_CuadreCaja)
            Dim ds As DataSet
            With oeCuadreCaja
                ds = sqlhelper.ExecuteDataset("[TES].[Isp_CuadreCaja_Listar]", .TipoOperacion, .Id, .IdCaja, .Fecha, .FechaCreacion)
            End With
            oeCuadreCaja = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeCuadreCaja = Cargar(o_Fila)
                ldCuadreCaja.Add(oeCuadreCaja)
            Next
            Return ldCuadreCaja
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeCuadreCaja As e_CuadreCaja) As Boolean
        Try
            Dim stResultado() As String
            Using transScope As New TransactionScope()
                With oeCuadreCaja
                    stResultado = sqlhelper.ExecuteScalar("[TES].[Isp_CuadreCaja_IAE]", .TipoOperacion, .PrefijoID,
                            .Id, .IdCaja, .Fecha, .SaldoSistema, .Otros, .Diferencia, .Observacion, .num200, .num100, .num50 _
                            , .num20, .num10, .num5, .num2, .num1, .num05, .num02, .num01, .num005, .UsuarioCreacion).ToString.Split("_")
                    .Id = stResultado(0)
                    For Each cuagas As e_CuadreCajaGasto In .loCajaGasto
                        cuagas.IdCuadreCaja = stResultado(0)
                        cuagas.PrefijoID = oeCuadreCaja.PrefijoID '@0001
                        odCuadreGasto.Guardar(cuagas)
                    Next
                    For Each cuabol As e_CuadreCajaBolsa In .loCajaBolsa
                        cuabol.IdCuadreCaja = stResultado(0)
                        cuabol.PrefijoID = oeCuadreCaja.PrefijoID '@0001
                        odCuadreBolsa.Guardar(cuabol)
                    Next
                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeCuadreCaja As e_CuadreCaja) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[TES].[Isp_CuadreCaja_IAE]", "E", _
             "", oeCuadreCaja.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class