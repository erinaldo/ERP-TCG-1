'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win

Public Class frm_ComprobanteDiario
    Inherits frm_MenuPadre

#Region "Declaración de variables"

    Private WithEvents oeAsiento As New e_Asiento, olAsiento As New l_Asiento
    Private oeDetalleAsiento As New e_AsientoMovimiento, olDetalleAsiento As New l_AsientoMovimiento

    Private oeMovimientoCajaBanco As New e_MovimientoCajaBanco, oeMovimientoDocumento As New e_MovimientoDocumento, oeMovimientoAnalisis As New e_MovimientoAnalisis
    Private oePeriodo As New e_Periodo, olPeriodo As New l_Periodo
    Private oeTipoAsiento As New e_TablaContableDet, loTipoAsiento As New l_TablaContableDet

    Dim olTipoDoc As New l_TipoDocumento
    Dim olCuentaCtble As New l_CuentaContable
    Private leCuenta As New List(Of e_CuentaContable)

    Private _ComboCtaCte As String = "", _ItemCta As String = "", _Cta As String = "", _ComboPeriodo As Boolean = False
    Private _CuentaEdita As String, _IndexMovEdita As Integer, Ejercicio As Integer = 0, EditableCyV As Boolean = True

    Private Shared instancia As frm_ComprobanteDiario = Nothing
    Private Shared Operacion As String

    Dim ol_FuncionesGenerales As New l_FuncionesGenerales
    Dim lnInicializacion As Integer = 0
    Private oeObligacionFin As New e_ObligacionFin

    Private oeCta As New e_CuentaContable
    Private olTrabSeg As New l_TrabajadorSeguridad

#End Region

#Region "Definición del Formulario base"

    Public Sub New()
        lnInicializacion = 0
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        lnInicializacion = 1
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ComprobanteDiario()
        End If
        instancia.Activate()
        Return instancia

    End Function

#End Region

#Region "Botones"

#Region "Cabecera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            If grid_ComprobanteDiario.Rows.Count > 0 Then
                MyBase.Consultar(Activo) 'activa desactiva botonera
            Else
                MyBase.Consultar() 'activa desactiva botonera
            End If
            Operacion = ""
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            Inicializar()
            agrCabeceraAsiento.Text = "Nro Asiento: "
            oeAsiento.TipoOperacion = "I"
            oeAsiento.Modificado = False
            MostrarTabs(0, tcAsientoDetalle) 'inicializamos
            numAño.ReadOnly = False
            cmbPeriodo.ReadOnly = False
            cmbTipoAsiento.ReadOnly = False
            numAño.Focus()
            MyBase.Nuevo() 'activa desactiva botonera
            Operacion = "Nuevo"
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            ValidarGrilla(grid_ComprobanteDiario, "Comprobante Diario")
            If Not grid_ComprobanteDiario.ActiveRow Is Nothing AndAlso grid_ComprobanteDiario.ActiveRow.Cells("Id").Value.ToString <> "" Then
                Inicializar()
                Mostrar()
                oeAsiento.TipoOperacion = "A"
                oeAsiento.Modificado = False
                MostrarTabs(0, tcAsientoDetalle)
                MyBase.Editar()
                numAño.ReadOnly = True
                cmbPeriodo.ReadOnly = True
                cmbTipoAsiento.ReadOnly = True
                Operacion = "Editar"
                ControlBoton(0, 0, 0, 1, 1, 0, 1, 1, 0)
            Else
                Throw New Exception("Seleccione una Fila!")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarComprobante() Then
                MyBase.Guardar()
                Operacion = ""
            Else
                MostrarTabs(1, tcComprobanteDiario)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeAsiento.Modificado Then
                Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        If Not GuardarComprobante() Then
                            MostrarTabs(1, tcComprobanteDiario)
                            MyBase.Consultar(True) 'activa desactiva botonera
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcComprobanteDiario)
                        MyBase.Consultar(True) 'activa desactiva botonera
                        Operacion = ""
                End Select
            Else
                MostrarTabs(0, tcComprobanteDiario)
                MyBase.Consultar(True) 'activa desactiva botonera
                Operacion = ""
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With grid_ComprobanteDiario
                ValidarGrilla(grid_ComprobanteDiario, "Comprobante")
                If Not .ActiveRow Is Nothing AndAlso .ActiveRow.Cells("Id").Value.ToString <> "" Then
                    oeAsiento = New e_Asiento
                    oeAsiento.TipoOperacion = "1"
                    oeAsiento.Id = .ActiveRow.Cells("Id").Value
                    oeAsiento = olAsiento.Obtener(oeAsiento)
                    l_FuncionesGenerales.ValidarPeriodo(oeAsiento.IdPeriodo, gAreasSGI.Contabilidad, Date.Parse("01/01/1901"), "")
                    If oeAsiento.IdTipoAsiento = "1CH000019" Or oeAsiento.IdTipoAsiento = "1CH000024" Then 'compras o ventas
                        Throw New Exception("No se puede Eliminar las compras o ventas desde este módulo")
                    End If
                    If oeAsiento.IdEstado.ToString.Trim <> "" Then
                        Throw New Exception("No se puede Eliminar Asiento verifique el modulo que genero COBRANZA/PAGOS")
                    End If
                    If oeAsiento.IndOrigen = 40 Then
                        Throw New Exception("No se puede Eliminar Asiento verifique el modulo que genero ACTIVO FIJO")
                    End If
                    If oeAsiento.IndOrigen = 11 Then
                        Throw New Exception("No se puede Eliminar Asiento verifique el modulo que genero ANTICIPOS")
                    End If
                    If oeAsiento.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar el Comprobante: " & _
                                 .ActiveRow.Cells("NroAsiento").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeAsiento.TipoOperacion = "E"
                            oeAsiento.IdUsuarioCrea = gUsuarioSGI.Id
                            olAsiento.Eliminar(oeAsiento)
                            Consultar(True)
                        End If
                    Else
                        Throw New Exception("La informacion  se encuentra eliminada.")
                    End If
                Else
                    Throw New Exception("Seleccione una Fila!")
                End If
            End With
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

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    ''' 

    Public Overrides Sub Exportar()
        Try
            If tcComprobanteDiario.Tabs(0).Active Then
                If grid_ComprobanteDiario.Rows.Count = 0 Then Throw New Exception("No hay ningún Comprobante Diario para exportar al Excel")
                Exportar_Excel(grid_ComprobanteDiario)
            End If
            If tcComprobanteDiario.Tabs(1).Active And tcAsientoDetalle.Tabs(0).Active Then
                If grid_AsientoDetalle.Rows.Count = 0 Then Throw New Exception("No hay ningún detalle del Comprobante Diario para exportar al Excel")
                Exportar_Excel(grid_AsientoDetalle)
            End If
            If tcComprobanteDiario.Tabs(1).Active And Not tcAsientoDetalle.Tabs(0).Active Then
                Throw New Exception("Debe ubicarse en el listado de detalles de comprobante diario, para poder exportarlo")
            End If
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Detalles"

    Private Sub NuevoDetalle()
        Try
            ValidarCombo(cboMoneda, "Moneda")
            ValidarCombo(cmbPeriodo, "Periodo")
            ValidarCombo(cmbTipoAsiento, "Tipo Asiento")
            If decTC.Value < 0 Then
                Throw New Exception("El Tipo de Cambio debe ser mayo a cero")
            End If
            If decTC.Value = 0 Then
                If MessageBox.Show("El tipo de Cambio es Cero, Desea Continuar?", Me.Text, _
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                    Throw New Exception("Ingresar Tipo de Cambio")
                Else
                    If cboMoneda.Text = "DOLARES" Then
                        Throw New Exception("Ingresar Tipo de Cambio o cambiar a Soles")
                    End If
                End If
            End If
            InicializarDetalle()
            mnuDetalleAsiento.Tools("Modificar").SharedProps.Visible = False
            mnuDetalleAsiento.Tools("Agregar").SharedProps.Visible = True
            oeDetalleAsiento = New e_AsientoMovimiento
            oeDetalleAsiento.DivideAnalisis = False
            oeDetalleAsiento.IdUsuarioCrea = gUsuarioSGI.Id
            oeDetalleAsiento.Glosa = txtGlosa.Value
            oeDetalleAsiento.IdAsiento = oeAsiento.Id
            oeDetalleAsiento.TipoOperacion = "I"
            oeDetalleAsiento.Modificado = False

            oeMovimientoCajaBanco.TipoOperacion = "I"
            'oeMovimientoDocumento.TipoOperacion = "I"

            txt_GlosaDetalle.Value = txtGlosa.Value
            cboCuenta.Focus()
            If Not EditableCyV Then
                Agrupacion4.Enabled = False
                Agrupacion2.Enabled = False
                grid_DetalleAsientoAnalisis.Enabled = False
                mnuDetalleAsiento.Tools("Agregar").SharedProps.Enabled = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ModificaDetalle()
        Try
            ValidarGrilla(grid_AsientoDetalle, "Detalles de Asiento")
            ValidarCombo(cboMoneda, "Moneda")
            InicializarDetalle()
            mnuDetalleAsiento.Tools("Agregar").SharedProps.Visible = False
            mnuDetalleAsiento.Tools("Modificar").SharedProps.Visible = True
            mnuDetalleAsiento.Tools("Modificar").SharedProps.Enabled = True
            MostrarDetalle()
            oeDetalleAsiento.TipoOperacion = "A"
            If oeAsiento.TipoOperacion = "A" Then 'ACTUALIZA
                With oeDetalleAsiento
                    .MovimientoCajaBanco.IdAsientoMovimiento = .Id
                    .MovimientoCajaBanco.Id = .MovimientoCajaBanco.Id
                    .MovimientoDocumento.IdAsientoMovimiento = .Id
                    .MovimientoDocumento.Id = .MovimientoDocumento.Id

                    oeMovimientoCajaBanco.IdAsientoMovimiento = .Id
                    oeMovimientoDocumento.IdAsientoMovimiento = .Id
                    oeMovimientoCajaBanco.Id = oeDetalleAsiento.MovimientoCajaBanco.Id
                    oeMovimientoDocumento.Id = oeDetalleAsiento.MovimientoDocumento.Id

                    If Not grid_AsientoDetalle.ActiveRow.Cells("Id").Value Is Nothing Then 'DETALLE DE BD
                        _CuentaEdita = .IdCuentaContable
                    Else
                        If Not grid_AsientoDetalle.ActiveRow.Cells("IdCuentaContable").Value Is Nothing Then
                            cboCuenta.Focus()
                        Else
                            MessageBox.Show("Seleccione una Fila!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                End With
            End If
            If EditableCyV = False Then
                Agrupacion4.Enabled = True
                Agrupacion2.Enabled = False
                grid_DetalleAsientoAnalisis.Enabled = False
                mnuDetalleAsiento.Tools("Modificar").SharedProps.Enabled = False
                cmbAgregarAnalisis.Enabled = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub EliminarD()
        Try
            If EditableCyV Then
                ValidarGrilla(grid_AsientoDetalle, "Detalles de Asiento")
                'inicialializo mi objeto
                oeDetalleAsiento = New e_AsientoMovimiento
                '---Obtengo O CAPTURO objeto de la grilla 
                oeDetalleAsiento = grid_AsientoDetalle.ActiveRow.ListObject
                '----------------------
                If Not grid_AsientoDetalle.ActiveRow.Cells("Id").Value Is Nothing Then
                    With oeAsiento
                        If .TipoOperacion = "I" Then 'cuando inserto o nuevo objeto cabecera y detalles
                            '-----remuevo o elimino de mi lista de objetos
                            .AsientoMovimiento.Remove(oeDetalleAsiento)
                            '-------------------
                        ElseIf .TipoOperacion = "A" Then ' cuando actualizo o edito el objeto
                            If oeDetalleAsiento.Id <> "" Then '---viene de BD
                                '-----Solo cambio tipo de operacion para desactivar ya que viene de BD
                                oeDetalleAsiento.TipoOperacion = "E"
                                oeDetalleAsiento.IdUsuarioCrea = gUsuarioSGI.Id
                                Dim oeDetAs As e_AsientoMovimiento = olDetalleAsiento.Obtener(oeDetalleAsiento)
                                oeDetalleAsiento.MovimientoDocumento = oeDetAs.MovimientoDocumento
                                oeDetalleAsiento.MovimientoDocumento.IdAsientoMovimiento = oeDetalleAsiento.Id
                                If oeDetalleAsiento.MovimientoDocumento.Id <> "" Then
                                    If oeDetalleAsiento.MovimientoDocumento.IndCompraVenta = 4 Or oeDetalleAsiento.MovimientoDocumento.IndCompraVenta = 5 Then
                                        oeDetalleAsiento.MovimientoDocumento.TipoOperacion = "E"
                                    End If
                                End If
                                '--------------------
                            Else '-----no viene de BD
                                '-----remuevo de mi lista de objetos
                                .AsientoMovimiento.Remove(oeDetalleAsiento)
                                '----------------------------
                            End If
                        End If
                        'recargo grilla
                        CargaAsientoMovimiento(oeAsiento.AsientoMovimiento)
                    End With
                Else
                    If Not grid_AsientoDetalle.ActiveRow.Cells("IdCuentaContable").Value Is Nothing Then
                        '-----remuevo o elimino de mi lista de objetos
                        oeAsiento.AsientoMovimiento.Remove(oeDetalleAsiento)
                        '-------------------
                        'recargo grilla
                        CargaAsientoMovimiento(oeAsiento.AsientoMovimiento)
                    Else
                        Throw New Exception("Seleccione una Fila!")
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#End Region

#Region "Métodos"

#Region "Cabecera"

    Private Sub Inicializar()
        Try
            oeAsiento = New e_Asiento
            oeAsiento.IdUsuarioCrea = gUsuarioSGI.Id
            FecAsiento.Value = Date.Now
            numAño.Value = Date.Today.Year
            cmbPeriodo.SelectedIndex = -1
            cmbTipoAsiento.SelectedIndex = -1
            decTC.Value = 0
            txtGlosa.Text = ""
            DecDebeAsiento.Value = 0
            DecHaberAsiento.Value = 0
            cboMoneda.SelectedIndex = -1
            DecDMN.Value = 0
            DecHMN.Value = 0
            DecDME.Value = 0
            DecHME.Value = 0
            ComboPeriodoMant()
            CuentaContable()
            LimpiaGrid(grid_AsientoDetalle, UltraDataSource3)
            MostrarTabs(1, tcComprobanteDiario, 1)
            agrCabeceraAsiento.Enabled = True
            LimpiarCombo()
            oeCta = New e_CuentaContable
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar(ByVal Activo As Boolean)
        Try
            ValidarCombo(cboMes, "Mes")
            Me.Cursor = Cursors.WaitCursor
            oeAsiento = New e_Asiento
            oeAsiento.Activo = Activo
            oeAsiento.IdPeriodo = cboMes.Value
            oeAsiento.IdTipoAsiento = cboTipoAsiento.Value
            LimpiaGrid(grid_ComprobanteDiario, UltraDataSource1)
            With grid_ComprobanteDiario
                .DataSource = olAsiento.Listar(oeAsiento)

                For i As Integer = 0 To .DisplayLayout.Bands(0).Columns.Count - 1
                    .DisplayLayout.Bands(0).Columns(i).Hidden = True
                Next
                .DisplayLayout.Bands(0).Columns("IdPeriodo").Hidden = False
                .DisplayLayout.Bands(0).Columns("IdTipoAsiento").Hidden = False
                .DisplayLayout.Bands(0).Columns("NroAsiento").Hidden = False
                .DisplayLayout.Bands(0).Columns("Fecha").Hidden = False
                .DisplayLayout.Bands(0).Columns("Glosa").Hidden = False
                .DisplayLayout.Bands(0).Columns("IdMoneda").Hidden = False
                .DisplayLayout.Bands(0).Columns("TipoCambio").Hidden = False
                .DisplayLayout.Bands(0).Columns("TotalDebe").Hidden = False
                .DisplayLayout.Bands(0).Columns("TotalHaber").Hidden = False
                .DisplayLayout.Bands(0).Columns("IdUsuarioCrea").Hidden = False
            End With
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
        grid_ComprobanteDiario.Focus()
    End Sub

    Private Sub Mostrar()
        Try
            EditableCyV = True
            If grid_ComprobanteDiario.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                With grid_ComprobanteDiario.ActiveRow
                    oeAsiento.Id = .Cells("Id").Value.ToString
                    If .Cells("IdTipoAsiento").Text = "COMPRAS" Or .Cells("IdTipoAsiento").Text = "VENTAS" Then
                        EditableCyV = False
                    End If
                End With
                oeAsiento = olAsiento.Obtener(oeAsiento)
                FecAsiento.Value = oeAsiento.Fecha
                decTC.Value = oeAsiento.TipoCambio
                cboMoneda.Value = oeAsiento.IdMoneda
                txtGlosa.Value = oeAsiento.Glosa
                numAño.Value = CInt(Strings.Left(grid_ComprobanteDiario.ActiveRow.Cells("IdPeriodo").Text, 4))
                cmbPeriodo.Value = oeAsiento.IdPeriodo
                cmbTipoAsiento.Value = oeAsiento.IdTipoAsiento
                DecDebeAsiento.Value = oeAsiento.TotalDebe
                DecHaberAsiento.Value = oeAsiento.TotalHaber
                agrCabeceraAsiento.Text = "Nro. Asiento: " + oeAsiento.NroAsiento
                CargaAsientoMovimiento(oeAsiento.AsientoMovimiento)
                EditableCyV = True
                agrCabeceraAsiento.Enabled = EditableCyV
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GuardarComprobante() As Boolean
        Try
            If ValidaComprobante() Then
                oeAsiento.Fecha = FecAsiento.Value
                If oeAsiento.TipoOperacion = "A" Then oeAsiento.AsientoMovimiento = oeAsiento.AsientoMovimiento.Where(Function(item) item.TipoOperacion <> "").ToList
                If oeAsiento.TipoOperacion = "I" Then
                    For Each obj As e_AsientoMovimiento In oeAsiento.AsientoMovimiento
                        obj.TipoOperacion = "I"
                        obj.PrefijoID = gs_PrefijoIdSucursal '@0001
                    Next
                End If
                oeAsiento.PrefijoID = gs_PrefijoIdSucursal '@0001
                If olAsiento.Guardar(oeAsiento) Then
                    mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente", True)
                    MostrarTabs(0, tcComprobanteDiario, 2)
                    Consultar(True)
                    grid_ComprobanteDiario.Focus()
                    Return True
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidaComprobante() As Boolean
        Try
            l_FuncionesGenerales.ValidarCampoNoNulo(txtGlosa.Text, "Ingrese la Glosa")
            l_FuncionesGenerales.ValidarPeriodo(oeAsiento.IdPeriodo, gAreasSGI.Contabilidad, FecAsiento.Value, "")
            ValidarCombo(cboMoneda, "Moneda")
            ValidarGrilla(grid_AsientoDetalle, "Detalles de asiento")
            If decTC.Value < 0 Then Throw New Exception("Ingrese Tipo de Cambio")
            If decTC.Value = 0 Then
                If MessageBox.Show("El tipo de Cambio es Cero, Desea Continuar?", Me.Text, _
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                    Throw New Exception("Ingresar Tipo de Cambio")
                Else
                    If cboMoneda.Text = "DOLARES" Then
                        Throw New Exception("Ingresar Tipo de Cambio o cambiar a Soles")
                    End If
                End If
            End If
            If oeAsiento.IdEstado = "DESCUADRADO" Then
                If MessageBox.Show("El asiento esta descuadrado desea continuar?", "Mensaje del sistema", _
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                    Return False
                End If
            End If
            If tcAsientoDetalle.Tabs(1).Selected Then GuardarAsientoDetalle()
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub LlenarCombos()
        Try
            ComboTipoAsiento()
            ComboPeriodoList()
            ComboMoneda()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboMoneda()
        Try
            Dim oeMoneda As New e_Moneda, olMoneda As New l_Moneda
            Dim leMoneda As New List(Of e_Moneda)
            oeMoneda.Activo = True
            leMoneda.AddRange(olMoneda.Listar(oeMoneda))
            '-------- para llenar combo en grilla    
            grid_ComprobanteDiario.DisplayLayout.ValueLists.Add("IdMoneda")
            With grid_ComprobanteDiario.DisplayLayout.ValueLists("IdMoneda").ValueListItems
                .Clear()
                For Each oeTD As e_Moneda In leMoneda
                    .Add(oeTD.Id, oeTD.Abreviatura)
                Next
            End With
            CrearComboGrid3("IdMoneda", "Abreviatura", grid_ComprobanteDiario, True)
            '------------------------------------------
            With cboMoneda
                .DisplayMember = "Nombre"
                .ValueMember = "Id"
                .DataSource = leMoneda
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboPeriodoMant()
        Try
            'If _ComboPeriodo Then
            Dim lePeriodo As New List(Of e_Periodo)
            lePeriodo.AddRange(ObtenerPeriodoActivo(numAño.Value))
            With cmbPeriodo
                .DisplayMember = "NomMes"
                .ValueMember = "Id"
                .DataSource = lePeriodo
                If .Items.Count > 0 Then
                    .SelectedIndex = -1
                End If
            End With
            ' End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboPeriodoList()
        Try
            If _ComboPeriodo Then
                Dim lePeriodo As New List(Of e_Periodo)
                lePeriodo.AddRange(ObtenerPeriodoActivo(Año1.Año))
                '---------------- para llenar combo en grilla    
                With grid_ComprobanteDiario.DisplayLayout
                    If .Bands(0).Columns.Exists("IdPeriodo") Then
                        .ValueLists.Clear()
                        .ValueLists.Add("IdPeriodo")
                    End If
                End With
                With grid_ComprobanteDiario.DisplayLayout.ValueLists("IdPeriodo").ValueListItems
                    .Clear()
                    For Each oeTD As e_Periodo In lePeriodo
                        .Add(oeTD.Id, oeTD.Codigo)
                    Next
                End With
                CrearComboGrid3("IdPeriodo", "Codigo", grid_ComprobanteDiario, True)
                With cboMes
                    .DisplayMember = "NomMes"
                    .ValueMember = "Id"
                    .DataSource = lePeriodo
                    If .Items.Count > 0 Then
                        .SelectedIndex = Date.Today.Month - 1
                    End If
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboTipoAsiento()
        Try
            oeTipoAsiento = New e_TablaContableDet
            Dim leTablaContableDet As New List(Of e_TablaContableDet)
            oeTipoAsiento.TipoOperacion = "N"
            oeTipoAsiento.Nombre = "TIPO DE ASIENTO" 'tipo de asiento
            oeTipoAsiento.Logico1 = True
            oeTipoAsiento.Activo = True
            leTablaContableDet.AddRange(loTipoAsiento.Listar(oeTipoAsiento))
            '--------------------- para llenar combo en grilla    
            grid_ComprobanteDiario.DisplayLayout.ValueLists.Add("IdTipoAsiento")
            With grid_ComprobanteDiario.DisplayLayout.ValueLists("IdTipoAsiento").ValueListItems
                .Clear()
                For Each oeTD As e_TablaContableDet In leTablaContableDet
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdTipoAsiento", "Nombre", grid_ComprobanteDiario, True)
            '------------------------------------------
            With cboTipoAsiento
                .DisplayMember = "Nombre"
                .ValueMember = "Id"
                .DataSource = leTablaContableDet
                If .Items.Count > 0 Then
                    .SelectedIndex = 1
                End If
            End With

            With cmbTipoAsiento
                .DisplayMember = "Nombre"
                .ValueMember = "Id"
                .DataSource = leTablaContableDet
                If .Items.Count > 0 Then
                    .SelectedText = "DIARIO"
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CuentaContable()
        Try
            'If Ejercicio <> Año1.Año Then
            'Ejercicio = Año1.Año
            Dim oeCuenta As New e_CuentaContable
            leCuenta = New List(Of e_CuentaContable)
            oeCuenta.Ejercicio = numAño.Value   'Año1.Año
            oeCuenta.Movimiento = 1
            leCuenta.AddRange(olCuentaCtble.Listar(oeCuenta))
            '--------------------- para llenar combo en grilla    
            With grid_AsientoDetalle.DisplayLayout
                If .Bands(0).Columns.Exists("IdCuentaContable") Then
                    .ValueLists.Clear()
                    .ValueLists.Add("IdCuentaContable")
                End If
            End With
            With grid_AsientoDetalle.DisplayLayout.ValueLists("IdCuentaContable").ValueListItems
                .Clear()
                For Each oeTD As e_CuentaContable In leCuenta
                    .Add(oeTD.Id, oeTD.Cuenta)
                Next
            End With
            CrearComboGrid3("IdCuentaContable", "Cuenta", grid_AsientoDetalle, True)
            '------------------------------------------
            With cboCuenta
                .ValueMember = "Id"
                .DisplayMember = "Cuenta"
                .DataSource = leCuenta
            End With
            ' End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargaAsientoMovimiento(ByVal oe_CA As List(Of e_AsientoMovimiento))
        Try
            With grid_AsientoDetalle
                LimpiaGrid(grid_AsientoDetalle, UltraDataSource3)
                Dim leAsiento As New List(Of e_AsientoMovimiento)
                '-----------obtengo lista de objetos activos
                leAsiento = oe_CA.Where(Function(item) item.TipoOperacion <> "E").ToList
                '-----------------
                Dim _DebeMN As Double = 0, _HaberMN As Double = 0
                Dim _DebeME As Double = 0, _HaberME As Double = 0

                For Each obj As e_AsientoMovimiento In leASiento
                    _DebeMN = _DebeMN + obj.DebeMN
                    _HaberMN = _HaberMN + obj.HaberMN
                    _DebeME = _DebeME + obj.DebeME
                    _HaberME = _HaberME + obj.HaberME
                Next
                .DataSource = leASiento
                If cboMoneda.Text = "SOLES" Or cboMoneda.Value = "1CH01" Then 'soles
                    DecDebeAsiento.Value = Math.Round(_DebeMN, 2)
                    DecHaberAsiento.Value = Math.Round(_HaberMN, 2)
                Else
                    DecDebeAsiento.Value = Math.Round(_DebeME, 2)
                    DecHaberAsiento.Value = Math.Round(_HaberME, 2)
                End If
                If DecDebeAsiento.Value = DecHaberAsiento.Value Then
                    oeAsiento.IdEstado = "CUADRADO"
                Else
                    oeAsiento.IdEstado = "DESCUADRADO"
                End If
                DecDMN.Value = _DebeMN
                DecHMN.Value = _HaberMN
                DecDME.Value = _DebeME
                DecHME.Value = _HaberME
                grid_AsientoDetalle.DataBind()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LimpiarCombo()
        Dim itemList As ICheckedItemList = DirectCast(Me.cboVehiculo.Items.ValueList, ICheckedItemList)
        For i As Integer = 0 To Me.cboVehiculo.Items.Count - 1
            itemList.SetCheckState(i, CheckState.Unchecked)
        Next
    End Sub

#End Region

#Region "Detalles"

    Private Sub InicializarDetalle()
        oeDetalleAsiento = New e_AsientoMovimiento
        oeDetalleAsiento.DivideAnalisis = False : oeDetalleAsiento.IdUsuarioCrea = gUsuarioSGI.Id
        oeMovimientoAnalisis = New e_MovimientoAnalisis : oeMovimientoCajaBanco = New e_MovimientoCajaBanco : oeMovimientoDocumento = New e_MovimientoDocumento
        LimpiaGrid(grid_DetalleAsientoAnalisis, odAnalisis)
        txt_GlosaDetalle.Text = String.Empty : txtNombreCta.Text = String.Empty : _ItemCta = "" : _Cta = "" : _ComboCtaCte = ""
        DecDebe.Value = 0 : DecHaber.Value = 0 : cboFlujoCaja.SelectedIndex = -1 : cboCtaBancaria.SelectedIndex = -1
        cboTipoDocCajaBanco.SelectedIndex = -1 : cmbTipoDoc.SelectedIndex = -1 : cboCuenta.Value = Nothing : txtNumeroCajaBanco.Text = String.Empty
        FecCajaBanco.Value = Date.Now : cboFlujoCaja.Enabled = False : cboCtaBancaria.Enabled = False : cboTipoDocCajaBanco.Enabled = False
        txtNumeroCajaBanco.Enabled = False : FecCajaBanco.Enabled = False : txtNroSerie.Value = String.Empty : txtNroDoc.Value = String.Empty
        FecEmision.Value = Date.Now : FecVencimiento.Value = Date.Now : cboCtaCte.SelectedIndex = -1 : cmbTipoDoc.Enabled = False
        txtNroSerie.Enabled = False : txtNroDoc.Enabled = False : FecEmision.Enabled = False : FecVencimiento.Enabled = False
        cboCtaCte.Enabled = False : Agrupacion4.Enabled = True
        'obligacion
        cboTipoObligacion.SelectedIndex = -1 : txtCodigoUnico.Text = String.Empty : fecEmisionObligacion.Value = Date.Now
        fecVencimientoObligacion.Value = Date.Now : cboBancoObligacion.Enabled = False
        cboTipoObligacion.Enabled = False : txtCodigoUnico.Enabled = False : fecEmisionObligacion.Enabled = False : fecVencimientoObligacion.Enabled = False
        cboBancoObligacion.Enabled = False : tabDocumentoDetalle.SelectTab(0)


        InicializaAnalisis(False)
        btnBuscarDoc.Enabled = False
        MostrarTabs(1, tcAsientoDetalle, 1)
        cboTipoObligacion.SelectedIndex = -1
        txtCodigoUnico.Text = "" : cboBancoObligacion.SelectedIndex = -1 : DecDebe.ReadOnly = False : DecHaber.ReadOnly = False
    End Sub

    Private Sub LimpiarDetalle()
        cboFlujoCaja.SelectedIndex = -1 : cboCtaBancaria.SelectedIndex = -1
        cboTipoDocCajaBanco.SelectedIndex = -1 : cmbTipoDoc.SelectedIndex = -1 : txtNumeroCajaBanco.Text = String.Empty
        FecCajaBanco.Value = Date.Now : cboFlujoCaja.Enabled = False : cboCtaBancaria.Enabled = False : cboTipoDocCajaBanco.Enabled = False
        txtNumeroCajaBanco.Enabled = False : FecCajaBanco.Enabled = False : txtNroSerie.Value = String.Empty : txtNroDoc.Value = String.Empty
        FecEmision.Value = Date.Now : FecVencimiento.Value = Date.Now : cboCtaCte.SelectedIndex = -1 : cmbTipoDoc.Enabled = False
        txtNroSerie.Enabled = False : txtNroDoc.Enabled = False : FecEmision.Enabled = False : FecVencimiento.Enabled = False
        cboCtaCte.Enabled = False : Agrupacion4.Enabled = True
        'obligacion
        cboTipoObligacion.SelectedIndex = -1 : txtCodigoUnico.Text = String.Empty : fecEmisionObligacion.Value = Date.Now
        fecVencimientoObligacion.Value = Date.Now : cboBancoObligacion.SelectedIndex = -1
        cboTipoObligacion.Enabled = False : txtCodigoUnico.Enabled = False : fecEmisionObligacion.Enabled = False : fecVencimientoObligacion.Enabled = False
        cboBancoObligacion.Enabled = False : tabDocumentoDetalle.SelectTab(0)
        btnBuscarDoc.Enabled = False

        DecMontoAn.Value = 0 : cboGastonFuncion.SelectedIndex = -1 : cboItemGasto.SelectedIndex = -1 : cboCentroCosto.SelectedIndex = -1
        cboTrabajador.SelectedIndex = -1 : ChkVehiculoProper.Checked = False : cboVehiculo.SelectedIndex = -1 : cboRuta.SelectedIndex = -1
        cboBanco.SelectedIndex = -1 : cboAnalisis1.SelectedIndex = -1 : cboAnalisis2.SelectedIndex = -1 : DecMontoAn.Enabled = False
        cboGastonFuncion.Enabled = False : cboItemGasto.Enabled = False : cboCentroCosto.Enabled = False : cboTrabajador.Enabled = False
        ChkVehiculoProper.Enabled = False : cboVehiculo.Enabled = False : cboRuta.Enabled = False : cboBanco.Enabled = False
        cboAnalisis1.Enabled = False : cboAnalisis2.Enabled = False : Agrupacion2.Enabled = True : grid_DetalleAsientoAnalisis.Enabled = True
        cmbAgregarAnalisis.Enabled = False

        DecDebe.ReadOnly = False : DecHaber.ReadOnly = False
    End Sub

    Private Sub MostrarDetalle()
        Try
            '---Obtengo O CAPTURO objeto de la grilla 
            oeDetalleAsiento = grid_AsientoDetalle.ActiveRow.ListObject
            _IndexMovEdita = oeAsiento.AsientoMovimiento.IndexOf(oeDetalleAsiento)
            '----------------------  
            If oeDetalleAsiento.TipoOperacion = "" Then
                oeDetalleAsiento.Id = grid_AsientoDetalle.ActiveRow.Cells("Id").Value.ToString
                oeDetalleAsiento = olDetalleAsiento.Obtener(oeDetalleAsiento)
                If oeDetalleAsiento.Editable = False Then
                    Agrupacion4.Enabled = False : Agrupacion2.Enabled = False
                    grid_DetalleAsientoAnalisis.Enabled = False : mnuDetalleAsiento.Tools("Modificar").SharedProps.Enabled = False
                Else
                    Agrupacion4.Enabled = True : Agrupacion2.Enabled = True
                    grid_DetalleAsientoAnalisis.Enabled = True : mnuDetalleAsiento.Tools("Modificar").SharedProps.Enabled = True
                End If
            End If
            With oeDetalleAsiento
                'oeDetalleAsiento.DivideAnalisis = True
                cboCuenta.Value = .IdCuentaContable
                Me.txt_GlosaDetalle.Text = .Glosa
                If cboMoneda.Text = "SOLES" OrElse cboMoneda.Value = "1CH01" Then 'soles
                    DecDebe.Value = .DebeMN : DecHaber.Value = .HaberMN
                Else
                    DecDebe.Value = .DebeME : DecHaber.Value = .HaberME
                End If
                _Cta = .IdCuentaContable
                CargaCombosSegunCta(.IdCuentaContable, .MovimientoCajaBanco, .MovimientoDocumento, .MovimientoAnalisis, .ObligacionFin)
                CargarAnalisis()
                Dim ln As Double = oeDetalleAsiento.MovimientoAnalisis.Where(Function(item) item.TipoOperacion <> "E").ToList.Sum(Function(item) item.Monto)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargaAsientoMovimientoDetalles(ByVal oeAsDetDet As List(Of e_MovimientoAnalisis))
        Try
            With grid_DetalleAsientoAnalisis
                LimpiaGrid(grid_DetalleAsientoAnalisis, odAnalisis)
                If Not oeAsDetDet Is Nothing Then
                    Dim leASiento As New List(Of e_MovimientoAnalisis)
                    '-----------obtengo lista de objetos activos
                    leASiento = oeAsDetDet.Where(Function(item) item.TipoOperacion <> "E").ToList
                    '-----------------
                    .DataSource = leASiento
                    .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdAsientoMovimiento").Hidden = True
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargaCombosSegunCta(ByVal _IdCta As String, ByVal oeMovCajaBanco As e_MovimientoCajaBanco, ByVal oeMovDocumento As e_MovimientoDocumento, _
                                    ByVal leMovAnalisis As List(Of e_MovimientoAnalisis), ByVal oeObligacion As e_ObligacionFin)
        Try
            If String.IsNullOrEmpty(_IdCta) Then
                oeCta = Nothing
            Else
                oeCta.Id = _IdCta : oeCta = olCuentaCtble.Obtener(oeCta)
            End If
            If Not oeCta Is Nothing Then
                ItemGasto(oeCta.Id)
                oeDetalleAsiento.MovimientoAnalisis = leMovAnalisis
                CargaAsientoMovimientoDetalles(leMovAnalisis)
                '--------------Caja y Bancos-----------------
                If oeCta.FlujoCaja = 1 Then
                    FlujoCaja()
                    cboFlujoCaja.Enabled = True : cboFlujoCaja.Value = oeMovCajaBanco.IdFlujoCaja
                    If oeCta.NroDocumento = 1 Then
                        txtNumeroCajaBanco.Enabled = True : txtNumeroCajaBanco.Value = oeMovCajaBanco.NroBoucher
                    Else
                        txtNumeroCajaBanco.Enabled = False : txtNumeroCajaBanco.Value = ""
                    End If
                    If oeCta.FechaEmision = 1 Then
                        FecCajaBanco.Enabled = True : FecCajaBanco.Value = oeMovCajaBanco.Fecha
                    Else
                        FecCajaBanco.Enabled = False : FecCajaBanco.Value = Date.Now
                    End If
                    txtNroDoc.Enabled = False : txtNroDoc.Value = "" : FecEmision.Enabled = False
                Else
                    cboFlujoCaja.Enabled = False : cboFlujoCaja.SelectedIndex = -1
                    txtNumeroCajaBanco.Enabled = False : txtNumeroCajaBanco.Value = ""
                    FecCajaBanco.Enabled = False : FecCajaBanco.Value = Date.Now
                    If oeCta.NroDocumento = 1 Then
                        txtNroDoc.Enabled = True : txtNroDoc.Value = oeMovDocumento.Numero
                    Else
                        txtNroDoc.Enabled = False : txtNroDoc.Value = ""
                    End If
                    If oeCta.FechaEmision = 1 Then
                        FecEmision.Enabled = True : FecEmision.Value = oeMovDocumento.FechaEmision
                    Else
                        FecEmision.Enabled = False : FecEmision.Value = Date.Now
                    End If
                End If
                If oeCta.Conciliacion = 1 Then
                    CuentaBancaria()
                    cboCtaBancaria.Enabled = True : cboCtaBancaria.Value = oeMovCajaBanco.IdCuentaBancaria
                Else
                    cboCtaBancaria.Enabled = False : cboCtaBancaria.SelectedIndex = -1
                End If
                If oeCta.TipoDocGeneral = "1CH000013" Then 'TIPO DE MEDIO DE PAGO
                    TipoDocumentoBanco()
                    cboTipoDocCajaBanco.Enabled = True
                    If Not oeMovCajaBanco.IdMedioPago Is Nothing Then cboTipoDocCajaBanco.Value = oeMovCajaBanco.IdMedioPago.ToString.Trim
                Else
                    cboTipoDocCajaBanco.Enabled = False : cboTipoDocCajaBanco.SelectedIndex = -1
                End If
                '-----------------------------------------
                '--------------Documento------------------
                tabDocumentoDetalle.SelectTab(0)
                If oeCta.TipoDocGeneral = "1CH000014" Then ' TIPO DE DOCUMENTO
                    btnBuscarDoc.Enabled = Agrupacion4.Enabled : TipoDocumentoOperacion()
                    cmbTipoDoc.Enabled = True : cmbTipoDoc.Value = oeMovDocumento.IdTipoDocumento
                Else
                    cmbTipoDoc.Enabled = False : cmbTipoDoc.SelectedIndex = -1 : btnBuscarDoc.Enabled = False
                End If
                If oeCta.Serie = 1 Then
                    btnBuscarDoc.Enabled = Agrupacion4.Enabled : txtNroSerie.Enabled = True : txtNroSerie.Value = oeMovDocumento.Serie
                Else
                    txtNroSerie.Enabled = False : txtNroSerie.Value = "" : btnBuscarDoc.Enabled = False
                End If
                If oeCta.FechaVencimiento = 1 Then
                    btnBuscarDoc.Enabled = Agrupacion4.Enabled : FecVencimiento.Enabled = True : FecVencimiento.Value = oeMovDocumento.FechaVencimiento
                Else
                    FecVencimiento.Enabled = False : FecVencimiento.Value = Date.Now : btnBuscarDoc.Enabled = False
                End If
                If oeCta.TipoCuentaCorriente.Trim <> "" Then 'CLIENTE
                    cboCtaCte.Enabled = True
                    IndCuentaCP = 0
                    If oeCta.TipoCuentaCorriente = "1CH000010" Then 'CLIENTE - 2 VENTA
                        IndCuentaCP = 2 : Cliente()
                    ElseIf oeCta.TipoCuentaCorriente = "1CH000011" Then 'PROVEEDOR - 1 COMPRA
                        IndCuentaCP = 1 : Proveedor()
                    ElseIf oeCta.TipoCuentaCorriente = "1CH000012" Then 'PERSONAL - 3
                        IndCuentaCP = 3 : Personal()
                    End If
                    cboCtaCte.Value = oeMovDocumento.IdClienteProveedor
                    btnBuscarDoc.Enabled = Agrupacion4.Enabled
                Else
                    cboCtaCte.Enabled = False : cboCtaCte.SelectedIndex = -1 : btnBuscarDoc.Enabled = False
                End If
                '-----------------------------------------
                '--------obligacion --------------------
                If oeCta.TipoDocGeneral.Trim = "" And oeCta.Serie = 1 Then
                    'If oeDetalleAsiento.Id <> "" Or (oeCta.TipoDocGeneral.Trim = "" And oeCta.Serie = 1) Then
                    cmbTipoDoc.Enabled = False : txtNroSerie.Enabled = False : txtNroDoc.Enabled = False
                    FecEmision.Enabled = False : FecVencimiento.Enabled = False : cboCtaCte.Enabled = False
                    If oeCta.TipoDocGeneral.Trim = "" And oeCta.Serie = 1 Then
                        cboTipoObligacion.Enabled = True
                        txtCodigoUnico.Enabled = True : fecEmisionObligacion.Enabled = True : fecVencimientoObligacion.Enabled = True : cboBancoObligacion.Enabled = True
                        tabDocumentoDetalle.SelectTab(1)
                    End If
                    If Not oeObligacion Is Nothing Then
                        If oeObligacion.Id <> "" Then
                            tabDocumentoDetalle.SelectTab(1)
                            cboTipoObligacion.Text = oeObligacion.IdTipoObligacion
                            txtCodigoUnico.Value = oeObligacion.NroVencimiento
                            fecEmisionObligacion.Value = oeObligacion.FechaVencimiento
                            fecVencimientoObligacion.Value = oeObligacion.FechaVencimiento
                            cboBancoObligacion.Text = oeObligacion.Banco
                        End If
                    End If
                End If
                '-----------------analisis----------------

                '-----------------------------------------
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#Region "Combos"

    Private Sub FlujoCaja()
        Try
            If cboFlujoCaja.Items.Count = 0 Then
                Dim oeFlujo As New e_FlujoCaja
                Dim olFlujo As New l_FlujoCaja
                oeFlujo.Activo = True
                With cboFlujoCaja
                    .ValueMember = "Id"
                    .DisplayMember = "Nombre"
                    .DataSource = olFlujo.Listar(oeFlujo)
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CuentaBancaria()
        Try
            If cboCtaBancaria.Items.Count = 0 Then
                Dim oeCtaBancaria As New e_CuentaBancaria
                Dim olCtaBancaria As New l_CuentaBancaria
                oeCtaBancaria.Activo = True
                oeCtaBancaria.Ejercicio = Year(fecAsiento.Value)
                With cboCtaBancaria
                    .ValueMember = "Id"
                    .DisplayMember = "NumeroCuenta"
                    .DataSource = olCtaBancaria.Listar(oeCtaBancaria)
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub TipoDocumentoBanco()
        Try
            If cboTipoDocCajaBanco.Items.Count = 0 Then
                Dim oeMedioPago As New e_MedioPago
                Dim olMedioPago As New l_MedioPago
                Dim leMedioPago As New List(Of e_MedioPago)
                oeMedioPago.Activo = True
                leMedioPago.AddRange(olMedioPago.Listar(oeMedioPago))
                With cboTipoDocCajaBanco
                    .ValueMember = "Id"
                    .DisplayMember = "Nombre"
                    .DataSource = leMedioPago
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub TipoDocumentoOperacion()
        Try
            If cmbTipoDoc.Items.Count = 0 Then
                Dim oeTipoDoc As New e_TipoDocumento
                Dim olTipoDoc As New l_TipoDocumento
                oeTipoDoc.Activo = True
                oeTipoDoc.TipoOperacion = "C"
                With cmbTipoDoc
                    .ValueMember = "Id"
                    .DisplayMember = "Nombre"
                    .DataSource = olTipoDoc.Listar(oeTipoDoc)
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub TipoDocumentoObligacion()
        Try
            If cboTipoObligacion.Items.Count = 0 Then
                Dim oeTipoDoc As New e_TipoDocumento
                oeTipoDoc.Activo = True
                oeTipoDoc.TipoOperacion = "I"
                With cboTipoObligacion
                    .ValueMember = "Id"
                    .DisplayMember = "Nombre"
                    .DataSource = olTipoDoc.Listar(oeTipoDoc)
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Cliente()
        Try
            oeDetalleAsiento.MovimientoDocumento.IndCompraVenta = 5
            If _ComboCtaCte <> "CL" Then
                Dim oeCliente As New e_Cliente
                Dim olCliente As New l_Cliente
                oeCliente.Activo = True
                With cboCtaCte
                    .ValueMember = "Id"
                    .DisplayMember = "Nombre"
                    .DataSource = olCliente.Listar(oeCliente)
                End With
                _ComboCtaCte = "CL"
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Proveedor()
        Try
            oeDetalleAsiento.MovimientoDocumento.IndCompraVenta = 4
            If _ComboCtaCte <> "PR" Then
                Dim oeProveedor As New e_Proveedor
                Dim olProveedor As New l_Proveedor
                oeProveedor.Activo = True
                With cboCtaCte
                    .ValueMember = "Id"
                    .DisplayMember = "Nombre"
                    .DataSource = olProveedor.Listar(oeProveedor)
                End With
                _ComboCtaCte = "PR"
            End If
            Dim e As New e_Compra
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Personal()
        Try
            oeDetalleAsiento.MovimientoDocumento.IndCompraVenta = 3
            oeMovimientoDocumento.IndCompraVenta = 3
            If _ComboCtaCte <> "PE" Then
                Dim oeTrabajador As New e_Trabajador, olTrabajador As New l_Trabajador
                oeTrabajador.Activo = True
                With cboCtaCte
                    .ValueMember = "Id" : .DisplayMember = "NombreCompleto"
                    Dim _leTrabAux = olTrabajador.Listar(oeTrabajador)
                    Dim _leTrab = From le In _leTrabAux Select le.Id, le.oePersona.NombreCompleto
                    .DataSource = _leTrab.ToList
                End With
                _ComboCtaCte = "PE"
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ItemGasto(ByVal idCuenta As String)
        Try
            If _ItemCta <> idCuenta Then
                Dim oeItemGasto As New e_ItemGasto
                Dim olItemGasto As New l_ItemGasto
                Dim leItemGasto As New List(Of e_ItemGasto)
                oeItemGasto.Activo = True
                oeItemGasto.IdCuentaContable = idCuenta
                oeItemGasto.Ejercicio = Año1.Año
                leItemGasto.AddRange(olItemGasto.Listar(oeItemGasto))
                '--------------------- para llenar combo en grilla    
                With grid_DetalleAsientoAnalisis.DisplayLayout
                    If .Bands(0).Columns.Exists("IdItemGasto") Then
                        .ValueLists.Clear()
                        .ValueLists.Add("IdItemGasto")
                    End If
                End With
                With grid_DetalleAsientoAnalisis.DisplayLayout.ValueLists("IdItemGasto").ValueListItems
                    .Clear()
                    For Each oeTD As e_ItemGasto In leItemGasto
                        .Add(oeTD.Id, oeTD.Nombre)
                    Next
                End With
                CrearComboGrid3("IdItemGasto", "Nombre", grid_DetalleAsientoAnalisis, True)
                '------------------------------------------
                With cboItemGasto
                    .ValueMember = "Id"
                    .DisplayMember = "Nombre"
                    .DataSource = leItemGasto
                End With

                cboItemGasto.Enabled = Not (cboItemGasto.Items.Count = 0)
                _ItemCta = idCuenta
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GastoFuncion()
        If cboGastonFuncion.Items.Count = 0 Then
            Dim oeTablaContableDet As New e_TablaContableDet
            Dim olTablaContableDet As New l_TablaContableDet
            Dim leTabla As New List(Of e_TablaContableDet)
            oeTablaContableDet.TipoOperacion = "N"
            oeTablaContableDet.Nombre = "GASTO FUNCION" 'Tipo de medio de pago
            oeTablaContableDet.Activo = True
            oeTablaContableDet.Logico2 = 1
            leTabla.AddRange(olTablaContableDet.Listar(oeTablaContableDet))
            '--------------------- para llenar combo en grilla    
            grid_DetalleAsientoAnalisis.DisplayLayout.ValueLists.Add("IdGastoFuncion")
            With grid_DetalleAsientoAnalisis.DisplayLayout.ValueLists("IdGastoFuncion").ValueListItems
                .Clear()
                For Each oeTD As e_TablaContableDet In leTabla
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdGastoFuncion", "Nombre", grid_DetalleAsientoAnalisis, True)
            '------------------------------------------
            With cboGastonFuncion
                .ValueMember = "Id"
                .DisplayMember = "Nombre"
                .DataSource = leTabla
            End With
        End If
    End Sub

    Private Sub CentroCosto()
        Try
            If cboCentroCosto.Items.Count = 0 Then
                Dim oeCentroCosto As New e_CentroCosto
                Dim olCentroCosto As New l_CentroCosto
                Dim leCentroCosto As New List(Of e_CentroCosto)
                oeCentroCosto.Activo = True
                leCentroCosto.AddRange(olCentroCosto.Listar(oeCentroCosto))
                '--------------------- para llenar combo en grilla    
                grid_DetalleAsientoAnalisis.DisplayLayout.ValueLists.Add("IdCentroCosto")
                With grid_DetalleAsientoAnalisis.DisplayLayout.ValueLists("IdCentroCosto").ValueListItems
                    .Clear()
                    For Each oeTD As e_CentroCosto In leCentroCosto
                        .Add(oeTD.Id, oeTD.Nombre)
                    Next
                End With
                CrearComboGrid3("IdCentroCosto", "Nombre", grid_DetalleAsientoAnalisis, True)
                '------------------------------------------

                With cboCentroCosto
                    .ValueMember = "Id"
                    .DisplayMember = "Nombre"
                    .DataSource = leCentroCosto
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Trabajador()
        Try
            If cboTrabajador.Items.Count = 0 Then
                Dim oeTrabajador As New e_Trabajador
                Dim olTrabajador As New l_Trabajador
                Dim leTrabajador As New List(Of e_Trabajador)
                oeTrabajador.Activo = True
                leTrabajador.AddRange(olTrabajador.Listar(oeTrabajador))
                '--------------------- para llenar combo en grilla    
                grid_DetalleAsientoAnalisis.DisplayLayout.ValueLists.Add("IdTrabajador")
                With grid_DetalleAsientoAnalisis.DisplayLayout.ValueLists("IdTrabajador").ValueListItems
                    .Clear()
                    For Each oeTD As e_Trabajador In leTrabajador
                        .Add(oeTD.Id, oeTD.oePersona.NombreCompleto)
                    Next
                End With
                CrearComboGrid3("IdTrabajador", "NombreCompleto", grid_DetalleAsientoAnalisis, True)
                '------------------------------------------
                With cboTrabajador
                    .ValueMember = "Id"
                    .DisplayMember = "NombreCompleto"
                    Dim _leTrabAux = From le In leTrabajador _
                                     Select le.Id, le.oePersona.NombreCompleto
                    .DataSource = _leTrabAux.ToList
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Vehiculo()
        Try
            If cboVehiculo.Items.Count = 0 Then
                Dim oeVehiculo As New e_Vehiculo
                Dim olVehiculo As New l_Vehiculo
                Dim leVehiculo As New List(Of e_Vehiculo)
                oeVehiculo.TipoOperacion = "B"
                oeVehiculo.Activo = True
                oeVehiculo.Motriz = 1
                leVehiculo.AddRange(olVehiculo.Listar(oeVehiculo))
                '--------------------- para llenar combo en grilla    
                grid_DetalleAsientoAnalisis.DisplayLayout.ValueLists.Add("IdVehiculo")
                With grid_DetalleAsientoAnalisis.DisplayLayout.ValueLists("IdVehiculo").ValueListItems
                    .Clear()
                    For Each oeTD As e_Vehiculo In leVehiculo
                        .Add(oeTD.Id, oeTD.Placa)
                    Next
                End With
                CrearComboGrid3("IdVehiculo", "Placa", grid_DetalleAsientoAnalisis, True)
                '------------------------------------------
                With cboVehiculo
                    .ValueMember = "Id"
                    .DisplayMember = "Placa"
                    .DataSource = leVehiculo
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Ruta()
        Try
            If cboRuta.Items.Count = 0 Then
                Dim oeRuta As New e_Ruta
                Dim olRuta As New l_Ruta
                Dim leRutas As New List(Of e_Ruta)
                oeRuta.Activo = True
                leRutas.AddRange(olRuta.Listar(oeRuta))
                '--------------------- para llenar combo en grilla    
                grid_DetalleAsientoAnalisis.DisplayLayout.ValueLists.Add("IdRuta")
                With grid_DetalleAsientoAnalisis.DisplayLayout.ValueLists("IdRuta").ValueListItems
                    .Clear()
                    For Each oeTD As e_Ruta In leRutas
                        .Add(oeTD.Id, oeTD.Nombre)
                    Next
                End With
                CrearComboGrid3("IdRuta", "Nombre", grid_DetalleAsientoAnalisis, True)
                '------------------------------------------
                With cboRuta
                    .ValueMember = "Id"
                    .DisplayMember = "Nombre"
                    .DataSource = leRutas
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Banco()
        Try
            If cboBanco.Items.Count = 0 Then
                Dim leBanco As New List(Of e_Proveedor)
                Dim leBanco2 As New List(Of e_Proveedor)
                Dim oeProveedor As New e_Proveedor
                Dim olProveedor As New l_Proveedor
                oeProveedor.Activo = True
                oeProveedor.TipoOperacion = "4"
                leBanco.AddRange(olProveedor.Listar(oeProveedor))
                leBanco2 = leBanco.ToList

                '--------------------- para llenar combo en grilla    
                grid_DetalleAsientoAnalisis.DisplayLayout.ValueLists.Add("IdBanco")
                With grid_DetalleAsientoAnalisis.DisplayLayout.ValueLists("IdBanco").ValueListItems
                    .Clear()
                    For Each oeTD As e_Proveedor In leBanco
                        .Add(oeTD.Id, oeTD.Nombre)
                    Next
                End With
                CrearComboGrid3("IdBanco", "Nombre", grid_DetalleAsientoAnalisis, True)
                '------------------------------------------
                With cboBanco
                    .ValueMember = "Id"
                    .DisplayMember = "Nombre"
                    .DataSource = leBanco
                End With
                With cboBancoObligacion
                    .ValueMember = "Id"
                    .DisplayMember = "Nombre"
                    .DataSource = leBanco2
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Analisis1()
        Try
            If cboAnalisis1.Items.Count = 0 Then
                'Dim oeTablaContableDet As New e_TablaContableDet
                'Dim olTablaContableDet As New l_TablaContableDet
                'Dim leTabla As New List(Of e_TablaContableDet)
                'oeTablaContableDet.TipoOperacion = "N"
                'oeTablaContableDet.Nombre = "ANALISIS 1" 'Tipo de medio de pago
                'oeTablaContableDet.Activo = True
                'leTabla.AddRange(olTablaContableDet.Listar(oeTablaContableDet))
                '--------------------- para llenar combo en grilla    
                grid_DetalleAsientoAnalisis.DisplayLayout.ValueLists.Add("IdAnalisis1")
                With grid_DetalleAsientoAnalisis.DisplayLayout.ValueLists("IdAnalisis1").ValueListItems
                    .Clear()
                    For Each oeTD As e_Combo In ClienteProveedorPublic
                        .Add(oeTD.Id, oeTD.Nombre)
                    Next
                End With
                CrearComboGrid3("IdAnalisis1", "Nombre", grid_DetalleAsientoAnalisis, True)
                '------------------------------------------
                With cboAnalisis1
                    .ValueMember = "Id"
                    .DisplayMember = "Nombre"
                    .DataSource = ClienteProveedorPublic
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Analisis2()
        Try
            If cboAnalisis2.Items.Count = 0 Then
                Dim oeTablaContableDet As New e_TablaContableDet
                Dim olTablaContableDet As New l_TablaContableDet
                Dim leTabla As New List(Of e_TablaContableDet)
                oeTablaContableDet.TipoOperacion = "N"
                oeTablaContableDet.Nombre = "ANALISIS 2" 'Tipo de medio de pago
                oeTablaContableDet.Activo = True
                leTabla.AddRange(olTablaContableDet.Listar(oeTablaContableDet))
                '--------------------- para llenar combo en grilla    
                grid_DetalleAsientoAnalisis.DisplayLayout.ValueLists.Add("IdAnalisis2")
                With grid_DetalleAsientoAnalisis.DisplayLayout.ValueLists("IdAnalisis2").ValueListItems
                    .Clear()
                    For Each oeTD As e_TablaContableDet In leTabla
                        .Add(oeTD.Id, oeTD.Nombre)
                    Next
                End With
                CrearComboGrid3("IdAnalisis2", "Nombre", grid_DetalleAsientoAnalisis, True)
                '------------------------------------------
                With cboAnalisis2
                    .ValueMember = "Id"
                    .DisplayMember = "Nombre"
                    .DataSource = olTablaContableDet.Listar(oeTablaContableDet)
                End With
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

    Private Sub MontoDetalle()

        If cboMoneda.Text = "SOLES" Or cboMoneda.Value = "1CH01" Then 'soles
            oeDetalleAsiento.DebeMN = DecDebe.Value
            oeDetalleAsiento.DebeME = IIf(decTC.Value <> 0, DecDebe.Value / decTC.Value, 0)
            oeDetalleAsiento.HaberMN = DecHaber.Value
            oeDetalleAsiento.HaberME = IIf(decTC.Value <> 0, DecHaber.Value / decTC.Value, 0)
        Else
            oeDetalleAsiento.DebeMN = DecDebe.Value * decTC.Value
            oeDetalleAsiento.DebeME = DecDebe.Value
            oeDetalleAsiento.HaberMN = DecHaber.Value * decTC.Value
            oeDetalleAsiento.HaberME = DecHaber.Value
        End If
    End Sub

    Private Sub GuardarAsientoDetalle()
        Try
            If ValidarAsientoDetalle() Then
                MontoDetalle()
                If cboFlujoCaja.Enabled Then
                    oeMovimientoCajaBanco._Operador = IIf(DecHaber.Value > 0, -1, 1)
                    oeMovimientoCajaBanco.Fecha = FecCajaBanco.Value : oeDetalleAsiento.MovimientoCajaBanco = oeMovimientoCajaBanco
                End If
                'If btnBuscarDoc.Enabled Then
                '    oeDetalleAsiento.AsMov_MovDoc.IdMovimientoDocumento = oeMovimientoDocumento.Id
                '    oeDetalleAsiento.AsMov_MovDoc.TipoOperacion = "I"
                'End If
                If cmbTipoDoc.Enabled Then
                    oeDetalleAsiento.AsMov_MovDoc.IdMovimientoDocumento = oeMovimientoDocumento.Id
                    oeDetalleAsiento.AsMov_MovDoc.TipoOperacion = "I"
                    oeDetalleAsiento.MovimientoDocumento = oeMovimientoDocumento
                End If
                If cboTipoObligacion.Enabled Then
                    If cboTipoObligacion.Text <> "" Then
                        oeDetalleAsiento.AsMov_ObligacionFin.IdObligacionFinanciera = oeObligacionFin.Id
                        oeDetalleAsiento.AsMov_ObligacionFin.IdObligacionFinanciera = oeObligacionFin.Id
                        oeDetalleAsiento.AsMov_ObligacionFin.TipoOperacion = "I"
                        oeDetalleAsiento.ObligacionFin = oeObligacionFin
                    End If
                End If
                With oeDetalleAsiento
                    .PrefijoID = gs_PrefijoIdSucursal '@0001
                    If .TipoOperacion = "I" Then 'si es detalle nuevo agrego a objeto cabecera
                        oeDetalleAsiento.NroLinea = oeAsiento.AsientoMovimiento.Count + 1
                        oeDetalleAsiento.IdUsuarioCrea = gUsuarioSGI.Id
                        oeAsiento.AsientoMovimiento.Add(oeDetalleAsiento)
                    ElseIf .TipoOperacion = "A" Then ' Actualiza detalle del asiento
                        oeDetalleAsiento.NroLinea = oeAsiento.AsientoMovimiento.Count + 1
                        If _CuentaEdita = .IdCuentaContable Then
                            oeAsiento.AsientoMovimiento.Item(_IndexMovEdita) = oeDetalleAsiento
                        Else
                            If oeDetalleAsiento.Id = "" Then
                                oeAsiento.AsientoMovimiento.Item(_IndexMovEdita) = oeDetalleAsiento
                            Else 'viene de base de datos
                                oeAsiento.AsientoMovimiento.Item(_IndexMovEdita).TipoOperacion = "E"
                                Dim oeDA As New e_AsientoMovimiento
                                oeDA.DivideAnalisis = False
                                oeDA = oeDetalleAsiento : oeDA.TipoOperacion = "I"
                                oeAsiento.AsientoMovimiento.Add(oeDA)
                            End If
                        End If
                        oeDetalleAsiento.TipoOperacion = IIf(oeDetalleAsiento.Id <> "", "A", "I")
                    End If
                    'recargo grilla
                    CargaAsientoMovimiento(oeAsiento.AsientoMovimiento)
                End With
                MostrarTabs(0, tcAsientoDetalle, 2)
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidarAsientoDetalle() As Boolean
        Try
            If cboCuenta.Text = "" Then Throw New Exception("Seleccione Cuenta")
            l_FuncionesGenerales.ValidarCampoNoNulo(txt_GlosaDetalle.Text, "Ingrese la Glosa")
            If DecDebe.Value = 0 And DecHaber.Value = 0 Then l_FuncionesGenerales.ValidarNumero(DecDebe.Value, "Ingresa Debe")
            If DecDebe.Value <> 0 And DecHaber.Value <> 0 Then Throw New Exception("Debe y haber no pueden tener monto")
            If cboFlujoCaja.Enabled Then ValidarCombo(cboFlujoCaja, "Flujo de Caja")
            If cboTipoDocCajaBanco.Enabled Then ValidarCombo(cboTipoDocCajaBanco, "Tipo de Documento de Caja y banco")
            If cboCtaBancaria.Enabled Then ValidarCombo(cboCtaBancaria, "Cuenta Bancaria")
            If txtNumeroCajaBanco.Enabled Then l_FuncionesGenerales.ValidarCampoNoNulo(txtNumeroCajaBanco.Text, "Ingrese el Nro de Caja y Banco")
            If cmbTipoDoc.Enabled Then ValidarCombo(cmbTipoDoc, "Tipo de Documento")
            If txtNroSerie.Enabled Then l_FuncionesGenerales.ValidarCampoNoNulo(txtNroSerie.Text, "Serie")
            If txtNroDoc.Enabled Then l_FuncionesGenerales.ValidarCampoNoNulo(txtNroDoc.Text, "Ingrese el Número de Documento")
            If cboCtaCte.Enabled Then ValidarCombo(cboCtaCte, "Cuenta Corriente")
            If cboTipoObligacion.Enabled Then ValidarCombo(cboTipoObligacion, "Tipo obligación")
            If txtCodigoUnico.Enabled Then l_FuncionesGenerales.ValidarCampoNoNulo(txtCodigoUnico.Text, "Código único")
            'If fecEmisionObligacion.Enabled Then ValidarCombo(cboCtaCte, "Fecha emisión obligación")
            'If fecVencimientoObligacion.Enabled Then ValidarCombo(cboCtaCte, "Fecha vencimiento obligación")
            If cboBancoObligacion.Enabled Then ValidarCombo(cboBancoObligacion, "Banco obligación")

            If (cboItemGasto.Enabled Or cboGastonFuncion.Enabled Or cboCentroCosto.Enabled Or cboTrabajador.Enabled Or _
                cboVehiculo.Enabled Or cboRuta.Enabled Or cboBanco.Enabled Or cboAnalisis1.Enabled Or _
                cboAnalisis2.Enabled) And grid_DetalleAsientoAnalisis.Rows.Count < 1 Then
                If DecDebe.Value > 0 Then
                    Throw New Exception("Ingresar Detalles de Análisis")
                End If
            End If
            If cboItemGasto.Enabled = False And cboGastonFuncion.Enabled And cboCentroCosto.Enabled = False And cboTrabajador.Enabled = False And _
                cboVehiculo.Enabled = False And cboRuta.Enabled = False And cboBanco.Enabled = False And cboAnalisis1.Enabled = False And _
                cboAnalisis2.Enabled = False And grid_DetalleAsientoAnalisis.Rows.Count > 1 Then
                Throw New Exception("Esta cuenta no admite Detalles de Análisis")
            End If
            Dim leASiento As New List(Of e_MovimientoAnalisis)
            '-----------obtengo lista de objetos activos
            leASiento = oeDetalleAsiento.MovimientoAnalisis.Where(Function(item) item.TipoOperacion <> "E").ToList
            '-----------------
            Dim sumadetallesAnalisis As Double = 0
            For Each obj As e_MovimientoAnalisis In leASiento
                sumadetallesAnalisis = sumadetallesAnalisis + obj.Monto
            Next
            If (cboItemGasto.Enabled Or cboGastonFuncion.Enabled Or cboCentroCosto.Enabled Or cboTrabajador.Enabled Or _
                cboVehiculo.Enabled Or cboRuta.Enabled Or cboBanco.Enabled Or cboAnalisis1.Enabled Or _
                cboAnalisis2.Enabled) Then
                If DecDebe.Value > 0 And Math.Round(sumadetallesAnalisis, 2) <> Math.Round(DecHaber.Value + DecDebe.Value, 2) Then
                    Throw New Exception("los analisis y el total del detalle del asiento no coincide: Total analisis= " & Math.Round(sumadetallesAnalisis, 2).ToString)
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fb_ValidaAgregaMovimientoAnalisis() As Boolean
        Try
            Dim bandera As Boolean
            If cboItemGasto.Enabled Then
                ValidarCombo(cboItemGasto, "Item Gasto")
                bandera = True
            Else
                cboItemGasto.SelectedIndex = -1
            End If
            If cboGastonFuncion.Enabled Then
                ValidarCombo(cboGastonFuncion, "Gasto Funcion")
                bandera = True
            Else
                cboGastonFuncion.SelectedIndex = -1
            End If
            If cboCentroCosto.Enabled Then
                ValidarCombo(cboCentroCosto, "Centro de Costo")
                bandera = True
            Else
                cboCentroCosto.SelectedIndex = -1
            End If
            If cboTrabajador.Enabled Then
                ValidarCombo(cboTrabajador, "Trabajador")
                bandera = True
            Else
                cboTrabajador.SelectedIndex = -1
            End If
            If cboVehiculo.Enabled Then
                ValidarCombo(cboVehiculo, "Vehiculo")
                bandera = True
            Else
                cboVehiculo.SelectedIndex = -1
            End If
            If cboRuta.Enabled Then
                ValidarCombo(cboRuta, "Ruta")
                bandera = True
            Else
                cboRuta.SelectedIndex = -1
            End If
            If cboBanco.Enabled Then
                ValidarCombo(cboBanco, "Banco")
                bandera = True
            Else
                cboBanco.SelectedIndex = -1
            End If
            If cboAnalisis1.Enabled Then
                ValidarCombo(cboAnalisis1, "Analisis 1")
                bandera = True
            Else
                cboAnalisis1.SelectedIndex = -1
            End If
            If cboAnalisis2.Enabled Then
                ValidarCombo(cboAnalisis2, "Analisis 2")
                bandera = True
            Else
                cboAnalisis2.SelectedIndex = -1
            End If
            If Not bandera Then
                Throw New Exception("No hay nada que agregar")
            End If
            If DecMontoAn.Value = 0 Then
                Throw New Exception("Ingrese Monto")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub AgregarMovimientoAnalisis()
        Try
            If fb_ValidaAgregaMovimientoAnalisis() Then
                'Inicializo objeto
                oeMovimientoAnalisis = New e_MovimientoAnalisis
                Dim leListaAn As New List(Of e_MovimientoAnalisis)
                '---capturo datos a ingresa-----
                If ChkVehiculoProper.Checked Then
                    Dim checkedItemList As ICheckedItemList = DirectCast(cboVehiculo.Items.ValueList, ICheckedItemList)
                    For i As Integer = 0 To cboVehiculo.Items.Count - 1
                        oeMovimientoAnalisis = New e_MovimientoAnalisis
                        Dim item As ValueListItem = cboVehiculo.Items(i)
                        Dim checkState__1 As CheckState = checkedItemList.GetCheckState(i)
                        If checkState__1 = CheckState.Checked Then
                            With oeMovimientoAnalisis
                                .Id = ""
                                .IdAsientoMovimiento = oeDetalleAsiento.Id
                                .IdItemGasto = cboItemGasto.Value
                                .IdGastoFuncion = cboGastonFuncion.Value
                                .IdCentroCosto = cboCentroCosto.Value
                                .IdTrabajador = cboTrabajador.Value
                                .IdRuta = cboRuta.Value
                                .IdVehiculo = item.DataValue.ToString
                                .IdBanco = cboBanco.Value
                                .IdAnalisis1 = cboAnalisis1.Value
                                .IdAnalisis2 = cboAnalisis2.Value
                                .Monto = DecMontoAn.Value
                                .Saldo = DecMontoAn.Value
                                .Activo = True
                                .TipoOperacion = "I"
                            End With
                            leListaAn.Add(oeMovimientoAnalisis)
                        End If
                    Next

                Else
                    With oeMovimientoAnalisis
                        .Id = ""
                        .IdAsientoMovimiento = oeDetalleAsiento.Id
                        .IdItemGasto = cboItemGasto.Value
                        .IdGastoFuncion = cboGastonFuncion.Value
                        .IdCentroCosto = cboCentroCosto.Value
                        .IdTrabajador = cboTrabajador.Value
                        .IdVehiculo = cboVehiculo.Value
                        .IdRuta = cboRuta.Value
                        .IdBanco = cboBanco.Value
                        .IdAnalisis1 = cboAnalisis1.Value
                        .IdAnalisis2 = cboAnalisis2.Value
                        .Monto = DecMontoAn.Value
                        .Saldo = DecMontoAn.Value
                        .Activo = True
                        .TipoOperacion = "I"
                    End With
                    leListaAn.Add(oeMovimientoAnalisis)
                End If

                '-----------------------
                For Each obj As e_MovimientoAnalisis In leListaAn
                    With oeDetalleAsiento
                        If .TipoOperacion = "I" Then ' cuando inserto o nuevo cabecera y detalles
                            If Not oeDetalleAsiento.MovimientoAnalisis.Contains(obj) Then
                                ' si no esta en la lista o no esta contenido AGREGOOO
                                .MovimientoAnalisis.Add(obj)
                            Else
                                If ChkVehiculoProper.Checked Then
                                    Throw New Exception("Ya existe un Análisis")
                                Else
                                    Throw New Exception("Ya existe esta Análisis")
                                End If
                            End If
                        ElseIf .TipoOperacion = "A" Then ' cuando actualizo o edito el objeto
                            If Not .MovimientoAnalisis.Contains(obj) Then
                                ' si no esta en la lista o no esta contenido AGREGOOO
                                .MovimientoAnalisis.Add(obj)
                            Else
                                '-------BUSCA OBJETO EN LA LISTA DE OBJETOS
                                oeMovimientoAnalisis = .MovimientoAnalisis.Item(.MovimientoAnalisis.IndexOf(obj))
                                '---------
                                If oeMovimientoAnalisis.TipoOperacion = "E" Then 'Existe en la BD y esta para eliminarse
                                    ' la dejo como estaba al inicio(carga)
                                    oeMovimientoAnalisis.TipoOperacion = ""
                                Else
                                    Throw New Exception("Ya existe esta Cuenta")
                                End If
                            End If
                        End If
                        'recargo grilla
                        CargaAsientoMovimientoDetalles(oeDetalleAsiento.MovimientoAnalisis)
                    End With
                Next
                Dim ln As Double = oeDetalleAsiento.MovimientoAnalisis.Where(Function(item) item.TipoOperacion <> "E").ToList.Sum(Function(item) item.Monto)
                'EtiTotalAnalisis.Text = ln.ToString
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarMovimientoAnalisis()
        Try
            If grid_DetalleAsientoAnalisis.Rows.Count > 0 Then
                With oeDetalleAsiento
                    'inicialializo mi objeto
                    oeMovimientoAnalisis = New e_MovimientoAnalisis
                    '---Obtengo O CAPTURO objeto de la grilla 
                    oeMovimientoAnalisis = grid_DetalleAsientoAnalisis.ActiveRow.ListObject
                    '----------------------
                    If .TipoOperacion = "I" Then 'cuando inserto o nuevo objeto cabecera y detalles
                        '-----remuevo o elimino de mi lista de objetos
                        .MovimientoAnalisis.Remove(oeMovimientoAnalisis)
                        '-------------------
                    ElseIf .TipoOperacion = "A" Then ' cuando actualizo o edito el objeto
                        If oeMovimientoAnalisis.Id <> "" Then '---viene de BD
                            '-----Solo cambio tipo de operacion para desactivar ya que viene de BD
                            oeMovimientoAnalisis.TipoOperacion = "E"
                            '--------------------
                        Else '-----no viene de BD
                            '-----remuevo de mi lista de objetos
                            .MovimientoAnalisis.Remove(oeMovimientoAnalisis)
                            '----------------------------
                        End If
                    End If
                    CargaAsientoMovimientoDetalles(.MovimientoAnalisis) '----recargo mi grilla
                End With
                Dim ln As Double = oeDetalleAsiento.MovimientoAnalisis.Where(Function(item) item.TipoOperacion <> "E").ToList.Sum(Function(item) item.Monto)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarAnalisis()
        If oeCta.GastoFuncion = 1 Then
            cboGastonFuncion.Enabled = True : GastoFuncion()
        Else
            cboGastonFuncion.Enabled = False : cboGastonFuncion.SelectedIndex = -1
        End If
        If oeCta.CentroCosto = 1 Then
            cboCentroCosto.Enabled = True : CentroCosto()
        Else
            cboCentroCosto.Enabled = False : cboCentroCosto.SelectedIndex = -1
        End If
        If oeCta.Trabajador = 1 Then
            cboTrabajador.Enabled = True : Trabajador()
        Else
            cboTrabajador.Enabled = False : cboTrabajador.SelectedIndex = -1
        End If
        If oeCta.Tracto = 1 Then
            ChkVehiculoProper.Enabled = True : cboVehiculo.Enabled = True : Vehiculo()
        Else
            ChkVehiculoProper.Enabled = False : cboVehiculo.Enabled = False : cboVehiculo.SelectedIndex = -1
        End If
        If oeCta.Ruta = 1 Then
            cboRuta.Enabled = True : Ruta()
        Else
            cboRuta.Enabled = False : cboRuta.SelectedIndex = -1
        End If
        If oeCta.Banco = 1 Then
            cboBanco.Enabled = True : Banco()
        Else
            cboBanco.Enabled = False : cboBanco.SelectedIndex = -1
        End If
        If oeCta.Analisis01 = 1 Then
            cboAnalisis1.Enabled = True : Analisis1()
        Else
            cboAnalisis1.Enabled = False : cboAnalisis1.SelectedIndex = -1
        End If
        If oeCta.Analisis02 = 1 Then
            cboAnalisis2.Enabled = True : Analisis2()
        Else
            cboAnalisis2.Enabled = False : cboAnalisis2.SelectedIndex = -1
        End If
        If oeCta.CentroCosto = 1 Or oeCta.Trabajador = 1 Or oeCta.Tracto = 1 Or oeCta.Ruta = 1 Or oeCta.Banco = 1 Or oeCta.Analisis01 = 1 Or _
        oeCta.Analisis02 = 1 Or cboItemGasto.Enabled = True Or cboGastonFuncion.Enabled = True Then
            cmbAgregarAnalisis.Enabled = True : DecMontoAn.Enabled = True
        Else
            cmbAgregarAnalisis.Enabled = False : DecMontoAn.Enabled = False
        End If
    End Sub

    Private Sub InicializaAnalisis(ByVal _band As Boolean)
        DecMontoAn.Value = 0 : cboGastonFuncion.SelectedIndex = -1 : cboItemGasto.SelectedIndex = -1 : cboCentroCosto.SelectedIndex = -1
        cboTrabajador.SelectedIndex = -1 : ChkVehiculoProper.Checked = False : cboVehiculo.SelectedIndex = -1 : cboRuta.SelectedIndex = -1
        cboBanco.SelectedIndex = -1 : cboAnalisis1.SelectedIndex = -1 : cboAnalisis2.SelectedIndex = -1 : DecMontoAn.Enabled = False
        cboGastonFuncion.Enabled = False : cboItemGasto.Enabled = False : cboCentroCosto.Enabled = False : cboTrabajador.Enabled = False
        ChkVehiculoProper.Enabled = False : cboVehiculo.Enabled = False : cboRuta.Enabled = False : cboBanco.Enabled = False
        cboAnalisis1.Enabled = False : cboAnalisis2.Enabled = False : Agrupacion2.Enabled = True : grid_DetalleAsientoAnalisis.Enabled = True
        cmbAgregarAnalisis.Enabled = False
        If _band And grid_DetalleAsientoAnalisis.Rows.Count > 0 Then
            If MessageBox.Show("Hay Registros Ingresados en el Analisis del Detalle." & Environment.NewLine & "¿Desea Eliminar los Registros?", _
                               "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                LimpiaGrid(grid_DetalleAsientoAnalisis, odAnalisis)
                If oeDetalleAsiento.TipoOperacion = "I" Then
                    Dim oeMovA As New List(Of e_MovimientoAnalisis)
                    oeDetalleAsiento.MovimientoAnalisis = oeMovA
                Else
                    For Each obj As e_MovimientoAnalisis In oeDetalleAsiento.MovimientoAnalisis
                        If obj.IdAsientoMovimiento <> "" Then
                            obj.TipoOperacion = "E"
                        Else
                            oeDetalleAsiento.MovimientoAnalisis.Remove(obj)
                        End If
                    Next
                End If
            End If
        End If
    End Sub

#End Region

#End Region

#Region "Eventos"

#Region "Cabecera"

    Private Sub Año1_DatoCambiado() Handles Año1.DatoCambiado
        Try
            ComboPeriodoList()
            LimpiaGrid(grid_ComprobanteDiario, UltraDataSource1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub oeAsiento_DatoCambiado() Handles oeAsiento.DatoCambiado
        oeAsiento.Modificado = True
    End Sub

    Private Sub frm_ComprobanteDiario_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        Else
            ControlBoton(1, 1, 0, 0, 0, 0, 1, 1, 1)
        End If
    End Sub

    Private Sub frm_ComprobanteDiario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ComprobanteDiario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case _Operacion
            Case "Nuevo", "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_ComprobanteDiario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            MostrarTabs(0, tcComprobanteDiario)
            _ComboPeriodo = True
            LlenarCombos()
            TipoDocumentoObligacion()
            Banco()
            ListaUsuarios(grid_ComprobanteDiario, "IdUsuarioCrea")
            ListaUsuarios(grid_AsientoDetalle, "IdUsuarioCrea")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gridComprobanteDiario_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles grid_ComprobanteDiario.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub gridComprobanteDiario_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid_ComprobanteDiario.DoubleClick
        If grid_ComprobanteDiario.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub grid_ComprobanteDiario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid_ComprobanteDiario.KeyDown
        If Not grid_ComprobanteDiario.ActiveRow.IsFilterRow Then
            TeclaPulsada(e)
        End If
    End Sub

    Private Sub EliminaCabecera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminaCabecera.Click
        Try
            Eliminar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub AgregarCabecera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarCabecera.Click
        Nuevo()
    End Sub

    Private Sub EditarCabecera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarCabecera.Click
        Try
            Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub FecAsiento_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles FecAsiento.Validated
        Try
            If oeAsiento.TipoOperacion = "I" Then
                decTC.Value = TipoCambio(FecAsiento.Value)(0)
            ElseIf oeAsiento.TipoOperacion = "A" Then
                If decTC.Value = 0 Then
                    decTC.Value = TipoCambio(FecAsiento.Value)(0)
                Else
                    If MessageBox.Show("Desea Cambiar al Tipo de Cambio del dia?", "Mensaje del sistema", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) _
                       = Windows.Forms.DialogResult.Yes Then
                        decTC.Value = TipoCambio(FecAsiento.Value)(0)
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub FecAsiento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecAsiento.ValueChanged
        'oeAsiento.Fecha = FecAsiento.Value
    End Sub

    Private Sub cboMoneda_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMoneda.ValueChanged
        oeAsiento.IdMoneda = cboMoneda.Value
    End Sub

    Private Sub decTC_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decTC.ValueChanged
        oeAsiento.TipoCambio = decTC.Value
    End Sub

    Private Sub txtGlosa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa.ValueChanged
        oeAsiento.Glosa = txtGlosa.Value
        oeAsiento.GlosaImprime = txtGlosa.Value
    End Sub

    Private Sub DecDebeAsiento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecDebeAsiento.ValueChanged
        oeAsiento.TotalDebe = DecDebeAsiento.Value
    End Sub

    Private Sub DecHaberAsiento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecHaberAsiento.ValueChanged
        oeAsiento.TotalHaber = DecHaberAsiento.Value
    End Sub

    Private Sub DuplicarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DuplicarToolStripMenuItem.Click
        Try
            ValidarGrilla(grid_ComprobanteDiario, "Comprobante Diario")
            If Not grid_ComprobanteDiario.ActiveRow Is Nothing AndAlso grid_ComprobanteDiario.ActiveRow.Cells("Id").Value.ToString <> "" Then
                Dim frm As New Frm_PeriodoTipoAsiento(True, True, True, "CTB")
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    oeAsiento = New e_Asiento
                    olAsiento = New l_Asiento
                    oeAsiento.Id = grid_ComprobanteDiario.ActiveRow.Cells("Id").Value.ToString
                    oeAsiento.IdPeriodo = frm.cboMes.Value
                    oeAsiento.IdTipoAsiento = frm.cboTipoAsiento.Value
                    oeAsiento.Fecha = frm.FecEmision.Value
                    oeAsiento.IdUsuarioCrea = gUsuarioSGI.Id
                    l_FuncionesGenerales.ValidarPeriodo(oeAsiento.IdPeriodo, gAreasSGI.Contabilidad, Date.Parse("01/01/1901"), "")
                    olAsiento.DuplicaAsiento(oeAsiento)
                    mensajeEmergente.Confirmacion("Se a registrado-Duplicado corretamente", True)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ExtornarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExtornarToolStripMenuItem.Click
        Try
            ValidarGrilla(grid_ComprobanteDiario, "Comprobante Diario")
            If Not grid_ComprobanteDiario.ActiveRow Is Nothing AndAlso grid_ComprobanteDiario.ActiveRow.Cells("Id").Value.ToString <> "" Then
                If olTrabSeg.Permisos(gUsuarioSGI.IdTrabajador, "EXTORNAR ASIENTO") Then
                    Dim frm As New Frm_PeriodoTipoAsiento(True, True, True, "CTB")
                    frm.etiEmision.Visible = False
                    frm.FecEmision.Visible = False
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        If frm.cboTipoAsiento.Value <> "1CH000020" Then Throw New Exception("Solo se puede extornar a tipo de asiento diario.")
                        oeAsiento = New e_Asiento
                        olAsiento = New l_Asiento
                        oeAsiento.Id = grid_ComprobanteDiario.ActiveRow.Cells("Id").Value.ToString
                        oeAsiento.IdPeriodo = frm.cboMes.Value
                        oeAsiento.IdTipoAsiento = "1CH000020"
                        oeAsiento.Fecha = frm.FecEmision.Value
                        oeAsiento.IdUsuarioCrea = gUsuarioSGI.Id
                        oeAsiento.Glosa = "ASIENTO EXTORNADO " & grid_ComprobanteDiario.ActiveRow.Cells("Glosa").Value.ToString
                        oeAsiento.GlosaImprime = "ASIENTO EXTORNADO " & grid_ComprobanteDiario.ActiveRow.Cells("GlosaImprime").Value.ToString
                        l_FuncionesGenerales.ValidarPeriodo(oeAsiento.IdPeriodo, gAreasSGI.Contabilidad, Date.Parse("01/01/1901"), "")
                        olAsiento.ExtornarAsiento(oeAsiento)
                        mensajeEmergente.Confirmacion("Se extornó el asiento correctamente", True)
                    End If
                Else
                    Throw New Exception("No Tiene Permiso de Extorno")
                End If
            Else
                Throw New Exception("Seleccione una fila válida")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cmbPeriodo_ValueChanged(sender As Object, e As EventArgs) Handles cmbPeriodo.ValueChanged
        oeAsiento.IdPeriodo = cmbPeriodo.Value
    End Sub

    Private Sub cmbTipoAsiento_ValueChanged(sender As Object, e As EventArgs) Handles cmbTipoAsiento.ValueChanged
        oeAsiento.IdTipoAsiento = cmbTipoAsiento.Value
    End Sub

    Private Sub numAño_ValueChanged(sender As Object, e As EventArgs) Handles numAño.ValueChanged
        Try
            If lnInicializacion = 1 Then
                ComboPeriodoMant()
                CuentaContable()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Detalle"

    Private Sub gridAsientoDetalle_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) _
    Handles grid_AsientoDetalle.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub grid_AsientoDetalle_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid_AsientoDetalle.DoubleClick
        'Try
        '    ModificaDetalle()
        'Catch ex As Exception
        '    mensajeEmergente.Problema(ex.Message, True)
        'End Try
    End Sub

    Private Sub grid_AsientoDetalle_DoubleClickRow(sender As Object, e As UltraWinGrid.DoubleClickRowEventArgs) Handles grid_AsientoDetalle.DoubleClickRow
        Try
            If e.Row.Index >= 0 Then
                ModificaDetalle()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_AsientoDetalle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid_AsientoDetalle.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Insert
                    NuevoDetalle()
                Case Keys.Add
                    NuevoDetalle()
                Case Keys.F3
                    NuevoDetalle()
                Case Keys.Multiply
                    ModificaDetalle()
                Case Keys.Delete
                    EliminarD()
                Case Keys.Delete
                    EliminarD()
                Case Keys.Subtract
                    EliminarD()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mnuDetalleAsiento_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles mnuDetalleAsiento.ToolClick
        Try
            Select Case e.Tool.Key
                Case "Agregar"
                    GuardarAsientoDetalle()
                Case "Modificar"
                    GuardarAsientoDetalle()
                Case "Cancelar"
                    MostrarTabs(0, tcAsientoDetalle, 2)
                Case "Exportar"
                    Exportar_Excel(grid_DetalleAsientoAnalisis)
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub AgregarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarDetalle.Click
        NuevoDetalle()
    End Sub

    Private Sub EditarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarDetalle.Click
        ModificaDetalle()
    End Sub

    Private Sub EliminarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarDetalle.Click
        Try
            EliminarD()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ExportarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportarToolStripMenuItem.Click
        Exportar_Excel(grid_AsientoDetalle)
    End Sub

    Private Sub cmbAgregarAnalisis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAgregarAnalisis.Click
        Try
            AgregarMovimientoAnalisis()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub EliminarAnalisis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            QuitarMovimientoAnalisis()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txt_GlosaDetalle_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_GlosaDetalle.ValueChanged
        oeDetalleAsiento.Glosa = txt_GlosaDetalle.Text
    End Sub

    Private Sub cboFlujoCaja_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFlujoCaja.ValueChanged
        oeMovimientoCajaBanco.IdFlujoCaja = cboFlujoCaja.Value
    End Sub

    Private Sub cboTipoDocCajaBanco_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoDocCajaBanco.ValueChanged
        oeMovimientoCajaBanco.IdMedioPago = cboTipoDocCajaBanco.Value
    End Sub

    Private Sub cboCtaBancaria_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCtaBancaria.ValueChanged
        oeMovimientoCajaBanco.IdCuentaBancaria = cboCtaBancaria.Value
    End Sub

    Private Sub txtNumeroCajaBanco_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumeroCajaBanco.ValueChanged
        oeMovimientoCajaBanco.NroBoucher = txtNumeroCajaBanco.Text
    End Sub

    Private Sub cboTipoDocDocumento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoDoc.ValueChanged
        oeMovimientoDocumento.IdTipoDocumento = cmbTipoDoc.Value
    End Sub

    Private Sub txtNroSerie_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroSerie.Validated
        txtNroSerie.Text = FormatoDocumento(txtNroSerie.Text, 4)
    End Sub

    Private Sub txtNroSerie_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroSerie.ValueChanged
        oeMovimientoDocumento.Serie = txtNroSerie.Value
    End Sub

    Private Sub txtNroDocDocumento_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroDoc.Validated
        txtNroDoc.Text = FormatoDocumento(txtNroDoc.Text, 10)
    End Sub

    Private Sub txtNroDocDocumento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroDoc.ValueChanged
        oeMovimientoDocumento.Numero = txtNroDoc.Value
    End Sub

    Private Sub FecEmision_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles FecEmision.Validated

    End Sub

    Private Sub FecEmision_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecEmision.ValueChanged
        oeMovimientoDocumento.FechaEmision = FecEmision.Value
    End Sub

    Private Sub FecVencimiento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecVencimiento.ValueChanged
        oeMovimientoDocumento.FechaVencimiento = FecVencimiento.Value
    End Sub

    Private Sub cboCtaCte_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCtaCte.ValueChanged
        oeMovimientoDocumento.IdClienteProveedor = cboCtaCte.Value
    End Sub

    Private Sub FecCajaBanco_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecCajaBanco.ValueChanged
        oeMovimientoCajaBanco.Fecha = FecCajaBanco.Value
    End Sub

    Private Sub ChkVehiculoProper_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkVehiculoProper.CheckedChanged
        If ChkVehiculoProper.Checked Then
            With cboVehiculo.CheckedListSettings
                .CheckBoxStyle = Infragistics.Win.CheckStyle.CheckBox
                .EditorValueSource = Infragistics.Win.EditorWithComboValueSource.CheckedItems
                .ListSeparator = ";"
            End With
        Else
            With cboVehiculo.CheckedListSettings
                .CheckBoxStyle = Infragistics.Win.CheckStyle.None
                .EditorValueSource = Infragistics.Win.EditorWithComboValueSource.SelectedItem
                .ListSeparator = ""
            End With
            'Dim itemList As ICheckedItemList = DirectCast(Me.cboVehiculo.Items.ValueList, ICheckedItemList)
            'For i As Integer = 0 To Me.cboVehiculo.Items.Count - 1
            '    itemList.SetCheckState(i, CheckState.Unchecked)
            'Next
        End If
        cboVehiculo.SelectedIndex = -1
    End Sub

    Private Sub cboCuenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCuenta.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cboCuenta.PerformAction(UltraWinGrid.UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub cboCuenta_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCuenta.Validated
        Try
            If cboCuenta.Value <> _Cta Then
                With oeDetalleAsiento
                    If Not .MovimientoAnalisis Is Nothing AndAlso .MovimientoAnalisis.Count > 0 Then
                        If MessageBox.Show("Si cambia de Cuenta se eliminar todos los detalles" & vbCrLf & "Desea continuar?", _
                        "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) _
                        = Windows.Forms.DialogResult.No Then
                            Exit Sub
                        Else
                            If .TipoOperacion = "I" Then
                                Dim oeMovA As New List(Of e_MovimientoAnalisis)
                                .MovimientoAnalisis = oeMovA
                            Else
                                For Each obj As e_MovimientoAnalisis In .MovimientoAnalisis
                                    If obj.IdAsientoMovimiento <> "" Then
                                        obj.TipoOperacion = "E"
                                    Else
                                        .MovimientoAnalisis.Remove(obj)
                                    End If
                                Next
                            End If
                        End If
                    End If
                    .IdCuentaContable = cboCuenta.Value
                    oeMovimientoDocumento.IdCuentaContable = .IdCuentaContable
                    LimpiarDetalle()
                    CargaCombosSegunCta(.IdCuentaContable, oeMovimientoCajaBanco, oeMovimientoDocumento, .MovimientoAnalisis, .ObligacionFin)
                    _Cta = cboCuenta.Value
                End With
            End If
            Me.DecDebe.Focus()
            Me.DecDebe.SelectAll()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboCuenta_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCuenta.ValueChanged
        Dim leCta As New List(Of e_CuentaContable)
        leCta = leCuenta.ToList
        leCta = leCta.Where(Function(item) item.Id = cboCuenta.Value).ToList
        If leCta.Count > 0 Then
            txtNombreCta.Value = leCta(0).Nombre
        End If
    End Sub

    Private Sub DecDebe_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecDebe.Validated
        DecMontoAn.Value = DecDebe.Value + DecHaber.Value
    End Sub

    Private Sub DecHaber_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecHaber.Validated
        DecMontoAn.Value = DecHaber.Value + DecDebe.Value
    End Sub

    Private Sub gridDetalleAsientoAnalisis_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_DetalleAsientoAnalisis.CellChange
        Try
            grid_DetalleAsientoAnalisis.UpdateData()
            Dim oeMovAna As New e_MovimientoAnalisis
            oeMovAna = grid_DetalleAsientoAnalisis.ActiveRow.ListObject
            If oeDetalleAsiento.Id.Trim <> "" Then
                oeMovAna.TipoOperacion = IIf(oeMovAna.Id.Trim <> "", "G", "I")
            Else
                oeMovAna.TipoOperacion = "I"
            End If
            oeMovAna.Saldo = oeMovAna.Monto
            Dim oedetalle As New List(Of e_MovimientoAnalisis)
            oedetalle = oeDetalleAsiento.MovimientoAnalisis.Where(Function(item) item.TipoOperacion <> "E").ToList
            Dim ln As Double = oedetalle.Sum(Function(item) item.Monto)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub EliminarDetalleDetalle_Click(sender As Object, e As EventArgs) Handles EliminarDetalleDetalle.Click
        QuitarMovimientoAnalisis()
    End Sub

    Private Sub btnBuscarDoc_Click(sender As Object, e As EventArgs) Handles btnBuscarDoc.Click
        Try
            'objDoc = New e_MovimientoDocumento
            Dim _frm As New frm_BuscarDocumento
            _frm.StartPosition = FormStartPosition.CenterScreen
            _frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
            If tabDocumentoDetalle.SelectedIndex = 0 Then
                If _frm.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                    oeMovimientoDocumento = _frm.oeDocumento
                    cmbTipoDoc.Value = oeMovimientoDocumento.IdTipoDocumento
                    FecEmision.Value = oeMovimientoDocumento.FechaEmision
                    FecVencimiento.Value = oeMovimientoDocumento.FechaVencimiento
                    txtNroSerie.Text = oeMovimientoDocumento.Serie
                    txtNroDoc.Text = oeMovimientoDocumento.Numero
                    cboCtaCte.Value = oeMovimientoDocumento.IdClienteProveedor
                End If
            Else
                IndCuentaCP = 0
                If _frm.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                    oeObligacionFin = _frm.oeObligacionFin
                    cboTipoObligacion.Text = oeObligacionFin.IdTipoObligacion
                    txtCodigoUnico.Text = oeObligacionFin.NroVencimiento
                    fecEmisionObligacion.Value = oeObligacionFin.FechaVencimiento
                    fecVencimientoObligacion.Value = oeObligacionFin.FechaVencimiento
                    cboBancoObligacion.Text = oeObligacionFin.Banco
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub DecDebe_ValueChanged_1(sender As Object, e As EventArgs) Handles DecDebe.ValueChanged
        If IsDBNull(DecDebe.Value) Then DecDebe.Value = 0
        If DecDebe.Value > 0 Then
            DecHaber.ReadOnly = True
            If oeCta.PartidaAnalisis = 0 Or oeCta.PartidaAnalisis = 1 Then CargarAnalisis()
        Else
            InicializaAnalisis(True) : DecHaber.ReadOnly = False
        End If
    End Sub

    Private Sub DecHaber_ValueChanged_1(sender As Object, e As EventArgs) Handles DecHaber.ValueChanged
        If IsDBNull(DecHaber.Value) Then DecHaber.Value = 0
        If DecHaber.Value > 0 Then
            DecDebe.ReadOnly = True
            If oeCta.PartidaAnalisis = 0 Or oeCta.PartidaAnalisis = 2 Then CargarAnalisis()
        Else
            InicializaAnalisis(True) : DecDebe.ReadOnly = False
        End If
    End Sub

#End Region

#End Region

End Class
