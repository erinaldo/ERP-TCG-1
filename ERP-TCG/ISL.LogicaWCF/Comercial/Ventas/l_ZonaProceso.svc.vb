' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_ZonaProceso" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_ZonaProceso.svc o l_ZonaProceso.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ISL.EntidadesWCF
Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_ZonaProceso
    Implements Il_ZonaProceso

    'Public Sub DoWork() Implements Il_ZonaProceso.DoWork
    'End Sub

    Dim odZonaProceso As New d_ZonaProceso

    Public Function Obtener(oeZonaProceso As e_ZonaProceso) As e_ZonaProceso Implements Il_ZonaProceso.Obtener
        Try
            Return odZonaProceso.Obtener(oeZonaProceso)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeZonaProceso As e_ZonaProceso) As List(Of e_ZonaProceso) Implements Il_ZonaProceso.Listar
        Try
            Return odZonaProceso.Listar(oeZonaProceso)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(oeZonaProceso As e_ZonaProceso) As Boolean Implements Il_ZonaProceso.Guardar
        Try
            Return odZonaProceso.Guardar(oeZonaProceso)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(oeZonaProceso As e_ZonaProceso) As Boolean Implements Il_ZonaProceso.Eliminar
        Try
            Return odZonaProceso.Eliminar(oeZonaProceso)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
