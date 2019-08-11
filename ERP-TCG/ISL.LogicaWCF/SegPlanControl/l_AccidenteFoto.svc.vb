Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_AccidenteFoto" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_AccidenteFoto.svc o l_AccidenteFoto.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class l_AccidenteFoto
    Implements Il_AccidenteFoto
    Private odAccidenteFoto As New d_AccidenteFoto

    Public Function Eliminar(oe As e_AccidenteFoto) As Boolean Implements Il_AccidenteFoto.Eliminar
        Try
            Return odAccidenteFoto.Eliminar(oe)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(oe As e_AccidenteFoto) As Boolean Implements Il_AccidenteFoto.Guardar
        Try
            Return odAccidenteFoto.Guardar(oe)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oe As e_AccidenteFoto) As List(Of e_AccidenteFoto) Implements Il_AccidenteFoto.Listar
        Try
            Return odAccidenteFoto.Listar(oe)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(oe As e_AccidenteFoto) As e_AccidenteFoto Implements Il_AccidenteFoto.Obtener
        Try
            Return odAccidenteFoto.Obtener(oe)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
