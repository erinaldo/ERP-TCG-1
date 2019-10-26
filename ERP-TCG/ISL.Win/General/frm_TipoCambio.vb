'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF

Public Class frm_TipoCambio
    Inherits frm_MenuPadre
    Private WithEvents oeTipoCambio As New e_TipoCambio
    Private olTipoCambio As New l_TipoCambio
    Private Shared instancia As frm_TipoCambio = Nothing
    Dim _ingresando_datos As Boolean = False

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_TipoCambio()
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            If gridTipoCambio.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Inicializar()
        oeTipoCambio.TipoOperacion = "I"
        oeTipoCambio.Modificado = False
        cboMonedaOrigen.Text = "SOLES"
        cboMonedaDestino.Text = "DOLARES"
        decCambioCompra.Focus()
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        Try
            If ValidarGrilla(gridTipoCambio, "Tipo de Cambio") Then
                If gridTipoCambio.ActiveRow.Cells("Id").Value.ToString <> "" Then
                    Inicializar()
                    MostrarTipoCambio()
                    oeTipoCambio.TipoOperacion = "A"
                    oeTipoCambio.Modificado = False
                    cboMonedaOrigen.Focus()
                    MyBase.Editar()
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
            If GuardarTipoCambio() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcTipoCambio, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeTipoCambio.Modificado Then
                Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarTipoCambio() Then
                            MostrarTabs(1, tcTipoCambio, 2)
                            _ingresando_datos = False
                            MyBase.Consultar(True) 'activa desactiva botonera
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, tcTipoCambio, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcTipoCambio, 2)
                        _ingresando_datos = True
                        MyBase.Consultar(True)
                    Case Windows.Forms.DialogResult.Cancel
                        _ingresando_datos = True
                End Select
            Else
                MostrarTabs(0, tcTipoCambio, 2)
                _ingresando_datos = False
                MyBase.Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With gridTipoCambio
                If ValidarGrilla(gridTipoCambio, "Tipo de Cambio") Then
                    If .ActiveRow.Cells("Id").Value.ToString <> "" Then
                        oeTipoCambio.Id = .ActiveRow.Cells("ID").Value
                        oeTipoCambio = olTipoCambio.Obtener(oeTipoCambio)
                        If oeTipoCambio.Activo Then
                            If MessageBox.Show("Esta seguro de eliminar el Tipo de Cambio del día: " & _
                                     .ActiveRow.Cells("FechaCambio").Value.ToString.Substring(0, 10) & " ?", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                oeTipoCambio.TipoOperacion = "E"
                                olTipoCambio.Eliminar(oeTipoCambio)
                                Consultar(True)
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
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try

            If gridTipoCambio.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(gridTipoCambio)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Métodos"

    Private Sub Inicializar()
        oeTipoCambio = New e_TipoCambio
        oeTipoCambio.Activo = True
        cboMonedaOrigen.SelectedIndex = -1
        cboMonedaDestino.SelectedIndex = -1
        fecFechaCambio.Value = Date.Now
        decCambioCompra.Value = "0.0000"
        decCambioVenta.Value = "0.0000"
        verActivo.Checked = oeTipoCambio.Activo
        verActivo.Visible = Not oeTipoCambio.Activo
        MostrarTabs(1, tcTipoCambio, 1)
        AsociarMenu()

    End Sub

    Private Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeTipoCambio = New e_TipoCambio
            oeTipoCambio.Activo = Activo
            oeTipoCambio.FechaCambio = "01/" & Meses1.Id.ToString & "/" & Año1.Año.ToString
            LimpiaGrid(gridTipoCambio, UltraDataSource2)
            With gridTipoCambio
                .DataSource = olTipoCambio.Listar(oeTipoCambio)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True

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
        gridTipoCambio.Focus()
    End Sub

    Private Function GuardarTipoCambio() As Boolean
        Try
            oeTipoCambio.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olTipoCambio.Guardar(oeTipoCambio) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, tcTipoCambio, 2)
                Consultar(True)
                gridTipoCambio.Focus()
                Return True
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Sub MostrarTipoCambio()
        Try
            If gridTipoCambio.ActiveRow.Cells("ID").Value.ToString.Length > 0 Then
                oeTipoCambio.Id = gridTipoCambio.ActiveRow.Cells("Id").Value.ToString
                oeTipoCambio = olTipoCambio.Obtener(oeTipoCambio)
                cboMonedaOrigen.Value = oeTipoCambio.IdMonedaOrigen
                cboMonedaDestino.Value = oeTipoCambio.IdMonedaDestino
                fecFechaCambio.Value = oeTipoCambio.FechaCambio
                decCambioCompra.Value = oeTipoCambio.CambioCompra
                decCambioVenta.Value = oeTipoCambio.CambioVenta
                verActivo.Checked = oeTipoCambio.Activo
                verActivo.Visible = Not oeTipoCambio.Activo
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub ComboMonedas()
        Dim leMoneda As New List(Of e_Moneda)
        Dim leMoneda2 As New List(Of e_Moneda)
        Dim oeMoneda As New e_Moneda
        oeMoneda.Activo = True
        Dim olMoneda As New l_Moneda
        leMoneda.AddRange(olMoneda.Listar(oeMoneda))
        '------Clona o copia lista Objetos con origen de datos desenlazado
        leMoneda2 = leMoneda.ToList
        '---------------------     
        gridTipoCambio.DisplayLayout.ValueLists.Add("IdMonedaOrigen")
        With gridTipoCambio.DisplayLayout.ValueLists("IdMonedaOrigen").ValueListItems
            .Clear()
            For Each oem As e_Moneda In leMoneda
                .Add(oem.Id, oem.Nombre)
            Next
        End With
        CrearComboGrid3("IdMonedaOrigen", "Nombre", gridTipoCambio, True)
        '------------------------------------------
        cboMonedaOrigen.DataSource = leMoneda
        '---------------------     
        gridTipoCambio.DisplayLayout.ValueLists.Add("IdMonedaDestino")
        With gridTipoCambio.DisplayLayout.ValueLists("IdMonedaDestino").ValueListItems
            .Clear()
            For Each oem2 As e_Moneda In leMoneda2
                .Add(oem2.Id, oem2.Nombre)
            Next
        End With
        CrearComboGrid3("IdMonedaDestino", "Nombre", gridTipoCambio, True)
        '------------------------------------------
        cboMonedaDestino.DataSource = leMoneda2

    End Sub

#End Region

#Region "Eventos"

    Private Sub oeTipoCambio_DatoCambiado() Handles oeTipoCambio.DatoCambiado
        oeTipoCambio.Modificado = True
    End Sub

    Private Sub frm_TipoCambio_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_TipoCambio_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case _Operacion
            Case "Nuevo"
                Me.Activate()
                Me.Cancelar()

            Case "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_frm_TipoCambio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        MostrarTabs(0, tcTipoCambio)
        gridTipoCambio.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        gridTipoCambio.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        ComboMonedas()
        Tiempo1.Enabled = False
        InicializaTiempo()
        Meses1.Seleccionar(Date.Now.Month)
        Año1.Año = Date.Now.Year
        NroDecimales.Value = 3
    End Sub

    Private Sub gridTipoCambio_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles gridTipoCambio.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub gridTipoCambio_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridTipoCambio.DoubleClick
        If gridTipoCambio.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub gridTipoCambio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridTipoCambio.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub cmbMonedaOrigen_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMonedaOrigen.ValueChanged
        oeTipoCambio.IdMonedaOrigen = cboMonedaOrigen.Value
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeTipoCambio.Activo = verActivo.Checked
    End Sub

    Private Sub cmbMonedaDestino_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMonedaDestino.ValueChanged
        oeTipoCambio.IdMonedaDestino = cboMonedaDestino.Value
    End Sub

    Private Sub fecFechaCambio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecFechaCambio.ValueChanged
        oeTipoCambio.FechaCambio = fecFechaCambio.Value
    End Sub

    Private Sub decCambioVenta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decCambioVenta.ValueChanged
        oeTipoCambio.CambioVenta = decCambioVenta.Value
    End Sub

    Private Sub decCambioCompra_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decCambioCompra.ValueChanged
        oeTipoCambio.CambioCompra = decCambioCompra.Value
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_TipoCambio_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub gridTipoCambio_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridTipoCambio.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro de Tipo de Cambio"

    Private Sub AsociarMenu()
        gridTipoCambio.ContextMenuStrip = MenuContextual1
    End Sub

    Private Sub InsertarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertarToolStripMenuItem.Click
        Nuevo()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        Editar()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar()
    End Sub

    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        MenuContextual1.Items("InsertarToolStripMenuItem").Visible = True
        If gridTipoCambio.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

    '''' <summary>
    '''' Cambia el número de decimales con que se muestra el tipo de cambio
    '''' </summary>
    '''' <param name="sender"></param>
    '''' <param name="e"></param>
    '''' <remarks></remarks>
    Private Sub NroDecimales_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NroDecimales.Validated
        If gridTipoCambio.Rows.Count > 0 Then
            With gridTipoCambio.DisplayLayout.Bands(0)
                .Columns("CambioCompra").Format = FormateaDecimales(NroDecimales.Value)
                .Columns("CambioVenta").Format = FormateaDecimales(NroDecimales.Value)
            End With
        End If
    End Sub

End Class
