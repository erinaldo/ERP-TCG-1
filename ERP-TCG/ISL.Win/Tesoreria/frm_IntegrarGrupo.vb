Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_IntegrarGrupo
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializar"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_IntegrarGrupo = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_IntegrarGrupo
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variable"

    Private oeGrupoSancion As New e_GrupoSancion, olGrupoSancion As New l_GrupoSancion, leGrupoSancion As New List(Of e_GrupoSancion)
    Private oePrestamo As New e_Prestamo, lePrestamo As New List(Of e_Prestamo), olPrestamo As New l_Prestamo, oePrestamoSancion As New e_Prestamo_Sancion
    Private oeSancion As New e_Sancion, olSancion As New l_Sancion, leSancion As New List(Of e_Sancion)
    Private oeArea As New e_Area, olArea As New l_Area, leArea As New List(Of e_Area)
    Private oeEstado As New e_Estado, olEstado As New l_Estado, leEstado As New List(Of e_Estado), leEstPre As New List(Of e_Estado), leEstSanc As New List(Of e_Estado)
    Private oeConceptoPrestamo As New e_Concepto_Prestamo, olConceptoPrestamo As New l_Concepto_Prestamo, leConceptoPrestamo As New List(Of e_Concepto_Prestamo)
    Private IdSancion As String, CadIdGroup As String, CadGroupDesc As String, bandCargar As Boolean
    Private strGrupoDesc As String, strGrupoSanc As String, IdPrestamo As String, IdAdelanto As String, IdBolsaViaje As String
    Private leConcepAux As New List(Of e_Concepto_Prestamo), oeDMReferencia As New e_DetalleModelo_Referencia
    Private oeParametro As New e_AporteDescuento, olParametro As New l_AporteDescuento, leParametro As New List(Of e_AporteDescuento)
    Private oeDetParametro As New e_DetalleAporteDescuento, olDetParametro As New l_DetalleAporteDescuento, leDetParametro As New List(Of e_DetalleAporteDescuento)
    Private oeFormula As New e_Formula, olFormula As New l_Formula, leFormula As New List(Of e_Formula)
    Private _SueldoMin As Double, _PorcDesc As Double, _MontoDesc As Double
    'Private dtAMAN As Data.DataTable
    'Private dtDAMFC As Data.DataTable
    Private oeAsientoModel As New e_AsientoModelo, olAsientoModel As New l_AsientoModelo, leAsientoModel As New List(Of e_AsientoModelo)
    Private oeMedioPago As New e_MedioPago, olMedioPago As New l_MedioPago, leMedioPago As New List(Of e_MedioPago)
    ' Private oeReferencia As New e_AsientoModelo_Referencia, olReferencia As New l_AsientoModelo_Referencia, leReferencia As New List(Of e_AsientoModelo_Referencia)
    'Private oeDetalleAM As New e_DetalleAsientoModelo, olDetalleAM As New l_DetalleAsientoModelo, leDetalleAM As New List(Of e_DetalleAsientoModelo)
    Private _opeInt As String = "", _acl As String = ""

    Private oeConcepto As New e_Concepto
    Private olConcepto As New l_Concepto
    Private loConcepto As New List(Of e_Concepto)

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griGrupoSancion.Rows.Count > 0 Then
                ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)
            Else
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If decTipoCambio.Value = 0 Then Throw New Exception("Ingrese Tipo de Cambio")
            If oeAsientoModel.Id.Trim.Length = 0 Then Throw New Exception("Este Proceso no se ha Pre-Configurado Contablemente")
            Dim formulario As frm_AutenticarTrabajador
            formulario = New frm_AutenticarTrabajador
            formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
            Dim fechaactual As Date = ObtenerFechaServidor()
            Dim fecha As Date = CDate(CStr(loConcepto(0).Valor1) + "/" + CStr(fechaactual.Month) + "/" + CStr(fechaactual.Year))
            If fecIntegracion.Value.Date > fecha Then
                Throw New Exception("No se Pueden Realizar Integraciones Pasado el " + CStr(loConcepto(0).Valor1) + " del Presente")
            End If
            If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                Throw New Exception("Ingrese un Clave Correcta")
            Else
                Dim _idestado As String = ""
                Dim _est As String = gEstadosSGI.APROBADA.ToString
                Dim _leAux = leEstPre.Where(Function(it) it.Nombre = _est).ToList
                If _leAux.Count > 0 Then _idestado = _leAux(0).Id
                lePrestamo = New List(Of e_Prestamo)
                'agregar cuotas
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
                ''''
                For Each oeSanc As e_Sancion In leSancion
                    If oeSanc.IdTrabajador.Trim.Length = 0 Then
                        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                        Throw New Exception("No se ha Registrado el Trabajador al Prestamo")
                    End If
                    oePrestamo = New e_Prestamo
                    oePrestamo.TipoOperacion = "I" : oePrestamo.Id = String.Empty
                    oePrestamo.Glosa = oeSanc.Concepto & ": " & oeSanc.Glosa : oePrestamo.Monto = oeSanc.Monto
                    oePrestamo.IdTrabajador = oeSanc.IdTrabajador
                    oePrestamo.IdConcepto = IIf(oeSanc._Tipo = 0, IdSancion, oeSanc.IdConcepto)
                    oePrestamo.IdEstado = _idestado : oePrestamo.Cancelado = 0
                    oePrestamo.Fecha = oeSanc.Fecha : oePrestamo.CantidadCuotas = oeSanc.NroCuota
                    oePrestamo.Saldo = oeSanc.Monto : oePrestamo.UsuarioCreacion = oeSanc.UsuarioCreacion
                    oePrestamo.FechaIntegracion = Date.Now.Date : oePrestamo.UsuarioAprueba = gUsuarioSGI.Id
                    oePrestamo.FechaAprueba = oeSanc.FechaAprobacion
                    Select Case oePrestamo.IdConcepto
                        Case IdPrestamo : oePrestamo.IndProv = "A"
                        Case IdAdelanto : oePrestamo.IndProv = "B"
                        Case IdBolsaViaje : oePrestamo.IndProv = IIf(oePrestamo.Monto > _MontoDesc, "C", "D")
                        Case IdSancion : oePrestamo.IndProv = IIf(oePrestamo.Monto > _MontoDesc, "E", "F")
                        Case Else : oePrestamo.IndProv = IIf(oePrestamo.Monto > _MontoDesc, "G", "H")
                    End Select
                    oePrestamo.leSancion = New List(Of e_Prestamo_Sancion)
                    oePrestamoSancion = New e_Prestamo_Sancion
                    oePrestamoSancion.TipoOperacion = "I" : oePrestamoSancion.Id = String.Empty
                    oePrestamoSancion.IdSancion = oeSanc.Id : oePrestamoSancion.UsuarioCreacion = gUsuarioSGI.Id
                    oePrestamoSancion.Tipo = oeSanc._Tipo
                    oePrestamo.leSancion.Add(oePrestamoSancion)
                    'agregar cuotas
                    Dim _FecCuota As Date = #1/1/1901#
                    _FecCuota = DateAdd(DateInterval.Month, mescuota, Date.Parse("01/" & fechaServidor.Month & "/" & fechaServidor.Year))
                    oePrestamo.leDetalle.AddRange(GenerarCuotas(oePrestamo.Monto, _FecCuota, oePrestamo.CantidadCuotas))
                    ''''
                    lePrestamo.Add(oePrestamo)
                Next
                Dim olPeriodo As New l_Periodo, oePeriodo As New e_Periodo
                oePeriodo.Ejercicio = Date.Now.Year : oePeriodo.Mes = Date.Now.Month
                oePeriodo = olPeriodo.Obtener(oePeriodo)
                l_FuncionesGenerales.ValidarPeriodo(oePeriodo.Id, gAreasSGI.Tesoreria)
                oeAsientoModel.UsuarioCreacion = gUsuarioSGI.Id : oeAsientoModel.TipoCambio = decTipoCambio.Value : oeAsientoModel.IdMedioPago = cboMedioPago.Value
                If olPrestamo.GuardarLista(lePrestamo, CadIdGroup, CadGroupDesc, oePeriodo, oeAsientoModel, strGrupoSanc, strGrupoDesc) Then
                    mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                    MostrarTabs(0, ficIntegrarGrupo, 2)
                    Consultar(_Activo)
                    griGrupoSancion.Focus()
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If MessageBox.Show("¿Desea Cancelar la operacion?", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                MostrarTabs(0, ficIntegrarGrupo, 2)
                Consultar(True)
            Else
                griGrupoSancion.Select()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            If ficIntegrarGrupo.Tabs(0).Selected AndAlso griGrupoSancion.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            If ficIntegrarGrupo.Tabs(0).Selected Then Exportar_Excel(griGrupoSancion)
            If ficIntegrarGrupo.Tabs(1).Selected AndAlso griSancion.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            If ficIntegrarGrupo.Tabs(1).Selected Then Exportar_Excel(griSancion)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_IntegrarGrupo_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'Select Case Operacion
        '    Case "Nuevo"
        '        Nuevo()
        '    Case "Editar"
        '        Editar()
        '    Case "Inicializa"
        '        If griGrupoSancion.Rows.Count > 0 Then
        '            ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)
        '        Else
        '            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
        '        End If
        'End Select
        Select Case ficIntegrarGrupo.SelectedTab.Index
            Case 0 : ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
            Case 1 : ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
        End Select
    End Sub

    Private Sub frm_IntegrarGrupo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_IntegrarGrupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CargaCombo()
            bandCargar = True
            CargarSanciones(New List(Of e_Sancion))
            bandCargar = False
            'Cargar Parametros para procesar informacion
            _SueldoMin = ValorParametro(gPSueldoMinimo, leParametro, leDetParametro)
            _PorcDesc = ValorParametro(gPPorcentajeDescuento, leParametro, leDetParametro)
            _MontoDesc = _SueldoMin * _PorcDesc / 100
            CargarAsientoModelo(Date.Now.Year)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griGrupoSancion_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griGrupoSancion.CellChange
        griGrupoSancion.UpdateData()
    End Sub

    Private Sub griGrupoSancion_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles griGrupoSancion.AfterRowUpdate
        Try
            If (Not e.Row.ChildBands Is Nothing) AndAlso e.Row.ChildBands.Count > 0 Then
                For Each ChildBand As UltraGridChildBand In e.Row.ChildBands
                    For Each fila In ChildBand.Rows
                        fila.Cells("Selec").Value = e.Row.Cells("Selec").Value
                    Next
                Next
            End If
            griGrupoSancion.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub fecIntegracion_ValueChanged(sender As Object, e As EventArgs) Handles fecIntegracion.ValueChanged
        Try
            If fecIntegracion.Value.Year <> Date.Now.Year Then
                CargarAsientoModelo(fecIntegracion.Value.Year)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargaCombo()
        Try
            'Cargar RUTAS para no validar limite viajes reportados
            loConcepto = New List(Of e_Concepto)
            oeConcepto = New e_Concepto
            oeConcepto.Activo = True
            oeConcepto.Prefijo = "34"
            loConcepto = olConcepto.Listar(oeConcepto)

            oeArea = New e_Area
            oeArea.Id = "TODOS" : oeArea.Nombre = "TODOS"
            leArea.Add(oeArea)
            oeArea = New e_Area
            oeArea.Activo = 1 : oeArea.TipoOperacion = ""
            leArea.AddRange(olArea.Listar(oeArea))
            LlenarCombo(cboArea, "Nombre", leArea, 0)

            oeEstado = New e_Estado
            oeEstado.Activo = 1 : oeEstado.Nombre = "GRUPO SANCION"
            leEstado = olEstado.Listar(oeEstado)
            oeEstado = New e_Estado
            oeEstado.Nombre = "PRESTAMO"
            leEstPre = olEstado.Listar(oeEstado)
            oeEstado = New e_Estado
            oeEstado.Nombre = "SANCION"
            leEstSanc = olEstado.Listar(oeEstado)

            oeConceptoPrestamo = New e_Concepto_Prestamo
            oeConceptoPrestamo.Tipo = 1 : oeConceptoPrestamo.Activo = 1 : oeConceptoPrestamo.TipoOperacion = String.Empty
            leConceptoPrestamo = olConceptoPrestamo.Listar(oeConceptoPrestamo)
            leConcepAux = New List(Of e_Concepto_Prestamo)
            leConcepAux = leConceptoPrestamo.Where(Function(item) item.Nombre = gCPSanciones).ToList
            IdSancion = leConcepAux(0).Id
            leConcepAux = New List(Of e_Concepto_Prestamo)
            leConcepAux = leConceptoPrestamo.Where(Function(item) item.Nombre = gCPPrestamos).ToList
            IdPrestamo = leConcepAux(0).Id
            leConcepAux = New List(Of e_Concepto_Prestamo)
            leConcepAux = leConceptoPrestamo.Where(Function(item) item.Nombre = gCPAdelantos).ToList
            IdAdelanto = leConcepAux(0).Id
            leConcepAux = New List(Of e_Concepto_Prestamo)
            leConcepAux = leConceptoPrestamo.Where(Function(item) item.Nombre = gCPBolsaViaje).ToList
            IdBolsaViaje = leConcepAux(0).Id

            oeParametro = New e_AporteDescuento
            oeParametro.TipoOperacion = "" : oeParametro.Activo = True
            leParametro = olParametro.Listar(oeParametro)

            oeDetParametro = New e_DetalleAporteDescuento
            oeDetParametro.TipoOperacion = "" : oeDetParametro.Activo = True : oeDetParametro.Vigencia = 1
            leDetParametro = olDetParametro.Listar(oeDetParametro)

            oeFormula = New e_Formula
            oeFormula.TipoOperacion = "" : oeFormula.Activo = True
            leFormula = olFormula.Listar(oeFormula)

            oeMedioPago = New e_MedioPago
            oeMedioPago.TipoOperacion = "" : oeMedioPago.Activo = True
            leMedioPago = olMedioPago.Listar(oeMedioPago)
            LlenarCombo(cboMedioPago, "Nombre", leMedioPago, -1)
            cboMedioPago.Text = "EFECTIVO"
            cboMedioPago.Enabled = False

            oeAsientoModel = New e_AsientoModelo
            oeAsientoModel.TipoOperacion = "A" : oeAsientoModel.Activo = True : oeAsientoModel.Nombre = pIdActividadNegocio
            leAsientoModel = olAsientoModel.Listar(oeAsientoModel)

            'oeDetalleAM = New e_DetalleAsientoModelo
            'oeDetalleAM.TipoOperacion = "A" : oeDetalleAM.Activo = True : oeDetalleAM.Formula = pIdActividadNegocio
            'leDetalleAM = olDetalleAM.Listar(oeDetalleAM)

            'oeReferencia = New e_AsientoModelo_Referencia
            'oeReferencia.TipoOperacion = "N" : oeReferencia.Activo = True : oeReferencia.IdReferencia = pIdActividadNegocio
            'leReferencia = olReferencia.Listar(oeReferencia)

            'dtAMAN = GenerarDTConfigurable(CargarCTCD("AsientoModelo_ActividadNegocio"))
            'dtDAMFC = GenerarDTConfigurable(CargarCTCD("DetalleAsientoModelo_FlujoCaja"))

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarAsientoModelo(ByVal ln_Ejercicio As Integer)
        Try
            oeAsientoModel = New e_AsientoModelo
            oeAsientoModel.TipoOperacion = String.Empty
            oeAsientoModel.Ejercicio = ln_Ejercicio
            oeAsientoModel.Id = String.Empty
            If leAsientoModel.Count > 0 Then
                oeAsientoModel.Id = leAsientoModel(0).Id
                oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                If oeAsientoModel.leDetalle.Count > 0 Then
                    For Each oeDetAux In oeAsientoModel.leDetalle
                        Dim _leDMRAux = oeAsientoModel.leDMReferencia.Where(Function(it) it.IdDetalleAsientoModelo = oeDetAux.Id).ToList
                        If _leDMRAux.Count > 0 Then oeDetAux.IdReferencia = _leDMRAux(0).IdReferencia
                    Next
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarGrupos(ByVal dsGrupoSancion As Data.DataSet)
        Try

            Dim PadreCol As DataColumn = dsGrupoSancion.Tables(0).Columns("Id")
            Dim HijoCol As DataColumn = dsGrupoSancion.Tables(1).Columns("IdGrupo")
            Dim Relacion As DataRelation = New DataRelation("Grupo_Detalle", PadreCol, HijoCol, True)
            dsGrupoSancion.Relations.Add(Relacion)
            dsGrupoSancion.AcceptChanges()
            With griGrupoSancion
                .DataSource = dsGrupoSancion

                For Each Colx In .DisplayLayout.Bands(0).Columns
                    If Colx.Key = "Selec" Then
                        Colx.CellClickAction = CellClickAction.Edit
                    Else
                        Colx.CellClickAction = CellClickAction.RowSelect
                        Colx.CellActivation = Activation.NoEdit
                    End If
                Next

                For Each Col In .DisplayLayout.Bands(1).Columns
                    If Col.Key.Contains("Id") Or Col.Key.Contains("Creacion") Then Col.Hidden = True
                    Col.CellClickAction = CellClickAction.RowSelect
                    Col.CellActivation = Activation.NoEdit
                Next

                .DisplayLayout.Bands(1).Columns("Tipo").Hidden = True
                .DisplayLayout.Bands(1).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(1).Columns("Area").Hidden = True

                .DisplayLayout.Bands(1).Columns("Selec").Header.VisiblePosition = 0
                .DisplayLayout.Bands(1).Columns("Fecha").Header.VisiblePosition = 1
                .DisplayLayout.Bands(1).Columns("Concepto").Header.VisiblePosition = 2
                .DisplayLayout.Bands(1).Columns("Trabajador").Header.VisiblePosition = 3
                .DisplayLayout.Bands(1).Columns("Glosa").Header.VisiblePosition = 4
                .DisplayLayout.Bands(1).Columns("Monto").Header.VisiblePosition = 5

                .DisplayLayout.Bands(1).Columns("Monto").Format = "#,##0.00"

                .DisplayLayout.Bands(1).Columns("Monto").CellAppearance.TextHAlign = HAlign.Right

                .DisplayLayout.Bands(1).Columns("Selec").Style = ColumnStyle.CheckBox

                .DisplayLayout.Bands(1).Columns("Fecha").SortIndicator = SortOrder.Ascending

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
                .DisplayLayout.Bands(0).Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Bands(0).Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Bands(0).Override.FilterUIProvider = Filtro1
                .DisplayLayout.Bands(0).Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Bands(1).Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Bands(0).Override.RowAppearance.BackColor = Color.LightYellow

            End With
            CalcularTotales(griGrupoSancion, "Monto")
        Catch ex As Exception
            Throw ex
        End Try
        
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            oeGrupoSancion = New e_GrupoSancion
            oeGrupoSancion.Activo = Activo
            oeGrupoSancion.IdArea = cboArea.Value
            oeGrupoSancion.TipoOperacion = "N"
            CargarGrupos(olGrupoSancion.ListarDS(oeGrupoSancion))
            MostrarTabs(0, ficIntegrarGrupo)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griGrupoSancion.Focus()
    End Sub

    Private Sub CargarSanciones(ByVal leSancion As List(Of e_Sancion))
        Try
            With griSancion
                .DataSource = leSancion
                If bandCargar Then
                    OcultarColumna(griSancion, True, "IdGrupo", "IdTrabajador", "IdArea", "Id", "IdConcepto", "IdResponsable", "IdEstado", _
                                   "Activo", "FechaCreacion", "UsuarioCreacion", "Responsable", "IdUsuarioAprueba", "FechaAprobacion")
                    .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 0
                    .DisplayLayout.Bands(0).Columns("Area").Header.VisiblePosition = 1
                    .DisplayLayout.Bands(0).Columns("Trabajador").Header.VisiblePosition = 2
                    .DisplayLayout.Bands(0).Columns("Concepto").Header.VisiblePosition = 3
                    .DisplayLayout.Bands(0).Columns("Glosa").Header.VisiblePosition = 4
                    .DisplayLayout.Bands(0).Columns("Monto").Header.VisiblePosition = 5
                    .DisplayLayout.Bands(0).Columns("Fecha").Width = 80
                    .DisplayLayout.Bands(0).Columns("Area").Width = 150
                    .DisplayLayout.Bands(0).Columns("Trabajador").Width = 200
                    .DisplayLayout.Bands(0).Columns("Concepto").Width = 120
                    .DisplayLayout.Bands(0).Columns("Glosa").Width = 300
                    FormatoColumna(griSancion, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Monto")
                    .DisplayLayout.Bands(0).Columns("Fecha").SortIndicator = SortOrder.Ascending
                    .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
                    .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                    .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                    .DisplayLayout.Override.FilterUIProvider = Filtro1
                    .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                    .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                    .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                    .DisplayLayout.MaxColScrollRegions = 1
                    .DisplayLayout.MaxRowScrollRegions = 1
                End If
                CalcularTotales(griSancion, "Monto")
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Menu Contextual"

    Private Sub tsmiIntegrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiIntegrar.Click
        Try
            _acl = gAccionSistema.INTEGRAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                Operacion = "Nuevo" : CadIdGroup = "" : CadGroupDesc = ""
                strGrupoDesc = "" : strGrupoSanc = ""
                leSancion = New List(Of e_Sancion)
                griGrupoSancion.UpdateData()
                For Each Fil As UltraGridRow In griGrupoSancion.Rows
                    If Fil.Cells("Selec").Value = 1 Then
                        If Fil.Cells("Tipo").Value = 0 Then
                            CadIdGroup = CadIdGroup & "'" & Fil.Cells("Id").Value & "',"
                            strGrupoSanc = strGrupoSanc & Fil.Cells("Codigo").Value.ToString.Trim & ","
                        Else
                            CadGroupDesc = CadGroupDesc & "'" & Fil.Cells("Id").Value & "',"
                            strGrupoDesc = strGrupoDesc & Fil.Cells("Codigo").Value.ToString.Trim & ","
                        End If
                    End If
                Next
                If CadIdGroup.Trim = "" And CadGroupDesc.Trim = "" Then Throw New Exception("Seleccione al menos un Grupo para Integrar.")
                'Listar Sanciones por Area
                If CadIdGroup <> "" Then
                    Dim _est As String = gNombreEstadoEnviado
                    Dim _leAux = leEstSanc.Where(Function(it) it.Nombre = _est).ToList
                    CadIdGroup = CadIdGroup.Substring(0, CadIdGroup.Length - 1)
                    strGrupoSanc = strGrupoSanc.Substring(0, strGrupoSanc.Length - 1)
                    oeSancion = New e_Sancion
                    oeSancion.TipoOperacion = "1"
                    If _leAux.Count > 0 Then
                        oeSancion.IdEstado = _leAux(0).Id
                    Else
                        oeSancion.IdEstado = ""
                    End If
                    oeSancion._CadenaIdGrupo = CadIdGroup
                    leSancion = olSancion.Listar(oeSancion)
                End If
                ' LIstar las dedudas de lo trabajadores por viaje
                If CadGroupDesc <> "" Then
                    CadGroupDesc = CadGroupDesc.Substring(0, CadGroupDesc.Length - 1)
                    strGrupoDesc = strGrupoDesc.Substring(0, strGrupoDesc.Length - 1)
                    oeSancion = New e_Sancion
                    oeSancion.TipoOperacion = "2"
                    oeSancion._GrupoDesc = CadGroupDesc
                    leSancion.AddRange(olSancion.Listar(oeSancion))
                End If
                CargarSanciones(leSancion)
                fecIntegracion.Value = ObtenerFechaServidor()
                fecIntegracion.Enabled = False
                decTipoCambio.Value = TipoCambio(fecIntegracion.Value, True)(0)
                MostrarTabs(1, ficIntegrarGrupo)
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

End Class
