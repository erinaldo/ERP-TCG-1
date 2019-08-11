Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports ISL.Controles
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports Infragistics.Shared
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinDataSource
Imports System.Collections
Imports Infragistics.Win.UltraWinGrid

Public Class frm_Neumatico
    Inherits ISL.Win.frm_MenuPadre

#Region "Declaración de variables"

    Dim oeNeumatico As New e_Neumatico, olNeumatico As New l_Neumatico
    Dim oeVidaNeumatico As New e_VidaNeumatico, olVidaNeumatico As New l_VidaNeumatico, leVidaNeumatico As New List(Of e_VidaNeumatico)
    Dim oeMaterial As New e_Material, olMaterial As New l_Material, leMaterial As New List(Of e_Material)
    Dim oeMarca As e_Marca, olMarca As l_Marca
    Dim oeMedida As New e_MedidaNeumatico, olMedida As New l_MedidaNeumatico
    Dim oeDiseño As New e_DiseñoNeumatico, olDiseño As New l_DiseñoNeumatico, leDiseño As New List(Of e_DiseñoNeumatico)
    Dim oeTipo As New e_TipoNeumatico, olTipo As New l_TipoNeumatico
    Dim oeOperacionNeu As New e_OperacionNeumatico, olOperacionNeu As New l_OperacionNeumatico, leOperacionNeu As New List(Of e_OperacionNeumatico)
    Dim oeOrdenSalida As New e_OrdenMaterial, olOrdenSalida As New l_OrdenMaterial
    Dim dsNeumaticoVidas As DataSet
    Dim relationNeuVida As DataRelation
    Private oeDetalleOrdenNeu As New e_DetalleOrdenNeumatico, olDetalleOrdenNeu As New l_DetalleOrdenNeumatico, leDetalleOrdenNeu As List(Of e_DetalleOrdenNeumatico)
    Dim oeProveedor As New e_Proveedor, olProveedor As New l_Proveedor, llProveedores As New List(Of e_Proveedor)
    Dim lstVidaNeumatico As List(Of e_VidaNeumatico)
    Dim ls_IdVidaNeumatico As String = String.Empty, _ingresando_datos As Boolean = False
    Dim _TipoCambio As Double = 0, _Lista As String = "", _IdVidaNeu As String = "", bandConf As Boolean = False
    Private oeMatDiseno As New e_Material_DisenoNeu
    Private oeFlota As New e_Flota, olFlota As New l_Flota, leFlota As New List(Of e_Flota)
    Private oeVehiculo As New e_Vehiculo, olVehiculo As New l_Vehiculo, leVehiculo As New List(Of e_Vehiculo)
    Dim NroSel As Integer = 0, _descripcion As String = "", _kmVida As Double = 0
    Private _opeNeu As String = "", _acl As String = "", _estado As String = ""

    Dim loConcepto As New l_Concepto
    Dim oeConcepto As New e_Concepto
    Dim ListaConcepto As New List(Of e_Concepto)
    Dim olTrabajadorSeguridad As New l_TrabajadorSeguridad

#End Region

#Region "Inicializar el formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_Neumatico = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_Neumatico()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            If tcNeumatico.SelectedTab.Index = 0 Then
                Listar(Activo)
                Tiempo1.Enabled = True
                Operacion = "Inicializa"
                If grid_Neumatico.Rows.Count > 0 Then
                    MyBase.Consultar(Activo)
                Else
                    MyBase.Consultar()
                End If
            Else
                oeDetalleOrdenNeu = New e_DetalleOrdenNeumatico
                oeDetalleOrdenNeu.TipoOperacion = "L"
                oeDetalleOrdenNeu.Confirmacion = 0
                leDetalleOrdenNeu = olDetalleOrdenNeu.Listar(oeDetalleOrdenNeu)
                CargarPreRegistro(leDetalleOrdenNeu)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            _acl = gAccionSistema.NUEVO.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _opeNeu = "GENERADA"
                txtCodigoAgregar.Text = ObtenerUltimoCodigoNeumatico() + 1
                oeNeumatico = New e_Neumatico
                oeNeumatico.TipoOperacion = "I"
                oeNeumatico.UsuarioCreacion = gUsuarioSGI.Id
                Operacion = "Nuevo"
                Inicializar()
                ' MostrarTabs(1, tcNeumatico, 1)
                tcNeumatico.Tabs(0).Enabled = False
                tcNeumatico.Tabs(1).Enabled = False
                tcNeumatico.Tabs(2).Enabled = True
                tcNeumatico.SelectedTab = tcNeumatico.Tabs(2)
                cmbMaterial.Focus()
                btnCalculaKmNeu.Enabled = False
                cboLugar.SelectedIndex = 0 : cboLugar.ReadOnly = True
                cboAlmacen.SelectedIndex = 1 : cboAlmacen.ReadOnly = True
                MyBase.Nuevo()
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            _acl = gAccionSistema.EDITAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _opeNeu = "GENERADA"
                oeNeumatico = New e_Neumatico
                Operacion = "Editar"
                MostrarNeumatico()
                oeNeumatico.TipoOperacion = "A"
                ' cmbMaterial.Focus()
                btnCalculaKmNeu.Enabled = True
                cboLugar.ReadOnly = False
                cboAlmacen.ReadOnly = False
                MyBase.Editar()
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarNeumatico() Then
                MyBase.Guardar()
            Else
                tcNeumatico.SelectedTab = tcNeumatico.Tabs(2)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If _Lista = "1" Then
                If oeNeumatico.Modificado Then
                    Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", _
                                                "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, _
                                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                        Case Windows.Forms.DialogResult.Yes
                            If GuardarNeumatico() Then
                                tcNeumatico.Tabs(0).Enabled = True
                                tcNeumatico.Tabs(1).Enabled = True
                                tcNeumatico.Tabs(2).Enabled = False
                                tcNeumatico.SelectedTab = tcNeumatico.Tabs(0)
                                _ingresando_datos = False
                                Consultar(True)
                            Else
                                _ingresando_datos = True
                                tcNeumatico.Tabs(0).Enabled = False
                                tcNeumatico.Tabs(1).Enabled = False
                                tcNeumatico.Tabs(2).Enabled = True
                                tcNeumatico.SelectedTab = tcNeumatico.Tabs(2)
                            End If
                        Case Windows.Forms.DialogResult.No
                            tcNeumatico.Tabs(0).Enabled = True
                            tcNeumatico.Tabs(1).Enabled = True
                            tcNeumatico.Tabs(2).Enabled = False
                            tcNeumatico.SelectedTab = tcNeumatico.Tabs(0)
                            _ingresando_datos = False
                            Consultar(True)
                    End Select
                Else
                    tcNeumatico.Tabs(0).Enabled = True
                    tcNeumatico.Tabs(1).Enabled = True
                    tcNeumatico.Tabs(2).Enabled = False
                    tcNeumatico.SelectedTab = tcNeumatico.Tabs(0)
                    _ingresando_datos = False
                    'Consultar(True)
                End If
            Else
                If MessageBox.Show("¿Desea Cancelar la Operacion?", "Mensaje de Sistema", MessageBoxButtons.YesNo _
                                   , MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    tcNeumatico.Tabs(0).Enabled = True
                    tcNeumatico.Tabs(1).Enabled = True
                    tcNeumatico.Tabs(2).Enabled = False
                    tcNeumatico.SelectedTab = tcNeumatico.Tabs(1)
                    Consultar(True)
                End If
            End If
            
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            _acl = gAccionSistema.ELIMINAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                With grid_Neumatico
                    If ValidarGrilla(grid_Neumatico, "Neumatico") Then
                        oeNeumatico.TipoOperacion = "R"
                        oeNeumatico.Id = .ActiveRow.Cells("Id").Value
                        If VerficarOperacionesMovimientos(oeNeumatico) Then
                            If MessageBox.Show("Esta seguro de eliminar el Neumatico: " & _
                            .ActiveRow.Cells("Codigo").Value.ToString.Trim & "?", _
                            "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                oeNeumatico.TipoOperacion = "E"
                                olNeumatico.Eliminar(oeNeumatico)
                                Consultar(True)
                            End If
                        Else
                            Throw New Exception("No se puede eliminar el neumatico, tiene operaciones y movimientos vigentes. ")
                        End If
                    End If
                End With
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
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
            If grid_Neumatico.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(grid_Neumatico)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Metodos y Funciones"

    Sub MostrarNeumatico()
        Try
            If grid_Neumatico.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                bandConf = False
                Inicializar()
                oeNeumatico.TipoOperacion = ""
                oeNeumatico.Id = grid_Neumatico.ActiveRow.Cells("Id").Value.ToString
                oeNeumatico = olNeumatico.Obtener(oeNeumatico)
                CargarDatosNeu(oeNeumatico)
                tcNeumatico.Tabs(0).Enabled = False
                tcNeumatico.Tabs(1).Enabled = False
                tcNeumatico.Tabs(2).Enabled = True
                tcNeumatico.SelectedTab = tcNeumatico.Tabs(2)
                btnGeneraVida.Enabled = False
                MyBase.Editar()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ObtenerPrimeraVidaNeumatico()
        oeVidaNeumatico = New e_VidaNeumatico
        oeVidaNeumatico.IdNeumatico = grid_Neumatico.ActiveRow.Cells("Id").Value.ToString
        oeVidaNeumatico.TipoOperacion = "U"
        oeVidaNeumatico.Vigente = 1
        oeVidaNeumatico.Activo = True
        oeVidaNeumatico = olVidaNeumatico.Obtener(oeVidaNeumatico)

        ls_IdVidaNeumatico = oeVidaNeumatico.Id
        ndRibete1.Value = oeVidaNeumatico.Ribete1
        ndRibete2.Value = oeVidaNeumatico.Ribete2
        ndRibete3.Value = oeVidaNeumatico.Ribete3
        'ndRibete4.Value = oeVidaNeumatico.Ribete4
        ndCocada.Value = oeVidaNeumatico.Cocada
        Select Case oeVidaNeumatico.Condicion
            Case "NVO"
                optCondicion.CheckedIndex = 0
            Case "USD"
                optCondicion.CheckedIndex = 1
            Case "REE"
                optCondicion.CheckedIndex = 2
        End Select
        ndNroVida.Value = oeVidaNeumatico.NroVida
        cboLugar.SelectedIndex = oeVidaNeumatico.IndLugar
        cboAlmacen.SelectedIndex = oeVidaNeumatico.IndLog
    End Sub

    Public Sub LlenaCombos()
        Try
            oeMarca = New e_Marca
            oeMarca.Activo = True
            oeMarca.TipoMarca = 1
            LlenarComboMaestro(cmbMarca, olMarca.Listar(oeMarca), -1)

            oeDiseño = New e_DiseñoNeumatico
            oeDiseño.Activo = True
            leDiseño = olDiseño.Listar(oeDiseño)

            Dim lstProveedor As New List(Of e_Proveedor)
            oeProveedor.Activo = True
            lstProveedor = olProveedor.Listar(oeProveedor)

            oeProveedor.Id = "0"
            oeProveedor.Nombre = "NINGUNO"
            llProveedores.Add(oeProveedor)
            llProveedores.AddRange(lstProveedor)
            LlenarComboMaestro(cmbProveedor, llProveedores, 0)

            oeMaterial = New e_Material
            oeMaterial.TipoOperacion = "N"
            oeMaterial.Activo = 1
            leMaterial = olMaterial.Listar(oeMaterial)
            'cmbMaterial.DataSource = olMaterial.Listar(oeMaterial)

            oeFlota = New e_Flota
            oeFlota.Id = String.Empty : oeFlota.Activo = True : oeFlota.Nombre = "[ TODOS ]"
            leFlota.Add(oeFlota)
            oeFlota = New e_Flota
            oeFlota.TipoOperacion = String.Empty : oeFlota.Activo = True : oeFlota.IndFlota = 1 : oeFlota.IndZona = 1
            leFlota.AddRange(olFlota.Listar(oeFlota).OrderBy(Function(it) it.Nombre).ToList)
            LlenarCombo(cboFlota, "Nombre", leFlota, 0)

            oeVehiculo = New e_Vehiculo
            oeVehiculo.TipoOperacion = "A" : oeVehiculo.Activo = True : oeVehiculo.Motriz = -1
            leVehiculo.AddRange(olVehiculo.Listar(oeVehiculo).OrderBy(Function(it) it.Placa).ToList)

            cboEstado.Items.Clear()
            cboEstado.Items.Add("[ TODOS ]")
            cboEstado.Items.Add("MON")
            cboEstado.Items.Add("DES")
            cboEstado.Items.Add("VEN")
            cboEstado.SelectedIndex = 0

            cboLugar.Items.Clear()
            cboLugar.Items.Add("PACASMAYO")
            cboLugar.Items.Add("LIMA")
            cboLugar.Items.Add("CHICLAYO")
            cboLugar.Items.Add("PIURA")
            cboLugar.SelectedIndex = 0

            cboAlmacen.Items.Clear()
            cboAlmacen.Items.Add("STAND-BY")
            cboAlmacen.Items.Add("STOCK")
            cboAlmacen.SelectedIndex = 0

            'llenamos combo tipo banda
            ListaConcepto = New List(Of e_Concepto)
            oeConcepto = New e_Concepto
            oeConcepto.Activo = True
            oeConcepto.Prefijo = "17" 'prefijo de tipo banda
            ListaConcepto = loConcepto.Listar(oeConcepto)
            cboTipoBanda.DataSource = ListaConcepto
            cboTipoBanda.DisplayMember = "Nombre"
            cboTipoBanda.ValueMember = "Valor1"
            cboTipoBanda.SelectedIndex = -1
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub Listar(ByVal Activo As Boolean)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeNeumatico = New e_Neumatico
            oeNeumatico.Activo = Activo
            oeNeumatico.TipoOperacion = "V"
            dsNeumaticoVidas = olNeumatico.ListarDS(oeNeumatico)
            CargarNeumaticos(dsNeumaticoVidas)
        Catch ex As Exception
            Throw ex
        Finally
            Cursor = Cursors.Default
            ugb_Espera.Visible = False
            grid_Neumatico.Focus()
        End Try
    End Sub

    Private Sub CargarNeumaticos(dsNeu As Data.DataSet)
        Try
            Dim dsAux As New DataSet, dtPadre As New DataTable, dtHijo As New DataTable
            Dim drPadre() As DataRow, drHijo() As DataRow
            Dim strFiltro As String = ""
            If cboEstado.SelectedIndex > 0 Then
                If cboEstado.Text <> "MON" Then
                    strFiltro = "EstadoActual = '" & cboEstado.Text & "'"
                Else
                    If cboFlota.SelectedIndex > 0 Then
                        strFiltro = "EstadoActual = '" & cboEstado.Text & "' AND IdFlota = '" & cboFlota.Value & "'"
                        If cboVehiculo.SelectedIndex > 0 Then
                            strFiltro = "EstadoActual = '" & cboEstado.Text & "' AND IdFlota = '" & cboFlota.Value & "' AND IdVehiculo = '" & cboVehiculo.Value & "'"
                        Else
                            strFiltro = "EstadoActual = '" & cboEstado.Text & "' AND IdFlota = '" & cboFlota.Value & "'"
                        End If
                    Else
                        strFiltro = "EstadoActual = '" & cboEstado.Text & "'"
                    End If
                End If
                drPadre = dsNeu.Tables(0).Select(strFiltro, "")
                If drPadre.Count = 0 Then Throw New Exception("No Hay Registros Encontrados")
                drHijo = dsNeu.Tables(1).Select(strFiltro, "")
                dtPadre = drPadre.CopyToDataTable
                dtHijo = drHijo.CopyToDataTable
            Else
                dtPadre = dsNeu.Tables(0).Copy
                dtHijo = dsNeu.Tables(1).Copy
            End If
            dsAux.Tables.Add(dtPadre) : dsAux.Tables.Add(dtHijo)
            Dim parentCol As DataColumn = dsAux.Tables(0).Columns("Id")
            Dim childCol As DataColumn = dsAux.Tables(1).Columns("IdNeumatico")
            relationNeuVida = New DataRelation("FK_Relacion", parentCol, childCol, True)
            dsAux.Relations.Add(relationNeuVida)
            dsAux.AcceptChanges()
            grid_Neumatico.DataSource = dsAux
            grid_Neumatico.DisplayLayout.CaptionVisible = DefaultableBoolean.True
            grid_Neumatico.Text = "Neumaticos con Estado: " & cboEstado.Text & ", Flota: " & cboFlota.Text & ", Vehiculo: " & _
                cboVehiculo.Text & " (" & grid_Neumatico.Rows.Count & ")"
            With grid_Neumatico.DisplayLayout.Bands(1)
                .Columns("IdNeumatico").Hidden = True
                .Columns("Ribete4").Hidden = True
                .Columns("IdFlota").Hidden = True
                .Columns("IdVehiculo").Hidden = True
                .Columns("Vigente").Width = 55
                .Columns("Vigente").Style = ColumnStyle.CheckBox
                .Columns("NroVida").Header.Appearance.TextHAlign = HAlign.Center
                .Columns("Vigente").Header.Appearance.TextHAlign = HAlign.Center
                .Columns("Ribete1").Header.Appearance.TextHAlign = HAlign.Center
                .Columns("Ribete2").Header.Appearance.TextHAlign = HAlign.Center
                .Columns("Ribete3").Header.Appearance.TextHAlign = HAlign.Center
                .Columns("Cocada").Header.Appearance.TextHAlign = HAlign.Center
                .Columns("CostoSoles").Header.Appearance.TextHAlign = HAlign.Center
                .Columns("CostoDolares").Header.Appearance.TextHAlign = HAlign.Center
                .Columns("Condicion").Header.Appearance.TextHAlign = HAlign.Center
                .Columns("FechaIngreso").Header.Appearance.TextHAlign = HAlign.Center
                .Columns("EstadoActual").Header.Appearance.TextHAlign = HAlign.Center
                .Columns("Kilometraje").Header.Appearance.TextHAlign = HAlign.Center
                .Columns("NroVida").CellAppearance.TextHAlign = HAlign.Center
                .Columns("Vigente").CellAppearance.TextHAlign = HAlign.Center
                .Columns("Ribete1").CellAppearance.TextHAlign = HAlign.Right
                .Columns("Ribete2").CellAppearance.TextHAlign = HAlign.Right
                .Columns("Ribete3").CellAppearance.TextHAlign = HAlign.Right
                .Columns("Cocada").CellAppearance.TextHAlign = HAlign.Right
                .Columns("CostoSoles").CellAppearance.TextHAlign = HAlign.Right
                .Columns("CostoDolares").CellAppearance.TextHAlign = HAlign.Right
                .Columns("FechaIngreso").CellAppearance.TextHAlign = HAlign.Center
                .Columns("Kilometraje").CellAppearance.TextHAlign = HAlign.Right
                .Override.AllowRowFiltering = DefaultableBoolean.False
                .Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Default
                .Override.FilterUIType = FilterUIType.Default
                .Override.CellClickAction = CellClickAction.RowSelect
            End With
            grid_Neumatico.DisplayLayout.Bands(0).Override.CellClickAction = CellClickAction.RowSelect
            For Each Fila As UltraGridRow In grid_Neumatico.Rows
                Select Case Fila.Cells("EstadoActual").Value
                    Case "MON" : Fila.Appearance.BackColor = colorMontaje.Color
                    Case "DES" : Fila.Appearance.BackColor = colorDesmontaje.Color
                    Case "VEN" : Fila.Appearance.BackColor = colorVenta.Color
                End Select
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GuardarNeumatico() As Boolean
        Try
            If _Lista = "1" Then
                If _opeNeu = "GENERADA" Then
                    Select Case Operacion
                        Case "Nuevo"
                            AsignarCodigos() : AsignarVidaNeumatico()
                            If leVidaNeumatico.Count > 0 Then oeNeumatico.lstVidaNeumatico.AddRange(leVidaNeumatico)
                        Case "Editar"
                            oeVidaNeumatico = New e_VidaNeumatico
                            oeVidaNeumatico.Equivale = 1
                            oeVidaNeumatico.Vigente = 1
                            If leVidaNeumatico.Contains(oeVidaNeumatico) Then
                                oeVidaNeumatico = leVidaNeumatico.Item(leVidaNeumatico.IndexOf(oeVidaNeumatico))
                                oeVidaNeumatico.TipoOperacion = "N"
                                oeVidaNeumatico.IndLugar = cboLugar.SelectedIndex
                                oeVidaNeumatico.IndLog = cboAlmacen.SelectedIndex
                                lstVidaNeumatico = New List(Of e_VidaNeumatico)
                                lstVidaNeumatico.Add(oeVidaNeumatico)
                                oeNeumatico.lstVidaNeumatico = lstVidaNeumatico
                            End If
                    End Select
                    If olNeumatico.Guardar(oeNeumatico) Then
                        mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                        tcNeumatico.Tabs(0).Enabled = True
                        tcNeumatico.Tabs(1).Enabled = True
                        tcNeumatico.Tabs(2).Enabled = False
                        tcNeumatico.SelectedTab = tcNeumatico.Tabs(0)
                        Consultar(True)
                        grid_Neumatico.Focus()
                        Return True
                    End If
                End If
            Else
                If lstCodigos.Items.Count > 0 Then
                    If lstCodigos.Items.Count < NroSel Then Throw New Exception("Ha Seleccionado " & NroSel & _
                    " Neumaticos pero esta confirmando " & lstCodigos.Items.Count)
                    AsignarCodigos()
                    AsignarVidaNeumatico()
                    oeNeumatico.CostoCascoDolares = ndCostoCascoDolares.Value
                    If olNeumatico.Confirmar(oeNeumatico) Then
                        mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                        tcNeumatico.Tabs(0).Enabled = True
                        tcNeumatico.Tabs(1).Enabled = True
                        tcNeumatico.Tabs(2).Enabled = False
                        tcNeumatico.SelectedTab = tcNeumatico.Tabs(1)
                        Consultar(True)
                        griPreRegistro.Focus()
                        Return True
                    End If
                Else
                    Throw New Exception("Debe Generar Codigo para Ingreso del Neumatico!!!")
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub AsignarCodigos()
        If lstCodigos.Items.Count > 0 Then
            Dim cadena As String = ""
            For i As Integer = 0 To lstCodigos.Items.Count - 1
                cadena = cadena & lstCodigos.Items.Item(i).ToString & ","
            Next
            oeNeumatico.Codigo = Strings.Left(cadena, cadena.Length - 1)
        End If
    End Sub

    Private Sub AsignarVidaNeumatico()
        oeNeumatico.lstVidaNeumatico.Clear()
        oeVidaNeumatico = New e_VidaNeumatico
        oeVidaNeumatico.Id = ls_IdVidaNeumatico
        oeVidaNeumatico.NroVida = ndNroVida.Value
        oeVidaNeumatico.FechaIngreso = fecIngreso.Value
        oeVidaNeumatico.Ribete1 = ndRibete1.Value
        oeVidaNeumatico.Ribete2 = ndRibete2.Value
        oeVidaNeumatico.Ribete3 = ndRibete3.Value
        oeVidaNeumatico.Cocada = ndCocada.Value
        oeVidaNeumatico.CocadaOriginal = ndCocadaOriginal.Value
        Select Case optCondicion.CheckedIndex
            Case 0
                oeVidaNeumatico.Condicion = "NVO"
            Case 1
                oeVidaNeumatico.Condicion = "USD"
            Case 2
                oeVidaNeumatico.Condicion = "REE"
        End Select
        oeVidaNeumatico.Kilometraje = ndKilometraje.Value
        oeVidaNeumatico.CostoSoles = ndCostoSoles.Value
        oeVidaNeumatico.CostoDolares = ndCostoDolares.Value
        oeVidaNeumatico.EstadoActual = "DES"
        oeVidaNeumatico.Ubicacion = "ALMACEN"
        oeVidaNeumatico.IdProveedor = cmbProveedor.Value
        oeVidaNeumatico.UsuarioCreacion = gUsuarioSGI.Id
        oeVidaNeumatico.IdDisenoNeu = cmbDiseño.Value
        oeVidaNeumatico.FechaFinVida = #1/1/1901#
        oeVidaNeumatico.Vigente = 1
        oeVidaNeumatico.CostoCascoDolares = ndCostoCascoDolares.Value
        oeVidaNeumatico.IndLugar = cboLugar.SelectedIndex
        oeVidaNeumatico.IndLog = cboLugar.SelectedIndex
        If Operacion = "Nuevo" AndAlso optCondicion.CheckedIndex = 2 Then
            oeNeumatico.lstVidaNeumatico.Add(oeVidaNeumatico)
            oeNeumatico.KilometrajeActual = leVidaNeumatico.Where(Function(it) it.Vigente = 0).Sum(Function(it) it.Kilometraje)
        Else
            oeNeumatico.CostoCascoDolares = ndCostoCascoDolares.Value
            oeNeumatico.lstVidaNeumatico.Add(oeVidaNeumatico)
        End If
    End Sub

    Public Sub ListarMateriales()

        Try
            Cursor.Current = Cursors.WaitCursor
            oeMaterial = New e_Material
            cmbMaterial.DataSource = Nothing
            If Not String.IsNullOrEmpty(cmbMaterial.Text.Trim) Then
                'oeMaterial.Nombre = cmbMaterial.Text.Trim
                'oeMaterial.TipoOperacion = "G"
                'oeMaterial.Activo = True
                Dim _leMat = leMaterial.Where(Function(it) it.Nombre.Contains(cmbMaterial.Text.Trim)).ToList
                cmbMaterial.DataSource = _leMat
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Sub Inicializar()
        Me.txtCodigo.Text = String.Empty
        Me.fecIngreso.Value = Date.Now
        Me.neCantidad.Value = 1
        Me.ndKilometraje.Value = 0
        Me.lstCodigos.Items.Clear()
        Me.ndCostoSoles.Value = 0
        Me.ndCostoDolares.Value = 0
        Me.ndCostoCascoDolares.Value = 70
        Me.ndCocada.Value = 0
        Me.ndCocadaMinima.Value = 0
        ndRibete1.Value = 0
        ndRibete2.Value = 0
        ndRibete3.Value = 0
        cmbMaterial.Text = String.Empty
        cmbMaterial.DataSource = leMaterial
        cmbDiseño.SelectedIndex = -1
        cmbProveedor.SelectedIndex = 0
        cmbMarca.SelectedIndex = -1
        cmbDiseño.SelectedIndex = -1
        txtMedida.Value = String.Empty
        txtTipoNeumatico.Value = String.Empty

        cboTipoBanda.SelectedIndex = -1
        optCondicion.CheckedIndex = 0
        verActivo.Checked = True
        _TipoCambio = TipoCambio(Date.Now, True)(0)
        If _TipoCambio = 0 Then Throw New Exception("No existe tipo de cambio para esta fecha.")
        decTipoCambio.Value = _TipoCambio
        txtDOT.Text = String.Empty
        'If Operacion = "Editar" Then
        '    txtDOT.ReadOnly = True
        'Else
        '    txtDOT.ReadOnly = False
        'End If
        leVidaNeumatico = New List(Of e_VidaNeumatico)
        CargarVidaNeu(leVidaNeumatico)
        leOperacionNeu = New List(Of e_OperacionNeumatico)
        CargarOperacionNeu(leOperacionNeu)
        _IdVidaNeu = String.Empty : _kmVida = 0
        btnGrabarActKm.Enabled = False
    End Sub

    Private Function ObtenerUltimoCodigoNeumatico() As Integer
        Try
            oeNeumatico = New e_Neumatico
            oeNeumatico.Activo = True
            oeNeumatico.TipoOperacion = "C"
            oeNeumatico = olNeumatico.Obtener(oeNeumatico)
            Dim var As Integer = 0
            If oeNeumatico.Id <> "" Then
                var = CInt(oeNeumatico.Codigo)
            End If
            Return var
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Sub CargarRibetesSegunDiseño()
        Try
            Dim obj As New e_DiseñoNeumatico
            obj = cmbDiseño.Items(cmbDiseño.SelectedIndex).ListObject
            ndRibete1.Value = obj.Ribete1
            ndRibete2.Value = obj.Ribete2
            ndRibete3.Value = obj.Ribete3
            'ndRibete4.Value = obj.Ribete4
            ndCocada.Value = obj.Cocada
            ndCocadaMinima.Value = obj.CocadaMinima
            ndCocadaOriginal.Value = obj.Cocada

            oeMedida = New e_MedidaNeumatico
            oeMedida.Activo = True
            oeMedida.Id = obj.IdMedidaNeumatico
            oeMedida = olMedida.Obtener(oeMedida)
            txtMedida.Value = oeMedida.Nombre

            oeTipo = New e_TipoNeumatico
            oeTipo.Activo = True
            oeTipo.Id = oeMedida.IdTipoNeumatico
            oeTipo = olTipo.Obtener(oeTipo)
            txtTipoNeumatico.Value = oeTipo.Nombre
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Function r_FormatoCodigo( _
          ByVal lnTamañoCad As Byte _
          , ByVal lsPrefijo As String _
          , ByVal lsCadena As String _
          , ByVal lsPrefijoCentro As String) As String
        Dim lsCod As String = ""
        If lsCadena.Length And lsPrefijo <> lsCadena Then
            If lsPrefijoCentro = "" Then
                lnTamañoCad = lnTamañoCad - lsCadena.Length
                lsCadena = lsCadena.Substring(lsPrefijo.Length, lsCadena.Length - lsPrefijo.Length)
                lsCod = lsPrefijo & StrDup(lnTamañoCad, "0") & lsCadena
            Else
                lsCadena = Strings.Right(lsCadena, lsCadena.Length - lsPrefijo.Length) 'QUITA PREFIJO
                lnTamañoCad = lnTamañoCad - lsPrefijoCentro.Length - lsPrefijo.Length - lsCadena.Length
                lsCod = lsPrefijo & lsPrefijoCentro & StrDup(lnTamañoCad, "0") & lsCadena
            End If
        Else
            lsCod = lsPrefijo
        End If
        Return lsCod
    End Function

    Public Function VerificarCodioInterno(ByVal ls_Codigo As String) As Boolean
        Try
            If lstCodigos.Items.Count > 0 Then
                For j As Integer = 0 To lstCodigos.Items.Count - 1
                    If ls_Codigo = lstCodigos.Items.Item(j) Then
                        MessageBox.Show("Ya ingresó este codigo a la lista : " & ls_Codigo, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Me.txtCodigoAgregar.Focus()
                        Return False
                    End If
                Next
            End If
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Function

    ''' <summary>
    ''' Quitar un registro de la lista de códigos de neumático
    ''' </summary>
    ''' <remarks></remarks>
    Sub Quitar()
        If lstCodigos.SelectedIndex > -1 Then
            lstCodigos.Items.RemoveAt(lstCodigos.SelectedIndex)
        End If
    End Sub

    Private Sub CargarVidaNeu(ByVal leVidaN As List(Of e_VidaNeumatico))
        Try
            With griVidaNeumatico

                Dim _leAux = leVidaN.OrderBy(Function(it) it.NroVida).ToList

                .DataSource = _leAux


                OcultarColumna(griVidaNeumatico, True, "Id", "IdNeumatico", "CodigoNeumatico", "IdMarca", "Activo", "UsuarioCreacion", "IdMedida", _
                               "IdProveedor", "KmTotalNeumatico", "Ribete4", "CostoDolxMilKm", "CocadaMinima", "CostoActualDolares", "KmProyectado", _
                               "FechaFinVida", "IdDisenoNeu", "IndLugar", "IndLog")

                .DisplayLayout.Bands(0).Columns("EstadoActual").Header.Caption = "Estado"
                .DisplayLayout.Bands(0).Columns("FechaIngreso").Header.Caption = "Fec. Montaje"
                .DisplayLayout.Bands(0).Columns("Ribete1").Header.Caption = "R1"
                .DisplayLayout.Bands(0).Columns("Ribete2").Header.Caption = "R2"
                .DisplayLayout.Bands(0).Columns("Ribete3").Header.Caption = "R3"
                .DisplayLayout.Bands(0).Columns("Kilometraje").Header.Caption = "Km"
                .DisplayLayout.Bands(0).Columns("CocadaOriginal").Header.Caption = "C. Original"
                .DisplayLayout.Bands(0).Columns("CostoSoles").Header.Caption = "Costo S/"
                .DisplayLayout.Bands(0).Columns("CostoDolares").Header.Caption = "Costo $."
                .DisplayLayout.Bands(0).Columns("CostoCascoDolares").Header.Caption = "Costo Casco $."

                .DisplayLayout.Bands(0).Columns("Vigente").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("NroVida").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Condicion").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("EstadoActual").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Ubicacion").Header.VisiblePosition = 5

                .DisplayLayout.Bands(0).Columns("Vigente").Style = ColumnStyle.CheckBox

                FormatoColumna(griVidaNeumatico, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Kilometraje", "CostoSoles", "CostoDolares", "CostoCascoDolares")

                .DisplayLayout.Bands(0).Columns("Vigente").Width = 30
                .DisplayLayout.Bands(0).Columns("Condicion").Width = 55
                .DisplayLayout.Bands(0).Columns("EstadoActual").Width = 55
                .DisplayLayout.Bands(0).Columns("Ribete1").Width = 30
                .DisplayLayout.Bands(0).Columns("Ribete2").Width = 30
                .DisplayLayout.Bands(0).Columns("Ribete3").Width = 30
                .DisplayLayout.Bands(0).Columns("Cocada").Width = 45
                .DisplayLayout.Bands(0).Columns("CocadaOriginal").Width = 50

                .DisplayLayout.UseFixedHeaders = True
                .DisplayLayout.Override.FixedHeaderIndicator = FixedHeaderIndicator.None
                .DisplayLayout.Bands(0).Columns("Vigente").Header.Fixed = True
                .DisplayLayout.Bands(0).Columns("NroVida").Header.Fixed = True

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarOperacionNeu(ByVal leOpe As List(Of e_OperacionNeumatico))
        Try
            With griOperacionNeumatico

                .DataSource = leOpe.OrderByDescending(Function(it) it.FechaOperacion).ToList

                OcultarColumna(griOperacionNeumatico, True, "Id", "IdVidaNeumatico", "CodigoNeumatico", "IdNeumatico", "Marca", "Medida", "Diseño", "IdVehiculo", _
                               "IdMotivo", "IndMontaje", "IndInspeccion", "Activo", "UsuarioCreacion", "Ribete4", "KmRecorridoNeu", "IdResponsable", _
                               "IdConductor", "IndObservacion")

                .DisplayLayout.Bands(0).Columns("Ribete1").Header.Caption = "R1"
                .DisplayLayout.Bands(0).Columns("Ribete2").Header.Caption = "R2"
                .DisplayLayout.Bands(0).Columns("Ribete3").Header.Caption = "R3"
                .DisplayLayout.Bands(0).Columns("FechaOperacion").Header.Caption = "Fecha"
                .DisplayLayout.Bands(0).Columns("Posicion").Header.Caption = "Pos"

                .DisplayLayout.Bands(0).Columns("FechaOperacion").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Codigo").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Motivo").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Placa").Header.VisiblePosition = 4

                FormatoColumna(griOperacionNeumatico, "#,##0.00", ColumnStyle.Double, HAlign.Right, "KmVehiculo", "KmNeumatico")

                .DisplayLayout.Bands(0).Columns("Ribete1").Width = 30
                .DisplayLayout.Bands(0).Columns("Ribete2").Width = 30
                .DisplayLayout.Bands(0).Columns("Ribete3").Width = 30
                .DisplayLayout.Bands(0).Columns("FechaOperacion").Width = 60
                .DisplayLayout.Bands(0).Columns("Motivo").Width = 150
                .DisplayLayout.Bands(0).Columns("Placa").Width = 55
                .DisplayLayout.Bands(0).Columns("Posicion").Width = 30
                .DisplayLayout.Bands(0).Columns("Cocada").Width = 50
                .DisplayLayout.Bands(0).Columns("Presion").Width = 50

                .DisplayLayout.UseFixedHeaders = True
                .DisplayLayout.Override.FixedHeaderIndicator = FixedHeaderIndicator.None
                .DisplayLayout.Bands(0).Columns("FechaOperacion").Header.Fixed = True
                .DisplayLayout.Bands(0).Columns("Codigo").Header.Fixed = True

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.CellSelect
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub ListarOrdenesSalida()
        oeOrdenSalida.TipoOperacion = "N"
        oeOrdenSalida.FechaInicio = fecDesde.Value
        oeOrdenSalida.FechaFin = fecHasta.Value
        oeOrdenSalida.Activo = True
        grid_OrdenesSalida.DataSource = olOrdenSalida.ListarOSNeumaticos(oeOrdenSalida)
    End Sub

    Public Function VerficarOperacionesMovimientos(ByVal objNeumatico As e_Neumatico) As Boolean
        Try
            If olNeumatico.Listar(oeNeumatico).Count > 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub CargarPreRegistro(ByVal lePre As List(Of e_DetalleOrdenNeumatico))
        Try
            With griPreRegistro

                .DataSource = lePre

                For Each col In .DisplayLayout.Bands(0).Columns
                    If col.Key = "Confirmacion" Then
                        col.CellActivation = Activation.AllowEdit
                        col.CellClickAction = CellClickAction.Edit
                    Else
                        col.CellActivation = Activation.NoEdit
                        col.CellClickAction = CellClickAction.RowSelect
                    End If
                Next

                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdOrdenMaterial").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdNeumatico").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaConfirmacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True

                .DisplayLayout.Bands(0).Columns("Confirmacion").Header.VisiblePosition = 1

                .DisplayLayout.Bands(0).Columns("CodNeumatico").Header.Caption = "Pre - Codigo"

                .DisplayLayout.Bands(0).Columns("Confirmacion").Style = ColumnStyle.CheckBox

                .DisplayLayout.Bands(0).Columns("Descripcion").Width = 350

                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

            End With

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarDatosNeu(ByVal oeNeu As e_Neumatico)
        txtCodigo.Text = oeNeu.Codigo
        fecIngreso.Value = oeNeu.FechaIngreso
        cmbMaterial.Value = oeNeu.IdMaterial
        cmbMarca.Value = oeNeu.IdMarca
        cmbDiseño.Value = oeNeu.IdDiseño
        ndCostoSoles.Value = oeNeu.CostoTotalSoles
        ndCostoDolares.Value = oeNeu.CostoTotalDolares
        ndCostoCascoDolares.Value = oeNeu.CostoCascoDolares
        ndCocadaMinima.Value = oeNeu.CocadaMinima
        ndKilometraje.Value = oeNeu.KilometrajeActual
        cmbProveedor.Value = oeNeu.IdProveedor
        verActivo.Checked = oeNeu.Activo
        cboTipoBanda.Text = oeNeu.TipoBanda
        txtDOT.Text = oeNeu.DOT
        If Not bandConf Then ObtenerPrimeraVidaNeumatico()
        leVidaNeumatico = oeNeu.leVidaNeu
        leOperacionNeu = oeNeu.leOperacionNeu
        CargarVidaNeu(leVidaNeumatico)
        CargarOperacionNeu(New List(Of e_OperacionNeumatico))
    End Sub

    Private Function ValidaVidaNeu(ByVal oeVidaNeu As e_VidaNeumatico) As Boolean
        Try
            If cmbMarca.SelectedIndex = -1 Then Throw New Exception("Seleccione Marca de Neumatico")
            If cmbDiseño.SelectedIndex = -1 Then Throw New Exception("Seleccione Diseño de Neumatico")
            If ndCostoSoles.Value = 0 Then Throw New Exception("Ingrese Costo Original en Soles de Neumatico")
            If ndCostoDolares.Value = 0 Then Throw New Exception("Ingrese Costo Original en Dolares de Neumatico")
            If ndKilometraje.Value = 0 Then Throw New Exception("Ingrese Kilometraje Recorrido de Neumatico")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Eventos"

    Private Sub cmbMaterial_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbMaterial.KeyDown
        If e.KeyCode = Keys.Enter Then
            ListarMateriales()
        End If
    End Sub

    Private Sub cmbMaterial_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cmbMaterial.InitializeLayout

        Me.cmbMaterial.ValueMember = "Id"
        Me.cmbMaterial.DisplayMember = "Nombre"

        With cmbMaterial.DisplayLayout.Bands(0)
            .Columns("Id").Hidden = True
            .Columns("Codigo").Hidden = True
            .Columns("Seleccion").Hidden = True
            .Columns("CodigoNombre").Hidden = True
            .Columns("IdTipoMaterial").Hidden = True
            .Columns("IndDivisible").Hidden = True
            .Columns("TipoMaterial").Hidden = True
            .Columns("IdFamilia").Hidden = True
            .Columns("Familia").Hidden = True
            .Columns("IdSubFamilia").Hidden = True
            .Columns("SubFamilia").Hidden = True
            .Columns("IdTipoUnidadMedida").Hidden = True
            .Columns("TipoUnidadMedida").Hidden = True
            .Columns("IdUnidadMedida").Hidden = True
            .Columns("UnidadMedida").Hidden = True
            .Columns("Medida").Hidden = True
            .Columns("Peso").Hidden = True
            .Columns("Serial").Hidden = True
            .Columns("AfectoIgv").Hidden = True
            .Columns("Glosa").Hidden = True
            .Columns("Activo").Hidden = True
            .Columns("IdSubAlmacen").Hidden = True
            .Columns("SubAlmacen").Hidden = True
            .Columns("IdAlmacen").Hidden = True
            .Columns("Almacen").Hidden = True
            .Columns("Precio").Hidden = True
            .Columns("Stock").Hidden = True
            .Columns("Ubicacion").Hidden = True
            .Columns("IndActivoFijo").Hidden = True
        End With
    End Sub

    Private Sub cmbMarca_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMarca.ValueChanged
        If cmbMarca.SelectedIndex <> -1 Then
            oeNeumatico.IdMarca = cmbMarca.Value
            Dim _leDiseñoAux = leDiseño.Where(Function(it) it.IdMarca = cmbMarca.Value).ToList
            LlenarComboMaestro(cmbDiseño, _leDiseñoAux, -1)
            txtMedida.Value = String.Empty
            txtTipoNeumatico.Value = String.Empty
        End If
    End Sub

    Private Sub cmbDiseño_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDiseño.ValueChanged
        If cmbDiseño.SelectedIndex <> -1 Then
            oeNeumatico.IdDiseño = cmbDiseño.Value
            CargarRibetesSegunDiseño()
        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            Dim codigo As String = ""
            If String.IsNullOrEmpty(Me.txtCodigoAgregar.Text) Then
                Me.txtCodigoAgregar.Focus()
                Throw New Exception("Ingrese el código de neumático")
            Else
                If Me.lstCodigos.Items.Count + 1 <= neCantidad.Value Then
                    Dim cant As Integer = Me.neCantidad.Value - (lstCodigos.Items.Count)
                    If MessageBox.Show("¿Desea autogenerar los códigos?", "AYUDA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        For x As Integer = 1 To cant
                            codigo = r_FormatoCodigo(8, "", Trim(txtCodigoAgregar.Text), "")
                            txtCodigoAgregar.Text = txtCodigoAgregar.Text + 1
                            If VerificarCodioInterno(codigo) Then
                                lstCodigos.Items.Add(codigo)
                            Else
                                txtCodigoAgregar.Text = CInt(lstCodigos.Items(lstCodigos.Items.Count - 1) + 1)
                            End If
                        Next
                        ndCostoSoles.Focus()
                    End If
                Else
                    Throw New Exception("Ha superado el número de neumáticos a ingresar")
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        Quitar()
    End Sub

    Private Sub cmbMaterial_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMaterial.ValueChanged
        Try
            If cmbMaterial.Value IsNot Nothing AndAlso cmbMaterial.Value.ToString.Trim <> "" Then
                Dim _leMatNeu = leMaterial.Where(Function(it) it.Id = cmbMaterial.Value).ToList
                If _leMatNeu.Count > 0 Then
                    oeNeumatico.IdMaterial = cmbMaterial.Value
                    'Else
                    '    Throw New Exception("Elija un Material para Neumatico")
                End If
            End If

            If Operacion = "Nuevo" AndAlso cmbMaterial.Value IsNot Nothing AndAlso cmbMaterial.Value.ToString.Trim <> "" Then
                If cmbMaterial.Value.ToString.Trim.Length = 12 Then
                    Dim _nro As Integer = 0
                    Dim _id As String = cmbMaterial.Value.ToString.Trim
                    _id = _id.Substring(4)
                    _nro = CInt(_id)
                    If _nro > 0 Then
                        oeMaterial = New e_Material
                        oeMaterial.TipoOperacion = "G"
                        oeMaterial.Id = cmbMaterial.Value.ToString.Trim
                        oeMaterial = olMaterial.ObtenerMatNeu(oeMaterial)
                        If oeMaterial IsNot Nothing AndAlso oeMaterial.Id.Trim <> "" Then
                            oeMatDiseno = New e_Material_DisenoNeu
                            oeMatDiseno = oeMaterial.oeMaterial_DisenoNeu
                            If oeMatDiseno IsNot Nothing AndAlso oeMatDiseno.IdDisenoNeumatico.Trim <> "" Then
                                Dim _leAux = leDiseño.Where(Function(it) it.Id = oeMatDiseno.IdDisenoNeumatico).ToList
                                If _leAux.Count > 0 Then
                                    cmbMarca.Value = _leAux(0).IdMarca
                                    cmbDiseño.Value = _leAux(0).Id
                                    cboTipoBanda.SelectedIndex = -1
                                End If
                            Else
                                cmbMarca.SelectedIndex = -1
                                cmbDiseño.SelectedIndex = -1
                                cboTipoBanda.SelectedIndex = -1
                                txtTipoNeumatico.Text = String.Empty
                                txtMedida.Text = String.Empty
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cmbProveedor_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProveedor.ValueChanged
        oeNeumatico.IdProveedor = cmbProveedor.Value
    End Sub

    Private Sub fecIngreso_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecIngreso.ValueChanged
        oeNeumatico.FechaIngreso = fecIngreso.Value
    End Sub

    Private Sub ndCostoSoles_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndCostoSoles.Validated
        If Not IsDBNull(ndCostoSoles.Value) AndAlso ndCostoSoles.Value > 0 Then
            ndCostoDolares.Value = Math.Round((ndCostoSoles.Value / _TipoCambio), 2)
        Else
            ndCostoSoles.Value = 0
        End If
    End Sub

    Private Sub ndCostoDolares_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndCostoDolares.Validated
        If Not IsDBNull(ndCostoDolares.Value) AndAlso ndCostoDolares.Value > 0 Then
            ndCostoSoles.Value = Math.Round((ndCostoDolares.Value * _TipoCambio), 2)
        Else
            ndCostoDolares.Value = 0
        End If
    End Sub

    Private Sub ndCostoSoles_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndCostoSoles.ValueChanged
        If Not String.IsNullOrEmpty(ndCostoSoles.Value.ToString) AndAlso IsNumeric(ndCostoSoles.Value.ToString) Then
            oeNeumatico.CostoTotalSoles = ndCostoSoles.Value
        Else
            oeNeumatico.CostoTotalSoles = 0
        End If
    End Sub

    Private Sub ndCostoDolares_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndCostoDolares.ValueChanged
        If Not String.IsNullOrEmpty(ndCostoDolares.Value.ToString) AndAlso IsNumeric(ndCostoDolares.Value.ToString) Then
            oeNeumatico.CostoTotalDolares = ndCostoDolares.Value
        Else
            oeNeumatico.CostoTotalDolares = 0
        End If
    End Sub

    Private Sub ndKilometraje_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndKilometraje.ValueChanged
        If Not String.IsNullOrEmpty(ndKilometraje.Value.ToString) AndAlso IsNumeric(ndKilometraje.Value.ToString) Then
            oeNeumatico.KilometrajeActual = ndKilometraje.Value
        Else
            oeNeumatico.KilometrajeActual = 0
        End If
    End Sub

    Private Sub frm_Neumatico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gmt_ConfigurarEventoKeyEnter_Tab(Me, cmbMaterial.Name)
            gf_AsignarEventoSeleccionarTexto(Me)
            olMarca = New l_Marca
            LlenaCombos()
            fecDesde.Value = Date.Today.AddDays(-7)
            fecHasta.Value = Date.Today
            colorMontaje.Color = Color.LightSteelBlue
            colorDesmontaje.Color = Color.NavajoWhite
            colorVenta.Color = Color.LightCyan
            cmbMaterial.Text = String.Empty
            cmbMaterial.DataSource = New List(Of e_Material)
            cmbMaterial.DataSource = leMaterial
            cmbMaterial.PerformAction(UltraComboAction.Dropdown)
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            tcNeumatico.Tabs(0).Enabled = True
            tcNeumatico.Tabs(1).Enabled = True
            tcNeumatico.Tabs(2).Enabled = False
            tcNeumatico.SelectedTab = tcNeumatico.Tabs(0)
            Tiempo1.Enabled = False
            CargarPreRegistro(New List(Of e_DetalleOrdenNeumatico))
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Neumatico_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_Neumatico_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            Me.Activate()
            Me.Cancelar()
        End If
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        oeNeumatico.Codigo = txtCodigo.Text
    End Sub

    Private Sub btnConsultarOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarOS.Click
        ListarOrdenesSalida()
    End Sub

    Private Sub griVidaNeumatico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griVidaNeumatico.Click
        Try
            If griVidaNeumatico.Rows.Count > 0 And griVidaNeumatico.Selected.Rows.Count > 0 Then
                If btnGrabarActKm.Enabled = True Then Throw New Exception("Tiene datos Pendientes por Grabar")
                _IdVidaNeu = griVidaNeumatico.ActiveRow.Cells("Id").Value
                Dim _leOperacion = leOperacionNeu.Where(Function(it) it.IdVidaNeumatico = _IdVidaNeu).ToList
                CargarOperacionNeu(_leOperacion)
                _kmVida = 0
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tcNeumatico_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles tcNeumatico.SelectedTabChanged
        Select Case tcNeumatico.SelectedTab.Index
            Case 0
                _Lista = "1"
                If grid_Neumatico.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
            Case 1
                _Lista = "2"
                If griPreRegistro.Rows.Count > 0 Then
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                Else
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                End If
        End Select
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        Nuevo()
        cmbMaterial.Value = grid_OrdenesSalida.ActiveRow.Cells("IdMaterial").Value.ToString
        cmbMaterial.Text = grid_OrdenesSalida.ActiveRow.Cells("Material").Value.ToString
        neCantidad.Value = grid_OrdenesSalida.ActiveRow.Cells("CantidadMaterial").Value.ToString
    End Sub

    Private Sub ndCostoCascoDolares_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndCostoCascoDolares.ValueChanged
        If Not String.IsNullOrEmpty(ndCostoCascoDolares.Value.ToString) AndAlso IsNumeric(ndCostoCascoDolares.Value.ToString) Then
            oeNeumatico.CostoCascoDolares = ndCostoCascoDolares.Value
        Else
            oeNeumatico.CostoCascoDolares = 0
        End If
    End Sub

    Private Sub cmbMaterial_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbMaterial.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cmbMaterial.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub CambiarCodigoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarCodigoToolStripMenuItem.Click
        Try
            Dim frm As frm_CambiarCodNeumatico
            frm = New frm_CambiarCodNeumatico(grid_Neumatico.ActiveRow.Cells("Id").Value.ToString, _
                                                      grid_Neumatico.ActiveRow.Cells("Codigo").Value.ToString)
            frm.StartPosition = FormStartPosition.CenterScreen

            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub grid_Neumatico_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grid_Neumatico.DoubleClickRow
        If grid_Neumatico.ActiveRow.Band.Index = 0 Then
            Editar()
        End If
    End Sub

    Private Sub mcNeumatico_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mcNeumatico.Opening
        If grid_Neumatico.ActiveRow.Band.Index <> 0 Then e.Cancel = True
    End Sub

    Private Sub NvoNeuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NvoNeuToolStripMenuItem.Click
        Nuevo()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        Editar()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar()
    End Sub

    Private Sub ndCocadaMinima_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndCocadaMinima.ValueChanged
        oeNeumatico.CocadaMinima = ndCocadaMinima.Value
    End Sub

    Private Sub optCondicion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCondicion.ValueChanged
        Select Case optCondicion.CheckedIndex
            Case 0, 1
                ndNroVida.Value = 1
                ndNroVida.Enabled = False
                btnGeneraVida.Enabled = False
                'ndCostoCascoDolares.Value = 0
                ' agrCodigoRee.Visible = False
            Case 2
                ndNroVida.Enabled = True
                ndNroVida.Value = 2
                btnGeneraVida.Enabled = True
                'ndCostoCascoDolares.Value = 70
                ' agrCodigoRee.Visible = True
                If Operacion = "Nuevo" Then
                    mensajeEmergente.Confirmacion("Para ingresar un nuevo Neumatico Reencauchado, debe generar una vida anterior", True)
                End If
        End Select
        'txtCodRee.Text = String.Empty
    End Sub

    Private Sub cboTipoBanda_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoBanda.ValueChanged
        oeNeumatico.TipoBanda = cboTipoBanda.Text.Trim
    End Sub

    Private Sub txtDOT_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDOT.ValueChanged
        If txtDOT.Text.Trim <> "" Then oeNeumatico.DOT = txtDOT.Text
    End Sub

    Private Sub griPreRegistro_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griPreRegistro.CellChange
        Try
            griPreRegistro.UpdateData()
            'If griPreRegistro.ActiveRow.Cells("Confirmacion").Value Then
            '    NroSel = griPreRegistro.Rows.Where(Function(it) it.Cells("Confirmacion").Value).ToList.Count
            '    If NroSel = 1 Then
            '        _descripcion = griPreRegistro.ActiveRow.Cells("Descripcion").Value
            '    Else
            '        If NroSel > 0 And _descripcion <> griPreRegistro.ActiveRow.Cells("Descripcion").Value Then
            '            griPreRegistro.ActiveRow.Cells("Confirmacion").Value = False
            '            griPreRegistro.UpdateData()
            '            Throw New Exception("Debe Elegir el mismo Diseño de Neumatico")
            '        End If
            '    End If
            'End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mcConfirmar_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mcConfirmar.Opening
        Try
            If griPreRegistro.Rows.Count > 0 Then
                mcConfirmar.Items("tsmiConfirmar").Visible = True
            Else
                mcConfirmar.Items("tsmiConfirmar").Visible = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiConfirmar.Click
        Try
            Dim idNeu As String = ""
            For Each fila In griPreRegistro.Rows
                If fila.Cells("Confirmacion").Value Then
                    bandConf = True
                    idNeu = idNeu & fila.Cells("IdNeumatico").Value & ","
                End If
            Next
            idNeu = Strings.Left(idNeu, idNeu.Length - 1)
            If Not bandConf Then
                Throw New Exception("Elija al menos un Neumatico para Confirmar!!!")
            Else
                If idNeu.Trim <> "" Then
                    Inicializar()
                    neCantidad.Value = NroSel
                    txtCodigoAgregar.Text = ObtenerUltimoCodigoNeumatico() + 1
                    oeNeumatico = New e_Neumatico
                    oeNeumatico.TipoOperacion = "A"
                    Dim cadena() As String = idNeu.Split(","c)
                    oeNeumatico.Id = cadena(0).ToString
                    oeNeumatico = olNeumatico.Obtener(oeNeumatico)
                    CargarDatosNeu(oeNeumatico)
                    oeNeumatico.oeDetalleOrdenNeu = New e_DetalleOrdenNeumatico
                    oeNeumatico.oeDetalleOrdenNeu.IdNeumatico = oeNeumatico.Id
                    oeNeumatico.oeDetalleOrdenNeu.Confirmacion = 1
                    oeNeumatico.oeDetalleOrdenNeu.TipoOperacion = "A"
                    oeNeumatico.TipoOperacion = "A"
                    tcNeumatico.Tabs(0).Enabled = False
                    tcNeumatico.Tabs(1).Enabled = False
                    tcNeumatico.Tabs(2).Enabled = True
                    tcNeumatico.SelectedTab = tcNeumatico.Tabs(2)
                    oeNeumatico.Id = idNeu
                    MyBase.Editar()
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griPreRegistro_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griPreRegistro.AfterCellUpdate
        Try
            If griPreRegistro.ActiveRow.Cells("Confirmacion").Value Then
                NroSel = griPreRegistro.Rows.Where(Function(it) it.Cells("Confirmacion").Value).ToList.Count
                If NroSel = 1 Then
                    _descripcion = griPreRegistro.ActiveRow.Cells("Descripcion").Value
                Else
                    If NroSel > 0 And _descripcion <> griPreRegistro.ActiveRow.Cells("Descripcion").Value Then
                        griPreRegistro.ActiveRow.Cells("Confirmacion").Value = False
                        griPreRegistro.UpdateData()
                        Throw New Exception("Debe Elegir el mismo Diseño de Neumatico")
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnGeneraVida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGeneraVida.Click
        Try
            oeVidaNeumatico = New e_VidaNeumatico
            oeVidaNeumatico.Id = ls_IdVidaNeumatico
            oeVidaNeumatico.NroVida = 1
            oeVidaNeumatico.FechaIngreso = fecIngreso.Value
            oeVidaNeumatico.Ribete1 = ndRibete1.Value
            oeVidaNeumatico.Ribete2 = ndRibete2.Value
            oeVidaNeumatico.Ribete3 = ndRibete3.Value
            oeVidaNeumatico.Cocada = ndCocada.Value
            oeVidaNeumatico.CocadaOriginal = ndCocadaOriginal.Value
            oeVidaNeumatico.Condicion = "NVO"
            oeVidaNeumatico.Kilometraje = ndKilometraje.Value
            oeVidaNeumatico.KmTotalNeumatico = ndKilometraje.Value
            oeVidaNeumatico.CostoSoles = ndCostoSoles.Value
            oeVidaNeumatico.CostoDolares = ndCostoDolares.Value
            oeVidaNeumatico.EstadoActual = "DES"
            oeVidaNeumatico.Ubicacion = "ALMACEN"
            oeVidaNeumatico.IdProveedor = ""
            oeVidaNeumatico.UsuarioCreacion = gUsuarioSGI.Id
            oeVidaNeumatico.IdDisenoNeu = cmbDiseño.Value
            oeVidaNeumatico.FechaFinVida = #1/1/1901#
            oeVidaNeumatico.Vigente = 0
            oeVidaNeumatico.Marca = cmbMarca.Text
            oeVidaNeumatico.Diseño = cmbDiseño.Text
            oeVidaNeumatico.Medida = txtMedida.Text
            oeVidaNeumatico.CostoCascoDolares = 0
            ValidaVidaNeu(oeVidaNeumatico)
            If MessageBox.Show("¿Desea Agregar los Datos Originales del Neumatico?", "Mensaje de Sistema" _
                               , MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                leVidaNeumatico.Add(oeVidaNeumatico)
                CargarVidaNeu(leVidaNeumatico)
                griVidaNeumatico.DataBind()
                mensajeEmergente.Confirmacion("Se ha Ingresado Correctamente los Datos de la Vida Anterior, " & _
                                              " ahora puede continuar con los datos del de su Vida Actual", True)
                ndCostoSoles.Value = 0
                ndCostoDolares.Value = 0
                ndCostoCascoDolares.Value = 0
                ndKilometraje.Value = 0
                btnGeneraVida.Enabled = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCalculaKmNeu_Click(sender As Object, e As EventArgs) Handles btnCalculaKmNeu.Click
        Try
            If _IdVidaNeu = "" Then Throw New Exception("Seleccione un Vida de Neumatico para Efectuar Operacion")
            If MessageBox.Show("¿Desea Recalcular Kilometraje de la Vida Neumatico?", "Mensaje de Sistema", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim _leOpeNeu = leOperacionNeu.Where(Function(it) it.IdVidaNeumatico = _IdVidaNeu).ToList
                If _leOpeNeu.Count = 0 Then Throw New Exception("Esta Vida del Neumatico no Tiene ninguna operacion")
                Dim _idVeh As String = "", _KmVehIni As Double = 0, _kmNeuIni As Double = 0, _OpePriVeh As Boolean = False, _band As Boolean = False
                _kmVida = 0
                For Each oeOpeNeuAux In _leOpeNeu.OrderBy(Function(it) it.FechaOperacion).ToList
                    oeOperacionNeu = New e_OperacionNeumatico
                    oeOperacionNeu.Equivale = 1
                    oeOperacionNeu.Id = oeOpeNeuAux.Id
                    If leOperacionNeu.Contains(oeOperacionNeu) Then
                        oeOperacionNeu = leOperacionNeu.Item(leOperacionNeu.IndexOf(oeOperacionNeu))
                        oeOperacionNeu.TipoOperacion = "A"
                    End If
                    If _idVeh <> oeOpeNeuAux.IdVehiculo Then
                        _idVeh = oeOpeNeuAux.IdVehiculo
                        _OpePriVeh = False
                    End If
                    If oeOpeNeuAux.Posicion < 0 Then _OpePriVeh = False
                    If Not _OpePriVeh Then
                        _OpePriVeh = True
                        If Not _band Then _kmNeuIni = oeOpeNeuAux.KmNeumatico
                        _KmVehIni = oeOpeNeuAux.KmVehiculo
                        oeOperacionNeu.KmNeumatico = _kmNeuIni
                    Else
                        oeOperacionNeu.KmNeumatico = _kmNeuIni + (oeOpeNeuAux.KmVehiculo - _KmVehIni)
                        _kmNeuIni = _kmNeuIni + (oeOpeNeuAux.KmVehiculo - _KmVehIni)
                        _KmVehIni = oeOpeNeuAux.KmVehiculo
                    End If
                    _band = True
                Next
                _kmVida = _kmNeuIni
                Dim _leAux = leOperacionNeu.Where(Function(it) it.IdVidaNeumatico = _IdVidaNeu).ToList
                CargarOperacionNeu(_leAux)
                btnGrabarActKm.Enabled = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnGrabarActKm_Click(sender As Object, e As EventArgs) Handles btnGrabarActKm.Click
        Try
            If MessageBox.Show("¿Desea Grabar Los Datos de la Vida Neumatico?", "Mensaje de Sistema", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim oeVidaAux = New e_VidaNeumatico
                oeVidaAux.Id = _IdVidaNeu
                If leVidaNeumatico.Contains(oeVidaAux) Then
                    oeVidaAux = leVidaNeumatico.Item(leVidaNeumatico.IndexOf(oeVidaAux))
                    oeVidaAux.TipoOperacion = "K"
                    oeVidaAux.Kilometraje = _kmVida
                End If
                oeVidaAux.leOpeNeuAux = leOperacionNeu.Where(Function(it) it.TipoOperacion = "A").ToList
                If olVidaNeumatico.ActualizaKM(oeVidaAux) Then
                    Dim _oeVNAux = New e_VidaNeumatico
                    _oeVNAux.TipoOperacion = "L"
                    _oeVNAux.IdNeumatico = oeNeumatico.Id
                    _oeVNAux.Activo = True
                    leVidaNeumatico = New List(Of e_VidaNeumatico)
                    leVidaNeumatico = olVidaNeumatico.Listar(_oeVNAux)
                    Dim _oeONAux = New e_OperacionNeumatico
                    _oeONAux.TipoOperacion = "L"
                    _oeONAux.IdVidaNeumatico = oeNeumatico.Id
                    _oeONAux.Activo = True
                    leOperacionNeu = New List(Of e_OperacionNeumatico)
                    leOperacionNeu = olOperacionNeu.Listar(_oeONAux)
                    CargarVidaNeu(leVidaNeumatico)
                    ndKilometraje.Value = leVidaNeumatico.Sum(Function(it) it.Kilometraje)
                    btnGrabarActKm.Enabled = False
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griOperacionNeumatico_DoubleClickCell(sender As Object, e As DoubleClickCellEventArgs) Handles griOperacionNeumatico.DoubleClickCell
        Try
            With griOperacionNeumatico
                If .ActiveRow.Index > -1 Then
                    Select Case .ActiveCell.Column.Key
                        Case "KmVehiculo"
                            Dim _kmAux As String
                            _kmAux = InputBox("Ingrese Kilometraje:", "Mensaje de Sistema", .ActiveRow.Cells("KmVehiculo").Value)
                            If Not IsNumeric(_kmAux) Then Throw New Exception("Solo se Permite Ingresar Números")
                            If _kmAux < 0 Then Throw New Exception("Debe Ingresar un Km mayor a Cero")
                            .ActiveRow.Cells("KmVehiculo").Value = _kmAux
                            .UpdateData()
                            'ndTotal.Value = leDetallePlaVac.Sum(Function(it) it.TotalPagar)
                    End Select
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboEstado_ValueChanged(sender As Object, e As EventArgs) Handles cboEstado.ValueChanged
        cboFlota.SelectedIndex = 0 : cboVehiculo.SelectedIndex = 0
        cboFlota.ReadOnly = IIf(cboEstado.Text = "MON", False, True)
        cboVehiculo.ReadOnly = IIf(cboEstado.Text = "MON", False, True)
    End Sub

    Private Sub cboFlota_ValueChanged(sender As Object, e As EventArgs) Handles cboFlota.ValueChanged
        Try
            Dim _leVehAux As New List(Of e_Vehiculo)
            oeVehiculo = New e_Vehiculo
            oeVehiculo.Id = String.Empty : oeVehiculo.Placa = "[ TODOS ]"
            _leVehAux.Add(oeVehiculo)
            If cboFlota.SelectedIndex > 0 Then _leVehAux.AddRange(leVehiculo.Where(Function(it) it.IdFlota = cboFlota.Text).ToList)
            LlenarCombo(cboVehiculo, "Placa", _leVehAux, 0)
            'cboVehiculo.SelectedIndex = 0
            cboVehiculo.ReadOnly = IIf(cboFlota.SelectedIndex = 0, True, False)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboLugar_ValueChanged(sender As Object, e As EventArgs) Handles cboLugar.ValueChanged
        cboAlmacen.SelectedIndex = 0
        cboAlmacen.ReadOnly = IIf(cboLugar.SelectedIndex = 0, False, True)
        oeVidaNeumatico.IndLugar = cboLugar.SelectedIndex
    End Sub

    'Private Sub btnGeneraVida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGeneraVida.Click
    '    Try
    '        If MessageBox.Show("¿Desea crear Vida al Neumatico?", "Mensaje de Sistema" _
    '                           , MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
    '            oeVidaNeumatico = New e_VidaNeumatico
    '            oeVidaNeumatico.IdNeumatico = oeNeumatico.Id
    '            oeVidaNeumatico.Vigente = 1
    '            oeVidaNeumatico.FechaIngreso = oeNeumatico.FechaIngreso
    '            oeVidaNeumatico.Ribete1 = ndRibete1.Value
    '            oeVidaNeumatico.Ribete2 = ndRibete2.Value
    '            oeVidaNeumatico.Ribete3 = ndRibete3.Value
    '            oeVidaNeumatico.Ribete4 = 0
    '            oeVidaNeumatico.Cocada = ndCocada.Value
    '            oeVidaNeumatico.CocadaMinima = ndCocadaMinima.Value
    '            oeVidaNeumatico.CocadaOriginal = ndCocadaOriginal.Value
    '            oeVidaNeumatico.CostoSoles = oeNeumatico.CostoTotalSoles
    '            oeVidaNeumatico.CostoDolares = oeNeumatico.CostoTotalDolares
    '            oeVidaNeumatico.NroVida = 1
    '            oeVidaNeumatico.Ubicacion = "ALMACEN"
    '            oeVidaNeumatico.EstadoActual = "DES"
    '            oeVidaNeumatico.Condicion = "NVO"
    '            oeVidaNeumatico.Marca = cmbMarca.Text
    '            oeVidaNeumatico.Diseño = cmbDiseño.Text
    '            oeVidaNeumatico.Medida = txtMedida.Text
    '            leVidaNeumatico.Add(oeVidaNeumatico)

    '            CargarVidaNeu(leVidaNeumatico)

    '            griVidaNeumatico.DataBind()

    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub frm_Neumatico_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

#End Region

    Private Sub btnCorregirKmGeneral_Click(sender As Object, e As EventArgs) Handles btnCorregirKmGeneral.Click
        Try
            If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "ACTUALIZAR KM NEUMATICO") Then
                ugb_Espera.Visible = True
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                If MessageBox.Show("¿Desea actualizar el Km de todos los Neumaticos?", "Mensaje de Sistema", _
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    olNeumatico.ActualizarKmGeneral()
                    mensajeEmergente.Confirmacion("Se actualizo correctamente los Km.", True)
                End If
            Else
                Throw New Exception("No Tiene Permiso para Actualizar Km")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Cursor = Cursors.Default
            ugb_Espera.Visible = False
            grid_Neumatico.Focus()
        End Try


    End Sub

End Class
