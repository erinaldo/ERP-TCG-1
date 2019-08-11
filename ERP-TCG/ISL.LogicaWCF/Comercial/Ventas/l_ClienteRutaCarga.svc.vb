Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_ClienteRutaCarga" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_ClienteRutaCarga.svc o l_ClienteRutaCarga.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class l_ClienteRutaCarga
    Implements Il_ClienteRutaCarga

    Dim odClienteRutaCarga As New d_ClienteRutaCarga

    Public Function Obtener(ByVal oeClienteRutaCarga As e_ClienteRutaCarga) As e_ClienteRutaCarga Implements Il_ClienteRutaCarga.Obtener
        Try
            Return odClienteRutaCarga.Obtener(oeClienteRutaCarga)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeClienteRutaCarga As e_ClienteRutaCarga) As List(Of e_ClienteRutaCarga) Implements Il_ClienteRutaCarga.Listar
        Try
            Return odClienteRutaCarga.Listar(oeClienteRutaCarga)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeClienteRutaCarga As e_ClienteRutaCarga) As Boolean Implements Il_ClienteRutaCarga.Validar
        Try
            With oeClienteRutaCarga
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeClienteRutaCarga As e_ClienteRutaCarga) As Boolean Implements Il_ClienteRutaCarga.Guardar
        Try
            If Validar(oeClienteRutaCarga) Then
                Return odClienteRutaCarga.Guardar(oeClienteRutaCarga)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeClienteRutaCarga As e_ClienteRutaCarga) As Boolean Implements Il_ClienteRutaCarga.Eliminar
        Try
            Return odClienteRutaCarga.Eliminar(oeClienteRutaCarga)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
