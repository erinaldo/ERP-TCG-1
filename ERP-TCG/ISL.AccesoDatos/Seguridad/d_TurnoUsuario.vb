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

Public Class d_TurnoUsuario

    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_TurnoUsuario
        Try
            Dim oeTurnoUsuario = New e_TurnoUsuario( _
                             o_fila("Id").ToString _
                             , o_fila("IdTurno").ToString _
                             , o_fila("IdUsuario").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("HoraInicio").ToString _
                             , o_fila("HoraSalida").ToString _
                             , o_fila("Dia").ToString _
                             , o_fila("Turno").ToString _
            )
            Return oeTurnoUsuario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTurnoUsuario As e_TurnoUsuario) As e_TurnoUsuario

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SGD.Isp_Turno_Usuario_Listar", "", oeTurnoUsuario.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeTurnoUsuario = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeTurnoUsuario
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTurnoUsuario As e_TurnoUsuario) As List(Of e_TurnoUsuario)
        Try
            Dim ldTurnoUsuario As New List(Of e_TurnoUsuario)
            Dim ds As DataSet
            With oeTurnoUsuario
                ds = sqlhelper.ExecuteDataset("SGD.Isp_Turno_Usuario_Listar", "" _
                        , .Id _
                        , .IdTurno _
                        , .IdUsuario _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeTurnoUsuario = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeTurnoUsuario = Cargar(o_Fila)
                ldTurnoUsuario.Add(oeTurnoUsuario)
            Next
            Return ldTurnoUsuario
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTurnoUsuario As e_TurnoUsuario) As Boolean
        Try

            With oeTurnoUsuario
                sqlhelper.ExecuteNonQuery("SGD.Isp_Turno_Usuario_IAE", .TipoOperacion,
                        .Id _
                        , .IdTurno _
                        , .IdUsuario _
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

    Public Function Eliminar(ByVal oeTurnoUsuario As e_TurnoUsuario) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SGD.Isp_Turno_Usuario_IAE", "E", oeTurnoUsuario.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
