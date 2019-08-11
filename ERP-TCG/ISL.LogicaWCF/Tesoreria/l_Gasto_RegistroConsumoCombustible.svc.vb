Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Gasto_RegistroConsumoCombustible
    Implements Il_Gasto_RegistroConsumoCombustible
    Dim odGasto_RegistroConsumoCombustible As New d_Gasto_RegistroConsumoCombustible

    Public Function Eliminar(ByVal oeGasto_RegistroConsumoCombustible As EntidadesWCF.e_Gasto_RegistroConsumoCombustible) As Boolean Implements Il_Gasto_RegistroConsumoCombustible.Eliminar
        Try
            Return odGasto_RegistroConsumoCombustible.Eliminar(oeGasto_RegistroConsumoCombustible)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeGasto_RegistroConsumoCombustible As EntidadesWCF.e_Gasto_RegistroConsumoCombustible) As Boolean Implements Il_Gasto_RegistroConsumoCombustible.Guardar
        Try
            If Validar(oeGasto_RegistroConsumoCombustible) Then
                Return odGasto_RegistroConsumoCombustible.Guardar(oeGasto_RegistroConsumoCombustible)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGasto_RegistroConsumoCombustible As EntidadesWCF.e_Gasto_RegistroConsumoCombustible) As System.Collections.Generic.List(Of EntidadesWCF.e_Gasto_RegistroConsumoCombustible) Implements Il_Gasto_RegistroConsumoCombustible.Listar
        Try
            Return odGasto_RegistroConsumoCombustible.Listar(oeGasto_RegistroConsumoCombustible)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeGasto_RegistroConsumoCombustible As EntidadesWCF.e_Gasto_RegistroConsumoCombustible) As EntidadesWCF.e_Gasto_RegistroConsumoCombustible Implements Il_Gasto_RegistroConsumoCombustible.Obtener
        Try
            Return odGasto_RegistroConsumoCombustible.Obtener(oeGasto_RegistroConsumoCombustible)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeGasto_RegistroConsumoCombustible As EntidadesWCF.e_Gasto_RegistroConsumoCombustible) As Boolean Implements Il_Gasto_RegistroConsumoCombustible.Validar
        Try
            With oeGasto_RegistroConsumoCombustible
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
