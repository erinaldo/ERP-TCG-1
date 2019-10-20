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

Public Class frm_ConteoMaterial
    Inherits ISL.Win.frm_MenuPadre

#Region "Variables"

    Dim l1Material As New List(Of e_Material)
    Dim l2Material As New List(Of e_Material)
    Dim odMaterial As New l_Material
    Dim oeMaterial As New e_Material

    Private oeCodBarMat As New e_CodigoBarraMaterial
    Private olCodBarMat As New l_CodigoBarraMaterial
    Private loCodBarMar As New List(Of e_CodigoBarraMaterial)

#End Region

#Region "Inicialización del formulario"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ConteoMaterial = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        'Operacion = "Inicializa"
        If instancia Is Nothing Then
            instancia = New frm_ConteoMaterial()
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Eliminar()
        Try
            If griMaterial.Rows.Count > 0 Then
                QuitarDetalle()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try

            If griMaterial.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griMaterial)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub BuscaCodigoBarras()
        Try
            Dim flag As Boolean = False
            oeCodBarMat = New e_CodigoBarraMaterial
            oeCodBarMat.TipoOperacion = "1"
            oeCodBarMat.CodigoBarras = Trim(Me.txtCodigoBarras.Text)
            loCodBarMar = olCodBarMat.Listar(oeCodBarMat)
            If loCodBarMar.Count > 0 Then
                If loCodBarMar.Count = 1 Then
                    If l1Material.Count > 0 Then
                        For Each mat As e_Material In l1Material
                            If mat.Id = loCodBarMar.Item(0).IdMaterial Then
                                mat.Precio += 1
                                griMaterial.DataBind()
                                Exit Sub
                            End If
                        Next
                    End If
                    For Each mat As e_Material In l2Material
                        If mat.Id = loCodBarMar.Item(0).IdMaterial Then
                            txtMaterial.Text = ""
                            oeMaterial = New e_Material
                            oeMaterial = mat
                            txtMaterial.Text = mat.Nombre
                            l1Material.Add(oeMaterial)
                            flag = 1
                        End If
                    Next
                    griMaterial.DataBind()
                Else
                    Dim listamaterial As New List(Of e_Material)
                    For Each mat As e_Material In l2Material
                        For Each codmat As e_CodigoBarraMaterial In loCodBarMar
                            If mat.Id = codmat.IdMaterial Then
                                listamaterial.Add(mat)
                            End If
                        Next
                    Next
                    Dim frm As New frm_DetalleCodigoBarra
                    frm.Material(listamaterial)
                    frm.ShowDialog()
                    txtMaterial.Text = ""
                    txtMaterial.Text = frm.SeleccionMaterial.Nombre
                    If l1Material.Count > 0 Then
                        For Each mat As e_Material In l1Material
                            If mat.Id = frm.SeleccionMaterial.Id Then
                                mat.Precio += 1
                                griMaterial.DataBind()
                                Exit Sub
                            End If
                        Next
                    End If
                    For Each mat As e_Material In l2Material
                        If mat.Id = frm.SeleccionMaterial.Id Then
                            txtMaterial.Text = ""
                            oeMaterial = New e_Material
                            oeMaterial = mat
                            txtMaterial.Text = mat.Nombre
                            l1Material.Add(oeMaterial)
                            flag = 1
                        End If
                    Next
                    griMaterial.DataBind()
                End If
            End If
            If flag = 0 Then
                Throw New Exception("Material no tiene Codigo de Barra Asociado")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub frm_ConteoMaterial_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(0, 0, 0, 0, 0, 1, 0, 1, 0)
    End Sub

    Private Sub frm_ConteoMaterial_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ConteoMaterial_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_ConteoMaterial_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        griMaterial.DataSource = l1Material
        oeMaterial = New e_Material
        oeMaterial.Activo = True
        oeMaterial.TipoOperacion = "G"
        l2Material = odMaterial.Listar(oeMaterial)
        With griMaterial
            .DisplayLayout.Bands(0).Columns("IndDivisible").Hidden = True
            .DisplayLayout.Bands(0).Columns("SubAlmacen").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdSubAlmacen").Hidden = True
            .DisplayLayout.Bands(0).Columns("Serial").Hidden = True
            .DisplayLayout.Bands(0).Columns("IndActivoFijo").Hidden = True
            .DisplayLayout.Bands(0).Override.SelectTypeGroupByRow = SelectType.None
            .DisplayLayout.Bands(0).Override.SelectTypeRow = SelectType.SingleAutoDrag
        End With
        ControlBoton(0, 0, 0, 0, 0, 1, 0, 1, 0)
        Me.txtCodigoBarras.Focus()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Try
            If griMaterial.Rows.Count > 0 Then
                QuitarDetalle()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub QuitarDetalle()
        Try
            Dim oeMat As New e_Material
            oeMat = griMaterial.ActiveRow.ListObject
            oeMat = l1Material.Item(l1Material.IndexOf(oeMat))
            l1Material.Remove(oeMat)
            griMaterial.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region
    
    Private Sub Boton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.txtCodigoBarras.Text = ""
        Me.txtCodigoBarras.Focus()
    End Sub

    Private Sub txtCodigoBarras_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoBarras.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                If txtCodigoBarras.Text <> "" Then
                    BuscaCodigoBarras()
                    txtCodigoBarras.Text = ""
                    txtCodigoBarras.Focus()
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            txtCodigoBarras.SelectAll()
        End Try
    End Sub
End Class