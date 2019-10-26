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

Public Class d_DetallePlanillaPiloto

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_DetallePlanillaPiloto
        Try
            Dim oe As New e_DetallePlanillaPiloto(o_fila("Viaje").ToString, o_fila("Tipo").ToString, _
                                                  o_fila("Trabajador").ToString, o_fila("Tracto").ToString, _
                                                  o_fila("FechaViaje").ToString, o_fila("Ruta").ToString, _
                                                  o_fila("Puesto").ToString, o_fila("Monto").ToString, o_fila("Cuenta").ToString)
            Return oe
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oe As e_DetallePlanillaPiloto) As List(Of e_DetallePlanillaPiloto)
        Try
            Dim ldDetallePlanilla As New List(Of e_DetallePlanillaPiloto)
            Dim ds As DataSet
            With oe
                ds = sqlhelper.ExecuteDataset("[PER].[Isp_PlanillaViaje_Listar]", "2", Date.Parse("01/01/1901"), Date.Parse("01/01/1901"), .IdPlanilla, .IdTrabajador)
            End With
            oe = New e_DetallePlanillaPiloto
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oe = Cargar(o_Fila)
                ldDetallePlanilla.Add(oe)
            Next
            Return ldDetallePlanilla
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
