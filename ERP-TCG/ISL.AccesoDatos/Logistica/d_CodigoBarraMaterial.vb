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

Public Class d_CodigoBarraMaterial
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_CodigoBarraMaterial
        Try
            Dim oeCodigoBarraMaterial = New e_CodigoBarraMaterial( _
                             o_Fila("Id").ToString _
                             , o_Fila("IdMaterial").ToString _
                             , o_Fila("CodigoBarras").ToString _
                             , o_Fila("IndPrincipal").ToString _
            )
            Return oeCodigoBarraMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCodigoBarraMaterial As e_CodigoBarraMaterial) As e_CodigoBarraMaterial

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("ALM.Isp_CodigoBarraMaterial_Listar", "", oeCodigoBarraMaterial.Id)
            If ds.Tables.Count > 0 Then
                oeCodigoBarraMaterial = Cargar(ds.Tables(0).Rows(0))
                Return oeCodigoBarraMaterial
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCodigoBarraMaterial As e_CodigoBarraMaterial) As List(Of e_CodigoBarraMaterial)
        Try
            Dim ldCodigoBarraMaterial As New List(Of e_CodigoBarraMaterial)
            Dim ds As DataSet
            With oeCodigoBarraMaterial
                ds = sqlhelper.ExecuteDataset("ALM.Isp_CodigoBarraMaterial_Listar", .TipoOperacion _
                        , .Id _
                        , .IdMaterial _
                        , .CodigoBarras _
                        , .IndPrincipal _
                        , True)
            End With
            oeCodigoBarraMaterial = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCodigoBarraMaterial = Cargar(o_Fila)
                    ldCodigoBarraMaterial.Add(oeCodigoBarraMaterial)
                Next
                Return ldCodigoBarraMaterial
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCodigoBarraMaterial As e_CodigoBarraMaterial) As Boolean
        Try
            With oeCodigoBarraMaterial
                sqlhelper.ExecuteNonQuery("ALM.Isp_CodigoBarraMaterial_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdMaterial _
                        , .CodigoBarras _
                        , .IndPrincipal _
                        , .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeCodigoBarraMaterial As e_CodigoBarraMaterial) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeCodigoBarraMaterial.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
