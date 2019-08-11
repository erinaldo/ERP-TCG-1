Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_DetalleConfiguracionNeumatico
    Implements Il_DetalleConfiguracionNeumatico

    Dim odDetalleConfiguracionNeumatico As New d_DetalleConfiguracionNeumatico

    Public Function Eliminar(ByVal oeDetalleConfiguracionNeumatico As EntidadesWCF.e_DetalleConfiguracionNeumatico) As Boolean Implements Il_DetalleConfiguracionNeumatico.Eliminar
        Try
            Return odDetalleConfiguracionNeumatico.Eliminar(oeDetalleConfiguracionNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleConfiguracionNeumatico As EntidadesWCF.e_DetalleConfiguracionNeumatico) As Boolean Implements Il_DetalleConfiguracionNeumatico.Guardar
        Try
            If Validar(oeDetalleConfiguracionNeumatico) Then
                Return odDetalleConfiguracionNeumatico.Guardar(oeDetalleConfiguracionNeumatico)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleConfiguracionNeumatico As EntidadesWCF.e_DetalleConfiguracionNeumatico) As System.Collections.Generic.List(Of EntidadesWCF.e_DetalleConfiguracionNeumatico) Implements Il_DetalleConfiguracionNeumatico.Listar
        Try
            Return odDetalleConfiguracionNeumatico.Listar(oeDetalleConfiguracionNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeDetalleConfiguracionNeumatico As EntidadesWCF.e_DetalleConfiguracionNeumatico) As EntidadesWCF.e_DetalleConfiguracionNeumatico Implements Il_DetalleConfiguracionNeumatico.Obtener
        Try
            Return odDetalleConfiguracionNeumatico.Obtener(oeDetalleConfiguracionNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeDetalleConfiguracionNeumatico As EntidadesWCF.e_DetalleConfiguracionNeumatico) As Boolean Implements Il_DetalleConfiguracionNeumatico.Validar
        Try
            With oeDetalleConfiguracionNeumatico
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
