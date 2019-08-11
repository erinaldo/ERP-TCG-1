Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_Feriados" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_Feriados.svc o l_Feriados.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class l_Feriados
    Implements Il_Feriados

    Dim odFeriados As New d_Feriados

    Public Function Obtener(ByVal oeFeriados As e_Feriados) As e_Feriados Implements Il_Feriados.Obtener
        Try
            Return odFeriados.Obtener(oeFeriados)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeFeriados As e_Feriados) As List(Of e_Feriados) Implements Il_Feriados.Listar
        Try
            Return odFeriados.Listar(oeFeriados)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeFeriados As e_Feriados) As Boolean Implements Il_Feriados.Validar
        Try
            With oeFeriados
                Dim oeFer As New e_Feriados
                oeFer.Fecha = .Fecha
                oeFer = odFeriados.Obtener(oeFer)
                If oeFer.Id <> "" Then
                    Throw New Exception("Dia Feriado ya Registrado. Verificar")
                End If
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeFeriados As e_Feriados) As Boolean Implements Il_Feriados.Guardar
        Try
            If Validar(oeFeriados) Then
                Return odFeriados.Guardar(oeFeriados)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeFeriados As e_Feriados) As Boolean Implements Il_Feriados.Eliminar
        Try
            Return odFeriados.Eliminar(oeFeriados)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
