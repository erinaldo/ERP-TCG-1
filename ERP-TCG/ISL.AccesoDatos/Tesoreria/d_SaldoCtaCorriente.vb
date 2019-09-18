Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_SaldoCtaCorriente

    Private sqlhelper As New SqlHelper
    Private odMovCuentaCte As d_MovCuentaCte

    Private Function Cargar(ByVal o_fila As DataRow) As e_SaldoCtaCorriente
        Try
            Dim oeSaldoCtaCorriente = New e_SaldoCtaCorriente( _
                             o_fila("Id").ToString _
                             , o_fila("IdCuentaCorriente").ToString _
                             , o_fila("TipoCuenta") _
                             , o_fila("Dni").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("Monto") _
                             , o_fila("Saldo") _
                             , o_fila("Activo") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioLiquida").ToString _
                             , o_fila("FechaLiquida") _
                             , o_fila("Liquidado") _
                             , o_fila("Cargo") _
                             , o_fila("Abono") _
                             , o_fila("Movimiento") _
                             , o_fila("IdReferencia"))
            Return oeSaldoCtaCorriente
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeSaldoCtaCorriente As e_SaldoCtaCorriente) As e_SaldoCtaCorriente

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_SaldoCtaCorriente_Lista", "", oeSaldoCtaCorriente.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeSaldoCtaCorriente = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeSaldoCtaCorriente
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeSaldoCtaCorriente As e_SaldoCtaCorriente) As List(Of e_SaldoCtaCorriente)
        Try
            Dim ldSaldoCtaCorriente As New List(Of e_SaldoCtaCorriente)
            Dim ds As DataSet
            With oeSaldoCtaCorriente
                ds = sqlhelper.ExecuteDataset("TES.Isp_SaldoCtaCorriente_Lista", .TipoOperacion _
                        , .Id _
                        , .IdCuentaCorriente _
                        , .TipoCuenta _
                        , .Monto _
                        , .Saldo _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        , .UsuarioLiquida _
                        , .FechaLiquida _
                        , .Liquidado _
                        )
            End With
            oeSaldoCtaCorriente = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeSaldoCtaCorriente = Cargar(o_Fila)
                ldSaldoCtaCorriente.Add(oeSaldoCtaCorriente)
            Next
            Return ldSaldoCtaCorriente
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeSaldoCtaCorriente As e_SaldoCtaCorriente) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeSaldoCtaCorriente
                sqlhelper.ExecuteNonQuery("TES.Isp_SaldoCtaCorriente_IAE", _
                                          .TipoOperacion, _
                                          .PrefijoID, _
                                            .Id _
                                            , .IdCuentaCorriente _
                                            , .TipoCuenta _
                                            , .Monto _
                                            , .Saldo _
                                            , .Activo _
                                            , .UsuarioCreacion _
                                            , .UsuarioLiquida _
                                            , .FechaLiquida _
                                            , .Liquidado _
                                            , .Cargo _
                                            , .Abono _
                                            , .Movimiento _
                                            , .IdReferencia)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function PagoBono(ByVal oeSaldoCtaCorriente As e_SaldoCtaCorriente) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Using TransScope As New TransactionScope()
                With oeSaldoCtaCorriente
                    sqlhelper.ExecuteNonQuery("TES.Isp_SaldoCtaCorriente_IAE", _
                                              "U", _
                                              .PrefijoID, _
                                                .Id _
                                                , .IdCuentaCorriente _
                                                , .TipoCuenta _
                                                , .Monto _
                                                , .Saldo _
                                                , .Activo _
                                                , .UsuarioCreacion _
                                                , .UsuarioLiquida _
                                                , .FechaLiquida _
                                                , .Liquidado _
                                                , .Cargo _
                                                , .Abono _
                                                , .Movimiento _
                                                , .IdReferencia)
                    odMovCuentaCte = New d_MovCuentaCte
                    For Each _oeMovCte In .leMovCtaCte.Where(Function(it) it.TipoOperacion.Trim <> "").ToList
                        If _oeMovCte.TipoOperacion = "I" Then _oeMovCte.IdReferencia = .IdReferencia
                        odMovCuentaCte.Guardar(_oeMovCte)
                    Next
                    sqlhelper.ExecuteNonQuery("TES.Isp_SaldoCtaCorriente_IAE", _
                                              "I", _
                                              .PrefijoID, _
                                                "" _
                                                , .IdCuentaCorriente _
                                                , .TipoCuenta _
                                                , .Monto _
                                                , .Saldo _
                                                , .Activo _
                                                , .UsuarioCreacion _
                                                , "" _
                                                , #1/1/1901# _
                                                , 0 _
                                                , IIf(.Saldo > 0, Math.Abs(.Saldo), 0) _
                                                , IIf(.Saldo > 0, 0, Math.Abs(.Saldo)) _
                                                , .Movimiento _
                                                , String.Empty)
                End With
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeSaldoCtaCorriente As e_SaldoCtaCorriente) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_SaldoCtaCorriente_IAE", "E", _
             "", oeSaldoCtaCorriente.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
