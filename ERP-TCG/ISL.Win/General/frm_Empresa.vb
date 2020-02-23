'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
' @0002 |   2019-09-01  |  CT2010   |   ConsultaRUC
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports ISL.Controles
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinToolbars
Imports Infragistics.Win.UltraWinTabControl

Public Class frm_Empresa
    Inherits frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_Empresa = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Empresa()
        End If
        instancia.Activate()
        Return instancia

    End Function

#End Region

#Region "Definicion de Variables"

    Private Const IdPaisPeru As String = "1CH000001"
    Dim WithEvents oeEmpresa As New e_Empresa
    Dim olEmpresa As New l_Empresa

    Dim olDireccionEmpresaPersona As New l_Direccion_EmpresaPersona

    Dim oeTipoEmpresa As New e_TipoEmpresa
    Dim olTipoEmpresa As New l_TipoEmpresa
    Dim oeDireccionEP As New e_Direccion_EmpresaPersona
    Public leDireccionEP As New List(Of e_Direccion_EmpresaPersona)
    Public leEmail As New List(Of e_Email)
    Public leTelefono As New List(Of e_Telefono)
    Dim oePETipoPago As New e_PersonaEmpresa_TipoPago
    Dim olPETipoPago As New l_PersonaEmpresa_TipoPago
    Public leTipoPago As New List(Of e_PersonaEmpresa_TipoPago)
    Dim oeTipoPago As New e_TipoPago

    Dim _ingresando_datos As Boolean = False

    Dim griTemp As New Grilla
    Dim Tipo As Integer
    Private band As Boolean = False

    Dim BandCbo As Boolean = True
    Dim oeLugar As New e_Lugar, olLugar As New l_Lugar
    Dim lstLugar As New List(Of e_Lugar)
    Dim BandTP As Boolean = False

    Dim oeMovDoc As New e_MovimientoDocumento
    Dim olMovDoc As New l_MovimientoDocumento
    Dim oeCombo As New e_Combo
    Dim olCombo As New l_Combo

    Dim bndRuc As Boolean = False
    Public Shared leContactos As New List(Of e_Persona)

    Private Const URLConsultaSunat As String = "https://e-consultaruc.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias"

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griEmpresa.Rows.Count > 0 Then
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
            MostrarTabs(1, ficEmpresa, 1)
            oeEmpresa = New e_Empresa
            Inicializar()
            oeEmpresa.TipoOperacion = "I"
            oeEmpresa.Modificado = False
            Operacion = "Nuevo"
            txtCodigo.ReadOnly = False
            txtRuc.ReadOnly = False
            mt_ControlBonotoneria()
            txtRuc.Focus()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Mostrar()
            oeEmpresa.TipoOperacion = "A"
            oeEmpresa.Modificado = False
            'agrDatoDireccion.Expanded = False
            ficDetalle.SelectedTab = ficDetalle.Tabs(0)
            Operacion = "Editar"
            If PerfilAsignado(gNombrePerfilAdministrador) Then
                txtCodigo.ReadOnly = False
                txtRuc.ReadOnly = False
            Else
                txtCodigo.ReadOnly = True
                txtRuc.ReadOnly = True
            End If
            mt_ControlBonotoneria()
            txtRuc.Focus()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If Guardando() Then
                ActualizarEmpresasPublicas()
                If BandCbo Then
                    MyBase.Guardar()
                Else
                    'BandCbo = True
                    Me.Close()
                End If
            Else
                MostrarTabs(1, ficEmpresa, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If BandCbo Then
                If oeEmpresa.Modificado Then
                    Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                        Case Windows.Forms.DialogResult.Yes
                            If Guardando() Then
                                MostrarTabs(0, ficEmpresa, 2)
                                _ingresando_datos = False
                                Consultar(True)
                            Else
                                _ingresando_datos = True
                                MostrarTabs(1, ficEmpresa, 1)
                            End If
                        Case Windows.Forms.DialogResult.No
                            MostrarTabs(0, ficEmpresa, 2)
                            _ingresando_datos = False
                            Consultar(True)
                    End Select
                Else
                    MostrarTabs(0, ficEmpresa, 2)
                    _ingresando_datos = False
                End If
                mt_ControlBonotoneria()
            Else
                'BandCbo = True
                Me.Close()
            End If
            
            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With griEmpresa
                If ValidarGrilla(griEmpresa, "Usuario") AndAlso gUsuarioSGI.oeArea.Nombre = gNombreAreaInformaticaSistemas Then
                    oeEmpresa.Id = .ActiveRow.Cells("ID").Value
                    oeEmpresa.CargaCompleta = True
                    oeEmpresa = olEmpresa.Obtener(oeEmpresa)
                    If oeEmpresa.Activo Then
                        If lf_ValidarEliminar() AndAlso MessageBox.Show("Esta seguro de eliminar Empresa: " & _
                                 .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeEmpresa.TipoOperacion = "E"
                            oeEmpresa.UsuarioCreacion = gUsuarioSGI.Id
                            olEmpresa.Eliminar(oeEmpresa)
                            Consultar(True)
                        End If
                    Else
                        Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try

            If griEmpresa.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griEmpresa)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Empresa_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Empresa_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If BandCbo Then
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
        Else
            BandCbo = True
        End If
    End Sub

    Private Sub ComboTipoEmpresa()
        Try
            oeTipoEmpresa.TipoOperacion = String.Empty
            oeTipoEmpresa.Activo = True
            LlenarComboMaestro(cboTipoEmpresa, olTipoEmpresa.Listar(oeTipoEmpresa), 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub frm_Empresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gf_AsignarEventoSeleccionarTexto(Me)
            mt_ControlBonotoneria()
            ComboTipoEmpresa()
            CargarCombo()
            MostrarTabs(0, ficEmpresa)
            Tiempo1.Enabled = False
            InicializaTiempo()
            WebBrowser1.Navigate(URLConsultaSunat)
            WebBrowser1.ScriptErrorsSuppressed = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        oeEmpresa.Codigo = txtCodigo.Text.Trim
    End Sub

    Private Sub txtRuc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRuc.KeyDown
        TeclaPulsada(e)
        ' TextoNumero(e)
    End Sub

    Private Sub txtRuc_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRuc.ValueChanged
        oeEmpresa.Ruc = txtRuc.Text.Trim
        If Operacion = "Nuevo" Then
            If txtRuc.Text.Trim.Length = 11 Then
                Dim _oeEmp As New e_Empresa
                _oeEmp.Ruc = txtRuc.Text.Trim
                _oeEmp.CargaCompleta = True
                _oeEmp = olEmpresa.Obtener(_oeEmp)
                If Not String.IsNullOrEmpty(_oeEmp.Id) Then
                    bndRuc = True
                    oeEmpresa.oeClienteProveedor = _oeEmp.oeClienteProveedor
                    CargarEmpresa(_oeEmp)
                    If Not _oeEmp.Activo Then
                        If MessageBox.Show("La Empresa: " & _oeEmp.Nombre & ", esta Inactivo." & Environment.NewLine & _
                                           "¿Desea Activarla?", "Mensaje del Sistema", MessageBoxButtons.YesNo, _
                                           MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                            oeEmpresa.Activo = True
                        End If
                    End If
                    'oeEmpresa.Activo = _oeEmp.Activo
                    oeEmpresa.TipoOperacion = "A"
                End If
            End If
        End If
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        oeEmpresa.Nombre = txtNombre.Text.Trim
    End Sub

    Private Sub txtAbreviatura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAbreviatura.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtAbreviatura_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbreviatura.ValueChanged
        oeEmpresa.Abreviatura = txtAbreviatura.Text.Trim
    End Sub

    Private Sub cboTipoEmpresa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoEmpresa.ValueChanged
        oeEmpresa.IdTipoEmpresa = cboTipoEmpresa.Value
    End Sub

    Private Sub oeEmpresa_DatoCambiado() Handles oeEmpresa.DatoCambiado
        oeEmpresa.Modificado = True
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            AgregarDireccion()
            If band Then
                If MessageBox.Show("¿Desea seguir Agregando Direcciones?", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    InicializarDireccion()
                Else
                    'agrDatoDireccion.Expanded = False
                End If
            Else
                mensajeEmergente.Confirmacion("Losa Datos de Guardaron Correctamente", True)
                'agrDatoDireccion.Expanded = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Sub

    Private Sub griTelefono_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griTelefono.InitializeLayout
        'System.Type.GetType("System.Boolean")
        'griTelefono.DisplayLayout.Bands(0).Columns("Nombre").MaskInput = "(###) ###-###"
    End Sub

    Private Sub griTelefono_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griTelefono.KeyDown
        TecladoGrilla(griTelefono, e)
    End Sub

    Private Sub griEmail_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griEmail.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show("¿Desea Quitar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub griEmail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griEmail.KeyDown
        TecladoGrilla(griEmail, e)
    End Sub

    Private Sub griTelefono_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griTelefono.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show("¿Desea Quitar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub griTelefono_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griTelefono.CellChange
        Try
            griTelefono.UpdateData()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griEmail_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griEmail.CellChange
        Try
            griEmail.UpdateData()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub verCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcCliente.ValueChanged
        Try
            oeEmpresa.oeClienteProveedor.Cliente = opcCliente.CheckedIndex 'IIf(verCliente.Checked, 1, 0)
            If opcCliente.CheckedIndex <> 2 AndAlso opcProveedor.CheckedIndex <> 2 AndAlso opcComisionista.CheckedIndex <> 2 Then
                cboPais.Value = IdPaisPeru
                cboPais.Enabled = False
            Else
                cboPais.Enabled = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub verProveedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcProveedor.ValueChanged
        Try
            oeEmpresa.oeClienteProveedor.Proveedor = opcProveedor.CheckedIndex  'IIf(verProveedor.Checked, 1, 0)
            If opcProveedor.CheckedIndex <> 2 AndAlso opcCliente.CheckedIndex <> 2 AndAlso opcComisionista.CheckedIndex <> 2 Then
                cboPais.Value = IdPaisPeru
                cboPais.Enabled = False
            Else
                cboPais.Enabled = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub verComisionista_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcComisionista.ValueChanged
        Try
            oeEmpresa.oeClienteProveedor.Comisionista = opcComisionista.CheckedIndex 'IIf(verComisionista.Checked, 1, 0)
            If opcProveedor.CheckedIndex <> 2 AndAlso opcCliente.CheckedIndex <> 2 AndAlso opcComisionista.CheckedIndex <> 2 Then
                cboPais.Value = IdPaisPeru
                cboPais.Enabled = False
            Else
                cboPais.Enabled = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ficDetalle_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles ficDetalle.SelectedTabChanged
        Select Case ficDetalle.SelectedTab.Index
            Case 0
                Tipo = 0
            Case 1
                Tipo = 1
                griTemp = griTelefono
            Case 2
                Tipo = 2
                griTemp = griEmail
        End Select
    End Sub

    Private Sub btnAceptarTP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptarTP.Click
        Try
            oeTipoPago = New e_TipoPago
            oeTipoPago = cboTipoPago.Items(cboTipoPago.SelectedIndex).ListObject
            AgregarTP(oeTipoPago)
            CargarPETipoPago(leTipoPago)
            If MessageBox.Show("Los Datos se guardaron correctamente." & Environment.NewLine & "¿Desea seguir agregando?" _
                               , "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                InicializaTipoPago()
            Else
                agrContenedorTP.Expanded = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCancelarTP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarTP.Click
        agrContenedorTP.Expanded = False
    End Sub

    Private Sub txtRuc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRuc.KeyPress
        TextoNumero(e)
    End Sub

    Private Sub txtRuc_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRuc.Validated
        'Try
        '    Dim oeEmp As New e_Empresa
        '    oeEmp.Ruc = txtRuc.Text.Trim
        '    oeEmp.Ruc
        'Catch ex As Exception
        '    mensajeEmergente.Problema(ex.Message, True)
        'End Try
    End Sub

    Private Sub btnActualizaDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizaDoc.Click
        Try
            If leTipoPago.Count = 0 Then
                Throw New Exception("Ingrese Tipo de Pago para Actualizar los Documentos")
            Else
                Dim letp As New List(Of e_PersonaEmpresa_TipoPago)
                letp = leTipoPago.Where(Function(item) item.IndClienteProveedor = "1").ToList
                If letp.Count = 0 Then Throw New Exception("Ingrese Tipo de Pago para esta Empresa como Cliente")
            End If
            ActualizaDoc()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griEmpresa_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles griEmpresa.KeyPress
        Try
            If griEmpresa.ActiveRow.Band.Index = 0 Then
                If griEmpresa.ActiveRow.Index > -1 AndAlso griEmpresa.ActiveRow.Cells("Abreviatura").Activated Then
                    If e.KeyChar = Chr(13) Then
                        griEmpresa.UpdateData()
                        oeEmpresa = New e_Empresa
                        oeEmpresa.TipoOperacion = "G"
                        oeEmpresa.Id = griEmpresa.ActiveRow.Cells("Id").Value
                        oeEmpresa.Abreviatura = griEmpresa.ActiveRow.Cells("Abreviatura").Value
                        oeEmpresa.PrefijoID = gs_PrefijoIdSucursal '@0001
                        olEmpresa.Guardar(oeEmpresa)
                        ActualizarEmpresasPublicas()
                    End If
                End If
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griEmpresa_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griEmpresa.InitializeLayout
        e.Layout.Bands(0).Columns("Abreviatura").Nullable = Nullable.Nothing
    End Sub

    Private Sub griEmpresa_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griEmpresa.DoubleClick
        If griEmpresa.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griEmpresa_ClickCellButton(sender As Object, e As CellEventArgs) Handles griEmpresa.ClickCellButton
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeEmpresa = New e_Empresa
            With oeEmpresa
                .TipoOperacion = "B"
                .Id = RTrim(griEmpresa.ActiveRow.Cells("Id").Value)
                .UsuarioCreacion = gUsuarioSGI.Id
                .IndAgentePercepcion = griEmpresa.ActiveRow.Cells("IndAgentePercepcion").Value
                .IndAgenteRetencion = griEmpresa.ActiveRow.Cells("IndAgenteRetencion").Value
                .IndBuenContribuyente = griEmpresa.ActiveRow.Cells("IndBuenContribuyente").Value
                .IndCanjeDocumento = griEmpresa.ActiveRow.Cells("IndCanjeDocumento").Value
                .IndAceptaLetras = griEmpresa.ActiveRow.Cells("IndAceptaLetras").Value
                .IndAceptaCheque = griEmpresa.ActiveRow.Cells("IndAceptaCheque").Value
                .IndRelacionada = griEmpresa.ActiveRow.Cells("IndRelacionada").Value
                .Morosidad = griEmpresa.ActiveRow.Cells("Morosidad").Value
                .Credito = griEmpresa.ActiveRow.Cells("Credito").Value
            End With
            oeEmpresa.PrefijoID = gs_PrefijoIdSucursal '@0001
            olEmpresa.Guardar(oeEmpresa)
            griEmpresa.ActiveRow.CellAppearance.BackColor = Me.colorCambio.Color
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub ugb_Finanzas_Click(sender As Object, e As EventArgs) Handles ugb_Finanzas.Click

    End Sub

    Private Sub agrEmpresa_Click(sender As Object, e As EventArgs) Handles agrEmpresa.Click

    End Sub
    Dim oPersona As e_Persona
    Private Sub tsmiAgregar_Click(sender As Object, e As EventArgs) Handles tsmiAgregar.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If ficDetalle.SelectedTab.Key = "tabContactos" Then
                Dim Persona As New frm_Persona
                Persona = Persona.getInstancia()
                Persona.MdiParent = frm_Menu
                Persona.BuscarPersona(leContactos)
                Persona.Show()
            End If
            ugb_Espera.Visible = False
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub griEmpresa_CellChange(sender As Object, e As CellEventArgs) Handles griEmpresa.CellChange
        griEmpresa.UpdateData()
    End Sub

    Private Sub frm_Empresa_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Try
            If frm_Persona.listaContactos IsNot Nothing Then
                Me.griContactos.DataSource = New List(Of e_Persona)
                Me.griContactos.DataSource = leContactos
            End If
            mt_ControlBonotoneria()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Dim opcion As String = ""
    Private Sub tsmiEditar_Click(sender As Object, e As EventArgs) Handles tsmiEditar.Click
        If ficDetalle.SelectedTab.Key = "tabContactos" Then
            opcion = "EC"
            Dim Persona As New frm_Persona
            Persona = Persona.getInstancia()
            Persona.MdiParent = frm_Menu
            Persona.bandContacto = "EC"
            Persona.Show()
            Persona.MostrarContacto(griContactos.ActiveRow.Cells("Id").Value)
        End If
    End Sub

    Private Sub tsmiQuitar_Click(sender As Object, e As EventArgs) Handles tsmiQuitar.Click
        If ficDetalle.SelectedTab.Key = "tabContactos" Then
            If griContactos.ActiveRow.Cells("NombreCompleto").Value.ToString.Length > 0 Then
                If griContactos.Rows.Count > 0 Then griContactos.ActiveRow.Delete()
            End If
        End If
    End Sub

    Private Sub griContactos_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griContactos.BeforeRowsDeleted
        If ficDetalle.SelectedTab.Key = "tabContactos" Then
            e.DisplayPromptMsg = False
            If MessageBox.Show(Me.Text & ": ¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            Else
                '   griContactos.ActiveRow.Cells("Activo").Value = False
            End If
        End If
    End Sub

    Private Sub griEmpresa_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griEmpresa.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            e.Cancel = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub chkIndicadorSGI_CheckedChanged(sender As Object, e As EventArgs)
        If chkIndicadorSGI.Checked Then
            opIndSGI.Enabled = False
        Else
            opIndSGI.Enabled = True
        End If
    End Sub

    Private Sub chkIndicadorSGI_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkIndicadorSGI.CheckedChanged
        If chkIndicadorSGI.Checked Then
            opIndSGI.Enabled = False
        Else
            opIndSGI.Enabled = True
        End If
    End Sub

    Private Async Sub btnObtenerSunat_Click(sender As Object, e As EventArgs) Handles btnObtenerSunat.Click
        Try
            '@0002 Inicio
            'Dim oeEmp As New e_Persona
            'oeEmp = ObtenerDesdeSunat(Me.txtRuc.Value)
            'txtNombre.Text = oeEmp.Nombre
            '@0002 Fin Inicio
            Dim consultaRucSunat As New ConsultaRucSunat()
            Dim contribuyente As New Contribuyente
            contribuyente = Await consultaRucSunat.SunatConsultaRuc(txtRuc.Text)
            txtNombre.Text = contribuyente.RazonSocial
            txtDireccionFiscal.Text = contribuyente.Direccion
            WebBrowser1.Navigate(URLConsultaSunat)
            WebBrowser1.ScriptErrorsSuppressed = True
            '@0002 Fin
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboPais_ValueChanged(sender As Object, e As EventArgs) Handles cboPais.ValueChanged
        Try
            If cboPais.Value = IdPaisPeru Then ' Perú
                Ccpp1.Enabled = True
            Else
                'Ccpp1.Enabled = False '@0001
                Ccpp1.Enabled = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtDireccionFiscal_ValueChanged(sender As Object, e As EventArgs) Handles txtDireccionFiscal.ValueChanged
        oeEmpresa.DireccionFiscal = txtDireccionFiscal.Text
    End Sub

#Region "Eventos Direccion"

    Private Sub mnuDireccion_ToolClick(sender As Object, e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles mnuDireccion.ToolClick
        Try
            Select Case e.Tool.Key
                Case "DirAgregar"
                    InicializarDireccion()
                    oeDireccionEP = New e_Direccion_EmpresaPersona
                    oeDireccionEP.TipoOperacion = "I"
                    MostrarTabs(1, ficDireccion)
                    ControlSubMenu(mnuDireccion, "Dir", 0, 0, 0, 1, 1, 0, 0)
                Case "DirModificar"
                    EditarDireccion()
                Case "DirGrabar"
                    AgregarDireccion()
                    mensajeEmergente.Confirmacion("¡Los Datos se Guardaron Correctamente!", True)
                    IniciaDetalle(griDireccion, mnuDireccion, "Dir", ficDireccion)
                Case "DirCancelar"
                    If MessageBox.Show("¿Desea cancelar la Operacion", "Mensaje de Sistema", MessageBoxButtons.YesNo _
                                       , MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        IniciaDetalle(griDireccion, mnuDireccion, "Dir", ficDireccion)
                    End If
                Case "DirQuitar"
                    QuitarDireccion()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTipoVia_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoVia.ValueChanged
        If cboTipoVia.SelectedIndex > -1 Then
            txtNombreVia.Enabled = IIf(cboTipoVia.Text = "NINGUNO", False, True)
            txtNumero.Enabled = IIf(cboTipoVia.Text = "NINGUNO", False, True)
            txtNumeroInterior.Enabled = IIf(cboTipoVia.Text = "NINGUNO", False, True)
            txtDepartamento.Enabled = IIf(cboTipoVia.Text = "NINGUNO", False, True)
            txtManzana.Enabled = IIf(cboTipoVia.Text = "NINGUNO", False, True)
            txtLote.Enabled = IIf(cboTipoVia.Text = "NINGUNO", False, True)
            txtKilometro.Enabled = IIf(cboTipoVia.Text = "NINGUNO", False, True)
            txtBlock.Enabled = IIf(cboTipoVia.Text = "NINGUNO", False, True)
            txtEtapa.Enabled = IIf(cboTipoVia.Text = "NINGUNO", False, True)
            If cboTipoVia.Text <> "NINGUNO" Then
                CargaNombreDir()
            End If
        Else
            txtNombreVia.Enabled = False : txtNumero.Enabled = False : txtNumeroInterior.Enabled = False
        End If
    End Sub

    Private Sub cboNombreZona_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNombreZona.ValueChanged
        If cboNombreZona.SelectedIndex > -1 Then
            txtNombreZona.Enabled = IIf(cboNombreZona.Text = "NINGUNO", False, True)
            If cboNombreZona.Text <> "NINGUNO" Then
                CargaNombreDir()
            End If
        Else
            txtNumeroInterior.Enabled = False
        End If
    End Sub

    Private Sub txtNombreVia_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombreVia.ValueChanged
        ' oeDireccionEP.oeDireccion.Via = txtNombreVia.Text
        CargaNombreDir()
    End Sub

    Private Sub txtNombreZona_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombreZona.ValueChanged
        'oeDireccionEP.oeDireccion.Zona = txtNombreZona.Text
        CargaNombreDir()
    End Sub

    Private Sub txtNumero_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.ValueChanged
        ' oeDireccionEP.oeDireccion.Numero = cboNumero.Text & " " & txtNumero.Value
        CargaNombreDir()
    End Sub

    Private Sub txtNumeroInterior_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumeroInterior.ValueChanged
        ' oeDireccionEP.oeDireccion.NumeroInterior = "INT. " & txtNumeroInterior.Text
        CargaNombreDir()
    End Sub

    Private Sub txtReferencia_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReferencia.ValueChanged
        '  oeDireccionEP.oeDireccion.Referencia = txtReferencia.Text
        CargaNombreDir()
    End Sub

    Private Sub griDireccion_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles griDireccion.AfterCellUpdate
        Try
            'Dim idDireccion As String = griDireccion.ActiveRow.Cells("Id").Value
            'With griDireccion
            '    If .ActiveRow.Cells("Principal").Activated Then

            '    End If
            '    Select Case e.Cell.Column.Key
            '        Case "Principal"
            '            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In .Rows
            '                If fila.Cells("Id").Value <> idDireccion Then fila.Cells("Principal").Value = False
            '            Next
            '    End Select
            'End With


            ''For Each diremp As e_Direccion_EmpresaPersona In leDireccionEP
            ''    If leDireccionEP.Where(Function(i) i.Principal).ToList.Count > 0 Then
            ''        Throw New Exception("habla blaha")
            ''    End If
            ''Next

            
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griDireccion_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griDireccion.CellChange
        Try
            With griDireccion
                If .ActiveRow.Cells("Principal").Activated Then
                    Dim oe As New e_Direccion_EmpresaPersona
                    oe.Equivale = "2"
                    oe.Id = .ActiveRow.Cells("Id").Value
                    oe = leDireccionEP.Item(leDireccionEP.IndexOf(oe))
                    oe.Principal = Not .ActiveRow.Cells("Principal").Value
                    If oe.TipoOperacion = "" Then oe.TipoOperacion = "A"
                    For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In .Rows
                        If fila.Cells("Nombre").Value <> oe.Nombre Then fila.Cells("Principal").Value = False
                    Next
                    .DataBind()
                    .UpdateData()
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Ccpp1_DatoCambiado(ByVal Id As System.String)
        ' oeDireccionEP.oeDireccion.CCPP = Ccpp1.Id
        'Erick control nuevo para que manejes los centros poblados
        'Ccpp1.Seleccionar(oeDireccionEP.CCPP)
        CargaNombreDir()
    End Sub

    Private Sub griDireccion_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griDireccion.DoubleClick
        If griDireccion.Selected.Rows.Count > 0 Then EditarDireccion()
    End Sub

    Private Sub cmbLugar_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLugar.ValueChanged
        ' If cmbLugar.SelectedIndex > -1 Then oeDireccionEP.oeDireccion.IdLugar = cmbLugar.Value : oeDireccionEP.oeDireccion.Lugar = cmbLugar.Text
    End Sub

    Private Sub Ccpp1_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Ccpp1.Validating
        ' oeDireccionEP.oeDireccion.NombreCCPP = Ccpp1.Departamento1.Nombre & " - " & _
        'Ccpp1.Provincia1.Nombre & " - " & Ccpp1.Distrito1.Nombre & " - " & Ccpp1.CentroPoblado1.Nombre
        ' oeDireccionEP.oeDireccion.NombreUbigeo = Ccpp1.Departamento1.Nombre & " - " & _
        'Ccpp1.Provincia1.Nombre & " - " & Ccpp1.Distrito1.Nombre
        CargaNombreDir()
    End Sub

    Private Sub txtCentroCosto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCentroCosto.ValueChanged
        ' oeDireccionEP.oeDireccion.CentroCosto = txtCentroCosto.Text
    End Sub

    Private Sub txtDepartamento_ValueChanged(sender As Object, e As EventArgs) Handles txtDepartamento.ValueChanged
        CargaNombreDir()
    End Sub

    Private Sub txtManzana_ValueChanged(sender As Object, e As EventArgs) Handles txtManzana.ValueChanged
        CargaNombreDir()
    End Sub

    Private Sub txtLote_ValueChanged(sender As Object, e As EventArgs) Handles txtLote.ValueChanged
        CargaNombreDir()
    End Sub

    Private Sub txtKilometro_ValueChanged(sender As Object, e As EventArgs) Handles txtKilometro.ValueChanged
        CargaNombreDir()
    End Sub

    Private Sub txtBlock_ValueChanged(sender As Object, e As EventArgs) Handles txtBlock.ValueChanged
        CargaNombreDir()
    End Sub

    Private Sub txtEtapa_ValueChanged(sender As Object, e As EventArgs) Handles txtEtapa.ValueChanged
        CargaNombreDir()
    End Sub

#End Region

#End Region

#Region "Funciones"

    Private Function lf_ValidarEliminar() As Boolean
        Try
            'Validar si la empresa esta en algun documento
            oeCombo = New e_Combo
            oeCombo.Nombre = "EmpresaMovimientoDocumento"
            oeCombo.Id = griEmpresa.ActiveRow.Cells("Id").Value.ToString().Trim()
            If olCombo.Listar(oeCombo).Count > 0 Then
                MessageBox.Show("No se puede eliminar la empresa porque esta asignada en almenos un documento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
            'Validar si la empresa esa en alguna carga
            oeCombo = New e_Combo
            oeCombo.Nombre = "EmpresaOperacionDetalle"
            oeCombo.Id = griEmpresa.ActiveRow.Cells("Id").Value.ToString().Trim()
            If olCombo.Listar(oeCombo).Count > 0 Then
                MessageBox.Show("No se puede eliminar la empresa porque esta asignada en almenos una carga de un viaje", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function AgregarDireccion(ByVal IdEmpresa As String) As Boolean
        Try
            oeEmpresa = New e_Empresa
            Inicializar()
            oeEmpresa.Id = IdEmpresa
            oeEmpresa.CargaCompleta = True
            oeEmpresa = olEmpresa.Obtener(oeEmpresa)
            CargarEmpresa(oeEmpresa)
            MostrarTabs(1, ficEmpresa, 1)
            oeEmpresa.TipoOperacion = "A"
            oeEmpresa.Modificado = False
            ficDetalle.SelectedTab = ficDetalle.Tabs(0)
            MostrarTabs(0, ficDireccion)
            InicializarDireccion()
            oeDireccionEP.Modificado = False
            cboTipoVia.Focus()
            band = True
            Operacion = "Editar"
            BandCbo = False
            MyBase.Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

#End Region

#Region "Metodos"

    Dim bandNuevoCliente As String = ""
    Public Sub NuevoCliente()
        MostrarTabs(1, ficEmpresa, 1)
        oeEmpresa = New e_Empresa
        Inicializar()
        oeEmpresa.TipoOperacion = "I"
        oeEmpresa.Modificado = False
        txtCodigo.Focus()
        'agrDatoDireccion.Expanded = False
        Operacion = "Nuevo"
        opcCliente.CheckedIndex = 1
        opcCliente.Enabled = False
        'verCliente.Checked = True
        'verCliente.Enabled = False
        txtCodigo.ReadOnly = False
        txtRuc.ReadOnly = False
        BandCbo = False
        MyBase.Nuevo()
        bandNuevoCliente = "0"
    End Sub

    'Public Sub AgregaDireccionCombo(ByVal idEmpresa As String)
    '    Try
    '        oeEmpresa = New e_Empresa
    '        oeEmpresa.Id = idEmpresa
    '        oeEmpresa = olEmpresa.Obtener(oeEmpresa)
    '        MostrarTabs(1, ficEmpresa, 1)
    '        CargarEmpresa(oeEmpresa)
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            'Me.Cursor = Cursors.WaitCursor
            oeEmpresa = New e_Empresa
            oeEmpresa.TipoOperacion = "5"
            If chkIndicadorSGI.Checked = False Then
                oeEmpresa.IndCategoriaEmpresaSGI = opIndSGI.CheckedIndex
            Else
                oeEmpresa.IndCategoriaEmpresaSGI = -1
            End If
            With griEmpresa
                .DataSource = olEmpresa.Listar(oeEmpresa)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True

                'Ubica el cursor el el primer registro de la grilla
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
        griEmpresa.Focus()
    End Sub

    Private Sub Inicializar()
        txtCodigo.Text = String.Empty
        txtRuc.Text = String.Empty
        txtNombre.Text = String.Empty
        txtAbreviatura.Text = String.Empty
        verActivo.Checked = True
        cboTipoEmpresa.SelectedIndex = 0
        opcCliente.CheckedIndex = 1
        opcCategoria.Enabled = True
        'verCliente.Checked = False
        'verCliente.Enabled = True
        opcProveedor.CheckedIndex = 1
        'verProveedor.Checked = False
        opcComisionista.CheckedIndex = 0
        'verComisionista.Checked = False
        verPercepcion.Checked = 0
        verRetencion.Checked = 0
        verBuenContribuyente.Checked =
        verCanjeDocumento.Checked = 0
        verAceptaLetras.Checked = 0
        verAceptaCheque.Checked = 0
        numMorosidad.Value = 0
        numLineaCredito.Value = 0
        cboNivelComercial.Value = 0
        cboClasificacion.Value = 0
        chkRelacionada.Checked = False
        cboMoneda.SelectedIndex = -1
        leDireccionEP = New List(Of e_Direccion_EmpresaPersona)
        CargarDireccion(leDireccionEP)
        Dim lePersona = New List(Of e_Persona)
        CargarContactos(lePersona)
        leEmail = New List(Of e_Email)
        ListarEmail(leEmail)
        leTelefono = New List(Of e_Telefono)
        ListarTelefono(leTelefono)
        leTipoPago = New List(Of e_PersonaEmpresa_TipoPago)
        CargarPETipoPago(New List(Of e_PersonaEmpresa_TipoPago))
        cboTipoPago.SelectedIndex = -1
        agrContenedorTP.Expanded = False
        ficDetalle.SelectedTab = ficDetalle.Tabs(0)
        IniciaDetalle(griDireccion, mnuDireccion, "Dir", ficDireccion)
        opcCategoria.CheckedIndex = 0
        leContactos.Clear()
        bandNuevoCliente = ""
        If CType(cboPais.DataSource, List(Of e_Combo)).Count > 0 Then
            cboPais.Value = IdPaisPeru
        End If
        txtDireccionFiscal.Text = String.Empty
    End Sub

    Private Sub CargarContactos(ByVal leDEP As List(Of e_Persona))
        Try
            With griContactos
                .DisplayLayout.Bands(0).Columns("ApellidoPaterno").Hidden = True
                .DisplayLayout.Bands(0).Columns("ApellidoMaterno").Hidden = True
                .DisplayLayout.Bands(0).Columns("Nombre").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = False
                .DisplayLayout.Bands(0).Columns("IdContacto").Hidden = True
                .DisplayLayout.Bands(0).Columns("Contacto").Hidden = True
                .DisplayLayout.Bands(0).Columns("Codigo").Hidden = True
                .DisplayLayout.Bands(0).Columns("NombreCompleto").Width = 230
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Header.Caption = "Telefonos"
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Width = 240
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Mostrar()
        Try
            If griEmpresa.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                oeEmpresa = New e_Empresa
                Inicializar()
                oeEmpresa.Id = griEmpresa.ActiveRow.Cells("Id").Value.ToString
                oeEmpresa.CargaCompleta = True
                oeEmpresa = olEmpresa.Obtener(oeEmpresa)
                CargarEmpresa(oeEmpresa)
                MostrarTabs(1, ficEmpresa, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function Guardando() As Boolean
        Try
            If opcCliente.CheckedIndex = 2 OrElse opcProveedor.CheckedIndex = 2 OrElse opcComisionista.CheckedIndex = 2 Then
                If leDireccionEP.Where(Function(x) x.TipoOperacion <> "E" And x.Principal = 1).Count = 0 Then
                    Throw New Exception("Si marcó extranjero debe agregar almenos una direccion principal con su respectivo País")
                End If
            End If
            Dim resultado As Boolean = False
            LlenaTelefono()
            LlenaEmail()
            With oeEmpresa
                .leDireccionEP = leDireccionEP
                .leTipoPago = leTipoPago
                .UsuarioCreacion = gUsuarioSGI.Id
                .IndAgentePercepcion = IIf(verPercepcion.Checked, 1, 0)
                .IndAgenteRetencion = IIf(verRetencion.Checked, 1, 0)
                .IndBuenContribuyente = IIf(verBuenContribuyente.Checked, 1, 0)
                .IndCanjeDocumento = IIf(verCanjeDocumento.Checked, 1, 0)
                .IndAceptaLetras = IIf(verAceptaLetras.Checked, 1, 0)
                .IndAceptaCheque = IIf(verAceptaCheque.Checked, 1, 0)
                .Morosidad = numMorosidad.Value
                .Credito = numLineaCredito.Value
                .IndNivelComercial = cboNivelComercial.Value
                .IndClasificacion = cboClasificacion.Value
                .IndRelacionada = IIf(chkRelacionada.Checked, 1, 0)
                .IdMoneda = cboMoneda.Value
                .oeClienteProveedor.IndCategoriaSGI = opcCategoria.CheckedIndex
            End With
            If leContactos.Count > 0 Then
                oeEmpresa.leContactos = griContactos.DataSource
                resultado = True
            End If
            oeEmpresa.PrefijoID = gs_PrefijoIdSucursal '@0001
            If bandNuevoCliente.Trim <> "" Then
                frm_DemandaRapida.codigoNuevoCLiente = olEmpresa.GuardarCliente(oeEmpresa)
                If frm_DemandaRapida.codigoNuevoCLiente <> "" Then
                    mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                    resultado = True
                End If
            Else
                ' If 
                olEmpresa.Guardar(oeEmpresa)
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                If BandTP Then
                    ActualizaDoc()
                    BandTP = False
                End If
                MostrarTabs(0, ficEmpresa, 2)
                Consultar(True)
                griEmpresa.Focus()
                resultado = True
            End If

            Return resultado
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            Enfocar(ex.Message)
        End Try
    End Function

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("Codigo") Then txtCodigo.Focus()
        If excepcion.Contains("Nombre") Then txtNombre.Focus()
        If excepcion.Contains("Via") Then txtNombreVia.Focus()
        If excepcion.Contains("Tipo de Via") Then cboTipoVia.Focus()
        If excepcion.Contains("Zona") Then txtNombreZona.Focus()
        If excepcion.Contains("Tipo de Zona") Then cboNombreZona.Focus()
        If excepcion.Contains("Centro Poblado") Then Ccpp1.Focus()
    End Sub

    Private Sub CargarCombo()

        Try

            Dim oeTipoZona As New e_TipoZona, olTipoZona As New l_TipoZona
            Dim oeTipoVia As New e_TipoVia, olTipoVia As New l_TipoVia
            Dim oeMoneda As New e_Moneda, olMoneda As New l_Moneda
            oeLugar = New e_Lugar

            LlenarCombo(cboNombreZona, "Nombre", olTipoZona.Listar(oeTipoZona), -1)
            LlenarCombo(cboTipoVia, "Nombre", olTipoVia.Listar(oeTipoVia), -1)
            LlenarCombo(cmbLugar, "Nombre", olLugar.Listar(oeLugar).OrderBy(Function(item) item.Nombre).ToList, -1)

            oeTipoPago = New e_TipoPago
            Dim olTipoPago As New l_TipoPago
            oeTipoPago.TipoOperacion = ""
            oeTipoPago.Activo = True
            LlenarCombo(cboTipoPago, "Nombre", olTipoPago.Listar(oeTipoPago), -1)

            oeMoneda = New e_Moneda
            oeMoneda.Activo = True
            LlenarCombo(cboMoneda, "Nombre", olMoneda.Listar(oeMoneda), -1)
            'Pais
            oeCombo = New e_Combo
            oeCombo.Nombre = "Pais"
            LlenarCombo(cboPais, "Nombre", olCombo.Listar(oeCombo), -1)

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    'Private Sub QuitarDireccion()
    '    Try
    '        Dim oeDEP As New e_Direccion_EmpresaPersona
    '        oeDEP = griDireccion.ActiveRow.ListObject
    '        If oeDEP.TipoOperacion = "I" Then
    '            leDireccionEP.Remove(oeDEP)
    '        Else
    '            oeDEP = leDireccionEP.Item(leDireccionEP.IndexOf(oeDEP))
    '            oeDEP.TipoOperacion = "E"
    '            griDireccion.ActiveRow.Hidden = True
    '        End If
    '        griDireccion.DataBind()
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    Private Sub TecladoGrilla(ByVal Migrilla As Grilla, ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Insert
                Agregar(Migrilla, Tipo)
            Case Keys.Delete
                Quitar(Migrilla)
            Case Keys.Add
                Agregar(Migrilla, Tipo)
            Case Keys.Subtract
                Quitar(Migrilla)
        End Select
    End Sub

    Private Sub Agregar(ByVal MiGrilla As Grilla, ByVal MiTipo As Integer)
        Try
            Dim oeTemp As New Object
            Select Case Tipo
                Case 1
                    oeTemp = New e_Telefono
                    Dim ListaTelefono As New List(Of e_Telefono)
                    If MiGrilla.Rows.Count = 0 Then
                        ListarTelefono(ListaTelefono)
                        oeEmpresa.leTelefono = ListaTelefono
                    End If
                    ListaTelefono = oeEmpresa.leTelefono
                    ListaTelefono.Add(oeTemp)
                Case 2
                    oeTemp = New e_Email
                    Dim ListaEmail As New List(Of e_Email)
                    If MiGrilla.Rows.Count = 0 Then
                        ListarEmail(ListaEmail)
                        oeEmpresa.leEmail = ListaEmail
                    End If
                    ListaEmail = oeEmpresa.leEmail
                    ListaEmail.Add(oeTemp)
                Case 3
            End Select
            MiGrilla.DataBind()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Quitar(ByVal Migrilla As Grilla)
        Try
            If Migrilla.Rows.Count > 0 Then
                Migrilla.ActiveRow.Delete()
                Migrilla.Select()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub LlenaTelefono()
        With griTelefono
            If .Rows.Count > 0 Then
                oeEmpresa.leTelefono = New List(Of e_Telefono)
                For i = 0 To .Rows.Count - 1
                    Dim oeTelefono As New e_Telefono
                    oeTelefono.Id = .Rows(i).Cells("Id").Value
                    oeTelefono.Tipo = "1"
                    oeTelefono.UsuarioCreacion = gUsuarioSGI.Id
                    oeTelefono.TipoPersonaEmpresa = 2
                    oeTelefono.IdPersonaEmpresa = oeEmpresa.Id
                    oeTelefono.Nombre = .Rows(i).Cells("Nombre").Value
                    oeTelefono.Activo = .Rows(i).Cells("Activo").Value
                    oeEmpresa.leTelefono.Add(oeTelefono)
                    oeTelefono = Nothing
                Next
            End If
        End With
    End Sub

    Private Sub LlenaEmail()
        With griEmail
            If .Rows.Count > 0 Then
                oeEmpresa.leEmail = New List(Of e_Email)
                For i = 0 To .Rows.Count - 1
                    Dim oeEmail As New e_Email
                    oeEmail.Id = .Rows(i).Cells("Id").Value
                    oeEmail.TipoPersonaEmpresa = 2
                    oeEmail.IdPersonaEmpresa = oeEmpresa.Id
                    oeEmail.UsuarioCreacion = gUsuarioSGI.Id
                    oeEmail.Nombre = .Rows(i).Cells("Nombre").Value
                    oeEmail.Activo = .Rows(i).Cells("Activo").Value
                    oeEmpresa.leEmail.Add(oeEmail)
                    oeEmail = Nothing
                Next
            End If
        End With
    End Sub

    Private Sub ListarTelefono(ByVal leTelefono As List(Of e_Telefono))
        Try
            With griTelefono
                .DataSource = leTelefono
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Tipo").Hidden = True
                .DisplayLayout.Bands(0).Columns("TipoPersonaEmpresa").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdPersonaEmpresa").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ListarEmail(ByVal leEmail As List(Of e_Email))
        Try
            With griEmail
                .DataSource = leEmail
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("TipoPersonaEmpresa").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdPersonaEmpresa").Hidden = True
                .DisplayLayout.Bands(0).Columns("NombreCompleto").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("Principal").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    'Private Sub ListarTipoPago()
    '    Try
    '        Dim oeTipoPago As New e_TipoPago
    '        Dim olTipoPago As New l_TipoPago
    '        oeTipoPago.TipoOperacion = ""
    '        oeTipoPago.Activo = True
    'With griListaTipoPago
    '    .ResetDisplayLayout()
    '    .DataSource = olTipoPago.Listar(oeTipoPago)

    '    .DisplayLayout.Bands(0).Columns.Add("Selec", "Seleccionar")
    '    .DisplayLayout.Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
    '    .DisplayLayout.Bands(0).Columns("Selec").DefaultCellValue = False
    '    .DisplayLayout.Bands(0).Columns("Selec").Header.VisiblePosition = 1
    '    .DisplayLayout.Bands(0).Columns("Selec").Width = 60

    '    For Each Col As UltraGridColumn In .DisplayLayout.Bands(0).Columns
    '        If Col.Key = "Selec" Then
    '            Col.CellActivation = Activation.AllowEdit
    '            Col.CellClickAction = CellClickAction.Edit
    '        Else
    '            Col.CellActivation = Activation.NoEdit
    '            Col.CellClickAction = CellClickAction.RowSelect
    '        End If
    '    Next

    '    .DisplayLayout.Bands(0).Columns("Id").Hidden = True
    '    .DisplayLayout.Bands(0).Columns("Abreviatura").Hidden = True
    '    .DisplayLayout.Bands(0).Columns("Activo").Hidden = True

    '    .DisplayLayout.Bands(0).Columns("Codigo").Header.VisiblePosition = 2
    '    .DisplayLayout.Bands(0).Columns("Nombre").Header.VisiblePosition = 3
    '    .DisplayLayout.Bands(0).Columns("Dias").Header.VisiblePosition = 4

    '    .DisplayLayout.Bands(0).Columns("Codigo").Width = 60
    '    .DisplayLayout.Bands(0).Columns("Nombre").Width = 200

    '    .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.RowIndex

    'End With

    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    Private Sub AgregarTP(ByVal oe As e_TipoPago)
        Try
            Dim oeEPTP As New e_PersonaEmpresa_TipoPago
            oeEPTP.IdTipoPago = oe.Id
            oeEPTP.IndClienteProveedor = IIf(optTipo.CheckedIndex = 0, 1, 2)
            If Not leTipoPago.Contains(oeEPTP) Then
                oePETipoPago.IdClienteProveedor = oeEmpresa.oeClienteProveedor.Id
                oeEPTP.TipoPago = oe.Nombre
                oeEPTP.Dias = oe.Dias
                oeEPTP.UsuarioCreacion = gUsuarioSGI.Id
                oeEPTP.TipoOperacion = "I"
                If griTipoPago.Rows.Count < 1 Then CargarPETipoPago(leTipoPago)
                leTipoPago.Add(oeEPTP)
            Else
                If oe.TipoOperacion = "E" Then
                    oe.TipoOperacion = ""
                Else
                    Throw New Exception("El Tipo Pago: " & oe.Nombre & " y Tipo: " & oeEPTP.Tipo & " ya esta Asignada")
                End If
            End If
            'Verifica el Nuevo Tipo de Pago por Cliente (Cobranzas)
            If Operacion = "Editar" Then
                If oeEPTP.IndClienteProveedor = 1 AndAlso oeEPTP.Dias > 0 Then
                    BandTP = True
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarTP(ByVal oe As e_PersonaEmpresa_TipoPago)
        Try
            If oe.Id <> "" Then
                oe.TipoOperacion = "E"
            Else
                leTipoPago.Remove(oe)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarPETipoPago(ByVal leTP As List(Of e_PersonaEmpresa_TipoPago))
        Try
            Dim leActivo As New List(Of e_PersonaEmpresa_TipoPago)
            leActivo = leTP.Where(Function(item) item.TipoOperacion <> "E").ToList

            With griTipoPago

                .DataSource = leActivo

                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdClienteProveedor").Hidden = True
                .DisplayLayout.Bands(0).Columns("IndClienteProveedor").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdTipoPago").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True

                .DisplayLayout.Bands(0).Columns("TipoPago").Width = 200
                .DisplayLayout.Bands(0).Columns("Dias").Width = 60
                .DisplayLayout.Bands(0).Columns("Tipo").Width = 120

                .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow

                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect

            End With

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub InicializaTipoPago()
        cboTipoPago.SelectedIndex = -1
        optTipo.CheckedIndex = 0
    End Sub

    Private Sub CargarEmpresa(ByVal oeEmpr As e_Empresa)
        Try
            With oeEmpr
                If bndRuc Then oeEmpresa.Id = .Id
                txtCodigo.Text = .Codigo
                txtRuc.Text = .Ruc
                txtNombre.Text = .Nombre
                txtAbreviatura.Text = .Abreviatura
                verActivo.Checked = .Activo
                cboTipoEmpresa.Value = .IdTipoEmpresa
                opcCliente.CheckedIndex = .oeClienteProveedor.Cliente
                opcProveedor.CheckedIndex = .oeClienteProveedor.Proveedor
                opcComisionista.CheckedIndex = .oeClienteProveedor.Comisionista
                'verCliente.Checked = IIf(.oeClienteProveedor.Cliente = 1, True, False)
                'verProveedor.Checked = IIf(.oeClienteProveedor.Proveedor = 1, True, False)
                'verComisionista.Checked = IIf(.oeClienteProveedor.Comisionista = 1, True, False)
                opcCategoria.CheckedIndex = .oeClienteProveedor.IndCategoriaSGI
                verPercepcion.Checked = .IndAgentePercepcion
                verRetencion.Checked = .IndAgenteRetencion
                verBuenContribuyente.Checked = .IndBuenContribuyente
                verCanjeDocumento.Checked = .IndCanjeDocumento
                verAceptaLetras.Checked = .IndAceptaLetras
                verAceptaCheque.Checked = .IndAceptaCheque
                numMorosidad.Value = .Morosidad
                numLineaCredito.Value = .Credito
                cboNivelComercial.Value = .IndNivelComercial
                cboClasificacion.Value = .IndClasificacion
                chkRelacionada.Checked = IIf(.IndRelacionada = 1, True, False)
                cboMoneda.Value = .IdMoneda
                oeEmpresa.oeClienteProveedor.Id = .oeClienteProveedor.Id
                oeEmpresa.oeClienteProveedor.Codigo = .oeClienteProveedor.Codigo
                oeEmpresa.oeClienteProveedor.IdPersonaEmpresa = .oeClienteProveedor.IdPersonaEmpresa
                oeEmpresa.oeClienteProveedor.FechaActividad = .oeClienteProveedor.FechaActividad
                leDireccionEP = .leDireccionEP
                CargarDireccion(leDireccionEP)
                ListarTelefono(.leTelefono)
                ListarEmail(.leEmail)
                leTipoPago = .leTipoPago
                CargarPETipoPago(leTipoPago)
                bndRuc = False
                griContactos.DataSource = .leContactos
                leContactos = .leContactos
                txtDireccionFiscal.Text = .DireccionFiscal
            End With
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub TextoNumero(ByVal ei As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(ei.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then ei.Handled = True
    End Sub

    Private Sub ActualizaDoc()
        Try
            Dim oeEmpr As New e_Empresa
            Dim idCli As String = ""
            oeEmpr.Id = oeEmpresa.Id
            oeEmpr.CargaCompleta = True
            oeEmpr = olEmpresa.Obtener(oeEmpresa)
            idCli = oeEmpr.oeClienteProveedor.Id
            oeMovDoc.TipoOperacion = "TOT"
            oeMovDoc.IdClienteProveedor = idCli
            oeMovDoc = olMovDoc.ObtenerCantDoc(oeMovDoc)
            If oeMovDoc.Total > 0 Then
                If MessageBox.Show("Se ha Actualizado el plazo de dias de pago como cliente." & Environment.NewLine & _
                                   "Tiene " & Math.Round(oeMovDoc.Total) & " Documento(s) pendientes a Pagar." & Environment.NewLine & _
                                   "¿Desea Actualizar su Dias de plazo de pago?", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    oeEmpr = New e_Empresa
                    oeEmpr.Id = idCli
                    oeEmpr.TipoOperacion = "R"
                    olEmpresa.ActualizaFec(oeEmpr)
                    mensajeEmergente.Confirmacion("Los Documentos se Actualizaron con Exito")
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
      
    End Sub

    'Private Sub TecladoGrilla(ByVal Migrilla As Grilla, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    Select Case e.KeyCode
    '        Case Keys.Insert
    '            Agregar(Migrilla, Tipo)
    '        Case Keys.Delete
    '            Quitar(Migrilla)
    '        Case Keys.Add
    '            Agregar(Migrilla, Tipo)
    '        Case Keys.Subtract
    '            Quitar(Migrilla)
    '    End Select
    'End Sub

    Private Sub ActualizarEmpresasPublicas()

        ClientesPublic = New List(Of e_Combo)
        oeCombo = New e_Combo
        oeCombo.Nombre = "Clientes"
        ClientesPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

        ProveedorPublic = New List(Of e_Combo)
        oeCombo = New e_Combo
        oeCombo.Nombre = "Proveedores"
        ProveedorPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)

    End Sub

    Private Sub ControlSubMenu(MenuTool As UltraToolbarsManager _
                               , Pref As String _
                               , Listar As Boolean _
                               , Agregar As Boolean _
                               , Modificar As Boolean _
                               , Grabar As Boolean _
                               , Cancelar As Boolean _
                               , Quitar As Boolean _
                               , Regresar As Boolean)
        With MenuTool
            ' .Tools.Item(Pref & "Listar").SharedProps.Enabled = Listar
            .Tools.Item(Pref & "Agregar").SharedProps.Enabled = Agregar
            .Tools.Item(Pref & "Modificar").SharedProps.Enabled = Modificar
            .Tools.Item(Pref & "Grabar").SharedProps.Enabled = Grabar
            .Tools.Item(Pref & "Cancelar").SharedProps.Enabled = Cancelar
            .Tools.Item(Pref & "Quitar").SharedProps.Enabled = Quitar
            '.Tools.Item(Pref & "Regresar").SharedProps.Enabled = Regresar
        End With
    End Sub

    Private Sub IniciaDetalle(Gri As UltraGrid, Menu As UltraToolbarsManager, Pre As String, Ficha As UltraTabControl)
        If Gri.Rows.Count > 0 Then
            ControlSubMenu(Menu, Pre, 1, 1, 1, 0, 0, 1, 0)
        Else
            ControlSubMenu(Menu, Pre, 1, 1, 0, 0, 0, 1, 0)
        End If
        MostrarTabs(0, Ficha)
    End Sub

    Private Sub mt_ControlBonotoneria()
        Try
            Select Case ficEmpresa.SelectedTab.Index
                Case 0 'Listado
                    If griEmpresa.Rows.Count > 0 Then
                        ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                    Else
                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                    End If
                Case 1 'Mantenimiento
                    ControlBoton(0, 0, 0, 1, 1)
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#Region "Metodo Direccion"

    Private Sub InicializarDireccion()
        cboTipoVia.Text = "NINGUNO"
        txtNombreVia.Text = String.Empty
        txtNumero.Value = String.Empty
        txtDepartamento.Text = String.Empty
        txtNumeroInterior.Text = String.Empty
        txtManzana.Text = String.Empty
        txtLote.Text = String.Empty
        txtKilometro.Text = String.Empty
        txtBlock.Text = String.Empty
        txtEtapa.Text = String.Empty
        cboNombreZona.Text = "NINGUNO"
        txtNombreZona.Text = String.Empty
        txtReferencia.Text = String.Empty
        cmbLugar.SelectedIndex = -1
        txtCentroCosto.Text = String.Empty
        Ccpp1.Seleccionar(String.Empty)
    End Sub

    Private Sub CargarDireccion(ByVal leDEP As List(Of e_Direccion_EmpresaPersona))
        Try
            With griDireccion

                .ResetDisplayLayout()

                Dim _leActivo = leDEP.Where(Function(it) it.Activo = True).ToList

                .DataSource = _leActivo

                For Each col In .DisplayLayout.Bands(0).Columns
                    If col.Key <> "Nombre" And col.Key <> "Principal" Then col.Hidden = True
                    'If col.Key.Contains("Id") Then col.ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                    If col.Key = "Principal" Then
                        col.CellActivation = Activation.AllowEdit
                        col.CellClickAction = CellClickAction.Edit
                    Else
                        col.CellActivation = Activation.NoEdit
                        col.CellClickAction = CellClickAction.RowSelect
                    End If
                Next

                .DisplayLayout.Bands(0).Columns("Principal").Header.VisiblePosition = 0

                .DisplayLayout.Bands(0).Columns("Principal").Style = ColumnStyle.CheckBox

                .DisplayLayout.Bands(0).Columns("Nombre").Width = 500

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarDireccion()
        Try
            If opcCliente.CheckedIndex = 2 OrElse opcProveedor.CheckedIndex = 2 OrElse opcComisionista.CheckedIndex = 2 Then
                If cboPais.SelectedIndex < 0 Then
                    Throw New Exception("Si marcó extranjero debe elegir un país ")
                End If
                If cboPais.Value = IdPaisPeru Then
                    Throw New Exception("Si marcó extranjero debe elegir un país diferente de Perú")
                End If
            End If
            RecogerDatosDir()
            If olDireccionEmpresaPersona.ValidarDireccionValida(oeDireccionEP) Then
                Dim oeDireccion As New e_Direccion
                Dim olDireccion As New l_Direccion
                With oeDireccionEP
                    oeDireccion.CCPP = .oeDireccion.CCPP
                    oeDireccion.IdTipoVia = .oeDireccion.IdTipoVia
                    oeDireccion.IdTipoZona = .oeDireccion.IdTipoZona
                    oeDireccion.Numero = .oeDireccion.Numero
                    oeDireccion.NumeroInterior = .oeDireccion.NumeroInterior
                    oeDireccion.Referencia = .oeDireccion.Referencia
                    oeDireccion.Via = .oeDireccion.Via
                    oeDireccion.Zona = .oeDireccion.Zona
                    oeDireccion.IdLugar = .oeDireccion.IdLugar
                    oeDireccion.Lugar = .oeDireccion.Lugar
                    oeDireccion.CentroCosto = .oeDireccion.CentroCosto
                    oeDireccion.IdPais = .oeDireccion.IdPais
                End With
                oeDireccion = olDireccion.Obtener(oeDireccion)
                If oeDireccion.Id <> "" Then
                    oeDireccionEP.oeDireccion.Id = oeDireccion.Id
                    If Not leDireccionEP.Contains(oeDireccionEP) Then
                        oeDireccionEP.TipoOperacion = "I"
                        If griDireccion.Rows.Count = 0 Then CargarDireccion(leDireccionEP) : oeDireccionEP.Principal = 1
                        leDireccionEP.Add(oeDireccionEP)
                    Else
                        Dim oe As New e_Direccion_EmpresaPersona
                        oe = leDireccionEP.Item(leDireccionEP.IndexOf(oeDireccionEP))
                        oe.oeDireccion.IdTipoVia = oeDireccionEP.oeDireccion.IdTipoVia
                        oe.oeDireccion.Via = oeDireccionEP.oeDireccion.Via
                        oe.oeDireccion.IdTipoZona = oeDireccionEP.oeDireccion.IdTipoZona
                        oe.oeDireccion.Zona = oeDireccionEP.oeDireccion.Zona
                        oe.oeDireccion.Numero = oeDireccionEP.oeDireccion.Numero
                        oe.oeDireccion.CCPP = oeDireccionEP.oeDireccion.CCPP
                        oe.oeDireccion.NumeroInterior = oeDireccionEP.oeDireccion.NumeroInterior
                        oe.oeDireccion.Referencia = oeDireccionEP.oeDireccion.Referencia
                        oe.oeDireccion.IdLugar = oeDireccionEP.oeDireccion.IdLugar
                        oe.oeDireccion.Lugar = oeDireccionEP.oeDireccion.Lugar
                        oe.oeDireccion.CentroCosto = oeDireccionEP.oeDireccion.CentroCosto
                        oe.oeDireccion.IdPais = oeDireccionEP.oeDireccion.IdPais
                        If band Then
                            If oe.TipoOperacion = "E" Then
                                oe.TipoOperacion = "A"
                            Else
                                Throw New Exception("Esta direccion ya esta registrado a esta Persona.")
                            End If
                        Else
                            oe.TipoOperacion = "A"
                        End If
                    End If
                Else
                    oeDireccionEP.Equivale = "1"
                    If Not leDireccionEP.Contains(oeDireccionEP) Then
                        oeDireccionEP.TipoOperacion = "C"
                        If griDireccion.Rows.Count = 0 Then CargarDireccion(leDireccionEP) : oeDireccionEP.Principal = 1
                        leDireccionEP.Add(oeDireccionEP)
                    Else
                        Dim oe As New e_Direccion_EmpresaPersona
                        oe = leDireccionEP.Item(leDireccionEP.IndexOf(oeDireccionEP))
                        oe.oeDireccion.IdTipoVia = oeDireccionEP.oeDireccion.IdTipoVia
                        oe.oeDireccion.Via = oeDireccionEP.oeDireccion.Via
                        oe.oeDireccion.IdTipoZona = oeDireccionEP.oeDireccion.IdTipoZona
                        oe.oeDireccion.Zona = oeDireccionEP.oeDireccion.Zona
                        oe.oeDireccion.Numero = oeDireccionEP.oeDireccion.Numero
                        oe.oeDireccion.CCPP = oeDireccionEP.oeDireccion.CCPP
                        oe.oeDireccion.NumeroInterior = oeDireccionEP.oeDireccion.NumeroInterior
                        oe.oeDireccion.Referencia = oeDireccionEP.oeDireccion.Referencia
                        oe.oeDireccion.IdLugar = oeDireccionEP.oeDireccion.IdLugar
                        oe.oeDireccion.Lugar = oeDireccionEP.oeDireccion.Lugar
                        oe.oeDireccion.CentroCosto = oeDireccionEP.oeDireccion.CentroCosto
                        oe.oeDireccion.IdPais = oeDireccionEP.oeDireccion.IdPais
                        If band Then
                            If oe.TipoOperacion = "E" Then
                                oe.Activo = True
                                oe.TipoOperacion = "A"
                            Else
                                Throw New Exception("Esta direccion ya esta registrada a esta Persona.")
                            End If
                        Else
                            oe.TipoOperacion = "A"
                        End If
                    End If
                End If
                CargarDireccion(leDireccionEP)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MostrarDireccion()
        Try
            oeDireccionEP = New e_Direccion_EmpresaPersona
            oeDireccionEP.Id = griDireccion.ActiveRow.Cells("Id").Value
            oeDireccionEP.Equivale = "2"
            If leDireccionEP.Contains(oeDireccionEP) Then
                oeDireccionEP = leDireccionEP.Item(leDireccionEP.IndexOf(oeDireccionEP))
                With oeDireccionEP
                    cboTipoVia.Value = .oeDireccion.IdTipoVia
                    txtNombreVia.Text = .oeDireccion.Via
                    txtNumeroInterior.Text = .oeDireccion.NumeroInterior
                    txtManzana.Text = .oeDireccion.Manzana
                    txtLote.Text = .oeDireccion.Lote
                    txtKilometro.Text = .oeDireccion.Kilometro
                    txtBlock.Text = .oeDireccion.Block
                    txtEtapa.Text = .oeDireccion.Etapa
                    If .oeDireccion.Numero.Contains("NRO.") Then
                        txtNumero.Text = .oeDireccion.Numero.Substring(4, .oeDireccion.Numero.Length - 4).Trim
                    ElseIf .oeDireccion.Numero.Contains("KM") Then
                        txtKilometro.Text = .oeDireccion.Numero.Substring(2, .oeDireccion.Numero.Length - 2).Trim
                    ElseIf .oeDireccion.Numero.Contains("S/N") Then
                        txtNumero.Text = "S/N"
                    Else
                        txtNumero.Text = .oeDireccion.Numero
                    End If
                    cboNombreZona.Value = .oeDireccion.IdTipoZona
                    txtNombreZona.Text = .oeDireccion.Zona
                    txtReferencia.Text = .oeDireccion.Referencia
                    txtCentroCosto.Text = .oeDireccion.CentroCosto
                    cmbLugar.Value = .oeDireccion.IdLugar
                    Ccpp1.Seleccionar(.oeDireccion.CCPP)
                    cboPais.Value = .oeDireccion.IdPais
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargaNombreDir()
        txtNombreDir.Text = oeDireccionEP.NombreDir1
    End Sub

    Private Sub EditarDireccion()
        Try
            InicializarDireccion()
            MostrarDireccion()
            oeDireccionEP.TipoOperacion = "A"
            MostrarTabs(1, ficDireccion)
            ControlSubMenu(mnuDireccion, "Dir", 0, 0, 0, 1, 1, 0, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarDireccion()
        Try
            oeDireccionEP = New e_Direccion_EmpresaPersona
            oeDireccionEP.Id = griDireccion.ActiveRow.Cells("Id").Value
            oeDireccionEP.Equivale = "2"
            If leDireccionEP.Contains(oeDireccionEP) Then
                oeDireccionEP = leDireccionEP.Item(leDireccionEP.IndexOf(oeDireccionEP))
                If oeDireccionEP.TipoOperacion = "I" Then
                    leDireccionEP.Remove(oeDireccionEP)
                Else
                    oeDireccionEP.TipoOperacion = "E"
                    oeDireccionEP.Activo = False
                End If
                CargarDireccion(leDireccionEP)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub RecogerDatosDir()
        oeDireccionEP.oeDireccion.IdTipoVia = cboTipoVia.Value
        If cboTipoVia.Text <> "NINGUNO" Then
            Dim oeTVia As New e_TipoVia
            oeTVia = cboTipoVia.Items(cboTipoVia.SelectedIndex).ListObject
            oeDireccionEP.oeDireccion.TipoVia = oeTVia.Abreviatura
        End If
        oeDireccionEP.oeDireccion.Via = txtNombreVia.Text.Trim
        oeDireccionEP.oeDireccion.Numero = txtNumero.Text.Trim
        oeDireccionEP.oeDireccion.Departamento = txtDepartamento.Text.Trim
        oeDireccionEP.oeDireccion.NumeroInterior = txtNumeroInterior.Text
        oeDireccionEP.oeDireccion.Manzana = txtManzana.Text.Trim
        oeDireccionEP.oeDireccion.Lote = txtLote.Text.Trim
        oeDireccionEP.oeDireccion.Kilometro = txtKilometro.Text.Trim
        oeDireccionEP.oeDireccion.Block = txtBlock.Text.Trim
        oeDireccionEP.oeDireccion.Etapa = txtEtapa.Text.Trim
        oeDireccionEP.oeDireccion.IdTipoZona = cboNombreZona.Value
        oeDireccionEP.oeDireccion.IdLugar = cmbLugar.Value
        If cboNombreZona.Text <> "NINGUNO" Then
            Dim oeTZona As New e_TipoZona
            oeTZona = cboNombreZona.Items(cboNombreZona.SelectedIndex).ListObject
            oeDireccionEP.oeDireccion.TipoZona = oeTZona.Abreviatura
        End If
        oeDireccionEP.oeDireccion.Zona = txtNombreZona.Text
        oeDireccionEP.oeDireccion.Referencia = txtReferencia.Text
        oeDireccionEP.oeDireccion.CentroCosto = txtCentroCosto.Text
        oeDireccionEP.oeDireccion.CCPP = Ccpp1.Id
        oeDireccionEP.oeDireccion.IdPais = cboPais.Value
        oeDireccionEP.oeDireccion.NombreCCPP = Ccpp1.Departamento1.Nombre & " - " & _
              Ccpp1.Provincia1.Nombre & " - " & Ccpp1.Distrito1.Nombre
    End Sub

#End Region

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_Empresa_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griEmpresa_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro de Empresas"

    Private Sub AsociarMenu()
        griEmpresa.ContextMenuStrip = MenuContextual1
    End Sub

    Private Sub InsertarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertarToolStripMenuItem.Click
        Nuevo()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        Editar()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar()
    End Sub

    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        MenuContextual1.Items("InsertarToolStripMenuItem").Visible = True
        If griEmpresa.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

#Region "Menu Contextual para Detalle Empresa (Direccion)"

    'Private Sub AsociarMenuDetalle()
    '    griDireccion.ContextMenuStrip = MenuContextual2
    'End Sub

    'Private Sub MenuContextual2_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual2.Opening
    '    MenuContextual2.Items("tsmiAgregar").Visible = True
    '    MenuContextual2.Items("tsmiEditar").Visible = False
    '    MenuContextual2.Items("tsmiQuitar").Visible = False
    '    If griDireccion.Selected.Rows.Count > 0 Then
    '        MenuContextual2.Items("tsmiEditar").Visible = True
    '        MenuContextual2.Items("tsmiQuitar").Visible = True
    '    End If
    'End Sub

    'Private Sub tsmiAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiAgregar.Click
    '    If Tipo > 0 Then
    '        Agregar(griTemp, Tipo)
    '    Else
    '        'InicializarDireccion()
    '        'CargarCombo()
    '        'agrDatoDireccion.Expanded = True
    '        'agrDatoDireccion.Expanded = True
    '        InicializarDireccion()
    '        oeDireccionEP.Modificado = False
    '        band = True
    '    End If
    'End Sub

    'Private Sub tsmiEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEditar.Click
    '    'EditarDir()
    'End Sub

    'Private Sub tsmiQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiQuitar.Click
    '    If Tipo > 0 Then
    '        Quitar(griTemp)
    '    Else
    '        ' QuitarDireccion()
    '        oeDireccionEP = griDireccion.ActiveRow.ListObject
    '        oeDireccionEP = leDireccionEP.Item(leDireccionEP.IndexOf(oeDireccionEP))
    '        If MessageBox.Show("¿Desea Eliminar la Dirección: " & oeDireccionEP.Nombre & "?", "Mensaje de sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
    '            If oeDireccionEP.Id <> "" Then
    '                oeDireccionEP.TipoOperacion = "E"
    '                oeDireccionEP.Activo = False
    '            Else
    '                leDireccionEP.Remove(oeDireccionEP)
    '            End If
    '            CargarDireccion(leDireccionEP)
    '        End If
    '    End If

    'End Sub

#End Region

#Region "Menú Contextual para Tipo Pago"

    Private Sub mnuTipoPago_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mnuTipoPago.Opening
        mnuTipoPago.Items("tsmiQuitarTP").Visible = False
        If griTipoPago.Rows.Count > 0 Then mnuTipoPago.Items("tsmiQuitarTP").Visible = True
    End Sub

    Private Sub tsmiAgregarTP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiAgregarTP.Click
        InicializaTipoPago()
        agrContenedorTP.Expanded = True
    End Sub

    Private Sub etiRuc_Click(sender As Object, e As EventArgs) Handles etiRuc.Click

    End Sub

    Private Sub tsmiQuitarTP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiQuitarTP.Click
        Try
            Dim oePETP As New e_PersonaEmpresa_TipoPago
            oePETP = griTipoPago.ActiveRow.ListObject
            If MessageBox.Show("¿Desea Eliminar el Tipo de Pago: " & oePETP.TipoPago & " y Tipo: " & oePETP.Tipo & "?" _
                               , "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                QuitarTP(oePETP)
                CargarPETipoPago(leTipoPago)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

End Class