Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF

Public Class frm_ReporteMovimientosCaja
    Inherits frm_MenuPadre

#Region "Inicializar el Formulario"

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Shared instancia As frm_ReporteMovimientosCaja = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        Operacion = "Inicializa"
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ReporteMovimientosCaja()

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

    'Dim IdCajaUsuario As String = ""
    'Dim oeCajaUsuario As New e_CajaUsuario
    'Dim olCajaUsuario As New l_CajaUsuario

    Dim oeCaja As e_Caja
    Dim olCaja As New l_Caja
    Dim loCaja As List(Of e_Caja)

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar()
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        If griCajaDiario.Rows.Count > 0 Then Exportar_Excel(griCajaDiario)
    End Sub

#End Region

#Region "Metodos"

    Private Sub Listar()
        Dim Ingreso As Decimal = 0
        Dim Egreso As Decimal = 0
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeCajaDiario = New e_ReporteCajaDiario
            oeCajaDiario.IdCaja = uce_Caja.Value
            oeCajaDiario.FechaInicio = Date.Parse(fec_FechaInicio.Value.ToShortDateString & " " & txt_HoraInicio.Text)
            oeCajaDiario.FechaFin = Date.Parse(fec_FechaFin.Value.ToShortDateString & " " & txt_HoraFin.Text)
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
                .DisplayLayout.Bands(0).Columns("Trabajador").Width = 220
                .DisplayLayout.Bands(0).Columns("FechaMov").Width = 110
                .DisplayLayout.Bands(0).Columns("Voucher").Width = 100
                .DisplayLayout.Bands(0).Columns("Fecha").Width = 70
                .DisplayLayout.Bands(0).Columns("Glosa").Width = 450
                .DisplayLayout.Bands(0).Columns("Ingresos").Width = 70
                .DisplayLayout.Bands(0).Columns("Egresos").Width = 70
                .DisplayLayout.Bands(0).Columns("Usuario").Width = 70
                .DisplayLayout.Bands(0).Columns("Ingresos").CellAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
                .DisplayLayout.Bands(0).Columns("Egresos").CellAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))

                .DisplayLayout.Bands(0).Columns("Ingresos").Format = "#,###,###,####0.00"
                .DisplayLayout.Bands(0).Columns("Egresos").Format = "#,###,###,####0.00"

                .DisplayLayout.Bands(0).Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
                .DisplayLayout.Bands(0).Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
                .DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = UltraGridFilterUIProvider1
                .DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
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

    Private Sub lr_CargarCombo()
        Try
            oeCaja = New e_Caja
            oeCaja.Activo = True
            loCaja = olCaja.Listar(oeCaja)
            LlenarCombo(uce_Caja, "Nombre", loCaja.OrderBy(Function(i) i.Nombre).ToList, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LlenarSaldoAnterior()
        Try
            oeSaldo = New e_Saldo
            oeSaldo.TipoOperacion = "2"
            oeSaldo.IdCaja = uce_Caja.Value
            oeSaldo = olSaldo.Obtener(oeSaldo)
            txt_HoraInicio.Text = String.Empty
            With oeSaldo
                fec_FechaInicio.Value = .FechaHora.Date
                txt_HoraInicio.Text = CStr(.FechaHora.Hour & ":" & .FechaHora.Minute & ":" & .FechaHora.Second)
                'cboHoraInicio.SelectedIndex = 0
                decSaldoInicio.Value = .Saldo
            End With
            lr_FechaFin()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub lr_FechaFin()
        Dim fec_Servidor As Date = ObtenerFechaServidor()
        fec_FechaFin.Value = fec_Servidor.Date
        txt_HoraFin.Text = String.Empty
        txt_HoraFin.Text = CStr(fec_Servidor.Hour & ":" & (fec_Servidor.Minute + 5) & ":" & fec_Servidor.Second)
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ReporteMovimientosCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            lr_CargarCombo()
            lr_FechaFin()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub uce_Caja_ValueChanged(sender As Object, e As EventArgs) Handles uce_Caja.ValueChanged
        Try
            LlenarSaldoAnterior()
            lr_FechaFin()
        Catch ex As Exception
            If uce_Caja.SelectedIndex > -1 Then LlenarSaldoAnterior()
        End Try
    End Sub

    Private Sub frm_ReporteMovimientosCaja_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

#End Region

End Class