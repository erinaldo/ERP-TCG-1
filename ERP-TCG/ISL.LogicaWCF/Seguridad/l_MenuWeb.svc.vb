Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_MenuWeb
    Implements Il_MenuWeb
    Dim odMenuWeb As New d_MenuWeb

    Public Function Eliminar(ByVal oeMenuWeb As EntidadesWCF.e_MenuWeb) As Boolean Implements Il_MenuWeb.Eliminar
        Try
            Return odMenuWeb.Eliminar(oeMenuWeb)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMenuWeb As EntidadesWCF.e_MenuWeb) As Boolean Implements Il_MenuWeb.Guardar
        Try
            If Validar(oeMenuWeb) Then
                Return odMenuWeb.Guardar(oeMenuWeb)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMenuWeb As EntidadesWCF.e_MenuWeb) As System.Collections.Generic.List(Of EntidadesWCF.e_MenuWeb) Implements Il_MenuWeb.Listar
        Try
            Return odMenuWeb.Listar(oeMenuWeb)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeMenuWeb As EntidadesWCF.e_MenuWeb) As EntidadesWCF.e_MenuWeb Implements Il_MenuWeb.Obtener
        Try
            Return odMenuWeb.Obtener(oeMenuWeb)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMenuWeb As EntidadesWCF.e_MenuWeb) As Boolean Implements Il_MenuWeb.Validar
        Try
            With oeMenuWeb
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
