'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Shared

Public Class frm_ConfiguracionNeumaticos

#Region "Instancia"

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Shared instancia As frm_ConfiguracionNeumaticos = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ConfiguracionNeumaticos()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Dim oeConfiguracionNeumatico As New e_ConfiguracionNeumatico, olConfiguracionNeumatico As New l_ConfiguracionNeumatico
    Dim oeDetalleConfigNeu As New e_DetalleConfiguracionNeumatico, olDetalleConfigNeu As New l_DetalleConfiguracionNeumatico
    Dim lstDetalleConfigNeu As New List(Of e_DetalleConfiguracionNeumatico)
    Dim _ingresando_datos As Boolean = False
    Dim olConfiguracion As New l_Configuracion

#End Region

#Region "Botones" 'Manejo de botones del menú principal del sistema

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            ListarConfiguracionNeumaticos(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If grid_ConfiguracionNeumatico.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            oeConfiguracionNeumatico = New e_ConfiguracionNeumatico
            oeConfiguracionNeumatico.TipoOperacion = "I"
            oeConfiguracionNeumatico.UsuarioCreacion = gUsuarioSGI.Id
            MostrarTabs(1, tcConfigNeumatico, 1)
            Inicializa()
            Operacion = "Nuevo"
            MyBase.Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            oeConfiguracionNeumatico = New e_ConfiguracionNeumatico
            MostrarConfiguracionNeumaticos()
            oeConfiguracionNeumatico.TipoOperacion = "A"
            txtCodigo.Focus()
            Operacion = "Editar"
            MyBase.Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarConfiguracionNeumatico() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcConfigNeumatico, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeConfiguracionNeumatico.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarConfiguracionNeumatico() Then
                            MostrarTabs(0, tcConfigNeumatico, 2)
                            _ingresando_datos = False
                            Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, tcConfigNeumatico, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcConfigNeumatico, 2)
                        _ingresando_datos = False
                        Consultar(True)
                End Select
            Else
                MostrarTabs(0, tcConfigNeumatico, 2)
                _ingresando_datos = False
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If ValidarGrilla(grid_ConfiguracionNeumatico, "Configuracion Neumaticos") Then
                With grid_ConfiguracionNeumatico
                    If .ActiveRow.Band.Index = 0 Then

                        oeConfiguracionNeumatico = New e_ConfiguracionNeumatico
                        oeConfiguracionNeumatico.Id = .ActiveRow.Cells("Id").Value.ToString
                        oeConfiguracionNeumatico = olConfiguracionNeumatico.Obtener(oeConfiguracionNeumatico)
                        If oeConfiguracionNeumatico.Activo Then
                            If MessageBox.Show("Esta seguro de eliminar la Configuración : " & _
                                     .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                oeConfiguracionNeumatico.TipoOperacion = "E"
                                olConfiguracionNeumatico.Eliminar(oeConfiguracionNeumatico)
                                Consultar(True)
                            End If
                        Else
                            Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                        End If

                    Else
                        Throw New Exception("Seleccione una Configuracion")
                    End If
                End With
            End If
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

            If grid_ConfiguracionNeumatico.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(grid_ConfiguracionNeumatico)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ConfiguracionNeumatico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grid_Ejes.DataSource = lstDetalleConfigNeu
        gmt_ConfigurarEventoKeyEnter_Tab(Me)
        gf_AsignarEventoSeleccionarTexto(Me)
    End Sub

    Private Sub frm_ConfiguracionNeumatico_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ConfiguracionNeumatico_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Select Case _Operacion
            Case "Nuevo", "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            If ValidarEje() Then
                oeConfiguracionNeumatico.lstDetalleConfiguracionNeumatico = grid_Ejes.DataSource
                oeDetalleConfigNeu = New e_DetalleConfiguracionNeumatico
                oeDetalleConfigNeu.Id = ""
                oeDetalleConfigNeu.IdConfiguracionNeumatico = ""
                oeDetalleConfigNeu.NroLineaEje = grid_Ejes.Rows.Count + 1
                oeDetalleConfigNeu.CantidadLlantas = neNroLLantas.Value
                oeDetalleConfigNeu.Activo = True
                oeDetalleConfigNeu.IndTraccion = chkTraccion.Checked
                oeConfiguracionNeumatico.lstDetalleConfiguracionNeumatico.Add(oeDetalleConfigNeu)
                grid_Ejes.DataBind()
                btnVisualizar.PerformClick()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            neNroLLantas.Value = 2
        End Try
    End Sub

    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click
        Try
            With grid_Ejes
                If .Rows.Count > 0 Then
                    For i As Integer = 0 To .Rows.Count - 1
                        Dim panel As New Panel
                        Select Case .Rows(i).Cells("NroLineaEje").Value
                            Case 1
                                panel = Me.pnl_Eje1
                            Case 2
                                panel = Me.pnl_Eje2
                            Case 3
                                panel = Me.pnl_Eje3
                            Case 4
                                panel = Me.pnl_Eje4
                        End Select
                        CargarImagen(.Rows(i).Cells("CantidadLlantas").Value, .Rows(i).Cells("IndTraccion").Value, _
                                       panel)
                        panel = Nothing
                    Next
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Confirmacion(ex.Message)
        End Try
    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        Try
            With grid_Ejes
                If .Selected.Rows.Count > 0 Then
                    .ActiveRow.Delete()
                    .DataBind()
                Else
                    Throw New Exception("Por favor seleccione el dato que desea quitar")
                End If
                Renumerar()
                MuestraOcultaEjes(False)
                btnVisualizar.PerformClick()
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        txtNombre.Text = LTrim(txtNombre.Text)
        oeConfiguracionNeumatico.Nombre = txtNombre.Text
    End Sub

    Private Sub grid_ConfiguracionNeumatico_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grid_ConfiguracionNeumatico.DoubleClickRow
        If grid_ConfiguracionNeumatico.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub grid_Ejes_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles grid_Ejes.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show(Me.Text & ": ¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then e.Cancel = True
    End Sub

    Private Sub grid_Ejes_AfterRowsDeleted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grid_Ejes.AfterRowsDeleted
        Renumerar()
        MuestraOcultaEjes(False)
        btnVisualizar.PerformClick()
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarImagen(ByVal numLLantas As Integer, ByVal traccion As Boolean, ByVal panel As Panel)
        Try
            panel.Visible = True
            If numLLantas = 2 And traccion Then
                panel.BackgroundImage = GeneraImagen("\1.jpg", False, "", True)
            ElseIf numLLantas = 2 And Not traccion Then
                panel.BackgroundImage = GeneraImagen("\2.jpg", False, "", True)
            ElseIf numLLantas = 4 And Not traccion Then
                panel.BackgroundImage = GeneraImagen("\3.jpg", False, "", True)
            ElseIf numLLantas = 4 And traccion Then
                panel.BackgroundImage = GeneraImagen("\4.jpg", False, "", True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método para visualizar u ocultar los ejes 
    ''' </summary>
    ''' <param name="visualiza"></param>
    ''' <remarks></remarks>
    Private Sub MuestraOcultaEjes(ByVal visualiza As Boolean)
        pnl_Eje1.Visible = visualiza
        pnl_Eje2.Visible = visualiza
        pnl_Eje3.Visible = visualiza
        pnl_Eje4.Visible = visualiza
    End Sub

    Private Sub Renumerar()
        With grid_Ejes
            For Each fila As UltraGridRow In .Rows
                fila.Cells("NroLineaEje").Value = fila.RowSelectorNumber
            Next
        End With
    End Sub

    Public Sub ListarConfiguracionNeumaticos(ByVal Activo As Boolean)
        Try
            oeConfiguracionNeumatico = New e_ConfiguracionNeumatico
            oeConfiguracionNeumatico.Activo = Activo
            With grid_ConfiguracionNeumatico
                .DataSource = olConfiguracionNeumatico.Listar(oeConfiguracionNeumatico)
                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
        grid_ConfiguracionNeumatico.Focus()
    End Sub

    Private Sub Inicializa()
        Me.txtNombre.Text = String.Empty
        Me.txtCodigo.Text = String.Empty
        Me.chkTraccion.Checked = False
        neNroLLantas.Value = 2
        verActivo.Checked = True
        MuestraOcultaEjes(False)
        lstDetalleConfigNeu.Clear()
        grid_Ejes.DataBind()
    End Sub

    Public Sub MostrarConfiguracionNeumaticos()
        Try
            If grid_ConfiguracionNeumatico.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializa()
                oeConfiguracionNeumatico.Id = grid_ConfiguracionNeumatico.ActiveRow.Cells("Id").Value.ToString
                oeConfiguracionNeumatico = olConfiguracionNeumatico.Obtener(oeConfiguracionNeumatico)
                txtCodigo.Text = oeConfiguracionNeumatico.Id
                txtNombre.Text = oeConfiguracionNeumatico.Nombre
                verActivo.Checked = oeConfiguracionNeumatico.Activo
                MostrarTabs(1, tcConfigNeumatico, 1)
                ListarEjes()
                btnVisualizar.PerformClick()
                MyBase.Editar()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarEjes()
        Try
            oeDetalleConfigNeu = New e_DetalleConfiguracionNeumatico
            oeDetalleConfigNeu.Activo = True
            oeDetalleConfigNeu.IdConfiguracionNeumatico = oeConfiguracionNeumatico.Id
            lstDetalleConfigNeu = olDetalleConfigNeu.Listar(oeDetalleConfigNeu)
            grid_Ejes.DataSource = lstDetalleConfigNeu
            grid_Ejes.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Funciones"

    Public Function GuardarConfiguracionNeumatico() As Boolean
        Try
            oeConfiguracionNeumatico.NroEjes = grid_Ejes.Rows.Count
            oeConfiguracionNeumatico.lstDetalleConfiguracionNeumatico = grid_Ejes.DataSource
            oeConfiguracionNeumatico.NroNeumaticos = lstDetalleConfigNeu.Where(Function(it) it.Activo = 1).Sum(Function(it) it.CantidadLlantas)
            oeConfiguracionNeumatico.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olConfiguracionNeumatico.Guardar(oeConfiguracionNeumatico) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                MostrarTabs(0, tcConfigNeumatico, 2)
                Consultar(True)
                grid_ConfiguracionNeumatico.Focus()
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Función que permite validar que el eje tenga pares de neumáticos y que el tope de ejes sea 4
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ValidarEje() As Boolean
        Try
            If grid_Ejes.Rows.Count >= 4 Then Throw New Exception("Ya ha ingresado 4 ejes, no es posible asignar más ejes al vehículo")

            Dim val As Double = neNroLLantas.Value
            If Not (val Mod 2 = 0) Then Throw New Exception("El eje sólo puede tener pares de neumáticos")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

End Class
