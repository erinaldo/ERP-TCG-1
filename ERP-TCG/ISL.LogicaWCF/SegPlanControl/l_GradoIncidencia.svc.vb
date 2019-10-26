' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_GradoIncidencia" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_GradoIncidencia.svc o l_GradoIncidencia.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF

Public Class l_GradoIncidencia
    Implements Il_GradoIncidencia

    Public Sub DoWork() Implements Il_GradoIncidencia.DoWork
    End Sub

    Dim odGradoIncidencia As New d_GradoIncidencia

    Public Function Obtener(ByVal oeGradoIncidencia As e_GradoIncidencia) As e_GradoIncidencia Implements Il_GradoIncidencia.Obtener
        Try
            Return odGradoIncidencia.Obtener(oeGradoIncidencia)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGradoIncidencia As e_GradoIncidencia) As List(Of e_GradoIncidencia) Implements Il_GradoIncidencia.Listar
        Try
            Return odGradoIncidencia.Listar(oeGradoIncidencia)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeGradoIncidencia As e_GradoIncidencia) As Boolean Implements Il_GradoIncidencia.Validar
        Try
            With oeGradoIncidencia
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeGradoIncidencia As e_GradoIncidencia) As Boolean Implements Il_GradoIncidencia.Guardar
        Try
            If Validar(oeGradoIncidencia) Then
                Return odGradoIncidencia.Guardar(oeGradoIncidencia)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeGradoIncidencia As e_GradoIncidencia) As Boolean Implements Il_GradoIncidencia.Eliminar
        Try
            Return odGradoIncidencia.Eliminar(oeGradoIncidencia)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
