Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient
Public Class d_GuiaRRemitenteMaterial
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_GuiaRRemitenteMaterial
        Try
            Dim oeGuiaRRemitenteMaterial = New e_GuiaRRemitenteMaterial( _
                             o_fila("Seleccion").ToString _
                             , o_fila("Id").ToString _
                             , o_fila("IdGuiaRemision").ToString _
                             , o_fila("IdMaterial").ToString _
                             , o_fila("CodigoMaterial").ToString _
                            , o_fila("Material").ToString _
                            , o_fila("IdUnidadMedida").ToString _
                            , o_fila("UnidadMedida").ToString _
                             , o_fila("CantidadMaterial").ToString _
                             , o_fila("Peso").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("idTipoUnidadMedida").ToString _
                             , o_fila("IdAlmacen").ToString _
                             , o_fila("Almacen").ToString _
                             , o_fila("idSubAlmacen").ToString)
            Return oeGuiaRRemitenteMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeGuiaRRemitenteMaterial As e_GuiaRRemitenteMaterial) As e_GuiaRRemitenteMaterial

        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "",
            Left(oeGuiaRRemitenteMaterial.PrefijoID, 1), "", oeGuiaRRemitenteMaterial.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeGuiaRRemitenteMaterial = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeGuiaRRemitenteMaterial
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGuiaRRemitenteMaterial As e_GuiaRRemitenteMaterial) As List(Of e_GuiaRRemitenteMaterial)
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ldGuiaRRemitenteMaterial As New List(Of e_GuiaRRemitenteMaterial)
            Dim ds As DataSet
            With oeGuiaRRemitenteMaterial
                ds = sqlhelper.ExecuteDataset("CMP.Isp_GuiaRemision_Material_Listar", .TipoOperacion _
                        , .Id _
                        , .IdGuiaRemision _
                        , .IdMaterial _
                        , .CantidadMaterial _
                        , .IdUnidadMedida _
                        , .Peso _
                        , .Glosa _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        )
            End With
            oeGuiaRRemitenteMaterial = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeGuiaRRemitenteMaterial = Cargar(o_Fila)
                    ldGuiaRRemitenteMaterial.Add(oeGuiaRRemitenteMaterial)
                Next
            End If
            Return ldGuiaRRemitenteMaterial
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeGuiaRRemitenteMaterial As e_GuiaRRemitenteMaterial) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeGuiaRRemitenteMaterial
                sqlhelper.ExecuteNonQuery("CMP.Isp_GuiaRemision_Material_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .IdGuiaRemision _
                        , .IdMaterial _
                        , .CantidadMaterial _
                        , .IdUnidadMedida _
                        , .Peso _
                        , .Glosa _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        , .IdSubAlmacen)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeGuiaRRemitenteMaterial As e_GuiaRRemitenteMaterial) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeGuiaRRemitenteMaterial.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class


