Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Configuration
Imports Infragistics.Win.CalcEngine
Imports Infragistics.Win.UltraWinDataSource

Public Class frm_DetalleCodigoBarra
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicialización del formulario"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_DetalleCodigoBarra = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        'Operacion = "Inicializa"
        If instancia Is Nothing Then
            instancia = New frm_DetalleCodigoBarra()
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Variables"

    Private oeMaterial As New e_Material
    Private olMaterial As New l_Material
    Private loMaterial As New List(Of e_Material)

    Private Tipo As Integer = 0

#End Region

#Region "Eventos"

    Private Sub frm_DetalleCodigoBarra_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        griMaterial.Focus()
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
    End Sub

    Private Sub btnMaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaterial.Click
        Dim Material As New frm_Material
        Material = Material.getInstancia()
        Material.MdiParent = frm_Menu
        Material.Show()
        Material.Listar(True)
        Me.Close()
    End Sub

    Private Sub griMaterial_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griMaterial.DoubleClick
        Try
            If Tipo = 0 Then
                SeleccionMaterial()
            Else
                SeleccionRequerimiento()
            End If

            Me.Close()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griMaterial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles griMaterial.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                If Tipo = 0 Then
                    SeleccionMaterial()
                Else
                    SeleccionRequerimiento()
                End If

                Me.Close()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Public Sub Material(ByVal lista As List(Of e_Material))
        Try
            With griMaterial
                .DataSource = lista
                .Focus()
                .Rows.Item(0).Selected = True
                .Rows(0).Activated = True
                Tipo = 0
            End With

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Sub RequerimientoMaterial(ByVal lista As List(Of e_RequerimientoMaterial))
        Try
            With griMaterial
                .DataSource = lista
                .DisplayLayout.Bands(0).Columns("StockActual").Hidden = True
                .DisplayLayout.Bands(0).Columns("Mantenimiento").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdMantenimiento").Hidden = True
                .DisplayLayout.Bands(0).Columns("CantidadARegularizar").Hidden = True
                .DisplayLayout.Bands(0).Columns("CantidadPorRegularizar").Hidden = True
                .DisplayLayout.Bands(0).Columns("IndRegularizado").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdEstadoRequerimientoMaterial").Hidden = True
                .DisplayLayout.Bands(0).Columns("EstadoRequerimientoMaterial").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdCentroCosto").Hidden = True
                .DisplayLayout.Bands(0).Columns("CentroCosto").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdMaterial").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdRequerimiento").Hidden = True
                .DisplayLayout.Bands(0).Columns("Trabajador").Hidden = True
                .DisplayLayout.Bands(0).Columns("Cantidad").Hidden = True
                .DisplayLayout.Bands(0).Columns("CantidadAAtender").Hidden = True
                .DisplayLayout.Bands(0).Columns("CantidadPorAtender").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("CodigoRequerimiento").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdArea").Hidden = True
                .DisplayLayout.Bands(0).Columns("Area").Hidden = True
                .DisplayLayout.Bands(0).Columns("IndicadorAprobacion").Hidden = True

                .DisplayLayout.Bands(0).Columns("CodigoMaterial").Header.Caption = "Codigo"

                .DisplayLayout.Bands(0).Columns("CodigoMaterial").Width = 83
                .DisplayLayout.Bands(0).Columns("Material").Width = 261
                .DisplayLayout.Bands(0).Columns("UnidadMedida").Width = 98

                .DisplayLayout.Bands(0).Columns("CodigoMaterial").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Material").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("UnidadMedida").Header.VisiblePosition = 3

                .Focus()
                Tipo = 1
                .Rows.Item(0).Selected = True
                .Rows(0).Activated = True

            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Function SeleccionMaterial() As e_Material
        Try
            With griMaterial
                If .ActiveRow.Selected Then
                    Dim oeMat As New e_Material
                    oeMat = .ActiveRow.ListObject
                    Return oeMat
                Else
                    Throw New Exception("Seleccione Material")
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function SeleccionRequerimiento() As e_RequerimientoMaterial
        Try
            With griMaterial
                If .ActiveRow.Selected Then
                    Dim oeReqMat As New e_RequerimientoMaterial
                    oeReqMat = .ActiveRow.ListObject
                    Return oeReqMat
                Else
                    Throw New Exception("Seleccione Material")
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

End Class