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

Public Class frm_GastosFinancieros
    Inherits frm_MenuPadre

    Private _ItemCta As String = ""
    Private oeCtaBancaria As New e_CuentaBancaria, olCtaBancaria As New l_CuentaBancaria, leCuentaBancaria As New List(Of e_CuentaBancaria)
    Private oeAsientoModel As New e_AsientoModelo, olAsientoModel As New l_AsientoModelo, leAsientoModel As New List(Of e_AsientoModelo)
    Private oeContratoFin As New e_ContratoFinanciero, olContratoFin As New l_ContratoFinanciero
    Dim oePeriodo As New e_Periodo, olPeriodo As New l_Periodo
    Private oeFlujoCaja As New e_FlujoCaja
    Private oeCtaGasto As New e_CuentaContable
    Private oeGastoFuncion As New e_TablaContableDet
    Private oeItemGasto As New e_ItemGasto
    Private oeMoneda As New e_Moneda, olMoneda As New l_Moneda, leMoneda As New List(Of e_Moneda)
    Private Ejercicio As Integer = 0

    Private Shared instancia As frm_GastosFinancieros = Nothing
    Private Shared Operacion As String

#Region "Definición del Formulario base"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_GastosFinancieros()
        End If
        instancia.Activate()
        Return instancia

    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Guardar()
        Try
            If GuardarGasto() Then
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
                Inicializar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If MessageBox.Show("¿Desea Cancelar la Operación?", "Mensaje de Sistema", MessageBoxButtons.YesNo, _
                               MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
                Inicializar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Métodos"

    Private Sub Inicializar()
        fecEmision.Value = Date.Now.Date
        DecTC.Value = TipoCambio(fecEmision.Value)(0)
        cboMoneda.SelectedIndex = -1
        cboCuentaBancaria.SelectedIndex = -1
        txtVoucher.Text = String.Empty
        cboCuenta.SelectedIndex = -1
        cboFlujoGasto.SelectedIndex = -1
        cboItemGasto.SelectedIndex = -1
        cboItemGasto.Enabled = False
        cboGastonFuncion.SelectedIndex = -1
        DecMonto.Value = 0
        txtGlosa.Value = String.Empty
        _ItemCta = String.Empty
        fecEmision.Focus()
    End Sub

    Private Sub GastoFuncion()
        Try
            If cboGastonFuncion.Items.Count = 0 Then
                Dim olTablaContableDet As New l_TablaContableDet
                Dim leTabla As New List(Of e_TablaContableDet)
                oeGastoFuncion.TipoOperacion = "N"
                oeGastoFuncion.Nombre = "GASTO FUNCION"
                oeGastoFuncion.Activo = True
                oeGastoFuncion.Logico2 = 1
                leTabla.AddRange(olTablaContableDet.Listar(oeGastoFuncion))
                With cboGastonFuncion
                    .ValueMember = "Id"
                    .DisplayMember = "Nombre"
                    .DataSource = leTabla
                End With
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub ItemGasto(ByVal idCuenta As String)
        Try
            If _ItemCta <> idCuenta Then
                Dim olItemGasto As New l_ItemGasto
                Dim leIG As New List(Of e_ItemGasto)
                oeItemGasto = New e_ItemGasto
                oeItemGasto.Activo = True
                oeItemGasto.IdCuentaContable = idCuenta
                'oeItemGasto.Ejercicio = Fecha.DateTime.Year
                oeItemGasto.Ejercicio = fecEmision.Value.Year
                leIG.AddRange(olItemGasto.Listar(oeItemGasto))
                With cboItemGasto
                    .ValueMember = "Id"
                    .DisplayMember = "Nombre"
                    .DataSource = leIG
                End With
                If cboItemGasto.Items.Count = 0 Then
                    cboItemGasto.Enabled = False
                Else
                    cboItemGasto.Enabled = True
                End If
                _ItemCta = idCuenta
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub LlenaFlujoCaja()
        Try
            Dim olFlujoCaja As New l_FlujoCaja
            LlenarCombo(cboFlujoGasto, "Nombre", olFlujoCaja.Listar(oeFlujoCaja), -1)
            cboFlujoGasto.Enabled = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaCuentaBancaria()
        Try
            oeCtaBancaria = New e_CuentaBancaria
            oeCtaBancaria.Activo = True
            leCuentaBancaria.AddRange(olCtaBancaria.Listar(oeCtaBancaria))
            leCuentaBancaria.OrderBy(Function(item) item.BancoCuenta)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarMoneda()
        Try
            oeMoneda = New e_Moneda
            oeMoneda.Activo = True
            leMoneda = olMoneda.Listar(oeMoneda)
            LlenarCombo(cboMoneda, "Nombre", leMoneda, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargaCuenta()
        Try
            Dim leCta As New List(Of e_CuentaContable)
            Dim olCta As New l_CuentaContable
            oeCtaGasto.TipoOperacion = "F" : oeCtaGasto.Activo = True : oeCtaGasto.Movimiento = 1 : oeCtaGasto.Ejercicio = fecEmision.Value.Year
            leCta.AddRange(olCta.Listar(oeCtaGasto))
            With cboCuenta
                .ValueMember = "Id" : .DisplayMember = "Nombre" : .DataSource = leCta
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GuardarGasto() As Boolean
        Try
            ValidarCombo(cboCuentaBancaria, "Cuenta Bancaria")
            ValidarCombo(cboFlujoGasto, "Flujo Gasto")
            ValidarCombo(cboGastonFuncion, "Distribucion")
            ValidarCombo(cboCuenta, "Cuenta del Gasto")
            If txtGlosa.Text.Trim.Length = 0 Then Throw New Exception("Ingrese Glosa")
            If cboItemGasto.Enabled Then ValidarCombo(cboItemGasto, "Item Gasto")
            l_FuncionesGenerales.ValidarNumeroDecimal(DecTC.Value, "Ingrese el Tipo de Cambio")
            l_FuncionesGenerales.ValidarNumeroDecimal(DecMonto.Value, "Ingrese el Monto")
            oeContratoFin = New e_ContratoFinanciero
            oeContratoFin.oeMovCajaBanco = New e_MovimientoCajaBanco
            oeContratoFin.oeMovCajaBanco.PrefijoID = gs_PrefijoIdSucursal '@0001
            'Obtener Periodo
            oePeriodo = New e_Periodo
            oePeriodo = ObtenerPeriodo(CDate(fecEmision.Value))
            oeContratoFin.IdPeriodo = oePeriodo.Id
            'Obtiene Asiento Modelo por Moneda
            oeAsientoModel = New e_AsientoModelo
            oeAsientoModel.Equivale = 1 : oeAsientoModel.IdMoneda = cboMoneda.Value
            If leAsientoModel.Contains(oeAsientoModel) Then
                oeAsientoModel = leAsientoModel.Item(leAsientoModel.IndexOf(oeAsientoModel))
                oeAsientoModel.TipoOperacion = ""
                oeAsientoModel.Ejercicio = fecEmision.Value.Year
                oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
            Else
                Throw New Exception("No Existe Configuracion Contable")
            End If
            'Cargar Tipo de Pago
            If oeAsientoModel.leDMReferencia.Count = 0 Then Throw New Exception("No Se Han Configurado el Medio de Pago")
            'Cargar Movimiento Bancario
            oeContratoFin.oeMovCajaBanco.IdCuentaBancaria = cboCuentaBancaria.Value
            oeContratoFin.oeMovCajaBanco.IdFlujoCaja = cboFlujoGasto.Value
            oeContratoFin.oeMovCajaBanco.IdMedioPago = oeAsientoModel.leDMReferencia(0).IdReferencia.Trim
            oeContratoFin.oeMovCajaBanco.NroBoucher = txtVoucher.Text
            oeContratoFin.oeMovCajaBanco.TipoCambio = DecTC.Value
            oeContratoFin.oeMovCajaBanco._Operador = -1
            oeContratoFin.oeMovCajaBanco.TotalMN = IIf(cboMoneda.Text = "SOLES", DecMonto.Value, DecMonto.Value * DecTC.Value)
            oeContratoFin.oeMovCajaBanco.TotalME = IIf(cboMoneda.Text = "SOLES", DecMonto.Value / DecTC.Value, DecMonto.Value)
            'Cargar Datos Adicionales
            oeContratoFin.Usuario = gUsuarioSGI.Id
            oeContratoFin.FechaEmision = fecEmision.Value
            oeContratoFin.Glosa = txtGlosa.Text.Trim
            oeContratoFin.IdMoneda = cboMoneda.Value
            oeContratoFin.TipoCambio = DecTC.Value
            oeContratoFin.Capital = DecMonto.Value
            oeContratoFin.NombreBanco = txtGlosa.Text.Trim
            oeContratoFin.MontoMN = IIf(cboMoneda.Text = "SOLES", DecMonto.Value, DecMonto.Value * DecTC.Value)
            oeContratoFin.MontoME = IIf(cboMoneda.Text = "SOLES", DecMonto.Value / DecTC.Value, DecMonto.Value)
            oeContratoFin.IdClienteProveedor = cboGastonFuncion.Value
            oeContratoFin.IdTipoDocumento = IIf(cboItemGasto.SelectedIndex > 0, cboItemGasto.Value, String.Empty)
            oeContratoFin.Codigo = cboCuenta.Value
            'oeContratoFin.NombreBanco = cboBanco.Text
            oeContratoFin.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olContratoFin.GuardarGastoFin(oeContratoFin, oeAsientoModel) Then
                mensajeEmergente.Confirmacion("Se registró Correctamente", True)
                Return True
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub CargarAsientoModel()
        oeAsientoModel = New e_AsientoModelo
        oeAsientoModel.TipoOperacion = "A" : oeAsientoModel.Activo = True : oeAsientoModel.Nombre = pIdActividadNegocio
        leAsientoModel = olAsientoModel.Listar(oeAsientoModel)
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_GastosFinancieros_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
    End Sub

    Private Sub frm_GastosFinancieros_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_GastosFinancieros_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_GastosFinancieros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            GastoFuncion()
            CargaCuenta()
            LlenaCuentaBancaria()
            LlenaFlujoCaja()
            LlenarMoneda()
            CargarAsientoModel()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cboCuenta_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCuenta.SelectionChangeCommitted
        Try
            If cboCuenta.SelectedIndex <> -1 Then
                Dim i As Integer = cboCuenta.SelectedIndex
                oeCtaGasto = cboCuenta.Items(i).ListObject
                ItemGasto(oeCtaGasto.Id)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cboCuentaBancaria_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuentaBancaria.ValueChanged
        If cboCuentaBancaria.SelectedIndex <> -1 Then
            oeCtaBancaria = cboCuentaBancaria.Items(cboCuentaBancaria.SelectedIndex).ListObject
        End If
    End Sub

    Private Sub cboFlujoGasto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFlujoGasto.ValueChanged
        If cboFlujoGasto.SelectedIndex <> -1 Then
            oeFlujoCaja = cboFlujoGasto.Items(cboFlujoGasto.SelectedIndex).ListObject
        End If
    End Sub

    Private Sub cboGastonFuncion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGastonFuncion.ValueChanged
        If cboGastonFuncion.SelectedIndex <> -1 Then
            oeGastoFuncion = cboGastonFuncion.Items(cboGastonFuncion.SelectedIndex).ListObject
        End If
    End Sub

    Private Sub cboItemGasto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboItemGasto.ValueChanged
        If cboItemGasto.SelectedIndex <> -1 Then
            oeItemGasto = cboItemGasto.Items(cboItemGasto.SelectedIndex).ListObject
        End If
    End Sub

    Private Sub cboCuenta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuenta.ValueChanged
        If cboCuenta.SelectedIndex <> -1 Then
            oeCtaGasto = cboCuenta.Items(cboCuenta.SelectedIndex).ListObject
            cboFlujoGasto.Text = IIf(cboCuenta.Text = "GASTOS BANCARIOS", gFCGastoFin, gFCITF)
        End If
    End Sub

    Private Sub fecEmision_Validated(sender As Object, e As EventArgs) Handles fecEmision.Validated
        Try
            If DecTC.Value = 0 Then
                DecTC.Value = TipoCambio(fecEmision.Value)(0)
            Else
                If MessageBox.Show("Desea Cambiar al Tipo de Cambio del dia?", "Mensaje del sistema", _
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) _
                   = Windows.Forms.DialogResult.Yes Then
                    DecTC.Value = TipoCambio(fecEmision.Value)(0)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboMoneda_ValueChanged(sender As Object, e As EventArgs) Handles cboMoneda.ValueChanged
        Try
            If cboMoneda.SelectedIndex > -1 Then
                Dim _leCtaBanAux = leCuentaBancaria.Where(Function(it) it.IdMoneda = cboMoneda.Value).ToList
                If _leCtaBanAux.Count > 0 Then
                    LlenarCombo(cboCuentaBancaria, "BancoCuenta", _leCtaBanAux, -1)
                Else
                    cboCuentaBancaria.DataSource = New List(Of e_CuentaBancaria)
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub fecEmision_ValueChanged(sender As Object, e As EventArgs) Handles fecEmision.ValueChanged
        Try
            If fecEmision.Value.Year <> Date.Now.Year Then
                CargaCuenta()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region


End Class
