Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win

Public Class frm_FechasContrato
    Inherits frm_MenuPadre

#Region "Declaracion de Variables"

    Public FechaInicio As Date
    Public FechaTermino As Date
    Public Sueldo As Double
    Public flag As Boolean = False

#End Region

    Public Sub New(ByVal FechaInicio1 As Date, ByVal FechaTermino2 As Date, ByVal Sueldo3 As Double)
        InitializeComponent()
        fecInicio.Value = FechaInicio1
        fecTermino.Value = FechaTermino2
        numSueldo.Value = Sueldo3
    End Sub

    Private Sub frm_FechasContrato_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.btnAprobar.Focus()
    End Sub

    Private Sub btnAprobar_Click(sender As Object, e As EventArgs) Handles btnAprobar.Click
        FechaInicio = fecInicio.Value
        FechaTermino = fecTermino.Value
        Sueldo = numSueldo.Value
        flag = True
        Me.Close()
    End Sub

    Private Sub Boton1_Click(sender As Object, e As EventArgs) Handles Boton1.Click
        Me.Close()
    End Sub

End Class