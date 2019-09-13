Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Movimiento_Administrativo

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Movimiento_Administrativo 
        Try
            Dim oeMovimiento_Administrativo = New e_Movimiento_Administrativo( _
                             o_fila("Id").ToString _
                             , o_fila("Fecha") _
                             , o_fila("IdCuentaCorrienteOrigen").ToString _
                             , o_fila("CuentaOrigen").ToString _
                             , o_fila("IdCuentaCorrienteDestino").ToString _
                             , o_fila("CuentaDestino").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("Ingreso") _
                             , o_fila("Egreso") _
                             , o_fila("Saldo") _
                             , o_fila("Glosa").ToString _
                             , o_fila("Voucher").ToString _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Descuento").ToString _
                             , o_fila("TipoMovimiento").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Activo") _
                             , o_fila("TipoTransa") _
                             , o_fila("IngresoTotal") _
                             , o_fila("EgresoTotal") _
                             , o_fila("SaldoTotal") _
                             , o_fila("GastosREndidos") _
                             , o_fila("IndCerrado"))
            Return oeMovimiento_Administrativo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMovimiento_Administrativo As e_Movimiento_Administrativo) As e_Movimiento_Administrativo

        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ds As DataSet
            With oeMovimiento_Administrativo
                ds = sqlhelper.ExecuteDataset("TES.Isp_Movimiento_Administrativo_Listar", .TipoOperacion, _
                                             .Id, .IdCuentaCorrienteD, .IdTrabajadorCuentaCorriente, .TipoTransa, .FechaDesde, _
                                             .FechaHasta, .Activo, "")
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeMovimiento_Administrativo = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeMovimiento_Administrativo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMovimiento_Administrativo As e_Movimiento_Administrativo) As List(Of e_Movimiento_Administrativo)
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ldMovimiento_Administrativo As New List(Of e_Movimiento_Administrativo)
            Dim ds As DataSet
            With oeMovimiento_Administrativo
                ds = sqlhelper.ExecuteDataset("TES.Isp_Movimiento_Administrativo_Listar", .TipoOperacion, _
                                              .Id, .IdCuentaCorrienteD, .IdTrabajadorCuentaCorriente, .TipoTransa, .FechaDesde, _
                                              .FechaHasta, .Activo, .IdCaja)
            End With
            oeMovimiento_Administrativo = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMovimiento_Administrativo = Cargar(o_Fila)
                    ldMovimiento_Administrativo.Add(oeMovimiento_Administrativo)
                Next
            End If
            Return ldMovimiento_Administrativo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMovimiento_Administrativo As e_Movimiento_Administrativo) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeMovimiento_Administrativo
                sqlhelper.ExecuteNonQuery("TES.Isp_Movimiento_Administrativo_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeMovimiento_Administrativo As e_Movimiento_Administrativo) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_Movimiento_Administrativo_IAE", "E", _
             "", oeMovimiento_Administrativo.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
