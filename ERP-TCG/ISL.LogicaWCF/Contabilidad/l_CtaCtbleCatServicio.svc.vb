Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_CtaCtbleCatServicio" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_CtaCtbleCatServicio.svc o l_CtaCtbleCatServicio.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class l_CtaCtbleCatServicio
    Implements Il_CtaCtbleCatServicio

    Dim odCtaCtbleCatServicio As New d_CtaCtbleCatServicio

    Public Function Obtener(ByVal oeCtaCtbleCatServicio As e_CtaCtbleCatServicio) As e_CtaCtbleCatServicio Implements Il_CtaCtbleCatServicio.Obtener
        Try
            Return odCtaCtbleCatServicio.Obtener(oeCtaCtbleCatServicio)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeCtaCtbleCatServicio As e_CtaCtbleCatServicio) As List(Of e_CtaCtbleCatServicio) Implements Il_CtaCtbleCatServicio.Listar
        Try
            Return odCtaCtbleCatServicio.Listar(oeCtaCtbleCatServicio)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeCtaCtbleCatServicio As e_CtaCtbleCatServicio) As Boolean Implements Il_CtaCtbleCatServicio.Validar
        Try
            With oeCtaCtbleCatServicio
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeCtaCtbleCatServicio As e_CtaCtbleCatServicio) As Boolean Implements Il_CtaCtbleCatServicio.Guardar
        Try
            If Validar(oeCtaCtbleCatServicio) Then
                Return odCtaCtbleCatServicio.Guardar(oeCtaCtbleCatServicio)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeCtaCtbleCatServicio As e_CtaCtbleCatServicio) As Boolean Implements Il_CtaCtbleCatServicio.Eliminar
        Try
            Return odCtaCtbleCatServicio.Eliminar(oeCtaCtbleCatServicio)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
