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

Public Class d_DocVehDocPago
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_DocVehDocPago
        Try
            Dim oe = New e_DocVehDocPago( _
                             o_fila("Id").ToString _
                             , o_fila("IdDocVeh_Doc").ToString _
                             , o_fila("IdCuotaDocVeh_Mov").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("Monto").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oe
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oe As e_DocVehDocPago) As e_DocVehDocPago

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.ISP_DocVeh_DocPago_Listar", "", oe.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oe = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oe
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oe As e_DocVehDocPago) As List(Of e_DocVehDocPago)
        Try
            Dim ld As New List(Of e_DocVehDocPago)
            Dim ds As DataSet
            With oe
                ds = sqlhelper.ExecuteDataset("STD.ISP_DocVeh_DocPago_Listar", "" _
                        , .Id _
                        , .IdDocVeh_Doc _
                        , .IdCuotaDocVeh_Mov _
                        , .Glosa _
                        , .Monto _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oe = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oe = Cargar(o_Fila)
                ld.Add(oe)
            Next
            Return ld
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oe As e_DocVehDocPago) As Boolean
        Try
            With oe
                sqlhelper.ExecuteNonQuery("STD.ISP_DocVeh_DocPago_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdDocVeh_Doc _
                        , .IdCuotaDocVeh_Mov _
                        , .Glosa _
                        , .Monto _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
