' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_VehiculoTarjeta" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_VehiculoTarjeta.svc o l_VehiculoTarjeta.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Public Class l_VehiculoTarjeta
    Implements Il_VehiculoTarjeta
    Private odVehiculoTarjeta As d_VehiculoTarjeta

    Public Function Eliminar(oeVehiculoTarjeta As e_VehiculoTarjeta) As Boolean Implements Il_VehiculoTarjeta.Eliminar
        Try
            odVehiculoTarjeta = New d_VehiculoTarjeta
            Return odVehiculoTarjeta.Eliminar(oeVehiculoTarjeta)
        Catch ex As Exception
            Throw ex
        End Try   
    End Function

    Public Function Guardar(oeVehiculoTarjeta As e_VehiculoTarjeta) As Boolean Implements Il_VehiculoTarjeta.Guardar
        Try
            odVehiculoTarjeta = New d_VehiculoTarjeta
            Return odVehiculoTarjeta.Guardar(oeVehiculoTarjeta)
        Catch ex As Exception
            Throw ex
        End Try     
    End Function

    Public Function Listar(oeVehiculoTarjeta As e_VehiculoTarjeta) As List(Of e_VehiculoTarjeta) Implements Il_VehiculoTarjeta.Listar
        Try
            odVehiculoTarjeta = New d_VehiculoTarjeta
            Return odVehiculoTarjeta.Listar(oeVehiculoTarjeta)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(oeVehiculoTarjeta As e_VehiculoTarjeta) As e_VehiculoTarjeta Implements Il_VehiculoTarjeta.Obtener
        Try
            odVehiculoTarjeta = New d_VehiculoTarjeta
            Return odVehiculoTarjeta.Obtener(oeVehiculoTarjeta)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
