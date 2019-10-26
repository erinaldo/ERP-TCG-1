Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_OrdenCmp_OrdenTrb" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_OrdenCmp_OrdenTrb.svc o l_OrdenCmp_OrdenTrb.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class l_OrdenCmp_OrdenTrb
    Implements Il_OrdenCmp_OrdenTrb

    Dim odOrdenCmp_OrdenTrb As New d_OrdenCmp_OrdenTrb

    Public Function Obtener(ByVal oeOrdenCmp_OrdenTrb As e_OrdenCmp_OrdenTrb) As e_OrdenCmp_OrdenTrb Implements Il_OrdenCmp_OrdenTrb.Obtener
        Try
            Return odOrdenCmp_OrdenTrb.Obtener(oeOrdenCmp_OrdenTrb)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeOrdenCmp_OrdenTrb As e_OrdenCmp_OrdenTrb) As Boolean Implements Il_OrdenCmp_OrdenTrb.Guardar
        Try
            Return odOrdenCmp_OrdenTrb.Guardar(oeOrdenCmp_OrdenTrb)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeOrdenCmp_OrdenTrb As e_OrdenCmp_OrdenTrb) As Boolean Implements Il_OrdenCmp_OrdenTrb.Eliminar
        Try
            Return odOrdenCmp_OrdenTrb.Eliminar(oeOrdenCmp_OrdenTrb)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
