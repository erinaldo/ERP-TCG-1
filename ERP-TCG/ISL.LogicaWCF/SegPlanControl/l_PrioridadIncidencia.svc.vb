' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_PrioridadIncidencia" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_PrioridadIncidencia.svc o l_PrioridadIncidencia.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF

Public Class l_PrioridadIncidencia
    Implements Il_PrioridadIncidencia

    Public Sub DoWork() Implements Il_PrioridadIncidencia.DoWork
    End Sub

    Dim odPrioridadIncidencia As New d_PrioridadIncidencia

    Public Function Obtener(ByVal oePrioridadIncidencia As e_PrioridadIncidencia) As e_PrioridadIncidencia Implements Il_PrioridadIncidencia.Obtener
        Try
            Return odPrioridadIncidencia.Obtener(oePrioridadIncidencia)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oePrioridadIncidencia As e_PrioridadIncidencia) As List(Of e_PrioridadIncidencia) Implements Il_PrioridadIncidencia.Listar
        Try
            Return odPrioridadIncidencia.Listar(oePrioridadIncidencia)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oePrioridadIncidencia As e_PrioridadIncidencia) As Boolean Implements Il_PrioridadIncidencia.Validar
        Try
            With oePrioridadIncidencia
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oePrioridadIncidencia As e_PrioridadIncidencia) As Boolean Implements Il_PrioridadIncidencia.Guardar
        Try
            If Validar(oePrioridadIncidencia) Then
                Return odPrioridadIncidencia.Guardar(oePrioridadIncidencia)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oePrioridadIncidencia As e_PrioridadIncidencia) As Boolean Implements Il_PrioridadIncidencia.Eliminar
        Try
            Return odPrioridadIncidencia.Eliminar(oePrioridadIncidencia)
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
