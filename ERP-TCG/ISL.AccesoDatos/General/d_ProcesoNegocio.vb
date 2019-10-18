'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions

Public Class d_ProcesoNegocio

    Private sqlhelper As New SqlHelper

    Private oeProcesoNegocio As New e_ProcesoNegocio
    Private oeActividadNegocio As New e_ActividadNegocio
    Private odActividadNegocio As New d_ActividadNegocio
    Private oeFlujoCaja As New e_FlujoCaja, odFlujoCaja As New d_FlujoGasto

    Private Function Cargar(ByVal o_fila As DataRow) As e_ProcesoNegocio
        Try
            Dim oeProcesoNegocio = New e_ProcesoNegocio(
                         o_fila("Id").ToString _
                         , o_fila("Codigo").ToString _
                         , o_fila("Nombre").ToString _
                         , o_fila("Indicador") _
                         , o_fila("Protegido").ToString _
                         , o_fila("IndSeguridad") _
                         , o_fila("Activo").ToString _
                         , o_fila("UsuarioCreacion").ToString
        )
            Return oeProcesoNegocio
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function Obtener(ByVal oeProcesoNegocio As e_ProcesoNegocio) As e_ProcesoNegocio
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.ISP_ProcesoNegocio_Listar", "", oeProcesoNegocio.Id, "", oeProcesoNegocio.Nombre)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeProcesoNegocio = Cargar(ds.Tables(0).Rows(0))
                oeActividadNegocio.IdProcesoNegocio = oeProcesoNegocio.Id
                oeProcesoNegocio.leActividadNegocio = odActividadNegocio.Listar(oeActividadNegocio)
                oeFlujoCaja = New e_FlujoCaja
                oeFlujoCaja.NombProceso = oeProcesoNegocio.Nombre.Trim
                oeFlujoCaja.TipoOperacion = "P"
                oeProcesoNegocio.leFlujoCaja = odFlujoCaja.Listar(oeFlujoCaja)
                Return oeProcesoNegocio
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeProcesoNegocio As e_ProcesoNegocio) As List(Of e_ProcesoNegocio)
        Try
            Dim ldProcesoNegocio As New List(Of e_ProcesoNegocio)
            Dim ds As DataSet
            With oeProcesoNegocio
                ds = sqlhelper.ExecuteDataset("STD.ISP_ProcesoNegocio_Listar", .TipoOperacion, .Id, .Codigo,
                        .Nombre, .Indicador, .Activo)
            End With
            oeProcesoNegocio = Nothing
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeProcesoNegocio = Cargar(o_Fila)
                    ldProcesoNegocio.Add(oeProcesoNegocio)
                Next
            End If
            Return ldProcesoNegocio
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeProcesoNegocio As e_ProcesoNegocio) As Boolean
        Try
            Dim id As String = ""
            Using TransScope As New TransactionScope()
                With oeProcesoNegocio
                    id = sqlhelper.ExecuteScalar("STD.Isp_ProcesoNegocio_IAE", .TipoOperacion,
                      .Id _
                      , .Codigo _
                      , .Nombre _
                      , .Indicador _
                      , .Protegido _
                      , .Seguridad _
                      , .Activo _
                      , .UsuarioCreacion _
                      , .PrefijoID
                  )
                End With

                If Not oeProcesoNegocio.leActividadNegocio Is Nothing Then
                    For Each oeActividadNegocio As e_ActividadNegocio In oeProcesoNegocio.leActividadNegocio
                        oeActividadNegocio.IdProcesoNegocio = id
                        oeActividadNegocio.PrefijoID = oeProcesoNegocio.PrefijoID '@0001
                        odActividadNegocio.Guardar(oeActividadNegocio)
                    Next
                End If
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeProcesoNegocio As e_ProcesoNegocio) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_ProcesoNegocio_IAE", "E", oeProcesoNegocio.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function


End Class
