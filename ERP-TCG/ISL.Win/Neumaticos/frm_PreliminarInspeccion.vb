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
Imports Infragistics.Win.UltraWinDataSource
Imports Infragistics.Win.UltraWinGrid

Public Class frm_PreliminarInspeccion
    Inherits frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_PreliminarInspeccion = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_PreliminarInspeccion()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oePreliminarInsp As New e_PreliminarInspeccion
    Private olPreliminarInsp As New l_PreliminarInspeccion
    Private lePreliminarInsp As New List(Of e_PreliminarInspeccion)

    Private oeDetallePre As New e_DetallePreliminar
    Private olDetallePre As New l_DetallePreliminar
    Private leDetallePre As New List(Of e_DetallePreliminar)
    Private leDetPreGen As New List(Of e_DetallePreliminar)

    Private oeMarcaNeu As New e_Marca
    Private olMarcaNeu As New l_Marca
    Private leMarcaNeu As New List(Of e_Marca)

    Private oeTipoBanda As New e_Marca
    Private leTipoBanda As New List(Of e_Marca)

    Private oeMedidaNeu As New e_MedidaNeumatico
    Private olMedidaNeu As New l_MedidaNeumatico
    Private leMedidaNeu As New List(Of e_MedidaNeumatico)

    Private oeDisenoNeu As New e_DiseñoNeumatico
    Private olDisenoNeu As New l_DiseñoNeumatico
    Private leDisenoNeu As New List(Of e_DiseñoNeumatico)

    Private oeRequerimiento As New e_Requerimiento
    Private olRequerimiento As New l_Requerimiento
    Private oeReqMaterial As New e_RequerimientoMaterial

    Private BandLoad As Boolean = True
    Private BandUpdate As Boolean = True

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Select Case ficPreliminar.SelectedTab.Index
                Case 0
                    BandUpdate = True
                    oeDetallePre = New e_DetallePreliminar
                    oeDetallePre.TipoOperacion = "L"
                    oeDetallePre.Periodo = fecPeriodo.Value.Year.ToString & FormatoDocumento(fecPeriodo.Value.Month.ToString, 2)
                    leDetallePre = olDetallePre.Listar(oeDetallePre)
                    CargarPreliminar(leDetallePre)
                    If leDetPreGen.Count > 0 Then
                        If MessageBox.Show("Tiene Registros Seleccionados" & Environment.NewLine & _
                                           "¿Desea quitar todos los registros seleccionados?", "Mensaje de Sistema", _
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                            leDetPreGen = New List(Of e_DetallePreliminar)
                        Else
                            BandUpdate = False
                            For Each oeAux In leDetPreGen
                                For Each Fila In griPreliminarInsp.Rows
                                    If Fila.Cells("IdOperacionNeu").Value = oeAux.IdOperacionNeu Then
                                        Fila.Cells("Confirmado").Value = True
                                        Exit For
                                    End If
                                Next
                            Next
                            griPreliminarInsp.UpdateData()
                            BandUpdate = True
                        End If
                    End If
                    If griPreliminarInsp.Rows.Count > 0 Then
                        ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                    Else
                        ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                    End If
                Case 1
                    oePreliminarInsp = New e_PreliminarInspeccion
                    oePreliminarInsp.TipoOperacion = "L"
                    oePreliminarInsp.Anio = dtpPeriodoPreliminar.Value.Year
                    oePreliminarInsp.Mes = FormatoDocumento(dtpPeriodoPreliminar.Value.Month, 2)
                    lePreliminarInsp = olPreliminarInsp.Listar(oePreliminarInsp)
                    CargarPreNecesidades(lePreliminarInsp)
                    If griPreNecesidades.Rows.Count > 0 Then
                        ControlBoton(1, 0, 1, 0, 0, 1, 0, 1, 1)
                    Else
                        ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                    End If
                Case 3
                    BandUpdate = True
                    oeDetallePre = New e_DetallePreliminar
                    oeDetallePre.TipoOperacion = "L"
                    oeDetallePre.Periodo = fecPeriodo.Value.Year.ToString & FormatoDocumento(fecPeriodo.Value.Month.ToString, 2)
                    leDetallePre = olDetallePre.Listar(oeDetallePre)
                    CargarConfiguracion(leDetallePre)
                    If griConfiguracionMedida.Rows.Count > 0 Then
                        ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                    Else
                        ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                    End If
            End Select

        Catch ex As Exception
            mensajeEmergente.Confirmacion(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If MessageBox.Show("¿Desea Guardar los Cambios Realizados?", "Mensaje de Sistema", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                oePreliminarInsp.TipoOperacion = "A"
                oePreliminarInsp.PrefijoID = gs_PrefijoIdSucursal '@0001
                olPreliminarInsp.Guardar(oePreliminarInsp)
                mensajeEmergente.Confirmacion("Los Datos se Guardaron Correctamente", True)
            End If

            ficPreliminar.Tabs(0).Enabled = True
            ficPreliminar.Tabs(1).Enabled = True
            ficPreliminar.Tabs(2).Enabled = False
            ficPreliminar.SelectedTab = ficPreliminar.Tabs(1)

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            oePreliminarInsp = New e_PreliminarInspeccion
            oePreliminarInsp.Id = griPreNecesidades.ActiveRow.Cells("Id").Value
            oePreliminarInsp.Activo = True
            oePreliminarInsp.TipoOperacion = "N"
            oePreliminarInsp = olPreliminarInsp.Obtener(oePreliminarInsp)
            CargarDetallePre(oePreliminarInsp.leDetallePre)
            If oePreliminarInsp.Estado = "GENERADA" Then
                griDetallePre.DisplayLayout.Bands(0).Columns("Confirmado").Hidden = True
                griDetallePre.DisplayLayout.Bands(0).Columns("Confirmado").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
            Else
                griDetallePre.DisplayLayout.Bands(0).Columns("Confirmado").Hidden = False
                griDetallePre.DisplayLayout.Bands(0).Columns("Confirmado").ExcludeFromColumnChooser = ExcludeFromColumnChooser.False
            End If
            ficPreliminar.Tabs(0).Enabled = False
            ficPreliminar.Tabs(1).Enabled = False
            ficPreliminar.Tabs(2).Enabled = True
            ficPreliminar.SelectedTab = ficPreliminar.Tabs(2)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            ficPreliminar.Tabs(0).Enabled = True
            ficPreliminar.Tabs(1).Enabled = True
            ficPreliminar.Tabs(2).Enabled = False
            ficPreliminar.SelectedTab = ficPreliminar.Tabs(1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            Select Case ficPreliminar.SelectedTab.Index
                Case 0
                    If griPreliminarInsp.Rows.Count > 0 Then
                        Exportar_Excel(griPreliminarInsp)
                    Else
                        Throw New Exception("No Hay Registros para Exportar")
                    End If
                Case 1
                    If griPreNecesidades.Rows.Count > 0 Then
                        Exportar_Excel(griPreNecesidades)
                    Else
                        Throw New Exception("No Hay Registros para Exportar")
                    End If
                Case 2
                    If griDetallePre.Rows.Count > 0 Then
                        Exportar_Excel(griDetallePre)
                    Else
                        Throw New Exception("No Hay Registros para Exportar")
                    End If
                Case 3
                    If griConfiguracionMedida.Rows.Count > 0 Then
                        Exportar_Excel(griConfiguracionMedida)
                    Else
                        Throw New Exception("No Hay Registros para Exportar")
                    End If
                Case 4
                    If griDetalleConfig.Rows.Count > 0 Then
                        Exportar_Excel(griDetalleConfig)
                    Else
                        Throw New Exception("No Hay Registros para Exportar")
                    End If
            End Select

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_PreliminarInspeccion_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case ficPreliminar.SelectedTab.Index
            Case 0
                If griPreliminarInsp.Rows.Count > 0 Then
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                Else
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                End If
            Case 1
                If griPreNecesidades.Rows.Count > 0 Then
                    ControlBoton(1, 0, 1, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                End If
            Case 2
                If griDetallePre.Rows.Count > 0 Then
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
                Else
                    ControlBoton(0, 0, 0, 0, 1, 0, 0, 1, 0)
                End If

        End Select
    End Sub

    Private Sub frm_PreliminarInspeccion_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_PreliminarInspeccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            colorBueno.Color = Color.LightGreen
            ColorRegular.Color = Color.Gold
            colorMalo.Color = Color.LightCoral
            colorGenerada.Color = Color.White
            colorEnviado.Color = Color.Gold
            colorTerminado.Color = Color.LightGreen
            fecPeriodo.Value = Convert.ToDateTime("01/" & Date.Now.Month.ToString & "/" & Date.Now.Year.ToString)
            dtpPeriodoPreliminar.Value = Convert.ToDateTime("01/" & Date.Now.Month.ToString & "/" & Date.Now.Year.ToString)
            CargarCombos()
            CargarPreliminar(New List(Of e_DetallePreliminar))
            CargarPreNecesidades(New List(Of e_PreliminarInspeccion))
            CargarDetallePre(New List(Of e_DetallePreliminar))
            CargarGrillaConfiguracionMedida(New List(Of e_Vehiculo))
            CargarGrillaDetalleConfiguracion(New List(Of e_DetallePreliminar))
            If griPreliminarInsp.Rows.Count > 0 Then
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
            Else
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            End If
            ficPreliminar.Tabs(0).Enabled = True
            ficPreliminar.Tabs(1).Enabled = True
            ficPreliminar.Tabs(2).Enabled = False
            ficPreliminar.SelectedTab = ficPreliminar.Tabs(0)
            BandLoad = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    'Private Sub griPreliminarInsp_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griPreliminarInsp.AfterCellUpdate
    '    Try
    '        'griPreliminarInsp.UpdateData()
    '        Select Case e.Cell.Column.Key
    '            Case "MarcaRecomendada"
    '                Dim _leMedAux = leMedidaNeu.Where(Function(it) it.UsuarioCreacion = griPreliminarInsp.ActiveRow.Cells("MarcaRecomendada").Value.ToString).OrderBy(Function(it) it.Nombre).ToList
    '                With griPreliminarInsp.DisplayLayout
    '                    .ValueLists.Clear()
    '                    .ValueLists.Add("MedidaRecomendada")
    '                    With .ValueLists("MedidaRecomendada").ValueListItems
    '                        .Clear()
    '                        For Each oeMod In _leMedAux
    '                            .Add(oeMod.Id, oeMod.Nombre)
    '                        Next
    '                    End With
    '                    .Bands(0).Columns("MedidaRecomendada").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
    '                    '.Bands(0).Columns("ModeloRecomendada").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDown
    '                    griPreliminarInsp.ActiveRow.Cells("MedidaRecomendada").ValueList = .ValueLists("MedidaRecomendada")
    '                    '.ValueLists("MedidaRecomendada").SelectedIndex = 0
    '                    .ValueLists("MedidaRecomendada").MaxDropDownItems = 20
    '                    griPreliminarInsp.ActiveRow.Cells("MedidaRecomendada").Value = _leMedAux(0).Id
    '                End With
    '            Case "MedidaRecomendada"
    '                Dim _leDisAux = leDisenoNeu.Where(Function(it) it.IdMarca = griPreliminarInsp.ActiveRow.Cells("MarcaRecomendada").Value _
    '                                                     And it.IdMedidaNeumatico = griPreliminarInsp.ActiveRow.Cells("MedidaRecomendada").Value).OrderBy(Function(it) it.Nombre).ToList
    '                With griPreliminarInsp.DisplayLayout
    '                    .ValueLists.Clear()
    '                    .ValueLists.Add("ModeloRecomendada")
    '                    With .ValueLists("ModeloRecomendada").ValueListItems
    '                        .Clear()
    '                        For Each oeDis In _leDisAux
    '                            .Add(oeDis.Id, oeDis.Nombre)
    '                        Next
    '                    End With
    '                    .Bands(0).Columns("ModeloRecomendada").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
    '                    '.Bands(0).Columns("ModeloRecomendada").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDown
    '                    griPreliminarInsp.ActiveRow.Cells("ModeloRecomendada").ValueList = .ValueLists("ModeloRecomendada")
    '                    .ValueLists("ModeloRecomendada").MaxDropDownItems = 20
    '                    griPreliminarInsp.ActiveRow.Cells("ModeloRecomendada").Value = _leDisAux(0).Id

    '                End With
    '                'Case "Observacion"
    '                '    If String.IsNullOrEmpty(e.Cell.Value) Then e.Cell.Value = String.Empty
    '        End Select

    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    End Try

    'End Sub

    Private Sub griPreliminarInsp_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griPreliminarInsp.CellChange
        Try
            With griPreliminarInsp
                .UpdateData()
                If BandUpdate AndAlso .ActiveRow.Index > -1 Then
                    oeDetallePre = New e_DetallePreliminar
                    oeDetallePre.IdVidaNeumatico = .ActiveRow.Cells("IdVidaNeumatico").Value
                    If .ActiveRow.Cells("Confirmado").Value Then
                        If leDetPreGen.Contains(oeDetallePre) Then
                            .ActiveRow.Cells("Confirmado").Value = False
                            Throw New Exception("El Neumatico: " & .ActiveRow.Cells("CodNeumatico").Value & " ya ha sido Seleccionado")
                        Else
                            Dim _leAux = leDetallePre.Where(Function(it) it.IdVidaNeumatico = .ActiveRow.Cells("IdVidaNeumatico").Value).ToList
                            If _leAux.Count > 0 Then
                                _leAux(0).UsuarioCreacion = gUsuarioSGI.Id
                                leDetPreGen.Add(_leAux(0))
                            End If
                        End If
                    Else
                        If leDetPreGen.Contains(oeDetallePre) Then
                            leDetPreGen.Remove(oeDetallePre)
                        End If
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    'Private Sub griPreliminarInsp_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles griPreliminarInsp.BeforeCellUpdate
    '    Try
    '        Select Case e.Cell.Column.Key
    '            Case "Observacion"
    '                If IsDBNull(e.NewValue) Then
    '                    e.Cancel = True
    '                    e.Cell.Value = String.Empty
    '                    Exit Sub
    '                End If
    '        End Select
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    End Try
    'End Sub

    'Private Sub griPreliminarInsp_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griPreliminarInsp.InitializeLayout
    '    e.Layout.Bands(0).Columns("Observacion").Nullable = Nullable.Nothing
    'End Sub

    Private Sub ficPreliminar_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles ficPreliminar.SelectedTabChanged
        Select Case e.Tab.Index
            Case 0
                If griPreliminarInsp.Rows.Count > 0 Then
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
                Else
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                End If
            Case 1
                If griPreNecesidades.Rows.Count > 0 Then
                    ControlBoton(1, 0, 1, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                End If
            Case 2
        End Select
    End Sub

    Private Sub mnuPreliminar_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mnuPreliminar.Opening
        Select Case ficPreliminar.SelectedTab.Index
            Case 0
                mnuPreliminar.Items("tsmiGenerar").Visible = True
                mnuPreliminar.Items("tsmiEditar").Visible = False
                mnuPreliminar.Items("tsmiEliminar").Visible = False
                mnuPreliminar.Items("tsmiEnviar").Visible = False
                mnuPreliminar.Items("tsmiTerminar").Visible = False
                If leDetPreGen.Count > 0 Then
                    mnuPreliminar.Items("tsmiGenerar").Enabled = True
                Else
                    mnuPreliminar.Items("tsmiGenerar").Enabled = False
                End If
            Case 1
                mnuPreliminar.Items("tsmiGenerar").Visible = False
                mnuPreliminar.Items("tsmiEditar").Visible = True
                mnuPreliminar.Items("tsmiEliminar").Visible = True
                mnuPreliminar.Items("tsmiEnviar").Visible = True
                mnuPreliminar.Items("tsmiTerminar").Visible = True
            Case 2
                mnuPreliminar.Items("tsmiGenerar").Visible = False
                mnuPreliminar.Items("tsmiEditar").Visible = False
                mnuPreliminar.Items("tsmiEliminar").Visible = False
                mnuPreliminar.Items("tsmiEnviar").Visible = False
                mnuPreliminar.Items("tsmiTerminar").Visible = False
        End Select
    End Sub

    Private Sub tsmiGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiGenerar.Click
        Try
            oePreliminarInsp = New e_PreliminarInspeccion
            oePreliminarInsp.TipoOperacion = "L"
            oePreliminarInsp.Anio = fecPeriodo.Value.Year
            oePreliminarInsp.Mes = FormatoDocumento(fecPeriodo.Value.Month.ToString, 2)
            oePreliminarInsp = olPreliminarInsp.Obtener(oePreliminarInsp)
            If oePreliminarInsp.Id <> "" AndAlso oePreliminarInsp.Estado = "GENERADO" Then
                If MessageBox.Show("En este Periodo se encuentra Generado un Preliminar" & _
                                   "¿Desea Adicionar los Neumaticos a este Preliminar?", _
                                   "Mensaje de Sistema", MessageBoxButtons.YesNo, _
                                   MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then

                    oePreliminarInsp.TipoOperacion = "A"
                    oePreliminarInsp.leDetallePre.AddRange(leDetPreGen)
                    oePreliminarInsp.PrefijoID = gs_PrefijoIdSucursal '@0001
                    olPreliminarInsp.Guardar(oePreliminarInsp)

                    mensajeEmergente.Confirmacion("Los Datos se Actualizaron Correctamente", True)

                    leDetPreGen = New List(Of e_DetallePreliminar)
                    Consultar(True)

                End If

            Else
                If MessageBox.Show("¿Desa Generar un Registro Preliminar de Necesidades?", "Mensaje del Sistema", _
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then

                    oePreliminarInsp = New e_PreliminarInspeccion
                    oePreliminarInsp.TipoOperacion = "U"
                    oePreliminarInsp = olPreliminarInsp.Obtener(oePreliminarInsp)
                    Dim CodPI As String = String.Empty
                    CodPI = oePreliminarInsp.Codigo
                    oePreliminarInsp = New e_PreliminarInspeccion
                    oePreliminarInsp.TipoOperacion = "I"
                    oePreliminarInsp.UsuarioCreacion = gUsuarioSGI.Id
                    oePreliminarInsp.Codigo = CodPI
                    oePreliminarInsp.Periodo = fecPeriodo.Value.Year.ToString & FormatoDocumento(fecPeriodo.Value.Month.ToString, 2)
                    oePreliminarInsp.IdEstado = "1CH00014"
                    oePreliminarInsp.leDetallePre = leDetPreGen
                    oePreliminarInsp.PrefijoID = gs_PrefijoIdSucursal '@0001
                    olPreliminarInsp.Guardar(oePreliminarInsp)

                    mensajeEmergente.Confirmacion("Los Datos se Guardaron Correctamente", True)

                    leDetPreGen = New List(Of e_DetallePreliminar)
                    Consultar(True)

                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEditar.Click
        Editar()
    End Sub

    Private Sub griDetallePre_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles griDetallePre.BeforeCellUpdate
        Try
            Select Case e.Cell.Column.Key
                Case "Observacion"
                    If IsDBNull(e.NewValue) Then
                        e.Cancel = True
                        e.Cell.Value = String.Empty
                        Exit Sub
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDetallePre_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griDetallePre.InitializeLayout
        e.Layout.Bands(0).Columns("Observacion").Nullable = Nullable.Nothing
    End Sub

    Private Sub griDetallePre_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griDetallePre.CellChange
        griDetallePre.UpdateData()
    End Sub

    Private Sub griDetallePre_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griDetallePre.AfterCellUpdate
        Try
            'griPreliminarInsp.UpdateData()
            Select Case e.Cell.Column.Key
                Case "MarcaRecomendada"
                    Dim _leMedAux = leMedidaNeu.Where(Function(it) it.UsuarioCreacion = griPreliminarInsp.ActiveRow.Cells("MarcaRecomendada").Value.ToString).OrderBy(Function(it) it.Nombre).ToList
                    With griPreliminarInsp.DisplayLayout
                        .ValueLists.Clear()
                        .ValueLists.Add("MedidaRecomendada")
                        With .ValueLists("MedidaRecomendada").ValueListItems
                            .Clear()
                            For Each oeMod In _leMedAux
                                .Add(oeMod.Id, oeMod.Nombre)
                            Next
                        End With
                        .Bands(0).Columns("MedidaRecomendada").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
                        '.Bands(0).Columns("ModeloRecomendada").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDown
                        griPreliminarInsp.ActiveRow.Cells("MedidaRecomendada").ValueList = .ValueLists("MedidaRecomendada")
                        '.ValueLists("MedidaRecomendada").SelectedIndex = 0
                        .ValueLists("MedidaRecomendada").MaxDropDownItems = 20
                        griPreliminarInsp.ActiveRow.Cells("MedidaRecomendada").Value = _leMedAux(0).Id
                    End With
                Case "MedidaRecomendada"
                    Dim _leDisAux = leDisenoNeu.Where(Function(it) it.IdMarca = griPreliminarInsp.ActiveRow.Cells("MarcaRecomendada").Value _
                                                         And it.IdMedidaNeumatico = griPreliminarInsp.ActiveRow.Cells("MedidaRecomendada").Value).OrderBy(Function(it) it.Nombre).ToList
                    With griPreliminarInsp.DisplayLayout
                        .ValueLists.Clear()
                        .ValueLists.Add("ModeloRecomendada")
                        With .ValueLists("ModeloRecomendada").ValueListItems
                            .Clear()
                            For Each oeDis In _leDisAux
                                .Add(oeDis.Id, oeDis.Nombre)
                            Next
                        End With
                        .Bands(0).Columns("ModeloRecomendada").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
                        '.Bands(0).Columns("ModeloRecomendada").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDown
                        griPreliminarInsp.ActiveRow.Cells("ModeloRecomendada").ValueList = .ValueLists("ModeloRecomendada")
                        .ValueLists("ModeloRecomendada").MaxDropDownItems = 20
                        griPreliminarInsp.ActiveRow.Cells("ModeloRecomendada").Value = _leDisAux(0).Id

                    End With
                    'Case "Observacion"
                    '    If String.IsNullOrEmpty(e.Cell.Value) Then e.Cell.Value = String.Empty
            End Select

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub griPreNecesidades_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griPreNecesidades.DoubleClick
        If griPreNecesidades.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub tsmiEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEnviar.Click
        Try
            oePreliminarInsp = New e_PreliminarInspeccion
            oePreliminarInsp.Id = griPreNecesidades.ActiveRow.Cells("Id").Value
            oePreliminarInsp.Activo = True
            oePreliminarInsp.TipoOperacion = "N"
            oePreliminarInsp = olPreliminarInsp.Obtener(oePreliminarInsp)
            If oePreliminarInsp.Estado = "GENERADA" Then
                If oePreliminarInsp.leDetallePre.Count > 0 Then
                    Dim _leDetVal = oePreliminarInsp.leDetallePre.Where(Function(it) it.IdMaterial.ToString.Trim = "").ToList
                    If _leDetVal.Count > 0 Then
                        Dim _lsMensaje As String = ""
                        Dim _idDisVal As String = ""
                        Dim _leValAux = _leDetVal.OrderBy(Function(it) it.IdDisenioPedido).ToList
                        For Each _oeval In _leValAux
                            If _idDisVal <> _oeval.IdDisenioPedido Then
                                _idDisVal = _oeval.IdDisenioPedido
                                Dim _leDis2 = leDisenoNeu.Where(Function(it) it.Id = _idDisVal).ToList
                                If _leDis2.Count > 0 Then
                                    Dim NombreDis = _leDis2(0).Marca & " " & _leDis2(0).Nombre & " " & _leDis2(0).MedidaNeumatico & " " & _oeval.TipoBandaPedido
                                    _lsMensaje = _lsMensaje & "LLANTA " & NombreDis & Environment.NewLine
                                End If
                            End If
                        Next
                        Throw New Exception("Falta Registrar los Siguientes Materiales: " & Environment.NewLine & _lsMensaje)
                    Else
                        oePreliminarInsp.TipoOperacion = "R"
                        oeRequerimiento = New e_Requerimiento
                        oeRequerimiento.TipoOperacion = "I"
                        oeRequerimiento.IdArea = "1CH000000016"
                        oeRequerimiento.IdEstadoRequerimiento = "1CH000000001"
                        oeRequerimiento.MaterialServicio = "M"
                        oeRequerimiento.UsuarioCreacion = gUsuarioSGI.Id
                        oeRequerimiento.GlosaAtencion = String.Empty
                        oeRequerimiento.FechaAtencion = Date.Now
                        oeRequerimiento.Activo = True
                        Dim _leDetAux = oePreliminarInsp.leDetallePre.OrderBy(Function(it) it.IdMaterial).ToList
                        Dim _idmat As String = ""
                        For Each oeDetAux In _leDetAux
                            If _idmat <> oeDetAux.IdMaterial Then
                                oeReqMaterial = New e_RequerimientoMaterial
                                oeReqMaterial.IdEstadoRequerimientoMaterial = "1CH000000006"
                                _idmat = oeDetAux.IdMaterial
                                Dim _leAux = _leDetAux.Where(Function(it) it.IdMaterial = _idmat).ToList
                                oeReqMaterial.IdMaterial = _idmat
                                oeReqMaterial.Cantidad = _leAux.Count
                                oeReqMaterial.CantidadPorAtender = _leAux.Count
                                oeReqMaterial.IndRegularizado = True
                                oeReqMaterial.CantidadPorRegularizar = 0
                                oeReqMaterial.CentroCosto = String.Empty
                                oeReqMaterial.Glosa = String.Empty
                                oeReqMaterial.IdMantenimiento = String.Empty
                                oeReqMaterial.UsuarioCreacion = gUsuarioSGI.Id
                                oeReqMaterial.IdSubAlmacen = "1CH000000002"
                                oeReqMaterial.IdUnidadMedida = "1PY000000011"
                                oeRequerimiento.lstRequerimientoMaterial.Add(oeReqMaterial)
                            End If
                        Next
                    End If
                    oePreliminarInsp.oeRequerimiento = oeRequerimiento
                    olPreliminarInsp.Enviar(oePreliminarInsp)
                    Consultar(True)
                    mensajeEmergente.Confirmacion("Se Envio Correctamente el Registro Preliminar de Necesidades!!", True)
                End If
            Else
                Throw New Exception("El Registro Preliminar de Necesidades esta en Estado: " & oePreliminarInsp.Estado)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiTerminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiTerminar.Click
        Try
            oePreliminarInsp = New e_PreliminarInspeccion
            oePreliminarInsp.Id = griPreNecesidades.ActiveRow.Cells("Id").Value
            oePreliminarInsp.Activo = True
            oePreliminarInsp.TipoOperacion = "L"
            oePreliminarInsp = olPreliminarInsp.Obtener(oePreliminarInsp)
            If oePreliminarInsp.Estado = "ENVIADO" Then
                Dim _leAux = oePreliminarInsp.leDetallePre.Where(Function(it) it.Confirmado = 0).ToList
                If _leAux.Count > 0 Then
                    Throw New Exception("Debe Confirmar todos los Registros del Reporte")
                Else
                    oePreliminarInsp.TipoOperacion = "T"
                    oePreliminarInsp.PrefijoID = gs_PrefijoIdSucursal '@0001
                    olPreliminarInsp.Guardar(oePreliminarInsp)
                    mensajeEmergente.Problema("Se ha Terminado el Registro Preliminar")
                End If
            Else
                Throw New Exception("El Registro Preliminar de Necesidades esta en Estado: " & oePreliminarInsp.Estado)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboEstadoBus_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEstadoBus.ValueChanged
        Try
            If leDetallePre.Count > 0 Then CargarPreliminar(leDetallePre)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombos()
        Try

            cboEstadoBus.Items.Clear()
            cboEstadoBus.Items.Add("TODOS")
            cboEstadoBus.Items.Add("BUENO")
            cboEstadoBus.Items.Add("REGULAR")
            cboEstadoBus.Items.Add("MALO")
            cboEstadoBus.SelectedIndex = 0

            oeMarcaNeu = New e_Marca
            oeMarcaNeu.TipoOperacion = "N"
            leMarcaNeu = olMarcaNeu.Listar(oeMarcaNeu)
            'LlenarCombo(cboMarcaNeu, "Nombre", leMarcaNeu, -1)

            oeMedidaNeu = New e_MedidaNeumatico
            oeMedidaNeu.TipoOperacion = "N"
            leMedidaNeu = olMedidaNeu.Listar(oeMedidaNeu)

            oeDisenoNeu = New e_DiseñoNeumatico
            oeDisenoNeu.TipoOperacion = ""
            oeDisenoNeu.Activo = True
            leDisenoNeu = olDisenoNeu.Listar(oeDisenoNeu)

            oeTipoBanda = New e_Marca
            oeTipoBanda.Id = "DIRECCIONAL"
            oeTipoBanda.Nombre = "DIRECCIONAL"
            leTipoBanda.Add(oeTipoBanda)
            oeTipoBanda = New e_Marca
            oeTipoBanda.Id = "TRACCION"
            oeTipoBanda.Nombre = "TRACCION"
            leTipoBanda.Add(oeTipoBanda)
            oeTipoBanda = New e_Marca
            oeTipoBanda.Id = "MIXTA"
            oeTipoBanda.Nombre = "MIXTA"
            leTipoBanda.Add(oeTipoBanda)
            oeTipoBanda = New e_Marca
            oeTipoBanda.Id = "PISTERA"
            oeTipoBanda.Nombre = "PISTERA"
            leTipoBanda.Add(oeTipoBanda)

            'cboTipoBanda.Items.Clear()
            'cboTipoBanda.Items.Add(0, "DIRECCIONAL")
            'cboTipoBanda.Items.Add(1, "TRACCION")
            'cboTipoBanda.Items.Add(2, "MIXTA")
            'cboTipoBanda.SelectedIndex = -1

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarCombo_Grilla()
        Try
            'Para Columna de Moneda
            griDetallePre.DisplayLayout.ValueLists.Add("MarcaRecomendada")
            With griDetallePre.DisplayLayout.ValueLists("MarcaRecomendada").ValueListItems
                .Clear()
                For Each oeMarAux In leMarcaNeu
                    .Add(oeMarAux.Id, oeMarAux.Nombre)
                Next
            End With
            CrearComboGrid3("MarcaRecomendada", "Nombre", griDetallePre, True)

            'Para Columna Tipo Banda Pedido
            griDetallePre.DisplayLayout.ValueLists.Add("TipoBandaPedido")
            With griDetallePre.DisplayLayout.ValueLists("TipoBandaPedido").ValueListItems
                .Clear()
                For Each oeTBAux In leTipoBanda
                    .Add(oeTBAux.Id, oeTBAux.Nombre)
                Next
            End With
            CrearComboGrid3("TipoBandaPedido", "Nombre", griDetallePre, True)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarPreliminar(ByVal leDetPreliminar As List(Of e_DetallePreliminar))
        Try
            With griPreliminarInsp

                If BandLoad Then .ResetDisplayLayout()

                Dim _leAux As New List(Of e_DetallePreliminar)
                Select Case cboEstadoBus.SelectedIndex
                    Case 0 : _leAux.AddRange(leDetPreliminar)
                    Case 1 : _leAux = leDetPreliminar.Where(Function(it) it.IndColor > 1).ToList
                    Case 2 : _leAux = leDetPreliminar.Where(Function(it) it.IndColor > -1 And it.IndColor < 2).ToList
                    Case 3 : _leAux = leDetPreliminar.Where(Function(it) it.IndColor <= -1).ToList
                End Select

                .DataSource = _leAux

                If BandLoad Then

                    For Each col In .DisplayLayout.Bands(0).Columns
                        If col.Key = "Confirmado" Then
                            col.CellActivation = Activation.AllowEdit : col.CellClickAction = CellClickAction.EditAndSelectText
                        Else
                            col.CellActivation = Activation.NoEdit : col.CellClickAction = CellClickAction.RowSelect
                        End If
                    Next

                    OcultarColumna(griPreliminarInsp, True, "Id", "IdPreliminarInspeccion", "IdOperacionNeu", "CodOperacion", "FechaCreacion", "UsuarioCreacion", _
                                   "Activo", "MarcaRecomendada", "MedidaRecomendada", "IdDisenioPedido", "Observacion", "IdVidaNeumatico", "TipoBandaPedido", _
                                   "IdMaterial", "IndColor")

                    .DisplayLayout.Bands(0).Columns("Confirmado").Header.VisiblePosition = 0
                    .DisplayLayout.Bands(0).Columns("Centro").Header.VisiblePosition = 1
                    .DisplayLayout.Bands(0).Columns("Flota").Header.VisiblePosition = 2
                    .DisplayLayout.Bands(0).Columns("Tipo").Header.VisiblePosition = 3
                    .DisplayLayout.Bands(0).Columns("Placa").Header.VisiblePosition = 4
                    .DisplayLayout.Bands(0).Columns("CodNeumatico").Header.VisiblePosition = 5
                    .DisplayLayout.Bands(0).Columns("Marca").Header.VisiblePosition = 6
                    .DisplayLayout.Bands(0).Columns("Modelo").Header.VisiblePosition = 7
                    .DisplayLayout.Bands(0).Columns("TipoMedida").Header.VisiblePosition = 8
                    .DisplayLayout.Bands(0).Columns("Medida").Header.VisiblePosition = 9
                    .DisplayLayout.Bands(0).Columns("TipoBanda").Header.VisiblePosition = 10
                    .DisplayLayout.Bands(0).Columns("DOT").Header.VisiblePosition = 11
                    .DisplayLayout.Bands(0).Columns("Posicion").Header.VisiblePosition = 12
                    .DisplayLayout.Bands(0).Columns("Cocada").Header.VisiblePosition = 13
                    .DisplayLayout.Bands(0).Columns("Kilometraje").Header.VisiblePosition = 14
                    .DisplayLayout.Bands(0).Columns("FechaOperacion").Header.VisiblePosition = 15
                    .DisplayLayout.Bands(0).Columns("Cocadaminima").Header.VisiblePosition = 16

                    .DisplayLayout.Bands(0).Columns("Centro").Header.Caption = "Centro de Distribucion"
                    .DisplayLayout.Bands(0).Columns("CodNeumatico").Header.Caption = "Neumatico"
                    .DisplayLayout.Bands(0).Columns("Posicion").Header.Caption = "Pos."
                    .DisplayLayout.Bands(0).Columns("Cocada").Header.Caption = "Coc. Act."
                    .DisplayLayout.Bands(0).Columns("Cocadaminima").Header.Caption = "Coc. Min."

                    FormatoColumna(griPreliminarInsp, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Cocada", "Cocadaminima", "Kilometraje")

                    .DisplayLayout.Bands(0).Columns("FechaOperacion").Style = ColumnStyle.DateTime
                    .DisplayLayout.Bands(0).Columns("Confirmado").Style = ColumnStyle.CheckBox

                    .DisplayLayout.Bands(0).Columns("DOT").Width = 40
                    .DisplayLayout.Bands(0).Columns("Flota").Width = 90
                    .DisplayLayout.Bands(0).Columns("Tipo").Width = 70
                    .DisplayLayout.Bands(0).Columns("Placa").Width = 60
                    .DisplayLayout.Bands(0).Columns("CodNeumatico").Width = 70
                    .DisplayLayout.Bands(0).Columns("FechaOperacion").Width = 110
                    .DisplayLayout.Bands(0).Columns("Posicion").Width = 30
                    .DisplayLayout.Bands(0).Columns("Cocada").Width = 60
                    .DisplayLayout.Bands(0).Columns("Cocadaminima").Width = 60
                    .DisplayLayout.Bands(0).Columns("Modelo").Width = 70
                    .DisplayLayout.Bands(0).Columns("TipoBanda").Width = 60

                    .DisplayLayout.Bands(0).Columns("Posicion").CellAppearance.TextHAlign = HAlign.Center

                    .DisplayLayout.Bands(0).Columns("Placa").SortIndicator = SortOrder.Ascending

                    .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                    .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                    .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                    .DisplayLayout.Override.FilterUIProvider = Filtro1
                    .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                    .DisplayLayout.MaxColScrollRegions = 1
                    .DisplayLayout.MaxRowScrollRegions = 1


                End If

                If .Rows.Count > 0 Then
                    For Each Fila In .Rows
                        If Fila.Cells("IndColor").Value > 1 Then
                            Fila.Cells("Cocada").Appearance.BackColor = colorBueno.Color
                            Fila.Cells("CodNeumatico").Appearance.BackColor = colorBueno.Color
                        ElseIf Fila.Cells("IndColor").Value > -1 And Fila.Cells("IndColor").Value < 2 Then
                            Fila.Cells("Cocada").Appearance.BackColor = ColorRegular.Color
                            Fila.Cells("CodNeumatico").Appearance.BackColor = ColorRegular.Color
                        Else
                            Fila.Cells("Cocada").Appearance.BackColor = colorMalo.Color
                            Fila.Cells("CodNeumatico").Appearance.BackColor = colorMalo.Color
                        End If
                    Next
                End If

                .Text = "LISTA DE NEUMATICO MONTADO [ESTADO: " & cboEstadoBus.Text & "] (" & .Rows.Count & ")"

            End With

            'CargarComboCelda()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarConfiguracion(ByVal leDetPreliminar As List(Of e_DetallePreliminar))
        Try
            Dim oeVehiculo As New e_Vehiculo, olVehiculo As New l_Vehiculo, leVehiculo As New List(Of e_Vehiculo)
            oeVehiculo = New e_Vehiculo()
            oeVehiculo.Activo = 1
            oeVehiculo.Motriz = -1
            oeVehiculo.TipoOperacion = "N"
            Dim _leAux = From la In leDetPreliminar Select la.Placa
            leVehiculo = olVehiculo.Listar(oeVehiculo).Where(Function(x) _leAux.Contains(x.Placa)).ToList
            CargarGrillaConfiguracionMedida(leVehiculo)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarGrillaConfiguracionMedida(ByVal leVehiculo As List(Of e_Vehiculo))
        Try
            With griConfiguracionMedida
                If BandLoad Then .ResetDisplayLayout()
                .DataSource = leVehiculo
                If BandLoad Then
                    ConfiguraGrilla(griConfiguracionMedida, "Tahoma", True, UIElementBorderStyle.Default)
                    OcultarColumna2(griConfiguracionMedida, False, "IdFlota", "Placa", "Motriz", "TipoVehiculo", "Marca", "Modelo", "ConfiguracionNeumaticos", _
                                    "AnioFabricacion", "NroEjes", "NroNeumaticos", "NroNeumaticosRepuesto", "TipoNeumatico")
                    .DisplayLayout.Bands(0).Columns("Codigo").Width = 50
                    .DisplayLayout.Bands(0).Columns("Placa").Width = 70
                    .DisplayLayout.Bands(0).Columns("ConfiguracionNeumaticos").Width = 60
                    .DisplayLayout.Bands(0).Columns("AnioFabricacion").Width = 50
                    .DisplayLayout.Bands(0).Columns("NroEjes").Width = 50
                    .DisplayLayout.Bands(0).Columns("NroNeumaticos").Width = 50
                    .DisplayLayout.Bands(0).Columns("NroNeumaticosRepuesto").Width = 50
                    .DisplayLayout.Bands(0).Columns("ConfiguracionNeumaticos").Header.Caption = "Conf. Neu."
                    .DisplayLayout.Bands(0).Columns("IdFlota").Header.Caption = "Flota"
                    .DisplayLayout.Bands(0).Columns("AnioFabricacion").Header.Caption = "Año Fab."
                    .DisplayLayout.Bands(0).Columns("NroEjes").Header.Caption = "Nro. Ejes."
                    .DisplayLayout.Bands(0).Columns("NroNeumaticos").Header.Caption = "Nro. Neu."
                    .DisplayLayout.Bands(0).Columns("NroNeumaticosRepuesto").Header.Caption = "Nro. Rep."
                    .DisplayLayout.Bands(0).Columns("IdFlota").Header.VisiblePosition = 0
                    .DisplayLayout.Override.BorderStyleCell = UIElementBorderStyle.Dotted
                    .DisplayLayout.Override.BorderStyleRow = UIElementBorderStyle.Dotted
                    FormatoColumna(griConfiguracionMedida, "", ColumnStyle.CheckBox, HAlign.Default, "Motriz")

                    .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                    .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                    .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                    .DisplayLayout.Override.FilterUIProvider = Filtro1
                    .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                    .DisplayLayout.MaxColScrollRegions = 1
                    .DisplayLayout.MaxRowScrollRegions = 1

                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarDetalleConfiguracion(ByVal Placa As String)
        Try
            oeDetallePre = New e_DetallePreliminar
            oeDetallePre.TipoOperacion = "L"
            oeDetallePre.Periodo = fecPeriodo.Value.Year.ToString & FormatoDocumento(fecPeriodo.Value.Month.ToString, 2)
            leDetallePre = olDetallePre.Listar(oeDetallePre).Where(Function(x) x.Placa = Placa).ToList
            CargarGrillaDetalleConfiguracion(leDetallePre)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarGrillaDetalleConfiguracion(ByVal leDetPreliminar As List(Of e_DetallePreliminar))
        Try
            With griDetalleConfig
                If BandLoad Then .ResetDisplayLayout()
                .DataSource = leDetPreliminar
                If BandLoad Then
                    'For Each col In .DisplayLayout.Bands(0).Columns
                    '    If col.Key = "Confirmado" Then
                    '        col.CellActivation = Activation.AllowEdit : col.CellClickAction = CellClickAction.EditAndSelectText
                    '    Else
                    '        col.CellActivation = Activation.NoEdit : col.CellClickAction = CellClickAction.RowSelect
                    '    End If
                    'Next
                    ConfiguraGrilla(griDetalleConfig, "Tahoma", True, UIElementBorderStyle.Default)
                    OcultarColumna(griDetalleConfig, True, "Id", "IdPreliminarInspeccion", "IdOperacionNeu", "CodOperacion", "FechaCreacion", "UsuarioCreacion", _
                                   "Activo", "MarcaRecomendada", "MedidaRecomendada", "IdDisenioPedido", "Observacion", "IdVidaNeumatico", "TipoBandaPedido", _
                                   "IdMaterial", "IndColor", "Confirmado")


                    .DisplayLayout.Bands(0).Columns("Centro").Header.VisiblePosition = 0
                    .DisplayLayout.Bands(0).Columns("Flota").Header.VisiblePosition = 1
                    .DisplayLayout.Bands(0).Columns("Tipo").Header.VisiblePosition = 2
                    .DisplayLayout.Bands(0).Columns("Placa").Header.VisiblePosition = 3
                    .DisplayLayout.Bands(0).Columns("CodNeumatico").Header.VisiblePosition = 4
                    .DisplayLayout.Bands(0).Columns("Marca").Header.VisiblePosition = 5
                    .DisplayLayout.Bands(0).Columns("Modelo").Header.VisiblePosition = 6
                    .DisplayLayout.Bands(0).Columns("TipoMedida").Header.VisiblePosition = 7
                    .DisplayLayout.Bands(0).Columns("Medida").Header.VisiblePosition = 8
                    .DisplayLayout.Bands(0).Columns("TipoBanda").Header.VisiblePosition = 9
                    .DisplayLayout.Bands(0).Columns("DOT").Header.VisiblePosition = 10
                    .DisplayLayout.Bands(0).Columns("Posicion").Header.VisiblePosition = 11
                    .DisplayLayout.Bands(0).Columns("Cocada").Header.VisiblePosition = 12
                    .DisplayLayout.Bands(0).Columns("Kilometraje").Header.VisiblePosition = 13
                    .DisplayLayout.Bands(0).Columns("FechaOperacion").Header.VisiblePosition = 14
                    .DisplayLayout.Bands(0).Columns("Cocadaminima").Header.VisiblePosition = 15

                    .DisplayLayout.Bands(0).Columns("Centro").Header.Caption = "Centro de Distribucion"
                    .DisplayLayout.Bands(0).Columns("CodNeumatico").Header.Caption = "Neumatico"
                    .DisplayLayout.Bands(0).Columns("Posicion").Header.Caption = "Pos."
                    .DisplayLayout.Bands(0).Columns("Cocada").Header.Caption = "Coc. Act."
                    .DisplayLayout.Bands(0).Columns("Cocadaminima").Header.Caption = "Coc. Min."

                    FormatoColumna(griPreliminarInsp, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Cocada", "Cocadaminima", "Kilometraje")

                    .DisplayLayout.Bands(0).Columns("FechaOperacion").Style = ColumnStyle.DateTime


                    .DisplayLayout.Bands(0).Columns("DOT").Width = 40
                    .DisplayLayout.Bands(0).Columns("Flota").Width = 90
                    .DisplayLayout.Bands(0).Columns("Tipo").Width = 70
                    .DisplayLayout.Bands(0).Columns("Placa").Width = 60
                    .DisplayLayout.Bands(0).Columns("CodNeumatico").Width = 70
                    .DisplayLayout.Bands(0).Columns("FechaOperacion").Width = 110
                    .DisplayLayout.Bands(0).Columns("Posicion").Width = 30
                    .DisplayLayout.Bands(0).Columns("Cocada").Width = 60
                    .DisplayLayout.Bands(0).Columns("Cocadaminima").Width = 60
                    .DisplayLayout.Bands(0).Columns("Modelo").Width = 70
                    .DisplayLayout.Bands(0).Columns("TipoBanda").Width = 60

                    .DisplayLayout.Bands(0).Columns("Posicion").CellAppearance.TextHAlign = HAlign.Center

                    .DisplayLayout.Bands(0).Columns("Placa").SortIndicator = SortOrder.Ascending
                    .DisplayLayout.Override.BorderStyleCell = UIElementBorderStyle.Dotted
                    .DisplayLayout.Override.BorderStyleRow = UIElementBorderStyle.Dotted
                    .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                    .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                    .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                    .DisplayLayout.Override.FilterUIProvider = Filtro1
                    .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                    .DisplayLayout.MaxColScrollRegions = 1
                    .DisplayLayout.MaxRowScrollRegions = 1


                End If

                If .Rows.Count > 0 Then
                    For Each Fila In .Rows
                        If Fila.Cells("IndColor").Value > 1 Then
                            Fila.Cells("Cocada").Appearance.BackColor = colorBueno.Color
                            Fila.Cells("CodNeumatico").Appearance.BackColor = colorBueno.Color
                        ElseIf Fila.Cells("IndColor").Value > -1 And Fila.Cells("IndColor").Value < 2 Then
                            Fila.Cells("Cocada").Appearance.BackColor = ColorRegular.Color
                            Fila.Cells("CodNeumatico").Appearance.BackColor = ColorRegular.Color
                        Else
                            Fila.Cells("Cocada").Appearance.BackColor = colorMalo.Color
                            Fila.Cells("CodNeumatico").Appearance.BackColor = colorMalo.Color
                        End If
                    Next
                End If

                .Text = "LISTA DE NEUMATICO MONTADO"

            End With

            'CargarComboCelda()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarComboCelda()
        Try
            With griDetallePre
                If .Rows.Count > 0 Then
                    For Each Fila In .Rows

                        Dim _leMedAux = leMedidaNeu.Where(Function(it) it.UsuarioCreacion = Fila.Cells("MarcaRecomendada").Value).OrderBy(Function(it) it.Nombre).ToList

                        With .DisplayLayout
                            .ValueLists.Clear()
                            .ValueLists.Add("MedidaRecomendada")
                            With .ValueLists("MedidaRecomendada").ValueListItems
                                .Clear()
                                For Each oeMod In _leMedAux
                                    .Add(oeMod.Id, oeMod.Nombre)
                                Next
                            End With
                            .Bands(0).Columns("MedidaRecomendada").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
                            '.Bands(0).Columns("ModeloRecomendada").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDown
                            Fila.Cells("MedidaRecomendada").ValueList = .ValueLists("MedidaRecomendada")
                            .ValueLists("MedidaRecomendada").MaxDropDownItems = 20
                        End With

                        Dim _leDisAux = leDisenoNeu.Where(Function(it) it.IdMarca = Fila.Cells("MarcaRecomendada").Value _
                                                              And it.IdMedidaNeumatico = Fila.Cells("MedidaRecomendada").Value).OrderBy(Function(it) it.Nombre).ToList
                        With .DisplayLayout
                            .ValueLists.Clear()
                            .ValueLists.Add("IdDisenioPedido")
                            With .ValueLists("IdDisenioPedido").ValueListItems
                                .Clear()
                                For Each oeDis In _leDisAux
                                    .Add(oeDis.Id, oeDis.Nombre)
                                Next
                            End With
                            .Bands(0).Columns("IdDisenioPedido").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
                            '.Bands(0).Columns("ModeloRecomendada").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDown
                            Fila.Cells("IdDisenioPedido").ValueList = .ValueLists("IdDisenioPedido")
                            .ValueLists("IdDisenioPedido").MaxDropDownItems = 20
                        End With

                    Next
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarPreNecesidades(ByVal lePreNec As List(Of e_PreliminarInspeccion))
        Try
            With griPreNecesidades

                .ResetDisplayLayout()

                .DataSource = lePreNec

                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdEstado").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("Periodo").Hidden = True

                .DisplayLayout.Bands(0).Columns("Codigo").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("FechaEnvio").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("FechaTermino").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Estado").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("Usuario").Header.VisiblePosition = 6

                .DisplayLayout.Bands(0).Columns("FechaCreacion").Header.Caption = "Fecha"

                .DisplayLayout.Bands(0).Columns("Usuario").Width = 300

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

                If .Rows.Count > 0 Then
                    For Each fila In .Rows
                        Select Case fila.Cells("Estado").Value
                            Case "GENERADA" : fila.CellAppearance.BackColor = colorGenerada.Color
                            Case "ENVIADO" : fila.CellAppearance.BackColor = colorEnviado.Color
                            Case "TERMINADA" : fila.CellAppearance.BackColor = colorTerminado.Color
                        End Select
                    Next
                End If

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarDetallePre(ByVal leDet As List(Of e_DetallePreliminar))
        Try
            With griDetallePre

                If BandLoad Then .ResetDisplayLayout()

                .DataSource = leDet

                If BandLoad Then

                    CargarCombo_Grilla()

                    For Each col In .DisplayLayout.Bands(0).Columns
                        If col.Key = "MarcaRecomendada" Or col.Key = "IdDisenioPedido" Or col.Key = "MedidaRecomendada" _
                        Or col.Key = "Confirmado" Or col.Key = "Observacion" Or col.Key = "TipoBandaPedido" Then
                            col.CellActivation = Activation.AllowEdit
                            col.CellClickAction = CellClickAction.EditAndSelectText
                        Else
                            col.CellActivation = Activation.NoEdit
                            col.CellClickAction = CellClickAction.RowSelect
                        End If
                    Next

                    .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdPreliminarInspeccion").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdOperacionNeu").Hidden = True
                    .DisplayLayout.Bands(0).Columns("CodOperacion").Hidden = True
                    .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                    .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdVidaNeumatico").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IdMaterial").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Kilometraje").Hidden = True
                    .DisplayLayout.Bands(0).Columns("IndColor").Hidden = True

                    .DisplayLayout.Bands(0).Columns("Id").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                    .DisplayLayout.Bands(0).Columns("IdPreliminarInspeccion").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                    .DisplayLayout.Bands(0).Columns("IdOperacionNeu").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                    .DisplayLayout.Bands(0).Columns("CodOperacion").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                    .DisplayLayout.Bands(0).Columns("FechaCreacion").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                    .DisplayLayout.Bands(0).Columns("UsuarioCreacion").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                    .DisplayLayout.Bands(0).Columns("Activo").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                    .DisplayLayout.Bands(0).Columns("IdVidaNeumatico").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True

                    .DisplayLayout.Bands(0).Columns("Centro").Header.VisiblePosition = 1
                    .DisplayLayout.Bands(0).Columns("Flota").Header.VisiblePosition = 2
                    .DisplayLayout.Bands(0).Columns("Placa").Header.VisiblePosition = 3
                    .DisplayLayout.Bands(0).Columns("CodNeumatico").Header.VisiblePosition = 4
                    .DisplayLayout.Bands(0).Columns("Marca").Header.VisiblePosition = 5
                    .DisplayLayout.Bands(0).Columns("Modelo").Header.VisiblePosition = 6
                    .DisplayLayout.Bands(0).Columns("Medida").Header.VisiblePosition = 7
                    .DisplayLayout.Bands(0).Columns("TipoBanda").Header.VisiblePosition = 8
                    .DisplayLayout.Bands(0).Columns("Posicion").Header.VisiblePosition = 9
                    .DisplayLayout.Bands(0).Columns("Cocada").Header.VisiblePosition = 10
                    .DisplayLayout.Bands(0).Columns("FechaOperacion").Header.VisiblePosition = 11
                    .DisplayLayout.Bands(0).Columns("Cocadaminima").Header.VisiblePosition = 12
                    .DisplayLayout.Bands(0).Columns("MarcaRecomendada").Header.VisiblePosition = 13
                    .DisplayLayout.Bands(0).Columns("MedidaRecomendada").Header.VisiblePosition = 14
                    .DisplayLayout.Bands(0).Columns("IdDisenioPedido").Header.VisiblePosition = 15
                    .DisplayLayout.Bands(0).Columns("TipoBandaPedido").Header.VisiblePosition = 16
                    .DisplayLayout.Bands(0).Columns("Confirmado").Header.VisiblePosition = 17
                    .DisplayLayout.Bands(0).Columns("Observacion").Header.VisiblePosition = 18


                    .DisplayLayout.Bands(0).Columns("Centro").Header.Caption = "Centro de Distribucion"
                    .DisplayLayout.Bands(0).Columns("CodNeumatico").Header.Caption = "Neumatico"
                    .DisplayLayout.Bands(0).Columns("Posicion").Header.Caption = "Pos."
                    .DisplayLayout.Bands(0).Columns("Cocada").Header.Caption = "Coc. Act."
                    .DisplayLayout.Bands(0).Columns("Cocadaminima").Header.Caption = "Coc. Min."
                    .DisplayLayout.Bands(0).Columns("MarcaRecomendada").Header.Caption = "Marca Recom."
                    .DisplayLayout.Bands(0).Columns("MedidaRecomendada").Header.Caption = "Medida Recom."
                    .DisplayLayout.Bands(0).Columns("IdDisenioPedido").Header.Caption = "Modelo Recom."

                    .DisplayLayout.Bands(0).Columns("Cocada").Format = "#,##0.00"
                    .DisplayLayout.Bands(0).Columns("Cocadaminima").Format = "#,##0.00"

                    .DisplayLayout.Bands(0).Columns("FechaOperacion").Style = ColumnStyle.DateTime
                    .DisplayLayout.Bands(0).Columns("Confirmado").Style = ColumnStyle.CheckBox

                    .DisplayLayout.Bands(0).Columns("Flota").Width = 110
                    .DisplayLayout.Bands(0).Columns("Placa").Width = 55
                    .DisplayLayout.Bands(0).Columns("CodNeumatico").Width = 60
                    .DisplayLayout.Bands(0).Columns("FechaOperacion").Width = 110
                    .DisplayLayout.Bands(0).Columns("Posicion").Width = 25
                    .DisplayLayout.Bands(0).Columns("Cocada").Width = 50
                    .DisplayLayout.Bands(0).Columns("Cocadaminima").Width = 50
                    .DisplayLayout.Bands(0).Columns("Modelo").Width = 60
                    .DisplayLayout.Bands(0).Columns("Marca").Width = 80
                    .DisplayLayout.Bands(0).Columns("Medida").Width = 80
                    .DisplayLayout.Bands(0).Columns("TipoBanda").Width = 60
                    .DisplayLayout.Bands(0).Columns("MarcaRecomendada").Width = 80
                    .DisplayLayout.Bands(0).Columns("MedidaRecomendada").Width = 80
                    .DisplayLayout.Bands(0).Columns("IdDisenioPedido").Width = 70
                    .DisplayLayout.Bands(0).Columns("TipoBandaPedido").Width = 60
                    .DisplayLayout.Bands(0).Columns("Observacion").Width = 200

                    .DisplayLayout.Bands(0).Columns("Posicion").CellAppearance.TextHAlign = HAlign.Center
                    .DisplayLayout.Bands(0).Columns("Cocada").CellAppearance.TextHAlign = HAlign.Right
                    .DisplayLayout.Bands(0).Columns("Cocadaminima").CellAppearance.TextHAlign = HAlign.Right

                    '.DisplayLayout.Bands(0).Columns("Centro").CellAppearance.BackColor = Color.Gold
                    '.DisplayLayout.Bands(0).Columns("Flota").CellAppearance.BackColor = Color.Gold
                    '.DisplayLayout.Bands(0).Columns("Placa").CellAppearance.BackColor = Color.Gold
                    .DisplayLayout.Bands(0).Columns("MarcaRecomendada").CellAppearance.BackColor = Color.LemonChiffon
                    .DisplayLayout.Bands(0).Columns("MedidaRecomendada").CellAppearance.BackColor = Color.LemonChiffon
                    .DisplayLayout.Bands(0).Columns("IdDisenioPedido").CellAppearance.BackColor = Color.LemonChiffon
                    .DisplayLayout.Bands(0).Columns("TipoBandaPedido").CellAppearance.BackColor = Color.LemonChiffon
                    '.DisplayLayout.Bands(0).Columns("Medida").CellAppearance.BackColor = Color.LightSkyBlue
                    '.DisplayLayout.Bands(0).Columns("Posicion").CellAppearance.BackColor = Color.LightSlateGray

                    .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                    .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                    .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                    .DisplayLayout.Override.FilterUIProvider = Filtro1
                    '.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                    '.DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                    .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                    .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                    .DisplayLayout.MaxColScrollRegions = 1
                    .DisplayLayout.MaxRowScrollRegions = 1

                End If

            End With

            CargarComboCelda()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

    Private Sub griConfiguracionMedida_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles griConfiguracionMedida.DoubleClickRow
        Try
            CargarDetalleConfiguracion(griConfiguracionMedida.ActiveRow.Cells("Placa").Value.ToString.Trim)
            ficPreliminar.SelectedTab = ficPreliminar.Tabs(4)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDetalleConfig_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griDetalleConfig.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            e.Cancel = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griConfiguracionMedida_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griConfiguracionMedida.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            e.Cancel = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
End Class