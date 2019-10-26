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

Public Class d_FamiliaMaterial

    Private sqlhelper As New SqlHelper

    Private oeFamiliaMaterial As New e_FamiliaMaterial

    Public Function Cargar(ByVal fila As DataRow) As e_FamiliaMaterial
        Try
            Dim oefamiliamaterial = New e_FamiliaMaterial( _
                                                          fila("Id"), _
                                                          fila("Codigo"), _
                                                          fila("Nombre"), _
                                                          fila("Activo"), _
                                                          fila("IdTipoMaterial"), _
                                                          fila("TipoMaterial"))
            Return oefamiliamaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function Obtener(ByVal oeFamiliaMaterial As e_FamiliaMaterial) As e_FamiliaMaterial
        Try
            Dim ds As New DataSet
            With oeFamiliaMaterial
                ds = sqlhelper.ExecuteDataset("ALM.Isp_FamiliaMaterial_Listar", _
                                              "", _
                                              .Id, _
                                              .Codigo, _
                                              .Nombre _
                                              )
            End With
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeFamiliaMaterial = Cargar(ds.Tables(0).Rows(0))
            Else
                oeFamiliaMaterial = New e_FamiliaMaterial
            End If
            Return oeFamiliaMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeFamiliaMaterial As e_FamiliaMaterial) As List(Of e_FamiliaMaterial)
        Try
            Dim ds As New DataSet
            Dim lista As New List(Of e_FamiliaMaterial)
            With oeFamiliaMaterial
                ds = sqlhelper.ExecuteDataset("ALM.Isp_FamiliaMaterial_Listar", _
                                              "", _
                                              .Id, _
                                              .Codigo, _
                                              .Nombre, _
                                              .Activo, _
                                              .IdTipoMaterial)
            End With
            If ds.Tables.Count > 0 Then
                For Each fila As DataRow In ds.Tables(0).Rows
                    oeFamiliaMaterial = Cargar(fila)
                    lista.Add(oeFamiliaMaterial)
                Next
            End If
            Return lista
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function Guardar(ByVal oeFamiliaMaterial As e_FamiliaMaterial) As Boolean
        Try
            With oeFamiliaMaterial
                sqlhelper.ExecuteNonQuery("ALM.Isp_FamiliaMaterial_IAE",
                                          .TipoOperacion,
                                          .PrefijoID,
                                          .Id,
                                          .IdTipoMaterial,
                                          .Codigo,
                                          .Nombre,
                                          .Activo,
                                          .UsuarioCreacion)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeFamiliaMaterial As e_FamiliaMaterial) As Boolean
        Try
            With oeFamiliaMaterial
                sqlhelper.ExecuteNonQuery("ALM.Isp_FamiliaMaterial_IAE", _
                                          "E", "", .Id)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
