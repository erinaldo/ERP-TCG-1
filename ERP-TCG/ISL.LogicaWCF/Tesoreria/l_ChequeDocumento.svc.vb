Imports ISL.AccesoDatos

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_ChequeDocumento" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_ChequeDocumento.svc o l_ChequeDocumento.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class l_ChequeDocumento
    Implements Il_ChequeDocumento
    Dim odChequeDocumento As New d_ChequeDocumento

    Public Function Eliminar(oe As EntidadesWCF.e_ChequeDocumento) As Boolean Implements Il_ChequeDocumento.Eliminar
        Try
            Return odChequeDocumento.Eliminar(oe)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(oe As EntidadesWCF.e_ChequeDocumento) As Boolean Implements Il_ChequeDocumento.Guardar
        Try
            Return odChequeDocumento.Guardar(oe)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oe As EntidadesWCF.e_ChequeDocumento) As List(Of EntidadesWCF.e_ChequeDocumento) Implements Il_ChequeDocumento.Listar
        Try
            Return odChequeDocumento.Listar(oe)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
