Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_ConfiguracionNeumatico
    Implements Il_ConfiguracionNeumatico

    Dim odConfiguracionNeumatico As New d_ConfiguracionNeumatico

    Public Function Eliminar(ByVal oeConfiguracionNeumatico As EntidadesWCF.e_ConfiguracionNeumatico) As Boolean Implements Il_ConfiguracionNeumatico.Eliminar
        Try
            Return odConfiguracionNeumatico.Eliminar(oeConfiguracionNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeConfiguracionNeumatico As EntidadesWCF.e_ConfiguracionNeumatico) As Boolean Implements Il_ConfiguracionNeumatico.Guardar
        Try
            If Validar(oeConfiguracionNeumatico) Then
                Return odConfiguracionNeumatico.Guardar(oeConfiguracionNeumatico)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeConfiguracionNeumatico As EntidadesWCF.e_ConfiguracionNeumatico) As System.Collections.Generic.List(Of EntidadesWCF.e_ConfiguracionNeumatico) Implements Il_ConfiguracionNeumatico.Listar
        Try
            Return odConfiguracionNeumatico.Listar(oeConfiguracionNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeConfiguracionNeumatico As EntidadesWCF.e_ConfiguracionNeumatico) As EntidadesWCF.e_ConfiguracionNeumatico Implements Il_ConfiguracionNeumatico.Obtener
        Try
            Return odConfiguracionNeumatico.Obtener(oeConfiguracionNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeConfiguracionNeumatico As EntidadesWCF.e_ConfiguracionNeumatico) As Boolean Implements Il_ConfiguracionNeumatico.Validar
        Try
            With oeConfiguracionNeumatico
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
