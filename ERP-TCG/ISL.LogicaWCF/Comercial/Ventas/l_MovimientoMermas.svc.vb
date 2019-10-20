' NOTA: si cambia aquí el nombre de clase "l_MovimientoMermas", también debe actualizar la referencia a "l_MovimientoMermas" tanto en Web.config como en el archivo .svc asociado.
Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization
Imports System.Transactions

Public Class l_MovimientoMermas
    Implements Il_MovimientoMermas

    Dim odMovimientoMermas As New d_MovimientoMermas

    Public Function Obtener(ByVal oeMovimientoMermas As e_MovimientoMermas) As e_MovimientoMermas Implements Il_MovimientoMermas.Obtener
        Try
            Return odMovimientoMermas.Obtener(oeMovimientoMermas)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeMovimientoMermas As e_MovimientoMermas) As List(Of e_MovimientoMermas) Implements Il_MovimientoMermas.Listar
        Try
            Return odMovimientoMermas.Listar(oeMovimientoMermas)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeMovimientoMermas As e_MovimientoMermas) As Boolean Implements Il_MovimientoMermas.Guardar
        Try
            Return odMovimientoMermas.Guardar(oeMovimientoMermas)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeMovimientoMermas As e_MovimientoMermas) As Boolean Implements Il_MovimientoMermas.Eliminar
        Try
            Return odMovimientoMermas.Eliminar(oeMovimientoMermas)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Cobrar(loMovMer As List(Of e_MovimientoMermas), oeOtrosIngresos As e_OtrosIngresos) As String Implements Il_MovimientoMermas.Cobrar
        Try
            Dim id As String = ""
            Dim oeAsiento As New e_Asiento
            Dim loAsiento As New List(Of e_Asiento)
            Dim olAsiento As New l_Asiento
            Dim oeAsientoMovimiento As New e_AsientoMovimiento
            Dim loAsientoMovimiento As New List(Of e_AsientoMovimiento)
            Using TransScope As New TransactionScope()
                id = odMovimientoMermas.Cobrar(loMovMer, oeOtrosIngresos)
                If oeOtrosIngresos.loAsientoModelo.Count > 0 Then
                    For Each asimod As e_AsientoModelo In oeOtrosIngresos.loAsientoModelo
                        oeAsiento = New e_Asiento
                        With oeAsiento
                            .TipoOperacion = "I" : .IdTipoAsiento = asimod.IdTipoAsiento : .NroAsiento = String.Empty : .GlosaImprime = String.Empty
                            .Glosa = oeOtrosIngresos.Glosa
                            .IdMoneda = asimod.IdMoneda : .IdEstado = "CUADRADO" : oeAsiento.Activo = True : .TipoCambio = oeOtrosIngresos.TipoCambio
                            .TotalDebe = oeOtrosIngresos.Importe : .TotalHaber = oeOtrosIngresos.Importe : .Fecha = oeOtrosIngresos.FechaCreacion
                            .IdUsuarioCrea = oeOtrosIngresos.UsuarioCreacion : .IdPeriodo = oeOtrosIngresos.IdPeriodo
                        End With
                        For Each asidet As e_DetalleAsientoModelo In asimod.leDetalle
                            If asidet.Partida = "1" Then
                                oeAsientoMovimiento = New e_AsientoMovimiento
                                With oeAsientoMovimiento
                                    .TipoOperacion = "I"
                                    .IdUsuarioCrea = oeAsiento.IdUsuarioCrea : .Activo = True : .Fila = asidet.Fila
                                    .IdCuentaContable = asidet.IdCuentaContable
                                    .Glosa = oeAsiento.Glosa
                                    .DebeMN = Math.Round(oeOtrosIngresos.Importe, 2)
                                    .DebeME = Math.Round(oeOtrosIngresos.Importe / oeAsiento.TipoCambio, 2)
                                    If .DebeMN > 0 Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                                End With
                            Else
                                oeAsientoMovimiento = New e_AsientoMovimiento
                                With oeAsientoMovimiento
                                    .TipoOperacion = "I"
                                    .IdUsuarioCrea = oeAsiento.IdUsuarioCrea : .Activo = True : .Fila = asidet.Fila
                                    .IdCuentaContable = asidet.IdCuentaContable
                                    .HaberMN = oeOtrosIngresos.Importe
                                    .HaberME = Math.Round(oeOtrosIngresos.Importe / oeAsiento.TipoCambio, 2)
                                    .Glosa = oeAsiento.Glosa
                                    If .HaberMN > 0 Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                                End With
                            End If
                        Next
                    Next
                    oeAsiento.AsientoMovimiento.AddRange(loAsientoMovimiento.OrderBy(Function(item) item.Fila).ToList)
                    loAsiento.Add(oeAsiento)
                    If olAsiento.GuardarLista(loAsiento) Then
                        TransScope.Complete()
                    End If
                Else
                    TransScope.Complete()
                End If
            End Using
            Return id
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
