Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_ParametroGeneral
    Implements Il_ParametroGeneral

    Dim odParametroGeneral As New d_ParametroGeneral

    Public Function Eliminar(ByVal oeParametroGeneral As EntidadesWCF.e_ParametroGeneral) As Boolean Implements Il_ParametroGeneral.Eliminar
        Try
            Return odParametroGeneral.Eliminar(oeParametroGeneral)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeParametroGeneral As EntidadesWCF.e_ParametroGeneral) As Boolean Implements Il_ParametroGeneral.Guardar
        Try
            If Validar(oeParametroGeneral) Then
                Return odParametroGeneral.Guardar(oeParametroGeneral)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeParametroGeneral As EntidadesWCF.e_ParametroGeneral) As System.Collections.Generic.List(Of EntidadesWCF.e_ParametroGeneral) Implements Il_ParametroGeneral.Listar
        Try
            Return odParametroGeneral.Listar(oeParametroGeneral)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeParametroGeneral As EntidadesWCF.e_ParametroGeneral) As EntidadesWCF.e_ParametroGeneral Implements Il_ParametroGeneral.Obtener
        Try
            Return odParametroGeneral.Obtener(oeParametroGeneral)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeParametroGeneral As EntidadesWCF.e_ParametroGeneral) As Boolean Implements Il_ParametroGeneral.Validar
        Try
            With oeParametroGeneral
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function
End Class
