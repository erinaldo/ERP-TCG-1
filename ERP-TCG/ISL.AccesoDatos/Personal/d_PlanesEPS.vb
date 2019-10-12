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

Public Class d_PlanesEPS

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_PlanesEPS
        Try
            Dim oePlanesEPS = New e_PlanesEPS( _
                             o_fila("Id").ToString _
                             , o_fila("IdEmpresa").ToString _
                             , o_fila("Empresa").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("Precio") _
                             , o_fila("Adicional1") _
                             , o_fila("Adicional2") _
                             , o_fila("Adicional3") _
                             , o_fila("Adicional4") _
                             , o_fila("Adicional5") _
                             , o_fila("MontoHijoMayor") _
                             , o_fila("Vigente") _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo") _
            )
            Return oePlanesEPS
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oePlanesEPS As e_PlanesEPS) As e_PlanesEPS

        Try
            Dim ds As DataSet
            With oePlanesEPS
                ds = sqlhelper.ExecuteDataset("PER.Isp_PlanesEPS_Listar", .TipoOperacion, .Id)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oePlanesEPS = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oePlanesEPS
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oePlanesEPS As e_PlanesEPS) As List(Of e_PlanesEPS)
        Try
            Dim ldPlanesEPS As New List(Of e_PlanesEPS)
            Dim ds As DataSet
            With oePlanesEPS
                ds = sqlhelper.ExecuteDataset("PER.Isp_PlanesEPS_Listar", "" _
                        , .Id _
                        , .IdEmpresa _
                        , .Codigo _
                        , .Nombre _
                        , .Descripcion _
                        , .Precio _
                        , .Vigente _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oePlanesEPS = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oePlanesEPS = Cargar(o_Fila)
                ldPlanesEPS.Add(oePlanesEPS)
            Next
            Return ldPlanesEPS
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oePlanesEPS As e_PlanesEPS) As Boolean
        Try
            With oePlanesEPS
                sqlhelper.ExecuteNonQuery("PER.ISP_PlanesEPS_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdEmpresa _
                        , .Codigo _
                        , .Nombre _
                        , .Descripcion _
                        , .Precio _
                        , .Adicional1 _
                        , .Adicional2 _
                        , .Adicional3 _
                        , .Adicional4 _
                        , .Adicional5 _
                        , .MontoHijoMayor _
                        , .Vigente _
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

    Public Function Eliminar(ByVal oePlanesEPS As e_PlanesEPS) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.ISP_PlanesEPS_IAE", "E", _
             "", oePlanesEPS.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
