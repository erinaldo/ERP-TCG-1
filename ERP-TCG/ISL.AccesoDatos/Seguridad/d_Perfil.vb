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

Public Class d_Perfil

    Private sqlHelper As New SqlHelper
    Dim odPerfilActividad As New d_PerfilActividadNegocio
    Dim oePerfilActividad As New e_PerfilActividadNegocio

    Private Function Cargar(ByVal o_fila As DataRow) As e_Perfil
        Try
            Dim oePerfil = New e_Perfil( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Abreviatura").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
            )
            Return oePerfil
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oePerfil As e_Perfil) As e_Perfil

        Try
            Dim ds As DataSet
            ds = sqlHelper.ExecuteDataset("SGD.ISP_Perfil_Listar", _
                                          oePerfil.TipoOperacion, _
                                          oePerfil.Id, _
                                          oePerfil.Codigo, _
                                          oePerfil.Nombre)
            If ds.Tables(0).Rows.Count > 0 Then
                oePerfil = Cargar(ds.Tables(0).Rows(0))
                oePerfilActividad.IdPerfil = oePerfil.Id
                oePerfil.lePerfilActividadNegocio = odPerfilActividad.Listar(oePerfilActividad)
                '    Return oePerfil
            Else
                oePerfil = New e_Perfil
                Return oePerfil
            End If
            Return oePerfil
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oePerfil As e_Perfil) As List(Of e_Perfil)
        Try
            Dim ldPerfil As New List(Of e_Perfil)
            Dim ds As DataSet
            With oePerfil
                ds = sqlHelper.ExecuteDataset("SGD.Isp_Perfil_Listar", "" _
                        , .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .Activo _
                        , .UsuarioCreacion _
                        )
            End With
            oePerfil = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oePerfil = Cargar(o_Fila)
                    ldPerfil.Add(oePerfil)
                Next
                Return ldPerfil
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    'Public Function ListarTodos(ByVal oePerfil As e_Perfil) As List(Of e_Perfil)
    '    Try
    '        Dim ldPerfil As New List(Of e_Perfil)
    '        Dim ds As DataSet
    '        With oePerfil
    '            ds = sqlHelper.ExecuteDataset("SGD.Isp_Perfil_Listar", "" _
    '                    , .Id _
    '                    , .Codigo _
    '                    , .Nombre _
    '                    , .Abreviatura _
    '                    )
    '        End With
    '        oePerfil = Nothing
    'If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
    '            For Each o_Fila As DataRow In ds.Tables(0).Rows
    '                oePerfil = Cargar(o_Fila)
    '                ldPerfil.Add(oePerfil)
    '            Next
    '            '    Return ldPerfil
    '            'Else
    '            '    Return Nothing
    '        End If
    '        Return ldPerfil
    '    Catch ex As Exception
    '        Throw
    '    End Try
    'End Function

    Public Function Guardar(ByVal oePerfil As e_Perfil) As Boolean
        Try
            Using TransScope As New TransactionScope()
                Dim id As String = ""
                With oePerfil
                    id = sqlHelper.ExecuteScalar("SGD.Isp_Perfil_IAE", .TipoOperacion _
                            , .Id _
                            , .Codigo _
                            , .Nombre _
                            , .Abreviatura _
                            , .Activo _
                            , .UsuarioCreacion _
                            , .PrefijoID _
                        )

                    If Not .lePerfilActividadNegocio Is Nothing Then
                        For Each oeDet In .lePerfilActividadNegocio
                            oeDet.IdPerfil = id
                            oeDet.PrefijoID = oePerfil.PrefijoID '@0001
                            If oeDet.TipoOperacion <> "" Then
                                If oeDet.TipoOperacion = "E" Then
                                    odPerfilActividad.Eliminar(oeDet)
                                Else
                                    odPerfilActividad.Guardar(oeDet)
                                End If
                            End If
                        Next
                    End If
                End With
                TransScope.Complete()
                Return True
            End Using

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oePerfil As e_Perfil) As Boolean
        Try
            sqlHelper.ExecuteNonQuery("SGD.Isp_Perfil_IAE", "E", oePerfil.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function


End Class
