Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class l_CuotaDocVeh_Movimiento
    Implements Il_CuotaDocVeh_Movimiento

    Dim odCuotaDocVeh_Movimiento As New d_CuotaDocVeh_Movimiento

    Public Function GuardarCancelacion(ByVal oeCuotaDocVeh_Movimiento As e_CuotaDocVeh_Movimiento) As Boolean Implements Il_CuotaDocVeh_Movimiento.GuardarCancelacion
        Try
            Return odCuotaDocVeh_Movimiento.GuardarCancelacion(oeCuotaDocVeh_Movimiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
