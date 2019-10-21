'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class frm_RevisionTecnica
    Inherits frm_MenuPadre


#Region "Inicializar el formulario"

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Shared Instancia As frm_RevisionTecnica = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_RevisionTecnica()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Declaración de Variables"
    Dim _ingresando_datos As Boolean
    Dim oeDocumentoVehicular As New e_DocumentoVehicular
    Dim olDocumentoVehicular As New l_DocumentoVehicular
    Dim oeDetalleDocumentoVehicular As New e_DetalleDocumentoVehiculo
    Dim olDetalleDocumentoVehiculo As New l_DetalleDocumentoVehiculo
    Dim oeRevisionTecnica As New e_RevisionTecnica
    Dim olRevisionTecnica As New l_RevisionTecnica
    Dim oeVehiculo As New e_Vehiculo
    Dim olVehiculo As New l_Vehiculo
    Dim lstVehiculo As New List(Of e_Vehiculo)
    Dim lstVehiculo2 As New List(Of e_Vehiculo)
#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If Grid_ListadoRevisionT.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            Inicializar()
            MostrarTabs(1, tc_DocumentosVehiculares, 1)
            oeDocumentoVehicular.TipoOperacion = "I"
            Operacion = "Nuevo"
            MyBase.Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Operacion = "Editar"
            oeDocumentoVehicular = New e_DocumentoVehicular
            If Grid_ListadoRevisionT.ActiveRow.Band.Index = 0 Then
                EditarRevision()
                MostrarTabs(1, tc_DocumentosVehiculares, 1)
                cboEmpresa.Focus()
                Operacion = "Editar"
                MyBase.Editar()
            Else
                Throw New Exception("Seleccione un Registro válido")
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarDocumento() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tc_DocumentosVehiculares, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            MostrarTabs(0, tc_DocumentosVehiculares, 2)
            ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
            _ingresando_datos = False
            Consultar(True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With Grid_ListadoRevisionT
                If Grid_ListadoRevisionT.ActiveRow.Band.Index = 0 Then
                    If MessageBox.Show("Esta seguro de eliminar la Revisión Técnica N°: " & _
                    .ActiveRow.Cells("Numero").Value.ToString.Trim & " ?", _
                    "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        oeDocumentoVehicular.TipoOperacion = "E"
                        oeDocumentoVehicular.Id = .ActiveRow.Cells("Id").Value
                        olDocumentoVehicular.Eliminar(oeDocumentoVehicular)
                        Consultar(True)
                    End If
                Else
                    Throw New Exception("Seleccione una revisión para poder eliminarlo")
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If Grid_ListadoRevisionT.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(Grid_ListadoRevisionT)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Procedimientos"

    Private Sub LlenarCombo()
        Try
            LlenarTracto()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarTracto()
        Try
            oeVehiculo = New e_Vehiculo
            oeVehiculo.Id = ""
            oeVehiculo.Placa = "NINGUNO"
            lstVehiculo.Add(oeVehiculo)
            oeVehiculo = New e_Vehiculo
            oeVehiculo.TipoOperacion = "A"
            oeVehiculo.Motriz = -1
            oeVehiculo.Activo = True
            lstVehiculo.AddRange(olVehiculo.Listar(oeVehiculo))
            LlenarComboMaestro(CmbTracto, lstVehiculo, 0)

            oeVehiculo = New e_Vehiculo
            oeVehiculo.Id = ""
            oeVehiculo.Placa = "TODOS"
            lstVehiculo2.Add(oeVehiculo)
            oeVehiculo = New e_Vehiculo
            oeVehiculo.TipoOperacion = "A"
            oeVehiculo.Motriz = -1
            oeVehiculo.Activo = True
            lstVehiculo2.AddRange(olVehiculo.Listar(oeVehiculo))
            LlenarComboMaestro(CmbFilTracto, lstVehiculo2, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializar()
        Try
            oeDocumentoVehicular = New e_DocumentoVehicular
            CmbTracto.SelectedIndex = 0
            cboEmpresa.DataSource = ProveedorPublic
            cboEmpresa.Value = Nothing
            dtp_FEmision.Value = Date.Now()
            dtp_FechaProxima.Value = Date.Now().AddYears(1)
            txtTipoInspeccion.Value = ""
            txtNroInspeccion.Value = ""
            txtNroCertificado.Value = ""
            TxtDescripcion.Value = ""
            TxtCodigo.Value = ""
            txtGlosaRevision.Value = ""
            TxtCalificacion.Value = ""
            TxtResultado.Value = ""
            LimpiaGrid(grid_RevisionTecnica, dsRevisionTecnica)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MostrarDetalleVehiculo()
        Try
            If CmbTracto.Value <> "" Then
                oeVehiculo = New e_Vehiculo
                oeVehiculo = lstVehiculo.Where(Function(item) item.Id = CmbTracto.Value)(0)
                TxtPlaca.Value = oeVehiculo.Placa
                TxtCategoria.Value = oeVehiculo.NroMTC
                TxtMarca.Value = oeVehiculo.Marca
                TxtModelo.Value = oeVehiculo.Modelo
                TxtAñoFabri.Value = oeVehiculo.AnioFabricacion
                TxtSerie.Value = oeVehiculo.NroSerieChasis
                TxtMotor.Value = oeVehiculo.NroSerieMotor
                TxtNroEjes.Value = oeVehiculo.NroEjes
                TxtNroRuedas.Value = oeVehiculo.NroNeumaticos
            Else
                TxtPlaca.Value = ""
                TxtCategoria.Value = ""
                TxtMarca.Value = ""
                TxtModelo.Value = ""
                TxtAñoFabri.Value = ""
                TxtSerie.Value = ""
                TxtMotor.Value = ""
                TxtNroEjes.Value = ""
                TxtNroRuedas.Value = ""
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarToolInfoTipo()
        Try
            ToolTipAyudaTipo.Enabled = True
            Dim ToolTipInfo As New UltraWinToolTip.UltraToolTipInfo
            ToolTipInfo.ToolTipTitle = "Tipo de Revisiones Técnicas"
            ToolTipInfo.ToolTipText = "Ejemplos:" + vbCrLf + _
                                      "Insp. Técnica Vehicular Complementaria." + vbCrLf + _
                                      "Certificado de Rebisión Técnica."
            ToolTipInfo.ToolTipImage = ToolTipImage.Warning
            ToolTipAyudaTipo.SetUltraToolTip(AyudaTipo, ToolTipInfo)
            ToolTipAyudaTipo.IsToolTipVisible(AyudaTipo)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, False)
        End Try
    End Sub

    Private Sub LlenarToolInfoResultado()
        Try
            ToolTipAyudaResultado.Enabled = True
            Dim ToolTipInfo As New UltraWinToolTip.UltraToolTipInfo
            ToolTipInfo.ToolTipTitle = "Resultado de Revisiones Técnicas"
            ToolTipInfo.ToolTipText = "Ejemplos:" + vbCrLf + _
                                      "Aprobado." + vbCrLf + _
                                      "Acreditado-"
            ToolTipInfo.ToolTipImage = ToolTipImage.Warning
            ToolTipAyudaResultado.SetUltraToolTip(AyudaResultado, ToolTipInfo)
            ToolTipAyudaResultado.IsToolTipVisible(AyudaResultado)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, False)
        End Try
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeDocumentoVehicular = New e_DocumentoVehicular
            With Grid_ListadoRevisionT
                oeDocumentoVehicular.Activo = True
                oeDocumentoVehicular.TipoOperacion = "T"
                oeDocumentoVehicular.IdVehiculo = CmbFilTracto.Value
                oeDocumentoVehicular.IdEmpresaEmisora = ""
                oeDocumentoVehicular.IndVigencia = IIf(chk_Vigentes.Checked, True, False)
                oeDocumentoVehicular.TipoDocumento = "1CH000000050"
                Dim ds As DataSet = olDocumentoVehicular.ListarDts(oeDocumentoVehicular)
                Grid_ListadoRevisionT.DataSource = ds
                Me.Cursor = Cursors.WaitCursor
                With .DisplayLayout
                    .UseFixedHeaders = True
                    .Override.FixedHeaderIndicator = FixedHeaderIndicator.None
                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In Grid_ListadoRevisionT.Rows
                        If Date.Now.AddDays(numDias.Value) > fila.Cells("FechaVencimiento").Value And fila.Cells("FechaVencimiento").Value > Date.Now Then
                            fila.CellAppearance.BackColor = Me.ColorVencimiento.Color
                        End If
                    Next
                End With
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function GuardarDocumento() As Boolean
        Try
            If ProveedorPublic.Where(Function(i) i.Id = cboEmpresa.Value).Count() = 0 Then Throw New Exception("Seleccione una empresa certificadora válida.")
            If oeDocumentoVehicular.ldDetalleDocVeh.Where(Function(i) i.Activo = True And i.IdVehiculo <> "").Count() = 0 Then Throw New Exception("Especifique la unidad de la revisión técnica.")
            oeDocumentoVehicular.IdTipoDocumento = "1CH000000050"
            oeDocumentoVehicular.IdEmpresaEmisora = cboEmpresa.Value
            oeDocumentoVehicular.Tipo = txtTipoInspeccion.Value
            oeDocumentoVehicular.FechaEmision = dtp_FEmision.Value
            oeDocumentoVehicular.NroResolucion = txtNroInspeccion.Value
            oeDocumentoVehicular.Numero = txtNroCertificado.Value
            oeDocumentoVehicular.Resultado = TxtResultado.Value
            oeDocumentoVehicular.FechaVencimiento = dtp_FechaProxima.Value
            oeDocumentoVehicular.Descripcion = TxtDescripcion.Value
            oeDocumentoVehicular.UsuarioCreacion = gUsuarioSGI.Id
            oeDocumentoVehicular.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olDocumentoVehicular.Guardar(oeDocumentoVehicular) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, tc_DocumentosVehiculares, 2)
                Consultar(True)
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub EditarRevision()
        Try
            Inicializar()
            oeDocumentoVehicular.Activo = True
            oeDocumentoVehicular.TipoOperacion = "O"
            oeDocumentoVehicular.Id = Grid_ListadoRevisionT.ActiveRow.Cells("Id").Value
            oeDocumentoVehicular = olDocumentoVehicular.Obtener(oeDocumentoVehicular)
            oeDocumentoVehicular.TipoOperacion = "A"

            oeDetalleDocumentoVehicular.TipoOperacion = "O"
            oeDetalleDocumentoVehicular.Id = ""
            oeDetalleDocumentoVehicular.IdDocumento = oeDocumentoVehicular.Id
            oeDocumentoVehicular.ldDetalleDocVeh = olDetalleDocumentoVehiculo.Listar(oeDetalleDocumentoVehicular)

            oeRevisionTecnica.TipoOperacion = "O"
            oeRevisionTecnica.Id = ""
            oeRevisionTecnica.IdDocumentoVehicular = oeDocumentoVehicular.Id
            oeDocumentoVehicular.ldRevisionTec = olRevisionTecnica.Listar(oeRevisionTecnica)

            cboEmpresa.Value = oeDocumentoVehicular.IdEmpresaEmisora
            txtTipoInspeccion.Value = oeDocumentoVehicular.Tipo
            dtp_FEmision.Value = oeDocumentoVehicular.FechaEmision
            txtNroInspeccion.Value = oeDocumentoVehicular.NroResolucion
            txtNroCertificado.Value = oeDocumentoVehicular.Numero
            TxtResultado.Value = oeDocumentoVehicular.Resultado
            dtp_FechaProxima.Value = oeDocumentoVehicular.FechaVencimiento
            TxtDescripcion.Value = oeDocumentoVehicular.Descripcion

            CmbTracto.Value = oeDocumentoVehicular.ldDetalleDocVeh(0).IdVehiculo

            grid_RevisionTecnica.DataSource = oeDocumentoVehicular.ldRevisionTec
            grid_RevisionTecnica.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Eventos"
    Private Sub frm_RevisionTecnica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LlenarCombo()
            Inicializar()
            LlenarToolInfoTipo()
            LlenarToolInfoResultado()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub frm_RevisionTecnica_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_RevisionTecnica_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            Me.Activate()
            Me.Cancelar()
        End If
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_RevisionTecnica_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Try
            If tc_DocumentosVehiculares.Tabs(0).Selected = True Then
                If Grid_ListadoRevisionT.Rows.Count() = 0 Then
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                Else
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                End If
            ElseIf tc_DocumentosVehiculares.Tabs(1).Selected = True Then
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub CmbTracto_ValueChanged_1(sender As Object, e As EventArgs) Handles CmbTracto.ValueChanged
        Try
            MostrarDetalleVehiculo()
            If oeDocumentoVehicular.ldDetalleDocVeh.Count = 0 Then
                oeDetalleDocumentoVehicular = New e_DetalleDocumentoVehiculo
                oeDetalleDocumentoVehicular.Activo = True
                oeDetalleDocumentoVehicular.IdVehiculo = IIf(CmbTracto.Value = "", False, True)
                oeDetalleDocumentoVehicular.IndTipoVehiculo = ""
                oeDetalleDocumentoVehicular.UsuarioCreacion = ObtenerPerfilPrincipal.Id
                oeDocumentoVehicular.ldDetalleDocVeh.Add(oeDetalleDocumentoVehicular)
            Else
                For Each odd In oeDocumentoVehicular.ldDetalleDocVeh
                    odd.Activo = IIf(CmbTracto.Value = "", False, True)
                    odd.IdVehiculo = CmbTracto.Value
                    odd.IndTipoVehiculo = 0
                    odd.UsuarioCreacion = ObtenerPerfilPrincipal.Id
                Next
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cboEmpresa_InitializeLayout(sender As Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboEmpresa.InitializeLayout
        Try
            With cboEmpresa.DisplayLayout.Bands(0)
                .Columns("Id").Hidden = True
                .Columns("Descripcion").Hidden = True
                .Columns("Nombre").Hidden = False
                .Columns("Nombre").Width = 350
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cboEmpresa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboEmpresa.KeyPress
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                cboEmpresa.PerformAction(UltraComboAction.Dropdown)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cboEmpresa_KeyDown(sender As Object, e As KeyEventArgs) Handles cboEmpresa.KeyDown
        Try
            With CType(sender, Infragistics.Win.UltraWinGrid.UltraCombo)
                If e.KeyData = Keys.Delete Then
                    .Text = ""
                End If
            End With
            If e.KeyCode = Keys.Enter Then
                If cboEmpresa.Text.Trim = "" Then
                    cboEmpresa.DataSource = Nothing
                    cboEmpresa.DataSource = ProveedorPublic
                Else
                    cboEmpresa.DataSource = Nothing
                    cboEmpresa.DataSource = ProveedorPublic.Where(Function(Item) Item.Nombre.Contains(cboEmpresa.Text.Trim)).ToList
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub UltraButton1_Click(sender As Object, e As EventArgs) Handles UltraButton1.Click
        Try
            If oeDocumentoVehicular.ldRevisionTec.Where(Function(i) i.Codigo = TxtCodigo.Value And i.Activo = 1).Count = 0 Then
                If oeDocumentoVehicular.ldRevisionTec.Where(Function(i) i.Codigo = TxtCodigo.Value And i.Activo = 0).Count = 1 Then
                    Dim oe As New e_RevisionTecnica
                    oe.Codigo = TxtCodigo.Value
                    oe = oeDocumentoVehicular.ldRevisionTec.Item(oeDocumentoVehicular.ldRevisionTec.IndexOf(oe))
                    oe.Descripcion = TxtDescripcion.Value
                    oe.Calificacion = TxtCalificacion.Value
                    oe.Activo = True
                    oe.UsuarioCreacion = gUsuarioSGI.Id
                    oe.FechaCreacion = Date.Now()
                Else
                    oeRevisionTecnica = New e_RevisionTecnica
                    oeRevisionTecnica.Id = ""
                    oeRevisionTecnica.IdDocumentoVehicular = ""
                    oeRevisionTecnica.Activo = True
                    oeRevisionTecnica.Codigo = TxtCodigo.Value
                    oeRevisionTecnica.Descripcion = txtGlosaRevision.Value
                    oeRevisionTecnica.Calificacion = TxtCalificacion.Value
                    oeDocumentoVehicular.ldRevisionTec.Add(oeRevisionTecnica)
                    oeRevisionTecnica.UsuarioCreacion = gUsuarioSGI.Id
                    oeRevisionTecnica.FechaCreacion = Date.Now()
                    TxtCodigo.Value = ""
                    txtGlosaRevision.Value = ""
                    TxtCalificacion.Value = ""
                End If
            Else
                Throw New Exception("Existe ya un detalle de revisión técnica con este código")
            End If
            grid_RevisionTecnica.DataSource = oeDocumentoVehicular.ldRevisionTec.Where(Function(i) i.Activo = True).ToList
            grid_RevisionTecnica.DataBind()

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub UltraButton2_Click(sender As Object, e As EventArgs) Handles UltraButton2.Click
        Try
            Dim oeRev = New e_RevisionTecnica
            If grid_RevisionTecnica.Rows.Count > 0 Then
                oeRev.Codigo = grid_RevisionTecnica.ActiveRow.Cells("Codigo").Value
                If grid_RevisionTecnica.ActiveRow.Cells("Id").Value = "" Then
                    oeDocumentoVehicular.ldRevisionTec.Remove(oeRev)
                Else
                    Dim oe As New e_RevisionTecnica
                    oe = oeDocumentoVehicular.ldRevisionTec.Item(oeDocumentoVehicular.ldRevisionTec.IndexOf(oeRev))
                    oe.Activo = False
                End If
            Else
                Throw New Exception("No existe ninguna fila para eliminar")
            End If

            grid_RevisionTecnica.DataSource = oeDocumentoVehicular.ldRevisionTec.Where(Function(i) i.Activo = True)
            grid_RevisionTecnica.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub dtp_FechaProxima_Validated(sender As Object, e As EventArgs) Handles dtp_FechaProxima.Validated
        Try
            If dtp_FechaProxima.Value <= dtp_FEmision.Value Then
                dtp_FechaProxima.Value = dtp_FEmision.Value.AddYears(1)
                Throw New Exception("Fecha de Vencimiento no puede ser menor a la de Emisión.")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Grid_ListadoRevisionT_MouseEnterElement(sender As Object, e As UIElementEventArgs) Handles Grid_ListadoRevisionT.MouseEnterElement
        If Grid_ListadoRevisionT.Rows.Count > 0 Then
            Dim celda As UltraGridCell = TryCast(e.Element.GetContext(GetType(UltraGridCell), True), UltraGridCell)
            If Not celda Is Nothing Then
                If celda.Column.Key = "FechaVencimiento" AndAlso Not IsDBNull(celda.Value) Then
                    Dim diasRetrazo As Integer = DateDiff(DateInterval.Day, Date.Now, celda.Value)
                    If diasRetrazo > 0 Then
                        Dim mensaje As String = diasRetrazo.ToString & " días para vencer"
                        Dim tipInfo As New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo(mensaje, Infragistics.Win.ToolTipImage.Default, "Información", Infragistics.Win.DefaultableBoolean.True)
                        UltraToolTipManager1.SetUltraToolTip(Grid_ListadoRevisionT, tipInfo)
                        UltraToolTipManager1.ShowToolTip(Grid_ListadoRevisionT)
                    End If
                Else
                    UltraToolTipManager1.HideToolTip()
                End If
            End If
        End If
    End Sub

    Private Sub Grid_ListadoRevisionT_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles Grid_ListadoRevisionT.DoubleClickRow
        Try
            If Grid_ListadoRevisionT.ActiveRow.Cells("Id").Value.ToString <> "" Then
                Operacion = "Editar"
                oeDocumentoVehicular = New e_DocumentoVehicular
                If Grid_ListadoRevisionT.ActiveRow.Band.Index = 0 Then
                    EditarRevision()
                    MostrarTabs(1, tc_DocumentosVehiculares, 1)
                    cboEmpresa.Focus()
                    MyBase.Editar()
                Else
                    Throw New Exception("Seleccione una fila válida.")
                End If
            Else
                Throw New Exception("Seleccione una fila válida")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

End Class