
Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_CuentaxCyP
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_CuentaxCyP
        Try
            Dim oeCuentaxCyP = New e_CuentaxCyP( _
                             o_fila("Id").ToString _
                             , o_fila("IdMovimientoCajaBanco").ToString _
                             , o_fila("IdMovimientoDocumento").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("MontoMN").ToString _
                             , o_fila("MontoMe").ToString _
                                , o_fila("idCuentaBancaria").ToString _
                            , o_fila("idFlujoCaja").ToString _
                            , o_fila("IdAsiento").ToString _
                            , o_fila("FlujoCaja").ToString _
                            , o_fila("DocumentoCancelacion").ToString _
                            , o_fila("TipoCodigoObligacion").ToString _
                            , o_fila("NroBoucher").ToString _
                            , o_fila("MedioPago").ToString _
                            , o_fila("Glosa").ToString _
                            , o_fila("TipoAsiento").ToString _
                            , o_fila("NroAsiento").ToString _
                            , o_fila("Periodo").ToString _
                            , o_fila("IdCuentaCorriente").ToString _
                            , o_fila("IndCargoAbono").ToString _
                            , o_fila("IdMoneda").ToString _
                            , o_fila("TipoCambio").ToString _
                            , o_fila("UsuarioModifica").ToString _
                            )
            Return oeCuentaxCyP
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCuentaxCyP As e_CuentaxCyP) As e_CuentaxCyP

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.ISP_CuentaxCyP_Listar", "", oeCuentaxCyP.Id)
            If ds.Tables.Count > 0 Then
                oeCuentaxCyP = Cargar(ds.Tables(0).Rows(0))
                Return oeCuentaxCyP
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCuentaxCyP As e_CuentaxCyP) As List(Of e_CuentaxCyP)
        Try
            Dim ldCuentaxCyP As New List(Of e_CuentaxCyP)
            Dim ds As DataSet
            With oeCuentaxCyP
                ds = sqlhelper.ExecuteDataset("TES.ISP_CuentaxCyP_Listar", .TipoOperacion _
                        , .Id _
                        , .IdMovimientoCajaBanco _
                        , .IdMovimientoDocumento _
                        , .Fecha _
                        , .MontoMN _
                        , .MontoMe _
                        , .Activo _
                        , .IdAsientoElimina _
                        )
            End With
            oeCuentaxCyP = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCuentaxCyP = Cargar(o_Fila)
                    ldCuentaxCyP.Add(oeCuentaxCyP)
                Next
                Return ldCuentaxCyP
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByRef oeCuentaxCyP As e_CuentaxCyP) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado() As String
            With oeCuentaxCyP
                stResultado = sqlhelper.ExecuteScalar("TES.ISP_CuentaxCyP_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .IdMovimientoCajaBanco _
                        , .IdMovimientoDocumento _
                        , .Fecha _
                        , .MontoMN _
                        , .MontoMe _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .MacPCLocalCreacion _
                        , .IdCuentaCorriente _
                        , .IndCargoAbono _
                        , .IdMoneda _
                        , .TipoCambio _
                        , .UsuarioModifica _
                        ).ToString.Split("_")
                oeCuentaxCyP.Id = stResultado(0)
                If oeCuentaxCyP.MovDocCta.TipoOperacion = "I" Then
                    Dim odMovcDocCta As New d_MovimientoDocumentoCuenta
                    oeCuentaxCyP.MovDocCta.idCuentaxCyP = stResultado(0)
                    odMovcDocCta.Guardar(oeCuentaxCyP.MovDocCta)
                End If

                '---------para el caso de fec que necesita que inserte el id cuentaxCyP---------
                If Not oeCuentaxCyP.ObligacionDocumento Is Nothing Then
                    With oeCuentaxCyP.ObligacionDocumento
                        If .TipoOperacion = "I" Then
                            Dim odObligacionCta As New d_ObligacionDocumento
                            .IdCuentaxCyP = stResultado(0)
                            odObligacionCta.Guardar(oeCuentaxCyP.ObligacionDocumento)
                        End If
                    End With
                End If
                If Not oeCuentaxCyP.leObligacionDocumento Is Nothing Then
                    If oeCuentaxCyP.leObligacionDocumento.Count > 0 Then
                        For Each o_o As e_ObligacionDocumento In oeCuentaxCyP.leObligacionDocumento
                            If o_o.TipoOperacion = "I" Then
                                Dim odObligacionCta2 As New d_ObligacionDocumento
                                o_o.IdCuentaxCyP = stResultado(0)
                                odObligacionCta2.Guardar(o_o)
                            End If
                        Next

                    End If
                End If
                '(SOLO PARA PAGOS,COBROS y CANCELACIONES DEL DOCUMENTO),Provision se encuentra en asiento
                If Not .AsMov_MovDoc Is Nothing Then 'cuando documento esta generado y debe generarse relacion
                    If .AsMov_MovDoc.TipoOperacion <> "" Then 'relacion detalle de asiento y movimiento documento
                        Dim odAsM As New d_AsientoMov_MovDoc
                        '.AsMov_MovDoc.IdAsientoMovimiento = stResultado(0)
                        .AsMov_MovDoc.IdAsientoMovimiento = ._IdAsientoMovimiento
                        .AsMov_MovDoc.IdCuentaxCyP = oeCuentaxCyP.Id
                        If .AsMov_MovDoc.TipoOperacion = "E" Then
                            odAsM.Eliminar(.AsMov_MovDoc)
                        Else
                            odAsM.Guardar(.AsMov_MovDoc)
                        End If
                    End If
                End If
                If Not .CuentaxPDocumentoRetencion Is Nothing Then
                    .CuentaxPDocumentoRetencion.IdCuentaxCyP = stResultado(0)
                    Dim odCuentaxpCompraRet As New d_CuentaxPDocumentoRetencion
                    odCuentaxpCompraRet.Guardar(.CuentaxPDocumentoRetencion)
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarCuentaCyP_AsiMovMovDoc(ByRef oeCuentaxCyP As e_CuentaxCyP) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado() As String
            With oeCuentaxCyP
                stResultado = sqlhelper.ExecuteScalar("TES.ISP_CuentaxCyP_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .IdMovimientoCajaBanco _
                        , .IdMovimientoDocumento _
                        , .Fecha _
                        , .MontoMN _
                        , .MontoMe _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .MacPCLocalCreacion _
                        , .IdCuentaCorriente _
                        , .IndCargoAbono _
                        , .IdMoneda _
                        , .TipoCambio _
                        , .UsuarioModifica _
                        ).ToString.Split("_")
                oeCuentaxCyP.Id = stResultado(0)
                ' Guardar Asiento Movimiento Movimiento Documento
                If (.AsMov_MovDoc IsNot Nothing) AndAlso .AsMov_MovDoc.TipoOperacion = "I" Then
                    Dim odAsM As New d_AsientoMov_MovDoc
                    .AsMov_MovDoc.IdAsientoMovimiento = ._IdAsientoMovimiento
                    .AsMov_MovDoc.IdCuentaxCyP = oeCuentaxCyP.Id
                    odAsM.Guardar(.AsMov_MovDoc)
                End If
                ' Guardar Obligacion Fin Movimiento Documento
                If (.ObligacionDocumento IsNot Nothing) AndAlso .ObligacionDocumento.TipoOperacion = "I" Then
                    Dim odObliFinMovDoc As New d_ObligacionDocumento
                    .ObligacionDocumento.IdCuentaxCyP = oeCuentaxCyP.Id
                    odObliFinMovDoc.Guardar(.ObligacionDocumento)
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeCuentaxCyP As e_CuentaxCyP) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.ISP_CuentaxCyP_IAE", "E", _
             "", oeCuentaxCyP.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ReporteCuentasXCobrar(ByVal TipoOper As String, ByVal IdClienteProveedor As String) As DataTable
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.ISP_ReporteCuentasXCobrar", IdClienteProveedor, TipoOper)
            Return ds.Tables(0)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "TES.CuentaxCyP", PrefijoID
                                  )
            Return IIf(stResultado Is Nothing, PrefijoID & "000000000001", stResultado)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class