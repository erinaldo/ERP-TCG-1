Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Configuration
Imports Infragistics.Win.CalcEngine
Imports Infragistics.Win.UltraWinDataSource
Imports System.Threading
Imports System.Data.OleDb

Public Class frm_Guias

    Inherits ISL.Win.frm_MenuPadre

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_Guias = Nothing
    Private Shared Operacion As String
    Private Estado As String
    Private FechaServidor As Date = ObtenerFechaServidor()
    Private olFuncionesGenerales As New l_FuncionesGenerales

    ''' <summary>
    ''' Instancia unica de Formulario: frm_Operacion
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 
    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Guias()
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Declaración de variables"

    Dim oeLugar As New e_Lugar
    Dim olLugar As New l_Lugar
    Dim ListaLugar As New List(Of e_Lugar)

    Dim oeTipoVehiculo As New e_TipoVehiculo
    Dim olTipoVehiculo As New l_TipoVehiculo

    Dim oeMoneda As New e_Moneda
    Dim olMoneda As New l_Moneda
    Dim ListaMoneda As New List(Of e_Moneda)

    Dim oeCliente As New e_Cliente
    Dim olCliente As New l_Cliente
    Dim ListaCliente As New List(Of e_Combo)
    Dim ListaComisionista As New List(Of e_Combo)
    Dim ListaRemitenteLista As New List(Of e_Combo)
    Dim ListaDestinatario As New List(Of e_Combo)
    Dim ListaRemitente As New List(Of e_Combo)

    Dim oeTipoCarga As New e_TipoCarga
    Dim olTipoCarga As New l_TipoCarga
    Dim ListaTipoCarga As New List(Of e_TipoCarga)

    Dim oeMaterial As New e_Material
    Dim olMaterial As New l_Material
    Dim ListaMaterial As New List(Of e_Material)

    Dim oeRuta As New e_Ruta
    Dim olRuta As New l_Ruta

    Dim oeSeguimiento As New e_Seguimiento
    Dim olSeguimiento As New l_Seguimiento

    Dim oeGuiaTransportista As New e_GuiaTransportista
    Dim olGuiaTransportista As New l_GuiaTransportista

    Dim GuiaTransportistaLista As New List(Of e_GuiaTransportista)

    Dim oeGuiaRemitente As New e_GuiaRemitente
    Dim olGuiaRemitente As New l_GuiaRemitente

    Dim oeGuiaTransportistaInterrumpida As New e_GuiaTransportistaInterrumpida
    Dim olGuiaTransportistaInterrumpida As New l_GuiaTransportistaInterrumpida

    Dim olDireccionEmpresa As New l_Combo
    Dim oeDireccionEmpresa As New e_Combo
    Dim ListaDireccionEmpresa As New List(Of e_Combo)
    Dim ListaPuntoPartida As New List(Of e_Combo)
    Dim ListaPuntoLlegada As New List(Of e_Combo)


    Dim oeViaje As New e_Viaje
    Dim oeOperacionDetalle As New e_OperacionDetalle

    Dim olIgv As New l_Impuesto
    Dim oeIgv As New e_Impuesto

    Dim olOperacion As New l_Operacion
    Dim oeOperacion As New e_Operacion

    Dim olTiempoCiclo As New l_TiempoCiclo
    Dim oeTiempoCiclo As New e_TiempoCiclo

    Dim olVehiculo As New l_Vehiculo
    Dim oeVehiculo As New e_Vehiculo
    Dim ListaTracto As New List(Of e_Vehiculo)
    Dim olMotivoTrasladoInterrumpido As New l_MotivoDocumento
    Dim oeMotivoTrasladoInterrumpido As New e_MotivoDocumento
    Dim ListaMotivoDocumento As New List(Of e_MotivoDocumento)

    Dim oeFechas As New e_Fechas

    Dim _ingresando_datos As Boolean = False

    Dim Opcion As Boolean

    Dim GRT As String

    Dim oeDemandaDetalle As New e_DemandaDetalle

    Dim SalidaOrigenIndicador As Boolean = False

    Dim SalidaDestinoIndicador As Boolean = False

    Dim oeUsuarioPerfil As New e_UsuarioPerfil
    Dim olUsuarioPerfil As New l_UsuarioPerfil

    Dim oePerfil As New e_Perfil
    Dim olPerfil As New l_Perfil

    Dim oeCentro As New e_Centro
    Dim olCentro As New l_Centro
    Dim ListaCentro As New List(Of e_Centro)

    Dim Prefijo As New l_Configuracion

    Dim ctrNuevo As Boolean = False, ctrEditar As Boolean = False, SOrigen As String, SDestino As String

    Dim oeRegConsumoCombustible As New e_RegistroConsumoCombustible, olRegConsumoCombustible As New l_RegistroConsumoCombustible
    Dim lstRegConsumoCombustible As New List(Of e_RegistroConsumoCombustible)

    Dim IdPuntoPartida As String = ""
    Dim IdPuntoLlegada As String = ""

    Dim IdRemitente As String = ""
    Dim IdDestinatario As String = ""

    Dim Nombre As String = ""

    Dim Tipo As Integer = 0

    Dim oeRegistroEditado As New e_RegistrosEditados
    Dim olRegistroEditado As New l_RegistrosEditados

    Dim RegistroEditado As Integer = 0
    Dim IdRegistroEditado As String = ""

    'Tipo 0 = Guia Transportista Normal
    'Tipo 1 = Agregar Varias Guias Transportistas a Viaje
    Dim oeCombo As New e_Combo
    Dim olCombo As New l_Combo

    'bitacora
    Dim columnas As New List(Of String)
    Dim rowGeneral(14, 1) As Integer
    Dim glosasGeneral(14, 2) As String
    Dim idDetalleGeneral As String
    Dim count As Integer

    Dim ListaBitacora As New List(Of e_Bitacora)
    Dim GlosaDetalleDemanda As String = ""
    Dim ValoresAnterioresDetalleDemanda As String = ""
    Dim ValoresActualesDetalleDemanda As String = ""
    Dim objEliminarTercero As e_Bitacora
    Dim objEliminarDetalle As e_Bitacora

    Dim TrabajadorTerceroList As New List(Of e_Combo)
    Public Shared codigoPilotoTercero As String = ""
    Private bandComboPiloto As String = "U"

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            'Tiempo1.Enabled = True
            Operacion = "Inicializa"
            Estado = IIf(Activo, " Activo", " Inactivo")

            If ValidarFechaInicioFin(fecDesde, fecHasta) Then
                oeViaje = New e_Viaje
                If tabLista.Tabs(0).Selected Then
                    If verViajeRetorno.Checked Then
                        oeViaje.Activo = 1
                    Else
                        oeViaje.Activo = 0
                    End If
                    oeViaje.TipoOperacion = "6"
                    Listar(griLista)
                    If griLista.Rows.Count > 0 Then
                        Tipo = 0
                        ControlBoton(1, 0, 1, 0, 0, 1, 1, 1, 1)
                    Else
                        ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                    End If
                Else
                    If tabLista.Tabs(1).Selected Then
                        oeGuiaTransportista = New e_GuiaTransportista
                        With oeGuiaTransportista
                            .TipoOperacion = "0"
                            .FechaDesde = fecDesde.Value
                            .FechaHasta = fecHasta.Value
                            .Activo = True
                        End With
                        griListaAnuladas.DataSource = olGuiaTransportista.Listar(oeGuiaTransportista)
                        If griListaAnuladas.Rows.Count > 0 Then
                            ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                        Else
                            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                        End If
                    Else
                        If tabLista.Tabs(2).Selected Then
                            oeViaje.TipoOperacion = "B"
                            Listar(griGrtConfirmarBloque)
                            CalcularTotales(griGrtConfirmarBloque, "PesoToneladas", "TotalFlete")
                            If griGrtConfirmarBloque.Rows.Count > 0 Then
                                Tipo = 0
                                ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)
                            Else
                                ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                            End If
                        Else
                            If tabLista.Tabs(3).Selected Then
                                oeViaje.TipoOperacion = "D"
                                Listar(griViajeConfirmarBloque)
                                CalcularTotales(griViajeConfirmarBloque, "PesoToneladas", "TotalFlete")
                                If griViajeConfirmarBloque.Rows.Count > 0 Then
                                    Tipo = 0
                                    ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)
                                Else
                                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                                End If                          
                            End If
                            
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    'Public Overrides Sub Nuevo()
    '    Operacion = "Nuevo"
    '    Dim listadetalle As New List(Of e_GuiaRemitente)
    '    Inicializar()
    '    MostrarTabs(1, ficDemanda, 1)
    '    oeSeguimiento.UsuarioCreacion = gUsuarioSGI.Id
    '    griGuiaTransportista.DataSource = listadetalle
    '    MyBase.Nuevo()
    'End Sub

    Public Overrides Sub Editar()
        Dim HabilitarCOD As Boolean = True
        griViajeDetalle.Enabled = HabilitarCOD
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If griLista.ActiveRow.Cells("Id").Value.ToString.Length Then
                'If griLista.ActiveRow.Cells("ViajeVacio").Value = 0 Or griLista.ActiveRow.Cells("DiaNoche").Value = 0 Then
                Inicializar()
                'ombos()
                'ComboGrilla()
                LlenarComboMaestro(cboRemitente, ClientesPublic, 0)
                LlenarComboMaestro(cboDestinatario, ClientesPublic, 0)
                Operacion = "Editar"
                tabGrt.Tabs(0).Selected = True
                If EditarGuia() Then
                    oeSeguimiento.UsuarioCreacion = gUsuarioSGI.Id
                    tabGrt.Tabs(1).Visible = True
                    tabGrt.Tabs(2).Visible = True
                    tabDetalleGrt.Tabs(0).Visible = True
                    tabDetalleGrt.Tabs(1).Visible = True
                    tabDetalleGrt.Tabs(2).Visible = True
                    If Tipo <> 1 Then
                        tabDetalleGrt.Tabs(3).Visible = False
                        Me.cboPilotoTercero.Visible = True
                        Me.lblPilotoGRT.Visible = True
                    Else
                        cboRemitente.Text = griLista.ActiveRow.Cells("Cliente").Value.ToString()
                        cboRemitente.Focus()
                        cboDestinatario.Text = griLista.ActiveRow.Cells("Cliente").Value.ToString()
                        cboDestinatario.Focus()
                        tabDetalleGrt.Tabs(1).Visible = False
                        tabDetalleGrt.Tabs(3).Visible = True
                        Me.cboPilotoTercero.Visible = False
                        Me.lblPilotoGRT.Visible = False
                    End If

                    If RTrim(griLista.ActiveRow.Cells("Id").Value.ToString) = "0" Then
                        cboRemitente.Text = griLista.ActiveRow.Cells("Cliente").Value.ToString()
                        cboRemitente.Focus()
                        cboDestinatario.Text = griLista.ActiveRow.Cells("Cliente").Value.ToString()
                        cboDestinatario.Focus()
                    End If

                    exgruViaje.Visible = True
                    exgruGrtAnuladas.Visible = False
                    exgruViaje.Expanded = True
                    exgrupoGrt.Size = New System.Drawing.Size(580, 218)
                    btnAgregarGrt.Visible = False
                    txtRangoFinalNumeroAnulado.Visible = False
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                    cboRemitente.Focus()
                    cboDestinatario.Focus()
                    cboPuntoPartida.Value = IdPuntoPartida
                    cboPuntoLlegada.Value = IdPuntoLlegada
                    txtSerie.Focus()

                    If RegistroEditado = 1 Then
                        oeRegistroEditado = New e_RegistrosEditados
                        With oeRegistroEditado
                            .IdRegistro = griLista.ActiveRow.Cells("IdOperacion").Value
                            .Referencia = "GuiaTransportista"
                            .UsuarioEdita = gUsuarioSGI.Id
                        End With
                        IdRegistroEditado = olRegistroEditado.Guardar(oeRegistroEditado)
                    End If
                    If gUsuarioSGI.Controlado <> 0 Then
                        HabilitarCOD = False
                        olFuncionesGenerales.ValidarFechaCierre("Editar Carga", griLista.ActiveRow.Cells("Fecha").Value, FechaServidor.Date)
                        HabilitarCOD = True
                        griViajeDetalle.DisplayLayout.Bands(0).Columns("FleteUnitario").CellActivation = Activation.NoEdit
                    End If
                Else
                    Operacion = "Inicializa"
                End If
                'Else
                '    Throw New Exception(Me.Text & ": Ya fue Facturado no se puede Editar")
                'End If

            End If
            CalcularTotales(griViajeDetalle, "Flete", "Comision", "Subtotal")
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
            If HabilitarCOD = False Then
                griViajeDetalle.Enabled = HabilitarCOD
            End If
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarGuia() Then
                ActualizaRegistroEditado()
                Tipo = 0
                MostrarTabs(0, ficGuias, 2)
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficGuias, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                Case Windows.Forms.DialogResult.Yes
                    If GuardarGuia() Then
                        MostrarTabs(0, ficGuias, 2)
                        _ingresando_datos = False
                        Operacion = "Inicializa"
                        Tipo = 0
                        ControlBoton(1, 0, 1, 0, 0, 0, 1, 1, 1)
                    Else
                        _ingresando_datos = True
                    End If

                Case Windows.Forms.DialogResult.No
                    MostrarTabs(0, ficGuias, 2)
                    _ingresando_datos = False
                    Operacion = "Inicializa"
                    Tipo = 0
                    ControlBoton(1, 0, 1, 0, 0, 0, 1, 1, 1)
                    ActualizaRegistroEditado()
                Case Windows.Forms.DialogResult.Cancel
                    _ingresando_datos = True

            End Select
            '_ingresando_datos = True
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        griLista.ActiveRow.Delete()
    End Sub

    Public Overrides Sub Imprimir()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Tipo = 0
            MyBase.Imprimir()
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Salir()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Tipo = 0
            MyBase.Salir()
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
    Public Overrides Sub Exportar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Tipo = 0
            If tabLista.Tabs(0).Selected Then
                If griLista.Rows.Count > 0 Then Exportar_Excel(griLista)
            Else
                If tabLista.Tabs(1).Selected Then
                    If griListaAnuladas.Rows.Count > 0 Then Exportar_Excel(griListaAnuladas)
                Else
                    If tabLista.Tabs(2).Selected Then
                        If griGrtConfirmarBloque.Rows.Count > 0 Then Exportar_Excel(griGrtConfirmarBloque)
                    Else
                        If griViajeConfirmarBloque.Rows.Count > 0 Then Exportar_Excel(griViajeConfirmarBloque)
                    End If
                End If
            End If
            MyBase.Exportar()
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub
#End Region

#Region "Eventos"

    Private Sub frm_Guias_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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
    End Sub

    Private Sub frm_Guias_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Select Case Operacion
            Case "Nuevo"
                MyBase.Nuevo()
                TipoCliente = 0
            Case "Editar"
                MyBase.Editar()
                AyudaMaestros(TipoCliente)
                TipoCliente = 0
            Case "Inicializa"
                TipoCliente = 0
                MostrarTabs(0, ficGuias)
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                'Consultar(True)
            Case "Ayuda"
        End Select

        If codigoPilotoTercero.Trim <> "" Then
            TrabajadorPublic = New List(Of e_Combo)
            oeCombo = New e_Combo
            oeCombo.Nombre = "Trabajador"
            TrabajadorPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
            TrabajadorTerceroList = TrabajadorPublic.Where(Function(item) item.Extras(0) = 3).ToList.Where(Function(item) item.Extras(1) = 1 Or item.Extras(1) = 4).ToList
            LlenarComboMaestro(IIf(bandComboPiloto = "U", Me.cboPilotoTercero, Me.cboPilotoTercMasivo), TrabajadorTerceroList, 0)
            If bandComboPiloto = "U" Then
                Me.cboPilotoTercero.Value = codigoPilotoTercero
            Else
                Me.cboPilotoTercMasivo.Value = codigoPilotoTercero
            End If
            'Me.cboComisionista.Value = codigoNuevoCom
            codigoPilotoTercero = ""
            bandComboPiloto = "U"
        End If
    End Sub

    Private Sub frm_Guias_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub TecladoTextos(ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            'Case (Keys.F11)
            '    Guardar()
            'Case (Keys.F12)
            '    Cancelar()
            Case (Keys.Escape)
                Cancelar()
            Case (Keys.Enter)
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub TecladoGrilla(ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            'Case Keys.F7
            '    Consultar()
            'Case Keys.F8
            '    Nuevo()
            Case Keys.Insert
                Nuevo()
            Case Keys.Add
                Nuevo()
            Case Keys.Multiply
                Editar()
                'Case Keys.F10
                '    Eliminar()
            Case Keys.Delete
                Eliminar()
            Case Keys.Subtract
                Eliminar()
                'Case Keys.F11
                '    Guardar()
                'Case Keys.F12
                '    Cancelar()
            Case Keys.Escape
                Cancelar()
        End Select
    End Sub

    Private Sub frm_Guias_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            ValidaTipoColor()
            LlenaCombos()
            ComboGrilla()
            ControlRangoFechaInicializa()
            cboCentro.Value = Prefijo.PrefijoID
            If PerfilAsignado(gNombrePerfilAutorizaTarifas) Then
                With griViajeDetalle.DisplayLayout.Bands(0)
                    .Columns("Carga").Header.Enabled = True
                    .Columns("FleteUnitario").Header.Enabled = True
                End With
            End If
            TrabajadorTerceroList = TrabajadorPublic.Where(Function(item) item.Extras(0) = 3).ToList.Where(Function(item) item.Extras(1) = 1 Or item.Extras(1) = 4).ToList
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub opcTipoColores_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcTipoColores.ValueChanged
        ValidaTipoColor()
    End Sub

    Private Sub griGuiaRemitente_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griGuiaRemitente.InitializeLayout
        e.Layout.Grid.CalcManager = Nothing
    End Sub

    Private Sub griViajeInterrumpido_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griViajeInterrumpido.InitializeLayout
        e.Layout.Grid.CalcManager = Nothing
    End Sub

    Private Sub griLista_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griLista.InitializeLayout
        e.Layout.Grid.CalcManager = Nothing
        agrListaRegistro.Text = "Lista Registros: " & e.Layout.Rows.Count & Estado
    End Sub

    Private Sub griLista_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griLista.DoubleClick
        If griLista.Selected.Rows.Count > 0 Then
            Tipo = 1
            Editar()
        End If
    End Sub

    Private Sub cboRemitente_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRemitente.Validated
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            If Not String.IsNullOrEmpty(cboRemitente.Text) Then
                ListaPuntoPartida = New List(Of e_Combo)
                oeDireccionEmpresa = New e_Combo
                oeDireccionEmpresa.Nombre = "DireccionEmpresa"
                oeDireccionEmpresa.Id = cboRemitente.Value
                ListaPuntoPartida.AddRange(olDireccionEmpresa.Listar(oeDireccionEmpresa))
                LlenarComboMaestro(cboPuntoPartida, ListaPuntoPartida, 0)
                cboPuntoPartida.Value = IdPuntoPartida
            End If
            GrtActualiza()
        End If
    End Sub

    Private Sub cboDestinatario_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDestinatario.Validated
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            If Not String.IsNullOrEmpty(cboDestinatario.Text) Then
                ListaPuntoLlegada = New List(Of e_Combo)
                oeDireccionEmpresa = New e_Combo
                oeDireccionEmpresa.Nombre = "DireccionEmpresa"
                oeDireccionEmpresa.Id = cboDestinatario.Value
                ListaPuntoLlegada.AddRange(olDireccionEmpresa.Listar(oeDireccionEmpresa))
                LlenarComboMaestro(cboPuntoLlegada, ListaPuntoLlegada, 0)
                cboPuntoLlegada.Value = IdPuntoLlegada
            End If
        End If
        GrtActualiza()
    End Sub

    Private Sub griViajeDetalle_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griViajeDetalle.KeyDown
        Try
            If e.KeyValue = 13 Then
                With griViajeDetalle
                    Select Case .ActiveRow.Cells(.ActiveCell.Column.Index).Column.Key
                        Case "Seleccion"
                            With griViajeDetalle.Rows(.ActiveRow.Index)
                                If .Cells("Seleccion").Value Then
                                    FleteDetalleGrilla()
                                    txtIdOperacionDetalle.Text = .Cells("Id").Value
                                End If
                            End With
                            .PerformAction(UltraGridAction.NextCellByTab)
                        Case "Cliente"
                            .PerformAction(UltraGridAction.NextCellByTab)
                        Case "Carga"
                            .PerformAction(UltraGridAction.NextCellByTab)
                        Case "PesoToneladasDescarga"
                            FleteDetalleGrilla()
                            With griViajeDetalle.Rows(.ActiveRow.Index)
                                If .Cells("PesoToneladasDescarga").Value.ToString.Length = 0 Or Not IsNumeric(.Cells("PesoToneladasDescarga").Value.ToString) Then
                                    .Cells("PesoToneladasDescarga").Value = 0.0
                                    Throw New Exception("Ingrese PesoToneladasDescarga")
                                End If
                                If .Cells("PesoToneladasDescarga").Value = 0 Or Not IsNumeric(.Cells("PesoToneladasDescarga").Value.ToString) Then
                                    .Cells("PesoToneladasDescarga").Value = 0.0
                                    Throw New Exception("PesoToneladasDescarga no Puede ser 0")
                                End If
                                .Cells("IndPesoTnDescarga").Value = 1
                            End With
                            .PerformAction(UltraGridAction.NextCellByTab)
                        Case "IncluyeIgv"
                            With griViajeDetalle.Rows(.ActiveRow.Index)
                                'If .Cells("IncluyeIgv").Value = False Then
                                '    .Cells("Facturado").Value = True
                                'Else
                                '    .Cells("Facturado").Value = False
                                'End If
                                FleteDetalleGrilla()
                            End With
                            '.PerformAction(UltraGridAction.NextCellByTab)
                        Case "FleteUnitario"
                            FleteDetalleGrilla()
                            With griViajeDetalle.Rows(.ActiveRow.Index)
                                If .Cells("FleteUnitario").Value.ToString.Length = 0 Then Throw New Exception("Ingrese Flete Unitario")
                            End With
                            .PerformAction(UltraGridAction.NextCellByTab)
                        Case "Facturado"
                            With griViajeDetalle.Rows(.ActiveRow.Index)
                                If .Cells("Facturado").Value = False Then
                                    .Cells("Facturado").Value = True
                                Else
                                    .Cells("Facturado").Value = False
                                End If
                            End With
                            '.PerformAction(UltraGridAction.NextCellByTab)
                        Case "PagoContraEntrega"
                            With griViajeDetalle.Rows(.ActiveRow.Index)
                                If .Cells("PagoContraEntrega").Value = False Then
                                    .Cells("PagoContraEntrega").Value = True
                                Else
                                    .Cells("PagoContraEntrega").Value = False
                                End If
                            End With
                            '.PerformAction(UltraGridAction.NextCellByTab)
                        Case "Material"
                            .PerformAction(UltraGridAction.NextCellByTab)
                        Case "Moneda"
                            .PerformAction(UltraGridAction.NextCellByTab)
                            .PerformAction(UltraGridAction.NextCellByTab)
                        Case "Comisionista"
                            .PerformAction(UltraGridAction.NextCellByTab)
                        Case "Comision"
                            With griViajeDetalle.Rows(.ActiveRow.Index)
                                If .Cells("Comision").Value.ToString.Length = 0 Then Throw New Exception("Ingrese Comision")
                            End With
                            .PerformAction(UltraGridAction.NextCellByTab)
                    End Select
                End With
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griViajeDetalle_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griViajeDetalle.CellChange
        Try
            griViajeDetalle.UpdateData()
            FleteDetalleGrilla()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griViajeDetalle_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griViajeDetalle.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griGrtAsociadasViaje_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griGrtAsociadasViaje.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griGrtAsociadasOperacion_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griGrtAsociadasOperacion.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griGuiaRemitente_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griGuiaRemitente.CellChange
        griGuiaRemitente.UpdateData()
    End Sub

    Private Sub griViajeInterrumpido_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griViajeInterrumpido.CellChange
        griViajeInterrumpido.UpdateData()
    End Sub

    Private Sub griGuiaRemitente_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griGuiaRemitente.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show(Me.Text & ": ¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
            'Exit Sub
        End If
    End Sub

    Private Sub griViajeInterrumpido_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griViajeInterrumpido.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show(Me.Text & ": ¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
            'Exit Sub
        End If
    End Sub

    Private Sub btnAgregarInterrumpido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarInterrumpido.Click
        AgregarViajeInterrumpido()
    End Sub

    Private Sub txtGrr_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGrr.Validated
        Try
            If txtGrr.Text <> "" Then ValidarGuiaRemitente(txtGrr)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtRangoGrr_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRangoGrr.Validated
        Try
            If txtRangoGrr.Text <> "" Then ValidarGuiaRemitente(txtRangoGrr)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If ValidaGuiaTransportista(txtIdGrt.Text.Trim, txtSerie.Text.Trim, txtNumero.Text.Trim, Me.chkGuiaTercero.Checked) Then
                ValidaGRTGlosa()
                If txtGrr.Text <> "" Then
                    If ValidarGuiaRemitente(txtGrr) Then
                        If txtRangoGrr.Text <> "" Then
                            ValidarGuiaRemitente(txtGrr, txtRangoGrr)
                        End If
                    End If
                    If txtRangoGrr.Text = "" Then
                        Dim GuiaRemitente() As String = txtGrr.Text.Split("-")
                        If ValidaGuiaRemitente(cboRemitente.Value, GuiaRemitente(0).ToString.Trim, GuiaRemitente(1).ToString.Trim, griGuiaRemitente) Then
                            AgregarGuiasRemitente()
                        End If
                    Else
                        Dim GuiaRemitente() As String = txtRangoGrr.Text.Split("-")

                        If ValidaGuiaRemitente(cboRemitente.Value, GuiaRemitente(0).ToString.Trim, GuiaRemitente(1).ToString.Trim, griGuiaRemitente) Then
                            AgregarGrrRango(txtGrr, txtRangoGrr)
                        End If
                    End If
                Else
                    Throw New Exception("Ingrese Datos Correctos para N° Guia Remitente, Separando Serie y Numero por un Guión (-): (0000-0000000000)")
                End If
                txtGrr.Text = ""
                txtRangoGrr.Text = ""
            End If
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub txtGrr_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGrr.KeyPress
        e.Handled = EvaluarValorIngresado(sender, e)
    End Sub

    Private Sub txtRangoGrr_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRangoGrr.KeyPress
        e.Handled = EvaluarValorIngresado(sender, e)
    End Sub

    Private Sub griGrtAsociadasViaje_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griGrtAsociadasViaje.InitializeLayout
        e.Layout.Grid.CalcManager = Nothing
    End Sub

    Private Sub griGrtAsociadasOperacion_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griGrtAsociadasOperacion.InitializeLayout
        e.Layout.Grid.CalcManager = Nothing
    End Sub

    Private Sub griLista_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griLista.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            If IndDireccionarGRT Then
                e.Cancel = False
            Else
                If EliminarGuiaTransportista(griLista) Then
                    e.Cancel = False
                Else
                    e.Cancel = True
                End If
            End If
        Catch ex As Exception
            e.Cancel = True
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub verConfirmado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verConfirmado.CheckedChanged
        If verConfirmado.Checked Then
            verDocumentos.Enabled = True
            verDoctsPerdido.Enabled = True
        Else
            verDocumentos.Enabled = False
            verDocumentos.Checked = False
            verDoctsPerdido.Enabled = False
            verDoctsPerdido.Checked = False
        End If
    End Sub

    Private Sub txtGuiaRemitente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGuiaRemitente.KeyPress
        e.Handled = EvaluarValorIngresado(sender, e)
    End Sub

    Private Sub txtGuiaRemitente_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGuiaRemitente.Validated
        Try
            If txtGuiaRemitente.Text <> "" Then
                ValidarGuiaRemitente(txtGuiaRemitente)
                cboRemitenteBusca.Focus()
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboRemitente_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles cboRemitente.EditorButtonClick
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If ClientesPublic.Where(Function(Item) Item.Id = cboRemitente.Value).Count() > 0 Then
                Dim IdEmpresa As String
                TipoCliente = 2
                oeCliente = New e_Cliente
                oeCliente.Id = cboRemitente.Value
                oeCliente = olCliente.Obtener(oeCliente)
                IdEmpresa = oeCliente.IdEmpresa
                Dim Empresa As New frm_Empresa
                Empresa = Empresa.getInstancia()
                Empresa.MdiParent = frm_Menu
                Empresa.Show()
                Empresa.AgregarDireccion(IdEmpresa)
            End If
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub cboDestinatario_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles cboDestinatario.EditorButtonClick
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If ClientesPublic.Where(Function(Item) Item.Id = cboDestinatario.Value).Count() > 0 Then
                Dim IdEmpresa As String
                TipoCliente = 2
                oeCliente = New e_Cliente
                oeCliente.Id = cboDestinatario.Value
                oeCliente = olCliente.Obtener(oeCliente)
                IdEmpresa = oeCliente.IdEmpresa
                Dim Empresa As New frm_Empresa
                Empresa = Empresa.getInstancia()
                Empresa.MdiParent = frm_Menu
                Empresa.Show()
                Empresa.AgregarDireccion(IdEmpresa)
            End If

            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub txtSerie_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerie.Validated
        If txtSerie.Text <> "" Then
            txtSerie.Text = FormatoDocumento(txtSerie.Text, 4)
        End If
    End Sub

    Private Sub txtNumero_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.Validated
        If txtNumero.Text <> "" Then
            txtNumero.Text = FormatoDocumento(txtNumero.Text, 10)
        End If
    End Sub

    Private Sub griLista_ClickCellButton(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griLista.ClickCellButton
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim Mensaje As String
            Select Case e.Cell.Column.Key
                Case "Piloto"
                    Dim formulario As frm_FichaPersonal
                    formulario = frm_FichaPersonal
                    If formulario.MostrarTrabajador(griLista.ActiveRow.Cells("IdPiloto").Value) Then formulario.ShowDialog()
                    ControlBoton(1, 0, 1, 0, 0, 1, 1, 1, 1)

                Case "IncidenciaSeguimiento"
                    oeGuiaTransportista = New e_GuiaTransportista
                    oeGuiaTransportista.TipoOperacion = "G"
                    oeGuiaTransportista.Id = griLista.ActiveRow.Cells("Id").Value
                    Mensaje = griLista.ActiveRow.Cells("IncidenciaSeguimiento").Value
                    oeGuiaTransportista.Incidencia = Mensaje
                    If olGuiaTransportista.Guardar(oeGuiaTransportista) Then mensajeEmergente.Confirmacion(Me.Text & ": " & Mensaje, True)
                    oeUsuarioPerfil = New e_UsuarioPerfil
                    oeUsuarioPerfil.oeUsuario.Id = gUsuarioSGI.Id
                    oeUsuarioPerfil.Principal = 1
                    oeUsuarioPerfil = olUsuarioPerfil.Obtener(oeUsuarioPerfil)
                    oePerfil = New e_Perfil
                    oePerfil.TipoOperacion = "M"
                    oePerfil.Id = oeUsuarioPerfil.oePerfil.Id
                    oePerfil.Codigo = Mensaje
                    oePerfil.Nombre = "Area: Guias Informa, " & "GRT: " & griLista.ActiveRow.Cells("Codigo").Value & "-" & griLista.ActiveRow.Cells("Flota").Value & _
                    ", Viaje: " & griLista.ActiveRow.Cells("Operacion").Value & ", Usuario: " & gUsuarioSGI.oePersona.NombreCompleto & ", Dice: " & Mensaje
                    oePerfil.Activo = True
                    olPerfil.Guardar(oePerfil)
                    ControlBoton(1, 0, 1, 0, 0, 1, 1, 1, 1)
            End Select
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try

    End Sub

    Private Sub griListaAnuladas_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griListaAnuladas.InitializeLayout
        e.Layout.Grid.CalcManager = Nothing
    End Sub

    Private Sub Insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Insert.Click
        Operacion = "Nuevo"
        Inicializar()
        GRTAnuladasControles()
        MostrarTabs(1, ficGuias, 1)
        txtSerie.Focus()
        GuiaTransportistaLista = New List(Of e_GuiaTransportista)
        griGrtAnuladas.DataSource = GuiaTransportistaLista
        fecEmision.Value = Date.Now
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        Me.chkGuiaTercero.Checked = False
        Dim ListTercero = New List(Of e_Combo)
        oeCombo = New e_Combo
        oeCombo.Nombre = "Transportista"
        ListTercero.AddRange(olCombo.Listar(oeCombo).Where(Function(Item) Item.Id = "1CH000004444").ToList.OrderBy(Function(Item) Item.Nombre).ToList)
        LlenarComboMaestro(cboTransportista, ListTercero, 0)                
        'cambioss
    End Sub

    Private Sub GRTAnuladasControles()
        tabGrt.Tabs(1).Visible = False
        tabGrt.Tabs(2).Visible = False

        tabDetalleGrt.Tabs(0).Visible = False
        tabDetalleGrt.Tabs(1).Visible = False
        tabDetalleGrt.Tabs(2).Visible = False
        tabDetalleGrt.Tabs(3).Visible = False
        tabDetalleGrt.Tabs(4).Visible = False
        exgruViaje.Visible = False
        exgruGrtAnuladas.Visible = True
        exgruGrtAnuladas.Expanded = True
        exgrupoGrt.Size = New System.Drawing.Size(580, 218)
        btnAgregarGrt.Visible = True
        txtRangoFinalNumeroAnulado.Text = ""
        txtRangoFinalNumeroAnulado.Visible = True
        LlenarComboMaestro(cboRemitente, ListaCliente, 0)
        LlenarComboMaestro(cboDestinatario, ListaCliente, 0)
        cboRemitente.Text = "NINGUNO  ,"
        cboDestinatario.Text = "NINGUNO  ,"
        cboSubContrata.Text = "NINGUNO  ,"
    End Sub

    Private Sub MenuGrtAnuladas_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuGrtAnuladas.Opening
        MenuGrtAnuladas.Items("Insert").Visible = True
        If griListaAnuladas.Selected.Rows.Count > 0 Then
            MenuGrtAnuladas.Items("Update").Visible = True
            MenuGrtAnuladas.Items("Delete").Visible = True
        Else
            MenuGrtAnuladas.Items("Update").Visible = False
            MenuGrtAnuladas.Items("Delete").Visible = False
        End If
    End Sub

    Private Sub griGrtAnuladas_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griGrtAnuladas.InitializeLayout
        e.Layout.Grid.CalcManager = Nothing
    End Sub

    Private Sub frm_Guias_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub btnAgregarGrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarGrt.Click
        AgregarGrtAnuladas()
    End Sub

    Private Sub txtSubSerie_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubSerie.Validated
        If txtSubSerie.Text <> "" Then
            txtSubSerie.Text = FormatoDocumento(txtSubSerie.Text, 4)
        End If
        GrtActualiza()
    End Sub

    Private Sub txtSubNumero_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubNumero.Validated
        If txtSubNumero.Text <> "" Then
            txtSubNumero.Text = FormatoDocumento(txtSubNumero.Text, 10)
        End If
        GrtActualiza()
    End Sub

    Private Sub Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update.Click
        txtRangoFinalNumeroAnulado.Visible = False
        EditarGrtAnulada()
    End Sub

    Private Sub griListaAnuladas_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaAnuladas.DoubleClick
        If griListaAnuladas.Selected.Rows.Count > 0 Then EditarGrtAnulada()
    End Sub

    Private Sub griListaAnuladas_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaAnuladas.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            If EliminarGrtAnuladas() Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        Catch ex As Exception
            e.Cancel = True
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Sub

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        griListaAnuladas.ActiveRow.Delete()
    End Sub

    Private Sub MenuGrt_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuGrt.Opening
        If griLista.Selected.Rows.Count > 0 Then
            MenuGrt.Items("ActualizarGrt").Visible = True
            MenuGrt.Items("AgregarGrt").Visible = True
            MenuGrt.Items("EliminarGrt").Visible = True
            MenuGrt.Items("ConfirmarViaje").Visible = True
            MenuGrt.Items("DocumentosViaje").Visible = True
            MenuGrt.Items("DireccionarGRT").Visible = True
        Else
            MenuGrt.Items("ActualizarGrt").Visible = False
            MenuGrt.Items("AgregarGrt").Visible = False
            MenuGrt.Items("EliminarGrt").Visible = False
            MenuGrt.Items("ConfirmarViaje").Visible = False
            MenuGrt.Items("DocumentosViaje").Visible = False
            MenuGrt.Items("DireccionarGRT").Visible = False
        End If
    End Sub

    Private Sub griGuiaTransportista_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griGuiaTransportistaViaje.InitializeLayout
        e.Layout.Grid.CalcManager = Nothing
    End Sub

    Private Sub griGuiaRemitenteViaje_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griGuiaRemitenteViaje.InitializeLayout
        e.Layout.Grid.CalcManager = Nothing
    End Sub

    Private Sub btnAgregarGrtViaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarGrtViaje.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            ValidaGRTGlosa()
            Dim Ingreso As Integer
            'Ingreso = 0            
            'griGuiaTransportistaViaje
            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griGuiaTransportistaViaje.Rows
                If FormatoDocumento(fila.Cells("Serie").Value, 4) + "-" + FormatoDocumento(fila.Cells("Numero").Value, 10) = txtSerie.Text + "-" + txtNumero.Text Then
                    'Ingreso = 1
                    txtIdGrt.Text = fila.Cells("Id").Value
                    Exit For
                End If
            Next
            'If Ingreso = 0 Then
            '    txtIdGrt.Text = ""
            'End If
            'Ingreso = 0
            If ValidaGuiaTransportista(txtIdGrt.Text.Trim, txtSerie.Text.Trim, txtNumero.Text.Trim, Me.chkGuiaTercero.Checked) Then
                If txtSerie.Text <> "" And txtNumero.Text <> "" And txtGrrViaje.Text <> "" Then
                    If ValidarGuiaRemitente(txtGrrViaje) Then
                        If txtGrrRangoViaje.Text <> "" Then
                            ValidarGuiaRemitente(txtGrrViaje, txtGrrRangoViaje)
                        End If
                        For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griGuiaTransportistaViaje.Rows
                            If FormatoDocumento(fila.Cells("Serie").Value, 4) + "-" + FormatoDocumento(fila.Cells("Numero").Value, 10) = txtSerie.Text + "-" + txtNumero.Text And
                            fila.Cells("IndGuiaTercero").Value = Me.chkGuiaTercero.Checked Then
                                Ingreso = 1
                                Exit For
                            End If
                        Next
                        If txtGrrRangoViaje.Text = "" Then
                            Dim GuiaRemitente() As String = txtGrrViaje.Text.Split("-")
                            ValidaGuiaRemitente(cboRemitente.Value, GuiaRemitente(0).ToString.Trim, GuiaRemitente(1).ToString.Trim, griGuiaRemitenteViaje)
                        Else
                            Dim GuiaRemitente() As String = txtGrrRangoViaje.Text.Split("-")
                            ValidaGuiaRemitente(cboRemitente.Value, GuiaRemitente(0).ToString.Trim, GuiaRemitente(1).ToString.Trim, griGuiaRemitenteViaje)
                        End If
                        If Ingreso = 0 Then
                            If txtGrrRangoViaje.Text = "" Then
                                AgregarGuiasGrtViaje()
                                AgregarGuiasRemitenteViaje()
                            Else
                                AgregarGuiasGrtViaje()
                                AgregarGrrRangoViaje(txtGrrViaje, txtGrrRangoViaje)
                            End If
                        Else
                            If txtGrrRangoViaje.Text = "" Then
                                AgregarGuiasRemitenteViaje()
                            Else
                                AgregarGrrRangoViaje(txtGrrViaje, txtGrrRangoViaje)
                            End If
                        End If
                    End If
                Else
                    Throw New Exception("Ingrese Datos Correctos para N° Guia Transportista / N° Guia Remitente, Separando Serie y Numero por un Guión (-): (0000-0000000000)")
                End If
                txtSubSerie.Text = ""
                txtSubNumero.Text = ""
                txtGlosa.Text = ""
                txtGlosaRemitente.Text = ""
                txtRemitenteGlosa.Text = ""
                txtGrrViaje.Text = ""
                txtGrrRangoViaje.Text = ""
            End If
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub txtGrrViaje_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGrrViaje.Validated
        Try
            If txtGrrViaje.Text <> "" Then ValidarGuiaRemitente(txtGrrViaje)
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Sub

    Private Sub txtGrrRangoViaje_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGrrRangoViaje.Validated
        Try
            If txtGrrRangoViaje.Text <> "" Then ValidarGuiaRemitente(txtGrrRangoViaje)
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Sub

    Private Sub txtGrrViaje_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGrrViaje.KeyPress
        e.Handled = EvaluarValorIngresado(sender, e)
    End Sub

    Private Sub txtGrrRangoViaje_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGrrRangoViaje.KeyPress
        e.Handled = EvaluarValorIngresado(sender, e)
    End Sub

    Private Sub ActualizarGrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarGrt.Click
        If griLista.Selected.Rows.Count > 0 Then
            Tipo = 0
            Editar()
        End If
    End Sub

    Private Sub griGuiaTransportistaViaje_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griGuiaTransportistaViaje.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show("¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub griGuiaTransportistaViaje_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griGuiaTransportistaViaje.CellChange
        griGuiaTransportistaViaje.UpdateData()
    End Sub

    Private Sub griGuiaRemitenteViaje_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griGuiaRemitenteViaje.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show("¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
            'Exit Sub
        End If
    End Sub

    Private Sub griGuiaRemitenteViaje_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griGuiaRemitenteViaje.CellChange
        griGuiaRemitenteViaje.UpdateData()
    End Sub

    Private Sub AgregarGrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarGrt.Click
        If griLista.Selected.Rows.Count > 0 Then
            Tipo = 1
            Editar()
        End If
    End Sub

    Private Sub griGrtConfirmarBloque_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griGrtConfirmarBloque.InitializeLayout
        e.Layout.Grid.CalcManager = Nothing
        agrListaRegistro.Text = "Lista Registros: " & e.Layout.Rows.Count & Estado
    End Sub

    Private Sub cboRemitenteBusca_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboRemitenteBusca.InitializeLayout
        With cboRemitenteBusca.DisplayLayout.Bands(0)
            .Columns("Id").Hidden = True
            .Columns("Nombre").Hidden = False
            .Columns("Nombre").Width = 400
            .Columns("Descripcion").Hidden = True
        End With
    End Sub

    Private Sub cboRemitenteBusca_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboRemitenteBusca.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Nombre = cboRemitenteBusca.Text.Trim
            'ListaCliente.Clear()
            'cboRemitenteBusca.DataSource = ListaCliente
            'LlenaComboClienteLike(Nombre)
            'LlenarComboMaestro(cboRemitenteBusca, ListaCliente, 0)
            'cboRemitenteBusca.DataBind()
            If cboRemitenteBusca.Text.Trim = "" Then
                cboRemitenteBusca.DataSource = Nothing
                cboRemitenteBusca.DataSource = ClientesPublic
            Else
                cboRemitenteBusca.DataSource = Nothing
                ListaRemitenteLista = ClientesPublic
                cboRemitenteBusca.DataSource = ListaRemitenteLista.Where(Function(Item) Item.Nombre.Contains(cboRemitenteBusca.Text.Trim)).ToList
            End If
        End If
    End Sub

    Private Sub cboRemitenteBusca_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboRemitenteBusca.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cboRemitenteBusca.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub cboRemitente_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboRemitente.InitializeLayout
        With cboRemitente.DisplayLayout.Bands(0)
            .Columns("Id").Hidden = True
            .Columns("Nombre").Hidden = False
            .Columns("Nombre").Width = 500
            .Columns("Descripcion").Hidden = True
            '.Columns("Descripcion").Header.Caption
        End With
    End Sub

    Private Sub cboDestinatario_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboDestinatario.InitializeLayout
        With cboDestinatario.DisplayLayout.Bands(0)
            .Columns("Id").Hidden = True
            .Columns("Nombre").Hidden = False
            .Columns("Nombre").Width = 500
            .Columns("Descripcion").Hidden = True
        End With
    End Sub

    Private Sub cboRemitente_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboRemitente.KeyDown
        With CType(sender, Infragistics.Win.UltraWinGrid.UltraCombo)
            If e.KeyData = Keys.Delete Then
                .Text = ""
            End If
        End With

        If e.KeyCode = Keys.Enter Then
            If cboRemitente.Text.Trim = "" Then
                cboRemitente.DataSource = Nothing
                cboRemitente.DataSource = ClientesPublic
            Else
                cboRemitente.DataSource = Nothing
                ListaRemitente = New List(Of e_Combo)
                ListaRemitente = ClientesPublic
                cboRemitente.DataSource = ListaRemitente.Where(Function(Item) Item.Nombre.Contains(cboRemitente.Text.Trim)).ToList
            End If
        End If
    End Sub

    Private Sub cboDestinatario_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboDestinatario.KeyDown
        With CType(sender, Infragistics.Win.UltraWinGrid.UltraCombo)
            If e.KeyData = Keys.Delete Then
                .Text = ""
            End If
        End With

        If e.KeyCode = Keys.Enter Then
            If cboDestinatario.Text.Trim = "" Then
                cboDestinatario.DataSource = Nothing
                cboDestinatario.DataSource = ClientesPublic
            Else
                cboDestinatario.DataSource = Nothing
                ListaDestinatario = New List(Of e_Combo)
                ListaDestinatario = ClientesPublic
                cboDestinatario.DataSource = ListaDestinatario.Where(Function(Item) Item.Nombre.Contains(cboDestinatario.Text.Trim)).ToList
            End If
        End If
    End Sub

    Private Sub cboRemitente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboRemitente.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cboRemitente.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub cboDestinatario_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboDestinatario.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cboDestinatario.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub cboPuntoPartida_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboPuntoPartida.InitializeLayout
        With cboPuntoPartida.DisplayLayout.Bands(0)
            .Columns("Id").Hidden = True
            .Columns("Nombre").Hidden = False
            .Columns("Nombre").Width = 500
            .Columns("Descripcion").Hidden = True
        End With
    End Sub

    Private Sub cboPuntoLlegada_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboPuntoLlegada.InitializeLayout
        With cboPuntoLlegada.DisplayLayout.Bands(0)
            .Columns("Id").Hidden = True
            .Columns("Nombre").Hidden = False
            .Columns("Nombre").Width = 500
            .Columns("Descripcion").Hidden = True
        End With
    End Sub

    Private Sub cboPuntoPartida_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboPuntoPartida.KeyDown
        With CType(sender, Infragistics.Win.UltraWinGrid.UltraCombo)
            If e.KeyData = Keys.Delete Then
                .Text = ""
            End If
        End With

        If e.KeyCode = Keys.Enter Then
            If cboPuntoPartida.Text.Trim = "" Then
                cboPuntoPartida.DataSource = Nothing
                cboPuntoPartida.DataSource = ListaPuntoPartida
            Else
                cboPuntoPartida.DataSource = Nothing
                ListaDireccionEmpresa = ListaPuntoPartida
                cboPuntoPartida.DataSource = ListaDireccionEmpresa.Where(Function(Item) Item.Nombre.Contains(cboPuntoPartida.Text.Trim)).ToList
            End If
        End If
    End Sub

    Private Sub cboPuntoPartida_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboPuntoPartida.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cboPuntoPartida.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub cboPuntoLlegada_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboPuntoLlegada.KeyDown
        With CType(sender, Infragistics.Win.UltraWinGrid.UltraCombo)
            If e.KeyData = Keys.Delete Then
                .Text = ""
            End If
        End With

        If e.KeyCode = Keys.Enter Then
            If cboPuntoLlegada.Text.Trim = "" Then
                cboPuntoLlegada.DataSource = Nothing
                cboPuntoLlegada.DataSource = ListaPuntoLlegada
            Else
                cboPuntoLlegada.DataSource = Nothing
                ListaDireccionEmpresa = ListaPuntoLlegada
                cboPuntoLlegada.DataSource = ListaDireccionEmpresa.Where(Function(Item) Item.Nombre.Contains(cboPuntoLlegada.Text.Trim)).ToList
            End If
        End If
    End Sub

    Private Sub cboPuntoLlegada_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboPuntoLlegada.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cboPuntoLlegada.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub fecEmision_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecEmision.Validated
        fecEmisionGrr.Value = fecEmision.Value
        fecEmisionGrrViaje.Value = fecEmision.Value
        If griGuiaRemitente.Rows.Count > 0 Then
            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griGuiaRemitente.Rows
                fila.Cells("Fecha").Value = fecEmision.Value
            Next
        End If
        If griGuiaRemitenteViaje.Rows.Count > 0 Then
            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griGuiaRemitenteViaje.Rows
                fila.Cells("Fecha").Value = fecEmision.Value
            Next
        End If

        If griGuiaTransportistaViaje.Rows.Count > 0 Then
            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griGuiaTransportistaViaje.Rows
                fila.Cells("Fecha").Value = fecEmision.Value
            Next
        End If

    End Sub

    Private Sub tabDetalleGrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabDetalleGrt.Click
        fecEmisionGrr.Value = fecEmision.Value
        fecEmisionGrrViaje.Value = fecEmision.Value
        fecPartidaViajeInterrumpido.Value = fecViaje.Value
    End Sub

    Private Sub EliminarGrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarGrt.Click
        IndDireccionarGRT = False
        Eliminar()
    End Sub

    Private Sub griGrtConfirmarBloque_ClickCellButton(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griGrtConfirmarBloque.ClickCellButton
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Select Case e.Cell.Column.Key
                Case "Piloto"
                    Dim formulario As frm_FichaPersonal
                    formulario = frm_FichaPersonal
                    If formulario.MostrarTrabajador(griGrtConfirmarBloque.ActiveRow.Cells("Ayudante").Value) Then formulario.ShowDialog()
                    ControlBoton(1, 0, 1, 0, 0, 1, 1, 1, 1)
                Case "Tesoreria"
                    If ValidaCamposGriBloque() Then
                        oeGuiaTransportista = New e_GuiaTransportista
                        oeGuiaTransportista.TipoOperacion = "I"
                        With griGrtConfirmarBloque.ActiveRow
                            oeGuiaTransportista.Id = RTrim(.Cells("Id").Value)
                            oeGuiaTransportista.Serie = FormatoDocumento(RTrim(.Cells("Codigo").Value), 4)
                            oeGuiaTransportista.Numero = FormatoDocumento(RTrim(.Cells("IdCopiloto").Value), 10)
                            oeGuiaTransportista.IdSeguimiento = RTrim(.Cells("IdAyudante").Value)
                            oeGuiaTransportista.IdRemitente = RTrim(.Cells("IdEscala").Value)
                            oeGuiaTransportista.IdDireccionLugarPartida = RTrim(.Cells("IdEstado").Value)
                            oeGuiaTransportista.IdDestinatario = RTrim(.Cells("Escala").Value)
                            oeGuiaTransportista.IdDireccionLugarLlegada = RTrim(.Cells("IdTracto").Value)
                            oeGuiaTransportista.IdMotivoDocumentoTraslado = "1CH000000006"
                            oeGuiaTransportista.Glosa = ""
                            oeGuiaTransportista.Fecha = .Cells("LlegadaOrigen").Value
                            oeGuiaTransportista.UsuarioCreacion = gUsuarioSGI.Id
                            oeGuiaTransportista.Activo = True
                            oeGuiaTransportista.IdSubContrata = ""
                            oeGuiaTransportista.SubSerie = ""
                            oeGuiaTransportista.SubNumero = ""
                            oeGuiaTransportista.IdOperacionDetalle = RTrim(.Cells("GlosaEscala").Value)
                            oeGuiaTransportista.PesoToneladas = .Cells("PesoToneladas").Value
                            oeGuiaTransportista.IndGrtConfirmada = .Cells("IndFecha").Value
                            oeGuiaTransportista.IndDocumentos = .Cells("DiaNoche").Value
                            oeGuiaTransportista.IndGrtPerdido = .Cells("IndEscala").Value
                            oeGuiaTransportista.Incidencia = ""
                            oeGuiaTransportista.IndGuiaTercero = IIf(.Cells("IdTercero").Value = "1CH000004444", False, True)

                            oeGuiaTransportista.OperacionDetalle = New List(Of e_OperacionDetalle)
                            oeOperacionDetalle = New e_OperacionDetalle
                            oeOperacionDetalle.TipoOperacion = "B"
                            oeOperacionDetalle.Id = RTrim(.Cells("GlosaEscala").Value)
                            oeOperacionDetalle.Carga = RTrim(.Cells("CargaMaterial").Value)
                            oeOperacionDetalle.Material = RTrim(.Cells("Flota").Value)
                            oeOperacionDetalle.PesoToneladasDescarga = .Cells("PesoToneladas").Value
                            oeOperacionDetalle.IncluyeIgv = .Cells("Turno").Value
                            oeOperacionDetalle.FleteUnitario = .Cells("KmCarretaDestino").Value
                            oeOperacionDetalle.Flete = .Cells("TotalFlete").Value
                            oeOperacionDetalle.Cliente = .Cells("Cliente").Value
                            oeOperacionDetalle.Activo = True
                            oeGuiaTransportista.OperacionDetalle.Add(oeOperacionDetalle)

                            oeGuiaTransportista.GuiaRemitente = New List(Of e_GuiaRemitente)
                            oeGuiaRemitente = New e_GuiaRemitente
                            oeGuiaRemitente.Id = RTrim(.Cells("UsuarioCreacion").Value)
                            oeGuiaRemitente.Serie = FormatoDocumento(RTrim(.Cells("IdTipoVehiculo").Value), 4)
                            oeGuiaRemitente.Numero = FormatoDocumento(RTrim(.Cells("TipoVehiculo").Value), 10)
                            oeGuiaRemitente.IdGuiaTransportista = RTrim(.Cells("Id").Value)
                            oeGuiaRemitente.GuiaTransportista = FormatoDocumento(RTrim(.Cells("Codigo").Value), 4) + "-" + FormatoDocumento(RTrim(griGrtConfirmarBloque.ActiveRow.Cells("IdCopiloto").Value), 10)
                            oeGuiaRemitente.Fecha = .Cells("LlegadaOrigen").Value
                            oeGuiaRemitente.Activo = True
                            oeGuiaRemitente.Viaje = RTrim(.Cells("Operacion").Value)
                            oeGuiaTransportista.GuiaRemitente.Add(oeGuiaRemitente)
                        End With

                        If olGuiaTransportista.Guardar(oeGuiaTransportista) Then
                            griGrtConfirmarBloque.ActiveRow.CellAppearance.BackColor = Me.ColorBloque.Color
                        End If

                    End If
            End Select
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub griGrtConfirmarBloque_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griGrtConfirmarBloque.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            If EliminarGuiaTransportista(griGrtConfirmarBloque) Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        Catch ex As Exception
            e.Cancel = True
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Sub

    Private Sub griGrtConfirmarBloque_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griGrtConfirmarBloque.CellChange
        Try
            griGrtConfirmarBloque.UpdateData()
            FleteDetalleGrillaBloque()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griGrtConfirmarBloque_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griGrtConfirmarBloque.KeyDown
        Try
            If e.KeyValue = 13 Then
                With griGrtConfirmarBloque
                    Select Case .ActiveRow.Cells(.ActiveCell.Column.Index).Column.Key
                        Case "Codigo"
                            .PerformAction(UltraGridAction.NextCellByTab)
                        Case "IdCopiloto"
                            .PerformAction(UltraGridAction.NextCellByTab)
                        Case "IdTipoVehiculo"
                            .PerformAction(UltraGridAction.NextCellByTab)
                        Case "TipoVehiculo"
                            .PerformAction(UltraGridAction.NextCellByTab)
                        Case "Turno"
                            With griGrtConfirmarBloque.Rows(.ActiveRow.Index)
                                FleteDetalleGrillaBloque()
                            End With
                            .PerformAction(UltraGridAction.NextCellByTab)
                        Case "PesoToneladas"
                            FleteDetalleGrillaBloque()
                            With griGrtConfirmarBloque.Rows(.ActiveRow.Index)
                                If .Cells("PesoToneladas").Value.ToString.Length = 0 Or Not IsNumeric(.Cells("PesoToneladas").Value.ToString) Then
                                    .Cells("PesoToneladas").Value = 0.0
                                    Throw New Exception("Ingrese PesoToneladas")
                                End If
                                If .Cells("PesoToneladas").Value = 0 Or Not IsNumeric(.Cells("PesoToneladas").Value.ToString) Then
                                    .Cells("PesoToneladas").Value = 0.0
                                    Throw New Exception("PesoToneladas no Puede ser 0")
                                End If
                            End With
                            .PerformAction(UltraGridAction.NextCellByTab)
                            .PerformAction(UltraGridAction.NextCellByTab)
                        Case "DiaNoche"
                            .PerformAction(UltraGridAction.NextCellByTab)
                        Case "IndFecha"
                            .PerformAction(UltraGridAction.NextCellByTab)
                        Case "KmCarretaDestino"
                            FleteDetalleGrillaBloque()
                            With griGrtConfirmarBloque.Rows(.ActiveRow.Index)
                                If .Cells("KmCarretaDestino").Value.ToString.Length = 0 Then Throw New Exception("Ingrese Flete Unitario")
                            End With
                            .PerformAction(UltraGridAction.NextCellByTab)

                    End Select
                End With
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Sub

    Private Sub griGrtConfirmarBloque_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles griGrtConfirmarBloque.BeforeCellUpdate
        With griGrtConfirmarBloque
            Select Case e.Cell.Column.Key
                Case "Codigo"
                    If e.Cell.Column.Key = "Codigo" Then If IsDBNull(e.NewValue) Then e.Cancel = True
                Case "IdCopiloto"
                    If e.Cell.Column.Key = "IdCopiloto" Then If IsDBNull(e.NewValue) Then e.Cancel = True
                Case "IdTipoVehiculo"
                    If e.Cell.Column.Key = "IdTipoVehiculo" Then If IsDBNull(e.NewValue) Then e.Cancel = True
                Case "TipoVehiculo"
                    If e.Cell.Column.Key = "TipoVehiculo" Then If IsDBNull(e.NewValue) Then e.Cancel = True
            End Select
        End With
    End Sub

    Private Sub ConfirmarViaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfirmarViaje.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            With griLista.ActiveRow
                If RTrim(.Cells("Id").Value) = "0" Then
                    Dim formulario As frm_ConfirmarGRT
                    formulario = frm_ConfirmarGRT
                    If formulario.ObtenerViaje(RTrim(.Cells("IdOperacion").Value)) Then formulario.ShowDialog()
                    If IndGrtConfirmada Then
                        .Cells("IndFecha").Value = True
                        If IndDocumentos Then
                            .CellAppearance.BackColor = Me.ColorConDocts.Color
                            .Cells("DiaNoche").Value = True
                        Else
                            .CellAppearance.BackColor = Me.ColorSinDocts.Color
                            .Cells("DiaNoche").Value = False
                        End If
                        If .Cells("ViajeVacio").Value And IndDocumentos Then
                            .CellAppearance.BackColor = Me.ColorFactConDocts.Color
                        Else
                            If .Cells("ViajeVacio").Value And IndDocumentos = False Then
                                .CellAppearance.BackColor = Me.ColorFactSinDocts.Color
                            End If
                        End If
                    Else
                        .CellAppearance.BackColor = Me.ColorSinConfirmar.Color
                    End If
                    If IndGrtPerdido Then
                        .Cells("IndEscala").Value = True
                        .Cells("Codigo").Appearance.BackColor = Me.ColorDoctsPerdido.Color
                        .Cells("Flota").Appearance.BackColor = Me.ColorDoctsPerdido.Color
                    Else
                        .Cells("IndEscala").Value = False
                        .Cells("Codigo").Appearance.BackColor = Color.White
                        .Cells("Flota").Appearance.BackColor = Color.White
                    End If
                    ControlBoton(1, 0, 1, 0, 0, 1, 1, 1, 1)
                Else
                    Throw New Exception("Esta opcion no es valida para este viaje ")
                End If
            End With
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub griLista_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles griLista.BeforeCellUpdate
        With griLista
            Select Case e.Cell.Column.Key
                Case "IncidenciaSeguimiento"
                    If e.Cell.Column.Key = "IncidenciaSeguimiento" Then If IsDBNull(e.NewValue) Then e.Cancel = True
            End Select
        End With
    End Sub

    Private Sub griLista_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griLista.CellChange
        griLista.UpdateData()
    End Sub

    Private Sub txtRangoFinalNumeroAnulado_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRangoFinalNumeroAnulado.Validated
        If txtRangoFinalNumeroAnulado.Text <> "" Then
            txtRangoFinalNumeroAnulado.Text = FormatoDocumento(txtRangoFinalNumeroAnulado.Text, 10)
        End If
    End Sub

    '  Private Sub griGuiaTransportistaViaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griGuiaTransportistaViaje.Click
    'Dim PuntoPartida As String = ""
    'Dim PuntoLlegada As String = ""
    'If griGuiaTransportistaViaje.Rows.Count > 0 Then
    '    With griGuiaTransportistaViaje.ActiveRow                
    '        txtIdGrt.Text = .Cells("Id").Value
    '        txtSerie.Text = .Cells("Serie").Value
    '        txtNumero.Text = .Cells("Numero").Value
    '        fecEmision.Value = .Cells("Fecha").Value
    '        txtGrtPT.Text = .Cells("PesoToneladas").Value
    '        cboRemitente.Value = .Cells("IdRemitente").Value
    '        PuntoPartida = .Cells("IdDireccionLugarPartida").Value
    '        cboDestinatario.Value = .Cells("IdDestinatario").Value
    '        PuntoLlegada = .Cells("IdDireccionLugarLlegada").Value
    '        cboSubContrata.Value = .Cells("IdSubContrata").Value
    '        txtSubSerie.Text = .Cells("SubSerie").Value
    '        txtSubNumero.Text = .Cells("SubNumero").Value
    '        verConfirmado.Checked = .Cells("IndGrtConfirmada").Value
    '        verDocumentos.Checked = .Cells("IndDocumentos").Value
    '        verDoctsPerdido.Checked = .Cells("IndGrtPerdido").Value
    '        cboMotivoTraslado.Value = .Cells("IdMotivoDocumentoTraslado").Value
    '        txtGlosa.Text = .Cells("Glosa").Value
    '        txtGrtCantidad.Text = .Cells("Cantidad").Value
    '        Me.chkGuiaTercero.Checked = IIf(.Cells("IndGuiaTercero").Value = True, True, False)
    '    End With
    '    cboRemitente_Validated(Nothing, Nothing)
    '    cboPuntoPartida.Value = PuntoPartida
    '    cboDestinatario_Validated(Nothing, Nothing)
    '    cboPuntoLlegada.Value = PuntoLlegada
    'End If
    '  End Sub

    Private Sub DocumentosViaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DocumentosViaje.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If RTrim(griLista.ActiveRow.Cells("Id").Value.ToString).Length > 1 Then
                Dim formulario As frm_DocumentosViaje
                formulario = frm_DocumentosViaje
                If formulario.ListarDocumentosViaje(RTrim(griLista.ActiveRow.Cells("Id").Value), RTrim(griLista.ActiveRow.Cells("IdOperacion").Value)) Then formulario.ShowDialog()
                ControlBoton(1, 0, 1, 0, 0, 1, 1, 1, 1)
            Else
                Throw New Exception("Esta opcion no es valida para este viaje ")
            End If
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub txtSerie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerie.Click
        txtSerie.SelectAll()
    End Sub

    Private Sub txtSerie_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerie.Enter
        txtNumero.SelectAll()
    End Sub

    Private Sub txtNumero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.Click
        txtNumero.SelectAll()
    End Sub

    Private Sub txtNumero_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.Enter
        txtNumero.SelectAll()
    End Sub

    Private Sub txtRangoFinalNumeroAnulado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRangoFinalNumeroAnulado.Click
        txtRangoFinalNumeroAnulado.SelectAll()
    End Sub

    Private Sub txtRangoFinalNumeroAnulado_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRangoFinalNumeroAnulado.Enter
        txtRangoFinalNumeroAnulado.SelectAll()
    End Sub

    Private Sub txtSubSerie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubSerie.Click
        txtSubSerie.SelectAll()
    End Sub

    Private Sub txtSubSerie_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubSerie.Enter
        txtSubSerie.SelectAll()
    End Sub

    Private Sub txtSubNumero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubNumero.Click
        txtSubNumero.SelectAll()
    End Sub

    Private Sub txtSubNumero_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubNumero.Enter
        txtSubNumero.SelectAll()
    End Sub

    Private Sub DireccionarGRT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DireccionarGRT.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            IndDireccionarGRT = False
            If RTrim(griLista.ActiveRow.Cells("Id").Value.ToString).Length > 1 Then
                Dim formulario As frm_DireccionarGRT
                formulario = frm_DireccionarGRT
                If formulario.ObtenerViaje(RTrim(griLista.ActiveRow.Cells("IdOperacion").Value), RTrim(griLista.ActiveRow.Cells("Id").Value)) Then formulario.ShowDialog()
                ControlBoton(1, 0, 1, 0, 0, 1, 1, 1, 1)
            Else
                Throw New Exception("Esta opcion no es valida para este viaje ")
            End If
            If IndDireccionarGRT Then
                Eliminar()
            End If
            IndDireccionarGRT = False
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub griGuiaRemitenteViaje_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles griGuiaRemitenteViaje.BeforeCellUpdate
        With griGuiaRemitenteViaje
            Select Case e.Cell.Column.Key
                Case "Glosa"
                    If e.Cell.Column.Key = "Glosa" Then If IsDBNull(e.NewValue) Then e.Cancel = True
            End Select
        End With
    End Sub

    Private Sub griGuiaRemitente_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles griGuiaRemitente.BeforeCellUpdate
        With griGuiaRemitente
            Select Case e.Cell.Column.Key
                Case "Glosa"
                    If e.Cell.Column.Key = "Glosa" Then If IsDBNull(e.NewValue) Then e.Cancel = True
            End Select
        End With
    End Sub

    Private Sub verTracto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verTracto.CheckedChanged
        If verTracto.Checked Then
            cboTractoLista.Enabled = verTracto.Checked
            cboTractoLista.Focus()
        Else
            cboTractoLista.Enabled = verTracto.Checked
            cboTractoLista.Text = ""
        End If
    End Sub

    Private Sub MenuGrtBloque_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuGrtBloque.Opening
        If griGrtConfirmarBloque.Selected.Rows.Count > 0 Then
            MenuGrtBloque.Items("EliminarGrtBloque").Visible = True
            MenuGrtBloque.Items("ConfirmarDoctsViajeBloque").Visible = True
            MenuGrtBloque.Items("DocumentosViajeBloque").Visible = True
            MenuGrtBloque.Items("DireccionarGrtBloque").Visible = True
        Else
            MenuGrtBloque.Items("EliminarGrtBloque").Visible = False
            MenuGrtBloque.Items("ConfirmarDoctsViajeBloque").Visible = False
            MenuGrtBloque.Items("DocumentosViajeBloque").Visible = False
            MenuGrtBloque.Items("DireccionarGrtBloque").Visible = False
        End If
    End Sub

    Private Sub EliminarGrtBloque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarGrtBloque.Click
        griGrtConfirmarBloque.ActiveRow.Delete()
    End Sub

    Private Sub griViajeConfirmarBloque_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griViajeConfirmarBloque.InitializeLayout
        e.Layout.Grid.CalcManager = Nothing
        agrListaRegistro.Text = "Lista Registros: " & e.Layout.Rows.Count & Estado
    End Sub

    Private Sub griViajeConfirmarBloque_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griViajeConfirmarBloque.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub cboPuntoPartida_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPuntoPartida.Validated
        GrtActualiza()
    End Sub

    Private Sub cboPuntoLlegada_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPuntoLlegada.Validated
        GrtActualiza()
    End Sub

    Private Sub cboSubContrata_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSubContrata.Validated
        GrtActualiza()
    End Sub

    Private Sub verConfirmado_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verConfirmado.Validated
        GrtActualiza()
    End Sub

    Private Sub verDocumentos_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verDocumentos.Validated
        GrtActualiza()
    End Sub

    Private Sub verDoctsPerdido_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verDoctsPerdido.Validated
        GrtActualiza()
    End Sub

    Private Sub cboMotivoTraslado_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMotivoTraslado.Validated
        GrtActualiza()
    End Sub

    Private Sub griViajeConfirmarBloque_ClickCellButton(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griViajeConfirmarBloque.ClickCellButton
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Select Case e.Cell.Column.Key
                Case "Piloto"
                    Dim formulario As frm_FichaPersonal
                    formulario = frm_FichaPersonal
                    If formulario.MostrarTrabajador(griViajeConfirmarBloque.ActiveRow.Cells("Ayudante").Value) Then formulario.ShowDialog()
                    ControlBoton(1, 0, 1, 0, 0, 1, 1, 1, 1)
                Case "Tesoreria"
                    If griViajeConfirmarBloque.ActiveRow.Cells("IndFecha").Value Then
                        oeOperacionDetalle = New e_OperacionDetalle
                        oeOperacionDetalle.TipoOperacion = "C"
                        With griViajeConfirmarBloque.ActiveRow
                            oeOperacionDetalle.Id = RTrim(.Cells("GlosaEscala").Value)
                            oeOperacionDetalle.Carga = RTrim(.Cells("CargaMaterial").Value)
                            oeOperacionDetalle.Material = RTrim(.Cells("Flota").Value)
                            oeOperacionDetalle.PesoToneladasDescarga = .Cells("PesoToneladas").Value
                            oeOperacionDetalle.IncluyeIgv = .Cells("Turno").Value
                            oeOperacionDetalle.FleteUnitario = .Cells("KmCarretaDestino").Value
                            oeOperacionDetalle.Flete = .Cells("TotalFlete").Value
                            oeOperacionDetalle.Cliente = .Cells("Cliente").Value
                            oeOperacionDetalle.Activo = True
                        End With
                        If olOperacion.GuardarOperacionDetalle(oeOperacionDetalle) Then
                            griViajeConfirmarBloque.ActiveRow.CellAppearance.BackColor = Me.ColorBloque.Color
                        End If
                    End If
            End Select
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub griViajeConfirmarBloque_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griViajeConfirmarBloque.CellChange
        Try
            griViajeConfirmarBloque.UpdateData()
            FleteDetalleGrillaBloqueSinDocumento()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griViajeConfirmarBloque_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griViajeConfirmarBloque.KeyDown
        Try
            If e.KeyValue = 13 Then
                With griViajeConfirmarBloque
                    Select Case .ActiveRow.Cells(.ActiveCell.Column.Index).Column.Key
                        Case "Codigo"
                            .PerformAction(UltraGridAction.NextCellByTab)
                        Case "IdCopiloto"
                            .PerformAction(UltraGridAction.NextCellByTab)
                        Case "IdTipoVehiculo"
                            .PerformAction(UltraGridAction.NextCellByTab)
                        Case "TipoVehiculo"
                            .PerformAction(UltraGridAction.NextCellByTab)
                        Case "Turno"
                            With griGrtConfirmarBloque.Rows(.ActiveRow.Index)
                                FleteDetalleGrillaBloqueSinDocumento()
                            End With
                            .PerformAction(UltraGridAction.NextCellByTab)
                        Case "PesoToneladas"
                            FleteDetalleGrillaBloqueSinDocumento()
                            With griViajeConfirmarBloque.Rows(.ActiveRow.Index)
                                If .Cells("PesoToneladas").Value.ToString.Length = 0 Or Not IsNumeric(.Cells("PesoToneladas").Value.ToString) Then
                                    .Cells("PesoToneladas").Value = 0.0
                                    Throw New Exception("Ingrese PesoToneladas")
                                End If
                                If .Cells("PesoToneladas").Value = 0 Or Not IsNumeric(.Cells("PesoToneladas").Value.ToString) Then
                                    .Cells("PesoToneladas").Value = 0.0
                                    Throw New Exception("PesoToneladas no Puede ser 0")
                                End If
                            End With
                            .PerformAction(UltraGridAction.NextCellByTab)
                            .PerformAction(UltraGridAction.NextCellByTab)
                        Case "DiaNoche"
                            .PerformAction(UltraGridAction.NextCellByTab)
                        Case "IndFecha"
                            .PerformAction(UltraGridAction.NextCellByTab)
                        Case "KmCarretaDestino"
                            FleteDetalleGrillaBloqueSinDocumento()
                            With griViajeConfirmarBloque.Rows(.ActiveRow.Index)
                                If .Cells("KmCarretaDestino").Value.ToString.Length = 0 Then Throw New Exception("Ingrese Flete Unitario")
                            End With
                            .PerformAction(UltraGridAction.NextCellByTab)
                    End Select
                End With
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Sub

    Private Sub fecDesde_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles fecDesde.Validating
        If fecDesde.Value = Nothing Then
            fecDesde.Value = Today.Date
        End If
    End Sub

    Private Sub fecHasta_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles fecHasta.Validating
        If fecHasta.Value = Nothing Then
            fecHasta.Value = Today.Date
        End If
    End Sub

    Private Sub txtRemitenteGlosa_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRemitenteGlosa.Validated
        Try
            Dim NroCarga As String
            Dim NroCargaDigitos As String
            If cboRemitente.Text = "SUPERMERCADOS PERUANOS S.A." Then
                NroCarga = txtRemitenteGlosa.Text.Trim
                NroCargaDigitos = Microsoft.VisualBasic.Left(NroCarga, 3)
                If NroCarga <> "" Then
                    If NroCargaDigitos = "OSF" Or NroCargaDigitos = "SPF" Then
                        If (NroCarga.Length - 3) <> 11 Then
                            txtRemitenteGlosa.Focus()
                            Throw New Exception("Longitud de caracteres despues de OSF/SPF son de 11 digistos enteros Ejemplo: OSF00300034412 / SPF00300034412")
                        End If
                        If Not IsNumeric(Microsoft.VisualBasic.Right(NroCarga, 11)) Then
                            txtRemitenteGlosa.Focus()
                            Throw New Exception("Longitud de caracteres despues de OSF/SPF son de 11 digistos enteros Ejemplo: OSF00300034412 / SPF00300034412")
                        End If
                    Else
                        If NroCarga.Length < 8 Or NroCarga.Length > 10 Then
                            txtGlosaRemitente.Focus()
                            Throw New Exception("Longitud de caracteres son de mayor 8 y menor 10 digistos enteros por Ejemplo: 0000034412")
                        End If
                        If Not IsNumeric(NroCarga) Then
                            txtRemitenteGlosa.Focus()
                            Throw New Exception("Longitud de caracteres son de 8 digistos enteros por Ejemplo: 00034412")
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Sub

    Private Sub txtGlosaRemitente_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosaRemitente.Validated
        Try
            Dim NroCarga As String
            Dim NroCargaDigitos As String
            If cboRemitente.Text = "SUPERMERCADOS PERUANOS S.A." Then
                NroCarga = txtGlosaRemitente.Text.Trim
                NroCargaDigitos = Microsoft.VisualBasic.Left(NroCarga, 3)
                If NroCarga <> "" Then
                    If NroCargaDigitos = "OSF" Or NroCargaDigitos = "SPF" Then
                        If (NroCarga.Length - 3) <> 11 Then
                            txtGlosaRemitente.Focus()
                            Throw New Exception("Longitud de caracteres despues de OSF/SPF son de 11 digistos enteros Ejemplo: OSF00300034412 / SPF00300034412")
                        End If
                        If Not IsNumeric(Microsoft.VisualBasic.Right(NroCarga, 11)) Then
                            txtGlosaRemitente.Focus()
                            Throw New Exception("Longitud de caracteres despues de OSF/SPF son de 11 digistos enteros Ejemplo: OSF00300034412 / SPF00300034412")
                        End If
                    Else
                        If NroCarga.Length < 8 Or NroCarga.Length > 10 Then
                            txtGlosaRemitente.Focus()
                            Throw New Exception("Longitud de caracteres son de mayor 8 y menor 10 digistos enteros por Ejemplo: 0000034412")
                        End If
                        If Not IsNumeric(NroCarga) Then
                            txtGlosaRemitente.Focus()
                            Throw New Exception("Longitud de caracteres son de 8 digistos enteros por Ejemplo: 0000034412")
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Sub

    Private Sub txtGrtCantidad_Validated(sender As Object, e As EventArgs) Handles txtGrtCantidad.Validated
        GrtActualiza()
    End Sub

    Private Sub txtGrtPT_Validated(sender As Object, e As EventArgs) Handles txtGrtPT.Validated
        GrtActualiza()
    End Sub

#End Region

#Region "Métodos"

    Private Sub AyudaMaestros(ByVal Tipo As Integer)
        Select Case Tipo
            Case 2
                Dim Cliente As New DataTable
                ClientesPublic = New List(Of e_Combo)
                oeCombo = New e_Combo
                oeCombo.Nombre = "Clientes"
                ClientesPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

                Cliente = olCombo.ComboGrilla(ClientesPublic)
                CrearComboGrid("IdRemitente", "Nombre", griGuiaTransportistaViaje, Cliente, True)
                CrearComboGrid("IdDestinatario", "Nombre", griGuiaTransportistaViaje, Cliente, True)
                CrearComboGrid("Cliente", "Nombre", griViajeDetalle, Cliente, True)
        End Select
    End Sub

    Private Sub ControlRangoFechaInicializa()
        fecDesde.Value = Date.Today.AddDays(-5)
        fecHasta.Value = Date.Today.AddDays(+1)
    End Sub

    Private Sub GrtActualiza()
        If griGuiaTransportistaViaje.Rows.Count > 0 Then
            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griGuiaTransportistaViaje.Rows
                With fila
                    If FormatoDocumento(.Cells("Serie").Value, 4) = txtSerie.Text And FormatoDocumento(.Cells("Numero").Value, 10) = txtNumero.Text Then
                        .Cells("PesoToneladas").Value = txtGrtPT.Text
                        .Cells("IdRemitente").Value = cboRemitente.Value
                        .Cells("IdDireccionLugarPartida").Value = cboPuntoPartida.Value
                        .Cells("IdDestinatario").Value = cboDestinatario.Value
                        .Cells("IdDireccionLugarLlegada").Value = cboPuntoLlegada.Value
                        .Cells("IdSubContrata").Value = cboSubContrata.Value
                        .Cells("SubSerie").Value = txtSubSerie.Text
                        .Cells("SubNumero").Value = txtSubNumero.Text
                        .Cells("IndGrtConfirmada").Value = verConfirmado.Checked
                        .Cells("IndDocumentos").Value = verDocumentos.Checked
                        .Cells("IndGrtPerdido").Value = verDoctsPerdido.Checked
                        .Cells("IdMotivoDocumentoTraslado").Value = cboMotivoTraslado.Value
                        .Cells("Glosa").Value = txtGlosa.Text
                        .Cells("IdOperacionDetalle").Value = txtIdOperacionDetalle.Text
                        .Cells("Cantidad").Value = txtGrtCantidad.Text
                        Exit For
                    End If
                End With
            Next
        End If
    End Sub

    Private Function ActualizaRegistroEditado() As Boolean
        Try
            If RegistroEditado = 1 Then
                oeRegistroEditado = New e_RegistrosEditados
                oeRegistroEditado.Id = IdRegistroEditado
                olRegistroEditado.Guardar(oeRegistroEditado)
                RegistroEditado = 0
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Inicializar()
        txtIdGrt.Text = ""
        txtSerie.Text = ""
        txtNumero.Text = ""
        txtGrtPT.Value = 0
        txtGrtCantidad.Text = 0
        txtSubSerie.Text = ""
        txtSubNumero.Text = ""
        verConfirmado.Checked = False
        verDocumentos.Checked = False
        txtGlosa.Text = ""
        txtGlosaRemitente.Text = ""
        txtRemitenteGlosa.Text = ""
        txtIdOperacion.Text = ""
        txtCodigoOperacion.Text = ""
        txtIdViaje.Text = ""
        txtCodigoViaje.Text = ""
        txtIdSeguimiento.Text = ""
        txtIdOperacionDetalle.Text = ""
        txtViajeTracto.Text = ""
        txtViajeCarreta.Text = ""
        txtViajeOrigen.Text = ""
        txtViajeDestino.Text = ""
        txtViajeEscala.Text = ""
        txtViajePiloto.Text = ""
        txtViajeCopiloto.Text = ""
        txtGrr.Text = ""
        txtRangoGrr.Text = ""
        txtGuiaTransportista.Text = ""
        txtGrrViaje.Text = ""
        txtGrrRangoViaje.Text = ""
        LimpiaGrid(griGuiaRemitente, ogdGuiaRemitente)
        LimpiaGrid(griViajeInterrumpido, ogdGuiaTransportistaInterrumpido)
        LimpiaGrid(griGrtAnuladas, ogdGuiaTransportista)
        LimpiaGrid(griGuiaTransportistaViaje, ogdGuiaTransportista)
        LimpiaGrid(griGuiaRemitenteViaje, ogdGuiaRemitente)
        griViajeDetalle.DataSource = New List(Of e_OperacionDetalle)

        'Glosas
        GlosaDetalleDemanda = ""
        ValoresAnterioresDetalleDemanda = ""
        ValoresActualesDetalleDemanda = ""
        ListaBitacora.Clear()
        'deshabilitar

        'llenar bidimensional
        For i As Integer = 0 To 14
            rowGeneral(i, 0) = -1
            rowGeneral(i, 1) = -1
        Next

        For i As Integer = 0 To 14
            glosasGeneral(i, 0) = ""
            glosasGeneral(i, 1) = -1
            glosasGeneral(i, 2) = -1
        Next
        Me.chkGuiaTercero.Visible = False
        'piloto de tercero
        Me.cboPilotoTercero.Visible = False
        Me.lblPilotoGRT.Visible = False
        Me.cboPilotoTercero.Value = ""

    End Sub

    Public Sub Listar(ByVal Grilla As Infragistics.Win.UltraWinGrid.UltraGrid)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            With oeViaje
                If txtGuiaRemitente.Text <> "" Then
                    ValidarCombo(cboRemitenteBusca, "Remitente")
                    Dim GuiaRemitente() As String = txtGuiaRemitente.Text.Split("-")
                    .Serie = GuiaRemitente(0).ToString.Trim
                    .Numero = GuiaRemitente(1).ToString.Trim
                    .Remitente = cboRemitenteBusca.Value
                End If
                If verViajeVacio.Checked Then
                    .ViajeVacio = 1
                Else
                    .ViajeVacio = 2
                End If
                .FechaDesde = fecDesde.Value
                .FechaHasta = fecHasta.Value
                .Centro = cboCentro.Value
                .IndMotriz = 1
                .IdTracto = cboTractoLista.Value
            End With

            If tabLista.Tabs(0).Selected Then
                Grilla.DataSource = olOperacion.ListarViaje(oeViaje)
                If opcTipoColores.CheckedIndex = 0 Then
                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In Grilla.Rows
                        If fila.Cells("IndFecha").Value Then
                            If fila.Cells("DiaNoche").Value Then
                                fila.CellAppearance.BackColor = Me.ColorConDocts.Color
                            Else
                                fila.CellAppearance.BackColor = Me.ColorSinDocts.Color
                            End If
                            If fila.Cells("ViajeVacio").Value And fila.Cells("DiaNoche").Value Then
                                fila.CellAppearance.BackColor = Me.ColorFactConDocts.Color
                            Else
                                If fila.Cells("ViajeVacio").Value And fila.Cells("DiaNoche").Value = False Then
                                    fila.CellAppearance.BackColor = Me.ColorFactSinDocts.Color
                                End If
                            End If
                        Else
                            fila.CellAppearance.BackColor = Me.ColorSinConfirmar.Color
                        End If
                        If fila.Cells("IndEscala").Value Then
                            fila.Cells("Codigo").Appearance.BackColor = Me.ColorDoctsPerdido.Color
                            fila.Cells("Flota").Appearance.BackColor = Me.ColorDoctsPerdido.Color
                        End If
                    Next
                Else
                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In Grilla.Rows
                        Select Case fila.Cells("Estado").Value
                            Case "TRANSITO"
                                fila.CellAppearance.BackColor = Me.ColorTransito.Color
                            Case "DESCARGA"
                                fila.CellAppearance.BackColor = Me.ColorDescarga.Color
                            Case "FIN"
                                fila.CellAppearance.BackColor = Me.ColorFin.Color
                            Case Else
                                fila.CellAppearance.BackColor = Color.White
                        End Select
                    Next
                End If
                'Ubica el cursor el el primer registro de la grilla
                If Grilla.Rows.Count > 0 Then
                    Grilla.Focus()
                    Grilla.Rows.Item(0).Activated = True
                End If
            Else
                Grilla.DataSource = olOperacion.ListarViaje(oeViaje)
                If opcTipoColores.CheckedIndex = 0 Then
                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In Grilla.Rows
                        If fila.Cells("IndFecha").Value Then
                            If fila.Cells("DiaNoche").Value Then
                                fila.CellAppearance.BackColor = Me.ColorConDocts.Color
                            Else
                                fila.CellAppearance.BackColor = Me.ColorSinDocts.Color
                            End If
                            If fila.Cells("ViajeVacio").Value And fila.Cells("DiaNoche").Value Then
                                fila.CellAppearance.BackColor = Me.ColorFactConDocts.Color
                            Else
                                If fila.Cells("ViajeVacio").Value And fila.Cells("DiaNoche").Value = False Then
                                    fila.CellAppearance.BackColor = Me.ColorFactSinDocts.Color
                                End If
                            End If
                        Else
                            fila.CellAppearance.BackColor = Me.ColorSinConfirmar.Color
                        End If
                        If fila.Cells("IndEscala").Value Then
                            fila.Cells("Codigo").Appearance.BackColor = Me.ColorDoctsPerdido.Color
                            fila.Cells("IdCopiloto").Appearance.BackColor = Me.ColorDoctsPerdido.Color
                            fila.Cells("IdTipoVehiculo").Appearance.BackColor = Me.ColorDoctsPerdido.Color
                            fila.Cells("TipoVehiculo").Appearance.BackColor = Me.ColorDoctsPerdido.Color
                        End If
                    Next
                Else
                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In Grilla.Rows
                        Select Case fila.Cells("Estado").Value
                            Case "TRANSITO"
                                fila.CellAppearance.BackColor = Me.ColorTransito.Color
                            Case "DESCARGA"
                                fila.CellAppearance.BackColor = Me.ColorDescarga.Color
                            Case "FIN"
                                fila.CellAppearance.BackColor = Me.ColorFin.Color
                            Case Else
                                fila.CellAppearance.BackColor = Color.White
                        End Select
                    Next
                End If
                'colocar transportista
                If tabLista.Tabs(2).Selected Then
                    For Each obj As UltraGridRow In griGrtConfirmarBloque.Rows
                        If obj.Cells("DisponibleA").Value = False Then
                            obj.Cells("IdTercero").Value = "1CH000004444"
                        Else
                            Dim ass = obj.Cells("IdTercero").Value
                        End If
                    Next
                End If
                'Ubica el cursor el el primer registro de la grilla
                If Grilla.Rows.Count > 0 Then
                    Grilla.Focus()
                    Grilla.Rows.Item(0).Activated = True
                End If
            End If
            InicializaTiempo()
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    'Public Sub LlenaComboDireccionesLike(ByVal IdEmpresa As String, ByVal Nombre As String)
    '    Try
    '        oeDireccionEmpresa = New e_Direccion_EmpresaPersona
    '        oeDireccionEmpresa.TipoOperacion = "D"
    '        oeDireccionEmpresa.Id = IdEmpresa
    '        oeDireccionEmpresa.oeDireccion.NombreCCPP = Nombre
    '        ListaDireccionEmpresa.AddRange(olDireccionEmpresa.Listar(oeDireccionEmpresa))
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
    '    End Try
    'End Sub

    'Public Sub LlenaComboClienteLike(ByVal Nombre As String)
    '    Try
    '        oeCliente = New e_Cliente
    '        oeCliente.TipoOperacion = "L"
    '        oeCliente.TipoClienteProveedor = 1
    '        oeCliente.Nombre = Nombre
    '        ListaCliente.AddRange(olCliente.Listar(oeCliente))
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
    '    End Try
    'End Sub

    Public Sub LlenaCombos()
        Try
            oeMotivoTrasladoInterrumpido = New e_MotivoDocumento
            LlenarComboMaestro(cboRemitente, ClientesPublic, 0)
            LlenarComboMaestro(cboDestinatario, ClientesPublic, 0)
            LlenarComboMaestro(cboSubContrata, ClientesPublic, 0)
            LlenarComboMaestro(cboRemitenteBusca, ClientesPublic, 0)
            LlenarComboMaestro(cboMotivoTraslado, MotivoDocumentoPublic, 0)
            LlenarComboMaestro(cboMotivoTrasladoInterrumpido, MotivoDocumentoPublic, 0)
            LlenarCombo(cboTractoLista, "Nombre", TractoPublic, -1)
            LlenarComboMaestro(cboCentro, CentroPublic, 0)
            TrabajadorTerceroList = TrabajadorPublic.Where(Function(item) item.Extras(0) = 3).ToList.Where(Function(item) item.Extras(1) = 1 Or item.Extras(1) = 4).ToList
            LlenarComboMaestro(Me.cboPilotoTercero, TrabajadorTerceroList, 0)
            LlenarComboMaestro(Me.cboPilotoTercMasivo, TrabajadorTerceroList, 0)
            OperacionesPublic = New List(Of e_Combo)
            oeCombo.Id = ""
            oeCombo.Nombre = ""
            OperacionesPublic.Add(oeCombo)
            oeCombo = New e_Combo
            oeCombo.Nombre = "VENTAS"
            OperacionesPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
            LlenarComboMaestro(cboActividadNegocio, OperacionesPublic, 0)

            Dim ListTercero = New List(Of e_Combo)
            oeCombo = New e_Combo
            oeCombo.Nombre = "Transportista"
            ListTercero.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
            '   LlenarComboMaestro(cboTransportista, ListTercero, 1)
            '  cboTransportista.Value = "1CH000004444" 'induamerica isl
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboGrilla()
        Dim Lugar As New DataTable
        Dim Cliente As New DataTable
        Dim Carga As New DataTable
        Dim Material As New DataTable
        CrearComboGrid("Moneda", "Nombre", griViajeDetalle, olCombo.ComboGrilla(MonedaPublic), True)

        Cliente = olCombo.ComboGrilla(ClientesPublic)
        CrearComboGrid("Cliente", "Nombre", griViajeDetalle, Cliente, True)
        CrearComboGrid("ClienteFinal", "Nombre", griViajeDetalle, Cliente, True)
        CrearComboGrid("IdRemitente", "Nombre", griGuiaTransportistaViaje, Cliente, True)
        CrearComboGrid("IdDestinatario", "Nombre", griGuiaTransportistaViaje, Cliente, True)
        CrearComboGrid("Cliente", "Nombre", griGrtConfirmarBloque, Cliente, True)
        CrearComboGrid("IdEscala", "Nombre", griGrtConfirmarBloque, Cliente, True)
        CrearComboGrid("Escala", "Nombre", griGrtConfirmarBloque, Cliente, True)
        CrearComboGrid("Cliente", "Nombre", griViajeConfirmarBloque, Cliente, True)

        CrearComboGrid("Comisionista", "Nombre", griViajeDetalle, olCombo.ComboGrilla(ComisionistasPublic), True)

        CrearComboGrid("IdMotivoDocumentoTraslado", "Nombre", griGuiaTransportistaViaje, olCombo.ComboGrilla(MotivoDocumentoPublic), True)

        Carga = olCombo.ComboGrilla(TipoCargaPublic)
        CrearComboGrid("Carga", "Nombre", griViajeDetalle, Carga, True)
        CrearComboGrid("CargaMaterial", "Nombre", griGrtConfirmarBloque, Carga, True)
        CrearComboGrid("CargaMaterial", "Nombre", griViajeConfirmarBloque, Carga, True)

        Material = olCombo.ComboGrilla(MaterialesPublic)
        CrearComboGrid("Material", "Nombre", griViajeDetalle, Material, True)
        CrearComboGrid("Flota", "Nombre", griGrtConfirmarBloque, Material, True)
        CrearComboGrid("Flota", "Nombre", griViajeConfirmarBloque, Material, True)

        Lugar = olCombo.ComboGrilla(LugaresPublic)
        CrearComboGrid("Origen", "Nombre", griViajeDetalle, Lugar, True)
        CrearComboGrid("Destino", "Nombre", griViajeDetalle, Lugar, True)

        CrearComboGrid("IdMotivoTrasladoInterrumpido", "Nombre", griViajeInterrumpido, olCombo.ComboGrilla(MotivoDocumentoPublic), True)
        Dim ListTercero = New List(Of e_Combo)
        oeCombo = New e_Combo
        oeCombo.Nombre = "Transportista"
        ListTercero.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
        CrearComboGrid("IdTercero", "Nombre", griGrtConfirmarBloque, olCombo.ComboGrilla(ListTercero), True)
        'combos piloto tercero
        TrabajadorTerceroList = TrabajadorPublic.Where(Function(item) item.Extras(0) = 3).ToList.Where(Function(item) item.Extras(1) = 1 Or item.Extras(1) = 4).ToList
        '      LlenarComboMaestro(Me.cboPilotoTercero, TrabajadorTerceroList, 0)
        CrearComboGrid("IdPilotoTercero", "Nombre", griGuiaTransportistaViaje, olCombo.ComboGrilla(TrabajadorTerceroList), True)
    End Sub

    Private Sub ValidaTipoColor()
        If opcTipoColores.CheckedIndex = 0 Then
            grupoTipoVehiculo.Enabled = True
            grupoEstado.Enabled = False
        Else
            grupoEstado.Enabled = True
            grupoTipoVehiculo.Enabled = False
        End If
        '----------------------------------------------
        '------Tipo de Vehiculo------------------------
        ColorFactConDocts.Color = Color.Lime
        ColorFactSinDocts.Color = Color.DarkSeaGreen
        ColorConDocts.Color = Color.LightBlue
        ColorSinDocts.Color = Color.PaleTurquoise
        ColorDoctsPerdido.Color = Color.LightCoral
        ColorSinConfirmar.Color = Color.White
        '----------------------------------------------
        '------Estados de Viaje------------------------
        ColorProgramado.Color = Color.White
        ColorCarga.Color = Color.Yellow
        ColorTransito.Color = Color.DarkOrange
        ColorDescarga.Color = Color.Silver
        ColorFin.Color = Color.LimeGreen
        '----------------------------------------------
        '------Cambio de Registro------------------------
        ColorBloque.Color = Color.Cyan
    End Sub

    Dim codigoTercero As String = ""
    Public Function EditarGuia() As Boolean
        Try
            Dim IdGuiaTransportista As String

            If griLista.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                'Viaje
                oeViaje = New e_Viaje
                txtIdViaje.Text = griLista.ActiveRow.Cells("IdOperacion").Value.ToString
                oeViaje.Id = griLista.ActiveRow.Cells("IdOperacion").Value.ToString
                oeViaje.TipoOperacion = "G"
                oeViaje = olOperacion.ObtenerViaje(oeViaje)
                If oeViaje.TipoVehiculo <> "" Then
                    If oeViaje.UsuarioModifica <> gUsuarioSGI.oePersona.NombreCompleto Then
                        Throw New Exception("La información del Viaje no es accesible pues esta siendo editado por" & Environment.NewLine & Environment.NewLine & _
                                            "el Usuario: " & oeViaje.UsuarioModifica & Environment.NewLine & _
                                            "desde: " & oeViaje.LlegadaOrigen & Environment.NewLine & _
                                            "en la Sucursal: " & oeViaje.UsuarioCreacion)
                    Else
                        oeRegistroEditado = New e_RegistrosEditados
                        With oeRegistroEditado
                            .TipoOperacion = "A"
                            .Id = oeViaje.TipoVehiculo
                            .FechaModificado = DateAdd(DateInterval.Minute, 5, oeViaje.LlegadaOrigen)
                        End With
                        olRegistroEditado.Guardar(oeRegistroEditado)
                        RegistroEditado = 1
                    End If
                Else
                    RegistroEditado = 1
                End If
                Dim indGuiaT As Boolean
                'GuiaTransportista
                oeGuiaTransportista = New e_GuiaTransportista
                If Tipo = 1 Then
                    oeGuiaTransportista.Id = "1"
                Else
                    oeGuiaTransportista.Id = griLista.ActiveRow.Cells("Id").Value.ToString
                    oeGuiaTransportista.IndGuiaTercero = Nothing
                    oeGuiaTransportista = olGuiaTransportista.Obtener(oeGuiaTransportista)
                End If
                'devolver idpilototercero
                If Tipo = 0 Then
                    Me.cboPilotoTercero.Value = oeGuiaTransportista.IdPilotoTercero

                    indGuiaT = oeGuiaTransportista.IndGuiaTercero
                    With oeGuiaTransportista
                        txtSerie.Text = .Serie
                        txtNumero.Text = .Numero
                        txtGuiaTransportista.Text = .Serie & "-" & .Numero
                        'fecEmision.Value = oeGuiaTransportista.Fecha
                        fecEmision.Value = griLista.ActiveRow.Cells("LlegadaOrigen").Value
                        verConfirmado.Checked = .IndGrtConfirmada
                        IdRemitente = .IdRemitente
                        IdDestinatario = .IdDestinatario
                        IdPuntoPartida = .IdDireccionLugarPartida
                        IdPuntoLlegada = .IdDireccionLugarLlegada
                        verDocumentos.Checked = .IndDocumentos
                        'piloto tecero


                        cboRemitente.Value = IdRemitente
                        cboDestinatario.Value = IdDestinatario
                        If IdRemitente = "" Then IdRemitente = "0"
                        oeDireccionEmpresa = New e_Combo
                        oeDireccionEmpresa.Nombre = "DireccionEmpresa"
                        oeDireccionEmpresa.Id = IdRemitente
                        LlenarComboMaestro(cboPuntoPartida, olDireccionEmpresa.Listar(oeDireccionEmpresa), 0)
                        If IdDestinatario = "" Then IdDestinatario = "0"
                        oeDireccionEmpresa = New e_Combo
                        oeDireccionEmpresa.Nombre = "DireccionEmpresa"
                        oeDireccionEmpresa.Id = IdDestinatario
                        LlenarComboMaestro(cboPuntoLlegada, olDireccionEmpresa.Listar(oeDireccionEmpresa), 0)
                        If oeGuiaTransportista.IdSubContrata = "" Then
                            cboSubContrata.Text = "NINGUNO  ,"
                        Else
                            cboSubContrata.Value = .IdSubContrata
                        End If
                        txtIdGrt.Text = .Id
                        txtSubSerie.Text = .SubSerie
                        txtSubNumero.Text = .SubNumero
                        cboMotivoTraslado.Value = .IdMotivoDocumentoTraslado
                        txtGlosa.Text = .Glosa
                        txtGrtPT.Text = .PesoToneladas
                        txtIdOperacionDetalle.Text = .IdOperacionDetalle
                        verConfirmado.Checked = .IndGrtConfirmada
                        verDoctsPerdido.Checked = .IndGrtPerdido
                        Me.chkGuiaTercero.Checked = .IndGuiaTercero
                    End With
                End If
                'Viaje
                With oeViaje
                    txtIdSeguimiento.Text = .Id
                    txtIdOperacion.Text = .IdOperacion
                    txtCodigoOperacion.Text = .Operacion
                    txtCodigoViaje.Text = .Codigo
                    txtViajeTracto.Text = .Tracto
                    txtViajeCarreta.Text = .Carreta
                    fecViaje.Value = .Fecha
                    txtViajeOrigen.Text = .Origen
                    txtViajeDestino.Text = .Destino
                    txtViajePiloto.Text = .Piloto
                    txtViajeCopiloto.Text = .Copiloto
                    txtViajeEscala.Text = .Escala
                    cboActividadNegocio.Value = .Tesoreria
                End With

                oeOperacionDetalle = New e_OperacionDetalle
                oeOperacionDetalle.IdOperacion = oeViaje.IdOperacion
                oeOperacionDetalle.TipoOperacion = "G"
                griViajeDetalle.DataSource = olOperacion.ListarOperacionDetalle(oeOperacionDetalle)

                IdGuiaTransportista = txtIdGrt.Text
                If IdGuiaTransportista = "" Then IdGuiaTransportista = "0"
                oeGuiaRemitente = New e_GuiaRemitente
                oeGuiaRemitente.IdGuiaTransportista = IdGuiaTransportista
                oeGuiaRemitente.Activo = True
                griGuiaRemitente.DataSource = olGuiaRemitente.Listar(oeGuiaRemitente)

                oeGuiaTransportistaInterrumpida = New e_GuiaTransportistaInterrumpida
                oeGuiaTransportistaInterrumpida.IdGuiaTransportista = IdGuiaTransportista
                oeGuiaTransportistaInterrumpida.Activo = True
                griViajeInterrumpido.DataSource = olGuiaTransportistaInterrumpida.Listar(oeGuiaTransportistaInterrumpida)

                oeGuiaTransportista = New e_GuiaTransportista
                oeGuiaTransportista.TipoOperacion = "1"
                oeGuiaTransportista.IdViaje = txtIdViaje.Text
                oeGuiaTransportista.Activo = True
                griGrtAsociadasViaje.DataSource = olGuiaTransportista.Listar(oeGuiaTransportista)

                oeGuiaTransportista = New e_GuiaTransportista
                oeGuiaTransportista.TipoOperacion = "1"
                oeGuiaTransportista.IdOperacion = txtIdOperacion.Text
                oeGuiaTransportista.Activo = True
                griGrtAsociadasOperacion.DataSource = olGuiaTransportista.Listar(oeGuiaTransportista)
                tabDetalleGrt.Tabs(0).Selected = True

                If Tipo = 1 Then
                    oeGuiaTransportista = New e_GuiaTransportista
                    oeGuiaTransportista.IdViaje = txtIdViaje.Text
                    oeGuiaTransportista.Activo = True
                    oeGuiaTransportista.Id = "1"
                    griGuiaTransportistaViaje.DataSource = olGuiaTransportista.Listar(oeGuiaTransportista)
                    oeGuiaRemitente = New e_GuiaRemitente
                    oeGuiaRemitente.IdViaje = txtIdViaje.Text
                    oeGuiaRemitente.Activo = True
                    griGuiaRemitenteViaje.DataSource = olGuiaRemitente.Listar(oeGuiaRemitente)
                    If griGuiaTransportistaViaje.Rows.Count > 0 Then
                        cboRemitente.Value = griGuiaTransportistaViaje.Rows(0).Cells("IdRemitente").Value
                        cboDestinatario.Value = griGuiaTransportistaViaje.Rows(0).Cells("IdDestinatario").Value
                    End If                    
                End If
                If txtIdOperacionDetalle.Text = "" Then
                    For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griViajeDetalle.Rows
                        txtIdOperacionDetalle.Text = Fila.Cells("Id").Value
                        Exit For
                    Next
                End If

                'llenar listra

                Dim oeViajes = New e_Viaje
                With oeViajes
                    .TipoOperacion = "T"
                    ' .ViajeVacio = verViajeVacio.Checked
                    '   .FechaDesde = fecDesde.Value.ToString
                    '   .FechaHasta = fecHasta.Value.ToString
                    '   .ViajeRetorno = verViajeRetorno.Checked
                    .IdOperacion = oeViaje.IdOperacion
                    ' .UsuarioCreacion = cboUsuario.Value
                    ' .Zona = cboZona.Value
                    '   .Centro = cboCentro.Value

                End With
                Dim listaTerceros As List(Of e_Viaje) = olOperacion.ListarViaje(oeViajes)
                Dim listaTercerosAdd As List(Of e_Viaje) = olOperacion.ListarViaje(oeViajes)
                griListaTerceros.DataSource = listaTerceros
                '   listaTercerosAdd = listaTerceros
                '   If oeGuiaTransportista.Serie <> "" Then
                If listaTerceros.Count > 0 Then
                    Me.chkGuiaTercero.Visible = True
                    codigoTercero = listaTerceros.Item(0).IdTercero
                    If indGuiaT Then
                        'cambios
                        codigoTercero = listaTerceros.Item(0).IdTercero
                        Dim ListTercero = New List(Of e_Combo)
                        oeCombo = New e_Combo
                        oeCombo.Nombre = "Transportista"
                        ListTercero.AddRange(olCombo.Listar(oeCombo).Where(Function(Item) Item.Id = codigoTercero).ToList.OrderBy(Function(Item) Item.Nombre).ToList)
                        LlenarComboMaestro(cboTransportista, ListTercero, 1)
                        Me.cboTransportista.Value = codigoTercero
                        Me.chkGuiaTercero.Checked = True
                        chkGuiaTercero_CheckedChanged(Nothing, Nothing)
                    Else
                        Dim ListTercero = New List(Of e_Combo)
                        oeCombo = New e_Combo
                        oeCombo.Nombre = "Transportista"
                        ListTercero.AddRange(olCombo.Listar(oeCombo).Where(Function(Item) Item.Id = "1CH000004444").ToList.OrderBy(Function(Item) Item.Nombre).ToList)
                        LlenarComboMaestro(cboTransportista, ListTercero, 0)
                        Me.chkGuiaTercero.Checked = False
                        chkGuiaTercero_CheckedChanged(Nothing, Nothing)
                    End If
                Else
                    Dim ListTercero = New List(Of e_Combo)
                    oeCombo = New e_Combo
                    oeCombo.Nombre = "Transportista"
                    ListTercero.AddRange(olCombo.Listar(oeCombo).Where(Function(Item) Item.Id = "1CH000004444").ToList.OrderBy(Function(Item) Item.Nombre).ToList)
                    LlenarComboMaestro(cboTransportista, ListTercero, 0)
                    Me.chkGuiaTercero.Visible = False
                    Me.chkGuiaTercero.Checked = False
                End If
                '   Else
                'If listaTerceros.Count > 0 Then
                '    codigoTercero = listaTerceros.Item(0).IdTercero
                '    Dim ListTercero = New List(Of e_Combo)
                '    oeCombo = New e_Combo
                '    oeCombo.Nombre = "Transportista"
                '    ListTercero.AddRange(olCombo.Listar(oeCombo).Where(Function(Item) Item.Id = "1CH000004444").ToList.OrderBy(Function(Item) Item.Nombre).ToList)
                '    LlenarComboMaestro(cboTransportista, ListTercero, 1)
                '    Me.chkGuiaTercero.Visible = True
                '    Me.chkGuiaTercero.Visible = True
                '    Me.chkGuiaTercero.Checked = True
                '    Me.cboTransportista.Value = codigoTercero
                'End If
                '    End If
                '     LlenarComboMaestro(cboTransportista, listaTercerosAdd, 1)
            End If
            MostrarTabs(1, ficGuias, 1)
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Private Function ValidaCamposCabecera() As Boolean
        Try
            Dim Cantidad As Double = 0
            Dim Carga As String = "VIAJE"
            Dim Porcentaje As Integer = 0
            Dim FleteUnitarioCarga As Double = 0
            Dim FleteUnitarioViaje As Double = 0
            Dim ClienteCarga As String = ""

            For I As Integer = 0 To griViajeDetalle.Rows.Count - 1
                With griViajeDetalle.Rows(I)
                    If .Cells("Carga").Text = "VIAJE" Then
                        Cantidad = .Cells("Cantidad").Value
                    Else
                        Cantidad = .Cells("Cantidad").Value
                    End If
                    If .Cells("Cliente").Text = "OTROS" And .Cells("ClienteFinal").Text = "OTROS" Then
                        If MessageBox.Show("Si cliente es OTROS, deberia ingresar CLIENTE FINAL diferente. ¿Desea continuar?", "Información del Sistema",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                            Exit Function
                            Return False
                        End If
                        '    mensajeEmergente.Confirmacion("Si cliente es OTROS, deberia ingresar CLIENTE FINAL diferente. ¿Desea continuar?", True)
                    End If
                    Carga = .Cells("Carga").Text
                    ClienteCarga = .Cells("Cliente").Text
                    If Carga = "VIAJE" Then
                        If Cantidad > 1 Then
                            tabDetalleGrt.Tabs(0).Selected = True
                            Throw New Exception("Cantidad no puede Superar el Maximo (1) con su Tipo Carga --> " & Carga)
                        End If
                        FleteUnitarioCarga += .Cells("FleteUnitario").Value
                    Else
                        If Carga = "TONELADA" Then
                            If Cantidad > 40 Then
                                tabDetalleGrt.Tabs(0).Selected = True
                                Throw New Exception("Cantidad no puede Superar el Maximo (40) con su Tipo Carga --> " & Carga)
                            End If
                        Else
                            If Carga = "METRO CUBICO" Then
                                If Cantidad > 120 Then
                                    tabDetalleGrt.Tabs(0).Selected = True
                                    Throw New Exception("Cantidad no puede Superar el Maximo (120) con su Tipo Carga --> " & Carga)
                                End If
                            End If
                        End If
                    End If
                End With
            Next
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidaGRTGlosa() As Boolean
        Dim Cliente As String = ""
        For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griViajeDetalle.Rows
            Cliente = Fila.Cells("Cliente").Text
        Next
        If Cliente = "ALICORP SAA" Then
            If txtGlosa.Text = "" Then
                txtGlosa.Focus()
                Throw New Exception("Ingrese Nª Transporte para este cliente : " & Cliente)
            End If
        End If
        Return True
    End Function

    Private Function GuardarGuia() As Boolean
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If ValidaCamposCabecera() Then
                If Tipo = 0 Then
                    If ValidaGuiaTransportista(txtIdGrt.Text.Trim, txtSerie.Text.Trim, txtNumero.Text.Trim, IIf(chkGuiaTercero.Checked, "1", "0")) Then
                        If Operacion = "Editar" Then
                            If griGuiaRemitente.Rows.Count > 0 Then
                                'I = Insertar y Actualizar
                                ValidaGRTGlosa()
                                oeGuiaTransportista = New e_GuiaTransportista
                                With oeGuiaTransportista
                                    .TipoOperacion = "I"
                                    .Id = txtIdGrt.Text
                                    .Serie = txtSerie.Text
                                    .Numero = txtNumero.Text
                                    .IdSeguimiento = txtIdSeguimiento.Text
                                    .IdRemitente = cboRemitente.Value
                                    .IdDireccionLugarPartida = cboPuntoPartida.Value
                                    .IdDestinatario = cboDestinatario.Value
                                    .IdDireccionLugarLlegada = cboPuntoLlegada.Value
                                    .IdMotivoDocumentoTraslado = cboMotivoTraslado.Value
                                    .Glosa = txtGlosa.Text
                                    .Fecha = fecEmision.Value
                                    .UsuarioCreacion = gUsuarioSGI.Id
                                    .IdSubContrata = cboSubContrata.Value
                                    .SubSerie = txtSubSerie.Text
                                    .SubNumero = txtSubNumero.Text

                                    .IdOperacionDetalle = txtIdOperacionDetalle.Text
                                    .PesoToneladas = txtGrtPT.Text
                                    .IndGrtConfirmada = verConfirmado.Checked
                                    .IndDocumentos = verDocumentos.Checked
                                    .Incidencia = ""
                                    .Cantidad = txtGrtCantidad.Text
                                    .OperacionDetalle = griViajeDetalle.DataSource
                                    .GuiaRemitente = griGuiaRemitente.DataSource
                                    .GuiaTransportistaInterrumpida = griViajeInterrumpido.DataSource
                                    .IndGuiaTercero = Me.chkGuiaTercero.Checked
                                End With
                            Else
                                Throw New Exception("Debe ingresar GUIAS REMITENTES")
                            End If
                        Else
                            'A = Anulado
                            oeGuiaTransportista = New e_GuiaTransportista
                            oeGuiaTransportista.TipoOperacion = "A"
                            oeGuiaTransportista.GuiaTransportista = griGrtAnuladas.DataSource
                        End If
                        oeGuiaTransportista.IdPilotoTercero = Me.cboPilotoTercero.Value
                        If olGuiaTransportista.Guardar(oeGuiaTransportista) Then
                            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                            'ControlRangoFechaInicializa()
                            'Consultar(True)
                            Operacion = "Inicializa"
                            If tabLista.Tabs(0).Selected Then
                                If griLista.Rows.Count > 0 Then
                                    Tipo = 0
                                    ControlBoton(1, 0, 1, 0, 0, 1, 1, 1, 1)
                                    griLista.ActiveRow.CellAppearance.BackColor = Me.ColorBloque.Color
                                Else
                                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                                End If
                            Else
                                If tabLista.Tabs(1).Selected Then
                                    If griListaAnuladas.Rows.Count > 0 Then
                                        ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                                    Else
                                        ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                                    End If
                                End If
                            End If
                        End If
                    End If
                Else
                    oeSeguimiento = New e_Seguimiento
                    FiltrarLista()
                    With oeSeguimiento
                        .TipoOperacion = "G"
                        .UsuarioCreacion = gUsuarioSGI.Id

                        .GuiaTransportista = griGuiaTransportistaViaje.DataSource
                        .GuiaRemitente = griGuiaRemitenteViaje.DataSource
                        .GuiaTransportistaInterrumpida = griViajeInterrumpido.DataSource
                        .OperacionDetalle = griViajeDetalle.DataSource
                        .oeListaBitacora = ListaBitacora
                        'Validación especial para evitar que el flete sea cero 0

                        Dim fletes0 As Integer = 0
                        For Each operacion As e_OperacionDetalle In .OperacionDetalle
                            If operacion.Flete = 0 Then
                                fletes0 = fletes0 + 1
                            End If
                        Next

                        If fletes0 > 0 Then
                            If MessageBox.Show("Está intentando grabar " & fletes0.ToString & " fletes en cero (0.00)" & Environment.NewLine & "¿Está Ud., Seguro de que estos datos son correctos?", _
        "Control de Fletes", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                                Exit Function
                            End If
                        End If
                    End With

                    If olSeguimiento.Guardar(oeSeguimiento) Then
                        mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                        'ControlRangoFechaInicializa()
                        'Consultar(True)
                        Operacion = "Inicializa"
                        If tabLista.Tabs(0).Selected Then
                            If griLista.Rows.Count > 0 Then
                                Tipo = 0
                                ControlBoton(1, 0, 1, 0, 0, 1, 1, 1, 1)
                                griLista.ActiveRow.CellAppearance.BackColor = Me.ColorBloque.Color
                            Else
                                ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                            End If
                        Else
                            If tabLista.Tabs(1).Selected Then
                                If griListaAnuladas.Rows.Count > 0 Then
                                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                                Else
                                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                                End If
                            End If
                        End If
                    End If
                End If
            Else
                Return False
            End If

            ugb_Espera.Visible = False
            Return True

        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Function

    Private Function EliminarGuiaTransportista(ByVal Grilla As Infragistics.Win.UltraWinGrid.UltraGrid) As Boolean
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            With Grilla
                If ValidarGrilla(Grilla, "Guia Transportista") Then
                    If RTrim(Grilla.ActiveRow.Cells("Id").Value.ToString).Length > 1 Then
                        oeGuiaTransportista = New e_GuiaTransportista
                        oeGuiaTransportista.Id = Grilla.ActiveRow.Cells("Id").Value
                        oeGuiaTransportista = olGuiaTransportista.Obtener(oeGuiaTransportista)
                        If oeGuiaTransportista.Activo Then
                            If oeGuiaTransportista.IndFacturado = 0 Then
                                If MessageBox.Show("Esta seguro de eliminar la Guia Transportista: " & _
                                oeGuiaTransportista.Serie & "-" & oeGuiaTransportista.Numero & " ?", _
                                                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                    oeGuiaTransportista.TipoOperacion = "E"
                                    oeGuiaTransportista.UsuarioCreacion = gUsuarioSGI.Id
                                    olGuiaTransportista.Eliminar(oeGuiaTransportista)
                                    'Consultar(True)
                                Else
                                    Return False
                                    Exit Function
                                End If
                            Else
                                Throw New Exception(oeGuiaTransportista.Serie & "-" & oeGuiaTransportista.Numero & " Ya fue Facturado")
                            End If
                        Else
                            Throw New Exception(oeGuiaTransportista.Serie & "-" & oeGuiaTransportista.Numero & " Ya fue eliminado")
                        End If
                    Else
                        Throw New Exception("Esta opcion no es valida para este viaje ")
                    End If
                End If
            End With
            MyBase.Eliminar()
            ugb_Espera.Visible = False
            Return True
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Function

    Private Function ValidaGuiaTransportista(ByVal IdGuiaTransportista As String, _
                                          ByVal Serie As String, _
                                          ByVal Numero As String, _
                                                Optional ByVal IndGuiaTercero As Boolean = False) As Boolean
        Try
            If Operacion <> "Nuevo" Then
                ' If IdGuiaTransportista = "" Then
                If Serie.Trim = "" And Numero.Trim = "" Then
                    Throw New Exception("Debe ingresar SERIE y NUMERO de guia")
                Else
                    ' If griGuiaRemitente.Rows.Count = 0 Then
                    'Throw New Exception("Debe agregar GUIA REMITENTE")
                    ' Else
                    oeGuiaTransportista = New e_GuiaTransportista
                    oeGuiaTransportista.Serie = Serie
                    oeGuiaTransportista.Numero = Numero
                    oeGuiaTransportista.IndGuiaTercero = IndGuiaTercero
                    oeGuiaTransportista.Glosa = IIf(Me.cboTransportista.Value <> "1CH000004444", Me.cboTransportista.Value, "")
                    oeGuiaTransportista = olGuiaTransportista.Obtener(oeGuiaTransportista)
                    If oeGuiaTransportista.Serie <> "" And oeGuiaTransportista.Id <> IdGuiaTransportista Then
                        Throw New Exception(oeGuiaTransportista.Serie & "-" & oeGuiaTransportista.Numero & " GRT ya fue Ingresado en Viaje: " & oeGuiaTransportista.Viaje & IIf(IndGuiaTercero = True, " Se uso LA GUIA DE TERCERO", "") &
                                             " Fecha: " & oeGuiaTransportista.Fecha)
                    End If
                End If
                ' End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidaGuiaTransportistaAnulada(ByVal IdGuiaTransportista As String, _
                                      ByVal Serie As String, _
                                      ByVal Numero As String) As Boolean
        Try
            If IdGuiaTransportista = "" Then
                oeGuiaTransportista = New e_GuiaTransportista
                oeGuiaTransportista.TipoOperacion = "0"
                oeGuiaTransportista.Serie = Serie
                oeGuiaTransportista.Numero = Numero
                oeGuiaTransportista.IndGuiaTercero = Me.chkGuiaTercero.Checked
                oeGuiaTransportista.Glosa = IIf(Me.cboTransportista.Value <> "1CH000004444", Me.cboTransportista.Value, "")
                oeGuiaTransportista = olGuiaTransportista.Obtener(oeGuiaTransportista)
                If oeGuiaTransportista.Serie <> "" Then
                    Throw New Exception(oeGuiaTransportista.Serie & "-" & oeGuiaTransportista.Numero & " fue Anulado en esta fecha: " & oeGuiaTransportista.Fecha)
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidaGuiaRemitente(ByVal Remitente As String, _
                                         ByVal Serie As String, _
                                         ByVal Numero As String, _
                                         ByVal Grid As UltraGrid) As Boolean
        Try
            oeGuiaRemitente = New e_GuiaRemitente
            oeGuiaRemitente.IdRemitente = Remitente
            oeGuiaRemitente.Serie = Serie
            oeGuiaRemitente.Numero = Numero
            oeGuiaRemitente = olGuiaRemitente.Obtener(oeGuiaRemitente)
            If oeGuiaRemitente.Serie <> "" Then
                Throw New Exception(oeGuiaRemitente.Serie & "-" & oeGuiaRemitente.Numero & " GRR fue Ingresado en Viaje: " & oeGuiaRemitente.Viaje)
            End If
            If Grid.Rows.Count > 0 Then
                For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In Grid.Rows
                    If FormatoDocumento(fila.Cells("Serie").Value, 4) + "-" + FormatoDocumento(fila.Cells("Numero").Value, 10) = Serie + "-" + Numero Then
                        Throw New Exception(Serie & "-" & Numero & " GRR fue Ingresado en Viaje: " & txtCodigoViaje.Text)
                    End If
                Next
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Function ValidarGuiaRemitente(ByVal txt_controlInicial As ISL.Controles.Texto, ByVal txt_controlFinal As ISL.Controles.Texto) As Boolean
        Try
            If txt_controlInicial.Text.Trim.Length = 0 Or Not txt_controlInicial.Text.Contains("-") Then
                txt_controlInicial.Focus()
                Throw New Exception("Ingrese Correctamente Guía Remisión Remitente, Separando Serie y Numero por un Guión (-): (0000-0000000000)")
            End If
            If txt_controlFinal.Text.Trim.Length = 0 Or Not txt_controlFinal.Text.Contains("-") Then
                txt_controlFinal.Focus()
                Throw New Exception("Ingrese Correctamente Guía Remisión Remitente Rango, Separando Serie y Numero por un Guión (-): (0000-0000000000)")
            End If
            Dim ls_NroSerieInicial As String = "", _
                    ls_NroSerieFinal As String = "", _
                    ls_NroDocInicial As String = "", _
                    ls_NroDocFinal As String = ""

            Dim o_DocumentoInicial() As String = txt_controlInicial.Text.Split("-")
            ls_NroSerieInicial = o_DocumentoInicial(0).ToString.Trim
            ls_NroDocInicial = o_DocumentoInicial(1).ToString.Trim

            Dim o_DocumentoFinal() As String = txt_controlFinal.Text.Split("-")
            ls_NroSerieFinal = o_DocumentoFinal(0).ToString.Trim
            ls_NroDocFinal = o_DocumentoFinal(1).ToString.Trim

            If ls_NroSerieInicial <> ls_NroSerieFinal Then
                txt_controlFinal.Focus()
                Throw New Exception("Nº Serie Inicial y Nº Serie Final deben Ser iguales")
            End If

            If CDbl(ls_NroDocInicial) > CDbl(ls_NroDocFinal) Then
                txt_controlFinal.Focus()
                Throw New Exception("Nº Documento Inicial debe ser Menor a Nº Documento Final")
            End If

            If ls_NroSerieInicial.Length > 4 Then
                txt_controlInicial.Focus()
                Throw New Exception("Nº Serie debe ser Menor o Igual a 4 Digitos, Separando Serie y Numero por un Guión (-): (0000-0000000000)")
            End If

            If ls_NroSerieFinal.Length > 4 Then
                txt_controlFinal.Focus()
                Throw New Exception("Nº Serie debe ser Menor o Igual a 4 Digitos, Separando Serie y Numero por un Guión (-): (0000-0000000000)")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub AgregarGuiasRemitente()
        Try
            If ValidaCamposDetalle() Then
                Dim ls_Serie As String = "", _
                                    ls_Numero As String = ""
                Dim GuiaRemitenteCodigo() As String = txtGrr.Text.Split("-")
                ls_Serie = GuiaRemitenteCodigo(0).ToString.Trim
                ls_Numero = GuiaRemitenteCodigo(1).ToString.Trim
                oeSeguimiento.GuiaRemitente = griGuiaRemitente.DataSource
                With oeGuiaRemitente
                    .Id = ""
                    .Serie = ls_Serie
                    .Numero = ls_Numero
                    .IdGuiaTransportista = txtIdGrt.Text
                    .GuiaTransportista = txtSerie.Text + "-" + txtNumero.Text
                    .Fecha = fecEmisionGrr.Value
                    .Activo = True
                    .Viaje = txtCodigoViaje.Text
                    .Glosa = txtRemitenteGlosa.Text
                End With
                oeSeguimiento.GuiaRemitente.Add(oeGuiaRemitente)
                griGuiaRemitente.DataBind()
                oeGuiaRemitente = New e_GuiaRemitente
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarGuiasRemitenteViaje()
        Try
            If ValidaCamposDetalle() Then
                Dim ls_Serie As String = "", _
                                    ls_Numero As String = ""
                Dim GuiaRemitenteCodigo() As String = txtGrrViaje.Text.Split("-")
                ls_Serie = GuiaRemitenteCodigo(0).ToString.Trim
                ls_Numero = GuiaRemitenteCodigo(1).ToString.Trim
                oeSeguimiento.GuiaRemitente = griGuiaRemitenteViaje.DataSource
                With oeGuiaRemitente
                    .Id = ""
                    .Serie = ls_Serie
                    .Numero = ls_Numero
                    .IdGuiaTransportista = txtIdGrt.Text
                    .GuiaTransportista = txtSerie.Text + "-" + txtNumero.Text
                    .Fecha = fecEmisionGrrViaje.Value
                    .Activo = True
                    .Viaje = txtCodigoViaje.Text
                    .Glosa = txtGlosaRemitente.Text
                End With
                oeSeguimiento.GuiaRemitente.Add(oeGuiaRemitente)
                griGuiaRemitenteViaje.DataBind()
                oeGuiaRemitente = New e_GuiaRemitente
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ValidaCamposDetalle() As Boolean
        Try
            If Tipo <> 1 Then
                ValidarCombo(cboRemitente, "Remitente")
                ValidarCombo(cboDestinatario, "Destinatario")
                If Operacion <> "Nuevo" Then
                    ValidarCombo(cboPuntoPartida, "Punto Partida")
                    ValidarCombo(cboPuntoLlegada, "Punto Llegada")
                End If
                If Operacion = "Nuevo" Then
                    If txtRangoFinalNumeroAnulado.Text <> "" Then
                        ValidarGrtAnular(txtNumero, txtRangoFinalNumeroAnulado)
                    End If                    
                    ValidaGuiaTransportistaAnulada(txtIdGrt.Text, txtSerie.Text, txtNumero.Text)
                End If
            End If
            Return True
        Catch ex As Exception
            EnfocarDetalle(ex.Message)
            Throw ex
        End Try
    End Function

    Function ValidarGrtAnular(ByVal txt_controlInicial As UltraWinMaskedEdit.UltraMaskedEdit, ByVal txt_controlFinal As UltraWinMaskedEdit.UltraMaskedEdit) As Boolean
        Try
            Dim ls_NroDocInicial As String = "", _
                    ls_NroDocFinal As String = ""
            ls_NroDocInicial = txt_controlInicial.Text
            ls_NroDocFinal = txt_controlFinal.Text
            If CDbl(ls_NroDocInicial) > CDbl(ls_NroDocFinal) Then
                txt_controlFinal.Focus()
                Throw New Exception("Nº Documento Inicial debe ser Menor a Nº Documento Final")
            End If
            If CDbl(ls_NroDocFinal) - CDbl(ls_NroDocInicial) > 50 Then
                txt_controlInicial.Focus()
                Throw New Exception("El rango ingresado de GRT a Anular no corresponde a un Talonario")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub EnfocarDetalle(ByVal excepcion As String)
        Select Case excepcion
            Case excepcion.Contains("Remitente")
                cboRemitente.Focus()
            Case excepcion.Contains("Destinatario")
                cboDestinatario.Focus()
            Case excepcion.Contains("Punto Partida")
                cboPuntoPartida.Focus()
            Case excepcion.Contains("Punto Llegada")
                cboPuntoLlegada.Focus()
        End Select
    End Sub

    Private Sub AgregarGrrRango(ByVal txt_controlGuiaInicial As ISL.Controles.Texto, _
                                ByVal txt_controlguiaFinal As ISL.Controles.Texto)
        Try
            Dim ls_NroSerieInicial As String = "", _
                ls_NroSerieFinal As String = "", _
                ls_NroDocInicial As String = "", _
                ls_NroDocFinal As String = "", _
                Guia As Integer = 0
            Dim o_DocumentoInicial() As String = txt_controlGuiaInicial.Text.Split("-")
            ls_NroSerieInicial = o_DocumentoInicial(0).ToString.Trim
            ls_NroDocInicial = o_DocumentoInicial(1).ToString.Trim

            Dim o_DocumentoFinal() As String = txt_controlguiaFinal.Text.Split("-")
            ls_NroSerieFinal = o_DocumentoFinal(0).ToString.Trim
            ls_NroDocFinal = o_DocumentoFinal(1).ToString.Trim

            Dim ln_TotalGuias As Integer = CDbl(ls_NroDocFinal) - CDbl(ls_NroDocInicial)
            Dim i As Integer

            Dim ls_NroSerie As String = ls_NroSerieInicial
            Dim ls_NroDocumento As String = ""
            For i = 0 To ln_TotalGuias
                ls_NroDocumento = (CDbl(ls_NroDocInicial) + i).ToString
                If griGuiaRemitente.Rows.Count > 0 Then
                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griGuiaRemitente.Rows
                        If FormatoDocumento(fila.Cells("Serie").Value, 4) + "-" + FormatoDocumento(fila.Cells("Numero").Value, 10) = ls_NroSerie + "-" + FormatoDocumento(ls_NroDocumento, 10) Then
                            Guia = 1
                            Exit For
                        End If
                    Next
                End If
                If Guia = 0 Then
                    oeSeguimiento.GuiaRemitente = griGuiaRemitente.DataSource
                    With oeGuiaRemitente
                        .Id = ""
                        .Serie = ls_NroSerie
                        .Numero = FormatoDocumento(ls_NroDocumento, 10)
                        .IdGuiaTransportista = txtIdGrt.Text
                        .GuiaTransportista = txtSerie.Text + "-" + txtNumero.Text
                        .Fecha = fecEmisionGrr.Value
                        .Activo = True
                        .Viaje = txtCodigoViaje.Text
                        .Glosa = txtRemitenteGlosa.Text
                    End With
                    oeSeguimiento.GuiaRemitente.Add(oeGuiaRemitente)
                    griGuiaRemitente.DataBind()
                    oeGuiaRemitente = New e_GuiaRemitente
                End If
                Guia = 0
            Next
            o_DocumentoInicial = Nothing
            o_DocumentoFinal = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarGrrRangoViaje(ByVal txt_controlGuiaInicial As ISL.Controles.Texto, _
                                            ByVal txt_controlguiaFinal As ISL.Controles.Texto)
        Try
            Dim ls_NroSerieInicial As String = "", _
                ls_NroSerieFinal As String = "", _
                ls_NroDocInicial As String = "", _
                ls_NroDocFinal As String = "", _
                GuiaViaje As Integer = 0

            Dim o_DocumentoInicial() As String = txt_controlGuiaInicial.Text.Split("-")
            ls_NroSerieInicial = o_DocumentoInicial(0).ToString.Trim
            ls_NroDocInicial = o_DocumentoInicial(1).ToString.Trim

            Dim o_DocumentoFinal() As String = txt_controlguiaFinal.Text.Split("-")
            ls_NroSerieFinal = o_DocumentoFinal(0).ToString.Trim
            ls_NroDocFinal = o_DocumentoFinal(1).ToString.Trim

            Dim ln_TotalGuias As Integer = CDbl(ls_NroDocFinal) - CDbl(ls_NroDocInicial)
            Dim i As Integer

            Dim ls_NroSerie As String = ls_NroSerieInicial
            Dim ls_NroDocumento As String = ""
            For i = 0 To ln_TotalGuias
                ls_NroDocumento = (CDbl(ls_NroDocInicial) + i).ToString
                If griGuiaRemitenteViaje.Rows.Count > 0 Then
                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griGuiaRemitenteViaje.Rows
                        If FormatoDocumento(fila.Cells("Serie").Value, 4) + "-" + FormatoDocumento(fila.Cells("Numero").Value, 10) = ls_NroSerie + "-" + FormatoDocumento(ls_NroDocumento, 10) Then
                            GuiaViaje = 1
                            Exit For
                        End If
                    Next
                End If
                If GuiaViaje = 0 Then
                    oeSeguimiento.GuiaRemitente = griGuiaRemitenteViaje.DataSource
                    With oeGuiaRemitente
                        .Id = ""
                        .Serie = ls_NroSerie
                        .Numero = FormatoDocumento(ls_NroDocumento, 10)
                        .IdGuiaTransportista = txtIdGrt.Text
                        .GuiaTransportista = txtSerie.Text + "-" + txtNumero.Text
                        .Fecha = fecEmisionGrrViaje.Value
                        .Activo = True
                        .Viaje = txtCodigoViaje.Text
                        .Glosa = txtGlosaRemitente.Text
                    End With
                    oeSeguimiento.GuiaRemitente.Add(oeGuiaRemitente)
                    griGuiaRemitenteViaje.DataBind()
                    oeGuiaRemitente = New e_GuiaRemitente
                End If
                GuiaViaje = 0
            Next
            o_DocumentoInicial = Nothing
            o_DocumentoFinal = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub FleteDetalleGrilla()
        Try
            With oeDemandaDetalle
                With griViajeDetalle.ActiveRow
                    Select Case .Cells("Carga").Text
                        'Case "VIAJE"
                        '    If Not .Cells("Cantidad").Value.ToString = "" Or Not IsNumeric(.Cells("Cantidad").Value.ToString) Then
                        '        oeDemandaDetalle.Cantidad = CDbl(.Cells("Cantidad").Value)
                        '    Else
                        '        .Cells("Cantidad").Value = 0
                        '    End If
                        Case "TONELADA"
                            If Not .Cells("PesoToneladasDescarga").Value.ToString = "" Or Not IsNumeric(.Cells("PesoToneladasDescarga").Value.ToString) Then
                                oeDemandaDetalle.Cantidad = CDbl(.Cells("PesoToneladasDescarga").Value)
                            Else
                                .Cells("PesoToneladasDescarga").Value = 0
                            End If
                            If .Cells("Seleccion").Value Then
                                .Cells("IndPesoTnDescarga").Value = 1
                            Else
                                .Cells("IndPesoTnDescarga").Value = 0
                            End If
                        Case "BOLSA"
                            If Not .Cells("Cantidad").Value.ToString = "" Or Not IsNumeric(.Cells("Cantidad").Value.ToString) Then
                                oeDemandaDetalle.Cantidad = CDbl(.Cells("Cantidad").Value)
                            Else
                                .Cells("Cantidad").Value = 0
                            End If
                            If .Cells("Seleccion").Value Then
                                .Cells("IndPesoTnDescarga").Value = 1
                            Else
                                .Cells("IndPesoTnDescarga").Value = 0
                            End If
                            'Case "PARIHUELA"
                            '    If Not .Cells("Cantidad").Value.ToString = "" Or Not IsNumeric(.Cells("Cantidad").Value.ToString) Then
                            '        oeDemandaDetalle.Cantidad = CDbl(.Cells("Cantidad").Value)
                            '    Else
                            '        .Cells("Cantidad").Value = 0
                            '    End If
                            'Case "METRO CUBICO"
                            '    If Not .Cells("Cantidad").Value.ToString = "" Or Not IsNumeric(.Cells("Cantidad").Value.ToString) Then
                            '        oeDemandaDetalle.Cantidad = CDbl(.Cells("Cantidad").Value)
                            '    Else
                            '        .Cells("Cantidad").Value = 0
                            '    End If
                        Case "KILOMETRAJE"
                            If Not .Cells("Cantidad").Value.ToString = "" Or Not IsNumeric(.Cells("Cantidad").Value.ToString) Then
                                oeDemandaDetalle.Cantidad = CDbl(.Cells("Cantidad").Value)
                            Else
                                .Cells("Cantidad").Value = 0
                            End If
                            If .Cells("Seleccion").Value Then
                                .Cells("IndPesoTnDescarga").Value = 1
                            Else
                                .Cells("IndPesoTnDescarga").Value = 0
                            End If
                        Case Else
                            If Not .Cells("Cantidad").Value.ToString = "" Or Not IsNumeric(.Cells("Cantidad").Value.ToString) Then
                                oeDemandaDetalle.Cantidad = CDbl(.Cells("Cantidad").Value)
                            Else
                                .Cells("Cantidad").Value = 0
                            End If
                    End Select

                    'If .Cells("Carga").Text = "TONELADA" Or .Cells("Carga").Text = "BOLSA" Then
                    '    If Not .Cells("PesoToneladasDescarga").Value.ToString = "" Or Not IsNumeric(.Cells("PesoToneladasDescarga").Value.ToString) Then
                    '        oeDemandaDetalle.Cantidad = CDbl(.Cells("PesoToneladasDescarga").Value)
                    '    Else
                    '        .Cells("PesoToneladasDescarga").Value = 0
                    '    End If
                    '    If .Cells("Seleccion").Value Then
                    '        .Cells("IndPesoTnDescarga").Value = 1
                    '    Else
                    '        .Cells("IndPesoTnDescarga").Value = 0
                    '    End If
                    'Else
                    '    If Not .Cells("Cantidad").Value.ToString = "" Or Not IsNumeric(.Cells("Cantidad").Value.ToString) Then
                    '        oeDemandaDetalle.Cantidad = CDbl(.Cells("Cantidad").Value)
                    '    Else
                    '        .Cells("Cantidad").Value = 0
                    '    End If
                    'End If

                    If Not .Cells("FleteUnitario").Value.ToString = "" Or Not IsNumeric(.Cells("FleteUnitario").Value.ToString) Then
                        oeDemandaDetalle.FleteUnitario = CDbl(.Cells("FleteUnitario").Value)
                    Else
                        .Cells("FleteUnitario").Value = 0
                    End If
                    oeIgv = olIgv.IGV(Date.Now)
                    oeDemandaDetalle.IGV = oeIgv.Porcentaje
                    If .Cells("IncluyeIgv").Value = False Then
                        .Cells("Flete").Value = oeDemandaDetalle.FleteCalcularSinIgv
                    Else
                        .Cells("Flete").Value = oeDemandaDetalle.FleteCalcularIgv
                    End If
                    .Cells("Subtotal").Value = oeDemandaDetalle.FleteCalcularSinIgv
                    txtIdOperacionDetalle.Text = .Cells("Id").Value
                    txtGrtPT.Text = .Cells("PesoToneladasDescarga").Value
                    txtGrtCantidad.Text = .Cells("Cantidad").Value
                    'If griGuiaTransportistaViaje.Rows.Count > 0 Then
                    '    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griGuiaTransportistaViaje.Rows
                    '        fila.Cells("PesoToneladas").Value = txtGrtPT.Text
                    '        'fila.Cells("Cantidad").Value = txtGrtCantidad.Text
                    '    Next
                    'End If
                End With
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Sub

    Private Sub AgregarViajeInterrumpido()
        If ValidaViajeInterrumpido() Then
            oeSeguimiento.GuiaTransportistaInterrumpida = griViajeInterrumpido.DataSource
            With oeGuiaTransportistaInterrumpida
                .Id = ""
                .IdSeguimiento = txtIdSeguimiento.Text
                .IdGuiaTransportista = txtIdGrt.Text
                .GuiaTransportista = txtGuiaTransportista.Text
                .IdMotivoTrasladoInterrumpido = cboMotivoTrasladoInterrumpido.Value
                .Glosa = txtGlosaInterrumpido.Text
                .Fecha = fecPartidaViajeInterrumpido.Value
                .Activo = True
                .Viaje = txtCodigoViaje.Text
            End With
            oeSeguimiento.GuiaTransportistaInterrumpida.Add(oeGuiaTransportistaInterrumpida)
            griViajeInterrumpido.DataBind()
            oeGuiaTransportistaInterrumpida = New e_GuiaTransportistaInterrumpida
        End If
    End Sub

    Private Function ValidaViajeInterrumpido() As Boolean
        Try
            ValidarCombo(cboMotivoTrasladoInterrumpido, "Motivo Traslado Interrumpido")
            ValidaGuiaTransportista(txtIdGrt.Text.Trim, txtSerie.Text.Trim, txtNumero.Text.Trim)
            Return True
        Catch ex As Exception
            EnfocarViajeInterrumpido(ex.Message)
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Function

    Private Sub EnfocarViajeInterrumpido(ByVal excepcion As String)
        Select Case excepcion
            Case excepcion.Contains("Motivo Traslado Interrumpido")
                cboMotivoTrasladoInterrumpido.Focus()
        End Select
    End Sub

    Private Sub FleteDetalleGrillaBloque()
        Try
            If griGrtConfirmarBloque.ActiveRow.Cells("IdOperacion").Value.ToString.Length > 0 Then

                With griGrtConfirmarBloque.ActiveRow
                    If .Cells("CargaMaterial").Text = "TONELADA" Or .Cells("CargaMaterial").Text = "BOLSA" Then
                        If Not .Cells("PesoToneladas").Value.ToString = "" Or Not IsNumeric(.Cells("PesoToneladas").Value.ToString) Then
                            oeDemandaDetalle.Cantidad = CDbl(.Cells("PesoToneladas").Value)
                        Else
                            .Cells("PesoToneladas").Value = 0
                        End If
                    Else
                        If Not .Cells("KmCarretaOrigen").Value.ToString = "" Or Not IsNumeric(.Cells("KmCarretaOrigen").Value.ToString) Then
                            oeDemandaDetalle.Cantidad = CDbl(.Cells("KmCarretaOrigen").Value)
                        Else
                            .Cells("KmCarretaOrigen").Value = 0
                        End If
                    End If

                    If Not .Cells("KmCarretaDestino").Value.ToString = "" Or Not IsNumeric(.Cells("KmCarretaDestino").Value.ToString) Then
                        oeDemandaDetalle.FleteUnitario = CDbl(.Cells("KmCarretaDestino").Value)
                    Else
                        .Cells("KmCarretaDestino").Value = 0
                    End If
                    oeIgv = olIgv.IGV(Date.Now)
                    oeDemandaDetalle.IGV = oeIgv.Porcentaje
                    If .Cells("Turno").Value = False Then
                        .Cells("TotalFlete").Value = oeDemandaDetalle.FleteCalcularSinIgv
                    Else
                        .Cells("TotalFlete").Value = oeDemandaDetalle.FleteCalcularIgv
                    End If
                End With
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Sub

    Private Sub FleteDetalleGrillaBloqueSinDocumento()
        Try
            If griViajeConfirmarBloque.ActiveRow.Cells("IdOperacion").Value.ToString.Length > 0 Then
                With oeDemandaDetalle
                    With griViajeConfirmarBloque.ActiveRow
                        If .Cells("CargaMaterial").Text = "TONELADA" Or .Cells("CargaMaterial").Text = "BOLSA" Then
                            If Not .Cells("PesoToneladas").Value.ToString = "" Or Not IsNumeric(.Cells("PesoToneladas").Value.ToString) Then
                                oeDemandaDetalle.Cantidad = CDbl(.Cells("PesoToneladas").Value)
                            Else
                                .Cells("PesoToneladas").Value = 0
                            End If
                        Else
                            If Not .Cells("KmCarretaOrigen").Value.ToString = "" Or Not IsNumeric(.Cells("KmCarretaOrigen").Value.ToString) Then
                                oeDemandaDetalle.Cantidad = CDbl(.Cells("KmCarretaOrigen").Value)
                            Else
                                .Cells("KmCarretaOrigen").Value = 0
                            End If
                        End If

                        If Not .Cells("KmCarretaDestino").Value.ToString = "" Or Not IsNumeric(.Cells("KmCarretaDestino").Value.ToString) Then
                            oeDemandaDetalle.FleteUnitario = CDbl(.Cells("KmCarretaDestino").Value)
                        Else
                            .Cells("KmCarretaDestino").Value = 0
                        End If
                        oeIgv = olIgv.IGV(Date.Now)
                        oeDemandaDetalle.IGV = oeIgv.Porcentaje
                        If .Cells("Turno").Value = False Then
                            .Cells("TotalFlete").Value = oeDemandaDetalle.FleteCalcularSinIgv
                        Else
                            .Cells("TotalFlete").Value = oeDemandaDetalle.FleteCalcularIgv
                        End If
                    End With
                End With
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Function ValidarGuiaRemitente(ByVal txt_controlInicial As ISL.Controles.Texto) As Boolean
        Try
            Dim ls_Serie As String
            Dim ls_Numero As String

            Dim o_DocumentoGrrInicial() As String = txt_controlInicial.Text.Split("-")
            ls_Serie = o_DocumentoGrrInicial(0).ToString.Trim
            If ls_Serie.Length > 4 Then
                txt_controlInicial.Focus()
                Throw New Exception("Nº Serie debe ser Menor o Igual a 4 Digitos, Separando Serie y Numero por un Guión (-): (0000-0000000000)")
            End If

            If txt_controlInicial.Text.Trim.Length = 0 Or Not txt_controlInicial.Text.Contains("-") Then
                txt_controlInicial.Focus()
                Throw New Exception("Ingrese Correctamente Guía Remisión Remitente, Separando Serie y Numero por un Guión (-): (0000-0000000000)")
            End If

            ls_Numero = o_DocumentoGrrInicial(1).ToString.Trim
            If ls_Numero.Length < 1 Then
                txt_controlInicial.Focus()
                Throw New Exception("Numero Seguido de Serie debe ser Mayor a 1 Digitos, Separando Serie y Numero por un Guión (-): (0000-0000000000)")
            End If

            ls_Serie = FormatoDocumento(ls_Serie, 4)
            ls_Numero = FormatoDocumento(ls_Numero, 10)
            Select Case txt_controlInicial.Name
                Case "txtGrr"
                    txtGrr.Text = ls_Serie & "-" & ls_Numero
                Case "txtRangoGrr"
                    txtRangoGrr.Text = ls_Serie & "-" & ls_Numero
                Case "txtGuiaRemitente"
                    txtGuiaRemitente.Text = ls_Serie & "-" & ls_Numero
                Case "txtGrrViaje"
                    txtGrrViaje.Text = ls_Serie & "-" & ls_Numero
                Case "txtGrrRangoViaje"
                    txtGrrRangoViaje.Text = ls_Serie & "-" & ls_Numero
            End Select
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub AgregarGrtAnuladas()
        Try
            Dim GrtAnuladas As Integer = 0
            If ValidaCamposDetalle() Then
                If txtRangoFinalNumeroAnulado.Text = "" Then
                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griGrtAnuladas.Rows
                        If txtSerie.Text + "-" + txtNumero.Text = fila.Cells("Serie").Value + "-" + fila.Cells("Numero").Value Then
                            GrtAnuladas = 1
                            Exit For
                        End If
                    Next
                    If GrtAnuladas = 0 Then
                        With oeGuiaTransportista
                            .GuiaTransportista = griGrtAnuladas.DataSource
                            .TipoOperacion = "I"
                            .Id = txtIdGrt.Text
                            .Serie = txtSerie.Text
                            .Numero = txtNumero.Text
                            .IdSeguimiento = ""
                            .IdRemitente = cboRemitente.Value
                            .Remitente = cboRemitente.Text
                            .IdDireccionLugarPartida = ""
                            .IdDestinatario = cboDestinatario.Value
                            .Destinatario = cboDestinatario.Text
                            .IdDireccionLugarLlegada = ""
                            .IdMotivoDocumentoTraslado = ""
                            .Glosa = ""
                            .Fecha = fecEmision.Value
                            .UsuarioCreacion = gUsuarioSGI.Id
                            .Viaje = ""
                            .IdOperacionDetalle = ""
                            .Incidencia = "ANULADO"
                            .IdSubContrata = ""
                            .SubSerie = ""
                            .SubNumero = ""
                            .PesoToneladas = txtGrtPT.Text
                            .IndFacturado = 0
                            .IndGrtConfirmada = 0
                            .IdVehiculo = ""
                            .IndDocumentos = 0
                            .IndGrtPerdido = 0
                            .IndGuiaTercero = Me.chkGuiaTercero.Checked
                        End With
                        oeGuiaTransportista.GuiaTransportista.Add(oeGuiaTransportista)
                        griGrtAnuladas.DataBind()
                        oeGuiaTransportista = New e_GuiaTransportista
                    End If
                    GrtAnuladas = 0
                Else

                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griGrtAnuladas.Rows
                        If txtSerie.Text + "-" + txtNumero.Text = fila.Cells("Serie").Value + "-" + fila.Cells("Numero").Value Then
                            GrtAnuladas = 1
                            Exit For
                        End If
                    Next
                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griGrtAnuladas.Rows
                        If txtSerie.Text + "-" + txtRangoFinalNumeroAnulado.Text = fila.Cells("Serie").Value + "-" + fila.Cells("Numero").Value Then
                            GrtAnuladas = 1
                            Exit For
                        End If
                    Next
                    If GrtAnuladas = 0 Then
                        Dim ls_NroDocInicial As String = "", _
                                                            ls_NroDocFinal As String = ""

                        ls_NroDocInicial = txtNumero.Text
                        ls_NroDocFinal = txtRangoFinalNumeroAnulado.Text

                        Dim ln_TotalGuias As Integer = CDbl(ls_NroDocFinal) - CDbl(ls_NroDocInicial)
                        Dim i As Integer
                        Dim ls_NroDocumento As String = ""
                        For i = 0 To ln_TotalGuias
                            ls_NroDocumento = (CDbl(ls_NroDocInicial) + i).ToString
                            With oeGuiaTransportista
                                .GuiaTransportista = griGrtAnuladas.DataSource
                                .TipoOperacion = "I"
                                .Id = txtIdGrt.Text
                                .Serie = txtSerie.Text
                                .Numero = FormatoDocumento(ls_NroDocumento, 10)
                                .IdSeguimiento = ""
                                .IdRemitente = cboRemitente.Value
                                .Remitente = cboRemitente.Text
                                .IdDireccionLugarPartida = ""
                                .IdDestinatario = cboDestinatario.Value
                                .Destinatario = cboDestinatario.Text
                                .IdDireccionLugarLlegada = ""
                                .IdMotivoDocumentoTraslado = ""
                                .Glosa = ""
                                .Fecha = fecEmision.Value
                                .UsuarioCreacion = gUsuarioSGI.Id
                                .Viaje = ""
                                .IdOperacionDetalle = ""
                                .Incidencia = "ANULADO"
                                .IdSubContrata = ""
                                .SubSerie = ""
                                .SubNumero = ""
                                .PesoToneladas = txtGrtPT.Text
                                .IndFacturado = 0
                                .IndGrtConfirmada = 0
                                .IdVehiculo = ""
                                .IndDocumentos = 0
                                .IndGrtPerdido = 0
                            End With
                            oeGuiaTransportista.GuiaTransportista.Add(oeGuiaTransportista)
                            griGrtAnuladas.DataBind()
                            oeGuiaTransportista = New e_GuiaTransportista
                        Next
                    End If
                    GrtAnuladas = 0
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub AgregarGuiasGrtViaje()
        Try
            oeGuiaTransportista = New e_GuiaTransportista
            If ValidaCamposDetalle() Then
                oeGuiaTransportista.GuiaTransportista = griGuiaTransportistaViaje.DataSource
                With oeGuiaTransportista
                    .TipoOperacion = "I"
                    .Id = ""
                    .Serie = txtSerie.Text
                    .Numero = txtNumero.Text
                    .IdSeguimiento = txtIdSeguimiento.Text
                    .IdRemitente = cboRemitente.Value
                    .IdDireccionLugarPartida = cboPuntoPartida.Value
                    .IdDestinatario = cboDestinatario.Value
                    .IdDireccionLugarLlegada = cboPuntoLlegada.Value
                    .IdMotivoDocumentoTraslado = cboMotivoTraslado.Value
                    .Glosa = txtGlosa.Text
                    .Fecha = fecEmision.Value
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .Viaje = txtCodigoViaje.Text
                    .IdOperacionDetalle = txtIdOperacionDetalle.Text
                    .Incidencia = ""
                    .IdSubContrata = cboSubContrata.Value
                    .SubSerie = txtSubSerie.Text
                    .SubNumero = txtSubNumero.Text
                    .PesoToneladas = txtGrtPT.Text
                    .IndFacturado = 0
                    .IndGrtConfirmada = verConfirmado.Checked
                    .IdVehiculo = ""
                    .IndDocumentos = verDocumentos.Checked
                    .IndGrtPerdido = verDoctsPerdido.Checked
                    .Cantidad = txtGrtCantidad.Text
                    .IndGuiaTercero = Me.chkGuiaTercero.Checked
                    .IdPilotoTercero = Me.cboPilotoTercMasivo.Value
                End With
                oeGuiaTransportista.GuiaTransportista.Add(oeGuiaTransportista)
                griGuiaTransportistaViaje.DataBind()
                oeGuiaTransportista = New e_GuiaTransportista
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EditarGrtAnulada()
        Try
            Inicializar()
            GRTAnuladasControles()
            Operacion = "Nuevo"
            GuiaTransportistaLista = New List(Of e_GuiaTransportista)
            griGrtAnuladas.DataSource = GuiaTransportistaLista
            If griListaAnuladas.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                oeGuiaTransportista = New e_GuiaTransportista
                oeGuiaTransportista.TipoOperacion = "0"
                oeGuiaTransportista.Id = griListaAnuladas.ActiveRow.Cells("Id").Value.ToString
                oeGuiaTransportista = olGuiaTransportista.Obtener(oeGuiaTransportista)
                With oeGuiaTransportista
                    txtSerie.Text = .Serie
                    txtNumero.Text = .Numero
                    fecEmision.Value = .Fecha
                    cboRemitente.Text = "NINGUNO  ,"
                    cboDestinatario.Text = "NINGUNO  ,"
                    cboSubContrata.Text = "NINGUNO  ,"
                    txtIdGrt.Text = .Id
                    txtGlosa.Text = .Glosa                    
                    txtGrtPT.Text = .PesoToneladas
                    Me.chkGuiaTercero.Checked = .IndGuiaTercero                    
                    Me.cboTransportista.Value = "1CH000004444"
                End With
            End If
            MostrarTabs(1, ficGuias, 1)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function EliminarGrtAnuladas() As Boolean
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            With griLista
                If ValidarGrilla(griListaAnuladas, "GRT-Anuladas") Then
                    oeGuiaTransportista = New e_GuiaTransportista
                    oeGuiaTransportista.Id = griListaAnuladas.ActiveRow.Cells("Id").Value
                    oeGuiaTransportista.TipoOperacion = "0"
                    oeGuiaTransportista = olGuiaTransportista.Obtener(oeGuiaTransportista)
                    If oeGuiaTransportista.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar la GRT-Anulada: " & _
                                                         oeGuiaTransportista.Serie & "-" & oeGuiaTransportista.Numero & " ?", _
                                                         "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeGuiaTransportista.TipoOperacion = "E"
                            olGuiaTransportista.Eliminar(oeGuiaTransportista)
                            'Consultar(True)
                        Else
                            Return False
                            Exit Function
                        End If
                    Else
                        Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                    End If
                End If
            End With
            ugb_Espera.Visible = False
            Return True
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Function

    Private Function ValidaCamposGriBloque() As Boolean
        Try
            LimpiaGrid(griGuiaRemitente, ogdGuiaRemitente)
            With griGrtConfirmarBloque.ActiveRow
                l_FuncionesGenerales.ValidarCampoNoNulo(.Cells("Codigo").Text, "Ingrese Grt-Serie")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Cells("IdCopiloto").Text, "Ingrese Grt-Numero")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Cells("IdTipoVehiculo").Text, "Ingrese Grr-Serie")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Cells("TipoVehiculo").Text, "Ingrese Grr-Numero")
                If RTrim(.Cells("Id").Value) = "" Then
                    ValidaGuiaTransportista(RTrim(.Cells("Id").Value), _
                                            FormatoDocumento(RTrim(.Cells("Codigo").Value), 4), _
                                            FormatoDocumento(RTrim(.Cells("IdCopiloto").Value), 10),
                                            IIf(.Cells("IdTercero").Value = "1CH000004444", False, True))
                    ValidaGuiaRemitente(RTrim(.Cells("IdEscala").Value), _
                                        FormatoDocumento(RTrim(.Cells("IdTipoVehiculo").Value), 4), _
                                        FormatoDocumento(RTrim(.Cells("TipoVehiculo").Value), 10), griGuiaRemitente)
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Control de tiempo de respuesta y actualización"

    'Private Sub frm_Guias_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
    '    InicializaTiempo()
    'End Sub

    'Private Sub griLista_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    If _tiempo <= 0 Then
    '        Consultar(True)
    '    End If
    '    InicializaTiempo()
    'End Sub

    'Public Overloads Function InicializaTiempo() As Integer
    '    _tiempo = 120
    'End Function

#End Region

    Private Sub griViajeDetalle_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles griViajeDetalle.AfterCellUpdate
        If Operacion = "Editar" And griViajeDetalle.Rows(e.Cell.Row.Index).Cells("Id").Value <> "" Then

            Dim lista1 As New List(Of String)
            Dim lista2 As New List(Of String)
            Dim lista3 As New List(Of String)
            lista1.Add(e.Cell.Column.Key)
            lista2.Add(columnas(e.Cell.Column.Index).ToString)
            lista3.Add(e.Cell.Text.ToString)

            Dim indLista = getIndiceLista(e.Cell.Row.Index)
            Dim indArrayGlosas As Integer = getIdArrayGlosas(e.Cell.Column.Key, indLista)
            If indLista = -1 Then
                glosasGeneral(indArrayGlosas, 0) = e.Cell.Column.Key
                glosasGeneral(indArrayGlosas, 1) = ListaBitacora.Count
                glosasGeneral(indArrayGlosas, 2) = 0
                rowGeneral(count, 1) = ListaBitacora.Count ' ind de la lista general
                ListaBitacora.Add(New e_Bitacora(griViajeDetalle.Rows(e.Cell.Row.Index).Cells("IdOperacion").Value, griViajeDetalle.Rows(e.Cell.Row.Index).Cells("Id").Value, "OPE.Operacion", "OPE.OperacionDetalle",
                                                 Me.Text, lista1, gUsuarioSGI.Id, oeSeguimiento.TipoOperacion,
                                                 lista2, lista3, "", "I", True))
            Else
                Dim indicolm = existeColumna(e.Cell.Column.Key, indLista)
                If indicolm <> -1 Then
                    ListaBitacora.Item(indLista).ValoresActuales.Item(indicolm) = e.Cell.Text.ToString
                Else
                    glosasGeneral(indArrayGlosas, 0) = e.Cell.Column.Key
                    glosasGeneral(indArrayGlosas, 1) = indLista
                    glosasGeneral(indArrayGlosas, 2) = ListaBitacora.Item(indLista).ColumnasAfectadas.Count
                    ListaBitacora.Item(indLista).ColumnasAfectadas.Add(e.Cell.Column.Key)
                    ListaBitacora.Item(indLista).ValoresAnteriores.Add(columnas(e.Cell.Column.Index).ToString)
                    ListaBitacora.Item(indLista).ValoresActuales.Add(e.Cell.Text.ToString)
                End If
            End If
        End If
    End Sub

    Private Sub griViajeDetalle_ClickCell(sender As Object, e As ClickCellEventArgs) Handles griViajeDetalle.ClickCell
        columnas.Clear()
        For i As Integer = 0 To griViajeDetalle.Rows(e.Cell.Row.Index).Cells.Count - 1
            columnas.Add(griViajeDetalle.Rows(e.Cell.Row.Index).Cells(i).Text)
        Next
        count = getIdArrayBidimensional()
        rowGeneral(count, 0) = e.Cell.Row.Index
        rowGeneral(count, 1) = -1
    End Sub

    Private Function getIdArrayBidimensional() As Integer
        For i As Integer = 0 To 14
            If rowGeneral(i, 0) = -1 Then
                Return i
            End If
        Next
    End Function

    Private Function getIdArrayGlosas(ByVal nombreCol As String, ByVal indLista As Integer) As String
        For i As Integer = 0 To 14
            If glosasGeneral(i, 0) = nombreCol And glosasGeneral(i, 1) = indLista Then
                Return i
            End If
        Next
        For i As Integer = 0 To 14
            If glosasGeneral(i, 0) = "" Then
                Return i
            End If
        Next
        Return 0
    End Function

    Public Function getIndiceLista(ByVal indiceGrilla As Integer) As Integer
        For i As Integer = 0 To rowGeneral.Length
            If rowGeneral(i, 0) = indiceGrilla Then
                Return rowGeneral(i, 1)
            End If
        Next
        Return -1
    End Function
    Public Function existeColumna(ByVal nombreCol As String, ByVal indLista As Integer) As Integer
        For i As Integer = 0 To 14
            If glosasGeneral(i, 0) = nombreCol And glosasGeneral(i, 1) = indLista Then
                Return glosasGeneral(i, 2)
            End If
        Next
        Return -1
    End Function
    Public Sub FiltrarLista()
        Dim listaAuxiliar As New List(Of e_Bitacora)
        For Each obj As e_Bitacora In ListaBitacora
            Dim objAuxiliar As New e_Bitacora
            objAuxiliar.ValoresActuales = New List(Of String)
            objAuxiliar.ValoresAnteriores = New List(Of String)
            objAuxiliar.ColumnasAfectadas = New List(Of String)
            For j As Integer = 0 To obj.ValoresAnteriores.Count - 1
                If obj.ValoresAnteriores(j) <> obj.ValoresActuales(j) Then
                    objAuxiliar.ValoresAnteriores.Add(obj.ValoresAnteriores(j))
                    objAuxiliar.ValoresActuales.Add(obj.ValoresActuales(j))
                    objAuxiliar.ColumnasAfectadas.Add(obj.ColumnasAfectadas(j))
                    objAuxiliar.Activo = obj.Activo
                    objAuxiliar.IdTablaCabecera = obj.IdTablaCabecera
                    objAuxiliar.IdTablaDetalle = obj.IdTablaDetalle
                    objAuxiliar.Indicador = obj.Indicador
                    objAuxiliar.NombreFormulario = obj.NombreFormulario
                    objAuxiliar.NombreTablaCabecera = obj.NombreTablaCabecera
                    objAuxiliar.NombreTablaDetalle = obj.NombreTablaDetalle
                    objAuxiliar.Tipo = obj.Tipo
                    objAuxiliar.TipoOPeracion = obj.TipoOPeracion
                    objAuxiliar.UsuarioRegistro = obj.UsuarioRegistro
                End If
            Next
            If objAuxiliar.ValoresAnteriores.Count > 0 Then
                listaAuxiliar.Add(objAuxiliar)
            End If
        Next
        ListaBitacora = listaAuxiliar
    End Sub

    Private Sub chkGuiaTercero_CheckedChanged(sender As Object, e As EventArgs) Handles chkGuiaTercero.CheckedChanged
        '        Me.cboTransportista.Value = codigoTercero
        Try
            If chkGuiaTercero.Checked Then                 
                Dim ListTercero = New List(Of e_Combo)
                oeCombo = New e_Combo
                oeCombo.Nombre = "Transportista"
                ListTercero.AddRange(olCombo.Listar(oeCombo).Where(Function(Item) Item.Id = codigoTercero).ToList.OrderBy(Function(Item) Item.Nombre).ToList)
                LlenarComboMaestro(cboTransportista, ListTercero, 0)
                Me.cboTransportista.Value = codigoTercero
            Else
                Dim ListTercero = New List(Of e_Combo)
                oeCombo = New e_Combo
                oeCombo.Nombre = "Transportista"
                ListTercero.AddRange(olCombo.Listar(oeCombo).Where(Function(Item) Item.Id = "1CH000004444").ToList.OrderBy(Function(Item) Item.Nombre).ToList)
                LlenarComboMaestro(cboTransportista, ListTercero, 0)
                Me.cboTransportista.Value = "1CH000004444"
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cboPilotoTercero_EditorButtonClick(sender As Object, e As EditorButtonEventArgs) Handles cboPilotoTercero.EditorButtonClick
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            'If cboPilotoTercero.Value <> "" Then
            bandComboPiloto = "U"
            codigoPilotoTercero = IIf(cboPilotoTercero.Value = Nothing, "", cboPilotoTercero.Value)
            Dim frmTrabajador As New frm_Trabajador
            frmTrabajador = frm_Trabajador.getInstancia()
            frmTrabajador.MdiParent = frm_Menu
            frmTrabajador.Show()
            frmTrabajador.MostrarTrabajador(cboPilotoTercero.Value)
            ugb_Espera.Visible = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cboPilotoTercMasivo_EditorButtonClick(sender As Object, e As EditorButtonEventArgs) Handles cboPilotoTercMasivo.EditorButtonClick
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            'If cboPilotoTercero.Value <> "" Then
            bandComboPiloto = "M"
            codigoPilotoTercero = IIf(cboPilotoTercMasivo.Value = Nothing, "", cboPilotoTercMasivo.Value)
            Dim frmTrabajador As New frm_Trabajador
            frmTrabajador = frm_Trabajador.getInstancia()
            frmTrabajador.MdiParent = frm_Menu
            frmTrabajador.Show()
            frmTrabajador.MostrarTrabajador(cboPilotoTercMasivo.Value)
            ugb_Espera.Visible = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griGuiaTransportistaViaje_ClickCell(sender As Object, e As ClickCellEventArgs) Handles griGuiaTransportistaViaje.ClickCell
        Dim PuntoPartida As String = ""
        Dim PuntoLlegada As String = ""
        Try
            If griGuiaTransportistaViaje.Rows.Count > 0 Then
                If e.Cell.Row.Index > -1 Then
                    With griGuiaTransportistaViaje.Rows(e.Cell.Row.Index)
                        txtIdGrt.Text = .Cells("Id").Value
                        txtSerie.Text = .Cells("Serie").Value
                        txtNumero.Text = .Cells("Numero").Value
                        fecEmision.Value = .Cells("Fecha").Value
                        txtGrtPT.Text = .Cells("PesoToneladas").Value
                        cboRemitente.Value = .Cells("IdRemitente").Value
                        PuntoPartida = .Cells("IdDireccionLugarPartida").Value
                        cboDestinatario.Value = .Cells("IdDestinatario").Value
                        PuntoLlegada = .Cells("IdDireccionLugarLlegada").Value
                        cboSubContrata.Value = .Cells("IdSubContrata").Value
                        txtSubSerie.Text = .Cells("SubSerie").Value
                        txtSubNumero.Text = .Cells("SubNumero").Value
                        verConfirmado.Checked = .Cells("IndGrtConfirmada").Value
                        verDocumentos.Checked = .Cells("IndDocumentos").Value
                        verDoctsPerdido.Checked = .Cells("IndGrtPerdido").Value
                        cboMotivoTraslado.Value = .Cells("IdMotivoDocumentoTraslado").Value
                        txtGlosa.Text = .Cells("Glosa").Value
                        txtGrtCantidad.Text = .Cells("Cantidad").Value
                        Me.chkGuiaTercero.Checked = IIf(.Cells("IndGuiaTercero").Value = True, True, False)
                    End With
                    cboRemitente_Validated(Nothing, Nothing)
                    cboPuntoPartida.Value = PuntoPartida
                    cboDestinatario_Validated(Nothing, Nothing)
                    cboPuntoLlegada.Value = PuntoLlegada
                End If
                
            End If
        Catch ex As Exception
            Throw ex
        End Try
        
    End Sub

    Private Sub griListaTerceros_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griListaTerceros.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            e.Cancel = True
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class