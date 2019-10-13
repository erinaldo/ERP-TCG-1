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

Public Class d_ControlEntregaMaterial
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_ControlEntregaMaterial
        Try


            Dim oeControlEntregaMaterial = New e_ControlEntregaMaterial( _
                             o_fila("Id").ToString _
                             , o_fila("CantidadEntregada").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Material").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("NroOrden").ToString _
                             , o_fila("TipoOrden").ToString)
            Return oeControlEntregaMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeControlEntregaMaterial As e_ControlEntregaMaterial) As e_ControlEntregaMaterial

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CMP.Isp_ControlEntregaMaterial_Listar", oeControlEntregaMaterial.TipoOperacion, oeControlEntregaMaterial.Id, oeControlEntregaMaterial.IdRequerimientoMaterial)
            oeControlEntregaMaterial = New e_ControlEntregaMaterial
            If ds.Tables.Count > 0 Then
                If ds.Tables(0).Rows.Count > 0 Then
                    oeControlEntregaMaterial = Cargar(ds.Tables(0).Rows(0))
                End If
                Return oeControlEntregaMaterial
            Else
                Return oeControlEntregaMaterial
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeControlEntregaMaterial As e_ControlEntregaMaterial) As List(Of e_ControlEntregaMaterial)
        Try
            Dim ldControlEntregaMaterial As New List(Of e_ControlEntregaMaterial)
            Dim ds As DataSet
            With oeControlEntregaMaterial
                ds = sqlhelper.ExecuteDataset("CMP.Isp_ControlEntregaMaterial_Listar", .TipoOperacion _
                        , .Id _
                        , .IdRequerimientoMaterial _
                        , .IdOrdenMaterialSalida _
                        , .IdOrdenMaterialIngreso)
            End With
            oeControlEntregaMaterial = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeControlEntregaMaterial = Cargar(o_Fila)
                    ldControlEntregaMaterial.Add(oeControlEntregaMaterial)
                Next
                Return ldControlEntregaMaterial
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeControlEntregaMaterial As e_ControlEntregaMaterial) As Boolean
        Try
            Dim id As String = ""
            With oeControlEntregaMaterial
                id = sqlhelper.ExecuteScalar("CMP.Isp_ControlEntregaMaterial_IAE", .TipoOperacion,
                                             .PrefijoID,
                        .Id _
                        , .IdRequerimientoMaterial _
                        , .IdTrabajador _
                        , .CantidadEntregada _
                        , .IdUnidadMedida _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .IdOrdenMaterialIngreso _
                        , .IdOrdenMaterialSalida)
                .Id = id
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeControlEntregaMaterial As e_ControlEntregaMaterial) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeControlEntregaMaterial.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
