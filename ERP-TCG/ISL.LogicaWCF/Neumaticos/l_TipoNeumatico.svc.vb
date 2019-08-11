Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_TipoNeumatico
    Implements Il_TipoNeumatico

    Dim odTipoNeumatico As New d_TipoNeumatico

    Public Function Eliminar(ByVal oeTipoNeumatico As EntidadesWCF.e_TipoNeumatico) As Boolean Implements Il_TipoNeumatico.Eliminar
        Try
            Return odTipoNeumatico.Eliminar(oeTipoNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoNeumatico As EntidadesWCF.e_TipoNeumatico) As Boolean Implements Il_TipoNeumatico.Guardar
        Try
            If Validar(oeTipoNeumatico) Then
                Return odTipoNeumatico.Guardar(oeTipoNeumatico)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTipoNeumatico As EntidadesWCF.e_TipoNeumatico) As System.Collections.Generic.List(Of EntidadesWCF.e_TipoNeumatico) Implements Il_TipoNeumatico.Listar
        Try
            Return odTipoNeumatico.Listar(oeTipoNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoNeumatico As EntidadesWCF.e_TipoNeumatico) As EntidadesWCF.e_TipoNeumatico Implements Il_TipoNeumatico.Obtener
        Try
            Return odTipoNeumatico.Obtener(oeTipoNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeTipoNeumatico As EntidadesWCF.e_TipoNeumatico) As Boolean Implements Il_TipoNeumatico.Validar
        Try
            With oeTipoNeumatico
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
