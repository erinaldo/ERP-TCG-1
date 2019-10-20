'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction

Public Class frm_FacturaPeaje
    Inherits ISL.Win.frm_MenuPadre

#Region "Declaración de variables"

    Private oeGasto As e_GastoOperacion
    Private olGasto As l_GastoOperacion
    Private loGasto As List(Of e_GastoOperacion)

    Private oeDocumento As e_MovimientoDocumento
    Private olDocumento As l_MovimientoDocumento

    Private oeDetalleDoc As e_DetalleDocumento
    Private loDetalleDoc As List(Of e_DetalleDocumento)

    Private olProveedor As l_Proveedor
    Private oeProveedor As e_Proveedor

    Private oeCombo As e_Combo

#End Region

#Region "Inicialización del formulario"

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Shared instancia As frm_FacturaPeaje = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        Operacion = "Inicializa"
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_FacturaPeaje
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            Inicializar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarDocumento() Then
                mensajeEmergente.Confirmacion("La Informacion ha Sido Guardada Correctamente", True)
                Inicializar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try

            'If grid_ListRegComsumoComb.Rows.Count = 0 Then Throw New Exception("No hay ningún registro de consumo de combustible para exportar al Excel")
            'Exportar_Excel(grid_ListRegComsumoComb)

            'If grilisDetDocCom.Rows.Count = 0 Then Throw New Exception("No hay ningún detalle de Combustibles para exportar al Excel")
            'Exportar_Excel(grilisDetDocCom)

            'MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Metodos"

    Private Sub InicializarForm()
        Try
            oeProveedor = New e_Proveedor
            olGasto = New l_GastoOperacion
            olProveedor = New l_Proveedor
            olDocumento = New l_MovimientoDocumento
            Inicializar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarCombos()
        Try
            'Moneda
            cboMoneda.DataSource = MonedaPublic
            cboMoneda.SelectedIndex = 0
            cboMoneda.DisplayMember = "Descripcion"
            'Tipo de Pago
            LlenarComboMaestro(cboTipoPago, TipoPagoPublic, 0)
            'Tracto
            LlenarCombo(cboTractoLista, "Nombre", TractoPublic, -1)
            'Proveedor
            ComboProveedor()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboProveedor()
        Try
            oeProveedor = New e_Proveedor

            Dim ListaProveedor As New List(Of e_Proveedor)
            oeProveedor.TipoOperacion = "5"
            cboProveedores.Value = Nothing
            ListaProveedor.AddRange(olProveedor.Listar(oeProveedor))
            With cboProveedores
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = ListaProveedor
            End With
            InicializarComboProveedor()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub InicializarComboProveedor()
        Try
            Me.cboProveedores.ValueMember = "Id"
            Me.cboProveedores.DisplayMember = "Nombre"
            With cboProveedores.DisplayLayout.Bands(0)
                '.Columns("Id").Hidden = True
                .Columns("Codigo").Hidden = True
                .Columns("TipoPersonaEmpresa").Hidden = True
                .Columns("IdPersona").Hidden = True
                .Columns("IdEmpresa").Hidden = True
                .Columns("FechaActividad").Hidden = True
                .Columns("UsuarioCreacion").Hidden = True
                .Columns("Activo").Hidden = True
                .Columns("Seleccion").Hidden = True
                .Columns("Email").Hidden = True
                .Columns("Contacto").Hidden = True
                .Columns("NroDocumento").Header.Caption = "RUC"
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializar()
        Try
            oeGasto = New e_GastoOperacion
            loDetalleDoc = New List(Of e_DetalleDocumento)
            griDetalleDoc.DataSource = loDetalleDoc
            loGasto = New List(Of e_GastoOperacion)
            griGasto.DataSource = loGasto
            cboProveedores.Value = Nothing
            dtpFechaEmision.Value = ObtenerFechaServidor()
            txtSerie.Value = String.Empty
            txtNumero.Value = String.Empty
            cboTipoPago.SelectedIndex = 0
            DecTotalImponible.Value = 0
            DecTotalIgv.Value = 0
            DecTotalDoc.Value = 0
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            loDetalleDoc = New List(Of e_DetalleDocumento)
            griDetalleDoc.DataSource = loDetalleDoc
            If cboProveedores.Value <> Nothing Then
                oeGasto = New e_GastoOperacion
                oeGasto.TipoOperacion = "P"
                oeGasto.IdCuentaCorriente = cboProveedores.Value
                oeGasto.FechaEmision = fecDesde.Value
                oeGasto.FechaCreacion = fecHasta.Value
                oeGasto.IdFlujoCaja = IIf(cboTractoLista.SelectedIndex <> -1, cboTractoLista.Value, "")
                loGasto = olGasto.Listar(oeGasto)
                griGasto.DataSource = loGasto
            Else
                Throw New Exception("Seleccione Proveedor")
            End If      
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub AgregarDetalle()
        Try
            If ValidarDuplicado() Then
                If loGasto.Where(Function(i) i.IndAlmacen = True).Count > 0 Then
                    For Each oe As e_GastoOperacion In loGasto.Where(Function(i) i.IndAlmacen = True).ToList
                        oeDetalleDoc = New e_DetalleDocumento
                        oeDetalleDoc.TipoOperacion = "I"
                        oeDetalleDoc.IdGastoOperacion = oe.Id
                        oeDetalleDoc.IdVehiculo = oe.IdTipoVehiculo
                        oeDetalleDoc.IdItemGasto = oe.Proveedor
                        oeDetalleDoc.IdMaterialServicio = "1CH000000395"
                        oeDetalleDoc.CodigoMaterialServicio = "CH00000006"
                        oeDetalleDoc.NombreMaterialServicio = "PEAJES Y ESTACIONAMIENTO"
                        oeDetalleDoc.IdTipoUnidadMedida = oe.SerieDoc + " - " + oe.NroDoc
                        oeDetalleDoc.IndServicioMaterial = "S"
                        oeDetalleDoc.IdUnidadMedida = "1PY000000011"
                        oeDetalleDoc.UnidadMedida = oe.Vehiculo
                        oeDetalleDoc.Cantidad = 1
                        oeDetalleDoc.Precio = oe.Total
                        oeDetalleDoc.Subtotal = oe.Total / (1 + oeIGVGlobal.Porcentaje)
                        oeDetalleDoc.Igv = oeDetalleDoc.Precio - oeDetalleDoc.Subtotal
                        oeDetalleDoc.IndGravado = True
                        oeDetalleDoc.UsuarioCreacion = gUsuarioSGI.Id
                        oeDetalleDoc.FactorRefUni = 0
                        oeDetalleDoc.PrefijoID = gs_PrefijoIdSucursal '@0001
                        loDetalleDoc.Add(oeDetalleDoc)
                    Next
                End If
                griDetalleDoc.DataBind()
                CheckBox1.Checked = False
                CalcularTotalDocumento()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarDetalle()
        Try
            For index = loDetalleDoc.Count - 1 To 0 Step -1
                If loDetalleDoc(index).Seleccion = True Then
                    loDetalleDoc.RemoveAt(index)
                End If
            Next
            griDetalleDoc.DataBind()
            CalcularTotalDocumento()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ValidarDuplicado() As Boolean
        Try
            For Each oe As e_DetalleDocumento In loDetalleDoc
                For Each oe1 As e_GastoOperacion In loGasto.Where(Function(i) i.IndAlmacen = True).ToList
                    If oe.IdGastoOperacion = oe1.Id Then
                        Throw New Exception("Documento: " + oe1.SerieDoc + oe1.NroDoc + ". Ya se Encuentra Agregado")
                    End If
                Next
            Next
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub CalcularTotalDocumento()
        Try
            Dim Total As Double = 0
            Dim SubTotal As Double = 0
            Dim Igv As Double = 0
            For Each oe As e_DetalleDocumento In loDetalleDoc
                Total += oe.Precio
            Next
            DecTotalDoc.Value = Math.Round(Total, 4, MidpointRounding.AwayFromZero)
            DecTotalImponible.Value = Math.Round(Total / (1 + oeIGVGlobal.Porcentaje), 4, MidpointRounding.AwayFromZero)
            DecTotalIgv.Value = Math.Round(DecTotalDoc.Value - DecTotalImponible.Value, 4, MidpointRounding.AwayFromZero)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GuardarDocumento() As Boolean
        Try
            If ValidarDocumento() Then
                oeDocumento = New e_MovimientoDocumento
                oeCombo = New e_Combo
                oeCombo = cboTipoPago.Items(cboTipoPago.SelectedIndex).ListObject
                oeDocumento.TipoOperacion = "I"
                If Not String.IsNullOrEmpty(Me.txtSerie.Value) Then oeDocumento.Serie = FormatoDocumento(txtSerie.Value.ToString.Trim, 4)
                If Not String.IsNullOrEmpty(Me.txtNumero.Value) Then oeDocumento.Numero = FormatoDocumento(txtNumero.Value.ToString.Trim, 10)
                oeDocumento.FechaEmision = dtpFechaEmision.Value
                oeDocumento.IdClienteProveedor = cboProveedores.Value
                oeDocumento.FechaVencimiento = oeDocumento.FechaEmision.AddDays(CInt(oeCombo.Descripcion))
                oeDocumento.IndServicioMaterial = "S"
                oeDocumento.EstadoDocumento = "GENERADA"
                oeDocumento.Tipo = "FACTURACOMPRA"
                oeDocumento.IndCompraVenta = 1
                oeDocumento.IdTipoDocumento = ObtenerTipoDocumento("FACTURA")
                oeDocumento.Mac_PC_Local = MacPCLocal()
                oeDocumento.IdMoneda = cboMoneda.Value
                oeDocumento.Compra.TipoOperacion = "I"
                oeDocumento.Compra.IdTipoPago = cboTipoPago.Value
                oeDocumento.SubTotal = DecTotalImponible.Value
                oeDocumento.IGV = DecTotalIgv.Value
                oeDocumento.Total = DecTotalDoc.Value
                oeDocumento.Saldo = DecTotalDoc.Value
                oeDocumento.TipoCambio = numTipoCambio.Value
                oeDocumento.IdUsuarioCrea = gUsuarioSGI.Id
                If oeDocumento.IGV > 0 Then
                    oeDocumento.Compra.Base1 = oeDocumento.SubTotal
                    oeDocumento.Compra.Igv1 = oeDocumento.IGV
                Else
                    oeDocumento.Compra.Base1 = 0
                    oeDocumento.Compra.Igv1 = 0
                    oeDocumento.Compra.NoGravadas = oeDocumento.Total
                End If
                oeDocumento.lstDetalleDocumento = loDetalleDoc
                oeDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeDocumento.Compra.PrefijoID = gs_PrefijoIdSucursal '@0001
                If Not olDocumento.Guardar(oeDocumento) Then
                    Return False
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerTipoDocumento(ByVal NomTipoDocumento As String) As String
        Try
            Dim oeTipoDocumento As New e_TipoDocumento
            Dim olTipoDocumento As New l_TipoDocumento
            oeTipoDocumento.TipoOperacion = "L"
            oeTipoDocumento.Nombre = NomTipoDocumento
            oeTipoDocumento = olTipoDocumento.Obtener(oeTipoDocumento)
            Return oeTipoDocumento.Id
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidarDocumento() As Boolean
        Try
            If cboProveedores.Value <> Nothing Then
                oeProveedor = New e_Proveedor
                oeProveedor.Id = cboProveedores.Value
                oeProveedor.TipoOperacion = "5"
                oeProveedor = olProveedor.Obtener(oeProveedor)
                If oeProveedor.Id = "" Then Throw New Exception("Seleccione Proveedor")
            Else
                Throw New Exception("Seleccione Proveedor")
            End If
            For Each oe As e_DetalleDocumento In loDetalleDoc
                If oe.Precio = 0 Then Throw New Exception("Verifique Totales de Detalle")
                If oe.IdItemGasto <> oeProveedor.Id Then Throw New Exception("Verifique Proveedor")
            Next
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Eventos"

    Private Sub frm_FacturaPeaje_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ControlBoton(1, 0, 0, 1)
    End Sub


    Private Sub frm_FacturaPeaje_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_FacturaPeaje_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_FacturaPeaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            InicializarForm()
            CargarCombos()
            ControlBoton(1, 0, 0, 1)
            numTipoCambio.Value = TipoCambio(dtpFechaEmision.Value, True)(0)
            fecDesde.Value = Date.Now.AddDays(-25)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            AgregarDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub BtnQuitar_Click(sender As Object, e As EventArgs) Handles BtnQuitar.Click
        Try
            QuitarDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtSerie_Validated(sender As Object, e As EventArgs) Handles txtSerie.Validated
        txtSerie.Text = FormatoDocumento(txtSerie.Text, 4)
    End Sub

    Private Sub txtNumero_Validated(sender As Object, e As EventArgs) Handles txtNumero.Validated
        txtNumero.Text = FormatoDocumento(txtNumero.Text, 10)
    End Sub

    Private Sub frm_FacturaPeaje_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Try
            Me.numTotal.Value = 0
            If CheckBox1.Checked Then
                For Each obj In griGasto.Rows.Where(Function(item) item.IsFilteredOut = False)
                    obj.Cells("IndAlmacen").Value = True
                Next
            Else
                For Each obj In griGasto.Rows.Where(Function(item) item.IsFilteredOut = False)
                    obj.Cells("IndAlmacen").Value = False
                Next
            End If
            Me.numTotal.Value = loGasto.Where(Function(i) i.IndAlmacen = True).Sum(Function(i) i.Total)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub dtpFechaEmision_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaEmision.ValueChanged
        numTipoCambio.Value = TipoCambio(dtpFechaEmision.Value, True)(0)
    End Sub

    Private Sub griGasto_CellChange(sender As Object, e As CellEventArgs) Handles griGasto.CellChange
        griGasto.UpdateData()
    End Sub

    Private Sub cboProveedores_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboProveedores.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                Listar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDetalleDoc_CellChange(sender As Object, e As CellEventArgs) Handles griDetalleDoc.CellChange
        griDetalleDoc.UpdateData()
    End Sub

    Private Sub griDetalleDoc_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griDetalleDoc.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Try
            If griDetalleDoc.Rows.Count > 0 Then Exportar_Excel(griDetalleDoc, "DetalleDoc")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Try
            If griGasto.Rows.Count > 0 Then Exportar_Excel(griGasto, "DetalleGasto")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

End Class