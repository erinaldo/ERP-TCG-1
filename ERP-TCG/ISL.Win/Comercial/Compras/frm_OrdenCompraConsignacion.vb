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

Public Class frm_OrdenCompraConsignacion

    Inherits ISL.Win.frm_MenuPadre

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_OrdenCompraConsignacion = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_OrdenCompraConsignacion()
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Declaración de variables"


    Dim olArea As New l_Area
    Dim oeArea As New e_Area
    Dim olUsuario As New l_Usuario
    Dim oeUsuario As New e_Usuario
    Dim oeIGV As New e_Impuesto
    Dim olIGV As New l_Impuesto

    Dim oeCentro As New e_Centro
    Dim olCentro As New l_Centro

    Dim oeAlmacen As New e_Almacen
    Dim olAlmacen As New l_Almacen


    '---------------Datos para OS------------------
    Dim oeOrdenSalida As New e_Orden
    Dim olOrdenSalida As New l_Orden
    Dim llOrdenSalida As New List(Of e_Orden)

    Dim oeDetalleOrdenSalida As New e_OrdenMaterial
    Dim olDetalleOrdenSalida As New l_OrdenMaterial
    Dim llDetalleOrdenSalida As New List(Of e_OrdenMaterial)
    '----------------------------------------------

    'Manejador de Tipo de Orden
    Dim oeTipoOrden As New e_TipoOrden
    Dim olTipoOrden As New l_TipoOrden

    Dim oeEstadoOrden As New e_EstadoOrden
    Dim olEstadoOrden As New l_EstadoOrden
    Dim llEstadoOrden As New List(Of e_EstadoOrden)


    Dim _ingresando_datos As Boolean = False
    Dim ds_OC_C As DataSet
    Dim relation As DataRelation
    Dim Monto As Double = 0

#End Region

#Region "BOTONES"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            ValidarFechaDesde_Hasta(rfOrdenCompraConsignacionDesde, rfOrdenCompraConsignacionHasta)
            ListarDetalleOrdenSalida(Activo)
            Tiempo1.Enabled = True
            If griDetalleOrdenSalida.Rows.Count > 0 Then
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
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
            If griDetalleOrdenSalida.Rows.Count = 0 Then Throw New Exception("No hay ninguna Orden de Compra a Consignación para exportar al Excel")
            Exportar_Excel(griDetalleOrdenSalida)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Métodos"

    Public Sub ListarDetalleOrdenSalida(ByVal Activo As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeDetalleOrdenSalida = New e_OrdenMaterial
            oeDetalleOrdenSalida.TipoOperacion = "A"
            oeDetalleOrdenSalida.Activo = Activo
            oeDetalleOrdenSalida.IdTipoOrden = ObtenerTipoOrden("ORDEN DE SALIDA")
            oeDetalleOrdenSalida.FechaInicio = rfOrdenCompraConsignacionDesde.Value
            oeDetalleOrdenSalida.FechaFin = rfOrdenCompraConsignacionHasta.Value
            oeDetalleOrdenSalida.IdAlmacen = cboAlmacen.Value
            oeDetalleOrdenSalida.IdEstadoOrden = ObtenerEstadoOrden("TERMINADA")
            Monto = 0
            If String.IsNullOrEmpty(oeDetalleOrdenSalida.IdAlmacen) Then Exit Sub
            ds_OC_C = olDetalleOrdenSalida.ListarParaOCC(oeDetalleOrdenSalida)
            Dim parentCol As DataColumn = ds_OC_C.Tables(0).Columns("IdMaterial")
            Dim childCol As DataColumn = ds_OC_C.Tables(1).Columns("IdMaterial")
            relation = New DataRelation("FK_Relacion", parentCol, childCol, True)
            ds_OC_C.Relations.Add(relation)
            ds_OC_C.AcceptChanges()
            With griDetalleOrdenSalida
                .DataSource = ds_OC_C
                For x As Integer = 0 To .Rows.Count - 1
                    .Rows(x).ExpandAll()
                Next
                'ocultar
                .DisplayLayout.Bands(1).Columns("Id").Hidden = True
                .DisplayLayout.Bands(1).Columns("IdMaterial").Hidden = True
                .DisplayLayout.Bands(1).Columns("Material").Hidden = True
                .DisplayLayout.Bands(1).Columns("IdOrden").Hidden = True
                .DisplayLayout.Bands(1).Columns("IdAlmacen").Hidden = True
                .DisplayLayout.Bands(1).Columns("IdSubAlmacen").Hidden = True
                .DisplayLayout.Bands(1).Columns("IndicadorIgv").Hidden = True
                .DisplayLayout.Bands(1).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(1).Columns("IdUnidadMedida").Hidden = True
                .DisplayLayout.Bands(0).Columns("UnidadMedida").Hidden = True
                .DisplayLayout.Bands(1).Columns("UnidadMedida").Hidden = True
                .DisplayLayout.Bands(1).Columns("IdTipoUnidadMedida").Hidden = True
                .DisplayLayout.Bands(1).Columns("CodigoMaterial").Hidden = True
                .DisplayLayout.Bands(0).Columns("Seleccion").Style = UltraWinGrid.ColumnStyle.CheckBox
                .DisplayLayout.Bands(1).Columns("Seleccion").Style = UltraWinGrid.ColumnStyle.CheckBox
                .DisplayLayout.Bands(0).Columns("CantidadMaterial").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(1).Columns("CantidadMaterial").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(1).Columns("PrecioUnitario").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(1).Columns("ValorVenta").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(1).Columns("ValorVenta").MaskInput = "{LOC}n,nnn,nnn,nnn.nnnn"
                .DisplayLayout.Bands(0).Columns("Atender").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("Importe").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(1).Columns("Seleccion").CellClickAction = UltraWinGrid.CellClickAction.Edit
                .DisplayLayout.Bands(0).ColHeadersVisible = True
                .DisplayLayout.Bands(1).ColHeadersVisible = False
                For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In .Rows
                    If fila.Cells("CantidadMaterial").Value = 0 Then
                        fila.Hidden = True
                    End If
                Next
            End With
        Catch ex As Exception
            Throw ex
        End Try
        griDetalleOrdenSalida.Focus()
    End Sub

    Public Function ObtenerTipoOrden(ByVal cad As String) As String
        Try
            oeTipoOrden = New e_TipoOrden
            oeTipoOrden.TipOoperacion = ""
            oeTipoOrden.Nombre = cad
            oeTipoOrden = olTipoOrden.Obtener(oeTipoOrden)
            Return oeTipoOrden.Id
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerEstadoOrden(ByVal cad As String) As String
        Try
            oeEstadoOrden = New e_EstadoOrden
            oeEstadoOrden.TipoOperacion = ""
            oeEstadoOrden.Nombre = cad
            oeEstadoOrden = olEstadoOrden.Obtener(oeEstadoOrden)
            Return oeEstadoOrden.Id
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Inicializar()
        Try
            oeCentro.Activo = True
            LlenarComboMaestro(cboCentro, olCentro.Listar(oeCentro), 0)
            oeCentro.TipoOperacion = "2"
            oeCentro.PrefijoID = gs_PrefijoIdSucursal '@0001
            oeCentro = olCentro.Obtener(oeCentro)
            cboCentro.Value = oeCentro.Id
            rfOrdenCompraConsignacionDesde.Value = Date.Now.AddDays(-7)
            rfOrdenCompraConsignacionHasta.Value = Date.Now
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Function ObtenerProveedor(ByVal lsIdAlmacen As String)
        oeAlmacen = New e_Almacen
        oeAlmacen.Id = lsIdAlmacen
        oeAlmacen.TipoOperacion = ""
        oeAlmacen = olAlmacen.Obtener(oeAlmacen)
        Return oeAlmacen.IdProveedor
    End Function

    Private Sub GenerarOC()
        Dim frm As New frm_OrdenCompra
        Dim ls_IdProveedor As String = ObtenerProveedor(cboAlmacen.Value)
        llDetalleOrdenSalida = New List(Of e_OrdenMaterial)
        Try
            If ds_OC_C Is Nothing Then Throw New Exception("Listar Datos.")
            For Each Row As DataRow In ds_OC_C.Tables(1).Rows
                If Row("Seleccion") = 1 Then
                    oeDetalleOrdenSalida = New e_OrdenMaterial
                    With oeDetalleOrdenSalida
                        .Seleccion = True
                        .CodigoMaterial = Row("CodigoMaterial")
                        .IdMaterial = Row("IdMaterial")
                        .Material = Row("Material")
                        .CantidadMaterial = Row("CantidadMaterial")
                        .PrecioUnitario = Row("PrecioUnitario")
                        .Id = Row("Id")
                        .IdTipoUnidadMedida = Row("IdTipoUnidadMedida")
                        .IdUnidadMedida = Row("IdUnidadMedida")
                        .UnidadMedida = Row("UnidadMedida")
                        .IdAlmacen = Row("IdAlmacen")
                        .Almacen = Row("Almacen")
                        .IdSubAlmacen = Row("IdSubAlmacen")
                        .PrefijoID = gs_PrefijoIdSucursal '@0001
                    End With
                    llDetalleOrdenSalida.Add(oeDetalleOrdenSalida)
                End If
            Next
            If llDetalleOrdenSalida.Count = 0 Then Throw New Exception("Seleccione Detalles.")
            frm = frm.getInstancia()
            With frm
                .MdiParent = frm_Menu
                .GenerarOCporOS(llDetalleOrdenSalida, ls_IdProveedor)
                .Show()
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_OrdenCompraConsignacion_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Select Case Operacion
            Case "Nuevo"
                Nuevo()
            Case "Editar"
                Editar()
            Case "Inicializa"
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                'Consultar(True)
            Case "Ayuda"
        End Select
    End Sub

    Private Sub frm_OrdenCompraConsignacion_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_OrdenCompraConsignacion_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub cboCentro_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCentro.ValueChanged
        Try
            oeAlmacen.IdCentro = cboCentro.Value
            oeAlmacen.TipoOperacion = "C"
            oeAlmacen.Activo = True
            LimpiaCombos(cboAlmacen)
            LlenarComboMaestro(cboAlmacen, olAlmacen.Listar(oeAlmacen), 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub frm_OrdenCompraConsignacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gmt_ConfigurarEventoKeyEnter_Tab(Me, cmdGenerarOrdenCompra.Name)
        gf_AsignarEventoSeleccionarTexto(Me)
        Inicializar()
    End Sub

    Private Sub cmdGenerarOrdenCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerarOrdenCompra.Click
        GenerarOC()
    End Sub

    Private Sub griDetalleOrdenSalida_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griDetalleOrdenSalida.CellChange
        Try
            With griDetalleOrdenSalida
                .UpdateData()
                Dim Cant As Double = 0
                Dim Importe As Double = 0
                Dim Importe2 As Double = 0
                If e.Cell.Column.Key.ToUpper = "SELECCION" Then
                    Select Case .ActiveRow.Band.Index
                        Case 0
                            Importe2 = .ActiveRow.Cells("Importe").Value
                            For Each Row As DataRow In ds_OC_C.Tables(1).Rows
                                If .ActiveRow.Cells("IdMaterial").Value = Row("IdMaterial") Then
                                    Row("Seleccion") = .ActiveRow.Cells("Seleccion").Value
                                    If .ActiveRow.Cells("Seleccion").Value = 1 Then
                                        Cant += Row("CantidadMaterial")
                                        Importe += Row("ValorVenta")
                                        Monto += Row("ValorVenta")
                                    End If
                                End If
                            Next
                            .ActiveRow.Cells("Atender").Value = Cant
                            .ActiveRow.Cells("Importe").Value = Importe
                            If .ActiveRow.Cells("Seleccion").Value = 0 Then
                                Monto -= Importe2
                            End If
                        Case 1
                            Dim cont As Integer = 0, cont2 As Integer = 0
                            For Each Row As DataRow In ds_OC_C.Tables(1).Rows
                                If .ActiveRow.Cells("IdMaterial").Value = Row("IdMaterial") Then
                                    If Row("Seleccion") = .ActiveRow.Cells("Seleccion").Value Then
                                        cont += 1
                                    End If
                                    cont2 += 1
                                End If
                            Next
                            Cant = .ActiveRow.ParentRow.Cells("Atender").Value
                            Importe = .ActiveRow.ParentRow.Cells("Importe").Value
                            If cont = cont2 Then
                                .ActiveRow.ParentRow.Cells("Seleccion").Value = .ActiveRow.Cells("Seleccion").Value
                                If .ActiveRow.Cells("Seleccion").Value = 0 Then
                                    Cant -= .ActiveRow.Cells("CantidadMaterial").Value
                                    Importe -= .ActiveRow.Cells("ValorVenta").Value
                                    Monto -= .ActiveRow.Cells("ValorVenta").Value
                                Else
                                    Cant += .ActiveRow.Cells("CantidadMaterial").Value
                                    Importe += .ActiveRow.Cells("ValorVenta").Value
                                    Monto += .ActiveRow.Cells("ValorVenta").Value
                                End If

                            Else
                                Cant = .ActiveRow.ParentRow.Cells("Atender").Value
                                Importe = .ActiveRow.ParentRow.Cells("Importe").Value
                                If .ActiveRow.Cells("Seleccion").Value = 0 Then
                                    .ActiveRow.ParentRow.Cells("Seleccion").Value = .ActiveRow.Cells("Seleccion").Value
                                    Cant -= .ActiveRow.Cells("CantidadMaterial").Value
                                    Importe -= .ActiveRow.Cells("ValorVenta").Value
                                    Monto -= .ActiveRow.Cells("ValorVenta").Value
                                Else
                                    Cant += .ActiveRow.Cells("CantidadMaterial").Value
                                    Importe += .ActiveRow.Cells("ValorVenta").Value
                                    Monto += .ActiveRow.Cells("ValorVenta").Value
                                End If
                            End If
                            .ActiveRow.ParentRow.Cells("Atender").Value = Cant
                            .ActiveRow.ParentRow.Cells("Importe").Value = Importe
                    End Select
                    .UpdateData()
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griDetalleOrdenSalida_AfterHeaderCheckStateChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterHeaderCheckStateChangedEventArgs) Handles griDetalleOrdenSalida.AfterHeaderCheckStateChanged
        Try
            Dim Total As Double = 0
            Dim CantAtender As Double = 0
            Dim TotalNodo As Double = 0
            For Each Row As DataRow In ds_OC_C.Tables(0).Rows
                CantAtender = 0
                TotalNodo = 0
                For Each Row2 As DataRow In Row.GetChildRows(relation)
                    Row2("Seleccion") = Row("Seleccion")
                    If Row2("Seleccion") = 1 Then
                        CantAtender += Row2("CantidadMaterial")
                        TotalNodo += Row2("ValorVenta")
                        Total += Row2("ValorVenta")
                    Else
                        CantAtender = 0
                        TotalNodo = 0
                        Total = 0
                    End If
                Next
                Row("Atender") = CantAtender
                Row("Importe") = TotalNodo
            Next
            griDetalleOrdenSalida.UpdateData()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GenerarStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarStripMenuItem1.Click
        GenerarOC()
    End Sub

    Private Sub griDetalleOrdenSalida_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griDetalleOrdenSalida.BeforeRowsDeleted
        e.Cancel = True
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    'Private Sub frm_OrdenCompraConsignacion_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
    '    InicializaTiempo()
    'End Sub
    'Private Sub griDetalleOrdenSalida_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griDetalleOrdenSalida.MouseMove
    '    If _tiempo <= 0 Then
    '        'ListarDetalleOrdenSalida(True)
    '    End If
    '    InicializaTiempo()
    'End Sub

#End Region

End Class
