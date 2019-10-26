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

Public Class frm_Alerta

#Region "Definición del Formulario base"

    Inherits frm_MenuPadre

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_Alerta = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Alerta()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Definicion de Variables"
    Dim WithEvents oeAlerta As New e_Alerta
    Dim olAlerta As New l_Alerta
    Dim leAlertaDestino As New List(Of e_AlertaDestino)
    Dim _ingresando_datos As Boolean = False
#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griAlerta.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        MostrarTabs(1, ficAlerta, 1)
        Inicializar()
        oeAlerta.TipoOperacion = "I"
        oeAlerta.Modificado = False
        txtGlosa.Focus()
        Operacion = "Nuevo"
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        Mostrar()
        oeAlerta.TipoOperacion = "A"
        oeAlerta.Modificado = False
        txtGlosa.Focus()
        Operacion = "Editar"
        MyBase.Editar()
    End Sub

    Public Overrides Sub Guardar()
        Try
            'LlenarDatos()
            If Guardando() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficAlerta, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeAlerta.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If Guardando() Then
                            MostrarTabs(0, ficAlerta, 2)
                            _ingresando_datos = False
                            Consultar(_Activo)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficAlerta, 1)
                        End If
                        'Exit Sub
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficAlerta, 2)
                        _ingresando_datos = False
                        Consultar(_Activo)
                        'Exit Sub
                End Select
            Else
                MostrarTabs(0, ficAlerta, 2)
                _ingresando_datos = False
                Consultar(_Activo)
                'Exit Sub
            End If
            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With griAlerta
                If ValidarGrilla(griAlerta, "Alerta") Then
                    oeAlerta.Id = .ActiveRow.Cells("ID").Value
                    oeAlerta = olAlerta.Obtener(oeAlerta)
                    If oeAlerta.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar la Alerta: " & _
                                 .ActiveRow.Cells("NombreCompleto").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeAlerta.TipoOperacion = "E"
                            olAlerta.Eliminar(oeAlerta)
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

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            If griAlerta.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griAlerta)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Alerta_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Alerta_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm_Alerta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        Tiempo1.Enabled = False
        MostrarTabs(0, ficAlerta)
        InicializaTiempo()
        griAlerta.ContextMenuStrip = MenuContextual1
    End Sub

    Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrar.Click
        spcAlerta.Panel2Collapsed = IIf(spcAlerta.Panel2Collapsed, False, True)
    End Sub

    Private Sub btnMostrarOcultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrarOcultar.Click
        spcDestino.Panel2Collapsed = IIf(spcDestino.Panel2Collapsed, False, True)
    End Sub

    Private Sub txtGlosa_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGlosa.ValueChanged
        oeAlerta.oeAlertaDetalle.Glosa = txtGlosa.Text.Trim
    End Sub

    Private Sub verEmail_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verEmail.CheckedChanged
        oeAlerta.oeAlertaDetalle.Email = verEmail.Checked
    End Sub

    Private Sub verSonora_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verSonora.CheckedChanged
        oeAlerta.oeAlertaDetalle.Sonora = verSonora.Checked
    End Sub

    Private Sub verVisual_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verVisual.CheckedChanged
        oeAlerta.oeAlertaDetalle.Visual = verVisual.Checked
    End Sub

    Private Sub cboActividadNegocio_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboActividadNegocio.ValueChanged
        If cboActividadNegocio.SelectedIndex > -1 Then oeAlerta.IdActividadNegocio = cboActividadNegocio.Value
    End Sub

    Private Sub oeAlerta_DatoCambiado() Handles oeAlerta.DatoCambiado
        oeAlerta.Modificado = True
    End Sub

    Private Sub griAlerta_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griAlerta.DoubleClick
        If griAlerta.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griEmail_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griEmail.CellChange
        Try
            With griEmail
                .UpdateData()
                If .ActiveRow.Cells("Selec").Activated Then
                    Dim oeAlertaDestino As New e_AlertaDestino
                    leAlertaDestino = oeAlerta.leDestino
                    oeAlertaDestino.IdPersona = .ActiveRow.Cells("Id").Value
                    If Not leAlertaDestino.Contains(oeAlertaDestino) Then
                        If .ActiveRow.Cells("Selec").Value Then
                            oeAlertaDestino.IdAlerta = oeAlerta.Id
                            oeAlertaDestino.UsuarioCreacion = gUsuarioSGI.Id
                            oeAlertaDestino.NombreCompleto = .ActiveRow.Cells("NombreCompleto").Value
                            If griAlertaDestino.Rows.Count < 1 Then
                                LlenarAlertaDestino(leAlertaDestino)
                                'oeOcupacionTrabajador.Principal = True
                            End If
                            leAlertaDestino.Add(oeAlertaDestino)
                        End If
                    Else
                        oeAlertaDestino = leAlertaDestino.Item(leAlertaDestino.IndexOf(oeAlertaDestino))
                        If .ActiveRow.Cells("Selec").Value Then
                            If oeAlertaDestino.TipoOperacion = "E" Then
                                oeAlertaDestino.TipoOperacion = ""
                                For Each fila As UltraWinGrid.UltraGridRow In griAlertaDestino.Rows
                                    If fila.Cells("IdPersona").Value = oeAlertaDestino.IdPersona Then
                                        fila.Hidden = False
                                        Exit For
                                    End If
                                Next
                            Else
                                Throw New Exception("La Persona: " & .ActiveRow.Cells("NombreCompleto").Value & " ya está asignada")
                            End If
                        Else
                            If oeAlertaDestino.Id <> "" Then
                                oeAlertaDestino.TipoOperacion = "E"
                                For Each fila As UltraWinGrid.UltraGridRow In griAlertaDestino.Rows
                                    If fila.Cells("IdPersona").Value = oeAlertaDestino.IdPersona Then
                                        fila.Hidden = True
                                        Exit For
                                    End If
                                Next
                            Else
                                leAlertaDestino.Remove(oeAlertaDestino)
                            End If
                        End If
                    End If
                End If
            End With
            griAlertaDestino.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            oeAlerta = New e_Alerta
            With griAlerta
                oeAlerta.Activo = Activo
                .DataSource = olAlerta.Listar(oeAlerta)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True

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
        griAlerta.Focus()
    End Sub

    Private Sub Inicializar()
        Try
            txtGlosa.Text = String.Empty
            LimpiaGrid(griAlertaHistorial, ordAlertaDetalle)
            LimpiaGrid(griAlertaDestino, ordAlertaDestino)
            ListarPersona()
            Dim oeActividadNegocio As New e_ActividadNegocio
            Dim olActividadNegocio As New l_ActividadNegocio
            LlenarCombo(cboActividadNegocio, "Nombre", olActividadNegocio.Listar(oeActividadNegocio), -1)
            'AsociarMenu()
            txtGlosa.Text = String.Empty
            verEmail.Checked = False
            verSonora.Checked = False
            verVisual.Checked = False
            spcAlerta.Panel2Collapsed = True
            spcDestino.Panel2Collapsed = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Mostrar()
        Try
            If griAlerta.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeAlerta.Id = griAlerta.ActiveRow.Cells("Id").Value.ToString
                oeAlerta = olAlerta.Obtener(oeAlerta)
                'CargaDatosPersonales()
                cboActividadNegocio.Value = oeAlerta.IdActividadNegocio
                txtGlosa.Text = oeAlerta.oeAlertaDetalle.Glosa
                verEmail.Checked = oeAlerta.oeAlertaDetalle.Email
                verSonora.Checked = oeAlerta.oeAlertaDetalle.Sonora
                verVisual.Checked = oeAlerta.oeAlertaDetalle.Visual
                MostratAlertaDetalle(oeAlerta.leDetalle)
                MostrarAlertaDestino()
                MostrarTabs(1, ficAlerta, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function Guardando() As Boolean
        Try
            oeAlerta.leDestino = leAlertaDestino
            oeAlerta.UsuarioCreacion = gUsuarioSGI.Id
            oeAlerta.PrefijoID = gs_PrefijoIdSucursal '@0001
            If Not olAlerta.Guardar(oeAlerta) Then
                Return False
            End If
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
            MostrarTabs(0, ficAlerta, 2)
            Consultar(_Activo)
            griAlerta.Focus()
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Function

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("Glosa") Then
            txtGlosa.Focus()
        End If

    End Sub

    Private Sub ListarPersona()
        Try
            Dim oePersona As New e_Persona
            Dim olPersona As New l_Persona

            With griEmail
                .ResetDisplayLayout()
                .DataSource = olPersona.Listar(oePersona)
                .DisplayLayout.Bands(0).Columns.Add("Selec", "Seleccionar")
                .DisplayLayout.Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
                .DisplayLayout.Bands(0).Columns("Selec").DefaultCellValue = False
                .DisplayLayout.Bands(0).Columns("Selec").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Selec").Width = 60

                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Codigo").Hidden = True
                .DisplayLayout.Bands(0).Columns("ApellidoPaterno").Hidden = True
                .DisplayLayout.Bands(0).Columns("ApellidoMaterno").Hidden = True
                .DisplayLayout.Bands(0).Columns("Nombre").Hidden = True
                .DisplayLayout.Bands(0).Columns("Sexo").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaNacimiento").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True

                .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow

                .DisplayLayout.Bands(0).Columns("Dni").Width = 80
                .DisplayLayout.Bands(0).Columns("NombreCompleto").Width = 300

                .DisplayLayout.Bands(0).Columns("Dni").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .DisplayLayout.Bands(0).Columns("NombreCompleto").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit

            End With

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub MostratAlertaDetalle(ByVal leAlertaDetalle As List(Of e_AlertaDetalle))
        Try
            If leAlertaDetalle.Count > 0 Then
                griAlertaHistorial.DataSource = leAlertaDetalle
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
        
    End Sub

    Private Sub LlenarAlertaDestino(ByVal leAlertaDestino As List(Of e_AlertaDestino))
        Try
            With griAlertaDestino
                .DataSource = oeAlerta.leDestino
                '.DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                '.DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("NombreCompleto").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub MostrarAlertaDestino()
        Try
            If oeAlerta.leDestino.Count > 0 Then
                LlenarAlertaDestino(oeAlerta.leDestino)
                For Each oe As e_AlertaDestino In oeAlerta.leDestino
                    For Each Fila As UltraWinGrid.UltraGridRow In griEmail.Rows
                        If Fila.Cells("Id").Value = oe.IdPersona AndAlso oe.Activo Then
                            Fila.Cells("Selec").Value = True
                            Exit For
                        End If
                    Next
                Next
                griEmail.UpdateData()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Menú contextual del maestro de areas"

    Private Sub tsmiNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiNuevo.Click
        Nuevo()
    End Sub

    Private Sub tsmiActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiActualizar.Click
        Editar()
    End Sub

    Private Sub tsmiEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEliminar.Click
        Eliminar()
    End Sub

    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        MenuContextual1.Items("tsmiNuevo").Visible = True
        If griAlerta.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("tsmiActualizar").Visible = True
            MenuContextual1.Items("tsmiEliminar").Visible = True
            MenuContextual1.Items("tsmiAtender").Visible = True
            MenuContextual1.Items("tsmiTerminar").Visible = True
        Else
            MenuContextual1.Items("tsmiActualizar").Visible = False
            MenuContextual1.Items("tsmiEliminar").Visible = False
            MenuContextual1.Items("tsmiAtender").Visible = False
            MenuContextual1.Items("tsmiTerminar").Visible = False
        End If
    End Sub

#End Region



End Class