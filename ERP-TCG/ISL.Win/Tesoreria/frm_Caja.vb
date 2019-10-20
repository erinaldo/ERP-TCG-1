'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_Caja
    Inherits ISL.Win.frm_MenuPadre

#Region "Constructores e Inicialización del formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Private Shared Instancia As frm_Caja = Nothing
    Private Shared Operacion As String
    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_Caja()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Declaración de variables"

    'Declaración de instancia para el control de modificaciones de la entidad en el formulario
    Private WithEvents oeCaja As New e_Caja

    Dim olCaja As New l_Caja

    Private WithEvents oeCajaMonto As New e_CajaMonto

    Dim olCajaMonto As New l_CajaMonto

    Dim oeCuentaBancaria As New e_CuentaBancaria
    Dim olCuentaBancaria As New l_CuentaBancaria

    Private WithEvents oeCajaUsuario As New e_CajaUsuario

    Dim olCajaUsuario As New l_CajaUsuario

    Dim oeTrabajador As New e_Trabajador
    Dim olTrabajador As New l_Trabajador

    Dim leCajaUsuario As New List(Of e_CajaUsuario)

    Dim oeCentro As New e_Centro
    Dim olCentro As New l_Centro

    Dim _ingresando_datos As Boolean = False
    Dim _ingresando_datos_monto As Boolean = False
    Dim VerificarMonto As Boolean = False
    Dim _id As String = ""

#End Region

#Region "Menus y Fichas"
    Public Sub Botones(ByVal oeBoton As e_Boton)
        Try
            With MenuMovimiento
                .Tools("Consultar").SharedProps.Enabled = oeBoton.Consultar
                .Tools("Nuevo").SharedProps.Enabled = oeBoton.Nuevo
                .Tools("Editar").SharedProps.Enabled = oeBoton.Editar
                .Tools("Guardar").SharedProps.Enabled = oeBoton.Guardar
                .Tools("Cancelar").SharedProps.Enabled = oeBoton.Cancelar
                .Tools("Eliminar").SharedProps.Enabled = oeBoton.Eliminar
            End With
        Catch ex As Exception
        End Try
    End Sub
    Public Sub r_Botonera(ByVal lb_Consultar As Boolean, ByVal lb_Nuevo As Boolean, ByVal lb_Editar As Boolean, _
                                      ByVal lb_Guardar As Boolean, ByVal lb_Eliminar As Boolean, ByVal lb_Cancelar As Boolean)
        o_Botonera.Consultar = lb_Consultar
        o_Botonera.Nuevo = lb_Nuevo
        o_Botonera.Editar = lb_Editar
        o_Botonera.Guardar = lb_Guardar
        o_Botonera.Eliminar = lb_Eliminar
        o_Botonera.Cancelar = lb_Cancelar
        Botones(o_Botonera)
    End Sub
    Private Sub MenuMovimiento_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles MenuMovimiento.ToolClick
        Select Case e.Tool.Key
            Case "Consultar"
                ListarMovimiento()
            Case "Nuevo"
                NuevoMovimiento()
            Case "Editar"
                EditarMovimiento()
            Case "Guardar"
                GuardarMovimiento()
            Case "Eliminar"
                EliminarMovimiento()
            Case "Cancelar"
                CancelarMovimiento()
        End Select
    End Sub

    Private Sub ListarMovimiento()
        Select Case ficMovimiento.SelectedTab.Index
            Case 0
                ListarMonto(True)
        End Select
    End Sub
    Private Sub EditarMovimiento()
        Select Case ficMovimiento.SelectedTab.Index
            Case 0
                MostrarMonto()
        End Select
    End Sub
    Private Sub NuevoMovimiento()
        Select Case ficMovimiento.SelectedTab.Index
            Case 0
                NuevoMonto()
        End Select
    End Sub
    Private Sub GuardarMovimiento()
        Select Case ficMovimiento.SelectedTab.Index
            Case 0
                If Not GuardarMonto() Then
                    'txtCodigoPrestamo.Focus()
                    MostrarTabs(1, ficMontoCaja, 1)
                End If
        End Select
    End Sub
    Private Sub CancelarMovimiento()
        Select Case ficMovimiento.SelectedTab.Index
            Case 0
                CancelarMonto()
        End Select
    End Sub
    Private Sub EliminarMovimiento()
        Select Case ficMovimiento.SelectedTab.Index
            Case 0
                EliminarMonto()
        End Select
    End Sub
#End Region

#Region "Montos"

    Private Sub InicializarMonto()
        cboCaja.SelectedIndex = -1
        txtCuentaBancaria.Text = String.Empty
        cboCaja.SelectedIndex = -1
        decMonto.Value = 0.0
        decSaldoCuenta.Value = 0.0
        fecFecha.Value = Date.Today
        verActivoMonto.Checked = True
        With oeCajaMonto
            .UsuarioCreacion = gUsuarioSGI.Id
            .Id = String.Empty
            .IdCuentaBancaria = String.Empty
            If griListaCaja.Rows.Count > 0 AndAlso Not griListaCaja.ActiveRow Is Nothing Then
                oeCajaMonto.IdCaja = griListaCaja.ActiveRow.Cells("Id").Value.ToString
            Else
                oeCajaMonto.IdCaja = ""
            End If
            .Monto = 0.0
            .Activo = True
        End With
    End Sub

    Private Sub CancelarMonto()
        If oeCajaMonto.Modificado Then
            Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & " el monto de caja?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                Case Windows.Forms.DialogResult.Yes
                    If GuardarMonto() Then
                        MostrarTabs(0, ficMontoCaja, 2)
                        _ingresando_datos_monto = False
                    Else
                        _ingresando_datos_monto = True
                        MostrarTabs(1, ficMontoCaja, 1)
                    End If
                    Exit Sub
                Case Windows.Forms.DialogResult.No
                    MostrarTabs(0, ficMontoCaja, 2)
                    _ingresando_datos_monto = False
                    Inicializar()
                    ListarMonto(True)
                    Exit Sub
            End Select
            r_Botonera(True, True, True, False, False, True)
        Else
            MostrarTabs(0, ficMontoCaja, 2)
            _ingresando_datos_monto = False
            ListarMonto(True)
            Exit Sub
        End If
        _ingresando_datos_monto = True
    End Sub

    Private Sub EliminarMonto()
        With griMontoCaja
            If ValidarGrilla(griMontoCaja, "Monto de Caja") Then
                oeCajaMonto.Id = .ActiveRow.Cells("ID").Value
                oeCajaMonto = olCajaMonto.Obtener(oeCajaMonto)
                If oeCajaMonto.Activo Then
                    If MessageBox.Show("Esta seguro de eliminar el Monto de la caja: " & _
                             .ActiveRow.Cells("Monto").Value.ToString & " referenciada a " & .ActiveRow.Cells("NumeroCuenta").Value.ToString _
                             & " ?", _
                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        oeCajaMonto.Tipooperacion = "E"
                        olCajaMonto.Eliminar(oeCajaMonto)
                        InicializarMonto()
                        Consultar(True)
                        ListarMonto(True)
                    End If
                Else
                    mensajeEmergente.Problema("La informacion  se encuentra eliminada en " & Me.Text)
                End If
            End If
        End With
    End Sub

    Private Sub NuevoMonto()
        verActivoMonto.Visible = False
        MostrarOcultarCuentaBancaria()
        ListarCuentaBancaria(True)
        oeCajaMonto.Tipooperacion = "I"
        MostrarTabs(1, ficMontoCaja, 1)
        InicializarMonto()
        oeCajaMonto.Id = String.Empty
        cboCaja.Focus()
        r_Botonera(False, False, False, True, False, True)
    End Sub

    Private Sub MostrarMonto()
        Try
            verActivoMonto.Visible = True
            LlenaCombos()
            spcCuentaBancaria.Panel2Collapsed = False
            verActivoMonto.Visible = True
            cboCaja.Focus()
            ListarCuentaBancaria(True)
            If griMontoCaja.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                InicializarMonto()
                oeCajaMonto.Id = griMontoCaja.ActiveRow.Cells("Id").Value.ToString
                oeCajaMonto = olCajaMonto.Obtener(oeCajaMonto)
                With oeCajaMonto
                    .Tipooperacion = "A"
                    fecFecha.Value = .Fecha
                    decMonto.Value = .Monto
                    cboCaja.Value = .IdCaja
                    txtCuentaBancaria.Text = .NumeroCuenta
                    verActivoMonto.Checked = .Activo
                    If griListaCuentaBancaria.Rows.Count > 0 Then
                        For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griListaCuentaBancaria.Rows
                            If fila.Cells("Id").Value = .IdCuentaBancaria Then
                                fila.Cells("selec").Value = True
                                decSaldoCuenta.Value = fila.Cells("SaldoInicial").Value
                                Exit For
                            End If
                        Next
                    End If
                End With
                MostrarTabs(1, ficMontoCaja, 1)
                oeCajaMonto.Modificado = False
            End If
            r_Botonera(False, False, False, True, False, True)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ListarMonto(ByVal Activo As Boolean)
        InicializarMonto()
        oeCajaMonto.IdCaja = _id
        oeCajaMonto.Activo = Activo
        Try
            Me.Cursor = Cursors.WaitCursor
            With griMontoCaja
                .DataSource = olCajaMonto.Listar(oeCajaMonto)
                '.DisplayLayout.Bands(0).Columns("Modificado").Hidden = True
                '.DisplayLayout.Bands(0).Columns("TipoOperacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
            End With
            If griMontoCaja.Rows.Count > 0 Then
                r_Botonera(True, True, True, False, True, False)
            Else
                r_Botonera(True, True, False, False, False, False)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griMontoCaja.Focus()
    End Sub

    Private Function GuardarMonto() As Boolean
        Try
            If Not VerificarMonto Then Throw New Exception("El monto asignado no es correcto " & Me.Text)
            If decMonto.Value <= 0 Then Throw New Exception("El monto asignado no es correcto")
            oeCajaMonto.Activo = verActivoMonto.Checked
            oeCajaMonto.PrefijoID = gs_PrefijoIdSucursal '@0001
            If Not olCajaMonto.Guardar(oeCajaMonto) Then
                Return False
            End If
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
            MostrarTabs(0, ficMontoCaja, 2)
            'Consultar(True)
            InicializarMonto()
            ListarMonto(True)
            griMontoCaja.Focus()
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            'ListarGrillaMovimientos()
            'ListarCuentaBancaria(True)
            If griListaCaja.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            oeCaja.Tipooperacion = "I"
            MostrarTabs(1, tcCaja, 1)
            Inicializar()
            txtCodigo.Focus()
            Operacion = "Nuevo"
            verActivo.Visible = False
            MyBase.Nuevo()
            oeCaja.Modificado = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            MostrarCaja()
            oeCaja.Tipooperacion = "A"
            txtCodigo.Focus()
            Operacion = "Editar"
            MyBase.Editar()
            oeCaja.Modificado = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarCaja() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcCaja, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeCaja.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarCaja() Then
                            MostrarTabs(0, tcCaja, 2)
                            _ingresando_datos = False
                            Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, tcCaja, 1)
                        End If
                        LimpiaGrid(griUsuarioCaja, ogdUsuarioCaja)
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcCaja, 2)
                        MenuMovimiento.Visible = True
                        MostrarTabs(0, ficMovimiento, 1)
                        LimpiaGrid(griUsuarioCaja, ogdUsuarioCaja)
                        MostrarTabs(0, ficMovimiento)
                        _ingresando_datos = False
                        Consultar(True)
                    Case Windows.Forms.DialogResult.Cancel
                        _ingresando_datos = True
                End Select
            Else
                MostrarTabs(0, tcCaja, 2)
                MenuMovimiento.Visible = True
                LimpiaGrid(griUsuarioCaja, ogdUsuarioCaja)
                MostrarTabs(0, ficMovimiento)
                verActivo.Visible = False
                _ingresando_datos = False
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Public Overrides Sub Eliminar()
        Try
            Dim oeCaja As New e_Caja
            Dim oeCajaMontoVer As New e_CajaMonto
            With griListaCaja
                If ValidarGrilla(griListaCaja, "Caja") Then
                    oeCaja.Id = .ActiveRow.Cells("ID").Value
                    oeCaja = olCaja.Obtener(oeCaja)
                    oeCajaMontoVer.Id = String.Empty
                    oeCajaMontoVer.IdCaja = .ActiveRow.Cells("ID").Value
                    oeCajaMontoVer.Activo = True
                    If oeCaja.Activo Then
                        If MessageBox.Show("Esta caja presenta " & olCajaMonto.Listar(oeCajaMontoVer).Count & " movimientos, está seguro de eliminar caja: " & _
                                 .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeCaja.Tipooperacion = "E"
                            olCaja.Eliminar(oeCaja)
                            Consultar(True)
                        End If
                    Else
                        Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                    End If
                End If
            End With
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
            If griListaCaja.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griListaCaja)

            MyBase.Exportar()
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

#End Region

#Region "Eventos"

    Private Sub LlenaCombos()
        Inicializar()
        LlenarComboMaestro(cboCaja, olCaja.Listar(oeCaja), -1)
        LlenarCombo(cboCentro, "Nombre", olCentro.Listar(oeCentro), -1)
    End Sub

    Private Sub oeCaja_DatoCambiado() Handles oeCaja.DatoCambiado
        oeCaja.Modificado = True
    End Sub

    Private Sub oeCajaMonto_DatoCambiado() Handles oeCajaMonto.DatoCambiado
        oeCajaMonto.Modificado = True
        oeCaja.Modificado = True
    End Sub

    Private Sub oeCajaUsuario_DatoCambiado() Handles oeCajaUsuario.DatoCambiado
        oeCajaUsuario.Modificado = True
        oeCaja.Modificado = True
    End Sub

    Private Sub frm_Caja_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case Operacion
            Case "Nuevo"
                MyBase.Nuevo()
            Case "Editar"
                MyBase.Editar()
            Case "Inicializa"
                Consultar(True)
            Case "Ayuda"

        End Select
    End Sub

    Private Sub frm_Caja_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Instancia = Nothing

    End Sub

    Private Sub frm_Caja_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub frm_Caja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        r_Botonera(True, True, False, False, False, False)
        MostrarTabs(0, tcCaja)
        MostrarTabs(0, ficMontoCaja)
        MostrarTabs(0, ficMovimiento)
        VerificarMonto = True
        Tiempo1.Enabled = False
        griListaCaja.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        griListaCaja.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        InicializaTiempo()
        LlenaCombos()
    End Sub

    Private Sub griListaCaja_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaCaja.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griListaCaja_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaCaja.DoubleClick
        If griListaCaja.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        txtCodigo.SelectAll()
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        txtCodigo.Text = LTrim(txtCodigo.Text)
        oeCaja.Codigo = txtCodigo.Text.Trim
    End Sub

    Private Sub txtNombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.GotFocus
        txtNombre.SelectAll()
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        txtNombre.Text = LTrim(txtNombre.Text)
        oeCaja.Nombre = txtNombre.Text.Trim
    End Sub

    Private Sub txtAbreviatura_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbreviatura.GotFocus
        txtAbreviatura.SelectAll()
    End Sub

    Private Sub txtAbreviatura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAbreviatura.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtAbreviatura_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAbreviatura.ValueChanged
        txtAbreviatura.Text = LTrim(txtAbreviatura.Text)
        oeCaja.Abreviatura = txtAbreviatura.Text.Trim
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeCaja.Activo = verActivo.Checked
    End Sub

    Private Sub verActivo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles verActivo.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub griListaCaja_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griListaCaja.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub griListaCaja_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griListaCaja.InitializeLayout
        agrTotalCaja.Text = "Total de Cajas: " & e.Layout.Rows.Count
    End Sub
    'INICIO MONTOS
    Private Sub ListarGrillaMovimientos()
        Select Case ficMovimiento.SelectedTab.Index
            Case 1
                ListarCuentaBancaria(True)
        End Select
    End Sub

    Private Sub txtCuentaBancaria_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCuentaBancaria.GotFocus
        txtCuentaBancaria.SelectAll()
    End Sub

    Private Sub txtCuentaBancaria_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuentaBancaria.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtCuentaBancaria_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuentaBancaria.ValueChanged
        'oeCajaMonto.IdCuentaBancaria = txtCuentaBancaria.Tag.ToString.Trim
        'If txtCuentaBancaria.Tag.ToString.Length = 0 Then
        '    oeCajaMonto.IdCuentaBancaria = String.Empty
        'End If
        'Texto1.Text = oeCajaMonto.IdCuentaBancaria
    End Sub

    Private Sub cboCaja_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCaja.ValueChanged
        oeCajaMonto.Modificado = True
        oeCajaMonto.IdCaja = cboCaja.Value
    End Sub

    Private Sub cboCaja_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCaja.KeyDown
        TeclaPulsada(e)
        oeCajaMonto.Modificado = True
    End Sub

    Private Sub fecFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecFecha.ValueChanged
        oeCajaMonto.Fecha = fecFecha.Value
    End Sub

    Private Sub fecFecha_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fecFecha.KeyDown
        TeclaPulsada(e)
        oeCajaMonto.Modificado = True
    End Sub

    Private Sub decMonto_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles decMonto.ValueChanged
        If decMonto.Value > 0 AndAlso decMonto.Value < decSaldoCuenta.Value Then
            decMonto.Appearance.BackColor = Color.LightBlue
            VerificarMonto = True
        Else
            decMonto.Appearance.BackColor = Color.IndianRed
            VerificarMonto = False
        End If
        oeCajaMonto.Monto = decMonto.Value
    End Sub

    Private Sub decMonto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles decMonto.GotFocus
        decMonto.SelectAll()
    End Sub

    Private Sub decMonto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles decMonto.KeyDown
        TeclaPulsada(e)
        oeCajaMonto.Modificado = True
    End Sub

    Private Sub btnMostrarCuentaBancaria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrarCuentaBancaria.Click
        MostrarOcultarCuentaBancaria()
    End Sub

    Sub MostrarOcultarCuentaBancaria()
        If Me.spcCuentaBancaria.Panel2Collapsed Then
            Me.spcCuentaBancaria.Panel2Collapsed = False
        Else
            Me.spcCuentaBancaria.Panel2Collapsed = True
        End If
        'cargar listados
    End Sub

    Private Sub NuevoContext()
        If MenuContextual1.SourceControl Is griListaCaja Then
            Nuevo()
        ElseIf MenuContextual1.SourceControl Is griMontoCaja Then
            NuevoMovimiento()
        End If
    End Sub

    Private Sub EliminarContext()
        If MenuContextual1.SourceControl Is griListaCaja Then
            Eliminar()
        ElseIf MenuContextual1.SourceControl Is griMontoCaja Then
            EliminarMovimiento()
        End If
    End Sub

    Private Sub griListaCuentaBancaria_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaCuentaBancaria.AfterCellUpdate
        Try
            Dim Total_Selec As Integer

            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griListaCuentaBancaria.Rows
                If fila.Cells("Seleccion").Value = True Then
                    Total_Selec += 1
                End If
                If Total_Selec > 1 Then
                    fila.Cells("Seleccion").Value = False
                    fila.Appearance.BackColor = Color.White
                    fila.Fixed = False
                End If
            Next

            Select Case e.Cell.Column.Key.ToUpper
                Case "SELECCION"
                    If Total_Selec <= 1 Then
                        With griListaCuentaBancaria.Rows(e.Cell.Row.Index)
                            If .Cells("Seleccion").Value Then
                                decSaldoCuenta.Value = .Cells("SaldoInicial").Value
                                .Appearance.BackColor = Color.LightSteelBlue
                                .Fixed = True
                            Else
                                .Appearance.BackColor = Color.White
                                .Fixed = False
                            End If
                        End With
                    End If
            End Select
            griListaCuentaBancaria.UpdateData()
        Catch
            Exit Sub
        End Try
    End Sub

    Private Sub griLista_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaCuentaBancaria.CellChange
        griListaCuentaBancaria.UpdateData()
        griListaCuentaBancaria_AfterRowActivate(griListaCuentaBancaria, e)
    End Sub

    Private Sub griListaCuentaBancaria_AfterRowActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaCuentaBancaria.AfterCellActivate
        With griListaCuentaBancaria.ActiveRow
            griListaCuentaBancaria.UpdateData()
            If .Cells("Seleccion").Value = True Then
                oeCajaMonto.IdCuentaBancaria = .Cells("Id").Value.ToString
                txtCuentaBancaria.Text = .Cells("NumeroCuenta").Value.ToString.Trim
                decSaldoCuenta.Value = .Cells("SaldoInicial").Value
                decMonto_ValueChanged(decMonto, e)
            End If
        End With
    End Sub

    Private Sub griMontoCaja_ClickCellButton(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griMontoCaja.ClickCellButton
        Try
            If griMontoCaja.ActiveRow.Cells("IdCuentaBancaria").Value.ToString.Length > 0 Then
                Dim formulario As frm_CuentaBancaria
                formulario = frm_CuentaBancaria
                If formulario.InformacionCuentaBancaria(griMontoCaja.ActiveRow.Cells("IdCuentaBancaria").Value) Then
                    formulario.ShowDialog()
                    Consultar(True)
                End If
            Else
                Throw New Exception(Me.Text & ": Numero de cuenta no se encuentra asignada a una cuenta bancaria")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub LlenarUsuario(ByVal leCajaUsuario As List(Of e_CajaUsuario))
        With griUsuarioCaja
            .DataSource = oeCaja.leCajaUsuario

            .DisplayLayout.Bands(0).Columns("Id").Hidden = True
            .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
            .DisplayLayout.Bands(0).Columns("ApellidoPaterno").Hidden = True
            .DisplayLayout.Bands(0).Columns("ApellidoMaterno").Hidden = True
            .DisplayLayout.Bands(0).Columns("Nombre").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdCentro").Hidden = True
            .DisplayLayout.Bands(0).Columns("NombreCompleto").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        End With
    End Sub

    Private Sub griTrabajador_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griTrabajador.CellChange
        Try
            With griTrabajador
                If e.Cell.Row.Index > -1 Then
                    .UpdateData()
                    If .ActiveRow.Cells("Selec").Activated Then

                        oeCaja.Modificado = True

                        Dim oeCajaUsuario As New e_CajaUsuario
                        'leOcupacionTrabajador = New List(Of e_OcupacionTrabajador)
                        leCajaUsuario = oeCaja.leCajaUsuario

                        oeCajaUsuario.IdTrabajador = .ActiveRow.Cells("Id").Value

                        If Not leCajaUsuario.Contains(oeCajaUsuario) Then
                            If .ActiveRow.Cells("Selec").Value Then
                                oeCajaUsuario.IdCaja = oeCaja.Id
                                oeCajaUsuario.IdTrabajador = .ActiveRow.Cells("Id").Value
                                oeCajaUsuario.ApellidoPaterno = .ActiveRow.Cells("ApellidoPaterno").Value
                                oeCajaUsuario.ApellidoMaterno = .ActiveRow.Cells("ApellidoMaterno").Value
                                oeCajaUsuario.Nombre = .ActiveRow.Cells("Nombre").Value
                                oeCajaUsuario.Codigo = .ActiveRow.Cells("Codigo").Value
                                leCajaUsuario.Add(oeCajaUsuario)
                                If griUsuarioCaja.Rows.Count < 1 Then
                                    LlenarUsuario(leCajaUsuario)
                                End If

                            End If
                        Else
                            oeCajaUsuario = leCajaUsuario.Item(leCajaUsuario.IndexOf(oeCajaUsuario))
                            If .ActiveRow.Cells("Selec").Value Then
                                If oeCajaUsuario.TipoOperacion = "E" Then
                                    oeCajaUsuario.TipoOperacion = ""
                                    For Each fila As UltraWinGrid.UltraGridRow In griUsuarioCaja.Rows
                                        If fila.Cells("IdTrabajador").Value = oeCajaUsuario.IdTrabajador Then
                                            fila.Hidden = False
                                            Exit For
                                        End If
                                    Next
                                Else
                                    Throw New Exception("El Trabajador: " & .ActiveRow.Cells("NombreCompleto").Value & " ya esta Asignado")
                                End If

                            Else
                                If oeCajaUsuario.Id <> "" Then
                                    oeCajaUsuario.TipoOperacion = "E"
                                    For Each fila As UltraWinGrid.UltraGridRow In griUsuarioCaja.Rows
                                        If fila.Cells("IdTrabajador").Value = oeCajaUsuario.IdTrabajador Then
                                            fila.Hidden = True
                                            Exit For
                                        End If
                                    Next
                                Else
                                    leCajaUsuario.Remove(oeCajaUsuario)
                                End If

                            End If

                        End If

                    End If
                End If
            End With
            griUsuarioCaja.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griListaCaja_AfterRowActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaCaja.AfterRowActivate
        If griListaCaja.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
            _id = griListaCaja.ActiveRow.Cells("Id").Value.ToString
            'ListarMonto(True)
        ElseIf griListaCaja.ActiveRow.Cells("Usuarios").Value.ToString.Length > 0 Then
            Editar()
        End If
    End Sub

#End Region

#Region "Métodos Caja"

    Private Function GuardarCaja() As Boolean
        Try
            oeCaja.IdCentro = cboCentro.Value
            oeCaja.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olCaja.Guardar(oeCaja) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, tcCaja, 2)
                LlenaCombos()
                MenuMovimiento.Visible = True
                MostrarTabs(0, ficMovimiento)
                LimpiaGrid(griUsuarioCaja, ogdUsuarioCaja)
                Consultar(True)
                griListaCaja.Focus()
                verActivo.Visible = False
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Function

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("codigo") Then
            txtCodigo.Focus()
        End If
        If excepcion.Contains("nombre") Then
            txtNombre.Focus()
        End If
        If excepcion.Contains("abreviatura") Then
            txtAbreviatura.Focus()
        End If
    End Sub

    Private Sub Inicializar()
        txtCodigo.Text = String.Empty
        txtAbreviatura.Text = String.Empty
        txtNombre.Text = String.Empty
        verActivo.Checked = True
        cboCentro.SelectedIndex = -1
        oeCaja.UsuarioCreacion = gUsuarioSGI.Id
        Me.spcCuentaBancaria.Panel2Collapsed = True

        ListarTrabajadores()

    End Sub

    Private Sub ListarTrabajadores()
        Try
            oeTrabajador = New e_Trabajador
            olTrabajador = New l_Trabajador
            With griTrabajador
                .ResetDisplayLayout()
                oeTrabajador.Activo = True
                Dim _leTrabAux = olTrabajador.Listar(oeTrabajador)
                Dim _leTrab = From le In _leTrabAux _
                              Select le.Id, le.Codigo, le.oePersona.Dni _
                              , le.oePersona.NombreCompleto, Ocupacion = le.oeOcupacion.Nombre _
                              , Area = le.oeArea.Nombre, le.oePersona.ApellidoPaterno _
                              , le.oePersona.ApellidoMaterno, le.oePersona.Nombre
                .DataSource = _leTrab.ToList

                .DisplayLayout.Bands(0).Columns.Add("Selec", "Seleccionar")
                .DisplayLayout.Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
                .DisplayLayout.Bands(0).Columns("Selec").DefaultCellValue = False
                .DisplayLayout.Bands(0).Columns("Selec").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("Selec").Width = 50

                .DisplayLayout.Bands(0).Columns("ApellidoPaterno").Hidden = True
                .DisplayLayout.Bands(0).Columns("ApellidoMaterno").Hidden = True
                .DisplayLayout.Bands(0).Columns("Nombre").Hidden = True
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Bands(0).Columns("NombreCompleto").Width = 350
                .DisplayLayout.Bands(0).Columns("Dni").Width = 70
                .DisplayLayout.Bands(0).Columns("Ocupacion").Width = 300
                .DisplayLayout.Override.FilterUIProvider = filtro1
            End With
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griUsuarioCaja.Focus()
    End Sub

    Private Sub MostrarUsuarios()
        Try
            If oeCaja.leCajaUsuario.Count > 0 Then
                With griUsuarioCaja
                    .DataSource = oeCaja.leCajaUsuario
                    .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                    .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                    .DisplayLayout.Bands(0).Columns("ApellidoPaterno").Hidden = True
                    .DisplayLayout.Bands(0).Columns("ApellidoMaterno").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Nombre").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdCentro").Hidden = True
                    .DisplayLayout.Bands(0).Columns("NombreCompleto").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit

                End With

                For Each oe As e_CajaUsuario In oeCaja.leCajaUsuario
                    For Each Fila As UltraWinGrid.UltraGridRow In griTrabajador.Rows
                        If Fila.Cells("Id").Value = oe.IdTrabajador And oe.Activo Then
                            Fila.Cells("Selec").Value = True
                            Exit For
                        End If
                    Next
                Next
                griTrabajador.UpdateData()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MostrarCaja()
        Try
            If griListaCaja.ActiveRow.Cells("ID").Value.ToString.Length > 0 Then
                Inicializar()
                verActivo.Visible = True
                oeCaja.Id = griListaCaja.ActiveRow.Cells("Id").Value.ToString
                oeCaja = olCaja.Obtener(oeCaja)
                txtCodigo.Text = oeCaja.Codigo
                txtNombre.Text = oeCaja.Nombre
                txtAbreviatura.Text = oeCaja.Abreviatura
                cboCentro.Value = oeCaja.IdCentro
                MostrarUsuarios()
                MostrarTabs(1, tcCaja, 1)
                MenuMovimiento.Visible = False
                MostrarTabs(1, ficMovimiento, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeCaja = New e_Caja
            oeCaja.Activo = True
            With griListaCaja
                oeCaja.Activo = Activo
                .DataSource = olCaja.Listar(oeCaja)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                '.DisplayLayout.Bands(0).Columns("Modificado").Hidden = True
                '.DisplayLayout.Bands(0).Columns("TipoOperacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdCentro").Hidden = True

                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                    .Rows.Item(0).Activated = True
                End If
            End With
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griListaCaja.Focus()
    End Sub

    Private Sub ListarCuentaBancaria(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeCuentaBancaria = New e_CuentaBancaria
            With griListaCuentaBancaria
                oeCuentaBancaria.Activo = Activo
                .DataSource = olCuentaBancaria.Listar(oeCuentaBancaria)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                '.DisplayLayout.Bands(0).Columns("Modificado").Hidden = True
                '.DisplayLayout.Bands(0).Columns("TipoOperacion").Hidden = True
                '.DisplayLayout.Bands(0).Columns("IdCuentaContable").Hidden = True
            End With

        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griListaCuentaBancaria.Focus()
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_Caja_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griListaCaja_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griListaCaja.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro Cajas"

    Private Sub AsociarMenu()
        griListaCaja.ContextMenuStrip = MenuContextual1
    End Sub

    Private Sub InsertarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertarToolStripMenuItem.Click
        Nuevo()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        Editar()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar()
    End Sub

    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        MenuContextual1.Items("InsertarToolStripMenuItem").Visible = True
        If griListaCaja.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarToolStripMenuItem.Click
        ListarMovimiento()
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem.Click
        NuevoMovimiento()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem.Click
        EditarMovimiento()
    End Sub

    Private Sub QuitarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarToolStripMenuItem.Click
        EliminarMovimiento()
    End Sub

    Private Sub mcMovimientosCaja_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mcMovimientosCaja.Opening
        mcMovimientosCaja.Items(0).Visible = True
        mcMovimientosCaja.Items(1).Visible = True
        If griMontoCaja.Selected.Rows.Count > 0 Then
            mcMovimientosCaja.Items(2).Visible = True
            mcMovimientosCaja.Items(3).Visible = True
        Else
            mcMovimientosCaja.Items(2).Visible = False
            mcMovimientosCaja.Items(3).Visible = False
        End If
    End Sub

#End Region

End Class