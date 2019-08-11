Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports ISL.Controles
Imports System.ServiceModel

Public Class frm_Banco
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializar el formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_Banco = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_Banco()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Declaración de variables"

    'Variables para inicializar el objeto Banco
    Dim olbanco As New l_Banco

    'Declaración de instancia para el control de modificaciones de la entidad en el formulario
    Private WithEvents oebanco As New e_Banco

    'Declaración de clase que administra información de listado de bancos
    Dim bancos As New e_Bancos

    'Variable para controlar el estado de los registros mostrados (Activo - Inactivo)
    Dim Estado As String

    'Variable para controlar el estado de la botonera principal del sistema
    Dim _ingresando_datos As Boolean = False

#End Region

#Region "Botones"

    ''' <summary>
    ''' Método para consultar y listar bancos
    ''' </summary>
    ''' <param name="Activo"></param>
    ''' <remarks></remarks>
    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griListaBanco.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As TimeoutException
            mensajeEmergente.Problema(ex.Message)
            'olbanco.Abort()
        Catch ex As CommunicationException
            mensajeEmergente.Problema(ex.Message)
            'olbanco.Abort()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            'olbanco.Abort()
        End Try
    End Sub

    ''' <summary>
    ''' Método para crear un nuevo banco
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Nuevo()
        Try
            verActivo.Visible = False
            oebanco.TipoOperacion = "I"
            MostrarTabs(1, tcbanco, 1)
            Inicializar()
            txtCodigo.Focus()
            Operacion = "Nuevo"
            MyBase.Nuevo()
            oebanco.Modificado = False
        Catch ex As TimeoutException
            mensajeEmergente.Problema(ex.Message)
            'olbanco.Abort()
        Catch ex As CommunicationException
            mensajeEmergente.Problema(ex.Message)
            'olbanco.Abort()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            'olbanco.Abort()
        End Try
    End Sub

    ''' <summary>
    ''' Método para editar un banco específico
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Editar()
        Try
            verActivo.Visible = True
            MostrarBanco()
            oebanco.TipoOperacion = "A"
            txtCodigo.Focus()
            Operacion = "Editar"
            MyBase.Editar()
            oebanco.Modificado = False
        Catch ex As TimeoutException
            mensajeEmergente.Problema(ex.Message)
            'olbanco.Abort()
        Catch ex As CommunicationException
            mensajeEmergente.Problema(ex.Message)
            'olbanco.Abort()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            'olbanco.Abort()
        End Try
    End Sub

    ''' <summary>
    ''' Método para Guardar la información del banco
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Guardar()
        Try
            If GuardarBanco() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcbanco, 1)
            End If
        Catch ex As TimeoutException
            mensajeEmergente.Problema(ex.Message)
            'olbanco.Abort()
        Catch ex As CommunicationException
            mensajeEmergente.Problema(ex.Message)
            'olbanco.Abort()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            'olbanco.Abort()
        End Try
    End Sub

    ''' <summary>
    ''' Método para cancelar la edición de la información de un banco
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Cancelar()
        Try
            If oebanco.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarBanco() Then
                            MostrarTabs(0, tcbanco, 2)
                            _ingresando_datos = False
                            MyBase.Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, tcbanco, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcbanco, 2)
                        _ingresando_datos = False
                        MyBase.Consultar(True)
                    Case Windows.Forms.DialogResult.Cancel
                        _ingresando_datos = True
                End Select
            Else
                MostrarTabs(0, tcbanco, 2)
                _ingresando_datos = False
                MyBase.Consultar(True)
            End If
        Catch ex As TimeoutException
            mensajeEmergente.Problema(ex.Message)
            'olbanco.Abort()
        Catch ex As CommunicationException
            mensajeEmergente.Problema(ex.Message)
            'olbanco.Abort()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            'olbanco.Abort()
        End Try
    End Sub

    ''' <summary>
    ''' Método para eliminar un banco
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Eliminar()
        Try
            With griListaBanco
                If ValidarGrilla(griListaBanco, "Banco") Then
                    oebanco.Id = .ActiveRow.Cells("ID").Value
                    oebanco = olbanco.Obtener(oebanco)
                    If oebanco.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar el Banco: " & _
                                 .ActiveRow.Cells("Nombre").Value.ToString.Trim & "?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oebanco.TipoOperacion = "E"
                            olbanco.Eliminar(oebanco)
                            Consultar(True)
                        End If
                    Else
                        Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                    End If
                End If
            End With
        Catch ex As TimeoutException
            mensajeEmergente.Problema(ex.Message)
            'olbanco.Abort()
        Catch ex As CommunicationException
            mensajeEmergente.Problema(ex.Message)
            'olbanco.Abort()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            'olbanco.Abort()
        End Try
    End Sub

    ''' <summary>
    ''' Método para imprimir un listado de banco
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Imprimir()
        Try
            MyBase.Imprimir()
            Dim frm As frm_ReporteBasico = frm_ReporteBanco
            frm.MdiParent = frm_Menu
            frm.Show()
        Catch ex As TimeoutException
            mensajeEmergente.Problema(ex.Message)
            'olbanco.Abort()
        Catch ex As CommunicationException
            mensajeEmergente.Problema(ex.Message)
            'olbanco.Abort()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            'olbanco.Abort()
        End Try
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            If griListaBanco.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griListaBanco)

            MyBase.Exportar()
        Catch ex As TimeoutException
            mensajeEmergente.Problema(ex.Message)
            'olbanco.Abort()
        Catch ex As CommunicationException
            mensajeEmergente.Problema(ex.Message)
            'olbanco.Abort()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            'olbanco.Abort()
        End Try
    End Sub

    ''' <summary>
    ''' Método para salir o cerrar el formulario Banco
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
    Private Sub frm_Banco_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        MostrarTabs(0, tcbanco)
        griListaBanco.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        griListaBanco.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        Tiempo1.Enabled = False
        InicializaTiempo()

    End Sub

    Private Sub frm_Banco_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

    End Sub

    Private Sub oeBanco_DatoCambiado() Handles oebanco.DatoCambiado
        oebanco.Modificado = True
    End Sub

    ''' <summary>
    ''' Evento que se ejecuta al cerrar el formulario 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frm_Banco_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    ''' <summary>
    ''' Evento que se ejecuta al cerrar el formulario 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frm_Banco_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If _Operacion = "Nuevo" Or _Operacion = "Editar" Then
            Me.Activate()
            Me.Cancelar()
        End If
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    ''' <summary>
    ''' Evento que evita que la grilla muestre un mensaje de alerta al pulsar la tecla delete sobre ella
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub griListaBanco_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaBanco.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    ''' <summary>
    ''' Evento que ejecuta la edición al hacer doble click sobre la grilla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub griListaBanco_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaBanco.DoubleClick
        If griListaBanco.Selected.Rows.Count > 0 Then Editar()
    End Sub

    ''' <summary>
    ''' Controla las teclas pulsadas en la grilla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub griListaBanco_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griListaBanco.KeyDown
        TeclaPulsada(e)
    End Sub

    ''' <summary>
    ''' Evento que muestra el total de bancos listados
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub griListaBanco_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griListaBanco.InitializeLayout
        agrTotalBancos.Text = "Total de Bancos: " & bancos.Cuantos & Estado
    End Sub

    ''' <summary>
    ''' Seleccionar todo el contenido del control al momento de ingresar en él
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        txtCodigo.SelectAll()
    End Sub

    ''' <summary>
    ''' Asociar el control a la función tecla pulsada para que en caso sea pulsada una tecla especial la función correspondiente se ejecute inmediatamente
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown, txtNombre.KeyDown, txtAbreviatura.KeyDown
        TeclaPulsada(e)
    End Sub

    ''' <summary>
    ''' Asignar el valor ingresado en el control al objeto
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtCodigo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        txtCodigo.Text = txtCodigo.Text.Trim
        oebanco.Codigo = txtCodigo.Text
    End Sub

    Private Sub txtNombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.GotFocus
        txtNombre.SelectAll()
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        txtNombre.Text = txtNombre.Text.Trim
        oebanco.Nombre = txtNombre.Text
    End Sub

    Private Sub txtAbreviatura_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbreviatura.GotFocus
        txtAbreviatura.SelectAll()
    End Sub
    Private Sub txtAbreviatura_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAbreviatura.ValueChanged
        txtAbreviatura.Text = txtAbreviatura.Text.Trim
        oebanco.Abreviatura = txtAbreviatura.Text
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oebanco.Activo = verActivo.Checked
    End Sub

    Private Sub verActivo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles verActivo.KeyDown
        TeclaPulsada(e)
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Inicializar el formulario
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Inicializar()
        txtCodigo.Text = String.Empty
        txtAbreviatura.Text = String.Empty
        txtNombre.Text = String.Empty
        verActivo.Checked = True
        AsociarMenu()
    End Sub

    ''' <summary>
    ''' Método que permite guardar la infomación del banco
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GuardarBanco() As Boolean
        Try
            If olbanco.Guardar(oebanco) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, tcbanco, 2)
                Consultar(True)
                griListaBanco.Focus()
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
    ''' Obtener un banco y cargar los datos en los controles del formulario
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub MostrarBanco()
        Try
            If griListaBanco.ActiveRow.Cells("ID").Value.ToString.Length > 0 Then
                Inicializar()
                verActivo.Visible = True
                oebanco.Id = griListaBanco.ActiveRow.Cells("Id").Value.ToString
                oebanco = olbanco.Obtener(oebanco)
                txtCodigo.Text = oebanco.Codigo
                txtNombre.Text = oebanco.Nombre
                txtAbreviatura.Text = oebanco.Abreviatura
                verActivo.Checked = oebanco.Activo
                MostrarTabs(1, tcbanco, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Generar una lista de bancos y cargar la grilla principal del formulario
    ''' </summary>
    ''' <param name="Activo"></param>
    ''' <remarks></remarks>
    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Estado = IIf(Activo, " Activo", " Inactivo")
            Me.Cursor = Cursors.WaitCursor
            oebanco = New e_Banco
            With griListaBanco
                oebanco.Activo = Activo

                'Obtiene la información de bancos desde la BD
                .DataSource = bancos.Obtener(olbanco.Listar(oebanco))

                'Ordena los datos en forma ascendente por el campo Nombre
                .DisplayLayout.Bands(0).Columns("Nombre").SortIndicator = SortOrder.Ascending

                'Ocultar columnas específicas
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True

                'Especificar el ancho de las columnas que se muestran
                .DisplayLayout.Bands(0).Columns("Codigo").Width = 100
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 500
                .DisplayLayout.Bands(0).Columns("Abreviatura").Width = 200

                'Define el nombre que se mostrará en la cabecera de la lista
                .DisplayLayout.Bands(0).Columns("Codigo").Header.Caption = "Código"
                .DisplayLayout.Bands(0).Columns("Nombre").Header.Caption = "Banco"
                .DisplayLayout.Bands(0).Columns("Abreviatura").Header.Caption = "Siglas"

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
    End Sub

#End Region

#Region "Menú contextual"

    ''' <summary>
    ''' Método que permite asociar el menú contextual del formulario con la grilla principal
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AsociarMenu()
        griListaBanco.ContextMenuStrip = MenuContextual1
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

    ''' <summary>
    ''' Evento que permite especificar que rutina se va a ejecutar al seleccionar la opción Actualizar del menú contextual
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        Editar()
    End Sub

    ''' <summary>
    ''' Evento que permite especificar que rutina se va a ejecutar al seleccionar la opción Eliminar del menú contextual
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
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
        MenuContextual1.Items("InsertarToolStripMenuItem").Visible = True
        If griListaBanco.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("EditarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("EditarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
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
    Private Sub frm_Banco_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    ''' <summary>
    ''' Método que actualiza automáticamente la grilla al mover el mouse sobre ella después de un tiempo de inactividad (por defecto 10 segundos)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    ''' 
    Private Sub griListaBanco_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griListaBanco.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

    
End Class