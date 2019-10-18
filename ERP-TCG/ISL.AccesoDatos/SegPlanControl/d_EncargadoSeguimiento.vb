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

Public Class d_EncargadoSeguimiento
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_EncargadoSeguimiento
        Try
            Dim oeEncargadoSeguimiento = New e_EncargadoSeguimiento( _
                             o_Fila("Id").ToString _
                             , o_Fila("IdIncidencia").ToString _
                             , o_Fila("FechaInicio").ToString _
                             , o_Fila("FechaFin").ToString _
                             , o_Fila("IdTrabajador").ToString _
                             , o_Fila("GlosaGeneral").ToString _
                             , o_Fila("GlosaDescargo").ToString _
                             , o_Fila("EstadoEncargado").ToString _
                             , o_Fila("FechaCreacion").ToString _
                             , o_Fila("UsuarioCreacion").ToString _
                             , o_Fila("Activo").ToString _
                             , o_Fila("FechaModifica").ToString _
                             , o_Fila("UsuarioModifica").ToString _
            )
            Return oeEncargadoSeguimiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeEncargadoSeguimiento As e_EncargadoSeguimiento) As e_EncargadoSeguimiento

        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("SPC.Isp_EncargadoSeguimiento_Listar", "", oeEncargadoSeguimiento.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeEncargadoSeguimiento = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeEncargadoSeguimiento
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeEncargadoSeguimiento As e_EncargadoSeguimiento) As List(Of e_EncargadoSeguimiento)
        Try
            Dim ldEncargadoSeguimiento As New List(Of e_EncargadoSeguimiento)
            Dim ds As DataSet
            With oeEncargadoSeguimiento
                ds = SqlHelper.ExecuteDataset("SPC.Isp_EncargadoSeguimiento_Listar", "" _
                        , .Id _
                        , .IdIncidencia _
                        , .FechaInicio _
                        , .FechaFin _
                        , .IdTrabajador _
                        , .GlosaGeneral _
                        , .GlosaDescargo _
                        , .EstadoEncargado _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        )
            End With
            oeEncargadoSeguimiento = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeEncargadoSeguimiento = Cargar(o_Fila)
                ldEncargadoSeguimiento.Add(oeEncargadoSeguimiento)
            Next
            Return ldEncargadoSeguimiento
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeEncargadoSeguimiento As e_EncargadoSeguimiento) As Boolean
        Try
            With oeEncargadoSeguimiento
                sqlhelper.ExecuteNonQuery("SPC.Isp_EncargadoSeguimiento_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdIncidencia _
                        , .FechaInicio _
                        , .FechaFin _
                        , .IdTrabajador _
                        , .GlosaGeneral _
                        , .GlosaDescargo _
                        , .EstadoEncargado _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        , .FechaModifica _
                        , .UsuarioModifica
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeEncargadoSeguimiento As e_EncargadoSeguimiento) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("SPC.Isp_EncargadoSeguimiento_IAE", "E", _
             "", oeEncargadoSeguimiento.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
