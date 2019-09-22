'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo .PrefijoID por PrefijoID
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_ControlUsuario
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_ControlUsuario
        Try
            Dim oeControlUsuario = New e_ControlUsuario( _
                             o_fila("Id").ToString _
                             , o_fila("IdUsuario").ToString _
                             , o_fila("FechaInicio").ToString _
                             , o_fila("FechaSalida").ToString _
                             , o_fila("Ampliacion").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , IIf(o_fila("Salida") = True, 1, 0) _
                             , o_fila("ApellidoPaterno") & " " & o_fila("ApellidoMaterno") & ", " & o_fila("Nombre") _
                             , o_fila("Area").ToString _
                             , o_fila("Ipv4").ToString _
            )
            Return oeControlUsuario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeControlUsuario As e_ControlUsuario) As e_ControlUsuario
        Try
            Dim ds As DataSet
            With oeControlUsuario
                ds = sqlhelper.ExecuteDataset("SGD.Isp_ControlUsuario_Listar", .TipoOperacion, .Id, .IdUsuario, .FechaInicio, .FechaSalida, .Ampliacion, .Salida)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeControlUsuario = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeControlUsuario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeControlUsuario As e_ControlUsuario) As List(Of e_ControlUsuario)
        Try
            Dim ldControlUsuario As New List(Of e_ControlUsuario)
            Dim ds As DataSet
            With oeControlUsuario
                ds = sqlhelper.ExecuteDataset("SGD.Isp_ControlUsuario_Listar", .TipoOperacion _
                        , .Id _
                        , .IdUsuario _
                        , .FechaInicio _
                        , .FechaSalida _
                        , .Ampliacion _
                        , .IdArea _
                        , .Salida _
                        )
            End With
            oeControlUsuario = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeControlUsuario = Cargar(o_Fila)
                ldControlUsuario.Add(oeControlUsuario)
            Next
            Return ldControlUsuario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeControlUsuario As e_ControlUsuario) As String
        Try
            Dim id As String = ""
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeControlUsuario
                id = sqlhelper.ExecuteScalar("SGD.Isp_ControlUsuario_IAE", .TipoOperacion,
                        .Id _
                        , .IdUsuario _
                        , .Ampliacion _
                        , .Salida _
                        , .PrefijoID _
                        , .Ipv4
                    )
            End With
            Return id
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeControlUsuario As e_ControlUsuario) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SGD.Isp_ControlUsuario_IAE", "E", oeControlUsuario.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
