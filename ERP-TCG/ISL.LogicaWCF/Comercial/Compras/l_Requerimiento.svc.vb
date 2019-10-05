'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization
Imports System.Transactions

<DataContract(), Serializable()> _
Public Class l_Requerimiento
    Implements Il_Requerimiento

    Dim odRequerimiento As New d_Requerimiento
    Dim olOrden As l_Orden

    Public Function Eliminar(ByVal oeRequerimiento As EntidadesWCF.e_Requerimiento) As Boolean Implements Il_Requerimiento.Eliminar
        Try
            Return odRequerimiento.Eliminar(oeRequerimiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeRequerimiento As EntidadesWCF.e_Requerimiento) As Boolean Implements Il_Requerimiento.Guardar
        Try
            Using TransScope As New TransactionScope()
                If Validar(oeRequerimiento) Then
                    If odRequerimiento.Guardar(oeRequerimiento) Then
                        If oeRequerimiento.TipoOperacion = "D" Or oeRequerimiento.TipoOperacion = "R" Then
                            olOrden = New l_Orden
                            olOrden.GenerarAsientoConsumo(oeRequerimiento.oeOrdenSalida)
                        End If
                        TransScope.Complete()
                    End If
                End If
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarLista(ByVal lstRequerimientos As System.Collections.Generic.List(Of EntidadesWCF.e_Requerimiento)) As Boolean Implements Il_Requerimiento.GuardarLista
        Try
            Return odRequerimiento.GuardarLista(lstRequerimientos)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeRequerimiento As EntidadesWCF.e_Requerimiento) As System.Collections.Generic.List(Of EntidadesWCF.e_Requerimiento) Implements Il_Requerimiento.Listar
        Try
            Return odRequerimiento.Listar(oeRequerimiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeRequerimiento As EntidadesWCF.e_Requerimiento) As EntidadesWCF.e_Requerimiento Implements Il_Requerimiento.Obtener
        Try
            Return odRequerimiento.Obtener(oeRequerimiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeRequerimiento As EntidadesWCF.e_Requerimiento) As Boolean Implements Il_Requerimiento.Validar
        Try

            Dim oeRequerimientoMaterial As New e_RequerimientoMaterial, lstRequerimientoMaterial As List(Of e_RequerimientoMaterial)
            Dim olRequerimientoMaterial As New l_RequerimientoMaterial
            oeRequerimientoMaterial.Tipooperacion = 2
            oeRequerimientoMaterial.Activo = True
            oeRequerimientoMaterial.IdRequerimiento = oeRequerimiento.Id

            If oeRequerimiento.TipoOperacion = "D" And oeRequerimiento.Id IsNot Nothing Then
                lstRequerimientoMaterial = olRequerimientoMaterial.Listar(oeRequerimientoMaterial)
                For Each Detalle As e_RequerimientoMaterial In oeRequerimiento.lstRequerimientoMaterial
                    For Each DetalleBD As e_RequerimientoMaterial In lstRequerimientoMaterial
                        If Detalle.IdMaterial = DetalleBD.IdMaterial _
                            And Detalle.IdMantenimiento = DetalleBD.IdMantenimiento _
                            And Detalle.IdMantenimientoEquipo = DetalleBD.IdMantenimientoEquipo _
                            And Detalle.IdSubAlmacen.Trim = DetalleBD.IdSubAlmacen.Trim Then

                            If (Detalle.Cantidad - Detalle.CantidadAAtender) - (DetalleBD.Cantidad - DetalleBD.CantidadPorAtender) < 0 Then
                                Throw New Exception("Del Material " & Detalle.Material & " queda por atender " & (Detalle.Cantidad - DetalleBD.Cantidad + DetalleBD.CantidadPorAtender))
                            End If

                        End If
                    Next
                Next
            End If

            With oeRequerimiento
                If .TipoOperacion <> "N" And .TipoOperacion <> "E" Then
                    If oeRequerimiento.MaterialServicio = "M" AndAlso oeRequerimiento.lstRequerimientoMaterial.Count = 0 Then
                        Throw New Exception("Debe agregar materiales para generar un requerimiento.")
                    End If
                    If oeRequerimiento.MaterialServicio = "S" AndAlso oeRequerimiento.lstRequerimientoServicio.Count = 0 Then
                        Throw New Exception("Debe agregar servicios para generar un requerimiento.")
                    End If
                    If oeRequerimiento.FechaAtencion.Date < oeRequerimiento.FechaCreacion.Date Then
                        Throw New Exception("La fecha de atención no puede ser menor que la fecha de solicitud.")
                    End If
                End If
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ActualizaOT(oeRequerimiento As e_Requerimiento) As Boolean Implements Il_Requerimiento.ActualizaOT
        Try
            Return odRequerimiento.ActualizarOT(oeRequerimiento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
