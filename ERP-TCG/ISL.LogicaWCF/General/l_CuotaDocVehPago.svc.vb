Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class l_CuotaDocVehPago
    Implements Il_CuotaDocVehPago

    Dim odCuotaDocVehPago As New d_CuotaDocVehPago

    Public Function Listar(ByVal oeCuotaDocVehPago As e_CuotaDocVehPago) As List(Of e_CuotaDocVehPago) Implements Il_CuotaDocVehPago.Listar
        Try
            Return odCuotaDocVehPago.Listar(oeCuotaDocVehPago)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
