'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization
Imports System.Transactions

<DataContract(), Serializable()> _
Public Class l_RegistroConsumoCombustible
    Implements Il_RegistroConsumoCombustible

    Dim odRegistrarConsumoCombustible As d_RegistroConsumoCombustible
    Dim oeSeguimiento As e_Seguimiento, olSeguimiento As New l_Seguimiento
    Dim oeViaje As e_Viaje
    Dim olOperacion As l_Operacion
    Dim l_FuncionesGenerales As l_FuncionesGenerales
    Dim oeSubAlmacen As e_SubAlmacen
    Dim olSubAlmacen As l_SubAlmacen
    Dim CantidadGlsPY As Double = 0
    Dim oePeriodo As e_Periodo
    Dim odPeriodo As d_Periodo
    Dim ListaPeriodo As List(Of e_Periodo)

    Dim oeAsiento As e_Asiento
    Dim loAsiento As List(Of e_Asiento)
    Dim olAsiento As l_Asiento
    Dim oeAsientoMovimiento As e_AsientoMovimiento
    Dim loAsientoMovimiento As List(Of e_AsientoMovimiento)
    Dim oeAsientoAnalisis As e_MovimientoAnalisis

    Public Function Eliminar(ByVal oeRegistrarConsumoCombustible As e_RegistroConsumoCombustible) As Boolean Implements Il_RegistroConsumoCombustible.Eliminar
        Try
            odRegistrarConsumoCombustible = New d_RegistroConsumoCombustible
            If oeRegistrarConsumoCombustible.IndIsl Then
                CargarPeriodo()
                ValidarPeriodo(oeRegistrarConsumoCombustible)
            End If
            Return odRegistrarConsumoCombustible.Eliminar(oeRegistrarConsumoCombustible)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(oeRegConCom As e_RegistroConsumoCombustible, oeOrden As e_Orden) As e_RegistroConsumoCombustible Implements Il_RegistroConsumoCombustible.Guardar
        Try
            Dim oeRegistro As New e_RegistroConsumoCombustible
            odRegistrarConsumoCombustible = New d_RegistroConsumoCombustible
            CargarPeriodo()
            Using Transcope As New TransactionScope
                If oeRegConCom.Ind_Masivo Then
                    odRegistrarConsumoCombustible.GuardarMasivo(oeRegConCom)
                    AsientoConsumoDiesel(oeOrden, oeRegConCom)
                Else
                    If Validar(oeRegConCom) Then
                        oeRegistro = odRegistrarConsumoCombustible.Guardar(oeRegConCom)
                        If oeOrden.IndAsiento Then
                            AsientoConsumoDiesel(oeOrden, oeRegConCom.Id)
                        End If
                    End If
                End If
                Transcope.Complete()
            End Using
            Return oeRegistro
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub AsientoConsumoDiesel(oeOrdenSalida As e_Orden, idReg As String) Implements Il_RegistroConsumoCombustible.AsientoConsumoDiesel
        Try
            odRegistrarConsumoCombustible = New d_RegistroConsumoCombustible
            Dim oe As New e_RegistroConsumoCombustible
            oe.TipoOperacion = "2"
            oe.Id = idReg
            oe = odRegistrarConsumoCombustible.Obtener(oe)
            If oeOrdenSalida.IndAsiento Then
                loAsiento = New List(Of e_Asiento)
                loAsientoMovimiento = New List(Of e_AsientoMovimiento)
                olAsiento = New l_Asiento
                For Each asimod As e_AsientoModelo In oeOrdenSalida.loAsientoModelo
                    oeAsiento = New e_Asiento
                    oeAsiento.PrefijoID = oeOrdenSalida.PrefijoID '@0001
                    With oeAsiento
                        .TipoOperacion = "I" : .IdPeriodo = oeOrdenSalida.IdPeriodo : .IdTipoAsiento = asimod.IdTipoAsiento
                        .NroAsiento = String.Empty : .Fecha = oeOrdenSalida.FechaOrden
                        .Glosa = asimod.Nombre & " " & oe.PlacaVeh & " " & oe.NroVale
                        .GlosaImprime = String.Empty : .IdMoneda = asimod.IdMoneda : .TipoCambio = oeOrdenSalida.TipoCambio
                        .TotalDebe = Math.Round(oeOrdenSalida.Total, 2)
                        .TotalHaber = Math.Round(oeOrdenSalida.Total, 2)
                        .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeOrdenSalida.UsuarioCreacion : oeAsiento.Activo = True
                        .IndOrigen = 27
                        .AsientoReferencia = New e_AsientoReferencia
                        .AsientoReferencia.TipoOperacion = "I"
                        .AsientoReferencia.IdReferencia = idReg
                        .AsientoReferencia.TipoReferencia = 5
                        .AsientoReferencia.PrefijoID = oeOrdenSalida.PrefijoID '@0001
                    End With
                    For Each asidet As e_DetalleAsientoModelo In asimod.leDetalle.OrderBy(Function(item) item.Fila).ToList
                        oeAsientoMovimiento = New e_AsientoMovimiento
                        oeAsientoMovimiento.PrefijoID = oeOrdenSalida.PrefijoID '@0001
                        With oeAsientoMovimiento
                            .TipoOperacion = "I" : .Glosa = oeAsiento.Glosa
                            .IdUsuarioCrea = oeOrdenSalida.UsuarioCreacion : .Activo = True : .Fila = asidet.Fila
                            .IdCuentaContable = asidet.IdCuentaContable
                            If asidet.Partida = 1 Then
                                .DebeMN = Math.Round(oeOrdenSalida.Total, 2)
                                .DebeME = Math.Round(oeOrdenSalida.Total, 2)
                                oeAsientoAnalisis = New e_MovimientoAnalisis
                                oeAsientoAnalisis.PrefijoID = oeOrdenSalida.PrefijoID '@0001
                                oeAsientoAnalisis.TipoOperacion = ""
                                oeAsientoAnalisis.IdMoneda = asimod.IdMoneda
                                oeAsientoAnalisis.IdUsuarioCrea = oeOrdenSalida.UsuarioCreacion
                                oeAsientoAnalisis.IdGastoFuncion = "1CH000087"
                                oeAsientoAnalisis.Monto = .DebeMN
                                oeAsientoAnalisis.Saldo = .DebeMN
                                oeAsientoAnalisis.IdVehiculo = oe.IdVehiculo
                                .MovimientoAnalisis.Add(oeAsientoAnalisis)
                                If .DebeMN > 0 And .IdCuentaContable.Trim <> "" Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                            Else
                                .HaberMN = Math.Round(oeOrdenSalida.Total, 2)
                                .HaberME = Math.Round(oeOrdenSalida.Total, 2)
                                If .HaberMN > 0 And .IdCuentaContable.Trim <> "" Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                            End If
                        End With
                    Next
                    oeAsiento.AsientoMovimiento.AddRange(loAsientoMovimiento.OrderBy(Function(item) item.Fila).ToList)
                    If oeAsiento.AsientoMovimiento.Count > 0 Then loAsiento.Add(oeAsiento)
                Next
                olAsiento.GuardarLista(loAsiento)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function AsientoConsumoDieselMasivo(loReg As List(Of e_RegistroConsumoCombustible), loAsientoModelo As List(Of e_AsientoModelo), oeOrden As e_Orden) As Boolean Implements Il_RegistroConsumoCombustible.AsientoConsumoDieselMasivo
        Try
            odRegistrarConsumoCombustible = New d_RegistroConsumoCombustible
            loAsiento = New List(Of e_Asiento)
            loAsientoMovimiento = New List(Of e_AsientoMovimiento)
            olAsiento = New l_Asiento
            Using Transcope As New TransactionScope
                For Each oeRegCon As e_RegistroConsumoCombustible In loReg
                    For Each asimod As e_AsientoModelo In loAsientoModelo
                        oeAsiento = New e_Asiento
                        With oeAsiento
                            .TipoOperacion = "I" : .IdPeriodo = oeOrden.IdPeriodo : .IdTipoAsiento = asimod.IdTipoAsiento
                            .NroAsiento = String.Empty : .Fecha = oeRegCon.FechaCreacion
                            .Glosa = asimod.Nombre & " " & oeRegCon.PlacaVeh & " " & oeRegCon.NroVale
                            .GlosaImprime = String.Empty : .IdMoneda = asimod.IdMoneda : .TipoCambio = oeOrden.TipoCambio
                            .TotalDebe = Math.Round(oeRegCon.CantidadGalon * oeRegCon.PrecioUnitario, 2)
                            .TotalHaber = Math.Round(oeRegCon.CantidadGalon * oeRegCon.PrecioUnitario, 2)
                            .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeRegCon.UsuarioCreacion : oeAsiento.Activo = True
                            .IndOrigen = 27
                            .AsientoReferencia = New e_AsientoReferencia
                            .AsientoReferencia.TipoOperacion = "I"
                            .AsientoReferencia.IdReferencia = oeRegCon.Id
                            .AsientoReferencia.TipoReferencia = 5
                        End With
                        loAsientoMovimiento = New List(Of e_AsientoMovimiento)
                        For Each asidet As e_DetalleAsientoModelo In asimod.leDetalle.OrderBy(Function(item) item.Fila).ToList
                            oeAsientoMovimiento = New e_AsientoMovimiento
                            With oeAsientoMovimiento
                                .TipoOperacion = "I" : .Glosa = oeAsiento.Glosa
                                .IdUsuarioCrea = oeRegCon.UsuarioCreacion : .Activo = True : .Fila = asidet.Fila
                                .IdCuentaContable = asidet.IdCuentaContable
                                If asidet.Partida = 1 Then
                                    .DebeMN = Math.Round(oeRegCon.CantidadGalon * oeRegCon.PrecioUnitario, 2)
                                    .DebeME = Math.Round(oeRegCon.CantidadGalon * oeRegCon.PrecioUnitario, 2)
                                    oeAsientoAnalisis = New e_MovimientoAnalisis
                                    oeAsientoAnalisis.TipoOperacion = ""
                                    oeAsientoAnalisis.IdMoneda = asimod.IdMoneda
                                    oeAsientoAnalisis.IdUsuarioCrea = oeRegCon.UsuarioCreacion
                                    oeAsientoAnalisis.IdGastoFuncion = "1CH000087"
                                    oeAsientoAnalisis.Monto = .DebeMN
                                    oeAsientoAnalisis.Saldo = .DebeMN
                                    oeAsientoAnalisis.IdVehiculo = oeRegCon.IdVehiculo
                                    .MovimientoAnalisis.Add(oeAsientoAnalisis)
                                    If .DebeMN > 0 And .IdCuentaContable.Trim <> "" Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                                Else
                                    .HaberMN = Math.Round(oeRegCon.CantidadGalon * oeRegCon.PrecioUnitario, 2)
                                    .HaberME = Math.Round(oeRegCon.CantidadGalon * oeRegCon.PrecioUnitario, 2)
                                    If .HaberMN > 0 And .IdCuentaContable.Trim <> "" Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                                End If
                            End With
                        Next
                        oeAsiento.AsientoMovimiento.AddRange(loAsientoMovimiento.OrderBy(Function(item) item.Fila).ToList)
                        If oeAsiento.AsientoMovimiento.Count > 0 Then loAsiento.Add(oeAsiento)
                    Next
                Next
                olAsiento.GuardarListaMasiva4(loAsiento, oeOrden.PrefijoID)
                Transcope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub AsientoConsumoDiesel(oeOrdenSalida As e_Orden, oeRegCon As e_RegistroConsumoCombustible) 'Implements Il_Orden.GenerarAsientoConsumo
        Try
            If oeOrdenSalida.IndAsiento Then
                loAsiento = New List(Of e_Asiento)
                loAsientoMovimiento = New List(Of e_AsientoMovimiento)
                olAsiento = New l_Asiento
                For Each asimod As e_AsientoModelo In oeOrdenSalida.loAsientoModelo
                    oeAsiento = New e_Asiento
                    oeAsiento.PrefijoID = oeOrdenSalida.PrefijoID '@0001
                    With oeAsiento
                        .TipoOperacion = "I" : .IdPeriodo = oeOrdenSalida.IdPeriodo : .IdTipoAsiento = asimod.IdTipoAsiento
                        .NroAsiento = String.Empty : .Fecha = oeOrdenSalida.FechaOrden
                        .Glosa = asimod.Nombre & " MASIVO"
                        .GlosaImprime = String.Empty : .IdMoneda = asimod.IdMoneda : .TipoCambio = oeOrdenSalida.TipoCambio
                        .TotalDebe = Math.Round(oeOrdenSalida.Total, 2)
                        .TotalHaber = Math.Round(oeOrdenSalida.Total, 2)
                        .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeOrdenSalida.UsuarioCreacion : oeAsiento.Activo = True
                        .IndOrigen = 27
                    End With
                    For Each asidet As e_DetalleAsientoModelo In asimod.leDetalle.OrderBy(Function(item) item.Fila).ToList
                        oeAsientoMovimiento = New e_AsientoMovimiento
                        oeAsientoMovimiento.PrefijoID = oeOrdenSalida.PrefijoID '@0001
                        With oeAsientoMovimiento
                            .TipoOperacion = "I" : .Glosa = oeAsiento.Glosa
                            .IdUsuarioCrea = oeOrdenSalida.UsuarioCreacion : .Activo = True : .Fila = asidet.Fila
                            .IdCuentaContable = asidet.IdCuentaContable
                            If asidet.Partida = 1 Then
                                .DebeMN = Math.Round(oeOrdenSalida.Total, 2)
                                .DebeME = Math.Round(oeOrdenSalida.Total, 2)
                                For Each concom As e_RegistroConsumoCombustible In oeRegCon.ListaRegistrosConsumoD2
                                    oeAsientoAnalisis = New e_MovimientoAnalisis
                                    oeAsientoAnalisis.PrefijoID = oeOrdenSalida.PrefijoID '@0001
                                    oeAsientoAnalisis.TipoOperacion = ""
                                    oeAsientoAnalisis.IdMoneda = asimod.IdMoneda
                                    oeAsientoAnalisis.IdUsuarioCrea = oeOrdenSalida.UsuarioCreacion
                                    oeAsientoAnalisis.IdGastoFuncion = "1CH000087"
                                    oeAsientoAnalisis.Monto = Math.Round(concom.CantidadGalon * concom.PrecioUnitario, 2)
                                    oeAsientoAnalisis.Saldo = Math.Round(concom.CantidadGalon * concom.PrecioUnitario, 2)
                                    oeAsientoAnalisis.IdVehiculo = concom.IdVehiculo
                                    .MovimientoAnalisis.Add(oeAsientoAnalisis)
                                Next
                                If .DebeMN > 0 And .IdCuentaContable.Trim <> "" Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                            Else
                                .HaberMN = Math.Round(oeOrdenSalida.Total, 2)
                                .HaberME = Math.Round(oeOrdenSalida.Total, 2)
                                If .HaberMN > 0 And .IdCuentaContable.Trim <> "" Then loAsientoMovimiento.Add(oeAsientoMovimiento)
                            End If
                        End With
                    Next
                    oeAsiento.AsientoMovimiento.AddRange(loAsientoMovimiento.OrderBy(Function(item) item.Fila).ToList)
                    If oeAsiento.AsientoMovimiento.Count > 0 Then loAsiento.Add(oeAsiento)
                Next
                olAsiento.GuardarLista(loAsiento)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function Listar(ByVal oeRegistrarConsumoCombustible As e_RegistroConsumoCombustible) As System.Collections.Generic.List(Of e_RegistroConsumoCombustible) Implements Il_RegistroConsumoCombustible.Listar
        Try
            odRegistrarConsumoCombustible = New d_RegistroConsumoCombustible
            Return odRegistrarConsumoCombustible.Listar(oeRegistrarConsumoCombustible)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDts(ByVal oeRegCon As e_RegistroConsumoCombustible) As System.Data.DataSet Implements Il_RegistroConsumoCombustible.ListarDts
        Try
            odRegistrarConsumoCombustible = New d_RegistroConsumoCombustible
            Dim dts As New DataSet
            dts = odRegistrarConsumoCombustible.ListarDts(oeRegCon)
            Return dts
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeRegistrarConsumoCombustible As e_RegistroConsumoCombustible) As e_RegistroConsumoCombustible Implements Il_RegistroConsumoCombustible.Obtener
        Try
            odRegistrarConsumoCombustible = New d_RegistroConsumoCombustible
            Return odRegistrarConsumoCombustible.Obtener(oeRegistrarConsumoCombustible)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeRegistrarConsumoCombustible As e_RegistroConsumoCombustible) As Boolean Implements Il_RegistroConsumoCombustible.Validar
        Try
            l_FuncionesGenerales = New l_FuncionesGenerales
            With oeRegistrarConsumoCombustible
                If oeRegistrarConsumoCombustible.TipoOperacion = "G" Or oeRegistrarConsumoCombustible.TipoOperacion = "P" Then
                    If oeRegistrarConsumoCombustible.TipoOperacion = "P" Then
                        If Not String.IsNullOrEmpty(oeRegistrarConsumoCombustible.IdViaje) Then
                            If ValidarFechaTanqueo(oeRegistrarConsumoCombustible) Then Return True
                        End If
                    End If
                    Return True
                End If
                If Not String.IsNullOrEmpty(oeRegistrarConsumoCombustible.IdViaje) Then
                    ValidarFechaTanqueo(oeRegistrarConsumoCombustible)
                End If
                'If .FechaViaje <> #1/1/1901# Then
                '    If oeRegistrarConsumoCombustible.Perfil <> "SUPERVISOR GENERAL" Then
                '        If .FechaTanqueo > .FechaViaje AndAlso DateDiff(DateInterval.Day, .FechaViaje, .FechaTanqueo) > 5 Then
                '            .FechaTanqueo = .FechaViaje
                '            Throw New Exception("La fecha de tanqueo no se aproxima a la fecha del viaje" & Environment.NewLine & _
                '               "Verifique el kilometraje o fecha de tanqueo para ubicar el tanqueo de la unidad en un viaje correcto. De ser correcto será necesario el registro sera posible por un usuario cuyo perfil sea Supervisr General")
                '        End If
                '        If .FechaTanqueo < .FechaViaje AndAlso DateDiff(DateInterval.Day, .FechaTanqueo, .FechaViaje) > 5 Then
                '            .FechaTanqueo = .FechaViaje
                '            Throw New Exception("La fecha de tanqueo no se aproxima a la fecha del viaje" & Environment.NewLine & _
                '                    "Verifique el kilometraje o fecha de tanqueo para ubicar el tanqueo de la unidad en un viaje correcto.  De ser correcto será necesario el registro sera posible por un usuario cuyo perfil sea Supervisr General")
                '        End If
                '    End If
                'End If
                l_FuncionesGenerales.ValidarCampoNoNulo(Trim(.IdVehiculo), "Especifique un Vehículo para el Tanqueo")
                l_FuncionesGenerales.ValidarNumero(Len(.IdVehiculo), "Vehículo Incorrecto")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdVehiculo, "Especifique un Vehículo para el Tanqueo")
                l_FuncionesGenerales.ValidarNumeroDecimal(.KilometrosTanqueo, "El Kilometraje Debe ser Mayor a 0")
                l_FuncionesGenerales.ValidarNumeroDecimal(.CantidadGalon, "Cantidad de Galones no puede ser 0.000")
                l_FuncionesGenerales.ValidarCampoNoNulo(Trim(.NroVale), "Ingrese un Numero de Vale")
                ValidarGrifo(oeRegistrarConsumoCombustible)
                ValidarDireccion(oeRegistrarConsumoCombustible)
                ValidarSubAlmacen(oeRegistrarConsumoCombustible)
                ValidarFechaTanqueoActual(oeRegistrarConsumoCombustible)

                If oeRegistrarConsumoCombustible.TipoOperacion = "I" Then
                    ValidarNroValeDireccion(oeRegistrarConsumoCombustible)
                End If
                If oeRegistrarConsumoCombustible.IndIsl Then
                    'l_FuncionesGenerales.ValidarNumeroDecimal(oeRegistrarConsumoCombustible.PrecioUnitario, "Precio de Combustible igual 0. Verificar")
                    Validar48Horas(oeRegistrarConsumoCombustible)
                    ValidarPeriodo(oeRegistrarConsumoCombustible)
                    'ValidarStockMinimo(oeRegistrarConsumoCombustible)
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub ValidarDireccion(ByVal oeRegistrarConsumoCombustible As e_RegistroConsumoCombustible) Implements Il_RegistroConsumoCombustible.ValidarDireccion
        Try
            Dim oeDireccion As New e_Direccion, olDireccion As New l_Direccion
            oeDireccion.TipoOperacion = ""
            oeDireccion.Id = oeRegistrarConsumoCombustible.IdDireccion
            oeDireccion.Activo = True
            If String.IsNullOrEmpty(oeDireccion.Id) Then
                Throw New Exception("Seleccione una Direccion,Por favor")
            End If
            oeDireccion = olDireccion.Obtener(oeDireccion)
            If String.IsNullOrEmpty(oeDireccion.Id) Then
                Throw New Exception("No existe el Grifo seleccionado")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ValidarFechaTanqueo(ByVal oeRegistrarConsumoCombustible As e_RegistroConsumoCombustible) As Boolean Implements Il_RegistroConsumoCombustible.ValidarFechaTanqueo
        Try
            If Trim(oeRegistrarConsumoCombustible.IdViaje) = "" Then
                Exit Try
            End If
            oeViaje = New e_Viaje
            olOperacion = New l_Operacion
            oeViaje.TipoOperacion = "E"
            oeViaje.Id = oeRegistrarConsumoCombustible.IdViaje
            oeViaje = olOperacion.ObtenerViaje(oeViaje)
            If oeViaje.Id <> "" Then
                oeSeguimiento = New e_Seguimiento
                olSeguimiento = New l_Seguimiento
                oeSeguimiento.TipoOperacion = 5
                oeSeguimiento.IdViaje = oeRegistrarConsumoCombustible.IdViaje
                oeSeguimiento = olSeguimiento.Obtener(oeSeguimiento)
                If oeRegistrarConsumoCombustible.IdGrifo = "1CH000006026" Then
                    If oeRegistrarConsumoCombustible.Perfil <> "SUPERVISOR GENERAL" Then

                        If oeSeguimiento.IndLlegadaDestino = "1" Then
                            If oeRegistrarConsumoCombustible.FechaTanqueo > oeSeguimiento.LlegadaDestino AndAlso DateDiff(DateInterval.Day, oeSeguimiento.LlegadaDestino, oeRegistrarConsumoCombustible.FechaTanqueo) > 10 Then
                                Throw New Exception("La fecha de tanqueo no se aproxima a la fecha de la operacion" & Environment.NewLine & _
                                    "Verifique el kilometraje o fecha de tanqueo para ubicar el tanqueo de la unidad en una operacion correcta. De ser correcto será necesario el registro sera posible por un usuario cuyo perfil sea Supervisr General")
                            End If

                            If oeRegistrarConsumoCombustible.FechaTanqueo < oeSeguimiento.LlegadaDestino AndAlso DateDiff(DateInterval.Day, oeRegistrarConsumoCombustible.FechaTanqueo, oeSeguimiento.LlegadaDestino) > 10 Then
                                Throw New Exception("La fecha de tanqueo no se aproxima a la fecha de la operacion" & Environment.NewLine & _
                                "Verifique el kilometraje o fecha de tanqueo para ubicar el tanqueo de la unidad en una operacion correcta.  De ser correcto será necesario el registro sera posible por un usuario cuyo perfil sea Supervisr General")
                            End If
                        End If
                    End If
                End If
            Else
                Throw New Exception("Este viaje fue eliminado en Operaciones, actualize su relación de viajes para tanquear nuevamente")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub ValidarGrifo(ByVal oeRegistrarConsumoCombustible As e_RegistroConsumoCombustible) Implements Il_RegistroConsumoCombustible.ValidarGrifo
        Try
            If Not String.IsNullOrEmpty(oeRegistrarConsumoCombustible.IdGrifo) Then
                Dim oeEmpresa As New e_Empresa, olEmpresa As New l_Empresa
                oeEmpresa.Id = oeRegistrarConsumoCombustible.IdGrifo
                oeEmpresa.Activo = True
                oeEmpresa = olEmpresa.Obtener(oeEmpresa)
                If oeEmpresa.Id = "" Then
                    Throw New Exception("No existe el Grifo seleccionado")
                End If
            Else
                Throw New Exception("Seleccione un Grifo determinado")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ValidarNroValeDireccion(ByVal oeRegistrarConsumoCombustible As e_RegistroConsumoCombustible) Implements Il_RegistroConsumoCombustible.ValidarNroValeDireccion
        Try
            Dim oeRegConsumo, oeRegConsumoI As New e_RegistroConsumoCombustible, olRegConsumo As New l_RegistroConsumoCombustible
            oeRegConsumo.TipoOperacion = 5
            oeRegConsumo.Id = oeRegistrarConsumoCombustible.IdGrifo
            oeRegConsumo.IdVehiculo = oeRegistrarConsumoCombustible.NroVale
            oeRegConsumoI = olRegConsumo.Obtener(oeRegConsumo)
            If oeRegConsumoI.IdGrifo <> "" Then
                Throw New Exception("El numero de vale ingresado fue registrado con dicho grifo, Ingrese otro N° Vale")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ValidarSubAlmacen(ByVal oeRegistrarConsumoCombustible As e_RegistroConsumoCombustible) Implements Il_RegistroConsumoCombustible.ValidarSubAlmacen
        Try
            oeSubAlmacen = New e_SubAlmacen
            olSubAlmacen = New l_SubAlmacen
            oeSubAlmacen.TipoOperacion = ""
            oeSubAlmacen.IdGrifo = oeRegistrarConsumoCombustible.IdGrifo
            oeSubAlmacen.IdDireccion = oeRegistrarConsumoCombustible.IdDireccion
            oeSubAlmacen = olSubAlmacen.Obtener(oeSubAlmacen)

            If String.IsNullOrEmpty(oeSubAlmacen.Id) Then
                oeSubAlmacen = New e_SubAlmacen
                oeSubAlmacen.TipoOperacion = "I"
                oeSubAlmacen.Codigo = ""
                oeSubAlmacen.IdAlmacen = "1CH000000011"
                oeSubAlmacen.Activo = True
                oeSubAlmacen.UsuarioCreacion = oeRegistrarConsumoCombustible.UsuarioCreacion
                oeSubAlmacen.IdEquipo = ""
                oeSubAlmacen.IdGrifo = oeRegistrarConsumoCombustible.IdGrifo
                oeSubAlmacen.IdDireccion = oeRegistrarConsumoCombustible.IdDireccion
                olSubAlmacen.Guardar(oeSubAlmacen)

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Function ValidarFechaTanqueoActual(ByVal oeRegistrarConsumoCombustible As e_RegistroConsumoCombustible) Implements Il_RegistroConsumoCombustible.ValidarFechaTanqueActual
        Try
            If oeRegistrarConsumoCombustible.FechaTanqueo > Date.Now().AddMinutes(5) Then
                Throw New Exception("Fecha de Tanqueo es mayor a la fecha actual")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub CargarPeriodo()
        Try
            oePeriodo = New e_Periodo
            odPeriodo = New d_Periodo
            ListaPeriodo = New List(Of e_Periodo)
            oePeriodo.Activo = True
            ListaPeriodo = odPeriodo.Listar(oePeriodo)
            oePeriodo = ListaPeriodo.Where(Function(item) item.CierreCombustible = True).OrderByDescending(Function(i) i.FechaInicio).ToList(0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ValidarPeriodo(ByVal oeRegistrarConsumoCombustible As e_RegistroConsumoCombustible) Implements Il_RegistroConsumoCombustible.ValidarPeriodo
        Try
            If oeRegistrarConsumoCombustible.FechaTanqueo < oePeriodo.FechaInicio.AddMonths(1) Then
                Throw New Exception("El periodo de Combustibles para " + oePeriodo.Codigo + " se ha cerrado; verifique su consumo")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Function Validar48Horas(ByVal oeRegistrarConsumoCombustible As e_RegistroConsumoCombustible) Implements Il_RegistroConsumoCombustible.Validar48Horas
        Try
            If oeRegistrarConsumoCombustible.TipoOperacion = "A" Then
                Dim oeCompara As New e_RegistroConsumoCombustible
                oeCompara.Id = oeRegistrarConsumoCombustible.Id
                oeCompara.TipoOperacion = 2
                oeCompara = odRegistrarConsumoCombustible.Obtener(oeCompara)
                If oeRegistrarConsumoCombustible.FechaTanqueo = oeCompara.FechaTanqueo Then
                    Return True
                End If
                If oeRegistrarConsumoCombustible.FechaTanqueo > oeCompara.FechaTanqueo.AddHours(1) Then
                    Throw New Exception("No se puede actualizar el tanqueo a una fecha después de su creación(1 hora).")
                End If
            End If
            If oeRegistrarConsumoCombustible.TipoOperacion = "I" Or oeRegistrarConsumoCombustible.TipoOperacion = "A" Then
                If Date.Now.AddDays(-5) > oeRegistrarConsumoCombustible.FechaTanqueo Then
                    Throw New Exception("No se permiten registrar ni modificar tanqueos con fecha anterior a 5 días del presente día")
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Function CalcularRendimiento(oeRegistroConsumoComb As e_RegistroConsumoCombustible) As DataSet Implements Il_RegistroConsumoCombustible.CalcularRendimiento
        Try
            odRegistrarConsumoCombustible = New d_RegistroConsumoCombustible
            Dim ds As DataSet
            ds = odRegistrarConsumoCombustible.ListarDts(oeRegistroConsumoComb)

            Dim relation_1 As DataRelation, relation_2 As DataRelation
            Dim parentCol As DataColumn = ds.Tables(0).Columns("Id")
            Dim childCol_1 As DataColumn = ds.Tables(1).Columns("IdTracto")
            relation_1 = New DataRelation("FK_RelacionRegConComb_1", parentCol, childCol_1, False)
            ds.Relations.Add(relation_1)

            Dim TransactionColumns() As DataColumn, DetailColumns() As DataColumn
            TransactionColumns = New DataColumn() {ds.Tables(1).Columns("IdViaje"), ds.Tables(1).Columns("IdTracto")}
            DetailColumns = New DataColumn() {ds.Tables(2).Columns("IdViaje"), ds.Tables(2).Columns("IdVehiculo")}
            relation_2 = New DataRelation("FK_Relacion_VT", TransactionColumns, DetailColumns, False)
            ds.Relations.Add(relation_2)

            Dim dtTractos As DataTable = ds.Tables(0)
            Dim dtViaje As DataTable = ds.Tables(1)
            Dim dtTanqueo As DataTable = ds.Tables(2)

            Dim dtViajeAnterior = New DataTable()
            Dim dtTanqueoAnterior = New DataTable()
            dtViajeAnterior = dtViaje.Clone()
            dtTanqueoAnterior = dtTanqueo.Clone()

            Dim ConsumoGls As Double = 0.0
            Dim Metas As String = ""
            Dim Pilotos As String = ""
            Dim Pesos As String = ""
            Dim Clientes As String = ""
            Dim Cargas As String = ""
            Dim LD As String = ""
            Dim ViajeOrigen As String = ""
            Dim ViajeDestino As String = ""
            Dim SaltoViaje As Boolean
            Dim SaltoTanqueo As Boolean

            For Each vehRow As DataRow In dtTractos.Rows
                LD = ""
                vehRow("Desviacion") = 0
                vehRow("Cons") = 0
                vehRow("Dist") = 0
                For Each viajeRow As DataRow In vehRow.GetChildRows(relation_1)
                    SaltoViaje = False
                    ViajeOrigen = IIf(String.IsNullOrEmpty(Trim(viajeRow("EqOrigen"))), viajeRow("ROrigen"), viajeRow("EqOrigen"))
                    ViajeDestino = IIf(String.IsNullOrEmpty(Trim(viajeRow("EqDestino"))), viajeRow("RDestino"), viajeRow("EqDestino"))
                    If LD <> "" And ViajeOrigen <> LD Then
                        LD = ViajeOrigen
                        Metas = Metas + " - " + LD
                        Pesos = IIf(Pesos = "", CInt(dtViajeAnterior(0)("Peso")).ToString, Pesos + " - 0")
                        Clientes = IIf(Clientes = "", dtViajeAnterior(0)("Cliente").ToString, Clientes + " / --")
                        Cargas = IIf(Cargas = "", dtViajeAnterior(0)("CargaMaterial").ToString, Cargas + " / --")
                        Pilotos = Pilotos + " / " + viajeRow("Piloto") + " / " + viajeRow("Copiloto")
                    End If
                    SaltoTanqueo = True
                    For Each tanqRow As DataRow In viajeRow.GetChildRows(relation_2)
                        SaltoTanqueo = False
                        If tanqRow("IndTanqueo") = True Then
                            If dtTanqueoAnterior.Rows.Count > 0 Then
                                tanqRow("Cons") = Math.Round(tanqRow("CantidadGls") + ConsumoGls, 3)
                                tanqRow("Dist") = Math.Round(tanqRow("Kilometraje") - dtTanqueoAnterior(0)("Kilometraje"), 3)
                                tanqRow("Rend") = Math.Round(tanqRow("Dist") / tanqRow("Cons"), 3)
                                tanqRow("Rutas") = IIf(String.IsNullOrEmpty(Trim(dtTanqueoAnterior(0)("EqOrigen"))), dtTanqueoAnterior(0)("LugTanqueo"), dtTanqueoAnterior(0)("EqOrigen"))
                                tanqRow("Rutas") = tanqRow("Rutas") + Metas
                                tanqRow("IdPiloto") = Pilotos + " / " + viajeRow("Piloto") + " / " + viajeRow("CoPiloto")
                                Pilotos = ""
                                tanqRow("Pesos") = Pesos
                                tanqRow("IdMaterial") = Cargas
                                tanqRow("IdEmpresaGrifo") = Clientes
                                Dim LugarTanqueo As String = IIf(String.IsNullOrEmpty(Trim(tanqRow("EqOrigen"))), tanqRow("LugTanqueo"), tanqRow("EqOrigen"))
                                If LugarTanqueo <> LD Then
                                    tanqRow("Rutas") = tanqRow("Rutas") + " - " + LugarTanqueo
                                    tanqRow("Pesos") = IIf(Pesos = "", CInt(viajeRow("Peso")).ToString, Pesos + " - " + CInt(viajeRow("Peso")).ToString)
                                    tanqRow("IdMaterial") = IIf(Cargas = "", viajeRow("CargaMaterial").ToString, Cargas + " - " + viajeRow("CargaMaterial").ToString)
                                    tanqRow("IdEmpresaGrifo") = IIf(Clientes = "", viajeRow("Cliente").ToString, Clientes + " - " + viajeRow("Cliente").ToString)
                                End If
                                Dim tablaMetas() As String
                                tablaMetas = Split(tanqRow("Rutas"), " - ")
                                Dim tablaPesos() As String
                                tablaPesos = Split(tanqRow("Pesos"), " - ")
                                If tablaMetas.Length > 1 Then
                                    Dim ConsumoStandar As Double = 0
                                    Dim DistanciaStandar As Double = 0
                                    Dim Validado As Boolean = True
                                    For i As Integer = 0 To tablaMetas.Length - 2
                                        If Validado = False Then Exit For
                                        'If oeRegistroConsumoComb.leZonaD2.Where(Function(z) z.OrigenRuta = tablaMetas(i) And z.DestinoRuta = tablaMetas(i + 1)).Count = 0 Then
                                        '    tanqRow("Piloto") = "No existe la Ruta: " + tablaMetas(i) + "-" + tablaMetas(i + 1)
                                        '    Validado = False
                                        'Else
                                        '    For Each obj In oeRegistroConsumoComb.leZonaD2.Where(Function(z) z.OrigenRuta = tablaMetas(i) And z.DestinoRuta = tablaMetas(i + 1)).OrderBy(Function(y) y.Orden).ToList
                                        '        If obj.Orden = 0 Then
                                        '            tanqRow("Piloto") = "No existe Zona D2, Ruta: " + tablaMetas(i) + "-" + tablaMetas(i + 1)
                                        '            Validado = False
                                        '            Exit For
                                        '        Else
                                        '            If oeRegistroConsumoComb.leRendimiento.Where(Function(y) y.IdTipoVehiculo = vehRow("IdModeloTracto") And y.Peso = tablaPesos(i) And y.IdFlota = obj.IdFlota).Count > 0 Then
                                        '                DistanciaStandar = DistanciaStandar + obj.Kilometros
                                        '                ConsumoStandar = ConsumoStandar + Math.Round(obj.Kilometros / oeRegistroConsumoComb.leRendimiento.Where(Function(y) y.IdTipoVehiculo = vehRow("IdModeloTracto") And y.Peso = tablaPesos(i) And y.IdFlota = obj.IdFlota)(0).Rendimiento, 3)
                                        '            Else
                                        '                tanqRow("Piloto") = "No existe rendimiento, Ruta:" + tablaMetas(i) + "-" + tablaMetas(i + 1) + " , con peso:" + tablaPesos(i)
                                        '                Validado = False
                                        '                Exit For
                                        '            End If
                                        '        End If
                                        '    Next
                                        'End If
                                        If oeRegistroConsumoComb.leRutas.Where(Function(y) y.Origen = tablaMetas(i) And y.Destino = tablaMetas(i + 1)).Count > 0 And Validado = True Then
                                            Dim IdRuta As String = oeRegistroConsumoComb.leRutas.Where(Function(y) y.Origen = tablaMetas(i) And y.Destino = tablaMetas(i + 1))(0).Id
                                            If oeRegistroConsumoComb.leZonaD2.Where(Function(y) y.IdRuta = IdRuta).Count > 0 And Validado = True Then
                                                For Each zona In oeRegistroConsumoComb.leZonaD2.Where(Function(y) y.IdRuta = IdRuta).OrderBy(Function(z) z.Orden).ToList
                                                    If Validado = False Then Exit For
                                                    If zona.Kilometros > -1 Then
                                                        If oeRegistroConsumoComb.leRendimiento.Where(Function(y) y.IdTipoVehiculo = vehRow("IdModeloTracto") And y.Peso = tablaPesos(i) And y.IdFlota = zona.IdFlota).Count > 0 And Validado = True Then
                                                            DistanciaStandar = DistanciaStandar + zona.Kilometros
                                                            ConsumoStandar = ConsumoStandar + Math.Round(zona.Kilometros / oeRegistroConsumoComb.leRendimiento.Where(Function(y) y.IdTipoVehiculo = vehRow("IdModeloTracto") And y.Peso = tablaPesos(i) And y.IdFlota = zona.IdFlota)(0).Rendimiento, 3)
                                                        Else
                                                            Validado = False
                                                            tanqRow("Piloto") = "No existe rendimiento para zona de Ruta:" + tablaMetas(i) + "-" + tablaMetas(i + 1)
                                                        End If
                                                    Else
                                                        Validado = False
                                                        tanqRow("Piloto") = "{" + tablaMetas(i) + "-" + tablaMetas(i + 1) + "}[La zona de metas, no existe como Ruta]"
                                                    End If
                                                Next
                                            Else
                                                'Mensaje de que Viaje no tiene Zonas
                                                Validado = False
                                                tanqRow("Piloto") = "Zonas de Combustible no configuradas, ruta:" + tablaMetas(i) + "-" + tablaMetas(i + 1)
                                            End If
                                        Else
                                            'Mensaje para configurar Viajes
                                            Validado = False
                                            tanqRow("Piloto") = "No existe la Ruta:" + tablaMetas(i) + "-" + tablaMetas(i + 1)
                                        End If
                                    Next
                                    If Validado = True Then
                                        tanqRow("RendEsperado") = Math.Round(DistanciaStandar / ConsumoStandar, 3)
                                        tanqRow("GlsEsperado") = Math.Round(tanqRow("Dist") / tanqRow("RendEsperado"), 2)
                                        tanqRow("Desviacion") = Math.Round(tanqRow("Cons") - tanqRow("GlsEsperado"), 2)
                                    Else
                                        tanqRow("RendEsperado") = "0.0"
                                        tanqRow("GlsEsperado") = "0.0"
                                        tanqRow("Desviacion") = "0.0"
                                    End If
                                    vehRow("Desviacion") = CDbl(vehRow("Desviacion")) + CDbl(tanqRow("Desviacion"))
                                End If
                                vehRow("Cons") = CDbl(vehRow("Cons")) + tanqRow("Cons")
                                vehRow("Dist") = CDbl(vehRow("Dist")) + tanqRow("Dist")
                            Else
                                tanqRow("IdPiloto") = Pilotos + " / " + viajeRow("Piloto") + " / " + viajeRow("CoPiloto")
                                Pilotos = ""
                            End If
                            Metas = ""
                            'Pilotos = dtViaje(0)("Piloto") + " / " + dtViaje(0)("Copiloto")
                            Pesos = ""
                            Clientes = ""
                            Cargas = ""
                            ConsumoGls = 0.0
                            LD = IIf(String.IsNullOrEmpty(Trim(tanqRow("EqOrigen"))), tanqRow("LugTanqueo"), tanqRow("EqOrigen"))
                            SaltoViaje = True
                            dtTanqueoAnterior.Clear()
                            dtTanqueoAnterior.ImportRow(tanqRow)
                        Else
                            ConsumoGls = ConsumoGls + tanqRow("CantidadGls")
                        End If
                    Next
                    If SaltoTanqueo Then
                        If Pilotos <> "" Then
                            Pilotos = Pilotos + " / " + viajeRow("Piloto").ToString + " / " + viajeRow("CoPiloto").ToString
                        Else
                            Pilotos = viajeRow("Piloto").ToString + " / " + viajeRow("CoPiloto").ToString
                        End If
                    End If
                    If LD <> "" And SaltoViaje = False Then
                        If ViajeDestino <> LD Then
                            LD = ViajeDestino
                            Metas = Metas + " - " + LD
                            'Pilotos = Pilotos + " / " + viajeRow("Piloto").ToString + " / " + viajeRow("CoPiloto").ToString
                            Pesos = IIf(Pesos = "", CInt(viajeRow("Peso")).ToString, Pesos + " - " + CInt(viajeRow("Peso")).ToString)
                            Cargas = IIf(Cargas = "", viajeRow("CargaMaterial").ToString, Cargas + " / " + viajeRow("CargaMaterial").ToString)
                            Clientes = IIf(Clientes = "", viajeRow("Cliente").ToString, Clientes + " / " + viajeRow("Cliente").ToString)
                        End If
                    End If
                    dtViajeAnterior.Clear()
                    dtViajeAnterior.ImportRow(viajeRow)
                Next
                dtTanqueoAnterior.Clear()
                dtViajeAnterior.Clear()
                Pilotos = ""
            Next
            ds.AcceptChanges()
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
