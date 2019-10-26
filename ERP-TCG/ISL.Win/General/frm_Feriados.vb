'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Configuration
Imports Infragistics.Win.UltraWinDataSource

Public Class frm_Feriados
    Inherits frm_MenuPadre

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_Feriados = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Feriados()
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Declaración de variables"

    Public WithEvents oeFeriados As New e_Feriados
    Public olFeriados As New l_Feriados

    Private oeTipoFeriado As New e_TipoFeriado
    Private olTipoFeriado As New l_TipoFeriado

    Dim _ingresando_datos As Boolean = False

#End Region

#Region "Botones"

    Public Overrides Sub Nuevo()
        Try
            Operacion = "Nuevo"
            MostrarTabs(1, ficFeriados, 1)
            Inicializar()
            dtpFecha.Focus()
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
            Inicializar()
            Operacion = "Editar"
            MostrarTabs(1, ficFeriados, 1)
            Mostrar()
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarFeriado() Then
                mensajeEmergente.Confirmacion("La Informacion ha sido Guardada Correctamente")
                MostrarTabs(0, ficFeriados, 0)
                Consultar(True)
            Else
                MostrarTabs(1, ficFeriados, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeFeriados.Modificado Then
                Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarFeriado() Then
                            MostrarTabs(0, ficFeriados, 2)
                            _ingresando_datos = False
                            Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficFeriados, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficFeriados, 2)
                        _ingresando_datos = False
                        Consultar(True)
                End Select
            Else
                MostrarTabs(0, ficFeriados)
                _ingresando_datos = False
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If griFeriados.Rows.Count > 0 Then
                Exportar_Excel(griFeriados)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If griFeriados.Rows.Count > 0 Then
                EliminarFeriado()
                Listar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Public Sub Inicializar()
        oeFeriados = New e_Feriados
        cboTipoFeriado.SelectedIndex = -1
        Me.txtDescripcion.Text = String.Empty
        Me.chkIndLaborable.Checked = False
    End Sub

    Public Sub Listar()
        Try
            Dim loFeriados As New List(Of e_Feriados)
            oeFeriados = New e_Feriados
            oeFeriados.TipoOperacion = ""
            loFeriados = olFeriados.Listar(oeFeriados)
            griFeriados.DataSource = loFeriados
            If griFeriados.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
            Else
                ControlBoton(1, 1)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Mostrar()
        Try
            oeFeriados.TipoOperacion = ""
            oeFeriados.Id = griFeriados.ActiveRow.Cells("Id").Value.ToString
            oeFeriados = olFeriados.Obtener(oeFeriados)
            dtpFecha.Value = oeFeriados.Fecha
            cboTipoFeriado.Value = oeFeriados.IdTipoFeriado
            txtDescripcion.Text = oeFeriados.Descripcion
            chkIndLaborable.Checked = oeFeriados.IndLaborable
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function GuardarFeriado() As Boolean
        Try
            LlenaObjeto()
            oeFeriados.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olFeriados.Guardar(oeFeriados) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub EliminarFeriado()
        Try
            oeFeriados = New e_Feriados
            oeFeriados.Id = griFeriados.ActiveRow.Cells("Id").Value
            If olFeriados.Eliminar(oeFeriados) Then
                mensajeEmergente.Confirmacion("La Informacion ha sido Eliminada Correctamente")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LlenaCombos()
        Try
            oeTipoFeriado = New e_TipoFeriado
            LlenarCombo(cboTipoFeriado, "Nombre", olTipoFeriado.Listar(oeTipoFeriado), -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaObjeto()
        Try
            If Operacion = "Editar" Then
                oeFeriados.TipoOperacion = "A"
            Else
                oeFeriados.TipoOperacion = "I"
            End If
            oeFeriados.Fecha = dtpFecha.Value
            oeFeriados.Descripcion = txtDescripcion.Text
            oeFeriados.FechaCreacion = ObtenerFechaServidor()
            oeFeriados.IdTipoFeriado = cboTipoFeriado.Value
            oeFeriados.UsuarioCreacion = gUsuarioSGI.Id
            If chkIndLaborable.Checked Then
                oeFeriados.IndLaborable = True
            Else
                oeFeriados.IndLaborable = False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Feriados_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Select Case ficFeriados.SelectedTab.Index
            Case 0
                If griFeriados.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 1, 1)
        End Select
    End Sub

    Private Sub frm_Feriados_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Feriados_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_Feriados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenaCombos()
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs)
        oeFeriados.Modificado = True
    End Sub

    Private Sub cboTipoFeriado_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoFeriado.ValueChanged
        oeFeriados.Modificado = True
    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged
        oeFeriados.Modificado = True
    End Sub

    Private Sub chkIndLaborable_CheckedChanged(sender As Object, e As EventArgs) Handles chkIndLaborable.CheckedChanged
        oeFeriados.Modificado = True
    End Sub

    Private Sub griFeriados_DoubleClick(sender As Object, e As EventArgs) Handles griFeriados.DoubleClick
        Editar()
    End Sub

    Private Sub griFeriados_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griFeriados.BeforeRowsDeleted
        e.Cancel = True
    End Sub

#End Region    
    
End Class