'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.Cache
Imports System.Threading
Imports System.Deployment.Application

Public Class frm_MenuPadre

    Inherits System.Windows.Forms.Form


#Region "Declaracion de Variables"

    Public HiloIsl As Thread
    Dim HiloIslInicio As New ThreadStart(AddressOf VerificaHiloIsl)
    Dim MetodoHilo As New MethodInvoker(AddressOf MetodoParalelo)

#End Region

    Public _Activo As Boolean
    ' Public Shared instancia As frm_MenuPadre = Nothing
    Public _Operacion As String = "Inicializa"
    Public l_IdActividadNegocio As String = ""
    'Variable para medir el tiempo de actualización de la información
    Public _tiempo As Integer
    Public mensajeEmergente As New c_Alertas
    Public cache As New ISL.Cache.Cache
    Public pIdActividadNegocio As String
    Public IndMultiInstancia As String
    Public pProcesoNegocio As String

    Public Overridable Sub Consultar()
        _Operacion = "Inicializa"
        If _Activo Then
            ControlBoton(1, 1, 0, 0, 0, 1, 1, 1, 1)
        Else
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        End If
        'Await MensajePC("Consultando")
    End Sub

    Public Overridable Sub Consultar(ByVal Activo As Boolean)
        _Operacion = "Inicializa"
        If Activo Then
            ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
        Else
            ControlBoton(1, 1, 1, 0, 0, 0, 1, 0, 1)
        End If
        'Await MensajePC("Consultando")
    End Sub

    Public Overridable Sub Nuevo()
        _Operacion = "Nuevo"
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        'Await MensajePC("Nuevo")
    End Sub

    Public Overridable Sub Editar()
        _Operacion = "Editar"
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
        'Await MensajePC("Editando")
    End Sub

    Public Overridable Sub Vista()
        _Operacion = "Vista"
        ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 0)
    End Sub

    Public Overridable Sub Guardar()
        ' _Operacion = "Inicializa"
        'ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        'If _Activo Then
        '    ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
        'Else
        '    ControlBoton(1, 1, 1, 0, 0, 0, 1, 0, 1)
        'End If
    End Sub

    Public Overridable Sub Cancelar()
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        'If _Activo Then
        '    ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
        'Else
        '    ControlBoton(1, 1, 1, 0, 0, 0, 1, 0, 1)
        'End If
        'Await MensajePC("Cancelado")
    End Sub

    Public Overridable Sub Eliminar()
    End Sub

    Public Overridable Sub Imprimir()
        _Operacion = "Imprimir"
        'ControlBoton(0, 0, 0, 0, 1, 0, 1, 0, 1)
        'Await MensajePC("Imprimiendo")
    End Sub

    Public Overridable Sub Exportar()
        'Await MensajePC("Exportando")
    End Sub

    Public Overridable Sub Salir()
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        Me.Close()
        'Await MensajePC("Ventana cerrada")
    End Sub

    Public Overridable Sub frm_MenuPadre_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case _Operacion
            Case "Nuevo"
                MyClass.Nuevo()

            Case "Editar"
                MyClass.Editar()

            Case "Inicializa"
                If _Activo Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
        End Select
    End Sub

    Dim inst As frm_MenuPadre = Nothing
    Public Overridable Function getInstancia() As frm_MenuPadre
        Return inst
    End Function

    Public Sub VerificaHiloIsl()
        With True
            BeginInvoke(MetodoHilo)
            Thread.Sleep(120000)
        End With
    End Sub

    Public Sub EjecutaHilo()
        HiloIsl = New Thread(HiloIslInicio)
        HiloIsl.IsBackground = True
        HiloIsl.Name = "HiloIsl"
        HiloIsl.Start()
    End Sub

    Public Overridable Sub MetodoParalelo()

    End Sub

#Region "Control de tiempo de respuesta y actualización"

    Public Overridable Function InicializaTiempo() As Integer
        _tiempo = 60
    End Function

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InicializaTiempo()
    End Sub

    Public Sub Tiempo1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tiempo1.Tick
        If PararTiempo Then
            InicializaTiempo()
        Else
            _tiempo = _tiempo - 1
        End If
    End Sub

#End Region

#Region "Control del Teclado"

    ''' <summary>
    ''' Controla la acción a ejecutar en caso de pulsación de teclas específicas
    ''' </summary>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Public Sub TeclaPulsada(ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case (Keys.F5) AndAlso _Operacion = "Editar"
                Guardar()
            Case (Keys.F6) AndAlso _Operacion = "Editar"
                Cancelar()
            Case (Keys.Enter)
                SendKeys.Send("{TAB}")
            Case Keys.Insert
                Nuevo()
            Case Keys.Add
                Nuevo()
            Case Keys.F3
                Nuevo()
            Case Keys.Multiply
                Editar()
            Case Keys.Delete And _Operacion <> "Editar"
                Eliminar()
                'Case Keys.Delete And _Operacion <> "Editar"
                '    Eliminar()
            Case Keys.Subtract And _Operacion <> "Editar"
                Eliminar()
            Case Keys.Escape
                Cancelar()
        End Select
    End Sub

#End Region


    ''' <summary>
    ''' Evento que permite mostrar al usuario las actualizaciones que se publican
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ControlDeVersion_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlDeVersion.Tick
        'Dim informacion As UpdateCheckInfo = Nothing
        'Dim actualizacion As ApplicationDeployment

        'If ApplicationDeployment.IsNetworkDeployed Then

        '    ControlDeVersion.Enabled = False
        '    actualizacion = ApplicationDeployment.CurrentDeployment
        '    Try
        '        informacion = actualizacion.CheckForDetailedUpdate
        '    Catch dde As DeploymentDownloadException
        '        MessageBox.Show("La nueva versión de la aplicación no se puede descargar en este momento." & Environment.NewLine() & "Verifique su conexión, Error: " & dde.Message)
        '    Catch ide As InvalidDeploymentException
        '        MessageBox.Show("Problemas en la aplicación que controla las versiones diponibles, Error: " & ide.Message)
        '    Catch ioe As Exception
        '        MessageBox.Show("No se puede actualizar esta versión de la aplicación, Error " & ioe.Message)
        '    End Try

        '    If informacion.UpdateAvailable Then
        '        Try

        '            If MostrarMensajeActualizarSGI = False Then

        '                MostrarMensajeActualizarSGI = True

        '                If MessageBox.Show("Se ha publicado una nueva versión del sistema" & Environment.NewLine & "Para aplicar dichos cambios es necesario reiniciar la aplicación" & Environment.NewLine & "¿Desea reiniciar el SGI y actualizar la versión?", _
        '                        "Control de versiones SGI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
        '                    actualizacion.Update()
        '                    Application.Restart()
        '                Else
        '                    MostrarMensajeActualizarSGI = False
        '                End If

        '            End If

        '        Catch dde As DeploymentDownloadException
        '            MessageBox.Show("No se puede instalar la última versión de la aplicación" & Environment.NewLine() & "Verifique su conexión, Error: " & dde.Message)
        '        End Try
        '    End If
        'End If

        'ControlDeVersion.Enabled = True

    End Sub

End Class