Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_DepositoDetalle
    Implements Il_DepositoDetalle
    Dim odDepositoDetalle As New d_DepositoDetalle

    Public Function Eliminar(ByVal oeDepositoDetalle As EntidadesWCF.e_DepositoDetalle) As Boolean Implements Il_DepositoDetalle.Eliminar
        Try
            Return odDepositoDetalle.Eliminar(oeDepositoDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDepositoDetalle As EntidadesWCF.e_DepositoDetalle) As Boolean Implements Il_DepositoDetalle.Guardar
        Try
            If Validar(oeDepositoDetalle) Then
                Return odDepositoDetalle.Guardar(oeDepositoDetalle)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDepositoDetalle As EntidadesWCF.e_DepositoDetalle) As System.Collections.Generic.List(Of EntidadesWCF.e_DepositoDetalle) Implements Il_DepositoDetalle.Listar
        Try
            Return odDepositoDetalle.Listar(oeDepositoDetalle)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDepositoDetalle As EntidadesWCF.e_DepositoDetalle) As EntidadesWCF.e_DepositoDetalle Implements Il_DepositoDetalle.Obtener
        Try
            Return odDepositoDetalle.Obtener(oeDepositoDetalle)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeDepositoDetalle As EntidadesWCF.e_DepositoDetalle) As Boolean Implements Il_DepositoDetalle.Validar
        Try
            With oeDepositoDetalle
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
