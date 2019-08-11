Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_PerfilActividadNegocio
    Implements Il_PerfilActividadNegocio
    Dim odPerfilActividadNegocio As New d_PerfilActividadNegocio

    Public Function Eliminar(ByVal oePerfilActividadNegocio As EntidadesWCF.e_PerfilActividadNegocio) As Boolean Implements Il_PerfilActividadNegocio.Eliminar
        Try
            Return odPerfilActividadNegocio.Eliminar(oePerfilActividadNegocio)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oePerfilActividadNegocio As EntidadesWCF.e_PerfilActividadNegocio) As Boolean Implements Il_PerfilActividadNegocio.Guardar
        Try
            If Validar(oePerfilActividadNegocio) Then
                Return odPerfilActividadNegocio.Guardar(oePerfilActividadNegocio)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oePerfilActividadNegocio As EntidadesWCF.e_PerfilActividadNegocio) As System.Collections.Generic.List(Of EntidadesWCF.e_PerfilActividadNegocio) Implements Il_PerfilActividadNegocio.Listar
        Try
            Return odPerfilActividadNegocio.Listar(oePerfilActividadNegocio)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarTodos(ByVal oePerfilActividadNegocio As EntidadesWCF.e_PerfilActividadNegocio) As System.Collections.Generic.List(Of EntidadesWCF.e_PerfilActividadNegocio) Implements Il_PerfilActividadNegocio.ListarTodos
        Try
            Return odPerfilActividadNegocio.ListarTodos(oePerfilActividadNegocio)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oePerfilActividadNegocio As EntidadesWCF.e_PerfilActividadNegocio) As EntidadesWCF.e_PerfilActividadNegocio Implements Il_PerfilActividadNegocio.Obtener
        Try
            Return odPerfilActividadNegocio.Obtener(oePerfilActividadNegocio)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oePerfilActividadNegocio As EntidadesWCF.e_PerfilActividadNegocio) As Boolean Implements Il_PerfilActividadNegocio.Validar
        Try
            With oePerfilActividadNegocio
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
