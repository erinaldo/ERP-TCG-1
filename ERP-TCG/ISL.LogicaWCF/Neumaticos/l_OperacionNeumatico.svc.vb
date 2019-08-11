Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_OperacionNeumatico
    Implements Il_OperacionNeumatico

    Dim odOperacionNeumatico As New d_OperacionNeumatico

    Public Function Eliminar(ByVal oeOperacionNeumatico As EntidadesWCF.e_OperacionNeumatico) As Boolean Implements Il_OperacionNeumatico.Eliminar
        Try
            Return odOperacionNeumatico.Eliminar(oeOperacionNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeOperacionNeumatico As EntidadesWCF.e_OperacionNeumatico) As Boolean Implements Il_OperacionNeumatico.Guardar
        Try
            If Validar(oeOperacionNeumatico) Then
                Return odOperacionNeumatico.Guardar(oeOperacionNeumatico)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeOperacionNeumatico As EntidadesWCF.e_OperacionNeumatico) As System.Collections.Generic.List(Of EntidadesWCF.e_OperacionNeumatico) Implements Il_OperacionNeumatico.Listar
        Try
            Return odOperacionNeumatico.Listar(oeOperacionNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeOperacionNeumatico As EntidadesWCF.e_OperacionNeumatico) As EntidadesWCF.e_OperacionNeumatico Implements Il_OperacionNeumatico.Obtener
        Try
            Return odOperacionNeumatico.Obtener(oeOperacionNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeOperacionNeumatico As EntidadesWCF.e_OperacionNeumatico) As Boolean Implements Il_OperacionNeumatico.Validar
        Try
            With oeOperacionNeumatico
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarLista(leOperacionNeumatico As List(Of e_OperacionNeumatico)) As Boolean Implements Il_OperacionNeumatico.GuardarLista
        Try
            Return odOperacionNeumatico.GuardarLista(leOperacionNeumatico)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
