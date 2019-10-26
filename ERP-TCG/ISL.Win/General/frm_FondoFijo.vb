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
Public Class frm_FondoFijo
    Inherits frm_MenuPadre

#Region "Inicializar el formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_FondoFijo = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_FondoFijo()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Declaración de variables"

    'Declaración de instancia para el control de modificaciones de la entidad en el formulario
    Private WithEvents oeFondoFijo As New e_FondoFijo

    Dim olFondoFijo As New l_FondoFijo

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
            If griFondoFijo.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
            MostrarTabs(0, ficFondoFijo, 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método para crear un nuevo banco
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Nuevo()
        verActivo.Visible = False
        oeFondoFijo.TipoOperacion = "I"
        MostrarTabs(1, ficFondoFijo, 1)
        Inicializar()
        numFondo.Focus()
        Operacion = "Nuevo"
        MyBase.Nuevo()
        oeFondoFijo.Modificado = False
    End Sub

    ''' <summary>
    ''' Método para editar un banco específico
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Editar()
        Try
            verActivo.Visible = True
            MostrarFondo()
            oeFondoFijo.TipoOperacion = "A"
            numFondo.Focus()
            Operacion = "Editar"
            MyBase.Editar()
            oeFondoFijo.Modificado = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método para Guardar la información del banco
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Guardar()
        Try
            If GuardarFondo() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficFondoFijo, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método para cancelar la edición de la información de un banco
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Cancelar()
        Try
            If oeFondoFijo.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarFondo() Then
                            MostrarTabs(0, ficFondoFijo, 2)
                            _ingresando_datos = False
                            MyBase.Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficFondoFijo, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficFondoFijo, 2)
                        _ingresando_datos = False
                        MyBase.Consultar(True)
                End Select
            Else
                MostrarTabs(0, ficFondoFijo, 2)
                _ingresando_datos = False
                MyBase.Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método para eliminar un banco
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Eliminar()
        Try
            With griFondoFijo
                If ValidarGrilla(griFondoFijo, "FondoFijo") Then
                    oeFondoFijo.Id = .ActiveRow.Cells("ID").Value
                    oeFondoFijo = olFondoFijo.Obtener(oeFondoFijo)
                    If oeFondoFijo.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar el fondo fijo: " & _
                                 .ActiveRow.Cells("FondoFijo").Value.ToString.Trim & "?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeFondoFijo.TipoOperacion = "E"
                            olFondoFijo.Eliminar(oeFondoFijo)
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

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try

            If griFondoFijo.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griFondoFijo)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
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

    Private Function GuardarFondo() As Boolean
        Try
            oeFondoFijo.Glosa = txtGlosa.Text
            oeFondoFijo.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olFondoFijo.Guardar(oeFondoFijo) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, ficFondoFijo, 2)
                Consultar(True)
                griFondoFijo.Focus()
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Sub Inicializar()
        numFondo.Value = 0
        fecFecha.Value = Date.Now
        verActivo.Checked = True
        txtGlosa.Text = String.Empty
        oeFondoFijo.UsuarioCreacion = gUsuarioSGI.Id
        AsociarMenu()
    End Sub

    Private Sub MostrarFondo()
        Try
            If griFondoFijo.ActiveRow.Cells("ID").Value.ToString.Length > 0 Then
                Inicializar()
                verActivo.Visible = True
                oeFondoFijo.Id = griFondoFijo.ActiveRow.Cells("Id").Value.ToString
                oeFondoFijo = olFondoFijo.Obtener(oeFondoFijo)
                numFondo.Value = oeFondoFijo.FondoFijo
                fecFecha.Value = oeFondoFijo.Fecha
                verActivo.Checked = oeFondoFijo.Activo
                txtGlosa.Text = oeFondoFijo.Glosa
                MostrarTabs(1, ficFondoFijo, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub oeFondoFijo_DatoCambiado() Handles oeFondoFijo.DatoCambiado
        oeFondoFijo.Modificado = True
    End Sub

    Private Sub numFondo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numFondo.ValueChanged
        oeFondoFijo.FondoFijo = numFondo.Value
    End Sub

    Private Sub fecFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecFecha.ValueChanged, fecFecha.KeyDown, _
                                                                                                fecFecha.GotFocus
        oeFondoFijo.Fecha = fecFecha.Value
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeFondoFijo.Activo = 1
    End Sub

    Private Sub verActivo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles verActivo.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub griFondoFijo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griFondoFijo.DoubleClick
        If griFondoFijo.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griFondoFijo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griFondoFijo.KeyDown
        TeclaPulsada(e)
    End Sub


    Private Sub griFondoFijo_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griFondoFijo.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    ''' <summary>
    ''' Generar una lista de bancos y cargar la grilla principal del formulario
    ''' </summary>
    ''' <param name="Activo"></param>
    ''' <remarks></remarks>
    Public Sub Listar(ByVal Activo As Boolean)
        Try
            oeFondoFijo.Activo = IIf(Activo, 1, 0)
            Me.Cursor = Cursors.WaitCursor
            oeFondoFijo = New e_FondoFijo
            With griFondoFijo
                'oeFondoFijo.Activo = Activo

                'Obtiene la información de bancos desde la BD
                .DataSource = olFondoFijo.Listar(oeFondoFijo)

                'Ordena los datos en forma ascendente por el campo Fecha
                .DisplayLayout.Bands(0).Columns("Fecha").SortIndicator = SortOrder.Descending

                'Ocultar columnas específicas
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True

                'Especificar el ancho de las columnas que se muestran
                .DisplayLayout.Bands(0).Columns("FondoFijo").Width = 100
                .DisplayLayout.Bands(0).Columns("Fecha").Width = 200

                .DisplayLayout.Bands(0).Columns("FondoFijo").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("Fecha").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
                ' .DisplayLayout.Bands(0).Columns("Abreviatura").Width = 200

                'Define el nombre que se mostrará en la cabecera de la lista
                '.DisplayLayout.Bands(0).Columns("Codigo").Header.Caption = "Código"
                '.DisplayLayout.Bands(0).Columns("Nombre").Header.Caption = "Banco"
                '.DisplayLayout.Bands(0).Columns("Abreviatura").Header.Caption = "Siglas"

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

#Region "Menú contextual"

    ''' <summary>
    ''' Método que permite asociar el menú contextual del formulario con la grilla principal
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AsociarMenu()
        griFondoFijo.ContextMenuStrip = MenuContextual1
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
        If griFondoFijo.Selected.Rows.Count > 0 Then
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
    Private Sub frm_FondoFijo_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    ''' <summary>
    ''' Método que actualiza automáticamente la grilla al mover el mouse sobre ella después de un tiempo de inactividad (por defecto 10 segundos)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub griFondoFijo_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griFondoFijo.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region


    Private Sub fecFecha_ValueChanged(sender As Object, e As KeyEventArgs)

    End Sub

    Private Sub frm_FondoFijo_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Try
            MostrarTabs(0, ficFondoFijo)
            ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_FondoFijo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub
End Class