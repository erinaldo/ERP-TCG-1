Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win.UltraWinGrid

Public Class frm_FactoryFEDD
    Inherits ISL.Win.frm_MenuPadre

#Region "Declaracion de Variables"

    'Private oeObligacion As New e_ObligacionFinanciera, olObligacion As New l_ObligacionFinanciera
    Private leTipoObli As New List(Of e_ObligacionFinanciera)
    Private WithEvents oeMovimientoDocumento As New e_MovimientoDocumento
    Private olMovimientoDocumento As New l_MovimientoDocumento
    Private leMovDoc As New List(Of e_MovimientoDocumento), leMovDocAgregado As New List(Of e_MovimientoDocumento)
    Private leFactoringAgregado As New List(Of e_ObligacionAyudaDetalle)
    Private oeFactoring As New e_ObligacionAyudaDetalle
    Private oeCuentaBancaria As New e_CuentaBancaria
    Private importeMN As Double, importeME As Double
    Dim oePeriodo As New e_Periodo, olPeriodo As New l_Periodo
    Private oeCtaBancaria As New e_CuentaBancaria, olCtaBancaria As New l_CuentaBancaria, leCtaBancaria As New List(Of e_CuentaBancaria)
    Private oeAsientoModel As New e_AsientoModelo, olAsientoModel As New l_AsientoModelo, leAsientoModel As New List(Of e_AsientoModelo)
    Private oeReferencia As New e_AsientoModelo_Referencia, olReferencia As New l_AsientoModelo_Referencia, leReferencia As New List(Of e_AsientoModelo_Referencia)
    Private oeContratoFin As New e_ContratoFinanciero, olContratoFin As New l_ContratoFinanciero
    Private oeObligacionFin As New e_ObligacionFin, leObligacionFin As New List(Of e_ObligacionFin)
    Private oeTipoDoc As New e_TipoDocumento, leTipoDoc As New List(Of e_TipoDocumento), olTipoDoc As New l_TipoDocumento
    Private leTipoDocBus As New List(Of e_TipoDocumento), leTipoDocIns As New List(Of e_TipoDocumento)
    Private DTReferencia As Data.DataTable, dtAux As Data.DataTable ', dsPagare As DataSet
    Private dsFedd As DataSet, relationContratoObligFin As DataRelation
    Dim ListaCliente As New List(Of e_Combo)
    Dim _idFactDesc As String, IdCtaCtble As String

#End Region

#Region "Instancia"

    Private Shared instancia As frm_FactoryFEDD = Nothing
    Private Shared Operacion As String

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_FactoryFEDD
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            'If tcFactoringFedd.Tabs(0).Selected = True Then
            ListaFactoringFedd()
            If GridFactoringFedd.Rows.Count > 0 Then
                ControlBoton(1, 1, 0, 0, 0, 1, 0, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
            End If

            'ElseIf tcFactoringFedd.Tabs(1).Selected = True Then
            'Listar(True)
            ' ControlBoton(1, 0, 0, 1, 1, 0, 0, 0, 1)
            'End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Inicializar()
        If tcFactoringFedd.Tabs(0).Selected = True Then
            MostrarTabs(1, tcFactoringFedd, 1)
            ControlBoton(1, 0, 0, 1, 1, 0, 0, 0, 0)
            Operacion = "Nuevo"
        End If
    End Sub

    Public Overrides Sub Guardar()
        Try
            ValidarCombo(CboTipo, "Tipo de Obligacion")
            oePeriodo = New e_Periodo
            oePeriodo.Ejercicio = Date.Parse(FecFecha.Value).Year
            oePeriodo.Mes = Date.Parse(FecFecha.Value).Month
            oePeriodo = olPeriodo.Obtener(oePeriodo)
            If l_FuncionesGenerales.ValidarPeriodo(oePeriodo.Id, gAreasSGI.Tesoreria) Then
                If CboTipo.Text = "FEDD" Then
                    GuardarFedd()
                ElseIf CboTipo.Text = "FACTORING" Then
                    GuardarFactoring()
                End If
                If GridFactoringFedd.Rows.Count > 0 Then
                    ControlBoton(1, 1, 0, 0, 0, 1, 0, 0, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
                End If
            End If
            Operacion = ""
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try

            'Consultar(True) 'activa desactiva botonera
            MostrarTabs(0, tcFactoringFedd, 0)
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
            Operacion = ""
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            'With GridFactoringFedd
            '    ValidarGrilla(GridFactoringFedd, "Obligacion")
            '    If Not .ActiveRow Is Nothing AndAlso .ActiveRow.Cells("Id").Value.ToString <> "" Then
            '        oeObligacion.Id = .ActiveRow.Cells("Id").Value
            '        oeObligacion = olObligacion.Obtener(oeObligacion)
            '        If oeObligacion.Activo Then
            '            If MessageBox.Show("Esta seguro de eliminar la Obligacion: " & _
            '                 .ActiveRow.Cells("codigo").Value.ToString & " ?", "Mensaje del Sistema", _
            '                 MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            '                oeObligacion.TipoOperacion = "X"
            '                oeObligacion.Codigo = "FEDDFACTORY"
            '                olObligacion.Eliminar(oeObligacion)
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

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try

            If GridFactoringFedd.Rows.Count = 0 Then Throw New Exception("No hay ningún dato de Fedd para exportar al Excel")
            Exportar_Excel(GridFactoringFedd)

            'If GridFactoring.Rows.Count = 0 Then Throw New Exception("No hay ningún dato de Factoring para exportar al Excel")
            'Exportar_Excel(GridFactoring)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub LimpiarControles()
        Try
            txt_Glosa.Text = ""
            DecSubTotal.Value = 0
            DecTasaInt.Value = 0
            DecInteresMonto.Value = 0
            TxtUnico.Text = ""
            CboBanco.SelectedIndex = -1
            CboCtaBancaria.SelectedIndex = -1
            CboMoneda.SelectedIndex = -1
            CboTipo.SelectedIndex = 0
            txt_Glosa.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Function GuardarFedd() As Boolean
        Try
            Espere1.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If decImporteSol.Value = 0 Or decImporteDol.Value = 0 Then Throw New Exception("Los Importes Soles y Dolares son Cero")
            ValidarCombo(CboMoneda, "Moneda")
            ValidarCombo(CboBanco, "Banco")
            ValidarCombo(CboCtaBancaria, "Cuenta Bancaria")
            l_FuncionesGenerales.ValidarNumero(DecInteresMonto.Value, "Monto Interés")
            l_FuncionesGenerales.ValidarNumero(DecTasaInt.Value, "Tasa Interés")
            l_FuncionesGenerales.ValidarNumero(DecSubTotal.Value, "Sub Total")
            'Filtra DtReferencia
            dtAux = New Data.DataTable
            Dim _rwAux() As Data.DataRow
            Dim cadSQL As String = String.Empty
            cadSQL = "TipoRef1 = 4 AND IdRef1 = '" & CboMoneda.Value & "' AND TipoRef2 = 5 AND Ref2 = '" & CboTipo.Text.Trim & "'"
            _rwAux = DTReferencia.Select(cadSQL, "")
            If _rwAux.Count = 0 Then Throw New Exception("No tiene configuracion contable")
            dtAux = _rwAux.CopyToDataTable
            'Obtiene Asiento Modelo por Referencia
            oeAsientoModel = New e_AsientoModelo
            oeAsientoModel.TipoOperacion = "" : oeAsientoModel.Activo = True
            oeAsientoModel.Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString
            oeAsientoModel.Ejercicio = CDate(FecFecha.Value).Year
            oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
            If oeAsientoModel.leDetalle.Count > 0 Then
                Dim _leDetAux = oeAsientoModel.leDetalle.Where(Function(it) it.Cuenta.Contains(gCCTOFecFeddCredHipo)).ToList
                If _leDetAux.Count > 0 Then IdCtaCtble = _leDetAux(0).IdCuentaContable
            Else
                Throw New Exception("No Existe Configuracion Contable")
            End If
            'Cargar Obligacion
            leObligacionFin = New List(Of e_ObligacionFin)
            oeObligacionFin = New e_ObligacionFin
            oeObligacionFin.TipoOperacion = "I"
            oeObligacionFin.NroVencimiento = TxtUnico.Text.Trim
            oeObligacionFin.FechaVencimiento = FecVencimiento.Value
            oeObligacionFin.MontoMN = IIf(CboMoneda.Text = "SOLES", DecSubTotal.Value, DecSubTotal.Value * DecTC.Value)
            oeObligacionFin.MontoME = IIf(CboMoneda.Text = "SOLES", DecSubTotal.Value / DecTC.Value, DecSubTotal.Value)
            oeObligacionFin.MontoInteres = Math.Round(DecInteresMonto.Value, 2)
            oeObligacionFin.MontoCapital = Math.Round(DecSubTotal.Value, 2)
            oeObligacionFin.Saldo = oeObligacionFin.MontoCapital + oeObligacionFin.MontoInteres
            oeObligacionFin.IdCuentaContable = IdCtaCtble
            oeObligacionFin.leOblFinDoc = ObtenerObliDoc(leMovDocAgregado)
            leObligacionFin.Add(oeObligacionFin)
            'Obtener Flujo Caja y Medio de Pago
            oeContratoFin = New e_ContratoFinanciero
            If oeAsientoModel.leDMReferencia.Count = 0 Then Throw New Exception("No Se Han Configurado el Flujo de Caja y el Medio de Pago")
            Dim _leRefDM = oeAsientoModel.leDMReferencia.OrderBy(Function(it) it.TipoReferencia).ToList
            oeContratoFin.oeMovCajaBanco = New e_MovimientoCajaBanco
            oeContratoFin.oeMovCajaBanco.IdFlujoCaja = _leRefDM(0).IdReferencia.Trim
            oeContratoFin.oeMovCajaBanco.IdMedioPago = _leRefDM(1).IdReferencia.Trim
            oeContratoFin.oeMovCajaBanco.IdCuentaBancaria = CboCtaBancaria.Value
            'Obtener Periodo
            oePeriodo = New e_Periodo
            oePeriodo = ObtenerPeriodo(CDate(FecFecha.Value))
            oeContratoFin.IdPeriodo = oePeriodo.Id
            'Llenar Contrato
            oeContratoFin.Codigo = TxtUnico.Text.Trim
            oeContratoFin.Usuario = gUsuarioSGI.Id
            oeContratoFin.TipoOperacion = "I"
            oeContratoFin.FechaEmision = FecFecha.Value
            oeContratoFin.FechaVencimiento = leObligacionFin(0).FechaVencimiento
            oeContratoFin.Glosa = txt_Glosa.Text
            oeContratoFin.IdEmpresaBanco = CboBanco.Value
            oeContratoFin.IdMoneda = CboMoneda.Value
            oeContratoFin.IdTipoDocumento = CboTipo.Value
            oeContratoFin.TasaInteres = DecTasaInt.Value
            oeContratoFin.TipoCambio = DecTC.Value
            oeContratoFin.MontoMN = IIf(CboMoneda.Text = "SOLES", DecSubTotal.Value, Math.Round(DecSubTotal.Value * DecTC.Value, 2))
            oeContratoFin.MontoME = IIf(CboMoneda.Text = "SOLES", Math.Round(DecSubTotal.Value / DecTC.Value, 2), DecSubTotal.Value)
            oeContratoFin.NroCuotas = leObligacionFin.Count
            oeContratoFin.lstObligacionesFin = leObligacionFin
            oeContratoFin.NombreBanco = CboBanco.Text
            oeContratoFin.Capital = DecSubTotal.Value
            'Guardar Contrato Financiero
            If olContratoFin.GuardarFedd(oeContratoFin, oeAsientoModel) Then
                Espere1.Visible = False
                mensajeEmergente.Confirmacion("Se registró Correctamente", True)
                leMovDocAgregado.Clear() : GridAgregados.DataSource = leMovDocAgregado : GridAgregados.DataBind()
                LimpiarControles()
                MostrarTabs(0, tcFactoringFedd)
                ListaFactoringFedd()
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

    Private Function GuardarFactoring() As Boolean
        Try
            Espere1.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim _idAsientoModel As String = ""
            IdCtaCtble = String.Empty
            If decImporteSol.Value = 0 Or decImporteDol.Value = 0 Then Throw New Exception("Los Importes Soles y Dolares son Cero")
            ValidarCombo(CboMoneda, "Moneda")
            ValidarCombo(CboBanco, "Banco")
            If chkFactoring.Checked = False Then ValidarCombo(CboCtaBancaria, "Cuenta Bancaria")
            If leObligacionFin.Count = 0 Then Throw New Exception("Ingrese al Menos un Factoring")
            If leMovDocAgregado.Count = 0 Then Throw New Exception("Ingrese al Menos una Venta")
            leAsientoModel = New List(Of e_AsientoModelo)
            'Filtra DtReferencia
            dtAux = New Data.DataTable
            Dim _rwAux() As Data.DataRow
            Dim cadSQL As String = String.Empty
            cadSQL = "TipoRef1 = 4 AND IdRef1 = '" & CboMoneda.Value & "' AND TipoRef2 = 5 AND Ref2 = '" & gTOFactDesc & "'"
            _rwAux = DTReferencia.Select(cadSQL, "")
            If _rwAux.Count = 0 Then Throw New Exception("No tiene configuracion contable")
            dtAux = _rwAux.CopyToDataTable
            'Obtiene Asiento Modelo por Referencia
            oeAsientoModel = New e_AsientoModelo
            oeAsientoModel.TipoOperacion = "" : oeAsientoModel.Activo = True
            oeAsientoModel.Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString
            oeAsientoModel.Ejercicio = CDate(FecFecha.Value).Year
            oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
            If oeAsientoModel.leDetalle.Count > 0 Then
                Dim _leDetAux = oeAsientoModel.leDetalle.Where(Function(it) it.Cuenta.Contains(gCCTOFactDcto)).ToList
                If _leDetAux.Count > 0 Then IdCtaCtble = _leDetAux(0).IdCuentaContable
                For Each oeOFAux In leObligacionFin
                    oeOFAux.IdCuentaContable = IdCtaCtble
                Next
            Else
                Throw New Exception("No Existe Configuracion Contable")
            End If
            _idAsientoModel = oeAsientoModel.IdVinculado
            leAsientoModel.Add(oeAsientoModel)
            'Obtener Flujo Caja y Medio de Pago
            oeContratoFin = New e_ContratoFinanciero
            If oeAsientoModel.leDMReferencia.Count = 0 Then Throw New Exception("No Se Han Configurado el Flujo de Caja y el Medio de Pago")
            Dim _leRefDM = oeAsientoModel.leDMReferencia.OrderBy(Function(it) it.TipoReferencia).ToList
            oeContratoFin.oeMovCajaBanco = New e_MovimientoCajaBanco
            oeContratoFin.oeMovCajaBanco.IdFlujoCaja = _leRefDM(0).IdReferencia.Trim
            oeContratoFin.oeMovCajaBanco.IdMedioPago = _leRefDM(1).IdReferencia.Trim
            oeContratoFin.oeMovCajaBanco.IdCuentaBancaria = CboCtaBancaria.Value
            'Obtiene Asiento Modelo para Interes
            oeAsientoModel = New e_AsientoModelo
            oeAsientoModel.TipoOperacion = "" : oeAsientoModel.Activo = True
            oeAsientoModel.Id = _idAsientoModel
            oeAsientoModel.Ejercicio = CDate(FecFecha.Value).Year
            oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
            If oeAsientoModel.leDetalle.Count = 0 Then Throw New Exception("No Existe Configuracion Contable")
            leAsientoModel.Add(oeAsientoModel)
            'Obtener Periodo
            oePeriodo = New e_Periodo
            oePeriodo = ObtenerPeriodo(CDate(FecFecha.Value))
            oeContratoFin.IdPeriodo = oePeriodo.Id
            'Llenar Contrato
            oeContratoFin.Codigo = txtCodigoBancoFactoring.Text.Trim
            oeContratoFin.Usuario = gUsuarioSGI.Id
            oeContratoFin.TipoOperacion = "I"
            oeContratoFin.FechaEmision = FecFecha.Value
            oeContratoFin.FechaVencimiento = leObligacionFin(0).FechaVencimiento
            oeContratoFin.Glosa = txt_Glosa.Text
            oeContratoFin.IdEmpresaBanco = CboBanco.Value
            oeContratoFin.IdMoneda = CboMoneda.Value
            oeContratoFin.IdTipoDocumento = _idFactDesc
            oeContratoFin.TasaInteres = DecTasaInteresFactoring.Value
            oeContratoFin.TipoCambio = DecTC.Value
            oeContratoFin.MontoMN = IIf(CboMoneda.Text = "SOLES", DecTotalFactoring.Value, Math.Round(DecTotalFactoring.Value * DecTC.Value, 2))
            oeContratoFin.MontoME = IIf(CboMoneda.Text = "SOLES", Math.Round(DecTotalFactoring.Value / DecTC.Value, 2), DecTotalFactoring.Value)
            oeContratoFin.NroCuotas = leObligacionFin.Count
            leObligacionFin(0).leOblFinDoc = ObtenerObliDoc(leMovDocAgregado)
            oeContratoFin.lstObligacionesFin = leObligacionFin
            oeContratoFin.NombreBanco = CboBanco.Text
            oeContratoFin.Capital = DecTotalFactoring.Value
            'Guardar Contrato Financiero
            If olContratoFin.GuardarFactDesc(oeContratoFin, leAsientoModel) Then
                Espere1.Visible = False
                mensajeEmergente.Confirmacion("Se registró Correctamente", True)
                leMovDocAgregado.Clear() : GridAgregados.DataSource = leMovDocAgregado : GridAgregados.DataBind()
                leObligacionFin.Clear() : GridFactoring.DataSource = leObligacionFin : GridFactoring.DataBind()
                LimpiarControles()
                MostrarTabs(0, tcFactoringFedd)
                ListaFactoringFedd()
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

    Private Sub ListaFactoringFedd()
        Try
            Cursor.Current = Cursors.WaitCursor

            oeContratoFin = New e_ContratoFinanciero
            oeContratoFin.TipoOperacion = "F"
            oeContratoFin.Activo = True
            ValidarFechaDesde_Hasta(FecDesde, FecHasta)
            oeContratoFin.FechaEmision = FecDesde.Value
            oeContratoFin.FechaVencimiento = FecHasta.Value
            oeContratoFin.IdTipoDocumento = CboTipoObligacionListar.Value
            dsFedd = olContratoFin.ListarDS(oeContratoFin)

            ''''''''''''''''''''''''''''''''''''''''''''''
            'Tabla(0) CONTRATOS
            'Tabla(1) OBLIGACIONES
            ''''''''''''''''''''''''''''''''''''''''''''''
            Dim IdContrato As DataColumn = dsFedd.Tables(0).Columns("Id")
            Dim IdObligFin As DataColumn = dsFedd.Tables(1).Columns("IdContratoFinanciero")
            relationContratoObligFin = New DataRelation("FK_Relacion", IdContrato, IdObligFin, False)
            dsFedd.Relations.Add(relationContratoObligFin)
            dsFedd.AcceptChanges()
            GridFactoringFedd.DataSource = dsFedd
            With GridFactoringFedd.DisplayLayout
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
            End With
        Catch ex As Exception
            Throw ex
        Finally
            ' GrDocumentos.DataBind()
        End Try
    End Sub

    Private Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            If GridAgregados.Rows.Count > 0 Then
                If MessageBox.Show("Existen Documentos agregados, desea eliminarlos", "Mensaje del Sistema", _
               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
               = Windows.Forms.DialogResult.Yes Then
                    leMovDocAgregado.Clear() : GridAgregados.DataBind()
                    'Else
                    '    Exit Sub
                End If
            Else
                leMovDocAgregado.Clear()
            End If
            If Trim(cboClienteFac.Value) = "" Then Throw New Exception("Seleccione un Cliente válido")
            If Len(Trim(cboClienteFac.Value)) <> 12 Then Throw New Exception("Seleccione un Cliente válido")
            If CboMoneda.SelectedIndex = -1 Then Throw New Exception("Seleccione Moneda")
            oeMovimientoDocumento = New e_MovimientoDocumento
            oeMovimientoDocumento.Activo = Activo : oeMovimientoDocumento.Ejercicio = Date.Parse(FecFecha.Value).Year
            oeMovimientoDocumento.IndCompraVenta = IIf(chkFactoring.Checked, 1, 2)
            oeMovimientoDocumento.TipoOperacion = IIf(chkFactoring.Checked, "PAG", "COB")
            oeMovimientoDocumento.IdMoneda = CboMoneda.Value
            oeMovimientoDocumento.IdClienteProveedor = cboClienteFac.Value
            leMovDoc.Clear()
            leMovDoc.AddRange(olMovimientoDocumento.Listar(oeMovimientoDocumento))
            GridDocumentosVentas.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        GridDocumentosVentas.Focus()
        If CboMoneda.SelectedIndex = -1 Then CboMoneda.Focus()
    End Sub

    Private Sub LlenarBanco()
      
        Dim oeProveedor As New e_Proveedor
        Dim olProveedor As New l_Proveedor
        Dim leProveedor As New List(Of e_Proveedor)
        oeProveedor.Activo = True
        oeProveedor.TipoOperacion = "4"

        leProveedor.AddRange(olProveedor.Listar(oeProveedor))
        '--------------------- para llenar combo en grilla gridventas   
        GridFactoringFedd.DisplayLayout.ValueLists.Add("IdEmpresaBanco")
        With GridFactoringFedd.DisplayLayout.ValueLists("IdEmpresaBanco").ValueListItems
            .Clear()
            For Each oeTD As e_Proveedor In leProveedor
                .Add(oeTD.Id, oeTD.Nombre)
            Next
        End With
        CrearComboGrid3("IdEmpresaBanco", "Nombre", GridFactoringFedd, True)
        '--------------------------------------
        With CboBanco
            .ValueMember = "Id"
            .DisplayMember = "Nombre"
            .DataSource = leProveedor
        End With
    End Sub

    Private Sub Inicializar()
        Try
            TxtUnico.Text = ""
            FecFecha.Value = Date.Now
            CboBanco.SelectedIndex = -1
            CboCtaBancaria.SelectedIndex = -1
            CboMoneda.SelectedIndex = -1
            leMovDocAgregado.Clear()
            GridAgregados.DataBind()
            leMovDoc.Clear()
            GridDocumentosVentas.DataBind()
            leFactoringAgregado.Clear()
            GridFactoring.DataBind()
            DecTasaInteresFactoring.Value = "0.00"
            DecTotalFactoring.Value = "0.00"
            DecMontoInteresFactoring.Value = "0.00"
            DecComisionFactoring.Value = "0.00"
            DecGastosFactoring.Value = "0.00"
            DecSubTotal.Value = "0.00"
            DecTasaInt.Value = "0.00"
            DecInteresMonto.Value = "0.00"
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub LlenaCuentaBancaria()
        Try
            oeCtaBancaria = New e_CuentaBancaria
            oeCtaBancaria.Id = oeCtaBancaria.Id 'Relacionada con Cuenta Contale
            oeCtaBancaria.Activo = True
            leCtaBancaria = olCtaBancaria.Listar(oeCtaBancaria)
            ' LlenarCombo(CboCtaBancaria, "BancoCuenta", olCtaBancaria.Listar(oeCtaBancaria), -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaMoneda()
        Dim oeMoneda As New e_Moneda
        Dim olMoneda As New l_Moneda
        Dim leMoneda As New List(Of e_Moneda)
        Try
            oeMoneda.Activo = True
            leMoneda.AddRange(olMoneda.Listar(oeMoneda))
            '--------------------- para llenar combo en grilla    
            GridDocumentosVentas.DisplayLayout.ValueLists.Add("IdMoneda")
            With GridDocumentosVentas.DisplayLayout.ValueLists("IdMoneda").ValueListItems
                .Clear()
                For Each oeTD As e_Moneda In leMoneda
                    .Add(oeTD.Id, oeTD.Abreviatura)
                Next
            End With
            CrearComboGrid3("IdMoneda", "Abreviatura", GridDocumentosVentas, True)
            '--------------------- para llenar combo en grilla    
            GridAgregados.DisplayLayout.ValueLists.Add("IdMoneda")
            With GridAgregados.DisplayLayout.ValueLists("IdMoneda").ValueListItems
                .Clear()
                For Each oeTD As e_Moneda In leMoneda
                    .Add(oeTD.Id, oeTD.Abreviatura)
                Next
            End With
            CrearComboGrid3("IdMoneda", "Abreviatura", GridAgregados, True)
            '-------------------------------
            '--------------------- para llenar combo en grilla    
            GridFactoringFedd.DisplayLayout.ValueLists.Add("IdMoneda")
            With GridFactoringFedd.DisplayLayout.ValueLists("IdMoneda").ValueListItems
                .Clear()
                For Each oeTD As e_Moneda In leMoneda
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdMoneda", "Nombre", GridFactoringFedd, True)
            '-------------------------------
            With CboMoneda
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = leMoneda
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaTipoDocumento()
        Try
            Dim oeTipoDoc As New e_TipoDocumento
            Dim leTipoDoc As New List(Of e_TipoDocumento)
            Dim olTipoDoc As New l_TipoDocumento
            oeTipoDoc.Activo = True
            oeTipoDoc.TipoOperacion = "C" 'proceso contabilidad
            leTipoDoc.AddRange(olTipoDoc.Listar(oeTipoDoc))
            '--------------------- para llenar combo en grilla    
            GridDocumentosVentas.DisplayLayout.ValueLists.Add("IdTipoDocumento")
            With GridDocumentosVentas.DisplayLayout.ValueLists("IdTipoDocumento").ValueListItems
                .Clear()
                For Each oeTD As e_TipoDocumento In leTipoDoc
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdTipoDocumento", "Nombre", GridDocumentosVentas, True)
            '------------------------------------------
            '--------------------- para llenar combo en grilla    
            GridAgregados.DisplayLayout.ValueLists.Add("IdTipoDocumento")
            With GridAgregados.DisplayLayout.ValueLists("IdTipoDocumento").ValueListItems
                .Clear()
                For Each oeTD As e_TipoDocumento In leTipoDoc
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdTipoDocumento", "Nombre", GridAgregados, True)
            '------------------------------------------

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub LlenarCombos()
        Try
            LlenaCuentaBancaria()
            LlenarBanco()
            LlenaCliente()
            LlenaMoneda()
            LlenaTipoDocumento()
            LlenaTipoDocumentoFacotoryFEDD()
            CargarAsiento()
            LlenarComboMaestro(cboClienteFac, ClientesPublic, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaTipoDocumentoFacotoryFEDD()
        Try
            oeTipoDoc = New e_TipoDocumento
            oeTipoDoc.Activo = True : oeTipoDoc.TipoOperacion = "I" 'proceso contabilidad
            leTipoDoc.AddRange(olTipoDoc.Listar(oeTipoDoc).Where(Function(it) it.Abreviatura = "FEDD" Or it.Abreviatura = "FACD" Or it.Abreviatura = "FT").ToList)
            '--------------------- para llenar combo en grilla    
            GridFactoringFedd.DisplayLayout.ValueLists.Add("IdTipoDocumento")
            With GridFactoringFedd.DisplayLayout.ValueLists("IdTipoDocumento").ValueListItems
                .Clear()
                For Each oeTD As e_TipoDocumento In leTipoDoc
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdTipoDocumento", "Nombre", GridFactoringFedd, True)
            oeTipoDoc = New e_TipoDocumento
            oeTipoDoc.Nombre = "[ TODOS ]"
            leTipoDocBus.Add(oeTipoDoc)
            leTipoDocIns = leTipoDoc.Where(Function(it) it.Abreviatura = "FEDD" Or it.Abreviatura = "FT").ToList
            leTipoDocBus.AddRange(leTipoDoc)
            LlenarCombo(CboTipoObligacionListar, "Nombre", leTipoDocBus, 0)
            LlenarCombo(CboTipo, "Nombre", leTipoDocIns, -1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub LlenaCliente()
        Dim oeCliente As e_Cliente
        Dim leCliente As List(Of e_Cliente)
        Dim olCliente As l_Cliente
        Try
            oeCliente = New e_Cliente
            leCliente = New List(Of e_Cliente)
            olCliente = New l_Cliente

            oeCliente.Activo = True

            leCliente.AddRange(olCliente.Listar(oeCliente))
            '--------------------- para llenar combo en grilla gridventas   
            GridDocumentosVentas.DisplayLayout.ValueLists.Add("IdClienteProveedor")
            With GridDocumentosVentas.DisplayLayout.ValueLists("IdClienteProveedor").ValueListItems
                .Clear()
                For Each oeTD As e_Cliente In leCliente
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdClienteProveedor", "Nombre", GridDocumentosVentas, True)
            '--------------------------------------

            '--------------------- para llenar combo en grilla gridventas   
            GridAgregados.DisplayLayout.ValueLists.Add("IdClienteProveedor")
            With GridAgregados.DisplayLayout.ValueLists("IdClienteProveedor").ValueListItems
                .Clear()
                For Each oeTD As e_Cliente In leCliente
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdClienteProveedor", "Nombre", GridAgregados, True)
            '--------------------------------------

        Catch ex As Exception
            Throw ex
        Finally
            oeCliente = Nothing
            leCliente = Nothing
            olCliente = Nothing
        End Try
    End Sub

    Private Sub CargarAsiento()
        'Cargar Asiento Modelo Referencia
        oeReferencia = New e_AsientoModelo_Referencia
        oeReferencia.TipoOperacion = "N" : oeReferencia.Activo = True : oeReferencia.IdReferencia = pIdActividadNegocio
        leReferencia = olReferencia.Listar(oeReferencia)
        'Cargar DT Referencia
        DTReferencia = GeneraDTRef(leReferencia)
    End Sub

    Private Sub AgregarDetalle()
        Try
            'If CboTipo.Text = gTOFactoring AndAlso GridAgregados.Rows.Count > 0 Then Throw New Exception("Solo Puede Ingresar una Factura")
            If GridDocumentosVentas.Rows.Count > 0 AndAlso Not GridDocumentosVentas.ActiveRow Is Nothing Then
                oeMovimientoDocumento = New e_MovimientoDocumento
                oeMovimientoDocumento = GridDocumentosVentas.ActiveRow.ListObject : oeMovimientoDocumento.TipoOperacion = "I"
                If txt_Glosa.Text = "" Then txt_Glosa.Text = oeMovimientoDocumento._NombreClienteProveedor
                If ValidarAgregarDetalle() Then
                    With leMovDocAgregado
                        If Not .Contains(oeMovimientoDocumento) Then
                            .Add(oeMovimientoDocumento.Clonar)
                        Else
                            Throw New Exception("Ya existe este documento asociado")
                        End If
                    End With
                    GridAgregados.DataSource = leMovDocAgregado : GridAgregados.DataBind()
                    mostrar_totales()
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub mostrar_totales()
        Try
            Dim _MontoAux As Double = 0
            importeMN = 0 : importeME = 0
            For Each oeMovimientoDocumento As e_MovimientoDocumento In leMovDocAgregado
                _MontoAux = 0
                With oeMovimientoDocumento
                    _MontoAux = IIf(chkFactoring.Checked, .Saldo, .Total)
                    importeMN = IIf(.IdMoneda = "1CH01", importeMN + _MontoAux, importeMN + _MontoAux * DecTC.Value)
                    importeME = IIf(.IdMoneda = "1CH01", importeME + _MontoAux / DecTC.Value, importeME + _MontoAux)
                End With
            Next
            importeME = Math.Round(importeME, 4) : importeMN = Math.Round(importeMN, 4)
            decImporteSol.Value = importeMN : decImporteDol.Value = importeME
            If CboTipo.Text = "FEDD" Then DecSubTotal.Value = leMovDocAgregado.Sum(Function(it) it.Total)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mostrar_totalesFactoring()
        Try
            Dim importe As Double = 0, Monto As Double = 0
            For Each obj In leObligacionFin
                importe = importe + obj.MontoCapital : Monto = Monto + (obj.MontoInteres + obj.Gastos + obj.Comision)
            Next
            DecSubTotal.Value = importe : DecInteresMonto.Value = Monto
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function ValidarAgregarDetalle() As Boolean
        Try
            ValidarGrilla(GridDocumentosVentas, "Documentos")
            If Not GridDocumentosVentas.ActiveRow Is Nothing AndAlso GridDocumentosVentas.ActiveRow.Cells("Id").Value.ToString = "" Then Throw New Exception("Seleccione una fila")

            l_FuncionesGenerales.ValidarNumero(DecTC.Value, "Tipo de Cambio")
            If oeMovimientoDocumento.Saldo < 0 Then Throw New Exception("Este documento no se puede agregar, porque el saldo es negativo")

            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Sub QuitarDetalle()
        Try
            If GridAgregados.Rows.Count <= 0 Then Throw New Exception("Seleccione una fila")
            ValidarGrilla(GridAgregados, "Documentos x Rendir agregados")
            If GridAgregados.ActiveRow Is Nothing Then Throw New Exception("Seleccione una fila")
            If Not GridAgregados.ActiveRow.ListObject Is Nothing AndAlso GridAgregados.ActiveRow.Cells("Id").Value.ToString = "" Then Throw New Exception("Seleccione una fila")
            'inicialializo mi objeto
            oeMovimientoDocumento = New e_MovimientoDocumento
            '---Obtengo O CAPTURO objeto de la grilla 
            oeMovimientoDocumento = GridAgregados.ActiveRow.ListObject
            '----------------------
            With leMovDocAgregado
                '-----remuevo o elimino de mi lista de objetos
                .Remove(oeMovimientoDocumento)
                '-------------------
            End With
            GridAgregados.DataBind()
            mostrar_totales()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Private Sub QuitarDetalleFactoring()
        Try
            If GridFactoring.Rows.Count <= 0 Then Throw New Exception("Seleccione una fila")
            ValidarGrilla(GridFactoring, "Documentos x Rendir agregados")
            If GridFactoring.ActiveRow Is Nothing Then Throw New Exception("Seleccione una fila")
            If Not GridFactoring.ActiveRow.ListObject Is Nothing AndAlso GridFactoring.ActiveRow.Cells("Monto").Value.ToString = "" Then Throw New Exception("Seleccione una fila")
            'inicialializo mi objeto
            oeFactoring = New e_ObligacionAyudaDetalle
            '---Obtengo O CAPTURO objeto de la grilla 
            oeFactoring = GridFactoring.ActiveRow.ListObject
            '----------------------
            With leFactoringAgregado
                '-----remuevo o elimino de mi lista de objetos
                .Remove(oeFactoring)
                '-------------------
            End With
            GridAgregados.DataBind()
            mostrar_totalesFactoring()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Private Function ValidarAgregarDetalleFactoring() As Boolean
        Try
            l_FuncionesGenerales.ValidarNumeroDecimal(DecTC.Value, "Tipo de Cambio")
            l_FuncionesGenerales.ValidarNumeroDecimal(DecTotalFactoring.Value, "Factoring")
            If chkFactoring.Checked = False Then
                l_FuncionesGenerales.ValidarNumeroDecimal(DecTasaInteresFactoring.Value, "Tasa de interes")
                l_FuncionesGenerales.ValidarNumeroDecimal(DecMontoInteresFactoring.Value, "Monto de Interes")
            End If
            If Date.Parse(FecFecha.Value).Date > Date.Parse(FecVencimientoFactoring.Value).Date Then Throw New Exception("La fecha de emision es mayor a la fecha de vencimiento de la obligacion")
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Function ObtenerObliDoc(leDoc As List(Of e_MovimientoDocumento)) As List(Of e_ObligacionDocumento)
        Try
            Dim _leObliDocAux As New List(Of e_ObligacionDocumento)
            For Each oeDoc In leDoc
                Dim oeObliDoc As New e_ObligacionDocumento
                oeObliDoc.TipoOperacion = "I"
                oeObliDoc.IdCuentaxCyP = String.Empty
                oeObliDoc.IdMovimientoDocumento = oeDoc.Id
                oeObliDoc.MontoMN = IIf(CboMoneda.Text = "SOLES", oeDoc.Total, oeDoc.Total * DecTC.Value)
                oeObliDoc.MontoME = IIf(CboMoneda.Text = "SOLES", oeDoc.Total / DecTC.Value, oeDoc.Total)
                oeObliDoc.UsuarioCreacion = gUsuarioSGI.Id
                _leObliDocAux.Add(oeObliDoc)
            Next
            Return _leObliDocAux
        Catch ex As Exception
            Throw
        End Try
    End Function

#End Region

#Region "Eventos"

    Private Sub frm_FactoryFEDD_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            ControlBoton(1, 0, 0, 1, 1, 0, 0, 0, 0)
        Else
            ControlBoton(1, 1, 0, 0, 0, 1, 0, 1, 1)
        End If
    End Sub

    Private Sub frm_Factoring_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            GridDocumentosVentas.DataSource = leMovDoc
            GridAgregados.DataSource = leMovDocAgregado
            GridFactoring.DataSource = leObligacionFin
            LlenarCombos()
            Dim _leAuxTO = leTipoDocBus.Where(Function(it) it.Nombre = gTOFactDesc).ToList
            If _leAuxTO.Count > 0 Then _idFactDesc = _leAuxTO(0).Id
            ControlBoton(0, 1, 0, 0, 0, 1, 0, 1, 1)
            FecDesde.Value = DateAdd(DateInterval.Day, -30, Date.Now)
            FecHasta.Value = Date.Now.Date
            CboTipo.Text = "FACTORING"
            MostrarTabs(0, tcFactoringFedd)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_factoring_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub GridDocumentos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridDocumentosVentas.DoubleClick
        AgregarDetalle()
    End Sub

    Private Sub QuitarDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarDocumento.Click
        QuitarDetalle()
    End Sub

    Private Sub AgregarDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarDocumento.Click
        AgregarDetalle()
    End Sub

    Private Sub FecFecha_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles FecFecha.Validated
        Try
            DecTC.Value = TipoCambio(FecFecha.Value)(0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    'Private Sub DtFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecFecha.ValueChanged
    '    oeObligacion.FechaEmision = FecFecha.Value
    'End Sub

    'Private Sub CboBanco_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboBanco.ValueChanged
    '    oeObligacion.IdEmpresaBanco = CboBanco.Value
    '    oeObligacion._NombreBanco = CboBanco.Text
    'End Sub

    Private Sub CboTipoMoneda_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboMoneda.ValueChanged
        Try
            If CboMoneda.SelectedIndex > -1 Then
                If CboBanco.SelectedIndex = -1 Then Throw New Exception("Seleccione Entidad Bancaria")
                DecSubTotal.Value = IIf(CboMoneda.Value = "SOLES", decImporteSol.Value, decImporteDol.Value)
                Dim _leCtaAux = leCtaBancaria.Where(Function(it) it.IdMoneda = CboMoneda.Value).ToList
                LlenarCombo(CboCtaBancaria, "BancoCuenta", _leCtaAux, -1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            If CboBanco.SelectedIndex = -1 Then CboMoneda.SelectedIndex = -1 : CboBanco.Focus()
        End Try
        
    End Sub

    'Private Sub DtVencimiento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecVencimiento.ValueChanged
    '    oeObligacion.FechaVencimiento = FecVencimiento.Value
    'End Sub

    Private Sub NumCalc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumCalc.ValueChanged
        DecTasaInt.Value = NumCalc.Text
    End Sub

    Private Sub DecTasaInt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecTasaInt.ValueChanged
        'oeObligacion.TasaInteres = DecTasaInt.Value
        DecInteresMonto.Value = CalculoInteres(FecFecha.Value, FecVencimiento.Value, DecTasaInt.Value, DecSubTotal.Value)
    End Sub

    Private Sub DecInteresMonto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecInteresMonto.ValueChanged
        'oeObligacion.MontoInteresTes = DecInteresMonto.Value
        DecTotalPagar.Value = Math.Round(DecInteresMonto.Value + DecSubTotal.Value, 4)
    End Sub

    Private Sub DecTC_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DecTC.ValueChanged
        ' oeObligacion.TipoCambio = DecTC.Value
        mostrar_totales()
    End Sub

    'Private Sub txt_Glosa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Glosa.ValueChanged
    '    oeObligacion.Glosa = txt_Glosa.Text
    'End Sub

    'Private Sub TxtUnico_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtUnico.ValueChanged
    '    oeObligacion.Codigo = TxtUnico.Text
    'End Sub

    Private Sub DecSubTotal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecSubTotal.ValueChanged
        DecInteresMonto.Value = DecSubTotal.Value * DecTasaInt.Value / 100
        DecTotalPagar.Text = DecInteresMonto.Value + DecSubTotal.Value + DecComisionFactoring.Value + DecGastosFactoring.Value
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        QuitarDetalleFactoring()
    End Sub

    Private Sub CboTipo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboTipo.ValueChanged
        If CboTipo.Text = "FACTORING" Then
            DecComisionFactoring.Enabled = True : DecSubTotal.Enabled = False : FecVencimiento.Enabled = False
            DecComisionFactoring.Value = 0 : SplitContainer2.Panel2.Enabled = True : DecTasaInt.Enabled = False
            NumCalc.Enabled = False : DecInteresMonto.Enabled = False : TxtUnico.Enabled = False
            chkFactoring.Enabled = False : TxtUnico.Text = String.Empty : FecFecha.Focus()
        Else
            If leFactoringAgregado.Count > 0 Then
                If MessageBox.Show("Estas seguro de cambiar de Tipo de Obligacion", "Mensaje del sistema", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    DecComisionFactoring.Enabled = False : DecSubTotal.Enabled = True : FecVencimiento.Enabled = True
                    DecComisionFactoring.Value = 0 : SplitContainer2.Panel2.Enabled = False : chkFactoring.Enabled = False
                    leFactoringAgregado.Clear() : GridFactoring.DataBind()
                Else
                    CboTipo.Text = "FACTORING"
                End If
            Else
                DecComisionFactoring.Enabled = False : DecSubTotal.Enabled = True : FecVencimiento.Enabled = True
                DecComisionFactoring.Value = 0 : SplitContainer2.Panel2.Enabled = False : chkFactoring.Checked = False
                DecTasaInt.Enabled = True : NumCalc.Enabled = True : DecInteresMonto.Enabled = True
                TxtUnico.Enabled = True : chkFactoring.Enabled = False
                leFactoringAgregado.Clear() : GridFactoring.DataBind()
            End If
        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            If leObligacionFin.Count > 1 Then Throw New Exception("Solo puede Ingresar un Registro de Factoring")
            If DecTC.Value = 0 Then Throw New Exception("Ingrese Tipo Cambio")
            ValidarCombo(CboBanco, "Banco")
            ValidarCombo(CboMoneda, "Moneda")
            If chkFactoring.Checked = False Then ValidarCombo(CboCtaBancaria, "Cuenta Bancaria")
            If txtCodigoBancoFactoring.Text = "" Then Throw New Exception("Ingrese Codido de Factoring")
            If Date.Parse(FecFecha.Value).Date > Date.Parse(FecVencimientoFactoring.Value).Date Then
                Throw New Exception("La fecha de emision es mayor a la fecha de vencimiento de la obligacion")
            End If
            If DecTasaInteresFactoring.Value = 0 Then Throw New Exception("Ingrese Tasa de Inteses")
            If DecMontoInteresFactoring.Value = 0 Then Throw New Exception("Ingrese Importe de Interes")
            leObligacionFin = New List(Of e_ObligacionFin)
            oeObligacionFin = New e_ObligacionFin
            With oeObligacionFin
                .TipoOperacion = "I"
                .NroVencimiento = String.Empty
                .FechaVencimiento = FecVencimientoFactoring.Value
                .MontoCapital = DecTotalFactoring.Value
                .MontoMN = IIf(CboMoneda.Text = "SOLES", DecTotalFactoring.Value, DecTotalFactoring.Value * DecTC.Value)
                .MontoME = IIf(CboMoneda.Text = "SOLES", DecTotalFactoring.Value / DecTC.Value, DecTotalFactoring.Value)
                .MontoInteres = DecMontoInteresFactoring.Value
                .Comision = DecComisionFactoring.Value
                .Gastos = DecGastosFactoring.Value
                .Saldo = .MontoCapital + .MontoInteres + .Comision + .Gastos
                .Usuario = gUsuarioSGI.Id
            End With
            leObligacionFin.Add(oeObligacionFin)
            GridFactoring.DataSource = leObligacionFin
            GridFactoring.DataBind()
            mostrar_totalesFactoring()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            If DecTC.Value = 0 Then DecTC.Focus() : Exit Sub
            If CboBanco.SelectedIndex = -1 Then CboBanco.Focus() : Exit Sub
            If CboMoneda.SelectedIndex = -1 Then CboMoneda.Focus() : Exit Sub
            If CboCtaBancaria.SelectedIndex = -1 Then CboCtaBancaria.Focus() : Exit Sub
            If txtCodigoBancoFactoring.Text = "" Then txtCodigoBancoFactoring.Focus() : Exit Sub
            If Date.Parse(FecFecha.Value).Date > Date.Parse(FecVencimientoFactoring.Value).Date Then
                FecVencimientoFactoring.Focus() : Exit Sub
            End If
            If DecTasaInteresFactoring.Value = 0 Then DecTasaInteresFactoring.Focus() : Exit Sub
            If DecMontoInteresFactoring.Value = 0 Then DecMontoInteresFactoring.Focus() : Exit Sub
        End Try
    End Sub

    Private Sub CboCtaBancaria_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCtaBancaria.ValueChanged
        'oeObligacion.IdCuentaBancaria = CboCtaBancaria.Value
        Dim i As Integer = CboCtaBancaria.SelectedIndex
        If i >= 0 Then
            oeCuentaBancaria = New e_CuentaBancaria
            oeCuentaBancaria = CboCtaBancaria.Items(i).ListObject
        End If
    End Sub

    Private Sub CboTipoObligacionListar_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboTipoObligacionListar.ValueChanged
        CboTipo.Text = CboTipoObligacionListar.Text
    End Sub

    Private Sub DecTasaInteresFactoring_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles DecTasaInteresFactoring.Validated
        DecMontoInteresFactoring.Value = DecTasaInteresFactoring.Value * DecTotalFactoring.Value / 100
    End Sub

    Private Sub DecTotalFactoring_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecTotalFactoring.ValueChanged
        lblTotalFactoring.Text = DecTotalFactoring.Value + DecMontoInteresFactoring.Value + DecComisionFactoring.Value + DecGastosFactoring.Value
    End Sub

    Private Sub DecMontoInteresFactoring_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecMontoInteresFactoring.ValueChanged
        lblTotalFactoring.Text = DecTotalFactoring.Value + DecMontoInteresFactoring.Value + DecComisionFactoring.Value + DecGastosFactoring.Value
    End Sub

    Private Sub DecComisionFactoring_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecComisionFactoring.ValueChanged
        lblTotalFactoring.Text = DecTotalFactoring.Value + DecMontoInteresFactoring.Value + DecComisionFactoring.Value + DecGastosFactoring.Value
    End Sub

    Private Sub DecGastosFactoring_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecGastosFactoring.ValueChanged
        lblTotalFactoring.Text = DecTotalFactoring.Value + DecMontoInteresFactoring.Value + DecComisionFactoring.Value + DecGastosFactoring.Value
    End Sub

    Private Sub CalcFactoring_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles CalcFactoring.Validated
        DecMontoInteresFactoring.Value = DecTasaInteresFactoring.Value * DecTotalFactoring.Value / 100
    End Sub

    Private Sub CalcFactoring_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcFactoring.ValueChanged
        DecTasaInteresFactoring.Value = CalcFactoring.Text
    End Sub

    Private Sub chkFactoring_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFactoring.CheckedChanged
        If chkFactoring.Checked Then
            GridDocumentosVentas.Text = "COMPRAS"
            leMovDocAgregado.Clear()
            GridAgregados.DataBind()
            leMovDoc.Clear()
            GridDocumentosVentas.DataBind()
        Else
            GridDocumentosVentas.Text = "VENTAS"
            leMovDocAgregado.Clear()
            GridAgregados.DataBind()
            leMovDoc.Clear()
            GridDocumentosVentas.DataBind()
        End If
    End Sub

    Private Sub DecTasaInteresFactoring_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecTasaInteresFactoring.ValueChanged
        DecMontoInteresFactoring.Value = CalculoInteres(FecFecha.Value, FecVencimientoFactoring.Value, DecTasaInteresFactoring.Value, DecTotalFactoring.Value)
    End Sub

    Private Sub btnListaDoc_Click(sender As Object, e As EventArgs) Handles btnListaDoc.Click
        Listar(True)
    End Sub

    Private Sub cboClienteFac_InitializeLayout(sender As Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboClienteFac.InitializeLayout
        Try
            With cboClienteFac.DisplayLayout.Bands(0)
                .Columns("Id").Hidden = True
                .Columns("Descripcion").Hidden = True
                .Columns("Nombre").Hidden = False
                .Columns("Nombre").Width = 350
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboClienteFac_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboClienteFac.KeyPress
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then cboClienteFac.PerformAction(UltraComboAction.Dropdown)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboClienteFac_KeyDown(sender As Object, e As KeyEventArgs) Handles cboClienteFac.KeyDown
        Try
            With CType(sender, Infragistics.Win.UltraWinGrid.UltraCombo)
                If e.KeyData = Keys.Delete Then
                    .Text = ""
                End If
            End With
            If e.KeyCode = Keys.Enter Then
                If cboClienteFac.Text.Trim = "" Then
                    cboClienteFac.DataSource = Nothing
                    cboClienteFac.DataSource = ProveedorPublic
                Else
                    cboClienteFac.DataSource = Nothing
                    ListaCliente = New List(Of e_Combo)
                    ListaCliente = ClientesPublic
                    cboClienteFac.DataSource = ListaCliente.Where(Function(Item) Item.Nombre.Contains(cboClienteFac.Text.Trim)).ToList
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

End Class
