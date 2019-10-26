'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF

Public Class frm_DocumentosXRendir
    Inherits frm_MenuPadre

#Region "Declaracion de Variables"

    '------variables para controlar detalles------------
    Private oeMovAnalisis As New e_MovimientoAnalisis
    Private leMovAnalisisAgrega As New List(Of e_MovimientoAnalisis)
    Private olMovAnalisis As New l_MovimientoAnalisis
    Private oeMD As New e_MovimientoAnalisis
    Private leMD As New List(Of e_MovimientoAnalisis)
    '--------------------------------------------------
    '---------Variable Cabecera---------------------
    Private oeDocumento As New e_MovimientoDocumento
    Private oeDocEjecuta As New e_MovimientoDocumento
    '-----------------------------------------------
    Private olAsiento As New l_Asiento
    Private oeItemGasto As New e_ItemGasto

    Private olImp As New l_Impuesto
    Private oeIGV As New e_Impuesto

    Private oePeriodo As New e_Periodo
    Private olPeriodo As New l_Periodo
    Private _ComboPeriodo As Boolean = False
    Private lePeriodo As New List(Of e_Periodo)

    Private Ejercicio As Integer

#End Region

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_DocumentosXRendir = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_DocumentosXRendir()
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
        Try
            CargarComprobante()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            ControlBoton(1, 0, 0, 1, 0, 0, 0, 1, 1)
        End Try
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
            If gridDetallePersonal.Rows.Count = 0 Then Throw New Exception("No hay ningún Documento por Rendir para exportar al Excel")
            Exportar_Excel(gridDetallePersonal)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Métodos"

    Private Sub CargarComprobante()
        Try
            If ValidarEjecutar() Then
                oeDocumento = New e_MovimientoDocumento
                oeDocumento.IdMoneda = cboMoneda.Value
                oeDocumento.IdPeriodo = cboMesDocumento.Value
                oeDocumento.FechaEmision = FecEmision.Value
                oeDocumento.TipoCambio = decTC.Value
                oeDocumento.Total = Math.Round(DecTotalDoc.Value, 2)
                oeDocumento.Saldo = Math.Round(DecTotalDoc.Value, 2)
                oeDocumento.NoGravado = DecNoGravada.Value

                oeDocumento.Compra.IdTipoCompra = oeItemGasto.Cuenta
                oeDocumento.TipoOperacion = "I"
                oeDocumento.IndCompraVenta = 1 'indica compra
                oeDocumento.IdUsuarioCrea = gUsuarioSGI.Id
                oeDocumento.Compra.AnoEmisionAduana = Date.Now.Year
                oeDocumento.IdPeriodo = cboMesAplicacion.Value
                oeDocumento.Ejercicio = Año1.Año
                oeDocumento.IndOrigenContable = 6

                Dim frm As New frm_ComprobanteCompra(oeDocumento, oeItemGasto, leMovAnalisisAgrega)
                'frm.FecEmision.Value = Date.Now
                frm.FecVencimiento.Value = Date.Now
                frm.MaximizeBox = False
                frm.MinimizeBox = False
                frm.WindowState = FormWindowState.Normal
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    ugb_Espera.Visible = True
                    Application.DoEvents()
                    Cursor.Current = Cursors.WaitCursor
                    Cursor.Show()
                    oeDocumento = frm.oeMovimientoDocumento
                    oeDocumento.Mac_PC_Local = MacPCLocal()
                    oeDocumento.EstadoDocumento = "ENVIADO"
                    Dim oeAsiento As New e_Asiento
                    With oeAsiento
                        .IdPeriodo = cboMesAplicacion.Value
                        .Fecha = FecAplicacion.Value
                        .IdMoneda = cboMoneda.Value
                        .TipoCambio = decTC.Value
                        .TotalDebe = DecTotalDoc.Value
                        .TotalHaber = DecTotalDoc.Value
                        .IdUsuarioCrea = gUsuarioSGI.Id
                        .IndOrigen = 17
                    End With
                    oeAsiento.PrefijoID = gs_PrefijoIdSucursal '@0001
                    oeDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
                    olAsiento.GuardarDocumentoxRendir(leMovAnalisisAgrega, oeAsiento, oeDocumento)
                    mensajeEmergente.Confirmacion("Se registro Correctamente", True)
                    leMovAnalisisAgrega = New List(Of e_MovimientoAnalisis)
                    GridAgregado.DataSource = leMovAnalisisAgrega
                    GridAgregado.DataBind()
                    Me.DecTotalImponible.Value = 0
                    Me.DecNoGravada.Value = 0
                    Listar()
                End If
                frm = Nothing
                oeDocumento = Nothing
            End If
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
            ControlBoton(1, 0, 0, 1, 0, 0, 0, 1, 1)
        End Try
        ControlBoton(1, 0, 0, 1, 0, 0, 0, 1, 1)
    End Sub

    Private Sub Listar()
        Try
            If GridAgregado.Rows.Count > 0 Then
                If MessageBox.Show("Existe Documentos agregados desea eliminarlos", "Mensaje del Sistema", _
               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
               = Windows.Forms.DialogResult.Yes Then
                    leMovAnalisisAgrega = New List(Of e_MovimientoAnalisis)
                    GridAgregado.DataSource = leMovAnalisisAgrega
                    r_Totales()
                Else
                    Exit Sub
                End If
            Else
                leMovAnalisisAgrega = New List(Of e_MovimientoAnalisis)
                GridAgregado.DataSource = leMovAnalisisAgrega
                r_Totales()
            End If
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeMD = New e_MovimientoAnalisis
            oeMD.Activo = True
            oeMD.Ejercicio = Año1.Año
            'oeMD.idp
            oeMD.TipoOperacion = "R"
            oeMD.IdPeriodo = cboMesDocumento.Value
            leMD = New List(Of e_MovimientoAnalisis)
            leMD.AddRange(olMovAnalisis.Listar(oeMD))
            gridDetallePersonal.DataSource = leMD
            gridDetallePersonal.DataBind()
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
        gridDetallePersonal.Focus()
    End Sub

    Private Sub LlenarCombos()
        ComboPerido()
        ComboMoneda()
        ComboItemGasto()
    End Sub

    Private Sub ComboMoneda()
        If cboMoneda.Items.Count = 0 Then
            Dim oeMoneda As New e_Moneda
            Dim olMoneda As New l_Moneda
            Dim leMoneda As New List(Of e_Moneda)
            oeMoneda.Activo = True
            leMoneda.AddRange(olMoneda.Listar(oeMoneda))
            '--------------------- para llenar combo en grilla    
            gridDetallePersonal.DisplayLayout.ValueLists.Add("IdMoneda")
            With gridDetallePersonal.DisplayLayout.ValueLists("IdMoneda").ValueListItems
                .Clear()
                For Each oeTD As e_Moneda In leMoneda
                    .Add(oeTD.Id, oeTD.Abreviatura)
                Next
            End With
            CrearComboGrid3("IdMoneda", "Abreviatura", gridDetallePersonal, True)
            '------------------------------------------
            '--------------------- para llenar combo en grilla    
            GridAgregado.DisplayLayout.ValueLists.Add("IdMoneda")
            With GridAgregado.DisplayLayout.ValueLists("IdMoneda").ValueListItems
                .Clear()
                For Each oeTD As e_Moneda In leMoneda
                    .Add(oeTD.Id, oeTD.Abreviatura)
                Next
            End With
            CrearComboGrid3("IdMoneda", "Abreviatura", GridAgregado, True)
            '------------------------------------------
            With cboMoneda
                .DisplayMember = "Nombre"
                .ValueMember = "Id"
                .DataSource = leMoneda
                If .Items.Count > 0 Then
                    .Value = "1CH01"
                End If
            End With
        End If
    End Sub

    Private Sub ComboPerido()
        Try
            If _ComboPeriodo = True Then
                oePeriodo = New e_Periodo
                Dim olPeriodo As New l_Periodo
                lePeriodo = New List(Of e_Periodo)
                oePeriodo.Ejercicio = Año1.Año
                oePeriodo.Activo = True
                lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))
                '--------------------- para llenar combo en grilla  
                If Not gridDetallePersonal.DisplayLayout.ValueLists.Exists("IdPeriodo") Then
                    gridDetallePersonal.DisplayLayout.ValueLists.Add("IdPeriodo")
                End If
                With gridDetallePersonal.DisplayLayout.ValueLists("IdPeriodo").ValueListItems
                    .Clear()
                    For Each oeTD As e_Periodo In lePeriodo
                        .Add(oeTD.Id, oeTD.Codigo)
                    Next
                End With
                CrearComboGrid3("IdPeriodo", "Codigo", gridDetallePersonal, True)
                '------------------------------------------
                '--------------------- para llenar combo en grilla    
                If Not GridAgregado.DisplayLayout.ValueLists.Exists("IdPeriodo") Then
                    GridAgregado.DisplayLayout.ValueLists.Add("IdPeriodo")
                End If
                With GridAgregado.DisplayLayout.ValueLists("IdPeriodo").ValueListItems
                    .Clear()
                    For Each oeTD As e_Periodo In lePeriodo
                        .Add(oeTD.Id, oeTD.Codigo)
                    Next
                End With
                CrearComboGrid3("IdPeriodo", "Codigo", GridAgregado, True)
                '------------------------------------------
                Dim lePeriodoAplicacion As New List(Of e_Periodo)
                lePeriodoAplicacion = lePeriodo.ToList
                With cboMesDocumento
                    .DisplayMember = "Mes"
                    .ValueMember = "Id"
                    .DataSource = lePeriodo
                End With
                With cboMesAplicacion
                    .DisplayMember = "Mes"
                    .ValueMember = "Id"
                    .DataSource = lePeriodoAplicacion
                End With
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub ComboItemGasto()
        Try
            If Ejercicio <> Date.Parse(FecEmision.Value).Date.Year Then
                Ejercicio = Date.Parse(FecEmision.Value).Date.Year
                Dim oeIG As New e_ItemGasto
                Dim olIG As New l_ItemGasto
                oeIG.Activo = True
                oeIG.Nombre = "659"
                oeIG.TipoOperacion = "L"
                oeIG.Ejercicio = Date.Parse(FecEmision.Value).Date.Year
                With cboItemGasto
                    .DisplayMember = "Nombre"
                    .ValueMember = "Id"
                    .DataSource = olIG.Listar(oeIG)
                End With
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function ValidarAgregarDetalle(ByVal oeMA As e_MovimientoAnalisis) As Boolean
        Try
            ValidarGrilla(gridDetallePersonal, "Documentos x Rendir")
            If gridDetallePersonal.ActiveRow Is Nothing Then Throw New Exception("Seleccione una fila")
            l_FuncionesGenerales.ValidarCampoNoNulo(gridDetallePersonal.ActiveRow.Cells("Id").Value.ToString, "Seleccione una fila")
            l_FuncionesGenerales.ValidarNumero(decTC.Value, "Tipo de cambio")
            If DecSinIgv.Value >= DecTotalImponible.Value + DecNoGravada.Value Then Throw New Exception("El Importe debe ser menor o igual al monto del documento")
            If oeMA.IdMoneda <> cboMoneda.Value Then Throw New Exception("Tiene que ser moneda soles")
            If oeMA.Saldo <= 0 Then Throw New Exception("Saldo mayor a cero")
            l_FuncionesGenerales.ValidarNumero(DecTotalDoc.Value, "Importe Doc")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ValidarEjecutar() As Boolean
        Try
            l_FuncionesGenerales.ValidarNumero(decTC.Value, "Tipo de cambio")
            If DecTotalImponible.Value + DecNoGravada.Value > Math.Round(DecSinIgv.Value, 2) Then Throw New Exception("El Importe es menor al monto a rendir")

            l_FuncionesGenerales.ValidarNumero(DecTotalDoc.Value, "Importe Doc")
            l_FuncionesGenerales.ValidarPeriodo(cboMesDocumento.Value, gAreasSGI.Contabilidad)
            l_FuncionesGenerales.ValidarPeriodo(cboMesAplicacion.Value, gAreasSGI.Contabilidad)
            ValidarPeriodoyFecha(cboMesAplicacion.Value, FecEmision.Value)
            ValidarPeriodoyFecha(cboMesAplicacion.Value, FecAplicacion.Value)

            If leMovAnalisisAgrega.Count = 0 Then Throw New Exception("Ingresa Documento x rendir")

            If leMovAnalisisAgrega.Item(0).IdMoneda <> cboMoneda.Value Then Throw New Exception("Tiene que ser moneda soles")

            ValidarCombo(cboMoneda, "Ingresa Moneda")
            ValidarCombo(cboItemGasto, "Ingresa ItemGasto")
            l_FuncionesGenerales.ValidarNumero(decTC.Value, "Tipo de Cambio")

            For Each obj As e_MovimientoAnalisis In leMovAnalisisAgrega
                If lePeriodo.Where(Function(ll) ll.Id = obj.IdPeriodo).ToList(0).Mes > cboMesDocumento.Text Then
                    Throw New Exception("Existen Documento a rendir con periodo mayor al documento Asiento:" & obj.NroAsiento)
                End If
            Next

            If Math.Round(Me.DecTotalImponible.Value + DecNoGravada.Value, 2) < Math.Round(Me.DecSinIgv.Value, 2) Then r_SaldarLinea()
            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub AgregarDetalle()
        Try

            If gridDetallePersonal.Rows.Count > 0 And Not gridDetallePersonal.ActiveRow.ListObject Is Nothing Then
                'Inicializo objeto
                oeMovAnalisis = New e_MovimientoAnalisis
                '---capturo datos a ingresar-----
                oeMovAnalisis = gridDetallePersonal.ActiveRow.ListObject
                oeMovAnalisis.TipoOperacion = "I"
                oeMovAnalisis.PrefijoID = gs_PrefijoIdSucursal '@0001
                '-----------------------
                If ValidarAgregarDetalle(oeMovAnalisis) Then
                    With leMovAnalisisAgrega
                        If Not .Contains(oeMovAnalisis) Then
                            oeMovAnalisis.SaldoSinIgv = oeMovAnalisis.Saldo / (1 + oeIGV.Porcentaje)
                            .Add(oeMovAnalisis.Clone)
                            .Item(.Count - 1).Monto = oeMovAnalisis.Saldo
                            GridAgregado.DataSource = leMovAnalisisAgrega
                            GridAgregado.DataBind()
                        Else
                            Throw New Exception("Ya existe este documento asociado")
                        End If
                    End With
                    r_Totales()
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarDetalle()
        Try
            If GridAgregado.Rows.Count > 0 Then
                ValidarGrilla(GridAgregado, "Documentos x Rendir agregados")
                If GridAgregado.ActiveRow.ListObject Is Nothing Then Throw New Exception("Seleccione una fila")
                l_FuncionesGenerales.ValidarCampoNoNulo(GridAgregado.ActiveRow.Cells("Id").Value.ToString, "Seleccione una fila")
                'inicialializo mi objeto
                oeMovAnalisis = New e_MovimientoAnalisis
                '---Obtengo O CAPTURO objeto de la grilla 
                oeMovAnalisis = GridAgregado.ActiveRow.ListObject
                '----------------------
                With leMovAnalisisAgrega
                    '-----remuevo o elimino de mi lista de objetos
                    .Remove(oeMovAnalisis)
                    '-------------------
                End With
                r_Totales()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub r_Totales()
        DecSinIgv.Value = leMovAnalisisAgrega.Sum(Function(ma As e_MovimientoAnalisis) ma.SaldoSinIgv)
        DecIGV.Value = DecSinIgv.Value * oeIGV.Porcentaje
        DecImporte.Value = DecSinIgv.Value + DecIGV.Value
        GridAgregado.DataBind()
    End Sub

    Private Sub r_SaldarLinea()
        Try
            Dim ln_SinIgv As Double = 0
            Dim ln_Saldo As Double = 0
            With leMovAnalisisAgrega
                ln_SinIgv = .Item(.Count - 1).SaldoSinIgv + _
                (Math.Abs(CDbl(DecTotalImponible.Value + DecNoGravada.Value)) - Math.Abs(CDbl(DecSinIgv.Value)))
                .Item(.Count - 1).SaldoSinIgv = ln_SinIgv
                ln_Saldo = ln_SinIgv + (ln_SinIgv - DecNoGravada.Value) * (oeIGV.Porcentaje)
                .Item(.Count - 1)._SaldoFinal = .Item(.Count - 1).Saldo - ln_Saldo
                .Item(.Count - 1).Saldo = ln_Saldo
                .Item(.Count - 1).Monto = ln_Saldo
            End With
            r_Totales
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub GastoFuncion()
        Try
            Dim oeTablaContableDet As New e_TablaContableDet
            Dim olTablaContableDet As New l_TablaContableDet
            Dim leTabla As New List(Of e_TablaContableDet)
            oeTablaContableDet.TipoOperacion = "N"
            oeTablaContableDet.Nombre = "GASTO FUNCION" 'Tipo de medio de pago
            oeTablaContableDet.Activo = True
            oeTablaContableDet.Logico2 = 1
            leTabla.AddRange(olTablaContableDet.Listar(oeTablaContableDet))
            '--------------------- para llenar combo en grilla    
            gridDetallePersonal.DisplayLayout.ValueLists.Add("IdGastoFuncion")
            With gridDetallePersonal.DisplayLayout.ValueLists("IdGastoFuncion").ValueListItems
                .Clear()
                For Each oeTD As e_TablaContableDet In leTabla
                    .Add(oeTD.Id, oeTD.Nombre)
                Next
            End With
            CrearComboGrid3("IdGastoFuncion", "Nombre", gridDetallePersonal, True)
            '------------------------------------------
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub Año1_DatoCambiado() Handles Año1.DatoCambiado
        ComboPerido()
    End Sub

    Private Sub frm_DocumentosXRendir_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(1, 0, 0, 1, 0, 0, 0, 1, 1)
    End Sub

    Private Sub frm_ComprobanteDiario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ComprobanteDiario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case _Operacion
            Case "Nuevo"
                Me.Activate()
                Me.Cancelar()
            Case "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_DocumentosXRendir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _ComboPeriodo = True
        LlenarCombos()
        GastoFuncion()
        oeIGV = olImp.IGV(Date.Now)
        leMovAnalisisAgrega = New List(Of e_MovimientoAnalisis)
        GridAgregado.DataSource = leMovAnalisisAgrega
        gridDetallePersonal.DataSource = leMD
        cboMesDocumento.Text = Date.Now.Month.ToString
        cboMesAplicacion.Text = Date.Now.Month.ToString
        cboMoneda.Text = "SOLES"
        cboMoneda.Enabled = False
        decTC.Value = TipoCambio(FecEmision.Value, True)(0)
    End Sub

    Private Sub FecEmision_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles FecEmision.Validated
        Try
            decTC.Value = TipoCambio(FecEmision.Value, True)(0)
            oeIGV = New e_Impuesto
            oeIGV = olImp.IGV(FecEmision.Value)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub AgregarCabecera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarCabecera.Click
        Try
            AgregarDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gridDetallePersonal_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridDetallePersonal.DoubleClick
        Try
            AgregarDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub EliminarAnalisis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarAnalisis.Click
        Try
            QuitarDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboItemGasto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboItemGasto.ValueChanged
        If cboItemGasto.SelectedIndex <> -1 Then
            Dim i As Integer = cboItemGasto.SelectedIndex
            oeItemGasto = New e_ItemGasto
            oeItemGasto = cboItemGasto.Items(i).ListObject
        End If
    End Sub

    Private Sub frm_DocumentosXRendir_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub DecTotalImponible_ValueChanged(sender As Object, e As EventArgs) Handles DecTotalImponible.ValueChanged
        DecTotalIgv.Value = DecTotalImponible.Value * oeIGV.Porcentaje
        DecTotalDoc.Value = DecTotalIgv.Value + DecTotalImponible.Value + DecNoGravada.Value
    End Sub

    Private Sub FecEmision_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecEmision.ValueChanged
        ComboItemGasto()
        FecAplicacion.Value = FecEmision.Value
        decTC.Value = TipoCambio(FecEmision.Value, True)(0)
    End Sub

    Private Sub DecNoGravada_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecNoGravada.ValueChanged
        DecTotalDoc.Value = DecTotalIgv.Value + DecTotalImponible.Value + DecNoGravada.Value
    End Sub

    Private Sub Año1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Año1.Validated
        ComboPerido()
    End Sub

    Private Sub cboMesDocumento_ValueChanged(sender As Object, e As EventArgs) Handles cboMesDocumento.ValueChanged
        cboMesAplicacion.Value = cboMesDocumento.Value
    End Sub

#End Region

End Class
