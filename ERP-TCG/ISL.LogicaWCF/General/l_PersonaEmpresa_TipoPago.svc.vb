Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_PersonaEmpresa_TipoPago
    Implements Il_PersonaEmpresa_TipoPago

    Dim odPersonaEmpresa_TipoPago As New d_PersonaEmpresa_TipoPago

    Public Function Eliminar(ByVal oePersonaEmpresa_TipoPago As EntidadesWCF.e_PersonaEmpresa_TipoPago) As Boolean Implements Il_PersonaEmpresa_TipoPago.Eliminar
        Try
            Return odPersonaEmpresa_TipoPago.Eliminar(oePersonaEmpresa_TipoPago)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oePersonaEmpresa_TipoPago As EntidadesWCF.e_PersonaEmpresa_TipoPago) As Boolean Implements Il_PersonaEmpresa_TipoPago.Guardar
        Try
            If Validar(oePersonaEmpresa_TipoPago) Then
                Return odPersonaEmpresa_TipoPago.Guardar(oePersonaEmpresa_TipoPago)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oePersonaEmpresa_TipoPago As EntidadesWCF.e_PersonaEmpresa_TipoPago) As System.Collections.Generic.List(Of EntidadesWCF.e_PersonaEmpresa_TipoPago) Implements Il_PersonaEmpresa_TipoPago.Listar
        Try
            Return odPersonaEmpresa_TipoPago.Listar(oePersonaEmpresa_TipoPago)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oePersonaEmpresa_TipoPago As EntidadesWCF.e_PersonaEmpresa_TipoPago) As EntidadesWCF.e_PersonaEmpresa_TipoPago Implements Il_PersonaEmpresa_TipoPago.Obtener
        Try
            Return odPersonaEmpresa_TipoPago.Obtener(oePersonaEmpresa_TipoPago)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oePersonaEmpresa_TipoPago As EntidadesWCF.e_PersonaEmpresa_TipoPago) As Boolean Implements Il_PersonaEmpresa_TipoPago.Validar
        Try
            With oePersonaEmpresa_TipoPago
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
