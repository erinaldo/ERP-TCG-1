Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_SeguimientoMonitoreo" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_SeguimientoMonitoreo.svc o l_SeguimientoMonitoreo.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class l_SeguimientoMonitoreo
    Implements Il_SeguimientoMonitoreo

    Dim odSeguimientoMonitoreo As New d_SeguimientoMonitoreo

    Public Function Obtener(ByVal oeSeguimientoMonitoreo As e_SeguimientoMonitoreo) As e_SeguimientoMonitoreo Implements Il_SeguimientoMonitoreo.Obtener
        Try
            Return odSeguimientoMonitoreo.Obtener(oeSeguimientoMonitoreo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeSeguimientoMonitoreo As e_SeguimientoMonitoreo) As List(Of e_SeguimientoMonitoreo) Implements Il_SeguimientoMonitoreo.Listar
        Try
            Return odSeguimientoMonitoreo.Listar(oeSeguimientoMonitoreo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeSeguimientoMonitoreo As e_SeguimientoMonitoreo) As Boolean Implements Il_SeguimientoMonitoreo.Validar
        Try
            With oeSeguimientoMonitoreo
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeSeguimientoMonitoreo As e_SeguimientoMonitoreo) As Boolean Implements Il_SeguimientoMonitoreo.Guardar
        Try
            If Validar(oeSeguimientoMonitoreo) Then
                Return odSeguimientoMonitoreo.Guardar(oeSeguimientoMonitoreo)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeSeguimientoMonitoreo As e_SeguimientoMonitoreo) As Boolean Implements Il_SeguimientoMonitoreo.Eliminar
        Try
            Return odSeguimientoMonitoreo.Eliminar(oeSeguimientoMonitoreo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub DoWork() Implements Il_SeguimientoMonitoreo.DoWork
    End Sub

End Class
