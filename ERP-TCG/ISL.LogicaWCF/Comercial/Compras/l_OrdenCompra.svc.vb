Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_OrdenCompra
    Implements Il_OrdenCompra

    Dim odOrdenCompra As New d_OrdenCompra
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeOrden As EntidadesWCF.e_OrdenCompra) As Boolean Implements Il_OrdenCompra.Eliminar
        Try
            Return odOrdenCompra.Eliminar(oeOrden)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeOrden As EntidadesWCF.e_OrdenCompra) As Boolean Implements Il_OrdenCompra.Guardar
        Try
            If Validar(oeOrden) Then
                Return odOrdenCompra.Guardar(oeOrden)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar1(ByVal oeOrden As EntidadesWCF.e_OrdenCompra) As Boolean Implements Il_OrdenCompra.Guardar1
        Try
            Return odOrdenCompra.Guardar(oeOrden)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub GuardarLista(ByVal llOrden As System.Collections.Generic.List(Of EntidadesWCF.e_OrdenCompra), ByVal tipoOperacion As String, ByVal IdTrabajador As String, ByVal IdUsuario As String) Implements Il_OrdenCompra.GuardarLista
        Try
            For Each oeOrdenCompra As e_OrdenCompra In llOrden.Where(Function(item) item.IndicadorAprobacion)
                oeOrdenCompra.TipoOperacion = tipoOperacion
                oeOrdenCompra.IdTrabajador = IdTrabajador
                oeOrdenCompra.UsuarioCreacion = IdUsuario
                oeOrdenCompra.OrdenAprobacion.IndBloqueo = 1
                oeOrdenCompra.OrdenAprobacion.Id = ""
                oeOrdenCompra.OrdenAprobacion.IdOrden = oeOrdenCompra.Id
                oeOrdenCompra.OrdenAprobacion.FechaAprobacion = Date.Now
                oeOrdenCompra.OrdenAprobacion.IndAprobacion = 1
                oeOrdenCompra.OrdenAprobacion.Activo = 1
                oeOrdenCompra.OrdenAprobacion.IdTrabajador = IdTrabajador
                oeOrdenCompra.OrdenAprobacion.UsuarioCreacion = IdUsuario
                odOrdenCompra.Guardar(oeOrdenCompra)
            Next
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function Listar(ByVal oeOrden As EntidadesWCF.e_OrdenCompra, ByVal oeFecha As EntidadesWCF.e_Fechas) As System.Collections.Generic.List(Of EntidadesWCF.e_OrdenCompra) Implements Il_OrdenCompra.Listar
        Try
            Return odOrdenCompra.Listar(oeOrden, oeFecha)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeOrden As EntidadesWCF.e_OrdenCompra) As EntidadesWCF.e_OrdenCompra Implements Il_OrdenCompra.Obtener
        Try
            Return odOrdenCompra.Obtener(oeOrden)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeOrden As EntidadesWCF.e_OrdenCompra) As Boolean Implements Il_OrdenCompra.Validar
        Try
            With oeOrden
                If .TipoOperacion <> "1" Then 'Si es deferente de aprobar ordenes de compra.
                    '--Dia Limite de la OC.
                    'If oeOrden.FechaOrden.Day > 25 AndAlso oeOrden.TipoOperacion <> "3" Then Throw New Exception("Solo se pueden generar OC hasta el 25 de cada mes.")
                    'If oeOrden.FechaEntrega.Date < oeOrden.FechaOrden.Date Then
                    '    Throw New Exception("La fecha de entrega debe ser mayor o igual a la fecha en la que se generó la orden.")
                    'End If
                    If .TipoOperacion <> "G" Then
                        l_FuncionesGenerales.ValidarCampoNoNulo(.IdProveedor, "Seleccione un proveedor para generar una orden de compra.")
                        If .TipoBien = "MATERIAL" Then
                            If .lstOrdenMaterial.Count = 0 Then Throw New Exception("Agregar Detalles.")
                            If .lstOrdenMaterial.Where(Function(item) item.CantidadMaterial * item.PrecioUnitario = 0).Count > 0 Then Throw New Exception("Verifique Montos en Detalles.")
                            If .lstOrdenMaterial.Where(Function(item) Trim(item.IdAlmacen) = "").Count > 0 Then Throw New Exception("Verifique Almacenes")
                        Else
                            If .lstOrdenServicio.Count = 0 Then Throw New Exception("Agregar Detalles.")
                            If .lstOrdenServicio.Where(Function(item) item.Cantidad * item.PrecioUnitarioConImp = 0).Count > 0 Then Throw New Exception("Verifique Montos en Detalles.")
                        End If
                    End If
                    'If oeOrden.FechaPago.Date < oeOrden.FechaOrden.Date Then Throw New Exception("Fecha de pago debe ser mayor o igual a la Fecha en la que se generó la orden")
                    'ValidarProveedor(oeOrden)
                    'ValidarDuplicado(oeOrden)
                End If
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub ValidarDuplicado(ByVal oeOrden As EntidadesWCF.e_OrdenCompra) Implements Il_OrdenCompra.ValidarDuplicado
        Try
            Dim oeOrd As New e_OrdenCompra
            oeOrd.NroOrden = oeOrden.NroOrden
            oeOrd.Id = oeOrden.Id
            oeOrd.Activo = True
            oeOrd = Obtener(oeOrd)
            If oeOrden.TipoOperacion.Equals("I") And Not oeOrden Is Nothing Then
                'If Trim(oeOrd.NroOrden) = Trim(oeOrden.NroOrden) Then
                '    Throw New Exception("Ya existe el número de orden  " & oeOrd.NroOrden)
                'End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ValidarProveedor(ByVal oeOrden As EntidadesWCF.e_OrdenCompra) Implements Il_OrdenCompra.ValidarProveedor
        Try
            Dim oeProveedor As New e_Proveedor
            Dim olProveedor As New l_Proveedor
            oeProveedor.Id = oeOrden.IdProveedor
            oeProveedor.Activo = True
            oeProveedor = olProveedor.Obtener(oeProveedor)
            If oeProveedor.Id = "" Then
                'Throw New Exception("Este Proveedor tiene OC sin Documento ")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ModificarPrecios(oeOrden As e_OrdenCompra) As Boolean Implements Il_OrdenCompra.ModificarPrecios
        Try
            If Validar(oeOrden) Then
                Return odOrdenCompra.ModificarPrecios(oeOrden)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
