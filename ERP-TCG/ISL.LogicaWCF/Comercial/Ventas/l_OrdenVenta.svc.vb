Imports ERP.EntidadesWCF
Imports ERP.AccesoDatos
Imports System.Transactions

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_OrdenVenta" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_OrdenVenta.svc o l_OrdenVenta.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class l_OrdenVenta
    Implements Il_OrdenVenta

    Private odOrdenComercial As New d_OrdenVenta
    Private olDocumento As New l_MovimientoDocumento

    Dim odOrden As d_Orden
    Dim OrdenIngreso As e_Orden
    Dim odDetOrden As d_OrdenMaterial
    Dim lstDetOrden As List(Of e_OrdenMaterial)
    Dim bol_guardado As Boolean = False

    Public Function Obtener(ByVal oeOrdenComercial As e_OrdenVenta) As e_OrdenVenta Implements Il_OrdenVenta.Obtener
        Try
            oeOrdenComercial = odOrdenComercial.Obtener(oeOrdenComercial)
            Return oeOrdenComercial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeOrdenComercial As e_OrdenVenta) As List(Of e_OrdenVenta) Implements Il_OrdenVenta.Listar
        Try
            Dim lstOrdenComercial As New List(Of e_OrdenVenta)
            lstOrdenComercial = odOrdenComercial.Listar(oeOrdenComercial)
            Return lstOrdenComercial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDataset(ByVal oeOrdenComercial As e_OrdenVenta) As Data.DataSet Implements Il_OrdenVenta.ListarDataset
        Try
            Return odOrdenComercial.ExecuteLST(oeOrdenComercial)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Anular(ByVal oeOrdenComercial As e_OrdenVenta) As Boolean Implements Il_OrdenVenta.Anular
        Try
            Using TransScope As New TransactionScope()
                Dim lst_OrdenSalida As List(Of e_ReferenciaAsociada)

                If odOrdenComercial.Guardar(oeOrdenComercial) Then
                    Dim odRefAsoc As New d_ReferenciaAsociada
                    lst_OrdenSalida = odRefAsoc.Listar(New e_ReferenciaAsociada With {.TipoOperacion = "S", .IdTablaPrincipal = oeOrdenComercial.Id})
                    odOrden = New d_Orden
                    odDetOrden = New d_OrdenMaterial
                    For Each orden In lst_OrdenSalida
                        GenerarOI(oeOrdenComercial, orden.IdTablaAsociada)
                    Next
                End If
                TransScope.Complete()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        Return True
    End Function

    Private Sub GenerarOI(OrdenComercial As e_OrdenVenta, IdOrdenSalida As String)
        Try
            '1CH000000040
            OrdenIngreso = New e_Orden
            With OrdenIngreso
                .lstOrdenMaterial = New List(Of e_OrdenMaterial)
                .Activo = True
                .IdTipoOrden = "1CH000000001"
                .IdMovimientoInventario = "1CH000000040"
                .IdMoneda = OrdenComercial.IdMoneda
                .IdProveedor = OrdenComercial.IdEmpresa
                .Glosa = "EXTORNO DE VENTA " & OrdenComercial.OrdenComercial
                .FechaOrden = Date.Now
                .TipoOperacion = "I"
                .IdSubAlmacenDestino = ""
                .IdSubAlmacenOrigen = ""
                .TipoReferencia = "ORDEN VENTA"
                .UsuarioCreacion = OrdenComercial.UsuarioCrea
                '.TipoReferencia = "COMPRA" 'Enviamos el Id de la Orden de compra para guardarlo a la Tabla Orden_Orden y asi asociarla a la Orden de Ingreso.
                .Referencia = OrdenComercial.OrdenComercial
                .PrefijoID = OrdenComercial.PrefijoID  '@0001
            End With
            lstDetOrden = odDetOrden.Listar(New e_OrdenMaterial With {.IdOrden = IdOrdenSalida})
            OrdenIngreso.lstOrdenMaterial = lstDetOrden
            For Each detalle In OrdenIngreso.lstOrdenMaterial
                detalle.PrefijoID = OrdenComercial.PrefijoID
                detalle.IdOrden = ""
                detalle.TipoOperacion = "I"
                detalle.Id = String.Empty

            Next
            odOrden.Guardar(OrdenIngreso)
            'Dim oeOrdenSalida As e_Orden
            'oeOrdenSalida = odOrden.Obtener(New e_Orden With {.Id = IdOrdenSalida})

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function Guardar(ByVal oeOrdenComercial As e_OrdenVenta) As Boolean Implements Il_OrdenVenta.Guardar
        Try

            Using TransScope As New TransactionScope()
                If Validar(oeOrdenComercial) Then
                    bol_guardado = odOrdenComercial.Guardar(oeOrdenComercial)
                    If oeOrdenComercial.oeDocumento.TipoOperacion <> "" Then
                        'oeOrdenComercial.oeDocumento.idOrdenComercial = oeOrdenComercial.Id
                        'If oeOrdenComercial.oeDocumento.Serie.StartsWith("B") OrElse oeOrdenComercial.oeDocumento.Serie.StartsWith("F") Then
                        '    oeOrdenComercial.oeDocumento.IndElectronico = True
                        'End If
                        For Each oe In oeOrdenComercial.oeDocumento.lo_OrdenDocumento
                            oe.IdOrden = oeOrdenComercial.Id
                        Next
                        olDocumento.Guardar(oeOrdenComercial.oeDocumento)
                    End If
                End If
                TransScope.Complete()
            End Using
            Return bol_guardado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar_VentaRapida(ByVal OrdenVenta As e_OrdenVenta) As e_OrdenVenta Implements Il_OrdenVenta.Guardar_VentaRapida
        Try
            Dim dORdenDocumento As New d_Orden_Documento
            Using TransScope As New TransactionScope()
                If Validar(OrdenVenta) Then
                    OrdenVenta = odOrdenComercial.Guardar_VentaRapida(OrdenVenta)
                End If
                TransScope.Complete()
            End Using
            Return OrdenVenta
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeOrdenComercial As e_OrdenVenta) As Boolean Implements Il_OrdenVenta.Eliminar
        Try
            Return odOrdenComercial.Eliminar(oeOrdenComercial)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Validar(ByVal oeOrdenComercial As e_OrdenVenta) As Boolean
        Try
            With oeOrdenComercial
                If .Total = 0 Then Throw New Exception("Total no Puede ser 0. Verificar")
                If .IdEmpresa = "" Then Throw New Exception("Seleccione Razon Social")
                If .IdMoneda = "" Then Throw New Exception("Seleccione Moneda")
                If .IdTipoPago = "" Then Throw New Exception("Seleccione Tipo Pago")
                If .TipoOperacion = "A" Or .TipoOperacion = "I" Then
                    If ValidarDetalles(oeOrdenComercial) Then
                        'If .TipoExistencia = 1 Then
                        '    If .lstOrdenComercialMaterial.Count = 0 Then Throw New Exception("Ingrese Detalles")
                        '    If .lstOrdenComercialMaterial.Where(Function(i) i.Cantidad = 0).ToList.Count > 0 Then Throw New Exception("Cantidad no Puede ser 0.")
                        '    If .lstOrdenComercialMaterial.Where(Function(i) i.CostoUnitario = 0).ToList.Count > 0 Then Throw New Exception("Costo no Puede ser 0.")
                        'Else
                        '    If .lstOrdenComercialServicio.Count = 0 Then Throw New Exception("Ingrese Detalles")
                        '    If .lstOrdenComercialServicio.Where(Function(i) i.Cantidad = 0).ToList.Count > 0 Then Throw New Exception("Cantidad no Puede ser 0.")
                        '    If .lstOrdenComercialServicio.Where(Function(i) i.CostoUnitario = 0).ToList.Count > 0 Then Throw New Exception("Costo no Puede ser 0.")
                        'End If
                    End If
                End If
                'If .TipoOperacion = "G" Or .TipoOperacion = "X" Then
                '    If .lstOrdenComercialMaterial.Sum(Function(i) i.Cantidad) <> .lstOrdenComercialMaterial.Sum(Function(i) i.CantidadPendiente) Then
                '        Throw New Exception("Orden ya ha sido atendida")
                '    End If
                'End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidarDetalles(oeOrdenComercial As e_OrdenVenta) As Boolean
        Try
            If oeOrdenComercial.Impuesto > 0 Then
                'For Each oe As e_OrdenVentaMaterial In oeOrdenComercial.lstOrdenComercialMaterial
                '    If oe.IndImpuesto = False Then Throw New Exception("No puede Haber Materiales No Afectos al IGV")
                'Next
                'For Each oe As e_OrdenVentaServicio In oeOrdenComercial.lstOrdenComercialServicio
                '    If oe.IndImpuesto = False Then Throw New Exception("No puede Haber Servicios No Afectos al IGV")
                'Next
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EliminarExtornar(oeOrdenComercial As e_OrdenVenta) As Boolean Implements Il_OrdenVenta.EliminarExtornar
        Try
            bol_guardado = odOrdenComercial.Eliminar(oeOrdenComercial)
        Catch ex As Exception
            Throw ex
        End Try
        Return bol_guardado
    End Function

End Class
