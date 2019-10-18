'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF

Public Class d_ChequeContable

    Private sqlhelper As New SqlHelper
    Private oeChequeContable As e_ChequeContable


    Private Function Cargar(ByVal o_fila As DataRow) As e_ChequeContable
        Try
            Dim oeChequeContable = New e_ChequeContable(o_fila("Id"), o_fila("IdCuentaBancaria"), o_fila("IdBanco"), o_fila("Nombre"), o_fila("NumeroCuenta"), _
            o_fila("NumeroChequera"), o_fila("Fecha"), o_fila("NumeroInicial"), o_fila("NumeroFinal"), o_fila("NumeroEmitir"), _
            o_fila("Activo"))
            Return oeChequeContable
        Catch ex As Exception
            Throw ex
        End Try

    End Function


    Public Function Obtener(ByVal oeChequeContable As e_ChequeContable) As e_ChequeContable
        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("TES.Isp_ChequeContable_Listar", "", oeChequeContable.Id)
            If ds.Tables.Count > 0 Then
                oeChequeContable = Cargar(ds.Tables(0).Rows(0))
                Return oeChequeContable
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function Listar(ByVal oeChequeContable As e_ChequeContable) As List(Of e_ChequeContable)
        Try
            Dim ldChequeContable As New List(Of e_ChequeContable)
            Dim ds As DataSet
            With oeChequeContable
                ds = SqlHelper.ExecuteDataset("TES.Isp_ChequeContable_Listar", "", .Id, .IdCuentaBancaria, .Activo)
            End With
            oeChequeContable = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeChequeContable = Cargar(o_Fila)
                    ldChequeContable.Add(oeChequeContable)
                Next
                Return ldChequeContable
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function Guardar(ByVal oeChequeContable As e_ChequeContable) As Boolean
        Try
            With oeChequeContable
                sqlhelper.ExecuteNonQuery("TES.Isp_ChequeContable_IAE", .TipoOperacion,
            .Id, .IdCuentaBancaria, .NumeroChequera, .Fecha, .NumeroInicial, .NumeroFinal,
            .NumeroEmitir, .Activo, .PrefijoID)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function


    Public Function Eliminar(ByVal oeChequeContable As e_ChequeContable) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("TES.Isp_ChequeContable_IAE", "E", oeChequeContable.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
