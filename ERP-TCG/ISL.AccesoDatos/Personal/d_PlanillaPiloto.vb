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

Public Class d_PlanillaPiloto

    Private sqlhelper As New SqlHelper
    Private odPlanillaPilotoDet As New d_PlanillaPilotoDet

    Private Function Cargar(ByVal o_fila As DataRow) As e_PlanillaPiloto
        Try
            Dim oePlanillaPiloto = New e_PlanillaPiloto(o_fila("Id").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("IdPlanilla").ToString _
                             , o_fila("Planilla").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("Total").ToString _
                             , o_fila("FechaInicio").ToString _
                             , o_fila("FechaFin").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString)
            Return oePlanillaPiloto
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oePlanillaPiloto As e_PlanillaPiloto) As e_PlanillaPiloto

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("PER.Isp_PlanillaPiloto_Listar", oePlanillaPiloto.TipoOperacion, oePlanillaPiloto.Id)
            oePlanillaPiloto = New e_PlanillaPiloto
            If ds.Tables(0).Rows.Count > 0 Then
                oePlanillaPiloto = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oePlanillaPiloto
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oePlanillaPiloto As e_PlanillaPiloto) As List(Of e_PlanillaPiloto)
        Try
            Dim ldPlanillaPiloto As New List(Of e_PlanillaPiloto)
            Dim ds As DataSet
            With oePlanillaPiloto
                ds = sqlhelper.ExecuteDataset("PER.Isp_PlanillaPiloto_Listar", "", .Id)
            End With
            oePlanillaPiloto = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oePlanillaPiloto = Cargar(o_Fila)
                ldPlanillaPiloto.Add(oePlanillaPiloto)
            Next
            Return ldPlanillaPiloto
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDS(ByVal oePlanillaPiloto As e_PlanillaPiloto) As System.Data.DataSet
        Try
            Dim ds As DataSet
            With oePlanillaPiloto
                ds = sqlhelper.ExecuteDataset("PER.Isp_PlanillaPiloto_Listar", 2, .Id, Date.Parse("01/01/1901"), Date.Parse("01/01/1901"), .IdPlanilla)
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oePlanillaPiloto As e_PlanillaPiloto) As Boolean
        Try
            Dim stResultado As String
            Using transScope As New TransactionScope()
                With oePlanillaPiloto
                    stResultado = sqlhelper.ExecuteScalar("PER.Isp_PlanillaPiloto_IAE", .TipoOperacion, .PrefijoID,
                            .Id _
                            , .IdPlanilla _
                            , .IdEstado _
                            , .Descripcion _
                            , .FechaInicio _
                            , .FechaFin _
                            , .Fecha _
                            , .Total _
                            , .FechaCreacion _
                            , .UsuarioCreacion _
                            , .Activo)
                    .Id = stResultado
                    For Each plapildet As e_PlanillaPilotoDet In .listaPlanillaPiloto
                        plapildet.IdPlanillaPiloto = .Id
                        plapildet.PrefijoID = oePlanillaPiloto.PrefijoID '@0001
                        odPlanillaPilotoDet.Guardar(plapildet)
                    Next
                End With
                transScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oePlanillaPiloto As e_PlanillaPiloto) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_PlanillaPiloto_IAE", "E", _
             "", oePlanillaPiloto.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
