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
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports System.Windows.Forms
Imports System.IO
Imports Infragistics.Documents.Excel
Imports System.Text

Public Class frm_FacturacionCombustible
    Inherits frm_MenuPadre

#Region "Declaración de variables"

    'Manejador de Movimiento Documento
    Dim oeMovimientoDocumento As e_MovimientoDocumento, olMovimientoDocumento As l_MovimientoDocumento
    Dim lstDetDocumento As List(Of e_DetalleDocumento)

    'Manejador de Detalle Documento Combustible
    Dim oeDetDocumentoCombustible As e_DetalleDocumentoCombustible, olDetDocumentoCombustible As l_DetalleDocumentoCombustible
    Dim lstDetDocumentoCombustible As List(Of e_DetalleDocumentoCombustible)

    'Declaración de instancia para el control de modificaciones de la entidad en el formulario
    Private WithEvents oeRegConsumoCombustible As e_RegistroConsumoCombustible

    Dim olRegConsumoCombustible As l_RegistroConsumoCombustible
    Dim lstRegConsumoCombustible As List(Of e_RegistroConsumoCombustible)

    'Manejador de Proveedor
    Dim oeProveedor As e_Proveedor, olProveedor As l_Proveedor

    'Manejador de Lugares
    Dim oeCcpp As e_CCPP, olCcpp As l_CCPP

    'Manejador de Proceso
    Dim oeProceso As e_ProcesoNegocio, olProceso As l_ProcesoNegocio

    'Manejador de Proceso Tipo de Documento
    Dim oeProDoc As e_ProcesoTipoDocumento, olProDoc As l_ProcesoTipoDocumento

    'Manejador de Tipo de Documento
    Dim oeTipoDocumento As e_TipoDocumento, olTipoDocumento As l_TipoDocumento

    'Manejador de Monedas
    Dim oeMoneda As e_Moneda, olMoneda As l_Moneda
    Dim llMoneda As List(Of e_Moneda)

    'Manejador de Tipo de Pago
    Dim oeTipoPago As e_TipoPago, olTipoPago As l_TipoPago
    Dim llTipoPago As List(Of e_TipoPago)

    'Manejador de Estados
    Dim oeEstado As e_Estado, olEstado As l_Estado

    'Manejador de Material
    Dim oeMaterial As e_Material, olMaterial As l_Material

    'Manejador de DetalleDocumento
    Dim oeDetalleMovimientoDoc As e_DetalleDocumento, olDetalleMovimientoDoc As l_DetalleDocumento
    Dim _ingresando_datos As Boolean = False
    'Manejador para Obtener el Igv
    Dim oeIGV As e_Impuesto, olIGV As l_Impuesto

    'optimizar agregar detalles para facturacion
    Dim loMaterial As List(Of e_Material)

    Dim oeDireccion As e_Direccion, olDireccion As l_Direccion

#End Region

#Region "Inicialización del formulario"

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Shared instancia As frm_FacturacionCombustible = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        Operacion = "Inicializa"
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_FacturacionCombustible
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            MostrarTabs(1, ficConCombustible, 1)
            MyBase.Consultar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            Operacion = "Nuevo"
            Inicializar()
            gbMateriales.Expanded = False
            oeMovimientoDocumento.IdUsuarioCrea = gUsuarioSGI.Id
            oeMovimientoDocumento.TipoOperacion = "I"
            oeMovimientoDocumento.Compra.TipoOperacion = "I"
            oeMovimientoDocumento.Compra.IndTipoOperacion = "C" '----para diferenciar Tipo de operacion
            oeMovimientoDocumento.Activo = True
            MostrarTabs(0, ficConCombustible, 1)
            MyBase.Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            MyBase.Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarMovimientoDocumento() Then
                MostrarTabs(1, ficConCombustible, 1)
                MyBase.Guardar()
            Else
                MostrarTabs(0, ficConCombustible, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            Inicializar()
            ControlBoton(0, 1, 0, 0, 0, 0, 0, 0, 1)
            MostrarTabs(1, ficConCombustible, 1)
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
            If grid_ListRegComsumoComb.Rows.Count = 0 Then Throw New Exception("No hay ningún registro de consumo de combustible para exportar al Excel")
            Exportar_Excel(grid_ListRegComsumoComb)
            If grilisDetDocCom.Rows.Count = 0 Then Throw New Exception("No hay ningún detalle de Combustibles para exportar al Excel")
            Exportar_Excel(grilisDetDocCom)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Eventos del Formulario"

    Private Sub oeRegConsumoCombustible_DatoCambiado() Handles oeRegConsumoCombustible.DatoCambiado
        oeRegConsumoCombustible.Modificado = True
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            For Each item As e_RegistroConsumoCombustible In lstRegConsumoCombustible.Where(Function(x) x.Seleccion)
                oeDetDocumentoCombustible = New e_DetalleDocumentoCombustible
                oeDetDocumentoCombustible.TipoOperacion = "I"
                oeDetDocumentoCombustible.Seleccion = False
                oeDetDocumentoCombustible.UsuarioCreacion = item.IdDireccion
                oeDetDocumentoCombustible.IdRegConsumoCombustible = item.Id
                oeDetDocumentoCombustible.IdViaje = item.IdViaje
                oeDetDocumentoCombustible.CodViaje = item.CodViaje
                oeDetDocumentoCombustible.IdEmpresaGrifo = item.IdGrifo
                If item.SaldoGls > 0 Then
                    oeDetDocumentoCombustible.Cantidad = item.SaldoGls
                    oeDetDocumentoCombustible.SaldoReferencia = item.SaldoGls
                ElseIf item.SaldoGls = 0 Then
                    oeDetDocumentoCombustible.Cantidad = item.CantidadGalon
                    oeDetDocumentoCombustible.SaldoReferencia = item.CantidadGalon
                End If
                oeDetDocumentoCombustible.IndGravado = True
                oeDetDocumentoCombustible.PlacaVeh = item.PlacaVeh
                oeDetDocumentoCombustible.NroVale = item.NroVale
                oeDetDocumentoCombustible.FechaTanqueo = item.FechaTanqueo
                oeDetDocumentoCombustible.IdVehiculo = item.IdVehiculo
                oeDetDocumentoCombustible.IdMaterial = item.IdMaterial
                oeMaterial = New e_Material
                oeMaterial.Id = item.IdMaterial
                If loMaterial.Contains(oeMaterial) Then
                    oeMaterial = loMaterial.Item(loMaterial.IndexOf(oeMaterial))
                Else
                    Throw New Exception("Error en Material. Informar a Sistemas")
                End If
                'leMaterialParaAgregar.Add(oeMaterial)
                oeDetDocumentoCombustible.CodMaterial = oeMaterial.Codigo
                oeDetDocumentoCombustible.Material = oeMaterial.Nombre
                oeDetDocumentoCombustible.IdUnidadMedida = oeMaterial.IdUnidadMedida
                oeDetDocumentoCombustible.PrecioUnit = 0
                oeDetDocumentoCombustible.PrecioIGV = 0
                oeDetDocumentoCombustible.Valor = 0
                oeMovimientoDocumento.lstDetalleDocumentoCombustible.Add(oeDetDocumentoCombustible)
            Next
            grilisDetDocCom.DataBind()
            lstRegConsumoCombustible.RemoveAll(Function(item) item.Seleccion)
            grid_ListRegComsumoComb.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub BtnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitar.Click
        Try
            oeMovimientoDocumento.lstDetalleDocumentoCombustible.RemoveAll(AddressOf verificarSeleccionado)
            grid_ListRegComsumoComb.DataBind()
            grilisDetDocCom.DataBind()
            CalcularTotales()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_FacturacionCombustible_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case Operacion
            'Case "Nuevo"
            '    Nuevo()
            'Case "Editar", "Vista"
            '    Editar()
            Case "Inicializa"
                Tiempo1.Enabled = False
                InicializaTiempo()
                MostrarTabs(0, ficConCombustible, 0)
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        End Select
    End Sub

    Private Sub frm_FacturacionCombustible_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_FacturacionCombustible_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = _ingresando_datos
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub cboProveedor_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProveedor.ValueChanged
        If cboProveedor.SelectedIndex <> -1 Then
            oeMovimientoDocumento.IdClienteProveedor = cboProveedor.Value
            If cboProveedor.Value <> Nothing Then
                ObtenerLugares(ObtenerIdEmpresa)
            End If
        End If
    End Sub

    Private Sub btnListarTanqueos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarTanqueos.Click
        Try
            If Not String.IsNullOrEmpty(oeMovimientoDocumento.IdClienteProveedor) Then
                oeRegConsumoCombustible = New e_RegistroConsumoCombustible
                oeRegConsumoCombustible.TipoOperacion = 3
                oeRegConsumoCombustible.Activo = True
                oeRegConsumoCombustible.IdGrifo = ObtenerIdEmpresa()
                oeRegConsumoCombustible.IdDireccion = IIf(chkTodasDirecciones.Checked, "", cboDireccion.Value)
                oeRegConsumoCombustible.fechaInicio = rfDesde.Value
                oeRegConsumoCombustible.fechaFin = rfHasta.Value
                lstRegConsumoCombustible = olRegConsumoCombustible.Listar(oeRegConsumoCombustible)
                grid_ListRegComsumoComb.DataSource = lstRegConsumoCombustible
                If oeMovimientoDocumento.lstDetalleDocumentoCombustible.Count > 0 Then
                    lstRegConsumoCombustible.RemoveAll(AddressOf VerificaListaTanqueo)
                    grid_ListRegComsumoComb.DataBind()
                End If
            Else
                Throw New Exception("Seleccione un proveedor,por favor")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griTanNFacturado_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_ListRegComsumoComb.CellChange
        grid_ListRegComsumoComb.UpdateData()
    End Sub

    Private Sub grilisDetDocCom_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grilisDetDocCom.AfterCellUpdate
        Try
            grilisDetDocCom.UpdateData()
            With grilisDetDocCom
                oeIGV = olIGV.IGV(fecMovDoc.Value)
                Dim PorIgv As Double = oeIGV.Porcentaje
                For i = 0 To .Rows.Count - 1
                    If .Rows(i).Cells("IndGravado").Value = True Then
                        .Rows(i).Cells("PrecioUnit").Value = .Rows(i).Cells("PrecioIGV").Value / (1 + PorIgv)
                        .Rows(i).Cells("Igv").Value = .Rows(i).Cells("PrecioIGV").Value - .Rows(i).Cells("PrecioUnit").Value
                    Else
                        .Rows(i).Cells("PrecioUnit").Value = .Rows(i).Cells("PrecioIGV").Value
                        .Rows(i).Cells("Igv").Value = 0.0
                    End If
                Next
            End With
            CalcularTotales()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grilisDetDocCom_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grilisDetDocCom.CellChange
        Try
            grilisDetDocCom.UpdateData()
            With grilisDetDocCom
                oeIGV = olIGV.IGV(fecMovDoc.Value)
                Dim PorIgv As Double = oeIGV.Porcentaje
                If .ActiveRow.Cells("IndGravado").Value = True Then
                    .ActiveRow.Cells("PrecioUnit").Value = .ActiveRow.Cells("PrecioIGV").Value / (1 + PorIgv)
                    .ActiveRow.Cells("Igv").Value = .ActiveRow.Cells("PrecioIGV").Value - .ActiveRow.Cells("PrecioUnit").Value
                    .ActiveRow.Cells("Valor").Value = .ActiveRow.Cells("Cantidad").Value * .ActiveRow.Cells("PrecioIGV").Value
                Else
                    .ActiveRow.Cells("PrecioUnit").Value = .ActiveRow.Cells("PrecioIGV").Value
                    .ActiveRow.Cells("Igv").Value = 0.0
                    .ActiveRow.Cells("Valor").Value = .ActiveRow.Cells("Cantidad").Value * .ActiveRow.Cells("PrecioIGV").Value
                End If
                CalcularTotales()
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    'Private Sub txtSerie_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerie.KeyPress
    '    If Char.IsDigit(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If
    'End Sub

    Private Sub txtSerie_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSerie.Validating
        If Not String.IsNullOrEmpty(txtSerie.Text) Then
            'txtSerie.Value = String.Format("{0:0000}", Convert.ToInt32(txtSerie.Text))
            txtSerie.Text = gfc_ConcatenarCeros(txtSerie.Text, 4)
        End If
    End Sub

    Private Sub txtNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumero_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNumero.Validating
        Try
            If Not String.IsNullOrEmpty(txtNumero.Text) Then
                txtNumero.Text = String.Format("{0:00000000}", Convert.ToInt32(txtNumero.Text))
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub fecMovDoc_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles fecMovDoc.Validated
        If oeMovimientoDocumento.TipoOperacion = "I" Then
            decTipoCambio.Value = TipoCambio(fecMovDoc.Value, True)(0)
        End If
    End Sub

    Private Sub fecFechaOrden_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecMovDoc.ValueChanged
        Try
            If fecMovDoc.Value > Date.Now AndAlso Operacion = "Nuevo" Then
                fecMovDoc.Value = Date.Now
                Throw New Exception("La fecha no puede ser mayor al día actual")
            Else
                Dim diamesanterior As Date = UltimoDiaMesAnterior()
                If fecMovDoc.Value < DateAdd(DateInterval.Month, -3, diamesanterior) AndAlso Operacion = "Nuevo" Then
                    fecMovDoc.Value = Date.Now
                    Throw New Exception("La Fecha no Puede ser tan Antigua")
                Else
                    oeMovimientoDocumento.FechaEmision = fecMovDoc.Value
                    oeMovimientoDocumento.FechaVencimiento = fecMovDoc.Value
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboMoneda_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMoneda.ValueChanged
        oeMovimientoDocumento.IdMoneda = cboMoneda.Value
    End Sub

    Private Sub decTipoCambio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decTipoCambio.ValueChanged
        oeMovimientoDocumento.TipoCambio = decTipoCambio.Value
    End Sub

    Private Sub cboTipoPago_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoPago.ValueChanged
        Try
            oeMovimientoDocumento.IdTipoPago = cboTipoPago.Value
            oeMovimientoDocumento.Compra.IdTipoPago = cboTipoPago.Value
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAplicarPrecio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicarPrecio.Click
        CalcularPrecios()
    End Sub

    Private Sub grilisRegCon_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid_ListRegComsumoComb.DoubleClick
        If grid_ListRegComsumoComb.ActiveRow.Cells("Seleccion").Value = False Then
            grid_ListRegComsumoComb.ActiveRow.Cells("Seleccion").Value = True
        Else
            grid_ListRegComsumoComb.ActiveRow.Cells("Seleccion").Value = False
        End If
        btnAgregar_Click(sender, e)
    End Sub

    Private Sub frm_FacturacionCombustible_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            InicializarLogicas()
            gf_AsignarEventoSeleccionarTexto(Me)
            gmt_ConfigurarEventoKeyEnter_Tab(Me)
            Nuevo()
            rfDesde.Value = Date.Now.AddDays(-30)
            CargarMateriales()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CargarMateriales()
        Try
            oeMaterial = New e_Material
            loMaterial = New List(Of e_Material)
            oeMaterial.TipoOperacion = "G"
            oeMaterial.TipoMaterial = ""
            oeMaterial.IdFamilia = ""
            oeMaterial.IdSubFamilia = ""
            loMaterial = olMaterial.Listar(oeMaterial)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try
            If grilisDetDocCom.Rows.Count > 0 Then
                For i As Integer = 0 To grilisDetDocCom.DisplayLayout.Bands(0).Columns.BoundColumnsCount - 1
                    grilisDetDocCom.DisplayLayout.Bands(0).Columns(i).Hidden = False
                Next
                Dim sfd As New Windows.Forms.SaveFileDialog
                sfd = CargaDatosSaveFileDialog()
                If sfd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Dim cad As String = sfd.FileName
                    Try
                        Me.Cursor = Cursors.WaitCursor
                        UltraGridExcelExporter1.Export(grilisDetDocCom, sfd.FileName)
                        Me.Cursor = Cursors.Default
                        mensajeEmergente.Confirmacion("Exportación con éxito.", True)
                    Catch ex As Exception
                        Throw ex
                    End Try
                End If
                MostrarColumnas()
            Else
                Throw New Exception("No hay Datos para Exportar")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try  
    End Sub

    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        Try
            Dim PathFilePTRA As String = ""
            OpenFileDialog1 = CargaDatosOpenFileDialog()
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                'oeMovimientoDocumento = New e_MovimientoDocumento
                oeMovimientoDocumento.lstDetalleDocumento.Clear()
                PathFilePTRA = OpenFileDialog1.FileName
                If File.Exists(PathFilePTRA) Then
                    'Cargamos el archivo de excel al libro de trabajo
                    Dim libroTrabajo As Workbook = Workbook.Load(PathFilePTRA)
                    '/ / Vamos a trabajar sólo con la primera hoja del libro
                    Dim hojaTrabajo As Worksheet = libroTrabajo.Worksheets(0)
                    '/ / Vamos a colocar los datos de Excel en este DataTable
                    Dim tanquoFacturado As DataTable = New DataTable("MyData")
                    Dim contfilas As Integer = 0
                    Dim contCeldas As Integer = 0
                    '/ / Iterar a través de todas las filas de hojas de cálculo
                    For Each filahoja As WorksheetRow In hojaTrabajo.Rows
                        If contfilas = 0 Then
                            contCeldas = 0
                            '/ / Este es el encabezado de fila. Estamos suponiendo que la hoja de cálculo de Excel
                            '/ fila / primera contiene el esquema de nuestro modelo que pronto será de datos.
                            '/ / Vamos a utilizar esta información para construir nuestra esquema de DataTable
                            For Each cellhoja As WorksheetCell In filahoja.Cells
                                'string theCellValue = theWorksheetCell.Value.ToString().Trim();
                                Dim valorCelda As String = cellhoja.Value.ToString.Trim
                                'if (theCellValue != string.Empty)
                                If valorCelda <> String.Empty Then
                                    '/ / Esta es la "fila de cabecera"
                                    '/ / Crear un objeto DataColumn de cada columna tomados de la fila primera hoja de cálculo
                                    Dim datoColumna As DataColumn = tanquoFacturado.Columns.Add()
                                    '/ / Dado que esta es la fila de cabecera, se utiliza el valor de la celda
                                    '/ / como el nombre de columna
                                    'theDataColumn.ColumnName = theCellValue;
                                    datoColumna.ColumnName = valorCelda
                                    '/ / Aquí nos saltamos a la fila de datos real (la fila debajo de la fila de encabezado).
                                    '/ / Comprobar si hay más aún de datos. Compruebe si hay algún tipo de valor establecidos en
                                    '/ / Excel (si el tipo es de carácter general que se importan como FormattedString) y
                                    '/ / si por lo que los configure. Si uno de los requrements no se cumple
                                    '/ / usamos la representación de cadena por defecto
                                    If hojaTrabajo.Rows(contfilas + 1).Cells(contCeldas).Value IsNot Nothing Then
                                        If valorCelda = "Fecha" Then
                                            datoColumna.DataType = GetType(DateTime)
                                        Else
                                            datoColumna.DataType = hojaTrabajo.Rows(contfilas + 1).Cells(contCeldas).Value.GetType
                                        End If
                                    End If
                                End If
                                contCeldas += 1
                            Next
                        Else
                            '/ / Estos son los datos reales que pueblan el modelo de datos
                            contCeldas = 0
                            '/ / Agrega una nueva fila de datos vacía en nuestro modelo de datos
                            Dim filaDato As DataRow = tanquoFacturado.NewRow()
                            '/ / iterar a través de cada celda de la hoja actual y rellenar la nueva fila de datos.
                            For Each cellhoja As WorksheetCell In filahoja.Cells
                                Dim NombreCelda As String = hojaTrabajo.Rows(0).Cells(contCeldas).Value
                                Dim ValorCelda As Object = hojaTrabajo.Rows(contfilas).Cells(contCeldas).Value
                                If ValorCelda IsNot Nothing Then
                                    If NombreCelda = "Fecha" Then
                                        filaDato(contCeldas) = DateTime.FromOADate(CDbl(ValorCelda))
                                    Else
                                        filaDato(contCeldas) = ValorCelda.ToString
                                    End If

                                End If
                                contCeldas += 1
                            Next
                            oeDetDocumentoCombustible = New e_DetalleDocumentoCombustible
                            oeDetDocumentoCombustible.Seleccion = filaDato("Seleccion")
                            oeDetDocumentoCombustible.IdRegConsumoCombustible = filaDato("IdRegConsumoCombustible")
                            oeDetDocumentoCombustible.IdViaje = filaDato("IdViaje")
                            oeDetDocumentoCombustible.CodViaje = filaDato("Viaje")
                            oeDetDocumentoCombustible.IdEmpresaGrifo = filaDato("IdEmpresaGrifo")
                            oeDetDocumentoCombustible.Cantidad = filaDato("Cantidad(Gal)")
                            oeDetDocumentoCombustible.SaldoReferencia = filaDato("SaldoReferencia")
                            oeDetDocumentoCombustible.IndGravado = filaDato("Ind")
                            oeDetDocumentoCombustible.PlacaVeh = filaDato("Tracto")
                            oeDetDocumentoCombustible.NroVale = filaDato("Nro Vale")
                            oeDetDocumentoCombustible.FechaTanqueo = filaDato("Fecha")
                            oeDetDocumentoCombustible.IdVehiculo = filaDato("IdVehiculo")
                            oeDetDocumentoCombustible.IdMaterial = filaDato("IdMaterial")
                            oeDetDocumentoCombustible.CodMaterial = filaDato("Codigo")
                            oeDetDocumentoCombustible.Material = filaDato("Material")
                            oeDetDocumentoCombustible.IdUnidadMedida = filaDato("IdUnidadMedida")
                            oeDetDocumentoCombustible.PrecioUnit = filaDato("Precio")
                            oeDetDocumentoCombustible.PrecioIGV = filaDato("Precio(Igv)")
                            oeDetDocumentoCombustible.Valor = filaDato("Valor")
                            oeDetDocumentoCombustible.Igv = filaDato("Igv")
                            oeDetDocumentoCombustible.Id = "" 'filaDato("Id")
                            oeDetDocumentoCombustible.NroLinea = filaDato("NroLinea")
                            oeDetDocumentoCombustible.Activo = filaDato("Activo")
                            oeDetDocumentoCombustible.UsuarioCreacion = "" ' filaDato("UsuarioCreacion")
                            oeDetDocumentoCombustible.IdDetalleDocumento = "" 'filaDato("IdDetalleDocumento")
                            decPrecio.Value = filaDato("Precio(Igv)")
                            tanquoFacturado.Rows.Add(filaDato)
                            Dim ia As Integer = 0
                            For Each objlst In oeMovimientoDocumento.lstDetalleDocumentoCombustible
                                If (objlst.IdRegConsumoCombustible = oeDetDocumentoCombustible.IdRegConsumoCombustible) Then
                                    ia = 1
                                    Exit For
                                End If
                            Next
                            If ia = 0 Then
                                oeMovimientoDocumento.lstDetalleDocumentoCombustible.Add(oeDetDocumentoCombustible)
                            End If

                        End If
                        contfilas += 1
                    Next
                    '/ / AcceptChanges de modo que éstos no parecen ser filas NUEVOS
                    tanquoFacturado.AcceptChanges()
                    '/ / Ahora eliminamos las filas que ya estan agregadas:
                    'CASO I: Quito de la lista de no facturados los nuevos elementos agregados:
                    ' Ver línea 826
                    'CASO II: Quito de la nueva lista los detalles que ya estan agregados:
                    If oeMovimientoDocumento.lstDetalleDocumentoCombustible.Count > 0 Then
                        lstRegConsumoCombustible.RemoveAll(AddressOf VerificaListaTanqueo)
                        grid_ListRegComsumoComb.DataBind()
                    End If
                    '/ / Por último, obligar a la WinGrid a la DataTable
                    grilisDetDocCom.DataSource = oeMovimientoDocumento.lstDetalleDocumentoCombustible ' tanquoFacturado.DefaultView
                    grilisDetDocCom.DataBind()
                    CalcularTotales()
                    mensajeEmergente.Problema("Importación exitosa.")
                Else
                    mensajeEmergente.Problema("El Archivo No fue Ubicado.")
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cboDireccion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDireccion.ValueChanged
        Try
            If cboDireccion.SelectedIndex <> -1 Then
                oeRegConsumoCombustible.IdDireccion = cboDireccion.Value
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grilisDetDocCom_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grilisDetDocCom.KeyDown
        Try
            If e.KeyCode = Keys.Down Then
                Dim int As Integer = grilisDetDocCom.ActiveRow.Index
                If int > -1 Then
                    If grilisDetDocCom.Rows(int).Cells("PrecioIGV").IsActiveCell Then
                        grilisDetDocCom.PerformAction(ExitEditMode, False, False)
                        grilisDetDocCom.PerformAction(BelowCell, False, False)
                        e.Handled = True
                        grilisDetDocCom.PerformAction(EnterEditMode, False, False)
                    End If
                    If grilisDetDocCom.Rows(int).Cells("Cantidad").IsActiveCell Then
                        grilisDetDocCom.PerformAction(ExitEditMode, False, False)
                        grilisDetDocCom.PerformAction(BelowCell, False, False)
                        e.Handled = True
                        grilisDetDocCom.PerformAction(EnterEditMode, False, False)
                    End If
                End If
            End If
            If e.KeyCode = Keys.Up Then
                Dim int As Integer = grilisDetDocCom.ActiveRow.Index
                If int > -1 Then
                    If grilisDetDocCom.Rows(int).Cells("PrecioIGV").IsActiveCell Then
                        grilisDetDocCom.PerformAction(ExitEditMode, False, False)
                        grilisDetDocCom.PerformAction(AboveCell, False, False)
                        e.Handled = True
                        grilisDetDocCom.PerformAction(EnterEditMode, False, False)
                    End If
                    If grilisDetDocCom.Rows(int).Cells("Cantidad").IsActiveCell Then
                        grilisDetDocCom.PerformAction(ExitEditMode, False, False)
                        grilisDetDocCom.PerformAction(AboveCell, False, False)
                        e.Handled = True
                        grilisDetDocCom.PerformAction(EnterEditMode, False, False)
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Boton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiaTodo.Click
        Try
            With grilisDetDocCom
                If .Rows.Count > 0 Then
                    For i = 0 To .Rows.Count - 1
                        .Rows(i).Cells("Seleccion").Value = True
                    Next
                End If
            End With
            BtnQuitar_Click(sender, e)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboLugar_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLugar.ValueChanged
        Try
            If cboLugar.SelectedIndex <> -1 Then
                r_ListarDireccionesGrifo()
                If cboDireccion.Items.Count > 1 Then
                    cboDireccion.SelectedIndex = -1
                Else
                    cboDireccion.SelectedIndex = 0
                End If
            Else
                Me.cboDireccion.Value = Nothing
                Me.cboDireccion.DataSource = Nothing
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ExportarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarToolStripMenuItem.Click
        Try
            If grid_ListRegComsumoComb.Rows.Count > 0 Then
                Exportar_Excel(grid_ListRegComsumoComb)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Procedimientos del Formulario"

    Private Sub InicializarLogicas()
        olMovimientoDocumento = New l_MovimientoDocumento
        olDetDocumentoCombustible = New l_DetalleDocumentoCombustible
        olRegConsumoCombustible = New l_RegistroConsumoCombustible
        olProveedor = New l_Proveedor
        olCcpp = New l_CCPP
        olProceso = New l_ProcesoNegocio
        olProDoc = New l_ProcesoTipoDocumento
        olTipoDocumento = New l_TipoDocumento
        olMoneda = New l_Moneda
        olTipoPago = New l_TipoPago
        olEstado = New l_Estado
        olMaterial = New l_Material
        olDetalleMovimientoDoc = New l_DetalleDocumento
        olIGV = New l_Impuesto
        olDireccion = New l_Direccion
    End Sub

    Private Sub LimpiarListas()
        Try
            lstRegConsumoCombustible = New List(Of e_RegistroConsumoCombustible)
            oeMovimientoDocumento.lstDetalleDocumentoCombustible = New List(Of e_DetalleDocumentoCombustible)
            grid_ListRegComsumoComb.DataSource = lstRegConsumoCombustible
            With grid_ListRegComsumoComb
                .DisplayLayout.Bands(0).Columns("IndTanqueoNoAsoc").Hidden = True
                .DisplayLayout.Bands(0).Columns("GlosaValeTanqueo").Hidden = True
                .DisplayLayout.Bands(0).Columns("SaldoGls").Hidden = True
            End With
            grilisDetDocCom.DataSource = oeMovimientoDocumento.lstDetalleDocumentoCombustible
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ObtenerTipoDocumento(ByVal NomTipoDocumento As String) As String
        Try
            oeTipoDocumento = New e_TipoDocumento
            oeTipoDocumento.TipoOperacion = "L"
            oeTipoDocumento.Nombre = NomTipoDocumento
            oeTipoDocumento = olTipoDocumento.Obtener(oeTipoDocumento)
            Return oeTipoDocumento.Id
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Inicializar()
        Try
            oeRegConsumoCombustible = New e_RegistroConsumoCombustible
            oeMovimientoDocumento = New e_MovimientoDocumento
            Me.decImporte.Value = 0
            Me.decIgv.Value = 0
            Me.decTotal.Value = 0
            decTipoCambio.Value = 0
            txtSerie.Text = String.Empty
            txtNumero.Text = String.Empty
            oeMovimientoDocumento.FechaEmision = fecMovDoc.Value
            oeMovimientoDocumento.FechaVencimiento = fecMovDoc.Value
            oeMovimientoDocumento.Saldo = 0
            oeMovimientoDocumento.IndCompraVenta = 1
            oeMovimientoDocumento.IndServicioMaterial = "M"
            oeMovimientoDocumento._Operador = 1
            gbMateriales.Expanded = False
            CargarCombos()
            cboLugar.SelectedIndex = -1
            'cboTipoDocComb.Value = ObtenerTipoDocumento("FACTURA")
            rfHasta.Value = Date.Now
            decPrecio.Value = 0.0
            LimpiarListas()
            fecMovDoc.Value = ObtenerFechaServidor()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GuardarMovimientoDocumento() As Boolean
        Try
            Dim oe As New e_TipoPago
            oe = cboTipoPago.Items(cboTipoPago.SelectedIndex).ListObject
            'If Not String.IsNullOrEmpty(Me.txtSerie.Value) Then oeMovimientoDocumento.Serie = FormatoDocumento(txtSerie.Value.ToString.Trim, 4)
            'If Not String.IsNullOrEmpty(Me.txtNumero.Value) Then oeMovimientoDocumento.Numero = FormatoDocumento(txtNumero.Value.ToString.Trim, 10)
            oeMovimientoDocumento.Serie = txtSerie.Value.ToString.Trim
            oeMovimientoDocumento.Numero = txtNumero.Value.ToString.Trim
            gfc_ValidarSerieDoc(txtSerie.Text, "01")
            gfc_ValidarNumeroDoc(txtNumero.Text, "01")
            oeMovimientoDocumento.FechaVencimiento = oeMovimientoDocumento.FechaEmision.AddDays(oe.Dias)
            oeMovimientoDocumento.EstadoDocumento = "GENERADA"
            oeMovimientoDocumento.Tipo = "Combustible"
            oeMovimientoDocumento.IndCompraVenta = 1
            oeMovimientoDocumento.IdTipoDocumento = ObtenerTipoDocumento("FACTURA")
            oeMovimientoDocumento.Mac_PC_Local = MacPCLocal()
            oeMovimientoDocumento.IdMoneda = cboMoneda.Value
            oeMovimientoDocumento.Compra.IdTipoPago = cboTipoPago.Value
            oeMovimientoDocumento.SubTotal = decImporte.Value
            oeMovimientoDocumento.IGV = decIgv.Value
            oeMovimientoDocumento.Total = decTotal.Value
            oeMovimientoDocumento.Saldo = decTotal.Value
            If oeMovimientoDocumento.IGV > 0 Then
                oeMovimientoDocumento.Compra.Base1 = oeMovimientoDocumento.SubTotal
                oeMovimientoDocumento.Compra.Igv1 = oeMovimientoDocumento.IGV
            Else
                oeMovimientoDocumento.Compra.Base1 = 0
                oeMovimientoDocumento.Compra.Igv1 = 0
                oeMovimientoDocumento.Compra.NoGravadas = oeMovimientoDocumento.Total
            End If
            ConsolidarDetalleDocumentoCombustible()
            If ValidarPreciosCantidades() Then
                oeMovimientoDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeMovimientoDocumento.Compra.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeMovimientoDocumento = olMovimientoDocumento.Guardar(oeMovimientoDocumento)
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                Inicializar()
                ControlBoton(0, 1, 0, 0, 0, 0, 0, 0, 1)
                MostrarTabs(1, ficConCombustible, 1)
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub CalcularTotales()
        'decImporte.Value = oeMovimientoDocumento.CalcularImporte
        'decTotal.Value = oeMovimientoDocumento.CalcularTotal
        'decIgv.Value = decTotal.Value - decImporte.Value
        'oeMovimientoDocumento.SubTotal = decImporte.Value
        'oeMovimientoDocumento.IGV = decIgv.Value
        'oeMovimientoDocumento.Total = decTotal.Value
        'oeMovimientoDocumento.Saldo = decTotal.Value
        'If oeMovimientoDocumento.IGV > 0 Then
        '    oeMovimientoDocumento.Compra.Base1 = oeMovimientoDocumento.SubTotal
        '    oeMovimientoDocumento.Compra.Igv1 = oeMovimientoDocumento.IGV
        'Else
        '    oeMovimientoDocumento.Compra.Base1 = 0
        '    oeMovimientoDocumento.Compra.Igv1 = 0
        '    oeMovimientoDocumento.Compra.NoGravadas = oeMovimientoDocumento.Total
        'End If
        Dim Total As Double = 0
        Dim flag As Boolean = False
        decImporte.Value = 0
        decIgv.Value = 0
        decTotal.Value = 0
        For Each oeDetalleOC As e_DetalleDocumentoCombustible In oeMovimientoDocumento.lstDetalleDocumentoCombustible
            Total += oeDetalleOC.Cantidad * oeDetalleOC.PrecioIGV
            If oeDetalleOC.IndGravado Then flag = True
        Next
        decTotal.Value = Math.Round(Total, 4)
        If flag Then
            decImporte.Value = Math.Round(Total / (oeIGV.Porcentaje + 1), 4)
            decIgv.Value = Math.Round(decTotal.Value - decImporte.Value, 4)
        Else
            decIgv.Value = 0
            decImporte.Value = decTotal.Value
        End If
    End Sub

    Public Sub ObtenerLugares(ByVal id As String)
        Try
            cboLugar.SelectedIndex = -1
            oeCcpp = New e_CCPP
            oeCcpp.TipOoperacion = 1
            oeCcpp.Activo = True
            oeCcpp.Nombre = id
            LlenarCombo(cboLugar, "Nombre", olCcpp.Listar(oeCcpp), 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ObtenerProceso(ByVal cad As String) As String
        Try
            oeProceso = New e_ProcesoNegocio
            oeProceso.Nombre = cad.Trim
            oeProceso = olProceso.Obtener(oeProceso)
            Return oeProceso.Id
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub CargarCombos()
        Try
            'Proveedor
            oeProveedor = New e_Proveedor
            oeProveedor.TipoOperacion = 3
            oeProveedor.Activo = True
            LlenarComboMaestro(cboProveedor, olProveedor.Listar(oeProveedor), -1)
            'Moneda
            oeMoneda = New e_Moneda
            oeMoneda.Activo = True
            oeMoneda.TipoOperacion = "1"
            LlenarComboMaestro(cboMoneda, olMoneda.Listar(oeMoneda), 0)
            'Tipo de Pago
            oeTipoPago = New e_TipoPago
            llTipoPago = New List(Of e_TipoPago)
            oeTipoPago.Activo = True
            llTipoPago.AddRange(olTipoPago.Listar(oeTipoPago))
            LlenarComboMaestro(cboTipoPago, llTipoPago, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub MostrarColumnas()
        grilisDetDocCom.DisplayLayout.Bands(0).Columns("Id").Hidden = True
        grilisDetDocCom.DisplayLayout.Bands(0).Columns("IdMaterial").Hidden = True
        grilisDetDocCom.DisplayLayout.Bands(0).Columns("IdViaje").Hidden = True
        grilisDetDocCom.DisplayLayout.Bands(0).Columns("IdVehiculo").Hidden = True
        grilisDetDocCom.DisplayLayout.Bands(0).Columns("NroLinea").Hidden = True
        grilisDetDocCom.DisplayLayout.Bands(0).Columns("IdEmpresaGrifo").Hidden = True
        grilisDetDocCom.DisplayLayout.Bands(0).Columns("Activo").Hidden = True
        grilisDetDocCom.DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
        grilisDetDocCom.DisplayLayout.Bands(0).Columns("IdRegConsumoCombustible").Hidden = True
        grilisDetDocCom.DisplayLayout.Bands(0).Columns("SaldoReferencia").Hidden = True
        grilisDetDocCom.DisplayLayout.Bands(0).Columns("IdDetalleDocumento").Hidden = True
        grilisDetDocCom.DisplayLayout.Bands(0).Columns("IdUnidadMedida").Hidden = True
    End Sub

    Public Function ValidarPreciosCantidades() As Boolean
        Try
            ''''
            Dim proveedorcompara As New e_Proveedor
            proveedorcompara = cboProveedor.Items(cboProveedor.SelectedIndex).ListObject
            ''''
            If (grilisDetDocCom.Rows.Count > 0) Then
                With grilisDetDocCom
                    Dim IdUnicoGrifo As String = .Rows(0).Cells("IdEmpresaGrifo").Value
                    For i = 0 To .Rows.Count - 1
                        If .Rows(i).Cells("Cantidad").Value = 0 Or .Rows(i).Cells("PrecioIGV").Value = 0 Then
                            Throw New Exception("Existen cantidades o precios con valor de 0.00")
                        End If
                        If .Rows(i).Cells("IdEmpresaGrifo").Value <> IdUnicoGrifo Then
                            Throw New Exception("Los detalles de factura, pertenecen a mas de un mismo proveedor")
                        End If
                        If .Rows(i).Cells("IdEmpresaGrifo").Value <> proveedorcompara.IdEmpresa Then
                            Throw New Exception("Detalles de factura, pertenecen a un proveedor distinto al cual se hace referencia en cabecera")
                        End If
                        ''Verificación de que el vale no sea tanqueado
                        Dim oeReg As New e_RegistroConsumoCombustible
                        Dim lstReg As New List(Of e_RegistroConsumoCombustible)
                        oeReg.TipoOperacion = ""
                        oeReg.Id = .Rows(i).Cells("IdRegConsumoCombustible").Value
                        lstReg = olRegConsumoCombustible.Listar(oeReg)
                        For Each obj In lstReg
                            If obj.Estado = "FAC" Then
                                Throw New Exception("El vale: " + obj.NroVale + " se encuentra ya facturado")
                            End If
                        Next
                        ''
                    Next
                End With
            Else
                Throw New Exception("No existe ningun detalle para ser grabado.")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function HasLetters(ByVal formatsting As String) As Boolean
        For Each ch As Char In formatsting
            If [Char].IsLetter(ch) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub r_ListarDireccionesGrifo()
        Try
            Dim obj As New e_Proveedor
            obj = cboProveedor.Items(cboProveedor.SelectedIndex).ListObject
            oeDireccion = New e_Direccion
            oeDireccion.TipoOperacion = 1
            oeDireccion.IdTipoVia = obj.IdEmpresa
            oeDireccion.Activo = True
            oeDireccion.Id = cboLugar.Value
            LimpiaCombos(cboDireccion)
            LlenarCombo(cboDireccion, "Via", olDireccion.Listar(oeDireccion), 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub CalcularPrecios()
        Try
            If Not String.IsNullOrEmpty(decPrecio.Value) Then
                oeIGV = olIGV.IGV(fecMovDoc.Value)
                Dim PorIgv As Double = oeIGV.Porcentaje
                For Each lista As e_DetalleDocumentoCombustible In oeMovimientoDocumento.lstDetalleDocumentoCombustible
                    If chkPrecios.Checked And lista.UsuarioCreacion <> cboDireccion.Value Then Continue For
                    lista.IndGravado = True
                    lista.PrecioUnit = decPrecio.Value / (1 + PorIgv)
                    lista.Igv = decPrecio.Value - lista.PrecioUnit
                    lista.PrecioIGV = decPrecio.Value
                    lista.Valor = decPrecio.Value * lista.Cantidad
                Next
                CalcularTotales()
                grilisDetDocCom.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub ConsolidarDetalleDocumentoCombustible()
        Try
            lstDetDocumento = New List(Of e_DetalleDocumento)
            oeMovimientoDocumento.lstDetalleDocumentoCombustible = oeMovimientoDocumento.lstDetalleDocumentoCombustible.OrderBy(Function(p) p.IdViaje).ToList
            For Each item As e_DetalleDocumentoCombustible In oeMovimientoDocumento.lstDetalleDocumentoCombustible
                oeDetalleMovimientoDoc = New e_DetalleDocumento
                oeDetalleMovimientoDoc.TipoOperacion = "I"
                oeDetalleMovimientoDoc.Id = ""
                oeDetalleMovimientoDoc.IdMovimientoDocumento = ""
                oeDetalleMovimientoDoc.IndServicioMaterial = "M"
                oeDetalleMovimientoDoc.IdMaterialServicio = item.IdMaterial
                oeDetalleMovimientoDoc.IdUnidadMedida = item.IdUnidadMedida
                oeDetalleMovimientoDoc.Precio = item.PrecioIGV
                oeDetalleMovimientoDoc.IndGravado = item.IndGravado
                oeDetalleMovimientoDoc.Igv = IIf(item.IndGravado, Math.Round((item.Valor * oeIGV.Porcentaje / (1 + oeIGV.Porcentaje)), 4), 0)
                oeDetalleMovimientoDoc.Cantidad = item.Cantidad
                oeDetalleMovimientoDoc.Subtotal = Math.Round(item.Valor - oeDetalleMovimientoDoc.Igv, 4)
                oeDetalleMovimientoDoc.IdViaje = item.IdViaje
                oeDetalleMovimientoDoc.IdVehiculo = item.IdVehiculo
                oeDetalleMovimientoDoc.Activo = item.Activo
                oeDetalleMovimientoDoc.FactorRefUni = 0
                oeDetalleMovimientoDoc.IdRegistroConsCombustible = item.IdRegConsumoCombustible
                lstDetDocumento.Add(oeDetalleMovimientoDoc)
            Next
            oeMovimientoDocumento.lstDetalleDocumento = lstDetDocumento
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function verificarSeleccionado(ByVal obj As e_DetalleDocumentoCombustible) As Boolean
        Try
            If obj.Seleccion Then
                oeRegConsumoCombustible = New e_RegistroConsumoCombustible
                oeRegConsumoCombustible.TipoOperacion = ""
                oeRegConsumoCombustible.Id = obj.IdRegConsumoCombustible
                oeRegConsumoCombustible.Activo = True
                oeRegConsumoCombustible = olRegConsumoCombustible.Obtener(oeRegConsumoCombustible)
                oeRegConsumoCombustible.PlacaVeh = obj.PlacaVeh
                oeRegConsumoCombustible.Seleccion = False
                lstRegConsumoCombustible.Add(oeRegConsumoCombustible)
            End If
            Return obj.Seleccion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerIdEmpresa() As String
        Dim obj As New e_Proveedor
        obj = cboProveedor.Items(cboProveedor.SelectedIndex).ListObject
        Return obj.IdEmpresa
    End Function

    Private Function VerificaListaTanqueo(ByVal oeRegCon As e_RegistroConsumoCombustible) As Boolean
        For Each fila As e_DetalleDocumentoCombustible In oeMovimientoDocumento.lstDetalleDocumentoCombustible
            If (oeRegCon.Id = fila.IdRegConsumoCombustible) Then Return True
        Next
    End Function

#End Region

End Class
