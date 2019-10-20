'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Configuration
Imports Infragistics.Win.CalcEngine
Imports Infragistics.Win.UltraWinDataSource

Public Class frm_Zona
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicialización del formulario"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_Zona = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        'Operacion = "Inicializa"
        If instancia Is Nothing Then
            instancia = New frm_Zona()
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Variables"

    Private oeZonaAlmacen As New e_Zona
    Private olZonaAlmacen As New l_Zona
    Private loZonaAlmacen As New List(Of e_Zona)

    Private oeAlmacen As New e_Almacen
    Private olAlmacen As New l_Almacen

    Private oeCentro As New e_Centro
    Private olCentro As New l_Centro

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            'Operacion = "Inicializa"
            'Tiempo1.Enabled = True
            Listar()
            'If griListaMaterialesAlmacen.Rows.Count > 0 Then
            '    If Activo Then
            '        ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
            '    Else
            '        ControlBoton(1, 1, 1, 0, 0, 0, 1, 0, 1)
            '    End If
            'Else
            '    ControlBoton(1, 1)
            'End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            'Inicializar()
            'Operacion = "Nuevo"
            'oeMaterialAlmacen.TipoOperacion = "I"
            'MostrarTabs(1, ficMaterialAlmacen, 1)
            'LlenarComboMaestro(cboCentroM, olCentro.Listar(oeCentro), 0)
            'MyBase.Nuevo()

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Public Overrides Sub Editar()
        Try
            'If ltMateriales.Where(Function(item) item.Seleccion).Count > 0 Then
            '    Mostrar()
            '    oeMaterialAlmacen.TipoOperacion = "A"
            '    Operacion = "Editar"
            '    LimpiarListas()
            '    MostrarTabs(1, ficMaterialAlmacen, 1)
            '    LlenarComboMaestro(cboCentroM, olCentro.Listar(oeCentro), 0)
            '    MostrarTabs(1, tcDetalle, 0)
            '    MyBase.Editar()
            'Else
            '    mensajeEmergente.Confirmacion("Seleccione Materiales", True)
            'End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        'oeMaterialAlmacen.Activo = True
        'If GuardarMaterialAlmacen() Then
        '    MyBase.Guardar()
        '    MostrarTabs(0, ficMaterialAlmacen)
        '    Consultar(True)
        'End If

    End Sub

    Public Overrides Sub Cancelar()
        Try
            MostrarTabs(0, ficZonaAlmacen, 0)

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            'With griListaMaterialesAlmacen
            '    If ltMateriales.Where(Function(item) item.Seleccion).Count = 0 Then
            '        mensajeEmergente.Problema("Seleccione Materiales")
            '        Exit Sub
            '    End If
            '    listaMat = New List(Of e_MaterialAlmacen)
            '    For Each oeMaterial As e_MaterialAlmacen In ltMateriales.Where(Function(item) item.Seleccion)
            '        oeMaterial.Seleccion = False
            '        listaMat.Add(oeMaterial)
            '    Next
            '    If MessageBox.Show("Esta seguro de desasignar los material seleccionados ? ", _
            '              "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            '        olMaterialAlmacen.Eliminar(listaMat)
            '        Inicializar()
            '        Consultar(True)
            '        Throw New Exception("La informacion  se elimino en " & Me.Text)
            '    End If
            'End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub


    Public Overrides Sub Salir()
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Zona_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(1, 1, 1, 1, 1, 1, 1, 1, 1)
    End Sub

    Private Sub frm_Zona_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Zona_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_Zona_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarCombos()
        'CargaArbol()
    End Sub

    Private Sub cboCentro_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCentro.ValueChanged
        CargarAlmacen(cboCentro.Value)
    End Sub

#End Region

    Private Sub CargarCombos()
        oeCentro.TipoOperacion = ""
        oeCentro.Activo = True
        LlenarCombo(cboCentro, "Nombre", olCentro.Listar(oeCentro), 0)
        cboCentro.Value = ObtenerCentro.Id
    End Sub

    Private Sub CargarAlmacen(ByVal idCentro As String)
        oeAlmacen.TipoOperacion = ""
        oeAlmacen.Activo = True
        oeAlmacen.IdCentro = idCentro
        cboAlmacen.Clear()
        LlenarCombo(cboAlmacen, "Nombre", olAlmacen.Listar(oeAlmacen), 0)
    End Sub

    Private Sub CargaArbol()

        Dim i, c, j As Integer
        Dim x As String = ""
        For i = 0 To 5
            x = Str(i)
            arZonasAlmacen.Nodes.Add(x)
            For c = 0 To 5
                x = Str(i) & Str(c)
                arZonasAlmacen.Nodes(i).Nodes.Add(x)
                For j = 0 To 3
                    x = Str(i) & Str(c) & Str(j)
                    arZonasAlmacen.Nodes(i).Nodes(c).Nodes.Add(x)
                Next
            Next
        Next
    End Sub

#Region "Menu Contextual"

    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        Try
            If arZonasAlmacen.ActiveNode.Selected Then
                MenuContextual1.Items("ToolStripMenuItem1").Visible = True
                MenuContextual1.Items("ToolStripMenuItem2").Visible = True
                MenuContextual1.Items("ToolStripMenuItem3").Visible = True
            Else
                MenuContextual1.Items("ToolStripMenuItem1").Visible = False
                MenuContextual1.Items("ToolStripMenuItem2").Visible = False
                MenuContextual1.Items("ToolStripMenuItem3").Visible = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region
    
    Private Sub arZonasAlmacen_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arZonasAlmacen.DoubleClick
        Try
            If arZonasAlmacen.ActiveNode.Selected Then
                MostrarTabs(1, ficZonaAlmacen, 0)
                Inicializar()
                Mostrar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Inicializar()

    End Sub

    Private Sub Mostrar()
        Try
            oeZonaAlmacen = New e_Zona
            oeZonaAlmacen.Id = arZonasAlmacen.ActiveNode.Tag.ToString

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Listar()
        Try
            oeZonaAlmacen = New e_Zona
            oeZonaAlmacen.IdAlmacen = cboAlmacen.Value

            Dim x As String = ""
            Dim i As Integer = 0
            Dim j As Integer = 0
            For Each zona1 As e_Zona In loZonaAlmacen
                If Trim(zona1.IdDependencia) = "" Then
                    x = zona1.Zona
                    arZonasAlmacen.Nodes.Add(x)
                    For Each zona2 As e_Zona In loZonaAlmacen
                        If Trim(zona2.IdDependencia) <> "" Then
                            x = zona1.Zona & " " & zona2.SubZona
                            arZonasAlmacen.Nodes(loZonaAlmacen.IndexOf(zona1)).Nodes.Add(x)
                            For Each zona3 As e_Zona In loZonaAlmacen
                                x = zona1.Zona & " " & zona2.SubZona & " " & zona3.Ubicacion
                                Dim a As Integer = loZonaAlmacen.IndexOf(zona1)
                                Dim b As Integer = loZonaAlmacen.IndexOf(zona2)
                                arZonasAlmacen.Nodes(i).Nodes(j).Nodes.Add(x)
                            Next
                        End If
                    Next
                End If

                For i = 0 To 5
                    x = Str(i)
                    arZonasAlmacen.Nodes.Add(x)
                    For c = 0 To 5
                        x = Str(i) & Str(c)
                        arZonasAlmacen.Nodes(i).Nodes.Add(x)
                        For j = 0 To 3
                            x = Str(i) & Str(c) & Str(j)
                            arZonasAlmacen.Nodes(i).Nodes(c).Nodes.Add(x)
                        Next
                    Next
                Next
            Next
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub
End Class