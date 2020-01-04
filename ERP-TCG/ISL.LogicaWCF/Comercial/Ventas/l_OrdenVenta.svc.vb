Imports ERP.EntidadesWCF
Imports ERP.AccesoDatos
Imports System.Transactions

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_OrdenVenta" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_OrdenVenta.svc o l_OrdenVenta.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class l_OrdenVenta
    Implements Il_OrdenVenta

    Private odOrdenComercial As New d_OrdenVenta
    Private olDocumento As New l_MovimientoDocumento

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

    Public Function Guardar(ByVal oeOrdenComercial As e_OrdenVenta) As Boolean Implements Il_OrdenVenta.Guardar
        Try
            Dim bol_guardado As Boolean = False
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
            Dim bol_guardado As Boolean = False
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
        Dim bol_guardado As Boolean = False
        Try
            bol_guardado = odOrdenComercial.Eliminar(oeOrdenComercial)
        Catch ex As Exception
            Throw ex
        End Try
        Return bol_guardado
    End Function

End Class
