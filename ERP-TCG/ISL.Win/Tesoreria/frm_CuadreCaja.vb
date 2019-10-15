'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win
Imports Infragistics

Public Class frm_CuadreCaja
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializacion del Formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_CuadreCaja = Nothing
    Private Shared Operacion As String = ""
    Private Estado As String
    Dim _ingresando_datos As Boolean = False

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_CuadreCaja()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private WithEvents oeCuadreCaja As New e_CuadreCaja
    Private olCuadreCaja As New l_CuadreCaja
    Private loCuadreCaja As New List(Of e_CuadreCaja)

    Private oeCuadreCajaGasto As New e_CuadreCajaGasto
    Private olCuadreCajaGasto As New l_CuadreCajaGasto
    Private loCuadreCajaGasto As New List(Of e_CuadreCajaGasto)

    Private oeCuadreCajaBolsa As New e_CuadreCajaBolsa
    Private olCuadreCajaBolsa As New l_CuadreCajaBolsa
    Private loCuadreCajaBolsa As New List(Of e_CuadreCajaBolsa)

    Dim oeCaja As New e_Caja
    Dim olCaja As New l_Caja
    Dim loCaja As New List(Of e_Caja)

    Dim oeCajaUsuario As New e_CajaUsuario
    Dim olCajaUsuario As New l_CajaUsuario

    Dim idCajaCentro As String = ""
    Dim IndPrincipal As Boolean = False

    Dim FechaInicio As Date = Date.Parse("01/01/1901")

    Dim oeCentro As New e_Centro
    Dim olCentro As New l_Centro

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Listar()
            ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Inicializar()
            Operacion = "Editar"
            MostrarTabs(1, ficCuadreCaja, 1)
            Mostrar()
            ControlBoton(0, 0, 0, 0, 1, 0, 1, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Operacion = "Nuevo"
            Inicializar()
            MostrarTabs(1, ficCuadreCaja, 1)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            Me.num200.Focus()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarCuadre() Then
                MostrarTabs(0, ficCuadreCaja, 2)
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            MostrarTabs(0, ficCuadreCaja, 2)
            _ingresando_datos = False
            Operacion = "Inicializa"
            ControlBoton(1, 0, 0, 0, 0, 0, 1, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Salir()
        Try
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            MyBase.Salir()
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
        End Try
    End Sub

    Public Overrides Sub Exportar()
        MyBase.Exportar()
    End Sub

    Public Overrides Sub Imprimir()
        Try
            ImprimirCuadre()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        MyBase.Eliminar()
    End Sub

#End Region

#Region "Metodos"

    Public Sub Inicializar()
        Try
            If Operacion = "Nuevo" Then
                btnActualizarDetalle.Enabled = True
                Me.Etiqueta29.Visible = False
                Me.Etiqueta30.Visible = False
                Me.txtCodigo.Visible = False
                Me.txtCaja.Visible = False
                dtpFechaCuadre.Value = ObtenerFechaServidor()
            Else
                btnActualizarDetalle.Enabled = False
                Me.Etiqueta29.Visible = True
                Me.Etiqueta30.Visible = True
                Me.txtCodigo.Visible = True
                Me.txtCaja.Visible = True
            End If
            FechaInicio = Date.Parse("01/01/1901")
            oeCuadreCaja = New e_CuadreCaja
            loCuadreCajaBolsa = New List(Of e_CuadreCajaBolsa)
            griCuadreBolsas.DataSource = loCuadreCajaBolsa
            loCuadreCajaGasto = New List(Of e_CuadreCajaGasto)
            griCuadreGastos.DataSource = loCuadreCajaGasto
            Me.numSaldoSistema.Value = 0
            Me.numTotalEfectivo.Value = 0
            Me.numGastosTotal.Value = 0
            Me.numTotalCaja.Value = 0
            Me.numOtros.Value = 0
            Me.numDiferencia.Value = 0
            Me.numBolsasHabilitar.Value = 0
            Me.num200.Value = 0
            Me.num100.Value = 0
            Me.num50.Value = 0
            Me.num20.Value = 0
            Me.num10.Value = 0
            Me.num5.Value = 0
            Me.num2.Value = 0
            Me.num1.Value = 0
            Me.num05.Value = 0
            Me.num02.Value = 0
            Me.num01.Value = 0
            Me.num005.Value = 0
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Listar()
        Try
            oeCuadreCaja = New e_CuadreCaja
            loCuadreCaja = New List(Of e_CuadreCaja)
            oeCuadreCaja.IdCaja = cboCentroL.Value
            oeCuadreCaja.Fecha = fecDesde.Value
            oeCuadreCaja.FechaCreacion = fecHasta.Value
            loCuadreCaja.AddRange(olCuadreCaja.Listar(oeCuadreCaja))
            griCuadreCaja.DataSource = loCuadreCaja
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Mostrar()
        Try
            oeCuadreCaja.Id = griCuadreCaja.ActiveRow.Cells("Id").Value
            oeCuadreCaja = olCuadreCaja.Obtener(oeCuadreCaja)
            With oeCuadreCaja
                dtpFechaCuadre.Value = .Fecha
                numSaldoSistema.Value = .SaldoSistema
                numOtros.Value = .Otros
                numTotalEfectivo.Value = .Efectivo
                numDiferencia.Value = Math.Round(.Diferencia, 2)
                Me.txtCaja.Value = .Caja
                Me.txtCodigo.Value = .Codigo
                Me.txtObservacion.Value = .Observacion
                Me.num200.Value = .num200
                Me.num100.Value = .num100
                Me.num50.Value = .num50
                Me.num20.Value = .num20
                Me.num10.Value = .num10
                Me.num5.Value = .num5
                Me.num2.Value = .num2
                Me.num1.Value = .num1
                Me.num05.Value = .num05
                Me.num02.Value = .num02
                Me.num01.Value = .num01
                Me.num005.Value = .num005
                ListarDetalles(.Id)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarDetalles(IdCuadreCaja As String)
        Try
            oeCuadreCajaBolsa = New e_CuadreCajaBolsa
            oeCuadreCajaBolsa.IdCuadreCaja = IdCuadreCaja
            loCuadreCajaBolsa.AddRange(olCuadreCajaBolsa.Listar(oeCuadreCajaBolsa))
            CalcularTotales(griCuadreBolsas, "Importe")

            oeCuadreCajaGasto = New e_CuadreCajaGasto
            oeCuadreCajaGasto.IdCuadreCaja = IdCuadreCaja
            loCuadreCajaGasto.AddRange(olCuadreCajaGasto.Listar(oeCuadreCajaGasto))
            CalcularTotales(griCuadreGastos, "Importe")
            CalcularGastos()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub CalcularGastos()
        Try
            Me.numGastosTotal.Value = loCuadreCajaGasto.Sum(Function(i) i.Importe)
            Me.numBolsasHabilitar.Value = loCuadreCajaBolsa.Sum(Function(i) i.Importe)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub CargarCierre(Saldo As Double, fecini As Date)
        Try
            Nuevo()
            numSaldoSistema.Value = Saldo
            FechaInicio = fecini
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function GuardarCuadre() As Boolean
        Try
            LlenaObjeto()
            oeCuadreCaja.loCajaBolsa = loCuadreCajaBolsa
            oeCuadreCaja.loCajaGasto = loCuadreCajaGasto
            oeCuadreCaja.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olCuadreCaja.Guardar(oeCuadreCaja) Then
                ImprimirCuadre()
                mensajeEmergente.Confirmacion("La Informacion ha sido Guardada Correctamente", True)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub CargaCombos()
        Try
            CargarTipoDocumento()
            CargarTrabajadores()
            LlenaComboCentro()
            ListarUsuarioCaja()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CargarTipoDocumento()
        Try
            If cboTipoDocumento.Items.Count = 0 Then
                Dim oeTipoDoc As New e_TipoDocumento
                Dim olTipoDoc As New l_TipoDocumento
                Dim ListaTipoDocumento As New List(Of e_TipoDocumento)
                oeTipoDoc.TipoOperacion = "J"
                ListaTipoDocumento = New List(Of e_TipoDocumento)
                ListaTipoDocumento.AddRange(olTipoDoc.Listar(oeTipoDoc))
                LlenarCombo(cboTipoDocumento, "Nombre", ListaTipoDocumento, -1)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarTrabajadores()
        Try
            If cboTrabajadores.Items.Count = 0 Then
                LlenarCombo(cboTrabajadores, "Nombre", TrabajadorPublic, -1)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaComboCentro()
        Dim oe As New e_Centro
        Dim leCentro As New List(Of e_Centro)
        oe.Id = ""
        oe.Nombre = "TODOS"
        leCentro.Add(oe)
        leCentro.AddRange(olCentro.Listar(oeCentro))
        LlenarCombo(cboCentroL, "Nombre", leCentro, 0)
    End Sub

    Private Sub ImprimirCuadre()
        Try
            Dim Id As String = ""
            Dim Tipo As Integer = 0
            Select Case ficCuadreCaja.SelectedTab.Index
                Case 0
                    If griCuadreCaja.Selected.Rows.Count > 0 Then
                        Id = griCuadreCaja.ActiveRow.Cells("Id").Value
                    End If
                    Tipo = 0
                Case 1
                    If oeCuadreCaja.Id <> "" Then
                        Id = oeCuadreCaja.Id
                        Tipo = 1
                    Else
                        Throw New Exception("Debe Guardar el Cuadre de Caja para Imprimir")
                    End If
            End Select
            Dim frm As New frm_ReporteCuadreCaja
            frm.CargarDatos(Id)
            frm.ShowDialog()
            If Tipo = 0 Then
                ControlBoton(1, 1, 0, 0, 0, 0, 1, 1, 1)
            Else
                ControlBoton(0, 0, 0, 0, 1, 0, 1, 0, 1)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ListarUsuarioCaja()
        Try
            oeCaja = New e_Caja
            loCaja = olCaja.Listar(oeCaja)
            oeCajaUsuario = New e_CajaUsuario
            oeCajaUsuario = BuscarCajaUsuario(gUsuarioSGI.IdTrabajador)
            If oeCajaUsuario.Id <> "" Then
                For Each ListaCaja As e_Caja In loCaja
                    If ListaCaja.Id = oeCajaUsuario.IdCaja Then
                        cboCentroL.Value = oeCajaUsuario.IdCentro
                        idCajaCentro = ListaCaja.Id
                        IndPrincipal = ListaCaja.IndPrincipal
                        Exit For
                    End If
                Next
            Else
                mensajeEmergente.Problema("Este Usuario no Esta Asignado a Ninguna Caja")
            End If
            If IndPrincipal Then
                cboCentroL.Enabled = True
            Else
                cboCentroL.Enabled = False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaObjeto()
        Try
            With oeCuadreCaja
                .TipoOperacion = "I"
                .IdCaja = idCajaCentro
                .Fecha = dtpFechaCuadre.Value
                .SaldoSistema = numSaldoSistema.Value
                .Otros = numOtros.Value
                .Diferencia = Math.Round(numDiferencia.Value, 2)
                .Observacion = Me.txtObservacion.Text
                .num200 = Me.num200.Value
                .num100 = Me.num100.Value
                .num50 = Me.num50.Value
                .num20 = Me.num20.Value
                .num10 = Me.num10.Value
                .num5 = Me.num5.Value
                .num2 = Me.num2.Value
                .num1 = Me.num1.Value
                .num05 = Me.num05.Value
                .num02 = Me.num02.Value
                .num01 = Me.num01.Value
                .num005 = Me.num005.Value
                .UsuarioCreacion = gUsuarioSGI.Id
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarGasto()
        Try
            oeCuadreCajaGasto = New e_CuadreCajaGasto
            If cboTipoDocumento.SelectedIndex = -1 Then Throw New Exception("Seleccione Tipo Documento")
            If decImporteGasto.Value = 0 Then Throw New Exception("El Importe Tiene que ser Mayor a 0")
            With oeCuadreCajaGasto
                .TipoOperacion = "I"
                .IdTipoDocumento = cboTipoDocumento.Value
                .Importe = decImporteGasto.Value
                .TipoDocumento = cboTipoDocumento.Text
                .Glosa = txtGlosa.Text
                .Fecha = dtpDocumento.Value
            End With
            loCuadreCajaGasto.Add(oeCuadreCajaGasto)
            griCuadreGastos.DataBind()
            CalcularTotales(griCuadreGastos, "Importe")
            CalcularGastos()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarBolsa()
        Try
            oeCuadreCajaBolsa = New e_CuadreCajaBolsa
            With oeCuadreCajaBolsa
                .TipoOperacion = "I"
                .IdTrabajador = cboTrabajadores.Value
                .Importe = decImporteBolsa.Value
                .Trabajador = cboTrabajadores.Text
                .Fecha = dtpDocumento.Value
            End With
            loCuadreCajaBolsa.Add(oeCuadreCajaBolsa)
            griCuadreBolsas.DataBind()
            CalcularTotales(griCuadreBolsas, "Importe")
            CalcularGastos()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarGasto()
        Try
            oeCuadreCajaGasto = New e_CuadreCajaGasto
            oeCuadreCajaGasto = griCuadreGastos.ActiveRow.ListObject
            If oeCuadreCajaGasto.TipoOperacion = "I" Then
                loCuadreCajaGasto.Remove(oeCuadreCajaGasto)
            End If
            griCuadreGastos.DataBind()
            CalcularGastos()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarBolsa()
        Try
            oeCuadreCajaBolsa = New e_CuadreCajaBolsa
            oeCuadreCajaBolsa = griCuadreBolsas.ActiveRow.ListObject
            If oeCuadreCajaBolsa.TipoOperacion = "I" Then
                loCuadreCajaBolsa.Remove(oeCuadreCajaBolsa)
            End If
            griCuadreBolsas.DataBind()
            CalcularGastos()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ActualizarSaldoSistema()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim i As Double = 0 : Dim e As Double = 0
            If IndPrincipal Then
                Dim oeCajaDiario As New e_ReporteCajaDiario
                Dim olCajaDiario As New l_ReporteCajaDiario
                Dim loCajaDiario As New List(Of e_ReporteCajaDiario)
                Dim fecha As Date = ObtenerFechaServidor()
                Dim a As String = fecha.Hour & ":" & fecha.Minute & ":" & fecha.Second
                oeCajaDiario.IdCaja = idCajaCentro
                oeCajaDiario.FechaInicio = FechaInicio
                oeCajaDiario.FechaFin = Date.Parse(fecha.Date & " " & a)
                loCajaDiario = olCajaDiario.Listar(oeCajaDiario)
                i = loCajaDiario.Sum(Function(item) item.Ingresos)
                e = loCajaDiario.Sum(Function(item) item.Egresos)
                Me.numSaldoSistema.Value = Math.Round(i - e, 2)
            Else
                Dim oeMovAdm As New e_Movimiento_Administrativo
                Dim olMovAdm As New l_Movimiento_Administrativo
                Dim loMovAdm As New List(Of e_Movimiento_Administrativo)
                oeMovAdm.TipoOperacion = "4"
                oeMovAdm.IdCaja = idCajaCentro
                loMovAdm = olMovAdm.Listar(oeMovAdm)
                i = loMovAdm.Sum(Function(item) item.Ingreso)
                e = loMovAdm.Sum(Function(item) item.Egreso)
                Me.numSaldoSistema.Value = Math.Round(e - i, 2)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_CuadreCaja_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Select Case ficCuadreCaja.SelectedTab.Index
            Case 0
                ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)
            Case 1
                If Operacion = "Nuevo" Then
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
                Else
                    ControlBoton(0, 0, 0, 0, 1, 0, 1, 0, 1)
                End If
        End Select
    End Sub

    Private Sub frm_CuadreCaja_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_CuadreCaja_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
       ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_CuadreCaja_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            gf_AsignarEventoSeleccionarTexto(Me)
            gmt_ConfigurarEventoKeyEnter_Tab(Me, btnAceptarBolsa.Name, btnAgregarGasto.Name)
            Me.numDiferencia.Appearance.ForeColor = Color.White
            CargaCombos()
            fecDesde.Value = Date.Now.AddDays(-30)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub num200_ValueChanged(sender As Object, e As EventArgs) Handles num200.ValueChanged
        If IsDBNull(num200.Value) Then num200.Value = 0
        dec200.Value = num200.Value * 200
    End Sub

    Private Sub num100_ValueChanged(sender As Object, e As EventArgs) Handles num100.ValueChanged
        If IsDBNull(num100.Value) Then num200.Value = 0
        dec100.Value = num100.Value * 100
    End Sub

    Private Sub num50_ValueChanged(sender As Object, e As EventArgs) Handles num50.ValueChanged
        If IsDBNull(num50.Value) Then num50.Value = 0
        dec50.Value = num50.Value * 50
    End Sub

    Private Sub num20_ValueChanged(sender As Object, e As EventArgs) Handles num20.ValueChanged
        If IsDBNull(num20.Value) Then num20.Value = 0
        dec20.Value = num20.Value * 20
    End Sub

    Private Sub num10_ValueChanged(sender As Object, e As EventArgs) Handles num10.ValueChanged
        If IsDBNull(num10.Value) Then num10.Value = 0
        dec10.Value = num10.Value * 10
    End Sub

    Private Sub num5_ValueChanged(sender As Object, e As EventArgs) Handles num5.ValueChanged
        If IsDBNull(num5.Value) Then num5.Value = 0
        dec5.Value = num5.Value * 5
    End Sub

    Private Sub num2_ValueChanged(sender As Object, e As EventArgs) Handles num2.ValueChanged
        If IsDBNull(num2.Value) Then num2.Value = 0
        dec2.Value = num2.Value * 2
    End Sub

    Private Sub num1_ValueChanged(sender As Object, e As EventArgs) Handles num1.ValueChanged
        If IsDBNull(num1.Value) Then num1.Value = 0
        dec1.Value = num1.Value
    End Sub

    Private Sub num05_ValueChanged(sender As Object, e As EventArgs) Handles num05.ValueChanged
        If IsDBNull(num05.Value) Then num05.Value = 0
        dec05.Value = num05.Value * 0.5
    End Sub

    Private Sub num02_ValueChanged(sender As Object, e As EventArgs) Handles num02.ValueChanged
        If IsDBNull(num02.Value) Then num02.Value = 0
        dec02.Value = num02.Value * 0.2
    End Sub

    Private Sub num01_ValueChanged(sender As Object, e As EventArgs) Handles num01.ValueChanged
        If IsDBNull(num01.Value) Then num01.Value = 0
        dec01.Value = num01.Value * 0.1
    End Sub

    Private Sub num005_ValueChanged(sender As Object, e As EventArgs) Handles num005.ValueChanged
        If IsDBNull(num005.Value) Then num005.Value = 0
        dec005.Value = num005.Value * 0.05
    End Sub

    Private Sub dec200_ValueChanged(sender As Object, e As EventArgs) Handles dec200.ValueChanged
        decTotalBilletes.Value = dec200.Value + dec100.Value + dec50.Value + dec20.Value + dec10.Value
    End Sub

    Private Sub dec100_ValueChanged(sender As Object, e As EventArgs) Handles dec100.ValueChanged
        decTotalBilletes.Value = dec200.Value + dec100.Value + dec50.Value + dec20.Value + dec10.Value
    End Sub

    Private Sub dec50_ValueChanged(sender As Object, e As EventArgs) Handles dec50.ValueChanged
        decTotalBilletes.Value = dec200.Value + dec100.Value + dec50.Value + dec20.Value + dec10.Value
    End Sub

    Private Sub dec20_ValueChanged(sender As Object, e As EventArgs) Handles dec20.ValueChanged
        decTotalBilletes.Value = dec200.Value + dec100.Value + dec50.Value + dec20.Value + dec10.Value
    End Sub

    Private Sub dec10_ValueChanged(sender As Object, e As EventArgs) Handles dec10.ValueChanged
        decTotalBilletes.Value = dec200.Value + dec100.Value + dec50.Value + dec20.Value + dec10.Value
    End Sub

    Private Sub dec5_ValueChanged(sender As Object, e As EventArgs) Handles dec5.ValueChanged
        decTotalMonedas.Value = dec5.Value + dec2.Value + dec1.Value + dec05.Value + dec02.Value + dec01.Value + dec005.Value
    End Sub

    Private Sub dec2_ValueChanged(sender As Object, e As EventArgs) Handles dec2.ValueChanged
        decTotalMonedas.Value = dec5.Value + dec2.Value + dec1.Value + dec05.Value + dec02.Value + dec01.Value + dec005.Value
    End Sub

    Private Sub dec1_ValueChanged(sender As Object, e As EventArgs) Handles dec1.ValueChanged
        decTotalMonedas.Value = dec5.Value + dec2.Value + dec1.Value + dec05.Value + dec02.Value + dec01.Value + dec005.Value
    End Sub

    Private Sub dec05_ValueChanged(sender As Object, e As EventArgs) Handles dec05.ValueChanged
        decTotalMonedas.Value = dec5.Value + dec2.Value + dec1.Value + dec05.Value + dec02.Value + dec01.Value + dec005.Value
    End Sub

    Private Sub dec02_ValueChanged(sender As Object, e As EventArgs) Handles dec02.ValueChanged
        decTotalMonedas.Value = dec5.Value + dec2.Value + dec1.Value + dec05.Value + dec02.Value + dec01.Value + dec005.Value
    End Sub

    Private Sub dec01_ValueChanged(sender As Object, e As EventArgs) Handles dec01.ValueChanged
        decTotalMonedas.Value = dec5.Value + dec2.Value + dec1.Value + dec05.Value + dec02.Value + dec01.Value + dec005.Value
    End Sub

    Private Sub dec005_ValueChanged(sender As Object, e As EventArgs) Handles dec005.ValueChanged
        decTotalMonedas.Value = dec5.Value + dec2.Value + dec1.Value + dec05.Value + dec02.Value + dec01.Value + dec005.Value
    End Sub

    Private Sub decTotalBilletes_ValueChanged(sender As Object, e As EventArgs) Handles decTotalBilletes.ValueChanged
        numTotalEfectivo.Value = decTotalBilletes.Value + decTotalMonedas.Value
    End Sub

    Private Sub decTotalMonedas_ValueChanged(sender As Object, e As EventArgs) Handles decTotalMonedas.ValueChanged
        numTotalEfectivo.Value = decTotalBilletes.Value + decTotalMonedas.Value
    End Sub

    Private Sub numOtros_ValueChanged(sender As Object, e As EventArgs) Handles numOtros.ValueChanged
        numTotalCaja.Value = numGastosTotal.Value + numTotalEfectivo.Value + numBolsasHabilitar.Value + numOtros.Value
    End Sub

    Private Sub numGastosTotal_ValueChanged(sender As Object, e As EventArgs) Handles numGastosTotal.ValueChanged
        numTotalCaja.Value = numGastosTotal.Value + numTotalEfectivo.Value + numBolsasHabilitar.Value + numOtros.Value
    End Sub

    Private Sub numSaldoSistema_ValueChanged(sender As Object, e As EventArgs) Handles numSaldoSistema.ValueChanged
        numDiferencia.Value = numSaldoSistema.Value - numTotalCaja.Value
    End Sub

    Private Sub numTotalCaja_ValueChanged(sender As Object, e As EventArgs) Handles numTotalCaja.ValueChanged
        numDiferencia.Value = numSaldoSistema.Value - numTotalCaja.Value
    End Sub

    Private Sub numTotalEfectivo_ValueChanged(sender As Object, e As EventArgs) Handles numTotalEfectivo.ValueChanged
        numTotalCaja.Value = numGastosTotal.Value + numTotalEfectivo.Value + numBolsasHabilitar.Value + numOtros.Value
    End Sub

    Private Sub numBolsasHabilitar_ValueChanged(sender As Object, e As EventArgs) Handles numBolsasHabilitar.ValueChanged
        numTotalCaja.Value = numGastosTotal.Value + numTotalEfectivo.Value + numBolsasHabilitar.Value + numOtros.Value
    End Sub

    Private Sub cboTipoDocumento_Enter(sender As Object, e As EventArgs) Handles cboTipoDocumento.Enter
        cboTipoDocumento.SelectAll()
    End Sub

    Private Sub txtGlosa_Enter(sender As Object, e As EventArgs) Handles txtGlosa.Enter
        txtGlosa.SelectAll()
    End Sub

    Private Sub decImporteGasto_Enter(sender As Object, e As EventArgs) Handles decImporteGasto.Enter
        decImporteGasto.SelectAll()
    End Sub

    Private Sub decImporteGasto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles decImporteGasto.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = Keys.Tab Then
            btnAgregarGasto.Focus()
        End If
    End Sub

    Private Sub cboTrabajadores_Enter(sender As Object, e As EventArgs) Handles cboTrabajadores.Enter
        cboTrabajadores.SelectAll()
    End Sub

    Private Sub decImporteBolsa_Enter(sender As Object, e As EventArgs) Handles decImporteBolsa.Enter
        decImporteBolsa.SelectAll()
    End Sub

    Private Sub decImporteBolsa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles decImporteBolsa.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = Keys.Tab Then
            btnAceptarBolsa.Focus()
        End If
    End Sub

    Private Sub btnAgregarGasto_Click(sender As Object, e As EventArgs) Handles btnAgregarGasto.Click
        Try
            AgregarGasto()
            dtpDocumento.Focus()
            'Me.cboTipoDocumento.SelectedIndex = -1
            Me.txtGlosa.Value = String.Empty
            Me.decImporteGasto.Value = 0
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAceptarBolsa_Click(sender As Object, e As EventArgs) Handles btnAceptarBolsa.Click
        Try
            AgregarBolsa()
            dtpFechaBolsa.Focus()
            Me.decImporteBolsa.Value = 0
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griCuadreCaja_DoubleClick(sender As Object, e As EventArgs) Handles griCuadreCaja.DoubleClick
        Try
            If griCuadreCaja.Selected.Rows.Count > 0 Then Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnQuitarCC_Click(sender As Object, e As EventArgs) Handles btnQuitarCC.Click
        Try
            If griCuadreGastos.Selected.Rows.Count > 0 Then QuitarGasto()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnQuitarBolsa_Click(sender As Object, e As EventArgs) Handles btnQuitarBolsa.Click
        Try
            If griCuadreBolsas.Selected.Rows.Count > 0 Then QuitarBolsa()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griCuadreGastos_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles griCuadreGastos.AfterCellUpdate
        Try
            CalcularTotales(griCuadreBolsas, "Importe")
            CalcularGastos()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griCuadreGastos_CellChange(sender As Object, e As CellEventArgs) Handles griCuadreGastos.CellChange
        Try
            griCuadreGastos.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griCuadreBolsas_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles griCuadreBolsas.AfterCellUpdate
        Try
            CalcularTotales(griCuadreBolsas, "Importe")
            CalcularGastos()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griCuadreBolsas_CellChange(sender As Object, e As CellEventArgs) Handles griCuadreBolsas.CellChange
        Try
            griCuadreBolsas.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griCuadreGastos_BeforeCellUpdate(sender As Object, e As BeforeCellUpdateEventArgs) Handles griCuadreGastos.BeforeCellUpdate
        Try
            With griCuadreGastos
                Select Case e.Cell.Column.Key
                    Case "Importe"
                        If IsDBNull(e.NewValue) Then
                            e.Cancel = True
                        End If
                End Select
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griCuadreBolsas_BeforeCellUpdate(sender As Object, e As BeforeCellUpdateEventArgs) Handles griCuadreBolsas.BeforeCellUpdate
        Try
            With griCuadreBolsas
                Select Case e.Cell.Column.Key
                    Case "Importe"
                        If IsDBNull(e.NewValue) Then
                            e.Cancel = True
                            e.Cell.Value = 0
                        End If
                End Select
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnActualizarDetalle_Click(sender As Object, e As EventArgs) Handles btnActualizarDetalle.Click
        Try
            ActualizarSaldoSistema()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_CuadreCaja_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

#End Region

End Class