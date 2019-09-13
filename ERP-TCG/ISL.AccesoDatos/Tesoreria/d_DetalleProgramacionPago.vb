Imports ISL.EntidadesWCF
Imports System.Data.SqlClient
Imports System.Configuration
Public Class d_DetalleProgramacionPago
    Private sqlhelper As New SqlHelper
    ' Private oeDetalleProgramacionPago As e_DetalleProgramacionPago
    Private d_DatosConfiguracion As New d_DatosConfiguracion
    Public Function Cargar(ByVal o_fila As DataRow) As e_DetalleProgramacionPago
        Try
            Dim oeDetalleProgramacionPago = New e_DetalleProgramacionPago( _
                         o_fila("Id").ToString, o_fila("IdEstado").ToString, o_fila("IdProgramacionPago").ToString _
                        , o_fila("IdUsuario").ToString, o_fila("MontoOriginal").ToString _
                        , o_fila("Afectacion").ToString, o_fila("PorcAfect").ToString, _
                        o_fila("Montopago"), o_fila("TipoOrden").ToString, _
                        o_fila("TipoAfect").ToString, o_fila("IdMovimientoDocumento").ToString _
                        , o_fila("IdTipoGasto").ToString, o_fila("CtaBancaria").ToString, o_fila("NroOperacion").ToString _
                        , o_fila("FlujoCaja").ToString, o_fila("CtaContable").ToString, o_fila("MedioPago").ToString, o_fila("FechaPago").ToString)
            Return oeDetalleProgramacionPago
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleProgramacionPago As e_DetalleProgramacionPago) As DataTable
        Try
            Dim ds As New DataSet
            With oeDetalleProgramacionPago
                ds = sqlhelper.ExecuteDataset("[TES].[sp_DetalleProgramacionPago_LST]", .TipoOperacion, .Id, .IdProgramacionPago, .IdEstado, .IdMovimientoDocumento)
            End With
            ' oeDetalleProgramacionPago = New e_DetalleProgramacionPago
            'If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
            '    oeDetalleProgramacionPago = Cargar(ds.Tables(0).Rows(0))
            'End If
            Return ds.Tables(0)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleProgramacionPago As e_DetalleProgramacionPago) As Boolean
        Try

            Dim stResultado() As String
            With oeDetalleProgramacionPago
                stResultado = sqlhelper.ExecuteScalar("[TES].[sp_DetalleProgramacionPago_IAE]", .TipoOperacion, _
                        .PrefijoID, _
                        .Id _
                        , .IdMovimientoDocumento _
                        , .IdEstado _
                        , .IdProgramacionPago _
                        , .IdUsuario _
                        , .MontoOriginal _
                        , .Afectacion _
                        , .MontoPago _
                        , .PorcAfect _
                        , .TipoOrden _
                        , .TipoAfect _
                        , .IdTipoGasto _
                         , .CtaBancaria _
                         , .NroOperacion _
                          , .FlujoGasto _
                         , .CtaContable _
                         , .MedioPago _
                         , .FechaPago _
                        ).ToString.Split("_")
                .Id = stResultado(0)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try

    End Function
End Class
