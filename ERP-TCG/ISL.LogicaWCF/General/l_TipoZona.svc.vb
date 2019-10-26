Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_TipoZona
    Implements Il_TipoZona

    Dim odTipoZona As New d_TipoZona

    Public Function Eliminar(ByVal oeTipoZona As e_TipoZona) As Boolean Implements Il_TipoZona.Eliminar
        Try
            Return odTipoZona.Eliminar(oeTipoZona)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoZona As e_TipoZona) As Boolean Implements Il_TipoZona.Guardar
        Try
            If Validar(oeTipoZona) Then
                Return odTipoZona.Guardar(oeTipoZona)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTipoZona As e_TipoZona) As System.Collections.Generic.List(Of e_TipoZona) Implements Il_TipoZona.Listar
        Try
            Return odTipoZona.Listar(oeTipoZona)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoZona As e_TipoZona) As e_TipoZona Implements Il_TipoZona.Obtener
        Try
            Return odTipoZona.Obtener(oeTipoZona)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeTipoZona As e_TipoZona) As Boolean Implements Il_TipoZona.Validar
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
