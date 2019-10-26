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

Public Class frm_MotivoMonDes
    Inherits frm_MenuPadre

#Region "Inicializar el formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_MotivoMonDes = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_MotivoMonDes()
        End If
        Instancia.Activate()
        Return Instancia
    End Function
#End Region

#Region "Declaración de variables"

    Private WithEvents oeMotivo As New e_Motivo
    Dim olMotivo As New l_Motivo

    'Variable para controlar el estado de los registros mostrados (Activo - Inactivo)
    Dim Estado As String
    'Variable para controlar el estado de la botonera principal del sistema
    Dim _ingresando_datos As Boolean = False

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If grid_Motivo.Rows.Count > 0 Then
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
            oeMotivo = New e_Motivo
            oeMotivo.TipoOperacion = "I"
            oeMotivo.UsuarioCreacion = gUsuarioSGI.Id
            MostrarTabs(1, tcMotivo, 1)
            Inicializar()
            txtNombre.Focus()
            Operacion = "Nuevo"
            MyBase.Nuevo()
            oeMotivo.Modificado = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            oeMotivo = New e_Motivo
            MostrarMotivoMontajeDesmontaje()
            oeMotivo.TipoOperacion = "A"
            txtNombre.Focus()
            Operacion = "Editar"
            MyBase.Editar()
            oeMotivo.Modificado = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarMotivoMonDes() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcMotivo, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeMotivo.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarMotivoMonDes() Then
                            MostrarTabs(0, tcMotivo, 2)
                            _ingresando_datos = False
                            MyBase.Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, tcMotivo, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcMotivo, 2)
                        _ingresando_datos = False
                        MyBase.Consultar(True)
                End Select
            Else
                MostrarTabs(0, tcMotivo, 2)
                _ingresando_datos = False
                MyBase.Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With grid_Motivo
                If ValidarGrilla(grid_Motivo, "Motivo Montaje y Desmontaje") Then
                    oeMotivo.Id = .ActiveRow.Cells("Id").Value
                    oeMotivo = olMotivo.Obtener(oeMotivo)
                    If oeMotivo.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar el Motivo: " & _
                        .ActiveRow.Cells("Nombre").Value.ToString.Trim & "?", _
                        "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeMotivo.TipoOperacion = "E"
                            olMotivo.Eliminar(oeMotivo)
                            Consultar(True)
                        End If
                    Else
                        Throw New Exception("La informacion se encuentra eliminada en " & Me.Text)
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

            If grid_Motivo.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(grid_Motivo)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

    Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeMotivo = New e_Motivo
            With grid_Motivo
                oeMotivo.Activo = Activo
                .DataSource = olMotivo.Listar(oeMotivo)
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
            grid_Motivo.Focus()
        End Try
    End Sub

    Function GuardarMotivoMonDes() As Boolean
        Try
            oeMotivo.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olMotivo.Guardar(oeMotivo) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, tcMotivo, 2)
                Consultar(True)
                grid_Motivo.Focus()
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Sub MostrarMotivoMontajeDesmontaje()
        Try
            If grid_Motivo.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeMotivo.Id = grid_Motivo.ActiveRow.Cells("Id").Value.ToString
                oeMotivo = olMotivo.Obtener(oeMotivo)
                txtCodigo.Text = oeMotivo.Codigo
                txtNombre.Text = oeMotivo.Nombre
                chkAlmacen.Checked = oeMotivo.IndAlmacen
                chkReencauche.Checked = oeMotivo.IndReencauche
                chkReparacion.Checked = oeMotivo.IndReparacion
                chkBaja.Checked = oeMotivo.IndBaja
                verActivo.Checked = oeMotivo.Activo
                MostrarTabs(1, tcMotivo, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Sub Inicializar()
        Me.txtNombre.Text = String.Empty
        Me.txtCodigo.Text = String.Empty
        chkAlmacen.Checked = False
        chkReencauche.Checked = False
        chkReparacion.Checked = False
        chkBaja.Checked = False
        verActivo.Checked = False
    End Sub

    Private Sub oeMotivo_DatoCambiado() Handles oeMotivo.DatoCambiado
        oeMotivo.Modificado = True
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        txtNombre.Text = LTrim(txtNombre.Text)
        oeMotivo.Nombre = txtNombre.Text
    End Sub

    Private Sub chkAlmacen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAlmacen.CheckedChanged
        oeMotivo.IndAlmacen = chkAlmacen.Checked
    End Sub

    Private Sub chkReencauche_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkReencauche.CheckedChanged
        oeMotivo.IndReencauche = chkReencauche.Checked
    End Sub

    Private Sub chkReparacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkReparacion.CheckedChanged
        oeMotivo.IndReparacion = chkReparacion.Checked
    End Sub

    Private Sub chkBaja_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBaja.CheckedChanged
        oeMotivo.IndBaja = chkBaja.Checked
    End Sub

    Private Sub frm_MotivoMonDes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gmt_ConfigurarEventoKeyEnter_Tab(Me)
        gf_AsignarEventoSeleccionarTexto(Me)
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        MostrarTabs(0, tcMotivo)
        grid_Motivo.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        grid_Motivo.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        Tiempo1.Enabled = False
        InicializaTiempo()
    End Sub

    Private Sub frm_MotivoMonDes_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_MotivoMonDes_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            Me.Activate()
            Me.Cancelar()
        End If
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub grid_Motivo_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles grid_Motivo.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub grid_Motivo_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grid_Motivo.DoubleClickRow
        If grid_Motivo.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub frm_MotivoMonDes_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub grid_Motivo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid_Motivo.KeyDown
        TeclaPulsada(e)
    End Sub

End Class
