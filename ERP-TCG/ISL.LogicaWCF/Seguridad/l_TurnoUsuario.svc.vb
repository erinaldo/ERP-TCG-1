Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_TurnoUsuario
    Implements Il_TurnoUsuario

    Dim odTurnoUsuario As New d_TurnoUsuario

    Public Function Eliminar(ByVal oeTurnoUsuario As EntidadesWCF.e_TurnoUsuario) As Boolean Implements Il_TurnoUsuario.Eliminar
        Try
            Return odTurnoUsuario.Eliminar(oeTurnoUsuario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTurnoUsuario As EntidadesWCF.e_TurnoUsuario) As Boolean Implements Il_TurnoUsuario.Guardar
        Try
            If Validar(oeTurnoUsuario) Then
                Return odTurnoUsuario.Guardar(oeTurnoUsuario)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTurnoUsuario As EntidadesWCF.e_TurnoUsuario) As System.Collections.Generic.List(Of EntidadesWCF.e_TurnoUsuario) Implements Il_TurnoUsuario.Listar
        Try
            Return odTurnoUsuario.Listar(oeTurnoUsuario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeTurnoUsuario As EntidadesWCF.e_TurnoUsuario) As EntidadesWCF.e_TurnoUsuario Implements Il_TurnoUsuario.Obtener
        Try
            Return odTurnoUsuario.Obtener(oeTurnoUsuario)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeTurnoUsuario As EntidadesWCF.e_TurnoUsuario) As Boolean Implements Il_TurnoUsuario.Validar
        Try
            With oeTurnoUsuario
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
