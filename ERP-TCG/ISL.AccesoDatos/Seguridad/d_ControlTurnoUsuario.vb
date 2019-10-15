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

Public Class d_ControlTurnoUsuario

    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_ControlTurnoUsuario
        Try
            Dim oeControlTurnoUsuario = New e_ControlTurnoUsuario( _
                             o_Fila("Id").ToString _
                             , o_Fila("IdUsuario").ToString _
                             , o_Fila("CierreAutomatico").ToString _
                             , o_Fila("LanzaAlerta").ToString _
                             , o_Fila("TiempoAlerta").ToString _
                             , o_Fila("Intervalo").ToString _
                             , o_Fila("FechaCreacion").ToString _
                             , o_Fila("UsuarioCreacion").ToString _
                             , o_Fila("Activo").ToString _
            )
            Return oeControlTurnoUsuario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeControlTurnoUsuario As e_ControlTurnoUsuario) As e_ControlTurnoUsuario
        Try
            Dim ds As DataSet
            With oeControlTurnoUsuario
                ds = sqlhelper.ExecuteDataset("SGD.Isp_ControlTurnoUsuario_Listar", "", .Id, .IdUsuario)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeControlTurnoUsuario = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeControlTurnoUsuario
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeControlTurnoUsuario As e_ControlTurnoUsuario) As List(Of e_ControlTurnoUsuario)
        Try
            Dim ldControlTurnoUsuario As New List(Of e_ControlTurnoUsuario)
            Dim ds As DataSet
            With oeControlTurnoUsuario
                ds = sqlhelper.ExecuteDataset("SGD.Isp_ControlTurnoUsuario_Listar", "" _
                        , .Id _
                        , .IdUsuario _
                        , .CierreAutomatico _
                        , .LanzaAlerta _
                        , .TiempoAlerta _
                        , .Intervalo _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeControlTurnoUsuario = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeControlTurnoUsuario = Cargar(o_Fila)
                ldControlTurnoUsuario.Add(oeControlTurnoUsuario)
            Next
            Return ldControlTurnoUsuario
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeControlTurnoUsuario As e_ControlTurnoUsuario) As Boolean
        Try
            With oeControlTurnoUsuario
                sqlhelper.ExecuteNonQuery("SGD.Isp_ControlTurnoUsuario_IAE", .TipoOperacion,
                        .Id _
                        , .IdUsuario _
                        , .CierreAutomatico _
                        , .LanzaAlerta _
                        , .TiempoAlerta _
                        , .Intervalo _
                        , .UsuarioCreacion _
                        , .Activo _
                        , .PrefijoID
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeControlTurnoUsuario As e_ControlTurnoUsuario) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SGD.Isp_ControlTurnoUsuario_IAE", "E", oeControlTurnoUsuario.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
