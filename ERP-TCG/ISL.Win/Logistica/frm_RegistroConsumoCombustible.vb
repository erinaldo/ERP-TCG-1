'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.IO
Imports Infragistics.Documents.Excel
Imports System.Text
Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices

Public Class frm_RegistroConsumoCombustible
    Inherits frm_MenuPadre

#Region "Declaracion de Variables"

    Private Shared instancia As frm_RegistroConsumoCombustible = Nothing
    Private Shared Operacion As String

    Dim grid As UltraGrid
    Dim oeRegConsumoCombustible As New e_RegistroConsumoCombustible, olRegConsumoCombustible As New l_RegistroConsumoCombustible
    Dim lstRegConsumoCombustible As New List(Of e_RegistroConsumoCombustible)
    Dim oeVehiculo As New e_Vehiculo, olVehiculo As New l_Vehiculo
    Dim oeEmpresa As New e_Empresa, olEmpresa As New l_Empresa
    Dim oeCcpp As New e_CCPP, olCcpp As New l_CCPP
    Dim oeDireccion As New e_Direccion, olDireccion As New l_Direccion
    'Dim oeSubAlmacen As New e_SubAlmacen, olSubAlmacen As New l_SubAlmacen
    'Dim oeMaterialAlmacen As New e_MaterialAlmacen, olMaterialAlmacen As New l_MaterialAlmacen
    Dim oeInventario As e_Inventario, olInventario As New l_Inventario
    'Manejador de Viaje
    Dim oeSeguimiento As New e_Seguimiento, olSeguimiento As New l_Seguimiento
    Dim oeMaterial As New e_Material, olMaterial As New l_Material
    'Dim oeTrabajador As New e_Trabajador, olTrabajador As New l_Trabajador

    Dim oeViaje As e_Viaje
    Dim olViaje As l_Operacion

    Dim ctrNuevo As Boolean = False, ctrEditar As Boolean = False, SOrigen As String, SDestino As String
    Dim _ingresando_datos As Boolean = False

    Dim ctrTanqueoS1 As Boolean = False
    Dim ctrTanqueoS2 As Boolean = False

    Dim olTrabajadorSeguridad As New l_TrabajadorSeguridad

    Dim loRegDiesel As New List(Of e_RegistroConsumoCombustible)

    ''Invocar Maestros
    Dim listaVehiculos As New List(Of e_Combo)
    Dim listaPilotos As New List(Of e_Combo)
    ''Mantenedores para nuevo cálculo
    Dim oeRuta As New e_Ruta
    Dim olRuta As New l_Ruta
    Dim leRuta As New List(Of e_Ruta)
    Dim oeRendimientoCombustible As New e_RendimientoCombustible
    Dim olRendimientoCombustible As New l_RendimientoCombustible
    Dim leRendimientoCombustible As New List(Of e_RendimientoCombustible)
    Dim oeZonaD2 As New e_ZonaCombustible
    Dim olZonaD2 As New l_ZonaCombustible
    Dim leZonaD2 As New List(Of e_ZonaCombustible)
    Dim oeOrden As e_Orden

    Private IdSubAlmacen As String = ""
    Private oeCombo As e_Combo
    'asientos contables
    Private oeAsientoModelo As e_AsientoModelo
    Private olAsientoModelo As l_AsientoModelo
    Private loAsientoModelo As List(Of e_AsientoModelo)
    Private oeReferencia As e_AsientoModelo_Referencia
    Private olReferencia As l_AsientoModelo_Referencia
    Private loReferencia As List(Of e_AsientoModelo_Referencia)

    Private dtReferencia As New DataTable

    'Dim olPecsa As datosPecsa
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Overrides Function getInstancia() As frm_MenuPadre
        Operacion = "Inicializa"
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_RegistroConsumoCombustible
        End If
        instancia.Activate()
        Return instancia
    End Function

    Public Sub New()
        InitializeComponent()
    End Sub


#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Operacion = "Inicializa"
            Select Case ficConCombustible.SelectedTab.Index
                Case 0, 1, 2, 3
                    Listar(Activo)
                    MostrarTabs(0, ficConCombustible, 2)
                    If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "COMBUSTIBLE") Then
                        ficConCombustible.Tabs(3).Enabled = True
                        ficConCombustible.Tabs(4).Enabled = True
                    Else
                        ficConCombustible.Tabs(1).Enabled = False
                        ficConCombustible.Tabs(2).Enabled = False
                        ficConCombustible.Tabs(3).Enabled = False
                        ficConCombustible.Tabs(4).Enabled = False
                    End If
                    If grid_ListadoTanqueo.Rows.Count > 0 Then
                        MyBase.Consultar(Activo)
                    Else
                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                    End If
                Case 4
                    CargarTanqueos()
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "COMBUSTIBLE") Then
                Operacion = "Nuevo"
                oeRegConsumoCombustible = New e_RegistroConsumoCombustible
                Inicializar()
                lblRango.Visible = False
                decOdometro.Value = 0.0
                cboVehiculo.ReadOnly = False
                gbeConsultar.Expanded = False
                ag_Operacion.Enabled = True
                ag_Datos.Enabled = True
                ag_DatosGrifo.Enabled = True
                ctrNuevo = True
                oeRegConsumoCombustible.TipoOperacion = "I"
                MostrarTabs(1, ficConCombustible, 1)
                MyBase.Nuevo()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "COMBUSTIBLE") Then
                Operacion = "Editar"
                oeRegConsumoCombustible = New e_RegistroConsumoCombustible
                If grid_ListadoTanqueo.ActiveRow.Band.Index = 2 Then
                    ctrEditar = True
                    EditarConsumoCombustible()
                Else
                    Throw New Exception("Seleccione un Registro de Consumo de Combustible")
                End If
                gbeConsultar.Expanded = False
                oeRegConsumoCombustible.TipoOperacion = "A"
                MostrarTabs(1, ficConCombustible, 1)
            End If         
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarConsumo() Then
                MyBase.Guardar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeRegConsumoCombustible.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficConCombustible, 2)
                        ficConCombustible.Tabs(3).Enabled = True
                        ficConCombustible.Tabs(4).Enabled = True
                        _ingresando_datos = False
                        TiempoManguera.Enabled = False
                        Consultar(True)
                    Case Windows.Forms.DialogResult.Cancel
                End Select
            Else
                MostrarTabs(0, ficConCombustible, 2)
                ficConCombustible.Tabs(3).Enabled = True
                ficConCombustible.Tabs(4).Enabled = True
                TiempoManguera.Enabled = False
                If grid_ListadoTanqueo.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 0, 0, 0, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If

                gbeConsultar.Expanded = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "ELIMINAR TANQUEOS") Then
                With grid_ListadoTanqueo
                    If .Rows.Count > 0 Then
                        oeRegConsumoCombustible = New e_RegistroConsumoCombustible
                        oeRegConsumoCombustible.Id = .ActiveRow.Cells("Id").Value
                        oeRegConsumoCombustible.TipoOperacion = 2
                        oeRegConsumoCombustible = olRegConsumoCombustible.Obtener(oeRegConsumoCombustible)
                        If oeRegConsumoCombustible.IndIsl Then
                            If ObtenerFechaServidor().Date <> oeRegConsumoCombustible.FechaTanqueo.Date Then
                                Throw New Exception("Solo Puede Eliminar Tanqueos del Mismo Dia.")
                            End If
                        End If
                        If oeRegConsumoCombustible.Activo And .ActiveRow.Cells("Estado").Value.ToString = "SIN" Then
                            If MessageBox.Show("Esta seguro de eliminar el Registro de Consumo de Combustible: ?", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                                oeRegConsumoCombustible.TipoOperacion = "E"
                                oeRegConsumoCombustible.UsuarioCreacion = gUsuarioSGI.Id
                                olRegConsumoCombustible.Eliminar(oeRegConsumoCombustible)
                                Consultar(True)
                            End If
                        Else
                            Throw New Exception("El tanqueo no se puede eliminar por su estado:" & .ActiveRow.Cells("Estado").Value.ToString)
                        End If
                    End If
                End With
            Else
                Throw New Exception("No Tiene Permisos para Eliminar Tanqueos")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Try
            If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "COMBUSTIBLE") Then
                If MessageBox.Show("¿Desea Imprimir el Vale de Consumo?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    oeRegConsumoCombustible.TipoOperacion = 2
                    oeRegConsumoCombustible.Id = grid_ListadoTanqueo.ActiveRow.Cells("Id").Value.ToString
                    oeRegConsumoCombustible = olRegConsumoCombustible.Obtener(oeRegConsumoCombustible)
                    ImprimirValeTanqueo(oeRegConsumoCombustible)
                End If
                MostrarTabs(0, ficConCombustible, 2)
                ficConCombustible.Tabs(3).Enabled = True
                ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If grid_ListadoTanqueo.Rows.Count > 0 Then Exportar_Excel(grid_ListadoTanqueo)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Procedimientos del Formulario"

    Public Function EditarConsumoCombustible() As Boolean
        Try
            Inicializar()
            With grid_ListadoTanqueo
                If ctrEditar Then
                    oeRegConsumoCombustible.Id = .ActiveRow.Cells("Id").Value.ToString
                    dtp_FecViaje.Value = .ActiveRow.ParentRow.Cells("FechaViaje").Value.ToString
                    SOrigen = Format(.ActiveRow.Cells("KmTractoOrigen").Value, "#,##0.00")
                    SDestino = Format(.ActiveRow.Cells("KmTractoDestino").Value, "#,##0.00")
                    lblRango.Visible = True
                    lblRango.Text = "<" & SOrigen & " - " & SDestino & ">"
                    If .ActiveRow.Cells("Estado").Value.ToString = "PAR" Or .ActiveRow.Cells("Estado").Value.ToString = "FAC" Then
                        ag_Operacion.Enabled = False
                        Me.chk_Credito.Enabled = False
                        Me.cmb_TipoCombustible.Enabled = False
                        Me.nd_CantGalones.Enabled = False
                        Me.txt_NroVale.Enabled = False
                        Me.nd_PrecioUnitario.Enabled = False
                        ag_DatosGrifo.Enabled = False
                    Else
                        ag_Operacion.Enabled = True
                        Me.chk_Credito.Enabled = True
                        Me.cmb_TipoCombustible.Enabled = False
                        Me.nd_CantGalones.Enabled = True
                        Me.txt_NroVale.Enabled = True
                        Me.nd_PrecioUnitario.Enabled = True
                        ag_DatosGrifo.Enabled = True
                    End If
                    ctrNuevo = False
                Else
                    oeRegConsumoCombustible.Id = grid_TanqNoAsoc.ActiveRow.Cells("Id").Value.ToString
                    dtp_FecViaje.Value = #1/1/1901#
                    cboVehiculo.ReadOnly = False
                End If
                decStock.Visible = VerISL.Checked
                etiStock.Visible = VerISL.Checked
                eti_Galones.Visible = VerISL.Checked
                txt_NroVale.ReadOnly = VerISL.Checked
                chk_Credito.Enabled = Not (VerISL.Checked)
                MyBase.Editar()
                oeRegConsumoCombustible.TipoOperacion = 2
                Dim oeRegConsumoCombustible2 As New e_RegistroConsumoCombustible
                oeRegConsumoCombustible2 = olRegConsumoCombustible.Obtener(oeRegConsumoCombustible)
                txtViaje.Text = oeRegConsumoCombustible2.CodViaje
                cboVehiculo.Value = oeRegConsumoCombustible2.IdVehiculo
                oeRegConsumoCombustible2.FechaViaje = dtp_FecViaje.Value
                cboGrifo.Value = oeRegConsumoCombustible2.IdGrifo
                cboLugar.Value = oeRegConsumoCombustible2.IdLugar
                cboDireccion.Value = oeRegConsumoCombustible2.IdDireccion
                nd_KmTanqueo.Value = oeRegConsumoCombustible2.KilometrosTanqueo
                nd_CantGalones.Value = oeRegConsumoCombustible2.CantidadGalon
                txt_NroVale.Text = oeRegConsumoCombustible2.NroVale
                nd_PrecioUnitario.Value = oeRegConsumoCombustible2.PrecioUnitario
                txtPiloto.Text = oeRegConsumoCombustible2.Piloto
                txtPiloto.Tag = oeRegConsumoCombustible2.IdPiloto
                chk_Credito.Checked = oeRegConsumoCombustible2.IndCredito
                opt_IndTanqueo.CheckedIndex = IIf(oeRegConsumoCombustible2.IndTanqueo = True, 0, 1)
                decOdometro.Value = ObtenerOdometro(oeRegConsumoCombustible2.IdVehiculo)
                cmb_TipoCombustible.Value = oeRegConsumoCombustible2.IdMaterial
                'If oeRegConsumoCombustible2.IndIsl Then
                '    DEC()
                'End If
                fecFechaTanqueo.Value = oeRegConsumoCombustible2.FechaTanqueo
                oeRegConsumoCombustible = oeRegConsumoCombustible2
                oeRegConsumoCombustible.GalonajeAntiguo = oeRegConsumoCombustible2.CantidadGalon

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub AsientoConsumo(oe As e_RegistroConsumoCombustible, Tipo As Integer)
        Try
            oeOrden = New e_Orden
            Dim oePeriodo As New e_Periodo
            Dim olPeriodo As New l_Periodo
            Dim fechaactual As Date = ObtenerFechaServidor.Date
            oePeriodo.Ejercicio = fechaactual.Year
            oePeriodo.Mes = fechaactual.Month
            oePeriodo = olPeriodo.Obtener(oePeriodo)
            If oePeriodo.Id = "" Then Throw New Exception("No Existe el Periodo Contable de Este Periodo. Comunicar a Contabilidad")
            oeOrden.IndAsiento = True
            oeOrden.loAsientoModelo = New List(Of e_AsientoModelo)
            oeOrden.lstInventario = New List(Of e_Inventario)
            ObtenerAsientoModelo("1CH01", oePeriodo.Ejercicio)
            If Tipo = 1 Then
                oeOrden.Total = (oe.CantidadGalon * oe.PrecioUnitario)
            End If
            oeOrden.IdPeriodo = oePeriodo.Id
            oeOrden.UsuarioCreacion = gUsuarioSGI.Id
            oeOrden.FechaOrden = fechaactual
            oeOrden.TipoCambio = TipoCambio(fechaactual, True)(0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GuardarConsumo() As Boolean
        Try
            If ValidaViajeTanqueo(oeRegConsumoCombustible.IdViaje) Then
                oeOrden = New e_Orden
                oeRegConsumoCombustible.CantidadGalon = nd_CantGalones.Value
                oeRegConsumoCombustible.Perfil = ObtenerPerfilPrincipal.Nombre
                oeRegConsumoCombustible.Ind_Masivo = False
                oeRegConsumoCombustible.Estado = IIf(oeRegConsumoCombustible.Estado = "PAR", oeRegConsumoCombustible.Estado, IIf(oeRegConsumoCombustible.Estado = "FAC", oeRegConsumoCombustible.Estado, "SIN"))
                oeRegConsumoCombustible.SaldoGls = 0.0
                oeRegConsumoCombustible.IdMaterial = Me.cmb_TipoCombustible.Value
                oeRegConsumoCombustible.UsuarioCreacion = gUsuarioSGI.Id
                If oeRegConsumoCombustible.FechaCreacion.Date = Date.Parse("01/01/1901") Then oeRegConsumoCombustible.FechaCreacion = ObtenerFechaServidor()
                oeRegConsumoCombustible.IndIsl = IIf(VerISL.Checked, True, False)
                oeRegConsumoCombustible.PrecioUnitario = nd_PrecioUnitario.Value
                oeRegConsumoCombustible.GlosaValeTanqueo = txtGlosaTanqueo.Value
                oeRegConsumoCombustible.lstInventario = New List(Of e_Inventario)
                If oeRegConsumoCombustible.TipoOperacion = "I" Then
                    If oeRegConsumoCombustible.IndIsl Then AsientoConsumo(oeRegConsumoCombustible, 1)
                    oeCombo = New e_Combo
                    oeCombo.Tipo = 4
                    oeCombo.Nombre = cboGrifo.Value
                    oeCombo.Descripcion = cboDireccion.Value
                    If SubAlmDiesel.Contains(oeCombo) Then
                        oeCombo = SubAlmDiesel.Item(SubAlmDiesel.IndexOf(oeCombo))
                    Else
                        Throw New Exception("No existe el SubAlmacen. Verificar")
                    End If
                    IdSubAlmacen = oeCombo.Id
                    oeRegConsumoCombustible.lstInventario = Inventario(oeRegConsumoCombustible, False, ObtenerFechaServidor())
                End If
                oeRegConsumoCombustible.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeOrden.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeRegConsumoCombustible = olRegConsumoCombustible.Guardar(oeRegConsumoCombustible, oeOrden)
                If oeRegConsumoCombustible.Id Is Nothing Then Return False
                If Operacion = "Nuevo" Then
                    If VerISL.Checked Then
                        If MessageBox.Show("El Consumo de combustible ha sido grabada satisfactoriamente," & vbCrLf & "¿Desea Imprimir el Vale de Consumo?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                            oeRegConsumoCombustible.TipoOperacion = 2
                            oeRegConsumoCombustible = olRegConsumoCombustible.Obtener(oeRegConsumoCombustible)
                            ImprimirValeTanqueo(oeRegConsumoCombustible)
                        End If
                        TiempoManguera.Enabled = False
                    Else
                        MessageBox.Show("El Consumo de combustible ha sido grabada satisfactoriamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    End If
                Else
                    mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                End If
                MostrarTabs(0, ficConCombustible, 2)
                ficConCombustible.Tabs(3).Enabled = True
                ficConCombustible.Tabs(4).Enabled = True
                gbeConsultar.Expanded = True
                If Grid_Vehiculos.Rows.Where(Function(x) x.Cells("Seleccion").Value = True).Count > 0 _
                OrElse Grid_Pilotos.Rows.Where(Function(x) x.Cells("Seleccion").Value = True).Count > 0 Then
                    'OrElse listaModeloMarca.Where(Function(x) x.Seleccion).Count > 0 _
                    Consultar(True)
                Else
                    Operacion = "Inicializa"
                    If grid_ListadoTanqueo.Rows.Count > 0 Then
                        MyBase.Consultar(True)
                    Else
                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                    End If
                End If
            End If
            Return True
        Catch ex As Exception
            fecFechaTanqueo.Value = oeRegConsumoCombustible.FechaTanqueo
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    ''REVISAR:
    Public Sub ObtenerStockUltPrecio()
        Try
            If Not String.IsNullOrEmpty(cboDireccion.Value) Then
                oeCombo = New e_Combo
                oeCombo.Tipo = 4
                oeCombo.Nombre = cboGrifo.Value
                oeCombo.Descripcion = cboDireccion.Value
                If SubAlmDiesel.Contains(oeCombo) Then
                    oeCombo = SubAlmDiesel.Item(SubAlmDiesel.IndexOf(oeCombo))
                Else
                    Throw New Exception("No existe el SubAlmacen. Verificar")
                End If
                IdSubAlmacen = oeCombo.Id
                If Not String.IsNullOrEmpty(oeCombo.Id) Then
                    'oeMaterialAlmacen = New e_MaterialAlmacen
                    'oeMaterialAlmacen.TipoOperacion = "1"
                    'oeMaterialAlmacen.IdAlmacen = oeSubAlmacen.IdAlmacen
                    'oeMaterialAlmacen.IdMaterial = cmb_TipoCombustible.Value
                    'oeMaterialAlmacen = olMaterialAlmacen.Obtener(oeMaterialAlmacen)
                    oeInventario = New e_Inventario
                    oeInventario.TipoOperacion = "5"
                    oeInventario.IdSubAlmacen = oeCombo.Id
                    oeInventario.IdMaterial = cmb_TipoCombustible.Value
                    oeInventario = olInventario.Obtener(oeInventario)
                    decStock.Value = oeInventario.CantidadFinal
                    nd_PrecioUnitario.Value = oeInventario.ValorUnitario ''REVISAR
                Else
                    decStock.Value = 0
                    nd_PrecioUnitario.Value = 0
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Dibujo de grilla"

    Public Sub MostrarColumnas()
        With grid_RegTanqNoAsoc
            .DisplayLayout.Bands(0).Columns("Seleccion").Hidden = True
            .DisplayLayout.Bands(0).Columns("Id").Hidden = True
            .DisplayLayout.Bands(0).Columns("CodViaje").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdVehiculo").Hidden = True
            .DisplayLayout.Bands(0).Columns("PrecioUnitario").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdDireccion").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdLugar").Hidden = True
            .DisplayLayout.Bands(0).Columns("IndCredito").Hidden = True
            .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
            .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdRegistroInventario").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdMaterial").Hidden = True
            .DisplayLayout.Bands(0).Columns("SaldoGls").Hidden = True
            .DisplayLayout.Bands(0).Columns("Estado").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdViaje").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdTracto").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdPiloto").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdGrifo").Hidden = True
            .DisplayLayout.Bands(0).Columns("Piloto").Hidden = True
            .DisplayLayout.Bands(0).Columns("CodMaterial").Hidden = True
            .DisplayLayout.Bands(0).Columns("Material").Hidden = True
        End With
    End Sub

    Private Sub griListadoTanqueo_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grid_ListadoTanqueo.InitializeLayout
        e.Layout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        e.Layout.Override.CellClickAction = CellClickAction.RowSelect

        With grid_ListadoTanqueo.DisplayLayout
            .UseFixedHeaders = True
            .Override.FixedHeaderIndicator = FixedHeaderIndicator.None

            With .Bands(0)
                .Override.RowAppearance.TextVAlign = Infragistics.Win.VAlign.Middle
                .Columns("Id").Header.Fixed = True
                .Columns("Placa").Header.Fixed = True
                .Columns("Marca").Header.Fixed = True
                .Columns("Placa").Header.Caption = "Placa/Viaje/NroVale"
                .Columns("IndTanqueo").Header.Caption = "Full"
                .Columns("CantidadGls").Header.Caption = "Gls"
                .Columns("Marca").Header.Caption = "Marca/Fecha Viaje/Tanqueo"
                .Columns("Marca").CellActivation = Activation.NoEdit
                .Columns("Id").Hidden = True
                .Columns("IdPiloto").Hidden = True
                .Columns("IdCopiloto").Hidden = True
                .Columns("KmTractoOrigen").Hidden = True
                .Columns("KmTractoDestino").Hidden = True
                .Columns("ROrigen").Hidden = True
                .Columns("RDestino").Hidden = True
                .Columns("IdCarreta").Hidden = True
                .Columns("IdOrigen").Hidden = True
                .Columns("IdDestino").Hidden = True
                .Columns("IdMaterial").Hidden = True
                .Columns("IdEmpresaGrifo").Hidden = True
                .Columns("EqOrigen").Hidden = True
                .Columns("EqDestino").Hidden = True
                .Columns("Placa").Width = 80
                .Columns("Marca").Width = 125
                .Columns("Modelo").Width = 80
                .Columns("Piloto").Width = 180
                .Columns("Copiloto").Width = 180
                .Columns("CantidadGls").Width = 65
                .Columns("KM").Width = 80
                .Columns("Grifo").Width = 150
                .Columns("Ruta").Width = 150
                .Columns("LugTanqueo").Width = 100
                .Columns("Peso").Width = 35
                .Columns("Cons").Width = 45
                .Columns("Dist").Width = 45
                .Columns("Rend").Width = 45
                .Columns("UsuarioCrea").Width = 60
                .Columns("Credito").Width = 35
                .Columns("Estado").Width = 45
                .Columns("Documento").Width = 80
                .Columns("IndTanqueo").Width = 30
                .Columns("Rutas").Width = 150
                .Columns("Pesos").Width = 150
                .Columns("Glosa").Width = 150
                .Columns("Material").Width = 60
                .Columns("RendEsperado").Width = 50
                .Columns("GlsEsperado").Width = 50
                .Columns("Desviacion").Width = 50
                .Columns("UsuarioCrea").Width = 70
                .Columns("FechaCrea").Width = 100
                .Columns("UsuarioModif").Width = 70
                .Columns("FechaModif").Width = 100
                .Columns("Cliente").Width = 220
                .Columns("CargaMaterial").Width = 125
                .Columns("KM").CellAppearance.BackColor = Color.SkyBlue
            End With

            With .Bands(1)
                .ColHeadersVisible = False
                .HeaderVisible = False
                .Override.RowAppearance.TextVAlign = Infragistics.Win.VAlign.Middle
                .Columns("IdTracto").Header.Fixed = True
                .Columns("IdViaje").Header.Fixed = True
                .Columns("CodViaje").Header.Fixed = True
                .Columns("FechaViaje").Header.Fixed = True
                .Columns("FechaViaje").CellActivation = Activation.NoEdit
                .Columns("IdOrigen").Hidden = True
                .Columns("IdDestino").Hidden = True
                .Columns("IdMaterial").Hidden = True
                .Columns("IdTracto").Hidden = True
                .Columns("IdViaje").Hidden = True
                .Columns("IdPiloto").Hidden = True
                .Columns("IdCopiloto").Hidden = True
                .Columns("IdCarreta").Hidden = True
                .Columns("KmTractoOrigen").Hidden = True
                .Columns("KmTractoDestino").Hidden = True
                .Columns("ROrigen").Hidden = True
                .Columns("RDestino").Hidden = True
                .Columns("IdEmpresaGrifo").Hidden = True
                .Columns("EqOrigen").Hidden = True
                .Columns("EqDestino").Hidden = True
                .Columns("FechaViaje").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("KM").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("Dist").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("Peso").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("FechaViaje").Width = 125
                .Columns("CodViaje").Width = 80
                .Columns("Carreta").Width = 80
                .Columns("Piloto").Width = 180
                .Columns("Copiloto").Width = 180
                .Columns("Ruta").Width = 150
                .Columns("LugTanqueo").Width = 100
                .Columns("Grifo").Width = 150
                .Columns("KM").Width = 80
                .Columns("CantidadGls").Width = 65
                .Columns("Peso").Width = 35
                .Columns("Material").Width = 60
                .Columns("Credito").Width = 35
                .Columns("Estado").Width = 45
                .Columns("IndTanqueo").Width = 30
                .Columns("UsuarioCrea").Width = 60
                .Columns("Cons").Width = 45
                .Columns("Dist").Width = 45
                .Columns("Rend").Width = 45
                .Columns("Rutas").Width = 150
                .Columns("Pesos").Width = 150
                .Columns("Glosa").Width = 150
                .Columns("RendEsperado").Width = 50
                .Columns("GlsEsperado").Width = 50
                .Columns("Desviacion").Width = 50
                .Columns("UsuarioCrea").Width = 70
                .Columns("FechaCrea").Width = 100
                .Columns("UsuarioModif").Width = 70
                .Columns("FechaModif").Width = 100
                .Columns("Cliente").Width = 220
                .Columns("CargaMaterial").Width = 125
                .Columns("CodViaje").CellAppearance.BackColor = Color.Khaki
                .Columns("Dist").CellAppearance.BackColor = Color.Silver
                .Columns("KM").CellAppearance.BackColor = Color.SkyBlue
                .Columns("Peso").Format = "#,##0.00"
                .Columns("KM").Format = "#,##0.00"
                .Columns("FechaViaje").Style = ColumnStyle.DateTime
            End With

            With .Bands(2)
                .Override.RowAppearance.TextVAlign = Infragistics.Win.VAlign.Middle
                .ColHeadersVisible = False
                .HeaderVisible = False
                .Columns("NroVale").Header.Fixed = True
                .Columns("FechaTanqueo").Header.Fixed = True
                .Columns("IdOrigen").Hidden = True
                .Columns("IdDestino").Hidden = True
                .Columns("IdMaterial").Hidden = True
                .Columns("IdVehiculo").Hidden = True
                .Columns("Id").Hidden = True
                .Columns("IdViaje").Hidden = True
                .Columns("IdCarreta").Hidden = True
                .Columns("KmTractoOrigen").Hidden = True
                .Columns("KmTractoDestino").Hidden = True
                .Columns("ROrigen").Hidden = True
                .Columns("RDestino").Hidden = True
                .Columns("IdPiloto").Hidden = True
                .Columns("IdCopiloto").Hidden = True
                .Columns("IdEmpresaGrifo").Hidden = True
                .Columns("EqOrigen").Hidden = True
                .Columns("EqDestino").Hidden = True
                .Columns("Glosa").CellClickAction = CellClickAction.Edit
                .Columns("FechaTanqueo").CellActivation = Activation.NoEdit
                .Columns("FechaCrea").CellActivation = Activation.NoEdit
                .Columns("FechaModif").CellActivation = Activation.NoEdit
                .Columns("CantidadGls").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("Cons").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("Kilometraje").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("Dist").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("NroVale").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("Rend").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("FechaTanqueo").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("FechaCrea").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("FechaModif").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("RendEsperado").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("GlsEsperado").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("Desviacion").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("Estado").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("Documento").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("Id").Width = 80
                .Columns("IdViaje").Width = 80
                .Columns("IdVehiculo").Width = 80
                .Columns("NroVale").Width = 80
                .Columns("FechaTanqueo").Width = 125
                .Columns("Carreta").Width = 80
                .Columns("Piloto").Width = 180
                .Columns("Copiloto").Width = 180
                .Columns("Ruta").Width = 150
                .Columns("Grifo").Width = 150
                .Columns("Kilometraje").Width = 80
                .Columns("LugTanqueo").Width = 100
                .Columns("CantidadGls").Width = 65
                .Columns("Peso").Width = 35
                .Columns("Material").Width = 60
                .Columns("Credito").Width = 35
                .Columns("Estado").Width = 45
                .Columns("IndTanqueo").Width = 30
                .Columns("UsuarioCrea").Width = 60
                .Columns("Cons").Width = 45
                .Columns("Dist").Width = 45
                .Columns("Rend").Width = 45
                .Columns("Rutas").Width = 150
                .Columns("Pesos").Width = 150
                .Columns("Glosa").Width = 150
                .Columns("RendEsperado").Width = 50
                .Columns("GlsEsperado").Width = 50
                .Columns("Desviacion").Width = 50
                .Columns("UsuarioCrea").Width = 70
                .Columns("FechaCrea").Width = 100
                .Columns("UsuarioModif").Width = 70
                .Columns("FechaModif").Width = 100
                .Columns("Cliente").Width = 220
                .Columns("CargaMaterial").Width = 125
                .Columns("NroVale").CellAppearance.BackColor = Color.Khaki
                .Columns("Dist").CellAppearance.BackColor = Color.Silver
                .Columns("Kilometraje").CellAppearance.BackColor = Color.SkyBlue
                .Columns("Kilometraje").Format = "#,##0.00"
                .Columns("Cons").Format = "#,##0.00"
                .Columns("Dist").Format = "#,##0.00"
                .Columns("RendEsperado").Format = "#,##0.00"
                .Columns("GlsEsperado").Format = "#,##0.00"
                .Columns("Desviacion").Format = "#,##0.00"
                .Columns("RendEsperado").Style = ColumnStyle.Double
                .Columns("GlsEsperado").Style = ColumnStyle.Double
                .Columns("Desviacion").Style = ColumnStyle.Double
                .Columns("RendEsperado").MaskInput = "{double:6.2}"
                .Columns("GlsEsperado").MaskInput = "{double:6.2}"
                .Columns("Desviacion").MaskInput = "{double:6.2}"
                .Columns("FechaTanqueo").Style = ColumnStyle.DateTime
                .Columns("FechaCrea").Style = ColumnStyle.DateTime
                .Columns("FechaModif").Style = ColumnStyle.DateTime
            End With
        End With
    End Sub

#End Region

#Region "Procedimientos"

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            ValidarFechaDesde_Hasta(rfDesde, rfHasta)
            oeRegConsumoCombustible.Activo = Activo
            oeRegConsumoCombustible.TipoOperacion = "1"
            oeRegConsumoCombustible.fechaInicio = rfDesde.Value
            oeRegConsumoCombustible.fechaFin = rfHasta.Value
            oeRegConsumoCombustible.IdVehiculo = ObtenerTractosSeleccionados()
            oeRegConsumoCombustible.Pilotos = ObtenerPilotosSeleccionados()
            oeRegConsumoCombustible.TipoVehiculos = ObtenerTipoVehSeleccionadas()
            oeRegConsumoCombustible.Flotas = ObtenerFlotaSeleccionadas()
            oeRegConsumoCombustible.IndTanqueoNoAsoc = chk_TanqNoAsoc.Checked
            oeRegConsumoCombustible.leRutas = leRuta
            oeRegConsumoCombustible.leZonaD2 = leZonaD2
            oeRegConsumoCombustible.leRendimiento = leRendimientoCombustible
            grid_ListadoTanqueo.DataSource = olRegConsumoCombustible.CalcularRendimiento(oeRegConsumoCombustible)
            Me.Cursor = Cursors.WaitCursor
            If grid_ListadoTanqueo.Rows.Count > 0 Then
                grid_ListadoTanqueo.Focus()
                grid_ListadoTanqueo.Rows.Item(0).Selected = True
            End If
            If grid_ListadoTanqueo.Rows.Count < 11 Then
                grid_ListadoTanqueo.Rows.ExpandAll(True)
            End If
            If chkColores.Checked = True Then
                Dim band As UltraGridBand = Me.grid_ListadoTanqueo.DisplayLayout.Bands(2)
                Dim row As UltraGridRow
                For Each row In band.GetRowEnumerator(GridRowType.DataRow)
                    If row.Cells("IndTanqueo").Value = True And row.Cells("RendEsperado").Value <> "" Then
                        If row.Cells("Dist").Value < 0 Then
                            row.CellAppearance.BackColor = ColorDistNegativo.Color
                        ElseIf ObtenerNroVueltasTembladeraPacas(row.Cells("Rutas").Value, CDbl(row.Cells("Dist").Value)) = True Then
                            row.CellAppearance.BackColor = ColorKmVuelta.Color
                        ElseIf row.Cells("RendEsperado").Value = 0.0 Then
                            row.CellAppearance.BackColor = ColorSinRend.Color
                        ElseIf row.Cells("Rend").Value > nd_RendMayor.Value Then
                            row.CellAppearance.BackColor = ColorRendMayor.Color
                        ElseIf row.Cells("Rend").Value < nd_RendMenor.Value Then
                            row.CellAppearance.BackColor = ColorRendMenor.Color
                        End If
                    End If
                Next row
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        grid_ListadoTanqueo.Focus()
    End Sub

    Public Sub VerificacionKilometraje()
        If ctrNuevo Then
            oeRegConsumoCombustible.KilometrosTanqueo = nd_KmTanqueo.Value
            oeSeguimiento = New e_Seguimiento
            oeSeguimiento.TipoOperacion = 1
            oeSeguimiento.Activo = True
            oeSeguimiento.IdVehiculo = cboVehiculo.Value
            oeSeguimiento.CantKm = CStr(oeRegConsumoCombustible.KilometrosTanqueo)
            oeSeguimiento.IndLlegadaDestino = IIf(VerISL.Checked, 1, 0)
            oeSeguimiento = olSeguimiento.ObtenerRango(oeSeguimiento)

            If oeSeguimiento.CodViaje <> Nothing Then
                txtViaje.Text = oeSeguimiento.CodViaje
                dtp_FecViaje.Value = oeSeguimiento.LlegadaDestino
                fecFechaTanqueo.Value = dtp_FecViaje.Value
                oeRegConsumoCombustible.FechaTanqueo = fecFechaTanqueo.Value
                oeRegConsumoCombustible.FechaViaje = dtp_FecViaje.Value
                txtPiloto.Text = oeSeguimiento.Piloto
                txtPiloto.Tag = oeSeguimiento.IdPiloto
                oeRegConsumoCombustible.IdPiloto = oeSeguimiento.IdPiloto
                oeRegConsumoCombustible.IdViaje = oeSeguimiento.Id
            Else
                mensajeEmergente.Problema("El kilometraje ingresado no coincide con ningun viaje.", True)
                nd_KmTanqueo.Value = 0.0
                txtViaje.Text = String.Empty
                txtPiloto.Text = String.Empty
                oeRegConsumoCombustible.IdViaje = ""
            End If

        End If
    End Sub

    Public Sub ObtenerLugares(ByVal id As String, ByVal ind As Boolean)
        Try
            oeCcpp = New e_CCPP
            oeCcpp.TipoOperacion = 1
            oeCcpp.Activo = True
            oeCcpp.Nombre = id
            LimpiaCombos(cboLugar)
            If ind Then
                LlenarCombo(cboLugar, "Nombre", olCcpp.Listar(oeCcpp), 0)
            Else
                LlenarCombo(cboLugarTNA, "Nombre", olCcpp.Listar(oeCcpp), 0)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ObtenerOdometro(ByVal idVehiculo As String) As Double
        Try
            oeVehiculo = New e_Vehiculo
            oeVehiculo.TipoOperacion = "A"
            oeVehiculo.Id = idVehiculo
            oeVehiculo = olVehiculo.Obtener(oeVehiculo)
            Return oeVehiculo.Odometro
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub ConsultarTanqueosNoAsociados(ByVal idVehiculo As String)
        Try
            oeRegConsumoCombustible = New e_RegistroConsumoCombustible
            oeRegConsumoCombustible.TipoOperacion = 4
            oeRegConsumoCombustible.Activo = True
            oeRegConsumoCombustible.IdVehiculo = idVehiculo
            lstRegConsumoCombustible = olRegConsumoCombustible.Listar(oeRegConsumoCombustible)
            grid_TanqNoAsoc.DataSource = lstRegConsumoCombustible
            gbTanqueosNoAsociados.Expanded = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializar()
        Try
            nd_KmTanqueo.Value = 0.0
            VerISL.Checked = False
            Me.txtViaje.Text = String.Empty
            Me.txt_NroVale.Text = String.Empty
            txtPiloto.Text = String.Empty
            nd_CantGalones.Value = 0.0
            nd_PrecioUnitario.Value = 0.0
            fecFechaTanqueo.Value = Date.Now
            dtp_FecViaje.Value = Date.Now
            oeRegConsumoCombustible.FechaViaje = dtp_FecViaje.Value
            chk_Credito.Checked = False
            cboGrifo.SelectedIndex = -1
            cboLugar.SelectedIndex = -1
            cboDireccion.SelectedIndex = -1
            cmb_TipoCombustible.SelectedIndex = 0
            opt_IndTanqueo.CheckedIndex = 0
            cboVehiculo.SelectedIndex = -1
            cboVehiculo.Text = String.Empty
            gbTanqueosNoAsociados.Expanded = False
            nd_CantGalones.Enabled = True
            txt_NroVale.Enabled = True
            nd_PrecioUnitario.Enabled = True
            Etiqueta47.Visible = False
            txtGlosaTanqueo.Text = ""
            txtGlosaTanqueo.Value = ""
            txtGlosaTanqueo.Visible = False
            If Operacion = "Editar" Then
                VerISL.Enabled = False
                cboGrifo.Enabled = False
                cboLugar.Enabled = False
                cboDireccion.Enabled = False
                cboVehiculo.ReadOnly = True
                cmb_TipoCombustible.Enabled = False
                PanelGrifo.Enabled = False
            Else
                VerISL.Enabled = True
                cboGrifo.Enabled = True
                cboLugar.Enabled = True
                cboDireccion.Enabled = True
                cmb_TipoCombustible.Enabled = True
                PanelGrifo.Enabled = True
            End If
            chk_Credito.Checked = Not (VerISL.Checked)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub CargarCombos()
        Try
            LlenaComboGrifos()
            LlenarCombo(cboVehiculo, "Nombre", listaVehiculos.Where(Function(i) i.Id <> "").ToList, 0)
            LlenarCombo(CboVehiculoS1, "Nombre", listaVehiculos, 0)
            LlenarCombo(CboVehiculoS2, "Nombre", listaVehiculos, 0)
            LlenaComboTipoCombutible()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Sub LlenaComboGrifos()
        Dim ListaEmpresa As New List(Of e_Empresa)
        oeEmpresa = New e_Empresa
        oeEmpresa.TipoOperacion = "1"
        oeEmpresa.IdTipoEmpresa = "1CH000000002"
        oeEmpresa.Activo = True
        ListaEmpresa = olEmpresa.Listar(oeEmpresa)
        LlenarComboMaestro(cboGrifo, ListaEmpresa, -1)
        LlenarComboMaestro(cboGrifoTNA, ListaEmpresa, -1)
    End Sub

    Sub LlenaComboTipoCombutible()
        Dim lstTipoCombustible As New List(Of e_Material)
        oeMaterial = New e_Material
        oeMaterial.Activo = True
        oeMaterial.TipoOperacion = "C"
        lstTipoCombustible = olMaterial.Listar(oeMaterial)
        LlenarComboMaestro(cmb_TipoCombustible, lstTipoCombustible, 0)
    End Sub

    Public Sub CargarTabs()
        Try
            ' Carga de los vehículos
            listaVehiculos = New List(Of e_Combo)
            Dim oeVehiculo As New e_Combo
            oeVehiculo.Id = ""
            oeVehiculo.Nombre = "NINGUNO"
            listaVehiculos.Add(oeVehiculo)
            listaVehiculos.AddRange(VehiculosD2Public)
            Grid_Vehiculos.DataSource = listaVehiculos.Where(Function(i) i.Id <> "").ToList
            ' Carga de los Pilotos:
            Dim ListaPiloto = PilotoPublic
            For Each obj In CopilotoPublic
                If ListaPiloto.Where(Function(i) i.Id = obj.Id).Count = 0 Then
                    ListaPiloto.Add(obj)
                End If
            Next
            Grid_Pilotos.DataSource = ListaPiloto.Where(Function(i) i.Id <> "0").ToList
            ' Carga de los tipos de vehículo
            Grid_TipoeVeh.DataSource = TipoVehiculoPublic
            ' Carga de Zonas 
            Grid_Zona.DataSource = ZonaPublic.Where(Function(i) i.Id <> "").ToList
            ' Carga de Rutas
            oeRuta = New e_Ruta
            oeRuta.TipoOperacion = "D"
            leRuta = olRuta.Listar(oeRuta)
            ' Carga de Zona D2
            oeZonaD2 = New e_ZonaCombustible
            leZonaD2 = New List(Of e_ZonaCombustible)
            oeZonaD2.TipoOperacion = "D"
            leZonaD2 = olZonaD2.Listar(oeZonaD2)
            ' Carga de Rendimientos
            oeRendimientoCombustible = New e_RendimientoCombustible
            leRendimientoCombustible = New List(Of e_RendimientoCombustible)
            oeRendimientoCombustible.Id = ""
            oeRendimientoCombustible.IdTipoVehiculo = ""
            oeRendimientoCombustible.IdFlota = ""
            leRendimientoCombustible = olRendimientoCombustible.Listar(oeRendimientoCombustible)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ImprimirValeTanqueo(ByVal oeRegConsumoCombustible As e_RegistroConsumoCombustible)
        Dim frm As frm_ImprimirValeCombustible
        Dim o_Datos = New Dictionary(Of String, String)
        o_Datos.Item("PLACA_VEH") = oeRegConsumoCombustible.PlacaVeh
        o_Datos.Item("NOM_CHOFER") = oeRegConsumoCombustible.Piloto
        o_Datos.Item("NUMERO") = oeRegConsumoCombustible.NroVale
        o_Datos.Item("FECHA") = oeRegConsumoCombustible.FechaTanqueo
        o_Datos.Item("KILOMETRAJE") = String.Format("{0:#,##0.00}", oeRegConsumoCombustible.KilometrosTanqueo)
        o_Datos.Item("GALONES") = oeRegConsumoCombustible.CantidadGalon
        o_Datos.Item("GLOSA") = oeRegConsumoCombustible.GlosaValeTanqueo
        frm = New frm_ImprimirValeCombustible(o_Datos)
        frm.ShowDialog()
        o_Datos = Nothing
        frm = Nothing

    End Sub

    Sub r_ListarLugaresEmpresa()
        Try
            oeCcpp = New e_CCPP
            oeCcpp.TipoOperacion = 1
            oeCcpp.Activo = True
            oeCcpp.Nombre = cboGrifo.Value
            LimpiaCombos(cboLugar)
            LlenarCombo(cboLugar, "Nombre", olCcpp.Listar(oeCcpp), -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub r_ListarDireccionesGrifo()
        Try
            oeDireccion = New e_Direccion
            oeDireccion.TipoOperacion = 1
            oeDireccion.IdTipoVia = cboGrifo.Value
            oeDireccion.Activo = True
            oeDireccion.Id = cboLugar.Value
            LimpiaCombos(cboDireccion)
            LlenarCombo(cboDireccion, "Via", olDireccion.Listar(oeDireccion), 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ObtenerTractosSeleccionados() As String
        Dim Tractos As String = ""
        For Each row In Grid_Vehiculos.Rows.Where(Function(i) i.Cells("Seleccion").Value = True).ToList
            If Tractos = "" Then
                Tractos &= "'" & row.Cells("Id").Value & "'"
            Else
                Tractos &= ",'" & row.Cells("Id").Value & "'"
            End If
        Next
        Return Tractos
    End Function

    Public Function ObtenerPilotosSeleccionados() As String
        Dim Pilotos As String = ""
        For Each row In Grid_Pilotos.Rows.Where(Function(i) i.Cells("Seleccion").Value = True).ToList
            If Pilotos = "" Then
                Pilotos &= "'" & row.Cells("Id").Value & "'"
            Else
                Pilotos &= ",'" & row.Cells("Id").Value & "'"
            End If
        Next
        Return Pilotos
    End Function

    Public Function ObtenerTipoVehSeleccionadas() As String
        Dim TipoVeh As String = ""
        For Each row In Grid_TipoeVeh.Rows.Where(Function(i) i.Cells("Seleccion").Value = True).ToList
            If TipoVeh = "" Then
                TipoVeh &= "'" & row.Cells("Id").Value & "'"
            Else
                TipoVeh &= ",'" & row.Cells("Id").Value & "'"
            End If
        Next
        Return TipoVeh
    End Function

    Public Function ObtenerFlotaSeleccionadas() As String
        Dim Zona As String = ""
        For Each row In Grid_Zona.Rows.Where(Function(i) i.Cells("Seleccion").Value = True).ToList
            If Zona = "" Then
                Zona &= "'" & row.Cells("Id").Value & "'"
            Else
                Zona &= ",'" & row.Cells("Id").Value & "'"
            End If
        Next
        Return Zona
    End Function

    Public Function ObtenerNroVueltasTembladeraPacas(cadena As String, distancia As Double) As Boolean
        Try
            If Not Cadena.StartsWith("PACASMAYO - TEMBLADERA - PACASMAYO") Then Return False
            Dim Ruta As String = "PACASMAYO"
            For i = 1 To 9
                Ruta = Ruta + " - TEMBLADERA - PACASMAYO"
                If Cadena = Ruta Then
                    If ndKmxVuelta.Value * i < distancia Then
                        Return True
                    End If
                    Exit For
                End If
            Next
            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Menú Contextual"

    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuTanqueo.Opening
        If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "COMBUSTIBLE") Then
            MenuTanqueo.Items(0).Visible = False : MenuTanqueo.Items(1).Visible = False
            MenuTanqueo.Items(2).Visible = False : MenuTanqueo.Items(3).Visible = False
            MenuTanqueo.Items(4).Visible = False : MenuTanqueo.Items(5).Visible = False
            MenuTanqueo.Items(6).Visible = False : MenuTanqueo.Items(7).Visible = False
            If MenuTanqueo.SourceControl Is grid_ListadoTanqueo Then
                grid = grid_ListadoTanqueo
                If grid_ListadoTanqueo.Rows.Count > 0 Then
                    If grid_ListadoTanqueo.ActiveRow.Band.Index = 1 Then
                        MenuTanqueo.Items(0).Visible = True
                        MenuTanqueo.Items(6).Visible = True
                        MenuTanqueo.Items(7).Visible = True
                    ElseIf grid_ListadoTanqueo.ActiveRow.Band.Index = 2 Then
                        MenuTanqueo.Items(1).Visible = True
                        MenuTanqueo.Items(2).Visible = True
                        MenuTanqueo.Items(3).Visible = True
                        MenuTanqueo.Items(4).Visible = True
                    End If
                End If
            End If
            If MenuTanqueo.SourceControl Is grid_RegTanqNoAsoc Then
                grid = grid_RegTanqNoAsoc
                MenuTanqueo.Items(0).Visible = False : MenuTanqueo.Items(1).Visible = False
                MenuTanqueo.Items(2).Visible = False : MenuTanqueo.Items(3).Visible = False
                MenuTanqueo.Items(4).Visible = False : MenuTanqueo.Items(5).Visible = False
                MenuTanqueo.Items(6).Visible = False : MenuTanqueo.Items(7).Visible = False
                If grid_RegTanqNoAsoc.Rows.Count > 0 Then
                    MenuTanqueo.Items(3).Visible = True
                    MenuTanqueo.Items(6).Visible = True
                End If
            End If
            If MenuTanqueo.SourceControl Is grid_TanqNoAsoc Then
                grid = grid_TanqNoAsoc
                MenuTanqueo.Items(0).Visible = False : MenuTanqueo.Items(1).Visible = False
                MenuTanqueo.Items(2).Visible = False : MenuTanqueo.Items(3).Visible = False
                MenuTanqueo.Items(4).Visible = False : MenuTanqueo.Items(5).Visible = False
                MenuTanqueo.Items(6).Visible = False : MenuTanqueo.Items(7).Visible = False
                If grid_TanqNoAsoc.Rows.Count > 0 Then
                    MenuTanqueo.Items(1).Visible = True
                    MenuTanqueo.Items(2).Visible = True
                    MenuTanqueo.Items(5).Visible = True
                End If
            End If
        Else
            MenuTanqueo.Items(0).Enabled = False : MenuTanqueo.Items(1).Enabled = False
            MenuTanqueo.Items(2).Enabled = False : MenuTanqueo.Items(3).Enabled = False
            MenuTanqueo.Items(4).Enabled = False : MenuTanqueo.Items(5).Enabled = False
            MenuTanqueo.Items(6).Enabled = False : MenuTanqueo.Items(7).Enabled = False
        End If  
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        Try
            Operacion = "Nuevo"
            oeRegConsumoCombustible = New e_RegistroConsumoCombustible
            Inicializar()
            If grid_ListadoTanqueo.ActiveRow.Band.Index = 1 Then
                If grid_ListadoTanqueo.ActiveRow.Cells("CodViaje").Value.ToString.Length > 0 Then
                    cboVehiculo.ReadOnly = True
                    oeRegConsumoCombustible.IdViaje = grid_ListadoTanqueo.ActiveRow.Cells("IdViaje").Value.ToString
                    txtViaje.Text = grid_ListadoTanqueo.ActiveRow.Cells("CodViaje").Value.ToString
                    cboVehiculo.Value = grid_ListadoTanqueo.ActiveRow.Cells("IdTracto").Value.ToString
                    oeRegConsumoCombustible.IdVehiculo = cboVehiculo.Value
                    decOdometro.Value = ObtenerOdometro(oeRegConsumoCombustible.IdVehiculo)
                    oeRegConsumoCombustible.PlacaVeh = grid_ListadoTanqueo.ActiveRow.ParentRow.Cells("Placa").Value.ToString
                    oeRegConsumoCombustible.IdPiloto = grid_ListadoTanqueo.ActiveRow.Cells("IdPiloto").Value.ToString
                    txtPiloto.Text = grid_ListadoTanqueo.ActiveRow.Cells("Piloto").Value.ToString
                    fecFechaTanqueo.Value = Date.Now
                    oeRegConsumoCombustible.FechaTanqueo = fecFechaTanqueo.Value
                    dtp_FecViaje.Value = grid_ListadoTanqueo.ActiveRow.Cells("FechaViaje").Value.ToString
                    oeRegConsumoCombustible.FechaViaje = dtp_FecViaje.Value
                    SOrigen = Format(grid_ListadoTanqueo.ActiveRow.Cells("KmTractoOrigen").Value, "#,##0.00")
                    SDestino = Format(grid_ListadoTanqueo.ActiveRow.Cells("KmTractoDestino").Value, "#,##0.00")
                End If
            Else
                Throw New Exception("Seleccione un viaje para registrar un nuevo consumo")
            End If
            ctrNuevo = False
            lblRango.Visible = True
            lblRango.Text = "<" & SOrigen & " - " & SDestino & ">"
            gbeConsultar.Expanded = False
            oeRegConsumoCombustible.UsuarioCreacion = gUsuarioSGI.Id
            oeRegConsumoCombustible.TipoOperacion = "I"
            oeRegConsumoCombustible.Activo = True
            ag_Operacion.Enabled = True
            ag_Datos.Enabled = True
            ag_DatosGrifo.Enabled = True
            MostrarTabs(1, ficConCombustible, 1)
            MyBase.Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        If MenuTanqueo.SourceControl Is grid_ListadoTanqueo Then
            If grid_ListadoTanqueo.ActiveRow.Band.Index = 2 Then
                Editar()
            Else
                mensajeEmergente.Problema("Para editar un tanqueo,Seleccione un registro de consumo de combustible")
            End If
        Else
            Operacion = "Editar"
            oeRegConsumoCombustible = New e_RegistroConsumoCombustible
            Try
                ctrEditar = False
                If grid_TanqNoAsoc.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                    EditarConsumoCombustible()
                End If
            Catch ex As Exception
                mensajeEmergente.Problema("Seleccione un Registro de Consumo de Combustible a Editar")
                Exit Sub
            End Try
            gbeConsultar.Expanded = False
            oeRegConsumoCombustible.TipoOperacion = "A"
            MostrarTabs(1, ficConCombustible, 1)
            MyBase.Editar()
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar()
    End Sub

    Private Sub DesasociarTanqueoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DesasociarTanqueoToolStripMenuItem.Click
        Try
            If MessageBox.Show("Esta seguro en desasociar el Registro de Consumo de Combustible Seleccionado?", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                oeRegConsumoCombustible.Id = grid_ListadoTanqueo.ActiveRow.Cells("Id").Value.ToString
                oeRegConsumoCombustible.TipoOperacion = 2
                oeRegConsumoCombustible = olRegConsumoCombustible.Obtener(oeRegConsumoCombustible)
                oeRegConsumoCombustible.Ind_Masivo = False
                oeRegConsumoCombustible.TipoOperacion = "P"
                oeRegConsumoCombustible.IdViaje = ""
                oeRegConsumoCombustible.IdPiloto = ""
                oeRegConsumoCombustible.FechaViaje = grid_ListadoTanqueo.ActiveRow.ParentRow().Cells("FechaViaje").Value.ToString
                oeRegConsumoCombustible.Perfil = ObtenerPerfilPrincipal.Nombre
                oeRegConsumoCombustible.UsuarioCreacion = gUsuarioSGI.Id
                oeRegConsumoCombustible.lstInventario = New List(Of e_Inventario)
                oeRegConsumoCombustible.PrefijoID = gs_PrefijoIdSucursal '@0001
                olRegConsumoCombustible.Guardar(oeRegConsumoCombustible, New e_Orden)
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub AsociarTanqueoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsociarTanqueoToolStripMenuItem.Click
        Try
            If grid_ListadoTanqueo.ActiveRow.Band.Index = 1 Then
                If grid_TanqNoAsoc.ActiveRow.Cells("IdVehiculo").Value = grid_ListadoTanqueo.ActiveRow.Cells("IdTracto").Value Then
                    If MessageBox.Show("Esta seguro de asociar el tanqueo con N° Vale: " & grid_TanqNoAsoc.ActiveRow.Cells("NroVale").Value & " al viaje con N°Codigo: " & grid_ListadoTanqueo.ActiveRow.Cells("CodViaje").Value & " ?", _
                                    "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        oeRegConsumoCombustible.TipoOperacion = 2
                        oeRegConsumoCombustible.Id = grid_TanqNoAsoc.ActiveRow.Cells("Id").Value
                        oeRegConsumoCombustible = olRegConsumoCombustible.Obtener(oeRegConsumoCombustible)
                        oeRegConsumoCombustible.TipoOperacion = "P"
                        oeRegConsumoCombustible.IdViaje = grid_ListadoTanqueo.ActiveRow.Cells("IdViaje").Value
                        oeRegConsumoCombustible.IdPiloto = grid_ListadoTanqueo.ActiveRow.Cells("IdPiloto").Value
                        oeRegConsumoCombustible.FechaViaje = grid_ListadoTanqueo.ActiveRow.Cells("FechaViaje").Value
                        oeRegConsumoCombustible.Perfil = ObtenerPerfilPrincipal.Nombre
                        oeRegConsumoCombustible.UsuarioCreacion = gUsuarioSGI.Id
                        oeRegConsumoCombustible.lstInventario = New List(Of e_Inventario)
                        oeRegConsumoCombustible.PrefijoID = gs_PrefijoIdSucursal '@0001
                        olRegConsumoCombustible.Guardar(oeRegConsumoCombustible, New e_Orden)
                        ConsultarTanqueosNoAsociados(grid_TanqNoAsoc.ActiveRow.Cells("IdVehiculo").Value)
                        Consultar(True)
                    End If
                Else
                    Throw New Exception("Asocie el tanqueo a un viaje del mismo vehiculo")
                End If
            Else
                Throw New Exception("Seleccione un viaje para asociar.")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click
        If grid_ListadoTanqueo.ActiveRow.Band.Index = 2 Then
            Editar()
            ControlBoton(0, 0, 0, 0, 1, 0, 1, 0, 1)
        Else
            mensajeEmergente.Problema("Ubiquese en el 3 nivel", True)
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Try
            If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "COMBUSTIBLE") Then
                If Len(Grid_Vehiculos.ActiveRow.Cells("Id").Value.ToString) > 0 Then
                    CboVehiculoS1.Value = Grid_Vehiculos.ActiveRow.Cells("Id").Value
                    CboVehiculoS1.Enabled = True
                    ctrTanqueoS1 = False
                    TxT_IdViajeS1.Value = ""
                    TxtViajeS1.Value = ""
                    TxtPilotoS1.Value = ""
                    Txt_IdPilotoS1.Value = ""
                    dtp_FechaViajeS1.Value = "01/01/1901"
                    Opt_IndTanqueoS1.Value = True
                    ficConCombustible.Tabs(3).Selected = True
                Else
                    Throw New Exception("Seleccione un vehículo válido")
                End If
            End If
           
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub EnviarASurtidor2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarASurtidor2ToolStripMenuItem.Click
        Try
            If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "COMBUSTIBLE") Then
                If Len(Grid_Vehiculos.ActiveRow.Cells("Id").Value.ToString) > 0 Then
                    CboVehiculoS2.Value = Grid_Vehiculos.ActiveRow.Cells("Id").Value
                    CboVehiculoS2.Enabled = True
                    ctrTanqueoS2 = False
                    TxT_IdViajeS2.Value = ""
                    TxtViajeS2.Value = ""
                    TxtPilotoS2.Value = ""
                    Txt_IdPilotoS2.Value = ""
                    dtp_FechaViajeS2.Value = "01/01/1901"
                    Opt_IndTanqueoS2.Value = True
                    ficConCombustible.Tabs(3).Selected = True
                Else
                    Throw New Exception("Seleccione un vehículo válido")
                End If
            End If        
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_RegistroConsumoCombustible_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub cboDireccionTNA_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDireccionTNA.ValueChanged
        oeRegConsumoCombustible.IdDireccion = cboDireccionTNA.Value
    End Sub

    Private Sub cmbTipoCombustible_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_TipoCombustible.ValueChanged
        ObtenerStockUltPrecio()
    End Sub

    Private Sub cboDireccion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDireccion.ValueChanged
        Try
            If cboDireccion.SelectedIndex <> -1 Then
                oeRegConsumoCombustible.IdDireccion = cboDireccion.Value
                If VerISL.Checked Then
                    ObtenerStockUltPrecio()
                    If cboDireccion.Value = "1SI0000471" Then
                        PanelGrifo.Visible = True
                        OptManguera1.Checked = True
                        TiempoManguera.Enabled = True
                    Else
                        PanelGrifo.Visible = False
                        OptNinguno.Checked = True
                        TiempoManguera.Enabled = False
                        oeRegConsumoCombustible.CodigoSurtidor = ""
                    End If
                Else
                    PanelGrifo.Visible = False
                    OptNinguno.Checked = True
                    TiempoManguera.Enabled = False
                    oeRegConsumoCombustible.CodigoSurtidor = ""
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub VerISL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerISL.CheckedChanged
        Try
            If Operacion <> "Editar" Then
                If VerISL.Checked Then
                    txt_NroVale.Text = "AUTO"
                    txt_NroVale.ReadOnly = True
                    chk_Credito.Checked = False
                    chk_Credito.Visible = False
                    cboGrifo.Value = ISL_IdEmpresa
                    cboGrifo.Enabled = False
                    decStock.Visible = True
                    etiStock.Visible = True
                    eti_Galones.Visible = True
                    txt_NroVale.ReadOnly = True
                    Etiqueta47.Visible = True
                    txtGlosaTanqueo.Visible = True
                Else
                    chk_Credito.Checked = True
                    chk_Credito.Visible = True
                    cboGrifo.SelectedIndex = -1
                    cboLugar.SelectedIndex = -1
                    cboGrifo.Enabled = True
                    cboDireccion.SelectedIndex = -1
                    txt_NroVale.Text = String.Empty
                    txt_NroVale.ReadOnly = False
                    decStock.Visible = False
                    etiStock.Visible = False
                    eti_Galones.Visible = False
                    Etiqueta47.Visible = False
                    txtGlosaTanqueo.Visible = False
                    txtGlosaTanqueo.Value = ""
                    txtGlosaTanqueo.Text = ""
                End If
                If nd_KmTanqueo.Value > 0 Then
                    VerificacionKilometraje()
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ndCanKilometraje_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nd_KmTanqueo.Validated
        Try
            If Not String.IsNullOrEmpty(cboVehiculo.Text) Then
                If nd_KmTanqueo.Value > 0 Then
                    VerificacionKilometraje()
                End If
            Else
                Throw New Exception("Seleccione un Vehiculo, Antes de Ingresar un Kilometraje")
                nd_KmTanqueo.Value = 0.0
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboGrifo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrifo.ValueChanged
        Try
            oeRegConsumoCombustible.IdGrifo = cboGrifo.Value
            LimpiaCombos(cboLugar)
            LimpiaCombos(cboDireccion)
            If Me.cboGrifo.SelectedIndex <> -1 Then
                r_ListarLugaresEmpresa()

                Dim obj As New e_Empresa
                obj = cboGrifo.Items(cboGrifo.SelectedIndex).ListObject
                If Not String.IsNullOrEmpty(obj.IdDireccionTanqueo) Then
                    oeDireccion = New e_Direccion
                    oeDireccion.Activo = True
                    oeDireccion.Id = obj.IdDireccionTanqueo
                    oeDireccion.TipoOperacion = ""
                    oeDireccion = olDireccion.Obtener(oeDireccion)
                    cboLugar.Value = oeDireccion.CCPP
                End If
            Else
                Me.cboLugar.Value = Nothing
                Me.cboLugar.DataSource = Nothing
            End If
            If Me.cboGrifo.Value = ISL_IdEmpresa Then Me.VerISL.Checked = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboLugar_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLugar.ValueChanged
        Try
            If cboLugar.SelectedIndex <> -1 Then
                r_ListarDireccionesGrifo()
                If cboDireccion.Items.Count > 1 Then
                    If VerISL.Checked Then
                        Dim obj As New e_Empresa
                        obj = cboGrifo.Items(cboGrifo.SelectedIndex).ListObject
                        If Not String.IsNullOrEmpty(obj.IdDireccionTanqueo) Then
                            cboDireccion.Value = obj.IdDireccionTanqueo
                        End If
                    Else
                        cboDireccion.SelectedIndex = -1
                    End If
                Else
                    cboDireccion.SelectedIndex = 0
                End If
            Else
                Me.cboDireccion.Value = Nothing
                Me.cboDireccion.DataSource = Nothing
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub optIndTanqueo_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles opt_IndTanqueo.ValueChanged
        oeRegConsumoCombustible.IndTanqueo = IIf(opt_IndTanqueo.CheckedIndex = 0, True, False)
    End Sub

    Private Sub griListadoTanqueo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        If grid_ListadoTanqueo.ActiveRow.Band.Index = 2 Then Editar()
    End Sub

    Private Sub chkCredito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        oeRegConsumoCombustible.IndCredito = chk_Credito.Checked
    End Sub

    Private Sub cboVehiculo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVehiculo.ValueChanged
        oeRegConsumoCombustible.IdVehiculo = cboVehiculo.Value
        decOdometro.Value = ObtenerOdometro(oeRegConsumoCombustible.IdVehiculo)
    End Sub

    Private Sub frm_RegistraConsumoCombustible_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gmt_ConfigurarEventoKeyEnter_Tab(Me, grid_ListadoTanqueo.Name)
            gf_AsignarEventoSeleccionarTexto(Me)
            CargarTabs()
            opt_IndTanqueo.CheckedIndex = 0
            rfDesde.Value = Date.Today.AddDays(-30)
            rfHasta.Value = ObtenerFechaServidor()
            fecInicioTanqueo.Value = Date.Now.AddDays(-5)
            gbTanqueosNoAsociados.Expanded = False
            CargarCombos()
            If gUsuarioSGI.oeArea.Nombre = gNombreAreaInformaticaSistemas Then Etiqueta27.Visible = True And nd_PrecioUnitarioS.Visible = True
            If Not olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "COMBUSTIBLE") Then
                ficConCombustible.Tabs(1).Enabled = False
                ficConCombustible.Tabs(2).Enabled = False
                ficConCombustible.Tabs(3).Enabled = False
                ficConCombustible.Tabs(4).Enabled = False
            End If
            AsientoContable()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_RegistraConsumoCombustible_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Select Case Operacion
            Case "Inicializa"
                MostrarTabs(0, ficConCombustible, 2)
                ficConCombustible.Tabs(3).Enabled = True
                ficConCombustible.Tabs(4).Enabled = True
        End Select
        If Not olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "COMBUSTIBLE") Then
            ficConCombustible.Tabs(1).Enabled = False
            ficConCombustible.Tabs(2).Enabled = False
            ficConCombustible.Tabs(3).Enabled = False
            ficConCombustible.Tabs(4).Enabled = False
        End If
    End Sub

    Private Sub frm_RegistraConsumoCombustible_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_RegistraConsumoCombustible_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub txtNroVale_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_NroVale.ValueChanged
        oeRegConsumoCombustible.NroVale = txt_NroVale.Text
    End Sub

    Private Sub fecFechaTanqueo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecFechaTanqueo.ValueChanged
        oeRegConsumoCombustible.FechaTanqueo = fecFechaTanqueo.Value
    End Sub

    Private Sub ndCanKilometraje_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nd_KmTanqueo.ValueChanged
        Try
            If cboVehiculo.Value <> "" Then
                oeRegConsumoCombustible.KilometrosTanqueo = nd_KmTanqueo.Value
            Else
                nd_KmTanqueo.Value = 0.0
                nd_KmTanqueo.Focus()
                oeRegConsumoCombustible.KilometrosTanqueo = nd_KmTanqueo.Value
                Throw New Exception("Seleccione un vehículo antes de ingresar kilometraje")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtCantGalones_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nd_CantGalones.ValueChanged
        Try
            If nd_CantGalones.Value > 250 Then
                oeRegConsumoCombustible.CantidadGalon = 0
                nd_CantGalones.Value = oeRegConsumoCombustible.CantidadGalon
                txt_NroVale.Focus()
                nd_CantGalones.Focus()
                Throw New Exception("La cantidad de galones solicitada debe ser menor o igual 250")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub grid_TanqNoAsoc_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles grid_TanqNoAsoc.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            Eliminar()
            e.Cancel = True
        Catch ex As Exception
            e.Cancel = True
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Sub

    Private Sub griListadoTanqueo_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles grid_ListadoTanqueo.DragDrop
        Try
            If Not olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "COMBUSTIBLE") Then Throw New Exception("No Tiene Permiso para Realizar esta Accion")
            Dim uieOver As UIElement = grid_ListadoTanqueo.DisplayLayout.UIElement.ElementFromPoint(grid_ListadoTanqueo.PointToClient(New Point(e.X, e.Y)))
            'get the row that is the drop zone/or where the dragged row is to be dropped 
            'Dim grid1 As UltraGrid = TryCast(sender, UltraGrid)
            Dim ugrOver As UltraGridRow = TryCast(uieOver.GetContext(GetType(UltraGridRow), True), UltraGridRow)

            If Not ugrOver Is Nothing Then
                If ugrOver.Band.Index = 1 Then
                    If grid.ActiveRow.Cells("IdVehiculo").Value = ugrOver.Cells("IdTracto").Value Then
                        If MessageBox.Show("Esta seguro de Mover el tanqueo con N° Vale: " & grid.ActiveRow.Cells("NroVale").Value & " al viaje con N°Codigo: " & ugrOver.Cells("CodViaje").Value & " ?", _
                                         "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeRegConsumoCombustible.TipoOperacion = 2
                            oeRegConsumoCombustible.Id = grid.ActiveRow.Cells("Id").Value
                            oeRegConsumoCombustible.Ind_Masivo = False
                            oeRegConsumoCombustible = olRegConsumoCombustible.Obtener(oeRegConsumoCombustible)
                            oeRegConsumoCombustible.TipoOperacion = "P"
                            oeRegConsumoCombustible.IdViaje = ugrOver.Cells("IdViaje").Value
                            oeRegConsumoCombustible.IdPiloto = ugrOver.Cells("IdPiloto").Value
                            oeRegConsumoCombustible.FechaViaje = ugrOver.Cells("FechaViaje").Value
                            oeRegConsumoCombustible.UsuarioCreacion = gUsuarioSGI.Id
                            oeRegConsumoCombustible.lstInventario = New List(Of e_Inventario)
                            oeRegConsumoCombustible.PrefijoID = gs_PrefijoIdSucursal '@0001
                            olRegConsumoCombustible.Guardar(oeRegConsumoCombustible, New e_Orden)
                            ConsultarTanqueosNoAsociados(grid.ActiveRow.Cells("IdVehiculo").Value)
                            Consultar(True)
                        End If
                    Else
                        Throw New Exception("Agregue tanqueo a que contenga el mismo vehiculo")
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListadoTanqueo_DragOver(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles grid_ListadoTanqueo.DragOver
        e.Effect = DragDropEffects.Move
        Dim grid As UltraGrid = TryCast(sender, UltraGrid)
        Dim pointInGridCoords As Point = grid.PointToClient(New Point(e.X, e.Y))
        If pointInGridCoords.Y < 20 Then
            ' Scroll up
            Me.grid_ListadoTanqueo.ActiveRowScrollRegion.Scroll(RowScrollAction.LineUp)
        ElseIf pointInGridCoords.Y > grid.Height - 20 Then
            ' Scroll down
            Me.grid_ListadoTanqueo.ActiveRowScrollRegion.Scroll(RowScrollAction.LineDown)
        End If
    End Sub

    Private Sub griListadoTanqueo_SelectionDrag(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles grid_ListadoTanqueo.SelectionDrag
        grid = sender
        grid_ListadoTanqueo.DoDragDrop(grid_ListadoTanqueo.Selected.Rows, DragDropEffects.Move)
    End Sub

    Private Sub grilisRegCon_DragOver(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles grid_TanqNoAsoc.DragOver
        e.Effect = DragDropEffects.Move

        Dim grid As UltraGrid = TryCast(sender, UltraGrid)
        Dim pointInGridCoords As Point = grid.PointToClient(New Point(e.X, e.Y))
        If pointInGridCoords.Y < 20 Then
            ' Scroll up
            Me.grid_ListadoTanqueo.ActiveRowScrollRegion.Scroll(RowScrollAction.LineUp)
        ElseIf pointInGridCoords.Y > grid.Height - 20 Then
            ' Scroll down
            Me.grid_ListadoTanqueo.ActiveRowScrollRegion.Scroll(RowScrollAction.LineDown)
        End If
    End Sub

    Private Sub grilisRegCon_SelectionDrag(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles grid_TanqNoAsoc.SelectionDrag
        grid = sender
        grid_TanqNoAsoc.DoDragDrop(grid_TanqNoAsoc.Selected.Rows, DragDropEffects.Move)
    End Sub

    Private Sub ficConCombustible_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles ficConCombustible.SelectedTabChanged
        Try
            TiempoSurtidor.Enabled = False
            IdSubAlmacen = ""
            If ficConCombustible.Tabs(3).Selected Then
                CboGrifoS.Value = "1CH000006026"
                CboLugarS.Value = "1CH0001173"
                CboDireccionS.Value = "1SI0000475"
                TiempoSurtidor.Enabled = True
                ObtenerStockUltPrecioS("1CH000006026", "1SI0000471")
                ActualizarSurtidores()
            ElseIf ficConCombustible.Tabs(2).Selected Then
                CboGrifoS.Value = "1CH000006026"
                CboLugarS.Value = "1CH0001173"
                CboDireccionS.Value = "1SI0000475"
            ElseIf ficConCombustible.Tabs(4).Selected Then
                If griTanqueosPecsa.Rows.Count = 0 Then
                    loRegDiesel = New List(Of e_RegistroConsumoCombustible)
                    griTanqueosPecsa.DataSource = loRegDiesel
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboDireccion_AfterDropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDireccion.AfterDropDown
        Dim senderComboBox As UltraComboEditor = DirectCast(sender, UltraComboEditor)
        Dim width As Integer = senderComboBox.DropDownListWidth
        Dim g As Graphics = senderComboBox.CreateGraphics()
        Dim font As Font = senderComboBox.Font
        Dim vertScrollBarWidth As Integer = If((senderComboBox.Items.Count > senderComboBox.MaxDropDownItems), SystemInformation.VerticalScrollBarWidth, 0)

        Dim newWidth As Integer
        For Each s As ValueListItem In DirectCast(sender, UltraComboEditor).Items
            newWidth = CInt(g.MeasureString(s.ToString, font).Width) + vertScrollBarWidth
            If width < newWidth Then
                width = newWidth
            End If
        Next
        senderComboBox.DropDownListWidth = width
    End Sub

    Private Sub griListadoTanqueo_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grid_ListadoTanqueo.DoubleClickRow
        If grid_ListadoTanqueo.Rows.Count > 0 Then
            If grid_ListadoTanqueo.ActiveRow.Band.Index = 2 Then
                Editar()
            ElseIf grid_ListadoTanqueo.ActiveRow.Band.Index = 0 Then
                If grid_ListadoTanqueo.Rows.Count > 0 Then
                    If grid_ListadoTanqueo.ActiveRow.Cells("Placa").Value <> Nothing Then
                        ConsultarTanqueosNoAsociados(grid_ListadoTanqueo.ActiveRow.Cells("Id").Value)
                        gbTanqueosNoAsociados.Expanded = True
                    End If
                End If
            Else
                gbTanqueosNoAsociados.Expanded = False
            End If
        End If
    End Sub

    Private Sub grid_TanqNoAsoc_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles grid_TanqNoAsoc.DoubleClickRow
        If grid_TanqNoAsoc.Rows.Count > 0 Then

            Operacion = "Editar"
            oeRegConsumoCombustible = New e_RegistroConsumoCombustible
            Try
                ctrEditar = False
                If grid_TanqNoAsoc.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                    EditarConsumoCombustible()
                End If
            Catch ex As Exception
                mensajeEmergente.Problema("Seleccione un Registro de Consumo de Combustible a Editar")
                Exit Sub
            End Try
            gbeConsultar.Expanded = False
            oeRegConsumoCombustible.TipoOperacion = "A"
            MostrarTabs(1, ficConCombustible, 1)
            MyBase.Editar()

        Else
            Throw New Exception("No existen filas a editar en tanqueos no asociados.")
        End If
    End Sub

    Private Sub grid_ListadoTanqueo_KeyDown(sender As Object, e As KeyEventArgs) Handles grid_ListadoTanqueo.KeyDown
        Try
            If e.Shift = False Then
                If e.KeyCode = Keys.Enter Then
                    If grid_ListadoTanqueo.ActiveRow.Band.Index = 2 Then
                        grid_ListadoTanqueo.UpdateData()
                        oeRegConsumoCombustible = New e_RegistroConsumoCombustible
                        oeRegConsumoCombustible.TipoOperacion = "G"
                        oeRegConsumoCombustible.Id = grid_ListadoTanqueo.ActiveRow.Cells("Id").Value
                        oeRegConsumoCombustible.Glosa = IIf(String.IsNullOrEmpty(grid_ListadoTanqueo.ActiveRow.Cells("Glosa").Value.ToString), "", grid_ListadoTanqueo.ActiveRow.Cells("Glosa").Value.ToString)
                        oeRegConsumoCombustible.lstInventario = New List(Of e_Inventario)
                        oeRegConsumoCombustible.PrefijoID = gs_PrefijoIdSucursal '@0001
                        oeRegConsumoCombustible = olRegConsumoCombustible.Guardar(oeRegConsumoCombustible, New e_Orden)
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Grid_Pilotos_CellChange(sender As Object, e As CellEventArgs) Handles Grid_Pilotos.CellChange
        Grid_Pilotos.UpdateData()
    End Sub

    Private Sub Grid_Vehiculos_CellChange_1(sender As Object, e As CellEventArgs) Handles Grid_Vehiculos.CellChange
        Grid_Vehiculos.UpdateData()
    End Sub

    Private Sub Grid_TipoeVeh_CellChange(sender As Object, e As CellEventArgs) Handles Grid_TipoeVeh.CellChange
        Grid_TipoeVeh.UpdateData()
    End Sub

    Private Sub Grid_Zona_CellChange(sender As Object, e As CellEventArgs) Handles Grid_Zona.CellChange
        Grid_Zona.UpdateData()
    End Sub

    Private Sub Grid_Vehiculos_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles Grid_Vehiculos.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub Grid_Pilotos_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles Grid_Pilotos.BeforeRowsDeleted
        e.cancel = True
    End Sub

    Private Sub Grid_TipoeVeh_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles Grid_TipoeVeh.BeforeRowsDeleted
        e.cancel = True
    End Sub

    Private Sub Grid_Zona_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles Grid_Zona.BeforeRowsDeleted
        e.cancel = True
    End Sub

    Private Sub Grid_Pilotos_AfterHeaderCheckStateChanged(sender As Object, e As AfterHeaderCheckStateChangedEventArgs) Handles Grid_Pilotos.AfterHeaderCheckStateChanged
        Try
            Dim column As UltraGridColumn = e.Column
            Dim rows As RowsCollection = e.Rows
            Dim checkStateValue = column.GetHeaderCheckedState(rows)
            For Each row In Grid_Pilotos.Rows.Where(Function(item) item.IsFilteredOut = False)
                row.Cells("Seleccion").Value = checkStateValue
            Next
            Grid_Pilotos.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Grid_TipoeVeh_AfterHeaderCheckStateChanged(sender As Object, e As AfterHeaderCheckStateChangedEventArgs) Handles Grid_TipoeVeh.AfterHeaderCheckStateChanged
        Try
            Dim column As UltraGridColumn = e.Column
            Dim rows As RowsCollection = e.Rows
            Dim checkStateValue = column.GetHeaderCheckedState(rows)
            For Each row In Grid_TipoeVeh.Rows.Where(Function(item) item.IsFilteredOut = False)
                row.Cells("Seleccion").Value = checkStateValue
            Next
            Grid_TipoeVeh.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Grid_Zona_AfterHeaderCheckStateChanged(sender As Object, e As AfterHeaderCheckStateChangedEventArgs) Handles Grid_Zona.AfterHeaderCheckStateChanged
        Try
            Dim column As UltraGridColumn = e.Column
            Dim rows As RowsCollection = e.Rows
            Dim checkStateValue = column.GetHeaderCheckedState(rows)
            For Each row In Grid_Zona.Rows.Where(Function(item) item.IsFilteredOut = False)
                row.Cells("Seleccion").Value = checkStateValue
            Next
            Grid_Zona.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Grid_Vehiculos_AfterHeaderCheckStateChanged(sender As Object, e As AfterHeaderCheckStateChangedEventArgs) Handles Grid_Vehiculos.AfterHeaderCheckStateChanged
        Try
            Dim column As UltraGridColumn = e.Column
            Dim rows As RowsCollection = e.Rows
            Dim checkStateValue = column.GetHeaderCheckedState(rows)
            For Each row In Grid_Vehiculos.Rows.Where(Function(item) item.IsFilteredOut = False)
                row.Cells("Seleccion").Value = checkStateValue
            Next
            Grid_Vehiculos.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub chkVisualiza_CheckedChanged(sender As Object, e As EventArgs) Handles chkVisualiza.CheckedChanged
        If chkVisualiza.Checked = True Then
            grid_ListadoTanqueo.DisplayLayout.Bands(0).Columns("Cliente").Hidden = True
            grid_ListadoTanqueo.DisplayLayout.Bands(1).Columns("Cliente").Hidden = True
            grid_ListadoTanqueo.DisplayLayout.Bands(2).Columns("Cliente").Hidden = True
            grid_ListadoTanqueo.DisplayLayout.Bands(0).Columns("Grifo").Hidden = True
            grid_ListadoTanqueo.DisplayLayout.Bands(1).Columns("Grifo").Hidden = True
            grid_ListadoTanqueo.DisplayLayout.Bands(2).Columns("Grifo").Hidden = True
            grid_ListadoTanqueo.DisplayLayout.Bands(0).Columns("Referencia").Hidden = True
            grid_ListadoTanqueo.DisplayLayout.Bands(1).Columns("Referencia").Hidden = True
            grid_ListadoTanqueo.DisplayLayout.Bands(2).Columns("Referencia").Hidden = True
            grid_ListadoTanqueo.DisplayLayout.Bands(0).Columns("Copiloto").Hidden = True
            grid_ListadoTanqueo.DisplayLayout.Bands(1).Columns("Copiloto").Hidden = True
            grid_ListadoTanqueo.DisplayLayout.Bands(2).Columns("Copiloto").Hidden = True
        Else
            grid_ListadoTanqueo.DisplayLayout.Bands(0).Columns("Cliente").Hidden = False
            grid_ListadoTanqueo.DisplayLayout.Bands(1).Columns("Cliente").Hidden = False
            grid_ListadoTanqueo.DisplayLayout.Bands(2).Columns("Cliente").Hidden = False
            grid_ListadoTanqueo.DisplayLayout.Bands(0).Columns("Grifo").Hidden = False
            grid_ListadoTanqueo.DisplayLayout.Bands(1).Columns("Grifo").Hidden = False
            grid_ListadoTanqueo.DisplayLayout.Bands(2).Columns("Grifo").Hidden = False
            grid_ListadoTanqueo.DisplayLayout.Bands(0).Columns("Referencia").Hidden = False
            grid_ListadoTanqueo.DisplayLayout.Bands(1).Columns("Referencia").Hidden = False
            grid_ListadoTanqueo.DisplayLayout.Bands(2).Columns("Referencia").Hidden = False
            grid_ListadoTanqueo.DisplayLayout.Bands(0).Columns("Copiloto").Hidden = False
            grid_ListadoTanqueo.DisplayLayout.Bands(1).Columns("Copiloto").Hidden = False
            grid_ListadoTanqueo.DisplayLayout.Bands(2).Columns("Copiloto").Hidden = False
        End If
    End Sub

    Private Sub grFiltro_Click(sender As Object, e As EventArgs) Handles grFiltro.Click
        For x As Integer = 0 To grid_ListadoTanqueo.Rows.Count - 1
            Me.grid_ListadoTanqueo.Rows(x).ExpandAll()
        Next
    End Sub

    Private Sub btnExporta2_Click(sender As Object, e As EventArgs) Handles btnExporta2.Click
        Try
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            Dim dst As New DataSet
            Dim TablaInforme As New DataTable
            'AKI MISMO ARMAMOS LA NUEVA TABLA PAL PIVOT
            dst = New DataSet
            'ARMAMOS LA TABLA
            TablaInforme = dst.Tables.Add("TablaInforme")
            TablaInforme.Columns.Add("Placa", Type.GetType("System.String"))
            TablaInforme.Columns.Add("CodViaje", Type.GetType("System.String"))
            TablaInforme.Columns.Add("FechaViaje", Type.GetType("System.DateTime"))
            TablaInforme.Columns.Add("Carreta", Type.GetType("System.String"))
            TablaInforme.Columns.Add("Piloto", Type.GetType("System.String"))
            TablaInforme.Columns.Add("Copiloto", Type.GetType("System.String"))
            TablaInforme.Columns.Add("Ruta", Type.GetType("System.String"))
            TablaInforme.Columns.Add("Peso", Type.GetType("System.Double"))
            TablaInforme.Columns.Add("KM", Type.GetType("System.String"))
            TablaInforme.Columns.Add("Distancia", Type.GetType("System.String"))
            TablaInforme.Columns.Add("NroVale", Type.GetType("System.String"))
            TablaInforme.Columns.Add("FechaTanqueo", Type.GetType("System.String"))
            TablaInforme.Columns.Add("Grifo", Type.GetType("System.String"))
            TablaInforme.Columns.Add("Referencia", Type.GetType("System.String"))
            TablaInforme.Columns.Add("LugTanqueo", Type.GetType("System.String"))
            TablaInforme.Columns.Add("Kilometraje", Type.GetType("System.String"))
            TablaInforme.Columns.Add("IndTanqueo", Type.GetType("System.String"))
            TablaInforme.Columns.Add("CantidadGls", Type.GetType("System.String"))
            TablaInforme.Columns.Add("Material", Type.GetType("System.String"))
            TablaInforme.Columns.Add("Cons", Type.GetType("System.String"))
            TablaInforme.Columns.Add("Dist", Type.GetType("System.String"))
            TablaInforme.Columns.Add("Rend", Type.GetType("System.String"))
            TablaInforme.Columns.Add("Rutas", Type.GetType("System.String"))
            TablaInforme.Columns.Add("Pesos", Type.GetType("System.String"))
            TablaInforme.Columns.Add("RendEsperado", Type.GetType("System.String"))
            TablaInforme.Columns.Add("GlsEsperado", Type.GetType("System.String"))
            TablaInforme.Columns.Add("Desviacion", Type.GetType("System.String"))
            TablaInforme.Columns.Add("Glosa", Type.GetType("System.String"))
            TablaInforme.Columns.Add("Estado", Type.GetType("System.String"))
            TablaInforme.Columns.Add("UsuarioCrea", Type.GetType("System.String"))
            TablaInforme.Columns.Add("FechaCrea", Type.GetType("System.String"))
            TablaInforme.Columns.Add("UsuarioModif", Type.GetType("System.String"))
            TablaInforme.Columns.Add("FechaModif", Type.GetType("System.String"))

            For Each fila As UltraGridRow In grid_ListadoTanqueo.Rows
                For Each band As UltraGridChildBand In fila.ChildBands
                    For Each xfila As UltraGridRow In band.Rows
                        For Each band2 As UltraGridChildBand In xfila.ChildBands
                            If band2.Rows.Count = 0 Then
                                Dim row As DataRow = dst.Tables("TablaInforme").NewRow()
                                row("Placa") = fila.Cells("Placa").Value
                                row("CodViaje") = xfila.Cells("CodViaje").Value
                                row("FechaViaje") = xfila.Cells("FechaViaje").Value
                                row("Carreta") = xfila.Cells("Carreta").Value
                                row("Piloto") = xfila.Cells("Piloto").Value
                                row("Copiloto") = xfila.Cells("Copiloto").Value
                                row("Ruta") = xfila.Cells("Ruta").Value
                                row("Peso") = xfila.Cells("Peso").Value
                                row("KM") = xfila.Cells("KM").Value
                                row("Distancia") = xfila.Cells("Dist").Value
                                row("NroVale") = ""
                                row("FechaTanqueo") = ""
                                row("Grifo") = ""
                                row("Referencia") = ""
                                row("LugTanqueo") = ""
                                row("Kilometraje") = ""
                                row("IndTanqueo") = ""
                                row("CantidadGls") = ""
                                row("Material") = ""
                                row("Cons") = ""
                                row("Dist") = ""
                                row("Rend") = ""
                                row("Rutas") = ""
                                row("Pesos") = ""
                                row("RendEsperado") = ""
                                row("GlsEsperado") = ""
                                row("Desviacion") = ""
                                row("Glosa") = ""
                                row("Estado") = ""
                                row("UsuarioCrea") = ""
                                row("FechaCrea") = ""
                                row("UsuarioModif") = ""
                                row("FechaModif") = ""
                                dst.Tables("TablaInforme").Rows.Add(row)
                            Else
                                For Each x2fila As UltraGridRow In band2.Rows
                                    Dim row As DataRow = dst.Tables("TablaInforme").NewRow()
                                    row("Placa") = fila.Cells("Placa").Value
                                    row("CodViaje") = xfila.Cells("CodViaje").Value
                                    row("FechaViaje") = xfila.Cells("FechaViaje").Value
                                    row("Carreta") = xfila.Cells("Carreta").Value
                                    row("Piloto") = xfila.Cells("Piloto").Value
                                    row("Copiloto") = xfila.Cells("Copiloto").Value
                                    row("Ruta") = xfila.Cells("Ruta").Value
                                    row("Peso") = xfila.Cells("Peso").Value
                                    row("KM") = xfila.Cells("KM").Value
                                    row("Distancia") = xfila.Cells("Dist").Value
                                    row("NroVale") = x2fila.Cells("NroVale").Value
                                    row("FechaTanqueo") = x2fila.Cells("FechaTanqueo").Value
                                    row("Grifo") = x2fila.Cells("Grifo").Value
                                    row("Referencia") = x2fila.Cells("Referencia").Value
                                    row("LugTanqueo") = x2fila.Cells("LugTanqueo").Value
                                    row("Kilometraje") = x2fila.Cells("Kilometraje").Value
                                    row("IndTanqueo") = x2fila.Cells("IndTanqueo").Value
                                    row("CantidadGls") = x2fila.Cells("CantidadGls").Value
                                    row("Material") = x2fila.Cells("Material").Value
                                    row("Cons") = x2fila.Cells("Cons").Value
                                    row("Dist") = x2fila.Cells("Dist").Value
                                    row("Rend") = x2fila.Cells("Rend").Value
                                    row("Rutas") = x2fila.Cells("Rutas").Value
                                    row("Pesos") = x2fila.Cells("Pesos").Value
                                    row("RendEsperado") = x2fila.Cells("RendEsperado").Value
                                    row("GlsEsperado") = x2fila.Cells("GlsEsperado").Value
                                    row("Desviacion") = x2fila.Cells("Desviacion").Value
                                    row("Glosa") = x2fila.Cells("Glosa").Value
                                    row("Estado") = x2fila.Cells("Estado").Value
                                    row("UsuarioCrea") = x2fila.Cells("UsuarioCrea").Value
                                    row("FechaCrea") = x2fila.Cells("FechaCrea").Value
                                    row("UsuarioModif") = x2fila.Cells("UsuarioModif").Value
                                    row("FechaModif") = x2fila.Cells("FechaModif").Value
                                    dst.Tables("TablaInforme").Rows.Add(row)
                                Next
                            End If
                        Next
                    Next
                Next
            Next
            griData.DataSource = dst
            griData.DataBind()
            If griData.Rows.Count > 0 Then
                Exportar_Excel(griData)
            Else
                Throw New Exception("No existen filas a exportar")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub btnExporta1_Click(sender As Object, e As EventArgs) Handles btnExporta1.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            Dim objXls As Excel.Application
            Dim objWorkbook As Excel.Workbook
            Dim objWorkSheet As Excel.Worksheet
            objXls = New Excel.Application
            Dim FileToCopy As String
            Dim PathFile As String

            If grid_ListadoTanqueo.Rows.Count > 0 Then
                FileToCopy = Application.StartupPath & "\PLANTILLAS_SGI\Plantilla_Combustible.xlt"
                PathFile = Application.StartupPath & "\" & "Combustible.xls"
                If System.IO.File.Exists(FileToCopy) = True And System.IO.File.Exists(PathFile) = True Then
                    System.IO.File.SetAttributes(PathFile, IO.FileAttributes.Archive + IO.FileAttributes.Normal)
                    System.IO.File.Copy(FileToCopy, PathFile, True)
                    System.IO.File.SetAttributes(PathFile, IO.FileAttributes.Archive + IO.FileAttributes.Normal)
                Else
                    If System.IO.File.Exists(FileToCopy) = True Then
                        System.IO.File.Copy(FileToCopy, PathFile, True)
                        System.IO.File.SetAttributes(PathFile, IO.FileAttributes.Archive + IO.FileAttributes.Normal)
                    Else
                        Throw New Exception("No se encontro el archivo de Plantilla, Consulte con Soporte")
                    End If
                End If
                ' Creamos una variable para guardar la cultura actual
                Dim OldCultureInfo As System.Globalization.CultureInfo = _
                System.Threading.Thread.CurrentThread.CurrentCulture
                'Crear una cultura standard (en-US) inglés estados unidos
                System.Threading.Thread.CurrentThread.CurrentCulture = _
                New System.Globalization.CultureInfo("es-PE")
                objWorkbook = objXls.Workbooks.Open(PathFile)
                objWorkSheet = objXls.Worksheets(1)
                objWorkSheet.Name = "Combustible"
                Dim ln_Fila As Integer = 1
                For Each fila As UltraGridRow In grid_ListadoTanqueo.Rows
                    For Each band As UltraGridChildBand In fila.ChildBands
                        For Each xfila As UltraGridRow In band.Rows
                            For Each band2 As UltraGridChildBand In xfila.ChildBands
                                If band2.Rows.Count = 0 Then
                                    'Aquí ingresamos los detalles del tracto
                                    objWorkSheet.Cells(ln_Fila + 7, 2) = fila.Cells("Placa").Value
                                    'Aquí ingresamos los detalles del viaje
                                    objWorkSheet.Cells(ln_Fila + 7, 3) = xfila.Cells("CodViaje").Value
                                    objWorkSheet.Cells(ln_Fila + 7, 4) = xfila.Cells("FechaViaje").Value
                                    objWorkSheet.Cells(ln_Fila + 7, 5) = xfila.Cells("Carreta").Value
                                    objWorkSheet.Cells(ln_Fila + 7, 6) = xfila.Cells("Piloto").Value
                                    objWorkSheet.Cells(ln_Fila + 7, 7) = xfila.Cells("Copiloto").Value
                                    objWorkSheet.Cells(ln_Fila + 7, 8) = xfila.Cells("Ruta").Value
                                    objWorkSheet.Cells(ln_Fila + 7, 9) = xfila.Cells("Peso").Value
                                    objWorkSheet.Cells(ln_Fila + 7, 10) = xfila.Cells("KM").Value
                                    objWorkSheet.Cells(ln_Fila + 7, 11) = xfila.Cells("Dist").Value
                                    'Aquí ingresamos los detalles de los tanqueos
                                    objWorkSheet.Cells(ln_Fila + 7, 12) = ""
                                    objWorkSheet.Cells(ln_Fila + 7, 13) = ""
                                    objWorkSheet.Cells(ln_Fila + 7, 14) = ""
                                    objWorkSheet.Cells(ln_Fila + 7, 15) = ""
                                    objWorkSheet.Cells(ln_Fila + 7, 16) = ""
                                    objWorkSheet.Cells(ln_Fila + 7, 17) = ""
                                    objWorkSheet.Cells(ln_Fila + 7, 18) = ""
                                    objWorkSheet.Cells(ln_Fila + 7, 19) = ""
                                    objWorkSheet.Cells(ln_Fila + 7, 20) = ""
                                    objWorkSheet.Cells(ln_Fila + 7, 21) = ""
                                    objWorkSheet.Cells(ln_Fila + 7, 22) = ""
                                    objWorkSheet.Cells(ln_Fila + 7, 23) = ""
                                    objWorkSheet.Cells(ln_Fila + 7, 24) = ""
                                    objWorkSheet.Cells(ln_Fila + 7, 25) = ""
                                    objWorkSheet.Cells(ln_Fila + 7, 26) = ""
                                    objWorkSheet.Cells(ln_Fila + 7, 27) = ""
                                    objWorkSheet.Cells(ln_Fila + 7, 28) = ""
                                    objWorkSheet.Cells(ln_Fila + 7, 29) = ""
                                    objWorkSheet.Cells(ln_Fila + 7, 30) = ""
                                    objWorkSheet.Cells(ln_Fila + 7, 31) = ""
                                    objWorkSheet.Cells(ln_Fila + 7, 32) = ""
                                    objWorkSheet.Cells(ln_Fila + 7, 33) = ""
                                    objWorkSheet.Cells(ln_Fila + 7, 34) = ""
                                    objWorkSheet.Cells(ln_Fila + 7, 35) = ""
                                    'Aumento en uno la fila
                                    ln_Fila = ln_Fila + 1
                                Else
                                    For Each x2fila As UltraGridRow In band2.Rows
                                        'Aquí ingresamos los detalles del tracto
                                        objWorkSheet.Cells(ln_Fila + 7, 2) = fila.Cells("Placa").Value
                                        'Aquí ingresamos los detalles del viaje
                                        objWorkSheet.Cells(ln_Fila + 7, 3) = xfila.Cells("CodViaje").Value
                                        objWorkSheet.Cells(ln_Fila + 7, 4) = xfila.Cells("FechaViaje").Value
                                        objWorkSheet.Cells(ln_Fila + 7, 5) = xfila.Cells("Carreta").Value
                                        objWorkSheet.Cells(ln_Fila + 7, 6) = xfila.Cells("Piloto").Value
                                        objWorkSheet.Cells(ln_Fila + 7, 7) = xfila.Cells("Copiloto").Value
                                        objWorkSheet.Cells(ln_Fila + 7, 8) = xfila.Cells("Ruta").Value
                                        objWorkSheet.Cells(ln_Fila + 7, 9) = xfila.Cells("Peso").Value
                                        objWorkSheet.Cells(ln_Fila + 7, 10) = xfila.Cells("KM").Value
                                        objWorkSheet.Cells(ln_Fila + 7, 11) = xfila.Cells("Dist").Value
                                        'Aquí ingresamos los detalles de los tanqueos
                                        objWorkSheet.Cells(ln_Fila + 7, 12) = x2fila.Cells("NroVale").Value
                                        objWorkSheet.Cells(ln_Fila + 7, 13) = x2fila.Cells("FechaTanqueo").Value
                                        objWorkSheet.Cells(ln_Fila + 7, 14) = x2fila.Cells("Grifo").Value
                                        objWorkSheet.Cells(ln_Fila + 7, 15) = x2fila.Cells("Referencia").Value
                                        objWorkSheet.Cells(ln_Fila + 7, 16) = x2fila.Cells("LugTanqueo").Value
                                        objWorkSheet.Cells(ln_Fila + 7, 17) = x2fila.Cells("Kilometraje").Value
                                        objWorkSheet.Cells(ln_Fila + 7, 18) = x2fila.Cells("IndTanqueo").Value
                                        objWorkSheet.Cells(ln_Fila + 7, 19) = x2fila.Cells("CantidadGls").Value
                                        objWorkSheet.Cells(ln_Fila + 7, 20) = x2fila.Cells("Material").Value
                                        objWorkSheet.Cells(ln_Fila + 7, 21) = x2fila.Cells("Cons").Value
                                        objWorkSheet.Cells(ln_Fila + 7, 22) = x2fila.Cells("Dist").Value
                                        objWorkSheet.Cells(ln_Fila + 7, 23) = x2fila.Cells("Rend").Value
                                        objWorkSheet.Cells(ln_Fila + 7, 24) = x2fila.Cells("Rutas").Value
                                        objWorkSheet.Cells(ln_Fila + 7, 25) = x2fila.Cells("Pesos").Value
                                        objWorkSheet.Cells(ln_Fila + 7, 26) = x2fila.Cells("RendEsperado").Value
                                        objWorkSheet.Cells(ln_Fila + 7, 27) = x2fila.Cells("GlsEsperado").Value
                                        objWorkSheet.Cells(ln_Fila + 7, 28) = x2fila.Cells("Desviacion").Value
                                        objWorkSheet.Cells(ln_Fila + 7, 29) = x2fila.Cells("Glosa").Value
                                        objWorkSheet.Cells(ln_Fila + 7, 30) = x2fila.Cells("Credito").Value
                                        objWorkSheet.Cells(ln_Fila + 7, 31) = x2fila.Cells("Estado").Value
                                        objWorkSheet.Cells(ln_Fila + 7, 32) = x2fila.Cells("UsuarioCrea").Value
                                        objWorkSheet.Cells(ln_Fila + 7, 33) = x2fila.Cells("FechaCrea").Value
                                        objWorkSheet.Cells(ln_Fila + 7, 34) = x2fila.Cells("UsuarioModif").Value
                                        objWorkSheet.Cells(ln_Fila + 7, 35) = x2fila.Cells("FechaModif").Value
                                        'Agregamos uno a la fila
                                        ln_Fila = ln_Fila + 1
                                    Next
                                End If
                            Next
                        Next
                    Next
                Next

                System.IO.File.SetAttributes(PathFile, IO.FileAttributes.ReadOnly)
                objXls.Visible = True

                objWorkSheet = Nothing
                objWorkbook = Nothing
                objXls = Nothing
                'Restauramos la cultura original
                System.Threading.Thread.CurrentThread.CurrentCulture = OldCultureInfo
            Else
                mensajeEmergente.Problema("No existen filas a exportar", False)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub btnExpande1_Click(sender As Object, e As EventArgs) Handles btnExpande1.Click
        grid_ListadoTanqueo.Rows.CollapseAll(True)
    End Sub

    Private Sub btnExpande2_Click(sender As Object, e As EventArgs) Handles btnExpande2.Click
        btnExpande3.PerformClick()
        For i As Integer = 0 To grid_ListadoTanqueo.Rows.Count - 1
            For Each aChildBand1 As UltraGridChildBand In grid_ListadoTanqueo.Rows(i).ChildBands
                For x As Integer = 0 To aChildBand1.Rows.Count - 1
                    aChildBand1.Rows(x).CollapseAll()
                Next
            Next
        Next
    End Sub

    Private Sub btnExpande3_Click(sender As Object, e As EventArgs) Handles btnExpande3.Click
        grid_ListadoTanqueo.Rows.ExpandAll(True)
    End Sub

    Private Sub btnActualizaRend_Click(sender As Object, e As EventArgs) Handles btnActualizaRend.Click
        Try
            ' Carga de Rutas
            oeRuta = New e_Ruta
            oeRuta.TipoOperacion = "D"
            leRuta = olRuta.Listar(oeRuta)
            ' Carga de Zona D2
            oeZonaD2 = New e_ZonaCombustible
            leZonaD2 = New List(Of e_ZonaCombustible)
            oeZonaD2.TipoOperacion = "D"
            leZonaD2 = olZonaD2.Listar(oeZonaD2)
            ' Carga de Rendimientos
            oeRendimientoCombustible = New e_RendimientoCombustible
            leRendimientoCombustible = New List(Of e_RendimientoCombustible)
            oeRendimientoCombustible.Id = ""
            oeRendimientoCombustible.IdTipoVehiculo = ""
            oeRendimientoCombustible.IdFlota = ""
            leRendimientoCombustible = olRendimientoCombustible.Listar(oeRendimientoCombustible)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_ListadoTanqueo_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles grid_ListadoTanqueo.BeforeRowsDeleted
        e.Cancel = True
    End Sub

#End Region

#Region "Seguimiento y Operaciones"

    Public Function SeguimientoCombustible(ByVal IdViaje As String, _
                                        ByVal CodViaje As String, _
                                        ByVal IdTracto As String, _
                                        ByVal Placa As String, _
                                        ByVal IdPiloto As String, _
                                        ByVal FechaViaje As Date, _
                                        ByVal Piloto As String, _
                                        ByVal KmTractoOrigen As String, _
                                        ByVal KmTractoDestino As String) As Boolean
        Try
            Operacion = "Nuevo"
            oeRegConsumoCombustible = New e_RegistroConsumoCombustible
            Inicializar()
            ctrNuevo = False
            cboVehiculo.ReadOnly = True
            oeRegConsumoCombustible.IdViaje = IdViaje
            txtViaje.Text = CodViaje
            cboVehiculo.Value = IdTracto
            oeRegConsumoCombustible.IdVehiculo = cboVehiculo.Value
            decOdometro.Value = ObtenerOdometro(cboVehiculo.Value)
            oeRegConsumoCombustible.PlacaVeh = Placa
            oeRegConsumoCombustible.IdPiloto = IdPiloto
            txtPiloto.Text = Piloto
            fecFechaTanqueo.Value = FechaViaje
            oeRegConsumoCombustible.FechaTanqueo = fecFechaTanqueo.Value
            dtp_FecViaje.Value = FechaViaje
            oeRegConsumoCombustible.FechaViaje = dtp_FecViaje.Value
            SOrigen = KmTractoOrigen
            SDestino = KmTractoDestino
            ctrNuevo = False
            lblRango.Visible = True
            lblRango.Text = "<" & SOrigen & " - " & SDestino & ">"
            gbeConsultar.Expanded = False
            oeRegConsumoCombustible.UsuarioCreacion = gUsuarioSGI.Id
            oeRegConsumoCombustible.TipoOperacion = "I"
            oeRegConsumoCombustible.Activo = True
            ag_Operacion.Enabled = True
            ag_Datos.Enabled = True
            ag_DatosGrifo.Enabled = True
            MostrarTabs(1, ficConCombustible, 1)

            MostrarTabs(1, ficConCombustible, 1)

            MyBase.Nuevo()
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Public Function SeguimientoCombustibleEditar(ByVal Id As String, _
                                            ByVal KmTractoOrigen As String, _
                                            ByVal KmTractoDestino As String, _
                                            ByVal FechaViaje As Date, _
                                            ByVal Estado As String) As Boolean
        Try
            Operacion = "Editar"
            oeRegConsumoCombustible = New e_RegistroConsumoCombustible
            ctrEditar = True
            Inicializar()
            If ctrEditar Then
                oeRegConsumoCombustible.Id = Id
                dtp_FecViaje.Value = FechaViaje
                SOrigen = KmTractoOrigen
                SDestino = KmTractoDestino
                lblRango.Visible = True
                lblRango.Text = "<" & SOrigen & " - " & SDestino & ">"

                If Estado = "PAR" Or Estado = "FAC" Then
                    ag_Operacion.Enabled = False
                    Me.chk_Credito.Enabled = False
                    Me.cmb_TipoCombustible.Enabled = False
                    Me.nd_CantGalones.Enabled = False
                    Me.txt_NroVale.Enabled = False
                    Me.nd_PrecioUnitario.Enabled = False
                    ag_DatosGrifo.Enabled = False
                Else
                    ag_Operacion.Enabled = True
                    Me.chk_Credito.Enabled = True
                    Me.cmb_TipoCombustible.Enabled = True
                    Me.nd_CantGalones.Enabled = True
                    Me.txt_NroVale.Enabled = True
                    Me.nd_PrecioUnitario.Enabled = True
                    ag_DatosGrifo.Enabled = True
                End If
                ctrNuevo = False
            End If

            decStock.Visible = VerISL.Checked
            etiStock.Visible = VerISL.Checked
            eti_Galones.Visible = VerISL.Checked
            txt_NroVale.ReadOnly = VerISL.Checked
            chk_Credito.Enabled = Not (VerISL.Checked)
            MyBase.Editar()

            oeRegConsumoCombustible.TipoOperacion = 2
            oeRegConsumoCombustible = olRegConsumoCombustible.Obtener(oeRegConsumoCombustible)

            txtViaje.Text = oeRegConsumoCombustible.CodViaje
            cboVehiculo.Value = oeRegConsumoCombustible.IdVehiculo
            fecFechaTanqueo.Value = oeRegConsumoCombustible.FechaTanqueo
            oeRegConsumoCombustible.FechaViaje = dtp_FecViaje.Value
            nd_KmTanqueo.Value = oeRegConsumoCombustible.KilometrosTanqueo
            nd_CantGalones.Value = oeRegConsumoCombustible.CantidadGalon
            txt_NroVale.Text = oeRegConsumoCombustible.NroVale
            nd_PrecioUnitario.Value = oeRegConsumoCombustible.PrecioUnitario
            txtPiloto.Text = oeRegConsumoCombustible.Piloto
            txtPiloto.Tag = oeRegConsumoCombustible.IdPiloto
            chk_Credito.Checked = oeRegConsumoCombustible.IndCredito
            cboGrifo.Value = oeRegConsumoCombustible.IdGrifo
            cboLugar.Value = oeRegConsumoCombustible.IdLugar
            cboDireccion.Value = oeRegConsumoCombustible.IdDireccion
            opt_IndTanqueo.CheckedIndex = IIf(oeRegConsumoCombustible.IndTanqueo = True, 0, 1)
            decOdometro.Value = ObtenerOdometro(oeRegConsumoCombustible.IdVehiculo)
            cmb_TipoCombustible.Value = oeRegConsumoCombustible.IdMaterial
            gbeConsultar.Expanded = False
            oeRegConsumoCombustible.TipoOperacion = "A"
            MostrarTabs(1, ficConCombustible, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Public Function SeguimientoCombustibleEliminar(ByVal Id As String, ByVal Estado As String) As Boolean
        Try
            oeRegConsumoCombustible.Id = Id
            oeRegConsumoCombustible.TipoOperacion = 2
            oeRegConsumoCombustible = olRegConsumoCombustible.Obtener(oeRegConsumoCombustible)

            If oeRegConsumoCombustible.Activo And Estado = "SIN" Then
                If MessageBox.Show("Esta seguro de eliminar el Registro de Consumo de Combustible: ?", _
                         "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    oeRegConsumoCombustible.TipoOperacion = "E"
                    olRegConsumoCombustible.Eliminar(oeRegConsumoCombustible)
                    Consultar(True)
                End If
            Else
                Throw New Exception("El tanqueo no se puede eliminar por su estado:" & Estado)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Public Function ValidaViajeTanqueo(Id As String) As Boolean
        Try
            oeViaje = New e_Viaje
            olViaje = New l_Operacion
            oeViaje.TipoOperacion = "P"
            oeViaje.Id = Id.Trim
            If oeViaje.Id <> "" Then
                oeViaje = olViaje.ObtenerViaje(oeViaje)
                If oeViaje.Id.Trim = "" Then Throw New Exception("El Viaje ha Sido Eliminado. Verificar")
                If oeViaje.IdCopiloto <> "" Then Throw New Exception("El Viaje esta Siendo Editado. No Puede Tanquear")
                If oeViaje.Estado = gNombreEstadoCancelada Then Throw New Exception("El Viaje ha Sido Cancelado. No Puede Tanquear")
            End If

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Importación de Tanqueos"

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If grid_RegTanqNoAsoc.Rows.Count > 0 Then
                Dim oeRegConsumoMasivo As New e_RegistroConsumoCombustible
                Dim Total As Double = 0
                oeRegConsumoMasivo.TipoOperacion = "I"
                oeRegConsumoMasivo.Ind_Masivo = True
                oeRegConsumoMasivo.ListaRegistrosConsumoD2 = lstRegConsumoCombustible
                oeRegConsumoMasivo.UsuarioCreacion = gUsuarioSGI.Id
                ObtenerStockUltPrecioS(CboGrifoS.Value, CboDireccionS.Value)
                If nd_PrecioUnitarioS.Value = 0 Then Throw New Exception("Error en el Costo del Diesel. Verificar")
                For Each oe As e_RegistroConsumoCombustible In lstRegConsumoCombustible
                    If oe.IdDireccion = CboDireccionS.Value And oe.IdGrifo = CboGrifoS.Value Then
                        oe.PrecioUnitario = nd_PrecioUnitarioS.Value
                        Total += oe.CantidadGalon * nd_PrecioUnitarioS.Value
                    End If
                Next
                Dim fechaActual As Date = ObtenerFechaServidor()
                oeOrden = New e_Orden
                For Each oe As e_RegistroConsumoCombustible In oeRegConsumoMasivo.ListaRegistrosConsumoD2
                    oe.lstInventario = New List(Of e_Inventario)
                    IdSubAlmacen = ""
                    oeCombo = New e_Combo
                    oeCombo.Tipo = 4
                    oeCombo.Nombre = oe.IdGrifo
                    oeCombo.Descripcion = oe.IdDireccion
                    If SubAlmDiesel.Contains(oeCombo) Then
                        oeCombo = SubAlmDiesel.Item(SubAlmDiesel.IndexOf(oeCombo))
                    Else
                        Throw New Exception("No existe el SubAlmacen. Verificar")
                    End If
                    IdSubAlmacen = oeCombo.Id
                    oe.lstInventario = Inventario(oe, False, fechaActual)
                Next
                If Total > 0 Then
                    AsientoConsumo(oeRegConsumoMasivo, 0)
                    oeOrden.Total = Total
                End If
                oeRegConsumoMasivo.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeOrden.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeRegConsumoCombustible = olRegConsumoCombustible.Guardar(oeRegConsumoMasivo, oeOrden)
                mensajeEmergente.Confirmacion("Los Tanqueos No asociado importados fueron grabados satisfactoriamente", True)
                lstRegConsumoCombustible.Clear()
                grid_RegTanqNoAsoc.DataBind()
            Else
                Throw New Exception("Ningun Tanqueo se ha importado, Importe tanqueos no asociados al sistema")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        Try
            Dim PathFilePTRA As String = ""
            OpenFileDialog1 = CargaDatosOpenFileDialog()

            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

                PathFilePTRA = OpenFileDialog1.FileName
                Dim objXls As Excel.Application
                Dim objWorkbook As Excel.Workbook
                Dim objWorkSheet As Excel.Worksheet
                Dim ObjExcel() As Object = Nothing
                Dim men As String = ""
                objXls = CreateObject("Excel.Application")
                objWorkbook = objXls.Workbooks.Open(PathFilePTRA)
                objXls.Visible = False
                objWorkSheet = objXls.Worksheets(1)
                lstRegConsumoCombustible.Clear()
                Dim FechaActual As Date = ObtenerFechaServidor()
                For ln_Fila As Integer = 1 To 100000
                    If (Not objWorkSheet.Cells(ln_Fila + 1, 1).Value Is Nothing) Then
                        oeRegConsumoCombustible = New e_RegistroConsumoCombustible
                        With oeRegConsumoCombustible
                            .TipoOperacion = "I"
                            .Seleccion = False
                            .IdViaje = String.Empty
                            .CodViaje = String.Empty
                            .IdVehiculo = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 3).Value)
                            .FechaTanqueo = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 4).Value)
                            .PlacaVeh = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 5).Value)
                            .KilometrosTanqueo = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 6).Value)
                            .CantidadGalon = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 7).Value)
                            .IndTanqueo = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 8).Value)
                            .NroVale = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 9).Value)
                            .PrecioUnitario = Convert.ToDouble(objWorkSheet.Cells(ln_Fila + 1, 10).Value)
                            .IndCredito = True 'Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 11).Value)
                            .IdDireccion = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 26).Value)
                            .NomDireccion = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 27).Value)
                            .IdLugar = String.Empty
                            .Activo = True
                            .UsuarioCreacion = gUsuarioSGI.Id
                            .IdRegistroInventario = String.Empty
                            .IdMaterial = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 16).Value)
                            .SaldoGls = 0 'Convert.ToDouble(objWorkSheet.Cells(ln_Fila + 1, 17).Value)
                            .Estado = "SIN"
                            .Id = String.Empty
                            .IdPiloto = String.Empty
                            .IdGrifo = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 22).Value)
                            .NomGrifo = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 23).Value)
                            .Piloto = String.Empty
                            .CodMaterial = String.Empty
                            .Material = String.Empty
                            .FechaViaje = #1/1/1901#
                            .FechaCreacion = FechaActual
                            lstRegConsumoCombustible.Add(oeRegConsumoCombustible)
                        End With
                    Else
                        Exit For
                    End If
                Next

                If ValidarNrosValeImportados() Then Exit Sub
                If ValidarPlacas() Then Exit Sub
                If ValidarTanqueosMaximos() Then Exit Sub

                grid_RegTanqNoAsoc.DataSource = lstRegConsumoCombustible
                grid_RegTanqNoAsoc.DataBind()
                If Not objXls Is Nothing Then
                    objWorkbook.Saved = True
                    objWorkbook.Close()
                    objXls.Quit()
                End If
                OpenFileDialog1.Dispose()
                ObjExcel = Nothing
                objWorkSheet = Nothing
                objWorkbook = Nothing
                objXls = Nothing
                Dim proceso() As Process
                proceso = Process.GetProcessesByName("EXCEL")
                If proceso.Length > 0 Then
                    proceso(proceso.Length - 1).Kill()
                End If

            Else
                OpenFileDialog1.Dispose()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Sub GenerarLog(ByVal ContenidoArchivo As String)
        Dim strStreamW As Stream = Nothing
        Dim strStreamWriter As StreamWriter = Nothing
        Dim PathArchivo As String

        Try
            If Not Directory.Exists("C:\TanqueosReg") Then
                Directory.CreateDirectory("C:\TanqueosReg")
            End If
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            PathArchivo = "C:\TanqueosReg\TanqueosReg" & Format(Date.Now, "ddMMyyyy_hhmm") & ".txt" ' Se determina el nombre del archivo con la fecha actual

            If File.Exists(PathArchivo) Then
                strStreamW = File.Open(PathArchivo, FileMode.Open)
            Else
                strStreamW = File.Create(PathArchivo)
            End If
            strStreamWriter = New StreamWriter(strStreamW, System.Text.Encoding.Default) ' tipo de codificacion para escritura
            strStreamWriter.Write(ContenidoArchivo) 'escribimos en el archivo
            strStreamWriter.Flush()
            strStreamWriter.Close() ' cerramos
            Process.Start(PathArchivo, "")
        Catch ex As Exception
            MsgBox("Error al Guardar la informacion en el archivo. " & ex.ToString, MsgBoxStyle.Critical, Application.ProductName)
            strStreamWriter.Close() ' cerramos
        End Try
    End Sub

    Public Function ValidarPlacas() As Boolean
        Try
            Dim Vales As String = String.Empty, Msg As String = "", cont As Integer = 0
            For Each obj As e_RegistroConsumoCombustible In lstRegConsumoCombustible
                Dim Placa As New e_Vehiculo
                Placa.Id = obj.IdVehiculo
                Placa.TipoOperacion = "A"
                Placa.Motriz = 1
                Placa.Activo = True
                Placa = olVehiculo.Obtener(Placa)
                If Placa.Id = "" Then
                    cont = cont + 1
                End If
                If Not obj.CantidadGalon > 0 And obj.CantidadGalon < 250 Then
                    cont = cont + 1
                End If
                If obj.KilometrosTanqueo < 0 Then
                    cont = cont + 1
                End If
            Next
            Msg = "Se han encontrado vehículos inexistentes, cantidad de gls o km no validos; en la lista de importación. Favor de revisar"
            If cont > 0 Then
                mensajeEmergente.Problema(Msg)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarNrosValeImportados() As Boolean
        Try
            Dim Vales As String = String.Empty, Msg As String = "", cont As Integer = 0
            For Each obj As e_RegistroConsumoCombustible In lstRegConsumoCombustible
                Dim oeRegConsumoI As New e_RegistroConsumoCombustible
                oeRegConsumoI.TipoOperacion = 5
                oeRegConsumoI.Id = obj.IdGrifo
                oeRegConsumoI.IdVehiculo = obj.NroVale
                oeRegConsumoI = olRegConsumoCombustible.Obtener(oeRegConsumoI)
                If oeRegConsumoI.IdGrifo <> "" Then
                    cont += 1
                    If cont = 1 Then
                        Vales &= "" & oeRegConsumoI.NroVale & " : " & oeRegConsumoI.NomGrifo
                    ElseIf cont > 1 Then
                        Vales &= Environment.NewLine & oeRegConsumoI.NroVale & " : " & oeRegConsumoI.NomGrifo
                    End If
                End If
            Next
            Msg = "Se encontraron tanqueos con tickets  ya registrados, " & _
            "verifique el archivo importado y vuelva a importar." & Environment.NewLine & "¿Desea generar un log para vizualizar los tanqueos mencionados?"

            If Vales.Length > 0 Then
                If MessageBox.Show(Msg, "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    GenerarLog(Vales)
                End If
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarTanqueosMaximos() As Boolean
        Try
            If lstRegConsumoCombustible.Count() > 250 Then
                lstRegConsumoCombustible.Clear()
                mensajeEmergente.Problema("Solo se permiten importar como máximo 250 tanqueos")
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Operaciones del Surtidor"

    Private Sub TiempoManguera_Tick(sender As Object, e As EventArgs) Handles TiempoManguera.Tick
        Try
            ActualizaManguera()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ActualizaManguera()
        Try
            If Operacion = "Nuevo" Then
                Dim oeSurtidor As New e_Surtidor
                Dim olSurtidor As New l_Surtidor
                Dim leSurtidor As New List(Of e_Surtidor)
                oeSurtidor.TipoOperacion = "M"
                leSurtidor = olSurtidor.Listar(oeSurtidor)
                Dim FechaActual As Date = ObtenerFechaServidor()

                If OptManguera1.Checked = True Then
                    If leSurtidor.Where(Function(i) i.Cara = "1").Count > 0 Then
                        fecFechaTanqueo.Value = FechaActual
                        nd_CantGalones.Value = leSurtidor.Where(Function(i) i.Cara = "1")(0).Galones
                        oeRegConsumoCombustible.CodigoSurtidor = leSurtidor.Where(Function(i) i.Cara = "1")(0).Numero
                        Exit Sub
                    Else
                        fecFechaTanqueo.Value = FechaActual
                        nd_CantGalones.Value = 0.0
                        oeRegConsumoCombustible.CodigoSurtidor = ""
                    End If
                End If

                If OptManguera2.Checked = True Then
                    If leSurtidor.Where(Function(i) i.Cara = "2").Count > 0 Then
                        fecFechaTanqueo.Value = FechaActual
                        nd_CantGalones.Value = leSurtidor.Where(Function(i) i.Cara = "2")(0).Galones
                        oeRegConsumoCombustible.CodigoSurtidor = leSurtidor.Where(Function(i) i.Cara = "2")(0).Numero
                        Exit Sub
                    Else
                        fecFechaTanqueo.Value = FechaActual
                        nd_CantGalones.Value = 0.0
                        oeRegConsumoCombustible.CodigoSurtidor = ""
                    End If
                End If

                If OptNinguno.Checked Then
                    oeRegConsumoCombustible.CodigoSurtidor = ""
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub OptManguera1_CheckedChanged(sender As Object, e As EventArgs) Handles OptManguera1.CheckedChanged
        Try
            If OptManguera1.Checked = True Then
                fecFechaTanqueo.Enabled = False
                nd_CantGalones.Enabled = False
                cmb_TipoCombustible.Enabled = False
                cmb_TipoCombustible.Value = "1CH000001990"
                PanelManguera.Appearance.BackColor = Color.LightGray
                PanelImagen.Enabled = True
                TxtNumManguera.Text = "D2"
                ActualizaManguera()
            Else
                fecFechaTanqueo.Enabled = True
                nd_CantGalones.Enabled = True
                cmb_TipoCombustible.Enabled = True
                PanelManguera.Appearance.BackColor = Color.WhiteSmoke
                PanelImagen.Enabled = False
                TxtNumManguera.Text = ""
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub OptManguera2_CheckedChanged(sender As Object, e As EventArgs) Handles OptManguera2.CheckedChanged
        Try
            If OptManguera2.Checked = True Then
                fecFechaTanqueo.Enabled = False
                nd_CantGalones.Enabled = False
                cmb_TipoCombustible.Enabled = False
                cmb_TipoCombustible.Value = "1CH000001990"
                PanelManguera.Appearance.BackColor = Color.LightGray
                PanelImagen.Enabled = True
                TxtNumManguera.Text = "D2"
                ActualizaManguera()
            Else
                fecFechaTanqueo.Enabled = True
                nd_CantGalones.Enabled = True
                cmb_TipoCombustible.Enabled = True
                PanelManguera.Appearance.BackColor = Color.WhiteSmoke
                PanelImagen.Enabled = False
                TxtNumManguera.Text = ""
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub OptNinguno_CheckedChanged(sender As Object, e As EventArgs) Handles OptNinguno.CheckedChanged
        Try
            If OptNinguno.Checked = True Then
                fecFechaTanqueo.Enabled = True
                nd_CantGalones.Enabled = True
                cmb_TipoCombustible.Enabled = True
                nd_CantGalones.Value = 0.0
                fecFechaTanqueo.Value = Date.Now()
                oeRegConsumoCombustible.CodigoSurtidor = ""
                PanelManguera.Appearance.BackColor = Color.WhiteSmoke
                PanelImagen.Enabled = False
                TxtNumManguera.Text = ""
            Else
                fecFechaTanqueo.Enabled = False
                nd_CantGalones.Enabled = False
                cmb_TipoCombustible.Enabled = False
                oeRegConsumoCombustible.CodigoSurtidor = ""
                PanelManguera.Appearance.BackColor = Color.WhiteSmoke
                PanelImagen.Enabled = False
                TxtNumManguera.Text = ""
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Sub ObtenerStockUltPrecioS(IdGrifo As String, IdDireccion As String)
        Try
            If Not String.IsNullOrEmpty(IdDireccion) Then
                IdSubAlmacen = ""
                oeCombo = New e_Combo
                oeCombo.Tipo = 4
                oeCombo.Nombre = CboGrifoS.Value
                oeCombo.Descripcion = CboDireccionS.Value
                If SubAlmDiesel.Contains(oeCombo) Then
                    oeCombo = SubAlmDiesel.Item(SubAlmDiesel.IndexOf(oeCombo))
                Else
                    Throw New Exception("No existe el SubAlmacen. Verificar")
                End If
                IdSubAlmacen = oeCombo.Id
                If Not String.IsNullOrEmpty(oeCombo.Id) Then
                    oeInventario = New e_Inventario
                    oeInventario.TipoOperacion = "5"
                    oeInventario.IdSubAlmacen = oeCombo.Id
                    oeInventario.IdMaterial = "1CH000001990"
                    oeInventario = olInventario.Obtener(oeInventario)
                    decSotckS.Value = oeInventario.CantidadFinal
                    nd_PrecioUnitarioS.Value = oeInventario.ValorUnitario
                Else
                    decSotckS.Value = 0
                    nd_PrecioUnitarioS.Value = 0.0
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CboVehiculoS1_ValueChanged(sender As Object, e As EventArgs) Handles cboVehiculoS1.ValueChanged
        Try
            If cboVehiculoS1.Value <> "" Then
                nd_OdometroS1.Value = ObtenerOdometro(cboVehiculoS1.Value)
            Else
                nd_OdometroS1.Value = 0.0
                txtViajeS1.Value = ""
                txtPilotoS1.Value = ""
                TxT_IdViajeS1.Value = ""
                Txt_IdPilotoS1.Value = ""
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CboVehiculoS2_ValueChanged(sender As Object, e As EventArgs) Handles CboVehiculoS2.ValueChanged
        Try
            If CboVehiculoS2.Value <> "" Then
                nd_OdometroS2.Value = ObtenerOdometro(CboVehiculoS2.Value)
            Else
                nd_OdometroS2.Value = 0.0
                TxtViajeS2.Value = ""
                TxtPilotoS2.Value = ""
                TxT_IdViajeS2.Value = ""
                Txt_IdPilotoS2.Value = ""
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    'Private Sub nd_KmTanqueoS1_ValueChanged(sender As Object, e As EventArgs) Handles nd_KmTanqueoS1.ValueChanged
    '    Try
    '        If CboVehiculoS1.Value = "" Then
    '            nd_KmTanqueoS1.Value = 0.0
    '            CboVehiculoS1.Focus()
    '            Throw New Exception("Seleccione un vehículo antes de ingresar kilometraje")
    '        End If
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    End Try
    'End Sub

    'Private Sub nd_KmTanqueoS2_ValueChanged(sender As Object, e As EventArgs) Handles nd_KmTanqueoS2.ValueChanged
    '    Try
    '        If CboVehiculoS2.Value = "" Then
    '            nd_KmTanqueoS2.Value = 0.0
    '            CboVehiculoS2.Focus()
    '            Throw New Exception("Seleccione un vehículo antes de ingresar kilometraje")
    '        End If
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    Private Sub nd_KmTanqueoS1_Validated(sender As Object, e As EventArgs) Handles nd_KmTanqueoS1.Validated
        Try
            If cboVehiculoS1.Value <> "" Then
                If ctrTanqueoS1 = False Then
                    If nd_KmTanqueoS1.Value > 0 Then
                        VerificacionKilometrajeS1()
                    End If
                End If
            Else
                nd_KmTanqueoS1.Value = 0.0
                Throw New Exception("Seleccione un Vehiculo, Antes de Ingresar un Kilometraje")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub nd_KmTanqueoS2_Validated(sender As Object, e As EventArgs) Handles nd_KmTanqueoS2.Validated
        Try
            If CboVehiculoS2.SelectedIndex <> -1 Then
                If ctrTanqueoS2 = False Then
                    If nd_KmTanqueoS2.Value > 0 Then
                        VerificacionKilometrajeS2()
                    End If
                End If
            Else
                nd_KmTanqueoS2.Value = 0.0
                Throw New Exception("Seleccione un Vehiculo, Antes de Ingresar un Kilometraje")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Sub VerificacionKilometrajeS1()
        Try
            oeSeguimiento = New e_Seguimiento
            oeSeguimiento.TipoOperacion = 1
            oeSeguimiento.Activo = True
            oeSeguimiento.IdVehiculo = cboVehiculoS1.Value
            oeSeguimiento.CantKm = CStr(nd_KmTanqueoS1.Value)
            oeSeguimiento.IndLlegadaDestino = 1
            oeSeguimiento = olSeguimiento.ObtenerRango(oeSeguimiento)

            If oeSeguimiento.CodViaje <> Nothing Then
                txtViajeS1.Text = oeSeguimiento.CodViaje
                txtPilotoS1.Text = oeSeguimiento.Piloto
                txtPilotoS1.Tag = oeSeguimiento.IdPiloto
                TxT_IdViajeS1.Value = oeSeguimiento.Id
                Txt_IdPilotoS1.Value = oeSeguimiento.IdPiloto
                dtp_FechaViajeS1.Value = CDate("01/01/1901")
            Else
                mensajeEmergente.Problema("El kilometraje ingresado no coincide con ningun viaje.", True)
                nd_KmTanqueoS1.Value = 0.0
                txtViajeS1.Text = String.Empty
                txtPilotoS1.Text = String.Empty
                TxT_IdViajeS1.Value = String.Empty
                Txt_IdPilotoS1.Value = String.Empty
                dtp_FechaViajeS1.Value = "01/01/1901"
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub VerificacionKilometrajeS2()
        Try
            oeSeguimiento = New e_Seguimiento
            oeSeguimiento.TipoOperacion = 1
            oeSeguimiento.Activo = True
            oeSeguimiento.IdVehiculo = CboVehiculoS2.Value
            oeSeguimiento.CantKm = CStr(nd_KmTanqueoS2.Value)
            oeSeguimiento.IndLlegadaDestino = 1
            oeSeguimiento = olSeguimiento.ObtenerRango(oeSeguimiento)
            If oeSeguimiento.CodViaje <> Nothing Then
                TxtViajeS2.Text = oeSeguimiento.CodViaje
                TxtPilotoS2.Text = oeSeguimiento.Piloto
                TxtPilotoS2.Tag = oeSeguimiento.IdPiloto
                TxT_IdViajeS2.Value = oeSeguimiento.Id
                Txt_IdPilotoS2.Value = oeSeguimiento.IdPiloto
                dtp_FechaViajeS2.Value = oeSeguimiento.LlegadaDestino
            Else
                mensajeEmergente.Problema("El kilometraje ingresado no coincide con ningun viaje.", True)
                nd_KmTanqueoS2.Value = 0.0
                TxtViajeS2.Text = String.Empty
                TxtPilotoS2.Text = String.Empty
                TxT_IdViajeS2.Value = String.Empty
                Txt_IdPilotoS2.Value = String.Empty
                dtp_FechaViajeS2.Value = CDate("01/01/1901")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub TiempoSurtidor_Tick(sender As Object, e As EventArgs) Handles TiempoSurtidor.Tick
        Try
            ActualizarSurtidores()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub TanquearConSurtidor1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TanquearConSurtidor1ToolStripMenuItem.Click
        Try
            If grid_ListadoTanqueo.ActiveRow.Band.Index = 1 Then
                If grid_ListadoTanqueo.ActiveRow.Cells("CodViaje").Value.ToString.Length > 0 Then
                    Operacion = "Nuevo"
                    LimpiarTanqueos(1)
                    cboVehiculoS1.Value = grid_ListadoTanqueo.ActiveRow.Cells("IdTracto").Value.ToString
                    cboVehiculoS1.Enabled = False
                    ctrTanqueoS1 = True
                    Txt_IdPilotoS1.Value = grid_ListadoTanqueo.ActiveRow.Cells("IdPiloto").Value.ToString
                    txtPilotoS1.Value = grid_ListadoTanqueo.ActiveRow.Cells("Piloto").Value.ToString
                    txtViajeS1.Value = grid_ListadoTanqueo.ActiveRow.Cells("CodViaje").Value.ToString
                    TxT_IdViajeS1.Value = grid_ListadoTanqueo.ActiveRow.Cells("IdViaje").Value.ToString
                    dtp_FechaViajeS1.Value = grid_ListadoTanqueo.ActiveRow.Cells("FechaViaje").Value.ToString
                    ficConCombustible.Tabs(3).Selected = True
                    Opt_IndTanqueoS1.Value = True
                    nd_KmTanqueoS1.Value = 0.0
                    decSotckS.Value = 0
                    nd_PrecioUnitarioS.Value = 0.0
                    ObtenerStockUltPrecioS(CboGrifoS.Value, CboDireccionS.Value)
                    ActualizarSurtidores()
                    nd_KmTanqueoS1.Focus()
                    nd_KmTanqueoS1.SelectAll()
                Else
                    Throw New Exception("Seleccione un viaje válido para tanquear.")
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub TanquearConSurtidor2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TanquearConSurtidor2ToolStripMenuItem.Click
        Try
            If grid_ListadoTanqueo.ActiveRow.Band.Index = 1 Then
                If grid_ListadoTanqueo.ActiveRow.Cells("CodViaje").Value.ToString.Length > 0 Then
                    Operacion = "Nuevo"
                    LimpiarTanqueos(2)
                    CboVehiculoS2.Value = grid_ListadoTanqueo.ActiveRow.Cells("IdTracto").Value.ToString
                    CboVehiculoS2.Enabled = False
                    ctrTanqueoS2 = True
                    Txt_IdPilotoS2.Value = grid_ListadoTanqueo.ActiveRow.Cells("IdPiloto").Value.ToString
                    TxtPilotoS2.Value = grid_ListadoTanqueo.ActiveRow.Cells("Piloto").Value.ToString
                    TxtViajeS2.Value = grid_ListadoTanqueo.ActiveRow.Cells("CodViaje").Value.ToString
                    TxT_IdViajeS2.Value = grid_ListadoTanqueo.ActiveRow.Cells("IdViaje").Value.ToString
                    dtp_FechaViajeS2.Value = grid_ListadoTanqueo.ActiveRow.Cells("FechaViaje").Value.ToString
                    ficConCombustible.Tabs(3).Selected = True
                    Opt_IndTanqueoS2.Value = True
                    nd_KmTanqueoS2.Value = 0.0
                    decSotckS.Value = 0
                    nd_PrecioUnitarioS.Value = 0.0
                    ObtenerStockUltPrecioS(CboGrifoS.Value, CboDireccionS.Value)
                    ActualizarSurtidores()
                    nd_KmTanqueoS2.Focus()
                    nd_KmTanqueoS2.SelectAll()
                Else
                    Throw New Exception("Seleccione un viaje válido para tanquear.")
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub BtnGuardarS1_Click_1(sender As Object, e As EventArgs) Handles BtnGuardarS1.Click
        Try
            nd_CantGalonesS1.Focus()
            If CboVehiculoS1.Value = "" Then Throw New Exception("Seleccione una unidad para el tanqueo.")
            If nd_CantGalonesS1.Value = 0.0 Then Throw New Exception("No se pueden registrar 0.0 galones.")
            If nd_KmTanqueoS1.Value = 0.0 Then Throw New Exception("Ingrese el Km. para el primer tanqueo.")
            If TxT_IdViajeS1.Value = "" Then Throw New Exception("No se encontró viaje para este tanqueo.")
            If ValidaViajeTanqueo(TxT_IdViajeS1.Value) Then
                Dim oeConsumo As New e_RegistroConsumoCombustible
                oeConsumo.IdGrifo = CboGrifoS.Value
                oeConsumo.IdDireccion = CboDireccionS.Value
                oeConsumo.IdVehiculo = CboVehiculoS1.Value
                oeConsumo.IdViaje = TxT_IdViajeS1.Value
                oeConsumo.IdPiloto = Txt_IdPilotoS1.Value
                oeConsumo.FechaViaje = dtp_FechaViajeS1.Value
                oeConsumo.IdMaterial = "1CH000001990"
                oeConsumo.PrecioUnitario = nd_PrecioUnitarioS.Value
                oeConsumo.CantidadGalon = nd_CantGalonesS1.Value
                oeConsumo.FechaTanqueo = dtp_FechaTanqueoS1.Value
                oeConsumo.CodigoSurtidor = TxtCodigoSurtidorS1.Value
                oeConsumo.IndTanqueo = Opt_IndTanqueoS1.Value
                oeConsumo.Perfil = ObtenerPerfilPrincipal.Nombre
                oeConsumo.Ind_Masivo = False
                oeConsumo.Estado = "SIN"
                oeConsumo.SaldoGls = 0.0
                oeConsumo.UsuarioCreacion = gUsuarioSGI.Id
                oeConsumo.KilometrosTanqueo = nd_KmTanqueoS1.Value
                oeConsumo.NroVale = "AUTO"
                oeConsumo.TipoOperacion = "I"
                oeConsumo.FechaCreacion = ObtenerFechaServidor()
                oeConsumo.IndIsl = True
                oeConsumo.GlosaValeTanqueo = txtGlosaTanqueo1.Value
                AsientoConsumo(oeConsumo, 1)
                oeConsumo.lstInventario = New List(Of e_Inventario)
                oeConsumo.lstInventario = Inventario(oeConsumo, True, ObtenerFechaServidor())
                oeConsumo.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeOrden.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeConsumo = olRegConsumoCombustible.Guardar(oeConsumo, oeOrden)
                If oeConsumo.Id Is Nothing Then
                    Throw New Exception("No se registró el tanqueo correctamente.")
                Else
                    oeConsumo.TipoOperacion = 2
                    oeConsumo = olRegConsumoCombustible.Obtener(oeConsumo)
                    If MessageBox.Show("El Consumo de combustible ha sido grabada satisfactoriamente," & vbCrLf & "¿Desea Imprimir el Vale de Consumo?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        ImprimirValeTanqueo(oeConsumo)
                    End If
                End If
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                CboVehiculoS1.Value = ""
                TxtViajeS1.Value = ""
                TxT_IdViajeS1.Value = ""
                TxtPilotoS1.Value = ""
                Txt_IdPilotoS1.Value = ""
                dtp_FechaViajeS1.Value = "01/01/1901"
                nd_KmTanqueoS1.Value = 0.0
                Opt_IndTanqueoS1.Value = True
                ctrTanqueoS1 = False
                txtGlosaTanqueo1.Value = ""
                txtGlosaTanqueo1.Text = ""
                ActualizarSurtidores()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub BtnGuardarS2_Click(sender As Object, e As EventArgs) Handles BtnGuardarS2.Click
        Try
            nd_CantGalonesS2.Focus()
            If CboVehiculoS2.Value = "" Then Throw New Exception("Seleccione una unidad para el tanqueo.")
            If nd_CantGalonesS2.Value = 0.0 Then Throw New Exception("No se pueden registrar 0.0 galones.")
            If nd_KmTanqueoS2.Value = 0.0 Then Throw New Exception("Ingrese el Km. para el primer tanqueo.")
            If TxT_IdViajeS2.Value = "" Then Throw New Exception("No se encontró viaje para este tanqueo.")
            If ValidaViajeTanqueo(TxT_IdViajeS2.Value) Then
                Dim oeConsumo As New e_RegistroConsumoCombustible
                oeConsumo.IdGrifo = CboGrifoS.Value
                oeConsumo.IdDireccion = CboDireccionS.Value
                oeConsumo.IdVehiculo = CboVehiculoS2.Value
                oeConsumo.IdViaje = TxT_IdViajeS2.Value
                oeConsumo.IdPiloto = Txt_IdPilotoS2.Value
                oeConsumo.FechaViaje = dtp_FechaViajeS2.Value
                oeConsumo.IdMaterial = "1CH000001990"
                oeConsumo.PrecioUnitario = nd_PrecioUnitarioS.Value
                oeConsumo.CantidadGalon = nd_CantGalonesS2.Value
                oeConsumo.FechaTanqueo = dtp_FechaTanqueoS2.Value
                oeConsumo.CodigoSurtidor = TxtCodigoSurtidorS2.Value
                oeConsumo.IndTanqueo = Opt_IndTanqueoS2.Value
                oeConsumo.Perfil = ObtenerPerfilPrincipal.Nombre
                oeConsumo.Ind_Masivo = False
                oeConsumo.Estado = "SIN"
                oeConsumo.SaldoGls = 0.0
                oeConsumo.UsuarioCreacion = gUsuarioSGI.Id
                oeConsumo.KilometrosTanqueo = nd_KmTanqueoS2.Value
                oeConsumo.NroVale = "AUTO"
                oeConsumo.TipoOperacion = "I"
                oeConsumo.FechaCreacion = ObtenerFechaServidor()
                oeConsumo.IndIsl = True
                oeConsumo.GlosaValeTanqueo = txtGlosaTanqueo2.Value
                AsientoConsumo(oeConsumo, 1)
                oeConsumo.lstInventario = New List(Of e_Inventario)
                oeConsumo.lstInventario = Inventario(oeConsumo, True, ObtenerFechaServidor())
                oeConsumo.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeOrden.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeConsumo = olRegConsumoCombustible.Guardar(oeConsumo, oeOrden)
                If oeConsumo.Id Is Nothing Then
                    Throw New Exception("No se registró el tanqueo correctamente.")
                Else
                    oeConsumo.TipoOperacion = 2
                    oeConsumo = olRegConsumoCombustible.Obtener(oeConsumo)
                    'Dim oeRegInv As New e_RegistroInventario
                    'Dim olRegInv As New l_RegistroInventario
                    'oeRegInv.TipoOperacion = "F"
                    'If olRegInv.ListarSOrden(oeRegInv).Count > 0 Then
                    '    mensajeEmergente.Confirmacion("El Despacho que Acaba de Guardar ha Generado un Duplicado en la Base de Datos. Favor Comunicarse con Sistemas. " _
                    '                                  + "Enviar Pantallazo con los Datos. Gracias. " _
                    '                                  & oeConsumo.PlacaVeh + " / " + oeConsumo.FechaCreacion + " / " + oeConsumo.NroVale, True)
                    'End If
                    If MessageBox.Show("El Consumo de combustible ha sido grabada satisfactoriamente," & vbCrLf & "¿Desea Imprimir el Vale de Consumo?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        ImprimirValeTanqueo(oeConsumo)
                    End If
                End If
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                CboVehiculoS2.Value = ""
                TxtViajeS2.Value = ""
                TxT_IdViajeS2.Value = ""
                TxtPilotoS2.Value = ""
                Txt_IdPilotoS2.Value = ""
                dtp_FechaViajeS2.Value = "01/01/1901"
                nd_KmTanqueoS2.Value = 0.0
                ctrTanqueoS2 = False
                Opt_IndTanqueoS2.Value = True
                txtGlosaTanqueo2.Value = ""
                txtGlosaTanqueo1.Text = ""
                ActualizarSurtidores()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub BtnLimpiaS1_Click(sender As Object, e As EventArgs) Handles BtnLimpiaS1.Click
        LimpiarTanqueos(1)
    End Sub

    Private Sub BtnLimpiaS2_Click(sender As Object, e As EventArgs) Handles BtnLimpiaS2.Click
        LimpiarTanqueos(2)
    End Sub

    Private Sub btn_ListarTanqNoAsoc_Click(sender As Object, e As EventArgs) Handles btn_ListarTanqNoAsoc.Click
        Try
            ConsultarTanqueosNoAsociados("")
            gbTanqueosNoAsociados.Expanded = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ActualizarSurtidores()
        Try
            Dim oeSurtidor As New e_Surtidor
            Dim olSurtidor As New l_Surtidor
            Dim leSurtidor As New List(Of e_Surtidor)
            oeSurtidor.TipoOperacion = "M"
            leSurtidor = olSurtidor.Listar(oeSurtidor)
            Dim FechaActual As Date = ObtenerFechaServidor()

            If leSurtidor.Where(Function(i) i.Cara = 1).Count > 0 Then
                dtp_FechaTanqueoS1.Value = FechaActual
                nd_CantGalonesS1.Value = leSurtidor.Where(Function(i) i.Cara = 1)(0).Galones
                TxtCodigoSurtidorS1.Value = leSurtidor.Where(Function(i) i.Cara = 1)(0).Numero
            Else
                dtp_FechaTanqueoS1.Value = FechaActual
                nd_CantGalonesS1.Value = 0.0
                TxtCodigoSurtidorS1.Value = ""
            End If
            If leSurtidor.Where(Function(i) i.Cara = 2).Count > 0 Then
                dtp_FechaTanqueoS2.Value = FechaActual
                nd_CantGalonesS2.Value = leSurtidor.Where(Function(i) i.Cara = 2)(0).Galones
                TxtCodigoSurtidorS2.Value = leSurtidor.Where(Function(i) i.Cara = 2)(0).Numero
            Else
                dtp_FechaTanqueoS2.Value = FechaActual
                nd_CantGalonesS2.Value = 0.0
                TxtCodigoSurtidorS2.Value = ""
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function Inventario(oe As e_RegistroConsumoCombustible, IndValidar As Boolean, FechaActual As Date) As List(Of e_Inventario)
        Try
            Dim loInventario As New List(Of e_Inventario)
            Dim oeRegInventario As e_RegistroInventario
            oeInventario = New e_Inventario
            With oeInventario
                .IdOrden = ""
                .IdMaterial = oe.IdMaterial
                .FechaCreacion = FechaActual
                .IdSubAlmacen = IdSubAlmacen
                .CantidadSalida = oe.CantidadGalon
                .ValorUnitario = Math.Round(oe.PrecioUnitario, 4)
                .Usuario = gUsuarioSGI.Id
                .IndValidar = IndValidar
            End With
            oeRegInventario = New e_RegistroInventario
            With oeRegInventario
                .TipoOperacion = "I"
                .IdMaterial = oe.IdMaterial
                .IdSubAlmacen = IdSubAlmacen
                .IdMovimientoInventario = "1CH000000028"
                .IdUnidadMedida = "1CH000000001"
                .Cantidad = oe.CantidadGalon
                .UsuarioCreacion = gUsuarioSGI.Id
            End With
            oeInventario.oeRegistroInventario = New e_RegistroInventario
            oeInventario.oeRegistroInventario = oeRegInventario
            loInventario.Add(oeInventario)
            Return loInventario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub LimpiarTanqueos(C1 As Integer)
        Try
            If C1 = 1 Then
                cboVehiculoS1.Enabled = True
                cboVehiculoS1.Value = ""
                ctrTanqueoS1 = False
                txtViajeS1.Value = ""
                TxT_IdViajeS1.Value = ""
                txtPilotoS1.Value = ""
                Txt_IdPilotoS1.Value = ""
                dtp_FechaViajeS1.Value = "01/01/1901"
                TxtCodigoSurtidorS1.Value = ""
                Opt_IndTanqueoS1.Value = True
                ctrTanqueoS1 = False
            ElseIf C1 = 2 Then
                CboVehiculoS2.Enabled = True
                CboVehiculoS2.Value = ""
                ctrTanqueoS2 = False
                TxtViajeS2.Value = ""
                TxT_IdViajeS2.Value = ""
                TxtPilotoS2.Value = ""
                Txt_IdPilotoS2.Value = ""
                dtp_FechaViajeS2.Value = "01/01/1901"
                TxtCodigoSurtidorS2.Value = ""
                Opt_IndTanqueoS2.Value = True
                ctrTanqueoS2 = False
            Else
                cboVehiculoS1.Enabled = True
                cboVehiculoS1.Value = ""
                ctrTanqueoS1 = False
                txtViajeS1.Value = ""
                TxT_IdViajeS1.Value = ""
                txtPilotoS1.Value = ""
                Txt_IdPilotoS1.Value = ""
                dtp_FechaViajeS1.Value = "01/01/1901"
                TxtCodigoSurtidorS1.Value = ""
                Opt_IndTanqueoS1.Value = True
                ctrTanqueoS1 = False
                CboVehiculoS2.Enabled = True
                CboVehiculoS2.Value = ""
                ctrTanqueoS2 = False
                TxtViajeS2.Value = ""
                TxT_IdViajeS2.Value = ""
                TxtPilotoS2.Value = ""
                Txt_IdPilotoS2.Value = ""
                dtp_FechaViajeS2.Value = "01/01/1901"
                TxtCodigoSurtidorS2.Value = ""
                Opt_IndTanqueoS2.Value = True
                ctrTanqueoS2 = False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "PECSA"

    Private Sub btnGuardarPecsa_Click(sender As Object, e As EventArgs) Handles btnGuardarPecsa.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Operacion = "Inicializa"
            If loRegDiesel.Count > 300 Then Throw New Exception("Solo Puede Guardar como Maximo 300 Registros. Verificar")
            If loRegDiesel.Where(Function(i) i.IdDireccion = "").ToList.Count > 0 Then Throw New Exception("Existen Estaciones no Registradas. Verificar")
            If loRegDiesel.Where(Function(i) i.IdVehiculo = "").ToList.Count > 0 Then Throw New Exception("Hay Registros sin Placa. Verificar")
            If loRegDiesel.Where(Function(i) i.KilometrosTanqueo = 0).ToList.Count > 0 Then Throw New Exception("Hay Registros con Kilometraje 0. Verificar")
            If loRegDiesel.Where(Function(i) i.IndTanqueoNoAsoc = True).ToList.Count > 0 Then Throw New Exception("Hay Registros con Duplicados. Verificar")
            If loRegDiesel.Count > 0 Then
                Dim oeRegConsumoMasivo As New e_RegistroConsumoCombustible
                oeRegConsumoMasivo.TipoOperacion = "I"
                oeRegConsumoMasivo.Ind_Masivo = True
                oeRegConsumoMasivo.ListaRegistrosConsumoD2 = loRegDiesel
                Dim FechaActual As Date = ObtenerFechaServidor()
                For Each oe As e_RegistroConsumoCombustible In oeRegConsumoMasivo.ListaRegistrosConsumoD2
                    oe.lstInventario = New List(Of e_Inventario)
                    IdSubAlmacen = ""
                    oeCombo = New e_Combo
                    oeCombo.Tipo = 4
                    oeCombo.Nombre = oe.IdGrifo
                    oeCombo.Descripcion = oe.IdDireccion
                    If SubAlmDiesel.Contains(oeCombo) Then
                        oeCombo = SubAlmDiesel.Item(SubAlmDiesel.IndexOf(oeCombo))
                    Else
                        Throw New Exception("No existe el SubAlmacen. Verificar")
                    End If
                    IdSubAlmacen = oeCombo.Id
                    oe.lstInventario = Inventario(oe, False, FechaActual)
                Next
                oeRegConsumoMasivo.UsuarioCreacion = gUsuarioSGI.Id
                oeRegConsumoMasivo.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeRegConsumoCombustible = olRegConsumoCombustible.Guardar(oeRegConsumoMasivo, New e_Orden)
                mensajeEmergente.Confirmacion("Los Tanqueos No Asociados Fueron Guardados Satisfactoriamente", True)
                loRegDiesel = New List(Of e_RegistroConsumoCombustible)
                griTanqueosPecsa.DataSource = loRegDiesel
            Else
                Throw New Exception("Ningun Tanqueo se ha importado, Importe tanqueos no asociados al sistema")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub CargarTanqueos()
        Try
            Dim olPecsa As New listarPecsa.ServiciosExternosSoapClient
            UltraGrid1.DataSource = olPecsa.ListarConsumos("20479729141", "20479729141", "", "", "", fecInicioTanqueo.Value.Date, fecFinTanqueo.Value.Date, "Error")
            CrearListaNoAsociados()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CrearListaNoAsociados()
        Try
            Dim oeValeGrifo As New e_Combo
            Dim olValeGrifo As New l_Combo
            Dim loValeGrifo As New List(Of e_Combo)
            oeValeGrifo.Nombre = "ValeGrifo"
            oeValeGrifo.Id = "1CH000005308"
            loValeGrifo = olValeGrifo.Listar(oeValeGrifo)
            loRegDiesel = New List(Of e_RegistroConsumoCombustible)
            Dim loAuxDiesel As New List(Of e_RegistroConsumoCombustible)
            Dim oeComboVehiculo As New e_Combo
            Dim oeEmpresa As New e_Empresa
            oeEmpresa.Id = "1CH000005308"
            oeEmpresa = olEmpresa.Obtener(oeEmpresa)
            Dim oeDireccion As New e_Combo
            Dim olCombo As New l_Combo
            Dim loDireccion As New List(Of e_Combo)
            oeDireccion.Id = oeEmpresa.Id
            oeDireccion.Nombre = "LugarEmpresa"
            loDireccion.AddRange(olCombo.Listar(oeDireccion))
            Dim FechaActual As Date = ObtenerFechaServidor()
            For Each fila As UltraGridRow In UltraGrid1.Rows
                oeRegConsumoCombustible = New e_RegistroConsumoCombustible
                With oeRegConsumoCombustible
                    .Seleccion = False
                    .TipoOperacion = "I"
                    .IdViaje = String.Empty
                    .CodViaje = String.Empty
                    Dim Placa As String = ""
                    Placa = IIf(fila.Cells("Placa").Value <> "", Replace(fila.Cells("Placa").Value.ToString.Trim, "-", ""), "")
                    If Placa <> "" Then
                        oeComboVehiculo = New e_Combo
                        oeComboVehiculo.Tipo = 1
                        oeComboVehiculo.Nombre = Placa.Substring(0, 3) & "-" & Placa.Substring(3)
                        If TractoPublic.Contains(oeComboVehiculo) Then
                            oeComboVehiculo = TractoPublic.Item(TractoPublic.IndexOf(oeComboVehiculo))
                        Else
                            oeComboVehiculo = New e_Combo
                        End If
                    Else
                        oeComboVehiculo = New e_Combo
                    End If
                    .IdVehiculo = oeComboVehiculo.Id
                    .PlacaVeh = oeComboVehiculo.Nombre
                    .FechaTanqueo = fila.Cells("FechaDocumento").Value
                    .KilometrosTanqueo = IIf(fila.Cells("Km").Value <> "", fila.Cells("Km").Value, 0)
                    .CantidadGalon = fila.Cells("Cantidad").Value
                    .IndTanqueo = True
                    .NroVale = fila.Cells("Documento").Value
                    .PrecioUnitario = Math.Round(fila.Cells("Total").Value / fila.Cells("Cantidad").Value, 4)
                    .IndCredito = True 'Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 11).Value)
                    oeDireccion = New e_Combo
                    oeDireccion.Descripcion = fila.Cells("Estacion").Value
                    oeDireccion.Tipo = 2
                    If loDireccion.Contains(oeDireccion) Then
                        oeDireccion = loDireccion.Item(loDireccion.IndexOf(oeDireccion))
                    Else
                        oeDireccion = New e_Combo
                    End If
                    .IdDireccion = oeDireccion.Id
                    .NomDireccion = oeDireccion.Nombre
                    .NomLugar = oeDireccion.Descripcion
                    oeValeGrifo = New e_Combo
                    oeValeGrifo.Tipo = 1
                    oeValeGrifo.Nombre = fila.Cells("Documento").Value
                    If loValeGrifo.Contains(oeValeGrifo) Then
                        .IndTanqueoNoAsoc = 1
                    Else
                        .IndTanqueoNoAsoc = 0
                    End If
                    .IdLugar = String.Empty
                    .Activo = True
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .IdRegistroInventario = String.Empty
                    .IdMaterial = "1CH000001990"
                    .SaldoGls = 0
                    .Estado = "SIN"
                    .Id = String.Empty
                    .IdPiloto = String.Empty
                    .IdGrifo = "1CH000005308"
                    .NomGrifo = oeEmpresa.Nombre
                    .Piloto = String.Empty
                    .CodMaterial = String.Empty
                    .Material = String.Empty
                    .FechaViaje = #1/1/1901#
                    .FechaCreacion = FechaActual
                    .IndIsl = False
                    loAuxDiesel.Add(oeRegConsumoCombustible)
                End With
            Next
            loRegDiesel.AddRange(loAuxDiesel.OrderByDescending(Function(i) i.FechaTanqueo).ToList)
            griTanqueosPecsa.DataSource = loRegDiesel
            griTanqueosPecsa.DataBind()
            ColorTanqueos(griTanqueosPecsa)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Try
            If MessageBox.Show("Desea Eliminar los Tanqueos ya Registrados? ", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = Windows.Forms.DialogResult.Yes Then
                For Each oe As e_RegistroConsumoCombustible In loRegDiesel.Where(Function(i) i.IndTanqueoNoAsoc = True).ToList
                    loRegDiesel.Remove(oe)
                Next
                griTanqueosPecsa.DataBind()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If MessageBox.Show("Desea Eliminar los Tanqueos Marcados? ", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = Windows.Forms.DialogResult.Yes Then
                For Each oe As e_RegistroConsumoCombustible In loRegDiesel.Where(Function(i) i.Seleccion = True).ToList
                    loRegDiesel.Remove(oe)
                Next
                griTanqueosPecsa.DataBind()
                UltraCheckEditor2.Checked = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ColorTanqueos(Grilla As UltraGrid)
        Try
            If Grilla.Rows.Count > 0 Then
                For Each fila As UltraGridRow In Grilla.Rows
                    If fila.Cells("IdVehiculo").Value = "" Then fila.Appearance.BackColor = ColorSPlaca.Color
                    If fila.Cells("KilometrosTanqueo").Value = 0 Then fila.Appearance.BackColor = ColorKm.Color
                    If fila.Cells("IndTanqueoNoAsoc").Value = True Then fila.Appearance.BackColor = ColoresDup.Color
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griTanqueosPecsa_CellChange(sender As Object, e As CellEventArgs) Handles griTanqueosPecsa.CellChange
        griTanqueosPecsa.UpdateData()
    End Sub

    Private Sub UltraCheckEditor2_CheckedChanged(sender As Object, e As EventArgs) Handles UltraCheckEditor2.CheckedChanged
        If UltraCheckEditor2.Checked Then
            For Each obj In griTanqueosPecsa.Rows.Where(Function(item) item.IsFilteredOut = False)
                obj.Cells("Seleccion").Value = True
            Next
        Else
            For Each obj In griTanqueosPecsa.Rows.Where(Function(item) item.IsFilteredOut = False)
                obj.Cells("Seleccion").Value = False
            Next
        End If
    End Sub

#End Region

#Region "Asiento Modelo"

    Private Sub AsientoContable()
        AsientoModelo()
        dtReferencia = New DataTable
        dtReferencia = GeneraDTRef(loReferencia)
    End Sub

    Private Sub AsientoModelo()
        oeAsientoModelo = New e_AsientoModelo
        olAsientoModelo = New l_AsientoModelo
        loAsientoModelo = New List(Of e_AsientoModelo)
        oeAsientoModelo.TipoOperacion = "A" : oeAsientoModelo.Activo = True : oeAsientoModelo.Nombre = pIdActividadNegocio
        loAsientoModelo = olAsientoModelo.Listar(oeAsientoModelo)

        oeReferencia = New e_AsientoModelo_Referencia
        olReferencia = New l_AsientoModelo_Referencia
        loReferencia = New List(Of e_AsientoModelo_Referencia)
        oeReferencia.TipoOperacion = "N" : oeReferencia.Activo = True : oeReferencia.IdReferencia = pIdActividadNegocio
        loReferencia = olReferencia.Listar(oeReferencia)
    End Sub

    Public Sub ObtenerAsientoModelo(IdMoneda As String, Ejercicio As Integer)
        Try
            Dim dtAux = New Data.DataTable
            Dim _rwAux() As Data.DataRow
            Dim cadSQL As String = String.Empty
            cadSQL = "TipoRef1 = 4 AND IdRef1 = '" & IdMoneda & "'"
            _rwAux = dtReferencia.Select(cadSQL, "")
            If _rwAux.Count = 0 Then Throw New Exception("Error en el Modelo de Asiento Contable. Verificar")
            dtAux = _rwAux.CopyToDataTable
            oeAsientoModelo = New e_AsientoModelo
            oeAsientoModelo.TipoOperacion = "" : oeAsientoModelo.Activo = True
            oeAsientoModelo.Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString
            oeAsientoModelo.Ejercicio = Ejercicio
            oeAsientoModelo = olAsientoModelo.Obtener(oeAsientoModelo)
            oeOrden.loAsientoModelo = New List(Of e_AsientoModelo)
            oeOrden.loAsientoModelo.Add(oeAsientoModelo)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class

