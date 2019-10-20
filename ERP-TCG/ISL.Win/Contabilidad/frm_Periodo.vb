'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_Periodo
    Inherits ISL.Win.frm_MenuPadre

#Region "Declaracion de Variables"

    Private WithEvents oeEjercicio As New e_Periodo
    Private olEjercicio As New l_Periodo
    Private _acl As String = ""

#End Region

#Region "Instancia"

    Private Shared instancia As frm_Periodo = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_Periodo()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            If grid_ListaPeriodo.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            _acl = gAccionSistema.NUEVO.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                Inicializar()
                oeEjercicio.TipoOperacion = "I"
                oeEjercicio.Modificado = False
                nroEjercicio.Focus()
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
                If ValidarGrilla(grid_ListaPeriodo, "Periodo") Then
                    If grid_ListaPeriodo.ActiveRow.Cells("Id").Value.ToString <> "" Then
                        Inicializar()
                        MostrarEjercicio()
                        oeEjercicio.TipoOperacion = "A"
                        oeEjercicio.Modificado = False
                        nroEjercicio.Focus()
                        MyBase.Editar()
                    Else
                        Throw New Exception("Seleccione una Fila!")
                    End If
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarEjercicio() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcEjercicio, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeEjercicio.Modificado Then
                Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        If Not GuardarEjercicio() Then
                            MostrarTabs(1, tcEjercicio)
                            Consultar(_Activo) 'activa desactiva botonera
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcEjercicio, 2)
                        Consultar(_Activo)
                End Select
            Else
                MostrarTabs(0, tcEjercicio, 2)
                Consultar(_Activo)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            _acl = gAccionSistema.ELIMINAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                With grid_ListaPeriodo
                    If ValidarGrilla(grid_ListaPeriodo, "Periodo") Then
                        If .ActiveRow.Cells("Id").Value.ToString <> "" Then
                            oeEjercicio.Id = .ActiveRow.Cells("ID").Value
                            oeEjercicio = olEjercicio.Obtener(oeEjercicio)
                            If oeEjercicio.Activo Then
                                If MessageBox.Show("Esta seguro de eliminar el Periodo: " & .ActiveRow.Cells("Codigo").Value.ToString & " ?", _
                                            "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                    Dim formulario As frm_AutenticarTrabajador
                                    formulario = New frm_AutenticarTrabajador
                                    formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                                    If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                                        ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                                        Throw New Exception("Ingrese un Clave Correcta")
                                    Else
                                        oeEjercicio.TipoOperacion = "E"
                                        olEjercicio.Eliminar(oeEjercicio)
                                        Consultar(_Activo)
                                    End If
                                End If
                            Else
                                Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                            End If
                        Else
                            Throw New Exception("Seleccione una Fila!")
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

            If grid_ListaPeriodo.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(grid_ListaPeriodo)

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

#Region "Métodos"

    Private Sub Inicializar()
        oeEjercicio = New e_Periodo
        nroEjercicio.Año = Now.Year
        nroMes.Mes = Now.Month
        txtCodigo.Text = nroEjercicio.Año.ToString + "-" + nroMes.Mes.ToString
        verCompras.Checked = False
        VerAlmacen.Checked = False
        verVentas.Checked = False
        verContabilidad.Checked = False
        VerCombustible.Checked = False
        verTesoreria.Checked = False
        fecInicio.Value = Date.Parse("01/" & Now.Month & "/" & Now.Year)
        fecFin.Value = Date.Parse(Date.DaysInMonth(Now.Year, Now.Month) & "/" & Now.Month & "/" & Now.Year)
        decTCCompra.Value = 0
        decTCVenta.Value = 0
        verActivo.Checked = oeEjercicio.Activo
        verActivo.Visible = Not oeEjercicio.Activo
        MostrarTabs(1, tcEjercicio, 1)
    End Sub

    Private Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeEjercicio = New e_Periodo
            oeEjercicio.Activo = Activo
            oeEjercicio.Ejercicio = nroEjercicioBusca.Año
            LimpiaGrid(grid_ListaPeriodo, odPeriodo)
            With grid_ListaPeriodo
                .DataSource = olEjercicio.Listar(oeEjercicio)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("CambioCompra").Hidden = True
                .DisplayLayout.Bands(0).Columns("CambioVenta").Hidden = True
                .DisplayLayout.Bands(0).Columns("IndCierre").Hidden = True
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        grid_ListaPeriodo.Focus()
    End Sub

    Private Function GuardarEjercicio() As Boolean
        Try
            If Validar() Then
                oeEjercicio.PrefijoID = gs_PrefijoIdSucursal '@0001
                olEjercicio.Guardar(oeEjercicio)
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente", True)
                MostrarTabs(0, tcEjercicio, 2)
                Consultar(True)
                grid_ListaPeriodo.Focus()
                Return True
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Validar() As Boolean
        Try
            l_FuncionesGenerales.ValidarCampoNoNulo(txtCodigo.Text, "Ingrese el Código")
            If fecInicio.DateTime = fecFin.DateTime Then Throw New Exception("La fecha de inicio y la de fin no pueden ser Iguales")
            If fecInicio.DateTime > fecFin.DateTime Then Throw New Exception("La fecha de inicio no puede ser mayor a la fecha fin")
            If Year(fecInicio.Value) <> nroEjercicio.Año Then Throw New Exception("El año de la Fecha Inicio no coincide con el Ejercicio")
            If Year(fecFin.Value) <> nroEjercicio.Año Then Throw New Exception("El año de la Fecha Fin no coincide con el Ejercicio")
            If decTCCompra.Value < 0 Then Throw New Exception("El tipo de cambio compra no puede ser menor a cero")
            If decTCVenta.Value < 0 Then Throw New Exception("El tipo de cambio venta no puede ser menor a cero")
            Return True
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub MultiSeleccion()
        With grid_ListaPeriodo.Rows
            For i As Integer = 0 To .Count - 1
                If .Item(i).Selected Then
                    Exit For
                Else
                    .Item(i).Selected = False
                End If
            Next
        End With
    End Sub

    Private Sub MostrarEjercicio()
        Try
            If grid_ListaPeriodo.ActiveRow.Cells("ID").Value.ToString.Length > 0 Then
                oeEjercicio = New e_Periodo
                oeEjercicio.Id = grid_ListaPeriodo.ActiveRow.Cells("Id").Value.ToString
                oeEjercicio = olEjercicio.Obtener(oeEjercicio)
                txtCodigo.Text = oeEjercicio.Codigo
                nroEjercicio.Año = oeEjercicio.Ejercicio
                nroMes.Mes = oeEjercicio.Mes
                fecInicio.Value = oeEjercicio.FechaInicio
                fecFin.Value = oeEjercicio.FechaFin
                VerAlmacen.Checked = oeEjercicio.CierreAlmacen
                verCompras.Checked = oeEjercicio.CierreCompras
                verContabilidad.Checked = oeEjercicio.CierreContabilidad
                VerCombustible.Checked = oeEjercicio.CierreCombustible
                verTesoreria.Checked = oeEjercicio.CierreTesoreria
                verVentas.Checked = oeEjercicio.CierraVentas
                verCajaLiquidacion.Checked = oeEjercicio.CierreCajaLiquidacion
                verPlanillas.Checked = oeEjercicio.CierrePlanilla
                decTCCompra.Value = oeEjercicio.CambioCompra
                decTCVenta.Value = oeEjercicio.CambioVenta
                verActivo.Checked = oeEjercicio.Activo
                verActivo.Visible = Not oeEjercicio.Activo
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub oeEjercicio_DatoCambiado() Handles oeEjercicio.DatoCambiado
        oeEjercicio.Modificado = True
    End Sub

    Private Sub frm_Periodo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Periodo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm_Periodo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            MostrarTabs(0, tcEjercicio)
            grid_ListaPeriodo.DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
            grid_ListaPeriodo.DisplayLayout.Override.RowSelectors = DefaultableBoolean.True
            InicializaTiempo()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub timTiempo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timTiempo.Tick
        _tiempo = _tiempo - 1
    End Sub

    Private Sub grid_ListaEjercicio_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid_ListaPeriodo.DoubleClick
        If grid_ListaPeriodo.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub grid_ListaEjercicio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid_ListaPeriodo.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub grid_ListaEjercicio_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grid_ListaPeriodo.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

    Private Sub grid_ListaPeriodo_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles grid_ListaPeriodo.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub mnuEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEliminar.Click
        Eliminar()
    End Sub

    Private Sub nroEjercicio_DatoCambiado() Handles nroEjercicio.DatoCambiado
        oeEjercicio.Ejercicio = nroEjercicio.Año
        oeEjercicio.Codigo = nroEjercicio.Año.ToString + "-" + nroMes.Mes.ToString
        txtCodigo.Text = oeEjercicio.Codigo
        ''fecInicio.Value = PrimerDiaMes(Date.Parse("01/" + nroMes.Mes.ToString + "/" + nroEjercicio.Año.ToString))
        ''fecFin.Value = UltimoDiaMes(Date.Parse("01/" + nroMes.Mes.ToString + "/" + nroEjercicio.Año.ToString))
    End Sub

    Private Sub nroMes_DatoCambiado() Handles nroMes.DatoCambiado
        oeEjercicio.Mes = nroMes.Mes
        oeEjercicio.Codigo = nroEjercicio.Año.ToString + "-" + nroMes.Mes.ToString
        txtCodigo.Text = oeEjercicio.Codigo
        ''fecInicio.Value = PrimerDiaMes(Date.Parse("01/" + nroMes.Mes.ToString + "/" + nroEjercicio.Año.ToString))
        ''fecFin.Value = UltimoDiaMes(Date.Parse("01/" + nroMes.Mes.ToString + "/" + nroEjercicio.Año.ToString))
    End Sub

    Private Sub fecInicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecInicio.ValueChanged
        oeEjercicio.FechaInicio = fecInicio.Value
    End Sub

    Private Sub fecFin_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecFin.ValueChanged
        oeEjercicio.FechaFin = fecFin.Value
    End Sub

    Private Sub verCompras_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verCompras.CheckedChanged
        oeEjercicio.CierreCompras = verCompras.Checked
    End Sub

    Private Sub VerAlmacen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerAlmacen.CheckedChanged
        oeEjercicio.CierreAlmacen = VerAlmacen.Checked
    End Sub

    Private Sub verContabilidad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verContabilidad.CheckedChanged
        oeEjercicio.CierreContabilidad = verContabilidad.Checked
    End Sub

    Private Sub VerCombustible_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerCombustible.CheckedChanged
        oeEjercicio.CierreCombustible = VerCombustible.Checked
    End Sub

    Private Sub verVentas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verVentas.CheckedChanged
        oeEjercicio.CierraVentas = verVentas.Checked
    End Sub

    Private Sub verTesoreria_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verTesoreria.CheckedChanged
        oeEjercicio.CierreTesoreria = verTesoreria.Checked
    End Sub

    Private Sub verPlanillas_CheckedChanged(sender As Object, e As EventArgs) Handles verPlanillas.CheckedChanged
        oeEjercicio.CierrePlanilla = verPlanillas.Checked
    End Sub

    Private Sub decTCCompra_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decTCCompra.ValueChanged
        oeEjercicio.CambioCompra = decTCCompra.Value
    End Sub

    Private Sub decTCVenta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decTCVenta.ValueChanged
        oeEjercicio.CambioVenta = decTCVenta.Value
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeEjercicio.Activo = verActivo.Checked
    End Sub

    Private Sub verCajaLiquidacion_CheckedChanged(sender As Object, e As EventArgs) Handles verCajaLiquidacion.CheckedChanged
        oeEjercicio.CierreCajaLiquidacion = verCajaLiquidacion.Checked
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem.Click
        Nuevo()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        Editar()
    End Sub

#End Region

End Class
