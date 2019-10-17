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

Public Class d_TarifasProveedor
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_TarifasProveedor
        Try
            Dim oeTarifasProveedor = New e_TarifasProveedor(o_fila("Id").ToString _
                             , o_fila("IdProveedor").ToString _
                             , o_fila("Proveedor").ToString _
                             , o_fila("IdFlujoCaja").ToString _
                             , o_fila("FlujoCaja").ToString _
                             , o_fila("IdLugar").ToString _
                             , o_fila("Lugar").ToString _
                             , o_fila("Importe").ToString _
                             , o_fila("Tipo").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Vigencia").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("IdMaterial").ToString _
                             , o_fila("Material").ToString _
                             , o_fila("IdCliente").ToString _
                             , o_fila("Cliente").ToString)
            Return oeTarifasProveedor
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTarifasProveedor As e_TarifasProveedor) As e_TarifasProveedor
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("OPE.Isp_TarifasProveedor_Listar", oeTarifasProveedor.TipoOperacion,
                                          oeTarifasProveedor.Id, oeTarifasProveedor.IdProveedor,
                                          oeTarifasProveedor.IdFlujoCaja, oeTarifasProveedor.IdLugar _
                                          , oeTarifasProveedor.IdMaterial, oeTarifasProveedor.IdCliente)
            oeTarifasProveedor = New e_TarifasProveedor
            If ds.Tables.Count > 0 Then
                If ds.Tables(0).Rows.Count > 0 Then
                    oeTarifasProveedor = Cargar(ds.Tables(0).Rows(0))
                End If
            End If
            
            Return oeTarifasProveedor
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeTarifasProveedor As e_TarifasProveedor) As List(Of e_TarifasProveedor)
        Try
            Dim ldTarifasProveedor As New List(Of e_TarifasProveedor)
            Dim ds As DataSet
            With oeTarifasProveedor
                ds = sqlhelper.ExecuteDataset("OPE.Isp_TarifasProveedor_Listar", .TipoOperacion _
                        , .Id, .IdProveedor, .IdFlujoCaja, "", .IdMaterial, .IdCliente)
            End With
            oeTarifasProveedor = Nothing
            If ds.Tables.Count > 0 Then
                If ds.Tables(0).Rows.Count > 0 Then
                    For Each o_Fila As DataRow In ds.Tables(0).Rows
                        oeTarifasProveedor = Cargar(o_Fila)
                        ldTarifasProveedor.Add(oeTarifasProveedor)
                    Next
                End If
            End If
            Return ldTarifasProveedor
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarTarifasProveedor(ByVal oeTarifasProveedor As e_TarifasProveedor) As List(Of e_TarifasProveedor)
        Try
            Dim ldTarifasProveedor As New List(Of e_TarifasProveedor)
            Dim ds As DataSet
            With oeTarifasProveedor
                ds = sqlhelper.ExecuteDataset("OPE.Isp_TarifasProveedor_Listar", "" _
                        , "", "", "", .IdLugar, .IdMaterial, "")
            End With
            oeTarifasProveedor = Nothing
            If ds.Tables.Count > 0 Then
                If ds.Tables(0).Rows.Count > 0 Then
                    For Each o_Fila As DataRow In ds.Tables(0).Rows
                        oeTarifasProveedor = Cargar(o_Fila)
                        ldTarifasProveedor.Add(oeTarifasProveedor)
                    Next
                End If
            End If
            Return ldTarifasProveedor
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function Guardar(ByVal oeTarifasProveedor As e_TarifasProveedor) As Boolean
        Try
            With oeTarifasProveedor
                sqlhelper.ExecuteNonQuery("OPE.Isp_TarifasProveedor_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdProveedor _
                        , .IdLugar _
                        , .IdFlujoCaja _
                        , .Importe _
                        , .Tipo _
                        , .Activo _
                        , .Vigencia _
                        , .FechaCreacion _
                        , .IdMaterial _
                        , .IdCliente)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeTarifasProveedor As e_TarifasProveedor) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("OPE.Isp_TarifasProveedor_IAE", "E", _
             "", oeTarifasProveedor.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
