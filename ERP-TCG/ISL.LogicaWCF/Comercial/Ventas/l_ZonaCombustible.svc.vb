Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_ZonaCombustible
    Implements Il_ZonaCombustible

    Dim odZonaCombustible As New d_ZonaCombustible

    Public Function Eliminar(ByVal oeZonaCombustible As EntidadesWCF.e_ZonaCombustible) As Boolean Implements Il_ZonaCombustible.Eliminar
        Try
            Return odZonaCombustible.Eliminar(oeZonaCombustible)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeZonaCombustible As EntidadesWCF.e_ZonaCombustible) As Boolean Implements Il_ZonaCombustible.Guardar
        Try
            If Validar(oeZonaCombustible) Then
                Return odZonaCombustible.Guardar(oeZonaCombustible)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeZonaCombustible As EntidadesWCF.e_ZonaCombustible) As System.Collections.Generic.List(Of EntidadesWCF.e_ZonaCombustible) Implements Il_ZonaCombustible.Listar
        Try
            Return odZonaCombustible.Listar(oeZonaCombustible)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeZonaCombustible As EntidadesWCF.e_ZonaCombustible) As EntidadesWCF.e_ZonaCombustible Implements Il_ZonaCombustible.Obtener
        Try
            Return odZonaCombustible.Obtener(oeZonaCombustible)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeZonaCombustible As EntidadesWCF.e_ZonaCombustible) As Boolean Implements Il_ZonaCombustible.Validar
        Try
            With oeZonaCombustible
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
