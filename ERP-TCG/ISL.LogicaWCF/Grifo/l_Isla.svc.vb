' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_Isla" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_Isla.svc o l_Isla.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF

Public Class l_Isla
    Implements Il_Isla

    Dim odIsla As New d_Isla

    Public Function mt_Obtener(oeIsla As e_Isla) As e_Isla Implements Il_Isla.mt_Obtener
        Try
            Return odIsla.mt_Obtener(oeIsla)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Listar(oeIsla As e_Isla) As List(Of e_Isla) Implements Il_Isla.mt_Listar
        Try
            Return odIsla.mt_Listar(oeIsla)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Guardar(oeIsla As e_Isla) As Boolean Implements Il_Isla.mt_Guardar
        Try
            Return odIsla.mt_Guardar(oeIsla)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Eliminar(oeIsla As e_Isla) As Boolean Implements Il_Isla.mt_Eliminar
        Try
            Return odIsla.mt_Eliminar(oeIsla)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
