'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF

Public Class d_CuentaBancaria
    Private sqlhelper As New SqlHelper

    Private oeCuentaBancaria As e_CuentaBancaria

    Public Function Cargar(ByVal o_fila As DataRow) As e_CuentaBancaria
        Try
            Dim oeCuentaBancaria = New e_CuentaBancaria(o_fila("Seleccion").ToString, _
            o_fila("Id"), o_fila("IdBanco"), o_fila("NombreBanco"), o_fila("NumeroCuenta"), o_fila("NombreMoneda"), o_fila("IdMoneda"), _
            o_fila("IdCuentaContable"), o_fila("SaldoInicial"), o_fila("Contacto"), o_fila("ContactoTelefono"), _
            o_fila("TasaActiva"), o_fila("TasaPasiva"), o_fila("LineaCredito"), _
            o_fila("NumeroCorrelativo"), o_fila("Activo"))
            Return oeCuentaBancaria
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function Obtener(ByVal oeCuentaBancaria As e_CuentaBancaria) As e_CuentaBancaria
        Try
            Dim ds As New DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_CuentaBancaria_Listar", oeCuentaBancaria.TipoOperacion, oeCuentaBancaria.Id, _
                                          oeCuentaBancaria.IdBanco, oeCuentaBancaria.NumeroCuenta, "", True, "", Date.Now.Year)
            oeCuentaBancaria = New e_CuentaBancaria
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeCuentaBancaria = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeCuentaBancaria
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function Listar(ByVal oeCuentaBancaria As e_CuentaBancaria) As List(Of e_CuentaBancaria)
        Try
            Dim ldCuentaBancaria As New List(Of e_CuentaBancaria)
            Dim ds As DataSet
            With oeCuentaBancaria
                ds = sqlhelper.ExecuteDataset("TES.Isp_CuentaBancaria_Listar", _
                                              .TipoOperacion, .Id, _
                                              .IdBanco, .NumeroCuenta, _
                                              .IdMoneda, .Activo, _
                                              .IdCuentaContable, .Ejercicio)
            End With
            oeCuentaBancaria = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCuentaBancaria = Cargar(o_Fila)
                    ldCuentaBancaria.Add(oeCuentaBancaria)
                Next
                Return ldCuentaBancaria
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function Guardar(ByVal oeCuentaBancaria As e_CuentaBancaria) As Boolean

        Try
            With oeCuentaBancaria
                sqlhelper.ExecuteNonQuery("TES.Isp_CuentaBancaria_IAE", .TipoOperacion,
                .Id, .IdBanco, .NumeroCuenta, .IdMoneda, .IdCuentaContable, .SaldoInicial,
                .Contacto, .ContactoTelefono, .TasaActiva, .TasaPasiva,
                .LineaCredito, .NumeroCorrelativo, .Activo, .PrefijoID)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function Eliminar(ByVal oeCuentaBancaria As e_CuentaBancaria) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("TES.Isp_CuentaBancaria_IAE", "E", oeCuentaBancaria.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
