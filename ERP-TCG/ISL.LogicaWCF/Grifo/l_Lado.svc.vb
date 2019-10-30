' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_Lado" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_Lado.svc o l_Lado.svc.vb en el Explorador de soluciones e inicie la depuración.

Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF

Public Class l_Lado
    Implements Il_Lado

    Dim odLado As New d_Lado

    Public Function mt_Obtener(oeLado As e_Lado) As e_Lado Implements Il_Lado.mt_Obtener
        Try
            Return odLado.mt_Obtener(oeLado)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Listar(oeLado As e_Lado) As List(Of e_Lado) Implements Il_Lado.mt_Listar
        Try
            Return odLado.mt_Listar(oeLado)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Guardar(oeLado As e_Lado) As Boolean Implements Il_Lado.mt_Guardar
        Try
            Return odLado.mt_Guardar(oeLado)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Eliminar(oeLado As e_Lado) As Boolean Implements Il_Lado.mt_Eliminar
        Try
            Return odLado.mt_Eliminar(oeLado)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
