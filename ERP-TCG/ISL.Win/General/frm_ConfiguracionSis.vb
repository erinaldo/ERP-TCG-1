Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_ConfiguracionSis
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ConfiguracionSis = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ConfiguracionSis()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de variables"

    Dim olConfiguracionSis As New l_ConfiguracionSis
    Private WithEvents oeConfiguracionSis As New e_ConfiguracionSis
    Dim olConfiguracionSisDet As New l_ConfiguracionSisDet
    Private WithEvents oeConfiguracionSisDet As New e_ConfiguracionSisDet
    Private ConfiguracionSisDet As New List(Of e_ConfiguracionSisDet)

    Dim Estado As String
    Dim _ingresando_datos As Boolean = False

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griLista.Rows.Count > 0 Then
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            Else
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            MostrarTabs(1, tcConfSis, 1)
            Inicializar()
            Operacion = "Nuevo"
            MyBase.Nuevo()
            oeConfiguracionSis.Modificado = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            MostrarTablas()
            Operacion = "Editar"
            ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 1)
            oeConfiguracionSis.Modificado = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarConfiguracion() Then
                ControlBoton(1)
            Else
                MostrarTabs(1, tcConfSis, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            MostrarTabs(0, tcConfSis, 2)
            'Consultar(_Activo)
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
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

            If griLista.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griLista)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Eventos"

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeConfiguracionSis = New e_ConfiguracionSis
            With griLista
                oeConfiguracionSis.Activo = Activo
                .DataSource = olConfiguracionSis.Listar(oeConfiguracionSis)
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
        Me.txtNombre.Text = String.Empty
        Me.txtTabla.Text = String.Empty
        Me.Año.Año = Date.Now.Year
        ConfiguracionSisDet = New List(Of e_ConfiguracionSisDet)
        ConfiguracionSisDet.Clear()
        Me.griEjercicio.DataSource = ConfiguracionSisDet
        Me.griEjercicio.DataBind()
    End Sub

    Private Sub MostrarTablas()
        Try
            If griLista.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeConfiguracionSis.Id = griLista.ActiveRow.Cells("Id").Value.ToString
                oeConfiguracionSis = olConfiguracionSis.Obtener(oeConfiguracionSis)
                txtNombre.Text = oeConfiguracionSis.Nombre
                txtTabla.Text = oeConfiguracionSis.NombreTabla

                oeConfiguracionSisDet = New e_ConfiguracionSisDet
                oeConfiguracionSisDet.TipoOperacion = ""
                oeConfiguracionSisDet.IdConfiguracionSis = oeConfiguracionSis.Id
                oeConfiguracionSisDet.Activo = True
                griEjercicio.DataSource = olConfiguracionSisDet.Listar(oeConfiguracionSisDet)
                MostrarTabs(1, tcConfSis, 1)
                ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function GuardarConfiguracion() As Boolean
        Try
            oeConfiguracionSis.ListaConfiguracionSisDet = griEjercicio.DataSource
            If olConfiguracionSisDet.Guardar(oeConfiguracionSisDet) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente")
                MostrarTabs(0, tcConfSis, 2)
                Consultar(_Activo)
                griLista.Focus()
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Sub frm_ConfiguracionSis_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Select Case _Operacion
            Case "Nuevo"
                MyBase.Nuevo()
            Case "Editar"
                MyBase.Editar()
            Case "Inicializa"
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
                MostrarTabs(0, tcConfSis)
                ''Consultar(True)
                InicializaTiempo()
            Case "Ayuda"
                'ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        End Select
    End Sub

    Private Sub frm_ConfiguracionSis_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ConfiguracionSis_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If _Operacion = "Nuevo" Or _Operacion = "Editar" Then
            Me.Activate()
            Me.Cancelar()
        End If
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_ConfiguracionSis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MostrarTabs(0, tcConfSis)
        griLista.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        griLista.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        Tiempo1.Enabled = False
        InicializaTiempo()
        ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

#End Region

#Region "Metodos"

    Private Sub griLista_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griLista.DoubleClick
        If Me.griLista.Rows.Count > 0 Then Editar()
    End Sub

    Private Function ValidarEjercicio() As Boolean
        Try
            Dim flag As Boolean = False
            If Me.griEjercicio.Rows.Count > 0 Then
                For i = 0 To Me.griEjercicio.Rows.Count - 1
                    If Año.Año = Me.griEjercicio.Rows(i).Cells("Ejercicio").Value Then
                        flag = False
                        Throw New Exception("Ya Existe Configuracion para el Ejercicio: " & Año.Año)
                    Else
                        flag = True
                    End If
                Next
            Else
                flag = True
            End If
            Return flag
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function EjecutarConfiguracion() As Boolean
        Try
            If ValidarEjercicio() Then
                oeConfiguracionSis.ListaConfiguracionSisDet = Me.griEjercicio.DataSource
                oeConfiguracionSisDet.Id = ""
                oeConfiguracionSisDet.IdConfiguracionSis = oeConfiguracionSis.Id
                oeConfiguracionSisDet.Ejercicio = Año.Año
                oeConfiguracionSisDet.Activo = True
                oeConfiguracionSis.ListaConfiguracionSisDet.Add(oeConfiguracionSisDet)
                Guardar()
                oeConfiguracionSisDet = New e_ConfiguracionSisDet
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub btn_AddEjercicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AddEjercicio.Click
        Try
            If EjecutarConfiguracion() Then
                mensajeEmergente.Confirmacion("El ejercicio fue agregado satisfactoriamente")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

End Class