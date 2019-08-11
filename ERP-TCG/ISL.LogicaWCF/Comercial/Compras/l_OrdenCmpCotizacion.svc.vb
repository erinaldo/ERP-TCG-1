Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_OrdenCmpCotizacion" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_OrdenCmpCotizacion.svc o l_OrdenCmpCotizacion.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class l_OrdenCmpCotizacion
    Implements Il_OrdenCmpCotizacion


    Dim odOrdenCmpCotizacion As New d_OrdenCmpCotizacion

    Public Function Guardar(ByVal oeOrdenCmpCotizacion As e_OrdenCmpCotizacion) As Boolean Implements Il_OrdenCmpCotizacion.Guardar
        Try
            Return odOrdenCmpCotizacion.Guardar(oeOrdenCmpCotizacion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeOrdenCmpCotizacion As e_OrdenCmpCotizacion) As Boolean Implements Il_OrdenCmpCotizacion.Eliminar
        Try
            Return odOrdenCmpCotizacion.Eliminar(oeOrdenCmpCotizacion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(oeOrdenCmpCotizacion As e_OrdenCmpCotizacion) As e_OrdenCmpCotizacion Implements Il_OrdenCmpCotizacion.Obtener
        Try
            Return odOrdenCmpCotizacion.Obtener(oeOrdenCmpCotizacion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
