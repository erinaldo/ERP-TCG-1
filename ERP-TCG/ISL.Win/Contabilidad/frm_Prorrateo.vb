'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_Prorrateo
    Inherits ISL.Win.frm_MenuPadre

#Region "Declaración de Variables"

    Private oeVehiculo As e_Vehiculo, olVehiculo As New l_Vehiculo, leVehiculo As List(Of e_Vehiculo), leVehAux As List(Of e_Vehiculo)
    Private oeAsientoMov As e_AsientoMovimiento, olAsientoMov As New l_AsientoMovimiento, leAsientoMov As List(Of e_AsientoMovimiento)
    Private oePeriodo As e_Periodo, olPeriodo As New l_Periodo, lePeriodo As List(Of e_Periodo)
    Private oeTipoAsiento As e_TablaContableDet, olTipoAsiento As New l_TablaContableDet, leTipoAsiento As List(Of e_TablaContableDet), leGastoFuncion As List(Of e_TablaContableDet)
    Private oeMoneda As e_Moneda, olMoneda As New l_Moneda, leMoneda As List(Of e_Moneda)
    Private oeMovAnalisis As e_MovimientoAnalisis, olMovAnalisis As New l_MovimientoAnalisis, leMovAnalisis As List(Of e_MovimientoAnalisis)
    Private ld_FechaMov As Date = #1/1/1901#
    Private ls_IdPeriodo As String = String.Empty

#End Region

#Region "Inicialización del formulario"

    Private Shared Operacion As String
    Private Shared instancia As frm_Prorrateo = Nothing
    Private var As String = ""

    Public Overrides Function getInstancia() As frm_MenuPadre
         If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Prorrateo()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            leMovAnalisis = New List(Of e_MovimientoAnalisis)
            For Each _oeVeh In leVehAux
                oeMovAnalisis = New e_MovimientoAnalisis
                With oeMovAnalisis
                    .Id = String.Empty
                    .IdCentroCosto = String.Empty
                    .IdItemGasto = String.Empty
                    .IdTrabajador = String.Empty
                    .IdVehiculo = _oeVeh.Id
                    .IdRuta = String.Empty
                    .IdBanco = String.Empty
                    .IdAnalisis1 = String.Empty
                    .IdAnalisis2 = String.Empty
                    .Activo = True
                    .IdAsientoMovimiento = txtNroAsiento.Tag
                    .Monto = decProrrateo.Value
                    .Saldo = decProrrateo.Value
                    .IdGastoFuncion = cboGastoFuncion.Value
                    .IdOrigenProrrateo = String.Empty
                    .Fecha = ld_FechaMov
                    .IdPeriodo = ls_IdPeriodo
                End With
                oeMovAnalisis.PrefijoID = gs_PrefijoIdSucursal '@0001
                leMovAnalisis.Add(oeMovAnalisis)
            Next
            If leMovAnalisis.Count = 0 Then Throw New Exception("No se Encontrado Datos para Guardar")
            If olMovAnalisis.Prorraretar(leMovAnalisis) Then
                mensajeEmergente.Confirmacion("Se registro Correctamente", True)
                Inicializar()
                BtnOrigen_Click(Nothing, Nothing)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    Public Overrides Sub Exportar()
        Try
            Throw New Exception("Esta información no puede ser exportada")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Métodos"

    Private Sub Listar()
        Try
            Me.Cursor = Cursors.WaitCursor
            ''RELACIÓN TOTAL DE VEHÍCULOS
            oeVehiculo = New e_Vehiculo : leVehiculo = New List(Of e_Vehiculo)
            oeVehiculo.Motriz = -1 : oeVehiculo.Activo = True : oeVehiculo.IdEmpresaPropietaria = ISL_IdEmpresa
            leVehiculo = olVehiculo.Listar(oeVehiculo)
            CargarVeh(leVehiculo)
            ''FINALIZA
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
            griAsientoMov.Focus()
        End Try
    End Sub

    Private Sub ComboPeriodo()
        Try
            oePeriodo = New e_Periodo : lePeriodo = New List(Of e_Periodo)
            oePeriodo.Ejercicio = Año1.Año : oePeriodo.Activo = True
            lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))
            With cboMes
                .DisplayMember = "Mes" : .ValueMember = "Id" : .DataSource = lePeriodo
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CargarCombos()
        Try
            ' Cargar Tipo Asiento
            oeTipoAsiento = New e_TablaContableDet : leTipoAsiento = New List(Of e_TablaContableDet)
            oeTipoAsiento.TipoOperacion = "N" : oeTipoAsiento.Nombre = "TIPO DE ASIENTO"
            oeTipoAsiento.Logico1 = True : oeTipoAsiento.Activo = True
            leTipoAsiento.AddRange(olTipoAsiento.Listar(oeTipoAsiento))
            With cboTipoAsiento
                .DisplayMember = "Nombre" : .ValueMember = "Id" : .DataSource = leTipoAsiento : .SelectedIndex = 0
            End With
            ' Cargar Gasto Funcion
            oeTipoAsiento = New e_TablaContableDet : leGastoFuncion = New List(Of e_TablaContableDet)
            oeTipoAsiento.TipoOperacion = "N" : oeTipoAsiento.Nombre = "GASTO FUNCION"
            oeTipoAsiento.Logico2 = 1 : oeTipoAsiento.Activo = True
            leGastoFuncion.AddRange(olTipoAsiento.Listar(oeTipoAsiento))
            With cboGastoFuncion
                .DisplayMember = "Nombre" : .ValueMember = "Id" : .DataSource = leGastoFuncion : .SelectedIndex = 0
            End With
            ' Cargar Tipo Moneda
            oeMoneda = New e_Moneda : leMoneda = New List(Of e_Moneda)
            oeMoneda.TipoOperacion = "" : oeMoneda.Activo = True
            leMoneda = olMoneda.Listar(oeMoneda)
            With cboMoneda
                .DisplayMember = "Nombre" : .ValueMember = "Id" : .DataSource = leMoneda : .SelectedIndex = 0
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarVeh(leVeh As List(Of e_Vehiculo))
        Try
            With GridVehiculoDestino
                .ResetDisplayLayout()
                .Text = String.Empty
                .DataSource = leVeh
                For Each Col In .DisplayLayout.Bands(0).Columns
                    If Col.Key = "Seleccion" Then
                        Col.CellActivation = Activation.AllowEdit
                        Col.CellClickAction = CellClickAction.Edit
                    Else
                        Col.CellActivation = Activation.NoEdit
                        Col.CellClickAction = CellClickAction.RowSelect
                    End If
                Next
                OcultarColumna(GridVehiculoDestino, True, "Id", "IdConfiguracionNeumaticos", "IdConfiguracionVehicularMTC", "IdEmpresaPropietaria", _
                               "IdFlota", "IdMarca", "IdMaterialCombustible", "IdModelo", "IdModeloFuncional", "IdTipoVehiculo", "IndActivoFijo", _
                               "IndEstado", "IndPropiedad", "IndProrrateo", "Activo", "Alto", "Ancho", "Capacidad", "CapacidadTanque", "Codigo", _
                               "Color", "ConfiguracionNeumaticos", "Cubicaje", "DescripcionDetalle", "Fecha", "Horometro", "Largo", "NroAsientos", _
                               "NroEjes", "NroEquipoMovil", "NroMTC", "NroNeumaticos", "NroNeumaticosRepuesto", "NroPasajeros", "NroSerieChasis", _
                               "NroSerieMotor", "Observacion", "Odometro", "PesoNeto", "PlacaAntigua", "Tara", "ModeloFuncional")
                FormatoColumna(GridVehiculoDestino, "", ColumnStyle.CheckBox, HAlign.Center, "Motriz")
                .DisplayLayout.Bands(0).Columns("Seleccion").Header.VisiblePosition = 0
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarAsiMov(leAsiMov As List(Of e_AsientoMovimiento))
        Try
            With griAsientoMov
                .ResetDisplayLayout()
                .Text = ""
                .DataSource = leAsiMov.OrderBy(Function(it) it.IdAsiento).ToList
                OcultarColumna(griAsientoMov, True, "Id", "Activo", "NroLinea")
                FormatoColumna(griAsientoMov, "#,##0.00", ColumnStyle.Double, HAlign.Right, "DebeMN", "DebeME", "HaberMN", "HaberME")
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("IdAsiento").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("IdCuentaContable").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("IdUsuarioCrea").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Header.Caption = "Fecha"
                .DisplayLayout.Bands(0).Columns("IdAsiento").Header.Caption = "Nro Asiento"
                .DisplayLayout.Bands(0).Columns("IdCuentaContable").Header.Caption = "Cuenta"
                .DisplayLayout.Bands(0).Columns("IdUsuarioCrea").Header.Caption = "T. M."
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Width = 70
                .DisplayLayout.Bands(0).Columns("IdAsiento").Width = 65
                .DisplayLayout.Bands(0).Columns("IdCuentaContable").Width = 65
                .DisplayLayout.Bands(0).Columns("IdUsuarioCrea").Width = 30
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
                CalcularTotales(griAsientoMov, "DebeMN", "DebeME", "HaberMN", "HaberME")
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializar()
        txtNroAsiento.Text = String.Empty
        txtNroAsiento.Tag = String.Empty
        txtCuenta.Text = String.Empty
        txtDescripcion.Text = String.Empty
        decMonto.Value = 0
        decProrrateo.Value = 0
        ld_FechaMov = #1/1/1901#
        'ls_IdPeriodo = String.Empty
    End Sub

    Private Sub ObtenerSeleccion()
        Try
            leVehAux = New List(Of e_Vehiculo)
            For Each Fil In GridVehiculoDestino.Rows.Where(Function(it) it.Cells("Seleccion").Value = True).ToList
                oeVehiculo = New e_Vehiculo
                oeVehiculo = Fil.ListObject
                leVehAux.Add(oeVehiculo)
            Next
            If leVehAux.Count = 0 Then Throw New Exception("Seleccione Un Vehiculo para prorratear")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub Año1_DatoCambiado() Handles Año1.DatoCambiado
        ComboPeriodo()
    End Sub

    Private Sub frm_Prorrateo_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(1, 0, 0, 1, 0, 0, 0, 1, 1)
    End Sub

    Private Sub frm_Prorrateo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Prorrateo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case _Operacion
            Case "Nuevo"
                Me.Activate()
                Me.Cancelar()

            Case "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_Prorrateo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ComboPeriodo()
            cboMes.Text = Date.Now.Month.ToString
            CargarVeh(New List(Of e_Vehiculo))
            CargarAsiMov(New List(Of e_AsientoMovimiento))
            CargarCombos()
            Inicializar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub GridVehiculoOrigen_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griAsientoMov.CellChange
        Try
            griAsientoMov.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub GridVehiculoDestino_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles GridVehiculoDestino.CellChange
        Try
            GridVehiculoDestino.UpdateData()
            etiCantidad.Text = GridVehiculoDestino.Rows.Where(Function(it) it.Cells("Seleccion").Value = True).ToList.Count
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub BtnOrigen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOrigen.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If oePeriodo.Id = String.Empty Then Throw New Exception("Seleccione Periodo a Prorratear")
            oeAsientoMov = New e_AsientoMovimiento : leAsientoMov = New List(Of e_AsientoMovimiento)
            oeAsientoMov.TipoOperacion = "P"
            oeAsientoMov.Glosa = Año1.Año
            ls_IdPeriodo = oePeriodo.Id
            oeAsientoMov.Id = ls_IdPeriodo
            oeAsientoMov.IdAsiento = cboTipoAsiento.Value
            oeAsientoMov.IdCuentaContable = cboMoneda.Value
            leAsientoMov = olAsientoMov.Listar(oeAsientoMov)
            CargarAsiMov(leAsientoMov)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub BtnDestino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDestino.Click
        Try
            For Each Fil In GridVehiculoDestino.Rows.Where(Function(it) it.IsFilteredOut = False And it.Cells("Seleccion").Value = False).ToList
                Fil.Cells("Seleccion").Value = True
            Next
            GridVehiculoDestino.UpdateData()
            etiCantidad.Text = GridVehiculoDestino.Rows.Where(Function(it) it.Cells("Seleccion").Value = True).ToList.Count
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnDesMarcar_Click(sender As Object, e As EventArgs) Handles btnDesMarcar.Click
        Try
            For Each Fil In GridVehiculoDestino.Rows.Where(Function(it) it.IsFilteredOut = False And it.Cells("Seleccion").Value = True).ToList
                Fil.Cells("Seleccion").Value = False
            Next
            GridVehiculoDestino.UpdateData()
            etiCantidad.Text = GridVehiculoDestino.Rows.Where(Function(it) it.Cells("Seleccion").Value = True).ToList.Count
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboMes_ValueChanged(sender As Object, e As EventArgs) Handles cboMes.ValueChanged
        Try
            If cboMes.SelectedIndex > -1 Then
                oePeriodo = New e_Periodo
                oePeriodo = cboMes.SelectedItem.ListObject
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griAsientoMov_DoubleClick(sender As Object, e As EventArgs) Handles griAsientoMov.DoubleClick
        Try
            If griAsientoMov.Selected.Rows.Count > 0 AndAlso griAsientoMov.ActiveRow.Index > -1 Then
                Dim _band As Boolean, _montodebe As Double = 0, _montohaber As Double = 0
                If txtNroAsiento.Tag.trim <> String.Empty Then
                    If txtNroAsiento.Tag.trim <> griAsientoMov.ActiveRow.Cells("Id").Value Then
                        If MessageBox.Show("Hay Datos Cargados para Prorratear." & Environment.NewLine & "¿Desea Reemplazarlo los Datos?", _
                                   "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            _band = True
                        End If
                    End If
                Else
                    _band = True
                End If
                If _band Then
                    ObtenerSeleccion()
                    Inicializar()
                    txtNroAsiento.Tag = griAsientoMov.ActiveRow.Cells("Id").Value
                    txtNroAsiento.Text = griAsientoMov.ActiveRow.Cells("IdAsiento").Value
                    txtCuenta.Text = griAsientoMov.ActiveRow.Cells("IdCuentaContable").Value
                    txtDescripcion.Text = griAsientoMov.ActiveRow.Cells("Glosa").Value
                    ld_FechaMov = griAsientoMov.ActiveRow.Cells("FechaCreacion").Value
                    If griAsientoMov.ActiveRow.Cells("IdUsuarioCrea").Value = "S/" Then
                        _montodebe = griAsientoMov.ActiveRow.Cells("DebeMN").Value
                        _montohaber = griAsientoMov.ActiveRow.Cells("HaberMN").Value
                        decMonto.Value = IIf(_montodebe > _montohaber, _montodebe, _montohaber)
                    Else
                        _montodebe = griAsientoMov.ActiveRow.Cells("DebeME").Value
                        _montohaber = griAsientoMov.ActiveRow.Cells("HaberME").Value
                        decMonto.Value = IIf(_montodebe > _montohaber, _montodebe, _montohaber)
                    End If
                    decProrrateo.Value = Math.Round(decMonto.Value / leVehAux.Count, 4)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

End Class