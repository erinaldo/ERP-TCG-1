Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Configuration
Imports Infragistics.Win.CalcEngine
Imports Infragistics.Win.UltraWinDataSource
Imports System.Threading
Imports System.Data.OleDb

Public Class frm_FlotaZona
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_FlotaZona = Nothing
    Private Shared Operacion As String
    Private Estado As String

    ''' <summary>
    ''' Instancia unica de Formulario: frm_DemandaRapida
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function getInstancia() As frm_MenuPadre

        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_FlotaZona()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de variables"

    Dim olFlota As New l_Flota
    Dim oeFlota As New e_Flota
    Dim _ingresando_datos As Boolean = False

    Private oeJefe As e_Flota_Trabajador
    Private lstJefe As List(Of e_Flota_Trabajador)
    Private oeCuotas As e_Flota_Cuota, olCuota As l_Flota_Cuota, lstCuotas As List(Of e_Flota_Cuota)
    Private olJefe As l_Flota_Trabajador
    Private olCombo As l_Combo
#End Region

#Region "BOTONES"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Operacion = "Inicializa"
        If Activo Then
            Estado = " Activo"
        Else
            Estado = " Inactivo"
        End If
        Try
            Listar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Operacion = "Nuevo"
            Inicializar()
            MostrarTabs(1, ficDemanda, 1)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            txtNombre.Focus()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try

    End Sub

    Public Overrides Sub Editar()
        Try
            If griLista.Selected.Rows.Count > 0 Then
                ugb_Espera.Visible = True
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                Inicializar()
                If EditarFlota() Then
                    Operacion = "Editar"
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                End If
                txtNombre.Focus()
            Else
                mensajeEmergente.Problema("Seleccione registro", True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarFlota() Then
                MostrarTabs(0, ficDemanda, 2)
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficDemanda, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                Case Windows.Forms.DialogResult.Yes
                    If GuardarFlota() Then
                        MostrarTabs(0, ficDemanda, 2)
                        _ingresando_datos = False
                        Operacion = "Inicializa"
                        ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                    Else
                        _ingresando_datos = True
                    End If
                Case Windows.Forms.DialogResult.No
                    MostrarTabs(0, ficDemanda, 2)
                    _ingresando_datos = False
                    Operacion = "Inicializa"
                    ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                Case Windows.Forms.DialogResult.Cancel
                    _ingresando_datos = True
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If griLista.Selected.Rows.Count > 0 Then
                griLista.ActiveRow.Delete()
            Else
                mensajeEmergente.Problema("Seleccione registro", True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            MyBase.Imprimir()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Salir()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            MyBase.Salir()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    'Public Overrides Sub Exportar()
    '    Try
    '        ugb_Espera.Visible = True
    '        Application.DoEvents()
    '        Cursor.Current = Cursors.WaitCursor
    '        Cursor.Show()
    '        Exportar_Excel(griLista)
    '        MyBase.Exportar()
    '        ugb_Espera.Visible = False
    '    Catch ex As Exception
    '        ugb_Espera.Visible = False
    '    Finally
    '        Windows.Forms.Cursor.Current = Cursors.Default
    '        Cursor.Show()
    '        ugb_Espera.Visible = False
    '    End Try
    'End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try

            If griLista.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griLista)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_FlotaZona_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Select Case Operacion
            Case "Nuevo"
                Me.Activate()
                Me.Cancelar()
            Case "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_FlotaZona_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Select Case Operacion
            Case "Nuevo"
                MyBase.Nuevo()
            Case "Editar"
                MyBase.Editar()
            Case "Inicializa"
                MostrarTabs(0, ficDemanda)
                If _Activo Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
                'Consultar(True)
        End Select
    End Sub

    Private Sub frm_FlotaZona_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub griLista_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griLista.InitializeLayout
        Try
            agrListaRegistro.Text = "Lista Registros: " & griLista.Rows.Count & Estado
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griLista_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griLista.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            If EliminarFlota() Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        Catch ex As Exception
            e.Cancel = True
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Sub

    Private Sub frm_FlotaZona_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case ficDemanda.SelectedTab.Index
                Case 0

                Case 1
                    Select Case e.KeyCode
                        Case Keys.Enter
                            SendKeys.Send("{TAB}")
                        Case Keys.Insert
                            tsbAgregar.PerformClick()
                        Case Keys.Delete
                            tsbQuitar.PerformClick()
                    End Select
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_FlotaZona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mt_CargarIconos()
            griLista.DisplayLayout.Bands(0).Columns("IndZona").Header.Caption = "Zona" & Environment.NewLine & "(Territorio)"
            'Llenar Combo 
            LlenarComboMaestro(cboJefeAsignado, TrabajadorPublic, -1)
            'Formato Grid
            lstJefe = New List(Of e_Flota_Trabajador)
            griJefe.DataSource = lstJefe
            'Deshabilitar Ordenar Grilla Jefes
            For Each _Columna In griJefe.DisplayLayout.Bands(0).Columns
                _Columna.SortIndicator = SortIndicator.Disabled
            Next
            OcultarColumna(griJefe, True, "IdFlota", "UsuarioCreacion", "FechaCreacion", "UsuarioModificacion", "FechaModificacion", "Activo")
            With griJefe.DisplayLayout.Bands(0)
                Dim i As Integer = 0
                'Posicion
                .Columns("IdTrabajador").Header.VisiblePosition = i : i += 1
                .Columns("IdTrabajador").Header.Caption = "Jefe"
                .Columns("FechaInicio").Header.VisiblePosition = i : i += 1
                .Columns("FechaInicio").Header.Caption = "Fecha Inicio"
                .Columns("FechaFin").Header.VisiblePosition = i : i += 1
                .Columns("FechaFin").Header.Caption = "Fecha Fin"
                .Columns("Glosa").Header.VisiblePosition = i : i += 1
                .Columns("Actual").Header.VisiblePosition = i : i += 1
            End With
            olCombo = New l_Combo
            CrearComboGrid("IdTrabajador", "Nombre", griJefe, olCombo.ComboGrilla(TrabajadorPublic), False)
            'Inicializar Variable Lofica
            olJefe = New l_Flota_Trabajador
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griLista_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles griLista.DoubleClickRow
        Try
            If griLista.Selected.Rows.Count > 0 Then Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAgregarCuota_Click(sender As Object, e As EventArgs) Handles btnAgregarCuota.Click
        Try
            If numCuotaTracto.Value > 0 Then
                oeCuotas = New e_Flota_Cuota
                oeCuotas.TipoOperacion = "I" : oeCuotas.Activo = True
                oeCuotas.UsuarioCreacion = gUsuarioSGI.Id
                oeCuotas.Importe = numCuotaTracto.Value
                oeCuotas.FechaInicio = fecCuota.Value
                oeCuotas.Vigente = 1
                For Each oItem In lstCuotas.Where(Function(it) it.Vigente = 1).ToList
                    oItem.Vigente = 0 : oItem.TipoOperacion = "A" : oItem.UsuarioModifica = gUsuarioSGI.Id
                Next
                lstCuotas.Add(oeCuotas)
                mt_CargarCuota(lstCuotas)
                griCuota.DataBind()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnQuitarCuota_Click(sender As Object, e As EventArgs) Handles btnQuitarCuota.Click
        Try

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Métodos"

    Private Sub Inicializar()
        Try
            txtId.Text = String.Empty
            txtCodigo.Text = String.Empty
            txtNombre.Text = String.Empty
            txtDescripcion.Text = String.Empty
            verZona.Checked = False
            verFlota.Checked = False
            cboJefeAsignado.SelectedIndex = -1
            cboJefeAsignado.Text = String.Empty
            dtpFechaInicio.Value = Now.Date
            txtGlosa.Text = String.Empty
            numCuotaTracto.Value = 0
            fecCuota.Value = Now.Date
            lstJefe.Clear() : griJefe.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Listar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeFlota = New e_Flota
            griLista.DataSource = olFlota.Listar(oeFlota)
            'Ubica el cursor el el primer registro de la grilla
            If griLista.Rows.Count > 0 Then
                griLista.Focus()
                griLista.Rows.Item(0).Selected = True
                ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 1, 0, 1)
            End If
            griLista.Focus()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Function EditarFlota() As Boolean
        Try
            If griLista.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                oeFlota = New e_Flota
                oeFlota.Id = griLista.ActiveRow.Cells("Id").Value
                oeFlota = olFlota.Obtener(oeFlota)
                If oeFlota.Activo Then
                    txtId.Text = oeFlota.Id
                    txtCodigo.Text = oeFlota.Codigo
                    txtNombre.Text = oeFlota.Nombre
                    txtDescripcion.Text = oeFlota.Descripcion
                    verZona.Checked = oeFlota.IndZona
                    verFlota.Checked = oeFlota.IndFlota
                    VerZonaD2.Checked = oeFlota.IndZonaD2
                    numCuotaTracto.Value = oeFlota.CuotaTracto
                    'Jefes
                    lstJefe.Clear()
                    oeJefe = New e_Flota_Trabajador : oeJefe.IdFlota = oeFlota.Id
                    lstJefe.AddRange(olJefe.Listar(oeJefe).OrderBy(Function(x) x.FechaInicio.Date).ThenBy(Function(x) x.FechaFin.Date).ThenBy(Function(x) x.Actual).ToList())
                    griJefe.DataBind()
                    ' Cargar Cuotas
                    olCuota = New l_Flota_Cuota
                    oeCuotas = New e_Flota_Cuota : lstCuotas = New List(Of e_Flota_Cuota)
                    oeCuotas.IdFlota = oeFlota.Id : oeCuotas.Vigente = -1
                    lstCuotas = olCuota.Listar(oeCuotas)
                    mt_CargarCuota(lstCuotas)
                    MostrarTabs(1, ficDemanda, 1)
                    Consultar(True)
                Else
                    Throw New Exception("El Registro se encuentra eliminada no se puede editar")
                End If
            End If
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        End Try
    End Function

    Private Function GuardarFlota() As Boolean
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If ValidaCamposCabecera() Then
                oeFlota = New e_Flota
                With oeFlota
                    .TipoOperacion = "I"
                    .Id = txtId.Text.Trim()
                    .Codigo = txtCodigo.Text.Trim()
                    .Nombre = txtNombre.Text.Trim()
                    .Activo = True
                    .IndZona = verZona.Checked
                    .IndFlota = verFlota.Checked
                    .IndZonaD2 = VerZonaD2.Checked
                    .Descripcion = txtDescripcion.Text.Trim()
                    .CuotaTracto = numCuotaTracto.Value
                    If verZona.Checked AndAlso lstJefe.Where(Function(x) x.TipoOperacion <> "E" And x.Actual).Count > 0 Then
                        .IdJefeActual = lstJefe.Where(Function(x) x.TipoOperacion <> "E" And x.Actual)(0).IdTrabajador
                    End If
                    'Detalles
                    .ListJefes.Clear()
                    .ListJefes.AddRange(lstJefe)
                    .ListCuotas = lstCuotas
                End With
                If olFlota.Guardar(oeFlota) Then mensajeEmergente.Confirmacion(Me.Text & ": La informacion ha sido grabada satisfactoriamente", True)
                Consultar(True)
                Operacion = "Inicializa"
                If griLista.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 1, 0, 1)
                End If
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Function

    Private Function EliminarFlota() As Boolean
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            With griLista
                If ValidarGrilla(griLista, "Demanda Rapida") Then
                    oeFlota = New e_Flota
                    oeFlota.Id = griLista.ActiveRow.Cells("Id").Value
                    oeFlota = olFlota.Obtener(oeFlota)
                    If oeFlota.Activo Then
                        If lf_ValidarEliminar() AndAlso MessageBox.Show("Esta seguro de eliminar la Flota / Zona: " & _
                                                 oeFlota.Codigo & " ?", _
                                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            olFlota.Eliminar(oeFlota)
                            'Consultar(True)
                            Operacion = "Inicializa"
                            If griLista.Rows.Count > 0 Then
                                ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                            Else
                                ControlBoton(1, 1, 0, 0, 0, 0, 1, 0, 1)
                            End If
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
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Function

    Private Function ValidaCamposCabecera() As Boolean
        Try
            'Cabecera
            l_FuncionesGenerales.ValidarCampoNoNulo(txtNombre.Text, "Seleccione Nombre")
            If verZona.Checked = False AndAlso verFlota.Checked = False AndAlso VerZonaD2.Checked = False Then
                mensajeEmergente.Problema("Seleccione Zona, Flota o Zona D2", True)
                Return False
            End If
            'Detalle
            If verFlota.Checked Then
                'verifica que agregar almenos un jefe actual
                If lstJefe.Where(Function(x) x.Actual And x.TipoOperacion <> "E").Count = 0 Then
                    MessageBox.Show("Debe agregar almenos un jefe actual", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return False
                End If
                'Verificar si existen unidades con la flota editada y con un usuario responsable diferente al actual asignado
                Dim oeVehiculo As New e_Vehiculo, olVehiculo As New l_Vehiculo, lstVehiculo As New List(Of e_Vehiculo)
                oeVehiculo.IdFlota = txtId.Text.Trim()
                lstVehiculo.AddRange(olVehiculo.Listar(oeVehiculo))
                If lstVehiculo.Count > 0 AndAlso lstVehiculo.Where(Function(x) x.ConductorAsignada <> lstJefe.Where(Function(i) i.TipoOperacion <> "E" And i.Actual)(0).IdTrabajador).Count > 0 Then
                    Dim Jefe As String = ""
                    Dim UnidadesJefeAnterior As Integer = lstVehiculo.Where(Function(x) x.ConductorAsignada <> lstJefe.Where(Function(i) i.TipoOperacion <> "E" And i.Actual)(0).IdTrabajador).Count
                    If TrabajadorPublic.Where(Function(x) x.Id = lstJefe.Where(Function(i) i.TipoOperacion <> "E" And i.Actual)(0).IdTrabajador).Count > 0 Then
                        Jefe = TrabajadorPublic.Where(Function(x) x.Id = lstJefe.Where(Function(i) i.TipoOperacion <> "E" And i.Actual)(0).IdTrabajador)(0).Nombre
                    End If
                    Dim DR As DialogResult = MessageBox.Show("Existen " & UnidadesJefeAnterior & " vehículos con flota: " & txtNombre.Text.Trim() & " y" & Environment.NewLine & _
                                       "Responsable de Unidad diferente a: " & Environment.NewLine & _
                                       Jefe & Environment.NewLine & _
                                       "¿Desea actualizar el Responsable de las Unidades?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

                    If DR = Windows.Forms.DialogResult.Yes Then
                        oeVehiculo = New e_Vehiculo
                        oeVehiculo.TipoOperacion = "M"
                        oeVehiculo.IdFlota = txtId.Text.Trim()
                        oeVehiculo.ConductorAsignada = lstJefe.Where(Function(i) i.TipoOperacion <> "E" And i.Actual)(0).IdTrabajador
                        olVehiculo.GuardarJefeUnidad(oeVehiculo)
                    ElseIf DR = Windows.Forms.DialogResult.Cancel Then
                        Return False
                    End If
                End If
            End If
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Private Sub mt_CargarIconos()
        Try
            For Each Item In gLstIconos
                Select Case Item.Nombre
                    Case "Agregar" : btnAgregarCuota.Appearance.Image = Item.Icono
                    Case "Quitar" : btnQuitarCuota.Appearance.Image = Item.Icono
                End Select
            Next
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mt_CargarCuota(ByVal leCuota As List(Of e_Flota_Cuota))
        Try
            With griCuota
                .ResetDisplayLayout()
                .DataSource = leCuota.OrderByDescending(Function(it) it.FechaInicio).ToList
                ConfiguraGrilla(griCuota, "Tahoma", False, UIElementBorderStyle.Default, "Vigente")
                OcultarColumna2(griCuota, False, "Vigente", "Importe", "FechaInicio", "FechaFin")
                FormatoColumna(griCuota, "", ColumnStyle.CheckBox, HAlign.Default, "Vigente")
                FormatoColumna(griCuota, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Importe")
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griCuota_CellChange(sender As Object, e As CellEventArgs) Handles griCuota.CellChange
        griCuota.UpdateData()
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    'Private Sub frm_DemandaRapida_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
    '    InicializaTiempo()
    'End Sub

    'Private Sub griLista_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griLista.MouseMove
    '    If _tiempo <= 0 Then
    '        Consultar(True)
    '    End If
    '    InicializaTiempo()
    'End Sub

    'Public Overloads Function InicializaTiempo() As Integer
    '    _tiempo = 120
    'End Function

#End Region

#Region "Menú contextual del maestro de Demandas rápidas"


    Private Sub InsertarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Insert.Click
        Nuevo()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update.Click
        Editar()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        Eliminar()
    End Sub

#End Region

#Region "Funciones"

    Private Function lf_ValidarEliminar() As Boolean
        Try
            Dim oeCombo As New e_Combo
            Dim olCombo As New l_Combo
            oeCombo.Id = griLista.ActiveRow.Cells("Id").Value.ToString().Trim()
            oeCombo.Nombre = "FlotaVehiculo"
            If olCombo.Listar(oeCombo).Count > 0 Then
                MessageBox.Show("No se puede eliminar la flota porque esta asignada en almenos un vehículo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Jefe Asignado"

    Private Sub tspJefeAsignado_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tspJefeAsignado.ItemClicked
        Try
            Select Case e.ClickedItem.Name
                Case tsbAgregar.Name
                    mt_AgregarJefe()
                Case tsbQuitar.Name
                    mt_QuitarJefe()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mt_AgregarJefe()
        Try
            If fc_ValidarAgregarJefe() Then
                oeJefe = New e_Flota_Trabajador
                With oeJefe
                    .IdTrabajador = cboJefeAsignado.Value
                    .FechaInicio = dtpFechaInicio.Value
                    .FechaFin = dtpFechaInicio.Value
                    .Glosa = txtGlosa.Text.Trim()
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .Actual = True
                End With
                'Colocar al Ultimo registro la Fecha Final = Fecha Inicio del que se Ingresa
                If lstJefe.Where(Function(x) x.TipoOperacion <> "E").Count > 0 Then
                    lstJefe.Where(Function(x) x.TipoOperacion <> "E").OrderByDescending(Function(x) x.FechaInicio.Date).ThenByDescending(Function(x) x.FechaFin.Date).ThenByDescending(Function(x) x.Actual).ToList()(0).FechaFin = oeJefe.FechaInicio
                End If
                'Colocar Actual 0 a todos los registros
                For Each Jefe As e_Flota_Trabajador In lstJefe
                    Jefe.Actual = False
                Next
                'Agregar flota a la lista
                lstJefe.Add(oeJefe)
                griJefe.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function fc_ValidarAgregarJefe()
        Try
            If cboJefeAsignado.SelectedIndex < 0 Then
                MessageBox.Show("Seleccione Jefe Asignado", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cboJefeAsignado.Focus()
                Return False
            End If
            If lstJefe.Where(Function(x) x.TipoOperacion <> "E").Count > 0 Then
                Dim ldUltimaFecha As Date = lstJefe.Where(Function(x) x.TipoOperacion <> "E").OrderByDescending(Function(x) x.FechaInicio.Date).ThenByDescending(Function(x) x.FechaFin.Date).ThenByDescending(Function(x) x.Actual).ToList()(0).FechaInicio
                If DateTime.Compare(ldUltimaFecha.Date, dtpFechaInicio.Value.Date) > 0 Then
                    MessageBox.Show("La fecha ingresada debe ser mayor a la ultima Fecha: " & ldUltimaFecha.ToShortDateString(), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtpFechaInicio.Focus()
                    Return False
                End If
                Dim strIdUltimoJefe As String = lstJefe.Where(Function(x) x.TipoOperacion <> "E").OrderByDescending(Function(x) x.FechaInicio.Date).ThenByDescending(Function(x) x.FechaFin.Date).ThenByDescending(Function(x) x.Actual).ToList()(0).IdTrabajador
                If cboJefeAsignado.Value = strIdUltimoJefe Then
                    MessageBox.Show("Debe Ingresar un jefe diferente al último asignado " & Environment.NewLine & cboJefeAsignado.Text, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cboJefeAsignado.Focus()
                    Return False
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub mt_QuitarJefe()
        Try
            If gf_ValidarFilaSeleccionada(griJefe) Then
                If gUsuarioSGI.Controlado = 0 Then
                    With griJefe
                        If Not String.IsNullOrEmpty(.ActiveRow.Cells("Id").Value.ToString().Trim()) Then
                            lstJefe(lstJefe.IndexOf(.ActiveRow.ListObject)).TipoOperacion = "E"
                            lstJefe(lstJefe.IndexOf(.ActiveRow.ListObject)).UsuarioCreacion = gUsuarioSGI.Id
                            .ActiveRow.Hidden = True
                        Else
                            lstJefe.Remove(.ActiveRow.ListObject)
                        End If
                        .DataBind()
                        'Marcar el último registro como actual
                        If lstJefe.Where(Function(x) x.TipoOperacion <> "E").Count > 0 AndAlso _
                             lstJefe.Where(Function(x) x.TipoOperacion <> "E" And x.Actual).Count = 0 Then
                            .Rows.Where(Function(x) x.Hidden = False).OrderByDescending(Function(x) x.Index)(0).Cells("Actual").Value = 1
                            .UpdateData()
                        End If
                    End With
                Else
                    MessageBox.Show("Usted no tiene permiso para eliminar un Jefe", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griJefe_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griJefe.BeforeRowsDeleted
        Try
            e.Cancel = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private bolExistRowCheck As Boolean = False
    Private Sub griJefe_BeforeCellUpdate(sender As Object, e As BeforeCellUpdateEventArgs) Handles griJefe.BeforeCellUpdate
        Try
            If e.Cell.Row.Index >= 0 Then
                Select Case e.Cell.Column.Key
                    Case "Actual"
                        bolExistRowCheck = lstJefe.Exists(Function(x) x.Actual And x.TipoOperacion <> "E")
                End Select
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griJefe_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles griJefe.AfterCellUpdate
        Try
            If e.Cell.Row.Index >= 0 Then
                Select Case e.Cell.Column.Key
                    Case "Actual"
                        If bolExistRowCheck Then
                            For Each Jefe As e_Flota_Trabajador In lstJefe.Where(Function(x) x.Actual And x.TipoOperacion <> "E")
                                If Jefe.Actual Then
                                    Jefe.Actual = 0
                                End If
                            Next
                        End If
                        griJefe.DataBind()
                End Select
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griJefe_CellChange(sender As Object, e As CellEventArgs) Handles griJefe.CellChange
        Try
            griJefe.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

End Class