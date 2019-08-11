Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_TipoZona
    Implements Il_TipoZona

    Dim odTipoZona As New d_TipoZona

    Public Function Eliminar(ByVal oeTipoZona As EntidadesWCF.e_TipoZona) As Boolean Implements Il_TipoZona.Eliminar
        Try
            Return odTipoZona.Eliminar(oeTipoZona)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoZona As EntidadesWCF.e_TipoZona) As Boolean Implements Il_TipoZona.Guardar
        Try
            If Validar(oeTipoZona) Then
                Return odTipoZona.Guardar(oeTipoZona)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTipoZona As EntidadesWCF.e_TipoZona) As System.Collections.Generic.List(Of EntidadesWCF.e_TipoZona) Implements Il_TipoZona.Listar
        Try
            Return odTipoZona.Listar(oeTipoZona)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoZona As EntidadesWCF.e_TipoZona) As EntidadesWCF.e_TipoZona Implements Il_TipoZona.Obtener
        Try
            Return odTipoZona.Obtener(oeTipoZona)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeTipoZona As EntidadesWCF.e_TipoZona) As Boolean Implements Il_TipoZona.Validar
        Try
            With oeTipoZona
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
