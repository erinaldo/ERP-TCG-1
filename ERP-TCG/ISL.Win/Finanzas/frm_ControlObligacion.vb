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

Public Class frm_ControlObligacion
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ControlObligacion = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ControlObligacion()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oeObligacionFin As e_ObligacionFin, olObligacionFin As l_ObligacionFinanciera, leObligacionFin As List(Of e_ObligacionFin)
    Private oePagoFinan As e_AsientoMov_ObligacionFin, olPagoFinan As l_AsientoMov_ObligacionFin, lePagoFinan As List(Of e_AsientoMov_ObligacionFin)
    Private oePeriodo As e_Periodo, olPeriodo As l_Periodo, lePeriodo As List(Of e_Periodo), lePeriodoAux As List(Of e_Periodo)
    Private oeBanco As e_Proveedor, olBanco As l_Proveedor, leBanco As List(Of e_Proveedor)
    Private oeTipoObligacion As e_TipoDocumento, olTipoObligacion As l_TipoDocumento, leTipoObligacion As List(Of e_TipoDocumento)
    Private oeMovCajaBanco As e_MovimientoCajaBanco, olMovCajaBanco As l_MovimientoCajaBanco, leMovCajaBanco As List(Of e_MovimientoCajaBanco)
    Private FechaBusqueda As Date = #1/1/1901#, NroMes As Integer = 0

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(Activo As Boolean)
        Try
            oeObligacionFin = New e_ObligacionFin : leObligacionFin = New List(Of e_ObligacionFin)
            oeObligacionFin.TipoOperacion = String.Empty : oeObligacionFin.Activo = True
            oeObligacionFin.Banco = cboBanco.Value
            oeObligacionFin.IdTipoObligacion = cboTipoObligacion.Value
            oeObligacionFin.Ejercicio = numEjercicio.Value
            oeObligacionFin.Mes = NroMes
            oeObligacionFin.IndPeriodoGracia = 0
            leObligacionFin = olObligacionFin.Listar2(oeObligacionFin)
            mt_CargarObliFinan(leObligacionFin)
            mt_InicializarDatos()
            lePagoFinan = New List(Of e_AsientoMov_ObligacionFin)
            mt_CargarPagoFinan(lePagoFinan)
            btnExtornar.Enabled = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If griObligacionFin.Rows.Count > 0 Then
                Exportar_Excel(griObligacionFin, "Obligaciones Financieras")
            Else
                Throw New Exception("No hay Registros para Exportar")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ControlObligacion_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
    End Sub

    Private Sub frm_ControlObligacion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ControlObligacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
            mt_InicializarLogicas()
            mt_CargarCombos()
            mt_CargarIconos()
            numEjercicio.Value = Date.Now.Year : numEjercicio.Focus()
            mt_CargarObliFinan(New List(Of e_ObligacionFin))
            mt_CargarPagoFinan(New List(Of e_AsientoMov_ObligacionFin))
            btnExtornar.Enabled = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub numEjercicio_ValueChanged(sender As Object, e As EventArgs) Handles numEjercicio.ValueChanged
        Try
            oePeriodo = New e_Periodo : lePeriodoAux = New List(Of e_Periodo)
            oePeriodo.Id = String.Empty : oePeriodo.Codigo = "[--TODOS--]"
            lePeriodoAux.Add(oePeriodo)
            lePeriodoAux.AddRange(lePeriodo.Where(Function(it) it.Ejercicio = numEjercicio.Value).ToList)
            LlenarCombo(cboPeriodo, "Codigo", lePeriodoAux, 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboPeriodo_ValueChanged(sender As Object, e As EventArgs) Handles cboPeriodo.ValueChanged
        Try
            If cboPeriodo.SelectedIndex > 0 Then
                oePeriodo = cboPeriodo.Items(cboPeriodo.SelectedIndex).ListObject
                FechaBusqueda = Date.Parse("01/" & oePeriodo.Mes.ToString & "/" & oePeriodo.Ejercicio.ToString)
                NroMes = oePeriodo.Mes
            Else
                FechaBusqueda = #1/1/1901# : NroMes = 0
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griObligacionFin_DoubleClick(sender As Object, e As EventArgs) Handles griObligacionFin.DoubleClick
        Try
            If griObligacionFin.Selected.Rows.Count > 0 Then
                ' Obtener Obligacion Financiera Seleccionada
                oeObligacionFin = New e_ObligacionFin
                oeObligacionFin = griObligacionFin.ActiveRow.ListObject
                ' Cargar Datos de la Obligacion Financiera
                txtTipoObligacion.Text = oeObligacionFin.IdTipoObligacion
                txtBanco.Text = oeObligacionFin.Banco
                txtContrato.Text = FormatoDocumento(oeObligacionFin.NroContrato.Trim, 15) & "-" & FormatoDocumento(oeObligacionFin.NroVencimiento.Trim, 5)
                fecVencimiento.Value = oeObligacionFin.FechaVencimiento
                txtMoneda.Text = oeObligacionFin.IdMoneda
                decTotal.Value = oeObligacionFin.Total
                decSaldo.Value = oeObligacionFin.Saldo
                ' Obtener Pagos de la Obligacion Financiera
                oePagoFinan = New e_AsientoMov_ObligacionFin : lePagoFinan = New List(Of e_AsientoMov_ObligacionFin)
                oePagoFinan.TipoOperacion = "P" : oePagoFinan.IdObligacionFinanciera = oeObligacionFin.Id
                lePagoFinan = olPagoFinan.Listar(oePagoFinan)
                If lePagoFinan.Count > 0 Then
                    mt_CargarPagoFinan(lePagoFinan)
                    btnExtornar.Enabled = True
                Else
                    lePagoFinan = New List(Of e_AsientoMov_ObligacionFin)
                    mt_CargarPagoFinan(lePagoFinan)
                    btnExtornar.Enabled = False
                    Throw New Exception("No se encontraron Pagos en esta Obligacion Financiera")
                End If
            Else
                Throw New Exception("Seleccione un Registro!!")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnExtornar_Click(sender As Object, e As EventArgs) Handles btnExtornar.Click
        Try
           
            If griMovimientoPago.Selected.Rows.Count > 0 Then
                oePagoFinan = griMovimientoPago.ActiveRow.ListObject
                ' Obtener Movimiento Caja Banco del Pago de Obligacion
                oeMovCajaBanco = New e_MovimientoCajaBanco : leMovCajaBanco = New List(Of e_MovimientoCajaBanco)
                oeMovCajaBanco.TipoOperacion = "O" : oeMovCajaBanco.IdAsientoMovimiento = oePagoFinan.IdObligacionPago
                leMovCajaBanco = olMovCajaBanco.Listar(oeMovCajaBanco)
                ' Verificar si esta Conciliado
                Dim _leMCBAux = leMovCajaBanco.Where(Function(it) it.IdPeriodoConcilia.Trim <> "" And it.Activo).ToList
                If _leMCBAux.Count > 0 Then Throw New Exception("No se puede extornar este pago. Necesita Desconsiliar el Pago")

                If MessageBox.Show("¿Desea Extornar el Pago?", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim oeAsiMovObl As New e_AsientoMov_ObligacionFin
                    oeAsiMovObl.TipoOperacion = "X"
                    oeAsiMovObl.Id = oePagoFinan.Id
                    oeAsiMovObl.IdObligacionPago = oePagoFinan.IdObligacionPago
                    oeAsiMovObl.IdObligacionFinanciera = oePagoFinan.IdObligacionFinanciera
                    oeAsiMovObl.IdAsientoMovimiento = oePagoFinan.IdAsientoMovimiento
                    oeAsiMovObl.UsuarioCreacion = gUsuarioSGI.Id

                    Dim lst_ObligFin_MovDoc As New List(Of e_ObligacionDocumento)
                    Dim oe_DocRetDet As e_DocumentoRetencionDetalle
                    Dim ol_DocRetDet As l_DocumentoRetencionDetalle
                    Dim lst_DocRetDet As New List(Of e_DocumentoRetencionDetalle)
                    Dim oe_ObligFin_MovDoc As New e_ObligacionDocumento
                    Dim ol_ObligFin_MovDoc As New l_ObligacionDocumento
                    Dim oe_ObligFin As e_ObligacionFin
                    Dim ol_ObligFin As l_ObligacionFinanciera
                    Dim retencion_orig As Double = 0.0
                    If txtTipoObligacion.Text.Trim = "LETRA" Then
                        oe_ObligFin_MovDoc.IdObligacionFinanciera = oeAsiMovObl.IdObligacionFinanciera
                        lst_ObligFin_MovDoc = ol_ObligFin_MovDoc.Listar(oe_ObligFin_MovDoc).ToList
                        If lst_ObligFin_MovDoc.Where(Function(g) g.RetencionME > 0.0).Count > 0 Then
                            For Each fila In lst_ObligFin_MovDoc
                                oe_ObligFin = New e_ObligacionFin
                                oe_ObligFin.Id = fila.IdObligacionFinanciera
                                oe_ObligFin.TipoOperacion = ""
                                ol_ObligFin = New l_ObligacionFinanciera
                                oe_ObligFin = ol_ObligFin.Listar2(oe_ObligFin).Item(0)
                                oe_DocRetDet = New e_DocumentoRetencionDetalle
                                With oe_DocRetDet
                                    .IdMovimientoDocumento = fila.IdMovimientoDocumento
                                    .TipoOperacion = ""
                                    .Activo = 1
                                    .NroVoucher = "LETRA " & oe_ObligFin.NroVencimiento
                                    .NumeroPago = oe_ObligFin.NroVencimiento
                                    .FechaPago = oe_ObligFin.FechaVencimiento
                                    retencion_orig = IIf(oe_ObligFin.IdMoneda = "DOLARES", fila.RetencionME, fila.RetencionMN)
                                    oe_DocRetDet.RetencionOrigen = retencion_orig
                                    ol_DocRetDet = New l_DocumentoRetencionDetalle
                                    Dim lst_aux As New List(Of e_DocumentoRetencionDetalle)
                                    lst_aux = ol_DocRetDet.Listar(oe_DocRetDet)
                                    .UsuarioModifica = gUsuarioSGI.IdTrabajador
                                    .TipoOperacion = "E"
                                    If lst_aux.Count > 0 Then
                                        If (lst_aux.Item(0).IdDocumentoRetencion).Trim Is String.Empty Then
                                            .Id = lst_aux.Item(0).Id
                                            .UsuarioModifica = gUsuarioSGI.IdTrabajador
                                            lst_DocRetDet.Add(oe_DocRetDet)
                                        Else
                                            Throw New Exception("La retención de la letra no se puede extornar porque ya se generó el pago.")
                                        End If
                                    End If
                                End With
                            Next
                        End If
                    End If
                    'Dim oe_ObligFin As New e_ObligacionFin
                    'oe_ObligFin.Id = oe_ObligFin_MovDoc.IdObligacionFinanciera
                    If olPagoFinan.Extornar(oeAsiMovObl, lst_DocRetDet) Then
                        mensajeEmergente.Confirmacion("Se extorno correctamente el pago", True)
                    Else
                        Throw New Exception("Ocurrio un error en el proceso")
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griObligacionFin_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griObligacionFin.BeforeRowsDeleted, griMovimientoPago.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

#End Region

#Region "Metodos"

    Private Sub mt_InicializarDatos()
        txtTipoObligacion.Text = String.Empty
        txtBanco.Text = String.Empty
        txtContrato.Text = String.Empty
        fecVencimiento.Value = Now.Date.Date
        txtMoneda.Text = String.Empty
        decTotal.Value = 0
        decSaldo.Value = 0
    End Sub

    Private Sub mt_InicializarLogicas()
        Try
            olObligacionFin = New l_ObligacionFinanciera
            olPagoFinan = New l_AsientoMov_ObligacionFin
            olPeriodo = New l_Periodo
            olBanco = New l_Proveedor
            olTipoObligacion = New l_TipoDocumento
            olMovCajaBanco = New l_MovimientoCajaBanco
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarCombos()
        Try
            'Cargar Periodo
            oePeriodo = New e_Periodo : lePeriodo = New List(Of e_Periodo)
            oePeriodo.TipoOperacion = String.Empty : oePeriodo.Activo = True
            lePeriodo = olPeriodo.Listar(oePeriodo)
            'Cargar Banco
            oeBanco = New e_Proveedor : leBanco = New List(Of e_Proveedor)
            oeBanco.Id = String.Empty : oeBanco.Nombre = "[--TODOS--]"
            leBanco.Add(oeBanco)
            oeBanco = New e_Proveedor
            oeBanco.TipoOperacion = "4" : oeBanco.Activo = True
            leBanco.AddRange(olBanco.Listar(oeBanco).OrderBy(Function(it) it.Nombre).ToList)
            LlenarCombo(cboBanco, "Nombre", leBanco, 0)
            'Cargar Tipo Obligacion
            oeTipoObligacion = New e_TipoDocumento : leTipoObligacion = New List(Of e_TipoDocumento)
            oeTipoObligacion.Id = String.Empty : oeTipoObligacion.Nombre = "[--TODOS--]"
            leTipoObligacion.Add(oeTipoObligacion)
            oeTipoObligacion = New e_TipoDocumento
            oeTipoObligacion.TipoOperacion = "I" : oeTipoObligacion.Activo = True
            leTipoObligacion.AddRange(olTipoObligacion.Listar(oeTipoObligacion).OrderBy(Function(it) it.Nombre).ToList)
            LlenarCombo(cboTipoObligacion, "Nombre", leTipoObligacion, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarObliFinan(leObliFin As List(Of e_ObligacionFin))
        Try
            With griObligacionFin
                .ResetDisplayLayout()
                .DataSource = leObliFin
                .Text = "OBLIGACIONES FINANCIERAS DEL EJERCICIO: " & cboPeriodo.Text
                ConfiguraGrilla(griObligacionFin, "Tahoma", True, UIElementBorderStyle.Default)
                OcultarColumna2(griObligacionFin, False, "IdTipoObligacion", "Banco", "NroContrato", "FechaVencimiento", "NroVencimiento", "IdMoneda", _
                                "MontoCapital", "MontoInteres", "Comision", "IGV", "Portes", "Gastos", "Total", "Saldo")
                FormatoColumna(griObligacionFin, "#,##0.00", ColumnStyle.Double, HAlign.Right, "MontoInteres", "Comision", "Gastos", "Portes", _
                               "IGV", "Saldo", "MontoCapital", "Total")
                .DisplayLayout.Bands(0).Columns("FechaVencimiento").Header.Caption = "Fec. Venc."
                .DisplayLayout.Bands(0).Columns("NroVencimiento").Header.Caption = "Nro Cuota"
                .DisplayLayout.Bands(0).Columns("IdTipoObligacion").Header.Caption = "Tipo Oblig."
                .DisplayLayout.Bands(0).Columns("IdMoneda").Header.Caption = "Moneda"
                .DisplayLayout.Bands(0).Columns("MontoCapital").Header.Caption = "Capital"
                .DisplayLayout.Bands(0).Columns("MontoInteres").Header.Caption = "Interes"
                .DisplayLayout.Bands(0).Columns("FechaVencimiento").Width = 70
                .DisplayLayout.Bands(0).Columns("NroVencimiento").Width = 60
                .DisplayLayout.Bands(0).Columns("IdMoneda").Width = 70
                .DisplayLayout.Bands(0).Columns("IdTipoObligacion").Width = 130
                .DisplayLayout.Bands(0).Columns("Banco").Width = 180
                CalcularTotales(griObligacionFin, "Total", "Saldo")
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarPagoFinan(lePagoFin As List(Of e_AsientoMov_ObligacionFin))
        Try
            With griMovimientoPago
                .ResetDisplayLayout()
                .DataSource = lePagoFin
                .Text = "PAGOS DEL CONTRATO FINANCIERO: " & txtContrato.Text
                ConfiguraGrilla(griMovimientoPago, "Tahoma", True, UIElementBorderStyle.Default)
                OcultarColumna2(griMovimientoPago, False, "Periodo", "TipoAsiento", "NroAsiento", "FechaPago", "FlujoCaja", "MedioPago", "Banco", _
                                "NroCuenta", "NroBoucher", "TipoCambio", "TotalMN", "TotalME", "Glosa")
                .DisplayLayout.Bands(0).Columns("FechaPago").Header.Caption = "Fecha"
                .DisplayLayout.Bands(0).Columns("TipoCambio").Header.Caption = "T.C."
                .DisplayLayout.Bands(0).Columns("FechaPago").Width = 70
                .DisplayLayout.Bands(0).Columns("Periodo").Width = 60
                .DisplayLayout.Bands(0).Columns("NroAsiento").Width = 80
                .DisplayLayout.Bands(0).Columns("TipoCambio").Width = 40
                .DisplayLayout.Bands(0).Columns("TipoAsiento").Width = 70
                .DisplayLayout.Bands(0).Columns("FlujoCaja").Width = 110
                .DisplayLayout.Bands(0).Columns("MedioPago").Width = 125
                .DisplayLayout.Bands(0).Columns("Banco").Width = 135
                .DisplayLayout.Bands(0).Columns("NroCuenta").Width = 130
                .DisplayLayout.Bands(0).Columns("Glosa").Width = 150
                FormatoColumna(griMovimientoPago, "#,##0.00", ColumnStyle.Double, HAlign.Right, "TotalMN", "TotalME", "TipoCambio")
                CalcularTotales(griMovimientoPago, "TotalMN", "TotalME")
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarIconos()
        Try
            For Each Item In gLstIconos
                If Item.Nombre = "Extornar" Then btnExtornar.Appearance.Image = Item.Icono : Exit For
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class
