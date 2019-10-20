'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF
Imports ISL.Controles

Public Class frm_VidaNeumatico

#Region "Instancia"

    Sub New(ByVal ls_IdNeumatico As String, ByVal ls_CodigoNeu As String, ByVal ls_IdVidaNeumatico As String, _
            ByVal ls_EstadoInicial As String, ln_Lugar As Integer, ln_Log As Integer)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _IdNeumatico = ls_IdNeumatico
        _EstadoInicial = ls_EstadoInicial
        _CodigoNeu = ls_CodigoNeu
        _IdVidaNeumatico = ls_IdVidaNeumatico
        _indLugar = ln_Lugar
        _indLog = ln_Log
    End Sub

#End Region

#Region "Declaracion de variables"

    Dim oeVidaNeumatico As New e_VidaNeumatico, olVidaNeumatico As New l_VidaNeumatico
    Dim oeMovimientoNeumatico As New e_MovimientoNeumatico, olMovimientoNeumatico As New l_MovimientoNeumatico
    Dim _IdNeumatico As String
    Dim _CodigoNeu As String
    Dim _IdVidaNeumatico As String
    Dim _EstadoInicial As String
    Dim _TipoCambio As Double = 0
    Dim _indLugar As Integer, _indLog As Integer
    Dim oeOperacionNeu As New e_OperacionNeumatico, olOperacionNeu As New l_OperacionNeumatico
    Dim oeVehiculo As New e_Combo, olVehiculo As New l_Combo, leVehiculo As New List(Of e_Combo)
    Dim oeTrabajador As New e_Trabajador, olTrabajador As New l_Trabajador, leTrabajador As New List(Of e_Trabajador)
    Dim _idOpeNeuUtl As String

    Dim oeMaterialNeu As New e_Material, olMaterialNeu As New l_Material, leMaterialNeu As New List(Of e_Material)
    Dim oeMarcaNeu As New e_Marca, olMarcaNeu As New l_Marca, leMarcaNeu As New List(Of e_Marca)
    Dim oeDiseñoNeu As New e_DiseñoNeumatico, olDiseñoNeu As New l_DiseñoNeumatico, leDiseñoNeu As New List(Of e_DiseñoNeumatico)
    Dim oeMedidaNeu As New e_MedidaNeumatico, olMedidaNeu As New l_MedidaNeumatico, leMedidaNeu As New List(Of e_MedidaNeumatico)
    Dim oeNeumatico As New e_Neumatico, olNeumatico As New l_Neumatico, leNeumatico As New List(Of e_Neumatico)
    Dim oeProveedor As New e_Proveedor, olProveedor As New l_Proveedor, leProveedor As New List(Of e_Proveedor)
    Dim oeMatDiseño As New e_Material_DisenoNeu

    Dim loConcepto As New l_Concepto
    Dim oeConcepto As New e_Concepto
    Dim ListaConcepto As New List(Of e_Concepto)

#End Region

#Region "Eventos"

    Private Sub frm_VidaNeumatico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gmt_ConfigurarEventoKeyEnter_Tab(Me)
            gf_AsignarEventoSeleccionarTexto(Me)
            CargarCombo()
            CargarDatosComplementarios()
            dtpFechaIng.Value = Date.Now
            txtCodigo.Text = _CodigoNeu
            ndTipoCambio.Value = TipoCambio(Date.Now, 1)(0)
            Habilitar()
            ndCostoSoles.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            AsignarVidaNeumatico()
            If chkCancelaRee.Checked Then ValidaVidaNeu(oeVidaNeumatico)
            If MessageBox.Show("¿Desea Guardar la Operacion Realizada?", "Mensaje de Sistema" _
                               , MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                oeVidaNeumatico.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeVidaNeumatico = olVidaNeumatico.Guardar(oeVidaNeumatico)
                GenerarMovimiento(oeVidaNeumatico.Id)
                MessageBox.Show("Registrado correctamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub ndCostoDolares_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndCostoDolares.Validated
        ndCostoSoles.Value = Math.Round((ndCostoDolares.Value * ndTipoCambio.Value), 2)
    End Sub

    Private Sub ndCostoSoles_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndCostoSoles.Validated
        ndCostoDolares.Value = Math.Round((ndCostoSoles.Value / ndTipoCambio.Value), 2)
    End Sub

    Private Sub dtpFechaIng_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaIng.ValueChanged
        ndTipoCambio.Value = TipoCambio(dtpFechaIng.Value)(0)
    End Sub

    Private Sub cboVehiculo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVehiculo.ValueChanged
        Try
            If cboVehiculo.SelectedIndex > -1 Then
                oeVehiculo = New e_Combo
                oeVehiculo = cboVehiculo.Items(cboVehiculo.SelectedIndex).ListObject
                txtTipoVehiculo.Text = IIf(oeVehiculo.Descripcion = "1", "TRACTO", "CARRETA")
            Else
                txtTipoVehiculo.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub cboMaterial_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMaterial.ValueChanged
        Try
            If cboMaterial.Value IsNot Nothing AndAlso cboMaterial.Value.ToString.Trim <> "" Then
                oeMaterialneu = New e_Material
                oeMaterialneu.TipoOperacion = "G"
                oeMaterialneu.Id = cboMaterial.Value.ToString.Trim
                oeMaterialNeu = olMaterialNeu.ObtenerMatNeu(oeMaterialNeu)
                oeMatDiseño = New e_Material_DisenoNeu
                oeMatDiseño = oeMaterialNeu.oeMaterial_DisenoNeu
                If oeMatDiseño IsNot Nothing AndAlso oeMatDiseño.IdDisenoNeumatico.Trim <> "" Then
                    Dim _leAux = leDiseñoNeu.Where(Function(it) it.Id = oeMatDiseño.IdDisenoNeumatico).ToList
                    If _leAux.Count > 0 Then
                        cboMarca.Value = _leAux(0).IdMarca
                        cboMedida.Value = _leAux(0).IdMedidaNeumatico
                        cboDiseño.Value = _leAux(0).Id
                        'cboTipoBanda.Text = oeMatDiseño.TipoBanda
                        'cboTipoBanda.SelectedIndex = -1
                    End If
                Else
                    cboMarca.SelectedIndex = -1
                    cboMedida.SelectedIndex = -1
                    cboDiseño.SelectedIndex = -1
                    'cboTipoBanda.SelectedIndex = -1
                    'cboTipoBanda.SelectedIndex = -1
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub cboMarca_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMarca.ValueChanged
        If cboMarca.SelectedIndex > -1 Then
            Dim _leMedida = leMedidaNeu.Where(Function(it) it.UsuarioCreacion = cboMarca.Value).ToList
            LlenarCombo(cboMedida, "Nombre", _leMedida, -1)
        End If
    End Sub

    Private Sub cboMedida_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMedida.ValueChanged
        Try
            If cboMedida.SelectedIndex > -1 Then
                Dim _leDiseno = leDiseñoNeu.Where(Function(it) it.IdMarca = cboMarca.Value And it.IdMedidaNeumatico = cboMedida.Value).ToList
                LlenarCombo(cboDiseño, "Nombre", _leDiseno, -1)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboDiseño_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDiseño.ValueChanged
        If _EstadoInicial = "REENCAUCHE" Then
            Dim _leDisR = leDiseñoNeu.Where(Function(it) it.Id = cboDiseño.Value)
            If _leDisR.Count > 0 Then
                ndRibete1.Value = _leDisR(0).Ribete1
                ndRibete2.Value = _leDisR(0).Ribete2
                ndRibete3.Value = _leDisR(0).Ribete3
                ndCocada.Value = _leDisR(0).Cocada
            End If
        End If
    End Sub

    Private Sub chkCancelaRee_CheckedChanged(sender As Object, e As EventArgs) Handles chkCancelaRee.CheckedChanged
        Try
            If Not chkCancelaRee.Checked Then
                If MessageBox.Show("¿Desea No Generar Vida al Neumatico?", "Mensaje de Sistema", _
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim formulario As frm_AutenticarTrabajador
                    formulario = New frm_AutenticarTrabajador
                    formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                    If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                        _EstadoInicial = "REENCAUCHE"
                        Habilitar()
                        chkCancelaRee.Checked = True
                        ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                        Throw New Exception("Ingrese un Clave Correcta")
                    Else
                        _EstadoInicial = "REPARACION"
                        Habilitar()
                    End If
                Else
                    _EstadoInicial = "REENCAUCHE"
                    Habilitar()
                    chkCancelaRee.Checked = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Sistema")
        End Try
    End Sub

    Private Sub cboLugarOpe_ValueChanged(sender As Object, e As EventArgs) Handles cboLugarOpe.ValueChanged
        cboAlmacenOpe.SelectedIndex = 0
        cboAlmacenOpe.ReadOnly = IIf(cboLugarOpe.SelectedIndex = 0, False, True)
        oeVidaNeumatico.IndLugar = cboLugarOpe.SelectedIndex
    End Sub

    Private Sub cboAlmacenOpe_ValueChanged(sender As Object, e As EventArgs) Handles cboAlmacenOpe.ValueChanged
        oeVidaNeumatico.IndLog = cboAlmacenOpe.SelectedIndex
    End Sub

#End Region

#Region "Metodos"

    Private Sub AsignarVidaNeumatico()
        oeVidaNeumatico = New e_VidaNeumatico
        Select Case _EstadoInicial
            Case "REENCAUCHE"
                oeVidaNeumatico.TipoOperacion = "I"
            Case "REPARACION"
                oeVidaNeumatico.TipoOperacion = "R"
                oeVidaNeumatico.Id = _IdVidaNeumatico
        End Select
        oeVidaNeumatico.IdNeumatico = _IdNeumatico
        oeVidaNeumatico.FechaIngreso = dtpFechaIng.Value
        oeVidaNeumatico.Ribete1 = ndRibete1.Value
        oeVidaNeumatico.Ribete2 = ndRibete2.Value
        oeVidaNeumatico.Ribete3 = ndRibete3.Value
        oeVidaNeumatico.Cocada = ndCocada.Value
        oeVidaNeumatico.CocadaOriginal = ndCocada.Value
        oeVidaNeumatico.Condicion = "REE"
        oeVidaNeumatico.Kilometraje = 0
        oeVidaNeumatico.CostoSoles = ndCostoSoles.Value
        oeVidaNeumatico.CostoDolares = ndCostoDolares.Value
        oeVidaNeumatico.EstadoActual = "DES"
        oeVidaNeumatico.Ubicacion = "ALMACEN"
        oeVidaNeumatico.IndLugar = cboLugarOpe.SelectedIndex
        oeVidaNeumatico.IndLog = cboAlmacenOpe.SelectedIndex
        oeVidaNeumatico.IdProveedor = cboProveedor.Value
        oeVidaNeumatico.UsuarioCreacion = gUsuarioSGI.Id
        oeVidaNeumatico.Vigente = 1
        oeVidaNeumatico.IdDisenoNeu = cboDiseño.Value
        oeVidaNeumatico.ls_IdMaterial = cboMaterial.Value
        oeVidaNeumatico.Marca = cboTipoBanda.Text.Trim 'para actualizar tipo banda
    End Sub

    Private Sub GenerarMovimiento(ByVal ls_IdVidaNeumatico As String)
        Try
            oeMovimientoNeumatico = New e_MovimientoNeumatico
            oeMovimientoNeumatico.TipoOperacion = "I"
            oeMovimientoNeumatico.UsuarioCreacion = gUsuarioSGI.Id
            oeMovimientoNeumatico.Activo = True
            oeMovimientoNeumatico.EstadoInicial = _EstadoInicial
            oeMovimientoNeumatico.EstadoFinal = "ALMACEN"
            oeMovimientoNeumatico.IdMotivo = ""
            oeMovimientoNeumatico.IdOperacionNeumatico = _idOpeNeuUtl
            oeMovimientoNeumatico.CostoSoles = ndCostoSoles.Value
            oeMovimientoNeumatico.IdVehiculo = cboVehiculo.Value
            oeMovimientoNeumatico.IdConductor = cboConductor.Value
            oeMovimientoNeumatico.IdTecnicoNeu = cboTecnico.Value
            oeMovimientoNeumatico.IdVidaNeumatico = ls_IdVidaNeumatico
            oeMovimientoNeumatico.IndVigente = 1
            oeMovimientoNeumatico.PrefijoID = gs_PrefijoIdSucursal '@0001
            olMovimientoNeumatico.Guardar(oeMovimientoNeumatico)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarCombo()
        Try
            oeVehiculo = New e_Combo
            oeVehiculo.Nombre = "Vehiculo"
            leVehiculo = olVehiculo.Listar(oeVehiculo).OrderBy(Function(it) it.Nombre).ToList
            LlenarCombo(cboVehiculo, "Nombre", leVehiculo, -1)

            LlenarCombo(cboConductor, "Nombre", PilotoPublic, -1)

            oeTrabajador = New e_Trabajador
            oeTrabajador.Id = "NO ASIGNADO"
            oeTrabajador.oePersona.ApellidoPaterno = "NO ASIGNADO"
            oeTrabajador.oeArea.Nombre = "MANTENIMIENTO"
            oeTrabajador.Disponible = True
            oeTrabajador.IndEstado = 1
            leTrabajador.Add(oeTrabajador)
            oeTrabajador = New e_Trabajador
            oeTrabajador.TipoOperacion = "N"
            leTrabajador.AddRange(olTrabajador.Listar(oeTrabajador).Where(Function(it) it.oeArea.Nombre = "MANTENIMIENTO").OrderBy(Function(it) it.oePersona.NombreCompleto).ToList)
            Dim _leTrab = leTrabajador
            Dim _leTrabAux = From le In _leTrab _
                             Where le.Disponible = True And le.IndEstado > 0 _
                             Select le.Id, le.oePersona.NombreCompleto, le.oePersona.Dni

            LlenarCombo(cboTecnico, "NombreCompleto", _leTrabAux.ToList, 0)

            oeMaterialNeu = New e_Material
            oeMaterialNeu.TipoOperacion = "N"
            oeMaterialNeu.Activo = 1
            leMaterialNeu = olMaterialNeu.Listar(oeMaterialNeu)

            LlenarCombo(cboMaterial, "Nombre", leMaterialNeu.OrderBy(Function(it) it.Nombre).ToList, -1)

            oeProveedor = New e_Proveedor
            oeProveedor.Id = ""
            oeProveedor.Nombre = "NINGUNO"
            leProveedor.Add(oeProveedor)
            oeProveedor = New e_Proveedor
            oeProveedor.Activo = True
            leProveedor.AddRange(olProveedor.Listar(oeProveedor))
            LlenarCombo(cboProveedor, "Nombre", leProveedor, 0)

            oeMarcaNeu = New e_Marca
            oeMarcaNeu.Activo = True
            oeMarcaNeu.TipoOperacion = "L"
            leMarcaNeu = olMarcaNeu.Listar(oeMarcaNeu)
            LlenarCombo(cboMarca, "Nombre", leMarcaNeu, -1)

            oeMedidaNeu = New e_MedidaNeumatico
            oeMedidaNeu.TipoOperacion = "N"
            leMedidaNeu = olMedidaNeu.Listar(oeMedidaNeu)

            oeDiseñoNeu = New e_DiseñoNeumatico
            oeDiseñoNeu.Activo = True
            leDiseñoNeu = olDiseñoNeu.Listar(oeDiseñoNeu)

            'cboTipoBanda.Items.Clear()
            'cboTipoBanda.Items.Add(0, "DIRECCIONAL")
            'cboTipoBanda.Items.Add(1, "TRACCION")
            'cboTipoBanda.Items.Add(2, "MIXTA")
            'cboTipoBanda.Items.Add(3, "PISTERA")
            'cboTipoBanda.SelectedIndex = -1

            cboLugarOpe.Items.Clear()
            cboLugarOpe.Items.Add("PACASMAYO")
            cboLugarOpe.Items.Add("LIMA")
            cboLugarOpe.Items.Add("CHICLAYO")
            cboLugarOpe.Items.Add("PIURA")
            cboLugarOpe.SelectedIndex = -1

            cboAlmacenOpe.Items.Clear()
            cboAlmacenOpe.Items.Add("STAND-BY")
            cboAlmacenOpe.Items.Add("STOCK")
            cboAlmacenOpe.SelectedIndex = 0

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

    Private Sub CargarDatosComplementarios()
        Try

            oeOperacionNeu = New e_OperacionNeumatico
            oeOperacionNeu.TipoOperacion = "U"
            oeOperacionNeu.IdVidaNeumatico = _IdVidaNeumatico
            oeOperacionNeu = olOperacionNeu.Obtener(oeOperacionNeu)
            If oeOperacionNeu IsNot Nothing AndAlso oeOperacionNeu.IdVehiculo <> "" Then
                cboVehiculo.Value = oeOperacionNeu.IdVehiculo
                _idOpeNeuUtl = oeOperacionNeu.Id
                If _EstadoInicial = "REPARACION" Then
                    ndRibete1.Value = oeOperacionNeu.Ribete1
                    ndRibete2.Value = oeOperacionNeu.Ribete2
                    ndRibete3.Value = oeOperacionNeu.Ribete3
                    ndCocada.Value = oeOperacionNeu.Cocada
                End If
            End If

            oeOperacionNeu = New e_OperacionNeumatico
            oeOperacionNeu.TipoOperacion = "O"
            oeOperacionNeu.IdVehiculo = cboVehiculo.Value
            oeOperacionNeu.IndMontaje = IIf(txtTipoVehiculo.Text <> "TRACTO", 0, 1)
            oeOperacionNeu = olOperacionNeu.Obtener(oeOperacionNeu)
            If oeOperacionNeu IsNot Nothing AndAlso oeOperacionNeu.UsuarioCreacion <> "" Then
                cboConductor.Value = oeOperacionNeu.UsuarioCreacion
            End If

            oeNeumatico = New e_Neumatico
            oeNeumatico.TipoOperacion = ""
            oeNeumatico.Id = _IdNeumatico
            oeNeumatico = olNeumatico.Obtener(oeNeumatico)

            If oeNeumatico IsNot Nothing Then
                If oeNeumatico.IdMaterial <> "" Then
                    cboMaterial.Value = oeNeumatico.IdMaterial
                End If
                If oeNeumatico.IdProveedor <> "" Then
                    cboProveedor.Value = oeNeumatico.IdProveedor
                End If
                If oeNeumatico.TipoBanda <> "" Then
                    cboTipoBanda.Text = oeNeumatico.TipoBanda
                Else
                    cboTipoBanda.SelectedIndex = -1
                End If
                If cboDiseño.SelectedIndex = -1 Then
                    Dim _leDis = leDiseñoNeu.Where(Function(it) it.Id = oeNeumatico.IdDiseño).ToList
                    If _leDis.Count > 0 Then
                        cboMarca.Value = _leDis(0).IdMarca
                        cboMedida.Value = _leDis(0).IdMedidaNeumatico
                        cboDiseño.Value = _leDis(0).Id
                    End If
                End If
            End If

            cboLugarOpe.SelectedIndex = _indLugar
            cboAlmacenOpe.SelectedIndex = _indLog

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ValidaVidaNeu(ByVal oeVidaNeu As e_VidaNeumatico) As Boolean
        Try
            If _EstadoInicial = "REENCAUCHE" Then
                If oeVidaNeumatico.CostoSoles = 0 Then Throw New Exception("Ingrese Costo en Soles")
                If oeVidaNeumatico.CostoDolares = 0 Then Throw New Exception("Ingrese Costo en Dolares")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Habilitar()
        'If _EstadoInicial = "REPARACION" Then
        dtpFechaIng.Visible = IIf(_EstadoInicial = "REPARACION", False, True)
        Etiqueta3.Visible = IIf(_EstadoInicial = "REPARACION", False, True)
        ndRibete1.Enabled = IIf(_EstadoInicial = "REPARACION", False, True)
        ndRibete2.Enabled = IIf(_EstadoInicial = "REPARACION", False, True)
        ndRibete3.Enabled = IIf(_EstadoInicial = "REPARACION", False, True)
        ndCocada.Enabled = IIf(_EstadoInicial = "REPARACION", False, True)
        cboMaterial.Enabled = IIf(_EstadoInicial = "REPARACION", False, True)
        cboProveedor.Enabled = IIf(_EstadoInicial = "REPARACION", False, True)
        cboMarca.Enabled = IIf(_EstadoInicial = "REPARACION", False, True)
        cboDiseño.Enabled = IIf(_EstadoInicial = "REPARACION", False, True)
        cboMedida.Enabled = IIf(_EstadoInicial = "REPARACION", False, True)
        cboTipoBanda.Enabled = IIf(_EstadoInicial = "REPARACION", False, True)
        chkCancelaRee.Checked = IIf(_EstadoInicial = "REPARACION", False, True)
        chkCancelaRee.Enabled = IIf(_EstadoInicial = "REPARACION", False, True)
        ' Else
        cboVehiculo.Enabled = IIf(_EstadoInicial = "REPARACION", True, False)
        cboConductor.Enabled = IIf(_EstadoInicial = "REPARACION", True, False)
        cboTecnico.Enabled = IIf(_EstadoInicial = "REPARACION", True, False)
        txtTipoVehiculo.Enabled = IIf(_EstadoInicial = "REPARACION", True, False)
        'chkCancelaRee.Checked = True
        'chkCancelaRee.Enabled = True
        'End If
    End Sub

#End Region

End Class