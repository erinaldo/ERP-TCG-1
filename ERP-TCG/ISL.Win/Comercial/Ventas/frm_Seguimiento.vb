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
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Configuration
Imports Infragistics.Win.CalcEngine
Imports Infragistics.Win.UltraWinDataSource
Imports System.Threading
Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Imports System.Net.Mail
Imports System.IO
Imports System.Net
Imports System.Text
Imports System
Imports System.Globalization
Imports Microsoft.VisualBasic
Imports Microsoft.Office.Interop

Public Class frm_Seguimiento
    Inherits frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_Seguimiento = Nothing
    Private Shared Operacion As String
    Private Estado As String

    ''' <summary>
    ''' Instancia unica de Formulario: frm_Demanda
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Seguimiento()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de variables"

    Dim oeCliente As e_Cliente
    Dim olCliente As l_Cliente

    Dim oeRuta As e_Ruta
    Dim olRuta As l_Ruta

    Dim oeSeguimiento As e_Seguimiento
    Dim oeSeguimientoAnterior As e_Seguimiento
    Dim olSeguimiento As l_Seguimiento
    Dim ListaSeguimiento As List(Of e_Seguimiento)

    Dim oeGuiaTransportista As e_GuiaTransportista
    Dim olGuiaTransportista As l_GuiaTransportista

    Dim oeGuiaRemitente As e_GuiaRemitente
    Dim olGuiaRemitente As l_GuiaRemitente

    Dim oeGrtInterrumpida As e_GuiaTransportistaInterrumpida
    Dim olGrtInterrumpida As l_GuiaTransportistaInterrumpida

    Dim oeViaje As e_Viaje
    Dim oeViajeImportar As e_Viaje
    Dim ListaViaje As New List(Of e_Viaje)
    Dim oeOperacionDetalle As e_OperacionDetalle

    Dim olOperacion As l_Operacion

    Dim olTiempoCiclo As l_TiempoCiclo
    Dim oeTiempoCiclo As e_TiempoCiclo

    Dim olGuiasControl As l_GuiasControl
    Dim oeGuiasControl As e_GuiasControl

    Dim olDireccionEmpresa As l_Combo
    Dim oeDireccionEmpresa As e_Combo

    Dim olVehiculo As l_Vehiculo
    Dim oeVehiculo As e_Vehiculo

    Dim _ingresando_datos As Boolean = False

    Dim Opcion As Boolean

    Dim GRT As String

    Dim SalidaOrigenIndicador As Boolean = False

    Dim SalidaDestinoIndicador As Boolean = False

    Dim oeUsuarioPerfil As e_UsuarioPerfil
    Dim olUsuarioPerfil As l_UsuarioPerfil

    Dim oePerfil As e_Perfil
    Dim olPerfil As l_Perfil

    Dim Prefijo As l_Configuracion

    Dim ctrNuevo As Boolean = False, ctrEditar As Boolean = False, SOrigen As String, SDestino As String

    Dim oeRegConsumoCombustible As e_RegistroConsumoCombustible
    Dim olRegConsumoCombustible As l_RegistroConsumoCombustible

    Dim Origen As String
    Dim Destino As String
    Dim RutaKilometros As Decimal
    Dim TractoKilometros As Decimal

    Dim IdVehiculo As String

    Dim ProximoNumeroGRT As String = ""

    Dim GuiasIngresoGRT As Boolean = False

    Dim oeRegistroEditado As e_RegistrosEditados
    Dim olRegistroEditado As l_RegistrosEditados

    Dim RegistroEditado As Integer = 0
    Dim IdRegistroEditado As String = ""

    Dim oeCombo As e_Combo
    Dim olCombo As l_Combo

    Dim FechaServidor As Date = ObtenerFechaServidor()

    Dim ClienteCargaMaterial As String = ""
    Dim ClienteCarga As String = ""
    Dim ClienteSalidaCarga As String = ""
    Dim ClienteLlegadaCarga As String = ""
    Dim OrigenViaje As String = ""
    Dim DestinoViaje As String = ""

    Dim IndGuardar As Integer = 0
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
    Private Const IdEstadoProgramado As String = "1CH00017"
    Dim IdMaterialAux As String = String.Empty
#End Region

#Region "BOTONES"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Estado = IIf(Activo, " Activo", " Inactivo")
            If ValidarFechaInicioFin(fecDesde, fecHasta) Then
                Select Case tabListado.SelectedTab.Index
                    Case tapViajes.Tab.Index
                        Listar()
                        If gUsuarioSGI.oeArea.Nombre = gNombreAreaPlaneamientoControl Or
                           gUsuarioSGI.oeArea.Nombre = gNombreAreaOperaciones Or
                           gUsuarioSGI.oeArea.Nombre = gNombreAreaCoordinacionSupervisionOperacion Or
                            gUsuarioSGI.oeArea.Nombre = gNombreAreaInformaticaSistemas Then
                            If griLista.Rows.Count > 0 Then
                                ControlBoton(1, 0, 1, 0, 0, 0, 1, 1, 1)
                            Else
                                ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                            End If
                        Else
                            ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                        End If
                    Case tapAlertaViajes.Tab.Index
                        mt_ListarAlerta()
                        If griAlertaViajes.Rows.Count > 0 Then
                            ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                        Else
                            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                        End If
                End Select
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
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If griLista.Selected.Rows.Count > 0 AndAlso griLista.ActiveRow.Index >= 0 Then
                IdMaterialAux = griLista.ActiveRow.Cells("CargaMaterial").Value
                Inicializar()
                cboLugarTienda.Clear()
                olRegistroEditado = New l_RegistrosEditados
                IncidenciasPublic = New e_IncidenciasAutentificadas
                If EditarSeguimiento() Then
                    Operacion = "Editar"
                    oeSeguimiento.UsuarioCreacion = gUsuarioSGI.Id
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                    SalidaOrigenIndicador = False
                    SalidaDestinoIndicador = False
                    InformacionTractoCarreta(0, 0, 0, 0, 0, 0)
                    If RegistroEditado = 1 Then
                        oeRegistroEditado = New e_RegistrosEditados
                        With oeRegistroEditado
                            .IdRegistro = griLista.ActiveRow.Cells("Id").Value
                            .Referencia = "Seguimiento"
                            .UsuarioEdita = gUsuarioSGI.Id
                        End With
                        oeRegistroEditado.PrefijoID = gs_PrefijoIdSucursal '@0001
                        IdRegistroEditado = olRegistroEditado.Guardar(oeRegistroEditado)
                    End If
                    If verIndFallaOP.Checked Then
                        Dim Fecha24Horas As DateTime
                        Fecha24Horas = DateAdd(DateInterval.Day, -1, FechaServidor)
                        If Fecha24Horas <= oeSeguimiento.FechaFalla Then
                            grupoMarca01.Enabled = False
                            grupoMarca02.Enabled = False
                        Else
                            grupoMarca01.Enabled = True
                            grupoMarca02.Enabled = True
                        End If
                    Else

                        grupoMarca01.Enabled = True
                        grupoMarca02.Enabled = True

                    End If
                    IndGuardar = 0
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try

    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarSeguimiento() Then
                MostrarTabs(0, ficDemanda, 2)
                MyBase.Guardar()
                ''Await MensajePC("Guardado")
            Else
                MostrarTabs(1, ficDemanda, 1)
                ''Await MensajePC("Problema")
            End If
            GuiasIngresoGRT = False
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
            If IndGuardar = 0 Then
                Dim pregunta As String = "¿Desea guardar los cambios efectuados en " & Me.Text & "?"
                ''Await MensajePC(pregunta)
                Select Case MessageBox.Show(pregunta, "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarSeguimiento() Then
                            MostrarTabs(0, ficDemanda, 2)
                            _ingresando_datos = False
                            Operacion = "Inicializa"
                            ControlBoton(1, 0, 1, 0, 0, 0, 1, 1, 1)
                            GuiasIngresoGRT = False
                        Else
                            _ingresando_datos = True
                        End If

                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficDemanda, 2)
                        _ingresando_datos = False
                        Operacion = "Inicializa"
                        ControlBoton(1, 0, 1, 0, 0, 0, 1, 1, 1)
                        GuiasIngresoGRT = False
                        ActualizaRegistroEditado(RegistroEditado, IdRegistroEditado)
                    Case Windows.Forms.DialogResult.Cancel
                        _ingresando_datos = True
                End Select
                '_ingresando_datos = True
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

    'Public Overrides Sub Eliminar()
    'try
    '    With griLista
    '        If Not ValidarGrilla(griLista, "Seguimiento") Then Exit Sub
    '        oeSeguimiento.Id = griLista.ActiveRow.Cells("Id").Value
    '        oeSeguimiento.TipoOperacion = "2"
    '        oeSeguimiento = olSeguimiento.Obtener(oeSeguimiento)
    '        If oeSeguimiento.Activo Then
    '            If MessageBox.Show("Esta seguro de eliminar el Seguimiento: " & _
    '                     oeSeguimiento.Codigo & " ?", _
    '                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
    '                olSeguimiento.Eliminar(oeSeguimiento)
    '                Consultar(True)
    '            End If
    '        Else
    'Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
    '        End If
    '    End With
    '    MyBase.Eliminar()
    '    Catch ex As Exception
    'mensajeEmergente.Problema(ex.Message)
    'End Try
    'End Sub

    Public Overrides Sub Imprimir()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            MyBase.Imprimir()
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
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
            MyBase.Salir()
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Select Case tabListado.SelectedTab.Index
                Case tapViajes.Tab.Index
                    ExportarGrillaAExcel(griLista)
                Case tapAlertaViajes.Tab.Index
                    ExportarGrillaAExcel(griAlertaViajes)
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Function ValidaMarcacion() As Boolean
        Try
            If Not PerfilAsignado(gNombrePerfilAutorizaCallCenter) Then
                If MessageBox.Show("No esta autorizado para cambiar el estado del" & Environment.NewLine & _
                                    "viaje cuando ya fue reportado comuniquese con el " & gNombrePerfilJefeCallCenter & Environment.NewLine & _
                                    "Desea Seguir reportando Viajes:  ?", _
                                    "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    IncidenciasPublic = New e_IncidenciasAutentificadas
                    Dim formulario As frm_Autorizacion
                    formulario = frm_Autorizacion
                    If formulario.ObtenerJefes(gNombrePerfilAutorizaCallCenter, "frm_Seguimiento1", pIdActividadNegocio) Then formulario.ShowDialog()
                    If IncidenciasPublic.IdResponsableAutoriza = "" Then
                        Throw New Exception("La Autentificacion de Autorizacion no devolvio ningun valor....")
                    End If
                Else
                    Throw New Exception("La Autentificacion de Autorizacion no devolvio ningun valor....")
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub griGuias_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griGuiaTransportista.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show(Me.Text & ": ¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub mnu_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        If griGuiaTransportista.Rows.Count > 0 Then griGuiaTransportista.ActiveRow.Delete()
    End Sub

    Private Sub griLista_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griLista.DoubleClick
        If gUsuarioSGI.oeArea.Nombre = gNombreAreaPlaneamientoControl Or
           gUsuarioSGI.oeArea.Nombre = gNombreAreaCoordinacionSupervisionOperacion Or
           gUsuarioSGI.oeArea.Nombre = gNombreAreaOperaciones Or
            gUsuarioSGI.oeArea.Nombre = gNombreAreaInformaticaSistemas Then
            If griLista.Selected.Rows.Count > 0 Then Editar()
        End If
    End Sub

    Private Sub griGuias_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griGuiaTransportista.CellChange
        griGuiaTransportista.UpdateData()
    End Sub

    Private Sub frm_Seguimiento_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            Me.Activate()
            Me.Cancelar()
        End If
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_Seguimiento_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Select Case Operacion
            Case "Nuevo"
                MyBase.Nuevo()
            Case "Editar"
                MyBase.Editar()
            Case "Inicializa"
                MostrarTabs(0, ficDemanda, 2)
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                'Consultar(True)
            Case "Ayuda"
        End Select
    End Sub

    Private Sub frm_Seguimiento_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub griLista_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griLista.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griLista_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griLista.InitializeLayout
        agrBusqueda.Text = "Lista Registros: " & e.Layout.Rows.Count
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim Guia As String
            Dim Ingreso As Integer
            Ingreso = 0
            Dim Cliente As String = ""
            Dim Material As String = ""
            'Ingreso = 0
            For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griViajeDetalle.Rows
                Cliente = Fila.Cells("Cliente").Text
                Material = Fila.Cells("Material").Text.Trim
                Exit For
            Next
            If Cliente = "ALICORP SAA" And Material <> "ARROZ" Then
                If txtGlosa.Text = "" Then
                    '' Await MensajePC("Falta número de transporte")
                    txtGlosa.Focus()
                    Throw New Exception("Ingrese Nª Transporte para este cliente : " & Cliente)
                End If
            End If

            If txtGrt.Text <> "" And txtGrr.Text <> "" Then
                If ValidarGuiaTransportista(txtGrt) And ValidarGuiaRemitente(txtGrr) Then
                    If txtRangoGrr.Text <> "" Then
                        ValidarGuiaRemitente(txtGrr, txtRangoGrr)
                    End If
                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griGuiaTransportista.Rows
                        Guia = fila.Cells("Serie").Value + "-" + fila.Cells("Numero").Value
                        If Guia = txtGrt.Text Then
                            Ingreso = 1
                            Exit For
                        End If
                    Next
                    If Ingreso = 0 Then
                        Dim GuiaTransportista() As String = txtGrt.Text.Split("-")
                        If ValidaGuiaTransportista("", GuiaTransportista(0).ToString.Trim, GuiaTransportista(1).ToString.Trim) Then
                            If txtRangoGrr.Text = "" Then
                                Dim GuiaRemitente() As String = txtGrr.Text.Split("-")
                                If ValidaGuiaRemitente(cboRemitente.Value, GuiaRemitente(0).ToString.Trim, GuiaRemitente(1).ToString.Trim) Then
                                    AgregarGuias()
                                    AgregarGuiasRemitente()
                                End If
                            Else
                                Dim GuiaRemitente() As String = txtRangoGrr.Text.Split("-")
                                If ValidaGuiaRemitente(cboRemitente.Value, GuiaRemitente(0).ToString.Trim, GuiaRemitente(1).ToString.Trim) Then
                                    AgregarGuias()
                                    AgregarGrrRango(txtGrr, txtRangoGrr)
                                End If
                            End If
                        End If
                    Else
                        If txtRangoGrr.Text = "" Then
                            Dim GuiaRemitente() As String = txtGrr.Text.Split("-")
                            If ValidaGuiaRemitente(cboRemitente.Value, GuiaRemitente(0).ToString.Trim, GuiaRemitente(1).ToString.Trim) Then
                                AgregarGuiasRemitente()
                            End If
                        Else
                            Dim GuiaRemitente() As String = txtRangoGrr.Text.Split("-")
                            If ValidaGuiaRemitente(cboRemitente.Value, GuiaRemitente(0).ToString.Trim, GuiaRemitente(1).ToString.Trim) Then
                                AgregarGrrRango(txtGrr, txtRangoGrr)
                            End If
                        End If
                    End If
                    If Not String.IsNullOrEmpty(ProximoNumeroGRT) Then txtGrt.Text = ProximoNumeroGRT
                End If
            Else
                'Await MensajePC("Verifique la Guía")
                Throw New Exception("Ingrese Datos Correctos para N° Guia Transportista / N° Guia Remitente, Separando Serie y Numero por un Guión (-): (0000-0000000000)")
            End If

            txtRangoGrr.Text = String.Empty
            txtGlosa.Text = "Glosa: "
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub frm_Seguimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Prefijo = New l_Configuracion
            ColorControles()
            fecLlegadaOrigen.Value = Date.Today
            fecLlegadaOrigenE.Value = Date.Today
            hLlegadaOrigen.Value = TimeOfDay.ToShortTimeString
            hLlegadaOrigenE.Value = TimeOfDay.ToShortTimeString
            LlenaCombos()
            ComboGrilla()
            ControlRangoFechaInicializa()
            cboCentro.Value = gs_PrefijoIdSucursal '@0001
            cboCentroImportar.Value = gs_PrefijoIdSucursal '@0001
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnLlegadaOrigen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLlegadaOrigen.Click
        Try
            If verCargaOrigen.Checked Then
                ValidaMarcacion()
            End If
            ValidarFechaServidor(fecLlegadaOrigen.Value)
            With oeSeguimiento
                .TipoOperacion = "1"
                .IdViaje = txtViajeId.Text
                .IdEstado = "CARGA"
                .LlegadaOrigen = Date.Parse(fecLlegadaOrigen.Value.ToShortDateString & " " & hLlegadaOrigen.Value.ToShortTimeString)
                .IndLlegadaOrigen = 1
            End With
            'ValidaLlegadaOrigen(oeSeguimiento.LlegadaOrigen)
            oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olSeguimiento.Guardar(oeSeguimiento) Then
                verLlegadaOrigen.Checked = True
                Marcas()
                InformacionTractoCarreta(0, 0, 0, 0, 0, 0)
            End If
            ViajeVacio()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCargaOrigen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargaOrigen.Click
        Try
            If verTerminoCargaOrigen.Checked Then
                ValidaMarcacion()
            End If
            ValidarFechaServidor(fecCargaOrigen.Value)
            With oeSeguimiento
                .TipoOperacion = "3"
                .IdViaje = txtViajeId.Text
                .IdEstado = "CARGA"
                .CargaOrigen = Date.Parse(fecCargaOrigen.Value.ToShortDateString & " " & hCargaOrigen.Value.ToShortTimeString)
                .IndCargaOrigen = 1
            End With

            ValidaInicioCargaOrigen(oeSeguimiento.CargaOrigen)
            oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olSeguimiento.Guardar(oeSeguimiento) Then
                verCargaOrigen.Checked = True
                Marcas()
                InformacionTractoCarreta(0, 0, 0, 0, 0, 0)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnSalidaOrigen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalidaOrigen.Click
        Try
            If verLlegadaDestino.Checked Then
                ValidaMarcacion()
            End If
            ValidarFechaServidor(fecSalidaOrigen.Value)
            With oeSeguimiento
                .TipoOperacion = "6"
                .IdViaje = txtViajeId.Text
                .IdEstado = "TRANSITO"
                .SalidaOrigen = Date.Parse(fecSalidaOrigen.Value.ToShortDateString & " " & hSalidaOrigen.Value.ToShortTimeString)
                .IndSalidaOrigen = 1
            End With

            ValidaSalidaOrigen(oeSeguimiento.SalidaOrigen)
            oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olSeguimiento.Guardar(oeSeguimiento) Then
                verSalidaOrigen.Checked = True
                Marcas()
                InformacionTractoCarreta(1, 0, 1, 0, 1, 0)
                SalidaOrigenIndicador = True
                If griGuiaTransportista.Rows.Count > 0 Then
                    tabGuias.Tabs(0).Enabled = False
                    tabGuias.Tabs(1).Enabled = False
                    tabGuias.Tabs(2).Enabled = False
                Else
                    tabGuias.Tabs(0).Selected = True
                    tabGuias.Tabs(0).Enabled = True
                    tabGuias.Tabs(1).Enabled = True
                End If

                cboRemitente.Focus()
                cboDestinatario.Focus()
                txtGrt.Focus()
                'If ClienteCarga = "INDUSTRIA ARROCERA DE AMERICA S.A.C." Then
                '    ClienteSalidaCarga = CStr(Date.Parse(fecSalidaOrigen.Value.ToShortDateString & " " & hSalidaOrigen.Value.ToShortTimeString))
                '    EnviarEmailCliente("", ClienteSalidaCarga, ClienteLlegadaCarga)
                'End If
            End If
            ViajeVacio()
            IndGuardar = 1
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnLlegadaDestino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLlegadaDestino.Click
        Try
            If txtKmTractoOrigen.Value < 1 Then
                Throw New Exception("Ingrese KM Origen del Tracto")
            End If
            If verDescargaDestino.Checked Then
                ValidaMarcacion()
            End If
            ValidarFechaServidor(fecLlegadaDestino.Value)
            With oeSeguimiento
                .TipoOperacion = "8"
                .IdViaje = txtViajeId.Text
                .IdEstado = "TRANSITO"
                .LlegadaDestino = Date.Parse(fecLlegadaDestino.Value.ToShortDateString & " " & hLlegadaDestino.Value.ToShortTimeString)
                .IndLlegadaDestino = 1
            End With
            ValidaLlegadaDestino(oeSeguimiento.LlegadaDestino)
            oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olSeguimiento.Guardar(oeSeguimiento) Then
                verLlegadaDestino.Checked = True
                Marcas()
                InformacionTractoCarreta(1, 0, 1, 0, 1, 0)
                'If ClienteCarga = "INDUSTRIA ARROCERA DE AMERICA S.A.C." Then
                '    ClienteSalidaCarga = CStr(Date.Parse(fecSalidaOrigen.Value.ToShortDateString & " " & hSalidaOrigen.Value.ToShortTimeString))
                '    ClienteLlegadaCarga = CStr(Date.Parse(fecLlegadaDestino.Value.ToShortDateString & " " & hLlegadaDestino.Value.ToShortTimeString))
                '    EnviarEmailCliente("", ClienteSalidaCarga, ClienteLlegadaCarga)
                'End If
            End If
            ViajeVacio()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnDescargaDestino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDescargaDestino.Click
        Try
            If verTerminoDescargaDestino.Checked Then
                ValidaMarcacion()
            End If
            ValidarFechaServidor(fecDescargaDestino.Value)
            With oeSeguimiento
                .TipoOperacion = "X"
                .IdViaje = txtViajeId.Text
                .IdEstado = "DESCARGA"
                .DescargaDestino = Date.Parse(fecDescargaDestino.Value.ToShortDateString & " " & hDescargaDestino.Value.ToShortTimeString)
                .IndDescargaDestino = 1
            End With

            ValidaDescargaDestino(oeSeguimiento.DescargaDestino)
            oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olSeguimiento.Guardar(oeSeguimiento) Then
                verDescargaDestino.Checked = True
                Marcas()
                InformacionTractoCarreta(1, 0, 1, 0, 1, 0)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnSalidaDestino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalidaDestino.Click
        Try
            If txtKmTractoOrigen.Value < 1 Then
                txtKmTractoOrigen.Focus()
                txtKmTractoOrigen.Select()
                Throw New Exception("Ingrese KM Origen del Tracto")
            End If
            If txtKmTractoDestino.Value < 1 Then
                InformacionTractoCarreta(1, 1, 1, 1, 1, 1)
                txtKmTractoDestino.Focus()
                txtKmTractoDestino.Select()
                Throw New Exception("Ingrese KM Destino del Tracto")
            End If
            ValidarFechaServidor(fecSalidaDestino.Value)
            With oeSeguimiento
                .TipoOperacion = "D"
                .IdViaje = txtViajeId.Text
                .IdEstado = "FIN"
                .SalidaDestino = Date.Parse(fecSalidaDestino.Value.ToShortDateString & " " & hSalidaDestino.Value.ToShortTimeString)
                .IndSalidaDestino = 1
            End With

            ValidaSalidaDestino(oeSeguimiento.SalidaDestino)
            oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olSeguimiento.Guardar(oeSeguimiento) Then
                verSalidaDestino.Checked = True
                InformacionTractoCarreta(1, 1, 1, 1, 1, 1)
                SalidaDestinoIndicador = True
            End If
            ViajeVacio()
            IndGuardar = 1
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnLlegadaOrigenE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLlegadaOrigenE.Click
        Try
            If verIngresoComplejoOrigenE.Checked Then
                ValidaMarcacion()
            End If
            ValidarFechaServidor(fecLlegadaOrigenE.Value)
            With oeSeguimiento
                .TipoOperacion = "1"
                .IdViaje = txtViajeId.Text
                .IdEstado = "CARGA"
                .LlegadaOrigen = Date.Parse(fecLlegadaOrigenE.Value.ToShortDateString & " " & hLlegadaOrigenE.Value.ToShortTimeString)
                .IndLlegadaOrigen = 1
            End With

            'ValidaLlegadaOrigen(oeSeguimiento.LlegadaOrigen)
            oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olSeguimiento.Guardar(oeSeguimiento) Then
                verLlegadaOrigenE.Checked = True
                Marcas()
                InformacionTractoCarreta(0, 0, 0, 0, 0, 0)
            End If
            ViajeVacio()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnIngresoComplejoOrigenE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresoComplejoOrigenE.Click
        Try
            If verCargaOrigenE.Checked Then
                ValidaMarcacion()
            End If
            ValidarFechaServidor(fecIngresoComplejoOrigenE.Value)
            With oeSeguimiento
                .TipoOperacion = "2"
                .IdViaje = txtViajeId.Text
                .IdEstado = "CARGA"
                .IngresoComplejoOrigen = Date.Parse(fecIngresoComplejoOrigenE.Value.ToShortDateString & " " & hIngresoComplejoOrigenE.Value.ToShortTimeString)
                .IndIngresoComplejoOrigen = 1
            End With

            ValidaIngresoComplejoOrigenE(oeSeguimiento.IngresoComplejoOrigen)
            oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olSeguimiento.Guardar(oeSeguimiento) Then
                verIngresoComplejoOrigenE.Checked = True
                Marcas()
                InformacionTractoCarreta(0, 0, 0, 0, 0, 0)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCargaOrigenE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargaOrigenE.Click
        Try
            If verTerminoCargaOrigenE.Checked Then
                ValidaMarcacion()
            End If
            ValidarFechaServidor(fecCargaOrigenE.Value)
            With oeSeguimiento
                .TipoOperacion = "3"
                .IdViaje = txtViajeId.Text
                .IdEstado = "CARGA"
                .CargaOrigen = Date.Parse(fecCargaOrigenE.Value.ToShortDateString & " " & hCargaOrigenE.Value.ToShortTimeString)
                .IndCargaOrigen = 1
            End With

            ValidaInicioCargaOrigenE(oeSeguimiento.CargaOrigen)
            oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olSeguimiento.Guardar(oeSeguimiento) Then
                verCargaOrigenE.Checked = True
                Marcas()
                InformacionTractoCarreta(0, 0, 0, 0, 0, 0)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnTerminoCargaOrigenE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTerminoCargaOrigenE.Click
        Try
            If verImpresionGuiaOrigenE.Checked Then
                ValidaMarcacion()
            End If
            ValidarFechaServidor(fecTerminoCargaOrigenE.Value)
            With oeSeguimiento
                .TipoOperacion = "4"
                .IdViaje = txtViajeId.Text
                .IdEstado = "CARGA"
                .TerminoCargaOrigen = Date.Parse(fecTerminoCargaOrigenE.Value.ToShortDateString & " " & hTerminoCargaOrigenE.Value.ToShortTimeString)
                .IndTerminoCargaOrigen = 1
            End With

            ValidaTerminoCargaOrigenE(oeSeguimiento.TerminoCargaOrigen)
            oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olSeguimiento.Guardar(oeSeguimiento) Then
                verTerminoCargaOrigenE.Checked = True
                Marcas()
                InformacionTractoCarreta(0, 0, 0, 0, 0, 0)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnImpresionGuiaOrigenE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImpresionGuiaOrigenE.Click
        Try
            If verSalidaOrigenE.Checked Then
                ValidaMarcacion()
            End If
            ValidarFechaServidor(fecImpresionGuiaOrigenE.Value)
            With oeSeguimiento
                .TipoOperacion = "5"
                .IdViaje = txtViajeId.Text
                .IdEstado = "CARGA"
                .ImpresionGuiaOrigen = Date.Parse(fecImpresionGuiaOrigenE.Value.ToShortDateString & " " & hImpresionGuiaOrigenE.Value.ToShortTimeString)
                .IndImpresionGuiaOrigen = 1
            End With

            ValidaImpresionGuiaOrigenE(oeSeguimiento.ImpresionGuiaOrigen)
            oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olSeguimiento.Guardar(oeSeguimiento) Then
                verImpresionGuiaOrigenE.Checked = True
                Marcas()
                InformacionTractoCarreta(0, 0, 0, 0, 0, 0)
                fecEmisionGrt.Value = fecImpresionGuiaOrigenE.Value
                fecEmisionGrr.Value = fecImpresionGuiaOrigenE.Value
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnSalidaOrigenE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalidaOrigenE.Click
        Try
            If verLlegadaAproximadaDestinoE.Checked Then
                ValidaMarcacion()
            End If
            ValidarFechaServidor(fecSalidaOrigenE.Value)
            With oeSeguimiento
                .TipoOperacion = "6"
                .IdViaje = txtViajeId.Text
                .IdEstado = "TRANSITO"
                .SalidaOrigen = Date.Parse(fecSalidaOrigenE.Value.ToShortDateString & " " & hSalidaOrigenE.Value.ToShortTimeString)
                .IndSalidaOrigen = 1
            End With

            ValidaSalidaOrigenE(oeSeguimiento.SalidaOrigen)
            oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olSeguimiento.Guardar(oeSeguimiento) Then
                verSalidaOrigenE.Checked = True
                Marcas()
                InformacionTractoCarreta(1, 0, 1, 0, 1, 0)
                SalidaOrigenIndicador = True
                If griGuiaTransportista.Rows.Count > 0 Then
                    tabGuias.Tabs(0).Enabled = False
                    tabGuias.Tabs(1).Enabled = False
                    tabGuias.Tabs(2).Enabled = False
                Else
                    tabGuias.Tabs(0).Selected = True
                    tabGuias.Tabs(0).Enabled = True
                    tabGuias.Tabs(1).Enabled = True
                    txtGrt.Focus()
                End If
            End If
            ViajeVacio()
            IndGuardar = 1
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnLlegadaAproximadaDestinoE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLlegadaAproximadaDestinoE.Click
        Try
            If txtKmTractoOrigen.Value < 1 Then
                Throw New Exception("Ingrese KM Origen del Tracto")
            End If
            If verLlegadaDestinoE.Checked Then
                ValidaMarcacion()
            End If
            ValidarFechaServidor(fecLlegadaAproximadaDestinoE.Value)
            With oeSeguimiento
                .TipoOperacion = "7"
                .IdViaje = txtViajeId.Text
                .IdEstado = "TRANSITO"
                .LlegadaAproximadaDestino = Date.Parse(fecLlegadaAproximadaDestinoE.Value.ToShortDateString & " " & hLlegadaAproximadaDestinoE.Value.ToShortTimeString)
                .IndLlegadaAproximadaDestino = 1
            End With

            ValidaLlegadaAproximadaDestinoE(oeSeguimiento.LlegadaAproximadaDestino)
            oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olSeguimiento.Guardar(oeSeguimiento) Then
                verLlegadaAproximadaDestinoE.Checked = True
                Marcas()
                InformacionTractoCarreta(1, 0, 1, 0, 1, 0)
            End If
            ViajeVacio()

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnLlegadaDestinoE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLlegadaDestinoE.Click
        Try
            If txtKmTractoOrigen.Value < 1 Then
                Throw New Exception("Ingrese KM Origen del Tracto")
            End If
            If verIngresoDestinoE.Checked Then
                ValidaMarcacion()
            End If
            ValidarFechaServidor(fecLlegadaDestinoE.Value)
            With oeSeguimiento
                .TipoOperacion = "8"
                .IdViaje = txtViajeId.Text
                .IdEstado = "TRANSITO"
                .LlegadaDestino = Date.Parse(fecLlegadaDestinoE.Value.ToShortDateString & " " & hLlegadaDestinoE.Value.ToShortTimeString)
                .IndLlegadaDestino = 1
            End With

            ValidaLlegadaDestinoE(oeSeguimiento.LlegadaDestino)
            oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olSeguimiento.Guardar(oeSeguimiento) Then
                verLlegadaDestinoE.Checked = True
                Marcas()
                InformacionTractoCarreta(1, 0, 1, 0, 1, 0)
            End If
            ViajeVacio()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnIngresoDestinoE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresoDestinoE.Click
        Try
            If verDescargaDestinoE.Checked Then
                ValidaMarcacion()
            End If
            ValidarFechaServidor(fecIngresoDestinoE.Value)
            With oeSeguimiento
                .TipoOperacion = "9"
                .IdViaje = txtViajeId.Text
                .IdEstado = "DESCARGA"
                .IngresoDestino = Date.Parse(fecIngresoDestinoE.Value.ToShortDateString & " " & hIngresoDestinoE.Value.ToShortTimeString)
                .IndIngresoDestino = 1
            End With

            ValidaIngresoDestinoE(oeSeguimiento.IngresoDestino)
            oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olSeguimiento.Guardar(oeSeguimiento) Then
                verIngresoDestinoE.Checked = True
                Marcas()
                InformacionTractoCarreta(1, 0, 1, 0, 1, 0)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnDescargaDestinoE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDescargaDestinoE.Click
        Try
            If verTerminoDescargaDestinoE.Checked Then
                ValidaMarcacion()
            End If
            ValidarFechaServidor(fecDescargaDestinoE.Value)
            With oeSeguimiento
                .TipoOperacion = "X"
                .IdViaje = txtViajeId.Text
                .IdEstado = "DESCARGA"
                .DescargaDestino = Date.Parse(fecDescargaDestinoE.Value.ToShortDateString & " " & hDescargaDestinoE.Value.ToShortTimeString)
                .IndDescargaDestino = 1
            End With

            ValidaDescargaDestinoE(oeSeguimiento.DescargaDestino)
            oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olSeguimiento.Guardar(oeSeguimiento) Then
                verDescargaDestinoE.Checked = True
                Marcas()
                InformacionTractoCarreta(1, 0, 1, 0, 1, 0)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnTerminoDescargaDestinoE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTerminoDescargaDestinoE.Click
        Try
            If verSalidaDestinoE.Checked Then
                ValidaMarcacion()
            End If
            ValidarFechaServidor(fecTerminoDescargaDestinoE.Value)
            With oeSeguimiento
                .TipoOperacion = "O"
                .IdViaje = txtViajeId.Text
                .IdEstado = "DESCARGA"
                .TerminoDescargaDestino = Date.Parse(fecTerminoDescargaDestinoE.Value.ToShortDateString & " " & hTerminoDescargaDestinoE.Value.ToShortTimeString)
                .IndTerminoDescargaDestino = 1
            End With

            ValidaTerminoDescargaDestinoE(oeSeguimiento.TerminoDescargaDestino)
            oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olSeguimiento.Guardar(oeSeguimiento) Then
                verTerminoDescargaDestinoE.Checked = True
                Marcas()
                InformacionTractoCarreta(1, 1, 1, 0, 1, 0)
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnSalidaDestinoE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalidaDestinoE.Click
        Try
            If txtKmTractoOrigen.Value < 1 Then
                txtKmTractoOrigen.Focus()
                txtKmTractoOrigen.Select()
                Throw New Exception("Ingrese KM Origen del Tracto")
            End If
            If txtKmTractoDestino.Value < 1 Then
                InformacionTractoCarreta(1, 1, 1, 1, 1, 1)
                txtKmTractoDestino.Focus()
                txtKmTractoDestino.Select()
                Throw New Exception("Ingrese KM Destino del Tracto")
            End If
            ValidarFechaServidor(fecSalidaDestinoE.Value)
            With oeSeguimiento
                .TipoOperacion = "D"
                .IdViaje = txtViajeId.Text
                .IdEstado = "FIN"
                .SalidaDestino = Date.Parse(fecSalidaDestinoE.Value.ToShortDateString & " " & hSalidaDestinoE.Value.ToShortTimeString)
                .IndSalidaDestino = 1
            End With

            ValidaSalidaDestinoE(oeSeguimiento.SalidaDestino)
            oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olSeguimiento.Guardar(oeSeguimiento) Then
                verSalidaDestinoE.Checked = True
                InformacionTractoCarreta(1, 1, 1, 1, 1, 1)
                SalidaDestinoIndicador = True
            End If
            ViajeVacio()
            IndGuardar = 1
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griLista_ClickCellButton(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griLista.ClickCellButton
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim Mensaje As String
            olSeguimiento = New l_Seguimiento
            olUsuarioPerfil = New l_UsuarioPerfil
            olPerfil = New l_Perfil
            Select Case e.Cell.Column.Key
                Case "Piloto"
                    Dim formulario As frm_FichaPersonal
                    formulario = frm_FichaPersonal
                    formulario.IndCambioPestaña = False
                    If formulario.MostrarTrabajador(griLista.ActiveRow.Cells("IdPiloto").Value) Then formulario.ShowDialog()
                    ControlBoton(1, 0, 1, 0, 0, 1, 1, 1, 1)
                Case "IncidenciaSeguimiento"
                    oeSeguimiento = New e_Seguimiento
                    With oeSeguimiento
                        .TipoOperacion = "R"
                        .Id = griLista.ActiveRow.Cells("Id").Value
                        .UsuarioCreacion = gUsuarioSGI.Id
                        .LlegadaOrigen = Date.Now
                        .IngresoComplejoOrigen = Date.Now
                        .CargaOrigen = Date.Now
                        .TerminoCargaOrigen = Date.Now
                        .ImpresionGuiaOrigen = Date.Now
                        .SalidaOrigen = Date.Now
                        .LlegadaAproximadaDestino = Date.Now
                        .LlegadaDestino = Date.Now
                        .IngresoDestino = Date.Now
                        .DescargaDestino = Date.Now
                        .TerminoDescargaDestino = Date.Now
                        .SalidaDestino = Date.Now
                        Mensaje = griLista.ActiveRow.Cells("IncidenciaSeguimiento").Value
                        .Incidencia = Mensaje
                    End With
                    oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olSeguimiento.Guardar(oeSeguimiento) Then
                        mensajeEmergente.Confirmacion("La Informacion ha sido grabada Satisfactoriamente; " & Mensaje, True)
                    End If
                    oeUsuarioPerfil = New e_UsuarioPerfil
                    oeUsuarioPerfil.oeUsuario.Id = gUsuarioSGI.Id
                    oeUsuarioPerfil.Principal = 1
                    oeUsuarioPerfil = olUsuarioPerfil.Obtener(oeUsuarioPerfil)
                    oePerfil = New e_Perfil
                    With oePerfil
                        .TipoOperacion = "M"
                        .Id = oeUsuarioPerfil.oePerfil.Id
                        .Codigo = Mensaje
                        .Nombre = "Area: Call Center Comunica, " & "Viaje: " & griLista.ActiveRow.Cells("Codigo").Value & ", Usuario: " & gUsuarioSGI.oePersona.NombreCompleto & ", Dice: " & Mensaje
                    End With
                    oePerfil.PrefijoID = gs_PrefijoIdSucursal '@0001
                    olPerfil.Guardar(oePerfil)
                    ControlBoton(1, 0, 1, 0, 0, 1, 1, 1, 1)
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

    Private Sub griGuiaRemitente_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griGuiaRemitente.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show(Me.Text & ": ¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
            'Exit Sub
        End If
    End Sub

    Private Sub griGuiaTransportistaDetalle_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs)
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griViajeDetalle_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griViajeDetalle.CellChange
        griViajeDetalle.UpdateData()
        Select Case e.Cell.Column.Key
            Case "PesoToneladas"
                CalcularPesoToneladas()
        End Select
    End Sub

    Private Sub mnuViajeInterrumpido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Interrumpir.Click
        With griGuiaTransportista.ActiveRow
            txtIdGuiaTransportista.Text = .Cells("Id").Value
            txtGuiaTransportista.Text = .Cells("Serie").Value & "-" & .Cells("Numero").Value
            tabGuias.Tabs(1).Selected = True
        End With
    End Sub

    Private Sub btnAgregarInterrumpido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarInterrumpido.Click
        AgregarViajeInterrumpido()
    End Sub

    Private Sub griViajeDetalle_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griViajeDetalle.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griViajeInterrumpido_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griViajeInterrumpido.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show(Me.Text & ": ¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
            'Exit Sub
        End If
    End Sub

    Private Sub griViajeInterrumpido_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griViajeInterrumpido.CellChange
        griViajeInterrumpido.UpdateData()
    End Sub

    Private Sub griGuiaRemitente_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griGuiaRemitente.CellChange
        griGuiaRemitente.UpdateData()
    End Sub

    Private Sub btnTerminoCargaOrigen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTerminoCargaOrigen.Click
        Try
            If verSalidaOrigen.Checked Then
                ValidaMarcacion()
            End If
            ValidarFechaServidor(fecTerminoCargaOrigen.Value)
            With oeSeguimiento
                .TipoOperacion = "4"
                .IdViaje = txtViajeId.Text
                .IdEstado = "CARGA"
                .TerminoCargaOrigen = Date.Parse(fecTerminoCargaOrigen.Value.ToShortDateString & " " & hTerminoCargaOrigen.Value.ToShortTimeString)
                .IndTerminoCargaOrigen = 1
            End With

            ValidaTerminoCargaOrigen(oeSeguimiento.TerminoCargaOrigen)
            oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olSeguimiento.Guardar(oeSeguimiento) Then
                verTerminoCargaOrigen.Checked = True
                Marcas()
                InformacionTractoCarreta(0, 0, 0, 0, 0, 0)
                fecEmisionGrt.Value = fecTerminoCargaOrigen.Value
                fecEmisionGrr.Value = fecTerminoCargaOrigen.Value
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnTerminoDescargaDestino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTerminoDescargaDestino.Click
        Try
            If verSalidaDestino.Checked Then
                ValidaMarcacion()
            End If
            ValidarFechaServidor(fecTerminoDescargaDestino.Value)
            With oeSeguimiento
                .TipoOperacion = "O"
                .IdViaje = txtViajeId.Text
                .IdEstado = "DESCARGA"
                .TerminoDescargaDestino = Date.Parse(fecTerminoDescargaDestino.Value.ToShortDateString & " " & hTerminoDescargaDestino.Value.ToShortTimeString)
                .IndTerminoDescargaDestino = 1
            End With

            ValidaTerminoDescargaDestino(oeSeguimiento.TerminoDescargaDestino)
            oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olSeguimiento.Guardar(oeSeguimiento) Then
                verTerminoDescargaDestino.Checked = True
                Marcas()
                InformacionTractoCarreta(1, 1, 1, 0, 1, 0)
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtKmTractoDestino_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKmTractoDestino.TextChanged
        KilometrosCarreta()
    End Sub

    Private Sub txtGrt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGrt.KeyPress
        e.Handled = EvaluarValorIngresado(sender, e)
    End Sub

    Private Sub txtGrr_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGrr.KeyPress
        e.Handled = EvaluarValorIngresado(sender, e)
    End Sub

    Private Sub txtRangoGrr_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRangoGrr.KeyPress
        e.Handled = EvaluarValorIngresado(sender, e)
    End Sub

    Private Sub hLlegadaOrigen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hLlegadaOrigen.Click
        hLlegadaOrigen.SelectAll()
    End Sub

    Private Sub hCargaOrigen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hCargaOrigen.Click
        hCargaOrigen.SelectAll()
    End Sub

    Private Sub hTerminoCargaOrigen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hTerminoCargaOrigen.Click
        hTerminoCargaOrigen.SelectAll()
    End Sub

    Private Sub hSalidaOrigen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hSalidaOrigen.Click
        hSalidaOrigen.SelectAll()
    End Sub

    Private Sub hLlegadaDestino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hLlegadaDestino.Click
        hLlegadaDestino.SelectAll()
    End Sub

    Private Sub hDescargaDestino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hDescargaDestino.Click
        hDescargaDestino.SelectAll()
    End Sub

    Private Sub hTerminoDescargaDestino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hTerminoDescargaDestino.Click
        hTerminoDescargaDestino.SelectAll()
    End Sub

    Private Sub hSalidaDestino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hSalidaDestino.Click
        hSalidaDestino.SelectAll()
    End Sub

    Private Sub hLlegadaOrigenE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hLlegadaOrigenE.Click
        hLlegadaOrigenE.SelectAll()
    End Sub

    Private Sub hIngresoComplejoOrigenE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hIngresoComplejoOrigenE.Click
        hIngresoComplejoOrigenE.SelectAll()
    End Sub

    Private Sub hCargaOrigenE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hCargaOrigenE.Click
        hCargaOrigenE.SelectAll()
    End Sub

    Private Sub hTerminoCargaOrigenE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hTerminoCargaOrigenE.Click
        hTerminoCargaOrigenE.SelectAll()
    End Sub

    Private Sub hImpresionGuiaOrigenE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hImpresionGuiaOrigenE.Click
        hImpresionGuiaOrigenE.SelectAll()
    End Sub

    Private Sub hSalidaOrigenE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hSalidaOrigenE.Click
        hSalidaOrigenE.SelectAll()
    End Sub

    Private Sub hLlegadaAproximadaDestinoE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hLlegadaAproximadaDestinoE.Click
        hLlegadaAproximadaDestinoE.SelectAll()
    End Sub

    Private Sub hLlegadaDestinoE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hLlegadaDestinoE.Click
        hLlegadaDestinoE.SelectAll()
    End Sub

    Private Sub hIngresoDestinoE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hIngresoDestinoE.Click
        hIngresoDestinoE.SelectAll()
    End Sub

    Private Sub hDescargaDestinoE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hDescargaDestinoE.Click
        hDescargaDestinoE.SelectAll()
    End Sub

    Private Sub hTerminoDescargaDestinoE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hTerminoDescargaDestinoE.Click
        hTerminoDescargaDestinoE.SelectAll()
    End Sub

    Private Sub hSalidaDestinoE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hSalidaDestinoE.Click
        hSalidaDestinoE.SelectAll()
    End Sub

    Private Sub hViaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hViaje.Click
        hViaje.SelectAll()
    End Sub

    Private Sub txtObservacion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtObservacion.TextChanged
        btnEnviarCorreo.Visible = False
    End Sub

    Private Sub txtObservacion_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtObservacion.Leave
        btnEnviarCorreo.Visible = True
    End Sub

    Private Sub txtObservacion_Layout(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles txtObservacion.Layout
        btnEnviarCorreo.Visible = True
    End Sub

    Private Sub txtObservacion_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtObservacion.MouseLeave
        btnEnviarCorreo.Visible = True
    End Sub

    Private Sub griLista_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griLista.CellChange
        griLista.UpdateData()
    End Sub

    Private Sub griLista_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles griLista.BeforeCellUpdate
        With griLista
            Select Case e.Cell.Column.Key
                Case "IncidenciaSeguimiento"
                    If e.Cell.Column.Key = "IncidenciaSeguimiento" Then If IsDBNull(e.NewValue) Then e.Cancel = True
            End Select
        End With
    End Sub

    Private Sub txtKmTractoDestino_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKmTractoDestino.Validated
        ValidaKilometrajeDestino()
    End Sub

    Private Sub txtHorasTractoDestino_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHorasTractoDestino.Validated
        Dim HorasOrigen As Double
        Dim HorasDestino As Double

        HorasOrigen = txtHorasTractoOrigen.Value
        HorasDestino = txtHorasTractoDestino.Value

        If HorasOrigen >= HorasDestino Then
            txtHorasTractoDestino.Focus()
            txtHorasTractoDestino.SelectAll()
            mensajeEmergente.Problema("Las Horas destino marcado es inferior o Igual ala Horas origen", True)
        End If
    End Sub

    ''' <summary>
    ''' Envia email de control cuando call center desea reportar algún suceso a sistemas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    ''' 
    'Async
    Private Sub btnEnviarCorreo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarCorreo.Click
        'Try
        '    If MessageBox.Show("Desea enviar el mail:  ?", _
        '                        "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
        '        If EnviarEmail("consultores.tecnologicos.2010@gmail.com", "consultores.tecnologicos.2010@gmail.com", "", "", "Call Center Informa", txtObservacion.Text, "", True) Then
        '            Await MensajePC("email enviado")
        '            mensajeEmergente.Confirmacion("Se envió un email al área de Sistemas ISL", True)
        '        End If
        '    End If
        '    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        'Catch ex As Exception
        '    mensajeEmergente.Problema(ex.Message, True)
        'End Try    

        Try
            Dim formulario As frm_EnvioEmail
            formulario = New frm_EnvioEmail
            formulario.Modulo = "Seguimiento"
            formulario.bandFrmExterno = "SI"
            formulario.cadenaMensaje = txtObservacion.Text
            formulario.asunto = "Incidencias OP"
            formulario.cantMensajes = 1
            formulario.ShowDialog()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtGrt_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGrt.Validated
        Try
            If txtGrt.Text <> "" Then ValidarGuiaTransportista(txtGrt)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
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

    Private Sub frm_Seguimiento_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update.Click
        Editar()
    End Sub

    Private Sub EventoViaje_Click(sender As Object, e As EventArgs) Handles EventoViaje.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If griLista.Selected.Rows.Count > 0 AndAlso griLista.ActiveRow.Index >= 0 Then
                Dim idViaje As String = griLista.ActiveRow.Cells("Id").Value
                Dim Formulario As frm_RegistroEventosViaje = frm_RegistroEventosViaje.getInstancia
                Formulario.MdiParent = frm_Menu
                Formulario.Show()
                Formulario.CargarNuevoEvento(idViaje)
                ugb_Espera.Visible = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub SeguimientoMonitoreo_Click(sender As Object, e As EventArgs) Handles SeguimientoMonitoreo.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If griLista.Selected.Rows.Count > 0 AndAlso griLista.ActiveRow.Index >= 0 Then
                Dim idViaje As String = griLista.ActiveRow.Cells("Id").Value
                Dim Formulario As frm_RegistroSeguimiento = frm_RegistroSeguimiento.getInstancia
                Formulario.MdiParent = frm_Menu
                Formulario.Show()
                Formulario.CargarNuevoSeguimiento(idViaje)
                ugb_Espera.Visible = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub SeguimientoRapido_Click(sender As Object, e As EventArgs) Handles SeguimientoRapido.Click
        Try
            If griLista.Selected.Rows.Count > 0 AndAlso griLista.ActiveRow.Index >= 0 Then
                Dim idViaje As String = griLista.ActiveRow.Cells("Id").Value
                Dim Formulario As New frm_RegistroSeguimiento
                Formulario.IdViaje = idViaje.Trim
                Formulario.ShowDialog()
                Formulario.Dispose()
                Formulario.Close()
                ControlBoton(1, 0, 1, 0, 0, 0, 1, 1, 1)
                'ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Menu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Menu.Opening
        If gUsuarioSGI.oeArea.Nombre = gNombreAreaPlaneamientoControl Or gUsuarioSGI.oeArea.Nombre = gNombreAreaInformaticaSistemas Then
            If griLista.Selected.Rows.Count > 0 Then
                Menu.Items("Update").Visible = True
            Else
                Menu.Items("Update").Visible = False
            End If
        Else
            Menu.Items("Update").Visible = False
        End If

    End Sub

    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click
        Try
            Dim IdViaje As String
            Dim CodViaje As String
            Dim IdTracto As String
            Dim Placa1 As String
            Dim IdPiloto As String
            Dim FechaViaje As String
            Dim NombreCompleto As String
            Dim KmTractoOrigen As String
            Dim KmTractoDestino As String

            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            IdViaje = griListadoTanqueo.ActiveRow.Cells("IdViaje").Value.ToString
            CodViaje = griListadoTanqueo.ActiveRow.Cells("CodViaje").Value.ToString
            IdTracto = griListadoTanqueo.ActiveRow.Cells("IdTracto").Value.ToString
            Placa1 = griListadoTanqueo.ActiveRow.Cells("Placa1").Value.ToString
            IdPiloto = griListadoTanqueo.ActiveRow.Cells("IdPiloto").Value.ToString
            FechaViaje = griListadoTanqueo.ActiveRow.Cells("FechaViaje").Value.ToString
            NombreCompleto = griListadoTanqueo.ActiveRow.Cells("NombreCompleto").Value.ToString
            KmTractoOrigen = griListadoTanqueo.ActiveRow.Cells("KmTractoOrigen").Value.ToString
            KmTractoDestino = griListadoTanqueo.ActiveRow.Cells("KmTractoDestino").Value.ToString
            Dim Combustible As New frm_RegistroConsumoCombustible
            Combustible = Combustible.getInstancia()
            Combustible.MdiParent = frm_Menu
            Combustible.Show()
            Combustible.SeguimientoCombustible(IdViaje, _
                                                 CodViaje, _
                                                 IdTracto, _
                                                 Placa1, _
                                                 IdPiloto, _
                                                 FechaViaje, _
                                                 NombreCompleto, _
                                                 KmTractoOrigen, _
                                                 KmTractoDestino)
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub griListadoTanqueo_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListadoTanqueo.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub Actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar.Click
        If MenuCombustible.SourceControl Is griListadoTanqueo Then
            If griListadoTanqueo.ActiveRow.Band.Index = 2 Then
                Try
                    Dim Id As String
                    Dim KmTractoOrigen As String
                    Dim KmTractoDestino As String
                    Dim FechaViaje As Date
                    Dim Estado As String

                    ugb_Espera.Visible = True
                    Application.DoEvents()
                    Cursor.Current = Cursors.WaitCursor
                    Cursor.Show()
                    Id = griListadoTanqueo.ActiveRow.Cells("Id").Value.ToString
                    KmTractoOrigen = griListadoTanqueo.ActiveRow.Cells("KmTractoOrigen").Value
                    KmTractoDestino = griListadoTanqueo.ActiveRow.Cells("KmTractoDestino").Value
                    FechaViaje = griListadoTanqueo.ActiveRow.Cells("FechaViaje").Value.ToString
                    Estado = griListadoTanqueo.ActiveRow.Cells("Estado").Value.ToString
                    Dim Combustible As New frm_RegistroConsumoCombustible
                    Combustible = Combustible.getInstancia()
                    Combustible.MdiParent = frm_Menu
                    Combustible.Show()
                    Combustible.SeguimientoCombustibleEditar(Id, _
                                                         KmTractoOrigen, _
                                                         KmTractoDestino, _
                                                         FechaViaje, _
                                                         Estado)
                    ugb_Espera.Visible = False
                Catch ex As Exception
                    mensajeEmergente.Problema(ex.Message, True)
                Finally
                    Windows.Forms.Cursor.Current = Cursors.Default
                    Cursor.Show()
                    ugb_Espera.Visible = False
                End Try
            Else
                mensajeEmergente.Problema("Para editar un tanqueo ubiquese en el 3 nivel", True)
            End If
        End If
    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        If MenuCombustible.SourceControl Is griListadoTanqueo Then
            If griListadoTanqueo.ActiveRow.Band.Index = 2 Then

                Try
                    Dim Id As String
                    Dim Estado As String
                    ugb_Espera.Visible = True
                    Application.DoEvents()
                    Cursor.Current = Cursors.WaitCursor
                    Cursor.Show()
                    Id = griListadoTanqueo.ActiveRow.Cells("Id").Value.ToString
                    Estado = griListadoTanqueo.ActiveRow.Cells("Estado").Value
                    olRegConsumoCombustible = New l_RegistroConsumoCombustible
                    oeRegConsumoCombustible = New e_RegistroConsumoCombustible
                    oeRegConsumoCombustible.Id = Id
                    oeRegConsumoCombustible.TipoOperacion = 2
                    oeRegConsumoCombustible = olRegConsumoCombustible.Obtener(oeRegConsumoCombustible)

                    If oeRegConsumoCombustible.Activo And Estado = "SIN" Then
                        If MessageBox.Show("Esta seguro de eliminar el Registro de Consumo de Combustible: ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeRegConsumoCombustible.TipoOperacion = "E"
                            olRegConsumoCombustible.Eliminar(oeRegConsumoCombustible)
                            griListadoTanqueo.ActiveRow.Delete()
                        End If
                    Else
                        Throw New Exception("El tanqueo no se puede eliminar por su estado:" & Estado)
                    End If
                    ugb_Espera.Visible = False
                Catch ex As Exception
                    mensajeEmergente.Problema(ex.Message, True)
                Finally
                    Windows.Forms.Cursor.Current = Cursors.Default
                    Cursor.Show()
                    ugb_Espera.Visible = False
                End Try
            Else
                mensajeEmergente.Problema("Para Eliminar un tanqueo ubiquese en el 3 nivel", True)
            End If
        End If
    End Sub

    Private Sub txtKmTractoOrigen_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKmTractoOrigen.Validated
        ValidaKilometrajeOrigen()
    End Sub

    Private Sub cboRemitente_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRemitente.Validated
        If Operacion = "Editar" Then
            olDireccionEmpresa = New l_Combo
            cboPuntoPartida.Items.Clear()
            oeDireccionEmpresa = New e_Combo
            oeDireccionEmpresa.Nombre = "DireccionEmpresa"
            oeDireccionEmpresa.Id = cboRemitente.Value
            LlenarComboMaestro(cboPuntoPartida, olDireccionEmpresa.Listar(oeDireccionEmpresa), 0)
        End If
    End Sub

    Private Sub cboDestinatario_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDestinatario.Validated
        If Operacion = "Editar" Then
            olDireccionEmpresa = New l_Combo
            cboPuntoLlegada.Items.Clear()
            oeDireccionEmpresa = New e_Combo
            oeDireccionEmpresa.Nombre = "DireccionEmpresa"
            oeDireccionEmpresa.Id = cboDestinatario.Value
            LlenarComboMaestro(cboPuntoLlegada, olDireccionEmpresa.Listar(oeDireccionEmpresa), 0)
        End If
    End Sub

    Private Sub MenuCombustible_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuCombustible.Opening
        MenuCombustible.Items("Nuevo").Visible = True
        If griListadoTanqueo.Selected.Rows.Count > 0 Then
            MenuCombustible.Items("Actualizar").Visible = True
            MenuCombustible.Items("Eliminar").Visible = True
        Else
            MenuCombustible.Items("Actualizar").Visible = False
            MenuCombustible.Items("Eliminar").Visible = False
        End If
    End Sub

    Private Sub MenuGuiaTransportista_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuGuiaTransportista.Opening
        If griGuiaTransportista.Selected.Rows.Count > 0 Then
            MenuGuiaTransportista.Items("Interrumpir").Visible = True
            MenuGuiaTransportista.Items("Delete").Visible = True
        Else
            MenuGuiaTransportista.Items("Interrumpir").Visible = False
            MenuGuiaTransportista.Items("Delete").Visible = False
        End If
    End Sub

    Private Sub MenuGuiaRemitente_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuGuiaRemitente.Opening
        If griGuiaRemitente.Selected.Rows.Count > 0 Then
            MenuGuiaRemitente.Items("Quitar").Visible = True
        Else
            MenuGuiaRemitente.Items("Quitar").Visible = False
        End If
    End Sub

    Private Sub Quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Quitar.Click
        If griGuiaRemitente.Rows.Count > 0 Then
            griGuiaRemitente.ActiveRow.Delete()
        End If
    End Sub

    Private Sub griListadoTanqueo_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListadoTanqueo.CellChange
        griListadoTanqueo.UpdateData()
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

    Private Sub griViajeDetalle_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griViajeDetalle.AfterCellUpdate
        Try
            Select Case e.Cell.Column.Key
                Case "PesoToneladas"
                    With griViajeDetalle.Rows(e.Cell.Row.Index)
                        If .Cells("Carga").Text = "TONELADA" Then
                            If .Cells("PesoToneladas").Value > 10 Then
                                Dim PT As Double
                                Dim PTmas20 As Double
                                Dim PTmenos20 As Double
                                PT = .Cells("PesoToneladas").Value
                                PTmas20 = (.Cells("Cantidad").Value + .Cells("Cantidad").Value * 0.2)
                                PTmenos20 = (.Cells("Cantidad").Value - .Cells("Cantidad").Value * 0.2)
                                If .Cells("PesoToneladas").Value > PTmas20 Then
                                    'Await MensajePC("Peso excesivo")
                                    Throw New Exception("Peso Toneladas excede en 20% a lo programado por operaciones")
                                End If
                                If .Cells("PesoToneladas").Value < PTmenos20 Then
                                    'Await MensajePC("Peso excesivo")
                                    Throw New Exception("Cantidad programada excede en 20% al Peso Tonelada Ingresado")
                                End If
                            End If
                        End If
                    End With
            End Select
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
                                                     Me.Text, lista1, gUsuarioSGI.Id, "A",
                                                     lista2, lista3, "", "I", True))
                Else
                    Dim indicolm = existeColumna(e.Cell.Column.Key, indLista)
                    If indicolm <> -1 Then
                        '  ListaBitacora.Item(indLista).ColumnasAfectadas.Item(indicolm) = e.Cell.Column.Key ' glosasGeneral(indArrayGlosas, 0)
                        '  ListaBitacora.Item(indLista).ValoresAnteriores.Item(indicolm) = columnas(e.Cell.Column.Index).ToString ' glosasGeneral(indArrayGlosas, 1)
                        ListaBitacora.Item(indLista).ValoresActuales.Item(indicolm) = e.Cell.Text.ToString ' glosasGeneral(indArrayGlosas, 2)
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
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
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

    Private Sub txtGlosa_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa.Validated
        Try
            Dim NroCarga As String
            Dim NroCargaDigitos As String
            If cboRemitente.Text = "SUPERMERCADOS PERUANOS S.A." Then
                NroCarga = txtGlosa.Text.Trim
                NroCargaDigitos = Microsoft.VisualBasic.Left(NroCarga, 3)
                If NroCarga <> "" Then
                    If NroCargaDigitos = "OSF" Or NroCargaDigitos = "SPF" Then
                        If (NroCarga.Length - 3) <> 11 Then
                            txtGlosa.Focus()
                            Throw New Exception("Longitud de caracteres despues de OSF/SPF son de 11 digistos enteros Ejemplo: OSF00300034412 / SPF00300034412")
                        End If
                        If Not IsNumeric(Microsoft.VisualBasic.Right(NroCarga, 11)) Then
                            txtGlosa.Focus()
                            Throw New Exception("Longitud de caracteres despues de OSF/SPF son de 11 digistos enteros Ejemplo: OSF00300034412 / SPF00300034412")
                        End If
                    Else
                        If NroCarga.Length < 8 Or NroCarga.Length > 10 Then
                            txtGlosa.Focus()
                            Throw New Exception("Longitud de caracteres son de mayor 8 y menor 10 digistos enteros por Ejemplo: 0000034412")
                        End If
                        If Not IsNumeric(NroCarga) Then
                            txtGlosa.Focus()
                            Throw New Exception("Longitud de caracteres son de 8 digistos enteros por Ejemplo: 00034412")
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnSinReportarUnidades_Click(sender As Object, e As EventArgs) Handles btnSinReportarUnidades.Click
        Try
            olCombo = New l_Combo
            oeCombo = New e_Combo
            oeCombo.Id = numOPSinReportar.Value
            oeCombo.Nombre = "SINREPORTARUNIDADES"
            gridUnidadesSinReportar.DataSource = olCombo.Listar(oeCombo)
            gruopExpanUnidadesSinReportar.Expanded = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gridUnidadesSinReportar_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles gridUnidadesSinReportar.BeforeRowsDeleted
        e.Cancel = True
        e.DisplayPromptMsg = False
    End Sub

    Private Sub btnCorreoFalla_Click(sender As Object, e As EventArgs) Handles btnCorreoFalla.Click
        'Try
        '    If verIndFallaOP.Checked Then
        '        Dim MensajeCorreo As String = ""
        '        Dim formulario As frm_EnvioCorreo
        '        formulario = frm_EnvioCorreo
        '        MensajeCorreo = "Incidencia en Viaje: " & txtViajeCodigo.Text & Environment.NewLine & _
        '                        " *** Fecha Viaje: " & fecViaje.DateTime.Date.ToString & Environment.NewLine & _
        '                        " *** Ruta : " & OrigenViaje & " - " & DestinoViaje & Environment.NewLine & _
        '                        " *** Piloto : " & txtViajePiloto.Text & Environment.NewLine & _
        '                        " *** Fecha Detecto Incidencia : " & Date.Parse(fecFalla.Value.ToShortDateString & " " & hFalla.Value.ToShortTimeString).ToString & Environment.NewLine & _
        '                        " *** OBSERVACION : " & txtGlosaFalla.Text & Environment.NewLine & _
        '                        " .................................................................................... " & Environment.NewLine & _
        '                        " USURIO REPORTA : " & gUsuarioSGI.oePersona.NombreCompleto

        '        formulario.Modulo = "Seguimiento"
        '        formulario.MensajeCorreo = MensajeCorreo
        '        formulario.ShowDialog()
        '        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        '    End If
        'Catch ex As Exception
        '    mensajeEmergente.Confirmacion(ex.Message, True)
        'End Try
        Dim MensajeCorreo As String = "Incidencia en Viaje: " & txtViajeCodigo.Text & Environment.NewLine & _
                               " *** Fecha Viaje: " & fecViaje.DateTime.Date.ToString & Environment.NewLine & _
                               " *** Ruta : " & OrigenViaje & " - " & DestinoViaje & Environment.NewLine & _
                               " *** Piloto : " & txtViajePiloto.Text & Environment.NewLine & _
                               " *** Fecha Detecto Incidencia : " & Date.Parse(fecFalla.Value.ToShortDateString & " " & hFalla.Value.ToShortTimeString).ToString & Environment.NewLine & _
                               " *** OBSERVACION : " & txtGlosaFalla.Text & Environment.NewLine & _
                               " .................................................................................... " & Environment.NewLine & _
                               " USUARIO REPORTA : " & gUsuarioSGI.oePersona.NombreCompleto
        Try
            Dim formulario As frm_EnvioEmail
            formulario = New frm_EnvioEmail
            formulario.Modulo = "Seguimiento"
            formulario.bandFrmExterno = "SE"
            formulario.cadenaMensaje = MensajeCorreo
            formulario.asunto = "Fallas OP"
            formulario.cantMensajes = 1
            formulario.ShowDialog()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
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

    Private Sub tabListado_SelectedTabChanged(sender As Object, e As UltraWinTabControl.SelectedTabChangedEventArgs) Handles tabListado.SelectedTabChanged
        Try
            Select Case tabListado.SelectedTab.Index
                Case tapViajes.Tab.Index
                    If griLista.Rows.Count > 0 Then
                        ControlBoton(1, 0, 1, 0, 0, 0, 1, 1, 1)
                    Else
                        ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                    End If
                Case tapAlertaViajes.Tab.Index
                    If griAlertaViajes.Rows.Count > 0 Then
                        ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                    Else
                        ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griAlertaViajes_ClickCellButton(sender As Object, e As CellEventArgs) Handles griAlertaViajes.ClickCellButton
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Select Case e.Cell.Column.Key
                Case "Piloto"
                    Dim formulario As frm_FichaPersonal
                    formulario = frm_FichaPersonal
                    formulario.IndCambioPestaña = False
                    If formulario.MostrarTrabajador(griAlertaViajes.ActiveRow.Cells("IdPiloto").Value) Then formulario.ShowDialog()
                    ControlBoton(1, 0, 1, 0, 0, 1, 1, 1, 1)
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Const strPermisoRegresarProgramado As String = "CAMBIAR ESTADO DE VIAJE A PROGRAMADO"
    Private Sub itemProgramado_Click(sender As Object, e As EventArgs) Handles itemProgramado.Click
        Dim olTrabajadorSeg As New l_TrabajadorSeguridad
        Dim oeViaje As New e_Viaje
        Try
            'Validar Diferencia de Fecha Actual y Fecha de Viaje = '>=' 2 semanas 
            If olTrabajadorSeg.Permisos(gUsuarioSGI.IdTrabajador, strPermisoRegresarProgramado) Then
                If gf_ValidarFilaSeleccionada(griLista) AndAlso _
                    griLista.ActiveRow.Cells("IdEstado").Value <> IdEstadoProgramado AndAlso _
                    MessageBox.Show("¿Desea regresar a estado programado el viaje " & griLista.ActiveRow.Cells("Codigo").Value.ToString() & "?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    oeViaje.TipoOperacion = "S"
                    oeViaje.Id = griLista.ActiveRow.Cells("Id").Value.ToString()
                    oeViaje.IdEstado = IdEstadoProgramado
                    oeViaje.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olOperacion.GuardarViaje(oeViaje) Then
                        MessageBox.Show("Operacion realizada con éxito", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        griLista.ActiveRow.CellAppearance.BackColor = Me.colorCambio.Color
                    End If
                End If
            Else
                MessageBox.Show("Usted no tiene permiso para realizar esta operación", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            olTrabajadorSeg = Nothing
            oeViaje = Nothing
        End Try
    End Sub

#End Region

#Region "Métodos"

    Private Sub ColorControles()
        '----------------------------------------------
        '------Tipo de Vehiculo------------------------
        ColorPlataforma.Color = Color.Coral
        ColorFurgonLargo.Color = Color.PeachPuff
        ColorMediaBaranda.Color = Color.Orange
        ColorFurgon.Color = Color.Gold
        ColorCalicera.Color = Color.DarkKhaki
        ColorContenedor.Color = Color.OliveDrab
        ColorGranelero.Color = Color.YellowGreen
        ColorParihuelero.Color = Color.PaleGreen
        ColorTolvaVolteo.Color = Color.RosyBrown
        ColorVolquete.Color = Color.Peru
        ColorCamioneta.Color = Color.LightGreen
        ColorCamion65M3.Color = Color.MediumSpringGreen
        ColorCamion20M3.Color = Color.PaleTurquoise
        ColorCamion30M3.Color = Color.DeepSkyBlue
        ColorCamion40M3.Color = Color.Violet
        '----------------------------------------------
        '------Estados de Viaje------------------------
        ColorProgramado.Color = Color.White
        ColorCarga.Color = Color.Yellow
        ColorTransito.Color = Color.DarkOrange
        ColorDescarga.Color = Color.Silver
        ColorFin.Color = Color.LimeGreen
        '----------------------------------------------
        '------Cambio de Registro------------------------
        colorCambio.Color = Color.Cyan
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

    Private Sub ControlRangoFechaInicializa()
        fecDesde.Value = Date.Today.AddDays(-5)
        fecHasta.Value = Date.Today.AddDays(+1)
    End Sub

    Private Sub InformacionTractoCarreta(ByVal KmTractoOrigen As Boolean, _
                            ByVal KmTractoDestino As Boolean, _
                           ByVal HoraTractoOrigen As Boolean, _
                           ByVal HoraTractoDestino As Boolean, _
                           ByVal KmCarretaOrigen As Boolean, _
                           ByVal KmCarretaDestino As Boolean)
        txtKmTractoOrigen.Enabled = KmTractoOrigen
        txtKmTractoDestino.Enabled = KmTractoDestino
        txtHorasTractoOrigen.Enabled = HoraTractoOrigen
        txtHorasTractoDestino.Enabled = HoraTractoDestino
        txtKmCarretaOrigen.Enabled = KmCarretaOrigen
        txtKmCarretaDestino.Enabled = KmCarretaDestino
    End Sub

    Private Sub Inicializar()
        txtSeguimientoId.Text = String.Empty
        txtViajeCodigo.Text = String.Empty
        txtCliente.Text = "CLIENTES: "
        fecViaje.DateTime = Date.Today
        txtViajePiloto.Text = String.Empty
        txtViajeRuta.Text = String.Empty
        txtViajeTracto.Text = String.Empty
        txtViajeCarreta.Text = String.Empty
        txtIdCarreta.Text = String.Empty
        txtIdTracto.Text = String.Empty
        txtKmTractoOrigen.Value = 0.0
        txtKmTractoDestino.Value = 0.0
        txtKmCarretaOrigen.Value = 0.0
        txtKmCarretaDestino.Value = 0.0
        txtHorasTractoOrigen.Value = 0.0
        txtHorasTractoDestino.Value = 0.0
        txtGrtPT.Value = 0.0
        txtPesoToneladas.Value = 0.0
        txtGrt.Text = String.Empty
        txtGrr.Text = String.Empty
        txtRangoGrr.Text = String.Empty
        txtGlosa.Text = ""
        LimpiaGrid(griGuiaTransportista, ogdGuiaTransportista)
        LimpiaGrid(griGuiaRemitente, ogdGuiaRemitente)
        LimpiaGrid(griViajeInterrumpido, ogdGuiaTransportistaInterrumpido)
        LimpiaGrid(griViajeDetalle, ogdOperacionDetalle)

        'Glosas
        GlosaDetalleDemanda = ""
        ValoresAnterioresDetalleDemanda = ""
        ValoresActualesDetalleDemanda = ""
        ListaBitacora.Clear()

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

    End Sub

    Public Sub LlenaCombos()
        Try
            LlenarComboMaestro(cboRemitente, ClientesPublic, 0)
            LlenarComboMaestro(cboDestinatario, ClientesPublic, 0)
            LlenarComboMaestro(cboMotivoTrasladoInterrumpido, MotivoDocumentoPublic, 0)
            LlenarCombo(cboTractoLista, "Nombre", TractoPublic, -1)
            LlenarCombo(cboTractoImportar, "Nombre", TractoPublic, -1)
            LlenarComboMaestro(cboCentro, CentroPublic, 0)
            LlenarComboMaestro(cboCentroImportar, CentroPublic, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboGrilla()
        Dim Lugar As New DataTable
        Dim Cliente As New DataTable
        olCombo = New l_Combo
        Cliente = olCombo.ComboGrilla(ClientesPublic)
        CrearComboGrid("IdRemitente", "Nombre", griGuiaTransportista, Cliente, True)
        CrearComboGrid("IdDestinatario", "Nombre", griGuiaTransportista, Cliente, True)
        CrearComboGrid("Cliente", "Nombre", griViajeDetalle, Cliente, True)
        CrearComboGrid("Carga", "Nombre", griViajeDetalle, olCombo.ComboGrilla(TipoCargaPublic), True)
        CrearComboGrid("Material", "Nombre", griViajeDetalle, olCombo.ComboGrilla(MaterialesPublic), True)
        CrearComboGrid("Comisionista", "Nombre", griViajeDetalle, olCombo.ComboGrilla(ComisionistasPublic), True)
        Lugar = olCombo.ComboGrilla(LugaresPublic)
        CrearComboGrid("Origen", "Nombre", griViajeDetalle, Lugar, True)
        CrearComboGrid("Destino", "Nombre", griViajeDetalle, Lugar, True)
        CrearComboGrid("IdMotivoTrasladoInterrumpido", "Nombre", griViajeInterrumpido, olCombo.ComboGrilla(MotivoDocumentoPublic), True)
    End Sub

    ''' <summary>
    ''' Generar una lista de los viajes programados
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Listar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            olOperacion = New l_Operacion
            oeViaje = New e_Viaje
            With oeViaje
                .ViajeVacio = 2
                .FechaDesde = fecDesde.Value
                .FechaHasta = fecHasta.Value
                .TipoOperacion = "1"
                .Centro = cboCentro.Value
                .IndMotriz = 1
                .IdTracto = cboTractoLista.Value
            End With

            griLista.DataSource = olOperacion.ListarViaje(oeViaje)
            'If opcTipoColores.CheckedIndex = 0 Then
            '    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLista.Rows
            '        Select Case fila.Cells("TipoVehiculo").Value
            '            Case "PLATAFORMA"
            '                fila.Cells("Carreta").Appearance.BackColor = Me.ColorPlataforma.Color
            '            Case "FURGON"
            '                fila.Cells("Carreta").Appearance.BackColor = Me.ColorFurgon.Color
            '            Case "GRANELERO"
            '                fila.Cells("Carreta").Appearance.BackColor = Me.ColorGranelero.Color
            '            Case "FURGON LARGO"
            '                fila.Cells("Carreta").Appearance.BackColor = Me.ColorFurgonLargo.Color
            '            Case "CONTENEDOR"
            '                fila.Cells("Carreta").Appearance.BackColor = Me.ColorContenedor.Color
            '            Case "CAMION 20 M3"
            '                fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamion20M3.Color
            '            Case "CAMION 40 M3"
            '                fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamion40M3.Color
            '            Case "VOLQUETE"
            '                fila.Cells("Carreta").Appearance.BackColor = Me.ColorVolquete.Color
            '            Case "CALICERA"
            '                fila.Cells("Carreta").Appearance.BackColor = Me.ColorCalicera.Color
            '            Case "TOLVA DE VOLTEO"
            '                fila.Cells("Carreta").Appearance.BackColor = Me.ColorTolvaVolteo.Color
            '            Case "MEDIA BARANDA"
            '                fila.Cells("Carreta").Appearance.BackColor = Me.ColorMediaBaranda.Color
            '            Case "CAMIONETA"
            '                fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamioneta.Color
            '            Case "CAMION 30 M3"
            '                fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamion30M3.Color
            '            Case "CAMION 65 M3"
            '                fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamion65M3.Color
            '        End Select
            '    Next
            'Else
            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLista.Rows

                Select Case fila.Cells("Estado").Value
                    Case "PROGRAMADO"
                        fila.CellAppearance.BackColor = Me.ColorProgramado.Color
                    Case "CARGA"
                        fila.CellAppearance.BackColor = Me.ColorCarga.Color
                    Case "TRANSITO"
                        fila.CellAppearance.BackColor = Me.ColorTransito.Color
                    Case "DESCARGA"
                        fila.CellAppearance.BackColor = Me.ColorDescarga.Color
                    Case "FIN"
                        fila.CellAppearance.BackColor = Me.ColorFin.Color
                    Case Else
                        fila.CellAppearance.BackColor = Color.White
                End Select

                Select Case fila.Cells("TipoVehiculo").Value
                    Case "PLATAFORMA"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorPlataforma.Color
                    Case "FURGON"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorFurgon.Color
                    Case "GRANELERO"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorGranelero.Color
                    Case "FURGON LARGO"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorFurgonLargo.Color
                    Case "CONTENEDOR"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorContenedor.Color
                    Case "CAMION 20 M3"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamion20M3.Color
                    Case "CAMION 40 M3"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamion40M3.Color
                    Case "VOLQUETE"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorVolquete.Color
                    Case "CALICERA"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorCalicera.Color
                    Case "TOLVA DE VOLTEO"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorTolvaVolteo.Color
                    Case "MEDIA BARANDA"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorMediaBaranda.Color
                    Case "CAMIONETA"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamioneta.Color
                    Case "CAMION 30 M3"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamion30M3.Color
                    Case "CAMION 50 M3"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamion65M3.Color
                    Case "CAMION 65 M3"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamion65M3.Color
                End Select
            Next
            'End If

            'Ubica el cursor el el primer registro de la grilla
            If griLista.Rows.Count > 0 Then
                griLista.Focus()
                griLista.Rows.Item(0).Activated = True
            End If
            gruopExpanUnidadesSinReportar.Expanded = False
            'InicializaTiempo()
            ugb_Espera.Visible = False
            'Await MensajePC("Viajes listados")

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub mt_ListarAlerta()
        Try
            'Inicio Cursor Espera
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            'Listar
            olOperacion = New l_Operacion
            oeViaje = New e_Viaje
            With oeViaje
                .ViajeVacio = 2
                .FechaDesde = fecDesde.Value
                .FechaHasta = fecHasta.Value
                .TipoOperacion = "W"
                .Centro = cboCentro.Value
                .IndMotriz = 1
                .IdTracto = cboTractoLista.Value
            End With
            griAlertaViajes.DataSource = olOperacion.ListarViaje(oeViaje).OrderByDescending(Function(x) x.Fecha).ToList()
            'Color Filas
            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griAlertaViajes.Rows
                'Estado
                Select Case fila.Cells("Estado").Value
                    Case "PROGRAMADO"
                        fila.CellAppearance.BackColor = Me.ColorProgramado.Color
                    Case "CARGA"
                        fila.CellAppearance.BackColor = Me.ColorCarga.Color
                    Case "TRANSITO"
                        fila.CellAppearance.BackColor = Me.ColorTransito.Color
                    Case "DESCARGA"
                        fila.CellAppearance.BackColor = Me.ColorDescarga.Color
                    Case "FIN"
                        fila.CellAppearance.BackColor = Me.ColorFin.Color
                    Case Else
                        fila.CellAppearance.BackColor = Color.White
                End Select
                'TipoVehiculo
                Select Case fila.Cells("TipoVehiculo").Value
                    Case "PLATAFORMA"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorPlataforma.Color
                    Case "FURGON"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorFurgon.Color
                    Case "GRANELERO"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorGranelero.Color
                    Case "FURGON LARGO"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorFurgonLargo.Color
                    Case "CONTENEDOR"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorContenedor.Color
                    Case "CAMION 20 M3"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamion20M3.Color
                    Case "CAMION 40 M3"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamion40M3.Color
                    Case "VOLQUETE"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorVolquete.Color
                    Case "CALICERA"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorCalicera.Color
                    Case "TOLVA DE VOLTEO"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorTolvaVolteo.Color
                    Case "MEDIA BARANDA"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorMediaBaranda.Color
                    Case "CAMIONETA"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamioneta.Color
                    Case "CAMION 30 M3"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamion30M3.Color
                    Case "CAMION 50 M3"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamion65M3.Color
                    Case "CAMION 65 M3"
                        fila.Cells("Carreta").Appearance.BackColor = Me.ColorCamion65M3.Color
                End Select
            Next
        Catch ex As Exception
            Throw ex
        Finally
            'Fin Cursor Espera
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Sub CargaOperacion()
        oeOperacionDetalle = New e_OperacionDetalle
        oeOperacionDetalle.IdOperacion = txtIdOperacion.Text
        oeOperacionDetalle.TipoOperacion = "G"
        griViajeDetalle.DataSource = olOperacion.ListarOperacionDetalle(oeOperacionDetalle)
    End Sub

    Public Function EditarSeguimiento() As Boolean
        Try
            olSeguimiento = New l_Seguimiento
            olGuiaTransportista = New l_GuiaTransportista
            olGuiaRemitente = New l_GuiaRemitente
            olGrtInterrumpida = New l_GuiaTransportistaInterrumpida
            olOperacion = New l_Operacion
            Dim CodigoViaje As String
            If griLista.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                'Activar Para seleccionar el viaje siguiente
                If griLista.ActiveRow.Cells("Seleccion").Value = True Then
                    oeViaje = New e_Viaje
                    oeViaje.Id = griLista.ActiveRow.Cells("IdTracto").Value.ToString
                    'oeViaje.IdEstado = griLista.ActiveRow.Cells("IdPiloto").Value.ToString
                    oeViaje.TipoOperacion = "4"
                    'ViajeVacio  = 0 Para Validar Seguimiento Viaje Correlatividad
                    oeViaje.ViajeVacio = 0
                    oeViaje = olOperacion.ObtenerViaje(oeViaje)
                    If griLista.ActiveRow.Cells("Estado").Value.ToString = "FIN" Then
                        CodigoViaje = oeViaje.Codigo
                    Else
                        CodigoViaje = griLista.ActiveRow.Cells("Codigo").Value.ToString
                    End If

                    If oeViaje.Codigo = CodigoViaje Or oeViaje.Id.Trim = "" Then
                        EditaSeguimientoCabecera()
                        Marcas()
                    Else
                        Throw New Exception("No se puede Editar Viaje: " & griLista.ActiveRow.Cells("Codigo").Value.ToString & Environment.NewLine & _
                                            "No se a Reportado el Anterior: " & oeViaje.Codigo & Environment.NewLine & _
                                            "Fecha Viaje Anterior: " & oeViaje.Fecha.ToString & Environment.NewLine & _
                                            "Ruta Viaje: " & oeViaje.Origen & " - " & oeViaje.Destino & Environment.NewLine & _
                                            "Su Estado: " & oeViaje.Estado)
                    End If
                Else
                    If Not PerfilAsignado(gNombrePerfilAutorizaCallCenter) Then
                        If MessageBox.Show("No esta autorizado para quitar las validaciones" & Environment.NewLine & _
                                            "viajes sin validaciones comuniquese con el " & gNombrePerfilJefeCallCenter & Environment.NewLine & _
                                            "Desea Seguir reportando Viajes:  ?", _
                                            "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            IncidenciasPublic = New e_IncidenciasAutentificadas
                            Dim formulario As frm_Autorizacion
                            formulario = frm_Autorizacion
                            If formulario.ObtenerJefes(gNombrePerfilAutorizaCallCenter, "frm_Seguimiento", pIdActividadNegocio) Then formulario.ShowDialog()
                            If IncidenciasPublic.IdResponsableAutoriza = "" Then
                                Return False
                                Exit Function
                            End If
                        Else
                            Return False
                            Exit Function
                        End If
                    End If
                    EditaSeguimientoCabecera()
                    Marcas()
                End If
            End If
            griGuiaTransportista.DataSource = oeSeguimiento.GuiaTransportista
            griGuiaRemitente.DataSource = oeSeguimiento.GuiaRemitente

            oeGuiaTransportista = New e_GuiaTransportista
            oeGuiaTransportista.IdOperacion = txtIdOperacion.Text
            griGuiaTransportista.DataSource = olGuiaTransportista.Listar(oeGuiaTransportista)

            oeGrtInterrumpida = New e_GuiaTransportistaInterrumpida
            oeGrtInterrumpida.IdOperacion = txtIdOperacion.Text
            griViajeInterrumpido.DataSource = olGrtInterrumpida.Listar(oeGrtInterrumpida)

            oeGuiaRemitente = New e_GuiaRemitente
            oeGuiaRemitente.IdOperacion = txtIdOperacion.Text
            griGuiaRemitente.DataSource = olGuiaRemitente.Listar(oeGuiaRemitente)

            CargaOperacion()
            ListarCombustibleViaje(True)
            MostrarTabs(1, ficDemanda, 1)
            ViajeVacio()
            CorrelativoGuia(IdVehiculo)
            lblSalidaDestino.Text = IIf(verViajeVacio.Checked, "Llegada Destino:", "Salida Destino:")
            lblSalidaDestinoE.Text = IIf(verViajeVacio.Checked, "Llegada Destino:", "Salida Destino:")
            lblSalidaDestino.Text = IIf(verViajeRetorno.Checked, "Llegada Destino:", "Salida Destino:")
            lblSalidaDestinoE.Text = IIf(verViajeRetorno.Checked, "Llegada Destino:", "Salida Destino:")
            If griGuiaTransportista.Rows.Count > 0 Then
                tabGuias.Tabs(0).Enabled = False
                tabGuias.Tabs(1).Enabled = False
                tabGuias.Tabs(2).Enabled = False
                GuiasIngresoGRT = True
            End If
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    'Private Sub LlamarAntesMarcas(ByVal IdViaje As String)
    '    txtCliente.Text = "CLIENTES: "
    '    oeViaje.Id = IdViaje
    '    oeViaje.TipoOperacion = "1"
    '    oeViaje = olOperacion.Obtener(oeViaje)
    '    Marcas()
    'End Sub

    Private Sub ViajeVacio()
        If verViajeVacio.Checked Or verViajeRetorno.Checked Then
            exGroupMarcaDentro.Enabled = False
            exGroupMarcaEDentro.Enabled = False
            grupoLlegada.Enabled = True
            grupoLlegadaE.Enabled = True
            verTerminoCargaOrigen.Checked = True
            verTerminoDescargaDestino.Checked = True
            verImpresionGuiaOrigenE.Checked = True
            verTerminoDescargaDestinoE.Checked = True

            If grupoMarca01.Visible = True Then
                If oeSeguimiento.IndCargaOrigen = 0 Then
                    hCargaOrigen.Value = hLlegadaOrigen.Value.AddMinutes(1).ToShortTimeString
                    fecCargaOrigen.Value = DateAdd(DateInterval.Minute, 1, Date.Parse(fecLlegadaOrigen.Value.ToShortDateString & " " & hLlegadaOrigen.Value.ToShortTimeString))
                End If

                If oeSeguimiento.IndTerminoCargaOrigen = 0 Then
                    hTerminoCargaOrigen.Value = hCargaOrigen.Value.AddMinutes(1).ToShortTimeString
                    fecTerminoCargaOrigen.Value = DateAdd(DateInterval.Minute, 1, Date.Parse(fecCargaOrigen.Value.ToShortDateString & " " & hCargaOrigen.Value.ToShortTimeString))
                End If

                'If oeSeguimiento.IndDescargaDestino = 0 Then
                'End If
                hDescargaDestino.Value = hLlegadaDestino.Value.AddMinutes(1).ToShortTimeString
                fecDescargaDestino.Value = DateAdd(DateInterval.Minute, 1, Date.Parse(fecLlegadaDestino.Value.ToShortDateString & " " & hLlegadaDestino.Value.ToShortTimeString))

                'If oeSeguimiento.IndTerminoDescargaDestino = 0 Then
                'End If
                hTerminoDescargaDestino.Value = hDescargaDestino.Value.AddMinutes(1).ToShortTimeString
                fecTerminoDescargaDestino.Value = DateAdd(DateInterval.Minute, 1, Date.Parse(fecDescargaDestino.Value.ToShortDateString & " " & hDescargaDestino.Value.ToShortTimeString))

            Else
                If oeSeguimiento.IndIngresoComplejoOrigen = 0 Then
                    hIngresoComplejoOrigenE.Value = hLlegadaOrigenE.Value.AddMinutes(1).ToShortTimeString
                    fecIngresoComplejoOrigenE.Value = DateAdd(DateInterval.Minute, 1, Date.Parse(fecLlegadaOrigenE.Value.ToShortDateString & " " & hLlegadaOrigenE.Value.ToShortTimeString))
                End If

                If oeSeguimiento.IndCargaOrigen = 0 Then
                    hCargaOrigenE.Value = hIngresoComplejoOrigenE.Value.AddMinutes(1).ToShortTimeString
                    fecCargaOrigenE.Value = DateAdd(DateInterval.Minute, 1, Date.Parse(fecIngresoComplejoOrigenE.Value.ToShortDateString & " " & hIngresoComplejoOrigenE.Value.ToShortTimeString))
                End If

                If oeSeguimiento.IndTerminoCargaOrigen = 0 Then
                    hTerminoCargaOrigenE.Value = hCargaOrigen.Value.AddMinutes(1).ToShortTimeString
                    fecTerminoCargaOrigenE.Value = DateAdd(DateInterval.Minute, 1, Date.Parse(fecCargaOrigenE.Value.ToShortDateString & " " & hCargaOrigenE.Value.ToShortTimeString))
                End If

                If oeSeguimiento.IndImpresionGuiaOrigen = 0 Then
                    hImpresionGuiaOrigenE.Value = hTerminoCargaOrigenE.Value.AddMinutes(1).ToShortTimeString
                    fecImpresionGuiaOrigenE.Value = DateAdd(DateInterval.Minute, 1, Date.Parse(fecTerminoCargaOrigenE.Value.ToShortDateString & " " & hTerminoCargaOrigenE.Value.ToShortTimeString))
                End If

                'If oeSeguimiento.IndIngresoDestino = 0 Then
                'End If
                hIngresoDestinoE.Value = hLlegadaDestinoE.Value.AddMinutes(1).ToShortTimeString
                fecIngresoDestinoE.Value = DateAdd(DateInterval.Minute, 1, Date.Parse(fecLlegadaDestinoE.Value.ToShortDateString & " " & hLlegadaDestinoE.Value.ToShortTimeString))

                'If oeSeguimiento.IndDescargaDestino = 0 Then
                'End If
                hDescargaDestinoE.Value = hIngresoDestinoE.Value.AddMinutes(1).ToShortTimeString
                fecDescargaDestinoE.Value = DateAdd(DateInterval.Minute, 1, Date.Parse(fecIngresoDestinoE.Value.ToShortDateString & " " & hIngresoDestinoE.Value.ToShortTimeString))

                'If oeSeguimiento.IndTerminoDescargaDestino = 0 Then
                'End If
                hTerminoDescargaDestinoE.Value = hDescargaDestinoE.Value.AddMinutes(1).ToShortTimeString
                fecTerminoDescargaDestinoE.Value = DateAdd(DateInterval.Minute, 1, Date.Parse(fecDescargaDestinoE.Value.ToShortDateString & " " & hDescargaDestinoE.Value.ToShortTimeString))

            End If
            tabGuias.Tabs(0).Enabled = False
            tabGuias.Tabs(1).Enabled = False
            tabGuias.Tabs(2).Enabled = False
        Else
            exGroupMarcaDentro.Enabled = True
            exGroupMarcaEDentro.Enabled = True
            grupoLlegada.Enabled = True
            grupoLlegadaE.Enabled = True
            If griGuiaTransportista.Rows.Count > 0 Then
                tabGuias.Tabs(0).Enabled = False
                tabGuias.Tabs(1).Enabled = False
                tabGuias.Tabs(2).Enabled = False
            Else
                tabGuias.Tabs(2).Enabled = True
            End If
        End If

        If IdMaterialAux = "CALIZA" Or IdMaterialAux = "PUZOLANA" Or IdMaterialAux = "CONCHUELA" Or verViajeVacio.Checked Or verViajeRetorno.Checked Then
            exGroupMarcaDentro.Enabled = False
            exGroupMarcaEDentro.Enabled = False
            grupoLlegada.Enabled = True
            grupoLlegadaE.Enabled = True
            verTerminoCargaOrigen.Checked = True
            verTerminoDescargaDestino.Checked = True
            verImpresionGuiaOrigenE.Checked = True
            verTerminoDescargaDestinoE.Checked = True
        End If
    End Sub

    Public Sub ListarCombustibleViaje(ByVal Activo As Boolean)
        Try
            olRegConsumoCombustible = New l_RegistroConsumoCombustible
            oeRegConsumoCombustible = New e_RegistroConsumoCombustible
            With oeRegConsumoCombustible
                .TipoOperacion = "0"
                .fechaInicio = griLista.ActiveRow.Cells("Fecha").Value.ToString
                .fechaFin = griLista.ActiveRow.Cells("Fecha").Value.ToString
                .IdVehiculo = "'" & griLista.ActiveRow.Cells("IdTracto").Value.ToString & "'"
            End With

            Dim ds As DataSet = olRegConsumoCombustible.ListarDts(oeRegConsumoCombustible)
            Dim parentCol As DataColumn = ds.Tables(0).Columns("Id")
            Dim childCol_1 As DataColumn = ds.Tables(1).Columns("IdTracto")
            Dim childCol_2 As DataColumn = ds.Tables(1).Columns("IdViaje")
            Dim childCol_3 As DataColumn = ds.Tables(2).Columns("IdViaje")
            Dim relation_1 As DataRelation = New DataRelation("FK_RelacionRegConComb_1", parentCol, childCol_1, True)
            Dim relation_2 As DataRelation = New DataRelation("FK_RelacionRegConComb_2", childCol_2, childCol_3, True)
            ds.Relations.Add(relation_1)
            ds.Relations.Add(relation_2)
            ds.AcceptChanges()
            griListadoTanqueo.DataSource = ds
            Me.Cursor = Cursors.WaitCursor
            With griListadoTanqueo.DisplayLayout
                '.DisplayLayout.UseFixedHeaders = False

                .Bands(0).ColHeadersVisible = False
                .Bands(0).HeaderVisible = False

                .Bands(0).Columns("Id").Hidden = True
                'Nombre Columnas
                '.DisplayLayout.Bands(0).Columns("Placa").Header.Caption = "Placa/Viaje/NroVale"
                '.DisplayLayout.Bands(0).Columns("FechaTanqueo").Header.Caption = "F.Viaje/Tanqueo"
                .Bands(1).Columns("NombreCompleto").Header.Caption = "Piloto"
                '.DisplayLayout.Bands(0).Columns("Tanqueo").Header.Caption = "Full"
                .Bands(1).Columns("FechaViaje").Header.Caption = "F.Viaje"
                .Bands(1).Columns("FechaViaje").Style = ColumnStyle.DateTime

                .Bands(2).Columns("FechaTanqueo").Header.Caption = "F.Tanqueo"
                .Bands(2).Columns("FechaTanqueo").Style = ColumnStyle.DateTime

                .Bands(1).Columns("IndTanqueo").Hidden = True
                .Bands(1).Columns("GL").Hidden = True
                .Bands(1).Columns("Cons").Hidden = True
                .Bands(1).Columns("Rend").Hidden = True
                .Bands(1).Columns("Rutas").Hidden = True
                .Bands(1).Columns("Pesos").Hidden = True
                'Ancho
                .Bands(0).Columns("Placa").Width = 100

                .Bands(1).Columns("CodViaje").Width = 90

                .Bands(2).Columns("NroVale").Width = 70

                .Bands(1).Columns("Ruta").Width = 150
                '.DisplayLayout.Bands(1).Columns("CodViaje").Width = 100
                '.DisplayLayout.Bands(1).Columns("CodViaje").Width = 100
                '.DisplayLayout.Bands(1).Columns("CodViaje").Width = 100
                '.DisplayLayout.Bands(0).Columns("FechaTanqueo").Width = 90
                .Bands(1).Columns("FechaViaje").Width = 100

                .Bands(2).Columns("FechaTanqueo").Width = 100

                .Bands(1).Columns("NombreCompleto").Width = 200
                .Bands(1).Columns("Copiloto").Width = 150
                'Color
                .Bands(0).Columns("Placa").CellAppearance.BackColor = Color.Khaki

                .Bands(1).Columns("CodViaje").CellAppearance.BackColor = Color.Khaki

                .Bands(2).Columns("NroVale").CellAppearance.BackColor = Color.Khaki
                '.DisplayLayout.Bands(0).Columns("Dist").CellAppearance.BackColor = Color.Silver
                '.DisplayLayout.Bands(1).Columns("Dist").CellAppearance.BackColor = Color.Silver
                '.DisplayLayout.Bands(2).Columns("Dist").CellAppearance.BackColor = Color.Silver
                '.DisplayLayout.Bands(0).Columns("KM").CellAppearance.BackColor = Color.SkyBlue
                .Bands(1).Columns("KM").CellAppearance.BackColor = Color.SkyBlue

                .Bands(2).Columns("Kilometraje").CellAppearance.BackColor = Color.SkyBlue

                ' Band 1
                .Bands(1).Columns("IdTracto").Hidden = True
                .Bands(1).Columns("FechaViaje").CellActivation = Activation.NoEdit
                .Bands(1).Columns("IdViaje").Hidden = True
                .Bands(1).Columns("IdPiloto").Hidden = True
                .Bands(1).Columns("IdCopiloto").Hidden = True
                .Bands(1).Columns("IdCarreta").Hidden = True
                .Bands(1).Columns("Ruta").Hidden = False
                .Bands(1).Columns("Placa1").Hidden = True
                '.DisplayLayout.Bands(1).ColHeadersVisible = False
                '.DisplayLayout.Bands(1).HeaderVisible = False
                .Bands(1).Columns("Placa1").Hidden = True
                .Bands(1).Columns("KmTractoOrigen").Hidden = True
                .Bands(1).Columns("KmTractoDestino").Hidden = True
                .Bands(1).Columns("ROrigen").Hidden = True
                .Bands(1).Columns("RDestino").Hidden = True

                .Bands(2).Columns("Peso").Hidden = True
                .Bands(2).Columns("Credito").Hidden = True
                .Bands(2).Columns("Usuario").Hidden = True
                .Bands(2).Columns("Estado").Hidden = True
                .Bands(2).Columns("IndTanqueo").Hidden = True
                .Bands(2).Columns("Rutas").Hidden = True
                .Bands(2).Columns("Direccion").Width = 200

                .Bands(1).Columns("FechaViaje").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Bands(1).Columns("KM").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                '.DisplayLayout.Bands(1).Columns("Dist").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(1).Columns("Peso").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right

                ' Band 2
                .Bands(2).Columns("IdVehiculo").Hidden = True
                .Bands(2).Columns("Id").Hidden = True
                .Bands(2).Columns("IdViaje").Hidden = True
                .Bands(2).Columns("IdEmpresaGrifo").Hidden = True
                .Bands(2).Columns("UsuarioCreacion").Hidden = True
                .Bands(2).Columns("KmTractoOrigen").Hidden = True
                .Bands(2).Columns("KmTractoDestino").Hidden = True
                '.DisplayLayout.Bands(2).Columns("ROrigen").Hidden = True
                '.DisplayLayout.Bands(2).Columns("RDestino").Hidden = True
                .Bands(2).Columns("FechaTanqueo").CellActivation = Activation.NoEdit
                .Bands(2).Columns("FechaViaje").Hidden = True
                .Bands(2).Columns("CantidadGls").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(2).Columns("CONS").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(2).Columns("Kilometraje").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                '.DisplayLayout.Bands(2).Columns("Dist").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(2).Columns("NroVale").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(2).Columns("Credito").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(2).Columns("IndTanqueo").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(2).Columns("Rend").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(2).Columns("FechaTanqueo").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                '.DisplayLayout.Bands(2).ColHeadersVisible = False
                '.DisplayLayout.Bands(2).HeaderVisible = False
                .Bands(2).Columns("Grifo").Width = 200

                .Bands(0).Columns("Placa").Header.Fixed = True

                .Bands(1).Columns("CodViaje").Header.Fixed = True

                .Bands(2).Columns("NroVale").Header.Fixed = True
                '.DisplayLayout.Bands(0).Columns("FechaTanqueo").Header.Fixed = True
                .Bands(1).Columns("FechaViaje").Header.Fixed = True

                .Bands(2).Columns("FechaTanqueo").Header.Fixed = True
                'If .Rows.Count > 0 Then
                '    .Focus()
                '    .Rows.Item(0).Selected = True
                'End If
                For x As Integer = 0 To griListadoTanqueo.Rows.Count - 1
                    Me.griListadoTanqueo.Rows(x).ExpandAll()
                Next
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griListadoTanqueo.Focus()
    End Sub

    Private Sub CorrelativoGuia(ByVal IdVehiculo As String)
        Dim Correlativo As Integer
        olGuiasControl = New l_GuiasControl
        oeGuiasControl = New e_GuiasControl
        oeGuiasControl.IdVehiculo = IdVehiculo
        oeGuiasControl = olGuiasControl.Obtener(oeGuiasControl)
        Correlativo = CInt(oeGuiasControl.Correlativo) + 1
        txtGrt.Text = oeGuiasControl.Serie & "-" & Correlativo
    End Sub

    Private Sub EditaSeguimientoCabecera()
        Dim ListaOperacionDetalle As New List(Of e_OperacionDetalle)
        olVehiculo = New l_Vehiculo
        oeViaje = New e_Viaje
        olCombo = New l_Combo
        oeViaje.Id = griLista.ActiveRow.Cells("Id").Value.ToString
        oeViaje.TipoOperacion = "E"
        oeViaje = olOperacion.ObtenerViaje(oeViaje)
        If oeViaje.IdTipoVehiculo <> "" Then
            If oeViaje.Ayudante <> gUsuarioSGI.oePersona.NombreCompleto Then
                Throw New Exception("La información del Viaje no es accesible pues esta siendo ediatado por" & Environment.NewLine & Environment.NewLine & _
                                                "el Usuario: " & oeViaje.Ayudante & Environment.NewLine & _
                                                "desde: " & oeViaje.LlegadaOrigen & Environment.NewLine & _
                                                "en la Sucursal: " & oeViaje.IdAyudante)
            Else
                oeRegistroEditado = New e_RegistrosEditados
                With oeRegistroEditado
                    .TipoOperacion = "A"
                    .Id = oeViaje.IdTipoVehiculo
                    .FechaModificado = DateAdd(DateInterval.Minute, 5, oeViaje.LlegadaOrigen)
                End With
                oeRegistroEditado.PrefijoID = gs_PrefijoIdSucursal '@0001
                olRegistroEditado.Guardar(oeRegistroEditado)
                RegistroEditado = 1
            End If
        Else
            RegistroEditado = 1
        End If

        If oeViaje.Id <> "" Then
            IdVehiculo = oeViaje.IdTracto
            oeVehiculo = New e_Vehiculo
            oeVehiculo.TipoOperacion = "A"
            oeVehiculo.Id = oeViaje.IdTracto

            oeVehiculo = olVehiculo.Obtener(oeVehiculo)
            txtKmTractoOrigen.Value = oeVehiculo.Odometro
            lblKmTractoOrigen.Text = "Orig:" & oeVehiculo.Odometro
            TractoKilometros = oeVehiculo.Odometro
            txtHorasTractoOrigen.Value = oeVehiculo.Horometro
            lblHrTractoOrigen.Text = "Orig:" & oeVehiculo.Horometro

            oeVehiculo = New e_Vehiculo
            oeVehiculo.TipoOperacion = "A"
            oeVehiculo.Id = oeViaje.IdCarreta

            oeVehiculo = olVehiculo.Obtener(oeVehiculo)
            txtKmCarretaOrigen.Value = oeVehiculo.Odometro
            lblKmCarretaOrigen.Text = "Orig:" & oeVehiculo.Odometro
            With oeViaje
                txtIdOperacion.Text = .IdOperacion
                txtViajeId.Text = .Id
                txtViajeCodigo.Text = .Codigo
                fecViaje.Value = .Fecha
                hViaje.Value = .Fecha.ToShortTimeString
                verViajeVacio.Checked = .ViajeVacio
                verViajeRetorno.Checked = .ViajeRetorno
                txtViajePiloto.Text = .Piloto
                'txtViajeRuta.Text = .Origen & " - " & .Destino
                txtViajeRuta.Text = .Copiloto
                txtViajeEscala.Text = .Escala
                txtViajeTracto.Text = .Tracto
                txtViajeCarreta.Text = .Carreta
                txtViajeEstado.Text = .Estado
                lbOrigen.Text = .Origen
                lbDestino.Text = .Destino
                lbOrigenE.Text = .Origen
                lbDestinoE.Text = .Destino
                OrigenViaje = .Origen
                DestinoViaje = .Destino
                Origen = .IdOrigen
                Destino = .IdDestino
                txtIdTracto.Text = .IdTracto
                txtIdCarreta.Text = .IdCarreta
            End With

            oeOperacionDetalle = New e_OperacionDetalle
            oeOperacionDetalle.TipoOperacion = ""
            oeOperacionDetalle.IdOperacion = oeViaje.IdOperacion

            ListaOperacionDetalle = olOperacion.ListarOperacionDetalle(oeOperacionDetalle)
            Dim Cliente As String
            olCliente = New l_Cliente
            Cliente = ""
            For Each OperacionDetalle As e_OperacionDetalle In ListaOperacionDetalle
                oeCliente = New e_Cliente
                oeCliente.TipoOperacion = ""
                oeCliente.Id = OperacionDetalle.Cliente
                oeCliente = olCliente.Obtener(oeCliente)
                If Cliente <> oeCliente.Id Then
                    txtCliente.Text += oeCliente.Nombre & "; "
                End If
                For Each Datos In From M In MaterialesPublic Where M.Id = OperacionDetalle.Material Select M
                    ClienteCargaMaterial = Datos.Nombre
                Next
                ClienteCarga = oeCliente.Nombre
                Cliente = oeCliente.Id
                oeCliente = New e_Cliente
                oeCliente.TipoOperacion = "1"
                oeCliente.Id = OperacionDetalle.Cliente
                oeCliente = olCliente.Obtener(oeCliente)
                cboRemitente.Value = OperacionDetalle.Cliente
                cboDestinatario.Value = OperacionDetalle.Cliente
            Next

            oeCombo = New e_Combo
            oeCombo.Id = Destino
            oeCombo.Nombre = Cliente
            LlenarComboMaestro(cboLugarTienda, olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList, 0)
            '@0001
            If gs_PrefijoIdSucursal = "1LU" Or gs_PrefijoIdSucursal = "1LI" Then
                oeCliente.Id = ""
            End If

            oeSeguimiento = New e_Seguimiento
            oeSeguimiento.Id = ""
            oeSeguimiento.IdViaje = oeViaje.Id
            oeSeguimiento = olSeguimiento.Obtener(oeSeguimiento)
            With oeSeguimiento
                txtSeguimientoId.Text = .Id
                txtObservacion.Text = .Observacion
                txtPesoToneladas.Value = .PesoToneladas
                txtCantidad.Text = .Cantidad
                cboLugarTienda.Value = .IdClienteLugar
                verPilotoConf.Checked = .PilotoConf
                verCopilotoConf.Checked = .CopilotoConf
                verTractoConf.Checked = .TractoConf
                verCarretaConf.Checked = .CarretaConf
                verClienteConf.Checked = .ClienteConf
                verIndFallaOP.Checked = .IndFallaOP
                fecFalla.Value = .FechaFalla
                hFalla.Value = .FechaFalla.ToShortTimeString
                txtGlosaFalla.Text = .GlosaFalla

                tabGuias.Tabs(0).Enabled = False
                tabGuias.Tabs(2).Selected = True
                tabGuias.Tabs(1).Enabled = False
                'oeSeguimiento.IdEstado = "1CH00010" Or oeSeguimiento.IdEstado = "1CH00020" Or oeSeguimiento.IdEstado = "1CH00006"

                If .KmTractoOrigen > 0 Then
                    txtKmTractoOrigen.Text = .KmTractoOrigen
                    txtKmTractoDestino.Text = .KmTractoDestino
                    txtKmCarretaOrigen.Text = .KmCarretaOrigen
                    txtKmCarretaDestino.Text = .KmCarretaDestino
                    txtHorasTractoOrigen.Text = .HorasRecorreOrigen
                    txtHorasTractoDestino.Text = .HorasRecorreDestino
                    lblKmTractoOrigen.Text = "Orig:" & .KmTractoOrigen
                    TractoKilometros = .KmTractoOrigen
                    lblHrTractoOrigen.Text = "Orig:" & .HorasRecorreOrigen
                    lblKmCarretaOrigen.Text = "Orig:" & .KmCarretaOrigen
                    tabGuias.Tabs(0).Selected = True
                    tabGuias.Tabs(0).Enabled = True
                    tabGuias.Tabs(1).Enabled = True
                End If
            End With
        Else
            Throw New Exception("El Registro se encuentra eliminado y no se puede editar")
        End If
    End Sub

    Private Sub Marcas()
        Try
            oeTiempoCiclo = New e_TiempoCiclo
            olRuta = New l_Ruta
            olTiempoCiclo = New l_TiempoCiclo
            Dim HorasCarga As Double
            Dim HorasTraslado As Double
            Dim HorasDescarga As Double
            ListaSeguimiento = New List(Of e_Seguimiento)

            If oeCliente.Id = "" Then
                grupoMarca01.Visible = True
                grupoMarca02.Visible = False

                oeSeguimiento = New e_Seguimiento
                oeSeguimiento.Id = ""
                oeSeguimiento.IdViaje = oeViaje.Id
                oeSeguimiento = olSeguimiento.Obtener(oeSeguimiento)

                oeRuta = New e_Ruta
                oeRuta.IdOrigen = oeViaje.IdOrigen
                oeRuta.IdDestino = oeViaje.IdDestino
                oeRuta = olRuta.Obtener(oeRuta)
                RutaKilometros = oeRuta.Kilometros
                oeTiempoCiclo.TipoOperacion = "1"
                If oeRuta.Id = "" Then oeRuta.Id = "0"
                oeTiempoCiclo.IdRuta = oeRuta.Id
                oeTiempoCiclo = olTiempoCiclo.Obtener(oeTiempoCiclo)

                If oeTiempoCiclo.Id = "" Then
                    HorasCarga = 1
                    If oeViaje.IdCopiloto <> "0" Then
                        If oeRuta.HorasAcompañado > 0 Then
                            HorasTraslado = oeRuta.HorasAcompañado
                        Else
                            If oeRuta.HorasSolo > 0 Then
                                HorasTraslado = oeRuta.HorasSolo
                            Else
                                HorasTraslado = 1
                            End If
                        End If
                    Else
                        If oeRuta.HorasSolo > 0 Then
                            HorasTraslado = oeRuta.HorasSolo
                        Else
                            HorasTraslado = 1
                        End If
                    End If
                    HorasDescarga = 1
                Else
                    If verViajeVacio.Checked = False Or verViajeRetorno.Checked = False Then
                        HorasCarga = oeTiempoCiclo.HorasCarga
                        HorasTraslado = oeTiempoCiclo.HorasTraslado
                        HorasDescarga = oeTiempoCiclo.HorasDescarga
                    Else
                        HorasCarga = 1
                        If oeViaje.IdCopiloto <> "0" Then
                            If oeRuta.HorasAcompañado > 0 Then
                                HorasTraslado = oeRuta.HorasAcompañado
                            Else
                                If oeRuta.HorasSolo > 0 Then
                                    HorasTraslado = oeRuta.HorasSolo
                                Else
                                    HorasTraslado = 1
                                End If
                            End If
                        Else
                            If oeRuta.HorasSolo > 0 Then
                                HorasTraslado = oeRuta.HorasSolo
                            Else
                                HorasTraslado = 1
                            End If
                        End If
                        HorasDescarga = 1
                    End If
                End If

                verLlegadaOrigen.Checked = oeSeguimiento.IndLlegadaOrigen
                If verLlegadaOrigen.Checked Then
                    fecLlegadaOrigen.Value = oeSeguimiento.LlegadaOrigen
                    hLlegadaOrigen.Value = oeSeguimiento.LlegadaOrigen.ToShortTimeString
                Else
                    'fecLlegadaOrigen.Value = Date.Today
                    'hLlegadaOrigen.Value = TimeOfDay.ToShortTimeString
                    hLlegadaOrigen.Value = hViaje.Value.AddHours(0.05).ToShortTimeString
                    fecLlegadaOrigen.Value = DateAdd(DateInterval.Minute, 3, Date.Parse(fecViaje.Value.ToShortDateString & " " & hViaje.Value.ToShortTimeString))
                    'Dim myDTFI As DateTimeFormatInfo = New CultureInfo("es-PE", False).DateTimeFormat
                    'fecha = fecViaje.Value
                    'Cadena = fecha.ToString("dddd", myDTFI)
                End If

                verCargaOrigen.Checked = oeSeguimiento.IndCargaOrigen
                If verCargaOrigen.Checked Then
                    fecCargaOrigen.Value = oeSeguimiento.CargaOrigen
                    hCargaOrigen.Value = oeSeguimiento.CargaOrigen.ToShortTimeString
                Else
                    'fecCargaOrigen.Value = Date.Today
                    'hCargaOrigen.Value = TimeOfDay.ToShortTimeString
                    hCargaOrigen.Value = hLlegadaOrigen.Value.AddHours(0.05).ToShortTimeString
                    fecCargaOrigen.Value = DateAdd(DateInterval.Minute, 3, Date.Parse(fecLlegadaOrigen.Value.ToShortDateString & " " & hLlegadaOrigen.Value.ToShortTimeString))
                End If

                verTerminoCargaOrigen.Checked = oeSeguimiento.IndTerminoCargaOrigen
                If verTerminoCargaOrigen.Checked Then
                    fecTerminoCargaOrigen.Value = oeSeguimiento.TerminoCargaOrigen
                    hTerminoCargaOrigen.Value = oeSeguimiento.TerminoCargaOrigen.ToShortTimeString
                Else
                    hTerminoCargaOrigen.Value = hCargaOrigen.Value.AddHours(HorasCarga).ToShortTimeString
                    fecTerminoCargaOrigen.Value = DateAdd(DateInterval.Hour, HorasCarga, Date.Parse(fecCargaOrigen.Value.ToShortDateString & " " & hCargaOrigen.Value.ToShortTimeString))
                End If

                verSalidaOrigen.Checked = oeSeguimiento.IndSalidaOrigen
                If verSalidaOrigen.Checked Then
                    fecSalidaOrigen.Value = oeSeguimiento.SalidaOrigen
                    hSalidaOrigen.Value = oeSeguimiento.SalidaOrigen.ToShortTimeString
                Else
                    hSalidaOrigen.Value = hTerminoCargaOrigen.Value.AddHours(0.05).ToShortTimeString
                    fecSalidaOrigen.Value = DateAdd(DateInterval.Minute, 3, Date.Parse(fecTerminoCargaOrigen.Value.ToShortDateString & " " & hTerminoCargaOrigen.Value.ToShortTimeString))
                End If

                verLlegadaDestino.Checked = oeSeguimiento.IndLlegadaDestino
                If verLlegadaDestino.Checked Then
                    fecLlegadaDestino.Value = oeSeguimiento.LlegadaDestino
                    hLlegadaDestino.Value = oeSeguimiento.LlegadaDestino.ToShortTimeString
                Else
                    hLlegadaDestino.Value = hSalidaOrigen.Value.AddHours(HorasTraslado).ToShortTimeString
                    fecLlegadaDestino.Value = DateAdd(DateInterval.Hour, HorasTraslado, Date.Parse(fecSalidaOrigen.Value.ToShortDateString & " " & hSalidaOrigen.Value.ToShortTimeString))
                End If

                verDescargaDestino.Checked = oeSeguimiento.IndDescargaDestino
                If verDescargaDestino.Checked Then
                    fecDescargaDestino.Value = oeSeguimiento.DescargaDestino
                    hDescargaDestino.Value = oeSeguimiento.DescargaDestino.ToShortTimeString
                Else
                    hDescargaDestino.Value = hLlegadaDestino.Value.AddHours(0.05).ToShortTimeString
                    fecDescargaDestino.Value = DateAdd(DateInterval.Minute, 3, Date.Parse(fecLlegadaDestino.Value.ToShortDateString & " " & hLlegadaDestino.Value.ToShortTimeString))
                End If

                verTerminoDescargaDestino.Checked = oeSeguimiento.IndTerminoDescargaDestino
                If verTerminoDescargaDestino.Checked Then
                    fecTerminoDescargaDestino.Value = oeSeguimiento.TerminoDescargaDestino
                    hTerminoDescargaDestino.Value = oeSeguimiento.TerminoDescargaDestino.ToShortTimeString
                Else
                    hTerminoDescargaDestino.Value = hDescargaDestino.Value.AddHours(HorasDescarga).ToShortTimeString
                    fecTerminoDescargaDestino.Value = DateAdd(DateInterval.Hour, HorasDescarga, Date.Parse(fecDescargaDestino.Value.ToShortDateString & " " & hDescargaDestino.Value.ToShortTimeString))
                End If

                verSalidaDestino.Checked = oeSeguimiento.IndSalidaDestino
                If verSalidaDestino.Checked Then
                    fecSalidaDestino.Value = oeSeguimiento.SalidaDestino
                    hSalidaDestino.Value = oeSeguimiento.SalidaDestino.ToShortTimeString
                Else
                    hSalidaDestino.Value = hTerminoDescargaDestino.Value.AddHours(0.05).ToShortTimeString
                    fecSalidaDestino.Value = DateAdd(DateInterval.Minute, 3, Date.Parse(fecTerminoDescargaDestino.Value.ToShortDateString & " " & hTerminoDescargaDestino.Value.ToShortTimeString))
                End If

                oeSeguimientoAnterior = New e_Seguimiento
                oeSeguimientoAnterior.TipoOperacion = 2
                oeSeguimientoAnterior.IdOperacion = oeViaje.IdTracto
                'oeSeguimientoAnterior.IdTracto = oeViaje.IdTracto
                oeSeguimientoAnterior.IdEstado = "1CH00010"
                ListaSeguimiento = olSeguimiento.Listar2(oeSeguimientoAnterior)
                If ListaSeguimiento.Count > 0 Then
                    If verLlegadaOrigen.Checked = False And verCargaOrigen.Checked = False And verTerminoCargaOrigen.Checked = False And verSalidaOrigen.Checked = False Then
                        If ListaSeguimiento(0).ViajeVacio = 1 Then
                            Select Case MessageBox.Show("El sistema ha detectado un viaje previo FINALIZADO" & Environment.NewLine & _
                                               "La Fecha y Hora de Salida Destino: " & ListaSeguimiento(0).SalidaDestino & Environment.NewLine & _
                                               "Será considerada como Llegada Origen para este viaje", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                                Case Windows.Forms.DialogResult.Yes
                                    'mensajeEmergente.Confirmacion("El sistema ha detectado un viaje previo FINALIZADO" & Environment.NewLine & _
                                    '                   "La Fecha y Hora de Salida Destino: " & ListaSeguimiento(0).SalidaDestino & Environment.NewLine & _
                                    '                   "Será considerada como Llegada Origen para este viaje", True)

                                    'llegada origen 
                                    If ListaSeguimiento(0).IndLlegadaDestino = 1 Then
                                        verLlegadaOrigen.Checked = True
                                        fecLlegadaOrigen.Value = ListaSeguimiento(0).LlegadaDestino
                                        hLlegadaOrigen.Value = ListaSeguimiento(0).LlegadaDestino.ToShortTimeString
                                        With oeSeguimiento
                                            .TipoOperacion = "1"
                                            .IdViaje = txtViajeId.Text
                                            .IdEstado = "CARGA"
                                            .LlegadaOrigen = Date.Parse(fecLlegadaOrigen.Value.ToShortDateString & " " & hLlegadaOrigen.Value.ToShortTimeString)
                                            .IndLlegadaOrigen = 1
                                        End With
                                        oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
                                        olSeguimiento.Guardar(oeSeguimiento)
                                    End If
                                    'inicio carga origen       
                                    If ListaSeguimiento(0).IndDescargaDestino = 1 Then
                                        verCargaOrigen.Checked = True
                                        fecCargaOrigen.Value = ListaSeguimiento(0).DescargaDestino
                                        hCargaOrigen.Value = ListaSeguimiento(0).DescargaDestino.ToShortTimeString
                                        With oeSeguimiento
                                            .TipoOperacion = "3"
                                            .IdViaje = txtViajeId.Text
                                            .IdEstado = "CARGA"
                                            .CargaOrigen = Date.Parse(fecCargaOrigen.Value.ToShortDateString & " " & hCargaOrigen.Value.ToShortTimeString)
                                            .IndCargaOrigen = 1
                                        End With
                                        oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
                                        olSeguimiento.Guardar(oeSeguimiento)
                                    End If

                                    'termino carga origen
                                    If ListaSeguimiento(0).IndTerminoDescargaDestino = 1 Then
                                        verTerminoCargaOrigen.Checked = True
                                        fecTerminoCargaOrigen.Value = ListaSeguimiento(0).TerminoDescargaDestino
                                        hTerminoCargaOrigen.Value = ListaSeguimiento(0).TerminoDescargaDestino.ToShortTimeString
                                        With oeSeguimiento
                                            .TipoOperacion = "4"
                                            .IdViaje = txtViajeId.Text
                                            .IdEstado = "CARGA"
                                            .TerminoCargaOrigen = Date.Parse(fecTerminoCargaOrigen.Value.ToShortDateString & " " & hTerminoCargaOrigen.Value.ToShortTimeString)
                                            .IndTerminoCargaOrigen = 1
                                        End With
                                        oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
                                        olSeguimiento.Guardar(oeSeguimiento)
                                    End If
                                    'salida origen
                                    If ListaSeguimiento(0).IndSalidaDestino = 1 Then
                                        verSalidaOrigen.Checked = True
                                        fecSalidaOrigen.Value = ListaSeguimiento(0).SalidaDestino
                                        hSalidaOrigen.Value = ListaSeguimiento(0).SalidaDestino.ToShortTimeString
                                        With oeSeguimiento
                                            .TipoOperacion = "6"
                                            .IdViaje = txtViajeId.Text
                                            .IdEstado = "TRANSITO"
                                            .SalidaOrigen = Date.Parse(fecSalidaOrigen.Value.ToShortDateString & " " & hSalidaOrigen.Value.ToShortTimeString)
                                            .IndSalidaOrigen = 1
                                        End With
                                        oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
                                        olSeguimiento.Guardar(oeSeguimiento)
                                        Marcas()
                                    End If
                            End Select
                        Else
                            Select Case MessageBox.Show("El sistema ha detectado un viaje previo FINALIZADO" & Environment.NewLine & _
                                               "La Fecha y Hora de Llegada Destino: " & ListaSeguimiento(0).LlegadaDestino & Environment.NewLine & _
                                               "Será considerada como Llegada Origen para este viaje" & Environment.NewLine & _
                                               "La Fecha y Hora de Inicio Descarga Destino: " & ListaSeguimiento(0).DescargaDestino & Environment.NewLine & _
                                               "Será considerada como Inicio Carga Origen para este viaje" & Environment.NewLine & _
                                               "La Fecha y Hora de Termino Descarga Destino: " & ListaSeguimiento(0).TerminoDescargaDestino & Environment.NewLine & _
                                               "Será considerada como Termino Carga Origen para este viaje" & Environment.NewLine & _
                                               "La Fecha y Hora de Salida Destino: " & ListaSeguimiento(0).SalidaDestino & Environment.NewLine & _
                                               "Será considerada como Salida Origen para este viaje", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                                Case Windows.Forms.DialogResult.Yes
                                    'mensajeEmergente.Confirmacion("El sistema ha detectado un viaje previo FINALIZADO" & Environment.NewLine & _
                                    '           "La Fecha y Hora de Llegada Destino: " & ListaSeguimiento(0).LlegadaDestino & Environment.NewLine & _
                                    '           "Será considerada como Llegada Origen para este viaje" & Environment.NewLine & _
                                    '           "La Fecha y Hora de Inicio Descarga Destino: " & ListaSeguimiento(0).DescargaDestino & Environment.NewLine & _
                                    '           "Será considerada como Inicio Carga Origen para este viaje" & Environment.NewLine & _
                                    '           "La Fecha y Hora de Termino Descarga Destino: " & ListaSeguimiento(0).TerminoDescargaDestino & Environment.NewLine & _
                                    '           "Será considerada como Termino Carga Origen para este viaje" & Environment.NewLine & _
                                    '           "La Fecha y Hora de Salida Destino: " & ListaSeguimiento(0).SalidaDestino & Environment.NewLine & _
                                    '           "Será considerada como Salida Origen para este viaje", True)
                                    If ListaSeguimiento(0).IndLlegadaDestino = 1 Then
                                        verLlegadaOrigen.Checked = True
                                        fecLlegadaOrigen.Value = ListaSeguimiento(0).LlegadaDestino
                                        hLlegadaOrigen.Value = ListaSeguimiento(0).LlegadaDestino.ToShortTimeString
                                        With oeSeguimiento
                                            .TipoOperacion = "1"
                                            .IdViaje = txtViajeId.Text
                                            .IdEstado = "CARGA"
                                            .LlegadaOrigen = Date.Parse(fecLlegadaOrigen.Value.ToShortDateString & " " & hLlegadaOrigen.Value.ToShortTimeString)
                                            .IndLlegadaOrigen = 1
                                        End With
                                        oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
                                        olSeguimiento.Guardar(oeSeguimiento)
                                    End If

                                    If ListaSeguimiento(0).IndDescargaDestino = 1 Then
                                        verCargaOrigen.Checked = True
                                        fecCargaOrigen.Value = ListaSeguimiento(0).DescargaDestino
                                        hCargaOrigen.Value = ListaSeguimiento(0).DescargaDestino.ToShortTimeString
                                        With oeSeguimiento
                                            .TipoOperacion = "3"
                                            .IdViaje = txtViajeId.Text
                                            .IdEstado = "CARGA"
                                            .CargaOrigen = Date.Parse(fecCargaOrigen.Value.ToShortDateString & " " & hCargaOrigen.Value.ToShortTimeString)
                                            .IndCargaOrigen = 1
                                        End With
                                        oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
                                        olSeguimiento.Guardar(oeSeguimiento)
                                    End If

                                    If ListaSeguimiento(0).IndTerminoDescargaDestino = 1 Then
                                        verTerminoCargaOrigen.Checked = True
                                        fecTerminoCargaOrigen.Value = ListaSeguimiento(0).TerminoDescargaDestino
                                        hTerminoCargaOrigen.Value = ListaSeguimiento(0).TerminoDescargaDestino.ToShortTimeString
                                        With oeSeguimiento
                                            .TipoOperacion = "4"
                                            .IdViaje = txtViajeId.Text
                                            .IdEstado = "CARGA"
                                            .TerminoCargaOrigen = Date.Parse(fecTerminoCargaOrigen.Value.ToShortDateString & " " & hTerminoCargaOrigen.Value.ToShortTimeString)
                                            .IndTerminoCargaOrigen = 1
                                        End With
                                        oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
                                        olSeguimiento.Guardar(oeSeguimiento)
                                    End If

                                    If ListaSeguimiento(0).IndSalidaDestino = 1 Then
                                        verSalidaOrigen.Checked = True
                                        fecSalidaOrigen.Value = ListaSeguimiento(0).SalidaDestino
                                        hSalidaOrigen.Value = ListaSeguimiento(0).SalidaDestino.ToShortTimeString
                                        With oeSeguimiento
                                            .TipoOperacion = "6"
                                            .IdViaje = txtViajeId.Text
                                            .IdEstado = "TRANSITO"
                                            .SalidaOrigen = Date.Parse(fecSalidaOrigen.Value.ToShortDateString & " " & hSalidaOrigen.Value.ToShortTimeString)
                                            .IndSalidaOrigen = 1
                                        End With
                                        oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
                                        olSeguimiento.Guardar(oeSeguimiento)
                                    End If

                                    InformacionTractoCarreta(1, 0, 1, 0, 1, 0)
                                    SalidaOrigenIndicador = True
                                    tabGuias.Tabs(0).Selected = True
                                    tabGuias.Tabs(0).Enabled = True
                                    tabGuias.Tabs(1).Enabled = True
                                    cboRemitente.Focus()
                                    cboDestinatario.Focus()
                                    txtGrt.Focus()

                                    Marcas()
                            End Select



                        End If
                    End If

                    'For Each oeSegAnterior As e_Seguimiento In ListaSeguimiento.OrderByDescending(Function(Item) Item.IdViaje).ToList()
                    '    If oeSegAnterior.IdEstado = "1CH00010" Then
                    '        If verLlegadaOrigen.Checked = False Then
                    '            If oeSegAnterior.ViajeVacio = 1 Then
                    '                mensajeEmergente.Confirmacion("El sistema ha detectado un viaje previo FINALIZADO" & Environment.NewLine & _
                    '                                   "La Fecha y Hora de Salida Destino: " & oeSegAnterior.SalidaDestino & Environment.NewLine & _
                    '                                   "Será considerada como Llegada Origen para este viaje", True)
                    '                verLlegadaOrigen.Checked = True
                    '                fecLlegadaOrigen.Value = oeSegAnterior.SalidaDestino
                    '                hLlegadaOrigen.Value = oeSegAnterior.SalidaDestino.ToShortTimeString
                    '                oeSeguimiento.TipoOperacion = "1"
                    '                oeSeguimiento.IdViaje = txtViajeId.Text
                    '                oeSeguimiento.IdEstado = "CARGA"
                    '                oeSeguimiento.LlegadaOrigen = Date.Parse(fecLlegadaOrigen.Value.ToShortDateString & " " & hLlegadaOrigen.Value.ToShortTimeString)
                    '                oeSeguimiento.IndLlegadaOrigen = 1
                    '                olSeguimiento.Guardar(oeSeguimiento)
                    '                Marcas()
                    '            Else
                    '                mensajeEmergente.Confirmacion("El sistema ha detectado un viaje previo FINALIZADO" & Environment.NewLine & _
                    '                                   "La Fecha y Hora de Llegada Destino: " & oeSegAnterior.LlegadaDestino & Environment.NewLine & _
                    '                                   "Será considerada como Llegada Origen para este viaje" & Environment.NewLine & _
                    '                                   "La Fecha y Hora de Inicio Descarga Destino: " & oeSegAnterior.DescargaDestino & Environment.NewLine & _
                    '                                   "Será considerada como Inicio Carga Origen para este viaje" & Environment.NewLine & _
                    '                                   "La Fecha y Hora de Termino Descarga Destino: " & oeSegAnterior.TerminoDescargaDestino & Environment.NewLine & _
                    '                                   "Será considerada como Termino Carga Origen para este viaje" & Environment.NewLine & _
                    '                                   "La Fecha y Hora de Salida Destino: " & oeSegAnterior.SalidaDestino & Environment.NewLine & _
                    '                                   "Será considerada como Salida Origen para este viaje", True)

                    '                verLlegadaOrigen.Checked = True
                    '                fecLlegadaOrigen.Value = oeSegAnterior.LlegadaDestino
                    '                hLlegadaOrigen.Value = oeSegAnterior.LlegadaDestino.ToShortTimeString
                    '                With oeSeguimiento
                    '                    .TipoOperacion = "1"
                    '                    .IdViaje = txtViajeId.Text
                    '                    .IdEstado = "CARGA"
                    '                    .LlegadaOrigen = Date.Parse(fecLlegadaOrigen.Value.ToShortDateString & " " & hLlegadaOrigen.Value.ToShortTimeString)
                    '                    .IndLlegadaOrigen = 1
                    '                End With
                    '                olSeguimiento.Guardar(oeSeguimiento)

                    '                verCargaOrigen.Checked = True
                    '                fecCargaOrigen.Value = oeSegAnterior.DescargaDestino
                    '                hCargaOrigen.Value = oeSegAnterior.DescargaDestino.ToShortTimeString
                    '                With oeSeguimiento
                    '                    .TipoOperacion = "3"
                    '                    .IdViaje = txtViajeId.Text
                    '                    .IdEstado = "CARGA"
                    '                    .CargaOrigen = Date.Parse(fecCargaOrigen.Value.ToShortDateString & " " & hCargaOrigen.Value.ToShortTimeString)
                    '                    .IndCargaOrigen = 1
                    '                End With
                    '                olSeguimiento.Guardar(oeSeguimiento)

                    '                verTerminoCargaOrigen.Checked = True
                    '                fecTerminoCargaOrigen.Value = oeSegAnterior.TerminoDescargaDestino
                    '                hTerminoCargaOrigen.Value = oeSegAnterior.TerminoDescargaDestino.ToShortTimeString
                    '                With oeSeguimiento
                    '                    .TipoOperacion = "4"
                    '                    .IdViaje = txtViajeId.Text
                    '                    .IdEstado = "CARGA"
                    '                    .TerminoCargaOrigen = Date.Parse(fecTerminoCargaOrigen.Value.ToShortDateString & " " & hTerminoCargaOrigen.Value.ToShortTimeString)
                    '                    .IndTerminoCargaOrigen = 1
                    '                End With
                    '                olSeguimiento.Guardar(oeSeguimiento)

                    '                verSalidaOrigen.Checked = True
                    '                fecSalidaOrigen.Value = oeSegAnterior.SalidaDestino
                    '                hSalidaOrigen.Value = oeSegAnterior.SalidaDestino.ToShortTimeString
                    '                With oeSeguimiento
                    '                    .TipoOperacion = "6"
                    '                    .IdViaje = txtViajeId.Text
                    '                    .IdEstado = "TRANSITO"
                    '                    .SalidaOrigen = Date.Parse(fecSalidaOrigen.Value.ToShortDateString & " " & hSalidaOrigen.Value.ToShortTimeString)
                    '                    .IndSalidaOrigen = 1
                    '                End With
                    '                olSeguimiento.Guardar(oeSeguimiento)

                    '                InformacionTractoCarreta(1, 0, 1, 0, 1, 0)
                    '                SalidaOrigenIndicador = True
                    '                tabGuias.Tabs(0).Selected = True
                    '                tabGuias.Tabs(0).Enabled = True
                    '                tabGuias.Tabs(1).Enabled = True
                    '                cboRemitente.Focus()
                    '                cboDestinatario.Focus()
                    '                txtGrt.Focus()

                    '                Marcas()
                    '                Exit For
                    '            End If
                    '        End If
                    '    End If
                    'Next
                End If
            Else
                grupoMarca01.Visible = False
                grupoMarca02.Visible = True

                oeSeguimiento = New e_Seguimiento
                oeSeguimiento.Id = ""
                oeSeguimiento.IdViaje = oeViaje.Id
                oeSeguimiento = olSeguimiento.Obtener(oeSeguimiento)

                oeRuta = New e_Ruta
                oeRuta.IdOrigen = oeViaje.IdOrigen
                oeRuta.IdDestino = oeViaje.IdDestino
                oeRuta = olRuta.Obtener(oeRuta)
                RutaKilometros = oeRuta.Kilometros
                If oeRuta.Id = "" Then oeRuta.Id = "0"
                oeTiempoCiclo.TipoOperacion = "1"
                oeTiempoCiclo.IdRuta = oeRuta.Id
                oeTiempoCiclo = olTiempoCiclo.Obtener(oeTiempoCiclo)

                If oeTiempoCiclo.Id = "" Then
                    HorasCarga = 1
                    HorasTraslado = 1
                    HorasDescarga = 1

                Else
                    HorasCarga = oeTiempoCiclo.HorasCarga
                    HorasTraslado = oeTiempoCiclo.HorasTraslado
                    HorasDescarga = oeTiempoCiclo.HorasDescarga
                End If

                verLlegadaOrigenE.Checked = oeSeguimiento.IndLlegadaOrigen
                If verLlegadaOrigenE.Checked Then
                    fecLlegadaOrigenE.Value = oeSeguimiento.LlegadaOrigen
                    hLlegadaOrigenE.Value = oeSeguimiento.LlegadaOrigen.ToShortTimeString
                Else
                    'hLlegadaOrigenE.Value = TimeOfDay.ToShortTimeString
                    hLlegadaOrigenE.Value = hViaje.Value.AddHours(0.05).ToShortTimeString
                    fecLlegadaOrigenE.Value = DateAdd(DateInterval.Minute, 3, Date.Parse(fecViaje.Value.ToShortDateString & " " & hViaje.Value.ToShortTimeString))

                End If

                verIngresoComplejoOrigenE.Checked = oeSeguimiento.IndIngresoComplejoOrigen
                If verIngresoComplejoOrigenE.Checked Then
                    fecIngresoComplejoOrigenE.Value = oeSeguimiento.IngresoComplejoOrigen
                    hIngresoComplejoOrigenE.Value = oeSeguimiento.IngresoComplejoOrigen.ToShortTimeString
                Else
                    'fecIngresoComplejoOrigenE.Value = Date.Today
                    'hIngresoComplejoOrigenE.Value = TimeOfDay.ToShortTimeString
                    hIngresoComplejoOrigenE.Value = hLlegadaOrigenE.Value.AddHours(0.05).ToShortTimeString
                    fecIngresoComplejoOrigenE.Value = DateAdd(DateInterval.Minute, 3, Date.Parse(fecLlegadaOrigenE.Value.ToShortDateString & " " & hLlegadaOrigenE.Value.ToShortTimeString))

                End If

                verCargaOrigenE.Checked = oeSeguimiento.IndCargaOrigen
                If verCargaOrigenE.Checked Then
                    fecCargaOrigenE.Value = oeSeguimiento.CargaOrigen
                    hCargaOrigenE.Value = oeSeguimiento.CargaOrigen.ToShortTimeString
                Else
                    'fecCargaOrigenE.Value = Date.Today
                    'hCargaOrigenE.Value = TimeOfDay.ToShortTimeString
                    hCargaOrigenE.Value = hIngresoComplejoOrigenE.Value.AddHours(0.05).ToShortTimeString
                    fecCargaOrigenE.Value = DateAdd(DateInterval.Minute, 3, Date.Parse(fecIngresoComplejoOrigenE.Value.ToShortDateString & " " & hIngresoComplejoOrigenE.Value.ToShortTimeString))
                End If

                verTerminoCargaOrigenE.Checked = oeSeguimiento.IndTerminoCargaOrigen
                If verTerminoCargaOrigenE.Checked Then
                    fecTerminoCargaOrigenE.Value = oeSeguimiento.TerminoCargaOrigen
                    hTerminoCargaOrigenE.Value = oeSeguimiento.TerminoCargaOrigen.ToShortTimeString
                Else
                    hTerminoCargaOrigenE.Value = hCargaOrigenE.Value.AddHours(HorasCarga).ToShortTimeString
                    fecTerminoCargaOrigenE.Value = DateAdd(DateInterval.Hour, HorasCarga, Date.Parse(fecCargaOrigenE.Value.ToShortDateString & " " & hCargaOrigenE.Value.ToShortTimeString))
                End If

                verImpresionGuiaOrigenE.Checked = oeSeguimiento.IndImpresionGuiaOrigen
                If verImpresionGuiaOrigenE.Checked Then
                    fecImpresionGuiaOrigenE.Value = oeSeguimiento.ImpresionGuiaOrigen
                    hImpresionGuiaOrigenE.Value = oeSeguimiento.ImpresionGuiaOrigen.ToShortTimeString
                Else
                    hImpresionGuiaOrigenE.Value = hTerminoCargaOrigenE.Value.AddHours(0.05).ToShortTimeString
                    fecImpresionGuiaOrigenE.Value = DateAdd(DateInterval.Minute, 3, Date.Parse(fecTerminoCargaOrigenE.Value.ToShortDateString & " " & hTerminoCargaOrigenE.Value.ToShortTimeString))
                End If

                verSalidaOrigenE.Checked = oeSeguimiento.IndSalidaOrigen
                If verSalidaOrigenE.Checked Then
                    fecSalidaOrigenE.Value = oeSeguimiento.SalidaOrigen
                    hSalidaOrigenE.Value = oeSeguimiento.SalidaOrigen.ToShortTimeString
                Else
                    hSalidaOrigenE.Value = hImpresionGuiaOrigenE.Value.AddHours(0.05).ToShortTimeString
                    fecSalidaOrigenE.Value = DateAdd(DateInterval.Minute, 3, Date.Parse(fecImpresionGuiaOrigenE.Value.ToShortDateString & " " & hImpresionGuiaOrigenE.Value.ToShortTimeString))
                End If

                verLlegadaAproximadaDestinoE.Checked = oeSeguimiento.IndLlegadaAproximadaDestino
                If verLlegadaAproximadaDestinoE.Checked Then
                    fecLlegadaAproximadaDestinoE.Value = oeSeguimiento.LlegadaAproximadaDestino
                    hLlegadaAproximadaDestinoE.Value = oeSeguimiento.LlegadaAproximadaDestino.ToShortTimeString
                Else
                    hLlegadaAproximadaDestinoE.Value = hSalidaOrigenE.Value.AddHours(HorasTraslado).ToShortTimeString
                    fecLlegadaAproximadaDestinoE.Value = DateAdd(DateInterval.Hour, HorasTraslado, Date.Parse(fecSalidaOrigenE.Value.ToShortDateString & " " & hSalidaOrigenE.Value.ToShortTimeString))
                End If

                verLlegadaDestinoE.Checked = oeSeguimiento.IndLlegadaDestino
                If verLlegadaDestinoE.Checked Then
                    fecLlegadaDestinoE.Value = oeSeguimiento.LlegadaDestino
                    hLlegadaDestinoE.Value = oeSeguimiento.LlegadaDestino.ToShortTimeString
                Else
                    'fecLlegadaDestinoE.Value = Date.Today
                    hLlegadaDestinoE.Value = hLlegadaAproximadaDestinoE.Value.AddHours(0.05).ToShortTimeString
                    fecLlegadaDestinoE.Value = DateAdd(DateInterval.Minute, 3, Date.Parse(fecLlegadaAproximadaDestinoE.Value.ToShortDateString & " " & hLlegadaAproximadaDestinoE.Value.ToShortTimeString))
                End If

                verIngresoDestinoE.Checked = oeSeguimiento.IndIngresoDestino
                If verIngresoDestinoE.Checked Then
                    fecIngresoDestinoE.Value = oeSeguimiento.IngresoDestino
                    hIngresoDestinoE.Value = oeSeguimiento.IngresoDestino.ToShortTimeString
                Else
                    'hIngresoDestinoE.Value = hSalidaOrigenE.Value.AddHours(HorasTraslado).ToShortTimeString
                    'fecIngresoDestinoE.Value = DateAdd(DateInterval.Hour, HorasTraslado, Date.Parse(fecSalidaOrigenE.Value.ToShortDateString & " " & hSalidaOrigenE.Value.ToShortTimeString))
                    hIngresoDestinoE.Value = hLlegadaDestinoE.Value.AddHours(0.05).ToShortTimeString
                    fecIngresoDestinoE.Value = DateAdd(DateInterval.Minute, 3, Date.Parse(fecLlegadaDestinoE.Value.ToShortDateString & " " & hLlegadaDestinoE.Value.ToShortTimeString))
                End If

                verDescargaDestinoE.Checked = oeSeguimiento.IndDescargaDestino
                If verDescargaDestinoE.Checked Then
                    fecDescargaDestinoE.Value = oeSeguimiento.DescargaDestino
                    hDescargaDestinoE.Value = oeSeguimiento.DescargaDestino.ToShortTimeString
                Else
                    hDescargaDestinoE.Value = hIngresoDestinoE.Value.AddHours(0.05).ToShortTimeString
                    fecDescargaDestinoE.Value = DateAdd(DateInterval.Minute, 3, Date.Parse(fecIngresoDestinoE.Value.ToShortDateString & " " & hIngresoDestinoE.Value.ToShortTimeString))
                End If

                verTerminoDescargaDestinoE.Checked = oeSeguimiento.IndTerminoDescargaDestino
                If verTerminoDescargaDestinoE.Checked Then
                    fecTerminoDescargaDestinoE.Value = oeSeguimiento.TerminoDescargaDestino
                    hTerminoDescargaDestinoE.Value = oeSeguimiento.TerminoDescargaDestino.ToShortTimeString
                Else
                    hTerminoDescargaDestinoE.Value = hDescargaDestinoE.Value.AddHours(HorasDescarga).ToShortTimeString
                    fecTerminoDescargaDestinoE.Value = DateAdd(DateInterval.Hour, HorasDescarga, Date.Parse(fecDescargaDestinoE.Value.ToShortDateString & " " & hDescargaDestinoE.Value.ToShortTimeString))
                End If

                verSalidaDestinoE.Checked = oeSeguimiento.IndSalidaDestino
                If verSalidaDestinoE.Checked Then
                    fecSalidaDestinoE.Value = oeSeguimiento.SalidaDestino
                    hSalidaDestinoE.Value = oeSeguimiento.SalidaDestino.ToShortTimeString
                Else
                    hSalidaDestinoE.Value = hTerminoDescargaDestinoE.Value.AddHours(0.05).ToShortTimeString
                    fecSalidaDestinoE.Value = DateAdd(DateInterval.Minute, 3, Date.Parse(fecTerminoDescargaDestinoE.Value.ToShortDateString & " " & hTerminoDescargaDestinoE.Value.ToShortTimeString))
                End If

                oeSeguimientoAnterior = New e_Seguimiento
                oeSeguimientoAnterior.TipoOperacion = 2
                oeSeguimientoAnterior.IdOperacion = oeViaje.IdTracto
                'oeSeguimientoAnterior.IdTracto = oeViaje.IdTracto
                oeSeguimientoAnterior.IdEstado = "1CH00010"
                ListaSeguimiento = olSeguimiento.Listar2(oeSeguimientoAnterior)
                If ListaSeguimiento.Count > 0 Then
                    If ListaSeguimiento(0).IdEstado = "1CH00010" Then
                        If verLlegadaOrigenE.Checked = False And verIngresoComplejoOrigenE.Checked = False And verCargaOrigenE.Checked = False And verTerminoCargaOrigenE.Checked = False And verImpresionGuiaOrigenE.Checked = False And verSalidaOrigenE.Checked = False Then
                            If ListaSeguimiento(0).ViajeVacio = 1 Then
                                Select Case MessageBox.Show("El sistema ha detectado un viaje previo FINALIZADO" & Environment.NewLine & _
                                                   "La Fecha y Hora de Salida Destino: " & ListaSeguimiento(0).SalidaDestino & Environment.NewLine & _
                                                   "Será considerada como Llegada Origen para este viaje", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                                    Case Windows.Forms.DialogResult.Yes
                                        'mensajeEmergente.Confirmacion("El sistema ha detectado un viaje previo FINALIZADO" & Environment.NewLine & _
                                        '           "La Fecha y Hora de Salida Destino: " & ListaSeguimiento(0).SalidaDestino & Environment.NewLine & _
                                        '           "Será considerada como Llegada Origen para este viaje", True)

                                        'llegada origen 
                                        If ListaSeguimiento(0).IndLlegadaDestino = 1 Then
                                            verLlegadaOrigenE.Checked = True
                                            fecLlegadaOrigenE.Value = ListaSeguimiento(0).LlegadaDestino
                                            hLlegadaOrigenE.Value = ListaSeguimiento(0).LlegadaDestino.ToShortTimeString
                                            With oeSeguimiento
                                                .TipoOperacion = "1"
                                                .IdViaje = txtViajeId.Text
                                                .IdEstado = "CARGA"
                                                .LlegadaOrigen = Date.Parse(fecLlegadaOrigenE.Value.ToShortDateString & " " & hLlegadaOrigenE.Value.ToShortTimeString)
                                                .IndLlegadaOrigen = 1
                                            End With
                                            oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
                                            olSeguimiento.Guardar(oeSeguimiento)
                                        End If

                                        'ingreso origen 
                                        If ListaSeguimiento(0).IndIngresoDestino = 1 Then
                                            verIngresoComplejoOrigenE.Checked = True
                                            fecIngresoComplejoOrigenE.Value = ListaSeguimiento(0).IngresoDestino
                                            hIngresoComplejoOrigenE.Value = ListaSeguimiento(0).IngresoDestino.ToShortTimeString
                                            With oeSeguimiento
                                                .TipoOperacion = "2"
                                                .IdViaje = txtViajeId.Text
                                                .IdEstado = "CARGA"
                                                .IngresoComplejoOrigen = Date.Parse(fecIngresoComplejoOrigenE.Value.ToShortDateString & " " & hIngresoComplejoOrigenE.Value.ToShortTimeString)
                                                .IndIngresoComplejoOrigen = 1
                                            End With
                                            oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
                                            olSeguimiento.Guardar(oeSeguimiento)
                                        End If

                                        'inicio carga origen
                                        If ListaSeguimiento(0).IndDescargaDestino = 1 Then
                                            verCargaOrigenE.Checked = True
                                            fecCargaOrigenE.Value = ListaSeguimiento(0).DescargaDestino
                                            hCargaOrigenE.Value = ListaSeguimiento(0).DescargaDestino.ToShortTimeString
                                            With oeSeguimiento
                                                .TipoOperacion = "3"
                                                .IdViaje = txtViajeId.Text
                                                .IdEstado = "CARGA"
                                                .CargaOrigen = Date.Parse(fecCargaOrigenE.Value.ToShortDateString & " " & hCargaOrigenE.Value.ToShortTimeString)
                                                .IndCargaOrigen = 1
                                            End With
                                            oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
                                            olSeguimiento.Guardar(oeSeguimiento)
                                        End If

                                        'termino carga origen
                                        If ListaSeguimiento(0).IndTerminoDescargaDestino = 1 Then
                                            verTerminoCargaOrigenE.Checked = True
                                            fecTerminoCargaOrigenE.Value = ListaSeguimiento(0).TerminoDescargaDestino
                                            hTerminoCargaOrigenE.Value = ListaSeguimiento(0).TerminoDescargaDestino.ToShortTimeString
                                            With oeSeguimiento
                                                .TipoOperacion = "4"
                                                .IdViaje = txtViajeId.Text
                                                .IdEstado = "CARGA"
                                                .TerminoCargaOrigen = Date.Parse(fecTerminoCargaOrigenE.Value.ToShortDateString & " " & hTerminoCargaOrigenE.Value.ToShortTimeString)
                                                .IndTerminoCargaOrigen = 1
                                            End With
                                            oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
                                            olSeguimiento.Guardar(oeSeguimiento)
                                        End If

                                        'ImpresionGuiaOrigen origen
                                        If ListaSeguimiento(0).IndTerminoDescargaDestino = 1 Then
                                            verImpresionGuiaOrigenE.Checked = True
                                            fecImpresionGuiaOrigenE.Value = ListaSeguimiento(0).TerminoDescargaDestino
                                            hImpresionGuiaOrigenE.Value = ListaSeguimiento(0).TerminoDescargaDestino.ToShortTimeString
                                            With oeSeguimiento
                                                .TipoOperacion = "5"
                                                .IdViaje = txtViajeId.Text
                                                .IdEstado = "CARGA"
                                                .ImpresionGuiaOrigen = Date.Parse(fecImpresionGuiaOrigenE.Value.ToShortDateString & " " & hImpresionGuiaOrigenE.Value.ToShortTimeString)
                                                .IndImpresionGuiaOrigen = 1
                                            End With
                                            oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
                                            olSeguimiento.Guardar(oeSeguimiento)
                                        End If

                                        'salida origen
                                        If ListaSeguimiento(0).IndSalidaDestino = 1 Then
                                            verSalidaOrigenE.Checked = True
                                            fecSalidaOrigenE.Value = ListaSeguimiento(0).SalidaDestino
                                            hSalidaOrigenE.Value = ListaSeguimiento(0).SalidaDestino.ToShortTimeString
                                            With oeSeguimiento
                                                .TipoOperacion = "6"
                                                .IdViaje = txtViajeId.Text
                                                .IdEstado = "TRANSITO"
                                                .SalidaOrigen = Date.Parse(fecSalidaOrigenE.Value.ToShortDateString & " " & hSalidaOrigenE.Value.ToShortTimeString)
                                                .IndSalidaOrigen = 1
                                            End With
                                            oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
                                            olSeguimiento.Guardar(oeSeguimiento)
                                        End If

                                        Marcas()
                                End Select
                            Else
                                Select Case MessageBox.Show("El sistema ha detectado un viaje previo FINALIZADO" & Environment.NewLine & _
                                                  "La Fecha y Hora de Llegada Destino: " & ListaSeguimiento(0).LlegadaDestino & Environment.NewLine & _
                                                  "Será considerada como Llegada Origen para este viaje" & Environment.NewLine & _
                                                  "La Fecha y Hora de Ingreso Destino: " & ListaSeguimiento(0).IngresoDestino & Environment.NewLine & _
                                                  "Será considerada como Ingreso Complejo Origen para este viaje" & Environment.NewLine & _
                                                  "La Fecha y Hora de Inicio Descarga Destino: " & ListaSeguimiento(0).DescargaDestino & Environment.NewLine & _
                                                  "Será considerada como Inicio Carga Origen para este viaje" & Environment.NewLine & _
                                                  "La Fecha y Hora de Termino Descarga Destino: " & ListaSeguimiento(0).TerminoDescargaDestino & Environment.NewLine & _
                                                  "Será considerada como Termino Carga Origen y Impresion Guia Origen para este viaje" & Environment.NewLine & _
                                                  "La Fecha y Hora de Salida Destino: " & ListaSeguimiento(0).SalidaDestino & Environment.NewLine & _
                                                  "Será considerada como Salida Origen para este viaje", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                                    Case Windows.Forms.DialogResult.Yes
                                        'mensajeEmergente.Confirmacion("El sistema ha detectado un viaje previo FINALIZADO" & Environment.NewLine & _
                                        '          "La Fecha y Hora de Llegada Destino: " & ListaSeguimiento(0).LlegadaDestino & Environment.NewLine & _
                                        '          "Será considerada como Llegada Origen para este viaje" & Environment.NewLine & _
                                        '          "La Fecha y Hora de Ingreso Destino: " & ListaSeguimiento(0).IngresoDestino & Environment.NewLine & _
                                        '          "Será considerada como Ingreso Complejo Origen para este viaje" & Environment.NewLine & _
                                        '          "La Fecha y Hora de Inicio Descarga Destino: " & ListaSeguimiento(0).DescargaDestino & Environment.NewLine & _
                                        '          "Será considerada como Inicio Carga Origen para este viaje" & Environment.NewLine & _
                                        '          "La Fecha y Hora de Termino Descarga Destino: " & ListaSeguimiento(0).TerminoDescargaDestino & Environment.NewLine & _
                                        '          "Será considerada como Termino Carga Origen y Impresion Guia Origen para este viaje" & Environment.NewLine & _
                                        '          "La Fecha y Hora de Salida Destino: " & ListaSeguimiento(0).SalidaDestino & Environment.NewLine & _
                                        '          "Será considerada como Salida Origen para este viaje", True)

                                        If ListaSeguimiento(0).IndLlegadaDestino = 1 Then
                                            verLlegadaOrigenE.Checked = True
                                            fecLlegadaOrigenE.Value = ListaSeguimiento(0).LlegadaDestino
                                            hLlegadaOrigenE.Value = ListaSeguimiento(0).LlegadaDestino.ToShortTimeString
                                            With oeSeguimiento
                                                .TipoOperacion = "1"
                                                .IdViaje = txtViajeId.Text
                                                .IdEstado = "CARGA"
                                                .LlegadaOrigen = Date.Parse(fecLlegadaOrigenE.Value.ToShortDateString & " " & hLlegadaOrigenE.Value.ToShortTimeString)
                                                .IndLlegadaOrigen = 1
                                            End With
                                            oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
                                            olSeguimiento.Guardar(oeSeguimiento)
                                        End If


                                        If ListaSeguimiento(0).IndIngresoDestino = 1 Then
                                            verIngresoComplejoOrigenE.Checked = True
                                            fecIngresoComplejoOrigenE.Value = ListaSeguimiento(0).IngresoDestino
                                            hIngresoComplejoOrigenE.Value = ListaSeguimiento(0).IngresoDestino.ToShortTimeString
                                            With oeSeguimiento
                                                .TipoOperacion = "2"
                                                .IdViaje = txtViajeId.Text
                                                .IdEstado = "CARGA"
                                                .IngresoComplejoOrigen = Date.Parse(fecIngresoComplejoOrigenE.Value.ToShortDateString & " " & hIngresoComplejoOrigenE.Value.ToShortTimeString)
                                                .IndIngresoComplejoOrigen = 1
                                            End With
                                            oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
                                            olSeguimiento.Guardar(oeSeguimiento)
                                        End If


                                        If ListaSeguimiento(0).IndDescargaDestino = 1 Then
                                            verCargaOrigenE.Checked = True
                                            fecCargaOrigenE.Value = ListaSeguimiento(0).DescargaDestino
                                            hCargaOrigenE.Value = ListaSeguimiento(0).DescargaDestino.ToShortTimeString
                                            With oeSeguimiento
                                                .TipoOperacion = "3"
                                                .IdViaje = txtViajeId.Text
                                                .IdEstado = "CARGA"
                                                .CargaOrigen = Date.Parse(fecCargaOrigenE.Value.ToShortDateString & " " & hCargaOrigenE.Value.ToShortTimeString)
                                                .IndCargaOrigen = 1
                                            End With
                                            oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
                                            olSeguimiento.Guardar(oeSeguimiento)
                                        End If


                                        If ListaSeguimiento(0).IndTerminoDescargaDestino = 1 Then
                                            verTerminoCargaOrigenE.Checked = True
                                            fecTerminoCargaOrigenE.Value = ListaSeguimiento(0).TerminoDescargaDestino
                                            hTerminoCargaOrigenE.Value = ListaSeguimiento(0).TerminoDescargaDestino.ToShortTimeString
                                            With oeSeguimiento
                                                .TipoOperacion = "4"
                                                .IdViaje = txtViajeId.Text
                                                .IdEstado = "CARGA"
                                                .TerminoCargaOrigen = Date.Parse(fecTerminoCargaOrigenE.Value.ToShortDateString & " " & hTerminoCargaOrigenE.Value.ToShortTimeString)
                                                .IndTerminoCargaOrigen = 1
                                            End With
                                            oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
                                            olSeguimiento.Guardar(oeSeguimiento)
                                        End If


                                        If ListaSeguimiento(0).IndTerminoDescargaDestino = 1 Then
                                            verImpresionGuiaOrigenE.Checked = True
                                            fecImpresionGuiaOrigenE.Value = ListaSeguimiento(0).TerminoDescargaDestino
                                            hImpresionGuiaOrigenE.Value = ListaSeguimiento(0).TerminoDescargaDestino.ToShortTimeString
                                            With oeSeguimiento
                                                .TipoOperacion = "5"
                                                .IdViaje = txtViajeId.Text
                                                .IdEstado = "CARGA"
                                                .ImpresionGuiaOrigen = Date.Parse(fecImpresionGuiaOrigenE.Value.ToShortDateString & " " & hImpresionGuiaOrigenE.Value.ToShortTimeString)
                                                .IndImpresionGuiaOrigen = 1
                                            End With
                                            oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
                                            olSeguimiento.Guardar(oeSeguimiento)
                                        End If


                                        If ListaSeguimiento(0).IndSalidaDestino = 1 Then
                                            verSalidaOrigenE.Checked = True
                                            fecSalidaOrigenE.Value = ListaSeguimiento(0).SalidaDestino
                                            hSalidaOrigenE.Value = ListaSeguimiento(0).SalidaDestino.ToShortTimeString
                                            With oeSeguimiento
                                                .TipoOperacion = "6"
                                                .IdViaje = txtViajeId.Text
                                                .IdEstado = "TRANSITO"
                                                .SalidaOrigen = Date.Parse(fecSalidaOrigenE.Value.ToShortDateString & " " & hSalidaOrigenE.Value.ToShortTimeString)
                                                .IndSalidaOrigen = 1
                                            End With
                                            oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
                                            olSeguimiento.Guardar(oeSeguimiento)
                                        End If


                                        InformacionTractoCarreta(1, 0, 1, 0, 1, 0)
                                        SalidaOrigenIndicador = True
                                        tabGuias.Tabs(0).Selected = True
                                        tabGuias.Tabs(0).Enabled = True
                                        tabGuias.Tabs(1).Enabled = True
                                        cboRemitente.Focus()
                                        cboDestinatario.Focus()
                                        txtGrt.Focus()

                                        Marcas()
                                End Select


                            End If
                        End If
                    End If
                End If
            End If
            lblKmTractoDestino.Text = "Dest:" & txtKmTractoOrigen.Value + RutaKilometros
            'lblHrTractoDestino.Text = "Dest:" & oeSeguimiento.HorasRecorreOrigen
            lblKmCarretaDestino.Text = "Dest:" & txtKmCarretaOrigen.Value + RutaKilometros
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ValidarPeso()
        Try
            If oeViaje.ViajeVacio = 0 Then
                If txtPesoToneladas.Value = 0 Then
                    txtPesoToneladas.Focus()
                    Throw New Exception("Tiene que Ingresar el Peso para Cerrar el Viaje")
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GuardarSeguimiento() As Boolean
        Try
            fecViaje.Focus()
            ugb_Espera.Visible = True
            If ValidaCamposCabecera() Then
                ' txtPesoToneladas.Update()
                With oeSeguimiento
                    .Id = txtSeguimientoId.Text
                    .TipoOperacion = "A"
                    .KmTractoOrigen = txtKmTractoOrigen.Text
                    .KmTractoDestino = txtKmTractoDestino.Text
                    .KmCarretaOrigen = txtKmCarretaOrigen.Text
                    .KmCarretaDestino = txtKmCarretaDestino.Text
                    .HorasRecorreOrigen = txtHorasTractoOrigen.Text
                    .HorasRecorreDestino = txtHorasTractoDestino.Text
                    .Observacion = txtObservacion.Text
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .PesoToneladas = txtPesoToneladas.Value
                    .IngresoGRT = False
                    .Cantidad = txtCantidad.Text
                    .IdTracto = txtIdTracto.Text
                    .IdCarreta = txtIdCarreta.Text
                    .IdClienteLugar = cboLugarTienda.Value
                    .PilotoConf = IIf(verPilotoConf.Checked, 1, 0)
                    .CopilotoConf = IIf(verCopilotoConf.Checked, 1, 0)
                    .TractoConf = IIf(verTractoConf.Checked, 1, 0)
                    .CarretaConf = IIf(verCarretaConf.Checked, 1, 0)
                    .ClienteConf = IIf(verClienteConf.Checked, 1, 0)
                    .IndFallaOP = IIf(verIndFallaOP.Checked, 1, 0)
                    .FechaFalla = Date.Parse(fecFalla.Value.ToShortDateString & " " & hFalla.Value.ToShortTimeString)
                    .GlosaFalla = txtGlosaFalla.Text
                    If GuiasIngresoGRT = False Then
                        .GuiaTransportista = griGuiaTransportista.DataSource
                        .GuiaRemitente = griGuiaRemitente.DataSource
                        .GuiaTransportistaInterrumpida = griViajeInterrumpido.DataSource
                        .OperacionDetalle = griViajeDetalle.DataSource
                        .IngresoGRT = True
                    End If
                    oeSeguimiento.IncidenciaAutentificadas = IncidenciasPublic
                End With
                FiltrarLista()
                oeSeguimiento.oeListaBitacora = ListaBitacora
                oeSeguimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
                If olSeguimiento.Guardar(oeSeguimiento) Then
                    mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                    'Consultar(True)
                    ActualizaRegistroEditado(RegistroEditado, IdRegistroEditado)
                    Operacion = "Inicializa"
                    If griLista.Rows.Count > 0 Then
                        ControlBoton(1, 0, 1, 0, 0, 0, 1, 1, 1)
                        griLista.ActiveRow.CellAppearance.BackColor = Me.colorCambio.Color
                    Else
                        ControlBoton(1, 0, 1, 0, 0, 0, 1, 0, 1)
                    End If
                End If
                IncidenciasPublic = New e_IncidenciasAutentificadas
            End If
            ugb_Espera.Visible = False
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            ugb_Espera.Visible = False
        End Try
    End Function

    Private Function ValidaCamposCabecera() As Boolean
        Try
            If SalidaOrigenIndicador = True AndAlso CDbl(txtKmTractoOrigen.Text) = 0 Then
                Me.txtKmTractoOrigen.Focus()
                Me.txtKmTractoOrigen.Select()
                Throw New Exception("Aun no ha Actualizado el KM de Tracto Origen. No Podra Guardar los Cambios, mientras no Ingrese el KM Tracto Origen")
            End If

            If SalidaDestinoIndicador = True AndAlso CDbl(txtKmTractoDestino.Text) = 0 Then
                Me.txtKmTractoDestino.Focus()
                Me.txtKmTractoDestino.Select()
                Throw New Exception("Aun no ha Actualizado el KM de Tracto Destino. No Podra Terminar el Seguimiento, mientras no Ingrese el KM Tracto Destino")
            End If

            If ValidaKilometrajeOrigen() Then
                If ValidaKilometrajeDestino() Then
                    ValidarPeso()
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidaViajeInterrumpido() As Boolean
        Try
            ValidarCombo(cboMotivoTrasladoInterrumpido, "Motivo Traslado Interrumpido")
            l_FuncionesGenerales.ValidarCampoNoNulo(txtGuiaTransportista.Text, "Seleccione una GuiaTransportita")
            Return True
        Catch ex As Exception
            EnfocarViajeInterrumpido(ex.Message)
            Throw ex
        End Try
    End Function

    Private Sub EnfocarViajeInterrumpido(ByVal excepcion As String)
        Select Case excepcion
            Case excepcion.Contains("Motivo Traslado Interrumpido")
                cboMotivoTrasladoInterrumpido.Focus()
            Case excepcion.Contains("Seleccione una GuiaTransportita")
                tabGuias.Tabs(0).Selected = True
                griGuiaTransportista.Focus()
        End Select
    End Sub

    Private Function ValidaCamposDetalle() As Boolean
        Try
            ValidarCombo(cboRemitente, "Remitente")
            ValidarCombo(cboDestinatario, "Destinatario")
            'If Not olDemanda.ValidarDetalle(oeDemandaDetalle) Then
            '    Exit Function
            'End If
            Return True
        Catch ex As Exception
            EnfocarDetalle(ex.Message)
            Throw ex
        End Try
    End Function

    Private Sub EnfocarDetalle(ByVal excepcion As String)
        Select Case excepcion
            Case excepcion.Contains("Remitente")
                cboRemitente.Focus()
            Case excepcion.Contains("Destinatario")
                cboDestinatario.Focus()
                'Case excepcion.Contains("Comisionista")
                '    cboComisionista.Focus()
                'Case excepcion.Contains("Tipo Carga") 
                '    cboTipoCarga.Focus()
                'Case excepcion.Contains("Material") 
                '    cboMaterial.Focus()
        End Select
    End Sub

    Public Sub ContarRegistros()
        Try
            '----- TOTAL Registros -----'
            Dim Items As SummarySettings = griLista.DisplayLayout.Bands(0).Summaries.Add("TotalRegistros", SummaryType.Count, griLista.DisplayLayout.Bands(0).Columns("Numero"))
            With Items
                .DisplayFormat = "Cantidad Registros: {0:#,###,##0}"
                .Appearance.TextHAlign = HAlign.Right
                .Appearance.TextVAlign = VAlign.Middle
                .Band.Override.SummaryDisplayArea = SummaryDisplayAreas.Top
                .Band.Override.SummaryFooterCaptionVisible = DefaultableBoolean.False
                .Band.Override.BorderStyleSummaryFooter = UIElementBorderStyle.Solid
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

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
                txtGrr.Focus()
                Throw New Exception("Nº Serie debe ser Menor o Igual a 4 Digitos, Separando Serie y Numero por un Guión (-): (0000-0000000000)")
            End If

            If ls_NroSerieFinal.Length > 4 Then
                txtGrr.Focus()
                Throw New Exception("Nº Serie debe ser Menor o Igual a 4 Digitos, Separando Serie y Numero por un Guión (-): (0000-0000000000)")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Function ValidarGuiaTransportista(ByVal txt_controlInicial As ISL.Controles.Texto) As Boolean
        Try
            Dim ls_Serie As String
            Dim ls_Numero As String

            Dim o_DocumentoGrtInicial() As String = txt_controlInicial.Text.Split("-")
            ls_Serie = o_DocumentoGrtInicial(0).ToString.Trim
            If ls_Serie.Length > 4 Then
                txt_controlInicial.Focus()
                Throw New Exception("Nº Serie debe ser Menor o Igual a 4 Digitos, Separando Serie y Numero por un Guión (-): (0000-0000000000)")
            End If

            If txt_controlInicial.Text.Trim.Length = 0 Or Not txt_controlInicial.Text.Contains("-") Then
                txt_controlInicial.Focus()
                Throw New Exception("Ingrese Correctamente Guía Remisión Transportita, Separando Serie y Numero por un Guión (-): (0000-0000000000)")
            End If

            ls_Numero = o_DocumentoGrtInicial(1).ToString.Trim
            If ls_Numero.Length < 1 Then
                txt_controlInicial.Focus()
                Throw New Exception("Numero Seguido de Serie debe ser Mayor a 1 Digitos, Separando Serie y Numero por un Guión (-): (0000-0000000000)")
            End If

            ls_Serie = FormatoDocumento(ls_Serie, 4)
            ls_Numero = FormatoDocumento(ls_Numero, 10)
            txtGrt.Text = ls_Serie & "-" & ls_Numero

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

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
            If txt_controlInicial.Name = "txtGrr" Then
                txtGrr.Text = ls_Serie & "-" & ls_Numero
            Else
                txtRangoGrr.Text = ls_Serie & "-" & ls_Numero
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub AgregarGrrRango(ByVal txt_controlGuiaInicial As ISL.Controles.Texto, _
                                            ByVal txt_controlguiaFinal As ISL.Controles.Texto)
        Try
            oeGuiaRemitente = New e_GuiaRemitente
            Dim ls_NroSerieInicial As String = "", _
                ls_NroSerieFinal As String = "", _
                ls_NroDocInicial As String = "", _
                ls_NroDocFinal As String = ""

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
                oeSeguimiento.GuiaRemitente = griGuiaRemitente.DataSource
                With oeGuiaRemitente
                    .Id = ""
                    .Serie = ls_NroSerie
                    .Numero = FormatoDocumento(ls_NroDocumento, 10)
                    .IdGuiaTransportista = ""
                    .GuiaTransportista = txtGrt.Text
                    .Fecha = fecEmisionGrr.Value
                    .Viaje = txtViajeCodigo.Text
                    .Glosa = txtGlosa.Text
                    .PrefijoID = gs_PrefijoIdSucursal '@0001
                End With
                oeSeguimiento.GuiaRemitente.Add(oeGuiaRemitente)
                griGuiaRemitente.DataBind()
                oeGuiaRemitente = New e_GuiaRemitente
            Next
            o_DocumentoInicial = Nothing
            o_DocumentoFinal = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AgregarGuias()
        Try
            If ValidaCamposDetalle() Then
                Dim ls_Serie As String = "", _
                    ls_Numero As String = ""
                Dim GuiaTransportistaCodigo() As String = txtGrt.Text.Split("-")
                ls_Serie = GuiaTransportistaCodigo(0).ToString.Trim
                ls_Numero = GuiaTransportistaCodigo(1).ToString.Trim
                oeGuiaTransportista = New e_GuiaTransportista
                oeSeguimiento.GuiaTransportista = griGuiaTransportista.DataSource
                With oeGuiaTransportista
                    .Id = ""
                    .Serie = ls_Serie
                    .Numero = ls_Numero
                    .IdSeguimiento = txtSeguimientoId.Text
                    .IdRemitente = cboRemitente.Value
                    .IdDireccionLugarPartida = cboPuntoPartida.Value
                    .IdDestinatario = cboDestinatario.Value
                    .IdDireccionLugarLlegada = cboPuntoLlegada.Value
                    .IdMotivoDocumentoTraslado = ""
                    .Glosa = txtGlosa.Text
                    .Fecha = fecEmisionGrt.Value
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .Activo = True
                    .Viaje = txtViajeCodigo.Text
                    .IdOperacionDetalle = ObtenerIdOperacionDetalle(Origen, Destino)
                    .Incidencia = ""
                    .IdSubContrata = ""
                    .SubSerie = ""
                    .SubNumero = ""
                    .PesoToneladas = txtGrtPT.Text
                    .IndFacturado = 0
                    .IndGrtConfirmada = 0
                    .IdVehiculo = IdVehiculo
                    .IndDocumentos = 0
                    .IndGrtPerdido = 0
                    .Cantidad = txtGrtCantidad.Text
                    .PrefijoID = gs_PrefijoIdSucursal '@0001
                End With
                oeSeguimiento.GuiaTransportista.Add(oeGuiaTransportista)
                griGuiaTransportista.DataBind()
                oeGuiaTransportista = New e_GuiaTransportista

                ProximoNumeroGRT = ls_Serie & "-" & ls_Numero + 1

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ObtenerIdOperacionDetalle(ByVal IdOrigen As String, ByVal IdDestino As String) As String
        Dim IdOperacionDetalle As String = ""
        For I As Integer = 0 To griViajeDetalle.Rows.Count - 1
            IdOperacionDetalle = ""
            With griViajeDetalle
                If .Rows(I).Cells("Origen").Value = IdOrigen And .Rows(I).Cells("Destino").Value = IdDestino Then
                    IdOperacionDetalle = .Rows(I).Cells("Id").Value
                End If
                If IdOperacionDetalle = "" Then
                    IdOperacionDetalle = .Rows(I).Cells("Id").Value
                End If
            End With
        Next
        Return IdOperacionDetalle
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
                oeGuiaRemitente = New e_GuiaRemitente
                With oeGuiaRemitente
                    .Id = ""
                    .Serie = ls_Serie
                    .Numero = ls_Numero
                    .IdGuiaTransportista = ""
                    .GuiaTransportista = txtGrt.Text
                    .Fecha = fecEmisionGrr.Value
                    .Viaje = txtViajeCodigo.Text
                    .Glosa = txtGlosa.Text
                    .PrefijoID = gs_PrefijoIdSucursal '@0001
                End With
                oeSeguimiento.GuiaRemitente.Add(oeGuiaRemitente)
                griGuiaRemitente.DataBind()
                oeGuiaRemitente = New e_GuiaRemitente
                txtGrr.Text = String.Empty
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Función para validar que la fecha de marcación de seguimiento para que no sea mayor que la fecha del servidor
    ''' </summary>
    ''' <param name="FechaViaje"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ValidarFechaServidor(FechaViaje As DateTime) As Boolean
        Try
            If FechaViaje.Date > FechaServidor Then
                FechaServidor = ObtenerFechaServidor()
                If FechaViaje.Date > FechaServidor Then
                    Throw New Exception("La fecha de marcacion excede a la fecha actual")
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidaGuiaTransportista(ByVal IdGuiaTransportista As String, _
                                         ByVal Serie As String, _
                                         ByVal Numero As String) As Boolean
        Try
            If IdGuiaTransportista = "" Then
                oeGuiaTransportista = New e_GuiaTransportista
                oeGuiaTransportista.Serie = Serie
                oeGuiaTransportista.Numero = Numero
                oeGuiaTransportista = olGuiaTransportista.Obtener(oeGuiaTransportista)
                If oeGuiaTransportista.Serie <> "" Then
                    Throw New Exception(oeGuiaTransportista.Serie & "-" & oeGuiaTransportista.Numero & " GRT fue Ingresado en Viaje: " & oeGuiaTransportista.Viaje)
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidaGuiaRemitente(ByVal Remitente As String, _
                                         ByVal Serie As String, _
                                         ByVal Numero As String) As Boolean
        Try

            oeGuiaRemitente = New e_GuiaRemitente
            oeGuiaRemitente.IdRemitente = Remitente
            oeGuiaRemitente.Serie = Serie
            oeGuiaRemitente.Numero = Numero
            oeGuiaRemitente = olGuiaRemitente.Obtener(oeGuiaRemitente)
            If oeGuiaRemitente.Serie <> "" Then
                Throw New Exception(oeGuiaRemitente.Serie & "-" & oeGuiaRemitente.Numero & " GRR fue Ingresado en Viaje: " & oeGuiaRemitente.Viaje)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidaLlegadaOrigen(ByVal LlegadaOrigen As Date) As Boolean
        Dim InicioViaje As Date
        InicioViaje = Date.Parse(fecViaje.Value.ToShortDateString & " " & hViaje.Value.ToShortTimeString)
        If LlegadaOrigen <= InicioViaje Then
            Marcas()
            ViajeVacio()
            Throw New Exception("La Fecha de Llegada de Origen no puede ser Igual o Anterior a la Fecha de Inicio de Viaje Salida de Planta")
        End If
        Return True
    End Function

    Private Function ValidaInicioCargaOrigen(ByVal InicioCargaOrigen As Date) As Boolean
        Try
            Dim LlegadaOrigen As Date
            LlegadaOrigen = Date.Parse(fecLlegadaOrigen.Value.ToShortDateString & " " & hLlegadaOrigen.Value.ToShortTimeString)
            If verLlegadaOrigen.Checked Then
                If InicioCargaOrigen <= LlegadaOrigen Then
                    Marcas()
                    Throw New Exception("La Fecha de Inicio Carga Origen no puede ser Igual o Anterior a la Fecha de Llegada Origen")
                End If
            Else
                Throw New Exception("Marque Fecha y Hora de Llegada Origen")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidaSalidaOrigen(ByVal SalidaOrigen As Date) As Boolean
        Try
            Dim TerminoCargaOrigen As Date
            TerminoCargaOrigen = Date.Parse(fecTerminoCargaOrigen.Value.ToShortDateString & " " & hTerminoCargaOrigen.Value.ToShortTimeString)
            If verTerminoCargaOrigen.Checked And verLlegadaOrigen.Checked Then
                If SalidaOrigen <= TerminoCargaOrigen Then
                    Marcas()
                    ViajeVacio()
                    Throw New Exception("La Fecha de Salida Origen no puede ser Igual o Anterior a la Fecha de Termino Carga Origen")
                End If
            Else
                Throw New Exception("Marque Fecha y Hora de Termino Carga Origen / Llegada Origen")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidaLlegadaDestino(ByVal LlegadaDestino As Date) As Boolean
        Dim SalidaOrigen As Date
        SalidaOrigen = Date.Parse(fecSalidaOrigen.Value.ToShortDateString & " " & hSalidaOrigen.Value.ToShortTimeString)
        If verSalidaOrigen.Checked Then
            If LlegadaDestino <= SalidaOrigen Then
                Marcas()
                ViajeVacio()
                Throw New Exception("La Fecha de Llegada Destino no puede ser Igual o Anterior a la Fecha de Salida Origen")
            End If
        Else
            Throw New Exception("Marque Fecha y Hora de Salida Origen")
        End If
        Return True
    End Function

    Private Function ValidaDescargaDestino(ByVal DescargaDestino As Date) As Boolean
        Try
            Dim LlegadaDestino As Date
            LlegadaDestino = Date.Parse(fecLlegadaDestino.Value.ToShortDateString & " " & hLlegadaDestino.Value.ToShortTimeString)
            If verLlegadaDestino.Checked Then
                If DescargaDestino <= LlegadaDestino Then
                    Marcas()
                    Throw New Exception("La Fecha de Descarga Destino no puede ser Igual o Anterior a la Fecha de Llegada Destino")
                End If
            Else
                Throw New Exception("Marque Fecha y Hora de Llegada Destino")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidaSalidaDestino(ByVal SalidaDestino As Date) As Boolean
        Try
            Dim TerminoDescargaDestino As Date
            TerminoDescargaDestino = Date.Parse(fecTerminoDescargaDestino.Value.ToShortDateString & " " & hTerminoDescargaDestino.Value.ToShortTimeString)
            If verTerminoDescargaDestino.Checked And verSalidaOrigen.Checked Then
                If SalidaDestino <= TerminoDescargaDestino Then
                    Marcas()
                    ViajeVacio()
                    Throw New Exception("La Fecha de Salida Destino no puede ser Igual o Anterior a la Fecha de Termino Descarga Destino")
                End If
                ValidarPeso()
            Else
                Throw New Exception("Marque Fecha y Hora de Termino Descarga Destino / Salida Origen")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidaIngresoComplejoOrigenE(ByVal IngresoComplejoOrigen As Date) As Boolean
        Try
            Dim LlegadaOrigen As Date
            LlegadaOrigen = Date.Parse(fecLlegadaOrigenE.Value.ToShortDateString & " " & hLlegadaOrigenE.Value.ToShortTimeString)
            If verLlegadaOrigenE.Checked Then
                If IngresoComplejoOrigen <= LlegadaOrigen Then
                    Marcas()
                    Throw New Exception("La Fecha de Ingreso Complejo Origen no puede ser Igual o Anterior a la Fecha de Llegada Origen")
                End If
            Else
                Throw New Exception("Marque Fecha y Hora de Llegada Origen")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidaInicioCargaOrigenE(ByVal InicioCargaOrigen As Date) As Boolean
        Try
            Dim LlegadaOrigen As Date
            LlegadaOrigen = Date.Parse(fecLlegadaOrigenE.Value.ToShortDateString & " " & hLlegadaOrigenE.Value.ToShortTimeString)
            If verIngresoComplejoOrigenE.Checked Then
                If InicioCargaOrigen <= LlegadaOrigen Then
                    Marcas()
                    Throw New Exception("La Fecha de Inicio Carga Origen no puede ser Igual o Anterior a la Fecha de Ingreso Complejo Origen")
                End If
            Else
                Throw New Exception("Marque Fecha y Hora de Ingreso Complejo Origen")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidaTerminoCargaOrigenE(ByVal TerminoCargaOrigen As Date) As Boolean
        Try
            Dim InicioCargaOrigen As Date
            InicioCargaOrigen = Date.Parse(fecCargaOrigenE.Value.ToShortDateString & " " & hCargaOrigenE.Value.ToShortTimeString)
            If verCargaOrigenE.Checked Then
                If TerminoCargaOrigen <= InicioCargaOrigen Then
                    Marcas()
                    Throw New Exception("La Fecha de Termino Carga Origen no puede ser Igual o Anterior a la Fecha de Inicio Carga Origen")
                End If
            Else
                Throw New Exception("Marque Fecha y Hora de Inicio Carga Origen")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidaImpresionGuiaOrigenE(ByVal ImpresionGuiaOrigen As Date) As Boolean
        Try
            Dim TerminoCargaOrigen As Date
            TerminoCargaOrigen = Date.Parse(fecTerminoCargaOrigenE.Value.ToShortDateString & " " & hTerminoCargaOrigenE.Value.ToShortTimeString)
            If verTerminoCargaOrigenE.Checked Then
                If ImpresionGuiaOrigen <= TerminoCargaOrigen Then
                    Marcas()
                    Throw New Exception("La Fecha de Impresion Guia Origen no puede ser Igual o Anterior a la Fecha de Termino Carga Origen")
                End If
            Else
                Throw New Exception("Marque Fecha y Hora de Termino Carga Origen")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidaSalidaOrigenE(ByVal SalidaOrigen As Date) As Boolean
        Try
            Dim ImpresionGuiaOrigen As Date
            ImpresionGuiaOrigen = Date.Parse(fecImpresionGuiaOrigenE.Value.ToShortDateString & " " & hImpresionGuiaOrigenE.Value.ToShortTimeString)
            If verImpresionGuiaOrigenE.Checked And verLlegadaOrigenE.Checked Then
                If SalidaOrigen <= ImpresionGuiaOrigen Then
                    Marcas()
                    ViajeVacio()
                    Throw New Exception("La Fecha de Salida Origen no puede ser Igual o Anterior a la Fecha de Impresion Guia Origen")
                End If
            Else
                Throw New Exception("Marque Fecha y Hora de Impresion Guia Origen / Llegada Origen")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidaLlegadaAproximadaDestinoE(ByVal LlegadaAproximadaDestino As Date) As Boolean
        Try
            Dim SalidaOrigen As Date
            SalidaOrigen = Date.Parse(fecSalidaOrigenE.Value.ToShortDateString & " " & hSalidaOrigenE.Value.ToShortTimeString)
            If verSalidaOrigenE.Checked Then
                If LlegadaAproximadaDestino <= SalidaOrigen Then
                    Marcas()
                    ViajeVacio()
                    Throw New Exception("La Fecha de Llegada Aproximada Destino no puede ser Igual o Anterior a la Fecha de Salida Origen")
                End If
            Else
                Throw New Exception("Marque Fecha y Hora de Salida Origen")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidaLlegadaDestinoE(ByVal LlegadaDestino As Date) As Boolean
        Try
            Dim LlegadaAproximadaDestino As Date
            LlegadaAproximadaDestino = Date.Parse(fecLlegadaAproximadaDestinoE.Value.ToShortDateString & " " & hLlegadaAproximadaDestinoE.Value.ToShortTimeString)
            If verLlegadaAproximadaDestinoE.Checked Then
                If LlegadaDestino <= LlegadaAproximadaDestino Then
                    Marcas()
                    ViajeVacio()
                    Throw New Exception("La Fecha de Llegada Destino no puede ser Igual o Anterior a la Fecha de Llegada Aproximada Destino")
                End If
            Else
                Throw New Exception("Marque Fecha y Hora de Llegada Aproximada Destino")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidaIngresoDestinoE(ByVal IngresoDestino As Date) As Boolean
        Try
            Dim LlegadaDestino As Date
            LlegadaDestino = Date.Parse(fecLlegadaDestinoE.Value.ToShortDateString & " " & hLlegadaDestinoE.Value.ToShortTimeString)
            If verLlegadaDestinoE.Checked Then
                If IngresoDestino <= LlegadaDestino Then
                    Marcas()
                    Throw New Exception("La Fecha de Ingreso Destino no puede ser Igual o Anterior a la Fecha de Llegada Destino")
                End If
            Else
                Throw New Exception("Marque Fecha y Hora de Llegada Destino")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidaDescargaDestinoE(ByVal DescargaDestino As Date) As Boolean
        Try
            Dim IngresoDestino As Date
            IngresoDestino = Date.Parse(fecIngresoDestinoE.Value.ToShortDateString & " " & hIngresoDestinoE.Value.ToShortTimeString)
            If verIngresoDestinoE.Checked Then
                If DescargaDestino <= IngresoDestino Then
                    Marcas()
                    Throw New Exception("La Fecha de Descarga Destino no puede ser Igual o Anterior a la Fecha de Ingreso Destino")
                End If
            Else
                Throw New Exception("Marque Fecha y Hora de Ingreso Destino")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidaTerminoDescargaDestinoE(ByVal TerminoDescargaDestino As Date) As Boolean
        Try
            Dim DescargaDestino As Date
            DescargaDestino = Date.Parse(fecDescargaDestinoE.Value.ToShortDateString & " " & hDescargaDestinoE.Value.ToShortTimeString)
            If verDescargaDestinoE.Checked Then
                If TerminoDescargaDestino <= DescargaDestino Then
                    Marcas()
                    Throw New Exception("La Fecha de Termino Descarga Destino no puede ser Igual o Anterior a la Fecha de Descarga Destino")
                End If
            Else
                Throw New Exception("Marque Fecha y Hora de Descarga Destino")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidaSalidaDestinoE(ByVal SalidaDestino As Date) As Boolean
        Try
            Dim TerminoDescargaDestino As Date
            TerminoDescargaDestino = Date.Parse(fecTerminoDescargaDestinoE.Value.ToShortDateString & " " & hTerminoDescargaDestinoE.Value.ToShortTimeString)
            If verTerminoDescargaDestinoE.Checked And verSalidaOrigenE.Checked Then
                If SalidaDestino <= TerminoDescargaDestino Then
                    Marcas()
                    ViajeVacio()
                    Throw New Exception("La Fecha de Salida Destino no puede ser Igual o Anterior a la Fecha de Termino Descarga Destino")
                End If
                ValidarPeso()
            Else
                Throw New Exception("Marque Fecha y Hora de Termino Descarga Destino / Salida Origen")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub CalcularPesoToneladas()
        Try
            txtGrtPT.Text = 0.0
            txtPesoToneladas.Text = 0.0
            For Each Fila As UltraWinGrid.UltraGridRow In griViajeDetalle.Rows
                txtGrtPT.Text += Fila.Cells("PesoToneladas").Value
                txtPesoToneladas.Text += Fila.Cells("PesoToneladas").Value
            Next
            With griViajeDetalle.ActiveRow
                .Cells("PesoToneladasCarga").Value = .Cells("PesoToneladas").Value
                .Cells("PesoToneladasDescarga").Value = .Cells("PesoToneladas").Value
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarViajeInterrumpido()
        Try
            If ValidaViajeInterrumpido() Then
                oeGrtInterrumpida = New e_GuiaTransportistaInterrumpida
                oeSeguimiento.GuiaTransportistaInterrumpida = griViajeInterrumpido.DataSource
                With oeGrtInterrumpida
                    .Id = ""
                    .IdSeguimiento = txtSeguimientoId.Text
                    .IdGuiaTransportista = txtIdGuiaTransportista.Text
                    .GuiaTransportista = txtGuiaTransportista.Text
                    .IdMotivoTrasladoInterrumpido = cboMotivoTrasladoInterrumpido.Value
                    .Glosa = txtGlosaInterrumpido.Text
                    .Fecha = fecPartidaViajeInterrumpido.Value
                    .Viaje = txtViajeCodigo.Text
                    .PrefijoID = gs_PrefijoIdSucursal '@0001
                End With
                oeSeguimiento.GuiaTransportistaInterrumpida.Add(oeGrtInterrumpida)
                griViajeInterrumpido.DataBind()
                oeGrtInterrumpida = New e_GuiaTransportistaInterrumpida
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Function ValidaTerminoCargaOrigen(ByVal TerminoCargaOrigen As Date) As Boolean
        Dim InicioCargaOrigen As Date
        InicioCargaOrigen = Date.Parse(fecCargaOrigen.Value.ToShortDateString & " " & hCargaOrigen.Value.ToShortTimeString)
        If verCargaOrigen.Checked Then
            If TerminoCargaOrigen <= InicioCargaOrigen Then
                Marcas()
                Throw New Exception("La Fecha de Termino Carga Origen no puede ser Igual o Anterior a la Fecha de Inicio Carga Origen")
            End If
        Else
            Throw New Exception("Marque Fecha y Hora de Inicio Carga Origen")
        End If

        Return True
    End Function

    Private Function ValidaTerminoDescargaDestino(ByVal TerminoDescargaDestino As Date) As Boolean
        Dim DescargaDestino As Date
        DescargaDestino = Date.Parse(fecDescargaDestino.Value.ToShortDateString & " " & hDescargaDestino.Value.ToShortTimeString)
        If verDescargaDestino.Checked Then
            If TerminoDescargaDestino <= DescargaDestino Then
                Marcas()
                Throw New Exception("La Fecha de Termino Descarga Destino no puede ser Igual o Anterior a la Fecha de Descarga Destino")
            End If
        Else
            Throw New Exception("Marque Fecha y Hora de Descarga Destino")
        End If
        Return True
    End Function

    Private Sub KilometrosCarreta()
        Dim KmTractoOrigen As Double
        Dim KmTractoDestino As Double
        Dim KmCarretaOrigen As Double
        If Not String.IsNullOrEmpty(txtKmTractoDestino.Text) AndAlso IsNumeric(txtKmTractoDestino.Text.Trim.ToString) AndAlso txtKmTractoDestino.Text > 0.0 Then
            KmTractoDestino = CDbl(txtKmTractoDestino.Text.Trim)
        Else
            txtKmTractoDestino.Text = 0.0
            KmTractoDestino = CDbl(txtKmTractoDestino.Text.Trim)
        End If
        If Not String.IsNullOrEmpty(txtKmTractoOrigen.Text) AndAlso IsNumeric(txtKmTractoOrigen.Text.Trim.ToString) AndAlso txtKmTractoOrigen.Text > 0.0 Then
            KmTractoOrigen = CDbl(txtKmTractoOrigen.Text.Trim)
        Else
            KmTractoOrigen = 0.0
        End If
        If Not String.IsNullOrEmpty(txtKmCarretaOrigen.Text) AndAlso IsNumeric(txtKmCarretaOrigen.Text.Trim.ToString) AndAlso txtKmCarretaOrigen.Text > 0.0 Then
            KmCarretaOrigen = CDbl(txtKmCarretaOrigen.Text.Trim)
        Else
            KmCarretaOrigen = 0.0
        End If
        txtKmCarretaDestino.Text = (KmTractoDestino - KmTractoOrigen) + KmCarretaOrigen
    End Sub

    Private Function ValidaKilometrajeDestino() As Boolean
        'Dim KmOrigen As Double
        'Dim KmDestino As Double

        'KmOrigen = txtKmTractoOrigen.Value
        'KmDestino = txtKmTractoDestino.Value

        'If KmOrigen >= KmDestino Then
        '    txtKmTractoDestino.Focus()
        '    txtKmTractoDestino.SelectAll()
        '    mensajeEmergente.Problema(Me.Text & ": El kilometraje destino marcado es inferior o Igual al km origen", True)
        'End If
        Try
            If IsNumeric(txtKmTractoDestino.Value) Then

                Dim kmStandarRuta As Double = CDbl(txtKmTractoDestino.Value) - CDbl(txtKmTractoOrigen.Value)
                If RutaKilometros > 1 Then

                    If CDbl(txtKmTractoDestino.Value) > 0 Then
                        If RutaKilometros < 200 Then
                            If kmStandarRuta > RutaKilometros + (RutaKilometros * 1) Then
                                If MessageBox.Show("El kilometraje destino marcado a superado al DOBLE" & Environment.NewLine & _
                                                   "mas del km estandar( " & RutaKilometros & " km " & ") de la ruta." & Environment.NewLine & _
                                 "¿Desea continuar de todas formas?", "AYUDA", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, _
                                 MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                                    'r_PermisoModifKM("KD")
                                    Throw New Exception("Verificar kilometraje Destino es superior")
                                Else
                                    txtKmTractoDestino.Value = RutaKilometros + txtKmTractoOrigen.Value
                                End If
                            Else
                                If kmStandarRuta < RutaKilometros - (RutaKilometros * 0.2) Then
                                    If MessageBox.Show("El kilometraje destino marcado es inferior al 20%" & Environment.NewLine & _
                                                       "menos que del km estandar( " & RutaKilometros & " km " & ") de la ruta." & Environment.NewLine & _
                                    "¿Desea continuar de todas formas?", "AYUDA", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                                        'r_PermisoModifKM("KD")
                                        Throw New Exception("Verificar kilometraje Destino es inferior")
                                    Else
                                        txtKmTractoDestino.Value = RutaKilometros + txtKmTractoOrigen.Value
                                    End If
                                End If
                            End If
                        ElseIf RutaKilometros < 500 Then
                            If kmStandarRuta > RutaKilometros + (RutaKilometros * 0.5) Then
                                If MessageBox.Show("El kilometraje destino marcado a superado al 50%" & Environment.NewLine & _
                                                   "mas del km estandar( " & RutaKilometros & " km " & ") de la ruta" & Environment.NewLine & _
                                "¿Desea continuar de todas formas?", "AYUDA", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                                    'r_PermisoModifKM("KD")
                                    Throw New Exception("Verificar kilometraje Destino es superior")
                                Else
                                    txtKmTractoDestino.Value = RutaKilometros + txtKmTractoOrigen.Value
                                End If
                            Else
                                If kmStandarRuta < RutaKilometros - (RutaKilometros * 0.2) Then
                                    If MessageBox.Show("El kilometraje destino marcado es inferior al 20%" & Environment.NewLine & _
                                                        "menos que del km estandar( " & RutaKilometros & " km " & ") de la ruta" & Environment.NewLine & _
                                     "¿Desea seguir de todas formas?", "AYUDA", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                                        'r_PermisoModifKM("KD")
                                        Throw New Exception("Verificar kilometraje Destino es inferior")
                                    Else
                                        txtKmTractoDestino.Value = RutaKilometros + txtKmTractoOrigen.Value
                                    End If

                                End If
                            End If
                        Else
                            If kmStandarRuta > RutaKilometros + (RutaKilometros * 0.3) Then
                                If MessageBox.Show("El kilometraje destino marcado a superado al 30%" & Environment.NewLine & _
                                                   "mas del km estandar( " & RutaKilometros & " km " & ") de la ruta" & Environment.NewLine & _
                                 "¿Desea continuar de todas formas?", "AYUDA", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                                    'r_PermisoModifKM("KD")
                                    Throw New Exception("Verificar kilometraje Destino es superior")
                                Else
                                    txtKmTractoDestino.Value = RutaKilometros + txtKmTractoOrigen.Value
                                End If

                            Else
                                If kmStandarRuta < RutaKilometros - (RutaKilometros * 0.2) Then
                                    If MessageBox.Show("El kilometraje destino marcado es inferior al 20%" & Environment.NewLine & _
                                                       "menos que del km estandar( " & RutaKilometros & " km " & ") de la ruta" & Environment.NewLine & _
                                    "¿Desea continuar de todas formas?", "AYUDA", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                                        'r_PermisoModifKM("KD")
                                        Throw New Exception("Verificar kilometraje Destino es inferior")
                                    Else
                                        txtKmTractoDestino.Value = RutaKilometros + txtKmTractoOrigen.Value
                                    End If
                                End If
                            End If
                        End If

                    End If
                Else
                    If kmStandarRuta > 2000 Then
                        If MessageBox.Show("El kilometraje destino marcado a superado 2000 KM RECORRIDO", "AYUDA", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, _
                         MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                            'r_PermisoModifKM("KD")
                            Throw New Exception("Verificar kilometraje Destino es superior")
                        Else
                            txtKmTractoDestino.Value = RutaKilometros + txtKmTractoOrigen.Value
                        End If
                    Else
                        If kmStandarRuta < 1 Then
                            If MessageBox.Show("El kilometraje destino marcado es inferior a 1 KM RECORRIDO", "AYUDA", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                                ' r_PermisoModifKM("KD")
                                Throw New Exception("Verificar kilometraje Destino es superior")
                            Else
                                txtKmTractoDestino.Value = RutaKilometros + txtKmTractoOrigen.Value
                            End If
                        End If
                    End If
                End If

                If txtKmTractoDestino.Value <> 0 Then
                    txtKmCarretaDestino.Value = CDbl(txtKmCarretaOrigen.Value) + CDbl(txtKmTractoDestino.Value) - CDbl(txtKmTractoOrigen.Value)
                End If
            Else
                MessageBox.Show("Ingrese un valor al km Destino", "AYUDA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                txtKmTractoDestino.Focus()
            End If

            Return True
        Catch ex As Exception
            'txtKmTractoDestino.Focus()
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Private Function ValidaKilometrajeOrigen() As Boolean
        Try
            If TractoKilometros <> 0 AndAlso txtKmTractoOrigen.Value <> 0 Then
                If TractoKilometros - CDbl(txtKmTractoOrigen.Value) >= 1000 Then

                    If MessageBox.Show("El km Origen es inferior al horometro en mas de 1000 km." & Environment.NewLine & _
                                     "¿Desea continuar de todas formas?", "AYUDA", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, _
                                     MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        'r_PermisoModifKM("KO")
                        Throw New Exception("Verificar kilometraje Origen es inferior")
                    Else
                        txtKmTractoOrigen.Value = TractoKilometros
                        txtKmTractoOrigen.Focus()

                    End If
                ElseIf CDbl(txtKmTractoOrigen.Value) - TractoKilometros >= 1000 Then
                    If MessageBox.Show("El km Origen es superior al horometro en mas de 1000 km" & Environment.NewLine & _
                                    "¿Desea continuar de todas formas?", "AYUDA", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, _
                                    MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        'r_PermisoModifKM("KO")
                        Throw New Exception("Verificar kilometraje Origen es Superior")
                    Else
                        txtKmTractoOrigen.Value = TractoKilometros
                        txtKmTractoOrigen.Focus()
                    End If
                End If
            End If

            Return True
        Catch ex As Exception
            txtKmTractoOrigen.Focus()
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Private Function EnviarEmailCliente(MensajeCarga As String, SalidaOrigen As String, LlegadaDestino As String) As Boolean
        Try
            MensajeCarga = "El Usuario: " & gUsuarioSGI.oePersona.NombreCompleto & ". Informa Detalles de su Carga: " & ClienteCargaMaterial & " ." & Environment.NewLine & _
            "Salida Origen: " & SalidaOrigen & " Llegada Destino: " & LlegadaDestino & ". " & Environment.NewLine & _
            "Ruta de Transporte de Carga: " & lbOrigen.Text & " - " & lbDestino.Text & ". " & Environment.NewLine & _
            "Tracto: " & txtViajeTracto.Text & ". Carreta: " & txtViajeCarreta.Text & ". " & Environment.NewLine & _
            "Piloto: " & txtViajePiloto.Text & ". " & Environment.NewLine & _
            "Peso: " & txtPesoToneladas.Text
            EnviarEmail("consultores.tecnologicos.2010@gmail.com", "consultores.tecnologicos.2010@gmail.com;consultores.tecnologicos.2010@gmail.com;consultores.tecnologicos.2010@gmail.com", "", "", "CALL CENTER", MensajeCarga, "", True)
            Return True
            ';
        Catch ex As Exception

        End Try
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

#End Region

#Region "Control de tiempo de respuesta y actualización"

    'Private Sub frm_Seguimiento_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
    '    InicializaTiempo()
    'End Sub

    'Private Sub griLista_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griLista.MouseMove
    '    If _tiempo <= 0 Then
    '        Consultar(True)
    '    End If
    '    InicializaTiempo()
    'End Sub

    'Public Overloads Function InicializaTiempo() As Integer
    '    _tiempo = 120
    'End Function

#End Region

#Region "Funciones"

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


#End Region

    Private Sub btnBuscarImportar_Click(sender As Object, e As EventArgs) Handles btnBuscarImportar.Click
        Try
            ListarImportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ListarImportar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            olOperacion = New l_Operacion
            oeViajeImportar = New e_Viaje

            ValidarCombo(cboTractoImportar, "Tracto")

            With oeViajeImportar
                .ViajeVacio = 2
                .FechaDesde = ""
                .FechaHasta = ""
                .TipoOperacion = "1"
                .Centro = cboCentroImportar.Value
                .IndMotriz = 1
                .IdTracto = cboTractoImportar.Value
                .IdEstado = "1CH00017"
            End With

            ListaViaje = olOperacion.ListarViaje(oeViajeImportar)
            gridImportar.DataSource = ListaViaje

            'Ubica el cursor el el primer registro de la grilla
            If gridImportar.Rows.Count > 0 Then
                gridImportar.Focus()
                gridImportar.Rows.Item(0).Activated = True
            End If
            'gruopExpanUnidadesSinReportar.Expanded = False
            'InicializaTiempo()
            ugb_Espera.Visible = False
            'Await MensajePC("Viajes listados")

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        Try
            Dim PathFilePTRA As String = ""
            OpenFileDialog1 = CargaDatosOpenFileDialog()

            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

                ugb_Espera.Visible = True
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                Dim objXls As Excel.Application
                Dim objWorkbook As Excel.Workbook
                Dim objWorkSheet As Excel.Worksheet
                Dim ObjExcel() As Object = Nothing
                PathFilePTRA = OpenFileDialog1.FileName

                Dim men As String = ""
                objXls = CreateObject("Excel.Application")
                objWorkbook = objXls.Workbooks.Open(PathFilePTRA)
                objXls.Visible = False
                objWorkSheet = objXls.Worksheets(1)

                ListaViaje = ListaViaje.OrderBy(Function(x) x.Fecha).ToList()


                For ln_Fila As Integer = 1 To ListaViaje.Count
                    If (Not objWorkSheet.Cells(ln_Fila + 1, 1).Value Is Nothing) Then

                        If (ListaViaje(ln_Fila - 1).Tracto.Trim <> objWorkSheet.Cells(ln_Fila + 1, 1).value.ToString.Trim) Then Throw New Exception("Tracto no coincide, viaje: " & ListaViaje(ln_Fila - 1).Codigo.ToString & " con Fila " & (ln_Fila + 1) & " del excel.")
                        If (ListaViaje(ln_Fila - 1).Origen.Trim & " - " & ListaViaje(ln_Fila - 1).Destino.Trim <> objWorkSheet.Cells(ln_Fila + 1, 7).value.ToString.Trim) Then Throw New Exception("Ruta no coincide, viaje: " & ListaViaje(ln_Fila - 1).Codigo.ToString & " con Fila " & (ln_Fila + 1) & " del excel.")

                        ListaViaje(ln_Fila - 1).KmTractoOrigen = objWorkSheet.Cells(ln_Fila + 1, 16).value
                        ListaViaje(ln_Fila - 1).KmTractoDestino = objWorkSheet.Cells(ln_Fila + 1, 17).value

                        ListaViaje(ln_Fila - 1).LlegadaOrigen = DateTime.Parse(objWorkSheet.Cells(ln_Fila + 1, 18).Value)
                        ListaViaje(ln_Fila - 1).SalidaOrigen = DateTime.Parse(objWorkSheet.Cells(ln_Fila + 1, 19).Value)

                        ListaViaje(ln_Fila - 1).LlegadaDestino = DateTime.Parse(objWorkSheet.Cells(ln_Fila + 1, 20).Value)
                        ListaViaje(ln_Fila - 1).SalidaDestino = DateTime.Parse(objWorkSheet.Cells(ln_Fila + 1, 21).Value)

                        ListaViaje(ln_Fila - 1).PesoToneladas = IIf(IsNumeric(objWorkSheet.Cells(ln_Fila + 1, 22).Value), objWorkSheet.Cells(ln_Fila + 1, 22).Value, 0)
                        ListaViaje(ln_Fila - 1).Cantidad = IIf(IsNumeric(objWorkSheet.Cells(ln_Fila + 1, 23).Value), objWorkSheet.Cells(ln_Fila + 1, 23).Value, 0)

                        ListaViaje(ln_Fila - 1).IdEstado = "1CH00010"
                        ListaViaje(ln_Fila - 1).Estado = "FIN"


                    Else
                        Exit For
                    End If
                Next

                gridImportar.DataBind()

                For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In gridImportar.Rows

                    Select Case fila.Cells("Estado").Value
                        Case "PROGRAMADO"
                            fila.CellAppearance.BackColor = Me.ColorProgramado.Color
                        Case "CARGA"
                            fila.CellAppearance.BackColor = Me.ColorCarga.Color
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

                If Not objXls Is Nothing Then
                    objWorkbook.Saved = True : objWorkbook.Close()
                    objXls.Quit()
                End If
                OpenFileDialog1.Dispose()
                ObjExcel = Nothing : objWorkSheet = Nothing : objWorkbook = Nothing : objXls = Nothing
            Else
                OpenFileDialog1.Dispose()
            End If
            'mensajeEmergente.Confirmacion("Se han Procesado " & leDetImportar.Count & " registros", True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            OpenFileDialog1.Dispose()
            Dim proceso() As Process
            proceso = Process.GetProcessesByName("EXCEL")
            If proceso.Length > 0 Then proceso(proceso.Length - 1).Kill()

            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim ListaViajeGuardar As New List(Of e_Viaje)
            olSeguimiento = New l_Seguimiento
            ListaViajeGuardar = ListaViaje.Where(Function(x) x.IdEstado = "1CH00010").ToList().OrderBy(Function(x) x.Fecha).ToList()
            If ListaViajeGuardar.Count = 0 Then Throw New Exception("No existe información a Guardar")
            olSeguimiento.GuardarImportar(ListaViajeGuardar)
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
            ListarImportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

End Class