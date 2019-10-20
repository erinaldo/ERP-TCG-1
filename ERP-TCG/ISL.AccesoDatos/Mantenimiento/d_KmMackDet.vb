'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF

Public Class d_KmMackDet

    Dim bd As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_KmMackDet
        Try
            Dim oeKmMackDet = New e_KmMackDet( _
                             o_fila("Id").ToString _
                             , o_fila("IdKmMack").ToString _
                             , o_fila("IdEquipo").ToString _
                             , o_fila("Equipo").ToString _
                             , o_fila("KmInicial").ToString _
                             , o_fila("KmFinal").ToString _
                             , o_fila("KmTotal").ToString _
                             , o_fila("Importe").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeKmMackDet
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ExecuteLST(ByVal oeKmMackDet As e_KmMackDet) As DataSet
        Try
            Dim ds As DataSet
            With oeKmMackDet
                ds = bd.ExecuteDataset("[MAN].[Isp_KmMackDet_Listar]" _
                        , .TipoOperacion _
                        , .Id _
                        , .IdKmMack)
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeKmMackDet As e_KmMackDet) As e_KmMackDet
        Try
            Dim ds As DataSet = ExecuteLST(oeKmMackDet)
            If ds.Tables(0).Rows.Count > 0 Then
                oeKmMackDet = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeKmMackDet
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeKmMackDet As e_KmMackDet) As List(Of e_KmMackDet)
        Try
            Dim ldKmMackDet As New List(Of e_KmMackDet)
            Dim ds As DataSet = ExecuteLST(oeKmMackDet)
            oeKmMackDet = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeKmMackDet = Cargar(o_Fila)
                    ldKmMackDet.Add(oeKmMackDet)
                Next
            End If
            Return ldKmMackDet
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeKmMackDet As e_KmMackDet) As Boolean
        Try
            Dim stResultado() As String
            With oeKmMackDet
                stResultado = bd.ExecuteScalar("[MAN].[Isp_KmMackDet_IAE]" _
                        , .TipoOperacion _
                        , .PrefijoID _
                        , .Id _
                        , .IdKmMack _
                        , .IdEquipo _
                        , .KmInicial _
                        , .KmFinal _
                        , .UsuarioCreacion).ToString.Split("_")
                .Id = stResultado(0)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeKmMackDet As e_KmMackDet) As Boolean
        Try
            With oeKmMackDet
                bd.ExecuteNonQuery("[MAN].[Isp_KmMackDet_IAE]" _
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
