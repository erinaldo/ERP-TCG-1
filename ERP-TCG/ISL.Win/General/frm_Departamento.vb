'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.ServiceModel


Public Class frm_Departamento
    Inherits ISL.Win.frm_MenuPadre

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_Departamento = Nothing
    Private Shared Operacion As String
    'Public errorEnviadoEmail As Boolean = False

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Departamento
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Declaración de Variables"

    Private WithEvents oeDepartamento As New e_Departamento
    Dim osDepartamento As New SGI_WCF.MensajeError
    Dim _ingresando_datos As Boolean = False

#End Region

#Region "Eventos"

    Private Sub frm_Departamento_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        MostrarTabs(0, ficDepartamento)
        griDepartamento.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        griDepartamento.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        Tiempo1.Enabled = False
        InicializaTiempo()
        errorEnviadoEmail = False
    End Sub

    ''' <summary>
    ''' Cuenta el total de registros y los muestra
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub griDepartamento_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griDepartamento.InitializeLayout
        agrDepartamentos.Text = "Total de Departamentos: " & osDepartamento.DepartamentoTotalRegistros
    End Sub

    Private Sub frm_Departamento_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Departamento_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub oeDepartamento_DatoCambiado() Handles oeDepartamento.DatoCambiado
        oeDepartamento.Modificado = True
    End Sub

    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        txtCodigo.SelectAll()
    End Sub

    Private Sub txtNombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.GotFocus
        txtNombre.SelectAll()
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub verActivo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles verActivo.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        txtCodigo.Text = LTrim(txtCodigo.Text)
        oeDepartamento.Codigo = txtCodigo.Text.Trim
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        txtNombre.Text = LTrim(txtNombre.Text)
        oeDepartamento.Nombre = txtNombre.Text.Trim
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeDepartamento.Activo = verActivo.Checked
    End Sub

    Private Sub griDepartamento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griDepartamento.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub griDepartamento_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs)
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griDepartamento_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griDepartamento.DoubleClick
        If griDepartamento.Selected.Rows.Count > 0 Then Editar()
    End Sub

#End Region

#Region "Botones"

    ''' <summary>
    ''' Consultar la información de los departamentos activos
    ''' </summary>
    ''' <param name="Activo"></param>
    ''' <remarks></remarks>
    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griDepartamento.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Crear un nuevo departamento
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Nuevo()
        oeDepartamento.TipoOperacion = "I"
        MostrarTabs(1, ficDepartamento, 1)
        Inicializar()
        txtCodigo.Focus()
        Operacion = "Nuevo"
        MyBase.Nuevo()
        oeDepartamento.Modificado = False
    End Sub

    ''' <summary>
    ''' Editar o modificar la información del departamento
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Editar()
        Try
            Mostrar()
            oeDepartamento.TipoOperacion = "A"
            txtCodigo.Focus()
            Operacion = "Editar"
            MyBase.Editar()
            oeDepartamento.Modificado = False
        Catch ex As FaultException(Of SGI_WCF.MensajeError)
            mensajeEmergente.ProblemaEnvioEmail(ex, True, Me.Name)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Guardar la información ingresada al departamento
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Guardar()
        Try
            If GuardarRegistro() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficDepartamento, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Cancelar el ingreso de información sobre departamentos
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Cancelar()
        Try
            If oeDepartamento.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarRegistro() Then
                            MostrarTabs(0, ficDepartamento, 2)
                            _ingresando_datos = False
                            MyBase.Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficDepartamento, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficDepartamento, 2)
                        _ingresando_datos = False
                        MyBase.Consultar(True)
                End Select
            Else
                MostrarTabs(0, ficDepartamento, 2)
                _ingresando_datos = False
                MyBase.Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' Eliminar un departamento
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Eliminar()
        Try

            If ValidarGrilla(griDepartamento, "Departamento") Then
                'oeDepartamento = osDepartamento.DepartamentoObtener(griDepartamento.ActiveRow.Cells("ID").Value)
                If oeDepartamento.Activo Then
                    If MessageBox.Show("Desea eliminar el Departamento: " & _
                            oeDepartamento.Nombre & " ?", _
                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        oeDepartamento.TipoOperacion = "E"
                        'osDepartamento.DepartamentoEliminar(oeDepartamento)
                        Consultar(True)
                    End If
                Else
                    Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                End If
            End If

        Catch ex As FaultException(Of SGI_WCF.MensajeError)
            mensajeEmergente.ProblemaEnvioEmail(ex, True, Me.Name)
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

            If griDepartamento.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griDepartamento)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Metodos"

    Private Sub Inicializar()
        txtId.Text = String.Empty
        txtCodigo.Text = String.Empty
        txtNombre.Text = String.Empty
        verActivo.Checked = True
        AsociarMenu()
    End Sub


    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("codigo") Then
            txtCodigo.Focus()
        End If
        If excepcion.Contains("nombre") Then
            txtNombre.Focus()
        End If
    End Sub

    ''' <summary>
    ''' Mostrar la información del departamento seleccionado de la grilla
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Mostrar()
        Try
            If griDepartamento.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                'oeDepartamento = osDepartamento.DepartamentoObtener(griDepartamento.ActiveRow.Cells("Id").Value.ToString)
                txtId.Text = oeDepartamento.Id
                txtCodigo.Text = oeDepartamento.Codigo
                txtNombre.Text = oeDepartamento.Nombre
                verActivo.Checked = oeDepartamento.Activo
                MostrarTabs(1, ficDepartamento, 1)
                MyBase.Editar()
            End If
        Catch ex As FaultException(Of SGI_WCF.MensajeError)
            mensajeEmergente.ProblemaEnvioEmail(ex, True, Me.Name)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Guardar el registro del departamento 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GuardarRegistro() As Boolean
        Try
            'If osDepartamento.DepartamentoGuardar(oeDepartamento) Then
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
            MostrarTabs(0, ficDepartamento, 2)
            Consultar(True)
            griDepartamento.Focus()
            Return True
            'End If
        Catch ex As FaultException(Of SGI_WCF.MensajeError)
            mensajeEmergente.ProblemaEnvioEmail(ex, True, Me.Name)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Generar un listado de departamentos activos
    ''' </summary>
    ''' <param name="Activo"></param>
    ''' <remarks></remarks>
    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            With griDepartamento
                oeDepartamento = New e_Departamento
                oeDepartamento.Activo = Activo
                '.DataSource = osDepartamento.DepartamentoListar(oeDepartamento)

                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As FaultException(Of SGI_WCF.MensajeError)
            mensajeEmergente.ProblemaEnvioEmail(ex, True, Me.Name)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_Departamento_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griDepartamento_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griDepartamento.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro de Departamentos"

    Private Sub AsociarMenu()
        griDepartamento.ContextMenuStrip = MenuContextual1
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
        If griDepartamento.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

End Class
