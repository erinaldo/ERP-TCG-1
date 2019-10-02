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

Public Class frm_ControlPagos
    Inherits ISL.Win.frm_MenuPadre

#Region "Declaración de variables"

    Private WithEvents oeMovimientoDocumento As New e_MovimientoDocumento
    Private olMovimientoDocumento As New l_MovimientoDocumento

    Private leMovDoc As New List(Of e_MovimientoDocumento)
    Private leCuentaxCyP As New List(Of e_CuentaxCyP)

    Private oePeriodo As New e_Periodo
    Private olPeriodo As New l_Periodo

    Private oeCuentaxCyP As New e_CuentaxCyP
    Private olCuentaxCyP As New l_CuentaxCyP

    Private oeAsiento As New e_Asiento
    Private olAsiento As New l_Asiento

    Private _ComboPeriodo As Boolean = False
    Private _ComboFlujoCaja As Boolean = False

    Private Shared instancia As frm_ControlPagos = Nothing
    Private Shared Operacion As String

    Dim ListaProveedor As New List(Of e_Combo)
    Dim Buscar As Boolean = True

#End Region

#Region "Inicialización del formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ControlPagos()
        End If
        instancia.Activate()
        Return instancia

    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar()
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    Public Overrides Sub Exportar()
        Try
            If gridDocumentos.Rows.Count = 0 Then Throw New Exception("No hay ningún Pago para exportar al Excel")
            Exportar_Excel(gridDocumentos)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Function validarbusqueda() As Boolean
        Try
            ValidarCombo(cboProveedorFactura, "Proveedor")
            If Trim(cboProveedorFactura.Value) = "" Then Throw New Exception("Seleccione un Cliente válido.")
            If Len(Trim(cboProveedorFactura.Value)) <> 12 Then Throw New Exception("Seleccione un Cliente válido.")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Listar()
        Try
            If validarbusqueda() Then
                Me.Cursor = Cursors.WaitCursor
                oeMovimientoDocumento = New e_MovimientoDocumento
                leMovDoc.Clear()

                oeMovimientoDocumento.TipoOperacion = "CPA"
                oeMovimientoDocumento.IdPeriodo = cboMes.Value
                oeMovimientoDocumento.Activo = True
                oeMovimientoDocumento.Ejercicio = dtpFechaEjercicio.Value.Year
                oeMovimientoDocumento.IdClienteProveedor = cboProveedorFactura.Value

                leMovDoc.AddRange(olMovimientoDocumento.Listar(oeMovimientoDocumento))
                gridDocumentos.DataBind()
                gridDocumentos.Text = "Documentos: " + cboMes.Text + " / " + dtpFechaEjercicio.Value.Year.ToString
                leCuentaxCyP.Clear()
                GridPagos.DataBind()
                OcultarColumna(gridDocumentos, True, "Retencion_Letra", "Retencion_Saldo", "IndDetalleGlosa", "Retencion", "MontoCanje")
                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        gridDocumentos.Focus()
    End Sub

    Private Sub LlenaProveedor()

        Try
            LlenarComboMaestro(cboProveedorFactura, ProveedorPublic, 0)

            Dim oeProveedor As New e_Proveedor
            Dim leProveedor As New List(Of e_Proveedor)
            Dim olProveedor As New l_Proveedor
            oeProveedor.Activo = True
            leProveedor.AddRange(olProveedor.Listar(oeProveedor))
            gridDocumentos.DisplayLayout.ValueLists.Add("IdClienteProveedor")
            With gridDocumentos.DisplayLayout.ValueLists("IdClienteProveedor").ValueListItems
                .Clear()
                For Each oeTD As e_Proveedor In leProveedor
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdClienteProveedor", "Nombre", gridDocumentos, True)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaMoneda()
        Try

            Dim oeMoneda As New e_Moneda
            Dim olMoneda As New l_Moneda
            Dim leMoneda As New List(Of e_Moneda)
            oeMoneda.Activo = True
            leMoneda.AddRange(olMoneda.Listar(oeMoneda))
            '--------------------- para llenar combo en grilla    
            gridDocumentos.DisplayLayout.ValueLists.Add("IdMoneda")
            With gridDocumentos.DisplayLayout.ValueLists("IdMoneda").ValueListItems
                .Clear()
                For Each oeTD As e_Moneda In leMoneda
                    .Add(oeTD.Id, oeTD.Abreviatura)
                Next
            End With
            CrearComboGrid3("IdMoneda", "Abreviatura", gridDocumentos, True)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboPeriodo()
        Try
            If _ComboPeriodo Then
                oePeriodo = New e_Periodo
                Dim olPeriodo As New l_Periodo
                Dim lePeriodo As New List(Of e_Periodo)
                lePeriodo.Add(oePeriodo)
                oePeriodo.Ejercicio = dtpFechaEjercicio.Value.Year
                oePeriodo.Activo = True
                lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))
                With cboMes
                    .DisplayMember = "NomMes"
                    .ValueMember = "Id"
                    .DataSource = lePeriodo
                    If .Items.Count > 0 Then
                        .SelectedIndex = 0
                    End If
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarCombos()
        Try
            ComboPeriodo()
            LlenaCuentaBancaria()
            LlenaProveedor()
            LlenaMoneda()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializar()
        Try
            Me.Text = "Control de Pagos"
            gridDocumentos.DataSource = leMovDoc
            GridPagos.DataSource = leCuentaxCyP
            _ComboPeriodo = True
            LlenarCombos()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub LlenaTipoDocumentoOperacion()
        Try
            Dim oeTipoDoc As New e_TipoDocumento
            Dim leTipoDoc As New List(Of e_TipoDocumento)
            Dim olTipoDoc As New l_TipoDocumento
            oeTipoDoc.Activo = True
            oeTipoDoc.TipoOperacion = "C" 'proceso contabilidad
            leTipoDoc.AddRange(olTipoDoc.Listar(oeTipoDoc))
            '--------------------- para llenar combo en grilla    
            gridDocumentos.DisplayLayout.ValueLists.Add("IdTipoDocumento")
            With gridDocumentos.DisplayLayout.ValueLists("IdTipoDocumento").ValueListItems
                .Clear()
                For Each oeTD As e_TipoDocumento In leTipoDoc
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdTipoDocumento", "Nombre", gridDocumentos, True)
            '------------------------------------------
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub LlenaCuentaBancaria()
        Try

            Dim oeCuentaBancaria As New e_CuentaBancaria
            Dim olCuentaBancaria As New l_CuentaBancaria
            Dim leCuentaBancaria As New List(Of e_CuentaBancaria)
            oeCuentaBancaria.Activo = True
            leCuentaBancaria.AddRange(olCuentaBancaria.Listar(oeCuentaBancaria))
            '--------------------- para llenar combo en grilla    
            GridPagos.DisplayLayout.ValueLists.Add("IdCuentaBancaria")
            With GridPagos.DisplayLayout.ValueLists("IdCuentaBancaria").ValueListItems
                .Clear()
                For Each oeCtaBan As e_CuentaBancaria In leCuentaBancaria
                    .Add(oeCtaBan.Id, oeCtaBan.NumeroCuenta)
                Next
            End With
            CrearComboGrid3("IdCuentaBancaria", "NumeroCuenta", GridPagos, True)
            '--------------------- para llenar combo en grilla    

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ControlPagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Inicializar()
        'cboMes.Text = Date.Now.Month.ToString
        LlenaTipoDocumentoOperacion()
    End Sub

    Private Sub frm_ControlPagos_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
    End Sub

    Private Sub dtpFechaEjercicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaEjercicio.ValueChanged
        Try
            ComboPeriodo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gridDocumentos_DoubleClickCell_1(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickCellEventArgs) Handles gridDocumentos.DoubleClickCell
        Try
            If gridDocumentos.ActiveRow.Cells("id").Value.ToString = "" Then
                Throw New Exception("Seleccione Documento")
            End If
            oeCuentaxCyP = New e_CuentaxCyP
            leCuentaxCyP.Clear()

            oeCuentaxCyP.IdMovimientoDocumento = gridDocumentos.ActiveRow.Cells("id").Value
            oeCuentaxCyP.TipoOperacion = "PAG"
            oeCuentaxCyP.Fecha = "01/01/1901"
            oeCuentaxCyP.Activo = True
            leCuentaxCyP.AddRange(olCuentaxCyP.Listar(oeCuentaxCyP))

            CalcularTotales(GridPagos, "MontoMN", "MontoMe")

            If leCuentaxCyP.Count <= 0 Then
                mensajeEmergente.Problema("No existen Pagos Asociados a este documento", True)
            End If

            GridPagos.DataBind()

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_ControlPagos_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub cboMes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMes.ValueChanged
        'Try
        '    If cboMes.SelectedIndex >= 0 Then
        '        Listar()
        '    End If
        'Catch ex As Exception
        '    Throw ex
        'End Try
    End Sub

    Private Sub cboProveedorFactura_InitializeLayout(sender As Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboProveedorFactura.InitializeLayout
        Try
            With cboProveedorFactura.DisplayLayout.Bands(0)
                .Columns("Id").Hidden = True
                .Columns("Descripcion").Hidden = True
                .Columns("Nombre").Hidden = False
                .Columns("Nombre").Width = 350
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboProveedorFactura_KeyDown(sender As Object, e As KeyEventArgs) Handles cboProveedorFactura.KeyDown
        Try
            With CType(sender, Infragistics.Win.UltraWinGrid.UltraCombo)
                If e.KeyData = Keys.Delete Then
                    .Text = ""
                End If
            End With
            If e.KeyCode = Keys.Enter Then
                If cboProveedorFactura.Text.Trim = "" Then
                    cboProveedorFactura.DataSource = Nothing
                    cboProveedorFactura.DataSource = ProveedorPublic
                Else
                    cboProveedorFactura.DataSource = Nothing
                    ListaProveedor = New List(Of e_Combo)
                    ListaProveedor = ProveedorPublic
                    cboProveedorFactura.DataSource = ListaProveedor.Where(Function(Item) Item.Nombre.Contains(cboProveedorFactura.Text.Trim)).ToList
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboProveedorFactura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboProveedorFactura.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cboProveedorFactura.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub Extornar_Click(sender As Object, e As EventArgs) Handles Extornar.Click
        Try
            If GridPagos.ActiveRow.Selected = True Then
                oeAsiento = New e_Asiento
                oeAsiento.Id = GridPagos.ActiveRow.Cells("IdAsiento").Value
                oeAsiento._IdMovimientoCajaBanco = GridPagos.ActiveRow.Cells("IdMovimientoCajaBanco").Value
                oeAsiento.IdPeriodo = GridPagos.ActiveRow.Cells("Periodo").Value
                oeAsiento.IdUsuarioCrea = gUsuarioSGI.Id
                oeAsiento.NroAsiento = IIf(GridPagos.ActiveRow.Cells("NroBoucher").Value Is String.Empty, GridPagos.ActiveRow.Cells("TipoCodigoObligacion").Value, GridPagos.ActiveRow.Cells("NroBoucher").Value)
                If MsgBox("¿Desea eliminar el Pago? - Afectara a todos los Pagos relacionados ", MsgBoxStyle.YesNo, "Mensaje de Sistema") = MsgBoxResult.Yes Then
                    If olAsiento.EliminarCobroPago(oeAsiento) Then
                        mensajeEmergente.Confirmacion("Extorno satisfactorio.", True)
                        Listar()
                    End If
                End If
                Listar()
            Else
                Throw New Exception("Seleccione una fila válida.")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        Try
            If GridPagos.ActiveRow.Selected = True Then
                Dim IdMovCajaBanco As String = ""
                IdMovCajaBanco = Trim(GridPagos.ActiveRow.Cells("IdMovimientoCajaBanco").Value.ToString)
                If IdMovCajaBanco <> "" Then
                    Dim frm2 As New frm_ImprimeCobroPagoAnticipo(IdMovCajaBanco, 0, "Documento")
                    frm2.ShowDialog()
                    frm2 = Nothing
                Else
                    Throw New Exception("No existe movimiento para ser impreso.")
                End If
            Else
                Throw New Exception("Seleccione una fila válida.")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

 #End Region

End Class