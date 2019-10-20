'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win
Public Class frm_DocumentoVenta
    Inherits ISL.Win.frm_MenuPadre

#Region "Declaracion de Variables"
    Private WithEvents oeDocumentoVenta As New e_DocumentoVenta
    Dim olDocumentoVenta As New l_DocumentoVenta

    Dim oeCorrelativo As New e_Correlativo
    Dim olCorrelativo As New l_Correlativo

    Dim oeDocumentoVentaDetalle As New e_DocumentoVentaDetalle
    Dim olDocumentoVentaDetalle As New l_DocumentoVentaDetalle

    Dim oeDemanda As New e_Demanda
    Dim olDemanda As New l_Demanda

    Dim oeDemandaDetalle As New e_DemandaDetalle

    Dim oeTipoDocumento As New e_TipoDocumento
    Dim olTipoDocumento As New l_TipoDocumento

    Dim oeTipoPago As New e_TipoPago
    Dim olTipoPago As New l_TipoPago

    Dim oeMoneda As New e_Moneda
    Dim olMoneda As New l_Moneda

    Dim oeMaterial As New e_Material
    Dim olMaterial As New l_Material

    Dim oeTipoCarga As New e_TipoCarga
    Dim olTipoCarga As New l_TipoCarga

    Dim oeTrabajador As New e_Trabajador
    Dim olTrabajador As New l_Trabajador

    Dim oeCliente As New e_Cliente
    Dim olCliente As New l_Cliente

    Dim oeIgv As New e_Impuesto
    Dim OlIgv As New l_Impuesto

    Dim oeCuentaTrabajador As New e_CuentaCorriente
    Dim olCuentaCorriente As New l_CuentaCorriente

    Dim PorcentajeDescuento As Decimal
    Dim PorcentajeDetraccion As Decimal

    Dim _ingresando_datos As Boolean = False

    Private olPersona As New l_Persona

    Private Shared instancia As frm_DocumentoVenta = Nothing
    Private Shared Operacion As String

#Region "Instancia"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    ''' <summary>
    ''' Instancia unica de Formulario: frm_DocumentoVenta
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function getInstancia() As frm_MenuPadre
        Operacion = "Inicializa"
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_DocumentoVenta()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#End Region

#Region "BOTONES"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Tiempo1.Enabled = True
            'Operacion = "Inicializa"
            If griDemanda.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
                griDemanda.Focus()
            Else
                MyBase.Consultar()
            End If

            Select Case FicDocumentoVenta.SelectedTab.Index
                Case 0
                    ListarDemanda()
                Case 1
                    ListarVenta()
            End Select

            'InicializaTiempo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub ListarVenta()
        Try
            oeDocumentoVenta.TipoOperacion = "2"
            oeDocumentoVenta.FechaDesde = rgFecha.Desde
            oeDocumentoVenta.FechaHasta = rgFecha.Hasta
            oeDocumentoVenta.Activo = True
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            With griDocumentoVenta
                .ResetDisplayLayout()
                .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
                .DisplayLayout.Override.RowSelectorHeaderStyle = UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
                .DataSource = olDocumentoVenta.Listar(oeDocumentoVenta)
                .DisplayLayout.Bands(0).Columns.Add("Selec", "Seleccionar")
                .DisplayLayout.Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
                .DisplayLayout.Bands(0).Columns("Selec").DefaultCellValue = False
                .DisplayLayout.Bands(0).Columns("Selec").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Selec").Width = 37
                .DisplayLayout.Bands(0).Columns("Moneda").Width = 51
                .DisplayLayout.Bands(0).Columns("Serie").Width = 56
                .DisplayLayout.Bands(0).Columns("Numero").Width = 92
                .DisplayLayout.Bands(0).Columns("NombreCliente").Width = 270
                .DisplayLayout.Bands(0).Columns("Serie").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Numero").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("TipoDocumento").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("TipoPago").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("NombreCliente").Header.VisiblePosition = 6
            End With

            With griDocumentoVenta.DisplayLayout.Bands(0)
                .Columns("Id").Hidden = True
                .Columns("IdCliente").Hidden = True
                .Columns("IdCuentaCorriente").Hidden = True
                .Columns("FechaCreacion").Hidden = True
                .Columns("IdEstado").Hidden = True
                .Columns("IdMoneda").Hidden = True
                .Columns("IdReferencia").Hidden = True
                .Columns("IdTipoDocumento").Hidden = True
                .Columns("IdTipoPago").Hidden = True
                .Columns("UsuarioCreacion").Hidden = True
                .Columns("Activo").Hidden = True
                .Columns("PorcentajeDetraccion").Hidden = True
                .Columns("PorcentajeDescuento").Hidden = True
                .Columns("PorcentajeIgv").Hidden = True
                .Columns("SubTotal").Hidden = True
            End With

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
        End Try

    End Sub

    Public Overrides Sub Nuevo()
        InicializaDocumento()
        Inicializa()
        VerificarSeleccion()
        CargarCorrelativo()
        verIgv.Checked = True
        oeDocumentoVenta.TipoOperacion = "I"
        MostrarTabs(2, FicDocumentoVenta)
        MyBase.Nuevo()
    End Sub

    Private Sub VerificarSeleccion()

        Dim Fila As Integer
        Dim Cliente As String = ""
        Dim Glosa As String = "DOCUMENTO ASOCIANDO DEMANDA N: "
        Dim Cant_Cliente As Integer
        griDemanda.UpdateData()
        Cant_Cliente = 0
        For Each grilla As Infragistics.Win.UltraWinGrid.UltraGridRow In griDemanda.Rows
            If grilla.Cells("Seleccion").Value = True Then
                For Each grilla2 As Infragistics.Win.UltraWinGrid.UltraGridRow In griDemanda.Rows
                    If grilla2.Cells("Seleccion").Value = True Then
                        If grilla.Cells("Cliente").Value.ToString <> grilla2.Cells("Cliente").Value.ToString Then
                            Cant_Cliente = 1
                            Exit For
                        Else
                            cboCliente.Value = grilla.Cells("IdCliente").Value
                        End If
                    End If
                Next
                If Cant_Cliente = 1 Then
                    cboCliente.Value = String.Empty
                    Exit For
                End If
            End If
        Next

        If Cant_Cliente = 0 Then
            For Each grilla As Infragistics.Win.UltraWinGrid.UltraGridRow In griDemanda.Rows
                If grilla.Cells("Seleccion").Value = True Then
                    griDocumentoVentaDetalle.DisplayLayout.Bands(0).AddNew()
                    Fila = griDocumentoVentaDetalle.Rows.Count - 1
                    With griDocumentoVentaDetalle.Rows(Fila)
                        .Cells("TipoReferencia").Value = 1
                        .Cells("Tipo").Value = "Demanda"
                        .Cells("IdReferencia").Value = grilla.Cells("Id").Value
                        .Cells("Descripcion").Value = grilla.Cells("Codigo").Value & " Ruta: " & grilla.Cells("Ruta").Value
                        .Cells("Cantidad").Value = 1
                        .Cells("Precio").Value = grilla.Cells("TotalFlete").Value
                        .Cells("SubTotal").Value = .Cells("Cantidad").Value * .Cells("Precio").Value
                        Glosa = Glosa & grilla.Cells("Codigo").Value & ".  "
                    End With
                End If
            Next
            txtConcepto.Text = Glosa
            CalcularTotales()
            MostrarTabs(2, FicDocumentoVenta, 1)

        ElseIf Cant_Cliente = 1 Then
            Select Case MessageBox.Show("Ha seleccionado Clientes diferentes, ¿Desea Facturar estas Demandas? " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                Case Windows.Forms.DialogResult.Yes
                    For Each grilla As Infragistics.Win.UltraWinGrid.UltraGridRow In griDemanda.Rows
                        If grilla.Cells("Seleccion").Value = True Then
                            griDocumentoVentaDetalle.DisplayLayout.Bands(0).AddNew()
                            Fila = griDocumentoVentaDetalle.Rows.Count - 1
                            With griDocumentoVentaDetalle.Rows(Fila)
                                .Cells("TipoReferencia").Value = 1
                                .Cells("Tipo").Value = "Demanda"
                                .Cells("IdReferencia").Value = grilla.Cells("Id").Value
                                .Cells("Descripcion").Value = grilla.Cells("Codigo").Value & " Ruta: " & grilla.Cells("Ruta").Value
                                .Cells("Cantidad").Value = 1
                                .Cells("Precio").Value = grilla.Cells("TotalFlete").Value
                                .Cells("SubTotal").Value = .Cells("Cantidad").Value * .Cells("Precio").Value
                                Glosa = Glosa & grilla.Cells("Codigo").Value & ".  "
                            End With
                        End If
                    Next
                    txtConcepto.Text = Glosa
                    CalcularTotales()
                    MostrarTabs(2, FicDocumentoVenta, 1)
                Case Windows.Forms.DialogResult.No
                    griDemanda.UpdateData()
            End Select
        End If

    End Sub

    Private Sub CalcularTotales()

        decSubTotal.Value = 0
        decTotalFacturado.Value = 0

        For Each grilla As Infragistics.Win.UltraWinGrid.UltraGridRow In griDocumentoVentaDetalle.Rows
            decTotalFacturado.Value = decTotalFacturado.Value + grilla.Cells("SubTotal").Value
        Next

        decSubTotal.Value = decTotalFacturado.Value
        decSaldo.Value = decTotalFacturado.Value

    End Sub

    Public Overrides Sub Editar()

    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarDocumentoVenta() Then
                Inicializa()
                MyBase.Guardar()
            Else
                MostrarTabs(2, FicDocumentoVenta, 2)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function GuardarDocumentoVenta() As Boolean
        Try
            If MessageBox.Show("Efectivo es menor al Monto Facturado, esto generará una cuenta por cobrar ", "Mensaje del Sistema", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then

                Return False
            Else

                If decTotalEfectivo.Value < decTotalFacturado.Value Then
                    cboTipoPago.Text = "CREDITO"
                Else
                    cboTipoPago.Text = "CONTADO"
                End If

                For Each grilla As Infragistics.Win.UltraWinGrid.UltraGridRow In griDocumentoVentaDetalle.Rows
                    Dim oeDocumentoVentaDetalle As New e_DocumentoVentaDetalle
                    With oeDocumentoVentaDetalle
                        .Id = grilla.Cells("Id").Value.ToString
                        .TipoReferencia = grilla.Cells("TipoReferencia").Value.ToString
                        .IdReferencia = grilla.Cells("IdReferencia").Value.ToString
                        .Descripcion = grilla.Cells("Descripcion").Value.ToString
                        .Cantidad = grilla.Cells("Cantidad").Value
                        .Precio = grilla.Cells("Precio").Value
                        .SubTotal = grilla.Cells("SubTotal").Value
                        .UsuarioCreacion = gUsuarioSGI.Id
                        .Activo = True
                        .PrefijoID = gs_PrefijoIdSucursal '@0001
                        oeDocumentoVenta.loDocumentoVentaDetalle.Add(oeDocumentoVentaDetalle)
                    End With
                Next
                oeDocumentoVenta.PrefijoID = gs_PrefijoIdSucursal '@0001
                If olDocumentoVenta.Guardar(oeDocumentoVenta) Then
                    mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                    Consultar(True)
                    MostrarTabs(0, FicDocumentoVenta, 1)
                    LimpiaGrid(griDocumentoVentaDetalle, ogdDocumentoVentaDetalle)
                    griDocumentoVenta.Focus()
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Public Overrides Sub Cancelar()
        Try

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            'MyBase.Eliminar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
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
            If FicDocumentoVenta.SelectedTab.Index = 0 AndAlso griDemanda.Rows.Count = 0 Then Throw New Exception("No hay ninguna operación para exportar al Excel")
            If FicDocumentoVenta.SelectedTab.Index = 0 Then Exportar_Excel(griDemanda)

            If FicDocumentoVenta.SelectedTab.Index = 1 AndAlso griDocumentoVenta.Rows.Count = 0 Then Throw New Exception("No hay ningún documento de venta para exportar al Excel")
            If FicDocumentoVenta.SelectedTab.Index = 1 Then Exportar_Excel(griDocumentoVenta)

            If FicDocumentoVenta.SelectedTab.Index = 1 AndAlso griListaDetalle.Rows.Count = 0 Then Throw New Exception("No hay ningún detalle del documento de venta para exportar al Excel")
            If FicDocumentoVenta.SelectedTab.Index = 1 Then Exportar_Excel(griListaDetalle)

            If FicDocumentoVenta.SelectedTab.Index = 2 AndAlso griDocumentoVentaDetalle.Rows.Count = 0 Then Throw New Exception("No hay ningún detalle del documento de venta para exportar al Excel")
            If FicDocumentoVenta.SelectedTab.Index = 2 Then Exportar_Excel(griDocumentoVentaDetalle)

            MyBase.Exportar()

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Public Sub ListarDemanda()
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeDemanda.Activo = True
            oeDemanda.TipoOperacion = "4"
            griDemanda.DataSource = olDemanda.Listar(oeDemanda)
            griDemanda.DisplayLayout.Bands(0).Columns("IdCliente").Hidden = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
        End Try
    End Sub
#End Region

#Region "Eventos"

    Private Sub CargarCorrelativo()
        Dim Serie As String = ""
        Dim Numero As String = ""
        oeCorrelativo.TipoOperacion = "1"
        oeCorrelativo.IdTipoDocumento = cboTipoDocumento.Value
        oeCorrelativo = olCorrelativo.Obtener(oeCorrelativo)
        Numero = oeCorrelativo.Numero + 1

        Do While Len(Numero) < 10
            Numero = 0 & Numero
        Loop

        Select Case oeCorrelativo.Prefijo
            Case "1CH"
                Serie = "1"
                oeCorrelativo.Serie = 1
            Case "1PY"
                Serie = "2"
                oeCorrelativo.Serie = 2
            Case "1LI"
                Serie = "3"
                oeCorrelativo.Serie = 1
            Case "1SA"
                Serie = "4"
                oeCorrelativo.Serie = 1
            Case "1LU"
                Serie = "4"
                oeCorrelativo.Serie = 1
            Case Else
                Serie = "9"
                oeCorrelativo.Serie = 1
        End Select


        Do While Len(Serie) < 4
            Serie = 0 & Serie
        Loop

        txtSerie.Text = Serie
        txtNumero.Text = Numero

    End Sub

    Private Sub Inicializa()
        cboCliente.SelectedIndex = -1
        cboMoneda.SelectedIndex = 0
        cboTipoDocumento.SelectedIndex = 0
        cboTipoPago.SelectedIndex = 0
        cboCuentaCorrienteTrabajador.SelectedIndex = -1
        txtConcepto.Text = String.Empty
        txtSerie.Text = String.Empty
        txtNumero.Text = String.Empty
        fecFechaEmision.Value = Date.Today
        fecFechaVencimiento.Value = Date.Today
        decTotalEfectivo.Value = Decimal.Zero
        verTrabajadorAsignado.Checked = False
        agrTrabajadorAsignado.Visible = False
        picRecibidor.Image = Nothing
        etiDni.Text = String.Empty
        etiNombre.Text = String.Empty
        etiNumeroCuenta.Text = String.Empty
        etiSaldoCuentaTrabajador.Text = String.Empty
        LimpiaGrid(griDocumentoVentaDetalle, ogdDocumentoVentaDetalle)
    End Sub

    Private Sub InicializaDocumento()
        With oeDocumentoVenta
            .UsuarioCreacion = gUsuarioSGI.Id
            .Activo = True
            .IdReferencia = String.Empty
            .FechaEmision = Date.Today & " " & TimeOfDay
            .FechaVencimiento = Date.Today & " " & TimeOfDay
            .loDocumentoVentaDetalle.Clear()
        End With
    End Sub

    Private Sub frm_DocumentoVenta_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case Operacion
            Case "Nuevo"
                MyBase.Nuevo()
            Case "Editar"
                MyBase.Editar()
            Case "Inicializa"
                rgFecha.Hasta = Date.Today
                rgFecha.Desde = Date.Today
                rgFecha.Desde = Date.Today.AddDays(-3)
                Consultar(True)
            Case "Ayuda"

        End Select
    End Sub

    Private Sub frm_DocumentoVenta_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_DocumentoVenta_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case Operacion
            Case "Nuevo"
                Me.Activate()
                Me.Cancelar()
            Case "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_DocumentoVenta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        spcDocumentoVenta.Panel2Collapsed = True
        MostrarTabs(0, FicDocumentoVenta, 1)
        Tiempo1.Enabled = False
        fecFechaEmision.Value = Date.Today
        fecFechaVencimiento.Value = Date.Today
        rgFecha.Hasta = Date.Today
        rgFecha.Desde = Date.Today
        oeIgv = OlIgv.IGV(fecFechaEmision.Value)
        LlenaCombos()

    End Sub

    Private Sub LlenaCombos()
        oeCliente.Activo = True
        oeCliente.TipoOperacion = ""
        LlenarComboMaestro(cboCliente, olCliente.Listar(oeCliente), -1)
        cboCliente.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        oeMoneda.TipoOperacion = "1"
        LlenarCombo(cboMoneda, "Abreviatura", olMoneda.Listar(oeMoneda), 0)
        oeTipoDocumento.Activo = True
        oeTipoDocumento.TipoOperacion = String.Empty
        oeTipoDocumento.TipoOperacion = "F"
        LlenarComboMaestro(cboTipoDocumento, olTipoDocumento.Listar(oeTipoDocumento), 2)
        oeTipoPago.Activo = True
        LlenarComboMaestro(cboTipoPago, olTipoPago.Listar(oeTipoPago), 0)
        oeCuentaTrabajador.IdTrabajador = String.Empty
        oeCuentaTrabajador.Id = String.Empty
        oeCuentaTrabajador.Codigo = String.Empty
        LlenarCombo(cboCuentaCorrienteTrabajador, "Trabajador", olCuentaCorriente.Listar(oeCuentaTrabajador), -1)
    End Sub

    'Sub InicializaTrabajador()
    '    oeTrabajador.Id = String.Empty
    '    oeTrabajador.oePersona.Dni = String.Empty
    '    oeTrabajador.oePersona.ApellidoPaterno = String.Empty
    '    oeTrabajador.oePersona.ApellidoMaterno = String.Empty
    '    oeTrabajador.Codigo = String.Empty
    '    oeTrabajador.oePersona.Nombre = String.Empty
    '    oeTrabajador.FechaIngreso = #1/1/1901#
    '    oeTrabajador.FechaCese = #1/1/1901#
    '    oeTrabajador.oeArea.Id = String.Empty
    '    oeTrabajador.oeCargo.Id = String.Empty
    '    oeTrabajador.oePersona.Id = String.Empty
    'End Sub

    Private Sub verTrabajadorAsignado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verTrabajadorAsignado.CheckedChanged
        If verTrabajadorAsignado.Checked Then
            agrTrabajadorAsignado.Visible = True
        Else
            agrTrabajadorAsignado.Visible = False
        End If
    End Sub

    Private Sub cboTrabajador_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuentaCorrienteTrabajador.SelectionChanged, cboCuentaCorrienteTrabajador.ValueChanged
        oeDocumentoVenta.IdCuentaCorriente = cboCuentaCorrienteTrabajador.Value
        oeCuentaTrabajador = New e_CuentaCorriente

        With cboCuentaCorrienteTrabajador
            If .SelectedIndex > -1 Then
                Dim i As Integer = .SelectedIndex
                oeCuentaTrabajador = .Items(i).ListObject
                oeTrabajador.InicializaTrabajador()
                oeTrabajador.Id = oeCuentaTrabajador.IdTrabajador
                oeTrabajador = olTrabajador.Obtener(oeTrabajador)
                etiDni.Text = oeTrabajador.oePersona.Dni
                etiNombre.Text = oeTrabajador.oePersona.NombreCompleto
                etiNumeroCuenta.Text = oeCuentaTrabajador.Codigo
                etiSaldoCuentaTrabajador.Text = oeCuentaTrabajador.Saldo
                'If Not String.IsNullOrEmpty(etiDni.Text) Then picRecibidor.Image = olPersona.Foto(etiDni.Text)
            End If
        End With
    End Sub

    Private Sub decTotalFacturado_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decTotalFacturado.ValueChanged ', decTotalDescuento.ValueChanged

        decTotalFacturado.Value = Math.Round(decTotalFacturado.Value, 2)
        oeDocumentoVenta.TotalFacturado = decTotalFacturado.Value
        decSaldo.Value = decTotalFacturado.Value - decTotalEfectivo.Value
        oeDocumentoVenta.TotalDescuento = decTotalDescuento.Value
        etiTotal.Text = String.Empty

        'Convertir el monto facturado en letras
        'etiTotal.Text = Conversiones.NumerosALetras.Ejecutar(decTotalFacturado.Value, True, True, "NUEVOS SOLES")

    End Sub

    Private Sub decSaldo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decSaldo.ValueChanged
        decSaldo.Value = decTotalFacturado.Value - decTotalEfectivo.Value
        oeDocumentoVenta.TotalCredito = decSaldo.Value
    End Sub

    Private Sub decTotalEfectivo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles decTotalEfectivo.LostFocus
        'LlenarComboMaestro(cboTipoPago, olTipoPago.Listar(oeTipoPago), -1)
        oeTipoPago.Id = String.Empty
        oeTipoPago.Codigo = String.Empty
        oeTipoPago.Activo = True
        If decSaldo.Value > 0 Then
            oeTipoPago.Nombre = "CREDITO"
            oeTipoPago = olTipoPago.Obtener(oeTipoPago)
            cboTipoPago.Value = oeTipoPago.Id
        ElseIf decSaldo.Value = 0 Then
            oeTipoPago.Nombre = "CONTADO"
            oeTipoPago = olTipoPago.Obtener(oeTipoPago)
            cboTipoPago.Value = oeTipoPago.Id
        End If
    End Sub

    Private Sub decTotalEfectivo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decTotalEfectivo.ValueChanged
        decSaldo.Value = decTotalFacturado.Value - decTotalEfectivo.Value
        oeDocumentoVenta.TotalEfectivo = decTotalEfectivo.Value
    End Sub

    Private Sub cboTipoDocumento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoDocumento.ValueChanged
        oeDocumentoVenta.IdTipoDocumento = cboTipoDocumento.Value
        oeDocumentoVenta.TipoDocumento = cboTipoDocumento.Text
        CargarCorrelativo()
    End Sub

    Private Sub cboTipoPago_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoPago.ValueChanged
        oeDocumentoVenta.IdTipoPago = cboTipoPago.Value
    End Sub

    Private Sub cboMoneda_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMoneda.ValueChanged
        'oeMoneda = New e_Moneda
        ' With cboMoneda
        'Dim i As Integer = .SelectedIndex
        ' oeMoneda = .Items(i).ListObject
        'End With
        'NombreMoneda = oeMoneda.Nombre
        oeDocumentoVenta.IdMoneda = cboMoneda.Value
        oeDocumentoVenta.Moneda = cboMoneda.Text
        'If etiTotal.Text <> "" Then etiTotal.Text = etiTotal.Text
    End Sub

    Private Sub cboCliente_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCliente.ValueChanged
        oeDocumentoVenta.IdCliente = cboCliente.Value
    End Sub

    Private Sub txtSerie_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerie.ValueChanged
        oeDocumentoVenta.Serie = txtSerie.Text
    End Sub

    Private Sub txtNumero_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.ValueChanged
        oeDocumentoVenta.Numero = txtNumero.Text
    End Sub

    Private Sub fecFechaEmision_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecFechaEmision.ValueChanged, _
                                                                                                        fecFechaEmision.KeyDown, fecFechaEmision.GotFocus
        oeDocumentoVenta.FechaEmision = fecFechaEmision.Value
    End Sub

    Private Sub fecFechaVencimiento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecFechaVencimiento.ValueChanged, _
                                                                                                    fecFechaVencimiento.KeyDown, fecFechaVencimiento.GotFocus
        oeDocumentoVenta.FechaVencimiento = fecFechaVencimiento.Value
    End Sub

    Private Sub txtConcepto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConcepto.ValueChanged
        oeDocumentoVenta.Concepto = txtConcepto.Text
    End Sub

    Private Sub FicDocumentoVenta_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles FicDocumentoVenta.SelectedTabChanged
        Select Case FicDocumentoVenta.SelectedTab.Index
            Case 0
                ListarDemanda()
            Case 1
                ListarVenta()

        End Select
    End Sub

    Private Sub griDocumentoVenta_AfterRowActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griDocumentoVenta.AfterRowActivate

        If griDocumentoVenta.ActiveRow.Index >= 0 Then
            oeDocumentoVentaDetalle.IdDocumentoVenta = griDocumentoVenta.ActiveRow.Cells("Id").Value
            ListarDocumentoVentaDetalle()
        End If

    End Sub

    Private Sub ListarDocumentoVentaDetalle()
        Try
            LimpiaGrid(griListaDetalle, ogdDocumentoVentaDetalle)
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeDocumentoVentaDetalle.TipoOperacion = ""

            With griListaDetalle
                .DataSource = olDocumentoVentaDetalle.Listar(oeDocumentoVentaDetalle)
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
            End With

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
        End Try

    End Sub

    Private Sub btnMostrarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrarDetalle.Click
        MostrarDetalleVenta()
    End Sub

    Sub MostrarDetalleVenta()

        If Me.spcDocumentoVenta.Panel2Collapsed Then
            Me.spcDocumentoVenta.Panel2Collapsed = False
            btnMostrarDetalle.Text = "Ocultar Detalle"
        Else
            Me.spcDocumentoVenta.Panel2Collapsed = True
            btnMostrarDetalle.Text = "Mostrar Detalle"
        End If

    End Sub

    Private Sub decSubTotal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decSubTotal.ValueChanged
        oeDocumentoVenta.SubTotal = decSubTotal.Value
        'nupPorcentajeDescuento_ValueChanged(nupPorcentajeDescuento, e)
    End Sub

    Private Sub nupPorcentajeDetraccion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nupPorcentajeDetraccion.ValueChanged, _
                                                                                                                nupPorcentajeDetraccion.AutoSizeChanged
        PorcentajeDetraccion = nupPorcentajeDetraccion.Value / 100
        oeDocumentoVenta.PorcentajeDetraccion = PorcentajeDetraccion
        decTotalDetraccion.Value = decTotalFacturado.Value * PorcentajeDetraccion
        decDetraccion.Value = decTotalFacturado.Value - decTotalDetraccion.Value
    End Sub

    'Private Sub nupPorcentajeDescuento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nupPorcentajeDescuento.ValueChanged, _
    '                                                                                                            nupPorcentajeDescuento.AutoSizeChanged
    '    PorcentajeDescuento = nupPorcentajeDescuento.Value / 100
    '    oeDocumentoVenta.PorcentajeDescuento = PorcentajeDescuento
    '    decTotalDescuento.Value = decSubTotal.Value - (decSubTotal.Value * PorcentajeDescuento)
    '    verIgv_CheckedChanged(verIgv, e)
    'End Sub

    Private Sub verIgv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verIgv.CheckedChanged
        If verIgv.Checked = True Then
            oeDocumentoVenta.PorcentajeIgv = oeIgv.Porcentaje
            'decTotalFacturado.Value = decTotalDescuento.Value + (decTotalDescuento.Value * oeIgv.Porcentaje)
            decSubTotal.Value = decTotalFacturado.Value - (decTotalFacturado.Value * oeIgv.Porcentaje)
            decValorIgv.Value = decTotalFacturado.Value * oeIgv.Porcentaje
        Else
            'decTotalFacturado.Value = decTotalDescuento.Value - (decTotalDescuento.Value * oeIgv.Porcentaje)
            decSubTotal.Value = decTotalFacturado.Value
            decValorIgv.Value = 0.0
        End If
    End Sub

    Private Sub decTotalDetraccion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decTotalDetraccion.ValueChanged
        oeDocumentoVenta.TotalDetraccion = decTotalDetraccion.Value
    End Sub

    Private Sub decDetraccion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decDetraccion.ValueChanged
        oeDocumentoVenta.TotalMontoNeto = decDetraccion.Value
    End Sub

#End Region

    Private Sub griDocumentoVenta_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griDocumentoVenta.InitializeLayout

    End Sub

    Private Sub decValorIgv_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decValorIgv.ValueChanged

    End Sub

End Class
