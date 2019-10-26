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

Public Class d_AreaAO

    Dim SqlHelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_AreaAO
        Try
            Dim oeAreaAO = New e_AreaAO( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Abreviatura").ToString _
                             , o_fila("IdGerencia") _
                             , o_fila("Gerencia").ToString _
                             , o_fila("Activo") _
                             , o_fila("UsuarioCreacion").ToString _
            )

            ''George
            'oeArea.IsGerencia = o_fila("IsGerencia")
            'oeArea.IdGerencia = o_fila("IdGerencia").ToString
            'oeArea.Gerencia = o_fila("Gerencia").ToString
            Return oeAreaAO
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeAreaAO As e_AreaAO) As e_AreaAO

        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("PER.Isp_AreaOG_Listar", "", oeAreaAO.Id)
            If ds.Tables.Count > 0 Then
                oeAreaAO = Cargar(ds.Tables(0).Rows(0))
                Return oeAreaAO
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAreaAO As e_AreaAO) As List(Of e_AreaAO)
        Try
            Dim ldAreaAO As New List(Of e_AreaAO)
            Dim ds As DataSet
            With oeAreaAO
                ds = SqlHelper.ExecuteDataset("PER.Isp_AreaOG_Listar", .TipoOperacion _
                        , .Id _
                        , .IdGerencia _
                        , .Codigo _
                        , .Nombre _
                        , .Activo _
                        , .UsuarioCreacion _
                        )
            End With
            oeAreaAO = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeAreaAO = Cargar(o_Fila)
                    ldAreaAO.Add(oeAreaAO)
                Next
                Return ldAreaAO
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeAreaAO As e_AreaAO) As Boolean
        Try
            With oeAreaAO
                SqlHelper.ExecuteNonQuery("PER.Isp_AreaOG_IAE", .TipoOperacion _
                        , .PrefijoID _
                        , .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        , .IdGerencia
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeAreaAO As e_AreaAO) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("PER.Isp_AreaOG_IAE", "E", oeAreaAO.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
