Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_DespachoOperaciones" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_DespachoOperaciones.svc o l_DespachoOperaciones.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class l_DespachoOperaciones
    Implements Il_DespachoOperaciones

    Private odDespachoOperaciones As New d_DespachoOperaciones

    Public Function Obtener(oeDespachoOperaciones As e_DespachoOperaciones) As e_DespachoOperaciones Implements Il_DespachoOperaciones.Obtener

        Try
            oeDespachoOperaciones = odDespachoOperaciones.Obtener(oeDespachoOperaciones)
            Return oeDespachoOperaciones
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeDespachoOperaciones As e_DespachoOperaciones) As List(Of e_DespachoOperaciones) Implements Il_DespachoOperaciones.Listar
        Try
            Return odDespachoOperaciones.Listar(oeDespachoOperaciones)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeDespachoOperaciones As e_DespachoOperaciones) As Boolean Implements Il_DespachoOperaciones.Guardar
        Try
            Return odDespachoOperaciones.Guardar(oeDespachoOperaciones)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(oeDespachoOperaciones As e_DespachoOperaciones) As Boolean Implements Il_DespachoOperaciones.Eliminar
        Try
            Return odDespachoOperaciones.Eliminar(oeDespachoOperaciones)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
