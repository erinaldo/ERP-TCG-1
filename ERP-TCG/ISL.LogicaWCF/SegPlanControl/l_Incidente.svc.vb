' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_Incidente" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_Incidente.svc o l_Incidente.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF

Public Class l_Incidente
    Implements Il_Incidente

    Dim odIncidente As New d_Incidente

    Public Function Obtener(ByVal oeIncidente As e_Incidente) As e_Incidente Implements Il_Incidente.Obtener
        Try
            Return odIncidente.Obtener(oeIncidente)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeIncidente As e_Incidente) As List(Of e_Incidente) Implements Il_Incidente.Listar
        Try
            Return odIncidente.Listar(oeIncidente)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeIncidente As e_Incidente) As Boolean Implements Il_Incidente.Validar
        Try
            With oeIncidente
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeIncidente As e_Incidente) As Boolean Implements Il_Incidente.Guardar
        Try
            If Validar(oeIncidente) Then
                Return odIncidente.Guardar(oeIncidente)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeIncidente As e_Incidente) As Boolean Implements Il_Incidente.Eliminar
        Try
            Return odIncidente.Eliminar(oeIncidente)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub DoWork() Implements Il_Incidente.DoWork
    End Sub

End Class
