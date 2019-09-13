Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_MaterialesNegociados
    Private sqlhelper As New SqlHelper
    Private odMaterialesNegociablesDet As New d_MaterialesNegociadosDet

    Private Function Cargar(ByVal o_fila As DataRow) As e_MaterialesNegociados
        Try
            Dim oeMaterialesNegociados = New e_MaterialesNegociados( _
                             o_fila("Id").ToString _
                             , o_fila("IdProveedor").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("Vigente").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString)
            Return oeMaterialesNegociados
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMaterialesNegociados As e_MaterialesNegociados) As e_MaterialesNegociados

        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CMP.Isp_MaterialesNegociados_Listar", oeMaterialesNegociados.TipoOperacion, oeMaterialesNegociados.Id, oeMaterialesNegociados.IdProveedor)
            If ds.Tables(0).rows.Count > 0 Then
                oeMaterialesNegociados = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeMaterialesNegociados
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMaterialesNegociados As e_MaterialesNegociados) As DataSet
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ldMaterialesNegociados As New List(Of e_MaterialesNegociados)
            Dim ds As DataSet
            With oeMaterialesNegociados
                ds = sqlhelper.ExecuteDataset("CMP.Isp_MaterialesNegociados_Listar", .TipoOperacion _
                        , .Id _
                        , .IdProveedor _
                        , .Fecha _
                        , .Vigente _
                        , "" _
                        , Date.Parse(Now) _
                        , .Activo _
                        , .UsuarioCreacion _
                        )
            End With
            Return ds
            'oeMaterialesNegociados = Nothing
            'If ds.Tables.Count > 0 Then
            '    For Each o_Fila As DataRow In ds.Tables(0).Rows
            '        oeMaterialesNegociados = Cargar(o_Fila)
            '        ldMaterialesNegociados.Add(oeMaterialesNegociados)
            '    Next
            'End If
            'Return ldMaterialesNegociados
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMaterialesNegociados As e_MaterialesNegociados) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim id As String = ""
            Using transcope As New TransactionScope
                With oeMaterialesNegociados
                    id = sqlhelper.ExecuteScalar("CMP.Isp_MaterialesNegociados_IAE", .TipoOperacion, .PrefijoID, _
                            .Id _
                            , .IdProveedor _
                            , .Fecha _
                            , .Vigente _
                            , .Glosa _
                            , .FechaCreacion _
                            , .Activo _
                            , .UsuarioCreacion)
                    For Each material As e_MaterialesNegociadosDet In .loMaterialesNegociadosDet
                        If material.TipoOperacion <> "I" Then
                            If material.TipoOperacion <> "E" Then material.TipoOperacion = .TipoOperacion
                        End If
                        material.IdMaterialesNegociados = id
                        odMaterialesNegociablesDet.Guardar(material)
                    Next
                End With
                transcope.Complete()
                Return True
            End Using

        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeMaterialesNegociados As e_MaterialesNegociados) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CMP.Isp_MaterialesNegociados_IAE", oeMaterialesNegociados.TipoOperacion, "", oeMaterialesNegociados.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
