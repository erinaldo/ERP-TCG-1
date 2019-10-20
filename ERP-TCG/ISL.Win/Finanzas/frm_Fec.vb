'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win.UltraWinGrid
Public Class frm_Fec
    Inherits ISL.Win.frm_MenuPadre

#Region "Declaracion De Variables"

    ' Private oeFec As New e_ObligacionFinanciera, olFec As New l_ObligacionFinanciera
    Private leTipoObli As New List(Of e_ObligacionFinanciera)
    Private WithEvents oeMovimientoDocumento As New e_MovimientoDocumento
    Private olMovimientoDocumento As New l_MovimientoDocumento
    Private leMovDoc As New List(Of e_MovimientoDocumento)
    Private leMovDocAgregado As New List(Of e_MovimientoDocumento)
    Private leBanco As New List(Of e_Proveedor)
    Private leTipoDoc As New List(Of e_TipoDocumento)
    Private leProveedor As New List(Of e_Proveedor)
    Private leMoneda As New List(Of e_Moneda)
    Private oeAsientoModel As New e_AsientoModelo, olAsientoModel As New l_AsientoModelo, leAsientoModel As New List(Of e_AsientoModelo)
    Private oeContratoFin As New e_ContratoFinanciero, olContratoFin As New l_ContratoFinanciero
    Private oeObligacionFin As New e_ObligacionFin, leObligacionFin As New List(Of e_ObligacionFin)
    Private oePeriodo As New e_Periodo, olPeriodo As New l_Periodo
    Private dsFec As DataSet, relationContratoObligFin As DataRelation
    Dim ListaProveedor As New List(Of e_Combo)
    Private IdCtaCtble As String, NombreProveedor As String = String.Empty

#End Region

#Region "Instancia"

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Shared instancia As frm_Fec = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Fec()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            ListaFec()
            If GrDocumentos.Rows.Count > 0 Then
                ControlBoton(1, 1, 0, 0, 0, 1, 0, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
            End If
            Operacion = ""
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            Operacion = "Nuevo"
            MostrarTabs(1, tcFec)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            inicializar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        'Try
        '    ValidarGrilla(gridCobranza, "Cobranza")
        '    If Not gridCobranza.ActiveRow Is Nothing AndAlso gridCobranza.ActiveRow.Cells("Id").Value.ToString <> "" Then
        '        Inicializar()
        '        'Mostrar()
        '        oeMovimientoDocumento.TipoOperacion = "A"
        '        oeMovimientoDocumento.Venta.TipoOperacion = "A"
        '        oeMovimientoDocumento.Modificado = False
        '        MyBase.Editar()
        '    Else
        '        Throw New Exception("Seleccione una Fila!")
        '    End If

        'Catch ex As Exception
        '    mensajeEmergente.Problema(ex.Message)
        'End Try

    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarFEC() Then
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
                MostrarTabs(0, tcFec, 1)
                Operacion = ""
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try

            'Consultar(True) 'activa desactiva botonera
            MostrarTabs(0, tcFec, 0)
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            Operacion = ""
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally

        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            'With GrDocumentos
            '    ValidarGrilla(GrDocumentos, "Obligacion")
            '    If Not .ActiveRow Is Nothing AndAlso .ActiveRow.Cells("Id").Value.ToString <> "" Then
            '        oeFec.Id = .ActiveRow.Cells("Id").Value
            '        oeFec = olFec.Obtener(oeFec)
            '        If oeFec.Activo Then
            '            If MessageBox.Show("Esta seguro de eliminar la Obligacion: " & _
            '                 .ActiveRow.Cells("Codigo").Value.ToString & " ?", "Mensaje del Sistema", _
            '                 MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            '                oeFec.TipoOperacion = "X"
            '                oeFec.Codigo = "FEC"
            '                olFec.Eliminar(oeFec)
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

            If GrDocumentos.Rows.Count = 0 Then Throw New Exception("No hay ningún dato de Fec para exportar al Excel")
            Exportar_Excel(GrDocumentos)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Function GuardarFEC() As Boolean
        Try
            IdCtaCtble = String.Empty
            l_FuncionesGenerales.ValidarNumero(decMontoSoles.Value, "Los importes Nuevos Soles son cero")
            l_FuncionesGenerales.ValidarNumero(decMontoDolar.Value, "Los importes Dólares son cero")
            l_FuncionesGenerales.ValidarCampoNoNulo(TxtUnico.Text, "Ingrese el Código único de FEC")
            l_FuncionesGenerales.ValidarNumero(DecInteresMonto.Value, "Monto Interés")
            l_FuncionesGenerales.ValidarNumero(DecTasaInt.Value, "Tasa Interés")
            ValidarCombo(CboBanco, "Banco")
            ValidarCombo(CboMoneda, "Moneda")
            For Each obj As e_MovimientoDocumento In leMovDocAgregado
                If (obj.Saldo > 0 And obj.MontoOperar < 0) Or (obj.Saldo < 0 And obj.MontoOperar > 0) Then
                    Throw New Exception("los signos de la columna saldo y monto agregado no son iguales")
                End If
                If obj.MontoOperar = 0 Then Throw New Exception("El monto a cancelar es cero")
            Next
            ' Obtener Asiento por Moneda
            oeAsientoModel = New e_AsientoModelo
            oeAsientoModel.Equivale = 1 : oeAsientoModel.IdMoneda = CboMoneda.Value
            If leAsientoModel.Contains(oeAsientoModel) Then
                oeAsientoModel = leAsientoModel.Item(leAsientoModel.IndexOf(oeAsientoModel))
                oeAsientoModel.TipoOperacion = ""
                oeAsientoModel.Ejercicio = CDate(FecFecha.Value).Year
                oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                If oeAsientoModel.leDetalle.Count > 0 Then
                    Dim _leDetAux = oeAsientoModel.leDetalle.Where(Function(it) it.Cuenta.Contains(gCCTOFecFeddCredHipo)).ToList
                    If _leDetAux.Count > 0 Then IdCtaCtble = _leDetAux(0).IdCuentaContable
                End If
            Else
                Throw New Exception("No Existe Configuracion Contable")
            End If
            'Obtener Periodo
            oePeriodo = New e_Periodo
            oePeriodo = ObtenerPeriodo(CDate(FecFecha.Value))
            oeContratoFin.IdPeriodo = oePeriodo.Id
            'Obtener Obligacion Fin
            leObligacionFin = New List(Of e_ObligacionFin)
            oeObligacionFin.NroVencimiento = TxtUnico.Text
            oeObligacionFin.FechaVencimiento = FecVencimiento.Value
            oeObligacionFin.MontoMN = decMontoSoles.Value
            oeObligacionFin.MontoME = decMontoDolar.Value
            oeObligacionFin.MontoInteres = DecInteresMonto.Value
            oeObligacionFin.IdCuentaContable = IdCtaCtble
            oeObligacionFin.MontoCapital = IIf(CboMoneda.Text = "SOLES", decMontoSoles.Value, decMontoDolar.Value)
            oeObligacionFin.Saldo = oeObligacionFin.MontoCapital + oeObligacionFin.MontoInteres
            oeObligacionFin.PrefijoID = gs_PrefijoIdSucursal '@0001
            leObligacionFin.Add(oeObligacionFin)
            'Obtener datos a contrato
            oeContratoFin.Codigo = TxtUnico.Text
            oeContratoFin.FechaEmision = FecFecha.Value
            oeContratoFin.FechaVencimiento = FecVencimiento.Value
            oeContratoFin.MontoMN = decMontoSoles.Value
            oeContratoFin.MontoME = decMontoDolar.Value
            oeContratoFin.TasaInteres = DecTasaInt.Value
            oeContratoFin.Capital = leObligacionFin.Sum(Function(it) it.MontoCapital)
            oeContratoFin.IdEmpresaBanco = CboBanco.Value
            oeContratoFin.Glosa = txt_Glosa.Text
            oeContratoFin.IdMoneda = CboMoneda.Value
            oeContratoFin.NroCuotas = leObligacionFin.Count
            oeContratoFin.TipoCambio = DecTC.Value
            oeContratoFin.Usuario = gUsuarioSGI.Id
            oeContratoFin.MacLocal = MacPCLocal()
            oeContratoFin.lstObligacionesFin = leObligacionFin
            oeContratoFin.leDocumentos = leMovDocAgregado
            'oeContratoFin.leDocLetra = ObtineCobros(lstMovDocumentoLetra, leObligacionFin)
            oeContratoFin.IdClienteProveedor = leMovDocAgregado(0).IdClienteProveedor
            oeContratoFin.NombreBanco = CboBanco.Text
            oeContratoFin.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olContratoFin.GuardarFec(oeContratoFin, oeAsientoModel) Then
                mensajeEmergente.Confirmacion("Registrado correctamente", True)
                'LimpiarDatos()
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub LlenaBanco()
        Try
            If leBanco.Count = 0 Then

                Dim oeProveedor As New e_Proveedor
                Dim olProveedor As New l_Proveedor
                oeProveedor.Activo = True
                oeProveedor.TipoOperacion = "4"

                leBanco.AddRange(olProveedor.Listar(oeProveedor))
                '--------------------- para llenar combo en grilla gridventas   
                GrDocumentos.DisplayLayout.ValueLists.Add("IdEmpresaBanco")
                With GrDocumentos.DisplayLayout.ValueLists("IdEmpresaBanco").ValueListItems
                    .Clear()
                    For Each oeTD As e_Proveedor In leBanco
                        .Add(oeTD.Id, oeTD.Nombre)
                    Next
                End With
                CrearComboGrid3("IdEmpresaBanco", "Nombre", GrDocumentos, True)
                '--------------------------------------
                With CboBanco
                    .ValueMember = "Id"
                    .DisplayMember = "Nombre"
                    .DataSource = leBanco
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaTipoDocumento()
        If leTipoDoc.Count = 0 Then
            Dim oeTipoDoc As New e_TipoDocumento
            Dim olTipoDoc As New l_TipoDocumento
            Try
                oeTipoDoc.Activo = True
                oeTipoDoc.TipoOperacion = "C" 'proceso contabilidad
                leTipoDoc.AddRange(olTipoDoc.Listar(oeTipoDoc))
                '--------------------- para llenar combo en grilla    
                gridDocumentosxPagar.DisplayLayout.ValueLists.Add("IdTipoDocumento")
                With gridDocumentosxPagar.DisplayLayout.ValueLists("IdTipoDocumento").ValueListItems
                    .Clear()
                    For Each oeTD As e_TipoDocumento In leTipoDoc
                        .Add(oeTD.Id, oeTD.Nombre)
                    Next
                End With
                CrearComboGrid3("IdTipoDocumento", "Nombre", gridDocumentosxPagar, True)
                '------------------------------------------
                '--------------------- para llenar combo en grilla    
                gridDocumentosAgregados.DisplayLayout.ValueLists.Add("IdTipoDocumento")
                With gridDocumentosAgregados.DisplayLayout.ValueLists("IdTipoDocumento").ValueListItems
                    .Clear()
                    For Each oeTD As e_TipoDocumento In leTipoDoc
                        .Add(oeTD.Id, oeTD.Nombre)
                    Next
                End With
                CrearComboGrid3("IdTipoDocumento", "Nombre", gridDocumentosAgregados, True)
                '------------------------------------------

            Catch ex As Exception
                mensajeEmergente.Problema(ex.Message, True)
            Finally
                oeTipoDoc = Nothing
                leTipoDoc = Nothing
                olTipoDoc = Nothing
            End Try
        End If

    End Sub

    Private Sub ComboMoneda()
        Try
            If leMoneda.Count = 0 Then
                Dim oeMoneda As New e_Moneda
                Dim olMoneda As New l_Moneda

                oeMoneda.Activo = True
                leMoneda.AddRange(olMoneda.Listar(oeMoneda))
                '--------------------- para llenar combo en grilla    
                gridDocumentosxPagar.DisplayLayout.ValueLists.Add("IdMoneda")
                With gridDocumentosxPagar.DisplayLayout.ValueLists("IdMoneda").ValueListItems
                    .Clear()
                    For Each oeTD As e_Moneda In leMoneda
                        .Add(oeTD.Id, oeTD.Abreviatura)
                    Next
                End With
                CrearComboGrid3("IdMoneda", "Abreviatura", gridDocumentosxPagar, True)
                '------------------------------------------
                '--------------------- para llenar combo en grilla    
                gridDocumentosAgregados.DisplayLayout.ValueLists.Add("IdMoneda")
                With gridDocumentosAgregados.DisplayLayout.ValueLists("IdMoneda").ValueListItems
                    .Clear()
                    For Each oeTD As e_Moneda In leMoneda
                        .Add(oeTD.Id, oeTD.Abreviatura)
                    Next
                End With
                CrearComboGrid3("IdMoneda", "Abreviatura", gridDocumentosAgregados, True)
                '------------------------------------------
                '--------------------- para llenar combo en grilla    
                GrDocumentos.DisplayLayout.ValueLists.Add("IdMoneda")
                With GrDocumentos.DisplayLayout.ValueLists("IdMoneda").ValueListItems
                    .Clear()
                    For Each oeTD As e_Moneda In leMoneda
                        .Add(oeTD.Id, oeTD.Abreviatura)
                    Next
                End With
                CrearComboGrid3("IdMoneda", "Abreviatura", GrDocumentos, True)
                '------------------------------------------

                With CboMoneda
                    .DisplayMember = "Nombre"
                    .ValueMember = "Id"
                    .DataSource = leMoneda
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboProveedor()
        Try
            If leProveedor.Count = 0 Then
                Dim oeProveedor As New e_Proveedor
                Dim olProveedor As New l_Proveedor
                oeProveedor.Activo = True
                leProveedor.AddRange(olProveedor.Listar(oeProveedor))
                '--------------------- para llenar combo en grilla    
                gridDocumentosxPagar.DisplayLayout.ValueLists.Add("IdClienteProveedor")
                With gridDocumentosxPagar.DisplayLayout.ValueLists("IdClienteProveedor").ValueListItems
                    .Clear()
                    For Each oeTD As e_Proveedor In leProveedor
                        .Add(oeTD.Id, oeTD.Nombre)
                    Next
                End With
                CrearComboGrid3("IdClienteProveedor", "Nombre", gridDocumentosxPagar, True)
                '------------------------------------------
                '--------------------- para llenar combo en grilla    
                gridDocumentosAgregados.DisplayLayout.ValueLists.Add("IdClienteProveedor")
                With gridDocumentosAgregados.DisplayLayout.ValueLists("IdClienteProveedor").ValueListItems
                    .Clear()
                    For Each oeTD As e_Proveedor In leProveedor
                        .Add(oeTD.Id, oeTD.Nombre)
                    Next
                End With
                CrearComboGrid3("IdClienteProveedor", "Nombre", gridDocumentosAgregados, True)
                '------------------------------------------
                '--------------------- para llenar combo en grilla    
                'With cboProveedor
                '    .ValueMember = "Id"
                '    .DisplayMember = "Nombre"
                '    .DataSource = leProveedor
                'End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarCombos()
        Try
            LlenaTipoDocumento()
            LlenaBanco()
            ComboMoneda()
            LlenarComboMaestro(cboProveedorFactura, ProveedorPublic, 0)
            ComboProveedor()
            CargarAsiento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub inicializar()
        Try
            oeContratoFin = New e_ContratoFinanciero
            oeContratoFin.TipoOperacion = "I" : oeContratoFin.Activo = True
            oeContratoFin.IdTipoDocumento = "1CH000000065"
            oeObligacionFin = New e_ObligacionFin
            oeObligacionFin.TipoOperacion = "I"
            leObligacionFin = New List(Of e_ObligacionFin)
            TxtUnico.Text = String.Empty
            CboBanco.SelectedIndex = -1
            CboMoneda.SelectedIndex = -1
            FecFecha.Value = Date.Now.Date
            FecVencimiento.Value = Date.Now.Date
            DecTC.Value = TipoCambio(FecFecha.Value, False)(0)
            txt_Glosa.Text = String.Empty
            LimpiarGrillaAgregados()
            DecTasaInt.Value = 0
            DecInteresMonto.Value = 0
            LblTotalPagar.Text = 0.0
            leMovDoc = New List(Of e_MovimientoDocumento)
            gridDocumentosxPagar.DataSource = leMovDoc
            txtRuc.Text = String.Empty
            NombreProveedor = String.Empty
            TxtUnico.Focus()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ListaFacturas(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            If gridDocumentosAgregados.Rows.Count > 0 Then
                If MessageBox.Show("Existen Documentos agregados, desea eliminarlos", "Mensaje del Sistema", _
               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
               = Windows.Forms.DialogResult.Yes Then
                    LimpiarGrillaAgregados()
                Else
                    Exit Sub
                End If
            Else
                LimpiarGrillaAgregados()
            End If
            If Trim(cboProveedorFactura.Value) = "" Then Throw New Exception("Seleccione un Proveedor válido")
            If Len(Trim(cboProveedorFactura.Value)) <> 12 Then Throw New Exception("Seleccione un Proveedor válido")
            If CboMoneda.SelectedIndex = -1 Then Throw New Exception("Seleccione Moneda")
            Me.Cursor = Cursors.WaitCursor
            leMovDoc = New List(Of e_MovimientoDocumento)
            oeMovimientoDocumento = New e_MovimientoDocumento
            With oeMovimientoDocumento
                .Activo = Activo
                .TipoOperacion = "FEC"
                .IdPeriodo = ""
                .IdMoneda = CboMoneda.Value
                .Ejercicio = Date.Parse(FecFecha.Value).Year
                ._Operador = 1
                .IdClienteProveedor = cboProveedorFactura.Value
            End With
            leMovDoc.AddRange(olMovimientoDocumento.Listar(oeMovimientoDocumento))
            gridDocumentosxPagar.DataSource = leMovDoc
            gridDocumentosxPagar.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
            leMovDoc = Nothing
        End Try
        gridDocumentosxPagar.Focus()
        If CboMoneda.SelectedIndex = -1 Then CboMoneda.Focus()
    End Sub

    Private Sub LimpiarGrillaAgregados()
        leMovDocAgregado = New List(Of e_MovimientoDocumento)
        gridDocumentosAgregados.DataSource = leMovDocAgregado
        gridDocumentosAgregados.DataBind()
        decMontoSoles.Value = 0
        decMontoDolar.Value = 0
        DecSubTotal.Value = 0
    End Sub

    Private Sub ListaFec()
        Try
            Cursor.Current = Cursors.WaitCursor

            oeContratoFin = New e_ContratoFinanciero
            oeContratoFin.TipoOperacion = "B"
            oeContratoFin.Activo = True
            ValidarFechaDesde_Hasta(fecInicio, fecFin)
            oeContratoFin.FechaEmision = fecInicio.Value
            oeContratoFin.FechaVencimiento = fecFin.Value
            dsFec = olContratoFin.ListarDS(oeContratoFin)

            ''''''''''''''''''''''''''''''''''''''''''''''
            'Tabla(0) CONTRATOS
            'Tabla(1) OBLIGACIONES
            ''''''''''''''''''''''''''''''''''''''''''''''
            Dim IdContrato As DataColumn = dsFec.Tables(0).Columns("Id")
            Dim IdObligFin As DataColumn = dsFec.Tables(1).Columns("IdContratoFinanciero")
            relationContratoObligFin = New DataRelation("FK_Relacion", IdContrato, IdObligFin, False)
            dsFec.Relations.Add(relationContratoObligFin)
            dsFec.AcceptChanges()
            GrDocumentos.DataSource = dsFec
            With GrDocumentos.DisplayLayout
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
            GrDocumentos.DataBind()
        End Try
    End Sub

    Private Sub AgregarDetalle()
        Try
            If gridDocumentosxPagar.Rows.Count > 0 AndAlso Not gridDocumentosxPagar.ActiveRow.ListObject Is Nothing Then
                oeMovimientoDocumento = New e_MovimientoDocumento
                oeMovimientoDocumento = gridDocumentosxPagar.ActiveRow.ListObject
                oeMovimientoDocumento.TipoOperacion = "I"
                oeMovimientoDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
                If ValidarAgregarDetalle() Then
                    With leMovDocAgregado
                        If Not .Contains(oeMovimientoDocumento) Then
                            NombreProveedor = cboProveedorFactura.Text
                            .Add(oeMovimientoDocumento.Clonar)
                        Else
                            Throw New Exception("Ya existe este documento asociado")
                        End If
                    End With
                    gridDocumentosAgregados.DataSource = leMovDocAgregado
                    gridDocumentosAgregados.DataBind()
                    mostrar_totales()
                    If NombreProveedor.Length > 0 Then txt_Glosa.Text = "FEC " & NombreProveedor
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub mostrar_totales()
        Try
            Dim importeMN As Double = 0, importeME As Double = 0
            For Each oeMovimientoDocumento As e_MovimientoDocumento In leMovDocAgregado
                With oeMovimientoDocumento
                    importeMN = IIf(.IdMoneda = "1CH01", importeMN + .MontoOperar, importeMN + .MontoOperar * DecTC.Value)
                    importeME = IIf(.IdMoneda = "1CH01", importeME + .MontoOperar / DecTC.Value, importeME + .MontoOperar)
                End With
            Next
            importeME = Math.Round(importeME, 4) : importeMN = Math.Round(importeMN, 4)
            decMontoSoles.Value = importeMN : decMontoDolar.Value = importeME
            DecSubTotal.Value = IIf(CboMoneda.Text = "SOLES", decMontoSoles.Value, decMontoDolar.Value)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ValidarAgregarDetalle() As Boolean
        Try
            ValidarGrilla(gridDocumentosxPagar, "Documentos x Pagar")
            If Not gridDocumentosxPagar.ActiveRow Is Nothing AndAlso gridDocumentosxPagar.ActiveRow.Cells("Id").Value.ToString = "" Then Throw New Exception("Seleccione una fila")
            l_FuncionesGenerales.ValidarNumero(DecTC.Value, "Tipo de Cambio")
            If oeMovimientoDocumento.FechaEmision.Date > FecFecha.Value Then Throw New Exception("La fecha del documento es mayor a la fecha de la obligacion")
            If oeMovimientoDocumento.Saldo < 0 Then Throw New Exception("Este documento no se puede agregar, porque el saldo es negativo")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub QuitarDetalle()
        Try
            If gridDocumentosAgregados.Rows.Count <= 0 Then Throw New Exception("Seleccione una fila")
            ValidarGrilla(gridDocumentosAgregados, "Obligaciones agregadas")
            If gridDocumentosAgregados.ActiveRow Is Nothing Then Throw New Exception("Seleccione una fila")
            If Not gridDocumentosAgregados.ActiveRow.ListObject Is Nothing AndAlso gridDocumentosAgregados.ActiveRow.Cells("Id").Value.ToString = "" Then Throw New Exception("Seleccione una fila")
            oeMovimientoDocumento = New e_MovimientoDocumento
            oeMovimientoDocumento = gridDocumentosAgregados.ActiveRow.ListObject
            leMovDocAgregado.Remove(oeMovimientoDocumento)
            gridDocumentosAgregados.DataBind()
            mostrar_totales()
            If gridDocumentosAgregados.Rows.Count = 0 Then txt_Glosa.Text = String.Empty : NombreProveedor = String.Empty
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CargarAsiento()
        oeAsientoModel = New e_AsientoModelo
        oeAsientoModel.TipoOperacion = "A" : oeAsientoModel.Activo = True : oeAsientoModel.Nombre = pIdActividadNegocio
        leAsientoModel = olAsientoModel.Listar(oeAsientoModel)
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Fec_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        Else
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
        End If
    End Sub

    Private Sub frm_Fec_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Fec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ' GrDocumentos.DataSource = leTipoObli
            gridDocumentosxPagar.DataSource = leMovDoc
            gridDocumentosAgregados.DataSource = leMovDocAgregado
            LlenarCombos()
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
            fecInicio.Value = DateAdd(DateInterval.Day, -30, Date.Now)
            FecFecha.Value = Date.Now.Date
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub FecFecha_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles FecFecha.Validated
        Try
            DecTC.Value = TipoCambio(FecFecha.Value)(0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    'Private Sub DtFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecFecha.ValueChanged
    '    'oeFec.FechaEmision = FecFecha.Value
    'End Sub

    'Private Sub CboBanco_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboBanco.ValueChanged
    '    'oeFec.IdEmpresaBanco = CboBanco.Value
    '    'oeFec._NombreBanco = CboBanco.Text
    'End Sub

    Private Sub CboTipoMoneda_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboMoneda.ValueChanged
        'oeFec.IdMoneda = CboMoneda.Value
        DecSubTotal.Value = IIf(CboMoneda.Text = "SOLES", decMontoSoles.Value, decMontoDolar.Value)
    End Sub

    'Private Sub DtVencimiento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecVencimiento.ValueChanged
    '    ' oeFec.FechaVencimiento = FecVencimiento.Value
    'End Sub

    Private Sub gridDocumentosxPagar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridDocumentosxPagar.DoubleClick
        Try
            AgregarDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub gridDocumentosAgregados_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles gridDocumentosAgregados.CellChange
        Try
            l_FuncionesGenerales.ValidarNumero(DecTC.Value, "Tipo de Cambio")
            If IsNumeric(e.Cell.Value) Then
                Dim obj As New e_MovimientoDocumento
                obj = gridDocumentosxPagar.ActiveRow.ListObject
                If obj.Saldo < CDbl(e.Cell.Value) Then
                    gridDocumentosAgregados.UpdateData()
                    Throw New Exception("El monto ingresado es mayor al saldo")
                End If
                gridDocumentosAgregados.UpdateData()
                mostrar_totales()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub AgregarDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarDocumento.Click
        Try
            AgregarDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub QuitarDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarDocumento.Click
        QuitarDetalle()
    End Sub

    Private Sub DecTC_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DecTC.ValueChanged
        Try
            If DecTC.Value > 0 Then mostrar_totales()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub DecTasaInt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecTasaInt.ValueChanged
        'oeFec.TasaInteres = DecTasaInt.Value
        DecInteresMonto.Value = CalculoInteres(FecFecha.Value, FecVencimiento.Value, DecTasaInt.Value, DecSubTotal.Value)
    End Sub

    Private Sub DecInteresMonto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecInteresMonto.ValueChanged
        ' oeFec.MontoInteresTes = DecInteresMonto.Value
        LblTotalPagar.Text = Math.Round(DecInteresMonto.Value + DecSubTotal.Value, 4)
    End Sub

    ' Private Sub LblTotalPagar_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LblTotalPagar.TextChanged
    'If CboMoneda.Value = "1CH01" Then 'SOLES
    '    oeFec.MontoMN = DecInteresMonto.Value + DecSubTotal.Value
    '    oeFec._MontoMNSinInteres = DecSubTotal.Value
    '    oeFec.MontoME = (DecInteresMonto.Value + DecSubTotal.Value) / DecTC.Value
    '    oeFec._MontoMESinInteres = DecSubTotal.Value / DecTC.Value
    'Else
    '    oeFec.MontoMN = DecInteresMonto.Value + DecSubTotal.Value * DecTC.Value
    '    oeFec._MontoMNSinInteres = DecSubTotal.Value * DecTC.Value
    '    oeFec.MontoME = DecInteresMonto.Value + DecSubTotal.Value
    '    oeFec._MontoMESinInteres = DecSubTotal.Value
    'End If
    'oeFec.Saldo = DecInteresMonto.Value + DecSubTotal.Value
    'End Sub

    'Private Sub txt_Glosa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Glosa.ValueChanged
    '    'oeFec.Glosa = txt_Glosa.Text
    'End Sub

    'Private Sub TxtUnico_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtUnico.ValueChanged
    '    'oeFec.Codigo = TxtUnico.Text
    'End Sub

    Private Sub DecSubTotal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecSubTotal.ValueChanged
        DecInteresMonto.Value = CalculoInteres(FecFecha.Value, FecVencimiento.Value, DecTasaInt.Value, DecSubTotal.Value)
        LblTotalPagar.Text = Math.Round(DecInteresMonto.Value + DecSubTotal.Value, 4)
    End Sub

    Private Sub NumCalc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumCalc.ValueChanged
        DecTasaInt.Value = NumCalc.Text
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        ListaFacturas(True)
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

#End Region

End Class





