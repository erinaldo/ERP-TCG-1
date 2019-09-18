Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_ActivoFijo
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Dim ColorFilaEdit As Controles.Colores
    Dim Label2 As Label

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ActivoFijo = Nothing
    Private Shared Operacion As String

    'Private Property ColorFilaEdit As Controles.Colores

    'Private Property Label2 As Label

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ActivoFijo()
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de variables"

    'Entidades Principales
    Private oeActivoFijo As e_ActivoFijo, olActivoFijo As l_ActivoFijo, lstActivoFijo As List(Of e_ActivoFijo), leActivoFijoBusq As List(Of e_ActivoFijo)
    Private oeAFCuentaContable As e_ActivoFijo_CuentaContable, lstAFCuentaContable As List(Of e_ActivoFijo_CuentaContable)
    Private oeReadecuacionAF As e_ReadecuacionActivoFijo, lstReadecuacionAF As List(Of e_ReadecuacionActivoFijo)
    Private oeReadecuacionAFDoc As e_ReadecuacionAF_Documento, lstReadecuacionAFDoc As List(Of e_ReadecuacionAF_Documento)
    'Combos
    Private oeCombo As e_Combo, lstCombo As List(Of e_Combo), olCombo As l_Combo
    Private lstCentroCosto As List(Of e_CentroCosto), oeCentroCosto As e_CentroCosto, olCentroCosto As l_CentroCosto
    Private lstMaterial As List(Of e_Combo)
    'Mensaje de Espera
    Private ugbEspera As ISL.Win.Espere
    'Movimiento Documento
    Private oeMovimientoDocumento As e_MovimientoDocumento, olMovimientoDocumento As l_MovimientoDocumento
    Private oeContratoFinanciero As e_ContratoFinanciero, olContratoFinanciero As l_ContratoFinanciero
    Private FechaActual As Date = #1/1/1901#
    Private oePeriodo As e_Periodo, olPeriodo As l_Periodo, lstPeriodo As List(Of e_Periodo)
    'Depreciacion
    Private oeDepreciacionAF As e_DepreciacionActivoFijo, lstDepreciacionAF As List(Of e_DepreciacionActivoFijo)
    Private bolEliminarFilas As Boolean = False
    Private oeTipoActivoCtaCtble As e_TipoActivoFijo_CtaCtble, lstTipoActivoCtaCtble As List(Of e_TipoActivoFijo_CtaCtble), olTipoActivoFijoCtaCtble As l_TipoActivoFijo_CtaCtble
    Private oeAsiento As e_Asiento, lstAsiento As List(Of e_Asiento), olAsiento As l_Asiento
    Private oeAsientoMov As e_AsientoMovimiento, lstAsientoMov As List(Of e_AsientoMovimiento)
    Private olTrajadorabSeg As l_TrabajadorSeguridad
    Private Const strPermisoExtornarDepreciacion As String = "EXTORNAR ASIENTO DE DEPRECIACION"
    Private IdAFReclasificar As String = String.Empty
    Private lstTipoDocumento As List(Of e_TipoDocumento), olTipoDocumento As l_TipoDocumento
    '***************************************************************************************
    Private oeCuentaCtable As New e_CuentaContable, olCuentaContable As New l_CuentaContable
    Private leCuentaCtable As New List(Of e_CuentaContable)
    Private ListCuentaAF As List(Of e_Combo)

    Private oeDetConPond As e_DetalleConceptoPonderado, olDetConPond As l_DetalleConceptoPonderado, leDetConPond As List(Of e_DetalleConceptoPonderado)

    Private Const IdTipoAsientoDiario As String = "1CH000020"

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Listar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            mt_MostrarMsjeEspera()
            Operacion = "Nuevo"
            Inicializar()
            oeActivoFijo = New e_ActivoFijo
            MostrarTabs(1, ficActivoFijo, 1)
            mt_ControlBotoneria()
            cboCentro.Focus()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            mt_QuitarMsjeEspera()
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            mt_MostrarMsjeEspera()
            If gf_ValidarFilaSeleccionada(griLista) Then
                Operacion = "Editar"
                Inicializar()
                mt_MostrarDatos()
                MostrarTabs(1, ficActivoFijo, 1)
                mt_ControlBotoneria()
                cboCentro.Focus()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            mt_QuitarMsjeEspera()
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            Select Case ficActivoFijo.SelectedTab.Index
                Case 0 'Listado
                    Select Case tabAdicionalAF.SelectedTab.Index
                        Case utpDepreciarActivos.Tab.Index
                            If lf_ValidarDepreciacion() Then
                                If griDepreciacionActivos.Rows.Count > 0 Then
                                    'Verificar si ya se ejecuto la depreciación de ese periodo
                                    If lf_ValidarDepreciacionPeriodo(griDepreciacionActivos.Rows(0).Cells("IdPeriodo").Value) Then
                                        'Guardar Registro de DepreciacionActivoFijo
                                        lstDepreciacionAF = New List(Of e_DepreciacionActivoFijo)
                                        For Each Fila As UltraWinGrid.UltraGridRow In griDepreciacionActivos.Rows
                                            oeDepreciacionAF = New e_DepreciacionActivoFijo
                                            With oeDepreciacionAF
                                                .IdActivoFijo = Fila.Cells("IdActivoFijo").Value
                                                .IdPeriodo = Fila.Cells("IdPeriodo").Value
                                                .IdAFCuentaContable = Fila.Cells("IdAFCuentaContable").Value
                                                .IdCuentaOrigen = Fila.Cells("IdCtaDebe").Value
                                                .IdCuentaDestino = Fila.Cells("IdCtaHaber").Value
                                                .Valor = Math.Round(Fila.Cells("Total Depreciacion").Value, 2)
                                                .Importe = Math.Round(Fila.Cells("Total Depreciacion").Value, 2)
                                                .Observacion = "DEPRECIACION DEL PERIODO " & Fila.Cells("CodigoPeriodo").Value & "  S/ " & Math.Round(Fila.Cells("Total Depreciacion").Value, 2, MidpointRounding.AwayFromZero)
                                                .UsuarioCreacion = gUsuarioSGI.Id
                                                .IdTipoActivoFijo = Fila.Cells("IdTipoActivoFijo").Value
                                                .TipoActivoFijo = Fila.Cells("TipoActivoFijo").Value
                                                .IndTipoVehiculo = Fila.Cells("IndTipoVehiculo").Value
                                                .IdCentroCosto = Fila.Cells("IdCentroCosto").Value
                                                .IdGastoFuncion = Fila.Cells("IdGastoFuncion").Value
                                                .TipoCambio = TipoCambio(FechaActual.Date, True)(0)
                                                .Actual = 1
                                                If .TipoCambio = 0 Then
                                                    Throw New Exception("Tipo de cambio 0. Verificar")
                                                End If
                                            End With
                                            lstDepreciacionAF.Add(oeDepreciacionAF)
                                        Next
                                        If olActivoFijo.GuardarDepreciacionPeriodo(lstDepreciacionAF, gs_PrefijoIdSucursal) Then
                                            MessageBox.Show("Operación realizada con éxito", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        End If
                                    End If
                                Else
                                    MessageBox.Show("Listar activos para realizar la depreciación", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                            End If
                    End Select
                Case 1 'Mantenimiento
                    If lf_ValidarGuardar() AndAlso GuardarAF() Then
                        MessageBox.Show("Operación realizado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        MostrarTabs(0, ficActivoFijo, 0)
                        Operacion = "Inicializa"
                        mt_ControlBotoneria()
                        Consultar(True)
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            mt_MostrarMsjeEspera()
            Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                Case Windows.Forms.DialogResult.Yes
                    Guardar()
                Case Windows.Forms.DialogResult.No
                    MostrarTabs(0, ficActivoFijo, 2)
                    Operacion = "Inicializa"
                    mt_ControlBotoneria()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            mt_QuitarMsjeEspera()
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            griLista.ActiveRow.Delete()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Try
            mt_MostrarMsjeEspera()
            MyBase.Imprimir()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            mt_QuitarMsjeEspera()
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If tabAdicionalAF.Tabs(0).Selected = True Then
                Exportar_Excel(griLista)
            Else
                If tabAdicionalAF.Tabs(2).Selected = True Then
                    Exportar_Excel(griAsiento)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos y Funciones"

    Private Sub mt_ConfigurarGrillas()
        Try
            'Listado
            lstActivoFijo = New List(Of e_ActivoFijo)
            griLista.DataSource = lstActivoFijo
            OcultarColumna2(griLista, False, "IdModelo", "Codigo", "IdSedeEmpresa", "IdResponsable", "DescripcionResumida", "FechaIngreso", "IndFecActivacion", _
                            "FechaActivacion", "GrupoActivo", "SubGrupoActivo", "IndDepreciable", "IndPertenencia", "ValorCompra", "VidaUtil", "VidaUtilRemanente", "ValorResidual", "IndReclasificado", "IndBaja", "FechaBaja")
            With griLista.DisplayLayout.Bands(0)
                .Columns("IdModelo").Header.Caption = "Codigo"
                .Columns("IdModelo").Width = 80

                .Columns("Codigo").Header.Caption = "Codigo Usuario"
                .Columns("Codigo").Width = 80

                .Columns("IdSedeEmpresa").Header.Caption = "Sede"
                .Columns("IdSedeEmpresa").Width = 80

                .Columns("IdResponsable").Header.Caption = "Responsable"
                .Columns("IdResponsable").Width = 200

                .Columns("DescripcionResumida").Header.Caption = "Activo Fijo"
                .Columns("DescripcionResumida").Width = 200

                .Columns("FechaIngreso").Header.Caption = "F. Ingreso"
                .Columns("FechaIngreso").Width = 75

                .Columns("IndFecActivacion").Header.Caption = "Activ."
                .Columns("IndFecActivacion").Width = 45
                .Columns("IndFecActivacion").Style = ColumnStyle.CheckBox

                .Columns("FechaActivacion").Header.Caption = "F.Activ"
                .Columns("FechaActivacion").Width = 75

                .Columns("GrupoActivo").Header.Caption = "Tipo"
                .Columns("GrupoActivo").Width = 180

                .Columns("SubGrupoActivo").Header.Caption = "SubTipo"
                .Columns("SubGrupoActivo").Width = 120

                .Columns("IndDepreciable").Header.Caption = "Deprec."
                .Columns("IndDepreciable").Width = 45
                .Columns("IndDepreciable").Style = ColumnStyle.CheckBox

                .Columns("IndPertenencia").Header.Caption = "Propio"
                .Columns("IndPertenencia").Width = 45
                .Columns("IndPertenencia").Style = ColumnStyle.CheckBox

                .Columns("ValorCompra").Header.Caption = "ValorCompra(S/)"
                .Columns("ValorCompra").Width = 90
                .Columns("ValorCompra").Format = "#,##0.00"
                .Columns("ValorCompra").CellAppearance.TextHAlign = HAlign.Right

                .Columns("VidaUtil").Header.Caption = "VidaUtil(Años)"
                .Columns("VidaUtil").Width = 80
                .Columns("VidaUtil").Format = "#,##0.00"
                .Columns("VidaUtil").CellAppearance.TextHAlign = HAlign.Right

                .Columns("VidaUtilRemanente").Header.Caption = "VidaUtilRemanente"
                .Columns("VidaUtilRemanente").Width = 80
                .Columns("VidaUtilRemanente").Format = "#,##0.00"
                .Columns("VidaUtilRemanente").CellAppearance.TextHAlign = HAlign.Right

                .Columns("ValorResidual").Header.Caption = "VR"
                .Columns("ValorResidual").Width = 65
                .Columns("ValorResidual").Format = "#,##0.00"
                .Columns("ValorResidual").CellAppearance.TextHAlign = HAlign.Right

                .Columns("IndReclasificado").Header.Caption = "Reclasificado"
                .Columns("IndReclasificado").Width = 55
                .Columns("IndReclasificado").Style = ColumnStyle.CheckBox

                .Columns("IndBaja").Header.Caption = "Baja"
                .Columns("IndBaja").Width = 45
                .Columns("IndBaja").Style = ColumnStyle.CheckBox

                .Columns("FechaBaja").Header.Caption = "F. Baja"
                .Columns("FechaBaja").Width = 75
            End With
            'Detalle Informacion Contable
            lstAFCuentaContable = New List(Of e_ActivoFijo_CuentaContable)
            griAFCuentaContable.DataSource = lstAFCuentaContable

            OcultarColumna2(griAFCuentaContable, False, "Ejercicio", "TipoActivo", "CtaCtbleCompra", "CtaCtbleCompraH", "CtaCtbleRevalorizacion", "CtaCtbleRevalorizacionH", _
                            "CtaCtbeDepreciacion", "CtaCtbeDepreciacionH", "CtaCtbleReadeacuacion", "CtaCtbleReadeacuacionH", "CtaCtbleDesactivacionD", "GastoFuncion", "Actual")
            With griAFCuentaContable.DisplayLayout.Bands(0)
                .Columns("Ejercicio").Header.Caption = "Ejercicio"
                .Columns("Ejercicio").Width = 65

                .Columns("CtaCtbleCompra").Header.Caption = "Debe"
                .Columns("CtaCtbleCompra").Width = 65
                .Columns("CtaCtbleCompraH").Header.Caption = "Haber"
                .Columns("CtaCtbleCompraH").Width = 65

                .Columns("CtaCtbleRevalorizacion").Header.Caption = "Debe"
                .Columns("CtaCtbleRevalorizacion").Width = 65
                .Columns("CtaCtbleRevalorizacionH").Header.Caption = "Haber"
                .Columns("CtaCtbleRevalorizacionH").Width = 65

                .Columns("CtaCtbeDepreciacion").Header.Caption = "Debe"
                .Columns("CtaCtbeDepreciacion").Width = 65
                .Columns("CtaCtbeDepreciacionH").Header.Caption = "Haber"
                .Columns("CtaCtbeDepreciacionH").Width = 65

                .Columns("CtaCtbleReadeacuacion").Header.Caption = "Debe"
                .Columns("CtaCtbleReadeacuacion").Width = 65
                .Columns("CtaCtbleReadeacuacionH").Header.Caption = "Haber"
                .Columns("CtaCtbleReadeacuacionH").Width = 65

                .Columns("CtaCtbleDesactivacionD").Header.Caption = "Desactivación"
                .Columns("CtaCtbleDesactivacionD").Width = 65

                .Columns("GastoFuncion").Header.Caption = "Gasto Función"
                .Columns("GastoFuncion").Width = 150

                .Columns("Actual").Header.Caption = "Actual"
                .Columns("Actual").Width = 50
                .Columns("Actual").Style = ColumnStyle.CheckBox

            End With
            'Detalle de Readecuaciones
            lstReadecuacionAF = New List(Of e_ReadecuacionActivoFijo)
            griReadecuacion.DataSource = lstReadecuacionAF
            'Readecuaciones Doc
            lstReadecuacionAFDoc = New List(Of e_ReadecuacionAF_Documento)
            griReadecuacionAFDocumento.DataSource = lstReadecuacionAFDoc
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_InicializarLogica()
        Try
            FechaActual = ObtenerFechaServidor().Date
            olActivoFijo = New l_ActivoFijo
            olCombo = New l_Combo
            olCentroCosto = New l_CentroCosto
            olMovimientoDocumento = New l_MovimientoDocumento
            olPeriodo = New l_Periodo
            olTipoActivoFijoCtaCtble = New l_TipoActivoFijo_CtaCtble
            olAsiento = New l_Asiento
            olTrajadorabSeg = New l_TrabajadorSeguridad
            olContratoFinanciero = New l_ContratoFinanciero
            olTipoDocumento = New l_TipoDocumento
            olDetConPond = New l_DetalleConceptoPonderado
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_ConfigurarComboGrilla()
        Try
            CrearComboGrid("IdSedeEmpresa", "Nombre", griLista, gf_getDTCentroPublic(CentroPublic), True)
            CrearComboGrid("IdResponsable", "Nombre", griLista, olCombo.ComboGrilla(TrabajadorPublic), True)
            CrearComboGrid("IdMoneda", "Nombre", griAsiento, gf_getDTMonedaPublic(MonedaPublic), True)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_ControlBotoneria()
        Try
            If ficActivoFijo.SelectedTab IsNot Nothing Then
                Select Case ficActivoFijo.SelectedTab.Index
                    Case 0 'Lista
                        Select Case tabAdicionalAF.SelectedTab.Index
                            Case utpActivosFijos.Tab.Index 'Lista Activo Fijo
                                ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                            Case utpListaDAF.Tab.Index 'Eliminar Depreciacion
                                ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                            Case utpDepreciarActivos.Tab.Index
                                ControlBoton(1, 0, 0, 1, 0, 0, 0, 0, 1)
                        End Select
                    Case 1 'Mantenimiento
                        If Not String.IsNullOrWhiteSpace(oeActivoFijo.Id) AndAlso (oeActivoFijo.IndReclasificado = True OrElse oeActivoFijo.IndBaja = 1) Then
                            ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 1)
                        Else
                            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
                        End If
                End Select
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_MostrarMsjeEspera()
        Try
            ugbEspera = New Espere
            ficActivoFijo.SelectedTab.TabPage.Controls.Add(ugbEspera)
            ugbEspera.Location = New Point((Me.Width / 2) - (ugbEspera.Width / 2), (Me.Height / 2) - ugbEspera.Height)
            ugbEspera.BringToFront()
            ugbEspera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_QuitarMsjeEspera()
        Try
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugbEspera.Visible = False
            ugbEspera = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializar()
        Try
            uegbDatosBaja.Expanded = False
            uegbDatosBaja.Visible = False
            ficDatosAF.Tabs(0).Selected = True
            'General
            txtCodigo.Text = String.Empty
            txtIdentificador.Text = String.Empty
            cboCentro.Text = ""
            cboCentro.SelectedIndex = -1
            txtDescripcionResumida.Text = ""
            cboEstadoAF.Text = ""
            cboEstadoAF.SelectedIndex = -1
            cboResponsable.Text = ""
            cboResponsable.SelectedIndex = -1
            chkPropio.Checked = False
            txtDescripcionDetallada.Text = ""
            chkDepende.Checked = False
            chkDepende_CheckedChanged(Nothing, Nothing)
            'Especifico
            fecIngreso.Value = FechaActual
            verIndFecActivacion.Checked = False
            fecActivacion.Value = FechaActual
            cboConceptoIngresoAF.Text = ""
            cboGrupoAF.Text = ""
            cboSubGrupoAF.Text = ""
            cbgCentroCostoAF.Value = String.Empty
            cbgCentroCostoAF.Text = String.Empty
            cboCCUbicaciones.Value = ""
            cboCCUbicaciones.Text = ""
            chkMaterial.Checked = False
            cbgMaterial.Value = String.Empty
            cbgMaterial.Text = String.Empty
            uneValorResidual.Value = 0.0
            chkDepreciable.Checked = False
            cboDepreciacion.SelectedIndex = -1
            numPorcentaje.Value = 0
            cboMetodo.SelectedIndex = -1
            txtNroAutorizacion.Text = String.Empty
            chkDepreciable_CheckedChanged(Nothing, Nothing)
            chkConjuntoAF.Checked = False
            numCantidadAF.Value = 1
            rbtInformacionCompra.Enabled = True
            rbtSituacionAFecha.Enabled = True
            opcTipoDocumento.Enabled = True
            'Con Documento
            rbtInformacionCompra.Checked = True
            opcTipoDocumento.CheckedIndex = 0
            btnBuscarDoc.Enabled = True
            fecCompraIC.Enabled = False
            fecCompraIC.Value = FechaActual
            txtTipoDocumento.Text = String.Empty
            txtTipoDocumento.Tag = String.Empty
            txtProveedor.Text = String.Empty
            txtSerie.Text = String.Empty
            txtNroDocumentoIC.Text = String.Empty
            uneValorCompra.ReadOnly = False
            uneValorCompra.Value = 0.0
            decVidaUtilIC.Value = 0
            'Sin Documento
            fecSituacionCtble.Value = FechaActual
            decValorLibroSC.Value = 0.0
            decRevalorizacionAcumuladaSC.Value = 0.0
            decDepreciacionAcumuladaSC.Value = 0.0
            decVidaUtilRemanenteSC.Value = 0.0
            uneDep2014.Value = 0.0
            uneDep2015.Value = 0.0
            uneCosto2012.Value = 0.0
            'Tab Informacion Contable
            AñoIC.Año = FechaActual.Year
            mt_LimpiarDatosCuentasContables()
            'Tab Readecuaciones
            'Tab Depreciacion
            AñoD.Año = FechaActual.Year
            cboMesD.SelectedIndex = -1
            decValorD.Value = 0.0
            decImporteD.Value = 0.0
            cboAFCuentaContableD.Value = String.Empty
            cboAFCuentaContableD.Text = String.Empty
            cboCtaOrigenD.Value = String.Empty
            cboCtaOrigenD.Text = String.Empty
            txtCtaOrigenD.Text = String.Empty
            cboCtaDestinoD.Value = String.Empty
            cboCtaDestinoD.Text = String.Empty
            txtCtaDestinoD.Text = String.Empty
            txtObservacionD.Text = String.Empty
            verActualD.Checked = False
            'Tab Valorizacion
            fecConsultaV.Value = FechaActual
            decValorCompraLibroV.Value = 0.0
            decValorBrutoInicialV.Value = 0.0
            decReadecuacionesV.Value = 0.0
            decRevalAcumuladaV.Value = 0.0
            decDepreAcumuladaV.Value = 0.0
            decValorLibroAlFecV.Value = 0.0
            decVidaUtilRemanV.Value = 0.0
            'Datos de Baja
            verIndBaja.Checked = False
            fecBaja.Value = FechaActual
            cboConceptoBajaAF.Text = String.Empty
            cboConceptoBajaAF.SelectedIndex = -1
            txtDescripcionBaja.Text = String.Empty
            txtTipoDocBaja.Tag = String.Empty
            txtTipoDocBaja.Text = String.Empty
            txtSerieBaja.Text = String.Empty
            txtNumeroBaja.Text = String.Empty
            'Detalles
            lstAFCuentaContable.Clear() : griAFCuentaContable.DataBind()
            lstReadecuacionAF.Clear() : griReadecuacion.DataBind()
            MostrarTabs(0, utcReadecuaciones, 2)
            uneValorCompra.Enabled = True
            decVidaUtilIC.Enabled = True
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar()
        Try
            mt_MostrarMsjeEspera()
            Select Case tabAdicionalAF.SelectedTab.Index
                Case utpActivosFijos.Tab.Index
                    oeActivoFijo = New e_ActivoFijo : leActivoFijoBusq = New List(Of e_ActivoFijo)
                    lstActivoFijo.Clear() : leActivoFijoBusq.Clear()
                    lstActivoFijo.AddRange(olActivoFijo.Listar(oeActivoFijo))
                    leActivoFijoBusq.AddRange(lstActivoFijo)
                    'Dim DT As DataTable = ConvertToDataTable(lstActivoFijo.ToList)
                    griLista.DataBind()
                Case utpListaDAF.Tab.Index
                    oeAsiento = New e_Asiento
                    oeAsiento.TipoOperacion = "D"
                    oeAsiento.IdPeriodo = cboMesListaDAF.Value
                    griAsiento.DataSource = olAsiento.Listar(oeAsiento)
                Case utpDepreciarActivos.Tab.Index
                    mt_ListarDepreciacionActivos()
            End Select
            mt_ControlBotoneria()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            mt_QuitarMsjeEspera()
        End Try
    End Sub

    Private Sub mt_MostrarDatos()
        Try
            oeActivoFijo = New e_ActivoFijo
            oeActivoFijo.Id = griLista.ActiveRow.Cells("Id").Value.ToString()
            oeActivoFijo = olActivoFijo.Obtener(oeActivoFijo, True, True)
            With oeActivoFijo
                'General
                txtCodigo.Text = .IdModelo
                txtIdentificador.Text = .Codigo
                cboCentro.Value = .IdSedeEmpresa.Trim
                txtDescripcionResumida.Text = .DescripcionResumida
                cboEstadoAF.Value = .IdEstado
                cboResponsable.Value = .IdResponsable
                chkPropio.Checked = If(.IndPertenencia = 1, True, False)
                txtDescripcionDetallada.Text = gf_quitarSaltosLinea(.DescripcionDetallada, " ")
                chkDepende.Checked = IIf(.IdActivoFijoDepende.Trim.Length > 0, True, False)
                If chkDepende.Checked Then cboActivoFijo.Value = .IdActivoFijoDepende
                'Especificos
                fecIngreso.Value = .FechaIngreso
                verIndFecActivacion.Checked = If(.IndFecActivacion = 1, True, False)
                fecActivacion.Value = .FechaActivacion
                cboConceptoIngresoAF.Value = .IdConceptoIngreso
                cboGrupoAF.Value = .IdGrupoActivo
                cboSubGrupoAF.Value = .IdSubGrupoActivo
                cbgCentroCostoAF.Value = .IdCentroCosto
                cboCCUbicaciones.Value = .IdUbicacion
                cbgMaterial.Value = .IdMaterial
                uneValorResidual.Value = .ValorResidual
                chkDepreciable.Checked = If(.IndDepreciable = 1, True, False)
                Dim _leAux = .ListAF_CuentaContable.Where(Function(it) it.IdReadecuacion.Trim.Length = 0).ToList
                If _leAux.Count > 0 Then
                    cboMetodo.Value = _leAux(0).IdMetodoDepreciacion
                    txtNroAutorizacion.Text = _leAux(0).NroAutorizacion
                End If
                If .Cantidad <> 1 Then
                    chkConjuntoAF.Checked = True
                Else
                    chkConjuntoAF.Checked = False
                End If
                numCantidadAF.Value = .Cantidad
                'Obtener lista con Tipo Documentos
                'TipoDocumento
                oeCombo = New e_Combo
                oeCombo.Nombre = "TipoDocumento"
                lstCombo = New List(Of e_Combo)
                lstCombo.AddRange(olCombo.Listar(oeCombo))
                'Con Documento
                If .IndDocumento = 1 OrElse .IndDocumento = 2 OrElse .IndDocumento = 3 Then
                    rbtInformacionCompra.Checked = True
                    opcTipoDocumento.CheckedIndex = If(.IndDocumento > 0, .IndDocumento - 1, 0)
                    decVidaUtilIC.Value = .VidaUtil
                    mt_MostrarValoresDocumento(opcTipoDocumento.CheckedIndex)
                Else
                    If Not String.IsNullOrWhiteSpace(.IdDocumento) Then
                        If Not IsNumeric(.FichaTecnica) Then
                            .FichaTecnica = "0"
                        End If
                        opcTipoDocumento.CheckedIndex = If(Convert.ToInt32(.FichaTecnica) > 0, Convert.ToInt32(.FichaTecnica) - 1, 0)
                        mt_MostrarValoresDocumento(opcTipoDocumento.CheckedIndex)
                    End If
                    uneDep2014.Value = .Depreciacion2014
                    uneDep2015.Value = .Depreciacion2015
                    uneCosto2012.Value = .Costo2012
                    rbtSituacionAFecha.Checked = True
                    fecSituacionCtble.Value = .FechaSituacion
                    decValorLibroSC.Value = .ValorLibro
                    decRevalorizacionAcumuladaSC.Value = .RevalorizacionAcumulada
                    decDepreciacionAcumuladaSC.Value = .DepreciacionAcumulada
                    decVidaUtilRemanenteSC.Value = .VidaUtilRemanente
                End If
                'Baja
                verIndBaja.Checked = .IndBaja
                fecBaja.Value = .FechaBaja
                cboConceptoBajaAF.Value = .IdConceptoBaja
                txtDescripcionBaja.Text = .DescripcionBaja
                If Not String.IsNullOrWhiteSpace(.IdDocumentoBaja) Then
                    oeMovimientoDocumento = New e_MovimientoDocumento
                    oeMovimientoDocumento.Id = .IdDocumentoBaja
                    oeMovimientoDocumento = olMovimientoDocumento.Obtener(oeMovimientoDocumento)
                    txtTipoDocBaja.Text = If(lstCombo.Where(Function(x) x.Id = oeMovimientoDocumento.IdTipoDocumento).Count > 0, lstCombo.Where(Function(x) x.Id = oeMovimientoDocumento.IdTipoDocumento)(0).Nombre, String.Empty)
                    txtSerieBaja.Text = oeMovimientoDocumento.Serie
                    txtNumeroBaja.Text = oeMovimientoDocumento.Numero
                End If
                'Detalles
                lstAFCuentaContable.AddRange(.ListAF_CuentaContable)
                griAFCuentaContable.DataBind()
                lstReadecuacionAF.AddRange(.ListReadecuacionAF)
                griReadecuacion.DataBind()
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mt_MostrarValoresDocumento(Indice As Integer)
        Try
            With oeActivoFijo
                Select Case Indice
                    Case 0
                        txtTipoDocumento.Tag = .IdDocumento
                        'Documento
                        oeMovimientoDocumento = New e_MovimientoDocumento
                        oeMovimientoDocumento.Id = .IdDocumento
                        oeMovimientoDocumento = olMovimientoDocumento.Obtener(oeMovimientoDocumento)
                        'Mostrar
                        fecCompraIC.Value = oeMovimientoDocumento.FechaEmision
                        txtTipoDocumento.Text = If(lstCombo.Where(Function(x) x.Id = oeMovimientoDocumento.IdTipoDocumento).Count > 0, lstCombo.Where(Function(x) x.Id = oeMovimientoDocumento.IdTipoDocumento)(0).Nombre, String.Empty)
                        txtProveedor.Text = If(ClienteProveedorPublic.Where(Function(x) x.Id = oeMovimientoDocumento.IdClienteProveedor).Count > 0, ClienteProveedorPublic.Where(Function(x) x.Id = oeMovimientoDocumento.IdClienteProveedor)(0).Nombre, String.Empty)
                        txtSerie.Text = oeMovimientoDocumento.Serie
                        txtNroDocumentoIC.Text = oeMovimientoDocumento.Numero
                        uneValorCompra.Value = .ValorCompra
                    Case 1
                        txtTipoDocumento.Tag = .IdDocumento
                        'Obligación
                        oeContratoFinanciero = New e_ContratoFinanciero
                        oeContratoFinanciero.Id = .IdDocumento
                        oeContratoFinanciero = olContratoFinanciero.Obtener(oeContratoFinanciero)
                        'Mostrar
                        fecCompraIC.Value = oeContratoFinanciero.FechaVencimiento
                        txtTipoDocumento.Text = If(lstCombo.Where(Function(x) x.Id = oeContratoFinanciero.IdTipoDocumento).Count > 0, lstCombo.Where(Function(x) x.Id = oeContratoFinanciero.IdTipoDocumento)(0).Nombre, String.Empty)
                        txtProveedor.Text = If(ClienteProveedorPublic.Where(Function(x) x.Id = oeContratoFinanciero.IdEmpresaBanco).Count > 0, ClienteProveedorPublic.Where(Function(x) x.Id = oeContratoFinanciero.IdEmpresaBanco)(0).Nombre, String.Empty)
                        txtSerie.Text = ""
                        txtNroDocumentoIC.Text = oeContratoFinanciero.Codigo
                        uneValorCompra.Value = .ValorCompra
                    Case 2
                        uneValorCompra.Value = .ValorCompra
                End Select
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GuardarAF() As Boolean
        Try
            mt_MostrarMsjeEspera()
            With oeActivoFijo
                .TipoOperacion = "I"
                'Datos Generales
                .IdModelo = txtCodigo.Text
                .Codigo = txtIdentificador.Text
                .IdSedeEmpresa = cboCentro.Value
                .DescripcionResumida = txtDescripcionResumida.Text
                .IdEstado = cboEstadoAF.Value
                .IdResponsable = cboResponsable.Value
                .IndPertenencia = chkPropio.Checked
                .DescripcionDetallada = txtDescripcionDetallada.Text
                'Datos Especificos
                .FechaIngreso = fecIngreso.Value.Date
                .IndFecActivacion = If(verIndFecActivacion.Checked, 1, 0)
                .FechaActivacion = fecActivacion.Value.Date
                .IdConceptoIngreso = cboConceptoIngresoAF.Value
                .IdGrupoActivo = cboGrupoAF.Value
                .IdSubGrupoActivo = cboSubGrupoAF.Value
                .IdCentroCosto = cbgCentroCostoAF.Value
                .IdUbicacion = cboCCUbicaciones.Value
                If chkMaterial.Checked Then
                    .IdMaterial = cbgMaterial.Value
                Else
                    .IdMaterial = String.Empty
                End If
                .ValorResidual = uneValorResidual.Value
                .IndDepreciable = If(chkDepreciable.Checked, 1, 0)
                If chkConjuntoAF.Checked Then
                    .Cantidad = numCantidadAF.Value
                Else
                    .Cantidad = 1
                End If
                .IdDocumento = txtTipoDocumento.Tag
                .IdActivoFijoDepende = IIf(chkDepende.Checked, cboActivoFijo.Value, String.Empty)
                'Con Documento
                If rbtInformacionCompra.Checked Then
                    .IndDocumento = (opcTipoDocumento.CheckedIndex + 1)
                    .VidaUtil = decVidaUtilIC.Value
                    .ValorCompra = uneValorCompra.Value
                Else
                    'Sin Documento
                    .FechaSituacion = fecSituacionCtble.Value.Date
                    .ValorLibro = decValorLibroSC.Value
                    .RevalorizacionAcumulada = decRevalorizacionAcumuladaSC.Value
                    .DepreciacionAcumulada = decDepreciacionAcumuladaSC.Value
                    .VidaUtilRemanente = decVidaUtilRemanenteSC.Value
                    .Depreciacion2014 = uneDep2014.Value
                    .Depreciacion2015 = uneDep2015.Value
                    .Costo2012 = uneCosto2012.Value
                    If Not String.IsNullOrWhiteSpace(.IdDocumento) Then
                        .FichaTecnica = (opcTipoDocumento.CheckedIndex + 1)
                    End If
                End If
                'Baja
                If verIndBaja.Checked Then
                    .IndBaja = If(verIndBaja.Checked, 1, 0)
                    .FechaBaja = fecBaja.Value.Date
                    .DescripcionBaja = txtDescripcionBaja.Text.Trim()
                    .IdDocumentoBaja = txtTipoDocBaja.Tag
                    .IdConceptoBaja = cboConceptoBajaAF.Value
                End If
                'Detalles
                For Each _oeAux In lstAFCuentaContable.Where(Function(it) it.IdReadecuacion.Trim.Length = 0).ToList
                    _oeAux.UsuarioModificacion = gUsuarioSGI.Id
                    _oeAux.IdMetodoDepreciacion = cboMetodo.Value
                    _oeAux.NroAutorizacion = txtNroAutorizacion.Text
                Next
                .ListAF_CuentaContable.Clear()
                .ListAF_CuentaContable.AddRange(lstAFCuentaContable)
                .ListReadecuacionAF.Clear()
                .ListReadecuacionAF.AddRange(lstReadecuacionAF)
                .UsuarioCreacion = gUsuarioSGI.Id
                'Verificar si se esta reclasificando
                If Operacion = "Reclasificar" Then
                    .IndReclasificando = True
                    'Con la Fecha de Ingrese Obtener periodo y tipo de cambio
                    oePeriodo = New e_Periodo
                    oePeriodo.Activo = True
                    oePeriodo.Ejercicio = .FechaIngreso.Year
                    oePeriodo.Mes = .FechaIngreso.Month
                    oePeriodo = olPeriodo.Obtener(oePeriodo)
                    If Not String.IsNullOrWhiteSpace(oePeriodo.Id) Then
                        If oePeriodo.CierreContabilidad Then
                            Throw New Exception("Periodo " & .FechaIngreso.Year.ToString() & "-" & .FechaIngreso.Month.ToString() & " cerrado. Verificar fecha de ingreso")
                            ficDatosAF.Tabs(0).Selected = True
                            fecIngreso.Focus()
                        End If
                        .IdPeriodo = oePeriodo.Id
                    Else
                        Throw New Exception("Verificar fecha de ingreso el periodo " & .FechaIngreso.Year.ToString() & "-" & .FechaIngreso.Month.ToString() & Environment.NewLine & _
                                            "Aún no ha sido creado")
                    End If
                    .TipoCambio = TipoCambio(.FechaIngreso, True)(0)
                    If .TipoCambio = 0 Then
                        Throw New Exception("Tipo de cambio 0. Verificar")
                    End If
                End If
                'Verificar si se esta dando de baja
                If verIndBaja.Checked Then
                    'Con la Fecha de Baja Obtener periodo y tipo de cambio
                    oePeriodo = New e_Periodo
                    oePeriodo.Activo = True
                    oePeriodo.Ejercicio = .FechaBaja.Year
                    oePeriodo.Mes = .FechaBaja.Month
                    oePeriodo = olPeriodo.Obtener(oePeriodo)
                    If Not String.IsNullOrWhiteSpace(oePeriodo.Id) Then
                        If oePeriodo.CierreContabilidad Then
                            Throw New Exception("Periodo " & .FechaBaja.Year.ToString() & "-" & .FechaBaja.Month.ToString() & " cerrado. Verificar fecha de baja")
                            ficDatosAF.Tabs(0).Selected = True
                            fecBaja.Focus()
                        End If
                        .IdPeriodo = oePeriodo.Id
                    Else
                        Throw New Exception("Verificar fecha de baja el periodo " & .FechaBaja.Year.ToString() & "-" & .FechaBaja.Month.ToString() & Environment.NewLine & _
                                            "Aún no ha sido creado")
                    End If
                    'Verificar si en el periodo de baja ya se realizo la depreciación para ese activo
                    If Not String.IsNullOrWhiteSpace(oeActivoFijo.Id) Then
                        oeDepreciacionAF = New e_DepreciacionActivoFijo
                        oeDepreciacionAF.IdActivoFijo = oeActivoFijo.Id
                        oeDepreciacionAF.IdPeriodo = oePeriodo.Id
                        lstDepreciacionAF = New List(Of e_DepreciacionActivoFijo)
                        lstDepreciacionAF.AddRange(olActivoFijo.ListarDepreciacionAF(oeDepreciacionAF))
                        If lstDepreciacionAF.Count > 0 Then
                            Throw New Exception("Ya se ejecutó la depreciación para el periodo " & oePeriodo.Codigo & ".Verificar Fecha de baja")
                        End If
                    End If
                    .TipoCambio = TipoCambio(.FechaBaja, True)(0)
                    If .TipoCambio = 0 Then
                        Throw New Exception("Tipo de cambio 0. Verificar")
                    End If
                End If
            End With
            Return olActivoFijo.Guardar(oeActivoFijo)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            mt_QuitarMsjeEspera()
        End Try
    End Function

    Private Const strEliminarActivoFijo As String = "ELIMINAR ACTIVO FIJO"
    Public Function EliminarAF() As Boolean
        Try
            Dim olTrabajadorSeg As New l_TrabajadorSeguridad
            If olTrabajadorSeg.Permisos(gUsuarioSGI.IdTrabajador, strEliminarActivoFijo) Then
                With griLista
                    If ValidarGrilla(griLista, "Activo Fijo") Then
                        oeActivoFijo = New e_ActivoFijo
                        oeActivoFijo.Id = .ActiveRow.Cells("Id").Value.ToString
                        oeActivoFijo = olActivoFijo.Obtener(oeActivoFijo, False, False)  'Obtenemos un registro 
                        If oeActivoFijo.Id <> "" Then 'y verificamos si esta activo(Sin eliminación lógica)
                            If MessageBox.Show("Esta seguro de eliminar el Activo Fijo: " & _
                                     .ActiveRow.Cells("DescripcionResumida").Value.ToString & " ?", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                oeActivoFijo.TipoOperacion = "E"
                                olActivoFijo.Eliminar(oeActivoFijo)
                            Else
                                Return False
                                Exit Function
                            End If
                        Else
                            Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                        End If
                    End If
                End With
                Return True
            Else
                MessageBox.Show("Usted no tiene permiso para eliminar un activo fijo", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Private Sub LlenaCombos()
        Try
            'Configuracion Centro Costo
            lstCentroCosto = New List(Of e_CentroCosto)
            cbgCentroCostoAF.DataSource = lstCentroCosto
            With cbgCentroCostoAF
                For Each Col As UltraGridColumn In .DisplayLayout.Bands(0).Columns
                    Col.Hidden = True
                Next
                .DisplayMember = "Nombre"
                .ValueMember = "Id"
                .DropDownStyle = UltraComboStyle.DropDown
                .AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
                .AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
                .DisplayLayout.Bands(0).ColHeadersVisible = True
                .DisplayLayout.Bands(0).Columns("Nombre").Hidden = False
                .DisplayLayout.Bands(0).Columns("Nombre").Header.Caption = "Centro Costo"
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 320
                .DisplayLayout.Bands(0).Columns("Vehiculo").Hidden = False
                .DisplayLayout.Bands(0).Columns("Vehiculo").Width = 80
                '.DisplayLayout.AutoFitStyle = AutoFitStyle.ResizeAllColumns
                .DisplayLayout.ScrollStyle = ScrollStyle.Immediate
            End With
            'Centro (cambiar LlenaCentroCosto)
            LlenarComboMaestro(cboCentro, CentroPublic, 0)
            'Responsable
            oeCombo = New e_Combo
            oeCombo.Nombre = "JefesAreaAF"
            LlenarComboMaestro(cboResponsable, olCombo.Listar(oeCombo).OrderBy(Function(x) x.Nombre).ToList(), -1)
            'EstadoActivo
            oeCombo = New e_Combo
            oeCombo.Id = "Activo Fijo"
            oeCombo.Nombre = "ESTADO AF"
            LlenarComboMaestro(cboEstadoAF, olCombo.Listar(oeCombo).OrderBy(Function(x) x.Nombre).ToList(), 0)
            'ConceptoIngreso
            oeCombo = New e_Combo
            oeCombo.Id = "Activo Fijo"
            oeCombo.Nombre = "CONCEPTO INGRESO AF"
            LlenarComboMaestro(cboConceptoIngresoAF, olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList(), 0)
            'Grupo ActivoFijo (Cambio Llena SubActivoFijo)
            oeCombo = New e_Combo
            oeCombo.Id = "Activo Fijo"
            oeCombo.Nombre = "TIPO AF"
            LlenarComboMaestro(cboGrupoAF, olCombo.Listar(oeCombo).OrderBy(Function(x) x.Nombre).ToList(), 0)
            'Materiales
            lstMaterial = New List(Of e_Combo)
            cbgMaterial.DataSource = lstMaterial
            cbgMaterial.DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
            cbgMaterial.DisplayLayout.ScrollStyle = ScrollStyle.Immediate
            With cbgMaterial.DisplayLayout.Bands(0)
                .Columns("Id").Hidden = True
                .Columns("Nombre").Hidden = False
                .Columns("Nombre").Header.Caption = "Material"
                .Columns("Nombre").Width = 350
                .Columns("Descripcion").Hidden = True
            End With
            oeCombo = New e_Combo
            oeCombo.Nombre = "MaterialesAF"
            lstMaterial.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(x) x.Nombre).ToList())
            cbgMaterial.DataBind()
            'Concepto de Baja
            oeCombo = New e_Combo
            oeCombo.Id = "Activo Fijo"
            oeCombo.Nombre = "CONCEPTO BAJA AF"
            LlenarComboMaestro(cboConceptoBajaAF, olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList(), 0)
            'Tipo Documento
            lstTipoDocumento = New List(Of e_TipoDocumento)
            lstTipoDocumento.AddRange(olTipoDocumento.Listar(New e_TipoDocumento()))
            ComboPerido(cboMesR, AñoR)
            ComboPerido(cboMesD, AñoD)
            ComboPerido(cboMesDepActivos, AñoDepActivos)
            ComboPerido(cboMesListaDAF, AñoListaDAF)
            ' Detalle Concepto Ponderado - Depreciacion
            oeDetConPond = New e_DetalleConceptoPonderado : leDetConPond = New List(Of e_DetalleConceptoPonderado)
            oeDetConPond.TipoOperacion = "D"
            oeDetConPond.IdConceptoPonderado = "CP002"
            leDetConPond = olDetConPond.Listar(oeDetConPond)
            ' Metodo Depreciacion
            oeCombo = New e_Combo
            oeCombo.Id = "Activo Fijo"
            oeCombo.Nombre = "METODO DEPRECIACION"
            LlenarComboMaestro(cboMetodo, olCombo.Listar(oeCombo), -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboPerido(ByVal Combo As ISL.Controles.Combo, ByVal Anio As ISL.Win.Año)
        Try
            oePeriodo = New e_Periodo
            lstPeriodo = New List(Of e_Periodo)
            oePeriodo.Ejercicio = Anio.Año
            lstPeriodo.AddRange(olPeriodo.Listar(oePeriodo))
            oePeriodo = New e_Periodo
            lstPeriodo.Add(oePeriodo)
            With Combo
                .DisplayMember = "Mes"
                .ValueMember = "Id"
                .DataSource = lstPeriodo.OrderBy(Function(Item) Item.Mes).ToList
                If .Items.Count > 0 Then
                    .Text = FechaActual.Month
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub comboCuentallena(año As String)
        Try
            Dim oeCombo As New e_Combo
            Dim olCombo As New l_Combo
            oeCombo.Id = año
            oeCombo.Nombre = "CuentaContable"
            ListCuentaAF = New List(Of e_Combo)
            ListCuentaAF.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function lf_ValidarGuardar() As Boolean
        Try
            'Datos Obligatorios
            If String.IsNullOrWhiteSpace(txtDescripcionResumida.Text) Then
                MessageBox.Show("Ingrese nombre", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ficDatosAF.Tabs(0).Selected = True
                txtDescripcionResumida.Focus()
                Return False
            End If
            If cboEstadoAF.SelectedIndex < 0 Then
                MessageBox.Show("Seleccione estado", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ficDatosAF.Tabs(0).Selected = True
                cboEstadoAF.Focus()
                Return False
            End If
            If cboConceptoIngresoAF.SelectedIndex < 0 Then
                MessageBox.Show("Seleccione concepto de ingreso", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ficDatosAF.Tabs(0).Selected = True
                cboConceptoIngresoAF.Focus()
                Return False
            End If
            If cboGrupoAF.SelectedIndex < 0 Then
                MessageBox.Show("Seleccione tipo", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ficDatosAF.Tabs(0).Selected = True
                cboGrupoAF.Focus()
                Return False
            End If
            If cboSubGrupoAF.SelectedIndex < 0 Then
                MessageBox.Show("Seleccione sub tipo", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ficDatosAF.Tabs(0).Selected = True
                cboSubGrupoAF.Focus()
                Return False
            End If
            If cbgCentroCostoAF.SelectedRow Is Nothing Then
                MessageBox.Show("Seleccione centro de costos", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ficDatosAF.Tabs(0).Selected = True
                cbgCentroCostoAF.Focus()
                Return False
            End If
            If chkMaterial.Checked AndAlso cbgMaterial.SelectedRow Is Nothing Then
                MessageBox.Show("Seleccione material", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ficDatosAF.Tabs(0).Selected = True
                cbgMaterial.Focus()
                Return False
            End If
            If chkConjuntoAF.Checked AndAlso numCantidadAF.Value <= 1 Then
                MessageBox.Show("Ingrese un numero mayor a 1", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ficDatosAF.Tabs(0).Selected = True
                numCantidadAF.Focus()
                Return False
            End If
            'Con Documento
            If rbtInformacionCompra.Checked Then
                If opcTipoDocumento.CheckedIndex <> 2 AndAlso String.IsNullOrWhiteSpace(txtTipoDocumento.Tag) Then
                    MessageBox.Show("Seleccione el documento relacionado con la compra del activo", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ficDatosAF.Tabs(0).Selected = True
                    Return False
                End If
                If chkDepreciable.Checked AndAlso decVidaUtilIC.Value <= 0 Then
                    MessageBox.Show("Ingrese vida útil", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ficDatosAF.Tabs(0).Selected = True
                    decVidaUtilIC.Focus()
                    Return False
                End If
                If uneValorCompra.Value <= 0 Then
                    MessageBox.Show("Ingrese valor del activo", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ficDatosAF.Tabs(0).Selected = True
                    uneValorCompra.Focus()
                    Return False
                End If
                If uneValorCompra.Value <= uneValorResidual.Value Then
                    MessageBox.Show("El valor de compra del activo debe ser mayor al valor residual", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ficDatosAF.Tabs(0).Selected = True
                    uneValorResidual.Focus()
                    Return False
                End If
            Else 'Sin Documento
                If decValorLibroSC.Value <= 0 Then
                    MessageBox.Show("Ingrese valor de libro", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ficDatosAF.Tabs(0).Selected = True
                    decValorLibroSC.Focus()
                    Return False
                End If
                Dim TipoActivo As String = cboGrupoAF.Value
                Select Case TipoActivo
                    Case "1SI000009", "1SI000014", "1SI000015", "1SI000020", "1SI000011", "1SI000013", "1SI000010", "1SI000012", "1SI000008"
                    Case Else
                        If decDepreciacionAcumuladaSC.Value <= 0 Then
                            MessageBox.Show("Ingrese depreciacion acumulada", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ficDatosAF.Tabs(0).Selected = True
                            decDepreciacionAcumuladaSC.Focus()
                            Return False
                        End If
                        If decVidaUtilRemanenteSC.Value <= 0 Then
                            MessageBox.Show("Ingrese vida útil remanente", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ficDatosAF.Tabs(0).Selected = True
                            decDepreciacionAcumuladaSC.Focus()
                            Return False
                        End If
                End Select
                If decValorLibroSC.Value <= uneValorResidual.Value Then
                    MessageBox.Show("El valor libro del activo debe ser mayor al valor residual", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ficDatosAF.Tabs(0).Selected = True
                    uneValorResidual.Focus()
                    Return False
                End If
                If decValorLibroSC.Value - decDepreciacionAcumuladaSC.Value < uneValorResidual.Value Then
                    MessageBox.Show("la diferencia de valor libro y depreciacion acumulada debe ser mayor o igual al valor residual. Verificar", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ficDatosAF.Tabs(0).Selected = True
                    decValorLibroSC.Focus()
                    Return False
                End If
            End If
            If lstAFCuentaContable.Where(Function(x) x.TipoOperacion <> "E" And x.Actual = 1).Count = 0 Then
                MessageBox.Show("Debe agregar almenos un registro en informacion contable", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ficDatosAF.Tabs(1).Selected = True
                Return False
            End If
            If verIndFecActivacion.Checked AndAlso fecIngreso.Value.Date > fecActivacion.Value.Date Then
                MessageBox.Show("La fecha de ingreso no puede ser mayor a la fecha de adquisición", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
            If verIndBaja.Checked Then
                If verIndFecActivacion.Checked AndAlso fecBaja.Value.Date <= fecActivacion.Value.Date Then
                    MessageBox.Show("La fecha de baja debe ser mayor a la fecha de activación", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return False
                End If
                If lstReadecuacionAF.Where(Function(x) x.TipoOperacion <> "E").Count > 0 AndAlso
                    fecBaja.Value.Date <= lstReadecuacionAF.Where(Function(x) x.TipoOperacion <> "E").OrderByDescending(Function(x) x.FechaReadecuacion)(0).FechaReadecuacion Then
                    MessageBox.Show("La fecha de baja debe ser mayor a la última fecha de Adición/Retiro", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return False
                End If
                If cboConceptoBajaAF.SelectedIndex < 0 Then
                    MessageBox.Show("Seleccione el motivo de la baja del activo", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ficDatosAF.Tabs(0).Selected = True
                    cboConceptoBajaAF.Focus()
                    Return False
                End If
                oeCombo = New e_Combo
                oeCombo.Id = "Activo Fijo"
                oeCombo.Nombre = "CONCEPTO BAJA AF"
                lstCombo = New List(Of e_Combo)
                lstCombo = olCombo.Listar(oeCombo)
                If lstCombo.Where(Function(x) x.Id = cboConceptoBajaAF.Value And x.Descripcion = "1").Count > 0 AndAlso String.IsNullOrWhiteSpace(txtNumeroBaja.Tag) Then
                    MessageBox.Show("Seleccione documento de sustento para la desactivación del Activo", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ficDatosAF.Tabs(0).Selected = True
                    cboConceptoBajaAF.Focus()
                    Return False
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub mt_LimpiarDatosCuentasContables()
        Try
            txtCtaCompraDD.Tag = String.Empty
            txtCtaCompraDD.Text = String.Empty
            txtCtaCompraD.Text = String.Empty
            txtCtaCompraHH.Text = String.Empty
            txtCtaCompraH.Text = String.Empty
            txtCtaRevalorizacionDD.Text = String.Empty
            txtCtaRevalorizacionD.Text = String.Empty
            txtCtaRevalorizacionHH.Text = String.Empty
            txtCtaRevalorizacionH.Text = String.Empty
            txtCtaDepreciacionDD.Tag = String.Empty
            txtCtaDepreciacionDD.Text = String.Empty
            txtCtaDepreciacionD.Text = String.Empty
            txtCtaDepreciacionHH.Tag = String.Empty
            txtCtaDepreciacionHH.Text = String.Empty
            txtCtaDepreciacionH.Text = String.Empty
            txtCtaReadecuacionDD.Tag = String.Empty
            txtCtaReadecuacionDD.Text = String.Empty
            txtCtaReadecuacionD.Text = String.Empty
            txtCtaReadecuacionHH.Text = String.Empty
            txtCtaReadecuacionH.Text = String.Empty
            txtCtaDesactivacionDD.Tag = String.Empty
            txtCtaDesactivacionD.Text = String.Empty
            txtCtaDesactivacionDD.Text = String.Empty
            txtGastoFuncion.Text = String.Empty
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function lf_ValidarExtornarAsiento() As Boolean
        Try
            oePeriodo = New e_Periodo
            oePeriodo.Id = cboMesListaDAF.Value
            oePeriodo = olPeriodo.Obtener(oePeriodo)
            If Not String.IsNullOrWhiteSpace(oePeriodo.Id) AndAlso oePeriodo.CierreContabilidad = 1 Then
                MessageBox.Show("No se puede extornar el asiento seleccionado porque el periodo ya esta cerrado", "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function lf_ValidarReclasificar() As Boolean
        Try
            If griLista.ActiveRow.Cells("IndBaja").Value = 1 Then
                MessageBox.Show("No se puede reclasificar el Activo " & griLista.ActiveRow.Cells("DescripcionResumida").Value.ToString() & "," & Environment.NewLine & _
                                "Porque esta dado de baja", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
            If Convert.ToBoolean(griLista.ActiveRow.Cells("IndReclasificado").Value) Then
                MessageBox.Show("El activo seleccionado ya ha sido reclasificado", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub mt_Reclasificar()
        Try
            mt_MostrarMsjeEspera()
            If gf_ValidarFilaSeleccionada(griLista) Then
                If lf_ValidarReclasificar() Then
                    Operacion = "Reclasificar"
                    Inicializar()
                    oeActivoFijo = New e_ActivoFijo
                    oeActivoFijo.IdAFReclasificado = griLista.ActiveRow.Cells("Id").Value.ToString().Trim()
                    'Obtener monto con el que iniciará el nuevo AF
                    Dim oeAF As New e_ActivoFijo
                    oeAF.Id = oeActivoFijo.IdAFReclasificado
                    oeAF = olActivoFijo.Obtener(oeAF, True, True)
                    If Not String.IsNullOrWhiteSpace(oeAF.Id) Then
                        rbtInformacionCompra.Enabled = False
                        rbtSituacionAFecha.Enabled = False
                        opcTipoDocumento.CheckedIndex = 2
                        opcTipoDocumento.Enabled = False
                        uneValorCompra.Value = lf_CalcularValorAFReclasificado(oeAF)
                        uneValorCompra.ReadOnly = True
                    End If
                    MostrarTabs(1, ficActivoFijo, 1)
                    mt_ControlBotoneria()
                    cboCentro.Focus()
                End If
            End If
        Catch ex As Exception
            Throw ex
        Finally
            mt_QuitarMsjeEspera()
        End Try
    End Sub

    Private Function lf_CalcularValorAFReclasificado(oeAF As e_ActivoFijo) As Double
        Try
            Dim Total As Double = 0.0
            If oeAF.IndDocumento = 1 Then
                'Con Documento
                oeMovimientoDocumento = New e_MovimientoDocumento
                oeMovimientoDocumento.Id = oeAF.IdDocumento
                oeMovimientoDocumento = olMovimientoDocumento.Obtener(oeMovimientoDocumento)
                If Not String.IsNullOrWhiteSpace(oeMovimientoDocumento.Id) Then
                    Total += oeMovimientoDocumento.SubTotal
                End If
            Else
                If oeAF.IndDocumento = 0 Then
                    'Situacion contable a una fecha
                    Total += oeAF.ValorLibro
                    Total -= oeAF.DepreciacionAcumulada
                Else
                    'Obligacion o sin Documento
                    Total += oeAF.ValorCompra
                End If
            End If
            Total -= oeAF.ListAF_CuentaContable.Sum(Function(x) x.DepreciacionAcumulada)
            Total += oeAF.ListReadecuacionAF.Sum(Function(x) x.MontoAgregar)
            Return Total
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub mt_DarBajaActivo()
        Try
            mt_MostrarMsjeEspera()
            If gf_ValidarFilaSeleccionada(griLista) Then

                Operacion = "Editar"
                Inicializar()
                mt_MostrarDatos()
                uegbDatosBaja.Visible = True
                uegbDatosBaja.Expanded = True
                verIndBaja.Checked = True
                fecBaja.Value = FechaActual.Date
                MostrarTabs(1, ficActivoFijo, 1)
                mt_ControlBotoneria()
                fecBaja.Focus()

            End If
        Catch ex As Exception
            Throw ex
        Finally
            mt_QuitarMsjeEspera()
        End Try
    End Sub

    Private Const strPermisoEjecutarDepreciacion As String = "EJECUTAR DEPRECIACION"
    Private Function lf_ValidarDepreciacion() As Boolean
        Try
            'Dim olTrabajadorSeg As New l_TrabajadorSeguridad
            'If Not olTrabajadorSeg.Permisos(gUsuarioSGI.IdTrabajador, strPermisoEjecutarDepreciacion) Then
            '    MessageBox.Show("Usted no tiene permiso para Ejecutar la Depreciación Mensual", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Return False
            'End If
            'oePeriodo = New e_Periodo
            'oePeriodo.Id = cboMesDepActivos.Value
            'oePeriodo = olPeriodo.Obtener(oePeriodo)
            'If Not String.IsNullOrWhiteSpace(oePeriodo.Id) Then
            '    If FechaActual.Date < oePeriodo.FechaFin.AddDays(-10).Date Then
            '        MessageBox.Show("La depreciación del periodo " & oePeriodo.Codigo & Environment.NewLine & _
            '                        "se podrá realizar a partir del " & oePeriodo.FechaFin.AddDays(-10).Date.ToString("dd/MM/yyyy"), "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '        Return False
            '    End If
            'End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Eventos"

    Private Sub frm_ActivoFijo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            AñoIC.numAño.TabNavigation = UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
            gf_AsignarEventoSeleccionarTexto(Me)
            MostrarTabs(0, ficActivoFijo, 2)
            mt_InicializarLogica()
            'Combo Grilla
            mt_ConfigurarComboGrilla()
            LlenaCombos()
            'Configurar Grillas
            mt_ConfigurarGrillas()
            'Totales
            CalcularTotales(griLista, "ValorCompra", "ValorLibro")
            'CalcularTotales(griCtaCtbleDAF, "ValorResidual", "DepreciacionAcumulada", "Observacion")
            'CalcularTotales(griListaDAF, "Valor", "Importe")
            CalcularTotales(griAsiento, "Valor", "Importe")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_ActivoFijo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            ControlBoton()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_ActivoFijo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            instancia = Nothing
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_ActivoFijo_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Try
            mt_ControlBotoneria()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub AñoIC_Validated(sender As Object, e As EventArgs) Handles AñoIC.Validated
        Try
            If cboSubGrupoAF.SelectedIndex >= 0 Then
                comboCuentallena(AñoIC.Año)
                oeTipoActivoCtaCtble = New e_TipoActivoFijo_CtaCtble
                oeTipoActivoCtaCtble.TipoOperacion = "EDT"
                oeTipoActivoCtaCtble.IdTipoActivoFijo = cboSubGrupoAF.Value
                oeTipoActivoCtaCtble.Ejercicio = AñoIC.Año
                lstTipoActivoCtaCtble = New List(Of e_TipoActivoFijo_CtaCtble)
                lstTipoActivoCtaCtble.AddRange(olTipoActivoFijoCtaCtble.Listar(oeTipoActivoCtaCtble))
                If lstTipoActivoCtaCtble.Count > 0 Then
                    If ListCuentaAF.Where(Function(x) x.Id = lstTipoActivoCtaCtble(0).IdCtaCtbleCompraD).Count > 0 Then
                        txtCtaCompraDD.Tag = lstTipoActivoCtaCtble(0).IdCtaCtbleCompraD
                        txtCtaCompraDD.Text = ListCuentaAF.Where(Function(x) x.Id = lstTipoActivoCtaCtble(0).IdCtaCtbleCompraD)(0).Nombre
                        txtCtaCompraD.Text = ListCuentaAF.Where(Function(x) x.Id = lstTipoActivoCtaCtble(0).IdCtaCtbleCompraD)(0).Descripcion
                    End If
                    If ListCuentaAF.Where(Function(x) x.Id = lstTipoActivoCtaCtble(0).IdCtaCtbleCompraH).Count > 0 Then
                        txtCtaCompraHH.Text = ListCuentaAF.Where(Function(x) x.Id = lstTipoActivoCtaCtble(0).IdCtaCtbleCompraH)(0).Nombre
                        txtCtaCompraH.Text = ListCuentaAF.Where(Function(x) x.Id = lstTipoActivoCtaCtble(0).IdCtaCtbleCompraH)(0).Descripcion
                    End If
                    If ListCuentaAF.Where(Function(x) x.Id = lstTipoActivoCtaCtble(0).IdCtaCtbleRevalorizacionD).Count > 0 Then
                        txtCtaRevalorizacionDD.Text = ListCuentaAF.Where(Function(x) x.Id = lstTipoActivoCtaCtble(0).IdCtaCtbleRevalorizacionD)(0).Nombre
                        txtCtaRevalorizacionD.Text = ListCuentaAF.Where(Function(x) x.Id = lstTipoActivoCtaCtble(0).IdCtaCtbleRevalorizacionD)(0).Descripcion
                    End If
                    If ListCuentaAF.Where(Function(x) x.Id = lstTipoActivoCtaCtble(0).IdCtaCtbleRevalorizacionH).Count > 0 Then
                        txtCtaRevalorizacionHH.Text = ListCuentaAF.Where(Function(x) x.Id = lstTipoActivoCtaCtble(0).IdCtaCtbleRevalorizacionH)(0).Nombre
                        txtCtaRevalorizacionH.Text = ListCuentaAF.Where(Function(x) x.Id = lstTipoActivoCtaCtble(0).IdCtaCtbleRevalorizacionH)(0).Descripcion
                    End If
                    If ListCuentaAF.Where(Function(x) x.Id = lstTipoActivoCtaCtble(0).IdCtaCtbleDeprecD).Count > 0 Then
                        txtCtaDepreciacionDD.Tag = lstTipoActivoCtaCtble(0).IdCtaCtbleDeprecD
                        txtCtaDepreciacionDD.Text = ListCuentaAF.Where(Function(x) x.Id = lstTipoActivoCtaCtble(0).IdCtaCtbleDeprecD)(0).Nombre
                        txtCtaDepreciacionD.Text = ListCuentaAF.Where(Function(x) x.Id = lstTipoActivoCtaCtble(0).IdCtaCtbleDeprecD)(0).Descripcion
                    End If
                    If ListCuentaAF.Where(Function(x) x.Id = lstTipoActivoCtaCtble(0).IdCtaCtbleDeprecH).Count > 0 Then
                        txtCtaDepreciacionHH.Tag = lstTipoActivoCtaCtble(0).IdCtaCtbleDeprecH
                        txtCtaDepreciacionHH.Text = ListCuentaAF.Where(Function(x) x.Id = lstTipoActivoCtaCtble(0).IdCtaCtbleDeprecH)(0).Nombre
                        txtCtaDepreciacionH.Text = ListCuentaAF.Where(Function(x) x.Id = lstTipoActivoCtaCtble(0).IdCtaCtbleDeprecH)(0).Descripcion
                    End If
                    If ListCuentaAF.Where(Function(x) x.Id = lstTipoActivoCtaCtble(0).IdCtaCtbleReadecuacionD).Count > 0 Then
                        txtCtaReadecuacionDD.Tag = lstTipoActivoCtaCtble(0).IdCtaCtbleReadecuacionD
                        txtCtaReadecuacionDD.Text = ListCuentaAF.Where(Function(x) x.Id = lstTipoActivoCtaCtble(0).IdCtaCtbleReadecuacionD)(0).Nombre
                        txtCtaReadecuacionD.Text = ListCuentaAF.Where(Function(x) x.Id = lstTipoActivoCtaCtble(0).IdCtaCtbleReadecuacionD)(0).Descripcion
                    End If
                    If ListCuentaAF.Where(Function(x) x.Id = lstTipoActivoCtaCtble(0).IdCtaCtbleReadecuacionH).Count > 0 Then
                        txtCtaReadecuacionHH.Text = ListCuentaAF.Where(Function(x) x.Id = lstTipoActivoCtaCtble(0).IdCtaCtbleReadecuacionH)(0).Nombre
                        txtCtaReadecuacionH.Text = ListCuentaAF.Where(Function(x) x.Id = lstTipoActivoCtaCtble(0).IdCtaCtbleReadecuacionH)(0).Descripcion
                    End If
                    If ListCuentaAF.Where(Function(x) x.Id = lstTipoActivoCtaCtble(0).IdCtaCtbleBajaD).Count > 0 Then
                        txtCtaDesactivacionDD.Tag = lstTipoActivoCtaCtble(0).IdCtaCtbleBajaD
                        txtCtaDesactivacionDD.Text = ListCuentaAF.Where(Function(x) x.Id = lstTipoActivoCtaCtble(0).IdCtaCtbleBajaD)(0).Nombre
                        txtCtaDesactivacionD.Text = ListCuentaAF.Where(Function(x) x.Id = lstTipoActivoCtaCtble(0).IdCtaCtbleBajaD)(0).Descripcion
                    End If
                    If Not String.IsNullOrWhiteSpace(lstTipoActivoCtaCtble(0).IdGastoFuncion) Then
                        lstCombo = New List(Of e_Combo)
                        oeCombo = New e_Combo
                        oeCombo.Nombre = "GASTO FUNCION"
                        lstCombo.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList())
                        If lstCombo.Where(Function(x) x.Id = lstTipoActivoCtaCtble(0).IdGastoFuncion).Count > 0 Then
                            txtGastoFuncion.Text = lstCombo.Where(Function(x) x.Id = lstTipoActivoCtaCtble(0).IdGastoFuncion)(0).Nombre
                        End If
                    End If
                Else
                    mt_LimpiarDatosCuentasContables()
                End If
            Else
                mt_LimpiarDatosCuentasContables()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub AñoD_Validated(sender As Object, e As EventArgs) Handles AñoD.Validated
        Try
            ComboPerido(cboMesD, AñoD)
            comboCuentallena(AñoD.Año)
            LlenarComboMaestro(cboCtaOrigenD, ListCuentaAF.Where(Function(Item) Microsoft.VisualBasic.Left(Item.Nombre, 2) = "68").ToList, 1)
            LlenarComboMaestro(cboCtaDestinoD, ListCuentaAF.Where(Function(Item) Microsoft.VisualBasic.Left(Item.Nombre, 2) = "39").ToList, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAgregarD_Click(sender As Object, e As EventArgs) Handles btnAgregarD.Click
        Try
            ValidarCombo(cboMesD, "Mes")
            oeActivoFijo.ListDepreciacionAF = griDepreciacion.DataSource
            With oeDepreciacionAF
                .IdPeriodo = cboMesD.Value
                .Periodo = AñoD.Año & "-" & cboMesD.Text
                .IdAFCuentaContable = cboAFCuentaContableD.Value
                .IdCuentaOrigen = cboCtaOrigenD.Value
                .IdCuentaDestino = cboCtaDestinoD.Value
                '.CuentaOrigen = cboCtaOrigenD.Text
                '.CuentaDestino = cboCtaDestinoD.Text
                .Valor = decValorD.Value
                .Importe = decImporteD.Value
                .Observacion = txtObservacionD.Text
                .Actual = IIf(verActualD.Checked, 1, 0)
            End With
            oeActivoFijo.ListDepreciacionAF.Add(oeDepreciacionAF)
            griDepreciacion.DataBind()
            oeDepreciacionAF = New e_DepreciacionActivoFijo
            cboMesD.Focus()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboCtaOrigenD_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles cboCtaOrigenD.InitializeLayout
        Try

            With cboCtaOrigenD.DisplayLayout.Bands(0)
                .Columns("Id").Hidden = True
                .Columns("Nombre").Hidden = False
                .Columns("Nombre").Header.Caption = "Cuenta"
                .Columns("Nombre").Width = 50
                .Columns("Descripcion").Hidden = False
                .Columns("Descripcion").Width = 300
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboCtaDestinoD_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles cboCtaDestinoD.InitializeLayout
        Try
            With cboCtaDestinoD.DisplayLayout.Bands(0)
                .Columns("Id").Hidden = True
                .Columns("Nombre").Hidden = False
                .Columns("Nombre").Header.Caption = "Cuenta"
                .Columns("Nombre").Width = 50
                .Columns("Descripcion").Hidden = False
                .Columns("Descripcion").Width = 300
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboCtaOrigenD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboCtaOrigenD.KeyPress
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                cboCtaOrigenD.PerformAction(UltraWinGrid.UltraComboAction.Dropdown)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboCtaDestinoD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboCtaDestinoD.KeyPress
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                cboCtaDestinoD.PerformAction(UltraWinGrid.UltraComboAction.Dropdown)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboCtaOrigenD_ValueChanged(sender As Object, e As EventArgs) Handles cboCtaOrigenD.ValueChanged
        Try
            If cboCtaOrigenD.Value IsNot Nothing Then
                comboCuentallena(AñoD.Año)
                Dim leCta As New List(Of e_Combo)
                leCta = ListCuentaAF.ToList
                leCta = leCta.Where(Function(item) item.Id = cboCtaOrigenD.Value).ToList
                If leCta.Count > 0 Then
                    txtCtaOrigenD.Value = leCta(0).Descripcion
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboCtaDestinoD_ValueChanged(sender As Object, e As EventArgs) Handles cboCtaDestinoD.ValueChanged
        Try
            If cboCtaDestinoD.Value IsNot Nothing Then
                comboCuentallena(AñoD.Año)
                Dim leCta As New List(Of e_Combo)
                leCta = ListCuentaAF.ToList
                leCta = leCta.Where(Function(item) item.Id = cboCtaDestinoD.Value).ToList
                If leCta.Count > 0 Then
                    txtCtaDestinoD.Value = leCta(0).Descripcion
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub verConjuntoAF_CheckedChanged(sender As Object, e As EventArgs) Handles chkConjuntoAF.CheckedChanged
        Try
            numCantidadAF.Enabled = chkConjuntoAF.Checked
            If chkConjuntoAF.Checked Then
                numCantidadAF.Value = 1
            Else
                numCantidadAF.Value = 1
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub AñoR_Validated(sender As Object, e As EventArgs) Handles AñoR.Validated
        Try
            ComboPerido(cboMesR, AñoR)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Const IdMonedaSoles As String = "1CH01"
    Private Sub btnBuscarDoc_Click(sender As Object, e As EventArgs) Handles btnBuscarDoc.Click
        Try
            Dim FRM As New frm_BuscarDocumento
            FRM.strIndServicioMaterial = "M"
            FRM.StartPosition = FormStartPosition.CenterScreen
            FRM.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
            If opcTipoDocumento.CheckedIndex = 0 Then 'Documento
                IndCuentaCP = 1
                If FRM.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                    oeMovimientoDocumento = New e_MovimientoDocumento
                    oeMovimientoDocumento = FRM.oeDocumento
                    With oeMovimientoDocumento
                        fecCompraIC.Value = .FechaEmision
                        txtTipoDocumento.Tag = .Id
                        txtTipoDocumento.Text = .Glosa
                        txtProveedor.Text = .NombreProveedor
                        txtSerie.Text = .Serie
                        txtNroDocumentoIC.Text = .Numero
                        If rbtInformacionCompra.Checked Then
                            If .IdMoneda = IdMonedaSoles Then
                                uneValorCompra.Value = .SubTotal
                            Else
                                uneValorCompra.Value = .SubTotal * .TipoCambio
                            End If
                        End If
                        uneValorCompra.Focus()
                    End With
                End If
            Else 'Obligación
                IndCuentaCP = 0
                If FRM.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                    With FRM.oeObligacionFin
                        txtTipoDocumento.Text = .IdTipoObligacion
                        txtTipoDocumento.Tag = .IdContrato
                        txtProveedor.Text = .Banco
                        txtSerie.Text = String.Empty
                        fecCompraIC.Value = .FechaVencimiento
                        txtNroDocumentoIC.Text = String.Empty
                        uneValorCompra.Value = 0.0
                        uneValorCompra.Focus()
                    End With
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ficDatosAF_Click(sender As Object, e As EventArgs) Handles ficDatosAF.Click
        Try
            If Operacion = "Editar" Then
                If ficDatosAF.Tabs(4).Selected = True Then
                    'ListAFCuentaContable = New List(Of e_Combo)
                    'oeCombo = New e_Combo
                    'oeCombo.Id = txtIdAF.Text
                    'oeCombo.Nombre = "AFCuentaContable"
                    'ListAFCuentaContable.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
                    'LlenarComboMaestro(cboAFCuentaContableD, ListAFCuentaContable, 0)
                    'CrearComboGrid("IdAFCuentaContable", "Nombre", griDepreciacion, olCombo.ComboGrilla(ListAFCuentaContable), True)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griLista_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griLista.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            If EliminarAF() Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        Catch ex As Exception
            e.Cancel = True
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboAFCuentaContableD_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles cboAFCuentaContableD.InitializeLayout
        Try
            With cboAFCuentaContableD.DisplayLayout.Bands(0)
                .Columns("Id").Hidden = True
                .Columns("Nombre").Hidden = False
                .Columns("Nombre").Header.Caption = "Descripcion Informacion Contable"
                .Columns("Nombre").Width = 300
                .Columns("Descripcion").Hidden = False
                .Columns("Descripcion").Width = 200
                .Columns("Descripcion").Header.Caption = "Tipo Adquisicion"
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griReadecuacion_CellChange(sender As Object, e As CellEventArgs) Handles griReadecuacion.CellChange
        Try
            griReadecuacion.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDepreciacion_CellChange(sender As Object, e As CellEventArgs) Handles griDepreciacion.CellChange
        Try
            griDepreciacion.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDepreciacion_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griDepreciacion.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            If griDepreciacion.ActiveRow.Cells("IdAsiento").Text.Trim <> "" Then
                If MessageBox.Show("¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                    e.Cancel = True
                End If
            Else
                Throw New Exception("Registro no se puede eliminar, tiene asiento contable generado.")
            End If
        Catch ex As Exception
            e.Cancel = True
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griLista_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles griLista.DoubleClickRow
        Try
            Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    'Private Sub AñoDAF_Validated(sender As Object, e As EventArgs)
    '    Try
    '        ComboPerido(cboMesDAF, AñoDAF)
    '        comboCuentallena(AñoDAF.Año)
    '        LlenarComboMaestro(cboCtaOrigenDAF, ListCuentaAF.Where(Function(Item) Microsoft.VisualBasic.Left(Item.Nombre, 2) = "68").ToList, 1)
    '        LlenarComboMaestro(cboCtaDestinoDAF, ListCuentaAF.Where(Function(Item) Microsoft.VisualBasic.Left(Item.Nombre, 2) = "39").ToList, 1)
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    End Try
    'End Sub

    'Private Sub cboCtaOrigenDAF_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs)
    '    Try
    '        With cboCtaOrigenDAF.DisplayLayout.Bands(0)
    '            .Columns("Id").Hidden = True
    '            .Columns("Nombre").Hidden = False
    '            .Columns("Nombre").Header.Caption = "Cuenta"
    '            .Columns("Nombre").Width = 50
    '            .Columns("Descripcion").Hidden = False
    '            .Columns("Descripcion").Width = 300
    '        End With
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    End Try
    'End Sub

    'Private Sub cboCtaOrigenDAF_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    Try
    '        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
    '            cboCtaOrigenDAF.PerformAction(UltraWinGrid.UltraComboAction.Dropdown)
    '        End If
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    End Try
    'End Sub

    'Private Sub cboCtaOrigenDAF_ValueChanged(sender As Object, e As EventArgs)
    '    Try
    '        If cboCtaOrigenDAF.Value IsNot Nothing Then
    '            comboCuentallena(AñoDAF.Año)
    '            Dim leCta As New List(Of e_Combo)
    '            leCta = ListCuentaAF.ToList
    '            leCta = leCta.Where(Function(item) item.Id = cboCtaOrigenDAF.Value).ToList
    '            If leCta.Count > 0 Then
    '                txtCtaOrigenDAF.Value = leCta(0).Descripcion
    '            End If
    '        End If
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    End Try
    'End Sub

    'Private Sub cboCtaDestinoDAF_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs)
    '    Try
    '        With cboCtaDestinoDAF.DisplayLayout.Bands(0)
    '            .Columns("Id").Hidden = True
    '            .Columns("Nombre").Hidden = False
    '            .Columns("Nombre").Header.Caption = "Cuenta"
    '            .Columns("Nombre").Width = 50
    '            .Columns("Descripcion").Hidden = False
    '            .Columns("Descripcion").Width = 300
    '        End With
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    End Try
    'End Sub

    'Private Sub cboCtaDestinoDAF_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    Try
    '        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
    '            cboCtaDestinoDAF.PerformAction(UltraWinGrid.UltraComboAction.Dropdown)
    '        End If
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    End Try
    'End Sub

    'Private Sub cboCtaDestinoDAF_ValueChanged(sender As Object, e As EventArgs)
    '    Try
    '        If cboCtaDestinoDAF.Value IsNot Nothing Then
    '            Dim leCta As New List(Of e_Combo)
    '            leCta = ListCuentaAF.ToList
    '            leCta = leCta.Where(Function(item) item.Id = cboCtaDestinoDAF.Value).ToList
    '            If leCta.Count > 0 Then
    '                txtCtaDestinoDAF.Value = leCta(0).Descripcion
    '            End If
    '        End If
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    End Try
    'End Sub

    'Private Sub btnAgregarDAF_Click(sender As Object, e As EventArgs)
    '    Try
    '        ListVehiculosDAF = New List(Of e_Combo)
    '        oeDepreciacionAF = New e_DepreciacionActivoFijo
    '        ValidarCombo(cboMesDAF, "Mes")
    '        If txtGlosaAsientoDAF.Text.Trim = "" Then
    '            txtGlosaAsientoDAF.Focus()
    '            Throw New Exception("Ingrese Glosa para el Asiento a Generar")
    '        End If
    '        If txtObservacionDAF.Text.Trim = "" Then
    '            txtObservacionDAF.Focus()
    '            Throw New Exception("Ingrese Observacion para Generar la Depreciacion de AF.")
    '        End If
    '        If FecAsiento.Value.Month <> cboMesDAF.Text Then
    '            FecAsiento.Focus()
    '            Throw New Exception("Fecha no corresponde al periodo seleccionado, verificar.")
    '        End If
    '        oeActivoFijo.ListDepreciacionAF = griListaDAF.DataSource
    '        For Each Fila As UltraGridRow In griCtaCtbleDAF.Rows.Where(Function(Item) Item.Cells("Actual").Value = 1)
    '            If CDbl(Fila.Cells("Observacion").Value) > 0 Then
    '                With oeDepreciacionAF
    '                    .IdActivoFijo = Fila.Cells("IdActivoFijo").Value
    '                    .IdPeriodo = cboMesDAF.Value
    '                    .Periodo = AñoDAF.Año & "-" & cboMesDAF.Text
    '                    .IdAFCuentaContable = Fila.Cells("Id").Value
    '                    '.AFCuentaContable = Fila.Cells("Descripcion").Text
    '                    .IdCuentaOrigen = cboCtaOrigenDAF.Value
    '                    .IdCuentaDestino = cboCtaDestinoDAF.Value
    '                    '.CuentaOrigen = cboCtaOrigenDAF.Text
    '                    '.CuentaDestino = cboCtaDestinoDAF.Text
    '                    .Valor = decValorDAF.Value
    '                    .Importe = Fila.Cells("Observacion").Value
    '                    .Observacion = txtObservacionDAF.Text & " - " & txtGlosaAsientoDAF.Text
    '                    .UsuarioCreacion = gUsuarioSGI.Id
    '                End With
    '                oeActivoFijo.ListDepreciacionAF.Add(oeDepreciacionAF)
    '                griListaDAF.DataBind()
    '                If olActivoFijo.ListarDepreciacionAF(oeDepreciacionAF).Count > 0 Then
    '                    Fila.Appearance.BackColor = Me.ColorAdvertencia.Color
    '                End If
    '                If Fila.Cells("UsuarioCreacion").Value.ToString.Trim <> "" Then
    '                    oeCombo = New e_Combo
    '                    oeCombo.Id = Fila.Cells("UsuarioCreacion").Value
    '                    oeCombo.Descripcion = Fila.Cells("Observacion").Value
    '                    ListVehiculosDAF.Add(oeCombo)
    '                End If
    '                oeDepreciacionAF = New e_DepreciacionActivoFijo
    '            Else
    '                Fila.Appearance.BackColor = Me.ColorAdvertencia.Color
    '            End If
    '        Next
    '        oeAsiento = New e_Asiento
    '        MovimientoAnalisis(ListVehiculosDAF, cboCtaOrigenDAF.Value, 1, verCtaODH.CheckedIndex)
    '        MovimientoAnalisis(ListVehiculosDAF, cboCtaDestinoDAF.Value, 2, verCtaDDH.CheckedIndex)
    '        With oeAsiento
    '            .TipoOperacion = "I"
    '            .IdPeriodo = cboMesDAF.Value
    '            .IdMoneda = cboMoneda.Value
    '            .TipoCambio = decTC.Value
    '            .Fecha = FecAsiento.Value
    '            '1CH000020 Diario
    '            .IdTipoAsiento = "1CH000020"
    '            .Glosa = txtGlosaAsientoDAF.Text
    '            .GlosaImprime = txtGlosaAsientoDAF.Text
    '            .TotalDebe = decValorDAF.Value
    '            .TotalHaber = decValorDAF.Value
    '            .IdUsuarioCrea = gUsuarioSGI.Id
    '            .IndOrigen = 40
    '        End With
    '        cboMesDAF.Focus()
    '    Catch ex As Exception
    '        griListaDAF.DataSource = New List(Of e_DepreciacionActivoFijo)
    '        mensajeEmergente.Problema(ex.Message, True)
    '    End Try
    'End Sub

    'Private Sub griCtaCtbleDAF_CellChange(sender As Object, e As CellEventArgs)
    '    Try
    '        griCtaCtbleDAF.UpdateData()
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    End Try
    'End Sub

    'Private Sub griCtaCtbleDAF_AfterCellUpdate(sender As Object, e As CellEventArgs)
    '    Try
    '        Dim Total_Selec As Integer = 0
    '        Select Case e.Cell.Column.Key
    '            Case "Actual"
    '                If griCtaCtbleDAF.Rows.Count > 1 Then
    '                    If griCtaCtbleDAF.ActiveRow.Cells("Actual").Value Then
    '                        Total_Selec += 1
    '                        griCtaCtbleDAF.ActiveRow.Appearance.BackColor = Color.Aqua
    '                        griCtaCtbleDAF.ActiveRow.Fixed = True
    '                    Else
    '                        Total_Selec -= 1
    '                        griCtaCtbleDAF.ActiveRow.Appearance.BackColor = Color.White
    '                        griCtaCtbleDAF.ActiveRow.Fixed = False
    '                    End If
    '                End If
    '        End Select
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    End Try
    'End Sub

    'Private Sub decValorDAF_ValueChanged(sender As Object, e As EventArgs)
    '    Try
    '        decImporteDAF.Value = (decValorDAF.Value * numPorcentajeDAF.Value) / 12
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    End Try
    'End Sub

    'Private Sub btnGuardarDAF_Click(sender As Object, e As EventArgs)
    '    Try
    '        mt_MostrarMsjeEspera()
    '        oeActivoFijo = New e_ActivoFijo
    '        oeActivoFijo.TipoOperacion = "D"
    '        oeActivoFijo.ListDepreciacionAF = griListaDAF.DataSource
    '        If oeActivoFijo.ListDepreciacionAF.Count > 0 Then
    '            If MessageBox.Show("Se va depreciar todos los REGISTROS de la lista activa seleccionados desea continuar ? ", _
    '                                   "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
    '                oeActivoFijo.AsientoAF = oeAsiento
    '                If olActivoFijo.Guardar(oeActivoFijo) Then
    '                    mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente.", True)
    '                    griCtaCtbleDAF.DataSource = New List(Of e_ActivoFijo_CuentaContable)
    '                    griListaDAF.DataSource = New List(Of e_DepreciacionActivoFijo)
    '                End If
    '            End If
    '        Else
    '            Throw New Exception("Ingrese Activos por Depreciar segun Periodo Informado")
    '        End If
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    Finally
    '        mt_QuitarMsjeEspera()
    '    End Try
    'End Sub

    Private Sub griListaDAF_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs)
        Try
            e.DisplayPromptMsg = False
            If MessageBox.Show(Me.Text & ": ¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    'Private Sub griListaDAF_CellChange(sender As Object, e As CellEventArgs)
    '    Try
    '        griListaDAF.UpdateData()
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    End Try
    'End Sub

    Private Sub griCtaCtbleDAF_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs)
        Try
            e.DisplayPromptMsg = False
            e.Cancel = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    'Private Sub cboGastoFuncionDAF_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs)
    '    Try
    '        With cboGastoFuncionDAF.DisplayLayout.Bands(0)
    '            .Columns("Id").Hidden = True
    '            .Columns("Nombre").Hidden = False
    '            .Columns("Nombre").Header.Caption = "Nombre"
    '            .Columns("Nombre").Width = 300
    '            .Columns("Descripcion").Hidden = True
    '        End With
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    End Try
    'End Sub

    'Private Sub cboCentroCostoDAF_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs)
    '    Try
    '        With cboCentroCostoDAF.DisplayLayout.Bands(0)
    '            .Columns("Id").Hidden = True
    '            .Columns("Nombre").Hidden = False
    '            .Columns("Nombre").Header.Caption = "Centro de Costo"
    '            .Columns("Nombre").Width = 300
    '            .Columns("Descripcion").Hidden = False
    '            .Columns("Descripcion").Width = 100
    '            .Columns("Descripcion").Header.Caption = "Sede Empresa"
    '        End With
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    End Try
    'End Sub

    'Private Sub cboTipoActivoDAF_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs)
    '    Try
    '        With cboTipoActivoDAF.DisplayLayout.Bands(0)
    '            .Columns("Id").Hidden = True
    '            .Columns("Nombre").Hidden = False
    '            .Columns("Nombre").Width = 250
    '            .Columns("Descripcion").Hidden = True
    '        End With
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    End Try
    'End Sub

    'Private Sub cboSubTipoActivoDAF_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs)
    '    Try
    '        With cboSubTipoActivoDAF.DisplayLayout.Bands(0)
    '            .Columns("Id").Hidden = True
    '            .Columns("Nombre").Hidden = False
    '            .Columns("Nombre").Width = 250
    '            .Columns("Descripcion").Hidden = True
    '        End With
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    End Try
    'End Sub

    'Private Sub FecAsiento_Validated(sender As Object, e As EventArgs)
    '    Try
    '        decTC.Value = TipoCambio(FecAsiento.Value)(0)
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    End Try
    'End Sub

    'Private Sub btnConsultarAF_Click(sender As Object, e As EventArgs)
    '    Try
    '        oeAFCuentaContable = New e_ActivoFijo_CuentaContable
    '        With oeAFCuentaContable
    '            .TipoOperacion = "D"
    '            '.IdTipoActivo = cboTipoActivoDAF.Value
    '            '.IdSubTipoActivo = cboSubTipoActivoDAF.Value
    '        End With
    '        griCtaCtbleDAF.DataSource = olActivoFijo.ListarAF_CuentaContable(oeAFCuentaContable)
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    End Try
    'End Sub

    'Private Sub btnActualizarMasivaDAF_Click(sender As Object, e As EventArgs)
    '    Try
    '        Dim Valor As Double = 0
    '        Dim CantidadDAF As Integer = 0
    '        For Each Fila As UltraGridRow In griCtaCtbleDAF.Rows.Where(Function(Item) Item.Cells("Actual").Value = 1)
    '            Fila.Cells("Observacion").Value = Decimal.Round((Fila.Cells("ValorResidual").Value * numPorcentajeDAF.Value) / 12, 2)
    '            Valor += Fila.Cells("Observacion").Value
    '            CantidadDAF += 1
    '        Next
    '        decValorDAF.Value = Valor
    '        numCantidadDAF.Value = CantidadDAF
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    End Try
    'End Sub

    'Private Sub VerSeleccion_CheckedChanged(sender As Object, e As EventArgs)
    '    Try
    '        For Each fila As UltraGridRow In griCtaCtbleDAF.Rows.Where(Function(item) item.IsFilteredOut = False)
    '            fila.Cells("Actual").Value = IIf(VerSeleccion.Checked, 1, 0)
    '        Next
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    End Try
    'End Sub

    Private Sub AñoListaDAF_Validated(sender As Object, e As EventArgs) Handles AñoListaDAF.Validated
        Try
            ComboPerido(cboMesListaDAF, AñoListaDAF)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListarDAFPeriodo_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griAsiento.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            e.Cancel = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub verNroAsiento_CheckedChanged(sender As Object, e As EventArgs) Handles verNroAsiento.CheckedChanged
        Try
            If verNroAsiento.Checked Then
                txtNroAsiento.Enabled = True
                btnConsultarAsiento.Enabled = True
                btnEliminarDepreciaciones.Enabled = True
                txtNroAsiento.Focus()
                txtNroAsiento.Text = ""
            Else
                txtNroAsiento.Enabled = False
                btnConsultarAsiento.Enabled = False
                btnEliminarDepreciaciones.Enabled = False
                txtNroAsiento.Text = ""
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnConsultarAsiento_Click(sender As Object, e As EventArgs) Handles btnConsultarAsiento.Click
        Try
            oeAsiento = New e_Asiento
            If txtNroAsiento.Text.Trim = "" Then
                Throw New Exception("Ingrese NroAsiento Tomando del Comprobante DIARIO")
            End If
            oeAsiento.IdPeriodo = cboMesListaDAF.Value
            ''Tipo Asiento = DIARIO "1CH000020"
            oeAsiento.IdTipoAsiento = "1CH000020"
            oeAsiento.NroAsiento = txtNroAsiento.Text
            oeAsiento = olAsiento.Obtener(oeAsiento)
            If oeAsiento.Id.Trim <> "" Then
                oeDepreciacionAF = New e_DepreciacionActivoFijo
                oeDepreciacionAF.TipoOperacion = "0"
                oeDepreciacionAF.IdAsiento = oeAsiento.Id.Trim
                griAsiento.DataSource = olActivoFijo.ListarDepreciacionAF(oeDepreciacionAF)
            Else
                Throw New Exception("NroAsiento no tiene ninguna Depreciacion de AF, Verifique.")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnEliminarDepreciaciones_Click(sender As Object, e As EventArgs) Handles btnEliminarDepreciaciones.Click
        Try
            If txtNroAsiento.Text.Trim <> "" Then
                If griAsiento.Rows.Count > 0 Then
                    oeAsiento = New e_Asiento
                    With oeAsiento
                        .IdPeriodo = cboMesListaDAF.Value
                        ''Tipo Asiento = DIARIO "1CH000020"
                        .IdTipoAsiento = "1CH000020"
                        .NroAsiento = txtNroAsiento.Text
                    End With
                    oeAsiento = olAsiento.Obtener(oeAsiento)
                    l_FuncionesGenerales.ValidarPeriodo(oeAsiento.IdPeriodo, gAreasSGI.Contabilidad, Date.Parse("01/01/1901"), "")
                    If oeAsiento.Id.Trim <> "" Then
                        If MessageBox.Show("Depreciaciones se eliminara con el Comprobante NroAsiento: " & _
                                 txtNroAsiento.Text.Trim & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeAsiento.TipoOperacion = "E"
                            With oeActivoFijo
                                .TipoOperacion = "E"
                                .UsuarioCreacion = gUsuarioSGI.Id
                                .AsientoAF = oeAsiento
                                .ListDepreciacionAF = griAsiento.DataSource
                            End With
                            olActivoFijo.Eliminar(oeActivoFijo)
                            griAsiento.DataSource = New List(Of e_DepreciacionActivoFijo)
                        End If
                    Else
                        Throw New Exception("La informacion se encuentra eliminada.")
                    End If
                Else
                    btnConsultarAsiento.Focus()
                    Throw New Exception("No hay registros de Depreciaciones para eliminar.")
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tabAdicionalAF_SelectedTabChanged(sender As Object, e As UltraWinTabControl.SelectedTabChangedEventArgs) Handles tabAdicionalAF.SelectedTabChanged
        Try
            If tabAdicionalAF.SelectedTab IsNot Nothing Then
                mt_ControlBotoneria()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboGrupoAF_ValueChanged(sender As Object, e As EventArgs) Handles cboGrupoAF.ValueChanged
        Try
            'SubTipo
            If cboGrupoAF.SelectedIndex >= 0 Then
                oeCombo = New e_Combo
                oeCombo.Id = cboGrupoAF.Value
                oeCombo.Nombre = "TablaContableDetalle"
                cboSubGrupoAF.DataSource = olCombo.Listar(oeCombo)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboCentro_ValueChanged(sender As Object, e As EventArgs) Handles cboCentro.ValueChanged
        Try
            If cboCentro.SelectedIndex >= 0 Then
                oeCentroCosto = New e_CentroCosto
                oeCentroCosto.IdCentro = cboCentro.Value
                lstCentroCosto.Clear()
                lstCentroCosto.AddRange(olCentroCosto.Listar(oeCentroCosto))
                cbgCentroCostoAF.DataBind()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cbgCentroCostoAF_ValueChanged(sender As Object, e As EventArgs) Handles cbgCentroCostoAF.ValueChanged
        Try
            If cbgCentroCostoAF.SelectedRow IsNot Nothing Then
                oeCombo = New e_Combo
                oeCombo.Nombre = "Ubicaciones CC"
                oeCombo.Id = cbgCentroCostoAF.Value
                cboCCUbicaciones.DataSource = olCombo.Listar(oeCombo)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub verMaterial_CheckedChanged(sender As Object, e As EventArgs) Handles chkMaterial.CheckedChanged
        Try
            cbgMaterial.Enabled = chkMaterial.Checked
            If chkMaterial.Checked Then
                cbgMaterial.Focus()
            Else
                cbgMaterial.Value = ""
                cbgMaterial.Text = ""
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    'Private Sub cbgMaterial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbgMaterial.KeyPress
    '    Try
    '        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
    '            cbgMaterial.PerformAction(UltraWinGrid.UltraComboAction.Dropdown)
    '        End If
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    End Try
    'End Sub

    Private Sub rbtInformacionCompra_CheckedChanged(sender As Object, e As EventArgs) Handles rbtInformacionCompra.CheckedChanged
        Try
            If rbtInformacionCompra.Checked Then
                uneValorCompra.Enabled = True
                decVidaUtilIC.Enabled = True
                ugbSinDocumento.Enabled = False
            Else
                ugbSinDocumento.Enabled = True
                uneValorCompra.Enabled = False
                decVidaUtilIC.Enabled = False
            End If
            'ugbConDoc.Enabled = rbtInformacionCompra.Checked
            'ugbSinDocumento.Enabled = Not rbtInformacionCompra.Checked
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub verIndFecActivacion_CheckedChanged(sender As Object, e As EventArgs) Handles verIndFecActivacion.CheckedChanged
        Try
            fecActivacion.Enabled = verIndFecActivacion.Checked
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub uneValorResidual_ValidationError(sender As Object, e As UltraWinEditors.ValidationErrorEventArgs) Handles uneValorResidual.ValidationError, uneValorCompra.ValidationError
        Try
            CType(sender, UltraWinEditors.UltraNumericEditor).Value = 0
            e.RetainFocus = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub decValorLibroSC_ValidationError(sender As Object, e As UltraWinEditors.ValidationErrorEventArgs) Handles decValorLibroSC.ValidationError, decRevalorizacionAcumuladaSC.ValidationError, decDepreciacionAcumuladaSC.ValidationError, decVidaUtilRemanenteSC.ValidationError, decMontoAgregarVR.ValidationError, decMontoAgregarActR.ValidationError, decVidaUtilAgregarR.ValidationError, decVidaUtilIC.ValidationError
        Try
            CType(sender, ISL.Controles.NumeroDecimal).Value = 0
            e.RetainFocus = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub verIndBaja_CheckedChanged(sender As Object, e As EventArgs) Handles verIndBaja.CheckedChanged
        Try
            fecBaja.Enabled = verIndBaja.Checked
            If fecBaja.Enabled Then
                fecBaja.Value = FechaActual.Date
            Else
                fecBaja.Value = #1/1/1901#
            End If
            cboConceptoBajaAF.Enabled = verIndBaja.Checked
            txtDescripcionBaja.Enabled = verIndBaja.Checked
            ugbDocumentoBaja.Enabled = verIndBaja.Checked
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub opcTipoDocumento_ValueChanged(sender As Object, e As EventArgs) Handles opcTipoDocumento.ValueChanged
        Try
            btnBuscarDoc.Enabled = True
            If opcTipoDocumento.CheckedIndex = 2 Then
                btnBuscarDoc.Enabled = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnExtornarAsiento_Click(sender As Object, e As EventArgs) Handles btnExtornarAsiento.Click
        Try
            Cursor = Cursors.WaitCursor
            If olTrajadorabSeg.Permisos(gUsuarioSGI.IdTrabajador, strPermisoExtornarDepreciacion) Then
                If gf_ValidarFilaSeleccionada(griAsiento) AndAlso lf_ValidarExtornarAsiento() Then
                    oeAsiento = New e_Asiento
                    oeAsiento.Id = griAsiento.ActiveRow.Cells("Id").Value
                    oeAsiento = olAsiento.Obtener(oeAsiento)
                    If Not String.IsNullOrWhiteSpace(oeAsiento.Id) Then
                        Dim oeAsientoExtornar As New e_Asiento
                        oeAsientoExtornar.Id = oeAsiento.Id
                        oeAsientoExtornar.IdPeriodo = oeAsiento.IdPeriodo
                        oeAsientoExtornar.IdTipoAsiento = IdTipoAsientoDiario
                        oeAsientoExtornar.Fecha = oeAsiento.Fecha
                        oeAsientoExtornar.IdUsuarioCrea = gUsuarioSGI.Id
                        If olActivoFijo.ExtornarAsientoDepreciacion(oeAsientoExtornar) Then
                            MessageBox.Show("Operación realizada con éxito", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Consultar(True)
                        End If
                        'oeAsientoExtorno.TipoOperacion = "I"
                        'oeAsientoExtorno.IdPeriodo = oeAsiento.IdPeriodo
                        'oeAsientoExtorno.IdTipoAsiento = IdTipoAsientoDiario
                        'oeAsientoExtorno.Fecha = ObtenerFechaServidor()
                        'oeAsientoExtorno.Glosa = "ASIENTO DE EXTORNO: " & oeAsiento.Glosa
                        'oeAsientoExtorno.GlosaImprime = oeAsientoExtorno.Glosa
                        'oeAsientoExtorno.IdMoneda = oeAsiento.IdMoneda
                        'oeAsientoExtorno.TipoCambio = oeAsiento.TipoCambio
                        'oeAsientoExtorno.TotalDebe = oeAsiento.TotalDebe
                        'oeAsientoExtorno.TotalHaber = oeAsiento.TotalHaber
                        'oeAsientoExtorno.IdUsuarioCrea = gUsuarioSGI.Id
                        'oeAsientoExtorno.IdAsientoExtorno = oeAsiento.Id
                        'oeAsientoExtorno.IndOrigen = 40
                        'lstAsientoMov = New List(Of e_AsientoMovimiento)
                        'For Each Mov As e_AsientoMovimiento In oeAsiento.AsientoMovimiento
                        '    oeAsientoMov = New e_AsientoMovimiento
                        '    oeAsientoMov.TipoOperacion = "I"
                        '    oeAsientoMov.Glosa = Mov.Glosa
                        '    oeAsientoMov.IdUsuarioCrea = gUsuarioSGI.Id
                        '    oeAsientoMov.NroLinea = Mov.NroLinea
                        '    If Mov.DebeMN > 0 Then
                        '        oeAsientoMov.IdCuentaContable = Mov.IdCuentaContable
                        '        oeAsientoMov.HaberME = Mov.DebeME
                        '        oeAsientoMov.HaberMN = Mov.DebeMN
                        '    Else
                        '        oeAsientoMov.IdCuentaContable = Mov.IdCuentaContable
                        '        oeAsientoMov.DebeME = Mov.HaberME
                        '        oeAsientoMov.DebeMN = Mov.HaberMN
                        '    End If
                        '    lstAsientoMov.Add(oeAsientoMov)
                        'Next
                        'oeAsientoExtorno.AsientoMovimiento = New List(Of e_AsientoMovimiento)
                        'oeAsientoExtorno.AsientoMovimiento.AddRange(lstAsientoMov)
                        'If olActivoFijo.ExtornarAsientoDepreciacion(oeAsientoExtorno) Then
                        '    MessageBox.Show("Operación realizada con éxito", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        '    Consultar(True)
                        'End If
                    End If
                End If
            Else
                MessageBox.Show("Usted no tiene permiso para realizar esta operación", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmsListado_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles cmsListado.ItemClicked
        Try
            Select Case e.ClickedItem.Name
                Case itemReclasificar.Name
                    mt_Reclasificar()
                Case itemBaja.Name
                    mt_DarBajaActivo()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsbBuscarDocBaja_Click(sender As Object, e As EventArgs) Handles tsbBuscarDocBaja.Click
        Try
            Dim FRM As New frm_BuscarDocumento
            FRM.strIndServicioMaterial = "M"
            FRM.StartPosition = FormStartPosition.CenterScreen
            FRM.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
            IndCuentaCP = 2 'Documento de Venta
            If FRM.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                With FRM.oeDocumento
                    txtTipoDocBaja.Tag = .Id
                    txtTipoDocBaja.Text = .Glosa
                    txtSerieBaja.Text = .Serie
                    txtNumeroBaja.Text = .Numero
                End With
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub fecIngreso_ValueChanged(sender As Object, e As EventArgs) Handles fecIngreso.ValueChanged
        Try
            fecActivacion.Value = fecIngreso.Value
            AñoIC.numAño.Value = fecIngreso.Value.Year
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_ActivoFijo_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case ficActivoFijo.SelectedTab.Index
                Case 2 'Mantenimiento
                    Select Case e.KeyCode
                        Case Keys.Enter
                            SendKeys.Send("{TAB}")
                    End Select
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub chkDepreciable_CheckedChanged(sender As Object, e As EventArgs) Handles chkDepreciable.CheckedChanged
        Try
            cboDepreciacion.Enabled = chkDepreciable.Checked
            cboMetodo.Enabled = chkDepreciable.Checked
            txtNroAutorizacion.ReadOnly = Not chkDepreciable.Checked
            If Not chkDepreciable.Checked Then
                cboDepreciacion.SelectedIndex = -1
                numPorcentaje.Value = 0
                cboMetodo.SelectedIndex = -1
                txtNroAutorizacion.Text = String.Empty
            Else
                LlenarCombo(cboDepreciacion, "Nombre", leDetConPond, -1)
                ' Cargar Porcentaje
                oeTipoActivoCtaCtble = New e_TipoActivoFijo_CtaCtble
                oeTipoActivoCtaCtble.TipoOperacion = "EDT"
                oeTipoActivoCtaCtble.IdTipoActivoFijo = cboSubGrupoAF.Value
                oeTipoActivoCtaCtble.Ejercicio = AñoIC.Año
                lstTipoActivoCtaCtble = New List(Of e_TipoActivoFijo_CtaCtble)
                lstTipoActivoCtaCtble.AddRange(olTipoActivoFijoCtaCtble.Listar(oeTipoActivoCtaCtble))
                cboDepreciacion.Value = lstTipoActivoCtaCtble(0).IdDetConPond
                numPorcentaje.Value = lstTipoActivoCtaCtble(0).Porcentaje
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboDepreciacion_ValueChanged(sender As Object, e As EventArgs) Handles cboDepreciacion.ValueChanged
        Try
            If cboDepreciacion.SelectedIndex > -1 Then
                oeDetConPond = cboDepreciacion.SelectedItem.ListObject
                numPorcentaje.Value = oeDetConPond.Porcentaje
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub chkDepende_CheckedChanged(sender As Object, e As EventArgs) Handles chkDepende.CheckedChanged
        Try
            cboActivoFijo.ReadOnly = Not chkDepende.Checked
            txtActivoFijo.ReadOnly = Not chkDepende.Checked
            If chkDepende.Checked Then
                LlenarCombo(cboActivoFijo, "DescripcionResumida", leActivoFijoBusq, -1)
            Else
                LlenarCombo(cboActivoFijo, "DescripcionResumida", New List(Of e_ActivoFijo), -1)
                txtActivoFijo.Text = String.Empty
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboActivoFijo_ValueChanged(sender As Object, e As EventArgs) Handles cboActivoFijo.ValueChanged
        Try
            If cboActivoFijo.SelectedIndex > -1 Then
                Dim _oeAux As New e_ActivoFijo
                _oeAux = cboActivoFijo.SelectedItem.ListObject
                txtActivoFijo.Text = _oeAux.Codigo & " - " & _oeAux.DescripcionDetallada
            Else
                txtActivoFijo.Text = String.Empty
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Informacion Contable"

    Private Sub tspInformacionContable_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tspInformacionContable.ItemClicked
        Try
            Select Case e.ClickedItem.Name
                Case tsbAgregar.Name
                    mt_AgregarInformacionContable()
                Case tsbQuitar.Name
                    mt_QuitarInformacionContable()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function lf_ValidarAgregaCC() As Boolean
        Try
            AñoIC_Validated(Nothing, Nothing)
            If cboGrupoAF.SelectedIndex < 0 Then
                MessageBox.Show("Seleccion Tipo de Activo", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ficDatosAF.Tabs(0).Selected = True
                cboGrupoAF.Focus()
                Return False
            End If
            If AñoIC.Año <= FechaActual.AddYears(-10).Year AndAlso AñoIC.Año >= FechaActual.AddYears(2).Year Then
                MessageBox.Show("Ingrese Año válido (Rango desde: " & FechaActual.AddYears(-10).Year.ToString() & " hasta: " & FechaActual.AddYears(2).Year & " )", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                AñoIC.Focus()
                Return False
            End If
            If lstAFCuentaContable.Where(Function(x) x.IdTipoActivo = cboGrupoAF.Value And x.Ejercicio = AñoIC.Año And x.Actual = 1).Count > 0 Then
                MessageBox.Show("La Configuracion del Tipo: " & cboGrupoAF.Text & Environment.NewLine & _
                                "del Ejercicio: " & AñoIC.Año.ToString() & " esta marcada como la Actual", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub mt_AgregarInformacionContable()
        Try
            If lf_ValidarAgregaCC() Then
                oeAFCuentaContable = New e_ActivoFijo_CuentaContable
                With oeAFCuentaContable
                    .Ejercicio = AñoIC.Año
                    .IdCtaCtbleCompra = txtCtaCompraDD.Tag
                    .CtaCtbleCompra = txtCtaCompraDD.Text.Trim()
                    .CtaCtbleCompraH = txtCtaCompraHH.Text.Trim()
                    .CtaCtbleRevalorizacion = txtCtaRevalorizacionDD.Text.Trim()
                    .CtaCtbleRevalorizacionH = txtCtaRevalorizacionHH.Text.Trim()
                    .IdCtaCtbeDepreciacion = txtCtaDepreciacionDD.Tag
                    .CtaCtbeDepreciacion = txtCtaDepreciacionDD.Text.Trim()
                    .CtaCtbeDepreciacionH = txtCtaDepreciacionHH.Text.Trim()
                    .IdCtaCtbleReadeacuacion = txtCtaReadecuacionDD.Tag
                    .CtaCtbleReadeacuacion = txtCtaReadecuacionDD.Text.Trim()
                    .CtaCtbleReadeacuacionH = txtCtaReadecuacionHH.Text.Trim()
                    .CtaCtbleDesactivacionD = txtCtaDesactivacionDD.Text.Trim()
                    .GastoFuncion = txtGastoFuncion.Text.Trim()
                    .IdTipoActivo = cboSubGrupoAF.Value
                    .TipoActivo = cboSubGrupoAF.Text
                    .ValorResidual = uneValorResidual.Value
                    .DepreciacionAcumulada = decDepreciacionAcumuladaSC.Value
                    .IndFecActivacion = IIf(verIndFecActivacion.Checked, 1, 0)
                    .FechaActivacion = fecActivacion.Value
                    .IdMetodoDepreciacion = cboMetodo.Value
                    .NroAutorizacion = txtNroAutorizacion.Text.Trim
                    .IdReadecuacion = String.Empty
                    .Actual = 1
                End With
                For Each _CuentaContable In lstAFCuentaContable
                    _CuentaContable.Actual = 0
                Next
                lstAFCuentaContable.Add(oeAFCuentaContable)
                griAFCuentaContable.DataBind()
                AñoIC.Focus()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_QuitarInformacionContable()
        Try
            If gf_ValidarFilaSeleccionada(griAFCuentaContable) Then
                If Not String.IsNullOrEmpty(griAFCuentaContable.ActiveRow.Cells("Id").Value.ToString().Trim()) Then
                    lstAFCuentaContable(lstAFCuentaContable.IndexOf(griAFCuentaContable.ActiveRow.ListObject)).TipoOperacion = "E"
                    griAFCuentaContable.ActiveRow.Hidden = True
                Else
                    lstAFCuentaContable.Remove(griAFCuentaContable.ActiveRow.ListObject)
                End If
                griAFCuentaContable.DataBind()
                'Marcar el último registro como actual
                If lstAFCuentaContable.Where(Function(x) x.TipoOperacion <> "E").Count > 0 AndAlso _
                     lstAFCuentaContable.Where(Function(x) x.TipoOperacion <> "E" And x.Actual).Count = 0 Then
                    griAFCuentaContable.Rows.Where(Function(x) x.Hidden = False).OrderByDescending(Function(x) x.Index)(0).Cells("Actual").Value = 1
                    griAFCuentaContable.UpdateData()
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griAFCuentaContable_CellChange(sender As Object, e As CellEventArgs) Handles griAFCuentaContable.CellChange
        Try
            griAFCuentaContable.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Readecuacion"

    Private Sub tspReadecuaciones_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tspMantReadecuaciones.ItemClicked
        Try
            Select Case e.ClickedItem.Name
                Case tsbAceptarReadecuacion.Name
                    mt_AceptarReadecuacion()
                Case tsbCancelarReadecuacion.Name
                    MostrarTabs(0, utcReadecuaciones, 2)
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function lf_ValidarAgregarReadecuacion() As Boolean
        Try
            If AñoR.Año > FechaActual.Year Then
                MessageBox.Show("Ingrese Año válido, no puede ser mayor a " & FechaActual.Year.ToString(), "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                AñoR.Focus()
                Return False
            End If
            If fecReadecuacion.Value.Date > FechaActual.Date Then
                MessageBox.Show("La fecha de Adición/Retiro no puede ser mayor a la fecha actual", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
            If decMontoAgregarActR.Value = 0 Then
                MessageBox.Show("Ingrese un monto a agregar al Activo válido", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                decMontoAgregarActR.Focus()
                Return False
            End If
            'Validar que no ingresen adiciones o retiros en periodos cerrados
            oePeriodo = New e_Periodo
            oePeriodo.Id = cboMesR.Value
            oePeriodo = olPeriodo.Obtener(oePeriodo)
            If Not String.IsNullOrWhiteSpace(oePeriodo.Id) AndAlso oePeriodo.CierreContabilidad = 1 Then
                MessageBox.Show("No se puede agregar, porque el periodo " & oePeriodo.Codigo & " se encuentra cerrado", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            'Validar que no ingresen readecuaciones en periodos donde ya se ejecutó la depreciación
            If Not String.IsNullOrWhiteSpace(oeActivoFijo.Id) Then
                oeDepreciacionAF = New e_DepreciacionActivoFijo
                oeDepreciacionAF.IdActivoFijo = oeActivoFijo.Id
                oeDepreciacionAF.IdPeriodo = cboMesR.Value
                lstDepreciacionAF = New List(Of e_DepreciacionActivoFijo)
                lstDepreciacionAF.AddRange(olActivoFijo.ListarDepreciacionAF(oeDepreciacionAF))
                If lstDepreciacionAF.Count > 0 Then
                    Dim MejoraRetiro As String = If(decMontoAgregarActR.Value > 0, "la mejora", "el retiro")
                    MessageBox.Show("No se puede agregar " & MejoraRetiro & " ,porque ya se ejecutó la depreciación" & Environment.NewLine & _
                                    "En el periodo" & AñoR.Año.ToString() & "-" & cboMesR.Text)
                End If
            End If
            If lstReadecuacionAFDoc.Where(Function(x) x.TipoOperacion <> "E").Count = 0 Then
                MessageBox.Show("Debe ingresar almenos un documento relacionado a la Adición o Retiro", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cboTipoDocReadecuacion.Focus()
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub mt_AceptarReadecuacion()
        Try
            If lf_ValidarAgregarReadecuacion() Then
                With oeReadecuacionAF
                    oePeriodo = New e_Periodo
                    oePeriodo.Id = cboMesR.Value
                    oePeriodo = olPeriodo.Obtener(oePeriodo)
                    If Not String.IsNullOrWhiteSpace(oePeriodo.Id) Then
                        .IdPeriodo = oePeriodo.Id
                        .Periodo = oePeriodo.Codigo
                        .FechaReadecuacion = fecReadecuacion.Value
                        .MontoAgregar = decMontoAgregarActR.Value
                        .MontoInvertido = .MontoAgregar
                        .ValorResidualAgregar = decMontoAgregarVR.Value
                        .VidaUtilAgregar = decVidaUtilAgregarR.Value
                        .ListReadecuacionAFDoc.Clear()
                        .ListReadecuacionAFDoc.AddRange(lstReadecuacionAFDoc)
                    Else
                        Throw New Exception("No se generado el periodo " & AñoR.Año & " - " & cboMesR.Text)
                    End If
                End With
                If oeReadecuacionAF.TipoOperacion = "I" Then
                    lstReadecuacionAF.Add(oeReadecuacionAF)
                End If
                griReadecuacion.DataBind()
                MostrarTabs(0, utcReadecuaciones, 2)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_QuitarReadecuaciones()
        Try
            If gf_ValidarFilaSeleccionada(griReadecuacion) Then
                If Not String.IsNullOrEmpty(griReadecuacion.ActiveRow.Cells("Id").Value.ToString().Trim()) Then
                    lstReadecuacionAF(lstReadecuacionAF.IndexOf(griReadecuacion.ActiveRow.ListObject)).TipoOperacion = "E"
                    griReadecuacion.ActiveRow.Hidden = True
                Else
                    lstReadecuacionAF.Remove(griReadecuacion.ActiveRow.ListObject)
                End If
                griReadecuacion.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griReadecuacion_BeforeCellUpdate(sender As Object, e As BeforeCellUpdateEventArgs) Handles griReadecuacion.BeforeCellUpdate
        Try
            If e.Cell.Row.Index <> -1 Then
                Select Case e.Cell.Column.Key
                    Case "MontoInvertido", "MontoAgregar", "VidaUtilAgregar", "ValorResidualAgregar"
                        If IsDBNull(e.NewValue) Then
                            e.Cancel = True
                        End If
                        If IsDBNull(e.Cell.Value) Then e.Cell.Value = 0.0
                End Select
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griReadecuacion_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griReadecuacion.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            e.Cancel = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsbBuscarDocReadecuacion_Click(sender As Object, e As EventArgs) Handles tsbBuscarDocReadecuacion.Click
        Try
            Dim FRM As New frm_BuscarDocumento
            FRM.StartPosition = FormStartPosition.CenterScreen
            FRM.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
            If cboTipoDocReadecuacion.SelectedIndex = 0 Then
                'Documento de Compra
                IndCuentaCP = 1
                If FRM.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                    With FRM.oeDocumento
                        txtSerieReadecuacion.Tag = .Id
                        txtSerieReadecuacion.Text = .Serie
                        txtNumeroReadecuacion.Text = .Numero
                        txtNumeroReadecuacion.Tag = .Glosa
                        'If .IdMoneda = IdMonedaSoles Then
                        '    decMontoAgregarActR.Value += .SubTotal
                        'Else
                        '    decMontoAgregarActR.Value += .SubTotal * .TipoCambio
                        'End If
                    End With
                End If
            Else
                'Orden de Trabajo
                IndCuentaCP = 3
                If FRM.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                    With FRM.oeOrdenTrabajo
                        txtSerieReadecuacion.Tag = .Id
                        txtSerieReadecuacion.Text = String.Empty
                        txtNumeroReadecuacion.Text = .NroOT
                        txtNumeroReadecuacion.Tag = "ORDEN DE TRABAJO"
                    End With
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tspListaReadecuaciones_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tspListaReadecuaciones.ItemClicked
        Try
            Select Case e.ClickedItem.Name
                Case tsbAgregarReadecuacion.Name
                    mt_AgregarReadecuacion()
                Case tsbEditarReadecuacion.Name
                    mt_EditarReadecuacion()
                Case tsbQuitarReadecuacion.Name
                    mt_QuitarReadecuaciones()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mt_AgregarReadecuacion()
        Try
            InicializarControlesReadec()
            oeReadecuacionAF = New e_ReadecuacionActivoFijo
            oeReadecuacionAF.TipoOperacion = "I"
            MostrarTabs(1, utcReadecuaciones, 1)
            AñoR.Focus()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_EditarReadecuacion()
        Try
            If gf_ValidarFilaSeleccionada(griReadecuacion) Then
                InicializarControlesReadec()
                oeReadecuacionAF = New e_ReadecuacionActivoFijo
                oeReadecuacionAF = griReadecuacion.ActiveRow.ListObject
                'Mostrar Datos
                oePeriodo = New e_Periodo
                oePeriodo.Id = oeReadecuacionAF.IdPeriodo
                oePeriodo = olPeriodo.Obtener(oePeriodo)
                If Not String.IsNullOrWhiteSpace(oePeriodo.Id) Then
                    AñoR.Año = oePeriodo.Ejercicio
                    cboMesR.Value = oePeriodo.Id
                End If
                fecReadecuacion.Value = oeReadecuacionAF.FechaReadecuacion
                decMontoAgregarActR.Value = oeReadecuacionAF.MontoAgregar
                decMontoAgregarVR.Value = oeReadecuacionAF.ValorResidualAgregar
                decVidaUtilAgregarR.Value = oeReadecuacionAF.VidaUtilAgregar
                For Each ReadecuacionDoc In oeReadecuacionAF.ListReadecuacionAFDoc
                    If lstTipoDocumento.Where(Function(x) x.Id = ReadecuacionDoc.IdTipoDocumento).Count > 0 Then
                        ReadecuacionDoc.TipoDocumento = lstTipoDocumento.Where(Function(x) x.Id = ReadecuacionDoc.IdTipoDocumento)(0).Nombre
                    End If
                Next
                lstReadecuacionAFDoc.AddRange(oeReadecuacionAF.ListReadecuacionAFDoc)
                griReadecuacionAFDocumento.DataBind()

                oeReadecuacionAF.TipoOperacion = "A"
                MostrarTabs(1, utcReadecuaciones, 1)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub InicializarControlesReadec()
        Try
            AñoR.Año = FechaActual.Year
            cboMesR.SelectedIndex = -1
            fecReadecuacion.Value = FechaActual
            decMontoAgregarVR.Value = 0.0
            decMontoAgregarActR.Value = 0.0
            decVidaUtilAgregarR.Value = 0
            txtObservacionR.Text = String.Empty
            cboTipoDocReadecuacion.SelectedIndex = 0
            txtSerieReadecuacion.Text = String.Empty
            txtSerieReadecuacion.Tag = String.Empty
            txtNumeroReadecuacion.Text = String.Empty
            lstReadecuacionAFDoc.Clear() : griReadecuacionAFDocumento.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub tspDocAsocReadecuacion_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tspDocAsocReadecuacion.ItemClicked
        Try
            Select Case e.ClickedItem.Name
                Case tsbAgregarReadecuacionDoc.Name
                    mt_AgregarReadecuacionDoc()
                Case tsbQuitarReadecuacionDoc.Name
                    mt_QuitarReadecuacionDoc()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function lf_ValidarAgregaDocReadecuacion() As Boolean
        Try
            If String.IsNullOrWhiteSpace(txtSerieReadecuacion.Tag.ToString()) Then
                MessageBox.Show("No ha seleccionado ningun documento", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cboTipoDocReadecuacion.Focus()
                Return False
            End If
            If lstReadecuacionAFDoc.Where(Function(x) x.TipoDocumento <> "E" And x.IdDocumento = txtSerieReadecuacion.Tag.ToString()).Count > 0 Then
                MessageBox.Show("El Documento N°:" & txtNumeroReadecuacion.Text & " ya fue agregado a la lista", "Mensaje del Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub mt_AgregarReadecuacionDoc()
        Try
            If lf_ValidarAgregaDocReadecuacion() Then
                oeReadecuacionAFDoc = New e_ReadecuacionAF_Documento
                With oeReadecuacionAFDoc
                    .IdDocumento = txtSerieReadecuacion.Tag
                    .TipoDocumento = txtNumeroReadecuacion.Tag
                    .IndTipoDoc = cboTipoDocReadecuacion.SelectedIndex
                    .Glosa = cboTipoDocReadecuacion.Text
                    .Serie = txtSerieReadecuacion.Text
                    .Numero = txtNumeroReadecuacion.Text
                End With
                lstReadecuacionAFDoc.Add(oeReadecuacionAFDoc)
                griReadecuacionAFDocumento.DataBind()
                'Inicializar
                cboTipoDocReadecuacion.SelectedIndex = 0
                txtSerieReadecuacion.Text = String.Empty
                txtSerieReadecuacion.Tag = String.Empty
                txtNumeroReadecuacion.Text = String.Empty
                txtNumeroReadecuacion.Tag = String.Empty
                cboTipoDocReadecuacion.Focus()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_QuitarReadecuacionDoc()
        Try
            If gf_ValidarFilaSeleccionada(griReadecuacionAFDocumento) Then
                If Not String.IsNullOrEmpty(griReadecuacionAFDocumento.ActiveRow.Cells("Id").Value.ToString().Trim()) Then
                    lstReadecuacionAFDoc(lstReadecuacionAFDoc.IndexOf(griReadecuacionAFDocumento.ActiveRow.ListObject)).TipoOperacion = "E"
                    griReadecuacionAFDocumento.ActiveRow.Hidden = True
                Else
                    lstReadecuacionAFDoc.Remove(griReadecuacionAFDocumento.ActiveRow.ListObject)
                End If
                griReadecuacionAFDocumento.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griReadecuacionAFDocumento_CellChange(sender As Object, e As CellEventArgs) Handles griReadecuacionAFDocumento.CellChange
        Try
            griReadecuacionAFDocumento.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griReadecuacion_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles griReadecuacion.DoubleClickRow
        Try
            mt_EditarReadecuacion()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Ejecutar Depreciacion"

    Private Sub mt_ListarDepreciacionActivos()
        Try
            If lf_ValidarDepreciacionPeriodo(cboMesDepActivos.Value) Then
                oeActivoFijo = New e_ActivoFijo
                oeActivoFijo.TipoOperacion = "DEP"
                oeActivoFijo.IdPeriodo = cboMesDepActivos.Value
                griDepreciacionActivos.DataSource = olActivoFijo.ListarDS(oeActivoFijo)
                btnValidarDepreciacion_Click(Nothing, Nothing)
            Else
                griDepreciacionActivos.DataSource = udsDepActivos
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AñoDepActivos_Validated(sender As Object, e As EventArgs) Handles AñoDepActivos.Validated
        Try
            ComboPerido(cboMesDepActivos, AñoDepActivos)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function lf_ValidarDepreciacionPeriodo(IdPeriodo As String) As Boolean
        Try
            oePeriodo = New e_Periodo
            oePeriodo.Id = IdPeriodo
            oePeriodo = olPeriodo.Obtener(oePeriodo)
            If Not String.IsNullOrWhiteSpace(oePeriodo.Id) Then
                'Buscar si en el periodo seleccionado ya se ejecutó la depreciación
                lstDepreciacionAF = New List(Of e_DepreciacionActivoFijo)
                oeDepreciacionAF = New e_DepreciacionActivoFijo
                oeDepreciacionAF.IdPeriodo = oePeriodo.Id
                lstDepreciacionAF.AddRange(olActivoFijo.ListarDepreciacionAF(oeDepreciacionAF))
                If lstDepreciacionAF.Count > 0 Then
                    'Busco registro depreciacion del ultimo periodo generado
                    oeDepreciacionAF = New e_DepreciacionActivoFijo
                    oeDepreciacionAF.TipoOperacion = "MAX"
                    Dim lstDep As New List(Of e_DepreciacionActivoFijo)
                    lstDep.AddRange(olActivoFijo.ListarDepreciacionAF(oeDepreciacionAF))
                    If lstDep.Count > 0 Then
                        MessageBox.Show("La Depreciación de Activos del Periodo: " & AñoDepActivos.Año & "-" & cboMesDepActivos.Text & " ya fue generada" & Environment.NewLine & _
                                        "El último periodo generado es: " & lstDep(0).Periodo, "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return False
                    End If
                End If
            Else
                MessageBox.Show("El Periodo: " & AñoDepActivos.Año & "-" & cboMesDepActivos.Value & ",aún no ha sido generado", "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub btnValidarDepreciacion_Click(sender As Object, e As EventArgs) Handles btnValidarDepreciacion.Click
        Try
            For i = griDepreciacionActivos.Rows.Count - 1 To 0 Step -1
                If griDepreciacionActivos.Rows(i).Cells("Valor Activo").Value - griDepreciacionActivos.Rows(i).Cells("Total Deprec. Acumulada").Value > griDepreciacionActivos.Rows(i).Cells("Valor Residual").Value Then
                    If (griDepreciacionActivos.Rows(i).Cells("Valor Activo").Value - griDepreciacionActivos.Rows(i).Cells("Total Deprec. Acumulada").Value - griDepreciacionActivos.Rows(i).Cells("Total Depreciacion").Value) < griDepreciacionActivos.Rows(i).Cells("Valor Residual").Value Then
                        griDepreciacionActivos.Rows(i).Cells("Total Depreciacion").Value = griDepreciacionActivos.Rows(i).Cells("Valor Activo").Value - griDepreciacionActivos.Rows(i).Cells("Total Deprec. Acumulada").Value - griDepreciacionActivos.Rows(i).Cells("Valor Residual").Value
                        griDepreciacionActivos.Rows(i).Cells("Total Depreciacion").Appearance.BackColor = ColorFilaEdit.Color
                    End If
                Else
                    bolEliminarFilas = True
                    griDepreciacionActivos.Rows(i).Delete()
                    bolEliminarFilas = False
                End If
                If griDepreciacionActivos.Rows(i).Cells("Total Depreciacion").Value = 0 Then
                    bolEliminarFilas = True
                    griDepreciacionActivos.Rows(i).Delete()
                    bolEliminarFilas = False
                End If
            Next
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDepreciacionActivos_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griDepreciacionActivos.BeforeRowsDeleted
        Try
            If bolEliminarFilas Then
                e.DisplayPromptMsg = False
            Else
                e.Cancel = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDepreciacionActivos_CellChange(sender As Object, e As CellEventArgs) Handles griDepreciacionActivos.CellChange
        Try
            griDepreciacionActivos.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

End Class

