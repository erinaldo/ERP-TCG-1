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

Public Class d_ActividadRestringida

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_ActividadRestringida
        Try
            Dim oeActividadRestringida = New e_ActividadRestringida( _
                             o_fila("Id").ToString _
                             , o_fila("IdActividadNegocio").ToString _
                             , o_fila("IdProcesoNegocio").ToString _
                             , o_fila("ProcesoNegocio").ToString _
                             , o_fila("ActividadNegocio").ToString _
                             , o_fila("IdAccionSistema").ToString _
                             , o_fila("FechaCreacion") _
                             , o_fila("Activo") _
            )
            Return oeActividadRestringida
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeActividadRestringida As e_ActividadRestringida) As e_ActividadRestringida

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SGD.Isp_ActividadRestringida_Listar", "", oeActividadRestringida.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeActividadRestringida = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeActividadRestringida
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeActividadRestringida As e_ActividadRestringida) As List(Of e_ActividadRestringida)
        Try
            Dim ldActividadRestringida As New List(Of e_ActividadRestringida)
            Dim ds As DataSet
            With oeActividadRestringida
                ds = sqlhelper.ExecuteDataset("SGD.Isp_ActividadRestringida_Listar", "" _
                        , .Id _
                        , .IdActividadNegocio _
                        , .IdAccionSistema _
                        , .FechaCreacion _
                        , .Activo _
                        )
            End With
            oeActividadRestringida = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeActividadRestringida = Cargar(o_Fila)
                ldActividadRestringida.Add(oeActividadRestringida)
            Next
            Return ldActividadRestringida
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeActividadRestringida As e_ActividadRestringida) As Boolean
        Try
            With oeActividadRestringida
                sqlhelper.ExecuteNonQuery("SGD.Isp_ActividadRestringida_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdActividadNegocio _
                        , .IdAccionSistema _
                        , .FechaCreacion _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeActividadRestringida As e_ActividadRestringida) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SGD.Isp_ActividadRestringida_IAE", "E", _
             "", oeActividadRestringida.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
