' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_Robo" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_Robo.svc o l_Robo.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF

Public Class l_Robo
    Implements Il_Robo

    Dim odRobo As New d_Robo

    Public Function Obtener(ByVal oeRobo As e_Robo) As e_Robo Implements Il_Robo.Obtener
        Try
            Return odRobo.Obtener(oeRobo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeRobo As e_Robo) As List(Of e_Robo) Implements Il_Robo.Listar
        Try
            Return odRobo.Listar(oeRobo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeRobo As e_Robo) As Boolean Implements Il_Robo.Validar
        Try
            With oeRobo
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeRobo As e_Robo) As Boolean Implements Il_Robo.Guardar
        Try
            If Validar(oeRobo) Then
                Return odRobo.Guardar(oeRobo)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeRobo As e_Robo) As Boolean Implements Il_Robo.Eliminar
        Try
            Return odRobo.Eliminar(oeRobo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub DoWork() Implements Il_Robo.DoWork
    End Sub

End Class
