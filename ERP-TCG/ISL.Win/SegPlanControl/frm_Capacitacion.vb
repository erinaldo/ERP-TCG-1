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
Imports Infragistics.Win

Public Class frm_Capacitacion
    Inherits frm_MenuPadre

#Region "Inicializar"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_Capacitacion = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_Capacitacion()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oeCapacitacion As e_Capacitacion, olCapacitacion As l_Capacitacion, leCapacitacion As List(Of e_Capacitacion)
    Private oeDetalle As e_DetalleCapacitacion, olDetalle As l_DetalleCapacitacion, leDetalle As List(Of e_DetalleCapacitacion)
    Private oeTrabajador As e_Trabajador, olTrabajador As l_Trabajador, leTrabajador As List(Of e_Trabajador)
    Private oeEstado As e_Estado, olEstado As l_Estado, leEstado As List(Of e_Estado)
    Private _acl As String = "", _estado As String = "", _opeCapac As String = ""

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(Activo As Boolean)
        Try
            Listar()
            If griCapacitacion.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            _acl = gAccionSistema.NUEVO.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _opeCapac = "GENERADA"
                oeCapacitacion = New e_Capacitacion
                oeCapacitacion.TipoOperacion = "I" : oeCapacitacion.Activo = True
                Inicializa()
                cboEstado.ReadOnly = False
                txtCodigo.Text = fn_ObtenerCodigo()
                _estado = gNombreEstadoGenerada
                cboEstado.Text = _estado
                agrSeleccion.Expanded = True
                MostrarTabs(1, ficCapacitacion)
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            _acl = gAccionSistema.EDITAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _opeCapac = "GENERADA"
                Inicializa()
                cboEstado.ReadOnly = True
                Mostrar()
                oeCapacitacion.TipoOperacion = "A"
                MostrarTabs(1, ficCapacitacion)
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            olCapacitacion = New l_Capacitacion
            oeCapacitacion.Codigo = txtCodigo.Text.Trim
            oeCapacitacion.IdEstado = cboEstado.Value
            oeCapacitacion.Nombre = txtTema.Text.Trim
            oeCapacitacion.Lugar = txtLugar.Text.Trim
            oeCapacitacion.FechaFin = fecCapacitacion.Value
            oeCapacitacion.IdExpositor = cboExpositor.Value
            oeCapacitacion.IndExpositor = IIf(chkExterno.Checked, 1, 0)
            oeCapacitacion.leDetalle = leDetalle
            If oeCapacitacion.TipoOperacion = "I" Then
                oeCapacitacion.UsuarioCreacion = gUsuarioSGI.Id
            Else
                oeCapacitacion.UsuarioModifica = gUsuarioSGI.Id
            End If
            oeCapacitacion.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olCapacitacion.Guardar(oeCapacitacion) Then
                mensajeEmergente.Confirmacion("El Registro se Guardo correctamente!!", True)
                MostrarTabs(0, ficCapacitacion)
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If MessageBox.Show("¿Desea Cancelar la Operacion?", "Mensaje de Sistema", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                MostrarTabs(0, ficCapacitacion)
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        MyBase.Eliminar()
    End Sub

    Public Overrides Sub Exportar()
        MyBase.Exportar()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Capacitacion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_Capacitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
            CargarCombos()
            CargarDetCapac(New List(Of e_DetalleCapacitacion))
            MostrarTabs(0, ficCapacitacion)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombos()
        Try
            'Cargar Tipos de Capacitaciones para Busqueda
            cboTipoBus.Items.Clear()
            cboTipoBus.Items.Add("[ TODOS ]")
            cboTipoBus.Items.Add("CONBTROL ASISTENCIA - CHARLA DE 5 MIN")
            cboTipoBus.Items.Add("REGISTRO DE CAPACITACION / ENTRENAMIENTO")
            cboTipoBus.Items.Add("REGISTRO INDUCCION Y REINDUCCION DE SEGURIDAD")
            cboTipoBus.SelectedIndex = 0
            'Cargar Tipos de Capacitaciones para Ingreso de Información
            cboTipo.Items.Clear()
            cboTipo.Items.Add("CONBTROL ASISTENCIA - CHARLA DE 5 MIN")
            cboTipo.Items.Add("REGISTRO DE CAPACITACION / ENTRENAMIENTO")
            cboTipo.Items.Add("REGISTRO INDUCCION Y REINDUCCION DE SEGURIDAD")
            cboTipo.SelectedIndex = -1
            'Cargar Estados
            oeEstado = New e_Estado : olEstado = New l_Estado : leEstado = New List(Of e_Estado)
            oeEstado.Nombre = "CAPACITACIONES"
            leEstado = olEstado.Listar(oeEstado)
            'Cargar Estados para Busqueda
            Dim leEstadoBusq As New List(Of e_Estado)
            oeEstado = New e_Estado
            oeEstado.Nombre = "[ TODOS ]" : oeEstado.Id = String.Empty
            leEstadoBusq.Add(oeEstado)
            leEstadoBusq.AddRange(leEstado)
            LlenarCombo(cboEstadoBus, "Nombre", leEstadoBusq, 0)
            'Cargar Estados para Ingreso de Información
            LlenarCombo(cboEstado, "Nombre", leEstado, -1)
            'Cargar Trabajador
            oeTrabajador = New e_Trabajador : olTrabajador = New l_Trabajador : leTrabajador = New List(Of e_Trabajador)
            oeTrabajador.TipoOperacion = "N"
            leTrabajador = olTrabajador.Listar(oeTrabajador)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar()
        Try
            oeCapacitacion = New e_Capacitacion
            oeCapacitacion.TipoOperacion = ""
            oeCapacitacion.Activo = True
            oeCapacitacion.IndTipo = cboTipoBus.SelectedIndex
            oeCapacitacion.IdEstado = cboEstadoBus.Value
            olCapacitacion = New l_Capacitacion
            leCapacitacion = olCapacitacion.Listar(oeCapacitacion)
            CargarCapacitacion(leCapacitacion)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarCapacitacion(leCapac As List(Of e_Capacitacion))
        Try
            With griCapacitacion
                .ResetDisplayLayout()
                .Text = "Lista de Capacitaciones"
                .DataSource = leCapac
                OcultarColumna(griCapacitacion, True, "Id", "IdEstado", "IndTipo", "IdExpositor", "FechaCreacion", "UsuarioCreacion", _
                               "FechaModifica", "UsuarioModifica", "Activo")
                ExcluirColumna(griCapacitacion, "IdEstado", "IndTipo", "IdExpositor", "Activo")
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
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

    Private Sub CargarDetCapac(leDetCapc As List(Of e_DetalleCapacitacion))
        Try
            With griParticipante
                .ResetDisplayLayout()
                .Text = "Lista de Participantes"
                .DataSource = leDetCapc
                OcultarColumna(griParticipante, True, "Id", "IdCapacitacion", "IdAsistente", "FechaCreacion", "UsuarioCreacion", _
                               "FechaModifica", "UsuarioModifica", "Activo")
                ExcluirColumna(griParticipante, "IdCapacitacion", "IdAsistente", "Activo")
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarSeleccion()

    End Sub

    Private Sub Inicializa()
        cboTipo.SelectedIndex = -1
        txtCodigo.Text = String.Empty
        cboEstado.SelectedIndex = -1
        txtTema.Text = String.Empty
        txtLugar.Text = String.Empty
        fecCapacitacion.Value = Date.Now.Date
        fecHora.Value = Date.Now
        cboExpositor.SelectedIndex = -1
        chkExterno.Checked = False
        leDetalle = New List(Of e_DetalleCapacitacion)
        agrSeleccion.Expanded = False
    End Sub

    Private Function fn_ObtenerCodigo() As String
        Try
            Dim str As String = ""
            Dim oeCapac As New e_Capacitacion
            olCapacitacion = New l_Capacitacion
            oeCapac.TipoOperacion = "U"
            oeCapac = olCapacitacion.Obtener(oeCapac)
            If oeCapac IsNot Nothing AndAlso oeCapac.Codigo <> "" Then
                str = oeCapac.Codigo
            End If
            Return str
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Mostrar()
        Try
            oeCapacitacion = New e_Capacitacion : olCapacitacion = New l_Capacitacion
            oeCapacitacion.TipoOperacion = ""
            oeCapacitacion.Id = griCapacitacion.ActiveRow.Cells("Id").Value
            oeCapacitacion = olCapacitacion.Obtener(oeCapacitacion)
            With oeCapacitacion
                txtCodigo.Text = .Codigo
                ' txtDescripcion.Text = .Descripcion
                cboEstado.Value = .IdEstado
                cboTipo.SelectedIndex = .IndTipo
                txtTema.Text = .Nombre
                txtLugar.Text = .Lugar
                cboExpositor.Value = .IdExpositor
                fecCapacitacion.Value = .FechaInicio
                chkExterno.Checked = IIf(.IndExpositor = 1, True, False)
                'leDetallePlaVac = .leDetalle
                'CargarDetallePlaVac(leDetallePlaVac)
                'CargarDetalleCompra(leDetallePlaVac)
                'Dim _oeTrabAux As New e_Trabajador
                '_oeTrabAux.TipoOperacion = ""
                '_oeTrabAux.Id = oePlanillaVacaciones.IdPlanilla
                'dsDatosGen = olTrabajador.CargarDatosGenerales(_oeTrabAux).Tables(0)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class