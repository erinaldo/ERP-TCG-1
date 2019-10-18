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

Public Class d_ControlActividad

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_ControlActividad
        Try
            Dim oeControlActividad = New e_ControlActividad( _
                             o_Fila("Id").ToString _
                             , o_Fila("IdActividad").ToString _
                             , o_Fila("FechaCreacion").ToString _
                             , o_Fila("UsuarioCreacion").ToString _
                             , o_Fila("Glosa").ToString _
                             , o_Fila("Activo").ToString _
            )
            Return oeControlActividad
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeControlActividad As e_ControlActividad) As e_ControlActividad

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SGD.Isp_ControlActividad_Listar", "", oeControlActividad.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeControlActividad = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeControlActividad
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeControlActividad As e_ControlActividad) As List(Of e_ControlActividad)
        Try
            Dim ldControlActividad As New List(Of e_ControlActividad)
            Dim ds As DataSet
            With oeControlActividad
                ds = sqlhelper.ExecuteDataset("SGD.Isp_ControlActividad_Listar", "" _
                        , .Id _
                        , .IdActividad _
                        , .UsuarioCreacion _
                        , .Glosa _
                        , .Activo _
                        )
            End With
            oeControlActividad = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeControlActividad = Cargar(o_Fila)
                ldControlActividad.Add(oeControlActividad)
            Next
            Return ldControlActividad
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeControlActividad As e_ControlActividad) As Boolean
        Try
            With oeControlActividad
                sqlhelper.ExecuteNonQuery("SGD.Isp_ControlActividad_IAE", .TipoOperacion,
                        .Id _
                        , .IdActividad _
                        , .UsuarioCreacion _
                        , .Glosa _
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

    Public Function Eliminar(ByVal oeControlActividad As e_ControlActividad) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SGD.Isp_ControlActividad_IAE", "E", oeControlActividad.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function


End Class
