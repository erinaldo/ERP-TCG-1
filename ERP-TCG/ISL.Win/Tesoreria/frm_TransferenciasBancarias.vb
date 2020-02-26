'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Microsoft.Office.Interop

Public Class frm_TransferenciasBancarias
    Inherits frm_MenuPadre

#Region "Instancia"

    Private Shared instancia As frm_TransferenciasBancarias = Nothing
    Private Shared Operacion As String
    Private EjercicioBanderaCtaBancari As Integer

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_TransferenciasBancarias()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private leMovimientosBancarios As New List(Of e_MovimientoCajaBanco), olMovimientosBancarios As New l_MovimientoCajaBanco
    Private oeMovimientosBancariosOrigen As New e_MovimientoCajaBanco, oeMovimientosBancariosDestino As New e_MovimientoCajaBanco
    Private oeAsiento As New e_Asiento
    Private leCtaBancaria As New List(Of e_CuentaBancaria)
    Private oeFlujo As New e_FlujoCaja, leFlujo As New List(Of e_FlujoCaja), olFlujo As New l_FlujoCaja, leProcFlujo As New List(Of e_FlujoCaja)
    Private oeCtaCble As New e_CuentaContable, olCtaCble As New l_CuentaContable
    Private leCtaCbleOrigen As New List(Of e_CuentaContable), leCtaCbleDestino As New List(Of e_CuentaContable)
    Private oeTrabajador As New e_Trabajador, olTrabajador As New l_Trabajador, leTrabajador As New List(Of e_Trabajador)
    Private oePrestamo As New e_Prestamo, lePresAnalisis As New List(Of e_Prestamo), leImportaDatos As New List(Of e_Prestamo)
    Private oePeriodo As New e_Periodo, olPerido As New l_Periodo, lePeriodo As New List(Of e_Periodo)
    Private leDscto As New List(Of e_Prestamo), leCuota As New List(Of e_PrestamoDetalle)
    Private leDsctoGrab As New List(Of e_Prestamo), leCuotaGrab As New List(Of e_PrestamoDetalle)
    'Private dtAMFC As Data.DataTable
    Private oeAsientoModel As New e_AsientoModelo, olAsientoModel As New l_AsientoModelo, leAsientoModel As New List(Of e_AsientoModelo)
    Private oeReferencia As New e_AsientoModelo_Referencia, olReferencia As New l_AsientoModelo_Referencia, leReferencia As New List(Of e_AsientoModelo_Referencia)
    Private oeEstado As New e_Estado, olEstado As New l_Estado, leEstado As New List(Of e_Estado)
    Private oeConceptoDscto As New e_Concepto_Prestamo, olConceptoDscto As New l_Concepto_Prestamo, leConceptoDscto As New List(Of e_Concepto_Prestamo)
    Private oeCtaCtble As New e_CuentaContable, olCtaCtble As New l_CuentaContable
    Private leCtaCtble As New List(Of e_CuentaContable), leCCTrab As New List(Of e_CuentaContable)
    Private oeDetalleAM As New e_DetalleAsientoModelo, olDetalleAM As New l_DetalleAsientoModelo, leDetalleAM As New List(Of e_DetalleAsientoModelo)
    Private oeFonPen As New e_FondoPensionTrabajador, olFonPen As New l_FondoPensionTrabajador, leFonPen As New List(Of e_FondoPensionTrabajador)
    Private oeEmpresa As New e_Empresa, olEmpresa As New l_Empresa, leEmpresa As New List(Of e_Empresa)
    Private IndTrabjador As Boolean = False, IdConpcetoDscto As String = String.Empty, IdBanco As String

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            Operacion = "Inicializa"
            Listar(Activo)
            ControlBoton(1, 1, 0, 0, 0, 0, 1, 1, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Inicializar()
        Operacion = "Nuevo"
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
        'mt_Cargar_TurnoActivo()
    End Sub

    Public Overrides Sub Guardar()
        Try
            Operacion = "Inicializa"
            If GuardarMovBancario() Then
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1) 'activa desactiva botonera
            Else
                MostrarTabs(1, tcTransferenciaBancaria)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            Operacion = "Inicializa"
            MostrarTabs(0, tcTransferenciaBancaria)
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1) 'activa desactiva botonera
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Try
            If gridMovimientoBancarios.Rows.Count > 0 Then
                Dim frm As New frm_ImprimeTransferencia(gridMovimientoBancarios.ActiveRow.Cells("Id").Value)
                frm.ShowDialog() : frm = Nothing
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            Select Case tcTransferenciaBancaria.SelectedTab.Index
                Case 0
                    If gridMovimientoBancarios.Rows.Count > 0 Then
                        Exportar_Excel(gridMovimientoBancarios, "Trans_Bancarias")
                    Else
                        Throw New Exception("No hay ningún dato para exportar al Excel")
                    End If
                Case 1
                    If griDetalleAdjunto.Rows.Count > 0 Then
                        Exportar_Excel(griDetalleAdjunto, "Datos_Importar")
                    Else
                        Throw New Exception("No hay ningún dato para exportar al Excel")
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Métodos"

    Private Sub Inicializar()
        Try
            cboMedioPago.SelectedIndex = -1
            cboCuentaCtbleOrigen.SelectedIndex = -1
            cboCuentaBancariaOrigen.SelectedIndex = -1 : cboCuentaBancariaOrigen.Enabled = False
            cboCuentaCtbleDestino.SelectedIndex = -1
            cboCuentaBancariaDestino.SelectedIndex = -1 : cboCuentaBancariaDestino.Enabled = False
            cboTrabajadorOrigen.SelectedIndex = 0 : cboTrabajadorDestino.SelectedIndex = 0
            cboMoneda.SelectedIndex = -1
            chkReposicionCajaChica.Checked = False
            DecImporte.Value = 0
            txtCheque.Value = "" : txtGlosa.Value = "" : IdBanco = String.Empty
            cboTipoMovimiento.SelectedIndex = -1 : cboTipoMovimiento.ReadOnly = True
            cboFlujoCaja.SelectedIndex = -1 : cboFlujoCaja.ReadOnly = True
            cboTrabajadorDestino.Visible = False : cboTrabajadorOrigen.Visible = False
            cboTrabajadorDestino.Enabled = False
            cboCuentaBancariaOrigen.Visible = True : cboCuentaBancariaDestino.Visible = True
            etiOrigen.Text = "Cuenta Contable Origen:" : etiDestino.Text = "Cuenta Contable Destino:"
            etiCtaBanOrigen.Visible = True : etiCtaBanDestino.Visible = True
            oeMovimientosBancariosOrigen = New e_MovimientoCajaBanco : oeMovimientosBancariosOrigen._Operador = -1
            oeMovimientosBancariosDestino = New e_MovimientoCajaBanco : oeMovimientosBancariosDestino._Operador = 1
            oeAsiento = New e_Asiento : oeAsiento.IdUsuarioCrea = gUsuarioSGI.Id
            fecTransf.Value = Date.Now.Date : DecTC.Value = TipoCambio(fecTransf.Value, True)(0)
            IndTrabjador = False : lePresAnalisis = New List(Of e_Prestamo)
            chkDsctoPlanilla.Checked = False : chkDsctoPlanilla.Visible = False
            chkCargaMasiva.Checked = False : chkCargaMasiva.Visible = False
            agrDescuento.Visible = False : nroCuotaDscto.Value = 1 : txtGlosaDscto.Text = String.Empty
            btnImportar.Enabled = False : btnQuitarDatos.Enabled = False : btnValidarDatos.Enabled = False
            etiValidaDatos.Text = String.Empty : btnCobroDeuda.Visible = False
            leDscto = New List(Of e_Prestamo) : leCuota = New List(Of e_PrestamoDetalle)
            leDsctoGrab = New List(Of e_Prestamo) : leCuotaGrab = New List(Of e_PrestamoDetalle)
            leImportaDatos = New List(Of e_Prestamo) : CargarDatosImportados(leImportaDatos)
            MostrarTabs(1, tcTransferenciaBancaria, 1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar(ByVal Activo As Boolean)
        Try
            If ValidarFechaDesde_Hasta(fecInicio, fecFin) Then
                oeMovimientosBancariosOrigen = New e_MovimientoCajaBanco
                oeMovimientosBancariosOrigen.Activo = Activo
                oeMovimientosBancariosOrigen.Fecha = fecInicio.Value
                oeMovimientosBancariosOrigen._FechaFin = fecFin.Value
                oeMovimientosBancariosOrigen.IdCuentaBancaria = cboCtaBancaria.Value
                leMovimientosBancarios.Clear()
                leMovimientosBancarios.AddRange(olMovimientosBancarios.Listar(oeMovimientosBancariosOrigen))
                With gridMovimientoBancarios
                    .DataBind()
                    If .Rows.Count > 0 Then .Focus() : .Rows.Item(0).Selected = True
                End With
                ConfiguraGrilla()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GuardarMovBancario() As Boolean
        Try
            If Validar() Then
                Select Case cboTipoMovimiento.SelectedIndex
                    Case 0 'Cuenta a Cuenta
                        oeMovimientosBancariosOrigen.PrefijoID = gs_PrefijoIdSucursal '@0001
                        oeMovimientosBancariosDestino.PrefijoID = gs_PrefijoIdSucursal '@0001
                        oeAsiento.PrefijoID = gs_PrefijoIdSucursal '@0001
                        If Me.cboMedioPago.Text = "EFECTIVO" Then
                            If olMovimientosBancarios.GuardarTranferencia(oeMovimientosBancariosOrigen, oeMovimientosBancariosDestino, oeAsiento, chkReposicionCajaChica.Checked) Then
                                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente", True)
                                MostrarTabs(0, tcTransferenciaBancaria, 2)
                                Dim frm As New frm_ImprimeTransferencia(oeMovimientosBancariosOrigen.Id)
                                frm.ShowDialog() : frm = Nothing
                                ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
                                Consultar(True)
                                Return True
                            End If
                        Else
                            If olMovimientosBancarios.GuardarTranferencia(oeMovimientosBancariosOrigen, oeMovimientosBancariosDestino, oeAsiento, chkReposicionCajaChica.Checked) Then
                                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente", True)
                                MostrarTabs(0, tcTransferenciaBancaria, 2)
                                Dim frm As New frm_ImprimeTransferencia(oeMovimientosBancariosOrigen.Id)
                                frm.ShowDialog() : frm = Nothing
                                ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
                                Consultar(True)
                                Return True
                            End If
                        End If
                    Case 1 ' Egreso de la Cuenta
                        If Me.cboMedioPago.Text = "EFECTIVO" Then
                            If IndTrabjador Then
                                lePresAnalisis = New List(Of e_Prestamo)
                                If cboTrabajadorDestino.Enabled Then If cboTrabajadorDestino.Value.ToString.Trim.Length = 0 Then Throw New Exception("Seleccion de Trabajador Destino")
                                Dim _oeAux = cboTrabajadorDestino.Items(cboTrabajadorDestino.SelectedIndex).ListObject
                                lePresAnalisis.Add(New e_Prestamo With {.Id = _oeAux.IdEstadoCivil, .IdTrabajador = _oeAux.Id, ._MontoAux = _oeAux.CantidadRef, .Trabajador = _oeAux.NombreCompleto})
                            End If
                            If oeAsientoModel.Id.Trim.Length = 0 Then Throw New Exception("No se ha Seleccionado un Flujo de Caja Pre-Configurado Contablemente")
                            oeAsientoModel.TipoOperacion = "" : oeAsientoModel.Ejercicio = fecTransf.Value.Year
                            oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                            oeMovimientosBancariosOrigen = New e_MovimientoCajaBanco
                            With oeMovimientosBancariosOrigen
                                .TipoOperacion = "I" : .IdMedioPago = cboMedioPago.Value : ._Operador = -1 : .Fecha = fecTransf.Value
                                '.IdCuentaBancaria = cboCuentaBancariaOrigen.Value
                                ._IdCuentaContable = cboCuentaCtbleOrigen.Value
                                .NroBoucher = txtCheque.Text : .IdFlujoCaja = cboFlujoCaja.Value : .TipoCambio = DecTC.Value
                                .TotalMN = ndSoles.Value : .TotalME = ndDolares.Value : .UsuarioCreacion = gUsuarioSGI.Id
                                .IdPeriodoCtble = CalculaPeriodo(.Fecha) : .Activo = True
                                .IdCaja = cboCuentaBancariaOrigen.Value
                            End With
                            oeMovimientosBancariosOrigen.PrefijoID = gs_PrefijoIdSucursal '@0001
                            oeAsientoModel.PrefijoID = gs_PrefijoIdSucursal '@0001
                            If olMovimientosBancarios.GuardarTransBancaria(oeMovimientosBancariosOrigen, oeAsientoModel, lePresAnalisis, chkDsctoPlanilla.Checked) Then
                                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente", True)
                                MostrarTabs(0, tcTransferenciaBancaria, 2)
                                ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
                                Consultar(True)
                                Return True
                            End If
                        Else
                            If IndTrabjador Then
                                lePresAnalisis = New List(Of e_Prestamo)
                                If cboTrabajadorDestino.Enabled Then
                                    If cboTrabajadorDestino.Value.ToString.Trim.Length = 0 Then Throw New Exception("Seleccion de Trabajador Destino")
                                    CargarPrestamo()
                                Else
                                    Dim _leValAux = leImportaDatos.Where(Function(it) it.Activo = False).ToList
                                    If _leValAux.Count > 0 Then Throw New Exception(etiValidaDatos.Text)
                                    lePresAnalisis = leImportaDatos
                                End If
                            End If
                            If oeAsientoModel.Id.Trim.Length = 0 Then Throw New Exception("No se ha Seleccionado un Flujo de Caja Pre-Configurado Contablemente")
                            oeAsientoModel.TipoOperacion = "" : oeAsientoModel.Ejercicio = fecTransf.Value.Year
                            oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                            oeMovimientosBancariosOrigen = New e_MovimientoCajaBanco
                            With oeMovimientosBancariosOrigen
                                .TipoOperacion = "I" : .IdMedioPago = cboMedioPago.Value : ._Operador = -1 : .Fecha = fecTransf.Value
                                .IdCuentaBancaria = cboCuentaBancariaOrigen.Value : ._IdCuentaContable = cboCuentaCtbleOrigen.Value
                                .NroBoucher = txtCheque.Text : .IdFlujoCaja = cboFlujoCaja.Value : .TipoCambio = DecTC.Value
                                .TotalMN = ndSoles.Value : .TotalME = ndDolares.Value : .UsuarioCreacion = gUsuarioSGI.Id
                                .IdPeriodoCtble = CalculaPeriodo(.Fecha) : .Activo = True
                            End With
                            oeMovimientosBancariosOrigen.PrefijoID = gs_PrefijoIdSucursal '@0001
                            oeAsientoModel.PrefijoID = gs_PrefijoIdSucursal '@0001
                            If olMovimientosBancarios.GuardarTransBancaria(oeMovimientosBancariosOrigen, oeAsientoModel, lePresAnalisis, chkDsctoPlanilla.Checked) Then
                                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente", True)
                                MostrarTabs(0, tcTransferenciaBancaria, 2)
                                ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
                                Consultar(True)
                                Return True
                            End If
                        End If
                    Case 2 ' Ingreso a la Cuenta
                        leDsctoGrab = leDscto.Where(Function(it) it.TipoOperacion <> "").ToList
                        If leDsctoGrab.Count = 0 Then Throw New Exception("No se ha aplicado los Cobros." & Environment.NewLine & "Haga Clic en 'Cobrar Dscto'")
                        leCuotaGrab = leCuota.Where(Function(it) it.TipoOperacion <> "").ToList
                        If IndTrabjador Then
                            lePresAnalisis = New List(Of e_Prestamo)
                            If cboTrabajadorOrigen.Enabled Then
                                If cboTrabajadorOrigen.Value.ToString.Trim.Length = 0 Then Throw New Exception("Seleccion de Trabajador Origen")
                                lePresAnalisis = CargarAnalisis(leCuotaGrab)
                            End If
                        End If
                        If oeAsientoModel.Id.Trim.Length = 0 Then Throw New Exception("No se ha Seleccionado un Flujo de Caja Pre-Configurado Contablemente")
                        oeAsientoModel.TipoOperacion = "" : oeAsientoModel.Ejercicio = fecTransf.Value.Year
                        oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                        oeMovimientosBancariosDestino = New e_MovimientoCajaBanco
                        With oeMovimientosBancariosDestino
                            .TipoOperacion = "I" : .IdMedioPago = cboMedioPago.Value : ._Operador = 1 : .Fecha = fecTransf.Value
                            .IdCuentaBancaria = cboCuentaBancariaDestino.Value : ._IdCuentaContable = cboCuentaCtbleDestino.Value
                            .NroBoucher = txtCheque.Text : .IdFlujoCaja = cboFlujoCaja.Value : .TipoCambio = DecTC.Value
                            .TotalMN = ndSoles.Value : .TotalME = ndDolares.Value : .UsuarioCreacion = gUsuarioSGI.Id
                            .IdPeriodoCtble = CalculaPeriodo(.Fecha) : .Activo = True
                        End With
                        oeMovimientosBancariosDestino.PrefijoID = gs_PrefijoIdSucursal '@0001
                        oeAsientoModel.PrefijoID = gs_PrefijoIdSucursal '@0001
                        If olMovimientosBancarios.GuardarTransBancaria2(oeMovimientosBancariosDestino, oeAsientoModel, lePresAnalisis, leDsctoGrab, leCuotaGrab) Then
                            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente", True)
                            MostrarTabs(0, tcTransferenciaBancaria, 2)
                            ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
                            Consultar(True)
                            Return True
                        End If
                End Select
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Validar() As Boolean
        Try
            ValidarCombo(cboMedioPago, "Medio de Transferencia")
            ValidarCombo(cboMoneda, "moneda")
            l_FuncionesGenerales.ValidarNumero(DecTC.Value, "Tipo de Cambio")
            Select Case cboTipoMovimiento.SelectedIndex
                Case 0
                    ValidarCombo(cboCuentaCtbleOrigen, "Cuenta contable origen")
                    If cboCuentaBancariaOrigen.Enabled Then ValidarCombo(cboCuentaBancariaOrigen, "Cuenta bancaria origen")
                    ValidarCombo(cboCuentaCtbleDestino, "Cuenta contable Destino")
                    If cboCuentaBancariaDestino.Enabled Then ValidarCombo(cboCuentaBancariaDestino, "Cuenta bancaria Destino")
                Case 1
                    ValidarCombo(cboCuentaCtbleOrigen, "Cuenta contable origen")
                    If cboCuentaBancariaOrigen.Enabled Then ValidarCombo(cboCuentaBancariaOrigen, "Cuenta bancaria origen")
                Case 2
                    ValidarCombo(cboCuentaCtbleDestino, "Cuenta contable Destino")
                    If cboCuentaBancariaDestino.Enabled Then ValidarCombo(cboCuentaBancariaDestino, "Cuenta bancaria Destino")
            End Select
            l_FuncionesGenerales.ValidarNumero(DecImporte.Value, "Ingrese Importe")
            l_FuncionesGenerales.ValidarCampoNoNulo(txtCheque.Text, "Ingrese el Nro de Documento / Cheque")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Mostrar()
        'Try
        '    If grid_ListaPeriodo.ActiveRow.Cells("ID").Value.ToString.Length > 0 Then
        '        oeEjercicio = New e_Periodo
        '        oeEjercicio.Id = grid_ListaPeriodo.ActiveRow.Cells("Id").Value.ToString
        '        oeEjercicio = olEjercicio.Obtener(oeEjercicio)
        '        txtCodigo.Text = oeEjercicio.Codigo
        '        nroEjercicio.Año = oeEjercicio.Ejercicio
        '        nroMes.Mes = oeEjercicio.Mes
        '        fecInicio.Value = oeEjercicio.FechaInicio
        '        fecFin.Value = oeEjercicio.FechaFin
        '        VerAlmacen.Checked = oeEjercicio.CierreAlmacen
        '        verCompras.Checked = oeEjercicio.CierreCompras
        '        verContabilidad.Checked = oeEjercicio.CierreContabilidad
        '        verTesoreria.Checked = oeEjercicio.CierreTesoreria
        '        verVentas.Checked = oeEjercicio.CierraVentas
        '        decTCCompra.Value = oeEjercicio.CambioCompra
        '        decTCVenta.Value = oeEjercicio.CambioVenta
        '        verActivo.Checked = oeEjercicio.Activo
        '        verActivo.Visible = Not oeEjercicio.Activo
        '    End If
        'Catch ex As Exception
        '    mensajeEmergente.Problema(ex.Message)
        'End Try
    End Sub

    Private Sub CargaMaestros()
        Try
            FlujoCaja()
            CuentaBancaria()
            MedioPago()
            CuentaContable()
            ComboMoneda()
            Trabajador()
            AsientoModelo()
            CtaCtble()
            ConceptoDscto()
            Estado()
            FondoPension()
            CargarBancos()
            'dtAMFC = GenerarDTConfigurable(CargarCTCD("AsientoModelo_FlujoCaja"))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboMoneda()
        Try
            Dim oeMoneda As New e_Moneda
            Dim olMoneda As New l_Moneda
            Dim leMoneda As New List(Of e_Moneda)
            oeMoneda.Activo = True
            leMoneda.AddRange(olMoneda.Listar(oeMoneda))
            With cboMoneda
                .DisplayMember = "Nombre"
                .ValueMember = "Id"
                .DataSource = leMoneda
            End With
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub FlujoCaja()
        Try
            oeFlujo = New e_FlujoCaja
            oeFlujo.Activo = True
            leFlujo.AddRange(olFlujo.Listar(oeFlujo))
            '--------------------- para llenar combo en grilla    
            With gridMovimientoBancarios.DisplayLayout
                If .Bands(0).Columns.Exists("IdFlujoCaja") Then
                    .ValueLists.Clear()
                    .ValueLists.Add("IdFlujoCaja")
                End If
            End With
            With gridMovimientoBancarios.DisplayLayout.ValueLists("IdFlujoCaja").ValueListItems
                .Clear()
                For Each oeTD As e_FlujoCaja In leFlujo
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdFlujoCaja", "Nombre", gridMovimientoBancarios, True)
            '------------------------------------------
            oeFlujo = New e_FlujoCaja
            oeFlujo.Activo = True
            oeFlujo.TipoOperacion = "P"
            oeFlujo.NombProceso = "TRANSFERENCIAS BANCARIAS"
            leProcFlujo = olFlujo.Listar(oeFlujo)
            'LlenarCombo(cboFlujoCaja, "Nombre", leProcFlujo, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CuentaBancaria()
        Try
            'If cboCtaBancaria.Items.Count = 0 Then
            Dim oeCtaBancaria As New e_CuentaBancaria
            Dim olCtaBancaria As New l_CuentaBancaria
            oeCtaBancaria.Activo = True
            oeCtaBancaria.Ejercicio = Date.Parse(fecTransf.Value).Year
            oeCtaBancaria.TipoOperacion = "C"
            leCtaBancaria.AddRange(olCtaBancaria.Listar(oeCtaBancaria))
            '--------------------- para llenar combo en grilla    
            With gridMovimientoBancarios.DisplayLayout
                If .Bands(0).Columns.Exists("IdCuentaBancaria") Then
                    .ValueLists.Clear()
                    .ValueLists.Add("IdCuentaBancaria")
                End If
            End With
            With gridMovimientoBancarios.DisplayLayout.ValueLists("IdCuentaBancaria").ValueListItems
                .Clear()
                For Each oeTD As e_CuentaBancaria In leCtaBancaria
                    .Add(oeTD.Id, oeTD.NumeroCuenta)
                Next
            End With
            CrearComboGrid3("IdCuentaBancaria", "NumeroCuenta", gridMovimientoBancarios, True)
            '------------------------------------------
            With cboCtaBancaria
                .ValueMember = "Id"
                .DisplayMember = "BancoCuenta"
                .DataSource = leCtaBancaria
            End With
            'End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MedioPago()
        Try
            Dim oeMedioPago As New e_MedioPago
            Dim olMedioPago As New l_MedioPago
            Dim leMedioPago As New List(Of e_MedioPago)
            oeMedioPago.Activo = True
            leMedioPago.AddRange(olMedioPago.Listar(oeMedioPago))
            '--------------------- para llenar combo en grilla    
            With gridMovimientoBancarios.DisplayLayout
                If .Bands(0).Columns.Exists("IdMedioPago") Then
                    .ValueLists.Clear()
                    .ValueLists.Add("IdMedioPago")
                End If
            End With
            With gridMovimientoBancarios.DisplayLayout.ValueLists("IdMedioPago").ValueListItems
                .Clear()
                For Each oeTD As e_MedioPago In leMedioPago
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdMedioPago", "Nombre", gridMovimientoBancarios, True)
            '------------------------------------------
            With cboMedioPago
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = leMedioPago
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CuentaContable()

        oeCtaCble = New e_CuentaContable
        oeCtaCble.Activo = True
        oeCtaCble.Movimiento = 1
        oeCtaCble.FlujoCaja = 1
        oeCtaCble.Ejercicio = Date.Parse(fecTransf.Value).Year
        leCtaCbleOrigen.AddRange(olCtaCble.Listar(oeCtaCble))
        leCtaCbleDestino = leCtaCbleOrigen.ToList

    End Sub

    Private Sub Estado()
        oeEstado = New e_Estado
        oeEstado.Activo = True
        oeEstado.Nombre = ""
        leEstado = olEstado.Listar(oeEstado)
    End Sub

    Private Sub ConceptoDscto()
        oeConceptoDscto = New e_Concepto_Prestamo
        oeConceptoDscto.Tipo = 1 : oeConceptoDscto.Activo = 1 : oeConceptoDscto.TipoOperacion = String.Empty
        leConceptoDscto = olConceptoDscto.Listar(oeConceptoDscto)
    End Sub

    Private Sub AsientoModelo()
        oeAsientoModel = New e_AsientoModelo
        oeAsientoModel.TipoOperacion = "A" : oeAsientoModel.Activo = True : oeAsientoModel.Nombre = pIdActividadNegocio
        leAsientoModel = olAsientoModel.Listar(oeAsientoModel)
        oeDetalleAM = New e_DetalleAsientoModelo
        oeDetalleAM.TipoOperacion = "A" : oeDetalleAM.Activo = True : oeDetalleAM.Formula = pIdActividadNegocio
        leDetalleAM = olDetalleAM.Listar(oeDetalleAM)
        oeReferencia = New e_AsientoModelo_Referencia
        oeReferencia.TipoOperacion = "N" : oeReferencia.Activo = True : oeReferencia.IdReferencia = pIdActividadNegocio
        leReferencia = olReferencia.Listar(oeReferencia)
    End Sub

    Private Sub CtaCtble()
        oeCtaCtble = New e_CuentaContable
        oeCtaCtble.TipoOperacion = "N"
        oeCtaCtble.Activo = True : oeCtaCtble.Ejercicio = Date.Now.Year
        leCtaCtble = olCtaCtble.Listar(oeCtaCtble).OrderBy(Function(it) it.Nombre).ToList
        leCCTrab = leCtaCtble.Where(Function(it) it.Trabajador = 1).ToList
    End Sub

    Private Sub FondoPension()
        oeFonPen = New e_FondoPensionTrabajador
        oeFonPen.TipoOperacion = "" : oeFonPen.Activo = True : oeFonPen.Vigente = 1 : oeFonPen.Mixta = -1
        leFonPen = olFonPen.Listar(oeFonPen)
    End Sub

    Private Sub CargarBancos()
        oeEmpresa = New e_Empresa
        oeEmpresa.TipoOperacion = "" : oeEmpresa.Activo = True
        leEmpresa = olEmpresa.Listar(oeEmpresa).Where(Function(it) it.TipoEmpresa = "ENTIDADES FINANCIERAS").ToList
    End Sub

    Private Sub CuentaBancariaSegunCta(ByVal Combo As Infragistics.Win.UltraWinEditors.UltraComboEditor, _
    ByVal IndMonedaExtrangera As Integer, ByVal lsCta As String)
        Dim leCtaBanc As New List(Of e_CuentaBancaria)
        If IndMonedaExtrangera = 0 Then
            leCtaBanc = leCtaBancaria.Where(Function(item) item.IdMoneda = "1CH01" And item.IdCuentaContable = lsCta).ToList
        Else
            leCtaBanc = leCtaBancaria.Where(Function(item) item.IdMoneda <> "1CH01" And item.IdCuentaContable = lsCta).ToList
        End If
        If leCtaBanc.Count > 0 Then
            Combo.Enabled = True
            With Combo
                .ValueMember = "Id"
                .DisplayMember = "BancoCuenta"
                .DataSource = leCtaBanc
            End With
        Else
            Combo.SelectedIndex = -1
            Combo.Enabled = False
        End If

    End Sub

    Private Sub Montos()
        If cboMoneda.Text = "SOLES" Then
            ndSoles.Value = DecImporte.Value : ndDolares.Value = DecImporte.Value / DecTC.Value
            oeMovimientosBancariosOrigen.TotalMN = DecImporte.Value : oeMovimientosBancariosOrigen.TotalME = DecImporte.Value / DecTC.Value
            oeMovimientosBancariosDestino.TotalMN = DecImporte.Value : oeMovimientosBancariosDestino.TotalME = DecImporte.Value / DecTC.Value
        Else
            ndSoles.Value = DecImporte.Value * DecTC.Value : ndDolares.Value = DecImporte.Value
            oeMovimientosBancariosOrigen.TotalMN = DecImporte.Value * DecTC.Value : oeMovimientosBancariosOrigen.TotalME = DecImporte.Value
            oeMovimientosBancariosDestino.TotalMN = DecImporte.Value * DecTC.Value : oeMovimientosBancariosDestino.TotalME = DecImporte.Value
        End If
    End Sub

    Private Sub ConfiguraGrilla()
        Try
            With gridMovimientoBancarios
                .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("IdFlujoCaja").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("IdMedioPago").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("IdCuentaBancaria").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("NroBoucher").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Glosa").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("TotalMN").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("TotalME").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("Usuario").Header.VisiblePosition = 8
                .DisplayLayout.Bands(0).Columns("Fecha").Width = 75
                .DisplayLayout.Bands(0).Columns("IdFlujoCaja").Width = 220
                .DisplayLayout.Bands(0).Columns("IdMedioPago").Width = 160
                .DisplayLayout.Bands(0).Columns("IdCuentaBancaria").Width = 130
                .DisplayLayout.Bands(0).Columns("Glosa").Width = 300
                FormatoColumna(gridMovimientoBancarios, "#,##0.00", ColumnStyle.Double, HAlign.Right, "TotalMN", "TotalME")
                OcultarColumna(gridMovimientoBancarios, True, "Seleccion")
                .DisplayLayout.Bands(0).Columns("TotalMN").Header.Caption = "Total S/."
                .DisplayLayout.Bands(0).Columns("TotalME").Header.Caption = "Total $."
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End With
            CalcularTotales(gridMovimientoBancarios, "TotalMN", "TotalME")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Trabajador()
        Try
            Dim leTrabOri As New List(Of e_Trabajador)
            Dim leTrabDes As New List(Of e_Trabajador)
            oeTrabajador = New e_Trabajador
            oeTrabajador.Id = ""
            oeTrabajador.oePersona.ApellidoPaterno = "NINGUNO"
            leTrabOri.Add(oeTrabajador) : leTrabDes.Add(oeTrabajador)
            oeTrabajador = New e_Trabajador
            oeTrabajador.TipoOperacion = "N"
            leTrabajador = olTrabajador.Listar(oeTrabajador)
            leTrabOri.AddRange(leTrabajador.OrderBy(Function(it) it.oePersona.NombreCompleto).ToList)
            leTrabDes.AddRange(leTrabajador.OrderBy(Function(it) it.oePersona.NombreCompleto).ToList)
            Dim _leTOAux = From le In leTrabOri Select le.Id, le.oePersona.NombreCompleto
            Dim _leTDAux = From le In leTrabOri Select le.Id, le.oePersona.NombreCompleto
            LlenarCombo(cboTrabajadorOrigen, "NombreCompleto", _leTOAux.ToList, 0)
            LlenarCombo(cboTrabajadorDestino, "NombreCompleto", _leTDAux.ToList, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function CalculaPeriodo(fechaMov As Date) As String
        Try
            Dim _idPerido As String = ""
            oePeriodo = New e_Periodo
            oePeriodo.Activo = True
            oePeriodo.Id = String.Empty
            oePeriodo.Codigo = fechaMov.Year.ToString & "-" & fechaMov.Month.ToString
            lePeriodo.AddRange(olPerido.Listar(oePeriodo))
            If lePeriodo.Count > 0 Then _idPerido = lePeriodo(0).Id
            Return _idPerido
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub cboTrabajadorDestino_ValueChanged(sender As Object, e As EventArgs) Handles cboTrabajadorDestino.ValueChanged
        If cboTrabajadorDestino.Enabled Then
            If cboFlujoCaja.Text = gFCPH Then
                Dim _oeAux = cboTrabajadorDestino.Items(cboTrabajadorDestino.SelectedIndex).ListObject
                DecImporte.Value = _oeAux.CantidadRef
            End If
        End If
    End Sub

    Private Sub CargarCuentaContable()
        Dim obj As New e_Moneda
        obj = cboMoneda.Items(cboMoneda.SelectedIndex).ListObject
        EtiImporte.Text = "Importe " & obj.Abreviatura
        oeAsiento.IdMoneda = cboMoneda.Value
        Dim _leOriAux = New List(Of e_CuentaContable)
        Dim _leDesAux = New List(Of e_CuentaContable)
        If obj.Codigo = "1" Then
            _leOriAux = leCtaCbleOrigen.Where(Function(it) Not it.Nombre.Contains("M.E.")).ToList
            _leDesAux = leCtaCbleDestino.Where(Function(it) Not it.Nombre.Contains("M.E.")).ToList
        Else
            _leOriAux = leCtaCbleOrigen.Where(Function(it) it.Nombre.Contains("M.E.")).ToList
            _leDesAux = leCtaCbleDestino.Where(Function(it) it.Nombre.Contains("M.E.")).ToList
        End If
        LlenarCombo(cboCuentaCtbleOrigen, "Nombre", _leOriAux, -1)
        LlenarCombo(cboCuentaCtbleDestino, "Nombre", _leDesAux, -1)
    End Sub

    Private Sub CargarPrestamo()
        Try
            oePrestamo = New e_Prestamo
            oePrestamo.TipoOperacion = "I" : oePrestamo.Activo = True
            oePrestamo.CantidadCuotas = nroCuotaDscto.Value
            oePrestamo.Glosa = txtGlosaDscto.Text.Trim
            oePrestamo.UsuarioCreacion = gUsuarioSGI.Id : oePrestamo.UsuarioAprueba = gUsuarioSGI.Id
            oePrestamo.Fecha = fecTransf.Value : oePrestamo.FechaAprueba = fecTransf.Value : oePrestamo.Cancelado = 0
            oePrestamo.IdConcepto = IdConpcetoDscto
            If cboTrabajadorOrigen.Visible Then oePrestamo.IdTrabajador = cboTrabajadorOrigen.Value : oePrestamo.Trabajador = cboTrabajadorOrigen.Text
            If cboTrabajadorDestino.Visible Then oePrestamo.IdTrabajador = cboTrabajadorDestino.Value : oePrestamo.Trabajador = cboTrabajadorDestino.Text
            oePrestamo.Monto = ndSoles.Value : oePrestamo.Saldo = ndSoles.Value : oePrestamo._MontoAux = DecImporte.Value
            If cboTrabajadorDestino.Visible Then oePrestamo.IdCtaBancaria = cboCuentaBancariaOrigen.Value
            If cboTrabajadorOrigen.Visible Then oePrestamo.IdCtaBancaria = cboCuentaBancariaDestino.Value
            Dim _leEstAux = leEstado.Where(Function(it) it.Nombre = gNombreEstadoAprobada).ToList
            If _leEstAux.Count > 0 Then oePrestamo.IdEstado = _leEstAux(0).Id
            ''''''generar cuotas
            Dim fechaServidor As Date
            Dim olPlanilla As New l_Planilla
            Dim ListaPlanilla As New List(Of e_Planilla)
            Dim oePlanilla As New e_Planilla
            Dim mescuota As Integer = 0
            ListaPlanilla = olPlanilla.Listar(oePlanilla)
            fechaServidor = ObtenerFechaServidor()
            Dim listaplanillaaux = ListaPlanilla.Where(Function(x) x.Ejercicio = fechaServidor.Year And x.NroMes = fechaServidor.Month)
            If listaplanillaaux.Count > 0 Then 'existe planilla con la fecha actual
                If fechaServidor > listaplanillaaux(0).FechaFin Then mescuota = 1 'si ya paso al cierre de planilla
            End If
            Dim _FecCuota As Date = #1/1/1901#
            _FecCuota = DateAdd(DateInterval.Month, mescuota, Date.Parse("01/" & fechaServidor.Month & "/" & fechaServidor.Year))
            oePrestamo.leDetalle = GenerarCuotas(oePrestamo.Monto, _FecCuota, oePrestamo.CantidadCuotas)
            ''''''''''''''
            oePrestamo.PrefijoID = gs_PrefijoIdSucursal '@0001
            lePresAnalisis.Add(oePrestamo)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function CargarAnalisis(leCPAux As List(Of e_PrestamoDetalle)) As List(Of e_Prestamo)
        Try
            Dim leAnaRet As New List(Of e_Prestamo)
            If leCPAux.Count > 0 Then
                For Each oeCPAux In leCuotaGrab
                    oeCPAux.PrefijoID = gs_PrefijoIdSucursal '@0001
                    oeCPAux.Glosa = cboMedioPago.Text & ", Periodo: " & FormatoDocumento(fecTransf.Value.Month, 2) & "/" &
                FormatoDocumento(fecTransf.Value.Year, 4) & ", Monto: " & DecImporte.Value & " " & cboMoneda.Text &
                    " EN " & IdBanco & " OP:" & txtCheque.Text
                Next
                Dim _leCA = leCPAux.Where(Function(it) it.IndProv = "A").ToList
                If _leCA.Count > 0 Then
                    oePrestamo = New e_Prestamo
                    oePrestamo.IndProv = "A" : oePrestamo.IdTrabajador = cboTrabajadorOrigen.Value : oePrestamo.Trabajador = cboTrabajadorOrigen.Text
                    oePrestamo.Monto = _leCA.Sum(Function(it) it.Importe)
                    oePrestamo.PrefijoID = gs_PrefijoIdSucursal '@0001
                    leAnaRet.Add(oePrestamo)
                End If
                Dim _leCB = leCPAux.Where(Function(it) it.IndProv = "B").ToList
                If _leCB.Count > 0 Then
                    oePrestamo = New e_Prestamo
                    oePrestamo.IndProv = "B" : oePrestamo.IdTrabajador = cboTrabajadorOrigen.Value : oePrestamo.Trabajador = cboTrabajadorOrigen.Text
                    oePrestamo.Monto = _leCB.Sum(Function(it) it.Importe)
                    oePrestamo.PrefijoID = gs_PrefijoIdSucursal '@0001
                    leAnaRet.Add(oePrestamo)
                End If
            End If
            Return leAnaRet
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub CargarDatosImportados(leDI As List(Of e_Prestamo))
        Try
            With griDetalleAdjunto
                .ResetDisplayLayout()
                .DataSource = leDI
                .Text = "Detalle de Pago por Trabajador"
                OcultarColumna(griDetalleAdjunto, True, "Id", "Fecha", "IdTrabajador", "Saldo", "Cancelado", "CantidadCuotas", "Concepto",
                               "FechaCancelado", "FechaCreacion", "FechaIntegracion", "FechaAprueba", "Estado", "GlosaCancelado", "IdConcepto",
                               "IdCtaBancaria", "IdEstado", "UsuarioAprueba", "UsuarioCreacion")
                ExcluirColumna(griDetalleAdjunto, "Id", "Fecha", "IdTrabajador", "Saldo", "Cancelado", "CantidadCuotas", "Concepto",
                               "FechaCancelado", "FechaCreacion", "FechaIntegracion", "FechaAprueba", "Estado", "GlosaCancelado", "IdConcepto",
                               "IdCtaBancaria", "IdEstado", "UsuarioAprueba", "UsuarioCreacion")
                .DisplayLayout.Bands(0).Columns("Glosa").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("Trabajador").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Monto").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Glosa").Width = 150
                .DisplayLayout.Bands(0).Columns("Trabajador").Width = 300
                .DisplayLayout.Bands(0).Columns("Glosa").Header.Caption = "CUSSP"
                .DisplayLayout.Bands(0).Columns("Activo").Header.Caption = "OK"
                FormatoColumna(griDetalleAdjunto, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Monto")
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End With
            CalcularTotales(griDetalleAdjunto, "Monto")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarCajas(ByVal Combo As Infragistics.Win.UltraWinEditors.UltraComboEditor, ByVal IndMonedaExtrangera As Integer, ByVal lsCta As String, Optional _flag As Boolean = False)
        Dim leCaja As New List(Of e_Caja)
        Dim olCaja As New l_Caja
        If IndMonedaExtrangera = 0 Then
            If _flag Then
                Dim _oeCajaUsuario As e_CajaUsuario
                _oeCajaUsuario = BuscarCajaUsuario(gUsuarioSGI.IdTrabajador)
                Dim _oecaja As e_Caja, _olcaja As New l_Caja
                _oecaja = _olcaja.Obtener(New e_Caja With {.Id = _oeCajaUsuario.IdCaja})
                If _oecaja.Id.Trim <> "" Then
                    leCaja.Add(_oecaja)
                Else
                    leCaja = olCaja.Listar(New e_Caja With {.Tipooperacion = "", .Activo = True})
                End If
            Else
                leCaja = olCaja.Listar(New e_Caja With {.Tipooperacion = "", .Activo = True})
            End If
            'leCtaBanc = leCtaBancaria.Where(Function(item) item.IdMoneda = "1CH01" And item.IdCuentaContable = lsCta).ToList
        Else
            ' leCtaBanc = leCtaBancaria.Where(Function(item) item.IdMoneda <> "1CH01" And item.IdCuentaContable = lsCta).ToList
        End If
        If leCaja.Count > 0 Then
            Combo.Enabled = True
            With Combo
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = leCaja
            End With
        Else
            Combo.SelectedIndex = -1
            Combo.Enabled = False
        End If
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_TransferenciasBancarias_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case tcTransferenciaBancaria.SelectedTab.Index
            Case 0
                If gridMovimientoBancarios.Rows.Count > 0 Then
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
        End Select
    End Sub

    Private Sub frm_TransferenciasBancarias_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_TransferenciasBancarias_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case _Operacion
            Case "Nuevo"
                Me.Activate()
                Me.Cancelar()

            Case "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_TransferenciasBancarias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gmt_ConfigurarEventoKeyEnter_Tab(Me)
            gf_AsignarEventoSeleccionarTexto(Me)
            MostrarTabs(0, tcTransferenciaBancaria)
            gridMovimientoBancarios.DataSource = leMovimientosBancarios
            CargaMaestros()
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
            fecInicio.Value = Date.Now.Date : fecFin.Value = Date.Now.Date
            EjercicioBanderaCtaBancari = Date.Parse(fecTransf.Value).Year
            ConfiguraGrilla()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboMedioPago_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMedioPago.ValueChanged
        If cboMedioPago.SelectedIndex > -1 Then
            oeMovimientosBancariosOrigen.IdMedioPago = cboMedioPago.Value
            oeMovimientosBancariosDestino.IdMedioPago = cboMedioPago.Value
            Dim obj As New e_MedioPago
            obj = cboMedioPago.Items(cboMedioPago.SelectedIndex).ListObject
            oeAsiento.IdTipoAsiento = obj.IdTipoAsiento
            cboTipoMovimiento.SelectedIndex = -1
            Select Case obj.Codigo
                Case "001"
                    cboTipoMovimiento.ReadOnly = True
                    cboTipoMovimiento.Items.Clear()
                    cboTipoMovimiento.Items.Add("ENTRE CUENTAS PROPIAS")
                    cboTipoMovimiento.Items.Add("EGRESO DE LA CUENTA")
                    cboTipoMovimiento.Items.Add("INGRESO A LA CUENTA")
                    cboTipoMovimiento.SelectedIndex = 2
                Case "003", "007"
                    cboTipoMovimiento.ReadOnly = False
                    cboTipoMovimiento.Items.Clear()
                    cboTipoMovimiento.Items.Add("ENTRE CUENTAS PROPIAS")
                    cboTipoMovimiento.Items.Add("EGRESO DE LA CUENTA")
                    cboTipoMovimiento.SelectedIndex = 0
                Case "008"
                    cboTipoMovimiento.ReadOnly = False
                    cboTipoMovimiento.Items.Clear()
                    cboTipoMovimiento.Items.Add("ENTRE CUENTAS PROPIAS")
                    cboTipoMovimiento.Items.Add("EGRESO DE LA CUENTA")
                    cboTipoMovimiento.SelectedIndex = 0
                Case Else
                    cboTipoMovimiento.ReadOnly = True
            End Select
        End If
    End Sub

    Private Sub cboCuentaCtbleOrigen_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuentaCtbleOrigen.ValueChanged
        oeMovimientosBancariosOrigen._IdCuentaContable = cboCuentaCtbleOrigen.Value
        Dim i As Integer = cboCuentaCtbleOrigen.SelectedIndex
        If i >= 0 Then
            Dim obj As New e_CuentaContable
            obj = cboCuentaCtbleOrigen.Items(i).ListObject
            If obj.Cuenta = "10111" Then
                mt_CargarCajas(Me.cboCuentaBancariaOrigen, obj.MonedaExtranjera, obj.Cuenta, True) '10111
            Else
                CuentaBancariaSegunCta(cboCuentaBancariaOrigen, obj.MonedaExtranjera, obj.Id)
            End If
        End If
    End Sub

    Private Sub cboCuentaBancariaOrigen_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuentaBancariaOrigen.ValueChanged
        Dim i As Integer = cboCuentaBancariaOrigen.SelectedIndex
        If cboMedioPago.Text = "EFECTIVO" Then
            oeMovimientosBancariosOrigen.IdCaja = cboCuentaBancariaOrigen.Value
            If i >= 0 Then
                Dim obj As New e_Caja
                obj = cboCuentaBancariaOrigen.Items(i).ListObject
                cboMoneda.Text = "SOLES"
            End If
        Else
            oeMovimientosBancariosOrigen.IdCuentaBancaria = cboCuentaBancariaOrigen.Value
            If i >= 0 Then
                Dim obj As New e_CuentaBancaria
                obj = cboCuentaBancariaOrigen.Items(i).ListObject
                cboMoneda.Value = obj.IdMoneda
            End If
        End If
    End Sub

    Private Sub cboCuentaCtbleDestino_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuentaCtbleDestino.ValueChanged
        oeMovimientosBancariosDestino._IdCuentaContable = cboCuentaCtbleDestino.Value
        Dim i As Integer = cboCuentaCtbleDestino.SelectedIndex
        If i >= 0 Then
            Dim obj As New e_CuentaContable
            obj = cboCuentaCtbleDestino.Items(i).ListObject
            If obj.Cuenta = "10111" Then
                mt_CargarCajas(Me.cboCuentaBancariaDestino, obj.MonedaExtranjera, obj.Cuenta)
            Else
                CuentaBancariaSegunCta(cboCuentaBancariaDestino, obj.MonedaExtranjera, obj.Id)
            End If
        End If
    End Sub

    Private Sub cboCuentaBancariaDestino_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuentaBancariaDestino.ValueChanged
        If cboMedioPago.Text = "EFECTIVO" Then
            oeMovimientosBancariosDestino.IdCaja = cboCuentaBancariaDestino.Value
            IdBanco = String.Empty
        Else
            oeMovimientosBancariosDestino.IdCuentaBancaria = cboCuentaBancariaDestino.Value
            If cboCuentaBancariaDestino.SelectedIndex > -1 Then
                Dim _oeCtaAux = cboCuentaBancariaDestino.Items(cboCuentaBancariaDestino.SelectedIndex).ListObject
                Dim _leAux = leEmpresa.Where(Function(it) it.Id = _oeCtaAux.IdBanco).ToList
                If _leAux.Count > 0 Then IdBanco = _leAux(0).Abreviatura
            Else
                IdBanco = String.Empty
            End If
        End If
    End Sub

    Private Sub fecTransf_Validated(sender As Object, e As EventArgs) Handles fecTransf.Validated
        Try
            If EjercicioBanderaCtaBancari <> Date.Parse(fecTransf.Value).Year Then
                EjercicioBanderaCtaBancari = Date.Parse(fecTransf.Value).Year
                cboCuentaCtbleOrigen.SelectedIndex = -1
                cboCuentaCtbleDestino.SelectedIndex = -1
                cboCuentaBancariaOrigen.SelectedIndex = -1
                cboCuentaBancariaDestino.SelectedIndex = -1
                CuentaBancaria()
                CuentaContable()
                CargarCuentaContable()
            End If
            DecTC.Value = TipoCambio(fecTransf.Value, False)(0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, False)
        End Try
    End Sub

    Private Sub fecTransf_ValueChanged(sender As Object, e As EventArgs) Handles fecTransf.ValueChanged
        oeMovimientosBancariosOrigen.Fecha = fecTransf.Value
        oeMovimientosBancariosDestino.Fecha = fecTransf.Value
    End Sub

    Private Sub DecTC_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecTC.ValueChanged
        If IsDBNull(DecTC.Value) Then DecTC.Value = 0
        If DecTC.Value > 0 Then
            oeMovimientosBancariosOrigen.TipoCambio = DecTC.Value
            oeMovimientosBancariosDestino.TipoCambio = DecTC.Value
            oeAsiento.TipoCambio = DecTC.Value
            Montos()
        End If
    End Sub

    Private Sub txtCheque_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCheque.ValueChanged
        oeMovimientosBancariosOrigen.NroBoucher = txtCheque.Value
        oeMovimientosBancariosDestino.NroBoucher = txtCheque.Value
    End Sub

    Private Sub cboMoneda_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMoneda.ValueChanged
        Try
            If cboMoneda.SelectedIndex > -1 Then
                If cboMedioPago.SelectedIndex = -1 Then Throw New Exception("Seleccione Medio de Pago")
                If DecTC.Value = 0 Then Throw New Exception("Ingrese Tipo Cambio")
                CargarCuentaContable()
                Montos()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            cboMedioPago.Focus() : cboMoneda.SelectedIndex = -1
        End Try
    End Sub

    Private Sub DecImporte_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecImporte.ValueChanged
        Try
            If IsDBNull(DecImporte.Value) Then DecImporte.Value = 0
            If DecImporte.Value > 0 Then
                If DecTC.Value = 0 Then Throw New Exception("Ingrese Tipo Cambio")
                If cboMoneda.SelectedIndex = -1 Then Throw New Exception("Seleccione Moneda")
                Montos()
            Else
                ndSoles.Value = 0 : ndDolares.Value = 0
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            DecImporte.Value = 0 : cboMoneda.Focus()
        End Try
    End Sub

    Private Sub txtGlosa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa.ValueChanged
        oeAsiento.Glosa = txtGlosa.Text
    End Sub

    Private Sub fecInicio_ValueChanged(sender As Object, e As EventArgs) Handles fecInicio.ValueChanged
        Try
            ValidarFechaDesde_Hasta(fecInicio, fecFin)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            fecInicio.Value = fecFin.Value
        End Try
    End Sub

    Private Sub fecFin_ValueChanged(sender As Object, e As EventArgs) Handles fecFin.ValueChanged
        Try
            ValidarFechaDesde_Hasta(fecInicio, fecFin)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            fecFin.Value = fecInicio.Value
        End Try
    End Sub

    Private Sub cboTipoMovimiento_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoMovimiento.ValueChanged
        Dim _leFCAux = New List(Of e_FlujoCaja)
        cboFlujoCaja.ReadOnly = True
        cboCuentaCtbleOrigen.Visible = True : cboCuentaCtbleDestino.Visible = True
        cboCuentaBancariaOrigen.Visible = True : cboCuentaBancariaDestino.Visible = True
        etiCtaBanOrigen.Visible = True : etiCtaBanDestino.Visible = True
        cboTrabajadorOrigen.Visible = False : cboTrabajadorDestino.Visible = False
        chkDsctoPlanilla.Visible = False : chkDsctoPlanilla.Checked = False
        cboTrabajadorDestino.Enabled = False : btnCobroDeuda.Visible = False
        etiOrigen.Text = "Cuenta Contable Origen:" : etiDestino.Text = "Cuenta Contable Destino:"
        If cboTipoMovimiento.SelectedIndex > -1 Then
            Select Case cboTipoMovimiento.SelectedIndex
                Case 1
                    cboFlujoCaja.ReadOnly = False
                    _leFCAux = leProcFlujo.Where(Function(it) it.IndMovimiento = 1).ToList
                    cboCuentaCtbleOrigen.Visible = True : cboCuentaCtbleDestino.Visible = False
                    cboCuentaBancariaOrigen.Visible = True : cboCuentaBancariaDestino.Visible = False
                    etiCtaBanOrigen.Visible = True : etiCtaBanDestino.Visible = False
                    cboTrabajadorOrigen.Visible = False : cboTrabajadorDestino.Visible = True
                    etiOrigen.Text = "Cuenta Contable Origen:" : etiDestino.Text = "Trabajador Destino:"
                Case 2
                    cboFlujoCaja.ReadOnly = False
                    _leFCAux = leProcFlujo.Where(Function(it) it.IndMovimiento = 0).ToList
                    cboCuentaCtbleOrigen.Visible = False : cboCuentaCtbleDestino.Visible = True
                    cboCuentaBancariaOrigen.Visible = False : cboCuentaBancariaDestino.Visible = True
                    etiCtaBanOrigen.Visible = False : etiCtaBanDestino.Visible = True
                    cboTrabajadorOrigen.Visible = True : cboTrabajadorDestino.Visible = False
                    etiOrigen.Text = "Trabajador Origen:" : etiDestino.Text = "Cuenta Contable Destino:"
            End Select
        End If
        LlenarCombo(cboFlujoCaja, "Nombre", _leFCAux, -1)
    End Sub

    Private Sub cboFlujoCaja_ValueChanged(sender As Object, e As EventArgs) Handles cboFlujoCaja.ValueChanged
        Try
            oeAsientoModel = New e_AsientoModelo
            oeReferencia = New e_AsientoModelo_Referencia
            If cboFlujoCaja.SelectedIndex > -1 Then
                If cboMoneda.SelectedIndex = -1 Then Throw New Exception("Seleccione Moneda")
                IndTrabjador = False : chkDsctoPlanilla.Visible = False : chkDsctoPlanilla.Checked = False
                btnImportar.Enabled = False : btnQuitarDatos.Enabled = False : btnValidarDatos.Enabled = False
                chkCargaMasiva.Checked = False : chkCargaMasiva.Visible = False
                etiValidaDatos.Text = String.Empty : btnCobroDeuda.Visible = False
                oeReferencia.Equivale = 1
                oeReferencia.TipoReferencia = 1 : oeReferencia.IdReferencia = cboFlujoCaja.Value
                If leReferencia.Contains(oeReferencia) Then
                    oeReferencia = leReferencia.Item(leReferencia.IndexOf(oeReferencia))
                    oeAsientoModel.Id = oeReferencia.IdActividad
                    Dim _leDAMAux = leDetalleAM.Where(Function(it) it.IdAsientoModelo = oeReferencia.IdActividad).ToList
                    If _leDAMAux.Count > 0 Then
                        For Each oeDAMAux In _leDAMAux
                            oeCtaCtble = New e_CuentaContable
                            oeCtaCtble.Equivale = 0 : oeCtaCtble.Activo = True : oeCtaCtble.Cuenta = oeDAMAux.Cuenta
                            If leCtaCtble.Contains(oeCtaCtble) Then
                                oeCtaCtble = leCtaCtble.Item(leCtaCtble.IndexOf(oeCtaCtble))
                                If oeCtaCtble.Trabajador = 1 Then IndTrabjador = True : Exit For
                            End If
                        Next
                    End If
                    If IndTrabjador Then
                        Select Case cboTipoMovimiento.SelectedIndex
                            Case 1
                                If cboFlujoCaja.Text = gFCPrestamo Or cboFlujoCaja.Text = gFCAdelanto Then
                                    chkDsctoPlanilla.Visible = True : chkDsctoPlanilla.Checked = True
                                    IdConpcetoDscto = String.Empty
                                    Dim _leCDAux As New List(Of e_Concepto_Prestamo)
                                    If cboFlujoCaja.Text = gFCPrestamo Then _leCDAux = leConceptoDscto.Where(Function(it) it.Nombre = gCPPrestamos).ToList
                                    If cboFlujoCaja.Text = gFCAdelanto Then _leCDAux = leConceptoDscto.Where(Function(it) it.Nombre = gCPAdelantos).ToList
                                    If _leCDAux.Count > 0 Then IdConpcetoDscto = _leCDAux(0).Id
                                    cboTrabajadorDestino.Enabled = True
                                End If
                                If cboFlujoCaja.Text = gFCAFPHABITAT Or cboFlujoCaja.Text = gFCAFPHORIZONTE Or cboFlujoCaja.Text = gFCAFPINTEGRA _
                                    Or cboFlujoCaja.Text = gFCAFPPRIMA Or cboFlujoCaja.Text = gFCAFPPROFUTURO Then
                                    chkCargaMasiva.Checked = True : chkCargaMasiva.Visible = True : chkCargaMasiva.Enabled = False
                                    btnImportar.Enabled = True : cboTrabajadorDestino.Enabled = False : cboTrabajadorDestino.SelectedIndex = 0
                                End If
                                If cboFlujoCaja.Text = gFCVACACIONES Then
                                    chkCargaMasiva.Checked = True : chkCargaMasiva.Visible = True : chkCargaMasiva.Enabled = True
                                    btnImportar.Enabled = True : cboTrabajadorDestino.Enabled = False : cboTrabajadorDestino.SelectedIndex = 0
                                End If
                                If cboFlujoCaja.Text = gFCPH Then
                                    Dim _oeplanilla As New e_Planilla With {.IdPeriodo = oePeriodo.Id, .Tipo = 1}
                                    Dim _olplanilla As New l_Planilla
                                    Dim _leListaPago As New List(Of e_Trabajador)
                                    _oeplanilla.IndCargaCompleto = True
                                    _oeplanilla = _olplanilla.Obtener(_oeplanilla)
                                    For Each _det In _oeplanilla.leDetalle.Where(Function(it) it.IsPagado = False).ToList
                                        _leListaPago.Add(New e_Trabajador With {.Id = _det.IdTrabajador, .oePersona = (New e_Persona With {.ApellidoPaterno = _det.Trabajador}), .CantidadRef = _det.ImportePagar, .IdEstadoCivil = _det.Id})
                                    Next
                                    'DecImporte.Value = _oeplanilla.Importe
                                    Dim _leTDAux = From le In _leListaPago Select le.Id, le.oePersona.NombreCompleto, le.CantidadRef, le.IdEstadoCivil
                                    LlenarCombo(cboTrabajadorDestino, "NombreCompleto", _leTDAux.ToList, -1)
                                    cboTrabajadorDestino.Enabled = True
                                End If
                            Case 2
                                If cboFlujoCaja.Text = gFCADEPAGDSCTO Then
                                    btnCobroDeuda.Visible = True
                                End If
                        End Select
                    End If
                Else
                    Throw New Exception("El Flujo Caja: " & cboFlujoCaja.Text & ", no tiene configuracion contable")
                End If
            Else
                oeAsientoModel.Id = String.Empty
            End If
            'Dim dtAux As Data.DataTable
            'Dim _rwAux = dtAMFC.Select("FLUJOCAJA = '" & cboFlujoCaja.Value & "' AND MONEDA = '" & cboMoneda.Value & "'", "")
            'If _rwAux.Count > 0 Then
            '    chkDsctoPlanilla.Visible = False : chkDsctoPlanilla.Checked = False
            '    dtAux = _rwAux.CopyToDataTable
            '    oeAsientoModel.Id = dtAux.Rows(0).Item("ASIENTOMODELO").ToString
            '    Dim _varInd = dtAux.Rows(0).Item("INDTRABAJADOR").ToString
            '    IndTrabjador = IIf(_varInd = "1", True, False)
            '    If cboTrabajadorOrigen.Visible Then cboTrabajadorOrigen.Enabled = IIf(_varInd = "1", True, False)
            '    If cboTrabajadorDestino.Visible Then cboTrabajadorDestino.Enabled = IIf(_varInd = "1", True, False)
            '    If _varInd = "1" Then
            '        If cboFlujoCaja.Text = gFCPrestamo Or cboFlujoCaja.Text = gFCAdelanto Then
            '            chkDsctoPlanilla.Visible = True : chkDsctoPlanilla.Checked = True
            '            IdConpcetoDscto = String.Empty
            '            Dim _leCDAux As New List(Of e_Concepto_Prestamo)
            '            If cboFlujoCaja.Text = gFCPrestamo Then _leCDAux = leConceptoDscto.Where(Function(it) it.Nombre = gCPPrestamos).ToList
            '            If cboFlujoCaja.Text = gFCAdelanto Then _leCDAux = leConceptoDscto.Where(Function(it) it.Nombre = gCPAdelantos).ToList
            '            If _leCDAux.Count > 0 Then IdConpcetoDscto = _leCDAux(0).Id
            '        End If
            '    End If
            'Else
            '    Throw New Exception("El Flujo Caja: " & cboFlujoCaja.Text & ", no tiene configuracion contable")
            'End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            cboFlujoCaja.SelectedIndex = -1 : cboFlujoCaja.Focus()
        End Try
    End Sub

    Private Sub chkDsctoPlanilla_CheckedChanged(sender As Object, e As EventArgs) Handles chkDsctoPlanilla.CheckedChanged
        agrDescuento.Visible = chkDsctoPlanilla.Checked
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        Try
            Dim PathFilePTRA As String = "", SubTotal1 As String, SubTotal2 As String
            OpenFileDialog1 = CargaDatosOpenFileDialog()
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Espere1.Visible = True : Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor : Cursor.Show()
                PathFilePTRA = OpenFileDialog1.FileName
                Dim objXls As Excel.Application, objWorkbook As Excel.Workbook, objWorkSheet As Excel.Worksheet, ObjExcel() As Object = Nothing
                objXls = CreateObject("Excel.Application") : objWorkbook = objXls.Workbooks.Open(PathFilePTRA)
                objXls.Visible = False : objWorkSheet = objXls.Worksheets(1)
                leImportaDatos.Clear()
                For ln_Fila As Integer = 1 To 100000
                    If (Not objWorkSheet.Cells(ln_Fila + 1, 1).Value Is Nothing) Then
                        SubTotal1 = String.Empty : SubTotal2 = String.Empty
                        oePrestamo = New e_Prestamo : oeFonPen = New e_FondoPensionTrabajador
                        oeFonPen.Equivale = 3 : oeFonPen.CUSPP = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 2).Value)
                        If leFonPen.Contains(oeFonPen) Then oeFonPen = leFonPen.Item(leFonPen.IndexOf(oeFonPen))
                        With oePrestamo
                            .Id = String.Empty : .IdTrabajador = oeFonPen.IdTrabajador
                            .Trabajador = IIf(oeTrabajador.Id.ToString = "", Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 3).Value), oeFonPen.Trabajador)
                            .Glosa = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 2).Value)
                            SubTotal1 = objWorkSheet.Cells(ln_Fila + 1, 11).Value
                            SubTotal2 = objWorkSheet.Cells(ln_Fila + 1, 14).Value
                            .Monto = CDbl(SubTotal1) + CDbl(SubTotal2)
                            .Activo = False
                        End With
                        oePrestamo.PrefijoID = gs_PrefijoIdSucursal '@0001
                        leImportaDatos.Add(oePrestamo)
                    Else
                        Exit For
                    End If
                Next
                CargarDatosImportados(leImportaDatos) : griDetalleAdjunto.DataBind()
                If Not objXls Is Nothing Then objWorkbook.Saved = True : objWorkbook.Close() : objXls.Quit()
                OpenFileDialog1.Dispose() : ObjExcel = Nothing : objWorkSheet = Nothing : objWorkbook = Nothing : objXls = Nothing
                Dim proceso() As Process
                proceso = Process.GetProcessesByName("EXCEL")
                If proceso.Length > 0 Then proceso(proceso.Length - 1).Kill()
            Else
                OpenFileDialog1.Dispose()
            End If
            Espere1.Visible = False
            If griDetalleAdjunto.Rows.Count > 0 Then btnQuitarDatos.Enabled = True : btnValidarDatos.Enabled = True : btnImportar.Enabled = False
            If DecImporte.Value = 0 Then DecImporte.Value = leImportaDatos.Sum(Function(it) it.Monto)
        Catch ex As Exception
            Espere1.Visible = False : mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show() : Espere1.Visible = False
        End Try
    End Sub

    Private Sub btnQuitarDatos_Click(sender As Object, e As EventArgs) Handles btnQuitarDatos.Click
        If leImportaDatos.Count > 0 Then
            If MessageBox.Show("¿Desea Eliminar los Datos Importados", "Mensaje de Sistema", MessageBoxButtons.YesNo, _
                               MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                leImportaDatos = New List(Of e_Prestamo)
                CargarDatosImportados(leImportaDatos)
                btnValidarDatos.Enabled = False : etiValidaDatos.Text = String.Empty : btnQuitarDatos.Enabled = False
            End If
        Else
            mensajeEmergente.Problema("No Hay Datos para Eliminar", True)
        End If
    End Sub

    Private Sub btnValidarDatos_Click(sender As Object, e As EventArgs) Handles btnValidarDatos.Click
        Try
            If leImportaDatos.Count > 0 Then
                Dim cantrab As Integer = 0
                Espere1.Visible = True
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                FondoPension()
                For Each IDAux In leImportaDatos
                    IDAux.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If IDAux.IdTrabajador.Trim <> "" Then
                        IDAux.Activo = True
                    Else
                        oeFonPen = New e_FondoPensionTrabajador
                        oeFonPen.Equivale = 3
                        oeFonPen.CUSPP = IDAux.Glosa.Trim
                        If leFonPen.Contains(oeFonPen) Then
                            oeFonPen = leFonPen.Item(leFonPen.IndexOf(oeFonPen))
                            IDAux.IdTrabajador = oeFonPen.IdTrabajador
                            IDAux.Activo = True
                        Else
                            cantrab = cantrab + 1
                        End If
                    End If
                Next
                CargarDatosImportados(leImportaDatos)
                Espere1.Visible = False
                etiValidaDatos.Text = IIf(cantrab > 0, "Tiene " & cantrab & " Trabajadores que no se han registrado su Codigo CUSSP", "Todos los Datos estan Correctamente")
                mensajeEmergente.Confirmacion("Se Validaron todos los Registros", True)
            Else
                mensajeEmergente.Problema("No hay Datos para Validar", True)
            End If
        Catch ex As Exception
            Espere1.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            Espere1.Visible = False
        End Try
    End Sub

    Private Sub chkCargaMasiva_CheckedChanged(sender As Object, e As EventArgs) Handles chkCargaMasiva.CheckedChanged
        If chkCargaMasiva.Visible Then
            btnImportar.Enabled = chkCargaMasiva.Checked : cboTrabajadorDestino.Enabled = Not chkCargaMasiva.Checked
            cboTrabajadorDestino.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnCobroDeuda_Click(sender As Object, e As EventArgs) Handles btnCobroDeuda.Click
        Try
            Dim _band As Boolean = False
            If cboTrabajadorOrigen.SelectedIndex = 0 Then cboTrabajadorOrigen.Focus() : Throw New Exception("Seleccione un Trabajador")
            If DecImporte.Value = 0 Then DecImporte.Focus() : Throw New Exception("Ingrese Importe")
            If leCuota.Count > 0 Then
                If MessageBox.Show("¿Desea Reiniciar la Aplicacion de Cobros?", "Mensaje de Sistema", _
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    _band = True
                End If
            Else
                _band = False
            End If
            If Not _band Then
                leDscto = New List(Of e_Prestamo) : leCuota = New List(Of e_PrestamoDetalle)
                leDsctoGrab = New List(Of e_Prestamo) : leCuotaGrab = New List(Of e_PrestamoDetalle)
                Dim _frm As New frm_RegistroPagoCuota(2, leDscto, leCuota, ndSoles.Value, fecTransf.Value, 0, -1, cboTrabajadorOrigen.Value)
                _frm.StartPosition = FormStartPosition.CenterScreen
                _frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
                If _frm.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                    'Consultar(True)
                    leDscto = _frm.leDscto : leCuota = _frm.leCuota
                    mensajeEmergente.Confirmacion("Los Datos se guardaron correctamente", True)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Confirmacion(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_TransferenciasBancarias_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Espere1.Location = New System.Drawing.Point((Me.Width / 2) - (Espere1.Width / 2), (Me.Height / 2) - Espere1.Height)
    End Sub


    Private Sub mt_Cargar_TurnoActivo()
        Dim TurnoActivo As New e_CierreTurno
        TurnoActivo = gfc_obtener_TurnoActivo()
        Select Case RTrim(TurnoActivo.IdTurno)
            Case "1", "3", "5" : txtGlosa.Text = "DEPOSITO " + TurnoActivo.Turno + " : " + TurnoActivo.Trabajador_Apertura
            Case "2", "4" : txtGlosa.Text = "DEPOSITO " + TurnoActivo.Turno + " : " + TurnoActivo.Trabajador_Apertura
            Case "" : txtGlosa.Text = ""
        End Select
        If txtGlosa.Text <> "" Then
            cboMedioPago.Value = "1CH03"
            cboMoneda.Value = "1CH01"
            cboCuentaCtbleOrigen.Value = "1SI013496"
            cboCuentaBancariaOrigen.Value = "CHG001"
            cboCuentaCtbleDestino.Value = "1SI013496"
            cboCuentaBancariaDestino.Value = "CHG002"
            txtCheque.Text = TurnoActivo.Id
            DecImporte.Select()
            DecImporte.SelectAll()

            cboMedioPago.Enabled = False
            cboMoneda.Enabled = False
            cboCuentaCtbleOrigen.Enabled = False
            cboCuentaBancariaOrigen.Enabled = False
            cboCuentaCtbleDestino.Enabled = False
            cboCuentaBancariaDestino.Enabled = False
            txtCheque.Enabled = False
            cboTipoMovimiento.Enabled = False
            txtGlosa.Enabled = False
        End If
    End Sub
#End Region

End Class
