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

Public Class frm_MontoFlujoDiario
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializa"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_MontoFlujoDiario = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        Operacion = "Inicializa"
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_MontoFlujoDiario()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Dim WithEvents oeMontoFlujoDiario As New e_MontoFlujoDiario
    Dim olMontoFlujoDiario As New l_MontoFlujoDiario

    Dim _ingresando_datos As Boolean = False

    Dim oeMFDDetalle As New e_MontoFlujoDiario_Det
    Dim leMFDDetalle As New List(Of e_MontoFlujoDiario_Det)

    Dim oeTipoVehiculo As New e_TipoVehiculo
    Dim olTipoVehiculo As New l_TipoVehiculo

    Dim oeRuta As New e_Ruta
    Dim olRuta As New l_Ruta

    Dim oeFlujoCaja As New e_FlujoCaja
    Dim olFlujoCaja As New l_FlujoCaja

    Dim OperacionDet As String = ""

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal activo As Boolean)
        Try
            Listar(activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griMontoFlujoDiario.Rows.Count > 0 Then
                MyBase.Consultar(activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        MostrarTabs(1, ficMontoFlujoDiario, 1)
        Inicializar()
        oeMontoFlujoDiario.TipoOperacion = "I"
        oeMontoFlujoDiario.Modificado = False
        cboRuta.Focus()
        Operacion = "Nuevo"
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        Mostrar()
        oeMontoFlujoDiario.TipoOperacion = "A"
        oeMontoFlujoDiario.Modificado = False
        cboRuta.Focus()
        Operacion = "Editar"
        MyBase.Editar()
    End Sub

    Public Overrides Sub Guardar()
        Try
            If Guardando() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficMontoFlujoDiario, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeMontoFlujoDiario.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If Guardando() Then
                            MostrarTabs(0, ficMontoFlujoDiario, 2)
                            _ingresando_datos = False
                            Consultar(_Activo)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficMontoFlujoDiario, 1)
                        End If

                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficMontoFlujoDiario, 2)
                        _ingresando_datos = False
                        Consultar(_Activo)
                End Select
            Else
                MostrarTabs(0, ficMontoFlujoDiario, 2)
                _ingresando_datos = False
                Consultar(_Activo)
            End If
            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With griMontoFlujoDiario
                If ValidarGrilla(griMontoFlujoDiario, "Monto Flujo Diario") Then
                    oeMontoFlujoDiario.Id = .ActiveRow.Cells("ID").Value
                    oeMontoFlujoDiario = olMontoFlujoDiario.Obtener(oeMontoFlujoDiario)
                    If oeMontoFlujoDiario.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar el Monto de Flujo Diario: " & _
                                 .ActiveRow.Cells("Ruta").Value.ToString & ", " & _
                                 .ActiveRow.Cells("TipoVehiculo").Value.ToString & ", " & _
                                 .ActiveRow.Cells("TipoVehiculo").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeMontoFlujoDiario.TipoOperacion = "E"
                            olMontoFlujoDiario.Eliminar(oeMontoFlujoDiario)
                            Consultar(True)
                        End If
                    Else
                        Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            If ficMontoFlujoDiario.Tabs(0).Selected AndAlso griMontoFlujoDiario.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            If ficMontoFlujoDiario.Tabs(0).Selected Then Exportar_Excel(griMontoFlujoDiario)

            If ficMontoFlujoDiario.Tabs(1).Selected AndAlso griMFDDetalle.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            If ficMontoFlujoDiario.Tabs(1).Selected Then Exportar_Excel(griMFDDetalle)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        'MyBase.Imprimir()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_MontoFlujoDiario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_MontoFlujoDiario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        agrDatoDetalle.Expanded = False
        agrDatoDetalle.Visible = False
        agrDatoDetalle.ExpansionIndicator = Misc.GroupBoxExpansionIndicator.None
        agrDatoDetalle.HeaderClickAction = Misc.GroupBoxHeaderClickAction.None
    End Sub

    Private Sub cboRuta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRuta.ValueChanged
        If cboRuta.SelectedIndex > -1 Then oeMontoFlujoDiario.IdRuta = cboRuta.Value
    End Sub

    Private Sub cboTipoVehiculo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoVehiculo.ValueChanged
        If cboTipoVehiculo.SelectedIndex > -1 Then oeMontoFlujoDiario.IdTipoVehiculo = cboTipoVehiculo.Value
    End Sub

    Private Sub cboFlujoCaja_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFlujoCaja.ValueChanged
        If cboFlujoCaja.SelectedIndex > -1 Then oeMontoFlujoDiario.IdFlujoCaja = cboFlujoCaja.Value
    End Sub

    Private Sub decMonto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decMonto.ValueChanged
        oeMontoFlujoDiario.Monto = decMonto.Value
    End Sub

    Private Sub oeMontoFlujoDiario_DatoCambiado() Handles oeMontoFlujoDiario.DatoCambiado
        oeMontoFlujoDiario.Modificado = True
    End Sub

    Private Sub mnuMontoFlujoDiario_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mnuMontoFlujoDiario.Opening

        mnuMontoFlujoDiario.Items("tsmiNuevo").Visible = True
        
        If griMontoFlujoDiario.Selected.Rows.Count > 0 Then
            mnuMontoFlujoDiario.Items("tsmiActualizar").Visible = True
            mnuMontoFlujoDiario.Items("tsmiEliminar").Visible = True
        Else
            mnuMontoFlujoDiario.Items("tsmiActualizar").Visible = False
            mnuMontoFlujoDiario.Items("tsmiEliminar").Visible = False
        End If

    End Sub

    Private Sub tsmiNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiNuevo.Click
        Nuevo()
    End Sub

    Private Sub tsmiActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiActualizar.Click
        Editar()
    End Sub

    Private Sub tsmiEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEliminar.Click
        Eliminar()
    End Sub

    Private Sub griMontoFlujoDiario_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griMontoFlujoDiario.DoubleClick
        If griMontoFlujoDiario.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub mnuDetalle_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mnuDetalle.Opening
        mnuDetalle.Items("tsmiAgregar").Visible = True
        mnuDetalle.Items("tsmiEditar").Visible = False
        If griMFDDetalle.Selected.Rows.Count > 0 Then
            mnuDetalle.Items("tsmiEditar").Visible = True
            mnuDetalle.Items("tsmiQuitar").Visible = True
        Else
            mnuDetalle.Items("tsmiEditar").Visible = False
            mnuDetalle.Items("tsmiQuitar").Visible = False
        End If
    End Sub

    Private Sub tsmiAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiAgregar.Click
        Agregar_Det()
    End Sub

    Private Sub tsmiEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEditar.Click
        Editar_Det()
    End Sub

    Private Sub tsmiQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiQuitar.Click
        Quitar_Det()
    End Sub

    Private Sub griMFDDetalle_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griMFDDetalle.CellChange
        Try
            griMFDDetalle.UpdateData()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub griMFDDetalle_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griMFDDetalle.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show("¿Desea Quitar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
            Exit Sub
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            If oeMFDDetalle.TipoOperacion = "I" Then
                oeMFDDetalle.UsuarioCreacion = gUsuarioSGI.Id
                If Not leMFDDetalle.Contains(oeMFDDetalle) Then
                    If griMFDDetalle.Rows.Count = 0 Then ListarMFDDetalle(leMFDDetalle)
                    leMFDDetalle.Add(oeMFDDetalle)
                Else
                    Throw New Exception("El Concepto por:" & oeMFDDetalle.Concepto & " ya esta registrado.")
                End If
                griMFDDetalle.DataBind()
                'decMonto.Value = decMonto.Value + oeMFDDetalle.MontoPromedio
                SumaDetalle()
                If MessageBox.Show("¿Desea continuar agregando?", "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    Agregar_Det()
                Else
                    agrDatoDetalle.Expanded = False
                    agrDatoDetalle.Visible = False
                End If
            Else
                Dim oe As New e_MontoFlujoDiario_Det
                oe = leMFDDetalle.Item(leMFDDetalle.IndexOf(oeMFDDetalle))
                oe.MontoPromedio = oeMFDDetalle.MontoPromedio
                oe.TipoOperacion = "A"
                griMFDDetalle.DataBind()
                agrDatoDetalle.Expanded = False
                agrDatoDetalle.Visible = False
                'decMonto.Value = decMonto.Value + oeMFDDetalle.MontoPromedio
                SumaDetalle()
                mensajeEmergente.Confirmacion("El registro ha sido editado", True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        agrDatoDetalle.Expanded = False
        agrDatoDetalle.Visible = False
    End Sub

    Private Sub cboConcepto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboConcepto.ValueChanged
        If cboConcepto.SelectedIndex > -1 Then oeMFDDetalle.Tipo = cboConcepto.SelectedIndex + 1 : oeMFDDetalle.Concepto = cboConcepto.Text
    End Sub

    Private Sub decMontoMax_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decMontoMax.ValueChanged
        oeMFDDetalle.MontoPromedio = decMontoMax.Value
    End Sub

    Private Sub griMFDDetalle_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griMFDDetalle.DoubleClick
        If griMFDDetalle.Rows.Count > 0 Then Editar_Det()
    End Sub

#End Region

#Region "Metodos"

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            'Estado = IIf(Activo, " Activo", " Inactivo")
            Me.Cursor = Cursors.WaitCursor
            oeMontoFlujoDiario = New e_MontoFlujoDiario
            With griMontoFlujoDiario
                oeMontoFlujoDiario.Activo = Activo

                'Obtiene la información de bancos desde la BD
                .DataSource = olMontoFlujoDiario.Listar(oeMontoFlujoDiario)

                'Ordena los datos en forma ascendente por el campo Nombre
                '.DisplayLayout.Bands(0).Columns("Nombre").SortIndicator = SortOrder.Ascending

                'Ocultar columnas específicas
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdRuta").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdTipoVehiculo").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdFlujoCaja").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True

                'Especificar el ancho de las columnas que se muestran
                .DisplayLayout.Bands(0).Columns("Ruta").Width = 200
                .DisplayLayout.Bands(0).Columns("TipoVehiculo").Width = 200
                .DisplayLayout.Bands(0).Columns("FlujoCaja").Width = 200
                .DisplayLayout.Bands(0).Columns("Monto").Width = 90

                .DisplayLayout.Bands(0).Columns("Monto").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("Monto").CellAppearance.TextHAlign = HAlign.Right

                .DisplayLayout.Bands(0).Columns("Ruta").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("TipoVehiculo").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("FlujoCaja").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Monto").Header.VisiblePosition = 4

                'Cofigura la grilla para que se seleccione la fila completa al hacer click en algun lado
                .DisplayLayout.Bands(0).Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Bands(0).Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Bands(0).Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Bands(0).Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Bands(0).Override.FilterUIType = FilterUIType.FilterRow

                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If

            End With

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub Inicializar()
        Try
            leMFDDetalle = New List(Of e_MontoFlujoDiario_Det)
            ListarMFDDetalle(leMFDDetalle)

            oeRuta = New e_Ruta
            oeRuta.Activo = True
            LlenarCombo(cboRuta, "Nombre", olRuta.Listar(oeRuta), -1)

            oeTipoVehiculo = New e_TipoVehiculo
            oeTipoVehiculo.Carga = -1
            oeTipoVehiculo.Motriz = -1
            oeTipoVehiculo.IndicadorFuncional = 1
            oeTipoVehiculo.Activo = True
            LlenarCombo(cboTipoVehiculo, "Nombre", olTipoVehiculo.Listar(oeTipoVehiculo), -1)

            oeFlujoCaja = New e_FlujoCaja
            oeFlujoCaja.Activo = True
            LlenarCombo(cboFlujoCaja, "Nombre", olFlujoCaja.Listar(oeFlujoCaja), -1)

            decMonto.Value = 0

            agrDatoDetalle.Expanded = False
            agrDatoDetalle.Visible = False

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Mostrar()
        Try
            If griMontoFlujoDiario.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeMontoFlujoDiario.Id = griMontoFlujoDiario.ActiveRow.Cells("Id").Value.ToString
                oeMontoFlujoDiario = olMontoFlujoDiario.Obtener(oeMontoFlujoDiario)
                cboRuta.Value = oeMontoFlujoDiario.IdRuta
                cboTipoVehiculo.Value = oeMontoFlujoDiario.IdTipoVehiculo
                cboFlujoCaja.Value = oeMontoFlujoDiario.IdFlujoCaja
                decMonto.Value = oeMontoFlujoDiario.Monto
                leMFDDetalle = oeMontoFlujoDiario.leMontoFlujoDiarioDet
                ListarMFDDetalle(leMFDDetalle)
                MostrarTabs(1, ficMontoFlujoDiario, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function Guardando() As Boolean
        Try
            oeMontoFlujoDiario.UsuarioCreacion = gUsuarioSGI.Id
            oeMontoFlujoDiario.leMontoFlujoDiarioDet = leMFDDetalle
            oeMontoFlujoDiario.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olMontoFlujoDiario.Guardar(oeMontoFlujoDiario) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, ficMontoFlujoDiario, 2)
                Consultar(_Activo)
                griMontoFlujoDiario.Focus()
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Function

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("Ruta") Then cboRuta.Focus()
        If excepcion.Contains("Tipo Vehiculo") Then cboTipoVehiculo.Focus()
        If excepcion.Contains("Flujo Caja") Then cboFlujoCaja.Focus()

    End Sub

    Private Sub ListarMFDDetalle(ByVal le As List(Of e_MontoFlujoDiario_Det))
        Try
            Dim oe As New e_MontoFlujoDiario_Det
            With griMFDDetalle

                .DataSource = le
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdMontoFlujoDiario").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True

                .DisplayLayout.Bands(0).Columns("MontoPromedio").Style = ColumnStyle.Double
                .DisplayLayout.Bands(0).Columns("MontoPromedio").CellAppearance.TextHAlign = HAlign.Right

                .DisplayLayout.Bands(0).Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Bands(0).Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Bands(0).Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex

                For Each Fila As UltraGridRow In .Rows
                    oe = Fila.ListObject
                    Select Case Fila.Cells("Tipo").Value
                        Case 1
                            Fila.Cells("Concepto").Value = "Desayuno"
                        Case 2
                            Fila.Cells("Concepto").Value = "Almuerzo"
                        Case 3
                            Fila.Cells("Concepto").Value = "Cena"
                    End Select
                Next

                .UpdateData()

            End With


        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub Inicializa_Det()
        oeMFDDetalle = New e_MontoFlujoDiario_Det
        agrDatoDetalle.Expanded = True
        agrDatoDetalle.Visible = True
        CargarConcepto()
        decMontoMax.Value = 0
        cboConcepto.SelectedIndex = -1
        cboConcepto.Focus()
    End Sub

    Enum EnumConcepto As Byte
        Desayuno = 0
        Almuezo = 1
        Cena = 2
    End Enum

    Private Sub CargarConcepto()
        Dim TipoConcepto As EnumConcepto = CType(2, EnumConcepto)
        cboConcepto.Items.Clear()
        cboConcepto.Items.Add(EnumConcepto.Desayuno.ToString)
        cboConcepto.Items.Add(EnumConcepto.Almuezo.ToString)
        cboConcepto.Items.Add(EnumConcepto.Cena.ToString)
    End Sub

    Private Sub Agregar_Det()
        Inicializa_Det()
        oeMFDDetalle.TipoOperacion = "I"
    End Sub

    Private Sub Quitar_Det()
        oeMFDDetalle = New e_MontoFlujoDiario_Det
        oeMFDDetalle.Tipo = griMFDDetalle.ActiveRow.Cells("Tipo").Value
        If MessageBox.Show("¿Desea eliminar el concepto: " & griMFDDetalle.ActiveRow.Cells("Concepto").Value, _
                           "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            Dim oe As New e_MontoFlujoDiario_Det
            oe = leMFDDetalle.Item(leMFDDetalle.IndexOf(oeMFDDetalle))
            If oe.Id <> "" Then
                oe.TipoOperacion = "E"
                griMFDDetalle.ActiveRow.Hidden = True
            Else
                leMFDDetalle.Remove(oe)
            End If
            griMFDDetalle.DataBind()
            SumaDetalle()
        End If
       
    End Sub

    Private Sub Editar_Det()
        Inicializa_Det()
        oeMFDDetalle = griMFDDetalle.ActiveRow.ListObject
        oeMFDDetalle.TipoOperacion = "A"
        cboConcepto.SelectedIndex = oeMFDDetalle.Tipo - 1
        decMontoMax.Value = oeMFDDetalle.MontoPromedio
    End Sub

    Private Sub SumaDetalle()
        decMonto.Value = 0
        For Each Fila As UltraGridRow In griMFDDetalle.Rows
            If Not Fila.Hidden Then decMonto.Value = decMonto.Value + Fila.Cells("MontoPromedio").Value
        Next
    End Sub

#End Region


End Class