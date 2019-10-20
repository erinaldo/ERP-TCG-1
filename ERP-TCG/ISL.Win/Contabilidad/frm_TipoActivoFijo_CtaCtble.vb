'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF
Imports System.Text

Public Class frm_TipoActivoFijo_CtaCtble
    Inherits frm_MenuPadre

#Region "Instancia"

    Private Shared instancia As frm_TipoActivoFijo_CtaCtble = Nothing
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_TipoActivoFijo_CtaCtble
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Variables"

    Private Operacion As String = String.Empty
    Private oeTipoActivoFijo_CtaCtble As e_TipoActivoFijo_CtaCtble
    Private loTipoActivoFijo_CtaCtble As New List(Of e_TipoActivoFijo_CtaCtble)
    Private olTipoActivoFijo_CtaCtble As New l_TipoActivoFijo_CtaCtble
    Private cadValidacion As StringBuilder
    Private FechaActual As Date
    Private oeCombo As e_Combo
    Private lstCombo As List(Of e_Combo)
    Private olCombo As New l_Combo
    Private oeDetConPond As e_DetalleConceptoPonderado, olDetConPond As l_DetalleConceptoPonderado, leDetConPond As List(Of e_DetalleConceptoPonderado)

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(Activo As Boolean)
        Try
            Operacion = String.Empty
            mt_Listar()
            mt_ControlBotoneria()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            mt_InicializarControles()
            oeTipoActivoFijo_CtaCtble = New e_TipoActivoFijo_CtaCtble
            Operacion = "Nuevo"
            MostrarTabs(1, utcTipoActivoCtaCtble, 1)
            mt_ControlBotoneria()
            cboTipoAF.Focus()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            If gf_ValidarFilaSeleccionada(griTipoActivoFijo_CtaCtble) Then
                mt_Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If gf_ValidarFilaSeleccionada(griTipoActivoFijo_CtaCtble) AndAlso _
               fc_ValidarEliminar() AndAlso _
               MessageBox.Show("Desea eliminar el registro seleccionado?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                oeTipoActivoFijo_CtaCtble = New e_TipoActivoFijo_CtaCtble
                oeTipoActivoFijo_CtaCtble.Id = griTipoActivoFijo_CtaCtble.ActiveRow.Cells("Id").Value.ToString().Trim()
                olTipoActivoFijo_CtaCtble.Obtener(oeTipoActivoFijo_CtaCtble)
                If olTipoActivoFijo_CtaCtble.Eliminar(oeTipoActivoFijo_CtaCtble) Then
                    MessageBox.Show("Registro eliminado satisfactoriamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loTipoActivoFijo_CtaCtble.Remove(griTipoActivoFijo_CtaCtble.ActiveRow.ListObject)
                    griTipoActivoFijo_CtaCtble.DataBind()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If fc_ValidarRegistrar() Then
                mt_RecolectarDatos()
                oeTipoActivoFijo_CtaCtble.PrefijoID = gs_PrefijoIdSucursal '@0001
                If olTipoActivoFijo_CtaCtble.Guardar(oeTipoActivoFijo_CtaCtble) Then
                    MessageBox.Show("Registro guardado satisfactoriamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MostrarTabs(0, utcTipoActivoCtaCtble, 0)
                    Consultar(True)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If MessageBox.Show("Desea cancelar la operacion?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                MostrarTabs(0, utcTipoActivoCtaCtble, 0)
                mt_ControlBotoneria()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            ExportarGrillaAExcel(griTipoActivoFijo_CtaCtble, Me.Text)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mt_InicializarFormulario()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Try
            mt_ControlBotoneria()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            instancia = Nothing
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            ControlBoton()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griTipoActivoFijo_CtaCtble_DoubleClickRow(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles griTipoActivoFijo_CtaCtble.DoubleClickRow
        Try
            If e.Row.Index >= 0 Then
                Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_TipoActivoFijo_CtaCtble_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case utcTipoActivoCtaCtble.SelectedTab.Index
                Case utpMantenimiento.Tab.Index
                    Select Case e.KeyCode
                        Case Keys.Enter
                            SendKeys.Send("{TAB}")
                    End Select
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Año_Validated(sender As Object, e As EventArgs) Handles Año.Validated
        Try
            comboCuentallena(Año.Año)
            LlenarComboMaestro(cbgCtaCompraD, lstCombo.Where(Function(Item) Microsoft.VisualBasic.Left(Item.Nombre, 1) = "3").ToList, 1)
            LlenarComboMaestro(cbgCtaCompraH, lstCombo.Where(Function(Item) Microsoft.VisualBasic.Left(Item.Nombre, 2) = "33").ToList, 1)
            LlenarComboMaestro(cbgCtaRevalorizacionD, lstCombo.ToList, 1)
            LlenarComboMaestro(cbgCtaRevalorizacionH, lstCombo.ToList, 1)
            LlenarComboMaestro(cbgCtaDepreciacionD, lstCombo.Where(Function(Item) Microsoft.VisualBasic.Left(Item.Nombre, 2) = "68").ToList, 1)
            LlenarComboMaestro(cbgCtaDepreciacionH, lstCombo.Where(Function(Item) Microsoft.VisualBasic.Left(Item.Nombre, 2) = "39").ToList, 1)
            LlenarComboMaestro(cbgCtaReadecuacionD, lstCombo.Where(Function(Item) Microsoft.VisualBasic.Left(Item.Nombre, 1) = "3").ToList, 1)
            LlenarComboMaestro(cbgCtaReadecuacionH, lstCombo.Where(Function(Item) Microsoft.VisualBasic.Left(Item.Nombre, 1) = "3").ToList, 1)
            LlenarComboMaestro(cbgCtaDesactivacionD, lstCombo.Where(Function(Item) Microsoft.VisualBasic.Left(Item.Nombre, 3) = "655").ToList, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cbgCtaCompraD_ValueChanged(sender As Object, e As EventArgs) Handles cbgCtaCompraD.ValueChanged
        Try
            If cbgCtaCompraD.SelectedRow IsNot Nothing AndAlso lstCombo.Where(Function(item) item.Id = cbgCtaCompraD.Value).Count > 0 Then
                txtCtaCompraD.Text = lstCombo.Where(Function(item) item.Id = cbgCtaCompraD.Value)(0).Descripcion
            Else
                txtCtaCompraD.Text = String.Empty
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cbgCtaCompraH_ValueChanged(sender As Object, e As EventArgs) Handles cbgCtaCompraH.ValueChanged
        Try
            If cbgCtaCompraH.SelectedRow IsNot Nothing AndAlso lstCombo.Where(Function(item) item.Id = cbgCtaCompraH.Value).Count > 0 Then
                txtCtaCompraH.Text = lstCombo.Where(Function(item) item.Id = cbgCtaCompraH.Value)(0).Descripcion
            Else
                txtCtaCompraH.Text = String.Empty
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cbgCtaRevalorizacionD_ValueChanged(sender As Object, e As EventArgs) Handles cbgCtaRevalorizacionD.ValueChanged
        Try
            If cbgCtaRevalorizacionD.SelectedRow IsNot Nothing AndAlso lstCombo.Where(Function(item) item.Id = cbgCtaRevalorizacionD.Value).Count > 0 Then
                txtCtaRevalorizacionD.Text = lstCombo.Where(Function(item) item.Id = cbgCtaRevalorizacionD.Value)(0).Descripcion
            Else
                txtCtaRevalorizacionD.Text = String.Empty
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cbgCtaRevalorizacionH_ValueChanged(sender As Object, e As EventArgs) Handles cbgCtaRevalorizacionH.ValueChanged
        Try
            If cbgCtaRevalorizacionH.SelectedRow IsNot Nothing AndAlso lstCombo.Where(Function(item) item.Id = cbgCtaRevalorizacionH.Value).Count > 0 Then
                txtCtaRevalorizacionH.Text = lstCombo.Where(Function(item) item.Id = cbgCtaRevalorizacionH.Value)(0).Descripcion
            Else
                txtCtaRevalorizacionH.Text = String.Empty
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cbgCtaDepreciacionD_ValueChanged(sender As Object, e As EventArgs) Handles cbgCtaDepreciacionD.ValueChanged
        Try
            If cbgCtaDepreciacionD.SelectedRow IsNot Nothing AndAlso lstCombo.Where(Function(item) item.Id = cbgCtaDepreciacionD.Value).Count > 0 Then
                txtCtaDepreciacionD.Text = lstCombo.Where(Function(item) item.Id = cbgCtaDepreciacionD.Value)(0).Descripcion
            Else
                txtCtaDepreciacionD.Text = String.Empty
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cbgCtaDepreciacionH_ValueChanged(sender As Object, e As EventArgs) Handles cbgCtaDepreciacionH.ValueChanged
        Try
            If cbgCtaDepreciacionH.SelectedRow IsNot Nothing AndAlso lstCombo.Where(Function(item) item.Id = cbgCtaDepreciacionH.Value).Count > 0 Then
                txtCtaDepreciacionH.Text = lstCombo.Where(Function(item) item.Id = cbgCtaDepreciacionH.Value)(0).Descripcion
            Else
                txtCtaDepreciacionH.Text = String.Empty
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cbgCtaReadecuacionD_ValueChanged(sender As Object, e As EventArgs) Handles cbgCtaReadecuacionD.ValueChanged
        Try
            If cbgCtaReadecuacionD.SelectedRow IsNot Nothing AndAlso lstCombo.Where(Function(item) item.Id = cbgCtaReadecuacionD.Value).Count > 0 Then
                txtCtaReadecuacionD.Text = lstCombo.Where(Function(item) item.Id = cbgCtaReadecuacionD.Value)(0).Descripcion
            Else
                txtCtaReadecuacionD.Text = String.Empty
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cbgCtaReadecuacionH_ValueChanged(sender As Object, e As EventArgs) Handles cbgCtaReadecuacionH.ValueChanged
        Try
            If cbgCtaReadecuacionH.SelectedRow IsNot Nothing AndAlso lstCombo.Where(Function(item) item.Id = cbgCtaReadecuacionH.Value).Count > 0 Then
                txtCtaReadecuacionH.Text = lstCombo.Where(Function(item) item.Id = cbgCtaReadecuacionH.Value)(0).Descripcion
            Else
                txtCtaReadecuacionH.Text = String.Empty
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cbgCtaCompraD_InitializeLayout(sender As Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cbgCtaCompraD.InitializeLayout, cbgCtaCompraH.InitializeLayout, cbgCtaDepreciacionD.InitializeLayout, _
                cbgCtaDepreciacionH.InitializeLayout, cbgCtaReadecuacionD.InitializeLayout, cbgCtaReadecuacionH.InitializeLayout, _
                cbgCtaRevalorizacionD.InitializeLayout, cbgCtaRevalorizacionH.InitializeLayout, cbgCtaDesactivacionD.InitializeLayout
        Try
            With CType(sender, Infragistics.Win.UltraWinGrid.UltraCombo).DisplayLayout.Bands(0)
                .Columns("Id").Hidden = True
                .Columns("Nombre").Hidden = False
                .Columns("Nombre").Header.Caption = "Cuenta"
                .Columns("Nombre").Width = 50
                .Columns("Descripcion").Hidden = False
                .Columns("Descripcion").Width = 400
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cbgCtaDesactivacionD_ValueChanged(sender As Object, e As EventArgs) Handles cbgCtaDesactivacionD.ValueChanged
        Try
            If cbgCtaDesactivacionD.SelectedRow IsNot Nothing AndAlso lstCombo.Where(Function(item) item.Id = cbgCtaDesactivacionD.Value).Count > 0 Then
                txtCtaDesactivacionD.Text = lstCombo.Where(Function(item) item.Id = cbgCtaDesactivacionD.Value)(0).Descripcion
            Else
                txtCtaDesactivacionD.Text = String.Empty
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTipoAF_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoAF.ValueChanged
        Try
            'SubTipo
            If cboTipoAF.SelectedIndex > -1 Then
                oeCombo = New e_Combo
                oeCombo.Id = cboTipoAF.Value
                oeCombo.Nombre = "TablaContableDetalle"
                LlenarComboMaestro(cboSubtipoAF, olCombo.Listar(oeCombo), -1)
            Else
                LlenarComboMaestro(cboSubtipoAF, New List(Of e_Combo), -1)
            End If
            'If cboTipoAF.SelectedIndex >= 0 Then
            '    oeCombo = New e_Combo
            '    oeCombo.Id = cboTipoAF.Value
            '    oeCombo.Nombre = "TablaContableDetalle"
            '    cboSubtipoAF.DataSource = olCombo.Listar(oeCombo)
            'End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtCtaDepreciacionD_ValueChanged(sender As Object, e As EventArgs) Handles txtCtaDepreciacionD.ValueChanged
        Try
            If txtCtaDepreciacionD.Text.Trim.Length > 0 Then
                cboDepreciacion.Enabled = True
                LlenarCombo(cboDepreciacion, "Nombre", leDetConPond, -1)
            Else
                cboDepreciacion.Enabled = False
                LlenarCombo(cboDepreciacion, "Nombre", New List(Of e_DetalleConceptoPonderado), -1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboDepreciacion_ValueChanged(sender As Object, e As EventArgs) Handles cboDepreciacion.ValueChanged
        Try
            If cboDepreciacion.SelectedIndex > -1 Then
                oeDetConPond = cboDepreciacion.SelectedItem.ListObject
                numPorcentaje.Value = oeDetConPond.Porcentaje
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub mt_InicializarControles()
        Try
            cboTipoAF.SelectedIndex = -1
            cboTipoAF.Text = String.Empty
            cboSubtipoAF.SelectedIndex = -1
            cboSubtipoAF.Text = String.Empty
            cbgCtaCompraD.Value = String.Empty
            cbgCtaCompraD.Text = String.Empty
            txtCtaCompraD.Text = String.Empty
            cbgCtaCompraH.Value = String.Empty
            cbgCtaCompraH.Text = String.Empty
            txtCtaCompraH.Text = String.Empty
            cbgCtaDepreciacionD.Value = String.Empty
            cbgCtaDepreciacionD.Text = String.Empty
            txtCtaDepreciacionD.Text = String.Empty
            cbgCtaDepreciacionH.Value = String.Empty
            cbgCtaDepreciacionH.Text = String.Empty
            txtCtaDepreciacionH.Text = String.Empty
            cbgCtaRevalorizacionD.Value = String.Empty
            cbgCtaRevalorizacionD.Text = String.Empty
            txtCtaRevalorizacionD.Text = String.Empty
            cbgCtaRevalorizacionH.Value = String.Empty
            cbgCtaRevalorizacionH.Text = String.Empty
            txtCtaRevalorizacionH.Text = String.Empty
            cbgCtaReadecuacionD.Value = String.Empty
            cbgCtaReadecuacionD.Text = String.Empty
            txtCtaReadecuacionD.Text = String.Empty
            cbgCtaReadecuacionH.Value = String.Empty
            cbgCtaReadecuacionH.Text = String.Empty
            txtCtaReadecuacionH.Text = String.Empty
            cbgCtaDesactivacionD.Value = String.Empty
            cbgCtaDesactivacionD.Text = String.Empty
            txtCtaDesactivacionD.Text = String.Empty
            cboGastoFuncion.SelectedIndex = -1
            Año.Enabled = True
            cboTipoAF.Enabled = True
            cboSubtipoAF.Enabled = True
            Año.Año = FechaActual.Year
            Año_Validated(Nothing, Nothing)
            cboDepreciacion.SelectedIndex = -1
            numPorcentaje.Value = 0
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Listar()
        Try
            oeTipoActivoFijo_CtaCtble = New e_TipoActivoFijo_CtaCtble
            With oeTipoActivoFijo_CtaCtble
                .TipoOperacion = String.Empty
                .Ejercicio = AñoListado.Año
            End With
            loTipoActivoFijo_CtaCtble.Clear()
            loTipoActivoFijo_CtaCtble.AddRange(olTipoActivoFijo_CtaCtble.Listar(oeTipoActivoFijo_CtaCtble))
            griTipoActivoFijo_CtaCtble.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_InicializarFormulario()
        Try
            FechaActual = ObtenerFechaServidor()
            gf_AsignarEventoSeleccionarTexto(Me)
            mt_LlenarCombos()
            utcTipoActivoCtaCtble.Tabs(utpMantenimiento.Tab.Index).Enabled = False
            griTipoActivoFijo_CtaCtble.DataSource = loTipoActivoFijo_CtaCtble
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_LlenarCombos()
        Try
            AñoListado.Año = FechaActual.Year
            'Grupo ActivoFijo
            oeCombo = New e_Combo
            oeCombo.Id = "Activo Fijo"
            oeCombo.Nombre = "TIPO AF"
            LlenarComboMaestro(cboTipoAF, olCombo.Listar(oeCombo).OrderBy(Function(x) x.Nombre).ToList(), 0)
            'Gasto Función
            oeCombo = New e_Combo
            oeCombo.Nombre = "GASTO FUNCION"
            lstCombo = New List(Of e_Combo)
            lstCombo.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(x) x.Nombre).ToList())
            cboGastoFuncion.DataSource = lstCombo
            'Combo Grilla Listado
            CrearComboGrid("IdGastoFuncion", "Nombre", griTipoActivoFijo_CtaCtble, olCombo.ComboGrilla(lstCombo), False)
            ' Detalle Concepto Ponderado - Depreciacion
            olDetConPond = New l_DetalleConceptoPonderado
            oeDetConPond = New e_DetalleConceptoPonderado
            leDetConPond = New List(Of e_DetalleConceptoPonderado)
            oeDetConPond.TipoOperacion = "D" : oeDetConPond.IdConceptoPonderado = "CP002"
            leDetConPond = olDetConPond.Listar(oeDetConPond)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_ControlBotoneria()
        Try
            Select Case utcTipoActivoCtaCtble.SelectedTab.Index
                Case utpListado.Tab.Index
                    If griTipoActivoFijo_CtaCtble.Rows.Count > 0 Then
                        ControlBoton(1, 1, 1, 0, 0, 1, 0, 1)
                    Else
                        ControlBoton(1, 1)
                    End If
                Case utpMantenimiento.Tab.Index
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Editar()
        Try
            Operacion = "Editar"
            mt_InicializarControles()
            Año.Enabled = False
            cboTipoAF.Enabled = False
            cboSubtipoAF.Enabled = False
            oeTipoActivoFijo_CtaCtble = New e_TipoActivoFijo_CtaCtble
            oeTipoActivoFijo_CtaCtble.TipoActivoFijo = "EDT"
            oeTipoActivoFijo_CtaCtble.Id = griTipoActivoFijo_CtaCtble.ActiveRow.Cells("Id").Value.ToString()
            oeTipoActivoFijo_CtaCtble = olTipoActivoFijo_CtaCtble.Obtener(oeTipoActivoFijo_CtaCtble)
            mt_CargarTipoAFCtaCtble()
            MostrarTabs(1, utcTipoActivoCtaCtble, 1)
            mt_ControlBotoneria()
            'Foco Primer Control
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarTipoAFCtaCtble()
        Try
            With oeTipoActivoFijo_CtaCtble
                Año.Año = .Ejercicio
                Año_Validated(Nothing, Nothing)
                cboTipoAF.Value = .IdCtaCtbleReadecuacionD
                cboSubtipoAF.Value = .IdTipoActivoFijo
                cbgCtaCompraD.Value = .IdCtaCtbleCompraD
                cbgCtaCompraH.Value = .IdCtaCtbleCompraH
                cbgCtaDepreciacionD.Value = .IdCtaCtbleDeprecD
                cbgCtaDepreciacionH.Value = .IdCtaCtbleDeprecH
                cbgCtaRevalorizacionD.Value = .IdCtaCtbleRevalorizacionD
                cbgCtaRevalorizacionH.Value = .IdCtaCtbleRevalorizacionH
                'cbgCtaReadecuacionD.Value = .IdCtaCtbleReadecuacionD
                'cbgCtaReadecuacionH.Value = .IdCtaCtbleReadecuacionH
                cbgCtaDesactivacionD.Value = .IdCtaCtbleBajaD
                cboGastoFuncion.Value = .IdGastoFuncion
                cboDepreciacion.Value = .IdDetConPond
                numPorcentaje.Value = .Porcentaje
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_RecolectarDatos()
        Try
            With oeTipoActivoFijo_CtaCtble
                .TipoOperacion = "I"
                .IdTipoActivoFijo = If(cboSubtipoAF.Value Is Nothing, String.Empty, cboSubtipoAF.Value)
                .IdCtaCtbleReadecuacionD = If(cboTipoAF.Value Is Nothing, String.Empty, cboTipoAF.Value)
                .IdCtaCtbleCompraD = If(cbgCtaCompraD.Value Is Nothing, String.Empty, cbgCtaCompraD.Value)
                .IdCtaCtbleCompraH = If(cbgCtaCompraH.Value Is Nothing, String.Empty, cbgCtaCompraH.Value)
                .IdCtaCtbleDeprecD = If(cbgCtaDepreciacionD.Value Is Nothing, String.Empty, cbgCtaDepreciacionD.Value)
                .IdCtaCtbleDeprecH = If(cbgCtaDepreciacionH.Value Is Nothing, String.Empty, cbgCtaDepreciacionH.Value)
                .IdCtaCtbleRevalorizacionD = If(cbgCtaRevalorizacionD.Value Is Nothing, String.Empty, cbgCtaRevalorizacionD.Value)
                .IdCtaCtbleRevalorizacionH = If(cbgCtaRevalorizacionH.Value Is Nothing, String.Empty, cbgCtaRevalorizacionH.Value)
                .IdCtaCtbleBajaD = If(cbgCtaDesactivacionD.Value Is Nothing, String.Empty, cbgCtaDesactivacionD.Value)
                .IdGastoFuncion = If(cboGastoFuncion.Value Is Nothing, String.Empty, cboGastoFuncion.Value)
                .IdDetConPond = IIf(cboDepreciacion.SelectedIndex > -1, cboDepreciacion.Value, String.Empty)
                .Porcentaje = numPorcentaje.Value
                .Ejercicio = Año.Año
                .UsuarioCreacion = gUsuarioSGI.Id
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub comboCuentallena(año As String)
        Try
            oeCombo = New e_Combo
            oeCombo.Id = año
            oeCombo.Nombre = "CuentaContable"
            lstCombo = New List(Of e_Combo)
            lstCombo.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Funciones"

    Private Function fc_ValidarRegistrar() As Boolean
        Try
            cadValidacion = New StringBuilder
            Dim control As Control = Nothing
            If cboTipoAF.SelectedIndex < 0 Then
                cadValidacion.Append("Ingrese Tipo Activo Fijo").AppendLine()
                If control Is Nothing Then
                    control = cboTipoAF
                End If
            End If
            If cboSubtipoAF.SelectedIndex < 0 Then
                cadValidacion.Append("Ingrese Subtipo Activo Fijo").AppendLine()
                If control Is Nothing Then
                    control = cboSubtipoAF
                End If
            End If
            If cbgCtaCompraD.SelectedRow Is Nothing Then
                cadValidacion.Append("Ingrese Cta Compra (Debe)").AppendLine()
                If control Is Nothing Then
                    control = cbgCtaCompraD
                End If
            End If
            'If cbgCtaCompraH.SelectedRow Is Nothing Then
            '    cadValidacion.Append("Ingrese Cta Compra (Haber)").AppendLine()
            '    If control Is Nothing Then
            '        control = cbgCtaCompraH
            '    End If
            'End If
            'If cbgCtaRevalorizacionD.SelectedRow Is Nothing Then
            '    cadValidacion.Append("Ingrese Cta Reclasificacion (Debe)").AppendLine()
            '    If control Is Nothing Then
            '        control = cbgCtaRevalorizacionD
            '    End If
            'End If
            'If cbgCtaRevalorizacionH.SelectedRow Is Nothing Then
            '    cadValidacion.Append("Ingrese Cta Reclasificacion (Haber)").AppendLine()
            '    If control Is Nothing Then
            '        control = cbgCtaRevalorizacionH
            '    End If
            'End If
            If cbgCtaDepreciacionD.SelectedRow Is Nothing Then
                cadValidacion.Append("Ingrese Cta Depreciación (Debe)").AppendLine()
                If control Is Nothing Then
                    control = cbgCtaDepreciacionD
                End If
            End If
            If cbgCtaDepreciacionH.SelectedRow Is Nothing Then
                cadValidacion.Append("Ingrese Cta Depreciación (Haber)").AppendLine()
                If control Is Nothing Then
                    control = cbgCtaDepreciacionH
                End If
            End If
            'If cbgCtaReadecuacionD.SelectedRow Is Nothing Then
            '    cadValidacion.Append("Ingrese Cta Readecuación (Debe)").AppendLine()
            '    If control Is Nothing Then
            '        control = cbgCtaReadecuacionD
            '    End If
            'End If
            'If cbgCtaReadecuacionH.SelectedRow Is Nothing Then
            '    cadValidacion.Append("Ingrese Cta Readecuación (Haber)").AppendLine()
            '    If control Is Nothing Then
            '        control = cbgCtaReadecuacionH
            '    End If
            'End If
            If cbgCtaDesactivacionD.SelectedRow Is Nothing Then
                cadValidacion.Append("Ingrese Cta Desactivación (Debe)").AppendLine()
                If control Is Nothing Then
                    control = cbgCtaDesactivacionD
                End If
            End If
            If cboGastoFuncion.SelectedIndex < 0 Then
                cadValidacion.Append("Ingrese Gasto Función").AppendLine()
                If control Is Nothing Then
                    control = cboGastoFuncion
                End If
            End If
            If Not String.IsNullOrWhiteSpace(cadValidacion.ToString()) Then
                MessageBox.Show(cadValidacion.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                control.Focus()
                Return False
            End If
            'Validar que no registren Tipo Activo Fijo en el mismo ejercicio
            Dim lstTipoActivoFijo As New List(Of e_TipoActivoFijo_CtaCtble)
            Dim oeTipoActivoFijo As New e_TipoActivoFijo_CtaCtble
            oeTipoActivoFijo.TipoOperacion = "EDT"
            oeTipoActivoFijo.Ejercicio = Año.Año
            oeTipoActivoFijo.IdTipoActivoFijo = cboSubtipoAF.Value
            lstTipoActivoFijo.AddRange(olTipoActivoFijo_CtaCtble.Listar(oeTipoActivoFijo))
            If lstTipoActivoFijo.Where(Function(x) x.Id <> oeTipoActivoFijo_CtaCtble.Id).Count > 0 Then
                MessageBox.Show("Ya existe una configuración para el Subtipo de activo fijo:" & Environment.NewLine & _
                                cboSubtipoAF.Text.Trim() & " en el ejercicio " & Año.Año.ToString() & ". Verificar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Año.Focus()
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fc_ValidarEliminar() As Boolean
        Try
            'Validar Claves Foráneas
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

End Class