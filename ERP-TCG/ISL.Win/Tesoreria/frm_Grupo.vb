'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Shared
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Configuration
Imports Infragistics.Win.CalcEngine
Imports Infragistics.Win.UltraWinDataSource

Public Class frm_Grupo
    Inherits frm_MenuPadre

#Region "Inicializacion"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Enum EnumTipoGrupo As Byte
        Todos = 0
        Liquidaciones = 1
        CajaChica = 2
        Fletes = 3
        Descuento = 4
    End Enum

    Private Shared instancia As frm_Grupo = Nothing
    Private Shared Operacion As String
    Private Estado As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        Operacion = "Inicializa"
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Grupo()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de variables"

    Dim oeGrupo As New e_Grupo
    Dim olGrupo As New l_Grupo
    Dim loGrupo As New List(Of e_Grupo)

    Dim oeGrupoDetalle As New e_GrupoDetalle
    Dim olGrupoDetalle As New l_GrupoDetalle
    Dim loGrupoDetalle As New List(Of e_GrupoDetalle)

    Dim oeGastoOperacion As New e_GastoOperacion
    Dim olGastoOperacion As New l_GastoOperacion

    Dim oeCuentaCorriente As New e_CuentaCorriente
    Dim olCuentaCorriente As New l_CuentaCorriente
    Dim CuentaCorriente As String = ""
    Dim loCuentaCorriente As New List(Of e_CuentaCorriente)

    Dim oeCentro As New e_Centro
    Dim olCentro As New l_Centro
    Dim Pre As String = ""
    Dim Tip As String = ""

    Private oeDetGruCC As New e_GrupoDetalle
    Private olDetGruCC As New l_GrupoDetalle
    Private loDetGruCC As New List(Of e_GrupoDetalle)

    Private oeCajaUsuario As New e_CajaUsuario
    Private olCajaUsuario As New l_CajaUsuario

    Dim IdCajaUsuario As String = ""
    Dim Caja As String = ""

    Private oePeriodo As New e_Periodo
    Private olPeriodo As New l_Periodo

    Public IndLiquidado As Boolean = False

    Dim _ingresando_datos As Boolean = False
    Dim Opcion As Boolean

    Public IndFleteAdm As Boolean = False

    Private olTrabajadorSeguridad As New l_TrabajadorSeguridad

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Select Case ficGrupo.SelectedTab.Index
                Case 0
                    ListarGrupo()
                    If griLista.Rows.Count > 0 Then
                        ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
                    Else
                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            Dim oeGru As New e_Grupo
            Dim olGru As New l_Grupo
            Operacion = "Nuevo"
            Inicializar()
            oeGrupo.TipoOperacion = "I"
            oeGrupo.IdEstado = "GENERADA"
            oeGrupo.IdCentro = IIf(cboCentroL.SelectedIndex = 0, "", cboCentroL.Value)
            txtNumeroGrupo.Text = ObtenerCodigo()
            loGrupoDetalle = New List(Of e_GrupoDetalle)
            If cboCentroL.SelectedIndex = 0 Then Throw New Exception("Seleccione Centro")
            oeGru.TipoOperacion = "G"
            oeGru.Tipo = cboTipoGrupo.SelectedIndex
            oeGru.IdCentro = oeGrupo.IdCentro
            oeGru = olGru.Obtener(oeGru)
            If oeGru.Codigo <> "" And oeGru.Tipo <> 3 Then
                Throw New Exception("Grupo Generado/Pre-Enviado Activo. Favor Enviar Grupo: " & oeGru.Codigo & " Antes de Generar Otro.")
            Else
                Select Case cboTipoGrupo.SelectedIndex
                    Case 1
                        oeGrupo.Tipo = 1
                        txtGlosa.Text = "GRUPO DE REEMBOLSO DE LIQUIDACIONES"
                        MostrarTabs(1, ficGrupo, 0)
                        Me.ficGrupo.Tabs(0).Enabled = False
                        LlenarGrupoDetalle(loGrupoDetalle)
                        MyBase.Nuevo()
                    Case 2
                        oeGrupo.Tipo = 2
                        txtGlosa.Text = "GRUPO DE REEMBOLSO DE CAJA CHICA"
                        etiPeriodo.Visible = True
                        fecPeriodo.Visible = True
                        MostrarTabs(1, ficGrupo, 0)
                        Me.ficGrupo.Tabs(0).Enabled = False
                        ListarGastoOperacion(griOrigenDato)
                        LlenarGrupoDetalle(loGrupoDetalle)
                        MyBase.Nuevo()
                    Case 3
                        oeGrupo.Tipo = 3
                        txtGlosa.Text = "GRUPO DE REEMBOLSO DE FLETES"
                        If oeGrupo.IdCuentaCorriente <> "" Then
                            MostrarTabs(1, ficGrupo, 1)
                        Else
                            MostrarTabs(1, ficGrupo)
                        End If
                        agrOrigenDato.Expanded = False
                        ListarFletes()
                        LlenarGrupoDetalle(loGrupoDetalle)
                        MyBase.Nuevo()
                    Case 4
                        oeGrupo.Tipo = 4
                        txtGlosa.Text = "GRUPO DE REEMBOLSO DE DESCUENTOS"
                        MostrarTabs(1, ficGrupo, 0)
                        Me.ficGrupo.Tabs(0).Enabled = False
                        ListarDescuentos()
                        LlenarGrupoDetalle(loGrupoDetalle)
                        MyBase.Nuevo()
                    Case Else
                        Throw New Exception("Seleccione Tipo")
                        ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                End Select
                VisualizaGrupoDetalle(oeGrupo.Tipo)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try  
    End Sub

    Public Overrides Sub Editar()
        Try
            Operacion = "Editar"
            loGrupoDetalle = New List(Of e_GrupoDetalle)
            If Me.griLista.ActiveRow.Cells("Estado").Value.ToString = "ENVIADO" Or Me.griLista.ActiveRow.Cells("Estado").Value.ToString = "REEMBOLSADO" Then
                ControlBoton(1, 1, 1, 0, 0, 0, 0, 0, 1)
            Else
                Mostrar()
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try    
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeGrupo.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardaGrupo() Then
                            MostrarTabs(0, ficGrupo)
                            _ingresando_datos = False
                            MyBase.Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficGrupo)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficGrupo)
                        _ingresando_datos = False
                        MyBase.Consultar(True)
                End Select
            Else
                MostrarTabs(0, ficGrupo)
                _ingresando_datos = False
                If griLista.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 0, 0, 0, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If

            End If
            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If ValidaUsuarioCajaCentro(IdCajaUsuario, ObtenerCentro.Id, gUsuarioSGI.IdTrabajador) Then
                Select Case Operacion
                    Case "Nuevo"
                        If GuardaGrupo() Then ControlBoton(1, 1, 1, 0, 0, 0, 0, 0, 1)
                    Case "Editar"
                        If GuardaGrupo() Then ControlBoton(1, 1, 1, 0, 0, 0, 0, 0, 1)
                    Case "Enviar"
                        If EnviarGrupo() Then ControlBoton(1, 1, 1, 0, 0, 0, 0, 0, 1)
                End Select
            Else
                Throw New Exception("No puede Realizar Movimientos en esta Sede")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Public Overrides Sub Imprimir()
        'MyBase.Imprimir()
    End Sub

    Public Overrides Sub Exportar()
        Try
            If ficGrupo.Tabs(0).Selected AndAlso griLista.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            If ficGrupo.Tabs(0).Selected Then Exportar_Excel(griLista)

            If ficGrupo.Tabs(1).Selected AndAlso griDetalleGrupo.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            If ficGrupo.Tabs(1).Selected Then Exportar_Excel(griDetalleGrupo)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Grupo_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case Operacion
            Case "Nuevo"
                MyBase.Nuevo()
            Case "Editar"
                MyBase.Editar()
            Case "Inicializa"
                'fecHasta.Value = Date.Today
                'fecDesde.Value = Date.Today.AddDays(-5)
                'Consultar(True)
                If griLista.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 0, 0, 0, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
            Case "Ayuda"
        End Select
        If ficGrupo.SelectedTab.Index = 0 And griLista.Rows.Count Then
            ControlBoton(1, 1, 1, 0, 0, 0, 0, 0, 1)
        ElseIf ficGrupo.SelectedTab.Index = 1 Then
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 1)
        End If
    End Sub

    Private Sub frm_Grupo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Grupo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm_Grupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gmt_ConfigurarEventoKeyEnter_Tab(Me)
            gf_AsignarEventoSeleccionarTexto(Me)
            MostrarTabs(0, ficGrupo)
            colorEnviado.Color = Color.Khaki
            colorReembolsado.Color = Color.LightGreen
            ColorGenerado.Color = Color.Transparent
            ColorPreEnviado.Color = Color.LightSkyBlue
            fecPeriodo.Value = ObtenerFechaServidor()
            LlenaComboTipoGrupo()
            LlenaComboCentro()
            CargarEstado()
            BuscarUsuarioCaja()
            CargarCuentaCorrienteAdm()
            fecFecha.Value = Date.Now
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
            AsociarMenu()
            fecDesde.Value = Date.Now.AddDays(-20)
            agrOrigenDato.Expanded = False
            agrOrigenDato.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTipoGrupo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoGrupo.ValueChanged
        Try
            Select Case cboTipoGrupo.SelectedIndex
                Case 0
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                Case Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End Select
            Select Case cboTipoGrupo.SelectedIndex
                Case 1 : Tip = "0"
                Case 2 : Tip = "C"
                Case 3 : Tip = "F"
                Case 4 : Tip = "D"
                Case Else : Tip = ""
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try  
    End Sub

    Private Sub txtNumeroGrupo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumeroGrupo.ValueChanged
        If Operacion = "Nuevo" Then If txtNumeroGrupo.Text.Length > 0 Then oeGrupo.Codigo = txtNumeroGrupo.Text.Substring(0, 3)
    End Sub

    Private Sub fecFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecFecha.ValueChanged, fecFecha.KeyDown, _
        fecFecha.GotFocus
        oeGrupo.Fecha = fecFecha.Value
    End Sub

    Private Sub txtGlosa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa.ValueChanged
        oeGrupo.GlosaEnvio = txtGlosa.Text
    End Sub

    Private Sub decImporte_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decImporte.ValueChanged
        oeGrupo.ImporteTotal = decImporte.Value
        If oeGrupo.Estado = "" Or oeGrupo.Estado = "GENERADA" Then oeGrupo.Saldo = decImporte.Value
    End Sub

    Private Sub griLista_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griLista.DoubleClick
        Try
            If griLista.Rows.Count > 0 Then
                Dim str As String = Me.griLista.ActiveRow.Cells("Estado").Value.ToString
                If str <> "PRE-ENVIADO" And str <> "REEMBOLSADO" And str <> "ENVIADO" Then
                    Editar()
                End If
                If str = "PRE-ENVIADO" And olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "ENVIAR GRUPOS CC") = True Then
                    Editar()
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griOrigenDato_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griOrigenDato.CellChange
        Try
            With griOrigenDato
                .UpdateData()
                If .ActiveRow.Cells("Selec").Activated Then
                    oeGrupoDetalle = New e_GrupoDetalle
                    Dim Fila As UltraGridRow
                    Select Case oeGrupo.Tipo
                        Case 4, 3
                            oeGrupoDetalle.IdGastoOperacion = .ActiveRow.Cells("IdMovimiento").Value
                        Case 1
                            oeGrupoDetalle.IdGastoOperacion = .ActiveRow.Cells("IdViaje").Value
                        Case Else
                            oeGrupoDetalle.IdGastoOperacion = .ActiveRow.Cells("Id").Value
                    End Select
                    Fila = .ActiveRow
                    If .ActiveRow.Cells("Selec").Value Then
                        AgregarGastoOperacion(oeGrupoDetalle, Fila, oeGrupo.Tipo)
                    Else
                        QuitarGastoOperacion(oeGrupoDetalle, oeGrupo.Tipo)
                    End If
                End If
            End With
            griDetalleGrupo.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        Try
            Dim oeGD As New e_GrupoDetalle
            Dim var As Integer = 0
            If griOrigenDato.Rows.Count > 0 Then
                If btnSeleccionar.Tag = "Selec" Then
                    For Each fila As UltraGridRow In griOrigenDato.Rows
                        If Not fila.Cells("Selec").Value Then
                            fila.Cells("Selec").Value = True
                            oeGD = New e_GrupoDetalle
                            Select Case oeGrupo.Tipo
                                Case 4, 3
                                    oeGD.IdGastoOperacion = fila.Cells("IdMovimiento").Value
                                Case 1
                                    oeGD.IdGastoOperacion = fila.Cells("IdViaje").Value
                                Case Else
                                    oeGD.IdGastoOperacion = fila.Cells("Id").Value
                            End Select
                            AgregarGastoOperacion(oeGD, fila, oeGrupo.Tipo)
                            var = 1
                        End If
                    Next
                    If var = 0 Then Throw New Exception("Todos los Registros estan Seleccionados")
                    btnSeleccionar.Tag = "NoSelec"
                    btnSeleccionar.Text = "Quitar Todo"
                    btnSeleccionar.Appearance.Image = My.Resources.SymbolDelete
                Else
                    For Each fila As UltraGridRow In griOrigenDato.Rows
                        If fila.Cells("Selec").Value Then
                            fila.Cells("Selec").Value = False
                            oeGD = New e_GrupoDetalle
                            Select Case oeGrupo.Tipo
                                Case 4
                                    oeGD.IdGastoOperacion = fila.Cells("IdMovimiento").Value
                                Case 1
                                    oeGD.IdGastoOperacion = fila.Cells("IdViaje").Value
                                Case Else
                                    oeGD.IdGastoOperacion = fila.Cells("Id").Value
                            End Select
                            QuitarGastoOperacion(oeGD, oeGrupo.Tipo)
                        End If
                    Next
                    btnSeleccionar.Tag = "Selec"
                    btnSeleccionar.Text = "Agregar Todo"
                    btnSeleccionar.Appearance.Image = My.Resources.Agregar
                End If
            End If
            griDetalleGrupo.DataBind()
            griOrigenDato.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub colorEnviado_ColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        etiEnviado.Appearance.BackColor = colorEnviado.Color
    End Sub

    Private Sub colorReembolsado_ColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        etiReembolsado.Appearance.BackColor = colorReembolsado.Color
    End Sub

    Private Sub griOrigenDato_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griOrigenDato.InitializeLayout
        e.Layout.Grid.CalcManager = Nothing
    End Sub

    Private Sub cboCentroL_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCentroL.ValueChanged
        Try
            If cboCentroL.SelectedIndex > 0 Then
                Dim obj As New e_Centro
                obj = cboCentroL.Items(cboCentroL.SelectedIndex).ListObject
                Pre = obj.Abreviatura.Substring(1)
                If cboCentroL.Value = "1CH001" Then
                    cboTipoGrupo.Enabled = True
                    cboTipoGrupo.SelectedIndex = 0
                Else
                    cboTipoGrupo.Enabled = False
                    'cboTipoGrupo.SelectedIndex = 1
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodo"

    Private Sub InicializaGrupo()
        Try
            oeGrupo = New e_Grupo
            'Select Case 
            LlenarGrupoDetalle(New List(Of e_GrupoDetalle))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializar()
        Try
            oeGrupo = New e_Grupo
            txtNumeroGrupo.Text = String.Empty
            'cboCentro.SelectedIndex = -1
            decImporte.Value = 0
            txtGlosa.Text = String.Empty
            griOrigenDato.DataSource = Nothing
            etiPeriodo.Visible = False
            fecPeriodo.Visible = False
            loDetGruCC = New List(Of e_GrupoDetalle)
        Catch ex As Exception
            Throw ex
        End Try  
    End Sub

    Private Sub LlenaComboCentro()
        Try
            Dim oe As New e_Centro
            Dim leCentro As New List(Of e_Centro)
            oe.Id = ""
            oe.Nombre = "TODOS"
            leCentro.Add(oe)
            leCentro.AddRange(olCentro.Listar(oeCentro))
            LlenarCombo(cboCentroL, "Nombre", leCentro, 0)
        Catch ex As Exception
            Throw ex
        End Try 
    End Sub

    Private Sub LlenaComboTipoGrupo()
        Try
            Dim TipoGrupo As EnumTipoGrupo = CType(4, EnumTipoGrupo)
            cboTipoGrupo.Items.Add(EnumTipoGrupo.Todos.ToString)
            cboTipoGrupo.Items.Add("Tipo de Grupo " & EnumTipoGrupo.Liquidaciones.ToString)
            cboTipoGrupo.Items.Add("Tipo de Grupo " & EnumTipoGrupo.CajaChica.ToString)
            cboTipoGrupo.Items.Add("Tipo de Grupo " & EnumTipoGrupo.Fletes.ToString)
            cboTipoGrupo.Items.Add("Tipo de Grupo " & EnumTipoGrupo.Descuento.ToString)
            cboTipoGrupo.SelectedIndex = 0
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarCuentaCorrienteAdm()
        Try
            Dim e_CtaCte As New e_CuentaCorriente
            Dim l_CtaCte As New l_CuentaCorriente
            e_CtaCte.IdTrabajador = gUsuarioSGI.IdTrabajador
            e_CtaCte.Tipo = 1
            e_CtaCte = l_CtaCte.Obtener(e_CtaCte)
            CuentaCorriente = e_CtaCte.Id
        Catch ex As Exception
            Throw ex
        End Try   
    End Sub

    Private Function BuscarIdTrab(ByVal idCuentaCorriente As String, ByVal TipoCuenta As Integer) As String
        Dim IdTrab As String = ""
        Try
            Dim oeCtaCte As New e_CuentaCorriente
            oeCtaCte.Id = idCuentaCorriente
            oeCtaCte.Tipo = TipoCuenta
            oeCtaCte = olCuentaCorriente.Obtener(oeCtaCte)
            IdTrab = oeCtaCte.IdTrabajador
        Catch ex As Exception
            Throw ex
        End Try
        Return IdTrab
    End Function

    Private Sub CargarEstado()
        Try
            Dim loEstado As New List(Of e_Estado)
            Dim oeEstado As New e_Estado
            Dim olEstado As New l_Estado
            oeEstado.Id = ""
            oeEstado.Nombre = "TODOS"
            loEstado.Add(oeEstado)
            oeEstado = New e_Estado
            oeEstado.Nombre = "GRUPO REEMBOLSO"
            loEstado.AddRange(olEstado.Listar(oeEstado))
            LlenarCombo(cboEstadoL, "Nombre", loEstado, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GuardaGrupo() As Boolean
        Try
            oeGrupo.GlosaEnvio = oeGrupo.GlosaEnvio & " " & Date.Now
            oeGrupo.UsuarioCreacion = gUsuarioSGI.Id
            oeGrupo.NroCheque = ""
            oeGrupo.loDetalleGrupo = loGrupoDetalle
            If oeGrupo.Tipo = 2 Then
                If oeGrupo.TipoOperacion = "I" Then
                    oeGrupo.IdCuentaCorriente = CuentaCorriente
                    oeGrupo.IdCaja = IdCajaUsuario
                End If
                If loDetGruCC.Count > 0 Then
                    QuitarGastosCC()
                End If
                If Operacion = "Nuevo" Then
                    oePeriodo = New e_Periodo
                    oePeriodo.Ejercicio = fecPeriodo.DateTime.Year
                    oePeriodo.Mes = fecPeriodo.DateTime.Month
                    oePeriodo = olPeriodo.Obtener(oePeriodo)
                    If oePeriodo.Id Is Nothing Then
                        Throw New Exception("No existe el periodo: " & fecPeriodo.DateTime.Month.ToString)
                    Else
                        If oePeriodo.CierreCajaLiquidacion Then
                            Throw New Exception("El periodo para CajaLiquidacion esta cerrado: " & fecPeriodo.DateTime.Month.ToString)
                        End If
                    End If
                    oeGrupo.IdPeriodo = oePeriodo.Id
                End If
            End If
            oeGrupo.PrefijoID = gs_PrefijoIdSucursal '@0001
            If oeGrupo.Tipo = 3 And IndFleteAdm = True Then
                oeGrupo.TipoOperacion = "I"
                oeGrupo.IdEstado = "ENVIADO"
                If olGrupo.Guardar(oeGrupo) Then
                    mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                    Me.Close()
                    Exit Function
                End If
            Else
                If olGrupo.Guardar(oeGrupo) Then
                    mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                    MostrarTabs(0, ficGrupo)
                    InicializaGrupo()
                    Consultar(True)
                    griLista.Focus()
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub ListarGrupo()
        Try
            InicializaGrupo()
            oeGrupo = New e_Grupo
            oeGrupo.TipoOperacion = "7"
            oeGrupo.FechaDesde = fecDesde.Value
            oeGrupo.FechaHasta = fecHasta.Value
            oeGrupo.Tipo = IIf(cboTipoGrupo.SelectedIndex = 0, "", cboTipoGrupo.SelectedIndex)

            oeGrupo.IdCentro = IIf(cboCentroL.SelectedIndex = 0, "", cboCentroL.Value)
            oeGrupo.Estado = IIf(cboEstadoL.SelectedIndex = 0, "", cboEstadoL.Text)
            loGrupo = olGrupo.Listar(oeGrupo)
            griLista.ResetDisplayLayout()
            griLista.DataSource = loGrupo

            griLista.DisplayLayout.Bands(0).Columns("Id").Hidden = True
            griLista.DisplayLayout.Bands(0).Columns("Tipo").Hidden = True
            griLista.DisplayLayout.Bands(0).Columns("IdCentro").Hidden = True
            griLista.DisplayLayout.Bands(0).Columns("IdEstado").Hidden = True
            griLista.DisplayLayout.Bands(0).Columns("Activo").Hidden = True
            griLista.DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
            griLista.DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
            griLista.DisplayLayout.Bands(0).Columns("ImportePagar").Hidden = True
            griLista.DisplayLayout.Bands(0).Columns("IdCuentaCorriente").Hidden = True
            griLista.DisplayLayout.Bands(0).Columns("Saldo").Hidden = True
            griLista.DisplayLayout.Bands(0).Columns("FechaEnvio").Hidden = True
            griLista.DisplayLayout.Bands(0).Columns("Seleccion").Hidden = True
            griLista.DisplayLayout.Bands(0).Columns("IdPeriodo").Hidden = True
            griLista.DisplayLayout.Bands(0).Columns("IdCaja").Hidden = True

            griLista.DisplayLayout.Bands(0).Columns("Codigo").Header.VisiblePosition = 1
            griLista.DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 2
            griLista.DisplayLayout.Bands(0).Columns("NroCheque").Header.VisiblePosition = 3
            griLista.DisplayLayout.Bands(0).Columns("FechaReembolso").Header.VisiblePosition = 4
            griLista.DisplayLayout.Bands(0).Columns("GlosaEnvio").Header.VisiblePosition = 5
            griLista.DisplayLayout.Bands(0).Columns("ImporteTotal").Header.VisiblePosition = 6
            griLista.DisplayLayout.Bands(0).Columns("Saldo").Header.VisiblePosition = 7

            griLista.DisplayLayout.Bands(0).Columns("Centro").Header.VisiblePosition = 8
            griLista.DisplayLayout.Bands(0).Columns("Estado").Header.VisiblePosition = 9

            griLista.DisplayLayout.Bands(0).Columns("Codigo").Width = 110
            griLista.DisplayLayout.Bands(0).Columns("GlosaEnvio").Width = 300
            griLista.DisplayLayout.Bands(0).Columns("Fecha").Width = 120
            griLista.DisplayLayout.Bands(0).Columns("FechaEnvio").Width = 120
            griLista.DisplayLayout.Bands(0).Columns("FechaReembolso").Width = 120
            griLista.DisplayLayout.Bands(0).Columns("ImporteTotal").Width = 90
            griLista.DisplayLayout.Bands(0).Columns("Saldo").Width = 90

            griLista.DisplayLayout.Bands(0).Columns("ImporteTotal").Style = ColumnStyle.Double
            griLista.DisplayLayout.Bands(0).Columns("Saldo").Style = ColumnStyle.Double
            griLista.DisplayLayout.Bands(0).Columns("Fecha").Style = ColumnStyle.DateTime
            griLista.DisplayLayout.Bands(0).Columns("FechaEnvio").Style = ColumnStyle.DateTime
            griLista.DisplayLayout.Bands(0).Columns("FechaReembolso").Style = ColumnStyle.DateTime

            griLista.DisplayLayout.Bands(0).Columns("ImporteTotal").CellAppearance.TextHAlign = HAlign.Right
            griLista.DisplayLayout.Bands(0).Columns("Saldo").CellAppearance.TextHAlign = HAlign.Right

            For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLista.Rows
                If Fila.Cells("Estado").Value = "GENERADO" Then Fila.Appearance.BackColor = ColorGenerado.Color
                If Fila.Cells("Estado").Value = "PRE-ENVIADO" Then Fila.Appearance.BackColor = ColorPreEnviado.Color
                If Fila.Cells("Estado").Value = "ENVIADO" Then Fila.Appearance.BackColor = colorEnviado.Color
                If Fila.Cells("Estado").Value = "REEMBOLSADO" Then Fila.Appearance.BackColor = colorReembolsado.Color
            Next

            griLista.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
            griLista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
            griLista.DisplayLayout.Override.FilterUIProvider = Filtro1
            griLista.DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton

            griLista.DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
            griLista.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
            griLista.DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect

            CalcularTotales(griLista, "ImporteTotal")

        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
        End Try
    End Sub

    Private Sub QuitarGastosCC()
        Try
            Dim oeValRen As New e_ValesRendir
            Dim olValRen As New l_ValesRendir
            Dim oeGasOpe As New e_GastoOperacion
            Dim olGasOpe As New l_GastoOperacion
            Dim Importe As Double = 0
            For Each oe As e_GrupoDetalle In loDetGruCC
                Importe += oe.Importe
                oe.PrefijoID = gs_PrefijoIdSucursal '@0001
                olGrupoDetalle.Guardar(oe)
                oeGasOpe = New e_GastoOperacion
                oeGasOpe.Id = oe.IdGastoOperacion
                oeGasOpe.IdDocumento = oe.Viaje
                olGasOpe.Eliminar(oeGasOpe)
            Next
            With oeValRen
                .TipoOperacion = "I"
                .IdTrabajadorAutoriza = gUsuarioSGI.IdTrabajador
                .Importe = Importe
                .Glosa = "GASTOS RETIRADOS DEL GRUPO: " & oeGrupo.Codigo & " el día: " & Date.Now
                .Fecha = Date.Now
                .IdCuentaCorriente = oeGrupo.IdCuentaCorriente
                .IdTrabajador = BuscarIdTrab(oeGrupo.IdCuentaCorriente, 1)
                oeCajaUsuario = New e_CajaUsuario
                oeCajaUsuario.IdTrabajador = .IdTrabajador
                oeCajaUsuario = olCajaUsuario.Obtener(oeCajaUsuario)
                .IdCaja = oeCajaUsuario.IdCaja
                .UsuarioCreacion = gUsuarioSGI.Id
                .IndRendido = 0
                .IndCerrado = 0
                .IdCentro = oeGrupo.IdCentro
                .PrefijoID = gs_PrefijoIdSucursal '@0001
                If Not olValRen.Guardar(oeValRen) Then
                    Throw New Exception("Error")
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Mostrar()
        Try
            If griLista.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeGrupo = New e_Grupo
                oeGrupo.TipoOperacion = "7"
                oeGrupo.Id = griLista.ActiveRow.Cells("Id").Value
                oeGrupo = olGrupo.Obtener(oeGrupo)
                txtNumeroGrupo.Text = oeGrupo.Codigo
                fecFecha.Value = oeGrupo.Fecha
                txtGlosa.Text = oeGrupo.GlosaEnvio
                decImporte.Value = oeGrupo.ImporteTotal
                etiEstado.Text = oeGrupo.Estado
                If Operacion <> "Enviar" Then
                    oeGrupo.TipoOperacion = "A"
                    oeGrupo.IdEstado = etiEstado.Text
                End If
                LlenarGrupoDetalle(loGrupoDetalle)
                Select Case oeGrupo.Tipo
                    Case 1 ' LIQUIDACION
                        MostrarTabs(1, ficGrupo)
                        oeGrupoDetalle = New e_GrupoDetalle
                        oeGrupoDetalle.IdGrupo = oeGrupo.Id
                        loGrupoDetalle = olGrupoDetalle.ListarLiq(oeGrupoDetalle)
                        LlenarGrupoDetalle(loGrupoDetalle)
                        ListarGastoOperacion(griOrigenDato)
                        MostrarGasto()
                    Case 2 ' CAJA CHICA
                        MostrarTabs(1, ficGrupo)
                        ListarGastoOperacion(griOrigenDato)
                        oeGrupoDetalle = New e_GrupoDetalle
                        oeGrupoDetalle.IdGrupo = oeGrupo.Id
                        oeGrupoDetalle.TipoOperacion = "C"
                        loGrupoDetalle = olGrupoDetalle.Listar(oeGrupoDetalle)
                        LlenarGrupoDetalle(loGrupoDetalle)
                    Case 3 ' FLETES
                        MostrarTabs(1, ficGrupo)
                        oeGrupoDetalle = New e_GrupoDetalle
                        oeGrupoDetalle.IdGrupo = oeGrupo.Id
                        oeGrupoDetalle.TipoOperacion = "F"
                        loGrupoDetalle = olGrupoDetalle.ListarFlete(oeGrupoDetalle)
                        LlenarGrupoDetalle(loGrupoDetalle)
                        ListarFletes()
                        MostrarFlete()
                    Case 4 ' DESCUENTOS
                        MostrarTabs(1, ficGrupo)
                        oeGrupoDetalle = New e_GrupoDetalle
                        oeGrupoDetalle.IdGrupo = oeGrupo.Id
                        oeGrupoDetalle.TipoOperacion = "D"
                        ListarDescuentos()
                        loGrupoDetalle = olGrupoDetalle.ListarDesc(oeGrupoDetalle)
                        LlenarGrupoDetalle(loGrupoDetalle)
                End Select

                If oeGrupo.Tipo <> 3 Then
                    If Operacion <> "Enviar" Then
                        agrOrigenDato.Enabled = True
                    Else
                        agrOrigenDato.Enabled = False
                    End If
                Else
                    agrOrigenDato.Enabled = True
                End If
                VisualizaGrupoDetalle(oeGrupo.Tipo, True)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MostrarFlete()
        Try
            If loGrupoDetalle.Count > 0 Then
                LlenarGrupoDetalle(loGrupoDetalle)
                For Each oe As e_GrupoDetalle In loGrupoDetalle
                    For Each Fila As UltraGridRow In griOrigenDato.Rows
                        If Fila.Cells("IdMovimiento").Value = oe.IdGastoOperacion And oe.Activo Then
                            Fila.Cells("Selec").Value = True
                            Exit For
                        End If
                    Next
                Next
                griOrigenDato.UpdateData()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub AutogeneraGrupo(ByVal IdCtaCte As String)
        Operacion = "Nuevo"
        Try
            IndFleteAdm = True
            Nuevo()
            oeGrupo.IdCuentaCorriente = IdCtaCte
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ListarGastoOperacion(ByVal MiGrilla As UltraGrid)
        Try
            If oeGrupo.Tipo = 1 Or oeGrupo.Tipo = 2 Then
                oeGastoOperacion = New e_GastoOperacion
                olGastoOperacion = New l_GastoOperacion
                If oeGrupo.Tipo = 1 Then
                    oeGastoOperacion.TipoOperacion = "9"
                    oeGastoOperacion.TipoMovimiento = 1
                    oeGastoOperacion.IdEstado = "LIQUIDADA"
                    oeGastoOperacion.IdDocumento = txtNumeroGrupo.Text
                    oeGastoOperacion.Activo = True
                Else
                    oeGastoOperacion.TipoMovimiento = 2
                    oeGastoOperacion.TipoOperacion = "8"
                    If griLista.Rows.Count > 0 Then 
                        oeGastoOperacion.IdCaja = IdCajaUsuario
                    Else
                        oeGastoOperacion.IdCaja = ""
                    End If
                End If
                oeGastoOperacion.Activo = True
                oeGastoOperacion.IdGrupo = oeGrupo.Id
                MiGrilla.ResetDisplayLayout()
                MiGrilla.DataSource = olGastoOperacion.Listar(oeGastoOperacion)
                With MiGrilla.DisplayLayout.Bands(0)
                    .Columns.Add("Selec", "Seleccionar")
                    .Columns("Selec").DataType = System.Type.GetType("System.Boolean")
                    .Columns("Selec").DefaultCellValue = False
                    .Columns("Selec").Header.VisiblePosition = 1
                    .Columns("IdCuentaCorriente").Hidden = True : .Columns("TipoMovimiento").Hidden = True
                    .Columns("TipoDocumento").Hidden = True : .Columns("IdFlujoCaja").Hidden = True
                    .Columns("Flujocaja").Hidden = True : .Columns("IdDocumento").Hidden = True
                    .Columns("IdPeriodo").Hidden = True : .Columns("Periodo").Hidden = True
                    .Columns("SerieDoc").Hidden = True : .Columns("NroDoc").Hidden = True
                    .Columns("IdTipoDocumento").Hidden = True : .Columns("IdProveedor").Hidden = True
                    .Columns("Proveedor").Hidden = True : .Columns("Glosa").Hidden = True
                    .Columns("TipoCambio").Hidden = True : .Columns("IdMoneda").Hidden = True
                    .Columns("Moneda").Hidden = True : .Columns("SubTotal").Hidden = True
                    .Columns("IGV").Hidden = True : .Columns("IdEstado").Hidden = True
                    .Columns("FechaCreacion").Hidden = True : .Columns("UsuarioCReacion").Hidden = True
                    .Columns("Activo").Hidden = True : .Columns("FechaVencimiento").Hidden = True
                    .Columns("IdEstado").Hidden = True : .Columns("IdOrigen").Hidden = True
                    .Columns("Origen").Hidden = True : .Columns("IdDestino").Hidden = True
                    .Columns("Destino").Hidden = True : .Columns("Id").Hidden = True
                    .Columns("IdViaje").Hidden = True : .Columns("IdGrupo").Hidden = True
                    .Columns("IdCopiloto").Hidden = True : .Columns("IdTipoVehiculo").Hidden = True
                    .Columns("IdPiloto").Hidden = True : .Columns("IndAlmacen").Hidden = True
                    .Columns("IdTrabajadorAutoriza").Hidden = True : .Columns("TrabajadorAutoriza").Hidden = True
                    If oeGrupo.Tipo = 2 Then
                        .Columns("Ruta").Hidden = True : .Columns("Glosa").Hidden = False
                        .Columns("Estado").Hidden = True : .Columns("Copiloto").Hidden = True
                        .Columns("NroGrupo").Hidden = True : .Columns("Viaje").Hidden = True
                        .Columns("SerieDoc").Hidden = True : .Columns("NroDoc").Hidden = True
                        .Columns("IdTipoDocumento").Hidden = True : .Columns("IdProveedor").Hidden = True
                        .Columns("Vehiculo").Hidden = True : .Columns("Piloto").Hidden = True
                        .Columns("Glosa").Header.VisiblePosition = 2 : .Columns("IndAlmacen").Hidden = True
                        .Columns("Glosa").Width = 600
                    End If
                    If oeGrupo.Tipo = 1 Then
                        .Columns("Viaje").Header.VisiblePosition = 2 : .Columns("FechaEmision").Header.VisiblePosition = 3
                        .Columns("Ruta").Header.VisiblePosition = 4 : .Columns("Vehiculo").Header.VisiblePosition = 5
                        .Columns("Piloto").Header.VisiblePosition = 6
                        .Columns("Copiloto").Header.VisiblePosition = 7 : .Columns("Estado").Header.VisiblePosition = 8
                        .Columns("Total").Header.VisiblePosition = 9 : .Columns("NroGrupo").Header.VisiblePosition = 10
                    ElseIf oeGrupo.Tipo = 2 Then
                        .Columns("Viaje").Header.VisiblePosition = 2 : .Columns("FechaEmision").Header.VisiblePosition = 3
                        .Columns("Ruta").Header.VisiblePosition = 4 : .Columns("Vehiculo").Header.VisiblePosition = 5
                        .Columns("Piloto").Header.VisiblePosition = 6
                        .Columns("SerieDoc").Header.VisiblePosition = 7 : .Columns("NroDoc").Header.VisiblePosition = 8
                        .Columns("Total").Header.VisiblePosition = 9 : .Columns("NroGrupo").Header.VisiblePosition = 10
                    Else
                        .Columns("Piloto").Header.VisiblePosition = 3 : .Columns("ToTal").Header.VisiblePosition = 4
                        .Columns("Estado").Header.VisiblePosition = 5 : .Columns("FechaEmision").Header.VisiblePosition = 6
                        .Columns("Ruta").Header.VisiblePosition = 7 : .Columns("Copiloto").Header.VisiblePosition = 8
                    End If
                    .Columns("Viaje").CellActivation = Activation.NoEdit
                    .Columns("Piloto").CellActivation = Activation.NoEdit
                    .Columns("Total").CellActivation = Activation.NoEdit
                    .Columns("Estado").CellActivation = Activation.NoEdit
                    .Columns("FechaEmision").CellActivation = Activation.NoEdit
                    .Columns("Ruta").CellActivation = Activation.NoEdit
                    .Columns("Copiloto").CellActivation = Activation.NoEdit
                    .Columns("NroGrupo").CellActivation = Activation.NoEdit
                    .Columns("Vehiculo").CellActivation = Activation.NoEdit
                    .Columns("Total").Style = ColumnStyle.Double
                    .Columns("Total").CellAppearance.TextHAlign = HAlign.Right
                    .Columns("Selec").Width = 50 : .Columns("Viaje").Width = 110 : .Columns("Piloto").Width = 180
                    .Columns("Total").Width = 60 : .Columns("Estado").Width = 80 : .Columns("Copiloto").Width = 180
                    .Columns("Ruta").Width = 150 : .Columns("NroGrupo").Width = 100 : .Columns("Vehiculo").Width = 80
                End With
            Else
                Dim olMovimientoAdm As New l_Movimiento_Administrativo
                Dim oeMovimientoAdm As New e_Movimiento_Administrativo
                Dim loMovimientoAdm As New List(Of e_Movimiento_Administrativo)
                oeMovimientoAdm.TipoOperacion = "3"
                oeMovimientoAdm.IdCaja = "1CH001"
                oeMovimientoAdm.TipoTransa = 1
                loMovimientoAdm = olMovimientoAdm.Listar(oeMovimientoAdm)
                MiGrilla.ResetDisplayLayout()
                MiGrilla.DataSource = loMovimientoAdm
                With MiGrilla.DisplayLayout
                    .Bands(0).Columns.Add("Selec", "Seleccionar")
                    .Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
                    .Bands(0).Columns("Selec").DefaultCellValue = False
                    .Bands(0).Columns("Selec").Header.VisiblePosition = 1
                    .Bands(0).Columns("TipoMovimiento").Hidden = True
                    .Bands(0).Columns("Descuento").Hidden = True
                    .Bands(0).Columns("FechaCreacion").Hidden = True
                    .Bands(0).Columns("CuentaDestino").Hidden = True
                    .Bands(0).Columns("IdCuentaCorrienteD").Hidden = True
                    .Bands(0).Columns("CuentaOrigen").Hidden = True
                    .Bands(0).Columns("IdCuentaCorrienteO").Hidden = True
                    .Bands(0).Columns("CuentaDestino").Hidden = True
                    .Bands(0).Columns("IdTrabajadorCuentaCorriente").Hidden = True
                    '.Bands(0).Columns("Trabajador").Hidden = True
                    .Bands(0).Columns("Id").Hidden = True
                    .Bands(0).Columns("TipoTRansa").Hidden = True
                    .Bands(0).Columns("UsuarioCreacion").Hidden = True
                    .Bands(0).Columns("Saldo").Hidden = True
                    .Bands(0).Columns("IdEstado").Hidden = True
                    .Bands(0).Columns("Ingreso").Hidden = True
                    .Bands(0).Columns("SaldoTotal").Hidden = True
                    .Bands(0).Columns("EgresoTotal").Hidden = True
                    .Bands(0).Columns("IngresoTotal").Hidden = True
                    .Bands(0).Columns("Activo").Hidden = True
                    .Bands(0).Columns("GastosRendidos").Hidden = True
                    .Bands(0).Columns("Fecha").Header.VisiblePosition = 2
                    .Bands(0).Columns("Trabajador").Header.VisiblePosition = 3
                    .Bands(0).Columns("Voucher").Header.VisiblePosition = 4
                    .Bands(0).Columns("Glosa").Header.VisiblePosition = 5
                    .Bands(0).Columns("Egreso").Header.VisiblePosition = 6
                    .Bands(0).Columns("Fecha").Width = 120
                    .Bands(0).Columns("Trabajador").Width = 200
                    .Bands(0).Columns("Voucher").Width = 110
                    .Bands(0).Columns("Glosa").Width = 350
                    .Bands(0).Columns("Egreso").Width = 80
                    .Bands(0).Columns("Fecha").Style = ColumnStyle.DateTime
                    .Bands(0).Columns("Egreso").Style = ColumnStyle.Double
                    .Bands(0).Columns("Egreso").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                End With
            End If
            MiGrilla.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
            MiGrilla.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
            MiGrilla.DisplayLayout.Override.FilterUIProvider = Filtro1
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarGrupoDetalle(ByVal leGrupoDetalle As List(Of e_GrupoDetalle))
        Try
            With griDetalleGrupo
                .ResetDisplayLayout()
                .DataSource = leGrupoDetalle
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdGrupo").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdGastoOperacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdViaje").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdTrabajador").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdOrigen").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdDestino").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdVehiculo").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("Carga").Hidden = True
                .DisplayLayout.Bands(0).Columns("Cliente").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdCliente").Hidden = True
                .DisplayLayout.Bands(0).Columns("Importe").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("Trabajador").Width = 180
                .DisplayLayout.Bands(0).Columns("Importe").Width = 60
                '.DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                '.DisplayLayout.Override.FilterUIProvider = Filtro1
                Select Case oeGrupo.Tipo
                    Case "1"
                        .DisplayLayout.Bands(0).Columns("IdCopiloto").Hidden = True
                        .DisplayLayout.Bands(0).Columns("Saldo").Hidden = True
                        .DisplayLayout.Bands(0).Columns("Glosa").Hidden = True
                        .DisplayLayout.Bands(0).Columns("Usuario").Hidden = True
                        .DisplayLayout.Bands(0).Columns("IndFlete").Hidden = True
                        .DisplayLayout.Bands(0).Columns("Flete").Hidden = True
                        .DisplayLayout.Bands(0).Columns("Depositado").Hidden = True
                        .DisplayLayout.Bands(0).Columns("Cargado").Hidden = True
                        .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").Hidden = True
                        .DisplayLayout.Bands(0).Columns("NroGrupo").Hidden = True
                        .DisplayLayout.Bands(0).Columns("Viaje").Header.VisiblePosition = 1
                        .DisplayLayout.Bands(0).Columns("FechaEmision").Header.VisiblePosition = 2
                        .DisplayLayout.Bands(0).Columns("Ruta").Header.VisiblePosition = 3
                        .DisplayLayout.Bands(0).Columns("Vehiculo").Header.VisiblePosition = 4
                        .DisplayLayout.Bands(0).Columns("Trabajador").Header.VisiblePosition = 5
                        .DisplayLayout.Bands(0).Columns("Copiloto").Header.VisiblePosition = 6
                        .DisplayLayout.Bands(0).Columns("Estado").Header.VisiblePosition = 7
                        .DisplayLayout.Bands(0).Columns("Importe").Header.VisiblePosition = 8
                        '.DisplayLayout.Bands(0).Columns("NroGrupo").Header.VisiblePosition = 9
                        .DisplayLayout.Bands(0).Columns("Estado").Width = 80
                        .DisplayLayout.Bands(0).Columns("Copiloto").Width = 200
                        .DisplayLayout.Bands(0).Columns("Trabajador").Width = 200
                        .DisplayLayout.Bands(0).Columns("Ruta").Width = 150
                        '.DisplayLayout.Bands(0).Columns("NroGrupo").Width = 80
                        .DisplayLayout.Bands(0).Columns("Vehiculo").Width = 80
                        .DisplayLayout.Bands(0).Columns("Viaje").Width = 110
                        .DisplayLayout.Bands(0).Columns("Importe").Style = ColumnStyle.Double
                        .DisplayLayout.Bands(0).Columns("Importe").CellAppearance.TextHAlign = HAlign.Right
                        .DisplayLayout.Bands(0).Columns("Trabajador").Header.Caption = "Piloto"
                        .DisplayLayout.Bands(0).Columns("FechaEmision").Header.Caption = "Fecha"
                        .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                        .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                    Case "2"
                        .DisplayLayout.Bands(0).Columns("NroGrupo").Hidden = True
                        .DisplayLayout.Bands(0).Columns("Vehiculo").Hidden = True
                        .DisplayLayout.Bands(0).Columns("Saldo").Hidden = True
                        .DisplayLayout.Bands(0).Columns("Usuario").Hidden = True
                        .DisplayLayout.Bands(0).Columns("Ruta").Hidden = True
                        .DisplayLayout.Bands(0).Columns("IndFlete").Hidden = True
                        .DisplayLayout.Bands(0).Columns("Flete").Hidden = True
                        .DisplayLayout.Bands(0).Columns("Depositado").Hidden = True
                        .DisplayLayout.Bands(0).Columns("Cargado").Hidden = True
                        .DisplayLayout.Bands(0).Columns("Viaje").Hidden = True
                        .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").Hidden = True
                        .DisplayLayout.Bands(0).Columns("FechaEmision").Header.VisiblePosition = 1
                        .DisplayLayout.Bands(0).Columns("Copiloto").Header.VisiblePosition = 2
                        .DisplayLayout.Bands(0).Columns("Estado").Header.VisiblePosition = 3
                        .DisplayLayout.Bands(0).Columns("Glosa").Header.VisiblePosition = 4
                        .DisplayLayout.Bands(0).Columns("Trabajador").Header.VisiblePosition = 5
                        .DisplayLayout.Bands(0).Columns("Importe").Header.VisiblePosition = 6
                        .DisplayLayout.Bands(0).Columns("IdCopiloto").Header.VisiblePosition = 7
                        .DisplayLayout.Bands(0).Columns("FechaEmision").Header.Caption = "Fecha"
                        .DisplayLayout.Bands(0).Columns("Estado").Header.Caption = "Serie-Numero"
                        .DisplayLayout.Bands(0).Columns("Trabajador").Header.Caption = "TipoGasto"
                        .DisplayLayout.Bands(0).Columns("Copiloto").Header.Caption = "TipoDocumento"
                        .DisplayLayout.Bands(0).Columns("IdCopiloto").Header.Caption = "Trabajador"
                        .DisplayLayout.Bands(0).Columns("FechaEmision").Width = 120
                        .DisplayLayout.Bands(0).Columns("Copiloto").Width = 140
                        .DisplayLayout.Bands(0).Columns("Trabajador").Width = 175
                        .DisplayLayout.Bands(0).Columns("Estado").Width = 110
                        .DisplayLayout.Bands(0).Columns("Glosa").Width = 450
                        .DisplayLayout.Bands(0).Columns("Importe").Width = 80
                        .DisplayLayout.Bands(0).Columns("IdCopiloto").Width = 220
                        .DisplayLayout.Bands(0).Columns("Importe").Style = ColumnStyle.Double
                        .DisplayLayout.Bands(0).Columns("FechaEmision").Style = ColumnStyle.DateTime
                        .DisplayLayout.Bands(0).Columns("Importe").CellAppearance.TextHAlign = HAlign.Right
                        .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                        .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                    Case "3"
                        .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True
                        '.DisplayLayout.Bands(0).Columns("Importe").Hidden = True
                        .DisplayLayout.Bands(0).Columns("IdCopiloto").Hidden = True
                        .DisplayLayout.Bands(0).Columns("Saldo").Hidden = True
                        .DisplayLayout.Bands(0).Columns("Estado").Hidden = True
                        .DisplayLayout.Bands(0).Columns("Ruta").Hidden = True
                        .DisplayLayout.Bands(0).Columns("Copiloto").Hidden = True
                        .DisplayLayout.Bands(0).Columns("NroGrupo").Hidden = True
                        .DisplayLayout.Bands(0).Columns("Ruta").Hidden = True
                        .DisplayLayout.Bands(0).Columns("Glosa").Hidden = True
                        .DisplayLayout.Bands(0).Columns("Usuario").Hidden = True
                        .DisplayLayout.Bands(0).Columns("Vehiculo").Hidden = True
                        .DisplayLayout.Bands(0).Columns("IndFlete").Hidden = True
                        .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").Hidden = True
                        .DisplayLayout.Bands(0).Columns("Viaje").Width = 110
                        .DisplayLayout.Bands(0).Columns("Trabajador").Width = 280
                        .DisplayLayout.Bands(0).Columns("FechaEmision").Width = 80
                        .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").Style = ColumnStyle.Double
                        .DisplayLayout.Bands(0).Columns("Flete").Style = ColumnStyle.Double
                        .DisplayLayout.Bands(0).Columns("Importe").Style = ColumnStyle.Double
                        .DisplayLayout.Bands(0).Columns("Flete").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                        .DisplayLayout.Bands(0).Columns("Cargado").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                        .DisplayLayout.Bands(0).Columns("Depositado").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                        .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                        .DisplayLayout.Bands(0).Columns("Importe").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                        .DisplayLayout.Bands(0).Columns("Importe").CellAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
                        .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").CellAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
                        .DisplayLayout.Bands(0).Columns("Cargado").CellAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
                        .DisplayLayout.Bands(0).Columns("Viaje").Header.VisiblePosition = 2
                        .DisplayLayout.Bands(0).Columns("Trabajador").Header.VisiblePosition = 3
                        .DisplayLayout.Bands(0).Columns("FechaEmision").Header.VisiblePosition = 4
                        .DisplayLayout.Bands(0).Columns("Flete").Header.VisiblePosition = 5
                        .DisplayLayout.Bands(0).Columns("Cargado").Header.VisiblePosition = 6
                        .DisplayLayout.Bands(0).Columns("Depositado").Header.VisiblePosition = 7
                        .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").Header.VisiblePosition = 8
                    Case "4"
                        .DisplayLayout.Bands(0).Columns("Estado").Hidden = True
                        .DisplayLayout.Bands(0).Columns("Copiloto").Hidden = True
                        .DisplayLayout.Bands(0).Columns("Ruta").Hidden = True
                        .DisplayLayout.Bands(0).Columns("NroGrupo").Hidden = True
                        .DisplayLayout.Bands(0).Columns("Vehiculo").Hidden = True
                        .DisplayLayout.Bands(0).Columns("IndFlete").Hidden = True
                        .DisplayLayout.Bands(0).Columns("Flete").Hidden = True
                        .DisplayLayout.Bands(0).Columns("Depositado").Hidden = True
                        .DisplayLayout.Bands(0).Columns("Cargado").Hidden = True
                        .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").Hidden = True
                        .DisplayLayout.Bands(0).Columns("IdCopiloto").Hidden = True
                        .DisplayLayout.Bands(0).Columns("Saldo").Style = ColumnStyle.Double
                        .DisplayLayout.Bands(0).Columns("Saldo").Width = 60
                        .DisplayLayout.Bands(0).Columns("Glosa").Width = 300
                        .DisplayLayout.Bands(0).Columns("Usuario").Width = 300
                        .DisplayLayout.Bands(0).Columns("Viaje").Width = 110
                        .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                        .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                End Select
                .DisplayLayout.Bands(0).Columns("Id").SortIndicator = SortIndicator.Ascending
                .DisplayLayout.Bands(0).Columns("Viaje").MergedCellStyle = MergedCellStyle.Always
                '.DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Bands(0).Override.SelectTypeGroupByRow = SelectType.None
                .DisplayLayout.Bands(0).Override.SelectTypeRow = SelectType.SingleAutoDrag
                '.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                .DisplayLayout.Bands(0).Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MostrarGasto()
        Try
            If loGrupoDetalle.Count > 0 Then
                LlenarGrupoDetalle(loGrupoDetalle)
                For Each oe As e_GrupoDetalle In loGrupoDetalle
                    For Each Fila As UltraGridRow In griOrigenDato.Rows
                        Dim var As String = Fila.Cells("Id").Value
                        If oeGrupo.Tipo = 1 Then
                            If Fila.Cells("IdViaje").Value = oe.IdViaje And oe.Activo Then
                                Fila.Cells("Selec").Value = True
                                Exit For
                            End If
                        Else
                            If Fila.Cells("Id").Value = oe.IdGastoOperacion And oe.Activo Then
                                Fila.Cells("Selec").Value = True
                                Exit For
                            End If
                        End If
                    Next
                Next
                griOrigenDato.UpdateData()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Enviar()
        Try
            Operacion = "Enviar"
            loGrupoDetalle = New List(Of e_GrupoDetalle)
            Mostrar()
            ControlBoton(0, 0, 0, 1, 1, 0, 1, 1, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarGastoOperacion(ByVal oe As e_GrupoDetalle, ByVal o_Fila As UltraGridRow, ByVal Tipo As Integer)
        Try
            If Not loGrupoDetalle.Contains(oe) Then
                oe.IdGrupo = oeGrupo.Id
                Select Case Tipo
                    Case 1
                        oe.Viaje = o_Fila.Cells("Viaje").Value
                        oe.Trabajador = o_Fila.Cells("Piloto").Value
                        oe.Copiloto = o_Fila.Cells("Copiloto").Value
                        oe.Importe = o_Fila.Cells("Total").Value
                        oe.NroGrupo = o_Fila.Cells("NroGrupo").Value
                        oe.Vehiculo = o_Fila.Cells("Vehiculo").Value
                        oe.FechaEmision = o_Fila.Cells("FechaEmision").Value
                        oe.Ruta = o_Fila.Cells("Ruta").Value
                        oe.Estado = o_Fila.Cells("Estado").Value
                        oe.IdViaje = o_Fila.Cells("IdViaje").Value
                    Case 2
                        oe.Trabajador = o_Fila.Cells("Piloto").Value
                        oe.FechaEmision = o_Fila.Cells("FechaEmision").Value
                        oe.Importe = o_Fila.Cells("Total").Value
                        oe.Glosa = o_Fila.Cells("Glosa").Value
                        oe.Estado = o_Fila.Cells("SerieDoc").Value & "-" & o_Fila.Cells("NroDoc").Value
                    Case 3
                        oe.Viaje = o_Fila.Cells("Viaje").Value
                        oe.Trabajador = o_Fila.Cells("Trabajador").Value
                        oe.FechaEmision = o_Fila.Cells("Fecha").Value
                        oe.Flete = o_Fila.Cells("Flete").Value
                        oe.Cargado = o_Fila.Cells("Cargado").Value
                        oe.Depositado = o_Fila.Cells("Depositado").Value
                        oe.SaldoPorDepositar = o_Fila.Cells("SaldoPorDepositar").Value
                        oe.Importe = o_Fila.Cells("SaldoPorDepositar").Value - o_Fila.Cells("Importe").Value
                    Case 4
                        oe.Viaje = o_Fila.Cells("Viaje").Value
                        oe.Trabajador = o_Fila.Cells("Piloto").Value
                        oe.Importe = o_Fila.Cells("Ingreso").Value
                        oe.FechaEmision = o_Fila.Cells("Fecha").Value
                        oe.Glosa = o_Fila.Cells("Glosa").Value
                        oe.Usuario = o_Fila.Cells("Usuario").Value
                        oe.Saldo = o_Fila.Cells("Saldo").Value
                        oe.Ruta = o_Fila.Cells("Ruta").Value
                        oe.Estado = o_Fila.Cells("Estado").Value
                        oe.IdViaje = o_Fila.Cells("IdViaje").Value
                End Select
                If griDetalleGrupo.Rows.Count < 1 Then LlenarGrupoDetalle(loGrupoDetalle)
                loGrupoDetalle.Add(oe)
            Else
                If oe.TipoOperacion = "E" Then
                    oe.TipoOperacion = ""
                    For Each fila As UltraGridRow In griDetalleGrupo.Rows
                        If fila.Cells("IdGastoOperacion").Value = oe.IdGastoOperacion Then
                            fila.Hidden = False
                            Exit For
                        End If
                    Next
                Else
                    Throw New Exception("El Gasto Operacion: " & o_Fila.Cells("IdGastoOperacion").Value & " ya esta Asignada")
                End If
            End If
            CalTotales()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CalTotales()
        Try
            decImporte.Value = 0.0
            For Each GrupoDetalle As e_GrupoDetalle In loGrupoDetalle
                If GrupoDetalle.TipoOperacion <> "E" Then
                    decImporte.Value += GrupoDetalle.Importe
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarGastoOperacion(ByVal oe As e_GrupoDetalle, ByVal tipo As Integer)
        Try
            If oe.Id <> "" Then
                If Tipo = 1 Then
                    oe.TipoOperacion = "E"
                    For Each fila As UltraGridRow In griDetalleGrupo.Rows
                        If fila.Cells("IdGrupoOperacion").Value = oe.IdGastoOperacion Then
                            fila.Hidden = True
                            Exit For
                        End If
                    Next
                ElseIf Tipo = 2 Then
                    oe.TipoOperacion = "E"
                    For Each fila As UltraGridRow In griDetalleGrupo.Rows
                        If fila.Cells("Id").Value = oe.Id Then
                            fila.Hidden = True
                            Exit For
                        End If
                    Next
                End If
            Else
                loGrupoDetalle.Remove(oe)
            End If
            CalTotales()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarGastoOperacion()
        Try
            If griDetalleGrupo.ActiveRow.Selected Then
                Dim oeDetGru As New e_GrupoDetalle
                oeDetGru = griDetalleGrupo.ActiveRow.ListObject
                If oeDetGru.TipoOperacion = "I" Then
                    oeDetGru = loGrupoDetalle.Item(loGrupoDetalle.IndexOf(oeDetGru))
                    loGrupoDetalle.Remove(oeDetGru)
                Else
                    oeDetGru = loGrupoDetalle.Item(loGrupoDetalle.IndexOf(oeDetGru))
                    oeDetGru.TipoOperacion = "E"
                    griDetalleGrupo.ActiveRow.Hidden = True
                End If
                griDetalleGrupo.DataBind()
            Else
                Exit Sub
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function EnviarGrupo() As Boolean
        Try
            Dim ind As Boolean = False
            If oeGrupo.Tipo = "1" Then
                oeGrupo.loMovimiento = DevuelveListaMovimiento(loGrupoDetalle, oeGrupo.Tipo)
            Else
                IndLiquidado = True
            End If
            VerificarLiquidaciones()
            If IndLiquidado Then
                oeGrupo.loDetalleGrupo = loGrupoDetalle
                If oeGrupo.Tipo <> 3 And oeGrupo.Tipo <> 4 Then
                    If griDetalleGrupo.Rows.Count = 0 Or griOrigenDato.Rows.Count > 0 Then
                        Throw New Exception("Falta Subir Gastos y/o Liquidaciones")
                    End If
                End If
                oeGrupo.IdEstado = "ENVIADO"
                If oeGrupo.Tipo = 2 Then
                    If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "ENVIAR GRUPOS CC") = False Then
                        oeGrupo.IdEstado = "PRE-ENVIADO"
                    End If
                    If loDetGruCC.Count > 0 Then
                        QuitarGastosCC()
                    End If
                End If
                If olGrupo.Enviar(oeGrupo) Then
                    If oeGrupo.Tipo = 2 And oeGrupo.IdEstado = "PRE-ENVIADO" Then
                        Dim oePerfil As New e_Perfil
                        Dim olPerfil As New l_Perfil
                        oePerfil.TipoOperacion = "M"
                        oePerfil.Id = "1CH000000017"
                        oePerfil.Nombre = "Envio de Grupo de Caja Chica: " & oeGrupo.Codigo & ", Usuario: " & gUsuarioSGI.oePersona.NombreCompleto & ", En Espera de Aprobacion. "
                        oePerfil.PrefijoID = gs_PrefijoIdSucursal '@0001
                        olPerfil.Guardar(oePerfil)
                    End If
                    mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                    MostrarTabs(0, ficGrupo)
                    InicializaGrupo()
                    Consultar(True)
                    griLista.Focus()
                    ind = True
                End If
                Return ind
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub VerificarLiquidaciones()
        Try
            Dim oeGasOpe As New e_GastoOperacion
            Dim olGasOpe As New l_GastoOperacion
            Dim loGasOpe As New List(Of e_GastoOperacion)
            oeGasOpe.IdGrupo = oeGrupo.Id
            oeGasOpe.TipoOperacion = "X"
            loGasOpe = olGasOpe.Listar(oeGasOpe)
            ListarGastoOperacion(griOrigenDato)
            MostrarGasto()
            For Each oe As e_GastoOperacion In loGasOpe
                If oe.IdEstado = "1CH00012" Then
                    mensajeEmergente.Problema("Falta Liquidar Viaje Antes de Enviar Grupo: " & oe.Viaje)
                    IndLiquidado = False
                    Exit Sub
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try    
    End Sub

    Public Function DevuelveListaMovimiento(ByVal loGrupoD As List(Of e_GrupoDetalle), ByVal Tipo As Integer) As List(Of e_Movimiento)
        Try
            Dim oeMovViaje As New e_Movimiento_Viaje
            Dim olMovViaje As New l_Movimiento_Viaje
            Dim oeMovimiento As New e_Movimiento
            Dim loMovimiento As New List(Of e_Movimiento)
            Dim id As String = ""
            For Each oe As e_GrupoDetalle In loGrupoD
                If id <> oe.IdViaje Then
                    id = oe.IdViaje
                    Dim lo As New List(Of e_Movimiento_Viaje)
                    oeMovViaje = New e_Movimiento_Viaje
                    oeMovViaje.IdViaje = oe.IdViaje
                    Select Case Tipo
                        Case 1
                            oeMovViaje.TipoOperacion = "A"
                            oeMovViaje.Id = ""
                            oeMovViaje.TipoTransa = ""
                        Case 4
                            oeMovViaje.TipoOperacion = "5"
                            oeMovViaje.TipoTransa = "4"
                    End Select
                    lo = olMovViaje.Listar(oeMovViaje)
                    Select Case Tipo
                        Case 1
                            For Each oeMov As e_Movimiento_Viaje In lo
                                If oeMov.TipoTransa = 1 And oeMov.Estado = "HABILITADA" Then
                                    mensajeEmergente.Problema("Viaje No Liquidado - " & "Verificar Viaje: " & oeMov.Viaje)
                                    IndLiquidado = False
                                    Return Nothing
                                    Exit Function
                                Else
                                    IndLiquidado = True
                                End If
                                If oeMov.TipoTransa <> "6" Then
                                    oeMovimiento = New e_Movimiento
                                    oeMovimiento.Id = oeMov.IdMovimiento
                                    loMovimiento.Add(oeMovimiento)
                                End If
                            Next
                            'Case 2
                            'Case 3
                        Case 4
                            For Each oeMov As e_Movimiento_Viaje In lo
                                If oeMov.TipoTransa = "4" Then
                                    oeMovimiento.Id = oeMov.IdMovimiento
                                    loMovimiento.Add(oeMovimiento)
                                End If
                            Next
                    End Select
                End If
            Next
            Return loMovimiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub ListarFletes()
        Try
            Dim oeMovimientoFlete As New e_Movimiento_Flete
            Dim olMovimientoFlete As New l_Movimiento_Flete
            If IndFleteAdm = True Then
                oeMovimientoFlete.TipoOperacion = "9"
            Else
                oeMovimientoFlete.TipoOperacion = "4"
            End If
            With griOrigenDato
                .ResetDisplayLayout()
                .DataSource = olMovimientoFlete.Listar(oeMovimientoFlete)
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True
                .DisplayLayout.Bands(0).Columns.Add("Selec", "Seleccionar")
                .DisplayLayout.Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
                .DisplayLayout.Bands(0).Columns("Selec").DefaultCellValue = False
                .DisplayLayout.Bands(0).Columns("Selec").Header.VisiblePosition = 1

                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdOperacionDetalle").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdMovimiento").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdCheque").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdViaje").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdTrabajador").Hidden = True
                .DisplayLayout.Bands(0).Columns("ApellidoPaterno").Hidden = True
                .DisplayLayout.Bands(0).Columns("ApellidoMaterno").Hidden = True
                .DisplayLayout.Bands(0).Columns("Nombre").Hidden = True
                .DisplayLayout.Bands(0).Columns("Glosa").Hidden = True
                .DisplayLayout.Bands(0).Columns("NumeroCheque").Hidden = True
                .DisplayLayout.Bands(0).Columns("TipoCobro").Hidden = True
                .DisplayLayout.Bands(0).Columns("Carga").Hidden = True
                .DisplayLayout.Bands(0).Columns("Cliente").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdCliente").Hidden = True
                .DisplayLayout.Bands(0).Columns("Importe").Hidden = True

                .DisplayLayout.Bands(0).Columns("Origen").Hidden = True
                .DisplayLayout.Bands(0).Columns("Destino").Hidden = True
                .DisplayLayout.Bands(0).Columns("Cobrado").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdGrupo").Hidden = True

                .DisplayLayout.Bands(0).Columns("Viaje").Width = 110
                .DisplayLayout.Bands(0).Columns("Trabajador").Width = 280
                .DisplayLayout.Bands(0).Columns("Fecha").Width = 70

                ' .DisplayLayout.Bands(0).Columns("Fecha").Width = 70

                .DisplayLayout.Bands(0).Columns("Viaje").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Trabajador").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Flete").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("Cargado").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("Depositado").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").Header.VisiblePosition = 8

                .DisplayLayout.Bands(0).Columns("Fecha").Style = ColumnStyle.Date
                .DisplayLayout.Bands(0).Columns("Flete").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("Cargado").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("Depositado").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").Style = ColumnStyle.Double
                '.DisplayLayout.Bands(0).Columns("Importe").Style = ColumnStyle.Double

                .DisplayLayout.Bands(0).Columns("Flete").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("Cargado").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("Depositado").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right

                .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").CellAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
                .DisplayLayout.Bands(0).Columns("Cargado").CellAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))

                .DisplayLayout.Bands(0).Columns("Viaje").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("Trabajador").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("Fecha").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("Flete").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("Cargado").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("Depositado").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit

                .DisplayLayout.Bands(0).Columns("Viaje").CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Bands(0).Columns("Fecha").CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Bands(0).Columns("Flete").CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Bands(0).Columns("Cargado").CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Bands(0).Columns("Depositado").CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Bands(0).Columns("SaldoPorDepositar").CellClickAction = CellClickAction.RowSelect

                '.DisplayLayout.Bands(0).Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
                .DisplayLayout.Bands(0).Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.FilterUIProvider = Filtro1
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ListarDescuentos()
        Try
            Dim oeMovimientoViaje As New e_Movimiento_Viaje
            Dim olMovimientoViaje As New l_Movimiento_Viaje
            oeMovimientoViaje.TipoOperacion = "5"
            oeMovimientoViaje.TipoTransa = "4"
            oeMovimientoViaje.Activo = True
            griOrigenDato.ResetDisplayLayout()
            griOrigenDato.DataSource = olMovimientoViaje.Listar(oeMovimientoViaje)
            With griOrigenDato.DisplayLayout.Bands(0)
                .Columns.Add("Selec", "Seleccionar")
                .Columns("Selec").DataType = System.Type.GetType("System.Boolean")
                .Columns("Selec").DefaultCellValue = False
                .Columns("Selec").Header.VisiblePosition = 1
                .Columns("Id").Hidden = True : .Columns("IdMovimiento").Hidden = True
                .Columns("IdViaje").Hidden = True : .Columns("TipoTransa").Hidden = True
                .Columns("UsuarioCreacion").Hidden = True : .Columns("IdTipoVehiculo").Hidden = True
                .Columns("Voucher").Hidden = True : .Columns("IdEstado").Hidden = True
                .Columns("IdPiloto").Hidden = True : .Columns("IdTrabajadorRecepciona").Hidden = True
                .Columns("RecibeBolsa").Hidden = True : .Columns("FechaRecepcion").Hidden = True
                .Columns("SaldoTotal").Hidden = True : .Columns("EgresoTotal").Hidden = True
                .Columns("IngresoTotal").Hidden = True : .Columns("Activo").Hidden = True
                .Columns("TipoTRB").Hidden = True : .Columns("IdTipoDocumento").Hidden = True
                .Columns("IdTracto").Hidden = True : .Columns("GastosRendidos").Hidden = True
                .Columns("FechaLiquidacion").Hidden = True : .Columns("FechaReembolso").Hidden = True
                .Columns("Ruta").Hidden = True : .Columns("Tipovehiculo").Hidden = True
                .Columns("Estado").Hidden = True : .Columns("Carreta").Hidden = True
                .Columns("Tracto").Hidden = True : .Columns("Empresa").Hidden = True
                .Columns("TipoDocumento").Hidden = True : .Columns("Egreso").Hidden = True
                .Columns("Saldo").Hidden = True : .Columns("Carga").Hidden = True
                .Columns("FecLleDestino").Hidden = True : .Columns("FecSalOrigen").Hidden = True
                .Columns("IdOperacion").Hidden = True : .Columns("Operacion").Hidden = True
                .Columns("Descuento").Hidden = True
                .Columns("Glosa").Header.VisiblePosition = 2
                .Columns("Fecha").Header.VisiblePosition = 3
                .Columns("Ingreso").Header.VisiblePosition = 4
                .Columns("Saldo").Header.VisiblePosition = 5
                .Columns("Piloto").Header.VisiblePosition = 6
                .Columns("Viaje").Header.VisiblePosition = 7
                .Columns("Usuario").Header.VisiblePosition = 8
                .Columns("Viaje").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .Columns("Usuario").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .Columns("Fecha").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .Columns("Saldo").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .Columns("Ingreso").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .Columns("Piloto").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .Columns("Glosa").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .Columns("Viaje").CellClickAction = CellClickAction.RowSelect
                .Columns("Usuario").CellClickAction = CellClickAction.RowSelect
                .Columns("Fecha").CellClickAction = CellClickAction.RowSelect
                .Columns("Saldo").CellClickAction = CellClickAction.RowSelect
                .Columns("Ingreso").CellClickAction = CellClickAction.RowSelect
                .Columns("Piloto").CellClickAction = CellClickAction.RowSelect
                .Columns("Glosa").CellClickAction = CellClickAction.RowSelect
                .Columns("Fecha").Style = ColumnStyle.DateTime
                .Columns("Selec").Width = 50 : .Columns("Viaje").Width = 110 : .Columns("Piloto").Width = 180
                .Columns("Glosa").Width = 250 : .Columns("Saldo").Width = 80 : .Columns("Ingreso").Width = 80
                .Columns("Usuario").Width = 200 : .Columns("Fecha").Width = 115
                .Columns("Piloto").MergedCellStyle = MergedCellStyle.Always
                .Columns("Viaje").MergedCellStyle = MergedCellStyle.Always
                .Columns("Piloto").CellAppearance.TextVAlign = VAlign.Middle
                .Columns("Ingreso").CellAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
                .Columns("Saldo").CellAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
            End With
            griOrigenDato.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
            griOrigenDato.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
            griOrigenDato.DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
            griOrigenDato.DisplayLayout.Override.FilterUIProvider = Filtro1
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub VisualizaGrupoDetalle(ByVal Tipo As Integer, Optional ByVal Envio As Boolean = False)
        Try
            Select Case Tipo
                Case 1
                    ficDetalleGrupo.Tabs(0).Text = "Liquidaciones"
                    agrOrigenDato.Expanded = Envio
                    agrOrigenDato.Visible = Envio
                    agrOrigenDato.Text = "<< Lista de Liquidaciones >>"
                Case 2
                    ficDetalleGrupo.Tabs(0).Text = "Caja Chica"
                    agrOrigenDato.Expanded = True
                    agrOrigenDato.Visible = True
                    agrOrigenDato.Text = "<< Lista de Gastos de Caja Chica >>"
                Case 3
                    ficDetalleGrupo.Tabs(0).Text = "Fletes"
                    agrOrigenDato.Expanded = True
                    agrOrigenDato.Visible = True
                    agrOrigenDato.Text = "<< Lista de Fletes >>"
                Case 4
                    ficDetalleGrupo.Tabs(0).Text = "Descuentos"
                    agrOrigenDato.Expanded = True
                    agrOrigenDato.Visible = True
                    agrOrigenDato.Text = "<< Lista de Descuentos >>"
            End Select
            btnSeleccionar.Text = "Agregar Todo"
            btnSeleccionar.Appearance.Image = My.Resources.Agregar
            btnSeleccionar.Tag = "Selec"
        Catch ex As Exception
            Throw ex
        End Try  
    End Sub

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("Codigo") Then
            txtNumeroGrupo.Focus()
        End If
        'If excepcion.Contains("Centro") Then
        '    cboCentro.Focus()
        'End If
    End Sub

    Private Function ObtenerCodigo() As String
        Try
            Dim oe As New e_Grupo
            oe.TipoOperacion = "C"
            oe.Tipo = Tip
            oe.Codigo = Pre
            Return olGrupo.Obtener(oe).Codigo
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Sub BuscarUsuarioCaja()
        Try
            oeCajaUsuario = New e_CajaUsuario
            oeCajaUsuario = BuscarCajaUsuario(gUsuarioSGI.IdTrabajador)
            If oeCajaUsuario.Id <> "" Then
                cboCentroL.Value = oeCajaUsuario.IdCentro
                IdCajaUsuario = oeCajaUsuario.IdCaja
                If oeCajaUsuario.IdCentro = "1CH001" Then
                    cboCentroL.Enabled = True
                    cboTipoGrupo.Enabled = True
                Else
                    cboCentroL.Enabled = False
                    cboTipoGrupo.Enabled = True
                End If
            Else
                Throw New Exception("Usuario no Asignado a Caja")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub GruposPreEnviados()
        Try
            cboTipoGrupo.SelectedIndex = 2
            cboEstadoL.SelectedIndex = 1
            cboCentroL.SelectedIndex = 0
            ListarGrupo()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Menú contextual del maestro de SituacionAdministrativas"

    Private Sub AsociarMenu()
        griLista.ContextMenuStrip = MenuContextual1
    End Sub

    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        MenuContextual1.Items("tsmiInsertar").Visible = True
        If griLista.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("tsmiActualizar").Visible = True
            MenuContextual1.Items("tsmiEnviar").Visible = True
            MenuContextual1.Items("tsmiCambiaEstado").Visible = False
            If griLista.ActiveRow.Cells("Estado").Value = "ENVIADO" Or griLista.ActiveRow.Cells("Estado").Value = "REEMBOLSADO" Then
                MenuContextual1.Items("tsmiEnviar").Visible = False
                MenuContextual1.Items("tsmiActualizar").Visible = False
                If griLista.ActiveRow.Cells("Saldo").Value = 0 AndAlso _
                griLista.ActiveRow.Cells("Saldo").Value <> griLista.ActiveRow.Cells("ImporteTotal").Value Then MenuContextual1.Items("tsmiCambiaEstado").Visible = False
            Else
                If griLista.ActiveRow.Cells("Tipo").Value <> 1 AndAlso griLista.ActiveRow.Cells("ImporteTotal").Value = 0 Then MenuContextual1.Items("tsmiEnviar").Visible = False
                MenuContextual1.Items("tsmiCambiaEstado").Visible = False
            End If
            If griLista.ActiveRow.Cells("Estado").Value = "PRE-ENVIADO" And olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "ENVIAR GRUPOS CC") = True Then
                MenuContextual1.Items("tsmiEnviar").Visible = True
            End If
        Else
            MenuContextual1.Items("tsmiActualizar").Visible = False
            MenuContextual1.Items("tsmiEnviar").Visible = False
            MenuContextual1.Items("tsmiCambiaEstado").Visible = False
        End If
    End Sub

    Private Sub tsmiInsertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiInsertar.Click
        Nuevo()
    End Sub

    Private Sub tsmiActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiActualizar.Click
        If griLista.ActiveRow.Cells("Estado").Value.ToString = "ENVIADO" Then
            mensajeEmergente.Problema("No Puede Editar Grupos Enviados")
        Else
            Editar()
        End If
    End Sub

    Private Sub tsmiEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEnviar.Click
        Enviar()
    End Sub

    Private Sub tsmiCambiaEstado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiCambiaEstado.Click
        Try
            oeGrupo = New e_Grupo
            Dim olGrupo As New l_Grupo
            oeGrupo.Id = griLista.ActiveRow.Cells("Id").Value
            oeGrupo.Codigo = griLista.ActiveRow.Cells("Codigo").Value
            oeGrupo.IdCentro = griLista.ActiveRow.Cells("IdCentro").Value
            oeGrupo.TipoOperacion = "C"
            oeGrupo.Tipo = ""
            oeGrupo.IdEstado = "GENERADA"
            oeGrupo.PrefijoID = gs_PrefijoIdSucursal '@0001
            olGrupo.Guardar(oeGrupo)
            Consultar(True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Quitar Gastos Asociados"

    Private Sub btnListarEquipos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarEquipos.Click
        Try
            Select Case oeGrupo.Tipo
                Case 1
                    ListarGastoOperacion(griOrigenDato)
                    MostrarGasto()
                Case 2
                    ListarGastoOperacion(griOrigenDato)
                Case 3
                    ListarFletes()
                    MostrarFlete()
                Case 4
                    ListarDescuentos()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub MenuContextual2_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual2.Opening
        MenuContextual2.Items("Quitar").Visible = False
        'If Me.griDetalleGrupo.Selected.Rows.Count > 0 And oeGrupo.Tipo = 1 Then
        '    MenuContextual2.Items("Quitar").Visible = True
        'End If
        If Me.griDetalleGrupo.Selected.Rows.Count > 0 And oeGrupo.Tipo = 2 And olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "ENVIAR GRUPOS CC") = True And oeGrupo.IdEstado = "1CH00033" Then
            MenuContextual2.Items("Quitar").Visible = True
        End If
    End Sub

    Private Sub Quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Quitar.Click
        Try
            QuitarGastoAsociado()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub QuitarGastoAsociado()
        Try
            If griDetalleGrupo.ActiveRow.Selected Then
                If oeGrupo.Tipo = 1 Then
                    Dim oeDetGru As New e_GrupoDetalleLiq
                    Dim olDetGru As New l_GrupoDetalleLiq
                    With Me.griDetalleGrupo.ActiveRow
                        oeDetGru.TipoOperacion = "X"
                        oeDetGru.Id = .Cells("Id").Value.ToString
                        oeDetGru.IdGrupo = .Cells("IdGrupo").Value.ToString
                        oeDetGru.Monto = .Cells("Importe").Value
                        oeDetGru.PrefijoID = gs_PrefijoIdSucursal '@0001
                        If olDetGru.Guardar(oeDetGru) Then
                            Mostrar()
                        End If
                    End With
                ElseIf oeGrupo.Tipo = 2 Then
                    Dim oe As New e_GrupoDetalle
                    oeDetGruCC = New e_GrupoDetalle
                    oe.Id = griDetalleGrupo.ActiveRow.Cells("Id").Value
                    ValidarCierre(griDetalleGrupo.ActiveRow.Cells("IdVehiculo").Value, griDetalleGrupo.ActiveRow.Cells("FechaEmision").Value)
                    QuitarGastoOperacion()
                    oeDetGruCC.TipoOperacion = "E"
                    oeDetGruCC.Id = griDetalleGrupo.ActiveRow.Cells("Id").Value.ToString
                    oeDetGruCC.IdGastoOperacion = griDetalleGrupo.ActiveRow.Cells("IdGastoOperacion").Value.ToString
                    oeDetGruCC.Viaje = griDetalleGrupo.ActiveRow.Cells("Viaje").Value.ToString
                    oeDetGruCC.Importe = griDetalleGrupo.ActiveRow.Cells("Importe").Value
                    loDetGruCC.Add(oeDetGruCC)
                    Recalcular(oeDetGruCC.Importe)
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Recalcular(ByVal Monto As Double)
        decImporte.Value = decImporte.Value - Monto
    End Sub

    Private Sub ValidarCierre(ByVal IdCaja As String, ByVal FechaGasto As Date)
        Try
            Dim oeSaldo As New e_Saldo
            Dim olSaldo As New l_Saldo
            oeSaldo.TipoOperacion = "3"
            oeSaldo.IdCaja = IdCaja
            oeSaldo = olSaldo.Obtener(oeSaldo)
            If FechaGasto <= oeSaldo.FechaHora Then
                Throw New Exception("No Puede Retirar Gastos pasado el Cierre de Caja")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class