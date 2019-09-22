Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_ChequeEmitido
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_ChequeEmitido
        Try
            Dim oeChequeEmitido = New e_ChequeEmitido( _
                             o_fila("Id").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("IdProveedor").ToString _
                             , o_fila("IdCuentaBancaria").ToString _
                             , o_fila("IdCuentaCorriente").ToString _
                             , o_fila("NroCheque").ToString _
                             , o_fila("Detalle").ToString _
                             , o_fila("FechaCobro").ToString _
                             , o_fila("Importe").ToString _
                             , o_fila("Saldo").ToString _
                             , o_fila("IdConcepto").ToString _
                             , o_fila("Concepto").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Moneda").ToString _
                             , o_fila("Banco").ToString _
                             , o_fila("CuentaBancaria").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Proveedor").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("Centro").ToString)
            Return oeChequeEmitido
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeChequeEmitido As e_ChequeEmitido) As e_ChequeEmitido
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_ChequeEmitido_Listar", oeChequeEmitido.TipoOperacion, oeChequeEmitido.Id)
            If ds.Tables.Count > 0 Then
                oeChequeEmitido = Cargar(ds.Tables(0).Rows(0))
                Return oeChequeEmitido
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeChequeEmitido As e_ChequeEmitido) As List(Of e_ChequeEmitido)
        Try
            Dim ldChequeEmitido As New List(Of e_ChequeEmitido)
            Dim ds As DataSet
            With oeChequeEmitido
                ds = sqlhelper.ExecuteDataset("TES.Isp_ChequeEmitido_Listar", .TipoOperacion _
                        , .Id, .IdEstado, .Fecha, .FechaCreacion, .IdCuentaCorriente _
                        , .IdCentro, .IdCuentaBancaria)
            End With
            oeChequeEmitido = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeChequeEmitido = Cargar(o_Fila)
                    ldChequeEmitido.Add(oeChequeEmitido)
                Next
                Return ldChequeEmitido
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeChequeEmitido As e_ChequeEmitido) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim id As String = ""
            Dim odMovimientoDocumento As New d_MovimientoDocumento
            Dim odChequeDocumento As New d_ChequeDocumento
            Using TransScope As New TransactionScope()
                With oeChequeEmitido
                    id = sqlhelper.ExecuteScalar("TES.Isp_ChequeEmitido_IAE", .TipoOperacion, .PrefijoID,
                            .Id, .IdTrabajador, .IdProveedor, .IdCuentaBancaria, .IdCuentaCorriente,
                            .NroCheque, .Detalle, .FechaCobro, .Importe, .Saldo, .IdConcepto, .IdEstado, .FechaCreacion, .UsuarioCreacion,
                            .Activo, .IdCentro, .Fecha)
                    .Id = id
                    If .loChequeDocumento.Count > 0 Then
                        For Each oe As e_ChequeDocumento In .loChequeDocumento
                            If .TipoOperacion = "I" Or .TipoOperacion = "A" Or .TipoOperacion = "E" Then
                                oe.TipoOperacion = .TipoOperacion
                                oe.IdChequeEmitido = .Id
                                oe.UsuarioCreacion = .UsuarioCreacion
                                odChequeDocumento.Guardar(oe)
                            End If
                            If .TipoOperacion = "C" Then
                                Dim oeMovDoc As New e_MovimientoDocumento
                                oeMovDoc.Id = oe.IdMovimientoDocumento
                                oeMovDoc.TipoOperacion = "CAM"
                                oeMovDoc.Total = oe.Importe
                                odMovimientoDocumento.GuardarGastoOperacion(oeMovDoc)
                            End If
                        Next
                    End If
                End With
                TransScope.Complete()
            End Using 
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeChequeEmitido As e_ChequeEmitido) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_ChequeEmitido_IAE", "E", _
             "", oeChequeEmitido.Id, oeChequeEmitido.IdTrabajador)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardaMasivo(DTAsiento As DataTable, DTAsiMov As DataTable, DTMovCajBan As DataTable, DTAsiMovMovDoc As DataTable, DTCtaCyP As Data.DataTable) As Boolean
        If DTAsiento.Rows.Count > 0 Then sqlhelper.InsertarMasivo("CON.Asiento", DTAsiento, False)
        If DTAsiMov.Rows.Count > 0 Then sqlhelper.InsertarMasivo("CON.AsientoMovimiento", DTAsiMov, False)
        If DTMovCajBan.Rows.Count > 0 Then sqlhelper.InsertarMasivo("CON.MovimientoCajaBanco", DTMovCajBan, False)
        If DTCtaCyP.Rows.Count > 0 Then sqlhelper.InsertarMasivo("TES.CuentaxCyP", DTCtaCyP, False)
        If DTAsiMovMovDoc.Rows.Count > 0 Then sqlhelper.InsertarMasivo("CON.AsientoMov_MovDoc", DTAsiMovMovDoc, False)
        Return True
    End Function

End Class
