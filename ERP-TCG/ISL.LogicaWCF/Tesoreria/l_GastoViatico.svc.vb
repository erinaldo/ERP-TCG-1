Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_GastoViatico
    Implements Il_GastoViatico
    Dim odGastoViatico As New d_GastoViatico

    Public Function Eliminar(ByVal oeGastoViatico As e_GastoViatico) As Boolean Implements Il_GastoViatico.Eliminar
        Try
            Return odGastoViatico.Eliminar(oeGastoViatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeGastoViatico As e_GastoViatico) As Boolean Implements Il_GastoViatico.Guardar
        Try
            If Validar(oeGastoViatico) Then
                Return odGastoViatico.Guardar(oeGastoViatico)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGastoViatico As e_GastoViatico) As System.Collections.Generic.List(Of e_GastoViatico) Implements Il_GastoViatico.Listar
        Try
            Return odGastoViatico.Listar(oeGastoViatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeGastoViatico As e_GastoViatico) As e_GastoViatico Implements Il_GastoViatico.Obtener
        Try
            Return odGastoViatico.Obtener(oeGastoViatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeGastoViatico As e_GastoViatico) As Boolean Implements Il_GastoViatico.Validar
        Try
            With oeGastoViatico
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
