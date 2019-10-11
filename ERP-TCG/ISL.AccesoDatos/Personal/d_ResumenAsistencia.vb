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

Public Class d_ResumenAsistencia

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_ResumenAsistencia
        Try
            Dim oeResumenAsistencia = New e_ResumenAsistencia( _
                             o_fila("Id").ToString _
                             , o_fila("IdPlanilla").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("Dni").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("IndTipo") _
                             , o_fila("Cantidad") _
                             , o_fila("GozedeHaber") _
                             , o_fila("FechaInicio") _
                             , o_fila("FechaTermino") _
                             , o_fila("Observacion").ToString _
                             , o_fila("DiasNetos") _
                             , o_fila("IndTipoAux") _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaModifica") _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo") _
            )
            oeResumenAsistencia.CodigoSuspension = o_fila("CodigoSuspension").ToString
            Return oeResumenAsistencia
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeResumenAsistencia As e_ResumenAsistencia) As e_ResumenAsistencia

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("PER.Isp_ResumenAsistencia_Listar", "", oeResumenAsistencia.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeResumenAsistencia = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeResumenAsistencia
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeResumenAsistencia As e_ResumenAsistencia) As List(Of e_ResumenAsistencia)
        Try
            Dim ldResumenAsistencia As New List(Of e_ResumenAsistencia)
            Dim ds As DataSet
            With oeResumenAsistencia
                ds = sqlhelper.ExecuteDataset("PER.Isp_ResumenAsistencia_Listar", .TipoOperacion _
                        , .Id _
                        , .IdPlanilla _
                        , .IdTrabajador _
                        , .IndTipo _
                        , .Cantidad _
                        , .GozedeHaber _
                        , .IdEstado _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                        )
            End With
            oeResumenAsistencia = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeResumenAsistencia = Cargar(o_Fila)
                ldResumenAsistencia.Add(oeResumenAsistencia)
            Next
            Return ldResumenAsistencia
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeResumenAsistencia As e_ResumenAsistencia) As Boolean
        Try
            With oeResumenAsistencia
                sqlhelper.ExecuteNonQuery("PER.Isp_ResumenAsistencia_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdPlanilla _
                        , .IdTrabajador _
                        , .IndTipo _
                        , .Cantidad _
                        , .GozedeHaber _
                        , .FechaInicio _
                        , .FechaTermino _
                        , .Observacion _
                        , .DiasNetos _
                        , .IndTipoAux _
                        , .IdEstado _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                        , .CodigoSuspension
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarLista(ByVal leResumenAsist As List(Of e_ResumenAsistencia)) As Boolean
        Try
            Using TransScope As New TransactionScope()
                For Each oeRA In leResumenAsist
                    Guardar(oeRA)
                Next
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarMasivo(ByVal dtResumenAsis As DataTable) As Boolean
        Try
            sqlhelper.InsertarMasivo("PER.ResumenAsistencia", dtResumenAsis)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeResumenAsistencia As e_ResumenAsistencia) As Boolean
        Try
            With oeResumenAsistencia
                sqlhelper.ExecuteNonQuery("PER.Isp_ResumenAsistencia_IAE", "E", "", _
                        .Id _
                        , .IdPlanilla _
                        , .IdTrabajador _
                        , .IndTipo _
                        , .Cantidad _
                        , .GozedeHaber _
                        , .FechaInicio _
                        , .FechaTermino _
                        , .Observacion _
                        , .DiasNetos _
                        , .IndTipoAux _
                        , .IdEstado _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                        , .CodigoSuspension
                        )
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function EliminarLista(ByVal leResumenAsist As List(Of e_ResumenAsistencia)) As Boolean
        Try
            Using TransScope As New TransactionScope()
                For Each oeRA In leResumenAsist
                    Eliminar(oeRA)
                Next
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "PER.ResumenAsistencia", PrefijoID)
            Return stResultado
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    'Function GenerarAsistencias(oeMovDocumento As e_MovimientoDocumento) As DataSet
    '    Try
    '        Dim dsDet As DataSet
    '        With oeMovDocumento
    '            dsDet = sqlhelper.ExecuteDataset("CON.Isp_FacturacionElectronica_Listar", .TipoOperacion, .Id)
    '        End With
    '        If dsDet.Tables.Count = 0 Then Throw New Exception("¡No se encontraron Datos!")
    '        Return dsDet
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    Function AsistenciaOperativos(oeResumenAsistencia As e_ResumenAsistencia) As DataTable
        Try
            Dim dsDet As DataSet
            With oeResumenAsistencia
                dsDet = sqlhelper.ExecuteDataset("[PER].[Isp_AsistenciaOperativos_Listar]", .TipoOperacion, .Id, .IdPlanilla)
            End With
            If dsDet.Tables.Count = 0 Then Throw New Exception("¡No se encontraron Datos!")
            Return dsDet.Tables(0)
        Catch ex As Exception
            Throw ex
        End Try
    End Function


End Class
