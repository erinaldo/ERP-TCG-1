Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports ISL.Controles
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinToolbars
Imports Infragistics.Win.UltraWinTabControl

Public Class frm_Persona
    Inherits ISL.Win.frm_MenuPadre

#Region "Declaracion de Variables"

    Dim oePersona As New e_Persona
    Dim olPersona As New l_Persona
    Dim oeDireccionEP As New e_Direccion_EmpresaPersona
    Dim olDireccionEmpresaPersona As New l_Direccion_EmpresaPersona
    Public leDireccionEP As New List(Of e_Direccion_EmpresaPersona)

    Dim oeEmail As New e_Email
    Dim leEmail As New List(Of e_Email)
    Dim oeTelefono As New e_Telefono
    Dim leTelefono As New List(Of e_Telefono)

    Dim oePETipoPago As New e_PersonaEmpresa_TipoPago
    Dim olPETipoPago As New l_PersonaEmpresa_TipoPago
    Public leTipoPago As New List(Of e_PersonaEmpresa_TipoPago)
    Dim oeTipoPago As New e_TipoPago

    Dim _ingresando_datos As Boolean
    Dim griTemp As New Grilla
    Dim Tipo As Integer

    Public PersonaMerma As String = ""
    Public oeDerHab As New e_DerechoHabiente

    Private Band As Boolean
    Dim BandCbo As Boolean = True
    Private BandMuestra As Boolean = True, BandDni As Boolean = True
    Private vartel As Integer = 0, ModoPresentacion As Integer = 0
    Public bandFrm As String = ""
    Public bandContacto As String = ""
    Public listaContactos As New List(Of e_Persona)
    Dim oCombo As New e_Combo
    Dim ListaOperadorTelefonico As List(Of e_Combo) = New List(Of e_Combo)
    Dim olCombo As New l_Combo
#End Region

#Region "Instancia"

    Public Sub New(Tipo As String, oePerAux As e_Persona)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        BandMuestra = False
        mtManPersona.Visible = False
        ModoPresentacion = 0
        Select Case Tipo
            Case "Dir"
                leDireccionEP = oePerAux.leDireccionEP
                CargarDireccion(leDireccionEP)
                ActivaTab(0)
            Case "Tel2", "Tel1"
                vartel = IIf(Tipo = "Tel2", 2, 1)
                leTelefono = oePerAux.leTelefono
                CargarTelefono(leTelefono)
                ActivaTab(1)
            Case "Ema"
                leEmail = oePerAux.leEmail
                CargarEmail(leEmail)
                ActivaTab(2)
        End Select
    End Sub

    Public Sub New(Ope As Boolean, oeDerHabAux As e_DerechoHabiente)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        BandMuestra = False
        mtManPersona.Visible = True
        ModoPresentacion = 1
        oeDerHab.oePersona = oeDerHabAux.oePersona
        If Not Ope Then CargarDatos(oeDerHab.oePersona)
    End Sub

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        mtManPersona.Visible = False
    End Sub

    Private Shared Instancia As frm_Persona = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Instancia = New frm_Persona()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

    Public Function AgregarDireccion(ByVal IdPersona As String) As Boolean
        Try
            Inicializar()
            oePersona.Id = IdPersona
            oePersona.CargaCompleta = True
            oePersona = olPersona.Obtener(oePersona)
            CargarDatos(oePersona)
            MostrarTabs(1, ficPersona, 1)
            oePersona.TipoOperacion = "A"
            oePersona.Modificado = False
            ficDetalle.SelectedTab = ficDetalle.Tabs(0)
            'agrDatoDireccion.Expanded = True
            InicializarDireccion()
            oeDireccionEP.Modificado = False
            cboTipoVia.Focus()
            Band = True
            Operacion = "Editar"
            BandCbo = False
            MyBase.Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

#End Region

#Region "Métodos"

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            'Me.Cursor = Cursors.WaitCursor
            '  ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oePersona = New e_Persona
            oePersona.Activo = Activo
            Dim lePersona As New List(Of e_Persona)
            lePersona = olPersona.Listar(oePersona)
            CargarPersona(lePersona)
            '  ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griPersona.Focus()
    End Sub

    Private Sub Inicializar()

        txtCodigo.Text = String.Empty
        txtApellidoPaterno.Text = String.Empty
        txtApellidoMaterno.Text = String.Empty
        txtNombre.Text = String.Empty
        txtDni.Text = String.Empty
        fecFechaNacimiento.Value = Now.Date
        verActivo.Checked = True
        Sexo1.opcMasculino.Checked = True

        verCliente.Checked = False
        verProveedor.Checked = False
        verComisionista.Checked = False
        verComisionista.Enabled = True

        leDireccionEP = New List(Of e_Direccion_EmpresaPersona)
        CargarDireccion(leDireccionEP)
        leEmail = New List(Of e_Email)
        CargarEmail(leEmail)
        leTelefono = New List(Of e_Telefono)
        CargarTelefono(leTelefono)

        ficDetalle.SelectedTab = ficDetalle.Tabs(0)
        IniciaDetalle(griDireccion, mtDireccion, "Dir", ficDireccion)

        agrContenidoTP.Expanded = False
        'AsociarMenu()
        bandNuevaPersona = ""
        oCombo.Id = "TablaDinamica"
        oCombo.Nombre = "OperadorTelefonico"
        oCombo.Descripcion = "Nombre"        
        ListaOperadorTelefonico.AddRange(olCombo.Listar(oCombo))
        LlenarComboMaestro(cboOperador, ListaOperadorTelefonico, 0)
        CrearComboGrid("IdOperadorTelefonico", "Nombre", griTelefono, olCombo.ComboGrilla(ListaOperadorTelefonico), True)
    End Sub

    Private Sub Mostrar()
        Try
            If griPersona.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oePersona.Id = griPersona.ActiveRow.Cells("Id").Value.ToString
                oePersona.CargaCompleta = True
                oePersona = olPersona.Obtener(oePersona)
                CargarDatos(oePersona)
                ficDetalle.SelectedTab = ficDetalle.Tabs(0)
                MostrarTabs(1, ficPersona, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub MostrarContacto(ByVal codigo As String)
        'griPersona.ActiveRow.Cells("Id").Value.ToString.Length > 0
        Try
            If codigo <> "" Then
                bandContacto = "EC"                
                Inicializar()
                oePersona.Id = codigo
                oePersona.CargaCompleta = True
                oePersona = olPersona.Obtener(oePersona)
                CargarDatos(oePersona)
                ficDetalle.SelectedTab = ficDetalle.Tabs(0)
                MostrarTabs(1, ficPersona, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub ReemplazarPersona(ByVal persona As e_Persona)
        Try
            Dim ind = 0
            For Each obj As e_Persona In frm_Empresa.leContactos
                If obj.Id = persona.Id Then
                    frm_Empresa.leContactos.Item(ind) = persona
                    Exit For
                End If
                ind = ind + 1
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Function Guardando() As Boolean
        Try
            oePersona.leDireccionEP = leDireccionEP
            oePersona.leTelefono = leTelefono
            oePersona.leEmail = leEmail
            oePersona.oeSexo.Id = Sexo1.Sexo.Id
            oePersona.UsuarioCreacion = gUsuarioSGI.Id
            If listaContactos Is Nothing Then
                listaContactos = New List(Of e_Persona)
            End If
            
            If olPersona.Guardar(oePersona) <> "" Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                If oePersona.Id <> "" Then
                    oePersona.UsuarioCreacion = IIf(oePersona.leTelefono.Count > 0, ConcatenarTelf(oePersona.leTelefono), "")
                    ReemplazarPersona(oePersona)
                End If
                If bandNuevaPersona.Trim <> "" Then
                    frm_DemandaRapida.codigoNuevoComisionista = oePersona.oeClienteProveedor.Id
                Else
                    If BandCbo Then
                        MostrarTabs(0, ficPersona, 2)
                        Consultar(True)
                        griPersona.Focus()
                    End If
                End If
                Return True
            Else
                Return False
            End If


        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            Enfocar(ex.Message)
        End Try
    End Function

    Private Function ConcatenarTelf(ByVal lista As List(Of e_Telefono)) As String
        Dim cadena As String = ""
        Try

            For Each obj As e_Telefono In lista
                cadena = cadena + IIf(ListaOperadorTelefonico.Where(Function(item) item.Id = obj.IdOperadorTelefonico).Count > 0, ListaOperadorTelefonico.Where(Function(item) item.Id = obj.IdOperadorTelefonico).ToList.Item(0).Nombre.Substring(0, 3), "") + " " + obj.Nombre + " / "
            Next
        Catch ex As Exception
            Throw ex
        End Try
        Return cadena
    End Function
    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("Codigo") Then
            txtCodigo.Focus()
        End If
        If excepcion.Contains("Apellido Paterno") Then
            txtApellidoPaterno.Focus()
        End If
        If excepcion.Contains("Apellido Materno") Then
            txtApellidoMaterno.Focus()
        End If
        If excepcion.Contains("Nombre") Then
            txtNombre.Focus()
        End If
    End Sub

    'Private Sub AsociarMenu()
    '    griTelefono.ContextMenuStrip = mcDetalles
    '    griEmail.ContextMenuStrip = mcDetalles
    '    griDireccion.ContextMenuStrip = mcDetalles
    'End Sub

    'Private Sub Agregar(ByVal MiGrilla As Grilla, ByVal MiTipo As Integer)
    '    Try
    '        Dim oeTemp As New Object
    '        Select Case Tipo
    '            Case 1
    '                oeTemp = New e_Telefono
    '                Dim ListaTelefono As New List(Of e_Telefono)
    '                If MiGrilla.Rows.Count = 0 Then
    '                    CargarTelefono(ListaTelefono)
    '                    oePersona.leTelefono = ListaTelefono
    '                End If
    '                ListaTelefono = oePersona.leTelefono
    '                ListaTelefono.Add(oeTemp)
    '            Case 2
    '                oeTemp = New e_Email
    '                Dim ListaEmail As New List(Of e_Email)
    '                If MiGrilla.Rows.Count = 0 Then
    '                    CargarEmail(ListaEmail)
    '                    oePersona.leEmail = ListaEmail
    '                End If
    '                ListaEmail = oePersona.leEmail
    '                ListaEmail.Add(oeTemp)
    '            Case 3
    '        End Select
    '        MiGrilla.DataBind()
    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Sub

    'Private Sub Quitar(ByVal Migrilla As Grilla)
    '    Try
    '        If Migrilla.Rows.Count > 0 Then
    '            Migrilla.ActiveRow.Delete()
    '            Migrilla.Select()
    '        End If
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message)
    '    End Try
    'End Sub

    Private Sub CargarTelefono(ByVal leTel As List(Of e_Telefono))
        Try            
            Dim _leActivo As New List(Of e_Telefono)
            With griTelefono

                .ResetDisplayLayout()

                If vartel > 0 Then
                    _leActivo = leTel.Where(Function(it) it.Activo = True And it.Tipo = vartel).ToList
                Else
                    _leActivo = leTel.Where(Function(it) it.Activo = True).ToList
                End If

                .DataSource = _leActivo
                'And col.Key <> "CodigoLargaDistancia"
                For Each col In .DisplayLayout.Bands(0).Columns
                    If col.Key <> "Nombre" And col.Key <> "NomTipo" And col.Key <> "Principal" And col.Key <> "IdOperadorTelefonico" Then col.Hidden = True
                    If col.Key.Contains("Id") Then col.ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                    If col.Key = "Principal" Then
                        col.CellActivation = Activation.AllowEdit
                        col.CellClickAction = CellClickAction.Edit
                    Else
                        col.CellActivation = Activation.NoEdit
                        col.CellClickAction = CellClickAction.RowSelect
                    End If
                Next

                .DisplayLayout.Bands(0).Columns("Principal").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("NomTipo").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("CodigoLargaDistancia").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Nombre").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("IdOperadorTelefonico").Header.VisiblePosition = 4

                .DisplayLayout.Bands(0).Columns("Principal").Style = ColumnStyle.CheckBox                

                .DisplayLayout.Bands(0).Columns("CodigoLargaDistancia").Header.Caption = "Cod"

                .DisplayLayout.Bands(0).Columns("NomTipo").Width = 70
                .DisplayLayout.Bands(0).Columns("CodigoLargaDistancia").Width = 70
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 70
                .DisplayLayout.Bands(0).Columns("IdOperadorTelefonico").Header.Caption = "Operador"
                .DisplayLayout.Bands(0).Columns("Nombre").Header.Caption = "Numero"

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                ' .DisplayLayout.Override.FilterUIProvider = Filtro1
                '.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                '.DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

                oCombo.Id = "TablaDinamica"
                oCombo.Nombre = "OperadorTelefonico"
                oCombo.Descripcion = "Nombre"
                ListaOperadorTelefonico.AddRange(olCombo.Listar(oCombo))
                LlenarComboMaestro(cboOperador, ListaOperadorTelefonico, 0)
                CrearComboGrid("IdOperadorTelefonico", "Nombre", griTelefono, olCombo.ComboGrilla(ListaOperadorTelefonico), True)
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CargarEmail(ByVal leEma As List(Of e_Email))
        Try
            With griEmail

                .ResetDisplayLayout()
                Dim _leActivo = leEma.Where(Function(it) it.Activo = True).ToList
                .DataSource = _leActivo

                For Each col In .DisplayLayout.Bands(0).Columns
                    If col.Key <> "Nombre" And col.Key <> "Principal" Then col.Hidden = True
                    If col.Key.Contains("Id") Then col.ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                    If col.Key = "Principal" Then
                        col.CellActivation = Activation.AllowEdit
                        col.CellClickAction = CellClickAction.Edit
                    Else
                        col.CellActivation = Activation.NoEdit
                        col.CellClickAction = CellClickAction.RowSelect
                    End If
                Next

                .DisplayLayout.Bands(0).Columns("Principal").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("Nombre").Header.VisiblePosition = 1

                .DisplayLayout.Bands(0).Columns("Principal").Style = ColumnStyle.CheckBox

                .DisplayLayout.Bands(0).Columns("Nombre").Width = 250

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                ' .DisplayLayout.Override.FilterUIProvider = Filtro1
                '.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                '.DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

            End With

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

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
        txtCentroCosto.Text = String.Empty
        Ccpp1.Seleccionar(String.Empty)
        txtNombreDir.Text = String.Empty
        verCentroAsistenciaEsSalud.Checked = False
    End Sub

    Private Sub CargarCombo()
        Try
            Dim oeTipoZona As New e_TipoZona
            Dim olTipoZona As New l_TipoZona
            LlenarCombo(cboNombreZona, "Nombre", olTipoZona.Listar(oeTipoZona), -1)

            Dim oeTipoVia As New e_TipoVia
            Dim olTipoVia As New l_TipoVia
            LlenarCombo(cboTipoVia, "Nombre", olTipoVia.Listar(oeTipoVia), -1)

            Dim olTipoPago As New l_TipoPago
            oeTipoPago.TipoOperacion = ""
            oeTipoPago.Activo = True
            LlenarCombo(cboTipoPago, "Nombre", olTipoPago.Listar(oeTipoPago), -1)

            cboTipoTel.Items.Clear()
            cboTipoTel.Items.Add("MOVIL")
            cboTipoTel.Items.Add("FIJO")
            cboTipoTel.SelectedIndex = -1
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub CargarDireccion(ByVal leDEP As List(Of e_Direccion_EmpresaPersona))
        Try
            With griDireccion

                .ResetDisplayLayout()

                Dim _leActivo = leDEP.Where(Function(it) it.Activo = True).ToList

                .DataSource = _leActivo

                For Each col In .DisplayLayout.Bands(0).Columns
                    If col.Key <> "Nombre" And col.Key <> "Principal" Then col.Hidden = True
                    If col.Key.Contains("Id") Then col.ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
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

    Private Sub AgregarTP(ByVal oe As e_TipoPago)
        Try
            Dim oeEPTP As New e_PersonaEmpresa_TipoPago
            oeEPTP.IdTipoPago = oe.Id
            oeEPTP.IndClienteProveedor = IIf(optTipo.CheckedIndex = 0, 1, 2)
            If Not leTipoPago.Contains(oeEPTP) Then
                oePETipoPago.IdClienteProveedor = oePersona.oeClienteProveedor.Id
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

    Private Sub CargarDatos(ByVal oePers As e_Persona)
        Try
            With oePers
                If BandDni Then txtDni.Text = .Dni
                txtCodigo.Text = .Codigo
                txtApellidoPaterno.Text = .ApellidoPaterno
                txtApellidoMaterno.Text = .ApellidoMaterno
                txtNombre.Text = .Nombre
                fecFechaNacimiento.Value = .FechaNacimiento
                Sexo1.Sexo = New e_Sexo(CType(.oeSexo.Id, String))
                verActivo.Checked = .Activo
                verCliente.Checked = IIf(.oeClienteProveedor.Cliente = 1, True, False)
                verProveedor.Checked = IIf(.oeClienteProveedor.Proveedor = 1, True, False)
                verComisionista.Checked = IIf(.oeClienteProveedor.Comisionista = 1, True, False)
                leTelefono = .leTelefono
                CargarTelefono(leTelefono)
                leEmail = .leEmail
                CargarEmail(leEmail)
                leDireccionEP = .leDireccionEP
                CargarDireccion(leDireccionEP)
                leTipoPago = .leTipoPago
                CargarPETipoPago(leTipoPago)
            End With
        Catch ex As Exception
            Throw ex
        End Try

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
            .Tools.Item("Listar" & Pref).SharedProps.Enabled = Listar
            .Tools.Item("Agregar" & Pref).SharedProps.Enabled = Agregar
            .Tools.Item("Modificar" & Pref).SharedProps.Enabled = Modificar
            .Tools.Item("Grabar" & Pref).SharedProps.Enabled = Grabar
            .Tools.Item("Cancelar" & Pref).SharedProps.Enabled = Cancelar
            .Tools.Item("Quitar" & Pref).SharedProps.Enabled = Quitar
            .Tools.Item("Regresar" & Pref).SharedProps.Enabled = Regresar
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

    Private Sub ActivaTab(Orden As Integer)
        For Each xtab In ficDetalle.Tabs
            If xtab.Index = Orden Then
                xtab.Visible = True
            Else
                xtab.Visible = False
            End If
        Next
    End Sub

    Private Sub CargarPersona(lePer As List(Of e_Persona))
        Try
            With griPersona
                .DataSource = lePer
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdContacto").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaNacimiento").Hidden = False
                .DisplayLayout.Bands(0).Columns("Nombre").Hidden = False
                .DisplayLayout.Bands(0).Columns("ApellidoPaterno").Hidden = False
                .DisplayLayout.Bands(0).Columns("ApellidoMaterno").Hidden = False
                .DisplayLayout.Bands(0).Columns("Dni").Hidden = False

                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
                If bandContacto.Trim <> "" Then
                    .DisplayLayout.Bands(0).Columns("Contacto").Hidden = False
                    .DisplayLayout.Bands(0).Columns("Contacto").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
                    .DisplayLayout.Bands(0).Columns("Contacto").Header.VisiblePosition = 8
                    '   ControlBoton(1, 1, 0, 1, 1, 0, 0, 0, 0)
                Else
                    .DisplayLayout.Bands(0).Columns("Contacto").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Contacto").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub BuscarPersona(ByVal listaContactos As List(Of e_Persona))
        Try
            Me.listaContactos = listaContactos
            bandContacto = "S"
            oePersona = New e_Persona
            oePersona.Activo = 1
            Dim lePersona As New List(Of e_Persona)
            lePersona = olPersona.Listar(oePersona)
            CargarPersona(lePersona)
            Me.btnAgregarContacto.Visible = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.ToString, True)
        End Try

    End Sub
    Dim bandNuevaPersona As String = ""
    Public Sub NuevaPersona()
        oePersona.TipoOperacion = "I"
        MostrarTabs(1, ficPersona, 1)
        Inicializar()
        txtCodigo.Focus()
        ' agrDatoDireccion.Expanded = False
        ficDetalle.SelectedTab = ficDetalle.Tabs(0)
        Operacion = "Nuevo"
        Me.listaContactos.Clear()
        BandCbo = False
        bandNuevaPersona = "0"
        verComisionista.Checked = True
        verComisionista.Enabled = False
        MyBase.Nuevo()
    End Sub


#End Region

#Region "Eventos"

    Private Sub frm_Persona_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If BandMuestra Then
            Select Case Operacion
                Case "Nuevo"
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)

                Case "Editar"
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)

                Case "Inicializa"
                    If _Activo Then
                        ControlBoton(1, 1, 1, 0, 0, 0, 0, 0, 1)
                    Else
                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                    End If
            End Select
        Else
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        End If
        If bandContacto.Trim <> "" Then
            agrPersona.Text = "Datos del Contacto"
            Me.btnAgregarContacto.Visible = True
            Me.groupBtnAgregar.Visible = True
        Else
            agrPersona.Text = "Datos"
            Me.btnAgregarContacto.Visible = False
            Me.groupBtnAgregar.Visible = False
            'Me.griPersona.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub frm_Persona_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_Persona_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If BandMuestra Then
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
                    ControlBoton()
                End If
            Else
                BandCbo = True
            End If
        End If
    End Sub

    Private Sub frm_Persona_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If BandMuestra Then
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                Tiempo1.Enabled = False
                MostrarTabs(0, ficPersona)
                CargarCombo()
                CargarPersona(New List(Of e_Persona))
                agrContenidoTP.Expanded = False
                If PersonaMerma <> "" Then
                    ficDetalle.Visible = False
                    ficPersona.Tabs(0).Enabled = False
                    ficPersona.Tabs(1).Selected = True
                    ficPersona.Tabs(1).Enabled = True
                    btnGuardarProveedor.Visible = True
                End If
            Else
                ficPersona.Tabs(1).Selected = True
                ficPersona.Tabs(0).Enabled = False
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                CargarCombo()
                Select Case ModoPresentacion
                    Case 0
                        agrPersona.Visible = False
                        ficDetalle.Dock = DockStyle.Fill
                    Case 1
                        agrTipoPersona.Visible = False
                        btnGuardarProveedor.Visible = False
                End Select
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        oePersona.Modificado = True
    End Sub

    Private Sub txtApellidoPaterno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtApellidoPaterno.KeyDown
        oePersona.Modificado = True
    End Sub

    Private Sub txtApellidoMaterno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtApellidoMaterno.KeyDown
        oePersona.Modificado = True
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        oePersona.Modificado = True
    End Sub

    Private Sub txtDni_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDni.KeyDown
        oePersona.Modificado = True
    End Sub

    Private Sub txtEstadoCivil_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        oePersona.Modificado = True
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        oePersona.Codigo = txtCodigo.Text.Trim
    End Sub

    Private Sub txtApellidoPaterno_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtApellidoPaterno.ValueChanged
        oePersona.ApellidoPaterno = txtApellidoPaterno.Text.Trim
    End Sub

    Private Sub txtApellidoMaterno_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtApellidoMaterno.ValueChanged
        oePersona.ApellidoMaterno = txtApellidoMaterno.Text.Trim
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        oePersona.Nombre = txtNombre.Text.Trim
    End Sub

    Private Sub txtDni_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDni.ValueChanged
        oePersona.Dni = txtDni.Text.Trim
        If Not BandMuestra AndAlso ModoPresentacion = 1 Then
            If txtDni.Text.Length = 8 Then
                BandDni = False
                oePersona.CargaCompleta = True
                oePersona = olPersona.Obtener(oePersona)
                If Not String.IsNullOrEmpty(oePersona.Id) Then
                    CargarDatos(oePersona)
                    BandDni = True
                End If
            End If
        End If
        If Not String.IsNullOrEmpty(txtDni.Text) Then PictureBox1.Image = olPersona.Foto(oePersona.Dni)
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oePersona.Activo = verActivo.Checked
    End Sub

    Private Sub fecFechaNacimiento_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fecFechaNacimiento.ValueChanged
        oePersona.FechaNacimiento = fecFechaNacimiento.Value
    End Sub

    Private Sub griPersona_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griPersona.DoubleClick
        Editar()
    End Sub

    Private Sub griPersona_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griPersona.InitializeLayout
        agrGrillaPersona.Text = "Listado de Personas: " & griPersona.Rows.Count
    End Sub

    Private Sub Sexo1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Sexo1.Validating
        oePersona.oeSexo.Id = Sexo1.Sexo.Id
    End Sub

    'Private Sub tsmiAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiAgregar.Click
    '    If Tipo > 0 Then
    '        Agregar(griTemp, Tipo)
    '    Else
    '        InicializarDireccion()
    '        'CargarCombo()
    '        'agrDatoDireccion.Expanded = True
    '    End If
    'End Sub

    'Private Sub tsmiQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiQuitar.Click
    '    If Tipo > 0 Then
    '        Quitar(griTemp)
    '    Else
    '        QuitarDireccion()
    '    End If
    'End Sub

    Private Sub ficDetalle_SelectedTabChanged(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles ficDetalle.SelectedTabChanged
        Select Case ficDetalle.SelectedTab.Index
            Case 0
                Tipo = 0
                IniciaDetalle(griDireccion, mtDireccion, "Dir", ficDireccion)
            Case 1
                Tipo = 1
                '   IniciaDetalle(griTelefono, mtTelefono, "Tel", ficTelefono)
            Case 2
                Tipo = 2
                IniciaDetalle(griEmail, mtEmail, "Ema", ficEmail)
            Case 3

        End Select
    End Sub

    'Private Sub griTelefono_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griTelefono.KeyDown
    '    TecladoGrilla(griTelefono, e)
    'End Sub

    Private Sub griEmail_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griEmail.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show("¿Desea Quitar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    'Private Sub griEmail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griEmail.KeyDown
    '    TecladoGrilla(griEmail, e)
    'End Sub

    Private Sub griTelefono_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griTelefono.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show("¿Desea Quitar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            AgregarDireccion()
            If MessageBox.Show("¿Desea seguir Agregando Direcciones?", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                InicializarDireccion()
            Else
                ' agrDatoDireccion.Expanded = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        'agrDatoDireccion.Expanded = False
    End Sub

    Private Sub verCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verCliente.CheckedChanged
        oePersona.oeClienteProveedor.Cliente = IIf(verCliente.Checked, 1, 0)
    End Sub

    Private Sub verProveedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verProveedor.CheckedChanged
        oePersona.oeClienteProveedor.Proveedor = IIf(verProveedor.Checked, 1, 0)
    End Sub

    Private Sub verComisionista_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verComisionista.CheckedChanged
        oePersona.oeClienteProveedor.Comisionista = IIf(verComisionista.Checked, 1, 0)
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
                agrContenidoTP.Expanded = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCancelarTP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarTP.Click
        agrContenidoTP.Expanded = False
    End Sub

    Private Sub btnGuardarProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarProveedor.Click
        Guardar()
    End Sub

    Private Sub mtManPersona_ToolClick(sender As Object, e As ToolClickEventArgs) Handles mtManPersona.ToolClick
        Try
            Select Case e.Tool.Key
                Case "GrabarPer"
                    If oePersona.Id.Trim <> String.Empty Then
                        oePersona.TipoOperacion = "A"
                    Else
                        oePersona.TipoOperacion = "I"
                    End If
                    oeDerHab.oePersona = oePersona : oeDerHab.oePersona.leDireccionEP = leDireccionEP : oeDerHab.oePersona.leTelefono = leTelefono
                    oePersona.oeSexo.Id = Sexo1.Sexo.Id
                    mensajeEmergente.Confirmacion("¡Los Datos se han Guardado Correctamente!", True)
                    Me.Close()
                Case "CancelarPer"
                    If MessageBox.Show("¿Desea cancelar la Operacion", "Mensaje de Sistema", MessageBoxButtons.YesNo _
                                , MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        Me.Close()
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griPersona_ClickCell(sender As Object, e As ClickCellEventArgs) Handles griPersona.ClickCell
        Try
            With griPersona.ActiveRow
                If griPersona.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                    If .Cells("Contacto").Value IsNot Nothing Then
                        If .Cells("Contacto").Value = False Then
                            If buscarYaAgregados(.Cells("Id").Value) Then
                                .Cells("Contacto").Value = True
                            Else
                                mensajeEmergente.Confirmacion("Persona ya se encunetra en la lista", True)
                            End If
                        Else
                            .Cells("Contacto").Value = False
                        End If


                    End If
                End If

            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)

        End Try

    End Sub

    Private Sub btnAgregarContacto_Click(sender As Object, e As EventArgs) Handles btnAgregarContacto.Click
        If guardarContacto() Then
            Me.Close()
            bandContacto = ""
        End If
    End Sub

    Private Sub btnGuardarTelf_Click(sender As Object, e As EventArgs) Handles btnGuardarTelf.Click
        Try
            Dim oeTelAux As New e_Telefono
            Dim _idTel As String = String.Empty
            RecogerDatosTel()
            oeTelefono.Equivale = 1
            If Not leTelefono.Contains(oeTelefono) Then
                oeTelefono.Equivale = 2
                If Not leTelefono.Contains(oeTelefono) Then
                    oeTelefono.TipoOperacion = "I"
                    oeTelefono.Id = leTelefono.Count + 1
                    If griTelefono.Rows.Count = 0 Then CargarTelefono(leTelefono) : oeTelefono.Principal = 1
                    leTelefono.Add(oeTelefono)
                Else
                    oeTelAux = leTelefono.Item(leTelefono.IndexOf(oeTelefono))
                    If oeTelAux.TipoOperacion = "E" Then
                        oeTelAux.Activo = True
                        oeTelAux.TipoOperacion = "A"
                    Else
                        Throw New Exception("El Numero: " & oeTelAux.Nombre & " ya esta Registrado")
                    End If
                End If
            Else
                oeTelAux = New e_Telefono
                oeTelAux = leTelefono.Item(leTelefono.IndexOf(oeTelefono))
                _idTel = oeTelAux.Id
                oeTelefono.Equivale = 2
                If Not leTelefono.Contains(oeTelefono) Then
                    oeTelAux.Tipo = oeTelefono.Tipo
                    oeTelAux.NomTipo = oeTelefono.NomTipo
                    oeTelAux.Nombre = oeTelefono.Nombre
                    oeTelAux.TipoOperacion = "A"
                Else
                    oeTelAux = leTelefono.Item(leTelefono.IndexOf(oeTelefono))
                    If oeTelAux.TipoOperacion = "E" Then
                        oeTelAux.Activo = True
                        oeTelAux.TipoOperacion = "A"
                    Else
                        If oeTelAux.Id = _idTel Then
                            oeTelAux.TipoOperacion = "A"
                        Else
                            Throw New Exception("El Numero: " & oeTelAux.Nombre & " ya esta Registrado")
                        End If
                    End If
                End If
            End If
            CargarTelefono(leTelefono)
            InicializarTelefono()
            oeTelefono = New e_Telefono
            oeTelefono.TipoOperacion = "I"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        Try
            Select Case ficDetalle.SelectedTab.Index
                Case 1
                    EditarTelefono()
            End Select

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub tsmiAgregar_Click(sender As Object, e As EventArgs) Handles tsmiAgregar.Click
        Try
            Select Case ficDetalle.SelectedTab.Index
                Case 1
                    InicializarTelefono()
                    oeTelefono = New e_Telefono
                    oeTelefono.TipoOperacion = "I"
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub tsmiQuitar_Click(sender As Object, e As EventArgs) Handles tsmiQuitar.Click
        Try
            Select Case ficDetalle.SelectedTab.Index
                Case 1
                    QuitarTelefono()
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#Region "Direccion"

    Private Sub mtDireccion_ToolClick(sender As System.Object, e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles mtDireccion.ToolClick
        Try
            Select Case e.Tool.Key
                Case "ListarDir"
                    CargarDireccion(leDireccionEP)
                Case "AgregarDir"
                    InicializarDireccion()
                    oeDireccionEP = New e_Direccion_EmpresaPersona
                    oeDireccionEP.TipoOperacion = "I"
                    MostrarTabs(1, ficDireccion)
                    ControlSubMenu(mtDireccion, "Dir", 0, 0, 0, 1, 1, 0, 0)
                Case "ModificarDir"
                    EditarDireccion()
                Case "GrabarDir"
                    AgregarDireccion()
                    mensajeEmergente.Confirmacion("¡Los Datos se Guardaron Correctamente!", True)
                    IniciaDetalle(griDireccion, mtDireccion, "Dir", ficDireccion)
                Case "CancelarDir"
                    If MessageBox.Show("¿Desea cancelar la Operacion", "Mensaje de Sistema", MessageBoxButtons.YesNo _
                                       , MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        IniciaDetalle(griDireccion, mtDireccion, "Dir", ficDireccion)
                    End If
                Case "QuitarDir"
                    QuitarDireccion()
                Case "RegresarDir"

            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub cboNumero_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'RecogerDatosDir()
        CargaNombreDir()
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
                'RecogerDatosDir()
                CargaNombreDir()
            End If
        Else
            txtNombreVia.Enabled = False : txtNumero.Enabled = False : txtNumeroInterior.Enabled = False
        End If
    End Sub

    Private Sub txtNombreVia_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombreVia.ValueChanged
        'RecogerDatosDir()
        CargaNombreDir()
    End Sub

    Private Sub txtNumero_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.ValueChanged
        'RecogerDatosDir()
        CargaNombreDir()
    End Sub

    Private Sub txtNumeroInterior_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumeroInterior.ValueChanged
        'RecogerDatosDir()
        CargaNombreDir()
    End Sub

    Private Sub cboNombreZona_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNombreZona.ValueChanged
        If cboNombreZona.SelectedIndex > -1 Then
            txtNombreZona.Enabled = IIf(cboNombreZona.Text = "NINGUNO", False, True)
            If cboNombreZona.Text <> "NINGUNO" Then
                ' RecogerDatosDir()
                CargaNombreDir()
            End If
        Else
            txtNumeroInterior.Enabled = False
        End If
    End Sub

    Private Sub txtNombreZona_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombreZona.ValueChanged
        'RecogerDatosDir()
        CargaNombreDir()
    End Sub

    Private Sub txtReferencia_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReferencia.ValueChanged
        'RecogerDatosDir()
        CargaNombreDir()
    End Sub

    Private Sub txtCentroCosto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCentroCosto.ValueChanged
        'oeDireccionEP.CentroCosto = txtCentroCosto.Text
    End Sub

    Private Sub griDireccion_DoubleClick(sender As System.Object, e As System.EventArgs) Handles griDireccion.DoubleClick
        Try
            EditarDireccion()
        Catch ex As Exception
            mensajeEmergente.Confirmacion(ex.Message, True)
        End Try
    End Sub

    Private Sub griDireccion_CellChange(sender As System.Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griDireccion.CellChange
        Try
            griDireccion.UpdateData()
            If e.Cell.Column.Key.ToString = "Principal" AndAlso e.Cell.Row.Index > -1 Then
                Dim _idDir As String = ""
                oeDireccionEP = New e_Direccion_EmpresaPersona
                _idDir = griDireccion.Rows(e.Cell.Row.Index).Cells("Id").Value
                oeDireccionEP.Id = _idDir
                oeDireccionEP.Equivale = "2"
                If leDireccionEP.Contains(oeDireccionEP) Then
                    oeDireccionEP = leDireccionEP.Item(leDireccionEP.IndexOf(oeDireccionEP))
                    Dim _leDirAux = leDireccionEP.Where(Function(it) it.Principal = 1 And it.Id <> _idDir).ToList
                    If oeDireccionEP.Principal = 1 Then
                        If _leDirAux.Count > 0 Then
                            If MessageBox.Show("La Direccion: " & _leDirAux(0).Nombre & " esta como Principal." & Environment.NewLine & _
                                               "¿Desea Cambiar la que ha seleccionado?", "Mensaje de Sistema", MessageBoxButtons.YesNo, _
                                                MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                                Dim oeDirAux = New e_Direccion_EmpresaPersona
                                oeDirAux.Id = _leDirAux(0).Id
                                oeDirAux.Equivale = "2"
                                oeDirAux = leDireccionEP.Item(leDireccionEP.IndexOf(oeDirAux))
                                oeDirAux.Principal = 0
                                oeDirAux.TipoOperacion = IIf(oeDirAux.Id.Trim = "", "I", "A")
                            Else
                                oeDireccionEP.Principal = 0
                                oeDireccionEP.TipoOperacion = IIf(oeDireccionEP.Id.Trim = "", "I", "A")
                            End If
                        Else
                            oeDireccionEP.TipoOperacion = IIf(oeDireccionEP.Id.Trim = "", "I", "A")
                        End If
                    Else
                        If _leDirAux.Count > 0 Then
                            oeDireccionEP.TipoOperacion = IIf(oeDireccionEP.Id.Trim = "", "I", "A")
                        Else
                            mensajeEmergente.Confirmacion("Esta persona debe tener al menos una Direccion principal", True)
                            oeDireccionEP.Principal = 1
                            oeDireccionEP.TipoOperacion = IIf(oeDireccionEP.Id.Trim = "", "I", "A")
                        End If
                    End If
                    CargarDireccion(leDireccionEP)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Ccpp1_DatoCambiado(ByVal Id As System.String)
        'RecogerDatosDir()
        CargaNombreDir()
        'Erick control nuevo para que manejes los centros poblados
        'Ccpp1.Seleccionar(oeDireccionEP.CCPP)
    End Sub

    Private Sub txtDepartamento_ValueChanged(sender As Object, e As EventArgs) Handles txtDepartamento.ValueChanged
        ' RecogerDatosDir()
        CargaNombreDir()
    End Sub

    Private Sub txtManzana_ValueChanged(sender As Object, e As EventArgs) Handles txtManzana.ValueChanged
        'RecogerDatosDir()
        CargaNombreDir()
    End Sub

    Private Sub txtLote_ValueChanged(sender As Object, e As EventArgs) Handles txtLote.ValueChanged
        'RecogerDatosDir()
        CargaNombreDir()
    End Sub

    Private Sub txtKilometro_ValueChanged(sender As Object, e As EventArgs) Handles txtKilometro.ValueChanged
        ' RecogerDatosDir()
        CargaNombreDir()
    End Sub

    Private Sub txtBlock_ValueChanged(sender As Object, e As EventArgs) Handles txtBlock.ValueChanged
        'RecogerDatosDir()
        CargaNombreDir()
    End Sub

    Private Sub txtEtapa_ValueChanged(sender As Object, e As EventArgs) Handles txtEtapa.ValueChanged
        ' RecogerDatosDir()
        CargaNombreDir()
    End Sub

    Private Sub AgregarDireccion()
        Try
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
                        If Band Then
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
                        If Band Then
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
                    Ccpp1.Seleccionar(.oeDireccion.CCPP)
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
            ControlSubMenu(mtDireccion, "Dir", 0, 0, 0, 1, 1, 0, 0)
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
        If cboNombreZona.Text <> "NINGUNO" Then
            Dim oeTZona As New e_TipoZona
            oeTZona = cboNombreZona.Items(cboNombreZona.SelectedIndex).ListObject
            oeDireccionEP.oeDireccion.TipoZona = oeTZona.Abreviatura
        End If
        oeDireccionEP.oeDireccion.Zona = txtNombreZona.Text
        oeDireccionEP.oeDireccion.Referencia = txtReferencia.Text
        oeDireccionEP.oeDireccion.CentroCosto = txtCentroCosto.Text
        oeDireccionEP.oeDireccion.CCPP = Ccpp1.Id
        oeDireccionEP.oeDireccion.NombreCCPP = Ccpp1.Departamento1.Nombre & " - " & _
              Ccpp1.Provincia1.Nombre & " - " & Ccpp1.Distrito1.Nombre
        oeDireccionEP._nombredd = Ccpp1.Departamento1.Nombre
        oeDireccionEP._nombrepp = Ccpp1.Provincia1.Nombre
        oeDireccionEP._nombredi = Ccpp1.Distrito1.Nombre
    End Sub

#End Region

#Region "Telefono"

    Private Sub mtTelefono_ToolClick(sender As System.Object, e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles mtTelefono.ToolClick
        Try
            Select Case e.Tool.Key
                Case "ListarTel"
                    CargarTelefono(leTelefono)
                Case "AgregarTel"
                    InicializarTelefono()
                    oeTelefono = New e_Telefono
                    oeTelefono.TipoOperacion = "I"
                    '  MostrarTabs(1, ficTelefono)
                    ControlSubMenu(mtTelefono, "Tel", 0, 0, 0, 1, 1, 0, 0)
                Case "ModificarTel"
                    EditarTelefono()
                Case "GrabarTel"
                    AgregarTelefono()
                    mensajeEmergente.Confirmacion("¡Los Datos se Guardaron Correctamente!", True)
                    '   IniciaDetalle(griTelefono, mtTelefono, "Tel", ficTelefono)
                Case "CancelarTel"
                    If MessageBox.Show("¿Desea cancelar la Operacion", "Mensaje de Sistema", MessageBoxButtons.YesNo _
                                       , MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        '    IniciaDetalle(griTelefono, mtTelefono, "Tel", ficTelefono)
                    End If
                Case "QuitarTel"
                    QuitarTelefono()
                Case "RegresarTel"

            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griTelefono_DoubleClick(sender As System.Object, e As System.EventArgs) Handles griTelefono.DoubleClick
        If griTelefono.Rows.Count > 0 Then EditarTelefono()
    End Sub

    Private Sub griTelefono_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griTelefono.CellChange
        Try
            griTelefono.UpdateData()
            If e.Cell.Column.Key.ToString = "Principal" AndAlso e.Cell.Row.Index > -1 Then
                Dim _idTel As String = "", _tipo As String = ""
                oeTelefono = New e_Telefono
                _idTel = griTelefono.Rows(e.Cell.Row.Index).Cells("Id").Value
                _tipo = griTelefono.Rows(e.Cell.Row.Index).Cells("Tipo").Value
                oeTelefono.Id = _idTel
                oeTelefono.Equivale = 1
                If leTelefono.Contains(oeTelefono) Then
                    oeTelefono = leTelefono.Item(leTelefono.IndexOf(oeTelefono))
                    Dim _leTelAux = leTelefono.Where(Function(it) it.Principal = 1 And it.Id <> _idTel And it.Tipo = _tipo).ToList
                    If oeTelefono.Principal = 1 Then
                        If _leTelAux.Count > 0 Then
                            If MessageBox.Show("El Telefono: " & _leTelAux(0).Nombre & " esta como Principal." & Environment.NewLine & _
                                               "¿Desea Cambiar la que ha seleccionado?", "Mensaje de Sistema", MessageBoxButtons.YesNo, _
                                                MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                                Dim oeTelAux = New e_Telefono
                                oeTelAux.Id = _leTelAux(0).Id
                                oeTelAux.Equivale = 1
                                oeTelAux = leTelefono.Item(leTelefono.IndexOf(oeTelAux))
                                oeTelAux.Principal = 0
                                oeTelAux.TipoOperacion = IIf(oeTelAux.Id.Trim = "", "I", "A")
                            Else
                                oeTelefono.Principal = 0
                                oeTelefono.TipoOperacion = IIf(oeTelefono.Id.Trim = "", "I", "A")
                            End If
                        Else
                            oeTelefono.TipoOperacion = IIf(oeTelefono.Id.Trim = "", "I", "A")
                        End If
                    Else
                        If _leTelAux.Count > 0 Then
                            oeTelefono.TipoOperacion = IIf(oeTelefono.Id.Trim = "", "I", "A")
                        Else
                            mensajeEmergente.Confirmacion("Esta persona debe tener al menos una Telefono principal", True)
                            oeTelefono.Principal = 1
                            oeTelefono.TipoOperacion = IIf(oeTelefono.Id.Trim = "", "I", "A")
                        End If
                    End If
                    CargarTelefono(leTelefono)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTipoTel_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoTel.ValueChanged
        txtCodigoLargaDistancia.ReadOnly = IIf(cboTipoTel.Text = "FIJO", False, True)
    End Sub

    Private Sub txtCodigoLargaDistancia_ValueChanged(sender As Object, e As EventArgs) Handles txtCodigoLargaDistancia.ValueChanged
        'RecogerDatosTel()
    End Sub

    Private Sub InicializarTelefono()
        If vartel > 0 Then
            cboTipoTel.ReadOnly = True
            cboTipoTel.SelectedIndex = vartel - 1
        Else
            cboTipoTel.ReadOnly = False
            cboTipoTel.SelectedIndex = -1
        End If
        txtNumTel.Text = String.Empty
    End Sub

    Private Sub EditarTelefono()
        InicializarTelefono()
        MostrarTelefono()
        oeTelefono.TipoOperacion = "A"
        ' MostrarTabs(1, ficTelefono)
        ControlSubMenu(mtTelefono, "Tel", 0, 0, 0, 1, 1, 0, 0)
    End Sub

    Private Sub MostrarTelefono()
        Try
            oeTelefono = New e_Telefono
            oeTelefono.Id = griTelefono.ActiveRow.Cells("Id").Value
            oeTelefono.Equivale = 1
            If leTelefono.Contains(oeTelefono) Then
                oeTelefono = leTelefono.Item(leTelefono.IndexOf(oeTelefono))
                cboTipoTel.Text = oeTelefono.NomTipo
                txtCodigoLargaDistancia.Text = oeTelefono.CodigoLargaDistancia
                txtNumTel.Text = oeTelefono.Nombre
                Me.cboOperador.Value = oeTelefono.IdOperadorTelefonico
                Me.chkPrincipal.Checked = IIf(oeTelefono.Principal = 1, True, False)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarTelefono()
        Try
            Dim oeTelAux As New e_Telefono
            Dim _idTel As String = String.Empty
            RecogerDatosTel()
            oeTelefono.Equivale = 1
            If Not leTelefono.Contains(oeTelefono) Then
                oeTelefono.Equivale = 2
                If Not leTelefono.Contains(oeTelefono) Then
                    oeTelefono.TipoOperacion = "I"
                    oeTelefono.Id = leTelefono.Count + 1
                    If griTelefono.Rows.Count = 0 Then CargarTelefono(leTelefono) : oeTelefono.Principal = 1
                    leTelefono.Add(oeTelefono)
                Else
                    oeTelAux = leTelefono.Item(leTelefono.IndexOf(oeTelefono))
                    If oeTelAux.TipoOperacion = "E" Then
                        oeTelAux.Activo = True
                        oeTelAux.TipoOperacion = "A"
                    Else
                        Throw New Exception("El Numero: " & oeTelAux.Nombre & " ya esta Registrado")
                    End If
                End If
            Else
                oeTelAux = New e_Telefono
                oeTelAux = leTelefono.Item(leTelefono.IndexOf(oeTelefono))
                _idTel = oeTelAux.Id
                oeTelefono.Equivale = 2
                If Not leTelefono.Contains(oeTelefono) Then
                    oeTelAux.Tipo = oeTelefono.Tipo
                    oeTelAux.NomTipo = oeTelefono.NomTipo
                    oeTelAux.Nombre = oeTelefono.Nombre
                    oeTelAux.TipoOperacion = "A"
                Else
                    oeTelAux = leTelefono.Item(leTelefono.IndexOf(oeTelefono))
                    If oeTelAux.TipoOperacion = "E" Then
                        oeTelAux.Activo = True
                        oeTelAux.TipoOperacion = "A"
                    Else
                        If oeTelAux.Id = _idTel Then
                            oeTelAux.TipoOperacion = "A"
                        Else
                            Throw New Exception("El Numero: " & oeTelAux.Nombre & " ya esta Registrado")
                        End If
                    End If
                End If
            End If
            CargarTelefono(leTelefono)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarTelefono()
        Try
            oeTelefono = New e_Telefono
            oeTelefono.Id = griTelefono.ActiveRow.Cells("Id").Value
            oeTelefono.Equivale = 1
            If leTelefono.Contains(oeTelefono) Then
                oeTelefono = leTelefono.Item(leTelefono.IndexOf(oeTelefono))
                If oeTelefono.TipoOperacion = "I" Then
                    leTelefono.Remove(oeTelefono)
                Else
                    oeTelefono.TipoOperacion = "E"
                    oeTelefono.Activo = False
                End If
                CargarTelefono(leTelefono)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub RecogerDatosTel()
        oeTelefono.Tipo = cboTipoTel.SelectedIndex + 1
        oeTelefono.NomTipo = cboTipoTel.Text
        oeTelefono.CodigoLargaDistancia = txtCodigoLargaDistancia.Text.Trim
        oeTelefono.Nombre = txtNumTel.Text
        oeTelefono.IdOperadorTelefonico = Me.cboOperador.Value
        oeTelefono.Principal = IIf(Me.chkPrincipal.Checked, 1, 0)
    End Sub

#End Region

#Region "Email"

    Private Sub mtEmail_ToolClick(sender As System.Object, e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles mtEmail.ToolClick
        Select Case e.Tool.Key
            Case "ListarEma"
                CargarEmail(leEmail)
            Case "AgregarEma"
                InicializarEmail()
                oeEmail = New e_Email
                oeEmail.TipoOperacion = "I"
                MostrarTabs(1, ficEmail)
                ControlSubMenu(mtEmail, "Ema", 0, 0, 0, 1, 1, 0, 0)
            Case "ModificarEma"
                EditarEmail()
            Case "GrabarEma"
                AgregarEmail()
                mensajeEmergente.Confirmacion("¡Los Datos se Guardaron Correctamente!", True)
                IniciaDetalle(griEmail, mtEmail, "Ema", ficEmail)
            Case "CancelarEma"
                If MessageBox.Show("¿Desea cancelar la Operacion", "Mensaje de Sistema", MessageBoxButtons.YesNo _
                                   , MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    IniciaDetalle(griEmail, mtEmail, "Ema", ficEmail)
                End If
            Case "QuitarEma"
                QuitarEmail()
            Case "RegresarEma"

        End Select
    End Sub

    Private Sub griEmail_DoubleClick(sender As System.Object, e As System.EventArgs) Handles griEmail.DoubleClick
        If griEmail.Rows.Count > 0 Then EditarEmail()
    End Sub

    Private Sub griEmail_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griEmail.CellChange
        Try
            griEmail.UpdateData()
            If e.Cell.Column.Key.ToString = "Principal" AndAlso e.Cell.Row.Index > -1 Then
                Dim _idEma As String = ""
                oeEmail = New e_Email
                _idEma = griEmail.Rows(e.Cell.Row.Index).Cells("Id").Value
                oeEmail.Id = _idEma
                oeEmail.Equivale = 1
                If leEmail.Contains(oeEmail) Then
                    oeEmail = leEmail.Item(leEmail.IndexOf(oeEmail))
                    Dim _leEmaAux = leEmail.Where(Function(it) it.Principal = 1 And it.Id <> _idEma).ToList
                    If oeEmail.Principal = 1 Then
                        If _leEmaAux.Count > 0 Then
                            If MessageBox.Show("El Telefono: " & _leEmaAux(0).Nombre & " esta como Principal." & Environment.NewLine & _
                                               "¿Desea Cambiar la que ha seleccionado?", "Mensaje de Sistema", MessageBoxButtons.YesNo, _
                                                MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                                Dim oeEmaAux = New e_Email
                                oeEmaAux.Id = _leEmaAux(0).Id
                                oeEmaAux.Equivale = 1
                                oeEmaAux = leEmail.Item(leEmail.IndexOf(oeEmaAux))
                                oeEmaAux.Principal = 0
                                oeEmaAux.TipoOperacion = IIf(oeEmaAux.Id.Trim = "", "I", "A")
                            Else
                                oeEmail.Principal = 0
                                oeEmail.TipoOperacion = IIf(oeEmail.Id.Trim = "", "I", "A")
                            End If
                        Else
                            oeEmail.TipoOperacion = IIf(oeEmail.Id.Trim = "", "I", "A")
                        End If
                    Else
                        If _leEmaAux.Count > 0 Then
                            oeEmail.TipoOperacion = IIf(oeEmail.Id.Trim = "", "I", "A")
                        Else
                            mensajeEmergente.Confirmacion("Esta persona debe tener al menos una Email principal", True)
                            oeEmail.Principal = 1
                            oeEmail.TipoOperacion = IIf(oeEmail.Id.Trim = "", "I", "A")
                        End If
                    End If
                    CargarEmail(leEmail)
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub InicializarEmail()
        txtNomEmail.Text = String.Empty
        txtNomEmail.CharacterCasing = CharacterCasing.Normal
    End Sub

    Private Sub EditarEmail()
        InicializarEmail()
        MostarEmail()
        oeEmail.TipoOperacion = "A"
        MostrarTabs(1, ficEmail)
        ControlSubMenu(mtEmail, "Ema", 0, 0, 0, 1, 1, 0, 0)
    End Sub

    Private Sub MostarEmail()
        Try
            oeEmail = New e_Email
            oeEmail.Id = griEmail.ActiveRow.Cells("Id").Value
            oeEmail.Equivale = 1
            If leEmail.Contains(oeEmail) Then
                oeEmail = leEmail.Item(leEmail.IndexOf(oeEmail))
                txtNomEmail.Text = oeEmail.Nombre
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarEmail()
        Try
            Dim oeEmaAux As New e_Email
            Dim _idEma As String = String.Empty
            RecogerDatosEma()
            oeTelefono.Equivale = 1
            If Not leEmail.Contains(oeEmail) Then
                oeEmail.Equivale = 2
                If Not leEmail.Contains(oeEmail) Then
                    oeTelefono.TipoOperacion = "I"
                    If griEmail.Rows.Count = 0 Then CargarEmail(leEmail) : oeEmail.Principal = 1
                    leEmail.Add(oeEmail)
                Else
                    oeEmaAux = leEmail.Item(leEmail.IndexOf(oeEmail))
                    If oeEmaAux.TipoOperacion = "E" Then
                        oeEmaAux.Activo = True
                        oeEmaAux.TipoOperacion = "A"
                    Else
                        Throw New Exception("El Email: " & oeEmaAux.Nombre & "ya esta Registrado")
                    End If
                End If
            Else
                oeEmaAux = New e_Email
                oeEmaAux = leEmail.Item(leEmail.IndexOf(oeEmail))
                _idEma = oeEmaAux.Id
                oeEmail.Equivale = 2
                If Not leEmail.Contains(oeEmail) Then
                    oeEmaAux.Nombre = oeEmail.Nombre
                    oeEmaAux.TipoOperacion = "A"
                Else
                    oeEmaAux = leEmail.Item(leEmail.IndexOf(oeEmail))
                    If oeEmaAux.TipoOperacion = "E" Then
                        oeEmaAux.Activo = True
                        oeEmaAux.TipoOperacion = "A"
                    Else
                        If oeEmaAux.Id = _idEma Then
                            oeEmaAux.TipoOperacion = "A"
                        Else
                            Throw New Exception("El Email: " & oeEmaAux.Nombre & " ya esta Registrado")
                        End If
                    End If
                End If
            End If
            CargarEmail(leEmail)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub QuitarEmail()
        Try
            oeEmail = New e_Email
            oeEmail.Id = griEmail.ActiveRow.Cells("Id").Value
            oeEmail.Equivale = 1
            If leEmail.Contains(oeEmail) Then
                oeEmail = leEmail.Item(leEmail.IndexOf(oeEmail))
                If oeEmail.TipoOperacion = "I" Then
                    leEmail.Remove(oeEmail)
                Else
                    oeEmail.TipoOperacion = "E"
                    oeEmail.Activo = False
                End If
                CargarEmail(leEmail)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub RecogerDatosEma()
        oeEmail.Nombre = txtNomEmail.Text
    End Sub

#End Region

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Incializa"
            If griPersona.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        oePersona.TipoOperacion = "I"
        MostrarTabs(1, ficPersona, 1)
        Inicializar()
        txtCodigo.Focus()
        ' agrDatoDireccion.Expanded = False
        ficDetalle.SelectedTab = ficDetalle.Tabs(0)
        Operacion = "Nuevo"       
        MyBase.Nuevo()      
    End Sub

    Public Overrides Sub Editar()
        Try
            If griPersona.ActiveRow IsNot Nothing AndAlso griPersona.Selected.Rows.Count > 0 Then
                Mostrar()
                oePersona.TipoOperacion = "A"
                txtCodigo.Focus()
                ' agrDatoDireccion.Expanded = False
                ficDetalle.SelectedTab = ficDetalle.Tabs(0)
                Operacion = "Editar"
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try                        
                If Guardando() Then
                    If PersonaMerma <> "" Then
                        Dim oeCombo As New e_Combo
                        Dim olCombo As New l_Combo
                        oeCombo.Nombre = "Persona"
                        PersonasPublic = New List(Of e_Combo)
                        PersonasPublic.AddRange(olCombo.Listar(oeCombo))
                        Me.Close()
                    Else
                        If BandCbo Then
                            MyBase.Guardar()
                        Else
                            'BandCbo = True
                            Me.Close()
                        End If
                    End If

                Else
                    'txtCodigo.Focus()
                    MostrarTabs(1, ficPersona, 1)
                End If


        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If BandCbo Then
                If oePersona.Modificado Then
                    Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                        Case Windows.Forms.DialogResult.Yes
                            If Guardando() Then
                                MostrarTabs(0, ficPersona, 2)
                                _ingresando_datos = False
                                Consultar(True)
                            Else
                                _ingresando_datos = True
                                MostrarTabs(1, ficPersona, 1)
                            End If
                        Case Windows.Forms.DialogResult.No
                            MostrarTabs(0, ficPersona, 2)
                            _ingresando_datos = False
                            Consultar(True)
                    End Select
                Else
                    MostrarTabs(0, ficPersona, 2)
                    _ingresando_datos = False
                    Consultar(True)
                End If
            Else
                'BandCbo = True
                Me.Close()
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Public Overrides Sub Eliminar()
        Try
            With griPersona
                If ValidarGrilla(griPersona, "Persona") Then
                    oePersona.Id = .ActiveRow.Cells("Id").Value
                    oePersona.CargaCompleta = True
                    oePersona = olPersona.Obtener(oePersona)
                    If oePersona.Activo Then
                        If lf_ValidarEliminar() AndAlso MessageBox.Show("Esta seguro de eliminar Persona: " & .ActiveRow.Cells("Nombre").Value.ToString() & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            oePersona.TipoOperacion = "E"
                            olPersona.Eliminar(oePersona)
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

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try

            If griPersona.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griPersona)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Menú contextual del maestro de Persona"

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
        If griPersona.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

#Region "Menu Contextual de Tipo Pago"

    Private Sub mnuTipoCambio_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mnuTipoPago.Opening
        mnuTipoPago.Items("tsmiQuitarTP").Visible = False
        If griTipoPago.Rows.Count > 0 Then mnuTipoPago.Items("tsmiQuitarTP").Visible = True
    End Sub

    Private Sub tsmiAgregarTP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiAgregarTP.Click
        InicializaTipoPago()
        agrContenidoTP.Expanded = True
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

#Region "Funciones"

    Public Function guardarContacto() As Boolean
        Dim opersona As e_Persona
        For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griPersona.Rows
            With fila
                If CBool(.Cells("Contacto").Value) = True Then
                    opersona = New e_Persona(.Cells("Id").Value, .Cells("Codigo").Value, .Cells("ApellidoPaterno").Value, .Cells("ApellidoMaterno").Value, .Cells("Nombre").Value,
                                                     Nothing, .Cells("FechaNacimiento").Value, .Cells("Dni").Value, .Cells("Activo").Value)
                    opersona.TipoOperacion = "C"
                    opersona.UsuarioCreacion = .Cells("UsuarioCreacion").Value ' gUsuarioSGI.Id
                    listaContactos.Add(opersona)
                End If
            End With
        Next
        frm_Empresa.leContactos = listaContactos
        '   listaContactos.Clear()                
        Return True
    End Function

    Public Function buscarYaAgregados(ByVal codigo As String) As Boolean
        For Each obj As e_Persona In Me.listaContactos
            If obj.Id = codigo Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Function lf_ValidarEliminar() As Boolean
        Try
            oCombo = New e_Combo
            oCombo.Id = griPersona.ActiveRow.Cells("Id").Value.ToString().Trim()
            oCombo.Nombre = "PersonaClienteProveedor"
            If olCombo.Listar(oCombo).Count > 0 Then
                MessageBox.Show("No se puede eliminar a la persona seleccionada porque esta asignada a almenos un cliente/proveedor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region
   
End Class