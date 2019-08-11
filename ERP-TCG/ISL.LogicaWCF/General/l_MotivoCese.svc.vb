Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_MotivoCese" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_MotivoCese.svc o l_MotivoCese.svc.vb en el Explorador de soluciones e inicie la depuración.

Public Class l_MotivoCese
    Implements Il_MotivoCese

    Dim odMotivoCese As New d_MotivoCese

    Public Function Obtener(ByVal oeMotivoCese As e_MotivoCese) As e_MotivoCese Implements Il_MotivoCese.Obtener
        Try
            Return odMotivoCese.Obtener(oeMotivoCese)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeMotivoCese As e_MotivoCese) As List(Of e_MotivoCese) Implements Il_MotivoCese.Listar
        Try
            Return odMotivoCese.Listar(oeMotivoCese)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeMotivoCese As e_MotivoCese) As Boolean Implements Il_MotivoCese.Validar
        Try
            With oeMotivoCese
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeMotivoCese As e_MotivoCese) As Boolean Implements Il_MotivoCese.Guardar
        Try
            If Validar(oeMotivoCese) Then
                Return odMotivoCese.Guardar(oeMotivoCese)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeMotivoCese As e_MotivoCese) As Boolean Implements Il_MotivoCese.Eliminar
        Try
            Return odMotivoCese.Eliminar(oeMotivoCese)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
