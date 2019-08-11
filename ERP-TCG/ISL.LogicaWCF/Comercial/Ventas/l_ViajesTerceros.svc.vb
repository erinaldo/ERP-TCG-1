' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_ViajesTerceros" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_ViajesTerceros.svc o l_ViajesTerceros.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ISL.EntidadesWCF
Imports ISL.AccesoDatos

Public Class l_ViajesTerceros
    Implements Il_ViajesTerceros

    'Public Sub DoWork() Implements Il_ViajesTerceros.DoWork
    'End Sub
    Dim odViajesTerceros As New d_ViajesTerceros

    Public Function Obtener(ByVal oeViajesTerceros As e_ViajesTerceros) As e_ViajesTerceros Implements Il_ViajesTerceros.Obtener
        Try
            Return odViajesTerceros.Obtener(oeViajesTerceros)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeViajesTerceros As e_ViajesTerceros) As List(Of e_ViajesTerceros) Implements Il_ViajesTerceros.Listar
        Try
            Return odViajesTerceros.Listar(oeViajesTerceros)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeViajesTerceros As e_ViajesTerceros) As Boolean Implements Il_ViajesTerceros.Validar
        Try
            With odViajesTerceros
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeViajesTerceros As e_ViajesTerceros) As Boolean Implements Il_ViajesTerceros.Guardar
        Try
            If Validar(oeViajesTerceros) Then
                Return odViajesTerceros.Guardar(oeViajesTerceros)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeAlmacenMermas As e_ViajesTerceros) As Boolean Implements Il_ViajesTerceros.Eliminar
        Try
            Return odViajesTerceros.Eliminar(oeAlmacenMermas)
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
