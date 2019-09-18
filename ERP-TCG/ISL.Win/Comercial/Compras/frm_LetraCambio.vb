'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios Centro y Giro
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_LetraCambio
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicialización de formulario"

    Private _ingresando_datos As Boolean = False
    Private Shared instancia As frm_LetraCambio = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_LetraCambio()
        End If
        instancia.Activate()
        Return instancia
    End Function

    Public Sub New()
        InitializeComponent()
    End Sub

#End Region

#Region "Declaración de variables"
    Private ln_TasaRetencion As Double = 0
    Private olRetencion As l_DocumentoRetencion
    Private oeMovimientoDocumento As New e_MovimientoDocumento, olMovimientoDocumento As New l_MovimientoDocumento
    Private lstMovDocumento As New List(Of e_MovimientoDocumento), lstMovDocumentoLetra As New List(Of e_MovimientoDocumento)
    'Private oeLetraCambio As New e_ObligacionFinanciera, olLetraCambio As New l_ObligacionFinanciera, lsLetraCambio As New List(Of e_ObligacionFinanciera)
    Private oeProveedor As New e_Proveedor, olProveedor As New l_Proveedor, llProveedores As New List(Of e_Proveedor)
    Private oeTipoDocumento As New e_TipoDocumento, olTipoDocumento As New l_TipoDocumento
    Private oeProDoc As New e_ProcesoTipoDocumento, olProDoc As New l_ProcesoTipoDocumento
    Private oeProceso As New e_ProcesoNegocio, olProceso As New l_ProcesoNegocio
    Private Proveedor As String
    Private leProvee As New List(Of e_Proveedor)
    Private leCuentasGenerales As New List(Of e_TablaContableDet)
    Private oeLetra As e_ObligacionFinanciera
    Private oeAsientoModel As New e_AsientoModelo, olAsientoModel As New l_AsientoModelo, leAsientoModel As New List(Of e_AsientoModelo)
    Private oeContratoFin As New e_ContratoFinanciero, olContratoFin As New l_ContratoFinanciero
    Private oeObligacionFin As New e_ObligacionFin, leObligacionFin As New List(Of e_ObligacionFin)
    Private oeDocLetra As New e_DetalleDocumento, leDocLetra As New List(Of e_DetalleDocumento)
    Private oePeriodo As New e_Periodo, olPeriodo As New l_Periodo
    Private dsLetraObli As DataSet, relationContratoObligFin As DataRelation
    Private _idProveedor As String, IdCtaCtble As String
    Dim ListaProveedor As New List(Of e_Combo)

#End Region

#Region "Botones"

    Public Overrides Sub Nuevo()
        Try
            oeMovimientoDocumento.TipoOperacion = "I"
            oeMovimientoDocumento.PrefijoID = PrefijoIdSucursal '@0001
            MostrarTabs(1, ficLetra, 1)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            Inicializar()
            Operacion = "Nuevo"
            txtNumero.Value = "1"
            cboProveedorFactura.Value = ""
            Validar_TipoCambio()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            ListaLetra()
            If GridObligacionLetras.Rows.Count = 0 Then
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarLetra() Then
                lstMovDocumento.Clear()
                griFacturaAgregadas.DataSource = lstMovDocumento
                griFacturaAgregadas.DataBind()
                leObligacionFin.Clear()
                GridLetras.DataSource = leObligacionFin
                GridLetras.DataBind()
                Consultar(True)
                MostrarTabs(0, ficLetra)
                cboProveedorFactura.Value = ""
                Operacion = "Inicializa"
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            LimpiarDatos()
            Consultar(True) 'activa desactiva botonera
            MostrarTabs(0, ficLetra, 0)
            Operacion = "Inicializa"
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If ficLetra.Tabs(0).Selected() AndAlso GridObligacionLetras.Rows.Count = 0 Then
                Throw New Exception("No hay ninguna letra para exportar al Excel")
            End If
            If ficLetra.Tabs(0).Selected() Then
                Exportar_Excel(GridObligacionLetras)
            End If
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Metodos"

    Private Sub ListaLetra()
        Try
            Cursor.Current = Cursors.WaitCursor

            oeContratoFin = New e_ContratoFinanciero
            oeContratoFin.TipoOperacion = "E"
            oeContratoFin.Activo = True
            oeContratoFin.FechaEmision = DtpFechaEmisionInicial.Value
            oeContratoFin.FechaVencimiento = DtpFechaEmisionFinal.Value
            oeContratoFin.PrefijoID = PrefijoIdSucursal '@0001
            dsLetraObli = olContratoFin.ListarDS(oeContratoFin)
            ''''''''''''''''''''''''''''''''''''''''''''''
            'Tabla(0) CONTRATOS
            'Tabla(1) OBLIGACIONES
            ''''''''''''''''''''''''''''''''''''''''''''''
            Dim IdContrato As DataColumn = dsLetraObli.Tables(0).Columns("Id")
            Dim IdObligFin As DataColumn = dsLetraObli.Tables(1).Columns("IdContratoFinanciero")
            relationContratoObligFin = New DataRelation("FK_Relacion", IdContrato, IdObligFin, False)
            dsLetraObli.Relations.Add(relationContratoObligFin)
            dsLetraObli.AcceptChanges()
            GridObligacionLetras.DataSource = dsLetraObli
            With GridObligacionLetras.DisplayLayout
                '.Bands(1).ColHeadersVisible = False
                .Bands(0).Columns("FechaEmision").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Bands(1).Columns("Id").Hidden = True
                .Bands(1).Columns("IdContratoFinanciero").Hidden = True
                .Bands(1).Columns("Activo").Hidden = True
                .Bands(1).Columns("Glosa").Hidden = True
                .Bands(0).Columns("TotalMontoMN").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(0).Columns("TotalMontoME").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(0).Columns("TasaInteres").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(1).Columns("MontoMN").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(1).Columns("MontoMN").Format = "#,##0.00"
                .Bands(1).Columns("MontoMN").Header.Caption = "Capital MN"
                .Bands(1).Columns("MontoME").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(1).Columns("MontoME").Format = "#,##0.00"
                .Bands(1).Columns("MontoME").Header.Caption = "Capital ME"
                .Bands(1).Columns("Saldo").Format = "#,##0.00"
                .Bands(1).Columns("Saldo").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(1).Columns("Saldo").Header.VisiblePosition = 11
                .Bands(1).Columns("MontoInteresCompensatorio").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(1).Columns("MontoInteresCompensatorio").Format = "#,##0.00"
                .Bands(1).Columns("MontoInteresCompensatorio").Header.Caption = "Interes Comp."
                .Bands(1).Columns("MontoInteresCompensatorio").Header.VisiblePosition = 8
                .Bands(1).Columns("MontoInteresMoratorio").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(1).Columns("MontoInteresMoratorio").Format = "#,##0.00"
                .Bands(1).Columns("MontoInteresMoratorio").Header.Caption = "Interes Mor."
                .Bands(1).Columns("MontoInteresMoratorio").Header.VisiblePosition = 12
                .Bands(1).Columns("MontoDsctoInteres").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(1).Columns("MontoDsctoInteres").Header.Caption = "Dscto. Interes"
                .Bands(1).Columns("Comision").Format = "#,##0.00"
                .Bands(1).Columns("Comision").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(1).Columns("Comision").Header.VisiblePosition = 9
                .Bands(1).Columns("Gastos").Format = "#,##0.00"
                .Bands(1).Columns("Gastos").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Bands(1).Columns("Gastos").Header.VisiblePosition = 10
                .Bands(1).Columns("FechaVencimiento").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Bands(1).Columns("FechaVencimiento").Header.Caption = "Fec. Vencimiento"
                .Bands(1).Columns("Codigo").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Bands(1).Columns("Codigo").Width = 60
                .Bands(1).Columns("Codigo").Header.Caption = "Nro"
                .Bands(0).Override.CellClickAction = CellClickAction.RowSelect
                .Bands(1).Override.CellClickAction = CellClickAction.RowSelect
                .Bands(1).Columns("FechaVencimiento").CellActivation = Activation.NoEdit
                .Bands(0).Columns("FechaEmision").CellActivation = Activation.NoEdit
                .Bands(0).Columns("IdEmpresaBanco").CellActivation = Activation.NoEdit
                .Bands(0).Columns("IdMoneda").CellActivation = Activation.NoEdit
            End With
        Catch ex As Exception
            Throw ex
        Finally
            GridObligacionLetras.DataBind()
        End Try
    End Sub

    Private Sub LimpiarDatos()
        lstMovDocumento.Clear()
        lstMovDocumentoLetra.Clear()
        leObligacionFin.Clear()
        griFacturaAgregadas.DataSource = New List(Of e_MovimientoDocumento)
        griFacturas.DataSource = New List(Of e_MovimientoDocumento)
        GridLetras.DataSource = New List(Of e_ObligacionFin)
        'LimpiaGrid(griFacturas, odListadoDocumentos)
        'LimpiaGrid(griFacturaAgregadas, odListadoFacturaLetras)
        'LimpiaGrid(GridLetras, OrgDocumentosFec)
        chkRetencion.Checked = False
    End Sub

    Private Function GuardarLetra() As Boolean
        Try
            Validar_TipoCambio()
            Espere1.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim _MontoDoc As Double = 0, _MontoObl As Double = 0
            IdCtaCtble = String.Empty
            ValidarGrilla(GridLetras, "Ingresar Letras")
            ValidarGrilla(griFacturaAgregadas, "Ingresar Facturas asociadas")
            'Validar Monto de Letras con Facturas
            _MontoDoc = Math.Round(lstMovDocumentoLetra.Sum(Function(it) it.MontoOperar), 2)
            _MontoObl = Math.Round(leObligacionFin.Sum(Function(it) it.MontoCapital), 2)
            If _MontoObl < _MontoDoc Then Throw New Exception("El Monto de las Letras (" & _MontoObl & _
                ") es menor que el Monto a Operar de los Documentos (" & _MontoDoc & ")")
            ' Obtener Asiento por Moneda
            oeAsientoModel = New e_AsientoModelo
            oeAsientoModel.Equivale = 1 : oeAsientoModel.IdMoneda = cboMoneda.Value
            If leAsientoModel.Contains(oeAsientoModel) Then
                oeAsientoModel = leAsientoModel.Item(leAsientoModel.IndexOf(oeAsientoModel))
                oeAsientoModel.TipoOperacion = ""
                oeAsientoModel.Ejercicio = CDate(fecContrato.Value).Year
                oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                If oeAsientoModel.leDetalle.Count > 0 Then
                    Dim _leDetAux = oeAsientoModel.leDetalle.Where(Function(it) it.Cuenta.Contains(gCCTOLetra)).ToList
                    If _leDetAux.Count > 0 Then IdCtaCtble = _leDetAux(0).IdCuentaContable
                    For Each oeOFAux In leObligacionFin
                        oeOFAux.IdCuentaContable = IdCtaCtble
                    Next
                End If
            Else
                Throw New Exception("No Existe Configuracion Contable")
            End If
            'Obtener Periodo
            oePeriodo = New e_Periodo
            oePeriodo = ObtenerPeriodo(CDate(fecContrato.Value))
            oeContratoFin.IdPeriodo = oePeriodo.Id
            'Obtener datos a contrato
            oeContratoFin.FechaEmision = fecContrato.Value
            oeContratoFin.FechaVencimiento = fecContrato.Value
            oeContratoFin.MontoMN = Math.Round(ndTotalContratoMN.Value, 2)
            oeContratoFin.MontoME = Math.Round(ndTotalContratoME.Value, 2)
            oeContratoFin.Capital = leObligacionFin.Sum(Function(it) it.MontoCapital)
            oeContratoFin.IdEmpresaBanco = cboBanco.Value
            oeContratoFin.Glosa = txtGlosa.Text
            oeContratoFin.IdMoneda = cboMoneda.Value
            oeContratoFin.NroCuotas = leObligacionFin.Count
            oeContratoFin.TipoCambio = txtTipoCambio.Value
            oeContratoFin.Usuario = gUsuarioSGI.Id
            oeContratoFin.MacLocal = MacPCLocal()
            oeContratoFin.lstObligacionesFin = leObligacionFin
            oeContratoFin.leDocumentos = lstMovDocumentoLetra
            oeContratoFin.leDocLetra = ObtineCobros(lstMovDocumentoLetra, leObligacionFin)
            oeContratoFin.IndFec = True
            oeContratoFin.IdClienteProveedor = lstMovDocumentoLetra(0).IdClienteProveedor
            oeContratoFin.NombreBanco = cboBanco.Text
            oeContratoFin.PrefijoID = PrefijoIdSucursal '@0001
            If olContratoFin.GuardarLetra(oeContratoFin, oeAsientoModel, ln_TasaRetencion) Then
                Espere1.Visible = False
                mensajeEmergente.Confirmacion("Registrado correctamente", True)
                LimpiarDatos()
                Return True
            End If
        Catch ex As Exception
            Espere1.Visible = False
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            Espere1.Visible = False
        End Try
    End Function

    Private Sub Inicializar()
        oeContratoFin = New e_ContratoFinanciero
        oeContratoFin.TipoOperacion = "I" : oeContratoFin.Activo = True
        oeContratoFin.Usuario = gUsuarioSGI.Id : oeContratoFin.IdTipoDocumento = "1CH000000072"
        cboBanco.SelectedIndex = -1
        cboMoneda.SelectedIndex = -1
        fecContrato.Value = Date.Now.Date
        txtTipoCambio.Value = TipoCambio(fecContrato.Value, True)(0)
        ndTotalContratoME.Value = 0
        ndTotalContratoMN.Value = 0
        IniciliazaObliFin()
        txtGlosa.Text = String.Empty
        btnAgregar.Enabled = False
        btnQuitar.Enabled = False
        BloqueaContrato()
        cboBanco.Focus()
        _idProveedor = String.Empty
        oeContratoFin.PrefijoID = PrefijoIdSucursal '@0001
    End Sub

    Private Sub IniciliazaObliFin()
        oeObligacionFin = New e_ObligacionFin
        oeObligacionFin.TipoOperacion = "I"
        'txtNumero.Text = 1
        fecFechaEmision.Value = Date.Now.Date
        fecFechaVencimiento.Value = Date.Now.Date
        txtMonto.Value = 0
        ' txtGlosa.Text = String.Empty
        'txtNumero.Focus()
        oeObligacionFin.PrefijoID = PrefijoIdSucursal '@0001
    End Sub

    Public Function ObtenerProceso(ByVal cad As String) As String
        Try
            oeProceso = New e_ProcesoNegocio
            oeProceso.Nombre = cad.Trim
            oeProceso = olProceso.Obtener(oeProceso)
            Return oeProceso.Id
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub LlenaCombos()
        Try
            'Cargar Proveedor
            LlenarComboMaestro(cboProveedorFactura, ProveedorPublic, 0)
            oeProveedor.Id = "0"
            oeProveedor.Nombre = "NINGUNO"
            llProveedores.Add(oeProveedor)
            oeProveedor = New e_Proveedor
            oeProveedor.Activo = True
            llProveedores.AddRange(olProveedor.Listar(oeProveedor))
            leProvee = llProveedores.ToList
            'Cargar Tipo Documento
            oeTipoDocumento.Nombre = "FACTURA"
            oeTipoDocumento.Activo = True
            oeTipoDocumento = olTipoDocumento.Obtener(oeTipoDocumento)
            oeProDoc = New e_ProcesoTipoDocumento
            oeProDoc.TipoOperacion = 1
            oeProDoc.IdTipoDocumento = oeTipoDocumento.Id
            oeProDoc.IdProceso = ObtenerProceso("COMPRAS")
            LlenarCombo(cboTipoDocumento, "TipoDocumento", olProDoc.Listar(oeProDoc), 0)
            cboTipoDocumento.Enabled = False
            LlenaMoneda()
            LlenaBanco()
            'Cargar Asiento Modelo
            oeAsientoModel = New e_AsientoModelo
            oeAsientoModel.TipoOperacion = "A" : oeAsientoModel.Activo = True : oeAsientoModel.Nombre = pIdActividadNegocio
            leAsientoModel = olAsientoModel.Listar(oeAsientoModel)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarToolInfo()
        Try
            ToolTipAyudaActualizacion.Enabled = True
            Dim ToolTipInfo As New UltraWinToolTip.UltraToolTipInfo
            ToolTipInfo.ToolTipTitle = "Actualización de Letra"
            ToolTipInfo.ToolTipText = "Es posible actualizar el Nro de letra, Fecha de Vcto e inclusive el banco. " + _
                                       "Solo el banco se actualizará a todo el paquete de letras generadas."
            ToolTipInfo.ToolTipImage = ToolTipImage.Warning
            ToolTipAyudaActualizacion.SetUltraToolTip(LblInfo, ToolTipInfo)
            ToolTipAyudaActualizacion.IsToolTipVisible(LblInfo)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, False)
        End Try
    End Sub

    Private Sub LlenaBanco()
        Try

            Dim oeProveedor As New e_Proveedor
            Dim olProveedor As New l_Proveedor
            Dim leBanco As New List(Of e_Proveedor)
            oeProveedor.Activo = True
            oeProveedor.TipoOperacion = "4"
            leBanco.AddRange(olProveedor.Listar(oeProveedor))
            ''--------------------- para llenar combo en grilla 
            GridObligacionLetras.DisplayLayout.ValueLists.Add("IdEmpresaBanco")
            With GridObligacionLetras.DisplayLayout.ValueLists("IdEmpresaBanco").ValueListItems
                .Clear()
                For Each oeTD As e_Proveedor In leBanco
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdEmpresaBanco", "Nombre", GridObligacionLetras, True)
            ''--------------------------------------
            With cboBanco
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = leBanco
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaMoneda()
        Try
            Dim oeMoneda As New e_Moneda
            Dim olMoneda As New l_Moneda
            Dim leMoneda As New List(Of e_Moneda)
            oeMoneda.Activo = 1
            leMoneda.AddRange(olMoneda.Listar(oeMoneda))
            ''--------------------- para llenar combo en grilla 
            GridObligacionLetras.DisplayLayout.ValueLists.Add("IdMoneda")
            With GridObligacionLetras.DisplayLayout.ValueLists("IdMoneda").ValueListItems
                .Clear()
                For Each oeTD As e_Moneda In leMoneda
                    .Add(oeTD.Id, oeTD.Abreviatura)
                Next
            End With
            CrearComboGrid3("IdMoneda", "Abreviatura", GridObligacionLetras, True)
            ''--------------------------------------
            With cboMoneda
                .DisplayMember = "Nombre"
                .ValueMember = "Id"
                .DataSource = leMoneda
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub ConsultarFacturas()
        Try
            If griFacturaAgregadas.Rows.Count > 0 Then
                If MessageBox.Show("Existen Documentos Agregados, Desea quitarlos?", _
                "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                Else
                    lstMovDocumentoLetra.Clear()
                    LimpiaGrid(griFacturaAgregadas, odListadoFacturaLetras)
                End If
            End If

            If cboMoneda.SelectedIndex = -1 Then Throw New Exception("Seleccione Moneda")
            If Trim(cboProveedorFactura.Value) = "" Then Throw New Exception("Seleccione un Proveedor válido")
            If Len(Trim(cboProveedorFactura.Value)) <> 12 Then Throw New Exception("Seleccione un Proveedor válido")

            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeMovimientoDocumento = New e_MovimientoDocumento
            With oeMovimientoDocumento
                .Activo = True
                .FechaInicio = DtpFacturaDesde.Value
                .FechaFinal = DtpFacturaHasta.Value
                .TipoOperacion = "LET"
                .IdMoneda = cboMoneda.Value
                .Ejercicio = Date.Parse(fecFechaEmision.Value).Year
                .IdClienteProveedor = cboProveedorFactura.Value
                .PrefijoID = PrefijoIdSucursal '@0001
            End With
            Proveedor = cboProveedorFactura.Value

            lstMovDocumento = olMovimientoDocumento.ListarDocumentosPorCompras(oeMovimientoDocumento)
            With griFacturas
                .DataSource = lstMovDocumento
                .DisplayLayout.Bands(0).Columns("FechaCreacion").SortIndicator = SortOrder.Descending
                .DisplayLayout.Bands(0).Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            End With

            With griFacturaAgregadas
                .DataSource = lstMovDocumentoLetra
                .DisplayLayout.Bands(0).Columns("MontoCanje").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("MontoOperar").Header.VisiblePosition = 8
                .DisplayLayout.Bands(0).Columns("Retencion").Header.VisiblePosition = 9
            End With

            OcultarColumna(griFacturaAgregadas, True, "IndDetraccion", "Retencion_Letra", "Retencion_Saldo", "IndElectronico", "IndAnexo", "IndServicioMaterial", "IndDetalleGlosa", "IdTipoBien", "CodMotivo", "OrdenCompra", "EstadoSunat")
            OcultarColumna(griFacturas, True, "IndDetraccion", "Retencion_Letra", "Retencion_Saldo", "IndElectronico", "IndAnexo", "IndServicioMaterial", "IndDetalleGlosa", "IdTipoBien", "CodMotivo", "OrdenCompra", "EstadoSunat", "MontoCanje", "Retencion")
            With griFacturaAgregadas
                If .Rows.Count > 0 Then
                    .Focus()
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            If cboMoneda.SelectedIndex = -1 Then cboMoneda.Focus()
        End Try
    End Sub


    Private Sub OrdenarGrillas()
        With griFacturas
            .DisplayLayout.Bands(0).Columns("FechaCreacion").SortIndicator = SortOrder.Descending
        End With
        With griFacturaAgregadas
            .DisplayLayout.Bands(0).Columns("FechaCreacion").SortIndicator = SortOrder.Descending
        End With
    End Sub

    Sub AgregarMovimientoDocumento()
        Dim _ban As Boolean = True
        Dim id As String
        Dim Bandera As Boolean = False
        id = griFacturas.ActiveRow.Cells("Id").Value.ToString
        olRetencion = New l_DocumentoRetencion
        If griFacturaAgregadas.Rows.Count = 0 Then
            If olRetencion.Obtener(New e_DocumentoRetencion With {.TipoOperacion = "R", .IdAsientoMovimiento = cboProveedorFactura.Value}).ImporteRetencion > 0 Then
                If MessageBox.Show("El Proveedor: " & cboProveedorFactura.Text.Trim & " se ha retenido en operaciones anteriores." & Environment.NewLine & _
                                   "¿Desea Activar la Retencion para esta Operacion?", "Mensaje de Sistema", MessageBoxButtons.YesNo, _
                                   MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    chkRetencion.Checked = False
                    _ban = False
                End If
            Else
                If MessageBox.Show("El Proveedor: " & cboProveedorFactura.Text.Trim & "no  se ha retenido en operaciones anteriores." & Environment.NewLine & _
                                  "¿Desea Activar la Retencion para esta Operacion?", "Mensaje de Sistema", MessageBoxButtons.YesNo, _
                                  MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    chkRetencion.Checked = False
                    _ban = False
                End If
            End If
            If _ban = True Then
                chkRetencion.Checked = True
            End If
        End If
        For Each oeMovDocumento As e_MovimientoDocumento In lstMovDocumento
            oeMovDocumento.PrefijoID = PrefijoIdSucursal '@0001
            If id = oeMovDocumento.Id Then
                If ((_idProveedor = "") Or (_idProveedor <> "" And oeMovDocumento.IdClienteProveedor = _idProveedor)) Then
                    Bandera = True
                    oeMovimientoDocumento = New e_MovimientoDocumento()
                    oeMovimientoDocumento = oeMovDocumento.Clonar
                    If txtGlosa.Text = "" Then
                        txtGlosa.Text = oeMovimientoDocumento._NombreClienteProveedor
                    End If
                    oeMovimientoDocumento.PrefijoID = PrefijoIdSucursal '@0001
                    lstMovDocumentoLetra.Add(oeMovimientoDocumento)
                    If _idProveedor = "" Then
                        _idProveedor = oeMovDocumento.IdClienteProveedor
                    End If
                End If
            End If
        Next
        oeMovimientoDocumento.PrefijoID = PrefijoIdSucursal '@0001
        If Bandera = True Then
            lstMovDocumento.Remove(oeMovimientoDocumento)
        End If
        Call OrdenarGrillas()
        griFacturaAgregadas.DataBind()
        CalcularTotales(griFacturaAgregadas, "MontoCanje", "MontoOperar", "Retencion")
        griFacturas.DataBind()
        griFacturas.Rows.ExpandAll(True)
        If griFacturaAgregadas.Rows.Count > 0 Then
            btnAgregar.Enabled = True
            For pos = 0 To griFacturaAgregadas.Rows.Count - 1
                mt_CalcularRetencion(pos)
            Next
            txtMonto.Focus()
        End If

    End Sub

    Sub QuitarMovimientoDocumento()
        Try
            If GridLetras.Rows.Count > 0 Then Throw New Exception("No Puede Eliminar el documento por que ya se Ingresaron Letras")
            Dim id As String
            id = griFacturaAgregadas.ActiveRow.Cells("Id").Value.ToString
            For Each oeMovDocumento As e_MovimientoDocumento In lstMovDocumentoLetra
                oeMovDocumento.PrefijoID = PrefijoIdSucursal '@0001
                If id = oeMovDocumento.Id Then
                    If ((_idProveedor = "") Or (_idProveedor <> "" And oeMovDocumento.IdClienteProveedor = _idProveedor)) Then
                        oeMovimientoDocumento = New e_MovimientoDocumento()
                        oeMovimientoDocumento = oeMovDocumento.Clonar
                        oeMovimientoDocumento.PrefijoID = PrefijoIdSucursal '@0001
                        lstMovDocumento.Add(oeMovimientoDocumento)
                        lstMovDocumentoLetra.Remove(oeMovDocumento)
                        Exit For
                    End If
                End If
            Next
            griFacturaAgregadas.DataBind()
            CalcularTotales(griFacturaAgregadas, "MontoCanje", "MontoOperar", "Retencion")
            griFacturas.DataBind()
            If lstMovDocumentoLetra.Count = 0 Then
                _idProveedor = ""
            End If
            If griFacturaAgregadas.Rows.Count = 0 Then
                chkRetencion.Checked = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Calcula_Total_Contrato()
        ndTotalContratoMN.Value = leObligacionFin.Sum(Function(it) it.MontoMN)
        ndTotalContratoME.Value = leObligacionFin.Sum(Function(it) it.MontoME)
    End Sub

    Private Sub BloqueaContrato()
        cboMoneda.ReadOnly = IIf(GridLetras.Rows.Count > 0, True, False)
        fecContrato.ReadOnly = IIf(GridLetras.Rows.Count > 0, True, False)
        'txtTipoCambio.ReadOnly = IIf(GridLetras.Rows.Count > 0, True, False)
    End Sub

    Private Function ObtineCobros(leDoc As List(Of e_MovimientoDocumento), leLet As List(Of e_ObligacionFin)) As List(Of e_DetalleDocumento)
        Try
            Dim _MontoDocAux As Double = 0, _MontoLetAux As Double = 0
            leDocLetra = New List(Of e_DetalleDocumento)
            For Each _oeDoc In leDoc
                _MontoDocAux = _oeDoc.MontoOperar
                For Each _oeLet In leLet.Where(Function(it) it.SaldoAux > 0).ToList
                    If _MontoDocAux > 0 Then
                        _MontoLetAux = _oeLet.SaldoAux
                        If _MontoDocAux <= _MontoLetAux Then
                            _oeLet.SaldoAux = Math.Round(_MontoLetAux - _MontoDocAux, 2)
                            oeDocLetra = New e_DetalleDocumento
                            oeDocLetra.IdMovimientoDocumento = _oeDoc.Id
                            oeDocLetra.IdOperacionDetalle = _oeLet.NroVencimiento
                            oeDocLetra.Total = _MontoDocAux
                            oeDocLetra.UnidadMedida = _oeDoc.Serie & "-" & _oeDoc.Numero ' Nro Documento
                            oeDocLetra.NombreMaterialServicio = _oeLet.NroVencimiento ' Nro Letra
                            oeDocLetra.PrefijoID = PrefijoIdSucursal '@0001
                            leDocLetra.Add(oeDocLetra)
                            _MontoDocAux = 0
                        Else
                            _MontoDocAux = Math.Round(_MontoDocAux - _MontoLetAux, 2)
                            oeDocLetra = New e_DetalleDocumento
                            oeDocLetra.IdMovimientoDocumento = _oeDoc.Id
                            oeDocLetra.IdOperacionDetalle = _oeLet.NroVencimiento
                            oeDocLetra.Total = _MontoLetAux
                            oeDocLetra.UnidadMedida = _oeDoc.Serie & "-" & _oeDoc.Numero ' Nro Documento
                            oeDocLetra.NombreMaterialServicio = _oeLet.NroVencimiento ' Nro Letra
                            oeDocLetra.PrefijoID = PrefijoIdSucursal '@0001
                            leDocLetra.Add(oeDocLetra)
                            _oeLet.SaldoAux = 0
                        End If
                    Else
                        Exit For
                    End If
                Next
            Next
            Return leDocLetra
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Private Function TraerDataLetra() As e_ObligacionFinanciera
    '    Dim e_LetraTemporal As New e_ObligacionFinanciera
    '    With e_LetraTemporal
    '        .Id = "-"
    '        .TipoOperacion = "I"
    '        .Codigo = txtNumero.Text
    '        .NroLetra = txtNumero.Text
    '        .IdEmpresaBanco = cboBanco.Value
    '        ._NombreBanco = cboBanco.Text
    '        .Glosa = txtGlosa.Text
    '        .FechaEmision = fecFechaEmision.Value
    '        .FechaVencimiento = fecFechaVencimiento.Value
    '        .IdMoneda = cboMoneda.Value
    '        .TipoCambio = txtTipoCambio.Value
    '        If cboMoneda.Text = "SOLES" Then
    '            .MontoMN = txtMonto.Value
    '            .MontoME = txtMonto.Value / txtTipoCambio.Value
    '            .IdCuentaContable = leCuentasGenerales.Where(Function(item) item.Nombre = "CTALETRASSOLES").ToList(0).Texto2
    '        Else
    '            .MontoMN = txtMonto.Value * txtTipoCambio.Value
    '            .MontoME = txtMonto.Value
    '            .IdCuentaContable = leCuentasGenerales.Where(Function(item) item.Nombre = "CTALETRASDOLARES").ToList(0).Texto2
    '        End If
    '        .Saldo = txtMonto.Value
    '        .TasaInteres = 0
    '        .MontoInteresTes = 0
    '        .MontoInteresCon = 0
    '        .MontoInteresMoratorio = 0
    '        .Comision = 0
    '        .Activo = 1
    '        .UsuarioCreacion = gUsuarioSGI.Id
    '        .MacPcLocalCreacion = MacPCLocal()
    '        ._IdCuentaContableInteres = ""
    '        .IdCuentaBancaria = ""
    '        .Gastos = 0
    '        .IdClienteProveedor = Proveedor
    '        .IndClienteProveedor = 1
    '    End With
    '    Return e_LetraTemporal
    'End Function

    'Private Function ValidarLetras() As Boolean
    '    Try

    '        Dim IdmonedaLetra As String = ""
    '        Dim TipoCambioLetra As Double = 0

    '        IdmonedaLetra = lsLetraCambio(0).IdMoneda
    '        TipoCambioLetra = lsLetraCambio(0).TipoCambio
    '        For Each obj In lsLetraCambio
    '            If obj.IdMoneda <> IdmonedaLetra Then Throw New Exception("Todas las letras deben ser de la misma moneda")
    '            If obj.TipoCambio <> TipoCambioLetra Then Throw New Exception("El tipo de cambio de todas las letras debe ser el mismo.")
    '        Next


    '        Return True
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

#End Region

#Region "Eventos"

    Private Sub btnListarMateriales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarMateriales.Click
        ConsultarFacturas()
    End Sub

    Private Sub frm_LetraCambio_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Try
            If ficLetra.Tabs(0).Active = True Then
                If GridObligacionLetras.Rows.Count = 0 Then
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
                End If
            ElseIf ficLetra.Tabs(1).Active = True Then
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub frm_LetraCambio_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Letra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LlenaCombos()
            Inicializar()
            LlenarToolInfo()
            ln_TasaRetencion = ObtenerRetencion()
            ficLetra.Tabs(1).Enabled = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grFacturas_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griFacturas.CellChange
        Try
            griFacturas.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub grFacturas_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griFacturas.AfterCellUpdate
        Try
            Select Case e.Cell.Column.Key
                Case "Seleccion"
                    With griFacturas.DisplayLayout.Bands(0).Layout.ActiveRow
                        If .Cells("Seleccion").Value Then
                            .Appearance.BackColor = VerdeClaro
                            .Appearance.ForeColor = Rojo
                        Else
                            .Appearance.BackColor = Blanco
                            .Appearance.ForeColor = Negro
                        End If

                    End With
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Private Sub griFacturaLetra_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griFacturaAgregadas.CellChange
        Try
            Dim total As Double = 0.0
            Dim obj As New e_MovimientoDocumento
            obj = griFacturaAgregadas.ActiveRow.ListObject

            If IsNumeric(e.Cell.Value) Then
                total = obj.MontoOperar
                griFacturaAgregadas.UpdateData()
                If Math.Abs(obj.Saldo) < Math.Abs(CDbl(e.Cell.Value)) Then
                    If Math.Round(Math.Abs(CDbl(e.Cell.Value)) - Math.Abs(obj.Saldo), 2) > 0 Then
                        e.Cell.Value = total
                        griFacturaAgregadas.UpdateData()
                        Throw New Exception("El monto ingresado es mayor al saldo")
                    End If
                Else
                    mt_CalcularRetencion(griFacturaAgregadas.ActiveRow.Index)
                End If
                griFacturaAgregadas.UpdateData()
            Else
                e.Cell.Value = obj.MontoOperar
            End If
            griFacturaAgregadas.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Protected Sub mt_CalcularRetencion(pos As Integer)
        With griFacturaAgregadas.Rows(pos)
            If chkRetencion.Checked Then
                .Cells("Retencion").Value = Math.Round((.Cells("MontoCanje").Value * ln_TasaRetencion), 2)
                .Cells("MontoOperar").Value = Math.Round(.Cells("MontoCanje").Value, 2) - Math.Round((.Cells("MontoCanje").Value * ln_TasaRetencion), 2)

            Else
                .Cells("MontoOperar").Value = .Cells("MontoCanje").Value
                .Cells("Retencion").Value = 0.0
            End If
        End With

    End Sub

    Protected Sub mt_CalcularRetencionLetras(pos As Integer)
        With GridLetras.Rows(pos)
            If chkRetencion.Checked Then
                .Cells("RetencionMN").Value = (.Cells("MontoMN").Value / (1 - ln_TasaRetencion)) * ln_TasaRetencion
                .Cells("RetencionME").Value = (.Cells("MontoME").Value / (1 - ln_TasaRetencion)) * ln_TasaRetencion
            Else
                .Cells("RetencionMN").Value = 0.0
                .Cells("RetencionME").Value = 0.0
            End If
        End With


    End Sub

    Private Sub griFacturaLetras_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griFacturaAgregadas.AfterCellUpdate
        Try
            Select Case e.Cell.Column.Key
                Case "Seleccion"
                    With griFacturaAgregadas.DisplayLayout.Bands(0).Layout.ActiveRow
                        If .Cells("Seleccion").Value Then
                            .Appearance.BackColor = VerdeClaro
                            .Appearance.ForeColor = Rojo
                        Else
                            .Appearance.BackColor = Blanco
                            .Appearance.ForeColor = Negro
                        End If

                    End With
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim _totmonto As Double = 0, _montoletra As Double = 0, _montoaux As Double = 0
        Try
            If txtTipoCambio.Value = 0.0 Then Throw New Exception("Comuníquese con el Área de Contabilidad para actualizar el T.C. del día seleccionado.")
            If txtMonto.Value = 0 Then Throw New Exception("Ingrese Monto de Letra")
            _totmonto = lstMovDocumentoLetra.Sum(Function(it) it.MontoOperar)
            _montoletra = leObligacionFin.Sum(Function(it) it.Total)
            _montoaux = Math.Round(_totmonto - _montoletra, 2)
            If txtMonto.Value > _montoaux Then Throw New Exception("El Monto de la Letra no debe superar la cantidad de: " & _montoaux)
            With oeObligacionFin
                .NroVencimiento = txtNumero.Text
                .FechaVencimiento = fecFechaVencimiento.Value
                .MontoCapital = txtMonto.Value
                .Total = txtMonto.Value
                .Saldo = .Total
                .SaldoAux = txtMonto.Value ' Para Cobros de Documentos
                .MontoMN = Math.Round(IIf(cboMoneda.Text = "SOLES", txtMonto.Value, txtMonto.Value * txtTipoCambio.Value), 2)
                .MontoME = Math.Round(IIf(cboMoneda.Text = "SOLES", txtMonto.Value / txtTipoCambio.Value, txtMonto.Value), 2)
                If chkRetencion.Checked Then
                    .RetencionMN = Math.Round(((IIf(cboMoneda.Text = "SOLES", txtMonto.Value, txtMonto.Value * txtTipoCambio.Value) / (1 - ln_TasaRetencion)) * ln_TasaRetencion), 2)
                    .RetencionME = Math.Round(((IIf(cboMoneda.Text = "SOLES", txtMonto.Value / txtTipoCambio.Value, txtMonto.Value) / (1 - ln_TasaRetencion)) * ln_TasaRetencion), 2)
                End If
                .oeFecLetra = New e_FecLetras
                .oeFecLetra.TipoOperacion = "I"
                .oeFecLetra.IndClienteProveedor = 2
                .oeFecLetra.Activo = True
                .oeFecLetra.NroLetra = txtNumero.Text
                .oeFecLetra.IdClienteProveedor = lstMovDocumentoLetra(0).IdClienteProveedor
                .PrefijoID = PrefijoIdSucursal '@0001
            End With
            For Each fila In leObligacionFin
                If txtNumero.Value = fila.NroVencimiento Then
                    txtNumero.Focus()
                    Throw New Exception("El N° de Letra ya fue agregada.")
                    Exit For
                End If
                If fecFechaVencimiento.Value = fila.FechaVencimiento Then
                    Throw New Exception("La Fecha de Vencimiento ya fue agregada.")
                    fecFechaVencimiento.Focus()
                    Exit For
                End If
            Next
            oeObligacionFin.PrefijoID = PrefijoIdSucursal '@0001
            leObligacionFin.Add(oeObligacionFin)

            GridLetras.DataSource = leObligacionFin
            GridLetras.DataBind()
            CalcularTotales(GridLetras, "MontoMN", "MontoME", "RetencionMN", "RetencionME")
            With GridLetras
                .DisplayLayout.Bands(0).Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
                .DisplayLayout.Bands(0).Columns("ITF").Hidden = True
            End With
            If GridLetras.Rows.Count > 0 Then btnQuitar.Enabled = True
            BloqueaContrato()
            Calcula_Total_Contrato()
            IniciliazaObliFin()
            txtNumero.Text = GridLetras.Rows.Count + 1
            fecFechaVencimiento.Value = DateAdd(DateInterval.Day, 30, CDate(fecFechaVencimiento.Value))
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            If txtMonto.Value = 0 Then txtMonto.Focus()
            If txtMonto.Value > _montoaux Then txtMonto.Focus()
        End Try

    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        Try
            If GridLetras.Rows.Count <= 0 Then Throw New Exception("Seleccione una fila")
            ValidarGrilla(GridLetras, "Documentos x Rendir agregados")
            If GridLetras.ActiveRow Is Nothing Then Throw New Exception("Seleccione una fila")
            If GridLetras.ActiveRow.ListObject Is Nothing Then Throw New Exception("Seleccione una fila")
            Dim letra As Integer = GridLetras.Rows(GridLetras.ActiveRow.Index).Cells("NroVencimiento").Value
            fecFechaVencimiento.Value = GridLetras.Rows(GridLetras.ActiveRow.Index).Cells("FechaVencimiento").Value
            txtNumero.Value = GridLetras.Rows(GridLetras.ActiveRow.Index).Cells("NroVencimiento").Value

            Dim oeOFAux As New e_ObligacionFin
            oeOFAux = GridLetras.ActiveRow.ListObject
            leObligacionFin.Remove(oeOFAux)
            GridLetras.DataSource = leObligacionFin
            GridLetras.DataBind()
            CalcularTotales(GridLetras, "MontoMN", "MontoME", "RetencionMN", "RetencionME")
            BloqueaContrato()
            Calcula_Total_Contrato()
            txtMonto.Focus()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtNumero_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.ValueChanged
        Try
            If txtNumero.Text.Trim <> String.Empty Then
                If txtTipoCambio.Value = 0 Then Throw New Exception("Ingrese Tipo Cambio")
                'oeLetraCambio.NroLetra = txtNumero.Text : oeLetraCambio.Modificado = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            If txtTipoCambio.Value = 0 Then txtTipoCambio.Focus() ': txtNumero.Text = String.Empty
        End Try
    End Sub

    Private Sub fecFechaEmision_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles fecFechaEmision.Validated
        Try

            If txtTipoCambio.Value = 0 Then
                txtTipoCambio.Value = TipoCambio(fecFechaEmision.Value)(0)
            Else
                If MessageBox.Show("Desea Cambiar al Tipo de Cambio del dia?", "Mensaje del sistema", _
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) _
                   = Windows.Forms.DialogResult.Yes Then
                    txtTipoCambio.Value = TipoCambio(fecFechaEmision.Value)(0)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub fecFechaEmision_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecFechaEmision.ValueChanged
        'oeLetraCambio.FechaEmision = fecFechaEmision.Value
        'oeLetraCambio.Modificado = True
    End Sub

    Private Sub fecFechaVencimiento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecFechaVencimiento.ValueChanged
        'oeLetraCambio.FechaVencimiento = fecFechaVencimiento.Value
        'oeLetraCambio.Modificado = True
    End Sub

    Private Sub txtTipoCambio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTipoCambio.ValueChanged
        'oeLetraCambio.TipoCambio = txtTipoCambio.Value
        'oeLetraCambio.Modificado = True
    End Sub

    Private Sub txtGlosa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa.ValueChanged
        'oeLetraCambio.Glosa = txtGlosa.Text
        'oeLetraCambio.Modificado = True
    End Sub

    Private Sub griFactura_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griFacturas.DoubleClick
        If griFacturas.Selected.Rows.Count > 0 Then AgregarMovimientoDocumento()
    End Sub

    Private Sub griFacturaLetra_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griFacturaAgregadas.DoubleClick
        If griFacturaAgregadas.Selected.Rows.Count > 0 Then QuitarMovimientoDocumento()
    End Sub

    Private Sub gridletras_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles GridLetras.CellChange
        'Verificar que el monto a operar no sea mayor al saldo ni sea 0
        Try

            l_FuncionesGenerales.ValidarNumero(txtTipoCambio.Value, "Tipo de Cambio")
            Dim obj As New e_MovimientoDocumento
            obj = GridLetras.ActiveRow.ListObject
            If IsNumeric(e.Cell.Value) Then
                Dim total As Double = obj.MontoOperar
                GridLetras.UpdateData()
                If Math.Abs(obj.Saldo) < Math.Abs(CDbl(e.Cell.Value)) Then
                    e.Cell.Value = total
                    GridLetras.UpdateData()
                    Throw New Exception("El monto ingresado es mayor al saldo")
                End If
            Else
                e.Cell.Value = obj.MontoOperar
                GridLetras.UpdateData()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Private Sub QuitarDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarDocumento.Click
        Try
            'With GridObligacionLetras
            '    ValidarGrilla(GridObligacionLetras, "Obligacion")
            '    If Not .ActiveRow Is Nothing AndAlso .ActiveRow.Cells("Id").Value.ToString <> "" Then
            '        Dim oeObligacion As New e_ObligacionFinanciera
            '        oeObligacion = GridObligacionLetras.ActiveRow.ListObject
            '        If oeObligacion.Activo Then
            '            If MessageBox.Show("Esta seguro de eliminar la Obligacion: " & _
            '                .ActiveRow.Cells("codigo").Value.ToString & " ?", "Mensaje del Sistema", _
            '                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            '                oeObligacion.TipoOperacion = "X"
            '                oeObligacion.Codigo = "LETRA"
            '                olLetraCambio.Eliminar(oeObligacion)
            '                Consultar(True)
            '            End If
            '        Else
            '            Throw New Exception("La informacion  se encuentra eliminada.")
            '        End If
            '    Else
            '        Throw New Exception("Seleccione una Fila!")
            '    End If
            'End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub GridObligacionLetras_BeforeCellUpdate(sender As Object, e As BeforeCellUpdateEventArgs) Handles GridObligacionLetras.BeforeCellUpdate
        Try
            If GridObligacionLetras.Rows.Count > 0 AndAlso Not GridObligacionLetras.ActiveRow.ListObject Is Nothing Then
                oeLetra = New e_ObligacionFinanciera
                oeLetra = GridObligacionLetras.ActiveRow.ListObject
            Else
                oeLetra = Nothing
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub GridObligacionLetras_ClickCellButton(sender As Object, e As CellEventArgs) Handles GridObligacionLetras.ClickCellButton
        Try
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            Dim oeFinPago As New e_ObligacionPago
            Dim olFinPago As New l_ObligacionPago
            Dim leFinPago As New List(Of e_ObligacionPago)
            oeFinPago.Activo = True
            oeFinPago.TipoOperacion = "L"
            oeFinPago.FechaInicial = Date.Now()
            oeFinPago.FechaFinal = Date.Now()
            oeFinPago.IdObligacionFinanciera = GridObligacionLetras.ActiveRow.Cells("Id").Value
            oeFinPago.PrefijoID = PrefijoIdSucursal '@0001
            leFinPago = olFinPago.Listar(oeFinPago)

            If leFinPago.Count = 0 Then
                Select Case e.Cell.Column.Key
                    Case "IdCuentaBancaria"
                        Dim olLetra As New l_ObligacionFinanciera
                        GridObligacionLetras.UpdateData()
                        If Not oeLetra Is Nothing Then
                            oeLetra = GridObligacionLetras.ActiveRow.ListObject
                            oeLetra.TipoOperacion = "L"
                            oeLetra.NroLetra = oeLetra.Codigo
                            oeLetra.PrefijoID = PrefijoIdSucursal '@0001
                            olLetra.GuardarObli(oeLetra)
                            GridObligacionLetras.ActiveRow.CellAppearance.BackColor = Me.ColorBloque.Color
                            mensajeEmergente.Confirmacion("Se actualizó correctamente", False)
                        End If
                End Select
            Else
                ListaLetra()
                Throw New Exception("No se puede actualizar una Obligación que ya tiene pagos asociados")
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
        End Try
    End Sub

    Private Sub ChkMoratorio_CheckedChanged(sender As Object, e As EventArgs) Handles ChkMoratorio.CheckedChanged
        If ChkMoratorio.Checked = True Then
            GridObligacionLetras.DisplayLayout.Bands(0).Columns("MontoInteresMoratorio").Hidden = False
        Else
            GridObligacionLetras.DisplayLayout.Bands(0).Columns("MontoInteresMoratorio").Hidden = True
        End If
    End Sub

    Private Sub cboProveedorFactura_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles cboProveedorFactura.InitializeLayout
        Try
            With cboProveedorFactura.DisplayLayout.Bands(0)
                .Columns("Id").Hidden = True
                .Columns("Descripcion").Hidden = True
                .Columns("Nombre").Hidden = False
                .Columns("Nombre").Width = 350
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboProveedorFactura_KeyDown(sender As Object, e As KeyEventArgs) Handles cboProveedorFactura.KeyDown
        Try
            With CType(sender, Infragistics.Win.UltraWinGrid.UltraCombo)
                If e.KeyData = Keys.Delete Then
                    .Text = ""
                End If
            End With
            If e.KeyCode = Keys.Enter Then
                If cboProveedorFactura.Text.Trim = "" Then
                    cboProveedorFactura.DataSource = Nothing
                    cboProveedorFactura.DataSource = ProveedorPublic
                Else
                    cboProveedorFactura.DataSource = Nothing
                    ListaProveedor = New List(Of e_Combo)
                    ListaProveedor = ProveedorPublic
                    cboProveedorFactura.DataSource = ListaProveedor.Where(Function(Item) Item.Nombre.Contains(cboProveedorFactura.Text.Trim)).ToList
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboProveedorFactura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboProveedorFactura.KeyPress
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then cboProveedorFactura.PerformAction(UltraComboAction.Dropdown)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboMoneda_ValueChanged(sender As Object, e As EventArgs) Handles cboMoneda.ValueChanged
        Try
            If cboMoneda.SelectedIndex > -1 Then
                If cboBanco.SelectedIndex = -1 Then Throw New Exception("Seleccione Entidad Bancaria")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            If cboBanco.SelectedIndex = -1 Then cboMoneda.SelectedIndex = -1 : cboBanco.Focus()
        End Try
    End Sub

    Private Sub txtMonto_ValueChanged(sender As Object, e As EventArgs) Handles txtMonto.ValueChanged
        Try
            If txtMonto.Value > 0 Then
                If cboMoneda.SelectedIndex = -1 Then Throw New Exception("Seleccione Moneda")
                If txtNumero.Text.Trim = String.Empty Then Throw New Exception("Ingrese Numero de Cuota")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            If cboMoneda.SelectedIndex = -1 Then txtMonto.Value = 0 : cboMoneda.Focus()
            If txtNumero.Text.Trim = String.Empty Then txtMonto.Value = 0 : txtNumero.Focus()
        End Try
    End Sub

    Private Sub chkRetencion_CheckedChanged(sender As Object, e As EventArgs) Handles chkRetencion.CheckedChanged
        With griFacturaAgregadas.Rows
            If .Count > 0 Then
                For i = 0 To .Count - 1
                    mt_CalcularRetencion(i)
                Next
            End If
        End With

        With GridLetras.Rows
            If .Count > 0 Then
                For i = 0 To .Count - 1
                    mt_CalcularRetencionLetras(i)
                Next
            End If
        End With
    End Sub

#End Region


    Private Sub txtTipoCambio_EditorButtonClick(sender As Object, e As UltraWinEditors.EditorButtonEventArgs) Handles txtTipoCambio.EditorButtonClick
        Validar_TipoCambio()
    End Sub

    Private Sub fecContrato_ValueChanged(sender As Object, e As EventArgs) Handles fecContrato.ValueChanged
        Validar_TipoCambio()
    End Sub

    Private Sub Validar_TipoCambio()
        Try
            txtTipoCambio.Value = TipoCambio(fecContrato.Value, False)(0)
            If txtTipoCambio.Value = 0.0 Then Throw New Exception("Comuníquese con el Área de Contabilidad para actualizar el T.C. del día seleccionado.")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub
End Class
