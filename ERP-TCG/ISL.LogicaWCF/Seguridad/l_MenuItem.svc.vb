Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_MenuItem
    Implements Il_MenuItem
    Dim odMenuItem As New d_MenuItem

    Public Function Eliminar(ByVal oeMenuItem As e_MenuItem) As Boolean Implements Il_MenuItem.Eliminar
        Try
            Return odMenuItem.Eliminar(oeMenuItem)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMenuItem As e_MenuItem) As Boolean Implements Il_MenuItem.Guardar
        Try
            If Validar(oeMenuItem) Then
                Return odMenuItem.Guardar(oeMenuItem)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMenuItem As e_MenuItem) As System.Collections.Generic.List(Of e_MenuItem) Implements Il_MenuItem.Listar
        Try
            Return odMenuItem.Listar(oeMenuItem)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeMenuItem As e_MenuItem) As e_MenuItem Implements Il_MenuItem.Obtener
        Try
            Return odMenuItem.Obtener(oeMenuItem)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMenuItem As e_MenuItem) As Boolean Implements Il_MenuItem.Validar
        Try
            With oeMenuItem
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
