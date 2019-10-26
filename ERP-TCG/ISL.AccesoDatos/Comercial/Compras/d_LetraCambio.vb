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

Public Class d_LetraCambio
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_LetraCambio
        Try
            Dim oeLetraCambio = New e_LetraCambio( _
                             o_Fila("Id").ToString _
                             , o_Fila("NroLetra").ToString _
                             , o_Fila("IdProvedor").ToString _
                             , o_Fila("FechaEmision").ToString _
                             , o_Fila("FechaVencimiento").ToString _
                             , o_Fila("IdMoneda").ToString _
                             , o_Fila("Monto").ToString _
                             , o_Fila("TipoCambio").ToString _
                             , o_Fila("Glosa").ToString _
                             , o_Fila("IdEstado").ToString _
                             , o_Fila("UsuarioCreacion").ToString _
                             , o_Fila("FechaCreacion").ToString _
                             , o_Fila("NroLetraOrigen").ToString _
                             , o_Fila("IdPeriodo").ToString _
                             , o_Fila("IdCuentaContable").ToString _
                             , o_Fila("Activo").ToString _
            )
            Return oeLetraCambio
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeLetraCambio As e_LetraCambio) As e_LetraCambio

        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "", oeLetraCambio.Id)
            If ds.Tables.Count > 0 Then
                oeLetraCambio = Cargar(ds.Tables(0).Rows(0))
                Return oeLetraCambio
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeLetraCambio As e_LetraCambio) As List(Of e_LetraCambio)
        Try
            Dim ldLetraCambio As New List(Of e_LetraCambio)
            Dim ds As DataSet
            With oeLetraCambio
                ds = SqlHelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "" _
                        , .Id _
                        , .NroLetra _
                        , .IdProvedor _
                        , .FechaEmision _
                        , .FechaVencimiento _
                        , .IdMoneda _
                        , .Monto _
                        , .TipoCambio _
                        , .Glosa _
                        , .IdEstado _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        , .NroLetraOrigen _
                        , .IdPeriodo _
                        , .IdCuentaContable _
                        , .Activo _
                        )
            End With
            oeLetraCambio = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeLetraCambio = Cargar(o_Fila)
                    ldLetraCambio.Add(oeLetraCambio)
                Next
                Return ldLetraCambio
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeLetraCambio As e_LetraCambio) As Boolean
        Try
            With oeLetraCambio
                sqlhelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .NroLetra _
                        , .IdProvedor _
                        , .FechaEmision _
                        , .FechaVencimiento _
                        , .IdMoneda _
                        , .Monto _
                        , .TipoCambio _
                        , .Glosa _
                        , .IdEstado _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        , .NroLetraOrigen _
                        , .IdPeriodo _
                        , .IdCuentaContable _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeLetraCambio As e_LetraCambio) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeLetraCambio.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
