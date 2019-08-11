Imports ISL.EntidadesWCF
Imports System.Data.SqlClient
Imports System.Configuration
Public Class d_ProgramacionPago
    Private sqlhelper As New SqlHelper
    Private oeProgramacionPago As e_ProgramacionPago
    Private d_DatosConfiguracion As New d_DatosConfiguracion

    Public Function Cargar(ByVal o_fila As DataRow) As e_ProgramacionPago
        Try
            Dim oeProgramacionPago = New e_ProgramacionPago( _
                         o_fila("Id").ToString, o_fila("IdEstado").ToString, o_fila("NroLote").ToString _
                        , o_fila("IdUsuario").ToString, o_fila("MontoOriginal").ToString _
                        , o_fila("Retencion").ToString, o_fila("Detraccion").ToString, o_fila("Montopago"), o_fila("Observaciones").ToString _
                        , o_fila("FechaCrea").ToString, o_fila("FechaModifica").ToString _
                        , o_fila("Moneda").ToString)
            Return oeProgramacionPago
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerLote(ByVal oeProgramacionPago As e_ProgramacionPago) As e_ProgramacionPago
        Try
            Dim ds As New DataSet
            With oeProgramacionPago
                ds = sqlhelper.ExecuteDataset("[TES].[sp_ProgramacionPago_LST]", .TipoOperacion)
            End With
            Dim oeProgrPago As New e_ProgramacionPago
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeProgrPago = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeProgrPago
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeProgramacionPago As e_ProgramacionPago) As Boolean
        Try
            Dim stResultado() As String
            Dim d_MovDoc As d_MovimientoDocumento
            Dim d_DetProgPago As d_DetalleProgramacionPago
            With oeProgramacionPago
                stResultado = sqlhelper.ExecuteScalar("[TES].[sp_ProgramacionPago_IAE]", .TipoOperacion, _
                         d_DatosConfiguracion.PrefijoID, _
                         .Id _
                         , .IdEstado _
                         , .NroLote _
                         , .IdUsuario _
                         , .MontoOriginal _
                         , .Retencion _
                         , .Detraccion _
                         , .MontoPago _
                         , .Observaciones _
                         , .Moneda _
                         ).ToString.Split("_")
                Dim id As String = stResultado(0)
                If .TipoOperacion = "I" Or .TipoOperacion = "A" Then
                    For Each Fm As e_MovimientoDocumento In .lst_MovimientoDocumento.ToList
                        d_MovDoc = New d_MovimientoDocumento
                        Dim e_MovDoc As New e_MovimientoDocumento
                        e_MovDoc = Fm
                        d_MovDoc.ActualizarEstadoPago(e_MovDoc)
                    Next
                    For Each Fd As e_DetalleProgramacionPago In .lst_DetalleProgPago.ToList
                        d_DetProgPago = New d_DetalleProgramacionPago
                        Dim e_DetProgPago As New e_DetalleProgramacionPago
                        e_DetProgPago = Fd
                        If .TipoOperacion = "I" Then e_DetProgPago.IdProgramacionPago = id
                        d_DetProgPago.Guardar(e_DetProgPago)
                    Next
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function ListarProgramacionPagos(oe_ProgramacionPago As e_ProgramacionPago) As DataTable
        Try
            Dim ds As DataSet
            With oe_ProgramacionPago
                ds = sqlhelper.ExecuteDataset("TES.sp_ProgramacionPago_LST", .TipoOperacion, .Id, .NroLote, .IdEstado, .FechaCrea, .FechaModifica)
            End With
            Return ds.Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
