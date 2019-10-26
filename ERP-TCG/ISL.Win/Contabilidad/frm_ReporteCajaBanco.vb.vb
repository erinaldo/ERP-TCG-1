'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF

Public Class frm_ReporteCajaBanco
    Inherits frm_MenuPadre

    Private Shared instancia As frm_ReporteCajaBanco = Nothing
    Private Shared Operacion As String

    Private olAsiento As New l_Asiento
    Private leMovimientosBancarios As New List(Of e_MovimientoCajaBanco)
    Private olMovimientosBancarios As New l_MovimientoCajaBanco
    Private oeMovimientosBancarios As New e_MovimientoCajaBanco
    Private leCtaBancaria As New List(Of e_CuentaBancaria)
    Private oeCtaBancaria As New e_CuentaBancaria
    Private oePeriodo As New e_Periodo
    Private olPeriodo As New l_Periodo
    Private _ComboPeriodo As Boolean = False
    Private oeCtaCble As New e_CuentaContable
    Private ListaCuentaBancaria As New List(Of e_CuentaBancaria)
    Private olCtaBancaria As New l_CuentaBancaria
    Private leCuentaBancaria As New List(Of e_CuentaBancaria)
    Private olCtaCble As New l_CuentaContable
    Private Ejercicio As Integer = 0

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    'Public Overrides Function getInstancia() As frm_MenuPadre
    '    If instancia Is Nothing Then
    '        Operacion = "Inicializa"
    '        instancia = New frm_ReporteCajaBanco()
    '    End If
    '    instancia.Activate()
    '    Return instancia

    'End Function

    Public Overrides Function getInstancia() As frm_MenuPadre
        If IndMultiInstancia = "NO" Then
            If instancia Is Nothing Then
                Operacion = "Inicializa"
                instancia = New frm_ReporteCajaBanco
            End If
        Else
            Operacion = "Inicializa"
            instancia = New frm_ReporteCajaBanco
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        ImprimirVoucher()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try

            If gridMovimientoBancarios.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(gridMovimientoBancarios)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub ImprimirVoucher()
        Try
            If gridMovimientoBancarios.ActiveRow.Cells("Id").Value.ToString <> "" Then
                If gridMovimientoBancarios.ActiveRow.Cells("IdFlujoCaja").Text.ToString.Contains("TRANSFER") Or _
                gridMovimientoBancarios.ActiveRow.Cells("IdFlujoCaja").Text.ToString.Contains("CAJA CHIC") Then
                    Dim frm As New frm_ImprimeTransferencia(gridMovimientoBancarios.ActiveRow.Cells("ID").Value)
                    frm.ShowDialog()
                    frm = Nothing
                Else
                    Dim i As Integer = IIf(gridMovimientoBancarios.ActiveRow.Cells("TotalMN").Value > 0, 1, 0)
                    Dim frm2 As New frm_ImprimeCobroPagoAnticipo(gridMovimientoBancarios.ActiveRow.Cells("ID").Value, i, "Documento")
                    frm2.ShowDialog()
                    frm2 = Nothing
                End If
                ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Listar(ByVal Activo As Boolean)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            DecSaldoInicial.Value = 0
            DecSaldoFinal.Value = 0
            ValidarCombo(cboCtaBancaria, "Cuenta Bancaria")

            oeMovimientosBancarios = New e_MovimientoCajaBanco
            oeMovimientosBancarios.Activo = Activo
            oeMovimientosBancarios._Ejercicio = Date.Parse(dtpFechaHasta.Value).Year
            oeMovimientosBancarios.IdCuentaBancaria = cboCtaBancaria.Value
            oeMovimientosBancarios.Fecha = dtpFechaDesde.Value
            oeMovimientosBancarios.TipoOperacion = "R"
            leMovimientosBancarios.Clear()
            leMovimientosBancarios.AddRange(olMovimientosBancarios.Listar(oeMovimientosBancarios))
            If leMovimientosBancarios.Count > 0 Then
                If oeCtaBancaria.IdMoneda = "1CH01" Then 'SOLES
                    DecSaldoInicial.Value = leMovimientosBancarios(0).TotalMN
                Else
                    DecSaldoInicial.Value = leMovimientosBancarios(0).TotalME
                End If
            Else
                DecSaldoInicial.Value = 0
            End If
            oeMovimientosBancarios = New e_MovimientoCajaBanco
            oeMovimientosBancarios.TipoOperacion = ""
            oeMovimientosBancarios.Fecha = dtpFechaDesde.Value
            oeMovimientosBancarios._FechaFin = dtpFechaHasta.Value
            oeMovimientosBancarios.IdCuentaBancaria = cboCtaBancaria.Value
            leMovimientosBancarios.Clear()
            leMovimientosBancarios.AddRange(olMovimientosBancarios.Listar(oeMovimientosBancarios))

            'Ubica el cursor en el primer registro de la grilla
            With gridMovimientoBancarios
                .Text = cboCtaBancaria.Text
                .DataBind()
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With

            SumarTotales()
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try

    End Sub

    Private Sub CargaMaestros()
        FlujoCaja()
        CuentaBancaria()
        MedioPago()
        llenacuenta()
        Moneda()
    End Sub

    Private Sub FlujoCaja()
        Try
            Dim oeFlujo As New e_FlujoCaja
            Dim leFlujo As New List(Of e_FlujoCaja)
            Dim olFlujo As New l_FlujoCaja
            oeFlujo.Activo = True
            leFlujo.AddRange(olFlujo.Listar(oeFlujo))
            '--------------------- para llenar combo en grilla    
            With gridMovimientoBancarios.DisplayLayout
                If .Bands(0).Columns.Exists("IdFlujoCaja") Then
                    .ValueLists.Clear()
                    .ValueLists.Add("IdFlujoCaja")
                End If
            End With
            With gridMovimientoBancarios.DisplayLayout.ValueLists("IdFlujoCaja").ValueListItems
                .Clear()
                For Each oeTD As e_FlujoCaja In leFlujo
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdFlujoCaja", "Nombre", gridMovimientoBancarios, True)
            '------------------------------------------

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Moneda()
        Try
            cboMoneda.DataSource = MonedaPublic
            cboMoneda.SelectedIndex = -1
            cboMoneda.DisplayMember = "Descripcion"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CuentaBancaria()
        Try
            If cboCtaBancaria.Items.Count = 0 Then
                Dim oeCtaBancaria As New e_CuentaBancaria
                Dim olCtaBancaria As New l_CuentaBancaria
                leCtaBancaria.AddRange(olCtaBancaria.Listar(oeCtaBancaria))
                '--------------------- para llenar combo en grilla    
                With gridMovimientoBancarios.DisplayLayout
                    If .Bands(0).Columns.Exists("IdCuentaBancaria") Then
                        .ValueLists.Clear()
                        .ValueLists.Add("IdCuentaBancaria")
                    End If
                End With
                With gridMovimientoBancarios.DisplayLayout.ValueLists("IdCuentaBancaria").ValueListItems
                    .Clear()
                    For Each oeTD As e_CuentaBancaria In leCtaBancaria
                        .Add(oeTD.Id, oeTD.BancoCuenta)
                    Next
                End With
                CrearComboGrid3("IdCuentaBancaria", "BancoCuenta", gridMovimientoBancarios, True)
                '------------------------------------------

                With cboCtaBancaria
                    .ValueMember = "Id"
                    .DisplayMember = "BancoCuenta"
                    .DataSource = leCtaBancaria
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MedioPago()
        Try
            Dim oeMedioPago As New e_MedioPago
            Dim olMedioPago As New l_MedioPago
            Dim leMedioPago As New List(Of e_MedioPago)
            oeMedioPago.Activo = True
            leMedioPago.AddRange(olMedioPago.Listar(oeMedioPago))
            '--------------------- para llenar combo en grilla    
            With gridMovimientoBancarios.DisplayLayout
                If .Bands(0).Columns.Exists("IdMedioPago") Then
                    .ValueLists.Clear()
                    .ValueLists.Add("IdMedioPago")
                End If
            End With
            With gridMovimientoBancarios.DisplayLayout.ValueLists("IdMedioPago").ValueListItems
                .Clear()
                For Each oeTD As e_MedioPago In leMedioPago
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdMedioPago", "Nombre", gridMovimientoBancarios, True)
            '------------------------------------------

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SumarTotales()

        Dim SumaDeCheck As Double = 0
        For Each obj As e_MovimientoCajaBanco In leMovimientosBancarios
            If oeCtaBancaria.IdMoneda = "1CH01" Then 'SOLES
                SumaDeCheck = SumaDeCheck + obj.TotalMN
            Else
                SumaDeCheck = SumaDeCheck + obj.TotalME
            End If
        Next
        DecSaldoFinal.Value = DecSaldoInicial.Value + SumaDeCheck

    End Sub

    Private Sub llenacuenta()
        Try
            If Ejercicio <> Year(dtpFechaDesde.Value) Then
                Ejercicio = Year(dtpFechaDesde.Value)
                oeCtaCble = New e_CuentaContable
                oeCtaCble.Activo = True
                oeCtaCble.Movimiento = 1
                oeCtaCble.FlujoCaja = 1
                oeCtaCble.Ejercicio = Year(dtpFechaDesde.Value)

                LlenarCombo(cboCuentaContable, "Nombre", olCtaCble.Listar(oeCtaCble), -1)
            End If
            cboCuentaContable.Value = oeCtaBancaria.IdCuentaContable
            'cboCuentaContable.Enabled = False 'Desativa el control 
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub LlenaCuentaBancaria()
        Try
            If leCuentaBancaria.Count = 0 Then
                oeCtaBancaria = New e_CuentaBancaria
                oeCtaBancaria.BancoCuenta = "TODOS"
                leCuentaBancaria.Add(oeCtaBancaria)

                oeCtaBancaria = New e_CuentaBancaria
                'oeCtaBancaria.IdCuentaContable = oeCtaCble.Id 'Relacionada con Cuenta COntale
                leCuentaBancaria.AddRange(olCtaBancaria.Listar(oeCtaBancaria))

                LlenarCombo(cboCtaBancaria, "BancoCuenta", leCuentaBancaria, 0)
                cboCtaBancaria.Enabled = IIf(leCuentaBancaria.Count = 0, False, True)
            Else
                Dim lista As New List(Of e_CuentaBancaria)
                lista = leCuentaBancaria.ToList
                lista = lista.Where(Function(item) item.IdCuentaContable = oeCtaCble.Id).ToList()
                If lista.Count = 0 Then
                    cboCtaBancaria.Enabled = False
                Else
                    cboCtaBancaria.Clear()
                    oeCtaBancaria = New e_CuentaBancaria
                    oeCtaBancaria.BancoCuenta = "TODOS"
                    lista.Add(oeCtaBancaria)
                    LlenarCombo(cboCtaBancaria, "BancoCuenta", lista, 0)
                    cboCtaBancaria.Enabled = True
                    cboCtaBancaria.Text = "TODOS"
                End If
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ConciliacionBancaria_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)
    End Sub

    Private Sub frm_ConciliacionBancaria_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ConciliacionBancaria_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case _Operacion
            Case "Nuevo"
                Me.Activate()
                Me.Cancelar()

            Case "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_ConciliacionBancaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
        gridMovimientoBancarios.DataSource = leMovimientosBancarios
        _ComboPeriodo = True
        CargaMaestros()
        dtpFechaDesde.Value = Date.Now.AddDays(-30)
    End Sub

    Private Sub cboCtaBancaria_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCtaBancaria.ValueChanged
        Dim i As Integer = cboCtaBancaria.SelectedIndex
        If i = -1 Then
            cboMoneda.SelectedIndex = -1
        Else
            oeCtaBancaria = New e_CuentaBancaria
            oeCtaBancaria = cboCtaBancaria.Items(i).ListObject
            cboMoneda.Value = oeCtaBancaria.IdMoneda
        End If
    End Sub

    Private Sub cboCuentaContable_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuentaContable.ValueChanged
        Try
            oeCtaCble = New e_CuentaContable
            With cboCuentaContable
                Dim i As Integer = .SelectedIndex
                oeCtaCble = .Items(i).ListObject
            End With
            'If cboCuentaContable.Enabled Then
            LlenaCuentaBancaria()
            'End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_ReporteCajaBanco_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

#End Region

    Private Sub gridMovimientoBancarios_InitializeLayout(sender As Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles gridMovimientoBancarios.InitializeLayout
        Try
            gridMovimientoBancarios.DisplayLayout.CaptionAppearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True
        Catch ex As Exception

        End Try
        'Infragistics.Win.UltraWinGrid.UltraGridLayout = l = e.Layout
        '    UltraGridOverride ov = layout.Override;

        '    layout.CaptionAppearance.FontData.Bold = DefaultableBoolean.True;
    End Sub
End Class
