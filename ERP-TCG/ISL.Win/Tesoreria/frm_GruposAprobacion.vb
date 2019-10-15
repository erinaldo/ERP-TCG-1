'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_GruposAprobacion
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializacion"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_GruposAprobacion = Nothing
    Private Shared Operacion As String = ""

    Public Overrides Function getInstancia() As frm_MenuPadre
        Operacion = "Inicializa"
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_GruposAprobacion()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Declaracion de variables"

    Private WithEvents oeGrupoAprobacion As New e_GrupoAprobacion
    Private olGrupoAprobacion As New l_GrupoAprobacion

    Private oeGrupoAprobacionDet As New e_GrupoAprobacionDet
    Private olGrupoAprobacionDet As New l_GrupoAprobacionDet
    Private loGrupoAprobacionDet As New List(Of e_GrupoAprobacionDet)

    Dim oeGrupo As New e_Grupo
    Dim olGrupo As New l_Grupo
    Dim loGrupo As New List(Of e_Grupo)

    Dim oeCheque As New e_ChequeEmitido
    Dim olCheque As New l_ChequeEmitido

    Private oeChequeControl As New e_ChequesControl
    Private olChequeControl As New l_ChequesControl

    Private oeChequesTalonarios As New e_ChequesTalonarios
    Private olChequesTalonarios As New l_ChequesTalonarios

    Private idCtaCte As String = ""

    Dim _ingresando_datos As Boolean = False

#End Region

#Region "Botones"

    Public Overrides Sub Nuevo()
        Try
            Operacion = "Nuevo"
            MostrarTabs(1, ficGruposAprobacion, 1)
            Inicializar()
            InactivarBotonesCheque(1)
            ActivarBotones(True)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Tiempo1.Enabled = True
            Listar()
            ActivarBotones(True)
            If griLista.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Inicializar()
            Operacion = "Editar"
            If griLista.ActiveRow.Band.Index = 0 Then
                If Me.griLista.ActiveRow.Cells("Estado").Value.ToString = "APROBADA" Then
                    ControlBoton(1, 1, 1, 0, 0, 0, 1, 1, 1)
                Else
                    MostrarTabs(1, ficGruposAprobacion, 1)
                    InactivarBotonesCheque(False)
                    ActivarBotones(True)
                    Mostrar()
                    ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 1)
                End If
            Else
                Dim oeGrupoDetalle As New e_GrupoDetalle
                Dim olGrupoDetalle As New l_GrupoDetalle
                Dim loGrupoDetalle As New List(Of e_GrupoDetalle)
                Dim frm As New frm_DetalleGrupos
                Select Case griLista.ActiveRow.Cells("Tipo").Value
                    Case 1
                        oeGrupoDetalle = New e_GrupoDetalle
                        oeGrupoDetalle.IdGrupo = griLista.ActiveRow.Cells("IdGrupo").Value
                        loGrupoDetalle = olGrupoDetalle.ListarLiq(oeGrupoDetalle)
                        frm.MostrarDetalle(loGrupoDetalle, 1, griLista.ActiveRow.Cells("Codigo").Value)
                    Case 2
                        oeGrupoDetalle = New e_GrupoDetalle
                        oeGrupoDetalle.IdGrupo = griLista.ActiveRow.Cells("IdGrupo").Value
                        oeGrupoDetalle.TipoOperacion = "C"
                        loGrupoDetalle = olGrupoDetalle.Listar(oeGrupoDetalle)
                        frm.MostrarDetalle(loGrupoDetalle, 2, griLista.ActiveRow.Cells("Codigo").Value)
                    Case 4
                        oeGrupoDetalle = New e_GrupoDetalle
                        oeGrupoDetalle.IdGrupo = griLista.ActiveRow.Cells("IdGrupo").Value
                        oeGrupoDetalle.TipoOperacion = "D"
                        loGrupoDetalle = olGrupoDetalle.ListarDesc(oeGrupoDetalle)
                        frm.MostrarDetalle(loGrupoDetalle, 4, griLista.ActiveRow.Cells("Codigo").Value)
                End Select
                frm.ShowDialog()
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.WindowState = FormWindowState.Maximized

            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            Select Case ficGruposAprobacion.SelectedTab.Index
                Case 1
                    If GuardarGrupos() Then
                        MostrarTabs(0, ficGruposAprobacion, 0)
                        Listar()
                    Else
                        MostrarTabs(1, ficGruposAprobacion, 1)
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeGrupoAprobacion.Modificado Then
                Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarGrupos() Then
                            MostrarTabs(0, ficGruposAprobacion, 2)
                            _ingresando_datos = False
                            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficGruposAprobacion, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficGruposAprobacion, 2)
                        _ingresando_datos = False
                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End Select
            Else
                MostrarTabs(0, ficGruposAprobacion)
                _ingresando_datos = False
                Listar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If ficGruposAprobacion.Tabs(0).Selected AndAlso griLista.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            If ficGruposAprobacion.Tabs(0).Selected Then Exportar_Excel(griLista)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Dim id As String = ""
        Try
            Dim formulario As New frm_ImprimirGrupoAprobacion
            If griLista.Selected.Rows.Count > 0 And griLista.ActiveRow.Selected = True And griLista.ActiveRow.Band.Index = 0 Then
                If ficGruposAprobacion.SelectedTab.Index = 0 Then
                    id = griLista.ActiveRow.Cells("Id").Value
                    formulario.CargarDatos(id)
                    formulario.ShowDialog()
                    ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                Else
                    id = oeGrupoAprobacion.Id
                    formulario.CargarDatos(id)
                    formulario.ShowDialog()
                    ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 1)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        EliminarGrupoAprobacion()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_GruposAprobacion_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Try
            Select Case ficGruposAprobacion.SelectedTab.Index
                Case 0
                    If griLista.Rows.Count > 0 Then
                        ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                    Else
                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                    End If
                Case 1
                    ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 1)
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub frm_GruposAprobacion_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_GruposAprobacion_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub griListaGrupos_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaGrupos.CellChange
        Try
            griListaGrupos.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griListaGruposAprobar_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaGruposAprobar.CellChange
        Try
            griListaGruposAprobar.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griLista_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griLista.DoubleClick
        Editar()
    End Sub

    Private Sub frm_GruposAprobacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        gmt_ConfigurarEventoKeyEnter_Tab(Me)
        gf_AsignarEventoSeleccionarTexto(Me)
        Me.rangoFechaDesde.Value = Date.Now.AddDays(-15)
        CargarCuentaBancaria()
        CargarCuentaCorriente()
        Me.txtNroCheque.Value = ""
        MostrarTabs(0, ficGruposAprobacion, 0)
        If PermisoEvaluacion() Then
            btnEvaluar.Enabled = False
        End If
    End Sub

    Private Sub MenuDetalle_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles MenuDetalle.ToolClick
        Try
            Select Case e.Tool.Key
                Case "Agregar"
                    AgregarGrupo()
                Case "Eliminar"
                    QuitarGrupo()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub btnEvaluarReq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEvaluar.Click
        If griLista.Rows.Count > 0 Then
            Operacion = "Evaluar"
            MostrarTabs(1, ficGruposAprobacion, 1)
            InactivarBotonesCheque(False)
            Mostrar()
            ActivarBotones(False)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
            gbeGrupos.Expanded = False
            gbeGrupos.Enabled = False
        End If
    End Sub

    Private Sub griLista_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griLista.BeforeRowsDeleted
        Try
            If griLista.Rows.Count > 1 Then
                e.DisplayPromptMsg = False
                If griLista.ActiveRow.Cells("Estado").Value = "GENERADA" Then
                    If EliminarGrupoAprobacion() Then
                        e.Cancel = False
                    Else
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griLista_AfterRowActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griLista.AfterRowActivate
        ControlarEstadoOrden()
    End Sub

    Private Sub cboCuentaBancaria_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuentaBancaria.ValueChanged
        oeCheque.IdCuentaBancaria = cboCuentaBancaria.Value
    End Sub

    Private Sub txtNroCheque_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroCheque.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtNroCheque_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroCheque.Validated
        txtNroCheque.Text = FormatoDocumento(txtNroCheque.Text, 8)
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Eliminar()
    End Sub

    Private Sub cboCuentaBancaria_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuentaBancaria.Validated
        Try
            CargaNumeroCheque()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Public Sub Inicializar()
        oeCheque = New e_ChequeEmitido
        oeGrupoAprobacion = New e_GrupoAprobacion
        loGrupoAprobacionDet.Clear()
        griListaGruposAprobar.DataSource = loGrupoAprobacionDet
        Me.decTotal.Value = 0.0
        Me.txtNroCheque.Text = ""
        Me.txtGlosa.Text = String.Empty
        Me.FechaAprob.Value = Date.Now
        Me.fecFecha.Value = Date.Now
        Me.fecCheque.Value = Date.Now
        cboCuentaBancaria.SelectedIndex = -1
        ListarGrupos()
        If Operacion = "Nuevo" Then
            oeGrupoAprobacion.Modificado = False
            oeGrupoAprobacion.TipoOperacion = "I"
            oeGrupoAprobacion.IdEstado = "1CH00014"
        End If
    End Sub

    Public Sub Listar()
        Try
            oeGrupoAprobacion = New e_GrupoAprobacion
            With oeGrupoAprobacion
                .Fecha = Me.rangoFechaDesde.Value
                .FechaCreacion = Me.rangoFechaHasta.Value
                .TipoOperacion = "3"
            End With
            Dim loGrupoAprobacion As New List(Of e_GrupoAprobacion)
            Dim ids As String = ""
            loGrupoAprobacion.AddRange(olGrupoAprobacion.ListarDetalle(oeGrupoAprobacion))
            If loGrupoAprobacion.Count > 0 Then
                For Each gruapr As e_GrupoAprobacion In loGrupoAprobacion
                    ids = ids & "'" & gruapr.Id & "',"
                Next
                oeGrupoAprobacion = New e_GrupoAprobacion
                oeGrupoAprobacion.TipoOperacion = ""
                oeGrupoAprobacion.IdTrabajadorAprobacion = ids.Substring(0, ids.Length - 1)
                Dim ds As DataSet = olGrupoAprobacion.Listar(oeGrupoAprobacion)
                Dim parentCol As DataColumn = ds.Tables(0).Columns("Id")
                Dim childCol As DataColumn = ds.Tables(1).Columns("IdGrupoAprobacion")
                Dim relation As DataRelation = New DataRelation("FKGrupoAprobacion", parentCol, childCol, True)
                ds.Relations.Add(relation)
                ds.AcceptChanges()
                griLista.DataSource = ds
                With griLista
                    .DisplayLayout.Bands(1).Columns("Id").Hidden = True
                    .DisplayLayout.Bands(1).Columns("IdGrupoAprobacion").Hidden = True
                    .DisplayLayout.Bands(1).Columns("IdGrupo").Hidden = True
                    .DisplayLayout.Bands(1).Columns("Activo").Hidden = True
                    .DisplayLayout.Bands(1).Columns("Tipo").Hidden = True

                    .DisplayLayout.Bands(1).Columns("Importe").Header.VisiblePosition = 3
                    .DisplayLayout.Bands(1).Columns("Codigo").Header.VisiblePosition = 1
                    .DisplayLayout.Bands(1).Columns("Glosa").Header.VisiblePosition = 2
                    .DisplayLayout.Bands(0).Columns("Banco").Header.VisiblePosition = 6

                    .DisplayLayout.Bands(0).Columns("Banco").Width = 200
                    .DisplayLayout.Bands(1).Columns("Codigo").Width = 125
                    .DisplayLayout.Bands(1).Columns("Glosa").Width = 674
                    .DisplayLayout.Bands(1).Columns("Importe").Style = ColumnStyle.Double
                    .DisplayLayout.Bands(0).Columns("Importe").Format = "#,###,###,####0.00"
                    .DisplayLayout.Bands(1).Columns("Importe").Format = "#,###,###,####0.00"
                    .DisplayLayout.Bands(1).Columns("Importe").CellAppearance.TextHAlign = HAlign.Right
                    .DisplayLayout.Bands(1).Columns("Importe").Header.Appearance.TextHAlign = HAlign.Right
                End With
            End If
            If griLista.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
            FormatoColorGrilla(griLista)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GuardarGrupos() As Boolean
        Try
            oeGrupoAprobacion.oeChequeEmitido = New e_ChequeEmitido
            With oeGrupoAprobacion.oeChequeEmitido
                If oeGrupoAprobacion.TipoOperacion = "I" Then
                    .TipoOperacion = "I"
                    .IdCuentaCorriente = idCtaCte
                Else
                    .TipoOperacion = "A"
                    .Id = oeCheque.Id
                    .IdCuentaCorriente = oeCheque.IdCuentaCorriente
                End If
                .NroCheque = CStr(txtNroCheque.Value)
                .Fecha = fecCheque.Value
                .FechaCobro = fecCheque.Value
                .FechaCreacion = Date.Now
                .IdCentro = ObtenerCentro.Id
                .UsuarioCreacion = gUsuarioSGI.Id
                .Importe = decTotal.Value
                .Saldo = decTotal.Value
                .Detalle = "CHEQUE PARA REEMBOLSO DE GRUPOS DE CAJA"
                .IdEstado = "1CH00031"
                .IdConcepto = "1SI000000016"
                .IdCuentaBancaria = cboCuentaBancaria.Value
                .IdTrabajador = gUsuarioSGI.IdTrabajador
            End With
            olCheque.Validar(oeGrupoAprobacion.oeChequeEmitido)
            With oeGrupoAprobacion
                If Operacion = "Editar" Then .TipoOperacion = "A"
                If Operacion = "Evaluar" Then
                    .IdEstado = "1CH00031"
                    .TipoOperacion = "V"
                    .FechaAprobacion = Date.Now
                    .IdTrabajadorAprobacion = gUsuarioSGI.IdTrabajador
                Else
                    .loListaGrupoAprobacionDet = loGrupoAprobacionDet
                    .Importe = decTotal.Value
                    .Glosa = txtGlosa.Text
                    .Fecha = fecFecha.Value
                    .FechaAprobacion = FechaAprob.Value
                    .FechaCreacion = Date.Now
                    .IdCheque = oeCheque.Id
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .FechaCreacion = Date.Now
                    .IdEstado = "1CH00014"
                End If
                oeGrupoAprobacion.PrefijoID = gs_PrefijoIdSucursal '@0001
                If olGrupoAprobacion.Guardar(oeGrupoAprobacion) Then
                    If .TipoOperacion = "I" Then
                        Dim frm As New frm_ImprimirGrupoAprobacion
                        frm.CargarDatos(oeGrupoAprobacion.Id)
                        frm.StartPosition = FormStartPosition.CenterScreen
                        frm.ShowDialog()
                    End If
                    mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                    Return True
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Private Sub Mostrar()
        Try
            Dim a As String = ""
            If griLista.ActiveRow.Band.Index = 0 Then
                oeGrupoAprobacion = New e_GrupoAprobacion
                oeCheque = New e_ChequeEmitido
                oeGrupoAprobacion.TipoOperacion = "1"
                oeGrupoAprobacion.Id = griLista.ActiveRow.Cells("Id").Value
                oeGrupoAprobacion = olGrupoAprobacion.Obtener(oeGrupoAprobacion)
                decTotal.Value = oeGrupoAprobacion.Importe
                fecFecha.Value = oeGrupoAprobacion.Fecha
                txtGlosa.Text = oeGrupoAprobacion.Glosa
                oeCheque.Id = griLista.ActiveRow.Cells("IdCheque").Value
                oeCheque.TipoOperacion = "1"
                oeCheque = olCheque.Obtener(oeCheque)
                txtNroCheque.Value = oeCheque.NroCheque
                fecCheque.Value = oeCheque.Fecha
                cboCuentaBancaria.Value = oeCheque.IdCuentaBancaria
            End If
            ListarDetalle()
            gbeGrupos.Expanded = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub ListarDetalle()
        oeGrupoAprobacionDet = New e_GrupoAprobacionDet
        oeGrupoAprobacionDet.IdGrupoAprobacion = oeGrupoAprobacion.Id
        oeGrupoAprobacionDet.TipoOperacion = ""
        loGrupoAprobacionDet = olGrupoAprobacionDet.Listar(oeGrupoAprobacionDet)
        griListaGruposAprobar.DataSource = loGrupoAprobacionDet
        CalcularTotales(griListaGruposAprobar, "Importe")
    End Sub

    Private Sub InactivarBotonesCheque(ByVal Activo As Boolean)
        fecCheque.Enabled = Activo
        txtNroCheque.Enabled = Activo
        cboCuentaBancaria.Enabled = Activo
    End Sub

    Private Sub AgregarGrupo()
        Try
            For Each grupo As e_Grupo In loGrupo.Where(Function(Item) Item.Seleccion = True)
                oeGrupoAprobacionDet = New e_GrupoAprobacionDet()
                oeGrupoAprobacionDet.Seleccion = False
                oeGrupoAprobacionDet.Activo = True
                oeGrupoAprobacionDet.Id = ""
                oeGrupoAprobacionDet.TipoOperacion = "I"
                oeGrupoAprobacionDet.IdGrupo = grupo.Id
                oeGrupoAprobacionDet.IdGrupoAprobacion = ""
                oeGrupoAprobacionDet.Importe = grupo.ImporteTotal
                oeGrupoAprobacionDet.Glosa = grupo.GlosaEnvio
                oeGrupoAprobacionDet.Codigo = grupo.Codigo
                loGrupoAprobacionDet.Add(oeGrupoAprobacionDet)
            Next
            griListaGruposAprobar.DataBind()
            gbeGrupos.Expanded = False
            loGrupo.RemoveAll(AddressOf eliminaGrupos)
            griListaGrupos.DataBind()
            CalcularTotal()
            CalcularTotales(griListaGruposAprobar, "Importe")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarGrupo()
        loGrupoAprobacionDet.RemoveAll(AddressOf verificarSeleccionado)
        griListaGrupos.DataBind()
        griListaGruposAprobar.DataBind()
        CalcularTotal()
    End Sub

    Private Function verificarSeleccionado(ByVal oeGruAproDet As e_GrupoAprobacionDet) As Boolean
        Try
            If Not String.IsNullOrEmpty(oeGruAproDet.IdGrupo) AndAlso oeGruAproDet.Seleccion Then
                Dim oeGrupo As New e_Grupo
                oeGrupo.TipoOperacion = "1"
                oeGrupo.Id = oeGruAproDet.IdGrupo
                oeGrupo.Activo = True
                oeGrupo = olGrupo.Obtener(oeGrupo)
                loGrupo.Add(oeGrupo)
            End If
            Return oeGruAproDet.Seleccion
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Sub CalcularTotal()
        Try
            decTotal.Value = 0.0
            For Each det As e_GrupoAprobacionDet In loGrupoAprobacionDet
                decTotal.Value += det.Importe
            Next
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function eliminaGrupos(ByVal oeGru As e_Grupo) As Boolean
        Return oeGru.Seleccion
    End Function

    Private Sub ListarGrupos()
        Try
            oeGrupo.TipoOperacion = "S"
            oeGrupo.Estado = "ENVIADO"
            griListaGrupos.ResetDisplayLayout()
            loGrupo = olGrupo.Listar(oeGrupo)
            griListaGrupos.DataSource = loGrupo
            With griListaGrupos.DisplayLayout
                .Bands(0).Columns("Id").Hidden = True
                .Bands(0).Columns("FechaReembolso").Hidden = True
                .Bands(0).Columns("IdCentro").Hidden = True
                .Bands(0).Columns("IdEstado").Hidden = True
                .Bands(0).Columns("Estado").Hidden = True
                .Bands(0).Columns("Activo").Hidden = True
                .Bands(0).Columns("FechaCreacion").Hidden = True
                .Bands(0).Columns("UsuarioCreacion").Hidden = True
                .Bands(0).Columns("ImportePagar").Hidden = True
                .Bands(0).Columns("IdCuentaCorriente").Hidden = True
                .Bands(0).Columns("Saldo").Hidden = True
                .Bands(0).Columns("NroCheque").Hidden = True
                .Bands(0).Columns("Tipo").Hidden = True
                .Bands(0).Columns("Saldo").Hidden = True
                .Bands(0).Columns("Fecha").Hidden = True

                .Bands(0).Columns("Seleccion").Width = 50
                .Bands(0).Columns("Codigo").Width = 120
                .Bands(0).Columns("GlosaEnvio").Width = 400

                .Bands(0).Columns("Seleccion").Style = ColumnStyle.CheckBox
                .Bands(0).Columns("ImporteTotal").Style = UltraWinGrid.ColumnStyle.Double
                .Bands(0).Columns("Saldo").Style = UltraWinGrid.ColumnStyle.Double

                .Bands(0).Columns("Seleccion").Header.CheckBoxSynchronization = HeaderCheckBoxSynchronization.None
                .Bands(0).Columns("Seleccion").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Never
                .Bands(0).Columns("Seleccion").Header.VisiblePosition = 0

                .Bands(0).Columns("Seleccion").Header.VisiblePosition = 1
                .Bands(0).Columns("Codigo").Header.VisiblePosition = 2
                .Bands(0).Columns("GlosaEnvio").Header.VisiblePosition = 3
                .Bands(0).Columns("FechaEnvio").Header.VisiblePosition = 5
                .Bands(0).Columns("ImporteTotal").Header.VisiblePosition = 4
                .Bands(0).Columns("Centro").Header.VisiblePosition = 6

                .Bands(0).Columns("ImporteTotal").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right

                .Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                .Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
                .Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
                .CaptionVisible = DefaultableBoolean.False
                .Override.FilterUIProvider = Filtro1

                For Each Columna As UltraGridColumn In griListaGrupos.DisplayLayout.Bands(0).Columns
                    If Not Columna.Key = "Seleccion" Then Columna.CellClickAction = CellClickAction.RowSelect : Columna.CellActivation = Activation.NoEdit
                Next
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub ActivarBotones(ByVal Activo As Boolean)
        gbeGrupos.Expanded = Activo
        gbeGrupos.Enabled = Activo
        fecFecha.Enabled = Activo
        FechaAprob.Enabled = Activo
        txtGlosa.Enabled = Activo
        MenuDetalle.Enabled = Activo
    End Sub

    Private Sub FormatoColorGrilla(ByVal grilla As Infragistics.Win.UltraWinGrid.UltraGrid)
        For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In grilla.Rows
            Select Case fila.Cells("Estado").Value
                Case "GENERADA"
                    fila.CellAppearance.BackColor = Me.ColoresPorAprobar.Color
                Case "APROBADA"
                    fila.CellAppearance.BackColor = Me.ColoresAprobado.Color
            End Select
        Next
    End Sub

    Public Sub ControlarEstadoOrden()
        Try
            btnEvaluar.Enabled = False
            btnEliminar.Enabled = False
            If griLista.ActiveRow.Band.Index = 0 Then
                If griLista.ActiveRow.Index > -1 Then
                    Select Case griLista.ActiveRow.Cells("Estado").Value
                        Case "GENERADA"
                            If PermisoEvaluacion() Then
                                btnEvaluar.Enabled = True
                            End If
                            btnEliminar.Enabled = True
                        Case "EVALUADA"
                            btnEvaluar.Enabled = False
                    End Select
                End If
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Private Sub CargarCuentaBancaria()
        Try
            Dim oeCtaBan As New e_CuentaBancaria
            Dim olCtaBan As New l_CuentaBancaria
            oeCtaBan.Activo = 1
            LlenarCombo(cboCuentaBancaria, "BancoCuenta", olCtaBan.Listar(oeCtaBan), -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarCuentaCorriente()
        Try
            Dim oeCtaCte As New e_CuentaCorriente
            Dim olCtaCte As New l_CuentaCorriente
            oeCtaCte.IdTrabajador = gUsuarioSGI.IdTrabajador
            oeCtaCte.Tipo = 1
            oeCtaCte = olCtaCte.Obtener(oeCtaCte)
            idCtaCte = oeCtaCte.Id
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function EliminarGrupoAprobacion() As Boolean
        Try
            If MessageBox.Show("Desea Eliminar el Registro Seleccionado?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                oeGrupoAprobacion = New e_GrupoAprobacion
                oeGrupoAprobacion.Id = griLista.ActiveRow.Cells("Id").Value
                olGrupoAprobacion.Eliminar(oeGrupoAprobacion)
            Else
                Return False
                Exit Function
            End If
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Function PermisoEvaluacion() As Boolean
        Dim oeTrabSeg As New e_TrabajadorSeguridad
        Dim olTrabSeg As New l_TrabajadorSeguridad
        oeTrabSeg.IdTrabajador = gUsuarioSGI.IdTrabajador
        oeTrabSeg.TipoOperacion = "H"
        oeTrabSeg.NombreProceso = "EVALUACION GRUPOS"
        oeTrabSeg = olTrabSeg.Obtener(oeTrabSeg)
        If oeTrabSeg.IdTrabajador = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub CargaNumeroCheque()
        Try
            oeChequeControl = New e_ChequesControl
            oeChequesTalonarios = New e_ChequesTalonarios
            oeChequeControl.IdCuentaBancaria = cboCuentaBancaria.Value
            oeChequeControl.TipoOperacion = "2"
            oeChequeControl = olChequeControl.Obtener(oeChequeControl)
            If oeChequeControl.Id <> "" Then
                oeChequesTalonarios.TipoOperacion = "2"
                oeChequesTalonarios.IdChequesControl = oeChequeControl.Id
                oeChequesTalonarios.IdResponsable = gUsuarioSGI.IdTrabajador
                oeChequesTalonarios = olChequesTalonarios.Obtener(oeChequesTalonarios)
                If oeChequesTalonarios.Id <> "" Then
                    Me.txtNroCheque.Text = oeChequesTalonarios.Correlativo
                Else
                    Me.txtNroCheque.Text = ""
                    cboCuentaBancaria.SelectedIndex = -1
                    Throw New Exception("Chequera No Asignada, Terminada y/o Anulada , No Puede Crear Cheques")
                End If
            Else
                cboCuentaBancaria.SelectedIndex = -1
                Me.txtNroCheque.Text = ""
                Throw New Exception("Talonario de Cheques del Banco no Registrado en el Sistema. Verificar")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Menu Contextual"

    Private Sub MenuAgregados_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuAgregados.Opening
        Try
            MenuAgregados.Items("ToolStripMenuItem1").Visible = True
            MenuAgregados.Items("ToolStripMenuItem2").Visible = False
            MenuAgregados.Items("ToolStripMenuItem3").Visible = False
            If griLista.ActiveRow.Band.Index = 0 Then
                If Me.griLista.Rows.Count > 0 Then
                    If griLista.ActiveRow.Cells("Estado").Value = "GENERADA" Then
                        If PermisoEvaluacion() = True Then
                            MenuAgregados.Items("ToolStripMenuItem2").Visible = True
                        End If
                        MenuAgregados.Items("ToolStripMenuItem3").Visible = True
                    Else
                        MenuAgregados.Items("ToolStripMenuItem2").Visible = False
                    End If
                Else
                    MenuAgregados.Items("ToolStripMenuItem2").Visible = False
                    MenuAgregados.Items("ToolStripMenuItem3").Visible = False
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Nuevo()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        btnEvaluar.PerformClick()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Eliminar()
    End Sub

#End Region

End Class