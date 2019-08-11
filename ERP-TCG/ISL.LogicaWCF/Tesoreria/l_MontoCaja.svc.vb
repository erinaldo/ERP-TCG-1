Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_MontoCaja
    Implements Il_MontoCaja
    Dim odMontoCaja As New d_MontoCaja

    Public Function Eliminar(ByVal oeMontoCaja As EntidadesWCF.e_MontoCaja) As Boolean Implements Il_MontoCaja.Eliminar
        Try
            Return odMontoCaja.Eliminar(oeMontoCaja)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMontoCaja As EntidadesWCF.e_MontoCaja) As Boolean Implements Il_MontoCaja.Guardar
        Try
            If Validar(oeMontoCaja) Then
                Return odMontoCaja.Guardar(oeMontoCaja)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMontoCaja As EntidadesWCF.e_MontoCaja) As System.Collections.Generic.List(Of EntidadesWCF.e_MontoCaja) Implements Il_MontoCaja.Listar
        Try
            Return odMontoCaja.Listar(oeMontoCaja)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeMontoCaja As EntidadesWCF.e_MontoCaja) As EntidadesWCF.e_MontoCaja Implements Il_MontoCaja.Obtener
        Try
            Return odMontoCaja.Obtener(oeMontoCaja)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMontoCaja As EntidadesWCF.e_MontoCaja) As Boolean Implements Il_MontoCaja.Validar
        Try
            With oeMontoCaja
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
