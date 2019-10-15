'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_Material

#Region "Declaración de Variables"

    Dim oeMaterial As e_Material, olMaterial As l_Material
    Dim oeFamiliaMaterial As e_FamiliaMaterial, olFamiliaMaterial As l_FamiliaMaterial
    Dim oeSubFamiliaMaterial As e_SubFamiliaMaterial, olSubFamiliaMaterial As l_SubFamiliaMaterial
    Dim oeUnidadMedida As e_UnidadMedida, olUnidadMedida As l_UnidadMedida
    Dim oeTipoUnidadMedida As e_TipoUnidadMedida, olTipoUnidadMedida As l_TipoUnidadMedida
    Dim oeTipoMaterial As e_TipoMaterial, olTipoMaterial As l_TipoMaterial
    Dim oeCodBarras As e_CodigoBarraMaterial, olCodBarras As l_CodigoBarraMaterial
    'Dim oeMarca As e_Marca, olMarca As l_Marca

    Dim MaterialCodBarras As New List(Of e_CodigoBarraMaterial)

    Dim _ingresando_datos As Boolean = False
    Dim Estado As String

    Dim oeAlmacen As e_Almacen, olAlmacen As l_Almacen
    Dim lstAlmacen As List(Of e_Almacen)
    
    'objetos del Listado
    Dim lstTipo As List(Of e_TipoMaterial)
    Dim lstFamilia As List(Of e_FamiliaMaterial)
    Dim lstSubFamilia As List(Of e_SubFamiliaMaterial)
    Dim oeTipo As e_TipoMaterial

    Dim oeCaracteristicaEspecial As e_CaracteristicaEspecial, olCaracteristicaEspecial As l_CaracteristicaEspecial
    Dim loCaracteristicaEspecial As List(Of e_CaracteristicaEspecial)

    Dim oeCaracteristicaMaterial As e_CaracteristicaMaterial, olCaracteristicaMaterial As l_CaracteristicaMaterial
    Dim loCaracteristicaMaterial As List(Of e_CaracteristicaMaterial)

    Public MaterialMerma As String = ""

    Private bandNeu As Boolean = False
    Private oeMaterial_DisenoNeu As e_Material_DisenoNeu
    Private _TipoOpe As Integer

    Dim olCombo As l_Combo, oeCombo As e_Combo
    Dim oeMaterialAlmacen As e_MaterialAlmacen, olMaterialAlmacen As l_MaterialAlmacen
    Dim lstMaterialAlmacenes As List(Of e_MaterialAlmacen)

    Dim olTrabajadorSeguridad As l_TrabajadorSeguridad

#End Region

#Region "Inicializacion"

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Shared Instancia As frm_Material = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Instancia = New frm_Material()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Eventos"

    Private Sub frm_Material_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            MostrarTabs(0, ficMaterial)
            InicializarLogicas()
            griMaterial.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
            griMaterial.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
            r_CargarCombos()
            InicializaTiempo()
            If MaterialMerma <> "" Then
                Me.cboUnidadMedida.Visible = 0
                Me.txtGlosa.Visible = 0
                Me.txtMedida.Visible = 0
                Me.decPeso.Visible = 0
                Me.txtSerial.Visible = 0
                Me.verIgv.Visible = 0
                Me.txtCodigoBarra.Visible = 0
                btnAgregarCodigo.Visible = 0
                btnQuitarCodigo.Visible = 0
                Me.cbAlmacen.Visible = False
                Me.griListaCodBarras.Visible = False
                cboCaracteristicaEspecial.Visible = 0
                btnAgrCar.Visible = 0
                btnQuitCarac.Visible = 0
                griListaCodBarras.Visible = 0
                griCaracteristicaMaterial.Visible = 0
                'Me.cboMarca.Visible = False
                Me.verActivo.Visible = 0
                Me.txtCodigo.Visible = 0
                Me.Etiqueta14.Visible = 0
                Me.Etiqueta11.Visible = 0
                Me.Etiqueta15.Visible = 0
                Me.Etiqueta3.Visible = 0
                Me.Etiqueta12.Visible = 0
                Me.Etiqueta1.Visible = 0
                Me.Etiqueta9.Visible = 0
                Me.tcDetalle.Visible = 0
                Me.cmbMarca.Visible = 0
                Me.cmbModelo.Visible = 0
                Me.Etiqueta26.Visible = 0
                Me.Etiqueta27.Visible = 0
                Me.chkContabilizable.Visible = 0
                oeMaterial = New e_Material
                loCaracteristicaMaterial = New List(Of e_CaracteristicaMaterial)
                lstMaterialAlmacenes = New List(Of e_MaterialAlmacen)
                'Me.chkAsignarAlmacen.Visible = 0
                Me.Etiqueta10.Visible = 0
                Me.btnGuardarProveedor.Visible = 1
                Me.ficMaterial.Tabs(1).Selected = True
                Me.ficMaterial.Tabs(0).Enabled = False
                Me.ficMaterial.Tabs(1).Enabled = True
                oeMaterial.IdUnidadMedida = "1PY000000011"
                oeMaterial.TipoOperacion = "I"
                oeMaterial.Activo = 1
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Material_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_Material_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case Operacion
            Case "Nuevo", "Editar"
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

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        TeclaPulsada(e)
        oeMaterial.Modificado = True
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        oeMaterial.Modificado = True
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        txtCodigo.Text = LTrim(txtCodigo.Text)
        oeMaterial.Codigo = txtCodigo.Text.Trim
    End Sub

    Private Sub txtNombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.GotFocus
        txtNombre.SelectAll()
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        oeMaterial.Modificado = True
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        oeMaterial.Modificado = True
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        txtNombre.Text = LTrim(txtNombre.Text)
        oeMaterial.Nombre = txtNombre.Text
    End Sub

    Private Sub numStockMaximo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        oeMaterial.Modificado = True
    End Sub

    Private Sub numStockMaximo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        oeMaterial.Modificado = True
    End Sub

    Private Sub numStockMinimo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        TeclaPulsada(e)
        oeMaterial.Modificado = True
    End Sub

    Private Sub numStockMinimo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        oeMaterial.Modificado = True
    End Sub

    Private Sub cboFamilia_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFamilia.Click
        oeMaterial.Modificado = True
    End Sub

    Private Sub cboItemGasto_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        oeMaterial.Modificado = True
    End Sub

    Private Sub cboFamilia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboFamilia.KeyDown
        TeclaPulsada(e)
        oeMaterial.Modificado = True
    End Sub

    Private Sub cboFamilia_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFamilia.ValueChanged
        Try
            oeSubFamiliaMaterial = New e_SubFamiliaMaterial
            oeSubFamiliaMaterial.IdFamilia = cboFamilia.Value
            oeSubFamiliaMaterial.Activo = True
            LimpiaCombos(cboSubFamilia)
            LlenarComboMaestro(cboSubFamilia, olSubFamiliaMaterial.Listar(oeSubFamiliaMaterial), -1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboSubFamilia_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSubFamilia.Click
        oeMaterial.Modificado = True
    End Sub

    Private Sub cboSubFamilia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSubFamilia.KeyDown
        TeclaPulsada(e)
        oeMaterial.Modificado = True
    End Sub

    Private Sub cboSubFamilia_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSubFamilia.ValueChanged
        Try
            oeMaterial.IdSubFamilia = cboSubFamilia.Value
            If cboSubFamilia.Text.Contains("LLANTA") Then
                txtNombre.Enabled = False
                bandNeu = True
                mensajeEmergente.Confirmacion("Haga Doble Click Sobre la Caja de Texto de Nombre de Material para Ingresar Datos Adicionales", True)
                'Select Case Operacion
                '    Case "Nuevo"
                '        _TipoOpe = 1
                '    Case "Editar"
                '        oeMaterial_DisenoNeu.Material = txtNombre.Text.Trim
                '        If oeMaterial_DisenoNeu.Id <> "" Then
                '            _TipoOpe = 1
                '        Else
                '            If oeMaterial_DisenoNeu.IdDisenoNeumatico <> "" Then
                '                _TipoOpe = 1
                '            Else
                '                _TipoOpe = 2
                '            End If
                '        End If
                'End Select
                EvaluaOperacion()
            Else
                txtNombre.Enabled = True
                bandNeu = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTipoUnidadMedida_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipoUnidadMedida.Click
        oeMaterial.Modificado = True
    End Sub

    Private Sub cboTipoUnidadMedida_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboTipoUnidadMedida.KeyDown
        TeclaPulsada(e)
        oeMaterial.Modificado = True
    End Sub

    Private Sub cboTipoUnidadMedida_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboTipoUnidadMedida.KeyPress
        oeMaterial.Modificado = True
    End Sub

    Private Sub cboTipoUnidadMedida_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoUnidadMedida.ValueChanged
        Try
            oeUnidadMedida = New e_UnidadMedida
            oeUnidadMedida.TipoOperacion = ""
            oeUnidadMedida.Activo = True
            oeUnidadMedida.Asignado = True
            oeUnidadMedida.IdTipoUnidadMedida = cboTipoUnidadMedida.Value
            LlenarComboMaestro(cboUnidadMedida, olUnidadMedida.Listar(oeUnidadMedida), -1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboUnidadMedida_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboUnidadMedida.Click
        oeMaterial.Modificado = True
    End Sub

    Private Sub cboUnidadMedida_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboUnidadMedida.KeyDown
        TeclaPulsada(e)
        oeMaterial.Modificado = True
    End Sub

    Private Sub cboUnidadMedida_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboUnidadMedida.KeyPress
        oeMaterial.Modificado = True
    End Sub

    Private Sub cboUnidadMedida_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUnidadMedida.ValueChanged
        oeMaterial.IdUnidadMedida = cboUnidadMedida.Value
    End Sub

    Private Sub cboMarca_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        oeMaterial.Modificado = True
    End Sub

    Private Sub cboMarca_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        TeclaPulsada(e)
        oeMaterial.Modificado = True
    End Sub

    Private Sub txtAbreviatura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        TeclaPulsada(e)
        oeMaterial.Modificado = True
    End Sub

    Private Sub txtAbreviatura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        oeMaterial.Modificado = True
    End Sub

    Private Sub txtSerial_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSerial.GotFocus
        txtSerial.SelectAll()
    End Sub

    Private Sub txtSerial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSerial.KeyDown
        TeclaPulsada(e)
        oeMaterial.Modificado = True
    End Sub

    Private Sub txtSerial_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerial.ValueChanged
        txtSerial.Text = LTrim(txtSerial.Text)
        oeMaterial.Serial = txtSerial.Text
    End Sub

    Private Sub verIgv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verIgv.CheckedChanged
        oeMaterial.AfectoIgv = verIgv.Checked
    End Sub

    Private Sub verIgv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles verIgv.KeyPress
        oeMaterial.Modificado = True
    End Sub

    Private Sub txtGlosa_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGlosa.GotFocus
        txtGlosa.SelectAll()
    End Sub

    Private Sub txtGlosa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGlosa.KeyDown
        TeclaPulsada(e)
        oeMaterial.Modificado = True
    End Sub

    Private Sub txtGlosa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGlosa.KeyPress
        oeMaterial.Modificado = True
    End Sub

    Private Sub txtGlosa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa.ValueChanged
        txtGlosa.Text = LTrim(txtGlosa.Text)
        oeMaterial.Glosa = txtGlosa.Text
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeMaterial.Activo = verActivo.Checked
    End Sub

    Private Sub verActivo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles verActivo.KeyPress
        oeMaterial.Modificado = True
    End Sub

    Private Sub griMaterial_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs)
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griMaterial_DoubleClickRow(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles griMaterial.DoubleClickRow
        Try
            If griMaterial.Selected.Rows.Count > 0 Then Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griMaterial_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

    Private Sub griMaterial_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griMaterial.InitializeLayout
        agrLista.Text = "Total de Materiales: " & e.Layout.Rows.Count & Estado
    End Sub

    Private Sub decMedida_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        TeclaPulsada(e)
        oeMaterial.Modificado = True
    End Sub

    Private Sub decMedida_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        oeMaterial.Modificado = True
    End Sub

    Private Sub decMedida_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        oeMaterial.Peso = decPeso.Value
    End Sub

    Private Sub txtMedida_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMedida.ValueChanged
        oeMaterial.Medida = txtMedida.Text
    End Sub

    Private Sub cboTipoMaterial_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoMaterial.ValueChanged
        Try
            oeMaterial.IdTipoMaterial = cboTipoMaterial.Value
            oeFamiliaMaterial = New e_FamiliaMaterial
            oeFamiliaMaterial.IdTipoMaterial = cboTipoMaterial.Value
            oeFamiliaMaterial.Activo = True
            LimpiaCombos(cboFamilia)
            LimpiaCombos(cboSubFamilia)
            LlenarComboMaestro(cboFamilia, olFamiliaMaterial.Listar(oeFamiliaMaterial), -1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub decPeso_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decPeso.ValueChanged
        oeMaterial.Peso = decPeso.Value
    End Sub

    Private Sub cbTipoMaterial_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoMaterial.ValueChanged
        r_Familia(cbTipoMaterial.Value)
    End Sub

    Private Sub cbFamilia_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFamilia.ValueChanged
        r_SubFamilia(cbFamilia.Value)
    End Sub

    Private Sub etiNombre_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles etiNombre.DoubleClick
        Try
            If bandNeu Then
                EvaluaOperacion()
                Select Case cboSubFamilia.Text
                    Case "LLANTAS APLICACIÓN"
                        oeMaterial_DisenoNeu.EstadoNeu = "APLICACION"
                    Case "LLANTAS REENCAUCHADAS"
                        oeMaterial_DisenoNeu.EstadoNeu = "REENCAUCHADA"
                    Case Else
                        oeMaterial_DisenoNeu.EstadoNeu = "ORIGINAL"
                End Select
                Dim ofrm As frm_Material_DisenoNeu
                ofrm = New frm_Material_DisenoNeu(oeMaterial_DisenoNeu, _TipoOpe)
                If ofrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    txtNombre.Text = oeMDNAux.Material
                    oeMaterial_DisenoNeu.IdDisenoNeumatico = oeMDNAux.IdDisenoNeumatico
                    oeMaterial_DisenoNeu.TipoBanda = oeMDNAux.TipoBanda
                    If Operacion = "Nuevo" Then
                        cboTipoUnidadMedida.Text = "CANTIDAD"
                        cboUnidadMedida.Text = "UNIDAD"
                        'chkAsignarAlmacen.Checked = True
                        cbAlmacen.Text = "ALM. NEUMATICOS"
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try    
    End Sub

    Private Sub btnGuardarProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarProveedor.Click
        Try
            oeMaterial.IdTipoMaterial = "AL"
            Guardar()
            MaterialesPublic = New List(Of e_Combo)
            oeCombo = New e_Combo
            olCombo = New l_Combo
            oeCombo.Nombre = "Materiales"
            MaterialesPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAgrCar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgrCar.Click
        Try
            AgregarCaracteristica()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnQuitCarac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitCarac.Click
        Try
            If griCaracteristicaMaterial.ActiveRow.Selected Then
                Dim oeCarMat As New e_CaracteristicaMaterial
                Dim flag As Boolean = False
                oeCarMat = griCaracteristicaMaterial.ActiveRow.ListObject
                If oeCarMat.TipoOperacion = "I" Then
                    oeCarMat = loCaracteristicaMaterial.Item(loCaracteristicaMaterial.IndexOf(oeCarMat))
                    loCaracteristicaMaterial.Remove(oeCarMat)
                Else
                    oeCarMat = loCaracteristicaMaterial.Item(loCaracteristicaMaterial.IndexOf(oeCarMat))
                    oeCarMat.TipoOperacion = "E"
                    griCaracteristicaMaterial.ActiveRow.Hidden = True
                End If
                griListaCodBarras.DataBind()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAgregarAlmacen_Click(sender As Object, e As EventArgs) Handles btnAgregarAlmacen.Click
        Try
            If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "AGREGAR MATERIAL ALMACEN") Then
                Dim add As Boolean = True
                oeMaterialAlmacen = New e_MaterialAlmacen
                oeMaterialAlmacen.TipoOperacion = "I"
                oeMaterialAlmacen.Id = ""
                oeMaterialAlmacen.IdMaterial = oeMaterial.Id
                oeMaterialAlmacen.IdAlmacen = cbAlmacen.Value
                oeMaterialAlmacen.Almacen = cbAlmacen.Text
                oeMaterialAlmacen.StockMinimo = Me.ndStockMinimo.Value
                oeMaterialAlmacen.StockMaximo = Me.ndStockMaximo.Value
                oeMaterialAlmacen.Zona = Me.txtZona.Text.Trim
                oeMaterialAlmacen.IdZona = Me.txtZona.Text.Trim
                oeMaterialAlmacen.UsuarioCreacion = gUsuarioSGI.Id
                For Each fila As e_MaterialAlmacen In lstMaterialAlmacenes
                    If fila.IdAlmacen = oeMaterialAlmacen.IdAlmacen Then
                        mensajeEmergente.Confirmacion("El almacen ya se agrego a la lista")
                        add = False
                        Exit For
                    End If
                Next
                oeMaterialAlmacen.PrefijoID = gs_PrefijoIdSucursal '@0001
                If add Then
                    lstMaterialAlmacenes.Add(oeMaterialAlmacen)
                    grid_Almacenes.DataBind()
                    cbAlmacen.SelectedIndex = -1
                    Me.ndStockMinimo.Value = 0
                    Me.ndStockMaximo.Value = 0
                    Me.txtZona.Text = String.Empty
                End If
            Else
                Throw New Exception("No Tiene Permisos para Agregar Material a Almacen")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_Almacenes_CellChange(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_Almacenes.CellChange
        grid_Almacenes.UpdateData()
    End Sub

    Private Sub frm_Material_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

#End Region

#Region "Métodos"

    Private Sub InicializarLogicas()
        olMaterial = New l_Material
        olFamiliaMaterial = New l_FamiliaMaterial
        olSubFamiliaMaterial = New l_SubFamiliaMaterial
        olUnidadMedida = New l_UnidadMedida
        olTipoUnidadMedida = New l_TipoUnidadMedida
        olTipoMaterial = New l_TipoMaterial
        olCodBarras = New l_CodigoBarraMaterial
        olAlmacen = New l_Almacen
        olCaracteristicaEspecial = New l_CaracteristicaEspecial
        olCaracteristicaMaterial = New l_CaracteristicaMaterial
        olMaterialAlmacen = New l_MaterialAlmacen
        olTrabajadorSeguridad = New l_TrabajadorSeguridad
    End Sub

    Private Sub r_CargarCombos()
        Try
            r_TipoMaterial()
            llenarComboTipoUnidadMedida()
            llenarTipoMaterial()
            ComboCaracteristicaEspecial()
            ComboAlmacen()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboCaracteristicaEspecial()
        oeCaracteristicaEspecial = New e_CaracteristicaEspecial
        loCaracteristicaEspecial = New List(Of e_CaracteristicaEspecial)
        oeCaracteristicaEspecial.TipoOperacion = ""
        oeCaracteristicaEspecial.Id = ""
        loCaracteristicaEspecial = olCaracteristicaEspecial.Listar(oeCaracteristicaEspecial)
        LlenarComboMaestro(cboCaracteristicaEspecial, loCaracteristicaEspecial, -1)
    End Sub

    Private Sub ComboAlmacen()
        oeAlmacen = New e_Almacen
        lstAlmacen = New List(Of e_Almacen)
        oeAlmacen.TipoOperacion = "F"
        oeAlmacen.Activo = 1
        lstAlmacen = olAlmacen.Listar(oeAlmacen)
        LlenarComboMaestro(cbAlmacen, lstAlmacen, 0)
    End Sub

    Private Sub r_TipoMaterial()
        oeTipo = New e_TipoMaterial
        oeTipo.Id = ""
        oeTipo.Nombre = "TODOS"
        lstTipo = New List(Of e_TipoMaterial)
        lstFamilia = New List(Of e_FamiliaMaterial)
        lstSubFamilia = New List(Of e_SubFamiliaMaterial)
        lstTipo.Add(oeTipo)
        oeTipoMaterial = New e_TipoMaterial
        oeTipoMaterial.TipoOperacion = ""
        oeTipoMaterial.Activo = True
        lstTipo.AddRange(olTipoMaterial.Listar(oeTipoMaterial))
        LlenarComboMaestro(cbTipoMaterial, lstTipo, 0)
    End Sub

    Private Sub r_Familia(ByVal lsIdTipo As String)
        LimpiaCombos(cbFamilia)
        lstFamilia = New List(Of e_FamiliaMaterial)
        oeFamiliaMaterial = New e_FamiliaMaterial
        oeFamiliaMaterial.Id = ""
        oeFamiliaMaterial.Nombre = "TODOS"
        lstFamilia.Add(oeFamiliaMaterial)
        If lsIdTipo <> "" Then
            oeFamiliaMaterial = New e_FamiliaMaterial
            oeFamiliaMaterial.TipoOperacion = ""
            oeFamiliaMaterial.Activo = 1
            oeFamiliaMaterial.IdTipoMaterial = lsIdTipo
            lstFamilia.AddRange(olFamiliaMaterial.Listar(oeFamiliaMaterial))
        End If
        LlenarComboMaestro(cbFamilia, lstFamilia, 0)
    End Sub

    Private Sub r_SubFamilia(ByVal lsIdFamilia As String)
        LimpiaCombos(cbSubFamilia)
        lstSubFamilia = New List(Of e_SubFamiliaMaterial)
        oeSubFamiliaMaterial = New e_SubFamiliaMaterial
        oeSubFamiliaMaterial.Id = ""
        oeSubFamiliaMaterial.Nombre = "TODOS"
        lstSubFamilia.Add(oeSubFamiliaMaterial)
        If lsIdFamilia <> "" Then
            oeSubFamiliaMaterial = New e_SubFamiliaMaterial
            oeSubFamiliaMaterial.TipoOperacion = ""
            oeSubFamiliaMaterial.Activo = 1
            oeSubFamiliaMaterial.IdFamilia = lsIdFamilia
            lstSubFamilia.AddRange(olSubFamiliaMaterial.Listar(oeSubFamiliaMaterial))
        End If
        LlenarComboMaestro(cbSubFamilia, lstSubFamilia, 0)
    End Sub

    Private Sub Inicializar()
        oeMaterial = New e_Material
        txtId.Text = String.Empty
        txtCodigo.Text = String.Empty
        txtNombre.Text = String.Empty
        cboSubFamilia.Enabled = True
        decPeso.Value = 0
        cboTipoUnidadMedida.SelectedIndex = -1
        cboFamilia.SelectedIndex = -1
        cboSubFamilia.SelectedIndex = -1
        MaterialCodBarras = New List(Of e_CodigoBarraMaterial)
        griListaCodBarras.DataSource = MaterialCodBarras
        loCaracteristicaMaterial = New List(Of e_CaracteristicaMaterial)
        griCaracteristicaMaterial.DataSource = loCaracteristicaMaterial
        cboUnidadMedida.SelectedIndex = -1
        cboTipoMaterial.SelectedIndex = -1
        txtSerial.Text = String.Empty
        txtGlosa.Text = String.Empty
        txtCodigoBarra.Text = String.Empty
        lstMaterialAlmacenes = New List(Of e_MaterialAlmacen)
        grid_Almacenes.DataSource = lstMaterialAlmacenes
        verIgv.Checked = True
        verActivo.Checked = True
        chkContabilizable.Checked = False
        cbAlmacen.SelectedIndex = -1
        txtNombre.Enabled = True
        bandNeu = False
        oeMDNAux = New e_Material_DisenoNeu
        oeMaterial_DisenoNeu = New e_Material_DisenoNeu
        verActivoFijo.Checked = False
    End Sub

    Private Sub llenarComboTipoUnidadMedida()
        oeTipoUnidadMedida = New e_TipoUnidadMedida
        oeTipoUnidadMedida.TipoOperacion = ""
        oeTipoUnidadMedida.Activo = True
        LlenarComboMaestro(cboTipoUnidadMedida, olTipoUnidadMedida.Listar(oeTipoUnidadMedida), -1)
    End Sub

    Private Sub llenarTipoMaterial()
        oeTipoMaterial = New e_TipoMaterial
        oeTipoMaterial.TipoOperacion = ""
        oeTipoMaterial.Activo = True
        LlenarComboMaestro(cboTipoMaterial, olTipoMaterial.Listar(oeTipoMaterial), -1)
    End Sub

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("codigo") Then
            txtCodigo.Focus()
        End If
        If excepcion.Contains("nombre") Then
            txtNombre.Focus()
        End If
    End Sub

    Private Sub Mostrar()
        Try
            If griMaterial.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                If griMaterial.ActiveRow.Cells("IdSubAlmacen").Value.ToString.Trim = "MERMA" Or griMaterial.ActiveRow.Cells("IdSubAlmacen").Value.ToString.Trim = "OPERACIONESC" Then
                    Throw New Exception("No Puede Editar un Material de Operaciones")
                End If
                Dim IdFamilia As String = ""
                Dim IdSubFamilia As String = ""
                oeMaterial = New e_Material

                oeMaterial.TipoOperacion = "G"
                oeMaterial.Id = griMaterial.ActiveRow.Cells("Id").Value.ToString
                oeMaterial = olMaterial.Obtener(oeMaterial)
                With oeMaterial
                    IdFamilia = .IdFamilia
                    IdSubFamilia = .IdSubFamilia
                    txtId.Text = .Id
                    txtCodigo.Text = .Codigo
                    txtNombre.Text = .Nombre
                    cboTipoMaterial.Value = .IdTipoMaterial
                    cboFamilia.Value = IdFamilia
                    cboSubFamilia.Value = IdSubFamilia
                    txtMedida.Text = .Medida
                    decPeso.Value = .Peso
                    'cboMarca.Value = oeMaterial.IdMarca
                    cboTipoUnidadMedida.Value = .IdTipoUnidadMedida
                    cboUnidadMedida.Value = .IdUnidadMedida
                    txtGlosa.Text = .Glosa
                    verIgv.Checked = .AfectoIgv
                    verActivo.Checked = .Activo
                    txtSerial.Text = .Serial
                    chkContabilizable.Checked = .IndDivisible
                    verActivoFijo.Checked = .IndActivoFijo
                End With

                oeCodBarras = New e_CodigoBarraMaterial
                oeCodBarras.TipoOperacion = "1"
                oeCodBarras.IdMaterial = oeMaterial.Id
                oeCodBarras.Activo = True
                MaterialCodBarras = olCodBarras.Listar(oeCodBarras)
                griListaCodBarras.DataSource = MaterialCodBarras

                oeCaracteristicaMaterial = New e_CaracteristicaMaterial
                oeCaracteristicaMaterial.TipoOperacion = ""
                oeCaracteristicaMaterial.IdMaterial = oeMaterial.Id
                loCaracteristicaMaterial = olCaracteristicaMaterial.Listar(oeCaracteristicaMaterial)
                griCaracteristicaMaterial.DataSource = loCaracteristicaMaterial

                oeMaterialAlmacen = New e_MaterialAlmacen
                oeMaterialAlmacen.TipoOperacion = "S"
                oeMaterialAlmacen.IdMaterial = oeMaterial.Id
                lstMaterialAlmacenes = olMaterialAlmacen.Listar_(oeMaterialAlmacen)
                grid_Almacenes.DataSource = lstMaterialAlmacenes

                Dim oeMatAux As New e_Material
                oeMatAux.Id = griMaterial.ActiveRow.Cells("Id").Value.ToString
                oeMatAux.TipoOperacion = "G"
                oeMaterial_DisenoNeu = olMaterial.ObtenerMatNeu(oeMatAux).oeMaterial_DisenoNeu
                MostrarTabs(1, ficMaterial, 1)
                If IdSubFamilia.Trim <> "" Then
                    If gUsuarioSGI.oeArea.Nombre <> "INFORMATICA Y SISTEMAS" Then
                        If VerificarMovimiento(oeMaterial.Id) Then
                            cboSubFamilia.Enabled = False
                        Else
                            cboSubFamilia.Enabled = True
                        End If
                    End If
                End If
                MyBase.Editar()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function VerificarMovimiento(IdMaterial As String) As Boolean
        Try
            Dim oeInventario As New e_Inventario
            Dim olInventario As New l_Inventario
            Dim loInventario As New List(Of e_Inventario)
            oeInventario.TipoOperacion = "5"
            oeInventario.IdMaterial = IdMaterial
            oeInventario.FechaCreacion = Date.Parse("01/01/1901")
            loInventario.AddRange(olInventario.Listar1(oeInventario))
            If loInventario.Count = 0 Then Return False
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function GuardarRegistro() As Boolean
        Try
            'If chkAsignarAlmacen.Checked Then
            '    oeMaterial.IndAsignar = chkAsignarAlmacen.Checked
            '    oeMaterial.IdAlmacen = cbAlmacen.Value
            'End If
            With oeMaterial
                If .Nombre Is Nothing Or .Nombre = "" Then
                    Throw New Exception("Ingrese nombre de material")
                End If
                If .IdUnidadMedida Is Nothing OrElse .IdUnidadMedida = "" Then
                    Throw New Exception("Ingrese Unidad de medida")
                End If
                If MaterialCodBarras.Count > 0 Then .ListaCodigoBarras = MaterialCodBarras
                If loCaracteristicaMaterial.Count > 0 Then .ListaCaracteristicaMaterial = loCaracteristicaMaterial
                If lstMaterialAlmacenes.Count > 0 Then .ListaAlmacenesAsignados = lstMaterialAlmacenes
                .IndDivisible = chkContabilizable.Checked
                .oeMaterial_DisenoNeu = oeMaterial_DisenoNeu
                .UsuarioCreacion = gUsuarioSGI.Id
                .IndActivoFijo = IIf(verActivoFijo.Checked, 1, 0)
            End With
            oeMaterial.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olMaterial.Guardar(oeMaterial) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                If oeMaterial.TipoOperacion = "I" Then
                    EnviarCorreo(oeMaterial.Id)
                End If             
                MostrarTabs(0, ficMaterial, 2)
                Consultar(True)
                griMaterial.Focus()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Sub FormatoGrillaMat(ByVal tipo As String)
        With griMaterial

            .DisplayLayout.Bands(0).Columns("Seleccion").Hidden = True
            .DisplayLayout.Bands(0).Columns("Id").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdTipoMaterial").Hidden = True
            .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdSubFamilia").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdTipoUnidadMedida").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdUnidadMedida").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdFamilia").Hidden = True
            .DisplayLayout.Bands(0).Columns("Glosa").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdAlmacen").Hidden = True
            .DisplayLayout.Bands(0).Columns("Almacen").Hidden = True
            .DisplayLayout.Bands(0).Columns("Precio").Hidden = True
            .DisplayLayout.Bands(0).Columns("Stock").Hidden = True
            .DisplayLayout.Bands(0).Columns("CodigoNombre").Hidden = True
            .DisplayLayout.Bands(0).Columns("AfectoIgv").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdSubAlmacen").Hidden = True
            .DisplayLayout.Bands(0).Columns("SubAlmacen").Hidden = True

            .DisplayLayout.Bands(0).Columns("TipoMaterial").Header.Caption = "Tipo Material"
            .DisplayLayout.Bands(0).Columns("SubFamilia").Header.Caption = "Sub Familia"
            .DisplayLayout.Bands(0).Columns("TipoUnidadMedida").Header.Caption = "Tipo U. Medida"
            .DisplayLayout.Bands(0).Columns("UnidadMedida").Header.Caption = "U. Medida"
            .DisplayLayout.Bands(0).Columns("afectoigv").Header.Caption = "Afecto IGV"
            .DisplayLayout.Bands(0).Columns("Peso").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right

            .DisplayLayout.Bands(0).Columns("Codigo").Width = 70
            .DisplayLayout.Bands(0).Columns("Nombre").Width = 320
            .DisplayLayout.Bands(0).Columns("TipoMaterial").Width = 220
            .DisplayLayout.Bands(0).Columns("Familia").Width = 180
            .DisplayLayout.Bands(0).Columns("SubFamilia").Width = 150
            .DisplayLayout.Bands(0).Columns("TipoUnidadMedida").Width = 100
            .DisplayLayout.Bands(0).Columns("UnidadMedida").Width = 80
            .DisplayLayout.Bands(0).Columns("Medida").Width = 70
            .DisplayLayout.Bands(0).Columns("Peso").Width = 70
            .DisplayLayout.Bands(0).Columns("Serial").Width = 100
            .DisplayLayout.Bands(0).Columns("AfectoIgv").Width = 50

        End With

    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            If Activo Then
                Estado = " Activo"
            Else
                Estado = " Inactivo"
            End If
            oeMaterial = New e_Material
            oeMaterial.TipoOperacion = "G"
            oeMaterial.IdTipoMaterial = cbTipoMaterial.Value
            oeMaterial.IdFamilia = cbFamilia.Value
            oeMaterial.IdSubFamilia = cbSubFamilia.Value
            griMaterial.DataSource = olMaterial.Listar(oeMaterial)
            FormatoGrillaMat("")
            agrLista.Text = "Total de Materiales: " & griMaterial.Rows.Count.ToString
        Catch ex As Exception
            Throw ex
        Finally
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub EvaluaOperacion()
        Select Case Operacion
            Case "Nuevo"
                _TipoOpe = 1
            Case "Editar"
                oeMaterial_DisenoNeu.Material = txtNombre.Text.Trim
                If oeMaterial_DisenoNeu.Id <> "" Then
                    _TipoOpe = 1
                Else
                    If oeMaterial_DisenoNeu.IdDisenoNeumatico <> "" Then
                        _TipoOpe = 1
                    Else
                        _TipoOpe = 2
                    End If
                End If
        End Select
    End Sub

    Private Sub AgregarCaracteristica()
        Try
            If cboCaracteristicaEspecial.SelectedIndex = -1 Then Throw New Exception("Seleccion Caracteristica")
            If loCaracteristicaMaterial.Count > 0 Then
                For Each carmat As e_CaracteristicaMaterial In loCaracteristicaMaterial
                    If carmat.IdCaracteristicaEspecial = cboCaracteristicaEspecial.Value Then
                        Exit Sub
                    End If
                Next
            End If
            oeCaracteristicaMaterial = New e_CaracteristicaMaterial
            oeCaracteristicaMaterial.IdMaterial = oeMaterial.Id
            oeCaracteristicaMaterial.IdCaracteristicaEspecial = cboCaracteristicaEspecial.Value
            oeCaracteristicaMaterial.CaracteristicaEspecial = cboCaracteristicaEspecial.Text
            oeCaracteristicaMaterial.UsuarioCreacion = gUsuarioSGI.Id
            oeCaracteristicaMaterial.FechaCreacion = ObtenerFechaServidor()
            oeCaracteristicaMaterial.TipoOperacion = "I"
            oeCaracteristicaMaterial.PrefijoID = gs_PrefijoIdSucursal '@0001
            loCaracteristicaMaterial.Add(oeCaracteristicaMaterial)
            griCaracteristicaMaterial.DataBind()
            cboCaracteristicaEspecial.SelectedIndex = -1
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EnviarCorreo(IdMaterial As String)
        Try
            If My.Computer.Network.IsAvailable Then
                Try
                    If My.Computer.Network.Ping("8.8.8.8", 1000) Then
                        Dim txtDe As String = "consultores.tecnologicos.2010@gmail.com"
                        Dim txtPara As String = "consultores.tecnologicos.2010@gmail.com; consultores.tecnologicos.2010@gmail.com; consultores.tecnologicos.2010@gmail.com; consultores.tecnologicos.2010@gmail.com"
                        Dim txtAsunto As String = "NUEVO MATERIAL CREADO EN ERP T&L"
                        Dim txtMensaje As String = ""
                        oeMaterial = New e_Material
                        oeMaterial.TipoOperacion = "G"
                        oeMaterial.Id = IdMaterial
                        oeMaterial = olMaterial.Obtener(oeMaterial)
                        txtMensaje = "El Material: " + oeMaterial.Nombre + " ha Sido Creado el Dia: " + Date.Now + " Por el Usuario: " + gUsuarioSGI.Login
                        Dim ls_ListaAdjuntos As String = ""
                        EnviarEmail(txtDe, txtPara, "", "", txtAsunto, txtMensaje, ls_ListaAdjuntos)
                    End If
                Catch ex As Exception

                End Try
            End If  
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Operacion = "Inicializa"
            If griMaterial.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Operacion = "Nuevo"
        MostrarTabs(1, ficMaterial, 1)
        Inicializar()
        oeMaterial.TipoOperacion = "I"
        txtCodigo.Focus()
        'chkAsignarAlmacen.Visible = 1
        'cbAlmacen.Visible = 1
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        Try
            Operacion = "Editar"
            Mostrar()
            oeMaterial.TipoOperacion = "A"
            txtCodigo.Focus()
            MyBase.Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarRegistro() Then
                ActualizarListaPublica("MATERIALSUBFAMILIA")
                If MaterialMerma <> "" Then
                    Me.Close()
                Else
                    MyBase.Guardar()
                End If
            Else
                MostrarTabs(1, ficMaterial, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeMaterial.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarRegistro() Then
                            MostrarTabs(0, ficMaterial, 2)
                            _ingresando_datos = False
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficMaterial, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficMaterial, 2)
                        _ingresando_datos = False
                        Operacion = "Inicializa"
                        MyBase.Consultar(True)
                End Select
            Else
                MostrarTabs(0, ficMaterial, 2)
                _ingresando_datos = False
                Operacion = "Inicializa"
                MyBase.Consultar(True)
            End If
            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With griMaterial
                If ValidarGrilla(griMaterial, "Material") Then
                    oeMaterial = New e_Material
                    oeMaterial.Id = .ActiveRow.Cells("ID").Value
                    oeMaterial.TipoOperacion = "G"
                    oeMaterial = olMaterial.Obtener(oeMaterial)
                    If oeMaterial.Activo Then
                        If MessageBox.Show("Desea eliminar el Material: " & _
                                 .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeMaterial.TipoOperacion = "E"
                            olMaterial.Eliminar(oeMaterial)
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

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    Public Overrides Sub Exportar()
        Try
            If griMaterial.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griMaterial)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Menú contextual del maestro de Material"

    Private Sub AsociarMenu()
        griMaterial.ContextMenuStrip = MenuContextual1
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
        If griMaterial.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

#Region "Codigo de Barras"

    Private Sub btnAgregarCodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCodigo.Click
        Try
            AgregarCodigoBarras()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub btnQuitarCodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarCodigo.Click
        Try
            If griMaterial.Selected.Rows.Count > 0 Then
                Dim oeCodMat As New e_CodigoBarraMaterial
                Dim flag As Boolean = False
                oeCodMat = griListaCodBarras.ActiveRow.ListObject
                If oeCodMat.TipoOperacion = "I" Then
                    oeCodMat = MaterialCodBarras.Item(MaterialCodBarras.IndexOf(oeCodMat))
                    MaterialCodBarras.Remove(oeCodMat)
                Else
                    oeCodMat = MaterialCodBarras.Item(MaterialCodBarras.IndexOf(oeCodMat))
                    oeCodMat.TipoOperacion = "E"
                    griListaCodBarras.ActiveRow.Hidden = True
                End If
                griListaCodBarras.DataBind()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema("Seleccione Registro")
        End Try
    End Sub

    Private Sub griListaCodBarras_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaCodBarras.AfterCellUpdate
        Try
            With griListaCodBarras.ActiveRow
                Dim Id As String = ""
                If .Cells("IndPrincipal").Value = False Then
                    .Cells("IndPrincipal").Value = True
                End If
                If .Cells("IndPrincipal").Value = True Then
                    Id = .Cells("Id").Value
                End If
                For i = 0 To griListaCodBarras.Rows.Count - 1
                    If griListaCodBarras.Rows(i).Cells("Id").Value <> Id Then
                        griListaCodBarras.Rows(i).Cells("IndPrincipal").Value = False
                    End If
                Next
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griListaCodBarras_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaCodBarras.CellChange
        griListaCodBarras.UpdateData()
    End Sub

    Private Sub AgregarCodigoBarras()
        Try
            If txtCodigoBarra.Text <> "" Then
                oeCodBarras = New e_CodigoBarraMaterial
                oeCodBarras.Activo = True
                oeCodBarras.TipoOperacion = "I"
                oeCodBarras.Id = griListaCodBarras.Rows.Count
                If griListaCodBarras.Rows.Count > 0 Then
                    oeCodBarras.IndPrincipal = False
                    For Each codmat As e_CodigoBarraMaterial In MaterialCodBarras
                        If Trim(txtCodigoBarra.Text) = codmat.CodigoBarras Then
                            Throw New Exception("Codigo Ya Asignado al Material")
                            Exit Sub
                        End If
                    Next
                Else
                    oeCodBarras.IndPrincipal = True
                End If
                oeCodBarras.CodigoBarras = txtCodigoBarra.Text
                oeCodBarras.PrefijoID = gs_PrefijoIdSucursal '@0001
                MaterialCodBarras.Add(oeCodBarras)
                griListaCodBarras.DataBind()
                txtCodigoBarra.Text = String.Empty
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub txtCodigoBarra_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoBarra.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                AgregarCodigoBarras()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Caracteristica Material"

#End Region

End Class