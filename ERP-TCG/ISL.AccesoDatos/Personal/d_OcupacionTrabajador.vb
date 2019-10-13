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

Public Class d_OcupacionTrabajador

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_OcupacionTrabajador
        Try
            Dim oeOcupacionTrabajador = New e_OcupacionTrabajador(o_fila("Seleccion").ToString _
                            , o_fila("Id").ToString _
                             , o_fila("IdOcupacion").ToString _
                             , o_fila("Ocupacion").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Principal") _
                             , o_fila("IdArea") _
                             , o_fila("Area") _
                             , o_fila("IdCargo") _
                             , o_fila("Cargo") _
                             , o_fila("IdCentro") _
                             , o_fila("Centro") _
                             , o_fila("IdTipoRelacionLaboral") _
                             , o_fila("TipoRelacionlaboral") _
                             , o_fila("FechaIngreso") _
                             , o_fila("FechaCese") _
                             , o_fila("IndRuta") _
            )
            oeOcupacionTrabajador.IdAreaOG = o_fila("IdAreaOG")
            oeOcupacionTrabajador.AreaOG = o_fila("AreaOG")
            oeOcupacionTrabajador.IdGerencia = o_fila("IdGerencia")
            oeOcupacionTrabajador.Gerencia = o_fila("Gerencia")
            Return oeOcupacionTrabajador
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeOcupacionTrabajador As e_OcupacionTrabajador) As e_OcupacionTrabajador

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("PER.Isp_OcupacionTrabajador_Listar", "", oeOcupacionTrabajador.Id, oeOcupacionTrabajador.IdOcupacion _
                                          , oeOcupacionTrabajador.IdTrabajador, "", oeOcupacionTrabajador.Principal)
            oeOcupacionTrabajador = New e_OcupacionTrabajador
            If ds.Tables(0).rows.Count > 0 Then
                oeOcupacionTrabajador = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeOcupacionTrabajador
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub ObtenerJefeArea(ByVal oeOcupacionTrabajador As e_OcupacionTrabajador)

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.MAIL_REQUERIMIENTO_GENERADO", oeOcupacionTrabajador.Id, oeOcupacionTrabajador.IdArea)
            oeOcupacionTrabajador = Nothing
            
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function Listar(ByVal oeOcupacionTrabajador As e_OcupacionTrabajador) As List(Of e_OcupacionTrabajador)
        Try
            Dim ldOcupacionTrabajador As New List(Of e_OcupacionTrabajador)
            Dim ds As DataSet
            With oeOcupacionTrabajador
                ds = sqlhelper.ExecuteDataset("PER.Isp_OcupacionTrabajador_Listar", "" _
                        , .Id _
                        , .IdOcupacion _
                        , .IdTrabajador _
                        , .UsuarioCreacion _
                        , .Principal _
                        , .Activo _
                        )
            End With
            oeOcupacionTrabajador = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeOcupacionTrabajador = Cargar(o_Fila)
                ldOcupacionTrabajador.Add(oeOcupacionTrabajador)
            Next
            Return ldOcupacionTrabajador
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeOcupacionTrabajador As e_OcupacionTrabajador) As Boolean
        Try
            With oeOcupacionTrabajador
                sqlhelper.ExecuteNonQuery("PER.Isp_OcupacionTrabajador_IAE", .TipoOperacion,
                        .Id _
                        , .IdOcupacion _
                        , .IdTrabajador _
                        , .UsuarioCreacion _
                        , .Activo _
                        , .Principal _
                        , .IdArea _
                        , .IdCargo _
                        , .IdCentro _
                        , .IdTipoRelacionLaboral _
                        , .FechaIngreso _
                        , .FechaCese _
                        , .IndRuta _
                        , .FechaEjecutaCese _
                        , .UsuarioEjecutaCese _
                        , .PrefijoID
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeOcupacionTrabajador As e_OcupacionTrabajador) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_OcupacionTrabajador_IAE", "E", oeOcupacionTrabajador.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function


End Class
