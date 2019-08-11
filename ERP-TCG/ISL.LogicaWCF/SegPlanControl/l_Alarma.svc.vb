' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_Alarma" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_Alarma.svc o l_Alarma.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF

Public Class l_Alarma
    Implements Il_Alarma

    Dim odAlarma As New d_Alarma

    Public Function Obtener(ByVal oeAlarma As e_Alarma) As e_Alarma Implements Il_Alarma.Obtener
        Try
            Return odAlarma.Obtener(oeAlarma)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAlarma As e_Alarma) As List(Of e_Alarma) Implements Il_Alarma.Listar
        Try
            Return odAlarma.Listar(oeAlarma)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeAlarma As e_Alarma) As Boolean Implements Il_Alarma.Validar
        Try
            With oeAlarma
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeAlarma As e_Alarma) As Boolean Implements Il_Alarma.Guardar
        Try
            If Validar(oeAlarma) Then
                Return odAlarma.Guardar(oeAlarma)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeAlarma As e_Alarma) As Boolean Implements Il_Alarma.Eliminar
        Try
            Return odAlarma.Eliminar(oeAlarma)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub DoWork() Implements Il_Alarma.DoWork
    End Sub

End Class
