Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_MantenimientoMaterial

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_MantenimientoMaterial
        Try
            Dim oeMantenimientoMaterial = New e_MantenimientoMaterial( _
            o_fila("Seleccion").ToString _
            , o_fila("Id").ToString _
            , o_fila("IdMantenimiento").ToString _
            , o_fila("IdMaterial").ToString _
            , o_fila("Codigo").ToString _
            , o_fila("Material").ToString _
            , IIf(Convert.IsDBNull(o_fila("IdTipoUnidadMedida")), "", o_fila("IdTipoUnidadMedida").ToString) _
            , IIf(Convert.IsDBNull(o_fila("IdUnidadMedida")), "", o_fila("IdUnidadMedida").ToString) _
            , IIf(Convert.IsDBNull(o_fila("UnidadMedida")), "", o_fila("UnidadMedida").ToString) _
            , o_fila("Cantidad") _
            , o_fila("IdSubAlmacen") _
            , o_fila("IdAlmacen") _
            , o_fila("Precio") _
            , o_fila("Stock") _
            , o_fila("IdSubFamilia").ToString _
            , o_fila("IdFamilia").ToString _
                )
            Return oeMantenimientoMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMantenimientoMaterial As e_MantenimientoMaterial) As e_MantenimientoMaterial

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[MAN].[Isp_Mantenimiento_Material_Listar]", "", "", oeMantenimientoMaterial.Id)
            If ds.Tables.Count > 0 Then
                oeMantenimientoMaterial = Cargar(ds.Tables(0).Rows(0))
                Return oeMantenimientoMaterial
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMantenimientoMaterial As e_MantenimientoMaterial) As List(Of e_MantenimientoMaterial)
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ldMantenimientoMaterial As New List(Of e_MantenimientoMaterial)
            Dim ds As DataSet
            With oeMantenimientoMaterial
                ds = sqlhelper.ExecuteDataset("[MAN].[Isp_Mantenimiento_Material_Listar]", .TipoOperacion _
                        , d_DatosConfiguracion.PrefijoID _
                        , .Id _
                        , .IdMantenimiento _
                        , .IdMaterial _
                        , .Cantidad _
                        , .Activo _
                        , .UsuarioCreacion _
                        )
            End With
            oeMantenimientoMaterial = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMantenimientoMaterial = Cargar(o_Fila)
                    ldMantenimientoMaterial.Add(oeMantenimientoMaterial)
                Next
            End If
            Return ldMantenimientoMaterial
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMantenimientoMaterial As e_MantenimientoMaterial) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion

            With oeMantenimientoMaterial
                sqlhelper.ExecuteNonQuery("[MAN].[Isp_Mantenimiento_Material_IAE]", .TipoOperacion, _
                                          d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdMantenimiento _
                        , .IdMaterial _
                        , .IdUnidadMedida _
                        , .Cantidad _
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

    Public Function Eliminar(ByVal oeMantenimientoMaterial As e_MantenimientoMaterial) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[MAN].[Isp_Mantenimiento_Material_IAE]", "E", _
             "", oeMantenimientoMaterial.Id, oeMantenimientoMaterial.IdMantenimiento)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
