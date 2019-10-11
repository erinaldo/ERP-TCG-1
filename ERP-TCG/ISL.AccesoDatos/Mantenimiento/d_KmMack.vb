'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions

Public Class d_KmMack
    Dim d_DatosConfiguracion As d_DatosConfiguracion
    Dim bd As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_KmMack
        Try
            Dim oeKmMack = New e_KmMack(o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("CostoKm").ToString _
                             , o_fila("TipoCambio").ToString _
                             , o_fila("Serie").ToString _
                             , o_fila("Numero").ToString _
                             , o_fila("Total").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString)
            Return oeKmMack
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ExecuteLST(ByVal oeKmMack As e_KmMack) As DataSet
        Try
            Dim ds As DataSet
            With oeKmMack
                ds = bd.ExecuteDataset("[MAN].[Isp_KmMack_Listar]" _
                        , .TipoOperacion, .Id, .IdEstado, .Fecha, .FechaCreacion)
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeKmMack As e_KmMack) As e_KmMack
        Try
            Dim ds As DataSet = ExecuteLST(oeKmMack)
            If ds.Tables(0).Rows.Count > 0 Then
                oeKmMack = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeKmMack
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeKmMack As e_KmMack) As List(Of e_KmMack)
        Try
            Dim ldKmMack As New List(Of e_KmMack)
            Dim ds As DataSet = ExecuteLST(oeKmMack)
            oeKmMack = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeKmMack = Cargar(o_Fila)
                    ldKmMack.Add(oeKmMack)
                Next
            End If
            Return ldKmMack
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeKmMack As e_KmMack) As Boolean
        Try
            Dim stResultado() As String
            Dim odKmMackDet As New d_KmMackDet
            Using transScope As New TransactionScope()
                With oeKmMack
                    stResultado = bd.ExecuteScalar("[MAN].[Isp_KmMack_IAE]" _
                            , .TipoOperacion _
                            , .PrefijoID _
                            , .Id _
                            , .Codigo _
                            , .IdEstado _
                            , .Fecha _
                            , .CostoKm _
                            , .TipoCambio _
                            , .Serie _
                            , .Numero _
                            , .Total _
                            , .UsuarioCreacion).ToString.Split("_")
                    .Id = stResultado(0)
                    For Each oe As e_KmMackDet In .loKmMackDet
                        oe.IdKmMack = .Id
                        oe.TipoOperacion = .TipoOperacion
                        oe.UsuarioCreacion = .UsuarioCreacion
                        oe.PrefijoID = oeKmMack.PrefijoID '@0001
                        odKmMackDet.Guardar(oe)
                    Next
                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeKmMack As e_KmMack) As Boolean
        Try
            With oeKmMack
                bd.ExecuteNonQuery("[MAN].[Sp_KmMack_IAE]" _
                       , "E" _
                       , "" _
                       , .Id )
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
