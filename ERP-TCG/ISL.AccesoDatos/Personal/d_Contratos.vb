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

Public Class d_Contratos
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Contratos
        Try
            Dim oeContratos = New e_Contratos(o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("IdOcupacion").ToString _
                             , o_fila("Ocupacion").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("IdTipoContrato").ToString _
                             , o_fila("TipoContrato").ToString _
                             , o_fila("IdModalidadContrato").ToString _
                             , o_fila("ModalidadContrato").ToString _
                             , o_fila("Sueldo").ToString _
                             , o_fila("FechaInicio").ToString _
                             , o_fila("FechaTermino").ToString _
                             , o_fila("Vigencia").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCese").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("RegimenLaboral").ToString _
                             , o_fila("JornadaTrabajoMaxima") _
                             , o_fila("JornadaAcumulativa") _
                             , o_fila("JornadaNocturno") _
                             , o_fila("SituacionEspecial") _
                             , o_fila("Discapacitado") _
                             , o_fila("Sindicalizado") _
                             , o_fila("IdMotivoCese").ToString _
                             , o_fila("MotivoCese").ToString)
            Return oeContratos
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeContratos As e_Contratos) As e_Contratos
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("PER.Isp_Contratos_Listar", oeContratos.TipoOperacion, oeContratos.Id, oeContratos.IdTrabajador)
            If ds.Tables(0).Rows.Count > 0 Then
                oeContratos = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeContratos
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeContratos As e_Contratos) As List(Of e_Contratos)
        Try
            Dim ldContratos As New List(Of e_Contratos)
            Dim ds As DataSet
            With oeContratos
                ds = sqlhelper.ExecuteDataset("PER.Isp_Contratos_Listar", .TipoOperacion, .Id, .IdTrabajador, .IdOcupacion, .IdTipoContrato _
                                              , .Vigencia, .FechaDesde, .FechaHasta)
            End With
            oeContratos = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeContratos = Cargar(o_Fila)
                ldContratos.Add(oeContratos)
            Next
            Return ldContratos
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeContratos As e_Contratos) As Boolean
        Try
            With oeContratos
                sqlhelper.ExecuteNonQuery("PER.Isp_Contratos_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdTrabajador _
                        , .IdOcupacion _
                        , .IdEstado _
                        , .IdTipoContrato _
                        , .Sueldo _
                        , .FechaInicio _
                        , .FechaTermino _
                        , .Vigencia _
                        , .Activo _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaCese _
                        , .Glosa _
                        , .IdModalidadContrato _
                        , .RegimenLaboral _
                        , .JornadaTrabajoMax _
                        , .JornadaAcumulativo _
                        , .JornadaNocturno _
                        , .SituacionEspecial _
                        , .Discapacitado _
                        , .Sindicalizado _
                        , .IdMotivoCese)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Clonar(ByVal oeContrato1 As e_Contratos, ByVal oeContrato2 As e_Contratos) As Boolean
        Try
            Using TransScope As New TransactionScope()
                With oeContrato1
                    sqlhelper.ExecuteNonQuery("PER.Isp_Contratos_IAE", "V", "", .Id)
                End With
                With oeContrato2
                    sqlhelper.ExecuteNonQuery("PER.Isp_Contratos_IAE", .TipoOperacion, .PrefijoID,
                            .Id, .IdTrabajador, .IdOcupacion, .IdEstado, .IdTipoContrato, .Sueldo, .FechaInicio _
                            , .FechaTermino, .Vigencia, .Activo, .FechaCreacion, .UsuarioCreacion, .FechaCese _
                            , .Glosa, .IdModalidadContrato, .RegimenLaboral, .JornadaTrabajoMax, .JornadaAcumulativo _
                            , .JornadaNocturno, .SituacionEspecial, .Discapacitado, .Sindicalizado)
                End With
                TransScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeContratos As e_Contratos) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_Contratos_IAE", "E", _
             "", oeContratos.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
