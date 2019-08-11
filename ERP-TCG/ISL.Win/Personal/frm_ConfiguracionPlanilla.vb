Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_ConfiguracionPlanilla
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ConfiguracionPlanilla = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ConfiguracionPlanilla()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oeConfiguracionPlanilla As New e_ConfiguracionPlanilla, olConfiguracionPlanilla As New l_ConfiguracionPlanilla
    Private leConfiguracionPlanilla As New List(Of e_ConfiguracionPlanilla)
    Private oeAporteDescuento As New e_AporteDescuento, olAporteDescuento As New l_AporteDescuento
    Private leAporteDescuento As New List(Of e_AporteDescuento)
    Private oeDetalleConPla As New e_DetalleConfiguracionPlanilla, leDetalleConPla As New List(Of e_DetalleConfiguracionPlanilla)
    Private _opeCP As String = "", _acl As String = ""

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(Activo As Boolean)
        Try
            Listar()
            If griConfiguracionPlanilla.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
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
                oeConfiguracionPlanilla = New e_ConfiguracionPlanilla
                oeConfiguracionPlanilla.TipoOperacion = "I"
                oeConfiguracionPlanilla.Activo = True
                Inicializa()
                txtCodigo.Text = fn_ObtenerCodigo()
                ' cboEstado.Text = "GENERADA"
                MostrarTabs(1, ficConfiguracionPlanilla)
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
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
                Inicializa()
                Mostrar()
                ' btnActualizar.Enabled = True
                oeConfiguracionPlanilla.TipoOperacion = "A"
                MostrarTabs(1, ficConfiguracionPlanilla)
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
            RecolectaDatos()
            If oeConfiguracionPlanilla.TipoOperacion = "I" Then
                oeConfiguracionPlanilla.UsuarioCreacion = gUsuarioSGI.Id
            Else
                oeConfiguracionPlanilla.UsuarioModifica = gUsuarioSGI.Id
            End If
            olConfiguracionPlanilla.Guardar(oeConfiguracionPlanilla)
            mensajeEmergente.Confirmacion("¡El Registro se Guardo correctamente!", True)
            MostrarTabs(0, ficConfiguracionPlanilla)
            Consultar(True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If MessageBox.Show("¿Desea Cancelar la Operacion?", "Mensaje de Sistema", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                MostrarTabs(0, ficConfiguracionPlanilla)
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If griDetalleConfigPla.Rows.Count > 0 Then
                Exportar_Excel(griDetalleConfigPla)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ConfiguracionPlanilla_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Select Case ficConfiguracionPlanilla.SelectedTab.Index
            Case 0
                If griConfiguracionPlanilla.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        End Select
    End Sub

    Private Sub frm_ConfiguracionPlanilla_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ConfiguracionPlanilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarCombos()
            CargarConfiguracionPlanilla(New List(Of e_ConfiguracionPlanilla))
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            MostrarTabs(0, ficConfiguracionPlanilla)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mnuDetalle_ToolClick(sender As Object, e As UltraWinToolbars.ToolClickEventArgs) Handles mnuDetalle.ToolClick
        Try
            Select Case e.Tool.Key
                Case "Agregar"
                    ControlDetalle(0, 0, 1, 1, 0)
                    agrDatosDetalle.Expanded = True
                    InicializaDetalle()
                    nroOrden.Value = griDetalleConfigPla.Rows.Count + 1
                    oeDetalleConPla = New e_DetalleConfiguracionPlanilla
                    oeDetalleConPla.TipoOperacion = "I"
                    oeDetalleConPla.UsuarioCreacion = gUsuarioSGI.Id
                    btnAgregarAD.Enabled = True
                Case "Modificar"
                    EditarDetalle()
                Case "Grabar"
                    RecogeDatosDetalle()
                    If fn_Validar() Then
                        If oeDetalleConPla.TipoOperacion = "I" Then
                            oeDetalleConPla.Equivale = 2
                            If leDetalleConPla.Contains(oeDetalleConPla) Then
                                Dim oeDet As New e_DetalleConfiguracionPlanilla
                                oeDet = leDetalleConPla.Item(leDetalleConPla.IndexOf(oeDetalleConPla))
                                If oeDet.Activo = True Then
                                    Throw New Exception("Ya se Registro la Columna: " & oeDet.NombreTipo & " en la posicion: " & oeDet.NroOrden)
                                Else
                                    oeDet.Activo = True
                                    oeDet.TipoOperacion = "A"
                                End If
                            Else
                                leDetalleConPla.Add(oeDetalleConPla)
                            End If
                        Else

                        End If
                        ControlDetalle(1, 1, 0, 0, 1)
                        agrDatosDetalle.Expanded = False
                        ListarDetalle()
                        griDetalleConfigPla.DataBind()
                    End If
                Case "Cancelar"
                    If MessageBox.Show("¿Desea Cancelar la Operacion?", "Mensaje de Sistema", _
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        If griDetalleConfigPla.Rows.Count > 0 Then
                            ControlDetalle(1, 1, 0, 0, 1)
                        Else
                            ControlDetalle(1, 0, 0, 0, 0)
                        End If
                        agrDatosDetalle.Expanded = False
                    End If
                Case "Quitar"
                    If griDetalleConfigPla.Selected.Rows.Count > 0 Then
                        oeDetalleConPla = New e_DetalleConfiguracionPlanilla
                        oeDetalleConPla.Equivale = 1
                        oeDetalleConPla.Id = griDetalleConfigPla.ActiveRow.Cells("Id").Value
                        If leDetalleConPla.Contains(oeDetalleConPla) Then
                            oeDetalleConPla = leDetalleConPla.Item(leDetalleConPla.IndexOf(oeDetalleConPla))
                            oeDetalleConPla.TipoOperacion = "E"
                            oeDetalleConPla.Activo = 0
                        Else
                            oeDetalleConPla.Equivale = 2
                            oeDetalleConPla.IdAporteDescuento = griDetalleConfigPla.ActiveRow.Cells("IdAporteDescuento").Value
                            If leDetalleConPla.Contains(oeDetalleConPla) Then
                                leDetalleConPla.Remove(oeDetalleConPla)
                            End If
                        End If
                        ListarDetalle()
                        griDetalleConfigPla.DataBind()
                    Else
                        Throw New Exception("¡Seleccione un Registro!")
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griConfiguracionPlanilla_DoubleClick(sender As Object, e As EventArgs) Handles griConfiguracionPlanilla.DoubleClick
        If griConfiguracionPlanilla.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griDetalleConfigPla_DoubleClick(sender As Object, e As EventArgs) Handles griDetalleConfigPla.DoubleClick
        If griDetalleConfigPla.Selected.Rows.Count > 0 Then EditarDetalle()
    End Sub

    Private Sub btnAgregarAD_Click(sender As Object, e As EventArgs) Handles btnAgregarAD.Click
        Try
            oeAporteDescuento = New e_AporteDescuento
            Dim _frm As New frm_AporteDescuento("Agregar", oeAporteDescuento)
            Dim _id As String = ""
            _frm.Width = 938
            _frm.Height = 396
            _frm.StartPosition = FormStartPosition.CenterScreen
            _frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
            _frm.ShowDialog()
            _id = oeAporteDescuento.Id
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            CargarAporDesc()
            cboColumna.Value = _id
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombos()
        Try

            cboTipo.Items.Clear()
            cboTipo.Items.Add("INGRESO")
            cboTipo.Items.Add("DEDUCCION")
            cboTipo.Items.Add("APORTE")
            cboTipo.Items.Add("NETO")
            cboTipo.SelectedIndex = -1

            cboTipo2.Items.Clear()
            cboTipo2.Items.Add("NINGUNO")
            cboTipo2.Items.Add("SUBTOTAL")
            cboTipo2.Items.Add("GENERAL")
            cboTipo2.SelectedIndex = -1

            CargarAporDesc()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar()
        Try
            oeConfiguracionPlanilla = New e_ConfiguracionPlanilla
            oeConfiguracionPlanilla.TipoOperacion = ""
            oeConfiguracionPlanilla.Activo = True
            leConfiguracionPlanilla = olConfiguracionPlanilla.Listar(oeConfiguracionPlanilla)
            CargarConfiguracionPlanilla(leConfiguracionPlanilla)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarConfiguracionPlanilla(leConPla As List(Of e_ConfiguracionPlanilla))
        Try
            With griConfiguracionPlanilla

                .ResetDisplayLayout()
                .DataSource = leConPla

                OcultarColumna(griConfiguracionPlanilla, True, "Id", "FechaCreacion", "UsuarioCreacion", "FechaModifica", "UsuarioModifica", "Activo")

                .DisplayLayout.Bands(0).Columns("Nombre").Width = 150
                .DisplayLayout.Bands(0).Columns("Descripcion").Width = 300

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

    Private Sub Inicializa()
        txtCodigo.Text = String.Empty
        txtDescripcion.Text = String.Empty
        txtNombre.Text = String.Empty
        agrDatosDetalle.Expanded = False
        CargarDetalleConPla(New List(Of e_DetalleConfiguracionPlanilla))
        ControlDetalle(1, 0, 0, 0, 0)
    End Sub

    Private Sub Mostrar()
        Try
            oeConfiguracionPlanilla = New e_ConfiguracionPlanilla
            oeConfiguracionPlanilla.TipoOperacion = ""
            oeConfiguracionPlanilla.Id = griConfiguracionPlanilla.ActiveRow.Cells("Id").Value
            oeConfiguracionPlanilla = olConfiguracionPlanilla.Obtener(oeConfiguracionPlanilla)
            With oeConfiguracionPlanilla
                txtCodigo.Text = .Codigo
                txtDescripcion.Text = .Descripcion
                txtNombre.Text = .Nombre
                leDetalleConPla = .leDetalle
                ListarDetalle()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function fn_ObtenerCodigo() As String
        Try
            Dim str As String = ""
            Dim oeConPla As New e_ConfiguracionPlanilla
            oeConPla.TipoOperacion = "U"
            oeConPla = olConfiguracionPlanilla.Obtener(oeConPla)
            If oeConPla IsNot Nothing AndAlso oeConPla.Codigo <> "" Then
                str = oeConPla.Codigo
            End If
            Return str
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub RecolectaDatos()
        oeConfiguracionPlanilla.Codigo = txtCodigo.Text
        oeConfiguracionPlanilla.Nombre = txtNombre.Text
        oeConfiguracionPlanilla.Descripcion = txtDescripcion.Text
    End Sub

    Private Sub CargarDetalleConPla(leDetConPla As List(Of e_DetalleConfiguracionPlanilla))
        Try
            With griDetalleConfigPla

                .ResetDisplayLayout()

                Dim _leDetAux = leDetConPla.Where(Function(it) it.Activo = True).OrderBy(Function(it) it.NroOrden).ToList

                .DataSource = _leDetAux

                OcultarColumna(griDetalleConfigPla, True, "Id", "IdConfiguracionPlanilla", "IdAporteDescuento", "Tipo", _
                               "IndTotal", "FechaCreacion", "UsuarioCreacion", "FechaModifica", "UsuarioModifica", "Activo")

                ExcluirColumna(griDetalleConfigPla, "Id", "IdConfiguracionPlanilla", "IdAporteDescuento")

                .DisplayLayout.Bands(0).Columns("NroOrden").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("AporteDescuento").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Abreviatura").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("NombreTipo").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("TipoTotal").Header.VisiblePosition = 4

                .DisplayLayout.Bands(0).Columns("AporteDescuento").Width = 250
                .DisplayLayout.Bands(0).Columns("NombreTipo").Width = 150

                .DisplayLayout.Bands(0).Columns("NombreTipo").Header.Caption = "Tipo"

                For Each col In .DisplayLayout.Bands(0).Columns
                    If col.Key = "NroOrden" Then
                        col.CellActivation = Activation.AllowEdit
                        col.CellClickAction = CellClickAction.Edit
                    Else
                        col.CellActivation = Activation.NoEdit
                        col.CellClickAction = CellClickAction.RowSelect
                    End If
                Next

                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                '.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                '.DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ControlDetalle(lb_Agregar As Boolean, lb_Modificar As Boolean, lb_Grabar As Boolean, lb_Cancelar As Boolean, lb_Quitar As Boolean)
        With mnuDetalle.Tools
            .Item("Agregar").SharedProps.Enabled = lb_Agregar
            .Item("Modificar").SharedProps.Enabled = lb_Modificar
            .Item("Grabar").SharedProps.Enabled = lb_Grabar
            .Item("Cancelar").SharedProps.Enabled = lb_Cancelar
            .Item("Quitar").SharedProps.Enabled = lb_Quitar
        End With
    End Sub

    Private Sub InicializaDetalle()
        cboColumna.SelectedIndex = -1
        cboTipo.SelectedIndex = -1
        cboTipo2.SelectedIndex = 0
        nroOrden.Value = 0
        txtCodigoSunat.Text = ""
        btnAgregarAD.Enabled = False
    End Sub

    Private Sub ListarDetalle()
        CargarDetalleConPla(leDetalleConPla)
        If griDetalleConfigPla.Rows.Count > 0 Then
            ControlDetalle(1, 1, 0, 0, 1)
        Else
            ControlDetalle(1, 0, 0, 0, 0)
        End If
    End Sub

    Private Sub RecogeDatosDetalle()
        oeDetalleConPla.IdAporteDescuento = cboColumna.Value
        oeDetalleConPla.AporteDescuento = cboColumna.Text
        oeDetalleConPla.Tipo = cboTipo.SelectedIndex + 1
        oeDetalleConPla.NombreTipo = cboTipo.Text
        oeDetalleConPla.NroOrden = nroOrden.Value
        oeDetalleConPla.IndTotal = cboTipo2.SelectedIndex
        oeDetalleConPla.TipoTotal = cboTipo2.Text
        oeDetalleConPla.CodigoSunat = txtCodigoSunat.Text
    End Sub

    Private Sub MostraDetalle(oeDetConpla As e_DetalleConfiguracionPlanilla)
        cboColumna.Value = oeDetConpla.IdAporteDescuento
        cboTipo.Text = oeDetConpla.NombreTipo
        nroOrden.Value = oeDetConpla.NroOrden
        cboTipo2.Text = oeDetConpla.TipoTotal
        txtCodigoSunat.Text = oeDetConpla.CodigoSunat
    End Sub

    Private Function fn_Validar() As Boolean
        With oeDetalleConPla
            If .IdAporteDescuento = "" Then Throw New Exception("Seleccione Columna")
            If .Tipo < 1 Then Throw New Exception("Seleccione Tipo")
        End With
        Return True
    End Function

    Private Sub EditarDetalle()
        Try
            If griDetalleConfigPla.Selected.Rows.Count > 0 Then
                ControlDetalle(0, 0, 1, 1, 0)
                agrDatosDetalle.Expanded = True
                InicializaDetalle()
                oeDetalleConPla = New e_DetalleConfiguracionPlanilla
                oeDetalleConPla.Equivale = 1
                oeDetalleConPla.Id = griDetalleConfigPla.ActiveRow.Cells("Id").Value
                If Not leDetalleConPla.Contains(oeDetalleConPla) Then
                    oeDetalleConPla.Equivale = 2
                    oeDetalleConPla.IdAporteDescuento = griDetalleConfigPla.ActiveRow.Cells("IdAporteDescuento").Value
                End If
                oeDetalleConPla = leDetalleConPla.Item(leDetalleConPla.IndexOf(oeDetalleConPla))
                oeDetalleConPla.UsuarioModifica = gUsuarioSGI.Id
                oeDetalleConPla.TipoOperacion = "A"
                MostraDetalle(oeDetalleConPla)
            Else
                Throw New Exception("¡Seleccione un Registro!")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarAporDesc()
        Try

            oeAporteDescuento = New e_AporteDescuento
            oeAporteDescuento.TipoOperacion = ""
            oeAporteDescuento.Activo = True
            leAporteDescuento = olAporteDescuento.Listar(oeAporteDescuento)
            Dim _leColumna = leAporteDescuento.Where(Function(it) it.AporteDescuento = 2).ToList
            LlenarCombo(cboColumna, "Nombre", _leColumna, -1)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class