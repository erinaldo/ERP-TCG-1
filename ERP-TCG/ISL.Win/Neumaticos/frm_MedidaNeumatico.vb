'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports ISL.Controles
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_MedidaNeumatico

    Inherits frm_MenuPadre

#Region "Inicializar el formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_MedidaNeumatico = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_MedidaNeumatico()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Declaración de variables"

    Private oeMedidaNeumatico As New e_MedidaNeumatico
    Dim olMedidaNeumatico As New l_MedidaNeumatico
    Dim oeTipoNeumatico As New e_TipoNeumatico, olTipoNeumatico As l_TipoNeumatico
    'Variable para controlar el estado de los registros mostrados (Activo - Inactivo)
    Dim Estado As String
    'Variable para controlar el estado de la botonera principal del sistema
    Dim _ingresando_datos As Boolean = False
    Private oeTipoMedida As e_ConfiguracionDato, olTipoMedida As l_ConfiguracionDato, leTipoMedida As List(Of e_ConfiguracionDato)
    Private lb_Load As Boolean

    Dim loConcepto As New l_Concepto
    Dim oeConcepto As New e_Concepto
    Dim ListaConcepto As New List(Of e_Concepto)

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar()
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If grid_MedidaNeumatico.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            oeMedidaNeumatico = New e_MedidaNeumatico
            oeMedidaNeumatico.TipoOperacion = "I"
            oeMedidaNeumatico.UsuarioCreacion = gUsuarioSGI.Id
            MostrarTabs(1, tcMedidas, 1)
            Inicializar()
            txtNombre.Focus()
            Operacion = "Nuevo"
            MyBase.Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            oeMedidaNeumatico = New e_MedidaNeumatico
            MostrarMedidaNeumatico()
            oeMedidaNeumatico.TipoOperacion = "A"
            txtNombre.Focus()
            Operacion = "Editar"
            MyBase.Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarMedidaNeumatico() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcMedidas, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", _
                                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                Case Windows.Forms.DialogResult.Yes
                    If GuardarMedidaNeumatico() Then
                        MostrarTabs(0, tcMedidas, 2)
                        _ingresando_datos = False
                        Consultar(True)
                    Else
                        _ingresando_datos = True
                        MostrarTabs(1, tcMedidas, 1)
                    End If
                Case Windows.Forms.DialogResult.No
                    MostrarTabs(0, tcMedidas, 2)
                    _ingresando_datos = False
                    Consultar(True)
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With grid_MedidaNeumatico
                If ValidarGrilla(grid_MedidaNeumatico, "Medida Neumatico") Then
                    oeMedidaNeumatico.Id = .ActiveRow.Cells("Id").Value
                    oeMedidaNeumatico = olMedidaNeumatico.Obtener(oeMedidaNeumatico)
                    If oeMedidaNeumatico.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar la Medida Neumatico: " & _
                        .ActiveRow.Cells("Nombre").Value.ToString.Trim & "?", _
                        "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeMedidaNeumatico.TipoOperacion = "E"
                            olMedidaNeumatico.Eliminar(oeMedidaNeumatico)
                            Consultar(True)
                        End If
                    Else
                        Throw New Exception("La informacion se encuentra eliminada en " & Me.Text)
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try

            If grid_MedidaNeumatico.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(grid_MedidaNeumatico)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_MedidaNeumatico_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_MedidaNeumatico_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Operacion = "Nuevo" Or Operacion = "Editar" Then
            Me.Activate()
            Me.Cancelar()
        End If
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub grid_MedidaNeumatico_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles grid_MedidaNeumatico.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub grid_MedidaNeumatico_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grid_MedidaNeumatico.DoubleClick
        If grid_MedidaNeumatico.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub frm_MedidaNeumatico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gmt_ConfigurarEventoKeyEnter_Tab(Me)
            gf_AsignarEventoSeleccionarTexto(Me)
            InicializarLogicas()
            LlenaCombos()
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            lb_Load = True
            CargarMedNeu(New List(Of e_MedidaNeumatico))
            lb_Load = False
            MostrarTabs(0, tcMedidas, 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub InicializarLogicas()
        olTipoMedida = New l_ConfiguracionDato
        olTipoNeumatico = New l_TipoNeumatico
    End Sub

    Private Sub LlenaCombos()
        Try
            oeTipoNeumatico.Activo = True
            'LlenarComboMaestro(cmbTipoNeumatico, olTipoNeumatico.Listar(oeTipoNeumatico), -1)
            If Not cache.Contiene("TiposNeumatico") OrElse cache.ForzarActualizacion Then cache.Agregar("TiposNeumatico", olTipoNeumatico.Listar(oeTipoNeumatico))
            LlenarComboMaestro(cmbTipoNeumatico, DirectCast(cache.Obtener("TiposNeumatico"), List(Of e_TipoNeumatico)), -1)

            'oeTipoMedida = New e_ConfiguracionDato : leTipoMedida = New List(Of e_ConfiguracionDato)
            'oeTipoMedida.Descripcion = "NINGUNO" : oeTipoMedida.Id = String.Empty
            'leTipoMedida.Add(oeTipoMedida)
            'oeTipoMedida = New e_ConfiguracionDato
            'oeTipoMedida.TipoOperacion = "G" : oeTipoMedida.TipoReferencia = "Tipo_Medida_Neu" : oeTipoMedida.IdReferencia = "Nombre"
            'leTipoMedida.AddRange(olTipoMedida.Listar(oeTipoMedida))
            'LlenarCombo(cmbTipoMedida, "Descripcion", leTipoMedida, 0)

            'llenamos combo TIPO MEDIDA NEUMATICO
            ListaConcepto = New List(Of e_Concepto)
            oeConcepto = New e_Concepto
            oeConcepto.Valor1 = String.Empty
            oeConcepto.Nombre = "NINGUNO"
            ListaConcepto.Add(oeConcepto)
            oeConcepto = New e_Concepto
            oeConcepto.Activo = True
            oeConcepto.Prefijo = "18" 'prefijo de TIPO MEDIDA NEUMATICO
            ListaConcepto.AddRange(loConcepto.Listar(oeConcepto))
            cmbTipoMedida.DataSource = ListaConcepto
            cmbTipoMedida.DisplayMember = "Nombre"
            cmbTipoMedida.ValueMember = "Valor1"
            cmbTipoMedida.SelectedIndex = 0


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializar()
        Me.txtNombre.Text = String.Empty
        Me.ndAro.Value = 0
        Me.cmbTipoNeumatico.SelectedIndex = -1
        Me.cmbTipoMedida.SelectedIndex = 0
    End Sub

    Private Sub Listar()
        Try
            Me.Cursor = Cursors.WaitCursor
            oeMedidaNeumatico = New e_MedidaNeumatico
            CargarMedNeu(olMedidaNeumatico.Listar(oeMedidaNeumatico))
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
            grid_MedidaNeumatico.Focus()
        End Try
    End Sub

    Private Sub MostrarMedidaNeumatico()
        Try
            If grid_MedidaNeumatico.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeMedidaNeumatico.Id = grid_MedidaNeumatico.ActiveRow.Cells("Id").Value.ToString
                oeMedidaNeumatico = olMedidaNeumatico.Obtener(oeMedidaNeumatico)
                txtNombre.Text = oeMedidaNeumatico.Nombre
                ndAro.Value = oeMedidaNeumatico.DiametroAro
                cmbTipoNeumatico.Value = oeMedidaNeumatico.IdTipoNeumatico
                cmbTipoMedida.Value = oeMedidaNeumatico.IdTipoMedida.Trim
                MostrarTabs(1, tcMedidas, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("nombre") Then txtNombre.Focus()
        If excepcion.Contains("aro") Then ndAro.Focus()
        If excepcion.Contains("abreviatura") Then cmbTipoNeumatico.Focus()
    End Sub

    Private Sub CargarMedNeu(ByVal leMedNeu As List(Of e_MedidaNeumatico))
        Try
            With grid_MedidaNeumatico
                If lb_Load Then .ResetDisplayLayout()
                .DataSource = leMedNeu
                If lb_Load Then
                    ConfiguraGrilla(grid_MedidaNeumatico, "Tahoma", True, UIElementBorderStyle.Default)
                    OcultarColumna2(grid_MedidaNeumatico, False, "Nombre", "DiametroAro", "TipoNeumatico", "TipoMedida")
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub RecolectaDatos()
        oeMedidaNeumatico.Nombre = txtNombre.Text.Trim
        oeMedidaNeumatico.DiametroAro = ndAro.Value
        oeMedidaNeumatico.IdTipoMedida = cmbTipoMedida.Value
        oeMedidaNeumatico.IdTipoNeumatico = cmbTipoNeumatico.Value
    End Sub

#End Region

#Region "Funciones"

    Private Function GuardarMedidaNeumatico() As Boolean
        Try
            RecolectaDatos()
            oeMedidaNeumatico.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olMedidaNeumatico.Guardar(oeMedidaNeumatico) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                MostrarTabs(0, tcMedidas, 2)
                Consultar(True)
                grid_MedidaNeumatico.Focus()
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            Enfocar(ex.Message)
        End Try
    End Function

#End Region

End Class
