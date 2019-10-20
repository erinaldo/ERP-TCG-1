'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Microsoft.Office.Interop

''' <summary>
''' Formulario para la gestión de información de aportes y descuentos de planilla
''' </summary>
''' <remarks></remarks>
Public Class frm_AporteDescuento
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New(Accion As String, _oeAporDesc As e_AporteDescuento)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        mnuMantAD.Visible = True
        bandcargar = False
        'Inicializa()
        CargarCombo()
        oeAporteDescuento = _oeAporDesc
        Select Case Accion
            Case "Agregar"
                Nuevo()
            Case "Editar"
                Editar()
        End Select
    End Sub

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        mnuMantAD.Visible = False
    End Sub

    Private Shared instancia As frm_AporteDescuento = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_AporteDescuento()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oeAporteDescuento As New e_AporteDescuento, olAporteDescuento As New l_AporteDescuento, leAporteDescuento As New List(Of e_AporteDescuento)
    Private oeDetalleApoDes As New e_DetalleAporteDescuento, oeDetADAux As New e_DetalleAporteDescuento, leDetalleAD As New List(Of e_DetalleAporteDescuento)
    Private oeFormula As New e_Formula, olFormula As New l_Formula, leFormula As New List(Of e_Formula)
    Private _indrh As Boolean = False
    Private bandcargar As Boolean = True
    Private _opeAD As String = "", _acl As String = ""

#End Region

#Region "Botonera"

    ''' <summary>
    ''' Método para Consultar información de aportes y descuentos de planilla
    ''' </summary>
    ''' <param name="Activo"></param>
    ''' <remarks></remarks>
    Public Overrides Sub Consultar(Activo As Boolean)
        Try
            Listar()
            If griAporteDescuento.Rows.Count > 0 Then
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
                _opeAD = "GENERADA"
                oeAporteDescuento = New e_AporteDescuento
                oeAporteDescuento.TipoOperacion = "I"
                oeAporteDescuento.Activo = True
                oeDetalleApoDes = New e_DetalleAporteDescuento
                oeDetalleApoDes.TipoOperacion = "I"
                oeDetalleApoDes.Activo = True
                oeDetalleApoDes.Vigencia = 1
                Inicializa()
                txtCodigo.Text = fn_ObtenerCodigo()
                btnActualizar.Enabled = False
                Bloquea(False)
                btnAgregarFor.Enabled = True
                MostrarTabs(1, ficAporteDescuento)
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
                _opeAD = "GENERADA"
                Inicializa()
                Mostrar()
                btnActualizar.Enabled = True
                Bloquea(True)
                oeAporteDescuento.TipoOperacion = "A"
                MostrarTabs(1, ficAporteDescuento)
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            oeAporteDescuento.UsuarioCreacion = gUsuarioSGI.Id
            oeDetalleApoDes.FechaActividad = fecActividad.Value
            If _indrh Then
                oeDetADAux.FechaActividad = fecActividad.Value
                oeDetADAux.MontoCalculo = ndValor.Value
                oeDetADAux.UnidadCalculo = cboUnidad.Text
                oeDetADAux.IdFormula = cboFormula.Value
                oeDetADAux.UsuarioCreacion = gUsuarioSGI.Id
                oeDetADAux.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeAporteDescuento.leHistorial.Add(oeDetADAux)
            Else
                If oeAporteDescuento.TipoOperacion = "I" Then
                    oeDetalleApoDes.PrefijoID = gs_PrefijoIdSucursal '@0001
                    oeAporteDescuento.leHistorial.Add(oeDetalleApoDes)
                End If
            End If
            oeAporteDescuento.PrefijoID = gs_PrefijoIdSucursal '@0001
            olAporteDescuento.Guardar(oeAporteDescuento)
            mensajeEmergente.Confirmacion("El Registro se Guardo correctamente!!", True)
            If bandcargar Then
                MostrarTabs(0, ficAporteDescuento)
                Consultar(True)
            Else
                Me.Close()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If MessageBox.Show("¿Desea Cancelar la Operacion?", "Mensaje de Sistema", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                If bandcargar Then
                    MostrarTabs(0, ficAporteDescuento)
                    Consultar(True)
                Else
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            _acl = gAccionSistema.ELIMINAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then

            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            _acl = gAccionSistema.EXPORTAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                If griAporteDescuento.Rows.Count > 0 Then
                    Exportar_Excel(griAporteDescuento, "Parametros")
                Else
                    Throw New Exception("¡No hay Registos para Exportar!")
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_AporteDescuento_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Select Case ficAporteDescuento.SelectedTab.Index
            Case 0
                If griAporteDescuento.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        End Select
    End Sub

    Private Sub frm_AporteDescuento_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_AporteDescuento_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            CargarCombo()
            colorVigente.Color = Color.LightGreen
            colorNoVigente.Color = Color.Khaki
            CargarApoDes(New List(Of e_AporteDescuento))
            CargarHistorial(New List(Of e_DetalleAporteDescuento))
            txtContextoFormula.CharacterCasing = CharacterCasing.Normal
            If bandcargar Then
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                MostrarTabs(0, ficAporteDescuento)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtCodigo_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtCodigo.ValueChanged
        oeAporteDescuento.Codigo = txtCodigo.Text
    End Sub

    Private Sub txtNombre_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtNombre.ValueChanged
        oeAporteDescuento.Nombre = txtNombre.Text
    End Sub

    Private Sub cboTipo_ValueChanged(sender As System.Object, e As System.EventArgs) Handles cboTipo.ValueChanged
        If cboTipo.SelectedIndex > -1 Then
            oeAporteDescuento.AporteDescuento = cboTipo.SelectedIndex + 1
        End If
    End Sub

    Private Sub griAporteDescuento_DoubleClick(sender As System.Object, e As System.EventArgs) Handles griAporteDescuento.DoubleClick
        If griAporteDescuento.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        Try
            If MessageBox.Show("¿Desea Enviar este Registro al historial y Generar uno nuevo?", "Mensaje de Sistema", MessageBoxButtons.YesNo, _
                          MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                _indrh = True
                oeDetADAux = New e_DetalleAporteDescuento
                oeDetADAux.TipoOperacion = "I"
                oeDetADAux.Activo = True
                oeDetADAux.Vigencia = 1
            Else
                Dim _leDetAux = leDetalleAD.Where(Function(it) it.Activo = True And it.Vigencia = 1).ToList
                If _leDetAux.Count > 0 Then
                    oeDetalleApoDes = _leDetAux(0)
                    oeDetalleApoDes.TipoOperacion = "A"
                End If
            End If
            Bloquea(False)
            btnActualizar.Enabled = False
            btnAgregarFor.Enabled = True
            btnModificarFor.Enabled = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboUnidad_ValueChanged(sender As System.Object, e As System.EventArgs) Handles cboUnidad.ValueChanged
        If cboUnidad.SelectedIndex > -1 Then
            oeDetalleApoDes.UnidadCalculo = cboUnidad.Text
            agrFormula.Visible = IIf(cboUnidad.Text = "FORMULA", True, False)
        End If

    End Sub

    Private Sub ndValor_ValueChanged(sender As System.Object, e As System.EventArgs) Handles ndValor.ValueChanged
        If Not IsDBNull(ndValor.Value) Then
            oeDetalleApoDes.MontoCalculo = ndValor.Value
        Else
            ndValor.Value = 0
        End If
    End Sub

    Private Sub fecActividad_ValueChanged(sender As System.Object, e As System.EventArgs) Handles fecActividad.ValueChanged
        oeDetalleApoDes.FechaActividad = fecActividad.Value
    End Sub

    Private Sub cboFormula_ValueChanged(sender As Object, e As EventArgs) Handles cboFormula.ValueChanged
        If cboFormula.SelectedIndex > -1 Then
            oeDetalleApoDes.IdFormula = cboFormula.Value
            Dim _leForAux = leFormula.Where(Function(it) it.Id = cboFormula.Value).ToList
            If _leForAux.Count > 0 Then
                txtContextoFormula.Text = _leForAux(0).Esquema
            End If
        End If
    End Sub

    Private Sub txtAbreviatura_ValueChanged(sender As Object, e As EventArgs) Handles txtAbreviatura.ValueChanged
        oeAporteDescuento.Abreviatura = txtAbreviatura.Text.ToString
    End Sub

    Private Sub btnAgregarFor_Click(sender As Object, e As EventArgs) Handles btnAgregarFor.Click
        Try
            oeFormula = New e_Formula
            MantFormula("Agregar", oeFormula)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnModificarFor_Click(sender As Object, e As EventArgs) Handles btnModificarFor.Click
        Try
            If cboFormula.SelectedIndex > -1 Then
                oeFormula = New e_Formula
                oeFormula = cboFormula.Items(cboFormula.SelectedIndex).ListObject
                MantFormula("Editar", oeFormula)
            Else
                Throw New Exception("Debe Seleccionar una Formula para Editar")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mnuMantAD_ToolClick(sender As Object, e As UltraWinToolbars.ToolClickEventArgs) Handles mnuMantAD.ToolClick
        Try
            Select Case e.Tool.Key
                Case "Grabar"
                    Guardar()
                Case "Cancelar"
                    Cancelar()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombo()
        Try

            cboTipo.Items.Clear()
            cboTipo.Items.Add("PARAMETRO")
            cboTipo.Items.Add("ESTRUCTURA PLANILLA")

            cboUnidad.Items.Clear()
            cboUnidad.Items.Add("NUMERO")
            cboUnidad.Items.Add("PORCENTAJE")
            cboUnidad.Items.Add("FORMULA")

            CargarFormula()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar()
        Try

            oeAporteDescuento = New e_AporteDescuento
            oeAporteDescuento.TipoOperacion = ""
            oeAporteDescuento.AporteDescuento = "0"
            oeAporteDescuento.Activo = True
            leAporteDescuento = olAporteDescuento.Listar(oeAporteDescuento)

            CargarApoDes(leAporteDescuento)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarApoDes(leApoDes As List(Of e_AporteDescuento))
        Try
            With griAporteDescuento

                .ResetDisplayLayout()

                .DataSource = leApoDes

                OcultarColumna(griAporteDescuento, True, "Id", "AporteDescuento", "FechaCreacion", "UsuarioCreacion", "Activo")

                ExcluirColumna(griAporteDescuento, "Id", "AporteDescuento", "FechaCreacion", "UsuarioCreacion", "Activo")

                .DisplayLayout.Bands(0).Columns("Nombre").Width = 300
                .DisplayLayout.Bands(0).Columns("Tipo").Width = 150

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
        txtNombre.Text = String.Empty
        txtAbreviatura.Text = String.Empty
        cboTipo.SelectedIndex = -1
        agrFormula.Visible = False
        cboFormula.SelectedIndex = -1
        txtContextoFormula.Text = String.Empty
        InicializaDet()
        leDetalleAD = New List(Of e_DetalleAporteDescuento)
        CargarHistorial(leDetalleAD)
        _indrh = False
        btnAgregarFor.Enabled = False
        btnModificarFor.Enabled = False
    End Sub

    Private Sub InicializaDet()
        cboUnidad.SelectedIndex = -1
        ndValor.Value = 0
        fecActividad.Value = Date.Now.Date
    End Sub

    Private Sub Mostrar()
        Try
            oeAporteDescuento = New e_AporteDescuento
            oeAporteDescuento.TipoOperacion = ""
            oeAporteDescuento.Id = griAporteDescuento.ActiveRow.Cells("Id").Value
            oeAporteDescuento = olAporteDescuento.Obtener(oeAporteDescuento)
            With oeAporteDescuento
                txtCodigo.Text = .Codigo
                txtNombre.Text = .Nombre
                txtAbreviatura.Text = .Abreviatura
                cboTipo.SelectedIndex = .AporteDescuento - 1
                leDetalleAD = .leHistorial
                CargarHistorial(leDetalleAD)
                Dim _leAux = .leHistorial.Where(Function(it) it.Vigencia = 1).ToList
                If _leAux.Count > 0 Then
                    oeDetalleApoDes = New e_DetalleAporteDescuento
                    oeDetalleApoDes.TipoOperacion = "A"
                    oeDetalleApoDes = _leAux(0)
                    cboUnidad.Text = oeDetalleApoDes.UnidadCalculo
                    ndValor.Value = oeDetalleApoDes.MontoCalculo
                    fecActividad.Value = oeDetalleApoDes.FechaActividad
                    If oeDetalleApoDes.UnidadCalculo = "FORMULA" AndAlso oeDetalleApoDes.IdFormula.Trim <> "" Then
                        cboFormula.Value = oeDetalleApoDes.IdFormula
                    End If
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarHistorial(leHistorial As List(Of e_DetalleAporteDescuento))
        Try
            With griDetalle

                .ResetDisplayLayout()
                .DataSource = leHistorial

                OcultarColumna(griDetalle, True, "Id", "IdAporteDescuento", "IdFormula", "FechaCreacion", "UsuarioCreacion", "Activo")

                ExcluirColumna(griDetalle, "Id", "IdAporteDescuento", "FechaCreacion", "UsuarioCreacion", "Activo")

                .DisplayLayout.Bands(0).Columns("Vigencia").Style = ColumnStyle.CheckBox

                FormatoColumna(griDetalle, "#,##0.00", ColumnStyle.Double, HAlign.Right, "MontoCalculo")

                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

                For Each fil In .Rows
                    If fil.Cells("Vigencia").Value Then
                        fil.CellAppearance.BackColor = colorVigente.Color
                    Else
                        fil.CellAppearance.BackColor = colorNoVigente.Color
                    End If
                Next

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function fn_ObtenerCodigo() As String
        Try
            Dim oeApeDes As New e_AporteDescuento
            Dim strCodigo As String = ""
            oeApeDes.TipoOperacion = "U"
            oeApeDes = olAporteDescuento.Obtener(oeApeDes)
            If oeApeDes IsNot Nothing AndAlso oeApeDes.Codigo <> "" Then
                strCodigo = oeApeDes.Codigo
            End If
            Return strCodigo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Bloquea(Band As Boolean)
        cboUnidad.ReadOnly = Band
        ndValor.ReadOnly = Band
        fecActividad.Enabled = Not Band
        cboFormula.ReadOnly = Band
        'btnActualizar.Enabled = Not Band
    End Sub

    Private Sub MantFormula(Accion As String, oeForm As e_Formula)
        Try
            Dim _frm As New frm_Formula(Accion, oeForm)
            Dim _id As String = ""
            _frm.Width = 938
            _frm.Height = 396
            _frm.StartPosition = FormStartPosition.CenterScreen
            _frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
            _frm.ShowDialog()
            _id = oeForm.Id
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            CargarFormula()
            cboFormula.Value = _id
            ' CargarContrato(oeTrabajador.leContratos)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarFormula()
        Try
            oeFormula = New e_Formula
            oeFormula.TipoOperacion = ""
            oeFormula.Activo = True
            leFormula = olFormula.Listar(oeFormula)
            LlenarCombo(cboFormula, "Nombre", leFormula, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class