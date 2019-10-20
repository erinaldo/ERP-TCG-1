' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_PeajeTarifa" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_PeajeTarifa.svc o l_PeajeTarifa.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Public Class l_PeajeTarifa
    Implements Il_PeajeTarifa

    Private odPeajeTarifa As d_PeajeTarifa

    Public Function Eliminar(oePeajeTarifa As e_PeajeTarifa) As Boolean Implements Il_PeajeTarifa.Eliminar
        Try
            odPeajeTarifa = New d_PeajeTarifa
            Return odPeajeTarifa.Eliminar(oePeajeTarifa)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(oePeajeTarifa As e_PeajeTarifa) As Boolean Implements Il_PeajeTarifa.Guardar
        Try
            odPeajeTarifa = New d_PeajeTarifa
            Return odPeajeTarifa.Guardar(oePeajeTarifa)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oePeajeTarifa As e_PeajeTarifa) As List(Of e_PeajeTarifa) Implements Il_PeajeTarifa.Listar
        Try
            odPeajeTarifa = New d_PeajeTarifa
            Return odPeajeTarifa.Listar(oePeajeTarifa)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(oePeajeTarifa As e_PeajeTarifa) As e_PeajeTarifa Implements Il_PeajeTarifa.Obtener
        Try
            odPeajeTarifa = New d_PeajeTarifa
            Return odPeajeTarifa.Obtener(oePeajeTarifa)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
