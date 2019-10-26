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

Public Class d_MenuGrupo
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_MenuGrupo
        Try
            Dim oeMenuGrupo = New e_MenuGrupo( _
                             o_fila("Id").ToString _
                             , o_fila("IdMenuProceso").ToString _
                             , o_fila("MenuProceso") _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Abreviatura").ToString _
                             , o_fila("Orden").ToString _
                             , o_fila("Protegido").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
            )
            Return oeMenuGrupo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMenuGrupo As e_MenuGrupo) As e_MenuGrupo

        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("SGD.Isp_MenuGrupo_Listar", "", oeMenuGrupo.Id)
            If ds.Tables.Count > 0 Then
                oeMenuGrupo = Cargar(ds.Tables(0).Rows(0))
                Return oeMenuGrupo
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMenuGrupo As e_MenuGrupo) As List(Of e_MenuGrupo)
        Try
            Dim ldMenuGrupo As New List(Of e_MenuGrupo)
            Dim ds As DataSet
            With oeMenuGrupo
                ds = sqlhelper.ExecuteDataset("SGD.Isp_MenuGrupo_Listar", "" _
                        , .Id _
                        , .IdMenuProceso _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .Activo _
                        , .Orden _
                        , .Protegido _
                        , .UsuarioCreacion _
                        )
            End With
            oeMenuGrupo = Nothing
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMenuGrupo = Cargar(o_Fila)
                    ldMenuGrupo.Add(oeMenuGrupo)
                Next
            End If
            Return ldMenuGrupo
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function Guardar(ByVal oeMenuGrupo As e_MenuGrupo) As Boolean
        Try
            With oeMenuGrupo
                sqlhelper.ExecuteNonQuery("SGD.ISP_MenuGrupo_IAE", .TipoOperacion,
                        .Id _
                        , .IdMenuProceso _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .Activo _
                        , .Orden _
                        , .Protegido _
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

    Public Function Eliminar(ByVal oeMenuGrupo As e_MenuGrupo) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SGD.Isp_MenuGrupo_IAE", "E", oeMenuGrupo.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function ListarMenu(ByVal idUsuario As String, ByVal idMenuProceso As String) As List(Of e_MenuGrupo)
        Try
            Dim ldMenuGrupo As New List(Of e_MenuGrupo)
            Dim oeMenuGrupo As New e_MenuGrupo
            Dim odMenuActividad As New d_MenuActividad
            Dim ds As DataSet = sqlhelper.ExecuteDataset("SGD.Isp_Menu_Listar", "P", idUsuario, idMenuProceso)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMenuGrupo = Cargar(o_Fila)
                    oeMenuGrupo.leMenuActividad = odMenuActividad.ListarMenu(idUsuario, idMenuProceso, oeMenuGrupo.Id)
                    ldMenuGrupo.Add(oeMenuGrupo)
                    oeMenuGrupo = Nothing
                Next
            End If
            Return ldMenuGrupo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
