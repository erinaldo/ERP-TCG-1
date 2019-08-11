Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_GastoAsiento
    Implements Il_GastoAsiento

    Dim odGastoAsiento As New d_GastoAsiento

    Public Function Eliminar(ByVal oeGastoAsiento As EntidadesWCF.e_GastoAsiento) As Boolean Implements Il_GastoAsiento.Eliminar
        Try
            Return odGastoAsiento.Eliminar(oeGastoAsiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeGastoAsiento As EntidadesWCF.e_GastoAsiento) As Boolean Implements Il_GastoAsiento.Guardar
        Try
            If Validar(oeGastoAsiento) Then
                Dim oeAsieto As New e_Asiento
                Return odGastoAsiento.Guardar(oeGastoAsiento, oeAsieto)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGastoAsiento As EntidadesWCF.e_GastoAsiento) As System.Collections.Generic.List(Of EntidadesWCF.e_GastoAsiento) Implements Il_GastoAsiento.Listar
        Try
            Return odGastoAsiento.Listar(oeGastoAsiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeGastoAsiento As EntidadesWCF.e_GastoAsiento) As EntidadesWCF.e_GastoAsiento Implements Il_GastoAsiento.Obtener
        Try
            Return odGastoAsiento.Obtener(oeGastoAsiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeGastoAsiento As EntidadesWCF.e_GastoAsiento) As Boolean Implements Il_GastoAsiento.Validar
        Try
            With oeGastoAsiento
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarGAFAnalisis(ByVal oeGastoAsiento As EntidadesWCF.e_GastoAsiento) As DataTable Implements Il_GastoAsiento.ListarGAAnalisis
        Try
            Return odGastoAsiento.ListarGFAnalisis(oeGastoAsiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
