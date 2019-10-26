'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Configuration
Imports Infragistics.Win.CalcEngine
Imports Infragistics.Win.UltraWinDataSource


Public Class frm_AutenticarTrabajador

    Inherits frm_MenuPadre

    Private Shared instancia As frm_AutenticarTrabajador = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_AutenticarTrabajador()
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Declaración de variables"

    Dim oeTrabajador As New e_Trabajador
    Dim olTrabajador As New l_Trabajador
    Dim lstTrabajador As New List(Of e_Trabajador)
    Public IdArea As String = ""
    Public idTrabajador As String = ""
    Public _band As Boolean = False, _idtrab As String = ""

#End Region

#Region "Eventos"

    Private Sub frm_AutenticarTrabajador_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Select Case Operacion
            Case "Nuevo"

            Case "Editar"

            Case "Inicializa"

            Case "Autenticar"

        End Select
    End Sub

    Private Sub frm_AutenticarTrabajador_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_AutenticarTrabajador_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Select Case Operacion
            Case "Nuevo"
                Me.Activate()
                Me.Cancelar()

            Case "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
    End Sub

    Private Sub frm_AutenticarTrabajador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Inicializar()
        txtClaveSeguridad.Value = String.Empty
        If _band Then
            cboTrabajador.Value = _idtrab
            cboTrabajador.ReadOnly = True
            txtClaveSeguridad.Focus()
        End If
    End Sub

    Private Sub txtClaveSeguridad_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtClaveSeguridad.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If ValidarClaveIngresada() Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            Catch ex As Exception
                mensajeEmergente.Problema(ex.Message, True)
            End Try

        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            If ValidarClaveIngresada() Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

#End Region

#Region "Métodos"

    Public Sub Inicializar()

        oeTrabajador.Id = "0"
        oeTrabajador.oePersona.ApellidoPaterno = " ---SELECCIONE TRABAJADOR--- "
        lstTrabajador.Add(oeTrabajador)
        oeTrabajador = New e_Trabajador
        oeTrabajador.TipoOperacion = "N"

        lstTrabajador.AddRange(olTrabajador.Listar(oeTrabajador))
        Dim _leTrabAux = From le In lstTrabajador _
                         Select le.Id, le.oePersona.NombreCompleto, le.Activo, le.IndEstado, le.Disponible _
                         Where Activo = True And IndEstado = 1 And Disponible = True _
                         Order By NombreCompleto
        LlenarComboMaestro(cboTrabajador, _leTrabAux.ToList, 0)
        cboTrabajador.DropDownStyle = DropDownStyle.DropDown
        cboTrabajador.AutoCompleteMode = AutoCompleteMode.SuggestAppend

    End Sub

    ''' <summary>
    ''' Función para validar la clave de trabajador ingresada por el usuario
    ''' </summary>
    ''' <remarks></remarks>
    Public Function ValidarClaveIngresada() As Boolean
        Try
            Dim claveValida As Boolean = False
            Dim oeTra As New e_Trabajador

            If cboTrabajador.Value Is Nothing OrElse _
            cboTrabajador.Value = "0" Then Throw New Exception("Seleccione trabajador.")
            If txtClaveSeguridad.Value Is Nothing OrElse _
            txtClaveSeguridad.Value.ToString.Trim = "" Then Throw New Exception("Ingrese clave.")
            'oeTrabajador.Id = cboTrabajador.Value
            'oeTrabajador.ClaveSeguridad = txtClaveSeguridad.Value
            'oeTra = olTrabajador.ObtenerObjeto(oeTrabajador)
            'If oeTra.Id = "" Then
            '    Throw New Exception("Clave incorrecta")
            'Else
            '    claveValida = True
            '    idTrabajador = oeTra.Id
            'End If
            oeTra.TipoBusca = 1
            oeTra.Id = cboTrabajador.Value
            If lstTrabajador.Contains(oeTra) Then
                oeTra = lstTrabajador.Item(lstTrabajador.IndexOf(oeTra))
                If oeTra.ClaveSeguridad.Trim = txtClaveSeguridad.Value.ToString.Trim Then
                    claveValida = True
                    idTrabajador = oeTra.Id
                Else
                    Throw New Exception("Clave incorrecta")
                End If
            End If
            Return claveValida
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region


End Class
