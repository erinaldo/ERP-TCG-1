' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_RutaPeaje" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_RutaPeaje.svc o l_RutaPeaje.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Public Class l_RutaPeaje
    Implements Il_RutaPeaje
    Private odRutaPeaje As d_RutaPeaje

    Public Function Eliminar(oeRutaPeaje As e_RutaPeaje) As Boolean Implements Il_RutaPeaje.Eliminar
        Try
            odRutaPeaje = New d_RutaPeaje
            Return odRutaPeaje.Eliminar(oeRutaPeaje)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(oeRutaPeaje As e_RutaPeaje) As Boolean Implements Il_RutaPeaje.Guardar
        Try
            odRutaPeaje = New d_RutaPeaje
            Return odRutaPeaje.Guardar(oeRutaPeaje)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeRutaPeaje As e_RutaPeaje) As List(Of e_RutaPeaje) Implements Il_RutaPeaje.Listar
        Try
            odRutaPeaje = New d_RutaPeaje
            Return odRutaPeaje.Listar(oeRutaPeaje)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(oeRutaPeaje As e_RutaPeaje) As e_RutaPeaje Implements Il_RutaPeaje.Obtener
        Try
            odRutaPeaje = New d_RutaPeaje
            Return odRutaPeaje.Obtener(oeRutaPeaje)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
