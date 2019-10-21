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

Public Class frm_CentroCosto

#Region "Definición del Formulario base"

    Inherits frm_MenuPadre
    Private Shared instancia As frm_CentroCosto = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_CentroCosto()
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de variables"

    Dim oeCentroCosto As New e_CentroCosto
    Dim olCentroCosto As New l_CentroCosto
    Dim _ingresando_datos As Boolean = False

    Dim oeArea As New e_Area
    Dim olArea As New l_Area

    Dim oeCCUbicaciones As New e_CentroCostoUbicaciones
    Dim ListVehiculoAFCC As New List(Of e_Combo)
    Dim olCombo As l_Combo
    Dim oeCombo As e_Combo
#End Region

#Region "BOTONES"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Listar(Activo)
            If griLista.Rows.Count > 0 Then
                If Activo Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                Else
                    ControlBoton(1, 1, 1, 0, 0, 0, 1, 0, 1)
                End If
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Inicializar()
        Operacion = "Nuevo"
        MostrarTabs(1, ficCentroCosto, 1)
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
    End Sub

    Public Overrides Sub Editar()
        Try
            Operacion = "Editar"
            Inicializar()
            If MostrarItemCentroCosto() Then
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarCentroCosto() Then
                MostrarTabs(0, ficCentroCosto, 2)
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficCentroCosto, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeCentroCosto.Modificado Then

                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)

                    Case Windows.Forms.DialogResult.Yes

                        If GuardarCentroCosto() Then
                            MostrarTabs(0, ficCentroCosto, 2)
                            _ingresando_datos = False
                            Consultar(True)
                        Else
                            _ingresando_datos = True
                        End If

                    Case Windows.Forms.DialogResult.No

                        MostrarTabs(0, ficCentroCosto, 2)
                        _ingresando_datos = False
                        Consultar(True)

                    Case Windows.Forms.DialogResult.Cancel

                        _ingresando_datos = True

                End Select

            Else

                MostrarTabs(0, ficCentroCosto, 2)
                _ingresando_datos = False
                Consultar(True)
            End If

            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Public Overrides Sub Eliminar()
        griLista.ActiveRow.Delete()
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            If griLista.Rows.Count = 0 Then Throw New Exception("No hay ningún Centro de Costo para exportar al Excel")
            Exportar_Excel(griLista)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Métodos"

    Private Sub Inicializar()
        txtId.Text = String.Empty
        txtCodigo.Text = String.Empty
        txtNombre.Text = String.Empty
        txtAbreviatura.Text = String.Empty
        txtNombreUbicacion.Text = String.Empty
        txtDescripcionUbicacion.Text = String.Empty
        verVehiculo.Checked = False
        verIndActivoFijo.Checked = False
        verIndDiario.Checked = False
        verIndCompra.Checked = False
        verIndVenta.Checked = False
        griUbicaciones.DataSource = New List(Of e_CentroCostoUbicaciones)
    End Sub

    'Valida si hay datos en la fila de la grilla
    Public Function ValidarGrilla(ByVal Grilla As Infragistics.Win.UltraWinGrid.UltraGrid, _
                                   ByVal Etiqueta As String) As Boolean
        Try
            If Grilla.Rows.Count < 1 Then
                Throw New Exception("Ingrese: " + Etiqueta)
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeCentroCosto = New e_CentroCosto
            With oeCentroCosto
                .TipoOperacion = "1"
                .IndActivoFijo = IIf(verActivoFijoBusca.Checked, 1, 0)
                .IndDiario = IIf(verDiarioBusca.Checked, 1, 0)
                .IndCompra = IIf(verCompraBusca.Checked, 1, 0)
                .IndVenta = IIf(verVentaBusca.Checked, 1, 0)
            End With

            With griLista
                .DataSource = olCentroCosto.Listar(oeCentroCosto)
                agrCentroCosto.Text = "Centros de costo :" & .Rows.Count
                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Cursor.Current = Cursors.Default
            griLista.Focus()
        End Try
    End Sub

    Public Function GuardarCentroCosto() As Boolean
        Try
            With oeCentroCosto
                .TipoOperacion = "I"
                .Codigo = txtCodigo.Text
                .Nombre = txtNombre.Text
                .Abreviatura = txtAbreviatura.Text
                .IdArea = cboArea.Value
                .IdVehiculo = cboVehiculo.Value
                .IdCentro = cboCentro.Value
                .IndActivoFijo = IIf(verIndActivoFijo.Checked, 1, 0)
                .IndDiario = IIf(verIndDiario.Checked, 1, 0)
                .IndCompra = IIf(verIndCompra.Checked, 1, 0)
                .IndVenta = IIf(verIndVenta.Checked, 1, 0)
                .UsuarioCreacion = gUsuarioSGI.Id
                .ListUbicaciones = griUbicaciones.DataSource
                .PrefijoID = gs_PrefijoIdSucursal '@0001
            End With
            If olCentroCosto.Guardar(oeCentroCosto) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
            End If
            Operacion = "Inicializa"
            If griLista.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 1, 0, 1)
            End If
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Public Function MostrarItemCentroCosto() As Boolean
        Try
            If griLista.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                oeCentroCosto = New e_CentroCosto
                oeCentroCosto.Id = griLista.ActiveRow.Cells("Id").Value.ToString
                oeCentroCosto = olCentroCosto.Obtener(oeCentroCosto)
                With oeCentroCosto
                    txtId.Text = .Id
                    txtCodigo.Text = .Codigo
                    txtNombre.Text = .Nombre
                    txtAbreviatura.Text = .Abreviatura
                    cboArea.Value = .IdArea
                    If .IdVehiculo <> "" Then
                        verVehiculo.Checked = True
                        cboVehiculo.Value = .IdVehiculo
                    End If
                    cboCentro.Value = .IdCentro
                    verIndActivoFijo.Checked = .IndActivoFijo
                    verIndDiario.Checked = .IndDiario
                    verIndCompra.Checked = .IndCompra
                    verIndVenta.Checked = .IndVenta
                End With
                oeCCUbicaciones = New e_CentroCostoUbicaciones
                oeCCUbicaciones.IdCentroCosto = oeCentroCosto.Id
                griUbicaciones.DataSource = olCentroCosto.ListarUbicaciones(oeCCUbicaciones)
                MostrarTabs(1, ficCentroCosto, 1)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function EliminarCentroCosto() As Boolean
        Try
            With griLista
                If ValidarGrilla(griLista, "Centro de costo") Then
                    oeCentroCosto = New e_CentroCosto
                    oeCentroCosto.Id = .ActiveRow.Cells("Id").Value.ToString
                    oeCentroCosto = olCentroCosto.Obtener(oeCentroCosto)  'Obtenemos un registro 
                    If oeCentroCosto.Id <> "" Then 'y verificamos si esta activo(Sin eliminación lógica)
                        If MessageBox.Show("Esta seguro de eliminar el Centro de Costo: " & _
                                 .ActiveRow.Cells("Codigo").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                            oeCentroCosto.TipoOperacion = "E"
                            olCentroCosto.Eliminar(oeCentroCosto)
                        Else
                            Return False
                            Exit Function
                        End If
                    Else
                        Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                    End If
                End If
            End With
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Function

    Public Sub LlenaCombos()
        oeCombo = New e_Combo
        olCombo = New l_Combo
        oeCombo.Nombre = "VehiculoAFCC"
        ListVehiculoAFCC.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
        LlenarComboMaestro(cboArea, AreasPublic, -1)
        LlenarComboMaestro(cboCentro, CentroPublic, 0)
        LlenarComboMaestro(cboVehiculo, ListVehiculoAFCC, 0)
    End Sub

    Private Sub ComboGrilla()
        Try
            olCombo = New l_Combo
            CrearComboGrid("IdArea", "Nombre", griLista, olCombo.ComboGrilla(AreasPublic), True)
            CrearComboGrid("IdVehiculo", "Nombre", griLista, olCombo.ComboGrilla(ListVehiculoAFCC), True)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "Eventos"

    Private Sub frm_CentroCosto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            MostrarTabs(0, ficCentroCosto)
            InicializaTiempo()
            LlenaCombos()
            ComboGrilla()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub frm_CentroCosto_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

        instancia = Nothing

    End Sub

    Private Sub frm_CentroCosto_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing


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

    Private Sub griListaCentroCostos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griLista.DoubleClick
        If griLista.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griListaCentroCostos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griLista.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub griListaCentroCostos_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griLista.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            If EliminarCentroCosto() Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        Catch ex As Exception
            e.Cancel = True
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mnuEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Eliminar()
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    'Private Sub frm_CentroCosto_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
    '    InicializaTiempo()
    'End Sub

    'Private Sub griListaCentroCostos_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griLista.MouseMove
    '    If _tiempo <= 0 Then
    '        Consultar(True)
    '    End If
    '    InicializaTiempo()
    'End Sub

#End Region

    Private Sub btnAgregarR_Click(sender As Object, e As EventArgs) Handles btnAgregarU.Click
        Try
            If txtNombreUbicacion.Text <> "" Then
                oeCentroCosto.ListUbicaciones = griUbicaciones.DataSource
                With oeCCUbicaciones
                    .Id = ""
                    .IdCentroCosto = txtId.Text
                    .Nombre = txtNombreUbicacion.Text
                    .DescripcionDetallada = txtDescripcionUbicacion.Text
                End With
                oeCentroCosto.ListUbicaciones.Add(oeCCUbicaciones)
                griUbicaciones.DataBind()
                oeCCUbicaciones = New e_CentroCostoUbicaciones
                txtNombreUbicacion.Focus()
                txtNombreUbicacion.Text = ""
                txtDescripcionUbicacion.Text = ""
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griUbicaciones_CellChange(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griUbicaciones.CellChange
        griUbicaciones.UpdateData()
    End Sub

    Private Sub griUbicaciones_BeforeRowsDeleted(sender As Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griUbicaciones.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show("¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub verVehiculo_CheckedChanged(sender As Object, e As EventArgs) Handles verVehiculo.CheckedChanged
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            If verVehiculo.Checked Then
                cboVehiculo.Enabled = verVehiculo.Checked
                cboVehiculo.Focus()
            Else
                cboVehiculo.Enabled = verVehiculo.Checked
                cboVehiculo.Text = ""
                txtDescripcionVehiculo.Text = ""
            End If
        End If
    End Sub

    Private Sub cboVehiculo_InitializeLayout(sender As Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboVehiculo.InitializeLayout
        With cboVehiculo.DisplayLayout.Bands(0)
            .Columns("Id").Hidden = True
            .Columns("Nombre").Hidden = False
            .Columns("Nombre").Header.Caption = "Placa"
            .Columns("Nombre").Width = 100
            .Columns("Descripcion").Hidden = False
            .Columns("Descripcion").Header.Caption = "Motriz -- Placa Antigua"
            .Columns("Descripcion").Width = 250
        End With
    End Sub

    Private Sub cboVehiculo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboVehiculo.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cboVehiculo.PerformAction(UltraWinGrid.UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub cboVehiculo_ValueChanged(sender As Object, e As EventArgs) Handles cboVehiculo.ValueChanged
        Dim leVehiculo As New List(Of e_Combo)
        leVehiculo = ListVehiculoAFCC.ToList
        leVehiculo = leVehiculo.Where(Function(item) item.Id = cboVehiculo.Value).ToList
        If leVehiculo.Count > 0 Then
            txtDescripcionVehiculo.Value = leVehiculo(0).Descripcion
        End If
    End Sub

    Private Sub Menu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Menu.Opening
        Menu.Items("Insert").Visible = True
        If griLista.Selected.Rows.Count > 0 Then
            Menu.Items("Update").Visible = True
            Menu.Items("Delete").Visible = True
        Else
            Menu.Items("Update").Visible = False
            Menu.Items("Delete").Visible = False
        End If
    End Sub

    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles Insert.Click
        Nuevo()
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        Editar()
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Eliminar()
    End Sub


    Private Sub frm_CentroCosto_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub
End Class
