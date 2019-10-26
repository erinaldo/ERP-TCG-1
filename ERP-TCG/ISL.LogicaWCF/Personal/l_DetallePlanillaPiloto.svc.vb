Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_DetallePlanillaPiloto" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_DetallePlanillaPiloto.svc o l_DetallePlanillaPiloto.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class l_DetallePlanillaPiloto
    Implements Il_DetallePlanillaPiloto

    Private od As New d_DetallePlanillaPiloto

    Public Function Listar(oe As e_DetallePlanillaPiloto) As List(Of e_DetallePlanillaPiloto) Implements Il_DetallePlanillaPiloto.Listar
        Try
            Return od.Listar(oe)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
