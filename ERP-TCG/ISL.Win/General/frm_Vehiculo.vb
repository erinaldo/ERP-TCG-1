'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win.UltraWinGrid
Imports System.IO
Imports System.ComponentModel
Imports Infragistics.Win.UltraWinEditors
Imports Infragistics.Win.UltraWinToolTip
Imports Infragistics.Win

Public Class frm_Vehiculo
    Inherits frm_MenuPadre

#Region "Instancia/Constructor"

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Shared instancia As frm_Vehiculo = Nothing
    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Vehiculo()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de variables"

    Private t1 As New UltraToolTipInfo()
    Private Const IdEmpresaCovisol As String = "1CH000007416"
    Private Const IdTDTarjetaPropiedad As String = "1CH000000051"
    Private bolExistRowCheck As Boolean = False
    Public Operacion As String
    Private _ingresando_datos As Boolean = False
    Private Fs As FileStream = Nothing '@0001
    Private FotoRuta As String = "" '@0001
    Private FotoInsert As Integer = 0 '@0001
    Private FotoTamaño As Integer = 0 '@0001
    Public IdUnidad As String = ""
    Public IndConsultaGuardar As Boolean = True
    Public PlacaOriginal As String = ""

    'Vehiculo
    Private oeVehiculo As New e_Vehiculo
    Private loVehiculo As New List(Of e_Vehiculo)
    Private olVehiculo As New l_Vehiculo
    'Combos
    Private oeMarca As New e_Marca
    Private olMarca As New l_Marca
    Private oeConfiguracionNeumatico As New e_ConfiguracionNeumatico
    Private olConfiguracionNeumatico As New l_ConfiguracionNeumatico
    Private oeModeloVehiculo As New e_Modelo
    Private olModeloVehiculo As New l_Modelo
    Private ListaTipoDispositivo As New List(Of e_TipoDocumento)
    Private oeCombo As New e_Combo
    Private olCombo As New l_Combo
    Private ListCombo As New List(Of e_Combo)
    'Placa
    Private oePlaca As New e_Placa
    Private loPlaca As New List(Of e_Placa)
    'Estado
    Private oeVehiculoEstado As New e_VehiculoEstado
    Private loVehiculoEstado As New List(Of e_VehiculoEstado)
    'Dispositivo
    Private oeDispositivo As New e_Dispositivo
    Private loDispositivo As New List(Of e_Dispositivo)
    'Bonificacion
    Private oeBonificacion As New e_Bonificacion
    Private loBonificacion As New List(Of e_Bonificacion)
    'Flota
    Private oeAsignacionFlota As New e_AsignacionFlota
    Private loAsignacionFlota As New List(Of e_AsignacionFlota)
    'Tarjeta
    Private oeVehiculoTarj As New e_VehiculoTarjeta
    Private loVehiculoTarj As New List(Of e_VehiculoTarjeta)
    Private olVehociloTarj As New l_VehiculoTarjeta
    'Concepto
    Private oeConcepto As New e_Concepto
    Private olConcepto As New l_Concepto
    Private loConcepto As New List(Of e_Concepto)

    Private _acl As String = ""

    'Private Const URLConsultaVehicular As String = "https://m.sunarp.gob.pe/mobile/m_ConsultaVehicular.aspx"
    Private Const URLConsultaVehicular As String = "https://www.sunarp.gob.pe/seccion/servicios/detalles/0/c3.html"
#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            mt_Listar()
            mt_ControlBotoneria()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            _acl = gAccionSistema.LECTURA.ToString
            If Not ValidarAcl(_acl, pIdActividadNegocio) Then
                oeVehiculo = New e_Vehiculo
                Operacion = "Nuevo"
                Inicializar()
                btnDescargarJpg.Enabled = False
                mt_AgregarDispositivo()
                MostrarTabs(1, tcVehiculo, 1)
                mt_ControlBotoneria()
                txtPlaca.Focus()
            Else
                Throw New Exception("Usted Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            _acl = gAccionSistema.LECTURA.ToString
            If Not ValidarAcl(_acl, pIdActividadNegocio) Then
                oeVehiculo = New e_Vehiculo
                Operacion = "Editar"
                Inicializar()
                MostrarVehiculo(IdUnidad)
                IdUnidad = ""
                MostrarTabs(1, tcVehiculo, 1)
                mt_ControlBotoneria()
                txtCodigo.Focus()
            Else
                Throw New Exception("Usted Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            _acl = gAccionSistema.LECTURA.ToString
            If Not ValidarAcl(_acl, pIdActividadNegocio) Then
                If ValidarGuardar() AndAlso GuardarVehiculo() Then
                    oeCombo = New e_Combo
                    If verMotriz.Checked Then
                        oeCombo.Nombre = "Tracto"
                        TractoPublic = New List(Of e_Combo)
                        TractoPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
                    Else
                        oeCombo.Nombre = "Carreta"
                        CarretaPublic = New List(Of e_Combo)
                        CarretaPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
                    End If
                    mt_ControlBotoneria()
                End If
            Else
                Throw New Exception("Usted Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                Case Windows.Forms.DialogResult.Yes
                    _acl = gAccionSistema.LECTURA.ToString
                    If Not ValidarAcl(_acl, pIdActividadNegocio) Then
                        If GuardarVehiculo() Then
                            MostrarTabs(0, tcVehiculo, 2)
                            _ingresando_datos = False
                            Operacion = "Inicializa"
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, tcVehiculo, 1)
                        End If
                    Else
                        Throw New Exception("Usted Tiene Permiso de: " & _acl & " en " & Me.Text)
                    End If
                Case Windows.Forms.DialogResult.No
                    MostrarTabs(0, tcVehiculo, 2)
                    _ingresando_datos = False
                    Operacion = "Inicializa"
                Case Windows.Forms.DialogResult.Cancel
                    If Fs IsNot Nothing Then
                        Fs.Dispose()
                    End If
                    _ingresando_datos = True
            End Select
            mt_ControlBotoneria()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            _acl = gAccionSistema.LECTURA.ToString
            If Not ValidarAcl(_acl, pIdActividadNegocio) Then
                With griLista
                    If ValidarGrilla(griLista, "Vehiculo") Then
                        oeVehiculo = New e_Vehiculo
                        oeVehiculo.Id = .ActiveRow.Cells("Id").Value
                        oeVehiculo = olVehiculo.Obtener(oeVehiculo)
                        If Not String.IsNullOrWhiteSpace(oeVehiculo.Id) Then
                            ListCombo = New List(Of e_Combo)
                            oeCombo = New e_Combo
                            With oeCombo
                                .Nombre = "UNIDADVIAJE"
                                If oeVehiculo.Motriz = 1 Then
                                    .Descripcion = "TRACTO"
                                    .Id = oeVehiculo.Id
                                Else
                                    If oeVehiculo.Motriz = 0 Then
                                        .Descripcion = "CARRETA"
                                        .Id = oeVehiculo.Id
                                    End If
                                End If
                            End With
                            ListCombo.AddRange(olCombo.Listar(oeCombo))
                            If ListCombo.Count = 0 Then
                                If MessageBox.Show("Esta seguro de eliminar el Vehiculo: " & _
                                         .ActiveRow.Cells("Placa").Value.ToString & " ?", _
                                         "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                    oeVehiculo.TipoOperacion = "E"
                                    olVehiculo.Eliminar(oeVehiculo)
                                    Consultar(True)
                                End If
                            Else
                                Throw New Exception("La unidad tiene viajes asignados no procede la eliminacion " & Me.Text)
                            End If
                        Else
                            Throw New Exception("La informacion se encuentra eliminada en " & Me.Text)
                        End If
                    End If
                End With
            Else
                Throw New Exception("Usted Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
            
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    Public Overrides Sub Exportar()
        Try
            Select Case tabLista.SelectedTab.Index
                Case 0 'Lista
                    ExportarGrillaAExcel(griLista, "Vehiculos")
                Case 1 'Estado Situacional
                    ExportarGrillaAExcel(griListaSituacional, "Situacional_Vehiculos")
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Public Sub mt_Listar()
        Try
            mt_IniciaCursorEspera()
            oeVehiculo = New e_Vehiculo
            oeVehiculo.Motriz = -1
            Select Case tabLista.SelectedTab.Index
                Case tapVehiculo.Tab.Index
                    oeVehiculo.TipoOperacion = "A"
                    loVehiculo.Clear()
                    loVehiculo.AddRange(olVehiculo.Listar(oeVehiculo).ToList())
                    griLista.DataBind()
                    griLista.DisplayLayout.Bands(0).Columns("Fecha").Hidden = True
                    Dim Dt As DataTable = olCombo.ComboGrilla(ModeloFuncionalPublic.Where(Function(item) item.Extras(0).ToString = 0).ToList)
                    Dim DtM As DataTable = olCombo.ComboGrilla(ModeloFuncionalPublic.Where(Function(item) item.Extras(0).ToString = 1).ToList)
                    Dim j As Integer = 0
                    For Each Fila As UltraGridRow In griLista.Rows
                        mt_ColorxEstado(Fila, Convert.ToInt32(Fila.Cells("IndEstado").Value))
                        If Convert.ToInt32(Fila.Cells("Motriz").Value) = 1 Then
                            CrearComboGridPorCelda("IdModeloFuncional", "Nombre", j, griLista, DtM, True)
                        Else
                            CrearComboGridPorCelda("IdModeloFuncional", "Nombre", j, griLista, Dt, True)
                        End If
                        j += 1
                    Next
                Case tapSituacional.Tab.Index
                    mt_ListarSituacional()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            mt_FinCursorEspera()
        End Try
    End Sub

    Private Sub mt_ListarSituacional()
        Try
            oeVehiculo.TipoOperacion = "Z"
            oeVehiculo.IdFlota = cboFlotaSituacional.Value
            griListaSituacional.DataSource = olVehiculo.ListarSituacional(oeVehiculo)
            For Each Fila As UltraGridRow In griListaSituacional.Rows
                mt_ColorxEstadoSituacional(Fila, Convert.ToInt32(Fila.Cells("Estado").Value))
                mt_NombreEstadoxId(Fila, Convert.ToInt32(Fila.Cells("Estado").Value))
            Next
            griListaSituacional.UpdateData()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_NombreEstadoxId(Fila As UltraGridRow, Estado As Integer)
        Try
            Select Case Estado
                Case EstadoVehiculo.Siniestrado
                    Fila.Cells("EstadoVehiculo").Value = "SINIESTRADO"
                Case EstadoVehiculo.EnVenta
                    Fila.Cells("EstadoVehiculo").Value = "EN VENTA"
                Case EstadoVehiculo.Vendido
                    Fila.Cells("EstadoVehiculo").Value = "VENDIDO"
                Case EstadoVehiculo.Operativo
                    Fila.Cells("EstadoVehiculo").Value = "OPERATIVO"
                Case EstadoVehiculo.Alquilado
                    Fila.Cells("EstadoVehiculo").Value = "ALQUILADO"
                Case EstadoVehiculo.Otros
                    Fila.Cells("EstadoVehiculo").Value = "OTROS"
                Case EstadoVehiculo.DeBaja
                    Fila.Cells("EstadoVehiculo").Value = "DE BAJA"
                Case EstadoVehiculo.PerdidaTotal
                    Fila.Cells("EstadoVehiculo").Value = "PERDIDA TOTAL"
                Case EstadoVehiculo.Perdida
                    Fila.Cells("EstadoVehiculo").Value = "PERDIDA"
                Case EstadoVehiculo.Prestada
                    Fila.Cells("EstadoVehiculo").Value = "PRESTADA"
                Case EstadoVehiculo.Oficina
                    Fila.Cells("EstadoVehiculo").Value = "OFICINA"
                Case EstadoVehiculo.Duplicado
                    Fila.Cells("EstadoVehiculo").Value = "DUPLICADO"
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_ColorxEstadoSituacional(Fila As UltraGridRow, Estado As Integer)
        Try
            Select Case Estado
                Case EstadoVehiculo.Siniestrado
                    Fila.CellAppearance.BackColor = SiniestradoSit.Color
                Case EstadoVehiculo.EnVenta
                    Fila.CellAppearance.BackColor = EnVentaSit.Color
                Case EstadoVehiculo.Vendido
                    Fila.CellAppearance.BackColor = VendidoSit.Color
                Case EstadoVehiculo.Operativo
                    Fila.CellAppearance.BackColor = OperativoSit.Color
                Case EstadoVehiculo.Alquilado
                    Fila.CellAppearance.BackColor = AlquiladoSit.Color
                Case EstadoVehiculo.Otros
                    Fila.CellAppearance.BackColor = OtrosSit.Color
                Case EstadoVehiculo.DeBaja
                    Fila.CellAppearance.BackColor = DeBajaSit.Color
                Case EstadoVehiculo.PerdidaTotal
                    Fila.CellAppearance.BackColor = PerdidaTotalSit.Color
                Case EstadoVehiculo.Perdida
                    Fila.CellAppearance.BackColor = PerdidaSit.Color
                Case EstadoVehiculo.Prestada
                    Fila.CellAppearance.BackColor = PrestadaSit.Color
                Case EstadoVehiculo.Oficina
                    Fila.CellAppearance.BackColor = OficinaSit.Color
                Case EstadoVehiculo.Duplicado
                    Fila.CellAppearance.BackColor = DuplicadoSit.Color
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_ColorxEstado(Fila As UltraGridRow, Estado As Integer)
        Try
            Select Case Estado
                Case EstadoVehiculo.Siniestrado
                    Fila.CellAppearance.BackColor = Me.ColorSiniestrado.Color
                Case EstadoVehiculo.EnVenta
                    Fila.CellAppearance.BackColor = Me.ColorEnVenta.Color
                Case EstadoVehiculo.Vendido
                    Fila.CellAppearance.BackColor = Me.ColorVendido.Color
                Case EstadoVehiculo.Operativo
                    Fila.CellAppearance.BackColor = Me.ColorOperativo.Color
                Case EstadoVehiculo.Alquilado
                    Fila.CellAppearance.BackColor = Me.Colores6.Color
                Case EstadoVehiculo.Otros
                    Fila.CellAppearance.BackColor = Me.Colores5.Color
                Case EstadoVehiculo.DeBaja
                    Fila.CellAppearance.BackColor = Me.Colores7.Color
                Case EstadoVehiculo.PerdidaTotal
                    Fila.CellAppearance.BackColor = Me.Colores8.Color
                Case EstadoVehiculo.Perdida
                    Fila.CellAppearance.BackColor = Me.ColorPerdida.Color
                Case EstadoVehiculo.Prestada
                    Fila.CellAppearance.BackColor = Me.ColorPrestada.Color
                Case EstadoVehiculo.Oficina
                    Fila.CellAppearance.BackColor = Me.ColorOficina.Color
                Case EstadoVehiculo.Duplicado
                    Fila.CellAppearance.BackColor = Me.ColorDuplicado.Color
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_IniciaCursorEspera()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_FinCursorEspera()
        Try
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_RecolectarDatos()
        Try
            With oeVehiculo
                .TipoOperacion = "I"
                If String.IsNullOrEmpty(txtId.Text.Trim()) Then
                    .TipoActualizacion = ""
                Else
                    .TipoActualizacion = "A"
                End If
                .Id = txtId.Text.Trim()
                .Codigo = txtCodigo.Text.Trim()
                .Placa = txtPlaca.Text.Trim()
                If Not String.IsNullOrEmpty(PlacaOriginal.Trim()) AndAlso PlacaOriginal <> .Placa Then
                    .PlacaAntigua = PlacaOriginal
                End If
                .Motriz = IIf(verMotriz.Checked, 1, 0)
                .IdTipoVehiculo = cboTipoVehiculo.Value
                .IdMarca = cboMarca.Value
                .IdModelo = cboModelo.Value
                .IdModeloFuncional = cboModeloFuncional.Value
                .IdEmpresaPropietaria = cboPropietario.Value
                .IdFlota = cboFlota.Value
                .IdMaterialCombustible = IIf(cboCombustible.Value = "CER0", "", cboCombustible.Value)
                .AnioFabricacion = numAñoFabricacion.Value
                .NroSerieChasis = txtSerieChasis.Text.Trim()
                .NroSerieMotor = txtSerieMotor.Text.Trim()
                .Color = txtColor.Text.Trim()
                .Ancho = numAncho.Value
                .Largo = numLargo.Value
                .Alto = numAltura.Value
                .Tara = numTara.Value
                .Capacidad = numCargaUtil.Value
                .Cubicaje = numCubicaje.Value
                .NroEjes = numEjes.Value
                .NroNeumaticos = numRuedas.Value
                .NroNeumaticosRepuesto = numLlantasRepuesto.Value
                .NroMTC = txtNroMTC.Text.Trim()
                .IdConfiguracionVehicularMTC = cboConfiguracionMTC.Value
                .IdConfiguracionNeumaticos = cboConfiguracionGrafica.Value
                .Observacion = txtObservacion.Text.Trim()
                '.IndEstado = IIf(griEstados.Rows.Count > 0, DevuelveIndEstado(), opcEstado.CheckedIndex)
                .IndEstado = IIf(griEstados.Rows.Count > 0, DevuelveIndEstado(), cboEstadoMan.Value)
                '.PlacaAntigua = txtPlacaAntigua.Text.Trim()
                .CapacidadTanque = numCapacidadTanque.Value
                .Fecha = fecPropiedad.Value.Date
                .IndPropiedad = IIf(verIndPropiedad.Checked, 1, 0)
                .IndProrrateo = IIf(verIndProrrateo.Checked, 1, 0)
                .IndActivoFijo = IIf(verIndActivoFijo.Checked, 1, 0)
                .PesoNeto = numPesoNeto.Value
                .NroAsientos = numNroAsientos.Value
                .NroPasajeros = numNroPasajero.Value
                .NroEquipoMovil = txtNroEquipoMovil.Text.Trim()
                If upbFoto.Image IsNot Nothing Then
                    Dim ms As New System.IO.MemoryStream()
                    If ms.Length <> 0 Or FotoInsert = 1 Then
                        upbFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                        .Foto = ms.GetBuffer()
                    Else
                        .Foto = upbFoto.Image()
                    End If
                End If
                .AnioModelo = numAñoModelo.Value
                .IdModeloSunarp = cboModeloSunarp.Value
                .IdTipoCarroceriaSunarp = cboTipoCarroceriaSunarp.Value
                .TipoNeumatico = cboTipoNeumatico.Text.Trim()
                .SuspensionNeumatica = cboSuspensionNeumatica.Text.Trim()
                .Bonificacion = cboBonificacion.Text.Trim()
                .TomaFuerza = cboTomaFuerza.Text.Trim()
                .Modalidad = cboModalidad.Text.Trim()
                .TarjetaCombustible = txtTarjetaCombustible.Text.Trim()
                .IdEmpresaGPS = cboEmpresaGPS.Value
                .RutaAsignada = cboRutaAsignada.Text.Trim()
                .IdClasificacionISL = String.Empty
                .IdTipoCarroceria = String.Empty
                If Not IsNothing(cboClasificacionISL.Value) Then .IdClasificacionISL = cboClasificacionISL.Value.ToString.Trim()
                If Not IsNothing(cboTipoCarroceria.Value) Then .IdTipoCarroceria = cboTipoCarroceria.Value.ToString.Trim()
                .ConductorAsignada = cboPilotoAsignado.Value
                .UsuarioCreacion = gUsuarioSGI.Id
                'Agregar Placa, Estado y Flota
                If Operacion = "Nuevo" Then
                    'Placa
                    oePlaca = New e_Placa
                    loPlaca = New List(Of e_Placa)
                    With oePlaca
                        .Nombre = txtPlaca.Text.Trim()
                        .FechaInicio = Date.Now.AddDays(-15).Date
                        .Actual = True
                    End With
                    loPlaca.Add(oePlaca)
                    'Estado
                    oeVehiculoEstado = New e_VehiculoEstado
                    loVehiculoEstado = New List(Of e_VehiculoEstado)
                    With oeVehiculoEstado
                        '.Indicador = opcEstado.CheckedIndex
                        .Indicador = cboEstadoMan.Value
                        .Observacion = String.Empty
                        .FechaInicio = Date.Now
                        .FechaFin = Date.Now
                        .Actual = True
                    End With
                    loVehiculoEstado.Add(oeVehiculoEstado)
                    'Flota
                    oeAsignacionFlota = New e_AsignacionFlota
                    loAsignacionFlota = New List(Of e_AsignacionFlota)
                    With oeAsignacionFlota
                        .IdFlota = cboFlota.Value
                        .Observacion = String.Empty
                        .FechaInicio = Date.Now
                        .FechaFin = Date.Now
                        .Actual = True
                    End With
                    loAsignacionFlota.Add(oeAsignacionFlota)
                End If
                'Placas
                .ListHistorialPlaca.Clear() : .ListHistorialPlaca.AddRange(loPlaca)
                'Estados
                .ListVehiculoEstados.Clear() : .ListVehiculoEstados.AddRange(loVehiculoEstado)
                'Dispositivos
                .ListDispositivo.Clear() : .ListDispositivo.AddRange(loDispositivo)
                'Bonificacion
                .ListBonificacion.Clear() : .ListBonificacion.AddRange(loBonificacion)
                'Flota
                .ListAsignacionFlota.Clear() : .ListAsignacionFlota.AddRange(loAsignacionFlota)
                'Tarjetas
                .ListVehiculoTarjeta.Clear() : .ListVehiculoTarjeta = loVehiculoTarj
                'Otros
                .ListDocumentoVehicular.Clear()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GuardarVehiculo() As Boolean
        Try
            mt_IniciaCursorEspera()
            mt_RecolectarDatos()
            oeVehiculo.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olVehiculo.Guardar(oeVehiculo) Then
                mensajeEmergente.Confirmacion(Me.Text & ": La informacion ha sido grabada satisfactoriamente", True)
                MostrarTabs(0, tcVehiculo, 2)
                If FotoRuta <> "" Then
                    Fs.Dispose()
                End If
                Consultar(True)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            mt_FinCursorEspera()
        End Try
    End Function

    Public Sub ListarVehiculosMantenimiento()
        Try
            mt_IniciaCursorEspera()
            oeVehiculo = New e_Vehiculo
            oeVehiculo.Activo = 1
            oeVehiculo.Motriz = -1
            oeVehiculo.TipoOperacion = "O"
            loVehiculo.Clear()
            loVehiculo.AddRange(olVehiculo.Listar(oeVehiculo))
            griLista.DataBind()
            griLista.DisplayLayout.Bands(0).Columns("Fecha").Hidden = False
            Dim Dt As DataTable = olCombo.ComboGrilla(ModeloFuncionalPublic.Where(Function(item) item.Extras(0).ToString = 0).ToList)
            Dim DtM As DataTable = olCombo.ComboGrilla(ModeloFuncionalPublic.Where(Function(item) item.Extras(0).ToString = 1).ToList)
            Dim j As Integer = 0
            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLista.Rows
                mt_ColorxEstado(fila, Convert.ToInt32(fila.Cells("IndEstado").Value))
                If Convert.ToInt32(fila.Cells("Motriz").Value) = 1 Then
                    CrearComboGridPorCelda("IdModeloFuncional", "Nombre", j, griLista, DtM, True)
                Else
                    CrearComboGridPorCelda("IdModeloFuncional", "Nombre", j, griLista, Dt, True)
                End If
                Select Case TiempoSobrePasado(Convert.ToDateTime(fila.Cells("Fecha").Value).Date)
                    Case Is <= 0
                        fila.Cells("Fecha").Appearance.BackColor = Color.White
                    Case 1
                        fila.CellAppearance.BackColor = Me.Color1Dia.Color
                    Case 2 To 3
                        fila.CellAppearance.BackColor = Me.Color2a3Dias.Color
                    Case 4 To 7
                        fila.CellAppearance.BackColor = Me.Color4a7Dias.Color
                    Case Is > 7
                        fila.CellAppearance.BackColor = Me.Color7DiasAMas.Color
                End Select
                j += 1
            Next
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            mt_FinCursorEspera()
        End Try
    End Sub

    Private Sub MostrarVehiculo(ByVal Id As String)
        Try
            If Id.ToString.Length > 0 Then
                oeVehiculo.Id = Id
                oeVehiculo = olVehiculo.Obtener(oeVehiculo)
                With oeVehiculo
                    txtId.Text = .Id
                    txtCodigo.Text = .Codigo
                    txtPlaca.Text = .Placa
                    PlacaOriginal = .Placa
                    verMotriz.Checked = Convert.ToBoolean(.Motriz)
                    cboTipoVehiculo.Value = .IdTipoVehiculo
                    cboMarca.Value = .IdMarca
                    cboModelo.Value = .IdModelo
                    cboModeloFuncional.Value = .IdModeloFuncional
                    cboPropietario.Value = .IdEmpresaPropietaria
                    cboFlota.Value = .IdFlota
                    cboCombustible.Value = .IdMaterialCombustible.Trim
                    numAñoFabricacion.Value = IIf(.AnioFabricacion = 0, Date.Now.Year, .AnioFabricacion)
                    txtSerieChasis.Text = .NroSerieChasis
                    txtSerieMotor.Text = .NroSerieMotor
                    txtColor.Text = .Color
                    numAncho.Value = .Ancho
                    numLargo.Value = .Largo
                    numAltura.Value = .Alto
                    numTara.Value = .Tara
                    numCargaUtil.Value = .Capacidad
                    numPesoNeto.Value = .PesoNeto
                    numCubicaje.Value = .Cubicaje
                    numEjes.Value = .NroEjes
                    numRuedas.Value = .NroNeumaticos
                    numLlantasRepuesto.Value = .NroNeumaticosRepuesto
                    txtNroMTC.Text = .NroMTC
                    cboConfiguracionMTC.Value = .IdConfiguracionVehicularMTC
                    cboConfiguracionGrafica.Value = .IdConfiguracionNeumaticos
                    txtObservacion.Text = .Observacion
                    'opcEstado.CheckedIndex = .IndEstado
                    cboEstadoMan.Value = .IndEstado
                    txtPlacaAntigua.Text = .PlacaAntigua
                    numCapacidadTanque.Value = .CapacidadTanque
                    fecPropiedad.Value = .Fecha
                    verIndPropiedad.Checked = .IndPropiedad
                    verIndProrrateo.Checked = .IndProrrateo
                    verIndActivoFijo.Checked = .IndActivoFijo
                    numNroAsientos.Value = .NroAsientos
                    numNroPasajero.Value = .NroPasajeros
                    txtNroEquipoMovil.Text = .NroEquipoMovil
                    txtDescripcionDetalle.Text = .DescripcionDetalle
                    If .Foto.Length <> 4 Then
                        upbFoto.Image = .Foto
                        Dim tc As TypeConverter = TypeDescriptor.GetConverter(GetType(Bitmap))
                        Dim bitmap As Bitmap = DirectCast(tc.ConvertFrom(.Foto), Bitmap)
                        Dim imagen As Image = bitmap
                        imagenGuardar.Image = imagen
                        btnDescargarJpg.Enabled = True
                    End If
                    numAñoModelo.Value = IIf(.AnioModelo = 0, Date.Now.Year, .AnioModelo)
                    cboModeloSunarp.Value = .IdModeloSunarp
                    cboTipoCarroceriaSunarp.Value = .IdTipoCarroceriaSunarp
                    cboTipoNeumatico.Text = .TipoNeumatico
                    cboSuspensionNeumatica.Text = .SuspensionNeumatica
                    cboBonificacion.Text = .Bonificacion
                    cboTomaFuerza.Text = .TomaFuerza
                    cboModalidad.Text = .Modalidad
                    txtTarjetaCombustible.Text = .TarjetaCombustible
                    cboEmpresaGPS.Value = .IdEmpresaGPS
                    cboRutaAsignada.Text = .RutaAsignada
                    cboClasificacionISL.Value = .IdClasificacionISL
                    cboTipoCarroceria.Value = .IdTipoCarroceria
                    cboPilotoAsignado.Value = .ConductorAsignada

                    ndOdometro.Value = .Odometro
                    ndHorometro.Value = .Horometro
                End With
                'Tab Seguros
                Dim olDocumentoVehicular As New l_DocumentoVehicular
                Dim oeDocumentoVehicular As New e_DocumentoVehicular
                oeDocumentoVehicular = New e_DocumentoVehicular
                oeDocumentoVehicular.TipoOperacion = "G"
                oeDocumentoVehicular.IdVehiculo = txtId.Text.Trim()
                griDocumentoVehicular.DataSource = olDocumentoVehicular.ListarDts(oeDocumentoVehicular)
                'Placa
                oePlaca = New e_Placa
                oePlaca.IdVehiculo = txtId.Text.Trim()
                Dim olPlaca As New l_Placa
                loPlaca.AddRange(olPlaca.Listar(oePlaca).OrderBy(Function(x) x.FechaInicio.Date).ThenBy(Function(x) x.Actual).ToList())
                griHistorialPlaca.DataBind()
                'Estados
                oeVehiculoEstado = New e_VehiculoEstado
                oeVehiculoEstado.IdVehiculo = txtId.Text.Trim()
                loVehiculoEstado.AddRange(olVehiculo.ListarEstado(oeVehiculoEstado).OrderBy(Function(x) x.FechaInicio.Date).ThenBy(Function(x) x.FechaFin.Date).ThenBy(Function(x) x.Actual).ToList())
                griEstados.DataBind()
                'Dispositivos
                Dim olDispositivo As New l_Dispositivo
                oeDispositivo = New e_Dispositivo
                oeDispositivo.IdVehiculo = txtId.Text.Trim()
                loDispositivo.AddRange(olDispositivo.Listar(oeDispositivo)) : griDispositivo.DataBind()
                'Bonificacion
                Dim olBonificacion As New l_Bonificacion
                oeBonificacion = New e_Bonificacion
                oeBonificacion.IdVehiculo = txtId.Text.Trim()
                loBonificacion.AddRange(olBonificacion.Listar(oeBonificacion)) : griBonificacion.DataBind()
                'Flota
                Dim olAsignacionFlota As New l_AsignacionFlota
                oeAsignacionFlota = New e_AsignacionFlota
                oeAsignacionFlota.IdVehiculo = txtId.Text.Trim
                loAsignacionFlota.AddRange(olAsignacionFlota.Listar(oeAsignacionFlota).OrderBy(Function(x) x.FechaInicio.Date).ThenBy(Function(x) x.FechaFin.Date).ThenBy(Function(x) x.Actual).ToList())
                griAsignacionFlota.DataBind()
                'Equipos
                'Documentos
                Dim olImgDoc As New l_ImagenesDocumentos
                Dim oeImgDoc As New e_ImagenesDocumentos
                oeImgDoc.IdVehiculo = txtId.Text.Trim()
                gridControlDoc.DataSource = olImgDoc.Listar(oeImgDoc)
                For Each fila As UltraGridRow In gridControlDoc.Rows
                    If fila.Cells("FechaVencimiento").Value <> "01/01/1901" Then
                        fila.CellAppearance.ForeColor = Color.Black
                        If fila.Cells("Vencimiento").Value <= 10 Then
                            fila.CellAppearance.BackColor = Me.ColoresVencido.Color
                            fila.CellAppearance.ForeColor = Color.White
                        ElseIf fila.Cells("Vencimiento").Value > 10 And fila.Cells("Vencimiento").Value <= 20 Then
                            fila.CellAppearance.BackColor = Me.ColoresPorVencer.Color
                        Else
                            fila.CellAppearance.BackColor = Me.ColoresGenerado.Color
                        End If
                    End If
                Next
                'Tarjetas 
                oeVehiculoTarj = New e_VehiculoTarjeta
                With oeVehiculoTarj
                    .TipoOperacion = "GEN"
                    .IdVehiculo = oeVehiculo.Id
                End With
                loVehiculoTarj.AddRange(olVehociloTarj.Listar(oeVehiculoTarj).OrderBy(Function(x) x.FechaInicial).ToList)
                griTarjetaCovisol.DataBind()
                'Mostrar el último piloto del ultimo viaje 
                'Dim oeViaje As New e_Viaje
                'With oeViaje
                '    .ViajeVacio = 2
                '    .IndMotriz = 1
                '    .Zona = ""
                '    .IdDestino = ""
                '    .IdTracto = oeVehiculo.Id
                'End With
                'Dim loViaje As New List(Of e_Viaje)
                'Dim olOperacion As New l_Operacion
                'loViaje.AddRange(olOperacion.ListarViaje(oeViaje))
                'If loViaje.Count > 0 Then
                '    cboPilotoAsignado.Value = loViaje(0).IdPiloto
                'End If
                'Mostrar el Mantenimiento proyectado
                Dim oeProyMant As New e_ProyMantenimiento, olProyMant As New l_Mantenimiento
                oeProyMant.TipoOperacion = "V"
                oeProyMant.IdModelo = oeVehiculo.Id
                griMantenimiento.DataSource = olProyMant.ListarProyMant(oeProyMant)
            Else
                Throw New Exception("Seleccione Vehiculo a Editar en la Lista Activa")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializar()
        Try
            'TAB GENERAL
            Dim ld_FechaActual As Date = ObtenerFechaServidor()
            txtPlaca.Text = String.Empty
            txtPlacaAntigua.Text = String.Empty
            PlacaOriginal = String.Empty
            'opcEstado.CheckedIndex = 3
            cboEstadoMan.Value = 3
            fecPropiedad.Value = ld_FechaActual.Date
            verIndPropiedad.Checked = False
            verIndProrrateo.Checked = False
            verIndActivoFijo.Checked = False
            If cboFlota.DataSource IsNot Nothing AndAlso CType(cboFlota.DataSource, List(Of e_Combo)).ToList.Count > 0 Then
                cboFlota.SelectedIndex = 0
            End If
            txtCodigo.Text = String.Empty
            txtId.Text = String.Empty
            verMotriz.Checked = False
            If cboMarca.DataSource IsNot Nothing AndAlso CType(cboMarca.DataSource, List(Of e_Marca)).ToList.Count > 0 Then
                cboMarca.SelectedIndex = 0
            End If
            numAñoFabricacion.Value = ld_FechaActual.Year
            numAñoModelo.Value = ld_FechaActual.Year
            txtObservacion.Text = String.Empty
            txtNroEquipoMovil.Text = String.Empty
            upbFoto.Image = Nothing
            'TAB SUNARP
            txtSerieChasis.Text = String.Empty
            txtSerieMotor.Text = String.Empty
            txtColor.Text = String.Empty
            cboModeloSunarp.Text = String.Empty
            cboTipoCarroceriaSunarp.Text = String.Empty
            cboPropietario.Text = String.Empty
            txtDescripcionDetalle.Text = String.Empty
            'TAB CARACTERISTICAS
            cboCombustible.Text = String.Empty
            cboConfiguracionGrafica.Text = String.Empty
            txtNroMTC.Text = String.Empty
            cboTipoNeumatico.Text = String.Empty
            cboBonificacion.Text = String.Empty
            cboEmpresaGPS.Text = String.Empty
            cboModalidad.Text = String.Empty
            cboRutaAsignada.Text = String.Empty
            cboClasificacionISL.Text = String.Empty
            cboTipoCarroceria.Text = String.Empty
            cboPilotoAsignado.Text = String.Empty
            txtTarjetaCombustible.Text = String.Empty
            cboConfiguracionMTC.Text = String.Empty
            numEjes.Value = 0
            cboSuspensionNeumatica.Text = String.Empty
            cboTomaFuerza.Text = String.Empty
            numAncho.Value = 0
            numAltura.Value = 0
            numCargaUtil.Value = 0
            numCubicaje.Value = 0
            numLargo.Value = 0
            numTara.Value = 0
            numPesoNeto.Value = 0
            numCapacidadTanque.Value = 0
            numRuedas.Value = 0
            numNroAsientos.Value = 0
            numLlantasRepuesto.Value = 0
            numNroPasajero.Value = 0
            'SUB TAB PLACAS
            txtHisPlaca.Text = String.Empty
            fecHisInicio.Value = ld_FechaActual.Date
            loPlaca = New List(Of e_Placa)
            griHistorialPlaca.DataSource = loPlaca : griHistorialPlaca.DataBind()

            'SUB TAB ESTADO
            txtObservacionEstado.Text = String.Empty
            fecInicioEstado.Value = ld_FechaActual.Date
            loVehiculoEstado = New List(Of e_VehiculoEstado)
            griEstados.DataSource = loVehiculoEstado : griEstados.DataBind()

            'SUB TAB DISPOSITIVOS
            If cboTipoDispositivo.DataSource IsNot Nothing AndAlso CType(cboTipoDispositivo.DataSource, List(Of e_TipoDocumento)).ToList.Count > 0 Then
                cboTipoDispositivo.SelectedIndex = 0
            End If
            txtDispNroSerie.Text = String.Empty
            fecDispEnicio.Value = ld_FechaActual.Date
            txtDispCantidad.Value = 0
            ndOdometro.Value = 0
            ndHorometro.Value = 0
            loDispositivo = New List(Of e_Dispositivo)
            griDispositivo.DataSource = loDispositivo : griDispositivo.DataBind()

            'SUB TAB BONIFICACION
            txtBoniNumero.Value = 0
            txtBoniPorcentaje.Value = 0
            verBoniIndicador.Checked = False
            txtBoniObservacion.Text = String.Empty
            loBonificacion = New List(Of e_Bonificacion)
            griBonificacion.DataSource = loBonificacion : griBonificacion.DataBind()

            'SUB TAB FLOTA
            fecInicioAsigFlota.Value = ld_FechaActual.Date
            txtObservacionAsigFlota.Text = String.Empty
            loAsignacionFlota = New List(Of e_AsignacionFlota)
            griAsignacionFlota.DataSource = loAsignacionFlota : griAsignacionFlota.DataBind()

            'SUB TAB TARJETA
            mt_InicializarTabTarjeta()
            loVehiculoTarj = New List(Of e_VehiculoTarjeta)
            griTarjetaCovisol.DataSource = loVehiculoTarj : griTarjetaCovisol.DataBind()

            'SUB TAB MANTENIMIENTO
            griMantenimiento.DataSource = New List(Of e_ProyMantenimiento) : griMantenimiento.DataBind()
            'Variables
            FotoInsert = 0
            FotoRuta = ""
            'Manejo de Controles
            tabEquipos.Tab.Visible = False
            txtPlacaAntigua.ReadOnly = True
            txtPlaca.ReadOnly = False
            cboFlota.ReadOnly = False
            'opcEstado.Enabled = True
            cboEstadoMan.Enabled = True
            tabSeguros.Tab.Visible = True
            tabPlacas.Tab.Visible = True
            tabEstados.Tab.Visible = True
            tabFlota.Tab.Visible = True
            tabDocumentos.Tab.Visible = True
            'TabTarjetasCovisol.Tab.Visible = True '@0001
            Select Case Operacion
                Case "Nuevo"
                    tabSeguros.Tab.Visible = False
                    tabPlacas.Tab.Visible = False
                    tabEstados.Tab.Visible = False
                    tabFlota.Tab.Visible = False
                    tabDocumentos.Tab.Visible = False
                Case "Editar"
                    txtPlaca.ReadOnly = True
                    cboFlota.ReadOnly = True
                    'opcEstado.Enabled = False
                    cboEstadoMan.Enabled = False
            End Select
            'tabs.SelectedTab = TabTarjetasCovisol.Tab @0001
            'Para que llene los combos dependientes a IndMotriz
            verMotriz_CheckedChanged(Nothing, Nothing)
            'Web Browser Consulta Vehicular
            wbrConsultaVehicular.Navigate(URLConsultaVehicular)
            wbrConsultaVehicular.ScriptErrorsSuppressed = True
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_InicializarTabTarjeta()
        Try
            dtpCovFecha.Value = Date.Now.Date
            If cmbCovEmpProp.Value IsNot Nothing AndAlso CType(cmbCovEmpProp.DataSource, List(Of e_Empresa)).Where(Function(x) x.Id = IdEmpresaCovisol).Count > 0 Then
                cmbCovEmpProp.Value = IdEmpresaCovisol
            End If
            txtCovTarjeta.Text = ""
            txtCovGlosa.Text = ""
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private lstMarca As New List(Of e_Marca)
    Sub LlenaComboMarca()
        Try
            oeMarca = New e_Marca
            oeMarca.TipoMarca = 0
            lstMarca = olMarca.Listar(oeMarca)
            LlenarComboMaestro(cboMarca, lstMarca, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub LlenaComboPropietario()
        Try
            oeCombo = New e_Combo
            ListCombo = New List(Of e_Combo)
            oeCombo.Nombre = "EMPRESAINDICADOR"
            oeCombo.Descripcion = "PROPIETARIO"
            ListCombo.AddRange(olCombo.Listar(oeCombo))
            LlenarComboMaestro(cboPropietario, ListCombo, -1)
            cboPropietario.Value = gs_IdEmpresaSistema.Trim
            ListCombo = New List(Of e_Combo)
            oeCombo.Descripcion = "GPS"
            ListCombo.AddRange(olCombo.Listar(oeCombo))
            LlenarComboMaestro(cboEmpresaGPS, ListCombo, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub LlenaComboTipoCombustible()
        Try
            Dim lstTipoCombustible As New List(Of e_Material)
            Dim olMaterial As New l_Material
            Dim oeMaterial As New e_Material
            oeMaterial.Id = "CERO"
            oeMaterial.Nombre = "NINGUNO"
            lstTipoCombustible.Add(oeMaterial)
            oeMaterial = New e_Material
            oeMaterial.TipoOperacion = "C"
            lstTipoCombustible.AddRange(olMaterial.Listar(oeMaterial))
            LlenarComboMaestro(cboCombustible, lstTipoCombustible.OrderBy(Function(Item) Item.Nombre).ToList, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub LlenaComboConfiguracionNeumaticos()
        Try
            oeConfiguracionNeumatico = New e_ConfiguracionNeumatico
            oeConfiguracionNeumatico.Activo = True
            LlenarComboMaestro(cboConfiguracionGrafica, olConfiguracionNeumatico.Listar(oeConfiguracionNeumatico), 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub mt_ControlBotoneria()
        Try
            If IndConsultaGuardar Then
                Select Case tcVehiculo.SelectedTab.Index
                    Case 0
                        If griLista.Rows.Count > 0 Then
                            ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                        Else
                            ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
                        End If
                    Case 1
                        ControlBoton(0, 0, 0, 1, 1)
                End Select
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function EliminarVehiculo() As Boolean
        Try
            mt_IniciaCursorEspera()
            With griLista
                If ValidarGrilla(griLista, "Vehiculo") Then
                    oeVehiculo = New e_Vehiculo
                    oeVehiculo.Id = .ActiveRow.Cells("Id").Value.ToString().Trim()
                    oeVehiculo = olVehiculo.Obtener(oeVehiculo)
                    If Not String.IsNullOrWhiteSpace(oeVehiculo.Id) AndAlso oeVehiculo.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar el Vehiculo: " & _
                                 .ActiveRow.Cells("Placa").Value.ToString() & " ?", _
                                 "SGI-ISL", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeVehiculo.TipoOperacion = "E"
                            olVehiculo.Eliminar(oeVehiculo)
                            'Consultar(True)
                        Else
                            Return False
                        End If
                    Else
                        Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                    End If
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
        Finally
            mt_FinCursorEspera()
        End Try
    End Function

    Private Function DevuelveIndEstado() As Integer
        Try
            For Each row As UltraGridRow In griEstados.Rows
                If row.Cells("Actual").Value Then
                    Return row.Cells("Indicador").Value
                End If
            Next
            Return 0
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidarGuardar() As Boolean
        Try
            'Cabecera
            tabDatosUnidades.Tabs(0).Selected = True
            ValidarCombo(cboFlota, "Flota")
            ValidarCombo(cboTipoVehiculo, "Tipo Vehiculo")
            ValidarCombo(cboModeloFuncional, "Modelo Funcional")
            ValidarCombo(cboMarca, "Marca")
            ValidarCombo(cboModelo, "Modelo EMP.")
            tabDatosUnidades.Tabs(1).Selected = True
            ValidarCombo(cboModeloSunarp, "Modelo Sunarp")
            ValidarCombo(cboTipoCarroceriaSunarp, "Tipo Carroceria Sunarp")
            ValidarCombo(cboPropietario, "Propietario EMP.")
            If verIndPropiedad.Checked Then
                tabDatosUnidades.Tabs(2).Selected = True
                ValidarCombo(cboConfiguracionGrafica, "Configuracion Grafica")
                ValidarCombo(cboConfiguracionMTC, "Configuracion MTC")
                ValidarCombo(cboTipoNeumatico, "Tipo Neumatico")
                ValidarCombo(cboSuspensionNeumatica, "Suspension Neumatica")
                ValidarCombo(cboTomaFuerza, "Conexion Toma Fuerza")
                ValidarCombo(cboEmpresaGPS, "Empresa GPS")
                ValidarCombo(cboModalidad, "Modalidad")
                ValidarCombo(cboRutaAsignada, "Ruta Asignada")
                'ValidarCombo(cboPilotoAsignado, "Piloto Asignado")
                If verMotriz.Checked And (cboCombustible.Text = "NINGUNO" Or String.IsNullOrEmpty(cboCombustible.Text)) Then
                    cboCombustible.Focus()
                    Throw New Exception("Para los vehículos motrices, obligatoriamente debe indicar el tipo de combustible")
                End If
            End If
            tabDatosUnidades.Tabs(0).Selected = True
            'Detalles
            If Operacion <> "Nuevo" Then
                'Tab Placas
                If loPlaca.Where(Function(x) x.Actual And x.TipoOperacion <> "E").Count = 0 Then
                    tabs.SelectedTab = tabPlacas.Tab
                    MessageBox.Show("Debe agregar almenos una placa actual", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return False
                End If
                If loPlaca.Where(Function(x) x.Actual And x.TipoOperacion <> "E").Count > 1 Then
                    tabs.SelectedTab = tabPlacas.Tab
                    MessageBox.Show("Elija solo una placa actual", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return False
                End If
                'Tab Estados
                If loVehiculoEstado.Where(Function(x) x.Actual And x.TipoOperacion <> "E").Count = 0 Then
                    tabs.SelectedTab = tabEstados.Tab
                    MessageBox.Show("Debe agregar almenos un estado actual", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return False
                End If
                If loVehiculoEstado.Where(Function(x) x.Actual And x.TipoOperacion <> "E").Count > 1 Then
                    tabs.SelectedTab = tabEstados.Tab
                    MessageBox.Show("Elija solo un estado actual", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return False
                End If
                'Tab Flotas
                If loAsignacionFlota.Where(Function(x) x.Actual And x.TipoOperacion <> "E").Count = 0 Then
                    tabs.SelectedTab = tabFlota.Tab
                    MessageBox.Show("Debe agregar almenos una flota actual", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return False
                End If
                If loAsignacionFlota.Where(Function(x) x.Actual And x.TipoOperacion <> "E").Count > 1 Then
                    tabs.SelectedTab = tabFlota.Tab
                    MessageBox.Show("Elija solo una flota actual", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return False
                End If
            End If
            If verIndPropiedad.Checked AndAlso verMotriz.Checked AndAlso loDispositivo.Where(Function(x) x.TipoOperacion <> "E").Count = 0 Then
                tabs.SelectedTab = tabDispositivos.Tab
                MessageBox.Show("Debe ingresar un Odómetro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            'Tab Tarjetas Peajes
            'Si han ingresado un registro 
            If loVehiculoTarj.Where(Function(x) x.TipoOperacion <> "E").Count > 0 Then
                'Si existe almenos una tarjeta actual
                If loVehiculoTarj.Where(Function(x) x.TipoOperacion <> "E" And x.Actual).Count > 0 Then
                    'Comprobar si esta asignado a otro vehiculo
                    Dim loVehTarjeta As New List(Of e_VehiculoTarjeta)
                    oeVehiculoTarj = New e_VehiculoTarjeta
                    With oeVehiculoTarj
                        .NroTarjeta = loVehiculoTarj.Where(Function(x) x.TipoOperacion <> "E" And x.Actual)(0).NroTarjeta
                        .Actual = True
                        .IdEmpresaPropietaria = IdEmpresaCovisol
                    End With
                    loVehTarjeta.AddRange(olVehociloTarj.Listar(oeVehiculoTarj))
                    If loVehTarjeta.Count > 0 AndAlso oeVehiculo.Id <> loVehTarjeta(0).IdVehiculo Then
                        Throw New Exception("El numero de tarjeta " & loVehTarjeta(0).NroTarjeta & Environment.NewLine & _
                                            "Actualmente se encuentra asignada al vehículo " & loVehTarjeta(0).Placa)
                    End If
                Else
                    If MessageBox.Show("No ha marcado ninguna tarjeta actual, Desea Continuar?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                        Return False
                    End If
                End If
            End If
            ''Verificar si se le ha agregado documento tarjeta de propiedad
            'If Operacion = "Editar" AndAlso CType(gridControlDoc.DataSource, List(Of e_ImagenesDocumentos)).Where(Function(x) x.IdTipoDocumento = IdTDTarjetaPropiedad).Count = 0 Then
            '    MessageBox.Show("Falta registrar tarjeta de propiedad comunicarse con el encargado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            'End If
            Dim JefeFlotaActual As New e_Flota_Trabajador, olFlotaTrabajador As New l_Flota_Trabajador, lstFlotaTrabajador As New List(Of e_Flota_Trabajador)
            JefeFlotaActual.Actual = True
            JefeFlotaActual.IdFlota = cboFlota.Value
            lstFlotaTrabajador.AddRange(olFlotaTrabajador.Listar(JefeFlotaActual))
            If lstFlotaTrabajador.Count > 0 Then
                oeCombo = New e_Combo
                'Recupero Responsable Flota Actual
                If TrabajadorPublic.Where(Function(x) x.Id = lstFlotaTrabajador(0).IdTrabajador).Count > 0 Then
                    oeCombo = TrabajadorPublic.Where(Function(x) x.Id = lstFlotaTrabajador(0).IdTrabajador)(0)
                End If
                'Responsable Unidad Vacío
                If cboPilotoAsignado.SelectedRow Is Nothing Then
                    cboPilotoAsignado.Value = oeCombo.Id
                Else
                    'Responsable de la unidad lleno
                    If cboPilotoAsignado.Value <> lstFlotaTrabajador(0).IdTrabajador Then
                        tabDatosUnidades.Tabs(2).Selected = True
                        If MessageBox.Show("El responsable de la flota actual: " & oeCombo.Nombre & Environment.NewLine & _
                               "es diferente al seleccionado: " & cboPilotoAsignado.Text.Trim() & Environment.NewLine & _
                               "¿Desea continuar?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                            Return False
                        End If
                    End If
                End If
            End If
            JefeFlotaActual = Nothing : olFlotaTrabajador = Nothing : lstFlotaTrabajador = Nothing
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub LlenaCombosGrilla()
        Try
            Dim Flota = New DataTable
            Flota = olCombo.ComboGrilla(FlotaPublic.Where(Function(Item) Item.Nombre <> "TODOS").ToList)
            Dim olTipoDocumento As New l_TipoDocumento
            CrearComboGrid("IdTipoDispositivo", "Nombre", griDispositivo, olTipoDocumento.ComboGrilla(ListaTipoDispositivo), True)
            CrearComboGrid("IdFlota", "Nombre", griLista, Flota, True)
            CrearComboGrid("IdFlota", "Nombre", griAsignacionFlota, Flota, True)
            CrearComboGrid("IdModeloFuncional", "Nombre", griLista, olCombo.ComboGrilla(ModeloFuncionalPublic.Where(Function(item) item.Extras(0) = 1).ToList), True)
            CrearComboGrid("DescripcionDetalle", "Nombre", griLista, olCombo.ComboGrilla(ModeloFuncionalPublic.Where(Function(item) item.Extras(0) = 0).ToList), True)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LlenaCombos()
        Try

            'Cargar Estados Vehiculo
            loConcepto = New List(Of e_Concepto)
            oeConcepto = New e_Concepto
            oeConcepto.Activo = True
            oeConcepto.Prefijo = "23"
            loConcepto = olConcepto.Listar(oeConcepto)
            cboEstadoMan.DataSource = loConcepto
            cboEstadoMan.DisplayMember = "Nombre"
            cboEstadoMan.ValueMember = "Valor1"
            cboEstadoMan.Value = 3

            cboVehiculoEstado.DataSource = loConcepto
            cboVehiculoEstado.DisplayMember = "Nombre"
            cboVehiculoEstado.ValueMember = "Valor1"
            cboVehiculoEstado.Value = 3

            'Cargar Clasificacion EMP Vehiculo
            oeConcepto = New e_Concepto
            oeConcepto.Activo = True
            oeConcepto.Prefijo = "24"
            loConcepto = olConcepto.Listar(oeConcepto)
            cboClasificacionISL.DataSource = loConcepto
            cboClasificacionISL.DisplayMember = "Nombre"
            cboClasificacionISL.ValueMember = "Valor1"

            'Cargar tipo carroceria Vehiculo
            oeConcepto = New e_Concepto
            oeConcepto.Activo = True
            oeConcepto.Prefijo = "25"
            loConcepto = olConcepto.Listar(oeConcepto)
            cboTipoCarroceria.DataSource = loConcepto
            cboTipoCarroceria.DisplayMember = "Nombre"
            cboTipoCarroceria.ValueMember = "Valor1"
            '@0001 Ini
            'Cargar MODALIDAD Vehiculo
            oeConcepto = New e_Concepto
            oeConcepto.Activo = True
            oeConcepto.Prefijo = "251"
            loConcepto = olConcepto.Listar(oeConcepto)
            cboModalidad.DataSource = loConcepto
            cboModalidad.DisplayMember = "Nombre"
            cboModalidad.ValueMember = "Valor1"

            'Cargar RUTA ASIGNADA Vehiculo
            oeConcepto = New e_Concepto
            oeConcepto.Activo = True
            oeConcepto.Prefijo = "252"
            loConcepto = olConcepto.Listar(oeConcepto)
            cboRutaAsignada.DataSource = loConcepto
            cboRutaAsignada.DisplayMember = "Nombre"
            cboRutaAsignada.ValueMember = "Valor1"
            '@0001 Fin

            'Tipo Vehiculo, Modelo Funcional y Tipo Carroceria se llenar de acuerdo al IndMotriz
            'Llenar Combo Marca
            LlenaComboMarca()
            'Modelo y Modelo Sunarp se Llena de Acuerdo a la Marca
            'Combos Flota
            LlenarComboMaestro(cboFlota, FlotaPublic.Where(Function(Item) Item.Nombre <> "TODOS").ToList, 0)
            LlenarComboMaestro(cboFlotaMasiva, FlotaPublic.Where(Function(Item) Item.Nombre <> "TODOS").ToList, 1)
            LlenarComboMaestro(cboAsignacionFlota, FlotaPublic.Where(Function(Item) Item.Nombre <> "TODOS").ToList, 1)
            LlenarCombo(cboFlotaSituacional, "Nombre", FlotaPublic.Where(Function(Item) Item.Id <> "1CH013" And Item.Id <> "1CH017" _
                                                                             And Item.Id <> "1CH012" And Item.Id <> "1CH014" And Item.Id <> "1CH004").ToList, 0)
            'Combo Propietario y Empresa GPS
            LlenaComboPropietario()
            'Combo Tipo Combustible
            LlenaComboTipoCombustible()
            'Combo Configuracion Grafica
            LlenaComboConfiguracionNeumaticos()
            'Combo Configuracion MTC
            Dim olConfiguracionMTC As New l_ConfiguracionMTC
            LlenarComboMaestro(cboConfiguracionMTC, olConfiguracionMTC.Listar(New e_ConfiguracionMTC), 0)
            'Combo Piloto
            LlenarComboMaestro(cboPilotoAsignado, TrabajadorPublic, -1)
            'Combo Empresa Prestadora de Tarjetas
            mt_CargarComboEmpr()
            'Tipo de Dispositivo
            ListaTipoDispositivo = New List(Of e_TipoDocumento)
            Dim Odometro As New e_TipoDocumento
            With Odometro
                .Id = "1CH0000001"
                .Nombre = "ODOMETRO"
                ListaTipoDispositivo.Add(Odometro)
            End With
            Dim Horometro = New e_TipoDocumento
            With Horometro
                .Id = "1CH0000002"
                .Nombre = "HOROMETRO"
                ListaTipoDispositivo.Add(Horometro)
            End With
            LlenarComboMaestro(cboTipoDispositivo, ListaTipoDispositivo, 0)
            'Modelo Funcional Masivo
            LlenarComboMaestro(cboModeloFuncionalMasivo, ModeloFuncionalPublic, 1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarComboEmpr()
        Try
            Dim olEmpresa As New l_Empresa
            Dim loEmpresa As New List(Of e_Empresa)
            Dim oeTipoEmpresa As New e_TipoEmpresa
            oeTipoEmpresa.Codigo = "000008" 'PRESTADORAS DE SERVICIOS TARJETAS
            Dim olTipoEmpresa As New l_TipoEmpresa
            Dim loTipoEmpresa As New List(Of e_TipoEmpresa)
            loTipoEmpresa.AddRange(olTipoEmpresa.Listar(oeTipoEmpresa))
            If loTipoEmpresa.Count > 0 Then
                loEmpresa.Add(New e_Empresa With {.Id = gs_IdEmpresaSistema.Trim, .Nombre = gs_TxtEmpresaSistema.Trim})
                loEmpresa.AddRange(
                    olEmpresa.Listar(New e_Empresa With {.IdTipoEmpresa = loTipoEmpresa(0).Id})
                    )
            End If
            cmbCovEmpProp.DataSource = loEmpresa
            cmbCovEmpProp.DisplayMember = "Nombre"
            cmbCovEmpProp.ValueMember = "Id"
            If CType(cmbCovEmpProp.DataSource, List(Of e_Empresa)).Where(Function(x) x.Id = IdEmpresaCovisol).Count > 0 Then
                cmbCovEmpProp.Value = IdEmpresaCovisol
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub txtCovTarjeta_Validated(sender As Object, e As EventArgs) Handles txtCovTarjeta.Validated
        Try
            mt_FormatearNroTarjeta()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function fc_FormatoTarjeta(Texto As String, Cantidad As Integer) As String
        Try
            Dim ln As String = ""
            For i As Integer = 1 To Cantidad - Texto.Length
                ln = ln + "0"
            Next
            Return ln + Texto
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub mt_FormatearNroTarjeta()
        Try
            If Not String.IsNullOrEmpty(txtCovTarjeta.Text.Trim()) AndAlso cmbCovEmpProp.SelectedIndex <> -1 Then
                Select Case cmbCovEmpProp.Value
                    Case IdEmpresaCovisol
                        txtCovTarjeta.Text = fc_FormatoTarjeta(txtCovTarjeta.Text.Trim(), 16)
                End Select
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Vehiculo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gf_AsignarEventoSeleccionarTexto(Me)
            If IndConsultaGuardar Then
                tcVehiculo.Tabs(1).Enabled = False
                LlenaCombos()
            End If
            LlenaCombosGrilla()
            mt_ConfigurarGrilla()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mt_ConfigurarGrilla()
        Try
            'Asociar Lista con Grilla
            griLista.DataSource = loVehiculo
            'Deshabilitar Ordenar Grilla Tarjetas Peaje
            For Each _Columna In griTarjetaCovisol.DisplayLayout.Bands(0).Columns
                _Columna.SortIndicator = SortIndicator.Disabled
            Next
            'Deshabilitar Ordenar Grilla Placa
            For Each _Columna In griHistorialPlaca.DisplayLayout.Bands(0).Columns
                _Columna.SortIndicator = SortIndicator.Disabled
            Next
            'Deshabilitar Ordenar Grilla Estados
            For Each _Columna In griEstados.DisplayLayout.Bands(0).Columns
                _Columna.SortIndicator = SortIndicator.Disabled
            Next
            'Deshabilitar Ordenar Grilla Flota
            For Each _Columna In griAsignacionFlota.DisplayLayout.Bands(0).Columns
                _Columna.SortIndicator = SortIndicator.Disabled
            Next
            'Configurar Grilla Mantenimiento
            CargarProyMantenimiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarProyMantenimiento()
        Try
            With griMantenimiento
                OcultarColumna(griMantenimiento, True, "Fecha", "KmMantenimiento", "KmProyectado", "Unidad", "Codigo", "UnidadMedida", "Horometro", "Motriz", "Marca", "Modelo")
                .DisplayLayout.Bands(0).Columns("Kilometraje").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("FechaUltimoMant").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("NroUltimoOT").Header.VisiblePosition = 8
                .DisplayLayout.Bands(0).Columns("FechaUltimoMant").Width = 110
                .DisplayLayout.Bands(0).Columns("KmUltimoServicio").Header.Caption = "Km. Ult. Serv."
                .DisplayLayout.Bands(0).Columns("Motriz").Style = ColumnStyle.CheckBox
                FormatoColumna(griMantenimiento, "", ColumnStyle.DateTime, HAlign.Default, "FechaUltimoMant")
                FormatoColumna(griMantenimiento, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Kilometraje", "Cantidad", "KmUltimoServicio", "Horometro", "CantidadProx", "Diferencia")
                ColorFondoColumna(griMantenimiento, Color.LightGreen, "Fecha", "Kilometraje")
                ColorFondoColumna(griMantenimiento, Color.Thistle, "KMProyectado", "KmMantenimiento")
                ColorFondoColumna(griMantenimiento, Color.LightBlue, "FechaUltimoMant", "NroUltimoOT", "KmUltimoServicio", "UltimoMant")
                .Font = New System.Drawing.Font("Tahoma", 8.25!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub txtPlaca_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPlaca.KeyPress, _
        txtCodigo.KeyPress, txtSerieMotor.KeyPress, txtColor.KeyPress, numAncho.KeyPress, numLargo.KeyPress, numAltura.KeyPress, numTara.KeyPress, numCargaUtil.KeyPress, _
            txtNroMTC.KeyPress, numCubicaje.KeyPress, numEjes.KeyPress, numRuedas.KeyPress, numLlantasRepuesto.KeyPress
        Try
            If Operacion = "Nuevo" Or Operacion = "Editar" Then
                oeVehiculo.Modificado = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub verActivo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If Operacion = "Nuevo" Or Operacion = "Editar" Then
                oeVehiculo.Modificado = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Vehiculo_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Try
            mt_ControlBotoneria()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Vehiculo_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            instancia = Nothing
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Vehiculo_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If IndConsultaGuardar Then
                Select Case Operacion
                    Case "Nuevo"
                        Me.Activate()
                        Me.Cancelar()
                    Case "Editar"
                        Me.Activate()
                        Me.Cancelar()
                End Select
                e.Cancel = _ingresando_datos
                If Not e.Cancel Then
                    ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
                End If
            Else
                Me.Dispose()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Vehiculo_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case tcVehiculo.SelectedTab.Index
                Case 0
                Case 1
                    Select Case e.KeyCode
                        Case Keys.Enter
                            SendKeys.Send("{TAB}")
                    End Select
                    Select Case tabs.SelectedTab.Index
                        Case tabPlacas.Tab.Index
                            Select Case e.KeyCode
                                Case Keys.Insert
                                    tsbAgregarPlaca.PerformClick()
                                Case Keys.Delete
                                    tsbQuitarPlaca.PerformClick()
                            End Select
                        Case tabEstados.Tab.Index
                            Select Case e.KeyCode
                                Case Keys.Insert
                                    tsbAgregarEstado.PerformClick()
                                Case Keys.Delete
                                    tsbQuitarEstado.PerformClick()
                            End Select
                        Case tabDispositivos.Tab.Index
                            Select Case e.KeyCode
                                Case Keys.Insert
                                    tsbAgregarDispositivo.PerformClick()
                                Case Keys.Delete
                                    tsbQuitarDispositivo.PerformClick()
                            End Select
                        Case tabBonificacion.Tab.Index
                            Select Case e.KeyCode
                                Case Keys.Insert
                                    tsbAgregarBonificacion.PerformClick()
                                Case Keys.Delete
                                    tsbQuitarBonificacion.PerformClick()
                            End Select
                        Case tabFlota.Tab.Index
                            Select Case e.KeyCode
                                Case Keys.Insert
                                    tsbAgregarFlota.PerformClick()
                                Case Keys.Delete
                                    tsbQuitarFlota.PerformClick()
                            End Select
                        Case TabTarjetasCovisol.Tab.Index
                            Select Case e.KeyCode
                                Case Keys.Insert
                                    tsbAgregarTarj.PerformClick()
                                Case Keys.Delete
                                    tsbQuitarTarj.PerformClick()
                            End Select
                    End Select
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtObservacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtObservacion.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtNroEquipoMovil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroEquipoMovil.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnDescargar_Click(sender As Object, e As EventArgs) Handles btnDescargarJpg.Click
        Try
            If upbFoto.Image IsNot Nothing Then
                Dim NombreArchivo As String = ""
                Dim sfd_Dialogo As New System.Windows.Forms.SaveFileDialog
                sfd_Dialogo.Filter = "Imágenes JPG (*.jpg)|*.jpg"
                sfd_Dialogo.DefaultExt = "jpg"
                sfd_Dialogo.FilterIndex = 1
                sfd_Dialogo.Title = "Guardar imagen ..."
                sfd_Dialogo.FileName = txtPlaca.Text.Trim
                Dim result As DialogResult = sfd_Dialogo.ShowDialog()
                If result = DialogResult.Cancel Then Return
                Dim stNombreArchivo As String = sfd_Dialogo.FileName
                imagenGuardar.Image.Save(stNombreArchivo, System.Drawing.Imaging.ImageFormat.Jpeg)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboPilotoAsignado_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles cboPilotoAsignado.InitializeLayout
        Try
            With cboPilotoAsignado.DisplayLayout.Bands(0)
                .Columns("Id").Hidden = True
                .Columns("Nombre").Hidden = False
                .Columns("Nombre").Width = 400
                .Columns("Descripcion").Hidden = True
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griLista_Click(sender As Object, e As EventArgs) Handles griLista.Click
        Try
            If griLista.ActiveRow IsNot Nothing AndAlso griLista.ActiveRow.Index >= 0 Then
                IdUnidad = griLista.ActiveRow.Cells("Id").Value.ToString
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaSituacional_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griListaSituacional.BeforeRowsDeleted
        Try
            e.Cancel = True
            e.DisplayPromptMsg = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griLista_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griLista.CellChange
        Try
            griLista.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboModeloFuncionalMasivo_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles cboModeloFuncionalMasivo.EditorButtonClick
        Try
            'Si existen registros visibles y aceptan mensaje de confirmación
            If griLista.Rows.Where(Function(item) item.IsFilteredOut = False).Count > 0 AndAlso MessageBox.Show("¿Desea cambiar el modelo funcional de la lista activa por: " & cboModeloFuncionalMasivo.Text & "?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                mt_IniciaCursorEspera()
                'Actualizar 
                For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLista.Rows.Where(Function(item) item.IsFilteredOut = False)
                    Fila.Cells("IdModeloFuncional").Value = cboModeloFuncionalMasivo.Value
                Next
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            mt_FinCursorEspera()
        End Try
    End Sub

    Private Sub cboFlotaMasiva_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles cboFlotaMasiva.EditorButtonClick
        Try
            'Si existen registros visibles y aceptan mensaje de confirmación
            If griLista.Rows.Where(Function(item) item.IsFilteredOut = False).Count > 0 AndAlso MessageBox.Show("¿Desea cambiar la flota de la lista activa por: " & cboFlotaMasiva.Text & "?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                mt_IniciaCursorEspera()
                'Cambiar en la Grilla 
                For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLista.Rows.Where(Function(item) item.IsFilteredOut = False)
                    Fila.Cells("IdFlota").Value = cboFlotaMasiva.Value
                Next
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            mt_FinCursorEspera()
        End Try
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            _acl = gAccionSistema.LECTURA.ToString
            If Not ValidarAcl(_acl, pIdActividadNegocio) Then
                If griLista.Rows.Where(Function(item) item.IsFilteredOut = False).Count > 0 AndAlso MessageBox.Show("¿Desea actualizar todos los registros de la lista activa? ", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    mt_IniciaCursorEspera()
                    For Each Fila As UltraGridRow In griLista.Rows.Where(Function(item) item.IsFilteredOut = False)
                        oeVehiculo = New e_Vehiculo
                        With oeVehiculo
                            .TipoOperacion = "L"
                            .Id = RTrim(Fila.Cells("Id").Value)
                            .IdModeloFuncional = Fila.Cells("IdModeloFuncional").Value
                            .IdFlota = Fila.Cells("IdFlota").Value
                            .Ancho = Fila.Cells("Ancho").Value
                            .Largo = Fila.Cells("Largo").Value
                            .Alto = Fila.Cells("Alto").Value
                            .Tara = Fila.Cells("Tara").Value
                            .NroEjes = Fila.Cells("NroEjes").Value
                            .NroNeumaticos = Fila.Cells("NroNeumaticos").Value
                            .UsuarioCreacion = gUsuarioSGI.Id
                        End With
                        oeVehiculo.PrefijoID = gs_PrefijoIdSucursal '@0001
                        If olVehiculo.Guardar(oeVehiculo) Then
                            Fila.CellAppearance.BackColor = Me.ColorBloque.Color
                        End If
                    Next
                End If
            Else
                Throw New Exception("Usted Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            mt_FinCursorEspera()
        End Try
    End Sub

    Private Sub griLista_ClickCellButton(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griLista.ClickCellButton
        Try
            _acl = gAccionSistema.LECTURA.ToString
            If Not ValidarAcl(_acl, pIdActividadNegocio) Then
                Select Case e.Cell.Column.Key
                    Case "ModeloFuncional" 'Guardar
                        If (gUsuarioSGI.leARUsuario.Where(Function(item) item.IdActividadNegocio = gActividadNegocio.ActualizaMaestraVehiculo And _
                            item.AccionSistema = gAccionSistema.ACTUALIZAR.ToString() And item.IdProcesoNegocio = pProcesoNegocio)).Count = 0 Then
                            If MessageBox.Show("Desea guardar las modificaciones realizadas en el registro activo?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                mt_IniciaCursorEspera()
                                oeVehiculo = New e_Vehiculo
                                With oeVehiculo
                                    .TipoOperacion = "L"
                                    .Id = RTrim(griLista.ActiveRow.Cells("Id").Value)
                                    .IdModeloFuncional = griLista.ActiveRow.Cells("IdModeloFuncional").Value
                                    .IdFlota = griLista.ActiveRow.Cells("IdFlota").Value
                                    .Ancho = griLista.ActiveRow.Cells("Ancho").Value
                                    .Largo = griLista.ActiveRow.Cells("Largo").Value
                                    .Alto = griLista.ActiveRow.Cells("Alto").Value
                                    .Tara = griLista.ActiveRow.Cells("Tara").Value
                                    .NroEjes = griLista.ActiveRow.Cells("NroEjes").Value
                                    .NroNeumaticos = griLista.ActiveRow.Cells("NroNeumaticos").Value
                                    .IndPropiedad = griLista.ActiveRow.Cells("IndPropiedad").Value
                                    .Capacidad = griLista.ActiveRow.Cells("Capacidad").Value
                                    .UsuarioCreacion = gUsuarioSGI.Id
                                    .IndProrrateo = griLista.ActiveRow.Cells("IndProrrateo").Value
                                End With
                                oeVehiculo.PrefijoID = gs_PrefijoIdSucursal '@0001
                                If olVehiculo.Guardar(oeVehiculo) Then
                                    griLista.ActiveRow.CellAppearance.BackColor = Me.ColorBloque.Color
                                End If
                            End If
                        Else
                            mensajeEmergente.Confirmacion("Usted no esta autorizado para ACTUALIZAR VEHICULOS", True)
                        End If
                End Select
            Else
                Throw New Exception("Usted Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            mt_FinCursorEspera()
        End Try
    End Sub

    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click
        Try
            FotoInsert = 0
            FotoRuta = ""
            FotoTamaño = 0
            Dim ofd_Imagen As New OpenFileDialog
            With ofd_Imagen
                .Filter = "Imágenes JPG (*.jpg)|*.jpg"
                .FilterIndex = 1
                .Title = "Abrir imagen ..."
            End With
            If ofd_Imagen.ShowDialog = Windows.Forms.DialogResult.OK Then
                FotoRuta = ofd_Imagen.FileName
                Fs = New FileStream(ofd_Imagen.FileName, IO.FileMode.Open, IO.FileAccess.Read)
                upbFoto.Image = System.Drawing.Image.FromStream(Fs)
                FotoInsert = 1
            End If
            ofd_Imagen.Dispose()
            ofd_Imagen = Nothing
            If FotoRuta <> "" Then
                Dim fichero As New FileInfo(FotoRuta)
                FotoTamaño = fichero.Length
                If FotoTamaño > 51200 Then
                    FotoRuta = ""
                    Fs.Dispose()
                    upbFoto.Image = Nothing
                    Throw New Exception("El tamaño del archivo es: " & FormatNumber((FotoTamaño / 1024), 2) & " KB. excede a lo permito de 50 KB.")
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboEmpresaGPS_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles cboEmpresaGPS.InitializeLayout
        Try
            With cboEmpresaGPS.DisplayLayout.Bands(0)
                .Columns("Id").Hidden = True
                .Columns("Nombre").Hidden = False
                .Columns("Nombre").Width = 300
                .Columns("Descripcion").Hidden = False
                .Columns("Descripcion").Header.Caption = "RUC"
                .Columns("Descripcion").Width = 100
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboPropietario_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles cboPropietario.InitializeLayout
        Try
            With cboPropietario.DisplayLayout.Bands(0)
                .Columns("Id").Hidden = True
                .Columns("Nombre").Hidden = False
                .Columns("Nombre").Width = 300
                .Columns("Descripcion").Hidden = False
                .Columns("Descripcion").Header.Caption = "RUC"
                .Columns("Descripcion").Width = 100
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Try
            FotoInsert = 0
            upbFoto.Image = Nothing
            oeVehiculo.Foto = Nothing
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Vehiculo_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Try
            ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDocumentoVehicular_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griDocumentoVehicular.BeforeRowsDeleted
        Try
            e.Cancel = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnConsultarDisponibles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarDisponibles.Click
        Try
            ListarVehiculosMantenimiento()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboMarca_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMarca.ValueChanged
        Try
            oeModeloVehiculo = New e_Modelo
            oeModeloVehiculo.IdMarca = cboMarca.Value
            Dim ListModeloVehiculo As New List(Of e_Modelo)
            ListModeloVehiculo.AddRange(olModeloVehiculo.Listar(oeModeloVehiculo))
            LlenarComboMaestro(cboModelo, ListModeloVehiculo.Where(Function(Item) Item.IndEmpresa = 1).ToList, -1)
            LlenarComboMaestro(cboModeloSunarp, ListModeloVehiculo.Where(Function(Item) Item.IndSunarp = 1).ToList, -1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griLista_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griLista.BeforeRowsDeleted
        Try
            e.Cancel = True
            'e.DisplayPromptMsg = False
            'If EliminarVehiculo() Then
            '    e.Cancel = False
            'Else
            '    e.Cancel = True
            'End If
        Catch ex As Exception
            e.Cancel = True
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griLista_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles griLista.DoubleClickRow
        Try
            If griLista.Selected.Rows.Count > 0 Then Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub verMotriz_CheckedChanged(sender As Object, e As EventArgs) Handles verMotriz.CheckedChanged
        Try
            oeCombo = New e_Combo
            With oeCombo
                .Id = IIf(verMotriz.Checked, 1, 0)
                .Nombre = "UNIDADTIPOVEHICULO"
                .Descripcion = "TIPOVEHICULO"
            End With
            LlenarComboMaestro(cboTipoVehiculo, olCombo.Listar(oeCombo), -1)
            oeCombo.Descripcion = "TIPOFUNCIONAL"
            LlenarComboMaestro(cboModeloFuncional, olCombo.Listar(oeCombo), -1)
            oeCombo.Descripcion = "TIPOSUNARP"
            LlenarComboMaestro(cboTipoCarroceriaSunarp, olCombo.Listar(oeCombo), -1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gridControlDoc_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles gridControlDoc.BeforeRowsDeleted
        Try
            e.Cancel = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboModeloFuncionalMasivo_MouseEnterElement(sender As Object, e As Infragistics.Win.UIElementEventArgs) Handles cboModeloFuncionalMasivo.MouseEnterElement
        Dim boton As Object = Nothing
        Try
            boton = e.Element.GetContext()
            If e.Element.GetType() = GetType(EditorButtonUIElement) AndAlso e.Element.Parent.ControlElement.Equals(cboModeloFuncionalMasivo.UIElement.ControlElement) AndAlso boton.Equals(cboModeloFuncionalMasivo.ButtonsRight("b1")) Then
                t1.ToolTipText = "Cambiar Modelo Funcional en todos los registros de la grilla activa"
                t1.ToolTipTitle = "SGI-ISL"
                UltraToolTipManager1.SetUltraToolTip(cboModeloFuncionalMasivo, t1)
                UltraToolTipManager1.ShowToolTip(cboModeloFuncionalMasivo)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            boton = Nothing
        End Try
    End Sub

    Private Sub cboFlotaMasiva_MouseEnterElement(sender As Object, e As Infragistics.Win.UIElementEventArgs) Handles cboFlotaMasiva.MouseEnterElement
        Dim boton As Object = Nothing
        Try
            boton = e.Element.GetContext()
            If e.Element.GetType() = GetType(EditorButtonUIElement) AndAlso e.Element.Parent.ControlElement.Equals(cboFlotaMasiva.UIElement.ControlElement) AndAlso boton.Equals(cboFlotaMasiva.ButtonsRight("b1")) Then
                t1.ToolTipText = "Cambiar Flota en todos los registros de la grilla activa"
                t1.ToolTipTitle = "SGI-ISL"
                UltraToolTipManager1.SetUltraToolTip(cboFlotaMasiva, t1)
                UltraToolTipManager1.ShowToolTip(cboFlotaMasiva)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            boton = Nothing
        End Try
    End Sub

    Private Sub griListaSituacional_ClickCellButton(sender As Object, e As CellEventArgs) Handles griListaSituacional.ClickCellButton
        Try
            _acl = gAccionSistema.LECTURA.ToString
            If Not ValidarAcl(_acl, pIdActividadNegocio) Then
                If griListaSituacional.ActiveCell.Row.Index > -1 Then
                    Dim _oeVehEstado As New e_VehiculoEstado, _leVehEstado As New List(Of e_VehiculoEstado)
                    _oeVehEstado.IdVehiculo = griListaSituacional.ActiveCell.Row.Cells("Id").Value
                    _leVehEstado = olVehiculo.ListarEstado(_oeVehEstado)
                    If _leVehEstado.Where(Function(it) it.Actual).ToList.Count > 0 Then
                        griListaSituacional.UpdateData()
                        _oeVehEstado = New e_VehiculoEstado
                        _oeVehEstado.Id = _leVehEstado(0).Id
                        _oeVehEstado.Observacion = griListaSituacional.ActiveCell.Value.trim
                        _oeVehEstado.TipoOperacion = "O"
                        If olVehiculo.EditarEstado(_oeVehEstado) Then
                            mensajeEmergente.Confirmacion("Se guardo correctamente la informacion", True)
                            Consultar(True)
                        End If
                    Else
                        Throw New Exception("Ingrese Estado Actual del Vehiculo")
                    End If
                End If
            Else
                Throw New Exception("Usted Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Menú Contextual"

    Private Sub InsertarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertarToolStripMenuItem.Click
        Try
            Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        Try
            Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Try
            Eliminar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        Try
            MenuContextual1.Items("InsertarToolStripMenuItem").Visible = True
            If griLista.Selected.Rows.Count > 0 Then
                MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
                MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
            Else
                MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
                MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Tab Placas"

    Private Sub tspPlacas_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tspPlacas.ItemClicked
        Try
            Select Case e.ClickedItem.Name
                Case tsbAgregarPlaca.Name
                    mt_AgregarPlaca()
                Case tsbQuitarPlaca.Name
                    mt_QuitarPlaca()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function lf_ValidarPlaca() As Boolean
        Try
            If String.IsNullOrWhiteSpace(txtHisPlaca.Text) Then
                mensajeEmergente.Problema("Ingrese placa", True)
                txtHisPlaca.Focus()
                Return False
            End If
            If txtHisPlaca.Text.Trim().Length < 5 Then
                mensajeEmergente.Problema("Ingrese placa válida", True)
                txtHisPlaca.Focus()
                Return False
            End If
            If loPlaca.Where(Function(x) x.TipoOperacion <> "E" And x.Nombre = txtHisPlaca.Text.Trim()).Count > 0 Then
                mensajeEmergente.Problema("La placa ya se encuentra agregada a la lista", True)
                txtHisPlaca.Focus()
                Return False
            End If
            If loPlaca.Where(Function(x) x.TipoOperacion <> "E").Count > 0 Then
                Dim ldUltimaFecha As Date = loPlaca.Where(Function(x) x.TipoOperacion <> "E").OrderByDescending(Function(x) x.FechaInicio).ThenByDescending(Function(x) x.Actual).ToList(0).FechaInicio
                If DateTime.Compare(ldUltimaFecha.Date, fecHisInicio.Value.Date) > 0 Then
                    MessageBox.Show("La fecha ingresada debe ser mayor a la ultima Fecha: " & ldUltimaFecha.ToShortDateString(), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    fecHisInicio.Focus()
                    Return False
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub mt_AgregarPlaca()
        Try
            If lf_ValidarPlaca() Then
                oePlaca = New e_Placa
                With oePlaca
                    .Nombre = txtHisPlaca.Text.Trim()
                    .FechaInicio = fecHisInicio.Value.Date
                    .Actual = True
                End With
                For Each Placa As e_Placa In loPlaca
                    Placa.Actual = False
                Next
                loPlaca.Add(oePlaca)
                If loPlaca.Where(Function(x) x.Actual And x.TipoOperacion <> "E").Count > 0 Then
                    txtPlaca.Text = loPlaca.Where(Function(x) x.Actual And x.TipoOperacion <> "E")(0).Nombre
                End If
                griHistorialPlaca.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_QuitarPlaca()
        Try
            If gf_ValidarFilaSeleccionada(griHistorialPlaca) Then
                If gUsuarioSGI.Controlado = 0 Then
                    With griHistorialPlaca
                        If Not String.IsNullOrEmpty(.ActiveRow.Cells("Id").Value.ToString().Trim()) Then
                            loPlaca(loPlaca.IndexOf(.ActiveRow.ListObject)).TipoOperacion = "E"
                            .ActiveRow.Hidden = True
                        Else
                            loPlaca.Remove(.ActiveRow.ListObject)
                        End If
                        .DataBind()
                        'Marcar el último registro como actual
                        If loPlaca.Where(Function(x) x.TipoOperacion <> "E").Count > 0 AndAlso _
                             loPlaca.Where(Function(x) x.TipoOperacion <> "E" And x.Actual).Count = 0 Then
                            .Rows.Where(Function(x) x.Hidden = False).OrderByDescending(Function(x) x.Index)(0).Cells("Actual").Value = 1
                            .UpdateData()
                        End If
                    End With
                Else
                    MessageBox.Show("Usted no tiene permiso para eliminar una placa", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griHistorialPlaca_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griHistorialPlaca.BeforeRowsDeleted
        Try
            e.Cancel = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griHistorialPlaca_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griHistorialPlaca.CellChange
        Try
            griHistorialPlaca.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griHistorialPlaca_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles griHistorialPlaca.BeforeCellUpdate
        Try
            If e.Cell.Row.Index >= 0 Then
                Select Case e.Cell.Column.Key
                    Case "Actual"
                        bolExistRowCheck = loPlaca.Exists(Function(x) x.Actual And x.TipoOperacion <> "E")
                End Select
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griHistorialPlaca_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles griHistorialPlaca.AfterCellUpdate
        Try
            If e.Cell.Row.Index >= 0 Then
                Select Case e.Cell.Column.Key
                    Case "Actual"
                        If bolExistRowCheck Then
                            For Each Placa As e_Placa In loPlaca.Where(Function(x) x.Actual And x.TipoOperacion <> "E")
                                If Placa.Actual Then
                                    Placa.Actual = 0
                                End If
                            Next
                        End If
                        If loPlaca.Where(Function(x) x.Actual And x.TipoOperacion <> "E").Count > 0 Then
                            txtPlaca.Text = loPlaca.Where(Function(x) x.Actual And x.TipoOperacion <> "E")(0).Nombre
                        End If
                        griHistorialPlaca.DataBind()
                End Select
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Tab Estados"

    Private Sub tspEstados_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tspEstados.ItemClicked
        Try
            Select Case e.ClickedItem.Name
                Case tsbAgregarEstado.Name
                    mt_AgregarEstado()
                Case tsbQuitarEstado.Name
                    mt_QuitarEstado()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function lf_ValidarAgregarEstado() As Boolean
        Try
            If loVehiculoEstado.Where(Function(x) x.TipoOperacion <> "E").Count > 0 Then
                Dim ldUltimaFecha As Date = loVehiculoEstado.Where(Function(x) x.TipoOperacion <> "E").OrderByDescending(Function(x) x.FechaInicio.Date).ThenByDescending(Function(x) x.FechaFin.Date).ThenByDescending(Function(x) x.Actual).ToList()(0).FechaInicio
                If DateTime.Compare(ldUltimaFecha.Date, fecInicioEstado.Value.Date) > 0 Then
                    MessageBox.Show("La fecha ingresada debe ser mayor a la ultima Fecha: " & ldUltimaFecha.ToShortDateString(), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    fecInicioEstado.Focus()
                    Return False
                End If

                Dim intEstado As Integer = loVehiculoEstado.Where(Function(x) x.TipoOperacion <> "E").OrderByDescending(Function(x) x.FechaInicio.Date).ThenByDescending(Function(x) x.FechaFin.Date).ThenByDescending(Function(x) x.Actual).ToList()(0).Indicador
                'If opcVehiculoEstados.CheckedIndex = intEstado Then
                '    MessageBox.Show("Debe Ingresar un estado diferente al ultimo asignado: " & opcVehiculoEstados.CheckedItem.DisplayText, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                '    opcVehiculoEstados.Focus()
                '    Return False
                'End If
                If cboVehiculoEstado.Value = intEstado Then
                    MessageBox.Show("Debe Ingresar un estado diferente al ultimo asignado: " & cboVehiculoEstado.SelectedText, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cboVehiculoEstado.Focus()
                    Return False
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub mt_AgregarEstado()
        Try
            If lf_ValidarAgregarEstado() Then
                oeVehiculoEstado = New e_VehiculoEstado
                With oeVehiculoEstado
                    '.Indicador = opcVehiculoEstados.CheckedIndex
                    .Indicador = cboVehiculoEstado.Value
                    .Observacion = txtObservacionEstado.Text.Trim()
                    .FechaInicio = fecInicioEstado.Value.Date
                    .FechaFin = .FechaInicio
                    .UsuarioCrea = gUsuarioSGI.Id
                    .Actual = True
                End With
                'Colocar al Ultimo registro la Fecha Final = Fecha Inicio del que se Ingresa
                If loVehiculoEstado.Where(Function(x) x.TipoOperacion <> "E").Count > 0 Then
                    loVehiculoEstado.Where(Function(x) x.TipoOperacion <> "E").OrderByDescending(Function(x) x.FechaInicio.Date).ThenByDescending(Function(x) x.FechaFin.Date).ThenByDescending(Function(x) x.Actual).ToList()(0).FechaFin = DateAdd(DateInterval.Day, -1, oeVehiculoEstado.FechaInicio)
                End If
                'Colocar Actual 0 a todos los registros 
                For Each Estado As e_VehiculoEstado In loVehiculoEstado
                    Estado.Actual = False
                Next
                'Agregar estado a la lista
                loVehiculoEstado.Add(oeVehiculoEstado)
                'Actualizar Panel de estados de Cabecera
                If loVehiculoEstado.Where(Function(x) x.Actual And x.TipoOperacion <> "E").Count > 0 Then
                    'opcEstado.CheckedIndex = loVehiculoEstado.Where(Function(x) x.Actual And x.TipoOperacion <> "E")(0).Indicador
                    cboEstadoMan.Value = loVehiculoEstado.Where(Function(x) x.Actual And x.TipoOperacion <> "E")(0).Indicador
                End If
                griEstados.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_QuitarEstado()
        Try
            If gf_ValidarFilaSeleccionada(griEstados) Then
                If gUsuarioSGI.Controlado = 0 Then
                    With griEstados
                        If Not String.IsNullOrEmpty(.ActiveRow.Cells("Id").Value.ToString().Trim()) Then
                            loVehiculoEstado(loVehiculoEstado.IndexOf(.ActiveRow.ListObject)).TipoOperacion = "E"
                            loVehiculoEstado(loVehiculoEstado.IndexOf(.ActiveRow.ListObject)).UsuarioCrea = gUsuarioSGI.Id
                            .ActiveRow.Hidden = True
                        Else
                            loVehiculoEstado.Remove(.ActiveRow.ListObject)
                        End If
                        .DataBind()
                        'Marcar el último registro como actual
                        If loVehiculoEstado.Where(Function(x) x.TipoOperacion <> "E").Count > 0 AndAlso _
                             loVehiculoEstado.Where(Function(x) x.TipoOperacion <> "E" And x.Actual).Count = 0 Then
                            griEstados.Rows.Where(Function(x) x.Hidden = False).OrderByDescending(Function(x) x.Index)(0).Cells("Actual").Value = 1
                            griEstados.UpdateData()
                        End If
                    End With
                Else
                    MessageBox.Show("Usted no tiene permiso para eliminar un estado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub txtObservacionEstado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtObservacionEstado.KeyPress
        Try
            gmt_BloquearEnter(e)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griEstados_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griEstados.BeforeRowsDeleted
        Try
            e.Cancel = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griEstados_CellChange(sender As Object, e As CellEventArgs) Handles griEstados.CellChange
        Try
            griEstados.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griEstados_BeforeCellUpdate(sender As Object, e As BeforeCellUpdateEventArgs) Handles griEstados.BeforeCellUpdate
        Try
            If e.Cell.Row.Index >= 0 Then
                Select Case e.Cell.Column.Key
                    Case "Actual"
                        bolExistRowCheck = loVehiculoEstado.Exists(Function(x) x.Actual And x.TipoOperacion <> "E")
                End Select
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griEstados_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles griEstados.AfterCellUpdate
        Try
            If e.Cell.Row.Index >= 0 Then
                Select Case e.Cell.Column.Key
                    Case "Actual"
                        If bolExistRowCheck Then
                            For Each Estado As e_VehiculoEstado In loVehiculoEstado.Where(Function(x) x.Actual And x.TipoOperacion <> "E")
                                If Estado.Actual Then
                                    Estado.Actual = 0
                                End If
                            Next
                        End If
                        If loVehiculoEstado.Where(Function(x) x.Actual And x.TipoOperacion <> "E").Count > 0 Then
                            'opcEstado.CheckedIndex = loVehiculoEstado.Where(Function(x) x.Actual And x.TipoOperacion <> "E")(0).Indicador
                            cboEstadoMan.Value = loVehiculoEstado.Where(Function(x) x.Actual And x.TipoOperacion <> "E")(0).Indicador
                        End If
                        griEstados.DataBind()
                End Select
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Tab Dispositivos"

    Private Sub tspDispositivos_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tspDispositivos.ItemClicked
        Try
            Select Case e.ClickedItem.Name
                Case tsbAgregarDispositivo.Name
                    mt_AgregarDispositivo()
                Case tsbQuitarDispositivo.Name
                    mt_QuitarDispositivo()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function lf_ValidarAgregarDispositivo() As Boolean
        Try
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub mt_AgregarDispositivo()
        Try
            If lf_ValidarAgregarDispositivo() Then
                oeDispositivo = New e_Dispositivo
                With oeDispositivo
                    .IdTipoDispositivo = cboTipoDispositivo.Value
                    .NroSerie = txtDispNroSerie.Text.Trim()
                    .Cantidad = txtDispCantidad.Value
                    .FechaInicio = fecDispEnicio.Value.Date
                    .FechaUltimaAct = fecDispEnicio.Value.Date
                    .Actual = True
                End With
                For Each Dispositivo As e_Dispositivo In loDispositivo
                    Dispositivo.Actual = False
                Next
                loDispositivo.Add(oeDispositivo)
                griDispositivo.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_QuitarDispositivo()
        Try
            If gf_ValidarFilaSeleccionada(griDispositivo) Then
                With griDispositivo
                    If Not String.IsNullOrEmpty(.ActiveRow.Cells("Id").Value.ToString().Trim()) Then
                        loDispositivo(loDispositivo.IndexOf(.ActiveRow.ListObject)).TipoOperacion = "E"
                        .ActiveRow.Hidden = True
                    Else
                        loDispositivo.Remove(.ActiveRow.ListObject)
                    End If
                    .DataBind()
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griDispositivo_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griDispositivo.BeforeRowsDeleted
        Try
            e.Cancel = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDispositivo_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griDispositivo.CellChange
        Try
            griDispositivo.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDispositivo_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles griDispositivo.BeforeCellUpdate
        Try
            With griDispositivo
                Select Case e.Cell.Column.Key
                    Case "NroSerie"
                        If e.Cell.Column.Key = "NroSerie" Then If IsDBNull(e.NewValue) Then e.Cancel = True
                    Case "Cantidad"
                        If e.Cell.Column.Key = "Cantidad" Then If IsDBNull(e.NewValue) Then e.Cancel = True
                    Case "FechaInicio"
                        If e.Cell.Column.Key = "FechaInicio" Then If IsDBNull(e.NewValue) Then e.Cancel = True
                    Case "FechaAltimaAct"
                        If e.Cell.Column.Key = "FechaAltimaAct" Then If IsDBNull(e.NewValue) Then e.Cancel = True
                End Select
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Tab Bonificacion"

    Private Sub tsbBonificacion_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsbBonificacion.ItemClicked
        Try
            Select Case e.ClickedItem.Name
                Case tsbAgregarBonificacion.Name
                    mt_AgregarBonificacion()
                Case tsbQuitarBonificacion.Name
                    mt_QuitarBonificacion()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function lf_ValidarAgregarBonificacion() As Boolean
        Try
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub mt_AgregarBonificacion()
        Try
            If lf_ValidarAgregarBonificacion() Then
                oeBonificacion = New e_Bonificacion
                With oeBonificacion
                    .Numero = txtBoniNumero.Value
                    .Porcentaje = txtBoniPorcentaje.Value
                    .IndBonificacion = verBoniIndicador.Checked
                    .Observacion = txtBoniObservacion.Text.Trim()
                End With
                loBonificacion.Add(oeBonificacion)
                griBonificacion.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_QuitarBonificacion()
        Try
            If gf_ValidarFilaSeleccionada(griBonificacion) Then
                With griBonificacion
                    If Not String.IsNullOrEmpty(.ActiveRow.Cells("Id").Value.ToString().Trim()) Then
                        loBonificacion(loBonificacion.IndexOf(.ActiveRow.ListObject)).TipoOperacion = "E"
                        .ActiveRow.Hidden = True
                    Else
                        loBonificacion.Remove(.ActiveRow.ListObject)
                    End If
                    .DataBind()
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griBonificacion_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griBonificacion.BeforeRowsDeleted
        Try
            e.Cancel = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griBonificacion_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griBonificacion.CellChange
        Try
            griBonificacion.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griBonificacion_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles griBonificacion.BeforeCellUpdate
        Try
            With griBonificacion
                Select Case e.Cell.Column.Key
                    Case "Numero"
                        If e.Cell.Column.Key = "Numero" Then If IsDBNull(e.NewValue) Then e.Cancel = True
                    Case "Porcentaje"
                        If e.Cell.Column.Key = "Porcentaje" Then If IsDBNull(e.NewValue) Then e.Cancel = True
                End Select
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Tab Flota"

    Private Sub tsbFlota_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsbFlota.ItemClicked
        Try
            Select Case e.ClickedItem.Name
                Case tsbAgregarFlota.Name
                    mt_AgregarFlota()
                Case tsbQuitarFlota.Name
                    mt_QuitarFlota()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function lf_ValidarAgregarFlota() As Boolean
        Try
            If loAsignacionFlota.Where(Function(x) x.TipoOperacion <> "E").Count > 0 Then
                Dim ldUltimaFecha As Date = loAsignacionFlota.Where(Function(x) x.TipoOperacion <> "E").OrderByDescending(Function(x) x.FechaInicio.Date).ThenByDescending(Function(x) x.FechaFin.Date).ThenByDescending(Function(x) x.Actual).ToList()(0).FechaInicio
                If DateTime.Compare(ldUltimaFecha.Date, fecInicioAsigFlota.Value.Date) > 0 Then
                    MessageBox.Show("La fecha ingresada debe ser mayor a la ultima Fecha: " & ldUltimaFecha.ToShortDateString(), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    fecInicioAsigFlota.Focus()
                    Return False
                End If
                Dim strUltimaIdFlota As String = loAsignacionFlota.Where(Function(x) x.TipoOperacion <> "E").OrderByDescending(Function(x) x.FechaInicio.Date).ThenByDescending(Function(x) x.FechaFin.Date).ThenByDescending(Function(x) x.Actual).ToList()(0).IdFlota
                If cboAsignacionFlota.Value = strUltimaIdFlota Then
                    MessageBox.Show("Debe Ingresar una flota diferente a la ultima asignada " & cboAsignacionFlota.Text, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cboAsignacionFlota.Focus()
                    Return False
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub mt_AgregarFlota()
        Try
            If lf_ValidarAgregarFlota() Then
                oeAsignacionFlota = New e_AsignacionFlota
                With oeAsignacionFlota
                    .IdFlota = cboAsignacionFlota.Value
                    .Observacion = txtObservacionAsigFlota.Text.Trim()
                    .FechaInicio = fecInicioAsigFlota.Value
                    .FechaFin = fecInicioAsigFlota.Value
                    .UsuarioCrea = gUsuarioSGI.Id
                    .Actual = True
                End With
                'Colocar al Ultimo registro la Fecha Final = Fecha Inicio del que se Ingresa
                If loAsignacionFlota.Where(Function(x) x.TipoOperacion <> "E").Count > 0 Then
                    loAsignacionFlota.Where(Function(x) x.TipoOperacion <> "E").OrderByDescending(Function(x) x.FechaInicio.Date).ThenByDescending(Function(x) x.FechaFin.Date).ThenByDescending(Function(x) x.Actual).ToList()(0).FechaFin = oeAsignacionFlota.FechaInicio
                End If
                'Colocar Actual 0 a todos los registros
                For Each Flota As e_AsignacionFlota In loAsignacionFlota
                    Flota.Actual = False
                Next
                'Agregar flota a la lista
                loAsignacionFlota.Add(oeAsignacionFlota)
                'Actualizar flota de Cabecera
                If loAsignacionFlota.Where(Function(x) x.Actual And x.TipoOperacion <> "E").Count > 0 Then
                    cboFlota.Value = loAsignacionFlota.Where(Function(x) x.Actual And x.TipoOperacion <> "E")(0).IdFlota
                    mt_VerificarResponsableActual()
                End If
                griAsignacionFlota.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_QuitarFlota()
        Try
            If gf_ValidarFilaSeleccionada(griAsignacionFlota) Then
                If gUsuarioSGI.Controlado = 0 Then
                    With griAsignacionFlota
                        If Not String.IsNullOrEmpty(.ActiveRow.Cells("Id").Value.ToString().Trim()) Then
                            loAsignacionFlota(loAsignacionFlota.IndexOf(.ActiveRow.ListObject)).TipoOperacion = "E"
                            loAsignacionFlota(loAsignacionFlota.IndexOf(.ActiveRow.ListObject)).UsuarioCrea = gUsuarioSGI.Id
                            .ActiveRow.Hidden = True
                        Else
                            loAsignacionFlota.Remove(.ActiveRow.ListObject)
                        End If
                        .DataBind()
                        'Marcar el último registro como actual
                        If loAsignacionFlota.Where(Function(x) x.TipoOperacion <> "E").Count > 0 AndAlso _
                             loAsignacionFlota.Where(Function(x) x.TipoOperacion <> "E" And x.Actual).Count = 0 Then
                            .Rows.Where(Function(x) x.Hidden = False).OrderByDescending(Function(x) x.Index)(0).Cells("Actual").Value = 1
                            .UpdateData()
                        End If
                    End With
                Else
                    MessageBox.Show("Usted no tiene permiso para eliminar una flota", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griAsignacionFlota_CellChange(sender As Object, e As CellEventArgs) Handles griAsignacionFlota.CellChange
        Try
            griAsignacionFlota.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griAsignacionFlota_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griAsignacionFlota.BeforeRowsDeleted
        Try
            e.Cancel = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griAsignacionFlota_BeforeCellUpdate(sender As Object, e As BeforeCellUpdateEventArgs) Handles griAsignacionFlota.BeforeCellUpdate
        Try
            If e.Cell.Row.Index >= 0 Then
                Select Case e.Cell.Column.Key
                    Case "Actual"
                        bolExistRowCheck = loAsignacionFlota.Exists(Function(x) x.Actual And x.TipoOperacion <> "E")
                End Select
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griAsignacionFlota_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles griAsignacionFlota.AfterCellUpdate
        Try
            If e.Cell.Row.Index >= 0 Then
                Select Case e.Cell.Column.Key
                    Case "Actual"
                        If bolExistRowCheck Then
                            For Each Flota As e_AsignacionFlota In loAsignacionFlota.Where(Function(x) x.Actual And x.TipoOperacion <> "E")
                                If Flota.Actual Then
                                    Flota.Actual = 0
                                End If
                            Next
                        End If
                        If loAsignacionFlota.Where(Function(x) x.Actual And x.TipoOperacion <> "E").Count > 0 Then
                            cboFlota.Value = loAsignacionFlota.Where(Function(x) x.Actual And x.TipoOperacion <> "E")(0).IdFlota
                            mt_VerificarResponsableActual()
                        End If
                        griAsignacionFlota.DataBind()
                End Select
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mt_VerificarResponsableActual()
        Dim JefeFlotaActual As New e_Flota_Trabajador, olFlotaTrabajador As New l_Flota_Trabajador, lstFlotaTrabajador As New List(Of e_Flota_Trabajador)
        Try
            JefeFlotaActual.Actual = True
            JefeFlotaActual.IdFlota = cboFlota.Value
            lstFlotaTrabajador.AddRange(olFlotaTrabajador.Listar(JefeFlotaActual))
            If lstFlotaTrabajador.Count > 0 Then
                oeCombo = New e_Combo
                'Recupero Responsable Flota Actual
                If TrabajadorPublic.Where(Function(x) x.Id = lstFlotaTrabajador(0).IdTrabajador).Count > 0 Then
                    oeCombo = TrabajadorPublic.Where(Function(x) x.Id = lstFlotaTrabajador(0).IdTrabajador)(0)
                End If
                'Responsable Unidad Vacío
                If cboPilotoAsignado.SelectedRow Is Nothing Then
                    cboPilotoAsignado.Value = oeCombo.Id
                Else
                    'Responsable de la unidad lleno
                    If cboPilotoAsignado.Value <> lstFlotaTrabajador(0).IdTrabajador Then
                        tabDatosUnidades.Tabs(2).Selected = True
                        If MessageBox.Show("El responsable de la flota actual: " & oeCombo.Nombre & Environment.NewLine & _
                               "es diferente al seleccionado: " & cboPilotoAsignado.Text.Trim() & Environment.NewLine & _
                               "¿Desea cambiar el responsable de la unidad?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            cboPilotoAsignado.Value = lstFlotaTrabajador(0).IdTrabajador
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        Finally
            JefeFlotaActual = Nothing : olFlotaTrabajador = Nothing : lstFlotaTrabajador = Nothing
        End Try
    End Sub

#End Region

#Region "Tab Tarjetas Peaje"

    Private Sub tspTarjetasCovisol_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tspTarjetasCovisol.ItemClicked
        Try
            Select Case e.ClickedItem.Name
                Case tsbAgregarTarj.Name
                    mt_AgregarVehiculoTarjeta()
                Case tsbQuitarTarj.Name
                    mt_QuitarVehiculoTarjeta()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function fc_ValidarAgregarTarj() As Boolean
        Try
            If cmbCovEmpProp.SelectedIndex < 0 Then Throw New Exception("Seleccione Empresa")
            If String.IsNullOrEmpty(txtCovTarjeta.Text.Trim()) Then Throw New Exception("Digite numero de tarjeta")
            'Fecha menor al ultimo registro
            If loVehiculoTarj.Where(Function(x) x.TipoOperacion <> "E").Count > 0 Then
                oeVehiculoTarj = New e_VehiculoTarjeta
                oeVehiculoTarj = loVehiculoTarj.Where(Function(x) x.TipoOperacion <> "E").OrderBy(Function(x) x.FechaInicial)(0)
                Dim lnDiferencia As Integer = DateTime.Compare(oeVehiculoTarj.FechaInicial, dtpCovFecha.Value.Date)
                If lnDiferencia > 0 Then
                    MessageBox.Show("La fecha ingresada debe ser mayor o igual a la ultima fecha: " & oeVehiculoTarj.FechaInicial.ToString("dd/MM/yyyy"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtpCovFecha.Focus()
                    Return False
                End If
            End If
            'Tarjeta ya agregada a la lista
            If loVehiculoTarj.Where(Function(x) x.TipoOperacion <> "E" And x.IdEmpresaPropietaria = cmbCovEmpProp.Value And x.NroTarjeta = txtCovTarjeta.Text.Trim()).Count > 0 Then Throw New Exception("La tarjeta ingresada ya esta agregada a la lista")
            'Validar que todos los movimientos realizados con esa tarjeta esten asignados a sus respectivos viaje
            If loVehiculoTarj.Where(Function(x) x.TipoOperacion <> "E" And x.Actual = True).Count > 0 Then
                Return fc_MovimientosAsignadosViaje(loVehiculoTarj.Where(Function(x) x.TipoOperacion <> "E" And x.Actual = True)(0).NroTarjeta)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fc_MovimientosAsignadosViaje(Tarjeta As String) As Boolean
        Try
            Dim olTarjetaMov As New l_TarjetaMovimiento
            Dim loTarjetaMov As New List(Of e_TarjetaMovimiento)
            loTarjetaMov.AddRange(olTarjetaMov.Listar(New e_TarjetaMovimiento With {.TipoOperacion = "GEN", .NroTarjeta = Tarjeta}))
            'Buscar Movimientos desde hace un mes atras que no han sido ingresados y que comiencen y terminen con la misma letra de placa 
            If loTarjetaMov.Where(Function(x) x.Fecha >= Date.Now.AddMonths(-2).Date And x.IndIngresado = False And x.Placa.StartsWith(oeVehiculo.Placa.Trim.Substring(0, 1)) And x.Placa.EndsWith(oeVehiculo.Placa.Trim.Substring(txtPlaca.Text.Trim.Length - 1, 1))).Count > 0 Then
                MessageBox.Show("No se puede cambiar, porque la Tarjeta " & Tarjeta & Environment.NewLine & _
                                "aún tiene movimientos con la placa " & oeVehiculo.Placa.Trim, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub mt_AgregarVehiculoTarjeta()
        Try
            mt_FormatearNroTarjeta()
            If fc_ValidarAgregarTarj() Then
                oeVehiculoTarj = New e_VehiculoTarjeta
                With oeVehiculoTarj
                    .FechaInicial = dtpCovFecha.Value.Date
                    .FechaFinal = .FechaInicial
                    .IdEmpresaPropietaria = cmbCovEmpProp.Value
                    .EmpresaPropietaria = cmbCovEmpProp.Text
                    .NroTarjeta = txtCovTarjeta.Text.Trim()
                    .Glosa = txtCovGlosa.Text.Trim()
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .Actual = True
                End With
                'Colocar al Ultimo registro la Fecha Final = Fecha Inicio del que se Ingresa
                If loVehiculoTarj.Where(Function(x) x.TipoOperacion <> "E").Count > 0 Then
                    loVehiculoTarj.Where(Function(x) x.TipoOperacion <> "E").OrderByDescending(Function(x) x.FechaInicial.Date).ThenByDescending(Function(x) x.FechaFinal.Date).ThenByDescending(Function(x) x.Actual).ToList()(0).FechaFinal = oeVehiculoTarj.FechaInicial
                End If
                'Colocar a todos los registros actual = false
                For Each Tarjeta As e_VehiculoTarjeta In loVehiculoTarj
                    Tarjeta.Actual = False
                Next
                loVehiculoTarj.Add(oeVehiculoTarj)
                griTarjetaCovisol.DataBind()
                mt_InicializarTabTarjeta()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_QuitarVehiculoTarjeta()
        Try
            If griTarjetaCovisol.Selected.Rows.Count > 0 AndAlso griTarjetaCovisol.ActiveRow.Index >= 0 Then
                If fc_MovimientosAsignadosViaje(griTarjetaCovisol.ActiveRow.Cells("NroTarjeta").Value) Then
                    If String.IsNullOrEmpty(griTarjetaCovisol.ActiveRow.Cells("Id").Value.ToString().Trim()) Then
                        loVehiculoTarj.Remove(griTarjetaCovisol.ActiveRow.ListObject)
                    Else
                        loVehiculoTarj(loVehiculoTarj.IndexOf(griTarjetaCovisol.ActiveRow.ListObject)).TipoOperacion = "E"
                        loVehiculoTarj(loVehiculoTarj.IndexOf(griTarjetaCovisol.ActiveRow.ListObject)).UsuarioCreacion = gUsuarioSGI.Id
                        griTarjetaCovisol.ActiveRow.Hidden = True
                    End If
                    griTarjetaCovisol.DataBind()

                    'Marcar el último registro como actual
                    If loVehiculoTarj.Where(Function(x) x.TipoOperacion <> "E").Count > 0 AndAlso _
                         loVehiculoTarj.Where(Function(x) x.TipoOperacion <> "E" And x.Actual).Count = 0 Then
                        griTarjetaCovisol.Rows.Where(Function(x) x.Hidden = False).OrderByDescending(Function(x) x.Index)(0).Cells("Actual").Value = 1
                        griTarjetaCovisol.UpdateData()
                    End If
                End If
            Else
                MessageBox.Show("Seleccione registro a quitar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griTarjetaCovisol_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griTarjetaCovisol.BeforeRowsDeleted
        Try
            e.Cancel = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griTarjetaCovisol_CellChange(sender As Object, e As CellEventArgs) Handles griTarjetaCovisol.CellChange
        Try
            griTarjetaCovisol.UpdateData()
            'Por Cancelacion de quitar la fila actual
            griTarjetaCovisol.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griTarjetaCovisol_BeforeCellUpdate(sender As Object, e As BeforeCellUpdateEventArgs) Handles griTarjetaCovisol.BeforeCellUpdate
        Try
            If e.Cell.Row.Index >= 0 Then
                Select Case e.Cell.Column.Key
                    Case "Actual"
                        bolExistRowCheck = loVehiculoTarj.Exists(Function(x) x.Actual And x.TipoOperacion <> "E")
                        If bolExistRowCheck AndAlso Not fc_MovimientosAsignadosViaje(loVehiculoTarj.Where(Function(x) x.TipoOperacion <> "E" And x.Actual)(0).NroTarjeta) Then
                            e.Cancel = True
                        End If
                End Select
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griTarjetaCovisol_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles griTarjetaCovisol.AfterCellUpdate
        Try
            If e.Cell.Row.Index >= 0 Then
                Select Case e.Cell.Column.Key
                    Case "Actual"
                        If bolExistRowCheck Then
                            For Each Tarjeta As e_VehiculoTarjeta In loVehiculoTarj.Where(Function(x) x.Actual And x.TipoOperacion <> "E")
                                If Tarjeta.Actual Then
                                    Tarjeta.Actual = 0
                                End If
                            Next
                        End If
                        griTarjetaCovisol.DataBind()
                End Select
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Consulta Vehicular WebBrowser"

    Private Sub wbrConsultaVehicular_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wbrConsultaVehicular.DocumentCompleted
        Try
            If wbrConsultaVehicular.Url.ToString() = URLConsultaVehicular Then
                btnEnviarPlaca.Enabled = True
                btnObtenerDatos.Enabled = False
            Else
                btnEnviarPlaca.Enabled = False
                btnObtenerDatos.Enabled = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnEnviarPlaca_Click(sender As Object, e As EventArgs) Handles btnEnviarPlaca.Click
        Try
            wbrConsultaVehicular.Document.GetElementById("MainContent_txtNoPlac").InnerText = txtPlaca.Text.Trim()
            wbrConsultaVehicular.Document.GetElementById("MainContent_txtCaptcha").Focus()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnObtenerDatos_Click(sender As Object, e As EventArgs) Handles btnObtenerDatos.Click
        Try
            'If wbrConsultaVehicular.Document.GetElementById("MainContent_lblNuPlac") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(wbrConsultaVehicular.Document.GetElementById("MainContent_lblNuPlac").InnerText) Then
            '    With wbrConsultaVehicular.Document
            '        txtSerieChasis.Text = .GetElementById("MainContent_lblNoSeri").InnerText
            '        txtSerieMotor.Text = .GetElementById("MainContent_lblNoMotr").InnerText
            '        txtColor.Text = .GetElementById("MainContent_lblColr").InnerText
            '        'comprobar marca
            '        If lstMarca.Where(Function(x) x.Nombre = .GetElementById("MainContent_lblMarca").InnerText.Trim()).Count > 0 Then
            '            cboMarca.Value = lstMarca.Where(Function(x) x.Nombre = .GetElementById("MainContent_lblMarca").InnerText.Trim())(0).Id
            '            'Comprobar modelo
            '            oeModeloVehiculo = New e_Modelo
            '            oeModeloVehiculo.IdMarca = cboMarca.Value
            '            Dim ListModeloVehiculo As New List(Of e_Modelo)
            '            ListModeloVehiculo.AddRange(olModeloVehiculo.Listar(oeModeloVehiculo))
            '            If ListModeloVehiculo.Where(Function(Item) Item.IndSunarp = 1 And Item.Nombre.Replace(" ", "").ToUpper = .GetElementById("MainContent_lblModelo").InnerText.Trim().Replace(" ", "").ToUpper).Count > 0 Then
            '                cboModeloSunarp.Value = ListModeloVehiculo.Where(Function(Item) Item.IndSunarp = 1 And Item.Nombre.Replace(" ", "").ToUpper = .GetElementById("MainContent_lblModelo").InnerText.Trim().Replace(" ", "").ToUpper)(0).Id
            '            End If
            '        End If
            '        'Obtener Propietario
            '        oeCombo = New e_Combo
            '        oeCombo.Nombre = "EMPRESAINDICADOR"
            '        oeCombo.Descripcion = "PROPIETARIO"
            '        Dim lstPropietario As New List(Of e_Combo)
            '        lstPropietario.AddRange(olCombo.Listar(oeCombo))
            '        Dim _table As HtmlElement, _tr As HtmlElement, _td As HtmlElement
            '        _table = .GetElementById("MainContent_t_propietarios")
            '        For i = 0 To _table.GetElementsByTagName("tr").Count - 1
            '            _tr = _table.GetElementsByTagName("tr").Item(i)
            '            Select Case i
            '                Case 0
            '                    For j = 0 To _tr.GetElementsByTagName("td").Count - 1
            '                        _td = _tr.GetElementsByTagName("td").Item(j)
            '                        Select Case j
            '                            Case 0
            '                                If lstPropietario.Where(Function(x) x.Nombre = _td.InnerText.Trim()).Count > 0 Then
            '                                    cboPropietario.Value = lstPropietario.Where(Function(x) x.Nombre = _td.InnerText.Trim())(0).Id
            '                                End If
            '                        End Select
            '                    Next
            '            End Select
            '        Next
            '    End With
            'Else
            '    MessageBox.Show("No se encontraron datos", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    wbrConsultaVehicular.Navigate(URLConsultaVehicular)
            'End If
            '@0001 Web Browser Consulta Vehicular
            wbrConsultaVehicular.Navigate(URLConsultaVehicular)
            wbrConsultaVehicular.ScriptErrorsSuppressed = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub


#End Region

End Class
