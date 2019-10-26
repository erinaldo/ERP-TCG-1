'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF

Public Class d_MenuProceso
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_MenuProceso
        Try
            Dim oeProceso = New e_MenuProceso( _
                              o_fila("Id") _
                             , o_fila("Codigo") _
                             , o_fila("Nombre") _
                             , o_fila("Abreviatura") _
                             , o_fila("Protegido") _
                             , o_fila("Explorer") _
                             , CInt(o_fila("Orden")) _
                              , o_fila("Activo") _
                              , o_fila("UsuarioCreacion") _
            )
            Return oeProceso
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeProceso As e_MenuProceso) As e_MenuProceso

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SGD.Isp_MenuProceso_Listar", "", oeProceso.Id)
            If ds.Tables.Count > 0 Then
                oeProceso = Cargar(ds.Tables(0).Rows(0))
                Return oeProceso
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeProceso As e_MenuProceso) As List(Of e_MenuProceso)
        Try
            Dim ldProceso As New List(Of e_MenuProceso)
            Dim ds As DataSet
            With oeProceso
                ds = sqlhelper.ExecuteDataset("SGD.Isp_MenuProceso_Listar", "" _
                        , .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .Activo _
                        , .Orden _
                        )
            End With
            oeProceso = Nothing
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeProceso = Cargar(o_Fila)
                    ldProceso.Add(oeProceso)
                Next
            End If
            Return ldProceso
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeProceso As e_MenuProceso) As Boolean
        Try
            With oeProceso
                sqlhelper.ExecuteNonQuery("SGD.Isp_MenuProceso_IAE", .TipoOperacion,
                         .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .Activo _
                        , .Orden _
                          , .Protegido _
                          , .Explorador _
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


    Public Function Eliminar(ByVal oeProceso As e_MenuProceso) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SGD.Isp_MenuProceso_IAE", "E", oeProceso.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function ListarMenu(ByVal idUsuario As String) As List(Of e_MenuProceso)
        Try
            Dim leMenuProceso As New List(Of e_MenuProceso)
            Dim oeMenuProceso As New e_MenuProceso
            Dim odMenuGrupo As New d_MenuGrupo
            Dim ds As DataSet = sqlhelper.ExecuteDataset("SGD.Isp_Menu_Listar", "U", idUsuario)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMenuProceso = Cargar(o_Fila)
                    oeMenuProceso.leMenuGrupo = odMenuGrupo.ListarMenu(idUsuario, oeMenuProceso.Id)
                    leMenuProceso.Add(oeMenuProceso)
                    oeMenuProceso = Nothing
                Next
            End If
            Return leMenuProceso
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
