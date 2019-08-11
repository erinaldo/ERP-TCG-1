Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_ValorizacionNeumatico
    Implements Il_ValorizacionNeumatico

    Dim odValorizacionNeumatico As New d_ValorizacionNeumatico

    Public Function Eliminar(ByVal oeValorizacionNeumatico As EntidadesWCF.e_ValorizacionNeumatico) As Boolean Implements Il_ValorizacionNeumatico.Eliminar
        Try
            Return odValorizacionNeumatico.Eliminar(oeValorizacionNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeValorizacionNeumatico As EntidadesWCF.e_ValorizacionNeumatico) As Boolean Implements Il_ValorizacionNeumatico.Guardar
        Try
            If Validar(oeValorizacionNeumatico) Then
                Return odValorizacionNeumatico.Guardar(oeValorizacionNeumatico)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeValorizacionNeumatico As EntidadesWCF.e_ValorizacionNeumatico) As System.Collections.Generic.List(Of EntidadesWCF.e_ValorizacionNeumatico) Implements Il_ValorizacionNeumatico.Listar
        Try
            Return odValorizacionNeumatico.Listar(oeValorizacionNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeValorizacionNeumatico As EntidadesWCF.e_ValorizacionNeumatico) As EntidadesWCF.e_ValorizacionNeumatico Implements Il_ValorizacionNeumatico.Obtener
        Try
            Return odValorizacionNeumatico.Obtener(oeValorizacionNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeValorizacionNeumatico As EntidadesWCF.e_ValorizacionNeumatico) As Boolean Implements Il_ValorizacionNeumatico.Validar
        Try
            With oeValorizacionNeumatico
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
