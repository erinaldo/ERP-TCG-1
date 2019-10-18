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

Public Class d_MenuActividad

    Private sqlhelper As New SqlHelper

    Public Function Cargar(ByVal o_fila As DataRow) As e_MenuActividad
        Try
            Dim oeMenuActividad = New e_MenuActividad( _
                                o_fila("Id") _
                         , o_fila("IdActividadNegocio") _
                        , o_fila("MenuProceso") _
                        , o_fila("IdProcesoNegocio") _
                         , o_fila("IdMenuGrupo") _
                         , o_fila("MenuGrupo") _
                        , o_fila("IdMenuProceso") _
                         , o_fila("Codigo") _
                         , o_fila("Nombre") _
                         , o_fila("Abreviatura") _
                         , o_fila("Orden") _
                         , o_fila("Protegido") _
                         , o_fila("Explorer") _
                         , o_fila("Imagen") _
                         , o_fila("Tamano") _
                         , o_fila("Texto") _
                         , o_fila("Formulario") _
                         , o_fila("Form") _
                         , IIf(o_fila("Menu"), 1, 0) _
                         , o_fila("IdMenuItem") _
                         , IIf(o_fila("Padre"), "SI", "NO") _
                        , o_fila("NombrePadre") _
                        , IIf(o_fila("MultipleInstancia"), "SI", "NO") _
                         , o_fila("UsuarioCreacion") _
                         , o_fila("Activo") _
            )
            Return oeMenuActividad
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMenuActividad As e_MenuActividad) As e_MenuActividad
        Try
            Dim ds As DataSet
            With oeMenuActividad
                ds = sqlhelper.ExecuteDataset("SGD.Isp_MenuActividad_Listar", "", .Id, .IdActividadNegocio, .IdMenuGrupo, .IdMenuItem, .Codigo)
            End With
            oeMenuActividad = New e_MenuActividad
            If ds.Tables(0).Rows.Count > 0 Then
                oeMenuActividad = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeMenuActividad
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function Listar(ByVal oeMenuActividad As e_MenuActividad) As List(Of e_MenuActividad)
        Try
            Dim ld As New List(Of e_MenuActividad)
            Dim ds As DataSet
            With oeMenuActividad
                ds = sqlhelper.ExecuteDataset("SGD.Isp_MenuActividad_Listar", "" _
                        , .Id _
                        , .IdActividadNegocio _
                        , .IdMenuGrupo _
                        , .IdMenuItem _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .Orden _
                        , .Menu _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeMenuActividad = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMenuActividad = Cargar(o_Fila)
                    ld.Add(oeMenuActividad)
                Next
                Return ld
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMenuActividad As e_MenuActividad) As Boolean
        Try
            With oeMenuActividad
                sqlhelper.ExecuteNonQuery("SGD.Isp_MenuActividad_IAE", .TipoOperacion,
                        .Id _
                        , .IdActividadNegocio _
                        , .IdMenuGrupo _
                        , .IdMenuItem _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .Orden _
                        , .UsuarioCreacion _
                        , .Activo _
                        , .Protegido _
                        , .Explorer _
                        , .Imagen _
                        , .Tamano _
                        , .Texto _
                        , .Formulario _
                        , .Menu _
                        , .PrefijoID
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeMenuActividad As e_MenuActividad) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SGD.Isp_MenuActividad_IAE", "E", oeMenuActividad.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function ListarMenu(ByVal idUsuario As String, ByVal idMenuProceso As String, ByVal idMenuGrupo As String) As List(Of e_MenuActividad)
        Try
            Dim leMenuActividad As New List(Of e_MenuActividad)
            Dim oeMenuActividad As New e_MenuActividad
            Dim ds As DataSet = sqlhelper.ExecuteDataset("SGD.Isp_Menu_Listar", "G", idUsuario, idMenuProceso, idMenuGrupo)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMenuActividad = Cargar(o_Fila)
                    If oeMenuActividad.Menu Then oeMenuActividad.leSubMenu = ListarSubMenu(idUsuario, idMenuProceso, idMenuGrupo, oeMenuActividad.Id)
                    leMenuActividad.Add(oeMenuActividad)
                    oeMenuActividad = Nothing
                Next
            End If
            Return leMenuActividad
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ListarSubMenu(ByVal idUsuario As String, ByVal idMenuProceso As String, ByVal idMenuGrupo As String, ByVal idMenuItem As String) As List(Of e_MenuActividad)
        Try
            Dim leItem As New List(Of e_MenuActividad)
            Dim oeItem As New e_MenuActividad
            Dim ds As DataSet = sqlhelper.ExecuteDataset("SGD.Isp_Menu_Listar", "M", idUsuario, idMenuProceso, idMenuGrupo, idMenuItem)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeItem = Cargar(o_Fila)
                    leItem.Add(oeItem)
                    oeItem = Nothing
                Next
            End If
            Return leItem
        Catch ex As Exception
            Throw ex
        End Try
    End Function




End Class
