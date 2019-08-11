Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_ClienteProveedor
    Implements Il_ClienteProveedor

    Dim odClienteProveedor As New d_ClienteProveedor

    Public Function Eliminar(ByVal oeClienteProveedor As EntidadesWCF.e_ClienteProveedor) As Boolean Implements Il_ClienteProveedor.Eliminar
        Try
            Return odClienteProveedor.Eliminar(oeClienteProveedor)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeClienteProveedor As EntidadesWCF.e_ClienteProveedor) As Boolean Implements Il_ClienteProveedor.Guardar
        Try
            If Validar(oeClienteProveedor) Then
                Return odClienteProveedor.Guardar(oeClienteProveedor)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeClienteProveedor As EntidadesWCF.e_ClienteProveedor) As System.Collections.Generic.List(Of EntidadesWCF.e_ClienteProveedor) Implements Il_ClienteProveedor.Listar
        Try
            Return odClienteProveedor.Listar(oeClienteProveedor)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeClienteProveedor As EntidadesWCF.e_ClienteProveedor) As EntidadesWCF.e_ClienteProveedor Implements Il_ClienteProveedor.Obtener
        Try
            Return odClienteProveedor.Obtener(oeClienteProveedor)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeClienteProveedor As EntidadesWCF.e_ClienteProveedor) As Boolean Implements Il_ClienteProveedor.Validar
        Try
            With oeClienteProveedor
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
