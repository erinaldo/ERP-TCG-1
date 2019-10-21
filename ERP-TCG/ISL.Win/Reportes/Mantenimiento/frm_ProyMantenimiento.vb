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
Imports Infragistics.UltraChart.Shared.Styles

Public Class frm_ProyMantenimiento
    Inherits frm_MenuPadre

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ProyMantenimiento = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ProyMantenimiento()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Dim oeProyMant As New e_ProyMantenimiento, olProyMant As New l_Mantenimiento
    Dim oeUnidadMedida As New e_UnidadMedida, olUnidadMedida As New l_UnidadMedida, leUnidadMedida As List(Of e_UnidadMedida)
    Dim oeMarca As New e_Marca, olMarca As New l_Marca, leMarca As New List(Of e_Marca)
    Dim oeModelo As New e_Modelo, olModelo As New l_Modelo, leModelo As New List(Of e_Modelo)

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeProyMant = New e_ProyMantenimiento
            oeProyMant.IdUnidadMedida = cboUnidadMedida.Value
            oeProyMant.IdMarca = cboMarca.Value
            oeProyMant.IdModelo = cboModelo.Value
            CargarProyMantenimiento(olProyMant.ListarProyMant(oeProyMant))
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Exportar()
        'MyBase.Exportar()
        Try
            If griProyMant.Rows.Count > 0 Then
                Exportar_Excel(griProyMant)
            Else
                Throw New Exception("No hay Registros para exportar!!!!")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ProyMantenimiento_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ProyMantenimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gmt_ConfigurarEventoKeyEnter_Tab(Me)
            CargarCombos()
            CargarProyMantenimiento(New List(Of e_ProyMantenimiento))
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cboUnidadMedida_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUnidadMedida.ValueChanged
        Try
            If Not String.IsNullOrEmpty(cboUnidadMedida.Value) Then
                Dim leMarcaVeh As New List(Of e_Marca)
                oeMarca = New e_Marca
                leMarcaVeh = leMarca.Where(Function(it) it.Codigo = cboUnidadMedida.Value).OrderBy(Function(it) it.Nombre).ToList
                LlenarCombo(cboMarca, "Nombre", leMarcaVeh, 0)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboMarca_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMarca.ValueChanged
        Try
            If Not String.IsNullOrEmpty(cboMarca.Value) Then
                Dim leModeloVeh As New List(Of e_Modelo)
                oeModelo = New e_Modelo
                oeModelo.Id = "" : oeModelo.Nombre = "TODOS"
                leModeloVeh.Add(oeModelo)
                leModeloVeh.AddRange(leModelo.Where(Function(item) item.IdMarca = cboMarca.Value).ToList)
                LlenarCombo(cboModelo, "Nombre", leModeloVeh, 0)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_ProyMantenimiento_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombos()
        Try
            oeUnidadMedida = New e_UnidadMedida
            oeUnidadMedida.TipoOperacion = "D"
            leUnidadMedida = olUnidadMedida.Listar(oeUnidadMedida)
            LlenarCombo(cboUnidadMedida, "Abreviatura", leUnidadMedida, -1)

            oeMarca = New e_Marca
            oeMarca.TipoOperacion = "G"
            leMarca = olMarca.Listar(oeMarca)

            oeModelo = New e_Modelo
            oeModelo.TipoOperacion = String.Empty : oeModelo.Activo = True
            leModelo = olModelo.Listar(oeModelo)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarProyMantenimiento(ByVal leProyMant As List(Of e_ProyMantenimiento))
        Try
            With griProyMant
                .DataSource = leProyMant
                OcultarColumna(griProyMant, True, "Codigo", "UnidadMedida", "Horometro", "Motriz", "Marca", "Modelo")
                .DisplayLayout.Bands(0).Columns("Unidad").Header.VisiblePosition = 1 : .DisplayLayout.Bands(0).Columns("Motriz").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Marca").Header.VisiblePosition = 3 : .DisplayLayout.Bands(0).Columns("Modelo").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Fecha").Header.VisiblePosition = 5 : .DisplayLayout.Bands(0).Columns("Kilometraje").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("KMProyectado").Header.VisiblePosition = 7 : .DisplayLayout.Bands(0).Columns("KmMantenimiento").Header.VisiblePosition = 8
                .DisplayLayout.Bands(0).Columns("FechaUltimoMant").Header.VisiblePosition = 9 : .DisplayLayout.Bands(0).Columns("NroUltimoOT").Header.VisiblePosition = 10
                .DisplayLayout.Bands(0).Columns("Unidad").Width = 60 : .DisplayLayout.Bands(0).Columns("Motriz").Width = 35
                .DisplayLayout.Bands(0).Columns("Fecha").Width = 110 : .DisplayLayout.Bands(0).Columns("FechaUltimoMant").Width = 110
                .DisplayLayout.Bands(0).Columns("KMProyectado").Width = 70
                .DisplayLayout.Bands(0).Columns("KMProyectado").Header.Caption = "KmProy." : .DisplayLayout.Bands(0).Columns("KmMantenimiento").Header.Caption = "KmMnto"
                .DisplayLayout.Bands(0).Columns("KmUltimoServicio").Header.Caption = "Km. Ult. Serv."
                .DisplayLayout.Bands(0).Columns("Motriz").Style = ColumnStyle.CheckBox
                FormatoColumna(griProyMant, "", ColumnStyle.DateTime, HAlign.Default, "Fecha", "FechaUltimoMant")
                FormatoColumna(griProyMant, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Kilometraje", "Cantidad", "KmUltimoServicio", _
                               "KMProyectado", "KmMantenimiento", "Horometro", "CantidadProx", "Diferencia")
                ColorFondoColumna(griProyMant, Color.LightGreen, "Fecha", "Kilometraje")
                ColorFondoColumna(griProyMant, Color.Thistle, "KMProyectado", "KmMantenimiento")
                ColorFondoColumna(griProyMant, Color.LightBlue, "FechaUltimoMant", "NroUltimoOT", "KmUltimoServicio", "UltimoMant")
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class
