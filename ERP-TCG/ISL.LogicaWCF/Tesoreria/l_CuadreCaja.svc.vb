'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_CuadreCaja" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_CuadreCaja.svc o l_CuadreCaja.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class l_CuadreCaja
    Implements Il_CuadreCaja

    Dim odCuadreCaja As New d_CuadreCaja

    Public Function Obtener(ByVal oeCuadreCaja As e_CuadreCaja) As e_CuadreCaja Implements Il_CuadreCaja.Obtener
        Try
            Return odCuadreCaja.Obtener(oeCuadreCaja)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeCuadreCaja As e_CuadreCaja) As List(Of e_CuadreCaja) Implements Il_CuadreCaja.Listar
        Try
            Return odCuadreCaja.Listar(oeCuadreCaja)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeCuadreCaja As e_CuadreCaja) As Boolean Implements Il_CuadreCaja.Validar
        Try
            With oeCuadreCaja
                If .SaldoSistema = 0 Then
                    Throw New Exception("No Puede Guardar con SaldoSistema = 0")
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeCuadreCaja As e_CuadreCaja) As Boolean Implements Il_CuadreCaja.Guardar
        Try
            If Validar(oeCuadreCaja) Then
                Return odCuadreCaja.Guardar(oeCuadreCaja)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeCuadreCaja As e_CuadreCaja) As Boolean Implements Il_CuadreCaja.Eliminar
        Try
            Return odCuadreCaja.Eliminar(oeCuadreCaja)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
