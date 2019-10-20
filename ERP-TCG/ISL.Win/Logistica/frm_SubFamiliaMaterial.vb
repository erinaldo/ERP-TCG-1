'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF

Public Class frm_SubFamiliaMaterial

#Region "Inicializacion de Formulario"
    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_SubFamiliaMaterial = Nothing
    Private Shared Operacion As String
    ''' Instancia unica de Formulario: frm_SubFamiliaMaterial

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_SubFamiliaMaterial
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function
#End Region

#Region "Declaración de Variables"

    Dim olSubFamiliaMaterial As New l_SubFamiliaMaterial
    Dim oeSubFamiliaMaterial As New e_SubFamiliaMaterial
    Dim olFamiliaMaterial As New l_FamiliaMaterial
    Dim oeFamiliaMaterial As New e_FamiliaMaterial
    Dim _ingresando_datos As Boolean = False
    Dim Estado As String

    Private oeCCSFamMat As New e_CtaCtbleSubFamiliaMat
    Private olCCSFamMat As New l_CtaCtbleSubFamiliaMat
    Private loCCSFamMat As New List(Of e_CtaCtbleSubFamiliaMat)

    Private oeCtaCtble As New e_CuentaContable
    Private olCtaCtble As New l_CuentaContable
    Private loCtaCtble As New List(Of e_CuentaContable)

    Private oeItemGasto As New e_ItemGasto
    Private olItemGasto As New l_ItemGasto
    Private loItemGasto As New List(Of e_ItemGasto)

    Private loCtaCtbleExi As New List(Of e_CuentaContable)
    Private loCtaCtbleCmp As New List(Of e_CuentaContable)
    Private loCtaCtbleCsm As New List(Of e_CuentaContable)

    Private oeCuenta As New e_CuentaContable

#End Region

#Region "Eventos"

    Private Sub frm_SubFamiliaMaterial_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        Tiempo1.Enabled = False
        MostrarTabs(0, ficSubFamiliaMaterial)
        griSubFamiliaMaterial.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        griSubFamiliaMaterial.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        LlenarCombos()
        InicializaTiempo()
    End Sub

    Private Sub frm_SubFamiliaMaterial_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_SubFamiliaMaterial_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        txtCodigo.SelectAll()
    End Sub

    Private Sub txtNombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.GotFocus
        txtNombre.SelectAll()
    End Sub

    Private Sub txtAbreviatura_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbreviatura.GotFocus
        txtAbreviatura.SelectAll()
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        TeclaPulsada(e)
        oeSubFamiliaMaterial.Modificado = True
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        TeclaPulsada(e)
        oeSubFamiliaMaterial.Modificado = True
    End Sub

    Private Sub txtAbreviatura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAbreviatura.KeyDown
        TeclaPulsada(e)
        oeSubFamiliaMaterial.Modificado = True
    End Sub

    Private Sub chkActivo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles verActivo.KeyDown
        TeclaPulsada(e)
        oeSubFamiliaMaterial.Modificado = True
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        txtCodigo.Text = LTrim(txtCodigo.Text)
        oeSubFamiliaMaterial.Codigo = txtCodigo.Text.Trim
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        txtNombre.Text = LTrim(txtNombre.Text)
        oeSubFamiliaMaterial.Nombre = txtNombre.Text.Trim
    End Sub

    Private Sub txtAbreviatura_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAbreviatura.ValueChanged
        txtAbreviatura.Text = LTrim(txtAbreviatura.Text)
        oeSubFamiliaMaterial.Abreviatura = txtAbreviatura.Text.Trim
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeSubFamiliaMaterial.Activo = verActivo.Checked
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        oeSubFamiliaMaterial.Modificado = True
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        oeSubFamiliaMaterial.Modificado = True
    End Sub

    Private Sub txtAbreviatura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAbreviatura.KeyPress
        oeSubFamiliaMaterial.Modificado = True
    End Sub

    Private Sub verActivo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles verActivo.KeyPress
        oeSubFamiliaMaterial.Modificado = True
    End Sub

    Private Sub verActivo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivo.Click
        oeSubFamiliaMaterial.Modificado = True
    End Sub

    Private Sub cboFamiliaMaterial_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFamiliaMaterial.Click
        oeSubFamiliaMaterial.Modificado = True
    End Sub

    Private Sub cboFamiliaMaterial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboFamiliaMaterial.KeyPress
        oeSubFamiliaMaterial.Modificado = True
    End Sub

    Private Sub griSubFamiliaMaterial_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griSubFamiliaMaterial.InitializeLayout
        agrLista.Text = "Total de SubFamilias de Material: " & griSubFamiliaMaterial.Rows.Count.ToString
    End Sub

    Private Sub griSubFamiliaMaterial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griSubFamiliaMaterial.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub griSubFamiliaMaterial_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griSubFamiliaMaterial.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griSubFamiliaMaterial_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griSubFamiliaMaterial.DoubleClick
        If griSubFamiliaMaterial.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub cboFamiliaMaterial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboFamiliaMaterial.KeyDown
        TeclaPulsada(e)
        oeSubFamiliaMaterial.Modificado = True
    End Sub

    Private Sub cboFamiliaMaterial_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFamiliaMaterial.ValueChanged
        oeSubFamiliaMaterial.Modificado = True
        oeSubFamiliaMaterial.IdFamilia = cboFamiliaMaterial.Value
    End Sub

    Private Sub cboCtaCtble_ValueChanged(sender As Object, e As EventArgs) Handles cboCtaCtble.ValueChanged
        Try
            If cboCtaCtble.SelectedIndex <> -1 Then
                oeCuenta = New e_CuentaContable
                oeCuenta.Equivale = 1
                oeCuenta.Id = cboCtaCtble.Value
                oeCuenta = loCtaCtble.Item(loCtaCtble.IndexOf(oeCuenta))
                Me.txtCuenta.Value = oeCuenta.Nombre
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAgregarCC_Click(sender As Object, e As EventArgs) Handles btnAgregarCC.Click
        Try
            AgregarCC()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnQuitarCC_Click(sender As Object, e As EventArgs) Handles btnQuitarCC.Click
        Try
            If griCtaSubFam.Selected.Rows.Count > 0 Then QuitarCC()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboCtaCompra_ValueChanged(sender As Object, e As EventArgs) Handles cboCtaCompra.ValueChanged
        Try
            If cboCtaCompra.SelectedIndex <> -1 Then
                Dim oeCtaCmp As New e_CuentaContable
                oeCtaCmp.Equivale = 1
                oeCtaCmp.Id = cboCtaCompra.Value
                oeCtaCmp = loCtaCtbleCmp.Item(loCtaCtbleCmp.IndexOf(oeCtaCmp))
                Me.txtCtaCompra.Value = oeCtaCmp.Nombre
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboCtaConsumo_ValueChanged(sender As Object, e As EventArgs) Handles cboCtaConsumo.ValueChanged
        Try
            If cboCtaConsumo.SelectedIndex <> -1 Then
                Dim oeCtaCsm As New e_CuentaContable
                oeCtaCsm.Equivale = 1
                oeCtaCsm.Id = cboCtaConsumo.Value
                oeCtaCsm = loCtaCtbleCsm.Item(loCtaCtbleCsm.IndexOf(oeCtaCsm))
                Me.txtCtaConsumo.Value = oeCtaCsm.Nombre
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griSubFamiliaMaterial.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        oeSubFamiliaMaterial.TipoOperacion = "I"
        MostrarTabs(1, ficSubFamiliaMaterial, 1)
        Inicializar()
        txtCodigo.Focus()
        Operacion = "Nuevo"
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        Mostrar()
        oeSubFamiliaMaterial.TipoOperacion = "A"
        txtCodigo.Focus()
        Operacion = "Editar"
        MyBase.Editar()
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarRegistro() Then
                ActualizarListaPublica("MATERIALSUBFAMILIA")
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficSubFamiliaMaterial, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeSubFamiliaMaterial.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarRegistro() Then
                            MostrarTabs(0, ficSubFamiliaMaterial, 2)
                            _ingresando_datos = False
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficSubFamiliaMaterial, 1)
                        End If

                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficSubFamiliaMaterial, 2)
                        _ingresando_datos = False
                        Operacion = "Inicializa"
                        MyBase.Consultar(True)

                End Select
            Else
                MostrarTabs(0, ficSubFamiliaMaterial, 2)
                _ingresando_datos = False
                Operacion = "Inicializa"
                MyBase.Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try

            oeSubFamiliaMaterial = New e_SubFamiliaMaterial
            If ValidarGrilla(griSubFamiliaMaterial, "SubFamiliaMaterial") Then
                oeSubFamiliaMaterial.Id = griSubFamiliaMaterial.ActiveRow.Cells("ID").Value
                oeSubFamiliaMaterial = olSubFamiliaMaterial.Obtener(oeSubFamiliaMaterial)
                If oeSubFamiliaMaterial.Activo Then
                    If MessageBox.Show("Desea eliminar la SubFamilia de Material: " & _
                             griSubFamiliaMaterial.ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        oeSubFamiliaMaterial.TipoOperacion = "E"
                        olSubFamiliaMaterial.Eliminar(oeSubFamiliaMaterial)
                        Consultar(True)
                    End If
                Else
                    Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                End If
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try

            If griSubFamiliaMaterial.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griSubFamiliaMaterial)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Metodos"

    Private Sub Inicializar()
        oeFamiliaMaterial = New e_FamiliaMaterial
        cboFamiliaMaterial.SelectedIndex = -1
        txtId.Text = String.Empty
        txtCodigo.Text = String.Empty
        txtNombre.Text = String.Empty
        txtAbreviatura.Text = String.Empty
        txtCuenta.Text = String.Empty
        txtCtaCompra.Text = String.Empty
        txtCtaConsumo.Text = String.Empty
        verActivo.Checked = True
        cboCtaCtble.SelectedIndex = -1
        cboCtaCompra.SelectedIndex = -1
        cboCtaConsumo.SelectedIndex = -1
        cboItemGasto.SelectedIndex = -1
        oeCuenta = New e_CuentaContable
        loCCSFamMat = New List(Of e_CtaCtbleSubFamiliaMat)
        griCtaSubFam.DataSource = loCCSFamMat
        AsociarMenu()
    End Sub

    Private Sub LlenarCombos()
        Try
            oeFamiliaMaterial.TipoOperacion = ""
            oeFamiliaMaterial.Activo = True
            LlenarComboMaestro(cboFamiliaMaterial, olFamiliaMaterial.Listar(oeFamiliaMaterial), -1)

            loCtaCtble = New List(Of e_CuentaContable)

            oeCtaCtble = New e_CuentaContable
            oeCtaCtble.TipoOperacion = "M"
            oeCtaCtble.Ejercicio = ObtenerFechaServidor.Year
            loCtaCtble.AddRange(olCtaCtble.Listar(oeCtaCtble))

            loCtaCtbleExi.AddRange(loCtaCtble.Where(Function(item) item.Tesoreria = 0).ToList)
            LlenarCombo(cboCtaCtble, "Cuenta", loCtaCtbleExi, -1)

            loCtaCtbleCmp = New List(Of e_CuentaContable)
            loCtaCtbleCmp.AddRange(loCtaCtble.Where(Function(item) item.Tesoreria = 1).ToList)
            LlenarCombo(cboCtaCompra, "Cuenta", loCtaCtbleCmp, -1)

            loCtaCtbleCsm = New List(Of e_CuentaContable)
            loCtaCtbleCsm.AddRange(loCtaCtble.Where(Function(item) item.Tesoreria = 2).ToList)
            LlenarCombo(cboCtaConsumo, "Cuenta", loCtaCtbleCsm, -1)

            oeItemGasto = New e_ItemGasto
            oeItemGasto.TipoOperacion = "W"
            oeItemGasto.Activo = True
            oeItemGasto.Ejercicio = oeCtaCtble.Ejercicio
            loItemGasto.AddRange(olItemGasto.Listar(oeItemGasto))
            LlenarCombo(cboItemGasto, "Nombre", loItemGasto, -1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try     
    End Sub

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

    Private Sub Mostrar()
        Try
            If griSubFamiliaMaterial.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeSubFamiliaMaterial.Id = griSubFamiliaMaterial.ActiveRow.Cells("Id").Value.ToString
                oeSubFamiliaMaterial = olSubFamiliaMaterial.Obtener(oeSubFamiliaMaterial)
                txtId.Text = oeSubFamiliaMaterial.Id
                txtCodigo.Text = oeSubFamiliaMaterial.Codigo
                txtNombre.Text = oeSubFamiliaMaterial.Nombre
                txtAbreviatura.Text = oeSubFamiliaMaterial.Abreviatura
                verActivo.Checked = oeSubFamiliaMaterial.Activo
                cboFamiliaMaterial.Value = oeSubFamiliaMaterial.IdFamilia
                oeCCSFamMat = New e_CtaCtbleSubFamiliaMat
                oeCCSFamMat.IdSubFamilia = oeSubFamiliaMaterial.Id
                loCCSFamMat.AddRange(olCCSFamMat.Listar(oeCCSFamMat))
                griCtaSubFam.DataSource = loCCSFamMat
                MostrarTabs(1, ficSubFamiliaMaterial, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function GuardarRegistro() As Boolean
        Try
            oeSubFamiliaMaterial.UsuarioCreacion = gUsuarioSGI.Id
            oeSubFamiliaMaterial.loCtaCtbleSubFam.AddRange(loCCSFamMat)
            oeSubFamiliaMaterial.PrefijoID = gs_PrefijoIdSucursal '@0001
            If Not olSubFamiliaMaterial.Guardar(oeSubFamiliaMaterial) Then
                Return False
            End If
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
            MostrarTabs(0, ficSubFamiliaMaterial, 2)
            Consultar(True)
            griSubFamiliaMaterial.Focus()
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Function

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            If Activo Then
                Estado = " Activo"
            Else
                Estado = " Inactivo"
            End If
            Me.Cursor = Cursors.WaitCursor
            oeSubFamiliaMaterial = New e_SubFamiliaMaterial
            oeSubFamiliaMaterial.Activo = Activo
            griSubFamiliaMaterial.DataSource = olSubFamiliaMaterial.Listar(oeSubFamiliaMaterial)
            With griSubFamiliaMaterial
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Codigo").Hidden = False
                .DisplayLayout.Bands(0).Columns("Nombre").Hidden = False
                .DisplayLayout.Bands(0).Columns("Abreviatura").Hidden = True
                .DisplayLayout.Bands(0).Columns("Modificado").Hidden = True
                .DisplayLayout.Bands(0).Columns("TipoOperacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("Familia").Hidden = False
                .DisplayLayout.Bands(0).Columns("IdFamilia").Hidden = True
                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If

            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub AgregarCC()
        Try
            If ValidaCuenta() Then
                oeCCSFamMat = New e_CtaCtbleSubFamiliaMat
                With oeCCSFamMat
                    .TipoOperacion = "I"
                    .IdCtaCtbleExistencias = Me.cboCtaCtble.Value
                    .CtaCtbleExistencias = Me.txtCuenta.Text
                    .NroCtaCtbleExistencias = Me.cboCtaCtble.Text
                    .IdItemGasto = Me.cboItemGasto.Value
                    .ItemGasto = Me.cboItemGasto.Text
                    .IdCtaCtbleCompras = Me.cboCtaCompra.Value
                    .IdCtaCtbleConsumo = Me.cboCtaConsumo.Value
                    .CtaCtbleCompra = Me.cboCtaCompra.Text
                    .CtaCtbleConsumo = Me.cboCtaConsumo.Text
                    .Ejercicio = ObtenerFechaServidor().Year
                End With
                loCCSFamMat.Add(oeCCSFamMat)
                griCtaSubFam.DataBind()
            Else
                Throw New Exception("Ya Existe Cuenta para el Periodo: " & oeCuenta.Ejercicio)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarCC()
        Try
            oeCCSFamMat = New e_CtaCtbleSubFamiliaMat
            oeCCSFamMat = griCtaSubFam.ActiveRow.ListObject
            If oeCCSFamMat.TipoOperacion = "I" Then
                loCCSFamMat.Remove(oeCCSFamMat)
            Else
                oeCCSFamMat.TipoOperacion = "E"
                griCtaSubFam.ActiveRow.Hidden = True
            End If
            griCtaSubFam.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ValidaCuenta() As Boolean
        Try
            If cboCtaCompra.SelectedIndex = -1 Then Throw New Exception("Seleccione Cuenta Contable")
            If loCCSFamMat.Count > 0 Then
                For Each ctactbsubfam As e_CtaCtbleSubFamiliaMat In loCCSFamMat.Where(Function(item) item.TipoOperacion <> "E")
                    If ctactbsubfam.Ejercicio = oeCuenta.Ejercicio Then
                        Return False
                    End If
                Next
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_SubFamiliaAlmacen_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griSubFamiliaMaterial_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griSubFamiliaMaterial.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro de Sub Familia de Material"

    Private Sub AsociarMenu()
        griSubFamiliaMaterial.ContextMenuStrip = MenuContextual1
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
        If griSubFamiliaMaterial.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region
    
End Class

