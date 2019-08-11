Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
'Imports System.Math
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics

Public Class frm_ReporteCajaDiario
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializar el Formulario"

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Shared instancia As frm_ReporteCajaDiario = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        Operacion = "Inicializa"
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ReporteCajaDiario()

        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Dim oeCajaDiario As New e_ReporteCajaDiario
    Dim olCajaDiario As New l_ReporteCajaDiario
    Dim loCajaDiario As New List(Of e_ReporteCajaDiario)

    Dim oeSaldo As New e_Saldo
    Dim olSaldo As New l_Saldo

    Dim IdCajaUsuario As String = ""
    Dim oeCajaUsuario As New e_CajaUsuario
    Dim olCajaUsuario As New l_CajaUsuario


#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        If griCajaDiario.Rows.Count > 0 Then Exportar_Excel(griCajaDiario)
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ReporteCajaDiario_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)
    End Sub

    Private Sub frm_ReporteCajaDiario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ReporteCajaDiario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            griCajaDiario.DataSource = New List(Of e_ReporteCajaDiario)
            decSaldo.Value = 0
            fecFechaFin.Value = Date.Now.Date
            cboHoraFin.Items.Add(Now.Hour & ":" & Now.Minute & ":" & Now.Second)
            cboHoraFin.SelectedIndex = 0
            BuscarUsuarioCaja()
            LlenarSaldoAnterior()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub MnuConReporteCajaDiario_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MnuConReporteCajaDiario.Opening
        MnuConReporteCajaDiario.Items("mnuCierreCaja").Visible = False
        If griCajaDiario.Rows.Count > 0 Then
            MnuConReporteCajaDiario.Items("mnuCierreCaja").Visible = True
        End If
    End Sub

    Private Sub mnuCierreCaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCierreCaja.Click
        Try
            Dim oeCierreCaja As New e_CierreCaja
            Dim olCierreCaja As New l_CierreCaja
            Dim oeCierreCajaDet As New e_CierreCajaDet
            Dim loCierreCajaDet As New List(Of e_CierreCajaDet)
            If MessageBox.Show("¿Desea Cerrar Caja? " & Me.Text, "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = Windows.Forms.DialogResult.Yes Then
                For Each cajdia As e_ReporteCajaDiario In loCajaDiario
                    If cajdia.Codigo = "PRE-ENVIADO" Or cajdia.Codigo = "GENERADA" Then
                        Throw New Exception("No Puede Cerrar Hasta que se Aprueben sus Gastos")
                    End If
                Next
                oeSaldo = New e_Saldo
                oeSaldo.TipoOperacion = "I"
                oeSaldo.Tipo = 2
                oeSaldo.IdCuentaCorriente = String.Empty
                oeSaldo.IdCaja = oeCajaUsuario.IdCaja
                oeSaldo.FechaHora = Date.Now
                oeSaldo.Saldo = decSaldo.Value
                oeSaldo.Activo = True
                oeSaldo.UsuarioCreacion = gUsuarioSGI.Id
                With oeCierreCaja
                    .TipoOperacion = "I"
                    .Monto = Me.decSaldo.Value
                    .IdCentro = ObtenerCentro.Id
                    .IdCaja = IdCajaUsuario
                    .FechaCreacion = fecFechaFin.Value
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .Glosa = "CIERRE DE CAJA DEL DIA: " & Date.Now
                    For Each rptcaja As e_ReporteCajaDiario In loCajaDiario
                        oeCierreCajaDet = New e_CierreCajaDet()
                        oeCierreCajaDet.Fecha = rptcaja.FechaMov
                        oeCierreCajaDet.Voucher = rptcaja.Voucher
                        oeCierreCajaDet.Glosa = rptcaja.Glosa
                        oeCierreCajaDet.Ingreso = rptcaja.Ingresos
                        oeCierreCajaDet.Egreso = rptcaja.Egresos
                        loCierreCajaDet.Add(oeCierreCajaDet)
                    Next
                    .loCierreCajaDet = loCierreCajaDet
                    .oeMovimiento = Nothing
                    .oeGastoOperacion = Nothing
                    .oeOtrosIngresos = Nothing
                    .oeValesRendir = Nothing
                End With
                If olCierreCaja.Guardar(oeCierreCaja) Then
                    If olSaldo.Guardar(oeSaldo) Then
                        mensajeEmergente.Confirmacion("La informacion de cierre de caja ha sido grabada satisfactoriamente en " & Me.Text, True)
                        griCajaDiario.Focus()
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CuadreCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuadreCajaToolStripMenuItem.Click
        Try
            If griCajaDiario.Rows.Count > 0 Then
                Dim CierreCaja As New frm_CuadreCaja
                CierreCaja = CierreCaja.getInstancia()
                CierreCaja.MdiParent = frm_Menu
                CierreCaja.Show()
                CierreCaja.CargarCierre(decSaldo.Value, Date.Parse(fecFechaInicio.Value.ToShortDateString & " " & cboHoraInicio.Text))
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_ReporteCajaDiario_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

#End Region

#Region "Metodos"

    Public Sub Listar(ByVal Activo As Boolean)
        Dim Ingreso As Decimal = 0
        Dim Egreso As Decimal = 0
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeCajaDiario = New e_ReporteCajaDiario
            oeCajaDiario.IdCaja = IdCajaUsuario
            oeCajaDiario.FechaInicio = Date.Parse(fecFechaInicio.Value.ToShortDateString & " " & cboHoraInicio.Text)
            oeCajaDiario.FechaFin = Date.Parse(fecFechaFin.Value.ToShortDateString & " " & cboHoraFin.Text)
            With griCajaDiario
                loCajaDiario.Clear()
                .ResetDisplayLayout()
                loCajaDiario = olCajaDiario.Listar(oeCajaDiario)
                .DataSource = loCajaDiario
                .DisplayLayout.Bands(0).Columns("Ingresos").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("Egresos").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("Ingresos").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("Egresos").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("FechaMov").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
                .DisplayLayout.Bands(0).Columns("Codigo").Width = 100
                .DisplayLayout.Bands(0).Columns("Trabajador").Width = 250
                .DisplayLayout.Bands(0).Columns("FechaMov").Width = 110
                .DisplayLayout.Bands(0).Columns("Voucher").Width = 100
                .DisplayLayout.Bands(0).Columns("Fecha").Width = 70
                .DisplayLayout.Bands(0).Columns("Glosa").Width = 450
                .DisplayLayout.Bands(0).Columns("Ingresos").Width = 70
                .DisplayLayout.Bands(0).Columns("Egresos").Width = 70
                .DisplayLayout.Bands(0).Columns("Ingresos").CellAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
                .DisplayLayout.Bands(0).Columns("Egresos").CellAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))

                .DisplayLayout.Bands(0).Columns("Ingresos").Format = "#,###,###,####0.00"
                .DisplayLayout.Bands(0).Columns("Egresos").Format = "#,###,###,####0.00"

                .DisplayLayout.Bands(0).Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
                .DisplayLayout.Bands(0).Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
                .DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.HeaderClickAction = HeaderClickAction.SortMulti
                '.DisplayLayout.RowScrollRegions(0).Spli = Scrollbar.Hide
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                    CalcularTotales(griCajaDiario, "Ingresos", "Egresos")
                End If
                For Each Lista As e_ReporteCajaDiario In loCajaDiario
                    Egreso += Lista.Egresos
                    Ingreso += Lista.Ingresos
                Next
                decSaldo.Value = Math.Round(Ingreso - Egreso, 2)
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Sub LlenarSaldoAnterior()
        Try
            oeSaldo = New e_Saldo
            oeSaldo.TipoOperacion = "2"
            oeSaldo.IdCaja = IdCajaUsuario
            oeSaldo = olSaldo.Obtener(oeSaldo)
            With oeSaldo
                fecFechaInicio.Value = .FechaHora.Date
                cboHoraInicio.Items.Add(.FechaHora.Hour & ":" & .FechaHora.Minute & ":" & .FechaHora.Second)
                cboHoraInicio.SelectedIndex = 0
                decSaldoInicio.Value = .Saldo
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub BuscarUsuarioCaja()
        Try
            oeCajaUsuario = New e_CajaUsuario
            oeCajaUsuario.IdTrabajador = gUsuarioSGI.IdTrabajador
            oeCajaUsuario = olCajaUsuario.Obtener(oeCajaUsuario)
            If oeCajaUsuario.Id <> "" Then IdCajaUsuario = oeCajaUsuario.IdCaja
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

End Class