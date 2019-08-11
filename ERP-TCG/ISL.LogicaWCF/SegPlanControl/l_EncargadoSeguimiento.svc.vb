' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_EncargadoSeguimiento" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_EncargadoSeguimiento.svc o l_EncargadoSeguimiento.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF

Public Class l_EncargadoSeguimiento
    Implements Il_EncargadoSeguimiento

    Dim odEncargadoSeguimiento As New d_EncargadoSeguimiento

    Public Function Obtener(ByVal oeEncargadoSeguimiento As e_EncargadoSeguimiento) As e_EncargadoSeguimiento Implements Il_EncargadoSeguimiento.Obtener
        Try
            Return odEncargadoSeguimiento.Obtener(oeEncargadoSeguimiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeEncargadoSeguimiento As e_EncargadoSeguimiento) As List(Of e_EncargadoSeguimiento) Implements Il_EncargadoSeguimiento.Listar
        Try
            Return odEncargadoSeguimiento.Listar(oeEncargadoSeguimiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeEncargadoSeguimiento As e_EncargadoSeguimiento) As Boolean Implements Il_EncargadoSeguimiento.Validar
        Try
            With oeEncargadoSeguimiento
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeEncargadoSeguimiento As e_EncargadoSeguimiento) As Boolean Implements Il_EncargadoSeguimiento.Guardar
        Try
            If Validar(oeEncargadoSeguimiento) Then
                Return odEncargadoSeguimiento.Guardar(oeEncargadoSeguimiento)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeEncargadoSeguimiento As e_EncargadoSeguimiento) As Boolean Implements Il_EncargadoSeguimiento.Eliminar
        Try
            Return odEncargadoSeguimiento.Eliminar(oeEncargadoSeguimiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub DoWork() Implements Il_EncargadoSeguimiento.DoWork
    End Sub

End Class
