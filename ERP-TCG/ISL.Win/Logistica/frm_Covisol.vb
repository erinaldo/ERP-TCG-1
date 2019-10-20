'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ISL.Win.CovisolR
Imports ERP.EntidadesWCF
Imports Infragistics.Win.UltraWinGrid

Public Class frm_Covisol
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"
    Private Shared instancia As frm_Covisol = Nothing
    'Instancia unica de Formulario: frm_OrdenProduccionLadrillo
    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_Covisol
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Variables"

    Private mstrUsuCovisol As String = "induamericasl"
    Private mstrPassCovisol As String = "20479729141"

    Private olCovisol As CovisolR.GetDatosService

    Private olVehiculoTarjeta As New l_VehiculoTarjeta

    Private loMovimientoTarjeta As New List(Of e_TarjetaMovimiento)
    Private olMovimientoTarjeta As New l_TarjetaMovimiento

    'Control de Espera para el Usuario
    Private msjEspere As ISL.Win.Espere
    'Validar Acceso al Listado
    Private oeRegEditados As e_RegistrosEditados
    Private olRegistrosEditados As New l_RegistrosEditados
#End Region

#Region "Botones"

    Public Overrides Sub Consultar(Activo As Boolean)
        Try
            mt_Listar()
            mt_ControlBotoneria()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            Select Case ficPrincipal.SelectedTab.Index
                Case tabSaldos.Tab.Index
                    If griSaldoTarjeta.Rows.Count > 0 Then
                        Exportar_Excel(griSaldoTarjeta)
                    Else
                        MessageBox.Show("No hay ningún dato para exportar al Excel", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Case tabMovimientos.Tab.Index
                    If griMovimientos.Rows.Count > 0 Then
                        Exportar_Excel(griMovimientos)
                    Else
                        MessageBox.Show("No hay ningún dato para exportar al Excel", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Salir()
        Try
            MyBase.Salir()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            Select Case ficPrincipal.SelectedTab.Index
                Case tabSaldos.Tab.Index
                Case tabMovimientos.Tab.Index
                    mt_ListarMovimientos()
                    If MessageBox.Show("Desea guardar todos los registros pendientes?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        mt_GuardarMasivo()
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mt_InicializarForm()
            griMovimientos.DataSource = loMovimientoTarjeta
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Covisol_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Try
            mt_ControlBotoneria()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtNroTarjetaFiltro_Validated(sender As Object, e As EventArgs) Handles txtNroTarjetaFiltro.Validated
        Try
            If Not String.IsNullOrEmpty(txtNroTarjetaFiltro.Text.Trim()) Then
                txtNroTarjetaFiltro.Text = fc_FormatoTarjeta(txtNroTarjetaFiltro.Text.Trim(), 16)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Covisol_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            instancia = Nothing
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Covisol_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            'If oeRegEditados IsNot Nothing AndAlso oeRegEditados.Id <> String.Empty Then
            '    oeRegEditados.TipoOperacion = "I"
            '    olRegistrosEditados.Guardar(oeRegEditados)
            'End If
            ControlBoton()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtNroTarjetaFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroTarjetaFiltro.KeyDown
        Try
            If Not String.IsNullOrEmpty(txtNroTarjetaFiltro.Text.Trim()) Then
                If e.KeyCode = Keys.Enter Then
                    Consultar(True)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtTarjetaFiltroSaldo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTarjetaFiltroSaldo.KeyDown
        Try
            If Not String.IsNullOrEmpty(txtTarjetaFiltroSaldo.Text.Trim()) Then
                If e.KeyCode = Keys.Enter Then
                    Consultar(True)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub mt_InicializarForm()
        Try
            dtpHasta.Value = ObtenerFechaServidor()
            dtpDesde.Value = dtpHasta.Value.Date.AddDays(-2)
            For Each _Saldo In griSaldoTarjeta.DisplayLayout.Bands(0).Columns
                _Saldo.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                _Saldo.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            Next
            For Each _Movimiento In griMovimientos.DisplayLayout.Bands(0).Columns
                With _Movimiento
                    .CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                    .CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
                End With
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_ControlBotoneria()
        Try
            Select Case ficPrincipal.SelectedTab.Index
                Case tabSaldos.Tab.Index
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                Case tabMovimientos.Tab.Index
                    If loMovimientoTarjeta.Where(Function(x) x.IndGuardado = False).Count > 0 Then
                        ControlBoton(1, 0, 0, 1, 0, 0, 0, 1, 1)
                    Else
                        ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                    End If
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Listar()
        Try
            Select Case ficPrincipal.SelectedTab.Index
                Case tabSaldos.Tab.Index
                    mt_ListarSaldos()
                Case tabMovimientos.Tab.Index
                    'If fc_VerificarUsuarioEdita() Then
                    mt_ListarMovimientos()
                    'End If
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_ListarSaldos()
        Try
            Dim loVehiculoTarjeta As New List(Of e_VehiculoTarjeta)
            loVehiculoTarjeta.AddRange(olVehiculoTarjeta.Listar(New e_VehiculoTarjeta With {.TipoOperacion = "GEN", .Actual = True}))
            Dim strTarjeta As String = ""
            If Not String.IsNullOrEmpty(txtTarjetaFiltroSaldo.Text.Trim()) Then
                strTarjeta = fc_FormatoTarjeta(txtTarjetaFiltroSaldo.Text.Trim(), 16)
            End If
            mt_IniciarEspere()
            olCovisol = New CovisolR.GetDatosService
            'Recupero Saldo de Tarjes Web Service
            olCovisol.Timeout = 120000 '2Minutos
            Dim loSaldo = olCovisol.getListSaldoTarjetas(mstrUsuCovisol, mstrPassCovisol, strTarjeta)
            System.Net.ServicePointManager.Expect100Continue = False
            'Left Join con lista de Vehiculos Tarjetas para sacar su placa
            Dim Grilla As List(Of e_SaldoTarjeta) = (From Saldos In loSaldo
                        Group Join VehTarjeta In loVehiculoTarjeta
                        On Saldos.ncard Equals VehTarjeta.NroTarjeta
                        Into TarjetasList = Group
                        From VehTarjeta In TarjetasList.DefaultIfEmpty()
                        Select New e_SaldoTarjeta With {.NroTarjeta = Saldos.ncard, _
                                                        .Entrada = Saldos.entrada, _
                                                        .Salida = Saldos.salida, _
                                                        .Saldo = .Entrada - .Salida, _
                                                        .Placa = If(VehTarjeta Is Nothing, String.Empty, VehTarjeta.Placa)}).ToList
            griSaldoTarjeta.DataSource = Grilla.ToList
            For Each Fila As UltraGridRow In griSaldoTarjeta.Rows
                If Convert.ToDecimal(Fila.Cells("Entrada").Value) <> 0.0 AndAlso Convert.ToDecimal(Fila.Cells("Saldo").Value) <= 500 Then
                    Fila.Appearance.BackColor = ColorTarjetaRecargar.Color
                End If
            Next
        Catch ex As Exception
            Throw ex
        Finally
            mt_TerminarEspere()
        End Try
    End Sub

    Private Sub mt_ListarMovimientos()
        Try
            Dim loVehiculoTarjeta As New List(Of e_VehiculoTarjeta)
            loVehiculoTarjeta.AddRange(olVehiculoTarjeta.Listar(New e_VehiculoTarjeta With {.TipoOperacion = "GEN", .Actual = True}))
            Dim strTarjeta As String = ""
            If Not String.IsNullOrEmpty(txtNroTarjetaFiltro.Text.Trim()) Then
                strTarjeta = fc_FormatoTarjeta(txtNroTarjetaFiltro.Text.Trim(), 16)
            End If
            mt_IniciarEspere()
            olCovisol = New CovisolR.GetDatosService
            Dim strFecIni As String = dtpDesde.Value.Date.ToString("yyyy-MM-dd hh:mm:ss")
            Dim strFecFin As String = dtpHasta.Value.AddDays(1).Date.ToString("yyyy-MM-dd hh:mm:ss")
            'Movimientos de WebService
            Dim loMovimientos = olCovisol.getListRecargas(mstrUsuCovisol, mstrPassCovisol, strTarjeta, strFecIni, strFecFin)
            System.Net.ServicePointManager.Expect100Continue = False
            'Implementado para Pruebas
            'Dim loMovimientos As List(Of e_MovimientoWeb) = GetMovimientosWebs().Where(Function(x) x.fechahora > dtpDesde.Value And x.fechahora < dtpHasta.Value).ToList
            'If Not String.IsNullOrEmpty(strTarjeta.Trim()) Then
            '    loMovimientos = loMovimientos.Where(Function(x) x.nCard = strTarjeta).ToList
            'End If

            'Movimientos Grabados
            Dim loMovientoBD As New List(Of e_TarjetaMovimiento)
            Dim olMovimientoBD As New l_TarjetaMovimiento
            loMovientoBD = olMovimientoBD.Listar(New e_TarjetaMovimiento With {.TipoOperacion = "GEN", _
                                                                               .Fecha = dtpDesde.Value.Date, _
                                                                               .FechaHasta = dtpHasta.Value.Date, _
                                                                               .NroTarjeta = strTarjeta})
            loMovimientoTarjeta.Clear()
            If loMovimientos IsNot Nothing AndAlso loMovimientos.Count > 0 Then
                'Left Join WebService con MovimientoGrabados
                loMovimientoTarjeta.AddRange((From movWeb In loMovimientos
                                Group Join movBD In loMovientoBD
                                On movWeb.nCard Equals movBD.NroTarjeta And movWeb.numero Equals movBD.Ticket
                                Into movList = Group
                                From movBD In movList.DefaultIfEmpty
                                Group Join TarjetaBD In loVehiculoTarjeta
                                On movWeb.nCard Equals TarjetaBD.NroTarjeta
                                Into TBD = Group
                                From TarjetaBD In TBD.DefaultIfEmpty
                                Select New e_TarjetaMovimiento With {.NroTarjeta = movWeb.nCard, _
                                                                     .Ticket = movWeb.numero, _
                                                                     .Fecha = movWeb.fechaHora, _
                                                                     .Monto = movWeb.cantidad, _
                                                                     .Valor = If(movBD Is Nothing, 0, movBD.Valor), _
                                                                     .Tipo = movWeb.tipo, _
                                                                     .Lugar = movWeb.lugar, _
                                                                     .Placa = movWeb.placa, _
                                                                     .PlacaISL = If(TarjetaBD Is Nothing, "", TarjetaBD.Placa), _
                                                                     .IndIngresado = If(movBD Is Nothing, False, movBD.IndIngresado), _
                                                                     .IndGuardado = If(movBD Is Nothing, False, True)}).OrderByDescending(Function(x) x.Fecha).ThenBy(Function(x) x.NroTarjeta).ToList)

            End If
            griMovimientos.DataBind()
            For Each _Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griMovimientos.Rows
                With _Fila
                    If Convert.ToBoolean(.Cells("IndGuardado").Value) Then
                        .Appearance.BackColor = Me.colorRegistrado.Color
                    Else
                        .Appearance.BackColor = Me.colorPendiente.Color
                    End If
                    If .Cells("Placa").Value.ToString().Trim().Replace("-", "") <> .Cells("PlacaISL").Value.ToString().Trim().Replace("-", "") Then
                        .Cells("Placa").Appearance.BackColor = Color.OrangeRed
                        .Cells("PlacaISL").Appearance.BackColor = Color.OrangeRed
                    End If
                End With
            Next
        Catch ex As Exception
            Throw ex
        Finally
            mt_TerminarEspere()
        End Try
    End Sub

    Private Sub mt_GuardarMasivo()
        Try
            If loMovimientoTarjeta.Where(Function(x) x.IndGuardado = False).Count > 0 Then
                For Each _MovTarjeta As e_TarjetaMovimiento In loMovimientoTarjeta.Where(Function(x) x.IndGuardado = False).ToList
                    _MovTarjeta.UsuarioCreacion = gUsuarioSGI.Id
                Next
                If olMovimientoTarjeta.GuardarMasivo(loMovimientoTarjeta.Where(Function(x) x.IndGuardado = False).ToList, gs_PrefijoIdSucursal) Then
                    MessageBox.Show("Registro realizado con exito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mt_ListarMovimientos()
                End If
            Else
                MessageBox.Show("No existen elementos para guardar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_IniciarEspere()
        Try
            'gf_AsignarEventoSeleccionarTexto()
            msjEspere = New Espere()
            ficPrincipal.SelectedTab.TabPage.Controls.Add(msjEspere)
            With msjEspere
                .Top = (Me.Height / 2) - (.Height / 2) 'Largo
                .Left = (Me.Width / 2) - (.Width / 2) 'Ancho
                .BringToFront() ' Traer al frente el Control
                .Visible = True
            End With
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_TerminarEspere()
        Try
            Cursor.Current = Cursors.Default
            Cursor.Show()
            msjEspere.Visible = False
            msjEspere = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Funciones"

    Private Function fc_FormatoTarjeta(Texto As String, Cantidad As Integer) As String
        Try
            Dim ln As String = ""
            For i As Integer = 1 To Cantidad - Texto.Length
                ln = ln + "0"
            Next
            Return ln + Texto
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function GetMovimientosWebs() As List(Of e_MovimientoWeb)
        Try
            Return New List(Of e_MovimientoWeb) From
                {
                    New e_MovimientoWeb With {.nCard = "0000000000000269", .numero = "00001588", .fechahora = #10/10/2015 3:42:00 PM#, _
                                              .cantidad = 15.1D, .tipo = "I", .lugar = "CCP", .placa = "RND-123"},
                    New e_MovimientoWeb With {.nCard = "0000000000000269", .numero = "00001589", .fechahora = #10/11/2015 4:10:05 PM#, _
                                              .cantidad = 10.1D, .tipo = "I", .lugar = "CCP", .placa = "RND-123"},
                    New e_MovimientoWeb With {.nCard = "0000000000000269", .numero = "00001590", .fechahora = #10/11/2015 10:10:05 PM#, _
                                              .cantidad = 10.1D, .tipo = "I", .lugar = "CCP", .placa = "RND-123"},
                    New e_MovimientoWeb With {.nCard = "0000000000000271", .numero = "00001560", .fechahora = #10/18/2015 10:10:05 PM#, _
                                              .cantidad = 8D, .tipo = "I", .lugar = "CCP", .placa = "ABC-123"},
                    New e_MovimientoWeb With {.nCard = "0000000000000271", .numero = "00001570", .fechahora = #10/9/2015 12:45:53 PM#, _
                                              .cantidad = 15D, .tipo = "I", .lugar = "CCP", .placa = "C0W-789"},
                    New e_MovimientoWeb With {.nCard = "0000000000000271", .numero = "00001580", .fechahora = #10/10/2015 12:30:00 PM#, _
                                              .cantidad = 15D, .tipo = "I", .lugar = "CCP", .placa = "C0W-789"},
                    New e_MovimientoWeb With {.nCard = "0000000000000271", .numero = "00001581", .fechahora = #10/11/2015 8:34:00 PM#, _
                                              .cantidad = 15D, .tipo = "I", .lugar = "CCP", .placa = "C0W-789"}
                }
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fc_VerificarUsuarioEdita() As Boolean
        Try
            Dim loRegEditados As New List(Of e_RegistrosEditados)
            oeRegEditados = New e_RegistrosEditados
            oeRegEditados.TipoOperacion = "T"
            loRegEditados.AddRange(olRegistrosEditados.Listar(oeRegEditados).ToList())
            'Si existe registro 
            oeRegEditados.PrefijoID = gs_PrefijoIdSucursal '@0001
            If loRegEditados.Count > 0 Then
                If loRegEditados.Where(Function(x) x.IndEditado).Count > 0 Then
                    'El registro esta editandose
                    MessageBox.Show("La información no es accesible, " & Environment.NewLine & _
                                "Porque esta siendo consultada " & Environment.NewLine & _
                                "Usuario: " & loRegEditados.Where(Function(x) x.IndEditado = True)(0).UsuarioEdita, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return False
                Else
                    'El registro esta creado pero esta IndEditado = 0
                    loRegEditados(0).TipoOperacion = "Z"
                    loRegEditados(0).UsuarioEdita = gUsuarioSGI.Id
                    oeRegEditados.Id = olRegistrosEditados.Guardar(loRegEditados(0))
                    Return True
                End If
            Else
                'Inserto Registro
                oeRegEditados = New e_RegistrosEditados
                With oeRegEditados
                    .TipoOperacion = "I"
                    .Referencia = "TarjetaMovimiento"
                    .UsuarioEdita = gUsuarioSGI.Id
                    .IdRegistro = "1CH000000000001"
                End With
                oeRegEditados.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeRegEditados.Id = olRegistrosEditados.Guardar(oeRegEditados)
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

End Class

#Region "Clase provisional para movimiento web service"

Public Class e_MovimientoWeb
    Public Property nCard As String
    Public Property numero As String
    Public Property placa As String
    Public Property tipo As String
    Public Property lugar As String
    Public Property fechahora As Date
    Public Property cantidad As Decimal

    Sub New()
        nCard = ""
        numero = ""
        placa = ""
        tipo = ""
        lugar = ""
        fechahora = #1/1/1901#
        cantidad = 0D
    End Sub

End Class

#End Region

#Region "Clase SaldoTarjeta"

Public Class e_SaldoTarjeta

    Public Property NroTarjeta() As String
    Public Property Entrada() As Decimal
    Public Property Salida() As Decimal
    Public Property Placa() As String
    Public Property Saldo() As Decimal

    Sub New()
        NroTarjeta = ""
        Entrada = 0D
        Salida = 0D
        Placa = ""
        Saldo = 0D
    End Sub

End Class

#End Region

