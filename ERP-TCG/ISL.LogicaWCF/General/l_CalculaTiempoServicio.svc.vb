' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_CalculaTiempoServicio" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_CalculaTiempoServicio.svc o l_CalculaTiempoServicio.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_CalculaTiempoServicio
    Implements Il_CalculaTiempoServicio

    Dim odCalculaTiempoServicio As New d_CalculaTiempoServiciovb

    Public Function Obtener(ByVal oeCalculaTiempoServicio As e_CalculaTiempoServicio) As e_CalculaTiempoServicio Implements Il_CalculaTiempoServicio.Obtener
        Try
            Return odCalculaTiempoServicio.Obtener(oeCalculaTiempoServicio)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
