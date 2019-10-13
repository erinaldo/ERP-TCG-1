'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Configuration
Imports Infragistics.Win.CalcEngine
Imports Infragistics.Win.UltraWinDataSource
Imports System.Threading
Imports System.Data.OleDb

Public Class frm_Autorizacion
    Public mensajeEmergente As New c_Alertas

#Region "Declaración de variables"

    Dim olCombo As l_Combo
    Dim oeCombo As e_Combo
    Dim ListaJefes As List(Of e_Combo)
    Dim olUsuario As l_Usuario
    Dim oeUsuario As e_Usuario

    Dim olIncidenciasAutentificadas As l_IncidenciasAutentificadas
    Dim oeIncidenciasAutentificadas As e_IncidenciasAutentificadas

    Public Formulario As String
    Public IdActividadNegocio As String
#End Region

    Public Function ObtenerJefes(ByVal Nombre As String, ByVal frm_ As String, ActividadNeg As String) As Boolean
        Try
            olCombo = New l_Combo
            ListaJefes = New List(Of e_Combo)
            cboJefeArea.Clear()
            txtClave.Text = ""
            Formulario = frm_
            IdActividadNegocio = ActividadNeg
            oeCombo = New e_Combo
            oeCombo.Id = "Jefes"
            oeCombo.Nombre = Nombre
            ListaJefes.AddRange(olCombo.Listar(oeCombo))
            LlenarComboMaestro(cboJefeArea, ListaJefes, 1)
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            If Autorizar() Then
                Me.Close()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    ''' <summary>
    ''' Función que autoriza al usuario la ejecución de una tarea determinada
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function Autorizar() As Boolean
        Try
            Dim autorizado As Boolean = False
            olUsuario = New l_Usuario
            oeUsuario = New e_Usuario
            oeUsuario.TipoOperacion = "A"
            oeUsuario.Login = cboJefeArea.Value
            oeUsuario.Clave = txtClave.Text
            oeUsuario = olUsuario.ObtenerAutorizado(oeUsuario)
            If oeUsuario.Id = "" Then Throw New Exception("Usuario o clave incorrecta")
            autorizado = True
            Dim Perfil As String = ""
            For Each Jefes As e_Combo In ListaJefes
                If Jefes.Id.Equals(cboJefeArea.Value) Then
                    Perfil = Jefes.Descripcion
                    Exit For
                End If
            Next
            Select Case Formulario
                Case "frm_Operacion"
                    With IncidenciasPublic
                        .IdArea = gUsuarioSGI.oeArea.Id
                        .IdActividadNegocio = IdActividadNegocio
                        .IdResponsableAutoriza = cboJefeArea.Value
                        .IdUsuarioIncidente = gUsuarioSGI.Id
                        .Glosa = "Cambio de Fecha: " & txtMotivoGlosa.Text.Trim
                        .TipoPerfil = Perfil
                    End With
                Case "frm_Operacion1"
                    With IncidenciasPublic
                        .IdArea = gUsuarioSGI.oeArea.Id
                        .IdActividadNegocio = IdActividadNegocio
                        .IdResponsableAutoriza = cboJefeArea.Value
                        .IdUsuarioIncidente = gUsuarioSGI.Id
                        .Glosa = "Quitar validacion Tarifa: " & txtMotivoGlosa.Text.Trim
                        .TipoPerfil = Perfil
                    End With
                Case "frm_Demanda"
                    With IncidenciasPublic
                        .IdArea = gUsuarioSGI.oeArea.Id
                        .IdActividadNegocio = IdActividadNegocio
                        .IdResponsableAutoriza = cboJefeArea.Value
                        .IdUsuarioIncidente = gUsuarioSGI.Id
                        .Glosa = "Cambio de Estado: " & txtMotivoGlosa.Text.Trim
                        .TipoPerfil = Perfil
                    End With
                Case "frm_Seguimiento"
                    With IncidenciasPublic
                        .IdArea = gUsuarioSGI.oeArea.Id
                        .IdActividadNegocio = IdActividadNegocio
                        .IdResponsableAutoriza = cboJefeArea.Value
                        .IdUsuarioIncidente = gUsuarioSGI.Id
                        .Glosa = "Quitar validacion Reporte Viaje: " & txtMotivoGlosa.Text.Trim
                        .TipoPerfil = Perfil
                    End With
                Case "frm_Seguimiento1"
                    With IncidenciasPublic
                        .IdArea = gUsuarioSGI.oeArea.Id
                        .IdActividadNegocio = IdActividadNegocio
                        .IdResponsableAutoriza = cboJefeArea.Value
                        .IdUsuarioIncidente = gUsuarioSGI.Id
                        .Glosa = "Cambiar de Estado Viaje: " & txtMotivoGlosa.Text.Trim
                        .TipoPerfil = Perfil
                    End With
            End Select
            Return autorizado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        IncidenciasPublic = New e_IncidenciasAutentificadas

        Me.Close()
    End Sub

End Class