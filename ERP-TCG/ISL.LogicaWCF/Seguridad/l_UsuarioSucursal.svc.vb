Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()>
Public Class l_UsuarioSucursal
    Implements Il_UsuarioSucursal
    Dim odUsuarioSucursal As New d_UsuarioSucursal

    Public Function Eliminar(ByVal oeUsuarioSucursal As e_UsuarioSucursal) As Boolean Implements Il_UsuarioSucursal.Eliminar
        Try
            Return odUsuarioSucursal.Eliminar(oeUsuarioSucursal)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeUsuarioSucursal As e_UsuarioSucursal) As Boolean Implements Il_UsuarioSucursal.Guardar
        Try
            If Validar(oeUsuarioSucursal) Then
                Return odUsuarioSucursal.Guardar(oeUsuarioSucursal)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeUsuarioSucursal As e_UsuarioSucursal) As System.Collections.Generic.List(Of e_UsuarioSucursal) Implements Il_UsuarioSucursal.Listar
        Try
            Return odUsuarioSucursal.Listar(oeUsuarioSucursal)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarTodos(ByVal oeUsuarioSucursal As e_UsuarioSucursal) As System.Collections.Generic.List(Of e_UsuarioSucursal) Implements Il_UsuarioSucursal.ListarTodos
        Try
            Return odUsuarioSucursal.ListarTodo(oeUsuarioSucursal)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeUsuarioSucursal As e_UsuarioSucursal) As e_UsuarioSucursal Implements Il_UsuarioSucursal.Obtener
        Try
            Return odUsuarioSucursal.Obtener(oeUsuarioSucursal)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeUsuarioSucursal As e_UsuarioSucursal) As Boolean Implements Il_UsuarioSucursal.Validar
        Try
            With oeUsuarioSucursal
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class

