Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_CuentaFlujoCaja
    Implements Il_CuentaFlujoCaja
    Dim odCuentaFlujoCaja As New d_CuentaFlujoCaja

    Public Function Eliminar(ByVal oeCuentaFlujoCaja As e_CuentaFlujoCaja) As Boolean Implements Il_CuentaFlujoCaja.Eliminar
        Try
            Return odCuentaFlujoCaja.Eliminar(oeCuentaFlujoCaja)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCuentaFlujoCaja As e_CuentaFlujoCaja) As Boolean Implements Il_CuentaFlujoCaja.Guardar
        Try
            If Validar(oeCuentaFlujoCaja) Then
                Return odCuentaFlujoCaja.Guardar(oeCuentaFlujoCaja)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCuentaFlujoCaja As e_CuentaFlujoCaja) As System.Collections.Generic.List(Of e_CuentaFlujoCaja) Implements Il_CuentaFlujoCaja.Listar
        Try
            Return odCuentaFlujoCaja.Listar(oeCuentaFlujoCaja)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeCuentaFlujoCaja As e_CuentaFlujoCaja) As e_CuentaFlujoCaja Implements Il_CuentaFlujoCaja.Obtener
        Try
            Return odCuentaFlujoCaja.Obtener(oeCuentaFlujoCaja)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeCuentaFlujoCaja As e_CuentaFlujoCaja) As Boolean Implements Il_CuentaFlujoCaja.Validar
        Try
            With oeCuentaFlujoCaja
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
