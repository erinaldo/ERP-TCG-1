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
Imports System.Text.RegularExpressions

Public Class frm_Formula
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New(Accion As String, _oeFormula As e_Formula)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        mnuMantFormula.Visible = True
        bandcargar = False
        'Inicializa()
        CargarCombos()
        oeFormula = _oeFormula
        'leContratosAux = oeTrabAux.leContratos
        Select Case Accion
            Case "Agregar"
                Nuevo()
                ' cboTrabajador.Value = oeContratos.IdTrabajador
            Case "Editar"
                Editar()
                'CargarDatos(oeContratos)
                'cboTrabajador.ReadOnly = True
        End Select
        'cboTrabajador.ReadOnly = True
    End Sub

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        mnuMantFormula.Visible = False
    End Sub

    Private Shared instancia As frm_Formula = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Formula()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oeFormula As New e_Formula, olFormula As New l_Formula, leFormula As New List(Of e_Formula)
    Private oeConstante As New e_AporteDescuento, olConstante As New l_AporteDescuento
    Private leConstante As New List(Of e_AporteDescuento), leConsAux As New List(Of e_AporteDescuento), leConsCbo As New List(Of e_AporteDescuento)
    Private oeConfTabla As New e_ConfiguracionTabla, olConfTabla As New l_ConfiguracionTabla
    Private oeParametro As New e_AporteDescuento, olParametro As New l_AporteDescuento, leParametro As New List(Of e_AporteDescuento)
    Private leParamAux As New List(Of e_AporteDescuento), leParamCbo As New List(Of e_AporteDescuento)
    Private oeDatoTrab As New e_ConfiguracionColumna, leDatoTrab As New List(Of e_ConfiguracionColumna)
    Private leDatoTrabAux As New List(Of e_ConfiguracionColumna), leDatoTrabCbo As New List(Of e_ConfiguracionColumna)
    Private dtVariable As DataTable = CrearDT()
    Private bandcargar As Boolean = True

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(Activo As Boolean)
        Try
            Listar()
            If griFormula.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        oeFormula = New e_Formula
        oeFormula.TipoOperacion = "I"
        oeFormula.Activo = True
        Inicializa()
        txtCodigo.Text = fn_ObtenerCodigo()
        'btnActualizar.Enabled = False
        MostrarTabs(1, ficFormula)
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
    End Sub

    Public Overrides Sub Editar()
        Try
            Inicializa()
            Mostrar()
            ' btnActualizar.Enabled = True
            oeFormula.TipoOperacion = "A"
            MostrarTabs(1, ficFormula)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            oeFormula.UsuarioCreacion = gUsuarioSGI.Id
            oeFormula.PrefijoID = gs_PrefijoIdSucursal '@0001
            olFormula.Guardar(oeFormula)
            mensajeEmergente.Confirmacion("El Registro se Guardo correctamente!!", True)
            If bandcargar Then
                MostrarTabs(0, ficFormula)
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
                    MostrarTabs(0, ficFormula)
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

    End Sub

    Public Overrides Sub Exportar()

    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Formula_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Select Case ficFormula.SelectedTab.Index
            Case 0
                If griFormula.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        End Select
    End Sub

    Private Sub frm_Formula_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Formula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtParametros.ReadOnly = True
            txtConstantes.ReadOnly = True
            txtDatosTrabajador.ReadOnly = True
            txtNombre.CharacterCasing = CharacterCasing.Normal
            txtParametros.CharacterCasing = CharacterCasing.Normal
            txtConstantes.CharacterCasing = CharacterCasing.Normal
            txtInstrucciones.CharacterCasing = CharacterCasing.Normal
            txtDatosTrabajador.CharacterCasing = CharacterCasing.Normal
            If bandcargar Then
                CargarCombos()
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                CargarFormula(New List(Of e_Formula))
                CargarConstantes(New List(Of e_AporteDescuento))
                CargarVariable(dtVariable)
                CargarParametro(New List(Of e_AporteDescuento))
                CargarDatoTrab(New List(Of e_ConfiguracionColumna))
                MostrarTabs(0, ficFormula)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        'Dim ExprReg As Regex = New Regex("[A-Za-z_]")
        'If Not ExprReg.IsMatch(e.KeyChar.ToString) Then e.Handled = True
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            'ElseIf Char.IsSeparator(e.KeyChar) Then
            '    e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCodigo_ValueChanged(sender As Object, e As EventArgs) Handles txtCodigo.ValueChanged
        oeFormula.Codigo = txtCodigo.Text
    End Sub

    Private Sub txtNombre_ValueChanged(sender As Object, e As EventArgs) Handles txtNombre.ValueChanged
        oeFormula.Nombre = txtNombre.Text
    End Sub

    Private Sub txtParametros_ValueChanged(sender As Object, e As EventArgs) Handles txtParametros.ValueChanged
        oeFormula.Parametros = txtParametros.Text
    End Sub

    Private Sub txtConstantes_ValueChanged(sender As Object, e As EventArgs) Handles txtConstantes.ValueChanged
        oeFormula.Constantes = txtConstantes.Text
    End Sub

    Private Sub txtInstrucciones_ValueChanged(sender As Object, e As EventArgs) Handles txtInstrucciones.ValueChanged
        oeFormula.Instrucciones = txtInstrucciones.Text
    End Sub

    Private Sub txtDescripcion_ValueChanged(sender As Object, e As EventArgs) Handles txtDescripcion.ValueChanged
        oeFormula.Descripcion = txtDescripcion.Text
    End Sub

    Private Sub btnParametros_Click(sender As Object, e As EventArgs) Handles btnParametros.Click
        If btnParametros.Text = "P<<" Then
            btnParametros.Text = "P>>"
            btnDatos.Text = "D<<"
            btnConstantes.Text = "C<<"
            btnVariables.Text = "V<<"
            btnInstrucciones.Text = " I <<"
            ficInterativo.Visible = True
            ficInterativo.Tabs(0).Visible = False
            ficInterativo.Tabs(1).Visible = True
            ficInterativo.Tabs(2).Visible = False
            ficInterativo.Tabs(3).Visible = False
            ficInterativo.Tabs(4).Visible = False
            leParamAux = DesintegraParametro(txtParametros.Text.Trim)
            CargarParametro(leParamAux)
            CargarAuxParam()
        Else
            btnParametros.Text = "P<<"
            txtParametros.Text = String.Empty
            txtParametros.Text = IntegraParametro(leParamAux)
            ficInterativo.Visible = False
        End If
    End Sub

    Private Sub btnConstantes_Click(sender As Object, e As EventArgs) Handles btnConstantes.Click
        If btnConstantes.Text = "C<<" Then
            btnDatos.Text = "D>>"
            btnConstantes.Text = "C>>"
            btnParametros.Text = "P<<"
            btnVariables.Text = "V<<"
            btnInstrucciones.Text = " I <<"
            ficInterativo.Visible = True
            ficInterativo.Tabs(0).Visible = False
            ficInterativo.Tabs(1).Visible = False
            ficInterativo.Tabs(2).Visible = True
            ficInterativo.Tabs(3).Visible = False
            ficInterativo.Tabs(4).Visible = False
            leConsAux = DesintegraConstante(txtConstantes.Text.Trim)
            CargarConstantes(leConsAux)
            CargarAuxCons()
        Else
            btnConstantes.Text = "C<<"
            txtConstantes.Text = String.Empty
            txtConstantes.Text = IntegraConstante(leConsAux)
            ficInterativo.Visible = False
        End If
    End Sub

    Private Sub btnInstrucciones_Click(sender As Object, e As EventArgs) Handles btnInstrucciones.Click
        If btnInstrucciones.Text = " I <<" Then
            btnInstrucciones.Text = " D<<"
            btnInstrucciones.Text = " I >>"
            btnParametros.Text = "P<<"
            btnConstantes.Text = "C<<"
            btnVariables.Text = "V<<"
            ficInterativo.Visible = True
            ficInterativo.Tabs(0).Visible = False
            ficInterativo.Tabs(1).Visible = False
            ficInterativo.Tabs(2).Visible = False
            ficInterativo.Tabs(3).Visible = False
            ficInterativo.Tabs(4).Visible = True
        Else
            btnInstrucciones.Text = " I <<"
            ficInterativo.Visible = False
        End If
    End Sub

    Private Sub griFormula_DoubleClick(sender As Object, e As EventArgs) Handles griFormula.DoubleClick
        If griFormula.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub btnAgregarPar_Click(sender As Object, e As EventArgs) Handles btnAgregarPar.Click
        Try
            If cboParametro.SelectedIndex > -1 Then
                oeParametro = New e_AporteDescuento
                oeParametro = cboParametro.Items(cboParametro.SelectedIndex).ListObject
                leParamAux.Add(oeParametro)
                CargarParametro(leParamAux)
                griParametros.DataBind()
                oeParametro.Equivale = 1
                leParamCbo.Remove(oeParametro)
                LlenarCombo(cboParametro, "Nombre", leParamCbo, -1)
                cboParametro.DataBind()
            Else
                Throw New Exception("¡Seleccione un Parametro!")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnQuitarPar_Click(sender As Object, e As EventArgs) Handles btnQuitarPar.Click
        Try
            If griParametros.Selected.Rows.Count > 0 Then
                oeParametro = New e_AporteDescuento
                oeParametro.Id = griParametros.ActiveRow.Cells("Id").Value
                oeParametro.Equivale = 1
                If leParamAux.Contains(oeParametro) Then
                    oeParametro = leParamAux.Item(leParamAux.IndexOf(oeParametro))
                    leParamCbo.Add(oeParametro)
                    LlenarCombo(cboParametro, "Nombre", leParamCbo, -1)
                    cboParametro.DataBind()
                    leParamAux.Remove(oeParametro)
                    CargarParametro(leParamAux)
                End If
            Else
                Throw New Exception("¡Seleccione una Fila!")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAgregarCon_Click(sender As Object, e As EventArgs) Handles btnAgregarCon.Click
        Try
            If cboConstantes.SelectedIndex > -1 Then
                oeConstante = New e_AporteDescuento
                oeConstante = cboConstantes.Items(cboConstantes.SelectedIndex).ListObject
                leConsAux.Add(oeConstante)
                CargarConstantes(leConsAux)
                griConstantes.DataBind()
                oeConstante.Equivale = 1
                leConsCbo.Remove(oeConstante)
                LlenarCombo(cboConstantes, "Nombre", leConsCbo, -1)
                cboConstantes.DataBind()
            Else
                Throw New Exception("¡Seleccione una Constante!")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnQuitarCon_Click(sender As Object, e As EventArgs) Handles btnQuitarCon.Click
        Try
            If griConstantes.Selected.Rows.Count > 0 Then
                oeConstante = New e_AporteDescuento
                oeConstante.Id = griConstantes.ActiveRow.Cells("Id").Value
                oeConstante.Equivale = 1
                If leConsAux.Contains(oeConstante) Then
                    oeConstante = leConsAux.Item(leConsAux.IndexOf(oeConstante))
                    leConsCbo.Add(oeConstante)
                    LlenarCombo(cboConstantes, "Nombre", leConsCbo, -1)
                    cboConstantes.DataBind()
                    leConsAux.Remove(oeConstante)
                    CargarConstantes(leConsAux)
                End If
            Else
                Throw New Exception("¡Seleccione una Fila!")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnDatos_Click(sender As Object, e As EventArgs) Handles btnDatos.Click
        If btnDatos.Text = "D<<" Then
            btnDatos.Text = "D>>"
            btnParametros.Text = "P<<"
            btnConstantes.Text = "C<<"
            btnVariables.Text = "V<<"
            btnInstrucciones.Text = " I <<"
            ficInterativo.Visible = True
            ficInterativo.Tabs(0).Visible = True
            ficInterativo.Tabs(1).Visible = False
            ficInterativo.Tabs(2).Visible = False
            ficInterativo.Tabs(3).Visible = False
            ficInterativo.Tabs(4).Visible = False
            leDatoTrabAux = DesintegraDatoTrab(txtDatosTrabajador.Text.Trim)
            CargarDatoTrab(leDatoTrabAux)
            CargarAuxDatoT()
        Else
            btnDatos.Text = "D<<"
            txtDatosTrabajador.Text = String.Empty
            txtDatosTrabajador.Text = IntegraDatoTrab(leDatoTrabAux)
            ficInterativo.Visible = False
        End If
    End Sub

    Private Sub btnAgregaDato_Click(sender As Object, e As EventArgs) Handles btnAgregaDato.Click
        Try
            If cboDatoTrabajador.SelectedIndex > -1 Then
                oeDatoTrab = New e_ConfiguracionColumna
                oeDatoTrab = cboDatoTrabajador.Items(cboDatoTrabajador.SelectedIndex).ListObject
                leDatoTrabAux.Add(oeDatoTrab)
                CargarDatoTrab(leDatoTrabAux)
                griDatoTrabajador.DataBind()
                oeDatoTrab.Equivale = 1
                leDatoTrabCbo.Remove(oeDatoTrab)
                LlenarCombo(cboDatoTrabajador, "Nombre", leDatoTrabCbo, -1)
                cboDatoTrabajador.DataBind()
            Else
                Throw New Exception("¡Seleccione un Parametro!")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnQuitaDato_Click(sender As Object, e As EventArgs) Handles btnQuitaDato.Click
        Try
            If griDatoTrabajador.Selected.Rows.Count > 0 Then
                oeDatoTrab = New e_ConfiguracionColumna
                oeDatoTrab.Id = griDatoTrabajador.ActiveRow.Cells("Id").Value
                oeDatoTrab.Equivale = 1
                If leDatoTrabAux.Contains(oeDatoTrab) Then
                    oeDatoTrab = leDatoTrabAux.Item(leDatoTrabAux.IndexOf(oeDatoTrab))
                    leDatoTrabCbo.Add(oeDatoTrab)
                    LlenarCombo(cboDatoTrabajador, "Nombre", leDatoTrabCbo, -1)
                    cboDatoTrabajador.DataBind()
                    leDatoTrabAux.Remove(oeDatoTrab)
                    CargarDatoTrab(leDatoTrabAux)
                End If
            Else
                Throw New Exception("¡Seleccione una Fila!")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtDatosTrabajador_ValueChanged(sender As Object, e As EventArgs) Handles txtDatosTrabajador.ValueChanged
        oeFormula.DatoTrabajador = txtDatosTrabajador.Text.Trim
    End Sub

    Private Sub mnuMantFormula_ToolClick(sender As Object, e As UltraWinToolbars.ToolClickEventArgs) Handles mnuMantFormula.ToolClick
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

    Private Sub btnVariables_Click(sender As Object, e As EventArgs) Handles btnVariables.Click
        If btnVariables.Text = "V<<" Then
            btnVariables.Text = "V>>"
            btnDatos.Text = "D<<"
            btnConstantes.Text = "C<<"
            btnParametros.Text = "P<<"
            btnInstrucciones.Text = " I <<"
            ficInterativo.Visible = True
            ficInterativo.Tabs(0).Visible = False
            ficInterativo.Tabs(1).Visible = False
            ficInterativo.Tabs(2).Visible = False
            ficInterativo.Tabs(3).Visible = True
            ficInterativo.Tabs(4).Visible = False
            dtVariable = DesintegraVariable(txtVariables.Text.Trim)
            CargarVariable(dtVariable)
        Else
            btnVariables.Text = "V<<"
            txtVariables.Text = String.Empty
            txtVariables.Text = IntegraVariable(dtVariable)
            ficInterativo.Visible = False
        End If
    End Sub

    Private Sub btnAgregarVar_Click(sender As Object, e As EventArgs) Handles btnAgregarVar.Click
        Try
            If txtNomVariable.Text.Trim <> "" Then
                Dim rwVar As Data.DataRow
                rwVar = dtVariable.NewRow
                rwVar.Item("Id") = dtVariable.Rows.Count + 1
                rwVar.Item("Seleccion") = False
                rwVar.Item("Nombre") = txtNomVariable.Text.Trim
                dtVariable.Rows.Add(rwVar)
                CargarVariable(dtVariable)
                txtNomVariable.Text = String.Empty
            Else
                Throw New Exception("¡Ingrese Variable!")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnQuitarVar_Click(sender As Object, e As EventArgs) Handles btnQuitarVar.Click
        Try
            If griVariables.Selected.Rows.Count > 0 Then
                Dim idRem As String = griVariables.ActiveRow.Cells("Id").Value
                Dim rw = dtVariable.Select("Id = " & idRem)
                If rw.Length > 0 Then
                    dtVariable.Rows.Remove(rw(0))
                End If
                CargarVariable(dtVariable)
            Else
                Throw New Exception("¡Seleccione una Variable!")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtVariables_ValueChanged(sender As Object, e As EventArgs) Handles txtVariables.ValueChanged
        oeFormula.Variables = txtVariables.Text.Trim
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombos()
        Try
            oeConstante = New e_AporteDescuento
            oeConstante.TipoOperacion = ""
            oeConstante.Activo = True
            oeConstante.AporteDescuento = 2
            leConstante = olConstante.Listar(oeConstante)
            ' LlenarCombo(cboParametros, "Nombre", leParametro, -1)

            oeParametro = New e_AporteDescuento
            oeParametro.TipoOperacion = ""
            oeParametro.Activo = True
            oeParametro.AporteDescuento = 1
            leParametro = olParametro.Listar(oeParametro)

            Dim _leDTAux As New List(Of e_ConfiguracionColumna)
            oeConfTabla = New e_ConfiguracionTabla
            oeConfTabla.TipoOperacion = ""
            oeConfTabla.Nombre = "ISL1_Datos_Trabajador"
            oeConfTabla = olConfTabla.Obtener(oeConfTabla)
            _leDTAux = oeConfTabla.leColumna
            leDatoTrab = _leDTAux.Where(Function(it) it.Nombre <> "IDTRAB").ToList


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar()
        Try
            oeFormula = New e_Formula
            oeFormula.TipoOperacion = ""
            oeFormula.Activo = True
            leFormula = olFormula.Listar(oeFormula)
            CargarFormula(leFormula)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarFormula(leFor As List(Of e_Formula))
        Try
            With griFormula

                .ResetDisplayLayout()
                .DataSource = leFor

                OcultarColumna(griFormula, True, "Id", "FechaCreacion", "UsuarioCreacion", "Activo", "Nombre", _
                               "DatoTrabajador", "Parametros", "Constantes", "Variables", "Instrucciones", "Descripcion")

                ExcluirColumna(griFormula, "Id", "FechaCreacion", "UsuarioCreacion", "Activo")

                .DisplayLayout.Bands(0).Columns("Codigo").Width = 80
                .DisplayLayout.Bands(0).Columns("Esquema").Width = 850

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

    Private Sub Inicializa()
        txtCodigo.Text = String.Empty
        txtNombre.Text = String.Empty
        txtDatosTrabajador.Text = String.Empty
        txtParametros.Text = String.Empty
        txtConstantes.Text = String.Empty
        txtInstrucciones.Text = String.Empty
        txtDescripcion.Text = String.Empty
        txtCodigo.ReadOnly = True
        btnDatos.Text = "D<<"
        btnParametros.Text = "P<<"
        btnConstantes.Text = "C<<"
        btnVariables.Text = "V<<"
        btnInstrucciones.Text = " I <<"
        ficInterativo.Visible = False
        If dtVariable.Rows.Count > 0 Then dtVariable.Rows.Clear()
        leDatoTrabAux = New List(Of e_ConfiguracionColumna)
        CargarDatoTrab(leDatoTrabAux)
        leParamAux = New List(Of e_AporteDescuento)
        CargarParametro(leParamAux)
        leConsAux = New List(Of e_AporteDescuento)
        CargarConstantes(leConsAux)
    End Sub

    Private Sub Mostrar()
        Try
            If bandcargar Then
                oeFormula = New e_Formula
                oeFormula.TipoOperacion = ""
                oeFormula.Id = griFormula.ActiveRow.Cells("Id").Value
                oeFormula = olFormula.Obtener(oeFormula)
            End If
            CargarDatos(oeFormula)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function fn_ObtenerCodigo() As String
        Try
            Dim _oeForAux As New e_Formula
            Dim strCodigo As String = ""
            _oeForAux.TipoOperacion = "U"
            _oeForAux = olFormula.Obtener(_oeForAux)
            If _oeForAux IsNot Nothing AndAlso _oeForAux.Codigo <> "" Then
                strCodigo = _oeForAux.Codigo
            End If
            Return strCodigo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CrearDT() As System.Data.DataTable
        Dim dt As New Data.DataTable
        With dt
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.Int32")))
            .Columns.Add(New Data.DataColumn("Seleccion", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("Nombre", Type.GetType("System.String")))
        End With
        Return dt
    End Function

    Private Sub CargarVariable(dtVar As Data.DataTable)
        Try
            With griVariables

                .ResetDisplayLayout()
                .DataSource = dtVar

                .DisplayLayout.CaptionVisible = DefaultableBoolean.False

                OcultarColumna(griVariables, True, "Id", "Seleccion")

                .DisplayLayout.Bands(0).Columns("Nombre").Width = 200

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

    Private Sub CargarParametro(leParam As List(Of e_AporteDescuento))
        Try
            With griParametros

                .ResetDisplayLayout()
                .DataSource = leParam

                .DisplayLayout.CaptionVisible = DefaultableBoolean.False

                For Each col In .DisplayLayout.Bands(0).Columns
                    If col.Key <> "Nombre" AndAlso col.Key <> "Abreviatura" Then col.Hidden = True
                Next

                .DisplayLayout.Bands(0).Columns("Nombre").Width = 250
                .DisplayLayout.Bands(0).Columns("Abreviatura").Width = 100

                .DisplayLayout.Bands(0).Columns("Nombre").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("Abreviatura").Header.VisiblePosition = 1

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

    Private Function IntegraVariable(dtVar As Data.DataTable) As String
        Dim strIntegra As String = ""
        If dtVar.Rows.Count > 0 Then
            For Each rw In dtVar.Rows
                strIntegra = strIntegra & rw("Nombre").ToString & ","
            Next
            If strIntegra.Trim.Length > 0 Then strIntegra = strIntegra.Substring(0, strIntegra.Trim.Length - 1)
        End If
        Return strIntegra
    End Function

    Private Function IntegraParametro(lePar As List(Of e_AporteDescuento)) As String
        Dim strConstante As String = ""
        If lePar.Count > 0 Then
            For Each oeAux In lePar
                strConstante = strConstante & oeAux.Abreviatura & ","
            Next
            If strConstante.Trim.Length > 0 Then strConstante = strConstante.Substring(0, strConstante.Trim.Length - 1)
        End If
        Return strConstante
    End Function

    Private Function DesintegraVariable(strVar As String) As Data.DataTable
        Dim dt As Data.DataTable = CrearDT()
        If strVar.Trim.Length > 0 Then
            Dim strCad() As String
            strCad = strVar.Split(",")
            For i = 0 To strCad.Length - 1
                Dim rw As Data.DataRow
                rw = dt.NewRow
                rw("Id") = i + 1
                rw("Seleccion") = False
                rw("Nombre") = strCad(i).ToString
                dt.Rows.Add(rw)
            Next
        End If
        Return dt
    End Function

    Private Function DesintegraParametro(strPar As String) As List(Of e_AporteDescuento)
        Dim lePam As New List(Of e_AporteDescuento)
        If strPar.Trim.Length > 0 Then
            Dim strCad() As String
            strCad = strPar.Split(",")
            For i = 0 To strCad.Length - 1
                oeParametro = New e_AporteDescuento
                oeParametro.Equivale = 4
                oeParametro.Abreviatura = strCad(i)
                If leParametro.Contains(oeParametro) Then
                    oeParametro = leParametro.Item(leParametro.IndexOf(oeParametro))
                    lePam.Add(oeParametro)
                End If
            Next
        End If
        Return lePam
    End Function

    Private Function IntegraConstante(leCon As List(Of e_AporteDescuento)) As String
        Dim strConstante As String = ""
        If leCon.Count > 0 Then
            For Each oeAux In leCon
                strConstante = strConstante & oeAux.Abreviatura & ","
            Next
            If strConstante.Trim.Length > 0 Then strConstante = strConstante.Substring(0, strConstante.Trim.Length - 1)
        End If
        Return strConstante
    End Function

    Private Function DesintegraConstante(strCon As String) As List(Of e_AporteDescuento)
        Dim leCon As New List(Of e_AporteDescuento)
        If strCon.Trim.Length > 0 Then
            Dim strCad() As String
            strCad = strCon.Split(",")
            For i = 0 To strCad.Length - 1
                oeConstante = New e_AporteDescuento
                oeConstante.Equivale = 4
                oeConstante.Abreviatura = strCad(i)
                If leConstante.Contains(oeConstante) Then
                    oeConstante = leConstante.Item(leConstante.IndexOf(oeConstante))
                    leCon.Add(oeConstante)
                End If
            Next
        End If
        Return leCon
    End Function

    Private Sub CargarConstantes(leConst As List(Of e_AporteDescuento))
        Try
            With griConstantes

                .ResetDisplayLayout()
                .DataSource = leConst

                .DisplayLayout.CaptionVisible = DefaultableBoolean.False

                For Each col In .DisplayLayout.Bands(0).Columns
                    If col.Key <> "Nombre" AndAlso col.Key <> "Abreviatura" Then col.Hidden = True
                Next

                .DisplayLayout.Bands(0).Columns("Nombre").Width = 250
                .DisplayLayout.Bands(0).Columns("Abreviatura").Width = 100

                .DisplayLayout.Bands(0).Columns("Nombre").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("Abreviatura").Header.VisiblePosition = 1

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

    Private Sub CargarAuxCons()
        leConsCbo = New List(Of e_AporteDescuento)
        If leConsAux.Count > 0 Then
            For Each oeLC In leConstante
                oeLC.Equivale = 1
                If Not leConsAux.Contains(oeLC) Then
                    leConsCbo.Add(oeLC)
                End If
            Next
        Else
            leConsCbo.AddRange(leConstante)
        End If
        LlenarCombo(cboConstantes, "Nombre", leConsCbo, -1)
    End Sub

    Private Sub CargarAuxParam()
        leParamCbo = New List(Of e_AporteDescuento)
        If leParamAux.Count > 0 Then
            For Each oeLP In leParametro
                oeLP.Equivale = 1
                If Not leParamAux.Contains(oeLP) Then
                    leParamCbo.Add(oeLP)
                End If
            Next
        Else
            leParamCbo.AddRange(leParametro)
        End If
        LlenarCombo(cboParametro, "Nombre", leParamCbo, -1)
    End Sub

    Private Sub CargarDatoTrab(leDatoT As List(Of e_ConfiguracionColumna))
        Try
            With griDatoTrabajador

                .ResetDisplayLayout()
                .DataSource = leDatoT

                .DisplayLayout.CaptionVisible = DefaultableBoolean.False

                For Each col In .DisplayLayout.Bands(0).Columns
                    If col.Key = "Nombre" Or col.Key = "Descripcion" Then
                    Else
                        col.Hidden = True
                    End If
                Next

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

    Private Function IntegraDatoTrab(leDatoT As List(Of e_ConfiguracionColumna)) As String
        Dim strDato As String = ""
        If leDatoT.Count > 0 Then
            For Each oeAux In leDatoT
                strDato = strDato & oeAux.Nombre & ","
            Next
            If strDato.Trim.Length > 0 Then strDato = strDato.Substring(0, strDato.Trim.Length - 1)
        End If
        Return strDato
    End Function

    Private Function DesintegraDatoTrab(strDato As String) As List(Of e_ConfiguracionColumna)
        Dim leDT As New List(Of e_ConfiguracionColumna)
        If strDato.Trim.Length > 0 Then
            Dim strCad() As String
            strCad = strDato.Split(",")
            For i = 0 To strCad.Length - 1
                oeDatoTrab = New e_ConfiguracionColumna
                oeDatoTrab.Equivale = 3
                oeDatoTrab.Nombre = strCad(i)
                If leDatoTrab.Contains(oeDatoTrab) Then
                    oeDatoTrab = leDatoTrab.Item(leDatoTrab.IndexOf(oeDatoTrab))
                    leDT.Add(oeDatoTrab)
                End If
            Next
        End If
        Return leDT
    End Function

    Private Sub CargarAuxDatoT()
        leDatoTrabCbo = New List(Of e_ConfiguracionColumna)
        If leDatoTrabAux.Count > 0 Then
            For Each oeLDT In leDatoTrab
                oeLDT.Equivale = 1
                If Not leDatoTrabAux.Contains(oeLDT) Then
                    leDatoTrabCbo.Add(oeLDT)
                End If
            Next
        Else
            leDatoTrabCbo.AddRange(leDatoTrab)
        End If
        LlenarCombo(cboDatoTrabajador, "Nombre", leDatoTrabCbo, -1)
    End Sub

    Private Sub CargarDatos(oeForm As e_Formula)
        With oeForm
            txtCodigo.Text = .Codigo
            txtNombre.Text = .Nombre
            txtDatosTrabajador.Text = .DatoTrabajador
            txtParametros.Text = .Parametros
            txtConstantes.Text = .Constantes
            txtVariables.Text = .Variables
            txtInstrucciones.Text = .Instrucciones
            txtDescripcion.Text = .Descripcion
        End With
    End Sub

#End Region

End Class