' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_VehiculoPilotoOperacion" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_VehiculoPilotoOperacion.svc o l_VehiculoPilotoOperacion.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ISL.EntidadesWCF
Imports ISL.AccesoDatos
Imports System.Runtime.Serialization


<DataContract(), Serializable()> _
Public Class l_VehiculoPilotoOperacion
    Implements Il_VehiculoPilotoOperacion

    Dim odVehiculoPilotoOperacion As New d_VehiculoPilotoOperacion

    'Public Sub DoWork() Implements Il_VehiculoPilotoOperacion.DoWork
    'End Sub
    Public Function Obtener(oeVehiculoPilotoOperacion As e_VehiculoPilotoOperacion) As e_VehiculoPilotoOperacion Implements Il_VehiculoPilotoOperacion.Obtener
        Try
            Return odVehiculoPilotoOperacion.Obtener(oeVehiculoPilotoOperacion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeVehiculoPilotoOperacion As e_VehiculoPilotoOperacion) As List(Of e_VehiculoPilotoOperacion) Implements Il_VehiculoPilotoOperacion.Listar
        Try
            Return odVehiculoPilotoOperacion.Listar(oeVehiculoPilotoOperacion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(oeVehiculoPilotoOperacion As List(Of e_VehiculoPilotoOperacion)) As Boolean Implements Il_VehiculoPilotoOperacion.Guardar
        Try
            Return odVehiculoPilotoOperacion.Guardar(oeVehiculoPilotoOperacion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(oeVehiculoPilotoOperacion As e_VehiculoPilotoOperacion) As Boolean Implements Il_VehiculoPilotoOperacion.Eliminar
        Try
            Return odVehiculoPilotoOperacion.Eliminar(oeVehiculoPilotoOperacion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
