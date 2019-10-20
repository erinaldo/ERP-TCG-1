'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Data.SqlClient

Public Class d_TipoOpeCon

    Dim bd As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_TipoOpeCon
        Try
            Dim oeTipoOpeCon = New e_TipoOpeCon(
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString
            )
            Return oeTipoOpeCon
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ExecuteLST(ByVal oeTipoOpeCon As e_TipoOpeCon) As DataSet
        Try
            Dim ds As DataSet
            With oeTipoOpeCon
                ds = bd.ExecuteDataset("[CON].[Isp_TipoOperacion_Listar]" _
                        , .TipoOperacion _
                        , .Id _
                        , .Codigo _
                        , .Nombre
                        )
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoOpeCon As e_TipoOpeCon) As e_TipoOpeCon
        Try
            Dim ds As DataSet = ExecuteLST(oeTipoOpeCon)
            If ds.Tables(0).Rows.Count > 0 Then
                oeTipoOpeCon = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeTipoOpeCon
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeTipoOpeCon As e_TipoOpeCon) As List(Of e_TipoOpeCon)
        Try
            Dim ldTipoOpeCon As New List(Of e_TipoOpeCon)
            Dim ds As DataSet = ExecuteLST(oeTipoOpeCon)
            oeTipoOpeCon = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeTipoOpeCon = Cargar(o_Fila)
                    ldTipoOpeCon.Add(oeTipoOpeCon)
                Next
            End If
            Return ldTipoOpeCon
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoOpeCon As e_TipoOpeCon) As Boolean
        Try
            'Using transScope As New TransactionScope()
            Dim stResultado() As String
            With oeTipoOpeCon
                stResultado = bd.ExecuteScalar("[CON].[Sp_TipoOperacion_IAE]" _
                        , .TipoOperacion _
                        , .PrefijoID _
                        , .Id _
                        , .Codigo _
                        , .Nombre
                    ).ToString.Split("_")
                .Id = stResultado(0)
            End With
            'transScope.Complete()
            'End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeTipoOpeCon As e_TipoOpeCon) As Boolean
        Try
            With oeTipoOpeCon
                bd.ExecuteNonQuery("[CON].[Sp_TipoOperacion_IAE]" _
                       , "E" _
                       , "" _
                       , .Id)

            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
