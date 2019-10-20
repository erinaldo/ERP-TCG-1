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

Public Class d_MaterialesNegociadosDet
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_MaterialesNegociadosDet
        Try
            Dim oeMaterialesNegociadosDet = New e_MaterialesNegociadosDet(o_fila("Seleccion").ToString _
                            , o_fila("Id").ToString _
                             , o_fila("IdMaterialesNegociados").ToString _
                             , o_fila("IdMaterial").ToString _
                            , o_fila("Material").ToString _
                             , o_fila("IdMoneda").ToString _
                             , o_fila("Precio").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Vigente") _
                             , o_fila("FechaInicio") _
                             , o_fila("FechaFin"))
            Return oeMaterialesNegociadosDet
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMaterialesNegociadosDet As e_MaterialesNegociadosDet) As e_MaterialesNegociadosDet

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CMP.Isp_MaterialesNegociadosDet_Listar", "",
            Left(oeMaterialesNegociadosDet.PrefijoID, 1), "", oeMaterialesNegociadosDet.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeMaterialesNegociadosDet = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeMaterialesNegociadosDet
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeMaterialesNegociadosDet As e_MaterialesNegociadosDet) As List(Of e_MaterialesNegociadosDet)
        Try
            Dim ldMaterialesNegociadosDet As New List(Of e_MaterialesNegociadosDet)
            Dim ds As DataSet
            With oeMaterialesNegociadosDet
                ds = sqlhelper.ExecuteDataset("CMP.Isp_MaterialesNegociadosDet_Listar", .TipoOperacion _
                        , .Id _
                        , .IdMaterialesNegociados _
                        , .IdMaterial _
                        , .IdMoneda _
                        , .Precio _
                        , .Glosa _
                        , .Activo _
                        , .FechaCreacion _
                        , .UsuarioCreacion)
            End With
            oeMaterialesNegociadosDet = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMaterialesNegociadosDet = Cargar(o_Fila)
                    ldMaterialesNegociadosDet.Add(oeMaterialesNegociadosDet)
                Next
            End If
            Return ldMaterialesNegociadosDet
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeMaterialesNegociadosDet As e_MaterialesNegociadosDet) As Boolean
        Try
            With oeMaterialesNegociadosDet
                sqlhelper.ExecuteNonQuery("CMP.Isp_MaterialesNegociadosDet_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdMaterialesNegociados _
                        , .IdMaterial _
                        , .IdMoneda _
                        , .Precio _
                        , .Glosa _
                        , .Activo _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Vigente _
                        , .FechaInicio _
                        , .FechaFin)
            End With
            Return True
        Catch ex As Exception
            Throw ex 
        End Try
    End Function

    Public Function Eliminar(ByVal oeMaterialesNegociadosDet As e_MaterialesNegociadosDet) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CMP.Isp_MaterialesNegociadosDet_IAE", "E", _
             "", oeMaterialesNegociadosDet.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
