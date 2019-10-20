'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF
Public Class frm_GeneraCorrelativoAsiento
    Inherits ISL.Win.frm_MenuPadre
    Private Shared instancia As frm_GeneraCorrelativoAsiento = Nothing
    Private Shared Operacion As String

#Region "Inicialización del formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_GeneraCorrelativoAsiento()
        End If
        instancia.Activate()
        Return instancia

    End Function

#End Region

    Private Sub frm_GeneraCorrelativoAsiento_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_GeneraCorrelativoAsiento_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_GeneraCorrelativoAsiento_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If _Operacion = "Nuevo" Or _Operacion = "Editar" Then
            Me.Activate()
            Me.Cancelar()
        End If
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_GeneraCorrelativoAsiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim frm As New Frm_PeriodoTipoAsiento(True, False, False, "CTB")
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim olAsiento As New l_Asiento
                l_FuncionesGenerales.ValidarPeriodo(frm.cboMes.Value, gAreasSGI.Contabilidad)
                olAsiento.CorrelativoAsiento(frm.cboMes.Value)
                mensajeEmergente.Confirmacion("Se Generó los correlativos, correctamente", True)
            End If
            frm = Nothing
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub


End Class
