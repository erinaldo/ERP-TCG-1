'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_DocumentoAnulado
    Inherits frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_DocumentoAnulado = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_DocumentoAnulado
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oeDocAnulado As New e_MovimientoDocumento, olDocAnulado As New l_MovimientoDocumento
    Private oeMoneda As New e_Moneda, olMoneda As New l_Moneda, leMoneda As New List(Of e_Moneda)
    Private oeTipoDoc As New e_TipoDocumento, olTipoDoc As New l_TipoDocumento, leTipoDocBus As New List(Of e_TipoDocumento)
    Private leTipoDoc As New List(Of e_TipoDocumento), leTipoDocAso As New List(Of e_TipoDocumento)
    Private oeEstado As New e_Estado, olEstado As New l_Estado, leEstado As New List(Of e_Estado)
    Private IdEstado As String = "", IdCliente As String = "", IdMoneda As String = ""
    Private band As Boolean = True, _ingresando_datos As Boolean = False
    Private _opeDoc As String = "", _acl As String = "", _estado As String = ""

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griDocAnulados.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            _acl = gAccionSistema.NUEVO.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                MostrarTabs(1, ficDocAnulado, 1)
                Inicializar()
                oeDocAnulado.TipoOperacion = "I"
                oeDocAnulado.Modificado = False
                Operacion = "Nuevo"
                cboTipoDoc.Focus()
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            _acl = gAccionSistema.EDITAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                Inicializar()
                Mostrar()
                oeDocAnulado.TipoOperacion = "A"
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                MostrarTabs(1, ficDocAnulado, 0)
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeDocAnulado.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If Guardando() Then
                            MostrarTabs(0, ficDocAnulado, 2)
                            _ingresando_datos = False
                            Consultar(_Activo)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficDocAnulado, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficDocAnulado, 2)
                        _ingresando_datos = False
                        Consultar(_Activo)
                End Select
            Else
                MostrarTabs(0, ficDocAnulado, 2)
                _ingresando_datos = False
                Consultar(_Activo)
            End If
            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If Not Guardando() Then
                MostrarTabs(1, ficDocAnulado, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            _acl = gAccionSistema.ELIMINAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                oeDocAnulado = New e_MovimientoDocumento
                oeDocAnulado.CargarCompleto = False
                oeDocAnulado.Id = griDocAnulados.ActiveRow.Cells("Id").Value()
                oeDocAnulado = olDocAnulado.ObtenerVenta(oeDocAnulado)
                If ValidarPeridoContable(oeDocAnulado.IdPeriodo, gAreasSGI.Ventas) Then
                    'Dim formulario As frm_AutenticarTrabajador
                    'formulario = New frm_AutenticarTrabajador
                    'formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                    'If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                    '    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                    '    Throw New Exception("Ingrese un Clave Correcta")
                    'Else
                    oeDocAnulado.TipoOperacion = "E"
                    olDocAnulado.EliminarDocumentoVenta(oeDocAnulado)
                    mensajeEmergente.Confirmacion("¡El Documento se ha Eliminado correctamente!", True)
                    Consultar(True)
                    'End If
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            If griDocAnulados.Rows.Count = 0 Then Throw New Exception("No hay ningún Documento Anulado para exportar al Excel")
            Exportar_Excel(griDocAnulados)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_DocumentoAnulado_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case Operacion
            Case "Nuevo"
                MyBase.Nuevo()
            Case "Editar"
                MyBase.Editar()
            Case "Inicializa"
                If griDocAnulados.Rows.Count > 0 Then
                    ControlBoton(1, 1, 0, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
        End Select
    End Sub

    Private Sub frm_DocumentoAnulado_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_DocumentoAnulado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            fecDesde.Value = Date.Now.Date.AddDays(-5)
            fecHasta.Value = Date.Now.Date
            CargarCombos()
            CargarDocAnulado(New List(Of e_MovimientoDocumento))
            band = False
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            MostrarTabs(0, ficDocAnulado)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTipoDoc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoDoc.ValueChanged
        If cboTipoDoc.SelectedIndex > -1 Then
            If txtSerie.Text.Trim <> "" Then
                Dim oe As New e_MovimientoDocumento
                oe.TipoOperacion = "NUM"
                oe.Serie = txtSerie.Text.Trim
                oe.IdTipoDocumento = cboTipoDoc.Value
                txtNumero.Text = olDocAnulado.ObtenerNumDoc(oe).Numero
            End If
        End If

    End Sub

    Private Sub txtSerie_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerie.KeyPress
        TextoNumero(e)
    End Sub

    Private Sub txtNumero_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero.KeyPress
        TextoNumero(e)
    End Sub

    Private Sub txtSerie_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerie.Validated
        FormateaTexto(txtSerie, 4)
        If txtSerie.Text.Trim <> "" Then
            Dim oe As New e_MovimientoDocumento
            oe.TipoOperacion = "NUM"
            oe.Serie = txtSerie.Text.Trim
            oe.IdTipoDocumento = cboTipoDoc.Value
            txtNumero.Text = olDocAnulado.ObtenerNumDoc(oe).Numero
        End If
    End Sub

    Private Sub txtNumero_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.Validated
        'FormateaTexto(txtNumero, 10) '@0001
        FormateaTexto(txtNumero, 8)
    End Sub

    Private Sub griDocAnulados_DoubleClick(sender As Object, e As EventArgs) Handles griDocAnulados.DoubleClick
        Editar()
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombos()

        oeTipoDoc = New e_TipoDocumento
        oeTipoDoc.Id = "BFNCD"
        oeTipoDoc.Nombre = "TODOS"
        leTipoDocBus.Add(oeTipoDoc)

        oeTipoDoc = New e_TipoDocumento
        oeTipoDoc.TipoOperacion = "F"
        leTipoDocAso = olTipoDoc.Listar(oeTipoDoc)

        leTipoDoc.AddRange(leTipoDocAso)
        leTipoDocBus.AddRange(leTipoDocAso)

        oeTipoDoc = New e_TipoDocumento
        oeTipoDoc.TipoOperacion = ""
        oeTipoDoc.Nombre = "NOTA DE CRÉDITO"
        oeTipoDoc = olTipoDoc.Obtener(oeTipoDoc)
        leTipoDoc.Add(oeTipoDoc)
        leTipoDocBus.Add(oeTipoDoc)
        oeTipoDoc = New e_TipoDocumento
        oeTipoDoc.TipoOperacion = ""
        oeTipoDoc.Nombre = "NOTA DE DÉBITO"
        oeTipoDoc = olTipoDoc.Obtener(oeTipoDoc)
        leTipoDoc.Add(oeTipoDoc)
        leTipoDocBus.Add(oeTipoDoc)


        LlenarCombo(cboTipoDocumento, "Nombre", leTipoDocBus, 0)
        LlenarCombo(cboTipoDoc, "Nombre", leTipoDoc, -1)

        oeMoneda = New e_Moneda
        leMoneda = olMoneda.Listar(oeMoneda)

        oeEstado = New e_Estado
        oeEstado.Nombre = "FACTURAR"
        leEstado = olEstado.Listar(oeEstado)

        oeEstado = New e_Estado
        oeEstado = leEstado.Where(Function(item) item.Nombre = "ANULADO")(0)
        IdEstado = oeEstado.Id

        oeMoneda = New e_Moneda
        oeMoneda = leMoneda.Where(Function(item) item.Nombre = "SOLES")(0)
        IdMoneda = oeMoneda.Id

        Dim oeCli As New e_Cliente
        Dim olCli As New l_Cliente
        oeCli.Dni = "00000000002"
        oeCli.Activo = True
        oeCli.TipoOperacion = "T"
        oeCli.TipoPersonaEmpresa = 2
        oeCli = olCli.Obtener(oeCli)
        IdCliente = oeCli.Id

    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            oeDocAnulado = New e_MovimientoDocumento
            ValidarFechaDesde_Hasta(fecDesde, fecHasta)
            oeDocAnulado.Activo = Activo
            oeDocAnulado.TipoOperacion = "FAC"
            oeDocAnulado.IdTipoDocumento = cboTipoDocumento.Value
            oeDocAnulado.IndCompraVenta = 2
            oeDocAnulado.FechaInicio = fecDesde.Value
            oeDocAnulado.FechaFinal = fecHasta.Value
            oeDocAnulado.IdEstadoDocumento = IdEstado
            CargarDocAnulado(olDocAnulado.Listar(oeDocAnulado))
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griDocAnulados.Focus()
    End Sub

    Private Sub CargarDocAnulado(ByVal leDocAso As List(Of e_MovimientoDocumento))
        Try
            With griDocAnulados

                If band Then
                    .ResetDisplayLayout()
                    .DisplayLayout.ViewStyle = ViewStyle.SingleBand
                End If

                .DataSource = leDocAso

                If band Then

                    CreaCombo_griDocAnulado()

                    For Each Col As UltraGridColumn In .DisplayLayout.Bands(0).Columns
                        If Col.Header.Caption.Contains("Id") AndAlso _
                        Col.Header.Caption <> "IdMoneda" AndAlso _
                        Col.Header.Caption <> "IdEstadoDocumento" AndAlso _
                        Col.Header.Caption <> "IdTipoDocumento" Then Col.Hidden = True
                    Next

                    .DisplayLayout.Bands(0).Columns("NombreDocumento").Hidden = True
                    .DisplayLayout.Bands(0).Columns("MontoOperar").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IndCompraVenta").Hidden = True
                    .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                    .DisplayLayout.Bands(0).Columns("AbreviaturaMoneda").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Moneda").Hidden = True
                    .DisplayLayout.Bands(0).Columns("TipoPago").Hidden = True
                    .DisplayLayout.Bands(0).Columns("EstadoDocumento").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Percepcion").Hidden = True
                    .DisplayLayout.Bands(0).Columns("DiasVen").Hidden = True

                    .DisplayLayout.Bands(0).Columns("Serie").SortIndicator = SortOrder.Ascending

                    .DisplayLayout.Bands(0).Columns("IdTipoDocumento").Header.VisiblePosition = 1
                    .DisplayLayout.Bands(0).Columns("Serie").Header.VisiblePosition = 2
                    .DisplayLayout.Bands(0).Columns("Numero").Header.VisiblePosition = 3
                    .DisplayLayout.Bands(0).Columns("FechaEmision").Header.VisiblePosition = 4
                    .DisplayLayout.Bands(0).Columns("FechaVencimiento").Header.VisiblePosition = 5
                    .DisplayLayout.Bands(0).Columns("DiasVen").Header.VisiblePosition = 6
                    .DisplayLayout.Bands(0).Columns("NombreProveedor").Header.VisiblePosition = 7
                    .DisplayLayout.Bands(0).Columns("IdMoneda").Header.VisiblePosition = 8
                    .DisplayLayout.Bands(0).Columns("TipoCambio").Header.VisiblePosition = 9
                    .DisplayLayout.Bands(0).Columns("SubTotal").Header.VisiblePosition = 10
                    .DisplayLayout.Bands(0).Columns("IGV").Header.VisiblePosition = 11
                    .DisplayLayout.Bands(0).Columns("Total").Header.VisiblePosition = 12
                    .DisplayLayout.Bands(0).Columns("Saldo").Header.VisiblePosition = 13
                    .DisplayLayout.Bands(0).Columns("SaldoDetraccion").Header.VisiblePosition = 14
                    .DisplayLayout.Bands(0).Columns("Neto").Header.VisiblePosition = 15
                    .DisplayLayout.Bands(0).Columns("IdEstadoDocumento").Header.VisiblePosition = 16

                    .DisplayLayout.Bands(0).Columns("Serie").Width = 30
                    .DisplayLayout.Bands(0).Columns("Numero").Width = 65
                    .DisplayLayout.Bands(0).Columns("FechaEmision").Width = 70
                    .DisplayLayout.Bands(0).Columns("FechaVencimiento").Width = 70
                    .DisplayLayout.Bands(0).Columns("TipoCambio").Width = 30
                    .DisplayLayout.Bands(0).Columns("NombreProveedor").Width = 200
                    .DisplayLayout.Bands(0).Columns("IdMoneda").Width = 30

                    .DisplayLayout.Bands(0).Columns("FechaEmision").Header.Caption = "Fec. Emision"
                    .DisplayLayout.Bands(0).Columns("FechaVencimiento").Header.Caption = "Fec. Venc."
                    .DisplayLayout.Bands(0).Columns("TipoCambio").Header.Caption = "T.C."
                    .DisplayLayout.Bands(0).Columns("NombreProveedor").Header.Caption = "Cliente"
                    .DisplayLayout.Bands(0).Columns("IdMoneda").Header.Caption = "Mon"
                    .DisplayLayout.Bands(0).Columns("IdEstadoDocumento").Header.Caption = "Estado"
                    .DisplayLayout.Bands(0).Columns("IdTipoDocumento").Header.Caption = "Tipo Doc."

                    .DisplayLayout.Bands(0).Columns("IGV").Style = ColumnStyle.Double
                    .DisplayLayout.Bands(0).Columns("SubTotal").Style = ColumnStyle.Double
                    .DisplayLayout.Bands(0).Columns("Total").Style = ColumnStyle.Double
                    .DisplayLayout.Bands(0).Columns("Saldo").Style = ColumnStyle.Double
                    .DisplayLayout.Bands(0).Columns("SaldoDetraccion").Style = ColumnStyle.Double
                    .DisplayLayout.Bands(0).Columns("Neto").Style = ColumnStyle.Double

                    .DisplayLayout.Bands(0).Columns("IGV").CellAppearance.TextHAlign = HAlign.Right
                    .DisplayLayout.Bands(0).Columns("SubTotal").CellAppearance.TextHAlign = HAlign.Right
                    .DisplayLayout.Bands(0).Columns("Total").CellAppearance.TextHAlign = HAlign.Right
                    .DisplayLayout.Bands(0).Columns("Saldo").CellAppearance.TextHAlign = HAlign.Right
                    .DisplayLayout.Bands(0).Columns("SaldoDetraccion").CellAppearance.TextHAlign = HAlign.Right
                    .DisplayLayout.Bands(0).Columns("Neto").CellAppearance.TextHAlign = HAlign.Right

                    .DisplayLayout.Bands(0).Columns("SubTotal").Format = "##,###,###0.0000"
                    .DisplayLayout.Bands(0).Columns("Total").Format = "##,###,###0.0000"
                    .DisplayLayout.Bands(0).Columns("Saldo").Format = "##,###,###0.0000"
                    .DisplayLayout.Bands(0).Columns("SaldoDetraccion").Format = "##,###,###0.0000"
                    .DisplayLayout.Bands(0).Columns("Neto").Format = "##,###,###0.0000"

                    .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                    .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
                    .DisplayLayout.Override.FilterUIProvider = Filtro1

                    .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)

                    .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                    .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                    .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                    .DisplayLayout.MaxColScrollRegions = 1
                    .DisplayLayout.MaxRowScrollRegions = 1
                End If

                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CreaCombo_griDocAnulado()
        'Para Columna de Moneda
        griDocAnulados.DisplayLayout.ValueLists.Add("IdMoneda")
        With griDocAnulados.DisplayLayout.ValueLists("IdMoneda").ValueListItems
            .Clear()
            For Each oeTD As e_Moneda In leMoneda
                .Add(oeTD.Id, oeTD.Abreviatura)
            Next
        End With
        CrearComboGrid3("IdMoneda", "Abreviatura", griDocAnulados, True)
        'Para Columna de Estado Documento
        griDocAnulados.DisplayLayout.ValueLists.Add("IdEstadoDocumento")
        With griDocAnulados.DisplayLayout.ValueLists("IdEstadoDocumento").ValueListItems
            .Clear()
            For Each oeEs As e_Estado In leEstado
                .Add(oeEs.Id, oeEs.Nombre)
            Next
        End With
        CrearComboGrid3("IdEstadoDocumento", "Nombre", griDocAnulados, True)
        'Para Columna de Tipo Documento
        griDocAnulados.DisplayLayout.ValueLists.Add("IdTipoDocumento")
        With griDocAnulados.DisplayLayout.ValueLists("IdTipoDocumento").ValueListItems
            .Clear()
            For Each oeTD As e_TipoDocumento In leTipoDoc
                .Add(oeTD.Id, oeTD.Nombre)
            Next
        End With
        CrearComboGrid3("IdTipoDocumento", "TipoDocumento", griDocAnulados, True)
    End Sub

    Private Sub Inicializar()
        oeDocAnulado = New e_MovimientoDocumento
        oeDocAnulado.IdUsuarioCrea = gUsuarioSGI.Id
        oeDocAnulado.Mac_PC_Local = MacPCLocal()
        oeDocAnulado._Operador = 1
        oeDocAnulado.IndCompraVenta = 2
        oeDocAnulado.IdEstadoDocumento = IdEstado
        oeDocAnulado.SubTotal = 0
        oeDocAnulado.IGV = 0
        oeDocAnulado.Total = 0
        oeDocAnulado.IdClienteProveedor = IdCliente
        oeDocAnulado.IdMoneda = IdMoneda
        oeDocAnulado.Venta.IdDireccion = ""
        oeDocAnulado.Venta.IdTipoPago = ""
        oeDocAnulado.Venta.Glosa = ""
        oeDocAnulado.Venta.FactorRefUni = 0
        oeDocAnulado.Venta.PorcenDetra = 0
        oeDocAnulado.Venta.Gravado = 0
        oeDocAnulado.Venta.IGV = 0
        oeDocAnulado.Venta.Detraccion = 0
        oeDocAnulado.Venta.SaldoDetraccion = 0
        oeDocAnulado.Venta.IndCliente = 2
        cboTipoDoc.SelectedIndex = -1
        txtSerie.Text = String.Empty
        txtNumero.Text = String.Empty
        fecEmision.Value = Date.Now.Date
        oeDocAnulado.FechaEmision = fecEmision.Value
        oeDocAnulado.FechaVencimiento = fecEmision.Value
    End Sub

    Private Function Guardando() As Boolean
        Try
            oeDocAnulado.IdTipoDocumento = cboTipoDoc.Value
            oeDocAnulado.FechaEmision = fecEmision.Value
            oeDocAnulado.FechaVencimiento = fecEmision.Value
            oeDocAnulado.Serie = txtSerie.Text.Trim
            oeDocAnulado.Numero = txtNumero.Text.Trim
            oeDocAnulado.IdPeriodo = CalcularPeriodo(fecEmision.Value.Month, fecEmision.Value.Year)
            oeDocAnulado.TipoCambio = TipoCambio(fecEmision.Value, True)(0)
            If oeDocAnulado.IdPeriodo Is Nothing Then Throw New Exception("No existe Periodo")
            ValidarPeriodoyFecha(oeDocAnulado.IdPeriodo, oeDocAnulado.FechaEmision)
            ValidarPeridoContable(oeDocAnulado.IdPeriodo, gAreasSGI.Ventas)
            oeDocAnulado.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olDocAnulado.GuardarMasivo(oeDocAnulado) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                MostrarTabs(0, ficDocAnulado, 2)
                Consultar(_Activo)
                griDocAnulados.Focus()
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub TextoNumero(ByVal ei As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(ei.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then ei.Handled = True
    End Sub

    Private Sub FormateaTexto(ByVal texto As UltraWinEditors.UltraTextEditor, ByVal lon As Integer)
        If texto.Text.Trim <> "" AndAlso CInt(texto.Text) > 0 Then
            texto.Text = FormatoDocumento(texto.Text, lon)
        End If
    End Sub

    Private Sub Mostrar()
        Try
            If griDocAnulados.Selected.Rows.Count > 0 Then
                oeDocAnulado = New e_MovimientoDocumento
                oeDocAnulado.CargarCompleto = False
                oeDocAnulado.Id = griDocAnulados.ActiveRow.Cells("Id").Value()
                oeDocAnulado = olDocAnulado.ObtenerVenta(oeDocAnulado)
                cboTipoDoc.Value = oeDocAnulado.IdTipoDocumento
                txtSerie.Text = oeDocAnulado.Serie
                txtNumero.Text = oeDocAnulado.Numero
                fecEmision.Value = oeDocAnulado.FechaEmision
            Else
                Throw New Exception("Seleccione un Registro para Editar")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function CalcularPeriodo(ByVal Mes As Integer, ByVal Anio As Integer) As String
        Try
            Dim _IdPeriodo As String = ""
            Dim oePeriodo As New e_Periodo, olPeriodo As New l_Periodo
            oePeriodo.Ejercicio = Anio : oePeriodo.Mes = Mes
            oePeriodo = olPeriodo.Obtener(oePeriodo)
            _IdPeriodo = oePeriodo.Id
            Return _IdPeriodo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Menu Contextual"



#End Region

End Class