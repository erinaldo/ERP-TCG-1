'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports ISL.Controles
Imports Infragistics.Win.UltraWinGrid

Public Class frm_MovimientoNeumatico
    Inherits frm_MenuPadre

#Region "Inicializar el formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_MovimientoNeumatico = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_MovimientoNeumatico()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Dim oeVidaNeumatico As New e_VidaNeumatico, olVidaNeumatico As New l_VidaNeumatico
    Dim oeMovimientoNeumatico As New e_MovimientoNeumatico, olMovimientoNeumatico As New l_MovimientoNeumatico
    Dim oeDetalleConfigNeu As New e_DetalleConfiguracionNeumatico, olDetalleConfigNeu As New l_DetalleConfiguracionNeumatico
    Dim lstDetalleConfigNeu As New List(Of e_DetalleConfiguracionNeumatico)
    Dim lstVidaNeumaticoALM As New List(Of e_VidaNeumatico)
    Dim lstVidaNeumaticoREE As New List(Of e_VidaNeumatico)
    Dim lstVidaNeumaticoREP As New List(Of e_VidaNeumatico)
    Dim lstVidaNeumaticoBAJ As New List(Of e_VidaNeumatico)
    Dim lstVidaNeumaticoVEN As New List(Of e_VidaNeumatico)
    Dim _ingresando_datos As Boolean

    Private picOrigen As PictureBox
    Private picDestino As PictureBox
    Private grid As UltraGrid
    Dim CtrlMask As Byte = 8
    Dim olConfiguracion As New l_Configuracion

    Private FechaServidor As Date = ObtenerFechaServidor()

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            CargarGrids()
            MyBase.Consultar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_TrasladosNeumatico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            pic_Almacen.AllowDrop = True
            pic_Reencauche.AllowDrop = True
            pic_Reparar.AllowDrop = True
            pic_Baja.AllowDrop = True
            pic_Venta.AllowDrop = True
            grid_Almacen.AllowDrop = True
            grid_Reencauche.AllowDrop = True
            grid_Reparacion.AllowDrop = True
            grid_Baja.AllowDrop = True
            grid_Venta.AllowDrop = True
            CargarGrids()
            cboLugar.Items.Clear()
            cboLugar.Items.Add("PACASMAYO")
            cboLugar.Items.Add("LIMA")
            cboLugar.Items.Add("CHICLAYO")
            cboLugar.Items.Add("PIURA")
            cboLugar.SelectedIndex = -1
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            gmt_ConfigurarEventoKeyEnter_Tab(Me)
            gf_AsignarEventoSeleccionarTexto(Me)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub MandarAlmacen_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _
   grid_Almacen.MouseDown, grid_Reencauche.MouseDown, grid_Baja.MouseDown, grid_Reparacion.MouseDown, grid_Venta.MouseDown
        Try
            Dim Derecha As New PictureBox
            Derecha.Image = GeneraImagen("\Llanta derecha especial.jpg", False, "", True)
            grid = CType(sender, UltraGrid)
            With grid
                If .Rows.Count > 0 Then
                    If .ActiveRow.Index >= 0 AndAlso .Selected.Rows.Count > 0 Then
                        picOrigen = Derecha
                        If e.Button = Windows.Forms.MouseButtons.Left And e.Clicks = 1 Then
                            grid.DoDragDrop(Derecha.Image, DragDropEffects.Move Or DragDropEffects.Copy)
                        End If
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub frm_TrasladosNeumatico_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_TrasladosNeumatico_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Select Case _Operacion
            Case "Nuevo", "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub pic_Reencauche_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pic_Reencauche.DragDrop
        Try
            If grid.Name = "grid_Reencauche" Then
                Me.Cursor = Cursors.Default
            Else
                If grid.Name = "grid_Reparacion" Then
                    Throw New Exception("No se puede enviar a reencauche, el neumatico está en reparación")
                Else
                    Enviar("REENCAUCHE")
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub pic_Reparar_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pic_Reparar.DragDrop
        Try
            If grid.Name = "grid_Reparacion" Then
                Me.Cursor = Cursors.Default
            Else
                If grid.Name = "grid_Reencauche" Then
                    Throw New Exception("No se puede enviar a reparacion, el neumatico está en reencauche")
                Else
                    Enviar("REPARACION")
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub pic_Almacen_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pic_Almacen.DragDrop
        Try
            Select Case grid.Name
                Case "grid_Almacen"
                    Me.Cursor = Cursors.Default
                Case "grid_Baja"
                    Enviar("ALMACEN")
                Case "grid_Reencauche"
                    EnviarAlmacen("REENCAUCHE")
                Case "grid_Reparacion"
                    EnviarAlmacen("REPARACION")
                Case Else
                    Throw New Exception("No Puede Realizar este Movimiento")
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub pic_Baja_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pic_Baja.DragDrop
        Try
            If grid.Name = "grid_Baja" Then
                Me.Cursor = Cursors.Default
            Else
                If grid.Name = "grid_Almacen" Then
                    Enviar("BAJA")
                ElseIf grid.Name = "grid_Reencauche" Then
                    Enviar("BAJA")
                Else
                    Throw New Exception("Los neumáticos deben estar en almacén")
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub pic_Venta_DragDrop(sender As Object, e As DragEventArgs) Handles pic_Venta.DragDrop
        Try
            If grid.Name = "grid_Venta" Then
                Me.Cursor = Cursors.Default
            Else
                If grid.Name = "grid_Baja" Then
                    Enviar("VENTA")
                Else
                    Throw New Exception("Los neumáticos deben estar en baja")
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub pic_Almacen_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles _
    pic_Almacen.DragEnter, pic_Reencauche.DragEnter, pic_Reparar.DragEnter, pic_Baja.DragEnter, pic_Venta.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Bitmap)) Then
            ' Si presionó la tecla Ctrl durante la operación Arrastrar, llevar a cabo
            ' la operación Copiar. En caso contrario, ejecutar la operación Mover.
            If (e.KeyState And CtrlMask) = CtrlMask Then
                e.Effect = DragDropEffects.Copy
            Else
                e.Effect = DragDropEffects.Move
            End If
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub grid_Almacen_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grid_Almacen.DoubleClickRow
        cargarVehiculo(sender)
    End Sub

    Private Sub grid_Reencauche_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grid_Reencauche.DoubleClickRow
        cargarVehiculo(sender)
    End Sub

    Private Sub grid_Reparacion_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grid_Reparacion.DoubleClickRow
        cargarVehiculo(sender)
    End Sub

    Private Sub grid_Baja_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grid_Baja.DoubleClickRow
        cargarVehiculo(sender)
    End Sub

    Private Sub grid_Venta_DoubleClick(sender As Object, e As EventArgs) Handles grid_Venta.DoubleClick
        cargarVehiculo(sender)
    End Sub

    Private Sub grid_Almacen_BeforeColRegionScroll(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeColRegionScrollEventArgs) Handles grid_Almacen.BeforeColRegionScroll
        If Not e.NewState.IsActiveScrollRegion Then
            grid_Almacen.Selected.Rows.Clear()
        End If
    End Sub

    Private Sub grid_Almacen_BeforeRowRegionScroll(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowRegionScrollEventArgs) Handles grid_Almacen.BeforeRowRegionScroll
        If Not e.NewState.IsActiveScrollRegion Then
            grid_Almacen.Selected.Rows.Clear()
        End If
    End Sub

    Private Sub grid_Reencauche_BeforeColRegionScroll(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeColRegionScrollEventArgs) Handles grid_Reencauche.BeforeColRegionScroll
        If Not e.NewState.IsActiveScrollRegion Then
            grid_Reencauche.Selected.Rows.Clear()
        End If
    End Sub

    Private Sub grid_Reencauche_BeforeRowRegionScroll(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowRegionScrollEventArgs) Handles grid_Reencauche.BeforeRowRegionScroll
        If Not e.NewState.IsActiveScrollRegion Then
            grid_Reencauche.Selected.Rows.Clear()
        End If
    End Sub

    Private Sub grid_Reparacion_BeforeColRegionScroll(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeColRegionScrollEventArgs) Handles grid_Reparacion.BeforeColRegionScroll
        If Not e.NewState.IsActiveScrollRegion Then
            grid_Reparacion.Selected.Rows.Clear()
        End If
    End Sub

    Private Sub grid_Reparacion_BeforeRowRegionScroll(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowRegionScrollEventArgs) Handles grid_Reparacion.BeforeRowRegionScroll
        If Not e.NewState.IsActiveScrollRegion Then
            grid_Reparacion.Selected.Rows.Clear()
        End If
    End Sub

    Private Sub grid_Baja_BeforeColRegionScroll(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeColRegionScrollEventArgs) Handles grid_Baja.BeforeColRegionScroll
        If Not e.NewState.IsActiveScrollRegion Then
            grid_Baja.Selected.Rows.Clear()
        End If
    End Sub

    Private Sub grid_Baja_BeforeRowRegionScroll(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowRegionScrollEventArgs) Handles grid_Baja.BeforeRowRegionScroll
        If Not e.NewState.IsActiveScrollRegion Then
            grid_Baja.Selected.Rows.Clear()
        End If
    End Sub

    Private Sub grid_Venta_BeforeColRegionScroll(sender As Object, e As BeforeColRegionScrollEventArgs) Handles grid_Venta.BeforeColRegionScroll
        If Not e.NewState.IsActiveScrollRegion Then
            grid_Venta.Selected.Rows.Clear()
        End If
    End Sub

    Private Sub grid_Venta_BeforeRowRegionScroll(sender As Object, e As BeforeRowRegionScrollEventArgs) Handles grid_Venta.BeforeRowRegionScroll
        If Not e.NewState.IsActiveScrollRegion Then
            grid_Venta.Selected.Rows.Clear()
        End If
    End Sub

    Private Sub btnGrabarLugar_Click(sender As Object, e As EventArgs) Handles btnGrabarLugar.Click
        Try
            If oeVidaNeumatico.Id <> "" Then
                If MessageBox.Show("¿Desea Cambiar de Lugar al Neumatico?", "Mensaje de Sistema", _
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim _indlugar = cboLugar.SelectedIndex
                    If oeVidaNeumatico.IndLugar <> _indlugar Then
                        oeVidaNeumatico.TipoOperacion = "L"
                        oeVidaNeumatico.IndLugar = _indlugar
                        oeVidaNeumatico.PrefijoID = gs_PrefijoIdSucursal '@0001
                        olVidaNeumatico.Guardar(oeVidaNeumatico)
                        CargarGrids()
                    Else
                        Throw New Exception("Seleccione un Lugar Diferente para Actualizar")
                    End If
                End If
            Else
                Throw New Exception("Seleccione un Neumatico para Actualizar Lugar")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_MovimientoNeumatico_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

#End Region

#Region "Metodos"

    Sub CargarGrids()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            r_CargarAlmacen()
            r_CargarReencauche()
            r_CargarReparacion()
            r_CargarBaja()
            r_CargarVenta()
        Catch ex As Exception
            Throw ex
        Finally
            Cursor = Cursors.Default
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub r_CargarAlmacen()
        'Listar llantas que estan desmontadas
        Try
            oeVidaNeumatico = New e_VidaNeumatico
            oeVidaNeumatico.Vigente = 1
            oeVidaNeumatico.Ubicacion = "ALMACEN"
            oeVidaNeumatico.EstadoActual = "DES"
            oeVidaNeumatico.FechaIngreso = Date.Parse("01/01/1901")
            oeVidaNeumatico.Activo = True
            lstVidaNeumaticoALM = olVidaNeumatico.Listar(oeVidaNeumatico)
            grid_Almacen.DataSource = lstVidaNeumaticoALM
            grid_Almacen.DataBind()
            etiAlmacen.TextAlign = ContentAlignment.MiddleCenter
            etiAlmacen.Text = "ALMACEN (" & grid_Almacen.Rows.Count & ")"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub r_CargarReencauche()
        'Listar llantas que estan desmontadas
        Try
            oeVidaNeumatico = New e_VidaNeumatico
            oeVidaNeumatico.Vigente = 1
            oeVidaNeumatico.Ubicacion = "REENCAUCHE"
            oeVidaNeumatico.EstadoActual = "DES"
            oeVidaNeumatico.FechaIngreso = Date.Parse("01/01/1901")
            oeVidaNeumatico.Activo = True
            lstVidaNeumaticoREE = olVidaNeumatico.Listar(oeVidaNeumatico)
            grid_Reencauche.DataSource = lstVidaNeumaticoREE
            grid_Reencauche.DataBind()
            etiReencauche.TextAlign = ContentAlignment.MiddleCenter
            etiReencauche.Text = "REENCAUCHE (" & grid_Reencauche.Rows.Count & ")"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub r_CargarReparacion()
        'Listar llantas que estan desmontadas
        Try
            oeVidaNeumatico = New e_VidaNeumatico
            oeVidaNeumatico.Vigente = 1
            oeVidaNeumatico.Ubicacion = "REPARACION"
            oeVidaNeumatico.EstadoActual = "DES"
            oeVidaNeumatico.FechaIngreso = Date.Parse("01/01/1901")
            oeVidaNeumatico.Activo = True
            lstVidaNeumaticoREP = olVidaNeumatico.Listar(oeVidaNeumatico)
            grid_Reparacion.DataSource = lstVidaNeumaticoREP
            grid_Reparacion.DataBind()
            etiReparacion.TextAlign = ContentAlignment.MiddleCenter
            etiReparacion.Text = "REPARACION (" & grid_Reparacion.Rows.Count & ")"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub r_CargarBaja()
        'Listar llantas que estan desmontadas
        Try
            oeVidaNeumatico = New e_VidaNeumatico
            oeVidaNeumatico.Vigente = 1
            oeVidaNeumatico.Ubicacion = "BAJA"
            oeVidaNeumatico.EstadoActual = "DES"
            oeVidaNeumatico.FechaIngreso = Date.Parse("01/01/1901")
            oeVidaNeumatico.Activo = True
            lstVidaNeumaticoBAJ = olVidaNeumatico.Listar(oeVidaNeumatico)
            grid_Baja.DataSource = lstVidaNeumaticoBAJ
            grid_Baja.DataBind()
            etiBaja.TextAlign = ContentAlignment.MiddleCenter
            etiBaja.Text = "BAJA (" & grid_Baja.Rows.Count & ")"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub r_CargarVenta()
        Try
            oeVidaNeumatico = New e_VidaNeumatico
            oeVidaNeumatico.Vigente = 1
            oeVidaNeumatico.Ubicacion = "VENTA"
            oeVidaNeumatico.EstadoActual = "VEN"
            oeVidaNeumatico.FechaIngreso = Date.Parse("01/01/1901")
            oeVidaNeumatico.Activo = True
            lstVidaNeumaticoVEN = olVidaNeumatico.Listar(oeVidaNeumatico)
            grid_Venta.DataSource = lstVidaNeumaticoVEN
            grid_Venta.DataBind()
            eti_Venta.TextAlign = ContentAlignment.MiddleCenter
            eti_Venta.Text = "VENTA (" & grid_Venta.Rows.Count & ")"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub Enviar(ByVal Operacion As String)
        With grid
            If .Name.Substring(5, 3).ToString.ToUpper = "BAJ" Then
                '    If .GetData(.Row, 3) Then
                '        MessageBox.Show("Neumatico ya Ha sido Vendido", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                '        Exit Sub
                '    End If
            End If

            Dim frm As New frm_EnviarNeumatico(Operacion, .ActiveRow.Cells("Id").Value.ToString, _
                                                .ActiveRow.Cells("CodigoNeumatico").Value.ToString, _
                                                 grid.Name.Substring(5, 3).ToString.ToUpper)
            frm.StartPosition = FormStartPosition.CenterScreen
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.OnLoad(New System.EventArgs)
            End If
        End With
    End Sub

    Sub EnviarAlmacen(ByVal ls_EstadoInicial As String)
        Try
            With grid

                Dim frm As New frm_VidaNeumatico(.ActiveRow.Cells("IdNeumatico").Value.ToString, _
                                                 .ActiveRow.Cells("CodigoNeumatico").Value.ToString, _
                                                 .ActiveRow.Cells("Id").Value.ToString, _
                                                 ls_EstadoInicial, _
                                                 .ActiveRow.Cells("IndLugar").Value.ToString, _
                                                 .ActiveRow.Cells("IndLog").Value.ToString _
                                                 )
                frm.StartPosition = FormStartPosition.CenterScreen
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.OnLoad(New System.EventArgs)
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Sub cargarVehiculo(ByVal grilla As UltraGrid)
        Try
            With grilla
                If .Rows.Count > 0 Then
                    oeVidaNeumatico = New e_VidaNeumatico
                    oeVidaNeumatico.Activo = True
                    oeVidaNeumatico.Vigente = 1
                    oeVidaNeumatico.Id = .ActiveRow.Cells("Id").Value.ToString
                    oeVidaNeumatico = olVidaNeumatico.Obtener(oeVidaNeumatico)

                    Dim _IdNeumatico As String = oeVidaNeumatico.IdNeumatico
                    Me.txtCodigo.Text = oeVidaNeumatico.CodigoNeumatico
                    Me.txtDiseño.Text = oeVidaNeumatico.Diseño
                    Me.txtMarca.Text = oeVidaNeumatico.Marca
                    Me.txtMedida.Text = oeVidaNeumatico.Medida
                    Dim cad As String = ""
                    Select Case oeVidaNeumatico.Condicion
                        Case "NVO"
                            cad = "NUEVO"
                        Case "USD"
                            cad = "USADO"
                        Case "REE"
                            cad = "REENCAUCHADO"
                    End Select
                    Me.txtEstado.Text = cad
                    Me.numKilometraje.Value = oeVidaNeumatico.Kilometraje
                    Me.cboLugar.SelectedIndex = oeVidaNeumatico.IndLugar
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

End Class
