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

Public Class d_PlanillaPilotoDet
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_PlanillaPilotoDet
        Try
            Dim oePlanillaPilotoDet = New e_PlanillaPilotoDet( _
                             o_fila("Id").ToString _
                             , o_fila("IdPlanillaPiloto").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("Trabajador").ToString _
                                                          , o_fila("TipoTrabajador").ToString _
                                                          , o_fila("Dni").ToString _
                             , o_fila("MontoTotal").ToString _
                             , o_fila("Cuenta").ToString _
                             , o_fila("Tipo").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString)
            Return oePlanillaPilotoDet
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oePlanillaPilotoDet As e_PlanillaPilotoDet) As e_PlanillaPilotoDet

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("XXX.ISP_XXXXXX_Listar", "", oePlanillaPilotoDet.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oePlanillaPilotoDet = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oePlanillaPilotoDet
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oePlanillaPilotoDet As e_PlanillaPilotoDet) As List(Of e_PlanillaPilotoDet)
        Try
            Dim ldPlanillaPilotoDet As New List(Of e_PlanillaPilotoDet)
            Dim ds As DataSet
            With oePlanillaPilotoDet
                ds = sqlhelper.ExecuteDataset("PER.Isp_PlanillaPilotoDetalle_Listar", "" _
                        , .Id _
                        , .IdPlanillaPiloto)
            End With
            oePlanillaPilotoDet = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oePlanillaPilotoDet = Cargar(o_Fila)
                ldPlanillaPilotoDet.Add(oePlanillaPilotoDet)
            Next
            Return ldPlanillaPilotoDet
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oePlanillaPilotoDet As e_PlanillaPilotoDet) As Boolean
        Try
            With oePlanillaPilotoDet
                sqlhelper.ExecuteNonQuery("PER.Isp_PlanillaPilotoDetalle_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdPlanillaPiloto _
                        , .IdTrabajador _
                        , .TipoTrabajador _
                        , .MontoTotal _
                        , .Cuenta _
                        , .Tipo _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
