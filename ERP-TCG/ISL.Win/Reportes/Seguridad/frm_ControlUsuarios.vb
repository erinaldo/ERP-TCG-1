'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Infragistics.UltraChart.Shared.Styles
Imports Infragistics.Win.UltraWinGrid

Public Class frm_ControlUsuarios
    Inherits frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ControlUsuarios = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ControlUsuarios()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Dim oeUsuario As e_Usuario
    Dim olUsuario As l_Usuario
    Const textoSinIngreso As String = "Sin ingreso por más de                 días"
    Const usuariosSinIngreso As String = " Usuarios que no han ingresado al sistema"
    Const usuariosQueIngresaron As String = "Usuarios que han ingresado al sistema"
    Const usuariosConectados As String = "Usuarios actualmente conectados"

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar()
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griListaUsuario.Rows.Count > 0 Then
                ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)
            Else
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Exportar_Excel(griListaUsuario)
        MyBase.Exportar()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ControlUsuarios_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(1, 0, 0, 0, 0, 0, 1, 1, 1)
    End Sub

    Private Sub frm_ControlUsuarios_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ControlUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboTiempoActualizacionDatos.SelectedIndex = 1
        Listar()
    End Sub

#End Region

#Region "Metodos"

    Private Sub Listar()
        Try
            olUsuario = New l_Usuario

            With griListaUsuariosDesconectados

                .DataSource = olUsuario.ListarDesconectados()

                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("NombreTrabajador").Width = 300
                .DisplayLayout.Bands(0).Columns("Area").Width = 250
                .DisplayLayout.Bands(0).Columns("Ocupacion").Width = 200
                .DisplayLayout.Bands(0).Columns("ConectadoDesdePC").Width = 200
                .DisplayLayout.Bands(0).Columns("Usuario").Width = 80
                .DisplayLayout.Bands(0).Columns("FechaSalida").Width = 80
                .DisplayLayout.Bands(0).Columns("FechaSalida").Style = ColumnStyle.Time
                .DisplayLayout.Bands(0).Columns("FechaSalida").Header.Caption = "Hora Salida"
                .DisplayLayout.Bands(0).Columns("TiempoTranscurrido").Width = 150
                .DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]

                .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow

            End With


            With griListaUsuariosSinConexionUltimaSemana

                .DataSource = olUsuario.ListarSinAccesoUnaSemana

                '.DisplayLayout.Bands(0).Columns("Id").Hidden = True
                '.DisplayLayout.Bands(0).Columns("NombreTrabajador").Width = 300
                '.DisplayLayout.Bands(0).Columns("Area").Width = 250
                '.DisplayLayout.Bands(0).Columns("Ocupacion").Width = 200
                '.DisplayLayout.Bands(0).Columns("Usuario").Width = 80
                '.DisplayLayout.Bands(0).Columns("FechaUltimoIngreso").Width = 80
                '.DisplayLayout.Bands(0).Columns("FechaUltimoIngreso").Style = ColumnStyle.Date
                '.DisplayLayout.Bands(0).Columns("TiempoTranscurrido").Width = 150
                .DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]

                .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow

            End With

            With griListaUsuario

                .DataSource = olUsuario.ListarConectados()

                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("NombreTrabajador").Width = 300
                .DisplayLayout.Bands(0).Columns("Area").Width = 250
                .DisplayLayout.Bands(0).Columns("Ocupacion").Width = 200
                .DisplayLayout.Bands(0).Columns("ConectadoDesdePC").Width = 200
                .DisplayLayout.Bands(0).Columns("Usuario").Width = 80
                .DisplayLayout.Bands(0).Columns("FechaInicio").Width = 80
                .DisplayLayout.Bands(0).Columns("FechaInicio").Style = ColumnStyle.Time
                .DisplayLayout.Bands(0).Columns("FechaInicio").Header.Caption = "Hora Inicio"
                .DisplayLayout.Bands(0).Columns("TiempoTranscurrido").Width = 150
                .DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]

                .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow

            End With

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

    Private Sub Tiempo1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tiempo1.Tick
        Listar()
    End Sub

    Private Sub cboTiempoActualizacionDatos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Tiempo1.Enabled = True
        Select Case cboTiempoActualizacionDatos.Text
            Case "10 segundos"
                Tiempo1.Interval = 10000
            Case "30 segundos"
                Tiempo1.Interval = 30000
            Case "1 minuto"
                Tiempo1.Interval = 60000
            Case "5 minutos"
                Tiempo1.Interval = 300000
            Case "No actualizar"
                Tiempo1.Enabled = False
            Case Else
                Tiempo1.Interval = 10000
        End Select

    End Sub

End Class
