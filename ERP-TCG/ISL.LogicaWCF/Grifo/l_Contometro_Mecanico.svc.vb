' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_Contometro_Mecanico" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_Contometro_Mecanico.svc o l_Contometro_Mecanico.svc.vb en el Explorador de soluciones e inicie la depuración.

Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF

Public Class l_Contometro_Mecanico
    Implements Il_Contometro_Mecanico

    Dim odContometro_Mecanico As New d_Contometro_Mecanico

    Public Function mt_Obtener(oeContometro_Mecanico As e_Contometro_Mecanico) As e_Contometro_Mecanico Implements Il_Contometro_Mecanico.mt_Obtener
        Try
            Return odContometro_Mecanico.mt_Obtener(oeContometro_Mecanico)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Listar(oeContometro_Mecanico As e_Contometro_Mecanico) As List(Of e_Contometro_Mecanico) Implements Il_Contometro_Mecanico.mt_Listar
        Try
            Return odContometro_Mecanico.mt_Listar(oeContometro_Mecanico)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Guardar(oeContometro_Mecanico As e_Contometro_Mecanico) As Boolean Implements Il_Contometro_Mecanico.mt_Guardar
        Try
            Return odContometro_Mecanico.mt_Guardar(oeContometro_Mecanico)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Eliminar(oeContometro_Mecanico As e_Contometro_Mecanico) As Boolean Implements Il_Contometro_Mecanico.mt_Eliminar
        Try
            Return odContometro_Mecanico.mt_Eliminar(oeContometro_Mecanico)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
