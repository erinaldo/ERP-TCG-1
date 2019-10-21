'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_PlanesEPS
    Inherits frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        mnuRSalud.Visible = False
        mnuSComp.Visible = False
    End Sub

    Public Sub New(Accion As String, oeRSalud As e_RegimenSalud, oeTrabAux As e_Trabajador)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        mnuRSalud.Visible = True
        indCarga = 1
        Inicializar()
        CargarCombos()
        oeRegimenSalud = oeRSalud
        leRegSaludAux = oeTrabAux.leRegimenSalud
        Select Case Accion
            Case "Agregar"
                'cboTrabajador.Value = oeRegimenSalud.IdTrabajador
            Case "Editar"
                CargarRS()
                'cboTrabajador.ReadOnly = True
        End Select
        'cboTrabajador.ReadOnly = True
    End Sub

    Public Sub New(Accion As String, oeSeguroComp As e_SeguroComplementario, oeTrabAux As e_Trabajador)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        mnuSComp.Visible = True
        indCarga = 2
        Inicializar()
        CargarCombos()
        oeSeguroComplementario = oeSeguroComp
        leSegCompAux = oeTrabAux.leSeguroComp
        Select Case Accion
            Case "Agregar"
                'cboTrabajador.Value = oeContratos.IdTrabajador
            Case "Editar"
                CargarSC()
                'cboTrabajador.ReadOnly = True
        End Select
        ' cboTrabajador.ReadOnly = True
    End Sub

    Private Shared instancia As frm_PlanesEPS = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_PlanesEPS()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oePlanesEPS As New e_PlanesEPS, olPlanesEPS As New l_PlanesEPS, lePlanesEPS As New List(Of e_PlanesEPS)
    Private oeTrabajador As New e_Trabajador, olTrabajador As New l_Trabajador, leTrabajador As New List(Of e_Trabajador)
    Private oeEmpresa As New e_Empresa, olEmpresa As New l_Empresa, leEmpresa As New List(Of e_Empresa)
    Private oeRegimenSalud As New e_RegimenSalud, leRegSaludAux As New List(Of e_RegimenSalud)
    Private oeSeguroComplementario As New e_SeguroComplementario, leSegCompAux As New List(Of e_SeguroComplementario)
    Private indCarga As Integer = 0

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(Activo As Boolean)
        Try
            Listar(Activo)
            If griPlanEPS.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        SeleccionaTabs(1)
        Inicializar()
        oePlanesEPS.TipoOperacion = "I"
        oePlanesEPS.Modificado = False
        oePlanesEPS.Vigente = 1
        txtCodigo.Text = ObtieneCodigo()
        txtNombre.Focus()
        Operacion = "Nuevo"
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        Mostrar()
        oePlanesEPS.TipoOperacion = "A"
        oePlanesEPS.Modificado = False
        txtNombre.Focus()
        Operacion = "Editar"
        MyBase.Editar()
    End Sub

    Public Overrides Sub guardar()
        Try
            If Guardando() Then
                MyBase.Guardar()
            Else
                SeleccionaTabs(1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oePlanesEPS.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If Guardando() Then
                            SeleccionaTabs(0)
                            Consultar(True)
                        Else
                            SeleccionaTabs(1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        SeleccionaTabs(0)
                        Consultar(True)
                End Select
            Else
                SeleccionaTabs(0)
                Consultar(True)
            End If
            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()

    End Sub

    Public Overrides Sub Exportar()

    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_PlanesEPS_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Select Case ficPlanEPS.SelectedTab.Index
            Case 0
                If griPlanEPS.Rows.Count > 1 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        End Select
    End Sub

    Private Sub frm_PlanesEPS_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_PlanesEPS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Select Case indCarga
                Case 0
                    CargarCombos()
                    CargarPlanEPS(New List(Of e_PlanesEPS))
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                    Tiempo1.Enabled = False
                    SeleccionaTabs(0)
                Case 1
                    SeleccionaTabs(2)
                Case 2
                    SeleccionaTabs(3)
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboEmpresa_ValueChanged(sender As System.Object, e As System.EventArgs) Handles cboEmpresa.ValueChanged
        If cboEmpresa.SelectedIndex > -1 Then oePlanesEPS.IdEmpresa = cboEmpresa.Value
    End Sub

    Private Sub txtNombre_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtNombre.ValueChanged
        oePlanesEPS.Nombre = txtNombre.Text
    End Sub

    Private Sub txtDescripcion_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtDescripcion.ValueChanged
        oePlanesEPS.Descripcion = txtDescripcion.Text
    End Sub

    Private Sub ndPrecio_ValueChanged(sender As System.Object, e As System.EventArgs) Handles ndPrecio.ValueChanged
        If Not IsDBNull(ndPrecio.Value) Then
            oePlanesEPS.Precio = ndPrecio.Value
        Else
            ndPrecio.Value = 0
        End If
    End Sub

    Private Sub ndAdicional1_ValueChanged(sender As Object, e As EventArgs) Handles ndAdicional1.ValueChanged
        If Not IsDBNull(ndAdicional1.Value) Then
            oePlanesEPS.Adicional1 = ndAdicional1.Value
        Else
            ndAdicional1.Value = 0
        End If
    End Sub

    Private Sub ndAdicional2_ValueChanged(sender As Object, e As EventArgs) Handles ndAdicional2.ValueChanged
        If Not IsDBNull(ndAdicional2.Value) Then
            oePlanesEPS.Adicional2 = ndAdicional2.Value
        Else
            ndAdicional2.Value = 0
        End If
    End Sub

    Private Sub ndAdicional3_ValueChanged(sender As Object, e As EventArgs) Handles ndAdicional3.ValueChanged
        If Not IsDBNull(ndAdicional3.Value) Then
            oePlanesEPS.Adicional3 = ndAdicional3.Value
        Else
            ndAdicional3.Value = 0
        End If
    End Sub

    Private Sub ndAdicional4_ValueChanged(sender As Object, e As EventArgs) Handles ndAdicional4.ValueChanged
        If Not IsDBNull(ndAdicional4.Value) Then
            oePlanesEPS.Adicional4 = ndAdicional4.Value
        Else
            ndAdicional4.Value = 0
        End If
    End Sub

    Private Sub ndAdicional5_ValueChanged(sender As Object, e As EventArgs) Handles ndAdicional5.ValueChanged
        If Not IsDBNull(ndAdicional5.Value) Then
            oePlanesEPS.Adicional5 = ndAdicional5.Value
        Else
            ndAdicional5.Value = 0
        End If
    End Sub

    Private Sub ndMontoHijoMayor_ValueChanged(sender As Object, e As EventArgs) Handles ndMontoHijoMayor.ValueChanged
        If Not IsDBNull(ndMontoHijoMayor.Value) Then
            oePlanesEPS.MontoHijoMayor = ndMontoHijoMayor.Value
        Else
            ndMontoHijoMayor.Value = 0
        End If
    End Sub

    Private Sub txtCodigo_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtCodigo.ValueChanged
        oePlanesEPS.Codigo = txtCodigo.Text
    End Sub

    Private Sub griPlanEPS_DoubleClick(sender As System.Object, e As System.EventArgs) Handles griPlanEPS.DoubleClick
        If griPlanEPS.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub mnuRSalud_ToolClick(sender As Object, e As UltraWinToolbars.ToolClickEventArgs) Handles mnuRSalud.ToolClick
        Try
            Select Case e.Tool.Key
                Case "GrabarRS"
                    If oeRegimenSalud.Id <> "" Then
                        oeRegimenSalud.Equivale = 1
                        If leRegSaludAux.Contains(oeRegimenSalud) Then
                            oeRegimenSalud = leRegSaludAux.Item(leRegSaludAux.IndexOf(oeRegimenSalud))
                            If oeRegimenSalud.Id <> "ID" Then oeRegimenSalud.TipoOperacion = "A"
                            LlenarRS()
                        End If
                    Else
                        LlenarRS()
                        oeRegimenSalud.TipoOperacion = "I"
                        oeRegimenSalud.Id = "ID"
                        oeRegimenSalud.PrefijoID = gs_PrefijoIdSucursal '@0001
                        leRegSaludAux.Add(oeRegimenSalud)
                    End If
                    mensajeEmergente.Confirmacion("Los Datos se han Guardado Correctamente!!", True)
                    Me.Close()
                Case "CancelarRS"
                    If MessageBox.Show("¿Desea cancelar la Operacion", "Mensaje de Sistema", MessageBoxButtons.YesNo _
                               , MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        Me.Close()
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mnuSComp_ToolClick(sender As Object, e As UltraWinToolbars.ToolClickEventArgs) Handles mnuSComp.ToolClick
        Try
            Select Case e.Tool.Key
                Case "GrabarSC"
                    If oeSeguroComplementario.Id <> "" Then
                        oeSeguroComplementario.Equivale = 1
                        If leSegCompAux.Contains(oeSeguroComplementario) Then
                            oeSeguroComplementario = leSegCompAux.Item(leSegCompAux.IndexOf(oeSeguroComplementario))
                            If oeSeguroComplementario.Id <> "ID" Then oeSeguroComplementario.TipoOperacion = "A"
                            LlenarSC()
                        End If
                    Else
                        LlenarSC()
                        oeSeguroComplementario.TipoOperacion = "I"
                        oeSeguroComplementario.Id = "ID"
                        oeSeguroComplementario.PrefijoID = gs_PrefijoIdSucursal '@0001
                        leSegCompAux.Add(oeSeguroComplementario)
                    End If
                    mensajeEmergente.Confirmacion("Los Datos se han Guardado Correctamente!!", True)
                    Me.Close()
                Case "CancelarSC"
                    If MessageBox.Show("¿Desea cancelar la Operacion", "Mensaje de Sistema", MessageBoxButtons.YesNo _
                               , MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        Me.Close()
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboRegimenSalud_ValueChanged(sender As Object, e As EventArgs) Handles cboRegimenSalud.ValueChanged
        If cboRegimenSalud.SelectedIndex > -1 Then
            If cboRegimenSalud.Value = "01" Then
                cboEPS.ReadOnly = False : cboPlanEPS.ReadOnly = False : cboAdicional.ReadOnly = False
            Else
                cboEPS.ReadOnly = True : cboPlanEPS.ReadOnly = True : cboAdicional.ReadOnly = True
            End If
        End If
    End Sub

    Private Sub cboEPS_ValueChanged(sender As Object, e As EventArgs) Handles cboEPS.ValueChanged
        If cboEPS.SelectedIndex > -1 Then
            oeEmpresa = New e_Empresa
            oeEmpresa = cboEPS.Items(cboEPS.SelectedIndex).ListObject
            Dim _leAux = lePlanesEPS.Where(Function(it) it.IdEmpresa = oeEmpresa.Id).ToList
            LlenarCombo(cboPlanEPS, "Nombre", _leAux, -1)
        End If
    End Sub

    Private Sub cboPlanEPS_ValueChanged(sender As Object, e As EventArgs) Handles cboPlanEPS.ValueChanged
        If cboPlanEPS.SelectedIndex > -1 Then
            oePlanesEPS = New e_PlanesEPS
            oePlanesEPS = cboPlanEPS.Items(cboPlanEPS.SelectedIndex).ListObject
            cboAdicional.SelectedIndex = 0
            'ndMontoPlan.Value = oePlanesEPS.Precio
        End If
    End Sub

    Private Sub cboAdicional_ValueChanged(sender As Object, e As EventArgs) Handles cboAdicional.ValueChanged
        If oePlanesEPS.Id.Trim <> String.Empty Then
            Select Case cboAdicional.Value
                Case 0 : ndMontoPlan.Value = oePlanesEPS.Precio
                Case 1 : ndMontoPlan.Value = oePlanesEPS.Precio + oePlanesEPS.Adicional1
                Case 2 : ndMontoPlan.Value = oePlanesEPS.Precio + oePlanesEPS.Adicional2
                Case 3 : ndMontoPlan.Value = oePlanesEPS.Precio + oePlanesEPS.Adicional3
                Case 4 : ndMontoPlan.Value = oePlanesEPS.Precio + oePlanesEPS.Adicional4
                Case 5 : ndMontoPlan.Value = oePlanesEPS.Precio + oePlanesEPS.Adicional5
            End Select
        End If
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombos()
        Try
            oeEmpresa = New e_Empresa
            oeEmpresa.TipoOperacion = ""
            oeEmpresa.Activo = True
            leEmpresa = olEmpresa.Listar(oeEmpresa)
            Dim _leEmp = leEmpresa.Where(Function(it) it.TipoEmpresa = "PRESTADORA DE SALUD").ToList
            LlenarCombo(cboEmpresa, "Nombre", _leEmp, -1)
            LlenarCombo(cboEPS, "Nombre", _leEmp, -1)
            LlenaComboConfigurable(cboRegimenSalud, "T32_Reg_Aseg_Salud", "CODIGO", "NOMBRE", -1)
            LlenaComboConfigurable(cboAdicional, "IT4_Adicional_EPS", "ID", "NOMBRE", -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            oePlanesEPS = New e_PlanesEPS
            oePlanesEPS.Activo = Activo
            oePlanesEPS.Vigente = 1
            lePlanesEPS = olPlanesEPS.Listar(oePlanesEPS)
            CargarPlanEPS(lePlanesEPS)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub Inicializar()

        txtCodigo.Text = String.Empty
        txtNombre.Text = String.Empty
        txtDescripcion.Text = String.Empty
        cboEmpresa.SelectedIndex = -1
        ndPrecio.Value = 0
        ndAdicional1.Value = 0
        ndAdicional2.Value = 0
        ndAdicional3.Value = 0
        ndAdicional4.Value = 0
        ndAdicional5.Value = 0
        ndMontoHijoMayor.Value = 0

        cboRegimenSalud.SelectedIndex = 0
        cboEPS.SelectedIndex = -1
        cboPlanEPS.SelectedIndex = -1
        cboAdicional.SelectedIndex = 0
        fecInicioRSalud.Value = Date.Now.Date
        fecFinRSalud.Value = Date.Now.Date

        optAporteSCTR.CheckedIndex = -1
        optCoberturaPension.CheckedIndex = -1
        optCoberturaSalud.CheckedIndex = -1
        fecInicioSComp.Value = Date.Now.Date
        fecFinSComp.Value = Date.Now.Date

    End Sub

    Private Sub Mostrar()
        Try
            If griPlanEPS.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oePlanesEPS.TipoOperacion = ""
                oePlanesEPS.Id = griPlanEPS.ActiveRow.Cells("Id").Value.ToString
                oePlanesEPS = olPlanesEPS.Obtener(oePlanesEPS)
                txtCodigo.Text = oePlanesEPS.Codigo
                txtNombre.Text = oePlanesEPS.Nombre
                txtDescripcion.Text = oePlanesEPS.Descripcion
                cboEmpresa.Value = oePlanesEPS.IdEmpresa
                ndPrecio.Value = oePlanesEPS.Precio
                ndAdicional1.Value = oePlanesEPS.Adicional1
                ndAdicional2.Value = oePlanesEPS.Adicional2
                ndAdicional3.Value = oePlanesEPS.Adicional3
                ndAdicional4.Value = oePlanesEPS.Adicional4
                ndAdicional5.Value = oePlanesEPS.Adicional5
                ndMontoHijoMayor.Value = oePlanesEPS.MontoHijoMayor
                SeleccionaTabs(1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function Guardando() As Boolean
        Try
            oePlanesEPS.UsuarioCreacion = gUsuarioSGI.Id
            oePlanesEPS.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olPlanesEPS.Guardar(oePlanesEPS) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                SeleccionaTabs(0)
                Consultar(_Activo)
                griPlanEPS.Focus()
                Return True
            End If
        Catch ex As Exception
            'mensajeEmergente.Problema(ex.Message, True)
            'Enfocar(ex.Message)
            Throw ex
        End Try
    End Function

    Private Sub CargarPlanEPS(lePlan As List(Of e_PlanesEPS))
        Try
            With griPlanEPS

                .ResetDisplayLayout()
                .DataSource = lePlan
                .Text = "Relación de Planes EPS"
                OcultarColumna(griPlanEPS, True, "Id", "UsuarioCreacion", "FechaCreacion", "IdEmpresa", "Vigente", "Activo")
                ExcluirColumna(griPlanEPS, "UsuarioCreacion", "FechaCreacion", "Vigente", "Activo")
                .DisplayLayout.Bands(0).Columns("Empresa").Width = 300
                .DisplayLayout.Bands(0).Columns("Descripcion").Width = 250
                FormatoColumna(griPlanEPS, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Precio", "Adicional1", "Adicional2", "Adicional3", _
                               "Adicional4", "Adicional5", "MontoHijoMayor")
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

    Private Function ObtieneCodigo() As String
        Try
            Dim oe As New e_PlanesEPS
            oe.TipoOperacion = "C"
            Return olPlanesEPS.Obtener(oe).Codigo
        Catch ex As Exception
            'mensajeEmergente.Problema(ex.Message, True)
            Return ""
        End Try
    End Function

    Private Sub SeleccionaTabs(_index As Integer)
        ficPlanEPS.Tabs(0).Enabled = False
        ficPlanEPS.Tabs(1).Enabled = False
        ficPlanEPS.Tabs(2).Enabled = False
        ficPlanEPS.Tabs(3).Enabled = False
        ficPlanEPS.Tabs(_index).Enabled = True
        ficPlanEPS.SelectedTab = ficPlanEPS.Tabs(_index)
    End Sub

    Private Sub LlenarRS()
        oeRegimenSalud.Regimen = cboRegimenSalud.Value
        oeRegimenSalud.IdPlanEPS = cboPlanEPS.Value
        oeRegimenSalud.Adicional = cboAdicional.Value
        oeRegimenSalud.FechaInicio = fecInicioRSalud.Value
        oeRegimenSalud.FechaFin = fecFinRSalud.Value
    End Sub

    Private Sub CargarRS()

        oePlanesEPS = New e_PlanesEPS
        oePlanesEPS.TipoOperacion = ""
        oePlanesEPS.Activo = True
        oePlanesEPS.Vigente = 1
        lePlanesEPS = olPlanesEPS.Listar(oePlanesEPS)

        cboRegimenSalud.Value = oeRegimenSalud.Regimen
        oePlanesEPS = New e_PlanesEPS
        oePlanesEPS.Id = oeRegimenSalud.IdPlanEPS
        oePlanesEPS.Equivale = 1
        If lePlanesEPS.Contains(oePlanesEPS) Then
            oePlanesEPS = lePlanesEPS.Item(lePlanesEPS.IndexOf(oePlanesEPS))
            cboEPS.Value = oePlanesEPS.IdEmpresa
            cboPlanEPS.Value = oePlanesEPS.Id
            cboAdicional.Value = oeRegimenSalud.Adicional
        End If

        fecInicioRSalud.Value = oeRegimenSalud.FechaInicio
        fecFinRSalud.Value = oeRegimenSalud.FechaFin

    End Sub

    Private Sub LlenarSC()
        oeSeguroComplementario.AportaSCTR = IIf(optAporteSCTR.CheckedIndex = 1, True, False)
        oeSeguroComplementario.CoberturaPension = optCoberturaPension.CheckedIndex
        oeSeguroComplementario.CoberturaSalud = optCoberturaSalud.CheckedIndex
        oeSeguroComplementario.FechaInicio = fecInicioRSalud.Value
        oeSeguroComplementario.FechaFin = fecFinRSalud.Value
    End Sub

    Private Sub CargarSC()
        optAporteSCTR.CheckedIndex = IIf(oeSeguroComplementario.AportaSCTR, 1, 0)
        optCoberturaPension.CheckedIndex = oeSeguroComplementario.CoberturaPension
        optCoberturaSalud.CheckedIndex = oeSeguroComplementario.CoberturaSalud
        fecInicioSComp.Value = oeSeguroComplementario.FechaInicio
        fecFinSComp.Value = oeSeguroComplementario.FechaFin
    End Sub

#End Region

End Class