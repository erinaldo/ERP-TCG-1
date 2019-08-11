' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_AccidenteIncidencia" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_AccidenteIncidencia.svc o l_AccidenteIncidencia.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF

Public Class l_AccidenteIncidencia
    Implements Il_AccidenteIncidencia

    Dim odAccidenteIncidencia As New d_AccidenteIncidencia

    Public Function Obtener(ByVal oeAccidenteIncidencia As e_AccidenteIncidencia) As e_AccidenteIncidencia Implements Il_AccidenteIncidencia.Obtener
        Try
            Return odAccidenteIncidencia.Obtener(oeAccidenteIncidencia)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAccidenteIncidencia As e_AccidenteIncidencia) As List(Of e_AccidenteIncidencia) Implements Il_AccidenteIncidencia.Listar
        Try
            Return odAccidenteIncidencia.Listar(oeAccidenteIncidencia)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeAccidenteIncidencia As e_AccidenteIncidencia) As Boolean Implements Il_AccidenteIncidencia.Validar
        Try
            With oeAccidenteIncidencia
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeAccidenteIncidencia As e_AccidenteIncidencia) As Boolean Implements Il_AccidenteIncidencia.Guardar
        Try
            If Validar(oeAccidenteIncidencia) Then
                Return odAccidenteIncidencia.Guardar(oeAccidenteIncidencia)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeAccidenteIncidencia As e_AccidenteIncidencia) As Boolean Implements Il_AccidenteIncidencia.Eliminar
        Try
            Return odAccidenteIncidencia.Eliminar(oeAccidenteIncidencia)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub DoWork() Implements Il_AccidenteIncidencia.DoWork
    End Sub
End Class
