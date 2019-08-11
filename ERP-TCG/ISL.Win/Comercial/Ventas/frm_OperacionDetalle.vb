Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_OperacionDetalle
    Inherits frm_MenuPadre

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_OperacionDetalle = Nothing
    Private Shared Operacion As String
    Private Estado As String

    ''' <summary>
    ''' Instancia unica de Formulario: frm_OperacionDetalle
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    '''

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_OperacionDetalle()
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Declaración de variables"

    Dim oeOperacionDetalle As e_OperacionDetalle
    Dim olOperacion As l_Operacion
    Dim _ingresando_datos As Boolean = False
    Dim Opcion As Boolean
    Dim olViajeTercero As l_ViajesTerceros
    Dim oeContratoTercero As e_ViajesTerceros
    Dim olIgv As l_Impuesto
    Dim oeIgv As e_Impuesto

    Dim olTrabajadorSeguridad As l_TrabajadorSeguridad

    Dim FechaServidor As Date = Now.Date
    Dim ProcesoNegocio As String = "CONTRATO TERCEROS"
    Dim olActividadUsuario As l_ActividadRestringido_Usuario
    Dim oeActividadUsuario As e_ActividadRestringida_Usuario

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Operacion = "Inicializa"
        Try
            If ValidarFechaInicioFin(fecDesde, fecHasta) Then
                If rbOrdenTrabajo.Checked Then Listar("6")
                If rbContratoTercero.Checked Then Listar("8")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Operacion = "Nuevo"
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        MyBase.Eliminar()
    End Sub

    Public Overrides Sub Salir()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            MyBase.Salir()
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If rbOrdenTrabajo.Checked Then
                If griLista.Rows.Count = 0 Then
                    Throw New Exception("No hay ningún Registro de Ordenes de Trabajo para exportar al Excel")
                End If
                Exportar_Excel(griLista)
            Else
                If griContratoTercero.Rows.Count = 0 Then
                    Throw New Exception("No hay ningún Contrato de TErcero para exportar al Excel")
                End If
                Exportar_Excel(griContratoTercero)
            End If

            MyBase.Exportar()
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            ugb_Espera.Visible = False
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_OperacionDetalle_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub frm_OperacionDetalle_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Select Case Operacion
            Case "Nuevo"
                MyBase.Nuevo()
            Case "Editar"
                MyBase.Editar()
            Case "Inicializa"
                ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)
        End Select
    End Sub

    Private Sub frm_OperacionDetalle_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_OperacionDetalle_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub frm_OperacionDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oeIgv = New e_Impuesto
        olIgv = New l_Impuesto
        olTrabajadorSeguridad = New l_TrabajadorSeguridad
        LlenaCombos()
        ControlRangoFechaInicializa()
        cboEstadoCarga.SelectedIndex = 0
        FechaServidor = ObtenerFechaServidor()
        oeIgv = olIgv.IGV(FechaServidor.Date)
        CargarActividadesRestringidas()
    End Sub

    Private Sub txtSerie_Validated(sender As Object, e As EventArgs) Handles txtSerie.Validated
        If txtSerie.Text <> "" Then
            txtSerie.Text = FormatoDocumento(txtSerie.Text, 4)
        End If
    End Sub

    Private Sub txtNumero_Validated(sender As Object, e As EventArgs) Handles txtNumero.Validated
        If txtNumero.Text <> "" Then
            txtNumero.Text = FormatoDocumento(txtNumero.Text, 10)
        End If
    End Sub

    Private Sub btnActualizarMasiva_Click(sender As Object, e As EventArgs) Handles btnActualizarMasiva.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim Contador As Integer = 0
            If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "ACTUALIZAR LISTA CARGAS") Then
                If rbOrdenTrabajo.Checked Then
                    If griLista.Rows.Count > 0 Then
                        If MessageBox.Show("Se va ingresar la Factura/Boleta para todas las Cargas de Operaciones en lista activa Docuemento: " & txtSerie.Text.Trim & "-" & txtNumero.Text.Trim, _
                                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            ugb_Espera.Visible = True
                            Application.DoEvents()
                            Cursor.Current = Cursors.WaitCursor
                            Cursor.Show()
                            If griLista.Rows.Count > 0 Then
                                For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLista.Rows.Where(Function(item) item.Cells("Seleccion").Value = True And item.Cells("Carga").Value = "GENERADA").ToList
                                    Fila.Cells("Destino").Value = txtSerie.Text.Trim & "-" & txtNumero.Text.Trim
                                    Fila.CellAppearance.BackColor = colorCambio.Value
                                    Contador += 1
                                Next
                            End If
                            ugb_Espera.Visible = False
                        End If
                    End If
                Else
                    If griContratoTercero.Rows.Count > 0 Then
                        If MessageBox.Show("Se va ingresar la Factura/Boleta para todas las Cargas de Terceros en lista seleccionada: " & txtSerie.Text.Trim & "-" & txtNumero.Text.Trim, _
                                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                            If griContratoTercero.Rows.Count > 0 Then
                                For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griContratoTercero.Rows.Where(Function(item) item.Cells("Seleccion").Value = True And item.Cells("ClienteFinal").Value = "").ToList
                                    Fila.Cells("Moneda").Value = txtSerie.Text.Trim
                                    Fila.Cells("Glosa").Value = txtNumero.Text.Trim
                                    Fila.Cells("ClienteFinal").Value = "GENERADA"
                                    Fila.CellAppearance.BackColor = colorCambio.Value
                                    Contador += 1
                                Next
                            End If
                        End If
                    End If
                End If
                If Contador = 0 Then
                    Throw New Exception("Seleccione los viajes que se va actualizar")
                End If
            Else
                Throw New Exception("Usted no tiene permisos para realizar esta Operacion, Consulte con el Area de Operaciones")
            End If
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnGuardarMasiva_Click(sender As Object, e As EventArgs) Handles btnGuardarMasiva.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim IdViajeOperacion As String = ""
            Dim OperacionesDetalle As String = ""
            Dim contador As Integer = 0
            oeOperacionDetalle = New e_OperacionDetalle
            olOperacion = New l_Operacion
            If rbOrdenTrabajo.Checked Then
                If griLista.Rows.Count > 0 Then
                    oeOperacionDetalle.IdOperacion = cboEstadoCarga.Text
                    If gUsuarioSGI.oeArea.Nombre = gNombreAreaCoordinacionSupervisionOperacion Or gUsuarioSGI.oeArea.Nombre = gNombreAreaInformaticaSistemas Then
                        If oeOperacionDetalle.IdOperacion = "ENVIADA" Then
                            Throw New Exception("Usted no puede utilizar el estado --> ENVIADO")
                        End If
                        For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLista.Rows.Where(Function(Item) Item.Cells("Seleccion").Value = True And Item.Cells("Carga").Value = "GENERADA").ToList
                            IdViajeOperacion = fila.Cells("Id").Value
                            OperacionesDetalle = OperacionesDetalle & "'" & IdViajeOperacion & "',"
                            contador += 1
                        Next
                    Else
                        If gUsuarioSGI.oeArea.Nombre = gNombreAreaAdministracion Or gUsuarioSGI.oeArea.Nombre = gNombreAreaInformaticaSistemas Then
                            If oeOperacionDetalle.IdOperacion = "GENERADA" Then
                                Throw New Exception("Usted no puede Utilizar el estado --> GENERADA")
                            End If
                            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLista.Rows.Where(Function(Item) Item.Cells("Seleccion").Value = True And Item.Cells("Carga").Value = "ASIGNADA").ToList
                                IdViajeOperacion = fila.Cells("Id").Value
                                OperacionesDetalle = OperacionesDetalle & "'" & IdViajeOperacion & "',"
                                contador += 1
                            Next
                        End If
                    End If
                    If contador = 0 Then
                        Throw New Exception("Seleccione las ordenes con viajes que se va actualizar")
                    End If
                    With oeOperacionDetalle
                        .TipoOperacion = "T"
                        .Origen = txtSerie.Text.Trim
                        .Destino = txtNumero.Text.Trim
                        .Glosa = OperacionesDetalle.Substring(0, OperacionesDetalle.Length - 1)
                        .UsuarioCreacion = gUsuarioSGI.Id
                    End With
                    olOperacion.GuardarOperacionDetalle(oeOperacionDetalle)
                End If
            Else
                If griContratoTercero.Rows.Count > 0 Then
                    oeOperacionDetalle.IdOperacion = cboEstadoCarga.Text
                    If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "AGREGAR DOCUMENTO") And oeOperacionDetalle.IdOperacion <> "ENVIADA" Then 'SOLO OPERACIONES
                        If oeOperacionDetalle.IdOperacion = "ENVIADA" Then
                            Throw New Exception("Usted no puede utilizar el estado --> ENVIADO")
                        End If
                        For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griContratoTercero.Rows.Where(Function(Item) Item.Cells("Seleccion").Value = True And Item.Cells("ClienteFinal").Value = "GENERADA").ToList
                            IdViajeOperacion = fila.Cells("Id").Value
                            OperacionesDetalle = OperacionesDetalle & "'" & IdViajeOperacion & "',"
                            cboProveedor.Text = fila.Cells("Comisionista").Value
                            contador += 1
                        Next
                    Else
                        If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "ENVIAR DOCUMENTO") And oeOperacionDetalle.IdOperacion = "ENVIADA" Then
                            If oeOperacionDetalle.IdOperacion = "GENERADA" Then
                                Throw New Exception("Usted no puede utilizar el estado --> GENERADA")
                            End If
                            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griContratoTercero.Rows.Where(Function(Item) Item.Cells("Seleccion").Value = True And Item.Cells("ClienteFinal").Value = "ASIGNADA").ToList
                                IdViajeOperacion = fila.Cells("Id").Value
                                OperacionesDetalle = OperacionesDetalle & "'" & IdViajeOperacion & "',"
                                cboProveedor.Text = fila.Cells("Comisionista").Value
                                contador += 1
                                oeOperacionDetalle.IdOperacion = "ENVIADO"
                            Next
                        End If
                    End If
                    If contador = 0 Then
                        Throw New Exception("Seleccione los contratos con viajes que se va actualizar")
                    End If
                    With oeOperacionDetalle
                        .TipoOperacion = "D"
                        .Origen = txtSerie.Text.Trim
                        .Destino = txtNumero.Text.Trim
                        .Glosa = OperacionesDetalle.Substring(0, OperacionesDetalle.Length - 1)
                        .UsuarioCreacion = gUsuarioSGI.Id
                    End With
                    olOperacion.GuardarOperacionDetalle(oeOperacionDetalle)
                End If
            End If
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
            Consultar(True)
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If rbOrdenTrabajo.Checked Then Listar("7")
        If rbContratoTercero.Checked Then Listar("9")
    End Sub

    Private Sub CheckedChanged(sender As Object, e As EventArgs) Handles rbOrdenTrabajo.CheckedChanged, rbContratoTercero.CheckedChanged
        If rbOrdenTrabajo.Checked Then
            tabCargaOperacion.Tabs(0).Selected = True
            tabCargaOperacion.Tabs(1).Enabled = False
            tabCargaOperacion.Tabs(0).Enabled = True
        Else
            tabCargaOperacion.Tabs(1).Selected = True
            tabCargaOperacion.Tabs(0).Enabled = False
            tabCargaOperacion.Tabs(1).Enabled = True
        End If
    End Sub

    Private Sub griContratoTercero_CellChange(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griContratoTercero.CellChange
        griContratoTercero.UpdateData()
    End Sub

    Private Sub griContratoTercero_ClickCellButton(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griContratoTercero.ClickCellButton
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            olActividadUsuario = New l_ActividadRestringido_Usuario
            oeActividadUsuario = New e_ActividadRestringida_Usuario
            oeContratoTercero = New e_ViajesTerceros
            olViajeTercero = New l_ViajesTerceros
            Dim Mensaje As String = ""
            Select Case e.Cell.Column.Key
                Case "Cantidad"
                    With oeActividadUsuario
                        .TipoOperacion = "0"
                        .Id = gAccionSistema.ACTUALIZAR.ToString
                        .IdActividadRestringida = ProcesoNegocio
                        .IdUsuario = gUsuarioSGI.Id
                    End With
                    If olActividadUsuario.Listar(oeActividadUsuario).Count > 0 Then
                        If griContratoTercero.ActiveRow.Cells("Carga").Value <> "VIAJE" And griContratoTercero.ActiveRow.Cells("ClienteFinal").Value <> "HABILITADA" Then
                            Dim FU As Double = 0
                            FU = griContratoTercero.ActiveRow.Cells("PesoToneladas").Value
                            With oeContratoTercero
                                .TipoOperacion = "D"
                                .Cantidad = griContratoTercero.ActiveRow.Cells("Cantidad").Value
                                .SubTotal = (FU.ToString("###,##0.00") * .Cantidad).ToString("###,##0.00")
                                .Igv = (.SubTotal.ToString("###,##0.00") * oeIgv.Porcentaje).ToString("###,##0.00")
                                .TotalFlete = .FleteCalcula.ToString("###,##0.00")
                                griContratoTercero.ActiveRow.Cells("Saldo").Value = .SubTotal
                                griContratoTercero.ActiveRow.Cells("PesoToneladasCarga").Value = .Igv
                                griContratoTercero.ActiveRow.Cells("PesoToneladasDescarga").Value = .TotalFlete
                            End With
                            Mensaje = "OK"
                        Else
                            Throw New Exception("No se puede ingresar su informacion, Este servicio de carga ya fue procesado")
                        End If
                    End If
                Case "IdDemanda"
                    With oeActividadUsuario
                        .TipoOperacion = "0"
                        .Id = gAccionSistema.APROBAR.ToString
                        .IdActividadRestringida = ProcesoNegocio
                        .IdUsuario = gUsuarioSGI.Id
                    End With
                    If olActividadUsuario.Listar(oeActividadUsuario).Count > 0 Then
                        If griContratoTercero.ActiveRow.Cells("Facturado").Value = 0 And _
                            griContratoTercero.ActiveRow.Cells("ClienteFinal").Value <> "ENVIADO" And _
                            griContratoTercero.ActiveRow.Cells("PagoContraEntrega").Value <> "1" Then
                            oeContratoTercero = New e_ViajesTerceros
                            With oeContratoTercero
                                .TipoOperacion = "N"
                                .Comision = griContratoTercero.ActiveRow.Cells("Comision").Value
                                .AdelantoFlete = griContratoTercero.ActiveRow.Cells("Consolidado").Value
                            End With
                            Mensaje = "OK"
                        Else
                            Throw New Exception("No se puede Aprobar el Contrato, Informacion ya fue procesado")
                        End If
                    Else
                        Throw New Exception("Usted no tiene permisos para aprobar contratos, Consulte con su jefe inmediato")
                    End If
                Case "ClienteFinal"
                    Dim formulario As frm_ReporteContratoTercero
                    formulario = frm_ReporteContratoTercero
                    formulario.CargarDatos(griContratoTercero.ActiveRow.Cells("Id").Value)
                    formulario.ShowDialog()
                    ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)
                Case "Destino"
                    oeContratoTercero = New e_ViajesTerceros
                    With oeContratoTercero
                        .TipoOperacion = "R"
                        .Glosa = griContratoTercero.ActiveRow.Cells("Destino").Value
                    End With
                    Mensaje = "OK"
                Case "IdOperacion"
                    oeContratoTercero = New e_ViajesTerceros
                    With oeContratoTercero
                        .TipoOperacion = "O"
                        .Observacion = griContratoTercero.ActiveRow.Cells("IdOperacion").Value
                    End With
                    Mensaje = "OK"
                Case "Consolidado"
                    If (gUsuarioSGI.leARUsuario.Where(Function(item) item.IdActividadNegocio.Trim = gActividadNegocio.AdelantoFlete.ToString And
                                                  item.AccionSistema = gAccionSistema.ACTUALIZAR.ToString And item.IdProcesoNegocio = pProcesoNegocio)).ToList.Count > 0 Then
                        If griContratoTercero.ActiveRow.Cells("Facturado").Value = 0 And _
                            griContratoTercero.ActiveRow.Cells("ClienteFinal").Value <> "ENVIADO" Then
                            oeContratoTercero = New e_ViajesTerceros
                            With oeContratoTercero
                                .TipoOperacion = "A"
                                .Comision = griContratoTercero.ActiveRow.Cells("Comision").Value
                                .AdelantoFlete = griContratoTercero.ActiveRow.Cells("Consolidado").Value
                            End With
                            Mensaje = "OK"
                        Else
                            Throw New Exception("No se puede ACTUALIZAR ADELANTO, Informacion ya fue procesado")
                        End If
                    Else
                        Throw New Exception("Usted no tiene PERMISOS para ACTUALIZAR ADELANTO, Consulte con su jefe inmediato")
                    End If
            End Select
            If Mensaje = "OK" Then
                oeContratoTercero.Id = griContratoTercero.ActiveRow.Cells("Id").Value
                oeContratoTercero.UsuarioCrea = gUsuarioSGI.Id
                olViajeTercero.Guardar(oeContratoTercero)
                mensajeEmergente.Confirmacion("La Informacion ha sido grabada Satisfactoriamente", True)
                griContratoTercero.ActiveRow.CellAppearance.BackColor = Me.colorCambio.Color
                griContratoTercero.UpdateData()
            End If
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub griLista_CellChange(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griLista.CellChange
        griLista.UpdateData()
    End Sub

    Private Sub griContratoTercero_BeforeRowsDeleted(sender As Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griContratoTercero.BeforeRowsDeleted
        e.Cancel = True
        e.DisplayPromptMsg = False
    End Sub

#End Region

#Region "Métodos"

    Private Sub InicializarComboPro()
        Try
            Me.cboProveedor.ValueMember = "Id"
            Me.cboProveedor.DisplayMember = "Nombre"
            With cboProveedor.DisplayLayout.Bands(0)
                .Columns("Id").Hidden = True
                '.Columns("Nombre").Hidden = True
                '.Columns("Descripcion").Hidden = True
                '.Columns("IdPersona").Hidden = True
                '.Columns("IdEmpresa").Hidden = True
                '.Columns("FechaActividad").Hidden = True
                '.Columns("UsuarioCreacion").Hidden = True
                '.Columns("Activo").Hidden = True
                '.Columns("Seleccion").Hidden = True
                '.Columns("Email").Hidden = True
                '.Columns("Contacto").Hidden = True
                .Columns("Nombre").Header.Caption = "Proveedor"
                .Columns("Descripcion").Header.Caption = "RUC/DNI"
                .Columns("Descripcion").Header.VisiblePosition = 0
                .Columns("Nombre").Header.VisiblePosition = 1
                .Columns("Descripcion").Width = 120
                .Columns("Nombre").Width = 450
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub InicializarComboCliente()
        Try
            Me.cboCliente.ValueMember = "Id"
            Me.cboCliente.DisplayMember = "Nombre"
            With cboCliente.DisplayLayout.Bands(0)
                .Columns("Id").Hidden = True
                '.Columns("Codigo").Hidden = True
                '.Columns("TipoPersonaEmpresa").Hidden = True
                '.Columns("IdPersona").Hidden = True
                '.Columns("IdEmpresa").Hidden = True
                '.Columns("Comisionista").Hidden = True
                '.Columns("FechaActividad").Hidden = True
                '.Columns("UsuarioCreacion").Hidden = True
                '.Columns("Activo").Hidden = True
                '.Columns("oeEmpresa").Hidden = True
                '.Columns("oepersona").Hidden = True
                .Columns("Nombre").Header.Caption = "Cliente"
                .Columns("Descripcion").Header.Caption = "RUC/DNI"
                .Columns("Descripcion").Header.VisiblePosition = 0
                .Columns("Nombre").Header.VisiblePosition = 1
                .Columns("Descripcion").Width = 120
                .Columns("Nombre").Width = 450
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LlenaCombos()
        'Dim loProveedor As New List(Of e_Proveedor)
        'Dim oeProveedor As New e_Proveedor
        'Dim olProveedor As New l_Proveedor
        'oeProveedor.TipoOperacion = "5"
        'loProveedor.AddRange(olProveedor.Listar(oeProveedor))
        With cboProveedor
            .ValueMember = "Id"
            .DisplayMember = "Nombre"
            .DataSource = ProveedorPublic
        End With
        InicializarComboPro()
        'Dim oeCliente As New e_Cliente
        'Dim loCliente As New List(Of e_Cliente)
        'Dim olCliente As New l_Cliente
        'oeCliente.Activo = True
        'oeCliente.TipoPersonaEmpresa = 2
        'loCliente.AddRange(olCliente.Listar(oeCliente))
        With cboCliente
            .ValueMember = "Id"
            .DisplayMember = "Nombre"
            .DataSource = ClientesPublic
        End With
        InicializarComboCliente()
    End Sub

    Public Sub Listar(Tipo As String)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeOperacionDetalle = New e_OperacionDetalle
            olOperacion = New l_Operacion
            If rbOrdenTrabajo.Checked Then
                If Tipo = "6" Then
                    With oeOperacionDetalle
                        .FechaDesde = fecDesde.Value
                        .FechaHasta = fecHasta.Value
                        .IdDemanda = ""
                        .Cliente = cboCliente.Value
                        .Proveedor = cboProveedor.Value
                    End With
                Else
                    With oeOperacionDetalle
                        .FechaDesde = ""
                        .FechaHasta = ""
                        .IdDemanda = txtSerie.Text
                        .Cliente = txtNumero.Text
                        .Proveedor = cboProveedor.Value
                    End With
                End If
                oeOperacionDetalle.TipoOperacion = Tipo
                griLista.DataSource = olOperacion.ListarOperacionDetalle(oeOperacionDetalle)
                For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLista.Rows
                    Select Case fila.Cells("Carga").Value
                        Case "GENERADA"
                            fila.CellAppearance.BackColor = Me.colorGenerada.Color
                        Case "ASIGNADA"
                            fila.CellAppearance.BackColor = Me.colorAsignada.Color
                        Case "ENVIADA"
                            fila.CellAppearance.BackColor = Me.colorEnviada.Color
                        Case "HABILITADA"
                            fila.CellAppearance.BackColor = Me.colorHabilitada.Color
                    End Select

                Next
                'Ubica el cursor el el primer registro de la grilla
                If griLista.Rows.Count > 0 Then
                    griLista.Focus()
                    griLista.Rows.Item(0).Selected = True
                    ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)
                End If
                CalcularTotales(griLista, "FleteUnitario")
                griLista.Focus()
            Else
                If Tipo = 8 Then
                    With oeOperacionDetalle
                        .FechaDesde = fecDesde.Value
                        .FechaHasta = fecHasta.Value
                        .IdDemanda = ""
                        .Cliente = cboCliente.Value
                        .Proveedor = cboProveedor.Value
                    End With
                Else
                    With oeOperacionDetalle
                        .FechaDesde = ""
                        .FechaHasta = ""
                        .IdDemanda = txtSerie.Text
                        .Cliente = txtNumero.Text
                        .Proveedor = cboProveedor.Value
                    End With
                End If
                oeOperacionDetalle.TipoOperacion = Tipo
                griContratoTercero.DataSource = olOperacion.ListarOperacionDetalle(oeOperacionDetalle)
                For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griContratoTercero.Rows
                    Select Case fila.Cells("ClienteFinal").Value
                        Case "GENERADA"
                            fila.CellAppearance.BackColor = Me.colorGenerada.Color
                        Case "ASIGNADA"
                            fila.CellAppearance.BackColor = Me.colorAsignada.Color
                        Case "ENVIADO"
                            fila.CellAppearance.BackColor = Me.colorEnviada.Color
                        Case "HABILITADA"
                            fila.CellAppearance.BackColor = Me.colorHabilitada.Color
                    End Select
                    Select Case fila.Cells("PagoContraEntrega").Value
                        Case "0"
                            fila.Cells("IdDemanda").Appearance.BackColor = Me.colorGenerada.Color
                        Case "1"
                            fila.Cells("IdDemanda").Appearance.BackColor = Me.colorHabilitada.Color
                    End Select
                Next
                'Ubica el cursor el el primer registro de la grilla
                If griContratoTercero.Rows.Count > 0 Then
                    griContratoTercero.Focus()
                    griContratoTercero.Rows.Item(0).Selected = True
                    ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)
                End If
                griContratoTercero.Focus()
                CalcularTotales(griContratoTercero, "Saldo", "Cantidad", "FleteUnitario", "Flete", "PesoToneladas", "PesoToneladasCarga", "PesoToneladasDescarga")
            End If
            'InicializaTiempo()
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub ControlRangoFechaInicializa()
        fecDesde.Value = FechaServidor.AddDays(-5)
        fecHasta.Value = FechaServidor.AddDays(+1)
    End Sub

#End Region

End Class