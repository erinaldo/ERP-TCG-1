'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports ISL.Controles

Public Class frm_ConceptosGenerales
    Inherits frm_MenuPadre

#Region "Inicializar el formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Private Shared Instancia As frm_ConceptosGenerales = Nothing
    Private Shared Operacion As String
    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_ConceptosGenerales()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Declaración de variables"

    'Variables para inicializar el objeto ConceptosGenerales
    Dim olConceptosGenerales As New l_ConceptosGenerales
    'Declaración de instancia para el control de modificaciones de la entidad en el formulario
    Private WithEvents oeConceptosGenerales As New e_ConceptosGenerales
    'Variable para controlar el estado de los registros mostrados (Activo - Inactivo)
    Dim Estado As String
    'Variable para controlar el estado de la botonera principal del sistema
    Dim _ingresando_datos As Boolean = False

#End Region

#Region "Botones"

    ''' <summary>
    ''' Método para consultar y listar ConceptosGeneraless
    ''' </summary>
    ''' <param name="Activo"></param>
    ''' <remarks></remarks>
    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(True)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griConceptosGenerales.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método para crear un nuevo ConceptosGenerales
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Nuevo()
        verActivo.Visible = False
        oeConceptosGenerales.TipoOperacion = "I"
        oeConceptosGenerales.UsuarioCreacion = gUsuarioSGI.Id
        oeConceptosGenerales.Protegido = 1
        MostrarTabs(1, ficConceptosGenerales, 1)
        Inicializar()
        cboProceso.Focus()
        Operacion = "Nuevo"
        MyBase.Nuevo()
        oeConceptosGenerales.Modificado = False
    End Sub

    ''' <summary>
    ''' Método para editar un ConceptosGenerales específico
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Editar()
        verActivo.Visible = True
        MostrarConceptosGenerales()
        oeConceptosGenerales.TipoOperacion = "A"
        txtCodigo.Focus()
        Operacion = "Editar"
        MyBase.Editar()
        oeConceptosGenerales.Modificado = False
    End Sub

    ''' <summary>
    ''' Método para Guardar la información del ConceptosGenerales
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Guardar()
        Try
            If GuardarConceptosGenerales() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficConceptosGenerales, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método para cancelar la edición de la información de un ConceptosGenerales
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Cancelar()
        Try
            If oeConceptosGenerales.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarConceptosGenerales() Then
                            MostrarTabs(0, ficConceptosGenerales, 2)
                            _ingresando_datos = False
                            MyBase.Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficConceptosGenerales, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficConceptosGenerales, 2)
                        _ingresando_datos = False
                        MyBase.Consultar(True)
                End Select
            Else
                MostrarTabs(0, ficConceptosGenerales, 2)
                _ingresando_datos = False
                MyBase.Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método para eliminar un ConceptosGenerales
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Eliminar()
        Try

            If ValidarGrilla(griConceptosGenerales, "ConceptosGenerales") Then
                oeConceptosGenerales.Id = griConceptosGenerales.ActiveRow.Cells("ID").Value
                oeConceptosGenerales = olConceptosGenerales.Obtener(oeConceptosGenerales)
                If oeConceptosGenerales.Activo Then
                    If MessageBox.Show("Esta seguro de eliminar el ConceptosGenerales: " & _
                    griConceptosGenerales.ActiveRow.Cells("Nombre").Value.ToString.Trim & "?", _
                    "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        oeConceptosGenerales.TipoOperacion = "E"
                        olConceptosGenerales.Eliminar(oeConceptosGenerales)
                        Consultar(True)
                    End If
                Else
                    Throw New Exception("La informacion se encuentra eliminada en " & Me.Text)
                End If
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método para imprimir un listado de ConceptosGenerales
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
        'Dim frm As frm_ReporteBasico = frm_ReporteConceptosGenerales
        'frm.MdiParent = frm_Menu
        'frm.Show()
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try

            If griConceptosGenerales.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griConceptosGenerales)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método para salir o cerrar el formulario ConceptosGenerales
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Evento inicial que carga el formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frm_ConceptosGenerales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            MostrarTabs(0, ficConceptosGenerales)
            griConceptosGenerales.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
            griConceptosGenerales.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
            Tiempo1.Enabled = False
            InicializaTiempo()
            CargarCboFiltraProceso()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Evento que se ejecuta al cerrar el formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frm_ConceptosGenerales_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub


    ''' <summary>
    ''' Evento que se ejecuta al cerrar el formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frm_ConceptosGenerales_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case Operacion
            Case "Nuevo"
                Me.Activate()
                Me.Cancelar()
            Case "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    ''' <summary>
    ''' Evento que evita que la grilla muestre un mensaje de alerta al pulsar la tecla delete sobre ella
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub griConceptosGenerales_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griConceptosGenerales.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    ''' <summary>
    ''' Evento que ejecuta la edición al hacer doble click sobre la grilla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub griConceptosGenerales_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griConceptosGenerales.DoubleClick
        Try
            If griConceptosGenerales.Selected.Rows.Count > 0 Then Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griConceptosGenerales_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griConceptosGenerales.KeyDown
        TeclaPulsada(e)
    End Sub

    ''' <summary>
    ''' Evento que muestra el total de ConceptosGeneraless listados
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub griConceptosGenerales_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griConceptosGenerales.InitializeLayout
        agrListaConceptosGenerales.Text = "Total de Conceptos Generales: " & e.Layout.Rows.Count & Estado
    End Sub

    ''' <summary>
    ''' Seleccionar todo el contenido del control al momento de ingresar en él
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus, txtCodigo.Enter
        txtCodigo.SelectAll()
    End Sub

    Private Sub txtNombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.GotFocus, txtNombre.Enter
        txtNombre.SelectAll()
    End Sub

    Private Sub txtAbreviatura_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbreviatura.GotFocus, txtAbreviatura.Enter
        txtAbreviatura.SelectAll()
    End Sub

    Private Sub txtOrden_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOrden.GotFocus, txtOrden.Enter
        txtOrden.SelectAll()
    End Sub

    ''' <summary>
    ''' Asociar el control a la función tecla pulsada para que en caso sea pulsada una tecla especial la función correspondiente se ejecute inmediatamente
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown, txtNombre.KeyDown, txtAbreviatura.KeyDown, txtOrden.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub oeConceptosGenerales_DatoCambiado() Handles oeConceptosGenerales.DatoCambiado
        oeConceptosGenerales.Modificado = True
    End Sub

    ''' <summary>
    ''' Asignar el valor ingresado en el control al objeto
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtCodigo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        oeConceptosGenerales.Codigo = txtCodigo.Text.Trim
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        oeConceptosGenerales.Nombre = txtNombre.Text
    End Sub

    Private Sub txtAbreviatura_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbreviatura.ValueChanged
        oeConceptosGenerales.Abreviatura = txtAbreviatura.Text
    End Sub

    Private Sub txtOrden_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOrden.ValueChanged
        oeConceptosGenerales.Orden = txtOrden.Value
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeConceptosGenerales.Activo = verActivo.Checked
    End Sub

    Private Sub verConceptoProtegido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verConceptoProtegido.CheckedChanged
        oeConceptosGenerales.Protegido = verConceptoProtegido.Checked
    End Sub

    Private Sub verActivo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles verActivo.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub cboProceso_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProceso.ValueChanged
        Try
            If cboProceso.SelectedIndex > -1 Then
                oeConceptosGenerales.IdProcesoNegocio = cboProceso.Value.ToString.Trim
                ListarConceptosGeneralesRegistrados()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cboFiltraProceso_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFiltraProceso.ValueChanged
        Try
            If cboFiltraProceso.SelectedIndex > -1 Then oeConceptosGenerales.IdProcesoNegocio = cboFiltraProceso.Value.ToString.Trim
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

#End Region

#Region "Métodos"

    Private Sub ListarConceptosGeneralesRegistrados()
        Try
            agrListaConceptosVinculados.Text = "Lista de conceptos generales ya vinculados a : " & cboProceso.Text

            Dim oeConceptosGenerales2 As New e_ConceptosGenerales
            Dim olConceptosGenerales As New l_ConceptosGenerales
            oeConceptosGenerales2.Activo = True
            oeConceptosGenerales2.IdProcesoNegocio = cboProceso.Value

            FormateaGrilla(griConceptosGeneralesVinculados, oeConceptosGenerales2)

            'Calcula el próximo orden de la lista
            If Operacion = "Nuevo" Then txtOrden.Value = griConceptosGeneralesVinculados.Rows.Count + 1
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Inicializar el formulario
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Inicializar()
        txtCodigo.Text = String.Empty
        txtAbreviatura.Text = String.Empty
        txtNombre.Text = String.Empty
        verActivo.Checked = True
        txtOrden.Value = 1
        AsociarMenu()
        CargarCboProceso()

    End Sub

    Private Sub CargarCboProceso()
        Try

            Dim oeProceso As New e_ProcesoNegocio
            Dim olProceso As New l_ProcesoNegocio
            oeProceso.Indicador = 0
            cboProceso.Items.Clear()
            cboProceso.DataSource = olProceso.Listar(oeProceso)
            cboProceso.SelectedIndex = 0

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Private Sub CargarCboFiltraProceso()
        Try

            Dim oeProceso As New e_ProcesoNegocio
            Dim olProceso As New l_ProcesoNegocio

            cboFiltraProceso.Items.Clear()
            oeProceso.Indicador = 0

            cboFiltraProceso.DataSource = olProceso.Listar(oeProceso)
            cboFiltraProceso.SelectedIndex = 0

            If cboFiltraProceso.SelectedIndex > -1 Then oeConceptosGenerales.IdProcesoNegocio = cboFiltraProceso.Value.ToString.Trim

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' Método que permite guardar la infomación del ConceptosGenerales
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GuardarConceptosGenerales() As Boolean
        Try
            oeConceptosGenerales.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olConceptosGenerales.Guardar(oeConceptosGenerales) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, ficConceptosGenerales, 2)
                Consultar(True)
                griConceptosGenerales.Focus()
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Ubicar el foco en un control específico
    ''' </summary>
    ''' <param name="excepcion"></param>
    ''' <remarks></remarks>
    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("codigo") Then txtCodigo.Focus()
        If excepcion.Contains("nombre") Then txtNombre.Focus()
        If excepcion.Contains("abreviatura") Then txtAbreviatura.Focus()
    End Sub

    ''' <summary>
    ''' Obtener un ConceptosGenerales y cargar los datos en los controles del formulario
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub MostrarConceptosGenerales()
        Try
            If griConceptosGenerales.ActiveRow.Cells("ID").Value.ToString.Length > 0 Then
                Inicializar()
                verActivo.Visible = True
                oeConceptosGenerales.Id = griConceptosGenerales.ActiveRow.Cells("Id").Value.ToString
                oeConceptosGenerales = olConceptosGenerales.Obtener(oeConceptosGenerales)

                cboProceso.Value = oeConceptosGenerales.IdProcesoNegocio
                txtCodigo.Text = oeConceptosGenerales.Codigo
                txtNombre.Text = oeConceptosGenerales.Nombre
                txtAbreviatura.Text = oeConceptosGenerales.Abreviatura
                txtOrden.Value = oeConceptosGenerales.Orden
                verActivo.Checked = oeConceptosGenerales.Activo
                verConceptoProtegido.Checked = oeConceptosGenerales.Protegido

                oeConceptosGenerales.Modificado = False

                MostrarTabs(1, ficConceptosGenerales, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Generar una lista de ConceptosGeneraless y cargar la grilla principal del formulario
    ''' </summary>
    ''' <param name="Activo"></param>
    ''' <remarks></remarks>
    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Estado = IIf(Activo, " Activo", " Inactivo")
            Me.Cursor = Cursors.WaitCursor
            oeConceptosGenerales = New e_ConceptosGenerales

            oeConceptosGenerales.IdProcesoNegocio = cboFiltraProceso.Value
            oeConceptosGenerales.Activo = True

            FormateaGrilla(griConceptosGenerales, oeConceptosGenerales)

            'Cofigura la grilla para que se seleccione la fila completa al hacer click en algun lado
            griConceptosGenerales.DisplayLayout.Bands(0).Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            'Ubica el cursor el el primer registro de la grilla
            If griConceptosGenerales.Rows.Count > 0 Then
                griConceptosGenerales.Focus()
                griConceptosGenerales.Rows.Item(0).Selected = True
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub FormateaGrilla(ByVal grilla As Grilla, ByVal oeConceptosGenerales As e_ConceptosGenerales)
        Try

            'Obtiene la información de ConceptosGeneraless desde la BD
            grilla.DataSource = olConceptosGenerales.Listar(oeConceptosGenerales)
            'Ordena los datos en forma ascendente por el campo Nombre
            grilla.DisplayLayout.Bands(0).Columns("Orden").SortIndicator = SortOrder.Ascending
            'Ocultar columnas específicas
            grilla.DisplayLayout.Bands(0).Columns("Id").Hidden = True
            grilla.DisplayLayout.Bands(0).Columns("IdProcesoNegocio").Hidden = True
            grilla.DisplayLayout.Bands(0).Columns("Activo").Hidden = True
            grilla.DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
            'Especificar el ancho de las columnas que se muestran
            grilla.DisplayLayout.Bands(0).Columns("Codigo").Width = 100
            grilla.DisplayLayout.Bands(0).Columns("Nombre").Width = 500
            grilla.DisplayLayout.Bands(0).Columns("Abreviatura").Width = 200
            'Define el nombre que se mostrará en la cabecera de la lista
            grilla.DisplayLayout.Bands(0).Columns("Codigo").Header.Caption = "Código"
            grilla.DisplayLayout.Bands(0).Columns("Nombre").Header.Caption = "Descripción"
            grilla.DisplayLayout.Bands(0).Columns("Abreviatura").Header.Caption = "Siglas"

            'Muestra la columna Protegido en forma de casilla de verificación
            grilla.DisplayLayout.Bands(0).Columns("Protegido").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "Menú contextual"

    ''' <summary>
    ''' Método que permite asociar el menú contextual del formulario con la grilla principal
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AsociarMenu()
        griConceptosGenerales.ContextMenuStrip = MenuContextual1
    End Sub

    ''' <summary>
    ''' Evento que permite especificar que rutina se va a ejecutar al seleccionar la opción Nuevo del menú contextual
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub InsertarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertarToolStripMenuItem.Click
        Nuevo()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        Editar()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar()
    End Sub

    ''' <summary>
    ''' Configuración de las opciones que va a mostrar el menú contextual
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        MenuContextual1.Items(0).Visible = True
        If griConceptosGenerales.Selected.Rows.Count > 0 Then
            MenuContextual1.Items(1).Visible = True
            MenuContextual1.Items(2).Visible = True
        Else
            MenuContextual1.Items(1).Visible = False
            MenuContextual1.Items(2).Visible = False
        End If
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    ''' <summary>
    ''' Método que inicializa el control de tiempo al mover el mouse sobre el formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frm_ConceptosGenerales_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub
    ''' <summary>
    ''' Método que actualiza automáticamente la grilla al mover el mouse sobre ella después de un tiempo de inactividad (por defecto 10 segundos)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub griConceptosGenerales_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

End Class
