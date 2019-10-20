' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_AsignacionFlota" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_AsignacionFlota.svc o l_AsignacionFlota.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_AsignacionFlota
    Implements Il_AsignacionFlota

    Public Sub DoWork() Implements Il_AsignacionFlota.DoWork
    End Sub

    Dim odAsignacionFlota As d_AsignacionFlota

    Public Function Eliminar(ByVal oeAsignacionFlota As e_AsignacionFlota) As Boolean Implements Il_AsignacionFlota.Eliminar
        Try
            odAsignacionFlota = New d_AsignacionFlota
            Return odAsignacionFlota.Eliminar(oeAsignacionFlota)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeAsignacionFlota As e_AsignacionFlota) As Boolean Implements Il_AsignacionFlota.Guardar
        Try
            odAsignacionFlota = New d_AsignacionFlota
            If Validar(oeAsignacionFlota) Then
                Return odAsignacionFlota.Guardar(oeAsignacionFlota)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAsignacionFlota As e_AsignacionFlota) As System.Collections.Generic.List(Of e_AsignacionFlota) Implements Il_AsignacionFlota.Listar
        Try
            odAsignacionFlota = New d_AsignacionFlota
            Return odAsignacionFlota.Listar(oeAsignacionFlota)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeAsignacionFlota As e_AsignacionFlota) As e_AsignacionFlota Implements Il_AsignacionFlota.Obtener
        Try
            odAsignacionFlota = New d_AsignacionFlota
            Return odAsignacionFlota.Obtener(oeAsignacionFlota)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeAsignacionFlota As e_AsignacionFlota) As Boolean Implements Il_AsignacionFlota.Validar
        Try
            With oeAsignacionFlota
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
