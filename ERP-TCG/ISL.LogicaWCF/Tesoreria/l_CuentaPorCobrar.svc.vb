Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_CuentaPorCobrar
    Implements Il_CuentaPorCobrar
    Dim odCuentaPorCobrar As New d_CuentaPorCobrar

    Public Function Eliminar(ByVal oeCuentaPorCobrar As e_CuentaPorCobrar) As Boolean Implements Il_CuentaPorCobrar.Eliminar
        Try
            Return odCuentaPorCobrar.Eliminar(oeCuentaPorCobrar)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCuentaPorCobrar As e_CuentaPorCobrar) As Boolean Implements Il_CuentaPorCobrar.Guardar
        Try
            If Validar(oeCuentaPorCobrar) Then
                Return odCuentaPorCobrar.Guardar(oeCuentaPorCobrar)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCuentaPorCobrar As e_CuentaPorCobrar) As System.Collections.Generic.List(Of e_CuentaPorCobrar) Implements Il_CuentaPorCobrar.Listar
        Try
            Return odCuentaPorCobrar.Listar(oeCuentaPorCobrar)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeCuentaPorCobrar As e_CuentaPorCobrar) As e_CuentaPorCobrar Implements Il_CuentaPorCobrar.Obtener
        Try
            Return odCuentaPorCobrar.Obtener(oeCuentaPorCobrar)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeCuentaPorCobrar As e_CuentaPorCobrar) As Boolean Implements Il_CuentaPorCobrar.Validar
        Try
            With oeCuentaPorCobrar
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
