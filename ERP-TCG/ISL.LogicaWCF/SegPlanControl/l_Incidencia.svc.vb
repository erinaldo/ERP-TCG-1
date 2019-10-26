' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_Incidencia" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_Incidencia.svc o l_Incidencia.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF

Public Class l_Incidencia
    Implements Il_Incidencia

    Dim odd_Incidencia As New d_Incidencia

    Public Sub DoWork() Implements Il_Incidencia.DoWork
    End Sub

    Public Function Obtener(ByVal oed_Incidencia As e_Incidencia) As e_Incidencia Implements Il_Incidencia.Obtener
        Try
            Return odd_Incidencia.Obtener(oed_Incidencia)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oed_Incidencia As e_Incidencia) As List(Of e_Incidencia) Implements Il_Incidencia.Listar
        Try
            Return odd_Incidencia.Listar(oed_Incidencia)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oed_Incidencia As e_Incidencia) As Boolean Implements Il_Incidencia.Validar
        Try
            With oed_Incidencia

            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oed_Incidencia As e_Incidencia) As Boolean Implements Il_Incidencia.Guardar
        Try
            If Validar(oed_Incidencia) Then
                Return odd_Incidencia.Guardar(oed_Incidencia)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oed_Incidencia As e_Incidencia) As Boolean Implements Il_Incidencia.Eliminar
        Try
            Return odd_Incidencia.Eliminar(oed_Incidencia)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
