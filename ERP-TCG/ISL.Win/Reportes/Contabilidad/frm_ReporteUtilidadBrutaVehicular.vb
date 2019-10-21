'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Public Class frm_ReporteUtilidadBrutaVehicular
    Inherits frm_MenuPadre
    Private Ejercicio As Integer
    Private Shared Operacion As String
    Private Shared instancia As frm_ReporteUtilidadBrutaVehicular = Nothing

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ReporteUtilidadBrutaVehicular()
        End If
        instancia.Activate()
        Return instancia

    End Function


#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar()
            If GridUBV.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Exportar_Excel(GridUBV)
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Métodos"

    Private Sub ComboPerido()
        Try
            If Ejercicio <> Año1.Año Then
                Ejercicio = Año1.Año
                Dim oePeriodo As New e_Periodo
                Dim olPeriodo As New l_Periodo
                Dim lePeriodo As New List(Of e_Periodo)
                oePeriodo.Ejercicio = Año1.Año
                oePeriodo.Activo = True
                lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))
                cboMes.Clear()
                With cboMes
                    .DisplayMember = "Mes"
                    .ValueMember = "Id"
                    .DataSource = lePeriodo
                End With
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Listar()
        Dim olAsiento As New l_Asiento
        Dim ds As DataSet
        ds = olAsiento.ListarUtilidadBrutaVehicular(Año1.Año, cboMes.Text, _
        IIf(chkAcumulado.Checked, 1, 0))
        GridUBV.DataSource = ds
        GridUBV.DataBind()
    End Sub
#End Region

#Region "Eventos"
    Private Sub Año1_DatoCambiado() Handles Año1.DatoCambiado
        ComboPerido()
    End Sub

    Private Sub frm_ReporteUtilidadBrutaVehicular_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
    End Sub

    Private Sub frm_ReporteUtilidadBrutaVehicular_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ReporteUtilidadBrutaVehicular_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Año1.Año = Date.Now.Year
    End Sub


#End Region

End Class
