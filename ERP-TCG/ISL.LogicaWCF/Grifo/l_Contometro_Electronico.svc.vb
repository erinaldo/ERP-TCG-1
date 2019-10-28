' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_Contometro_Electronico" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_Contometro_Electronico.svc o l_Contometro_Electronico.svc.vb en el Explorador de soluciones e inicie la depuración.

Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF

Public Class l_Contometro_Electronico
    Implements Il_Contometro_Electronico

    Dim odContometro_Electronico As New d_Contometro_Electronico

    Public Function mt_Obtener(oeContometro_Electronico As e_Contometro_Electronico) As e_Contometro_Electronico Implements Il_Contometro_Electronico.mt_Obtener
        Try
            Return odContometro_Electronico.mt_Obtener(oeContometro_Electronico)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Listar(oeContometro_Electronico As e_Contometro_Electronico) As List(Of e_Contometro_Electronico) Implements Il_Contometro_Electronico.mt_Listar
        Try
            Return odContometro_Electronico.mt_Listar(oeContometro_Electronico)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Guardar(oeContometro_Electronico As e_Contometro_Electronico) As Boolean Implements Il_Contometro_Electronico.mt_Guardar
        Try
            Return odContometro_Electronico.mt_Guardar(oeContometro_Electronico)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function mt_Eliminar(oeContometro_Electronico As e_Contometro_Electronico) As Boolean Implements Il_Contometro_Electronico.mt_Eliminar
        Try
            Return odContometro_Electronico.mt_Eliminar(oeContometro_Electronico)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
