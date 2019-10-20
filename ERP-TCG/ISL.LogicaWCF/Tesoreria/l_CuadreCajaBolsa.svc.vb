Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_CuadreCajaBolsa" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_CuadreCajaBolsa.svc o l_CuadreCajaBolsa.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class l_CuadreCajaBolsa
    Implements Il_CuadreCajaBolsa

    Dim odCuadreCajaBolsa As New d_CuadreCajaBolsa

    Public Function Eliminar(oeCuadreCajaBolsa As e_CuadreCajaBolsa) As Boolean Implements Il_CuadreCajaBolsa.Eliminar
        Try
            Return odCuadreCajaBolsa.Eliminar(oeCuadreCajaBolsa)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(oeCuadreCajaBolsa As e_CuadreCajaBolsa) As Boolean Implements Il_CuadreCajaBolsa.Guardar
        Try
            If Validar(oeCuadreCajaBolsa) Then
                Return odCuadreCajaBolsa.Guardar(oeCuadreCajaBolsa)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeCuadreCajaBolsa As e_CuadreCajaBolsa) As List(Of e_CuadreCajaBolsa) Implements Il_CuadreCajaBolsa.Listar
        Try
            Return odCuadreCajaBolsa.Listar(oeCuadreCajaBolsa)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(oeCuadreCajaBolsa As e_CuadreCajaBolsa) As e_CuadreCajaBolsa Implements Il_CuadreCajaBolsa.Obtener
        Try
            Return odCuadreCajaBolsa.Obtener(oeCuadreCajaBolsa)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(oeCuadreCajaBolsa As e_CuadreCajaBolsa) As Boolean Implements Il_CuadreCajaBolsa.Validar
        Try
            With oeCuadreCajaBolsa
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
