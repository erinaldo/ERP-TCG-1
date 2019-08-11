Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_leasing
    Implements Il_leasing

    Dim odLeasing As New d_Leasing

    Public Function Eliminar(ByVal oeLeasing As EntidadesWCF.e_Leasing) As Boolean Implements Il_leasing.Eliminar
        Try
            Return odLeasing.Eliminar(oeLeasing)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeLeasing As EntidadesWCF.e_Leasing) As Boolean Implements Il_leasing.Guardar
        Try
            '' If Validar(oeCompra) Then
            Return odLeasing.Guardar(oeLeasing)
            ''End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeLeasing As EntidadesWCF.e_Leasing) As System.Collections.Generic.List(Of EntidadesWCF.e_Leasing) Implements Il_leasing.Listar
        Try
            Return odLeasing.Listar(oeLeasing)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeLeasing As EntidadesWCF.e_Leasing) As EntidadesWCF.e_Leasing Implements Il_leasing.Obtener
        Try
            Return odLeasing.Obtener(oeLeasing)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeLeasing As EntidadesWCF.e_Leasing) As Boolean Implements Il_leasing.Validar
        Try
            With oeLeasing
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
