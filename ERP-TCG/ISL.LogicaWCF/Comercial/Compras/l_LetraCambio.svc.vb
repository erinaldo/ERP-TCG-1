Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_LetraCambio
    Implements Il_LetraCambio

    Dim odLetraCambio As New d_LetraCambio

    Public Function Eliminar(ByVal oeLetraCambio As EntidadesWCF.e_LetraCambio) As Boolean Implements Il_LetraCambio.Eliminar
        Try
            Return odLetraCambio.Eliminar(oeLetraCambio)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeLetraCambio As EntidadesWCF.e_LetraCambio) As Boolean Implements Il_LetraCambio.Guardar
        Try
            If Validar(oeLetraCambio) Then
                Return odLetraCambio.Guardar(oeLetraCambio)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeLetraCambio As EntidadesWCF.e_LetraCambio) As System.Collections.Generic.List(Of EntidadesWCF.e_LetraCambio) Implements Il_LetraCambio.Listar
        Try
            Return odLetraCambio.Listar(oeLetraCambio)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeLetraCambio As EntidadesWCF.e_LetraCambio) As EntidadesWCF.e_LetraCambio Implements Il_LetraCambio.Obtener
        Try
            Return odLetraCambio.Obtener(oeLetraCambio)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeLetraCambio As EntidadesWCF.e_LetraCambio) As Boolean Implements Il_LetraCambio.Validar
        Try
            With oeLetraCambio
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
