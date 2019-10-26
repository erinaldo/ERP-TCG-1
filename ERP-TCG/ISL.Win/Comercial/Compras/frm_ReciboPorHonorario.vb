'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios Centro y Giro
'=================================================================================================================


Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Public Class frm_ReciboPorHonorario

#Region "Inicializacion de Form"
    Dim _ingresando_datos As Boolean = False
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Shared instancia As frm_ReciboPorHonorario = Nothing
    Private Shared Operacion As String
    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ReciboPorHonorario
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia

    End Function
#End Region

#Region "Declaración de variables"

    Dim oeMovimientoDocumento As New e_MovimientoDocumento, olMovimientoDocumento As New l_MovimientoDocumento
    Dim lstMovReciboHonorario As New List(Of e_MovimientoDocumento)
    'Manejador de Proveedor
    Dim oeProveedor As New e_Proveedor
    Dim olProveedor As New l_Proveedor
    Dim lstProveedor As New List(Of e_Proveedor)
    'Manejador de Tipo de Documento
    Dim oeTipoDocumento As New e_TipoDocumento, olTipoDocumento As New l_TipoDocumento
    'Manejador de Moneda
    Dim oeMoneda As New e_Moneda
    Dim olMoneda As New l_Moneda
    'Manejador de Estado
    'Manejador de Estados
    Dim oeEstado As New e_Estado
    Dim olEstado As New l_Estado
    Dim llEstado As New List(Of e_Estado)
    Dim lstEstado As New List(Of e_Estado)

    Dim ls_IdTipoDocumento As String = ""

    Private oeAsientoModelo, oeAsientoModeloCmpServ As New e_AsientoModelo
    Private olAsientoModelo As New l_AsientoModelo
    Private loAsientoModelo As New List(Of e_AsientoModelo)

    Private oeReferencia As New e_AsientoModelo_Referencia
    Private olReferencia As New l_AsientoModelo_Referencia
    Private loReferencia As New List(Of e_AsientoModelo_Referencia)
    Private dtReferencia As New DataTable

    Private oeCtaCtbleCSer As New e_CtaCtbleCatServicio
    Private olCtaCtbleCSer As New l_CtaCtbleCatServicio
    Private loCtaCtbleCSer As New List(Of e_CtaCtbleCatServicio)

    Private oeEmpresaAporte As New e_EmpresaAportacion
    Private olEmpresaAporte As New l_EmpresaAportacion

    'Concepto
    Private oeConcepto As New e_Concepto
    Private olConcepto As New l_Concepto
    Private loConcepto As New List(Of e_Concepto)

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Listar(Activo)
            ControlBoton(1, 1)
            If griListaReciboHonorario.Rows.Count > 0 Then ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            Operacion = "Nuevo"
            Inicializar()
            oeMovimientoDocumento.TipoOperacion = "I"
            oeMovimientoDocumento.Compra.TipoOperacion = "I"
            oeMovimientoDocumento.Compra.IndTipoOperacion = "C"
            MostrarTabs(1, ficReciboH, 1)
            MyBase.Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Operacion = "Editar"
            EditarReciboPorHonorario()
            oeMovimientoDocumento.TipoOperacion = "A"
            oeMovimientoDocumento.Compra.TipoOperacion = "A"
            MostrarTabs(1, ficReciboH, 1)
            MyBase.Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarReciboHonorario() Then
                MyBase.Guardar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            'MostrarTabs(0, ficOrden, 2)
            'Consultar(True)

            ''Inicializar()
            If oeMovimientoDocumento.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarReciboHonorario() Then
                            MostrarTabs(0, ficReciboH, 2)
                            _ingresando_datos = False
                            Consultar(True)
                        Else
                            _ingresando_datos = True
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficReciboH, 2)
                        _ingresando_datos = False
                        Consultar(True)
                    Case Windows.Forms.DialogResult.Cancel
                        _ingresando_datos = True
                End Select
            Else
                MostrarTabs(0, ficReciboH, 2)
                _ingresando_datos = False
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If griListaReciboHonorario.ActiveRow.Cells("EstadoDocumento").Value = "GENERADA" Then
                With griListaReciboHonorario
                    oeMovimientoDocumento = New e_MovimientoDocumento
                    oeMovimientoDocumento.TipoOperacion = "COM"
                    oeMovimientoDocumento.Id = .ActiveRow.Cells("Id").Value
                    oeMovimientoDocumento = olMovimientoDocumento.ObtenerDocumentosPorCompras(oeMovimientoDocumento)
                    If MessageBox.Show("Esta seguro de eliminar el recibo por honorario: " & oeMovimientoDocumento.Serie & " - " & oeMovimientoDocumento.Numero & " ?", _
                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        oeMovimientoDocumento.TipoOperacion = "E"
                        olMovimientoDocumento.Eliminar(oeMovimientoDocumento)
                        Consultar(True)
                    End If
                End With
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If ficReciboH.Tabs(0).Selected() AndAlso griListaReciboHonorario.Rows.Count = 0 Then Throw New Exception("No hay ningún recibo por honorario para exportar al Excel")
            If ficReciboH.Tabs(0).Selected() Then Exportar_Excel(griListaReciboHonorario)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Procedimientos del Formulario"

    Private Sub Inicializar()
        Try
            oeMovimientoDocumento = New e_MovimientoDocumento
            cboProveedor.Text = ""
            cboProveedor.DataSource = Nothing
            oeMovimientoDocumento.IdTipoDocumento = ls_IdTipoDocumento
            txtSerie.Text = String.Empty
            txtNumero.Text = String.Empty
            fecRecHonorario.Value = Date.Now
            oeMovimientoDocumento.EstadoDocumento = "GENERADA"
            oeMovimientoDocumento.IdUsuarioCrea = gUsuarioSGI.Id
            txtGlosa.Text = String.Empty
            oeMovimientoDocumento.Activo = True
            oeMovimientoDocumento.IdMoneda = cboMoneda.Value
            decSubTotal.Value = 0
            decImpRenta.Value = 0
            decTotal.Value = 0
            verImpuestoRenta.Checked = False
            txtProveedor.Text = gs_TxtEmpresaSistema '@0001
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            ValidarFechaDesde_Hasta(rfReciboPorHonorarioDesde, rfReciboPorHonorarioHasta)
            oeMovimientoDocumento = New e_MovimientoDocumento
            With oeMovimientoDocumento
                .TipoOperacion = "COM"
                .Activo = True
                .IdTipoDocumento = ls_IdTipoDocumento
                If rbNroDoc.Checked Then
                    If String.IsNullOrEmpty(txtSerieI.Value) And String.IsNullOrEmpty(txtNumeroI.Value) Then Throw New Exception("Ingrese Serie o Número")
                    If Not String.IsNullOrEmpty(txtSerieI.Value) Then .Serie = FormatoDocumento(txtSerieI.Value.ToString.Trim, 4)
                    If Not String.IsNullOrEmpty(txtNumeroI.Value) Then .Numero = FormatoDocumento(txtNumeroI.Value.ToString.Trim, 10)
                Else
                    .FechaInicio = rfReciboPorHonorarioDesde.Value
                    .FechaFinal = rfReciboPorHonorarioHasta.Value
                    oeMovimientoDocumento.IdEstadoDocumento = IIf(cboEstadoRecibo.Value = "CERO", "", cboEstadoRecibo.Value)
                End If
            End With
            lstMovReciboHonorario = olMovimientoDocumento.ListarDocumentosPorCompras(oeMovimientoDocumento)
            griListaReciboHonorario.DataSource = lstMovReciboHonorario
            'Colorea la grilla de acuerdo a los estados
            For Each fila As UltraGridRow In griListaReciboHonorario.Rows
                Select Case fila.Cells("EstadoDocumento").Value
                    Case "GENERADA"
                        fila.CellAppearance.BackColor = Me.ColoresGenerado.Color
                    Case "ENVIADO"
                        fila.CellAppearance.BackColor = Me.ColoresEnviado.Color
                End Select
            Next
            With griListaReciboHonorario
                agrRH.Text = "Listado : " & .Rows.Count
                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Sub CargarCombos()
        Try
            'Estado
            oeEstado.Id = "CERO"
            oeEstado.Nombre = "TODOS"
            lstEstado.Add(oeEstado)
            oeEstado = New e_Estado
            oeEstado.Activo = True
            oeEstado.Nombre = "COMPRAS"
            lstEstado.AddRange(olEstado.Listar(oeEstado))
            LlenarComboMaestro(cboEstadoRecibo, lstEstado, 0)
            'Moneda
            oeMoneda.TipoOperacion = "1"
            oeMoneda.Activo = True
            LlenarComboMaestro(cboMoneda, olMoneda.Listar(oeMoneda), 0)

            'TipoDocumento
            oeTipoDocumento = New e_TipoDocumento
            oeTipoDocumento.Id = "1CH000000043"
            oeTipoDocumento = olTipoDocumento.Obtener(oeTipoDocumento)
            ls_IdTipoDocumento = oeTipoDocumento.Id

            'cargar IMPORTE/PORCENTAJE RH 
            loConcepto = New List(Of e_Concepto)
            oeConcepto = New e_Concepto
            oeConcepto.Activo = True
            oeConcepto.Prefijo = "39"
            loConcepto = olConcepto.Listar(oeConcepto)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Validar_ExistenciaComprobante()
        Try
            Dim oeMovDocAUx As New e_MovimientoDocumento
            Dim lst_MovDocAUx As New List(Of e_MovimientoDocumento)
            oeMovDocAUx.IdTipoDocumento = "1CH000000043"
            oeMovDocAUx.Serie = txtSerie.Value
            oeMovDocAUx.Numero = CStr(CInt(txtNumero.Value))
            oeMovDocAUx.IdClienteProveedor = cboProveedor.Value
            oeMovDocAUx.TipoOperacion = "VDC"
            oeMovDocAUx.IndCompraVenta = 1
            lst_MovDocAUx = olMovimientoDocumento.Listar(oeMovDocAUx)
            If lst_MovDocAUx.Count > 0 Then Throw New Exception("El comprobante " & txtSerie.Value & "-" & txtNumero.Value & " de " & cboProveedor.Text & " ya ha sido registrado.")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GuardarReciboHonorario() As Boolean
        Try
            If cboMoneda.Value <> "1CH01" And (decTC.Value = 0) Then
                Throw New Exception("Ingresar Tipo de Cambio")
            End If
            gfc_ValidarSerieDoc(txtSerie.Text, "02")
            gfc_ValidarNumeroDoc(txtNumero.Text, "02")
            If oeMovimientoDocumento.TipoOperacion = "I" Then Validar_ExistenciaComprobante()
            With oeMovimientoDocumento
                .Tipo = "RECIBOPORHONORARIO"
                .IndCompraVenta = 1
                .Mac_PC_Local = MacPCLocal()
                .IdMoneda = cboMoneda.Value
                .TipoCambio = decTC.Value
                .IdClienteProveedor = cboProveedor.Value
                .Compra.IdTipoPago = "1SI000000001"
                .Compra.Base1 = 0
                .Compra.NoGravadas = IIf(cboMoneda.Value = "1CH01", decTotal.Value, decTotal.Value * decTC.Value)
                '.TipoCambio = TipoCambio(fecRecHonorario.Value, 1)(0)
                If Not String.IsNullOrEmpty(txtSerie.Value) Then .Serie = FormatoDocumento(txtSerie.Value.ToString.Trim, 4)
                If Not String.IsNullOrEmpty(txtNumero.Value) Then .Numero = FormatoDocumento(txtNumero.Value.ToString.Trim, 10)
            End With
            If oeMovimientoDocumento.TipoCambio = 0 Then Throw New Exception("Tipo de Cambio no puede Ser 0. Verificar")
            ' If oeMovimientoDocumento.FechaEmision >= Date.Parse("01/08/2014") Then ObtenerAportes()
            oeMovimientoDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olMovimientoDocumento.Guardar(oeMovimientoDocumento) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                Consultar(True)
                MostrarTabs(0, ficReciboH, 1)
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EditarReciboPorHonorario() As Boolean
        Try
            Inicializar()
            If griListaReciboHonorario.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                oeMovimientoDocumento.TipoOperacion = "COM"
                oeMovimientoDocumento.Id = griListaReciboHonorario.ActiveRow.Cells("Id").Value
                oeMovimientoDocumento.IdClienteProveedor = String.Empty
                oeMovimientoDocumento = olMovimientoDocumento.ObtenerDocumentosPorCompras(oeMovimientoDocumento)
                ListarProveedores(cboProveedor, oeMovimientoDocumento.IdClienteProveedor)
                cboProveedor.Value = oeMovimientoDocumento.IdClienteProveedor
                txtSerie.Value = oeMovimientoDocumento.Serie
                txtNumero.Value = oeMovimientoDocumento.Numero
                fecRecHonorario.Value = oeMovimientoDocumento.FechaEmision
                cboMoneda.Value = oeMovimientoDocumento.IdMoneda
                decTotal.Value = oeMovimientoDocumento.Total
                decSubTotal.Value = oeMovimientoDocumento.SubTotal
                decImpRenta.Value = oeMovimientoDocumento.ImpuestoRenta
                txtGlosa.Value = oeMovimientoDocumento.Glosa
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Sub EnviaATesoreria()
        Try
            If Not griListaReciboHonorario.ActiveRow Is Nothing AndAlso griListaReciboHonorario.ActiveRow.Cells("ID").Value.ToString.Length > 0 Then
                Dim frm As New Frm_PeriodoTipoAsiento(True, False, False, "CMP")
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    oeMovimientoDocumento = New e_MovimientoDocumento
                    oeMovimientoDocumento.Id = griListaReciboHonorario.ActiveRow.Cells("Id").Value
                    oeMovimientoDocumento = olMovimientoDocumento.Obtener(oeMovimientoDocumento)
                    Dim oeTipDoc As New e_TipoDocumento
                    olTipoDocumento = New l_TipoDocumento
                    oeTipDoc.Id = oeMovimientoDocumento.IdTipoDocumento
                    oeTipDoc = olTipoDocumento.Obtener(oeTipDoc)
                    oeMovimientoDocumento.Compra.TipoDoc = oeTipDoc
                    If oeMovimientoDocumento.EstadoDocumento = gNombreEstadoEnviado Then Throw New Exception("El Documento ya ha Sido Enviado. Verificar")
                    If oeMovimientoDocumento.FechaEmision.Year <> frm.Año1.Año Then Throw New Exception("Los años no son iguales. No se puede Enviar la Compra")
                    If oeMovimientoDocumento.FechaEmision.Month > CInt(frm.cboMes.Text) Then Throw New Exception("El mes de emision es Mayor al Periodo. No se puede Enviar la Compra")
                    Dim oePeriodo As New e_Periodo, olPeriodo As New l_Periodo
                    oePeriodo.Id = frm.cboMes.Value
                    oePeriodo.Ejercicio = frm.Año1.Año
                    oePeriodo.TipoOperacion = String.Empty : oePeriodo.Activo = True
                    oePeriodo = olPeriodo.Obtener(oePeriodo)
                    oeMovimientoDocumento.FechaFinal = oePeriodo.FechaFin
                    oeMovimientoDocumento.IdPeriodo = frm.cboMes.Value
                    oeMovimientoDocumento.Ejercicio = frm.Año1.Año
                    oeMovimientoDocumento.IndOrigenContable = 2 'Doc Logístico
                    oeMovimientoDocumento.loCtaCtbleCSer = New List(Of e_CtaCtbleCatServicio)
                    oeMovimientoDocumento.loCtas = New List(Of e_Combo)
                    oeMovimientoDocumento.loCtas.AddRange(CtaCtblePublic)
                    oeMovimientoDocumento.loCtaCtbleCSer = LlenaCuentaCatServicio(oeMovimientoDocumento, loCtaCtbleCSer, oeMovimientoDocumento.Ejercicio)
                    oeMovimientoDocumento.IdUsuarioCrea = gUsuarioSGI.Id
                    ObtenerAsientoModelo(oeMovimientoDocumento.IdMoneda, oeMovimientoDocumento.Ejercicio)
                    oeMovimientoDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
                    olMovimientoDocumento.GuardarCmpServicio(oeMovimientoDocumento)
                    'olMovimientoDocumento.InterfazCompra(oeMovimientoDocumento)
                    mensajeEmergente.Confirmacion("Se Envió Correctamente", True)
                    Listar(True)
                End If
            Else
                mensajeEmergente.Problema("Seleccione un Documento")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Public Sub ObtenerAportes()
    '    Try
    '        oeEmpresaAporte = New e_EmpresaAportacion
    '        oeEmpresaAporte.IdEmpresa = oeMovimientoDocumento.IdClienteProveedor
    '        oeEmpresaAporte = olEmpresaAporte.Obtener(oeEmpresaAporte)
    '        If oeEmpresaAporte.Id = "" Then
    '            Dim frm As New frm_EmpresaAportacion
    '            frm.IdEmpresa = oeMovimientoDocumento.IdClienteProveedor
    '            frm.ShowDialog()
    '            ControlBoton(0, 0, 0, 1, 1)
    '            oeEmpresaAporte = New e_EmpresaAportacion
    '            oeEmpresaAporte.IdEmpresa = oeMovimientoDocumento.IdClienteProveedor
    '            oeEmpresaAporte = olEmpresaAporte.Obtener(oeEmpresaAporte)
    '        End If
    '        If oeEmpresaAporte.Id = "" Then Throw New Exception("Tiene Que Registrar los Datos de AFP del Proveedor")
    '        Dim loHistorialRH As New List(Of e_Combo)
    '        loHistorialRH.AddRange(ListaRH(oeEmpresaAporte.IdEmpresa, oeMovimientoDocumento.FechaEmision))
    '        If oeEmpresaAporte.FechaNacimiento.Date >= Date.Parse("01/08/1973") Then
    '            Dim Total As Double = 0
    '            Total = loHistorialRH.Sum(Function(i) i.Descripcion) + oeMovimientoDocumento.Total
    '            If Total >= 750 Then
    '                If loHistorialRH.Count > 0 Then
    '                    If MessageBox.Show("No Puede Ingresar el Documento, MontoSuperado. Desea ver el Detalle?", "Mensaje de Sistema", _
    '                                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
    '                        Dim frm As New frm_DetalleCajaExterna
    '                        frm.MostrarDetalle("3", Nothing, Nothing, Nothing, loHistorialRH)
    '                        frm.ShowDialog()
    '                    End If
    '                End If
    '                Throw New Exception("No puede Ingresar RH se ha Superado el Monto sin Retencion ")
    '            End If

    '        End If
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

#End Region

#Region "Eventos del Formulario"

    Private Sub txtGlosa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa.ValueChanged
        oeMovimientoDocumento.Compra.Glosa = txtGlosa.Text
    End Sub

    Private Sub fecRecHonorario_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles fecRecHonorario.Validated
        If decTC.Value = 0 Then
            decTC.Value = TipoCambio(fecRecHonorario.Value)(0)
        Else
            If MessageBox.Show("Desea Cambiar al Tipo de Cambio del dia?", "Mensaje del sistema", _
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) _
            = Windows.Forms.DialogResult.Yes Then
                decTC.Value = TipoCambio(fecRecHonorario.Value)(0)
            End If
        End If
    End Sub

    Private Sub fecRecHonorario_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecRecHonorario.ValueChanged
        oeMovimientoDocumento.FechaEmision = fecRecHonorario.Value
        oeMovimientoDocumento.FechaVencimiento = fecRecHonorario.Value
    End Sub

    Private Sub decSubTotal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decSubTotal.ValueChanged
        oeMovimientoDocumento.SubTotal = decSubTotal.Value
        oeMovimientoDocumento.Compra.Base1 = oeMovimientoDocumento.SubTotal
        If decSubTotal.Value > decImpRenta.Value Then
            decTotal.Value = decSubTotal.Value - decImpRenta.Value
        End If
    End Sub

    Private Sub decTotal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decTotal.ValueChanged
        oeMovimientoDocumento.Total = decTotal.Value
        oeMovimientoDocumento.Saldo = decTotal.Value
    End Sub

    Private Sub cboMoneda_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMoneda.ValueChanged
        oeMovimientoDocumento.IdMoneda = cboMoneda.Value
    End Sub

    Private Sub griListaReciboHonorario_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaReciboHonorario.CellChange
        griListaReciboHonorario.UpdateData()
    End Sub

    Private Sub griListaReciboHonorario_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griListaReciboHonorario.DoubleClick
        If griListaReciboHonorario.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub verImpuestoRenta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verImpuestoRenta.CheckedChanged
        If verImpuestoRenta.Checked Then

            If loConcepto.Count <> 1 Then Throw New Exception("No se ha encontrado Importe/Porcentaje para la retención RH")


            If oeMovimientoDocumento.SubTotal > loConcepto(0).Valor1 Then
                oeMovimientoDocumento.Compra.ImpuestoRenta = CDec(oeMovimientoDocumento.SubTotal) * loConcepto(0).Valor2 / 100
                decTotal.Value = oeMovimientoDocumento.SubTotal - oeMovimientoDocumento.Compra.ImpuestoRenta
            Else
                oeMovimientoDocumento.Compra.ImpuestoRenta = 0
            End If
        Else
            decImpRenta.Value = 0
            decTotal.Value = 0
            oeMovimientoDocumento.Compra.ImpuestoRenta = 0
        End If
        decImpRenta.Value = oeMovimientoDocumento.Compra.ImpuestoRenta
    End Sub

    Private Sub decImpRenta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decImpRenta.ValueChanged
        If decSubTotal.Value > decImpRenta.Value Then
            decTotal.Value = decSubTotal.Value - decImpRenta.Value
        End If

    End Sub

    Private Sub cboProveedor_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboProveedor.InitializeLayout
        Me.cboProveedor.ValueMember = "Id"
        Me.cboProveedor.DisplayMember = "Nombre"
        With cboProveedor.DisplayLayout.Bands(0)
            .Columns("Id").Hidden = True
            .Columns("Email").Hidden = True
            .Columns("Seleccion").Hidden = True
            .Columns("Contacto").Hidden = True
            .Columns("Codigo").Hidden = True
            .Columns("TipoPersonaEmpresa").Hidden = True
            .Columns("IdPersona").Hidden = True
            .Columns("IdEmpresa").Hidden = True
            .Columns("FechaActividad").Hidden = True
            .Columns("UsuarioCreacion").Hidden = True
            .Columns("Activo").Hidden = True
            .Columns("NroDocumento").Header.Caption = "N° RUC"
            .Columns("NroDocumento").Width = 50
            .Columns("Nombre").Width = 150
        End With
    End Sub

    Private Sub cboProveedor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboProveedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            ListarProveedores(cboProveedor, "0", chkRuc.Checked)
        End If
    End Sub

    Private Sub cboProveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboProveedor.KeyPress
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                cboProveedor.PerformAction(UltraComboAction.Dropdown)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtSerieI_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerieI.Validated
        If Not String.IsNullOrEmpty(txtSerieI.Text) Then txtSerieI.Text = FormatoDocumento(txtSerieI.Text, 4)
    End Sub

    Private Sub txtNumeroI_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNumeroI.KeyDown
        If e.KeyCode = Keys.Enter Then
            Consultar(True)
        End If
    End Sub

    Private Sub txtNumeroI_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumeroI.Validated
        If Not String.IsNullOrEmpty(txtNumeroI.Text) Then txtNumeroI.Text = FormatoDocumento(txtNumeroI.Text, 10)
    End Sub

    Private Sub txtSerie_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerie.Validated
        If Not String.IsNullOrEmpty(txtSerie.Text) Then txtSerie.Text = FormatoDocumento(txtSerie.Text, 4)
    End Sub

    Private Sub txtNumero_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.Validated
        If Not String.IsNullOrEmpty(txtNumero.Text) Then txtNumero.Text = FormatoDocumento(txtNumero.Text, 10)
    End Sub

    Private Sub rbNroDoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNroDoc.CheckedChanged
        gbOI.Enabled = rbNroDoc.Checked
        txtSerie.Focus()
    End Sub

    Private Sub rbDatosAdicionales_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDatosAdicionales.CheckedChanged
        gbDatosAdicionales.Enabled = rbDatosAdicionales.Checked
        txtSerieI.Text = String.Empty
        txtNumeroI.Text = String.Empty
    End Sub

    Private Sub cmdEnviaTesoreria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEnviaTesoreria.Click
        Try
            EnviaATesoreria()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaReciboHonorario_AfterRowActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaReciboHonorario.AfterRowActivate
        cmdEnviaTesoreria.Enabled = 0
        If griListaReciboHonorario.ActiveRow.Index > -1 Then
            If griListaReciboHonorario.ActiveRow.Cells("EstadoDocumento").Value = "GENERADA" Then
                cmdEnviaTesoreria.Enabled = 1
            End If
        End If
    End Sub

    Private Sub frm_ReciboPorHonorario_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case Operacion
            Case "Editar"
                MyBase.Editar()
            Case "Vista"
                MyBase.Vista()
            Case "Inicializa"
                Tiempo1.Enabled = False
                ControlBoton(1, 1)
                If griListaReciboHonorario.Rows.Count > 0 Then ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                InicializaTiempo()
        End Select
    End Sub

    Private Sub frm_ReciboPorHonorario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ReciboPorHonorario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case Operacion
            Case "Nuevo", "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_ReciboPorHonorario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        gf_AsignarEventoSeleccionarTexto(Me)
        gmt_ConfigurarEventoKeyEnter_Tab(Me, txtNumeroI.Name, cboProveedor.Name)
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        ColoresGenerado.Color = Color.White
        ColoresEnviado.Color = Color.LightGreen
        CargarCombos()
        MostrarTabs(0, ficReciboH)
        rfReciboPorHonorarioHasta.Value = Date.Now
        rfReciboPorHonorarioDesde.Value = Date.Now.AddDays(-7)
        AsientosContablesServicio()
        ListarProveedores(cboProveedor, "1")
    End Sub

#End Region

#Region "Menú contextual"
    Private Sub MenuContextual2_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual2.Opening
        MenuContextual2.Items("NuevoToolStripMenuItem1").Visible = 1
        MenuContextual2.Items("ActualizarToolStripMenuItem2").Visible = 0
        MenuContextual2.Items("EliminarToolStripMenuItem3").Visible = 0
        MenuContextual2.Items("EnviarTesoreriaToolStripMenuItem").Visible = 0
        If griListaReciboHonorario.Selected.Rows.Count > 0 Then
            If griListaReciboHonorario.ActiveRow.Cells("EstadoDocumento").Value = "GENERADA" Then
                MenuContextual2.Items("EnviarTesoreriaToolStripMenuItem").Visible = 1
                MenuContextual2.Items("ActualizarToolStripMenuItem2").Visible = 1
                MenuContextual2.Items("EliminarToolStripMenuItem3").Visible = 1
            Else
                MenuContextual2.Items("EnviarTesoreriaToolStripMenuItem").Visible = 0
                MenuContextual2.Items("ActualizarToolStripMenuItem2").Visible = 0
                MenuContextual2.Items("EliminarToolStripMenuItem3").Visible = 0
            End If
        End If
    End Sub
    Private Sub NuevoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem1.Click
        Nuevo()
    End Sub

    Private Sub ActualizarToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem2.Click
        Editar()
    End Sub

    Private Sub EliminarToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem3.Click
        Eliminar()
    End Sub

    Private Sub EnviarTesoreriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnviarTesoreriaToolStripMenuItem.Click
        EnviaATesoreria()
    End Sub

#End Region

#Region "Valida Solo Ingrese Numeros"

    'Private Sub txtSerie_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerie.KeyPress
    '    'If Char.IsDigit(e.KeyChar) Then
    '    '    e.Handled = False
    '    'ElseIf Char.IsControl(e.KeyChar) Then
    '    '    e.Handled = False
    '    'Else
    '    '    e.Handled = True
    '    'End If

    '    If Char.IsLetter(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsSeparator(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsDigit(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If
    'End Sub

    Private Sub txtNumero_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtSerieI_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerieI.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumeroI_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeroI.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

#End Region

#Region "Asientos Contables"

    Public Sub AsientosContablesServicio()
        Try
            AsientoModelo()
            CtaCtbleCatServicio()
            dtReferencia = GeneraDTRef(loReferencia)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AsientoModelo()
        oeAsientoModelo = New e_AsientoModelo
        loAsientoModelo = New List(Of e_AsientoModelo)
        oeAsientoModelo.TipoOperacion = "A" : oeAsientoModelo.Activo = True : oeAsientoModelo.Nombre = pIdActividadNegocio
        loAsientoModelo = olAsientoModelo.Listar(oeAsientoModelo)

        oeReferencia = New e_AsientoModelo_Referencia
        loReferencia = New List(Of e_AsientoModelo_Referencia)
        oeReferencia.TipoOperacion = "N" : oeReferencia.Activo = True : oeReferencia.IdReferencia = pIdActividadNegocio
        loReferencia = olReferencia.Listar(oeReferencia)
    End Sub

    Private Sub CtaCtbleCatServicio()
        oeCtaCtbleCSer = New e_CtaCtbleCatServicio
        loCtaCtbleCSer = olCtaCtbleCSer.Listar(oeCtaCtbleCSer)
    End Sub

    Public Sub ObtenerAsientoModelo(IdMoneda As String, Ejercicio As Integer)
        Try
            oeMovimientoDocumento.loAsientoModelo = New List(Of e_AsientoModelo)
            Dim dtAux = New Data.DataTable
            Dim _rwAux() As Data.DataRow
            Dim cadSQL As String = String.Empty
            cadSQL = "TipoRef1 = 4 AND IdRef1 = '" & IdMoneda & "' AND TipoRef2 = 10 AND IdRef2 = '1PK000000003' "
            _rwAux = dtReferencia.Select(cadSQL, "")
            If _rwAux.Count = 0 Then Throw New Exception("Error en el Modelo de Asiento Contable. Verificar")
            dtAux = _rwAux.CopyToDataTable
            oeAsientoModeloCmpServ = New e_AsientoModelo
            oeAsientoModeloCmpServ.TipoOperacion = "" : oeAsientoModeloCmpServ.Activo = True
            oeAsientoModeloCmpServ.Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString
            oeAsientoModeloCmpServ.Ejercicio = Ejercicio
            oeAsientoModeloCmpServ = olAsientoModelo.Obtener(oeAsientoModeloCmpServ)
            oeMovimientoDocumento.loAsientoModelo.Add(oeAsientoModeloCmpServ)
            For Each oe As e_DetalleAsientoModelo In oeAsientoModeloCmpServ.leDetalle
                If oe.IndDocumento Then
                    oeMovimientoDocumento.IdCuentaContable = oe.IdCuentaContable.Trim
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class
