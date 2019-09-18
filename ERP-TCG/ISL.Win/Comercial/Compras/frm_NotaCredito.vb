'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios Centro y Giro
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_NotaCredito

#Region "Inicializacion de Formulario"

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Shared instancia As frm_NotaCredito = Nothing
    Private Shared Operacion As String
    Dim _ingresando_datos As Boolean = False

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_NotaCredito()
        End If
        instancia.Activate()
        Return instancia
    End Function
#End Region

#Region "Declaración de variables"

    Dim oeMovimientoDocumento As New e_MovimientoDocumento
    Dim olMovimientoDocumento As New l_MovimientoDocumento
    Dim lstMovimientoDocumento As New List(Of e_MovimientoDocumento)

    Dim oeDetalleDocumento As New e_DetalleDocumento
    Dim olDetalleDocumento As New l_DetalleDocumento
    Dim lstDetalleDocumento As New List(Of e_DetalleDocumento)
    Dim leActivo As New List(Of e_DetalleDocumento)

    Dim oeIGV As New e_Impuesto
    Dim olIGV As New l_Impuesto

    Dim totalSinIgv As Double = 0.0
    Dim totalIgv As Double = 0.0
    Dim totalConIng As Double = 0.0
    Dim cambioMon As Double = 0.0

    Dim oeMoneda As New e_Moneda
    Dim olMoneda As New l_Moneda
    Dim llMoneda As New List(Of e_Moneda)

    Dim oeMotivoDocumento As New e_MotivoDocumento
    Dim olMotivoDocumento As New l_MotivoDocumento

    Dim oeTipoPago As New e_TipoPago
    Dim olTipoPago As New l_TipoPago
    Dim llTipoPago As New List(Of e_TipoPago)

    Dim oeProveedor As New e_Proveedor
    Dim olProveedor As New l_Proveedor
    Dim llProveedores As New List(Of e_Proveedor)

    'Manejador de Estados
    Dim oeEstado As New e_Estado
    Dim olEstado As New l_Estado
    Dim llEstado As New List(Of e_Estado)
    Dim lstEstado As New List(Of e_Estado)


    Dim oeTipoDocumento As New e_TipoDocumento
    Dim olTipoDocumento As New l_TipoDocumento

    'Manejador de Tipo de Documento
    Dim oeProDoc As New e_ProcesoTipoDocumento
    Dim olProDoc As New l_ProcesoTipoDocumento


    'Manejador de Proceso
    Dim oeProceso As New e_ProcesoNegocio
    Dim olProceso As New l_ProcesoNegocio

    'Manejador de DetallesAsociados
    Dim lDetalleAsoc As New List(Of e_DetalleDocumento)

    Dim oeEmpresa As New e_Empresa
    Dim olEmpresa As New l_Empresa

    Dim oeCategoriaServicio As New e_CategoriaServicio
    Dim olCategoriaServicio As New l_CategoriaServicio
    Dim lstCategoriasServicio As New List(Of e_CategoriaServicio)


    Dim cantmat As Double = 0
    Dim cont As Integer
    Dim posGrilla As Integer
    Dim swIgv As Boolean

    Dim oeUnidadMedida As New e_UnidadMedida
    Dim olUnidadMedida As New l_UnidadMedida

    'Controla si viene de una orden
    Dim sOrden As Boolean = 1

    'Afectar Inventario
    Dim olRegistroInvDoc As New l_RegistroInventarioDocumento
    Private IndMaterialServicio As String

    'Manejador Documentos Asociados
    Dim lDocumentosAsoc As New List(Of e_MovimientoDocumento)
    Dim oeDocAsoc As New e_MovimientoDocumento
    Dim oeDocAso2 As New e_DocumentoAsociado
    Dim olDocAsoc As New l_DocumentoAsociado

    'asiento contable
    Private oeAsientoModelo, oeAsientoModeloNotaCredito As New e_AsientoModelo
    Private olAsientoModelo As New l_AsientoModelo
    Private loAsientoModelo As New List(Of e_AsientoModelo)

    Private oeReferencia As New e_AsientoModelo_Referencia
    Private olReferencia As New l_AsientoModelo_Referencia
    Private loReferencia As New List(Of e_AsientoModelo_Referencia)
    Private dtReferencia As New DataTable
    Private oeCtaCtbleSFam As New e_CtaCtbleSubFamiliaMat
    Private olCtaCtbleSFam As New l_CtaCtbleSubFamiliaMat
    Private loCtaCtbleSFam As New List(Of e_CtaCtbleSubFamiliaMat)

    Private oeCtaCtbleCSer As e_CtaCtbleCatServicio, olCtaCtbleCSer As l_CtaCtbleCatServicio, loCtaCtbleCSer As List(Of e_CtaCtbleCatServicio)

#End Region

#Region "Botones"

    Public Overrides Sub Nuevo()
        Try
            Inicializar()
            oeMovimientoDocumento.TipoOperacion = "I"
            oeMovimientoDocumento.PrefijoID = PrefijoIdSucursal '@0001
            IndMaterialServicio = cboMaterialServicio.Value
            MostrarTabs(1, ficNotaCredito, 1)
            MostrarTabs(1, ficDetalleOCMateriales, 0)
            UEGB_Ordenes.Expanded = True
            Operacion = "Nuevo"
            cboEstadoFacturaM.SelectedIndex = 0 'Ubica estado para Generar
            MyBase.Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            Operacion = "Inicializa"
            If oeMovimientoDocumento.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarDocumentoCompra() Then
                            MostrarTabs(0, ficNotaCredito, 2)
                            _ingresando_datos = False
                            Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficNotaCredito, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficNotaCredito, 2)
                        _ingresando_datos = False
                        Consultar(True)
                End Select
            Else
                MostrarTabs(0, ficNotaCredito, 2)
                _ingresando_datos = False
                Consultar(True)
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            'If GuardarDocumentoCompra() Then
            '    MostrarTabs(0, ficNotaCredito, 2)
            '    Consultar(True)
            'Else
            '    MostrarTabs(1, ficNotaCredito, 1)
            'End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            ControlBoton(1, 1)
            If griListaNotaCredito.Rows.Count > 0 Then ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Inicializar()
            If CargarDocumentoCompra() Then
                oeMovimientoDocumento.TipoOperacion = "A"
                oeMovimientoDocumento.PrefijoID = PrefijoIdSucursal '@0001
                If cboEstadoFacturaM.Text = "GENERADA" Then
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                Else
                    ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 0)
                End If
                MostrarTabs(1, ficNotaCredito, 1)
                gbeListadoMatSer.Expanded = False
                Operacion = "Editar"
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With griListaNotaCredito
                If griListaNotaCredito.ActiveRow.Cells("EstadoDocumento").Value = "GENERADA" Then
                    If ValidarGrilla(griListaNotaCredito, "NotaCredito") Then
                        oeMovimientoDocumento.Id = .ActiveRow.Cells("Id").Value
                        oeMovimientoDocumento.TipoOperacion = "COM"
                        oeMovimientoDocumento.PrefijoID = PrefijoIdSucursal '@0001
                        oeMovimientoDocumento = olMovimientoDocumento.ObtenerDocumentosPorCompras(oeMovimientoDocumento)
                        If oeMovimientoDocumento.Activo Then
                            If MessageBox.Show("Esta seguro de eliminar la factura : " & _
                                           .ActiveRow.Cells("NombreDocumento").Value.ToString & " ?", _
                                                              "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                oeMovimientoDocumento.TipoOperacion = "E"
                                oeMovimientoDocumento.PrefijoID = PrefijoIdSucursal '@0001
                                olMovimientoDocumento.Eliminar(oeMovimientoDocumento)
                                Consultar(True)
                            End If
                        Else
                            Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                        End If
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        'Imprimir()
    End Sub

    Public Overrides Sub Exportar()
        Try
            If ficNotaCredito.Tabs(0).Selected() AndAlso griListaNotaCredito.Rows.Count = 0 Then Throw New Exception("No hay ninguna Nota de Crédito para exportar al Excel")
            If ficNotaCredito.Tabs(0).Selected() Then Exportar_Excel(griListaNotaCredito)

            If ficNotaCredito.Tabs(1).Selected() Then

                If ficDetalleOCMateriales.Tabs(0).Selected() AndAlso griListaDetalleNotaCredito.Rows.Count = 0 Then Throw New Exception("No hay ninguna Nota de Crédito para exportar al Excel")
                If ficDetalleOCMateriales.Tabs(0).Selected() Then Exportar_Excel(griListaDetalleNotaCredito)

                If ficDetalleOCMateriales.Tabs(1).Selected() AndAlso GriAsocDoc.Rows.Count = 0 Then Throw New Exception("No hay ninguna Nota de Crédito para exportar al Excel")
                If ficDetalleOCMateriales.Tabs(1).Selected() Then Exportar_Excel(GriAsocDoc)

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

    Private Sub IniciarFormulario()
        Try
            'Para las cabezeras
            ColoresGenerado.Color = Blanco
            ColoresEmitido.Color = VerdeClaro
            ColoresAnulado.Color = Color.PowderBlue
            rfFechaDocDesde.Value = Date.Now.AddDays(-7)
            rfFechaDocHasta.Value = Date.Now
            fecFechaActual.Value = Date.Now
            cambioMon = TipoCambio(fecFechaActual.Value, 0)(0)
            decTc.Value = cambioMon
            oeIGV = olIGV.IGV(fecFechaActual.Value)
            decPorcenIGV.Value = oeIGV.Porcentaje

            oeEmpresa = New e_Empresa
            oeEmpresa.Id = ISL_IdEmpresa
            oeEmpresa.CargaCompleta = True
            oeEmpresa = olEmpresa.Obtener(oeEmpresa)
            txtEmpresa.Value = oeEmpresa.Nombre
            LlenaCombos()

            rfechasDesde.Value = Date.Now.AddDays(-7)
            rfechasHasta.Value = Date.Now
            btnAnular.Enabled = False
            AsociarMenu()
            AsientosContablesCompraDocN()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub LlenaCombos()
        Try
            oeMoneda.Activo = True
            oeMoneda.TipoOperacion = "1"
            LlenarComboMaestro(cboMoneda, olMoneda.Listar(oeMoneda), 0)

            cboMaterialServicio.SelectedIndex = 0

            oeTipoPago.Activo = True
            LlenarComboMaestro(cboTipoPago, olTipoPago.Listar(oeTipoPago), 0)
            cboProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend

            oeMoneda = New e_Moneda
            oeMoneda.Activo = True
            oeMoneda.TipoOperacion = "1"
            llMoneda.AddRange(olMoneda.Listar(oeMoneda))
            LlenarComboMaestro(cboMoneda, llMoneda, 0)

            oeEstado.Activo = True
            oeEstado.Nombre = "COMPRAS"
            lstEstado = olEstado.Listar(oeEstado)
            LlenarComboMaestro(cboEstadoFacturaM, lstEstado, 0)

            'oeEstado.Id = "CERO"
            'oeEstado.Nombre = "TODOS"
            'llEstado.Add(oeEstado)
            'oeEstado = New e_Estado
            'oeEstado.Activo = True
            'llEstado.AddRange(lstEstado)
            'LlenarComboMaestro(cboEstadoFactura, llEstado, 0)

            'Proceso Tipo Documento 
            oeTipoDocumento = New e_TipoDocumento
            oeTipoDocumento.Id = "1CH000000030"
            oeTipoDocumento = olTipoDocumento.Obtener(oeTipoDocumento)

            oeMotivoDocumento = New e_MotivoDocumento
            oeMotivoDocumento.Activo = True
            oeMotivoDocumento.TipoOperacion = "2"
            oeMotivoDocumento.IdTipoDocumento = oeTipoDocumento.Id
            LlenarComboMaestro(cboMotivo, olMotivoDocumento.Listar(oeMotivoDocumento), 0)

            'Llena Combo Asociacion Doc
            Dim oeTipoDoc = New e_TipoDocumento
            oeTipoDoc.TipoOperacion = "N"
            oeTipoDoc.Activo = True
            LlenarComboMaestro(cboTipoDoc, olTipoDocumento.Listar(oeTipoDoc), 0)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Listar(ByVal Activo As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            ValidarFechaDesde_Hasta(rfFechaDocDesde, rfFechaDocHasta)
            oeMovimientoDocumento = New e_MovimientoDocumento
            With oeMovimientoDocumento
                .IdTipoDocumento = oeTipoDocumento.Id
                If rbDatosAdicionales.Checked Then
                    .Activo = Activo
                    .FechaInicio = rfFechaDocDesde.Value
                    .FechaFinal = rfFechaDocHasta.Value
                    .IndServicioMaterial = ""
                    '.IdEstadoDocumento = cboEstadoFactura.Value
                Else
                    If String.IsNullOrEmpty(txtSerie.Value) And String.IsNullOrEmpty(txtNumero.Value) Then Throw New Exception("Ingrese Serie o Número")
                    If Not String.IsNullOrEmpty(txtSerie.Value) Then .Serie = FormatoDocumento(txtSerie.Value.ToString.Trim, 4)
                    If Not String.IsNullOrEmpty(txtNumero.Value) Then .Numero = FormatoDocumento(txtNumero.Value.ToString.Trim, 10)
                End If
                .TipoOperacion = "COM"
                .PrefijoID = PrefijoIdSucursal '@0001
            End With
            With griListaNotaCredito
                .DataSource = olMovimientoDocumento.ListarDocumentosPorCompras(oeMovimientoDocumento)
                .DisplayLayout.Bands(0).Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            End With
            'Colorea la grilla de acuerdo a los estados
            For Each fila As UltraGridRow In griListaNotaCredito.Rows
                Select Case fila.Cells("EstadoDocumento").Value
                    Case "GENERADA"
                        fila.CellAppearance.BackColor = Me.ColoresGenerado.Color
                    Case "ENVIADO"
                        fila.CellAppearance.BackColor = Me.ColoresEmitido.Color
                    Case "ANULADO"
                        fila.CellAppearance.BackColor = Me.ColoresAnulado.Color
                End Select
            Next
            With griListaNotaCredito
                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub Inicializar()
        Try
            oeMovimientoDocumento = New e_MovimientoDocumento
            fecFechaActual.Value = Date.Now : cambioMon = TipoCambio(ObtenerFechaServidor, 1)(0) : decTc.Value = cambioMon
            txtSerieM.Value = String.Empty : txtNumeroM.Value = String.Empty
            cboMoneda.SelectedIndex = 0 : cboTipoPago.SelectedIndex = 0 : cboProveedor.Text = "" : cboMotivo.SelectedIndex = 2
            cboProveedor.Enabled = 1
            Me.gbeListadoMatSer.Enabled = 1 : Me.MenuDetalle.Enabled = 1
            UEGB_Ordenes.Expanded = 0 : UEGB_Ordenes.Enabled = 1
            MostrarTabs(0, ficDetalleOCMateriales, 1) : gbeListadoMatSer.Expanded = 0
            txtGlosa.Text = String.Empty
            MostrarTabs(0, ficDetalleOCMateriales, 1)
            Me.txtSubTotal.Value = 0
            Me.txtIGV.Value = 0
            Me.txtTotal.Value = 0
            lbl_etiqueta.Visible = 0
            lDetalleAsoc.Clear() : lstDetalleDocumento.Clear() : lDocumentosAsoc.Clear() : lstMovimientoDocumento.Clear()
            griDetalleAsociado.DataSource = lDetalleAsoc
            griListaDetalleNotaCredito.DataSource = lstDetalleDocumento
            GriAsocDoc.DataSource = lDocumentosAsoc
            griListaDoc.DataSource = lstMovimientoDocumento
            chk_Afecta.Checked = 0
            Me.txtSubTotal.ReadOnly = 1
            Me.txtIGV.ReadOnly = 1
            Me.txtTotal.ReadOnly = 1
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function CargarDocumentoCompra() As Boolean
        Dim id As String
        Try
            With griListaNotaCredito
                id = .ActiveRow.Cells("Id").Value.ToString
                If id.Length > 0 Then
                    oeMovimientoDocumento.Id = id
                    oeMovimientoDocumento.TipoOperacion = "COM"
                    oeMovimientoDocumento.PrefijoID = PrefijoIdSucursal '@0001
                    oeMovimientoDocumento = olMovimientoDocumento.ObtenerDocumentosPorCompras(oeMovimientoDocumento)
                    If oeMovimientoDocumento.Activo Then
                        fecFechaActual.Value = oeMovimientoDocumento.FechaEmision
                        ListarProveedores(cboProveedor, oeMovimientoDocumento.IdClienteProveedor, 0)
                        cboProveedor.Value = oeMovimientoDocumento.IdClienteProveedor
                        cboEstadoFacturaM.Value = oeMovimientoDocumento.IdEstadoDocumento.Trim
                        txtNumeroM.Value = oeMovimientoDocumento.Numero
                        txtSerieM.Value = oeMovimientoDocumento.Serie
                        cboTipoPago.Value = oeMovimientoDocumento.IdTipoPago
                        cboMoneda.Value = oeMovimientoDocumento.IdMoneda
                        IndMaterialServicio = oeMovimientoDocumento.IndServicioMaterial
                        CargarDetalleDocumento(oeMovimientoDocumento.IndServicioMaterial)
                        CargarAsociacion(id)
                        If griListaDetalleNotaCredito.Rows.Count = 0 Then chk_Afecta.Checked = 1 : txtTotal.ReadOnly = 0
                        txtTotal.Value = oeMovimientoDocumento.Total
                        txtSubTotal.Value = oeMovimientoDocumento.SubTotal
                        txtIGV.Value = oeMovimientoDocumento.IGV
                        decTc.Value = oeMovimientoDocumento.TipoCambio
                        totalSinIgv = oeMovimientoDocumento.SubTotal
                        totalIgv = oeMovimientoDocumento.IGV
                        totalConIng = oeMovimientoDocumento.Total
                        txtGlosa.Text = oeMovimientoDocumento.Glosa
                        cboMotivo.Value = oeMovimientoDocumento.IdMotivoDocumento
                        Return True
                    Else
                        Throw New Exception(Me.Text & ": El Registro se encuentra eliminado y no se puede editar")
                    End If

                Else
                    Throw New Exception("Seleccione una Fila!")
                End If
            End With
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Sub CargarDetalleDocumento(ByVal IndMaterialServicio As String)
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeDetalleDocumento = New e_DetalleDocumento
            oeDetalleDocumento.TipoOperacion = "COM"
            oeDetalleDocumento.Activo = 1
            oeDetalleDocumento.IdMovimientoDocumento = oeMovimientoDocumento.Id
            oeDetalleDocumento.PrefijoID = PrefijoIdSucursal '@0001
            If IndMaterialServicio.Equals("M") Then
                oeDetalleDocumento.IndServicioMaterial = "M"
                lstDetalleDocumento = olDetalleDocumento.Listar(oeDetalleDocumento)
            Else
                oeDetalleDocumento.IndServicioMaterial = "S"
                lstDetalleDocumento = olDetalleDocumento.Listar(oeDetalleDocumento)
            End If
            LLenarDetalleDocumento(lstDetalleDocumento)
            llenaCombosGrilla(griListaDetalleNotaCredito)
            If griListaDetalleNotaCredito.Rows.Count > 0 Then griListaDetalleNotaCredito.Focus()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarAsociacion(ByVal IdDocumento As String)
        Try
            oeDocAsoc = New e_MovimientoDocumento
            oeDocAso2 = New e_DocumentoAsociado
            oeDocAso2.TipoOperacion = ""
            oeDocAso2.IdMovimientoDocumento = IdDocumento
            oeDocAso2.Activo = True
            oeDocAso2 = olDocAsoc.Obtener(oeDocAso2)
            oeDocAso2.PrefijoID = PrefijoIdSucursal '@0001
            If Not oeDocAso2.Id Is Nothing Then
                oeDocAso2.TipoOperacion = "A"
                oeDocAsoc.Id = oeDocAso2.IdMovimientoDocumentoAsoc
                oeDocAsoc.TipoOperacion = "COM"
                oeDocAsoc = olMovimientoDocumento.ObtenerDocumentosPorCompras(oeDocAsoc)
                oeDocAsoc.PrefijoID = PrefijoIdSucursal '@0001
                lDocumentosAsoc.Add(oeDocAsoc)
                oeMovimientoDocumento.DocAsoc.Add(oeDocAso2)
                GriAsocDoc.DataBind()
                CargarDetalleAsoc(oeDocAsoc.Id)
                cboProveedor.Enabled = 0
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LLenarDetalleDocumento(ByVal leDetalleDoc As List(Of e_DetalleDocumento))
        With griListaDetalleNotaCredito
            leActivo = New List(Of e_DetalleDocumento)
            For Each obj As e_DetalleDocumento In leDetalleDoc.Where(Function(item) item.TipoOperacion Is Nothing).ToList
                obj.TipoOperacion = "A"
                obj.PrefijoID = PrefijoIdSucursal '@0001
            Next
            For Each obj As e_DetalleDocumento In leDetalleDoc.Where(Function(item) item.TipoOperacion = "E").ToList
                obj.PrefijoID = PrefijoIdSucursal '@0001
                If obj.Id = "" Then leDetalleDoc.Remove(obj)
            Next
            leActivo = leDetalleDoc.Where(Function(item) item.TipoOperacion <> "E").ToList
            .DataSource = leActivo
            llenaCombosGrilla(griListaDetalleNotaCredito)
            CalcularTotales()
        End With
    End Sub

    Private Function GuardarDocumentoCompra() As Boolean
        Try
            CargarObjects()
            If oeMovimientoDocumento.TipoCambio = 0 Then Throw New Exception("Tipo de Cambio no puede Ser 0. Verificar")
            oeMovimientoDocumento.PrefijoID = PrefijoIdSucursal '@0001
            If olMovimientoDocumento.Guardar(oeMovimientoDocumento) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Private Sub CargarObjects()
        Try
            With oeMovimientoDocumento
                .Tipo = "NOTACREDITO"
                .IdTipoDocumento = oeTipoDocumento.Id
                If Not String.IsNullOrEmpty(txtSerieM.Value) Then .Serie = FormatoDocumento(txtSerieM.Value.ToString.Trim, 4) : gfc_ValidarSerieDoc(txtSerieM.Text, "07")
                If Not String.IsNullOrEmpty(txtNumeroM.Value) Then .Numero = FormatoDocumento(txtNumeroM.Value.ToString.Trim, 8) : gfc_ValidarNumeroDoc(txtNumeroM.Text, "07")
                .TipoCambio = decTc.Value
                .Activo = True
                .IdUsuarioCrea = gUsuarioSGI.Id
                .IdClienteProveedor = cboProveedor.Value
                .FechaEmision = fecFechaActual.Value
                .FechaVencimiento = fecFechaActual.Value
                .IdEstadoDocumento = cboEstadoFacturaM.Value
                .IndCompraVenta = 1
                .IdTipoPago = cboTipoPago.Value
                .IdMoneda = cboMoneda.Value
                .Moneda = cboMoneda.Text
                .SubTotal = Math.Round(txtSubTotal.Value, 4)
                .Total = Math.Round(txtTotal.Value, 4)
                .Saldo = .Total
                .IGV = Math.Round(txtIGV.Value, 4)
                ._Operador = -1
                .Mac_PC_Local = MacPCLocal()
                .lstDetalleDocumento = lstDetalleDocumento
                .Compra.Igv1 = IIf(.IdMoneda = "1CH01", txtIGV.Value, Math.Round(txtIGV.Value * decTc.Value, 4))
                .Compra.Base1 = IIf(txtIGV.Value = 0, 0, IIf(.IdMoneda = "1CH01", txtSubTotal.Value, Math.Round(txtSubTotal.Value * decTc.Value, 4)))
                .Compra.TipoOperacion = .TipoOperacion
                .Compra.IdTipoPago = cboTipoPago.Value
                .Compra.NoGravadas = IIf(txtIGV.Value <> 0, 0, IIf(.IdMoneda = "1CH01", txtSubTotal.Value, Math.Round(txtSubTotal.Value * decTc.Value, 4)))
                .Compra.IdMotivoDocumento = cboMotivo.Value
                .Compra.Glosa = txtGlosa.Text.Trim
                .IndServicioMaterial = IndMaterialServicio
                '-- Algunas Restricciones
                If .DocAsoc.Count = 0 Then Throw New Exception("Asociar Documento !!")
                For Each docaso As e_DocumentoAsociado In .DocAsoc
                    If chk_Afecta.Checked Then
                        docaso.IndAfectaDocumento = True
                    Else
                        docaso.IndAfectaDocumento = False
                    End If
                Next
                If Not chk_Afecta.Checked Then
                    If .lstDetalleDocumento.Where(Function(item) item.TipoOperacion <> "E").Count = 0 Then Throw New Exception("Ingrese Detalles !!")
                    If .lstDetalleDocumento.Where(Function(item) (item.TipoOperacion <> "E" And item.Subtotal = 0)).Count > 0 Then Throw New Exception("Verificar Cantidad y Precios en Detalles !!")
                Else
                    If txtTotal.Value = 0 Then Throw New Exception("Ingrese Total.")
                End If
                '----
                .PrefijoID = PrefijoIdSucursal '@0001
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarDetalleAsoc(ByVal IdDocumentoAsoc As String)
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeDetalleDocumento = New e_DetalleDocumento
            oeDetalleDocumento.TipoOperacion = "COM"
            oeDetalleDocumento.Activo = 1
            oeDetalleDocumento.IdMovimientoDocumento = IdDocumentoAsoc
            oeDetalleDocumento.PrefijoID = PrefijoIdSucursal '@0001
            If IndMaterialServicio.Equals("M") Then
                oeDetalleDocumento.IndServicioMaterial = "M"
                lDetalleAsoc = olDetalleDocumento.Listar(oeDetalleDocumento)
            Else
                oeDetalleDocumento.IndServicioMaterial = "S"
                lDetalleAsoc = olDetalleDocumento.Listar(oeDetalleDocumento)
            End If
            griDetalleAsociado.DataSource = lDetalleAsoc
            llenaCombosGrilla(griDetalleAsociado)
            griDetalleAsociado.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarDetalle()
        Try
            For Each oeDet As e_DetalleDocumento In lDetalleAsoc.Where(Function(detalle) detalle.Seleccion)
                oeDet.Seleccion = 0
                If BuscaMaterialServicio(oeDet.IdMaterialServicio) Then griListaDetalleNotaCredito.DataBind() : Throw New Exception("Material ya esta Agregado")
                oeDet.Id = ""
                oeDet.TipoOperacion = "I"
                oeDet.UsuarioCreacion = gUsuarioSGI.Id
                oeDet.Seleccion = False
                oeDet.Activo = True
                oeDet.Pos = lstDetalleDocumento.Count
                oeDet.PrefijoID = PrefijoIdSucursal '@0001
                lstDetalleDocumento.Add(oeDet)
            Next
            LLenarDetalleDocumento(lstDetalleDocumento)
            griDetalleAsociado.Rows.ExpandAll(True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub QuitarDetalle()
        Try
            Select Case ficDetalleOCMateriales.SelectedTab.Index
                Case 0
                    Dim sw As Boolean = False
                    For Each oeDD As e_DetalleDocumento In lstDetalleDocumento.Where(Function(item) item.Seleccion)
                        sw = True
                    Next
                    If Not sw Then Throw New Exception("Marque por lo menos un registro para quitar de lista")
                    If MessageBox.Show("¿Esta seguro eliminar los registros marcados? ", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        For Each oeDD As e_DetalleDocumento In lstDetalleDocumento.Where(Function(item) item.Seleccion)
                            oeDD.TipoOperacion = "E"
                            oeDD.PrefijoID = PrefijoIdSucursal '@0001
                        Next
                        LLenarDetalleDocumento(lstDetalleDocumento)
                    End If
                Case 1
                    If GriAsocDoc.Selected.Rows.Count > 0 Then
                        If MessageBox.Show("¿Esta seguro eliminar el Documento Asociado? ", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            lDocumentosAsoc.Clear()
                            oeMovimientoDocumento.DocAsoc.Clear()
                            lDetalleAsoc.Clear()
                            For Each oeDD As e_DetalleDocumento In lstDetalleDocumento
                                oeDD.TipoOperacion = "E"
                                oeDD.PrefijoID = PrefijoIdSucursal '@0001
                            Next
                            LLenarDetalleDocumento(lstDetalleDocumento)
                            griDetalleAsociado.DataBind()
                            GriAsocDoc.DataBind()
                            cboProveedor.DataSource = Nothing
                            cboProveedor.Text = ""
                            cboProveedor.Enabled = 1
                        End If
                    Else
                        mensajeEmergente.Confirmacion("Seleccione Documento.", True)
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Sub llenaCombosGrilla(ByVal grilla As ISL.Controles.Grilla)
        Try
            For i As Integer = 0 To grilla.Rows.Count - 1
                oeUnidadMedida = New e_UnidadMedida()
                oeUnidadMedida.Activo = True
                oeUnidadMedida.Factor = 0
                oeUnidadMedida.IdTipoUnidadMedida = grilla.Rows(i).Cells("IdTipoUnidadMedida").Value.ToString
                CrearComboGridPorCelda("IdUnidadMedida", "Nombre", i, grilla, olUnidadMedida.ComboGrilla(oeUnidadMedida), True)
            Next
            grilla.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function BuscaMaterialServicio(ByVal lsId As String) As Boolean
        With griListaDetalleNotaCredito
            For Each fila As UltraGridRow In griListaDetalleNotaCredito.Rows
                If fila.Cells("IdMaterialServicio").Value = lsId Then
                    Return True
                End If
            Next
            Return False
        End With
    End Function

    Public Sub CalcularTotales()
        Dim Total As Double = 0
        Dim flag As Boolean = False
        txtSubTotal.Value = 0
        txtIGV.Value = 0
        txtTotal.Value = 0
        For Each oeDetalleOC As e_DetalleDocumento In leActivo
            Total += oeDetalleOC.Cantidad * oeDetalleOC.Precio
            If oeDetalleOC.IndGravado Then flag = True
        Next
        txtTotal.Value = Math.Round(Total, 4)
        If flag Then
            txtSubTotal.Value = Math.Round(Total / (oeIGV.Porcentaje + 1), 4)
            txtIGV.Value = Math.Round(txtTotal.Value - txtSubTotal.Value, 4)
        Else
            txtIGV.Value = 0
            txtSubTotal.Value = txtTotal.Value
        End If
    End Sub

    Private Sub AnularDocumentoCompra()
        Try
            Editar()
            lbl_etiqueta.Text = "Anulando Nota Credito"
            lbl_etiqueta.Visible = 1
            oeMovimientoDocumento.TipoOperacion = "1"
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub EnviaATesoreria()
        Try
            If Not griListaNotaCredito.ActiveRow Is Nothing AndAlso griListaNotaCredito.ActiveRow.Cells("ID").Value.ToString.Length > 0 Then
                Dim frm As New Frm_PeriodoTipoAsiento(True, False, False, "CMP")
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    oeMovimientoDocumento = New e_MovimientoDocumento
                    oeMovimientoDocumento.Id = griListaNotaCredito.ActiveRow.Cells("Id").Value
                    oeMovimientoDocumento = olMovimientoDocumento.Obtener(oeMovimientoDocumento)
                    oeMovimientoDocumento.PrefijoID = PrefijoIdSucursal '@0001
                    Dim oeTipDoc As New e_TipoDocumento
                    olTipoDocumento = New l_TipoDocumento
                    oeTipDoc.Id = oeMovimientoDocumento.IdTipoDocumento
                    oeTipDoc = olTipoDocumento.Obtener(oeTipDoc)
                    oeMovimientoDocumento.Compra.TipoDoc = oeTipDoc
                    If oeMovimientoDocumento.EstadoDocumento = gNombreEstadoEnviado Then Throw New Exception("El Documento ya ha Sido Enviado. Verificar")
                    Dim FechaPeriodo As Date = CDate("01/" & frm.cboMes.Text & "/" & frm.Año1.Año)
                    If ValidarFechasPeriodo(oeMovimientoDocumento.FechaEmision, FechaPeriodo) Then
                        Dim oePeriodo As New e_Periodo, olPeriodo As New l_Periodo
                        oePeriodo.Id = frm.cboMes.Value
                        oePeriodo.Ejercicio = frm.Año1.Año
                        oePeriodo.TipoOperacion = String.Empty : oePeriodo.Activo = True
                        oePeriodo = olPeriodo.Obtener(oePeriodo)
                        oeMovimientoDocumento.FechaFinal = oePeriodo.FechaFin
                        GuardarCmpAsiento(frm.cboMes.Value, frm.Año1.Año)
                        mensajeEmergente.Confirmacion("Se Envió Correctamente", True)
                        Listar(True)
                    End If
                End If
            Else
                mensajeEmergente.Problema("Seleccione un Documento", True)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AsociarDocumento()
        Try
            If lDocumentosAsoc.Count = 1 Then
                Exit Sub
            End If
            oeDocAsoc = New e_MovimientoDocumento
            oeDocAsoc = griListaDoc.ActiveRow.ListObject
            oeDocAso2 = New e_DocumentoAsociado
            lDocumentosAsoc.Add(oeDocAsoc)
            oeDocAso2.TipoOperacion = "I"
            oeDocAso2.IdMovimientoDocumentoAsoc = oeDocAsoc.Id
            oeDocAso2.Activo = True
            oeDocAso2.PrefijoID = PrefijoIdSucursal '@0001
            oeMovimientoDocumento.DocAsoc.Add(oeDocAso2)
            GriAsocDoc.DataBind()
            ListarProveedores(cboProveedor, oeDocAsoc.IdClienteProveedor)
            cboProveedor.Value = oeDocAsoc.IdClienteProveedor
            cboProveedor.Enabled = 0
            cboMoneda.Value = oeDocAsoc.IdMoneda
            CargarDetalleAsoc(oeDocAsoc.Id)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_NotaCredito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gf_AsignarEventoSeleccionarTexto(Me)
        gmt_ConfigurarEventoKeyEnter_Tab(Me, cboProveedor.Name, btnBuscarOrdenes.Name)
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        InicializaTiempo()
        If sOrden Then IniciarFormulario()
        sOrden = 1
        ComboGrillaTipoDocumento(GriAsocDoc, "COMPRAS")
    End Sub

    Private Sub frm_FacturaCompra_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_FacturaCompra_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub frm_FacturaCompra_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Select Case Operacion
            Case "Nuevo"
                MyBase.Nuevo()
            Case "Editar"
                MyBase.Editar()
                If cboEstadoFacturaM.Value <> "GENERADA" Then ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 0)
            Case "Inicializa"
                MostrarTabs(0, ficNotaCredito)
                ControlBoton(1, 1)
                If griListaNotaCredito.Rows.Count > 0 Then ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
        End Select
    End Sub

    Private Sub griListaDetalleFactura_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaDetalleNotaCredito.AfterCellUpdate
        Try
            Select Case e.Cell.Column.Key
                Case "Seleccion"
                    With griListaDetalleNotaCredito.Rows(e.Cell.Row.Index)
                        If .Cells("Seleccion").Value Then
                            .Appearance.BackColor = VerdeClaro
                            .Appearance.ForeColor = Rojo
                        Else
                            .Appearance.BackColor = Blanco
                            .Appearance.ForeColor = Negro
                        End If
                    End With
                Case "IndGravado"
                    With griListaDetalleNotaCredito.Rows(e.Cell.Row.Index)
                        swIgv = .Cells("IndGravado").Value
                        posGrilla = .Cells("Pos").Value
                        If swIgv Then
                            .Cells("Precio").Value = Math.Round(.Cells("PrecioUnitarioSinImp").Value * (1 + oeIGV.Porcentaje), 4)
                        Else
                            .Cells("Precio").Value = Math.Round(.Cells("PrecioUnitarioSinImp").Value, 4)
                        End If
                        griListaDetalleNotaCredito.DataBind()
                    End With
                    CalcularTotales()
                Case "Cantidad"
                    With griListaDetalleNotaCredito.ActiveRow
                        If .Cells("Cantidad").Value < 0 Then
                            .Cells("Cantidad").Value = cantmat
                            Throw New Exception("El cantidad ingresada no puede ser menor o igual a 0. ")
                        End If
                        If .Cells("Cantidad").Value.Equals("") Then
                            .Cells("Cantidad").Value = 1
                        End If
                        .Cells("Total").Value = .Cells("Precio").Value * .Cells("Cantidad").Value
                        .Cells("SubTotal").Value = IIf(swIgv, Math.Round(.Cells("Total").Value / (oeIGV.Porcentaje + 1), 4), Math.Round(.Cells("Total").Value, 4))
                        .Cells("IGV").Value = Math.Round(.Cells("Total").Value - .Cells("SubTotal").Value, 4)
                    End With
                    CalcularTotales()
                Case "Precio"
                    Dim PrecioUnitarioConImp As Double
                    Dim PrecioUnitarioSinImp As Double
                    With griListaDetalleNotaCredito.ActiveRow
                        swIgv = .Cells("IndGravado").Value
                        If .Index > -1 Then
                            PrecioUnitarioConImp = Convert.ToDouble(.Cells("Precio").Value)
                            If PrecioUnitarioConImp < 0 Then
                                .Cells("Precio").Value = cantmat
                                Throw New Exception("El precio unitario con impuesto no puede ser menor o igual a 0.")
                            End If
                            PrecioUnitarioSinImp = IIf(swIgv, Math.Round(PrecioUnitarioConImp / (oeIGV.Porcentaje + 1), 4), Math.Round(PrecioUnitarioConImp, 4))
                            .Cells("PrecioUnitarioSinImp").Value = PrecioUnitarioSinImp
                            .Cells("Total").Value = .Cells("Precio").Value * .Cells("Cantidad").Value
                            .Cells("SubTotal").Value = IIf(swIgv, Math.Round(.Cells("Total").Value / (oeIGV.Porcentaje + 1), 4), Math.Round(.Cells("Total").Value, 4))
                            .Cells("IGV").Value = Math.Round(.Cells("Total").Value - .Cells("SubTotal").Value, 4)
                        End If
                    End With
                    CalcularTotales()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaDetalleFactura_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles griListaDetalleNotaCredito.BeforeCellUpdate
        With griListaDetalleNotaCredito
            Select Case e.Cell.Column.Key
                Case "Cantidad", "Precio"
                    If IsDBNull(e.NewValue) Then
                        e.Cancel = True
                        Exit Sub
                    End If
                    cantmat = e.Cell.Value

            End Select
        End With
    End Sub

    Private Sub griListaFacturaCompra_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaNotaCredito.DoubleClick
        If griListaNotaCredito.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        AnularDocumentoCompra()
    End Sub

    Private Sub rbDatosAdicionales_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDatosAdicionales.CheckedChanged
        gbDatosAdicionales.Enabled = rbDatosAdicionales.Checked
        txtSerie.Text = String.Empty
        txtNumero.Text = String.Empty
    End Sub

    Private Sub rbNroDoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNroDoc.CheckedChanged
        gbNroDoc.Enabled = rbNroDoc.Checked
        txtSerie.Focus()
    End Sub

    Private Sub cboMoneda_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMoneda.ValueChanged
        Try
            If Operacion <> "Inicializa" And ficNotaCredito.SelectedTab.Index = 1 Then
                If oeMovimientoDocumento.TipoOperacion = "I" Then
                    decTc.Value = TipoCambio(fecFechaActual.Value)(0)
                ElseIf oeMovimientoDocumento.TipoOperacion = "A" Then
                    If decTc.Value = 0 Then
                        decTc.Value = TipoCambio(fecFechaActual.Value)(0)
                    Else
                        If MessageBox.Show("Desea Cambiar al Tipo de Cambio del dia?", "Mensaje del sistema", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) _
                        = Windows.Forms.DialogResult.Yes Then
                            decTc.Value = TipoCambio(fecFechaActual.Value)(0)
                        End If
                    End If
                End If
            End If
            oeIGV = New e_Impuesto
            Dim olImp As New l_Impuesto
            oeIGV = olImp.IGV(fecFechaActual.Value)

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaFacturaCompra_AfterRowActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaNotaCredito.AfterRowActivate
        btnAnular.Enabled = 0
        cmdEnviaTesoreria.Enabled = 0
        If griListaNotaCredito.ActiveRow.Index > -1 Then
            If griListaNotaCredito.ActiveRow.Cells("EstadoDocumento").Value = "GENERADA" Then
                btnAnular.Enabled = 1 : cmdEnviaTesoreria.Enabled = 1
            End If
        End If
    End Sub

    Private Sub btnBuscarOrdenes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarOrdenes.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            ValidarFechaDesde_Hasta(rfechasDesde, rfechasHasta)
            Dim oeMovDoc As New e_MovimientoDocumento
            With oeMovDoc
                .FechaInicio = rfechasDesde.Value
                .FechaFinal = rfechasHasta.Value
                .Activo = 1
                .IdTipoDocumento = cboTipoDoc.Value
                .IndCompraVenta = 1
                .IndServicioMaterial = cboMaterialServicio.Value
                .IdEstadoDocumento = "1CH00009"
                .TipoOperacion = "COM"
                .PrefijoID = PrefijoIdSucursal '@0001
            End With
            lstMovimientoDocumento = olMovimientoDocumento.ListarDocumentosPorCompras(oeMovDoc)
            griListaDoc.DataSource = lstMovimientoDocumento
            griListaDoc.DisplayLayout.Bands(0).Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            With griListaDoc
                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub txtSerie_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerie.Validated
        If Not String.IsNullOrEmpty(txtSerie.Text) Then txtSerie.Text = FormatoDocumento(txtSerie.Text, 4)
    End Sub

    Private Sub txtNumero_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.Validated
        If Not String.IsNullOrEmpty(txtNumero.Text) Then txtNumero.Text = FormatoDocumento(txtNumero.Text, 8)
    End Sub

    Private Sub txtSerieM_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerieM.Validated
        If Not String.IsNullOrEmpty(txtSerieM.Text) Then txtSerieM.Text = FormatoDocumento(txtSerieM.Text, 4)
    End Sub

    Private Sub txtNumeroM_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumeroM.Validated
        If Not String.IsNullOrEmpty(txtNumeroM.Text) Then txtNumeroM.Text = FormatoDocumento(txtNumeroM.Text, 8)
    End Sub

    Private Sub fecFechaActual_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles fecFechaActual.Validated
        Try
            If Operacion <> "Inicializa" And ficNotaCredito.SelectedTab.Index = 1 Then
                If oeMovimientoDocumento.TipoOperacion = "I" Then
                    decTc.Value = TipoCambio(fecFechaActual.Value)(0)
                ElseIf oeMovimientoDocumento.TipoOperacion = "A" Then
                    If decTc.Value = 0 Then
                        decTc.Value = TipoCambio(fecFechaActual.Value)(0)
                    Else
                        If MessageBox.Show("Desea Cambiar al Tipo de Cambio del dia?", "Mensaje del sistema", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) _
                        = Windows.Forms.DialogResult.Yes Then
                            decTc.Value = TipoCambio(fecFechaActual.Value)(0)
                        End If
                    End If
                End If
            End If
            oeIGV = New e_Impuesto
            Dim olImp As New l_Impuesto
            oeIGV = olImp.IGV(fecFechaActual.Value)

        Catch ex As Exception
            decTc.Value = 0.0
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cmdEnviaTesoreria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEnviaTesoreria.Click
        Try
            EnviaATesoreria()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboProveedor_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboProveedor.InitializeLayout
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
            ListarProveedores(cboProveedor)
        End If
    End Sub

    Private Sub cboProveedor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboProveedor.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cboProveedor.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub griListaDoc_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaDoc.DoubleClick
        If griListaDoc.Selected.Rows.Count > 0 Then AsociarDocumento()
    End Sub

    Private Sub griDetalleAsociado_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griDetalleAsociado.CellChange
        Try
            griDetalleAsociado.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub chk_Afecta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Afecta.CheckedChanged
        txtTotal.Value = 0
        If chk_Afecta.Checked Then
            txtTotal.ReadOnly = 0
            gbeListadoMatSer.Expanded = 0
            gbeListadoMatSer.Enabled = 0
            MostrarTabs(1, ficDetalleOCMateriales, 1)
        Else
            txtTotal.ReadOnly = 1
            gbeListadoMatSer.Enabled = 1
            MostrarTabs(1, ficDetalleOCMateriales, 0)
        End If
        For Each oeDD As e_DetalleDocumento In lstDetalleDocumento
            oeDD.TipoOperacion = "E"
            oeDD.PrefijoID = PrefijoIdSucursal '@0001
        Next
        LLenarDetalleDocumento(lstDetalleDocumento)
    End Sub

    Private Sub txtTotal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotal.ValueChanged
        If Not griListaDetalleNotaCredito.Rows.Count > 0 Then
            txtSubTotal.Value = txtTotal.Value / (1 + oeIGV.Porcentaje)
            txtIGV.Value = txtTotal.Value - txtSubTotal.Value
        End If
    End Sub

    Private Sub griListaDetalleNotaCredito_CellChange(sender As Object, e As CellEventArgs) Handles griListaDetalleNotaCredito.CellChange
        Try
            griListaDetalleNotaCredito.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Menu y tabs"
    Private Sub MenuDetalle_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles MenuDetalle.ToolClick
        Select Case e.Tool.Key
            Case "Agregar"
                AgregarDetalle()
            Case "Eliminar"
                QuitarDetalle()
        End Select
    End Sub
#End Region

#Region "Menú contextual"

    Private Sub AsociarMenu()
        griListaNotaCredito.ContextMenuStrip = MenuContextual2
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

    Private Sub AnularToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnularToolStripMenuItem4.Click
        AnularDocumentoCompra()
    End Sub

    Private Sub EnviarTesoreriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnviarTesoreriaToolStripMenuItem.Click
        Try
            EnviaATesoreria()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub MenuContextual2_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual2.Opening
        MenuContextual2.Items("NuevoToolStripMenuItem1").Visible = 1
        MenuContextual2.Items("ActualizarToolStripMenuItem2").Visible = 0
        MenuContextual2.Items("EliminarToolStripMenuItem3").Visible = 0
        MenuContextual2.Items("AnularToolStripMenuItem4").Visible = 0
        MenuContextual2.Items("EnviarTesoreriaToolStripMenuItem").Visible = 0
        If griListaNotaCredito.Selected.Rows.Count > 0 Then
            If griListaNotaCredito.ActiveRow.Cells("EstadoDocumento").Value = "GENERADA" Then
                MenuContextual2.Items("AnularToolStripMenuItem4").Visible = 1
                MenuContextual2.Items("EnviarTesoreriaToolStripMenuItem").Visible = 1
                MenuContextual2.Items("ActualizarToolStripMenuItem2").Visible = 1
                MenuContextual2.Items("EliminarToolStripMenuItem3").Visible = 1
            Else
                MenuContextual2.Items("AnularToolStripMenuItem4").Visible = 0
                MenuContextual2.Items("EnviarTesoreriaToolStripMenuItem").Visible = 0
                MenuContextual2.Items("ActualizarToolStripMenuItem2").Visible = 0
                MenuContextual2.Items("EliminarToolStripMenuItem3").Visible = 0
            End If
        End If
    End Sub

#End Region

#Region "Valida Solo Ingrese Numeros"
    Private Sub txtSerie_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerie.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtNumero_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Consultar(True)
        End If
    End Sub
    Private Sub txtSerieD_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    'Private Sub txtSerieM_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerieM.KeyPress
    '    If Char.IsDigit(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If
    'End Sub
    Private Sub txtNumeroM_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeroM.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
#End Region

#Region "Asiento Modelo"

    Private Sub AsientosContablesCompraDocN()
        AsientoModelo()
        CtaCtbleSubFamilia()
        CtaCtbleCatServicio()
        dtReferencia = GeneraDTRef(loReferencia)
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

    Private Sub CtaCtbleSubFamilia()
        oeCtaCtbleSFam = New e_CtaCtbleSubFamiliaMat
        loCtaCtbleSFam = olCtaCtbleSFam.Listar(oeCtaCtbleSFam)
    End Sub

    Private Sub CtaCtbleCatServicio()
        olCtaCtbleCSer = New l_CtaCtbleCatServicio
        oeCtaCtbleCSer = New e_CtaCtbleCatServicio : loCtaCtbleCSer = New List(Of e_CtaCtbleCatServicio)
        loCtaCtbleCSer = olCtaCtbleCSer.Listar(oeCtaCtbleCSer)
    End Sub

    Public Sub ObtenerAsientoModelo(IdMoneda As String, IdTipoDocumento As String, Ejercicio As Integer, Tipo As String)
        Try
            Dim dtAux = New Data.DataTable
            Dim _rwAux() As Data.DataRow
            Dim cadSQL As String = String.Empty
            cadSQL = "TipoRef1 = 4 AND IdRef1 = '" & IdMoneda & "' AND TipoRef2 = 5 AND IdRef2 = '" & IdTipoDocumento & _
                "' AND TipoRef3 = 10 AND Ref3 = '" & IIf(Tipo = "M", "MATERIAL", "SERVICIO") & "'"
            _rwAux = dtReferencia.Select(cadSQL, "")
            If _rwAux.Count = 0 Then Throw New Exception("Error en el Modelo de Asiento Contable. Verificar")
            dtAux = _rwAux.CopyToDataTable
            oeAsientoModeloNotaCredito = New e_AsientoModelo
            With oeAsientoModeloNotaCredito
                .TipoOperacion = "" : .Activo = True
                .Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString
                .Ejercicio = Ejercicio
                oeAsientoModeloNotaCredito = olAsientoModelo.Obtener(oeAsientoModeloNotaCredito)
                oeMovimientoDocumento.loAsientoModelo.Add(oeAsientoModeloNotaCredito)
                For Each oe As e_DetalleAsientoModelo In oeAsientoModeloNotaCredito.leDetalle
                    If oe.IndDocumento Then
                        oeMovimientoDocumento.IdCuentaContable = oe.IdCuentaContable.Trim
                    End If
                Next
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GuardarCmpAsiento(IdPeriodo As String, Periodo As Integer)
        Try
            With oeMovimientoDocumento
                .IdPeriodo = IdPeriodo
                .Ejercicio = Periodo
                .Compra.TipoDoc = oeTipoDocumento
                .IndOrigenContable = 2 ' Doc. Logístico.
                .PrefijoID = PrefijoIdSucursal '@0001
                If .IndServicioMaterial = "M" Then
                    Dim oeDocAsic As New e_DocumentoAsociado
                    oeDocAsic.IdMovimientoDocumento = .Id
                    oeDocAsic = olDocAsoc.Obtener(oeDocAsic)
                    oeDocAsic.PrefijoID = PrefijoIdSucursal '@0001
                    .IndAsientoGuia = True
                    .loCtaCtbleSFam = New List(Of e_CtaCtbleSubFamiliaMat)
                    If oeDocAsic.IndAfectaDocumento Then
                        .loCtaCtbleSFam = ProrrateaCuentas(oeDocAsic.IdMovimientoDocumentoAsoc, oeMovimientoDocumento, loCtaCtbleSFam, Periodo)
                        ObtenerAsientoModelo(.IdMoneda, .IdTipoDocumento, Periodo, .IndServicioMaterial)
                    Else
                        .loCtaCtbleSFam = LlenaCuenta(oeMovimientoDocumento, loCtaCtbleSFam, Periodo)
                        ObtenerAsientoModelo(oeMovimientoDocumento.IdMoneda, oeMotivoDocumento.IdTipoDocumento, Periodo, .IndServicioMaterial)
                    End If
                    oeMovimientoDocumento.IdUsuarioCrea = gUsuarioSGI.Id
                    oeMovimientoDocumento.PrefijoID = PrefijoIdSucursal '@0001
                    olMovimientoDocumento.GuardarCompraMaterial(oeMovimientoDocumento)
                Else
                    Dim oeDocAsic As New e_DocumentoAsociado
                    oeDocAsic.IdMovimientoDocumento = .Id
                    oeDocAsic = olDocAsoc.Obtener(oeDocAsic)
                    oeDocAsic.PrefijoID = PrefijoIdSucursal '@0001
                    .IndAsientoGuia = True
                    .loCtaCtbleCSer = New List(Of e_CtaCtbleCatServicio)
                    .loCtaCtbleCSer = LlenaCuentaCatServicio(oeMovimientoDocumento, loCtaCtbleCSer, Periodo)
                    ObtenerAsientoModelo(oeMovimientoDocumento.IdMoneda, oeMotivoDocumento.IdTipoDocumento, Periodo, .IndServicioMaterial)
                    oeMovimientoDocumento.IdUsuarioCrea = gUsuarioSGI.Id
                    oeMovimientoDocumento.PrefijoID = PrefijoIdSucursal '@0001
                    olMovimientoDocumento.GuardarCmpServicio(oeMovimientoDocumento)
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class
