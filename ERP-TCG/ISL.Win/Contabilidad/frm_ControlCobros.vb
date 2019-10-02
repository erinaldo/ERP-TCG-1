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

Public Class frm_ControlCobros
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

    Private Shared instancia As frm_ControlCobros = Nothing
    Private Shared Operacion As String
    Private leCliente As New List(Of e_Cliente)

    Dim BuscarDocs As Boolean = False

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
            instancia = New frm_ControlCobros()
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

    Public Overrides Sub Guardar()

    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    Public Overrides Sub Exportar()
        Try
            If gridDocumentos.Rows.Count = 0 Then Throw New Exception("No hay ningún Documento para exportar a excell")
            Exportar_Excel(gridDocumentos)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Function validarbusqueda() As Boolean
        'ValidarCombo(cboMes, "Mes")
        ValidarCombo(cboCliente, "Cliente")
       
        Return True
    End Function

    Private Sub Listar()
        Try
            If validarbusqueda() Then
                Me.Cursor = Cursors.WaitCursor
                oeMovimientoDocumento = New e_MovimientoDocumento
                leMovDoc.Clear() 'Limpiar Lista

                'Listar todas las operaciones de tipo 2 
                oeMovimientoDocumento.TipoOperacion = "CCO" ' Obtiene la lista de los documentos 
                oeMovimientoDocumento.IdPeriodo = cboMes.Value
                oeMovimientoDocumento.Activo = True
                oeMovimientoDocumento.Ejercicio = dtpFechaEjercicio.Value.Year
                oeMovimientoDocumento.IdClienteProveedor = cboCliente.Value

                leMovDoc.AddRange(olMovimientoDocumento.Listar(oeMovimientoDocumento))
                Configurar_Grilla()
                gridDocumentos.DataBind()
                gridDocumentos.Text = "Documentos: " + cboMes.Text + " / " + dtpFechaEjercicio.Value.Year.ToString
                leCuentaxCyP.Clear()
                GridCobros.DataBind()

                Me.Cursor = Cursors.Default
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        gridDocumentos.Focus()
    End Sub

    Private Sub Configurar_Grilla()
        With gridDocumentos
            OcultarColumna(gridDocumentos, True, "Retencion_Saldo", "Retencion_Letra", "Retencion", "IndDetalleGlosa", "MontoCanje", "IdUsuarioCrea", _
                      "IdTipoBien", "OrdenCompra", "FechaCreacion", "IndAnexo", "CodMotivo")
            .DisplayLayout.Bands(0).Columns("Monto_Anticipo").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .DisplayLayout.Bands(0).Columns("Monto_Anticipo").Format = "#,##0.00"
        End With
    End Sub


    Private Sub LlenaCliente()
        Try
            Dim oeCliente As New e_Cliente
            Dim olCliente As New l_Cliente
            oeCliente.Activo = True
            '   LlenarCombo(cboCliente, "Nombre", olCliente.Listar(oeCliente), 0)
            leCliente.AddRange(olCliente.Listar(oeCliente))
            '--------------------- para llenar combo en grilla gridventas   
            gridDocumentos.DisplayLayout.ValueLists.Add("IdClienteProveedor")
            With gridDocumentos.DisplayLayout.ValueLists("IdClienteProveedor").ValueListItems
                .Clear()
                For Each oeTD As e_Cliente In leCliente
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdClienteProveedor", "Nombre", gridDocumentos, True)
            With cboCliente
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = leCliente
            End With

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
            ''--------------------- para llenar combo en grilla    
            'gridCobros.DisplayLayout.ValueLists.Add("IdMoneda")
            'With gridCobros.DisplayLayout.ValueLists("IdMoneda").ValueListItems
            '    .Clear()
            '    For Each oeTD As e_Moneda In leMoneda
            '        .Add(oeTD.Id, oeTD.Abreviatura)
            '    Next
            'End With
            'CrearComboGrid3("IdMoneda", "Abreviatura", gridCobros, True)
            ''-------------------------------

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboPeriodo()

        Try
            If _ComboPeriodo = True Then
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
        ComboPeriodo()
        LlenaCuentaBancaria()
        LlenaCliente()
        LlenaMoneda()
    End Sub

    Private Sub Inicializar()
        Try
            Me.Text = "Control de Cobros"
            gridDocumentos.DataSource = leMovDoc
            Configurar_Grilla()
            GridCobros.DataSource = leCuentaxCyP
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
            GridCobros.DisplayLayout.ValueLists.Add("IdCuentaBancaria")
            With GridCobros.DisplayLayout.ValueLists("IdCuentaBancaria").ValueListItems
                .Clear()
                For Each oeCtaBan As e_CuentaBancaria In leCuentaBancaria
                    .Add(oeCtaBan.Id, oeCtaBan.NumeroCuenta)
                Next
            End With
            CrearComboGrid3("IdCuentaBancaria", "NumeroCuenta", GridCobros, True)
            '--------------------- para llenar combo en grilla    

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ControlCobros_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
    End Sub

    Private Sub frm_ControlCobros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Inicializar()
        'cboMes.Text = Date.Now.Month
        LlenaTipoDocumentoOperacion()
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
            tabAsociados.Tabs(0).Selected = True
            If gridDocumentos.ActiveRow.Cells("id").Value.ToString = "" Then
                Throw New Exception("Seleccione Documento")
            End If
            ' If gridDocumentos.ActiveRow.Cells("IdTipoDocumento").Value.ToString = "1CH000000070" And CType(gridDocumentos.ActiveRow.Cells("IndAnticipo").Value, Boolean) = True Then Throw New Exception("El Anticipo no aplica a cobros. Ir al Reporte de Anticipos para visualizar documentos asociados.")
            oeCuentaxCyP = New e_CuentaxCyP
            leCuentaxCyP.Clear()
            oeCuentaxCyP.IdMovimientoDocumento = gridDocumentos.ActiveRow.Cells("id").Value
            oeCuentaxCyP.TipoOperacion = "COB"
            oeCuentaxCyP.Fecha = "01/01/1901"
            oeCuentaxCyP.Activo = True
            leCuentaxCyP.AddRange(olCuentaxCyP.Listar(oeCuentaxCyP))
            CalcularTotales(GridCobros, "MontoMN", "MontoMe")
            oeMovimientoDocumento = New e_MovimientoDocumento
            oeMovimientoDocumento.Id = gridDocumentos.ActiveRow.Cells("id").Value
            oeMovimientoDocumento.TipoOperacion = "DAT"
            oeMovimientoDocumento.Activo = True
            GridAnticipos.DataSource = olMovimientoDocumento.Listar_Anticipos(oeMovimientoDocumento)
            CalcularTotales(GridAnticipos, "Monto")
           
            If leCuentaxCyP.Count <= 0 Then
                If gridDocumentos.ActiveRow.Cells("IdTipoDocumento").Value.ToString = "1CH000000070" And CType(gridDocumentos.ActiveRow.Cells("IndAnticipo").Value, Boolean) = True Then Throw New Exception("No existe aplicación del Anticipo.")
                mensajeEmergente.Problema("No existen Cobros Asociados a este documento." & vbCrLf & IIf(GridAnticipos.Rows.Count > 0, "Esta factura está afectada por anticipos.", ""), True)
            End If
            GridCobros.DataBind()

           
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_ControlCobros_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub txtRuc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRuc.ValueChanged
        If Not txtRuc.Value Is Nothing Then
            If txtRuc.Value.ToString.Trim.Length > 7 Then
                Dim leClienteList As New List(Of e_Cliente)
                leClienteList = leCliente.ToList
                leClienteList = leCliente.Where(Function(item) item.Dni.Contains(txtRuc.Value)).ToList
                cboCliente.DataSource = leClienteList
                If leClienteList.Count > 0 Then
                    cboCliente.Value = leClienteList(0).Id
                End If
            End If
        End If
    End Sub

    Private Sub cboCliente_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboCliente.InitializeLayout
        Me.cboCliente.ValueMember = "Id"
        Me.cboCliente.DisplayMember = "Nombre"
        With cboCliente.DisplayLayout.Bands(0)
            .Columns("Id").Hidden = True
            .Columns("Codigo").Hidden = True
            .Columns("TipoPersonaEmpresa").Hidden = True
            .Columns("IdPersona").Hidden = True
            .Columns("IdEmpresa").Hidden = True
            .Columns("Comisionista").Hidden = True
            .Columns("FechaActividad").Hidden = True
            .Columns("UsuarioCreacion").Hidden = True
            .Columns("Activo").Hidden = True
            .Columns("oeEmpresa").Hidden = True
            .Columns("oepersona").Hidden = True
        End With
    End Sub

    Private Sub cboCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cboCliente.Text.Trim = "" Then
                cboCliente.DataSource = Nothing
                cboCliente.DataSource = leCliente
            Else
                cboCliente.DataSource = Nothing
                Dim leClienteList2 As New List(Of e_Cliente)
                leClienteList2 = leCliente
                cboCliente.DataSource = leClienteList2.Where(Function(Item) Item.Nombre.Contains(cboCliente.Text.Trim)).ToList
            End If
        End If
    End Sub

    Private Sub cboCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCliente.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cboCliente.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub cboMes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMes.ValueChanged
        'If Not cboCliente.DataSource Is Nothing Then
        '    Listar()
        'Else
        '    BuscarDocs = True
        'End If
    End Sub

    Private Sub ExtornarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExtornarToolStripMenuItem.Click
        Try
            If GridCobros.ActiveRow.Selected = True Then
                If GridCobros.ActiveRow.Cells("Medio").Value = "APLICACIÓN DE ANTICIPO" Then Throw New Exception("No se puede extornar, no es un cobro sino una aplicación de anticipo.")
                oeAsiento = New e_Asiento
                oeAsiento.Id = GridCobros.ActiveRow.Cells("IdAsiento").Value
                oeAsiento._IdMovimientoCajaBanco = GridCobros.ActiveRow.Cells("IdMovimientoCajaBanco").Value
                oeAsiento.IdPeriodo = GridCobros.ActiveRow.Cells("Periodo").Value
                oeAsiento.IdUsuarioCrea = gUsuarioSGI.Id
                oeAsiento.TotalDebe = GridCobros.ActiveRow.Cells("MontoMN").Value
                oeAsiento.IdUsuarioBloquea = cboCliente.Value
                If MsgBox("¿Desea eliminar el cobro? - Afectara a todos los cobros relacionados ", MsgBoxStyle.YesNo, "Mensaje de Sistema") = MsgBoxResult.Yes Then
                    If olAsiento.EliminarCobroPago2(oeAsiento) Then
                        mensajeEmergente.Confirmacion("Extorno satisfactorio.", True)
                        Listar()
                    End If
                End If
            Else
                Throw New Exception("Seleccione cobro.")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

End Class