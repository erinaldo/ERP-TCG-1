Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_CuentaAsociada
    Implements Il_CuentaAsociada

    Dim odCuentaAsociada As New d_CuentaAsociada

    Public Function Eliminar(ByVal oeCuentaAsociada As EntidadesWCF.e_CuentaAsociada) As Boolean Implements Il_CuentaAsociada.Eliminar
        Try
            Return odCuentaAsociada.Eliminar(oeCuentaAsociada)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCuentaAsociada As EntidadesWCF.e_CuentaAsociada) As Boolean Implements Il_CuentaAsociada.Guardar
        Try
            If Validar(oeCuentaAsociada) Then
                Return odCuentaAsociada.Guardar(oeCuentaAsociada)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCuentaAsociada As EntidadesWCF.e_CuentaAsociada) As System.Collections.Generic.List(Of EntidadesWCF.e_CuentaAsociada) Implements Il_CuentaAsociada.Listar
        Try
            Return odCuentaAsociada.Listar(oeCuentaAsociada)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeCuentaAsociada As EntidadesWCF.e_CuentaAsociada) As EntidadesWCF.e_CuentaAsociada Implements Il_CuentaAsociada.Obtener
        Try
            Return odCuentaAsociada.Obtener(oeCuentaAsociada)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeCuentaAsociada As EntidadesWCF.e_CuentaAsociada) As Boolean Implements Il_CuentaAsociada.Validar
        Try
            With oeCuentaAsociada
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
