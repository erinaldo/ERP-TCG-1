Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_UsuarioPerfil
    Implements Il_UsuarioPerfil
    Dim odUsuarioPerfil As New d_UsuarioPerfil

    Public Function Eliminar(ByVal oeUsuarioPerfil As EntidadesWCF.e_UsuarioPerfil) As Boolean Implements Il_UsuarioPerfil.Eliminar
        Try
            Return odUsuarioPerfil.Eliminar(oeUsuarioPerfil)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeUsuarioPerfil As EntidadesWCF.e_UsuarioPerfil) As Boolean Implements Il_UsuarioPerfil.Guardar
        Try
            If Validar(oeUsuarioPerfil) Then
                Return odUsuarioPerfil.Guardar(oeUsuarioPerfil)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeUsuarioPerfil As EntidadesWCF.e_UsuarioPerfil) As System.Collections.Generic.List(Of EntidadesWCF.e_UsuarioPerfil) Implements Il_UsuarioPerfil.Listar
        Try
            Return odUsuarioPerfil.Listar(oeUsuarioPerfil)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarTodos(ByVal oeUsuarioPerfil As EntidadesWCF.e_UsuarioPerfil) As System.Collections.Generic.List(Of EntidadesWCF.e_UsuarioPerfil) Implements Il_UsuarioPerfil.ListarTodos
        Try
            Return odUsuarioPerfil.ListarTodo(oeUsuarioPerfil)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeUsuarioPerfil As EntidadesWCF.e_UsuarioPerfil) As EntidadesWCF.e_UsuarioPerfil Implements Il_UsuarioPerfil.Obtener
        Try
            Return odUsuarioPerfil.Obtener(oeUsuarioPerfil)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeUsuarioPerfil As EntidadesWCF.e_UsuarioPerfil) As Boolean Implements Il_UsuarioPerfil.Validar
        Try
            With oeUsuarioPerfil
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
