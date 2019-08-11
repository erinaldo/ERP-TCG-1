Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win.UltraWinGrid

Public Class frm_ExtornoIngreso
    Inherits frm_MenuPadre

    Private Shared Instancia As frm_ExtornoIngreso = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Instancia = New frm_ExtornoIngreso
            Operacion = "Inicializa"
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#Region "Variables"

    Dim IdRegistroInventario As String = ""

    Private oeOrden As e_Orden
    Private oeRegConsumo As e_RegistroConsumoCombustible
    Private loRegConsumo As List(Of e_RegistroConsumoCombustible)
    Private olRegConsumo As l_RegistroConsumoCombustible

    Private oeRegInv As e_RegistroInventario
    Private olRegInv As l_RegistroInventario
    Private loRegInv As List(Of e_RegistroInventario)

    'Private oeRegistroInv As e_RegistroInventario
    Private dsRegistroInv As Data.DataSet

    Private oeAsientoModelo As e_AsientoModelo
    Private olAsientoModelo As l_AsientoModelo
    Private loAsientoModelo, loAsiMod As List(Of e_AsientoModelo)
    Private oeReferencia As e_AsientoModelo_Referencia
    Private olReferencia As l_AsientoModelo_Referencia
    Private loReferencia As List(Of e_AsientoModelo_Referencia)

    Dim oeDetalleLE As e_DetalleLibroElectronico
    Dim leDetalleLE As List(Of e_DetalleLibroElectronico)
    Dim olDetalleLE As l_DetalleLibroElectronico

    Private dtReferencia As New DataTable
#End Region

#Region "Metodos"

    Sub New()
        InitializeComponent()
    End Sub

    Public Sub Metodos(IdRegistro As String)
        IdRegistroInventario = IdRegistro
    End Sub

#End Region

    Private Sub frm_ExtornoIngreso_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ControlBoton()
    End Sub

    Private Sub frm_ExtornoIngreso_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Instancia = Nothing
    End Sub

    Private Sub frm_ExtornoIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            olRegConsumo = New l_RegistroConsumoCombustible
            olRegInv = New l_RegistroInventario
            olAsientoModelo = New l_AsientoModelo
            olReferencia = New l_AsientoModelo_Referencia
            olDetalleLE = New l_DetalleLibroElectronico
            btnExtornar.Enabled = True
            AsientoContable()
            ComboPeriodo()
            griLibroValorizado.DataSource = New List(Of e_DetalleLibroElectronico)
            ConfigurarGrillaValorizado()
            ConfigurarGrillaUnidades()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub
    Private Sub btnExtornar_Click(sender As Object, e As EventArgs) Handles btnExtornar.Click
        Try
            Select Case UltraTabControl1.SelectedTab.Index
                Case 0
                    ExtornarAsiento()
                Case 1
                    ListarValorizado()
                Case 2
                    ListarFisicas()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub ComboPeriodo()
        Try
            Dim oePeriodo As New e_Periodo
            Dim olPeriodo As New l_Periodo
            Dim lePeriodo As New List(Of e_Periodo)
            lePeriodo.AddRange(ObtenerPeriodoActivo(dtpFechaEjercicio.Value.Year))
            With cboMes
                .DisplayMember = "Mes"
                .ValueMember = "Id"
                .DataSource = lePeriodo
                If .Items.Count > 0 Then
                    .SelectedIndex = Date.Today.Month - 1
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ListarValorizado()
        oeDetalleLE = New e_DetalleLibroElectronico
        leDetalleLE = New List(Of e_DetalleLibroElectronico)
        oeDetalleLE.IdPeriodo = cboMes.Value
        oeDetalleLE._Ejercicio = dtpFechaEjercicio.Value.Year
        oeDetalleLE._Mes = FormatoDocumento(cboMes.Text, 2)
        oeDetalleLE.Año = dtpFechaEjercicio.Value.Year
        oeDetalleLE.TipoOperacion = "L"
        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
        ConfigurarListaValorizado(leDetalleLE)
        griLibroValorizado.DataSource = leDetalleLE
    End Sub

    Private Sub ListarFisicas()
        oeDetalleLE = New e_DetalleLibroElectronico
        leDetalleLE = New List(Of e_DetalleLibroElectronico)
        oeDetalleLE.IdPeriodo = cboMes.Value
        oeDetalleLE._Ejercicio = dtpFechaEjercicio.Value.Year
        oeDetalleLE._Mes = FormatoDocumento(cboMes.Text, 2)
        oeDetalleLE.Año = dtpFechaEjercicio.Value.Year
        oeDetalleLE.TipoOperacion = "U"
        leDetalleLE = olDetalleLE.Listar(oeDetalleLE)
        ConfigurarListaUnidades(leDetalleLE)
        griLibroUnidades.DataSource = leDetalleLE
    End Sub

    Private Sub ConfigurarGrillaValorizado()
        Try
            With griLibroValorizado
                .DisplayLayout.Bands(0).Columns("Id").Hidden = 1
                .DisplayLayout.Bands(0).Columns("IdLibroElectronico").Hidden = 1
                .DisplayLayout.Bands(0).Columns("IdMovimientoDocumento").Hidden = 1
                .DisplayLayout.Bands(0).Columns("FechaVencimiento").Hidden = 1
                .DisplayLayout.Bands(0).Columns("Total").Hidden = 1
                .DisplayLayout.Bands(0).Columns("TipoCambio").Hidden = 1
                .DisplayLayout.Bands(0).Columns("FechaEmisionAso").Hidden = 1
                .DisplayLayout.Bands(0).Columns("TipoDocumentoAso").Hidden = 1
                .DisplayLayout.Bands(0).Columns("SerieAso").Hidden = 1
                .DisplayLayout.Bands(0).Columns("NumeroDocAso").Hidden = 1
                .DisplayLayout.Bands(0).Columns("NumeroDocAso2").Hidden = 1
                .DisplayLayout.Bands(0).Columns("FechaEmisionDetraccion").Hidden = 1
                .DisplayLayout.Bands(0).Columns("Retencion").Hidden = 1
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = 1
                .DisplayLayout.Bands(0).Columns("CodigoMoneda").Hidden = 1
                .DisplayLayout.Bands(0).Columns("ClasificacionBienServicio").Hidden = 1
                .DisplayLayout.Bands(0).Columns("DsctoBaseImp").Hidden = 1
                .DisplayLayout.Bands(0).Columns("DsctoIGV").Hidden = 1
                .DisplayLayout.Bands(0).Columns("FechaVencimiento").Hidden = 1
                .DisplayLayout.Bands(0).Columns("AnioEmisionDUA").Hidden = 1
                .DisplayLayout.Bands(0).Columns("NumeroDoc2").Hidden = 1
                .DisplayLayout.Bands(0).Columns("TipoDocIdentidad").Hidden = 1
                .DisplayLayout.Bands(0).Columns("NumeroDocIdentidad").Hidden = 1
                .DisplayLayout.Bands(0).Columns("Denominacion").Hidden = 1
                .DisplayLayout.Bands(0).Columns("ErrorTipo1").Hidden = 1
                .DisplayLayout.Bands(0).Columns("NroCorrelativoVenta").Hidden = 1
                .DisplayLayout.Bands(0).Columns("NroCorrelativoCompra").Hidden = 1
                .DisplayLayout.Bands(0).Columns("NroCorrelativoConsignacion").Hidden = 1
                .DisplayLayout.Bands(0).Columns("CodigoDuaDsiFob").Hidden = 1

                .DisplayLayout.Bands(0).Columns("Periodo").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("CodigoUnicoOperacion").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("NumeroCorrelativo").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("ErrorTipo2").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("IdentificacionContratoProy").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("CodTipoRenta").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("CodConvenio").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("CodPais").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("FechaEmision").Header.VisiblePosition = 8
                .DisplayLayout.Bands(0).Columns("TipoDocumento").Header.VisiblePosition = 9
                .DisplayLayout.Bands(0).Columns("SerieDoc").Header.VisiblePosition = 10
                .DisplayLayout.Bands(0).Columns("NumeroDoc").Header.VisiblePosition = 11
                .DisplayLayout.Bands(0).Columns("ErrorTipo3").Header.VisiblePosition = 12
                .DisplayLayout.Bands(0).Columns("ErrorTipo4").Header.VisiblePosition = 13
                .DisplayLayout.Bands(0).Columns("NroConstanciaDetraccion").Header.VisiblePosition = 14
                .DisplayLayout.Bands(0).Columns("Indicador").Header.VisiblePosition = 15
                .DisplayLayout.Bands(0).Columns("SubTotal1").Header.VisiblePosition = 16
                .DisplayLayout.Bands(0).Columns("Igv1").Header.VisiblePosition = 17
                .DisplayLayout.Bands(0).Columns("SubTotal2").Header.VisiblePosition = 18
                .DisplayLayout.Bands(0).Columns("Igv2").Header.VisiblePosition = 19
                .DisplayLayout.Bands(0).Columns("SubTotal3").Header.VisiblePosition = 20
                .DisplayLayout.Bands(0).Columns("Igv3").Header.VisiblePosition = 21
                .DisplayLayout.Bands(0).Columns("NoGravada").Header.VisiblePosition = 22
                .DisplayLayout.Bands(0).Columns("Isc").Header.VisiblePosition = 23
                .DisplayLayout.Bands(0).Columns("OtrosTributos").Header.VisiblePosition = 24
                .DisplayLayout.Bands(0).Columns("IndCancelaComprobPago").Header.VisiblePosition = 25

                .DisplayLayout.Bands(0).Columns("Periodo").Width = 70
                .DisplayLayout.Bands(0).Columns("CodigoUnicoOperacion").Width = 100
                .DisplayLayout.Bands(0).Columns("NumeroCorrelativo").Width = 80
                .DisplayLayout.Bands(0).Columns("IdentificacionContratoProy").Width = 70
                .DisplayLayout.Bands(0).Columns("CodTipoRenta").Width = 70
                .DisplayLayout.Bands(0).Columns("CodConvenio").Width = 70
                .DisplayLayout.Bands(0).Columns("CodPais").Width = 70
                .DisplayLayout.Bands(0).Columns("FechaEmision").Width = 80
                .DisplayLayout.Bands(0).Columns("TipoDocumento").Width = 60
                .DisplayLayout.Bands(0).Columns("SerieDoc").Width = 60
                .DisplayLayout.Bands(0).Columns("NumeroDoc").Width = 80
                .DisplayLayout.Bands(0).Columns("ErrorTipo3").Width = 60
                .DisplayLayout.Bands(0).Columns("ErrorTipo4").Width = 120
                .DisplayLayout.Bands(0).Columns("NroConstanciaDetraccion").Width = 70
                .DisplayLayout.Bands(0).Columns("Indicador").Width = 70
                .DisplayLayout.Bands(0).Columns("SubTotal1").Width = 70
                .DisplayLayout.Bands(0).Columns("Igv1").Width = 70
                .DisplayLayout.Bands(0).Columns("SubTotal2").Width = 70
                .DisplayLayout.Bands(0).Columns("Igv2").Width = 70
                .DisplayLayout.Bands(0).Columns("SubTotal3").Width = 70
                .DisplayLayout.Bands(0).Columns("Igv3").Width = 70
                .DisplayLayout.Bands(0).Columns("NoGravada").Width = 70
                .DisplayLayout.Bands(0).Columns("Isc").Width = 70
                .DisplayLayout.Bands(0).Columns("OtrosTributos").Width = 70
                .DisplayLayout.Bands(0).Columns("IndCancelaComprobPago").Width = 70

                .DisplayLayout.Bands(0).Columns("CodigoUnicoOperacion").Header.Caption = "CUO"
                .DisplayLayout.Bands(0).Columns("NumeroCorrelativo").Header.Caption = "Correlativo"
                .DisplayLayout.Bands(0).Columns("ErrorTipo2").Header.Caption = "Establecimiento"
                .DisplayLayout.Bands(0).Columns("IdentificacionContratoProy").Header.Caption = "Catalogo"
                .DisplayLayout.Bands(0).Columns("CodTipoRenta").Header.Caption = "Tipo Exist."
                .DisplayLayout.Bands(0).Columns("CodConvenio").Header.Caption = "Cod. Mat."
                .DisplayLayout.Bands(0).Columns("CodPais").Header.Caption = "OSCE"
                .DisplayLayout.Bands(0).Columns("FechaEmision").Header.Caption = "F. Emision"
                .DisplayLayout.Bands(0).Columns("TipoDocumento").Header.Caption = "Tipo Doc."
                .DisplayLayout.Bands(0).Columns("SerieDoc").Header.Caption = "Serie"
                .DisplayLayout.Bands(0).Columns("NumeroDoc").Header.Caption = "Numero"
                .DisplayLayout.Bands(0).Columns("ErrorTipo3").Header.Caption = "Tipo Ope."
                .DisplayLayout.Bands(0).Columns("ErrorTipo4").Header.Caption = "Descripcion"
                .DisplayLayout.Bands(0).Columns("NroConstanciaDetraccion").Header.Caption = "U. Medida"
                .DisplayLayout.Bands(0).Columns("Indicador").Header.Caption = "Valuacion"
                .DisplayLayout.Bands(0).Columns("SubTotal1").Header.Caption = "Cant. I"
                .DisplayLayout.Bands(0).Columns("Igv1").Header.Caption = "Costo I"
                .DisplayLayout.Bands(0).Columns("SubTotal2").Header.Caption = "Total I"
                .DisplayLayout.Bands(0).Columns("Igv2").Header.Caption = "Cant. S"
                .DisplayLayout.Bands(0).Columns("SubTotal3").Header.Caption = "Costo S"
                .DisplayLayout.Bands(0).Columns("Igv3").Header.Caption = "Total S"
                .DisplayLayout.Bands(0).Columns("NoGravada").Header.Caption = "Saldo"
                .DisplayLayout.Bands(0).Columns("Isc").Header.Caption = "CostoSaldo"
                .DisplayLayout.Bands(0).Columns("OtrosTributos").Header.Caption = "SaldoTotal"
                .DisplayLayout.Bands(0).Columns("IndCancelaComprobPago").Header.Caption = "Est. Ope."

                .DisplayLayout.Bands(0).Columns("SubTotal1").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("Igv1").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("SubTotal2").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("Igv2").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("SubTotal3").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("Igv3").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("NoGravada").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("Isc").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("OtrosTributos").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right

                .DisplayLayout.Bands(0).Columns("SubTotal1").MaskInput = "{double:-9.2}"
                .DisplayLayout.Bands(0).Columns("Igv1").MaskInput = "{double:-9.2}"
                .DisplayLayout.Bands(0).Columns("SubTotal2").MaskInput = "{double:-9.2}"
                .DisplayLayout.Bands(0).Columns("Igv2").MaskInput = "{double:-9.2}"
                .DisplayLayout.Bands(0).Columns("SubTotal3").MaskInput = "{double:-9.2}"
                .DisplayLayout.Bands(0).Columns("Igv3").MaskInput = "{double:-9.2}"
                .DisplayLayout.Bands(0).Columns("NoGravada").MaskInput = "{double:-9.2}"
                .DisplayLayout.Bands(0).Columns("Isc").MaskInput = "{double:-9.2}"
                .DisplayLayout.Bands(0).Columns("OtrosTributos").MaskInput = "{double:-9.2}"
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ConfigurarGrillaUnidades()
        Try
            With griLibroUnidades
                .DisplayLayout.Bands(0).Columns("Id").Hidden = 1
                .DisplayLayout.Bands(0).Columns("IdLibroElectronico").Hidden = 1
                .DisplayLayout.Bands(0).Columns("IdMovimientoDocumento").Hidden = 1
                .DisplayLayout.Bands(0).Columns("FechaVencimiento").Hidden = 1
                .DisplayLayout.Bands(0).Columns("Total").Hidden = 1
                .DisplayLayout.Bands(0).Columns("TipoCambio").Hidden = 1
                .DisplayLayout.Bands(0).Columns("FechaEmisionAso").Hidden = 1
                .DisplayLayout.Bands(0).Columns("TipoDocumentoAso").Hidden = 1
                .DisplayLayout.Bands(0).Columns("SerieAso").Hidden = 1
                .DisplayLayout.Bands(0).Columns("NumeroDocAso").Hidden = 1
                .DisplayLayout.Bands(0).Columns("NumeroDocAso2").Hidden = 1
                .DisplayLayout.Bands(0).Columns("FechaEmisionDetraccion").Hidden = 1
                .DisplayLayout.Bands(0).Columns("Retencion").Hidden = 1
                .DisplayLayout.Bands(0).Columns("Indicador").Hidden = 1
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = 1
                .DisplayLayout.Bands(0).Columns("CodigoMoneda").Hidden = 1
                .DisplayLayout.Bands(0).Columns("ClasificacionBienServicio").Hidden = 1
                .DisplayLayout.Bands(0).Columns("DsctoBaseImp").Hidden = 1
                .DisplayLayout.Bands(0).Columns("DsctoIGV").Hidden = 1
                .DisplayLayout.Bands(0).Columns("FechaVencimiento").Hidden = 1
                .DisplayLayout.Bands(0).Columns("AnioEmisionDUA").Hidden = 1
                .DisplayLayout.Bands(0).Columns("NumeroDoc2").Hidden = 1
                .DisplayLayout.Bands(0).Columns("TipoDocIdentidad").Hidden = 1
                .DisplayLayout.Bands(0).Columns("NumeroDocIdentidad").Hidden = 1
                .DisplayLayout.Bands(0).Columns("Denominacion").Hidden = 1
                .DisplayLayout.Bands(0).Columns("ErrorTipo1").Hidden = 1
                .DisplayLayout.Bands(0).Columns("NroCorrelativoVenta").Hidden = 1
                .DisplayLayout.Bands(0).Columns("NroCorrelativoCompra").Hidden = 1
                .DisplayLayout.Bands(0).Columns("NroCorrelativoConsignacion").Hidden = 1
                .DisplayLayout.Bands(0).Columns("CodigoDuaDsiFob").Hidden = 1
                .DisplayLayout.Bands(0).Columns("Indicador").Hidden = 1
                .DisplayLayout.Bands(0).Columns("Igv1").Hidden = 1
                .DisplayLayout.Bands(0).Columns("Igv2").Hidden = 1
                .DisplayLayout.Bands(0).Columns("SubTotal3").Hidden = 1
                .DisplayLayout.Bands(0).Columns("Igv3").Hidden = 1
                .DisplayLayout.Bands(0).Columns("NoGravada").Hidden = 1
                .DisplayLayout.Bands(0).Columns("Isc").Hidden = 1
                .DisplayLayout.Bands(0).Columns("OtrosTributos").Hidden = 1

                .DisplayLayout.Bands(0).Columns("Periodo").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("CodigoUnicoOperacion").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("NumeroCorrelativo").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("ErrorTipo2").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("IdentificacionContratoProy").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("CodTipoRenta").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("CodConvenio").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("CodPais").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("FechaEmision").Header.VisiblePosition = 8
                .DisplayLayout.Bands(0).Columns("TipoDocumento").Header.VisiblePosition = 9
                .DisplayLayout.Bands(0).Columns("SerieDoc").Header.VisiblePosition = 10
                .DisplayLayout.Bands(0).Columns("NumeroDoc").Header.VisiblePosition = 11
                .DisplayLayout.Bands(0).Columns("ErrorTipo3").Header.VisiblePosition = 12
                .DisplayLayout.Bands(0).Columns("ErrorTipo4").Header.VisiblePosition = 13
                .DisplayLayout.Bands(0).Columns("NroConstanciaDetraccion").Header.VisiblePosition = 14
                .DisplayLayout.Bands(0).Columns("SubTotal1").Header.VisiblePosition = 15
                .DisplayLayout.Bands(0).Columns("SubTotal2").Header.VisiblePosition = 16
                .DisplayLayout.Bands(0).Columns("IndCancelaComprobPago").Header.VisiblePosition = 17

                .DisplayLayout.Bands(0).Columns("Periodo").Width = 70
                .DisplayLayout.Bands(0).Columns("CodigoUnicoOperacion").Width = 100
                .DisplayLayout.Bands(0).Columns("NumeroCorrelativo").Width = 80
                .DisplayLayout.Bands(0).Columns("IdentificacionContratoProy").Width = 70
                .DisplayLayout.Bands(0).Columns("CodTipoRenta").Width = 70
                .DisplayLayout.Bands(0).Columns("CodConvenio").Width = 70
                .DisplayLayout.Bands(0).Columns("CodPais").Width = 70
                .DisplayLayout.Bands(0).Columns("FechaEmision").Width = 80
                .DisplayLayout.Bands(0).Columns("TipoDocumento").Width = 60
                .DisplayLayout.Bands(0).Columns("SerieDoc").Width = 60
                .DisplayLayout.Bands(0).Columns("NumeroDoc").Width = 80
                .DisplayLayout.Bands(0).Columns("ErrorTipo3").Width = 60
                .DisplayLayout.Bands(0).Columns("ErrorTipo4").Width = 120
                .DisplayLayout.Bands(0).Columns("NroConstanciaDetraccion").Width = 70
                .DisplayLayout.Bands(0).Columns("Indicador").Width = 70
                .DisplayLayout.Bands(0).Columns("SubTotal1").Width = 70
                .DisplayLayout.Bands(0).Columns("Igv1").Width = 70
                .DisplayLayout.Bands(0).Columns("SubTotal2").Width = 70
                .DisplayLayout.Bands(0).Columns("Igv2").Width = 70
                .DisplayLayout.Bands(0).Columns("SubTotal3").Width = 70
                .DisplayLayout.Bands(0).Columns("Igv3").Width = 70
                .DisplayLayout.Bands(0).Columns("NoGravada").Width = 70
                .DisplayLayout.Bands(0).Columns("Isc").Width = 70
                .DisplayLayout.Bands(0).Columns("OtrosTributos").Width = 70
                .DisplayLayout.Bands(0).Columns("IndCancelaComprobPago").Width = 70

                .DisplayLayout.Bands(0).Columns("ErrorTipo2").Header.Caption = "Establecimiento"
                .DisplayLayout.Bands(0).Columns("IdentificacionContratoProy").Header.Caption = "Catalogo"
                .DisplayLayout.Bands(0).Columns("CodTipoRenta").Header.Caption = "Tipo Exist."
                .DisplayLayout.Bands(0).Columns("CodConvenio").Header.Caption = "Cod. Mat."
                .DisplayLayout.Bands(0).Columns("CodPais").Header.Caption = "OSCE"
                .DisplayLayout.Bands(0).Columns("FechaEmision").Header.Caption = "F. Emision"
                .DisplayLayout.Bands(0).Columns("TipoDocumento").Header.Caption = "Tipo Doc."
                .DisplayLayout.Bands(0).Columns("SerieDoc").Header.Caption = "Serie"
                .DisplayLayout.Bands(0).Columns("NumeroDoc").Header.Caption = "Numero"
                .DisplayLayout.Bands(0).Columns("ErrorTipo3").Header.Caption = "Tipo Ope."
                .DisplayLayout.Bands(0).Columns("ErrorTipo4").Header.Caption = "Descripcion"
                .DisplayLayout.Bands(0).Columns("NroConstanciaDetraccion").Header.Caption = "U. Medida"
                .DisplayLayout.Bands(0).Columns("SubTotal1").Header.Caption = "Ingreso"
                .DisplayLayout.Bands(0).Columns("SubTotal2").Header.Caption = "Salida"
                .DisplayLayout.Bands(0).Columns("IndCancelaComprobPago").Header.Caption = "Est. Ope."

                .DisplayLayout.Bands(0).Columns("SubTotal1").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("SubTotal2").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right

                .DisplayLayout.Bands(0).Columns("SubTotal1").MaskInput = "{double:-9.2}"
                .DisplayLayout.Bands(0).Columns("SubTotal2").MaskInput = "{double:-9.2}"
              
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ConfigurarListaValorizado(loValorizado As List(Of e_DetalleLibroElectronico))
        Try
            Dim CodMatAlm As String
            Dim PeriodoActual As String = oeDetalleLE._Ejercicio + oeDetalleLE._Mes
            Dim PeriodoLista As String
            Dim Cont As Integer = 0
            Dim IndMat As Boolean = False
            For Each oe As e_DetalleLibroElectronico In loValorizado
                IndMat = False
                CodMatAlm = ""
                oe.SubTotal2 = Math.Round(oe.SubTotal1, 2) * Math.Round(oe.IGV1, 2)
                PeriodoLista = Strings.Left(oe.Periodo, 6)
                If PeriodoLista <> PeriodoActual Then
                    CodMatAlm = oe.CodConvenio.Trim + oe.ErrorTipo2.Trim
                    If loValorizado.Where(Function(i) i.CodConvenio.Trim + oe.ErrorTipo2.Trim = CodMatAlm).Count > 1 Then
                        oe.IndCancelaComprobPago = 9
                    Else
                        oe.IndCancelaComprobPago = 8
                    End If
                End If
                If Cont > 0 Then
                    If oe.CodConvenio.Trim = loValorizado.Item(Cont - 1).CodConvenio.Trim Then IndMat = True
                    oe.NoGravada = IIf(IndMat, loValorizado.Item(Cont - 1).NoGravada + oe.SubTotal1 - oe.IGV2, oe.SubTotal1 - oe.IGV2)
                    If Not IndMat Then
                        oe.OtrosTributos = oe.SubTotal2
                        oe.ISC = IIf(oe.NoGravada <> 0, oe.OtrosTributos / oe.NoGravada, 0)
                    End If
                    If oe.IGV2 > 0 Then
                        oe.SubTotal3 = IIf(IndMat, loValorizado.Item(Cont - 1).ISC, 0)
                    Else
                        oe.SubTotal3 = 0
                    End If
                    oe.IGV3 = Math.Round(oe.IGV2, 2) * Math.Round(oe.SubTotal3, 2)
                    If IndMat Then
                        oe.OtrosTributos = IIf(oe.SubTotal2 > 0, loValorizado.Item(Cont - 1).OtrosTributos + oe.SubTotal2, loValorizado.Item(Cont - 1).OtrosTributos - oe.IGV3)
                        oe.ISC = IIf(oe.NoGravada <> 0, oe.OtrosTributos / oe.NoGravada, 0)
                    End If
                Else
                    oe.NoGravada = oe.SubTotal1
                    oe.ISC = oe.IGV1
                    oe.OtrosTributos = oe.SubTotal2
                End If
                Cont += 1
            Next
            For Each oe As e_DetalleLibroElectronico In loValorizado
                If Math.Round(oe.NoGravada, 2) = 0 Then
                    oe.ISC = 0
                    oe.OtrosTributos = 0
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ConfigurarListaUnidades(loValorizado As List(Of e_DetalleLibroElectronico))
        Try
            Dim CodMatAlm As String
            Dim PeriodoActual As String = oeDetalleLE._Ejercicio + oeDetalleLE._Mes
            Dim PeriodoLista As String
            For Each oe As e_DetalleLibroElectronico In loValorizado
                CodMatAlm = ""
                PeriodoLista = Strings.Left(oe.Periodo, 6)
                If PeriodoLista <> PeriodoActual Then
                    CodMatAlm = oe.CodConvenio.Trim + oe.ErrorTipo2.Trim
                    If loValorizado.Where(Function(i) i.CodConvenio.Trim + oe.ErrorTipo2.Trim = CodMatAlm).Count > 1 Then
                        oe.IndCancelaComprobPago = 9
                    Else
                        oe.IndCancelaComprobPago = 8
                    End If
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExtornarAsiento()
        Try
            oeRegInv = New e_RegistroInventario
            With oeRegInv
                .Fecha = Date.Parse("31/05/2016")
                .TipoOperacion = "J"
                .IdMaterial = "1CH000001990"
                .IdSubAlmacen = "1SI000000048"
                .FechaInicio = Date.Parse("01/05/2016")
            End With
            dsRegistroInv = New Data.DataSet
            dsRegistroInv = olRegInv.ListarStock(oeRegInv)
            grReg_Inv.DataSource = dsRegistroInv
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnGenerarAsientos_Click(sender As Object, e As EventArgs) Handles btnGenerarAsientos.Click
        Try
            GenerarAsientos()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub GenerarAsientos()
        Try
            ObtenerAsientoModelo("1CH01", 2016)
            AsientoConsumo()
            loRegConsumo = New List(Of e_RegistroConsumoCombustible)
            For Each fila As UltraGridRow In grReg_Inv.Rows
                oeRegConsumo = New e_RegistroConsumoCombustible
                With oeRegConsumo
                    .Id = fila.Cells("IdRegCombustible").Value
                    .FechaCreacion = fila.Cells("FechaCreacion").Value
                    .PlacaVeh = fila.Cells("Placa").Value
                    .NroVale = fila.Cells("NroVale").Value
                    .CantidadGalon = fila.Cells("Cantidad").Value
                    .PrecioUnitario = fila.Cells("ValorUnitario").Value
                    .UsuarioCreacion = fila.Cells("UsuarioCreacion").Value
                    .IdVehiculo = fila.Cells("IdVehiculo").Value
                End With
                loRegConsumo.Add(oeRegConsumo)
            Next
            If olRegConsumo.AsientoConsumoDieselMasivo(loRegConsumo, loAsiMod, oeOrden) Then
                MsgBox("Asientos Generados Correctamente", MsgBoxStyle.OkOnly, Me.Text)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AsientoContable()
        AsientoModelo()
        dtReferencia = New DataTable
        dtReferencia = GeneraDTRef(loReferencia)
    End Sub

    Private Sub AsientoModelo()
        oeAsientoModelo = New e_AsientoModelo
        loAsientoModelo = New List(Of e_AsientoModelo)
        oeAsientoModelo.TipoOperacion = "A" : oeAsientoModelo.Activo = True : oeAsientoModelo.Nombre = "1PY000000002"
        loAsientoModelo = olAsientoModelo.Listar(oeAsientoModelo)

        oeReferencia = New e_AsientoModelo_Referencia
        loReferencia = New List(Of e_AsientoModelo_Referencia)
        oeReferencia.TipoOperacion = "N" : oeReferencia.Activo = True : oeReferencia.IdReferencia = "1PY000000002"
        loReferencia = olReferencia.Listar(oeReferencia)
    End Sub

    Private Sub ObtenerAsientoModelo(IdMoneda As String, Ejercicio As Integer)
        Try
            loAsiMod = New List(Of e_AsientoModelo)
            Dim dtAux = New Data.DataTable
            Dim _rwAux() As Data.DataRow
            Dim cadSQL As String = String.Empty
            cadSQL = "TipoRef1 = 4 AND IdRef1 = '" & IdMoneda & "'"
            _rwAux = dtReferencia.Select(cadSQL, "")
            If _rwAux.Count = 0 Then Throw New Exception("Error en el Modelo de Asiento Contable. Verificar")
            dtAux = _rwAux.CopyToDataTable
            oeAsientoModelo = New e_AsientoModelo
            oeAsientoModelo.TipoOperacion = "" : oeAsientoModelo.Activo = True
            oeAsientoModelo.Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString
            oeAsientoModelo.Ejercicio = Ejercicio
            oeAsientoModelo = olAsientoModelo.Obtener(oeAsientoModelo)
            loAsiMod.Add(oeAsientoModelo)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub AsientoConsumo()
        Try
            oeOrden = New e_Orden
            Dim oePeriodo As New e_Periodo
            Dim olPeriodo As New l_Periodo
            Dim fechaactual As Date = ObtenerFechaServidor.Date
            oePeriodo.Ejercicio = dtpFechaEjercicio.Value.Year
            oePeriodo.Mes = CInt(cboMes.Text)
            oePeriodo = olPeriodo.Obtener(oePeriodo)
            If oePeriodo.Id = "" Then Throw New Exception("No Existe el Periodo Contable de Este Periodo. Comunicar a Contabilidad")
            oeOrden.IndAsiento = True
            oeOrden.loAsientoModelo = New List(Of e_AsientoModelo)
            oeOrden.lstInventario = New List(Of e_Inventario)
            oeOrden.IdPeriodo = oePeriodo.Id
            oeOrden.TipoCambio = TipoCambio(fechaactual, True)(0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub dtpFechaEjercicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaEjercicio.ValueChanged
        ComboPeriodo()
    End Sub

    Private Sub UltraButton1_Click(sender As Object, e As EventArgs) Handles UltraButton1.Click
        ConfigurarGrillaValorizado()
    End Sub

End Class