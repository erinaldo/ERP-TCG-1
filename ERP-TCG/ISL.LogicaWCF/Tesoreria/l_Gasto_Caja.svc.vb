Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Gasto_Caja
    Implements Il_Gasto_Caja
    Dim odGasto_Caja As New d_Gasto_Caja

    Public Function Eliminar(ByVal oeGasto_Caja As EntidadesWCF.e_Gasto_Caja) As Boolean Implements Il_Gasto_Caja.Eliminar
        Try
            Return odGasto_Caja.Eliminar(oeGasto_Caja)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeGasto_Caja As EntidadesWCF.e_Gasto_Caja) As Boolean Implements Il_Gasto_Caja.Guardar
        Try
            If Validar(oeGasto_Caja) Then
                Return odGasto_Caja.Guardar(oeGasto_Caja)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGasto_Caja As EntidadesWCF.e_Gasto_Caja) As System.Collections.Generic.List(Of EntidadesWCF.e_Gasto_Caja) Implements Il_Gasto_Caja.Listar
        Try
            Return odGasto_Caja.Listar(oeGasto_Caja)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeGasto_Caja As EntidadesWCF.e_Gasto_Caja) As EntidadesWCF.e_Gasto_Caja Implements Il_Gasto_Caja.Obtener
        Try
            Return odGasto_Caja.Obtener(oeGasto_Caja)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeGasto_Caja As EntidadesWCF.e_Gasto_Caja) As Boolean Implements Il_Gasto_Caja.Validar
        Try
            With oeGasto_Caja
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
