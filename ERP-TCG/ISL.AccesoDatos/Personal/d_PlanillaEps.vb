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

Public Class d_PlanillaEps

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_PlanillaEps
        Try
            Dim oePlanillaEps = New e_PlanillaEps( _
                             o_fila("Id").ToString _
                             , o_fila("IdPlanilla").ToString _
                             , o_fila("Planilla").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("Dni").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("Sueldo") _
                             , o_fila("AsignacionFamiliar") _
                             , o_fila("HoraExtra25") _
                             , o_fila("HoraExtra35") _
                             , o_fila("HorasNocturnas") _
                             , o_fila("Movilidad") _
                             , o_fila("BonoProduccion") _
                             , o_fila("CompensacionVacacional") _
                             , o_fila("RenumeracionVacacional") _
                             , o_fila("BonoResponsabilidad") _
                             , o_fila("DescansoMedico") _
                             , o_fila("VueltaAdicionalPiura") _
                             , o_fila("BonoCombustiblePiura") _
                             , o_fila("BonoJefeConvoy") _
                             , o_fila("VueltaAdicionalLima") _
                             , o_fila("Otros") _
                             , o_fila("VueltaCaliza") _
                             , o_fila("Semaforo") _
                             , o_fila("Bonos") _
                             , o_fila("TotalSueldo") _
                             , o_fila("AporteEssalud") _
                             , o_fila("CreditoEps") _
                             , o_fila("IdEpsContratada").ToString _
                             , o_fila("EpsContratada") _
                             , o_fila("Adicional") _
                             , o_fila("TotalEps") _
                             , o_fila("Dependiente") _
                             , o_fila("Regularizacion") _
                             , o_fila("MontoPlanilla") _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaModifica") _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oePlanillaEps
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oePlanillaEps As e_PlanillaEps) As e_PlanillaEps

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("PER.Isp_PlanillaEps_Listar", "", oePlanillaEps.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oePlanillaEps = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oePlanillaEps
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oePlanillaEps As e_PlanillaEps) As List(Of e_PlanillaEps)
        Try
            Dim ldPlanillaEps As New List(Of e_PlanillaEps)
            Dim ds As DataSet
            With oePlanillaEps
                ds = sqlhelper.ExecuteDataset("PER.Isp_PlanillaEps_Listar", .TipoOperacion _
                        , .Id _
                        , .IdPlanilla _
                        , .IdTrabajador _
                        , .Sueldo _
                        , .AsignacionFamiliar _
                        , .TotalSueldo _
                        , .AporteEssalud _
                        , .CreditoEps _
                        , .IdEpsContratada _
                        , .EpsContratada _
                        , .Adicional _
                        , .TotalEps _
                        , .MontoPlanilla _
                        , .IdEstado _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oePlanillaEps = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oePlanillaEps = Cargar(o_Fila)
                ldPlanillaEps.Add(oePlanillaEps)
            Next
            Return ldPlanillaEps
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oePlanillaEps As e_PlanillaEps) As Boolean
        Try
            With oePlanillaEps
                sqlhelper.ExecuteNonQuery("PER.Isp_PlanillaEps_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdPlanilla _
                        , .IdTrabajador _
                        , .Sueldo _
                        , .AsignacionFamiliar _
                        , .HoraExtra25 _
                        , .HoraExtra35 _
                        , .HorasNocturnas _
                        , .Movilidad _
                        , .BonoProduccion _
                        , .CompensacionVacacional _
                        , .RenumeracionVacacional _
                        , .BonoResponsabilidad _
                        , .DescansoMedico _
                        , .VueltaAdicionalPiura _
                        , .BonoCombustiblePiura _
                        , .BonoJefeConvoy _
                        , .VueltaAdicionalLima _
                        , .Otros _
                        , .VueltaCaliza _
                        , .Semaforo _
                        , .Bonos _
                        , .TotalSueldo _
                        , .AporteEssalud _
                        , .CreditoEps _
                        , .IdEpsContratada _
                        , .EpsContratada _
                        , .Adicional _
                        , .TotalEps _
                        , .Dependiente _
                        , .Regularizacion _
                        , .MontoPlanilla _
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

    Public Function GuardarLista(ByVal lePlanillaEps As List(Of e_PlanillaEps)) As Boolean
        Try
            Using TransScope As New TransactionScope()
                For Each oePE In lePlanillaEps
                    Guardar(oePE)
                Next
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oePlanillaEps As e_PlanillaEps) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_PlanillaEps_IAE", "E", _
             "", oePlanillaEps.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function EliminarLista(ByVal lePlanillaEps As List(Of e_PlanillaEps)) As Boolean
        Try
            Using TransScope As New TransactionScope()
                For Each oePE In lePlanillaEps
                    Eliminar(oePE)
                Next
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
