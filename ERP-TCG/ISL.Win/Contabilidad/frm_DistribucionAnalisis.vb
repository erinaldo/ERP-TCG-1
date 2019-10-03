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

Public Class frm_DistribucionAnalisis
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_DistribucionAnalisis = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_DistribucionAnalisis()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oeAsientoMov As e_AsientoMovimiento, olAsientoMov As l_AsientoMovimiento, leAsientoMov As List(Of e_AsientoMovimiento)
    Private oePeriodo As e_Periodo, olPeriodo As l_Periodo, leEjercicio As List(Of e_Periodo), lePeriodo As List(Of e_Periodo)
    Private oeTipoAsiento As e_TablaContableDet, olTipoAsiento As l_TablaContableDet, leTipoAsiento As List(Of e_TablaContableDet)
    Private oeAnalisis As e_MovimientoAnalisis, olAnalisis As l_MovimientoAnalisis, leAnalisis As List(Of e_MovimientoAnalisis)
    Private oeAuxiliar As e_MovimientoAnalisis, leAuxiliar As List(Of e_MovimientoAnalisis)
    Private oeMoneda As e_Moneda, olMoneda As l_Moneda, leMoneda As List(Of e_Moneda)
    Private oeTrabajador As e_Trabajador, olTrabajador As l_Trabajador, leTrabajador As List(Of e_Trabajador)
    Private oeAsiento As e_Asiento, olAsiento As l_Asiento
    Private oeAMDReferencia As e_DetalleModelo_Referencia, olAMDReferencia As l_DetalleModelo_Referencia, leAMDReferencia As List(Of e_DetalleModelo_Referencia)
    Private oePlanilla As e_Planilla, olPlanilla As l_Planilla
    Private oeMovCajaBanco As e_MovimientoCajaBanco, olMovCajaBanco As l_MovimientoCajaBanco, leMovCajaBanco As List(Of e_MovimientoCajaBanco)
    Private oeCuentaBancaria As e_CuentaBancaria, olCuentaBancaria As l_CuentaBancaria, leCuentaBancaria As List(Of e_CuentaBancaria)
    Private lePlanTrabajador As List(Of e_DetalleConcepto)
    Private lb_Load As Boolean, lb_Importar As Boolean
    Private ln_NroAnalisis As Integer = 0

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(Activo As Boolean)
        Try
            oeAsientoMov = New e_AsientoMovimiento : leAsientoMov = New List(Of e_AsientoMovimiento)
            oeAsientoMov.TipoOperacion = "D"
            oeAsientoMov.Glosa = cboEjercicio.Value
            oeAsientoMov.Id = cboPeriodo.Value
            oeAsientoMov.IdAsiento = cboTipoAsiento.Value
            oeAsientoMov.IdCuentaContable = cboTipoMoneda.Value
            leAsientoMov = olAsientoMov.Listar(oeAsientoMov)
            mt_CargarDist(leAsientoMov)
            If griDistribucion.Rows.Count > 0 Then ControlBoton(1, 0, 1, 0, 0, 0, 0, 1, 1) Else ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            If griDistribucion.Selected.Rows.Count = 0 Then Throw New Exception("¡Seleccione un Registro!")
            If griDistribucion.ActiveRow.Index = -1 Then Throw New Exception("¡Seleccione un Registro!")
            mt_Inicializar()
            oeAsientoMov = New e_AsientoMovimiento
            oeAsientoMov.Id = griDistribucion.ActiveRow.Cells("Id").Value
            oeAsientoMov = olAsientoMov.Obtener2(oeAsientoMov)
            txtNroAsiento.Text = oeAsientoMov.IdAsiento
            txtNroLinea.Text = oeAsientoMov.NroLinea
            txtGlosa.Text = oeAsientoMov.Glosa
            decDebe.Value = IIf(oeAsientoMov.IdUsuarioCrea.Trim = "S/", oeAsientoMov.DebeMN, oeAsientoMov.DebeME)
            decHaber.Value = IIf(oeAsientoMov.IdUsuarioCrea.Trim = "S/", oeAsientoMov.HaberMN, oeAsientoMov.HaberME)
            leAnalisis = oeAsientoMov.MovimientoAnalisis
            Dim _nro As Integer = 0
            For Each _oeDet In leAnalisis
                _nro = _nro + 1
                _oeDet.NroFila = _nro
            Next
            ln_NroAnalisis = _nro
            mt_CargarAna(leAnalisis)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            MostrarTabs(1, ficDistribucion, 1)
            If griAnalisis.Rows.Count > 0 Then mt_ControlSubBoton(1, 1, 0, 0, 1, 0) Else mt_ControlSubBoton(1, 0, 0, 0, 0, 1)
            MostrarTabs(0, ficAnalisis, 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If leAnalisis.Count > 0 Then
                If olAnalisis.GuardarLista(leAnalisis) Then
                    mensajeEmergente.Confirmacion("Se guardo correctamente los datos", True)
                    MostrarTabs(0, ficDistribucion, 0)
                    Consultar(True)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If MessageBox.Show("¿Desea Cancelar la Operacion?", "Mensaje de Sistema", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                MostrarTabs(0, ficDistribucion, 0)
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            Select Case ficDistribucion.SelectedTab.Index
                Case 0
                    If griDistribucion.Rows.Count = 0 Then Throw New Exception("¡No Hay datos para Exportar!")
                    Exportar_Excel(griDistribucion)
                Case 1
                    If griDetalle.Rows.Count = 0 Then Throw New Exception("¡No Hay datos para Exportar!")
                    Exportar_Excel(griDetalle)
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_DistribucionAnalisis_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_DistribucionAnalisis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mt_InicializarLogicas()
            mt_CargarIconos()
            mt_CargarCombos()
            lb_Load = True
            mt_CargarDist(New List(Of e_AsientoMovimiento))
            mt_CargarAna(New List(Of e_MovimientoAnalisis))
            mt_CargarDC(New List(Of e_MovimientoAnalisis))
            lb_Load = False
            MostrarTabs(0, ficDistribucion, 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboEjercicio_ValueChanged(sender As Object, e As EventArgs) Handles cboEjercicio.ValueChanged
        Try
            If cboEjercicio.SelectedIndex > -1 Then
                oePeriodo = cboEjercicio.SelectedItem.ListObject
                LlenarCombo(cboPeriodo, "NomMes", lePeriodo.Where(Function(it) it.Ejercicio = oePeriodo.Ejercicio).OrderByDescending(Function(it) it.Mes).ToList, 0)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDistribucion_DoubleClick(sender As Object, e As EventArgs) Handles griDistribucion.DoubleClick
        Editar()
    End Sub

    Private Sub utmAnalisis_ToolClick(sender As Object, e As UltraWinToolbars.ToolClickEventArgs) Handles utmAnalisis.ToolClick
        Try
            Select Case e.Tool.Key
                Case "Agregar"
                    oeAnalisis = New e_MovimientoAnalisis
                    oeAnalisis.TipoOperacion = "I" : oeAnalisis.Activo = True
                    oeAnalisis.IdAsientoMovimiento = oeAsientoMov.Id
                    oeAnalisis.NroFila = ln_NroAnalisis + 1
                    oeAnalisis.PrefijoID = gs_PrefijoIdSucursal '@0001
                    mt_InicializarAnalisis()
                    cboTrabajador.Focus()
                    mt_ControlSubBoton(0, 0, 1, 1, 0, 0)
                    MostrarTabs(1, ficAnalisis, 1)
                Case "Editar"
                    mt_EditarAnalisis()
                Case "Grabar"
                    If lb_Importar Then
                        If leAuxiliar.Count > 0 Then
                            leAnalisis.AddRange(leAuxiliar)
                            ln_NroAnalisis = leAnalisis.Max(Function(it) it.NroFila)
                            mt_CargarAna(leAnalisis)
                            griAnalisis.DataBind()
                            If griAnalisis.Rows.Count > 0 Then mt_ControlSubBoton(1, 1, 0, 0, 1, 0) Else mt_ControlSubBoton(1, 0, 0, 0, 0, 1)
                            MostrarTabs(0, ficAnalisis, 0)
                            mt_CargarDC(New List(Of e_MovimientoAnalisis))
                            MessageBox.Show("¡Los Datos de Guardaron Correctamente!", "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            Throw New Exception("¡No hay Datos para Importar!")
                        End If
                    Else
                        oeAnalisis.IdTrabajador = cboTrabajador.Value
                        oeAnalisis.Trabajador = cboTrabajador.Text.Trim
                        oeAnalisis.Monto = decMonto.Value
                        oeAnalisis.PrefijoID = gs_PrefijoIdSucursal '@0001
                        If oeAnalisis.TipoOperacion = "I" Then
                            leAnalisis.Add(oeAnalisis)
                            ln_NroAnalisis = ln_NroAnalisis + 1
                        Else
                            If oeAnalisis.Id.Trim.Length > 0 Then
                                oeAnalisis.TipoOperacion = "A"
                            Else
                                oeAnalisis.TipoOperacion = "I" : oeAnalisis.IdUsuarioCrea = gUsuarioSGI.Id
                            End If
                        End If
                        mt_CargarAna(leAnalisis)
                        griAnalisis.DataBind()
                        If griAnalisis.Rows.Count > 0 Then mt_ControlSubBoton(1, 1, 0, 0, 1, 0) Else mt_ControlSubBoton(1, 0, 0, 0, 0, 1)
                        MostrarTabs(0, ficAnalisis, 0)
                        MessageBox.Show("¡Los Datos de Guardaron Correctamente!", "Mensaje de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Case "Cancelar"
                    If MessageBox.Show("¿Desea Cancelar la Operacion?", "Mensaje de Sistema", _
                              MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        mt_CargarAna(leAnalisis)
                        griAnalisis.DataBind()
                        If griAnalisis.Rows.Count > 0 Then mt_ControlSubBoton(1, 1, 0, 0, 1, 0) Else mt_ControlSubBoton(1, 0, 0, 0, 0, 1)
                        MostrarTabs(0, ficAnalisis, 0)
                    End If
                Case "Quitar"
                    If griAnalisis.Selected.Rows.Count = 0 Then Throw New Exception("¡Seleccione un Registro!")
                    If griAnalisis.ActiveRow.Index = -1 Then Throw New Exception("¡Seleccione un Registro!")
                    If MessageBox.Show("¿Desea Eliminar Todos los Registros (SI) o Solo el registro seleccionado (NO)?", "Mensaje de Sistema", _
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    Else
                        oeAnalisis = New e_MovimientoAnalisis
                        Dim _oeAux = griAnalisis.ActiveRow.ListObject()
                        oeAnalisis.NroFila = _oeAux.NroFila
                        oeAnalisis.Equivale = 1
                        If leAnalisis.Contains(oeAnalisis) Then
                            oeAnalisis = leAnalisis.Item(leAnalisis.IndexOf(oeAnalisis))
                            If oeAnalisis.Id.Trim.Length > 0 Then
                                oeAnalisis.TipoOperacion = "E" : oeAnalisis.Activo = False
                            Else
                                oeAnalisis.Equivale = 1
                                leAnalisis.Remove(oeAnalisis)
                            End If
                        End If
                        mt_CargarAna(leAnalisis)
                        griAnalisis.DataBind()
                        If griAnalisis.Rows.Count > 0 Then mt_ControlSubBoton(1, 1, 0, 0, 1, 0) Else mt_ControlSubBoton(1, 0, 0, 0, 0, 1)
                    End If
                Case "Exportar"
                    If cboTipo.SelectedIndex = -1 Then Throw New Exception("¡Seleccione un Tipo para Importar!")
                    mt_ControlSubBoton(0, 0, 1, 1, 0, 0)
                    MostrarTabs(1, ficAnalisis, 1)
                    Select Case cboTipo.SelectedIndex
                        Case 0
                            mt_DatoPlanillaProv()
                        Case 1
                            mt_DatoPlanillaPago()
                    End Select
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub mt_InicializarLogicas()
        olAsientoMov = New l_AsientoMovimiento
        olPeriodo = New l_Periodo
        olTipoAsiento = New l_TablaContableDet
        olMoneda = New l_Moneda
        olTrabajador = New l_Trabajador
        olAsiento = New l_Asiento
        olAMDReferencia = New l_DetalleModelo_Referencia
        olPlanilla = New l_Planilla
        olAnalisis = New l_MovimientoAnalisis
        olMovCajaBanco = New l_MovimientoCajaBanco
        olCuentaBancaria = New l_CuentaBancaria
    End Sub

    Private Sub mt_CargarIconos()
        Try
            For Each Item In gLstIconos
                Select Case Item.Nombre
                    Case "Agregar"
                        utmAnalisis.Tools("Agregar").SharedProps.AppearancesSmall.Appearance.Image = Item.Icono
                    Case "Modificar"
                        utmAnalisis.Tools("Editar").SharedProps.AppearancesSmall.Appearance.Image = Item.Icono
                    Case "Grabar"
                        utmAnalisis.Tools("Grabar").SharedProps.AppearancesSmall.Appearance.Image = Item.Icono
                    Case "Cancelar"
                        utmAnalisis.Tools("Cancelar").SharedProps.AppearancesSmall.Appearance.Image = Item.Icono
                    Case "Quitar"
                        utmAnalisis.Tools("Quitar").SharedProps.AppearancesSmall.Appearance.Image = Item.Icono
                    Case "Buscar"
                        utmAnalisis.Tools("Exportar").SharedProps.AppearancesSmall.Appearance.Image = Item.Icono
                End Select
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarCombos()
        Try
            ' Cargar Tipo Importacion
            cboTipo.Items.Clear()
            cboTipo.Items.Add("PLANILLA HABERES PROVISION")
            cboTipo.Items.Add("PLANILLA HABERES PAGO")
            cboTipo.SelectedIndex = -1
            'cboTipo.Items.Add("PLANILLA HABERES PROVISION")
            ' Cargar Periodo
            oePeriodo = New e_Periodo : lePeriodo = New List(Of e_Periodo)
            oePeriodo.TipoOperacion = "" : oePeriodo.Ejercicio = 0
            lePeriodo = olPeriodo.Listar(oePeriodo)
            oePeriodo = New e_Periodo : leEjercicio = New List(Of e_Periodo)
            oePeriodo.TipoOperacion = "E"
            leEjercicio = olPeriodo.Listar(oePeriodo)
            LlenarCombo(cboEjercicio, "Ejercicio", leEjercicio, 0)
            ' Cargar Tipo Asiento
            oeTipoAsiento = New e_TablaContableDet : leTipoAsiento = New List(Of e_TablaContableDet)
            oeTipoAsiento.TipoOperacion = "N" : oeTipoAsiento.Nombre = "TIPO DE ASIENTO"
            oeTipoAsiento.Logico1 = True : oeTipoAsiento.Activo = True
            leTipoAsiento = olTipoAsiento.Listar(oeTipoAsiento)
            LlenarCombo(cboTipoAsiento, "Nombre", leTipoAsiento, 0)
            ' Cargar Tipo Mondea
            oeMoneda = New e_Moneda : leMoneda = New List(Of e_Moneda)
            oeMoneda.TipoOperacion = "" : oeMoneda.Activo = True
            leMoneda = olMoneda.Listar(oeMoneda)
            LlenarCombo(cboTipoMoneda, "Nombre", leMoneda, 0)
            ' Cargar Trabajador
            oeTrabajador = New e_Trabajador : leTrabajador = New List(Of e_Trabajador)
            oeTrabajador.TipoOperacion = "N"
            leTrabajador = olTrabajador.Listar(oeTrabajador)
            Dim _leTrabAux = (From le In leTrabajador _
                                Select le.Id, le.oePersona.NombreCompleto, le.oePersona.Dni, le.Activo, le.IndEstado
                                Where Activo = True
                                Order By NombreCompleto)
            LlenarCombo(cboTrabajador, "NombreCompleto", _leTrabAux.ToList, -1)
            ' Cargar Cuentas Bancarias
            oeCuentaBancaria = New e_CuentaBancaria
            oeCuentaBancaria.TipoOperacion = "" : oeCuentaBancaria.Activo = True
            leCuentaBancaria = olCuentaBancaria.Listar(oeCuentaBancaria)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Inicializar()
        txtNroAsiento.Text = String.Empty
        txtNroLinea.Text = String.Empty
        txtGlosa.Text = String.Empty
        decDebe.Value = 0
        decHaber.Value = 0
        cboTipo.SelectedIndex = -1
        ln_NroAnalisis = 0
        End Sub

    Private Sub mt_InicializarAnalisis()
        cboTrabajador.SelectedIndex = -1
        decMonto.Value = 0
        lb_Importar = False
    End Sub

    Private Sub mt_CargarDist(ByVal leDist As List(Of e_AsientoMovimiento))
        Try
            If lb_Load Then griDistribucion.ResetDisplayLayout()
            griDistribucion.DataSource = leDist
            griDistribucion.Text = "REGISTRO DE DISTRIBUCION"
            If lb_Load Then
                ConfiguraGrilla(griDistribucion, "Tahoma", True, UIElementBorderStyle.Default)
                OcultarColumna2(griDistribucion, False, "FechaCreacion", "IdAsiento", "NroLinea", "IdCuentaContable", "Glosa", "IdUsuarioCrea", "DebeMN", "HaberMN", "DebeME", "HaberME")
                griDistribucion.DisplayLayout.Bands(0).Columns("IdAsiento").Width = 100
                griDistribucion.DisplayLayout.Bands(0).Columns("IdCuentaContable").Width = 80
                griDistribucion.DisplayLayout.Bands(0).Columns("Glosa").Width = 350
                griDistribucion.DisplayLayout.Bands(0).Columns("IdUsuarioCrea").Width = 40
                griDistribucion.DisplayLayout.Bands(0).Columns("IdAsiento").Header.Caption = "Nro Asiento"
                griDistribucion.DisplayLayout.Bands(0).Columns("IdCuentaContable").Header.Caption = "Cuenta"
                griDistribucion.DisplayLayout.Bands(0).Columns("IdUsuarioCrea").Header.Caption = "T.M."
                griDistribucion.DisplayLayout.Bands(0).Columns("FechaCreacion").Header.Caption = "Fecha"
                FormatoColumna(griDistribucion, "#,##0.00", UltraWinGrid.ColumnStyle.Double, HAlign.Right, "DebeMN", "HaberMN", "DebeME", "HaberME")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarAna(ByVal leAna As List(Of e_MovimientoAnalisis))
        Try
            If lb_Load Then griAnalisis.ResetDisplayLayout()
            griAnalisis.DataSource = leAna.Where(Function(it) it.Activo = True).ToList
            If lb_Load Then
                ConfiguraGrilla(griAnalisis, "Tahoma", True, UIElementBorderStyle.Default)
                OcultarColumna2(griAnalisis, False, "Trabajador", "Monto")
                griAnalisis.DisplayLayout.Bands(0).Columns("Trabajador").Width = 450
                FormatoColumna(griAnalisis, "#,##0.00", UltraWinGrid.ColumnStyle.Double, HAlign.Right, "Monto")
                CalcularTotales(griAnalisis, "Monto")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarDC(ByVal leDC As List(Of e_MovimientoAnalisis))
        Try
            If lb_Load Then griDetalle.ResetDisplayLayout()
            griDetalle.DataSource = leDC
            If lb_Load Then
                ConfiguraGrilla(griDetalle, "Tahoma", True, UIElementBorderStyle.Default)
                OcultarColumna2(griDetalle, False, "Trabajador", "Monto")
                griDetalle.DisplayLayout.Bands(0).Columns("Trabajador").Width = 450
                FormatoColumna(griDetalle, "#,##0.00", UltraWinGrid.ColumnStyle.Double, HAlign.Right, "Monto")
                CalcularTotales(griDetalle, "Monto")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_ControlSubBoton(lb_Agregar As Boolean, lb_Modificar As Boolean, lb_Grabar As Boolean, lb_Cancelar As Boolean, lb_Quitar As Boolean, lb_Exportar As Boolean)
        Try
            utmAnalisis.Tools("Agregar").SharedProps.Enabled = lb_Agregar
            utmAnalisis.Tools("Editar").SharedProps.Enabled = lb_Modificar
            utmAnalisis.Tools("Grabar").SharedProps.Enabled = lb_Grabar
            utmAnalisis.Tools("Cancelar").SharedProps.Enabled = lb_Cancelar
            utmAnalisis.Tools("Quitar").SharedProps.Enabled = lb_Quitar
            utmAnalisis.Tools("Exportar").SharedProps.Enabled = lb_Exportar
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_EditarAnalisis()
        Try
            If griAnalisis.Selected.Rows.Count = 0 Then Throw New Exception("¡Seleccione un Registro!")
            If griAnalisis.ActiveRow.Index = -1 Then Throw New Exception("¡Seleccione un Registro!")
            mt_InicializarAnalisis()
            oeAnalisis = New e_MovimientoAnalisis
            oeAnalisis = griAnalisis.ActiveRow.ListObject
            oeAnalisis.TipoOperacion = "A"
            cboTrabajador.Value = oeAnalisis.IdTrabajador
            decMonto.Value = oeAnalisis.Monto
            decMonto.Focus()
            mt_ControlSubBoton(0, 0, 1, 1, 0, 1)
            MostrarTabs(1, ficAnalisis, 1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_DatoPlanillaProv()
        Try
            ' Obtener Asiento
            oeAsiento = New e_Asiento
            oeAsiento.TipoOperacion = "A" : oeAsiento.Glosa = oeAsientoMov.Id
            oeAsiento = olAsiento.Obtener2(oeAsiento)
            If oeAsiento.IdentificaAsiento = "1CH000000057" Then
                ' Obetener Asiento Modelo Detalle Referencia
                oeAMDReferencia = New e_DetalleModelo_Referencia
                oeAMDReferencia.TipoOperacion = "A" : oeAMDReferencia.Observacion = "1CH000000057"
                leAMDReferencia = olAMDReferencia.Listar(oeAMDReferencia)
                ' Obtener Planilla
                oePlanilla = New e_Planilla
                oePlanilla.IndCargaCompleto = True : oePlanilla.IdPeriodo = oeAsiento.IdPeriodo
                oePlanilla = olPlanilla.Obtener(oePlanilla)
                ' Mostrar Informacion
                Dim _nroAux As Integer = 0
                _nroAux = ln_NroAnalisis
                leAuxiliar = New List(Of e_MovimientoAnalisis)
                For Each _oeDet In leAMDReferencia.Where(Function(it) it.Cuenta.Trim = oeAsientoMov.IdCuentaContable.Trim And it.TipoReferencia = 13).ToList
                    For Each _oePDC In oePlanilla.leDetalleConcepto.Where(Function(it) it.IdAporteDescuento = _oeDet.IdReferencia).ToList
                        oeAnalisis = New e_MovimientoAnalisis
                        oeAnalisis.TipoOperacion = "I"
                        oeAnalisis.IdTrabajador = _oePDC.IdTrabajador
                        oeAnalisis.Trabajador = _oePDC.Trabajador
                        oeAnalisis.Saldo = _oePDC.Importe
                        oeAnalisis.Monto = _oePDC.Importe
                        oeAnalisis.IdUsuarioCrea = gUsuarioSGI.Id
                        oeAnalisis.IdAsientoMovimiento = oeAsientoMov.Id
                        _nroAux = _nroAux + 1
                        oeAnalisis.NroFila = _nroAux
                        oeAnalisis.Activo = True
                        oeAnalisis.PrefijoID = gs_PrefijoIdSucursal '@0001
                        leAuxiliar.Add(oeAnalisis)
                    Next
                Next
                mt_CargarDC(leAuxiliar)
                lb_Importar = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_DatoPlanillaPago()
        Try
            ' Obtener Asiento
            oeAsiento = New e_Asiento
            oeAsiento.TipoOperacion = "A" : oeAsiento.Glosa = oeAsientoMov.Id
            oeAsiento = olAsiento.Obtener2(oeAsiento)
            ' Obtener MovCajaBanco
            oeMovCajaBanco = New e_MovimientoCajaBanco : leMovCajaBanco = New List(Of e_MovimientoCajaBanco)
            oeMovCajaBanco.TipoOperacion = "D"
            oeMovCajaBanco.IdAsientoMovimiento = oeAsiento.Id
            leMovCajaBanco = olMovCajaBanco.Listar(oeMovCajaBanco)
            ' Obtener Planilla
            oePlanilla = New e_Planilla
            oePlanilla.IndCargaCompleto = True : oePlanilla.IdPeriodo = oeAsiento.IdPeriodo
            oePlanilla = olPlanilla.Obtener(oePlanilla)
            ' Mostrar Informacion
            Dim _nroAux As Integer = 0
            _nroAux = ln_NroAnalisis
            leAuxiliar = New List(Of e_MovimientoAnalisis)
            For Each _oeMCB In leMovCajaBanco
                oeCuentaBancaria = New e_CuentaBancaria
                oeCuentaBancaria.TipoBusca = 1
                oeCuentaBancaria.Id = _oeMCB.IdCuentaBancaria
                If leCuentaBancaria.Contains(oeCuentaBancaria) Then
                    oeCuentaBancaria = leCuentaBancaria.Item(leCuentaBancaria.IndexOf(oeCuentaBancaria))
                End If
                For Each _oeDet In oePlanilla.leDetalle.Where(Function(it) it.ImportePagar > 0 And it.IdBanco = oeCuentaBancaria.IdBanco).ToList
                    oeAnalisis = New e_MovimientoAnalisis
                    oeAnalisis.TipoOperacion = "I"
                    oeAnalisis.IdTrabajador = _oeDet.IdTrabajador
                    oeAnalisis.Trabajador = _oeDet.Trabajador
                    oeAnalisis.Saldo = _oeDet.ImportePagar
                    oeAnalisis.Monto = _oeDet.ImportePagar
                    oeAnalisis.IdUsuarioCrea = gUsuarioSGI.Id
                    oeAnalisis.IdAsientoMovimiento = oeAsientoMov.Id
                    _nroAux = _nroAux + 1
                    oeAnalisis.NroFila = _nroAux
                    oeAnalisis.Activo = True
                    oeAnalisis.PrefijoID = gs_PrefijoIdSucursal '@0001
                    leAuxiliar.Add(oeAnalisis)
                Next
            Next
            mt_CargarDC(leAuxiliar)
            lb_Importar = True
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class