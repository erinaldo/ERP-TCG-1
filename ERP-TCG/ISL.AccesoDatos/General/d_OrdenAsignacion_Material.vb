Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_OrdenAsignacion_Material

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_OrdenAsignacion_Material
        Try
            Dim oeOrdenAsignacion_Material = New e_OrdenAsignacion_Material( _
                             o_fila("Id").ToString _
                             , o_fila("IdMaterial").ToString _
                             , o_fila("IdOrdenAsignacion").ToString _
                             , o_fila("IndUnidadAsignacion").ToString _
                             , o_fila("IdUnidadAsignacion").ToString _
                             , o_fila("IdUnidadMedida").ToString _
                             , o_fila("CantidadMaterial").ToString _
                             , o_fila("CantidadMaterialEntregada").ToString _
                             , o_fila("CantidadMaterialDevuelto").ToString _
                             , o_fila("CostoUnitario").ToString _
                             , o_fila("IdSubAlmacen").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion").ToString)
            Return oeOrdenAsignacion_Material
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeOrdenAsignacion_Material As e_OrdenAsignacion_Material) As e_OrdenAsignacion_Material

        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_OrdenAsignacion_Material_Listar", _
                                            "", _
                                            oeOrdenAsignacion_Material.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeOrdenAsignacion_Material = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeOrdenAsignacion_Material
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeOrdenAsignacion_Material As e_OrdenAsignacion_Material) As List(Of e_OrdenAsignacion_Material)
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ldOrdenAsignacion_Material As New List(Of e_OrdenAsignacion_Material)
            Dim ds As DataSet
            With oeOrdenAsignacion_Material
                ds = sqlhelper.ExecuteDataset("STD.Isp_OrdenAsignacion_Material_Listar", .TipoOperacion _
                        , .Id _
                        , .IdMaterial _
                        , .IdOrdenAsignacion _
                        , .IndUnidadAsignacion _
                        , .IdUnidadAsignacion _
                        , .IdUnidadMedida _
                        , .IdSubAlmacen _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        )
            End With
            oeOrdenAsignacion_Material = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeOrdenAsignacion_Material = Cargar(o_Fila)
                    ldOrdenAsignacion_Material.Add(oeOrdenAsignacion_Material)
                Next
            End If
            Return ldOrdenAsignacion_Material
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeOrdenAsignacion_Material As e_OrdenAsignacion_Material) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Using transScope As New TransactionScope()
                With oeOrdenAsignacion_Material
                    sqlhelper.ExecuteNonQuery("STD.Isp_OrdenAsignacion_Material_IAE", .TipoOperacion, .PrefijoID, _
                            .Id _
                            , .IdMaterial _
                            , .IdOrdenAsignacion _
                            , .IndUnidadAsignacion _
                            , .IdUnidadAsignacion _
                            , .IdUnidadMedida _
                            , .CantidadMaterial _
                            , .CantidadMaterialEntregada _
                            , .CantidadMaterialDevuelto _
                            , .CostoUnitario _
                            , .IdSubAlmacen _
                            , .Activo _
                            , .UsuarioCreacion _
                            , .IndDescuento _
                            , .MontoDescuento)
                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex 
        End Try
    End Function

    Public Function Eliminar(ByVal oeOrdenAsignacion_Material As e_OrdenAsignacion_Material) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_OrdenAsignacion_Material_IAE", "E", _
             "", oeOrdenAsignacion_Material.Id, "", oeOrdenAsignacion_Material.IdOrdenAsignacion)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function ListarUnidAsig(ByVal oeUnidadAsignadaMaterial As e_OrdenAsignacion_Material) As DataSet
        Try
            Dim ds As DataSet
            With oeUnidadAsignadaMaterial
                ds = sqlhelper.ExecuteDataset("STD.Isp_OrdenAsignacion_Material_Listar", _
                                                .TipoOperacion, _
                                                .Id, _
                                                .IdMaterial, _
                                                .IdOrdenAsignacion)
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
