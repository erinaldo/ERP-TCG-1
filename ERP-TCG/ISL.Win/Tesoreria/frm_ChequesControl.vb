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

Public Class frm_ChequesControl
    Inherits frm_MenuPadre

#Region "Inicializacion"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ChequesControl = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ChequesControl()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    'Declaración de instancia para el control de modificaciones de la entidad en el formulario
    Private WithEvents oeChequesControl As New e_ChequesControl
    Private olChequesControl As New l_ChequesControl
    Private loChequesControl As New List(Of e_ChequesControl)

    Dim oeChequesTalonarios As New e_ChequesTalonarios
    Dim olChequesTalonarios As New l_ChequesTalonarios
    Dim loChequesTalonarios As New List(Of e_ChequesTalonarios)

    Dim oeCuentaBancaria As New e_CuentaBancaria
    Dim olCuentaBancaria As New l_CuentaBancaria
    Private loCuentaBancaria As New List(Of e_CuentaBancaria)

    Private oeCombo As New e_Combo
    Private olCombo As New l_Combo

    Dim _ingresando_datos As Boolean = False

    Private oeCaja As New e_Caja
    Private olCaja As New l_Caja
    Private loCaja As New List(Of e_Caja)

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Tiempo1.Enabled = True
            Listar(Activo)
            If griLista.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 0, 0, 1)
                griLista.Rows.Item(0).Selected = True
                griLista.Rows(0).Activated = True
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            Operacion = "Nuevo"
            Inicializar()
            oeChequesControl.TipoOperacion = "I"
            MostrarTabs(1, ficControlCheques, 1)
            Me.cboCuentaBancaria.Focus()
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Inicializar()
            If EditarControlCheques() Then
                Operacion = "Editar"
                MostrarTabs(1, ficControlCheques, 1)
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarControlCheques() Then
                Consultar(True)
            Else
                MostrarTabs(1, ficControlCheques, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            MostrarTabs(0, ficControlCheques)
            _ingresando_datos = False
            Consultar(True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    Public Overrides Sub Eliminar()
        EliminarTalonario()
    End Sub

    Public Overrides Sub Exportar()
        Try
            If griLista.Rows.Count = 0 Then Throw New Exception("No hay ninguna dato para exportar al Excel")
            Exportar_Excel(griLista)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ChequesTalonarios_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case ficControlCheques.SelectedTab.Index
            Case 0
                If griLista.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 0, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        End Select
    End Sub

    Private Sub frm_ChequesTalonarios_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ChequesTalonarios_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_ChequesTalonarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gmt_ConfigurarEventoKeyEnter_Tab(Me)
        gf_AsignarEventoSeleccionarTexto(Me)
        CargarCtaBancaria()
        CargarCajas()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            If Me.txtTalonario.Text = "" Then
                Throw New Exception("Ingrese Talonario Por Favor")
            End If
            AgregarRangoTalonarios(CInt(Me.txtInicial.Text), CInt(Me.txtFinal.Text))
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        Try
            With griTalonarios
                If .Rows.Count > 0 Then
                    If .ActiveRow.Selected Then
                        Dim oeCT As New e_ChequesTalonarios
                        oeCT = .ActiveRow.ListObject
                        If oeCT.TipoOperacion = "I" Then
                            oeCT = loChequesTalonarios.Item(loChequesTalonarios.IndexOf(oeCT))
                            loChequesTalonarios.Remove(oeCT)
                        Else
                            oeCT = loChequesTalonarios.Item(loChequesTalonarios.IndexOf(oeCT))
                            oeCT.Activo = 0
                            .ActiveRow.Hidden = True
                        End If
                        .DataBind()
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griTalonarios_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griTalonarios.CellChange
        griTalonarios.UpdateData()
    End Sub

    Private Sub griLista_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griLista.DoubleClick
        Editar()
    End Sub

    Private Sub griLista_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griLista.BeforeRowsDeleted
        If griLista.Rows.Count > 0 Then
            e.DisplayPromptMsg = False
            If EliminarTalonario() Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCtaBancaria()
        oeCuentaBancaria = New e_CuentaBancaria
        oeCuentaBancaria.Activo = 1
        loCuentaBancaria = olCuentaBancaria.Listar(oeCuentaBancaria)
        LlenarCombo(cboCuentaBancaria, "BancoCuenta", loCuentaBancaria, -1)
    End Sub

    Private Sub Inicializar()
        oeChequesControl = New e_ChequesControl
        Me.cboCuentaBancaria.SelectedIndex = -1
        txtTalonario.Text = String.Empty
        Me.txtInicial.Text = 1
        Me.txtFinal.Text = 50
        loChequesTalonarios.Clear()
        griTalonarios.DataSource = loChequesTalonarios
    End Sub

    Private Sub Listar(ByVal Activo As Boolean)
        Try
            oeChequesControl = New e_ChequesControl
            oeChequesControl.TipoOperacion = "1"
            oeChequesControl.Activo = Activo
            loChequesControl = olChequesControl.Listar(oeChequesControl)
            griLista.DataSource = loChequesControl
            For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griLista.Rows
                If CInt(Fila.Cells("StockTalonarios").Value) < numStockTalonarios.Value Then
                    Fila.CellAppearance.BackColor = Me.ColorStockTalonarios.Color
                Else
                    Fila.CellAppearance.BackColor = Color.White
                End If
            Next
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub CargarCajas()
        oeCaja = New e_Caja()
        oeCaja.Activo = True
        loCaja = olCaja.Listar(oeCaja)
    End Sub

    Private Function GuardarControlCheques() As Boolean
        Try
            If Operacion = "Editar" Then oeChequesControl.TipoOperacion = "A"
            oeChequesControl.IdCuentaBancaria = cboCuentaBancaria.Value
            oeChequesControl.UsuarioCreacion = gUsuarioSGI.Id
            oeChequesControl.FechaCreacion = ObtenerFechaServidor()
            oeChequesControl.Activo = True
            Dim loCheTal As New List(Of e_ChequesTalonarios)
            For Each chetal As e_ChequesTalonarios In loChequesTalonarios
                If Trim(chetal.IdResponsable) <> "" And chetal.IndTerminado = False Then
                    Dim oeCheTal As New e_ChequesTalonarios()
                    oeCheTal.Id = chetal.Id
                    oeCheTal.IdResponsable = chetal.IdResponsable
                    loCheTal.Add(oeCheTal)
                End If
            Next
            For Each chetal As e_ChequesTalonarios In loChequesTalonarios
                For Each chetalo As e_ChequesTalonarios In loCheTal
                    If chetal.Id <> chetalo.Id And chetal.IndTerminado = False Then
                        If chetal.IdResponsable = chetalo.IdResponsable Then Throw New Exception("Solo Puede Asignar una Chequera por Trabajador")
                    End If
                Next
            Next
            oeChequesControl.listaChequeTalonario = loChequesTalonarios
            oeChequesControl.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olChequesControl.Guardar(oeChequesControl) Then
                MostrarTabs(0, ficControlCheques, 0)
                mensajeEmergente.Confirmacion("La Informacion ha sido Guardada Correctamente")
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Sub AgregarRangoTalonarios(ByVal Inicial As Integer, ByVal Final As Integer)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim NumeroInicial As Integer, NumeroFinal As Integer
            Dim Talonarios As Integer = Me.txtTalonario.Text
            Dim talo As Integer = Talonarios
            Dim count As Integer = 0
            If Inicial = 1 Then
                Talonarios = Final \ 50
            Else
                Talonarios = (Final - Inicial + 1) \ 50
            End If
            NumeroInicial = Inicial
            NumeroFinal = Inicial
            Dim i As Integer
            For i = 0 To Talonarios - 1
                oeChequesTalonarios = New e_ChequesTalonarios()
                oeChequesTalonarios.TipoOperacion = "I"
                oeChequesTalonarios.Id = count
                oeChequesTalonarios.Inicial = NumeroInicial
                oeChequesTalonarios.Final = NumeroFinal + 49
                oeChequesTalonarios.Talonario = talo
                oeChequesTalonarios.Activo = True
                oeChequesTalonarios.FechaIngreso = Me.dtpFechaIngreso.Value
                oeChequesTalonarios.IndAnulado = Me.verAnulado.CheckState
                oeChequesTalonarios.IndTerminado = Me.verTerminado.CheckState
                oeChequesTalonarios.Correlativo = FormatoDocumento(CStr(NumeroInicial), 8)
                oeChequesTalonarios.FechaCreacion = ObtenerFechaServidor()
                oeChequesTalonarios.UsuarioCreacion = gUsuarioSGI.Id
                loChequesTalonarios.Add(oeChequesTalonarios)
                NumeroInicial = NumeroInicial + 50
                NumeroFinal = NumeroInicial
                talo += 1
                count += 1
            Next
            griTalonarios.DataBind()
            LlenaCombosGrilla(griTalonarios)
            ugb_Espera.Visible = False
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub LlenaCombosGrilla(ByVal Grilla As UltraWinGrid.UltraGrid)
        Try
            For i As Integer = 0 To Grilla.Rows.Count - 1
                CrearComboGridPorCelda("IdCaja", "Nombre", i, Grilla, olCaja.ComboGrilla(loCaja), True)
                CrearComboGridCelda("IdResponsable", "Nombre", i, Grilla, olCombo.ComboGrilla(TesoreroPublic), True)
            Next
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function EditarControlCheques() As Boolean
        Try
            oeChequesControl = New e_ChequesControl
            oeChequesControl.TipoOperacion = "1"
            oeChequesControl.Id = griLista.ActiveRow.Cells("Id").Value
            oeChequesControl = olChequesControl.Obtener(oeChequesControl)
            cboCuentaBancaria.Value = oeChequesControl.IdCuentaBancaria
            ListarDetalle()
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Sub ListarDetalle()
        Try
            oeChequesTalonarios = New e_ChequesTalonarios
            oeChequesTalonarios.IdChequesControl = oeChequesControl.Id
            oeChequesTalonarios.TipoOperacion = "1"
            loChequesTalonarios = olChequesTalonarios.Listar(oeChequesTalonarios)
            griTalonarios.DataSource = loChequesTalonarios
            For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griTalonarios.Rows
                If Fila.Cells("IndTerminado").Value = True Then
                    Fila.Appearance.BackColor = Me.ColorTerminado.Color
                    Fila.Appearance.ForeColor = Color.White
                ElseIf Fila.Cells("IndAnulado").Value = True Then
                    Fila.Appearance.BackColor = Me.ColorAnulado.Color
                ElseIf Fila.Cells("IndTerminado").Value = False And Trim(Fila.Cells("IdResponsable").Value) <> "" Then
                    Fila.Appearance.BackColor = Me.ColorEnUso.Color
                ElseIf Fila.Cells("IndTerminado").Value = False And Fila.Cells("IndAnulado").Value = False And Trim(Fila.Cells("IdResponsable").Value) = "" Then
                    Fila.Appearance.BackColor = Me.ColorStock.Color
                End If
            Next
            LlenaCombosGrilla(griTalonarios)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function EliminarTalonario() As Boolean
        Try
            If griLista.ActiveRow.Selected Then
                If MessageBox.Show("Desea Eliminar el Registro Seleccionado?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    oeChequesControl = New e_ChequesControl
                    oeChequesControl.Id = griLista.ActiveRow.Cells("Id").Value
                    olChequesControl.Eliminar(oeChequesControl)
                Else
                    Return False
                    Exit Function
                End If
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

#End Region

End Class