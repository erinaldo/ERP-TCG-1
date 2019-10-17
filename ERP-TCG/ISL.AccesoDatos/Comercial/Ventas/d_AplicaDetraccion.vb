'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions

Public Class d_AplicaDetraccion

    Private sqlhelper As New SqlHelper

    Public Function Cargar(ByVal o_fila As DataRow) As e_AplicaDetraccion
        Try
            Dim oeAplicaDetraccion = New e_AplicaDetraccion( _
                             o_fila("Id").ToString _
                             , o_fila("Serie").ToString _
                             , o_fila("Numero").ToString _
                             , o_fila("FechaEmision") _
                             , o_fila("IdCliente").ToString _
                             , o_fila("Cliente").ToString _
                             , o_fila("IdTipoMoneda").ToString _
                             , o_fila("TipoMoneda").ToString _
                             , o_fila("Total") _
                             , o_fila("Saldo") _
                             , o_fila("Detraccion") _
                             , o_fila("SaldoDetraccion") _
                             , o_fila("FechaCobro").ToString _
                             , o_fila("CuentaBancaria").ToString _
                             , o_fila("MontoCobro").ToString _
                             , o_fila("SumaCobro").ToString _
                             , False _
                             , False _
                             , o_fila("IdVenta").ToString _
                             , o_fila("NroInforme").ToString _
                             , o_fila("FechaUltimo") _
            )
            Return oeAplicaDetraccion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeAplicaDetraccion As e_AplicaDetraccion) As List(Of e_AplicaDetraccion)
        Try
            Dim leAplicaDetraccion As New List(Of e_AplicaDetraccion)
            Dim ds As DataSet
            With oeAplicaDetraccion
                ds = sqlhelper.ExecuteDataset("[CON].[Isp_AplicaDetraccion_Listar]", _
                                                 .TipoOperacion _
                                                , .IdMovimientoDocumento _
                                                , .Serie _
                                                , .Numero _
                                                , .IdCliente _
                                                , .IdTipoMoneda _
                                                , ._FechaInicio _
                                                , ._FechaFin _
                                                , ._IndAplicado)

            End With
            oeAplicaDetraccion = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeAplicaDetraccion = Cargar(o_Fila)
                    leAplicaDetraccion.Add(oeAplicaDetraccion)
                Next
            End If
            Return leAplicaDetraccion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
