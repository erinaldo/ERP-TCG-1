Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_FichaPersonal
    Inherits ISL.Win.frm_MenuPadre

#Region "Declaracion de Variables"

    Private oeTrabajador As New e_Trabajador
    Private oeArea As New e_Area
    Private oeCargo As New e_Cargo
    Private olTrabajador As New l_Trabajador
    Private olArea As New l_Area
    Private olCargo As New l_Cargo
    Private oeOcupacion As New e_Ocupacion
    Private olOcupacion As New l_Ocupacion
    Private olDatosConfiguracion As New l_Configuracion
    Private olOcupacionTrabajador As New List(Of e_OcupacionTrabajador)

    Private oeCentro As New e_Centro
    Private olCentro As New l_Centro

    Private oePersona As New e_Persona
    Private olPersona As New l_Persona
    Private Shared Operacion As String
    Private _ingresando_datos As Boolean = False

    Public IndCambioPestaña As Boolean = True

#End Region

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_FichaPersonal = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        Operacion = "Inicializa"
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_FichaPersonal()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

    Public Function MostrarTrabajador(ByVal Idtrabajador As String) As Boolean
        Operacion = "Ayuda"
        'MostrarTabs(1, ficTrabajador, 1)
        Try
            'Inicializar el obj oeTrabajador y limpia controles
            Inicializar()
            oeTrabajador.Id = Idtrabajador
            oeTrabajador.CargaCompleto = True
            oeTrabajador = olTrabajador.Obtener(oeTrabajador)
            MostrarTabs(1, ficTrabajador, 1)
            CargaDatosPersonales(oeTrabajador)
            If Not String.IsNullOrEmpty(oeTrabajador.oePersona.Dni) Then CargarFotoTrabajador(oeTrabajador)
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Listar(Activo)
            Tiempo1.Enabled = True
            mt_ControlBotoneria()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Operacion = "Editar"
        Mostrar()
        mt_ControlBotoneria()
    End Sub

    Public Overrides Sub Cancelar()
        MostrarTabs(0, ficTrabajador, 1)
        mt_ControlBotoneria()
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
            If griTrabajador.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griTrabajador)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    'Public Overrides Sub Salir()
    '    MostrarTabs(0, ficTrabajador, 1)
    '    Consultar(True)
    'End Sub

#End Region

#Region "Eventos"

    Private Sub frm_FichaPersonal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            LlenaComboCentro()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_FichaPersonal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_FichaPersonal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'Select Case Operacion
        '    Case "Nuevo"
        '        Me.Activate()
        '        Me.Cancelar()

        '    Case "Editar"
        '        Me.Activate()
        '        Me.Cancelar()
        'End Select
        'e.Cancel = _ingresando_datos
        'If Not e.Cancel Then
        '    ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        'End If
    End Sub

    Private Sub griTrabajador_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griTrabajador.DoubleClick
        If griTrabajador.Selected.Rows.Count > 0 Then Editar()

    End Sub

    Private Sub ColoresTrabajadoresNoDisponibles_ColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        etiTrabajadoresNoDisponibles.Appearance.BackColor = ColoresTrabajadoresNoDisponibles.Color
    End Sub

    Private Sub frm_FichaPersonal_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Try
            mt_ControlBotoneria()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mt_ControlBotoneria()
        Try
            If IndCambioPestaña Then
                Select Case ficTrabajador.SelectedTab.Index
                    Case 0
                        If griTrabajador.Rows.Count > 0 Then
                            ControlBoton(1, 0, 1, 0, 0, 0, 0, 1, 1)
                        Else
                            ControlBoton(1)
                        End If
                    Case 1
                        ControlBoton(0, 0, 0, 0, 1)
                End Select
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub VerDatosTrabajadorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerDatosTrabajadorToolStripMenuItem.Click
        If griTrabajador.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub ficTrabajador_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ficTrabajador.Click
        Try
            If IndCambioPestaña AndAlso ficTrabajador.Tabs(1).Selected Then
                Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griOcupacion_MouseEnterElement(ByVal sender As Object, ByVal e As Infragistics.Win.UIElementEventArgs) Handles griOcupacion.MouseEnterElement
        If griOcupacion.Rows.Count > 0 Then
            Dim celda As UltraGridCell = TryCast(e.Element.GetContext(GetType(UltraGridCell), True), UltraGridCell)
            If Not celda Is Nothing Then
                If celda.Column.Key = "FechaIngreso" Or celda.Column.Key = "FechaCese" AndAlso Not IsDBNull(celda.Value) Then
                    Dim diasAcumulados As Integer = TiempoPermanenciaParcial(griOcupacion.ActiveRow.Cells("FechaIngreso").Value, griOcupacion.ActiveRow.Cells("FechaCese").Value)
                    If diasAcumulados > 0 Then
                        Dim mensaje As String = diasAcumulados.ToString & " días acumulados"
                        Dim tipInfo As New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo(mensaje, Infragistics.Win.ToolTipImage.Default, "Días acumulados", Infragistics.Win.DefaultableBoolean.True)
                        UltraToolTipManager1.SetUltraToolTip(griOcupacion, tipInfo)
                        UltraToolTipManager1.ShowToolTip(griOcupacion)
                    End If
                Else
                    UltraToolTipManager1.HideToolTip()
                End If
            End If
        End If
    End Sub

#End Region

#Region "Metodos"

    Public Sub Listar(ByVal lb_Activo As Boolean)
        Try

            oeTrabajador = New e_Trabajador
            oeTrabajador.TipoOperacion = "F"
            oeTrabajador.Activo = lb_Activo
            CargarTrabajador(olTrabajador.Listar2(oeTrabajador))

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griTrabajador.Focus()
    End Sub

    Private Sub LlenaComboCentro()
        Try
            Dim oe As New e_Centro
            Dim leCentro As New List(Of e_Centro)
            oe.Id = ""
            oe.Nombre = "TODOS"
            leCentro.Add(oe)
            leCentro.AddRange(olCentro.Listar(oeCentro))
            LlenarCombo(cboCentroBus, "Nombre", leCentro, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializar()
        Try
            oeTrabajador = New e_Trabajador
            txtCodigo.Text = String.Empty
            txtApellidoPaterno.Text = String.Empty
            txtApellidoMaterno.Text = String.Empty
            txtNombre.Text = String.Empty
            fecFechaNacimiento.Value = Nothing
            Fotografia.Image = Nothing
            verActivo.Checked = True
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Mostrar()
        Try
            mt_ControlBotoneria()
            If griTrabajador.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeTrabajador.Id = griTrabajador.ActiveRow.Cells("Id").Value.ToString
                oeTrabajador.CargaCompleto = True
                oeTrabajador = olTrabajador.Obtener(oeTrabajador)
                MostrarTabs(1, ficTrabajador, 1)
                CargaDatosPersonales(oeTrabajador)
                If Not String.IsNullOrEmpty(oeTrabajador.oePersona.Dni) Then CargarFotoTrabajador(oeTrabajador)
                ProtegerControles()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub ProtegerControles(Optional ByVal soloLectura As Boolean = True)
        EstadoCivil1.cboEstadoCivil.ReadOnly = soloLectura
        GradoInstruccion1.cboGradoInstruccion.ReadOnly = soloLectura
        LugarNacimiento.Departamento1.cboDepartamento.ReadOnly = soloLectura
        LugarNacimiento.Provincia1.cboProvincia.ReadOnly = soloLectura
        LugarNacimiento.Distrito1.cboDistrito.ReadOnly = soloLectura
    End Sub

    Private Sub CargarFotoTrabajador(ByVal oeTrabajador As e_Trabajador)
        Fotografia.Image = olPersona.Foto(oeTrabajador.oePersona.Dni)
    End Sub

    Private Sub CargaDatosPersonales(ByVal oeTrabajador As e_Trabajador)
        Try
            With oeTrabajador
                txtCodigo.Text = .Codigo
                txtApellidoPaterno.Text = .oePersona.ApellidoPaterno
                txtApellidoMaterno.Text = .oePersona.ApellidoMaterno
                txtNombre.Text = .oePersona.Nombre
                txtDni.Text = .oePersona.Dni
                olOcupacionTrabajador = .leOcupacionTrabajador
                fecFechaNacimiento.Value = .oePersona.FechaNacimiento
                Sexo1.Sexo = New e_Sexo(CType(.oePersona.oeSexo.Id, String))
                txtCodigo.Text = .Codigo
                verActivo.Checked = .Activo
                TrabajadorDisponible1.Disponible = .Disponible

                If Not String.IsNullOrEmpty(.IdEstadoCivil) Then EstadoCivil1.Seleccionar(.IdEstadoCivil)

                If Not String.IsNullOrEmpty(.IdGradoInstruccion) Then GradoInstruccion1.Seleccionar(.IdGradoInstruccion)

                If Not String.IsNullOrEmpty(.IdLugarNacimiento) Then LugarNacimiento.Seleccionar(.IdLugarNacimiento)

                LlenarOcupacion(oeTrabajador.leOcupacionTrabajador)

                oePersona.Id = oeTrabajador.oePersona.Id

                Dim olPersonaTelef As New l_Persona
                oePersona.CargaCompleta = True
                oePersona = olPersonaTelef.Obtener(oePersona)
                ListarTelefono(oePersona.leTelefono)
                ListarEmail(oePersona.leEmail)
                ListarMovimientos(True)
                CargarDocumentos(.oePersona.leDocumento)
                CargarDireccion(oePersona.leDireccionEP)
                'Cargar Permisos de Trabajador
                CargarPermisos(.Id)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarPermisos(IdTrabajador As String)
        Try
            Dim olControlPermisos As New l_ControlPermisos
            Dim loControlPermisos As New List(Of e_ControlPermisos)
            griControlPermisos.DataSource = olControlPermisos.Listar(New e_ControlPermisos With {.IdTrabajador = IdTrabajador}).Where(Function(x) x.FechaSalida.Date >= Date.Now.Date).ToList()
        Catch ex As Exception
            Throw ex
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
                .DisplayLayout.Bands(0).Override.FilterUIProvider = Filtro1
                .DisplayLayout.Bands(0).Columns("Principal").Header.VisiblePosition = 0

                .DisplayLayout.Bands(0).Columns("Principal").Style = ColumnStyle.CheckBox

                .DisplayLayout.Bands(0).Columns("Nombre").Width = 500

                .Font = New System.Drawing.Font("Thaoma", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
                .DisplayLayout.Bands(0).Columns("Principal").Style = UltraWinGrid.ColumnStyle.CheckBox

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarDocumentos(leDocPer As List(Of e_PersonaDocumento))
        Try
            With griDocPersonales

                .ResetDisplayLayout()

                Dim _leActivo = leDocPer.Where(Function(it) it.Activo = True And it.Vigente = 1).ToList

                .DataSource = _leActivo

                .Text = String.Empty

                For Each col In .DisplayLayout.Bands(0).Columns
                    If col.Key <> "TipoDocumento" And col.Key <> "NumeroDocumento" And col.Key <> "Descripcion" And _
                        col.Key <> "FechaActividad" And col.Key <> "FechaVencimiento" Then col.Hidden = True
                    If col.Key.Contains("Id") Then col.ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
                Next

                .DisplayLayout.Bands(0).Columns("TipoDocumento").Header.Caption = "Tipo Doc."
                .DisplayLayout.Bands(0).Columns("NumeroDocumento").Header.Caption = "Nro Doc."

                .DisplayLayout.Bands(0).Columns("TipoDocumento").Width = 250

                .Font = New System.Drawing.Font("Tahoma", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarDatos()
        Try
            Dim oePersona As New e_Persona
            With oePersona
                .Activo = verActivo.Checked
                .Id = oeTrabajador.oePersona.Id
                .Codigo = oeTrabajador.oePersona.Codigo
            End With
            Dim oeTrabajadorTemp As New e_Trabajador(oePersona)
            With oeTrabajadorTemp
                .Id = oeTrabajador.Id
                .oeArea.Id = oeTrabajador.oeArea.Id
                .oeCargo.Id = oeTrabajador.oeCargo.Id
                .oePersona.Dni = oeTrabajador.oePersona.Dni
                .oePersona.ApellidoPaterno = oeTrabajador.oePersona.ApellidoPaterno
                .oePersona.ApellidoMaterno = oeTrabajador.oePersona.ApellidoMaterno
                .oePersona.Nombre = oeTrabajador.oePersona.Nombre
                .oePersona.FechaNacimiento = oeTrabajador.oePersona.FechaNacimiento
                .oePersona.oeSexo = oeTrabajador.oePersona.oeSexo
                .Codigo = oeTrabajador.Codigo
                .Activo = oeTrabajador.Activo
                .TipoOperacion = oeTrabajador.TipoOperacion
                .FechaIngreso = oeTrabajador.FechaIngreso

            End With
            oeTrabajador = oeTrabajadorTemp
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LlenarOcupacion(ByVal leOcuapacionTrabajador As List(Of e_OcupacionTrabajador))
        Try
            With griOcupacion
                .DataSource = oeTrabajador.leOcupacionTrabajador
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdOcupacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdTrabajador").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdArea").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdCentro").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdCargo").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdOcupacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdTipoRelacionLaboral").Hidden = True
                .DisplayLayout.Bands(0).Columns("IndRuta").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaEjecutaCese").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioEjecutaCese").Hidden = True

                .DisplayLayout.Bands(0).Columns("Seleccion").Hidden = True
                .DisplayLayout.Bands(0).Columns("Trabajador").Hidden = True
                .DisplayLayout.Bands(0).Columns("Ocupacion").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("Principal").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("FechaCese").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("FechaIngreso").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("Area").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("Cargo").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("Centro").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("TipoRelacionLaboral").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit

                .Font = New System.Drawing.Font("Thaoma", 7.5!)
                'Muestra la columna en forma de casilla de verificación
                .DisplayLayout.Bands(0).Columns("Principal").Style = UltraWinGrid.ColumnStyle.CheckBox

                'Define el nombre que se mostrará en la cabecera de la lista
                .DisplayLayout.Bands(0).Columns("Ocupacion").Header.Caption = "Ocupación"

                For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griOcupacion.Rows
                    If fila.Cells("FechaCese").Value = "01/01/1901" Then
                        fila.Cells("FechaCese").Appearance.ForeColor = Color.White
                        fila.Cells("FechaCese").Appearance.BackColor = Color.White
                    Else
                        If fila.Cells("FechaCese").Value >= Date.Now Then
                            fila.Cells("FechaCese").Appearance.ForeColor = Color.Yellow
                            fila.Cells("FechaCese").Appearance.BackColor = Color.Red
                        Else
                            fila.Cells("FechaCese").Appearance.ForeColor = Color.Red
                            fila.Cells("FechaCese").Appearance.BackColor = Color.Yellow
                        End If
                    End If
                Next

                lblTiempoPermanenciaTotal.Text = TiempoPermanenciaTotal.ToString & " días"
                lblEquivalenteTiempo.Text = TiempoEstimado(TiempoPermanenciaTotal)

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ListarTelefono(ByVal leTelefono As List(Of e_Telefono))
        Try
            With griTelefono
                .DataSource = leTelefono
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Tipo").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdPersonaEmpresa").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("TipoPersonaEmpresa").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdOperadorTelefonico").Hidden = True
                .DisplayLayout.Bands(0).Columns("CodigoLargaDistancia").Hidden = True
                .Font = New System.Drawing.Font("Thaoma", 7.5!)
                'Define el nombre que se mostrará en la cabecera de la lista
                .DisplayLayout.Bands(0).Columns("Nombre").Header.Caption = "Número"
                .DisplayLayout.Bands(0).Columns("NomTipo").Header.Caption = "Operador"
                .DisplayLayout.Bands(0).Columns("Principal").Style = UltraWinGrid.ColumnStyle.CheckBox
            End With
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ListarEmail(ByVal leEmail As List(Of e_Email))
        Try
            With griEmail
                .DataSource = leEmail
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdPersonaEmpresa").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("TipoPersonaEmpresa").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("NombreCompleto").Hidden = True

                'Define el nombre que se mostrará en la cabecera de la lista
                .DisplayLayout.Bands(0).Columns("Nombre").Header.Caption = "Email"

                'Muestra la columna en forma de casilla de verificación
                .DisplayLayout.Bands(0).Columns("Principal").Style = UltraWinGrid.ColumnStyle.CheckBox
                .Font = New System.Drawing.Font("Thaoma", 7.5!)
            End With
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Sub ListarMovimientos(ByVal Activo As Boolean)
        Try
            Dim olMovimientosTrabajador As New l_MovimientoPersonal
            Dim oeMovimientosTrabajador As New e_MovimientoPersonal
            oeMovimientosTrabajador.IdTrabajador = oeTrabajador.Id
            oeMovimientosTrabajador.Activo = True
            oeMovimientosTrabajador.Id = Nothing
            With griListaMovimientosTrabajador
                'oeMovimientosTrabajador.Activo = Activo
                .DataSource = olMovimientosTrabajador.Listar(oeMovimientosTrabajador)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdTrabajador").Hidden = True
                .DisplayLayout.Bands(0).Columns("ApellidoPaterno").Hidden = True
                .DisplayLayout.Bands(0).Columns("ApellidoMaterno").Hidden = True
                .DisplayLayout.Bands(0).Columns("Nombres").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdSituacionAdministrativa").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaRetorno").Hidden = True
                .DisplayLayout.Bands(0).Columns("Situacion").Width = 300

                'Define el nombre que se mostrará en la cabecera de la lista
                .DisplayLayout.Bands(0).Columns("Situacion").Header.Caption = "Situación"
                .DisplayLayout.Bands(0).Columns("FechaInicio").Header.Caption = "Inicia"
                .DisplayLayout.Bands(0).Columns("NroDias").Header.Caption = "Nro días"
                .DisplayLayout.Bands(0).Columns("FechaFin").Header.Caption = "Concluye"
                .DisplayLayout.Bands(0).Columns("Retorno").Header.Caption = "Retornó"
                .DisplayLayout.Bands(0).Columns("Observacion").Header.Caption = "Observación"

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Función para calcular el tiempo de permanencia de un trabajador en la empresa
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function TiempoPermanenciaTotal() As Integer
        Try
            Dim tiempoAcumulado As Integer = 0
            Dim tiempoContado As Boolean = False
            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griOcupacion.Rows
                If fila.Cells("FechaCese").Value <> "01/01/1901" Then
                    tiempoAcumulado = tiempoAcumulado + DateDiff(DateInterval.Day, fila.Cells("FechaIngreso").Value, fila.Cells("FechaCese").Value)
                Else
                    If Not tiempoContado Then
                        tiempoAcumulado = tiempoAcumulado + DateDiff(DateInterval.Day, fila.Cells("FechaIngreso").Value, Date.Now)
                        tiempoContado = True
                    End If
                End If
            Next
            Return tiempoAcumulado
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    ''' <summary>
    ''' Función para determinar el tiempo transcurrido en una ocupación
    ''' </summary>
    ''' <param name="FechaInicio"></param>
    ''' <param name="fechaCese"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function TiempoPermanenciaParcial(ByVal FechaInicio As Date, ByVal fechaCese As Date) As Integer
        Try
            Dim tiempoAcumulado As Integer = 0
            If fechaCese <> "01/01/1901" Then
                tiempoAcumulado = tiempoAcumulado + DateDiff(DateInterval.Day, FechaInicio, fechaCese)
            Else
                tiempoAcumulado = tiempoAcumulado + DateDiff(DateInterval.Day, FechaInicio, Date.Now)
            End If
            Return tiempoAcumulado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub CargarTrabajador(ByVal _leTrabajador As List(Of e_Trabajador))
        Try
            'If cboCentroBus.Value <> "" Then _leTrabajador = _leTrabajador.Where(Function(x) x.IdCentro = cboCentroBus.Value.ToString.Trim).ToList

            With griTrabajador

                Dim _leTrabajadorTemp = From le In _leTrabajador _
                                        Select le.Id, le.Codigo, le.oePersona.Dni, le.oePersona.NombreCompleto, le.oePersona.oeSexo.Nombre _
                                        , le.oePersona.FechaNacimiento, le.Centro, Area = le.oeArea.Nombre, Ocupacion = le.oeOcupacion.Nombre, le.FechaIngreso, le.Disponible, le.Activo

                .DataSource = _leTrabajadorTemp.ToList

                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Id").ExcludeFromColumnChooser = ExcludeFromColumnChooser.True

                .DisplayLayout.Bands(0).Columns("NombreCompleto").SortIndicator = SortOrder.Ascending

                .DisplayLayout.Bands(0).Columns("Dni").Width = 70
                .DisplayLayout.Bands(0).Columns("NombreCompleto").Width = 250
                .DisplayLayout.Bands(0).Columns("Centro").Width = 100
                .DisplayLayout.Bands(0).Columns("Area").Width = 200
                '.DisplayLayout.Bands(0).Columns("Sexo").Width = 70
                .DisplayLayout.Bands(0).Columns("Codigo").Width = 70
                .DisplayLayout.Bands(0).Columns("Ocupacion").Width = 200

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

                For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In .Rows
                    If fila.Cells("Disponible").Value = 0 Then
                        fila.CellAppearance.BackColor = Me.ColoresTrabajadoresNoDisponibles.Color
                    End If
                Next

                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_FichaPersonal_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griTrabajador_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griTrabajador.InitializeLayout
        agrGrillaTrabajador.Text = "Total de Trabajadores: " & e.Layout.Rows.Count
    End Sub

    Private Sub griTrabajador_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griTrabajador.MouseMove
        If griTrabajador.Selected.Rows.Count > 0 Then
            mnuListado.Items(0).Visible = True
            mnuListado.Items(0).Text = "Visualizar la ficha de: " & oeTrabajador.oePersona.NombreCompleto
            mnuListado.Items(1).Visible = True
            mnuListado.Items(1).Text = "Imprimir la ficha de: " & oeTrabajador.oePersona.NombreCompleto
        Else
            mnuListado.Items(0).Visible = False
            mnuListado.Items(1).Visible = False
        End If
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

End Class
