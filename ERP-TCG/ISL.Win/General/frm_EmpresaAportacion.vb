Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF

Public Class frm_EmpresaAportacion
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializacion"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_EmpresaAportacion = Nothing
    Private Shared Operacion As String
    Private Estado As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_EmpresaAportacion()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private WithEvents oeEmpresaAportacion As New e_EmpresaAportacion
    Private olEmpresaAportacion As New l_EmpresaAportacion

    Public IdEmpresa As String = ""

#End Region

#Region "Eventos"

    Private Sub frm_EmpresaAportacion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_EmpresaAportacion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_EmpresaAportacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarEmpresa()
    End Sub

    Private Sub btnAprobar_Click(sender As Object, e As EventArgs) Handles btnAprobar.Click
        Try
            If GuardarEmpresa() Then Me.Close()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub fecFechaNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles fecFechaNacimiento.ValueChanged
        If fecFechaNacimiento.Value.Date < Date.Parse("01/08/1973") Then
            Me.Agrupacion2.Enabled = False
        Else
            Me.Agrupacion2.Enabled = True
        End If
    End Sub

    Private Sub Boton1_Click(sender As Object, e As EventArgs) Handles Boton1.Click
        Me.Close()
    End Sub

    Private Sub Ficha1_SelectedTabChanged(sender As Object, e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles Ficha1.SelectedTabChanged
        Select Case Ficha1.SelectedTab.Index
            Case 0
                Me.rbComFLujo.Checked = True
                Me.rbMixtaFlujo.Checked = False
                Me.rbMixtaSaldo.Checked = False
            Case 1
                Me.rbComFLujo.Checked = False
                Me.rbMixtaFlujo.Checked = True
                Me.rbMixtaSaldo.Checked = False
        End Select
    End Sub

#End Region

#Region "Metodos"

    Private Sub LlenarEmpresa()
        Dim oeEmpresa As New e_Empresa
        Dim olEmpresa As New l_Empresa
        oeEmpresa.IdTipoEmpresa = "1CH000000005"
        LlenarCombo(cboEmpresa, "Nombre", olEmpresa.Listar(oeEmpresa), -1)
    End Sub

    Private Function GuardarEmpresa() As Boolean
        Try
            With oeEmpresaAportacion
                .TipoOperacion = "I"
                .IdEmpresa = IdEmpresa
                If Me.Agrupacion2.Enabled Then
                    .IdEmpresaPensiones = cboEmpresa.Value
                    .IndSistemaPension = IIf(rbSisNacional.Checked, 0, 1)
                    .IndComisionAFP = IIf(rbComFLujo.Checked, 0, IIf(rbMixtaFlujo.Checked, 1, 2))
                Else
                    .IdEmpresaPensiones = ""
                    .IndSistemaPension = 2
                    .IndComisionAFP = 3
                End If
                If ObtenerFechaServidor().Date.Year - fecFechaNacimiento.Value.Year < 18 Then Throw New Exception("Edad Menor a 18 años. Verificar")
                .FechaNacimiento = fecFechaNacimiento.Value
                .UsuarioCreacion = gUsuarioSGI.Id
            End With
            If Not olEmpresaAportacion.Guardar(oeEmpresaAportacion) Then
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region
    
End Class