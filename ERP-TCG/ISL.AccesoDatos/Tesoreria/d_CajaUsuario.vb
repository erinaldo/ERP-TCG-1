Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_CajaUsuario
    Private SqlHelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_CajaUsuario
        Try
            Dim oeCajaUsuario = New e_CajaUsuario(o_fila("Id").ToString _
                             , o_fila("IdCaja").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("ApellidoPaterno").ToString _
                             , o_fila("ApellidoMaterno").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("IdCentro") _
             )
            Return oeCajaUsuario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCajaUsuario As e_CajaUsuario) As e_CajaUsuario

        Try
            Dim ds As New DataSet
            ds = SqlHelper.ExecuteDataset("TES.Isp_CajaUsuario_Listar", "", oeCajaUsuario.Id, _
                                          oeCajaUsuario.IdCaja, oeCajaUsuario.IdTrabajador, oeCajaUsuario.Activo)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeCajaUsuario = Cargar(ds.Tables(0).Rows(0))
            Else
                oeCajaUsuario = New e_CajaUsuario
            End If
            Return oeCajaUsuario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeCajaUsuario As e_CajaUsuario) As List(Of e_CajaUsuario)
        Try
            Dim ldCajaUsuario As New List(Of e_CajaUsuario)
            Dim ds As DataSet
            With oeCajaUsuario
                ds = SqlHelper.ExecuteDataset("TES.Isp_CajaUsuario_Listar", _
                          .TipoOperacion _
                        , .Id _
                        , .IdCaja _
                        , .IdTrabajador _
                        , .Activo _
                        )
            End With
            oeCajaUsuario = Nothing
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCajaUsuario = Cargar(o_Fila)
                    ldCajaUsuario.Add(oeCajaUsuario)
                Next
            Else
                ldCajaUsuario = New List(Of e_CajaUsuario)
            End If
            Return ldCajaUsuario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeCajaUsuario As e_CajaUsuario) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion

            With oeCajaUsuario
                SqlHelper.ExecuteNonQuery("TES.Isp_CajaUsuario_IAE", .TipoOperacion, _
                        .Id _
                        , .IdCaja _
                        , .IdTrabajador _
                        , .UsuarioCreacion _
                        , .Activo _
                        , .PrefijoID _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeCajaUsuario As e_CajaUsuario) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("TES.Isp_CajaUsuario_IAE", "E", oeCajaUsuario.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class