'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_ReporteGastoFuncion
    Inherits ISL.Win.frm_MenuPadre



    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ReporteGastoFuncion = Nothing
    Private Shared Operacion As String
    Private Estado As String
    ''' <summary>
    ''' Instancia unica de Formulario: frm_ReporteGastoFuncion
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    '''
    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ReporteGastoFuncion()
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Declaración de variables"

    Dim _ingresando_datos As Boolean = False
    Dim Opcion As Boolean

    Dim oeGastoAsiento As New e_GastoAsiento
    Dim olGasttoAsiento As New l_GastoAsiento

    Private oeCtaContable As e_CuentaContable, olCtaContable As l_CuentaContable, leCtaContable As List(Of e_CuentaContable)
    Private oeItemGasto As e_ItemGasto, olItemGasto As l_ItemGasto, leItemGasto As List(Of e_ItemGasto)

#End Region

#Region "BOTONES"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Operacion = "Inicializa"
        Try
            Listar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Operacion = "Nuevo"
            Inicializar()
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
            mensajeEmergente.Problema(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Inicializar()
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            MyBase.Guardar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        MyBase.Eliminar()
    End Sub

    Public Overrides Sub Imprimir()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            MyBase.Imprimir()
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Salir()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            MyBase.Salir()
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            If griLista.Rows.Count = 0 Then Throw New Exception("No hay ningún Informe de Guía de Remisión Transportista para exportar al Excel")
            Exportar_Excel(griLista)

            MyBase.Exportar()
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ReporteGastoFuncion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)
        CalcularTotales(griLista, "Monto")
        mt_CargarItemgasto()
    End Sub

    Private Sub frm_ReporteGastoFuncion_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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
    End Sub

    Private Sub frm_ReporteGastoFuncion_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Select Case Operacion
            Case "Nuevo"
                MyBase.Nuevo()
            Case "Editar"
                MyBase.Editar()
            Case "Inicializa"
                MostrarTabs(0, ficDemanda)
                ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)
        End Select
    End Sub

    Private Sub frm_ReporteGastoFuncion_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ReporteGastoFuncion_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub AñoGFA_Validated(sender As Object, e As EventArgs) Handles AñoGFA.Validated
        ComboPerido(cboMesGFA, AñoGFA)
        mt_CargarCuentas(AñoGFA.Año)
    End Sub

    Private Sub griLista_DoubleClickRow(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles griLista.DoubleClickRow
        Try
            Dim ls_TipoGasto As String = String.Empty, ls_Cuenta As String = String.Empty, ls_NombreCuenta As String = String.Empty, ls_IdItemGasto As String = String.Empty
            If griLista.ActiveRow.Index > -1 Then
                ls_TipoGasto = griLista.ActiveRow.Cells("TipoGF").Value
                ' Obtener Cuenta Contable
                oeCtaContable = New e_CuentaContable
                oeCtaContable.Equivale = 0
                oeCtaContable.Cuenta = griLista.ActiveRow.Cells("Cuenta").Value
                oeCtaContable = leCtaContable.Item(leCtaContable.IndexOf(oeCtaContable))
                ls_Cuenta = oeCtaContable.Id
                ls_NombreCuenta = griLista.ActiveRow.Cells("NombreCuenta").Value
                ' Obtener Item Gasto
                Dim _leAux = leItemGasto.Where(Function(it) it.Nombre = IIf(IsDBNull(griLista.ActiveRow.Cells("ItemGasto").Value), "", griLista.ActiveRow.Cells("ItemGasto").Value)).ToList
                If _leAux.Count > 0 Then ls_IdItemGasto = _leAux(0).Id
                Dim _frm As New frm_ActualizarGastoFuncion(ls_TipoGasto, ls_Cuenta, ls_NombreCuenta, AñoGFA.Año, cboMesGFA.Value, ls_IdItemGasto)
                _frm.StartPosition = FormStartPosition.CenterScreen
                _frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
                If _frm.ShowDialog = Windows.Forms.DialogResult.Yes Then

                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Métodos"

    Private Sub Inicializar()

    End Sub

    Public Sub LlenaCombos()

    End Sub

    Public Sub Listar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeGastoAsiento = New e_GastoAsiento
            oeGastoAsiento.TipoOperacion = "0"
            oeGastoAsiento.IdPeriodo = cboMesGFA.Value
            griLista.DataSource = olGasttoAsiento.ListarGAFAnalisis(oeGastoAsiento)
            'Ubica el cursor el el primer registro de la grilla
            If griLista.Rows.Count > 0 Then
                griLista.Focus()
                griLista.Rows.Item(0).Selected = True
                ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)
            End If
            griLista.Focus()
            'InicializaTiempo()
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub ComboPerido(ByVal Combo As ISL.Controles.Combo, ByVal Anio As ISL.Win.Año)
        Try
            Dim oePeriodo As New e_Periodo
            Dim olPeriodo As New l_Periodo
            Dim lePeriodo As New List(Of e_Periodo)
            oePeriodo.Ejercicio = Anio.Año
            lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))
            oePeriodo = New e_Periodo
            lePeriodo.Add(oePeriodo)
            With Combo
                .DisplayMember = "Mes"
                .ValueMember = "Id"
                .DataSource = lePeriodo.OrderBy(Function(Item) Item.Mes).ToList
                If .Items.Count > 0 Then
                    .Text = Date.Now.Month
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarCuentas(ByVal _Ejercicio As Integer)
        olCtaContable = New l_CuentaContable
        oeCtaContable = New e_CuentaContable
        leCtaContable = New List(Of e_CuentaContable)
        oeCtaContable.Ejercicio = _Ejercicio
        oeCtaContable.Movimiento = 1
        leCtaContable = olCtaContable.Listar(oeCtaContable)
    End Sub

    Private Sub mt_CargarItemgasto()
        olItemGasto = New l_ItemGasto
        oeItemGasto = New e_ItemGasto
        leItemGasto = New List(Of e_ItemGasto)
        oeItemGasto.TipoOperacion = "I"
        leItemGasto = olItemGasto.Listar(oeItemGasto)
    End Sub

#End Region

End Class