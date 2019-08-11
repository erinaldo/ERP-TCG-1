Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_CuadreCajaGasto" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_CuadreCajaGasto.svc o l_CuadreCajaGasto.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class l_CuadreCajaGasto
    Implements Il_CuadreCajaGasto
    Dim odCuadreCajaGasto As New d_CuadreCajaGasto

    Public Function Eliminar(oeCuadreCajaGasto As e_CuadreCajaGasto) As Boolean Implements Il_CuadreCajaGasto.Eliminar
        Try
            Return odCuadreCajaGasto.Eliminar(oeCuadreCajaGasto)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(oeCuadreCajaGasto As e_CuadreCajaGasto) As Boolean Implements Il_CuadreCajaGasto.Guardar
        Try
            If Validar(oeCuadreCajaGasto) Then
                Return odCuadreCajaGasto.Guardar(oeCuadreCajaGasto)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeCuadreCajaGasto As e_CuadreCajaGasto) As List(Of e_CuadreCajaGasto) Implements Il_CuadreCajaGasto.Listar
        Try
            Return odCuadreCajaGasto.Listar(oeCuadreCajaGasto)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(oeCuadreCajaGasto As e_CuadreCajaGasto) As e_CuadreCajaGasto Implements Il_CuadreCajaGasto.Obtener
        Try
            Return odCuadreCajaGasto.Obtener(oeCuadreCajaGasto)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(oeCuadreCajaGasto As e_CuadreCajaGasto) As Boolean Implements Il_CuadreCajaGasto.Validar
        Try
            With oeCuadreCajaGasto
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
