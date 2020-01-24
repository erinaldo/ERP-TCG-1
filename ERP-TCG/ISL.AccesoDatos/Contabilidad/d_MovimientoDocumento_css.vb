'=====================================================================================================
'=== CAPA : ACCESO A DATOS ===========================================================================
'=====================================================================================================

Imports ERP.EntidadesWCF
Public Class d_MovimientoDocumento_css
    Private SQL As New SqlHelper
    Private DS As New DataSet
    Public Function Obtener(ByVal Item As e_MovimientoDocumento_css) As e_MovimientoDocumento_css
        Try
            Dim ds As DataSet = ExecuteLST(Item)
            If ds.Tables(0).Rows.Count > 0 Then
                Item = Cargar(ds.Tables(0).Rows(0))
            End If
            Return Item
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal item As e_MovimientoDocumento_css) As List(Of e_MovimientoDocumento_css)
        Try
            Dim ldMovimientoDocumento_css As New List(Of e_MovimientoDocumento_css)
            Dim ds As DataSet = ExecuteLST(item)
            item = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    item = Cargar(o_Fila)
                    ldMovimientoDocumento_css.Add(item)
                Next
            End If
            Return ldMovimientoDocumento_css
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal Item As e_MovimientoDocumento_css) As e_MovimientoDocumento_css
        Try
            'Using transScope As New TransactionScope()
            Dim stResultado() As String
            With Item
                stResultado = SQL.ExecuteScalar("[CON].[MovimientoDocumento_IAE]" _
                        , .TipoOperacion _
                        , .PrefijoID _
                        , .Id _
                        , .IdTipoDocumento _
                        , .Serie _
                        , .Numero _
                        , .FechaEmision _
                        , .FechaVencimiento _
                        , .NoGravadas _
                        , .IGV _
                        , .SubTotal _
                        , .Total _
                        , .Saldo _
                        , .IdClienteProveedor _
                        , .Activo _
                        , .IndCompraVenta _
                        , .IdPeriodo _
                        , .IdMoneda _
                        , .TipoCambio _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        , .IdCuentaContable _
                        , .IdEstadoDocumento _
                        , .Operador _
                        , .MacPCLocalCreacion _
                        , .IndServicioMaterial _
                        , .GlosaCtaxCyP _
                        , .CuoMomentaneo _
                        , .UsuarioModifica _
                        , .FechaModificacion _
                        , .CodigoUnicoOperacion _
                        , .IndElectronico _
                        , .IndEnviado _
                        , .IndAnulado _
                        , .IdTipoBien _
                        , .OrdenCompra _
                        , .IndAnexo _
                        , .CodMotivo _
                        , .VentaGratuita _
                        , .Descuento _
                        , .EsAnulado _
                        , .EnviadoEmail _
                        , .EnviadoExterno _
                        , .IndAfectoIVA _
                        , .EstadoElectronico _
                        , .EstadoPago _
                        , .FechaRevision _
                        , .UsuarioRevision _
                        , .EnvioPortal _
                        , .Retencion_Letra _
                        , .Retencion_Saldo _
                        , .IndAnticipo _
                        , .IndAfectaAnticipo _
                        , .Monto_Anticipo
                    ).ToString.Split("_")
                .Id = stResultado(0)
            End With
            'transScope.Complete()
            'End Using
            Return Item
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal Item As e_MovimientoDocumento_css) As Boolean
        Try
            With Item
                SQL.ExecuteNonQuery("[CON].[MovimientoDocumento_IAE]" _
                       , "E" _
                       , "" _
                       , .Id _
                       , .IdTipoDocumento _
                       , .Serie _
                       , .Numero _
                       , .FechaEmision _
                       , .FechaVencimiento _
                       , .NoGravadas _
                       , .IGV _
                       , .SubTotal _
                       , .Total _
                       , .Saldo _
                       , .IdClienteProveedor _
                       , .Activo _
                       , .IndCompraVenta _
                       , .IdPeriodo _
                       , .IdMoneda _
                       , .TipoCambio _
                       , .UsuarioCreacion _
                       , .FechaCreacion _
                       , .IdCuentaContable _
                       , .IdEstadoDocumento _
                       , .Operador _
                       , .MacPCLocalCreacion _
                       , .IndServicioMaterial _
                       , .GlosaCtaxCyP _
                       , .CuoMomentaneo _
                       , .UsuarioModifica _
                       , .FechaModificacion _
                       , .CodigoUnicoOperacion _
                       , .IndElectronico _
                       , .IndEnviado _
                       , .IndAnulado _
                       , .IdTipoBien _
                       , .OrdenCompra _
                       , .IndAnexo _
                       , .CodMotivo _
                       , .VentaGratuita _
                       , .Descuento _
                       , .EsAnulado _
                       , .EnviadoEmail _
                       , .EnviadoExterno _
                       , .IndAfectoIVA _
                       , .EstadoElectronico _
                       , .EstadoPago _
                       , .FechaRevision _
                       , .UsuarioRevision _
                       , .EnvioPortal _
                       , .Retencion_Letra _
                       , .Retencion_Saldo _
                       , .IndAnticipo _
                       , .IndAfectaAnticipo _
                       , .Monto_Anticipo
                   )
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#Region "Operaciones Basicas"

    Private Function Cargar(ByVal o_fila As DataRow) As e_MovimientoDocumento_css
        Try
            Dim Item = New e_MovimientoDocumento_css(
                             o_fila("Id").ToString _
                             , o_fila("IdTipoDocumento").ToString _
                             , o_fila("Serie").ToString _
                             , o_fila("Numero").ToString _
                             , o_fila("FechaEmision").ToString _
                             , o_fila("FechaVencimiento").ToString _
                             , o_fila("NoGravadas").ToString _
                             , o_fila("IGV").ToString _
                             , o_fila("SubTotal").ToString _
                             , o_fila("Total").ToString _
                             , o_fila("Saldo").ToString _
                             , o_fila("IdClienteProveedor").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("IndCompraVenta").ToString _
                             , o_fila("IdPeriodo").ToString _
                             , o_fila("IdMoneda").ToString _
                             , o_fila("TipoCambio").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("IdCuentaContable").ToString _
                             , o_fila("IdEstadoDocumento").ToString _
                             , o_fila("Operador").ToString _
                             , o_fila("MacPCLocalCreacion").ToString _
                             , o_fila("IndServicioMaterial").ToString _
                             , o_fila("GlosaCtaxCyP").ToString _
                             , o_fila("CuoMomentaneo").ToString _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("FechaModificacion").ToString _
                             , o_fila("CodigoUnicoOperacion").ToString _
                             , o_fila("IndElectronico").ToString _
                             , o_fila("IndEnviado").ToString _
                             , o_fila("IndAnulado").ToString _
                             , o_fila("IdTipoBien").ToString _
                             , o_fila("OrdenCompra").ToString _
                             , o_fila("IndAnexo").ToString _
                             , o_fila("CodMotivo").ToString _
                             , o_fila("VentaGratuita").ToString _
                             , o_fila("Descuento").ToString _
                             , o_fila("EsAnulado").ToString _
                             , o_fila("EnviadoEmail").ToString _
                             , o_fila("EnviadoExterno").ToString _
                             , o_fila("IndAfectoIVA").ToString _
                             , o_fila("EstadoElectronico").ToString _
                             , o_fila("EstadoPago").ToString _
                             , o_fila("FechaRevision").ToString _
                             , o_fila("UsuarioRevision").ToString _
                             , o_fila("EnvioPortal").ToString _
                             , o_fila("Retencion_Letra").ToString _
                             , o_fila("Retencion_Saldo").ToString _
                             , o_fila("IndAnticipo").ToString _
                             , o_fila("IndAfectaAnticipo").ToString _
                             , o_fila("Monto_Anticipo").ToString
            )
            Return Item
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Private Function ExecuteLST(ByVal Item As e_MovimientoDocumento_css) As DataSet
        Try
            Dim ds As DataSet
            With Item
                ds = SQL.ExecuteDataset("[CON].[MovimientoDocumento_LST]" _
                        , .TipoOperacion _
                        , "" _
                        , "" _
                        , .Id _
                        , .IdTipoDocumento _
                        , .Serie _
                        , .Numero _
                        , .FechaEmision _
                        , .FechaVencimiento _
                        , .NoGravadas _
                        , .IGV _
                        , .SubTotal _
                        , .Total _
                        , .Saldo _
                        , .IdClienteProveedor _
                        , .Activo _
                        , .IndCompraVenta _
                        , .IdPeriodo _
                        , .IdMoneda _
                        , .TipoCambio _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        , .IdCuentaContable _
                        , .IdEstadoDocumento _
                        , .Operador _
                        , .MacPCLocalCreacion _
                        , .IndServicioMaterial _
                        , .GlosaCtaxCyP _
                        , .CuoMomentaneo _
                        , .UsuarioModifica _
                        , .FechaModificacion _
                        , .CodigoUnicoOperacion _
                        , .IndElectronico _
                        , .IndEnviado _
                        , .IndAnulado _
                        , .IdTipoBien _
                        , .OrdenCompra _
                        , .IndAnexo _
                        , .CodMotivo _
                        , .VentaGratuita _
                        , .Descuento _
                        , .EsAnulado _
                        , .EnviadoEmail _
                        , .EnviadoExterno _
                        , .IndAfectoIVA _
                        , .EstadoElectronico _
                        , .EstadoPago _
                        , .FechaRevision _
                        , .UsuarioRevision _
                        , .EnvioPortal _
                        , .Retencion_Letra _
                        , .Retencion_Saldo _
                        , .IndAnticipo _
                        , .IndAfectaAnticipo _
                        , .Monto_Anticipo
                        )
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

End Class
