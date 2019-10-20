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

Public Class d_EntornoTrabajo

    Dim SqlHelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_EntornoTrabajo
        Try
            Dim oeEntornoTrabajo = New e_EntornoTrabajo( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
            )
            Return oeEntornoTrabajo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeEntornoTrabajo As e_EntornoTrabajo) As e_EntornoTrabajo

        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("SGD.Isp_EntornoTrabajo_Listar", "", oeEntornoTrabajo.Id)
            If ds.Tables.Count > 0 Then
                oeEntornoTrabajo = Cargar(ds.Tables(0).Rows(0))
                Return oeEntornoTrabajo
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeEntornoTrabajo As e_EntornoTrabajo) As List(Of e_EntornoTrabajo)
        Try
            Dim ldEntornoTrabajo As New List(Of e_EntornoTrabajo)
            Dim ds As DataSet
            With oeEntornoTrabajo
                ds = SqlHelper.ExecuteDataset("SGD.Isp_EntornoTrabajo_Listar", "" _
                        , .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Activo _
                        , .UsuarioCreacion _
                        )
            End With
            oeEntornoTrabajo = Nothing
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeEntornoTrabajo = Cargar(o_Fila)
                    ldEntornoTrabajo.Add(oeEntornoTrabajo)
                Next
            End If
            Return ldEntornoTrabajo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeEntornoTrabajo As e_EntornoTrabajo) As Boolean
        Try
            With oeEntornoTrabajo
                SqlHelper.ExecuteNonQuery("SGD.ISP_EntornoTrabajo_IAE", .TipoOperacion,
                        .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .PrefijoID
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeEntornoTrabajo As e_EntornoTrabajo) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("SGD.ISP_EntornoTrabajo_IAE", "E",  oeEntornoTrabajo.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
