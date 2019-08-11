Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Area

    Dim SqlHelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Area
        Try
            Dim oeArea = New e_Area( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Abreviatura").ToString _
                             , o_fila("IndSector") _
                             , o_fila("IdSector").ToString _
                             , o_fila("Sector").ToString _
                             , o_fila("Activo") _
                             , o_fila("UsuarioCreacion").ToString _
            )
            oeArea.IdAreaOG = o_fila("IdAreaOG")
            oeArea.AreaOG = o_fila("AreaOG").ToString
            oeArea.Gerencia = o_fila("Gerencia").ToString
            Return oeArea
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeArea As e_Area) As e_Area

        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("PER.Isp_Area_Listar", "", oeArea.Id)
            If ds.Tables.Count > 0 Then
                oeArea = Cargar(ds.Tables(0).Rows(0))
                Return oeArea
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeArea As e_Area) As List(Of e_Area)
        Try
            Dim ldArea As New List(Of e_Area)
            Dim ds As DataSet
            With oeArea
                ds = SqlHelper.ExecuteDataset("PER.Isp_Area_Listar", .TipoOperacion _
                        , .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .IndSector _
                        , .IdSector _
                        , .Activo _
                        , .UsuarioCreacion _
                        )
            End With
            oeArea = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeArea = Cargar(o_Fila)
                    ldArea.Add(oeArea)
                Next
                Return ldArea
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeArea As e_Area) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion

            With oeArea
                SqlHelper.ExecuteNonQuery("PER.Isp_Area_IAE", .TipoOperacion, _
                        .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .IndSector _
                        , .IdSector _
                        , .Activo _
                        , .UsuarioCreacion _
                        , d_DatosConfiguracion.PrefijoID _
                        , .IsGerencia _
                        , .IdGerencia _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeArea As e_Area) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("PER.Isp_Area_IAE", "E", oeArea.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
