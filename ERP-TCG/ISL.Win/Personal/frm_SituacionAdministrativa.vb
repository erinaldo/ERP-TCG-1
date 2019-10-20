'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_SituacionAdministrativa
    Inherits ISL.Win.frm_MenuPadre

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_SituacionAdministrativa = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_SituacionAdministrativa()
        End If
        instancia.Activate()
        Return instancia

    End Function

#Region "Declaracion de Variables"

    Dim oeSituacionAdministrativa As New e_SituacionAdministrativa
    Dim olSituacionAdministrativa As New l_SituacionAdministrativa
    Dim _ingresando_datos As Boolean = False

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Instancia"
            If griSituacionAdministrativa.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        oeSituacionAdministrativa.TipoOperacion = "I"
        MostrarTabs(1, ficSituacionAdministrativa, 1)
        Inicializar()
        txtCodigo.Focus()
        Operacion = "Nuevo"
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        Mostrar()
        oeSituacionAdministrativa.TipoOperacion = "A"
        txtCodigo.Focus()
        Operacion = "Editar"
        MyBase.Editar()
    End Sub

    Public Overrides Sub Guardar()
        Try
            If Guardando() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficSituacionAdministrativa, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeSituacionAdministrativa.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If Guardando() Then
                            MostrarTabs(0, ficSituacionAdministrativa, 2)
                            _ingresando_datos = False
                            Consultar(_Activo)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficSituacionAdministrativa, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficSituacionAdministrativa, 2)
                        _ingresando_datos = False
                        Consultar(_Activo)
                End Select
            Else
                MostrarTabs(0, ficSituacionAdministrativa, 2)
                _ingresando_datos = False
                Consultar(_Activo)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With griSituacionAdministrativa
                If ValidarGrilla(griSituacionAdministrativa, "Trabajador") Then
                    oeSituacionAdministrativa.Id = .ActiveRow.Cells("ID").Value
                    oeSituacionAdministrativa = olSituacionAdministrativa.Obtener(oeSituacionAdministrativa)
                    If oeSituacionAdministrativa.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar el SituacionAdministrativa: " & _
                                 .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeSituacionAdministrativa.TipoOperacion = "E"
                            olSituacionAdministrativa.Eliminar(oeSituacionAdministrativa)
                            Consultar(True)
                        End If
                    Else
                        Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            If griSituacionAdministrativa.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griSituacionAdministrativa)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Cargo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Cargo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm_Cargo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        Tiempo1.Enabled = False
        MostrarTabs(0, ficSituacionAdministrativa)
        InicializaTiempo()

        cboTipo.Items.Clear()
        cboTipo.Items.Add("FALTAS")
        cboTipo.Items.Add("DESCANSO")
        cboTipo.Items.Add("VACACIONES")
        cboTipo.SelectedIndex = -1

    End Sub

    Private Sub txtAbreviatura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAbreviatura.KeyDown
        TeclaPulsada(e)
        oeSituacionAdministrativa.Modificado = True
    End Sub

    Private Sub txtAbreviatura_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbreviatura.ValueChanged
        oeSituacionAdministrativa.Abreviatura = txtAbreviatura.Text.Trim
    End Sub

    Private Sub txtCodigoPlame_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoPlame.KeyDown
        TeclaPulsada(e)
        oeSituacionAdministrativa.Modificado = True
    End Sub

    Private Sub txtCodigoPlame_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoPlame.ValueChanged
        oeSituacionAdministrativa.CodigoPlame = txtCodigoPlame.Text.Trim
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        TeclaPulsada(e)
        oeSituacionAdministrativa.Modificado = True
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        oeSituacionAdministrativa.Codigo = txtCodigo.Text.Trim
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        TeclaPulsada(e)
        oeSituacionAdministrativa.Modificado = True
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        oeSituacionAdministrativa.Nombre = txtNombre.Text
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeSituacionAdministrativa.Activo = verActivo.Checked
    End Sub

    Private Sub verRemunerado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verRemunerado.CheckedChanged
        oeSituacionAdministrativa.Remunerado = verRemunerado.Checked
    End Sub

    Private Sub verAcumulaVacaciones_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verAcumulaVacaciones.CheckedChanged
        oeSituacionAdministrativa.AcumulaVacaciones = verAcumulaVacaciones.Checked
    End Sub

    Private Sub griSituacionAdministrativa_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griSituacionAdministrativa.DoubleClick
        If griSituacionAdministrativa.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griSituacionAdministrativa_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griSituacionAdministrativa.InitializeLayout
        agrListaSituacionAdministrativas.Text = "Total de Situaciones Administrativas: " & e.Layout.Rows.Count
    End Sub

    Private Sub cboTipo_ValueChanged(sender As Object, e As EventArgs) Handles cboTipo.ValueChanged
        oeSituacionAdministrativa.IndTipo = cboTipo.SelectedIndex
    End Sub

#End Region

#Region "Metodos"

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            oeSituacionAdministrativa = New e_SituacionAdministrativa
            Tiempo1.Enabled = True
            With griSituacionAdministrativa
                oeSituacionAdministrativa.Activo = Activo
                .DataSource = olSituacionAdministrativa.Listar(oeSituacionAdministrativa)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True

                .DisplayLayout.Bands(0).Columns("AcumulaVacaciones").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
                .DisplayLayout.Bands(0).Columns("Remunerado").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect

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
        griSituacionAdministrativa.Focus()
    End Sub

    Private Sub Inicializar()
        txtCodigo.Text = String.Empty
        txtNombre.Text = String.Empty
        txtAbreviatura.Text = String.Empty
        verActivo.Checked = True
        verRemunerado.Checked = True
        verAcumulaVacaciones.Checked = True
        AsociarMenu()
    End Sub

    Private Sub Mostrar()
        Try
            If griSituacionAdministrativa.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeSituacionAdministrativa.Id = griSituacionAdministrativa.ActiveRow.Cells("Id").Value.ToString
                oeSituacionAdministrativa = olSituacionAdministrativa.Obtener(oeSituacionAdministrativa)
                txtCodigo.Text = oeSituacionAdministrativa.Codigo
                txtNombre.Text = oeSituacionAdministrativa.Nombre
                txtAbreviatura.Text = oeSituacionAdministrativa.Abreviatura
                txtCodigoPlame.Text = oeSituacionAdministrativa.CodigoPlame
                cboTipo.SelectedIndex = oeSituacionAdministrativa.IndTipo
                verActivo.Checked = oeSituacionAdministrativa.Activo
                verRemunerado.Checked = oeSituacionAdministrativa.Remunerado
                verAcumulaVacaciones.Checked = oeSituacionAdministrativa.AcumulaVacaciones
                MostrarTabs(1, ficSituacionAdministrativa, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function Guardando() As Boolean
        Try
            oeSituacionAdministrativa.UsuarioCreacion = gUsuarioSGI.Id
            oeSituacionAdministrativa.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olSituacionAdministrativa.Guardar(oeSituacionAdministrativa) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, ficSituacionAdministrativa, 2)
                Consultar(_Activo)
                griSituacionAdministrativa.Focus()
                Return True
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Function

    Private Sub Enfocar(ByVal excepcion As String)
        Select Case excepcion
            Case excepcion.Contains("Codigo")
                txtCodigo.Focus()
            Case excepcion.Contains("Nombre")
                txtNombre.Focus()
        End Select

    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_SituacionAdministrativa_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griSituacionAdministrativa_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griSituacionAdministrativa.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro de SituacionAdministrativas"

    Private Sub AsociarMenu()
        griSituacionAdministrativa.ContextMenuStrip = MenuContextual1
    End Sub

    Private Sub InsertarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertarToolStripMenuItem.Click
        Nuevo()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        Editar()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar()
    End Sub

    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        MenuContextual1.Items("InsertarToolStripMenuItem").Visible = True
        If griSituacionAdministrativa.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

    
End Class