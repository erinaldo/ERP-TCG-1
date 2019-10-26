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
Imports Infragistics.Win.CalcEngine
Imports Infragistics.Win.UltraWinDataSource

Public Class frm_ConsultaMaterialStock
    Inherits frm_MenuPadre

#Region "Declaracion de Variables"

    Private loMaterial As New List(Of e_Material)
    Private oeMaterial As New e_Material
    Private olMaterial As New l_Material

    Private oeRegInv As New e_RegistroInventario
    Private olRegInv As New l_RegistroInventario

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

    Private Shared instancia As frm_ConsultaMaterialStock = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        'Operacion = "Inicializa"
        If instancia Is Nothing Then
            instancia = New frm_ConsultaMaterialStock()
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Eventos"

    Private Sub frm_ConsultaMaterialStock_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtCodigoBarras.Focus()
    End Sub

    Private Sub frm_ConsultaMaterialStock_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ConsultaMaterialStock_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_ConsultaMaterialStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gf_AsignarEventoSeleccionarTexto(Me)
        'griMaterialStock.DataSource = loMaterial
        oeMaterial = New e_Material
        oeMaterial.Activo = True
        oeMaterial.TipoOperacion = "G"
        loMaterial = olMaterial.Listar(oeMaterial)
        ControlBoton(0, 0, 0, 0, 0, 1, 0, 1, 0)
        fecFecha.Value = Date.Now.AddDays(-15)
        Me.txtCodigoBarras.Focus()
        LlenarGrillaKardex("NINGUNO")
        'griMaterialStock.DisplayLayout.Bands(0).Columns("IndDivisible").Hidden = True
        'griMaterialStock.DisplayLayout.Bands(0).Columns("IndActivoFijo").Hidden = True
        'griMaterialStock.DisplayLayout.Bands(0).Columns("IdSubAlmacen").Hidden = True
        'griMaterialStock.DisplayLayout.Bands(0).Columns("Serial").Hidden = True
    End Sub

    Private Sub txtCodigoBarras_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoBarras.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                If txtCodigoBarras.Text <> "" Then
                    BuscarMaterial()
                    txtCodigoBarras.Text = ""
                    txtCodigoBarras.Focus()
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub BuscarMaterial()
        Try
            oeCodBarMat = New e_CodigoBarraMaterial
            oeCodBarMat.TipoOperacion = "1"
            oeCodBarMat.CodigoBarras = Trim(Me.txtCodigoBarras.Text)
            loCodBarMar = olCodBarMat.Listar(oeCodBarMat)
            Dim IdMaterial As String = ObtenerIdMaterial()
            If loCodBarMar.Count > 0 Then
                LlenarGrillaKardex(IdMaterial)
                LlenarGrillaReq(IdMaterial)
            Else
                Throw New Exception("Codigo de Barra no Asignado a Material")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ObtenerIdMaterial() As String
        Try
            If loCodBarMar.Count = 1 Then
                For Each mat As e_Material In loMaterial
                    If mat.Id = loCodBarMar.Item(0).IdMaterial Then
                        txtMaterial.Text = ""
                        txtCodigo.Text = ""
                        txtMaterial.Text = mat.Nombre
                        txtCodigo.Text = txtCodigoBarras.Text
                        Return mat.Id
                    End If
                Next
            Else
                Dim listamaterial As New List(Of e_Material)
                For Each mat As e_Material In loMaterial
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
                txtCodigo.Text = ""
                txtMaterial.Text = frm.SeleccionMaterial.Nombre
                txtCodigo.Text = txtCodigoBarras.Text
                Return frm.SeleccionMaterial.Id
            End If
            Return String.Empty
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub LlenarGrillaKardex(IdMaterial As String)
        Try
            oeRegInv = New e_RegistroInventario
            oeRegInv.TipoOperacion = "T"
            oeRegInv.Activo = True
            oeRegInv.FechaInicio = fecFecha.Value
            oeRegInv.Fecha = ObtenerFechaServidor()
            oeRegInv.IdMaterial = IdMaterial
            Dim ds As DataSet = olRegInv.ListarStock(oeRegInv)
            Dim ingreso As Double = 0
            Dim salida As Double = 0

            Dim parentCol As DataColumn = ds.Tables(0).Columns("IdSubAlmacen")
            Dim childCol As DataColumn = ds.Tables(1).Columns("IdSubAlmacen")
            Dim relation As DataRelation = New DataRelation("FKSubAlmacen", parentCol, childCol, True)
            ds.Relations.Add(relation)
            ds.AcceptChanges()
            Me.griMaterialStock.DataSource = ds
            If ds.Tables.Count > 0 AndAlso ds.Tables(1).Rows.Count > 0 Then
                Dim i As Integer = 0
                While i <= ds.Tables(1).Rows.Count - 1
                    Dim saldo As Double = ds.Tables(0).Rows(i).Item("Stock")
                    ds.Tables(1).Rows(i).Item("Saldo") = saldo
                    ingreso = ds.Tables(1).Rows(i).Item("Ingreso")
                    salida = ds.Tables(1).Rows(i).Item("Salida")
                    saldo = saldo - ingreso + salida
                    i = i + 1
                End While
            End If
            With griMaterialStock
                .DisplayLayout.Bands(0).Columns("IdMaterial").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdSubAlmacen").Hidden = True
                .DisplayLayout.Bands(0).Columns("Almacen").Hidden = False
                .DisplayLayout.Bands(0).Columns("Codigo").Header.VisiblePosition = 1
                '.DisplayLayout.Bands(0).Columns("CodigoBarras").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Material").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Almacen").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("SubAlmacen").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("Precio").Header.Caption = "Stock"

                .DisplayLayout.Bands(0).Columns("Codigo").Width = 80
                '.DisplayLayout.Bands(0).Columns("CodigoBarras").Width = 120
                .DisplayLayout.Bands(0).Columns("Material").Width = 350
                .DisplayLayout.Bands(0).Columns("Almacen").Width = 220
                .DisplayLayout.Bands(0).Columns("SubAlmacen").Width = 320
                .DisplayLayout.Bands(0).Columns("Stock").Width = 80

                .DisplayLayout.Bands(1).Columns("Id").Hidden = True
                .DisplayLayout.Bands(1).Columns("IdSubAlmacen").Hidden = True
                .DisplayLayout.Bands(1).Columns("IdOrden").Hidden = True
                '.DisplayLayout.Bands(1).Columns("Saldo").Hidden = True

                .DisplayLayout.Bands(1).Columns("TipoMovimiento").Width = 80
                .DisplayLayout.Bands(1).Columns("Fecha").Width = 80
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarGrillaReq(IdMaterial As String)
        Try
            Dim oeReq As New e_Requerimiento
            Dim olReq As New l_Requerimiento
            oeReq.TipoOperacion = "B"
            oeReq.IdArea = gUsuarioSGI.oeArea.Id
            oeReq.IdEquipo = IdMaterial
            griListaRequerimientos.DataSource = olReq.Listar(oeReq)
            For Each fila As UltraGridRow In griListaRequerimientos.Rows
                Select Case fila.Cells("IdEquipo").Value
                    Case "0"
                        fila.CellAppearance.BackColor = Color.Aquamarine
                    Case "1"
                        fila.CellAppearance.BackColor = Color.Khaki
                    Case Else
                        fila.CellAppearance.BackColor = Color.White
                End Select
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region
    
End Class