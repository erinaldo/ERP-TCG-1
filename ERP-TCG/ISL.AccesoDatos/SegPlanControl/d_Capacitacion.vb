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

Public Class d_Capacitacion

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Capacitacion
        Try
            Dim oeCapacitacion = New e_Capacitacion( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("IndTipo") _
                             , o_fila("IdExpositor").ToString _
                             , o_fila("Expositor").ToString _
                             , o_fila("IndExpositor") _
                             , o_fila("FechaInicio").ToString _
                             , o_fila("FechaFin").ToString _
                             , o_fila("Lugar").ToString _
                             , o_fila("Resumen").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaModifica") _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo") _
            )
            Return oeCapacitacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCapacitacion As e_Capacitacion) As e_Capacitacion

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SPC.Isp_Capacitacion_Listar", oeCapacitacion.TipoOperacion, oeCapacitacion.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeCapacitacion = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeCapacitacion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCapacitacion As e_Capacitacion) As List(Of e_Capacitacion)
        Try
            Dim ldCapacitacion As New List(Of e_Capacitacion)
            Dim ds As DataSet
            With oeCapacitacion
                ds = sqlhelper.ExecuteDataset("SPC.Isp_Capacitacion_Listar", "" _
                        , .Id _
                        , .Codigo _
                        , .Nombre _
                        , .IndTipo _
                        , .IdExpositor _
                        , .IndExpositor _
                        , .FechaInicio _
                        , .FechaFin _
                        , .Lugar _
                        , .Resumen _
                        , .IdEstado _
                        , .Activo _
                        )
            End With
            oeCapacitacion = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeCapacitacion = Cargar(o_Fila)
                ldCapacitacion.Add(oeCapacitacion)
            Next
            Return ldCapacitacion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCapacitacion As e_Capacitacion) As Boolean
        Try
            With oeCapacitacion
                sqlhelper.ExecuteNonQuery("SPC.Isp_Capacitacion_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .Codigo _
                        , .Nombre _
                        , .IndTipo _
                        , .IdExpositor _
                        , .IndExpositor _
                        , .FechaInicio _
                        , .FechaFin _
                        , .Lugar _
                        , .Resumen _
                        , .IdEstado _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeCapacitacion As e_Capacitacion) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SPC.Isp_Capacitacion_IAE", "E", _
             "", oeCapacitacion.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
