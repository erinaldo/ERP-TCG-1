'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports Infragistics.Win.UltraWinGrid
Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF

Public Class frm_CuentasGenerales

    Inherits frm_MenuPadre

#Region "Declaración de variables"

    Private WithEvents oeTablaCtbleDet As New e_TablaContableDet
    Private olTablaCtbleDet As New l_TablaContableDet
    Dim oeTablaContable As New e_TablaContable
    Dim olTablaContable As New l_TablaContable

    Private Ejercicio As Integer = 0
    Private Shared instancia As frm_CuentasGenerales = Nothing
    Private Shared Operacion As String
    Dim _ingresando_datos As Boolean = False
    Dim Estado As String

    Private WithEvents oeCuentasGenerales As New e_CuentasGenerales
    Private olCuentasGenerales As New l_CuentasGenerales
    Private lstCuentasGenerales As New List(Of e_CuentasGenerales)

    Dim leCuentaCtble As New List(Of e_CuentaContable)
    Dim oeCuentaCtable As New e_CuentaContable, olCuentaContable As New l_CuentaContable

#End Region


#Region "Definición del Formulario base"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_CuentasGenerales()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If grid_TablaCtbleDet.Rows.Count > 0 Then
                ControlBoton(1, 0, 1)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            If ValidarGrilla(grid_TablaCtbleDet, "Tabla Contable - Cuentas Generales") Then
                If grid_TablaCtbleDet.ActiveRow.Cells("Id").Value.ToString <> "" Then
                    Inicializar()
                    MostrarCuentas()
                    Me.Año.Focus()
                    Operacion = "Editar"
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
                Else
                    Throw New Exception("Seleccione una Fila!")
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarCuentasGenerales() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tc_CuentasGenerales, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeCuentasGenerales.Modificado Then
                Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarCuentasGenerales() Then
                            MostrarTabs(0, tc_CuentasGenerales, 2)
                            _ingresando_datos = False
                            ControlBoton(1, 0, 1) 'activa desactiva botonera
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, tc_CuentasGenerales, 1)
                            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        _ingresando_datos = False
                        MostrarTabs(0, tc_CuentasGenerales, 2)
                        ControlBoton(1, 0, 1)
                End Select
            Else
                _ingresando_datos = False
                MostrarTabs(0, tc_CuentasGenerales, 2)
                ControlBoton(1, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With grid_CuentasGenerales
                If ValidarGrilla(grid_CuentasGenerales, "Cuentas Generales") Then
                    If .ActiveRow.Cells("Id").Value.ToString <> "" Then
                        oeTablaCtbleDet.Id = .ActiveRow.Cells("Id").Value
                        oeTablaCtbleDet = olTablaCtbleDet.Obtener(oeTablaCtbleDet)
                        oeCuentasGenerales.IdTablaContableDet = oeTablaCtbleDet.Id
                        oeCuentasGenerales.Id = .ActiveRow.Cells("Id").Value.ToString
                        If oeCuentasGenerales.Activo Then
                            If MessageBox.Show("Esta seguro de eliminar la Cuenta General Asociado a: " & _
                                    grid_TablaCtbleDet.ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                oeCuentasGenerales.TipoOperacion = "E"
                                olCuentasGenerales.Eliminar(oeCuentasGenerales)
                                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
                            End If
                        Else
                            Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                        End If
                    Else
                        Throw New Exception("Seleccione una Fila!")
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema("Tiene que Registrar la Cuenta General antes de poder Eliminarla")
        End Try
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

            If grid_CuentasGenerales.Rows.Count = 0 Then Throw New Exception("No hay ninguna Cuenta General para exportar al Excel")
            Exportar_Excel(grid_CuentasGenerales)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Métodos"

    Private Sub Inicializar()
        oeTablaCtbleDet = New e_TablaContableDet
        Me.Año.Año = Date.Now.Year
        lstCuentasGenerales = New List(Of e_CuentasGenerales)
        lstCuentasGenerales.Clear()
        Me.grid_CuentasGenerales.DataSource = lstCuentasGenerales
        Me.grid_CuentasGenerales.DataBind()
        MostrarTabs(1, tc_CuentasGenerales, 1)
    End Sub

    Private Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeTablaCtbleDet = New e_TablaContableDet
            oeTablaCtbleDet.Activo = True
            oeTablaCtbleDet.TipoOperacion = "G"
            oeTablaCtbleDet.IdTabla = cboTablaContable.Value
            LimpiaGrid(grid_CuentasGenerales, odCuentasGenerales)
            With grid_TablaCtbleDet
                .DataSource = olTablaCtbleDet.Listar(oeTablaCtbleDet)
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True

                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            Throw ex
            Me.Cursor = Cursors.Default
        Finally
            Me.Cursor = Cursors.Default
        End Try
        grid_CuentasGenerales.Focus()
    End Sub

    Private Function GuardarCuentasGenerales() As Boolean
        Try
            For Each obj As e_CuentasGenerales In lstCuentasGenerales
                If Not (String.IsNullOrEmpty(obj.TipoOperacion)) Then
                    obj.PrefijoID = gs_PrefijoIdSucursal '@0001
                    olCuentasGenerales.Guardar(obj)
                End If
            Next
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente", True)
            MostrarTabs(0, tc_CuentasGenerales, 2)
            Consultar(_Activo)
            grid_CuentasGenerales.Focus()
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub MostrarCuentas()
        Try
            If grid_TablaCtbleDet.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Me.txtNombre.Text = grid_TablaCtbleDet.ActiveRow.Cells("Nombre").Value.ToString
                oeCuentasGenerales = New e_CuentasGenerales
                oeCuentasGenerales.TipoOperacion = "L"
                oeCuentasGenerales.IdTablaContableDet = grid_TablaCtbleDet.ActiveRow.Cells("Id").Value.ToString
                oeCuentasGenerales.Activo = True
                lstCuentasGenerales = olCuentasGenerales.Listar(oeCuentasGenerales)
                grid_CuentasGenerales.DataSource = lstCuentasGenerales
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComboCuenta()
        Try
            If Ejercicio <> Año.Año Then
                oeCuentaCtable = New e_CuentaContable
                leCuentaCtble.Clear()
                oeCuentaCtable.Activo = True
                'oeCuentaCtable.Movimiento = 1
                oeCuentaCtable.Ejercicio = Año.Año
                leCuentaCtble.AddRange(olCuentaContable.Listar(oeCuentaCtable))
                Ejercicio = Año.Año
                grid_Cuentas.DataSource = leCuentaCtble
                grid_Cuentas.DataBind()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub AgregarCuentasGenerales()
        Try
            Dim _cant As Integer = 0, sw As Boolean
            If cboTablaContable.Text <> "CUENTAS GENERALES" OrElse ValidarEjercicio(grid_CuentasGenerales, Me.Año) Then
                For Each oeCtaCtble As e_CuentaContable In leCuentaCtble.Where(Function(item) item.Seleccion)
                    sw = False
                    For Each objCtaGen As e_CuentasGenerales In lstCuentasGenerales
                        If oeCtaCtble.Id = objCtaGen.IdCuentaContable Then
                            sw = True
                            Exit For
                        End If
                    Next
                    If sw Then Continue For
                    oeCuentasGenerales = New e_CuentasGenerales
                    oeCuentasGenerales.Modificado = True
                    oeCuentasGenerales.TipoOperacion = "I"
                    oeCuentasGenerales.Id = ""
                    oeCuentasGenerales.Ejercicio = Año.Año
                    oeCuentasGenerales.IdTablaContableDet = grid_TablaCtbleDet.ActiveRow.Cells("Id").Value.ToString
                    oeCuentasGenerales.IdCuentaContable = oeCtaCtble.Id
                    oeCuentasGenerales.Cuenta = oeCtaCtble.Cuenta
                    oeCuentasGenerales.NombreCuenta = oeCtaCtble.Nombre
                    oeCuentasGenerales.Activo = True
                    lstCuentasGenerales.Add(oeCuentasGenerales)
                    _cant += 1
                Next
                If _cant > 0 Then
                    leCuentaCtble.ForEach(AddressOf DescheckearlstE)
                    grid_Cuentas.DataBind()
                    grid_CuentasGenerales.DataBind()
                End If
            Else
                mensajeEmergente.Problema("No puede ingresar 2 cuentas en el mismo ejercicio", True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Sub DescheckearlstE(ByVal oeItem As e_CuentaContable)
        If oeItem.Seleccion Then oeItem.Seleccion = False
    End Sub

    Private Sub ComboConcepto()
        Try
            oeTablaContable = New e_TablaContable
            Me.Cursor = Cursors.WaitCursor
            cboTablaContable.ValueMember = "Id"
            cboTablaContable.DisplayMember = "Nombre"
            oeTablaContable.Activo = True
            oeTablaContable.Tipooperacion = ""
            oeTablaContable.Texto1 = "CONFIG_CTA"
            cboTablaContable.DataSource = olTablaContable.Listar(oeTablaContable)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub grTablaCtbleDet_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid_TablaCtbleDet.DoubleClick
        If grid_TablaCtbleDet.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub frm_CuentasGenerales_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case _Operacion
            Case "Nuevo"
                MyBase.Nuevo()
            Case "Editar"
                MyBase.Editar()
            Case "Inicializa"
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                MostrarTabs(0, tc_CuentasGenerales)
                InicializaTiempo()
            Case "Ayuda"
                'ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        End Select
    End Sub

    Private Sub frm_CuentasGenerales_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_CuentasGenerales_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case Operacion
            Case "Nuevo", "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_CuentasGenerales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            MostrarTabs(0, tc_CuentasGenerales)
            grid_CuentasGenerales.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
            grid_CuentasGenerales.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
            Tiempo1.Enabled = False
            InicializaTiempo()
            ComboCuenta()
            ComboConcepto()
            Me.Año.Año = Date.Now.Year
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub grCuentasGenerales_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        TeclaPulsada(e)
    End Sub

    Private Sub grCuentasGenerales_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs)
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub mnuEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEliminar.Click
        Try
            Eliminar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        Editar()
    End Sub

    Private Sub Año_Validated(ByVal sender As Object, ByVal e As System.EventArgs)
        ComboCuenta()
    End Sub

    Private Sub btn_CtsGenerales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CtsGenerales.Click
        AgregarCuentasGenerales()
    End Sub

    Private Sub MenuDetalle_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuDetalle.Opening
        If Me.grid_TablaCtbleDet.Rows.Count > 0 Then
            MenuDetalle.Items("EditarToolStripMenuItem").Visible = 1
            MenuDetalle.Items("mnuEliminar").Visible = 1
        Else
            MenuDetalle.Items("EditarToolStripMenuItem").Visible = 0
            MenuDetalle.Items("mnuEliminar").Visible = 0
        End If
    End Sub

    Private Sub btn_DelTipoVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DelTipoVenta.Click
        Try
            If MessageBox.Show("Esta seguro de eliminar la Cuenta General Asociado a: " & _
                                  grid_TablaCtbleDet.ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                   "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                'grid_CuentasGenerales.ActiveRow.Delete(False)
                If Me.grid_CuentasGenerales.Rows.Count > 0 Then
                    If grid_CuentasGenerales.ActiveRow.Selected Then
                        Dim oeGO As New e_CuentasGenerales
                        oeGO = grid_CuentasGenerales.ActiveRow.ListObject
                        If oeGO.TipoOperacion = "I" Then
                            lstCuentasGenerales.Remove(oeGO)
                        Else
                            oeGO.TipoOperacion = "E"
                            grid_CuentasGenerales.ActiveRow.Hidden = True
                        End If
                        grid_CuentasGenerales.DataBind()
                    Else
                        mensajeEmergente.Problema("Seleccione un registro para Quitar", True)
                    End If
                Else
                    Exit Sub
                End If
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
#End Region

    Private Sub Año_DatoCambiado() Handles Año.DatoCambiado
        ComboCuenta()
    End Sub

    Private Sub grid_Cuentas_CellChange(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_Cuentas.CellChange
        grid_Cuentas.UpdateData()
    End Sub


End Class