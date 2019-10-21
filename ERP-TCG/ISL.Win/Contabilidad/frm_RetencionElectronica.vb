'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports System.IO.Compression

Public Class frm_RetencionElectronica
    Inherits frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_RetencionElectronica = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_RetencionElectronica()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Variables"

    Private oeRetencion As e_RetencionImpresa
    Private olRetencion As l_RetencionImpresa
    Private loRetencion As List(Of e_RetencionImpresa)

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            ListarRet()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_RetencionElectronica_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ControlBoton(1)
    End Sub

    Private Sub frm_RetencionElectronica_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_RetencionElectronica_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_RetencionElectronica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        olRetencion = New l_RetencionImpresa
        txtRucAdq.Text = ISL_RUC
        txtRazonSocialAdq.Text = ISL_Nombre
        ControlBoton(1)
    End Sub

    Private Sub btnGenArchivo_Click(sender As Object, e As EventArgs) Handles btnGenArchivo.Click
        Try
            GenerarArchivo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If olRetencion.Guardar(loRetencion) Then
                mensajeEmergente.Confirmacion("La Informacion ha Sido Guardada Correctamente", True)
                loRetencion = New List(Of e_RetencionImpresa)
                griRetDet.DataSource = loRetencion
                griRetDet.DataBind()
                btnGuardar.Enabled = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Try
            QuitarDetalle()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        Try
            With ContextMenuStrip1
                .Items("ToolStripMenuItem1").Visible = False
                If griRetDet.Rows.Count > 0 Then
                    .Items("ToolStripMenuItem1").Visible = True
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griRetDet_KeyDown(sender As Object, e As KeyEventArgs) Handles griRetDet.KeyDown
        With griRetDet
            Dim int As Integer = .ActiveRow.Index
            If int > -1 Then
                If e.KeyCode = Keys.Down Then
                    If .Rows(int).Cells("ImpTotalPagar").IsActiveCell Then
                        .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.ExitEditMode, False, False)
                        .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.BelowCell, False, False)
                        e.Handled = True
                        .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                    End If
                End If
                If e.KeyCode = Keys.Up Then
                    If .Rows(int).Cells("ImpTotalPagar").IsActiveCell Then
                        .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.ExitEditMode, False, False)
                        .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.AboveCell, False, False)
                        e.Handled = True
                        .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                    End If
                End If
                If e.KeyValue = Keys.Space Then
                    .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.ExitEditMode, 0, 0)
                    .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, 0, 0)
                End If
            End If
        End With
    End Sub

    Private Sub griRetDet_CellChange(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griRetDet.CellChange
        griRetDet.UpdateData()
    End Sub

#End Region

#Region "Metodos"

    Private Sub ListarRet()
        Try
            oeRetencion = New e_RetencionImpresa
            loRetencion = New List(Of e_RetencionImpresa)
            oeRetencion.Fecha = DateTimePicker2.Value
            oeRetencion.PrefijoID = gs_PrefijoIdSucursal '@0001
            loRetencion.AddRange(olRetencion.Listar(oeRetencion))
            griRetDet.DataSource = loRetencion.OrderBy(Function(i) i.NumeroRet).ToList
            griRetDet.DataBind()
            CalcularTotales(griRetDet, "ImpTotRet", "ImpTotPag")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GenerarArchivo()
        Dim FechaActual As Date = DateTimePicker2.Value
        Dim NombreArchivo As String = ""
        NombreArchivo = ISL_RUC & "-20-" & CStr(FechaActual.Year) & FormatoDocumento(CStr(FechaActual.Month), 2) & FormatoDocumento(CStr(FechaActual.Day), 2) & "-" & Lote.Text
        Try
            Dim stTexto As String = ""
            Dim LibroTipo As String = ""
            Dim LibroSubTipo As String = ""
            Dim Ctr As Integer = 0
            Dim sfd_Dialogo As New System.Windows.Forms.SaveFileDialog
            With sfd_Dialogo
                .Filter = "Libros de Texto Plano (*.txt)|*.txt|Todos Los Archivos (*.*)|*.*"
                .DefaultExt = "txt"
                .FilterIndex = 1
                .Title = "Exportar a ..."
                .FileName = NombreArchivo
            End With
            Dim result As DialogResult = sfd_Dialogo.ShowDialog()
            Dim stNombreArchivo As String = sfd_Dialogo.FileName

            Dim ObjTxt As New System.IO.StreamWriter(stNombreArchivo, False)
            If result = Windows.Forms.DialogResult.Cancel Then Exit Sub

            If IO.File.Exists(stNombreArchivo) = False Then IO.File.Create(stNombreArchivo)
            For Each oe As e_RetencionImpresa In loRetencion
                oe.PrefijoID = gs_PrefijoIdSucursal '@0001
                stTexto = oe.MotContigencia + "|" + oe.SerieRet + "|" + oe.NumeroRet + "|" + CStr(oe.FechaRet)
                stTexto += "|" + oe.RucPro + "|" + oe.TipoDocPro + "|" + oe.RazonSocial
                stTexto += "|" + oe.RegRet + "|" + "0" + oe.TasaRet.ToString("##0.00") + "|" + oe.ImpTotRet.ToString("##0.00") + "|" + oe.ImpTotPag.ToString("##0.00")
                stTexto += "|" + oe.TipoDocRel + "|" + oe.SerieDocRel + "|" + oe.NumeroDocRel + "|" + oe.FechaEmidoc + "|" + oe.TotalDoc.ToString("##0.00") + "|" + oe.MonedaDoc
                stTexto += "|" + oe.FechaPago + "|" + oe.NroVoucher + "|" + oe.ImpPago.ToString("##0.00") + "|" + oe.MonedaPago
                stTexto += "|" + oe.ImpRetenido.ToString("##0.00") + "|" + CStr(oe.FechaRetencion) + "|" + IIf(oe.ImpTotalPagar = 0, "0", "") + oe.ImpTotalPagar.ToString("##0.00")
                stTexto += "|" + oe.MonExtranjera + "|" + IIf(CDbl(IIf(oe.TipoCambio = "", 0, oe.TipoCambio)) > 0, oe.TipoCambio, "") + "|" + IIf(oe.FechaTC = "01/01/1901", "", oe.FechaTC) + "|"
                ObjTxt.WriteLine(stTexto)

            Next
            ObjTxt.Close()

            If MessageBox.Show("Se ha Generado Satisfactoriamente el archivo, desea poder visualizarlo?", "ISL", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Process.Start(stNombreArchivo)
            End If
            btnGuardar.Enabled = True
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarDetalle()
        Try
            If griRetDet.Selected.Rows.Count > 0 Then
                oeRetencion = New e_RetencionImpresa
                oeRetencion = griRetDet.ActiveRow.ListObject
                loRetencion.Remove(oeRetencion)
                griRetDet.DataSource = loRetencion.OrderBy(Function(i) i.NumeroRet).ToList
                griRetDet.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class