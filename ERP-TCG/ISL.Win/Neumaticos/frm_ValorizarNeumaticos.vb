'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports ISL.Controles
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports Infragistics.Shared
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinDataSource
Imports System.Collections
Imports Infragistics.Win.UltraWinGrid

Public Class frm_ValorizarNeumaticos
    Inherits ISL.Win.frm_MenuPadre
    Dim oeValorizacionNeumatico As New e_ValorizacionNeumatico, olValorizacionNeumatico As New l_ValorizacionNeumatico
    Dim oeDetalleValorizacionNeumatico As New e_DetalleValorizacionNeumatico, olDetalleValorizacionNeumatico As New l_DetalleValorizacionNeumatico
    Dim oeVidaNeumatico As New e_VidaNeumatico, olVidaNeumatico As New l_VidaNeumatico
    Dim lstVidaNeumatico As New List(Of e_VidaNeumatico)
    Dim lstDetalleVal As New List(Of e_DetalleValorizacionNeumatico)
    Dim _ingresando_datos As Boolean

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Select Case tcValorizaciones.SelectedTab.Index
                Case 0
                    ListarValorizaciones()
                    Tiempo1.Enabled = True
                    Operacion = "Inicializa"
                    If grid_Valorizaciones.Rows.Count > 0 Then
                        MyBase.Consultar(Activo)
                    Else
                        MyBase.Consultar()
                    End If
                Case 1
                    ListarNeumaticosMontados()  
            End Select
           
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        oeValorizacionNeumatico = New e_ValorizacionNeumatico
        oeValorizacionNeumatico.TipoOperacion = "I"
        oeValorizacionNeumatico.UsuarioCreacion = gUsuarioSGI.Id
        'Inicializar()
        MostrarTabs(1, tcValorizaciones, 1)
        Operacion = "Nuevo"
        ControlBoton(1, 0, 0, 1, 1, 0, 0, 1, 1)
    End Sub

    Public Overrides Sub Editar()
       
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarValorizacionNeumaticos() Then
                ControlBoton(1, 1, 0, 0, 0, 1, 0, 0, 1)
            Else
                MostrarTabs(1, tcValorizaciones, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            MostrarTabs(0, tcValorizaciones, 2)
            _ingresando_datos = False
            Consultar(True)
            '    End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        'Try
        '    With grid_Neumatico
        '        If ValidarGrilla(grid_Neumatico, "Neumatico") Then
        '            oeNeumatico.TipoOperacion = ""
        '            oeNeumatico.Id = .ActiveRow.Cells("Id").Value
        '            oeNeumatico = olNeumatico.Obtener(oeNeumatico)
        '            If oeNeumatico.Activo Then
        '                If MessageBox.Show("Esta seguro de eliminar el Neumatico: " & _
        '                .ActiveRow.Cells("Codigo").Value.ToString.Trim & "?", _
        '                "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
        '                    oeNeumatico.TipoOperacion = "E"
        '                    olNeumatico.Eliminar(oeNeumatico)
        '                    Consultar(True)
        '                End If
        '            Else
        '                Throw New Exception("La informacion se encuentra eliminada en " & Me.Text)
        '            End If
        '        End If
        '    End With
        'Catch ex As Exception
        '    mensajeEmergente.Problema(ex.Message)
        'End Try
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try

            If grid_Valorizaciones.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(grid_Valorizaciones)

            If grid_Neumaticos.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(grid_Neumaticos)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Inicializar el formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_ValorizarNeumaticos = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_ValorizarNeumaticos()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

    Private Sub frm_ValorizarNeumaticos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gmt_ConfigurarEventoKeyEnter_Tab(Me)
        gf_AsignarEventoSeleccionarTexto(Me)
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        MostrarTabs(0, tcValorizaciones)
        'Tiempo1.Enabled = False
        Me.dtpFecha.Value = Date.Now
        rfechas.Desde = Date.Today.AddDays(-7) : rfechas.Hasta = Date.Today
    End Sub

    Private Function GuardarValorizacionNeumaticos() As Boolean
        Try
            Dim vtd As Double = 0
            oeValorizacionNeumatico = New e_ValorizacionNeumatico
            oeValorizacionNeumatico.TipoOperacion = "I"
            oeValorizacionNeumatico.Glosa = Me.txtGlosa.Text
            oeValorizacionNeumatico.Fecha = Me.dtpFecha.Value
            oeValorizacionNeumatico.UsuarioCreacion = gUsuarioSGI.Id
            For Each objdet As e_VidaNeumatico In lstVidaNeumatico
                oeDetalleValorizacionNeumatico = New e_DetalleValorizacionNeumatico
                oeDetalleValorizacionNeumatico.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeDetalleValorizacionNeumatico.IdVidaNeumatico = objdet.Id
                oeDetalleValorizacionNeumatico.ValorDolares = objdet.CostoActualDolares
                oeValorizacionNeumatico.lstDetalleValorizacion.Add(oeDetalleValorizacionNeumatico)
                vtd += objdet.CostoActualDolares
            Next
            oeValorizacionNeumatico.ValorTotalDolares = vtd
            oeValorizacionNeumatico.PrefijoID = gs_PrefijoIdSucursal '@0001
            If Not olValorizacionNeumatico.Guardar(oeValorizacionNeumatico) Then Return False
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente.")
            MostrarTabs(0, tcValorizaciones)
            Consultar(True)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Sub ListarValorizaciones()
        Try
            oeValorizacionNeumatico = New e_ValorizacionNeumatico
            oeValorizacionNeumatico.TipoOperacion = ""
            oeValorizacionNeumatico.Activo = True
            oeValorizacionNeumatico.Fecha = Date.Parse("01/01/1901")
            oeValorizacionNeumatico.FechaInicio = rfechas.Desde
            oeValorizacionNeumatico.FechaFin = rfechas.Hasta
            grid_Valorizaciones.DataSource = olValorizacionNeumatico.Listar(oeValorizacionNeumatico)
            grid_Valorizaciones.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Sub ListarNeumaticosMontados()
        Try
            oeVidaNeumatico = New e_VidaNeumatico
            oeVidaNeumatico.Vigente = 1
            oeVidaNeumatico.FechaIngreso = Date.Parse("01/01/1901")
            oeVidaNeumatico.Activo = True
            lstVidaNeumatico = olVidaNeumatico.Listar(oeVidaNeumatico)
            grid_Neumaticos.DataSource = lstVidaNeumatico
            grid_Neumaticos.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub frm_ValorizarNeumaticos_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_ValorizarNeumaticos_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Select Case _Operacion
            Case "Nuevo", "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub grid_Valorizaciones_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grid_Valorizaciones.InitializeLayout
        e.Layout.Grid.CalcManager = Nothing
    End Sub

    Private Sub grid_Valorizaciones_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grid_Valorizaciones.DoubleClickRow
        Try
            If grid_Valorizaciones.Selected.Rows.Count > 0 Then MostrarDetalleValorizaciones()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Sub MostrarDetalleValorizaciones()
        Try
            oeDetalleValorizacionNeumatico = New e_DetalleValorizacionNeumatico
            oeDetalleValorizacionNeumatico.TipoOperacion = ""
            oeDetalleValorizacionNeumatico.IdValorizacion = grid_Valorizaciones.ActiveRow.Cells("Id").Value
            oeDetalleValorizacionNeumatico.Activo = True
            grid_DetalleValorizaciones.DataSource = olDetalleValorizacionNeumatico.Listar(oeDetalleValorizacionNeumatico)
            If grid_DetalleValorizaciones.Rows.Count > 0 Then
                Me.gr_expande_DV.Expanded = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
