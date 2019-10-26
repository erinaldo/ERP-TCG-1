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

Public Class d_TipoCambio
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_TipoCambio
        Try
            Dim oeTipoCambio = New e_TipoCambio( _
                             o_fila("Id").ToString _
                             , o_fila("IdMonedaOrigen").ToString _
                             , o_fila("IdMonedaDestino").ToString _
                             , o_fila("FechaCambio").ToString _
                             , o_fila("CambioVenta").ToString _
                             , o_fila("CambioCompra").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeTipoCambio
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoCambio As e_TipoCambio) As e_TipoCambio

        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("STD.ISP_TipoCambio_Listar", "", oeTipoCambio.Id)
            If ds.Tables.Count > 0 Then
                oeTipoCambio = Cargar(ds.Tables(0).Rows(0))
                Return oeTipoCambio
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTipoCambio As e_TipoCambio) As List(Of e_TipoCambio)
        Try
            Dim ldTipoCambio As New List(Of e_TipoCambio)
            Dim ds As DataSet
            With oeTipoCambio
                ds = sqlhelper.ExecuteDataset("STD.ISP_TipoCambio_Listar", .TipoOperacion _
                        , .Id _
                        , .IdMonedaOrigen _
                        , .IdMonedaDestino _
                        , .FechaCambio _
                        , .CambioVenta _
                        , .CambioCompra _
                        , .Activo _
                        )
            End With
            oeTipoCambio = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeTipoCambio = Cargar(o_Fila)
                    ldTipoCambio.Add(oeTipoCambio)
                Next
                Return ldTipoCambio
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoCambio As e_TipoCambio) As Boolean
        Try
            With oeTipoCambio
                sqlhelper.ExecuteNonQuery("STD.ISP_TipoCambio_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdMonedaOrigen _
                        , .IdMonedaDestino _
                        , .FechaCambio _
                        , .CambioVenta _
                        , .CambioCompra _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeTipoCambio As e_TipoCambio) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("STD.ISP_TipoCambio_IAE", "E", _
             "", oeTipoCambio.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
