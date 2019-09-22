Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Motivo
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_Motivo
        Try
            Dim oeMotivo = New e_Motivo( _
                             o_fila("Id").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("IndAlmacen").ToString _
                             , o_fila("IndReencauche").ToString _
                             , o_fila("IndReparar").ToString _
                             , o_fila("IndBaja").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                                    )
            Return oeMotivo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMotivo As e_Motivo) As e_Motivo

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[NEU].[Isp_Motivo_Listar]", "", oeMotivo.Id)
            If ds.Tables.Count > 0 Then
                oeMotivo = Cargar(ds.Tables(0).Rows(0))
                Return oeMotivo
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMotivo As e_Motivo) As List(Of e_Motivo)
        Try
            Dim ldMotivo As New List(Of e_Motivo)
            Dim ds As DataSet
            With oeMotivo
                ds = sqlhelper.ExecuteDataset("[NEU].[Isp_Motivo_Listar]", "" _
                        , .Id _
                        , .Nombre _
                        , .Codigo _
                        , .IndAlmacen _
                        , .IndReencauche _
                        , .IndReparacion _
                        , .IndBaja _
                        , .Activo _
                        , .UsuarioCreacion _
                                               )
            End With
            oeMotivo = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMotivo = Cargar(o_Fila)
                    ldMotivo.Add(oeMotivo)
                Next
            End If
            Return ldMotivo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMotivo As e_Motivo) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeMotivo
                sqlhelper.ExecuteNonQuery("[NEU].[Isp_Motivo_IAE]", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .Nombre _
                        , .Codigo _
                        , .IndAlmacen _
                        , .IndReencauche _
                        , .IndReparacion _
                        , .IndBaja _
                        , .Activo _
                        , .UsuarioCreacion _
                                          )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeMotivo As e_Motivo) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[NEU].[Isp_Motivo_IAE]", "E", _
             "", oeMotivo.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
