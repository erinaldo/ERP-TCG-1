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

Public Class frm_SeguroContraRiesgo
    Inherits frm_MenuPadre

#Region "Inicializacion"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_SeguroContraRiesgo = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        Operacion = "Inicializa"
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_SeguroContraRiesgo()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Declaración de variables"

    Private WithEvents oeSeguro As New e_SeguroContraRiesgo
    Private olSeguro As New l_SeguroContraRiesgo
    Private loSeguro As New List(Of e_SeguroContraRiesgo)

    Dim _ingresando_datos As Boolean = False

#End Region

#Region "Botones"

    Public Overrides Sub Nuevo()
        Try
            MostrarTabs(1, ficSegurosRiesgo, 1)
            oeSeguro.Modificado = False
            Inicializar()
            Operacion = "Nuevo"
            cboEmpresa.Focus()
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Tiempo1.Enabled = True
            Listar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Operacion = "Editar"
            Inicializar()
            Mostrar()
            MostrarTabs(1, ficSegurosRiesgo, 1)
            cboEmpresa.Focus()
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarPago() Then
                MostrarTabs(0, ficSegurosRiesgo)
                Listar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeSeguro.Modificado Then
                Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarPago() Then
                            MostrarTabs(0, ficSegurosRiesgo, 2)
                            _ingresando_datos = False
                            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficSegurosRiesgo, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficSegurosRiesgo, 2)
                        _ingresando_datos = False
                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End Select
            Else
                MostrarTabs(0, ficSegurosRiesgo)
                _ingresando_datos = False
            End If
            Listar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If griSegurosRiesgo.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griSegurosRiesgo)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            Select Case MessageBox.Show("Desea Eliminar la Informacion?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Case Windows.Forms.DialogResult.Yes
                    EliminarPago()
                    Listar()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_SeguroContraRiesgo_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Select Case ficSegurosRiesgo.SelectedTab.Index
            Case 0
                If griSegurosRiesgo.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 1)
        End Select
    End Sub

    Private Sub frm_SeguroContraRiesgo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_SeguroContraRiesgo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_SeguroContraRiesgo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fecDesde.Value = Date.Now.AddDays(-15)
        CargarEmpresa()
    End Sub

    Private Sub griSegurosRiesgo_DoubleClick(sender As Object, e As EventArgs) Handles griSegurosRiesgo.DoubleClick
        Editar()
    End Sub

    Private Sub mnuContextual_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mnuContextual.Opening
        Try
            mnuContextual.Items("ToolStripMenuNuevo").Visible = True
            mnuContextual.Items("ToolStripMenuEditar").Visible = False
            mnuContextual.Items("ToolStripMenuEliminar").Visible = False
            If griSegurosRiesgo.Rows.Count > 0 Then
                mnuContextual.Items("ToolStripMenuEditar").Visible = True
                mnuContextual.Items("ToolStripMenuEliminar").Visible = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripMenuNuevo_Click(sender As Object, e As EventArgs) Handles ToolStripMenuNuevo.Click
        Nuevo()
    End Sub

    Private Sub ToolStripMenuEditar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuEditar.Click
        Editar()
    End Sub

    Private Sub ToolStripMenuEliminar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuEliminar.Click
        Eliminar()
    End Sub

    Private Sub cboEmpresa_ValueChanged(sender As Object, e As EventArgs) Handles cboEmpresa.ValueChanged
        oeSeguro.Modificado = True
    End Sub

    Private Sub txtDescripcion_ValueChanged(sender As Object, e As EventArgs) Handles txtDescripcion.ValueChanged
        oeSeguro.Modificado = True
    End Sub

    Private Sub fecPago_ValueChanged(sender As Object, e As EventArgs) Handles fecPago.ValueChanged
        oeSeguro.Modificado = True
    End Sub

    Private Sub txtImporte_ValueChanged(sender As Object, e As EventArgs) Handles txtImporte.ValueChanged
        oeSeguro.Modificado = True
    End Sub

    Private Sub griSegurosRiesgo_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griSegurosRiesgo.BeforeRowsDeleted
        e.Cancel = True
    End Sub

#End Region

#Region "Metodos"

    Public Function GuardarPago() As Boolean
        Try
            LlenarObjeto()
            oeSeguro.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olSeguro.Guardar(oeSeguro) Then
                mensajeEmergente.Confirmacion("La Informacion ha sido Guardada Correctamente")
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Listar()
        Try
            oeSeguro = New e_SeguroContraRiesgo
            oeSeguro.Fecha = fecDesde.Value
            oeSeguro.FechaCreacion = fecHasta.Value
            oeSeguro.IdEmpresa = cboFiltroProveedor.Value
            griSegurosRiesgo.DataSource = olSeguro.Listar(oeSeguro)
            If griSegurosRiesgo.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Inicializar()
        oeSeguro = New e_SeguroContraRiesgo
        cboEmpresa.SelectedIndex = -1
        Me.txtDescripcion.Text = String.Empty
        Me.fecPago.Value = ObtenerFechaServidor()
        Me.txtImporte.Value = 0.0
    End Sub

    Public Sub Mostrar()
        Try
            oeSeguro.Id = griSegurosRiesgo.ActiveRow.Cells("Id").Value
            oeSeguro = olSeguro.Obtener(oeSeguro)
            cboEmpresa.Value = oeSeguro.IdEmpresa
            txtDescripcion.Text = oeSeguro.Descripcion
            txtImporte.Value = oeSeguro.Importe
            fecPago.Value = oeSeguro.Fecha
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub CargarEmpresa()
        Try
            Dim oeEmpresa As New e_Empresa
            Dim olEmpresa As New l_Empresa
            Dim loEmpresa As New List(Of e_Empresa)
            Dim loEmpresa2 As New List(Of e_Empresa)
            oeEmpresa.IdTipoEmpresa = "1CH000000004"
            loEmpresa = olEmpresa.Listar(oeEmpresa)
            LlenarCombo(cboEmpresa, "Nombre", loEmpresa, -1)
            Dim oe As New e_Empresa
            oe.Id = ""
            oe.Nombre = "TODOS"
            loEmpresa2.Add(oe)
            loEmpresa2.AddRange(loEmpresa)
            LlenarCombo(cboFiltroProveedor, "Nombre", loEmpresa2, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LlenarObjeto()
        oeSeguro = New e_SeguroContraRiesgo
        If Operacion = "Nuevo" Then
            oeSeguro.TipoOperacion = "I"
        Else
            oeSeguro.TipoOperacion = "A"
        End If
        oeSeguro.IdEmpresa = cboEmpresa.Value
        oeSeguro.Descripcion = Me.txtDescripcion.Text
        oeSeguro.Fecha = Me.fecPago.Value
        oeSeguro.UsuarioCreacion = gUsuarioSGI.Id
        oeSeguro.Importe = txtImporte.Value
    End Sub

    Public Sub EliminarPago()
        Try
            oeSeguro = New e_SeguroContraRiesgo
            oeSeguro.Id = griSegurosRiesgo.ActiveRow.Cells("Id").Value
            oeSeguro.TipoOperacion = "E"
            If olSeguro.Eliminar(oeSeguro) Then
                mensajeEmergente.Confirmacion("La Informacion ha Sido Eliminada Correctamente")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class