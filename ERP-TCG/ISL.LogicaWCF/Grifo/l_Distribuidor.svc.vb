' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_Distribuidor" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_Distribuidor.svc o l_Distribuidor.svc.vb en el Explorador de soluciones e inicie la depuración.

Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF

Public Class l_Distribuidor
    Implements Il_Distribuidor

    Dim odDistribuidor As New d_Distribuidor

    Public Function mt_Obtener(oeDistribuidor As e_Distribuidor) As e_Distribuidor Implements Il_Distribuidor.mt_Obtener
        Try
            Return odDistribuidor.mt_Obtener(oeDistribuidor)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Listar(oeDistribuidor As e_Distribuidor) As List(Of e_Distribuidor) Implements Il_Distribuidor.mt_Listar
        Try
            Return odDistribuidor.mt_Listar(oeDistribuidor)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Guardar(oeDistribuidor As e_Distribuidor) As Boolean Implements Il_Distribuidor.mt_Guardar
        Try
            Return odDistribuidor.mt_Guardar(oeDistribuidor)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Eliminar(oeDistribuidor As e_Distribuidor) As Boolean Implements Il_Distribuidor.mt_Eliminar
        Try
            Return odDistribuidor.mt_Eliminar(oeDistribuidor)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
