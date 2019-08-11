Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_CuentaItemGasto
    Implements Il_CuentaItemGasto

    Dim odCuentaItemGasto As New d_CuentaItemGasto

    Public Function Eliminar(ByVal oeCuentaItemGasto As EntidadesWCF.e_CuentaItemGasto) As Boolean Implements Il_CuentaItemGasto.Eliminar
        Try
            Return odCuentaItemGasto.Eliminar(oeCuentaItemGasto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCuentaItemGasto As EntidadesWCF.e_CuentaItemGasto) As Boolean Implements Il_CuentaItemGasto.Guardar
        Try
            If Validar(oeCuentaItemGasto) Then
                Return odCuentaItemGasto.Guardar(oeCuentaItemGasto)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCuentaItemGasto As EntidadesWCF.e_CuentaItemGasto) As System.Collections.Generic.List(Of EntidadesWCF.e_CuentaItemGasto) Implements Il_CuentaItemGasto.Listar
        Try
            Return odCuentaItemGasto.Listar(oeCuentaItemGasto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeCuentaItemGasto As EntidadesWCF.e_CuentaItemGasto) As EntidadesWCF.e_CuentaItemGasto Implements Il_CuentaItemGasto.Obtener
        Try
            Return odCuentaItemGasto.Obtener(oeCuentaItemGasto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeCuentaItemGasto As EntidadesWCF.e_CuentaItemGasto) As Boolean Implements Il_CuentaItemGasto.Validar
        Try
            With oeCuentaItemGasto
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
