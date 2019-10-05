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

''' <summary>
''' Clase que permite el acceso a datos de la entidad ActividadNegocio
''' </summary>
''' <remarks></remarks>
Public Class d_ActividadNegocio

    Dim SqlHelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_ActividadNegocio
        Try
            Dim oe = New e_ActividadNegocio( _
                             o_fila("Id").ToString _
                             , o_fila("IdProcesoNegocio").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Abreviatura").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
            )
            Return oe
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeActividadNegocio As e_ActividadNegocio) As e_ActividadNegocio
        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset("STD.Isp_ActividadNegocio_Listar", "", oeActividadNegocio.Id)
            If ds.Tables.Count > 0 Then
                oeActividadNegocio = Cargar(ds.Tables(0).Rows(0))
                Return oeActividadNegocio
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeActividadNegocio As e_ActividadNegocio) As List(Of e_ActividadNegocio)
        Try
            Dim ld As New List(Of e_ActividadNegocio)
            Dim ds As DataSet
            With oeActividadNegocio
                ds = SqlHelper.ExecuteDataset("STD.Isp_ActividadNegocio_Listar", .TipoOperacion _
                        , .Id _
                        , .IdProcesoNegocio _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .Activo _
                        , .UsuarioCreacion _
                        )
            End With
            oeActividadNegocio = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeActividadNegocio = Cargar(o_Fila)
                    ld.Add(oeActividadNegocio)
                Next
                Return ld
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar() As Data.DataSet
        Try
            Return SqlHelper.ExecuteDataset("STD.Isp_ActividadNegocio_ListarDS")
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeActividadNegocio As e_ActividadNegocio) As Boolean
        Try
            With oeActividadNegocio
                SqlHelper.ExecuteNonQuery("STD.Isp_ActividadNegocio_IAE", .TipoOperacion,
                        .Id _
                        , .IdProcesoNegocio _
                        , .Codigo _
                        , .Nombre _
                        , .Abreviatura _
                        , .Activo _
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

    Public Function Eliminar(ByVal oeActividadNegocio As e_ActividadNegocio) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("STD.Isp_ActividadNegocio_IAE", "E", oeActividadNegocio.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function


End Class
