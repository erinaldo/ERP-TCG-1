Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_ClienteViajePrimaCon" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_ClienteViajePrimaCon.svc o l_ClienteViajePrimaCon.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class l_ClienteViajePrimaCon
    Implements Il_ClienteViajePrimaCon
    Dim odClienteViajePrimaCon As New d_ClienteViajePrimaCon

    Public Function Eliminar(oeClienteViajePrimaCon As EntidadesWCF.e_ClienteViajePrimaCon) As Boolean Implements Il_ClienteViajePrimaCon.Eliminar
        Try
            Return odClienteViajePrimaCon.Eliminar(oeClienteViajePrimaCon)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(oeClienteViajePrimaCon As EntidadesWCF.e_ClienteViajePrimaCon) As Boolean Implements Il_ClienteViajePrimaCon.Guardar
        Try
            If Validar(oeClienteViajePrimaCon) Then
                Return odClienteViajePrimaCon.Guardar(oeClienteViajePrimaCon)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeClienteViajePrimaCon As EntidadesWCF.e_ClienteViajePrimaCon) As List(Of EntidadesWCF.e_ClienteViajePrimaCon) Implements Il_ClienteViajePrimaCon.Listar
        Try
            Return odClienteViajePrimaCon.Listar(oeClienteViajePrimaCon)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(oeClienteViajePrimaCon As EntidadesWCF.e_ClienteViajePrimaCon) As EntidadesWCF.e_ClienteViajePrimaCon Implements Il_ClienteViajePrimaCon.Obtener
        Try
            Return odClienteViajePrimaCon.Obtener(oeClienteViajePrimaCon)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(oeClienteViajePrimaCon As EntidadesWCF.e_ClienteViajePrimaCon) As Boolean Implements Il_ClienteViajePrimaCon.Validar
        Try
            With oeClienteViajePrimaCon
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
