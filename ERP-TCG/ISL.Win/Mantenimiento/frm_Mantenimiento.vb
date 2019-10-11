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
Imports Infragistics.Shared
Imports System.Drawing.Graphics
Imports Infragistics.Win.UltraWinGrid.UltraGridAction

Public Class frm_Mantenimiento
    Inherits ISL.Win.frm_MenuPadre

#Region "Declaracion de variables y/o objetos"

    Dim oeMantenimiento As New e_Mantenimiento, olMantenimiento As New l_Mantenimiento
    Dim oeMarca As New e_Marca, olMarca As New l_Marca
    Dim oeModelo As New e_Modelo, olModelo As New l_Modelo
    Dim oeFamiliaMaterial As New e_FamiliaMaterial, olFamiliaMaterial As New l_FamiliaMaterial
    Dim oeSubFamiliaMaterial As New e_SubFamiliaMaterial, olSubFamiliaMaterial As New l_SubFamiliaMaterial
    Dim oeTipoMantenimiento As New e_TipoMantenimiento, olTipoMantenimiento As New l_TipoMantenimiento
    Dim oeUnidadMedida As New e_UnidadMedida, olUnidadMedida As New l_UnidadMedida
    Dim oeMantenimientoEquipo As New e_MantenimientoEquipo, olMantenimientoEquipo As New l_MantenimientoEquipo
    Dim oeCategoriaServicio As New e_CategoriaServicio, olCategoriaServicio As New l_CategoriaServicio
    Dim oeMantenimientoServicio As New e_MantenimientoServicio, olMantenimientoServicio As New l_MantenimientoServicio
    Dim oeMantenimientoMaterial As New e_MantenimientoMaterial, olMantenimientoMaterial As New l_MantenimientoMaterial
    Dim oeMantenimientoOcupacion As New e_MantenimientoOcupacion, olMantenimientoOcupacion As New l_MantenimientoOcupacion
    Dim oeMantenimientoActividad As New e_MantenimientoActividad, olMantenimientoActividad As New l_MantenimientoActividad

    Dim Opcion As Boolean
    Dim _ingresando_datos As Boolean = False

    Dim lstMantenimientoEquipo As New List(Of e_MantenimientoEquipo)
    Dim lstMantenimientoServicio As New List(Of e_MantenimientoServicio)
    Dim lstMantenimientoMaterial As New List(Of e_MantenimientoMaterial)
    Dim lstMantenimientoOcupacion As New List(Of e_MantenimientoOcupacion)
    Dim lstMantenimientoActividad As New List(Of e_MantenimientoActividad)

    Dim lstEquipos As New List(Of e_MantenimientoEquipo)
    Dim lstEquiposAsig As New List(Of e_MantenimientoEquipo)
    Dim lstServicios As New List(Of e_MantenimientoServicio)
    Dim lstMateriales As New List(Of e_MantenimientoMaterial)
    Dim lstOcupaciones As New List(Of e_MantenimientoOcupacion)
    Dim lstActividades As New List(Of e_MantenimientoActividad)

    Dim lstMarcas As New List(Of e_Marca)
    Dim lstMarcasAsig As New List(Of e_Marca)
    Dim lstCategoriasServicio As New List(Of e_CategoriaServicio)
    Dim lstFamiliasMaterial As New List(Of e_FamiliaMaterial)

    Dim dsMant As DataSet
    Dim relationMantEqui As DataRelation

    Private Shared instancia As frm_Mantenimiento = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Mantenimiento()
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
            'ListarMantenimientos(Activo)
            ListarMantenimientoEquipo(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If grid_Mantenimientos.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            oeMantenimiento = New e_Mantenimiento
            oeMantenimiento.TipoOperacion = "I"
            oeMantenimiento.UsuarioCreacion = gUsuarioSGI.Id
            MostrarTabs(1, tcMantenimiento, 1)
            Inicializar()
            ListadoGeneral()
            cmbTipoMantenimiento.Focus()
            Operacion = "Nuevo"
            MyBase.Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            MostrarMantenimiento()
            oeMantenimiento.TipoOperacion = "A"
            cmbTipoMantenimiento.Focus()
            Operacion = "Editar"
            MyBase.Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarMantenimiento() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcMantenimiento, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeMantenimiento.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarMantenimiento() Then
                            MostrarTabs(0, tcMantenimiento, 2)
                            _ingresando_datos = False
                            Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, tcMantenimiento, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcMantenimiento, 2)
                        _ingresando_datos = False
                        Consultar(True)
                End Select
            Else
                MostrarTabs(0, tcMantenimiento, 2)
                _ingresando_datos = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With grid_Mantenimientos
                If ValidarGrilla(grid_Mantenimientos, "Mantenimiento") Then
                    oeMantenimiento.Id = .ActiveRow.Cells("Id").Value
                    oeMantenimiento = olMantenimiento.Obtener(oeMantenimiento)
                    If oeMantenimiento.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar el Mantenimiento: " & _
                                 .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeMantenimiento.TipoOperacion = "E"
                            olMantenimiento.Eliminar(oeMantenimiento)
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

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try

            If grid_Mantenimientos.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(grid_Mantenimientos)

            MyBase.Exportar()
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

#End Region

#Region "Mantenimiento"

    Public Sub LlenaCombos()
        Try
            oeUnidadMedida.TipoOperacion = "D"
            oeUnidadMedida.Activo = True
            oeTipoMantenimiento.Activo = True
            LlenarComboMaestro(cmbUnidadMedida, olUnidadMedida.Listar(oeUnidadMedida), -1)
            LlenarComboMaestro(cmbTipoMantenimiento, olTipoMantenimiento.Listar(oeTipoMantenimiento), -1)
            LlenaComboMarca()
            LlenaComboFamilia()
            LlenaComboCategoriaServicios()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MostrarMantenimiento()
        Try
            If grid_Mantenimientos.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeMantenimiento.Id = grid_Mantenimientos.ActiveRow.Cells("Id").Value.ToString
                oeMantenimiento = olMantenimiento.Obtener(oeMantenimiento)
                txtCodigo.Text = oeMantenimiento.Codigo
                txtNombre.Text = oeMantenimiento.Nombre
                verInterna.Checked = IIf(oeMantenimiento.Externa = 1, True, False)
                verActivo.Checked = oeMantenimiento.Activo
                neOrdenSecuencia.Value = oeMantenimiento.OrdenSecuencia
                ndCantidad.Value = oeMantenimiento.Cantidad
                cmbTipoMantenimiento.Value = oeMantenimiento.IdTipoMantenimiento
                cmbUnidadMedida.Value = oeMantenimiento.IdUnidadMedida
                txtPatron.Text = oeMantenimiento.Descripcion
                MostrarTabs(1, tcMantenimiento, 1)
                ListarEquiposMantenimiento(True)
                ListarMaterialesMantenimiento(True)
                ListarServiciosMantenimiento(True)
                ListarOcupacionesMantenimiento(True)
                ListarActividadesMantenimiento(True)
                ListadoGeneral()
                MyBase.Editar()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LimpiarListas()
        Try
            lstEquipos.Clear()
            lstMateriales.Clear()
            lstOcupaciones.Clear()
            lstServicios.Clear()
            lstActividades.Clear()

            lstMantenimientoEquipo.Clear()
            lstMantenimientoMaterial.Clear()
            lstMantenimientoServicio.Clear()
            lstMantenimientoOcupacion.Clear()
            lstMantenimientoActividad.Clear()

            grid_Equipos.DataSource = lstEquipos
            grid_Materiales.DataSource = lstMateriales
            grid_Servicios.DataSource = lstServicios
            grid_Operarios.DataSource = lstOcupaciones
            grid_Actividades.DataSource = lstActividades

            grid_MantenimientoEquipo.DataSource = lstMantenimientoEquipo
            grid_MantenimientoMateriales.DataSource = lstMantenimientoMaterial
            grid_MantenimientoServicios.DataSource = lstMantenimientoServicio
            grid_MantenimientoOperarios.DataSource = lstMantenimientoOcupacion
            grid_MantenimientoActividades.DataSource = lstMantenimientoActividad
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializar()
        Try
            tcDetalle.SelectedTab = tcDetalle.Tabs(0)
            LlenaCombos()
            txtCodigo.Text = String.Empty
            txtNombre.Text = String.Empty
            neOrdenSecuencia.Value = Nothing
            ndCantidad.Value = Nothing
            verActivo.Checked = True
            Me.gbeEquipos.Expanded = False
            Me.gbeServicios.Expanded = False
            Me.gbeMateriales.Expanded = False
            Me.gbeRecursos.Expanded = False
            Me.gbeActividades.Expanded = False
            LimpiarListas()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub frm_Mantenimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gmt_ConfigurarEventoKeyEnter_Tab(Me)
            gf_AsignarEventoSeleccionarTexto(Me)
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            MostrarTabs(0, tcMantenimiento)
            LlenaComboMarcaAsig()
            uegbEquipos.Expanded = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Sub ListadoGeneral()
        Try
            ListarEquipos()
            ListarMateriales()
            ListarServicios()
            ListarOperarios()
            ListarActividades()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarMantenimientos(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeMantenimiento = New e_Mantenimiento
            oeMantenimiento.Activo = Activo
            grid_Mantenimientos.DataSource = olMantenimiento.Listar(oeMantenimiento)
            With grid_Mantenimientos
                'Cofigura la grilla para que se seleccione la fila completa al hacer click en algun lado
                .DisplayLayout.Bands(0).Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        grid_Mantenimientos.Focus()
    End Sub

    Private Function GuardarMantenimiento() As Boolean
        Try
            oeMantenimiento.lstDetalleEquipo = lstMantenimientoEquipo 'lstMantenimientoEquipo.Where(Function(item) String.IsNullOrEmpty(item.Id)).ToList
            oeMantenimiento.lstDetalleMaterial = lstMantenimientoMaterial 'lstMantenimientoMaterial.Where(Function(item) String.IsNullOrEmpty(item.Id)).ToList
            oeMantenimiento.lstDetalleServicio = lstMantenimientoServicio 'lstMantenimientoServicio.Where(Function(item) String.IsNullOrEmpty(item.Id)).ToList
            oeMantenimiento.lstDetalleOcupacion = lstMantenimientoOcupacion 'lstMantenimientoOcupacion.Where(Function(item) String.IsNullOrEmpty(item.Id)).ToList
            oeMantenimiento.lstDetalleActividad = lstMantenimientoActividad 'lstMantenimientoActividad.Where(Function(item) String.IsNullOrEmpty(item.Id)).ToList
            oeMantenimiento.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olMantenimiento.Guardar(oeMantenimiento) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, tcMantenimiento, 2)
                Consultar(True)
                grid_Mantenimientos.Focus()
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub txtCodigo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        txtCodigo.Text = LTrim(txtCodigo.Text)
        oeMantenimiento.Codigo = txtCodigo.Text
    End Sub

    Private Sub txtPatron_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPatron.ValueChanged
        txtPatron.Text = txtPatron.Text.Trim
        oeMantenimiento.Descripcion = txtPatron.Text
    End Sub

    Private Sub verInterna_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verInterna.CheckedChanged
        oeMantenimiento.Externa = IIf(verInterna.Checked, 1, 0)
    End Sub

    Private Sub cmbTipoMantenimiento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoMantenimiento.ValueChanged
        oeMantenimiento.IdTipoMantenimiento = cmbTipoMantenimiento.Value
        oeMantenimiento.TipoMantenimiento = cmbTipoMantenimiento.Text

        If cmbTipoMantenimiento.SelectedIndex = 0 Then
            ndCantidad.Enabled = False
            cmbUnidadMedida.Enabled = False
            neOrdenSecuencia.Enabled = False
        Else
            ndCantidad.Enabled = True
            cmbUnidadMedida.Enabled = True
            neOrdenSecuencia.Enabled = True
        End If
    End Sub

    Private Sub ndCantidad_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndCantidad.ValueChanged
        oeMantenimiento.Cantidad = ndCantidad.Value
    End Sub

    Private Sub cmbUnidadMedida_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUnidadMedida.ValueChanged
        oeMantenimiento.IdUnidadMedida = cmbUnidadMedida.Value
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeMantenimiento.Activo = verActivo.Checked
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        txtNombre.Text = LTrim(txtNombre.Text)
        oeMantenimiento.Nombre = txtNombre.Text
    End Sub

    Private Sub frm_Mantenimiento_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Mantenimiento_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Select Case _Operacion
            Case "Nuevo", "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub grid_Matenimientos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If grid_Mantenimientos.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub neOrdenSecuencia_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles neOrdenSecuencia.ValueChanged
        oeMantenimiento.OrdenSecuencia = neOrdenSecuencia.Value
    End Sub

    Private Sub grid_MantenimientoEquipo_AfterHeaderCheckStateChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterHeaderCheckStateChangedEventArgs) Handles grid_MantenimientoEquipo.AfterHeaderCheckStateChanged
        grid_MantenimientoEquipo.UpdateData()
    End Sub

    Private Sub grid_Equipos_AfterHeaderCheckStateChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterHeaderCheckStateChangedEventArgs) Handles grid_Equipos.AfterHeaderCheckStateChanged
        grid_Equipos.UpdateData()
    End Sub

    Private Sub grid_EquipoAsig_AfterHeaderCheckStateChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterHeaderCheckStateChangedEventArgs) Handles grid_EquipoAsig.AfterHeaderCheckStateChanged
        grid_EquipoAsig.UpdateData()
    End Sub

#End Region

#Region "Equipos"

    Public Sub ListarEquiposMantenimiento(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeMantenimientoEquipo = New e_MantenimientoEquipo
            With grid_MantenimientoEquipo
                oeMantenimientoEquipo.TipoOperacion = "L"
                oeMantenimientoEquipo.Activo = Activo
                oeMantenimientoEquipo.IdMantenimiento = oeMantenimiento.Id
                lstMantenimientoEquipo = olMantenimientoEquipo.Listar(oeMantenimientoEquipo)
                .DataSource = lstMantenimientoEquipo
            End With
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
            grid_MantenimientoEquipo.Focus()
        End Try
    End Sub

    Public Sub LlenaComboMarca()
        Try
            oeMarca.Id = "CERO" : oeMarca.Nombre = "TODOS"
            lstMarcas.Add(oeMarca)
            oeMarca = New e_Marca
            oeMarca.TipoMarca = 1
            oeMarca.Activo = True
            lstMarcas.AddRange(olMarca.Listar(oeMarca))
            LlenarComboMaestro(cmbMarca, lstMarcas, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarEquipos()
        Try
            Me.Cursor = Cursors.WaitCursor
            oeMantenimientoEquipo = New e_MantenimientoEquipo
            oeMantenimientoEquipo.TipoOperacion = "E" ' Lista de equipos en un mantenimiento
            oeMantenimientoEquipo.Activo = True
            oeMantenimientoEquipo.IdMantenimiento = oeMantenimiento.Id
            lstEquipos = olMantenimientoEquipo.Listar(oeMantenimientoEquipo)
            If lstMantenimientoEquipo.Count > 0 Then
                lstEquipos.RemoveAll(AddressOf VerificaListaEquipos)
                grid_Equipos.DataBind()
            End If
            grid_Equipos.DataSource = lstEquipos
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
            grid_Equipos.Focus()
        End Try
    End Sub

    Private Function VerificaListaEquipos(ByVal oeEqui As e_MantenimientoEquipo) As Boolean
        For Each filaMantEqui As e_MantenimientoEquipo In lstMantenimientoEquipo
            If oeEqui.IdEquipo = filaMantEqui.IdEquipo Then Return True
        Next
    End Function

    Private Sub AsignarEquiposMantenimiento()
        Try
            Dim _cant As Integer = 0
            For Each oeItem As e_MantenimientoEquipo In lstEquipos
                If oeItem.Seleccion Then
                    oeItem.IdMantenimiento = oeMantenimiento.Id
                    oeItem.Mantenimiento = oeMantenimiento.Nombre
                    lstMantenimientoEquipo.Add(oeItem)
                    _cant += 1
                End If
            Next
            If _cant > 0 Then
                lstEquipos.RemoveAll(Function(item) item.Seleccion)
                lstMantenimientoEquipo.ForEach(AddressOf DescheckearlstE)
                grid_Equipos.DataBind()
                grid_MantenimientoEquipo.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub DescheckearlstE(ByVal oeItem As e_MantenimientoEquipo)
        If oeItem.Seleccion Then oeItem.Seleccion = False
    End Sub

    Private Sub cmbMarca_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMarca.ValueChanged
        Try
            oeModelo = New e_Modelo
            oeModelo.IdMarca = cmbMarca.Value
            oeModelo.Activo = True
            LlenarComboMaestro(cmbModelo, olModelo.Listar(oeModelo), -1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Sub EliminarEquiposMantenimiento()
        Try
            lstEquipos.AddRange(lstMantenimientoEquipo.Where(Function(item) item.Seleccion).ToList)
            lstMantenimientoEquipo.RemoveAll(Function(item) item.Seleccion)
            lstEquipos.ForEach(AddressOf DescheckearlstE)
            grid_Equipos.DataBind()
            grid_MantenimientoEquipo.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub grid_MantenimientoEquipo_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_MantenimientoEquipo.CellChange
        Try
            grid_MantenimientoEquipo.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub grid_Equipos_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_Equipos.CellChange
        Try
            grid_Equipos.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub btnListarEquipos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarEquipos.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            oeMantenimientoEquipo = New e_MantenimientoEquipo
            oeMantenimientoEquipo.TipoOperacion = "E"
            oeMantenimientoEquipo.Activo = True
            oeMantenimientoEquipo.IdMantenimiento = oeMantenimiento.Id
            oeMantenimientoEquipo.IdMarca = IIf(cmbMarca.Value = "CERO", "", cmbMarca.Value)
            oeMantenimientoEquipo.IdModelo = cmbModelo.Value
            lstEquipos = olMantenimientoEquipo.Listar(oeMantenimientoEquipo)
            grid_Equipos.DataSource = lstEquipos
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
            grid_Equipos.Focus()
        End Try
    End Sub

#End Region

#Region "Materiales"

    Public Sub ListarMateriales()
        Try
            Me.Cursor = Cursors.WaitCursor
            oeMantenimientoMaterial = New e_MantenimientoMaterial
            oeMantenimientoMaterial.TipoOperacion = "M"
            oeMantenimientoMaterial.Activo = True
            oeMantenimientoMaterial.IdMantenimiento = oeMantenimiento.Id
            lstMateriales = olMantenimientoMaterial.Listar(oeMantenimientoMaterial)
            If lstMantenimientoMaterial.Count > 0 Then
                lstMateriales.RemoveAll(AddressOf VerificaListaMateriales)
                grid_Equipos.DataBind()
            End If
            grid_Materiales.DataSource = lstMateriales
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
            grid_Materiales.Focus()
        End Try
    End Sub

    Private Function VerificaListaMateriales(ByVal oeMat As e_MantenimientoMaterial) As Boolean
        For Each filaMantMat As e_MantenimientoMaterial In lstMantenimientoMaterial
            If oeMat.IdMaterial = filaMantMat.IdMaterial Then Return True
        Next
    End Function

    Private Sub AsignarMaterialesMantenimiento()
        Try
            Dim _cant As Integer = 0
            For Each oeItem As e_MantenimientoMaterial In lstMateriales
                If oeItem.Seleccion Then
                    oeItem.IdMantenimiento = oeMantenimiento.Id
                    oeItem.Cantidad = 1
                    lstMantenimientoMaterial.Add(oeItem)
                    _cant += 1
                End If
            Next
            If _cant > 0 Then
                lstMateriales.RemoveAll(Function(item) item.Seleccion)
                lstMantenimientoMaterial.ForEach(AddressOf DescheckearlstM)
                grid_Materiales.DataBind()
                grid_MantenimientoMateriales.DataBind()
                For i As Integer = 0 To grid_MantenimientoMateriales.Rows.Count - 1
                    UnidadMedidaValueList(grid_MantenimientoMateriales.Rows(i).Cells("IdTipoUnidadMedida").Value.ToString)
                    grid_MantenimientoMateriales.Rows(i).Cells("IdUnidadMedida").ValueList = Me.grid_MantenimientoMateriales.DisplayLayout.ValueLists("Medidas")
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub UnidadMedidaValueList(ByVal ls_IdTipoUnidadMedida As String)
        Try
            Dim objValueList As Infragistics.Win.ValueList = Nothing
            Me.grid_MantenimientoMateriales.DisplayLayout.ValueLists.Clear()
            objValueList = Me.grid_MantenimientoMateriales.DisplayLayout.ValueLists.Add("Medidas")

            oeUnidadMedida = New e_UnidadMedida()
            oeUnidadMedida.Activo = True
            oeUnidadMedida.Nombre = ""
            oeUnidadMedida.IdTipoUnidadMedida = ls_IdTipoUnidadMedida
            Dim dt As DataTable = olUnidadMedida.ComboGrilla(oeUnidadMedida)
            For i As Integer = 0 To dt.Rows.Count - 1
                objValueList.ValueListItems.Add(dt.Rows(i).Item("Id"), dt.Rows(i).Item("Nombre"))
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarMaterialesMantenimiento(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeMantenimientoMaterial = New e_MantenimientoMaterial
            oeMantenimientoMaterial.TipoOperacion = "L"
            oeMantenimientoMaterial.Activo = True
            oeMantenimientoMaterial.IdMantenimiento = oeMantenimiento.Id
            lstMantenimientoMaterial = olMantenimientoMaterial.Listar(oeMantenimientoMaterial)
            grid_MantenimientoMateriales.DataSource = lstMantenimientoMaterial

            For i As Integer = 0 To grid_MantenimientoMateriales.Rows.Count - 1
                UnidadMedidaValueList(grid_MantenimientoMateriales.Rows(i).Cells("IdTipoUnidadMedida").Value.ToString)
                grid_MantenimientoMateriales.Rows(i).Cells("IdUnidadMedida").ValueList = Me.grid_MantenimientoMateriales.DisplayLayout.ValueLists("Medidas")
            Next
            Me.grid_MantenimientoMateriales.DisplayLayout.Bands(0).Columns("IdUnidadMedida").Header.Caption = "Unidad Medida"
            CalcularTotales(grid_MantenimientoMateriales, "Precio")
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
            grid_MantenimientoMateriales.Focus()
        End Try
    End Sub

    Public Sub LlenaComboFamilia()
        Try
            oeFamiliaMaterial.Id = "CERO" : oeFamiliaMaterial.Nombre = "TODOS"
            lstFamiliasMaterial.Add(oeFamiliaMaterial)
            oeFamiliaMaterial = New e_FamiliaMaterial
            oeFamiliaMaterial.Activo = True
            lstFamiliasMaterial.AddRange(olFamiliaMaterial.Listar(oeFamiliaMaterial))
            LlenarComboMaestro(cmbFamilia, lstFamiliasMaterial, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnListarMaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarMaterial.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            oeMantenimientoMaterial = New e_MantenimientoMaterial
            oeMantenimientoMaterial.TipoOperacion = "L"
            oeMantenimientoMaterial.Activo = True
            oeMantenimientoMaterial.IdMantenimiento = oeMantenimiento.Id
            oeMantenimientoMaterial.IdFamilia = IIf(cmbFamilia.Value = "CERO", "", cmbFamilia.Value)
            oeMantenimientoMaterial.IdSubFamilia = cmbSubFamilia.Value
            lstMateriales = olMantenimientoMaterial.Listar(oeMantenimientoMaterial)
            grid_Materiales.DataSource = lstMateriales
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
            grid_Materiales.Focus()
        End Try
    End Sub

    Private Sub grid_Materiales_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_Materiales.CellChange
        Try
            grid_Materiales.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cmbFamilia_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFamilia.ValueChanged
        Try
            oeSubFamiliaMaterial = New e_SubFamiliaMaterial("", "", "", "", True, cmbFamilia.Value, "")
            LlenarComboMaestro(cmbSubFamilia, olSubFamiliaMaterial.Listar(oeSubFamiliaMaterial), -1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Sub EliminarMaterialesMantenimiento()
        Try
            lstMateriales.AddRange(lstMantenimientoMaterial.Where(Function(item) item.Seleccion).ToList)
            lstMantenimientoMaterial.RemoveAll(Function(item) item.Seleccion)
            lstMateriales.ForEach(AddressOf DescheckearlstM)
            grid_Materiales.DataBind()
            grid_MantenimientoMateriales.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub DescheckearlstM(ByVal oeItem As e_MantenimientoMaterial)
        If oeItem.Seleccion Then oeItem.Seleccion = False
    End Sub

    Private Sub grid_MantenimientoMateriales_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_MantenimientoMateriales.CellChange
        Try
            grid_MantenimientoMateriales.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Servicios"

    Public Sub LlenaComboCategoriaServicios()
        Try
            oeCategoriaServicio.Id = "CERO" : oeCategoriaServicio.Nombre = "TODOS"
            lstCategoriasServicio.Add(oeCategoriaServicio)
            oeCategoriaServicio = New e_CategoriaServicio
            oeCategoriaServicio.Activo = True
            lstCategoriasServicio.AddRange(olCategoriaServicio.Listar(oeCategoriaServicio))
            LlenarComboMaestro(cmbCategoriaServicios, lstCategoriasServicio, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarServicios()
        Try
            Me.Cursor = Cursors.WaitCursor
            oeMantenimientoServicio = New e_MantenimientoServicio
            oeMantenimientoServicio.TipoOperacion = "S"
            oeMantenimientoServicio.Activo = True
            oeMantenimientoServicio.IdMantenimiento = oeMantenimiento.Id
            lstServicios = olMantenimientoServicio.Listar(oeMantenimientoServicio)
            If lstMantenimientoServicio.Count > 0 Then
                lstServicios.RemoveAll(AddressOf VerificaListaServicios)
                grid_Equipos.DataBind()
            End If
            grid_Servicios.DataSource = lstServicios
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
            grid_Servicios.Focus()
        End Try
    End Sub

    Private Function VerificaListaServicios(ByVal oeServ As e_MantenimientoServicio) As Boolean
        For Each filaMantServ As e_MantenimientoServicio In lstMantenimientoServicio
            If oeServ.IdServicio = filaMantServ.IdServicio Then Return True
        Next
    End Function

    Private Sub btnCategoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCategoria.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            oeMantenimientoServicio = New e_MantenimientoServicio
            oeMantenimientoServicio.TipoOperacion = "S"
            oeMantenimientoServicio.Activo = True
            oeMantenimientoServicio.IdMantenimiento = oeMantenimiento.Id
            oeMantenimientoServicio.IdCategoriaServicio = IIf(cmbCategoriaServicios.Value = "CERO", "", cmbCategoriaServicios.Value)
            lstServicios = olMantenimientoServicio.Listar(oeMantenimientoServicio)
            grid_Servicios.DataSource = lstServicios
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
            grid_Servicios.Focus()
        End Try
    End Sub

    Private Sub grid_Servicios_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_Servicios.CellChange
        Try
            grid_Servicios.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub AsignarServiciosMantenimiento()
        Try
            Dim _cant As Integer = 0
            For Each oeItem As e_MantenimientoServicio In lstServicios
                If oeItem.Seleccion Then
                    oeItem.IdMantenimiento = oeMantenimiento.Id
                    lstMantenimientoServicio.Add(oeItem)
                    _cant = _cant + 1
                End If
            Next
            If _cant > 0 Then
                lstServicios.RemoveAll(Function(item) item.Seleccion)
                lstMantenimientoServicio.ForEach(AddressOf DescheckearlstS)
                grid_Servicios.DataBind()
                grid_MantenimientoServicios.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarServiciosMantenimiento(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeMantenimientoServicio = New e_MantenimientoServicio
            With grid_MantenimientoServicios
                oeMantenimientoServicio.TipoOperacion = "L"
                oeMantenimientoServicio.Activo = Activo
                oeMantenimientoServicio.IdMantenimiento = oeMantenimiento.Id
                lstMantenimientoServicio = olMantenimientoServicio.Listar(oeMantenimientoServicio)
                .DataSource = lstMantenimientoServicio
            End With
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
            grid_MantenimientoEquipo.Focus()
        End Try
    End Sub

    Sub EliminarServiciosMantenimiento()
        Try
            lstServicios.AddRange(lstMantenimientoServicio.Where(Function(item) item.Seleccion).ToList)
            lstMantenimientoServicio.RemoveAll(Function(item) item.Seleccion)
            lstServicios.ForEach(AddressOf DescheckearlstS)
            grid_Servicios.DataBind()
            grid_MantenimientoServicios.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub DescheckearlstS(ByVal oeItem As e_MantenimientoServicio)
        If oeItem.Seleccion Then oeItem.Seleccion = False
    End Sub

    Private Sub grid_MantenimientoServicios_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_MantenimientoServicios.CellChange
        Try
            grid_MantenimientoServicios.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Actividades"

    Public Sub ListarActividades()
        Try
            Me.Cursor = Cursors.WaitCursor
            oeMantenimientoActividad = New e_MantenimientoActividad
            oeMantenimientoActividad.TipoOperacion = "A"
            oeMantenimientoActividad.Activo = True
            oeMantenimientoActividad.IdMantenimiento = oeMantenimiento.Id
            lstActividades = olMantenimientoActividad.Listar(oeMantenimientoActividad)
            If lstMantenimientoActividad.Count > 0 Then
                lstActividades.RemoveAll(AddressOf VerificaListaActividades)
                grid_Actividades.DataBind()
            End If
            grid_Actividades.DataSource = lstActividades
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
            grid_Actividades.Focus()
        End Try
    End Sub

    Private Function VerificaListaActividades(ByVal oeAct As e_MantenimientoActividad) As Boolean
        For Each filaMantAct As e_MantenimientoActividad In lstMantenimientoActividad
            If oeAct.IdActividad = filaMantAct.IdActividad Then Return True
        Next
    End Function

    Private Sub AsignarActividadesMantenimiento()
        Try
            Dim _cant As Integer = 0
            For Each oeAct As e_MantenimientoActividad In lstActividades
                If oeAct.Seleccion Then
                    oeAct.IdMantenimiento = oeMantenimiento.Id
                    oeAct.CantidadHoras = Date.Parse("01/01/1901")
                    lstMantenimientoActividad.Add(oeAct)
                    _cant += 1
                End If
            Next
            If _cant > 0 Then
                lstActividades.RemoveAll(Function(item) item.Seleccion)
                lstMantenimientoActividad.ForEach(AddressOf DescheckearlstA)
                grid_Actividades.DataBind()
                grid_MantenimientoActividades.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarActividadesMantenimiento(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeMantenimientoActividad = New e_MantenimientoActividad
            oeMantenimientoActividad.TipoOperacion = "L"
            oeMantenimientoActividad.Activo = True
            oeMantenimientoActividad.IdMantenimiento = oeMantenimiento.Id
            lstMantenimientoActividad = olMantenimientoActividad.Listar(oeMantenimientoActividad)
            grid_MantenimientoActividades.DataSource = lstMantenimientoActividad
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
            grid_MantenimientoActividades.Focus()
        End Try
    End Sub

    Private Sub grid_Actividades_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_Actividades.CellChange
        Try
            grid_Actividades.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub grid_MantenimientoActividades_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_MantenimientoActividades.CellChange
        Try
            grid_MantenimientoActividades.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Sub EliminarActividadesMantenimiento()
        Try
            lstActividades.AddRange(lstMantenimientoActividad.Where(Function(item) item.Seleccion).ToList)
            lstMantenimientoActividad.RemoveAll(Function(item) item.Seleccion)
            lstActividades.ForEach(AddressOf DescheckearlstA)
            grid_Actividades.DataBind()
            grid_MantenimientoActividades.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub DescheckearlstA(ByVal oeItem As e_MantenimientoActividad)
        If oeItem.Seleccion Then oeItem.Seleccion = False
    End Sub

#End Region

#Region "Ocupaciones"

    Public Sub ListarOperarios()
        Try
            Me.Cursor = Cursors.WaitCursor
            oeMantenimientoOcupacion = New e_MantenimientoOcupacion
            oeMantenimientoOcupacion.TipoOperacion = "O"
            oeMantenimientoOcupacion.Activo = True
            oeMantenimientoOcupacion.IdMantenimiento = oeMantenimiento.Id
            lstOcupaciones = olMantenimientoOcupacion.Listar(oeMantenimientoOcupacion)
            If lstMantenimientoOcupacion.Count > 0 Then
                lstOcupaciones.RemoveAll(AddressOf VerificaListaOcupaciones)
                grid_Operarios.DataBind()
            End If
            grid_Operarios.DataSource = lstOcupaciones
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
            grid_Operarios.Focus()
        End Try
    End Sub

    Private Function VerificaListaOcupaciones(ByVal oeOcup As e_MantenimientoOcupacion) As Boolean
        For Each filaMantOcup As e_MantenimientoOcupacion In lstMantenimientoOcupacion
            If oeOcup.IdOcupacion = filaMantOcup.IdOcupacion Then Return True
        Next
    End Function

    Private Sub grid_Operarios_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_Operarios.CellChange
        Try
            grid_Operarios.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub AsignarOcupacionesMantenimiento()
        Try
            Dim _cant As Integer = 0
            For Each oeOcup As e_MantenimientoOcupacion In lstOcupaciones
                If oeOcup.Seleccion Then
                    oeOcup.IdMantenimiento = oeMantenimiento.Id
                    oeOcup.Cantidad = 1
                    lstMantenimientoOcupacion.Add(oeOcup)
                    _cant += 1
                End If
            Next
            If _cant > 0 Then
                lstOcupaciones.RemoveAll(Function(item) item.Seleccion)
                lstMantenimientoOcupacion.ForEach(AddressOf DescheckearlstO)
                grid_Operarios.DataBind()
                grid_MantenimientoOperarios.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarOcupacionesMantenimiento(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeMantenimientoOcupacion = New e_MantenimientoOcupacion
            oeMantenimientoOcupacion.TipoOperacion = "L"
            oeMantenimientoOcupacion.Activo = True
            oeMantenimientoOcupacion.IdMantenimiento = oeMantenimiento.Id
            lstMantenimientoOcupacion = olMantenimientoOcupacion.Listar(oeMantenimientoOcupacion)
            grid_MantenimientoOperarios.DataSource = lstMantenimientoOcupacion
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
            grid_MantenimientoOperarios.Focus()
        End Try
    End Sub

    Sub EliminarOcupacionesMantenimiento()
        Try
            lstOcupaciones.AddRange(lstMantenimientoOcupacion.Where(Function(item) item.Seleccion).ToList)
            lstMantenimientoOcupacion.RemoveAll(Function(item) item.Seleccion)
            lstOcupaciones.ForEach(AddressOf DescheckearlstO)
            grid_Operarios.DataBind()
            grid_MantenimientoOperarios.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub DescheckearlstO(ByVal oeItem As e_MantenimientoOcupacion)
        If oeItem.Seleccion Then oeItem.Seleccion = False
    End Sub

    Private Sub grid_MantenimientoOperarios_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_MantenimientoOperarios.CellChange
        Try
            grid_MantenimientoOperarios.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Menu y tabs"

    Private Sub mnDetalle_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles mnDetalle.ToolClick
        Try
            Select Case e.Tool.Key
                Case "Agregar"
                    AgregarDetalle()
                Case "Quitar"
                    EliminarDetalle()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Sub AgregarDetalle()
        Try
            Select Case tcDetalle.SelectedTab.Index
                Case 0
                    AsignarEquiposMantenimiento()
                Case 1
                    AsignarMaterialesMantenimiento()
                Case 2
                    AsignarServiciosMantenimiento()
                Case 3
                    AsignarOcupacionesMantenimiento()
                Case 4
                    AsignarActividadesMantenimiento()
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub EliminarDetalle()
        Try
            Select Case tcDetalle.SelectedTab.Index
                Case 0
                    EliminarEquiposMantenimiento()
                Case 1
                    EliminarMaterialesMantenimiento()
                Case 2
                    EliminarServiciosMantenimiento()
                Case 3
                    EliminarOcupacionesMantenimiento()
                Case 4
                    EliminarActividadesMantenimiento()
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarToolStripMenuItem.Click
        Try
            EliminarDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem.Click
        Try
            AgregarDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub mcDetalle_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mcDetalle.Opening
        Try
            mcDetalle.Items(0).Visible = True : mcDetalle.Items(1).Visible = True
            If mcDetalle.SourceControl Is grid_Equipos Or mcDetalle.SourceControl Is grid_Materiales Or mcDetalle.SourceControl Is grid_Servicios Then
                mcDetalle.Items(1).Visible = False
                If grid_Equipos.Rows.Count = 0 Then
                    mcDetalle.Items(0).Visible = False
                End If
            ElseIf mcDetalle.SourceControl Is grid_MantenimientoEquipo Or mcDetalle.SourceControl Is grid_MantenimientoMateriales Or mcDetalle.SourceControl Is grid_MantenimientoServicios Then
                mcDetalle.Items(0).Visible = False
                If grid_MantenimientoEquipo.Rows.Count = 0 Then
                    mcDetalle.Items(1).Visible = False
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub tcDetalle_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles tcDetalle.SelectedTabChanged
        'If oeMantenimiento.TipoOperacion = "A" Then
        '    ConsultaDetalle()
        'End If
    End Sub

    Private Sub grid_MantenimientoActividades_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs)
        'grid_MantenimientoActividades.DisplayLayout.Bands(0).Columns("Horas").EditorComponent = Hora1
    End Sub

    Public Sub LlenaComboMarcaAsig()
        Try
            oeMarca = New e_Marca
            oeMarca.Id = "CERO" : oeMarca.Nombre = "TODOS"
            lstMarcasAsig.Add(oeMarca)
            oeMarca = New e_Marca
            oeMarca.TipoMarca = 0
            oeMarca.Activo = True
            lstMarcasAsig.AddRange(olMarca.Listar(oeMarca))
            LlenarComboMaestro(cmbMarcaAsig, lstMarcasAsig, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnListarAsig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarAsig.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            oeMantenimientoEquipo = New e_MantenimientoEquipo
            oeMantenimientoEquipo.TipoOperacion = "E"
            oeMantenimientoEquipo.Activo = True
            oeMantenimientoEquipo.IdMarca = IIf(cmbMarcaAsig.Value = "CERO", "", cmbMarcaAsig.Value)
            oeMantenimientoEquipo.IdModelo = cmbModeloAsig.Value
            lstEquiposAsig = olMantenimientoEquipo.Listar(oeMantenimientoEquipo)
            grid_EquipoAsig.DataSource = lstEquiposAsig
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
            grid_EquipoAsig.Focus()
        End Try
    End Sub

    Private Sub cmbMarcaAsig_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMarcaAsig.ValueChanged
        Try
            oeModelo = New e_Modelo '(0, "", "", "", "", True, cmbMarcaAsig.Value, "", "")
            oeModelo.IdMarca = cmbMarcaAsig.Value
            oeModelo.Activo = True
            LlenarComboMaestro(cmbModeloAsig, olModelo.Listar(oeModelo), -1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Sub ListarMantenimientoEquipo(ByVal Activo As Boolean)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            dsMant = olMantenimiento.ListarDS(oeMantenimiento)

            ''''''''''''''''''''''''''''''''''''''''''''''
            'Tabla(0) Mantenimiento
            'Tabla(1) Equipo
            ''''''''''''''''''''''''''''''''''''''''''''''
            Dim IdMant As DataColumn = dsMant.Tables(0).Columns("Id")
            Dim IdMantEqui As DataColumn = dsMant.Tables(1).Columns("IdMantenimiento")
            relationMantEqui = New DataRelation("FK_Relacion", IdMant, IdMantEqui, False)
            dsMant.Relations.Add(relationMantEqui)
            dsMant.AcceptChanges()
            grid_Mantenimientos.DataSource = dsMant

            With grid_Mantenimientos.DisplayLayout
                '.Bands(1).ColHeadersVisible = False
                .Bands(1).Columns("Id").Hidden = True
                .Bands(1).Columns("Seleccion").Width = 40
                .Bands(1).Columns("Seleccion").CellClickAction = CellClickAction.Edit
                .Bands(0).Columns("Seleccion").CellClickAction = CellClickAction.Edit
                .Bands(1).Columns("IdEquipo").Hidden = True
                .Bands(1).Columns("Codigo").Hidden = True
                .Bands(1).Columns("IdMantenimiento").Hidden = True
                .Bands(1).Columns("IdVehiculo").Hidden = True
            End With
            'For x As Integer = 0 To grid_Mantenimientos.Rows.Count - 1
            '    Me.grid_Mantenimientos.Rows(x).ExpandAll()
            'Next
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
            grid_Mantenimientos.Focus()
        End Try
    End Sub

    Private Sub grid_Mantenimientos_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_Mantenimientos.CellChange
        Try
            grid_Mantenimientos.UpdateData()
            '    With grid_Mantenimientos
            '        .UpdateData()
            '        If e.Cell.Column.Key.ToUpper = "SELECCION" Then
            '            Select Case .ActiveRow.Band.Index
            '                Case 0
            '                    For Each equiRow As DataRow In dsMant.Tables(1).Rows
            '                        If .ActiveRow.Cells("Id").Value = equiRow("IdMantenimiento") Then
            '                            equiRow("Seleccion") = .ActiveRow.Cells("Seleccion").Value
            '                        End If
            '                    Next
            '                Case 1
            '                    Dim cont As Integer = 0, cont2 As Integer = 0
            '                    For Each equiRow As DataRow In dsMant.Tables(1).Rows
            '                        If .ActiveRow.Cells("IdMantenimiento").Value = equiRow("IdMantenimiento") Then
            '                            If equiRow("Seleccion") = .ActiveRow.Cells("Seleccion").Value Then
            '                                cont += 1
            '                            End If
            '                            cont2 += 1
            '                        End If
            '                    Next
            '                    If cont = cont2 Then
            '                        .ActiveRow.ParentRow.Cells("Seleccion").Value = .ActiveRow.Cells("Seleccion").Value
            '                    Else
            '                        If Not .ActiveRow.Cells("Seleccion").Value Then
            '                            .ActiveRow.ParentRow.Cells("Seleccion").Value = .ActiveRow.Cells("Seleccion").Value
            '                        End If
            '                    End If

            '            End Select
            '            .UpdateData()
            '            .DataBind()
            '        End If
            '    End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub grid_EquipoAsig_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_EquipoAsig.CellChange
        Try
            grid_EquipoAsig.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub btnAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignar.Click
        Try
            AsignarEquiposMantenimiento2()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Sub AsignarEquiposMantenimiento2()
        Try
            For Each oeMantenimientoEquipo As e_MantenimientoEquipo In lstEquiposAsig.Where(Function(x) x.Seleccion = True)
                For Each mantRow As Data.DataRow In dsMant.Tables(0).Rows
                    If mantRow("Seleccion") Then
                        oeMantenimientoEquipo.TipoOperacion = "I"
                        oeMantenimientoEquipo.IdMantenimiento = mantRow("Id").ToString
                        oeMantenimientoEquipo.UsuarioCreacion = gUsuarioSGI.Id
                        oeMantenimientoEquipo.Activo = True
                        oeMantenimientoEquipo.PrefijoID = gs_PrefijoIdSucursal '@0001
                        olMantenimientoEquipo.Guardar(oeMantenimientoEquipo)
                    End If
                Next
                oeMantenimientoEquipo.Seleccion = False
            Next
            mensajeEmergente.Confirmacion("Se asignaron correctamente los equipos a los mantenimientos " & Me.Text)
            Consultar(True)
            grid_EquipoAsig.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub grid_Mantenimientos_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grid_Mantenimientos.DoubleClickRow
        If grid_Mantenimientos.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub grid_MantenimientoEquipo_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles grid_MantenimientoEquipo.BeforeCellUpdate
        Try
            With grid_MantenimientoEquipo
                Select Case e.Cell.Column.Key.ToUpper
                    Case "CANTIDADMEDIDA"
                        If IsDBNull(e.NewValue) Then
                            e.Cancel = True
                            Exit Sub
                        End If
                End Select
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub grid_MantenimientoEquipo_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_MantenimientoEquipo.AfterCellUpdate
        Try
            With grid_MantenimientoEquipo
                Select Case e.Cell.Column.Key.ToUpper
                    Case "CANTIDADMEDIDA"
                        If IsDBNull(e.Cell.Value) Then
                            .ActiveRow.Cells("CantidadMedida").Value = 0
                            Exit Sub
                        End If
                End Select
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub frm_Mantenimiento_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

#End Region

#Region "Menú contextual"

    Private Sub InsertarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertarToolStripMenuItem.Click
        Nuevo()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        Editar()
    End Sub

    Private Sub mcMantenimiento_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mcMantenimiento.Opening
        mcMantenimiento.Items("InsertarToolStripMenuItem").Visible = True
        If grid_Mantenimientos.Selected.Rows.Count > 0 Then
            mcMantenimiento.Items("ActualizarToolStripMenuItem").Visible = True
            mcMantenimiento.Items("EliminarToolStripMenuItem").Visible = True
        Else
            mcMantenimiento.Items("ActualizarToolStripMenuItem").Visible = False
            mcMantenimiento.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

End Class