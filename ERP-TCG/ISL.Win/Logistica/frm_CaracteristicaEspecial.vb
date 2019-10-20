'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_CaracteristicaEspecial
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializacion"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_CaracteristicaEspecial = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_CaracteristicaEspecial()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private WithEvents oeCaracteristicaEspecial As New e_CaracteristicaEspecial
    Private olCaracteristicaEspecial As New l_CaracteristicaEspecial
    Private loCaracteristicaEspecial As New List(Of e_CaracteristicaEspecial)
    'Private oeCuentaCorriente As New e_CuentaCorriente
    'Private olCuentaCorriente As New l_CuentaCorriente
    'Private loCuentaCorriente As New List(Of e_CuentaCorriente)

    'Private oeCentro As New e_Centro
    'Private olCentro As New l_Centro

    Dim _ingresando_datos As Boolean = False

#End Region

#Region "Botones"

    Public Overrides Sub Nuevo()
        Try
            Operacion = "Nuevo"
            MostrarTabs(1, ficCaracteristicaEspecial, 1)
            Inicializar()
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
            If Me.griCaracteristicaEspecial.Rows.Count > 0 Then
                MostrarTabs(1, ficCaracteristicaEspecial, 1)
                Mostrar()
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            Try
                Select Case ficCaracteristicaEspecial.SelectedTab.Index
                    Case 1
                        If GuardarCaracteristica() Then
                            MostrarTabs(0, ficCaracteristicaEspecial, 0)
                            Listar()
                        Else
                            MostrarTabs(1, ficCaracteristicaEspecial, 1)
                        End If
                End Select
            Catch ex As Exception
                mensajeEmergente.Problema(ex.Message)
            End Try
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeCaracteristicaEspecial.Modificado Then
                Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarCaracteristica() Then
                            MostrarTabs(0, ficCaracteristicaEspecial, 2)
                            _ingresando_datos = False
                            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficCaracteristicaEspecial, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficCaracteristicaEspecial, 2)
                        _ingresando_datos = False
                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End Select
            Else
                MostrarTabs(0, ficCaracteristicaEspecial)
                _ingresando_datos = False
                Listar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If ficCaracteristicaEspecial.Tabs(0).Selected AndAlso griCaracteristicaEspecial.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            If ficCaracteristicaEspecial.Tabs(0).Selected Then Exportar_Excel(griCaracteristicaEspecial)

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        griCaracteristicaEspecial.ActiveRow.Delete()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_CaracteristicaEspecial_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case Me.ficCaracteristicaEspecial.SelectedTab.Index
            Case 0
                If Me.griCaracteristicaEspecial.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 1, 1)
        End Select
    End Sub

    Private Sub frm_CaracteristicaEspecial_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_CaracteristicaEspecial_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub


#End Region

#Region "Metodos"

    Private Sub Inicializar()
        oeCaracteristicaEspecial = New e_CaracteristicaEspecial
        txtNombre.Text = String.Empty
        txtAbreviatura.Text = String.Empty
        txtNombre.Focus()
    End Sub

    Private Function GuardarCaracteristica() As Boolean
        Try
            If txtNombre.Text = "" Then Throw New Exception("Ingrese Nombre")
            If txtAbreviatura.Text = "" Then Throw New Exception("Ingrese Abreviatura")
            With oeCaracteristicaEspecial
                If Operacion = "Nuevo" Then
                    .TipoOperacion = "I"
                Else
                    .TipoOperacion = "A"
                End If
                .Nombre = txtNombre.Text
                .Abreviatura = txtAbreviatura.Text
                .UsuarioCreacion = gUsuarioSGI.Id
                .FechaCreacion = ObtenerFechaServidor()
                .PrefijoID = gs_PrefijoIdSucursal '@0001
                If olCaracteristicaEspecial.Guardar(oeCaracteristicaEspecial) Then
                    mensajeEmergente.Confirmacion("La Informacion ha Sido Guardada Satisfactoriamente")
                    Return True
                Else
                    Return False
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Function

    Private Sub Listar()
        Try
            oeCaracteristicaEspecial = New e_CaracteristicaEspecial
            oeCaracteristicaEspecial.TipoOperacion = ""
            loCaracteristicaEspecial = olCaracteristicaEspecial.Listar(oeCaracteristicaEspecial)
            griCaracteristicaEspecial.DataSource = loCaracteristicaEspecial
            If griCaracteristicaEspecial.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Mostrar()
        Try
            oeCaracteristicaEspecial = New e_CaracteristicaEspecial
            oeCaracteristicaEspecial.TipoOperacion = ""
            oeCaracteristicaEspecial.Id = griCaracteristicaEspecial.ActiveRow.Cells(0).Value
            oeCaracteristicaEspecial = olCaracteristicaEspecial.Obtener(oeCaracteristicaEspecial)
            txtNombre.Text = oeCaracteristicaEspecial.Nombre
            txtAbreviatura.Text = oeCaracteristicaEspecial.Abreviatura
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region
    
    Private Sub griCaracteristicaEspecial_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griCaracteristicaEspecial.DoubleClick
        If griCaracteristicaEspecial.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griCaracteristicaEspecial_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griCaracteristicaEspecial.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            Select Case MessageBox.Show("Desea Eliminar el Registro Seleccionado?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Case Windows.Forms.DialogResult.Yes
                    EliminarRegistro()
                    e.Cancel = False
                Case Windows.Forms.DialogResult.No
                    e.Cancel = True
                Case Windows.Forms.DialogResult.Cancel
                    e.Cancel = True
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub EliminarRegistro()
        Try
            oeCaracteristicaEspecial = New e_CaracteristicaEspecial
            oeCaracteristicaEspecial.Id = griCaracteristicaEspecial.ActiveRow.Cells(0).Value
            If olCaracteristicaEspecial.Eliminar(oeCaracteristicaEspecial) Then
                mensajeEmergente.Confirmacion("La Informacion ha sido Eliminada Correctamente")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub
End Class