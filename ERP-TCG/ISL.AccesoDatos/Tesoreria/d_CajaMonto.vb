Imports ISL.EntidadesWCF

Public Class d_CajaMonto
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_CajaMonto
        Try
            Dim oeCajaMonto = New e_CajaMonto( _
                             o_fila("Id").ToString _
                             , o_fila("IdCaja").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("Monto").ToString _
                             , o_fila("IdMoneda").ToString _
                             , o_fila("Moneda").ToString _
                             , o_fila("IdCuentaBancaria").ToString _
                             , o_fila("NumeroCuenta").ToString _
                             , o_fila("SaldoInicial").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeCajaMonto
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCajaMonto As e_CajaMonto) As e_CajaMonto

        Try
            Dim ds As New DataSet
            ds = sqlhelper.ExecuteDataset("TES.ISP_CajaMonto_Listar", "", oeCajaMonto.Id)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeCajaMonto = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeCajaMonto
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeCajaMonto As e_CajaMonto) As List(Of e_CajaMonto)
        Try
            Dim ldCajaMonto As New List(Of e_CajaMonto)
            Dim ds As DataSet
            With oeCajaMonto
                ds = sqlhelper.ExecuteDataset("TES.Isp_CajaMonto_Listar", "" _
                        , .Id _
                        , .IdCaja _
                        , .IdCuentaBancaria _
                        , .Activo _
                        )
            End With
            oeCajaMonto = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCajaMonto = Cargar(o_Fila)
                    ldCajaMonto.Add(oeCajaMonto)
                Next
                Return ldCajaMonto
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCajaMonto As e_CajaMonto) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeCajaMonto
                sqlhelper.ExecuteNonQuery("TES.Isp_CajaMonto_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdCaja _
                        , .Fecha _
                        , .Monto _
                        , .IdCuentaBancaria _
                        , .UsuarioCreacion _
                        , .Activo _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeCajaMonto As e_CajaMonto) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_CajaMonto_IAE", "E", _
             "", oeCajaMonto.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
