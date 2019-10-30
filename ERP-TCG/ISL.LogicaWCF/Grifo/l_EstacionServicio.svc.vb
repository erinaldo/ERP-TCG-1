' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_EstacionServicio" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_EstacionServicio.svc o l_EstacionServicio.svc.vb en el Explorador de soluciones e inicie la depuración.

' Hola Simpatico

Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF

Public Class l_EstacionServicio
    Implements Il_EstacionServicio

    Dim odEstacionServicio As New d_EstacionServicio

    Public Function mt_Obtener(oeEstacionServicio As e_EstacionServicio) As e_EstacionServicio Implements Il_EstacionServicio.mt_Obtener
        Try
            Return odEstacionServicio.mt_Obtener(oeEstacionServicio)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Listar(oeEstacionServicio As e_EstacionServicio) As List(Of e_EstacionServicio) Implements Il_EstacionServicio.mt_Listar
        Try
            Return odEstacionServicio.mt_Listar(oeEstacionServicio)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Guardar(oeEstacionServicio As e_EstacionServicio) As Boolean Implements Il_EstacionServicio.mt_Guardar
        Try
            Return odEstacionServicio.mt_Guardar(oeEstacionServicio)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Eliminar(oeEstacionServicio As e_EstacionServicio) As Boolean Implements Il_EstacionServicio.mt_Eliminar
        Try
            Return odEstacionServicio.mt_Eliminar(oeEstacionServicio)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
